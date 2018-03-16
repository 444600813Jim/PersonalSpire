namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class CheckBoxFormField : FormField, Interface2
    {
        private bool bool_39;
        private byte[] byte_6;
        private CheckBoxSizeType checkBoxSizeType_0;
        private int int_13;
        private int[] int_14;
        private int[] int_15;
        private long[] long_6;

        public CheckBoxFormField(IDocument doc) : base(doc)
        {
            base.m_curFormFieldType = FormFieldType.CheckBox;
            base.m_paraItemType = ParagraphItemType.CheckBox;
            base.Type = FieldType.FieldFormCheckBox;
            base.Params = 0xe5;
            this.int_13 = 20;
        }

        protected override object CloneImpl()
        {
            return (CheckBoxFormField) base.CloneImpl();
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 11;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("爰嬲倴吶券示刼䜾ቀ⩂㽄≆", 11)))
            {
                this.int_13 = reader.ReadShort(BookmarkStart.b("爰嬲倴吶券示刼䜾ቀ⩂㽄≆", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("田嘲匴嘶䰸场䤼簾⥀♂♄ⱆୈ⑊㕌᥎ぐ㽒⁔㉖", num)))
            {
                this.bool_39 = reader.ReadBoolean(BookmarkStart.b("田嘲匴嘶䰸场䤼簾⥀♂♄ⱆୈ⑊㕌᥎ぐ㽒⁔㉖", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("爰嬲倴吶券示刼䜾ቀ⩂㽄≆ᵈ㉊㵌⩎", num)))
            {
                this.SizeType = (CheckBoxSizeType) reader.ReadEnum(BookmarkStart.b("爰嬲倴吶券示刼䜾ቀ⩂㽄≆ᵈ㉊㵌⩎", num), typeof(CheckBoxSizeType));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.method_305(this, ltWidget);
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            if (this.checkBoxSizeType_0 != CheckBoxSizeType.Auto)
            {
                return new SizeF((float) this.int_13, (float) this.int_13);
            }
            TextRange range = this;
            float fontSize = range.CharacterFormat.FontSize;
            return new SizeF(fontSize, fontSize);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("猯娱儳唵匷砹医䘽ጿ⭁㹃⍅", 10), this.int_13);
            writer.WriteValue(BookmarkStart.b("猯娱儳唵匷砹医䘽ጿ⭁㹃⍅᱇㍉㱋⭍", 10), this.SizeType);
            writer.WriteValue(BookmarkStart.b("琯圱刳圵䴷嘹䠻紽⠿❁❃ⵅੇ╉㑋ᡍㅏ㹑⅓㍕", 10), this.bool_39);
        }

        public int CheckBoxSize
        {
            get
            {
                return this.int_13;
            }
            set
            {
                this.int_13 = value;
            }
        }

        public bool Checked
        {
            get
            {
                switch (base.InnerValue)
                {
                    case 0:
                        return false;

                    case 1:
                        return true;
                }
                return this.bool_39;
            }
            set
            {
                base.InnerValue = value ? 1 : 0;
            }
        }

        public bool DefaultCheckBoxValue
        {
            get
            {
                return this.bool_39;
            }
            set
            {
                this.bool_39 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.CheckBox;
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

        public CheckBoxSizeType SizeType
        {
            get
            {
                if ((base.Params & 0x400) != 0x400)
                {
                    return CheckBoxSizeType.Auto;
                }
                return CheckBoxSizeType.Exactly;
            }
            set
            {
                this.checkBoxSizeType_0 = value;
                if (value == CheckBoxSizeType.Exactly)
                {
                    base.Params = (short) Class1012.smethod_8(base.Params, 0x400, 10, 1);
                }
                else
                {
                    base.Params = (short) Class1012.smethod_8(base.Params, 0x400, 10, 0);
                }
            }
        }
    }
}

