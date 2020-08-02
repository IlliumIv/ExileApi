namespace ExileCore.PoEMemory.Elements
{
    public class InstanceManagerPanel : Element
    {
        public Element NewInstance => FindChildRecursive("new");
    }
}