using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

internal abstract class Class581 : Interface50, Interface58
{
    private readonly ArrayList arrayList_0;
    private readonly ArrayList arrayList_1;
    private readonly ArrayList arrayList_2;
    private bool bool_0;
    private bool bool_1;
    private readonly Class389 class389_0;
    private readonly Class861 class861_0;
    private Dictionary<int, Comment> dictionary_0;
    private readonly Document document_0;
    private DocumentObject documentObject_0;
    private readonly Hashtable hashtable_0;
    private readonly Hashtable hashtable_1;
    private readonly Hashtable hashtable_2;
    private readonly Hashtable hashtable_3;
    private readonly Hashtable hashtable_4;
    private Hashtable hashtable_5;
    private Hashtable hashtable_6;
    private readonly Hashtable hashtable_7;
    private readonly Hashtable hashtable_8;
    private List<CommentMark> list_0;
    internal Stack<Class579> stack_0;

    protected Class581(Document A_0)
    {
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.hashtable_0 = new Hashtable();
        this.hashtable_1 = new Hashtable();
        this.hashtable_2 = new Hashtable();
        this.hashtable_3 = new Hashtable();
        this.hashtable_4 = new Hashtable();
        this.hashtable_7 = new Hashtable();
        this.hashtable_8 = new Hashtable();
        this.document_0 = A_0;
        this.documentObject_0 = A_0;
    }

    protected Class581(Document A_0, Class861 A_1)
    {
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.hashtable_0 = new Hashtable();
        this.hashtable_1 = new Hashtable();
        this.hashtable_2 = new Hashtable();
        this.hashtable_3 = new Hashtable();
        this.hashtable_4 = new Hashtable();
        this.hashtable_7 = new Hashtable();
        this.hashtable_8 = new Hashtable();
        this.document_0 = A_0;
        this.documentObject_0 = A_0;
        this.class389_0 = new Class389();
        this.class861_0 = A_1;
    }

