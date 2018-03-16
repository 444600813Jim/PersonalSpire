using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
internal struct Struct3
{
    [MarshalAs(UnmanagedType.LPWStr)]
    public string string_0;
    internal STGTY stgty_0;
    public ulong ulong_0;
    public FILETIME filetime_0;
    public FILETIME filetime_1;
    public FILETIME filetime_2;
    public uint uint_0;
    public LOCKTYPE locktype_0;
    public Guid guid_0;
    public uint uint_1;
    public uint uint_2;
}

