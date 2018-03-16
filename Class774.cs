using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;

internal class Class774
{
    private bool bool_0;
    private Interface22 interface22_0;
    private RectangleF rectangleF_0;
    private RectangleF rectangleF_1;
    private RectangleF rectangleF_2;

    public Class774() : this(new RectangleF(), (Interface22) null, (Interface1) null)
    {
    }

    public Class774(RectangleF A_0) : this(A_0, (Interface22) null, (Interface1) null)
    {
    }

    public Class774(RectangleF A_0, Interface22 A_1)
    {
        this.bool_0 = true;
        this.rectangleF_0 = A_0;
        this.interface22_0 = A_1;
        this.method_23();
    }

    public Class774(RectangleF A_0, bool A_1) : this(A_0, null, null, A_1)
    {
    }

    public Class774(RectangleF A_0, Interface22 A_1, Interface1 A_2)
    {
        this.bool_0 = true;
        this.rectangleF_0 = A_0;
        this.interface22_0 = A_1;
        this.method_22(A_2);
    }

    public Class774(RectangleF A_0, RectangleF A_1, Interface22 A_2)
    {
        this.bool_0 = true;
        this.rectangleF_0 = A_1;
        this.interface22_0 = A_2;
        this.rectangleF_1 = A_1;
        this.method_1(A_0);
    }

    public Class774(RectangleF A_0, Interface22 A_1, Interface1 A_2, bool A_3)
    {
        this.bool_0 = true;
        this.rectangleF_0 = A_0;
        this.interface22_0 = A_1;
        this.method_21(A_2, A_3);
    }

    public RectangleF method_0()
    {
        return this.rectangleF_2;
    }

    public void method_1(RectangleF A_0)
    {
        this.rectangleF_2 = A_0;
    }

    public RectangleF method_10()
    {
        return this.rectangleF_0;
    }

    public RectangleF method_11()
    {
        return this.rectangleF_1;
    }

    internal void method_12(RectangleF A_0)
    {
        this.rectangleF_1 = A_0;
    }

    public RectangleF method_13()
    {
        return this.method_0();
    }

    internal void method_14(RectangleF A_0)
    {
        this.method_1(A_0);
    }

    public void method_15(double A_0)
    {
        int num = 1;
        if ((A_0 < this.method_0().Left) || (A_0 > this.method_0().Right))
        {
            if (!this.method_6())
            {
                throw new ArgumentException(BookmarkStart.b("弦", num));
            }
            if (A_0 < this.method_0().Left)
            {
                A_0 = this.method_0().Left;
            }
            else if (A_0 > this.method_0().Right)
            {
                A_0 = this.method_0().Right;
            }
        }
        RectangleF ef7 = this.method_0();
        ef7.Width = ef7.Right - ((float) A_0);
        ef7.X = (float) A_0;
        this.method_1(ef7);
    }

    internal void method_16(double A_0)
    {
        RectangleF ef = this.method_0();
        ef.Width = ((ef.Right - A_0) < 0.0) ? 0f : (ef.Right - ((float) A_0));
        ef.X = (float) A_0;
        this.method_1(ef);
    }

    internal void method_17()
    {
        this.rectangleF_2 = this.rectangleF_1;
    }

    public void method_18(double A_0)
    {
        int num = 11;
        if ((A_0 > this.method_0().Bottom) || (A_0 < this.method_0().Top))
        {
            if (!this.method_6())
            {
                throw new ArgumentException(BookmarkStart.b("䠰", num));
            }
            if (A_0 < this.method_0().Top)
            {
                A_0 = this.method_0().Top + 0.1f;
            }
            else if (A_0 > this.method_0().Bottom)
            {
                A_0 = this.method_0().Bottom;
            }
        }
        RectangleF ef7 = this.method_0();
        ef7.Height = ef7.Bottom - ((float) A_0);
        ef7.Y = (float) A_0;
        this.method_1(ef7);
    }

    public void method_19()
    {
        this.method_18((double) this.method_13().Bottom);
    }

    public double method_2()
    {
        return (double) this.method_10().Width;
    }

