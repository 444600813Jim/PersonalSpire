using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class339
{
    private Class339()
    {
    }

    internal static FootnoteRestartRule smethod_0(string A_0)
    {
        int num = 11;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("到尲嬴䌶倸唺䠼倾㑀あ", num))
            {
                return FootnoteRestartRule.DoNotRestart;
            }
            if (str == BookmarkStart.b("吰刲嘴弶樸帺帼䬾", num))
            {
                return FootnoteRestartRule.RestartSection;
            }
            if (str == BookmarkStart.b("吰刲嘴弶ᐸ䠺堼尾㕀", num))
            {
                return FootnoteRestartRule.RestartSection;
            }
            if (str == BookmarkStart.b("吰刲嘴弶椸娺娼娾", num))
            {
                return FootnoteRestartRule.RestartPage;
            }
            if (str == BookmarkStart.b("吰刲嘴弶ᐸ䬺尼堾⑀", num))
            {
                return FootnoteRestartRule.RestartPage;
            }
        }
        return FootnoteRestartRule.DoNotRestart;
    }

    internal static string smethod_1(FootnoteRestartRule A_0, bool A_1)
    {
        int num = 0;
        if (A_0 != FootnoteRestartRule.DoNotRestart)
        {
            switch (A_0)
            {
                case FootnoteRestartRule.DoNotRestart:
                    return BookmarkStart.b("䔥䜧䐩堫䜭帯䜱嬳䌵䬷", num);

                case FootnoteRestartRule.RestartSection:
                    if (A_1)
                    {
                        return BookmarkStart.b("䌥䤧䤩䐫紭唯儱䀳", num);
                    }
                    return BookmarkStart.b("䌥䤧䤩䐫̭䌯圱圳䈵", num);

                case FootnoteRestartRule.RestartPage:
                    if (A_1)
                    {
                        return BookmarkStart.b("䌥䤧䤩䐫縭儯唱儳", num);
                    }
                    return BookmarkStart.b("䌥䤧䤩䐫̭䀯匱匳匵", num);
            }
        }
        return "";
    }

    internal static PageSeparator smethod_10(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_16 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("弶䀸䬺唼娾⽀", num), 0);
                dictionary1.Add(BookmarkStart.b("䜶尸䤺吼倾╀", num), 1);
                dictionary1.Add(BookmarkStart.b("吶嘸场刼儾", num), 2);
                dictionary1.Add(BookmarkStart.b("制吸缺尼䰾⥀", num), 3);
                dictionary1.Add(BookmarkStart.b("制吸ᘺ夼帾㉀⭂", num), 4);
                dictionary1.Add(BookmarkStart.b("制圸缺尼䰾⥀", num), 5);
                dictionary1.Add(BookmarkStart.b("制圸ᘺ夼帾㉀⭂", num), 6);
                Class1160.dictionary_16 = dictionary1;
            }
            if (Class1160.dictionary_16.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return PageSeparator.Hyphen;

                    case 1:
                        return PageSeparator.Period;

                    case 2:
                        return PageSeparator.Colon;

                    case 3:
                    case 4:
                        return PageSeparator.EmDash;

                    case 5:
                    case 6:
                        return PageSeparator.EnDash;
                }
            }
        }
        return PageSeparator.Hyphen;
    }

    internal static string smethod_11(PageSeparator A_0, bool A_1)
    {
        int num = 4;
        switch (A_0)
        {
            case PageSeparator.Hyphen:
                return BookmarkStart.b("䈩唫席堯圱娳", num);

            case PageSeparator.Period:
                return BookmarkStart.b("娩䤫尭夯崱倳", num);

            case PageSeparator.Colon:
                return BookmarkStart.b("䤩䌫䈭弯就", num);

            case PageSeparator.EmDash:
                if (A_1)
                {
                    return BookmarkStart.b("伩䄫樭儯䄱尳", num);
                }
                return BookmarkStart.b("伩䄫̭启匱䜳帵", num);

            case PageSeparator.EnDash:
                if (A_1)
                {
                    return BookmarkStart.b("伩䈫樭儯䄱尳", num);
                }
                return BookmarkStart.b("伩䈫̭启匱䜳帵", num);
        }
        return "";
    }

    internal static LineNumberingRestartMode smethod_12(string A_0)
    {
        int num = 15;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("嘴堶圸伺吼儾㑀ⱂい㑆", num))
            {
                return LineNumberingRestartMode.Continuous;
            }
            if ((str == BookmarkStart.b("嬴制丸欺尼堾⑀", num)) || (str == BookmarkStart.b("嬴制丸ᘺ䴼帾♀♂", num)))
            {
                return LineNumberingRestartMode.RestartPage;
            }
            if ((str == BookmarkStart.b("嬴制丸栺堼尾㕀⩂⩄⥆", num)) || (str == BookmarkStart.b("嬴制丸ᘺ丼娾≀㝂ⱄ⡆❈", num)))
            {
                return LineNumberingRestartMode.RestartSection;
            }
        }
        return LineNumberingRestartMode.RestartPage;
    }

    internal static string smethod_13(LineNumberingRestartMode A_0, bool A_1)
    {
        int num = 4;
        switch (A_0)
        {
            case LineNumberingRestartMode.RestartPage:
                if (A_1)
                {
                    return BookmarkStart.b("䐩䤫夭怯匱匳匵", num);
                }
                return BookmarkStart.b("䐩䤫夭ᴯ䈱唳儵崷", num);

            case LineNumberingRestartMode.RestartSection:
                if (A_1)
                {
                    return BookmarkStart.b("䐩䤫夭振圱圳䈵儷唹刻", num);
                }
                return BookmarkStart.b("䐩䤫夭ᴯ䄱儳唵䰷匹医倽", num);

            case LineNumberingRestartMode.Continuous:
                return BookmarkStart.b("䤩䌫䀭䐯嬱娳䌵圷伹伻", num);
        }
        return "";
    }

    internal static PageBorderOffsetFrom smethod_14(string A_0)
    {
        int num = 0x10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䘵夷崹夻", num))
            {
                return PageBorderOffsetFrom.PageEdge;
            }
            if (str == BookmarkStart.b("䈵崷䈹䠻", num))
            {
                return PageBorderOffsetFrom.Text;
            }
        }
        return PageBorderOffsetFrom.PageEdge;
    }

    internal static string smethod_15(PageBorderOffsetFrom A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case PageBorderOffsetFrom.Text:
                return BookmarkStart.b("䜲倴伶䴸", num);

            case PageBorderOffsetFrom.PageEdge:
                return BookmarkStart.b("䌲吴倶尸", num);
        }
        return "";
    }

    internal static PageBordersApplyType smethod_16(string A_0)
    {
        int num = 14;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_17 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("唳娵吷樹崻夽┿ㅁ", num), 0);
                dictionary1.Add(BookmarkStart.b("唳娵吷᜹䰻弽✿❁㝃", num), 1);
                dictionary1.Add(BookmarkStart.b("刳張䨷䤹䠻渽ℿ╁⅃", num), 2);
                dictionary1.Add(BookmarkStart.b("刳張䨷䤹䠻ጽ〿⍁⍃⍅", num), 3);
                dictionary1.Add(BookmarkStart.b("娳夵䰷簹唻䰽㌿㙁ᑃ❅⽇⽉", num), 4);
                dictionary1.Add(BookmarkStart.b("娳夵䰷᜹娻圽㈿ㅁぃ歅㡇⭉⭋⭍", num), 5);
                Class1160.dictionary_17 = dictionary1;
            }
            if (Class1160.dictionary_17.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return PageBordersApplyType.AllPages;

                    case 2:
                    case 3:
                        return PageBordersApplyType.FirstPage;

                    case 4:
                    case 5:
                        return PageBordersApplyType.AllExceptFirstPage;
                }
            }
        }
        return PageBordersApplyType.AllPages;
    }

    internal static string smethod_17(PageBordersApplyType A_0, bool A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case PageBordersApplyType.AllPages:
                if (A_1)
                {
                    return BookmarkStart.b("丮崰弲攴嘶常帺丼", num);
                }
                return BookmarkStart.b("丮崰弲ᠴ䜶堸尺堼䰾", num);

            case PageBordersApplyType.FirstPage:
                if (A_1)
                {
                    return BookmarkStart.b("䤮堰䄲䘴䌶椸娺娼娾", num);
                }
                return BookmarkStart.b("䤮堰䄲䘴䌶ᐸ䬺尼堾⑀", num);

            case PageBordersApplyType.AllExceptFirstPage:
                if (A_1)
                {
                    return BookmarkStart.b("䄮帰䜲猴帶䬸䠺䤼漾⁀⑂⁄", num);
                }
                return BookmarkStart.b("䄮帰䜲ᠴ儶倸䤺丼䬾汀㍂⑄⁆ⱈ", num);
        }
        return "";
    }

    internal static PageOrientation smethod_18(string A_0)
    {
        int num = 7;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䄬丮弰圲䘴吶堸䬺堼", num))
            {
                return PageOrientation.Landscape;
            }
            if (str == BookmarkStart.b("崬䀮䌰䜲䜴嘶倸伺", num))
            {
                return PageOrientation.Portrait;
            }
        }
        return PageOrientation.Portrait;
    }

    internal static string smethod_19(PageOrientation A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case PageOrientation.Portrait:
                return BookmarkStart.b("弮帰䄲䄴䔶堸刺䤼", num);

            case PageOrientation.Landscape:
                return BookmarkStart.b("䌮倰崲儴䐶娸娺䴼娾", num);
        }
        return "";
    }

    internal static GridPitchType smethod_2(string A_0)
    {
        int num = 7;
        string str = A_0;
        if (str != null)
        {
            if ((str == BookmarkStart.b("䄬䘮弰嘲䘴瘶圸强縼圾⁀ㅂ㙄", num)) || (str == BookmarkStart.b("䄬䘮弰嘲䘴ᨶ堸唺夼ሾ≀⭂⑄㕆㩈", num)))
            {
                return GridPitchType.CharsAndLine;
            }
            if (str == BookmarkStart.b("䄬䘮弰嘲䘴", num))
            {
                return GridPitchType.LinesOnly;
            }
            if ((str == BookmarkStart.b("帬䄮倰䌲愴堶稸区尼䴾㉀", num)) || (str == BookmarkStart.b("帬䄮倰䌲ᠴ䌶嘸ᘺ帼圾⁀ㅂ㙄", num)))
            {
                return GridPitchType.SnapToChars;
            }
        }
        return GridPitchType.NoGrid;
    }

    internal static SectionBreakType smethod_20(string A_0)
    {
        int num = 0;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_18 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                dictionary1.Add(BookmarkStart.b("䔥䜧䐩堫䜭帯䜱嬳䌵䬷", num), 0);
                dictionary1.Add(BookmarkStart.b("䌥帧伩䈫縭儯唱儳", num), 1);
                dictionary1.Add(BookmarkStart.b("䌥帧伩䈫̭䀯匱匳匵", num), 2);
                dictionary1.Add(BookmarkStart.b("䠥䴧利堫洭弯帱䄳嬵嘷", num), 3);
                dictionary1.Add(BookmarkStart.b("䠥䴧利堫̭匯崱堳䌵唷吹", num), 4);
                dictionary1.Add(BookmarkStart.b("䠥䴧利堫縭儯唱儳", num), 5);
                dictionary1.Add(BookmarkStart.b("䠥䴧利堫̭䀯匱匳匵", num), 6);
                dictionary1.Add(BookmarkStart.b("䤥䰧丩簫伭圯圱", num), 7);
                dictionary1.Add(BookmarkStart.b("䤥䰧丩ī席儯唱儳", num), 8);
                Class1160.dictionary_18 = dictionary1;
            }
            if (Class1160.dictionary_18.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return SectionBreakType.NoBreak;

                    case 1:
                    case 2:
                        return SectionBreakType.EvenPage;

                    case 3:
                    case 4:
                        return SectionBreakType.NewColumn;

                    case 5:
                    case 6:
                        return SectionBreakType.NewPage;

                    case 7:
                    case 8:
                        return SectionBreakType.Oddpage;
                }
            }
        }
        return SectionBreakType.NewPage;
    }

    internal static string smethod_21(SectionBreakType A_0, bool A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case SectionBreakType.NoBreak:
                return BookmarkStart.b("䰮帰崲䄴帶圸为刼䨾㉀", num);

            case SectionBreakType.NewColumn:
                if (A_1)
                {
                    return BookmarkStart.b("䄮吰䬲䄴琶嘸场䠼刾⽀", num);
                }
                return BookmarkStart.b("䄮吰䬲䄴ᨶ娸吺儼䨾ⱀⵂ", num);

            case SectionBreakType.NewPage:
                if (A_1)
                {
                    return BookmarkStart.b("䄮吰䬲䄴朶堸尺堼", num);
                }
                return BookmarkStart.b("䄮吰䬲䄴ᨶ䤸娺娼娾", num);

            case SectionBreakType.EvenPage:
                if (A_1)
                {
                    return BookmarkStart.b("䨮䜰嘲嬴朶堸尺堼", num);
                }
                return BookmarkStart.b("䨮䜰嘲嬴ᨶ䤸娺娼娾", num);

            case SectionBreakType.Oddpage:
                if (A_1)
                {
                    return BookmarkStart.b("䀮唰圲攴嘶常帺", num);
                }
                return BookmarkStart.b("䀮唰圲ᠴ䜶堸尺堼", num);
        }
        return "";
    }

    internal static string smethod_3(GridPitchType A_0, bool A_1)
    {
        int num = 0x13;
        switch (A_0)
        {
            case GridPitchType.CharsAndLine:
                if (A_1)
                {
                    return BookmarkStart.b("唸刺匼娾㉀ɂ⭄⍆ੈ⍊ⱌ㵎≐", num);
                }
                return BookmarkStart.b("唸刺匼娾㉀湂⑄⥆ⵈ晊⹌❎ぐ⅒♔", num);

            case GridPitchType.LinesOnly:
                return BookmarkStart.b("唸刺匼娾㉀", num);

            case GridPitchType.SnapToChars:
                if (A_1)
                {
                    return BookmarkStart.b("䨸唺尼伾ᕀⱂل⽆⡈㥊㹌", num);
                }
                return BookmarkStart.b("䨸唺尼伾汀㝂⩄橆⩈⍊ⱌ㵎≐", num);
        }
        return "";
    }

    internal static HeaderFooterType smethod_4(string A_0, bool A_1)
    {
        int num = 6;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䤫堭唯就", num))
            {
                if (A_1)
                {
                    return HeaderFooterType.HeaderEven;
                }
                return HeaderFooterType.FooterEven;
            }
            if (str == BookmarkStart.b("䨫䜭䈯䄱䀳", num))
            {
                if (A_1)
                {
                    return HeaderFooterType.HeaderFirstPage;
                }
                return HeaderFooterType.FooterFirstPage;
            }
        }
        if (A_1)
        {
            return HeaderFooterType.HeaderOdd;
        }
        return HeaderFooterType.FooterOdd;
    }

    internal static string smethod_5(HeaderFooterType A_0, bool A_1)
    {
        int num = 3;
        switch (A_0)
        {
            case HeaderFooterType.HeaderEven:
            case HeaderFooterType.FooterEven:
                return BookmarkStart.b("䰨崪䠬䄮", num);

            case HeaderFooterType.HeaderOdd:
            case HeaderFooterType.FooterOdd:
                if (A_1)
                {
                    return BookmarkStart.b("䴨个䬬丮䐰弲䄴", num);
                }
                return BookmarkStart.b("䘨伪䤬", num);

            case HeaderFooterType.HeaderFirstPage:
            case HeaderFooterType.FooterFirstPage:
                return BookmarkStart.b("伨䈪弬尮䔰", num);
        }
        throw new InvalidOperationException(BookmarkStart.b("簨䔪䘬䄮帰䐲嬴᜶儸帺尼嬾⑀ㅂ敄ⅆ♈⑊㥌⩎⍐獒⅔⹖⥘㹚獜", num));
    }

    internal static FootnotePosition smethod_6(string A_0)
    {
        int num = 7;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_15 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                dictionary1.Add(BookmarkStart.b("帬䨮到䜲瀴夶崸", num), 0);
                dictionary1.Add(BookmarkStart.b("帬䨮到䜲ᠴ制圸强", num), 1);
                dictionary1.Add(BookmarkStart.b("崬丮嘰嘲眴堶䴸伺刼刾", num), 2);
                dictionary1.Add(BookmarkStart.b("崬丮嘰嘲ᠴ唶嘸伺䤼倾ⱀ", num), 3);
                dictionary1.Add(BookmarkStart.b("伬䨮弰嘲吴䌶儸漺堼䜾㕀", num), 4);
                dictionary1.Add(BookmarkStart.b("伬䨮弰嘲吴䌶儸ᘺ䤼娾㥀㝂", num), 5);
                dictionary1.Add(BookmarkStart.b("䤬䀮到瘲嬴匶", num), 6);
                dictionary1.Add(BookmarkStart.b("䤬䀮到Ḳ倴夶崸", num), 7);
                Class1160.dictionary_15 = dictionary1;
            }
            if (Class1160.dictionary_15.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return FootnotePosition.PrintAsEndOfSection;

                    case 2:
                    case 3:
                        return FootnotePosition.PrintAtBottomOfPage;

                    case 4:
                    case 5:
                        return FootnotePosition.PrintImmediatelyBeneathText;

                    case 6:
                    case 7:
                        return FootnotePosition.PrintAsEndOfDocument;
                }
            }
        }
        return FootnotePosition.PrintAsEndOfSection;
    }

    internal static string smethod_7(FootnotePosition A_0, bool A_1)
    {
        int num = 7;
        switch (A_0)
        {
            case FootnotePosition.PrintAsEndOfSection:
                if (A_1)
                {
                    return BookmarkStart.b("帬䨮到䜲瀴夶崸", num);
                }
                return BookmarkStart.b("帬䨮到䜲ᠴ制圸强", num);

            case FootnotePosition.PrintAtBottomOfPage:
                if (A_1)
                {
                    return BookmarkStart.b("崬丮嘰嘲眴堶䴸伺刼刾", num);
                }
                return BookmarkStart.b("崬丮嘰嘲ᠴ唶嘸伺䤼倾ⱀ", num);

            case FootnotePosition.PrintImmediatelyBeneathText:
                if (A_1)
                {
                    return BookmarkStart.b("伬䨮弰嘲吴䌶儸漺堼䜾㕀", num);
                }
                return BookmarkStart.b("伬䨮弰嘲吴䌶儸ᘺ䤼娾㥀㝂", num);

            case FootnotePosition.PrintAsEndOfDocument:
                if (A_1)
                {
                    return BookmarkStart.b("䤬䀮到瘲嬴匶", num);
                }
                return BookmarkStart.b("䤬䀮到Ḳ倴夶崸", num);
        }
        return "";
    }

    internal static PageAlignment smethod_8(string A_0)
    {
        int num = 13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䜲娴䜶", num))
            {
                return PageAlignment.Top;
            }
            if (str == BookmarkStart.b("倲倴夶䴸帺似", num))
            {
                return PageAlignment.Middle;
            }
            if (str == BookmarkStart.b("儲娴䌶儸", num))
            {
                return PageAlignment.Justified;
            }
            if (str == BookmarkStart.b("儲娴䌶䴸吺值", num))
            {
                return PageAlignment.Bottom;
            }
        }
        return PageAlignment.Top;
    }

    internal static string smethod_9(PageAlignment A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case PageAlignment.Top:
                return BookmarkStart.b("䀳夵䠷", num);

            case PageAlignment.Middle:
                return BookmarkStart.b("圳匵嘷丹夻䰽", num);

            case PageAlignment.Justified:
                return BookmarkStart.b("嘳夵䰷刹", num);

            case PageAlignment.Bottom:
                return BookmarkStart.b("嘳夵䰷丹医匽", num);
        }
        return "";
    }
}

