using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;

namespace HessianLoginServer
{
    public class DefaultServer
    {
        /// <summary>
        /// A list of all connected clients
        /// </summary>
        private readonly List<Client> _clients;

        /// <summary>
        /// Does this server require an exchange?
        /// </summary>
        private readonly bool _exchangeRequired;

        /// <summary>
        /// The underlaying TCP Listener
        /// </summary>
        private readonly TcpListener _listener;

        /// <summary>
        /// Contains all parsers and their function
        /// </summary>
        private readonly Dictionary<ushort, Action<Packet>> _parsers;

        /// <summary>
        /// The port the server runs on
        /// </summary>
        public readonly int Port;

        /// <summary>
        /// Specifies wether or not we should dump incoming packets to a file!
        /// </summary>
        public static bool DumpIncoming { get; set; }

        /// <summary>
        /// Specifies wether or not we should dump outgoing packets to a file!
        /// </summary>
        public static bool DumpOutgoing { get; set; }

        public DefaultServer(int port, bool exchangeRequired = true)
        {
            _parsers = new Dictionary<ushort, Action<Packet>>();
            _clients = new List<Client>();
            Port = port;
            _listener = new TcpListener(IPAddress.Any, port);
            _exchangeRequired = exchangeRequired;

            var i = 0;
            i += AddAllMethodsFromType(Assembly.GetEntryAssembly().GetTypes());
            i += AddAllMethodsFromType(Assembly.GetExecutingAssembly().GetTypes());
        }

        private int AddAllMethodsFromType(IEnumerable<Type> types)
        {
            var i = 0;
            foreach (var type in types)
                foreach (var method in type.GetMethods())
                    foreach (var boxedAttrib in method.GetCustomAttributes(typeof(PacketAttribute), false))
                    {
                        var attrib = boxedAttrib as PacketAttribute;

                        if (attrib == null) continue;
                        var id = attrib.Id;
                        var parser = (Action<Packet>) Delegate.CreateDelegate(typeof(Action<Packet>), method);

                        SetParser(id, parser);

#if DEBUG
                        i++;
#endif
                    }

            return i;
        }

        public void Start()
        {
            _listener.Start();
            _listener.BeginAcceptTcpClient(OnAccept, _listener);
        }

        private void OnAccept(IAsyncResult result)
        {
            var tcpClient = _listener.EndAcceptTcpClient(result);
            var client = new Client(tcpClient, this);

            Console.WriteLine("[{0}] New client {1}", Port, client.EndPoint.Address);

            _clients.Add(client);
            _listener.BeginAcceptTcpClient(OnAccept, _listener);
        }

        private void SetParser(ushort id, Action<Packet> parser)
        {
            _parsers[id] = parser;
        }

        public void Parse(Packet packet)
        {
            // Handle the packet.
            if (_parsers.ContainsKey(packet.Id))
            {
                Console.WriteLine("[{0}] Received packet {2}:{1} ({3}).",
                    Port, packet.Size, Enum.GetName(typeof(CommonProtocolType), packet.Id), packet.Id);
                _parsers[packet.Id](packet);
            }
            else
            {
                Console.WriteLine("!!!! [{0}] Received unhandled packet {2}:{1} ({3}).",
                    Port, packet.Size, Enum.GetName(typeof(CommonProtocolType), packet.Id), packet.Id);
            }
        }

        /// <summary>
        /// Gets all clients connected to the server
        /// </summary>
        /// <returns>A collection of all clients connected to the server</returns>
        public IEnumerable<Client> GetClients() => _clients.ToArray();

        /// <summary>
        /// Broadcasts a packet to all clients on the server, excluding exclude if specified
        /// </summary>
        /// <param name="packet">The packet to broadcast</param>
        /// <param name="exclude">The client to exclude</param>
        public void Broadcast(Packet packet, Client exclude = null)
        {
            foreach (var client in GetClients())
                if (exclude == null || client != exclude)
                    client.Send(packet);
        }

        /// <summary>
        /// Broadcasts a packet to all clients on the server, excluding exclude if specified
        /// </summary>
        /// <param name="packet">The packet to broadcast</param>
        /// <param name="exclude">An array of clients that should be exluded</param>
        public void Broadcast(Packet packet, Client[] exclude)
        {
            foreach (var client in GetClients())
                if (!exclude.Contains(client))
                    client.Send(packet);
        }

        /// <summary>
        /// Broadcasts a packet to all clients in the same area as areaId
        /// TODO: Currently broadcasts everywhere.
        /// </summary>
        /// <param name="areaId"></param>
        /// <param name="packet"></param>
        public void BroadcastArea(int areaId, Packet packet)
        {
            foreach (var client in GetClients())
            {
                client.Send(packet);
            }
        }
    }
}