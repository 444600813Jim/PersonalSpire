using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Drawing;

internal class Class981
{
    private readonly bool bool_0;
    private readonly bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private readonly bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private Border border_0;
    private readonly Class656 class656_0 = new Class656();
    private readonly Class982 class982_0 = new Class982();
    private int int_0;
    private int int_1;
    private readonly Table table_0;

    internal Class981(Table A_0, bool A_1, bool A_2, bool A_3)
    {
        this.table_0 = A_0;
        this.bool_0 = A_1;
        this.bool_1 = A_2;
        this.bool_2 = A_3;
        this.method_13();
        this.method_14();
        this.method_18();
        this.method_19();
        if (this.bool_10)
        {
            this.method_20();
        }
    }

    internal void method_0()
    {
        this.int_0 = 0;
    }

    internal void method_1()
    {
        this.int_0++;
    }

    internal int method_10()
    {
        return this.method_5(0, this.method_9());
    }

    internal Class477 method_11()
    {
        if (this.int_0 >= this.class982_0.Count)
        {
            return null;
        }
        return this.class982_0.method_0(this.int_0);
    }

    internal Class925 method_12()
    {
        if ((this.method_11() != null) && (this.int_1 < this.method_9()))
        {
            return this.method_11().method_1()[this.int_1];
        }
        return null;
    }

