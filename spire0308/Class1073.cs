using Spire.Doc;
using Spire.Layouting;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class1073 : IDisposable
{
    private static Bitmap bitmap_0;
    [ThreadStatic]
    private static Class1073 class1073_0;
    private double[] double_0;
    [ThreadStatic]
    private static Graphics graphics_0;
    internal const int int_0 = 0x60;

    public Class1073() : this(smethod_0())
    {
    }

    public Class1073(Graphics A_0)
    {
        this.method_21(A_0);
    }

    private double[] method_0()
    {
        if (this.double_0 == null)
        {
            this.method_20();
        }
        return this.double_0;
    }

    public double method_1(double A_0, PrintUnits A_1, PrintUnits A_2)
    {
        if (A_1 == A_2)
        {
            return A_0;
        }
        return this.method_8(this.method_3(A_0, A_1), A_2);
    }

    public PointF method_10(PointF A_0, PrintUnits A_1)
    {
        float x = this.method_7(A_0.X, A_1);
        return new PointF(x, this.method_7(A_0.Y, A_1));
    }

    public SizeF method_11(Size A_0, PrintUnits A_1)
    {
        float width = this.method_7((float) A_0.Width, A_1);
        return new SizeF(width, this.method_7((float) A_0.Height, A_1));
    }

    public SizeF method_12(SizeF A_0, PrintUnits A_1)
    {
        float width = this.method_7(A_0.Width, A_1);
        return new SizeF(width, this.method_7(A_0.Height, A_1));
    }

    public float method_13(float A_0, PrintUnits A_1, float A_2)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        double[] numArray = this.method_19(A_2);
        return (float) (A_0 * numArray[(int) A_1]);
    }

    public double method_14(double A_0, PrintUnits A_1, float A_2)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        double[] numArray = this.method_19(A_2);
        return (A_0 * numArray[(int) A_1]);
    }

    public float method_15(float A_0, PrintUnits A_1, float A_2)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        double[] numArray = this.method_19(A_2);
        return (float) (((double) A_0) / numArray[(int) A_1]);
    }

    public double method_16(double A_0, PrintUnits A_1, float A_2)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        double[] numArray = this.method_19(A_2);
        return (A_0 / numArray[(int) A_1]);
    }

    public SizeF method_17(SizeF A_0, PrintUnits A_1, float A_2)
    {
        float width = this.method_15(A_0.Width, A_1, A_2);
        return new SizeF(width, this.method_15(A_0.Height, A_1, A_2));
    }

    public SizeF method_18(SizeF A_0, PrintUnits A_1, float A_2, float A_3)
    {
        float width = this.method_15(A_0.Width, A_1, A_2);
        return new SizeF(width, this.method_15(A_0.Height, A_1, A_3));
    }

    private double[] method_19(float A_0)
    {
        return new double[] { ((double) (A_0 / 75f)), ((double) (A_0 / 300f)), ((double) A_0), ((double) (A_0 / 25.4f)), ((double) (A_0 / 2.54f)), 1.0, ((double) (A_0 / 72f)) };
    }

    public float method_2(float A_0, PrintUnits A_1)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        return (float) (A_0 * this.double_0[(int) A_1]);
    }

    private void method_20()
    {
        double num = 96.0;
        this.double_0 = new double[] { 1.28, 0.32, num, 3.7795276158179276, 37.795276158179277, 1.0, 1.3333333333333333 };
    }

    private void method_21(Graphics A_0)
    {
        int num2 = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刴", num2));
        }
        Point[] pts = new Point[] { new Point(1, 1) };
        GraphicsContainer container = A_0.BeginContainer(new RectangleF(0f, 0f, 1f, 1f), new RectangleF(0f, 0f, 1f, 1f), GraphicsUnit.Pixel);
        A_0.PageUnit = GraphicsUnit.Inch;
        A_0.TransformPoints(CoordinateSpace.Device, CoordinateSpace.Page, pts);
        A_0.EndContainer(container);
        double x = pts[0].X;
        this.double_0 = new double[] { x / 75.0, x / 300.0, x, x / 25.399999618530273, x / 2.5399999618530273, 1.0, x / 72.0 };
    }

    public double method_3(double A_0, PrintUnits A_1)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        return (A_0 * this.double_0[(int) A_1]);
    }

    public RectangleF method_4(RectangleF A_0, PrintUnits A_1)
    {
        float x = this.method_2(A_0.X, A_1);
        float y = this.method_2(A_0.Y, A_1);
        float width = this.method_2(A_0.Width, A_1);
        return new RectangleF(x, y, width, this.method_2(A_0.Height, A_1));
    }

    public PointF method_5(PointF A_0, PrintUnits A_1)
    {
        float x = this.method_2(A_0.X, A_1);
        return new PointF(x, this.method_2(A_0.Y, A_1));
    }

    public SizeF method_6(SizeF A_0, PrintUnits A_1)
    {
        float width = this.method_2(A_0.Width, A_1);
        return new SizeF(width, this.method_2(A_0.Height, A_1));
    }

    public float method_7(float A_0, PrintUnits A_1)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        return (float) (((double) A_0) / this.double_0[(int) A_1]);
    }

    public double method_8(double A_0, PrintUnits A_1)
    {
        if (A_1 == PrintUnits.Pixel)
        {
            return A_0;
        }
        return (A_0 / this.double_0[(int) A_1]);
    }

    public RectangleF method_9(RectangleF A_0, PrintUnits A_1)
    {
        float x = this.method_7(A_0.X, A_1);
        float y = this.method_7(A_0.Y, A_1);
        float width = this.method_7(A_0.Width, A_1);
        return new RectangleF(x, y, width, this.method_7(A_0.Height, A_1));
    }

    public static Graphics smethod_0()
    {
        if (graphics_0 == null)
        {
            bitmap_0 = new Bitmap(1, 1);
            graphics_0 = Graphics.FromImage(bitmap_0);
        }
        return graphics_0;
    }

    public static Class1073 smethod_1()
    {
        if (class1073_0 == null)
        {
            class1073_0 = new Class1073();
        }
        return class1073_0;
    }

    void IDisposable.Dispose()
    {
        if (bitmap_0 != null)
        {
            bitmap_0.Dispose();
            bitmap_0 = null;
        }
        if (graphics_0 != null)
        {
            graphics_0.Dispose();
            graphics_0 = null;
        }
        this.double_0 = null;
        class1073_0 = null;
    }
}

