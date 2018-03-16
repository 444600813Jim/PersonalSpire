using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;

internal class Class569
{
    private readonly Class422 class422_0;
    private readonly Class974 class974_0;

    internal Class569(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class974_0 = new Class974(this.class422_0);
    }

    internal VisitorAction method_0(Paragraph A_0, bool A_1)
    {
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            this.class422_0.method_96(true);
            if (this.method_7(A_0, this.class422_0.method_87()))
            {
                return VisitorAction.Continue;
            }
            Class400 class2 = this.class422_0.method_18();
            char ch = smethod_3(A_0);
            char ch2 = smethod_4(this.class422_0.method_87());
            bool flag2 = (ch == '\f') || (ch2 == '\f');
            bool flag = (ch == '\x000e') || (ch2 == '\x000e');
            if (this.class422_0.method_21())
            {
                if ((flag2 || flag) && (this.class422_0.method_87() == null))
                {
                    this.class974_0.method_8(A_0, false, false);
                }
                this.class974_0.method_8(A_0, flag2, flag);
            }
            else if (((this.class422_0.method_23() != OpenDocumentWritingStage.ContentBodyTrackedChanges) || A_1) && ((this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters) && (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)))
            {
                this.class422_0.method_38(0);
                this.class422_0.method_36(0);
                string str = this.method_1(A_0);
                if ((flag2 || flag) && (this.class422_0.method_87() == null))
                {
                    this.method_2(A_0, str);
                    class2.method_6(str);
                }
                if (this.method_6(A_0))
                {
                    this.method_8(A_0);
                }
                this.method_2(A_0, str);
            }
        }
        return VisitorAction.Continue;
    }

    internal string method_1(Paragraph A_0)
    {
        int num = 7;
        if (((A_0.Format.OutlineLevel < OutlineLevel.Level1) || (A_0.Format.OutlineLevel > OutlineLevel.Level9)) || ((A_0.ParentObject is ShapeObject) && Class468.smethod_3(A_0.ParentObject as ShapeObject)))
        {
            return BookmarkStart.b("夬䨮䤰䜲༴䜶", num);
        }
        return BookmarkStart.b("夬䨮䤰䜲༴弶", num);
    }

    private string method_10(Paragraph A_0)
    {
        if (A_0.ListFormat.ListType != ListType.Bulleted)
        {
            for (int i = 0; i < this.class422_0.method_91().Count; i++)
            {
                Paragraph paragraph = this.class422_0.method_91().method_0(i);
                if (paragraph.IsList && (A_0.GetListFormatForApplyStyle().ListLevelNumber == paragraph.GetListFormatForApplyStyle().ListLevelNumber))
                {
                    if (!this.class422_0.method_14().method_13())
                    {
                        return smethod_1(i);
                    }
                    if (i == (this.class422_0.method_91().Count - 1))
                    {
                        return smethod_1(i);
                    }
                }
            }
        }
        return null;
    }

    private void method_11(Paragraph A_0)
    {
        Class400 class2 = this.class422_0.method_18();
        int listLevelNumber = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        Paragraph nextSibling = A_0.NextSibling as Paragraph;
        Paragraph paragraph2 = smethod_2(A_0);
        int num2 = this.method_15(A_0, nextSibling, paragraph2);
        if (this.method_16(A_0))
        {
            class2.method_5();
            class2.method_5();
        }
        if (this.method_17(A_0))
        {
            class2.method_5();
        }
        while (listLevelNumber > num2)
        {
            class2.method_5();
            class2.method_5();
            listLevelNumber--;
        }
        this.class422_0.method_91().Add(A_0);
    }

    private bool method_12(Paragraph A_0)
    {
        int listLevelNumber = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        Paragraph paragraph = this.class422_0.method_87() as Paragraph;
        Paragraph paragraph2 = this.method_18();
        int num2 = (paragraph2 == null) ? -1 : paragraph2.GetListFormatForApplyStyle().ListLevelNumber;
        if ((((paragraph == null) || !paragraph.IsList) || (paragraph.ListFormat.IsEmptyList || (num2 != listLevelNumber))) || (this.class422_0.method_87() is Table))
        {
            return true;
        }
        if (!A_0.IsInCell && !(A_0.ParentObject is Footnote))
        {
            return false;
        }
        return (A_0.PreviousSibling == null);
    }

    private bool method_13(Paragraph A_0)
    {
        int listLevelNumber = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        int num2 = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        Paragraph paragraph = this.class422_0.method_87() as Paragraph;
        Paragraph paragraph2 = this.method_18();
        int num4 = (paragraph2 == null) ? -1 : paragraph2.GetListFormatForApplyStyle().ListLevelNumber;
        int num3 = this.method_14(A_0, paragraph, paragraph2);
        if ((((paragraph == null) || !paragraph.IsList) || (paragraph.ListFormat.IsEmptyList || (num4 != listLevelNumber))) || (num2 > num3))
        {
            return false;
        }
        if (A_0.IsInCell)
        {
            return (A_0.PreviousSibling != null);
        }
        return true;
    }

    private int method_14(Paragraph A_0, Paragraph A_1, Paragraph A_2)
    {
        if ((A_2 == null) || ((A_1 != null) && ((((!A_1.IsList || A_1.ListFormat.IsEmptyList) || ((A_0.OwnerTextBody.Paragraphs[0] == A_0) || (A_1.OwnerTextBody.Paragraphs[A_1.OwnerTextBody.Paragraphs.Count - 1] == A_1))) || (A_1.IsEndOfSection || ((A_0.ParentObject is Footnote) && (A_0.PreviousSibling == null)))) || ((smethod_0(A_1) || A_1.IsEndOfSection) && (this.class422_0.method_16().NextSibling != null)))))
        {
            return 0;
        }
        return A_2.GetListFormatForApplyStyle().ListLevelNumber;
    }

    private int method_15(Paragraph A_0, Paragraph A_1, Paragraph A_2)
    {
        if ((A_2 == null) || ((A_1 != null) && ((((!A_1.IsList || (A_1.OwnerTextBody.Paragraphs[0] == A_1)) || ((A_0.OwnerTextBody.Paragraphs[A_0.OwnerTextBody.Paragraphs.Count - 1] == A_0) || A_0.IsEndOfSection)) || ((A_0.ParentObject is Footnote) && (A_0.NextSibling == null))) || ((smethod_0(A_0) || A_0.IsEndOfSection) && (this.class422_0.method_16().NextSibling != null)))))
        {
            return 0;
        }
        return A_2.GetListFormatForApplyStyle().ListLevelNumber;
    }

    private bool method_16(Paragraph A_0)
    {
        int listLevelNumber = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        Paragraph nextSibling = A_0.NextSibling as Paragraph;
        Paragraph paragraph2 = smethod_2(A_0);
        int num2 = (paragraph2 == null) ? -1 : paragraph2.GetListFormatForApplyStyle().ListLevelNumber;
        return (((((nextSibling == null) || nextSibling.ListFormat.IsEmptyList) || (!nextSibling.IsList || (num2 != listLevelNumber))) || ((A_0.NextNonMarkupElementLimited is Table) || (A_0.IsInCell && (A_0.NextSibling == null)))) || this.method_9(A_0, nextSibling));
    }

    private bool method_17(Paragraph A_0)
    {
        int listLevelNumber = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        int num2 = A_0.GetListFormatForApplyStyle().ListLevelNumber;
        Paragraph nextSibling = A_0.NextSibling as Paragraph;
        Paragraph paragraph2 = smethod_2(A_0);
        int num4 = (paragraph2 == null) ? -1 : paragraph2.GetListFormatForApplyStyle().ListLevelNumber;
        int num3 = this.method_15(A_0, nextSibling, paragraph2);
        if ((((nextSibling == null) || nextSibling.ListFormat.IsEmptyList) || (!nextSibling.IsList || (num4 != listLevelNumber))) || ((num2 < num3) || (A_0.IsInCell && (A_0.NextSibling == null))))
        {
            return false;
        }
        return !this.method_9(A_0, nextSibling);
    }

    private Paragraph method_18()
    {
        if (this.class422_0.method_91().Count <= 0)
        {
            return null;
        }
        return this.class422_0.method_91().method_0(this.class422_0.method_91().Count - 1);
    }

    internal void method_19(Paragraph A_0)
    {
        this.class422_0.method_80(true);
        this.method_5(A_0);
        this.method_3(A_0);
        this.class422_0.method_80(false);
    }

    internal void method_2(Paragraph A_0, string A_1)
    {
        int num = 0x12;
        Class400 class2 = this.class422_0.method_18();
        class2.method_4(A_1);
        class2.method_40(BookmarkStart.b("䰷弹䐻䨽稿ㅁぃ㽅⑇⽉態⁍ㅏ㽑ㅓ", 0x12), this.class974_0.method_28());
        if (A_1 == BookmarkStart.b("䰷弹䐻䨽稿⩁", 0x12))
        {
            class2.method_43(BookmarkStart.b("䰷弹䐻䨽稿ⵁㅃ㉅⑇⍉≋⭍絏㹑ㅓ⁕㵗㙙", num), ((int) A_0.Format.OutlineLevel) + 1);
        }
    }

    internal VisitorAction method_3(Paragraph A_0)
    {
        if (A_0.Owner == null)
        {
            return VisitorAction.Continue;
        }
        return this.method_0(A_0, false);
    }

    internal VisitorAction method_4(Paragraph A_0, bool A_1)
    {
        if (((!this.method_7(A_0, A_0) && !this.class422_0.method_21()) && ((this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters) && (this.class422_0.method_23() != OpenDocumentWritingStage.MathML))) && ((this.class422_0.method_23() != OpenDocumentWritingStage.ContentBodyTrackedChanges) || A_1))
        {
            this.class422_0.method_18().method_6(this.method_1(A_0));
            if (this.method_6(A_0))
            {
                this.method_11(A_0);
            }
        }
        this.class422_0.method_90(A_0);
        this.class422_0.method_11(A_0, A_0.method_49());
        return VisitorAction.Continue;
    }

    internal VisitorAction method_5(Paragraph A_0)
    {
        if ((this.class422_0.method_23() != OpenDocumentWritingStage.MathML) && (A_0.Owner != null))
        {
            return this.method_4(A_0, false);
        }
        return VisitorAction.Continue;
    }

    private bool method_6(Paragraph A_0)
    {
        return (((A_0.IsList && !(A_0.ParentObject is Comment)) && !this.class422_0.method_79()) && !A_0.ListFormat.IsEmptyList);
    }

    private bool method_7(Paragraph A_0, DocumentObject A_1)
    {
        if (A_0.ParentObject is ShapeObject)
        {
            ShapeObject parentObject = (ShapeObject) A_0.ParentObject;
            if ((((parentObject.ChildObjects.Count == 1) && (parentObject.ChildObjects[0] is Paragraph)) && ((((Paragraph) parentObject.ChildObjects[0]).ChildObjects.Count == 1) && (((Paragraph) parentObject.ChildObjects[0]).ChildObjects[0] is ShapeObject))) && (((ShapeObject) ((Paragraph) parentObject.ChildObjects[0]).ChildObjects[0]).IsImage && (parentObject.ParentObject is ShapeGroup)))
            {
                return true;
            }
        }
        return (smethod_0(A_0) || smethod_6(A_0, A_1));
    }

    private void method_8(Paragraph A_0)
    {
        int num = 7;
        Class400 class2 = this.class422_0.method_18();
        Paragraph paragraph = this.class422_0.method_89();
        Paragraph paragraph2 = this.method_18();
        int num2 = this.method_14(A_0, paragraph, paragraph2);
        string lFOStyleName = A_0.ListFormat.LFOStyleName;
        ListFormat listFormatForApplyStyle = A_0.GetListFormatForApplyStyle();
        int listLevelNumber = listFormatForApplyStyle.ListLevelNumber;
        if (this.method_12(A_0))
        {
            string str3;
            class2.method_4(BookmarkStart.b("夬䨮䤰䜲༴嬶倸䠺䤼", num));
            string name = listFormatForApplyStyle.CurrentListStyle.Name;
            if (!this.class422_0.hashtable_1.ContainsKey(name))
            {
                str3 = this.class974_0.method_29();
                this.class422_0.hashtable_1.Add(name, str3);
            }
            else
            {
                str3 = (string) this.class422_0.hashtable_1[name];
            }
            class2.method_40(BookmarkStart.b("夬䨮䤰䜲༴䐶䴸䈺儼娾汀ⵂ⑄⩆ⱈ", num), str3);
            if (string.IsNullOrEmpty(lFOStyleName))
            {
                class2.method_40(BookmarkStart.b("夬䨮䤰䜲༴吶嘸唺䤼嘾⽀㙂⁄橆❈㹊⁌ⵎ㑐⅒㱔㥖㹘", num), BookmarkStart.b("夬崮䐰嘲", num));
            }
            class2.method_4(BookmarkStart.b("夬䨮䤰䜲༴嬶倸䠺䤼ሾ⡀㝂⁄⩆", num));
            int num4 = 0;
            while (listLevelNumber > num2)
            {
                class2.method_4(BookmarkStart.b("夬䨮䤰䜲༴嬶倸䠺䤼", num));
                class2.method_4(BookmarkStart.b("夬䨮䤰䜲༴嬶倸䠺䤼ሾ⡀㝂⁄⩆", num));
                if ((num4 == 0) && !string.IsNullOrEmpty(A_0.ListFormat.LFOStyleName))
                {
                    class2.method_43(BookmarkStart.b("夬䨮䤰䜲༴䐶䴸娺似䬾汀㕂⑄⭆㱈⹊", num), this.class422_0.method_15().ListOverrides.method_35(lFOStyleName).method_23().method_5(listLevelNumber).StartAt);
                }
                num4++;
                listLevelNumber--;
            }
        }
        if (this.method_13(A_0))
        {
            class2.method_4(BookmarkStart.b("夬䨮䤰䜲༴嬶倸䠺䤼ሾ⡀㝂⁄⩆", num));
        }
    }

    private bool method_9(Paragraph A_0, Paragraph A_1)
    {
        if (!smethod_0(A_1) && !A_0.IsEndOfSection)
        {
            return false;
        }
        return (this.class422_0.method_16().NextSibling != null);
    }

    private static bool smethod_0(Paragraph A_0)
    {
        return ((!A_0.HasChildElements && A_0.IsEndOfSection) && !A_0.IsEndOfDocument);
    }

    private static string smethod_1(int A_0)
    {
        int num = 9;
        if (A_0 == -1)
        {
            return null;
        }
        return string.Format(BookmarkStart.b("䌮堰䀲䄴䰶स䘺", num), A_0);
    }

    private static Paragraph smethod_2(Paragraph A_0)
    {
        Paragraph nextNonMarkupElementLimited = A_0.NextNonMarkupElementLimited as Paragraph;
        if ((A_0.NextSibling != null) && ((nextNonMarkupElementLimited == null) || !smethod_0(nextNonMarkupElementLimited)))
        {
            for (DocumentObject obj2 = (A_0.OwnerTextBody.Paragraphs[A_0.OwnerTextBody.Paragraphs.Count - 1] == A_0) ? A_0.OwnerTextBody.NextNonMarkupElementLimited : A_0.NextNonMarkupElementLimited; obj2 != null; obj2 = obj2.NextNonMarkupElementLimited as Paragraph)
            {
                if (obj2 is Table)
                {
                    break;
                }
                if (obj2 is Paragraph)
                {
                    Paragraph paragraph2 = (Paragraph) obj2;
                    if (paragraph2.IsList)
                    {
                        return paragraph2;
                    }
                }
            }
        }
        return null;
    }

    internal static char smethod_3(Paragraph A_0)
    {
        if ((A_0 != null) && (A_0.FirstChild != null))
        {
            Break firstChild = A_0.FirstChild as Break;
            if (firstChild != null)
            {
                switch (firstChild.BreakType)
                {
                    case BreakType.PageBreak:
                        return '\f';

                    case BreakType.ColumnBreak:
                        return '\x000e';

                    case BreakType.LineBreak:
                        return '\v';
                }
            }
        }
        return '\0';
    }

    internal static char smethod_4(DocumentObject A_0)
    {
        if ((A_0 != null) && (A_0 is Paragraph))
        {
            Paragraph paragraph = A_0 as Paragraph;
            if (paragraph.ChildObjects.Count > 0)
            {
                ParagraphBase base2 = (ParagraphBase) paragraph.ChildObjects[paragraph.ChildObjects.Count - 1];
                if ((base2 != null) && (base2 is TextRange))
                {
                    string text = ((TextRange) base2).Text;
                    if (Class567.smethod_16(text) && (text.Length > 1))
                    {
                        return text[text.Length - 1];
                    }
                }
            }
        }
        return '\0';
    }

    private static bool smethod_5(DocumentObject A_0)
    {
        for (DocumentObject obj2 = A_0; obj2 != null; obj2 = obj2.Owner)
        {
            if (obj2.Owner is ShapeObject)
            {
                return true;
            }
        }
        return false;
    }

    internal static bool smethod_6(Paragraph A_0, DocumentObject A_1)
    {
        if ((A_1 == null) || !(A_1 is Paragraph))
        {
            return false;
        }
        Paragraph paragraph = (Paragraph) A_1;
        if (paragraph.IsInCell || smethod_5(A_0))
        {
            return false;
        }
        if (!paragraph.Format.method_55(0x5aa))
        {
            return paragraph.Format.method_55(0x5a0);
        }
        return true;
    }

    internal static bool smethod_7(Paragraph A_0)
    {
        return smethod_6(A_0, A_0);
    }
}

