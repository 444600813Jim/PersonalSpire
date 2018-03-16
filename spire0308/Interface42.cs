using System;
using System.Runtime.InteropServices;

[CLSCompliant(false), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("00000139-0000-0000-C000-000000000046")]
internal interface Interface42
{
    void imethod_0(int A_0, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] Struct7[] A_1, out int A_2);
    void imethod_1(uint A_0);
    void imethod_2();
    void imethod_3(out Interface42 A_0);
}

