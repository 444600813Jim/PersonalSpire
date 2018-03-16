using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode), CLSCompliant(false)]
internal struct Struct7
{
    [MarshalAs(UnmanagedType.LPWStr)]
    public string string_0;
    public uint uint_0;
    public VARTYPE vartype_0;
}

