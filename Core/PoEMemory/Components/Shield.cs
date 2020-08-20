namespace ExileCore.PoEMemory.Components
{
    public class Shield : Component
    {
        public int ChanceToBlock => Address != 0 ? M.Read<int>(Address + 0x10, 0x10) : 0;
    }
}
