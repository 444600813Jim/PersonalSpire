namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public class ParagraphStyle : Style, IParagraphStyle
    {
        private bool bool_11;
        private int int_10;
        private int int_9;
        protected Spire.Doc.Formatting.ListFormat m_listFormat;

        public ParagraphStyle(IDocument doc) : this(doc, true)
        {
        }

        internal ParagraphStyle(IDocument A_0, BuiltinStyle A_1) : this(A_0, A_1 != BuiltinStyle.Normal)
        {
        }

        internal ParagraphStyle(IDocument A_0, bool A_1) : base((Document) A_0)
        {
            this.int_9 = -1;
            this.int_10 = -1;
            base.m_ParaPr = new Spire.Doc.Formatting.ParagraphFormat(base.Document);
            base.m_ParaPr.method_0(this);
            if (A_1 && (A_0 as Document).bool_6)
            {
                (A_0 as Document).bool_6 = false;
                base.ApplyBaseStyle(BuiltinStyle.Normal);
                (A_0 as Document).bool_6 = true;
            }
        }

        internal override void ApplyBaseStyle(IStyle bStyle)
        {
            base.ApplyBaseStyle(bStyle);
            if (this.BaseStyle != null)
            {
                base.m_ParaPr.ApplyBase(this.BaseStyle.ParagraphFormat);
            }
        }

        public override void ApplyBaseStyle(string styleName)
        {
            base.ApplyBaseStyle(styleName);
            if (this.BaseStyle != null)
            {
                base.m_ParaPr.ApplyBase(this.BaseStyle.ParagraphFormat);
            }
        }

        public override IStyle Clone()
        {
            return (ParagraphStyle) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            ParagraphStyle style = (ParagraphStyle) base.CloneImpl();
            style.m_ParaPr = new Spire.Doc.Formatting.ParagraphFormat(base.Document);
            style.m_ParaPr.ImportContainer(this.ParagraphFormat);
            style.m_ParaPr.method_0(style);
            style.m_listFormat = new Spire.Doc.Formatting.ListFormat(base.Document, this);
            style.m_listFormat.ImportContainer(this.ListFormat);
            style.m_listFormat.method_0(style);
            style.m_listFormat.IsEmptyList = this.ListFormat.IsEmptyList;
            if (this.BaseStyle != null)
            {
                style.ApplyBaseStyle(this.BaseStyle.Clone());
            }
            return style;
        }

        protected override IStyle CloneStyleTo(Document doc)
        {
            ParagraphStyle style = (ParagraphStyle) base.CloneImpl();
            style.m_ParaPr = new Spire.Doc.Formatting.ParagraphFormat(base.Document);
            style.m_ParaPr.ImportContainer(this.ParagraphFormat);
            style.m_ParaPr.method_0(style);
            style.m_listFormat = new Spire.Doc.Formatting.ListFormat(base.Document, this);
            style.m_listFormat.ImportContainer(this.ListFormat);
            style.m_listFormat.method_0(style);
            style.m_listFormat.IsEmptyList = this.ListFormat.IsEmptyList;
            if (this.BaseStyle != null)
            {
                style.ApplyBaseStyle(this.BaseStyle.CloneStyleTo(doc));
            }
            style.method_24(doc);
            return style;
        }

        internal override void Close()
        {
            base.Close();
            if (base.m_ParaPr != null)
            {
                base.m_ParaPr.Close();
                base.m_ParaPr = null;
            }
            if (this.m_listFormat != null)
            {
                this.m_listFormat.Close();
                this.m_listFormat = null;
            }
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䜶堸䤺尼堾㍀≂㕄⽆摈ⵊ≌㵎㱐㉒⅔", 0x11), base.m_ParaPr);
        }

        private void method_23()
        {
            if (base.Document != null)
            {
                if (base.Document.DefCharFormat != null)
                {
                    base.m_chFormat.method_25(base.Document.DefCharFormat);
                }
                if (base.Document.DefParaFormat != null)
                {
                    base.m_ParaPr.method_25(base.Document.DefParaFormat);
                }
            }
        }

        internal void method_24(Document A_0)
        {
            int num = 15;
            if (this.ListFormat.ListType != ListType.NoList)
            {
                ListStyle currentListStyle = this.ListFormat.CurrentListStyle;
                if ((currentListStyle != null) && (A_0.ListStyles.FindByName(currentListStyle.Name) == null))
                {
                    A_0.ListStyles.Add((ListStyle) currentListStyle.Clone());
                }
                if (currentListStyle != null)
                {
                    this.ListFormat.CurrentListLevel.ParaStyleName = base.Name.Replace(BookmarkStart.b("ᔴ", num), string.Empty);
                }
            }
            if ((this.ListFormat.LFOStyleName != null) && (A_0.ListOverrides.method_35(this.ListFormat.LFOStyleName) == null))
            {
                Class12 class2 = base.Document.ListOverrides.method_35(this.ListFormat.LFOStyleName);
                if (class2 != null)
                {
                    A_0.ListOverrides.method_34((Class12) class2.Clone());
                }
            }
        }

        public ParagraphStyle BaseStyle
        {
            get
            {
                return (base.BaseStyle as ParagraphStyle);
            }
        }

        public Spire.Doc.Formatting.ListFormat ListFormat
        {
            get
            {
                if (this.m_listFormat == null)
                {
                    this.m_listFormat = new Spire.Doc.Formatting.ListFormat(base.Document, this);
                }
                return this.m_listFormat;
            }
        }

        internal int ListIndex
        {
            get
            {
                return this.int_9;
            }
            set
            {
                this.int_9 = value;
            }
        }

        internal int ListLevel
        {
            get
            {
                return this.int_10;
            }
            set
            {
                this.int_10 = value;
            }
        }

        public Spire.Doc.Formatting.ParagraphFormat ParagraphFormat
        {
            get
            {
                return base.m_ParaPr;
            }
        }

        internal override Spire.Doc.Formatting.ParagraphFormat ParaPr
        {
            get
            {
                return base.m_ParaPr;
            }
        }

        public override Spire.Doc.Documents.StyleType StyleType
        {
            get
            {
                return Spire.Doc.Documents.StyleType.ParagraphStyle;
            }
        }
    }
}

