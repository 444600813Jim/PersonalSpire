namespace Spire.Doc.Documents.Converters.BinaryDoc.Tables
{
    using System;

    [Flags]
    internal enum CellAlign
    {
        All = 0x3f,
        Bottom = 4,
        Box = 15,
        DiagonalDown = 0x10,
        DiagonalUp = 0x20,
        Left = 2,
        None = 0,
        Right = 8,
        Top = 1
    }
}

