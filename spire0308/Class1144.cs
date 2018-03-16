using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class1144
{
    private Class1144()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2, Style A_3)
    {
        A_0.method_17(null);
        Class977 class2 = smethod_1(A_0);
        smethod_2(A_0);
        if (class2 is Class978)
        {
            Class797.smethod_7(A_0, A_1, class2 as Class978, A_2, A_3);
        }
    }

    private static Class977 smethod_1(Class857 A_0)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        Class977 class3 = A_0.method_15().method_1(class2.method_12(BookmarkStart.b("䤩䌫䀭䐯䀱嬳娵", 4), ""));
        if (class3 == null)
        {
            return null;
        }
        class2.method_18();
        while (class2.method_19())
        {
            string str;
            if (!A_0.method_4(class2) && ((str = class2.method_1()) != null))
            {
                int num2;
                if (Class1160.dictionary_232 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x11);
                    dictionary1.Add(BookmarkStart.b("崩䔫䨭䐯娱", num), 0);
                    dictionary1.Add(BookmarkStart.b("䈩䤫䜭圯娱䀳", num), 1);
                    dictionary1.Add(BookmarkStart.b("利", num), 2);
                    dictionary1.Add(BookmarkStart.b("匩", num), 3);
                    dictionary1.Add(BookmarkStart.b("䬩䈫䴭堯崱䘳ᬵ䰷䌹䰻嬽", num), 4);
                    dictionary1.Add(BookmarkStart.b("帩䤫嘭䐯ἱ䜳䈵䄷嘹夻ጽ⸿⍁⥃⍅", num), 5);
                    dictionary1.Add(BookmarkStart.b("倩ī䜭帯嘱儳丵", num), 6);
                    dictionary1.Add(BookmarkStart.b("䌩䠫", num), 7);
                    dictionary1.Add(BookmarkStart.b("䘩䴫圭唯䀱", num), 8);
                    dictionary1.Add(BookmarkStart.b("䤩䀫伭䌯䄱ᤳ堵夷圹夻䴽", num), 9);
                    dictionary1.Add(BookmarkStart.b("帩師伭帯䄱刳夵䨷圹", num), 10);
                    dictionary1.Add(BookmarkStart.b("䐩䴫䌭唯", num), 11);
                    dictionary1.Add(BookmarkStart.b("伩䈫䨭ᴯ儱儳娵吷᜹崻娽␿ぁ⅃㕅㭇", num), 12);
                    dictionary1.Add(BookmarkStart.b("伩䈫䨭ᴯ䨱", num), 13);
                    dictionary1.Add(BookmarkStart.b("伩䈫䨭ᴯ䬱", num), 14);
                    dictionary1.Add(BookmarkStart.b("帩䴫䰭尯圱ᤳ吵夷夹圻夽㈿ⵁㅃ⡅ⱇ", num), 15);
                    dictionary1.Add(BookmarkStart.b("䬩䈫䴭堯崱䘳ᬵ䠷嬹嬻嬽洿ⱁㅃ⭅⩇⽉㹋", num), 0x10);
                    Class1160.dictionary_232 = dictionary1;
                }
                if (Class1160.dictionary_232.TryGetValue(str, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            class3.method_3(Class576.smethod_41(class2.method_3()));
                            break;

                        case 1:
                            class3.method_5(Class576.smethod_41(class2.method_3()));
                            break;
                    }
                }
            }
        }
        return class3;
    }

    private static void smethod_2(Class857 A_0)
    {
        int num = 7;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("丬䀮弰䜲䜴堶唸", num)))
        {
            A_0.method_11().method_1();
            class2.vmethod_1();
        }
    }
}

