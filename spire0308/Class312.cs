using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class312 : IDisposable, IComparable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private Class311 class311_0 = new Class311();
    private Interface1 interface1_0;
    private List<PointF> list_0;
    private RectangleF rectangleF_0 = new RectangleF();
    private RectangleF[] rectangleF_1;
    private Region region_0;
    private TableCell tableCell_0;

    public RectangleF method_0()
    {
        return this.rectangleF_0;
    }

    public void method_1(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }

    public List<PointF> method_10()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<PointF>();
        }
        return this.list_0;
    }

    public void method_11(List<PointF> A_0)
    {
        this.list_0 = A_0;
    }

    public RectangleF[] method_12()
    {
        return this.rectangleF_1;
    }

    public void method_13(RectangleF[] A_0)
    {
        this.rectangleF_1 = A_0;
    }

    public bool method_14()
    {
        return this.bool_4;
    }

    public void method_15(bool A_0)
    {
        this.bool_4 = A_0;
    }

    public bool method_16()
    {
        return this.bool_0;
    }

    public void method_17(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public bool method_18()
    {
        return this.bool_1;
    }

    public void method_19(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public Class311 method_2()
    {
        return this.class311_0;
    }

    public bool method_20()
    {
        return this.bool_2;
    }

    public void method_21(bool A_0)
    {
        this.bool_2 = A_0;
    }

    public bool method_22()
    {
        return this.bool_3;
    }

    public void method_23(bool A_0)
    {
        this.bool_3 = A_0;
    }

    public float method_24()
    {
        if (float.IsNaN(this.rectangleF_0.X))
        {
            return 0f;
        }
        return this.rectangleF_0.X;
    }

    private Region method_25()
    {
        List<PointF> list = new List<PointF> {
            new PointF(0f, 0f),
            new PointF(0f, this.rectangleF_0.Height),
            new PointF(this.rectangleF_0.Width, this.rectangleF_0.Height),
            new PointF(this.rectangleF_0.Width, 0f),
            new PointF(0f, 0f)
        };
        Region region = this.method_26(list, this.rectangleF_0, false);
        List<PointF> list2 = ((this.list_0 == null) || (this.list_0.Count <= 3)) ? new List<PointF>() : this.list_0;
        Region region2 = this.method_26(list2, this.rectangleF_0, true);
        if ((region != null) && (region2 != null))
        {
            region2.Intersect(region);
            return region2;
        }
        if ((region != null) && (region2 == null))
        {
            return region;
        }
        if ((region == null) && (region2 != null))
        {
            return region2;
        }
        return null;
    }

    private Region method_26(List<PointF> A_0, RectangleF A_1, bool A_2)
    {
        if (A_0.Count <= 3)
        {
            return null;
        }
        RectangleF ef = A_1;
        if (A_1.X < 0f)
        {
            ef = new RectangleF(0f, A_1.Y, A_1.Width + Math.Abs(A_1.X), A_1.Height);
        }
        if (A_1.Y < 0f)
        {
            ef = new RectangleF(ef.X, 0f, ef.Width, ef.Height + Math.Abs(ef.Y));
        }
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddPolygon(A_0.ToArray());
            Region region = new Region(path);
            using (Bitmap bitmap = new Bitmap(1, 1))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    RectangleF bounds = region.GetBounds(graphics);
                    if (!bounds.IsEmpty)
                    {
                        float x = bounds.X;
                        float y = bounds.Y;
                        region.Transform(new Matrix(1f, 0f, 0f, 1f, -x, -y));
                        double num3 = Math.Round((double) (bounds.X / 807f), 2);
                        double num4 = Math.Round((double) (bounds.Y / 807f), 2);
                        double num5 = Math.Round((double) (bounds.Width / 807f), 2);
                        double num6 = Math.Round((double) (bounds.Height / 807f), 2);
                        double num7 = (ef.Width * num3) + A_1.X;
                        double num8 = (ef.Height * num4) + A_1.Y;
                        double num9 = ef.Width * num5;
                        double num10 = ef.Height * num6;
                        if (A_2)
                        {
                            double num11 = Math.Round((double) (num9 / ((double) bounds.Width)), 2);
                            double num12 = Math.Round((double) (num10 / ((double) bounds.Height)), 2);
                            region.Transform(new Matrix((float) num11, 0f, 0f, (float) num12, 0f, 0f));
                        }
                        region.Transform(new Matrix(1f, 0f, 0f, 1f, (float) num7, (float) num8));
                    }
                }
            }
            return region;
        }
    }

    public void method_3(Class311 A_0)
    {
        this.class311_0 = A_0;
    }

    public Interface1 method_4()
    {
        return this.interface1_0;
    }

    public void method_5(Interface1 A_0)
    {
        this.interface1_0 = A_0;
    }

    public TableCell method_6()
    {
        return this.tableCell_0;
    }

    public void method_7(TableCell A_0)
    {
        this.tableCell_0 = A_0;
    }

    public Region method_8()
    {
        if (this.region_0 == null)
        {
            this.region_0 = this.method_25();
        }
        return this.region_0;
    }

    internal void method_9(Region A_0)
    {
        this.region_0 = A_0;
    }

    int IComparable.CompareTo(object A_0)
    {
        int num = 0x12;
        if (!(A_0 is Class312))
        {
            throw new NotImplementedException(BookmarkStart.b("眷堹嘻ḽ⤿ㅁ摃⡅❇㹉汋⽍灏ő㱓㝕⡗㽙ṛㅝᕟౡcᕥ⥧ѩ࡫㩭ᕯੱsⅵ੷᭹౻๽ꞅ", num));
        }
        Class312 class2 = A_0 as Class312;
        if ((this.method_0().IsEmpty || class2.method_0().IsEmpty) || (this.method_24() < class2.method_24()))
        {
            return -1;
        }
        return this.method_24().CompareTo(class2.method_24());
    }

    void IDisposable.Dispose()
    {
        this.class311_0 = null;
        this.interface1_0 = null;
        this.tableCell_0 = null;
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.region_0 != null)
        {
            this.region_0.Dispose();
            this.region_0 = null;
        }
        if ((this.rectangleF_1 != null) && (this.rectangleF_1.Length > 0))
        {
            this.rectangleF_1 = null;
        }
    }

    bool object.Equals(object A_0)
    {
        return (((((A_0 != null) && (A_0 is Class312)) && ((A_0 as Class312).method_2().Equals(this.method_2()) && ((A_0 as Class312).method_0() == this.method_0()))) && ((((A_0 as Class312).method_16() == this.method_16()) && ((A_0 as Class312).method_18() == this.method_18())) && (((A_0 as Class312).method_20() == this.method_20()) && ((A_0 as Class312).method_22() == this.method_22())))) && ((A_0 as Class312).method_6() == this.method_6()));
    }

    int object.GetHashCode()
    {
        return base.GetHashCode();
    }
}

