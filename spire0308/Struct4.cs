using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct4
{
    private ushort ushort_0;
    private ushort ushort_1;
    private uint uint_0;
    [MarshalAs(UnmanagedType.LPWStr)]
    private string string_0;
}

