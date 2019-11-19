namespace HessianLoginServer.Packets
{
    public class _C2S_LEAVE_CHANNEL
    {
        [Packet(CommonProtocolType._C2S_LEAVE_CHANNEL)]
        public static void OnC2S_LEAVE_CHANNEL(Packet packet)
        {
            var ack = new Packet(CommonProtocolType._S2C_LEAVE_CHANNEL_OK);
            packet.SendBack(ack);
        }
    }
}