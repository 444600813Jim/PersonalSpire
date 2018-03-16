using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class693
{
    private Class693()
    {
    }

    internal static void smethod_0(Class857 A_0, ListLevel A_1)
    {
        if (smethod_1(A_0, A_1))
        {
            smethod_2(A_0, A_1);
        }
    }

    private static bool smethod_1(Class857 A_0, ListLevel A_1)
    {
        int num = 14;
        Class396 class2 = A_0.method_11();
        float num2 = 0f;
        float num3 = 0f;
        float num4 = 0f;
        bool flag = false;
        while (class2.method_19())
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num5;
                if (Class1160.dictionary_123 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("䜳䘵夷夹夻ጽ∿❁≃⥅㩇⽉", num), 0);
                    dictionary1.Add(BookmarkStart.b("夳張嘷᜹倻弽∿❁⡃歅㽇⍉⡋㩍㡏", num), 1);
                    dictionary1.Add(BookmarkStart.b("夳張嘷᜹倻弽∿❁⡃歅ⱇ⍉㽋㩍ㅏ㱑㝓㍕", num), 2);
                    dictionary1.Add(BookmarkStart.b("䀳匵䀷丹ᄻ弽ⰿ⭁⍃⡅", num), 3);
                    dictionary1.Add(BookmarkStart.b("䌳張尷丹吻", num), 4);
                    dictionary1.Add(BookmarkStart.b("尳匵儷崹吻䨽", num), 5);
                    dictionary1.Add(BookmarkStart.b("堳張䬷丹ᄻ刽┿㑁⅃⩅敇㩉⍋㵍㥏♑㵓㥕㙗睙㵛そџ佡ᝣᙥ१३५䍭ᵯᵱၳ፵", num), 6);
                    Class1160.dictionary_123 = dictionary1;
                }
                if (Class1160.dictionary_123.TryGetValue(key, out num5))
                {
                    switch (num5)
                    {
                        case 0:
                            num2 = (float) Class576.smethod_41(class2.method_3());
                            break;

                        case 1:
                            num3 = (float) Class576.smethod_41(class2.method_3());
                            break;

                        case 2:
                            num4 = (float) Class576.smethod_41(class2.method_3());
                            break;

                        case 3:
                            A_1.NumberAlignment = Class922.smethod_53(class2.method_3());
                            break;

                        case 4:
                            if (A_1.HasPictureBullet)
                            {
                                A_1.PicBullet.ShapePr.SetAttr(0x1023, Class576.smethod_41(class2.method_3()));
                            }
                            break;

                        case 5:
                            if (A_1.HasPictureBullet)
                            {
                                A_1.PicBullet.ShapePr.SetAttr(0x1024, Class576.smethod_41(class2.method_3()));
                            }
                            break;

                        case 6:
                            flag = true;
                            break;
                    }
                }
            }
        }
        if (A_1.NumberAlignment == ListNumberAlignment.Right)
        {
            if (num3 != 0f)
            {
                A_1.ParagraphFormat.LeftIndent = num3;
            }
            A_1.ParagraphFormat.FirstLineIndent = (num3 - num4) - A_1.ParagraphFormat.LeftIndent;
            return flag;
        }
        if ((num3 + num2) != 0f)
        {
            A_1.ParagraphFormat.LeftIndent = num3 + num2;
        }
        A_1.ParagraphFormat.FirstLineIndent = num2 - A_1.ParagraphFormat.LeftIndent;
        return flag;
    }

    private static void smethod_2(Class857 A_0, ListLevel A_1)
    {
        int num = 0x13;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("唸刺丼䬾汀⽂⁄ㅆⱈ❊恌㽎⍐㱒╔㉖⭘⽚㑜㩞በ", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("唸刺丼䬾汀⽂⁄ㅆⱈ❊恌⍎ぐㅒご㭖瑘㩚ㅜ㙞٠ൢࡤɦݨὪ", num)))
            {
                smethod_3(A_0, A_1);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_3(Class857 A_0, ListLevel A_1)
    {
        int num = 15;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("头帶䨸伺ြ䬾⁀⅂桄㑆㵈⑊㵌扎⅐㱒♔㹖ⵘ㉚㉜ㅞ", num))
                {
                    if (!(str == BookmarkStart.b("䄴制䄸伺ြ嘾⽀❂⁄⥆㵈", num)))
                    {
                        if (str == BookmarkStart.b("場嘶䬸尺吼儾汀⽂⁄ⅆ㵈", num))
                        {
                            A_1.ParagraphFormat.LeftIndent = Class576.smethod_36(class2.method_3());
                        }
                    }
                    else
                    {
                        A_1.ParagraphFormat.FirstLineIndent = Class576.smethod_36(class2.method_3());
                    }
                }
                else
                {
                    A_1.TabSpaceAfter = (float) Class576.smethod_41(class2.method_3());
                }
            }
        }
    }
}

