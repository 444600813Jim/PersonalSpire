namespace Spire.Doc.Core.DataStreamParser.Escher
{
    using System;

    internal enum FOPTEProtection
    {
        fLockAdjustHandles = 0x7e,
        fLockAgainstGrouping = 0x7f,
        fLockAgainstSelect = 0x7a,
        fLockAspectRatio = 120,
        fLockCropping = 0x7b,
        fLockPosition = 0x79,
        fLockRotation = 0x13,
        fLockText = 0x7d,
        fLockVertices = 0x7c
    }
}

