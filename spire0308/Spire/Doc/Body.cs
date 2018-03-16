namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;

    public class Body : DocumentContainer, Interface3, IBody
    {
        private bool bool_3;
        private float float_2;
        private FormFieldCollection formFieldCollection_0;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal int int_5;
        protected BodyRegionCollection m_bodyItems;
        private ParagraphCollection paragraphCollection_0;
        private string string_7;
        private TableCollection tableCollection_0;

        internal Body(Section A_0) : this(A_0.Document, A_0)
        {
        }

        internal Body(Document A_0, DocumentObject A_1) : base(A_0, A_1)
        {
            this.m_bodyItems = new BodyRegionCollection(this);
            this.paragraphCollection_0 = new ParagraphCollection(this.m_bodyItems);
            this.tableCollection_0 = new TableCollection(this.m_bodyItems);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_5(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_4(this);
        }

        public Paragraph AddParagraph()
        {
            Paragraph entity = new Paragraph(base.Document);
            int num = this.m_bodyItems.Add(entity);
            return (this.m_bodyItems[num] as Paragraph);
        }

        public Table AddTable()
        {
            Table entity = new Table(base.Document);
            int num = this.m_bodyItems.Add(entity);
            return (this.m_bodyItems[num] as Table);
        }

        public Table AddTable(bool showBorder)
        {
            Table entity = new Table(showBorder, base.Document);
            int num = this.m_bodyItems.Add(entity);
            return (this.m_bodyItems[num] as Table);
        }

        protected override object CloneImpl()
        {
            Body body = (Body) base.CloneImpl();
            body.m_bodyItems = new BodyRegionCollection(body);
            this.ChildObjects.method_12(body.m_bodyItems);
            body.paragraphCollection_0 = new ParagraphCollection(body.m_bodyItems);
            body.tableCollection_0 = new TableCollection(body.m_bodyItems);
            body.bool_3 = this.bool_3;
            return body;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            int num = 0;
            int count = this.ChildObjects.Count;
            while (num < count)
            {
                this.ChildObjects[num].CloneRelationsTo(doc, nextOwner);
                num++;
            }
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Vertical);
        }

        public void EnsureMinimum()
        {
            if (this.Paragraphs.Count == 0)
            {
                this.AddParagraph();
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("席儯䀱唳儵䨷嬹䰻嘽㌿", 8), this.m_bodyItems);
        }

        public void InsertXHTML(string html)
        {
            this.InsertXHTML(html, this.Paragraphs.Count);
        }

        public void InsertXHTML(string html, int paragraphIndex)
        {
            this.InsertXHTML(html, paragraphIndex, 0);
        }

        public void InsertXHTML(string html, int paragraphIndex, int paragraphItemIndex)
        {
            using (Class747 class2 = new Class747())
            {
                class2.imethod_0(this, html, paragraphIndex, paragraphItemIndex);
            }
        }

        public bool IsValidXHTML(string html, XHTMLValidationType type)
        {
            using (Class747 class2 = new Class747())
            {
                return class2.imethod_2(html, type);
            }
        }

        public bool IsValidXHTML(string html, XHTMLValidationType type, out string exceptionMessage)
        {
            using (Class747 class2 = new Class747())
            {
                return class2.imethod_3(html, type, out exceptionMessage);
            }
        }

        internal IStructureDocument method_21()
        {
            IStructureDocument entity = new StructureDocumentTag(base.m_doc);
            this.m_bodyItems.Add(entity);
            return entity;
        }

        internal TextSelection method_22(Regex A_0)
        {
            TextSelection selection2;
            using (IEnumerator enumerator = this.Items.GetEnumerator())
            {
                TextSelection selection;
                while (enumerator.MoveNext())
                {
                    selection = ((BodyRegion) enumerator.Current).Find(A_0);
                    if ((selection != null) && (selection.Count > 0))
                    {
                        goto Label_0039;
                    }
                }
                return null;
            Label_0039:
                selection2 = selection;
            }
            return selection2;
        }

        internal Class185 method_23(Regex A_0)
        {
            Class185 class2 = null;
            foreach (BodyRegion region in this.Items)
            {
                Class185 collection = region.FindAll(A_0);
                if ((collection != null) && (collection.Count > 0))
                {
                    if (class2 == null)
                    {
                        class2 = new Class185();
                    }
                    class2.AddRange(collection);
                }
            }
            return class2;
        }

        internal int method_24(Regex A_0, string A_1)
        {
            int num2;
            int num = 0;
            using (IEnumerator enumerator = this.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    BodyRegion current = (BodyRegion) enumerator.Current;
                    num += current.Replace(A_0, A_1);
                    if (base.Document.ReplaceFirst && (num > 0))
                    {
                        goto Label_0043;
                    }
                }
                return num;
            Label_0043:
                num2 = num;
            }
            return num2;
        }

        internal int method_25(Regex A_0, TextSelection A_1, bool A_2)
        {
            int num2;
            int num = 0;
            using (IEnumerator enumerator = this.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    BodyRegion current = (BodyRegion) enumerator.Current;
                    num += current.Replace(A_0, A_1, A_2);
                    if (base.Document.ReplaceFirst && (num > 0))
                    {
                        goto Label_0044;
                    }
                }
                return num;
            Label_0044:
                num2 = num;
            }
            return num2;
        }

        internal int method_26(Regex A_0, TextBodyPart A_1, bool A_2)
        {
            int num = 12;
            if (Class191.smethod_0(A_0))
            {
                throw new ArgumentException(BookmarkStart.b("愱儳圵䨷夹吻ḽ㌿㙁㙃⽅♇ⵉ汋ⵍㅏ㱑㩓㥕ⱗ穙㹛㭝䁟ݡॣᙥᱧ፩", num));
            }
            Class185 class2 = this.method_23(A_0);
            if (class2 == null)
            {
                return 0;
            }
            foreach (TextSelection selection in class2)
            {
                CharacterFormat characterFormat = null;
                if (A_2)
                {
                    characterFormat = selection.StartTextRange.CharacterFormat;
                }
                int num2 = selection.method_0();
                Paragraph ownerParagraph = selection.OwnerParagraph;
                A_1.method_1(ownerParagraph.OwnerTextBody, ownerParagraph.method_5(), num2, characterFormat, A_2);
                if (base.Document.ReplaceFirst)
                {
                    break;
                }
            }
            return class2.Count;
        }

        internal int method_27(Regex A_0, IDocument A_1, bool A_2)
        {
            int num = 7;
            if (Class191.smethod_0(A_0))
            {
                throw new ArgumentException(BookmarkStart.b("縬䨮倰䄲嘴弶ᤸ䠺䤼䴾⡀ⵂ≄杆⩈⩊⍌ⅎ㹐❒畔㕖㱘筚㡜㉞ᅠᝢᱤ", num));
            }
            CharacterFormat characterFormat = null;
            Class185 class2 = this.method_23(A_0);
            if (class2 == null)
            {
                return 0;
            }
            foreach (TextSelection selection in class2)
            {
                if (A_2)
                {
                    characterFormat = selection.StartTextRange.CharacterFormat;
                }
                int num3 = selection.method_0();
                Paragraph ownerParagraph = selection.OwnerParagraph;
                for (int i = A_1.Sections.Count - 1; i >= 0; i--)
                {
                    ISection section = A_1.Sections[i];
                    if (!A_2)
                    {
                        base.Document.CurClonedSection = section as Section;
                    }
                    TextBodyPart part = new TextBodyPart(base.Document);
                    part.method_0(section.Body, false);
                    part.method_1(ownerParagraph.OwnerTextBody, ownerParagraph.method_5(), num3, characterFormat, A_2);
                }
                if (base.Document.ReplaceFirst)
                {
                    break;
                }
            }
            return class2.Count;
        }

        internal void method_28()
        {
            if ((this.m_bodyItems != null) && (this.m_bodyItems.Count > 0))
            {
                BodyRegion region = null;
                for (int i = 0; i < this.m_bodyItems.Count; i++)
                {
                    region = this.m_bodyItems[i];
                    region.Close();
                    region = null;
                }
                this.m_bodyItems.Clear();
                this.m_bodyItems = null;
            }
            if (this.paragraphCollection_0 != null)
            {
                this.paragraphCollection_0.Clear();
                this.paragraphCollection_0 = null;
            }
            if (this.tableCollection_0 != null)
            {
                this.tableCollection_0.Clear();
                this.tableCollection_0 = null;
            }
            if (this.formFieldCollection_0 != null)
            {
                this.formFieldCollection_0.InnerList.Clear();
                this.formFieldCollection_0 = null;
            }
        }

        internal void method_29()
        {
            this.method_30(new char[] { ' ' });
        }

        internal void method_30(char[] A_0)
        {
            this.method_31(A_0, true);
        }

        internal void method_31(char[] A_0, bool A_1)
        {
            this.int_5 = 0;
            this.int_4 = 0;
            this.int_3 = 0;
            this.int_2 = 0;
            this.method_32(this.ChildObjects, A_0, A_1);
        }

        private void method_32(DocumentObjectCollection A_0, char[] A_1, bool A_2)
        {
            foreach (BodyRegion region in A_0)
            {
                if (region is Paragraph)
                {
                    this.method_34(region as Paragraph, A_1, A_2);
                }
                else
                {
                    this.method_33(region as Table, A_1, A_2);
                }
            }
        }

        private void method_33(Table A_0, char[] A_1, bool A_2)
        {
            foreach (TableRow row in A_0.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    this.method_32(cell.Items, A_1, A_2);
                }
            }
        }

        private void method_34(Paragraph A_0, char[] A_1, bool A_2)
        {
            A_0.UpdateWordCount(A_1, A_2);
            this.int_2 += A_0.WordCount;
            this.int_3 += A_0.CharCount;
            this.int_5 += A_0.CharCountIncludeSpace;
            if (A_0.CharCount > 0)
            {
                this.int_4++;
            }
        }

        internal void method_35(bool A_0)
        {
            BodyRegion region = null;
            for (int i = 0; i < this.m_bodyItems.Count; i++)
            {
                region = this.m_bodyItems[i];
                if (!this.method_36(region, A_0, ref i))
                {
                    bool flag = this.method_39(region, A_0);
                    if (region is Table)
                    {
                        Table table = region as Table;
                        if (A_0)
                        {
                            table.xmlTableFormat_1 = null;
                            table.list_1 = null;
                        }
                        else if (table.xmlTableFormat_1 != null)
                        {
                            table.DocxTableFormat.Format.ClearFormatting();
                            table.DocxTableFormat = table.TrackTblFormat.method_0(table);
                            table.FirstRow.RowFormat.ClearFormatting();
                            table.FirstRow.RowFormat.ImportContainer(table.TrackTblFormat.Format);
                            table.xmlTableFormat_1 = null;
                        }
                        if (!A_0 && (table.list_1 != null))
                        {
                            table.TableGrid.Clear();
                            foreach (float num2 in table.TrackTableGrid)
                            {
                                table.TableGrid.Add(num2);
                            }
                            table.list_1 = null;
                        }
                    }
                    if (!A_0)
                    {
                        this.method_38(region);
                    }
                    if ((region.IsInsertRevision || region.IsDeleteRevision) || region.IsChangedCFormat)
                    {
                        region.AcceptCChanges();
                    }
                    if (region.IsChangedPFormat)
                    {
                        region.AcceptPChanges();
                    }
                    region.MakeChanges(A_0);
                    if (flag && this.method_40(region))
                    {
                        this.ChildObjects.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private bool method_36(BodyRegion A_0, bool A_1, ref int A_2)
        {
            if ((A_0.IsInsertRevision && !A_1) || (A_0.IsDeleteRevision && A_1))
            {
                bool flag = true;
                if (A_0 is Table)
                {
                    flag = (A_0 as Table).method_83();
                }
                else if (A_0 is Paragraph)
                {
                    flag = (A_0 as Paragraph).method_92();
                }
                if (flag)
                {
                    this.ChildObjects.RemoveAt(A_2);
                    A_2--;
                    return true;
                }
            }
            return false;
        }

        internal bool method_37()
        {
            bool flag;
            using (IEnumerator enumerator = this.m_bodyItems.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    BodyRegion current = (BodyRegion) enumerator.Current;
                    if (current.HasTrackedChanges())
                    {
                        goto Label_002D;
                    }
                }
                return false;
            Label_002D:
                flag = true;
            }
            return flag;
        }

        private void method_38(BodyRegion A_0)
        {
            if (A_0.IsChangedCFormat)
            {
                A_0.RemoveCFormatChanges();
            }
            if (A_0.IsChangedPFormat)
            {
                A_0.RemovePFormatChanges();
            }
        }

        private bool method_39(BodyRegion A_0, bool A_1)
        {
            bool flag = false;
            if (!(A_0 is Paragraph) || !(A_0.NextSibling is Paragraph))
            {
                return flag;
            }
            if ((!A_0.IsInsertRevision || A_1) && (!A_0.IsDeleteRevision || !A_1))
            {
                return flag;
            }
            return true;
        }

        private bool method_40(BodyRegion A_0)
        {
            Paragraph paragraph = A_0 as Paragraph;
            int num = paragraph.Items.Count - 1;
            Paragraph nextSibling = A_0.NextSibling as Paragraph;
            if (nextSibling == null)
            {
                return false;
            }
            for (int i = num; i >= 0; i--)
            {
                nextSibling.Items.Insert(0, paragraph.Items[i]);
            }
            return true;
        }

        internal IDocumentObjectCollection method_41()
        {
            BodyRegionCollection regions = new BodyRegionCollection(this);
            for (int i = 0; i < this.m_bodyItems.Count; i++)
            {
                if (this.m_bodyItems[i] is StructureDocumentTag)
                {
                    foreach (DocumentObject obj2 in (this.m_bodyItems[i] as StructureDocumentTag).method_25())
                    {
                        regions.InnerList.Add(obj2);
                    }
                }
                else
                {
                    regions.InnerList.Add(this.m_bodyItems[i]);
                }
            }
            return regions;
        }

        internal IParagraphBase method_42()
        {
            if (this.ChildObjects.Count == 0)
            {
                return null;
            }
            return (this.ChildObjects.FirstItem.ChildObjects.FirstItem as IParagraphBase);
        }

        internal IParagraphBase method_43()
        {
            if (this.ChildObjects.Count == 0)
            {
                return null;
            }
            return (this.ChildObjects.LastItem.ChildObjects.LastItem as IParagraphBase);
        }

        internal IParagraph method_44()
        {
            DocumentObject lastItem = this.m_bodyItems.LastItem;
            if (lastItem is StructureDocumentTag)
            {
                lastItem = (lastItem as StructureDocumentTag).method_25().LastItem;
            }
            return (lastItem as Paragraph);
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.m_bodyItems;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Body;
            }
        }

        public FormFieldCollection FormFields
        {
            get
            {
                if (this.formFieldCollection_0 == null)
                {
                    this.formFieldCollection_0 = new FormFieldCollection(this);
                }
                return this.formFieldCollection_0;
            }
        }

        internal bool HasSDT
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        internal bool IsFormFieldsCreated
        {
            get
            {
                return (this.formFieldCollection_0 != null);
            }
        }

        internal BodyRegionCollection Items
        {
            get
            {
                return this.m_bodyItems;
            }
        }

        public IParagraph LastParagraph
        {
            get
            {
                if (this.Paragraphs.Count <= 0)
                {
                    return null;
                }
                return this.Paragraphs[this.Paragraphs.Count - 1];
            }
        }

        public ParagraphCollection Paragraphs
        {
            get
            {
                return this.paragraphCollection_0;
            }
        }

        internal Section ParentSection
        {
            get
            {
                return (base.Owner as Section);
            }
        }

        public TableCollection Tables
        {
            get
            {
                return this.tableCollection_0;
            }
        }

        protected override IDocumentObjectCollection WidgetCollection
        {
            get
            {
                return this.method_41();
            }
        }
    }
}

