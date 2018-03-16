namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public class StyleCollection : DocumentSerializableCollection, IStyleCollection
    {
        internal bool bool_0;
        internal bool bool_1;
        private bool[] bool_2;
        private byte[] byte_1;
        private CharacterFormat characterFormat_0;
        private Class181 class181_0;
        private Class547 class547_0;
        private Class656 class656_0;
        private Class656 class656_1;
        private Dictionary<string, string> dictionary_0;
        private Dictionary<string, string> dictionary_1;
        private Dictionary<string, string> dictionary_2;
        private Dictionary<string, string> dictionary_3;
        private Document document_0;
        private Document document_1;
        private float float_1;
        private float[] float_2;
        internal const int int_2 = 15;
        internal const int int_3 = 14;
        internal const int int_4 = 0x9c;
        internal const int int_5 = 0x10b;
        internal const int int_6 = 4;
        internal const int int_7 = 7;
        private List<ParagraphStyle> list_1;
        private long[] long_4;
        private readonly object object_0;
        private readonly object object_1;
        private ParagraphFormat paragraphFormat_0;
        private ParagraphStyle paragraphStyle_0;
        private string[] string_1;
        internal string string_2;
        internal string string_3;
        private StyleCollection styleCollection_0;

        internal StyleCollection(Document A_0) : base(A_0, A_0)
        {
            this.string_2 = string.Empty;
            this.string_3 = string.Empty;
            this.class547_0 = new Class547();
            this.class656_0 = new Class656();
            this.class181_0 = new Class181();
            this.class656_1 = new Class656();
            this.object_0 = new object();
            this.object_1 = new object();
            this.characterFormat_0 = new CharacterFormat(A_0);
            this.paragraphFormat_0 = new ParagraphFormat(A_0);
            this.dictionary_0 = null;
        }

        public int Add(IStyle style)
        {
            int num = 9;
            if (style == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("尮䔰䨲头制", num));
            }
            DocumentSerializable serializable = (DocumentSerializable) style;
            serializable.CloneRelationsTo(base.Document, null);
            serializable.method_0(base.Document);
            if ((style as Style).BaseStyle != null)
            {
                Style baseStyle = (style as Style).BaseStyle as Style;
                if (!(this.FindByName(baseStyle.Name, baseStyle.StyleType) is Style))
                {
                    this.Add(baseStyle.Clone());
                }
                if (style is ParagraphStyle)
                {
                    (style as ParagraphStyle).ApplyBaseStyle(baseStyle.Name);
                }
                else if (style is Class13)
                {
                    (style as Class13).ApplyBaseStyle(baseStyle.Name);
                }
                else
                {
                    (style as Style).ApplyBaseStyle(baseStyle.Name);
                }
            }
            if (this.styleCollection_0 != null)
            {
                this.styleCollection_0.method_4();
                this.styleCollection_0 = null;
            }
            return base.InnerList.Add(style);
        }

        public void ApplyDocDefaultsToNormalStyle()
        {
            int num = 0x10;
            if (base.Document != null)
            {
                ParagraphStyle style = this.FindByName(BookmarkStart.b("砵圷䠹儻弽ⰿ", num), StyleType.ParagraphStyle) as ParagraphStyle;
                if (style != null)
                {
                    if (base.Document.DefCharFormat != null)
                    {
                        style.CharacterFormat.method_25(base.Document.DefCharFormat);
                    }
                    if (base.Document.DefParaFormat != null)
                    {
                        style.ParagraphFormat.method_25(base.Document.DefParaFormat);
                    }
                }
            }
        }

        internal override void CloneToImpl(CollectionEx coll)
        {
            StyleCollection styles = coll as StyleCollection;
            int num = 0;
            int count = base.InnerList.Count;
            while (num < count)
            {
                styles.Add((base.InnerList[num] as IStyle).Clone());
                num++;
            }
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            string str2;
            int num = 0x10;
            if (((str2 = reader.GetAttributeValue(BookmarkStart.b("䈵䄷䨹夻", 0x10))) != null) && (str2 == BookmarkStart.b("电倷嬹主弽⌿㙁⅃㑅ᭇ㹉㕋≍㕏", num)))
            {
                return new Class11(base.Document);
            }
            return new ParagraphStyle(base.Document);
        }

        public IStyle FindById(int styleId)
        {
            return smethod_3(base.InnerList, styleId);
        }

        public IStyle FindByIstd(int istd)
        {
            return smethod_4(base.InnerList, istd);
        }

        public Style FindByName(string name)
        {
            return (smethod_0(base.InnerList, name) as Style);
        }

        public IStyle FindByName(string name, StyleType styleType)
        {
            return smethod_1(base.InnerList, name, styleType);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("唥尧匩䀫䬭", 0);
        }

        internal IStyle method_10(IList A_0, string A_1)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                IStyle style2 = A_0[i] as IStyle;
                if ((style2 != null) && (style2.StyleId == A_1))
                {
                    return style2;
                }
            }
            return null;
        }

        internal IStyle method_11(string A_0, string A_1, StyleType A_2)
        {
            return smethod_2(base.InnerList, A_0, A_1, A_2);
        }

        internal Style method_12(string A_0, bool A_1)
        {
            Class567.smethod_20(A_0, BookmarkStart.b("䠥䤧䜩䤫", 0));
            Style style = this.FindByName(A_0);
            if ((style == null) && A_1)
            {
                Style style2 = this.BuiltInStyles.method_12(A_0, false);
                if (style2 != null)
                {
                    style = this.method_20(style2);
                }
            }
            return style;
        }

        internal Style method_13(int A_0, bool A_1)
        {
            Class567.smethod_20(A_0, BookmarkStart.b("尮䔰䨲头制ᤸ刺匼嬾⑀㭂", 9));
            Style style = (Style) this.FindByIstd(A_0);
            if ((style == null) && A_1)
            {
                Style style2 = this.BuiltInStyles.method_13(A_0, false);
                if (style2 != null)
                {
                    style = this.method_20(style2);
                }
            }
            return style;
        }

        internal string method_14(Style A_0, bool A_1)
        {
            int num = 2;
            StringBuilder builder = new StringBuilder();
            if (A_1)
            {
                builder.Append(A_0.Name);
            }
            for (int i = 0; i < this.class181_0.Count; i++)
            {
                Style byIndex = (Style) this.class181_0.GetByIndex(i);
                string key = (string) this.class181_0.GetKey(i);
                if ((A_0 == byIndex) && (A_0.Name != key))
                {
                    if (builder.Length > 0)
                    {
                        builder.Append(BookmarkStart.b("Ч", num));
                    }
                    builder.Append(key);
                }
            }
            return builder.ToString();
        }

        internal int method_15()
        {
            int num2 = 14;
            int num = Math.Max(this.MaxIstd, 14) + 1;
            if (num >= 0xfff)
            {
                throw new InvalidOperationException(BookmarkStart.b("怳帵崷䠹夻ḽℿぁ⅃晅㱇╉⍋湍㵏㍑㩓⽕硗⥙⡛❝౟ݡᝣ䙥ŧѩ䱫ᩭᡯ᝱味ት᝷᥹ॻ፽ꢅ", num2));
            }
            return num;
        }

        internal int method_16(string A_0)
        {
            Style style = this.DocStyleCollection.FindByName(A_0);
            if (style != null)
            {
                return style.StyleDocId;
            }
            return 0xfff;
        }

        internal int method_17(Style A_0)
        {
            Style style = this.DocStyleCollection.method_11(A_0.Name, A_0.StyleId, A_0.StyleType) as Style;
            if (style != null)
            {
                return style.StyleDocId;
            }
            return 0xfff;
        }

        private void method_18()
        {
            int num = 9;
            this.styleCollection_0 = new StyleCollection(this.DefaultParaPr.Document);
            for (int i = 0; i < 15; i++)
            {
                this.styleCollection_0.InnerList.Insert(i, null);
            }
            int num3 = 15;
            foreach (Style style2 in this)
            {
                Style style = style2.Clone() as Style;
                if ((style2.Name == BookmarkStart.b("愮帰䄲場嘶唸", num)) && (this.styleCollection_0.InnerList[0] == null))
                {
                    style.StyleDocId = 0;
                    style.method_14(StyleIdentifier.Normal);
                    this.styleCollection_0.InnerList[0] = style;
                }
                else if ((style2.StyleIdentifier < StyleIdentifier.Index1) && (this.styleCollection_0.InnerList[(int) style2.StyleIdentifier] == null))
                {
                    style.StyleDocId = (int) style2.StyleIdentifier;
                    this.styleCollection_0.InnerList[style.StyleDocId] = style;
                }
                else if ((style2.StyleIdentifier == StyleIdentifier.DefaultParagraphFont) && (this.styleCollection_0.InnerList[10] == null))
                {
                    style.StyleDocId = 10;
                    this.styleCollection_0.InnerList[10] = style;
                }
                else if ((style2.StyleIdentifier == StyleIdentifier.TableNormal) && (this.styleCollection_0.InnerList[11] == null))
                {
                    style.StyleDocId = 11;
                    this.styleCollection_0.InnerList[11] = style;
                }
                else if ((style2.StyleIdentifier == StyleIdentifier.NoList) && (this.styleCollection_0.InnerList[12] == null))
                {
                    style.StyleDocId = 12;
                    this.styleCollection_0.InnerList[12] = style;
                }
                else
                {
                    style.StyleDocId = num3;
                    this.styleCollection_0.InnerList.Add(style);
                    num3++;
                }
                this.styleCollection_0.class656_0.method_5(style.StyleDocId, style);
            }
            while (this.styleCollection_0.InnerList.Contains(null))
            {
                this.styleCollection_0.InnerList.Remove(null);
            }
        }

        internal StyleCollection method_19()
        {
            switch (base.Document.DetectedFormatType)
            {
                case FileFormat.Doc:
                case FileFormat.Dot:
                case FileFormat.WordML:
                case FileFormat.DocPre97:
                    return this.BuiltInStyles2003;
            }
            return this.BuiltInStyles2007;
        }

        private Style method_20(Style A_0)
        {
            return A_0;
        }

        private Document method_21(string A_0)
        {
            Document document2;
            int num = 13;
            try
            {
                using (Stream stream = Class1040.smethod_0(A_0))
                {
                    byte[] buffer = new byte[0x4000];
                    using (MemoryStream stream2 = new MemoryStream())
                    {
                        int num2;
                        while ((num2 = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            stream2.Write(buffer, 0, num2);
                        }
                        stream2.WriteByte(0);
                        Document document = new Document(stream2);
                        document.Styles.method_22();
                        return document;
                    }
                }
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(BookmarkStart.b("瀲吴夶圸吺䤼Ἶⵀⱂ⑄⍆楈⥊㡌♎㵐❒畔㹖㝘筚⹜⭞ᡠརdᑦ䝨", num), exception);
            }
            return document2;
        }

        internal void method_22()
        {
            foreach (Style style in this)
            {
                CharacterFormat characterFormat = style.CharacterFormat;
                characterFormat.Remove(380);
                characterFormat.Remove(340);
                characterFormat.Remove(390);
            }
        }

        internal void method_23(Style A_0, string A_1, string A_2)
        {
            this.class181_0.Remove(A_1);
            if (!this.class181_0.Contains(A_2))
            {
                this.class181_0.Add(A_2, A_0);
            }
            else
            {
                this.class181_0[A_2] = A_0;
            }
        }

        internal void method_24(Style A_0, StyleIdentifier A_1, StyleIdentifier A_2)
        {
            if (A_0.BuiltIn)
            {
                this.class656_1.method_18((int) A_1);
            }
            if (A_2 != StyleIdentifier.User)
            {
                if (this.class656_1.method_8((int) A_2))
                {
                    this.class656_1.method_4((int) A_2, A_0);
                }
                else
                {
                    this.class656_1.method_5((int) A_2, A_0);
                }
            }
        }

        internal void method_25(Style A_0, int A_1, int A_2)
        {
            this.class656_0.method_18(A_1);
            if (this.class656_0.method_8(A_2))
            {
                this.class656_0.method_4(A_2, A_0);
            }
            else
            {
                this.class656_0.method_5(A_2, A_0);
            }
            this.method_26(A_0, A_1, A_2);
        }

        private void method_26(Style A_0, int A_1, int A_2)
        {
            this.method_27(A_1, A_2);
            this.method_28(A_0, A_1, A_2);
        }

        private void method_27(int A_0, int A_1)
        {
            foreach (Style style in this)
            {
                if (style.BasedOnIstd == A_0)
                {
                    style.BasedOnIstd = A_1;
                }
                if (style.NextIstd == A_0)
                {
                    style.NextIstd = A_1;
                }
                if (style.LinkedIstd == A_0)
                {
                    style.LinkedIstd = A_1;
                }
            }
        }

        private void method_28(Style A_0, int A_1, int A_2)
        {
            switch (A_0.StyleType)
            {
                case StyleType.ParagraphStyle:
                    this.method_31(A_1, A_2);
                    return;

                case StyleType.CharacterStyle:
                    this.method_32(A_0, A_1, A_2);
                    return;

                case StyleType.TableStyle:
                    this.method_29(A_1, A_2);
                    return;

                case StyleType.ListStyle:
                    this.method_30(A_0, A_1, A_2);
                    return;
            }
        }

        private void method_29(int A_0, int A_1)
        {
            foreach (TableRow row in base.Document.GetChildElements(DocumentObjectType.TableRow, true))
            {
                RowFormat rowFormat = row.RowFormat;
                if (rowFormat.Istd == A_0)
                {
                    if (A_1 == -1)
                    {
                        rowFormat.Remove(50);
                    }
                    else
                    {
                        rowFormat[50] = A_1;
                    }
                }
            }
        }

        private void method_30(Style A_0, int A_1, int A_2)
        {
            foreach (Paragraph paragraph in base.Document.GetChildElements(DocumentObjectType.Paragraph, true))
            {
                ListFormat listFormat = paragraph.ListFormat;
                if (((listFormat.ListType != ListType.NoList) && (listFormat.CurrentListStyle != null)) && (listFormat.CurrentListStyle.Istd == A_1))
                {
                    if (A_2 == -1)
                    {
                        listFormat.Remove(0x460);
                        listFormat.Remove(0x456);
                    }
                    else
                    {
                        listFormat[0x460] = (A_0 as ListStyle).Istd;
                    }
                }
            }
        }

        private void method_31(int A_0, int A_1)
        {
            foreach (Paragraph paragraph in base.Document.GetChildElements(DocumentObjectType.Paragraph, true))
            {
                ParagraphFormat format = paragraph.Format;
                if ((format.Istd == A_0) && (A_0 != 0))
                {
                    if (A_1 == -1)
                    {
                        format.Remove(0x3e8);
                    }
                    else
                    {
                        format[0x3e8] = A_1;
                    }
                }
            }
        }

        private void method_32(Style A_0, int A_1, int A_2)
        {
            foreach (TextRange range in base.Document.GetChildElements(DocumentObjectType.TextRange, true))
            {
                CharacterFormat characterFormat = range.CharacterFormat;
                if (characterFormat.Istd == A_1)
                {
                    if (A_2 == -1)
                    {
                        characterFormat.Remove(50);
                    }
                    else
                    {
                        characterFormat[50] = A_2;
                    }
                }
            }
        }

        internal void method_5()
        {
            if (this.list_1 != null)
            {
                foreach (ParagraphStyle style in this.list_1)
                {
                    style.ListIndex = -1;
                }
                this.list_1 = null;
            }
        }

        internal void method_6(ParagraphStyle A_0)
        {
            if (this.list_1 == null)
            {
                this.list_1 = new List<ParagraphStyle>();
            }
            if (!this.list_1.Contains(A_0))
            {
                this.list_1.Add(A_0);
            }
        }

        internal void method_7(Style A_0, string[] A_1)
        {
            if (this.class181_0.Contains(A_0.Name))
            {
                A_0.method_8(this.method_8(A_0.Name));
            }
            if (A_0.BuiltIn && this.class656_1.method_8((int) A_0.StyleIdentifier))
            {
                A_0.method_14(StyleIdentifier.User);
            }
            this.Add(A_0);
            if (A_1 != null)
            {
                for (int i = 0; i < A_1.Length; i++)
                {
                    this.class181_0.Add(this.method_8(A_1[i]), A_0);
                }
            }
        }

        internal string method_8(string A_0)
        {
            int num = 6;
            string key = A_0;
            for (int i = 0; this.class181_0.Contains(key); i++)
            {
                key = string.Format(BookmarkStart.b("圫ḭ䴯洱伳ܵ䔷", num), A_0, i);
            }
            return key;
        }

        internal IStyle method_9(string A_0)
        {
            return this.method_10(base.InnerList, A_0);
        }

        internal static IStyle smethod_0(IList A_0, string A_1)
        {
            IStyle style = null;
            for (int i = 0; i < A_0.Count; i++)
            {
                IStyle style2 = A_0[i] as IStyle;
                if ((style2 != null) && ((style2.Name == A_1) || (style2.StyleId == A_1)))
                {
                    style = style2;
                }
            }
            return style;
        }

        internal static IStyle smethod_1(IList A_0, string A_1, StyleType A_2)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                IStyle style2 = A_0[i] as IStyle;
                if (((style2 != null) && ((style2.StyleId == A_1) || (style2.Name == A_1))) && (style2.StyleType == A_2))
                {
                    return style2;
                }
            }
            return null;
        }

        internal static IStyle smethod_2(IList A_0, string A_1, string A_2, StyleType A_3)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                IStyle style2 = A_0[i] as IStyle;
                if (((style2 != null) && (style2.Name == A_1)) && ((style2.StyleId == A_2) && (style2.StyleType == A_3)))
                {
                    return style2;
                }
            }
            return null;
        }

        internal static IStyle smethod_3(IList A_0, int A_1)
        {
            IStyle style = null;
            for (int i = 0; i < A_0.Count; i++)
            {
                Style style2 = A_0[i] as Style;
                if ((style2 != null) && (style2.StyleDocId == A_1))
                {
                    style = style2;
                }
            }
            return style;
        }

        internal static IStyle smethod_4(IList A_0, int A_1)
        {
            IStyle style = null;
            for (int i = 0; i < A_0.Count; i++)
            {
                Style style2 = A_0[i] as Style;
                if ((style2 != null) && (style2.Istd == A_1))
                {
                    style = style2;
                }
            }
            return style;
        }

        internal StyleCollection BuiltInStyles
        {
            get
            {
                return this.method_19();
            }
        }

        private StyleCollection BuiltInStyles2003
        {
            get
            {
                int num = 13;
                if (this.document_0 == null)
                {
                    lock (this.object_0)
                    {
                        if (this.document_0 == null)
                        {
                            this.document_0 = this.method_21(BookmarkStart.b("怲䔴帶䬸帺ጼ笾⹀⁂歄ᕆⱈ㡊≌㩎⍐げご⑖睘㥚⡜㙞ൠᝢ౤०䑨ᡪᥬ᙮ᵰᙲٴ䝶䡸", num));
                        }
                    }
                }
                return this.document_0.Styles;
            }
        }

        private StyleCollection BuiltInStyles2007
        {
            get
            {
                int num = 8;
                if (this.document_1 == null)
                {
                    lock (this.object_1)
                    {
                        if (this.document_1 == null)
                        {
                            this.document_1 = this.method_21(BookmarkStart.b("紭䀯嬱䘳匵ᘷ縹医崽渿၁⅃㕅❇㽉㹋ⵍ㕏⅑穓㑕ⵗ㍙せ⩝य़ౡ䥣ᕥᱧ፩k୭ͯ䉱䙳", num));
                        }
                    }
                }
                return this.document_1.Styles;
            }
        }

        internal ParagraphFormat DefaultParaPr
        {
            get
            {
                return this.paragraphFormat_0;
            }
        }

        internal ParagraphStyle DefaultParaStyle
        {
            get
            {
                return this.paragraphStyle_0;
            }
            set
            {
                this.paragraphStyle_0 = value;
            }
        }

        internal CharacterFormat DefaultRunPr
        {
            get
            {
                return this.characterFormat_0;
            }
        }

        internal StyleCollection DocStyleCollection
        {
            get
            {
                if (this.styleCollection_0 == null)
                {
                    this.method_18();
                }
                return this.styleCollection_0;
            }
        }

        internal Dictionary<string, string> EmbedDocumentCloneStyleName
        {
            get
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<string, string>();
                }
                return this.dictionary_0;
            }
        }

        internal bool FixedIndex13HasStyle
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        internal string FixedIndex13StyleName
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        internal bool FixedIndex14HasStyle
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        internal string FixedIndex14StyleName
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }

        public IStyle this[int index]
        {
            get
            {
                return (IStyle) base.InnerList[index];
            }
        }

        internal IStyle this[string A_0]
        {
            get
            {
                return this.method_12(A_0, true);
            }
        }

        internal Class547 LatentStyles
        {
            get
            {
                return this.class547_0;
            }
        }

        internal int MaxIstd
        {
            get
            {
                if (this.class656_0.method_2() <= 0)
                {
                    return -1;
                }
                return this.class656_0.method_13(this.class656_0.method_2() - 1);
            }
        }

        internal Dictionary<string, string> OldCharStylesHolder
        {
            get
            {
                if (this.dictionary_2 == null)
                {
                    this.dictionary_2 = new Dictionary<string, string>();
                }
                return this.dictionary_2;
            }
        }

        internal Dictionary<string, string> OldListStyleHolder
        {
            get
            {
                if (this.dictionary_3 == null)
                {
                    this.dictionary_3 = new Dictionary<string, string>();
                }
                return this.dictionary_3;
            }
        }

        internal Dictionary<string, string> OldParaStylesHolder
        {
            get
            {
                if (this.dictionary_1 == null)
                {
                    this.dictionary_1 = new Dictionary<string, string>();
                }
                return this.dictionary_1;
            }
        }
    }
}

