namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;

    public class Section : DocumentContainer, Interface3, ISection
    {
        private Spire.Doc.Body body_0;
        private bool bool_3;
        private Class17 class17_0;
        private DocumentObjectCollection documentObjectCollection_0;
        private const float float_2 = 36f;
        private FootEndnoteOptions footEndnoteOptions_0;
        private FootEndnoteOptions footEndnoteOptions_1;
        internal Spire.Doc.HeadersFooters headersFooters_0;
        protected internal byte[] m_internalData;
        private Spire.Doc.PageSetup pageSetup_0;
        private Spire.Doc.PageSetup pageSetup_1;
        private SectionBreakType sectionBreakType_0;
        internal Spire.Doc.Documents.TextDirection textDirection_0;

        public Section(IDocument doc) : base((Document) doc, null)
        {
            this.sectionBreakType_0 = SectionBreakType.NewPage;
            this.bool_3 = true;
            this.body_0 = new Spire.Doc.Body(this);
            this.headersFooters_0 = new Spire.Doc.HeadersFooters(this);
            this.headersFooters_0.method_0(this);
            this.class17_0 = new Class17(this);
            this.SectPr.method_123(new ColumnCollection(this));
            this.pageSetup_0 = new Spire.Doc.PageSetup(this);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_3(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_2(this);
        }

        public Column AddColumn(float width, float spacing)
        {
            Column column = new Column(base.Document) {
                Width = width,
                Space = spacing
            };
            this.Columns.Add(column);
            return column;
        }

        public Paragraph AddParagraph()
        {
            return this.Body.AddParagraph();
        }

        public Table AddTable()
        {
            return this.Body.AddTable();
        }

        public Table AddTable(bool showBorder)
        {
            return this.Body.AddTable(showBorder);
        }

        public Section Clone()
        {
            return (Section) base.Clone();
        }

        protected override object CloneImpl()
        {
            bool flag = base.Document.bool_5;
            base.Document.bool_5 = true;
            Section section = (Section) base.CloneImpl();
            section.documentObjectCollection_0 = null;
            section.method_23((Class17) this.SectPr.Clone());
            section.body_0 = (Spire.Doc.Body) this.body_0.Clone();
            section.body_0.method_0(section);
            section.pageSetup_0 = new Spire.Doc.PageSetup(section);
            section.pageSetup_0.HasLineNumbering = this.PageSetup.HasLineNumbering;
            ColumnCollection columns = new ColumnCollection(section);
            this.Columns.method_6(columns);
            section.SectPr.method_123(columns);
            section.headersFooters_0 = this.headersFooters_0.method_5();
            section.headersFooters_0.method_0(section);
            for (int i = 0; i < 6; i++)
            {
                section.headersFooters_0[i].method_0(section);
            }
            base.Document.bool_5 = flag;
            return section;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            doc.CurClonedSection = this;
            base.CloneRelationsTo(doc, nextOwner);
            this.Body.CloneRelationsTo(doc, nextOwner);
            ImportOptions importOption = doc.ImportOption;
            bool importStyles = doc.ImportStyles;
            if (doc.ImportOption != ImportOptions.UseDestinationStyles)
            {
                doc.ImportOption = ImportOptions.UseDestinationStyles;
                doc.ImportStyles = false;
            }
            for (int i = 0; i <= 5; i++)
            {
                this.headersFooters_0[i].CloneRelationsTo(doc, nextOwner);
            }
            if (doc.ImportOption != importOption)
            {
                doc.ImportOption = importOption;
                doc.ImportStyles = importStyles;
            }
            doc.CurClonedSection = null;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Vertical);
            if (this.Body.Items.Count == 0)
            {
                base.interface23_0.imethod_5(true);
            }
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䴮帰圲䰴", 9), this.body_0);
            base.XDLSHolder.AddElement(BookmarkStart.b("弮倰吲倴ᨶ䨸帺䤼䨾ㅀ", 9), this.pageSetup_0);
            base.XDLSHolder.AddElement(BookmarkStart.b("䜮吰刲儴制䬸䠺ြ夾⹀ⱂㅄ≆㭈㡊", 9), this.headersFooters_0);
        }

        public void MakeColumnsSameWidth()
        {
            if (this.Columns.Count > 0)
            {
                float num = (this.PageSetup.PageSize.Width - ((this.PageSetup.Margins.Left != -0.05f) ? this.PageSetup.Margins.Left : 0f)) - ((this.PageSetup.Margins.Right != -0.05f) ? this.PageSetup.Margins.Right : 0f);
                float num2 = (num - ((this.Columns.Count - 1) * 36f)) / ((float) this.Columns.Count);
                foreach (Column column in this.Columns)
                {
                    column.Width = num2;
                    column.Space = 36f;
                }
            }
        }

        internal Section method_21()
        {
            return (Section) this.method_27();
        }

        internal IStructureDocument method_22()
        {
            return this.Body.method_21();
        }

        internal void method_23(Class17 A_0)
        {
            this.class17_0 = A_0;
            this.class17_0.method_158(this);
            this.class17_0.method_122().method_0(this);
        }

        internal string method_24()
        {
            string str = string.Empty;
            for (int i = 0; i < this.Body.ChildObjects.Count; i++)
            {
                DocumentObject obj2 = this.Body.ChildObjects[i];
                if (obj2 is Paragraph)
                {
                    str = str + (obj2 as Paragraph).method_75();
                }
                else if (obj2 is Table)
                {
                    str = str + (obj2 as Table).method_40();
                }
                if (base.Document.bodyRegion_0 != null)
                {
                    i = base.Document.bodyRegion_0.method_5();
                    base.Document.bodyRegion_0 = null;
                }
            }
            return str;
        }

        internal Section method_25()
        {
            bool flag = base.Document.bool_5;
            base.Document.bool_5 = true;
            Section section = new Section(base.Document);
            section.method_23((Class17) this.SectPr.Clone());
            section.pageSetup_0 = new Spire.Doc.PageSetup(section);
            section.pageSetup_0.HasLineNumbering = this.PageSetup.HasLineNumbering;
            ColumnCollection columns = new ColumnCollection(section);
            this.Columns.method_6(columns);
            section.SectPr.method_123(columns);
            section.headersFooters_0 = this.headersFooters_0.method_5();
            section.headersFooters_0.method_0(section);
            for (int i = 0; i < 6; i++)
            {
                section.headersFooters_0[i].method_0(section);
            }
            base.Document.bool_5 = flag;
            return section;
        }

        internal void method_26(Spire.Doc.Documents.TextDirection A_0)
        {
            this.SectPr.method_135(A_0);
        }

        internal object method_27()
        {
            bool flag = base.Document.bool_5;
            base.Document.bool_5 = true;
            Section section = (Section) base.CloneImpl();
            section.documentObjectCollection_0 = null;
            section.body_0 = (Spire.Doc.Body) this.body_0.Clone();
            section.body_0.method_0(section);
            section.method_23((Class17) this.SectPr.Clone());
            section.pageSetup_0 = new Spire.Doc.PageSetup(section);
            section.pageSetup_0.HasLineNumbering = this.PageSetup.HasLineNumbering;
            ColumnCollection columns = new ColumnCollection(section);
            this.Columns.method_6(columns);
            section.SectPr.method_123(columns);
            section.headersFooters_0 = this.headersFooters_0.method_5();
            for (int i = 0; i < 6; i++)
            {
                section.headersFooters_0[i].method_0(section);
            }
            base.Document.bool_5 = flag;
            return section;
        }

        internal void method_28()
        {
            if (this.headersFooters_0.LinkToPrevious)
            {
                this.headersFooters_0.method_9(this.headersFooters_0.LinkToPrevious);
            }
        }

        internal void method_29(bool A_0)
        {
            this.body_0.method_35(A_0);
            for (int i = 0; i < 6; i++)
            {
                this.HeadersFooters[i].method_35(A_0);
            }
        }

        internal bool method_30()
        {
            if (this.body_0.method_37())
            {
                return true;
            }
            for (int i = 0; i < 6; i++)
            {
                if (this.HeadersFooters[i].method_37())
                {
                    return true;
                }
            }
            return false;
        }

        internal void method_31()
        {
            if (this.body_0 != null)
            {
                this.body_0.method_28();
                this.body_0 = null;
            }
            if (this.headersFooters_0 != null)
            {
                this.headersFooters_0.method_7();
                this.headersFooters_0 = null;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 8;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("氭䈯圱唳崵笷唹堻嬽", 8)))
            {
                this.BreakCode = (SectionBreakType) reader.ReadEnum(BookmarkStart.b("氭䈯圱唳崵笷唹堻嬽", num), typeof(SectionBreakType));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("尴夶䴸帺似儾⁀⽂桄⍆⡈㽊ⱌ", 15))
            {
                this.DataArray = reader.ReadChildBinaryElement();
                flag = true;
            }
            return flag;
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("瘳䐵崷嬹圻紽⼿♁⅃", 14), this.BreakCode);
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 0x13;
            base.WriteXmlContent(writer);
            if (this.DataArray != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("倸唺䤼娾㍀ⵂ⑄⭆摈⽊ⱌ㭎ぐ", num), this.DataArray);
            }
        }

        public Spire.Doc.Body Body
        {
            get
            {
                return this.body_0;
            }
        }

        public SectionBreakType BreakCode
        {
            get
            {
                return this.SectPr.method_56();
            }
            set
            {
                this.SectPr.method_57(value);
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                if (this.documentObjectCollection_0 == null)
                {
                    this.documentObjectCollection_0 = new Class46(this);
                    this.documentObjectCollection_0.InnerList.Add(this.body_0);
                    this.body_0.method_0(this);
                    for (int i = 0; i < 6; i++)
                    {
                        this.documentObjectCollection_0.InnerList.Add(this.headersFooters_0[i]);
                        this.headersFooters_0[i].method_0(this);
                    }
                }
                return this.documentObjectCollection_0;
            }
        }

        public ColumnCollection Columns
        {
            get
            {
                return this.SectPr.method_122();
            }
        }

        internal byte[] DataArray
        {
            get
            {
                return this.m_internalData;
            }
            set
            {
                this.m_internalData = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Section;
            }
        }

        public FootEndnoteOptions EndnoteOptions
        {
            get
            {
                return this.SectPr.method_138();
            }
        }

        public FootEndnoteOptions FootnoteOptions
        {
            get
            {
                return this.SectPr.method_139();
            }
        }

        public Spire.Doc.HeadersFooters HeadersFooters
        {
            get
            {
                return this.headersFooters_0;
            }
        }

        internal bool IsLastChild
        {
            get
            {
                if (base.ParentObject != null)
                {
                    return (this == base.ParentObject.LastChild);
                }
                return true;
            }
        }

        internal Spire.Doc.PageSetup LayoutPageSetup
        {
            get
            {
                return this.pageSetup_1;
            }
            set
            {
                this.pageSetup_1 = value;
            }
        }

        public Spire.Doc.PageSetup PageSetup
        {
            get
            {
                if (((base.Owner is Document) && ((base.Owner as Document).OperationType == DocumentOperationType.Layout)) && (this.pageSetup_1 != null))
                {
                    return this.pageSetup_1;
                }
                return this.pageSetup_0;
            }
        }

        public ParagraphCollection Paragraphs
        {
            get
            {
                return this.Body.Paragraphs;
            }
        }

        public bool ProtectForm
        {
            get
            {
                return !this.SectPr.method_124();
            }
            set
            {
                this.SectPr.method_125(!value);
            }
        }

        internal Spire.Doc.PageSetup RealPageSetup
        {
            get
            {
                return this.pageSetup_0;
            }
        }

        internal Class17 SectPr
        {
            get
            {
                return this.class17_0;
            }
        }

        public TableCollection Tables
        {
            get
            {
                return this.Body.Tables;
            }
        }

        public Spire.Doc.Documents.TextDirection TextDirection
        {
            get
            {
                return this.SectPr.method_134();
            }
            set
            {
                this.SectPr.method_135(value);
                if (value == Spire.Doc.Documents.TextDirection.RightToLeft)
                {
                    this.SectPr.method_89(PageOrientation.Landscape);
                }
                else
                {
                    this.SectPr.method_89(PageOrientation.Portrait);
                }
            }
        }

        protected override IDocumentObjectCollection WidgetCollection
        {
            get
            {
                return this.body_0.method_41();
            }
        }

        internal DocumentObjectCollection WidgetObjectCollection
        {
            get
            {
                return (this.WidgetCollection as DocumentObjectCollection);
            }
        }

        internal class Class46 : DocumentObjectCollection
        {
            private static readonly Type[] type_0 = new Type[] { typeof(Body), typeof(HeaderFooter) };

            internal Class46(Section A_0) : base(A_0.Document)
            {
                base.method_0(A_0);
            }

            OwnerHolder DocumentSerializableCollection.CreateItem(IXDLSContentReader A_0)
            {
                throw new Exception();
            }

            string DocumentSerializableCollection.GetTagItemName()
            {
                throw new Exception();
            }

            Type[] DocumentObjectCollection.TypesOfElement
            {
                get
                {
                    return type_0;
                }
            }
        }
    }
}

