using System.Diagnostics.Eventing.Reader;

namespace HessianLoginServer.Packets
{
    public class C2S_RECV_NOTE_LIST
    {
        [Packet(CommonProtocolType._C2S_RECV_NOTE_LIST)]
        public static void OnC2S_RECV_NOTE_LIST(Packet packet)
        {
	        var pageNo = packet.Reader.ReadUInt16();
            var ack = new Packet(CommonProtocolType._S2C_RECV_NOTE_LIST);
            ack.Writer.Write((byte)0);
            ack.Writer.Write(pageNo);
            //ack.Writer.Write((byte)0); // allread
            ack.Writer.Write((ushort)0); // totalSize
            ack.Writer.Write((ushort)0); // size
            
            packet.SendBack(ack);
            
            /*

struct _NOTE_INFO
{	
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];
	UINT32	sendPlayerID;
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];	

	UINT32	noteID;
	UINT8	isRead;
	UINT8	replyOption;
	UINT8	replyResult;
	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];
	UINT64  createDate;
};

PROTOCOL_DECLARE(S2C_RECV_NOTE_LIST, _S2C_RECV_NOTE_LIST)
{
public:	
	UINT8	result;    // 0.½ÇÆÐ 1.¼º°ø

	UINT16	pageNO;
	UINT8	allRead;     // 0.¸ðµÎ ÀÐÁö¾ÊÀ½ 1.¸ðµÎ ÀÐÀ½ 
	UINT16	totalSize;
	UINT16  size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};
 
             */
        }
    }
}