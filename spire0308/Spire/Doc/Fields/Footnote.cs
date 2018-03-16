namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class Footnote : ParagraphBase, Interface2
    {
        private Body body_0;
        private bool bool_7;
        private bool bool_8;
        private byte byte_4;
        private Spire.Doc.FootnoteType footnoteType_0;
        internal const int int_4 = 0x26;
        internal const int int_5 = 0x27;
        private int[] int_6;
        private int int_7;
        private long long_4;
        private string string_10;
        private string string_11;
        private string[] string_8;
        private string[] string_9;

        public Footnote(IDocument doc) : base((Document) doc)
        {
            this.string_10 = BookmarkStart.b("砪听䈮匰尲头", 5);
            this.string_11 = string.Empty;
            this.body_0 = new Body(base.Document, this);
            base.m_charFormat = new CharacterFormat(base.Document);
            base.m_charFormat.method_0(this);
        }

        internal Footnote(IDocument A_0, string A_1) : this(A_0)
        {
            this.string_11 = A_1;
            this.bool_7 = false;
        }

        internal override bool Accept(Class420 visitor)
        {
            visitor.vmethod_26(this);
            this.method_34();
            this.TextBody.Accept(visitor);
            return base.method_12(visitor.vmethod_29(this));
        }

        protected override object CloneImpl()
        {
            Footnote footnote = (Footnote) base.CloneImpl();
            footnote.body_0 = (Body) this.body_0.Clone();
            footnote.body_0.method_0(footnote);
            return footnote;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            base.CloneRelationsTo(doc, nextOwner);
            if (this.body_0 != null)
            {
                this.body_0.CloneRelationsTo(doc, nextOwner);
            }
        }

        internal override void Close()
        {
            base.Close();
            if (this.body_0 != null)
            {
                this.body_0.method_28();
                this.body_0 = null;
            }
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class209(ChildrenLayoutDirection.Horizontal);
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("唶嘸强䐼", 0x11), this.body_0);
            base.XDLSHolder.AddElement(BookmarkStart.b("娶堸䤺嘼娾㍀湂♄⽆⡈㥊ⱌⱎ═㙒❔穖㽘㑚⽜㉞`ᝢ", 0x11), base.m_charFormat);
        }

        private void method_30(bool A_0)
        {
            if (!base.Document.bool_3 && (this.bool_7 || !string.IsNullOrEmpty(this.string_11)))
            {
                string str2 = string.Empty;
                string str = string.Empty;
                if (!A_0)
                {
                    str = '\x0002'.ToString();
                    str2 = this.string_11;
                }
                else
                {
                    str = this.string_11;
                    str2 = '\x0002'.ToString();
                }
                this.method_33(str, str2);
            }
        }

        private void method_31(string A_0)
        {
            if (!base.Document.bool_3 && !string.IsNullOrEmpty(this.string_11))
            {
                this.method_33(this.string_11, A_0);
            }
        }

        private void method_32(byte A_0)
        {
            if (((!base.Document.bool_3 && (this.body_0.Items.Count != 0)) && (!this.bool_7 && (A_0 > 0))) && !string.IsNullOrEmpty(this.string_11))
            {
                Paragraph paragraph = this.body_0.Items[0] as Paragraph;
                TextSelection selection = paragraph.Find(this.string_11, true, true);
                TextRange range = this.method_36(A_0);
                this.method_37(range, paragraph, selection);
                base.m_charFormat.FontName = this.string_10;
                this.method_39(false);
            }
        }

        internal void method_33(string A_0, string A_1)
        {
            if (this.body_0.Items.Count != 0)
            {
                Paragraph paragraph = this.body_0.Items[0] as Paragraph;
                if (!string.IsNullOrEmpty(A_0))
                {
                    TextSelection selection = paragraph.Find(A_0, true, true);
                    this.method_40(selection, A_1);
                }
                else
                {
                    this.method_41(A_1, paragraph);
                }
                this.method_39(false);
            }
        }

        internal void method_34()
        {
            if (this.int_7 > 0)
            {
                if (!this.bool_7 && (this.byte_4 > 0))
                {
                    this.method_35();
                    this.method_39(false);
                }
                else
                {
                    string str = this.bool_7 ? '\x0002'.ToString() : this.string_11;
                    if (str.TrimStart(new char[] { ' ' }) != string.Empty)
                    {
                        str = str.TrimStart(new char[] { ' ' });
                    }
                    if (this.body_0.Items.Count == 0)
                    {
                        Paragraph paragraph = new Paragraph(base.m_doc);
                        this.method_41(str, paragraph);
                        this.body_0.Items.Insert(0, paragraph);
                    }
                    else
                    {
                        Paragraph paragraph2 = this.body_0.Items[0] as Paragraph;
                        TextSelection selection = paragraph2.Find(str, true, true);
                        if (selection == null)
                        {
                            this.method_41(str, paragraph2);
                        }
                        else
                        {
                            this.method_40(selection, str);
                        }
                    }
                    this.method_39(false);
                }
            }
        }

        private void method_35()
        {
            int num = 14;
            TextRange entity = this.method_36(this.byte_4);
            base.m_charFormat.FontName = this.string_10;
            if (this.body_0.Items.Count == 0)
            {
                Paragraph paragraph = new Paragraph(base.m_doc);
                paragraph.Items.Add(entity);
                paragraph.AppendText(BookmarkStart.b("ᐳ", num));
                this.body_0.Items.Insert(0, paragraph);
            }
            else
            {
                string given = this.bool_7 ? '\x0002'.ToString() : this.string_11;
                Paragraph paragraph2 = this.body_0.Items[0] as Paragraph;
                TextSelection selection = null;
                if (given != string.Empty)
                {
                    selection = paragraph2.Find(given, true, true);
                }
                this.method_37(entity, paragraph2, selection);
            }
        }

        private TextRange method_36(byte A_0)
        {
            TextRange range = new TextRange(base.Document);
            range.Text = ((char) A_0).ToString();
            range.CharacterFormat.ImportContainer(base.m_charFormat);
            range.CharacterFormat.FontName = this.string_10;
            return range;
        }

        private void method_37(TextRange A_0, Paragraph A_1, TextSelection A_2)
        {
            int num2 = 9;
            if (A_2 == null)
            {
                A_1.Items.Insert(0, A_0);
                TextRange entity = new TextRange(A_1.Document) {
                    Text = BookmarkStart.b("༮", num2)
                };
                A_1.Items.Insert(1, entity);
            }
            else
            {
                TextRange asOneRange = A_2.GetAsOneRange();
                int index = asOneRange.method_5();
                A_1.Items.Remove(asOneRange);
                A_1.Items.Insert(index, A_0);
            }
        }

        internal void method_38()
        {
            if (!base.Document.bool_3)
            {
                string charStyleName = base.m_charFormat.CharStyleName;
                Style style = null;
                if (!string.IsNullOrEmpty(charStyleName))
                {
                    style = base.Document.Styles.FindByName(charStyleName);
                }
                if ((style == null) || ((style.StyleDocId != 0x27) && (style.StyleDocId != 0x26)))
                {
                    Class11 class2 = null;
                    if (this.footnoteType_0 == Spire.Doc.FootnoteType.Footnote)
                    {
                        class2 = (Class11) Style.CreateBuiltinStyle(BuiltinStyle.FootnoteReference, StyleType.CharacterStyle, base.Document);
                    }
                    else if (this.footnoteType_0 == Spire.Doc.FootnoteType.Endnote)
                    {
                        class2 = (Class11) Style.CreateBuiltinStyle(BuiltinStyle.EndnoteReference, StyleType.CharacterStyle, base.Document);
                    }
                    if (class2 != null)
                    {
                        base.m_charFormat.CharStyleName = class2.Name;
                        base.Document.Styles.Add(class2);
                    }
                }
            }
        }

        private void method_39(bool A_0)
        {
            if (!base.Document.bool_3)
            {
                if (A_0)
                {
                    this.int_7++;
                }
                else
                {
                    this.int_7--;
                }
            }
        }

        private void method_40(TextSelection A_0, string A_1)
        {
            if (A_0 != null)
            {
                A_0.GetAsOneRange().Text = A_1;
            }
        }

        private void method_41(string A_0, Paragraph A_1)
        {
            TextRange entity = this.method_42(A_0);
            A_1.Items.Insert(0, entity);
            TextRange range2 = new TextRange(this.body_0.Document) {
                Text = BookmarkStart.b("ሱ", 12)
            };
            A_1.Items.Insert(1, range2);
        }

        private TextRange method_42(string A_0)
        {
            TextRange range = new TextRange(base.m_doc) {
                Text = A_0
            };
            range.CharacterFormat.ImportContainer(base.m_charFormat);
            return range;
        }

        internal override void OnStateChange(object sender)
        {
            if (sender is CharacterFormat)
            {
                this.method_39(true);
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x10;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("眵䴷丹医瀽㔿⽁♃⍅㩇⽉⡋", 0x10)))
            {
                this.bool_7 = reader.ReadBoolean(BookmarkStart.b("眵䴷丹医瀽㔿⽁♃⍅㩇⽉⡋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("电䴷䤹䠻儽ⴿཁ╃㑅⍇⽉㹋", num)))
            {
                this.string_11 = reader.ReadString(BookmarkStart.b("电䴷䤹䠻儽ⴿཁ╃㑅⍇⽉㹋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("缵䬷缹刻娽⸿ⵁぃ⍅े㹉㡋㱍", num)))
            {
                this.footnoteType_0 = reader.ReadBoolean(BookmarkStart.b("缵䬷缹刻娽⸿ⵁぃ⍅े㹉㡋㱍", num)) ? Spire.Doc.FootnoteType.Endnote : Spire.Doc.FootnoteType.Footnote;
            }
            if (reader.HasAttribute(BookmarkStart.b("攵䄷圹帻儽ⰿŁ⭃≅ⵇ", num)))
            {
                this.byte_4 = reader.ReadByte(BookmarkStart.b("攵䄷圹帻儽ⰿŁ⭃≅ⵇ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("攵䄷圹帻儽ⰿс⭃⡅㱇щⵋ⍍㕏", num)))
            {
                this.string_10 = reader.ReadString(BookmarkStart.b("攵䄷圹帻儽ⰿс⭃⡅㱇щⵋ⍍㕏", num));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.method_201(this, ltWidget, (base.interface23_0 as Class209).method_15());
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            SizeF empty = SizeF.Empty;
            if (!dc.method_127().Contains(this) && (this.FootnoteType == Spire.Doc.FootnoteType.Endnote))
            {
                dc.method_127().Add(this);
            }
            if (!this.IsAutoNumbered)
            {
                return empty;
            }
            string str = string.Empty;
            Section section = base.method_2();
            if (section == null)
            {
                return empty;
            }
            FootEndnoteOptions endnoteOptions = null;
            if (this.FootnoteType == Spire.Doc.FootnoteType.Endnote)
            {
                endnoteOptions = section.EndnoteOptions;
                endnoteOptions.ApplyBase(base.m_doc.EndnoteOptions);
            }
            else
            {
                endnoteOptions = section.FootnoteOptions;
                endnoteOptions.ApplyBase(base.m_doc.FootnoteOptions);
            }
            if (!(((Interface1) this).imethod_0() as Class205).method_5())
            {
                if (this.FootnoteType == Spire.Doc.FootnoteType.Footnote)
                {
                    if (endnoteOptions.RestartRule != FootnoteRestartRule.RestartPage)
                    {
                        Class500 class1 = dc.method_28();
                        class1.method_7(class1.method_6() + 1);
                    }
                    else
                    {
                        dc.method_28().method_7(dc.method_28().method_4().Count + 1);
                    }
                    str = ListLevel.smethod_2(dc.method_28().method_6(), endnoteOptions.NumberFormat);
                }
                else
                {
                    if (endnoteOptions.RestartRule != FootnoteRestartRule.DoNotRestart)
                    {
                        Class500 class2 = dc.method_28();
                        class2.method_12(class2.method_11() + 1);
                    }
                    else
                    {
                        dc.method_28().method_12(dc.method_127().Count);
                    }
                    str = ListLevel.smethod_2(dc.method_28().method_11(), endnoteOptions.NumberFormat);
                }
                (base.interface23_0 as Class209).method_16(str);
            }
            else
            {
                str = (base.interface23_0 as Class209).method_15();
            }
            return dc.method_322(str, this.MarkerCharacterFormat);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 10;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("䐯䬱䐳匵", 10), Spire.Doc.FootnoteType.Footnote);
            writer.WriteValue(BookmarkStart.b("焯䜱䀳夵瘷伹儻尽┿ぁ⅃≅", 10), this.bool_7);
            if (this.footnoteType_0 == Spire.Doc.FootnoteType.Endnote)
            {
                writer.WriteValue(BookmarkStart.b("礯䄱焳堵尷吹医䨽┿́ぃ㉅㩇", num), true);
            }
            if (this.string_11 != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("猯䜱䜳䈵圷圹焻弽㈿⥁⅃㑅", num), this.string_11);
            }
            if (this.CustomMarkerIsSymbol)
            {
                writer.WriteValue(BookmarkStart.b("振䬱夳吵圷嘹缻儽␿❁", num), (int) this.byte_4);
                writer.WriteValue(BookmarkStart.b("振䬱夳吵圷嘹稻儽⸿㙁੃❅╇⽉", num), this.string_10);
            }
        }

        public string CustomMarker
        {
            get
            {
                return this.string_11;
            }
            set
            {
                if (((value != this.string_11) && !this.bool_7) && !base.Document.bool_3)
                {
                    this.method_39(true);
                    this.method_31(value);
                }
                this.string_11 = value;
            }
        }

        internal bool CustomMarkerIsSymbol
        {
            get
            {
                return (this.byte_4 > 0);
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Footnote;
            }
        }

        public Spire.Doc.FootnoteType FootnoteType
        {
            get
            {
                return this.footnoteType_0;
            }
            set
            {
                this.footnoteType_0 = value;
            }
        }

        public bool IsAutoNumbered
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                if (this.bool_7 != value)
                {
                    if (!base.Document.bool_3)
                    {
                        this.method_39(true);
                        this.method_30(value);
                    }
                    this.bool_7 = value;
                }
            }
        }

        public CharacterFormat MarkerCharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
        }

        public byte SymbolCode
        {
            get
            {
                return this.byte_4;
            }
            set
            {
                if ((value != this.byte_4) && !base.Document.bool_3)
                {
                    this.method_39(true);
                    this.method_32(value);
                }
                this.byte_4 = value;
            }
        }

        internal string SymbolFontName
        {
            get
            {
                return this.string_10;
            }
            set
            {
                if ((value != this.string_10) && !base.Document.bool_3)
                {
                    this.method_39(true);
                }
                this.string_10 = value;
            }
        }

        public Body TextBody
        {
            get
            {
                return this.body_0;
            }
        }

        public bool UseAbsolutePos
        {
            get
            {
                return this.bool_8;
            }
            set
            {
                this.bool_8 = value;
            }
        }
    }
}

