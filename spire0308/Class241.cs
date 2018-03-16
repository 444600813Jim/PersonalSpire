using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using System;

internal class Class241
{
    private static bool bool_0;
    private static bool bool_1;
    private static bool bool_2;
    private readonly Class422 class422_0;
    private readonly Class469 class469_0;
    private readonly Class691 class691_0;
    private readonly Class974 class974_0;
    private static string string_0;
    private static string string_1;
    private static string string_2;
    private static string string_3;

    internal Class241(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class974_0 = new Class974(this.class422_0);
        this.class469_0 = new Class469(this.class422_0);
        this.class691_0 = new Class691(this.class422_0);
        bool_1 = true;
    }

    internal VisitorAction method_0(Field A_0)
    {
        int num = 0x13;
        FieldType type = A_0.Type;
        Class44 class2 = A_0.Range;
        TextRange range = null;
        DocPicture picture = null;
        foreach (DocumentObject obj2 in class2)
        {
            if (obj2 is ParagraphBase)
            {
                (obj2 as ParagraphBase).SkipDocxItem = true;
            }
            if (obj2 is TextRange)
            {
                range = obj2 as TextRange;
            }
            if (obj2 is DocPicture)
            {
                picture = obj2 as DocPicture;
            }
        }
        if (((range != null) && (type == FieldType.FieldHyperlink)) && (this.class422_0.method_23() == OpenDocumentWritingStage.ContentAutomaticStyles))
        {
            this.class422_0.vmethod_16(range);
        }
        if (((picture != null) && (type == FieldType.FieldHyperlink)) && (this.class422_0.method_23() == OpenDocumentWritingStage.ContentAutomaticStyles))
        {
            this.class422_0.vmethod_34(picture);
        }
        if ((range != null) && (type != FieldType.FieldHyperlink))
        {
            this.class422_0.vmethod_16(range);
        }
        Class400 class3 = this.class422_0.method_18();
        Class974 class4 = new Class974(this.class422_0);
        if (this.class422_0.method_21())
        {
            switch (type)
            {
                case FieldType.FieldCreateDate:
                case FieldType.FieldSaveDate:
                case FieldType.FieldPrintDate:
                case FieldType.FieldDate:
                {
                    string str2 = smethod_1(A_0.FormattingString);
                    class4.method_14(str2, A_0);
                    break;
                }
            }
        }
        else if ((this.class422_0.method_23() == OpenDocumentWritingStage.ContentBody) || this.class422_0.method_22())
        {
            switch (type)
            {
                case FieldType.FieldTitle:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀㝂ⱄ㍆╈⹊", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldSubject:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀あい╆⍈⹊⹌㭎", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldAuthor:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀⩂⭄⹆㵈≊ⱌ⍎籐げ❔㉖㡘⽚㉜ⵞ", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldKeyWord:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀⡂⁄㹆㹈⑊㽌⭎≐", num));
                    class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⭄㉆⑈晊⭌⁎⍐㹒㑔⍖", num), Class576.smethod_18(smethod_0(A_0.method_177()).Replace(BookmarkStart.b("爸縺搼栾เᅂńᑆ", num), "").Replace(BookmarkStart.b("攸ᄺ", num), "").Trim()));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldLastSavedBy:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀⁂㝄≆⡈㽊≌㵎", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldCreateDate:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀⁂㝄≆⡈㽊⑌⁎㽐繒ㅔ㙖ⵘ㹚", num));
                    if (smethod_1(A_0.FormattingString) != "")
                    {
                        class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⅄♆㵈⩊恌㱎═⩒㥔㉖瑘㕚㱜㉞Ѡ", num), class4.method_31());
                    }
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldSaveDate:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀⹂⩄⍆⁈ⵊ⑌ⱎぐ❒㱔㡖㝘癚㥜㹞ᕠ٢", num));
                    if (smethod_1(A_0.FormattingString) != "")
                    {
                        class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⅄♆㵈⩊恌㱎═⩒㥔㉖瑘㕚㱜㉞Ѡ", num), class4.method_31());
                    }
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldPrintDate:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀㍂㝄⹆❈㽊恌⭎ぐ❒ご", num));
                    if (smethod_1(A_0.FormattingString) != "")
                    {
                        class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⅄♆㵈⩊恌㱎═⩒㥔㉖瑘㕚㱜㉞Ѡ", num), class4.method_31());
                    }
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldRevisionNum:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀♂⅄⹆㵈≊⍌⡎籐げⱔ㑖㕘㹚⹜", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldEditTime:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀♂⅄⹆㵈≊⍌⡎籐㝒⁔╖㡘⽚㑜ぞའ", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldNumPages:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀㍂⑄⁆ⱈ晊⹌⁎⑐㵒⅔", num));
                    class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⭄㉆⑈晊⭌⁎⍐㹒㑔⍖", num), Class576.smethod_18(smethod_0(A_0.method_177()).Replace(BookmarkStart.b("眸渺瀼漾@тDᑆ", num), "").Replace(BookmarkStart.b("攸ᄺ", num), "").Trim()));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldNumWords:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀㑂⩄㕆ⵈ晊⹌⁎⑐㵒⅔", num));
                    class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⭄㉆⑈晊⭌⁎⍐㹒㑔⍖", num), Class576.smethod_18(smethod_0(A_0.method_177()).Replace(BookmarkStart.b("眸渺瀼栾เᅂńᑆ", num), "").Replace(BookmarkStart.b("攸ᄺ", num), "").Trim()));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldFileName:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ⭆ⱈ晊⍌⹎㱐㙒", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (A_0.method_177().Trim().ToLower().EndsWith(BookmarkStart.b("攸䬺", num)))
                    {
                        class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀❂ⱄ㑆㥈❊ⱌ㙎", num), BookmarkStart.b("弸为儼匾", num));
                    }
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldTemplate:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀㝂⁄⩆㥈❊ⱌ㭎㑐繒㭔㙖㑘㹚", num));
                    if (A_0.method_177().Trim().ToLower().EndsWith(BookmarkStart.b("攸䬺", num)))
                    {
                        class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀❂ⱄ㑆㥈❊ⱌ㙎", num), BookmarkStart.b("弸为儼匾", num));
                    }
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldDate:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀❂⑄㍆ⱈ", num));
                    if (smethod_1(A_0.FormattingString) != "")
                    {
                        class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⅄♆㵈⩊恌㱎═⩒㥔㉖瑘㕚㱜㉞Ѡ", num), class4.method_31());
                    }
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldPage:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀㍂⑄⁆ⱈ晊⍌㩎㱐ㅒご╖", num));
                    class3.method_18(BookmarkStart.b("䨸伺䐼匾⑀祂⭄㉆⑈晊⭌⁎⍐㹒㑔⍖", num), Class576.smethod_18(smethod_0(A_0.method_177()).Replace(BookmarkStart.b("椸稺稼稾", num), "").Replace(BookmarkStart.b("攸ᄺ", num), "").Trim()));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀╂ⱄ㽆ⱈ⽊", num), BookmarkStart.b("弸娺儼䰾⑀", num));
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldMergeField:
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀❂⑄㍆⡈⥊ⱌ㱎㑐繒ㅔ㹖⩘⭚ㅜ㹞ᡠ", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀㝂⑄╆╈⹊恌ⅎぐ㹒ご", num), "");
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀㝂⑄╆╈⹊恌㭎⡐⍒ご", num), BookmarkStart.b("䴸娺弼匾⑀", num));
                    class3.method_18(BookmarkStart.b("䴸帺䔼䬾筀⁂⩄⭆㱈♊⍌扎㽐㉒㡔㉖", num), smethod_0(A_0.method_177()).Replace(BookmarkStart.b("琸縺漼砾рՂౄɆՈཊ", num), "").Trim());
                    class3.method_15(A_0.Text);
                    this.class422_0.method_18().method_5();
                    break;

                case FieldType.FieldHyperlink:
                    string str;
                    class3.method_4(BookmarkStart.b("䴸帺䔼䬾筀≂", num));
                    if ((A_0.Code == "") && (A_0.Value != null))
                    {
                        str = string.Format(BookmarkStart.b("ᨸ䀺഼䈾", num), A_0.Value);
                    }
                    else
                    {
                        str = smethod_0(A_0.method_177()).Replace(BookmarkStart.b("焸戺洼稾ፀགౄॆɈ", num), "").Trim();
                    }
                    class3.method_18(BookmarkStart.b("䄸场吼儾⩀祂ⵄ㕆ⱈⵊ", num), str.Replace(BookmarkStart.b("ᬸ", num), ""));
                    class3.method_18(BookmarkStart.b("嘸崺嬼嘾≀♂罄㍆⡈㥊⩌⩎═繒㍔╖㡘㙚㡜牞འɢࡤɦ", num), BookmarkStart.b("昸伺刼伾", num));
                    class3.method_18(BookmarkStart.b("䄸场吼儾⩀祂㙄⽆♈㱊", num), BookmarkStart.b("䬸帺䴼匾⁀⁂⁄", num));
                    if (range != null)
                    {
                        range.SkipDocxItem = false;
                        this.class422_0.vmethod_16(range);
                        range.SkipDocxItem = true;
                    }
                    if (picture != null)
                    {
                        picture.SkipDocxItem = false;
                        this.class422_0.vmethod_34(picture);
                        this.class422_0.vmethod_35(picture);
                        picture.SkipDocxItem = true;
                    }
                    class3.method_15(A_0.Text);
                    this.class422_0.method_18().method_5();
                    break;

                default:
                    if (range != null)
                    {
                        class3.method_15(range.Text);
                    }
                    break;
            }
            if (((range != null) && (range.Text.Length > 0)) && (type != FieldType.FieldHyperlink))
            {
                this.class422_0.method_18().method_67(BookmarkStart.b("䴸帺䔼䬾筀あ㕄♆❈", num));
            }
        }
        return VisitorAction.Continue;
    }

    private void method_1()
    {
        int num = 13;
        Class400 class2 = this.class422_0.method_18();
        string[] strArray = string_0.Replace(BookmarkStart.b("欲瀴", 13), "").Replace(BookmarkStart.b("ᄲ", 13), "").Trim(new char[] { ' ' }).Split(new char[] { ':' });
        class2.method_4(BookmarkStart.b("䜲倴伶䴸ĺ尼匾ㅀ⭂⑄╆ⱈ㽊⑌ⱎぐ㽒硔㹖㝘㽚㡜❞䱠๢Ѥᕦɨ", 13));
        if (strArray.Length > 0)
        {
            if (strArray.Length == 1)
            {
                class2.method_40(BookmarkStart.b("䜲倴伶䴸ĺ丼䬾㍀⩂⭄⁆摈㵊ⱌ⍎⑐㙒", num), strArray[0]);
            }
            else
            {
                class2.method_40(BookmarkStart.b("䜲倴伶䴸ĺ嘼娾㡀牂", num), strArray[0]);
            }
            if (strArray.Length > 1)
            {
                if (strArray.Length == 2)
                {
                    class2.method_40(BookmarkStart.b("䜲倴伶䴸ĺ丼䬾㍀⩂⭄⁆摈㵊ⱌ⍎⑐㙒", num), strArray[1]);
                }
                else
                {
                    class2.method_40(BookmarkStart.b("䜲倴伶䴸ĺ嘼娾㡀煂", num), strArray[1]);
                }
                if (strArray.Length > 2)
                {
                    string str = strArray[2];
                    for (int i = 3; i < strArray.Length; i++)
                    {
                        str = string.Format(BookmarkStart.b("䠲Դ䨶̸䀺఼䈾", num), str, strArray[i]);
                    }
                    class2.method_40(BookmarkStart.b("䜲倴伶䴸ĺ丼䬾㍀⩂⭄⁆摈㵊ⱌ⍎⑐㙒", num), str);
                }
            }
        }
        class2.method_6(BookmarkStart.b("䜲倴伶䴸ĺ尼匾ㅀ⭂⑄╆ⱈ㽊⑌ⱎぐ㽒硔㹖㝘㽚㡜❞䱠๢Ѥᕦɨ", num));
    }

    private void method_10()
    {
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(BookmarkStart.b("䄴制䄸伺ܼ嬾⁀㝂⑄╆⡈㡊⡌扎⍐㱒≔穖㝘⹚ぜ㵞Ѡᅢ", 15));
        this.method_11();
        class2.method_67(BookmarkStart.b("䄴制䄸伺ܼ嬾⁀㝂⑄╆⡈㡊⡌扎⍐㱒≔穖㝘⹚ぜ㵞Ѡᅢ", 15));
    }

    private void method_11()
    {
        int num = 0x12;
        Class400 class2 = this.class422_0.method_18();
        if (!this.class422_0.method_63() && !this.class422_0.method_65())
        {
            class2.method_68(BookmarkStart.b("䰷弹䐻䨽稿♁╃㉅⥇⡉ⵋ㵍㕏网㩓㝕㕗㽙", num), "");
        }
        class2.method_68(BookmarkStart.b("䰷弹䐻䨽稿㙁╃⑅⑇⽉態⁍ㅏ㽑ㅓ", num), "");
        class2.method_69(BookmarkStart.b("䰷弹䐻䨽稿㙁╃⑅⑇⽉態㩍⥏≑ㅓ", num), BookmarkStart.b("䰷嬹帻刽┿", num));
    }

    private bool method_12(FieldType A_0)
    {
        if ((((A_0 != FieldType.FieldHyperlink) || !this.class422_0.method_101()) && ((A_0 != FieldType.FieldFormDropDown) || !this.class422_0.method_14().method_13())) && (((((((A_0 != FieldType.FieldHTMLActiveX) && (A_0 != FieldType.FieldCannotParse)) && ((A_0 != FieldType.FieldNone) && (A_0 != FieldType.FieldFillIn))) && (((A_0 != FieldType.FieldCitation) && (A_0 != FieldType.FieldGlossary)) && ((A_0 != FieldType.FieldGoToButton) && (A_0 != FieldType.FieldIncludeText)))) && ((((A_0 != FieldType.FieldIndex) && (A_0 != FieldType.FieldInfo)) && ((A_0 != FieldType.FieldLink) && (A_0 != FieldType.FieldListNum))) && (((A_0 != FieldType.FieldMacroButton) && (A_0 != FieldType.FieldMergeRec)) && ((A_0 != FieldType.FieldMergeSeq) && (A_0 != FieldType.FieldNext))))) && (((((A_0 != FieldType.FieldNextIf) && (A_0 != FieldType.FieldNoteRef)) && ((A_0 != FieldType.FieldNumChars) && (A_0 != FieldType.FieldPrint))) && (((A_0 != FieldType.FieldPrivate) && (A_0 != FieldType.FieldQuote)) && ((A_0 != FieldType.FieldRefNoKeyword) && (A_0 != FieldType.FieldRefDoc)))) && ((((A_0 != FieldType.FieldSkipIf) && (A_0 != FieldType.FieldStyleRef)) && ((A_0 != FieldType.FieldSymbol) && (A_0 != FieldType.FieldTOA))) && (((A_0 != FieldType.FieldTOAEntry) && (A_0 != FieldType.FieldTOC)) && ((A_0 != FieldType.FieldUserAddress) && (A_0 != FieldType.FieldUserInitials)))))) && ((((((A_0 != FieldType.FieldBarCode) && (A_0 != FieldType.FieldBidiOutline)) && ((A_0 != FieldType.FieldCompare) && (A_0 != FieldType.FieldDocVariable))) && (((A_0 != FieldType.FieldFileSize) && (A_0 != FieldType.FieldAutoNum)) && ((A_0 != FieldType.FieldAutoNumLegal) && (A_0 != FieldType.FieldAutoNumOutline)))) && ((((A_0 != FieldType.FieldAutoText) && (A_0 != FieldType.FieldAutoTextList)) && ((A_0 != FieldType.FieldAsk) && (A_0 != FieldType.FieldFormula))) && (((A_0 != FieldType.FieldAddressBlock) && (A_0 != FieldType.FieldPrivate)) && ((A_0 != FieldType.FieldIf) && (A_0 != FieldType.FieldDDE))))) && ((((A_0 != FieldType.FieldRef) && (A_0 != FieldType.FieldPageRef)) && ((A_0 != FieldType.FieldSection) && (A_0 != FieldType.FieldSectionPages))) && ((A_0 != FieldType.FieldIndexEntry) && ((A_0 != FieldType.FieldAdvance) || smethod_5()))))))
        {
            return (A_0 == FieldType.FieldTOCEntry);
        }
        return true;
    }

    private bool method_13(FieldType A_0)
    {
        if (((((!this.method_12(A_0) && (A_0 != FieldType.FieldAdvance)) && ((A_0 != FieldType.FieldMergeField) && (A_0 != FieldType.FieldNumWords))) && (((A_0 != FieldType.FieldRevisionNum) && (A_0 != FieldType.FieldEditTime)) && ((A_0 != FieldType.FieldKeyWord) && (A_0 != FieldType.FieldSubject)))) && ((((A_0 != FieldType.FieldComments) && (A_0 != FieldType.FieldTemplate)) && ((A_0 != FieldType.FieldFormTextInput) && (A_0 != FieldType.FieldFormDropDown))) && (((A_0 != FieldType.FieldFormCheckBox) && (A_0 != FieldType.FieldSet)) && ((A_0 != FieldType.FieldFileName) && (A_0 != FieldType.FieldUserInitials))))) && (((((A_0 != FieldType.FieldUserName) && (A_0 != FieldType.FieldTitle)) && ((A_0 != FieldType.FieldAuthor) && (A_0 != FieldType.FieldLastSavedBy))) && (((A_0 != FieldType.FieldPrintDate) && (A_0 != FieldType.FieldDate)) && ((A_0 != FieldType.FieldTime) && (A_0 != FieldType.FieldSaveDate)))) && (((A_0 != FieldType.FieldCreateDate) && (A_0 != FieldType.FieldDocProperty)) && (A_0 != FieldType.FieldPage))))
        {
            return (A_0 == FieldType.FieldNumPages);
        }
        return true;
    }

    private void method_14()
    {
        Class400 class2 = this.class422_0.method_18();
        string str = Class576.smethod_13(string_0);
        this.class691_0.method_1();
        class2.method_66(BookmarkStart.b("尧伩含娭ਯ䐱唳䐵儷嬹帻刽┿潁㝃⍅㱇", 2));
        class2.method_68(BookmarkStart.b("尧伩含娭ਯ就唳嬵崷", 2), str);
        class2.method_69(BookmarkStart.b("䜧䰩䨫䜭匯圱ำ䀵夷嘹䤻嬽洿㙁㵃㙅ⵇ", 2), BookmarkStart.b("嬧帩師䜭帯唱", 2));
        class2.method_15(Class576.smethod_14(string_0, str));
        class2.method_67(BookmarkStart.b("尧伩含娭ਯ䐱唳䐵儷嬹帻刽┿潁㝃⍅㱇", 2));
        this.class691_0.method_2();
        string_3 = str;
    }

    private void method_15(FormField A_0)
    {
        int num = 6;
        if (A_0 != null)
        {
            Class400 class2 = this.class422_0.method_18();
            this.class691_0.method_1();
            class2.method_66(BookmarkStart.b("堫䬭䠯䘱ำ䈵崷䈹䠻ጽ⤿ⱁ㑃㍅㱇", num));
            class2.method_15(A_0.FieldResult);
            class2.method_67(BookmarkStart.b("堫䬭䠯䘱ำ䈵崷䈹䠻ጽ⤿ⱁ㑃㍅㱇", num));
            this.class691_0.method_2();
        }
    }

    private void method_16(string A_0)
    {
        this.method_17(A_0, true);
    }

    private void method_17(string A_0, bool A_1)
    {
        int num = 14;
        this.class691_0.method_1();
        string str = !A_1 ? BookmarkStart.b("ᐳ䈵崷䈹䠻н☿⭁㱃⍅ⱇ睉湋⡍ㅏ㹑❓㍕穗", num) : "";
        this.class422_0.method_18().method_66(A_0);
        this.class422_0.method_18().method_15(str);
        this.class422_0.method_18().method_9(BookmarkStart.b("ᬳ࠵", num));
        this.class691_0.method_2();
    }

    private void method_18(Field A_0)
    {
        smethod_3(A_0);
        Class400 class2 = this.class422_0.method_18();
        string str = BookmarkStart.b("ᨩȫᴭį਱圳嬵", 4);
        this.class691_0.method_1();
        class2.method_66(BookmarkStart.b("丩師伭䜯࠱圳夵嘷丹主儽ⰿ", 4));
        class2.method_68(BookmarkStart.b("丩師伭䜯࠱䜳䈵䄷嘹夻ጽ⸿⍁⥃⍅", 4), this.class974_0.method_26());
        class2.method_68(BookmarkStart.b("天娫䤭ਯ䔱崳刵䰷刹", 4), str);
        class2.method_68(BookmarkStart.b("天娫䤭ਯ娱儳張強刹䠻", 4), str);
        class2.method_68(BookmarkStart.b("帩䤫嘭䐯࠱唳堵嬷刹医䰽洿㙁㵃㙅ⵇ", 4), BookmarkStart.b("䬩弫̭匯娱唳䐵", 4));
        class2.method_69(BookmarkStart.b("丩師伭䜯࠱圳夵嘷丹主儽ⰿ", 4), string.Format(BookmarkStart.b("䤩䌫䀭䐯䀱嬳娵䌷ਹ䄻", 4), this.class422_0.method_31()));
        this.class422_0.method_32(this.class422_0.method_31() + 1);
        class2.method_67(BookmarkStart.b("丩師伭䜯࠱圳夵嘷丹主儽ⰿ", 4));
        this.class691_0.method_2();
    }

    private void method_19(string A_0)
    {
        int num = 8;
        Class400 class2 = this.class422_0.method_18();
        this.class691_0.method_1();
        class2.method_66(A_0);
        if (Class567.smethod_16(Class576.smethod_20(string_0)))
        {
            class2.method_69(BookmarkStart.b("崭䐯䬱堳匵ȷ帹崻䨽ℿ潁㝃㉅ㅇ♉⥋捍㹏㍑㥓㍕", num), this.class974_0.method_31());
        }
        else
        {
            class2.method_9(BookmarkStart.b("ိ", num));
        }
        class2.method_67(A_0);
        this.class691_0.method_2();
    }

    private void method_2(Field A_0)
    {
        int num = 5;
        string str = BookmarkStart.b("弪䠬圮䔰ल䄴嘶嬸场堼ሾ⹀╂桄⑆♈╊㥌⩎㽐❒", 5);
        if (A_0.Type == FieldType.FieldIndex)
        {
            str = BookmarkStart.b("弪䠬圮䔰ल吴嬶䤸区尼崾⑀㝂ⱄ⑆⡈❊恌♎㽐㝒ご⽖", num);
        }
        Class400 class2 = this.class422_0.method_18();
        Class569 class3 = new Class569(this.class422_0);
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        string str2 = class3.method_1(ownerParagraph);
        if (A_0.PreviousSibling != null)
        {
            class2.method_6(str2);
        }
        class2.method_4(str);
        this.method_3(A_0, str);
        class2.method_4(BookmarkStart.b("弪䠬圮䔰ल尴夶崸帺䔼ሾ⍀ⱂ⅄㹆", num));
        this.class422_0.method_38(0);
        this.class422_0.method_36(0);
        class3.method_2(ownerParagraph, str2);
    }

    private void method_20()
    {
        int num = 0;
        Class400 class2 = this.class422_0.method_18();
        string str = Class576.smethod_89(string_0, this.class422_0.method_15().HtmlBaseUrl, false);
        if (str != null)
        {
            if (!this.class422_0.method_101())
            {
                this.class691_0.method_1();
            }
            class2.method_66(BookmarkStart.b("別䴧利堫ᐭ儯", num));
            class2.method_68(BookmarkStart.b("帥䐧䌩䈫䔭ਯ䘱䴳䘵崷", num), BookmarkStart.b("唥䄧䜩尫䈭唯", num));
            string str2 = Class576.smethod_10(string_0, BookmarkStart.b("稥尧", num)).Trim(new char[] { '"' }).Trim(new char[] { ' ' });
            if (Class567.smethod_16(str2))
            {
                class2.method_68(BookmarkStart.b("䤥丧䰩䔫䴭唯࠱䀳圵䨷崹夻䨽洿⑁㙃❅╇⽉態⁍ㅏ㽑ㅓ", num), str2);
            }
            class2.method_69(BookmarkStart.b("帥䐧䌩䈫䔭ਯ娱䘳匵帷", num), str);
        }
    }

    private void method_21()
    {
        int num = 0;
        Class400 class2 = this.class422_0.method_18();
        string str = Class576.smethod_11(string_0);
        this.class691_0.method_1();
        class2.method_66(BookmarkStart.b("別䴧利堫ᐭ䌯圱䔳䌵崷吹弻嬽", 0));
        if (str != null)
        {
            class2.method_68(BookmarkStart.b("別䴧利堫ᐭ帯匱夳匵", num), str);
            class2.method_68(BookmarkStart.b("別䴧利堫ᐭ嘯崱䘳嬵䴷嘹崻", num), string.Format(BookmarkStart.b("䤥䜧䔩嬫ᐭ䬯ȱ䤳ᴵष", num), str));
        }
        class2.method_69(BookmarkStart.b("唥尧匩䀫䬭ਯ就䄳嬵ᔷ尹医䰽ⴿ⍁ぃ", num), Class576.smethod_15(string_0));
    }

    private void method_22()
    {
        Class400 class2 = this.class422_0.method_18();
        this.class691_0.method_1();
        class2.method_66(BookmarkStart.b("䄴制䄸伺ܼ伾⁀⑂⁄橆❈㹊⁌ⵎ㑐⅒", 15));
        class2.method_68(BookmarkStart.b("䘴䌶䀸场堼Ծ⽀㙂⡄橆⽈⑊㽌≎ぐ❒", 15), Class576.smethod_15(string_0));
        class2.method_69(BookmarkStart.b("䄴制䄸伺ܼ䰾⑀⽂⁄⑆㵈晊㵌⹎㙐㙒", 15), BookmarkStart.b("嘴䈶䬸䤺堼儾㕀", 15));
        class2.method_67(BookmarkStart.b("䄴制䄸伺ܼ伾⁀⑂⁄橆❈㹊⁌ⵎ㑐⅒", 15));
        this.class691_0.method_2();
    }

    private void method_23(string A_0)
    {
        Class400 class2 = this.class422_0.method_18();
        this.class691_0.method_1();
        class2.method_66(A_0);
        class2.method_69(BookmarkStart.b("䄱䀳伵吷弹ػ倽㔿⽁楃⁅❇㡉⅋⽍⑏", 12), Class576.smethod_15(string_0));
        class2.method_67(A_0);
        this.class691_0.method_2();
    }

    private void method_24(string A_0)
    {
        Class400 class2 = this.class422_0.method_18();
        this.class691_0.method_1();
        class2.method_66(BookmarkStart.b("䴸帺䔼䬾筀㙂㙄≆㭈晊⥌⩎㝐㩒㭔㉖㵘", 0x13));
        class2.method_69(BookmarkStart.b("䴸帺䔼䬾筀ⵂ⑄⩆ⱈ", 0x13), A_0);
        class2.method_67(BookmarkStart.b("䴸帺䔼䬾筀㙂㙄≆㭈晊⥌⩎㝐㩒㭔㉖㵘", 0x13));
        this.class691_0.method_2();
    }

    private void method_25()
    {
        if (smethod_5())
        {
            this.class691_0.method_1();
            this.class422_0.method_18().method_15(smethod_6());
            this.class691_0.method_2();
        }
    }

    private void method_3(Field A_0, string A_1)
    {
        int num = 11;
        Class400 class2 = this.class422_0.method_18();
        string str = string.Format(BookmarkStart.b("䨰̲䠴ᨶ䨸吺䠼䴾≀♂", 11), A_1);
        string str2 = string.Format(BookmarkStart.b("䨰̲䠴ᨶ尸唺䤼䴾㡀湂ㅄ≆⑈㭊⅌⹎═㙒", 11), A_1);
        class2.method_4(str);
        string[] strArray = Class576.smethod_10(string_0, BookmarkStart.b("帰", 11)).Trim(new char[] { '"' }).Split(new char[] { '-' });
        int num2 = 9;
        if (strArray.Length > 1)
        {
            class2.method_40(BookmarkStart.b("䔰嘲䴴䌶̸吺䠼䬾ⵀ⩂⭄≆摈❊⡌㥎㑐㽒", num), strArray[1]);
            num2 = Class1041.smethod_11(strArray[1]);
        }
        else
        {
            class2.method_43(BookmarkStart.b("䔰嘲䴴䌶̸吺䠼䬾ⵀ⩂⭄≆摈❊⡌㥎㑐㽒", num), num2);
        }
        class2.method_10(BookmarkStart.b("䔰嘲䴴䌶̸刺匼嬾⑀㭂桄㍆⁈㽊⅌⩎籐❒ご㩖⥘㝚㱜⭞Ѡ", num));
        int num4 = (A_0.Type == FieldType.FieldTOC) ? 0x13 : 10;
        for (int i = 0; i < num2; i++)
        {
            class2.method_4(str2);
            class2.method_43(BookmarkStart.b("䔰嘲䴴䌶̸吺䠼䬾ⵀ⩂⭄≆摈❊⡌㥎㑐㽒", num), i + 1);
            class2.method_40(BookmarkStart.b("䔰嘲䴴䌶̸䠺䤼䘾ⵀ♂桄⥆⡈♊⡌", num), Class922.smethod_77((Style) this.class422_0.method_15().Styles[num4 + i]));
            class2.method_10(BookmarkStart.b("䔰嘲䴴䌶̸刺匼嬾⑀㭂桄≆❈㽊㽌㙎籐げ㵔㙖⥘⽚㡜ⵞ", num));
            class2.method_10(BookmarkStart.b("䔰嘲䴴䌶̸刺匼嬾⑀㭂桄≆❈㽊㽌㙎籐❒ご⽖ⵘ", num));
            class2.method_4(BookmarkStart.b("䔰嘲䴴䌶̸刺匼嬾⑀㭂桄≆❈㽊㽌㙎籐❒㑔㕖瑘⡚⥜ぞᅠ", num));
            class2.method_40(BookmarkStart.b("䈰䜲䰴嬶尸ĺ䤼䘾ㅀ♂", num), BookmarkStart.b("䌰娲刴弶䴸", num));
            class2.method_40(BookmarkStart.b("䈰䜲䰴嬶尸ĺ儼娾⁀❂⁄㕆摈⡊╌⹎⍐", num), BookmarkStart.b("ἰ", num));
            class2.method_6(BookmarkStart.b("䔰嘲䴴䌶̸刺匼嬾⑀㭂桄≆❈㽊㽌㙎籐❒㑔㕖瑘⡚⥜ぞᅠ", num));
            class2.method_10(BookmarkStart.b("䔰嘲䴴䌶̸刺匼嬾⑀㭂桄≆❈㽊㽌㙎籐⍒㑔ざ㱘癚㍜⩞ౠŢdᕦ", num));
            class2.method_6(str2);
        }
        class2.method_6(str);
    }

    private void method_4(Field A_0)
    {
        int num = 13;
        Class400 class2 = this.class422_0.method_18();
        Class569 class3 = new Class569(this.class422_0);
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        string str = class3.method_1(ownerParagraph);
        if (A_0.PreviousSibling != null)
        {
            class2.method_6(str);
        }
        class2.method_6(BookmarkStart.b("䜲倴伶䴸ĺ吼儾╀♂㵄橆⭈⑊⥌㙎", num));
        class2.method_5();
        class3.method_2(ownerParagraph, str);
    }

    private void method_5(Field A_0)
    {
        int num = 1;
        DocumentObject previousSibling = (DocumentObject) A_0.PreviousSibling;
        string str = smethod_4();
        if (((previousSibling != null) && (previousSibling is FieldMark)) && (((previousSibling as Field).Type == FieldType.FieldSet) && (str == string_3)))
        {
            bool_2 = true;
        }
        else
        {
            bool_2 = false;
            Class400 class2 = this.class422_0.method_18();
            class2.method_66(BookmarkStart.b("匦䰨匪夬ᔮ匰尲娴尶吸娺似吾汀ㅂ⁄ⅆ", num));
            if (A_0.Type == FieldType.FieldPageRef)
            {
                class2.method_68(BookmarkStart.b("匦䰨匪夬ᔮ䌰嘲匴制䬸帺匼尾⑀湂⍄⡆㭈♊ⱌ㭎", num), BookmarkStart.b("圦䠨䰪䠬", num));
            }
            else if (string_0.IndexOf(BookmarkStart.b("ܦ用嬪", num)) != -1)
            {
                class2.method_68(BookmarkStart.b("匦䰨匪夬ᔮ䌰嘲匴制䬸帺匼尾⑀湂⍄⡆㭈♊ⱌ㭎", num), BookmarkStart.b("䌦䀨太䠬䰮䔰娲娴夶", num));
            }
            else
            {
                class2.method_68(BookmarkStart.b("匦䰨匪夬ᔮ䌰嘲匴制䬸帺匼尾⑀湂⍄⡆㭈♊ⱌ㭎", num), BookmarkStart.b("匦䰨匪夬", num));
            }
            class2.method_69(BookmarkStart.b("匦䰨匪夬ᔮ䌰嘲匴ᨶ圸娺值娾", num), str);
        }
    }

    private void method_6(Field A_0, FieldType A_1)
    {
        int num = 4;
        DocumentObject nextSibling = (DocumentObject) A_0.NextSibling;
        string str = "";
        while (nextSibling != null)
        {
            if ((nextSibling is FieldMark) && (A_1 == A_0.Type))
            {
                break;
            }
            if (nextSibling is TextRange)
            {
                str = string.Format(BookmarkStart.b("儩ᰫ匭䬯̱䤳", num), str, ((TextRange) nextSibling).Text);
                nextSibling = nextSibling.NextNonMarkupElementLimited;
            }
        }
        this.class422_0.method_18().method_15(str);
    }

    private void method_7()
    {
        int num = 11;
        string str = (string_0.IndexOf(BookmarkStart.b("洰䌲", 11)) == -1) ? BookmarkStart.b("弰刲場制ᐸ娺匼嬾汀♂㵄㍆ⱈ╊㹌♎㹐㵒", num) : BookmarkStart.b("地䘲头嬶", num);
        this.method_17(string.Format(BookmarkStart.b("䔰嘲䴴䌶̸伺堼刾ㅀ⽂⑄㍆ⱈ晊⍌⹎㱐㙒畔⍖㱘⍚⥜敞ՠ੢ᙤᝦը੪ᑬ剮印ࡲ䕴੶學", num), str), true);
    }

    private void method_8()
    {
        int num = 7;
        string str = Class576.smethod_10(string_0, BookmarkStart.b("怬樮挰琲瀴然瀸縺焼笾", 7)).Trim(new char[] { '"' }).Trim(new char[] { ' ' });
        Class400 class2 = this.class422_0.method_18();
        if (Class567.smethod_16(string_1))
        {
            this.class422_0.method_68(false);
            this.class422_0.method_68(true);
        }
        this.class691_0.method_1();
        class2.method_66(BookmarkStart.b("夬䨮䤰䜲༴匶堸伺尼崾⁀あ⁄橆ⵈ≊㹌㽎㵐㉒ⱔ", num));
        class2.method_68(BookmarkStart.b("夬䨮䤰䜲༴吶嘸场䠼刾⽀湂⭄♆⑈⹊", num), str);
        this.method_11();
        this.class422_0.method_18().method_15(string.Format(BookmarkStart.b("蘬吮İ串踴", num), str));
        class2.method_67(BookmarkStart.b("夬䨮䤰䜲༴匶堸伺尼崾⁀あ⁄橆ⵈ≊㹌㽎㵐㉒ⱔ", num));
        this.class691_0.method_2();
    }

    private void method_9()
    {
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(BookmarkStart.b("尧伩含娭ਯ嘱唳䈵夷堹崻䴽┿潁⩃⍅ぇ㹉", 2));
        this.method_11();
        class2.method_67(BookmarkStart.b("尧伩含娭ਯ嘱唳䈵夷堹崻䴽┿潁⩃⍅ぇ㹉", 2));
    }

    private static string smethod_0(string A_0)
    {
        int num = 0x10;
        if (A_0.IndexOf(BookmarkStart.b("笵紷根笻笽ؿുᙃ୅ेṉ", 0x10)) >= 0)
        {
            A_0 = A_0.Replace(BookmarkStart.b("樵ሷᨹ焻笽ሿՁŃE݇ᡉŋཌྷя", num), "");
        }
        return A_0;
    }

    private static string smethod_1(string A_0)
    {
        int num = 11;
        if (A_0 == null)
        {
            return "";
        }
        return A_0.Replace(BookmarkStart.b("洰", num), "").Replace(BookmarkStart.b("焰", num), "").Replace(BookmarkStart.b("ጰ", num), "").Trim();
    }

    private static void smethod_2(DocumentObject A_0)
    {
        string_0 = "";
        DocumentObject nextSibling = (DocumentObject) A_0.NextSibling;
        int num = 0;
        while (nextSibling != null)
        {
            if (((nextSibling.DocumentObjectType == DocumentObjectType.FieldMark) || (nextSibling.DocumentObjectType == DocumentObjectType.FieldMark)) && (num == 0))
            {
                break;
            }
            if (nextSibling.DocumentObjectType == DocumentObjectType.FieldMark)
            {
                num--;
            }
            else if (((num == 0) && (nextSibling.DocumentObjectType != DocumentObjectType.FieldMark)) && ((nextSibling is TextRange) && Class567.smethod_16(((TextRange) nextSibling).Text.Trim(new char[] { ' ' }))))
            {
                string_0 = string_0 + ((TextRange) nextSibling).Text;
            }
            nextSibling = (DocumentObject) nextSibling.NextSibling;
        }
    }

    private static FormField smethod_3(Field A_0)
    {
        DocumentObject nextSibling = (DocumentObject) A_0.NextSibling;
        while (nextSibling != null)
        {
            if (nextSibling.DocumentObjectType == DocumentObjectType.DropDownFormField)
            {
                break;
            }
            if (nextSibling.DocumentObjectType == DocumentObjectType.FieldMark)
            {
                return null;
            }
            nextSibling = (DocumentObject) nextSibling.NextSibling;
        }
        return (FormField) nextSibling;
    }

    private static string smethod_4()
    {
        return Class576.smethod_10(string_0, BookmarkStart.b("紮琰甲", 9)).Trim(new char[] { '"' }).Trim(new char[] { ' ' });
    }

    private static bool smethod_5()
    {
        string str = smethod_6();
        return (Class567.smethod_16(str) && (str.IndexOf('\\') == -1));
    }

    private static string smethod_6()
    {
        return string_0.Substring(string_0.ToLower().IndexOf(BookmarkStart.b("堸强䬼帾⽀⁂⁄", 0x13)) + 7).Trim(new char[] { ' ' });
    }

    private static bool smethod_7(Field A_0)
    {
        return ((A_0.Type != FieldType.FieldHyperlink) && !Class576.smethod_0(A_0));
    }
}

