using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;

internal class Class4 : ParagraphBase
{
    private string string_8;

    internal Class4(Document A_0, string A_1) : base(A_0)
    {
        this.method_31(A_1);
    }

    internal string method_30()
    {
        return this.string_8;
    }

    internal void method_31(string A_0)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("䨫䜭尯圱稳圵唷弹", 6));
        this.string_8 = A_0;
    }

    void DocumentBase.CreateLayoutInfo()
    {
        throw new NotImplementedException();
    }

    bool ParagraphBase.Accept(Class420 A_0)
    {
        return base.method_12(A_0.vmethod_50(this));
    }

    public override DocumentObjectType Spire.Doc.Interface.IDocumentObject.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.SubDocument;
        }
    }
}

