namespace HessianLoginServer.Packets
{
    public class C2S_PRIMARY_CHARAC
    {
        [Packet(CommonProtocolType._C2S_PRIMARY_CHARAC)]
        public static void OnC2S_PRIMARY_CHARAC(Packet packet)
        {
            var ack = new Packet(CommonProtocolType._S2C_PRIMARY_CHARAC_OK);
            packet.SendBack(ack);
        }
    }
}