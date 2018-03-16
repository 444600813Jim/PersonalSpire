namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherThreeDStyleFlags
    {
        ConstrainRotation = 0x10,
        FillHarsh = 1,
        KeyHarsh = 2,
        Parallel = 4,
        RotationCenterAuto = 8
    }
}

