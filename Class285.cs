using System;
using System.Drawing;
using System.IO;

internal class Class285 : Class266
{
    private Point point_0;
    private Size size_0;

    internal Class285() : base(EscherRecordType.ShapeGroup, 1)
    {
        this.point_0 = Point.Empty;
        this.size_0 = Size.Empty;
    }

    internal Point method_4()
    {
        return this.point_0;
    }

    internal void method_5(Point A_0)
    {
        this.point_0 = A_0;
    }

    internal Size method_6()
    {
        return this.size_0;
    }

    internal void method_7(Size A_0)
    {
        this.size_0 = A_0;
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        int x = A_0.ReadInt32();
        int y = A_0.ReadInt32();
        int num3 = A_0.ReadInt32();
        int num4 = A_0.ReadInt32();
        this.point_0 = new Point(x, y);
        this.size_0 = new Size(num3 - x, num4 - y);
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.point_0.X);
        A_0.Write(this.point_0.Y);
        A_0.Write((int) (this.point_0.X + this.size_0.Width));
        A_0.Write((int) (this.point_0.Y + this.size_0.Height));
    }
}

