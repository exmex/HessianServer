namespace HessianLoginServer.Packets
{
    public class C2S_ROOM_TRAINING_START
    {
        [Packet(CommonProtocolType._C2S_ROOM_TRAINING_START)]
        public static void OnC2S_ROOM_TRAINING_START(Packet packet)
        {
            var ack = new Packet(CommonProtocolType._S2C_ROOM_CREATE_OK);
            ack.Writer.Write((uint)1);
	        
            ack.Writer.Write((byte)0); // MissionId
            ack.Writer.Write((byte)200); // MapId
            ack.Writer.Write((ushort)0); // Kill limit
            ack.Writer.Write((ushort)0); // Time limit
            ack.Writer.Write((byte)0); // Round limit
            ack.Writer.Write((byte)1); // Player limit
            ack.Writer.Write((byte)1); // Weapon allowance
	        
            var bs = new bool[8];
            bs[0] = false; // is private
            bs[1] = true; // level free
            bs[2] = true; // can intrude
            bs[3] = false; // auto balance
            bs[4] = false; // can observe
            bs[5] = true; // no team kill
            bs[6] = false; // minimumstart
            bs[7] = false; // auto change master
            ack.Writer.Write(BinaryWriterExt.ConvertToByte(bs)); // Options
            ack.Writer.Write((short)-1); // room name index
            ack.Writer.WriteUnicodeStatic("Test", 21);
	        
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


PROTOCOL_DECLARE(S2C_ROOM_CREATE_OK, _S2C_ROOM_CREATE_OK)
{
public:
	INT32	nEnteredRoomID;	// »ý¼ºµÈ ¹æ ¹øÈ£.
	_BATTLEROOM_OPTION	Option;	// ¹æ ¿É¼Ç Á¤º¸
};
             */
            
            /*var ack = new Packet(CommonProtocolType._C2S_ROOM_TRAINING_SUCCESS);
            packet.SendBack(ack);*/

            /*

PROTOCOL_DECLARE(C2S_ROOM_TRAINING_START, _C2S_ROOM_TRAINING_START)
{
public:
UINT8	bRankMode;	// °æÀï¸ðµå ¿©ºÎ.
};


PROTOCOL_DECLARE(C2S_ROOM_TRAINING_SUCCESS, _C2S_ROOM_TRAINING_SUCCESS)
{
public:
};

             */
        }
    }
}