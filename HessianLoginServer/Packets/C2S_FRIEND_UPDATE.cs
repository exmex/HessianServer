namespace HessianLoginServer.Packets
{
    public class C2S_FRIEND_UPDATE
    {
	    [Packet(CommonProtocolType._C2S_FRIEND_UPDATE)]
        public static void OnC2S_FRIEND_UPDATE(Packet packet)
        {
	        /*var playerId = packet.Reader.ReadUInt32();
	        var callSign = packet.Reader.ReadUnicodeStatic(17);
	        var status = packet.Reader.ReadByte();
	        var level = packet.Reader.ReadUInt16();
	        var ack = new Packet(CommonProtocolType._S2C_FRIEND_UPDATE);
	        ack.Writer.Write((byte)0);
	        ack.Writer.Write(playerId);
	        ack.Writer.Write(status);
	        packet.SendBack(ack);*/
            /*
             const NICKNAME_LEN_MAX = 16;
// Ä£±¸¸¦ °»½ÅÇÑ´Ù.
PROTOCOL_DECLARE(C2S_FRIEND_UPDATE, _C2S_FRIEND_UPDATE)
{
public:	
	UINT32	fPlayerID;
	WCHAR	fCallsign[NICKNAME_LEN_MAX+1];	
	UINT8	status;
	UINT16	level;
};

PROTOCOL_DECLARE(S2C_FRIEND_UPDATE, _S2C_FRIEND_UPDATE)
{
public:	
	UINT8	result;			// 0.½ÇÆÐ 1.¼º°ø
	UINT32	fPlayerID;
	UINT8	status;
};
             */
        }
    }
}