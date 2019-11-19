namespace HessianLoginServer
{
    public enum CommonProtocolType : ushort
    {
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

        _L2D_DB_MEMBER_ADD, // 계정이 없으면 생성한다. 
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
        /*
        //_S2S_DB_LOAD_INFO, 
        
        //_S2S_NEW_PLAYER, 
    
        //_S2S_DB_PLAYER_INFO, 
        _D2H_DB_PLAYER_INFO, 
    
        //_S2S_DB_BATTLE_RECORDS, 
        _D2H_DB_BATTLE_RECORDS, 
    
        //_S2S_DB_INVENTORY, 
        _D2H_DB_INVENTORY, 
    
        //_S2S_DB_UPDATE_PLAYER_INFO, 
        _H2D_DB_UPDATE_PLAYER_INFO, 
    
        //_S2S_DB_UPDATE_BATTLE_RECORDS, 
        _H2D_DB_UPDATE_BATTLE_RECORDS, 
    
        //_S2S_DB_UPDATE_INVENTORY, 
        _H2D_DB_UPDATE_INVENTORY, 
        */


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

/*public enum CommonProtocolType : ushort
{
    // client protocol
    // 0x1... Ã¤³Î ¼¼¼Ç ÇÁ·ÎÅäÄÝ 
    // 0x2... ·Î±×ÀÎ ¼¼¼Ç ÇÁ·ÎÅäÄÝ 
    // ÇöÀç 3°³¸¦ Á¦¿ÜÇÏ°í ¸ðµÎ Ã¤³Î¼¼¼Ç ÇÁ·ÎÅäÄÝÀÌ´Ù.
    //-------------------------------------------------------------

    // Ã¤³Î ¼¼¼Ç ÇÁ·ÎÅäÄÝ
    //-----------------------------------------

    // Á¢¼Ó 
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

    // Ã¤³Î 
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

    // ÅõÇ¥
    _C2S_VOTE_PROPOSE,
    _S2C_VOTE_PROPOSED,
    _C2S_VOTE_CAST,
    _S2C_VOTE_FINISHED,

    // ÃÊÃ»
    _C2S_INVITE_REQ_LOBBY_PLAYERS,
    _S2C_INVITE_RES_LOBBY_PLAYERS,
    _C2S_INVITE_TARGET_SELECTED,
    _S2C_INVITE_LOBBY_INVITATION,
    _C2S_INVITE_INVITATION_REPLY,

    // ÀüÅõ 
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
    _C2S_MATCH_MIDDLE_SCORE, // 2011.04.25 ÅÇÅ° Áß°£°á°ú ÆÐÅ¶Ãß°¡.
    _S2C_MATCH_MIDDLE_SCORE,

    // Ã¤ÆÃ 
    _C2S_CHAT,
    _S2C_CHAT,
    _C2S_JUMPTO,
    _S2C_JUMPTO,
    //_C2S_FRIEND_LIST, 
    //_S2C_FRIEND_LIST, 
    //_S2C_FRIEND_STATUS, 
    //_S2C_FRIEND_INFO, 
    //_C2S_FRIEND_INFO, 

    // ¹Ì¼Ç 
    _C2S_MISSION_PLAYER_KILL,
    _C2S_MISSION_EVENT,
    _C2S_MISSION_ITEM_EQUIP,
    _S2C_MISSION_SCORE,
    _S2C_UPDATE_CASHPOINT,
    _S2C_EVENT_RESULT,

    // È¦ÆÝÄª 
    _C2S_NAT_RESOLVE_START,
    _S2C_NAT_RESOLVE_INFO,
    _C2S_NAT_RESOLVE_END,
    _C2S_FULLCONE_RESULT,

    // Å¬·£ ¸Þ¼¼Áö 
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

    // ÂÊÁö ¸Þ¼¼Áö 
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

    // Ä£±¸½Ã½ºÅÛ 
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

    // LOGIN SERVER START
    // ·Î±×ÀÎ ¼¼¼Ç ÇÁ·ÎÅäÄÝ 
    //-----------------------------------------
    _C2S_VERSION = 0x2000,
    _C2S_GAME_LOGIN,
    _S2C_GAME_LOGIN_OK,

    // ¸±·¹ÀÌ ÇÁ·ÎÅäÄÝ 
    //-----------------------------------------
    _WELCOME_PING,
    _RELAY_PING,
    _RELAY_PONG,
    _INVITE_PING,


    // server protocol
    //------------------------------------------------------------------------------------------------------------
    // GMProxy¼­¹ö - G, DBProxy¼­¹ö - D, Center¼­¹ö - E, Channel¼­¹ö - H, 
    // Login¼­¹ö - L, Relay¼­¹ö - R, Community¼­¹ö - N

    // ·Î±×ÀÎ 
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

    _L2D_DB_MEMBER_ADD, // °èÁ¤ÀÌ ¾øÀ¸¸é »ý¼ºÇÑ´Ù. 
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

    // GM ¿ä±¸»çÇ× 
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

    // Ä£±¸ (ÀÌÀü ¸Þ¼¼Áö, »ç¿ë¾ÈÇÔ)
    //-----------------------------------------
    //_S2N_FRIEND_INFO, 
    //_S2N_FRIEND_STATUS, 
    //_N2S_FRIEND_LIST, 
    //_N2S_FRIEND_INFO, 
    //_N2S_FRIEND_ERROR, 


    // Å¬·£ ¸Þ¼¼Áö 
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

    _H2E_LOBBY_MEMBER_INFO,
    _E2H_LOBBY_MEMBER_INFO,

    _H2E_LOBBY_MEMBER_REMOVE,
    _E2H_LOBBY_MEMBER_REMOVE,

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

    // ÂÊÁö ½Ã½ºÅÛ 
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

    // Ä£±¸ ½Ã½ºÅÛ 
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
};*/
}