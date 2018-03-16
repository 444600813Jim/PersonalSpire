using Spire.Doc.Core.DataStreamParser.Escher;
using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct37
{
    public RectAlignment rectAlignment_0;
    public FlipOrientation flipOrientation_0;
    public float float_0;
    public float float_1;
    public float float_2;
    public float float_3;
    public Struct37(float A_0, float A_1)
    {
        this.rectAlignment_0 = RectAlignment.TopLeft;
        this.flipOrientation_0 = FlipOrientation.None;
        this.float_0 = A_0;
        this.float_1 = A_1;
        this.float_2 = 0f;
        this.float_3 = 0f;
    }
}

