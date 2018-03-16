namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class Break : ParagraphBase, Interface2
    {
        private bool bool_7;
        private Spire.Doc.Documents.BreakType breakType_0;
        private byte byte_4;
        internal Class442 class442_0;
        private LineBreakClear lineBreakClear_0;
        private string[] string_8;
        private Spire.Doc.Fields.TextRange textRange_0;

        public Break(IDocument doc) : this(doc, Spire.Doc.Documents.BreakType.LineBreak)
        {
        }

        public Break(IDocument doc, Spire.Doc.Documents.BreakType breakType) : base((Document) doc)
        {
            this.class442_0 = new Class442();
            this.breakType_0 = breakType;
            this.textRange_0 = new Spire.Doc.Fields.TextRange(doc);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_24(this));
        }

        internal override void Attach(Paragraph paragraph, int itemPos)
        {
            base.Attach(paragraph, itemPos);
            if ((base.OwnerParagraph != null) && (this.breakType_0 == Spire.Doc.Documents.BreakType.LineBreak))
            {
                base.OwnerParagraph.method_64(this, 0, this.textRange_0.Text);
            }
        }

        internal override void Attach(SDTInlineContent owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            if ((base.Owner is SDTInlineContent) && (this.breakType_0 == Spire.Doc.Documents.BreakType.LineBreak))
            {
                (base.Owner as SDTInlineContent).method_23(this, 0, this.textRange_0.Text);
            }
        }

        protected override void CreateLayoutInfo()
        {
            switch (this.breakType_0)
            {
                case Spire.Doc.Documents.BreakType.PageBreak:
                    base.interface23_0 = new Class210(ChildrenLayoutDirection.Vertical, false);
                    base.interface23_0.imethod_29(true);
                    break;

                case Spire.Doc.Documents.BreakType.ColumnBreak:
                    base.interface23_0 = new Class210(ChildrenLayoutDirection.Vertical, false);
                    base.interface23_0.imethod_29(true);
                    break;

                case Spire.Doc.Documents.BreakType.LineBreak:
                    base.interface23_0 = new Class210(ChildrenLayoutDirection.Vertical, false);
                    base.interface23_0.imethod_25(true);
                    if (this.IsCrBreak)
                    {
                        Paragraph ownerParagraph = this.OwnerParagraph;
                        if ((ownerParagraph != null) && ownerParagraph.IsInCell)
                        {
                            TableCell owner = ownerParagraph.Owner as TableCell;
                            Table table = owner.Owner.Owner as Table;
                            if (((owner != null) && (owner.Items.IndexOf(ownerParagraph) == (owner.Items.Count - 1))) && ((table != null) && !table.IsTextBox))
                            {
                                base.interface23_0.imethod_25(false);
                            }
                        }
                    }
                    break;
            }
            if (base.interface23_0 != null)
            {
                base.interface23_0.imethod_13(true);
            }
        }

        internal override void Detach()
        {
            base.Detach();
            if ((base.OwnerParagraph != null) && (this.breakType_0 == Spire.Doc.Documents.BreakType.LineBreak))
            {
                base.OwnerParagraph.method_64(this, this.textRange_0.Text.Length, string.Empty);
            }
            else if ((base.Owner is SDTInlineContent) && (this.breakType_0 == Spire.Doc.Documents.BreakType.LineBreak))
            {
                (base.Owner as SDTInlineContent).method_23(this, this.textRange_0.Text.Length, string.Empty);
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䀳匵䀷丹ᄻ䰽ℿⱁ⍃⍅", 14), this.textRange_0);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            base.ReadXmlAttributes(reader);
            this.breakType_0 = (Spire.Doc.Documents.BreakType) reader.ReadEnum(BookmarkStart.b("猰䄲倴嘶券漺䐼伾⑀", 11), typeof(Spire.Doc.Documents.BreakType));
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            int num = 11;
            SizeF ef = new SizeF();
            Paragraph paragraph = base.method_28();
            if ((paragraph != null) && (this.TextRange != null))
            {
                this.TextRange.CharacterFormat.ApplyBase(paragraph.BreakCharacterFormat);
                if (!this.IsCrBreak && (this.BreakType == Spire.Doc.Documents.BreakType.LineBreak))
                {
                    ef = dc.method_323(this.TextRange, BookmarkStart.b("㨰", num));
                    ef.Width = 0f;
                }
                if (this.IsCrBreak && !base.interface23_0.imethod_24())
                {
                    ef.Width = dc.method_323(this.TextRange, BookmarkStart.b("㨰", num)).Width;
                }
            }
            return ef;
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("尧匩尫䬭", 2), ParagraphItemType.Break);
            writer.WriteValue(BookmarkStart.b("樧堩䤫伭嬯昱䴳䘵崷", 2), this.BreakType);
        }

        public Spire.Doc.Documents.BreakType BreakType
        {
            get
            {
                return this.breakType_0;
            }
        }

        internal LineBreakClear ClearType
        {
            get
            {
                if (this.breakType_0 != Spire.Doc.Documents.BreakType.LineBreak)
                {
                    return LineBreakClear.None;
                }
                return this.lineBreakClear_0;
            }
            set
            {
                this.lineBreakClear_0 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Break;
            }
        }

        internal override int EndPos
        {
            get
            {
                return (base.EndPos + this.textRange_0.Text.Length);
            }
        }

        internal Class442 HtmlToDocLayoutInfo
        {
            get
            {
                return this.class442_0;
            }
        }

        internal bool IsCrBreak
        {
            get
            {
                return (this.bool_7 && (this.breakType_0 == Spire.Doc.Documents.BreakType.LineBreak));
            }
            set
            {
                this.bool_7 = value;
            }
        }

        internal Spire.Doc.Fields.TextRange TextRange
        {
            get
            {
                return this.textRange_0;
            }
            set
            {
                this.textRange_0 = value;
            }
        }
    }
}

