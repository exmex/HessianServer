using System.Collections.Generic;
using System.IO;
using HessianLoginServer.Packets;

namespace HessianLoginServer.ServerPackets
{
    public class CharacterInfo : BinaryWriterExt.ISerializable
    {
        public ulong ExpirationTime;
        public byte CharAcCode;
        public byte TattooCode;
        public byte SaleType;

        public ItemId ProtectionItemId;
        public ItemId SurvivalItemId;
        public ItemId TacticalItemId;
        public ItemId TrainingItemId;
        public ItemId CTSItemId;

        public void Serialize(BinaryWriterExt writer)
        {
            writer.Write(ExpirationTime);
            writer.Write(CharAcCode);
            writer.Write(TattooCode);
            writer.Write(SaleType);

            writer.Write(ProtectionItemId);
            writer.Write(SurvivalItemId);
            writer.Write(TacticalItemId);
            writer.Write(TrainingItemId);
            writer.Write(CTSItemId);
        }
    }

    public class S2C_INVENTORY : BinaryWriterExt.ISerializable
    {
        /// <summary>
        /// Primary Character Slot
        /// </summary>
        public byte PrimarySlot;

        public List<CharacterInfo> Characters = new List<CharacterInfo>();
        public List<Item> Inventory = new List<Item>();

        public void Serialize(BinaryWriterExt writer)
        {
            writer.Write(PrimarySlot);
            writer.Write((byte)Characters.Count);
            writer.Write((byte)Inventory.Count);

            foreach (var character in Characters)
            {
                writer.Write(character);
            }
            
            foreach (var invItem in Inventory)
            {
                writer.Write(invItem);
            }
        }
    }
}