using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

internal class Class618 : Class615
{
    private bool bool_10;
    private bool bool_6;
    protected bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private Class375 class375_1;
    private Class375 class375_2;
    private Class616 class616_0;
    private Class65[] class65_0;
    private Class820 class820_0;
    private Dictionary<Interface1, Class375> dictionary_0;
    private double[] double_0;
    private double[] double_1;
    private double[] double_2;
    private const float float_0 = 16f;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int[] int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private LayoutState layoutState_1;
    private RectangleF rectangleF_0;
    private RectangleF rectangleF_1;
    private Stack stack_0;
    private Stack stack_1;
    private Stack stack_2;
    private Stack stack_3;
    private const string string_0 = "W";
    private Table table_0;

    internal Class618() : base(null, null)
    {
        Image image;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.rectangleF_0 = new RectangleF();
        this.rectangleF_1 = new RectangleF();
        this.stack_0 = new Stack();
        this.stack_1 = new Stack();
        this.stack_2 = new Stack();
        this.stack_3 = new Stack();
        Bitmap bitmap = new Bitmap(1, 1);
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            image = new Metafile(new MemoryStream(), graphics.GetHdc(), new RectangleF(0f, 0f, 1f, 1f), MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
        }
        Class196 class2 = new Class196(Graphics.FromImage(image), GraphicsUnit.Point, new SizeF());
        base.bool_5 = true;
        base.class196_0 = class2;
    }

    public Class618(Class820 A_0, Interface30 A_1) : base(A_0.method_0(), A_1)
    {
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.rectangleF_0 = new RectangleF();
        this.rectangleF_1 = new RectangleF();
        this.stack_0 = new Stack();
        this.stack_1 = new Stack();
        this.stack_2 = new Stack();
        this.stack_3 = new Stack();
        this.bool_6 = true;
        this.int_2 = A_0.method_1() - 1;
        this.class820_0 = A_0;
        this.bool_8 = true;
    }

    public Class618(Interface4 A_0, Interface30 A_1) : base(A_0, A_1)
    {
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.rectangleF_0 = new RectangleF();
        this.rectangleF_1 = new RectangleF();
        this.stack_0 = new Stack();
        this.stack_1 = new Stack();
        this.stack_2 = new Stack();
        this.stack_3 = new Stack();
    }

    private void method_100(Class615 A_0)
    {
        if (A_0.method_9())
        {
            Class211 class2 = this.class375_1.method_73().imethod_0() as Class211;
            if (class2.method_107())
            {
                if (this.class375_2.method_69().Height == 0f)
                {
                    RectangleF ef = this.class375_2.method_69();
                    ef.Height = (float) Math.Abs(class2.method_121());
                    this.class375_2.method_70(ef);
                }
                this.method_101(A_0);
            }
            else
            {
                base.layoutState_0 = LayoutState.NotFitted;
            }
        }
        else if (this.method_34() < (this.method_33().imethod_5() - 1))
        {
            this.method_99(A_0);
            base.layoutState_0 = LayoutState.NotFitted;
        }
        else
        {
            base.layoutState_0 = LayoutState.NotFitted;
        }
    }

    private void method_101(Class615 A_0)
    {
        if (!(this.class375_1.method_73().imethod_0() as Class211).method_107())
        {
            this.class65_0[this.int_3] = (A_0.method_0() is Class65) ? (A_0.method_0() as Class65) : new Class65(A_0.method_8() as Interface3);
            (this.class65_0[this.int_3].Interface1.imethod_0() as Class211).method_110(true);
        }
        this.class375_1.method_74().method_7(this.class375_2);
        this.class375_1.method_31(this.class375_2.method_30());
        Class211 class2 = this.class375_2.method_73().imethod_0() as Class211;
        if (!class2.method_111())
        {
            if (!class2.method_113())
            {
                this.method_58(A_0);
            }
            goto Label_0251;
        }
        if ((this.class375_2.method_73() is TableCell) || ((this.class375_2.method_73() is Class65) && ((this.class375_2.method_73() as Class65).method_2() is TableCell)))
        {
            TableCell cell = (this.class375_2.method_73() is Class65) ? ((this.class375_2.method_73() as Class65).method_2() as TableCell) : (this.class375_2.method_73() as TableCell);
            switch (cell.CellFormat.TextDirection)
            {
                case TextDirection.RightToLeft:
                case TextDirection.LeftToRightRotated:
                case TextDirection.LeftToRight:
                case TextDirection.RightToLeftRotated:
                    this.double_2[this.int_3] = ((this.class375_2.method_69().Width + class2.Interface22.imethod_1().method_12()) + class2.Interface22.imethod_0().method_12()) + class2.Interface22.imethod_0().method_4();
                    goto Label_0201;
            }
            this.double_2[this.int_3] = ((this.class375_2.method_69().Height + class2.Interface22.imethod_1().method_12()) + class2.Interface22.imethod_0().method_12()) + class2.Interface22.imethod_0().method_4();
        }
    Label_0201:
        if (this.class820_0 != null)
        {
            this.int_4[this.int_3] = this.method_34() - (this.class820_0.method_1() - 1);
        }
        else
        {
            this.int_4[this.int_3] = this.method_34();
        }
    Label_0251:
        this.bool_7 = true;
    }

    private void method_102()
    {
        base.class774_0.method_18((double) this.class375_1.method_69().Bottom);
    }

    private Class774 method_103(bool A_0, int A_1, int A_2)
    {
        double num11;
        RectangleF ef = base.class774_0.method_13();
        float num = 0f;
        float layoutWidth = this.table_0.LayoutWidth;
        double num3 = this.method_105(A_1, A_2);
        for (int i = 0; i < A_2; i++)
        {
            TableCell cell1 = this.table_0.Rows[A_1].Cells[i];
            num += this.method_105(A_1, i);
        }
        if (num == 0f)
        {
            num11 = ef.X + this.double_1[A_2];
        }
        else
        {
            num11 = num + ef.X;
            if (this.table_0.Rows[A_1].Cells.Count == (A_2 + 1))
            {
                if (this.table_0.LayoutWidth < (Convert.ToSingle(num11) + Convert.ToSingle(num3)))
                {
                    float num6 = Convert.ToSingle((double) (layoutWidth - (num + num3)));
                    if (num6 < 0f)
                    {
                        num3 += num6;
                    }
                }
                if (this.table_0.LayoutWidth > (Convert.ToSingle(num11) + Convert.ToSingle(num3)))
                {
                    float num10 = Convert.ToSingle((double) (layoutWidth - (num + num3)));
                    if ((num3 > num10) && (num10 < 0f))
                    {
                        num3 -= num10;
                    }
                }
            }
        }
        double y = ef.Y;
        double height = ef.Height;
        if (A_0)
        {
            if (this.table_0.Rows[A_1].Cells[A_2].CellFormat.HorizontalMerge != CellMerge.Start)
            {
                num3 = this.method_105(A_1, A_2);
            }
            else if (this.table_0.Rows[A_1].Cells.Count == (A_2 + 1))
            {
                float num12 = 0f;
                for (int j = 0; j < A_2; j++)
                {
                    num12 += this.method_105(A_1, j);
                }
                num3 = ((base.class774_0.method_13().Width - num12) + this.table_0.Rows[A_1].RowFormat.Paddings.Left) + this.table_0.Rows[A_1].RowFormat.Paddings.Right;
                this.table_0.Rows[A_1].Cells[A_2].LayoutWidth = Convert.ToSingle(num3);
            }
            else if (this.table_0.Rows[A_1].Cells[A_2 + 1].CellFormat.HorizontalMerge != CellMerge.Continue)
            {
                num3 = this.method_105(A_1, A_2);
            }
            else
            {
                int num9 = A_2;
                float num15 = 0f;
                while ((num9 + 1) < this.table_0.Rows[A_1].Cells.Count)
                {
                    if (this.table_0.Rows[A_1].Cells[num9 + 1].CellFormat.HorizontalMerge != CellMerge.Continue)
                    {
                        break;
                    }
                    num15 += this.method_105(A_1, num9);
                    num9++;
                }
                if ((this.table_0.Rows[A_1].Cells.Count > num9) && (this.table_0.Rows[A_1].Cells[num9].CellFormat.HorizontalMerge == CellMerge.Continue))
                {
                    num15 += this.method_105(A_1, num9);
                }
                num3 = num15;
            }
        }
        Class211 class2 = this.class375_1.method_73().imethod_0() as Class211;
        if (class2.method_107())
        {
            height = class2.method_121();
        }
        else if (height < class2.method_121())
        {
            if (base.class774_0.method_11().Height == base.class774_0.method_13().Height)
            {
                height = class2.method_121();
            }
            else
            {
                int num17 = (base.class375_0 != null) ? base.class375_0.method_74().Count : 0;
                if ((num17 <= 0) || ((num17 > 0) && ((num17 - this.int_0) > 0)))
                {
                    height = 0.0;
                }
            }
        }
        if (this.table_0.Rows[A_1].Cells[A_2] != null)
        {
            switch (this.table_0.Rows[A_1].Cells[A_2].CellFormat.TextDirection)
            {
                case TextDirection.RightToLeft:
                case TextDirection.LeftToRightRotated:
                case TextDirection.LeftToRight:
                case TextDirection.RightToLeftRotated:
                {
                    float num14 = this.table_0.Rows[this.method_34()].Height;
                    float right = this.table_0.TableFormat.Paddings.Right;
                    float left = this.table_0.TableFormat.Paddings.Left;
                    if (this.table_0.Rows[A_1].Cells[A_2].CellFormat.VerticalMerge == CellMerge.Start)
                    {
                        for (int k = A_1 + 1; k < this.table_0.Rows.Count; k++)
                        {
                            int count = this.table_0.Rows[k].Cells.Count;
                            if ((A_2 >= count) || (this.table_0.Rows[k].Cells[A_2].CellFormat.VerticalMerge != CellMerge.Continue))
                            {
                                break;
                            }
                            num14 += this.table_0.Rows[k].Height;
                        }
                    }
                    if (num14 == 0f)
                    {
                        num14 = (float) height;
                        height = num3;
                    }
                    num3 = num14;
                    break;
                }
            }
        }
        return new Class774(new RectangleF((float) num11, (float) y, (float) num3, (float) height));
    }

    private float method_104(TableRow A_0)
    {
        if (A_0 == null)
        {
            return 0f;
        }
        float height = A_0.Height;
        if ((((A_0.HeightType == TableRowHeightType.Exactly) && (A_0.Owner is Table)) && ((A_0.Owner as Table).IsFrame && ((A_0.Owner as Table).FrameFormat.FrameHeightRule == FrameSizeRule.Exact))) && ((A_0.Owner as Table).FrameFormat.FrameHeight != 0))
        {
            ushort frameHeight = (ushort) (A_0.Owner as Table).FrameFormat.FrameHeight;
            float num2 = ((float) (frameHeight & 0x7fff)) / 20f;
            if (A_0.Height > num2)
            {
                height = num2;
            }
        }
        return height;
    }

    private float method_105(int A_0, int A_1)
    {
        TableCell cell = this.table_0.Rows[A_0].Cells[A_1];
        bool flag = false;
        if ((cell.CellFormat.HorizontalMerge == CellMerge.Continue) && (A_1 > 0))
        {
            TableCell cell2 = this.table_0.Rows[A_0].Cells[A_1 - 1];
            if ((cell2 != null) && (cell2.CellFormat.HorizontalMerge != CellMerge.None))
            {
                flag = true;
            }
        }
        float layoutWidth = cell.LayoutWidth;
        if ((layoutWidth == 0f) && !flag)
        {
            layoutWidth = (float) (((((Interface1) this.table_0.Rows[A_0].Cells[A_1]).imethod_0().imethod_0().method_0() + ((Interface1) this.table_0.Rows[A_0].Cells[A_1]).imethod_0().imethod_0().method_8()) + ((Interface1) this.table_0.Rows[A_0].Cells[A_1]).imethod_0().imethod_1().method_0()) + ((Interface1) this.table_0.Rows[A_0].Cells[A_1]).imethod_0().imethod_1().method_8());
        }
        if ((cell.CellFormat.VerticalMerge == CellMerge.Continue) && (layoutWidth == 0f))
        {
            while (A_0 >= 0)
            {
                if (this.table_0.Rows[A_0].Cells.Count > A_1)
                {
                    cell = this.table_0.Rows[A_0].Cells[A_1];
                    if ((cell.CellFormat.VerticalMerge == CellMerge.Start) || (cell.CellFormat.VerticalMerge == CellMerge.None))
                    {
                        break;
                    }
                }
                A_0--;
            }
            if ((cell.CellFormat.VerticalMerge == CellMerge.Start) && (cell.LayoutWidth != layoutWidth))
            {
                layoutWidth = cell.LayoutWidth;
            }
        }
        return layoutWidth;
    }

    private double method_106(int A_0, int A_1)
    {
        if ((this.table_0.Rows[0].method_23() + 1) > this.table_0.TableGrid.Count)
        {
            return 0.0;
        }
        double num = 0.0;
        int num2 = 0;
        if (this.int_3 > 0)
        {
            for (int i = 0; i < A_1; i++)
            {
                num2 += this.table_0.Rows[A_0].Cells[i].GridSpanEx;
            }
        }
        else
        {
            num2 = this.int_3;
        }
        num2 = (num2 < 0) ? 0 : num2;
        int num5 = ((num2 + this.table_0.Rows[A_0].Cells[A_1].GridSpanEx) >= this.table_0.TableGrid.Count) ? (this.table_0.TableGrid.Count - 1) : (num2 + this.table_0.Rows[A_0].Cells[A_1].GridSpanEx);
        int num4 = ((num2 - 1) < 0) ? 0 : num2;
        if ((num4 <= num5) && (num5 < this.table_0.TableGrid.Count))
        {
            num = (this.table_0.TableGrid[num5] - this.table_0.TableGrid[num4]) / 20f;
        }
        return num;
    }

    private float method_107(Table A_0, int A_1, int A_2)
    {
        if (A_0 == null)
        {
            return 0f;
        }
        float num5 = 0f;
        int num = 0;
        List<float> tableGrid = A_0.TableGrid;
        for (int i = 0; i < A_2; i++)
        {
            num += A_0.Rows[A_1].Cells[i].GridSpanEx;
        }
        int num4 = ((num + A_0.Rows[A_1].Cells[A_2].GridSpanEx) >= tableGrid.Count) ? (tableGrid.Count - 1) : (num + A_0.Rows[A_1].Cells[A_2].GridSpanEx);
        int num3 = ((num - 1) < 0) ? 0 : num;
        if (num4 < tableGrid.Count)
        {
            num5 = (tableGrid[num4] - tableGrid[num3]) / 20f;
        }
        return num5;
    }

    private void method_108()
    {
        RectangleF ef = base.class375_0.method_69();
        ef.Width = this.class375_1.method_69().Width + ((float) (this.method_33().imethod_0().imethod_0().method_0() + this.method_33().imethod_0().imethod_0().method_8()));
        ef.Height = (this.class375_1.method_69().Bottom - ef.Top) + ((float) this.method_33().imethod_0().imethod_0().method_12());
        base.class375_0.method_70(ef);
    }

    private void method_109()
    {
        if ((this.class375_1.method_73().imethod_0() as Class205).method_3())
        {
            RectangleF ef = new RectangleF(base.class774_0.method_0().Location, new SizeF(base.class774_0.method_0().Width, base.class774_0.method_0().Height - (this.class375_1.method_73().imethod_0() as Class205).method_7()));
            base.class774_0.method_1(ef);
        }
    }

    private bool method_110(int A_0, int A_1)
    {
        bool flag = A_0 > 0;
        int num = A_0;
        bool isHeader = (base.class375_0.method_74().method_4(A_0).method_73() as TableRow).IsHeader;
        while (flag)
        {
            Class375 class3 = base.class375_0.method_74().method_4(num - 1);
            bool flag3 = (class3.method_73() as TableRow).IsHeader;
            int num2 = this.method_111(A_0, A_1, num - 1);
            if (((class3.method_74().Count - 1) <= num2) || ((class3.method_74().method_4(num2).method_73().imethod_0() as Class211).method_111() && (isHeader == flag3)))
            {
                return true;
            }
            num--;
            flag = num > 0;
        }
        return false;
    }

    private int method_111(int A_0, int A_1, int A_2)
    {
        int num = A_1;
        float x = base.class375_0.method_74().method_4(A_0).method_74().method_4(A_1).method_69().X;
        float num3 = 0f;
        for (int i = 0; i < base.class375_0.method_74().method_4(A_2).method_74().Count; i++)
        {
            num3 = base.class375_0.method_74().method_4(A_2).method_74().method_4(i).method_69().X;
            if (x <= num3)
            {
                return i;
            }
        }
        return num;
    }

    private void method_112(ref RectangleF A_0)
    {
        RowFormat tableFormat = this.table_0.TableFormat;
        MarginsF sf = this.method_42();
        float layoutWidth = this.table_0.LayoutWidth;
        if (!this.table_0.IsTextBox)
        {
            if (((this.table_0.IndentFromLeft != float.MinValue) && (tableFormat.HorizontalAlignment == RowAlignment.Left)) && !this.method_32().imethod_13())
            {
                if (((this.table_0.OwnerTextBody is TableCell) && !(this.table_0.OwnerTextBody as TableCell).OwnerRow.OwnerTable.IsTextBox) || (!this.table_0.IsTextBox && (this.table_0.Document.Settings.method_3() > 14)))
                {
                    A_0.X += this.table_0.IndentFromLeft;
                }
                else
                {
                    A_0.X += this.table_0.IndentFromLeft - this.method_35();
                }
            }
            if (!this.method_32().imethod_13() && (tableFormat.HorizontalAlignment == RowAlignment.Right))
            {
                float num2 = (float) Math.Round((double) A_0.Right, 2);
                RectangleF ef = new RectangleF(A_0.Location, A_0.Size) {
                    Width = layoutWidth - tableFormat.Paddings.Right
                };
                float num3 = (float) Math.Round((double) ef.Right, 2);
                if (num2 > num3)
                {
                    A_0.X += ((num2 - num3) + tableFormat.Paddings.Left) + tableFormat.Paddings.Right;
                }
                else if (num2 != num3)
                {
                    A_0.X += num2 - num3;
                }
            }
            else if (!this.method_32().imethod_13() && (tableFormat.HorizontalAlignment == RowAlignment.Center))
            {
                if (layoutWidth > 0f)
                {
                    Paddings paddings = new Paddings();
                    if (this.table_0.Owner is TableCell)
                    {
                        paddings = !(this.table_0.Owner as TableCell).CellFormat.Paddings.IsEmpty ? (this.table_0.Owner as TableCell).CellFormat.Paddings : (!(this.table_0.Owner as TableCell).OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty ? (this.table_0.Owner as TableCell).OwnerRow.OwnerTable.TableFormat.Paddings : new Paddings());
                    }
                    if ((this.table_0.Owner is TableCell) && (paddings.Right != paddings.Left))
                    {
                        A_0.X += (((A_0.Width - layoutWidth) - paddings.PaddingWidth) / 2f) + paddings.Left;
                    }
                    else if (((this.table_0.PreferredTableWidth.method_51() == FtsWidth.Auto) || (this.table_0.PreferredTableWidth.method_51() == FtsWidth.None)) && ((tableFormat.LayoutType == LayoutType.AutoFit) && (Class59.smethod_4(A_0.Width, (layoutWidth - tableFormat.Paddings.Left) - tableFormat.Paddings.Right, 0.5f) > 0)))
                    {
                        A_0.X += (((A_0.Width - layoutWidth) + tableFormat.Paddings.Left) + tableFormat.Paddings.Right) / 2f;
                    }
                    else
                    {
                        A_0.X += (A_0.Width - layoutWidth) / 2f;
                    }
                }
            }
            else if (this.method_32().imethod_13() && this.table_0.interface23_0.imethod_34())
            {
                A_0 = this.rectangleF_1;
                this.method_36(this.table_0, sf, ref A_0);
            }
        }
        A_0.Width = layoutWidth;
        if (A_0.Width == 0f)
        {
            A_0.Width = this.table_0.LayoutWidth;
        }
    }

    internal ArrayList method_113(Table A_0, float A_1)
    {
        ArrayList list = new ArrayList();
        if (A_0 != null)
        {
            using (Class711 class2 = new Class711())
            {
                A_0.method_75();
                class2.method_17(A_0.TableFormat.LayoutType);
                float num = this.method_117(A_0, A_1);
                this.method_118(A_0, class2, num);
                if (((A_0.IndentFromLeft != 0f) && !A_0.TableFormat.WrapTextAround) && (A_0.TableFormat.HorizontalAlignment == RowAlignment.Left))
                {
                    A_1 -= A_0.TableFormat.RowIndent;
                }
                this.method_120(A_0, class2, num, A_1);
                foreach (Class714 class3 in class2.method_0())
                {
                    list.Add((int) (class3.method_8() * 20f));
                }
            }
        }
        return list;
    }

    internal float method_114(Table A_0, float A_1)
    {
        if (A_0 == null)
        {
            return 0f;
        }
        if ((A_0 == null) || !A_0.IsHasCaculatedCellWidth)
        {
            switch (A_0.TableFormat.LayoutType)
            {
                case LayoutType.Fixed:
                    this.method_116(A_0, A_1);
                    break;

                case LayoutType.AutoFit:
                    this.method_115(A_0, A_1);
                    break;
            }
            A_0.IsHasCaculatedCellWidth = true;
        }
        return A_0.LayoutWidth;
    }

