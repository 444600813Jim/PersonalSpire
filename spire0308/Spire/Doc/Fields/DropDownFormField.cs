namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using Spire.Doc.Rendering;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class DropDownFormField : FormField, Interface2
    {
        private bool bool_39;
        private bool bool_40;
        private DropDownCollection dropDownCollection_0;
        private float float_3;
        private short short_1;
        private string[] string_24;

        public DropDownFormField(IDocument doc) : base(doc)
        {
            base.m_curFormFieldType = FormFieldType.DropDown;
            base.m_paraItemType = ParagraphItemType.DropDownFormField;
            base.Type = FieldType.FieldFormDropDown;
            base.Params = 0x80e6;
            this.dropDownCollection_0 = new DropDownCollection(base.Document);
        }

        protected override object CloneImpl()
        {
            DropDownFormField field = (DropDownFormField) base.CloneImpl();
            field.dropDownCollection_0 = new DropDownCollection(base.Document);
            this.dropDownCollection_0.method_6(field.dropDownCollection_0);
            return field;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("唰䄲娴䜶崸吺䨼儾汀⩂ㅄ≆⑈㡊", 11), this.dropDownCollection_0);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("戥䴧䰩䴫嬭尯䘱瀳䐵圷䴹砻儽㜿ⱁቃ❅⑇㽉⥋", 0)))
            {
                this.short_1 = reader.ReadShort(BookmarkStart.b("戥䴧䰩䴫嬭尯䘱瀳䐵圷䴹砻儽㜿ⱁቃ❅⑇㽉⥋", num));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            string dropDownValue = string.Empty;
            if (this.dropDownCollection_0.Count > 0)
            {
                dropDownValue = this.DropDownValue;
            }
            Class198 class2 = new Class198 {
                drawingTextDirection_0 = DrawingTextDirection.Horizontal
            };
            dc.method_233(dropDownValue, this.CharacterFormat, null, ltWidget.method_69(), ltWidget.method_69().Width, class2);
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            string dropDownValue = string.Empty;
            if (this.dropDownCollection_0.Count > 0)
            {
                dropDownValue = this.DropDownValue;
            }
            if (!dc.method_1())
            {
                return dc.method_316(dropDownValue, this.CharacterFormat.Font, null);
            }
            return dc.method_309(dropDownValue, dc.method_376(this.CharacterFormat), null);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("欮吰唲吴䈶唸伺礼䴾⹀㑂ń⡆㹈╊ᭌ⹎㵐♒ご", 9), (int) this.short_1);
        }

        internal int DefaultDropDownValue
        {
            get
            {
                return this.short_1;
            }
            set
            {
                this.short_1 = (short) value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.DropDownFormField;
            }
        }

        public DropDownCollection DropDownItems
        {
            get
            {
                return this.dropDownCollection_0;
            }
        }

        public int DropDownSelectedIndex
        {
            get
            {
                if (base.InnerValue != 0x19)
                {
                    return base.InnerValue;
                }
                return this.short_1;
            }
            set
            {
                base.InnerValue = value;
            }
        }

        internal string DropDownValue
        {
            get
            {
                return this.dropDownCollection_0[this.DropDownSelectedIndex].Text;
            }
            set
            {
                for (int i = 0; i < this.dropDownCollection_0.Count; i++)
                {
                    if (string.Compare(this.dropDownCollection_0[i].Text, value, true) == 0)
                    {
                        this.DropDownSelectedIndex = i;
                        return;
                    }
                }
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
    }
}

