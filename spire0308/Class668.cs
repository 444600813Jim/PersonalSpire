using Spire.Doc;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal sealed class Class668
{
    private Class668()
    {
        throw new NotImplementedException();
    }

    [DllImport("gdi32.dll")]
    internal static extern bool AbortPath(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int AddFontResource(string A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool AngleArc(IntPtr A_0, int A_1, int A_2, int A_3, float A_4, float A_5);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool Arc(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool ArcTo(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8);
    [DllImport("gdi32.dll")]
    internal static extern bool BeginPath(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern bool BitBlt(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, IntPtr A_5, int A_6, int A_7, uint A_8);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool Chord(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool CloseFigure(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr CopyMetaFile(IntPtr A_0, string A_1);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr CreateDC(string A_0, string A_1, string A_2, IntPtr A_3);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr CreateFontIndirect(ref Class613 A_0);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr CreateIC(string A_0, string A_1, string A_2, IntPtr A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool DeleteDC(IntPtr A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool DeleteEnhMetaFile(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int DeleteObject(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr DPtoLP(IntPtr A_0, [In, Out] Struct13[] A_1, int A_2);
    [DllImport("gdi32.dll")]
    internal static extern bool EndPath(IntPtr A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool FillPath(IntPtr A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern int GetArcDirection(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetBkColor(IntPtr A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool GetCharABCWidths(IntPtr A_0, int A_1, int A_2, ref Struct12 A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool GetCharWidth32(IntPtr A_0, int A_1, int A_2, int[] A_3);
    [CLSCompliant(false), DllImport("user32.dll")]
    internal static extern bool GetClientRect(IntPtr A_0, out Struct15 A_1);
    [DllImport("user32.dll")]
    internal static extern IntPtr GetDC(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetDCBrushColor(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetDCPenColor(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetDeviceCaps(IntPtr A_0, int A_1);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern int GetEnhMetaFileBits(IntPtr A_0, int A_1, byte[] A_2);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern uint GetFontData(IntPtr A_0, uint A_1, uint A_2, [In, Out] byte[] A_3, uint A_4);
    [DllImport("gdi32.dll")]
    internal static extern int GetGraphicsMode(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetMapMode(IntPtr A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern int GetMetaFileBitsEx(IntPtr A_0, int A_1, byte[] A_2);
    [DllImport("gdi32.dll")]
    internal static extern bool GetMiterLimit(IntPtr A_0, out float A_1);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern int GetOutlineTextMetrics(IntPtr A_0, int A_1, ref Struct21 A_2);
    [CLSCompliant(false), DllImport("gdi32.dll", EntryPoint="GetOutlineTextMetrics")]
    internal static extern int GetOutlineTextMetrics_1(IntPtr A_0, int A_1, IntPtr A_2);
    [DllImport("gdi32.dll")]
    internal static extern int GetPolyFillMode(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetTextAlign(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int GetTextColor(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern bool GetTextExtentPoint32(IntPtr A_0, string A_1, int A_2, out Struct16 A_3);
    [DllImport("gdi32.dll", EntryPoint="GetTextExtentPoint32")]
    internal static extern bool GetTextExtentPoint32_1(IntPtr A_0, string A_1, int A_2, ref Size A_3);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern uint GetWinMetaFileBits(IntPtr A_0, uint A_1, byte[] A_2, int A_3, IntPtr A_4);
    [DllImport("gdi32.dll")]
    internal static extern bool LineTo(IntPtr A_0, int A_1, int A_2);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr LPtoDP(IntPtr A_0, [In, Out] Struct13[] A_1, int A_2);
    [DllImport("gdi32.dll")]
    internal static extern bool ModifyWorldTransform(IntPtr A_0, ref Struct17 A_1, int A_2);
    [DllImport("gdi32.dll")]
    internal static extern bool MoveToEx(IntPtr A_0, int A_1, int A_2, ref Struct13 A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool PolyBezierTo(IntPtr A_0, Struct13[] A_1, uint A_2);
    [DllImport("gdi32.dll")]
    internal static extern bool PolylineTo(IntPtr A_0, Struct13[] A_1, uint A_2);
    [DllImport("gdi32.dll")]
    internal static extern bool RemoveFontResource(string A_0);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr RestoreDC(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr SaveDC(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern bool ScaleViewportExtEx(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, IntPtr A_5);
    [DllImport("gdi32.dll")]
    internal static extern bool ScaleWindowExtEx(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, IntPtr A_5);
    [DllImport("gdi32.dll")]
    internal static extern bool SelectClipPath(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr SelectObject(IntPtr A_0, IntPtr A_1);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern int SetArcDirection(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern int SetBkColor(IntPtr A_0, int A_1);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern int SetBkMode(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern int SetGraphicsMode(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern int SetICMMode(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern int SetMapMode(IntPtr A_0, int A_1);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern IntPtr SetMetaFileBitsEx(uint A_0, byte[] A_1);
    [DllImport("gdi32.dll")]
    internal static extern bool SetMiterLimit(IntPtr A_0, float A_1, out float A_2);
    [DllImport("gdi32.dll")]
    internal static extern int SetPolyFillMode(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern int SetTextAlign(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern int SetTextColor(IntPtr A_0, int A_1);
    [DllImport("gdi32.dll")]
    internal static extern bool SetViewportExtEx(IntPtr A_0, int A_1, int A_2, ref Struct16 A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool SetViewportOrgEx(IntPtr A_0, int A_1, int A_2, ref Struct13 A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool SetWindowExtEx(IntPtr A_0, int A_1, int A_2, ref Struct16 A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool SetWindowOrgEx(IntPtr A_0, int A_1, int A_2, ref Struct16 A_3);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern IntPtr SetWinMetaFileBits(int A_0, byte[] A_1, IntPtr A_2, ref Struct18 A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool SetWorldTransform(IntPtr A_0, ref Struct17 A_1);
    internal static byte[] smethod_0(Font A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("丧䔩䈫娭", num));
        }
        byte[] buffer = null;
        IntPtr ptr = CreateDC(BookmarkStart.b("氧挩缫縭簯猱洳", num), null, null, IntPtr.Zero);
        IntPtr ptr2 = A_0.ToHfont();
        IntPtr ptr3 = SelectObject(ptr, ptr2);
        uint num2 = GetFontData(ptr, 0, 0, null, 0);
        if (num2 == uint.MaxValue)
        {
            Class947.GetLastError();
            throw new Exception(BookmarkStart.b("䬧䬩䈫อ帯崱䀳ᘵ䠷嬹主䴽┿扁ぃ⹅ⵇ橉⩋⅍㹏♑", num));
        }
        buffer = new byte[num2];
        GetFontData(ptr, 0, 0, buffer, num2);
        DeleteObject(SelectObject(ptr, ptr3));
        DeleteObject(ptr3);
        DeleteDC(ptr2);
        DeleteDC(ptr);
        return buffer;
    }

    [DllImport("gdi32.dll")]
    internal static extern int StretchDIBits(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8, byte[] A_9, [In] ref Struct20 A_10, int A_11, uint A_12);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool StrokeAndFillPath(IntPtr A_0);
    [CLSCompliant(false), DllImport("gdi32.dll")]
    internal static extern bool StrokePath(IntPtr A_0);
}

