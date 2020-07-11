namespace ExileCore.PoEMemory.Elements
{
    public class SyndicatePanel : Element
    {
        public Element EventElement
        {
            get
            {
                var ch = GetChildAtIndex(0);

                if (ch.ChildCount < 25)
                    return null;

                return ch.GetChildAtIndex(24);
            }
        }

        public Element TextElement => EventElement?.GetChildFromIndices(5, 1);
        public string EventText => TextElement.Text;
    }
}