namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsProtectionFlags
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

