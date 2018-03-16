using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using Spire.Doc.Formatting;
using System;

internal class Class1080
{
    private Class1080()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        Document doc = A_0.Interface50.imethod_0();
        A_0.method_3(new Table(doc));
        RowFormat format = new RowFormat(doc);
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            smethod_1(A_0, format);
        }
        smethod_2(A_0, format);
    }

    internal static void smethod_1(Class581 A_0, RowFormat A_1)
    {
        int num = 10;
        Class394 class2 = A_0.imethod_1();
        class2.method_18();
        if (A_0.vmethod_1())
        {
            Class9 class3 = Class402.smethod_0(A_0, MarkupLevel.Row);
            A_0.method_3(class3);
            while (class2.method_9(class3.method_22()))
            {
                smethod_1(A_0, A_1);
            }
            A_0.method_5(DocumentObjectType.CustomXml);
        }
        else
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str == BookmarkStart.b("䐯倱堳昵䨷", num))
                {
                    Class829.smethod_0(A_1, A_0, false);
                    ((Table) A_0.method_13()).TableFormat.ImportContainer(A_1);
                    return;
                }
                if (str == BookmarkStart.b("䐯倱堳焵䨷匹堻", num))
                {
                    Class532.smethod_1(class2, ((Table) A_0.method_13()).TableFormat);
                    return;
                }
                if (str == BookmarkStart.b("䐯䀱", num))
                {
                    Class912.smethod_0(A_0, A_1);
                    return;
                }
                if (str == BookmarkStart.b("儯就娳夵䰷嬹䠻圽⼿ⱁ", num))
                {
                    TableRow lastRow = A_0.Interface50.imethod_0().LastSection.Tables[A_0.Interface50.imethod_0().LastSection.Tables.Count - 1].LastRow;
                    TableCell cell = lastRow.Cells[lastRow.Cells.Count - 1];
                    Paragraph paragraph = cell.Items[cell.Items.Count - 1] as Paragraph;
                    if (paragraph == null)
                    {
                        paragraph = cell.AddParagraph();
                    }
                    Class519.smethod_1(A_0, paragraph);
                    return;
                }
            }
            smethod_3(A_0, A_1);
        }
    }

    private static void smethod_2(Class581 A_0, RowFormat A_1)
    {
        Table table = (Table) A_0.method_13();
        table.PreferredTableWidth = A_1.TablePreferredWidthInfo;
        A_0.method_5(DocumentObjectType.Table);
    }

    private static void smethod_3(Class581 A_0, RowFormat A_1)
    {
        int num = 7;
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("夬䴮崰", num))
            {
                smethod_2(A_0, A_1);
                smethod_0(A_0);
                A_0.method_3(new Table(A_0.Interface50.imethod_0()));
                return;
            }
            if (str == BookmarkStart.b("崬", num))
            {
                smethod_2(A_0, A_1);
                Class629.smethod_2(A_0);
                A_0.method_3(new Table(A_0.Interface50.imethod_0()));
                return;
            }
            if (str == BookmarkStart.b("帬䨮到䜲攴䔶", num))
            {
                class2.method_26();
                return;
            }
        }
        string str2 = class2.method_1();
        while (class2.method_9(str2))
        {
            smethod_1(A_0, A_1);
        }
    }
}

