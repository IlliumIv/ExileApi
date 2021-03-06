using ExileCore.Shared.Interfaces;

namespace ExileCore.PoEMemory.MemoryObjects
{
    public class NativeStringReader
    {
        public static string ReadString(long address, IMemory M)
        {
            return ReadString(address, M, 256);
        }

        //for compatibility reasons
        public static string ReadString(long address, IMemory M, int length = 256)
        {
            var Size = M.Read<uint>(address + 0x10);
            var Capacity = M.Read<uint>(address + 0x18);

            //var size = Size;
            //if (size == 0)
            //    return string.Empty;
            if ( /*8 <= size ||*/ 8 <= Capacity) //Have no idea how to deal with this
            {
                var readAddr = M.Read<long>(address);
                return M.ReadStringU(readAddr, length);
            }

            return M.ReadStringU(address, length);
        }

        public static string ReadStringLong(long address, IMemory M)
        {
            var size = (int)M.Read<uint>(address + 0x10) * 2;
            var capacity = M.Read<uint>(address + 0x18);

            //var size = Size;
            //if (size == 0)
            //    return string.Empty;
            if ( /*8 <= size ||*/ 8 <= capacity) //Have no idea how to deal with this
            {
                var readAddr = M.Read<long>(address);
                return M.ReadStringU(readAddr, size);
            }

            return M.ReadStringU(address, size);
        }

    }
}
