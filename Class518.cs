using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using System;
using System.Collections.Generic;

internal class Class518
{
    private Class518()
    {
    }

    internal static bool smethod_0(Class581 A_0, List<BookmarkStart> A_1, List<BookmarkEnd> A_2, List<PermissionStart> A_3, List<PermissionEnd> A_4)
    {
        int num = 0x10;
        bool flag = false;
        Paragraph paragraph = new Paragraph(A_0.Interface50.imethod_0());
        if (A_0.Interface50.imethod_0().Styles.DefaultParaStyle != null)
        {
            paragraph.method_65(A_0.Interface50.imethod_0().Styles.DefaultParaStyle);
        }
        smethod_1(paragraph, A_1);
        smethod_2(paragraph, A_2);
        smethod_3(paragraph, A_3);
        smethod_4(paragraph, A_4);
        A_0.method_3(paragraph);
        A_0.method_7();
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("䘵", num)))
        {
            if (smethod_6(A_0, paragraph))
            {
                flag = true;
            }
        }
        A_0.method_5(DocumentObjectType.Paragraph);
        return flag;
    }

    private static void smethod_1(Paragraph A_0, List<BookmarkStart> A_1)
    {
        if ((A_1 != null) && (A_1.Count > 0))
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                A_0.Items.Add(A_1[i]);
            }
            A_1.Clear();
        }
    }

    private static void smethod_2(Paragraph A_0, List<BookmarkEnd> A_1)
    {
        if (A_1 != null)
        {
            foreach (BookmarkEnd end in A_1)
            {
                A_0.Items.Add(end);
            }
            A_1.Clear();
        }
    }

    private static void smethod_3(Paragraph A_0, List<PermissionStart> A_1)
    {
        if ((A_1 != null) && (A_1.Count > 0))
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                A_0.Items.Add(A_1[i]);
            }
            A_1.Clear();
        }
    }

    private static void smethod_4(Paragraph A_0, List<PermissionEnd> A_1)
    {
        if (A_1 != null)
        {
            foreach (PermissionEnd end in A_1)
            {
                A_0.Items.Add(end);
            }
            A_1.Clear();
        }
    }

    private static bool smethod_5(Class581 A_0)
    {
        int num = 6;
        Class582 class2 = A_0 as Class582;
        if (class2 == null)
        {
            return false;
        }
        if (!class2.method_35())
        {
            return false;
        }
        if (!(A_0.imethod_1().method_1() == BookmarkStart.b("䌫挭儯䘱尳昵夷䠹崻", num)))
        {
            return (A_0.imethod_1().method_1() == BookmarkStart.b("䌫挭儯䘱尳", num));
        }
        return true;
    }

    private static bool smethod_6(Class581 A_0, Paragraph A_1)
    {
        int num = 0;
        bool flag = false;
        Class394 class2 = A_0.imethod_1();
        if (A_0.vmethod_1() && !smethod_5(A_0))
        {
            Class9 class3 = Class402.smethod_0(A_0, MarkupLevel.Inline);
            A_0.method_3(class3);
            while (class2.method_9(class3.method_22()))
            {
                flag = smethod_6(A_0, A_1);
            }
            A_0.method_5(DocumentObjectType.CustomXml);
            return flag;
        }
        string str = class2.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("嘥砧堩", num))
            {
                return Class924.smethod_0(A_0, A_1.Format, A_1.BreakCharacterFormat);
            }
            if (str != BookmarkStart.b("䨥䄧天堫縭䈯", num))
            {
                if ((str == BookmarkStart.b("嘥䴧堩䄫紭䐯匱䘳䈵", num)) || (str == BookmarkStart.b("嘥䴧堩䄫欭帯嘱", num)))
                {
                    Class464.smethod_1(A_0);
                    return flag;
                }
                if (str == BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷", num))
                {
                    Class519.smethod_1(A_0, A_1);
                    return flag;
                }
            }
            else
            {
                Class924.smethod_7(A_0, A_1.Format);
                return flag;
            }
        }
        Class464.smethod_1(A_0);
        return flag;
    }
}

