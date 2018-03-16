namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherInkFlags
    {
        HitTestInk = 4,
        InkAnnotation = 8,
        RenderInk = 1,
        RenderShape = 2,
        UseHitTestInk = 0x40000,
        UseInkAnnotation = 0x80000,
        UseRenderInk = 0x10000,
        UseRenderShape = 0x20000
    }
}

