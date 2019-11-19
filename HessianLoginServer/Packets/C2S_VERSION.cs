using System;

namespace HessianLoginServer
{
    public class C2S_VERSION
    {
        [Packet(CommonProtocolType._C2S_VERSION)]
        public static void OnC2S_VERSION(Packet packet)
        {
            Console.WriteLine("Handling Version");
            /*
             * 	WORD	nMajorVer;
	WORD	nMinorVer;
             */
            var major = packet.Reader.ReadUInt16();
            var minor = packet.Reader.ReadUInt16();
            Console.WriteLine("Version: {0}.{1}", major, minor);
        }
    }
}