namespace Spire.Doc
{
    using System;

    internal enum ThemeFontTypes
    {
        Ascii = 1,
        Bidi = 2,
        EastAsia = 3,
        GroupMask = 0xff0000,
        HAnsi = 4,
        Major = 0x10000,
        MajorAscii = 0x10001,
        MajorBidi = 0x10002,
        MajorEastAsia = 0x10003,
        MajorHAnsi = 0x10004,
        Minor = 0x20000,
        MinorAscii = 0x20001,
        MinorBidi = 0x20002,
        MinorEastAsia = 0x20003,
        MinorHAnsi = 0x20004,
        None = 0,
        RegionMask = 0xffff
    }
}

