using Spire.Doc;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using System;

internal class Class528
{
    private readonly Class422 class422_0;
    private readonly Class691 class691_0;
    private readonly Class974 class974_0;

    internal Class528(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class691_0 = new Class691(this.class422_0);
        this.class974_0 = new Class974(this.class422_0);
    }

    internal VisitorAction method_0(Comment A_0)
    {
        int num = 11;
        if ((A_0.ParentObject is Class5) && !this.class422_0.method_99())
        {
            return VisitorAction.SkipThisElement;
        }
        this.class422_0.method_64(true);
        if (this.class422_0.method_21())
        {
            this.class974_0.method_3(A_0);
        }
        else if (this.class422_0.method_23() == OpenDocumentWritingStage.ContentBody)
        {
            Class400 class2 = this.class422_0.method_18();
            this.class691_0.method_1();
            class2.method_4(BookmarkStart.b("帰唲匴帶娸帺ܼ帾⽀ⵂ⩄㍆⡈㽊⑌⁎㽐", num));
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(Comment A_0)
    {
        int num = 0x13;
        if (this.class422_0.method_23() == OpenDocumentWritingStage.ContentBody)
        {
            this.class422_0.method_18().method_6(BookmarkStart.b("嘸崺嬼嘾≀♂罄♆❈╊≌㭎ぐ❒㱔㡖㝘", num));
            this.class691_0.method_2();
        }
        this.class422_0.method_64(false);
        return VisitorAction.Continue;
    }
}

