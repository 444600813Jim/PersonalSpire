using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class8 : Paragraph
{
    private Body body_1;
    private readonly FootnoteSeparatorType footnoteSeparatorType_0;

    internal Class8(Document A_0, FootnoteSeparatorType A_1) : base(A_0)
    {
        this.footnoteSeparatorType_0 = A_1;
    }

    internal VisitorAction method_100(Class420 A_0)
    {
        return VisitorAction.Continue;
    }

    internal VisitorAction method_101(Class420 A_0)
    {
        return VisitorAction.Continue;
    }

    internal bool method_102(DocumentObject A_0)
    {
        return true;
    }

    internal FootnoteSeparatorType method_103()
    {
        return this.footnoteSeparatorType_0;
    }

    public Body method_104()
    {
        return this.body_1;
    }

    public void method_105(Body A_0)
    {
        this.body_1 = A_0;
    }

    public override DocumentObjectType Spire.Doc.Documents.Paragraph.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.System;
        }
    }
}

