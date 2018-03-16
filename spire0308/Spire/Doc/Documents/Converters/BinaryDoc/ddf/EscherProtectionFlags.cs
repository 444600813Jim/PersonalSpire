namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherProtectionFlags
    {
        LockAdjustHandles = 2,
        LockAgainstGrouping = 1,
        LockAgainstSelect = 0x20,
        LockAspectRatio = 0x80,
        LockCropping = 0x10,
        LockPosition = 0x40,
        LockRotation = 0x100,
        LockText = 4,
        LockVertices = 8
    }
}

