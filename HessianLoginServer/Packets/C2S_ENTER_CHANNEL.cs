namespace HessianLoginServer.Packets
{
    public class C2S_ENTER_CHANNEL
    {
        [Packet(CommonProtocolType._C2S_ENTER_CHANNEL)]
        public static void OnC2S_ENTER_CHANNEL(Packet packet)
        {
            var channelId = packet.Reader.ReadByte();
            var ack = new Packet(CommonProtocolType._S2C_ENTER_CHANNEL_OK);
            ack.Writer.Write(channelId); // channel Id
            packet.SendBack(ack);
            
            /*

PROTOCOL_DECLARE(S2C_ENTER_CHANNEL_OK, _S2C_ENTER_CHANNEL_OK)
{
public:
	UINT8	nChannelID;
};
             */
        }
    }
}