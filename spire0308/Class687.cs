using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class687
{
    private Class687()
    {
    }

    public static void smethod_0(Class404 A_0, bool A_1)
    {
        int num = 12;
        Class181 class2 = new Class181();
        Class181 class3 = new Class181();
        foreach (Class467 class5 in (IEnumerable) A_0.method_0())
        {
            string key = class5.method_2();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_122 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㱉≋⩍繏㵑⑓㍕㙗≙ㅛ㉝ٟൡᙣ୥१ṩὫ䍭o፱ᝳᵵ᥷ᵹ᥻偽ﲇ晴ﶓ놙첟", num), 0);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ尽ⴿ㉁", num), 1);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ䘽洿❁⥃⁅", num), 2);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ夽⤿⑁", num), 3);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ吽〿❁⍃", num), 4);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ䘽洿㉁❃㱅", num), 5);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ丽⸿╁", num), 6);
                    dictionary1.Add(BookmarkStart.b("嬱夳圵強弹ጻ䘽洿㕁⥃⁅", num), 7);
                    dictionary1.Add(BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㱉≋⩍繏㵑⑓㍕㙗≙ㅛ㉝ٟൡᙣ୥१ṩὫ䍭Ὧᑱታή᭷ό᡻ᅽﺉꊋﮗﮙﮝ쒟쮣좥\udca7", num), 8);
                    Class1160.dictionary_122 = dictionary1;
                }
                if (Class1160.dictionary_122.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            continue;
                        }
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        {
                            class2[class5.method_1()] = class5.method_2();
                            continue;
                        }
                    }
                }
            }
            class3.Add(class5.method_0(), class5.method_2());
        }
        Class467 class6 = new Class467(BookmarkStart.b("ᴱ漳电圷吹䠻嬽⸿㙁ᭃቅㅇ㩉⥋㵍൏籑ⱓ㭕㑗", num), "");
        A_0.method_0().method_2(class6);
        Class397 class4 = new Class397(class6.method_4(), A_1);
        class4.method_2(BookmarkStart.b("昱䴳䘵崷䤹", num));
        class4.method_18(BookmarkStart.b("䨱夳娵嘷䤹", num), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳ٵ᥷᥹᝻ώꮃ뒅뢇몉몋ꆍ﶑望ﶗ뎝풟\udba1\ud4a3쎥\udba7", num));
        foreach (DictionaryEntry entry2 in class2)
        {
            smethod_1((string) entry2.Key, (string) entry2.Value, class4);
        }
        smethod_1(BookmarkStart.b("䀱儳娵䬷", num), BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㱉≋⩍繏㵑⑓㍕㙗≙ㅛ㉝ٟൡᙣ୥१ṩὫ䍭o፱ᝳᵵ᥷ᵹ᥻偽ﲇ晴ﶓ놙첟", num), class4);
        smethod_1(BookmarkStart.b("䨱夳娵", num), BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㉉⅋≍", num), class4);
        foreach (DictionaryEntry entry in class3)
        {
            smethod_2((string) entry.Key, (string) entry.Value, class4);
        }
        class4.method_3();
    }

    private static void smethod_1(string A_0, string A_1, Class397 A_2)
    {
        A_2.method_4(BookmarkStart.b("欮吰唲吴䈶唸伺", 9));
        A_2.method_18(BookmarkStart.b("樮䤰䜲倴夶䨸刺刼儾", 9), A_0);
        A_2.method_18(BookmarkStart.b("氮帰崲䄴制圸伺椼䘾ㅀ♂", 9), A_1);
        A_2.method_5();
    }

    private static void smethod_2(string A_0, string A_1, Class397 A_2)
    {
        A_2.method_4(BookmarkStart.b("縰䔲倴䔶䬸刺夼娾", 11));
        A_2.method_18(BookmarkStart.b("愰刲䜴䌶眸娺值娾", 11), A_0);
        A_2.method_18(BookmarkStart.b("爰尲嬴䌶尸唺䤼款㡀㍂⁄", 11), A_1);
        A_2.method_5();
    }
}

