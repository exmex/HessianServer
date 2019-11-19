using System.Net;
using System.Runtime.Remoting.Activation;

namespace HessianLoginServer.Packets
{
    public class C2S_MATCH_REQ_START
    {
        [Packet(CommonProtocolType._C2S_MATCH_REQ_START)]
        public static void OnC2S_MATCH_REQ_START(Packet packet)
        {
	        var ack = new Packet(CommonProtocolType._S2C_ROOM_MEMBER_INFO);
	        ack.Writer.Write((uint)1);
	        ack.Writer.WriteUnicodeStatic("Test", 17);
	        ack.Writer.Write((byte)1);
	        ack.Writer.Write((byte)1);
	        ack.Writer.Write((byte)1);
	        ack.Writer.Write((uint)1); // nPingTime
	        ack.Writer.Write((byte)2);
	        packet.SendBack(ack);
	        
            ack = new Packet(CommonProtocolType._S2C_MATCH_START);
            packet.SendBack(ack);
            
            ack = new Packet(CommonProtocolType._S2C_MATCH_INFO_HOST);
            ack.Writer.Write((uint)1);
            ack.Writer.Write((uint)0);
            ack.Writer.Write(IPAddress.Parse("127.0.0.1").Address);
            ack.Writer.Write((ushort)3306);
            ack.Writer.Write((byte)2); // MATCH_INFO_INVITE
            ack.Writer.Write(IPAddress.Parse("127.0.0.1").Address);
            ack.Writer.Write((ushort)3307);
            packet.SendBack(ack);
            
            /*
const BYTE	MATCH_INFO_LISTEN		= 0;		// È£½ºÆ® ¸®½¼
const BYTE	MATCH_INFO_CONNECT		= 1;		// Å¬¶óÀÌ¾ðÆ®°¡ È£½ºÆ®¿¡ Á¢¼Ó
const BYTE	MATCH_INFO_INVITE		= 2;		// È£½ºÆ®°¡ ¸ÕÀú Å¬¶óÀÌ¾ðÆ®¿¡ ¿¬°á
const BYTE	MATCH_INFO_RELAY		= 3;		// ¸±·¹ÀÌ¼­¹ö ÅëÇØ¼­ Åë½Å

PROTOCOL_DECLARE(S2C_MATCH_INFO_HOST, _S2C_MATCH_INFO_HOST)
{
public:
	UINT32	nHostPlayerUID;	// È£½ºÆ® Ç¥½Ã ¹× ÀÀ´ä ¼Óµµ Ç¥½Ã¿¡ ÇÊ¿ä.
	UINT32	nMatchKey;
	UINT32	nHostIP;
	UINT16	nHostPort;
	UINT8	nConnType;
	UINT32	nHostIP2;
	UINT16	nHostPort2;
};
             */
        }
    }
}