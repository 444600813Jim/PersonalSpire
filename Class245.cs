using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;

internal class Class245
{
    private Class245()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2)
    {
        ShapeObject obj2 = new ShapeObject(A_0.method_9());
        if (A_2 != null)
        {
            A_2.method_37(obj2.CharacterFormat);
        }
        Class43 class2 = new Class43();
        Class43 class3 = new Class43();
        class3.SetAttr(0x103b, ShapeType.StraightConnector1);
        Class244.smethod_2(A_0, class3);
        Class746.smethod_1(A_0, class2);
        smethod_1(A_0, class3);
        obj2.ShapePr = class2;
        class3.method_37(obj2.ShapePr);
        obj2.SetShapeAttribute(0x147, 0x2a30);
        A_1.method_13(obj2);
    }

    private static void smethod_1(Class857 A_0, Class43 A_1)
    {
        int num = 14;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("圳夵嘷吹夻崽㐿ⵁ㙃", num)))
        {
            if (!A_0.method_5(A_1))
            {
                class2.vmethod_1();
            }
        }
    }
}

