namespace Spire.CompoundFile.Doc.Native
{
    using System;

    [CLSCompliant(false)]
    internal enum ComErrorCodes : uint
    {
        DV_E_FORMATETC = 0x80040064,
        E_FAIL = 0x80004005,
        E_INVALIDARG = 0x80070057,
        E_NOTIMPL = 0x80000001,
        E_UNEXPECTED = 0x8000ffff,
        OLE_E_ADVISENOTSUPPORTED = 0x80040003,
        S_FALSE = 1,
        S_OK = 0
    }
}

