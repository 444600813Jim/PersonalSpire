using System;
using System.IO;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CLSCompliant(false), Guid("0000000c-0000-0000-C000-000000000046")]
internal interface Interface39
{
    int imethod_0([MarshalAs(UnmanagedType.LPArray)] byte[] A_0, uint A_1, ref uint A_2);
    int imethod_1([MarshalAs(UnmanagedType.LPArray)] byte[] A_0, uint A_1, ref uint A_2);
    int imethod_2(long A_0, SeekOrigin A_1, out long A_2);
    int imethod_3(ulong A_0);
    int imethod_4(Interface39 A_0, ulong A_1, ref ulong A_2, ref ulong A_3);
    int imethod_5(uint A_0);
    int imethod_6();
    int imethod_7(ulong A_0, ulong A_1, uint A_2);
    int imethod_8(ulong A_0, ulong A_1, uint A_2);
    int imethod_9(ref Struct3 A_0, uint A_1);
    int imethod_10(ref Interface39 A_0);
}

