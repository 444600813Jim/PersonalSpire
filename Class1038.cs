using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class1038
{
    private Class1038()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        Section section = new Section(A_0.Interface50.imethod_0());
        A_0.method_3(section);
        A_0.method_4(section.Body);
        smethod_1(A_0);
        A_0.method_5(DocumentObjectType.Body);
        A_0.method_5(DocumentObjectType.Section);
    }

    private static void smethod_1(Class581 A_0)
    {
        int num = 5;
        Class394 class2 = A_0.imethod_1();
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            string str2;
            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("堪䠬䰮䔰挲䜴", num)))
            {
                Body body = (Body) A_0.method_13();
                Class980.smethod_0(A_0, body.ParentSection);
            }
            else
            {
                Class629.smethod_2(A_0);
            }
        }
    }
}

