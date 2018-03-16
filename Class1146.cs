using Spire.Doc.Formatting;
using System;

internal class Class1146
{
    internal static void smethod_0(Class581 A_0, ParagraphFormat A_1, CharacterFormat A_2, Class584 A_3)
    {
        object obj2 = A_1.method_31(0x465);
        A_1.method_71(0x465);
        object obj3 = A_1.method_31(0x62c);
        A_1.method_71(0x62c);
        ParagraphFormat format = (ParagraphFormat) A_1.method_23();
        A_1.ClearFormatting();
        Class924.smethod_0(A_0, A_1, A_2);
        bool flag = A_1.method_31(0x3e8) != null;
        bool flag2 = format.method_31(0x3e8) != null;
        if (flag && !flag2)
        {
            format.SetAttr(0x3e8, format.method_31(0x3e8));
        }
        if (obj2 != null)
        {
            A_1.SetAttr(0x465, obj2);
        }
        if (obj3 != null)
        {
            A_1.SetAttr(0x62c, obj3);
        }
    }

    internal static void smethod_1(Class581 A_0, CharacterFormat A_1, Class584 A_2)
    {
        object obj2 = A_1.method_31(14);
        A_1.Remove(14);
        object obj3 = A_1.method_31(12);
        A_1.Remove(12);
        object obj4 = A_1.method_31(40);
        A_1.Remove(40);
        object obj5 = A_1.method_31(30);
        A_1.Remove(30);
        CharacterFormat format1 = (CharacterFormat) A_1.method_23();
        A_1.ClearFormatting();
        Class733.smethod_0(A_0, A_1);
        A_1.Remove(14);
        A_1.Remove(12);
        if (obj2 != null)
        {
            A_1.SetAttr(14, obj2);
        }
        if (obj3 != null)
        {
            A_1.SetAttr(12, obj3);
        }
        if (obj4 != null)
        {
            A_1.SetAttr(40, obj4);
        }
        if (obj5 != null)
        {
            A_1.SetAttr(30, obj5);
        }
    }
}

