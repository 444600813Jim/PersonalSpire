using Spire.Doc;
using Spire.Layouting;
using System;
using System.Drawing;

internal class Class1013 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private Class1073 class1073_0;
    private Font font_0;
    private Graphics graphics_0;
    private Graphics graphics_1;

    public Class1013()
    {
    }

    public Class1013(Font A_0)
    {
        this.method_9(null, A_0);
    }

    public Class1013(Font A_0, Graphics A_1)
    {
        this.method_9(A_1, A_0);
    }

    internal bool method_0()
    {
        return this.bool_0;
    }

    internal void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public void method_10(Graphics A_0)
    {
        this.graphics_1 = (A_0 == null) ? this.method_8() : A_0;
        this.class1073_0 = new Class1073(this.graphics_1);
    }

    public double method_11()
    {
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        int cellAscent = this.font_0.FontFamily.GetCellAscent(this.font_0.Style);
        double num3 = ((double) (this.font_0.SizeInPoints * cellAscent)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num3, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num3;
        }
        throw new NotImplementedException();
    }

    public double method_12()
    {
        int cellAscent = this.font_0.FontFamily.GetCellAscent(this.font_0.Style);
        int cellDescent = this.font_0.FontFamily.GetCellDescent(this.font_0.Style);
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        int num4 = (cellAscent + cellDescent) - emHeight;
        int num5 = num4 / 2;
        int num6 = num4 - num5;
        int num7 = (int) (0.3 * (cellAscent + cellDescent));
        num7 -= num4;
        num4 = (num7 > 0) ? num7 : 0;
        cellAscent += num5;
        cellDescent += num6;
        double num8 = ((double) (this.font_0.SizeInPoints * cellAscent)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num8, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num8;
        }
        throw new NotImplementedException();
    }

    public double method_13()
    {
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        int cellDescent = this.font_0.FontFamily.GetCellDescent(this.font_0.Style);
        double num3 = ((double) (this.font_0.SizeInPoints * cellDescent)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num3, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num3;
        }
        throw new NotImplementedException();
    }

    public double method_14()
    {
        int cellAscent = this.font_0.FontFamily.GetCellAscent(this.font_0.Style);
        int cellDescent = this.font_0.FontFamily.GetCellDescent(this.font_0.Style);
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        int num4 = (cellAscent + cellDescent) - emHeight;
        int num5 = num4 / 2;
        int num6 = num4 - num5;
        int num7 = (int) (0.3 * (cellAscent + cellDescent));
        num7 -= num4;
        num4 = (num7 > 0) ? num7 : 0;
        cellAscent += num5;
        cellDescent += num6;
        double num8 = ((double) (this.font_0.SizeInPoints * cellDescent)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num8, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num8;
        }
        throw new NotImplementedException();
    }

    public double method_15()
    {
        if (this.method_0())
        {
            return this.method_16();
        }
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        int lineSpacing = this.font_0.FontFamily.GetLineSpacing(this.font_0.Style);
        double num3 = ((double) (this.font_0.SizeInPoints * lineSpacing)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num3, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num3;
        }
        throw new NotImplementedException();
    }

    public double method_16()
    {
        int cellAscent = this.font_0.FontFamily.GetCellAscent(this.font_0.Style);
        int cellDescent = this.font_0.FontFamily.GetCellDescent(this.font_0.Style);
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        int lineSpacing = this.font_0.FontFamily.GetLineSpacing(this.font_0.Style);
        int num5 = (cellAscent + cellDescent) - emHeight;
        int num6 = num5 / 2;
        int num7 = num5 - num6;
        int num8 = (int) (0.3 * (cellAscent + cellDescent));
        num8 -= num5;
        num5 = (num8 > 0) ? num8 : 0;
        cellAscent += num6;
        cellDescent += num7;
        lineSpacing = (cellAscent + cellDescent) + num5;
        double num9 = ((double) (this.font_0.SizeInPoints * lineSpacing)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num9, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num9;
        }
        throw new NotImplementedException();
    }

    internal bool method_2()
    {
        return this.bool_1;
    }

    internal void method_3(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public double method_4()
    {
        return this.method_11();
    }

    public double method_5()
    {
        return this.method_13();
    }

    public double method_6()
    {
        return this.method_15();
    }

    public double method_7()
    {
        int emHeight = this.font_0.FontFamily.GetEmHeight(this.font_0.Style);
        double num2 = ((double) (this.font_0.SizeInPoints * emHeight)) / ((double) emHeight);
        switch (this.graphics_1.PageUnit)
        {
            case GraphicsUnit.Pixel:
                return this.class1073_0.method_3(num2, PrintUnits.Point);

            case GraphicsUnit.Point:
                return num2;
        }
        throw new NotImplementedException();
    }

    protected Graphics method_8()
    {
        if (this.graphics_0 == null)
        {
            Bitmap image = new Bitmap(1, 1);
            this.graphics_0 = Graphics.FromImage(image);
        }
        return this.graphics_0;
    }

    public void method_9(Graphics A_0, Font A_1)
    {
        int num = 10;
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嘯崱娳䈵", num));
        }
        this.font_0 = A_1;
        this.method_10(A_0);
    }

    void IDisposable.Dispose()
    {
        if (this.graphics_0 != null)
        {
            this.graphics_0.Dispose();
            this.graphics_0 = null;
        }
        if (this.graphics_1 != null)
        {
            this.graphics_1.Dispose();
            this.graphics_1 = null;
        }
        if (this.font_0 != null)
        {
            this.font_0 = null;
        }
        if (this.class1073_0 != null)
        {
            this.class1073_0.System.IDisposable.Dispose();
            this.class1073_0 = null;
        }
    }
}

