using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using System;
using System.Collections;

internal class Class471
{
    private readonly Class422 class422_0;

    internal Class471(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal VisitorAction method_0(BookmarkStart A_0)
    {
        int num = 0x10;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            if ((this.class422_0.method_67() && !this.class422_0.method_69()) && this.class422_0.method_21())
            {
                this.class422_0.method_61().Add(A_0);
            }
            if (this.method_3(A_0))
            {
                return VisitorAction.Continue;
            }
            if (smethod_0(A_0))
            {
                this.method_2(BookmarkStart.b("䈵崷䈹䠻н∿ⵁ⭃ⵅ╇⭉㹋╍絏⅑⁓㝕⩗⹙", num), A_0.Name);
            }
            else
            {
                this.method_2(BookmarkStart.b("䈵崷䈹䠻н∿ⵁ⭃ⵅ╇⭉㹋╍絏⅑⁓㝕⩗⹙", num), A_0.Name);
                this.method_2(BookmarkStart.b("䈵崷䈹䠻н∿ⵁ⭃ⵅ╇⭉㹋╍絏㝑㩓㉕", num), A_0.Name);
            }
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(BookmarkEnd A_0)
    {
        int num = 0;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            if ((this.class422_0.method_67() && !this.class422_0.method_69()) && this.class422_0.method_21())
            {
                this.class422_0.method_61().Add(A_0);
            }
            if (this.method_3(A_0))
            {
                return VisitorAction.Continue;
            }
            if (smethod_1(A_0))
            {
                if (this.method_4(A_0))
                {
                    this.method_2(BookmarkStart.b("別䴧利堫ᐭ刯崱嬳崵唷嬹主唽洿ㅁぃ❅㩇㹉", num), A_0.Name);
                }
                this.method_2(BookmarkStart.b("別䴧利堫ᐭ刯崱嬳崵唷嬹主唽洿❁⩃≅", num), A_0.Name);
            }
        }
        return VisitorAction.Continue;
    }

    private void method_2(string A_0, string A_1)
    {
        this.class422_0.method_18().method_66(A_0);
        this.class422_0.method_18().method_68(BookmarkStart.b("䐯圱䰳䈵ȷ吹崻匽┿", 10), A_1);
        this.class422_0.method_18().method_9(BookmarkStart.b("Ἧఱ", 10));
    }

    private bool method_3(DocumentObject A_0)
    {
        if ((!this.class422_0.method_67() || this.class422_0.method_69()) && ((this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters) && !this.class422_0.method_21()))
        {
            return (!Class422.smethod_1(A_0) && this.class422_0.method_20());
        }
        return true;
    }

    private bool method_4(BookmarkEnd A_0)
    {
        bool flag;
        using (IEnumerator enumerator = this.class422_0.method_61().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                object current = enumerator.Current;
                if ((current is BookmarkStart) && ((current as BookmarkStart).Name == A_0.Name))
                {
                    goto Label_0045;
                }
            }
            return false;
        Label_0045:
            flag = true;
        }
        return flag;
    }

    private bool method_5(BookmarkStart A_0)
    {
        bool flag;
        using (IEnumerator enumerator = this.class422_0.method_61().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                object current = enumerator.Current;
                if ((current is BookmarkEnd) && ((current as BookmarkEnd).Name == A_0.Name))
                {
                    goto Label_0045;
                }
            }
            return false;
        Label_0045:
            flag = true;
        }
        return flag;
    }

    private static bool smethod_0(BookmarkStart A_0)
    {
        return true;
    }

    private static bool smethod_1(BookmarkEnd A_0)
    {
        if (A_0.ParentObject is Paragraph)
        {
            Paragraph parentObject = (Paragraph) A_0.ParentObject;
            if (parentObject.IsInCell)
            {
                return (((TableCell) parentObject.OwnerTextBody).Document.Bookmarks[A_0.Name] != null);
            }
        }
        return true;
    }
}

