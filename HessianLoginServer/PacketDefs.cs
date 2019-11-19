
    /*
Packet Def:

struct	MSG_HEADER
{
	unsigned short	size;
	unsigned short	code;	
};


     */
/*

#pragma once


// 모든 메세지 클래스를 만들기위한 메세지 타입
// 클라이언트와 서버 프로토콜을 같이 표시한다.
enum  CommonProtocolType
{
	// client protocol
	// 0x1... 채널 세션 프로토콜 
	// 0x2... 로그인 세션 프로토콜 
	// 현재 3개를 제외하고 모두 채널세션 프로토콜이다.
	//-------------------------------------------------------------

	// 채널 세션 프로토콜
	//-----------------------------------------

	// 접속 
	_S2C_ERROR = 0x1000, 
	_S2C_DEBUG_MSG, 
	_S2C_ACCEPT, 
	_S2C_HEART_BEAT, 
	_C2S_HEART_BEAT, 
	_S2C_SERVER_STATUS, 
	_S2C_CHANNEL_STATUS, 
	_S2C_SERVER_ADDRESS,	
	_C2S_DEVELOPMENT, 
	_S2C_DEVELOPMENT, 
	_C2S_ENTER_SERVER, 
	_S2C_ENTER_SERVER_OK, 
	_C2S_LEAVE_SERVER, 

	// 채널 
	_C2S_ENTER_CHANNEL, 
	_S2C_ENTER_CHANNEL_OK, 
	_C2S_LEAVE_CHANNEL, 
	_S2C_LEAVE_CHANNEL_OK, 
	_C2S_CHANGE_SERVER, 
	_S2C_CHANGE_SERVER, 

	// Player 
	_C2S_GET_PLAYER_INFO, 
	_S2C_NEW_PLAYER, 
	_C2S_REGISTER_NICKNAME, 
	_S2C_REGISTER_NICKNAME, 
	_C2S_GET_IDCARD_INFO, 
	_S2C_IDCARD_FRONTSIDE, 
	_S2C_IDCARD_BACKSIDE, 
	_S2C_PLAYER_INFO, 

	// Inventory
	_S2C_INVENTORY, 
	_C2S_PRIMARY_CHARAC, 
	_S2C_PRIMARY_CHARAC_OK, 
	_C2S_PUT_ITEM, 
	_S2C_PUT_ITEM_OK, 
	_C2S_EQUIP_ITEM, 
	_S2C_EQUIP_ITEM_OK, 
	_S2C_UPDATE_CHARAC_INFO, 
	_S2C_UPDATE_ITEM_INFO, 
	_C2S_REPAIR_ITEM, 
	_S2C_REPAIR_ITEM_OK, 
	_C2S_BUY_ITEM, 
	_S2C_BUY_ITEM_OK, 
	_C2S_SELL_ITEM, 
	_S2C_SELL_ITEM_OK, 
	_C2S_BUY_CHARAC, 
	_S2C_BUY_CHARAC_OK, 
	_C2S_SELL_CHARAC, 
	_S2C_SELL_CHARAC_OK, 
	_S2C_BUY_ITEM_NEW, 

	// Lobby 
	_S2C_LOBBY_MEMBER_LIST, 
	_S2C_LOBBY_MEMBER_INFO, 
	_S2C_LOBBY_MEMBER_REMOVE, 
	_S2C_LOBBY_ROOM_LIST, 
	_S2C_LOBBY_ROOM_INFO, 
	_S2C_LOBBY_ROOM_REMOVE, 
	_C2S_LOBBY_ROOM_DETAIL, 
	_S2C_LOBBY_ROOM_DETAIL, 
	_C2S_HOST_QUOTIENT, 
	_S2C_HOST_QUOTIENT, 

	// Room 
	_C2S_ROOM_CREATE, 
	_S2C_ROOM_CREATE_OK, 
	_C2S_ROOM_OPTION_CHANGE, 
	_S2C_ROOM_OPTION, 
	_S2C_ROOM_MEMBER_INFO, 
	_S2C_ROOM_MEMBER_DETAIL, 
	_S2C_ROOM_MEMBER_REMOVE, 
	_C2S_ROOM_JOIN, 
	_S2C_ROOM_JOIN_OK, 
	_C2S_ROOM_EXIT, 
	_S2C_ROOM_EXIT_OK, 
	_C2S_ROOM_MEMBER_PING, 
	_S2C_ROOM_MEMBER_PING, 
	_C2S_ROOM_TOGGLE_READY, 
	_C2S_ROOM_SWITCH_TEAM, 
	_C2S_ROOM_QUICKJOIN, 
	_C2S_ROOM_SCENE_CHANGE, 
	_C2S_ROOM_CHANGE_MASTER, 
	_C2S_ROOM_PLAYER_OUTFIT, 
	_S2C_ROOM_PLAYER_OUTFIT, 
	_C2S_ROOM_TRAINING_START, 
	_C2S_ROOM_TRAINING_SUCCESS, 

	// 투표
	_C2S_VOTE_PROPOSE, 
	_S2C_VOTE_PROPOSED, 
	_C2S_VOTE_CAST, 
	_S2C_VOTE_FINISHED, 

	// 초청
	_C2S_INVITE_REQ_LOBBY_PLAYERS, 
	_S2C_INVITE_RES_LOBBY_PLAYERS, 
	_C2S_INVITE_TARGET_SELECTED, 
	_S2C_INVITE_LOBBY_INVITATION, 
	_C2S_INVITE_INVITATION_REPLY, 

	// 전투 
	_C2S_MATCH_REQ_START, 
	_S2C_MATCH_START, 
	_S2C_MATCH_INFO_HOST, 
	_S2C_MATCH_INFO_CLIENT, 
	_C2S_MATCH_FINISH, 
	_S2C_MATCH_RETURN_ROOM, 
	_S2C_MATCH_ALLOW_CLIENT, 
	_S2C_MATCH_INFO_CHARACTER, 
	_C2S_MATCH_REQ_CANCEL, 
	_C2S_MATCH_PLAYER_PROGRESS, 
	_S2C_MATCH_CURRENT_PROGRESS, 
	_S2C_MATCH_PLAYER_PROGRESS, 
	_C2S_MATCH_HOST_ALIVE, 
	_S2C_MATCH_CLIENT_BATTLE_INFO, 
	_C2S_MATCH_LISTEN_STARTED, 
	_S2C_MATCH_HOST_MIGRATION, 

	// 채팅 
	_C2S_CHAT, 
	_S2C_CHAT, 
	_C2S_JUMPTO, 
	_S2C_JUMPTO, 
	//_C2S_FRIEND_LIST, 
	//_S2C_FRIEND_LIST, 
	//_S2C_FRIEND_STATUS, 
	//_S2C_FRIEND_INFO, 
	//_C2S_FRIEND_INFO, 

	// 미션 
	_C2S_MISSION_PLAYER_KILL, 
	_C2S_MISSION_EVENT, 
	_C2S_MISSION_ITEM_EQUIP, 
	_S2C_MISSION_SCORE, 
	_S2C_UPDATE_CASHPOINT, 
	_S2C_EVENT_RESULT, 

	// 홀펀칭 
	_C2S_NAT_RESOLVE_START, 
	_S2C_NAT_RESOLVE_INFO, 
	_C2S_NAT_RESOLVE_END, 
	_C2S_FULLCONE_RESULT, 

	// 클랜 메세지 
	_C2S_CLAN_ADD,
	_S2C_CLAN_ADD,	   
   
	_C2S_CLAN_DELETE,
	_S2C_CLAN_DELETE,	
   
	_C2S_CLAN_UPDATE,
	_S2C_CLAN_UPDATE,	
   
	_C2S_CLAN_LIST,
	_S2C_CLAN_LIST,	

	_C2S_CLAN_INFO,
	_S2C_CLAN_INFO,

	_C2S_CLAN_DUP_NAME,
	_S2C_CLAN_DUP_NAME,
   
	_C2S_CLAN_MEMBER_ADD,   
	_S2C_CLAN_MEMBER_ADD,	
   
	_C2S_CLAN_MEMBER_DELETE,
	_S2C_CLAN_MEMBER_DELETE,	
   
	_C2S_CLAN_MEMBER_UPDATE,
	_S2C_CLAN_MEMBER_UPDATE,
	
	_C2S_CLAN_MEMBER_LIST,
	_S2C_CLAN_MEMBER_LIST,	

	_C2S_CLAN_MEMBER_INFO,
	_S2C_CLAN_MEMBER_INFO,
   
	_C2S_CLAN_BOARD_ADD,
	_S2C_CLAN_BOARD_ADD,
   
	_C2S_CLAN_BOARD_DELETE,
	_S2C_CLAN_BOARD_DELETE,
   
	_C2S_CLAN_BOARD_UPDATE,
	_S2C_CLAN_BOARD_UPDATE,
   
	_C2S_CLAN_BOARD_LIST,
	_S2C_CLAN_BOARD_LIST,

	// 쪽지 메세지 
	_C2S_NOTE_SEND,
	_S2C_NOTE_SEND_SENDER,
	_S2C_NOTE_SEND_RECEIVER,

	_C2S_NOTE_REPLY,
	_S2C_NOTE_REPLY,
   
	_C2S_SEND_NOTE_DELETE,
	_S2C_SEND_NOTE_DELETE,

	_C2S_RECV_NOTE_DELETE,
	_S2C_RECV_NOTE_DELETE,
   
	_C2S_SEND_NOTE_LIST,
	_S2C_SEND_NOTE_LIST,

	_C2S_RECV_NOTE_LIST,
	_S2C_RECV_NOTE_LIST,

	// 친구시스템 
	//-----------------------------------------
	_C2S_FRIEND_INVITE, 
	_S2C_FRIEND_INVITE_SENDER, 
	_S2C_FRIEND_INVITE_RECEIVER, 

	_C2S_FRIEND_REPLY, 
	_S2C_FRIEND_REPLY_SENDER, 
	_S2C_FRIEND_REPLY_RECEIVER, 

	_C2S_FRIEND_DELETE, 
	_S2C_FRIEND_DELETE_SENDER, 
	_S2C_FRIEND_DELETE_RECEIVER, 

	_C2S_FRIEND_UPDATE, 
	_S2C_FRIEND_UPDATE, 

	_C2S_FRIEND_LIST, 
	_S2C_FRIEND_LIST, 


	// 로그인 세션 프로토콜 
	//-----------------------------------------
	_C2S_VERSION = 0x2000, 
	_C2S_GAME_LOGIN, 
	_S2C_GAME_LOGIN_OK, 

	// 릴레이 프로토콜 
	//-----------------------------------------
	_WELCOME_PING, 
	_RELAY_PING, 
	_RELAY_PONG, 
	_INVITE_PING, 

	
	// server protocol
	//------------------------------------------------------------------------------------------------------------
	// GMProxy서버 - G, DBProxy서버 - D, Center서버 - E, Channel서버 - H, 
	// Login서버 - L, Relay서버 - R, Community서버 - N

	// 로그인 
	//-----------------------------------------
	//_S2S_REQ_SERVER_LOGIN, 
	_G2E_REQ_SERVER_LOGIN, 
	_E2G_REQ_SERVER_LOGIN, 
	_E2D_REQ_SERVER_LOGIN, 	
	_H2E_REQ_SERVER_LOGIN, 
	_H2N_REQ_SERVER_LOGIN, 
	_H2D_REQ_SERVER_LOGIN, 
	_L2D_REQ_SERVER_LOGIN, 
	_L2E_REQ_SERVER_LOGIN, 	

	//_S2S_RES_SERVER_LOGIN, 
	_E2G_RES_SERVER_LOGIN, 
	_G2E_RES_SERVER_LOGIN, 
	_D2E_RES_SERVER_LOGIN, 	
	_E2H_RES_SERVER_LOGIN, 
	_N2H_RES_SERVER_LOGIN,

	_D2H_RES_SERVER_LOGIN, 
	_D2L_RES_SERVER_LOGIN, 
	_E2L_RES_SERVER_LOGIN, 	

	//_S2S_CMD_MSG, 
	_H2E_CMD_MSG, 

	_L2D_DB_MEMBER_ADD,    // 계정이 없으면 생성한다. 
	_D2L_DB_MEMBER_ADD,    

	//_S2S_REQ_MEMBER_INFO, 
	_L2D_REQ_MEMBER_INFO, 

	//_S2S_RES_MEMBER_INFO, 
	_D2L_RES_MEMBER_INFO, 	

	//_S2S_SEND_LOGIN_INFO, 
	_L2E_SEND_LOGIN_INFO, 

	//_S2S_SERVER_STATUS, 
	_E2L_SERVER_STATUS, 
	_E2H_SERVER_STATUS, 

	//_S2S_SERVER_POPULATION_LIMIT, 
	_L2E_SERVER_POPULATION_LIMIT, 

	//_S2S_REQ_PLAYER_ENTER, 
	_H2E_REQ_PLAYER_ENTER, 	
	
	//_S2S_RES_PLAYER_ENTER, 
	_E2H_RES_PLAYER_ENTER, 

	//_S2S_REQ_PLAYER_LEAVE, 
	_E2H_REQ_PLAYER_LEAVE, 
	_H2E_REQ_PLAYER_LEAVE, 

	//_S2S_RES_PLAYER_LEAVE, 	
	
	//_S2S_REQ_CHANGE_SERVER, 
	_H2E_REQ_CHANGE_SERVER, 

	//_S2S_RES_CHANGE_SERVER, 
	_E2H_RES_CHANGE_SERVER, 

	//_S2S_PLAYER_CHAT, 
	_E2H_PLAYER_CHAT, 
	_H2E_PLAYER_CHAT, 

	//_S2S_REQ_JUMPTO, 
	_H2E_REQ_JUMPTO, 

	//_S2S_RES_JUMPTO, 
	_E2H_RES_JUMPTO, 

	//_S2S_SEND_USER_STATUS, 

	//_S2S_DBPROXY_RESULT, 
	_D2H_DBPROXY_RESULT,  


	// Player
	//-----------------------------------------	
	_H2D_DB_PLAYER_ADD,
	_D2H_DB_PLAYER_ADD,
	_H2D_DB_PLAYER_UPDATE,
	_H2D_DB_PLAYER_SELECT,
	_D2H_DB_PLAYER_SELECT,

	_H2D_DB_BATTLE_RECORD_UPDATE,
	_H2D_DB_BATTLE_RECORD_SELECT,
	_D2H_DB_BATTLE_RECORD_SELECT,

	_H2D_DB_INVENTORY_UPDATE,
	_H2D_DB_INVENTORY_SELECT,
	_D2H_DB_INVENTORY_SELECT,	

	_H2D_DB_CHARAC_ADD,
	_H2D_DB_CHARAC_DELETE,
	_H2D_DB_CHARAC_UPDATE,
	_H2D_DB_CHARAC_SELECT,
	_D2H_DB_CHARAC_SELECT,

	_H2D_DB_ITEM_ADD,
	_H2D_DB_ITEM_DELETE,
	_H2D_DB_ITEM_UPDATE,
	_H2D_DB_ITEM_SELECT,
	_D2H_DB_ITEM_SELECT,

	//_S2S_DB_COMMAND, 

	//_S2S_NOTIFY_USER_STATUS, 

	//_S2S_REQ_REGISTER_NICKNAME, 
	_H2D_REQ_REGISTER_NICKNAME, 

	//_S2S_RES_REGISTER_NICKNAME, 
	_D2H_RES_REGISTER_NICKNAME, 

	// GM 요구사항 
	//-----------------------------------------
	_S2S_GM_REQ_GMSERVER_LOGIN, 
	_S2S_GM_RES_GMSERVER_LOGIN, 
	_S2S_GM_ERROR_CODE, 
	_S2S_GM_REQ_GMPROXY_STATUS, 
	_S2S_GM_RES_GMPROXY_STATUS, 
	_S2S_GM_REQ_CHANNEL_POPULATION, 
	_S2S_GM_INFO_CHANNEL_POPULATION, 
	_S2S_GM_REQ_NOTICE_NOW, 
	_S2S_GM_REQ_ACCOUNT_INFO, 
	_S2S_GM_RES_ACCOUNT_INFO, 
	_S2S_GM_REQ_PLAYER_INFO, 
	_S2S_GM_RES_PLAYER_INFO, 
	_S2S_GM_REQ_INVENTORY_INFO, 
	_S2S_GM_RES_INVENTORY_INFO, 
	_S2S_GM_REQ_LOCK_PLAYER, 
	_S2S_GM_RES_LOCK_PLAYER, 
	_S2S_GM_REQ_PLAYER_KICK, 
	_S2S_GM_REQ_EDIT_PLAYER_EXP, 
	_S2S_GM_REQ_EDIT_PLAYER_MONEY, 
	_S2S_GM_REQ_EDIT_PLAYER_BATTLE, 
	_S2S_GM_REQ_EDIT_PLAYER_WEAPON, 
	_S2S_GM_REQ_EDIT_PLAYER_MISSION, 

	// 친구 (이전 메세지, 사용안함)
	//-----------------------------------------
	//_S2N_FRIEND_INFO, 
	//_S2N_FRIEND_STATUS, 
	//_N2S_FRIEND_LIST, 
	//_N2S_FRIEND_INFO, 
	//_N2S_FRIEND_ERROR, 


	// 클랜 메세지 
	//-------------------------------------------
	_H2E_CLAN_ADD,
	_E2H_CLAN_ADD,  
	_E2D_CLAN_ADD,
	_D2E_CLAN_ADD,   
   
	_H2E_CLAN_DELETE,
	_E2H_CLAN_DELETE,
	_E2D_CLAN_DELETE,
	_D2E_CLAN_DELETE,
   
	_H2E_CLAN_UPDATE,
	_E2H_CLAN_UPDATE,
	_E2D_CLAN_UPDATE,
	_D2E_CLAN_UPDATE,
   
	_H2E_CLAN_LIST,
	_E2H_CLAN_LIST,
	_E2D_CLAN_LIST_LOAD,
	_D2E_CLAN_LIST_LOAD,

	_H2E_CLAN_INFO,
	_E2H_CLAN_INFO,

	_H2E_CLAN_DUP_NAME,
	_E2H_CLAN_DUP_NAME,
	_E2D_CLAN_DUP_NAME,
	_D2E_CLAN_DUP_NAME,
   
	_H2E_CLAN_MEMBER_ADD,
	_E2H_CLAN_MEMBER_ADD,
	_E2D_CLAN_MEMBER_ADD,
	_D2E_CLAN_MEMBER_ADD, 
   
	_H2E_CLAN_MEMBER_DELETE,
	_E2H_CLAN_MEMBER_DELETE,
	_E2D_CLAN_MEMBER_DELETE,
	_D2E_CLAN_MEMBER_DELETE,
   
	_H2E_CLAN_MEMBER_UPDATE,
	_E2H_CLAN_MEMBER_UPDATE,
	_E2D_CLAN_MEMBER_UPDATE,
	_D2E_CLAN_MEMBER_UPDATE,
   
	_H2E_CLAN_MEMBER_LIST,
	_E2H_CLAN_MEMBER_LIST,
	_E2D_CLAN_MEMBER_LIST_LOAD,
	_D2E_CLAN_MEMBER_LIST_LOAD,  

	_H2E_CLAN_MEMBER_INFO,
	_E2H_CLAN_MEMBER_INFO,

	_H2E_CLAN_BOARD_ADD,
	_E2H_CLAN_BOARD_ADD,
	_E2D_CLAN_BOARD_ADD,
	_D2E_CLAN_BOARD_ADD,
   
	_H2E_CLAN_BOARD_DELETE,
	_E2H_CLAN_BOARD_DELETE,
	_E2D_CLAN_BOARD_DELETE,
	_D2E_CLAN_BOARD_DELETE,
   
	_H2E_CLAN_BOARD_UPDATE,
	_E2H_CLAN_BOARD_UPDATE,
	_E2D_CLAN_BOARD_UPDATE,
	_D2E_CLAN_BOARD_UPDATE,
   
	_H2E_CLAN_BOARD_LIST,
	_E2H_CLAN_BOARD_LIST,
	_E2D_CLAN_BOARD_LIST_LOAD,
	_D2E_CLAN_BOARD_LIST_LOAD,

	_H2E_CLAN_CHAT,
	_E2H_CLAN_CHAT,
   
	// 쪽지 시스템 
	_H2E_NOTE_SEND,
	_E2H_NOTE_SEND_SENDER,	
	_E2H_NOTE_SEND_RECEIVER,	
	_E2D_NOTE_SEND_SENDER,
	_E2D_NOTE_SEND_RECEIVER,
	_D2E_NOTE_SEND_SENDER,
	_D2E_NOTE_SEND_RECEIVER,

	_H2E_NOTE_REPLY,	
	_E2H_NOTE_REPLY,	
	_E2D_NOTE_REPLY,
	_D2E_NOTE_REPLY,
   
	_H2E_SEND_NOTE_DELETE,
	_E2H_SEND_NOTE_DELETE,
	_E2D_SEND_NOTE_DELETE,
	_D2E_SEND_NOTE_DELETE,

	_H2E_RECV_NOTE_DELETE,
	_E2H_RECV_NOTE_DELETE,
	_E2D_RECV_NOTE_DELETE,
	_D2E_RECV_NOTE_DELETE,
   
	_H2E_SEND_NOTE_LIST,
	_E2H_SEND_NOTE_LIST,
	_E2D_SEND_NOTE_LIST_LOAD,
	_D2E_SEND_NOTE_LIST_LOAD,

	_H2E_RECV_NOTE_LIST,
	_E2H_RECV_NOTE_LIST,
	_E2D_RECV_NOTE_LIST_LOAD,
	_D2E_RECV_NOTE_LIST_LOAD,

	// 친구 시스템 
	//-------------------------------------------
	_H2E_FRIEND_INVITE,
	_E2H_FRIEND_INVITE_SENDER,
	_E2H_FRIEND_INVITE_RECEIVER,

	_H2E_FRIEND_REPLY,
	_E2H_FRIEND_REPLY_SENDER,
	_E2H_FRIEND_REPLY_RECEIVER,
	_E2D_FRIEND_REPLY,

	_H2E_FRIEND_DELETE,
	_E2H_FRIEND_DELETE_SENDER,
	_E2H_FRIEND_DELETE_RECEIVER,
	_E2D_FRIEND_DELETE,

	_H2E_FRIEND_UPDATE,
	_E2H_FRIEND_UPDATE,
	_E2D_FRIEND_UPDATE,

	_H2E_FRIEND_LIST,
	_E2H_FRIEND_LIST,
	_E2D_FRIEND_LIST_LOAD,
	_D2E_FRIEND_LIST_LOAD,

	_H2E_FRIEND_INFO,
	_E2H_FRIEND_INFO,

	_H2E_FRIEND_CHAT,
	_E2H_FRIEND_CHAT,
};




#pragma pack(push)
#pragma pack(1)

// 클라이언트 버전 
const short PROTOCOL_VERSION_HI = 3;
const short PROTOCOL_VERSION_LO = 0;
const TCHAR PROTOCOL_INFO[]  = _T("CBT3 버전 프로토콜");


// 서버 버전 
const short SVR_PROTOCOL_VERSION_HI = 2;
const short SVR_PROTOCOL_VERSION_LO = 3;
const TCHAR SVR_PROTOCOL_INFO[] = _T("CBT 버전 서버 간 프로토콜");



// 클라이언트 프로토콜 
//----------------------------------------------------------------------------------------------------------

// 채널 세션 프로토콜 
//-----------------------------------------
PROTOCOL_DECLARE(S2C_ERROR, _S2C_ERROR)
{
public:
	UINT16	nMsgID;	// 클라이언트가 요청했던 메시지 아이디
	UINT16	nErrCode;	// 에러 코드
	UINT8	nMsgLen;	// 에러 메시지 길이
	WCHAR	szErrMsg[MAX_MSG_LEN+1];
};


PROTOCOL_DECLARE(S2C_DEBUG_MSG, _S2C_DEBUG_MSG)
{
public:
	WCHAR	szMsg[MAX_MSG_LEN+1];
};


PROTOCOL_DECLARE(S2C_ACCEPT, _S2C_ACCEPT)
{
public:
	UINT8	nCode;	// 접속한 서버 구분?
	WCHAR	szClientIP[16];	// 채널 서버에서 보내는 것만 유효
};


PROTOCOL_DECLARE(S2C_HEART_BEAT, _S2C_HEART_BEAT)
{
public:
};


PROTOCOL_DECLARE(C2S_HEART_BEAT, _C2S_HEART_BEAT)
{
public:
};


PROTOCOL_DECLARE(S2C_SERVER_STATUS, _S2C_SERVER_STATUS)
{
public:
	UINT8	nServerCnt;	// 채널 서버 수
	UINT16	ServerStatusList[MAX_SERVER_CNT];	// 채널 서버 상태 정보
};


PROTOCOL_DECLARE(S2C_CHANNEL_STATUS, _S2C_CHANNEL_STATUS)
{
public:
	UINT8	nChannelCnt;	// 채널 수
	UINT8	PopulationPercentList[MAX_CHANNEL_CNT];	// 채널 입장 인원 백분율.
};


PROTOCOL_DECLARE(S2C_SERVER_ADDRESS, _S2C_SERVER_ADDRESS)
{
public:
	UINT8	nCount;	// 개수
	_HG_SERVER_ADDRESS	AddressList[MAX_SERVER_CNT];	// 채널 서버 주소
};


PROTOCOL_DECLARE(C2S_DEVELOPMENT, _C2S_DEVELOPMENT)
{
public:
	UINT32	nDWORD1;	// 4바이트 정수
	UINT32	nDWORD2;	// 4바이트 정수
	UINT32	nDWORD3;	// 4바이트 정수
	UINT32	nDWORD4;	// 4바이트 정수
	UINT16	nWORD1;	// 2바이트 정수
	UINT16	nWORD2;	// 2바이트 정수
	UINT8	nBYTE1;	// 1바이트 정수
	UINT8	nBYTE2;	// 1바이트 정수
	WCHAR	szMessage1[100+1];	// 100바이트 문자열
	WCHAR	szMessage2[100+1];	// 100바이트 문자열
};


PROTOCOL_DECLARE(S2C_DEVELOPMENT, _S2C_DEVELOPMENT)
{
public:
	UINT32	nDWORD1;	// 4바이트 정수
	UINT32	nDWORD2;	// 4바이트 정수
	UINT32	nDWORD3;	// 4바이트 정수
	UINT32	nDWORD4;	// 4바이트 정수
	UINT16	nWORD1;	// 2바이트 정수
	UINT16	nWORD2;	// 2바이트 정수
	UINT8	nBYTE1;	// 1바이트 정수
	UINT8	nBYTE2;	// 1바이트 정수
	WCHAR	szMessage1[100+1];	// 100바이트 문자열
	WCHAR	szMessage2[100+1];	// 100바이트 문자열
};


PROTOCOL_DECLARE(C2S_ENTER_SERVER, _C2S_ENTER_SERVER)
{
public:
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정
	UINT64	nAuthKey;	// 로긴 서버로 부터 발급 받은 인증키
	UINT32	nPlayerUID;
	UINT32	nLocalIP;	// 로컬 아이피 정보
	UINT16	nProtocolVer;
};


PROTOCOL_DECLARE(S2C_ENTER_SERVER_OK, _S2C_ENTER_SERVER_OK)
{
public:
};


PROTOCOL_DECLARE(C2S_LEAVE_SERVER, _C2S_LEAVE_SERVER)
{
public:
};


PROTOCOL_DECLARE(C2S_ENTER_CHANNEL, _C2S_ENTER_CHANNEL)
{
public:
	UINT8	nChannelID;
};


PROTOCOL_DECLARE(S2C_ENTER_CHANNEL_OK, _S2C_ENTER_CHANNEL_OK)
{
public:
	UINT8	nChannelID;
};


PROTOCOL_DECLARE(C2S_LEAVE_CHANNEL, _C2S_LEAVE_CHANNEL)
{
public:
};


PROTOCOL_DECLARE(S2C_LEAVE_CHANNEL_OK, _S2C_LEAVE_CHANNEL_OK)
{
public:
};


PROTOCOL_DECLARE(C2S_CHANGE_SERVER, _C2S_CHANGE_SERVER)
{
public:
	UINT8	ChannelServerID;
};


PROTOCOL_DECLARE(S2C_CHANGE_SERVER, _S2C_CHANGE_SERVER)
{
public:
	UINT8	ChannelServerID;
	UINT8	nResult;	// 0 이 아닌 경우는 에러 코드
};


PROTOCOL_DECLARE(C2S_GET_PLAYER_INFO, _C2S_GET_PLAYER_INFO)
{
public:
};


PROTOCOL_DECLARE(S2C_NEW_PLAYER, _S2C_NEW_PLAYER)
{
public:
};


PROTOCOL_DECLARE(C2S_REGISTER_NICKNAME, _C2S_REGISTER_NICKNAME)
{
public:
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 닉네임 요청
};


PROTOCOL_DECLARE(S2C_REGISTER_NICKNAME, _S2C_REGISTER_NICKNAME)
{
public:
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 요청한 닉네임
	UINT8	nResult;	// 0 이면 성공, 그 외 에러 코드
};


PROTOCOL_DECLARE(C2S_GET_IDCARD_INFO, _C2S_GET_IDCARD_INFO)
{
public:
	UINT32	nTargetPlayerUID;
	UINT8	bRequestBackSide;	// 0이면 앞면, 1이면 뒷면 요청.
	UINT8	bIsTargetFriend;	// 1이면 친구 목록에서만 대상 검색.
};


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


PROTOCOL_DECLARE(S2C_PLAYER_INFO, _S2C_PLAYER_INFO)
{
public:
	UINT32	nPlayerUID;
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 콜싸인
	UINT32	nGameMoney;
	UINT32	nExp;
	UINT32	nOptions;
	UINT32	nClanUID;
	UINT8	nNetwokType;
	UINT8	bIsPCBang;
	UINT8	bEventReward;
};


PROTOCOL_DECLARE(S2C_INVENTORY, _S2C_INVENTORY)
{
public:
	UINT8	nPrimarySlot;
	UINT8	nOpenSlotCount;
	UINT8	nItemCount;
	_CHARAC_INFO	CharacInven[ CHARAC_INVEN_SLOT_MAX ];	//  = 5, 고정 사이즈
	_ITEM_INFO	ItemInven[ ITEM_INVEN_SLOT_MAX ];	// 가변 사이즈
};


PROTOCOL_DECLARE(C2S_PRIMARY_CHARAC, _C2S_PRIMARY_CHARAC)
{
public:
	INT8	nPrimarySlot;	// 플레이 할 주캐릭터 슬롯 인덱스
};


PROTOCOL_DECLARE(S2C_PRIMARY_CHARAC_OK, _S2C_PRIMARY_CHARAC_OK)
{
public:
	INT8	nPrimarySlot;	// 플레이 할 주캐릭터 슬롯 인덱스
};


PROTOCOL_DECLARE(C2S_PUT_ITEM, _C2S_PUT_ITEM)
{
public:
	INT32	nItemID;	// 아이템 아이디
	INT8	nCharacSlot;	// 캐릭터 슬롯
	INT8	nPutType;	// 해제/착용
};


PROTOCOL_DECLARE(S2C_PUT_ITEM_OK, _S2C_PUT_ITEM_OK)
{
public:
	_ITEM_ID	ItemID;	// 아이템 아이디
	INT8	nStatus;	// 해제/착용
	INT8	nCharacSlot;	// 캐릭터 슬롯
	INT8	nPutSlot;	// 해제/착용 슬롯
};


PROTOCOL_DECLARE(C2S_EQUIP_ITEM, _C2S_EQUIP_ITEM)
{
public:
	INT32	nItemID;	// 아이템 아이디
	INT8	nEquipType;	// 인벤/배낭/착용
};


PROTOCOL_DECLARE(S2C_EQUIP_ITEM_OK, _S2C_EQUIP_ITEM_OK)
{
public:
	_ITEM_ID	ItemID;	// 아이템 아이디
	UINT8	nStatus;	// 아이템 상태 정보 [인벤,배낭,착용]
};


PROTOCOL_DECLARE(S2C_UPDATE_CHARAC_INFO, _S2C_UPDATE_CHARAC_INFO)
{
public:
	INT8	nCharacSlot;	// 캐릭터 슬롯
	_CHARAC_INFO	CharacInven;
};


PROTOCOL_DECLARE(S2C_UPDATE_ITEM_INFO, _S2C_UPDATE_ITEM_INFO)
{
public:
	UINT8	nItemCount;
	_ITEM_INFO	Items [ ITEM_INVEN_SLOT_MAX ];	// 가변 사이즈
};


PROTOCOL_DECLARE(C2S_REPAIR_ITEM, _C2S_REPAIR_ITEM)
{
public:
	UINT32	nItemUID;
};


PROTOCOL_DECLARE(S2C_REPAIR_ITEM_OK, _S2C_REPAIR_ITEM_OK)
{
public:
	UINT32	nItemUID;	// 가변 사이즈
	UINT32	nGameMoney;	// 수리하고 남은 돈
	UINT16	nDurablility;	// 내구도
};


PROTOCOL_DECLARE(C2S_BUY_ITEM, _C2S_BUY_ITEM)
{
public:
	UINT16	nItemCode;	// 구입할 아이템 코드
	UINT8	nBuyType;	// 구입 코드
};


PROTOCOL_DECLARE(S2C_BUY_ITEM_OK, _S2C_BUY_ITEM_OK)
{
public:
	_ITEM_INFO	ItemInfo;	// 구입한 아이템 정보
	UINT32	nGameMoney;	// 구입하고 남은 돈 (현재 소지금)
};


PROTOCOL_DECLARE(C2S_SELL_ITEM, _C2S_SELL_ITEM)
{
public:
	UINT32	nItemUID;	// 판매할 아이템 아이디
	UINT16	nItemCode;	// 판매할 아이템 코드
};


PROTOCOL_DECLARE(S2C_SELL_ITEM_OK, _S2C_SELL_ITEM_OK)
{
public:
	UINT32	nItemUID;	// 판매한 아이템 아이디
	UINT32	nGameMoney;	// 판매하고 남은 돈
};


PROTOCOL_DECLARE(C2S_BUY_CHARAC, _C2S_BUY_CHARAC)
{
public:
	INT8	nCharacType;	// 구입할 캐릭터 타입
	UINT8	nBuyType;		// 구입 코드
};


PROTOCOL_DECLARE(S2C_BUY_CHARAC_OK, _S2C_BUY_CHARAC_OK)
{
public:
	INT8	nCharacterIndex;	// 구입한 캐릭터의 슬롯 인덱스
	_CHARAC_INFO	CharacInfo;	// 구입한 캐릭터 정보
	UINT32	nGameMoney;	// 구입하고 남은 돈
};


PROTOCOL_DECLARE(C2S_SELL_CHARAC, _C2S_SELL_CHARAC)
{
public:
	INT8	nCharacterIndex;	// 판매할 캐릭터의 슬롯 인덱스
};


PROTOCOL_DECLARE(S2C_SELL_CHARAC_OK, _S2C_SELL_CHARAC_OK)
{
public:
	INT8	nCharacterIndex;	// 판매한 캐릭터의 슬롯 인덱스
	UINT32	nGameMoney;	// 판매하고 남은 돈
};


PROTOCOL_DECLARE(S2C_BUY_ITEM_NEW, _S2C_BUY_ITEM_NEW)
{
public:
};


PROTOCOL_DECLARE(S2C_LOBBY_MEMBER_LIST, _S2C_LOBBY_MEMBER_LIST)
{
public:
	UINT16	nTotalMemberCount;	// 로비에 입장한 플레이어의 총 수.
	_LOBBY_MEMBER_INFO	AllMemberInfo[MAX_MEMBER_PER_MESSAGE];	// * 존재하는 모든 플레이어 정보.
};


PROTOCOL_DECLARE(S2C_LOBBY_MEMBER_INFO, _S2C_LOBBY_MEMBER_INFO)
{
public:
	_LOBBY_MEMBER_INFO	MemberInfo;
};


PROTOCOL_DECLARE(S2C_LOBBY_MEMBER_REMOVE, _S2C_LOBBY_MEMBER_REMOVE)
{
public:
	UINT64	nPlayerUID;
};


PROTOCOL_DECLARE(S2C_LOBBY_ROOM_LIST, _S2C_LOBBY_ROOM_LIST)
{
public:
	UINT16	nTotalRoomCount;	// 대기실에 존재하는 방의 총 개수.
	_ROOM_SUMMARY	AllRoomSummary[MAX_ROOM_PER_MESSAGE];	// * 존재하는 모든 방 정보.
};


PROTOCOL_DECLARE(S2C_LOBBY_ROOM_INFO, _S2C_LOBBY_ROOM_INFO)
{
public:
	_ROOM_SUMMARY	RoomSummary;	// 전송할 방 정보.
};


PROTOCOL_DECLARE(S2C_LOBBY_ROOM_REMOVE, _S2C_LOBBY_ROOM_REMOVE)
{
public:
	INT8	nRemovedRoomID;	// 삭제된 방 번호.
};


PROTOCOL_DECLARE(C2S_LOBBY_ROOM_DETAIL, _C2S_LOBBY_ROOM_DETAIL)
{
public:
	INT8	nRoomID;	// 방 번호.
};


PROTOCOL_DECLARE(S2C_LOBBY_ROOM_DETAIL, _S2C_LOBBY_ROOM_DETAIL)
{
public:
	_ROOM_DETAIL	RoomDetail;	// 방 상세 정보.
};


PROTOCOL_DECLARE(C2S_HOST_QUOTIENT, _C2S_HOST_QUOTIENT)
{
public:
	INT8	bSaturated;	// 호스트(방장) CPU 랙 여부
	INT8	nLagConnection;	// 호스트에서 송신 버퍼가 찬 클라 체크 (로그)
};


PROTOCOL_DECLARE(S2C_HOST_QUOTIENT, _S2C_HOST_QUOTIENT)
{
public:
	INT8	bSaturated;	// 호스트(방장) CPU 랙 여부
};


PROTOCOL_DECLARE(C2S_ROOM_CREATE, _C2S_ROOM_CREATE)
{
public:
	_BATTLEROOM_OPTION	Option;	// 방 옵션 정보
	WCHAR	szRoomPassword[MAX_ROOM_PASSWORD+1];	// 비밀방일 경우 비밀번호.
};


PROTOCOL_DECLARE(S2C_ROOM_CREATE_OK, _S2C_ROOM_CREATE_OK)
{
public:
	INT32	nEnteredRoomID;	// 생성된 방 번호.
	_BATTLEROOM_OPTION	Option;	// 방 옵션 정보
};


PROTOCOL_DECLARE(C2S_ROOM_OPTION_CHANGE, _C2S_ROOM_OPTION_CHANGE)
{
public:
	_BATTLEROOM_OPTION	Option;	// 방 옵션 정보
};


PROTOCOL_DECLARE(S2C_ROOM_OPTION, _S2C_ROOM_OPTION)
{
public:
	_BATTLEROOM_OPTION	Option;	// 방 옵션 정보
};


PROTOCOL_DECLARE(S2C_ROOM_MEMBER_INFO, _S2C_ROOM_MEMBER_INFO)
{
public:
	UINT32	nPlayerUID;	// 다른 캐릭터는 이것으로 서로 구분.
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 콜사인
	_ROOM_MEMBER_DETAIL	Detail;	// 상세 정보
};


PROTOCOL_DECLARE(S2C_ROOM_MEMBER_DETAIL, _S2C_ROOM_MEMBER_DETAIL)
{
public:
	UINT32	nPlayerUID;
	_ROOM_MEMBER_DETAIL	Detail;	// 상세 정보
};


PROTOCOL_DECLARE(S2C_ROOM_MEMBER_REMOVE, _S2C_ROOM_MEMBER_REMOVE)
{
public:
	UINT32	nPlayerUID;
};


PROTOCOL_DECLARE(C2S_ROOM_JOIN, _C2S_ROOM_JOIN)
{
public:
	INT32	nTargetRoomID;	// 입장할 방 번호.
	WCHAR	szRoomPassword[MAX_ROOM_PASSWORD+1];	// 비밀방일 경우 비밀번호.
};


PROTOCOL_DECLARE(S2C_ROOM_JOIN_OK, _S2C_ROOM_JOIN_OK)
{
public:
	INT32	nEnteredRoomID;	// 입장한 방 번호.
	UINT8	bMatchStarted;	// 0: 매치 시작 안 한 방, 1: 매치 시작 한 방.
	_BATTLEROOM_OPTION	Option;	// 방 옵션 정보
};


PROTOCOL_DECLARE(C2S_ROOM_EXIT, _C2S_ROOM_EXIT)
{
public:
};


PROTOCOL_DECLARE(S2C_ROOM_EXIT_OK, _S2C_ROOM_EXIT_OK)
{
public:
};


PROTOCOL_DECLARE(C2S_ROOM_MEMBER_PING, _C2S_ROOM_MEMBER_PING)
{
public:
	UINT32	nPlayerUID;
	INT32	nPingTime;	// 응답 속도 ms단위.
};


PROTOCOL_DECLARE(S2C_ROOM_MEMBER_PING, _S2C_ROOM_MEMBER_PING)
{
public:
	UINT32	nPlayerUID;
	INT32	nPingTime;	// 응답 속도 ms단위.
};


PROTOCOL_DECLARE(C2S_ROOM_TOGGLE_READY, _C2S_ROOM_TOGGLE_READY)
{
public:
};


PROTOCOL_DECLARE(C2S_ROOM_SWITCH_TEAM, _C2S_ROOM_SWITCH_TEAM)
{
public:
};


PROTOCOL_DECLARE(C2S_ROOM_QUICKJOIN, _C2S_ROOM_QUICKJOIN)
{
public:
};


PROTOCOL_DECLARE(C2S_ROOM_SCENE_CHANGE, _C2S_ROOM_SCENE_CHANGE)
{
public:
	UINT8	nPlayerStatusInRoom;	// EPlayerStatusInRoom 값 중 하나.
};


PROTOCOL_DECLARE(C2S_ROOM_CHANGE_MASTER, _C2S_ROOM_CHANGE_MASTER)
{
public:
	UINT32	nNextMasterPlayerUID;	// 방장을 위임할 플레이어.
};


PROTOCOL_DECLARE(C2S_ROOM_PLAYER_OUTFIT, _C2S_ROOM_PLAYER_OUTFIT)
{
public:
	UINT32	nTargetPlayerUID;	// 대상 플레이어.
};


PROTOCOL_DECLARE(S2C_ROOM_PLAYER_OUTFIT, _S2C_ROOM_PLAYER_OUTFIT)
{
public:
	UINT32	nTargetPlayerUID;	// 대상 플레이어.
	_PEER_CHARAC_INFO	PrimaryCharacInfo;	// 캐릭터 정보.
	UINT16	EquipItemCodes[ITEM_EQUIP_SLOT_MAX];	// 착용 아이템 정보.
};


PROTOCOL_DECLARE(C2S_ROOM_TRAINING_START, _C2S_ROOM_TRAINING_START)
{
public:
	UINT8	bRankMode;	// 경쟁모드 여부.
};


PROTOCOL_DECLARE(C2S_ROOM_TRAINING_SUCCESS, _C2S_ROOM_TRAINING_SUCCESS)
{
public:
};


PROTOCOL_DECLARE(C2S_VOTE_PROPOSE, _C2S_VOTE_PROPOSE)
{
public:
	UINT32	nProposedPlayerUID;	// 투표를 발의한 플레이어.
	UINT32	nTargetPlayerUID;	// 투표 대상 플레이어.
	WCHAR	szVoteReason[MAX_VOTEREASON_LEN+1];	// 투표 사유.
};


PROTOCOL_DECLARE(S2C_VOTE_PROPOSED, _S2C_VOTE_PROPOSED)
{
public:
	UINT32	nProposedPlayerUID;	// 투표를 발의한 플레이어.
	UINT32	nTargetPlayerUID;	// 투표 대상 플레이어.
	UINT8	bTimeToExpire;	// 투표 시간. (초)
	WCHAR	szVoteReason[MAX_VOTEREASON_LEN+1];	// 투표 사유.
};


PROTOCOL_DECLARE(C2S_VOTE_CAST, _C2S_VOTE_CAST)
{
public:
	UINT8	bAgree;	// 1: 찬성, 0: 반대.
};


PROTOCOL_DECLARE(S2C_VOTE_FINISHED, _S2C_VOTE_FINISHED)
{
public:
	UINT8	bResult;	// 1: 가결, 0: 부결.
	UINT8	bTimeUntilKick;	// 강제 퇴장 집행시까지의 시간. (초)
};


PROTOCOL_DECLARE(C2S_INVITE_REQ_LOBBY_PLAYERS, _C2S_INVITE_REQ_LOBBY_PLAYERS)
{
public:
};


PROTOCOL_DECLARE(S2C_INVITE_RES_LOBBY_PLAYERS, _S2C_INVITE_RES_LOBBY_PLAYERS)
{
public:
	_LOBBY_MEMBER_INFO	InvitePlayers[MAX_INVITE_LOBBY_PLAYERS];	// 초대 가능한 로비 플레이어 목록.
};


PROTOCOL_DECLARE(C2S_INVITE_TARGET_SELECTED, _C2S_INVITE_TARGET_SELECTED)
{
public:
	UINT32	TargetPlayers[MAX_INVITE_LOBBY_PLAYERS];	// 초대하기로 결정한 플레이어 UID 목록.
};


PROTOCOL_DECLARE(S2C_INVITE_LOBBY_INVITATION, _S2C_INVITE_LOBBY_INVITATION)
{
public:
	INT32	nTargetRoomID;	// 초대 받은 방 번호.
	UINT16	nKillLimit;
	UINT8	nRoundLimit;
	UINT16	nTimeLimit;
};


PROTOCOL_DECLARE(C2S_INVITE_INVITATION_REPLY, _C2S_INVITE_INVITATION_REPLY)
{
public:
	UINT8	bAgree;	// 1: 수락, 0: 거부.
};


PROTOCOL_DECLARE(C2S_MATCH_REQ_START, _C2S_MATCH_REQ_START)
{
public:
};


PROTOCOL_DECLARE(S2C_MATCH_START, _S2C_MATCH_START)
{
public:
};


PROTOCOL_DECLARE(S2C_MATCH_INFO_HOST, _S2C_MATCH_INFO_HOST)
{
public:
	UINT32	nHostPlayerUID;	// 호스트 표시 및 응답 속도 표시에 필요.
	UINT32	nMatchKey;
	UINT32	nHostIP;
	UINT16	nHostPort;
	UINT8	nConnType;
	UINT32	nHostIP2;
	UINT16	nHostPort2;
};


PROTOCOL_DECLARE(S2C_MATCH_INFO_CLIENT, _S2C_MATCH_INFO_CLIENT)
{
public:
	UINT32	nClientPlayerUID;	// 클라이언트 표시 및 응답 속도 표시에 필요.
	UINT32	nMatchKey;
	UINT32	nClientIP;
	UINT16	nClientPort;
	UINT8	nConnType;
};


PROTOCOL_DECLARE(C2S_MATCH_FINISH, _C2S_MATCH_FINISH)
{
public:
};


PROTOCOL_DECLARE(S2C_MATCH_RETURN_ROOM, _S2C_MATCH_RETURN_ROOM)
{
public:
	UINT8	bSoleReturn;	// 자신만 대기실로 돌아가는 경우
};


PROTOCOL_DECLARE(S2C_MATCH_ALLOW_CLIENT, _S2C_MATCH_ALLOW_CLIENT)
{
public:
	UINT32	nPlayerUID;
};


PROTOCOL_DECLARE(S2C_MATCH_INFO_CHARACTER, _S2C_MATCH_INFO_CHARACTER)
{
public:
	UINT32	nPeerPlayerUID;
	_PEER_CHARAC_INFO	CharacInfo;	// 캐릭터가 착용 중인 아이템 코드
	UINT8	nItem;	// 전송하는 아이템 개수
	_PEER_ITEM_INFO	ItemList[PEER_ITEM_TO_HOST_MAX];	// 배낭 및 착용 아이템 목록
};


PROTOCOL_DECLARE(C2S_MATCH_REQ_CANCEL, _C2S_MATCH_REQ_CANCEL)
{
public:
};


PROTOCOL_DECLARE(C2S_MATCH_PLAYER_PROGRESS, _C2S_MATCH_PLAYER_PROGRESS)
{
public:
	_PLAYER_LEVEL_PROGRESS	PlayerProgressInfo;	// 플레이어 진행 정보.
};


PROTOCOL_DECLARE(S2C_MATCH_CURRENT_PROGRESS, _S2C_MATCH_CURRENT_PROGRESS)
{
public:
	UINT8	nCurrentRound;	// 현재 진행중인 라운드. (워밍업은 0)
	UINT16	nRoundTimePassed;	// 라운드 개시 후 경과한 시간. (초)
	UINT16	nTeam0Score;	// 팀 0의 점수.
	UINT16	nTeam1Score;	// 팀 1의 점수.
	UINT8	nTeam0RoundScore;	// 팀 0의 라운드 점수.
	UINT8	nTeam1RoundScore;	// 팀 1의 라운드 점수.
	UINT8	nGameObjectStatus;	// 게임오브젝트 상태.
	UINT8	nGameObjectPlantedTeamID;	// 게임오브젝트 설치한 팀ID.
	UINT16	nGameObjectPlanteTimePassed;	// 게임오브젝트 설치 후 경과한 시간. (초)
	UINT32	GameObjectHoldPlayerUID;	// 게임오브젝트 소유자.
	_UNREAL_LEVEL_LOCATION	GameObjectLocation;	// 게임오브젝트 위치.
};


PROTOCOL_DECLARE(S2C_MATCH_PLAYER_PROGRESS, _S2C_MATCH_PLAYER_PROGRESS)
{
public:
	UINT32	PlayerUID;
	UINT8	nPlayerScore;	// 개인 점수.
	UINT8	nPlayerDeath;	// 개인 죽음 수.
	UINT16	nMissionContribution;	// 기여도.
	UINT16	nPlayerMoney;	// 개인 머니
	UINT8	bAcePlayer;	// 팀 에이스 여부.
	_PLAYER_LEVEL_PROGRESS	PlayerProgressInfo;	// 플레이어 진행 정보.
};


PROTOCOL_DECLARE(C2S_MATCH_HOST_ALIVE, _C2S_MATCH_HOST_ALIVE)
{
public:
	_UNREAL_LEVEL_LOCATION	PlayerLocation;	// 플레이어 위치.
};


PROTOCOL_DECLARE(S2C_MATCH_CLIENT_BATTLE_INFO, _S2C_MATCH_CLIENT_BATTLE_INFO)
{
public:
	UINT32	nPlayerUID;
	UINT8	bIsAcePlayer;	// 에이스 플레이어인지 여부.
	UINT16	nContribution;	// 기여도 값.
};


PROTOCOL_DECLARE(C2S_MATCH_LISTEN_STARTED, _C2S_MATCH_LISTEN_STARTED)
{
public:
	UINT16	nListenPort;	// 리슨 시작한 포트 번호.
};


PROTOCOL_DECLARE(S2C_MATCH_HOST_MIGRATION, _S2C_MATCH_HOST_MIGRATION)
{
public:
	_LOBBY_MEMBER_INFO	OldHostInfo;	// 전 방장 정보
	_LOBBY_MEMBER_INFO	NewHostInfo;	// 새 방장 정보
};


PROTOCOL_DECLARE(C2S_CHAT, _C2S_CHAT)
{
public:
	UINT8	ChatType;	// 채팅 타입
	UINT32	ToPlayerUID;	// 수신할 플레이어, 필요없으면 0으로 설정
	WCHAR	szChatString[MAX_CHAT_LEN+1];
};


PROTOCOL_DECLARE(S2C_CHAT, _S2C_CHAT)
{
public:
	UINT8	ChatType;	// 채팅 타입
	UINT32	nPlayerUID;	// 말한 플레이어
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 말한 플레이어
	WCHAR	szChatString[MAX_CHAT_LEN+1];
};


PROTOCOL_DECLARE(C2S_JUMPTO, _C2S_JUMPTO)
{
public:
	UINT32	nTargetPlayerUID;
};


PROTOCOL_DECLARE(S2C_JUMPTO, _S2C_JUMPTO)
{
public:
	UINT8	nChannelServerID;
	UINT32	nTargetPlayerUID;
};


PROTOCOL_DECLARE(C2S_MISSION_PLAYER_KILL, _C2S_MISSION_PLAYER_KILL)
{
public:
	UINT32	nAttackPlayerUID;	// 공격자 플레이어
	UINT32	nVictimPlayerUID;	// 희생자 플레이어
	_ITEM_ID	AttackWeaponItem;	// 공격자의 무기 아이템
	_UNREAL_LEVEL_LOCATION	AttackLocation;	// 공격자 위치.
	_ITEM_ID	VictimWeaponItem;	// 희생자의 무기 아이템
	_UNREAL_LEVEL_LOCATION	VictimLocation;	// 희생자 위치.
	UINT8	bVictimHeadshot;	// 1: 희생자 헤드샷, 0: 일반.
	UINT8	bVictimMoving;	// 1: 희생자 이동 중, 0: 희생자 정지 중.
	UINT8	bVictimCovered;	// 1: 희생자 엄폐 중, 0: 일반.
};


PROTOCOL_DECLARE(C2S_MISSION_EVENT, _C2S_MISSION_EVENT)
{
public:
	UINT8	nEventType;	// 이벤트 코드.
	UINT32	nEventPlayerUID;	// 이벤트 발생 플레이어
	UINT8	nEventTeamID;	// 이벤트 발생 팀
	_UNREAL_LEVEL_LOCATION	EventLocation;	// 이벤트 발생 위치.
};


PROTOCOL_DECLARE(C2S_MISSION_ITEM_EQUIP, _C2S_MISSION_ITEM_EQUIP)
{
public:
};


PROTOCOL_DECLARE(S2C_MISSION_SCORE, _S2C_MISSION_SCORE)
{
public:
	UINT8	nWinnerTeamID;	// 승리한 팀. 무승부일 경우 255
	UINT8	nLoserTeamID;	// 패배한 팀. 무승부일 경우 255
	_MATCH_RESULT	Team0PlayerRank[MAX_PLAYER_PER_TEAM];	// 팀0의 순위 및 결과 정보. (1위부터 순서대로)
	_MATCH_RESULT	Team1PlayerRank[MAX_PLAYER_PER_TEAM];	// 팀1의 순위 및 결과 정보. (1위부터 순서대로)
};


PROTOCOL_DECLARE(S2C_UPDATE_CASHPOINT, _S2C_UPDATE_CASHPOINT)
{
public:
	UINT32	nCurrentCashPoint;	// 현재 소지한 캐시 포인트
};


PROTOCOL_DECLARE(S2C_EVENT_RESULT, _S2C_EVENT_RESULT)
{
public:
	UINT8	nEventID;	// 이벤트 아이디
};


PROTOCOL_DECLARE(C2S_NAT_RESOLVE_START, _C2S_NAT_RESOLVE_START)
{
public:
	UINT16	nClientTestPort;
};


PROTOCOL_DECLARE(S2C_NAT_RESOLVE_INFO, _S2C_NAT_RESOLVE_INFO)
{
public:
	UINT32	nConnKey;
	UINT32	nTestIP_A;
	UINT32	nTestIP_B;
	UINT32	nTestIP_C;
	UINT16	nTestPort_A;
	UINT16	nTestPort_B;
	UINT16	nTestPort_C;
};


PROTOCOL_DECLARE(C2S_NAT_RESOLVE_END, _C2S_NAT_RESOLVE_END)
{
public:
	UINT16	nAverageRTT;
	UINT8	nTestResult;
};


PROTOCOL_DECLARE(C2S_FULLCONE_RESULT, _C2S_FULLCONE_RESULT)
{
public:
	UINT32	nPublicIP;
	UINT16	nPublicPort;
};


// 클라이언트 클랜 메세지 
//-------------------------------------------------------------------
// 클랜 생성
PROTOCOL_DECLARE(C2S_CLAN_ADD, _C2S_CLAN_ADD)
{
public:
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_CLAN_ADD, _S2C_CLAN_ADD)
{
public:
	UINT32	clanID;	
	UINT8	result;    // 0.실패 1.성공

	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
	WCHAR	master[NICKNAME_LEN_MAX+1];
	UINT32	masterPlayerID;	
	UINT16	maxCrew;	
};

// 클랜 삭제
PROTOCOL_DECLARE(C2S_CLAN_DELETE, _C2S_CLAN_DELETE)
{
public:
	UINT32	clanID;	
};

PROTOCOL_DECLARE(S2C_CLAN_DELETE, _S2C_CLAN_DELETE)
{
public:
	UINT32	clanID;	
	UINT8	result;    // 0.실패 1.성공
};

// 클랜 수정
PROTOCOL_DECLARE(C2S_CLAN_UPDATE, _C2S_CLAN_UPDATE)
{
public:
	UINT32	clanID;	
};

PROTOCOL_DECLARE(S2C_CLAN_UPDATE, _S2C_CLAN_UPDATE)
{
public:
	UINT8	result;    // 0.실패 1.성공

	_CLAN_INFO  clanInfo;
};

// 클랜 리스트 
PROTOCOL_DECLARE(C2S_CLAN_LIST, _C2S_CLAN_LIST)
{
public:
	UINT16	pageNO;
};

PROTOCOL_DECLARE(S2C_CLAN_LIST, _S2C_CLAN_LIST)
{
public:
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16	size;

	_CLAN_INFO clanInfo[CLAN_LIST_LOAD_MAX];
};

// 클랜 정보 
PROTOCOL_DECLARE(C2S_CLAN_INFO, _C2S_CLAN_INFO)
{
public:	
	UINT32	clanID;  // 현재 사용안함 
};

PROTOCOL_DECLARE(S2C_CLAN_INFO, _S2C_CLAN_INFO)
{
public:
	_CLAN_INFO clanInfo;
};

// 클랜이름 중복 체크 
PROTOCOL_DECLARE(C2S_CLAN_DUP_NAME, _C2S_CLAN_DUP_NAME)
{
public:	
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(S2C_CLAN_DUP_NAME, _S2C_CLAN_DUP_NAME)
{
public:
	UINT8	result;    // 0.실패 1.성공
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	
};

// 클랜원 등록
PROTOCOL_DECLARE(C2S_CLAN_MEMBER_ADD, _C2S_CLAN_MEMBER_ADD)
{
public:
	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_CLAN_MEMBER_ADD, _S2C_CLAN_MEMBER_ADD)
{
public:
	UINT32	clanID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
	UINT8	level;

};

// 클랜원 삭제
PROTOCOL_DECLARE(C2S_CLAN_MEMBER_DELETE, _C2S_CLAN_MEMBER_DELETE)
{
public:
	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_CLAN_MEMBER_DELETE, _S2C_CLAN_MEMBER_DELETE)
{
public:
	UINT32	clanID;
	UINT8	result;			// 0.실패 1.성공
	UINT8	deleteType;		// 0.본인이 요청 1.마스터가 요청 

	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

// 클랜원 수정
PROTOCOL_DECLARE(C2S_CLAN_MEMBER_UPDATE, _C2S_CLAN_MEMBER_UPDATE)
{
public:
	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_CLAN_MEMBER_UPDATE, _S2C_CLAN_MEMBER_UPDATE)
{
public:
	UINT32	clanID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

// 클랜원 리스트 
PROTOCOL_DECLARE(C2S_CLAN_MEMBER_LIST, _C2S_CLAN_MEMBER_LIST)
{
public:
	UINT32	clanID;
	UINT16	pageNO;
	UINT8	onOff;    // 0.off(전부) 1.on(온라인만)
};

PROTOCOL_DECLARE(S2C_CLAN_MEMBER_LIST, _S2C_CLAN_MEMBER_LIST)
{
public:
	UINT32	clanID;		
	UINT16	pageNO;
	UINT8	onOff;    // 0.off(전부) 1.on(온라인만)
	UINT16	totalSize;
	UINT16	size;

	_CLAN_MEMBER_INFO  clanMemberInfo[CLAN_MEMBER_LIST_LOAD_MAX];
};

// 클랜원 정보
PROTOCOL_DECLARE(C2S_CLAN_MEMBER_INFO, _C2S_CLAN_MEMBER_INFO)
{
public:
	UINT32	clanID;
};

PROTOCOL_DECLARE(S2C_CLAN_MEMBER_INFO, _S2C_CLAN_MEMBER_INFO)
{
public:
	UINT32	clanID;		

	_CLAN_MEMBER_INFO  clanMemberInfo;
};


// 클랜 게시판 등록
PROTOCOL_DECLARE(C2S_CLAN_BOARD_ADD, _C2S_CLAN_BOARD_ADD)
{
public:
	UINT32	clanID;	

	WCHAR	title[CLAN_BOARD_TITLE_LEN_MAX+1];
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_CLAN_BOARD_ADD, _S2C_CLAN_BOARD_ADD)
{
public:	
	UINT32	clanID;	
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanBoardID;
	WCHAR	title[CLAN_BOARD_TITLE_LEN_MAX+1];
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
	UINT64	createDate;
};

// 클랜 게시판 삭제 
PROTOCOL_DECLARE(C2S_CLAN_BOARD_DELETE, _C2S_CLAN_BOARD_DELETE)
{
public:
	UINT32	clanID;
	UINT32	clanBoardID;	
};

PROTOCOL_DECLARE(S2C_CLAN_BOARD_DELETE, _S2C_CLAN_BOARD_DELETE)
{
public:	
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanBoardID;	
};

// 클랜 게시판 수정 
PROTOCOL_DECLARE(C2S_CLAN_BOARD_UPDATE, _C2S_CLAN_BOARD_UPDATE)
{
public:
	UINT32	clanID;
	UINT32	clanBoardID;	
	
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_CLAN_BOARD_UPDATE, _S2C_CLAN_BOARD_UPDATE)
{
public:
	UINT32	clanID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanBoardID;		
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
};

// 클랜 게시판 리스트 
PROTOCOL_DECLARE(C2S_CLAN_BOARD_LIST, _C2S_CLAN_BOARD_LIST)
{
public:
	UINT32	clanID;
	UINT16	pageNO;
};

PROTOCOL_DECLARE(S2C_CLAN_BOARD_LIST, _S2C_CLAN_BOARD_LIST)
{
public:
	UINT32	clanID;
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16  size;

	_CLAN_BOARD_INFO  clanBoardInfo[CLAN_BOARD_LIST_LOAD_MAX];
};


// 쪽지 보내기
//-----------------------------------------------------

// 쪽지를 보낸다.
PROTOCOL_DECLARE(C2S_NOTE_SEND, _C2S_NOTE_SEND)
{
public:	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];

	UINT8	isGroup;        // 0.기본쪽지 1.단체쪽지 
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];
};

// 보낸 쪽지함 확인(보낸사람)
PROTOCOL_DECLARE(S2C_NOTE_SEND_SENDER, _S2C_NOTE_SEND_SENDER)
{
public:
	UINT8	sendResult;   // 1 성공, 2 실패(캐릭없슴), 3 실패(편지함 full)

	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];

	UINT32	noteID;	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];
	UINT64	createDate;
};

// 받은 쪽지함 확인(받은사람) 
PROTOCOL_DECLARE(S2C_NOTE_SEND_RECEIVER, _S2C_NOTE_SEND_RECEIVER)
{
public:
	UINT32	sendPlayerID;
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];

	UINT32	noteID;	
	UINT8	isRead;			// 0.안읽음 1.읽음
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답 OK 2. 응답 NO
	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];
	UINT64	createDate;
};

// 쪽지 응답 
PROTOCOL_DECLARE(C2S_NOTE_REPLY, _C2S_NOTE_REPLY)
{
public:
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];

	UINT32	noteID;		
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO
	UINT32	clanID;
};


PROTOCOL_DECLARE(S2C_NOTE_REPLY, _S2C_NOTE_REPLY)
{
public:	
	UINT8	result;			// 0.실패 1.성공

	UINT32	noteID;		
	UINT8	isRead;			// 0.안읽음 1.읽음
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO
	UINT32	clanID;
	UINT64	createDate;
};


// 받은 쪽지 삭제 
PROTOCOL_DECLARE(C2S_RECV_NOTE_DELETE, _C2S_RECV_NOTE_DELETE)
{
public:	
	UINT32	noteID;
};

PROTOCOL_DECLARE(S2C_RECV_NOTE_DELETE, _S2C_RECV_NOTE_DELETE)
{
public:	
	UINT8	result;    // 0.실패 1.성공

	UINT32	noteID;	
};

// 보낸 쪽지 삭제 
PROTOCOL_DECLARE(C2S_SEND_NOTE_DELETE, _C2S_SEND_NOTE_DELETE)
{
public:	
	UINT32	noteID;
};

PROTOCOL_DECLARE(S2C_SEND_NOTE_DELETE, _S2C_SEND_NOTE_DELETE)
{
public:	
	UINT8	result;    // 0.실패 1.성공

	UINT32	noteID;	
};

// 받은 쪽지 리스트 
PROTOCOL_DECLARE(C2S_RECV_NOTE_LIST, _C2S_RECV_NOTE_LIST)
{
public:	
	UINT16	pageNO;
};

PROTOCOL_DECLARE(S2C_RECV_NOTE_LIST, _S2C_RECV_NOTE_LIST)
{
public:	
	UINT8	result;    // 0.실패 1.성공

	UINT16	pageNO;
	UINT16	totalSize;
	UINT16  size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};

// 보낸 쪽지 리스트 
PROTOCOL_DECLARE(C2S_SEND_NOTE_LIST, _C2S_SEND_NOTE_LIST)
{
public:	
	UINT16	pageNO;
};

PROTOCOL_DECLARE(S2C_SEND_NOTE_LIST, _S2C_SEND_NOTE_LIST)
{
public:
	UINT32	playerID;
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16  size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};


// 친구 시스템
//-----------------------------------------------------

// 친구등록을 요청한다.
PROTOCOL_DECLARE(C2S_FRIEND_INVITE, _C2S_FRIEND_INVITE)
{
public:	
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_FRIEND_INVITE_SENDER, _S2C_FRIEND_INVITE_SENDER)
{
public:	
	UINT8	result;    // 0.실패 1.성공
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_FRIEND_INVITE_RECEIVER, _S2C_FRIEND_INVITE_RECEIVER)
{
public:	
	UINT32	sendPlayerID;
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];
};

// 친구 등록 요청에대한 응답을 한다.
PROTOCOL_DECLARE(C2S_FRIEND_REPLY, _C2S_FRIEND_REPLY)
{
public:	
	UINT8	replyResult;    // 1.응답 OK 2. 응답 NO
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_FRIEND_REPLY_SENDER, _S2C_FRIEND_REPLY_SENDER)
{
public:	
	UINT8	result;			// 0.실패 1.성공
	UINT8	replyResult;    // 1.응답 OK 2. 응답 NO
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(S2C_FRIEND_REPLY_RECEIVER, _S2C_FRIEND_REPLY_RECEIVER)
{
public:	
	UINT8	replyResult;    // 1.응답 OK 2. 응답 NO
	UINT32	sendPlayerID;
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];	
};

// 친구를 삭제한다.
PROTOCOL_DECLARE(C2S_FRIEND_DELETE, _C2S_FRIEND_DELETE)
{
public:	
	UINT32	fPlayerID;
	WCHAR	fCallsign[NICKNAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(S2C_FRIEND_DELETE_SENDER, _S2C_FRIEND_DELETE_SENDER)
{
public:	
	UINT8	result;			// 0.실패 1.성공
	UINT32	fPlayerID;
	WCHAR	fCallsign[NICKNAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(S2C_FRIEND_DELETE_RECEIVER, _S2C_FRIEND_DELETE_RECEIVER)
{
public:	
	UINT32	sendPlayerID;
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];	
};

// 친구를 갱신한다.
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
	UINT8	result;			// 0.실패 1.성공
	UINT32	fPlayerID;
	UINT8	status;
};

// 친구 리스트를 요청한다.
PROTOCOL_DECLARE(C2S_FRIEND_LIST, _C2S_FRIEND_LIST)
{
public:	
	UINT16	pageNO;
};

PROTOCOL_DECLARE(S2C_FRIEND_LIST, _S2C_FRIEND_LIST)
{
public:	
	UINT16	size;

	_FRIEND_INFO  friendInfo[FRIEND_LIST_LOAD_MAX];
};



















// 로그인 프로토콜 
//-----------------------------------------
PROTOCOL_DECLARE(C2S_VERSION, _C2S_VERSION)
{
public:
	WORD	nMajorVer;
	WORD	nMinorVer;
};


PROTOCOL_DECLARE(C2S_GAME_LOGIN, _C2S_GAME_LOGIN)
{
public:
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
	WCHAR	szPassword[PASSWD_LEN_MAX+1];	// 비밀번호 길이 확인 및 암호화
	WORD	nCookieSize;	// 쿠키 크기
	BYTE	AuthCookie[COOKIE_SIZE];	// 웹 로긴 시에 받은 쿠키
};


PROTOCOL_DECLARE(S2C_GAME_LOGIN_OK, _S2C_GAME_LOGIN_OK)
{
public:
	UINT64	nAuthKey;	// 로긴서버에서 발급한 인증키
	UINT32	nPlayerUID;	// 계정 별로 할당된 정수키
	UINT64	nServerCurTime;	// 현재 서버 시각
	UINT8	nGamerights;	// 0:일반/1:미제휴PC방/2:제휴PC방/9:GM실행
	UINT8	IsAdult;		// 15세 18세 성인인증

	UINT8   size;

	_LOCAL_SERVER_INFO  info[MAX_SERVER_CNT];
};


// 릴레이 프로토콜 
//-----------------------------------------
PROTOCOL_DECLARE(WELCOME_PING, _WELCOME_PING)
{
public:		
	UINT8	IP[16];
	UINT16	Port;
};


PROTOCOL_DECLARE(RELAY_PING, _RELAY_PING)
{
public:	
	UINT32	nPingTime;
	UINT8	nPingCnt;
};

PROTOCOL_DECLARE(RELAY_PONG, _RELAY_PONG)
{
public:
	UINT32	nPingTime;
	UINT8	nPingCnt;
};

PROTOCOL_DECLARE(INVITE_PING, _INVITE_PING)
{
public:
	UINT32	nIP;
	UINT16	Port;
	UINT32	InviteKey;
};















// 서버 프로토콜 
//-----------------------------------------------------------------------------------------------------------------

PROTOCOL_DECLARE(G2E_REQ_SERVER_LOGIN, _G2E_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(E2G_REQ_SERVER_LOGIN, _E2G_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(E2D_REQ_SERVER_LOGIN, _E2D_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(H2E_REQ_SERVER_LOGIN, _H2E_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(H2N_REQ_SERVER_LOGIN, _H2N_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(H2D_REQ_SERVER_LOGIN, _H2D_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(L2D_REQ_SERVER_LOGIN, _L2D_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(L2E_REQ_SERVER_LOGIN, _L2E_REQ_SERVER_LOGIN)
{
public:
	UINT8	nServerID;	// 서버 아이디
	UINT16	nServerVersion;
	WCHAR	ServerType;	// 서버 형식. 단일 문자.
};

PROTOCOL_DECLARE(E2G_RES_SERVER_LOGIN, _E2G_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(G2E_RES_SERVER_LOGIN, _G2E_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(D2E_RES_SERVER_LOGIN, _D2E_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(E2H_RES_SERVER_LOGIN, _E2H_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(N2H_RES_SERVER_LOGIN, _N2H_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(D2H_RES_SERVER_LOGIN, _D2H_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(D2L_RES_SERVER_LOGIN, _D2L_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};

PROTOCOL_DECLARE(E2L_RES_SERVER_LOGIN, _E2L_RES_SERVER_LOGIN)
{
public:
	UINT8	nResultCode;
};


PROTOCOL_DECLARE(H2E_CMD_MSG, _H2E_CMD_MSG)
{
public:
	UINT8	nCmdType;	// 0, 1
	UINT8	Message[1024];
};

PROTOCOL_DECLARE(L2D_DB_MEMBER_ADD, _L2D_DB_MEMBER_ADD)
{
public:
	UINT32	sessionID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
	UINT32	playerID;  // gsp로부터 받은 playerid 
};


PROTOCOL_DECLARE(D2L_DB_MEMBER_ADD, _D2L_DB_MEMBER_ADD)
{
public:
	UINT32	sessionID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
};

PROTOCOL_DECLARE(L2D_REQ_MEMBER_INFO, _L2D_REQ_MEMBER_INFO)
{
public:
	UINT32	nRequestID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
};

PROTOCOL_DECLARE(D2L_RES_MEMBER_INFO, _D2L_RES_MEMBER_INFO)
{
public:
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT8	nStatus;	// 접속 상태 정보
	UINT32	nCreatedDate;	// 게임에 최초 로그인한 날짜
};

PROTOCOL_DECLARE(L2E_SEND_LOGIN_INFO, _L2E_SEND_LOGIN_INFO)
{
public:
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
	UINT64	nAuthKey;	// 로긴서버에서 발급한 인증키
	UINT32	nPlayerUID;	// 게임 회원 디비에서 발급한 키
	UINT32	LoginIP;	// 접속한 아이피
	UINT8	nGamerights;	// 0:일반/1:미제휴PC방/2:제휴PC방/9:GM실행
	UINT32	nExecutekey;	// GSP에서 받은 실행키, 빌링 연동에 필요
	UINT32	nCreatedDate;	// 게임에 최초 로그인한 날짜
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// GSP에서 받아온 닉네임(=콜싸인)
};

PROTOCOL_DECLARE(E2L_SERVER_STATUS, _E2L_SERVER_STATUS)
{
public:
	UINT8	nServerCnt;	// 채널 서버 수
	UINT16	PopulationStatusList[MAX_SERVER_CNT];	// 채널 서버 별 현재 접속자 상태
};

PROTOCOL_DECLARE(E2H_SERVER_STATUS, _E2H_SERVER_STATUS)
{
public:
	UINT8	nServerCnt;	// 채널 서버 수
	UINT16	PopulationStatusList[MAX_SERVER_CNT];	// 채널 서버 별 현재 접속자 상태
};

PROTOCOL_DECLARE(L2E_SERVER_POPULATION_LIMIT, _L2E_SERVER_POPULATION_LIMIT)
{
public:
	UINT16	PopulationNormal;	// 접속자 수 기준(원활)
	UINT16	PopulationBusy;	// 접속자 수 기준(혼잡)
	UINT16	PopulationFull;	// 접속자 수 기준(만원)
};

PROTOCOL_DECLARE(H2E_REQ_PLAYER_ENTER, _H2E_REQ_PLAYER_ENTER)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT64	nAuthKey;
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// 계정 길이 확인
};

PROTOCOL_DECLARE(E2H_RES_PLAYER_ENTER, _E2H_RES_PLAYER_ENTER)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT8	nResultCode;	// 0 이면 성공, 아니면 에러 코드
	UINT8	bIsMoveServer;	// 1 이면 채널 서버 이동, 0 이면 최초 접속.
	UINT32	nTimePassedSinceLoginMS;	// 로그인 후 경과 시간(밀리초).
	UINT8	nGamerights;	// 0:일반/1:미제휴PC방/2:제휴PC방/9:GM실행
	UINT32	nExecutekey;	// GSP에서 받은 실행키, 빌링 연동에 필요
	UINT32	nCreatedDate;	// 게임에 최초 로그인한 날짜
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// GSP에서 받아온 닉네임(=콜싸인)
};

PROTOCOL_DECLARE(E2H_REQ_PLAYER_LEAVE, _E2H_REQ_PLAYER_LEAVE)
{
public:
	UINT64	nAuthKey;
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT8	nLogoutType;
};

PROTOCOL_DECLARE(H2E_REQ_PLAYER_LEAVE, _H2E_REQ_PLAYER_LEAVE)
{
public:
	UINT64	nAuthKey;
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT8	nLogoutType;
};

PROTOCOL_DECLARE(H2E_REQ_CHANGE_SERVER, _H2E_REQ_CHANGE_SERVER)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT8	nChannelServerID;
	UINT32	nJumpToPlayerUID;	// 따라갈 플레이어
};

PROTOCOL_DECLARE(E2H_RES_CHANGE_SERVER, _E2H_RES_CHANGE_SERVER)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT8	nChannelServerID;
	UINT8	nResult;
};

PROTOCOL_DECLARE(E2H_PLAYER_CHAT, _E2H_PLAYER_CHAT)
{
public:
	UINT8	ChatType;	// 채팅 타입
	UINT32	nPlayerUIDFrom;	// 말한 플레이어
	UINT32	nPlayerUIDTo;	// 들을 플레이어
	WCHAR	szNicknameFrom[NICKNAME_LEN_MAX+1];	// 말한 플레이어 닉네임
	WCHAR	szNicknameTo[NICKNAME_LEN_MAX+1];	// 들을 플레이어 닉네임
	WCHAR	szChatString[MAX_CHAT_LEN+1];
};

PROTOCOL_DECLARE(H2E_PLAYER_CHAT, _H2E_PLAYER_CHAT)
{
public:
	UINT8	ChatType;	// 채팅 타입
	UINT32	nPlayerUIDFrom;	// 말한 플레이어
	UINT32	nPlayerUIDTo;	// 들을 플레이어
	WCHAR	szNicknameFrom[NICKNAME_LEN_MAX+1];	// 말한 플레이어 닉네임
	WCHAR	szNicknameTo[NICKNAME_LEN_MAX+1];	// 들을 플레이어 닉네임
	WCHAR	szChatString[MAX_CHAT_LEN+1];
};

PROTOCOL_DECLARE(H2E_REQ_JUMPTO, _H2E_REQ_JUMPTO)
{
public:
	UINT32	nRequestPlayerUID;
	UINT32	nTargetPlayerUID;
	WCHAR	szTargetCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(E2H_RES_JUMPTO, _E2H_RES_JUMPTO)
{
public:
	UINT8	bResult;
	UINT32	nRequestPlayerUID;
	UINT32	nTargetPlayerUID;
	UINT8	nChannelServerID;
	UINT8	bChannelServerFull;	// bResult 가 0일경우에만 해당.
	UINT8	bChannelFull;	// bResult 가 0일경우에만 해당.
};

PROTOCOL_DECLARE(D2H_DBPROXY_RESULT, _D2H_DBPROXY_RESULT)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	UINT16	nProtocolCode;
	UINT16	nResultCode;
};

PROTOCOL_DECLARE(H2D_DB_PLAYER_ADD, _H2D_DB_PLAYER_ADD)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	TCHAR   callSign[NICKNAME_LEN_MAX+1];
	TCHAR   accountID[ACCOUNT_LEN_MAX+1];

	UINT64  newCharacKey1;

	UINT64  newItemKey1;
	UINT64  newItemKey2;
	UINT64  newItemKey3;
	UINT64  newItemKey4;
	UINT64  newItemKey5;

	UINT64  expireTime;  // 유효기간 
};


PROTOCOL_DECLARE(D2H_DB_PLAYER_ADD, _D2H_DB_PLAYER_ADD)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	TCHAR   callSign[NICKNAME_LEN_MAX+1];
};


PROTOCOL_DECLARE(H2D_DB_PLAYER_UPDATE, _H2D_DB_PLAYER_UPDATE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;

	UINT64	loginTime;
	UINT64	logoutTime;
	UINT32	totalPlayTime;

	_DB_UPDATE_PLAYER_INFO	playerInfo;
};


PROTOCOL_DECLARE(H2D_DB_PLAYER_SELECT, _H2D_DB_PLAYER_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
};

PROTOCOL_DECLARE(D2H_DB_PLAYER_SELECT, _D2H_DB_PLAYER_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	_DB_PLAYER_INFO	playerInfo;
};


PROTOCOL_DECLARE(H2D_DB_BATTLE_RECORD_UPDATE, _H2D_DB_BATTLE_RECORD_UPDATE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	aceKillCount;
	UINT32	headShotKillCount;
	UINT32	totalKillCount;
	UINT32	totalDeathCount;
	UINT32	suicideCount;

	UINT32	desertionKillCount;

	UINT16	killCount1;
	UINT16	killCount2;
	UINT16	killCount3;
	UINT16	killCount4;
	UINT16	killCount5;
	UINT16	killCount6;
	UINT16	killCount7;
	UINT16	killCount8;
	UINT16	killCount9;
	UINT16	killCount10;

	UINT16	winCount1;
	UINT16	winCount2;
	UINT16	winCount3;
	UINT16	winCount4;
	UINT16	winCount5;
	UINT16	winCount6;
	UINT16	winCount7;
	UINT16	winCount8;
	UINT16	winCount9;
	UINT16	winCount10;

	UINT16	drawCount1;
	UINT16	drawCount2;
	UINT16	drawCount3;
	UINT16	drawCount4;
	UINT16	drawCount5;
	UINT16	drawCount6;
	UINT16	drawCount7;
	UINT16	drawCount8;
	UINT16	drawCount9;
	UINT16	drawCount10;

	UINT16	loseCount1;
	UINT16	loseCount2;
	UINT16	loseCount3;
	UINT16	loseCount4;
	UINT16	loseCount5;
	UINT16	loseCount6;
	UINT16	loseCount7;
	UINT16	loseCount8;
	UINT16	loseCount9;
	UINT16	loseCount10;
};


PROTOCOL_DECLARE(H2D_DB_BATTLE_RECORD_SELECT, _H2D_DB_BATTLE_RECORD_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;	
};


PROTOCOL_DECLARE(D2H_DB_BATTLE_RECORD_SELECT, _D2H_DB_BATTLE_RECORD_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	aceKillCount;
	UINT32	headShotKillCount;
	UINT32	totalKillCount;
	UINT32	totalDeathCount;
	UINT32	suicideCount;

	UINT32	desertionCount;

	UINT16	killCount1;
	UINT16	killCount2;
	UINT16	killCount3;
	UINT16	killCount4;
	UINT16	killCount5;
	UINT16	killCount6;
	UINT16	killCount7;
	UINT16	killCount8;
	UINT16	killCount9;
	UINT16	killCount10;

	UINT16	winCount1;
	UINT16	winCount2;
	UINT16	winCount3;
	UINT16	winCount4;
	UINT16	winCount5;
	UINT16	winCount6;
	UINT16	winCount7;
	UINT16	winCount8;
	UINT16	winCount9;
	UINT16	winCount10;

	UINT16	drawCount1;
	UINT16	drawCount2;
	UINT16	drawCount3;
	UINT16	drawCount4;
	UINT16	drawCount5;
	UINT16	drawCount6;
	UINT16	drawCount7;
	UINT16	drawCount8;
	UINT16	drawCount9;
	UINT16	drawCount10;

	UINT16	loseCount1;
	UINT16	loseCount2;
	UINT16	loseCount3;
	UINT16	loseCount4;
	UINT16	loseCount5;
	UINT16	loseCount6;
	UINT16	loseCount7;
	UINT16	loseCount8;
	UINT16	loseCount9;
	UINT16	loseCount10;
};

PROTOCOL_DECLARE(H2D_DB_INVENTORY_UPDATE, _H2D_DB_INVENTORY_UPDATE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	inventoryID;
	UINT32	primarySlot;
	UINT32	openSlotCount;
};


PROTOCOL_DECLARE(H2D_DB_INVENTORY_SELECT, _H2D_DB_INVENTORY_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
};


PROTOCOL_DECLARE(D2H_DB_INVENTORY_SELECT, _D2H_DB_INVENTORY_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	inventoryID;
	UINT32	primarySlot;
	UINT32	openSlotCount;
};





// 아이템 데이타 DB 처리 패킷
PROTOCOL_DECLARE(H2D_DB_ITEM_ADD, _H2D_DB_ITEM_ADD)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	inventoryID;
	UINT8	primarySlot;
	UINT8	openSlotCount;
	_DB_ITEM_INFO  itemInfo;
};

PROTOCOL_DECLARE(H2D_DB_ITEM_DELETE, _H2D_DB_ITEM_DELETE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	inventoryID;
	UINT8	primarySlot;
	UINT8	openSlotCount;
	UINT64	itemID;
};

PROTOCOL_DECLARE(H2D_DB_ITEM_UPDATE, _H2D_DB_ITEM_UPDATE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	inventoryID;
	UINT8	primarySlot;
	UINT8	openSlotCount;
	_DB_ITEM_INFO  itemInfo;
};

PROTOCOL_DECLARE(H2D_DB_ITEM_SELECT, _H2D_DB_ITEM_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
};

PROTOCOL_DECLARE(D2H_DB_ITEM_SELECT, _D2H_DB_ITEM_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;	

	UINT8	cnt;
	_DB_ITEM_INFO	itemInfo[ ITEM_INVEN_SLOT_MAX ];
};


// 캐릭터 데이타 DB 처리 패킷
PROTOCOL_DECLARE(H2D_DB_CHARAC_ADD, _H2D_DB_CHARAC_ADD)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT8	primarySlot;
	UINT8	openSlotCount;
	_DB_CHARAC_INFO  characInfo;
};

PROTOCOL_DECLARE(H2D_DB_CHARAC_DELETE, _H2D_DB_CHARAC_DELETE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT8	primarySlot;
	UINT8	openSlotCount;
	UINT32	characCode;
};

PROTOCOL_DECLARE(H2D_DB_CHARAC_UPDATE, _H2D_DB_CHARAC_UPDATE)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	
	UINT8	primarySlot;
	UINT8	openSlotCount;
	_DB_CHARAC_INFO  characInfo;
};

PROTOCOL_DECLARE(H2D_DB_CHARAC_SELECT, _H2D_DB_CHARAC_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
};

PROTOCOL_DECLARE(D2H_DB_CHARAC_SELECT, _D2H_DB_CHARAC_SELECT)
{
public:
	UINT32	sessionID;
	UINT32	playerID;
	UINT32	inventoryID;
	UINT8	primarySlot;
	UINT8	openSlotCount;
	UINT8	cnt;
	_DB_CHARAC_INFO	characInfo[ CHARAC_INVEN_SLOT_MAX ];
};

PROTOCOL_DECLARE(H2D_REQ_REGISTER_NICKNAME, _H2D_REQ_REGISTER_NICKNAME)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 닉네임 요청
	WCHAR	szAccountID[ACCOUNT_LEN_MAX+1];
};

PROTOCOL_DECLARE(D2H_RES_REGISTER_NICKNAME, _D2H_RES_REGISTER_NICKNAME)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// 닉네임 요청
	UINT8	nResult;	// 0 이면 성공, 그 외 에러 코드
};

PROTOCOL_DECLARE(S2S_GM_REQ_GMSERVER_LOGIN, _S2S_GM_REQ_GMSERVER_LOGIN)
{
public:
	INT32	nLoginKey;
};


PROTOCOL_DECLARE(S2S_GM_RES_GMSERVER_LOGIN, _S2S_GM_RES_GMSERVER_LOGIN)
{
public:
	INT32	nGMProxyErrorCode;
};


PROTOCOL_DECLARE(S2S_GM_ERROR_CODE, _S2S_GM_ERROR_CODE)
{
public:
	UINT32	nRequestID;
	INT32	nGMProxyErrorCode;
};


PROTOCOL_DECLARE(S2S_GM_REQ_GMPROXY_STATUS, _S2S_GM_REQ_GMPROXY_STATUS)
{
public:
	UINT32	nRequestID;
};


PROTOCOL_DECLARE(S2S_GM_RES_GMPROXY_STATUS, _S2S_GM_RES_GMPROXY_STATUS)
{
public:
	UINT32	nRequestID;
	WCHAR	szStatus[256 + 1];
	UINT8	bCenterServerConnected;
	UINT8	bDatabaseEnabled;
};


PROTOCOL_DECLARE(S2S_GM_REQ_CHANNEL_POPULATION, _S2S_GM_REQ_CHANNEL_POPULATION)
{
public:
	UINT32	nRequestID;
};


PROTOCOL_DECLARE(S2S_GM_INFO_CHANNEL_POPULATION, _S2S_GM_INFO_CHANNEL_POPULATION)
{
public:
	UINT32	nRequestID;
	UINT8	nItemCount;
	_CHANNEL_POPULATION_INFO	PopulationInfo[MAX_POPULATION_INFO];
};


PROTOCOL_DECLARE(S2S_GM_REQ_NOTICE_NOW, _S2S_GM_REQ_NOTICE_NOW)
{
public:
	UINT32	nRequestID;
	INT8	nServerID;
	WCHAR	szNotice[MAX_CHAT_LEN + 1];
};


PROTOCOL_DECLARE(S2S_GM_REQ_ACCOUNT_INFO, _S2S_GM_REQ_ACCOUNT_INFO)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
};


PROTOCOL_DECLARE(S2S_GM_RES_ACCOUNT_INFO, _S2S_GM_RES_ACCOUNT_INFO)
{
public:
	UINT32	nRequestID;
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT8	bIsOnline;
	INT8	nChannelServerID;
	INT64	LoginTimestamp;
	INT64	LogoutTimestamp;
	WCHAR	szRemoteIP[IP_STRING_LEN_MAX + 1];
};


PROTOCOL_DECLARE(S2S_GM_REQ_PLAYER_INFO, _S2S_GM_REQ_PLAYER_INFO)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
};


PROTOCOL_DECLARE(S2S_GM_RES_PLAYER_INFO, _S2S_GM_RES_PLAYER_INFO)
{
public:
	UINT32	nRequestID;
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	_HG_DATE	PlayerCreated;
	UINT32	nClanID;
	UINT32	nMoney;
	UINT32	nCash;
	UINT32	nExp;
	UINT32	nTotalKillCount;
	UINT32	nTotalDeathCount;
	UINT32	nAceKillCount;
	UINT32	nHeadShotKillCount;
	UINT16	nDesertionCount;
	UINT16	aMissionWin[MISSION_MAX];
	UINT16	aMissionDraw[MISSION_MAX];
	UINT16	aMissionLose[MISSION_MAX];
	UINT32	aWeaponTypeKillCount[KILL_TYPE_MAX];
};


PROTOCOL_DECLARE(S2S_GM_REQ_INVENTORY_INFO, _S2S_GM_REQ_INVENTORY_INFO)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
};


PROTOCOL_DECLARE(S2S_GM_RES_INVENTORY_INFO, _S2S_GM_RES_INVENTORY_INFO)
{
public:
	UINT32	nRequestID;
	_DB_CHARAC_INFO	Charac[CHARAC_INVEN_SLOT_MAX];
	UINT8	nItemCnt;
	_DB_ITEM_INFO	Items[ITEM_INVEN_SLOT_MAX];
};


PROTOCOL_DECLARE(S2S_GM_REQ_LOCK_PLAYER, _S2S_GM_REQ_LOCK_PLAYER)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT8	bUnlock;	// 1이면 입장 제한 해제.
};


PROTOCOL_DECLARE(S2S_GM_RES_LOCK_PLAYER, _S2S_GM_RES_LOCK_PLAYER)
{
public:
	UINT32	nRequestID;
	UINT8	bResult;	// 1: 요청대로 수행 완료, 0: 실패.
	UINT8	bUnlock;	// 1이면 입장 제한 해제.
};


PROTOCOL_DECLARE(S2S_GM_REQ_PLAYER_KICK, _S2S_GM_REQ_PLAYER_KICK)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
};


PROTOCOL_DECLARE(S2S_GM_REQ_EDIT_PLAYER_EXP, _S2S_GM_REQ_EDIT_PLAYER_EXP)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT32	nNewExp;
};


PROTOCOL_DECLARE(S2S_GM_REQ_EDIT_PLAYER_MONEY, _S2S_GM_REQ_EDIT_PLAYER_MONEY)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT32	nNewMoney;
};


PROTOCOL_DECLARE(S2S_GM_REQ_EDIT_PLAYER_BATTLE, _S2S_GM_REQ_EDIT_PLAYER_BATTLE)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT32	nTotalKillCount;
	UINT32	nTotalDeathCount;
	UINT32	nAceKillCount;
	UINT32	nHeadShotKillCount;
	UINT16	nDesertionCount;
};


PROTOCOL_DECLARE(S2S_GM_REQ_EDIT_PLAYER_WEAPON, _S2S_GM_REQ_EDIT_PLAYER_WEAPON)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT32	aWeaponTypeKillCount[KILL_TYPE_MAX];
};


PROTOCOL_DECLARE(S2S_GM_REQ_EDIT_PLAYER_MISSION, _S2S_GM_REQ_EDIT_PLAYER_MISSION)
{
public:
	UINT32	nRequestID;
	UINT32	nPlayerUID;
	WCHAR	szAccount[ACCOUNT_LEN_MAX + 1];
	WCHAR	szCallsign[NICKNAME_LEN_MAX + 1];
	UINT16	aMissionWin[MISSION_MAX];
	UINT16	aMissionDraw[MISSION_MAX];
	UINT16	aMissionLose[MISSION_MAX];
};

PROTOCOL_DECLARE(H2E_CLAN_ADD, _H2E_CLAN_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(E2H_CLAN_ADD, _E2H_CLAN_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
	WCHAR	master[NICKNAME_LEN_MAX+1];
	UINT32	masterPlayerID;		
	UINT16	maxCrew;
};

PROTOCOL_DECLARE(E2D_CLAN_ADD, _E2D_CLAN_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(D2E_CLAN_ADD, _D2E_CLAN_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공
	
	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
	WCHAR	master[NICKNAME_LEN_MAX+1];
	UINT32	masterPlayerID;		
	UINT16	playerLevel;
};

// 클랜 삭제
PROTOCOL_DECLARE(H2E_CLAN_DELETE, _H2E_CLAN_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공
	
	UINT32	clanID;
};

PROTOCOL_DECLARE(E2H_CLAN_DELETE, _E2H_CLAN_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공
	
	UINT32	clanID;
};

PROTOCOL_DECLARE(E2D_CLAN_DELETE, _E2D_CLAN_DELETE)
{
public:
	UINT32	clanID;
};

PROTOCOL_DECLARE(D2E_CLAN_DELETE, _D2E_CLAN_DELETE)
{
public:
	// 사용안함 
};

// 클랜 수정
PROTOCOL_DECLARE(H2E_CLAN_UPDATE, _H2E_CLAN_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	_CLAN_INFO  clanInfo;
};

PROTOCOL_DECLARE(E2H_CLAN_UPDATE, _E2H_CLAN_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공
	
	_CLAN_INFO  clanInfo;	
};

PROTOCOL_DECLARE(E2D_CLAN_UPDATE, _E2D_CLAN_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	_CLAN_INFO  clanInfo;	
};

PROTOCOL_DECLARE(D2E_CLAN_UPDATE, _D2E_CLAN_UPDATE)
{
public:
	// 사용안함
};

// 클랜 리스트 
PROTOCOL_DECLARE(H2E_CLAN_LIST, _H2E_CLAN_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT16	pageNO;
};

PROTOCOL_DECLARE(E2H_CLAN_LIST, _E2H_CLAN_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT16	pageNO;
	UINT16	totalSize;
	UINT16	size;

	_CLAN_INFO  clanInfo[CLAN_LIST_LOAD_MAX];
};

PROTOCOL_DECLARE(E2D_CLAN_LIST_LOAD, _E2D_CLAN_LIST_LOAD)
{
public:
	// 필드 없슴
};

PROTOCOL_DECLARE(D2E_CLAN_LIST_LOAD, _D2E_CLAN_LIST_LOAD)
{
public:
	UINT16	pageNO;
	UINT16	size;

	_CLAN_INFO  clanInfo[CLAN_LIST_LOAD_MAX];
};


// 클랜 정보 
PROTOCOL_DECLARE(H2E_CLAN_INFO, _H2E_CLAN_INFO)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;   
	UINT8	channelID;
	UINT16	level;
	UINT8	onOff;	   // 접속여부 0.비접속 1.접속  2.정보요구 
};

PROTOCOL_DECLARE(E2H_CLAN_INFO, _E2H_CLAN_INFO)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	_CLAN_INFO  clanInfo;
};

// 클랜 이름 중복체크  
PROTOCOL_DECLARE(H2E_CLAN_DUP_NAME, _H2E_CLAN_DUP_NAME)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(E2H_CLAN_DUP_NAME, _E2H_CLAN_DUP_NAME)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT8	result;    // 0.실패 1.성공
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(E2D_CLAN_DUP_NAME, _E2D_CLAN_DUP_NAME)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(D2E_CLAN_DUP_NAME, _D2E_CLAN_DUP_NAME)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT8	result;    // 0.실패 1.성공
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];	
};


// 클랜원 등록
PROTOCOL_DECLARE(H2E_CLAN_MEMBER_ADD, _H2E_CLAN_MEMBER_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(E2H_CLAN_MEMBER_ADD, _E2H_CLAN_MEMBER_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
	UINT8	level;
};

PROTOCOL_DECLARE(E2D_CLAN_MEMBER_ADD, _E2D_CLAN_MEMBER_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(D2E_CLAN_MEMBER_ADD, _D2E_CLAN_MEMBER_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
	UINT8   level;
};

// 클랜원 삭제
PROTOCOL_DECLARE(H2E_CLAN_MEMBER_DELETE, _H2E_CLAN_MEMBER_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;	

	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(E2H_CLAN_MEMBER_DELETE, _E2H_CLAN_MEMBER_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;
	UINT32	requestPlayerID;
	WCHAR	requestCallsign[NICKNAME_LEN_MAX+1];
};

PROTOCOL_DECLARE(E2D_CLAN_MEMBER_DELETE, _E2D_CLAN_MEMBER_DELETE)
{
public:
	UINT32	clanID;
	UINT32	requestPlayerID;	
};

PROTOCOL_DECLARE(D2E_CLAN_MEMBER_DELETE, _D2E_CLAN_MEMBER_DELETE)
{
public:
	// 사용안함
};

// 클랜원 수정
PROTOCOL_DECLARE(H2E_CLAN_MEMBER_UPDATE, _H2E_CLAN_MEMBER_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	_CLAN_MEMBER_INFO  clanMemberInfo;
};

PROTOCOL_DECLARE(E2H_CLAN_MEMBER_UPDATE, _E2H_CLAN_MEMBER_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;
	_CLAN_MEMBER_INFO  clanMemberInfo;	
};

PROTOCOL_DECLARE(E2D_CLAN_MEMBER_UPDATE, _E2D_CLAN_MEMBER_UPDATE)
{
public:
	UINT32	clanID;
	_CLAN_MEMBER_INFO  clanMemberInfo;
};

PROTOCOL_DECLARE(D2E_CLAN_MEMBER_UPDATE, _D2E_CLAN_MEMBER_UPDATE)
{
public:
	// 사용안함
};

// 클랜원 리스트 
PROTOCOL_DECLARE(H2E_CLAN_MEMBER_LIST, _H2E_CLAN_MEMBER_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT16	pageNO;
	UINT8	onOff;    // 0.off(전부) 1.on(온라인만)
};

PROTOCOL_DECLARE(E2H_CLAN_MEMBER_LIST, _E2H_CLAN_MEMBER_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT16	pageNO;
	UINT8	onOff;    // 0.off(전부) 1.on(온라인만)
	UINT16	totalSize;
	UINT16	size;

	_CLAN_MEMBER_INFO  clanMemberInfo[CLAN_MEMBER_LIST_LOAD_MAX];
};

PROTOCOL_DECLARE(E2D_CLAN_MEMBER_LIST_LOAD, _E2D_CLAN_MEMBER_LIST_LOAD)
{
public:
	UINT32	clanID;
};

PROTOCOL_DECLARE(D2E_CLAN_MEMBER_LIST_LOAD, _D2E_CLAN_MEMBER_LIST_LOAD)
{
public:
	UINT32	clanID;
	UINT16	pageNO;
	UINT16	size;

	_CLAN_MEMBER_INFO  clanMemberInfo[CLAN_MEMBER_LIST_LOAD_MAX];	
};


// 클랜원 정보 
PROTOCOL_DECLARE(H2E_CLAN_MEMBER_INFO, _H2E_CLAN_MEMBER_INFO)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
};

PROTOCOL_DECLARE(E2H_CLAN_MEMBER_INFO, _E2H_CLAN_MEMBER_INFO)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;	

	_CLAN_MEMBER_INFO  clanMemberInfo;
};


// 클랜 게시판 등록
PROTOCOL_DECLARE(H2E_CLAN_BOARD_ADD, _H2E_CLAN_BOARD_ADD)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	WCHAR	title[CLAN_BOARD_TITLE_LEN_MAX+1];
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];	
};

PROTOCOL_DECLARE(E2H_CLAN_BOARD_ADD, _E2H_CLAN_BOARD_ADD)
{
public:	
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;	
	UINT32	clanBoardID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	WCHAR	title[CLAN_BOARD_TITLE_LEN_MAX+1];
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
	UINT64	createDate;
};

PROTOCOL_DECLARE(E2D_CLAN_BOARD_ADD, _E2D_CLAN_BOARD_ADD)
{
public:
	UINT32	clanID;
	UINT32	playerID;

	UINT32	clanBoardID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	WCHAR	title[CLAN_BOARD_TITLE_LEN_MAX+1];
	WCHAR	mainContent[CLAN_BOARD_CONTENT_LEN_MAX+1];
	UINT8	isFull;            // full인지 체크 
	UINT32	deleteBoardID;     // full일때 삭제될 게시판ID 
	UINT64	createDate;
};

PROTOCOL_DECLARE(D2E_CLAN_BOARD_ADD, _D2E_CLAN_BOARD_ADD)
{
public:
	// 사용안함
};

// 클랜 게시판 삭제 
PROTOCOL_DECLARE(H2E_CLAN_BOARD_DELETE, _H2E_CLAN_BOARD_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT32	clanBoardID;
};

PROTOCOL_DECLARE(E2H_CLAN_BOARD_DELETE, _E2H_CLAN_BOARD_DELETE)
{
public:	
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanBoardID;
};

PROTOCOL_DECLARE(E2D_CLAN_BOARD_DELETE, _E2D_CLAN_BOARD_DELETE)
{
public:
	UINT32	clanID;
	UINT32	clanBoardID;
};

PROTOCOL_DECLARE(D2E_CLAN_BOARD_DELETE, _D2E_CLAN_BOARD_DELETE)
{
public:
	// 사용안함
};

// 클랜 게시판 수정 
PROTOCOL_DECLARE(H2E_CLAN_BOARD_UPDATE, _H2E_CLAN_BOARD_UPDATE)
{
public:	
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;

	_CLAN_BOARD_INFO  clanBoardInfo;
};

PROTOCOL_DECLARE(E2H_CLAN_BOARD_UPDATE, _E2H_CLAN_BOARD_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공

	UINT32	clanID;

	_CLAN_BOARD_INFO  clanBoardInfo;	
};

PROTOCOL_DECLARE(E2D_CLAN_BOARD_UPDATE, _E2D_CLAN_BOARD_UPDATE)
{
public:
	UINT32	clanID;

	_CLAN_BOARD_INFO  clanBoardInfo;
};

PROTOCOL_DECLARE(D2E_CLAN_BOARD_UPDATE, _D2E_CLAN_BOARD_UPDATE)
{
public:
	// 사용안함
};

// 클랜 게시판 리스트 
PROTOCOL_DECLARE(H2E_CLAN_BOARD_LIST, _H2E_CLAN_BOARD_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT16	pageNO;
};

PROTOCOL_DECLARE(E2H_CLAN_BOARD_LIST, _E2H_CLAN_BOARD_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16	size;

	_CLAN_BOARD_INFO  clanBoardInfo[CLAN_BOARD_LIST_LOAD_MAX]; 
};

PROTOCOL_DECLARE(E2D_CLAN_BOARD_LIST_LOAD, _E2D_CLAN_BOARD_LIST_LOAD)
{
public:
	UINT32	clanID;
};

PROTOCOL_DECLARE(D2E_CLAN_BOARD_LIST_LOAD, _D2E_CLAN_BOARD_LIST_LOAD)
{
public:
	UINT32	clanID;
	UINT16	pageNO;
	UINT16	size;

	_CLAN_BOARD_INFO  clanBoardInfo[CLAN_BOARD_LIST_LOAD_MAX];
};

// 클랜 채팅 
PROTOCOL_DECLARE(H2E_CLAN_CHAT, _H2E_CLAN_CHAT)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT8	chatType;	// 채팅 타입
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	// 말한 플레이어
	WCHAR	chatString[MAX_CHAT_LEN+1];
};

PROTOCOL_DECLARE(E2H_CLAN_CHAT, _E2H_CLAN_CHAT)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT32	clanID;
	UINT8	chatType;	// 채팅 타입
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	// 말한 플레이어
	WCHAR	chatString[MAX_CHAT_LEN+1];	
};


// 쪽지 시스템 
//--------------------------------------------------------------------------------------
PROTOCOL_DECLARE(H2E_NOTE_SEND, _H2E_NOTE_SEND)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	

	UINT8	isGroup;        // 0.기본쪽지 1.단체쪽지 	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2.클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];
};

// 보낸 쪽지함 확인(보낸사람)
PROTOCOL_DECLARE(E2H_NOTE_SEND_SENDER, _E2H_NOTE_SEND_SENDER)
{
public:
	UINT8	sendResult;   // 1 성공, 2 실패(캐릭없슴), 3 실패(편지함 full)
	UINT32	playerID;
	UINT8	serverID;

	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
	
	UINT32	noteID;		
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2.클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];		
	UINT64	createDate;
};

// 받은 쪽지함 확인(받은사람)
PROTOCOL_DECLARE(E2H_NOTE_SEND_RECEIVER, _E2H_NOTE_SEND_RECEIVER)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	UINT32	sendPlayerID;
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];	

	UINT32	noteID;	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2.클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO 
	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];
	
	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];	
	UINT64	createDate;
};

// 보낸사람 
PROTOCOL_DECLARE(E2D_NOTE_SEND_SENDER, _E2D_NOTE_SEND_SENDER)
{
public:
	UINT32	playerID;  // 보낸사람
	UINT8	serverID;	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];	
	UINT64	createDate;
};

// 받은사람
PROTOCOL_DECLARE(E2D_NOTE_SEND_RECEIVER, _E2D_NOTE_SEND_RECEIVER)
{
public:
	UINT32	playerID;  // 보낸사람
	UINT8	serverID;	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2.클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];	
	UINT64	createDate;
};

// 보낸사람 
PROTOCOL_DECLARE(D2E_NOTE_SEND_SENDER, _D2E_NOTE_SEND_SENDER)
{
public:
	UINT8	sendResult;    // 1.성공, 2.실패(캐릭없슴) 3.실패(편지함 full)	
	UINT32	playerID;      // 보낸사람 
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
		
	UINT32	sendNoteID;
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2.클랜가입권유(클랜마스터)
	UINT32	clanID;

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];	
	UINT32	deleteNoteID;     // full일때 삭제될 쪽지ID 
	UINT64	createDate;
};

// 받은사람 
PROTOCOL_DECLARE(D2E_NOTE_SEND_RECEIVER, _D2E_NOTE_SEND_RECEIVER)
{
public:
	UINT8	sendResult;    // 1.성공, 2.실패(캐릭없슴) 3.실패(편지함 full)	
	UINT32	playerID;      // 보낸사람
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
	
	UINT32	recvNoteID;
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2.클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO 	
	UINT32	clanID;
	WCHAR	clanName[CLAN_NAME_LEN_MAX+1];

	WCHAR	title[NOTE_TITLE_LEN_MAX+1];
	WCHAR	mainContent[NOTE_CONTENT_LEN_MAX+1];
	UINT32	deleteNoteID;     // full일때 삭제될 쪽지ID 
	UINT64	createDate;
};

// 쪽지 응답 
PROTOCOL_DECLARE(H2E_NOTE_REPLY, _H2E_NOTE_REPLY)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];

	UINT32	noteID;	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO 3.쪽지읽음 
	UINT32	clanID;
};

PROTOCOL_DECLARE(E2H_NOTE_REPLY, _E2H_NOTE_REPLY)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT8	result;			// 0.실패 1.성공

	UINT32	noteID;		
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO 3.쪽지읽음 
	UINT32	clanID;
	UINT64	createDate;
};

PROTOCOL_DECLARE(E2D_NOTE_REPLY, _E2D_NOTE_REPLY)
{
public:
	UINT32	playerID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];

	UINT32	noteID;			
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO 3.쪽지읽음 
	UINT32	clanID;	
	UINT64	createDate;
};

PROTOCOL_DECLARE(D2E_NOTE_REPLY, _D2E_NOTE_REPLY)
{
public:
	UINT32	playerID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	recvPlayerID;
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];

	UINT32	noteID;		
	UINT32	recvNoteID;	    // 보내는 쪽지의 ID
	
	UINT8	replyOption;    // 0.일반쪽지 1.클랜가입신청(신청인) 2. 클랜가입권유(클랜마스터)
	UINT8	replyResult;    // 0.응답대기 1.응답OK 2.응답NO 3.쪽지읽음 
	UINT32	clanID;
	UINT64	createDate;
};


// 받은 쪽지 삭제 
PROTOCOL_DECLARE(H2E_RECV_NOTE_DELETE, _H2E_RECV_NOTE_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	UINT32	noteID;
};

PROTOCOL_DECLARE(E2H_RECV_NOTE_DELETE, _E2H_RECV_NOTE_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공
	
	UINT32	noteID;	
};

PROTOCOL_DECLARE(E2D_RECV_NOTE_DELETE, _E2D_RECV_NOTE_DELETE)
{
public:
	UINT32	playerID;
	UINT32	noteID;	
};

PROTOCOL_DECLARE(D2E_RECV_NOTE_DELETE, _D2E_RECV_NOTE_DELETE)
{
public:
	// 사용안함
};


// 보낸 쪽지 삭제 
PROTOCOL_DECLARE(H2E_SEND_NOTE_DELETE, _H2E_SEND_NOTE_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	UINT32	noteID;
};

PROTOCOL_DECLARE(E2H_SEND_NOTE_DELETE, _E2H_SEND_NOTE_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	UINT8	result;    // 0.실패 1.성공
	
	UINT32	noteID;	
};

PROTOCOL_DECLARE(E2D_SEND_NOTE_DELETE, _E2D_SEND_NOTE_DELETE)
{
public:
	UINT32	playerID;
	UINT32	noteID;	
};

PROTOCOL_DECLARE(D2E_SEND_NOTE_DELETE, _D2E_SEND_NOTE_DELETE)
{
public:
	// 사용안함
};

// 받은 쪽지 리스트 
PROTOCOL_DECLARE(H2E_RECV_NOTE_LIST, _H2E_RECV_NOTE_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	UINT16	pageNO;
};

PROTOCOL_DECLARE(E2H_RECV_NOTE_LIST, _E2H_RECV_NOTE_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16	size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};

PROTOCOL_DECLARE(E2D_RECV_NOTE_LIST_LOAD, _E2D_RECV_NOTE_LIST_LOAD)
{
public:	
	UINT32	playerID;
};

PROTOCOL_DECLARE(D2E_RECV_NOTE_LIST_LOAD, _D2E_RECV_NOTE_LIST_LOAD)
{
public:
	UINT32	clanID;
	UINT32	playerID;

	UINT16	pageNO;
	UINT16	size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};


// 보낸 쪽지 리스트 
PROTOCOL_DECLARE(H2E_SEND_NOTE_LIST, _H2E_SEND_NOTE_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	UINT16	pageNO;
};

PROTOCOL_DECLARE(E2H_SEND_NOTE_LIST, _E2H_SEND_NOTE_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	
	UINT16	pageNO;
	UINT16	totalSize;
	UINT16	size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};

PROTOCOL_DECLARE(E2D_SEND_NOTE_LIST_LOAD, _E2D_SEND_NOTE_LIST_LOAD)
{
public:	
	UINT32	playerID;
};

PROTOCOL_DECLARE(D2E_SEND_NOTE_LIST_LOAD, _D2E_SEND_NOTE_LIST_LOAD)
{
public:	
	UINT32	playerID;
	UINT16	pageNO;
	UINT16	size;

	_NOTE_INFO  noteInfo[NOTE_LIST_LOAD_MAX];
};


// 친구 시스템 
//--------------------------------------------------------------------------------------

// 친구 초청
PROTOCOL_DECLARE(H2E_FRIEND_INVITE, _H2E_FRIEND_INVITE)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT32	recvPlayerID;	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
};

PROTOCOL_DECLARE(E2H_FRIEND_INVITE_SENDER, _E2H_FRIEND_INVITE_SENDER)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];

	UINT8	result;    // 0.실패 1.성공
	UINT32	recvPlayerID;	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];		
};

PROTOCOL_DECLARE(E2H_FRIEND_INVITE_RECEIVER, _E2H_FRIEND_INVITE_RECEIVER)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	
	UINT32	sendPlayerID;	
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];			
};

// 친구 초청에대한 응답
PROTOCOL_DECLARE(H2E_FRIEND_REPLY, _H2E_FRIEND_REPLY)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];
	UINT16	level;		

	UINT8	replyResult;    // 1.응답OK 2.응답NO 
	UINT32	recvPlayerID;	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];			
	UINT16	recvLevel;  
};

PROTOCOL_DECLARE(E2H_FRIEND_REPLY_SENDER, _E2H_FRIEND_REPLY_SENDER)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	

	UINT8	result;    // 0.실패 1.성공
	UINT8	replyResult;    // 1.응답OK 2.응답NO 
	UINT32	recvPlayerID;	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];			
};

PROTOCOL_DECLARE(E2H_FRIEND_REPLY_RECEIVER, _E2H_FRIEND_REPLY_RECEIVER)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	
	
	UINT8	replyResult;    // 1.응답OK 2.응답NO 
	UINT32	sendPlayerID;	
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];			
};

PROTOCOL_DECLARE(E2D_FRIEND_REPLY, _E2D_FRIEND_REPLY)
{
public:
	UINT32	playerID;
	UINT8	serverID;
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	
	
	UINT8	replyResult;    // 1.응답OK 2.응답NO 
	UINT32	recvPlayerID;	
	WCHAR	recvCallsign[NICKNAME_LEN_MAX+1];	
	UINT64	createDate;
};

// 친구 삭제
PROTOCOL_DECLARE(H2E_FRIEND_DELETE, _H2E_FRIEND_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];		

	UINT32	fPlayerID;	
	WCHAR	fCallsign[NICKNAME_LEN_MAX+1];		
};

PROTOCOL_DECLARE(E2H_FRIEND_DELETE_SENDER, _E2H_FRIEND_DELETE_SENDER)
{
public:
	UINT32	playerID;
	UINT8	serverID;	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];		

	UINT8	result;    // 0.실패 1.성공
	UINT32	fPlayerID;	
	WCHAR	fCallsign[NICKNAME_LEN_MAX+1];			
};

PROTOCOL_DECLARE(E2H_FRIEND_DELETE_RECEIVER, _E2H_FRIEND_DELETE_RECEIVER)
{
public:
	UINT32	playerID;
	UINT8	serverID;	
	WCHAR	callsign[NICKNAME_LEN_MAX+1];		
	
	UINT32	sendPlayerID;	
	WCHAR	sendCallsign[NICKNAME_LEN_MAX+1];		
};

PROTOCOL_DECLARE(E2D_FRIEND_DELETE, _E2D_FRIEND_DELETE)
{
public:
	UINT32	playerID;
	UINT8	serverID;	
	
	UINT32	fPlayerID;		
};

// 친구 수정
PROTOCOL_DECLARE(H2E_FRIEND_UPDATE, _H2E_FRIEND_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;		
	
	UINT32	fPlayerID;		
	UINT8   status;   // 0.비접속 1.접속		
	UINT8   level;
};

PROTOCOL_DECLARE(E2H_FRIEND_UPDATE, _E2H_FRIEND_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;		
	
	UINT8	result;    // 0.실패 1.성공
	UINT32	fPlayerID;		
	UINT8   status;   // 0.비접속 1.접속		
	UINT8   level;   
};

PROTOCOL_DECLARE(E2D_FRIEND_UPDATE, _E2D_FRIEND_UPDATE)
{
public:
	UINT32	playerID;
	UINT8	serverID;			
	
	UINT32	fPlayerID;		
	UINT8   status;   // 0.비접속 1.접속		
	UINT16  level;
};

// 친구 리스트
PROTOCOL_DECLARE(H2E_FRIEND_LIST, _H2E_FRIEND_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;			
	UINT8	pageNO;
};

PROTOCOL_DECLARE(E2H_FRIEND_LIST, _E2H_FRIEND_LIST)
{
public:
	UINT32	playerID;
	UINT8	serverID;			

	UINT8	pageNO;	
	UINT16	totalSize;
	UINT8	size;
	_FRIEND_INFO  friendInfo[FRIEND_LIST_LOAD_MAX];
};

PROTOCOL_DECLARE(E2D_FRIEND_LIST_LOAD, _E2D_FRIEND_LIST_LOAD)
{
public:
	UINT32	playerID;	
};

PROTOCOL_DECLARE(D2E_FRIEND_LIST_LOAD, _D2E_FRIEND_LIST_LOAD)
{
public:
	UINT32	playerID;	

	UINT8	size;
	_FRIEND_INFO  friendInfo[FRIEND_LIST_LOAD_MAX];	
};

// 친구 정보 
PROTOCOL_DECLARE(H2E_FRIEND_INFO, _H2E_FRIEND_INFO)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT8	channelID;
	UINT16	level;
	UINT8	onOff;			// 접속여부 0.비접속 1.접속  
};

PROTOCOL_DECLARE(E2H_FRIEND_INFO, _E2H_FRIEND_INFO)
{
public:
	UINT32	playerID;
	UINT8	serverID;
};

// 친구 채팅 
PROTOCOL_DECLARE(H2E_FRIEND_CHAT, _H2E_FRIEND_CHAT)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT8	chatType;						// 채팅 타입
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	// 말한 플레이어
	WCHAR	chatString[MAX_CHAT_LEN+1];
};

PROTOCOL_DECLARE(E2H_FRIEND_CHAT, _E2H_FRIEND_CHAT)
{
public:
	UINT32	playerID;
	UINT8	serverID;

	UINT8	chatType;						// 채팅 타입
	WCHAR	callsign[NICKNAME_LEN_MAX+1];	// 말한 플레이어
	WCHAR	chatString[MAX_CHAT_LEN+1];	
};


#pragma pack(pop)
*/