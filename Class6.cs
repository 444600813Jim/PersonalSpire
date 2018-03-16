using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class6 : ParagraphBase, Interface2
{
    [CompilerGenerated]
    private bool bool_7;
    private CharacterFormat characterFormat_0;
    private Dictionary<string, DictionaryEntry> dictionary_0;
    private Dictionary<string, Class517> dictionary_1;
    private DocPicture docPicture_0;
    [CompilerGenerated]
    private ShapeBase shapeBase_0;
    private Stream stream_0;
    private Stream stream_1;
    internal string string_8;
    [CompilerGenerated]
    private Struct36 struct36_0;
    [CompilerGenerated]
    private Struct37 struct37_0;

    public Class6(Stream A_0, IDocument A_1) : base(A_1 as Document)
    {
        this.stream_0 = A_0;
        this.characterFormat_0 = new CharacterFormat(A_1);
    }

    private void imethod_1(Class196 A_0, Class375 A_1)
    {
        if (this.method_32() != null)
        {
            this.method_32().DrawImpl(A_0, A_1);
        }
    }

    private void imethod_2(Class196 A_0, Class375 A_1)
    {
    }

    SizeF Interface2.imethod_3(Class196 A_0)
    {
        if (this.method_32() != null)
        {
            return this.method_32().Size;
        }
        return SizeF.Empty;
    }

    internal DocPicture method_30()
    {
        return this.docPicture_0;
    }

    internal void method_31(DocPicture A_0)
    {
        this.docPicture_0 = A_0;
    }

    [CompilerGenerated]
    internal ShapeBase method_32()
    {
        return this.shapeBase_0;
    }

    [CompilerGenerated]
    internal void method_33(ShapeBase A_0)
    {
        this.shapeBase_0 = A_0;
    }

    [CompilerGenerated]
    internal bool method_34()
    {
        return this.bool_7;
    }

    [CompilerGenerated]
    internal void method_35(bool A_0)
    {
        this.bool_7 = A_0;
    }

    [CompilerGenerated]
    internal Struct37 method_36()
    {
        return this.struct37_0;
    }

    [CompilerGenerated]
    internal void method_37(Struct37 A_0)
    {
        this.struct37_0 = A_0;
    }

    [CompilerGenerated]
    internal Struct36 method_38()
    {
        return this.struct36_0;
    }

    [CompilerGenerated]
    internal void method_39(Struct36 A_0)
    {
        this.struct36_0 = A_0;
    }

    internal Dictionary<string, Class517> method_40()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<string, Class517>();
        }
        return this.dictionary_1;
    }

    internal Dictionary<string, DictionaryEntry> method_41()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, DictionaryEntry>();
        }
        return this.dictionary_0;
    }

    internal Stream method_42()
    {
        return this.stream_0;
    }

    internal Stream method_43()
    {
        return this.stream_1;
    }

    internal void method_44(Stream A_0)
    {
        this.stream_1 = A_0;
    }

    internal CharacterFormat method_45()
    {
        return this.characterFormat_0;
    }

    internal void method_46(CharacterFormat A_0)
    {
        if (A_0 != null)
        {
            this.characterFormat_0 = A_0.method_23() as CharacterFormat;
        }
    }

    private void method_47(Document A_0)
    {
        int num = 7;
        if (this.method_41().Count != 0)
        {
            string[] array = new string[this.method_41().Count];
            this.method_41().Keys.CopyTo(array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                DictionaryEntry entry = this.method_41()[array[i]];
                string[] strArray2 = entry.Value.ToString().Split(new char[] { '/' });
                Class1128 class2 = base.Document.DocxPackage.method_18(BookmarkStart.b("娬䀮䌰圲ᨴ", num));
                Class1128 class3 = A_0.DocxPackage.method_18(BookmarkStart.b("娬䀮䌰圲ᨴ", num));
                string newValue = this.method_48(class2, class3, strArray2, 0);
                entry.Value = entry.Value.ToString().Replace(strArray2[strArray2.Length - 1], newValue);
                this.method_41()[array[i]] = entry;
            }
        }
    }

    private string method_48(Class1128 A_0, Class1128 A_1, string[] A_2, int A_3)
    {
        int num = 10;
        string str = string.Empty;
        for (int i = A_3; i < A_2.Length; i++)
        {
            if (i < (A_2.Length - 1))
            {
                string key = A_2[i] + BookmarkStart.b("Ἧ", num);
                if (A_1.method_1().ContainsKey(key))
                {
                    A_1 = A_1.method_1()[key];
                    A_0 = A_0.method_1()[key];
                    return this.method_48(A_0, A_1, A_2, i + 1);
                }
                Class1128 class2 = A_0.method_1()[key].method_17();
                class2.method_0().Clear();
                A_1.method_1().Add(key, class2);
                foreach (string str3 in class2.method_2().Keys)
                {
                    Class230 class3 = class2.method_2()[str3];
                    if ((class3.method_4() != null) && (class3.method_4().Length > 0L))
                    {
                        class3.method_4().Position = 0L;
                        XmlReader reader = XmlReader.Create(class3.method_4());
                        Dictionary<string, DictionaryEntry> dictionary = new Dictionary<string, DictionaryEntry>();
                        this.method_49(reader, dictionary);
                        foreach (DictionaryEntry entry in dictionary.Values)
                        {
                            string str4 = (string) entry.Key;
                            if (str4 == BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⅍⁏㝑㩓⹕㕗㙙㩛ㅝ቟ཡգብ᭧䑩ͫᱭᝯ嵱᭳ၵṷ፹ύ᭽쑿揄뾏ꂑ꒓ꚕ꺗떙ﮝ첟쎡킣쾥잧쒩\udfab\uc6ad\ud9af\uc2b1잳馵좷\udbb9\udfbb햽ꆿꗁꇃ", num))
                            {
                                string[] strArray = ((string) entry.Value).Replace(BookmarkStart.b("ḯᰱᬳ", num), string.Empty).Split(new char[] { '/' });
                                this.method_48(A_0, A_1, strArray, 0);
                            }
                        }
                    }
                }
                A_1 = A_1.method_1()[key];
                A_0 = A_0.method_1()[key];
            }
            else
            {
                str = this.method_50(A_0, A_1, A_2[i]);
            }
        }
        return str;
    }

    private void method_49(XmlReader A_0, Dictionary<string, DictionaryEntry> A_1)
    {
        int num = 7;
        A_0.MoveToContent();
        if (A_0.LocalName != BookmarkStart.b("缬䨮崰刲䄴帶嘸唺丼圾⡀㍂㙄", 7))
        {
            A_0.ReadInnerXml();
        }
        else
        {
            string key = null;
            string attribute = null;
            string str = null;
            while (true)
            {
                A_0.Read();
                key = A_0.GetAttribute(BookmarkStart.b("搬䬮", num));
                attribute = A_0.GetAttribute(BookmarkStart.b("礬丮䌰吲倴䌶", num));
                str = A_0.GetAttribute(BookmarkStart.b("礬嘮䄰嘲", num));
                if ((key != null) && ((attribute != null) && (str != null)))
                {
                    DictionaryEntry entry = new DictionaryEntry(str, attribute);
                    A_1.Add(key, entry);
                }
                if (A_0.LocalName == BookmarkStart.b("缬䨮崰刲䄴帶嘸唺丼圾⡀㍂㙄", num))
                {
                    return;
                }
            }
        }
    }

    private string method_50(Class1128 A_0, Class1128 A_1, string A_2)
    {
        string key = A_2;
        if (A_1.method_0().ContainsKey(A_2))
        {
            string extension = Path.GetExtension(A_2);
            string str3 = A_2.Replace(extension, "");
            string oldValue = str3.TrimEnd(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            int result = 0;
            int.TryParse(str3.Replace(oldValue, ""), out result);
            key = oldValue + result.ToString() + extension;
            while (A_1.method_0().ContainsKey(key))
            {
                result++;
                key = oldValue + result.ToString() + extension;
            }
            Class229 class2 = A_0.method_0()[A_2].method_9();
            class2.method_8(key);
            A_1.method_0().Add(key, class2);
            return key;
        }
        A_1.method_0().Add(A_2, A_0.method_0()[A_2].method_9());
        return key;
    }

    internal DocPicture method_51(bool A_0)
    {
        if (this.method_32() is ShapeObject)
        {
            this.method_32().method_0(base.Owner);
            (this.method_32() as ShapeObject).ParentContainer = this;
            return (this.method_32() as ShapeObject).method_63(A_0);
        }
        return null;
    }

    void DocumentBase.CreateLayoutInfo()
    {
        base.interface23_0 = new Class205();
        if ((this.method_30() != null) || (this.method_32() != null))
        {
            base.interface23_0.imethod_5(false);
        }
    }

    object ParagraphBase.CloneImpl()
    {
        Class6 class2 = base.CloneImpl() as Class6;
        if (base.m_charFormat != null)
        {
            class2.method_45().ImportContainer(base.m_charFormat);
        }
        if (class2.stream_0 != null)
        {
            class2.stream_0 = Class57.smethod_16(this.stream_0 as MemoryStream);
        }
        class2.dictionary_0 = new Dictionary<string, DictionaryEntry>();
        if (this.dictionary_0 != null)
        {
            foreach (string str in this.dictionary_0.Keys)
            {
                DictionaryEntry entry = this.dictionary_0[str];
                DictionaryEntry entry2 = new DictionaryEntry((string) entry.Key, (string) entry.Value);
                class2.method_41().Add(str, entry2);
            }
        }
        return class2;
    }

    void ParagraphBase.CloneRelationsTo(Document A_0, OwnerHolder A_1)
    {
        base.CloneRelationsTo(A_0, A_1);
        if (this.method_40().Count > 0)
        {
            string[] array = new string[this.method_40().Count];
            this.method_40().Keys.CopyTo(array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                Class517 class2 = this.method_40()[array[i]];
                if (class2.method_7())
                {
                    class2 = A_0.Images.method_6(class2.byte_1, true);
                }
                else
                {
                    class2 = A_0.Images.method_5(class2.method_3());
                }
                this.method_40()[array[i]] = class2;
            }
        }
        if ((A_0.DocxPackage == null) && (base.Document.DocxPackage != null))
        {
            A_0.DocxPackage = base.Document.DocxPackage.method_25();
        }
        else if ((A_0.DocxPackage != null) && (base.Document.DocxPackage != null))
        {
            this.method_47(A_0);
        }
    }

    public override DocumentObjectType Spire.Doc.Interface.IDocumentObject.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.XmlParaItem;
        }
    }
}

