namespace Spire.Doc
{
    using System;

    public enum FontClipPrecision : byte
    {
        CLIP_CHARACTER_PRECIS = 1,
        CLIP_DEFAULT_PRECIS = 0,
        CLIP_DFA_DISABLE = 0x40,
        CLIP_EMBEDDED = 0x80,
        CLIP_LH_ANGLES = 0x10,
        CLIP_MASK = 15,
        CLIP_STROKE_PRECIS = 2,
        CLIP_TT_ALWAYS = 0x20
    }
}

