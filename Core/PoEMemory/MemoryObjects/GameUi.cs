using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExileCore.PoEMemory.MemoryObjects
{
    public class GameUi : Element
    {
        public Element UnusedPassivePointsButton => GetChildAtIndex(3);
        public int UnusedPassivePointsAmount => GetUnusedPassivePointsAmount();


        private int GetUnusedPassivePointsAmount()
        {
            var numberInButton = GetChildAtIndex(3)?.GetChildAtIndex(1);
            if (numberInButton == null || !numberInButton.IsVisible)
            {
                return 0;
            }
            int result;
            var success = Int32.TryParse(GetChildAtIndex(3)?.GetChildAtIndex(1)?.Text, out result);
            return success ? result : 0;
        }
    }
}
