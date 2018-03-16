using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Text.RegularExpressions;

internal class Class561
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private readonly Class399 class399_0;
    private readonly Class421 class421_0;
    private FootnoteType footnoteType_0;
    private const int int_0 = 1;
    private const int int_1 = 2;
    private const int int_2 = 3;
    private const int int_3 = 4;
    private const int int_4 = 5;
    private const int int_5 = 6;
    private const int int_6 = 7;
    private const int int_7 = 8;
    private const int int_8 = 9;
    private const int int_9 = 10;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("ḵ㨷ጹ䀻ᘽ䌿歁㡃湅䱇捉か晍問筑⡓繕兗獙⁛癝浟䭡ᡣ乥摧ᙩ杫ቭ繯孱ࡳ幵晷卹{噽齿ꮁ꺅펇풉躋趍钏鞑鶓鮕钗醙銛肝뾟ﾡ躣辥", 0x10), RegexOptions.Singleline | RegexOptions.Compiled);

    internal Class561(Class421 A_0)
    {
        this.class421_0 = A_0;
        this.class399_0 = (Class399) A_0.Interface52.imethod_1();
    }

    internal void method_0(TextRange A_0, bool A_1)
    {
        this.bool_0 = A_1;
        this.method_1(A_0);
    }

    private void method_1(TextRange A_0)
    {
        int num = 8;
        string text = A_0.Text;
        if (Class567.smethod_16(text) && (text[0] != '\x0001'))
        {
            bool flag = Class738.smethod_2(text[0]);
            bool flag2 = A_0.CharacterFormat.HasKey(230);
            if (flag && flag2)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    this.method_3(A_0);
                    this.class399_0.method_33(BookmarkStart.b("夭ਯ䄱䴳嬵", num), new object[] { BookmarkStart.b("夭ਯ吱嬳堵䰷", num), A_0.CharacterFormat.FontNameNonFarEast, BookmarkStart.b("夭ਯ儱尳圵䨷", num), Class1041.smethod_41(text[i]) });
                    this.method_5();
                }
            }
            else
            {
                int index = text.IndexOf(BookmarkStart.b("⌭", num));
                if ((index != -1) && (A_0.OwnerParagraph != null))
                {
                    string str4 = text.Substring(0, index);
                    string str3 = text.Substring(index + 1);
                    A_0.Text = str4;
                    text = str4;
                    Paragraph entity = new Paragraph(this.class421_0.Interface52.imethod_0());
                    TextRange range = new TextRange(this.class421_0.Interface52.imethod_0());
                    Paragraph ownerParagraph = A_0.OwnerParagraph;
                    Body owner = A_0.OwnerParagraph.Owner as Body;
                    entity.Format.ImportContainer(ownerParagraph.Format);
                    entity.Format.method_21(ownerParagraph.Format);
                    entity.ListFormat.ImportContainer(ownerParagraph.ListFormat);
                    if (ownerParagraph.StyleName != null)
                    {
                        entity.ApplyStyle(ownerParagraph.StyleName);
                    }
                    entity.BreakCharacterFormat.ImportContainer(ownerParagraph.BreakCharacterFormat);
                    entity.BreakCharacterFormat.method_21(ownerParagraph.BreakCharacterFormat);
                    int num4 = ownerParagraph.method_5() + 1;
                    owner.ChildObjects.Insert(num4, entity);
                    range.Text = str3;
                    range.CharacterFormat.ImportContainer(A_0.CharacterFormat);
                    range.CharacterFormat.method_21(A_0.CharacterFormat);
                    entity.Items.Insert(0, range);
                    this.method_2(entity, ownerParagraph, A_0.method_5() + 1);
                }
                this.method_3(A_0);
                foreach (Match match in regex_0.Matches(text))
                {
                    string str2 = match.Groups[10].Value;
                    if (Class567.smethod_16(str2))
                    {
                        this.method_7(str2);
                    }
                    else if (Class567.smethod_16(match.Groups[1].Value))
                    {
                        this.method_6();
                    }
                    else if (Class567.smethod_16(match.Groups[2].Value))
                    {
                        this.class399_0.method_10(BookmarkStart.b("夭ਯ䄱儳䘵夷䠹崻䨽⼿ぁ", num));
                    }
                    else if (Class567.smethod_16(match.Groups[3].Value))
                    {
                        this.class399_0.method_10(BookmarkStart.b("夭ਯ儱嬳堵䰷匹刻䬽ℿ㙁ⵃ⥅♇᥉⥋㹍ㅏ⁑㕓≕㝗⡙", num));
                    }
                    else if (Class567.smethod_16(match.Groups[4].Value))
                    {
                        this.class399_0.method_10(BookmarkStart.b("夭ਯ匱娳堵圷丹崻䨽⤿ⵁ⩃ᑅⵇⱉ", num));
                    }
                    else if (Class567.smethod_16(match.Groups[5].Value))
                    {
                        this.method_8();
                    }
                    else if (Class567.smethod_16(match.Groups[6].Value))
                    {
                        this.class399_0.method_10(BookmarkStart.b("夭ਯ儱䘳", num));
                    }
                    else if (!Class567.smethod_16(match.Groups[7].Value))
                    {
                        if (Class567.smethod_16(match.Groups[9].Value))
                        {
                            if (!text.StartsWith(Class816.string_21))
                            {
                                this.method_5();
                                this.method_3(A_0);
                            }
                            this.class399_0.method_10(BookmarkStart.b("夭ਯ䄱嬳倵䰷爹䔻丽⠿❁⩃", num));
                        }
                        else if (Class567.smethod_16(match.Groups[8].Value))
                        {
                            if (!text.StartsWith(Class816.string_12))
                            {
                                this.method_5();
                                this.method_3(A_0);
                            }
                            this.class399_0.method_10(BookmarkStart.b("夭ਯ就嬳琵䨷弹崻唽࠿㭁㑃⹅ⵇ⑉", num));
                        }
                    }
                }
                this.method_5();
            }
        }
    }

    internal bool method_10()
    {
        return this.bool_1;
    }

    internal void method_11(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal FootnoteType method_12()
    {
        return this.footnoteType_0;
    }

    internal void method_13(FootnoteType A_0)
    {
        this.footnoteType_0 = A_0;
    }

    private void method_2(Paragraph A_0, Paragraph A_1, int A_2)
    {
        int num = A_1.Items.Count - A_2;
        for (int i = 0; i < num; i++)
        {
            IDocumentObject obj2 = A_1.ChildObjects[A_2];
            if (((obj2 is Field) && !(obj2 is MergeField)) || (obj2 is FormField))
            {
                A_0.ChildObjects.InnerList.Add(obj2);
                A_1.ChildObjects.InnerList.RemoveAt(A_2);
                A_0.LastChild.method_0(A_0);
                (obj2 as ParagraphBase).StartPos = (A_0.ChildObjects.Count > 1) ? (A_0.ChildObjects.InnerList[A_0.ChildObjects.InnerList.Count - 2] as ParagraphBase).EndPos : 0;
            }
            else
            {
                A_0.ChildObjects.Add(obj2);
            }
        }
    }

    private void method_3(ParagraphBase A_0)
    {
        this.method_4(A_0.CharacterFormat, A_0, false);
    }

    internal bool method_4(CharacterFormat A_0, IRunAttrSource A_1, bool A_2)
    {
        int num = 8;
        this.bool_2 = A_0.HasInsertRevision;
        this.bool_3 = A_0.HasDeleteRevision;
        this.class399_0.method_4(this.class399_0.method_57() ? BookmarkStart.b("䌭ਯ䀱", num) : BookmarkStart.b("夭ਯ䀱", num));
        return Class418.smethod_0(A_0, A_1, A_2, this.class421_0);
    }

    internal void method_5()
    {
        int num = 15;
        this.class399_0.method_6(this.class399_0.method_57() ? BookmarkStart.b("場ശ䬸", num) : BookmarkStart.b("䈴ശ䬸", num));
        if (this.bool_2)
        {
            this.bool_2 = false;
        }
        if (this.bool_3)
        {
            this.bool_3 = false;
        }
    }

    private void method_6()
    {
        int num = 0x12;
        string str = (this.footnoteType_0 == FootnoteType.Footnote) ? BookmarkStart.b("伷9娻儽⼿㙁⩃⥅㱇⽉ṋ⭍㙏", num) : BookmarkStart.b("伷9夻倽␿ⱁ⭃㉅ⵇᡉ⥋⡍", num);
        this.class399_0.method_10(str);
    }

    private void method_7(string A_0)
    {
        int num = 11;
        if (Class567.smethod_16(A_0))
        {
            string str;
            if (this.bool_1)
            {
                if (this.bool_3)
                {
                    str = BookmarkStart.b("䘰ल儴制唸爺匼䰾㕀ㅂᅄ≆ㅈ㽊", num);
                }
                else
                {
                    str = BookmarkStart.b("䘰ल尴夶䨸伺似款⑀㭂ㅄ", num);
                }
            }
            else if (this.bool_3)
            {
                str = BookmarkStart.b("䘰ल儴制唸漺堼䜾㕀", num);
            }
            else
            {
                str = this.class399_0.method_57() ? BookmarkStart.b("尰ल䄴", num) : BookmarkStart.b("䘰ल䄴", num);
            }
            this.class399_0.method_4(str);
            if ((A_0.Trim(new char[] { ' ' }).Length != A_0.Length) && this.bool_0)
            {
                this.class399_0.method_18(BookmarkStart.b("䤰帲头ശ䨸䬺尼尾⑀", num), BookmarkStart.b("䄰䄲倴䐶尸䤺䬼娾", num));
            }
            this.class399_0.method_15(A_0);
            this.class399_0.method_5();
        }
    }

    private void method_8()
    {
        this.class399_0.method_10(BookmarkStart.b("儥ሧ帩䴫䰭", 0));
    }

    private void method_9(char A_0, LineBreakClear A_1)
    {
        int num = 0x13;
        string str = null;
        if ((A_0 == '\v') && (A_1 != LineBreakClear.None))
        {
            str = Class860.smethod_12(A_1);
        }
        if ((A_0 == '\v') && (A_1 == LineBreakClear.None))
        {
            this.class399_0.method_10(BookmarkStart.b("丸ĺ弼䴾", num));
        }
        else
        {
            this.class399_0.method_33(BookmarkStart.b("丸ĺ弼䴾", num), new object[] { BookmarkStart.b("丸ĺ䤼䘾ㅀ♂", num), Class860.smethod_14(BreakType.LineBreak, false), BookmarkStart.b("丸ĺ帼匾⑀≂㝄", num), str });
        }
    }
}

