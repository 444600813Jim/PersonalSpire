namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;

    public abstract class FormField : Field
    {
        private bool bool_35;
        private bool bool_36;
        [CompilerGenerated]
        private bool bool_37;
        [CompilerGenerated]
        private bool bool_38;
        private byte byte_4;
        private byte byte_5;
        private Class42 class42_0;
        private static CultureInfo cultureInfo_0 = Thread.CurrentThread.CurrentCulture;
        private float[] float_2;
        internal const int int_10 = 0x8a;
        internal const int int_11 = 0xff;
        internal const int int_12 = 0x20;
        internal const int int_6 = 0x19;
        internal const int int_7 = 20;
        internal const int int_8 = 0xff;
        internal const int int_9 = 0x40;
        private long long_4;
        private long long_5;
        protected Spire.Doc.Documents.FormFieldType m_curFormFieldType;
        private short short_0;
        private string string_18;
        private string string_19;
        private string string_20;
        private string string_21;
        private string string_22;
        private static string string_23 = (BookmarkStart.b("ଧᔩ༫ḭḯȱгᘵ", 2) + cultureInfo_0.NumberFormat.CurrencySymbol + BookmarkStart.b("ጧȩ༫ᄭጯȱᨳص࠷ᨹ", 2) + cultureInfo_0.NumberFormat.CurrencySymbol + BookmarkStart.b("ħ", 2));

        public FormField(IDocument doc) : base(doc)
        {
            this.bool_36 = true;
            base.m_paraItemType = ParagraphItemType.FormField;
            this.string_18 = string.Empty;
            this.string_19 = string.Empty;
            this.string_20 = string.Empty;
            this.string_21 = string.Empty;
            this.string_22 = string.Empty;
        }

        protected FormField(FormField formField, IDocument doc) : this(doc)
        {
            this.Help = formField.Help;
            this.MacroOnEnd = formField.MacroOnEnd;
            this.MacroOnStart = formField.MacroOnStart;
            this.Params = formField.Params;
            this.Name = formField.Name;
            this.StatusBarHelp = formField.StatusBarHelp;
            this.InnerValue = formField.InnerValue;
            base.Type = formField.Type;
        }

        internal override void Attach(Paragraph paragraph, int itemPos)
        {
            base.Attach(paragraph, itemPos);
            if (!base.Document.bool_3)
            {
                this.method_236(paragraph.Owner as Body);
            }
        }

        protected override object CloneImpl()
        {
            FormField field = (FormField) base.CloneImpl();
            field.CharacterFormat.ImportContainer(this.CharacterFormat);
            return field;
        }

        internal override void Detach()
        {
            base.Detach();
            this.method_237(base.OwnerParagraph.Owner as Body);
        }

        internal void method_235(Class42 A_0)
        {
            if (A_0 != null)
            {
                this.class42_0 = A_0.method_23() as Class42;
            }
        }

        private void method_236(Body A_0)
        {
            if ((A_0 != null) && A_0.IsFormFieldsCreated)
            {
                A_0.FormFields.method_6(this);
                if (A_0 is TableCell)
                {
                    Table owner = A_0.Owner.Owner as Table;
                    if (owner != null)
                    {
                        this.method_236(owner.Owner as Body);
                    }
                }
            }
        }

        private void method_237(Body A_0)
        {
            if (A_0 != null)
            {
                if (A_0.IsFormFieldsCreated)
                {
                    A_0.FormFields.method_7(this);
                }
                if (A_0 is TableCell)
                {
                    this.method_237(A_0.Owner.Owner.Owner as Body);
                }
            }
        }

        private void method_238(string A_0, string A_1)
        {
            if (((base.Document == null) || !base.Document.bool_3) && (base.OwnerParagraph != null))
            {
                this.method_241(A_1);
                bool flag = false;
                if (base.Document != null)
                {
                    flag = this.method_239(A_0, A_1);
                }
                if (!flag)
                {
                    this.method_240(A_0, A_1);
                }
                if ((base.OwnerParagraph.OwnerTextBody != null) && base.OwnerParagraph.OwnerTextBody.IsFormFieldsCreated)
                {
                    base.OwnerParagraph.OwnerTextBody.FormFields.method_5(A_0, A_1);
                }
            }
        }

        private bool method_239(string A_0, string A_1)
        {
            bool flag = false;
            BookmarkCollection bookmarks = base.Document.Bookmarks;
            if (bookmarks.Count > 0)
            {
                Bookmark bookmark = bookmarks[A_0];
                if (((bookmark != null) && (bookmark.BookmarkStart != null)) && (bookmark.BookmarkEnd != null))
                {
                    bookmark.BookmarkStart.method_30(A_1);
                    bookmark.BookmarkEnd.method_30(A_1);
                    flag = true;
                }
            }
            return flag;
        }

        private void method_240(string A_0, string A_1)
        {
            BookmarkStart start = null;
            BookmarkEnd end = null;
            foreach (IParagraphBase base2 in base.OwnerParagraph.Items)
            {
                if ((base2 is BookmarkStart) && ((base2 as BookmarkStart).Name == A_0))
                {
                    start = base2 as BookmarkStart;
                }
                else if ((base2 is BookmarkEnd) && ((base2 as BookmarkEnd).Name == A_0))
                {
                    end = base2 as BookmarkEnd;
                    if (start != null)
                    {
                        break;
                    }
                }
            }
            if ((start != null) && (end != null))
            {
                start.method_30(A_1);
                end.method_30(A_1);
            }
        }

        private void method_241(string A_0)
        {
            int num = 1;
            if (base.Document.Bookmarks[A_0] != null)
            {
                throw new ArgumentException(BookmarkStart.b("䤦䠨䘪䠬༮ጰ", num) + A_0 + BookmarkStart.b("Ԧन伪堬弮崰娲嘴嘶䴸帺ጼ", num));
            }
            foreach (Section section in base.Document.Sections)
            {
                if ((section.Body.FormFields != null) && section.Body.FormFields.ContainsName(A_0))
                {
                    throw new ArgumentException(BookmarkStart.b("䤦䠨䘪䠬༮ጰ", num) + A_0 + BookmarkStart.b("Ԧन伪堬弮崰娲嘴嘶䴸帺ጼ", num));
                }
            }
        }

        internal void method_242(byte[] A_0)
        {
            MemoryStream input = new MemoryStream(A_0);
            BinaryReader reader = new BinaryReader(input, Encoding.Unicode);
            this.method_243(reader);
            this.HasFFData = true;
        }

        private void method_243(BinaryReader A_0)
        {
            bool flag;
            int num = 3;
            if (!(flag = A_0.ReadUInt32() == uint.MaxValue))
            {
                A_0.BaseStream.Seek(-4L, SeekOrigin.Current);
            }
            int num4 = A_0.ReadUInt16();
            Spire.Doc.Documents.FormFieldType type = ((Spire.Doc.Documents.FormFieldType) num4) & (Spire.Doc.Documents.FormFieldType.DropDown | Spire.Doc.Documents.FormFieldType.CheckBox);
            int num3 = (num4 & 0x7c) >> 2;
            switch (type)
            {
                case Spire.Doc.Documents.FormFieldType.CheckBox:
                    if (num3 != 0x19)
                    {
                        (this as CheckBoxFormField).Checked = num3 != 0;
                    }
                    break;

                case Spire.Doc.Documents.FormFieldType.DropDown:
                    if (num3 != 0x19)
                    {
                        (this as DropDownFormField).DropDownSelectedIndex = num3;
                    }
                    break;
            }
            this.OwnHelpText = (num4 & 0x80) != 0;
            this.OwnStatusText = (num4 & 0x100) != 0;
            this.Enabled = (num4 & 0x200) == 0;
            this.CalculateOnExit = (num4 & 0x4000) != 0;
            if (this is CheckBoxFormField)
            {
                (this as CheckBoxFormField).SizeType = ((num4 & 0x400) == 0) ? CheckBoxSizeType.Auto : CheckBoxSizeType.Exactly;
            }
            bool flag2 = (num4 & 0x8000) != 0;
            int num8 = A_0.ReadUInt16();
            int num7 = A_0.ReadUInt16();
            if (this is TextFormField)
            {
                (this as TextFormField).TextFieldType = (TextFormFieldType) ((num4 & 0x3800) >> 11);
                (this as TextFormField).MaximumLength = num8;
            }
            if (this is CheckBoxFormField)
            {
                (this as CheckBoxFormField).CheckBoxSize = num7;
            }
            if (!flag)
            {
                A_0.ReadUInt16();
            }
            this.Name = Class1029.smethod_1(A_0, flag, true);
            switch (type)
            {
                case Spire.Doc.Documents.FormFieldType.TextInput:
                {
                    string str2 = Class1029.smethod_1(A_0, flag, true);
                    if (num3 != 0x19)
                    {
                        (this as TextFormField).DefaultText = str2;
                    }
                    break;
                }
                case Spire.Doc.Documents.FormFieldType.CheckBox:
                    (this as CheckBoxFormField).DefaultCheckBoxValue = A_0.ReadUInt16() != 0;
                    break;

                case Spire.Doc.Documents.FormFieldType.DropDown:
                    (this as DropDownFormField).DefaultDropDownValue = A_0.ReadUInt16();
                    break;

                default:
                    throw new InvalidOperationException(BookmarkStart.b("簨䔪䘬䄮帰䐲嬴᜶弸吺似刾慀╂ⱄ≆╈⽊浌㭎⡐⍒ご祖", num));
            }
            string str = Class1029.smethod_1(A_0, flag, true);
            if (this is TextFormField)
            {
                (this as TextFormField).StringFormat = str;
            }
            this.Help = Class1029.smethod_1(A_0, flag, true);
            this.StatusBarHelp = Class1029.smethod_1(A_0, flag, true);
            this.MacroOnStart = Class1029.smethod_1(A_0, flag, true);
            this.MacroOnEnd = Class1029.smethod_1(A_0, flag, true);
            if ((type == Spire.Doc.Documents.FormFieldType.DropDown) && flag2)
            {
                int num5;
                A_0.ReadInt16();
                if (!flag)
                {
                    num5 = A_0.ReadInt16();
                    A_0.ReadInt16();
                    A_0.ReadInt16();
                    A_0.ReadInt16();
                    A_0.ReadBytes(num5 * 2);
                }
                else
                {
                    num5 = A_0.ReadInt32();
                }
                if (this is DropDownFormField)
                {
                    for (int i = 0; i < num5; i++)
                    {
                        (this as DropDownFormField).DropDownItems.Add(Class1029.smethod_1(A_0, flag, false));
                    }
                }
            }
        }

        internal MemoryStream method_244()
        {
            MemoryStream output = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(output, Encoding.Unicode);
            this.method_246(this, this.FormFieldType, writer);
            return output;
        }

        internal void method_245(BinaryWriter A_0)
        {
            long position = A_0.BaseStream.Position;
            Class262 class2 = new Class262();
            class2.method_1(A_0);
            this.method_246(this, this.FormFieldType, A_0);
            long offset = A_0.BaseStream.Position;
            class2.int_2 = (int) (offset - position);
            A_0.BaseStream.Seek(position, SeekOrigin.Begin);
            class2.method_1(A_0);
            A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
        }

        private void method_246(FormField A_0, Spire.Doc.Documents.FormFieldType A_1, BinaryWriter A_2)
        {
            string str;
            int num = 5;
            A_2.Write(uint.MaxValue);
            int num2 = 0;
            num2 = (int) (Spire.Doc.Documents.FormFieldType.TextInput | A_1);
            num2 |= this.method_247(A_0, A_1) << 2;
            num2 |= A_0.OwnHelpText ? 0x80 : 0;
            num2 |= A_0.OwnStatusText ? 0x100 : 0;
            num2 |= !A_0.Enabled ? 0x200 : 0;
            if (A_1 == Spire.Doc.Documents.FormFieldType.CheckBox)
            {
                num2 |= ((A_0 as CheckBoxFormField).SizeType != CheckBoxSizeType.Auto) ? 0x400 : 0;
            }
            if (A_1 == Spire.Doc.Documents.FormFieldType.TextInput)
            {
                num2 |= ((int) (A_0 as TextFormField).TextFieldType) << 11;
            }
            num2 |= A_0.CalculateOnExit ? 0x4000 : 0;
            num2 |= (A_1 == Spire.Doc.Documents.FormFieldType.DropDown) ? 0x8000 : 0;
            A_2.Write((ushort) num2);
            int num3 = (A_0 is TextFormField) ? (A_0 as TextFormField).MaximumLength : 0;
            int num4 = (A_0 is CheckBoxFormField) ? ((int) ((A_0 as CheckBoxFormField).CheckBoxSize * 2f)) : 20;
            A_2.Write((ushort) num3);
            A_2.Write((ushort) num4);
            Class1029.smethod_2(A_0.Name, 20, A_2, true, true);
            switch (A_1)
            {
                case Spire.Doc.Documents.FormFieldType.TextInput:
                {
                    TextFormField field = A_0 as TextFormField;
                    switch (field.TextFieldType)
                    {
                        case TextFormFieldType.RegularText:
                        case TextFormFieldType.NumberText:
                        case TextFormFieldType.DateText:
                        case TextFormFieldType.Calculation:
                            Class1029.smethod_2(field.DefaultText, 0xff, A_2, true, true);
                            goto Label_01CB;

                        case TextFormFieldType.CurrentDate:
                        case TextFormFieldType.CurrentTime:
                            Class1029.smethod_2("", 0xff, A_2, true, true);
                            goto Label_01CB;
                    }
                    throw new InvalidOperationException(BookmarkStart.b("縪䌬䐮弰尲䈴夶ᤸ伺堼䜾㕀捂ⱄ⥆㥈㹊㥌潎═⩒╔㉖睘", num));
                }
                case Spire.Doc.Documents.FormFieldType.CheckBox:
                    A_2.Write((A_0 as CheckBoxFormField).DefaultCheckBoxValue ? ((ushort) 1) : ((ushort) 0));
                    break;

                case Spire.Doc.Documents.FormFieldType.DropDown:
                    A_2.Write((ushort) (A_0 as DropDownFormField).DefaultDropDownValue);
                    break;

                default:
                    throw new InvalidOperationException(BookmarkStart.b("縪䌬䐮弰尲䈴夶ᤸ崺刼䴾ⱀ捂⍄⹆ⱈ❊⥌潎═⩒╔㉖睘", num));
            }
        Label_01CB:
            str = (A_0 is TextFormField) ? (A_0 as TextFormField).StringFormat : "";
            Class1029.smethod_2(str, 0x40, A_2, true, true);
            Class1029.smethod_2(A_0.Help, 0xff, A_2, true, true);
            Class1029.smethod_2(A_0.StatusBarHelp, 0x8a, A_2, true, true);
            Class1029.smethod_2(A_0.MacroOnStart, 0x20, A_2, true, true);
            Class1029.smethod_2(A_0.MacroOnEnd, 0x20, A_2, true, true);
            if (A_1 == Spire.Doc.Documents.FormFieldType.DropDown)
            {
                A_2.Write((ushort) 0xffff);
                A_2.Write((uint) (A_0 as DropDownFormField).DropDownItems.Count);
                for (int i = 0; i < (A_0 as DropDownFormField).DropDownItems.Count; i++)
                {
                    Class1029.smethod_2((A_0 as DropDownFormField).DropDownItems[i].Text, 0x7fffffff, A_2, true, false);
                }
            }
        }

        internal int method_247(FormField A_0, Spire.Doc.Documents.FormFieldType A_1)
        {
            int num = 8;
            switch (A_1)
            {
                case Spire.Doc.Documents.FormFieldType.TextInput:
                    return 0;

                case Spire.Doc.Documents.FormFieldType.CheckBox:
                    if ((A_0 as CheckBoxFormField).Checked)
                    {
                        return 1;
                    }
                    return 0;

                case Spire.Doc.Documents.FormFieldType.DropDown:
                    return (A_0 as DropDownFormField).DropDownSelectedIndex;
            }
            throw new InvalidOperationException(BookmarkStart.b("笭帯失娳夵伷吹᰻堽⼿ぁ⥃晅⹇⍉⥋≍㑏牑⁓⽕⡗㽙牛", num));
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 8;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("縭儯䀱唳嬵䬷", 8)))
            {
                this.Params = reader.ReadInt(BookmarkStart.b("縭儯䀱唳嬵䬷", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稭夯䘱堳匵", num)))
            {
                this.string_18 = reader.ReadString(BookmarkStart.b("稭夯䘱堳匵", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("昭唯帱䐳", num)))
            {
                this.string_19 = reader.ReadString(BookmarkStart.b("昭唯帱䐳", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稭弯崱堳䈵儷䨹", num)))
            {
                this.string_20 = reader.ReadString(BookmarkStart.b("稭弯崱堳䈵儷䨹", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("挭儯儱䘳夵眷吹漻䨽ℿぁぃ", num)))
            {
                this.string_21 = reader.ReadString(BookmarkStart.b("挭儯儱䘳夵眷吹漻䨽ℿぁぃ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("挭儯儱䘳夵眷吹礻倽␿", num)))
            {
                this.string_22 = reader.ReadString(BookmarkStart.b("挭儯儱䘳夵眷吹礻倽␿", num));
            }
        }

        private static TextFormat smethod_1(string A_0)
        {
            int num = 14;
            string str = A_0;
            if (str != null)
            {
                if (str == BookmarkStart.b("愳昵样缹渻紽ĿᅁŃ", num))
                {
                    return TextFormat.Uppercase;
                }
                if (str == BookmarkStart.b("砳礵漷缹渻紽ĿᅁŃ", num))
                {
                    return TextFormat.Lowercase;
                }
                if (str == BookmarkStart.b("爳缵樷椹栻ḽ̿́ᑃཅ᱇୉K", num))
                {
                    return TextFormat.FirstCapital;
                }
                if (str == BookmarkStart.b("怳缵氷瘹礻ḽ̿́ᝃͅ", num))
                {
                    return TextFormat.Titlecase;
                }
            }
            return TextFormat.None;
        }

        private static string smethod_2(TextFormField A_0)
        {
            int num = 15;
            switch (A_0.TextFormat)
            {
                case TextFormat.Uppercase:
                    return BookmarkStart.b("怴朶椸縺漼簾@၂D", num);

                case TextFormat.Lowercase:
                    return BookmarkStart.b("礴砶游縺漼簾@၂D", num);

                case TextFormat.FirstCapital:
                    return BookmarkStart.b("猴縶欸栺椼Ἶɀɂᕄๆᵈ੊Ō", num);

                case TextFormat.Titlecase:
                    return BookmarkStart.b("愴縶洸眺砼ἾɀɂᙄɆ", num);
            }
            return string.Empty;
        }

        private static NumberFormat smethod_3(string A_0)
        {
            int num = 0x10;
            string str = A_0;
            if (str != null)
            {
                if (str == BookmarkStart.b("ص", num))
                {
                    return NumberFormat.WholeNumber;
                }
                if (str == BookmarkStart.b("صᐷਹ఻", num))
                {
                    return NumberFormat.FloatingPoint;
                }
                if (str == BookmarkStart.b("صᴷ", num))
                {
                    return NumberFormat.WholeNumberPercent;
                }
                if (str == BookmarkStart.b("صᐷਹ఻ᬽ", num))
                {
                    return NumberFormat.FloatingPointPercent;
                }
                if (str == BookmarkStart.b("ᔵܷ᤹఻", num))
                {
                    return NumberFormat.WholeNumberWithSpace;
                }
                if (str == BookmarkStart.b("ᔵܷ᤹఻ሽ瀿牁", num))
                {
                    return NumberFormat.FloatingPointWithSpace;
                }
            }
            if (A_0.StartsWith(BookmarkStart.b("ᔵܷ᤹఻ሽ瀿牁摃", num)))
            {
                return NumberFormat.CurrencyFormat;
            }
            return NumberFormat.None;
        }

        private static string smethod_4(NumberFormat A_0)
        {
            int num = 14;
            switch (A_0)
            {
                case NumberFormat.WholeNumber:
                    return BookmarkStart.b("г", num);

                case NumberFormat.FloatingPoint:
                    return BookmarkStart.b("гᨵ࠷ਹ", num);

                case NumberFormat.WholeNumberPercent:
                    return BookmarkStart.b("гጵ", num);

                case NumberFormat.FloatingPointPercent:
                    return BookmarkStart.b("гᨵ࠷ਹ᤻", num);

                case NumberFormat.WholeNumberWithSpace:
                    return BookmarkStart.b("ᜳवᬷਹ", num);

                case NumberFormat.FloatingPointWithSpace:
                    return BookmarkStart.b("ᜳवᬷਹျ฽瀿", num);

                case NumberFormat.CurrencyFormat:
                    return string_23;
            }
            return string.Empty;
        }

        private static string smethod_5(NumberFormat A_0)
        {
            int num = 13;
            switch (A_0)
            {
                case NumberFormat.WholeNumber:
                case NumberFormat.WholeNumberWithSpace:
                    return BookmarkStart.b("̲", num);

                case NumberFormat.FloatingPoint:
                case NumberFormat.FloatingPointWithSpace:
                    return BookmarkStart.b("̲ᤴܶस", num);

                case NumberFormat.WholeNumberPercent:
                    return BookmarkStart.b("̲ဴ", num);

                case NumberFormat.FloatingPointPercent:
                    return BookmarkStart.b("̲ᤴܶसḺ", num);

                case NumberFormat.CurrencyFormat:
                    return (BookmarkStart.b("̲ᤴܶसᬺ", num) + cultureInfo_0.NumberFormat.CurrencySymbol);
            }
            return string.Empty;
        }

        internal static string smethod_6(TextFormat A_0, string A_1)
        {
            int num = 0;
            if (A_1 != string.Empty)
            {
                if (A_0 == TextFormat.Uppercase)
                {
                    return A_1.ToUpper();
                }
                if (A_0 == TextFormat.Lowercase)
                {
                    return A_1.ToLower();
                }
                if (A_0 == TextFormat.FirstCapital)
                {
                    char ch2 = A_1[0];
                    return (ch2.ToString().ToUpper() + A_1.Remove(0, 1));
                }
                if (A_0 != TextFormat.Titlecase)
                {
                    return A_1;
                }
                string[] strArray = A_1.Split(new char[] { ' ' });
                for (int i = 0; i < strArray.Length; i++)
                {
                    string str = strArray[i];
                    char ch = str[0];
                    string text1 = ch.ToString().ToUpper() + str.Remove(0, 1);
                    strArray[i] = str;
                }
                A_1 = string.Empty;
                int length = strArray.Length;
                for (int j = 0; j < length; j++)
                {
                    A_1 = A_1 + strArray[j];
                    if (j < (length - 1))
                    {
                        A_1 = A_1 + BookmarkStart.b("إ", num);
                    }
                }
            }
            return A_1;
        }

        private static string smethod_7(string A_0, NumberFormat A_1, string A_2)
        {
            string str2;
            if (A_1 == NumberFormat.None)
            {
                return A_2;
            }
            A_2 = A_2.Replace('.', ',');
            double d = 0.0;
            string str = string.Empty;
            try
            {
                d = Convert.ToDouble(A_2);
                switch (A_1)
                {
                    case NumberFormat.WholeNumber:
                    case NumberFormat.WholeNumberPercent:
                        if (A_1 != NumberFormat.WholeNumberPercent)
                        {
                            d = Math.Floor(d);
                        }
                        else
                        {
                            d *= 100.0;
                            d = Math.Floor(d) / 100.0;
                        }
                        return smethod_8(A_0, d);

                    case NumberFormat.FloatingPoint:
                    case NumberFormat.FloatingPointPercent:
                        return smethod_8(A_0, d);

                    case NumberFormat.WholeNumberWithSpace:
                    case NumberFormat.FloatingPointWithSpace:
                    case NumberFormat.CurrencyFormat:
                        if (A_1 == NumberFormat.WholeNumberWithSpace)
                        {
                            d = Math.Floor(d);
                        }
                        str = smethod_8(A_0, d);
                        if (d < 1000.0)
                        {
                            str = str.Substring(1, str.Length - 1);
                        }
                        return str;
                }
                if (A_0 != string.Empty)
                {
                    return smethod_8(A_0, d);
                }
                return string.Empty;
            }
            catch
            {
                str2 = smethod_5(A_1);
            }
            return str2;
        }

        private static string smethod_8(string A_0, double A_1)
        {
            double num = 0.0;
            if (A_0[A_0.Length - 1] == '%')
            {
                A_1 *= 100.0;
                num = Math.Round(A_1, 2);
                if (num > A_1)
                {
                    num -= 0.01;
                }
                num /= 100.0;
            }
            else
            {
                num = Math.Round(A_1, 2);
                if (num > A_1)
                {
                    num -= 0.01;
                }
            }
            return num.ToString(A_0);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("瘥䤧堩䴫䌭䌯", 0), (int) this.short_0);
            writer.WriteValue(BookmarkStart.b("爥䄧帩䀫䬭", 0), this.string_18);
            writer.WriteValue(BookmarkStart.b("渥䴧䘩尫", 0), this.string_19);
            writer.WriteValue(BookmarkStart.b("爥䜧䔩䀫娭夯䈱", 0), this.string_20);
            writer.WriteValue(BookmarkStart.b("欥䤧䤩師䄭缯就朳䈵夷䠹䠻", 0), this.string_21);
            writer.WriteValue(BookmarkStart.b("欥䤧䤩師䄭缯就焳堵尷", 0), this.string_22);
        }

        public bool CalculateOnExit
        {
            get
            {
                return ((this.short_0 & 0x4000) == 0x4000);
            }
            set
            {
                this.short_0 = value ? ((short) Class1012.smethod_8(this.short_0, 0x4000, 14, 1)) : ((short) Class1012.smethod_8(this.short_0, 0x4000, 14, 0));
            }
        }

        public bool Enabled
        {
            get
            {
                return ((this.short_0 & 0x200) == 0);
            }
            set
            {
                int num = value ? 0 : 1;
                this.short_0 = (short) Class1012.smethod_8(this.short_0, 0x200, 9, num);
            }
        }

        internal Class42 FormFieldPr
        {
            get
            {
                return this.class42_0;
            }
        }

        public Spire.Doc.Documents.FormFieldType FormFieldType
        {
            get
            {
                return this.m_curFormFieldType;
            }
        }

        internal bool HasFFData
        {
            get
            {
                return this.bool_36;
            }
            set
            {
                this.bool_36 = value;
            }
        }

        public string Help
        {
            get
            {
                return this.string_19;
            }
            set
            {
                this.string_19 = value;
                this.short_0 = (short) Class1012.smethod_8(this.short_0, 0x80, 7, 1);
            }
        }

        internal int InnerValue
        {
            get
            {
                return ((this.short_0 & 0x7c) >> 2);
            }
            set
            {
                this.short_0 = (short) ((this.short_0 & -125) | (value << 2));
            }
        }

        public string MacroOnEnd
        {
            get
            {
                return this.string_22;
            }
            set
            {
                this.string_22 = value;
            }
        }

        public string MacroOnStart
        {
            get
            {
                return this.string_21;
            }
            set
            {
                this.string_21 = value;
            }
        }

        public string Name
        {
            get
            {
                return this.string_18;
            }
            set
            {
                this.method_238(this.string_18, value);
                this.string_18 = value;
            }
        }

        internal bool OwnHelpText
        {
            [CompilerGenerated]
            get
            {
                return this.bool_37;
            }
            [CompilerGenerated]
            set
            {
                this.bool_37 = value;
            }
        }

        internal bool OwnStatusText
        {
            [CompilerGenerated]
            get
            {
                return this.bool_38;
            }
            [CompilerGenerated]
            set
            {
                this.bool_38 = value;
            }
        }

        internal int Params
        {
            get
            {
                return this.short_0;
            }
            set
            {
                this.short_0 = (short) value;
            }
        }

        public string StatusBarHelp
        {
            get
            {
                return this.string_20;
            }
            set
            {
                this.string_20 = value;
                this.short_0 = (short) Class1012.smethod_8(this.short_0, 0x100, 8, 1);
            }
        }
    }
}

