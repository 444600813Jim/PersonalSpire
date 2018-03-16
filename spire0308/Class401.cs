using Spire.Compression.Zip;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

internal class Class401 : Interface48
{
    private ArrayList arrayList_0;
    [CompilerGenerated]
    private bool bool_0;
    private readonly Class399 class399_0;
    private readonly Class465 class465_0;
    private readonly Class800 class800_0;
    private readonly Class928 class928_0;
    private readonly Document document_0;
    internal Hashtable hashtable_0;
    private Hashtable hashtable_1;
    private int int_0;
    private MemoryStream memoryStream_0;

    internal Class401(Class928 A_0, Class399 A_1)
    {
        this.hashtable_0 = new Hashtable();
        this.int_0 = 1;
        this.class928_0 = A_0;
        this.class399_0 = A_1;
        this.class800_0 = new Class800(this.class928_0.document_0.Styles);
    }

    internal Class401(Class928 A_0, Document A_1, Class399 A_2)
    {
        this.hashtable_0 = new Hashtable();
        this.int_0 = 1;
        this.class928_0 = A_0;
        this.document_0 = A_1;
        this.class399_0 = A_2;
        this.class800_0 = new Class800(this.document_0.Styles);
    }

    internal Class401(Class928 A_0, Document A_1, Class399 A_2, Class465 A_3)
    {
        this.hashtable_0 = new Hashtable();
        this.int_0 = 1;
        this.class928_0 = A_0;
        this.document_0 = A_1;
        this.class399_0 = A_2;
        this.class465_0 = A_3;
        if (A_3 == null)
        {
            this.class800_0 = new Class800(this.document_0.Styles);
        }
    }

    private string imethod_0(int A_0)
    {
        int num = 10;
        if (this.hashtable_1 == null)
        {
            this.hashtable_1 = new Hashtable();
            foreach (ShapeObject obj2 in this.method_0().GetChildElements(DocumentObjectType.Shape, true))
            {
                string name = obj2.Name;
                if (name.StartsWith(BookmarkStart.b("漯䄱", num)))
                {
                    this.hashtable_1[Class734.smethod_26(name)] = name;
                }
            }
        }
        return (this.hashtable_1[A_0] as string);
    }

