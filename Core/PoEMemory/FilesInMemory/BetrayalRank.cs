namespace ExileCore.PoEMemory.FilesInMemory
{
    public class BetrayalRank : RemoteMemoryObject
    {
        public string Id => M.ReadStringU(M.Read<long>(Address));
        public string Name => M.ReadStringU(M.Read<long>(Address + 0x8));
        public int Unknown => M.Read<int>(Address + 0x10);
        public string Art => M.ReadStringU(M.Read<long>(Address + 0x14));
        
        public int RankInt
        {
            get
            {
                switch (Id)
                {
                    case "Rank1": return 1;
                    case "Rank2": return 2;
                    case "Rank3": return 3;
                    default: return 0;
                }
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
