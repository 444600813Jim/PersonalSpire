namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class BookmarkEnd : ParagraphBase, Interface2
    {
        private bool bool_7;
        private bool bool_8;
        internal bool bool_9;
        private byte[] byte_4;
        private string string_8;

        internal BookmarkEnd(Document A_0) : this(A_0, "")
        {
        }

        public BookmarkEnd(IDocument document, string name) : base((Document) document)
        {
            this.string_8 = "";
            this.method_30(name);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_25(this));
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            if (!base.DeepDetached)
            {
                base.Document.Bookmarks.method_7(this);
                this.bool_9 = false;
            }
            else
            {
                this.bool_9 = true;
                this.bool_8 = true;
            }
        }

        internal override void CloneCommit()
        {
            if (this.bool_9 && this.bool_8)
            {
                base.Document.Bookmarks.method_7(this);
                this.bool_9 = false;
            }
        }

        protected override object CloneImpl()
        {
            BookmarkEnd end = (BookmarkEnd) base.CloneImpl();
            end.bool_9 = true;
            end.bool_8 = true;
            return end;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_13(true);
            if (!(base.Owner is SDTInlineContent))
            {
                base.interface23_0.imethod_3(((Interface1) base.OwnerParagraph).imethod_0().imethod_2());
            }
            else
            {
                DocumentObject owner = this;
                while (!(owner is Paragraph))
                {
                    if (owner.Owner == null)
                    {
                        break;
                    }
                    owner = owner.Owner;
                }
                base.interface23_0.imethod_3((owner as Interface1).imethod_0().imethod_2());
            }
        }

        internal override void Detach()
        {
            base.Detach();
            if (!base.DeepDetached)
            {
                Bookmark bookmark = base.Document.Bookmarks.FindByName(this.Name);
                if ((bookmark != null) && !this.bool_8)
                {
                    bookmark.method_1(null);
                }
            }
        }

        internal void method_30(string A_0)
        {
            this.string_8 = A_0.Replace('-', '_');
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 12;
            base.ReadXmlAttributes(reader);
            this.string_8 = reader.ReadString(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿ు╃⭅ⵇ", 12));
            base.Document.Bookmarks.method_7(this);
            if (reader.HasAttribute(BookmarkStart.b("笱䜳电崷嘹倻礽㈿ⵁㅃ㙅ੇⅉ⅋╍", 12)))
            {
                this.IsCellGroupBkmk = reader.ReadBoolean(BookmarkStart.b("笱䜳电崷嘹倻礽㈿ⵁㅃ㙅ੇⅉ⅋╍", num));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            if ((!this.Name.StartsWith(BookmarkStart.b("礥", 0)) && (dc.method_149() != null)) && dc.method_149().Name.Equals(this.Name))
            {
                dc.method_149().IsDrawComplete = true;
                dc.method_150(dc.method_149().Owner);
            }
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            int num = 0x11;
            SizeF ef = new SizeF();
            Paragraph ownerParagraph = base.OwnerParagraph;
            if ((ownerParagraph == null) && (base.Owner is SDTInlineContent))
            {
                ownerParagraph = (base.Owner as SDTInlineContent).OwnerParagraph;
            }
            if (ownerParagraph != null)
            {
                ef.Height = dc.method_1() ? dc.method_309(BookmarkStart.b("㸶", num), dc.method_376(ownerParagraph.BreakCharacterFormat), null).Height : dc.method_316(BookmarkStart.b("㸶", num), dc.method_365(ownerParagraph.BreakCharacterFormat), null).Height;
                if (ownerParagraph.ParaStyle != null)
                {
                    ef.Height = Math.Min(ef.Height, dc.method_1() ? dc.method_309(BookmarkStart.b("㸶", num), dc.method_376(ownerParagraph.ParaStyle.CharacterFormat), null).Height : dc.method_316(BookmarkStart.b("㸶", num), dc.method_365(ownerParagraph.ParaStyle.CharacterFormat), null).Height);
                }
            }
            return ef;
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 2;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("尧匩尫䬭", 2), ParagraphItemType.BookmarkEnd);
            writer.WriteValue(BookmarkStart.b("樧䔩䌫䔭崯匱䘳崵瘷嬹儻嬽", 2), this.Name);
            if (this.IsCellGroupBkmk)
            {
                writer.WriteValue(BookmarkStart.b("愧天漫䬭尯帱猳䐵圷伹䰻簽⬿⽁⽃", num), this.IsCellGroupBkmk);
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.BookmarkEnd;
            }
        }

        internal bool IsCellGroupBkmk
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                this.bool_7 = value;
            }
        }

        public string Name
        {
            get
            {
                return this.string_8;
            }
        }
    }
}