    private float method_115(Table A_0, float A_1)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("笮夰嘲ᔴံ䴸娺弼匾⑀摂敄㝆⡈㥊ⱌ≎㑐❒ご╖祘㉚⹜罞འᙢ।୦䝨", num));
        }
        using (Class711 class2 = new Class711())
        {
            A_0.method_75();
            class2.method_17(A_0.TableFormat.LayoutType);
            float num2 = this.method_117(A_0, A_1);
            this.method_118(A_0, class2, num2);
            if (((A_0.IndentFromLeft != 0f) && !A_0.TableFormat.WrapTextAround) && (A_0.TableFormat.HorizontalAlignment == RowAlignment.Left))
            {
                A_1 -= A_0.TableFormat.RowIndent;
            }
            float num3 = class2.method_63();
            if ((num2 < num3) && (num3 <= A_1))
            {
                if (A_0.interface23_0 != null)
                {
                    A_0.interface23_0.imethod_35(true);
                }
                num2 = num3;
                A_0.LayoutWidth = num2;
            }
            this.method_120(A_0, class2, num2, A_1);
            return A_0.LayoutWidth;
        }
    }

    private float method_116(Table A_0, float A_1)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("朲崴制ᤸ᰺䤼帾⍀⽂⁄恆楈㭊ⱌ㵎ぐ㹒ご⍖㱘⥚絜㙞በ䍢୤ቦըݪ䍬", num));
        }
        float num2 = this.method_117(A_0, A_1);
        A_0.LayoutWidth = num2;
        using (Class711 class2 = new Class711())
        {
            class2.method_17(A_0.TableFormat.LayoutType);
            this.method_118(A_0, class2, num2);
            this.method_122(A_0, class2, num2, A_1);
        }
        return A_0.LayoutWidth;
    }

    private float method_117(Table A_0, float A_1)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("挶儸帺ᴼᠾ㕀≂❄⭆ⱈ汊浌㽎ぐ⅒㑔㩖㱘⽚㡜ⵞ䅠੢ᙤ䝦ݨṪŬͮ彰", num));
        }
        float paddingWidth = A_0.TableFormat.Paddings.PaddingWidth;
        float num4 = A_1 + paddingWidth;
        float layoutWidth = 0f;
        float num2 = 0f;
        if (A_0.IsInCell)
        {
            TableCell owner = A_0.Owner as TableCell;
            Table ownerTable = owner.OwnerRow.OwnerTable;
            if (!owner.CellFormat.SamePaddingsAsTable)
            {
                num2 = owner.CellFormat.Paddings.PaddingWidth;
            }
            else
            {
                num2 = ownerTable.TableFormat.Paddings.PaddingWidth;
            }
        }
        switch (A_0.PreferredTableWidth.method_51())
        {
            case FtsWidth.None:
            case FtsWidth.Auto:
                switch (A_0.TableFormat.LayoutType)
                {
                    case LayoutType.Fixed:
                        if (A_0.LayoutWidth > 0f)
                        {
                            layoutWidth = (A_0.IsInCell || A_0.IsTextBox) ? A_0.LayoutWidth : A_0.LayoutWidth;
                        }
                        else
                        {
                            layoutWidth = A_0.IsInCell ? (A_1 - num2) : num4;
                        }
                        goto Label_0312;

                    case LayoutType.AutoFit:
                        if ((A_0.IsInCell && ((A_0.Owner as TableCell).LayoutWidth > 0f)) && (((A_0.Owner as TableCell).CellFormat.HorizontalMerge == CellMerge.None) && (A_0.PreferredTableWidth.method_51() == FtsWidth.Auto)))
                        {
                            if ((A_0.LayoutWidth > 0f) && ((A_0.Owner as TableCell).GridSpanEx == 1))
                            {
                                layoutWidth = Math.Min((A_0.Owner as TableCell).LayoutWidth - num2, A_0.LayoutWidth);
                            }
                            else if (A_0.LayoutWidth > 0f)
                            {
                                layoutWidth = A_0.LayoutWidth;
                            }
                            else
                            {
                                layoutWidth = (A_0.Owner as TableCell).LayoutWidth - num2;
                            }
                        }
                        else if (Class59.smethod_4(A_0.LayoutWidth, num4, 0.5f) >= 0)
                        {
                            layoutWidth = (A_0.IsInCell || A_0.IsTextBox) ? A_0.LayoutWidth : num4;
                        }
                        else if (Class59.smethod_4(A_0.LayoutWidth, paddingWidth, 0.5f) > 0)
                        {
                            layoutWidth = (A_0.IsInCell || A_0.IsTextBox) ? A_0.LayoutWidth : (A_0.LayoutWidth + paddingWidth);
                        }
                        else
                        {
                            layoutWidth = A_0.IsInCell ? (A_1 - num2) : num4;
                        }
                        if ((((A_0.TableFormat.LayoutType == LayoutType.AutoFit) && (A_0.IndentFromLeft != 0f)) && (!A_0.TableFormat.WrapTextAround && (A_0.TableFormat.HorizontalAlignment == RowAlignment.Left))) && ((layoutWidth + A_0.IndentFromLeft) > num4))
                        {
                            layoutWidth = num4 - A_0.IndentFromLeft;
                        }
                        goto Label_0312;
                }
                break;

            case FtsWidth.Percentage:
            {
                float num6 = (A_1 * A_0.PreferredTableWidth.method_49()) / 100f;
                layoutWidth = A_0.IsInCell ? (((num6 - num2) > paddingWidth) ? (num6 - num2) : num6) : (num6 + paddingWidth);
                break;
            }
            case FtsWidth.Point:
            {
                float num5 = A_0.PreferredTableWidth.method_49() / 20f;
                if (!A_0.IsInCell || (A_0.LayoutWidth <= num5))
                {
                    layoutWidth = num5;
                    break;
                }
                layoutWidth = A_0.LayoutWidth;
                break;
            }
        }
    Label_0312:
        if (((!A_0.IsTextBox && (A_0.TableFormat.LayoutType == LayoutType.AutoFit)) && (!A_0.GrowAuotFit && (layoutWidth > num4))) && ((A_0.PreferredTableWidth.method_51() != FtsWidth.Point) && (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)))
        {
            layoutWidth = num4;
        }
        A_0.LayoutWidth = layoutWidth;
        return layoutWidth;
    }

    private void method_118(Table A_0, Class711 A_1, float A_2)
    {
        int num = 4;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("縩䐫䬭ုᔱ䀳圵娷嘹夻᤽怿㉁╃㑅⥇❉⥋㩍㕏⁑瑓㽕⭗穙㉛⭝౟๡䩣", num));
        }
        if (A_1 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("縩䐫䬭ုᔱ䀳圵娷嘹夻眽⸿⑁⭃慅桇㩉ⵋ㱍ㅏ㽑ㅓ≕㵗⡙籛㝝፟䉡੣፥ѧ٩䉫", num));
        }
        int num12 = 0;
        int count = A_0.Rows.Count;
        while (num12 < count)
        {
            Class712 class3 = new Class712(A_1);
            TableRow row = A_0.Rows[num12];
            if (row.RowFormat.GridBefore > 0)
            {
                class3.method_7(new int?(row.RowFormat.GridBefore));
            }
            if (row.RowFormat.GridAfter > 0)
            {
                class3.method_9(new int?(row.RowFormat.GridAfter));
            }
            Paddings paddings = row.RowFormat.Paddings;
            short num7 = 0;
            float cellSpacingEx = A_0.TableFormat.CellSpacingEx;
            if ((row.RowFormat != null) && (row.RowFormat.CellSpacingEx != -1f))
            {
                cellSpacingEx = row.RowFormat.CellSpacingEx;
            }
            cellSpacingEx = (cellSpacingEx > 0f) ? cellSpacingEx : 0f;
            TableCell cell2 = null;
            int num16 = 0;
            int num18 = row.Cells.Count;
            while (num16 < num18)
            {
                TableCell cell = row.Cells[num16];
                bool flag = false;
                int gridSpanEx = cell.GridSpanEx;
                if (((cell.CellFormat.HorizontalMerge != CellMerge.Continue) || (cell2 == null)) || (cell.WidthType == cell2.WidthType))
                {
                    if ((((cell.CellFormat.HorizontalMerge == CellMerge.None) || (cell.CellFormat.HorizontalMerge == CellMerge.Start)) && ((cell.NextSibling is TableCell) && ((cell.NextSibling as TableCell).CellFormat.HorizontalMerge == CellMerge.Continue))) && ((cell.NextSibling as TableCell).WidthType != cell.WidthType))
                    {
                        cell2 = cell;
                        flag = true;
                        gridSpanEx = this.method_119(row, num16);
                    }
                    float paddingWidth = 0f;
                    if (cell.CellFormat.SamePaddingsAsTable)
                    {
                        if (!paddings.IsEmpty)
                        {
                            paddingWidth = paddings.PaddingWidth;
                        }
                        else if (!A_0.TableFormat.Paddings.IsEmpty)
                        {
                            paddingWidth = A_0.TableFormat.Paddings.PaddingWidth;
                        }
                        else if ((paddings.IsEmpty && A_0.TableFormat.Paddings.IsEmpty) && (paddings.IsDefault && A_0.TableFormat.Paddings.IsDefault))
                        {
                            paddingWidth = 10.8f;
                        }
                    }
                    else
                    {
                        paddingWidth = cell.CellFormat.Paddings.PaddingWidth;
                    }
                    paddingWidth += cellSpacingEx * 2f;
                    if ((num16 == 0) && (row.RowFormat.GridBeforeWidth.method_55() || (row.RowFormat.GridBefore > 0)))
                    {
                        Class713 class4 = new Class713(class3);
                        class4.method_11(num7);
                        class4.method_8(row.RowFormat.GridBefore);
                        if (row.RowFormat.GridBeforeWidth.method_55())
                        {
                            class4.method_43(row.RowFormat.GridBeforeWidth.method_51());
                            switch (row.RowFormat.GridBeforeWidth.method_51())
                            {
                                case FtsWidth.Point:
                                    class4.method_1(row.RowFormat.GridBeforeWidth.method_56());
                                    break;
                            }
                        }
                        else if (row.RowFormat.GridBefore > 0)
                        {
                            class4.method_43(FtsWidth.Point);
                        }
                        class3.method_32(num7, class4, -1);
                        int num14 = num7;
                        num7 = (short) (num7 + 1);
                        if (row.RowFormat.GridBefore > 1)
                        {
                            for (int i = 1; i < row.RowFormat.GridBefore; i++)
                            {
                                Class713 class5 = new Class713(class3);
                                class5.method_13(CellMerge.Continue);
                                class5.method_11(num7);
                                class3.method_32(num7, class5, num14);
                                num7 = (short) (num7 + 1);
                            }
                        }
                    }
                    Class713 class7 = new Class713(class3);
                    if (cell.WidthType == FtsWidth.Percentage)
                    {
                        float num11 = A_2;
                        if (A_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                        {
                            num11 = A_0.method_54();
                            num11 = (num11 <= 0f) ? A_2 : num11;
                        }
                        class7.method_1((num11 * cell.Scaling) / 100f);
                        cell.LayoutWidth = class7.method_0();
                    }
                    else if ((cell.WidthType != FtsWidth.None) && (cell.WidthType != FtsWidth.Auto))
                    {
                        class7.method_1(cell.LayoutWidth);
                    }
                    else if (A_0.TableGrid.Count > ((Interface4) A_0).imethod_6())
                    {
                        int num23 = row.method_5();
                        int cellIndex = cell.GetCellIndex();
                        class7.method_1(this.method_107(A_0, num23, cellIndex));
                    }
                    else
                    {
                        class7.method_1(0f);
                    }
                    class7.method_3(class7.method_0());
                    class7.method_13(cell.CellFormat.HorizontalMerge);
                    class7.method_18(cell.CellFormat.VerticalMerge);
                    class7.method_8(gridSpanEx);
                    class7.method_7(cell.GridSpanEx);
                    class7.method_43(cell.WidthType);
                    class7.method_32(paddingWidth);
                    class7.method_34(cellSpacingEx);
                    if (cell.Tables.Count > 0)
                    {
                        class7.method_16(true);
                    }
                    else
                    {
                        class7.method_16(false);
                    }
                    class7.method_11(num7);
                    if ((cell.Scaling != 100f) || (cell.WidthType == FtsWidth.Percentage))
                    {
                        class7.method_39(cell.Scaling / 100f);
                    }
                    TextDirection textDirection = cell.CellFormat.TextDirection;
                    if (cell.Items.Count > 0)
                    {
                        for (int j = 0; j < cell.Items.Count; j++)
                        {
                            float width = 0f;
                            float num6 = 0f;
                            float num3 = 0f;
                            float num5 = 0f;
                            BodyRegion region = cell.Items[j];
                            if (region is Paragraph)
                            {
                                Paragraph paragraph = region as Paragraph;
                                if (paragraph.Items.Count > 0)
                                {
                                    TextRange range = paragraph.method_39(true);
                                    if (range != null)
                                    {
                                        switch (textDirection)
                                        {
                                            case TextDirection.TopToBottom:
                                            case TextDirection.TopToBottomRotated:
                                                width = ((Interface2) range).imethod_3(base.method_4()).Width;
                                                break;
                                        }
                                    }
                                    else if (paragraph.WidgetCollection[0] is DocPicture)
                                    {
                                        DocPicture picture = paragraph.WidgetCollection[0] as DocPicture;
                                        if ((picture.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && (picture.TextWrappingStyle != TextWrappingStyle.Behind))
                                        {
                                            width = base.method_4().method_306(picture).Width;
                                        }
                                    }
                                    else if (paragraph.WidgetCollection[0] is Class6)
                                    {
                                        Class6 class2 = paragraph.WidgetCollection[0] as Class6;
                                        if (((class2.method_30() != null) && (class2.method_30().TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (class2.method_30().TextWrappingStyle != TextWrappingStyle.Behind))
                                        {
                                            width = base.method_4().method_306(class2.method_30()).Width;
                                        }
                                        else if (((class2.method_32() != null) && (class2.method_32().TextWrappingStyle != TextWrappingStyle.Behind)) && (class2.method_32().TextWrappingStyle != TextWrappingStyle.InFrontOfText))
                                        {
                                            width = base.method_4().method_214(class2.method_32() as ShapeObject).Width;
                                        }
                                    }
                                    else if (paragraph.WidgetCollection[0] is ShapeObject)
                                    {
                                        ShapeObject obj2 = paragraph.WidgetCollection[0] as ShapeObject;
                                        if ((obj2.TextWrappingStyle != TextWrappingStyle.Behind) && (obj2.TextWrappingStyle != TextWrappingStyle.InFrontOfText))
                                        {
                                            width = base.method_4().method_214(obj2).Width;
                                        }
                                    }
                                    else if (paragraph.WidgetCollection[0] is Interface2)
                                    {
                                        width = (paragraph.WidgetCollection[0] as Interface2).imethod_3(base.method_4()).Width;
                                    }
                                    float num4 = 0f;
                                    float num19 = 0f;
                                    List<List<DocumentObject>> list2 = paragraph.method_41(base.method_4(), out num19);
                                    foreach (List<DocumentObject> list in list2)
                                    {
                                        float num2 = 0f;
                                        foreach (DocumentObject obj3 in list)
                                        {
                                            if (obj3 is TextRange)
                                            {
                                                num2 += (obj3 as Interface2).imethod_3(base.method_4()).Width;
                                                num5 = Math.Max(num5, base.method_4().method_323(obj3 as TextRange, BookmarkStart.b("紩", num)).Width);
                                            }
                                            else if (obj3 is DocPicture)
                                            {
                                                num2 = base.method_4().method_306(obj3 as DocPicture).Width;
                                            }
                                            else if (obj3 is TextBox)
                                            {
                                                num2 = (obj3 as TextBox).Format.Width;
                                            }
                                            else if (obj3 is ShapeObject)
                                            {
                                                num2 = base.method_4().method_214(obj3 as ShapeObject).Width;
                                            }
                                            else if ((obj3 is Break) && ((obj3 as Break).BreakType == BreakType.LineBreak))
                                            {
                                                num3 = Math.Max(num3, num4);
                                                num4 = 0f;
                                                num2 = 0f;
                                            }
                                        }
                                        switch (textDirection)
                                        {
                                            case TextDirection.TopToBottom:
                                            case TextDirection.TopToBottomRotated:
                                                num6 = Math.Max(num6, num2);
                                                num4 += num2;
                                                break;
                                        }
                                    }
                                    if ((list2 != null) && (list2.Count > 0))
                                    {
                                        list2.Clear();
                                        list2 = null;
                                    }
                                    num4 = (num4 == 0f) ? width : num4;
                                    num6 = (num6 == 0f) ? width : num6;
                                    num3 = Math.Max(num3, num4);
                                }
                            }
                            else if (region is Table)
                            {
                                (region as Table).method_46();
                                if ((region as Table).TableFormat.LayoutType != A_0.TableFormat.LayoutType)
                                {
                                    (region as Table).TableFormat.LayoutType = A_0.TableFormat.LayoutType;
                                }
                                float layoutWidth = cell.LayoutWidth;
                                if (cell.CellFormat.HorizontalMerge == CellMerge.Start)
                                {
                                    for (TableCell cell3 = cell.NextSibling as TableCell; cell3 != null; cell3 = cell3.NextSibling as TableCell)
                                    {
                                        if (cell3.CellFormat.HorizontalMerge != CellMerge.Continue)
                                        {
                                            break;
                                        }
                                        layoutWidth += cell3.LayoutWidth;
                                    }
                                }
                                layoutWidth = ((layoutWidth <= 0f) || (cell.GridSpanEx != 1)) ? A_2 : layoutWidth;
                                float num26 = this.method_114(region as Table, layoutWidth);
                                width = Math.Max(width, num26);
                                num6 = Math.Max(num6, num26);
                                num3 = Math.Max(num3, num26);
                            }
                            class7.method_5(Math.Max(class7.method_4(), (((float) Math.Round((double) width, 2)) + paddingWidth) + ((float) ((Interface1) region).imethod_0().imethod_1().method_0())));
                            class7.method_20(Math.Max(class7.method_19(), (((float) Math.Round((double) num6, 2)) + paddingWidth) + ((float) ((Interface1) region).imethod_0().imethod_1().method_0())));
                            class7.method_36(Math.Max(class7.method_35(), ((float) Math.Round((double) num3, 2)) + ((float) ((Interface1) region).imethod_0().imethod_1().method_0())));
                            if ((((A_0.TableFormat.LayoutType == LayoutType.AutoFit) && (region is Paragraph)) && ((region as Paragraph).IsList && ((region as Paragraph).ListFormat != null))) && (class7.method_0() == 0f))
                            {
                                float num28 = ((region as Paragraph).ListFormat.CurrentListLevel != null) ? (region as Paragraph).ListFormat.CurrentListLevel.ParagraphFormat.LeftIndent : 0f;
                                class7.method_20(Math.Max(class7.method_19(), (((float) Math.Round((double) num6, 2)) + paddingWidth) + num28));
                                class7.method_36(Math.Max(class7.method_35(), ((float) Math.Round((double) num3, 2)) + num28));
                            }
                            class7.method_41(Math.Max(class7.method_40(), (float) Math.Round((double) num5, 2)));
                        }
                    }
                    if (gridSpanEx > 1)
                    {
                        class7.method_13(CellMerge.Start);
                    }
                    class3.method_31(num7, class7);
                    int num27 = num7;
                    num7 = (short) (num7 + 1);
                    if (gridSpanEx > 1)
                    {
                        for (int k = 1; k < gridSpanEx; k++)
                        {
                            Class713 class8 = new Class713(class3);
                            class8.method_13(CellMerge.Continue);
                            class8.method_11(num7);
                            class3.method_32(num7, class8, num27);
                            if (flag && (num7 < row.Cells.Count))
                            {
                                class8.method_25(false);
                                class8.method_18(row.Cells[num7].CellFormat.VerticalMerge);
                                class8.method_13(row.Cells[num7].CellFormat.HorizontalMerge);
                                class8.method_7(row.Cells[num7].GridSpanEx);
                            }
                            num7 = (short) (num7 + 1);
                        }
                    }
                    if (((num16 + 1) == num18) && (row.RowFormat.GridAfterWidth.method_55() || (row.RowFormat.GridAfter > 0)))
                    {
                        Class713 class6 = new Class713(class3);
                        class6.method_8(row.RowFormat.GridAfter);
                        class6.method_11(num7);
                        if (row.RowFormat.GridAfterWidth.method_55())
                        {
                            class6.method_43(row.RowFormat.GridAfterWidth.method_51());
                            switch (row.RowFormat.GridAfterWidth.method_51())
                            {
                                case FtsWidth.Point:
                                    class6.method_1(row.RowFormat.GridAfterWidth.method_56());
                                    break;
                            }
                        }
                        else if (row.RowFormat.GridAfter > 0)
                        {
                            class6.method_43(FtsWidth.Point);
                        }
                        class3.method_32(num7, class6, -1);
                        int num29 = num7;
                        num7 = (short) (num7 + 1);
                        if (row.RowFormat.GridAfter > 1)
                        {
                            for (int m = 1; m < row.RowFormat.GridAfter; m++)
                            {
                                Class713 class9 = new Class713(class3);
                                class9.method_13(CellMerge.Continue);
                                class9.method_11(num7);
                                class3.method_32(num7, class9, num29);
                                num7 = (short) (num7 + 1);
                            }
                        }
                    }
                }
                num16++;
            }
            if (class3.method_4() > 0)
            {
                A_1.method_71(num12, class3);
            }
            num12++;
        }
    }

    private int method_119(TableRow A_0, int A_1)
    {
        int gridSpanEx = A_0.Cells[A_1].GridSpanEx;
        for (int i = A_1 + 1; i < A_0.Cells.Count; i++)
        {
            if (A_0.Cells[i].CellFormat.HorizontalMerge != CellMerge.Continue)
            {
                return gridSpanEx;
            }
            gridSpanEx += A_0.Cells[i].GridSpanEx;
        }
        return gridSpanEx;
    }

    private void method_120(Table A_0, Class711 A_1, float A_2, float A_3)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("攰嬲倴᜶Ḹ伺尼崾ⵀ♂扄杆㥈⩊㽌⹎㱐㙒⅔㉖⭘筚㑜ⱞ䅠ൢၤ୦ը䕪", num));
        }
        if (A_1 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("攰嬲倴᜶Ḹ伺尼崾ⵀ♂ౄ⥆⽈⑊橌潎⅐㉒❔㙖㑘㹚⥜㩞፠䍢౤ᑦ䥨ժᡬͮᵰ嵲", num));
        }
        if (A_0.PreferredTableWidth.method_51() != FtsWidth.Point)
        {
            A_3 = (float) Math.Round((double) (A_3 + A_0.TableFormat.Paddings.PaddingWidth), 2);
        }
        A_2 = (float) Math.Round((double) A_2, 2);
        if ((A_1.method_5() > 0) && (A_1.method_5() == A_0.Rows.Count))
        {
            if (!A_1.method_2() || (A_1.method_2() && A_1.method_15()))
            {
                if (A_1.method_3())
                {
                    A_1.method_24(A_2);
                }
                else if (A_1.method_7())
                {
                    float num9 = A_2;
                    float num21 = A_1.method_19();
                    if ((num9 < num21) && (num21 <= A_3))
                    {
                        num9 = num21;
                    }
                    else if (num9 < num21)
                    {
                        num9 = A_3;
                    }
                    A_1.method_26(num9);
                }
                else
                {
                    A_1.method_29();
                }
                A_1.method_53(A_2);
                float num8 = (float) Math.Round((double) A_1.method_19(), 2);
                if ((((A_0.PreferredTableWidth.method_51() != FtsWidth.Auto) && (A_0.PreferredTableWidth.method_51() != FtsWidth.None)) && ((A_2 > 0f) && (num8 > 0f))) && (A_2 != num8))
                {
                    A_1.method_27(A_2);
                }
                else if (((A_0.PreferredTableWidth.method_51() == FtsWidth.Auto) || (A_0.PreferredTableWidth.method_51() == FtsWidth.None)) && (((A_2 > 0f) && (num8 > 0f)) && (!A_0.GrowAuotFit && ((num8 - A_3) > 1f))))
                {
                    A_1.method_27(A_3);
                }
                float num22 = 1f;
                if ((A_1.method_4() && !A_1.method_10()) && A_1.method_11())
                {
                    A_1.method_59();
                }
                A_1.method_53(A_2);
                float num16 = A_1.method_19();
                if (((A_0.PreferredWidth.Type == WidthType.Auto) || (A_0.PreferredWidth.Type == WidthType.None)) && ((num16 != A_2) && (num16 <= A_3)))
                {
                    A_0.LayoutWidth = num16;
                }
                if (num16 > A_0.LayoutWidth)
                {
                    num22 = (float) Math.Round((double) (A_0.LayoutWidth / num16), 2);
                }
                for (int i = 0; i < A_1.method_5(); i++)
                {
                    Class712 class3 = A_1.method_48(i);
                    int num25 = 0;
                    int num19 = 0;
                    if (class3.method_6().HasValue)
                    {
                        num25 = class3.method_6().Value;
                    }
                    for (int j = 0; j < class3.method_4(); j++)
                    {
                        Class713 class2 = class3.method_29(j);
                        if (!class2.method_24())
                        {
                            float num13 = 0f;
                            int count = A_1.method_9().Count;
                            int num15 = A_1.method_22();
                            bool flag = true;
                            if ((count > 1) && (num15 == (count - 1)))
                            {
                                num13 = A_1.method_60(num25 + num19, class2);
                                num25 += class2.method_6() - 1;
                            }
                            else if (class2.method_9() > 1)
                            {
                                for (int k = class2.method_10(); k < (class2.method_9() + class2.method_10()); k++)
                                {
                                    num13 += A_1.method_49(k);
                                }
                            }
                            else
                            {
                                num13 = A_1.method_49(class2.method_10());
                            }
                            if (flag)
                            {
                                A_0.Rows[i].Cells[num19].LayoutWidth = num13 * num22;
                            }
                            else
                            {
                                A_0.Rows[i].Cells[num19].LayoutWidth = num13;
                            }
                            num19++;
                        }
                    }
                }
            }
            else
            {
                A_2 = (float) Math.Round((double) A_2, 2);
                A_1.method_29();
                A_1.method_53(A_2);
                float num5 = (float) Math.Round((double) A_1.method_19(), 2);
                if ((((A_0.PreferredTableWidth.method_51() != FtsWidth.Auto) && (A_0.PreferredTableWidth.method_51() != FtsWidth.None)) && ((A_2 > 0f) && (num5 > 0f))) && (Class59.smethod_5((double) A_2, (double) num5, 0.005) != 0))
                {
                    A_1.method_27(A_2);
                }
                else if (((A_0.PreferredTableWidth.method_51() == FtsWidth.Auto) || (A_0.PreferredTableWidth.method_51() == FtsWidth.None)) && (((A_2 > 0f) && (num5 > 0f)) && (!A_0.GrowAuotFit && (Class59.smethod_5((double) num5, (double) A_3, 0.005) > 0))))
                {
                    A_1.method_27(A_3);
                }
                float num3 = 1f;
                float num2 = (float) Math.Round((double) A_1.method_19(), 2);
                switch (A_0.PreferredTableWidth.method_51())
                {
                    case FtsWidth.Auto:
                        if (A_2 >= num2)
                        {
                            if (A_0.IsInCell)
                            {
                                num3 = A_2 / num2;
                            }
                        }
                        else
                        {
                            num3 = A_2 / num2;
                        }
                        break;

                    case FtsWidth.Point:
                        if (A_2 < num2)
                        {
                            A_2 = num2;
                            A_0.LayoutWidth = A_2;
                        }
                        num3 = A_2 / num2;
                        break;

                    default:
                        num3 = A_2 / num2;
                        break;
                }
                if ((((A_0.PreferredTableWidth.method_51() != FtsWidth.Point) && !A_0.GrowAuotFit) && ((A_2 - A_3) > 0.5f)) || (((A_0.TableFormat.LayoutType == LayoutType.AutoFit) && A_0.IsInCell) && ((A_2 - A_3) > 0.5f)))
                {
                    num3 = A_3 / A_2;
                }
                this.method_121(A_1, A_2, num3, A_0.IsInCell);
                for (int m = 0; m < A_1.method_5(); m++)
                {
                    Class712 class4 = A_1.method_48(m);
                    int num17 = 0;
                    int num18 = 0;
                    if (class4.method_6().HasValue)
                    {
                        num17 = class4.method_6().Value;
                    }
                    for (int n = 0; n < class4.method_4(); n++)
                    {
                        Class713 class5 = class4.method_29(n);
                        if (!class5.method_24())
                        {
                            float num10 = 0f;
                            int num23 = A_1.method_9().Count;
                            int num24 = A_1.method_22();
                            if ((num23 > 1) && (num24 == (num23 - 1)))
                            {
                                num10 = A_1.method_60(num17 + num18, class5);
                                num17 += class5.method_6() - 1;
                            }
                            else if (class5.method_9() > 1)
                            {
                                for (int num11 = class5.method_10(); num11 < (class5.method_9() + class5.method_10()); num11++)
                                {
                                    num10 += A_1.method_49(num11);
                                }
                            }
                            else
                            {
                                num10 = A_1.method_49(class5.method_10());
                            }
                            if ((num3 < 1f) && !A_0.IsInCell)
                            {
                                A_0.Rows[m].Cells[num18].LayoutWidth = num10;
                            }
                            else
                            {
                                A_0.Rows[m].Cells[num18].LayoutWidth = num10 * num3;
                            }
                            num18++;
                        }
                    }
                }
            }
        }
    }

    private void method_121(Class711 A_0, float A_1, float A_2, bool A_3)
    {
        if ((A_2 < 1f) && !A_3)
        {
            float num3 = A_1 / ((float) A_0.method_0().Count);
            float num4 = 0f;
            float num5 = 0f;
            float num = 0f;
            float num2 = 0f;
            List<Class714> list = new List<Class714>();
            foreach (Class714 class3 in A_0.method_0())
            {
                num4 += class3.method_8();
                if (class3.method_8() > num3)
                {
                    list.Add(class3);
                    num5 += class3.method_8();
                }
                else
                {
                    num += class3.method_8();
                }
            }
            num2 = A_1 - num;
            foreach (Class714 class2 in list)
            {
                class2.method_9(num2 * (class2.method_8() / num5));
            }
        }
    }

    private void method_122(Table A_0, Class711 A_1, float A_2, float A_3)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("攰嬲倴᜶Ḹ伺尼崾ⵀ♂扄杆㥈⩊㽌⹎㱐㙒⅔㉖⭘筚㑜ⱞ䅠ൢၤ୦ը䕪", num));
        }
        if (A_1 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("攰嬲倴᜶Ḹ伺尼崾ⵀ♂ౄ⥆⽈⑊橌潎⅐㉒❔㙖㑘㹚⥜㩞፠䍢౤ᑦ䥨ժᡬͮᵰ嵲", num));
        }
        if (A_0.PreferredTableWidth.method_51() != FtsWidth.Point)
        {
            A_3 = (float) Math.Round((double) (A_3 + A_0.TableFormat.Paddings.PaddingWidth), 2);
        }
        A_2 = (float) Math.Round((double) A_2, 2);
        if (A_1.method_5() > 0)
        {
            A_1.method_53(A_2);
            float num8 = 1f;
            float num5 = A_1.method_19();
            if (((A_0.PreferredTableWidth.method_51() == FtsWidth.Point) || (A_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)) && ((A_2 != num5) && (num5 > 0f)))
            {
                num8 = A_2 / num5;
            }
            if (((A_0.PreferredWidth.Type == WidthType.None) || (A_0.PreferredWidth.Type == WidthType.Auto)) && ((A_0.TableFormat.LayoutType == LayoutType.Fixed) && (A_1.method_19() != A_2)))
            {
                A_0.LayoutWidth = A_1.method_19();
            }
            for (int i = 0; i < A_1.method_5(); i++)
            {
                Class712 class3 = A_1.method_48(i);
                int num11 = 0;
                int num6 = 0;
                if (class3.method_6().HasValue)
                {
                    num11 = class3.method_6().Value;
                }
                for (int j = 0; j < class3.method_4(); j++)
                {
                    Class713 class2 = class3.method_29(j);
                    if (!class2.method_24())
                    {
                        float num7 = 0f;
                        int count = A_1.method_9().Count;
                        int num9 = A_1.method_22();
                        if ((count > 1) && (num9 == (count - 1)))
                        {
                            num7 = A_1.method_60(num11 + num6, class2);
                            num11 += class2.method_6() - 1;
                        }
                        else if (class2.method_9() > 1)
                        {
                            for (int k = class2.method_10(); k < (class2.method_9() + class2.method_10()); k++)
                            {
                                num7 += A_1.method_49(k);
                            }
                        }
                        else
                        {
                            num7 = A_1.method_49(class2.method_10());
                        }
                        A_0.Rows[i].Cells[num6].LayoutWidth = num7 * num8;
                        this.method_123(A_0.Rows[i].Cells[num6], num8);
                        num6++;
                    }
                }
            }
        }
    }

    private void method_123(TableCell A_0, float A_1)
    {
        if (((A_0 != null) && (A_0.Tables.Count > 0)) && (Class59.smethod_4(A_1, 1f, 0.005f) < 0))
        {
            float paddingWidth = 0f;
            Table ownerTable = A_0.OwnerRow.OwnerTable;
            if (!A_0.CellFormat.SamePaddingsAsTable)
            {
                paddingWidth = A_0.CellFormat.Paddings.PaddingWidth;
            }
            else
            {
                paddingWidth = ownerTable.TableFormat.Paddings.PaddingWidth;
            }
            float num3 = A_0.LayoutWidth - paddingWidth;
            foreach (ITable table2 in A_0.Tables)
            {
                if (table2 is Table)
                {
                    Table table3 = table2 as Table;
                    if (table3.PreferredWidth.Type == WidthType.Percentage)
                    {
                        float layoutWidth = table3.LayoutWidth;
                        if (Class59.smethod_4(num3, layoutWidth, 0.005f) < 0)
                        {
                            float num4 = (float) Math.Round((double) (num3 / layoutWidth), 2);
                            table3.LayoutWidth *= num4;
                            foreach (TableRow row in table3.Rows)
                            {
                                foreach (TableCell cell in row.Cells)
                                {
                                    if (cell.WidthType == FtsWidth.Percentage)
                                    {
                                        cell.LayoutWidth *= num4;
                                    }
                                    this.method_123(cell, A_1);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    internal Class616 method_29()
    {
        return this.class616_0;
    }

    internal void method_30(Class616 A_0)
    {
        this.class616_0 = A_0;
    }

    private Dictionary<Interface1, Class375> method_31()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<Interface1, Class375>();
        }
        return this.dictionary_0;
    }

    public Interface5 method_32()
    {
        return this.method_33().imethod_3();
    }

    public Interface4 method_33()
    {
        return (base.interface1_1 as Interface4);
    }

    public int method_34()
    {
        if (this.bool_6)
        {
            return this.int_1;
        }
        return this.int_2;
    }

    internal float method_35()
    {
        return (float) (((Interface1) this.table_0.Rows[0].Cells[0]).imethod_0().imethod_0().method_0() + ((Interface1) this.table_0.Rows[0].Cells[0]).imethod_0().imethod_1().method_0());
    }

    private void method_36(Table A_0, MarginsF A_1, ref RectangleF A_2)
    {
        if ((A_0.IsTextBox && A_0.TextBoxFormat.IsInShape) && A_0.TextBoxFormat.IsInGroupShape)
        {
            A_2 = new RectangleF(A_0.TextBoxFormat.StartPoint.X + A_0.TextBoxFormat.HorizontalPosition, A_0.TextBoxFormat.StartPoint.Y + A_0.TextBoxFormat.VerticalPosition, A_0.TextBoxFormat.Width, A_0.TextBoxFormat.Height);
            return;
        }
        if ((A_0.IsTextBox && A_0.TextBoxFormat.IsInShape) && !A_0.TextBoxFormat.IsInGroupShape)
        {
            A_2 = new RectangleF(A_0.TextBoxFormat.StartPoint.X, A_0.TextBoxFormat.StartPoint.Y, A_0.TextBoxFormat.Width, A_0.TextBoxFormat.Height);
            this.method_32().imethod_15().VertRelationTo = VerticalRelation.Paragraph;
            return;
        }
        float x = A_2.X;
        float y = A_2.Y;
        RowFormat.TablePositioning positioning = this.method_32().imethod_15();
        if (!this.bool_8)
        {
            switch (positioning.VertRelationTo)
            {
                case VerticalRelation.Margin:
                    if (positioning.VertPositionAbs == VerticalPosition.None)
                    {
                        if (!(A_0.Owner is TableCell) || (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                        {
                            if ((A_0.Owner is TableCell) && (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                            {
                                A_2.Y += positioning.VertPositionEx;
                            }
                            else if ((A_0.IsTextBox && A_0.IsTextBoxInTable) && !(A_0.Owner.Owner.Owner.Owner as Table).IsSDTTable)
                            {
                                A_2.Y = (A_2.Y - A_1.Top) + positioning.VertPositionEx;
                            }
                            else if (!(base.interface30_0 as Class304).method_10() && A_0.IsTextBox)
                            {
                                float num10 = Math.Max(base.method_4().method_28().method_47(), A_1.Top);
                                A_2.Y = num10 + positioning.VertPositionEx;
                            }
                            else
                            {
                                A_2.Y = A_1.Top + positioning.VertPositionEx;
                            }
                            break;
                        }
                        A_2.Y = (A_2.Y - A_1.Top) + positioning.VertPositionEx;
                    }
                    break;

                case VerticalRelation.Page:
                    if (positioning.VertPositionAbs == VerticalPosition.None)
                    {
                        if (!(A_0.Owner is TableCell) || (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                        {
                            if ((A_0.IsTextBox && A_0.IsTextBoxInTable) && (A_0.TextBoxFormat.IsAllowInCell && !(A_0.Owner.Owner.Owner.Owner as Table).IsSDTTable))
                            {
                                RectangleF tableBounds = (A_0.Owner.Owner.Owner.Owner as Table).TableBounds;
                                A_2.Y = (tableBounds.Y - A_1.Top) + positioning.VertPositionEx;
                            }
                            else
                            {
                                A_2.Y = positioning.VertPositionEx;
                            }
                            break;
                        }
                        A_2.Y = (A_2.Y - A_1.Top) + positioning.VertPositionEx;
                    }
                    break;

                case VerticalRelation.Paragraph:
                {
                    if (!A_0.IsTextBox)
                    {
                        if (A_0.Owner is TableCell)
                        {
                            Class212 class2 = (A_0.Owner as Interface1).imethod_0() as Class212;
                            float num6 = class2.method_128().Y;
                            float num7 = A_2.Y + positioning.VertPositionEx;
                            if (num7 >= num6)
                            {
                                A_2.Y += positioning.VertPositionEx;
                                A_2.Height -= positioning.VertPositionEx;
                            }
                            else
                            {
                                float num8 = positioning.VertPositionEx + (num6 - num7);
                                A_2.Y += num8;
                                A_2.Height -= num8;
                            }
                        }
                        else
                        {
                            A_2.Y += positioning.VertPositionEx;
                            A_2.Height -= positioning.VertPositionEx;
                        }
                        break;
                    }
                    Paragraph ownerBase = A_0.TextBoxFormat.OwnerBase.OwnerBase as Paragraph;
                    A_2.Y = (((Interface1) ownerBase).imethod_0() as Class210).method_57() + positioning.VertPositionEx;
                    break;
                }
            }
        }
        if (A_0.IsTextBox && (A_0.TextBoxFormat.HorizontalOrigin == HorizontalOrigin.Character))
        {
            A_2.X = positioning.HorizPositionEx;
        }
        switch (positioning.HorizRelationTo)
        {
            case HorizontalRelation.Column:
                if (positioning.HorizPositionEx == 0f)
                {
                    switch (positioning.HorizPositionAbs)
                    {
                        case HorizontalPosition.None:
                        {
                            if (!A_0.IsTextBox || !A_0.IsTextBoxInTable)
                            {
                                if ((A_0.Owner is TableCell) && !(A_0.Owner.Owner.Owner as Table).IsSDTTable)
                                {
                                    float num15 = A_2.X + positioning.HorizPositionEx;
                                    if (num15 < (A_2.X - this.method_35()))
                                    {
                                        A_2.X -= this.method_35();
                                    }
                                    else
                                    {
                                        A_2.X = num15;
                                    }
                                }
                                else if ((A_0.Owner is TableCell) && (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                                {
                                    A_2.X += positioning.HorizPositionEx;
                                }
                                else if (A_0.IsTextBox)
                                {
                                    A_2.X = A_1.Left + positioning.HorizPositionEx;
                                }
                                else
                                {
                                    A_2.X = ((A_1.Left + A_0.IndentFromLeft) + positioning.HorizPositionEx) - A_0.TableFormat.Paddings.Left;
                                }
                                break;
                            }
                            float num17 = ((A_0.TextBox.OwnerParagraph == null) || (A_0.TextBox.OwnerParagraph.Format.FirstLineIndent <= 0f)) ? 0f : A_0.TextBox.OwnerParagraph.Format.FirstLineIndent;
                            A_2.X += positioning.HorizPositionEx - num17;
                            break;
                        }
                        case HorizontalPosition.Left:
                        {
                            if (!A_0.IsTextBox || !A_0.IsTextBoxInTable)
                            {
                                if ((A_0.Owner is TableCell) && !(A_0.Owner.Owner.Owner as Table).IsSDTTable)
                                {
                                    float num = A_2.X + positioning.HorizPositionEx;
                                    if (num < (A_2.X - this.method_35()))
                                    {
                                        A_2.X -= this.method_35();
                                    }
                                    else
                                    {
                                        A_2.X = num;
                                    }
                                }
                                else if ((A_0.Owner is TableCell) && (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                                {
                                    A_2.X += positioning.HorizPositionEx;
                                }
                                else if (A_0.IsTextBox)
                                {
                                    A_2.X = A_1.Left + positioning.HorizPositionEx;
                                }
                                else
                                {
                                    A_2.X = ((A_1.Left + A_0.IndentFromLeft) + positioning.HorizPositionEx) - A_0.TableFormat.Paddings.Left;
                                }
                                break;
                            }
                            float num13 = ((A_0.TextBox.OwnerParagraph == null) || (A_0.TextBox.OwnerParagraph.Format.FirstLineIndent <= 0f)) ? 0f : A_0.TextBox.OwnerParagraph.Format.FirstLineIndent;
                            A_2.X += positioning.HorizPositionEx - num13;
                            break;
                        }
                        case HorizontalPosition.Center:
                        {
                            float num12 = (A_0.Owner is TableCell) ? A_2.X : A_1.Left;
                            if (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)
                            {
                                if (A_0.LayoutWidth != 0f)
                                {
                                    Section section4 = this.table_0.method_55();
                                    if (A_0.Owner is TableCell)
                                    {
                                        A_2.X = num12 + ((A_2.Width - A_0.LayoutWidth) / 2f);
                                    }
                                    if (section4 != null)
                                    {
                                        A_2.X = num12 + ((section4.PageSetup.ClientWidth - A_0.LayoutWidth) / 2f);
                                    }
                                    else
                                    {
                                        A_2.X = num12 + ((A_2.Width - A_0.LayoutWidth) / 2f);
                                    }
                                }
                                break;
                            }
                            A_2.X = num12 + (((A_2.Width * (100f - A_0.PreferredTableWidth.method_49())) / 100f) / 2f);
                            break;
                        }
                        case HorizontalPosition.Right:
                        {
                            if (A_0.Owner is TableCell)
                            {
                                float single4 = A_2.X;
                                break;
                            }
                            float left = A_1.Left;
                            goto Label_0A57;
                        }
                    }
                }
                else if (!A_0.IsTextBoxInTable)
                {
                    if (A_0.IsTextBox)
                    {
                        bool flag = false;
                        float num9 = base.method_4().method_28().method_65(A_0.TextBox.OwnerParagraph, new PointF(A_2.X, A_2.Y), base.method_4(), new PointF(), ref flag);
                        if ((num9 != 0f) && !flag)
                        {
                            A_2.X = num9 + positioning.HorizPositionEx;
                        }
                        else if (!(base.interface30_0 as Class304).method_10())
                        {
                            A_2.X = base.method_4().method_132().imethod_0().method_23().X + positioning.HorizPositionEx;
                        }
                        else
                        {
                            A_2.X += positioning.HorizPositionEx;
                        }
                    }
                    else
                    {
                        A_2.X += positioning.HorizPositionEx;
                    }
                }
                else
                {
                    if ((A_0.TextBox.OwnerParagraph != null) && (A_0.TextBox.OwnerParagraph.Format.FirstLineIndent > 0f))
                    {
                        float firstLineIndent = A_0.TextBox.OwnerParagraph.Format.FirstLineIndent;
                    }
                    TableCell owner = A_0.TextBox.OwnerParagraph.Owner as TableCell;
                    A_2.X = (owner.interface23_0 as Class212).method_128().X + positioning.HorizPositionEx;
                }
                goto Label_123C;

            case HorizontalRelation.Margin:
                if (!A_0.IsTextBoxInTable)
                {
                    switch (positioning.HorizPositionAbs)
                    {
                        case HorizontalPosition.None:
                        {
                            if (!(A_0.Owner is TableCell) || (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                            {
                                if ((A_0.Owner is TableCell) && (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                                {
                                    A_2.X += positioning.HorizPositionEx;
                                }
                                else if (!A_0.IsTextBox)
                                {
                                    A_2.X = ((A_1.Left + A_0.IndentFromLeft) + positioning.HorizPositionEx) - A_0.TableFormat.Paddings.Left;
                                }
                                else
                                {
                                    A_2.X = A_1.Left + positioning.HorizPositionEx;
                                }
                                break;
                            }
                            float num2 = A_2.X + positioning.HorizPositionEx;
                            if (num2 >= (A_2.X - this.method_35()))
                            {
                                A_2.X = num2;
                                break;
                            }
                            A_2.X -= this.method_35();
                            break;
                        }
                        case HorizontalPosition.Left:
                        {
                            if (!(A_0.Owner is TableCell) || (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                            {
                                if ((A_0.Owner is TableCell) && (A_0.Owner.Owner.Owner as Table).IsSDTTable)
                                {
                                    A_2.X += positioning.HorizPositionEx;
                                }
                                else if (!A_0.IsTextBox)
                                {
                                    A_2.X = ((A_1.Left + A_0.IndentFromLeft) + positioning.HorizPositionEx) - A_0.TableFormat.Paddings.Left;
                                }
                                else
                                {
                                    A_2.X = A_1.Left + positioning.HorizPositionEx;
                                }
                                break;
                            }
                            float num16 = A_2.X + positioning.HorizPositionEx;
                            if (num16 >= (A_2.X - this.method_35()))
                            {
                                A_2.X = num16;
                                break;
                            }
                            A_2.X -= this.method_35();
                            break;
                        }
                        case HorizontalPosition.Center:
                        {
                            float num3 = (A_0.Owner is TableCell) ? A_2.X : A_1.Left;
                            if (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)
                            {
                                if (A_0.LayoutWidth != 0f)
                                {
                                    Section section = this.table_0.method_55();
                                    if (A_0.IsInCell)
                                    {
                                        A_2.X = num3 + ((A_2.Width - A_0.LayoutWidth) / 2f);
                                    }
                                    else if (section != null)
                                    {
                                        A_2.X = num3 + ((section.PageSetup.ClientWidth - A_0.LayoutWidth) / 2f);
                                    }
                                    else
                                    {
                                        A_2.X = num3 + ((A_2.Width - A_0.LayoutWidth) / 2f);
                                    }
                                }
                                break;
                            }
                            A_2.X = num3 + (((A_2.Width * (100f - A_0.PreferredTableWidth.method_49())) / 100f) / 2f);
                            break;
                        }
                        case HorizontalPosition.Right:
                            if (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)
                            {
                                if (A_0.LayoutWidth != 0f)
                                {
                                    A_2.X = (A_2.Right - A_0.LayoutWidth) + A_0.TableFormat.Paddings.Right;
                                }
                                break;
                            }
                            A_2.X = A_2.Right - ((A_2.Width * A_0.PreferredTableWidth.method_49()) / 100f);
                            break;
                    }
                }
                else
                {
                    float num14 = ((A_0.TextBox.OwnerParagraph == null) || (A_0.TextBox.OwnerParagraph.Format.FirstLineIndent <= 0f)) ? 0f : A_0.TextBox.OwnerParagraph.Format.FirstLineIndent;
                    A_2.X += positioning.HorizPositionEx - num14;
                }
                goto Label_123C;

            case HorizontalRelation.Page:
                if ((!A_0.IsTextBox || A_0.IsTextBoxInTable) || ((A_0.TextBoxFormat.HorizontalOrigin != HorizontalOrigin.Column) || (A_0.TextBox.OwnerParagraph == null)))
                {
                    switch (positioning.HorizPositionAbs)
                    {
                        case HorizontalPosition.Center:
                        {
                            float num4 = (A_0.Owner is TableCell) ? A_2.X : 0f;
                            if (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)
                            {
                                if (A_0.LayoutWidth != 0f)
                                {
                                    Section section2 = this.table_0.method_55();
                                    if (A_0.Owner is TableCell)
                                    {
                                        A_2.X = num4 + ((A_2.Width - A_0.LayoutWidth) / 2f);
                                    }
                                    if (section2 != null)
                                    {
                                        A_2.X = num4 + ((section2.PageSetup.PageSize.Width - A_0.LayoutWidth) / 2f);
                                    }
                                    else
                                    {
                                        A_2.X = num4 + ((A_2.Width - A_0.LayoutWidth) / 2f);
                                    }
                                }
                            }
                            else
                            {
                                A_2.X = num4 + (((A_2.Width * (100f - A_0.PreferredTableWidth.method_49())) / 100f) / 2f);
                            }
                            goto Label_123C;
                        }
                        case HorizontalPosition.Right:
                        {
                            Section section3 = this.table_0.method_55();
                            float num11 = (A_0.Owner is TableCell) ? A_2.Right : ((section3 != null) ? section3.PageSetup.PageSize.Width : A_2.Right);
                            if (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)
                            {
                                if (A_0.LayoutWidth != 0f)
                                {
                                    if (A_0.Owner is TableCell)
                                    {
                                        A_2.X = (num11 - A_0.LayoutWidth) + A_0.TableFormat.Paddings.Left;
                                    }
                                    else
                                    {
                                        A_2.X = num11 - A_0.LayoutWidth;
                                    }
                                }
                            }
                            else
                            {
                                A_2.X = num11 - ((A_2.Width * A_0.PreferredTableWidth.method_49()) / 100f);
                            }
                            goto Label_123C;
                        }
                    }
                    if (A_0.Owner is TableCell)
                    {
                        A_2.X += positioning.HorizPositionEx - (A_0.Owner as TableCell).OwnerRow.OwnerTable.TableFormat.Paddings.Left;
                    }
                    else if (A_0.IsFrame)
                    {
                        A_2.X = positioning.HorizPositionEx + A_0.IndentFromLeft;
                    }
                    else if (A_0.IsTextBox)
                    {
                        A_2.X = positioning.HorizPositionEx;
                    }
                    else
                    {
                        A_2.X = (A_0.IndentFromLeft + positioning.HorizPositionEx) - A_0.TableFormat.Paddings.Left;
                    }
                }
                else
                {
                    Paragraph ownerParagraph = A_0.TextBox.OwnerParagraph;
                    float num5 = base.method_4().method_28().method_63(ownerParagraph, ((Interface1) ownerParagraph).imethod_0() as Class210, A_2.Location, base.method_4(), A_0.TextBoxFormat);
                    if (num5 == 0f)
                    {
                        if (A_0.Owner is TableCell)
                        {
                            A_2.X += positioning.HorizPositionEx;
                        }
                        else
                        {
                            A_2.X = positioning.HorizPositionEx;
                            if ((A_0.TextBox.OwnerParagraph != null) && (A_0.TextBox.OwnerParagraph.Format.LeftIndent != 0f))
                            {
                                float leftIndent = A_0.TextBox.OwnerParagraph.Format.LeftIndent;
                            }
                        }
                    }
                    else
                    {
                        A_2.X = num5 + A_0.TextBoxFormat.HorizontalPosition;
                    }
                }
                goto Label_123C;

            default:
                goto Label_123C;
        }
    Label_0A57:
        if (A_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
        {
            A_2.X = A_2.Right - ((A_2.Width * A_0.PreferredTableWidth.method_49()) / 100f);
        }
        else if (A_0.LayoutWidth != 0f)
        {
            A_2.X = (A_2.Right - A_0.LayoutWidth) + A_0.TableFormat.Paddings.Right;
        }
    Label_123C:
        if (y > A_2.Y)
        {
            A_2.Height += y - A_2.Y;
        }
        if ((A_2.Y < 0f) && ((!A_0.IsTextBox && A_0.TableFormat.WrapTextAround) || ((A_0.IsTextBox && (A_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)) && ((A_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && (A_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline)))))
        {
            A_2.Height += A_2.Y;
            A_2.Y = 0f;
        }
        if (((!this.table_0.IsTextBox && (positioning.VertPositionAbs != VerticalPosition.None)) && ((positioning.VertPositionEx == 0f) && (positioning.VertRelationTo == VerticalRelation.Page))) && !(this.table_0.OwnerTextBody is TableCell))
        {
            A_2.Height = (base.interface30_0 as Class304).method_4().Height;
        }
    }

    private void method_37()
    {
        this.stack_0.Push(base.method_4().method_28().method_21());
        this.stack_1.Push(base.method_4().method_28().method_23());
        this.stack_3.Push(Class616.list_0);
        this.stack_2.Push(Class616.list_1);
        base.method_4().method_28().method_22(new List<Class312>());
        Class616.list_0 = new List<RectangleF>();
        Class616.list_1 = new List<TextWrappingStyle>();
    }

    private void method_38()
    {
        if (this.stack_0.Count > 0)
        {
            base.method_4().method_28().method_22((List<Class312>) this.stack_0.Pop());
        }
        if (this.stack_1.Count > 0)
        {
            base.method_4().method_28().method_24((List<Class312>) this.stack_1.Pop());
        }
        if (this.stack_3.Count > 0)
        {
            Class616.list_0 = (List<RectangleF>) this.stack_3.Pop();
        }
        if (this.stack_2.Count > 0)
        {
            Class616.list_1 = (List<TextWrappingStyle>) this.stack_2.Pop();
        }
    }

    private void method_39()
    {
        RectangleF ef = base.class375_0.method_69();
        float num = 0f;
        float num2 = 0f;
        float num3 = 0f;
        float num4 = 0f;
        if (this.table_0.TableFormat.CellSpacingEx > 0f)
        {
            num = this.table_0.TableFormat.CellSpacingEx * 2f;
            num2 = this.table_0.TableFormat.Borders.Left.LineWidth / 2f;
            num3 = this.table_0.TableFormat.Borders.Right.LineWidth / 2f;
            num4 = this.table_0.TableFormat.Borders.Top.LineWidth / 2f;
            float single1 = this.table_0.TableFormat.Borders.Bottom.LineWidth / 2f;
        }
        ef.X -= num2;
        ef.Y -= num4;
        ef.Width += (num + num2) + num3;
        ef.Height += (num + num4) + num3;
        if (this.table_0.IsTextBox && (this.table_0.TextBoxFormat.Rotation != 0f))
        {
            PointF tf;
            RectangleF ef2 = base.class375_0.method_69();
            if (this.table_0.TextBoxFormat.IsFitShapeToText)
            {
                ef2.Height = Math.Max(ef2.Height, this.table_0.TextBoxFormat.Height);
            }
            PointF[] pts = new PointF[] { ef2.Location, new PointF(ef2.Right, ef2.Y), new PointF(ef2.X, ef2.Bottom), new PointF(ef2.Right, ef2.Bottom) };
            if (this.table_0.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Inline)
            {
                tf = new PointF(ef2.X + (ef2.Height / 2f), ef2.Y + (ef2.Height / 2f));
            }
            else
            {
                tf = new PointF(ef2.X + (ef2.Width / 2f), ef2.Y + (ef2.Height / 2f));
            }
            Matrix matrix = new Matrix();
            matrix.Translate(tf.X, tf.Y);
            matrix.Rotate(this.table_0.TextBoxFormat.Rotation);
            matrix.Translate(-tf.X, -tf.Y);
            matrix.TransformPoints(pts);
            float x = pts[0].X;
            float y = pts[0].Y;
            float num8 = pts[0].X;
            float num9 = pts[0].Y;
            foreach (PointF tf2 in pts)
            {
                x = Math.Min(x, tf2.X);
                num8 = Math.Max(num8, tf2.X);
                y = Math.Min(y, tf2.Y);
                num9 = Math.Max(num9, tf2.Y);
            }
            ef = new RectangleF(x, y, num8 - x, num9 - y);
        }
        this.table_0.rectangleF_1 = ef;
        base.class375_0.method_70(ef);
        if (!this.method_32().imethod_9() && this.method_32().imethod_13())
        {
            this.method_41();
        }
    }

    private RectangleF method_40(TextBoxFormat A_0, RectangleF A_1)
    {
        float x = A_1.X;
        float y = A_1.Y;
        float width = base.method_4().method_28().method_28().PageSize.Width;
        float height = base.method_4().method_28().method_28().PageSize.Height;
        if (A_1.X < 0f)
        {
            x = 0f;
        }
        else if ((A_1.X + A_0.Width) > width)
        {
            x = width - A_0.Width;
        }
        if ((A_1.Y + A_0.Height) > height)
        {
            y = height - A_0.Height;
        }
        else if (A_1.Y < 0f)
        {
            y = 0f;
        }
        if ((x == A_1.X) && (y == A_1.Y))
        {
            return new RectangleF();
        }
        return new RectangleF(x, y, A_1.Width, A_1.Height);
    }

    private void method_41()
    {
        float num = 0f;
        float num2 = 0f;
        MarginsF sf = this.method_42();
        float num3 = 0f;
        if (sf != null)
        {
            num3 = ((base.interface30_0 as Class304).method_4().Height + sf.Top) + sf.Bottom;
        }
        if ((base.class375_0.method_69().Height < (base.interface30_0 as Class304).method_4().Height) && (this.method_32().imethod_15().VertRelationTo != VerticalRelation.Page))
        {
            num2 = (base.interface30_0 as Class304).method_4().Bottom - base.class375_0.method_69().Bottom;
        }
        else if (base.class375_0.method_69().Height < num3)
        {
            num2 = num3 - base.class375_0.method_69().Bottom;
        }
        if ((((num2 != 0f) && !this.table_0.IsTextBox) && ((!(this.table_0.OwnerTextBody is TableCell) || !((this.table_0.OwnerTextBody as TableCell).Owner.Owner is Table)) || ((this.table_0.OwnerTextBody as TableCell).Owner.Owner as Table).IsSDTTable)) || ((this.table_0.IsTextBox && (this.method_32().imethod_15().VertRelationTo != VerticalRelation.Page)) && (this.method_32().imethod_15().VertPositionAbs != VerticalPosition.None)))
        {
            if ((this.method_32().imethod_15().VertPositionAbs != VerticalPosition.Bottom) && (this.method_32().imethod_15().VertPositionAbs != VerticalPosition.Outside))
            {
                if (this.method_32().imethod_15().VertPositionAbs == VerticalPosition.Center)
                {
                    base.class375_0.method_94((double) num, (double) (num2 / 2f), false);
                }
            }
            else
            {
                base.class375_0.method_94((double) num, (double) num2, false);
            }
        }
    }

    private MarginsF method_42()
    {
        Section section = null;
        return this.method_43(ref section);
    }

    private MarginsF method_43(ref Section A_0)
    {
        ISection section = null;
        MarginsF margins = null;
        IDocumentObject owner = this.table_0.Owner;
        if (owner == null)
        {
            owner = this.table_0.ClonedOwner;
        }
        if (owner != null)
        {
            while (owner.DocumentObjectType != DocumentObjectType.Section)
            {
                if (owner.Owner == null)
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner.DocumentObjectType == DocumentObjectType.Section)
            {
                section = owner as Section;
                if (section != null)
                {
                    margins = section.PageSetup.Margins;
                    A_0 = owner as Section;
                }
            }
        }
        return margins;
    }

    private void method_44(SizeF A_0, ref RectangleF A_1)
    {
        if ((((this.table_0.IsTextBox && !this.table_0.TextBoxFormat.AllowOverlap) && (((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind) && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && ((this.table_0.TextBox as TextBox).ShapeInfo == null))) || !this.table_0.IsTextBox) && (((Class616.list_0.Count > 0) && !(base.interface30_0 as Class304).method_10()) && !this.table_0.IsFrame))
        {
            RectangleF ef6 = (base.interface30_0 as Class304).method_4();
            for (int i = 0; i < Class616.list_0.Count; i++)
            {
                RectangleF ef37;
                RectangleF ef18 = Class616.list_0[i];
                if (ef6.X > (ef18.Right + 16f))
                {
                    continue;
                }
                RectangleF ef19 = Class616.list_0[i];
                if (ef6.Right < (ef19.X - 16f))
                {
                    continue;
                }
                if (Class616.list_0.Count <= 0)
                {
                    goto Label_076A;
                }
                RectangleF ef17 = Class616.list_0[i];
                if (A_1.Y >= ef17.Y)
                {
                    RectangleF ef3 = Class616.list_0[i];
                    if (A_1.Y < ef3.Bottom)
                    {
                        goto Label_019B;
                    }
                }
                RectangleF ef12 = Class616.list_0[i];
                if ((A_1.Y + A_0.Height) < ef12.Y)
                {
                    goto Label_076A;
                }
                RectangleF ef13 = Class616.list_0[i];
                if ((A_1.Y + A_0.Height) >= ef13.Bottom)
                {
                    goto Label_076A;
                }
            Label_019B:
                if (((((TextWrappingStyle) Class616.list_1[i]) == TextWrappingStyle.Inline) || (((TextWrappingStyle) Class616.list_1[i]) == TextWrappingStyle.TopAndBottom)) || ((((TextWrappingStyle) Class616.list_1[i]) == TextWrappingStyle.InFrontOfText) || (((TextWrappingStyle) Class616.list_1[i]) == TextWrappingStyle.Behind)))
                {
                    goto Label_076A;
                }
                RectangleF ef23 = Class616.list_0[i];
                if (A_1.X >= ef23.X)
                {
                    RectangleF ef35 = Class616.list_0[i];
                    if (A_1.X < ef35.Right)
                    {
                        RectangleF ef36 = Class616.list_0[i];
                        if ((A_1.Width - ef36.Right) < this.table_0.LayoutWidth)
                        {
                            RectangleF ef26 = Class616.list_0[i];
                            A_1.Y = ef26.Bottom;
                            RectangleF ef27 = Class616.list_0[i];
                            A_1.Height -= ef27.Height;
                            this.method_45(ref A_1);
                            base.method_16(A_1);
                        }
                        else
                        {
                            RectangleF ef21 = Class616.list_0[i];
                            float num2 = A_1.Width - (ef21.Right - A_1.X);
                            if (num2 < 16f)
                            {
                                RectangleF ef22 = Class616.list_0[i];
                                float num3 = this.rectangleF_1.Right - ef22.Right;
                                if (num3 < A_1.Width)
                                {
                                    RectangleF ef15 = Class616.list_0[i];
                                    A_1.Y = ef15.Bottom;
                                    RectangleF ef16 = Class616.list_0[i];
                                    A_1.Height -= ef16.Bottom - A_1.Y;
                                    this.method_45(ref A_1);
                                    base.method_16(A_1);
                                }
                                else
                                {
                                    if (this.table_0.TableFormat.HorizontalAlignment == RowAlignment.Center)
                                    {
                                        RectangleF ef30 = Class616.list_0[i];
                                        float num4 = ((this.rectangleF_1.Right - ef30.Right) - A_1.Width) / 2f;
                                        RectangleF ef31 = Class616.list_0[i];
                                        A_1.X = ef31.Right + num4;
                                    }
                                    else
                                    {
                                        RectangleF ef40 = Class616.list_0[i];
                                        A_1.X = ef40.Right;
                                    }
                                    this.method_45(ref A_1);
                                    base.method_16(A_1);
                                }
                            }
                            else
                            {
                                if (this.table_0.TableFormat.HorizontalAlignment == RowAlignment.Center)
                                {
                                    RectangleF ef43 = Class616.list_0[i];
                                    float num5 = ((this.rectangleF_1.Right - ef43.Right) - A_1.Width) / 2f;
                                    RectangleF ef44 = Class616.list_0[i];
                                    A_1.X = ef44.Right + num5;
                                }
                                else
                                {
                                    RectangleF ef42 = Class616.list_0[i];
                                    A_1.X = ef42.Right;
                                }
                                this.method_45(ref A_1);
                                base.method_16(A_1);
                            }
                        }
                        continue;
                    }
                }
                RectangleF ef10 = Class616.list_0[i];
                if ((A_1.Right - ef10.Left) > 0f)
                {
                    RectangleF ef11 = Class616.list_0[i];
                    if ((A_1.Right - ef11.Right) < A_1.Width)
                    {
                        RectangleF ef41 = Class616.list_0[i];
                        if (A_1.Y < ef41.Y)
                        {
                            RectangleF ef39 = Class616.list_0[i];
                            if ((A_1.Y + A_0.Height) < ef39.Y)
                            {
                                goto Label_0551;
                            }
                        }
                        RectangleF ef45 = Class616.list_0[i];
                        A_1.Y = ef45.Bottom;
                        RectangleF ef46 = Class616.list_0[i];
                        A_1.Height -= ef46.Height;
                        this.method_45(ref A_1);
                        base.method_16(A_1);
                        continue;
                    }
                }
            Label_0551:
                ef37 = Class616.list_0[i];
                if (ef37.X > A_1.X)
                {
                    RectangleF ef38 = Class616.list_0[i];
                    if (A_1.Right > ef38.X)
                    {
                        RectangleF ef7 = Class616.list_0[i];
                        A_1.Width = ef7.X - A_1.X;
                        if (A_1.Width < 16f)
                        {
                            RectangleF ef2 = Class616.list_0[i];
                            A_1.Width = base.class774_0.method_13().Right - ef2.Right;
                            if (A_1.Width < 16f)
                            {
                                RectangleF ef47 = Class616.list_0[i];
                                A_1.Y = ef47.Bottom;
                                RectangleF ef48 = Class616.list_0[i];
                                A_1.Height -= ef48.Height;
                                this.method_45(ref A_1);
                                base.method_16(A_1);
                            }
                        }
                        else
                        {
                            this.method_45(ref A_1);
                            base.method_16(A_1);
                        }
                        continue;
                    }
                }
                RectangleF ef28 = Class616.list_0[i];
                if (A_1.X > ef28.X)
                {
                    RectangleF ef29 = Class616.list_0[i];
                    if (A_1.X > ef29.Right)
                    {
                        A_1.Width = base.class774_0.method_11().Width;
                        this.method_45(ref A_1);
                        base.method_16(A_1);
                        continue;
                    }
                }
                RectangleF ef24 = Class616.list_0[i];
                if (A_1.X > ef24.X)
                {
                    RectangleF ef25 = Class616.list_0[i];
                    if (A_1.X < ef25.Right)
                    {
                        RectangleF ef4 = Class616.list_0[i];
                        A_1.Width -= ef4.Right - A_1.X;
                        RectangleF ef5 = Class616.list_0[i];
                        A_1.X = ef5.Right;
                        this.method_45(ref A_1);
                        base.method_16(A_1);
                    }
                }
                continue;
            Label_076A:
                if (Class616.list_0.Count <= 0)
                {
                    continue;
                }
                RectangleF ef32 = Class616.list_0[i];
                if (A_1.Y >= ef32.Y)
                {
                    RectangleF ef14 = Class616.list_0[i];
                    if (A_1.Y < ef14.Bottom)
                    {
                        goto Label_07FD;
                    }
                }
                RectangleF ef8 = Class616.list_0[i];
                if ((A_1.Y + A_0.Height) < ef8.Y)
                {
                    continue;
                }
                RectangleF ef9 = Class616.list_0[i];
                if ((A_1.Y + A_0.Height) >= ef9.Bottom)
                {
                    continue;
                }
            Label_07FD:
                if (((TextWrappingStyle) Class616.list_1[i]) == TextWrappingStyle.TopAndBottom)
                {
                    RectangleF ef33 = Class616.list_0[i];
                    A_1.Y = ef33.Bottom;
                    RectangleF ef34 = Class616.list_0[i];
                    A_1.Height -= ef34.Height;
                    this.method_45(ref A_1);
                    base.method_16(A_1);
                }
            }
        }
    }

    private void method_45(ref RectangleF A_0)
    {
        float num = (this.table_0.TableFormat.CellSpacingEx > 0f) ? (this.table_0.TableFormat.CellSpacingEx * 2f) : 0f;
        A_0 = new RectangleF(A_0.X - num, A_0.Y, A_0.Width + num, A_0.Height);
    }

    private void method_46()
    {
        int num = this.method_33().imethod_6();
        this.double_0 = new double[num];
        this.double_1 = new double[num];
        ArrayList list = this.method_84(this.table_0);
        for (int i = this.double_0.Length - 1; i >= 1; i--)
        {
            if (i < list.Count)
            {
                this.double_0[i] = Convert.ToDouble(list[i]) - Convert.ToDouble(list[i - 1]);
            }
            else
            {
                this.double_0[i] = 0.0;
            }
        }
        this.double_0[0] = Convert.ToDouble(list[0]);
    }

    private bool method_47()
    {
        if ((this.method_34() + 1) < this.method_33().imethod_5())
        {
            this.int_3 = -1;
            this.method_59();
            this.class375_1 = new Class375(this.method_33().imethod_8(this.method_34()));
            this.class375_1.method_70(new RectangleF(base.class774_0.method_13().Location, new SizeF()));
            this.class375_1.method_73().imethod_0();
            return true;
        }
        return false;
    }

    private void method_48()
    {
        Class615 class2;
        this.class65_0 = new Class65[this.table_0.Rows[this.method_34()].Cells.Count];
        new ArrayList();
        if ((this.table_0.Rows[this.method_34()].RowFormat.GridBeforeWidth.method_49() <= 0f) && (this.table_0.Rows[this.method_34()].RowFormat.GridAfterWidth.method_49() <= 0f))
        {
            if (this.bool_10)
            {
                this.bool_10 = false;
                RectangleF ef = new RectangleF(this.rectangleF_0.X, base.class774_0.method_13().Y, this.rectangleF_0.Width, base.class774_0.method_13().Height);
                this.method_45(ref ef);
                base.method_20(ef, base.class774_0.method_11());
            }
        }
        else
        {
            this.bool_10 = true;
            RectangleF ef4 = new RectangleF(this.rectangleF_0.X, base.class774_0.method_13().Y, this.rectangleF_0.Width, base.class774_0.method_13().Height);
            float num = 0f;
            float num3 = 0f;
            if (this.table_0.Rows[this.method_34()].RowFormat.GridBeforeWidth.method_49() > 0f)
            {
                num = this.table_0.Rows[this.method_34()].RowFormat.GridBeforeWidth.method_49() / 20f;
                ef4.X += num;
                ef4.Width -= num;
            }
            if (this.table_0.Rows[this.method_34()].RowFormat.GridAfterWidth.method_49() > 0f)
            {
                num3 = this.table_0.Rows[this.method_34()].RowFormat.GridAfterWidth.method_49() / 20f;
                ef4.Width -= num3;
            }
            float num2 = 0f;
            switch (this.table_0.TableFormat.HorizontalAlignment)
            {
                case RowAlignment.Center:
                    if (num > 0f)
                    {
                        num2 -= num / 2f;
                    }
                    if (num3 > 0f)
                    {
                        num2 += num3 / 2f;
                    }
                    ef4 = new RectangleF(ef4.X + num2, ef4.Y, ef4.Width, ef4.Height);
                    break;

                case RowAlignment.Right:
                    if (num > 0f)
                    {
                        num2 -= num;
                    }
                    if (num3 > 0f)
                    {
                        num2 += num3;
                    }
                    ef4 = new RectangleF(ef4.X + num2, ef4.Y, ef4.Width, ef4.Height);
                    break;
            }
            this.method_45(ref ef4);
            base.method_20(ef4, base.class774_0.method_11());
        }
    Label_04CA:
        class2 = this.method_96();
        Class774 class5 = null;
        if (class2 != null)
        {
            Class211 class3 = class2.method_8().imethod_0() as Class211;
            Class212 class4 = class2.method_2() as Class212;
            TableCell cell1 = this.table_0.Rows[this.method_34()].Cells[this.int_3];
            class5 = this.method_103((class3 != null) ? class3.method_103() : false, this.method_34(), this.int_3);
            class4.method_131((float) class5.method_2());
            class4.method_129(new RectangleF(class5.method_13().Left + ((float) class2.method_2().imethod_0().method_0()), class5.method_13().Top, class5.method_13().Width - ((float) class2.method_2().imethod_0().method_0()), class5.method_13().Height));
            if (((Class59.smethod_5(class5.method_3(), (double) base.class774_0.method_13().Height, 0.005) > 0) && (Class59.smethod_5((double) base.class774_0.method_13().Height, (double) base.class774_0.method_11().Height, 0.005) != 0)) && !this.table_0.IsFrame)
            {
                (class2.method_8().imethod_0() as Class212).method_135(false);
                base.layoutState_0 = LayoutState.NotFitted;
            }
            else
            {
                this.method_92(class2, class5.method_11());
                this.method_98(class2);
            }
            if (base.method_1() == LayoutState.Unknown)
            {
                goto Label_04CA;
            }
        }
    }

    private void method_49()
    {
        this.int_5 = 0;
        this.int_6 = 0;
        bool flag = true;
        TableRow row = this.method_33().imethod_8(this.method_34()) as TableRow;
        Table ownerTable = row.OwnerTable;
        if ((base.layoutState_0 != LayoutState.Unknown) || !this.bool_7)
        {
            if (((base.class375_0.method_74().Count > 0) && (ownerTable != null)) && !ownerTable.IsFrame)
            {
                if (this.method_31().Count > 0)
                {
                    List<Class375> list = new List<Class375>();
                    foreach (Class375 class5 in this.method_31().Values)
                    {
                        list.Add(class5);
                    }
                    foreach (Class375 class6 in list)
                    {
                        this.method_76(class6);
                    }
                    list.Clear();
                    list = null;
                }
                if (!ownerTable.TableFormat.WrapTextAround || !ownerTable.DontBreakWrappedTables)
                {
                    bool flag5 = true;
                    if (!ownerTable.TableFormat.WrapTextAround)
                    {
                        int num4 = this.int_2;
                        this.method_56(this.table_0, ref this.int_2);
                        if ((flag5 = num4 > this.int_2) && (this.int_2 > 0))
                        {
                            int num5 = num4 - this.int_2;
                            if ((base.class375_0.method_74().Count - num5) > 0)
                            {
                                while (num5 > 0)
                                {
                                    base.class375_0.method_74().method_12(base.class375_0.method_74().Count - 1);
                                    num5--;
                                }
                            }
                            else
                            {
                                this.int_2 = num4;
                            }
                        }
                        else if (!flag5)
                        {
                            flag5 = true;
                        }
                        else
                        {
                            this.int_2 = num4;
                        }
                    }
                    base.interface1_0 = new Class820(this.method_33(), this.int_2 + 1);
                    if (!flag5)
                    {
                        base.layoutState_0 = LayoutState.NotFitted;
                    }
                    else
                    {
                        this.method_32().imethod_10(true);
                        base.layoutState_0 = LayoutState.Splitted;
                    }
                    this.method_50(this.class375_1);
                    this.method_51(this.class375_1);
                    return;
                }
                if (!((Interface4) ownerTable).imethod_3().imethod_9())
                {
                    base.interface1_0 = new Class820(this.method_33(), 0);
                    base.layoutState_0 = LayoutState.NotFitted;
                    ((Interface4) ownerTable).imethod_3().imethod_10(true);
                    return;
                }
                base.layoutState_0 = LayoutState.Unknown;
            }
            return;
        }
        this.method_61();
        if (row.interface23_0.imethod_40())
        {
            return;
        }
        if ((!ownerTable.TableFormat.WrapTextAround || !ownerTable.DontBreakWrappedTables) && (this.layoutState_1 == LayoutState.Splitted))
        {
            int num11 = (base.class375_0 != null) ? base.class375_0.method_74().Count : 0;
            if (((num11 <= 0) || ((num11 - this.int_0) > 0)) || row.RowFormat.IsBreakAcrossPages)
            {
                bool flag3 = this.method_54(this.class65_0);
                int num = this.int_2;
                if (flag3)
                {
                    this.method_56(this.table_0, ref this.int_2);
                    if (this.int_2 == 0)
                    {
                        flag3 = false;
                        this.int_2 = num;
                    }
                    else if (ownerTable.TableFormat.WrapTextAround)
                    {
                        this.int_2 = num;
                    }
                }
                if ((!row.RowFormat.IsBreakAcrossPages || row.IsHeader) || flag3)
                {
                    bool flag2 = true;
                    if (flag3 && !ownerTable.TableFormat.WrapTextAround)
                    {
                        if ((flag2 = num > this.int_2) && (this.int_2 > 0))
                        {
                            int num19 = num - this.int_2;
                            if ((base.class375_0.method_74().Count - num19) > 0)
                            {
                                while (num19 > 0)
                                {
                                    base.class375_0.method_74().method_12(base.class375_0.method_74().Count - 1);
                                    num19--;
                                }
                            }
                            else
                            {
                                this.int_2 = num;
                            }
                        }
                        else if (!flag2)
                        {
                            flag2 = true;
                        }
                        else
                        {
                            this.int_2 = num;
                        }
                    }
                    if (row.RowFormat.IsBreakAcrossPages || row.IsRowCanSplit)
                    {
                        base.interface1_0 = new Class820(this.method_33(), this.method_34() + 1);
                        row.IsRowCanSplit = false;
                        if (!flag2)
                        {
                            base.layoutState_0 = LayoutState.NotFitted;
                        }
                        else
                        {
                            this.method_32().imethod_10(true);
                            base.layoutState_0 = LayoutState.Splitted;
                        }
                        flag = false;
                        this.method_50(this.class375_1);
                        this.method_51(this.class375_1);
                    }
                }
                else
                {
                    this.method_32().imethod_10(true);
                    bool flag4 = false;
                    TableRow nextSibling = row.NextSibling as TableRow;
                    Class65[] classArray2 = new Class65[this.class65_0.Length];
                    float minValue = float.MinValue;
                    float num9 = (row.HeightType == TableRowHeightType.AtLeast) ? row.Height : float.MinValue;
                    if (nextSibling != null)
                    {
                        flag4 = true;
                        int num3 = 0;
                        foreach (Class65 class2 in this.class65_0)
                        {
                            if ((class2 == null) || (nextSibling.Cells.Count <= num3))
                            {
                                flag4 = false;
                                break;
                            }
                            TableCell cell = nextSibling.Cells[num3];
                            if (((class2.method_0() != null) || ((minValue != float.MinValue) && (Class59.smethod_1((double) num9, (double) minValue, false) < 0))) && (cell.CellFormat.VerticalMerge != CellMerge.Continue))
                            {
                                flag4 = false;
                                break;
                            }
                            if ((class2.method_0() == null) && (num9 != float.MinValue))
                            {
                                minValue = Math.Max(this.class375_1.method_74().method_4(num3).method_69().Height, minValue);
                            }
                            classArray2[num3] = (class2.method_0() != null) ? new Class65(class2.method_2(), class2.method_0(), class2.method_3()) : new Class65(cell, cell.FirstChild as Interface1, 0);
                            num3++;
                        }
                    }
                    if (flag4)
                    {
                        minValue = Math.Max(minValue, num9);
                        if (Class59.smethod_1((double) this.class375_1.method_69().Height, (double) minValue, false) > 0)
                        {
                            for (int i = 0; i < classArray2.Length; i++)
                            {
                                TableCell cell2 = classArray2[i].method_2() as TableCell;
                                if (cell2.OwnerRow == row)
                                {
                                    Class375 class3 = this.class375_1.method_74().method_4(i);
                                    Class375 class4 = class3.method_74().method_0();
                                    while (Class59.smethod_1((double) class3.method_69().Height, (double) minValue, false) > 0)
                                    {
                                        if (class4.method_74().Count <= 0)
                                        {
                                            break;
                                        }
                                        class3.method_70(new RectangleF(class3.method_69().Location, new SizeF(class3.method_69().Width, class3.method_69().Height - class4.method_74().method_0().method_69().Height)));
                                        class4.method_70(new RectangleF(class4.method_69().Location, new SizeF(class4.method_69().Width, class4.method_69().Height - class4.method_74().method_0().method_69().Height)));
                                        int num12 = (classArray2[i].method_3() > 0) ? (classArray2[i].method_3() - 1) : 0;
                                        classArray2[i] = new Class65(classArray2[i].method_2(), cell2.ChildObjects[num12] as Interface1, num12);
                                        this.method_50(class4.method_74().method_0());
                                        class3.method_74().method_0().method_74().method_11(class4.method_74().method_0());
                                    }
                                }
                            }
                        }
                        this.class375_1.method_70(new RectangleF(this.class375_1.method_69().Location, new SizeF(this.class375_1.method_69().Width, minValue)));
                        base.interface1_0 = new Class820(this.method_33(), this.method_34() + 2, classArray2);
                    }
                    else
                    {
                        base.interface1_0 = new Class820(this.method_33(), this.method_34() + 1, this.class65_0);
                    }
                    base.layoutState_0 = LayoutState.Splitted;
                }
            }
        }
        if (flag)
        {
            for (int j = 0; j < this.table_0.Rows[this.method_34()].Cells.Count; j++)
            {
                this.method_63(j);
            }
            base.class375_0.method_74().method_7(this.class375_1);
            this.method_108();
            this.method_102();
            this.method_109();
            if (((ownerTable.PreferredTableWidth.method_51() == FtsWidth.Point) && (ownerTable.TableFormat.HorizontalAlignment == RowAlignment.Left)) && ((row.RowFormat.GridAfterWidth.method_49() > 0f) || (row.RowFormat.GridBeforeWidth.method_49() > 0f)))
            {
                switch (ownerTable.TableFormat.HorizontalAlignment)
                {
                    case RowAlignment.Left:
                        switch (row.RowFormat.HorizontalAlignment)
                        {
                            case RowAlignment.Center:
                            {
                                float num13 = (this.rectangleF_1.Width - this.class375_1.method_69().Width) / 2f;
                                float num14 = (this.rectangleF_1.Left - this.rectangleF_0.Left) + num13;
                                this.class375_1.method_94((double) num14, 0.0, true);
                                goto Label_08B2;
                            }
                            case RowAlignment.Right:
                            {
                                float num17 = this.rectangleF_1.Right - this.class375_1.method_69().Right;
                                float num18 = (this.rectangleF_1.Right - this.rectangleF_0.Right) + num17;
                                this.class375_1.method_94((double) num18, 0.0, true);
                                goto Label_08B2;
                            }
                        }
                        break;

                    case RowAlignment.Center:
                        switch (row.RowFormat.HorizontalAlignment)
                        {
                            case RowAlignment.Center:
                            {
                                float num15 = (this.rectangleF_1.Width - this.class375_1.method_69().Width) / 2f;
                                float num16 = (this.rectangleF_1.Left - this.rectangleF_0.Left) + num15;
                                this.class375_1.method_94((double) num16, 0.0, true);
                                goto Label_08B2;
                            }
                            case RowAlignment.Right:
                            {
                                float num21 = this.rectangleF_1.Right - this.class375_1.method_69().Right;
                                float num22 = (this.rectangleF_1.Right - this.rectangleF_0.Right) + num21;
                                this.class375_1.method_94((double) num22, 0.0, true);
                                goto Label_08B2;
                            }
                        }
                        break;
                }
            }
        }
    Label_08B2:
        if (this.class375_1.method_30() || this.class375_1.method_73().imethod_0().imethod_28())
        {
            if (this.method_34() < (this.method_33().imethod_5() - 2))
            {
                base.interface1_0 = new Class820(this.method_33(), this.method_34() + 2);
            }
            base.layoutState_0 = LayoutState.Splitted;
            this.method_50(this.class375_1);
            this.method_51(this.class375_1);
        }
    }

    private void method_50(Class375 A_0)
    {
        if (A_0 != null)
        {
            foreach (Class375 class2 in A_0.method_74())
            {
                if ((((class2.method_73() is Table) && (class2.method_73() as Table).IsTextBox) && (((class2.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Behind) || ((class2.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.InFrontOfText))) || ((class2.method_73() is DocPicture) && (((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.InFrontOfText) || ((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Behind))))
                {
                    base.method_4().method_28().method_42(class2);
                    base.method_4().method_28().method_45(class2);
                }
                else
                {
                    this.method_50(class2);
                }
            }
        }
    }

    private void method_51(Class375 A_0)
    {
        if (A_0 != null)
        {
            foreach (Class375 class2 in A_0.method_74())
            {
                if (class2.method_73() is Footnote)
                {
                    base.method_4().method_28().method_39(class2);
                }
                else
                {
                    this.method_51(class2);
                }
            }
        }
    }

    private TableCell method_52(DocumentObject A_0)
    {
        for (DocumentObject obj2 = A_0; obj2 != null; obj2 = obj2.Owner)
        {
            if (obj2.Owner is TableCell)
            {
                return (obj2.Owner as TableCell);
            }
        }
        return null;
    }

    private void method_53(TableCell A_0)
    {
        for (int i = 0; i < base.method_4().method_28().method_21().Count; i++)
        {
            int num2;
            RowFormat.TablePositioning positioning;
            int num3;
            Class312 class3;
            Class312 class2 = base.method_4().method_28().method_21()[i];
            if ((class2.method_4() != null) && (this.method_52(class2.method_4() as DocumentObject) == A_0))
            {
                if (!(class2.method_4() is TextBox))
                {
                    goto Label_011E;
                }
                class2.method_4();
                num3 = 0;
                int count = Class616.list_0.Count;
                while (num3 < count)
                {
                    if (Class616.list_0[num3] == class2.method_0())
                    {
                        goto Label_009C;
                    }
                    num3++;
                }
            }
            continue;
        Label_009C:
            class3 = base.method_4().method_28().method_21()[i];
            base.method_4().method_28().method_21().Remove(class3);
            if (base.method_4().method_28().method_23().Contains(class3))
            {
                base.method_4().method_28().method_23().Remove(class3);
            }
            Class616.list_0.RemoveAt(num3);
            Class616.list_1.RemoveAt(num3);
            i--;
            continue;
        Label_011E:
            if (class2.method_4() is Table)
            {
                class2.method_4();
                positioning = (class2.method_4() as Interface4).imethod_3().imethod_15();
                num2 = 0;
                int num5 = Class616.list_0.Count;
                while (num2 < num5)
                {
                    RectangleF ef = Class616.list_0[num2];
                    RectangleF ef2 = new RectangleF(ef.X - positioning.DistanceFromLeft, ef.Y - positioning.DistanceFromTop, (ef.Width + positioning.DistanceFromRight) + positioning.DistanceFromLeft, (ef.Height + positioning.DistanceFromBottom) + positioning.DistanceFromTop);
                    if (ef2 == class2.method_0())
                    {
                        goto Label_01DB;
                    }
                    num2++;
                }
            }
            continue;
        Label_01DB:
            if ((positioning.VertPositionEx >= 0f) || ((positioning.VertPositionEx < 0f) && (positioning.VertRelationTo != VerticalRelation.Paragraph)))
            {
                Class312 item = base.method_4().method_28().method_21()[i];
                base.method_4().method_28().method_21().Remove(item);
                if (base.method_4().method_28().method_23().Contains(item))
                {
                    base.method_4().method_28().method_23().Remove(item);
                }
                Class616.list_0.RemoveAt(num2);
                Class616.list_1.RemoveAt(num2);
                i--;
            }
        }
    }

    private bool method_54(Class65[] A_0)
    {
        if ((A_0 != null) && (A_0.Length > 0))
        {
            Class65 class2 = A_0[0];
            if (((class2 != null) && (class2.method_2() is TableCell)) && ((((class2.method_0() == null) && this.method_55(A_0)) && (((class2.method_2() as TableCell).Paragraphs.Count > 0) && (class2.method_2() as TableCell).Paragraphs[0].Format.KeepFollow)) || ((class2.method_3() == 0) && (((class2.method_0() is Paragraph) && (class2.method_0() as Paragraph).Format.KeepFollow) || (((class2.method_0() is Class65) && ((class2.method_0() as Class65).method_2() is Paragraph)) && ((class2.method_0() as Class65).method_2() as Paragraph).Format.KeepFollow)))))
            {
                return true;
            }
        }
        return false;
    }

    private bool method_55(Class65[] A_0)
    {
        int index = 1;
        int length = A_0.Length;
        while (index < length)
        {
            Class65 class2 = A_0[index];
            if ((((class2 != null) && (class2.method_2() is TableCell)) && (class2.method_3() == 0)) && (((class2.method_0() is Paragraph) && (class2.method_0() as Paragraph).Format.KeepFollow) || (((class2.method_0() is Class65) && ((class2.method_0() as Class65).method_2() is Paragraph)) && ((class2.method_0() as Class65).method_2() as Paragraph).Format.KeepFollow)))
            {
                return true;
            }
            index++;
        }
        return false;
    }

    private void method_56(Table A_0, ref int A_1)
    {
        if ((A_1 >= 1) && (A_0.Rows.Count >= A_1))
        {
            for (int i = A_1 - 1; i > -1; i--)
            {
                TableRow row = A_0.Rows[i];
                if (((row.Cells.Count <= 0) || (row.Cells[0].Paragraphs.Count <= 0)) || !row.Cells[0].Paragraphs[0].Format.KeepFollow)
                {
                    break;
                }
                A_1--;
            }
        }
    }

    private bool method_57(Class375 A_0)
    {
        if (A_0 != null)
        {
            Class375 class2 = A_0;
            while (class2.method_74().Count > 0)
            {
                class2 = class2.method_74().method_4(class2.method_74().Count - 1);
            }
            if (((class2 != null) && (class2.method_73() is Break)) && ((class2.method_73() as Break).BreakType == BreakType.PageBreak))
            {
                return true;
            }
        }
        return false;
    }

    private void method_58(Class615 A_0)
    {
        RectangleF ef = this.class375_1.method_69();
        RectangleF ef2 = this.class375_2.method_69();
        double num4 = base.bool_0 ? 0.0 : A_0.method_6();
        double num = base.bool_0 ? 0.0 : A_0.method_7();
        SizeF size = ef2.Size;
        double num3 = Math.Max(ef2.Right + num4, (double) ef.Right);
        if (((A_0.method_8() is TableCell) && (A_0.method_8() as TableCell).OwnerRow.OwnerTable.IsFrame) && (((A_0.method_8() as TableCell).OwnerRow.OwnerTable.FrameFormat.FrameHeightRule != FrameSizeRule.Auto) && ((A_0.method_8() as TableCell).OwnerRow.OwnerTable.FrameFormat.FrameHeight != 0)))
        {
            float frameHeightEx = (A_0.method_8() as TableCell).OwnerRow.OwnerTable.FrameFormat.FrameHeightEx;
            double num5 = 0.0;
            num5 = Math.Max(ef2.Bottom + num, (double) ef.Bottom);
            size = new SizeF(((float) num3) - ef.Left, ((float) num5) - ef.Top);
        }
        else
        {
            double num2 = Math.Max(ef2.Bottom + num, (double) ef.Bottom);
            size = new SizeF(((float) num3) - ef.Left, ((float) num2) - ef.Top);
        }
        this.class375_1.method_70(new RectangleF(ef.Location, size));
    }

    private void method_59()
    {
        if (!this.bool_6)
        {
            this.int_2++;
        }
        else
        {
            Table table = this.method_33() as Table;
            TableRow row = table.Rows[this.int_2];
            if ((row == null) || row.IsHeader)
            {
                this.bool_6 = false;
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    TableRow row2 = table.Rows[i];
                    if (!row2.IsHeader)
                    {
                        this.bool_6 = false;
                        return;
                    }
                    this.method_60(row2);
                    this.int_0++;
                }
            }
        }
    }

    private void method_60(TableRow A_0)
    {
        if (A_0.IsHeader)
        {
            this.int_1++;
            if (this.int_2 != this.int_1)
            {
                this.class375_1 = new Class375(this.method_33().imethod_8(this.method_34()));
                this.class375_1.method_70(new RectangleF(base.class774_0.method_13().Location, new SizeF()));
                for (int i = 0; i < (this.class375_1.method_73() as TableRow).Cells.Count; i++)
                {
                    for (int j = 0; j < (this.class375_1.method_73() as TableRow).Cells[i].Items.Count; j++)
                    {
                        if ((this.class375_1.method_73() as TableRow).Cells[i].Items[j] is Paragraph)
                        {
                            Paragraph paragraph = (this.class375_1.method_73() as TableRow).Cells[i].Items[j] as Paragraph;
                            if (paragraph != null)
                            {
                                for (int k = 0; k < paragraph.Items.Count; k++)
                                {
                                    if (paragraph.Items[k] is TextRange)
                                    {
                                        (paragraph.Items[k] as TextRange).TextToSplit = (paragraph.Items[k] as TextRange).Text;
                                    }
                                }
                            }
                        }
                    }
                }
                this.method_48();
                this.method_49();
                this.int_3 = -1;
                if (((A_0.NextSibling != null) && (A_0.NextSibling is TableRow)) && (A_0.NextSibling as TableRow).IsHeader)
                {
                    A_0 = A_0.NextSibling as TableRow;
                }
                else
                {
                    this.bool_6 = false;
                }
            }
            else
            {
                this.int_2++;
            }
        }
    }

    private void method_61()
    {
        int num = 0x12;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        RectangleF ef = this.class375_1.method_69();
        this.class375_1.method_73();
        Class211 class2 = this.class375_1.method_73().imethod_0() as Class211;
        for (int i = 0; i < this.class375_1.method_74().Count; i++)
        {
            Class375 class3 = this.class375_1.method_74().method_4(i);
            Class211 class4 = class3.method_73().imethod_0() as Class211;
            class2.Interface23.imethod_41(class4.Interface23.imethod_40());
            bool flag3 = class4.method_113();
            bool flag = false;
            num2 = Math.Max(num2, class3.method_73().imethod_0().imethod_0().method_12() + class3.method_73().imethod_0().imethod_0().method_4());
            num3 = Math.Max(num3, class3.method_73().imethod_0().imethod_1().method_12());
            num4 = Math.Max(num4, class3.method_73().imethod_0().imethod_1().method_4());
            if (this.method_34() != (this.method_33().imethod_5() - 1))
            {
                int num13 = this.method_62(this.method_34(), i);
                Interface3 interface3 = this.method_33().imethod_7(this.method_34() + 1, num13);
                if (interface3 != null)
                {
                    flag = (interface3.imethod_0() as Class211).method_113();
                }
            }
            if ((flag3 || class4.method_111()) && (!flag || (flag && (this.layoutState_1 == LayoutState.Splitted))))
            {
                int index = i;
                if ((this.method_34() > 0) && (base.class375_0.method_74().Count > 0))
                {
                    index = this.method_68(class3.method_69().X, i);
                }
                ef.Height = (float) Math.Max(this.double_2[index], (double) ef.Height);
            }
        }
        double num11 = class2.method_107() ? class2.method_121() : (((class2.method_121() + ((float) num2)) + ((float) num3)) + ((float) num4));
        if (base.class774_0.method_13().Width > 0f)
        {
            ef.Width = base.class774_0.method_13().Width;
        }
        if (class2.method_107() && (num11 > 0.0))
        {
            ef.Height = (float) num11;
        }
        else if (class2.Interface23.imethod_30())
        {
            if (class2.method_121() == 0.0)
            {
                float num10 = base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ᠷ", num), base.method_4().method_376(this.table_0.Rows[this.method_34()].Cells[0].LastParagraph.BreakCharacterFormat), null).Height : base.method_4().method_316(BookmarkStart.b("ᠷ", num), this.table_0.Rows[this.method_34()].Cells[0].LastParagraph.BreakCharacterFormat.Font, null).Height;
                ef.Height = ((float) num11) + num10;
            }
            else
            {
                ef.Height = (float) num11;
            }
        }
        else
        {
            bool flag2 = false;
            for (int j = 0; j < this.class375_1.method_74().Count; j++)
            {
                if (this.class375_1.method_74().method_4(j).method_73().imethod_0().imethod_30())
                {
                    flag2 = true;
                    break;
                }
            }
            if (flag2)
            {
                float num12 = 0f;
                for (int k = 0; k < this.class375_1.method_74().Count; k++)
                {
                    float height = this.class375_1.method_74().method_4(k).method_69().Height;
                    Interface1 interface2 = this.class375_1.method_74().method_4(k).method_73();
                    TableCell cell = (interface2 is TableCell) ? (interface2 as TableCell) : ((!(interface2 is Class65) || !((interface2 as Class65).method_2() is TableCell)) ? null : ((interface2 as Class65).method_2() as TableCell));
                    if ((!interface2.imethod_0().imethod_30() && (num12 < height)) && ((cell != null) && (cell.CellFormat.VerticalMerge == CellMerge.None)))
                    {
                        num12 = height;
                    }
                }
                ef.Height = (float) Math.Max((double) num12, num11);
            }
            else
            {
                ef.Height = (float) Math.Max((double) ef.Height, num11);
            }
            if ((this.table_0.TextBoxFormat != null) && this.table_0.TextBoxFormat.IsFitShapeToText)
            {
                ef.Height = this.class375_2.method_69().Height + this.table_0.TextBoxFormat.InternalMargin.Bottom;
            }
        }
        this.class375_1.method_70(ef);
    }

    private int method_62(int A_0, int A_1)
    {
        float num2 = 0f;
        for (int i = 0; i < A_1; i++)
        {
            num2 += (this.method_33() as Table).Rows[A_0].Cells[i].LayoutWidth;
        }
        float num4 = 0f;
        for (int j = 0; j < (this.method_33() as Table).Rows[A_0 + 1].Cells.Count; j++)
        {
            num4 += (this.method_33() as Table).Rows[A_0 + 1].Cells[j].LayoutWidth;
            if (Class59.smethod_4(num2, num4, 0.5f) < 0)
            {
                return j;
            }
            if (num2 == num4)
            {
                if (j == ((this.method_33() as Table).Rows[A_0 + 1].Cells.Count - 1))
                {
                    return j;
                }
                return (j + 1);
            }
        }
        return 0;
    }

    private void method_63(int A_0)
    {
        if (A_0 < this.class375_1.method_74().Count)
        {
            this.method_64(A_0);
            this.method_66(A_0);
        }
    }

    private void method_64(int A_0)
    {
        int num = 3;
        Class375 class2 = this.class375_1.method_74().method_4(A_0);
        TableCell cell2 = (class2.method_73() is TableCell) ? (class2.method_73() as TableCell) : ((!(class2.method_73() is Class65) || !((class2.method_73() as Class65).method_2() is TableCell)) ? null : ((class2.method_73() as Class65).method_2() as TableCell));
        RectangleF ef = class2.method_69();
        this.int_3 = A_0;
        if (this.int_6 > 0)
        {
            A_0 += this.int_6;
        }
        if (A_0 >= this.double_0.Length)
        {
            if ((A_0 - this.int_6) == (this.double_0.Length - 1))
            {
                ef.Width = this.method_105(this.method_34(), this.int_3);
            }
        }
        else
        {
            ef.Width = this.method_105(this.method_34(), this.int_3) + ((float) this.method_95());
        }
        if (cell2 != null)
        {
            float layoutWidth = cell2.LayoutWidth;
            if ((ef.Width > layoutWidth) && (((cell2.CellFormat.TextDirection != TextDirection.TopToBottom) && (cell2.CellFormat.TextDirection != TextDirection.TopToBottomRotated)) || ((ef.Width - layoutWidth) <= 0.5)))
            {
                ef.Width = layoutWidth;
            }
            if (((cell2.Colspan > 1) && (ef.Width != layoutWidth)) || ((class2.method_73() is Class65) && ((ef.Width < layoutWidth) || ((ef.Width > layoutWidth) && (cell2.Colspan > 1)))))
            {
                ef.Width = layoutWidth;
            }
        }
        if (ef.Width == 0f)
        {
            ef.Width = (float) (((class2.method_73().imethod_0().imethod_0().method_0() + class2.method_73().imethod_0().imethod_0().method_8()) + class2.method_73().imethod_0().imethod_1().method_0()) + class2.method_73().imethod_0().imethod_1().method_8());
        }
        if (this.table_0.TableFormat.CellSpacingEx > 0f)
        {
            ef.Width -= this.table_0.TableFormat.CellSpacingEx * 2f;
        }
        class2.method_70(ef);
        if ((base.interface30_0 as Class304).method_4().Right < class2.method_69().Right)
        {
            TableCell cell = (class2.method_73() is TableCell) ? (class2.method_73() as TableCell) : ((class2.method_73() as Class65).method_2() as TableCell);
            if ((!((Interface4) cell.OwnerRow.OwnerTable).imethod_3().imethod_13() && (cell.OwnerRow.OwnerTable.OwnerTextBody != null)) && ((cell.OwnerRow.OwnerTable.OwnerTextBody.OwnerBase != null) && (cell.OwnerRow.OwnerTable.OwnerTextBody.OwnerBase is Section)))
            {
                Section ownerBase = cell.OwnerRow.OwnerTable.OwnerTextBody.OwnerBase as Section;
                if (ownerBase.Columns.Count > 1)
                {
                    int num2 = this.method_65(ownerBase);
                    if (((base.interface30_0 as Class304).method_4().Right + ownerBase.Columns[num2].Space) < class2.method_69().Right)
                    {
                        class2.method_65(BookmarkStart.b("樨䜪䐬弮䄰嘲儴", num));
                        class2.method_25((base.interface30_0 as Class304).method_4().Right + ownerBase.Columns[num2].Space);
                    }
                }
            }
        }
        if (class2.method_64() == BookmarkStart.b("稨䀪䐬弮挰娲刴弶䴸", num))
        {
            this.method_93(class2, class2.method_69().Right - ((float) (class2.method_73().imethod_0().imethod_1().method_0() + class2.method_73().imethod_0().imethod_1().method_8())));
        }
    }

    private int method_65(Section A_0)
    {
        ColumnCollection columns = A_0.Columns;
        float num2 = 0f;
        for (int i = 0; i < columns.Count; i++)
        {
            if (((base.class774_0.method_11().X - A_0.PageSetup.Margins.Left) - num2) <= columns[i].Width)
            {
                return i;
            }
            num2 += columns[i].Width + columns[i].Space;
        }
        return 0;
    }

    private void method_66(int A_0)
    {
        Class375 class2 = this.class375_1.method_74().method_4(A_0);
        RectangleF ef = class2.method_69();
        RectangleF ef2 = this.class375_1.method_69();
        bool flag = (class2.method_73().imethod_0() as Class211).method_113();
        (class2.method_73().imethod_0() as Class211).method_111();
        if (this.method_34() != (this.method_33().imethod_5() - 1))
        {
            Interface3 interface2 = this.method_33().imethod_7(this.method_34() + 1, A_0);
            if (interface2 != null)
            {
                (interface2.imethod_0() as Class211).method_113();
            }
        }
        if (this.bool_8 && !this.bool_9)
        {
            flag = false;
            this.bool_9 = true;
        }
        if (flag)
        {
            this.method_74(A_0);
        }
        float num = 0f;
        if (this.table_0.TableFormat.CellSpacingEx > 0f)
        {
            num = this.table_0.TableFormat.CellSpacingEx * 2f;
        }
        ef.Height = ef2.Height - num;
        if (this.method_34() != (this.table_0.Rows.Count - 1))
        {
            ef.Height -= ((float) class2.method_73().imethod_0().imethod_1().method_12()) - num;
        }
        if ((ef.Height < ef2.Height) && (this.table_0.TableFormat.CellSpacingEx <= 0f))
        {
            ef.Height = ef2.Height;
        }
        class2.method_70(ef);
        if (((this.method_34() > 0) && (base.class375_0.method_74().Count > 0)) && !(class2.method_73().imethod_0() as Class211).method_111())
        {
            this.method_71(class2.method_69().X, ef2.Height);
        }
        else if ((class2.method_73().imethod_0() as Class211).method_111())
        {
            double num2 = this.double_2[this.int_3] - ef2.Height;
            this.double_2[this.int_3] = (num2 > 0.0) ? num2 : 0.0;
        }
        if ((class2.method_74().method_4(0).method_74().Count > 0) && (this.class375_1.method_73().imethod_0() as Class211).method_107())
        {
            this.method_72(class2);
        }
    }

    private void method_67(int A_0)
    {
        int num = this.method_34() - 1;
        Class375 class2 = this.class375_1.method_74().method_4(A_0);
        RectangleF ef = class2.method_69();
        bool flag = (class2.method_73().imethod_0() as Class211).method_113();
        bool flag2 = false;
        bool flag3 = false;
        if (flag && (num != (this.method_33().imethod_5() - 1)))
        {
            float height = ef.Height;
            float single1 = ef.Height;
            while (true)
            {
                Interface3 interface2 = this.method_33().imethod_7(num, A_0);
                flag3 = (interface2.imethod_0() as Class211).method_111();
                if (flag2 = (interface2.imethod_0() as Class211).method_113())
                {
                    num--;
                }
                if (flag3 && (base.class375_0.method_74().Count > num))
                {
                    RectangleF ef2 = base.class375_0.method_74().method_4(num).method_74().method_4(A_0).method_69();
                    base.class375_0.method_74().method_4(num).method_74().method_4(A_0).method_70(new RectangleF(ef2.Location, new SizeF(ef2.Width, ef2.Height - height)));
                }
                if (!flag2)
                {
                    return;
                }
            }
        }
    }

    private int method_68(float A_0, int A_1)
    {
        int num = A_1;
        for (int i = base.class375_0.method_74().Count - 1; i >= 0; i--)
        {
            int num3 = 0;
            while (num3 < base.class375_0.method_74().method_4(i).method_74().Count)
            {
                float x = base.class375_0.method_74().method_4(i).method_74().method_4(num3).method_69().X;
                if (A_0 <= x)
                {
                    goto Label_0072;
                }
                num3++;
            }
            continue;
        Label_0072:
            if ((base.class375_0.method_74().method_4(i).method_74().method_4(num3).method_73().imethod_0() as Class211).method_111())
            {
                if ((this.int_4[num3] + this.int_0) == i)
                {
                    return num3;
                }
                return num;
            }
            if (!(base.class375_0.method_74().method_4(i).method_74().method_4(num3).method_73().imethod_0() as Class211).method_113())
            {
                return num;
            }
        }
        return num;
    }

    private int method_69(float A_0, int A_1)
    {
        int num = A_1;
        for (int i = this.method_34() - 1; i >= 0; i--)
        {
            for (int j = 0; j < this.table_0.Rows[i].Cells.Count; j++)
            {
                float num4 = (this.table_0.Rows[i].Cells[j].interface23_0 as Class211).method_115();
                if ((A_0 == num4) && (this.table_0.Rows[i].Cells[j].interface23_0 as Class211).method_111())
                {
                    return j;
                }
            }
        }
        return num;
    }

    private float method_70(int A_0, int A_1, float A_2)
    {
        for (int i = A_0 - 1; i >= 0; i--)
        {
            TableRow row = this.table_0.Rows[i];
            if (A_1 >= row.Cells.Count)
            {
                return A_2;
            }
            TableCell cell = row.Cells[A_1];
            if (cell.CellFormat.VerticalMerge == CellMerge.Start)
            {
                A_2 = cell.LayoutWidth;
                return A_2;
            }
        }
        return A_2;
    }

    private void method_71(float A_0, float A_1)
    {
        for (int i = base.class375_0.method_74().Count - 1; i >= 0; i--)
        {
            int num2 = 0;
            while (num2 < base.class375_0.method_74().method_4(i).method_74().Count)
            {
                float x = base.class375_0.method_74().method_4(i).method_74().method_4(num2).method_69().X;
                if (A_0 <= x)
                {
                    goto Label_0070;
                }
                num2++;
            }
            continue;
        Label_0070:
            if ((base.class375_0.method_74().method_4(i).method_74().method_4(num2).method_73().imethod_0() as Class211).method_111())
            {
                if ((this.int_4[num2] + this.int_0) != i)
                {
                    continue;
                }
                double num3 = this.double_2[num2] - A_1;
                this.double_2[num2] = (Class59.smethod_5(num3, 0.0, 0.005) > 1) ? num3 : 0.0;
                return;
            }
            if (!(base.class375_0.method_74().method_4(i).method_74().method_4(num2).method_73().imethod_0() as Class211).method_113())
            {
                return;
            }
        }
    }

    private void method_72(Class375 A_0)
    {
        if ((!(A_0.method_73() is TableCell) || ((A_0.method_73() as TableCell).OwnerRow.OwnerTable.TextBoxFormat == null)) && (A_0.method_74().method_4(0).method_74().method_4(A_0.method_74().Count - 1).method_73() is Table))
        {
            Class375 class2 = A_0.method_74().method_4(0).method_74().method_4(A_0.method_74().Count - 1);
            if (class2.method_69().Bottom >= A_0.method_69().Bottom)
            {
                for (int i = 0; i < class2.method_74().Count; i++)
                {
                    Class375 class3 = class2.method_74().method_4(i);
                    for (int j = 0; j < class3.method_74().Count; j++)
                    {
                        if (class3.method_69().Bottom < A_0.method_69().Bottom)
                        {
                            break;
                        }
                        if (class3.method_69().Top >= A_0.method_69().Bottom)
                        {
                            class3.method_74().method_12(j);
                        }
                        else
                        {
                            (class3.method_74().method_4(j).method_73().imethod_0() as Class212).method_137(true);
                            float num3 = A_0.method_69().Bottom - ((float) (A_0.method_73().imethod_0().imethod_1().method_12() + A_0.method_73().imethod_0().imethod_1().method_4()));
                            class3.method_97(0f, num3 - class3.method_74().method_4(j).method_69().Y, 0f, num3 - class3.method_74().method_4(j).method_69().Y);
                        }
                    }
                }
            }
        }
    }

    private int method_73(int A_0, int A_1)
    {
        float num = 0f;
        float num2 = 0f;
        if (A_1 != 0)
        {
            for (int i = 0; i < A_1; i++)
            {
                num2 += this.table_0.Rows[this.method_34()].Cells[i].LayoutWidth;
            }
            int num5 = 0;
            int count = this.table_0.Rows[A_0].Cells.Count;
            while (num5 < count)
            {
                num += this.table_0.Rows[A_0].Cells[num5].LayoutWidth;
                if (Math.Round((double) num, 1) == Math.Round((double) num2, 1))
                {
                    A_1 = ++num5;
                    if (A_1 >= count)
                    {
                        A_1 = count - 1;
                    }
                    return A_1;
                }
                if (Math.Round((double) num, 1) > Math.Round((double) num2, 1))
                {
                    if (Math.Ceiling((double) num) == Math.Ceiling((double) num2))
                    {
                        A_1 = ++num5;
                        if (A_1 >= count)
                        {
                            A_1 = count - 1;
                        }
                        return A_1;
                    }
                    A_1 = num5;
                    return A_1;
                }
                num5++;
            }
        }
        return A_1;
    }

    private void method_74(int A_0)
    {
        int num = A_0;
        int num2 = this.method_34() - 1;
        int num3 = 0;
        RectangleF ef = this.class375_1.method_69();
        float height = 0f;
        bool isHeader = (this.class375_1.method_73() as TableRow).IsHeader;
        while (num2 > -1)
        {
            A_0 = this.method_73(num2, num);
            Class211 class3 = this.method_33().imethod_7(num2, A_0).imethod_0() as Class211;
            if (!class3.method_111() && !class3.method_113())
            {
                return;
            }
            if ((num2 > 0) && class3.method_113())
            {
                A_0 = this.method_73(num2 - 1, num);
                Interface3 interface2 = this.method_33().imethod_7(num2 - 1, A_0);
                if (interface2 != null)
                {
                    Class211 class5 = interface2.imethod_0() as Class211;
                    if (!class5.method_111() && !class5.method_113())
                    {
                        class3.method_112(true);
                    }
                }
            }
            if (this.bool_9 || ((this.int_7 == num2) && this.bool_8))
            {
                if (class3.method_113())
                {
                    class3.method_112(base.class375_0.method_74().Count == (this.method_34() - num2));
                }
                num3 = this.method_34();
                this.int_7 = num2;
            }
            int num8 = (num3 != 0) ? (base.class375_0.method_74().Count - (this.method_34() - num2)) : num2;
            if ((num8 >= 0) && (num8 < base.class375_0.method_74().Count))
            {
                height += base.class375_0.method_74().method_4(num8).method_69().Height;
            }
            if (class3.method_111() && ((base.class375_0.method_74().Count + num3) > num2))
            {
                int num9 = base.class375_0.method_74().Count - (this.method_34() - num2);
                if (base.class375_0.method_74().Count == 0)
                {
                    break;
                }
                if (num3 != 0)
                {
                    if ((num9 < 0) || (num9 > base.class375_0.method_74().Count))
                    {
                        break;
                    }
                    if (A_0 > base.class375_0.method_74().method_4(num9).method_74().Count)
                    {
                        return;
                    }
                }
                Class375 class2 = null;
                if (num3 != 0)
                {
                    class2 = base.class375_0.method_74().method_4(num9).method_74().method_4(A_0);
                }
                else
                {
                    class2 = base.class375_0.method_74().method_4(num2).method_74().method_4(A_0);
                }
                bool flag3 = false;
                if (class2.method_73() is TableCell)
                {
                    flag3 = ((class2.method_73() as TableCell).Owner as TableRow).IsHeader;
                }
                else if ((class2.method_73() is Class65) && ((class2.method_73() as Class65).method_2() is TableCell))
                {
                    flag3 = (((class2.method_73() as Class65).method_2() as TableCell).Owner as TableRow).IsHeader;
                }
                if (isHeader != flag3)
                {
                    break;
                }
                RectangleF ef14 = class2.method_69();
                if (class2.method_68().Count == 0)
                {
                    class2.method_68().Add(class2.method_69());
                }
                ef14.Height = ef.Bottom - class2.method_69().Top;
                this.method_75(class2.method_68(), new RectangleF(ef14.X, ef.Y, ef14.Width, ef.Height));
                class2.method_70(ef14);
                if (!this.method_31().ContainsKey(class2.method_73()))
                {
                    this.method_31().Add(class2.method_73(), class2);
                }
                if (!(this.class375_1.method_74().method_4(num).method_73().imethod_0() as Class211).method_113() || ((this.method_34() != (this.table_0.Rows.Count - 1)) && ((this.method_34() >= (this.table_0.Rows.Count - 1)) || (this.table_0.Rows[this.method_34() + 1].Cells[this.method_62(this.method_34(), num)].CellFormat.VerticalMerge == CellMerge.Continue))))
                {
                    break;
                }
                if ((this.table_0.Rows[this.method_34()].HeightType != TableRowHeightType.Exactly) && (class2.method_74().method_4(0).method_74().Count > 0))
                {
                    TableCell cell = (class2.method_73() is TableCell) ? (class2.method_73() as TableCell) : ((!(class2.method_73() is Class65) || !((class2.method_73() as Class65).method_2() is TableCell)) ? null : ((class2.method_73() as Class65).method_2() as TableCell));
                    if ((cell != null) && (cell.CellFormat.VerticalMerge != CellMerge.Continue))
                    {
                        if (cell.CellFormat.TextDirection != TextDirection.TopToBottom)
                        {
                            float num5 = this.class375_1.method_115();
                            float num6 = Math.Max(this.table_0.Rows[this.method_34()].Height, num5);
                            height += num6;
                            class2.method_70(new RectangleF(class2.method_69().Location, new SizeF(class2.method_69().Width, height)));
                            this.class375_1.method_70(new RectangleF(this.class375_1.method_69().Location, new SizeF(this.class375_1.method_69().Width, num6)));
                            for (int i = 0; i < num; i++)
                            {
                                this.method_66(i);
                            }
                        }
                        else if ((((cell.CellFormat.TextDirection != TextDirection.TopToBottomRotated) && (cell.CellFormat.TextDirection != TextDirection.LeftToRightRotated)) && ((cell.CellFormat.TextDirection != TextDirection.RightToLeftRotated) && (cell.CellFormat.TextDirection != TextDirection.LeftToRight))) && (Class59.smethod_4(class2.method_69().Height, class2.method_74().method_4(0).method_69().Height, 0.5f) < 0))
                        {
                            class2.method_70(new RectangleF(class2.method_69().Location, new SizeF(class2.method_69().Width, class2.method_74().method_4(0).method_69().Height)));
                            this.class375_1.method_70(new RectangleF(this.class375_1.method_69().Location, new SizeF(this.class375_1.method_69().Width, class2.method_69().Bottom - this.class375_1.method_69().Top)));
                            for (int j = 0; j < num; j++)
                            {
                                this.method_66(j);
                            }
                        }
                    }
                }
                this.method_50(class2);
                this.method_51(class2);
                this.method_37();
                this.method_76(class2);
                this.method_38();
                return;
            }
            if (class3.method_111() && (base.class375_0.method_74().Count <= num2))
            {
                Class375 class4 = new Class375(this.method_33().imethod_7(num2, A_0));
                bool flag2 = false;
                if (class4.method_73() is TableCell)
                {
                    flag2 = ((class4.method_73() as TableCell).Owner as TableRow).IsHeader;
                }
                else if ((class4.method_73() is Class65) && ((class4.method_73() as Class65).method_2() is TableCell))
                {
                    flag2 = (((class4.method_73() as Class65).method_2() as TableCell).Owner as TableRow).IsHeader;
                }
                if (isHeader == flag2)
                {
                    RectangleF ef16 = class4.method_69();
                    ef16.Height = ef.Bottom - class4.method_69().Top;
                    ef16.Height -= (float) class4.method_73().imethod_0().imethod_1().method_12();
                    class4.method_70(ef16);
                    return;
                }
                break;
            }
            num2--;
        }
    }

    private void method_75(List<RectangleF> A_0, RectangleF A_1)
    {
        float bottom = A_1.Bottom;
        for (int i = 0; i < A_0.Count; i++)
        {
            RectangleF item = A_0[i];
            if (Class59.smethod_5((double) A_1.Top, (double) item.Top, 0.005) == 0)
            {
                bottom = Math.Max(bottom, item.Bottom);
                A_0.Remove(item);
                i--;
            }
        }
        A_1.Height = bottom - A_1.Top;
        A_0.Add(A_1);
    }

    private void method_76(Class375 A_0)
    {
        RectangleF ef = A_0.method_69();
        TableCell cell = (A_0.method_73() is TableCell) ? (A_0.method_73() as TableCell) : ((!(A_0.method_73() is Class65) || !((A_0.method_73() as Class65).method_2() is TableCell)) ? null : ((A_0.method_73() as Class65).method_2() as TableCell));
        switch (((cell != null) ? cell.CellFormat.TextDirection : TextDirection.TopToBottom))
        {
            case TextDirection.RightToLeft:
            case TextDirection.LeftToRightRotated:
            case TextDirection.LeftToRight:
            case TextDirection.RightToLeftRotated:
            {
                float clientHeight = cell.method_2().PageSetup.ClientHeight;
                ef = new RectangleF(ef.Location, new SizeF(ef.Height, clientHeight));
                break;
            }
        }
        if ((cell != null) && (cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f))
        {
            ef.Width += cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
            ef.X -= cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
            ef.Height += cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
            ef.Y -= cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
        }
        this.method_50(A_0);
        Class375 class3 = Class615.smethod_0(A_0.method_73(), base.interface30_0, (float) base.class774_0.method_2()).vmethod_0(ef);
        A_0.method_74().method_5(0, class3);
        this.method_31().Remove(A_0.method_73());
    }

    private void method_77()
    {
        int num = 0;
        int count = base.class375_0.method_74().Count;
        while (num < count)
        {
            Class375 class2 = base.class375_0.method_74().method_4(num);
            for (int i = class2.method_74().Count - 1; i > -1; i--)
            {
                bool flag2;
                Class375 class3 = class2.method_74().method_4(i);
                Class211 class4 = class3.method_73().imethod_0() as Class211;
                bool flag = class4.method_105();
                CellMerge merge = (class3.method_73() is TableCell) ? (class3.method_73() as TableCell).CellFormat.VerticalMerge : CellMerge.None;
                if (class3.method_73() is TableCell)
                {
                    CellMerge horizontalMerge = (class3.method_73() as TableCell).CellFormat.HorizontalMerge;
                }
                if (class4.method_113() || flag)
                {
                    goto Label_0394;
                }
                if (class3.method_74().Count <= 0)
                {
                    continue;
                }
                RectangleF ef = class3.method_69();
                Class375 class5 = class3.method_74().method_4(0);
                float num4 = 0f;
                if (class3.method_73() is TableCell)
                {
                    bool isHeader = (class3.method_73() as TableCell).OwnerRow.IsHeader;
                }
                Class211 class6 = class5.method_73().imethod_0() as Class211;
                TableCell cell = (class3.method_73() is TableCell) ? (class3.method_73() as TableCell) : ((!(class3.method_73() is Class65) || !((class3.method_73() as Class65).method_2() is TableCell)) ? null : ((class3.method_73() as Class65).method_2() as TableCell));
                RectangleF ef2 = ((cell == null) || (cell.CellFormat.VerticalMerge != CellMerge.Start)) ? class5.method_69() : this.method_79(class5);
                if (cell.HasShape)
                {
                    float top = ef.Top;
                    float num6 = ef.Top;
                    this.method_78(class3, ref top, ref num6);
                    float num7 = ((num6 > ef.Bottom) ? ef.Bottom : num6) - Math.Max(ef.Top, top);
                    ef2.Height = (num7 > ef.Height) ? ef.Height : ((num7 > 0f) ? num7 : ef2.Height);
                }
                switch (class6.method_122())
                {
                    case VerticalAlignment.Middle:
                        if (Math.Round((double) ef.Height) <= Math.Round((double) (ef2.Height + class6.Interface22.imethod_0().method_12())))
                        {
                            goto Label_034C;
                        }
                        if ((cell.CellFormat.TextDirection == TextDirection.TopToBottom) || (cell.CellFormat.TextDirection == TextDirection.TopToBottomRotated))
                        {
                            break;
                        }
                        num4 = ((ef.Height - ((float) class6.Interface22.imethod_0().method_0())) - ef2.Height) / 2f;
                        goto Label_02DB;

                    case VerticalAlignment.Bottom:
                        if ((cell.CellFormat.TextDirection == TextDirection.TopToBottom) || (cell.CellFormat.TextDirection == TextDirection.TopToBottomRotated))
                        {
                            goto Label_0324;
                        }
                        num4 = (ef.Height - ((float) class6.Interface22.imethod_0().method_0())) - ef2.Height;
                        goto Label_0345;

                    default:
                        goto Label_034C;
                }
                num4 = (ef.Height - ef2.Height) / 2f;
            Label_02DB:
                this.bool_8 = false;
                goto Label_034C;
            Label_0324:
                num4 = (ef.Height - ((float) class6.Interface22.imethod_0().method_12())) - ef2.Height;
            Label_0345:
                this.bool_8 = false;
            Label_034C:
                flag2 = cell.DontVertAlignCellWithSp;
                if ((num4 > 0f) && (!flag2 || (!cell.HasShape && flag2)))
                {
                    class5.method_94(0.0, (double) num4, true);
                }
                class5.method_70(RectangleF.Empty);
                continue;
            Label_0394:
                if (!this.method_110(num, i) && !flag)
                {
                    if ((merge == CellMerge.Continue) && (base.class375_0.method_74().method_4(num).method_74().method_4(i).method_74().Count > 0))
                    {
                        base.class375_0.method_74().method_4(num).method_74().method_4(i).method_74().method_12(0);
                    }
                }
                else
                {
                    if (((i - 1) >= 0) && flag)
                    {
                        Interface1 interface2 = base.class375_0.method_74().method_4(num).method_74().method_4(i).method_73();
                        Interface1 interface3 = base.class375_0.method_74().method_4(num).method_74().method_4(i - 1).method_73();
                        Borders borders = (interface2 is Class65) ? ((interface2 as Class65).method_2() as TableCell).CellFormat.Borders : (interface2 as TableCell).CellFormat.Borders;
                        Borders borders2 = (interface3 is Class65) ? ((interface3 as Class65).method_2() as TableCell).CellFormat.Borders : (interface3 as TableCell).CellFormat.Borders;
                        if ((!borders.IsDefault || !borders.NoBorder) && (((!borders.Right.IsDefault && (borders.Right.BorderType != BorderStyle.None)) && ((borders.Right.BorderType != BorderStyle.Cleared) && !borders2.Right.IsDefault)) && ((borders2.Right.BorderType == BorderStyle.None) || (borders2.Right.BorderType == BorderStyle.Cleared))))
                        {
                            borders2.Right.Color = borders.Right.Color;
                            borders2.Right.LineWidth = borders.Right.LineWidth;
                            borders2.Right.Space = borders.Right.Space;
                        }
                    }
                    base.class375_0.method_74().method_4(num).method_74().method_12(i);
                }
            }
            num++;
        }
    }

    private void method_78(Class375 A_0, ref float A_1, ref float A_2)
    {
        foreach (Class375 class2 in A_0.method_74())
        {
            if ((class2.method_74().Count != 0) && !(class2.method_73() is Table))
            {
                this.method_78(class2, ref A_1, ref A_2);
            }
            else
            {
                A_1 = Math.Min(A_1, class2.method_69().Top);
                A_2 = Math.Max(A_2, class2.method_69().Bottom);
            }
        }
    }

    private RectangleF method_79(Class375 A_0)
    {
        if ((A_0 == null) || (!(A_0.method_73() is TableCell) && (!(A_0.method_73() is Class65) || !((A_0.method_73() as Class65).method_2() is TableCell))))
        {
            return new RectangleF();
        }
        RectangleF ef = A_0.method_69();
        int num2 = 0;
        int count = A_0.method_74().Count;
        while (num2 < count)
        {
            Class375 class2 = A_0.method_74().method_4(num2);
            if ((class2.method_73() is Paragraph) && (class2.method_74().Count > 0))
            {
                class2 = (class2.method_74().method_4(0).method_73() is Paragraph) ? class2.method_74().method_4(0) : class2;
                int num = 0;
                int num4 = class2.method_74().Count;
                while (num < num4)
                {
                    if (((class2.method_74().method_4(num).method_73() is DocPicture) && ((class2.method_74().method_4(num).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)) && (class2.method_74().method_4(num).method_73() as DocPicture).LayoutInCell)
                    {
                        ef = new RectangleF(ef.Location, new SizeF(ef.Width, ef.Height + class2.method_74().method_4(num).method_69().Height));
                    }
                    num++;
                }
            }
            num2++;
        }
        return ef;
    }

    private RectangleF method_80(Class375 A_0)
    {
        if (A_0 == null)
        {
            return new RectangleF();
        }
        if (((A_0.method_73() is TableCell) && (A_0.method_74().Count > 0)) && (A_0.method_74().method_4(0).method_73() is TableCell))
        {
            A_0 = A_0.method_74().method_4(0);
        }
        RectangleF ef2 = new RectangleF();
        if ((A_0.method_73() is TableCell) || ((A_0.method_73() is Class65) && ((A_0.method_73() as Class65).method_2() is TableCell)))
        {
            int num4 = 0;
            int count = A_0.method_74().Count;
            while (num4 < count)
            {
                int num3 = 0;
                int num6 = A_0.method_74().method_4(num4).method_74().Count;
                while (num3 < num6)
                {
                    Class375 class2 = A_0.method_74().method_4(num4).method_74().method_4(num3);
                    if (class2.method_73() is Paragraph)
                    {
                        class2.method_73();
                    }
                    else if ((class2.method_73() is Class65) && ((class2.method_73() as Class65).method_2() is Paragraph))
                    {
                        (class2.method_73() as Class65).method_2();
                    }
                    RectangleF ef3 = class2.method_69();
                    int num = 0;
                    int num2 = class2.method_74().Count;
                    while (num < num2)
                    {
                        if (((class2.method_74().method_4(num).method_73() is DocPicture) && ((class2.method_74().method_4(num).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)) && (class2.method_74().method_4(num).method_73() as DocPicture).LayoutInCell)
                        {
                            ef3 = new RectangleF(ef3.Location, new SizeF(ef3.Width, ef3.Height + class2.method_74().method_4(num).method_69().Height));
                        }
                        num++;
                    }
                    if (ef2.IsEmpty)
                    {
                        ef2 = ef3;
                    }
                    else
                    {
                        float width = Math.Max(ef2.Width, ef3.Width);
                        ef2 = new RectangleF(ef2.Location, new SizeF(width, ef2.Height + ef3.Height));
                    }
                    num3++;
                }
                num4++;
            }
        }
        if (ef2.IsEmpty)
        {
            ef2 = A_0.method_69();
        }
        return ef2;
    }

    private float method_81(Class375 A_0)
    {
        RectangleF ef = new RectangleF();
        if ((A_0 != null) && ((A_0.method_73() is TableCell) || ((A_0.method_73() is Class65) && ((A_0.method_73() as Class65).method_2() is TableCell))))
        {
            int num = 0;
            int count = A_0.method_74().Count;
            while (num < count)
            {
                foreach (Class375 class3 in A_0.method_74().method_4(num).method_74())
                {
                    Class375 class2 = class3;
                    if ((class2.method_73() is Paragraph) && (class2.method_74().Count > 0))
                    {
                        class2 = (class2.method_74().method_4(0).method_73() is Paragraph) ? class2.method_74().method_4(0) : class2;
                        RectangleF ef2 = class2.method_69();
                        float bottom = class2.method_69().Bottom;
                        int num2 = 0;
                        int num4 = class2.method_74().Count;
                        while (num2 < num4)
                        {
                            if ((((class2.method_74().method_4(num2).method_73() is DocPicture) && ((class2.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)) && ((((class2.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind) && ((class2.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (class2.method_74().method_4(num2).method_73() as DocPicture).LayoutInCell)) || ((class2.method_74().method_4(num2).method_73() is Table) && (!(class2.method_74().method_4(num2).method_73() as Table).IsTextBox || (((class2.method_74().method_4(num2).method_73() as Table).IsTextBox && ((class2.method_74().method_4(num2).method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)) && ((class2.method_74().method_4(num2).method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText)))))
                            {
                                bottom = Math.Max(bottom, class2.method_74().method_4(num2).method_69().Bottom);
                            }
                            num2++;
                        }
                        ef2 = new RectangleF(ef2.Location, new SizeF(ef2.Width, bottom - ef2.Top));
                        if (ef.IsEmpty)
                        {
                            ef = ef2;
                        }
                        else
                        {
                            float width = Math.Max(ef.Width, ef2.Width);
                            float introduced15 = Math.Max(ef.Bottom, ef2.Bottom);
                            ef = new RectangleF(ef.Location, new SizeF(width, introduced15 - ef.Top));
                        }
                    }
                    else if (ef.IsEmpty)
                    {
                        ef = class2.method_69();
                    }
                    else
                    {
                        float introduced16 = Math.Max(ef.Width, class2.method_69().Width);
                        float introduced17 = Math.Max(ef.Bottom, class2.method_69().Bottom);
                        ef = new RectangleF(ef.Location, new SizeF(introduced16, introduced17 - ef.Top));
                    }
                }
                num++;
            }
        }
        if (ef.IsEmpty)
        {
            ef = A_0.method_69();
        }
        return ef.Height;
    }

    private RectangleF method_82(int A_0, int A_1)
    {
        Class211 class2 = this.method_33().imethod_7(A_0, A_1).imethod_0() as Class211;
        RectangleF ef = new RectangleF {
            X = (float) ((class2.method_115() - class2.Interface22.imethod_1().method_0()) - class2.Interface22.imethod_0().method_0()),
            Width = this.method_103((class2 != null) ? class2.method_103() : false, A_0, A_1).method_11().Width
        };
        Class375 class3 = new Class375(this.method_33().imethod_7(A_0, A_1));
        Class375 class5 = Class615.smethod_0(class3.method_73(), base.interface30_0, (float) base.class774_0.method_2()).vmethod_0(ef);
        class5.method_70(ef);
        return class5.method_69();
    }

    private bool method_83(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            for (int j = 0; j < A_0.method_74().method_4(i).method_74().Count; j++)
            {
                if ((A_0.method_74().method_4(i).method_74().method_4(j).method_73() is Paragraph) || ((A_0.method_74().method_4(i).method_74().method_4(j).method_73() is Class65) ? ((A_0.method_74().method_4(i).method_74().method_4(j).method_73() as Class65).method_2() is Paragraph) : false))
                {
                    for (int k = 0; k < A_0.method_74().method_4(i).method_74().method_4(j).method_74().Count; k++)
                    {
                        if (((A_0.method_74().method_4(i).method_74().method_4(j).method_74().method_4(k).method_73() is DocPicture) && (A_0.method_74().method_4(i).method_74().method_4(j).method_74().method_4(k).method_73() as DocPicture).LayoutInCell) && ((A_0.method_74().method_4(i).method_74().method_4(j).method_74().method_4(k).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline))
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }

    private ArrayList method_84(Table A_0)
    {
        if (A_0.Offsets.Count > 0)
        {
            return A_0.Offsets;
        }
        ArrayList list = new ArrayList();
        int num3 = 0;
        int count = A_0.Rows.Count;
        while (num3 < count)
        {
            TableRow row = A_0.Rows[num3];
            float item = 0f;
            int num = 0;
            int num2 = row.Cells.Count;
            while (num < num2)
            {
                TableCell cell = row.Cells[num];
                float num6 = (float) Math.Round((double) cell.LayoutWidth);
                item = (float) Math.Round((double) (item + num6));
                if (!list.Contains(item) || (list.Count < (num + 1)))
                {
                    list.Add(item);
                }
                num++;
            }
            num3++;
        }
        list.Sort();
        A_0.Offsets = list;
        return list;
    }

    private void method_85(ArrayList A_0, float A_1, TableCell A_2)
    {
        int num = 1;
        short gridSpanEx = A_2.GridSpanEx;
        A_1 = (float) Math.Round((double) A_1);
        float layoutWidth = A_2.LayoutWidth;
        num = this.method_87(A_0, A_1, (float) Math.Round((double) layoutWidth));
        A_2.Colspan = num;
        if (num > 1)
        {
            A_2.CellFormat.HorizontalMerge = CellMerge.Start;
        }
    }

    private void method_86(Table A_0)
    {
        ArrayList list = this.method_84(A_0);
        int num = 0;
        int count = A_0.Rows.Count;
        while (num < count)
        {
            TableRow row = A_0.Rows[num];
            float num5 = 0f;
            int num3 = 0;
            int num4 = row.Cells.Count;
            while (num3 < num4)
            {
                TableCell cell = row.Cells[num3];
                this.method_85(list, num5, cell);
                num5 += (float) Math.Round((double) cell.LayoutWidth);
                num3++;
            }
            num++;
        }
        list.Clear();
    }

    private int method_87(ArrayList A_0, float A_1, float A_2)
    {
        int index = -1;
        for (int i = 4; i > 0; i--)
        {
            index = A_0.IndexOf((float) Math.Round((double) A_1));
            if (index != -1)
            {
                break;
            }
        }
        if ((index < 0) && (A_1 > 0f))
        {
            throw new InvalidOperationException();
        }
        int num3 = 1;
        float num4 = A_1 + A_2;
        if (A_0.Count > (index + 1))
        {
            while (A_0.Count > (index + num3))
            {
                if ((num4 - ((float) A_0[index + num3])) <= 0.005f)
                {
                    return num3;
                }
                num3++;
            }
        }
        return num3;
    }

    private float method_88(ArrayList A_0, int A_1, float A_2)
    {
        bool flag = false;
        float num = 0f;
        int num2 = 1;
        using (IEnumerator enumerator = A_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                object current = enumerator.Current;
                if (((float) current) == A_2)
                {
                    flag = true;
                }
                if (flag)
                {
                    num += (float) current;
                    if (A_1 == num2)
                    {
                        goto Label_0049;
                    }
                    num2++;
                }
            }
            return num;
        Label_0049:
            flag = false;
        }
        return num;
    }

    private ArrayList method_89(Table A_0)
    {
        ArrayList list = new ArrayList();
        int num = 0;
        int count = A_0.Rows.Count;
        while (num < count)
        {
            TableRow row = A_0.Rows[num];
            float item = 0f;
            int num3 = 0;
            int num4 = row.Cells.Count;
            while (num3 < num4)
            {
                TableCell cell = row.Cells[num3];
                float layoutWidth = cell.LayoutWidth;
                item += layoutWidth;
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
                num3++;
            }
            num++;
        }
        list.Sort();
        return list;
    }

    private float method_90(Table A_0, float A_1)
    {
        float left = A_0.TableFormat.Paddings.Left;
        float right = A_0.TableFormat.Paddings.Right;
        if (A_0.LayoutWidth > 11f)
        {
            return 0f;
        }
        if (A_0.Rows[0].Cells[0].WidthType == FtsWidth.Percentage)
        {
            return A_1;
        }
        using (Class711 class2 = new Class711())
        {
            int num3 = 0;
            int count = A_0.Rows.Count;
            while (num3 < count)
            {
                Class712 class4 = new Class712(class2);
                TableRow row = this.table_0.Rows[num3];
                int num10 = 0;
                int num11 = 0;
                int num16 = row.Cells.Count;
                while (num11 < num16)
                {
                    TableCell cell = row.Cells[num11];
                    float num14 = ((right + left) < 10f) ? 10f : (right + left);
                    Class713 class3 = new Class713(class4);
                    if (cell.WidthType == FtsWidth.Percentage)
                    {
                        float layoutWidth = A_0.LayoutWidth;
                        if (A_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                        {
                            layoutWidth = A_0.method_54();
                        }
                        class3.method_1((layoutWidth * cell.Scaling) / 100f);
                    }
                    else
                    {
                        class3.method_1(cell.LayoutWidth);
                    }
                    class3.method_13(cell.CellFormat.HorizontalMerge);
                    class3.method_8(cell.GridSpanEx);
                    if ((cell.LayoutWidth <= num14) && (cell.Paragraphs.Count > 0))
                    {
                        float num6 = 0f;
                        float num5 = 0f;
                        float num17 = 0f;
                        if (cell.Paragraphs[0].Items.Count > 0)
                        {
                            for (int i = 0; i < cell.Paragraphs.Count; i++)
                            {
                                foreach (object obj2 in cell.Paragraphs[i].Items)
                                {
                                    if (obj2 is TextRange)
                                    {
                                        SizeF ef2 = new SizeF();
                                        string text = (obj2 as TextRange).Text;
                                        if (base.method_4().method_1())
                                        {
                                            sprᝪ rᝪ = base.method_4().method_376((obj2 as TextRange).CharacterFormat);
                                            base.method_4().method_309(text, rᝪ, null);
                                        }
                                        else
                                        {
                                            Font font = base.method_4().method_365((obj2 as TextRange).CharacterFormat);
                                            base.method_4().method_316(text, font, null);
                                        }
                                        float num13 = ((obj2 as TextRange).Document.Sections[0].PageSetup.PageSize.Width - (obj2 as TextRange).Document.Sections[0].PageSetup.Margins.Left) - (obj2 as TextRange).Document.Sections[0].PageSetup.Margins.Right;
                                        num6 += ef2.Width;
                                        if (num6 > num13)
                                        {
                                            num6 = num13 / ((float) row.Cells.Count);
                                        }
                                    }
                                    else if (obj2 is DocPicture)
                                    {
                                        num6 += (obj2 as DocPicture).Width;
                                    }
                                    else if (obj2 is Table)
                                    {
                                        num6 += this.method_90(obj2 as Table, A_1);
                                    }
                                    else if (obj2 is TextBox)
                                    {
                                        num6 += (obj2 as TextBox).Format.Width;
                                    }
                                }
                                num5 = Math.Max(num5, num6);
                            }
                        }
                        num17 = (num5 == 0f) ? 2f : num5;
                        if (num5 != 0f)
                        {
                            left = (left <= 1f) ? 5.5f : left;
                            right = (right <= 1f) ? 5.5f : right;
                            num17 = (num5 + left) + right;
                        }
                        class3.method_1(num17);
                        class3.method_13(row.Cells[num11].CellFormat.HorizontalMerge);
                        class3.method_8(row.Cells[num11].GridSpanEx);
                        if (((num11 - 1) >= 0) && (row.Cells[num11 - 1].GridSpanEx > 1))
                        {
                            num10 += row.Cells[num11 - 1].GridSpanEx;
                        }
                        else if (num11 != 0)
                        {
                            num10++;
                        }
                        class3.method_11(num10);
                        class4.method_31(num11, class3);
                    }
                    else
                    {
                        class4.method_31(num11, class3);
                    }
                    num11++;
                }
                if (class4.method_4() > 0)
                {
                    class2.method_71(num3, class4);
                }
                num3++;
            }
            if ((class2.method_5() > 0) && (class2.method_5() == A_0.Rows.Count))
            {
                for (int j = 0; j < class2.method_5(); j++)
                {
                    Class712 class5 = class2.method_48(j);
                    for (int k = 0; k < class5.method_4(); k++)
                    {
                        float num15 = class2.method_49(class5.method_29(k).method_10());
                        A_0.Rows[j].Cells[k].LayoutWidth = num15;
                        A_0.Rows[j].Cells[k].WidthType = FtsWidth.Point;
                        this.method_32().imethod_3()[k] = num15;
                    }
                }
            }
            return class2.method_19();
        }
    }

    private void method_91(ref RectangleF A_0, bool A_1)
    {
        Interface5 interface2 = this.method_32();
        if (!this.table_0.IsHasCaculatedCellWidth)
        {
            this.method_114(this.table_0, A_0.Width);
        }
        Paddings paddings = new Paddings();
        if (A_1)
        {
            this.method_112(ref A_0);
        }
        if ((this.method_32().imethod_2() > 0f) && (interface2.imethod_2() < A_0.Height))
        {
            A_0.Height = interface2.imethod_2();
        }
        this.method_45(ref A_0);
        base.method_18(A_0, paddings);
    }

    private void method_92(Class615 A_0, RectangleF A_1)
    {
        int num = 4;
        Class375 class2 = null;
        TableCell cell = (A_0.method_8() is TableCell) ? (A_0.method_8() as TableCell) : ((A_0.method_8() as Class65).method_2() as TableCell);
        TableCell cell2 = (this.int_3 > 0) ? this.table_0.Rows[this.method_34()].Cells[this.int_3 - 1] : null;
        if (((cell != null) && (cell.CellFormat.HorizontalMerge == CellMerge.Continue)) && ((cell2 != null) && (cell2.CellFormat.HorizontalMerge != CellMerge.None)))
        {
            class2 = new Class375(cell);
            class2.method_70(A_1);
        }
        else
        {
            (A_0.method_2() as Class211).method_108((this.class375_1.method_73().imethod_0() as Class211).method_107());
            (A_0.method_2() as Class211).method_116((float) ((A_1.X + A_0.method_2().imethod_0().method_0()) + A_0.method_2().imethod_1().method_0()));
            (A_0.method_2() as Class211).method_118((float) ((A_1.Y + A_0.method_2().imethod_0().method_4()) + A_0.method_2().imethod_1().method_4()));
            class2 = A_0.vmethod_0(A_1);
            Class375 class3 = class2;
            bool flag = false;
            for (int i = 0; i < class3.method_74().Count; i++)
            {
                if (flag = base.method_4().method_28().method_52(class3.method_74().method_4(i).method_69(), class3.method_73(), true))
                {
                    break;
                }
            }
            if (flag)
            {
                this.method_50(class2);
                this.method_51(this.class375_2);
                Class615 class5 = this.method_97();
                class5.method_11(true);
                this.method_53(cell);
                class2 = class5.vmethod_0(A_1);
            }
        }
        this.method_94(class2);
        Class375 class4 = new Class375(A_0.method_8(), class2.method_69().Location);
        class4.method_74().method_7(class2);
        class4.method_31(class2.method_30());
        class4.method_70(class2.method_69());
        this.class375_2 = class4;
        if (Math.Round((double) class2.method_69().Right) > Math.Round((double) (A_1.Right + A_0.method_2().imethod_0().method_8())))
        {
            this.class375_2.method_65(BookmarkStart.b("礩䜫䜭䀯怱崳儵倷丹", num));
        }
    }

    private void method_93(Class375 A_0, float A_1)
    {
        int num = 12;
        for (int i = 0; i < A_0.method_74().method_4(0).method_74().Count; i++)
        {
            if ((A_0.method_74().method_4(0).method_74().method_4(i).method_73() is Table) && (A_0.method_69().Right < A_0.method_74().method_4(0).method_74().method_4(i).method_69().Right))
            {
                Class375 class3 = A_0.method_74().method_4(0).method_74().method_4(i);
                if ((class3.method_73() as Table).IsTextBox ? (((class3.method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && ((class3.method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)) : true)
                {
                    class3.method_65(BookmarkStart.b("焱堳張䠷䨹夻娽", num));
                    class3.method_25(A_1);
                    for (int j = 0; j < class3.method_74().Count; j++)
                    {
                        Class375 class2 = class3.method_74().method_4(j);
                        class2.method_65(BookmarkStart.b("焱堳張䠷䨹夻娽", num));
                        class2.method_25(A_1);
                        if (class2.method_74().Count > 0)
                        {
                            for (int k = 0; k < class2.method_74().Count; k++)
                            {
                                if ((class2.method_74().method_4(k).method_69().Right > A_1) && (class2.method_74().method_4(k).method_69().Left < A_1))
                                {
                                    class2.method_74().method_4(k).method_65(BookmarkStart.b("焱堳張䠷䨹夻娽", num));
                                    class2.method_74().method_4(k).method_25(A_1);
                                    class2.method_97(A_1 - A_0.method_69().X, 0f, A_1 - A_0.method_69().X, 0f);
                                }
                                else if (class2.method_74().method_4(k).method_69().Left > A_1)
                                {
                                    RectangleF ef4 = new RectangleF();
                                    class2.method_74().method_4(k).method_70(ef4);
                                    class2.method_74().method_4(k).method_74().method_12(0);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void method_94(Class375 A_0)
    {
        RectangleF ef = A_0.method_69();
        float num = this.method_81(A_0);
        ef.Height = Math.Max(ef.Height, num);
        TableCell cell = (A_0.method_73() is TableCell) ? (A_0.method_73() as TableCell) : ((A_0.method_73() as Class65).method_2() as TableCell);
        if (!cell.OwnerRow.OwnerTable.IsTextBox)
        {
            float num2 = 0f;
            if (cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
            {
                num2 = cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
            }
            float num3 = ((float) A_0.method_73().imethod_0().imethod_1().method_4()) - num2;
            if (num3 > 0f)
            {
                ef.Y -= num3;
                ef.Height += num3;
            }
            float num4 = ((float) A_0.method_73().imethod_0().imethod_1().method_0()) - num2;
            if (num4 > 0f)
            {
                ef.X -= num4;
                ef.Width += num4;
            }
            float num6 = ((float) A_0.method_73().imethod_0().imethod_1().method_8()) - num2;
            if (num6 > 0f)
            {
                ef.Width += num6;
            }
            float num5 = ((float) A_0.method_73().imethod_0().imethod_0().method_12()) - num2;
            if (num5 > 0f)
            {
                ef.Height += num5;
            }
            int count = cell.ChildObjects.Count;
            if (((cell != null) && (count > 0)) && ((num2 > 0f) && (cell.ChildObjects[count - 1] is Paragraph)))
            {
                Paragraph paragraph = cell.ChildObjects[count - 1] as Paragraph;
                if (((paragraph.Format.BeforeSpacing != 0f) && !paragraph.Format.BeforeAutoSpacing) && (paragraph.Format.LineSpacingRule == LineSpacingRule.Multiple))
                {
                    ef.Height -= paragraph.Format.BeforeSpacing;
                }
            }
            A_0.method_70(ef);
        }
    }

    private double method_95()
    {
        double num = 0.0;
        TableCell cell1 = this.table_0.Rows[this.method_34()].Cells[this.int_3];
        TableCell cell = null;
        int num2 = this.int_3 + 1;
        if (this.int_3 < (this.table_0.Rows[this.method_34()].Cells.Count - 1))
        {
            cell = this.table_0.Rows[this.method_34()].Cells[num2];
        }
        while (cell != null)
        {
            if (cell.CellFormat.HorizontalMerge != CellMerge.Continue)
            {
                return num;
            }
            num += cell.LayoutWidth;
            num2++;
            if (num2 < this.table_0.Rows[this.method_34()].Cells.Count)
            {
                cell = this.table_0.Rows[this.method_34()].Cells[num2];
            }
            else
            {
                cell = null;
            }
        }
        return num;
    }

    private Class615 method_96()
    {
        if ((this.int_3 + 1) >= this.table_0.Rows[this.method_34()].Cells.Count)
        {
            return null;
        }
        this.int_3++;
        Interface3 interface2 = null;
        if (((this.class820_0 != null) && (this.class820_0.method_3() != null)) && (this.method_34() == (this.class820_0.method_1() - 1)))
        {
            interface2 = this.class820_0.method_3()[this.int_3];
            if (interface2 == null)
            {
                interface2 = new Class65(this.method_33().imethod_7(this.method_34(), this.int_3));
            }
        }
        if (interface2 == null)
        {
            interface2 = this.method_33().imethod_7(this.method_34(), this.int_3);
        }
        return Class615.smethod_0(interface2, base.interface30_0, (float) base.class774_0.method_2());
    }

    private Class615 method_97()
    {
        if ((this.int_3 > -1) && (this.int_3 < this.table_0.Rows[this.method_34()].Cells.Count))
        {
            return Class615.smethod_0(this.method_33().imethod_7(this.method_34(), this.int_3), base.interface30_0, (float) base.class774_0.method_2());
        }
        return null;
    }

    private void method_98(Class615 A_0)
    {
        switch (A_0.method_1())
        {
            case LayoutState.Unknown:
                this.class375_1.method_74().method_7(this.class375_2);
                this.class375_1.method_31(this.class375_2.method_30());
                this.bool_7 = true;
                return;

            case LayoutState.NotFitted:
                this.method_100(A_0);
                return;

            case LayoutState.Splitted:
                this.method_99(A_0);
                return;

            case LayoutState.Fitted:
                this.method_101(A_0);
                return;

            case LayoutState.Breaked:
                this.vmethod_2(A_0);
                return;
        }
    }

    private void method_99(Class615 A_0)
    {
        Class211 class2 = this.class375_1.method_73().imethod_0() as Class211;
        if (!class2.method_107() && !A_0.method_2().imethod_30())
        {
            (this.class375_2.method_73().imethod_0() as Class211).method_110(true);
            class2.method_110(true);
            this.method_101(A_0);
            if (this.layoutState_1 == LayoutState.Unknown)
            {
                this.layoutState_1 = LayoutState.Splitted;
                this.method_32().imethod_10(true);
            }
        }
        else
        {
            this.method_101(A_0);
            base.layoutState_0 = LayoutState.Unknown;
        }
    }

    public override Class375 vmethod_0(RectangleF A_0)
    {
        int num = 7;
        bool flag = true;
        if ((base.interface1_1 is Table) && !(base.interface1_1 as Table).IsHasCaculatedCellWidth)
        {
            (base.interface1_1 as Table).method_46();
        }
        this.table_0 = base.interface1_1 as Table;
        Section section = null;
        MarginsF sf = this.method_43(ref section);
        if (section.TextDirection == TextDirection.RightToLeft)
        {
            A_0 = new RectangleF(A_0.Location, new SizeF(A_0.Height, A_0.Width));
        }
        this.rectangleF_1 = A_0;
        if (!base.method_4().method_135())
        {
            RectangleF ef = A_0;
            if (this.table_0.IsTextBox && ((this.table_0.TextBoxFormat.VerticalOrigin == VerticalOrigin.Paragraph) || (this.table_0.TextBoxFormat.VerticalOrigin == VerticalOrigin.Line)))
            {
                ef.Y += this.method_32().imethod_15().VertPositionEx;
            }
            if ((((this.method_29().method_32() == 0) && this.table_0.IsTextBox) && !this.table_0.TextBoxFormat.IsInShape) && ((this.table_0.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.InFrontOfText) || (this.table_0.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Behind)))
            {
                TextRange range = this.table_0.TextBox.OwnerParagraph.method_54();
                SizeF ef2 = base.method_4().method_323(range, BookmarkStart.b("ബ", num));
                if ((Class59.smethod_1((double) ef2.Height, (double) A_0.Height, false) > 0) && !((Interface4) this.table_0).imethod_3().imethod_11())
                {
                    this.table_0.IsHasCaculatedCellWidth = false;
                    ((Interface4) this.table_0).imethod_3().imethod_12(true);
                    base.interface1_0 = new Class820(this.method_33(), 0);
                    base.layoutState_0 = LayoutState.NotFitted;
                    if ((Class59.smethod_4(A_0.Height, 0f, 0.75f) > 0) && (Class59.smethod_4(ef2.Height, A_0.Height, 1.5f) > 0))
                    {
                        this.method_29().bool_6 = true;
                    }
                    return null;
                }
            }
            if (((!this.table_0.IsTextBox && (((this.table_0.Rows[0].Height > 0f) && (A_0.Height < this.table_0.Rows[0].Height)) || ((this.table_0.Rows[0].HeightType == TableRowHeightType.Exactly) && (A_0.Height < Math.Abs(this.table_0.Rows[0].Height))))) && ((!this.table_0.IsInCell && !this.table_0.IsFrame) && !((Interface4) this.table_0).imethod_3().imethod_11())) || ((((this.table_0.IsTextBox && !this.table_0.TextBoxFormat.IsInShape) && ((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind))) && ((!ef.IsEmpty || (ef.Height <= 0f)) && ((this.table_0.Rows[0].Height > 0f) && ((this.table_0.Rows[0].Height + this.method_32().imethod_15().VertPositionEx) <= section.PageSetup.PageSize.Height)))) && (((ef.Height < this.table_0.Rows[0].Height) && !this.table_0.TextBoxFormat.IsFitShapeToText) && ((((this.table_0.Rows[0].Cells.Count > 0) && (this.table_0.Rows[0].Cells[0].CellFormat.TextDirection == TextDirection.TopToBottom)) && ((this.table_0.TextBoxFormat.VerticalOrigin == VerticalOrigin.Paragraph) | (this.table_0.TextBoxFormat.VerticalOrigin == VerticalOrigin.Line))) || ((this.table_0.TextBox as ParagraphBase).method_5() == 0)))))
            {
                this.table_0.IsHasCaculatedCellWidth = false;
                ((Interface4) this.table_0).imethod_3().imethod_12(true);
                base.interface1_0 = new Class820(this.method_33(), 0);
                base.layoutState_0 = LayoutState.NotFitted;
                return null;
            }
        }
        if (this.table_0.IsTextBox && (Class59.smethod_4(A_0.Width, 0f, 0.75f) == 0))
        {
            TextBox textBox = this.table_0.TextBox as TextBox;
            if (textBox.Format.TextWrappingStyle == TextWrappingStyle.Inline)
            {
                Paragraph paragraph = textBox.method_28();
                int index = (paragraph.WidgetCollection as DocumentObjectCollection).IndexOf(textBox);
                base.interface1_0 = new Class65(paragraph, textBox, index);
                base.class375_0 = new Class375(this.table_0.TextBox as TextBox);
                base.class375_0.method_70(new RectangleF(A_0.Location, new SizeF(0f, 0f)));
                base.layoutState_0 = LayoutState.Splitted;
                return base.class375_0;
            }
            if (textBox.Format.IsFitShapeToText)
            {
                A_0 = new RectangleF(A_0.Location, new SizeF(section.PageSetup.ClientWidth, A_0.Height));
            }
        }
        if (this.method_32().imethod_13() && (!this.method_32().imethod_9() || this.table_0.IsHasCaculatedCellWidth))
        {
            if ((((this.table_0.Owner != null) && (this.table_0.Owner.Owner != null)) && ((this.table_0.Owner.Owner.Owner != null) && (this.table_0.Owner.Owner.Owner is Table))) && !(this.table_0.Owner.Owner.Owner as Table).IsSDTTable)
            {
                TableCell cell = this.table_0.Owner as TableCell;
                Table table = this.table_0.Owner.Owner.Owner as Table;
                Paddings paddings = !cell.CellFormat.Paddings.IsEmpty ? cell.CellFormat.Paddings : (!table.TableFormat.Paddings.IsEmpty ? table.TableFormat.Paddings : new Paddings());
                sf = new MarginsF(paddings.Left, paddings.Top, paddings.Right, paddings.Bottom);
            }
            else if ((((this.table_0.IsTextBox && this.table_0.IsTextBoxInTable) && (this.table_0.TextBoxFormat.IsAllowInCell && (this.table_0.Owner != null))) && (((this.table_0.Owner.Owner != null) && (this.table_0.Owner.Owner.Owner != null)) && ((this.table_0.Owner.Owner.Owner.Owner != null) && (this.table_0.Owner.Owner.Owner.Owner is Table)))) && !(this.table_0.Owner.Owner.Owner.Owner as Table).IsSDTTable)
            {
                TableCell cell2 = this.table_0.Owner.Owner as TableCell;
                Table table2 = this.table_0.Owner.Owner.Owner.Owner as Table;
                Paddings paddings2 = !cell2.CellFormat.Paddings.IsEmpty ? cell2.CellFormat.Paddings : (!table2.TableFormat.Paddings.IsEmpty ? table2.TableFormat.Paddings : new Paddings());
                sf = new MarginsF(paddings2.Left, paddings2.Top, paddings2.Right, paddings2.Bottom);
            }
            this.method_36(this.table_0, sf, ref A_0);
        }
        else
        {
            for (IDocumentObject obj2 = this.table_0.PreviousSibling; obj2 != null; obj2 = obj2.PreviousSibling)
            {
                if (obj2 is Table)
                {
                    if (((!(obj2 as Interface4).imethod_3().imethod_13() && ((obj2 as Table).LastLayoutPage == base.method_4().method_28())) && (((obj2 as Table).TableFormat.HorizontalAlignment == RowAlignment.Left) && (section.Columns.Count == 1))) && (A_0.Y < (obj2 as Table).rectangleF_1.Bottom))
                    {
                        A_0.Y = (obj2 as Table).rectangleF_1.Bottom + 0.75f;
                        A_0.X = (obj2 as Table).rectangleF_1.X;
                        flag = false;
                    }
                    break;
                }
                if (!(obj2 is Paragraph) || !((obj2 as Paragraph).Text == string.Empty))
                {
                    break;
                }
            }
        }
        this.method_91(ref A_0, flag);
        if (((this.table_0 != null) && this.table_0.IsTextBox) && base.method_4().method_19().IsAtLast)
        {
            this.table_0.Rows[0].HeightType = TableRowHeightType.AtLeast;
        }
        Font font = null;
        SizeF ef4 = new SizeF();
        if (base.method_4().method_1())
        {
            sprᝪ rᝪ = (this.table_0.Rows[0].Cells[0].LastParagraph != null) ? base.method_4().method_376(this.table_0.Rows[0].Cells[0].LastParagraph.BreakCharacterFormat) : base.method_4().method_376(this.table_0.Rows[0].Cells[0].CharacterFormat);
            ef4 = base.method_4().method_309(BookmarkStart.b("ബ", num), rᝪ, null);
        }
        else
        {
            font = (this.table_0.Rows[0].Cells[0].LastParagraph != null) ? this.table_0.Rows[0].Cells[0].LastParagraph.BreakCharacterFormat.Font : this.table_0.Rows[0].Cells[0].CharacterFormat.Font;
            ef4 = base.method_4().method_316(BookmarkStart.b("ബ", num), font, null);
        }
        ef4.Width = this.table_0.LayoutWidth;
        Section section2 = this.table_0.method_55();
        if (((!this.table_0.TableBounds.IsEmpty && this.table_0.TableFormat.WrapTextAround) && (!this.table_0.IsTextBox && !this.table_0.IsSDTTable)) && ((((this.rectangleF_1.Width < A_0.Width) && (section2 != null)) && ((section2.Columns.Count > 1) && ((Interface1) section2).imethod_0().imethod_44())) || ((base.method_10() && (this.method_32().imethod_15().VertPositionEx < 0f)) && (this.method_32().imethod_15().VertRelationTo == VerticalRelation.Paragraph))))
        {
            A_0 = this.table_0.TableBounds;
            this.method_45(ref A_0);
            base.method_16(A_0);
        }
        else
        {
            this.method_44(ef4, ref A_0);
        }
        if (((this.table_0.IsTextBox && !base.method_4().method_135()) && ((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline) && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind))) && (((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && (this.table_0.TextBox.Format.HorizontalOrigin != HorizontalOrigin.RightMarginArea)) && (this.table_0.TextBox.Format.HorizontalOrigin != HorizontalOrigin.LeftMarginArea)))
        {
            RectangleF ef6 = this.method_40(this.table_0.TextBox.Format, A_0);
            if (!ef6.IsEmpty)
            {
                this.method_45(ref A_0);
                base.method_16(ef6);
            }
        }
        this.method_46();
        base.method_22(A_0.Location);
        this.double_2 = new double[this.table_0.Rows[this.method_33().imethod_4()].Cells.Count];
        this.int_4 = new int[this.table_0.Rows[this.method_33().imethod_4()].Cells.Count];
        this.rectangleF_0 = A_0;
        this.table_0.TableBounds = A_0;
        this.method_37();
        while (this.method_47())
        {
            while (this.method_34() < this.table_0.Rows.Count)
            {
                if (!this.table_0.Rows[this.method_34()].Hidden)
                {
                    break;
                }
                this.int_2++;
            }
            if (this.method_34() < this.table_0.Rows.Count)
            {
                this.method_48();
                this.method_49();
            }
            else
            {
                base.layoutState_0 = LayoutState.Fitted;
            }
            if (base.layoutState_0 != LayoutState.Unknown)
            {
                goto Label_0DE1;
            }
        }
        if (this.bool_7)
        {
            base.layoutState_0 = LayoutState.Fitted;
        }
    Label_0DE1:
        this.method_77();
        this.method_39();
        if (((this.table_0.IsTextBox && !((this.table_0.TextBox as TextBox).interface23_0 as Class205).method_9()) && (this.table_0.IsTextBox && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind))) && ((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && ((this.rectangleF_1.Y - base.class375_0.method_69().Y) > 1f)))
        {
            base.class375_0.method_35(true);
            ((this.table_0.TextBox as TextBox).interface23_0 as Class205).method_10(true);
        }
        else if ((!this.table_0.IsTextBox && !(this.table_0.interface23_0 as Class205).method_9()) && (this.table_0.IsFrame && ((this.class616_0.method_3().method_13().Y - base.class375_0.method_69().Y) > 1f)))
        {
            base.class375_0.method_35(true);
            (this.table_0.interface23_0 as Class205).method_10(true);
        }
        this.table_0.LastLayoutPage = base.method_4().method_28();
        this.method_38();
        DocumentObject owner = this.table_0.Owner;
        if (this.table_0.IsTextBox)
        {
            Class312 class2 = new Class312();
            RectangleF ef10 = base.class375_0.method_69();
            ef10 = new RectangleF(ef10.X - this.table_0.TextBoxFormat.WrapDistanceLeft, ef10.Y - this.table_0.TextBoxFormat.WrapDistanceTop, (ef10.Width + this.table_0.TextBoxFormat.WrapDistanceRight) + this.table_0.TextBoxFormat.WrapDistanceLeft, (ef10.Height + this.table_0.TextBoxFormat.WrapDistanceBottom) + this.table_0.TextBoxFormat.WrapDistanceTop);
            class2.method_17(this.table_0.TextBoxFormat.IsAllowInCell);
            class2.method_15(this.table_0.TextBoxFormat.AllowOverlap);
            class2.method_1(ef10);
            class2.method_2().method_1(this.table_0.TextBoxFormat.TextWrappingStyle);
            class2.method_2().method_3(this.table_0.TextBoxFormat.TextWrappingType);
            class2.method_5(this.table_0.TextBox as Interface1);
            class2.method_21(base.method_4().method_138());
            class2.method_23(base.method_4().method_137());
            Paragraph paragraph2 = (this.table_0.TextBox as TextBox).method_28();
            class2.method_7(((paragraph2 == null) || !paragraph2.IsInCell) ? null : (paragraph2.Owner as TableCell));
            if (((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)) && ((this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline) && !this.table_0.TextBox.Format.IsInShape))
            {
                base.method_4().method_28().method_40(class2);
            }
            if (!base.class375_0.method_34())
            {
                long zOrderEx = (this.table_0.TextBox as TextBox).ZOrderEx;
                Class199 class3 = new Class199();
                class3.method_1(null);
                class3.method_5(false);
                class3.method_3(base.class375_0);
                class3.method_9(base.method_4().method_135());
                class3.method_7(zOrderEx);
                if (this.table_0.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.InFrontOfText)
                {
                    base.method_4().method_28().method_41(class3);
                    class3.method_2().method_33(true);
                }
                else if (this.table_0.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Behind)
                {
                    base.method_4().method_28().method_44(class3);
                    class3.method_2().method_33(true);
                }
                else if ((zOrderEx > 0L) && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline))
                {
                    base.method_4().method_28().method_41(class3);
                    class3.method_2().method_33(true);
                }
                else if ((zOrderEx < 0L) && (this.table_0.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline))
                {
                    base.method_4().method_28().method_44(class3);
                    class3.method_2().method_33(true);
                }
            }
        }
        else if (!this.table_0.IsTextBox && (this.table_0.TableFormat.WrapTextAround || this.table_0.IsFrame))
        {
            Class312 class4 = new Class312();
            RectangleF ef11 = base.class375_0.method_69();
            if (this.table_0.IsFrame)
            {
                float frameHorizontalDistanceFromTextEx = this.table_0.FrameFormat.FrameHorizontalDistanceFromTextEx;
                float frameVerticalDistanceFromTextEx = this.table_0.FrameFormat.FrameVerticalDistanceFromTextEx;
                ushort frameHeight = (ushort) this.table_0.FrameFormat.FrameHeight;
                bool flag2 = (frameHeight & 0x8000) != 0;
                float num7 = ef11.Bottom - (base.interface30_0 as Class304).method_8().Y;
                if (((!flag2 && (this.table_0.FrameFormat.FrameHeightRule == FrameSizeRule.Exact)) || (flag2 && (num7 < this.table_0.FrameFormat.FrameHeightEx))) && (!this.table_0.IsInSameFrameWithNextSibling || (this.table_0.NextSibling is Table)))
                {
                    ef11.Height += this.table_0.FrameFormat.FrameHeightEx - num7;
                }
                ef11 = new RectangleF(ef11.X - frameHorizontalDistanceFromTextEx, ef11.Y - frameVerticalDistanceFromTextEx, ef11.Width + (frameHorizontalDistanceFromTextEx * 2f), ef11.Height + (frameVerticalDistanceFromTextEx * 2f));
            }
            else
            {
                ef11 = new RectangleF(ef11.X - this.method_32().imethod_15().DistanceFromLeft, ef11.Y - this.method_32().imethod_15().DistanceFromTop, (ef11.Width + this.method_32().imethod_15().DistanceFromRight) + this.method_32().imethod_15().DistanceFromLeft, (ef11.Height + this.method_32().imethod_15().DistanceFromBottom) + this.method_32().imethod_15().DistanceFromTop);
            }
            if (!this.table_0.method_41(this.table_0))
            {
                class4.method_17(this.table_0.IsInCell);
            }
            class4.method_15(this.method_32().imethod_15().TableOverlap);
            class4.method_5(this.table_0);
            class4.method_1(ef11);
            class4.method_2().method_1(TextWrappingStyle.Square);
            class4.method_2().method_3(TextWrappingType.Both);
            class4.method_21(base.method_4().method_138());
            class4.method_23(base.method_4().method_137());
            class4.method_7(class4.method_16() ? (this.table_0.Owner as TableCell) : null);
            if (((this.table_0.Owner is TableCell) && !(this.table_0.Owner.Owner.Owner as Table).IsTextBox) || !(this.table_0.Owner is TableCell))
            {
                base.method_4().method_28().method_40(class4);
            }
        }
        return base.class375_0;
    }

    protected virtual void vmethod_2(Class615 A_0)
    {
        Class211 class2 = this.class375_1.method_73().imethod_0() as Class211;
        if (class2.method_107())
        {
            this.class65_0[this.int_3] = (A_0.method_0() is Class65) ? (A_0.method_0() as Class65) : new Class65(A_0.method_8() as Interface3);
            (this.class65_0[this.int_3].Interface1.imethod_0() as Class211).method_110(true);
        }
        this.class375_1.method_74().method_7(this.class375_2);
        this.class375_1.method_31(this.class375_2.method_30());
        if (class2.method_111())
        {
            this.double_2[this.int_3] = ((this.class375_2.method_69().Height + class2.Interface22.imethod_1().method_12()) + class2.Interface22.imethod_0().method_12()) + class2.Interface22.imethod_0().method_4();
            if (this.class820_0 != null)
            {
                this.int_4[this.int_3] = this.method_34() - (this.class820_0.method_1() - 1);
            }
            else
            {
                this.int_4[this.int_3] = this.method_34();
            }
        }
        else if (!class2.method_113())
        {
            this.method_58(A_0);
        }
        this.bool_7 = true;
        this.layoutState_1 = LayoutState.Breaked;
    }
}

