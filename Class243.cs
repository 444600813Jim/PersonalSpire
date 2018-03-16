using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class243
{
    private Class243()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 2;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䔧䬩弫娭唯䀱ᤳ䔵䰷䌹倻嬽㌿", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䔧䬩弫娭唯䀱ᤳ䘵夷崹夻", num)))
            {
                Class1142.smethod_0(A_0);
            }
            else
            {
                class2.vmethod_1();
            }
        }
        smethod_1(A_0.method_14());
    }

    internal static void smethod_1(Class854 A_0)
    {
        foreach (Class108 class2 in A_0)
        {
            if (Class567.smethod_16(class2.method_6()))
            {
                Class108 class3 = A_0.method_0(class2.method_6());
                if (class3 != null)
                {
                    smethod_2(class2, class3, HeaderFooterType.HeaderOdd);
                    smethod_2(class2, class3, HeaderFooterType.FooterOdd);
                    smethod_2(class2, class3, HeaderFooterType.HeaderEven);
                    smethod_2(class2, class3, HeaderFooterType.FooterEven);
                    class2.method_8().SectPr.method_59(true);
                }
            }
        }
    }

    internal static void smethod_2(Class108 A_0, Class108 A_1, HeaderFooterType A_2)
    {
        HeaderFooter footer = A_1.method_8().HeadersFooters[A_2];
        switch (A_2)
        {
            case HeaderFooterType.HeaderEven:
                A_0.method_8().HeadersFooters[HeaderFooterType.HeaderEven] = footer;
                return;

            case HeaderFooterType.HeaderOdd:
                A_0.method_8().HeadersFooters[HeaderFooterType.HeaderOdd] = footer;
                return;

            case HeaderFooterType.FooterEven:
                A_0.method_8().HeadersFooters[HeaderFooterType.FooterEven] = footer;
                return;

            case HeaderFooterType.FooterOdd:
                A_0.method_8().HeadersFooters[HeaderFooterType.FooterOdd] = footer;
                return;

            case HeaderFooterType.HeaderFirstPage:
                A_0.method_8().HeadersFooters[HeaderFooterType.HeaderFirstPage] = footer;
                return;

            case HeaderFooterType.FooterFirstPage:
                A_0.method_8().HeadersFooters[HeaderFooterType.FooterFirstPage] = footer;
                return;
        }
    }
}

