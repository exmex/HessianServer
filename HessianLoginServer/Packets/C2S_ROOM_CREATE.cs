namespace HessianLoginServer.Packets
{
    public class C2S_ROOM_CREATE
    {
        [Packet(CommonProtocolType._C2S_ROOM_CREATE)]
        public static void OnC2S_ROOM_CREATE(Packet packet)
        {
	        var missionId = packet.Reader.ReadByte();
	        var mapId = packet.Reader.ReadByte();
	        var killLimit = packet.Reader.ReadUInt16();
	        var timeLimit = packet.Reader.ReadUInt16();
	        var roundLimit = packet.Reader.ReadByte();
	        var playerLimit = packet.Reader.ReadByte();
	        var weaponAllowance = packet.Reader.ReadByte();
	        
	        var flags = packet.Reader.ReadByte();
	        var roomNameIndex = packet.Reader.ReadByte();

	        var roomName = packet.Reader.ReadUnicodeStatic(21);
	        
	        var ack = new Packet(CommonProtocolType._S2C_ROOM_CREATE_OK);
	        ack.Writer.Write((uint)1);
	        
	        ack.Writer.Write(missionId);
	        ack.Writer.Write(mapId);
	        ack.Writer.Write(killLimit);
	        ack.Writer.Write(timeLimit);
	        ack.Writer.Write(roundLimit);
	        ack.Writer.Write(playerLimit);
	        ack.Writer.Write(weaponAllowance);
	        
	        ack.Writer.Write(flags);
	        ack.Writer.Write(roomNameIndex);
	        ack.Writer.WriteUnicodeStatic(roomName, 21);
	        
	        packet.SendBack(ack);
	        
	        ack = new Packet(CommonProtocolType._S2C_ROOM_MEMBER_INFO);
	        ack.Writer.Write((uint)1);
	        ack.Writer.WriteUnicodeStatic("Test", 17);
	        ack.Writer.Write((byte)1);
	        ack.Writer.Write((byte)1);
	        ack.Writer.Write((byte)1);
	        ack.Writer.Write((uint)1); // nPingTime
	        ack.Writer.Write((byte)0);
	        packet.SendBack(ack);
            /*
             MAX_ROOM_NAME = 20
struct _BATTLEROOM_OPTION
{
	UINT8	nMissionID;			// TODO: ÇÊ¿ä ¾ø´Â Ç×¸ñ. »èÁ¦ÇÒ °æ¿ì ±¸ÇöÀÌ Á¶±Ý º¹ÀâÇØÁö¹Ç·Î Á¸¼Ó½ÃÅ³Áö ¿©ºÎ °áÁ¤ ÇÊ¿ä.
	UINT8	nMapID;
	UINT16	nKillLimit;
	UINT16	nTimeLimit;
	UINT8	nRoundLimit;
	UINT8	nPlayerLimit;
	UINT8	nWeaponAllowance;

	UINT8	bIsPrivate : 1;
	UINT8	bLevelFree : 1;
	UINT8	bCanIntrude : 1;
	UINT8	bAutoBalance : 1;
	UINT8	bCanObserve : 1;
	UINT8	bNoTeamKill : 1;	// ÈÆ·ÃÀåÀÏ °æ¿ì¿¡ ÇÑÇÏ¿© °æÀï¸ðµå(0: ºñ°æÀï¸ðµå, 1: °æÀï¸ðµå) ¼³Á¤°ªÀ¸·Î »ç¿ë. ÇÊµå¸¦ Ãß°¡ÇÏ´Â °ÍÀÌ ¿øÄ¢ÀÌ³ª È£È¯¼º ¹®Á¦°¡ ¹ß»ýÇÏ¹Ç·Î ÀÌ·¸°Ô Ã³¸®. 
	UINT8	bMinimumStart : 1;
	UINT8	bAutoChangeMaster : 1;

	INT8	nRoomNameIndex;		// -1 ÀÏ °æ¿ì ÀÓÀÇ ¼öÁ¤µÈ ¹æÁ¦¸ñ. ±× ¿Ü¿¡´Â ¹æÁ¦¸ñÀ» ÁÖ°í¹ÞÁö ¾Ê°í ÀÌ »öÀÎ°ªÀ» »ç¿ëÇÑ´Ù.
	WCHAR	szRoomName[MAX_ROOM_NAME+1];	// °¡º¯±æÀÌ ¹æÁ¦¸ñÀÌ¹Ç·Î Ç×»ó ¸¶Áö¸· ¸â¹öº¯¼ö·Î ÁöÁ¤ÇØ¾ß ÇÑ´Ù.
};


PROTOCOL_DECLARE(C2S_ROOM_CREATE, _C2S_ROOM_CREATE)
{
public:
	_BATTLEROOM_OPTION	Option;	// ¹æ ¿É¼Ç Á¤º¸
	WCHAR	szRoomPassword[MAX_ROOM_PASSWORD+1];	// ºñ¹Ð¹æÀÏ °æ¿ì ºñ¹Ð¹øÈ£.
};


PROTOCOL_DECLARE(S2C_ROOM_CREATE_OK, _S2C_ROOM_CREATE_OK)
{
public:
	INT32	nEnteredRoomID;	// »ý¼ºµÈ ¹æ ¹øÈ£.
	_BATTLEROOM_OPTION	Option;	// ¹æ ¿É¼Ç Á¤º¸
};
             */
        }
    }
}