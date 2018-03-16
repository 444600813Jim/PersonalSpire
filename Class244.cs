using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;

internal class Class244
{
    private Class244()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2)
    {
        string str = A_0.method_11().method_1();
        ShapeObject obj2 = new ShapeObject(A_0.method_9());
        if (A_2 != null)
        {
            A_2.method_37(obj2.CharacterFormat);
        }
        Class43 class2 = new Class43();
        Class43 class3 = new Class43();
        class3.SetAttr(0x103b, ShapeType.Line);
        smethod_2(A_0, class3);
        Class746.smethod_1(A_0, class2);
        obj2.ShapePr = class2;
        class3.method_37(obj2.ShapePr);
        smethod_1(A_0, str, class3);
        A_1.method_13(obj2);
    }

    private static void smethod_1(Class857 A_0, string A_1, Class43 A_2)
    {
        while (A_0.method_11().method_9(A_1))
        {
            if (!A_0.method_5(A_2))
            {
                A_0.method_11().vmethod_1();
            }
        }
    }

    internal static void smethod_2(Class857 A_0, Class43 A_1)
    {
        int num = 11;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        double num5 = 0.0;
        string str = "";
        while (class2.method_19())
        {
            string str2;
            if ((!Class857.smethod_7(A_0, A_1) && !Class857.smethod_6(A_0, A_1)) && ((str2 = class2.method_1()) != null))
            {
                if (str2 != BookmarkStart.b("䔰䨲䔴制", num))
                {
                    if (str2 != BookmarkStart.b("䤰Ȳ", num))
                    {
                        if (str2 != BookmarkStart.b("䠰Ȳ", num))
                        {
                            if (str2 != BookmarkStart.b("䤰Ĳ", num))
                            {
                                if (!(str2 == BookmarkStart.b("䠰Ĳ", num)))
                                {
                                    if (str2 == BookmarkStart.b("䔰䄲吴夶䨸崺刼䴾ⱀ", num))
                                    {
                                        str = class2.method_3();
                                    }
                                }
                                else
                                {
                                    num5 = Class576.smethod_41(class2.method_3());
                                }
                            }
                            else
                            {
                                num4 = Class576.smethod_41(class2.method_3());
                            }
                        }
                        else
                        {
                            num3 = Class576.smethod_41(class2.method_3());
                        }
                    }
                    else
                    {
                        num2 = Class576.smethod_41(class2.method_3());
                    }
                }
                else
                {
                    A_1.SetAttr(0x103b, Class922.smethod_9(class2.method_3()));
                }
            }
        }
        Class857.smethod_4(A_1, str);
        smethod_3(A_1, num2, num3, num4, num5);
    }

    private static void smethod_3(Class43 A_0, double A_1, double A_2, double A_3, double A_4)
    {
        A_0.SetAttr(0x1021, Math.Min(A_1, A_3));
        A_0.SetAttr(0x1022, Math.Min(A_2, A_4));
        A_0.SetAttr(0x1023, Math.Abs((double) (A_1 - A_3)));
        A_0.SetAttr(0x1024, Math.Abs((double) (A_2 - A_4)));
        if ((A_1 > A_3) && (A_2 > A_4))
        {
            A_0.SetAttr(0x1000, FlipOrientation.Both);
        }
        else if (A_1 > A_3)
        {
            A_0.SetAttr(0x1000, FlipOrientation.Horizontal);
        }
        else if (A_2 > A_4)
        {
            A_0.SetAttr(0x1000, FlipOrientation.Vertical);
        }
    }
}

