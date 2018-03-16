using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

internal class Class466 : Interface50
{
    private readonly Class394 class394_0;
    private readonly Class563 class563_0;
    private Dictionary<string, ShapeBase> dictionary_0;
    private Dictionary<string, Class43> dictionary_1;
    private readonly Document document_0;
    private static readonly Hashtable hashtable_0 = new Hashtable();

    static Class466()
    {
        hashtable_0.Add(BookmarkStart.b("娫", 6), BookmarkStart.b("夫尭帯࠱䜳唵倷弹儻弽㌿潁⥃⽅⭇㡉⍋㵍㽏㑑⁓筕㭗㕙ㅛ摝ᙟཡࡣ", 6));
        hashtable_0.Add(BookmarkStart.b("䌫", 6), BookmarkStart.b("夫尭帯࠱䜳唵倷弹儻弽㌿潁⥃⽅⭇㡉⍋㵍㽏㑑⁓筕㭗㕙ㅛ摝ཟѡɣཥ୧ཀྵ噫ŭᙯᑱᵳᕵᵷ", 6));
    }

    internal Class466(Stream A_0)
    {
        this.dictionary_0 = new Dictionary<string, ShapeBase>();
        this.dictionary_1 = new Dictionary<string, Class43>();
        this.class394_0 = new Class394(A_0);
    }

    internal Class466(string A_0)
    {
        this.dictionary_0 = new Dictionary<string, ShapeBase>();
        this.dictionary_1 = new Dictionary<string, Class43>();
        this.class394_0 = new Class394(A_0, hashtable_0);
    }

    internal Class466(Stream A_0, Document A_1) : this(A_0)
    {
        this.document_0 = A_1;
    }

    internal Class466(Stream A_0, Document A_1, Class563 A_2) : this(A_0, A_1)
    {
        this.class563_0 = A_2;
    }

    private void imethod_11(string A_0, Class43 A_1)
    {
        if (!this.dictionary_1.ContainsKey(A_0))
        {
            this.dictionary_1.Add(A_0, A_1);
        }
        else
        {
            this.dictionary_1[A_0] = A_1;
        }
    }

    private void imethod_7(string A_0, ShapeBase A_1)
    {
        if (!this.dictionary_0.ContainsKey(A_0))
        {
            this.dictionary_0.Add(A_0, A_1);
        }
        else
        {
            this.dictionary_0[A_0] = A_1;
        }
    }

    private ShapeBase imethod_8(string A_0)
    {
        if (this.dictionary_0.ContainsKey(A_0))
        {
            return this.dictionary_0[A_0];
        }
        return null;
    }

    Document Interface50.imethod_0()
    {
        return this.document_0;
    }

    Class394 Interface50.imethod_1()
    {
        return this.class394_0;
    }

    void Interface50.imethod_10(ShapeBase A_0)
    {
        this.method_0().method_229(this.class394_0.method_8(), A_0);
    }

    Class43 Interface50.imethod_12(string A_0)
    {
        if (A_0.StartsWith(BookmarkStart.b("ᜳ", 14)))
        {
            A_0 = A_0.TrimStart(new char[] { '#' });
        }
        if (this.dictionary_1.ContainsKey(A_0))
        {
            return this.dictionary_1[A_0];
        }
        return null;
    }

    DocOleObject Interface50.imethod_2(string A_0, DocOleObject A_1)
    {
        Class229 class2 = this.method_0().method_183(A_0);
        if (class2 == null)
        {
            return null;
        }
        byte[] buffer = null;
        class2.method_4().Position = 0L;
        A_1.stream_1 = class2.method_4();
        if (this.method_0().method_185(A_1.OleObjectType))
        {
            buffer = new byte[class2.method_4().Length];
            class2.method_4().Read(buffer, 0, buffer.Length);
        }
        else
        {
            Class1004 class3 = null;
            class3 = new Class1004(class2.method_4());
            Class1116 class4 = new Class1116();
            class4.method_4(class3.Interface51.imethod_0());
            buffer = class4.method_0();
            if (A_1.OleObjectType == OleObjectType.Package)
            {
                A_1.method_105(class4.method_2(), class4.method_3());
            }
        }
        class2.method_4().Position = 0L;
        A_1.SetNativeData(buffer);
        A_1.method_102(buffer, string.Empty);
        return A_1;
    }

    byte[] Interface50.imethod_3(string A_0)
    {
        string key = this.method_0().method_459(A_0, false, false);
        if (this.method_0().method_0().ContainsKey(key))
        {
            return this.document_0.Images.method_0(this.method_0().method_0()[key]).method_3();
        }
        byte[] buffer = this.method_0().method_460(key);
        Class517 class3 = new Class517(buffer);
        this.document_0.Images.method_2(class3);
        this.method_0().method_0().Add(key, class3.method_0());
        return buffer;
    }

    string Interface50.imethod_4(string A_0)
    {
        return null;
    }

    bool Interface50.imethod_5(string A_0)
    {
        return false;
    }

    void Interface50.imethod_6(ShapeBase A_0)
    {
    }

    void Interface50.imethod_9()
    {
    }

    internal Class563 method_0()
    {
        return this.class563_0;
    }
}

