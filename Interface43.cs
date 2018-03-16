using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

[CLSCompliant(false), ComConversionLoss, Guid("00000138-0000-0000-c000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface43
{
    void imethod_0(uint A_0, [In, MarshalAs(UnmanagedType.LPArray)] Struct8[] A_1, [In, Out, MarshalAs(UnmanagedType.LPArray)] Struct9[] A_2);
    void imethod_1(uint A_0, [In, MarshalAs(UnmanagedType.LPArray)] Struct8[] A_1, [In, MarshalAs(UnmanagedType.LPArray)] Struct9[] A_2, int A_3);
    void imethod_2(uint A_0, ref Struct8 A_1);
    void imethod_3(uint A_0, ref uint A_1, [MarshalAs(UnmanagedType.LPWStr)] out string A_2);
    void imethod_4(uint A_0, ref uint A_1, [MarshalAs(UnmanagedType.LPWStr)] ref string A_2);
    void imethod_5(uint A_0, ref uint A_1);
    void imethod_6(uint A_0);
    void imethod_7();
    void imethod_8(out Interface42 A_0);
    void imethod_9(ref FILETIME A_0, ref FILETIME A_1, ref FILETIME A_2);
    void imethod_10(ref Guid A_0);
    void imethod_11(ref Struct6 A_0);
    void imethod_12(uint A_0, ref Struct8 A_1, IntPtr A_2);
    void imethod_13(uint A_0, ref Struct8 A_1, IntPtr A_2, PID A_3);
    void imethod_14(STGC A_0);
}

