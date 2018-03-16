using Spire.Doc;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using System;

internal class Class918
{
    private readonly Class422 class422_0;
    private readonly Class974 class974_0;

    internal Class918(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class974_0 = new Class974(this.class422_0);
    }

    internal VisitorAction method_0(Section A_0)
    {
        int num = 0x11;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            this.class422_0.method_17(A_0);
            Document document = A_0.Document;
            if ((document.Sections.Count > 1) || document.Settings.method_5().method_13())
            {
                if (this.class422_0.method_21())
                {
                    this.class974_0.method_9(A_0);
                }
                else if (this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters)
                {
                    Class400 class2 = this.class422_0.method_18();
                    if (this.class422_0.method_101())
                    {
                        class2.method_10(BookmarkStart.b("䌶尸䌺䤼Ծ㉀ⱂ⍄㍆摈㭊ⱌ⡎㑐繒㝔╖㱘㩚㙜", num));
                        return VisitorAction.Continue;
                    }
                    class2.method_4(BookmarkStart.b("䌶尸䌺䤼Ծ㉀♂♄㍆⁈⑊⍌", num));
                    class2.method_40(BookmarkStart.b("䌶尸䌺䤼Ծ㉀㝂㱄⭆ⱈ晊⍌⹎㱐㙒", num), this.class974_0.method_30());
                    class2.method_40(BookmarkStart.b("䌶尸䌺䤼Ծ⽀≂⡄≆", num), this.class974_0.method_30());
                    if (document.ProtectionType == ProtectionType.AllowOnlyFormFields)
                    {
                        class2.method_40(BookmarkStart.b("䌶尸䌺䤼Ծㅀㅂ⩄㍆ⱈ⡊㥌⩎㕐", num), A_0.SectPr.method_124() ? BookmarkStart.b("儶堸场丼娾", num) : BookmarkStart.b("䌶䬸为堼", num));
                    }
                }
            }
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(Section A_0)
    {
        int num = 9;
        if (((this.class422_0.method_23() != OpenDocumentWritingStage.MathML) && !this.class422_0.method_101()) && ((!this.class422_0.method_21() && (A_0.Document.Sections.Count > 1)) && (this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters)))
        {
            this.class422_0.method_18().method_6(BookmarkStart.b("嬮吰䬲䄴ശ䨸帺帼䬾⡀ⱂ⭄", num));
        }
        return VisitorAction.Continue;
    }
}

