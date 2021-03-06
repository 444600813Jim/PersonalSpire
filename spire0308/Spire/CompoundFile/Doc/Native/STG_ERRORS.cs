﻿namespace Spire.CompoundFile.Doc.Native
{
    using System;

    [CLSCompliant(false)]
    internal enum STG_ERRORS : uint
    {
        S_FAIL = 1,
        S_OK = 0,
        STG_E_ACCESSDENIED = 0x80030005,
        STG_E_FILEALREADYEXISTS = 0x80030050,
        STG_E_FILENOTFOUND = 0x80030002,
        STG_E_INSUFFICIENTMEMORY = 0x80030008,
        STG_E_INVALIDFLAG = 0x800300ff,
        STG_E_INVALIDFUNCTION = 0x80030001,
        STG_E_INVALIDHANDLE = 0x80030006,
        STG_E_INVALIDNAME = 0x800300fc,
        STG_E_INVALIDPOINTER = 0x80030009,
        STG_E_LOCKVIOLATION = 0x80030021,
        STG_E_NOTSIMPLEFORMAT = 0x80030112,
        STG_E_OLDDLL = 0x80030105,
        STG_E_OLDFORMAT = 0x80030104,
        STG_E_PATHNOTFOUND = 0x80030003,
        STG_E_SHAREVIOLATION = 0x80030020,
        STG_E_TOOMANYOPENFILES = 0x80030004
    }
}

