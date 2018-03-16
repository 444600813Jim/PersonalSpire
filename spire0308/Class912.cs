using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using Spire.Doc.Formatting;
using System;

internal class Class912
{
    private Class912()
    {
    }

    internal static void smethod_0(Class581 A_0, RowFormat A_1)
    {
        RowFormat format = (RowFormat) A_1.method_23();
        TableRow row = new TableRow(A_0.Interface50.imethod_0(), format);
        A_0.method_3(row);
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            smethod_1(A_0, format);
        }
        A_0.method_5(DocumentObjectType.TableRow);
        Class532.smethod_2(row);
    }

    private static void smethod_1(Class581 A_0, RowFormat A_1)
    {
        int num = 8;
        Class394 class2 = A_0.imethod_1();
        if (A_0.vmethod_1())
        {
            Class9 class3 = Class402.smethod_0(A_0, MarkupLevel.Cell);
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
                if (str == BookmarkStart.b("娭刯帱搳䐵紷䈹", num))
                {
                    Class829.smethod_2(A_1, A_0);
                    return;
                }
                if (str == BookmarkStart.b("娭䈯戱䘳", num))
                {
                    Class1131.smethod_0(A_1, A_0);
                    return;
                }
                if (str == BookmarkStart.b("娭匯", num))
                {
                    Class251.smethod_0(A_0);
                    return;
                }
                if (str == BookmarkStart.b("伭帯就嬳䈵夷丹唻儽⸿", num))
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
            string str2 = class2.method_1();
            while (class2.method_9(str2))
            {
                smethod_1(A_0, A_1);
            }
        }
    }
}

