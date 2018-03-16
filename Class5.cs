using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Text;

internal class Class5 : ParagraphBase
{
    private Class18 class18_0;

    internal Class5(Document A_0, Class18 A_1) : this(A_0, A_1, new CharacterFormat(A_0))
    {
    }

    internal Class5(Document A_0, Class18 A_1, CharacterFormat A_2) : base(A_0)
    {
        int num = 11;
        this.class18_0 = A_1;
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌰䘲嬴朶䬸", num));
        }
        base.m_charFormat = A_2;
    }

    internal bool method_30(DocumentObject A_0)
    {
        return this.class18_0.vmethod_0(A_0);
    }

    public Paragraph method_31()
    {
        return (Paragraph) base.GetAncestor(DocumentObjectType.Paragraph);
    }

    internal Class18 method_32()
    {
        return this.class18_0;
    }

    internal CharacterFormat method_33()
    {
        return base.m_charFormat;
    }

    private Paragraph method_34()
    {
        return this.method_31();
    }

    private Document method_35()
    {
        return base.Document;
    }

    private CharacterFormat method_36()
    {
        return base.m_charFormat;
    }

    private void method_37(CharacterFormat A_0)
    {
        base.m_charFormat = A_0;
    }

    internal string method_38()
    {
        int num = 0x12;
        StringBuilder builder = new StringBuilder(this.DocumentObjectType.ToString());
        builder.Append(' ');
        for (DocumentObject obj2 = this; obj2 != null; obj2 = obj2.ParentObject)
        {
            if (obj2.ParentObject == null)
            {
                break;
            }
            int num2 = 0;
            for (DocumentObject obj3 = obj2.ParentObject.FirstChild; obj3 != null; obj3 = obj3.NextSibling as DocumentObject)
            {
                if (obj3 == obj2)
                {
                    break;
                }
                num2++;
            }
            builder.AppendFormat(BookmarkStart.b("䌷ਹ䄻䔽焿㽁", num), (obj2 == this) ? "" : BookmarkStart.b("ᘷ", num), num2);
        }
        return builder.ToString();
    }

    void DocumentBase.CreateLayoutInfo()
    {
        throw new NotImplementedException();
    }

    VisitorAction DocumentObject.AcceptEnd(Class420 A_0)
    {
        return A_0.vmethod_39(this);
    }

    VisitorAction DocumentObject.AcceptStart(Class420 A_0)
    {
        return A_0.vmethod_38(this);
    }

    bool ParagraphBase.Accept(Class420 A_0)
    {
        return base.method_9(A_0);
    }

    object ParagraphBase.CloneImpl()
    {
        Class5 class2 = (Class5) base.Clone();
        class2.m_charFormat = (CharacterFormat) base.m_charFormat.Clone();
        class2.class18_0 = (Class18) this.class18_0.Clone();
        return class2;
    }

    public override DocumentObjectType Spire.Doc.DocumentObject.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.OfficeMath;
        }
    }
}

