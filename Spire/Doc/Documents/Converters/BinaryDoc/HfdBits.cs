namespace Spire.Doc.Documents.Converters.BinaryDoc
{
    using System;

    [Flags]
    internal enum HfdBits
    {
        ImageMap = 4,
        Location = 8,
        New = 1,
        NoHist = 2,
        Tooltip = 0x10
    }
}

