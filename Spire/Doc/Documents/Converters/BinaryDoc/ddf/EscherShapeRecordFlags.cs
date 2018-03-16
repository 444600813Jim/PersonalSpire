namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherShapeRecordFlags
    {
        Background = 0x400,
        Child = 2,
        Connector = 0x100,
        Deleted = 8,
        FlipH = 0x40,
        FlipV = 0x80,
        Group = 1,
        HasAnchor = 0x200,
        HasMaster = 0x20,
        HasSpt = 0x800,
        OleShape = 0x10,
        Patriarch = 4
    }
}

