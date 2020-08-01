using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExileCore.PoEMemory.Elements
{
    public class NpcDialog : Element
    {
        public string NpcName => this.GetChildAtIndex(1)?.GetChildAtIndex(3)?.Text;
        public Element NpcLineWrapper => this.GetChildAtIndex(0)?.GetChildAtIndex(2);
        public List<NpcLine> NpcLines => GetNpcLines();
        public bool IsLoreTalkVisible => NpcLines.Count == 0 && IsVisible; 

        private List<NpcLine> GetNpcLines()
        {
            var npcLines = new List<NpcLine>();
            if (NpcLineWrapper?.Children == null)
            {
                DebugWindow.LogError("NpcLineWrapper?.Children is null, check offsets");
                return npcLines;
            }
            foreach (var line in NpcLineWrapper?.Children)
            {
                try
                {
                    var npcLine = new NpcLine(line);
                    npcLines.Add(npcLine);
                }
                catch (Exception e)
                {
                    continue;
                }
            }
            return npcLines;
        }

        
    }

    public class NpcLine
    {
        public NpcLine(Element element)
        {
            Element = element ?? throw new ArgumentNullException(nameof(element));
            Text = Element.GetChildAtIndex(0)?.Text ?? throw new ArgumentOutOfRangeException(nameof(element));
        }

        public Element Element { get; }
        public string Text { get; }

        public override string ToString()
        {
            return Text;
        }
    }
}
