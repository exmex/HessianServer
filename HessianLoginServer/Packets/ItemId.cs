using System;
using System.IO;

namespace HessianLoginServer.Packets
{
    public class ItemId : BinaryWriterExt.ISerializable
    {
        public uint nItemUID;
        public ushort nItemCode;

        public ItemId(uint nItemUid, ushort nItemCode)
        {
            nItemUID = nItemUid;
            this.nItemCode = nItemCode;
        }

        public void Serialize(BinaryWriterExt writer)
        {
            writer.Write(nItemUID);
            writer.Write(nItemCode);
        }
    }
}