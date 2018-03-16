using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class685 : Interface48
{
    [CompilerGenerated]
    private bool bool_0;
    private Class398 class398_0;
    private readonly Class465 class465_0;
    private Dictionary<int, string> dictionary_0;
    private readonly Document document_0;
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private Stream stream_0;

    static Class685()
    {
        hashtable_0.Add(BookmarkStart.b("䜰", 11), BookmarkStart.b("䐰䄲嬴ശ䨸堺唼娾ⱀ≂㙄橆⑈≊⹌㵎㹐⁒㩔ㅖⵘ癚㹜ぞౠ奢፤੦ը", 11));
        hashtable_0.Add(BookmarkStart.b("帰", 11), BookmarkStart.b("䐰䄲嬴ശ䨸堺唼娾ⱀ≂㙄橆⑈≊⹌㵎㹐⁒㩔ㅖⵘ癚㹜ぞౠ奢੤Ŧཨɪ๬੮䭰ᱲ፴ᅶၸ᡺᡼", 11));
    }

    internal Class685(Class1092 A_0)
    {
        this.stream_0 = new MemoryStream();
        this.class398_0 = new Class398(A_0, true, true);
    }

    internal Class685(Stream A_0)
    {
        this.stream_0 = new MemoryStream();
        this.class398_0 = new Class398(A_0, Encoding.UTF8, true, true);
    }

    internal Class685(Class1092 A_0, Document A_1) : this(A_0)
    {
        this.document_0 = A_1;
    }

    internal Class685(Stream A_0, Document A_1) : this(A_0)
    {
        this.document_0 = A_1;
    }

    internal Class685(Class1092 A_0, Document A_1, Class465 A_2) : this(A_0, A_1)
    {
        this.class465_0 = A_2;
    }

    internal Class685(Stream A_0, Document A_1, Class465 A_2) : this(A_0, A_1)
    {
        this.class465_0 = A_2;
    }

    private string imethod_0(int A_0)
    {
        int num = 0x12;
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<int, string>();
            foreach (ShapeBase base2 in this.document_0.GetChildElements(DocumentObjectType.Shape, true))
            {
                string name = base2.Name;
                if (name.StartsWith(BookmarkStart.b("朷䤹", num)))
                {
                    this.dictionary_0[Class734.smethod_26(name)] = name;
                }
            }
        }
        return this.dictionary_0[A_0];
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string imethod_1(byte[] A_0)
    {
        return string.Empty;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string imethod_2(string A_0)
    {
        return string.Empty;
    }

    [CompilerGenerated]
    public void imethod_8(bool A_0)
    {
        this.bool_0 = A_0;
    }

    ArrayList Interface48.imethod_3()
    {
        return new ArrayList();
    }

    Class928 Interface48.imethod_4()
    {
        return new Class928(this.document_0, this.stream_0, string.Empty, Class253.smethod_0(FileFormat.WordML));
    }

    string Interface48.imethod_5()
    {
        return BookmarkStart.b("䀱ำ張尷", 12);
    }

    string Interface48.imethod_6()
    {
        return BookmarkStart.b("䘳వ倷䠹夻堽", 14);
    }

    [CompilerGenerated]
    bool Interface48.imethod_7()
    {
        return this.bool_0;
    }

    internal Class465 method_0()
    {
        return this.class465_0;
    }

    public string method_1(DocPicture A_0)
    {
        return this.method_0().method_335(A_0, false, null);
    }
}

