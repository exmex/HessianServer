/*
#ifndef		__COMMON_DEFINES_INCLUDE__
#define		__COMMON_DEFINES_INCLUDE__

#pragma once

const int	COOKIE_SIZE				= 512;		// ÄíÅ° ±æÀÌ°¡ °¡º¯ÀÌ¹Ç·Î ÃÖ´ë°ªÀº ¿©À¯ÀÖ°Ô µÐ´Ù.
const int	IP_STRING_LEN_MAX		= 15;

const int	HESSIAN_PACKET_SIZE_MAX = 1024;
const int	C2S_PACKET_SIZE_MAX = 1024;
const int	S2C_PACKET_SIZE_MAX = 2048;

const BYTE	INVALID_CHANNEL_ID		= 255;		// Ã¤³Î
const BYTE	INVALID_TEAM_ID			= 255;		// ÆÀ
const int	INVALID_ROOM_ID			= -1;		// ¹æ
const int	INVALID_SLOT_INDEX		= -1;		// Ä³¸¯ÅÍ¿Í ¾ÆÀÌÅÛ ½½·Ô
const DWORD INVALID_MONEY			= (DWORD)(-1);	// µ·

const int	MAX_SERVER_CNT			= 10;		// Ã¤³Î ¼­¹ö ÃÖ´ë °³¼ö
const int	MAX_CHANNEL_CNT			= 10;		// ¼­¹ö º° Ã¤³Î ÃÖ´ë °³¼ö
const int	MAX_MEMBER_PER_MESSAGE	= 20;		// ¸Þ½ÃÁö ´ç Àü¼Û °¡´ÉÇÑ ÃÖ´ë ÇÃ·¹ÀÌ¾î ¼ö.
const int	MAX_ROOM_PER_CHANNEL	= 100;		// Ã¤³Î ´ç ¸¸µé ¼ö ÀÖ´Â ÃÖ´ë ¹æ °³¼ö.
const int	MAX_ROOMINFO_PER_SEND	= 2;		// ÇÃ·¹ÀÌ¾î¿¡°Ô ÇÑ¹ø¿¡ º¸³¾ ¹æÁ¤º¸ °³¼ö.
const int	MAX_ROOM_PER_MESSAGE	= 20;		// ¸Þ½ÃÁö ´ç Àü¼Û °¡´ÉÇÑ ÃÖ´ë ¹æ °³¼ö.
const int	MAX_PLAYER_IN_ROOM		= 16;		// °üÀüÀÚ¸¦ Á¦¿ÜÇÏ°í ÇÑ ¹æ¿¡¼­ ÇÃ·¹ÀÌ °¡´ÉÇÑ ÃÖ´ë ÇÃ·¹ÀÌ¾î ¼ö.
const int	MAX_PLAYER_PER_TEAM		= 8;		// ÇÑ ÆÀ¿¡¼­ ÇÃ·¹ÀÌ °¡´ÉÇÑ ÃÖ´ë ÇÃ·¹ÀÌ¾î ¼ö.

const int	ACCOUNT_LEN_MIN			= 6;		// °èÁ¤ ±æÀÌ
const int	ACCOUNT_LEN_MAX			= 32;

const int	PASSWD_LEN_MIN			= 6;		// ºñ¹ø ±æÀÌ
const int	PASSWD_LEN_MAX			= 12;

const int	NICKNAME_LEN_MIN		= 3;		// ´Ð³×ÀÓ ±æÀÌ
const int	NICKNAME_LEN_LIMIT		= 10;		// ½ÇÁ¦ Á¦ÇÑ
const int	NICKNAME_LEN_MAX		= 16;		// ÇÁ·ÎÅäÄÝ¿¡¼­ ÃÖ´ë ±æÀÌ »ç¿ë

const int   MAX_ROOM_NAME			= 20;		// ¹æ ÀÌ¸§ ±æÀÌ
const int	MAX_MSG_LEN				= 64;		// ½Ã½ºÅÛ ¸Þ½ÃÁö ±æÀÌ
const int   MAX_CHAT_LEN			= 40;		// Ã¤ÆÃ ¸Þ½ÃÁö ±æÀÌ

const int	CLAN_NAME_LEN_MIN		= 2;		// Å¬·£¸í ±æÀÌ
const int	CLAN_NAME_LEN_MAX		= 16;
const int	CLAN_MARK_NAME_LEN_MAX	= 32;


const int	CLAN_MEMBER_CNT_MAX				= 30;		// Å¬·£ ÃÖ´ëÀÎ¿ø
const int	CLAN_CREATE_MEMBER_MIN_LEVEL	= 4;		// Å¬·£ »ý¼º°¡´É Å¬·£¿øÀÇ ·¹º§
const int	CLAN_CREATE_NEED_MONEY			= 150000;   // Å¬·£ Ã¢¼³ ÀÚ±Ý 

const int	CLAN_CNT_PER_PAGE			= 2;
const int	CLAN_MEMBER_CNT_PER_PAGE	= 18;
const int	NOTE_CNT_PER_PAGE			= 12;
const int	CLAN_BOARD_CNT_PER_PAGE		= 6;
const int	FRIEND_CNT_PER_PAGE			= 16;

const int	NOTE_TITLE_LEN_MAX			= 1;       // Å¬·£ ÂÊÁö Á¦¸ñ ±æÀÌ    
const int	NOTE_CONTENT_LEN_MAX		= 128;      // Å¬·£ ÂÊÁö ³»¿ë ±æÀÌ    
const int	NOTE_LIST_LOAD_MAX			= 32;

const int	CLAN_BOARD_TITLE_LEN_MAX		= 1;	// Å¬·£ °Ô½ÃÆÇ Á¦¸ñ ±æÀÌ
const int	CLAN_BOARD_CONTENT_LEN_MAX		= 256;  // Å¬·£ °Ô½ÃÆÇ ³»¿ë ±æÀÌ

const int	CLAN_LIST_LOAD_MAX				= 30;   // ÀÐÀ»¶§ ÃÖ´ë°¹¼ö 
const int	CLAN_MEMBER_LIST_LOAD_MAX		= 30;
const int	CLAN_BOARD_LIST_LOAD_MAX		= 30;

const int	CLAN_BOARD_OWN_CNT_MAX			= 50;   // º¸À¯ÇÒ ¼ö ÀÖ´Â ÃÖ´ë °Ô½ÃÆÇ °¹¼ö 
const int	PLAYER_RECV_NOTE_OWN_CNT_MAX	= 50;   // º¸À¯ÇÒ ¼ö ÀÖ´Â ¹ÞÀºÂÊÁö ÃÖ´ë°¹¼ö 
const int	PLAYER_SEND_NOTE_OWN_CNT_MAX	= 10;   // º¸À¯ÇÒ ¼ö ÀÖ´Â º¸³½ÂÊÁö ÃÖ´ë°¹¼ö 
const int	PLAYER_FRIEND_CNT_MAX			= 100;  // º¸À¯ÇÒ ¼ö ÀÖ´Â Ä£±¸ÀÇ ÃÖ´ë ¼ýÀÚ

const int	FRIEND_LIST_LOAD_MAX			= 30;   

// test
//const int	PLAYER_RECV_NOTE_OWN_CNT_MAX	= 2;   // º¸À¯ÇÒ ¼ö ÀÖ´Â ¹ÞÀºÂÊÁö ÃÖ´ë°¹¼ö 
//const int	PLAYER_SEND_NOTE_OWN_CNT_MAX	= 2;   // º¸À¯ÇÒ ¼ö ÀÖ´Â º¸³½ÂÊÁö ÃÖ´ë°¹¼ö 





const int	CHAT_TYPE_NOTICE		= 0;
const int	CHAT_TYPE_PRIVATE		= 1;
const int	CHAT_TYPE_LOBBY			= 2;
const int	CHAT_TYPE_ROOM			= 3;
const int	CHAT_TYPE_CLAN			= 4;
const int	CHAT_TYPE_FRIEND		= 5;
const int	CHAT_TYPE_SYSTEM		= 10;
const int	CHAT_TYPE_PRIVATE_FAIL	= 11;
const int	CHAT_TYPE_DEBUG			= 98;
const int	CHAT_TYPE_CHEAT			= 99;

const int	FRIEND_COUNT_MAX		= 30;

const int	MISSION_MAX				= 10;		// TODO: È®ÀÎ ÇÊ¿ä

// »ó¼¼ÀüÀû¿¡ °üÇÑ GUI°¡ ³ª¿À¸é (IDÄ«µå µÞ¸é) Å³Å¸ÀÔ°ú º¸¿©ÁÖ´Â ¼ø¼­ ÀÎµ¦½º ¸ÂÃçÁÖ´Â °ÍÀÌ ÁÁ´Ù.
const int	KILL_TYPE_AR			= 0;
const int	KILL_TYPE_SMG			= 1;
const int	KILL_TYPE_SR			= 2;
const int	KILL_TYPE_SG			= 3;
const int	KILL_TYPE_MG			= 4;
const int	KILL_TYPE_PISTOL		= 5;
const int	KILL_TYPE_MELEE			= 6;
const int	KILL_TYPE_THROW			= 7;
const int	KILL_TYPE_CTS			= 8;
const int	KILL_TYPE_ETC			= 9;
const int	KILL_TYPE_MAX			= 10;

const int	CHARAC_INVEN_SLOT_MAX	= 5;
const int	ITEM_INVEN_SLOT_MAX		= 100;		// TODO: È®ÀÎ ÇÊ¿ä
const int	ITEM_PACK_SLOT_MAX		= 28;
const int	ITEM_EQUIP_SLOT_MAX		= 5;		// ÁÖ, º¸Á¶, ¹Ð¸®, ÅõÃ´1, ÅõÃ´2
const int	SPECIAL_EQUIP_SLOT_MAX	= 5;		// Æ¯¼ö ¾ÆÀÌÅÛ

const int	PEER_ITEM_TO_HOST_MAX	= ITEM_EQUIP_SLOT_MAX + ITEM_PACK_SLOT_MAX;

const int	HAVE_CHARAC_MIN			= 3;
const int	HAVE_CHARAC_MAX			= 5;
const int	ITEM_GROUP_MAX			= 9;

#define		IS_PRIMARY_WEAPON_PARTS(code)		(code < 1000)	// ¼ÒÀ¯ ºÒ°¡
#define		IS_SPECIAL_ITEM_GROUP(code)			(code >= 1000 && code < 2000)
#define		IS_PROTECTION_GROUP(code)			(code >= 2000 && code < 3000)
#define		IS_STOG_ITEM_GROUP(code)			(code >= 3000 && code < 4000)
#define		IS_CTS_ITEM_GROUP(code)				(code >= 4000 && code < 5000)
#define		IS_THROW_WEAPON_GROUP(code)			(code >= 10000 && code < 11000) //10000, 19999
#define		IS_MELEE_WEAPON_GROUP(code)			(code >= 11000 && code < 12000) //11000, 11999
#define		IS_SECONDARY_WEAPON_GROUP(code)		(code >= 13000 && code < 14000) //13000, 13999
//#define		IS_PRIMARY_WEAPON_GROUP(code)		(code >= 14000 && code < 59999) //14000, 29999
#define		IS_PRIMARY_WEAPON_GROUP(code)		(code >= 14000 && code < 60000) //14000, 60000

#define		IS_WEARABLE(code)					(code >= 2000 && code < 5000)
#define		IS_WEAPON(code)						(code >= 10000 && code < 60000)

const BYTE	ITEM_REMOVED	= 0;
const BYTE	ITEM_IN_INVEN	= 1;	// ÀÎº¥Åä¸®
const BYTE	ITEM_IN_PACK	= 2;	// ¹éÆÑ
const BYTE	ITEM_ON_EQUIP	= 3;	// ¹«±â: ÀåÂø
const BYTE	ITEM_ON_CHARAC	= 4;	// Ä³¸¯ÅÍ º° Âø¿ë
const BYTE	ITEM_ON_FIXED_EQUIP	= 5;

const BYTE	SALE_TYPE_FREE	= 0;			// ±âº» Áö±Þ
const BYTE	SALE_TYPE_1DAY	= 1;			// 1ÀÏ
const BYTE	SALE_TYPE_7DAY	= 2;			// 7ÀÏ
const BYTE	SALE_TYPE_30DAY = 3;			// 30ÀÏ
const BYTE	SALE_TYPE_UNLIMIT	= 4;		// ³»±¸µµ


// ÂÊÁö Àü¼Û °á°ú Å¸ÀÔ
enum EClanMemberDeleteType
{
	ECMDT_Request =			0,	// º»ÀÎÀÌ Å»Åð ¿äÃ»
	ECMDT_Withdraw =		1,	// Å¬·£¸¶½ºÅÍ°¡ Å»Åð½ÃÅ´
};

// ÂÊÁö Àü¼Û °á°ú Å¸ÀÔ
enum ENoteSendReusltType
{
	ENSRT_Fail =			0,	// ÂÊÁö Àü¼Û ½ÇÆÐ
	ENSRT_Success =			1,	// ÂÊÁö Àü¼Û ¼º°ø
	ENSRT_NoCharac =		2,	// ÂÊÁö Àü¼Û ½ÇÆÐ(Ä³¸¯ÅÍ ¾ø½¿)
	ENSRT_RecvFull =		3,	// ÂÊÁö Àü¼Û ½ÇÆÐ(¹Þ´Â ÂÊÁöÇÔ full)
	ENSRT_SendFull =		4,	// ÂÊÁö Àü¼Û ½ÇÆÐ(º¸³½ ÂÊÁöÇÔ full)
};

// ÂÊÁö ÀÀ´ä Å¸ÀÔ
enum ENoteReplyOptionType
{
	ENROT_NormalNote =		0,	// ÀÏ¹ÝÂÊÁö
	ENROT_ClanRequest =		1,	// Å¬·£°¡ÀÔ½ÅÃ»(Å¬·£¿ø)
	ENROT_ClanInvite =		2,	// Å¬·£°¡ÀÔ±ÇÀ¯(Å¬·£¸¶½ºÅÍ)
};

// ÂÊÁö ÀÀ´ä °á°ú Å¸ÀÔ
enum ENoteReplyResultType
{
	ENRRT_Wait =			0,	// ÀÀ´ä´ë±â
	ENRRT_ClanOK =			1,	// Å¬·£ °¡ÀÔ OK
	ENRRT_ClanNO =			2,	// Å¬·£ °¡ÀÔ NO
	ENRRT_Read =			3,	// ÂÊÁö ÀÐÀ½ 
};



#pragma pack(push)
#pragma pack(1)

struct	_ITEM_ID
{
	UINT32		nItemUID;
	UINT16		nItemCode;
};

union _TIME64
{
	UINT64		nTime;
	struct _Time
	{
		UINT32	nLow;
		UINT32	nHigh;
	}Time;
};

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

union _HG_DATE
{
	UINT32	info;	
	struct tagDate
	{
		UINT16	year;
		UINT8	month;
		UINT8	day;
	}date;
};

// Å¬·£ ½Ã½ºÅÛ 
//-----------------------------------------------
struct _CLAN_INFO
{	
	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
	UINT16	rank;
	WCHAR	mark[CLAN_MARK_NAME_LEN_MAX+1];
	UINT32	point;
	WCHAR	master[NICKNAME_LEN_MAX+1];
	UINT32	masterPlayerID;

	UINT16	maxCrew;
	UINT16	memberCount;
	UINT16	winCount;
	UINT16	loseCount;
	UINT16	drawCount;
};


struct _CLAN_MEMBER_INFO
{	
	UINT32	playerID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	UINT8	status;	// 0.ºñÁ¢¼Ó 1.Á¢¼Ó
	UINT16	grade;  // 4.¸¶½ºÅÍ 3.°£ºÎ 2.°£ºÎ 1.°£ºÎ 0.ÀÏ¹ÝÈ¸¿ø 
	UINT16	level;  // player level
};


struct _CLAN_BOARD_INFO
{	
	UINT32	playerID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	clanBoardID;
	WCHAR	title[CLAN_BOARD_TITLE_LEN_MAX+1];
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
	UINT64  createDate;
};


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


struct _FRIEND_INFO
{	
	UINT32	playerID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	
	UINT8	status;	// 0.ºñÁ¢¼Ó 1.Á¢¼Ó	
	UINT16	level;  // player level	
	UINT64  createDate;
};


// ·Î±×ÀÎ¼­¹ö¿¡¼­ º¸³»´Â ¼­¹öÁ¤º¸ 
struct _LOCAL_SERVER_INFO
{
	UINT8	id;
	WCHAR	serverAddress[61];
	UINT16	port;
	WCHAR	category[21];
	WCHAR	serverName[21];	
};







#pragma pack(pop)

union _IP32
{
	DWORD	nIP;
	struct _UN_IP
	{
		BYTE	b1;
		BYTE	b2;
		BYTE	b3;
		BYTE	b4;
	}unIP;
};

const BYTE	NET_TYPE_PUBLIC			= 0;
const BYTE	NET_TYPE_PRIVATE		= 1;	// NATÅ¸ÀÔÀ» ¾Ë¾Æ³»Áö ¸øÇÑ °æ¿ì!

const BYTE	NAT_TYPE_FULL_CONE		= 10;	// NAT TYPE1
const BYTE	NAT_TYPE_RESTRICT_CONE	= 11;	// NAT TYPE2
const BYTE	NAT_TYPE_SYMMETRIC		= 12;	// NAT TYPE3
const BYTE	NAT_TYPE_OPEN			= 13;	// NAT TYPE4 Æ÷Æ® ¸ÅÇÎ ¶Ç´Â DMZ ¼³Á¤À¸·Î ¿ÜºÎ ¿ÀÇÂµÇ¾î ÀÖÀ½


const BYTE	NAT_TYPE_UNKNOWN		= 245;
const BYTE	NAT_TYPE_UNREACHED		= 255;	// ¹æÈ­º®À¸·Î ¸·ÇôÀÖ°Å³ª ¸±·¹ÀÌ ¼­¹ö¿¡ ¹®Á¦°¡ ÀÖ´Â °æ¿ì !

const BYTE	MATCH_INFO_LISTEN		= 0;		// È£½ºÆ® ¸®½¼
const BYTE	MATCH_INFO_CONNECT		= 1;		// Å¬¶óÀÌ¾ðÆ®°¡ È£½ºÆ®¿¡ Á¢¼Ó
const BYTE	MATCH_INFO_INVITE		= 2;		// È£½ºÆ®°¡ ¸ÕÀú Å¬¶óÀÌ¾ðÆ®¿¡ ¿¬°á
const BYTE	MATCH_INFO_RELAY		= 3;		// ¸±·¹ÀÌ¼­¹ö ÅëÇØ¼­ Åë½Å


const BYTE	GAMERIGHT_GENERAL				= 0;	// ÀÏ¹Ý
const BYTE	GAMERIGHT_NO_PARTNER_PCBANG		= 1;	// ¹ÌÁ¦ÈÞ ÇÇ¾¾¹æ
const BYTE	GAMERIGHT_PARTNER_PCBANG		= 2;	// Á¦ÈÞ ÇÇ¾¾¹æ
const BYTE	GAMERIGHT_GM					= 9;	// GM
const BYTE	GAMERIGHT_TEST					= 10;	// °³¹ßÆÀ ³»ºÎ¿¡¼­¸¸ »ç¿ëÇÏ´Â Å×½ºÆ® °èÁ¤

const BYTE	FRIEND_OFFLINE		= 0;
const BYTE	FRIEND_ONLINE		= 1;

const BYTE	FRIEND_TYPE_NONE		= 0;
const BYTE	FRIEND_TYPE_PROPOSE		= 1;
const BYTE	FRIEND_TYPE_ACCEPT		= 2;
const BYTE	FRIEND_TYPE_DENY		= 3;
const BYTE	FRIEND_TYPE_DEL			= 4;

const BYTE	FRIEND_RELATION_MYSELF			= 0;
const BYTE	FRIEND_RELATION_ERROR			= 1;
const BYTE	FRIEND_RELATION_NONE			= 2;
const BYTE	FRIEND_RELATION_MAKE			= 3;	// ¼­·Î Ä£±¸ ¿Ï·á
const BYTE	FRIEND_RELATION_BLOCKED_BY		= 4;	// »èÁ¦, °ÅÀýÀ» ´çÇÔ
const BYTE	FRIEND_RELATION_PROPOSE_WAIT	= 5;	// ¼ö¶ô ´ë±â (¹ÌÁ¢¼ÓÀ¸·Î Ç¥½Ã)
const BYTE	FRIEND_RELATION_PROPOSED_BY		= 6;	// ¿äÃ» ¹ÞÀ½ (¼ö¶ô È¤Àº °ÅÀýÀ» ¾ÆÁ÷ ¾ÈÇÑ »óÅÂ)





#endif //__COMMON_DEFINES_INCLUDE__
*/