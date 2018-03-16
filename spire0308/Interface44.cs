using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;

[ComConversionLoss, Guid("0000013a-0000-0000-c000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CLSCompliant(false)]
internal interface Interface44
{
    void imethod_0(ref Guid A_0, ref Guid A_1, uint A_2, STGM A_3, out Interface43 A_4);
    [PreserveSig]
    int imethod_1(ref Guid A_0, STGM A_1, out Interface43 A_2);
    void imethod_2(ref Guid A_0);
    void imethod_3(out Interface41 A_0);
}

