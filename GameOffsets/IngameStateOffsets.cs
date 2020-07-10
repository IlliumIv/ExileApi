using System.Runtime.InteropServices;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct IngameStateOffsets
    {
		[FieldOffset(0x15D0)] public long IngameUi;
		[FieldOffset(0xA0)] public long EntityLabelMap;
		[FieldOffset(0x4F8)] public long Data;
        [FieldOffset(0x500)] public long ServerData;
        [FieldOffset(0x628)] public long UIRoot;
		[FieldOffset(0x660)] public long UIHoverTooltip;
		[FieldOffset(0x668)] public float CurentUElementPosX;
		[FieldOffset(0x66C)] public float CurentUElementPosY;
		[FieldOffset(0x670)] public long UIHover;
		[FieldOffset(0x698)] public int MouseXGlobal;
		[FieldOffset(0x69C)] public int MouseYGlobal;
		[FieldOffset(0x6A4)] public float UIHoverX;
		[FieldOffset(0x6A8)] public float UIHoverY;
		[FieldOffset(0x6AC)] public float MouseXInGame;
		[FieldOffset(0x6B0)] public float MouseYInGame;
		[FieldOffset(0x6D4)] public float TimeInGame;
		[FieldOffset(0x6DC)] public float TimeInGameF;
		[FieldOffset(0x6F0)] public int DiagnosticInfoType;
        [FieldOffset(0x920)] public long LatencyRectangle;
        [FieldOffset(0xDC0)] public long FrameTimeRectangle;
        [FieldOffset(0x1010)] public long FPSRectangle;
        [FieldOffset(0x1160)] public int Camera;
    }
}
