using System;
using System.Runtime.InteropServices;

internal sealed class Class1102
{
    private Class1102()
    {
        throw new NotImplementedException();
    }

    [DllImport("gdi32.dll")]
    internal static extern IntPtr CreateDC(string A_0, string A_1, string A_2, IntPtr A_3);
    [DllImport("gdi32.dll")]
    internal static extern bool DeleteDC(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern int DeleteObject(IntPtr A_0);
    [DllImport("gdi32.dll")]
    internal static extern uint GetFontData(IntPtr A_0, uint A_1, uint A_2, [In, Out] byte[] A_3, uint A_4);
    [DllImport("gdi32.dll")]
    internal static extern IntPtr SelectObject(IntPtr A_0, IntPtr A_1);
}

