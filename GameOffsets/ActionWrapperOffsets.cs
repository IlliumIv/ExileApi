using System.Runtime.InteropServices;
using GameOffsets.Native;
using SharpDX;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ActionWrapperOffsets
    {
        [FieldOffset(0x78)] public Vector2i Destination;
        [FieldOffset(0x70)] public long Target;
        [FieldOffset(0x58)] public long Skill;
    }
}
