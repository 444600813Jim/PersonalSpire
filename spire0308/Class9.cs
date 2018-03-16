using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using System;

internal class Class9 : DocumentObject, Interface60
{
    private Class457 class457_0;
    private DocumentObjectCollection documentObjectCollection_0;
    private readonly MarkupLevel markupLevel_0;
    private string string_5;
    private string string_6;
    private string string_7;

    public Class9(Document A_0, MarkupLevel A_1) : base(A_0, A_0)
    {
        this.string_5 = "";
        this.string_6 = "";
        this.string_7 = "";
        this.class457_0 = new Class457();
        this.markupLevel_0 = A_1;
    }

    MarkupLevel Interface60.imethod_0()
    {
        return this.method_29();
    }

    internal Class9 method_21(bool A_0)
    {
        Class9 class2 = (Class9) base.Clone();
        class2.class457_0 = this.class457_0.method_10();
        return class2;
    }

    public string method_22()
    {
        return this.string_6;
    }

    public void method_23(string A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("戦䔨个䀬䨮弰䜲", num));
        }
        this.string_6 = A_0;
    }

    public string method_24()
    {
        return this.string_5;
    }

    public void method_25(string A_0)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("搳娵夷夹夻嘽⼿⹁⁃⍅㩇", num));
        }
        this.string_5 = A_0;
    }

    public string method_26()
    {
        return this.string_7;
    }

    public void method_27(string A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("礫尭夯", num));
        }
        this.string_7 = A_0;
    }

    public Class457 method_28()
    {
        return this.class457_0;
    }

    public MarkupLevel method_29()
    {
        return this.markupLevel_0;
    }

    bool DocumentObject.Accept(Class420 A_0)
    {
        return base.method_9(A_0);
    }

    VisitorAction DocumentObject.AcceptEnd(Class420 A_0)
    {
        return A_0.vmethod_41(this);
    }

    VisitorAction DocumentObject.AcceptStart(Class420 A_0)
    {
        return A_0.vmethod_40(this);
    }

    DocumentObjectCollection DocumentObject.ChildObjects
    {
        get
        {
            return this.documentObjectCollection_0;
        }
    }

    public override DocumentObjectType Spire.Doc.DocumentObject.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.CustomXml;
        }
    }
}

