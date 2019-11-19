namespace HessianLoginServer.Packets
{
    public class C2S_SEND_NOTE_LIST
    {

        [Packet(CommonProtocolType._C2S_SEND_NOTE_LIST)]
        public static void OnC2S_SEND_NOTE_LIST(Packet packet)
        {
	        var pageNo = packet.Reader.ReadUInt16();
	        var ack = new Packet(CommonProtocolType._S2C_SEND_NOTE_LIST);
	        ack.Writer.Write((uint)0); // playerId
	        ack.Writer.Write(pageNo);
	        ack.Writer.Write((ushort)0); // totalSize
	        ack.Writer.Write((ushort)0); // size
            
	        packet.SendBack(ack);
            /*

PROTOCOL_DECLARE(S2C_SEND_NOTE_LIST, _S2C_SEND_NOTE_LIST)
{
public:
	UINT32	playerID;
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16  size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};
             */
        }
    }
}