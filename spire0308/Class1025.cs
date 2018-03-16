using Spire.Doc.Fields.Shape;
using System;

internal class Class1025
{
    private byte[][] byte_0;
    private byte[] byte_1;
    private byte[][] byte_2;
    private byte[] byte_3;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;

    internal Class1025(int A_0, int A_1, int A_2, int A_3)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
        this.int_2 = A_2;
        this.int_3 = A_3;
        this.byte_0 = new byte[3][];
        this.byte_2 = new byte[3][];
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal float method_1()
    {
        return (((float) this.int_2) / ((float) this.int_1));
    }

    internal float method_2()
    {
        return (((float) this.int_3) / ((float) this.int_1));
    }

    internal void method_3(BorderType A_0, PageBorderArtElementPosition A_1, byte[] A_2)
    {
        switch (A_0)
        {
            case BorderType.Bottom:
                this.byte_2[(int) A_1] = A_2;
                return;

            case BorderType.Left:
                this.byte_3 = A_2;
                return;

            case BorderType.Right:
                this.byte_1 = A_2;
                return;

            case BorderType.Top:
                this.byte_0[(int) A_1] = A_2;
                return;
        }
    }

    internal byte[] method_4(BorderType A_0, PageBorderArtElementPosition A_1)
    {
        switch (A_0)
        {
            case BorderType.Bottom:
                return this.byte_2[(int) A_1];

            case BorderType.Left:
                return this.byte_3;

            case BorderType.Right:
                return this.byte_1;

            case BorderType.Top:
                return this.byte_0[(int) A_1];
        }
        return new byte[0];
    }
}

