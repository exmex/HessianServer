using System;

namespace HessianLoginServer.Packets
{
    public class C2S_ENTER_SERVER
    {
        [Packet(CommonProtocolType._C2S_ENTER_SERVER)]
        public static void OnC2S_ENTER_SERVER(Packet packet)
        {
            /*
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// °èÁ¤
	UINT64	nAuthKey;	// ·Î±ä ¼­¹ö·Î ºÎÅÍ ¹ß±Þ ¹ÞÀº ÀÎÁõÅ°
	UINT32	nPlayerUID;
	UINT32	nLocalIP;	// ·ÎÄÃ ¾ÆÀÌÇÇ Á¤º¸
	UINT16	nProtocolVer;
             */

            var accountName = packet.Reader.ReadUnicodeStatic(33);
            var authKey = packet.Reader.ReadUInt64();
            var playerUid = packet.Reader.ReadUInt32();
            var localIp = packet.Reader.ReadUInt32();
            var protocolVer = packet.Reader.ReadUInt16();
            Console.WriteLine("{0} - {1}", accountName, playerUid);

            var ack = new Packet(CommonProtocolType._S2C_ENTER_SERVER_OK);
            packet.SendBack(ack);
        }
    }
}