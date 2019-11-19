using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace HessianLoginServer
{
    public class Client
    {
        private readonly NetworkStream _ns;
        private readonly DefaultServer _parent;
        private readonly TcpClient _tcp;

        private byte[] _buffer;
        private int _bytesToRead;

        private bool _connected;
        private ushort _packetLength, _packetId;

        public Client(TcpClient tcp, DefaultServer parent)
        {
            _tcp = tcp;
            _parent = parent;

            _ns = tcp.GetStream();
            _connected = true;
            
            /*
             * 	unsigned short	size;
	         * unsigned short	code;
             * S_C_ACCEPT
             * 	UINT8	nCode;	// Á¢¼ÓÇÑ ¼­¹ö ±¸ºÐ?
	         * WCHAR	szClientIP[16];	// Ã¤³Î ¼­¹ö¿¡¼­ º¸³»´Â °Í¸¸ À¯È¿
             */

            var ack = new Packet(CommonProtocolType._S2C_ACCEPT);
            if(parent.Port == 5585)
                ack.Writer.Write((byte)0);
            else
                ack.Writer.Write((byte)1);
            ack.Writer.WriteUnicodeStatic(EndPoint.Address.ToString(), 16);
            Send(ack);

            try
            {
                _buffer = new byte[4];
                _bytesToRead = _buffer.Length;
                _ns.BeginRead(_buffer, 0, 4, OnHeader, null);
            }
            catch (Exception ex)
            {
                KillConnection(ex);
            }
        }

        ~Client()
        {
            KillConnection();
        }

        public IPEndPoint EndPoint => _tcp.Client.RemoteEndPoint as IPEndPoint;

        private void OnHeader(IAsyncResult result)
        {
            try
            {
                _bytesToRead -= _ns.EndRead(result);
                if (_bytesToRead > 0)
                {
                    _ns.BeginRead(_buffer, _buffer.Length - _bytesToRead, _bytesToRead, OnHeader, null);
                    return;
                }

                _packetLength = BitConverter.ToUInt16(_buffer, 0);
                _packetId = BitConverter.ToUInt16(_buffer, 2);
                Console.WriteLine("[{0}] Received: {1} ({2})", _parent.Port, _packetId, Enum.GetName(typeof(CommonProtocolType), _packetId));

                _bytesToRead = _packetLength - 4;
                _buffer = new byte[_bytesToRead];
                _ns.BeginRead(_buffer, 0, _bytesToRead, OnData, null);
            }
            catch (Exception ex)
            {
                KillConnection(ex);
            }
        }

        private void OnData(IAsyncResult result)
        {
            try
            {
                _bytesToRead -= _ns.EndRead(result);
                if (_bytesToRead > 0)
                {
                    _ns.BeginRead(_buffer, _buffer.Length - _bytesToRead, _bytesToRead, OnData, null);
                    return;
                }

                var packet = new Packet(this, _packetId, _packetLength, _buffer);
                _parent.Parse(packet);

                _buffer = new byte[4];
                _bytesToRead = _buffer.Length;
                _ns.BeginRead(_buffer, 0, 4, OnHeader, null);
            }
            catch (Exception ex)
            {
                KillConnection(ex);
            }
        }

        public void Send(Packet packet)
        {
            var buffer = packet.Writer.GetBuffer();

            var bufferLength = buffer.Length;
            var length = (ushort) (bufferLength + 2); // Length includes itself
            
            Console.WriteLine("[{0}] Sending: {1}:{2} ({3})", _parent.Port, packet.Id, bufferLength, Enum.GetName(typeof(CommonProtocolType), packet.Id));

            try
            {
                _ns.Write(BitConverter.GetBytes(length), 0, 2);
                _ns.Write(buffer, 0, bufferLength);
            }
            catch (Exception ex)
            {
                KillConnection(ex);
            }
        }
        
        private void KillConnection(Exception ex)
        {
            Console.WriteLine("[{0}] {1}", _parent.Port, ex.ToString());
            if (ex is SocketException || ex is IOException)
            {
                KillConnection("Socket or IO Exception");
                return;
            }

            KillConnection(ex.Message + ": " + ex.StackTrace);
        }

        public void KillConnection(string reason = "")
        {
            //if (!_connected) return;
            _connected = false;
            _tcp.Close();
        }
    }
}