using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using System;

internal class Class850
{
    private readonly Class422 class422_0;

    internal Class850(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal VisitorAction method_0(HeaderFooter A_0)
    {
        if (this.class422_0.method_20())
        {
            return VisitorAction.SkipThisElement;
        }
        if (this.class422_0.method_23() == OpenDocumentWritingStage.StylesMasterPage)
        {
            this.class422_0.method_18().method_4(smethod_0(A_0));
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(HeaderFooter A_0)
    {
        if (this.class422_0.method_23() == OpenDocumentWritingStage.StylesMasterPage)
        {
            this.class422_0.method_18().method_6(smethod_0(A_0));
        }
        return VisitorAction.Continue;
    }

    private static string smethod_0(HeaderFooter A_0)
    {
        int num = 0;
        string str = A_0.IsHeader ? BookmarkStart.b("唥尧匩䀫䬭ਯ娱儳圵尷弹主", num) : BookmarkStart.b("唥尧匩䀫䬭ਯ吱嬳夵䰷弹主", num);
        if ((A_0.Type != HeaderFooterType.HeaderEven) && (A_0.Type != HeaderFooterType.FooterEven))
        {
            return str;
        }
        return string.Format(BookmarkStart.b("崥ᠧ圩ī䈭唯吱䀳", num), str);
    }
}

