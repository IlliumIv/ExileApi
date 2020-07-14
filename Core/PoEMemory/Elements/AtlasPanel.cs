using System.Collections.Generic;

namespace ExileCore.PoEMemory.Elements
{
    public class AtlasPanel : Element
    {
        public Element AtlasInventory => GetObject<Element>(M.Read<long>(Address + 0x248, 0x3B0));
        public IList<Element> InventorySlots => AtlasInventory.Children;
    }
}