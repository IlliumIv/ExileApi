using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExileCore.PoEMemory.Elements
{
    public class BanditDialog : Element
    {
        public Element HelpButton => GetChildAtIndex(2)?.GetChildAtIndex(0);
        public Element KillButton => GetChildAtIndex(2)?.GetChildAtIndex(1);

        public BanditType BanditType => GetBanditType();

        private BanditType GetBanditType()
        {
            if (HelpButton == null)
            {
                DebugWindow.LogError("BanditDialog.HelpButton is null, either window is not open or check offsets");
            }
            var helpButtonText = HelpButton?.GetChildAtIndex(0)?.Text?.ToLower();
            if (helpButtonText == null) throw new ArgumentException();

            if (helpButtonText.Contains("kraityn")) return BanditType.Kraityn;
            if (helpButtonText.Contains("alira")) return BanditType.Alira;
            if (helpButtonText.Contains("oak")) return BanditType.Oak;

            throw new ArgumentException();
        }
    }

    public enum BanditType
    {
        Kraityn,
        Alira,
        Oak
    }
}
