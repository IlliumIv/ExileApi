using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ExileCore.Shared.Interfaces;

namespace ExileCore.PoEMemory.Components
{
    public class HarvestInfrastructure : Component
    {
        public unsafe List<HarvestInfrastructureMod> CraftMods
        {
            get
            {
                var start = M.Read<long>(Address + 0x20);
                var end = M.Read<long>(Address + 0x28);

                var structs =
                    M.ReadStructsArray<HarvestInfrastructureModUnmanaged>(start, end,
                        sizeof(HarvestInfrastructureModUnmanaged));

                return structs.Select(x => new HarvestInfrastructureMod(x, M)).ToList();
            }
        }
    }


    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    internal struct HarvestInfrastructureModUnmanaged
    {
        [FieldOffset(0x0)] public long DatPtrUnused;
        [FieldOffset(0x8)] public long DatEntryPtr;
        [FieldOffset(0x10)] public int ModLevel;
        [FieldOffset(0x14)] public int Unknown;
    }

    public class HarvestInfrastructureMod
    {
        internal HarvestInfrastructureMod(HarvestInfrastructureModUnmanaged data, IMemory m)
        {
            ModLevel = data.ModLevel;

            var namePtr = m.Read<long>(data.DatEntryPtr + 0x8);
            var name = m.ReadStringU(namePtr, 1000);
            ModName = Regex.Replace(name,  @"\<(.*?)\>|\{|\}", string.Empty) ;//@" \<(.*?)\>"
        }

        public int ModLevel { get; }
        public string ModName { get; }

        public override string ToString()
        {
            return $"{ModName}. ({ModLevel})";
        }
    }
}