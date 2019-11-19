using System;

namespace HessianLoginServer.Packets
{
    public class C2S_BUY_ITEM
    {
	    /*
			Log: Can't find item infomation [CreateInvItem] 65535
	     */
	    [Packet(CommonProtocolType._C2S_BUY_ITEM)]
        public static void OnC2S_BUY_ITEM(Packet packet)
        {
	        var itemCode = packet.Reader.ReadUInt16();
	        var buyType = packet.Reader.ReadByte();
	        
	        var ack = new Packet(CommonProtocolType._S2C_BUY_ITEM_OK);

	        ack.Writer.Write(new Item(6, itemCode));
	        ack.Writer.Write((uint)5);
	        packet.SendBack(ack);
/*
 union	_ITEM_LIMIT
{
	UINT64		nLimit;
	UINT64		nExpirationTime;
	UINT16		nDurability;
	//UINT8		nRemainCount;
};
union _ITEM_BIT_INFO
{
	UINT8	Info;
	struct _Detail
	{
		UINT8	SaleTypeBits : 4;
		UINT8	StatusBits : 3;
		UINT8	bExpiredBits : 1;
	}Detail;
};

struct	_ITEM_ID
{
	UINT32		nItemUID;
	UINT16		nItemCode;
};
struct	_ITEM_INFO
{
	_ITEM_LIMIT		ItemLimit;
	_ITEM_ID		ItemID;
	_ITEM_BIT_INFO	ItemBitInfo;
};

PROTOCOL_DECLARE(C2S_BUY_ITEM, _C2S_BUY_ITEM)
{
public:
	UINT16	nItemCode;	// ±¸ÀÔÇÒ ¾ÆÀÌÅÛ ÄÚµå
	UINT8	nBuyType;	// ±¸ÀÔ ÄÚµå
};


PROTOCOL_DECLARE(S2C_BUY_ITEM_OK, _S2C_BUY_ITEM_OK)
{
public:
	_ITEM_INFO	ItemInfo;	// ±¸ÀÔÇÑ ¾ÆÀÌÅÛ Á¤º¸
	UINT32	nGameMoney;	// ±¸ÀÔÇÏ°í ³²Àº µ· (ÇöÀç ¼ÒÁö±Ý)
};

*/
        }
    }
}