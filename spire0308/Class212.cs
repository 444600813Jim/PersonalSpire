using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class212 : Class211
{
    private bool bool_53;
    private bool bool_54;
    private bool bool_55;
    private bool bool_56;
    private bool bool_57;
    private bool bool_58;
    private bool bool_59;
    private bool bool_60;
    private float float_16;
    private float float_17;
    private float float_18;
    private float float_19;
    private float float_20;
    private int int_3;
    private RectangleF rectangleF_3;
    private TableCell tableCell_0;

    internal Class212(TableCell A_0) : base(ChildrenLayoutDirection.Vertical)
    {
        this.int_3 = -1;
        this.rectangleF_3 = new RectangleF();
        this.tableCell_0 = A_0;
        Class212 class2 = (A_0.PreviousSibling != null) ? ((A_0.PreviousSibling as Interface1).imethod_0() as Class212) : null;
        if (class2 == null)
        {
            this.method_133(0);
        }
        else
        {
            this.method_133(class2.method_132() + 1);
        }
        this.method_160();
        this.method_159();
        CellFormat cellFormat = this.tableCell_0.CellFormat;
        if (cellFormat.TextDirection != TextDirection.TopToBottom)
        {
            base.Interface23.imethod_31(true);
        }
        base.method_123(cellFormat.VerticalAlignment);
        base.Interface23.imethod_27(cellFormat.TextWrap);
    }

    internal RectangleF method_128()
    {
        return this.rectangleF_3;
    }

    internal void method_129(RectangleF A_0)
    {
        this.rectangleF_3 = A_0;
    }

    internal float method_130()
    {
        return this.float_20;
    }

    internal void method_131(float A_0)
    {
        this.float_20 = A_0;
    }

    public int method_132()
    {
        return this.int_3;
    }

    public void method_133(int A_0)
    {
        this.int_3 = A_0;
    }

    internal bool method_134()
    {
        return this.bool_53;
    }

    internal void method_135(bool A_0)
    {
        this.bool_53 = A_0;
    }

    internal bool method_136()
    {
        return this.bool_54;
    }

    internal void method_137(bool A_0)
    {
        this.bool_54 = A_0;
    }

    internal bool method_138()
    {
        return this.bool_55;
    }

    internal void method_139(bool A_0)
    {
        this.bool_55 = A_0;
    }

    internal bool method_140()
    {
        return this.bool_56;
    }

    internal void method_141(bool A_0)
    {
        this.bool_56 = A_0;
    }

    internal float method_142()
    {
        return this.float_16;
    }

    internal void method_143(float A_0)
    {
        this.float_16 = A_0;
    }

    internal float method_144()
    {
        return this.float_17;
    }

    internal void method_145(float A_0)
    {
        this.float_17 = A_0;
    }

    internal float method_146()
    {
        return this.float_18;
    }

    internal void method_147(float A_0)
    {
        this.float_18 = A_0;
    }

    internal float method_148()
    {
        return this.float_19;
    }

    internal void method_149(float A_0)
    {
        this.float_19 = A_0;
    }

    internal bool method_150()
    {
        return this.bool_57;
    }

    internal void method_151(bool A_0)
    {
        this.bool_57 = A_0;
    }

    internal bool method_152()
    {
        return this.bool_58;
    }

    internal void method_153(bool A_0)
    {
        this.bool_58 = A_0;
    }

    internal bool method_154()
    {
        return this.bool_59;
    }

    internal void method_155(bool A_0)
    {
        this.bool_59 = A_0;
    }

    internal bool method_156()
    {
        return this.bool_60;
    }

    internal void method_157(bool A_0)
    {
        this.bool_60 = A_0;
    }

    private void method_158()
    {
        int cellIndex = this.tableCell_0.GetCellIndex();
        int rowIndex = this.tableCell_0.OwnerRow.GetRowIndex();
        if (cellIndex != 0)
        {
            base.Interface22.imethod_1().method_1(0.0);
        }
        if (cellIndex != (this.tableCell_0.OwnerRow.Cells.Count - 1))
        {
            base.Interface22.imethod_1().method_9(0.0);
        }
        if (rowIndex != 0)
        {
            base.Interface22.imethod_1().method_5(0.0);
        }
        if (rowIndex != (this.tableCell_0.OwnerRow.OwnerTable.Rows.Count - 1))
        {
            base.Interface22.imethod_1().method_13(0.0);
        }
    }

    private void method_159()
    {
        CellFormat cellFormat = this.tableCell_0.CellFormat;
        int num = this.method_132();
        base.method_104((cellFormat.HorizontalMerge == CellMerge.Start) && (num < (this.tableCell_0.OwnerRow.Cells.Count - 1)));
        base.method_106(cellFormat.HorizontalMerge == CellMerge.Continue);
        base.method_112(cellFormat.VerticalMerge == CellMerge.Start);
        base.method_114(cellFormat.VerticalMerge == CellMerge.Continue);
    }

    private void method_160()
    {
        Paddings paddings = this.tableCell_0.CellFormat.Paddings;
        float left = this.tableCell_0.CellFormat.Paddings.Left;
        float right = this.tableCell_0.CellFormat.Paddings.Right;
        float top = this.tableCell_0.CellFormat.Paddings.Top;
        float bottom = this.tableCell_0.CellFormat.Paddings.Bottom;
        int num5 = this.method_132();
        int num6 = (((Interface1) this.tableCell_0.OwnerRow).imethod_0() as Class211).method_101();
        int num7 = this.tableCell_0.OwnerRow.Cells.Count - 1;
        int num8 = this.tableCell_0.OwnerRow.OwnerTable.Rows.Count - 1;
        float num9 = this.method_161(num5);
        float num10 = this.method_162(num5, num6);
        float num11 = this.method_163(num5, num7);
        float num12 = this.method_164(num5, num7, num6, num8);
        float num13 = 0f;
        if (this.tableCell_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            num13 = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
        }
        if (this.tableCell_0.CellFormat.SamePaddingsAsTable)
        {
            if (this.tableCell_0.OwnerRow.HasTblPrEx)
            {
                left = this.tableCell_0.OwnerRow.RowFormat.Paddings.Left;
                right = this.tableCell_0.OwnerRow.RowFormat.Paddings.Right;
                top = this.tableCell_0.OwnerRow.RowFormat.Paddings.Top;
                bottom = this.tableCell_0.OwnerRow.RowFormat.Paddings.Bottom;
            }
            else
            {
                left = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Left;
                right = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Right;
                top = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Top;
                bottom = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Bottom;
            }
            for (int i = 0; i < this.tableCell_0.OwnerRow.Cells.Count; i++)
            {
                if (!this.tableCell_0.OwnerRow.Cells[i].CellFormat.SamePaddingsAsTable)
                {
                    this.method_174(ref top, i);
                }
            }
            for (int j = 0; j < this.tableCell_0.OwnerRow.Cells.Count; j++)
            {
                if (!this.tableCell_0.OwnerRow.Cells[j].CellFormat.SamePaddingsAsTable)
                {
                    this.method_176(ref bottom, j);
                }
            }
        }
        else
        {
            left = this.method_171();
            right = this.method_172();
            top = this.method_173();
            bottom = this.method_175();
        }
        base.Interface22.imethod_0().method_1(((left - num9) <= 0f) ? ((double) 0f) : ((double) (left - num9)));
        base.Interface22.imethod_0().method_5((top > 0f) ? ((double) top) : ((this.tableCell_0.OwnerRow.RowFormat.Paddings.Top > 0f) ? ((double) this.tableCell_0.OwnerRow.RowFormat.Paddings.Top) : ((double) 0f)));
        base.Interface22.imethod_0().method_9(((right - num11) <= 0f) ? ((double) 0f) : ((double) (right - num11)));
        base.Interface22.imethod_0().method_13((bottom > 0f) ? ((double) bottom) : ((this.tableCell_0.OwnerRow.RowFormat.Paddings.Bottom > 0f) ? ((double) this.tableCell_0.OwnerRow.RowFormat.Paddings.Bottom) : ((double) 0f)));
        base.Interface22.imethod_1().method_1((double) (num13 + num9));
        base.Interface22.imethod_1().method_5((double) (num13 + num10));
        base.Interface22.imethod_1().method_9((double) (num13 + num11));
        base.Interface22.imethod_1().method_13((double) (num13 + num12));
    }

    private float method_161(int A_0)
    {
        Borders borders = this.tableCell_0.CellFormat.Borders;
        Borders borders2 = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Borders;
        Borders borders3 = this.tableCell_0.OwnerRow.RowFormat.Borders;
        float num = borders.Left.LineWidth / 2f;
        if (this.tableCell_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            return (((borders.Left.BorderType != BorderStyle.None) ? borders.Left.LineWidth : borders2.Vertical.LineWidth) / 2f);
        }
        if (A_0 > 0)
        {
            TableCell cell = this.method_165(A_0 - 1);
            if ((borders.Left.BorderType != BorderStyle.None) && cell.CellFormat.Borders.Right.IsBorderDefined)
            {
                this.method_139(this.method_167(borders.Left.LineWidth, cell.CellFormat.Borders.Right.LineWidth, true, ref num));
                return num;
            }
            if (borders.Left.BorderType != BorderStyle.None)
            {
                this.method_139(this.method_167(borders.Left.LineWidth, borders2.Vertical.LineWidth, true, ref num));
                return num;
            }
            if (cell.CellFormat.Borders.Right.IsBorderDefined)
            {
                if (borders2.Vertical.LineWidth < cell.CellFormat.Borders.Right.LineWidth)
                {
                    num = cell.CellFormat.Borders.Right.LineWidth / 2f;
                    this.method_139(true);
                    return num;
                }
                if ((borders.Left.BorderType == BorderStyle.None) && borders.Left.HasNoneStyle)
                {
                    this.method_139(true);
                    return 0f;
                }
                num = borders2.Vertical.LineWidth / 2f;
                this.method_139((borders3.Vertical.BorderType == BorderStyle.None) ? (borders2.Vertical.BorderType == BorderStyle.None) : false);
                return num;
            }
            return (borders2.Vertical.LineWidth / 2f);
        }
        return (((borders.Left.BorderType != BorderStyle.None) ? borders.Left.LineWidth : borders2.Left.LineWidth) / 2f);
    }

    private float method_162(int A_0, int A_1)
    {
        Borders borders = this.tableCell_0.CellFormat.Borders;
        Borders borders2 = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Borders;
        Borders borders3 = this.tableCell_0.OwnerRow.RowFormat.Borders;
        float num = borders.Top.LineWidth / 2f;
        if (this.tableCell_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            return (((borders.Top.BorderType != BorderStyle.None) ? borders.Top.LineWidth : borders2.Horizontal.LineWidth) / 2f);
        }
        if (A_1 > 0)
        {
            TableCell cell = this.method_166(A_1 - 1);
            if ((borders.Top.BorderType != BorderStyle.None) && cell.CellFormat.Borders.Bottom.IsBorderDefined)
            {
                this.method_135(this.method_167(borders.Top.LineWidth, cell.CellFormat.Borders.Bottom.LineWidth, true, ref num));
                return num;
            }
            if (borders.Top.BorderType != BorderStyle.None)
            {
                this.method_135(this.method_167(borders.Top.LineWidth, borders2.Horizontal.LineWidth, true, ref num));
                return num;
            }
            if (cell.CellFormat.Borders.Bottom.IsBorderDefined)
            {
                if (borders2.Horizontal.LineWidth < cell.CellFormat.Borders.Bottom.LineWidth)
                {
                    num = cell.CellFormat.Borders.Bottom.LineWidth / 2f;
                    this.method_135(true);
                    return num;
                }
                num = borders2.Horizontal.LineWidth / 2f;
                this.method_135((borders3.Horizontal.BorderType == BorderStyle.None) ? (borders2.Horizontal.BorderType == BorderStyle.None) : false);
                return num;
            }
            return (borders2.Horizontal.LineWidth / 2f);
        }
        return (((borders.Top.BorderType != BorderStyle.None) ? borders.Top.LineWidth : borders2.Top.LineWidth) / 2f);
    }

    private float method_163(int A_0, int A_1)
    {
        Borders borders = this.tableCell_0.CellFormat.Borders;
        Borders borders2 = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Borders;
        int num = this.method_169(A_0, A_1);
        if ((num - 1) > A_0)
        {
            borders = this.tableCell_0.OwnerRow.Cells[num - 1].CellFormat.Borders;
        }
        float num6 = borders.Right.LineWidth / 2f;
        if (this.tableCell_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            return (((borders.Right.BorderType != BorderStyle.None) ? borders.Right.LineWidth : borders2.Vertical.LineWidth) / 2f);
        }
        if (A_0 >= A_1)
        {
            return (((borders.Right.BorderType != BorderStyle.None) ? borders.Right.LineWidth : borders2.Right.LineWidth) / 2f);
        }
        TableCell cell = this.method_165(num);
        if (((borders.Right.BorderType != BorderStyle.None) || borders.Right.HasNoneStyle) && cell.CellFormat.Borders.Left.IsBorderDefined)
        {
            this.method_141(this.method_167(borders.Right.LineWidth, cell.CellFormat.Borders.Left.LineWidth, false, ref num6));
        }
        else if (borders.Right.BorderType != BorderStyle.None)
        {
            this.method_141(this.method_167(borders.Right.LineWidth, borders2.Vertical.LineWidth, false, ref num6));
        }
        else if (cell.CellFormat.Borders.Left.IsBorderDefined)
        {
            this.method_141(this.method_167(borders2.Vertical.LineWidth, cell.CellFormat.Borders.Left.LineWidth, false, ref num6));
        }
        else
        {
            num6 = borders2.Vertical.LineWidth / 2f;
            this.method_141(true);
        }
        if (borders.Right.BorderType == BorderStyle.Cleared)
        {
            int num5 = (((Interface1) cell.OwnerRow).imethod_0() as Class211).method_101();
            int num3 = (((Interface1) this.tableCell_0.OwnerRow).imethod_0() as Class211).method_101();
            if (num5 >= num3)
            {
                return num6;
            }
            if (cell.CellFormat.Borders.Left.BorderType == BorderStyle.Cleared)
            {
                (((Interface1) cell).imethod_0() as Class212).method_139(true);
            }
            int num4 = (((Interface1) cell).imethod_0() as Class212).method_132();
            if (num4 <= 0)
            {
                return num6;
            }
            for (int i = num5; i < num3; i++)
            {
                int num7 = this.method_168(cell, num4, i);
                if (num7 > 0)
                {
                    (((Interface1) this.tableCell_0.OwnerRow.OwnerTable.Rows[i].Cells[num7 - 1]).imethod_0() as Class212).method_141(false);
                }
            }
        }
        return num6;
    }

    private float method_164(int A_0, int A_1, int A_2, int A_3)
    {
        Borders borders = this.tableCell_0.CellFormat.Borders;
        Borders borders2 = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Borders;
        float num = borders.Bottom.LineWidth / 2f;
        if (this.tableCell_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            return (((borders.Bottom.BorderType != BorderStyle.None) ? borders.Bottom.LineWidth : borders2.Horizontal.LineWidth) / 2f);
        }
        int num2 = this.method_170(A_0, A_2, A_3);
        if (A_2 >= A_3)
        {
            return (((borders.Bottom.BorderType != BorderStyle.None) ? borders.Bottom.LineWidth : borders2.Bottom.LineWidth) / 2f);
        }
        int num3 = this.method_168(this.tableCell_0, A_0, num2);
        TableCell cell = this.method_166(num2);
        if ((borders.Bottom.BorderType != BorderStyle.None) && cell.CellFormat.Borders.Top.IsBorderDefined)
        {
            this.method_137(this.method_167(borders.Bottom.LineWidth, cell.CellFormat.Borders.Top.LineWidth, false, ref num));
        }
        else if (borders.Bottom.BorderType != BorderStyle.None)
        {
            this.method_137(this.method_167(borders.Bottom.LineWidth, borders2.Horizontal.LineWidth, false, ref num));
        }
        else if (cell.CellFormat.Borders.Top.IsBorderDefined)
        {
            this.method_137(this.method_167(borders2.Horizontal.LineWidth, cell.CellFormat.Borders.Top.LineWidth, false, ref num));
        }
        else if ((borders.Bottom.BorderType == BorderStyle.None) && borders.Bottom.HasNoneStyle)
        {
            this.method_137(true);
            num = 0f;
        }
        else
        {
            num = borders2.Horizontal.LineWidth / 2f;
        }
        if (borders.Bottom.BorderType != BorderStyle.None)
        {
            this.method_137(borders.Bottom.BorderType == BorderStyle.Cleared);
        }
        if ((this.method_136() && (this.tableCell_0.OwnerRow.OwnerTable.Rows[num2].Cells[num3].Width < this.tableCell_0.Width)) && (borders.Bottom.BorderType != BorderStyle.None))
        {
            this.method_137(false);
        }
        return num;
    }

    private TableCell method_165(int A_0)
    {
        int num = (((Interface1) this.tableCell_0.OwnerRow).imethod_0() as Class211).method_101();
        if ((num > 0) && (this.tableCell_0.CellFormat.VerticalMerge == CellMerge.Continue))
        {
            int num3 = this.method_168(this.tableCell_0, A_0, num - 1);
            if (this.tableCell_0.OwnerRow.OwnerTable.Rows[num - 1].Cells[num3].CellFormat.VerticalMerge == CellMerge.Continue)
            {
                for (int i = num - 1; i >= 0; i--)
                {
                    num3 = this.method_168(this.tableCell_0, A_0, i);
                    if (this.tableCell_0.OwnerRow.OwnerTable.Rows[i].Cells[num3].CellFormat.VerticalMerge == CellMerge.Start)
                    {
                        return this.tableCell_0.OwnerRow.OwnerTable.Rows[i].Cells[num3];
                    }
                }
            }
            else if (this.tableCell_0.OwnerRow.OwnerTable.Rows[num - 1].Cells[num3].CellFormat.VerticalMerge == CellMerge.Start)
            {
                return this.tableCell_0.OwnerRow.OwnerTable.Rows[num - 1].Cells[num3];
            }
        }
        return this.tableCell_0.OwnerRow.Cells[A_0];
    }

    private TableCell method_166(int A_0)
    {
        int num = this.method_132();
        int num2 = this.method_168(this.tableCell_0, num, A_0);
        if (num2 > 0)
        {
            if (this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[num2 - 1].CellFormat.HorizontalMerge == CellMerge.Continue)
            {
                for (int i = num2 - 1; i >= 0; i--)
                {
                    if (this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[i].CellFormat.HorizontalMerge == CellMerge.Start)
                    {
                        return this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[i];
                    }
                }
            }
            else if ((this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[num2 - 1].CellFormat.HorizontalMerge == CellMerge.Start) && (this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[num2].CellFormat.HorizontalMerge != CellMerge.Start))
            {
                return this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[num2 - 1];
            }
        }
        return this.tableCell_0.OwnerRow.OwnerTable.Rows[A_0].Cells[num2];
    }

    private bool method_167(float A_0, float A_1, bool A_2, ref float A_3)
    {
        if (A_2 ? (A_0 < A_1) : (A_0 < A_1))
        {
            A_3 = A_1 / 2f;
            return true;
        }
        A_3 = A_0 / 2f;
        return false;
    }

    private int method_168(TableCell A_0, int A_1, int A_2)
    {
        float num2 = 0f;
        for (int i = 0; i < A_1; i++)
        {
            num2 += A_0.OwnerRow.Cells[i].Width;
        }
        float num4 = 0f;
        for (int j = 0; j < A_0.OwnerRow.OwnerTable.Rows[A_2].Cells.Count; j++)
        {
            num4 += A_0.OwnerRow.OwnerTable.Rows[A_2].Cells[j].Width;
            if (num2 == num4)
            {
                if (j == (A_0.OwnerRow.OwnerTable.Rows[A_2].Cells.Count - 1))
                {
                    return j;
                }
                return (j + 1);
            }
            if (num2 < num4)
            {
                return j;
            }
        }
        return 0;
    }

    private int method_169(int A_0, int A_1)
    {
        for (int i = A_0 + 1; i < (A_1 + 1); i++)
        {
            if (this.tableCell_0.OwnerRow.Cells[i].CellFormat.HorizontalMerge != CellMerge.Continue)
            {
                return i;
            }
        }
        return A_0;
    }

    private int method_170(int A_0, int A_1, int A_2)
    {
        for (int i = A_1 + 1; i < (A_2 + 1); i++)
        {
            if (A_0 >= this.tableCell_0.OwnerRow.OwnerTable.Rows[i].Cells.Count)
            {
                return i;
            }
            if (this.tableCell_0.OwnerRow.OwnerTable.Rows[i].Cells[A_0].CellFormat.VerticalMerge != CellMerge.Continue)
            {
                return i;
            }
        }
        return A_1;
    }

    private float method_171()
    {
        float left = this.tableCell_0.CellFormat.Paddings.Left;
        if (this.tableCell_0.CellFormat.Paddings.Left != -0.05f)
        {
            return left;
        }
        if (!this.tableCell_0.OwnerRow.RowFormat.Paddings.HasKey(1) && this.tableCell_0.OwnerRow.RowFormat.Paddings.IsEmpty)
        {
            if (!this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.HasKey(1) && this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
            {
                return 5.4f;
            }
            return this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Left;
        }
        return this.tableCell_0.OwnerRow.RowFormat.Paddings.Left;
    }

    private float method_172()
    {
        float right = this.tableCell_0.CellFormat.Paddings.Right;
        if (this.tableCell_0.CellFormat.Paddings.Right != -0.05f)
        {
            return right;
        }
        if (!this.tableCell_0.OwnerRow.RowFormat.Paddings.HasKey(4) && this.tableCell_0.OwnerRow.RowFormat.Paddings.IsEmpty)
        {
            if (!this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.HasKey(4) && this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
            {
                return 5.4f;
            }
            return this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Right;
        }
        return this.tableCell_0.OwnerRow.RowFormat.Paddings.Right;
    }

    private float method_173()
    {
        float top = this.tableCell_0.CellFormat.Paddings.Top;
        if ((this.tableCell_0.CellFormat.Paddings.Top == -0.05f) || ((this.tableCell_0.CellFormat.Paddings.Top == 0f) && !this.tableCell_0.CellFormat.Paddings.HasValue(2)))
        {
            if (!this.tableCell_0.OwnerRow.RowFormat.Paddings.HasKey(2) && this.tableCell_0.OwnerRow.RowFormat.Paddings.IsEmpty)
            {
                if (!this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.HasKey(2) && this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
                {
                    top = 0f;
                }
                else
                {
                    top = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Top;
                }
            }
            else
            {
                top = this.tableCell_0.OwnerRow.RowFormat.Paddings.Top;
            }
        }
        for (int i = 0; i < this.tableCell_0.OwnerRow.Cells.Count; i++)
        {
            if (this.method_132() != i)
            {
                this.method_174(ref top, i);
            }
        }
        return top;
    }

    private void method_174(ref float A_0, int A_1)
    {
        TableCell cell = this.tableCell_0.OwnerRow.Cells[A_1];
        float top = cell.CellFormat.Paddings.Top;
        if ((cell.CellFormat.Paddings.Top == -0.05f) || ((cell.CellFormat.Paddings.Top == 0f) && !cell.CellFormat.Paddings.HasValue(2)))
        {
            if (!cell.OwnerRow.RowFormat.Paddings.HasKey(2) && cell.OwnerRow.RowFormat.Paddings.IsEmpty)
            {
                if (!cell.OwnerRow.OwnerTable.TableFormat.Paddings.HasKey(2) && cell.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
                {
                    top = 0f;
                }
                else
                {
                    top = cell.OwnerRow.OwnerTable.TableFormat.Paddings.Top;
                }
            }
            else
            {
                top = cell.OwnerRow.RowFormat.Paddings.Top;
            }
        }
        if (top > A_0)
        {
            A_0 = top;
        }
    }

    private float method_175()
    {
        float bottom = this.tableCell_0.CellFormat.Paddings.Bottom;
        if ((this.tableCell_0.CellFormat.Paddings.Bottom == -0.05f) || ((this.tableCell_0.CellFormat.Paddings.Bottom == 0f) && !this.tableCell_0.CellFormat.Paddings.HasValue(3)))
        {
            if (!this.tableCell_0.OwnerRow.RowFormat.Paddings.HasKey(3) && this.tableCell_0.OwnerRow.RowFormat.Paddings.IsEmpty)
            {
                if (!this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.HasKey(3) && this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
                {
                    bottom = 0f;
                }
                else
                {
                    bottom = this.tableCell_0.OwnerRow.OwnerTable.TableFormat.Paddings.Bottom;
                }
            }
            else
            {
                bottom = this.tableCell_0.OwnerRow.RowFormat.Paddings.Bottom;
            }
        }
        for (int i = 0; i < this.tableCell_0.OwnerRow.Cells.Count; i++)
        {
            if (this.method_132() != i)
            {
                this.method_176(ref bottom, i);
            }
        }
        return bottom;
    }

    private void method_176(ref float A_0, int A_1)
    {
        TableCell cell = this.tableCell_0.OwnerRow.Cells[A_1];
        float bottom = cell.CellFormat.Paddings.Bottom;
        if ((cell.CellFormat.Paddings.Bottom == -0.05f) || ((cell.CellFormat.Paddings.Bottom == 0f) && !cell.CellFormat.Paddings.HasValue(3)))
        {
            if (!cell.OwnerRow.RowFormat.Paddings.HasKey(3) && cell.OwnerRow.RowFormat.Paddings.IsEmpty)
            {
                if (!cell.OwnerRow.OwnerTable.TableFormat.Paddings.HasKey(3) && cell.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
                {
                    bottom = 0f;
                }
                else
                {
                    bottom = cell.OwnerRow.OwnerTable.TableFormat.Paddings.Bottom;
                }
            }
            else
            {
                bottom = cell.OwnerRow.RowFormat.Paddings.Bottom;
            }
        }
        if (bottom > A_0)
        {
            A_0 = bottom;
        }
    }
}