    public abstract Class394 imethod_1();
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract void imethod_10(ShapeBase A_0);
    private void imethod_11(string A_0, Class43 A_1)
    {
        if (Class567.smethod_16(A_0))
        {
            this.hashtable_8[A_0] = A_1;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract DocOleObject imethod_2(string A_0, DocOleObject A_1);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract byte[] imethod_3(string A_0);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract string imethod_4(string A_0);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract bool imethod_5(string A_0);
    private void imethod_7(string A_0, ShapeBase A_1)
    {
        this.hashtable_0[A_0] = A_1;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract void imethod_9();
    Document Interface50.imethod_0()
    {
        return this.document_0;
    }

    Class43 Interface50.imethod_12(string A_0)
    {
        if (A_0.StartsWith(BookmarkStart.b("ᔵ", 0x10)))
        {
            A_0 = A_0.Substring(1);
        }
        if (!Class567.smethod_16(A_0))
        {
            return null;
        }
        return (Class43) this.hashtable_8[A_0];
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Interface50.imethod_6(ShapeBase A_0)
    {
        if (this.bool_0)
        {
            this.arrayList_1.Add(A_0);
        }
        else
        {
            this.arrayList_2.Add(A_0);
        }
    }

    ShapeBase Interface50.imethod_8(string A_0)
    {
        return (ShapeBase) this.hashtable_0[A_0];
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    int Interface58.imethod_0(object A_0, int A_1)
    {
        object obj2 = this.hashtable_1[A_0];
        if (obj2 == null)
        {
            return A_1;
        }
        return (int) obj2;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Interface58.imethod_1(object A_0, int A_1)
    {
        this.hashtable_1[A_0] = A_1;
    }

    protected void method_0()
    {
        smethod_0(this.arrayList_1);
        smethod_0(this.arrayList_2);
    }

    protected void method_1()
    {
        foreach (ShapeBase base2 in this.hashtable_0.Values)
        {
            string str = null;
            if (base2.ShapePr.method_6(0x8e))
            {
                str = (string) base2.ShapePr[0x8e];
            }
            if (Class567.smethod_16(str))
            {
                ShapeBase base3 = (ShapeBase) this.hashtable_0[str];
                if (base3 != null)
                {
                    base2.SetShapeAttribute(0x8a, base3.Id);
                }
                base2.ShapePr.Remove(0x8e);
            }
        }
    }

    internal void method_10(DocumentObject A_0, DocumentObject A_1, DocumentObject A_2)
    {
        this.method_12(A_0, A_1, A_2, false);
    }

    internal void method_11(DocumentObject A_0, DocumentObject A_1, DocumentObject A_2)
    {
        this.method_12(A_0, A_1, A_2, true);
    }

    private void method_12(DocumentObject A_0, DocumentObject A_1, DocumentObject A_2, bool A_3)
    {
        if (A_3)
        {
            if (A_2 == A_0.LastChild)
            {
                A_0.method_13(A_1);
            }
            else
            {
                A_0.method_17(A_1, A_2);
            }
        }
        else
        {
            A_0.method_18(A_1, A_2);
        }
        ParagraphBase base2 = A_1 as ParagraphBase;
        if (base2 != null)
        {
            CharacterFormat characterFormat = base2.CharacterFormat;
            if ((this.stack_0 != null) && (this.stack_0.Count > 0))
            {
                if (this.stack_0.Peek().method_4() == EditRevisionType.Deletion)
                {
                    characterFormat.IsDeleteRevision = true;
                    characterFormat.DeleteRevision = this.stack_0.Peek();
                }
                else
                {
                    characterFormat.IsInsertRevision = true;
                    characterFormat.InsertRevision = this.stack_0.Peek();
                }
            }
        }
    }

    internal DocumentObject method_13()
    {
        return this.documentObject_0;
    }

    internal void method_14(DocumentObject A_0)
    {
        this.documentObject_0 = A_0;
    }

    internal bool method_15()
    {
        return this.bool_0;
    }

    internal void method_16(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal Hashtable method_17()
    {
        return this.hashtable_2;
    }

    internal Hashtable method_18()
    {
        return this.hashtable_3;
    }

    internal Hashtable method_19()
    {
        return this.hashtable_4;
    }

    internal byte[] method_2(byte[] A_0)
    {
        Guid key = Class968.smethod_0(A_0);
        if (!this.hashtable_7.ContainsKey(key))
        {
            this.hashtable_7.Add(key, A_0);
            return A_0;
        }
        return (byte[]) this.hashtable_7[key];
    }

    internal Dictionary<string, string> method_20()
    {
        return this.Interface50.imethod_0().ListStyles.ListStyleNames;
    }

    internal Hashtable method_21()
    {
        if (this.hashtable_6 == null)
        {
            this.hashtable_6 = new Hashtable();
        }
        return this.hashtable_6;
    }

    internal bool method_22()
    {
        return this.bool_1;
    }

    internal void method_23(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal Class861 method_24()
    {
        return this.class861_0;
    }

    internal Dictionary<int, Comment> method_25()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<int, Comment>();
        }
        return this.dictionary_0;
    }

    internal List<CommentMark> method_26()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<CommentMark>();
        }
        return this.list_0;
    }

    internal void method_3(DocumentObject A_0)
    {
        this.documentObject_0.method_13(A_0);
        this.documentObject_0 = A_0;
    }

    internal void method_4(DocumentObject A_0)
    {
        this.documentObject_0 = A_0;
    }

    internal void method_5(DocumentObjectType A_0)
    {
        int num = 0x10;
        if (this.documentObject_0.DocumentObjectType != A_0)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("愵儷䤹夻ḽ㬿牁㥃晅⩇㽉㡋湍⭏捑⥓硕", num), A_0, this.documentObject_0.DocumentObjectType));
        }
        if (this.documentObject_0.DocumentObjectType == DocumentObjectType.Body)
        {
            this.method_8(((Body) this.documentObject_0).method_44());
        }
        this.documentObject_0 = this.documentObject_0.ParentObject;
    }

    internal void method_6(DocumentObject A_0)
    {
        if (this.documentObject_0.DocumentObjectType == DocumentObjectType.Paragraph)
        {
            this.method_9(A_0);
        }
        else
        {
            this.arrayList_0.Add(A_0);
        }
    }

    internal void method_7()
    {
        this.method_8((Paragraph) this.documentObject_0);
    }

    private void method_8(IParagraph A_0)
    {
        if (A_0 == null)
        {
            A_0 = new Paragraph(this.Interface50.imethod_0());
            this.documentObject_0.method_13(A_0);
        }
        foreach (DocumentObject obj2 in this.arrayList_0)
        {
            ((Paragraph) A_0).method_13(obj2);
        }
        this.arrayList_0.Clear();
    }

    internal void method_9(DocumentObject A_0)
    {
        this.method_11(this.documentObject_0, A_0, this.documentObject_0.LastChild);
    }

    private static void smethod_0(ArrayList A_0)
    {
        if (A_0.Count != 0)
        {
            A_0.Sort(new Class823());
        }
    }

    internal abstract bool vmethod_0();
    internal abstract bool vmethod_1();
    internal abstract Footnote vmethod_2(FootnoteType A_0, int A_1);
    internal abstract void vmethod_3(Comment A_0);
    internal abstract Comment vmethod_4(int A_0);
    internal abstract bool vmethod_5();
}

