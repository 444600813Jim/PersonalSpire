using Spire.Doc;
using System;

internal class Class976
{
    private Class976()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 8;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䠭弯就䀳ᬵ帷嬹弻嬽洿♁⅃╅⑇㥉", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䠭弯就䀳ᬵ帷嬹弻嬽", num)))
            {
                smethod_1(A_0);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_1(Class857 A_0)
    {
        int num = 0x13;
        Class396 class2 = A_0.method_11();
        string str = null;
        string key = null;
        string str3 = null;
        string str4 = null;
        string str5 = null;
        while (class2.method_19())
        {
            string str6 = class2.method_1();
            if (str6 != null)
            {
                if (str6 != BookmarkStart.b("弸吺匼䬾汀╂⑄⩆⁈❊㑌", num))
                {
                    if (str6 != BookmarkStart.b("圸娺值娾", num))
                    {
                        if (str6 != BookmarkStart.b("弸吺匼䬾汀╂⑄⩆⁈❊㑌扎㙐㙒㭔㉖⭘㉚㹜", num))
                        {
                            if (!(str6 == BookmarkStart.b("弸吺匼䬾汀㍂ⱄ㍆⩈⍊", num)))
                            {
                                if (str6 == BookmarkStart.b("弸吺匼䬾汀⁂ⵄ♆㭈㡊⡌㭎", num))
                                {
                                    str5 = class2.method_3();
                                }
                            }
                            else
                            {
                                str4 = class2.method_3();
                            }
                        }
                        else
                        {
                            str3 = class2.method_3();
                        }
                    }
                    else
                    {
                        key = class2.method_3();
                    }
                }
                else
                {
                    string[] strArray = class2.method_3().Replace(BookmarkStart.b("Ḹ", num), "").Split(new char[] { ',' });
                    if (strArray.Length > 0)
                    {
                        str = strArray[0].Trim(new char[] { ' ' });
                    }
                }
            }
        }
        if (key != null)
        {
            if (!A_0.method_54().ContainsKey(key))
            {
                A_0.method_54().Add(key, str);
            }
            if (!Class567.smethod_16(str))
            {
                str = key;
            }
            Form4 form = new Form4();
            form.method_32(key);
            if (Class567.smethod_16(str3))
            {
                form.method_40(Class922.smethod_26(str3));
            }
            if (Class567.smethod_16(str4))
            {
                form.method_42(Class922.smethod_28(str4));
            }
            if (str5 == BookmarkStart.b("䄸ᘺ丼䘾ⱀ⅂⩄⭆", num))
            {
                form.method_38(2);
            }
            A_0.method_9().FontInfoList.method_11(form);
        }
    }
}

