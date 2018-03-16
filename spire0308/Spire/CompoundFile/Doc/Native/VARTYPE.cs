namespace Spire.CompoundFile.Doc.Native
{
    using System;

    [Flags]
    internal enum VARTYPE
    {
        VT_BOOL = 11,
        VT_BSTR = 8,
        VT_DATE = 7,
        VT_EMPTY = 0,
        VT_FILETIME = 0x40,
        VT_I4 = 3,
        VT_INT = 0x16,
        VT_LPSTR = 30,
        VT_LPWSTR = 0x1f,
        VT_VARIANT = 12,
        VT_VECTOR = 0x1000
    }
}

