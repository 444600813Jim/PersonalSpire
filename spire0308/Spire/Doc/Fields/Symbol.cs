namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;

    public class Symbol : ParagraphBase, Interface2
    {
        private bool bool_7;
        private bool[] bool_8;
        private byte byte_4;
        private byte byte_5;
        private byte byte_6;
        private string string_10;
        private string string_8;
        private string[] string_9;

        public Symbol(IDocument doc) : base((Document) doc)
        {
            this.string_10 = BookmarkStart.b("簮䠰帲圴堶唸", 9);
            this.byte_6 = 240;
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(doc);
            base.m_charFormat.method_0(this);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_17(this));
        }

        protected override object CloneImpl()
        {
            return (Symbol) base.CloneImpl();
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205();
            base.interface23_0.imethod_5(false);
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("圳帵夷䠹崻崽㐿❁㙃歅⹇╉㹋⍍ㅏ♑", 14), base.m_charFormat);
        }

        internal TextRange method_30()
        {
            TextRange range = new TextRange(base.Document);
            string str = char.ConvertFromUtf32(this.CharacterCode);
            Spire.Doc.Formatting.CharacterFormat characterFormat = range.CharacterFormat;
            characterFormat.ImportContainer(this.CharacterFormat);
            characterFormat.method_21(this.CharacterFormat);
            if ((!this.CharacterFormat.HasValue(0) && !string.IsNullOrEmpty(this.FontName)) && (this.FontName != this.CharacterFormat.FontName))
            {
                characterFormat.ApplyBase(base.method_28().BreakCharacterFormat.BaseFormat);
                characterFormat.FontSize = this.CharacterFormat.FontSize;
            }
            range.Text = str;
            range.method_0(base.Owner);
            return range;
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("縷唹刻䨽฿⍁⥃⍅", 0x12)))
            {
                this.FontName = reader.ReadString(BookmarkStart.b("縷唹刻䨽฿⍁⥃⍅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷刹崻䰽̿ⵁ⁃⍅", num)))
            {
                this.CharacterCode = reader.ReadByte(BookmarkStart.b("笷刹崻䰽̿ⵁ⁃⍅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷刹崻䰽̿ⵁ⁃⍅േ㉉㡋", num)))
            {
                this.CharCodeExt = reader.ReadByte(BookmarkStart.b("笷刹崻䰽̿ⵁ⁃⍅േ㉉㡋", num));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.method_209(this, ltWidget);
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            SizeF ef = new SizeF();
            string str = char.ConvertFromUtf32(this.CharacterCode);
            Spire.Doc.Formatting.CharacterFormat characterFormat = this.CharacterFormat;
            if ((!this.CharacterFormat.HasValue(0) && (this.FontName != string.Empty)) && (this.FontName != this.CharacterFormat.FontName))
            {
                characterFormat = new Spire.Doc.Formatting.CharacterFormat(base.Document);
                characterFormat.ImportContainer(this.CharacterFormat);
                characterFormat.method_21(this.CharacterFormat);
                characterFormat.ApplyBase(base.method_28().BreakCharacterFormat.BaseFormat);
                characterFormat.FontSize = this.CharacterFormat.FontSize;
                characterFormat.FontName = this.FontName;
            }
            if (this.CharacterFormat.IsSmallCaps)
            {
                ef = dc.method_1() ? dc.method_310(str, dc.method_376(characterFormat), null, true) : dc.method_317(str, dc.method_365(characterFormat), null, true);
            }
            else
            {
                ef = dc.method_1() ? dc.method_309(str, dc.method_376(characterFormat), null) : dc.method_316(str, dc.method_365(characterFormat), null);
            }
            ef.Height = this.CharacterFormat.FontSize;
            characterFormat = null;
            return ef;
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("堫圭䀯圱", 6), ParagraphItemType.Symbol);
            writer.WriteValue(BookmarkStart.b("樫䄭帯䘱稳圵唷弹", 6), this.FontName);
            writer.WriteValue(BookmarkStart.b("漫䘭儯䀱眳夵尷弹", 6), (int) this.CharacterCode);
            writer.WriteValue(BookmarkStart.b("漫䘭儯䀱眳夵尷弹礻䘽㐿", 6), (int) this.CharCodeExt);
        }

        public byte CharacterCode
        {
            get
            {
                return this.byte_5;
            }
            set
            {
                this.byte_5 = value;
            }
        }

        public override Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
        }

        internal byte CharCodeExt
        {
            get
            {
                return this.byte_6;
            }
            set
            {
                this.byte_6 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Symbol;
            }
        }

        public string FontName
        {
            get
            {
                return this.string_10;
            }
            set
            {
                this.string_10 = value;
            }
        }

        internal char Text
        {
            get
            {
                return BitConverter.ToChar(new byte[] { this.CharacterCode, this.CharCodeExt }, 0);
            }
        }
    }
}

