/*
#ifndef		__CLIENT_DEFINES_INCLUDE__
#define		__CLIENT_DEFINES_INCLUDE__

#pragma once

// °¢Á¾ ÃÖ´ë°ªµé
const int   MAX_ROOM_PASSWORD			= 8;		// ¹æ ºñ¹Ð¹øÈ£ ±æÀÌ
const int	MAX_VOTEREASON_LEN			= 10;		// ÅõÇ¥ »çÀ¯ ±æÀÌ Á¦ÇÑ.
const int   MAX_INVITE_LOBBY_PLAYERS	= 10;		// ÃÊ´ë °¡´ÉÇÑ ÃÖ´ë ·Îºñ ÇÃ·¹ÀÌ¾î ¼ö.



// ÈÆ·ÃÀå °ü·Ã Å¬¶óÀÌ¾ðÆ® Á¤ÀÇ °ª.
const int   TRAINING_BATTLE_ROOM_ID			= 0;		// ÈÆ·ÃÀåÀ¸·Î »ç¿ëÇÏ´Â ¹æÀÇ °íÁ¤ ID.
const int   TRAINING_BATTLE_ROOM_MAPID		= 200;		// ÈÆ·ÃÀåÀ¸·Î »ç¿ëÇÏ´Â ¹æÀÇ ¸Ê ID.
const int   TRAINING_BATTLE_ROOM_MISSIONID	= 0;		// ÈÆ·ÃÀåÀ¸·Î »ç¿ëÇÏ´Â ¹æÀÇ ¹Ì¼Ç ID.
const int   TRAINING_BATTLE_ROOM_TIMELIMIT	= 30 * 60;	// ÈÆ·ÃÀåÀ¸·Î »ç¿ëÇÏ´Â ¹æÀÇ ¶ó¿îµå ½Ã°£.
const int   TRAINING_BATTLE_ROOM_ROUNDLIMIT	= 1;		// ÈÆ·ÃÀåÀ¸·Î »ç¿ëÇÏ´Â ¹æÀÇ ¶ó¿îµå ¼ö.

// ¹Ì¼Ç ÁøÇà Áß ÇÃ·¹ÀÌ¾îÅ³À» Á¦¿ÜÇÑ ÀÏ¾î³¯ ¼ö ÀÖ´Â ¸ðµç ÀÌº¥Æ®¸¦ ÀÌ °÷¿¡ Á¤ÀÇÇÑ´Ù.
// È£½ºÆ®´Â ÀÌ °ªÀ» Ã¤³Î ¼­¹ö·Î Àü¼ÛÇÏ¸ç, Ã¤³Î ¼­¹ö´Â À¯È¿¼º °Ë»ç ¹× ·Î±× ±â·Ï¿¡ ÀÌ °ªÀ» È°¿ëÇÑ´Ù.
// °ú°Å Á¤ÀÇÇß´ø °ªÀÇ À¯È¿¼ºÀ» º¸ÀåÇØ¾ß ÇÏ¹Ç·Î ¹øÈ£¸¦ Áß°£¿¡ Ãß°¡ ¶Ç´Â »èÁ¦ÇÏÁö ¾Ê¾Æ¾ß ÇÑ´Ù.
// Å¬¶óÀÌ¾ðÆ®ÀÇ HG_OnlineData.uc ÆÄÀÏ¿¡ ÀÖ´Â MissionEventType_ »ó¼ö°ª°ú Ç×»ó ÀÏÄ¡ÇÏµµ·Ï ÇØ¾ß ÇÑ´Ù.
enum EMissionEventType
{
	EMET_NotDefined =			0,	// Á¤ÀÇµÇÁö ¾ÊÀº ÀÌº¥Æ®.
	EMET_RoundBegin =			1,	// ¶ó¿îµå ½ÃÀÛ.
	// nEventPlayerUID: »ç¿ë ¾È ÇÔ.
	// nEventTeamID: »ç¿ë ¾È ÇÔ.
	EMET_BombObtain =			3,	// ÆøÅº È¹µæ.
	// nEventPlayerUID: È¹µæÇÑ ÇÃ·¹ÀÌ¾î UID.
	// nEventTeamID: È¹µæÇÑ ÇÃ·¹ÀÌ¾îÀÇ ÆÀ.
	EMET_BombDrop =				4,	// ÆøÅº ¶³¾î¶ß¸².
	// nEventPlayerUID: ¶³¾î¶ß¸° ÇÃ·¹ÀÌ¾î UID.
	// nEventTeamID: ¶³¾î¶ß¸° ÇÃ·¹ÀÌ¾îÀÇ ÆÀ.
	EMET_BombInstall =			5,	// ÆøÅº ¼³Ä¡.
	// nEventPlayerUID: ¼³Ä¡ÇÑ ÇÃ·¹ÀÌ¾î UID.
	// nEventTeamID: ¼³Ä¡ÇÑ ÇÃ·¹ÀÌ¾îÀÇ ÆÀ.
	EMET_BombUninstall =		6,	// ÆøÅº ÇØÁ¦.
	// nEventPlayerUID: ÇØÁ¦ÇÑ ÇÃ·¹ÀÌ¾î UID.
	// nEventTeamID: ÇØÁ¦ÇÑ ÇÃ·¹ÀÌ¾îÀÇ ÆÀ.
	EMET_RoundEnd_TimeOver =	11,	// ½Ã°£ Á¦ÇÑ ÃÊ°ú·Î ¶ó¿îµå Á¾·á.
	// nEventPlayerUID: »ç¿ë ¾È ÇÔ.
	// nEventTeamID: »ç¿ë ¾È ÇÔ.
	EMET_RoundEnd_GoalReached =	12,	// ¸ñÇ¥ ´Þ¼ºÀ¸·Î ¶ó¿îµå Á¾·á.
	// nEventPlayerUID: »ç¿ë ¾È ÇÔ.
	// nEventTeamID: »ç¿ë ¾È ÇÔ.
	EMET_CTSS_Contributed =		21,	// ±â¿©µµ¿¡ ¿µÇâÀ» ÁÖ´Â CTSS »ç¿ë. ¸ðµç CTSS »ç¿ë¿¡ ´ëÇØ Àü¼ÛÇÏÁö ¾Ê´Â´Ù.
	// nEventPlayerUID: »ç¿ëÇÑ ÇÃ·¹ÀÌ¾î UID.
	// nEventTeamID: »ç¿ëÇÑ ÇÃ·¹ÀÌ¾îÀÇ ÆÀ.
	EMET_MAX
};

// BSM, CBM µî ¹Ì¼ÇÀÇ °ÔÀÓ¿ÀºêÁ§Æ®(GDT) »óÅÂ°ªÀ» Á¤ÀÇÇÑ´Ù.
// Å¬¶óÀÌ¾ðÆ®ÀÇ HG_BombFlagObject.uc ÆÄÀÏ¿¡ ÀÖ´Â EBombStateType Á¤ÀÇµÈ °ªÀ» µû¸¥´Ù.
enum EGameObjectStatus
{
    EGOS_NONE =	0,
    EGOS_HELD =	1,
    EGOS_HOME =	2,
    EGOS_PLANT =	3,
    EGOS_UNPLANT =	4,
    EGOS_BOOM =	5,
    EGOS_DROPPED =	6,
	EGOS_MAX
};

#pragma pack(push)
#pragma pack(1)

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

struct	_PEER_CHARAC_INFO
{	
	UINT8	nCharacCode;		// Ä³¸¯ÅÍ ÄÚµå
	UINT8	nTattooCode;		// ¹®½Å ÄÚµå
	UINT16	nProtectionItemCode;	// ¹æ¾î±¸
	UINT16	nSurvialItemCode;	// »ýÁ¸ STOG
	UINT16	nTacticalItemCode;	// Àü¼ú STOG
	UINT16	nTrainingItemCode;	// ´Ü·Ã STOG
	UINT16	nCTSItemCode;		// CTS
};

struct _LOBBY_MEMBER_INFO
{
	UINT32	nPlayerUID;
	UINT32	nClanID;      // Å¬·£IDÃß°¡ 
	UINT8	nLevel;
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];
};

struct _ROOM_SUMMARY
{
	INT16	nRoomID;
	UINT8	nMapID;

	UINT16	nMissionID : 4;
	UINT16	bIsPrivate : 1;			// 0: ÀÏ¹Ý ¹æ, 1: ºñ¹Ð ¹æ.
	UINT16	bRoomMatchStarted : 1;	// 0: ¸ÅÄ¡ ½ÃÀÛ ¾È ÇÑ »óÅÂ, 1: ¸ÅÄ¡ ½ÃÀÛ ÇÑ »óÅÂ.	
	UINT16	nRoomPlayerCount : 5;
	UINT16	nRoomPlayerLimit : 5;

	UINT8	nHostEvaluation;		// ¹æÀå Áö¼ö. --> »èÁ¦! ÇÁ·ÎÅäÄÝ ºÐ¸®ÇÔ
	INT8	nRoomNameIndex;			// -1 ÀÏ °æ¿ì ÀÓÀÇ ¼öÁ¤µÈ ¹æÁ¦¸ñ. ±× ¿Ü¿¡´Â ¹æÁ¦¸ñÀ» ÁÖ°í¹ÞÁö ¾Ê´Â´Ù.
	WCHAR	szRoomName[MAX_ROOM_NAME+1];	// °¡º¯±æÀÌ ¹æÁ¦¸ñÀÌ¹Ç·Î Ç×»ó ¸¶Áö¸· ¸â¹öº¯¼ö·Î ÁöÁ¤ÇØ¾ß ÇÑ´Ù.
};

struct _ROOM_DETAIL
{
	INT16	nRoomID;
	UINT16	nKillLimit;
	UINT8	nRoundLimit;
	UINT16	nTimeLimit;
	UINT8	nWeaponAllowance;
	UINT8	bLevelFree;
	UINT8	bCanIntrude;
	UINT8	bAutoBalance;
	UINT8	bCanObserve;
	UINT8	bNoTeamKill;
	UINT8	bMinimumStart;
	UINT8	bAutoChangeMaster;
};

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

struct _ROOM_MEMBER_DETAIL
{
	UINT8				nTeamID;
	UINT8				nLevel;
	UINT8				bHostPlayer;
	UINT32				nPingTime;
	UINT8				nPlayerStatusInRoom; // EPlayerStatusInRoom °ª Áß ÇÏ³ª.
};

struct _UNREAL_LEVEL_LOCATION
{
	INT16				nLocX;
	INT16				nLocY;
	INT16				nLocZ;
};

struct _PLAYER_LEVEL_PROGRESS
{
	_UNREAL_LEVEL_LOCATION	PlayerLocation; // ÇÃ·¹ÀÌ¾îÀÇ À§Ä¡.
	INT16				nPlayerYaw; // ÇÃ·¹ÀÌ¾îÀÇ ¹æÇâ.
	UINT16				nWeapon1AmmoUsed; // 1¹ø ¹«±â(ÁÖ¹«±â) »ç¿ëÇÑ ÃÑ¾Ë ¼ö.
	UINT16				nWeapon1SpareAmmo; // 1¹ø ¹«±â(ÁÖ¹«±â) ³²Àº ÃÑ¾Ë ¼ö.
	UINT16				nWeapon2AmmoUsed; // 2¹ø ¹«±â(º¸Á¶¹«±â) »ç¿ëÇÑ ÃÑ¾Ë ¼ö.
	UINT16				nWeapon2SpareAmmo; // 2¹ø ¹«±â(º¸Á¶¹«±â) ³²Àº ÃÑ¾Ë ¼ö.
	UINT16				nWeapon1Code; // 1¹ø ¹«±â(ÁÖ¹«±â) ÄÚµå.
	UINT16				nWeapon2Code; // 2¹ø ¹«±â(º¸Á¶¹«±â) ÄÚµå.
	UINT8				nCTSSPoint; // CTSS ÃàÀû Á¡¼ö.
	UINT8				nHealthPoint; // ÇÃ·¹ÀÌ¾î Ã¼·Â.
	UINT8				nArmorPoint; // ÇÃ·¹ÀÌ¾î ¹æ¾î±¸ Ã¼·Â.
	UINT8				nSprintPoint; // ÇÃ·¹ÀÌ¾î ½ºÇÁ¸°Æ®.
	UINT16				nGrenade1Code; // ¼ö·ùÅº ÄÚµå.
	UINT8				nGrenade1Ammo; // ¼ö·ùÅº ¼ö.
	UINT16				nGrenade2Code; // ¼ö·ùÅº ÄÚµå.
	UINT8				nGrenade2Ammo; // ¼ö·ùÅº ¼ö.
	UINT16				nGrenade3Code; // ¼ö·ùÅº ÄÚµå.
	UINT8				nGrenade3Ammo; // ¼ö·ùÅº ¼ö.
};

// »õ·Î¿î ¸ÅÄ¡ °á°ú ³»¿ë
struct _MATCH_RESULT
{
	UINT32	playerID;
	UINT16	rank;							// ¼øÀ§
	WCHAR	clanName[ACCOUNT_LEN_MAX+1];	// Å¬·£ÀÌ¸§
	WCHAR	callSign[ACCOUNT_LEN_MAX+1];	// ÄÝ½ÎÀÎ

	UINT32	contribution;					// ±â¿©µµ
	UINT16	bombInstall;					// ÆøÅº¼³Ä¡ È½¼ö 
	UINT16	bombUninstall;					// ÆøÅºÇØÃ¼ È½¼ö 	
	UINT16	killCount;						// Å³ È½¼ö
	UINT16	deathCount;						// µ¥½º È½¼ö 
	
	UINT32	rewardMoney;					// º¸»ó±Ý 
	UINT32	rewardExp;						// °æÇèÄ¡  
};

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


struct _HG_SERVER_ADDRESS 
{
	UINT32	nIP;
	UINT16	nPort;
	UINT16	nID;
};

#pragma pack(pop)

#endif //__CLIENT_DEFINES_INCLUDE__
	*/