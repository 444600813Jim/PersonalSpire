using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Text.RegularExpressions;

internal class Class974
{
    private readonly Class422 class422_0;
    private readonly Class469 class469_0;
    private readonly Class526 class526_0;
    private readonly Class919 class919_0;
    private readonly Class971 class971_0;
    private const int int_0 = 1;
    private const int int_1 = 2;
    private const int int_10 = 11;
    private const int int_11 = 12;
    private const int int_12 = 13;
    private const int int_13 = 14;
    private const int int_14 = 15;
    private const int int_15 = 0x10;
    private const int int_16 = 0x11;
    private const int int_17 = 0x12;
    private const int int_18 = 0x13;
    private const int int_19 = 20;
    private const int int_2 = 3;
    private const int int_20 = 0x15;
    private const int int_21 = 0x16;
    private const int int_22 = 0x17;
    private const int int_23 = 0x18;
    private const int int_3 = 4;
    private const int int_4 = 5;
    private const int int_5 = 6;
    private const int int_6 = 7;
    private const int int_7 = 8;
    private const int int_8 = 9;
    private const int int_9 = 10;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("Ĩ䨪䀬.䄰帲䤴瘶琸ᐺ洼爾桀㽂浄⁆㕈ొ摌㍎祐⩒ⱔ⹖⁘❚ќٞ㡠㩢䱤᭦䅨ቪᑬ፮⡰⩲屴୶典㙺ぼ㉾첀ꪂ濾꾆쒈욊삌Ꚏ뮒\ud894\uda96나떜튞袠\udfa2\u8da4쎦춨쾪즬蚮춰鮲톴펶\uddb8\u92ba솼鞾ꗀꟂ믆꿊돎類믒뷔ﻖꗘ뗜鷠쯢귤꿦샨韪여꟮\ud8f0\u8ff2\uddf4\u9af6铸틺臼퟾氀⨂礄⼆稈砊焌導䈐㨒椔㼖樘朚东㘞崠ଢ怤戦氨渪Ь匮ᤰ瘲瀴Ḷ䔸ጺ爼䌾@㽂ቄ湆㕈捊ᙌᅎ㙐ᑒⱔ๖ᑘ㽚ᕜ㝞ౠၢ㙤٦ᥨ⩪㵬㉮孰婲", 3), RegexOptions.Singleline | RegexOptions.Compiled);

    internal Class974(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class469_0 = new Class469(this.class422_0);
        this.class919_0 = new Class919(this.class422_0);
        this.class526_0 = new Class526(this.class422_0);
        this.class971_0 = new Class971(this.class422_0);
    }

    internal void method_0()
    {
        int num = 6;
        Class400 class2 = this.class422_0.method_18();
        this.class422_0.method_8();
        this.class422_0.method_24(OpenDocumentWritingStage.ContentAutomaticStyles);
        class2.method_4(BookmarkStart.b("䌫䠭嘯嬱圳匵ȷ嬹䤻䨽⼿⽁╃㉅ⅇ⥉態㵍⑏⭑㡓㍕⭗", 6));
        for (Section section = (Section) this.class422_0.method_15().FirstChild; section != null; section = (Section) section.NextSibling)
        {
            this.class422_0.method_17(section);
            this.class422_0.method_16().Body.Accept(this.class422_0);
        }
        class2.method_6(BookmarkStart.b("䌫䠭嘯嬱圳匵ȷ嬹䤻䨽⼿⽁╃㉅ⅇ⥉態㵍⑏⭑㡓㍕⭗", num));
        this.class422_0.method_8();
    }

    internal void method_1(ShapeBase A_0, bool A_1)
    {
        int num = 4;
        if (A_1)
        {
            this.method_11(this.method_27(), BookmarkStart.b("帩䤫嘭䐯", num), smethod_2(A_0));
            this.class526_0.method_0(A_0, A_0.CharacterFormat);
        }
        else
        {
            this.method_11(this.method_26(), BookmarkStart.b("䴩師伭䀯娱崳唵", num), smethod_2(A_0));
            this.class469_0.method_0(A_0);
        }
        this.class422_0.method_18().method_6(BookmarkStart.b("天堫圭尯圱ำ䔵䰷䌹倻嬽", num));
    }

    internal void method_10(ListLevel A_0, ListStyle A_1, string A_2)
    {
        int num = 12;
        if (this.class526_0.method_3(null, A_0.CharacterFormat))
        {
            Style style = this.class422_0.method_15().Styles.method_13(A_1.ListStyleIstd, false);
            string str = ((style == null) || (style.StyleIdentifier == StyleIdentifier.NoList)) ? "" : Class922.smethod_77(style);
            this.method_11(A_2, BookmarkStart.b("䘱儳丵䰷", num), str);
            this.class526_0.method_2(false);
            this.class422_0.method_18().method_6(BookmarkStart.b("䄱䀳伵吷弹ػ䴽㐿㭁⡃⍅", num));
        }
    }

    private void method_11(string A_0, string A_1, string A_2)
    {
        int num = 3;
        string str = A_0;
        if (!this.class422_0.method_21())
        {
            int num2 = 0;
            while (this.class422_0.method_93().ContainsValue(string.Format(BookmarkStart.b("刨ᬪ倬吮0串", num), str, A_1)))
            {
                str = string.Format(BookmarkStart.b("刨ᬪ倬瀮䨰Ȳ䠴", num), A_0, num2++);
            }
            this.class422_0.method_93().Add(this.class422_0.method_93().Count, string.Format(BookmarkStart.b("刨ᬪ倬吮0串", num), str, A_1));
        }
        Class400 class2 = this.class422_0.method_18();
        class2.method_4(BookmarkStart.b("娨弪听䌮吰ल䘴䌶䀸场堼", num));
        class2.method_70(str);
        class2.method_40(BookmarkStart.b("娨弪听䌮吰ल匴嘶吸刺儼䘾", num), A_1);
        class2.method_40(BookmarkStart.b("娨弪听䌮吰ल䔴嘶䬸帺匼䬾汀あㅄ㹆╈⹊恌ⅎぐ㹒ご", num), Class576.smethod_88(A_2));
    }

    internal void method_12(string A_0, string A_1)
    {
        this.method_11(A_0, A_1, null);
    }

    internal void method_13(string A_0)
    {
        this.class422_0.method_18().method_4(BookmarkStart.b("䜳䈵䄷嘹夻н␿❁≃❅㵇♉㡋捍⍏♑ⵓ㩕㵗", 14));
        this.class422_0.method_18().method_40(BookmarkStart.b("䜳䈵䄷嘹夻н☿⍁⥃⽅⑇㍉", 14), A_0);
    }

    internal void method_14(string A_0, Field A_1)
    {
        int num = 0;
        if (Class567.smethod_16(A_0))
        {
            Class400 class2 = this.class422_0.method_18();
            class2.method_4(BookmarkStart.b("䠥崧䜩丫䬭䈯࠱倳圵䰷弹ᄻ䴽㐿㭁⡃⍅", num));
            class2.method_70(this.method_31());
            string[] strArray = ((LocaleIDs) A_1.CharacterFormat.LocaleIdASCII).ToString().Split(new char[] { '_' });
            class2.method_18(BookmarkStart.b("䠥崧䜩丫䬭䈯࠱堳圵嘷崹䤻弽✿❁", num), strArray[0].ToLower());
            class2.method_18(BookmarkStart.b("䠥崧䜩丫䬭䈯࠱圳夵䴷吹䠻䰽㤿", num), strArray[1].ToUpper());
            foreach (Match match in regex_0.Matches(A_0))
            {
                this.method_15(match);
                this.method_16(match);
                this.method_17(match);
                this.method_18(match);
                this.method_21(match);
                this.method_22(match);
                this.method_23(match);
                this.method_19(match);
                bool flag = this.method_20(match);
                if (Class567.smethod_16(match.Groups[1].Value))
                {
                    class2.method_10(BookmarkStart.b("䠥崧䜩丫䬭䈯࠱唳嬵ᔷ䨹儻", num));
                }
                string str = match.Groups[0x18].Value.Trim(new char[] { '\'' });
                if (Class567.smethod_16(str) && flag)
                {
                    class2.method_11(BookmarkStart.b("䠥崧䜩丫䬭䈯࠱䀳匵䀷丹", num), str);
                }
            }
            class2.method_6(BookmarkStart.b("䠥崧䜩丫䬭䈯࠱倳圵䰷弹ᄻ䴽㐿㭁⡃⍅", num));
        }
    }

    private void method_15(Match A_0)
    {
        int num = 4;
        if (Class567.smethod_16(A_0.Groups[2].Value))
        {
            this.class422_0.method_18().method_10(BookmarkStart.b("䐩夫䌭刯圱䘳వ崷䠹崻", num));
        }
    }

    private void method_16(Match A_0)
    {
        this.method_24(BookmarkStart.b("嬴䈶吸夺堼䴾筀㩂⁄♆㭈", 15), Class567.smethod_16(A_0.Groups[4].Value), Class567.smethod_16(A_0.Groups[3].Value));
    }

    private void method_17(Match A_0)
    {
        this.method_25(BookmarkStart.b("堵䴷圹帻嬽㈿硁⥃⥅♇㹉⑋", 0x10), Class567.smethod_16(A_0.Groups[8].Value) || Class567.smethod_16(A_0.Groups[6].Value), Class567.smethod_16(A_0.Groups[7].Value) || Class567.smethod_16(A_0.Groups[5].Value), Class567.smethod_16(A_0.Groups[6].Value) || Class567.smethod_16(A_0.Groups[5].Value));
    }

    private void method_18(Match A_0)
    {
        this.method_24(BookmarkStart.b("帯䜱夳吵崷䠹ػ娽ℿ㭁", 10), Class567.smethod_16(A_0.Groups[12].Value), Class567.smethod_16(A_0.Groups[11].Value));
    }

    private void method_19(Match A_0)
    {
        this.method_24(BookmarkStart.b("䘧弩䄫䰭唯䀱ำ刵夷䌹ᄻ儽☿潁㍃⍅ⵇⅉ", 2), Class567.smethod_16(A_0.Groups[10].Value), Class567.smethod_16(A_0.Groups[9].Value));
    }

    internal void method_2(ParagraphBase A_0)
    {
        int num = 13;
        string str = null;
        if ((A_0.GetType().Name != BookmarkStart.b("笲䰴䜶尸䤺儼嘾⽀⡂", 13)) || !this.class422_0.method_101())
        {
            str = smethod_2(A_0);
        }
        this.method_11(this.method_27(), BookmarkStart.b("䜲倴伶䴸", num), str);
        this.class526_0.method_0(A_0, A_0.CharacterFormat);
        this.class422_0.method_18().method_6(BookmarkStart.b("䀲䄴丶唸帺ܼ䰾㕀㩂⥄≆", num));
    }

    private bool method_20(Match A_0)
    {
        int num = 11;
        Class400 class2 = this.class422_0.method_18();
        string str = A_0.ToString();
        if (str.IndexOf('O') > 0)
        {
            string[] strArray = str.Replace(BookmarkStart.b("ᘰ", num), "").Split(new char[] { 'O' });
            for (int j = 0; j < strArray.Length; j++)
            {
                if (strArray[j].Length > 0)
                {
                    if (j != (strArray.Length - 1))
                    {
                        class2.method_11(BookmarkStart.b("弰䘲場唶尸䤺ܼ䬾⑀㭂ㅄ", num), strArray[j]);
                        class2.method_4(BookmarkStart.b("弰䘲場唶尸䤺ܼ刾⹀ⵂㅄ⽆", num));
                        class2.method_18(BookmarkStart.b("弰䘲場唶尸䤺ܼ尾⁀⽂⁄⥆ⵈ⩊㽌", num), BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀", num));
                        class2.method_5();
                    }
                    else
                    {
                        class2.method_11(BookmarkStart.b("弰䘲場唶尸䤺ܼ䬾⑀㭂ㅄ", num), strArray[j]);
                    }
                }
            }
            return false;
        }
        if (str == BookmarkStart.b("瀰", num))
        {
            class2.method_4(BookmarkStart.b("弰䘲場唶尸䤺ܼ嬾⁀㩂", num));
            class2.method_18(BookmarkStart.b("弰䘲場唶尸䤺ܼ尾⁀⽂⁄⥆ⵈ⩊㽌", num), BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀", num));
            class2.method_5();
        }
        if ((str == BookmarkStart.b("琰瘲", num)) || (str == BookmarkStart.b("琰瘲瀴父", num)))
        {
            class2.method_4(BookmarkStart.b("弰䘲場唶尸䤺ܼ䘾⑀≂㝄", num));
            class2.method_18(BookmarkStart.b("弰䘲場唶尸䤺ܼ尾⁀⽂⁄⥆ⵈ⩊㽌", num), BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀", num));
            if (str.Length == 4)
            {
                class2.method_18(BookmarkStart.b("弰䘲場唶尸䤺ܼ䰾㕀㩂⥄≆", num), BookmarkStart.b("崰尲嬴倶", num));
            }
            class2.method_5();
        }
        if (str.IndexOf('W') <= 0)
        {
            return true;
        }
        string[] strArray2 = str.Replace(BookmarkStart.b("ᘰ", num), "").Split(new char[] { 'W' });
        for (int i = 0; i < strArray2.Length; i++)
        {
            if (strArray2[i].Length > 0)
            {
                if (i != (strArray2.Length - 1))
                {
                    class2.method_11(BookmarkStart.b("弰䘲場唶尸䤺ܼ䬾⑀㭂ㅄ", num), strArray2[i]);
                    class2.method_4(BookmarkStart.b("弰䘲場唶尸䤺ܼ嬾⁀㩂桄⡆⽈晊㩌⩎㑐㡒", num));
                    class2.method_18(BookmarkStart.b("弰䘲場唶尸䤺ܼ尾⁀⽂⁄⥆ⵈ⩊㽌", num), BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀", num));
                    class2.method_5();
                }
                else
                {
                    class2.method_11(BookmarkStart.b("弰䘲場唶尸䤺ܼ䬾⑀㭂ㅄ", num), strArray2[i]);
                }
            }
        }
        return false;
    }

    private void method_21(Match A_0)
    {
        this.method_24(BookmarkStart.b("帯䜱夳吵崷䠹ػ嘽⼿㝁㙃㕅", 10), Class567.smethod_16(A_0.Groups[14].Value) || Class567.smethod_16(A_0.Groups[0x10].Value), Class567.smethod_16(A_0.Groups[13].Value) || Class567.smethod_16(A_0.Groups[15].Value));
    }

    private void method_22(Match A_0)
    {
        this.method_24(BookmarkStart.b("䔪堬䈮匰嘲䜴ശ吸刺匼䨾㕀♂㙄", 5), Class567.smethod_16(A_0.Groups[0x12].Value), Class567.smethod_16(A_0.Groups[0x11].Value));
    }

    private void method_23(Match A_0)
    {
        this.method_24(BookmarkStart.b("帯䜱夳吵崷䠹ػ䴽┿⅁⭃⡅ⱇ㥉", 10), Class567.smethod_16(A_0.Groups[20].Value), Class567.smethod_16(A_0.Groups[0x13].Value));
    }

    private void method_24(string A_0, bool A_1, bool A_2)
    {
        this.method_25(A_0, A_1, A_2, false);
    }

    private void method_25(string A_0, bool A_1, bool A_2, bool A_3)
    {
        int num = 3;
        if (A_1 || A_2)
        {
            Class400 class2 = this.class422_0.method_18();
            class2.method_4(A_0);
            if (A_2)
            {
                class2.method_40(BookmarkStart.b("䜨帪䀬䴮吰䄲༴䐶䴸䈺儼娾", num), BookmarkStart.b("䔨䐪䌬䠮", num));
            }
            if (A_3)
            {
                class2.method_40(BookmarkStart.b("䜨帪䀬䴮吰䄲༴䌶尸䌺䤼䨾⁀⽂", num), BookmarkStart.b("崨太堬䨮", num));
            }
            class2.method_6(A_0);
        }
    }

    internal string method_26()
    {
        this.class422_0.method_30(this.class422_0.method_29() + 1);
        return string.Format(BookmarkStart.b("樫簭䬯ȱ䤳", 6), this.class422_0.method_29());
    }

    internal string method_27()
    {
        this.class422_0.method_38(this.class422_0.method_37() + 1);
        return string.Format(BookmarkStart.b("笮䨰̲䠴栶䈸਺䀼", 9), this.class422_0.method_33(), this.class422_0.method_37());
    }

    internal string method_28()
    {
        this.class422_0.method_34(this.class422_0.method_33() + 1);
        return string.Format(BookmarkStart.b("縭䬯ȱ䤳", 8), this.class422_0.method_33());
    }

    internal string method_29()
    {
        this.class422_0.method_106(this.class422_0.method_105() + 1);
        return string.Format(BookmarkStart.b("挮戰䠲Դ䨶", 9), this.class422_0.method_105());
    }

    internal void method_3(Comment A_0)
    {
        this.method_11(this.method_27(), BookmarkStart.b("䴸帺䔼䬾", 0x13), smethod_2(A_0.OwnerParagraph));
        this.class526_0.method_0(A_0.OwnerParagraph, A_0.CharacterFormat);
        this.class422_0.method_18().method_6(BookmarkStart.b("䨸伺䐼匾⑀祂㙄㍆え❊⡌", 0x13));
    }

    internal string method_30()
    {
        return string.Format(BookmarkStart.b("簮䨰̲䠴", 9), this.class422_0.method_15().Sections.IndexOf(this.class422_0.method_16()) + 1);
    }

    internal string method_31()
    {
        this.class422_0.method_50(this.class422_0.method_49() + 1);
        return string.Format(BookmarkStart.b("欮攰䠲Դ䨶", 9), this.class422_0.method_49());
    }

    internal void method_4(Footnote A_0)
    {
        this.method_11(this.method_27(), BookmarkStart.b("䄴制䄸伺", 15), smethod_2(A_0));
        this.class526_0.method_0(A_0, A_0.CharacterFormat);
        this.class422_0.method_18().method_6(BookmarkStart.b("䘴䌶䀸场堼Ծ㉀㝂㱄⭆ⱈ", 15));
    }

    internal void method_5(Style A_0)
    {
        int num = 12;
        if (A_0.StyleType != StyleType.TableStyle)
        {
            string str = Class922.smethod_77(A_0);
            if (Class567.smethod_16(str))
            {
                this.method_11(str, Class922.smethod_76(A_0.StyleType), smethod_2(A_0));
                if (A_0.StyleType != StyleType.CharacterStyle)
                {
                    this.class422_0.method_18().method_43(BookmarkStart.b("䄱䀳伵吷弹ػ娽┿⑁╃㍅⑇㹉態⅍╏♑㡓㽕㙗㽙煛㉝՟ᑡţ੥", num), ((int) A_0.ParaPr.OutlineLevel) + 1);
                    this.class919_0.method_0(A_0, A_0.ParaPr);
                }
                this.class526_0.method_0(A_0, A_0.RunPr);
                this.class422_0.method_18().method_6(BookmarkStart.b("䄱䀳伵吷弹ػ䴽㐿㭁⡃⍅", num));
            }
        }
    }

    private void method_6(Paragraph A_0)
    {
        int num = 10;
        this.class422_0.method_38(0);
        this.class422_0.method_36(0);
        string str = this.method_28();
        this.method_11(str, BookmarkStart.b("䀯匱䘳圵強䠹崻丽⠿", 10), smethod_2(A_0));
        this.method_7((this.class422_0.method_33() == 1) && (A_0.method_49().PreviousSibling == null), false);
        this.class919_0.method_0(A_0, A_0.Format);
        this.class526_0.method_0(A_0, A_0.BreakCharacterFormat);
        this.class422_0.method_18().method_6(BookmarkStart.b("䌯䘱䴳娵崷9伻䨽㤿⹁⅃", num));
    }

    internal void method_7(bool A_0, bool A_1)
    {
        int num = 0;
        if (this.class422_0.method_75() || A_0)
        {
            string str = smethod_0(this.class422_0, this.class422_0.method_16());
            if ((str == null) && (!A_1 || A_0))
            {
                str = BookmarkStart.b("甥尧䬩䈫䨭儯䀱倳", num);
            }
            this.class422_0.method_18().method_40(BookmarkStart.b("唥尧匩䀫䬭ਯ弱唳䔵䰷弹主ጽ〿⍁⍃⍅敇⑉ⵋ⍍㕏", num), str);
            this.class422_0.method_76(false);
        }
    }

    internal void method_8(Paragraph A_0, bool A_1, bool A_2)
    {
        this.class919_0.method_15(A_1);
        this.class919_0.method_13(A_2);
        this.method_6(A_0);
        this.class919_0.method_15(false);
        this.class919_0.method_13(false);
    }

    internal void method_9(Section A_0)
    {
        int num = 0x13;
        this.method_11(this.method_30(), BookmarkStart.b("䨸帺帼䬾⡀ⱂ⭄", 0x13), null);
        if (A_0.BreakCode == SectionBreakType.NewPage)
        {
            this.class422_0.method_18().method_40(BookmarkStart.b("䨸伺䐼匾⑀祂⡄♆㩈㽊⡌㵎籐⍒㑔ざ㱘癚㍜㹞ౠ٢", num), smethod_0(this.class422_0, this.class422_0.method_16()));
        }
        this.class971_0.method_0(A_0);
        this.class422_0.method_18().method_6(BookmarkStart.b("䨸伺䐼匾⑀祂㙄㍆え❊⡌", num));
    }

    internal static string smethod_0(Class422 A_0, Section A_1)
    {
        int num = 9;
        int index = A_0.method_15().Sections.IndexOf(A_1);
        if (index != 0)
        {
            return string.Format(BookmarkStart.b("戮倰䀲䄴制䬸欺尼堾⑀㡂畄㩆", num), index);
        }
        if ((A_0.method_23() != OpenDocumentWritingStage.ContentAutomaticStyles) && (A_0.method_23() != OpenDocumentWritingStage.StylesAutomaticStyles))
        {
            return BookmarkStart.b("簮䔰刲嬴匶堸䤺夼", num);
        }
        return null;
    }

    private static Style smethod_1(IRunAttrSource A_0)
    {
        if (A_0 is Style)
        {
            return (Style) A_0;
        }
        if (A_0 is Paragraph)
        {
            return ((Paragraph) A_0).ParaStyle;
        }
        if (A_0 is Footnote)
        {
            return ((Footnote) A_0).OwnerParagraph.ParaStyle;
        }
        if (!(A_0 is ShapeObject) && !(A_0 is ShapeGroup))
        {
            ParagraphBase base2 = (ParagraphBase) A_0;
            Style charStyle = base2.CharacterFormat.CharStyle;
            if ((charStyle != null) && (charStyle.StyleIdentifier != StyleIdentifier.DefaultParagraphFont))
            {
                return charStyle;
            }
            return null;
        }
        Paragraph parentObject = ((ShapeBase) A_0).ParentObject as Paragraph;
        if (((ShapeBase) A_0).ParentObject is ShapeGroup)
        {
            parentObject = (((ShapeBase) A_0).ParentObject as ShapeGroup).ParentParagraph;
        }
        if (parentObject == null)
        {
            return null;
        }
        return parentObject.ParaStyle;
    }

    private static string smethod_2(IRunAttrSource A_0)
    {
        Style style = smethod_1(A_0);
        if (style != null)
        {
            if (!(A_0 is Style))
            {
                return Class922.smethod_77(style);
            }
            Style baseStyle = style.BaseStyle as Style;
            if (baseStyle != null)
            {
                return Class922.smethod_77(baseStyle);
            }
        }
        return null;
    }
}

