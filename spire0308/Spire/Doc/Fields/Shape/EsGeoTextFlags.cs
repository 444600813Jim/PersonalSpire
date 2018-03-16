namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsGeoTextFlags
    {
        BestFit = 0x100,
        Bold = 0x20,
        DxMeasure = 0x40,
        GeoTextOn = 0x4000,
        Italic = 0x10,
        Kerning = 0x1000,
        Normalize = 0x80,
        ReverseRows = 0x8000,
        Shadow = 4,
        ShrinkFit = 0x200,
        SmallCaps = 2,
        Stretch = 0x400,
        StrikeThrough = 1,
        Tight = 0x800,
        Underline = 8,
        Vertical = 0x2000
    }
}