    private void method_13()
    {
        float width = 0f;
        Section section = this.table_0.method_55();
        for (TableRow row = this.table_0.FirstRow; row != null; row = (TableRow) row.NextSibling)
        {
            int num2 = smethod_2(row);
            this.class656_0.method_4(num2, null);
            foreach (TableCell cell5 in row.Cells)
            {
                CellFormat cellFormat = cell5.CellFormat;
                if (((cell5.CellWidthType == CellWidthType.Auto) && (cellFormat.HorizontalMerge != CellMerge.Continue)) && (cellFormat.VerticalMerge != CellMerge.Continue))
                {
                    if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell owner = this.table_0.Owner as TableCell;
                            if (owner.CellWidthType == CellWidthType.Percentage)
                            {
                                float num3 = owner.CellFormat.SamePaddingsAsTable ? owner.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : owner.CellFormat.Paddings.PaddingWidth;
                                width = ((owner.Scaling / 100f) * section.PageSetup.ClientWidth) - num3;
                            }
                            else if (owner.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = owner.Width;
                            }
                        }
                        else
                        {
                            width = (section.PageSetup.ClientWidth * this.table_0.PreferredTableWidth.method_49()) / 100f;
                        }
                    }
                    else if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Auto)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell cell = this.table_0.Owner as TableCell;
                            if (cell.CellWidthType == CellWidthType.Percentage)
                            {
                                float num4 = cell.CellFormat.SamePaddingsAsTable ? cell.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell.CellFormat.Paddings.PaddingWidth;
                                width = ((cell.Scaling / 100f) * section.PageSetup.ClientWidth) - num4;
                            }
                            else if (cell.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = cell.Width;
                            }
                        }
                        else
                        {
                            width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                        }
                    }
                    else
                    {
                        width = this.table_0.PreferredTableWidth.method_49();
                    }
                    num2 += (int) ((width / ((float) row.Cells.Count)) * 20f);
                }
                else if (cell5.CellWidthType == CellWidthType.Percentage)
                {
                    if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell cell2 = this.table_0.Owner as TableCell;
                            if (cell2.CellWidthType == CellWidthType.Percentage)
                            {
                                float num6 = cell2.CellFormat.SamePaddingsAsTable ? cell2.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell2.CellFormat.Paddings.PaddingWidth;
                                width = ((cell2.Scaling / 100f) * section.PageSetup.ClientWidth) - num6;
                            }
                            else if (cell2.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = cell2.Width;
                            }
                        }
                        else
                        {
                            width = (section.PageSetup.ClientWidth * this.table_0.PreferredTableWidth.method_49()) / 100f;
                        }
                    }
                    else if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Auto)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell cell4 = this.table_0.Owner as TableCell;
                            if (cell4.CellWidthType == CellWidthType.Percentage)
                            {
                                float num5 = cell4.CellFormat.SamePaddingsAsTable ? cell4.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell4.CellFormat.Paddings.PaddingWidth;
                                width = ((cell4.Scaling / 100f) * section.PageSetup.ClientWidth) - num5;
                            }
                            else if (cell4.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = cell4.Width;
                            }
                        }
                        else
                        {
                            width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                        }
                    }
                    else
                    {
                        width = this.table_0.PreferredTableWidth.method_49();
                    }
                    num2 += (int) (((cell5.Scaling * width) / 100f) * 20f);
                }
                else
                {
                    num2 += (int) (cellFormat.CellWidthEx * 20f);
                }
                this.class656_0.method_4(num2, null);
            }
        }
    }

    private void method_14()
    {
        RowCollection rows = this.table_0.Rows;
        int count = rows.Count;
        for (int i = 0; i < count; i++)
        {
            Class477 class2 = new Class477(this.method_9(), rows[i]);
            this.class982_0.Add(class2);
            this.method_17(class2);
            CellCollection cells = class2.method_0().Cells;
            int num9 = cells.Count;
            for (int j = 0; j < num9; j++)
            {
                int num4 = 0;
                float width = 0f;
                Section section = this.table_0.method_55();
                TableCell cell4 = cells[j];
                CellFormat cellFormat = cell4.CellFormat;
                if (((cell4.CellWidthType == CellWidthType.Auto) && (cellFormat.HorizontalMerge != CellMerge.Continue)) && (cellFormat.VerticalMerge != CellMerge.Continue))
                {
                    if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell owner = this.table_0.Owner as TableCell;
                            if (owner.CellWidthType == CellWidthType.Percentage)
                            {
                                float num15 = owner.CellFormat.SamePaddingsAsTable ? owner.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : owner.CellFormat.Paddings.PaddingWidth;
                                width = ((owner.Scaling / 100f) * section.PageSetup.ClientWidth) - num15;
                            }
                            else if (owner.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = owner.Width;
                            }
                        }
                        else
                        {
                            width = (section.PageSetup.ClientWidth * this.table_0.PreferredTableWidth.method_49()) / 100f;
                        }
                    }
                    else if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Auto)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell cell2 = this.table_0.Owner as TableCell;
                            if (cell2.CellWidthType == CellWidthType.Percentage)
                            {
                                float num11 = cell2.CellFormat.SamePaddingsAsTable ? cell2.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell2.CellFormat.Paddings.PaddingWidth;
                                width = ((cell2.Scaling / 100f) * section.PageSetup.ClientWidth) - num11;
                            }
                            else if (cell2.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = cell2.Width;
                            }
                        }
                        else
                        {
                            width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                        }
                    }
                    else
                    {
                        width = this.table_0.PreferredTableWidth.method_49();
                    }
                    num4 = (int) ((width / ((float) num9)) * 20f);
                }
                else if (cell4.CellWidthType == CellWidthType.Percentage)
                {
                    if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell cell7 = this.table_0.Owner as TableCell;
                            if (cell7.CellWidthType == CellWidthType.Percentage)
                            {
                                float num17 = cell7.CellFormat.SamePaddingsAsTable ? cell7.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell7.CellFormat.Paddings.PaddingWidth;
                                width = ((cell7.Scaling / 100f) * section.PageSetup.ClientWidth) - num17;
                            }
                            else if (cell7.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = cell7.Width;
                            }
                        }
                        else
                        {
                            width = (section.PageSetup.ClientWidth * this.table_0.PreferredTableWidth.method_49()) / 100f;
                        }
                    }
                    else if (this.table_0.PreferredTableWidth.method_51() == FtsWidth.Auto)
                    {
                        if (this.table_0.IsInCell)
                        {
                            TableCell cell = this.table_0.Owner as TableCell;
                            if (cell.CellWidthType == CellWidthType.Percentage)
                            {
                                float num16 = cell.CellFormat.SamePaddingsAsTable ? cell.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell.CellFormat.Paddings.PaddingWidth;
                                width = ((cell.Scaling / 100f) * section.PageSetup.ClientWidth) - num16;
                            }
                            else if (cell.CellWidthType == CellWidthType.Auto)
                            {
                                width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                            }
                            else
                            {
                                width = cell.Width;
                            }
                        }
                        else
                        {
                            width = section.PageSetup.ClientWidth - this.table_0.TableFormat.Paddings.PaddingWidth;
                        }
                    }
                    else
                    {
                        width = this.table_0.PreferredTableWidth.method_49();
                    }
                    num4 = (int) (((cell4.Scaling * width) / 100f) * 20f);
                }
                else
                {
                    num4 = (int) (cellFormat.CellWidthEx * 20f);
                }
                if (((cellFormat.HorizontalMerge != CellMerge.Continue) && (cellFormat.VerticalMerge != CellMerge.Continue)) || (num4 != 0))
                {
                    Class925 class3 = Class925.smethod_0(cellFormat, cell4);
                    int num12 = smethod_3(class2.method_0(), j);
                    int index = this.class656_0.method_14(num12);
                    int num13 = num12 + num4;
                    int num6 = this.class656_0.method_14(num13);
                    class2.method_1()[index] = class3;
                    TableCell cell6 = cell4;
                    TableCell cell5 = cell4;
                    if (cellFormat.HorizontalMerge == CellMerge.Start)
                    {
                        for (int m = j + 1; m < num9; m++)
                        {
                            TableCell cell8 = cells[m];
                            if (cell8.CellFormat.HorizontalMerge != CellMerge.Continue)
                            {
                                break;
                            }
                            cell6 = cell8;
                        }
                    }
                    if (cellFormat.VerticalMerge == CellMerge.Start)
                    {
                        for (int n = i + 1; n < count; n++)
                        {
                            TableCell cell9 = smethod_4(rows[n], num12);
                            if ((cell9 == null) || (cell9.CellFormat.VerticalMerge != CellMerge.Continue))
                            {
                                break;
                            }
                            cell5 = cell9;
                        }
                    }
                    CellFormat format2 = class3.method_0();
                    this.method_15(format2, cell4, 0xc26);
                    this.method_15(format2, cell4, 0xc30);
                    this.method_15(format2, cell5, 0xc3a);
                    this.method_15(format2, cell6, 0xc44);
                    this.method_15(format2, cell4, 0xc4e);
                    this.method_15(format2, cell4, 0xc58);
                    this.method_16(format2, cell4, 0xbfe);
                    this.method_16(format2, cell4, 0xc12);
                    this.method_16(format2, cell4, 0xc08);
                    this.method_16(format2, cell4, 0xc1c);
                    for (int k = index + 1; k < num6; k++)
                    {
                        class2.method_1()[k] = Class925.smethod_1(format2, cell4);
                    }
                    if ((num6 - index) > 1)
                    {
                        this.bool_9 = true;
                    }
                }
            }
        }
    }

    private void method_15(CellFormat A_0, TableCell A_1, int A_2)
    {
        smethod_0(this.bool_0, A_0, A_1, A_2);
    }

    private void method_16(CellFormat A_0, TableCell A_1, int A_2)
    {
        smethod_0(this.bool_2, A_0, A_1, A_2);
    }

    private void method_17(Class477 A_0)
    {
        int num = smethod_2(A_0.method_0());
        int num2 = this.class656_0.method_14(num);
        for (int i = 0; i < num2; i++)
        {
            A_0.method_1()[i] = Class925.smethod_2();
        }
        int num6 = smethod_3(A_0.method_0(), A_0.method_0().Cells.Count);
        int num4 = this.class656_0.method_14(num6);
        for (int j = num4; j < this.method_9(); j++)
        {
            A_0.method_1()[j] = Class925.smethod_2();
        }
        if ((num2 > 0) || (num4 < this.method_9()))
        {
            this.bool_9 = true;
            this.bool_10 = true;
        }
    }

    private void method_18()
    {
        for (int i = 0; i < this.class982_0.Count; i++)
        {
            int num3 = 1;
            for (int j = this.method_9() - 1; j >= 0; j--)
            {
                Class925 class2 = this.class982_0.method_0(i).method_1()[j];
                switch (class2.method_0().HorizontalMerge)
                {
                    case CellMerge.None:
                    case CellMerge.Start:
                        class2.method_0().TwipCellWidth = this.method_5(j, num3);
                        class2.method_4(num3);
                        num3 = 1;
                        break;

                    case CellMerge.Continue:
                        num3++;
                        break;
                }
            }
        }
    }

    private void method_19()
    {
        for (int i = 0; i < this.method_9(); i++)
        {
            int num3 = 1;
            for (int j = this.class982_0.Count - 1; j >= 0; j--)
            {
                Class925 class2 = this.class982_0.method_0(j).method_1()[i];
                switch (class2.method_0().VerticalMerge)
                {
                    case CellMerge.None:
                    case CellMerge.Start:
                        class2.method_6(num3);
                        num3 = 1;
                        break;

                    case CellMerge.Continue:
                        num3++;
                        break;
                }
            }
        }
    }

    internal void method_2()
    {
        this.int_1 = -1;
        this.method_3();
    }

    private void method_20()
    {
        if (this.bool_1)
        {
            RowFormat rowFormat = this.table_0.FirstRow.RowFormat;
            this.bool_3 = rowFormat.HasKey(0xfdc);
            this.bool_4 = rowFormat.HasKey(0xff0);
            this.bool_5 = rowFormat.HasKey(0xfd2);
            this.bool_6 = rowFormat.HasKey(0xfe6);
            this.bool_7 = rowFormat.HasKey(0xffa);
            this.bool_8 = rowFormat.HasKey(0x1004);
            Border border = new Border {
                BorderType = BorderStyle.None,
                LineWidth = 0f,
                Color = Color.Empty
            };
            bool flag = (((this.bool_3 || this.bool_4) || (this.bool_5 || this.bool_6)) || this.bool_7) || this.bool_8;
            this.border_0 = flag ? border : null;
        }
        for (int i = 0; i < this.class982_0.Count; i++)
        {
            Class477 class2 = this.class982_0.method_0(i);
            for (int j = 0; this.method_21(class2.method_1()[j], i, j); j++)
            {
            }
            for (int k = this.method_9() - 1; this.method_21(class2.method_1()[k], i, k); k--)
            {
            }
        }
    }

    private bool method_21(Class925 A_0, int A_1, int A_2)
    {
        bool flag;
        if (flag = A_0.method_2())
        {
            CellFormat format = A_0.method_0();
            bool flag2 = A_1 == 0;
            bool flag3 = A_1 == (this.class982_0.Count - 1);
            bool flag4 = !flag2 && smethod_1(format, 0xc26, this.class982_0.method_0(A_1 - 1).method_1()[A_2].method_0(), 0xc3a);
            bool flag7 = !flag3 && smethod_1(format, 0xc3a, this.class982_0.method_0(A_1 + 1).method_1()[A_2].method_0(), 0xc26);
            if (this.border_0 == null)
            {
                return flag;
            }
            if ((flag2 && this.bool_5) || ((!flag2 && this.bool_7) && !flag4))
            {
                format.SetAttr(0xc26, this.border_0);
            }
            if ((flag3 && this.bool_6) || ((!flag3 && this.bool_7) && !flag7))
            {
                format.SetAttr(0xc3a, this.border_0);
            }
            bool flag6 = A_2 == 0;
            bool flag5 = A_2 == (this.method_9() - 1);
            bool flag8 = !flag6 && smethod_1(format, 0xc30, this.class982_0.method_0(A_1).method_1()[A_2 - 1].method_0(), 0xc44);
            bool flag9 = !flag5 && smethod_1(format, 0xc44, this.class982_0.method_0(A_1).method_1()[A_2 + 1].method_0(), 0xc30);
            if ((flag6 && this.bool_3) || ((!flag6 && this.bool_8) && !flag8))
            {
                format.SetAttr(0xc30, this.border_0);
            }
            if ((flag5 && this.bool_4) || ((!flag5 && this.bool_8) && !flag9))
            {
                format.SetAttr(0xc44, this.border_0);
            }
        }
        return flag;
    }

    internal bool method_22()
    {
        return this.bool_9;
    }

    internal bool method_23()
    {
        return this.bool_11;
    }

    internal void method_24(bool A_0)
    {
        this.bool_11 = A_0;
    }

    internal void method_3()
    {
        do
        {
            this.int_1++;
        }
        while ((this.method_12() != null) && ((this.method_12().method_0().HorizontalMerge == CellMerge.Continue) || (this.method_12().method_0().VerticalMerge == CellMerge.Continue)));
    }

    internal int method_4(int A_0)
    {
        return this.method_5(A_0, 1);
    }

    private int method_5(int A_0, int A_1)
    {
        return (this.method_7(A_0 + A_1) - this.method_7(A_0));
    }

    internal int[] method_6()
    {
        int[] numArray = new int[this.class656_0.method_2() - 1];
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = this.method_4(i);
        }
        return numArray;
    }

    internal int method_7(int A_0)
    {
        return this.class656_0.method_13(A_0);
    }

    internal Table method_8()
    {
        return this.table_0;
    }

    internal int method_9()
    {
        return (this.class656_0.method_2() - 1);
    }

    private static void smethod_0(bool A_0, CellFormat A_1, TableCell A_2, int A_3)
    {
        object obj2 = A_0 ? A_2.CellFormat.method_32(A_3) : A_2.CellFormat.method_31(A_3);
        if (obj2 != null)
        {
            A_1.SetAttr(A_3, obj2);
        }
    }

    private static bool smethod_1(CellFormat A_0, int A_1, CellFormat A_2, int A_3)
    {
        bool flag;
        object obj2 = A_2.method_31(A_3);
        if (flag = obj2 != null)
        {
            A_0.SetAttr(A_1, obj2);
        }
        return flag;
    }

    private static int smethod_2(TableRow A_0)
    {
        RowFormat rowFormat = A_0.RowFormat;
        return (((int) (A_0.ParentTable.IndentFromLeft - (A_0.ParentTable.TableFormat.Paddings.Left * 20f))) + rowFormat.GridBefore);
    }

    private static int smethod_3(TableRow A_0, int A_1)
    {
        int num = smethod_2(A_0);
        float width = 0f;
        Section section = A_0.OwnerTable.method_55();
        CellCollection cells = A_0.Cells;
        for (int i = 0; i < A_1; i++)
        {
            if (((cells[i].CellWidthType == CellWidthType.Auto) && (cells[i].CellFormat.HorizontalMerge != CellMerge.Continue)) && (cells[i].CellFormat.VerticalMerge != CellMerge.Continue))
            {
                if (A_0.OwnerTable.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                {
                    if (A_0.OwnerTable.IsInCell)
                    {
                        TableCell owner = A_0.OwnerTable.Owner as TableCell;
                        if (owner.CellWidthType == CellWidthType.Percentage)
                        {
                            float num6 = owner.CellFormat.SamePaddingsAsTable ? owner.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : owner.CellFormat.Paddings.PaddingWidth;
                            width = ((owner.Scaling / 100f) * section.PageSetup.ClientWidth) - num6;
                        }
                        else if (owner.CellWidthType == CellWidthType.Auto)
                        {
                            width = section.PageSetup.ClientWidth - A_0.OwnerTable.TableFormat.Paddings.PaddingWidth;
                        }
                        else
                        {
                            width = owner.Width;
                        }
                    }
                    else
                    {
                        width = (section.PageSetup.ClientWidth * A_0.OwnerTable.PreferredTableWidth.method_49()) / 100f;
                    }
                }
                else if (A_0.OwnerTable.PreferredTableWidth.method_51() == FtsWidth.Auto)
                {
                    if (A_0.OwnerTable.IsInCell)
                    {
                        TableCell cell = A_0.OwnerTable.Owner as TableCell;
                        if (cell.CellWidthType == CellWidthType.Percentage)
                        {
                            float num4 = cell.CellFormat.SamePaddingsAsTable ? cell.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell.CellFormat.Paddings.PaddingWidth;
                            width = ((cell.Scaling / 100f) * section.PageSetup.ClientWidth) - num4;
                        }
                        else if (cell.CellWidthType == CellWidthType.Auto)
                        {
                            width = section.PageSetup.ClientWidth - A_0.OwnerTable.TableFormat.Paddings.PaddingWidth;
                        }
                        else
                        {
                            width = cell.Width;
                        }
                    }
                    else
                    {
                        width = section.PageSetup.ClientWidth - A_0.OwnerTable.TableFormat.Paddings.PaddingWidth;
                    }
                }
                else
                {
                    width = A_0.OwnerTable.PreferredTableWidth.method_49();
                }
                num += (int) ((width / ((float) cells.Count)) * 20f);
            }
            else if (cells[i].CellWidthType == CellWidthType.Percentage)
            {
                if (A_0.OwnerTable.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                {
                    if (A_0.OwnerTable.IsInCell)
                    {
                        TableCell cell2 = A_0.OwnerTable.Owner as TableCell;
                        if (cell2.CellWidthType == CellWidthType.Percentage)
                        {
                            float num5 = cell2.CellFormat.SamePaddingsAsTable ? cell2.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell2.CellFormat.Paddings.PaddingWidth;
                            width = ((cell2.Scaling / 100f) * section.PageSetup.ClientWidth) - num5;
                        }
                        else if (cell2.CellWidthType == CellWidthType.Auto)
                        {
                            width = section.PageSetup.ClientWidth - A_0.OwnerTable.TableFormat.Paddings.PaddingWidth;
                        }
                        else
                        {
                            width = cell2.Width;
                        }
                    }
                    else
                    {
                        width = (section.PageSetup.ClientWidth * A_0.OwnerTable.PreferredTableWidth.method_49()) / 100f;
                    }
                }
                else if (A_0.OwnerTable.PreferredTableWidth.method_51() == FtsWidth.Auto)
                {
                    if (A_0.OwnerTable.IsInCell)
                    {
                        TableCell cell4 = A_0.OwnerTable.Owner as TableCell;
                        if (cell4.CellWidthType == CellWidthType.Percentage)
                        {
                            float num7 = cell4.CellFormat.SamePaddingsAsTable ? cell4.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : cell4.CellFormat.Paddings.PaddingWidth;
                            width = ((cell4.Scaling / 100f) * section.PageSetup.ClientWidth) - num7;
                        }
                        else if (cell4.CellWidthType == CellWidthType.Auto)
                        {
                            width = section.PageSetup.ClientWidth - A_0.OwnerTable.TableFormat.Paddings.PaddingWidth;
                        }
                        else
                        {
                            width = cell4.Width;
                        }
                    }
                    else
                    {
                        width = section.PageSetup.ClientWidth - A_0.OwnerTable.TableFormat.Paddings.PaddingWidth;
                    }
                }
                else
                {
                    width = A_0.OwnerTable.PreferredTableWidth.method_49();
                }
                num += (int) (((cells[i].Scaling * width) / 100f) * 20f);
            }
            else
            {
                num += (int) (cells[i].CellFormat.CellWidthEx * 20f);
            }
        }
        return num;
    }

    private static TableCell smethod_4(TableRow A_0, int A_1)
    {
        int num = smethod_2(A_0);
        if (num <= A_1)
        {
            TableCell cell2;
            using (IEnumerator enumerator = A_0.Cells.GetEnumerator())
            {
                TableCell current;
                while (enumerator.MoveNext())
                {
                    current = (TableCell) enumerator.Current;
                    if (num == A_1)
                    {
                        goto Label_0047;
                    }
                    num += (int) current.CellFormat.CellWidth;
                }
                goto Label_0063;
            Label_0047:
                cell2 = current;
            }
            return cell2;
        }
    Label_0063:
        return null;
    }
}

