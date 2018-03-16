using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;

internal class Class1051
{
    private Class1051()
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
        class3.SetAttr(0x103b, ShapeType.Rectangle);
        smethod_2(A_0, class3);
        Class746.smethod_1(A_0, class2);
        smethod_1(A_0, str, class3);
        obj2.ShapePr = class2;
        class3.method_37(obj2.ShapePr);
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

    private static void smethod_2(Class857 A_0, Class43 A_1)
    {
        int num = 10;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        string str = "";
        while (class2.method_19())
        {
            string str2;
            if (((!Class857.smethod_7(A_0, A_1) && !Class857.smethod_6(A_0, A_1)) && (!A_0.method_2(class2, A_1) && ((str2 = class2.method_1()) != null))) && (!(str2 == BookmarkStart.b("匯崱䘳堵崷䠹ᄻ䰽ℿ♁ⵃ㍅㭇", num)) && (str2 == BookmarkStart.b("䐯䀱唳堵䬷尹医䰽ⴿ", num))))
            {
                str = class2.method_3();
            }
        }
        Class857.smethod_4(A_1, str);
    }
}

