using System;
using System.Net;
using System.Runtime.InteropServices;

namespace HessianLoginServer.Packets
{
    public class C2S_GAME_LOGIN
    {
	    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	    public unsafe static extern int time(int* timer);
        [Packet(CommonProtocolType._C2S_GAME_LOGIN)]
        public static void OnC2S_GAME_LOGIN(Packet packet)
        {
	        unsafe
	        {
		        /*
PROTOCOL_DECLARE(C2S_GAME_LOGIN, _C2S_GAME_LOGIN)
{
public:
	WCHAR	szAccount[ACCOUNT_LEN_MAX+1];	// °èÁ¤ ±æÀÌ È®ÀÎ
	WCHAR	szPassword[PASSWD_LEN_MAX+1];	// ºñ¹Ð¹øÈ£ ±æÀÌ È®ÀÎ ¹× ¾ÏÈ£È­
	WORD	nCookieSize;	// ÄíÅ° Å©±â
	BYTE	AuthCookie[COOKIE_SIZE];	// À¥ ·Î±ä ½Ã¿¡ ¹ÞÀº ÄíÅ°
};
	         */
		        var username = packet.Reader.ReadUnicodeStatic(33);
		        var password = packet.Reader.ReadUnicodeStatic(12);
		        var cookieSize = packet.Reader.ReadUInt16();
		        var cookie = packet.Reader.ReadBytes(cookieSize);
		        Console.WriteLine("{0}:{1}", username, password);
		        Console.WriteLine(Program.HexDump(cookie));
		        Console.WriteLine("Handling Game Login");
	        
		        var ack = new Packet(CommonProtocolType._S2C_GAME_LOGIN_OK);
		        ack.Writer.Write((ulong)0); // Authkey
		        ack.Writer.Write((uint)0); // playeruid
		        ack.Writer.Write((ulong)time(null)); // servercurtime
		        ack.Writer.Write((byte)9); // gamerights
		        ack.Writer.Write((byte)18); // isadult
		        ack.Writer.Write((byte)1); // size
            
		        ack.Writer.Write((byte)0); // id
		        ack.Writer.WriteUnicodeStatic("127.0.0.1", 61); // serveraddress
		        ack.Writer.Write((ushort)5555); // port
		        ack.Writer.WriteUnicodeStatic("Public", 21); // Category
		        ack.Writer.WriteUnicodeStatic("Empty", 21); // server name
            
		        packet.SendBack(ack);

		        /*
PROTOCOL_DECLARE(S2C_SERVER_STATUS, _S2C_SERVER_STATUS)
{
public:
	UINT8	nServerCnt;	// Ã¤³Î ¼­¹ö ¼ö
	UINT16	ServerStatusList[MAX_SERVER_CNT];	// Ã¤³Î ¼­¹ö »óÅÂ Á¤º¸
};
		         */
		        var ack2 = new Packet(CommonProtocolType._S2C_SERVER_STATUS);
		        ack2.Writer.Write((byte)1);
		        ack2.Writer.Write((short)1);
		        packet.SendBack(ack2);
/*
PROTOCOL_DECLARE(S2C_CHANNEL_STATUS, _S2C_CHANNEL_STATUS)
{
public:
	UINT8	nChannelCnt;	// Ã¤³Î ¼ö
	UINT8	PopulationPercentList[MAX_CHANNEL_CNT];	// Ã¤³Î ÀÔÀå ÀÎ¿ø ¹éºÐÀ².
};
 */
		        ack2 = new Packet(CommonProtocolType._S2C_CHANNEL_STATUS);
		        ack2.Writer.Write((byte)1);
		        ack2.Writer.Write((byte)1);
		        packet.SendBack(ack2);
		        
/*

struct _HG_SERVER_ADDRESS 
{
	UINT32	nIP;
	UINT16	nPort;
	UINT16	nID;
};

PROTOCOL_DECLARE(S2C_SERVER_ADDRESS, _S2C_SERVER_ADDRESS)
{
public:
	UINT8	nCount;	// °³¼ö
	_HG_SERVER_ADDRESS	AddressList[MAX_SERVER_CNT];	// Ã¤³Î ¼­¹ö ÁÖ¼Ò
};
		         */
		        ack2 = new Packet(CommonProtocolType._S2C_SERVER_ADDRESS);
		        ack2.Writer.Write((byte)1);
		        ack2.Writer.Write((uint)IPAddress.Parse("127.0.0.1").Address);
		        ack2.Writer.Write((short)5585);
		        ack2.Writer.Write((short)0);
		        packet.SendBack(ack2);
		        
		        
		        /*
	UINT64	nAuthKey;	// ·Î±ä¼­¹ö¿¡¼­ ¹ß±ÞÇÑ ÀÎÁõÅ°
	UINT32	nPlayerUID;	// °èÁ¤ º°·Î ÇÒ´çµÈ Á¤¼öÅ°
	UINT64	nServerCurTime;	// ÇöÀç ¼­¹ö ½Ã°¢
	UINT8	nGamerights;	// 0:ÀÏ¹Ý/1:¹ÌÁ¦ÈÞPC¹æ/2:Á¦ÈÞPC¹æ/9:GM½ÇÇà
	UINT8	IsAdult;		// 15¼¼ 18¼¼ ¼ºÀÎÀÎÁõ

	UINT8   size;

	_LOCAL_SERVER_INFO  info[MAX_SERVER_CNT];
/ ·Î±×ÀÎ¼­¹ö¿¡¼­ º¸³»´Â ¼­¹öÁ¤º¸ 
struct _LOCAL_SERVER_INFO
{
	UINT8	id;
	WCHAR	serverAddress[61];
	UINT16	port;
	WCHAR	category[21];
	WCHAR	serverName[21];	
};
             */
	        }
        }
        
    }
}