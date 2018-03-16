using Spire.Doc;
using System;

internal class Class570
{
    private Class570()
    {
    }

    internal static void smethod_0(Class857 A_0, Class975 A_1, Class106 A_2, bool A_3)
    {
        Class571 class2 = new Class571();
        A_0.method_17(null);
        smethod_2(A_0, class2);
        Class103 class3 = (Class103) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("別䤧䠩䀫䬭ᴯ䀱嬳䄵", 0), A_0.method_20(), true);
        if ((class3 != null) && (class3.method_12() != null))
        {
            class3.method_12().method_37(class2.method_2());
        }
        A_1.Add(class2);
        smethod_3(A_0, A_2, class2);
        if (A_2 != null)
        {
            class2.method_2().LeftIndent = (float) A_2.method_18().method_0().method_0();
        }
        if (A_3)
        {
            class2.method_2().SetAttr(0xfc8, true);
        }
        A_1.method_6(Math.Max(A_1.method_5(), class2.Count));
    }

    internal static void smethod_1(Class857 A_0, Class975 A_1, Class106 A_2)
    {
        smethod_0(A_0, A_1, A_2, false);
    }

    private static void smethod_2(Class857 A_0, Class571 A_1)
    {
        int num = 14;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (!A_0.method_4(class2) && ((str = class2.method_1()) != null))
            {
                if (!(str == BookmarkStart.b("娳䌵唷堹夻䰽洿ぁ⭃ㅅ㭇杉㹋⭍⁏㝑㕓≕㵗㹙", num)))
                {
                    if (str == BookmarkStart.b("倳匵帷嬹䤻刽㐿潁❃⍅⑇♉態㵍⑏⭑㡓㍕畗㑙㵛㍝՟", num))
                    {
                        A_1.method_7(class2.method_3());
                    }
                }
                else
                {
                    A_1.method_5(class2.method_4());
                }
            }
        }
    }

    internal static void smethod_3(Class857 A_0, Class106 A_1, Class571 A_2)
    {
        int num = 0x10;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䈵夷堹倻嬽洿ぁ⭃ㅅ", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䈵夷堹倻嬽洿⅁⅃⩅⑇", num)))
                {
                    if (!(str == BookmarkStart.b("唵圷䰹夻䰽┿♁楃㉅⥇⡉⁋⭍絏ㅑㅓ㩕㑗", num)))
                    {
                        goto Label_0055;
                    }
                    Class1139.smethod_0(A_0, A_1, A_2, true);
                }
                else
                {
                    Class1139.smethod_0(A_0, A_1, A_2, false);
                }
                continue;
            }
        Label_0055:
            class2.vmethod_1();
        }
    }
}

