using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class575
{
    private Class575()
    {
    }

    internal static void smethod_0(Class857 A_0, Class108 A_1, string A_2)
    {
        int num = 6;
        Class92 class2 = A_0.method_13().method_2(A_1.method_4(), null, A_0.method_20(), true) as Class92;
        HeaderFooterType type = smethod_1(A_1, A_2);
        HeaderFooter evenHeader = null;
        switch (type)
        {
            case HeaderFooterType.HeaderEven:
                evenHeader = A_1.method_8().HeadersFooters.EvenHeader;
                break;

            case HeaderFooterType.HeaderOdd:
                evenHeader = A_1.method_8().HeadersFooters.OddHeader;
                break;

            case HeaderFooterType.FooterEven:
                evenHeader = A_1.method_8().HeadersFooters.EvenFooter;
                break;

            case HeaderFooterType.FooterOdd:
                evenHeader = A_1.method_8().HeadersFooters.OddFooter;
                break;

            case HeaderFooterType.HeaderFirstPage:
                evenHeader = A_1.method_8().HeadersFooters.FirstPageHeader;
                break;

            case HeaderFooterType.FooterFirstPage:
                evenHeader = A_1.method_8().HeadersFooters.FirstPageFooter;
                break;
        }
        Class17 class3 = null;
        if (class2 != null)
        {
            Class107 class4 = A_2.StartsWith(BookmarkStart.b("䐫䬭儯嘱儳䐵", num)) ? class2.method_12() : class2.method_14();
            if (class4 != null)
            {
                class3 = class4.method_4();
            }
            if (A_2.EndsWith(BookmarkStart.b("ī䈭唯吱䀳", num)))
            {
                A_0.method_9().Settings.bool_37 = true;
            }
            if (class3 != null)
            {
                class3.method_37(A_1.method_8().SectPr);
            }
            while (A_0.method_11().method_9(A_2))
            {
                string key = A_0.method_11().method_1();
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_109 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                        dictionary1.Add(BookmarkStart.b("尫", num), 0);
                        dictionary1.Add(BookmarkStart.b("䐫", num), 1);
                        dictionary1.Add(BookmarkStart.b("䀫䜭䌯䘱", num), 2);
                        dictionary1.Add(BookmarkStart.b("堫伭刯帱儳", num), 3);
                        dictionary1.Add(BookmarkStart.b("堫伭刯帱儳ᬵ圷尹ᄻ崽⼿ⱁぃ⍅♇㹉", num), 4);
                        dictionary1.Add(BookmarkStart.b("䴫䈭䀯娱唳吵崷丹唻崽ℿ⹁楃⽅♇⹉⥋㙍", num), 5);
                        dictionary1.Add(BookmarkStart.b("䔫䈭尯䜱䜳䈵䨷嬹䠻圽⼿ⱁ楃⽅♇⹉⥋㙍", num), 6);
                        dictionary1.Add(BookmarkStart.b("堫伭刯帱儳ᬵ儷吹堻嬽㠿", num), 7);
                        dictionary1.Add(BookmarkStart.b("䌫䰭娯圱圳䈵ᔷ匹刻娽┿㩁", num), 8);
                        dictionary1.Add(BookmarkStart.b("夫崭唯䀱ᤳ張嘷帹夻䘽", num), 9);
                        dictionary1.Add(BookmarkStart.b("丫䜭刯帱崳夵強䠹崻丽⠿㭁", num), 10);
                        Class1160.dictionary_109 = dictionary1;
                    }
                    if (Class1160.dictionary_109.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                            case 1:
                            {
                                Class1099.smethod_1(A_0, A_0.method_11().method_1(), evenHeader);
                                continue;
                            }
                            case 2:
                            {
                                Class530.smethod_0(A_0, evenHeader, null);
                                continue;
                            }
                            case 3:
                            {
                                Class90.smethod_0(A_0, evenHeader);
                                continue;
                            }
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                            case 10:
                            {
                                if (!Class246.smethod_0(A_0, evenHeader, A_1))
                                {
                                    A_0.method_11().vmethod_1();
                                }
                                continue;
                            }
                        }
                    }
                }
                A_0.method_11().vmethod_1();
            }
        }
    }

    private static HeaderFooterType smethod_1(Class108 A_0, string A_1)
    {
        int num = 7;
        if (A_1.StartsWith(BookmarkStart.b("䔬䨮倰圲倴䔶", 7)))
        {
            if (A_1.EndsWith(BookmarkStart.b(",䌮吰唲䄴", num)))
            {
                return HeaderFooterType.HeaderEven;
            }
            if (Class567.smethod_16(A_0.method_6()))
            {
                return HeaderFooterType.HeaderFirstPage;
            }
            return HeaderFooterType.HeaderOdd;
        }
        if (A_1.EndsWith(BookmarkStart.b(",䌮吰唲䄴", num)))
        {
            return HeaderFooterType.FooterEven;
        }
        if (Class567.smethod_16(A_0.method_6()))
        {
            return HeaderFooterType.FooterFirstPage;
        }
        return HeaderFooterType.FooterOdd;
    }
}

