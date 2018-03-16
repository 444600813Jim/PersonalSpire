using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class925
{
    private readonly bool bool_0;
    private readonly CellFormat cellFormat_0;
    private int int_0 = 1;
    private int int_1 = 1;
    private readonly TableCell tableCell_0;

    private Class925(bool A_0, CellFormat A_1, TableCell A_2)
    {
        this.bool_0 = A_0;
        this.cellFormat_0 = A_1;
        this.tableCell_0 = A_2;
    }

    internal CellFormat method_0()
    {
        return this.cellFormat_0;
    }

    internal TableCell method_1()
    {
        return this.tableCell_0;
    }

    internal bool method_2()
    {
        return this.bool_0;
    }

    internal int method_3()
    {
        return this.int_0;
    }

    internal void method_4(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_5()
    {
        return this.int_1;
    }

    internal void method_6(int A_0)
    {
        this.int_1 = A_0;
    }

    internal static Class925 smethod_0(CellFormat A_0, TableCell A_1)
    {
        return new Class925(false, (CellFormat) A_0.Clone(), A_1);
    }

    internal static Class925 smethod_1(CellFormat A_0, TableCell A_1)
    {
        Class925 class2 = smethod_0(A_0, A_1);
        CellFormat format = class2.cellFormat_0;
        format.HorizontalMerge = CellMerge.Continue;
        format.SetAttr(0xc26, A_0.Borders.Top);
        format.SetAttr(0xc30, A_0.Borders.Left);
        format.SetAttr(0xc3a, A_0.Borders.Bottom);
        format.SetAttr(0xc44, A_0.Borders.Right);
        format.SetAttr(0xc4e, A_0.Borders.DiagonalDown);
        format.SetAttr(0xc58, A_0.Borders.DiagonalUp);
        format.SetAttr(0xc26, A_0.Borders.Top);
        return class2;
    }

    internal static Class925 smethod_2()
    {
        return new Class925(true, new CellFormat(), null);
    }
}

