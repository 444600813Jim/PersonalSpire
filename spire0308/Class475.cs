using Spire.Doc;
using System;
using System.Collections;

internal class Class475
{
    private Class475()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 4;
        Class113 class2 = A_0.method_10().method_2(BookmarkStart.b("ԩ愫欭搯猱ᤳ缵瘷簹ጻ匽ℿⱁⵃ⁅ⵇ㥉㡋恍⡏㽑㡓", 4));
        if (class2 != null)
        {
            A_0.method_64(new Hashtable());
            Class396 class3 = new Class396(class2.method_3());
            A_0.method_12(class3);
            while (class3.method_9(BookmarkStart.b("䜩䴫䀭夯吱儳䔵䰷", num)))
            {
                string str;
                if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("䰩䔫䈭唯ἱ儳堵䰷䠹䔻", num)))
                {
                    smethod_1(A_0);
                }
                else
                {
                    class3.vmethod_1();
                }
            }
        }
    }

    private static void smethod_1(Class857 A_0)
    {
        int num = 2;
        Class396 class2 = A_0.method_11();
        string key = null;
        string str2 = null;
        while (class2.method_19())
        {
            string str3 = class2.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("丧弩䀫䈭ᴯ䈱唳䈵倷", num)))
                {
                    if (str3 == BookmarkStart.b("䔧伩䠫䜭儯ἱ䀳伵䠷弹", num))
                    {
                        str2 = class2.method_3();
                    }
                }
                else
                {
                    key = class2.method_3();
                }
            }
        }
        if (key != null)
        {
            A_0.method_63().Add(key, str2);
        }
    }
}

