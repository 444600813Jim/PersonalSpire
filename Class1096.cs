using Spire.Doc;
using System;

internal class Class1096
{
    private Class1096()
    {
    }

    internal static Class107 smethod_0(Class857 A_0, string A_1)
    {
        int num = 0x13;
        Class107 class2 = new Class107();
        Class396 class3 = A_0.method_11();
        while (class3.method_9(A_1))
        {
            string str;
            if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("儸帺尼嬾⑀ㅂ桄ⅆ♈⑊㥌⩎⍐繒╔╖㙘⭚㡜ⵞᕠ੢dᑦ", num)))
            {
                Class744.smethod_0(A_0, class2, A_1 == BookmarkStart.b("儸帺尼嬾⑀ㅂ桄㑆㵈㉊⅌⩎", num));
            }
            else
            {
                class3.vmethod_1();
            }
        }
        return class2;
    }
}

