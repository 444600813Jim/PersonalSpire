namespace Spire.Doc.Documents.Converters.BinaryDoc.User
{
    using System;

    [Flags]
    internal enum TBCBSFlags
    {
        Accelerator = 4,
        ButtonDown = 1,
        ButtonMixed = 3,
        ButtonUp = 0,
        CustomBitmap = 8,
        CustomBtnFace = 0x10,
        HyperlinkNone = 0,
        HyperlinkOpenInBrowser = 0x20,
        HyperlinkToImage = 0x40,
        reserved1 = 0x80
    }
}

