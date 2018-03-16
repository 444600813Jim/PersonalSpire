namespace Spire.Doc.Documents.Converters
{
    using System;

    [Flags]
    internal enum TableStyleOptions
    {
        ColumnBands = 0x400,
        Default = 0x2a0,
        Default2003 = 0x600,
        FirstColumn = 0x80,
        FirstRow = 0x20,
        LastColumn = 0x100,
        LastRow = 0x40,
        None = 0,
        RowBands = 0x200
    }
}

