namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Documents.Markup;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using System;
    using System.Collections;
    using System.Drawing;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Xml;

    public class SDTProperties
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private byte[] byte_0;
        private byte[] byte_1;
        private Spire.Doc.Formatting.CharacterFormat characterFormat_0;
        private Class443 class443_0;
        private decimal decimal_0;
        private DocumentObject documentObject_0;
        private float float_0;
        private LockSettingsType lockSettingsType_0;
        private SdtControlProperties sdtControlProperties_0;
        private SdtType sdtType_0;
        private string string_0 = string.Empty;
        private string[] string_1;
        private string string_2;
        private string string_3;
        private uint uint_0;

        public SDTProperties(DocumentObject owner)
        {
            this.documentObject_0 = owner;
            this.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(this.documentObject_0.Document);
        }

        internal void method_0(CustomXmlPartCollection A_0)
        {
            int num = 0x12;
            if ((A_0.Count > 0) && (this.DataBinding != null))
            {
                if (!this.RepeatingSection)
                {
                    XmlNode node = this.DataBinding.method_2(A_0);
                    if (node != null)
                    {
                        string str2 = this.method_6(node.InnerText);
                        this.method_4(this.Owner, str2);
                    }
                }
                else
                {
                    Regex regex = new Regex(BookmarkStart.b("搷愹ᐻ戽␿桁浃ᩅᕇ湉", num));
                    string input = this.DataBinding.method_13();
                    if (!regex.IsMatch(input))
                    {
                        DocumentObject owner = this.Owner.Owner;
                        XmlNodeList list = this.DataBinding.method_5(A_0, input);
                        if ((list != null) && (list.Count > 0))
                        {
                            if (list.Count > 1)
                            {
                                int num2 = 1;
                                int count = list.Count;
                                while (num2 < count)
                                {
                                    this.method_1(owner, list[num2], input, false);
                                    num2++;
                                }
                            }
                            this.method_1(owner, list[0], input, true);
                        }
                    }
                    regex = null;
                }
            }
        }

        private void method_1(DocumentObject A_0, XmlNode A_1, string A_2, bool A_3)
        {
            if ((A_0 != null) && (A_1 != null))
            {
                string str = this.method_3(A_1);
                if (!A_3)
                {
                    IStructureDocument entity = (this.Owner as IStructureDocument).Clone() as IStructureDocument;
                    entity.SDTProperties.DataBinding.method_1(str);
                    A_0.ChildObjects.Add(entity);
                    this.method_2(entity as DocumentObject, A_2, str);
                }
                else
                {
                    this.DataBinding.method_1(str);
                    this.method_2(this.Owner, A_2, str);
                }
            }
        }

        private void method_2(DocumentObject A_0, string A_1, string A_2)
        {
            int num = 0x11;
            if (A_0 != null)
            {
                for (int i = 0; i < A_0.ChildObjects.Count; i++)
                {
                    DocumentObject obj2 = A_0.ChildObjects[i];
                    if ((obj2 is IStructureDocument) && ((obj2 as IStructureDocument).SDTProperties.DataBinding != null))
                    {
                        string str2 = (obj2 as IStructureDocument).SDTProperties.DataBinding.method_13();
                        if (!string.IsNullOrEmpty(str2))
                        {
                            string str = string.Empty;
                            string str3 = str2.Substring(A_1.Length);
                            if (str3.StartsWith(BookmarkStart.b("氶", num)))
                            {
                                int index = str3.IndexOf(BookmarkStart.b("ᠶ", num));
                                string str4 = str3.Substring(index);
                                str = A_2 + str4;
                            }
                            else
                            {
                                str = str2.Replace(A_1, A_2);
                            }
                            (obj2 as IStructureDocument).SDTProperties.DataBinding.method_1(str);
                        }
                    }
                    if (obj2 is StructureDocumentTagInline)
                    {
                        (obj2 as StructureDocumentTagInline).IsUpdateDataBinding = false;
                    }
                    if (obj2.ChildObjects.Count > 0)
                    {
                        this.method_2(obj2, A_1, A_2);
                    }
                }
            }
        }

        private string method_3(XmlNode A_0)
        {
            int num = 6;
            if (A_0.NodeType == XmlNodeType.Attribute)
            {
                return string.Format(BookmarkStart.b("圫ḭ䴯ᴱ琳䴵ष䜹", num), this.method_3(((XmlAttribute) A_0).OwnerElement), A_0.Name);
            }
            if (A_0.ParentNode == null)
            {
                return "";
            }
            int num2 = 1;
            for (XmlNode node = A_0; node.PreviousSibling != null; node = node.PreviousSibling)
            {
                if (!(node.PreviousSibling.Name == node.Name))
                {
                    break;
                }
                num2++;
            }
            if (!string.IsNullOrEmpty(A_0.NamespaceURI))
            {
                return string.Format(BookmarkStart.b("圫ḭ䴯ᴱ伳ܵ䔷9䜻ఽ㴿᥁㽃畅㕇ᝉ", num), new object[] { this.method_3(A_0.ParentNode), this.DataBinding.method_10(A_0.NamespaceURI), A_0.Name, num2 });
            }
            return string.Format(BookmarkStart.b("圫ḭ䴯ᴱ伳ܵ䔷愹䜻ఽ㴿ὁ", num), this.method_3(A_0.ParentNode), A_0.Name, num2);
        }

        private void method_4(DocumentObject A_0, string A_1)
        {
            int num = 12;
            if (A_0 != null)
            {
                ParagraphBase base2 = null;
                switch (this.SDTType)
                {
                    case SdtType.Picture:
                    {
                        base2 = new DocPicture(A_0.Document);
                        byte[] imageBytes = Convert.FromBase64String(A_1.Replace(BookmarkStart.b("㠱", num), string.Empty).Replace(BookmarkStart.b("㤱", num), string.Empty).Replace(BookmarkStart.b("㼱", num), string.Empty));
                        (base2 as DocPicture).LoadImage(imageBytes);
                        break;
                    }
                    case SdtType.Text:
                    case SdtType.None:
                        base2 = new TextRange(A_0.Document);
                        (base2 as TextRange).Text = A_1;
                        break;

                    case SdtType.DatePicker:
                    {
                        DateTime time;
                        base2 = new TextRange(A_0.Document);
                        if (string.IsNullOrEmpty(A_1))
                        {
                            (base2 as TextRange).Text = A_1;
                            break;
                        }
                        string dateFormat = (this.ControlProperties as SdtDate).DateFormat;
                        CultureInfo provider = (this.ControlProperties as SdtDate).method_1();
                        if (!DateTime.TryParse(A_1, out time))
                        {
                            (base2 as TextRange).Text = A_1;
                            break;
                        }
                        A_1 = !string.IsNullOrEmpty(dateFormat) ? time.ToString(dateFormat, provider) : time.ToString();
                        (base2 as TextRange).Text = A_1;
                        break;
                    }
                }
                if (base2 != null)
                {
                    if (A_0 is StructureDocumentTag)
                    {
                        StructureDocumentTag tag = A_0 as StructureDocumentTag;
                        if (tag.ChildObjects.Count > 0)
                        {
                            Paragraph paragraph2 = tag.ChildObjects[0] as Paragraph;
                            this.method_5(paragraph2, base2);
                        }
                    }
                    else if (A_0 is StructureDocumentTagInline)
                    {
                        StructureDocumentTagInline inline = A_0 as StructureDocumentTagInline;
                        if (inline.ChildObjects.Count > 0)
                        {
                            base2.CharacterFormat.method_27((inline.ChildObjects[0] as ParagraphBase).CharacterFormat);
                            if (!this.IsDataBindingOfCoreProperties && base2.CharacterFormat.HasValue(9))
                            {
                                base2.CharacterFormat.Remove(9);
                            }
                        }
                        inline.ChildObjects.Clear();
                        inline.ChildObjects.Add(base2);
                    }
                    else if (!(A_0 is StructureDocumentTagRow) && (A_0 is StructureDocumentTagCell))
                    {
                        StructureDocumentTagCell cell = A_0 as StructureDocumentTagCell;
                        if (cell.ChildObjects.Count > 0)
                        {
                            Paragraph paragraph = cell.ChildObjects[0] as Paragraph;
                            this.method_5(paragraph, base2);
                        }
                    }
                }
            }
        }

        private void method_5(Paragraph A_0, ParagraphBase A_1)
        {
            if ((A_0 == null) || (A_1 == null))
            {
                return;
            }
            DocumentObject obj2 = A_0.ChildObjects.method_20(DocumentObjectType.TextRange);
            if (A_1 is DocPicture)
            {
                using (IEnumerator enumerator = A_0.ChildObjects.GetEnumerator())
                {
                    ParagraphBase current;
                    while (enumerator.MoveNext())
                    {
                        current = (ParagraphBase) enumerator.Current;
                        if (current is DocPicture)
                        {
                            goto Label_004F;
                        }
                    }
                    goto Label_00DB;
                Label_004F:
                    (current as DocPicture).method_88((A_1 as DocPicture).ImageBytes, true);
                    goto Label_00DB;
                }
            }
            if ((obj2 is TextRange) && (A_1 is TextRange))
            {
                TextRange entity = obj2.Clone() as TextRange;
                entity.Text = (A_1 as TextRange).Text;
                A_0.ChildObjects.Clear();
                A_0.ChildObjects.Add(entity);
            }
            else
            {
                A_0.ChildObjects.Clear();
                A_0.ChildObjects.Add(A_1);
            }
        Label_00DB:
            obj2 = null;
        }

        private string method_6(string A_0)
        {
            string str = A_0.Replace(Class816.string_4, Class816.string_6);
            str = A_0.Replace(Class816.string_2, Class816.string_6);
            return A_0.Replace(Class816.string_3, Class816.string_6);
        }

        internal void method_7(DocumentObject A_0)
        {
            this.documentObject_0 = A_0;
        }

        internal void method_8()
        {
            TextRange range;
            SdtDropDownListBase controlProperties;
            switch (this.SDTType)
            {
                case SdtType.ComboBox:
                case SdtType.DropDownList:
                {
                    controlProperties = this.ControlProperties as SdtDropDownListBase;
                    range = null;
                    if (!(this.documentObject_0 is StructureDocumentTagCell))
                    {
                        if (this.documentObject_0 is StructureDocumentTagInline)
                        {
                            StructureDocumentTagInline inline3 = this.documentObject_0 as StructureDocumentTagInline;
                            if (inline3.ChildObjects.Count > 0)
                            {
                                range = inline3.ChildObjects[0] as TextRange;
                            }
                        }
                        else if (this.documentObject_0 is StructureDocumentTag)
                        {
                            StructureDocumentTag tag = this.documentObject_0 as StructureDocumentTag;
                            if (((tag.ChildObjects.Count > 0) && (tag.ChildObjects[0] is Paragraph)) && ((tag.ChildObjects[0] as Paragraph).ChildObjects.Count > 0))
                            {
                                range = (tag.ChildObjects[0] as Paragraph).ChildObjects[0] as TextRange;
                            }
                        }
                        break;
                    }
                    StructureDocumentTagCell cell = this.documentObject_0 as StructureDocumentTagCell;
                    if (((cell.ChildObjects.Count > 0) && (cell.ChildObjects[0] is Paragraph)) && ((cell.ChildObjects[0] as Paragraph).ChildObjects.Count > 0))
                    {
                        range = (cell.ChildObjects[0] as Paragraph).ChildObjects[0] as TextRange;
                    }
                    break;
                }
                case SdtType.Picture:
                {
                    SdtPicture picture = this.ControlProperties as SdtPicture;
                    Image image = picture.Image;
                    if (image != null)
                    {
                        DocPicture picture2 = null;
                        if (this.documentObject_0 is StructureDocumentTagCell)
                        {
                            StructureDocumentTagCell cell2 = this.documentObject_0 as StructureDocumentTagCell;
                            if (((cell2.ChildObjects.Count > 0) && (cell2.ChildObjects[0] is Paragraph)) && ((cell2.ChildObjects[0] as Paragraph).ChildObjects.Count > 0))
                            {
                                picture2 = (cell2.ChildObjects[0] as Paragraph).ChildObjects[0] as DocPicture;
                            }
                        }
                        else if (this.documentObject_0 is StructureDocumentTagInline)
                        {
                            StructureDocumentTagInline inline = this.documentObject_0 as StructureDocumentTagInline;
                            if (inline.ChildObjects.Count > 0)
                            {
                                picture2 = inline.ChildObjects[0] as DocPicture;
                            }
                        }
                        else if (this.documentObject_0 is StructureDocumentTag)
                        {
                            StructureDocumentTag tag3 = this.documentObject_0 as StructureDocumentTag;
                            if (((tag3.ChildObjects.Count > 0) && (tag3.ChildObjects[0] is Paragraph)) && ((tag3.ChildObjects[0] as Paragraph).ChildObjects.Count > 0))
                            {
                                picture2 = (tag3.ChildObjects[0] as Paragraph).ChildObjects[0] as DocPicture;
                            }
                        }
                        if (picture2 != null)
                        {
                            picture2.method_89(image);
                            this.IsShowingPlaceHolder = false;
                            picture.Image = null;
                        }
                    }
                    return;
                }
                case SdtType.CheckBox:
                {
                    SdtCheckBox box = this.ControlProperties as SdtCheckBox;
                    TextRange range2 = null;
                    if (this.documentObject_0 is StructureDocumentTagCell)
                    {
                        StructureDocumentTagCell cell3 = this.documentObject_0 as StructureDocumentTagCell;
                        if (((cell3.ChildObjects.Count > 0) && (cell3.ChildObjects[0] is Paragraph)) && ((cell3.ChildObjects[0] as Paragraph).ChildObjects.Count > 0))
                        {
                            range2 = (cell3.ChildObjects[0] as Paragraph).ChildObjects[0] as TextRange;
                        }
                    }
                    else if (this.documentObject_0 is StructureDocumentTagInline)
                    {
                        StructureDocumentTagInline inline2 = this.documentObject_0 as StructureDocumentTagInline;
                        if (inline2.ChildObjects.Count > 0)
                        {
                            range2 = inline2.ChildObjects[0] as TextRange;
                        }
                    }
                    else if (this.documentObject_0 is StructureDocumentTag)
                    {
                        StructureDocumentTag tag2 = this.documentObject_0 as StructureDocumentTag;
                        if (((tag2.ChildObjects.Count > 0) && (tag2.ChildObjects[0] is Paragraph)) && ((tag2.ChildObjects[0] as Paragraph).ChildObjects.Count > 0))
                        {
                            range2 = (tag2.ChildObjects[0] as Paragraph).ChildObjects[0] as TextRange;
                        }
                    }
                    if (range2 != null)
                    {
                        if (box.Checked)
                        {
                            range2.Text = ((char) box.CheckedState.method_3()).ToString();
                            return;
                        }
                        range2.Text = ((char) box.UncheckedState.method_3()).ToString();
                    }
                    return;
                }
                default:
                    return;
            }
            if ((range != null) && (controlProperties.ListItems.SelectedValue != null))
            {
                if (!this.IsShowingPlaceHolder)
                {
                    range.CharacterFormat.method_55(Color.Empty);
                    range.CharacterFormat.TextBackgroundColor = Color.Empty;
                }
                range.Text = controlProperties.ListItems.SelectedValue.DisplayText;
            }
        }

        internal SDTProperties method_9()
        {
            SDTProperties properties = (SDTProperties) base.MemberwiseClone();
            if (this.sdtControlProperties_0 != null)
            {
                properties.ControlProperties = this.sdtControlProperties_0.Clone();
            }
            if (this.characterFormat_0 != null)
            {
                properties.CharacterFormat = (Spire.Doc.Formatting.CharacterFormat) this.characterFormat_0.method_23();
            }
            if (this.DataBinding != null)
            {
                properties.class443_0 = this.class443_0.method_0();
            }
            if (this.ControlProperties != null)
            {
                properties.sdtControlProperties_0 = this.sdtControlProperties_0.Clone();
            }
            properties.documentObject_0 = null;
            return properties;
        }

        public string Alias
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }

        internal bool Bibliograph
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        internal Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
            set
            {
                this.characterFormat_0 = value;
            }
        }

        public SdtControlProperties ControlProperties
        {
            get
            {
                return this.sdtControlProperties_0;
            }
            set
            {
                this.sdtControlProperties_0 = value;
                if (value != null)
                {
                    this.sdtControlProperties_0.Owner = this;
                }
            }
        }

        internal Class443 DataBinding
        {
            get
            {
                return this.class443_0;
            }
            set
            {
                this.class443_0 = value;
            }
        }

        public decimal Id
        {
            get
            {
                return this.decimal_0;
            }
            set
            {
                this.decimal_0 = value;
            }
        }

        private bool IsDataBindingOfCoreProperties
        {
            get
            {
                int num = 10;
                return (((this.DataBinding != null) && !string.IsNullOrEmpty(this.DataBinding.method_12())) && this.DataBinding.method_12().Contains(BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⅍⁏㝑㩓⹕㕗㙙㩛ㅝ቟ཡգብ᭧䑩ͫᱭᝯ嵱ѳ᝵᭷ᅹᵻ᥽궁뚃뚅뢇벉ꎋ聯ﶛ놝쎟춡횣쎥薧\udaa9\udeab솭삯ힱ욳습톷\udfb9\ucfbb", num)));
            }
        }

        internal bool IsPlainTextControl
        {
            get
            {
                return (this.SDTType == SdtType.Text);
            }
        }

        public bool IsShowingPlaceHolder
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

        internal bool IsTemporary
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

        internal string Label
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        internal LockSettingsType LockSettings
        {
            get
            {
                return this.lockSettingsType_0;
            }
            set
            {
                this.lockSettingsType_0 = value;
            }
        }

        internal DocumentObject Owner
        {
            get
            {
                return this.documentObject_0;
            }
        }

        internal bool RepeatingSection
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        internal bool RepeatingSectionItem
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        public SdtType SDTType
        {
            get
            {
                if (this.sdtControlProperties_0 != null)
                {
                    return this.sdtControlProperties_0.Type;
                }
                return this.sdtType_0;
            }
            set
            {
                this.sdtType_0 = value;
                if (value == SdtType.None)
                {
                    this.sdtControlProperties_0 = null;
                }
            }
        }

        internal uint TabIndex
        {
            get
            {
                return this.uint_0;
            }
            set
            {
                this.uint_0 = value;
            }
        }

        public string Tag
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }
    }
}

