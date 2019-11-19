using System;

namespace HessianLoginServer.Packets
{
    public class C2S_FRIEND_LIST
    {
        [Packet(CommonProtocolType._C2S_FRIEND_LIST)]
        public static void OnC2S_FRIEND_LIST(Packet packet)
        {
            var pageNo = packet.Reader.ReadUInt16();
            var ack = new Packet(CommonProtocolType._S2C_FRIEND_LIST);
            ack.Writer.Write(pageNo);
            ack.Writer.Write((uint)0); // totalsize
            ack.Writer.Write((uint)0); // size
            
            packet.SendBack(ack);
            /*

struct _FRIEND_INFO
{	
	UINT32	playerID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	
	UINT8	status;	// 0.ºñÁ¢¼Ó 1.Á¢¼Ó	
	UINT16	level;  // player level	
	UINT64  createDate;
};
PROTOCOL_DECLARE(S2C_FRIEND_LIST, _S2C_FRIEND_LIST)
{
public:	
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16	size;

	_FRIEND_INFO  friendInfo[FRIEND_LIST_LOAD_MAX];
};
             */
        }
    }
}