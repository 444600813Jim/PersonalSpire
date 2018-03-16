namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents.Markup;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections;
    using System.Text.RegularExpressions;

    public class StructureDocumentTag : BodyRegion, Interface3, IStructureDocument
    {
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private CharacterFormat characterFormat_0;
        private readonly MarkupLevel markupLevel_0;
        private Spire.Doc.Documents.SDTContent sdtcontent_0;
        private Spire.Doc.Documents.SDTProperties sdtproperties_0;
        private string string_7;

        public StructureDocumentTag(Document doc) : base(doc)
        {
            this.sdtproperties_0 = new Spire.Doc.Documents.SDTProperties(this);
            this.sdtcontent_0 = new Spire.Doc.Documents.SDTContent(doc, this);
            this.characterFormat_0 = new CharacterFormat(doc);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override void AcceptCChanges()
        {
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_43(this);
        }

        internal override void AcceptPChanges()
        {
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_42(this);
        }

        internal override bool CheckChangedCFormat()
        {
            return false;
        }

        internal override bool CheckChangedPFormat()
        {
            return false;
        }

        internal override bool CheckDeleteRev()
        {
            return ((this.characterFormat_0 != null) && this.characterFormat_0.IsDeleteRevision);
        }

        internal override bool CheckInsertRev()
        {
            return false;
        }

        protected override object CloneImpl()
        {
            StructureDocumentTag tag = (StructureDocumentTag) base.CloneImpl();
            tag.sdtproperties_0 = this.SDTProperties.method_9();
            tag.sdtproperties_0.method_7(tag);
            tag.sdtcontent_0 = this.SDTContent.method_45();
            tag.sdtcontent_0.method_0(tag);
            return tag;
        }

        internal override void Close()
        {
            if (this.sdtcontent_0 != null)
            {
                this.sdtcontent_0.method_28();
                this.sdtcontent_0 = null;
            }
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            this.sdtproperties_0 = null;
            this.sdtcontent_0 = null;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Vertical);
            if (this.ChildObjects.Count == 0)
            {
                base.interface23_0.imethod_5(true);
            }
        }

        public override TextSelection Find(Regex pattern)
        {
            TextSelection selection2;
            using (IEnumerator enumerator = this.ChildObjects.GetEnumerator())
            {
                TextSelection selection;
                while (enumerator.MoveNext())
                {
                    selection = ((BodyRegion) enumerator.Current).Find(pattern);
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

        internal override Class185 FindAll(Regex pattern)
        {
            Class185 class2 = null;
            foreach (BodyRegion region in this.ChildObjects)
            {
                Class185 collection = region.FindAll(pattern);
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

        internal override BodyRegion GetNextTextBodyItem()
        {
            if (base.NextSibling != null)
            {
                return (base.NextSibling as BodyRegion);
            }
            if (base.Owner is TableCell)
            {
                return (base.Owner as TableCell).method_61();
            }
            if (base.Owner is Body)
            {
                if (base.OwnerTextBody.Owner is TextBox)
                {
                    return (base.OwnerTextBody.Owner as TextBox).method_76();
                }
                if (base.OwnerTextBody.Owner is Section)
                {
                    return base.GetNextInSection(base.OwnerTextBody.Owner as Section);
                }
            }
            return null;
        }

        internal override bool HasTrackedChanges()
        {
            return false;
        }

        internal override void MakeChanges(bool acceptChanges)
        {
        }

        internal StructureDocumentTag method_22()
        {
            return (StructureDocumentTag) this.CloneImpl();
        }

        internal ParagraphBase method_23()
        {
            if (this.ChildObjects.Count == 0)
            {
                return null;
            }
            return (this.ChildObjects.FirstItem.ChildObjects.FirstItem as ParagraphBase);
        }

        internal ParagraphBase method_24()
        {
            if (this.ChildObjects.Count == 0)
            {
                return null;
            }
            return (this.ChildObjects.LastItem.ChildObjects.LastItem as ParagraphBase);
        }

        internal BodyRegionCollection method_25()
        {
            BodyRegionCollection regions = new BodyRegionCollection(base.Document, this);
            this.UpdateDataBinding();
            for (int i = 0; i < this.ChildObjects.Count; i++)
            {
                DocumentObject obj2 = this.ChildObjects[i];
                if (obj2 is StructureDocumentTag)
                {
                    (obj2 as StructureDocumentTag).UpdateDataBinding();
                    BodyRegionCollection regions2 = (obj2 as StructureDocumentTag).method_25();
                    for (int j = 0; j < regions2.Count; j++)
                    {
                        DocumentObject obj3 = regions2[j];
                        regions.InnerList.Add(obj3);
                    }
                }
                else
                {
                    regions.InnerList.Add(obj2);
                }
            }
            return regions;
        }

        internal int method_26(string A_0, string A_1, bool A_2, bool A_3)
        {
            Regex regex = Class191.smethod_1(A_0, A_2, A_3);
            return this.method_27(regex, A_1);
        }

        internal int method_27(Regex A_0, string A_1)
        {
            int num = 0x12;
            if (Class191.smethod_0(A_0))
            {
                throw new ArgumentException(BookmarkStart.b("欷弹崻䰽⌿⩁摃㕅㱇㡉╋⁍㝏牑㝓㝕㙗㑙㍛⩝䁟aţ䙥൧ݩᱫᩭ९", num));
            }
            return this.Replace(A_0, A_1);
        }

        internal Table method_28(float A_0)
        {
            Table table = new Table(base.Document);
            table.ResetCells(1, 1);
            TableCell cell = table.Rows[0].Cells[0];
            cell.Width = A_0;
            table.TableFormat.Paddings.All = 0f;
            table.TableFormat.Borders.BorderType = BorderStyle.None;
            table.Rows[0].RowFormat.Borders.BorderType = BorderStyle.None;
            cell.CellFormat.Borders.BorderType = BorderStyle.None;
            table.TableFormat.LayoutType = LayoutType.Fixed;
            table.IsSDTTable = true;
            for (int i = 0; i < this.SDTContent.Items.Count; i++)
            {
                BodyRegion region = this.SDTContent.Items[i];
                cell.Items.Add(region.Clone());
            }
            table.method_0(base.Owner);
            return table;
        }

        internal override void RemoveCFormatChanges()
        {
        }

        internal override void RemovePFormatChanges()
        {
        }

        public override int Replace(Regex pattern, TextSelection textSelection)
        {
            return this.Replace(pattern, textSelection, false);
        }

        public override int Replace(Regex pattern, string replace)
        {
            int num3;
            int num = 0x12;
            if (Class191.smethod_0(pattern))
            {
                throw new ArgumentException(BookmarkStart.b("欷弹崻䰽⌿⩁摃㕅㱇㡉╋⁍㝏牑㝓㝕㙗㑙㍛⩝䁟aţ䙥൧ݩᱫᩭ९", num));
            }
            int num2 = 0;
            using (IEnumerator enumerator = this.ChildObjects.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    BodyRegion current = (BodyRegion) enumerator.Current;
                    num2 += current.Replace(pattern, replace);
                    if (base.Document.ReplaceFirst && (num2 > 0))
                    {
                        goto Label_0064;
                    }
                }
                return num2;
            Label_0064:
                num3 = num2;
            }
            return num3;
        }

        public override int Replace(Regex pattern, TextSelection textSelection, bool saveFormatting)
        {
            int num = 12;
            if (Class191.smethod_0(pattern))
            {
                throw new ArgumentException(BookmarkStart.b("愱儳圵䨷夹吻ḽ㌿㙁㙃⽅♇ⵉ汋ⵍㅏ㱑㩓㥕ⱗ穙㹛㭝䁟ݡॣᙥᱧ፩", num));
            }
            textSelection.method_1();
            Class185 class2 = this.FindAll(pattern);
            if (class2 == null)
            {
                return 0;
            }
            foreach (TextSelection selection in class2)
            {
                CharacterFormat characterFormat = null;
                if ((selection.StartTextRange != null) && saveFormatting)
                {
                    characterFormat = selection.StartTextRange.CharacterFormat;
                }
                int num2 = selection.method_0();
                Paragraph ownerParagraph = selection.OwnerParagraph;
                if (selection.OwnerSDTInlineContent != null)
                {
                    textSelection.method_3(selection.OwnerSDTInlineContent, num2, saveFormatting, characterFormat);
                }
                else
                {
                    textSelection.method_2(ownerParagraph, num2, saveFormatting, characterFormat);
                }
            }
            return class2.Count;
        }

        public int Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, textSelection, false);
        }

        public override int Replace(string given, string replace, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, replace);
        }

        public int Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord, bool saveFormatting)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, textSelection, saveFormatting);
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.interface45_0 = null;
            }
        }

        internal override void SetChangedCFormat(bool check)
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.IsChangedFormat = check;
            }
        }

        internal override void SetChangedPFormat(bool check)
        {
        }

        internal override void SetDeleteRev(bool check)
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.IsDeleteRevision = check;
            }
        }

        internal override void SetInsertRev(bool check)
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.IsInsertRevision = check;
            }
        }

        public void UpdateDataBinding()
        {
            this.SDTProperties.method_0(base.Document.CustomXmlParts);
        }

        public CharacterFormat BreakCharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.sdtcontent_0.ChildObjects;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.StructureDocumentTag;
            }
        }

        int Interface3.Count
        {
            get
            {
                return this.WidgetCollection.Count;
            }
        }

        Interface1 Interface3.this[int index]
        {
            get
            {
                return (this.WidgetCollection[index] as Interface1);
            }
        }

        public Spire.Doc.Documents.SDTContent SDTContent
        {
            get
            {
                return this.sdtcontent_0;
            }
        }

        public Spire.Doc.Documents.SDTProperties SDTProperties
        {
            get
            {
                return this.sdtproperties_0;
            }
        }

        internal IDocumentObjectCollection WidgetCollection
        {
            get
            {
                if (this.ChildObjects.Count == 0)
                {
                    return this.ChildObjects;
                }
                return this.method_25();
            }
        }
    }
}

