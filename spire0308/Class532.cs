using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class532
{
    private Class532()
    {
    }

    internal static void smethod_0(Class398 A_0, Table A_1)
    {
        int num = 1;
        RowFormat tableFormat = A_1.TableFormat;
        List<float> tableGrid = A_1.TableGrid;
        ArrayList list2 = tableFormat.HasFormatRevision ? smethod_11(tableFormat) : null;
        A_0.method_4(BookmarkStart.b("倦ጨ弪伬䌮瘰䄲尴匶", num));
        for (int i = 1; i < tableGrid.Count; i++)
        {
            int num4 = Class59.smethod_8(tableGrid[i] - tableGrid[i - 1], 0);
            A_0.method_33(BookmarkStart.b("倦ጨ䰪弬䘮唰瀲娴嬶", num), new object[] { BookmarkStart.b("倦ጨ尪", num), num4 });
        }
        if (list2 != null)
        {
            A_0.method_4(BookmarkStart.b("倦ጨ弪伬䌮瘰䄲尴匶稸区尼儾♀♂", num));
            A_0.method_4(BookmarkStart.b("倦ጨ弪伬䌮瘰䄲尴匶", num));
            foreach (int num2 in list2)
            {
                A_0.method_33(BookmarkStart.b("倦ጨ䰪弬䘮唰瀲娴嬶", num), new object[] { BookmarkStart.b("倦ጨ尪", num), num2 });
            }
            A_0.method_5();
            A_0.method_5();
        }
        A_0.method_5();
    }

    internal static void smethod_1(Class394 A_0, RowFormat A_1)
    {
        int num = 11;
        ArrayList list = new ArrayList();
        A_1.SetAttr(0x13ef, list);
        while (A_0.method_9(BookmarkStart.b("䔰儲头瀶䬸刺夼", num)))
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("嘰䄲尴匶稸吺儼", num)))
                {
                    if (!(str == BookmarkStart.b("䔰儲头瀶䬸刺夼簾⥀≂⭄⁆ⱈ", num)))
                    {
                        goto Label_0097;
                    }
                    smethod_10(A_0, A_1);
                }
                else
                {
                    int num2 = 0;
                    while (A_0.method_19())
                    {
                        string str2;
                        if (((str2 = A_0.method_1()) != null) && (str2 == BookmarkStart.b("䘰", num)))
                        {
                            num2 = A_0.method_61();
                        }
                    }
                    list.Add(num2);
                }
                continue;
            }
        Label_0097:
            A_0.vmethod_1();
        }
    }

    private static void smethod_10(Class394 A_0, RowFormat A_1)
    {
        int num = 14;
        while (A_0.method_9(BookmarkStart.b("䀳吵吷紹主圽␿Łⱃ❅♇ⵉ⥋", num)))
        {
            string str;
            if (((str = A_0.method_1()) != null) && (str == BookmarkStart.b("䀳吵吷紹主圽␿", num)))
            {
                ArrayList list = (ArrayList) A_1.method_31(0x13ef);
                if (A_1.FormatRevision == null)
                {
                    A_1.FormatRevision = new Class580(new RowFormat(), "", DateTime.MinValue);
                }
                A_1.FormatRevision.method_4().SetAttr(0x13ef, list);
                smethod_1(A_0, A_1);
            }
            else
            {
                A_0.vmethod_1();
            }
        }
    }

    private static ArrayList smethod_11(WordAttrCollection A_0)
    {
        return (ArrayList) A_0.method_31(0x13ef);
    }

    internal static void smethod_2(TableRow A_0)
    {
        smethod_3(A_0, false, false, 0);
    }

    internal static void smethod_3(TableRow A_0, bool A_1, bool A_2, int A_3)
    {
        Table parentTable = A_0.ParentTable;
        if (!parentTable.TableFormat.HasKey(0x13ef))
        {
            smethod_9(parentTable);
        }
        if (parentTable.TableFormat.HasFormatRevision)
        {
            smethod_5(A_0, false, A_1, A_2, A_3);
        }
        smethod_5(A_0, true, A_1, A_2, A_3);
    }

    private static void smethod_4(RowFormat A_0, Class252 A_1)
    {
        A_0.SetAttr(0x13f0, A_1.method_9());
        A_0.SetAttr(0x13f1, A_1.method_11());
        A_0.GridBeforeWidth.method_50((float) A_1.method_10());
        A_0.GridAfterWidth.method_50((float) A_1.method_12());
    }

    private static void smethod_5(TableRow A_0, bool A_1, bool A_2, bool A_3, int A_4)
    {
        RowFormat format = smethod_6(A_0.RowFormat, A_1);
        ArrayList list = (ArrayList) smethod_6(A_0.ParentTable.TableFormat, A_1).method_31(0x13ef);
        int num = (int) format.method_32(0x13f0);
        if (list.Count > 0)
        {
            int num2 = num;
            foreach (TableCell cell in A_0.Cells)
            {
                int num4 = 0;
                CellFormat cellFormat = cell.CellFormat;
                short num5 = (short) smethod_7(cellFormat, A_1).method_32(0xf3c);
                int num3 = Math.Min(num2 + num5, list.Count);
                while (num2 < num3)
                {
                    num4 += Convert.ToInt32(list[num2++]);
                }
                if (num4 != 0)
                {
                    if (A_1)
                    {
                        if (A_2)
                        {
                            if (A_3)
                            {
                                cellFormat.RevisedPr.CellWidth = (((float) num4) / ((float) A_4)) * 100f;
                                cellFormat.RevisedPr.WidthUnit = FtsWidth.Percentage;
                            }
                            else
                            {
                                cellFormat.RevisedPr.CellWidth = ((float) num4) / 20f;
                                cellFormat.RevisedPr.WidthUnit = FtsWidth.Point;
                            }
                        }
                        cellFormat.RevisedPr.TwipCellWidth = num4;
                    }
                    else if (cellFormat.HasFormatRevision)
                    {
                        if (A_2)
                        {
                            if (A_3)
                            {
                                cell.SetCellWidth((((float) num4) / ((float) A_4)) * 100f, CellWidthType.Percentage);
                            }
                            else
                            {
                                cell.SetCellWidth(((float) num4) / 20f, CellWidthType.Point);
                            }
                        }
                        cellFormat.TwipCellWidth = num4;
                    }
                }
            }
        }
    }

    private static RowFormat smethod_6(RowFormat A_0, bool A_1)
    {
        if (A_1)
        {
            RowFormat format = A_0.method_50();
            format.AcceptFormatRevision();
            return format;
        }
        return A_0;
    }

    private static CellFormat smethod_7(CellFormat A_0, bool A_1)
    {
        if (A_1)
        {
            CellFormat format = (CellFormat) A_0.Clone();
            format.AcceptFormatRevision();
            return format;
        }
        return A_0;
    }

    private static void smethod_8(ArrayList A_0, RowFormat A_1, TableRow A_2, bool A_3, bool A_4, int A_5)
    {
        int num = (int) A_1.method_32(0x13f0);
        int num2 = 0;
        for (int i = 0; i < num; i++)
        {
            num2 += (int) A_0[i];
        }
        RowFormat format = (!A_2.RowFormat.HasFormatRevision || !A_3) ? A_2.RowFormat : ((RowFormat) A_2.RowFormat.FormatRevision.method_4());
        Class15 class2 = (Class15) format.method_31(0x109a);
        if (A_4)
        {
            class2.method_50((((float) num2) / ((float) A_5)) * 50f);
            class2.method_52(FtsWidth.Percentage);
        }
        else
        {
            class2.method_50((float) num2);
            class2.method_52(FtsWidth.Point);
        }
    }

    private static void smethod_9(Table A_0)
    {
        ArrayList list = new ArrayList();
        A_0.TableFormat.SetAttr(0x13ef, list);
        foreach (TableCell cell in A_0.FirstRow.Cells)
        {
            float cellWidth = cell.CellFormat.CellWidth;
            if (cellWidth > 0f)
            {
                list.Add((int) Math.Round((double) (cellWidth * 20f), 2));
            }
        }
    }
}

