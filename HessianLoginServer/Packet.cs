using System;
using System.IO;

namespace HessianLoginServer
{
    /*
struct	MSG_HEADER
{
	unsigned short	size;
	unsigned short	code;	
};
     */
    public class Packet
    {
        public readonly byte[] Buffer;
        public readonly ushort Id;
        public readonly ushort Size;
        public readonly BinaryReaderExt Reader;
	
        public readonly BinaryWriterExt Writer;
        public readonly Client Sender;
	
        public Packet(CommonProtocolType id)
        {
            Writer = new BinaryWriterExt(new MemoryStream());
            Id = (ushort)id;
	
            Writer.Write((ushort)id);
        }
	
        public Packet(Client sender, ushort id, ushort size, byte[] buffer)
        {
            Sender = sender;
            Buffer = buffer;
            Id = id;
            Size = size;
            Reader = new BinaryReaderExt(new MemoryStream(Buffer));
        }
	        
        public void SendBack(Packet packet)
        {
            Sender.Send(packet);
        }
    }
	
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class PacketAttribute : Attribute
    {
        public PacketAttribute(CommonProtocolType id)
        {
            Id = (ushort)id;
        }
	
        public ushort Id { get; }
    }
}