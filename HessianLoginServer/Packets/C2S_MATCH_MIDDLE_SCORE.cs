namespace HessianLoginServer.Packets
{
    /*public class C2S_MATCH_MIDDLE_SCORE
    {
        [Packet(CommonProtocolType._C2S_MATCH_MIDDLE_SCORE)]
        public static void OnC2S_MATCH_MIDDLE_SCORE(Packet packet)
        {
            var ack = new Packet(CommonProtocolType._S2C_MATCH_MIDDLE_SCORE);
            ack.Writer.Write((uint)0);
            ack.Writer.Write((byte)1); // level
            ack.Writer.WriteUnicodeStatic("", 33);
            ack.Writer.WriteUnicodeStatic("Test", 33);
            
            ack.Writer.Write((uint)0);
            ack.Writer.Write((ushort)0);
            ack.Writer.Write((ushort)0);
            
            ack.Writer.Write((uint)9999);
            ack.Writer.Write((byte)0);
            packet.SendBack(ack);
            
            /*
             
const int	ACCOUNT_LEN_MAX			= 32;
// ¸ÅÄ¡ µµÁßÀÇ °á°ú ³»¿ë
struct _MATCH_MIDDLE_SCORE
{
	UINT32	playerID;
	UINT8	level;							// ·¹º§
	WCHAR	clanName[ACCOUNT_LEN_MAX+1];	// Å¬·£ÀÌ¸§
	WCHAR	callSign[ACCOUNT_LEN_MAX+1];	// ÄÝ½ÎÀÎ

	UINT32	contribution;					// ±â¿©µµ
	UINT16	killCount;						// Å³ È½¼ö
	UINT16	deathCount;						// µ¥½º È½¼ö 
	
	UINT32	money;							// º¸»ó±Ý 
	UINT8	teamID;							// ÆÀ ¿þ½ºÆ® 0, ·çÆä
};
PROTOCOL_DECLARE(S2C_MATCH_MIDDLE_SCORE, _S2C_MATCH_MIDDLE_SCORE)
{
public:
	_MATCH_MIDDLE_SCORE		MissionMiddleScore[16];
};
             /
        }
    }*/
}