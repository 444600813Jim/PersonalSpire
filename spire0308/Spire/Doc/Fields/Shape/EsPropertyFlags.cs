namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsPropertyFlags
    {
        BlipId = 0x4000,
        Complex = 0x8000,
        PropIdMask = 0x3fff
    }
}

