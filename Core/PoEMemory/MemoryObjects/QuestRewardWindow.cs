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
        public IList<(Entity, Element)> GetPossibleRewards()
        {
            var rewardsElems = GetChildAtIndex(5)?.GetChildAtIndex(0)?.Children.SelectMany(x => x.Children).ToList();
            var rewards = new List<(Entity, Element)>();
            foreach (var rewardElem in rewardsElems)
            {
                var subRewardElem = rewardElem.GetChildFromIndices(0, 1);
                var rewardEntity = subRewardElem?.ReadObject<Entity>(subRewardElem.Address + 0x0388);
                rewards.Add((rewardEntity, rewardElem));
            }
            return rewards;
        }
        public Element CancelButton => GetChildAtIndex(3);
        public Element SelectOneRewardString => GetChildAtIndex(0);
    }
}
