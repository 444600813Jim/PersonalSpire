namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsThreeDStyleFlags
    {
        ConstrainRotation = 0x10,
        FillHarsh = 1,
        KeyHarsh = 2,
        Parallel = 4,
        RotationCenterAuto = 8
    }
}

