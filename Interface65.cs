using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CLSCompliant(false), Guid("0000000a-0000-0000-C000-000000000046")]
internal interface Interface65
{
    int imethod_0(ulong A_0, [MarshalAs(UnmanagedType.LPArray)] byte[] A_1, uint A_2, out uint A_3);
    int imethod_1(ulong A_0, [MarshalAs(UnmanagedType.LPArray)] byte[] A_1, uint A_2, out uint A_3);
    int imethod_2();
    int imethod_3(ulong A_0);
    int imethod_4(ulong A_0, ulong A_1, uint A_2);
    int imethod_5(ulong A_0, ulong A_1, uint A_2);
    int imethod_6(out Struct3 A_0, uint A_1);
}