    private string imethod_1(byte[] A_0)
    {
        string str;
        string str2;
        int num = 3;
        Guid key = Class968.smethod_0(A_0);
        if (this.hashtable_0.ContainsKey(key))
        {
            return (string) this.hashtable_0[key];
        }
        ImageFormat format = Class409.smethod_0(A_0);
        byte[] buffer = A_0;
        switch (format)
        {
            case ImageFormat.Bmp:
                str = BookmarkStart.b("ᤨᨪ", num);
                str2 = BookmarkStart.b("䬨䘪崬", num);
                break;

            case ImageFormat.Emf:
                str = BookmarkStart.b("ᤨᴪ", num);
                str2 = BookmarkStart.b("䰨䘪圬", num);
                buffer = Class734.smethod_29(A_0);
                break;

            case ImageFormat.Gif:
                str = BookmarkStart.b("ᤨᨪ", num);
                str2 = BookmarkStart.b("丨䈪䬬", num);
                break;

            case ImageFormat.Jpeg:
                str = BookmarkStart.b("ᤨᤪ", num);
                str2 = BookmarkStart.b("䌨嬪䨬", num);
                break;

            case ImageFormat.Png:
                str = BookmarkStart.b("ᤨᠪ", num);
                str2 = BookmarkStart.b("夨䔪䨬", num);
                break;

            case ImageFormat.Wmf:
                str = BookmarkStart.b("ᤨጪ", num);
                str2 = BookmarkStart.b("帨䘪圬", num);
                buffer = Class734.smethod_29(A_0);
                break;

            case ImageFormat.Tiff:
                str = BookmarkStart.b("ᤨᠪ", num);
                str2 = BookmarkStart.b("崨䈪䬬", num);
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("簨䔪弬䨮到尲刴夶倸䄺堼嬾慀⩂⡄♆⹈⹊浌㭎⡐⍒ご睖㱘㕚㹜ぞᑠൢᅤɦ᭨๪६佮ᕰٲݴṶ᝸ᱺ嵼⡾쪆얈ꮊﲒ래", num));
        }
        string str3 = this.method_11(str, str2, buffer);
        this.hashtable_0.Add(key, str3);
        return str3;
    }

    private string imethod_2(string A_0)
    {
        return A_0;
    }

    [CompilerGenerated]
    private void imethod_8(bool A_0)
    {
        this.bool_0 = A_0;
    }

    ArrayList Interface48.imethod_3()
    {
        if (this.arrayList_0 == null)
        {
            this.arrayList_0 = new ArrayList();
        }
        return this.arrayList_0;
    }

    Class928 Interface48.imethod_4()
    {
        return this.class928_0;
    }

    string Interface48.imethod_5()
    {
        int num = 4;
        if (this.class465_0 != null)
        {
            return BookmarkStart.b("堩ᘫ䜭启", num);
        }
        return BookmarkStart.b("天師䴭", num);
    }

    string Interface48.imethod_6()
    {
        int num = 0x10;
        if (this.class465_0 != null)
        {
            return BookmarkStart.b("䐵ȷ刹主嬽☿", num);
        }
        return BookmarkStart.b("夵ȷ刹主嬽☿", num);
    }

    [CompilerGenerated]
    bool Interface48.imethod_7()
    {
        return this.bool_0;
    }

    internal Document method_0()
    {
        return this.document_0;
    }

    internal Class257 method_1()
    {
        return (Class257) this.class928_0.class253_0;
    }

    internal string method_10(string A_0, string A_1, MemoryStream A_2)
    {
        return this.method_11(A_0, A_1, A_2.ToArray());
    }

    private string method_11(string A_0, string A_1, byte[] A_2)
    {
        int num = 14;
        string str = Class1041.smethod_42(this.int_0);
        this.int_0++;
        string str2 = string.Format(BookmarkStart.b("䌳夵䨷帹儻刽稿流歃㵅硇㝉㝋罍ⵏ籑⽓摕╗", 14), A_0, str, A_1);
        if (this.class465_0 == null)
        {
            this.class399_0.method_4(BookmarkStart.b("䌳వ娷匹刻稽ℿ㙁╃", num));
            this.class399_0.method_40(BookmarkStart.b("䌳వ嘷嬹儻嬽", num), str2);
            this.class399_0.method_20(A_2, 0, A_2.Length);
            this.class399_0.method_5();
        }
        return str2;
    }

    internal Class399 method_2()
    {
        return this.class399_0;
    }

    internal Class465 method_3()
    {
        return this.class465_0;
    }

    internal string method_4(int A_0)
    {
        return this.class800_0.method_3(A_0);
    }

    internal string method_5(string A_0)
    {
        return this.class800_0.method_4(A_0);
    }

    internal MemoryStream method_6()
    {
        if (this.memoryStream_0 == null)
        {
            this.method_7();
        }
        return this.memoryStream_0;
    }

    private void method_7()
    {
        Class1132 class2 = new Class1132(Guid.Empty);
        foreach (KeyValuePair<string, DocOleObject> pair in this.class928_0.document_0.DocOleObjects)
        {
            string key = pair.Key;
            DocOleObject obj2 = pair.Value;
            Class1089 class3 = Class627.smethod_1(Class627.smethod_7(obj2.Interface49.get_ObjectType()), obj2.Interface49.get_ObjectType(), obj2, obj2.Interface49.get_DisplayAsIcon());
            class2.method_0().method_2(key, smethod_0(class3));
        }
        if (class2.method_0().Count > 0)
        {
            this.memoryStream_0 = new MemoryStream();
            class2.method_5(this.memoryStream_0);
        }
    }

    internal string method_8(byte[] A_0, ShapeObject A_1)
    {
        if (A_0 == null)
        {
            return null;
        }
        DocPicture picture = new DocPicture(A_1.Document);
        picture.LoadImage(A_0);
        picture.documentObject_1 = A_1.Owner;
        return this.method_9(picture);
    }

    public string method_9(DocPicture A_0)
    {
        return this.method_3().method_335(A_0, false, null);
    }

    private static MemoryStream smethod_0(Class1089 A_0)
    {
        Class1132 class2 = new Class1132(A_0);
        MemoryStream stream = new MemoryStream();
        class2.method_5(stream);
        stream.Position = 0L;
        MemoryStream stream2 = new MemoryStream();
        Class567.smethod_1((uint) stream.Length, stream2);
        Class1156.smethod_4(stream, stream2, CompressionMethod.Stored);
        return stream2;
    }
}

