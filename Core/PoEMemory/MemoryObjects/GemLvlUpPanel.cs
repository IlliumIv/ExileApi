using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExileCore.PoEMemory.MemoryObjects
{
    public class GemLvlUpPanel : Element
    {
        public IList<Element> GemsToLvlUp => GetChildAtIndex(0)?.Children;

        public Element LvlUpButtonForGem(Element gem)
        {
            return gem?.GetChildAtIndex(1);
        }

        public bool MeetRequirementForGem(Element gem)
        {
            var text = TextForGem(gem)?.Text;
            if (text == null) return false;
            return text.ToLower().Trim() == "click to level up";
        }

        public Element TextForGem(Element gem)
        {
            return gem?.GetChildAtIndex(3);
        }
    }
}
