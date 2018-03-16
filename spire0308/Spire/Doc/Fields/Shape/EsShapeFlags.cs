namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsShapeFlags
    {
        Background = 1,
        DeleteAttachedObject = 2,
        FlipHOverride = 0x80,
        FlipVOverride = 0x40,
        Initiator = 4,
        LockShapeType = 8,
        OleIcon = 0x20,
        PolicyBarcode = 0x100,
        PolicyLabel = 0x200,
        PreferRelativeResize = 0x10,
        UseBackground = 0x10000,
        UseFlipHOverride = 0x800000,
        UseFlipVOverride = 0x400000,
        UseInitiator = 0x40000,
        UseLockShapeType = 0x80000,
        UseOleIcon = 0x200000,
        UsePolicyBarcode = 0x1000000,
        UsePolicyLabel = 0x2000000,
        UsePreferRelativeResize = 0x100000
    }
}

