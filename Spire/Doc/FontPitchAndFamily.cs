namespace Spire.Doc
{
    using System;

    [Flags]
    public enum FontPitchAndFamily : byte
    {
        DEFAULT_PITCH = 0,
        FF_DECORATIVE = 80,
        FF_DONTCARE = 0,
        FF_MODERN = 0x30,
        FF_ROMAN = 0x10,
        FF_SCRIPT = 0x40,
        FF_SWISS = 0x20,
        FIXED_PITCH = 1,
        VARIABLE_PITCH = 2
    }
}

