using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class90
{
    private Class90()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1)
    {
        smethod_1(A_0, A_1, null);
    }

    internal static void smethod_1(Class857 A_0, DocumentObject A_1, Class106 A_2)
    {
        int num = 14;
        A_0.method_17(null);
        smethod_5(A_0);
        A_0.method_11().method_8().MoveToElement();
        Class108 class2 = Class574.smethod_10(A_0);
        if (!Class576.smethod_1(A_0.method_11()))
        {
            A_1 = Class574.smethod_4(A_0, class2, A_1);
        }
        Class106 class3 = (Class106) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("䀳圵娷嘹夻", num), A_0.method_20(), true);
        if (class3 == null)
        {
            class3 = A_2;
        }
        if (class3 == null)
        {
            class3 = new Class106();
        }
        Class975 class4 = new Class975();
        smethod_6(A_0, class3, class4);
        class4.method_4();
        Table table = smethod_3(A_0, class3, class4);
        if (A_1.LastChild is Table)
        {
            A_1.method_13(smethod_2(A_0.method_9()));
        }
        A_1.method_13(table);
    }

    private static Paragraph smethod_2(Document A_0)
    {
        return new Paragraph(A_0) { BreakCharacterFormat = { Hidden = true } };
    }

    private static Table smethod_3(Class857 A_0, Class106 A_1, Class975 A_2)
    {
        int num = 0;
        Table table = new Table(A_0.method_9());
        int num2 = smethod_4(A_0, A_1, A_2);
        foreach (Class571 class4 in A_2)
        {
            TableCell cell = new TableCell(A_0.method_9());
            TableRow lastRow = null;
            if (table.FirstRow != null)
            {
                lastRow = table.LastRow;
                cell = (TableCell) Class681.smethod_15(lastRow.FirstChild);
            }
            table.method_13(new TableRow(A_0.method_9(), class4.method_2()));
            for (int i = 0; i < class4.Count; i++)
            {
                Class1140 class3 = class4.method_0(i);
                if (class3.method_8() == null)
                {
                    class3.method_9((TableCell) cell.Clone());
                    if ((class3.method_4() == CellMerge.Continue) && (i != 0))
                    {
                        class3.method_8().CellFormat.PreferredWidth.method_50(0f);
                        class3.method_8().CellFormat.PreferredWidth.method_52(FtsWidth.Point);
                    }
                    if (((class3.method_6() == CellMerge.Continue) && (lastRow != null)) && (lastRow.Cells[i] != null))
                    {
                        class3.method_8().CellFormat.PreferredWidth.method_50(((float) A_1.method_20().method_1(i).method_12()) / 20f);
                        class3.method_8().CellFormat.PreferredWidth.method_52(FtsWidth.Point);
                    }
                }
                else if (class3.method_4() != CellMerge.Continue)
                {
                    int num6 = 0;
                    for (int k = 0; k < class3.method_0(); k++)
                    {
                        if ((A_1 != null) && ((i + k) < A_1.method_20().Count))
                        {
                            Class94 class2 = A_1.method_20().method_1(i + k);
                            if (class2 != null)
                            {
                                num6 += (class2.method_12() == -2147483648) ? num2 : class2.method_12();
                            }
                        }
                    }
                    class3.method_8().CellFormat.PreferredWidth.method_50(((float) num6) / 20f);
                    class3.method_8().CellFormat.PreferredWidth.method_52(FtsWidth.Point);
                }
                class3.method_8().CellFormat.HorizontalMerge = class3.method_4();
                class3.method_8().CellFormat.VerticalMerge = class3.method_6();
                table.LastRow.Cells.Add(class3.method_8());
                cell = class3.method_8();
            }
            if ((class4.method_0(0).method_6() == CellMerge.Continue) && (lastRow != null))
            {
                table.LastRow.RowFormat.LeftIndent = lastRow.RowFormat.LeftIndent;
            }
            for (int j = 1; j < class4.method_4(); j++)
            {
                table.method_13(table.LastRow);
            }
        }
        if (A_1 != null)
        {
            string str = A_1.method_12();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("吥䐧ܩ堫䰭", num)))
                {
                    if (str == BookmarkStart.b("䨥娧ܩ堫䰭", num))
                    {
                        table.TableFormat.Bidi = false;
                    }
                }
                else
                {
                    table.TableFormat.Bidi = true;
                }
            }
            table.DocxTableFormat.Format.HorizontalAlignment = (RowAlignment) A_1.method_14();
        }
        if ((A_1 != null) && (A_1.method_16() != -2147483648))
        {
            table.PreferredWidth = new PreferredWidth(WidthType.Twip, (short) A_1.method_16());
        }
        return table;
    }

    private static int smethod_4(Class857 A_0, Class106 A_1, Class975 A_2)
    {
        int num = 0;
        Class108 class2 = Class574.smethod_11(A_0, A_0.method_14(), A_0.method_26());
        if (class2 != null)
        {
            int num2 = Class969.smethod_31((double) class2.method_8().PageSetup.ClientWidth);
            int num3 = 0;
            int num4 = 0;
            if (A_1 == null)
            {
                return num;
            }
            int num5 = (A_1.method_16() == -2147483648) ? num2 : A_1.method_16();
            foreach (Class94 class3 in A_1.method_20())
            {
                if (class3.method_12() == -2147483648)
                {
                    num3++;
                }
                else
                {
                    num4 += class3.method_12();
                }
            }
            if (A_2.method_5() > A_1.method_20().Count)
            {
                num3 += A_2.method_5() - A_1.method_20().Count;
            }
            if (num3 > 0)
            {
                num = (num5 - num4) / num3;
            }
        }
        return num;
    }

    private static void smethod_5(Class857 A_0)
    {
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            A_0.method_4(class2);
        }
    }

    private static void smethod_6(Class857 A_0, Class106 A_1, Class975 A_2)
    {
        int num = 11;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䔰刲圴嬶尸", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䔰刲圴嬶尸ᘺ帼倾ⵀ㙂⡄⥆", num))
                {
                    if (str != BookmarkStart.b("䔰刲圴嬶尸ᘺ帼倾ⵀ㙂⡄⥆㩈", num))
                    {
                        if (str != BookmarkStart.b("䔰刲圴嬶尸ᘺ似倾㙀", num))
                        {
                            if (!(str == BookmarkStart.b("䔰刲圴嬶尸ᘺ似倾㙀あ", num)))
                            {
                                if (!(str == BookmarkStart.b("䔰刲圴嬶尸ᘺ唼娾⁀❂⁄㕆摈㥊≌㡎≐", num)))
                                {
                                    goto Label_00AE;
                                }
                                smethod_9(A_0, A_1, A_2);
                            }
                            else
                            {
                                smethod_8(A_0, A_2, A_1);
                            }
                        }
                        else
                        {
                            Class570.smethod_1(A_0, A_2, A_1);
                        }
                    }
                    else
                    {
                        smethod_7(A_0, A_1);
                    }
                }
                else
                {
                    Class1049.smethod_0(A_0, A_1);
                }
                continue;
            }
        Label_00AE:
            class2.vmethod_1();
        }
    }

    private static void smethod_7(Class857 A_0, Class106 A_1)
    {
        int num = 12;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䘱唳吵吷弹ᄻ崽⼿⹁ㅃ⭅♇㥉", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䘱唳吵吷弹ᄻ崽⼿⹁ㅃ⭅♇", num)))
            {
                Class1049.smethod_0(A_0, A_1);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_8(Class857 A_0, Class975 A_1, Class106 A_2)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("匦䠨䤪䄬䨮ᰰ䄲娴䀶䨸", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("匦䠨䤪䄬䨮ᰰ䄲娴䀶", num)))
            {
                Class570.smethod_1(A_0, A_1, A_2);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_9(Class857 A_0, Class106 A_1, Class975 A_2)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("匦䠨䤪䄬䨮ᰰ嬲倴嘶崸帺似ሾ㍀ⱂ㉄㑆", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("匦䠨䤪䄬䨮ᰰ䄲娴䀶", num)))
            {
                Class570.smethod_0(A_0, A_2, A_1, true);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }
}

