namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class TextFormField : FormField, Interface2
    {
        private byte[] byte_6;
        private byte byte_7;
        private float float_3;
        private int int_13;
        private long long_6;
        internal const string string_24 = "     ";
        private string[] string_25;
        private string string_26;
        private string string_27;
        private string[] string_28;
        private TextFormFieldType textFormFieldType_0;
        private Spire.Doc.Fields.TextRange textRange_1;

        public TextFormField(IDocument doc) : base(doc)
        {
            base.m_curFormFieldType = FormFieldType.TextInput;
            base.m_paraItemType = ParagraphItemType.TextFormField;
            base.Type = FieldType.FieldFormTextInput;
            base.Params = 0x80;
            this.string_26 = string.Empty;
            this.textRange_1 = new Spire.Doc.Fields.TextRange(doc);
            this.string_27 = string.Empty;
        }

        protected override object CloneImpl()
        {
            return (TextFormField) base.CloneImpl();
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = (this.Text == BookmarkStart.b("ㄷ", 0x12)) ? new Spire.Doc.Fields.TextRange.Class207(this) : new Class205(ChildrenLayoutDirection.Horizontal);
            if (this.TextRange != null)
            {
                this.CharacterFormat.method_21(this.TextRange.CharacterFormat);
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("娭唯䨱䀳ᬵ䨷嬹刻夽┿", 8), this.textRange_1);
        }

        private int method_248()
        {
            int num = 0;
            foreach (DocumentObject obj2 in base.Range)
            {
                if ((!(obj2 is FieldMark) && !(obj2 is BookmarkEnd)) && !(obj2 is BookmarkStart))
                {
                    num++;
                }
            }
            return num;
        }

        private void method_249()
        {
            switch (this.TextFieldType)
            {
                case TextFormFieldType.CurrentDate:
                case TextFormFieldType.CurrentTime:
                    base.method_80((base.Range.method_9() as Field).FormattingString);
                    base.method_229(this, 0, base.Range.InnerList.IndexOf(base.Separator));
                    return;

                case TextFormFieldType.Calculation:
                    base.method_134(this.DefaultText);
                    base.method_229(this, 0, base.Range.InnerList.IndexOf(base.Separator));
                    return;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x11;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("稶堸䌺焼娾⽀⑂ㅄ⽆", 0x11)))
            {
                this.int_13 = reader.ReadInt(BookmarkStart.b("稶堸䌺焼娾⽀⑂ㅄ⽆", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("猶尸崺尼䨾ⵀ㝂ᅄ≆ㅈ㽊", num)))
            {
                this.string_26 = reader.ReadString(BookmarkStart.b("猶尸崺尼䨾ⵀ㝂ᅄ≆ㅈ㽊", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("搶䴸䤺吼儾♀ᝂ⁄㽆㵈ൊ≌㵎㱐㉒⅔", num)))
            {
                this.string_27 = reader.ReadString(BookmarkStart.b("搶䴸䤺吼儾♀ᝂ⁄㽆㵈ൊ≌㵎㱐㉒⅔", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("挶尸䌺䤼款㡀㍂⁄", num)))
            {
                this.textFormFieldType_0 = (TextFormFieldType) reader.ReadEnum(BookmarkStart.b("挶尸䌺䤼款㡀㍂⁄", num), typeof(TextFormFieldType));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            if (this.method_248() == 0)
            {
                dc.method_199(this.TextRange, ltWidget, this.TextRange.Text);
            }
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            if (this.method_248() == 0)
            {
                return dc.method_323(this.TextRange, this.TextRange.Text);
            }
            this.method_249();
            return new SizeF();
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("愫伭䠯縱儳堵強丹吻", 6), this.int_13);
            writer.WriteValue(BookmarkStart.b("栫䬭嘯匱䄳娵䰷渹夻䘽㐿", 6), this.string_26);
            writer.WriteValue(BookmarkStart.b("缫娭䈯嬱娳儵氷弹䐻䨽ؿⵁ㙃⭅⥇㹉", 6), this.string_27);
            writer.WriteValue(BookmarkStart.b("砫䬭䠯䘱怳伵䠷弹", 6), (int) this.textFormFieldType_0);
        }

        public string DefaultText
        {
            get
            {
                return this.string_26;
            }
            set
            {
                this.string_26 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.TextFormField;
            }
        }

        Interface23 Interface1.LayoutInfo
        {
            get
            {
                if (base.interface23_0 == null)
                {
                    this.CreateLayoutInfo();
                }
                return base.interface23_0;
            }
        }

        internal bool IsDefaultText
        {
            get
            {
                return (this.TextRange.Text == BookmarkStart.b("㔖㬘㤚㼜㴞", 0x11));
            }
        }

        public int MaximumLength
        {
            get
            {
                return this.int_13;
            }
            set
            {
                int num = 11;
                if ((value < this.string_26.Length) && (value != 0))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("簰刲䴴帶吸为值猾⑀ⵂ≄㍆ⅈ歊⑌㱎煐㽒㩔⁖㱘⥚絜⭞ॠɢ୤䝦੨ṪὬᵮᑰᵲŴ坶൸Ṻռ୾ꆀﾊ", num));
                }
                this.int_13 = value;
            }
        }

        public string StringFormat
        {
            get
            {
                return this.string_27;
            }
            set
            {
                this.string_27 = value;
            }
        }

        public override string Text
        {
            get
            {
                if (((this.textRange_1 != null) && (this.CharacterFormat != null)) && !this.CharacterFormat.IsDefault)
                {
                    this.textRange_1.CharacterFormat.ImportContainer(this.CharacterFormat);
                    this.textRange_1.CharacterFormat.method_21(this.CharacterFormat);
                }
                if ((base.Range != null) && (base.Range.Count > 2))
                {
                    return string.Empty;
                }
                return this.textRange_1.Text;
            }
            set
            {
                int num = 9;
                if ((base.Range != null) && (base.Range.Count > 2))
                {
                    for (int i = base.Range.method_8().Count - 1; i >= 0; i--)
                    {
                        object obj2 = base.Range.method_8()[i];
                        if (obj2 is Paragraph)
                        {
                            (obj2 as Paragraph).OwnerTextBody.Items.Remove(obj2 as DocumentObject);
                            base.Range.method_8().Remove(obj2);
                        }
                        else if (obj2 is Spire.Doc.Fields.TextRange)
                        {
                            base.OwnerParagraph.Items.Remove(obj2 as DocumentObject);
                            base.Range.method_8().Remove(obj2);
                        }
                    }
                }
                if ((!base.Document.bool_3 && (base.FormFieldType == FormFieldType.TextInput)) && string.IsNullOrEmpty(value))
                {
                    this.textRange_1.Text = BookmarkStart.b("ⴎ㌐ㄒ㜔㔖", num);
                }
                else
                {
                    this.textRange_1.Text = value;
                }
            }
        }

        public TextFormFieldType TextFieldType
        {
            get
            {
                return this.textFormFieldType_0;
            }
            set
            {
                this.textFormFieldType_0 = value;
            }
        }

        public Spire.Doc.Fields.TextRange TextRange
        {
            get
            {
                int num = 15;
                if ((base.Range != null) && (base.Range.Count > 2))
                {
                    string str = string.Empty;
                    foreach (object obj2 in base.Range)
                    {
                        if (obj2 is Paragraph)
                        {
                            str = str + (obj2 as Paragraph).Text + BookmarkStart.b("㠴", num);
                        }
                        else if (obj2 is Spire.Doc.Fields.TextRange)
                        {
                            str = str + (obj2 as Spire.Doc.Fields.TextRange).Text;
                        }
                    }
                    this.textRange_1.Text = str;
                    str = string.Empty;
                }
                return this.textRange_1;
            }
            set
            {
                this.textRange_1 = value;
            }
        }
    }
}

