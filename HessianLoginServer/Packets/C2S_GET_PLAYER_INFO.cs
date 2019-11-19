using System;
using HessianLoginServer.ServerPackets;

namespace HessianLoginServer.Packets
{
    public class C2S_GET_PLAYER_INFO
    {
        [Packet(CommonProtocolType._C2S_GET_PLAYER_INFO)]
        public static void OnC2S_GET_PLAYER_INFO(Packet packet)
        {
            //packet.SendBack(new Packet(CommonProtocolType._S2C_NEW_PLAYER));

            var ack = new Packet(CommonProtocolType._S2C_INVENTORY);
            var packetInv = new S2C_INVENTORY
            {
                PrimarySlot = 0
            };
            var characterInfo = new CharacterInfo()
            {
                ExpirationTime = ulong.MaxValue - 1,
                CharAcCode = 1,
                TattooCode = 1,
                SaleType = 1,
                ProtectionItemId = new ItemId(1, 2000),
                SurvivalItemId = new ItemId(2, 3000),
                TacticalItemId = new ItemId(3, 3000),
                TrainingItemId = new ItemId(4, 3000),
                CTSItemId = new ItemId(5, 4000),
            };
            packetInv.Characters.Add(characterInfo);
            packetInv.Inventory.Add(new Item(1, 2000));
            packetInv.Inventory.Add(new Item(2, 3000));
            packetInv.Inventory.Add(new Item(3, 3000));
            packetInv.Inventory.Add(new Item(4, 3000));
            packetInv.Inventory.Add(new Item(5, 4000));
            packetInv.Inventory.Add(new Item(6, 14012));
            ack.Writer.Write(packetInv);
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


struct	_CHARAC_INFO
{
	UINT64	ExpirationTime;		// À¯È¿ ±â°£, ³â/¿ù/ÀÏ/½Ã/ºÐ
	UINT8	nCharacCode;		// Ä³¸¯ÅÍ ÄÚµå
	UINT8	nTattooCode;		// ¹®½Å ÄÚµå
	UINT8	nSaleType;			// ÆÇ¸Å Å¸ÀÔ
	_ITEM_ID	nProtectionItemID;	// ¹æ¾î±¸
	_ITEM_ID	nSurvialItemID;		// »ýÁ¸ STOG
	_ITEM_ID	nTacticalItemID;	// Àü¼ú STOG
	_ITEM_ID	nTrainingItemID;	// ´Ü·Ã STOG
	_ITEM_ID	nCTSItemID;		// CTS
};

struct	_PEER_ITEM_INFO
{
	UINT32		nItemUID;
	UINT16		nItemCode;
	UINT8		nStatus;		// Âø¿ë,¹è³¶
};


PROTOCOL_DECLARE(S2C_INVENTORY, _S2C_INVENTORY)
{
public:
	UINT8	nPrimarySlot;
	UINT8	nOpenSlotCount;
	UINT8	nItemCount;
	_CHARAC_INFO	CharacInven[ CHARAC_INVEN_SLOT_MAX ];	//  = 5, °íÁ¤ »çÀÌÁî
	_ITEM_INFO	ItemInven[ ITEM_INVEN_SLOT_MAX ];	// °¡º¯ »çÀÌÁî
};
ITEM_INVEN_SLOT_MAX = 100
             */


            ack = new Packet(CommonProtocolType._S2C_PLAYER_INFO);
            ack.Writer.Write((uint) 0);
            ack.Writer.WriteUnicodeStatic("Test", 17);
            ack.Writer.Write((uint) 99999); // money
            ack.Writer.Write((uint) 0); // EXP
            ack.Writer.Write((uint) 0); // Options?
            ack.Writer.Write((uint) 0); // ClanUID
            ack.Writer.Write((byte) 0); // NetworkType?
            ack.Writer.Write((byte) 0); // isPCBang
            ack.Writer.Write((byte) 0); // Event reward
            packet.SendBack(ack);
            /*
PROTOCOL_DECLARE(S2C_PLAYER_INFO, _S2C_PLAYER_INFO)
{
public:
	UINT32	nPlayerUID;
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// ÄÝ½ÎÀÎ
	UINT32	nGameMoney;
	UINT32	nExp;
	UINT32	nOptions;
	UINT32	nClanUID;
	UINT8	nNetwokType;
	UINT8	bIsPCBang;
	UINT8	bEventReward;
};
             */

            ack = new Packet(CommonProtocolType._S2C_IDCARD_FRONTSIDE);
            ack.Writer.Write((uint) 0);
            ack.Writer.Write((byte) 0); // level
            ack.Writer.Write((byte) 1); // character code
            ack.Writer.Write((byte) 1); // current channel server id
            ack.Writer.Write((byte) 1); // current channel id
            ack.Writer.Write((uint) 128u); // first login 
            ack.Writer.Write((ulong) 128u); // total login 
            ack.Writer.Write((uint) 0); // total kill count 
            ack.Writer.Write((uint) 0); // total death count 
            ack.Writer.Write((uint) 0); // ace kill 
            ack.Writer.Write((uint) 0); // headshot kill 
            ack.Writer.Write((ushort) 0); // win count 
            ack.Writer.Write((ushort) 0); // lose  count 
            ack.Writer.Write((ushort) 0); // desertion count 
            ack.Writer.WriteUnicodeStatic("", 17);
            packet.SendBack(ack);
/*
PROTOCOL_DECLARE(S2C_IDCARD_FRONTSIDE, _S2C_IDCARD_FRONTSIDE)
{
public:
	UINT32	nPlayerUID;
	UINT8	nLevel;
	UINT8	nCharacterCode;
	UINT8	nCurrentChannelServerID;	// 접속 서버 ID
	UINT8	nCurrentChannelID;	// 접속 채널 ID
	UINT32	nFirstLoginDate;	// 게임에 최초 로그인한 날짜
	UINT64	TotalLoggedInTime;	// 총 접속시간. (초)
	UINT32	nTotalKillCount;
	UINT32	nTotalDeathCount;
	UINT32	nAceKillCount;
	UINT32	nHeadShotKillCount;
	UINT16	nWinCount;
	UINT16	nDrawCount;
	UINT16	nLoseCount;
	UINT16	nDesertionCount;	// 탈영
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	// 클랜이름
};
 */
            ack = new Packet(CommonProtocolType._S2C_IDCARD_BACKSIDE);
            ack.Writer.Write((uint) 0);
            ack.Writer.Write((ulong) 0);
            for (int i = 0; i < 10; i++)
            {
                ack.Writer.Write((ushort) 0); // Win Count
            }

            for (int i = 0; i < 10; i++)
            {
                ack.Writer.Write((ushort) 0); // draw Count
            }

            for (int i = 0; i < 10; i++)
            {
                ack.Writer.Write((ushort) 0); // lose Count
            }

            for (int i = 0; i < 10; i++)
            {
                ack.Writer.Write((uint) 0); // kill Count
            }

            packet.SendBack(ack);

/*

PROTOCOL_DECLARE(S2C_IDCARD_BACKSIDE, _S2C_IDCARD_BACKSIDE)
{
public:
	UINT32	nPlayerUID;
	UINT64	LastLoginTimestamp;	// 최근 로그인 시각.
	UINT64	LastLogoutTimestamp;	// 최근 로그아웃 시각.
	UINT16	WinCount[MISSION_MAX];	// 미션 별 승
	UINT16	DrawCount[MISSION_MAX];	// 미션 별 무
	UINT16	LoseCount[MISSION_MAX];	// 미션 별 패
	UINT32	KillCount[KILL_TYPE_MAX];
};
 */

            ack = new Packet(CommonProtocolType._S2C_UPDATE_CHARAC_INFO);
            ack.Writer.Write((byte) 0);
            ack.Writer.Write(characterInfo);
            packet.SendBack(ack);
            /*

PROTOCOL_DECLARE(S2C_UPDATE_CHARAC_INFO, _S2C_UPDATE_CHARAC_INFO)
{
public:
	INT8	nCharacSlot;	// 캐릭터 슬롯
	_CHARAC_INFO	CharacInven;
};
             */
        }
    }
}