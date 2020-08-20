namespace ExileCore.PoEMemory.MemoryObjects
{
    public class MapDeviceWindow : Element
    {
        public Element OpenMapDialog => GetChildAtIndex(0);
        public Element CloseMapDialog => GetChildAtIndex(1);
        public Element ChooseZanaMod => GetChildAtIndex(2);
        public Element BottomMapSettings => GetChildAtIndex(3);

        public Element ActivateButton => BottomMapSettings?.GetChildAtIndex(0);
        public Element ChooseMastersMods => BottomMapSettings?.GetChildAtIndex(1);
    }
}