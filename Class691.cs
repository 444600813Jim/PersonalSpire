using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using System;
using System.Text.RegularExpressions;

internal class Class691
{
    private readonly Class422 class422_0;
    private readonly Class569 class569_0;
    private readonly Class974 class974_0;
    private const int int_0 = 1;
    private const int int_1 = 2;
    private const int int_2 = 3;
    private const int int_3 = 4;
    private const int int_4 = 1;
    private const int int_5 = 2;
    private const int int_6 = 3;
    private const int int_7 = 5;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("့", 0x12) + Class816.string_26 + BookmarkStart.b("ᄷ䘹ᐻ", 0x12) + Class816.string_25 + BookmarkStart.b("ᄷ䘹ᐻ", 0x12) + Class816.string_27 + BookmarkStart.b("ᄷ䘹ᐻ攽ḿ", 0x12) + Class816.string_26 + Class816.string_25 + Class816.string_27 + BookmarkStart.b("攷္ᔻ", 0x12), RegexOptions.Singleline | RegexOptions.Compiled);
    private static readonly Regex regex_1 = new Regex(BookmarkStart.b("့", 0x12) + Class816.string_9 + BookmarkStart.b("ᄷ䘹ᐻ", 0x12) + Class816.string_6 + BookmarkStart.b("ᄷ䘹ᐻᘽ", 0x12) + Class816.string_11 + BookmarkStart.b("ᄷ䄹഻ሽ㴿歁㡃湅ፇᑉ", 0x12) + Class816.string_9 + Class816.string_11 + Class816.string_6 + BookmarkStart.b("攷္ᔻ", 0x12), RegexOptions.Singleline | RegexOptions.Compiled);

    internal Class691(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class974_0 = new Class974(this.class422_0);
        this.class569_0 = new Class569(this.class422_0);
    }

    internal void method_0(ParagraphBase A_0)
    {
        if (!this.class422_0.method_67())
        {
            bool flag;
            if (!(flag = Class569.smethod_7(A_0.OwnerParagraph)) && (!this.class422_0.method_103() || !this.class422_0.method_101()))
            {
                this.method_1();
            }
            if (!(A_0 as TextRange).SkipDocxItem && (A_0 is TextRange))
            {
                string str = smethod_0(((TextRange) A_0).Text);
                this.method_7(str);
                if (!flag && (!this.class422_0.method_103() || !this.class422_0.method_101()))
                {
                    this.method_2();
                }
                this.class422_0.method_96(false);
            }
        }
    }

    internal void method_1()
    {
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(BookmarkStart.b("堫䬭䠯䘱ำ䔵䠷嬹刻", 6));
        class2.method_69(BookmarkStart.b("堫䬭䠯䘱ำ䔵䰷䌹倻嬽洿ⱁ╃⭅ⵇ", 6), this.class974_0.method_27());
    }

    private void method_10()
    {
        this.class422_0.method_18().method_9(BookmarkStart.b("ᤸܺ䤼娾㥀㝂罄㑆晈畊", 0x13));
    }

    private bool method_11(string A_0, bool A_1)
    {
        return (((!Class567.smethod_16(this.class422_0.method_18().method_21(A_0)) && !A_1) && (A_0.IndexOf(Class816.string_6) == -1)) && (A_0.IndexOf(Class816.string_9) == -1));
    }

    internal void method_2()
    {
        this.class422_0.method_18().method_67(BookmarkStart.b("䐯圱䰳䈵ȷ䤹䰻弽⸿", 10));
    }

    internal VisitorAction method_3(ParagraphBase A_0)
    {
        string text = ((TextRange) A_0).Text;
        if ((text != Class816.string_15) && (text != Class816.string_14))
        {
            Paragraph paragraph = A_0.method_28();
            if (paragraph == null)
            {
                return VisitorAction.Continue;
            }
            bool flag = ((text.IndexOf(Class816.string_26) != -1) || (text.IndexOf(Class816.string_25) != -1)) || (text.IndexOf(Class816.string_27) != -1);
            if (this.method_11(text, flag))
            {
                return VisitorAction.Continue;
            }
            switch (this.class422_0.method_23())
            {
                case OpenDocumentWritingStage.ContentAutomaticStyles:
                case OpenDocumentWritingStage.StylesAutomaticStyles:
                    if ((!this.class422_0.method_67() || flag) && (!Class569.smethod_7(paragraph) && (!this.class422_0.method_103() || !this.class422_0.method_101())))
                    {
                        if (flag)
                        {
                            this.method_4(A_0);
                        }
                        else
                        {
                            this.class974_0.method_2(A_0);
                        }
                    }
                    break;

                case OpenDocumentWritingStage.ContentBody:
                case OpenDocumentWritingStage.StylesMasterPage:
                    if (!flag)
                    {
                        this.method_0(A_0);
                        break;
                    }
                    this.method_5(A_0);
                    break;
            }
        }
        return VisitorAction.Continue;
    }

    private void method_4(ParagraphBase A_0)
    {
        if (A_0 is TextRange)
        {
            Paragraph paragraph = A_0.method_28();
            foreach (Match match in regex_0.Matches(((TextRange) A_0).Text))
            {
                if (((Class567.smethod_16(match.Groups[2].Value) || Class567.smethod_16(match.Groups[1].Value)) || Class567.smethod_16(match.Groups[3].Value)) && !this.method_6(A_0, match.Index))
                {
                    if (Class567.smethod_16(match.Groups[2].Value))
                    {
                        this.class974_0.method_8(paragraph, false, true);
                    }
                    if (Class567.smethod_16(match.Groups[1].Value))
                    {
                        this.class974_0.method_8(paragraph, true, false);
                    }
                    if (Class567.smethod_16(match.Groups[3].Value))
                    {
                        this.class974_0.method_8(paragraph, false, false);
                    }
                }
                if (Class567.smethod_16(match.Groups[4].Value) && !this.class422_0.method_67())
                {
                    this.class974_0.method_2(A_0);
                }
            }
        }
    }

    private void method_5(ParagraphBase A_0)
    {
        Paragraph paragraph = A_0.method_28();
        Section section = paragraph.method_49().Clone();
        Paragraph paragraph2 = (Paragraph) paragraph.Clone();
        section.Body.Paragraphs.Add(paragraph2);
        if (A_0 is TextRange)
        {
            foreach (Match match in regex_0.Matches(((TextRange) A_0).Text))
            {
                string str = match.Groups[4].Value;
                if (((Class567.smethod_16(match.Groups[2].Value) || Class567.smethod_16(match.Groups[1].Value)) || Class567.smethod_16(match.Groups[3].Value)) && !this.method_6(A_0, match.Index))
                {
                    this.class569_0.method_19(paragraph);
                }
                if (Class567.smethod_16(str))
                {
                    ParagraphBase entity = (ParagraphBase) A_0.Clone();
                    paragraph2.ChildObjects.Add(entity);
                    if (entity is TextRange)
                    {
                        ((TextRange) entity).Text = str;
                    }
                    this.method_0(entity);
                }
            }
        }
    }

    private bool method_6(ParagraphBase A_0, int A_1)
    {
        if (!(A_0 is TextRange))
        {
            return false;
        }
        string text = ((TextRange) A_0).Text;
        if (((A_1 != 0) || (A_0.PreviousSibling != null)) && !(A_0.NextSibling is FieldMark))
        {
            return ((A_1 == (text.Length - 1)) && (A_0.NextSibling == null));
        }
        return true;
    }

    private void method_7(string A_0)
    {
        int num = 4;
        Class400 class2 = this.class422_0.method_18();
        foreach (Match match in regex_1.Matches(A_0))
        {
            string str = match.Groups[5].Value;
            if (Class567.smethod_16(str))
            {
                class2.method_15(str);
            }
            string str2 = match.Groups[3].Value;
            if (Class567.smethod_16(str2))
            {
                this.method_9(str2.Length);
            }
            if (Class567.smethod_16(match.Groups[1].Value))
            {
                this.method_8();
            }
            if (Class567.smethod_16(match.Groups[2].Value))
            {
                class2.method_9(BookmarkStart.b("ᘩ堫䬭䠯䘱ำ娵儷吹夻ጽ∿ぁ⅃❅⍇敉牋", num));
            }
        }
    }

    private void method_8()
    {
        this.class422_0.method_18().method_9(BookmarkStart.b("ਵ䰷弹䐻䨽稿㙁╃⑅杇瑉", 0x10));
    }

    private void method_9(int A_0)
    {
        int num = 1;
        if (A_0 > 0)
        {
            if (A_0 == 1)
            {
                this.class422_0.method_18().method_9(BookmarkStart.b("ᬦ崨个唬嬮ର䀲ᨴश", num));
            }
            else
            {
                this.class422_0.method_18().method_9(string.Format(BookmarkStart.b("ᬦ崨个唬嬮ର䀲ᔴ䌶尸䌺䤼Ծ≀繂杄㱆祈㙊潌恎潐", num), A_0));
            }
        }
    }

    internal static string smethod_0(string A_0)
    {
        if (A_0 != null)
        {
            A_0 = A_0.Replace('\x001e', '‑');
            A_0 = A_0.Replace('\x001f', '\x00ad');
        }
        return A_0;
    }
}

