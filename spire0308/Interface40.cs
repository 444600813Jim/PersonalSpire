using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

[CLSCompliant(false), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0000000b-0000-0000-C000-000000000046")]
internal interface Interface40
{
    int imethod_0([MarshalAs(UnmanagedType.LPWStr)] string A_0, STGM A_1, uint A_2, uint A_3, ref Interface39 A_4);
    int imethod_1([MarshalAs(UnmanagedType.LPWStr)] string A_0, uint A_1, STGM A_2, uint A_3, out Interface39 A_4);
    int imethod_2([MarshalAs(UnmanagedType.LPWStr)] string A_0, STGM A_1, uint A_2, uint A_3, out Interface40 A_4);
    int imethod_3([MarshalAs(UnmanagedType.LPWStr)] string A_0, IntPtr A_1, STGM A_2, IntPtr A_3, uint A_4, out Interface40 A_5);
    int imethod_4(uint A_0, IntPtr A_1, IntPtr A_2, Interface40 A_3);
    int imethod_5(string A_0, Interface40 A_1, string A_2, uint A_3);
    int imethod_6(uint A_0);
    int imethod_7();
    int imethod_8(uint A_0, IntPtr A_1, uint A_2, ref Interface38 A_3);
    int imethod_9(string A_0);
    int imethod_10(string A_0, string A_1);
    int imethod_11(string A_0, ref FILETIME A_1, ref FILETIME A_2, ref FILETIME A_3);
    int imethod_12(ref Guid A_0);
    int imethod_13(uint A_0, uint A_1);
    int imethod_14(ref Struct3 A_0, uint A_1);
}