    public bool method_20(SizeF A_0)
    {
        return ((Class59.smethod_2((double) A_0.Width, (double) this.method_0().Width) <= 0) && (Class59.smethod_1((double) A_0.Height, (double) this.method_0().Height, false) <= 0));
    }

    private void method_21(Interface1 A_0, bool A_1)
    {
        RectangleF ef = this.rectangleF_0;
        double x = this.rectangleF_0.X;
        double y = this.rectangleF_0.Y;
        double width = this.rectangleF_0.Width;
        double height = this.rectangleF_0.Height;
        if (A_0 != null)
        {
            double num5 = 0.0;
            double num6 = 0.0;
            double num7 = 0.0;
            double num8 = 0.0;
            if (this.interface22_0 != null)
            {
                num5 = this.method_8().method_0() + this.method_9().method_0();
                num6 = this.method_8().method_4() + this.method_9().method_4();
                num7 = this.method_8().method_8() + this.method_9().method_8();
                num8 = this.method_9().method_12();
            }
            if (x < 0.0)
            {
                x = this.rectangleF_0.X;
            }
            if (((A_0 != null) && (A_0 is TableCell)) && A_0.imethod_0().imethod_30())
            {
                x = this.rectangleF_0.X + num6;
                y = this.rectangleF_0.Y + num5;
                width = (this.rectangleF_0.Width - num6) - num8;
                height = (this.rectangleF_0.Height - num5) - num7;
            }
            else
            {
                x = this.rectangleF_0.X + num5;
                y = this.rectangleF_0.Y + num6;
                width = (this.rectangleF_0.Width - num5) - num7;
                height = (this.rectangleF_0.Height - num6) - num8;
            }
            if ((A_0 is TableCell) || ((A_0 is Class65) && ((A_0 as Class65).method_2() is TableCell)))
            {
                TableCell cell = (A_0 is TableCell) ? (A_0 as TableCell) : ((!(A_0 is Class65) || !((A_0 as Class65).method_2() is TableCell)) ? null : ((A_0 as Class65).method_2() as TableCell));
                if ((cell != null) && (cell.OwnerRow.OwnerTable.TableFormat.CellSpacing > 0f))
                {
                    width += cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
                }
            }
            if (((A_0 is Paragraph) && (A_0 as Paragraph).IsInCell) && !(((A_0 as Paragraph).OwnerTextBody as TableCell).interface23_0 as Class211).method_107())
            {
                height -= this.method_8().method_12();
            }
            if (width < 0.0)
            {
                width = 0.0;
            }
            if (height < 0.0)
            {
                height = 0.0;
            }
            if (A_0 is Paragraph)
            {
                Class210 class2 = A_0.imethod_0() as Class210;
                RectangleF ef2 = class2.method_87();
                if (!ef2.IsEmpty || (ef2.Right > 0f))
                {
                    float num9 = ef2.Right - ((float) x);
                    x += num9;
                    width = class2.method_89() - ef2.Right;
                    width = (width < 0.0) ? 0.0 : width;
                }
            }
        }
        if (!A_1)
        {
            this.rectangleF_1 = new RectangleF(new PointF((float) x, ef.Y), new SizeF((float) width, ef.Height));
        }
        else
        {
            this.rectangleF_1 = new RectangleF((float) x, (float) y, (float) width, (float) height);
        }
        this.method_1(this.rectangleF_1);
        if ((A_0 is Paragraph) || ((A_0 is Class65) && ((A_0 as Class65).method_2() is Paragraph)))
        {
            (A_0.imethod_0() as Class210).method_86(this.rectangleF_1);
        }
    }

    private void method_22(Interface1 A_0)
    {
        this.method_21(A_0, true);
    }

    private void method_23()
    {
        this.method_22(null);
    }

    public double method_3()
    {
        return (double) this.method_10().Height;
    }

    public double method_4()
    {
        return (double) this.method_11().Width;
    }

    public double method_5()
    {
        return (double) this.method_11().Height;
    }

    public bool method_6()
    {
        return this.bool_0;
    }

    public void method_7(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public Class372 method_8()
    {
        return this.interface22_0.imethod_1();
    }

    public Class372 method_9()
    {
        return this.interface22_0.imethod_0();
    }
}

