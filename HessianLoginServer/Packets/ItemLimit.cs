namespace HessianLoginServer.Packets
{
    public class ItemLimit : BinaryWriterExt.ISerializable
    {
        public ulong nLimit;
        public ulong nExpirationTime;
        public ushort nDurability;

        public ItemLimit()
        {
            nLimit = ulong.MaxValue - 1;
            nExpirationTime = ulong.MaxValue - 1;
            nDurability = ushort.MaxValue - 1;
        }

        public void Serialize(BinaryWriterExt writer)
        {
            writer.Write(nLimit);
            writer.Write(nExpirationTime);
            writer.Write(nDurability);
        }
    }
}