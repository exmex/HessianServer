using System;
using System.IO;

namespace HessianLoginServer.Packets
{
    public class Item : BinaryWriterExt.ISerializable
    {
        public ItemLimit ItemLimit;
        public ItemBitInfo ItemBitInfo;

        public ItemId itemId;

        public Item(uint nItemUid, ushort nItemCode)
        {
            itemId = new ItemId(nItemUid, nItemCode);
            ItemLimit = new ItemLimit();
            ItemBitInfo = new ItemBitInfo();
        }

        public void Serialize(BinaryWriterExt writer)
        {
            writer.Write(ItemLimit);
            writer.Write(itemId);
            writer.Write(ItemBitInfo);
        }
    }
}