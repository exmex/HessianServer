using System.ComponentModel;
using System.Net;
using System.Runtime.Remoting.Activation;

namespace HessianLoginServer.Packets
{
    public class C2S_ROOM_SWITCH_TEAM
    {
        [Packet(CommonProtocolType._C2S_ROOM_SWITCH_TEAM)]
        public static void OnC2S_ROOM_SWITCH_TEAM(Packet packet)
        {
            var ack = new Packet(CommonProtocolType._S2C_ROOM_MEMBER_INFO);
            ack.Writer.Write((uint)1);
            ack.Writer.WriteUnicodeStatic("Test", 17);
            ack.Writer.Write((byte)1);
            ack.Writer.Write((byte)1);
            ack.Writer.Write((byte)1);
            ack.Writer.Write((uint)1); // nPingTime
            ack.Writer.Write((byte)0);
            packet.SendBack(ack);
            
            /*
enum EPlayerStatusInRoom
{
    EBRPS_Waiting           =0,
    EBRPS_Ready             =1,
    EBRPS_Loading           =2,
    EBRPS_Playing           =3,
    EBRPS_Shop              =4,
    EBRPS_Inventory         =5,
    EBRPS_Upgrade           =6,
    EBRPS_Reserved          =7,
    EBRPS_MAX               =8,
};
struct _ROOM_MEMBER_DETAIL
{
	UINT8				nTeamID;
	UINT8				nLevel;
	UINT8				bHostPlayer;
	UINT32				nPingTime;
	UINT8				nPlayerStatusInRoom; // EPlayerStatusInRoom °ª Áß ÇÏ³ª.
};

PROTOCOL_DECLARE(S2C_ROOM_MEMBER_INFO, _S2C_ROOM_MEMBER_INFO)
{
public:
	UINT32	nPlayerUID;	// ´Ù¸¥ Ä³¸¯ÅÍ´Â ÀÌ°ÍÀ¸·Î ¼­·Î ±¸ºÐ.
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// ÄÝ»çÀÎ
	_ROOM_MEMBER_DETAIL	Detail;	// »ó¼¼ Á¤º¸
};
             */
        }
    }
}