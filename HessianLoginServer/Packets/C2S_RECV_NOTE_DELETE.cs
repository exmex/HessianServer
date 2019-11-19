using System;

namespace HessianLoginServer.Packets
{
    public class C2S_RECV_NOTE_DELETE
    {
        [Packet(CommonProtocolType._C2S_RECV_NOTE_DELETE)]
        public static void OnC2S_RECV_NOTE_DELETE(Packet packet)
        {
            var noteId = packet.Reader.ReadUInt16();
            var ack = new Packet(CommonProtocolType._S2C_RECV_NOTE_DELETE);
            ack.Writer.Write((byte)0);
            ack.Writer.Write(noteId);
            packet.SendBack(ack);
            /*

PROTOCOL_DECLARE(S2C_RECV_NOTE_DELETE, _S2C_RECV_NOTE_DELETE)
{
public:	
	UINT8	result;    // 0.½ÇÆÐ 1.¼º°ø

	UINT32	noteID;	
};
             */
        }
    }
}