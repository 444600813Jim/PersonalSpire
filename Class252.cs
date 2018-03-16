using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class252
{
    private readonly bool bool_0;
    private const int int_0 = 1;
    private int[] int_1;
    private int int_2;
    private int[] int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;

    internal Class252(Table A_0) : this(A_0, false)
    {
    }

    internal Class252(Table A_0, bool A_1)
    {
        this.bool_0 = A_1;
        this.method_2(A_0);
    }

    private RowFormat method_0(TableRow A_0)
    {
        RowFormat rowFormat = A_0.RowFormat;
        if (this.bool_0 && rowFormat.HasFormatRevision)
        {
            rowFormat = (RowFormat) rowFormat.FormatRevision.method_4();
        }
        return rowFormat;
    }

    private CellFormat method_1(TableCell A_0)
    {
        CellFormat cellFormat = A_0.CellFormat;
        if (this.bool_0 && cellFormat.HasFormatRevision)
        {
            cellFormat = (CellFormat) cellFormat.FormatRevision.method_4();
        }
        return cellFormat;
    }

    internal int method_10()
    {
        return this.int_5;
    }

    internal int method_11()
    {
        return this.int_6;
    }

    internal int method_12()
    {
        return this.int_7;
    }

    private void method_2(Table A_0)
    {
        Class656 class2 = new Class656();
        float num = A_0.method_71(A_0);
        int num2 = (int) (this.method_0(A_0.FirstRow).LeftIndent * 20f);
        for (TableRow row = A_0.FirstRow; row != null; row = row.NextSibling as TableRow)
        {
            CellCollection cells = row.Cells;
            int gridBefore = row.RowFormat.GridBefore;
            int num6 = (int) Math.Round((double) (num2 + this.method_0(row).GridBeforeWidth.method_49()));
            class2.method_4(num6, null);
            foreach (TableCell cell in cells)
            {
                int num5 = gridBefore + cell.GridSpanEx;
                CellFormat format = this.method_1(cell);
                format.TwipCellWidth = (format.TwipCellWidth != 0) ? format.TwipCellWidth : this.method_4(cell, num, A_0._ColumnWidths, ref gridBefore, num5);
                num6 += this.method_1(cell).TwipCellWidth;
                class2.method_4(num6, null);
            }
        }
        this.int_1 = new int[Math.Max(class2.method_2() - 1, 0)];
        for (int i = 0; i < this.int_1.Length; i++)
        {
            this.int_1[i] = class2.method_13(i + 1) - class2.method_13(i);
        }
    }

    private void method_3(Class656 A_0)
    {
        for (int i = A_0.method_2() - 1; i > 0; i--)
        {
            if (Math.Abs((int) (A_0.method_13(i) - A_0.method_13(i - 1))) < 5)
            {
                A_0.method_17(i);
            }
        }
    }

    internal int method_4(TableCell A_0, float A_1, ArrayList A_2, ref int A_3, int A_4)
    {
        if (A_0 == null)
        {
            return 0;
        }
        int num = 0;
        if (A_0.WidthType == FtsWidth.Percentage)
        {
            return (int) (A_0.CellFormat.CellWidth * 20f);
        }
        if (A_2.Count <= 0)
        {
            return (int) Math.Round((double) (A_0.Width * 20f));
        }
        if ((((A_0.WidthType != FtsWidth.Auto) && (A_0.WidthType != FtsWidth.None)) || (A_0.Width != 0f)) && (A_0.GridSpanEx <= 1))
        {
            num = (int) Math.Round((double) (A_0.Width * 20f));
            A_3 += A_0.GridSpanEx;
            return num;
        }
        A_4 = Math.Min(A_4, A_2.Count);
        while (A_3 < A_4)
        {
            num += (int) A_2[A_3++];
        }
        return num;
    }

    internal void method_5(TableRow A_0)
    {
        int index = 0;
        this.int_8 = 0;
        this.int_5 = (int) this.method_0(A_0).GridBeforeWidth.method_49();
        int num2 = 0;
        while (num2 < this.int_5)
        {
            if (index >= this.int_1.Length)
            {
                break;
            }
            num2 += this.int_1[index];
            index++;
        }
        this.int_4 = index;
        CellCollection cells = A_0.Cells;
        this.int_3 = new int[cells.Count];
        for (int i = 0; i < cells.Count; i++)
        {
            int num4 = this.method_6(index, this.method_1(cells[i]).TwipCellWidth);
            this.int_3[i] = num4;
            index += num4;
        }
        this.int_7 = (int) Math.Round((double) this.method_0(A_0).GridAfterWidth.method_49());
        this.int_6 = this.int_1.Length - index;
        this.int_2++;
    }

    private int method_6(int A_0, int A_1)
    {
        int num = 0;
        while (A_1 > 1)
        {
            if (A_0 >= this.int_1.Length)
            {
                return num;
            }
            A_1 -= this.int_1[A_0];
            A_0++;
            num++;
        }
        return num;
    }

    internal int[] method_7()
    {
        return this.int_1;
    }

    internal int method_8()
    {
        return this.int_3[this.int_8++];
    }

    internal int method_9()
    {
        return this.int_4;
    }
}

