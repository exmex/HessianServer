namespace HessianLoginServer.Packets
{
    public class ItemBitInfo : BinaryWriterExt.ISerializable
    {
        public byte Info = 0;
        public void Serialize(BinaryWriterExt writer)
        {
            writer.Write(Info);
        }
    }
}