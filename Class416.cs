using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class416
{
    private Class416()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 5;
        A_0.method_9().Settings.method_5().method_72(true);
        Class113 class2 = A_0.method_10().method_2(BookmarkStart.b("Ъ帬䨮䔰䜲尴夶常䠺ጼ䜾ⱀ⽂", 5));
        if (class2 != null)
        {
            Class396 class3 = new Class396(class2.method_3());
            A_0.method_12(class3);
            while (class3.method_9(BookmarkStart.b("伪䈬䰮䐰帲倴夶䴸ᘺ丼娾㕀㝂ⱄ⥆⹈㡊", num)))
            {
                string str;
                if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("堪䠬嬮䔰娲嬴倶䨸", num)))
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
        int num = 14;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䜳匵䰷丹唻倽✿ㅁ", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("圳夵嘷尹唻夽洿⭁ぃ⍅╇杉㽋⭍⑏", num)))
            {
                smethod_2(A_0);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_2(Class857 A_0)
    {
        int num = 0x11;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("吶嘸唺嬼嘾♀湂ⱄ㍆ⱈ♊恌㱎㑐❒", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("吶嘸唺嬼嘾♀湂ⱄ㍆ⱈ♊", num)))
                {
                    if (!(str == BookmarkStart.b("吶嘸唺嬼嘾♀湂ⱄ㍆ⱈ♊恌≎ぐ⍒硔㹖㝘㽚㡜❞Ѡݢ", num)))
                    {
                        goto Label_004F;
                    }
                    smethod_4(A_0);
                }
                else
                {
                    smethod_5(A_0);
                }
                continue;
            }
        Label_004F:
            A_0.method_11().vmethod_1();
        }
    }

    private static void smethod_3(Class857 A_0)
    {
        int num = 11;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("到尲嬴儶倸尺ြ嘾㕀♂⡄橆⑈⩊㵌扎㑐㵒⅔╖⁘", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("到尲嬴儶倸尺ြ嘾㕀♂⡄", num)))
            {
                smethod_5(A_0);
            }
            else
            {
                A_0.method_11().vmethod_1();
            }
        }
    }

    private static void smethod_4(Class857 A_0)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        if (class2.method_12(BookmarkStart.b("䐩䴫䌭唯", 4), "") == BookmarkStart.b("簩䔫䬭䜯䄱", 4))
        {
            while (class2.method_9(BookmarkStart.b("䤩䌫䀭嘯嬱匳ᬵ儷丹夻匽洿⽁╃㙅敇⍉≋⩍㕏⩑ㅓ㉕", num)))
            {
                string str;
                if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䤩䌫䀭嘯嬱匳ᬵ儷丹夻匽洿⽁╃㙅敇⽉≋㩍≏⭑", num)))
                {
                    smethod_3(A_0);
                }
                else
                {
                    A_0.method_11().vmethod_1();
                }
            }
        }
    }

    private static void smethod_5(Class857 A_0)
    {
        int num = 4;
        Class908 class2 = A_0.method_9().Settings.method_5();
        Class396 class3 = A_0.method_11();
        while (class3.method_19())
        {
            string str;
            string str2;
            if ((((str2 = class3.method_1()) != null) && (str2 == BookmarkStart.b("䐩䴫䌭唯", num))) && ((str = class3.method_3()) != null))
            {
                int num2;
                if (Class1160.dictionary_29 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("欩䠫䨭怯匱䘳圵欷䨹崻崽⤿ⱁ⍃ቅ❇ṉⵋⱍ㱏㝑ᝓ㍕㑗㙙⽛", num), 0);
                    dictionary1.Add(BookmarkStart.b("礩䐫䄭䜯怱儳刵吷匹刻嬽̿⩁╃⡅⽇⽉㽋", num), 1);
                    dictionary1.Add(BookmarkStart.b("欩䠫䨭怯匱䘳圵氷嬹帻刽┿ᅁ㑃❅⭇⍉≋⥍", num), 2);
                    dictionary1.Add(BookmarkStart.b("欩䠫䨭甯䨱䀳匵䨷吹崻刽ి❁╃≅ⅇ⑉⭋", num), 3);
                    dictionary1.Add(BookmarkStart.b("瀩䌫䄭崯昱䴳䘵崷", num), 4);
                    dictionary1.Add(BookmarkStart.b("瀩䌫䄭崯琱唳唵䰷唹主", num), 5);
                    dictionary1.Add(BookmarkStart.b("缩弫䬭瘯崱䘳嬵崷䠹瀻圽⸿❁ᝃ㙅⥇⥉╋⁍㝏", num), 6);
                    Class1160.dictionary_29 = dictionary1;
                }
                if (Class1160.dictionary_29.TryGetValue(str, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            A_0.method_60(class3.method_23());
                            return;

                        case 1:
                            A_0.method_9().Settings.method_2(class3.method_23());
                            return;

                        case 2:
                            class2.method_72(class3.method_23());
                            return;

                        case 3:
                            class2.method_42(!class3.method_23());
                            return;

                        case 4:
                            A_0.method_9().ViewSetup.ZoomType = (ZoomType) class3.method_22();
                            return;

                        case 5:
                            A_0.method_9().ViewSetup.ZoomPercent = class3.method_22();
                            return;

                        case 6:
                            class2.method_94(class3.method_23());
                            return;
                    }
                }
            }
        }
    }
}

