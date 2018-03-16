namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Runtime.InteropServices;

    public abstract class ParagraphBase : DocumentBase, IParagraphBase, IRunAttrSource
    {
        private bool[] bool_3;
        internal bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private byte byte_2;
        private byte[] byte_3;
        private int int_2;
        private int[] int_3;
        private long[] long_3;
        protected Spire.Doc.Formatting.CharacterFormat m_charFormat;
        private ParagraphItemCollection paragraphItemCollection_0;
        private string[] string_7;

        protected ParagraphBase(Document doc) : base(doc, null)
        {
            this.paragraphItemCollection_0 = new ParagraphItemCollection(doc);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        public void ApplyCharacterFormat(Spire.Doc.Formatting.CharacterFormat charFormat)
        {
            if (charFormat != null)
            {
                this.m_charFormat = charFormat.method_23() as Spire.Doc.Formatting.CharacterFormat;
                this.m_charFormat.method_0(this);
            }
        }

        public void ApplyStyle(string styleName)
        {
            int num = 10;
            Class11 style = base.Document.Styles.FindByName(styleName, StyleType.CharacterStyle) as Class11;
            if ((style == null) && (styleName.ToLower() == BookmarkStart.b("启圱刳圵䴷嘹䠻ḽ〿⍁㙃❅⽇㡉ⵋ㹍㡏牑㉓㥕㙗⹙", num)))
            {
                style = (Class11) Style.CreateBuiltinStyle(BuiltinStyle.DefaultParagraphFont, base.Document);
                base.Document.Styles.Add(style);
            }
            if (style == null)
            {
                throw new ArgumentException(BookmarkStart.b("匯娱唳䐵夷夹䠻嬽㈿扁㝃㉅ㅇ♉⥋湍㍏㍑㩓癕㙗㕙⡛繝ɟݡ䑣eݧὩɫ੭幯", num));
            }
            this.method_23(style);
        }

        internal virtual void Attach(Paragraph owner, int itemPos)
        {
            int num = 14;
            if (owner == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嬳䄵嘷弹主", num));
            }
            if (owner != this.OwnerParagraph)
            {
                throw new InvalidOperationException();
            }
            if (this.ItemDetached)
            {
                throw new InvalidOperationException();
            }
            if (this.OwnerParagraph.BreakCharacterFormat.BaseFormat != null)
            {
                this.CharacterFormat.ApplyBase(this.OwnerParagraph.BreakCharacterFormat.BaseFormat);
            }
            this.StartPos = itemPos;
        }

        internal virtual void Attach(SDTInlineContent owner, int itemPos)
        {
            int num = 1;
            if (owner == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䠦帨䔪䠬崮", num));
            }
            if (this.ItemDetached)
            {
                throw new InvalidOperationException();
            }
            if (owner.OwnerParagraph.BreakCharacterFormat.BaseFormat != null)
            {
                this.CharacterFormat.ApplyBase(owner.OwnerParagraph.BreakCharacterFormat.BaseFormat);
            }
            this.StartPos = itemPos;
        }

        protected override object CloneImpl()
        {
            ParagraphBase base2 = (ParagraphBase) base.CloneImpl();
            if (this.m_charFormat != null)
            {
                base2.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(base.Document);
                base2.m_charFormat.ImportContainer(this.m_charFormat);
                base2.m_charFormat.method_21(this.m_charFormat);
                base2.m_charFormat.method_0(base2);
            }
            base2.interface23_0 = null;
            return base2;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            base.CloneRelationsTo(doc, nextOwner);
            if (doc.ImportOption != ImportOptions.UseDestinationStyles)
            {
                this.method_29(doc);
            }
            if ((((this.m_charFormat != null) && !string.IsNullOrEmpty(this.m_charFormat.CharStyleName)) && ((base.Document != null) && (base.Document.Styles != null))) && ((doc.ImportOption == ImportOptions.UseDestinationStyles) && doc.ImportStyles))
            {
                Class11 class2 = base.Document.Styles.FindByName(this.m_charFormat.CharStyleName, StyleType.CharacterStyle) as Class11;
                if (class2 != null)
                {
                    IStyle style = doc.Styles.FindByName(class2.Name, StyleType.CharacterStyle);
                    if (style == null)
                    {
                        class2.method_18(doc);
                    }
                    else if (doc.CurClonedSection != null)
                    {
                        class2 = (Class11) class2.method_20(doc, style);
                        this.m_charFormat.CharStyleName = class2.Name;
                    }
                }
            }
        }

        internal virtual void Close()
        {
            if (this.m_charFormat != null)
            {
                this.m_charFormat.Close();
                this.m_charFormat = null;
            }
        }

        internal virtual void Detach()
        {
            if (this.ItemDetached && !base.Document.IsClosing)
            {
                throw new InvalidOperationException();
            }
        }

        public DocumentObject GetAncestor(DocumentObjectType objectType)
        {
            DocumentObject owner = base.Owner;
            while (owner.DocumentObjectType != objectType)
            {
                if (owner.Owner == null)
                {
                    return null;
                }
                owner = owner.Owner;
            }
            return owner;
        }

        internal void method_21(bool A_0)
        {
            this.CharacterFormat.IsInsertRevision = A_0;
        }

        internal void method_22(bool A_0)
        {
            this.CharacterFormat.IsDeleteRevision = A_0;
        }

        internal void method_23(Class11 A_0)
        {
            int num = 0x11;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("夶尸䰺渼䬾㡀⽂⁄", num));
            }
            this.m_charFormat.CharStyleName = A_0.Name;
        }

        internal void method_24()
        {
            if (this.m_charFormat != null)
            {
                this.m_charFormat.AcceptChanges();
            }
        }

        internal void method_25()
        {
            if (this.m_charFormat != null)
            {
                this.m_charFormat.RemoveChanges();
            }
        }

        internal bool method_26()
        {
            if ((!this.IsInsertRevision && !this.IsDeleteRevision) && !this.IsChangedCFormat)
            {
                return false;
            }
            return true;
        }

        internal Spire.Doc.Formatting.CharacterFormat method_27()
        {
            return this.m_charFormat;
        }

        internal Paragraph method_28()
        {
            DocumentObject fieldOwner = (this.OwnerParagraph != null) ? this.OwnerParagraph : null;
            if ((this is TextRange) && (this as TextRange).IsFieldToTextRange)
            {
                fieldOwner = (this as TextRange).FieldOwner;
            }
            DocumentObject owner = this;
            if (!(fieldOwner is Paragraph))
            {
                while (!(owner is Paragraph))
                {
                    owner = owner.Owner;
                }
                fieldOwner = owner;
            }
            return (fieldOwner as Paragraph);
        }

        private void method_29(Document A_0)
        {
            int num = 10;
            if (A_0.ImportOption == ImportOptions.MergeFormatting)
            {
                Paragraph lastParagraph = A_0.LastParagraph;
                if (lastParagraph == null)
                {
                    lastParagraph = new Paragraph(A_0);
                }
                this.m_charFormat.method_77(lastParagraph.BreakCharacterFormat);
            }
            else
            {
                ParagraphStyle style = A_0.Styles.FindByName(BookmarkStart.b("縯崱䘳嬵夷嘹", num), StyleType.ParagraphStyle) as ParagraphStyle;
                if (A_0.ImportOption == ImportOptions.KeepSourceFormatting)
                {
                    this.m_charFormat.method_79(style.CharacterFormat);
                }
            }
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
            if (this.m_charFormat != null)
            {
                this.m_charFormat.interface45_0 = null;
            }
            if ((base.Owner is SDTInlineContent) && (base.Owner.Owner is StructureDocumentTagInline))
            {
                (base.Owner.Owner as StructureDocumentTagInline).IsUpdateDataBinding = false;
            }
        }

        void IRunAttrSource.ClearRunAttrs()
        {
            this.CharacterFormat.ClearAttrs();
        }

        object IRunAttrSource.FetchInheritedRunAttr(int fontAttr)
        {
            return this.CharacterFormat.method_31(fontAttr);
        }

        object IRunAttrSource.GetDirectRunAttr(int fontAttr)
        {
            return this.CharacterFormat.method_31(fontAttr);
        }

        void IRunAttrSource.GetDirectRunAttrByIndex(int index, out int key, out object value)
        {
            key = this.CharacterFormat.method_18(index);
            value = this.CharacterFormat.method_19(index);
        }

        void IRunAttrSource.SetRunAttr(int fontAttr, object value)
        {
            this.CharacterFormat.SetAttr(fontAttr, value);
        }

        public virtual Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                if (this.m_charFormat == null)
                {
                    if (!(base.Owner is SDTInlineContent))
                    {
                        this.m_charFormat = this.OwnerParagraph.BreakCharacterFormat;
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
                        this.m_charFormat = (owner as Paragraph).BreakCharacterFormat;
                    }
                }
                return this.m_charFormat;
            }
            internal set
            {
                this.m_charFormat = value;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.paragraphItemCollection_0;
            }
        }

        internal virtual int EndPos
        {
            get
            {
                return this.StartPos;
            }
        }

        internal bool IsAddForIfField
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                this.bool_6 = value;
            }
        }

        internal bool IsChangedCFormat
        {
            get
            {
                return ((this.m_charFormat != null) && this.m_charFormat.IsChangedFormat);
            }
            set
            {
                if (this.m_charFormat != null)
                {
                    this.m_charFormat.IsChangedFormat = value;
                }
            }
        }

        public bool IsDeleteRevision
        {
            get
            {
                return ((this.m_charFormat != null) && this.m_charFormat.IsDeleteRevision);
            }
        }

        public bool IsInsertRevision
        {
            get
            {
                return ((this.m_charFormat != null) && this.m_charFormat.IsInsertRevision);
            }
        }

        internal bool ItemDetached
        {
            get
            {
                return (base.OwnerBase == null);
            }
        }

        internal DocumentObject NextWidgetSibling
        {
            get
            {
                Paragraph owner = base.Owner as Paragraph;
                if ((owner != null) && (owner.WidgetCollection != null))
                {
                    return (owner.WidgetCollection as DocumentObjectCollection).method_8(this);
                }
                return null;
            }
        }

        public Paragraph OwnerParagraph
        {
            get
            {
                return (base.Owner as Paragraph);
            }
        }

        internal DocumentObject PreviousWidgetSibling
        {
            get
            {
                Paragraph owner = base.Owner as Paragraph;
                if ((owner != null) && (owner.WidgetCollection != null))
                {
                    return (owner.WidgetCollection as DocumentObjectCollection).method_9(this);
                }
                return null;
            }
        }

        internal bool SkipDocxItem
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        int IRunAttrSource.DirectRunAttrsCount
        {
            get
            {
                return this.CharacterFormat.Count;
            }
        }

        internal int StartPos
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_2 = value;
            }
        }

        public string StyleName
        {
            get
            {
                if (this.m_charFormat != null)
                {
                    return this.m_charFormat.CharStyleName;
                }
                return string.Empty;
            }
        }
    }
}

