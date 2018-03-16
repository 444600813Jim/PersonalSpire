using Spire.Doc.Fields.Shape;
using System;

internal class Class72
{
    private readonly HandlePositionType handlePositionType_0;
    private readonly int int_0;

    internal Class72() : this(HandlePositionType.Unknown, 0)
    {
    }

    internal Class72(int A_0)
    {
        this.int_0 = 0;
        switch (A_0)
        {
            case 0:
                this.handlePositionType_0 = HandlePositionType.LeftTop;
                return;

            case 1:
                this.handlePositionType_0 = HandlePositionType.RightBottom;
                return;

            case 2:
                this.handlePositionType_0 = HandlePositionType.Center;
                return;
        }
        if ((A_0 >= 3) && (A_0 <= 0x84))
        {
            this.handlePositionType_0 = HandlePositionType.Formula;
            this.int_0 = A_0 - 3;
        }
        else
        {
            this.handlePositionType_0 = HandlePositionType.Adjust;
            this.int_0 = A_0 - 0x100;
        }
    }

    internal Class72(HandlePositionType A_0, int A_1)
    {
        this.handlePositionType_0 = A_0;
        this.int_0 = A_1;
    }

    internal int method_0()
    {
        switch (this.handlePositionType_0)
        {
            case HandlePositionType.LeftTop:
                return 0;

            case HandlePositionType.RightBottom:
                return 1;

            case HandlePositionType.Center:
                return 2;

            case HandlePositionType.Formula:
                return (3 + this.int_0);

            case HandlePositionType.Adjust:
                return (0x100 + this.int_0);
        }
        return this.int_0;
    }

    internal HandlePositionType method_1()
    {
        return this.handlePositionType_0;
    }

    internal int method_2()
    {
        return this.int_0;
    }
}

