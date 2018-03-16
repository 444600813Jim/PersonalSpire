using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class473
{
    private Class473()
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
        class3.SetAttr(0x103b, ShapeType.Ellipse);
        smethod_2(A_0, class3);
        Class746.smethod_1(A_0, class2);
        smethod_1(A_0, str, obj2, class3);
        obj2.ShapePr = class2;
        class3.method_37(obj2.ShapePr);
        A_1.method_13(obj2);
    }

    private static void smethod_1(Class857 A_0, string A_1, ShapeObject A_2, Class43 A_3)
    {
        while (A_0.method_11().method_9(A_1))
        {
            if (!A_0.method_5(A_3))
            {
                Class857.smethod_13(A_0, A_2);
            }
        }
    }

    private static void smethod_2(Class857 A_0, Class43 A_1)
    {
        int num = 0x11;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if ((!Class857.smethod_7(A_0, A_1) && !Class857.smethod_6(A_0, A_1)) && (!A_0.method_2(class2, A_1) && ((str = class2.method_1()) != null)))
            {
                int num2;
                if (Class1160.dictionary_44 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("䔶䄸", num), 0);
                    dictionary1.Add(BookmarkStart.b("䔶䀸", num), 1);
                    dictionary1.Add(BookmarkStart.b("吶䄸", num), 2);
                    dictionary1.Add(BookmarkStart.b("吶䀸", num), 3);
                    dictionary1.Add(BookmarkStart.b("尶倸唺夼", num), 4);
                    dictionary1.Add(BookmarkStart.b("䐶䴸娺似䬾汀≂⭄⁆╈⹊", num), 5);
                    dictionary1.Add(BookmarkStart.b("制圸强ြ帾⽀⑂⥄≆", num), 6);
                    Class1160.dictionary_44 = dictionary1;
                }
                if (Class1160.dictionary_44.TryGetValue(str, out num2))
                {
                }
            }
        }
    }
}

