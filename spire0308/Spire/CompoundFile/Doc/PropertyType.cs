namespace Spire.CompoundFile.Doc
{
    using System;

    [Flags]
    public enum PropertyType
    {
        AsciiString = 30,
        AsciiStringArray = 0x101e,
        Blob = 0x41,
        Bool = 11,
        ClipboardData = 0x47,
        DateTime = 0x40,
        Double = 5,
        Empty = 0,
        Int = 0x16,
        Int16 = 2,
        Int32 = 3,
        Null = 1,
        Object = 12,
        ObjectArray = 0x100c,
        String = 0x1f,
        StringArray = 0x101f,
        UInt32 = 0x13,
        Vector = 0x1000
    }
}

