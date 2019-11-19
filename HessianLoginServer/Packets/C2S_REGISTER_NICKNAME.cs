namespace HessianLoginServer.Packets
{
    public class C2S_REGISTER_NICKNAME
    {
        [Packet(CommonProtocolType._C2S_REGISTER_NICKNAME)]
        public static void OnC2S_REGISTER_NICKNAME(Packet packet)
        {
            var ack = new Packet(CommonProtocolType._S2C_REGISTER_NICKNAME);
            ack.Writer.WriteUnicodeStatic(packet.Reader.ReadUnicodeStatic(16), 17);
            ack.Writer.Write((byte)0);
            packet.SendBack(ack);
            /*
PROTOCOL_DECLARE(S2C_REGISTER_NICKNAME, _S2C_REGISTER_NICKNAME)
{
public:
	WCHAR	szNickname[NICKNAME_LEN_MAX+1];	// ¿äÃ»ÇÑ ´Ð³×ÀÓ
	UINT8	nResult;	// 0 ÀÌ¸é ¼º°ø, ±× ¿Ü ¿¡·¯ ÄÚµå
};
             */
        }
    }
}