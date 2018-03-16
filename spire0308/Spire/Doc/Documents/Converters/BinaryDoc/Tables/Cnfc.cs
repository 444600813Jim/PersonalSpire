namespace Spire.Doc.Documents.Converters.BinaryDoc.Tables
{
    using System;

    [Flags]
    internal enum Cnfc
    {
        BandedColumns = 0x10,
        BandedRows = 0x40,
        BottomLeftCell = 0x800,
        BottomRightCell = 0x400,
        EvenColumnBanding = 0x20,
        EvenRowBanding = 0x80,
        FirstColumn = 4,
        FooterRow = 2,
        HeaderRow = 1,
        LastColumn = 8,
        None = 0,
        TopLeftCell = 0x200,
        TopRightCell = 0x100
    }
}

