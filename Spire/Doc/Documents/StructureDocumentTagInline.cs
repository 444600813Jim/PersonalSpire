namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public class StructureDocumentTagInline : ParagraphBase, IParagraphBase, IStructureDocument
    {
        private bool bool_7;
        private bool[] bool_8;
        private bool bool_9;
        private byte byte_4;
        private long long_4;
        private SDTInlineContent sdtinlineContent_0;
        private Spire.Doc.Documents.SDTProperties sdtproperties_0;

        public StructureDocumentTagInline(Document doc) : base(doc)
        {
            this.sdtproperties_0 = new Spire.Doc.Documents.SDTProperties(this);
            this.sdtinlineContent_0 = new SDTInlineContent(doc, this);
            this.sdtinlineContent_0.method_0(this);
            base.m_charFormat = new CharacterFormat(doc);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_45(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_44(this);
        }

        protected override object CloneImpl()
        {
            StructureDocumentTagInline inline = (StructureDocumentTagInline) base.CloneImpl();
            inline.sdtproperties_0 = this.SDTProperties.method_9();
            inline.sdtproperties_0.method_7(inline);
            inline.sdtinlineContent_0 = this.SDTContent.method_25();
            inline.sdtinlineContent_0.method_0(inline);
            inline.bool_9 = false;
            return inline;
        }

        protected override void CreateLayoutInfo()
        {
        }

        internal StructureDocumentTagInline method_30()
        {
            return (StructureDocumentTagInline) this.CloneImpl();
        }

        internal void method_31()
        {
            IParagraphStyle style = base.OwnerParagraph.GetStyle();
            if (style != null)
            {
                this.CharacterFormat.ApplyBase(style.CharacterFormat);
                for (int i = 0; i < this.SDTContent.Items.Count; i++)
                {
                    this.SDTContent.Items[i].CharacterFormat.ApplyBase(style.CharacterFormat);
                }
            }
        }

        internal void method_32(ParagraphItemCollection A_0)
        {
            if (this.SDTContent.Items.Count > 0)
            {
                for (int i = 0; i < this.SDTContent.Items.Count; i++)
                {
                    if (this.SDTContent.Items[i] is StructureDocumentTagInline)
                    {
                        (this.SDTContent.Items[i] as StructureDocumentTagInline).UpdateDataBinding();
                        (this.SDTContent.Items[i] as StructureDocumentTagInline).method_32(A_0);
                    }
                    else
                    {
                        A_0.InnerList.Add(this.SDTContent.Items[i]);
                    }
                }
            }
            else
            {
                TextRange range = (TextRange) base.Document.CreateParagraphItem(ParagraphItemType.TextRange);
                range.Text = "";
                range.CharacterFormat.ApplyBase(base.m_charFormat);
                A_0.InnerList.Add(range);
                range.OwnerEmptyParagraph = base.OwnerParagraph;
            }
        }

        public void UpdateDataBinding()
        {
            if (!this.bool_9)
            {
                this.SDTProperties.method_0(base.Document.CustomXmlParts);
                this.bool_9 = true;
            }
        }

        public CharacterFormat BreakCharacterFormat
        {
            get
            {
                return this.CharacterFormat;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.sdtinlineContent_0.ChildObjects;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.StructureDocumentTagInline;
            }
        }

        internal bool IsUpdateDataBinding
        {
            get
            {
                return this.bool_9;
            }
            set
            {
                this.bool_9 = value;
            }
        }

        public SDTInlineContent SDTContent
        {
            get
            {
                return this.sdtinlineContent_0;
            }
        }

        public Spire.Doc.Documents.SDTProperties SDTProperties
        {
            get
            {
                return this.sdtproperties_0;
            }
        }
    }
}

