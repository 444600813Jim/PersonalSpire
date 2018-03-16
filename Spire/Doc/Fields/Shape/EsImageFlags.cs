namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsImageFlags
    {
        Active = 1,
        BiLevel = 2,
        Gray = 4,
        NoHitTestPicture = 8,
        PreserveGrays = 0x40
    }
}

