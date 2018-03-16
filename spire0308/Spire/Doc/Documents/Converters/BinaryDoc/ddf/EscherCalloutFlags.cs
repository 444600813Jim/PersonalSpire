namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherCalloutFlags
    {
        AccentBar = 0x20,
        CalloutOn = 0x40,
        DropAuto = 2,
        LengthSpecified = 1,
        MinusX = 8,
        MinusY = 4,
        TextBorder = 0x10
    }
}

