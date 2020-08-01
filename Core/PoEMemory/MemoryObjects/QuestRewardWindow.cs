using ExileCore.PoEMemory.Elements.InventoryElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExileCore.PoEMemory.MemoryObjects
{
    public class QuestRewardWindow : Element
    {
        private Element PossibleRewardsWrapper => GetChildAtIndex(5)?.GetChildAtIndex(0)?.GetChildAtIndex(0);
        public IList<Element> PossibleRewards => PossibleRewardsWrapper?.Children;
        public Element CancelButton => GetChildAtIndex(3);
        public Element SelectOneRewardString => GetChildAtIndex(0);
    }
}
