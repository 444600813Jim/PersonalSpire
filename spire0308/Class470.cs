using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using System;
using System.Collections;

internal class Class470
{
    private bool bool_0;
    private readonly Class422 class422_0;
    private readonly Class974 class974_0;
    private readonly Stack stack_0 = new Stack();

    internal Class470(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class974_0 = new Class974(this.class422_0);
        this.bool_0 = false;
    }

    internal VisitorAction method_0(Footnote A_0)
    {
        int num = 0;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            if ((A_0.FootnoteType == FootnoteType.Endnote) && !this.class422_0.method_77())
            {
                this.class422_0.method_78(true);
            }
            if ((A_0.OwnerParagraph.OwnerTextBody.DocumentObjectType == DocumentObjectType.Body) || !this.class422_0.method_20())
            {
                if (this.class422_0.method_21())
                {
                    if (!A_0.IsAutoNumbered)
                    {
                        this.method_2(A_0);
                    }
                    if (!A_0.OwnerParagraph.Format.HasKey(0x532))
                    {
                        this.class974_0.method_4(A_0);
                    }
                }
                else if (this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters)
                {
                    Class400 class2 = this.class422_0.method_18();
                    class2.method_66(BookmarkStart.b("別䴧利堫ᐭ䌯䈱唳堵", num));
                    class2.method_69(BookmarkStart.b("別䴧利堫ᐭ䌯䘱䴳娵崷᜹刻弽ⴿ❁", num), this.class974_0.method_27());
                    class2.method_4(BookmarkStart.b("別䴧利堫ᐭ帯崱䀳匵", num));
                    class2.method_40(BookmarkStart.b("別䴧利堫ᐭ帯崱䀳匵ᔷ夹倻弽㌿ㅁ", num), (A_0.FootnoteType == FootnoteType.Endnote) ? BookmarkStart.b("䌥䘧丩䈫䄭䐯圱", num) : BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳", num));
                    class2.method_4(BookmarkStart.b("別䴧利堫ᐭ帯崱䀳匵ᔷ夹唻䨽ℿ㙁ⵃ⥅♇", num));
                    if (!A_0.IsAutoNumbered)
                    {
                        class2.method_40(BookmarkStart.b("別䴧利堫ᐭ尯匱嘳匵吷", num), A_0.CustomMarker);
                        class2.method_15(A_0.CustomMarker);
                    }
                    class2.method_6(BookmarkStart.b("別䴧利堫ᐭ帯崱䀳匵ᔷ夹唻䨽ℿ㙁ⵃ⥅♇", num));
                    class2.method_4(BookmarkStart.b("別䴧利堫ᐭ帯崱䀳匵ᔷ堹医娽㤿", num));
                }
            }
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(Footnote A_0)
    {
        int num = 0x13;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            Class400 class2 = this.class422_0.method_18();
            if (((A_0.OwnerParagraph.OwnerTextBody.DocumentObjectType == DocumentObjectType.Body) || !this.class422_0.method_20()) && (!this.class422_0.method_21() && (this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters)))
            {
                class2.method_6(BookmarkStart.b("䴸帺䔼䬾筀ⵂ⩄㍆ⱈ晊⽌⁎㕐⩒", num));
                class2.method_6(BookmarkStart.b("䴸帺䔼䬾筀ⵂ⩄㍆ⱈ", num));
                class2.method_67(BookmarkStart.b("䴸帺䔼䬾筀あ㕄♆❈", num));
                this.method_3(A_0);
            }
        }
        return VisitorAction.Continue;
    }

    private void method_2(Footnote A_0)
    {
        int length = A_0.CustomMarker.Length;
        Paragraph paragraph = (Paragraph) A_0.GetChildElements(4, 1)[0];
        TextRange range = (TextRange) paragraph.GetChildElements(0x10, 1)[0];
        while (range.TextLength <= length)
        {
            TextRange nextSibling = (TextRange) range.NextSibling;
            this.stack_0.Push(range);
            range.method_19();
            length -= range.TextLength;
            range = nextSibling;
            if (((length <= 0) || (range == null)) || (range.DocumentObjectType != DocumentObjectType.TextRange))
            {
                return;
            }
        }
        this.bool_0 = true;
        this.stack_0.Push(range.Clone());
        range.Text.Substring(length, range.TextLength - length);
    }

    private void method_3(Footnote A_0)
    {
        Paragraph paragraph = Class1099.smethod_20(A_0.TextBody.ChildObjects);
        if (this.bool_0)
        {
            paragraph.FirstTextRange.method_19();
            this.bool_0 = false;
        }
        while (this.stack_0.Count > 0)
        {
            paragraph.method_18((TextRange) this.stack_0.Pop(), paragraph.FirstTextRange);
        }
    }
}

