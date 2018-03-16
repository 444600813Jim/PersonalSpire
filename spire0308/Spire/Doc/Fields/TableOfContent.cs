namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class TableOfContent : ParagraphBase
    {
        private bool bool_10;
        private bool bool_11;
        private bool bool_12;
        private bool bool_13;
        private bool bool_14;
        private bool bool_15;
        private bool bool_7;
        private bool bool_8;
        private bool bool_9;
        private byte[] byte_4;
        private const char char_0 = 'o';
        private const char char_1 = 'h';
        private const char char_2 = 'n';
        private const char char_3 = 'p';
        private const char char_4 = 'u';
        private const char char_5 = 'f';
        private const char char_6 = 't';
        private Dictionary<int, ParagraphStyle> dictionary_0;
        private Field field_0;
        private int int_10;
        private int int_11;
        private const int int_4 = 3;
        private const int int_5 = 1;
        private int int_6;
        private int int_7;
        private int int_8;
        private int int_9;
        private List<int> list_0;
        private List<int> list_1;
        private List<IParagraph> list_2;
        private long[] long_4;
        private Paragraph paragraph_0;
        private string string_10;
        private string string_11;
        private string string_8;
        private string string_9;

        public TableOfContent(IDocument doc) : base(doc as Document)
        {
            this.bool_7 = true;
            this.int_6 = 3;
            this.int_7 = 1;
            this.bool_9 = true;
            this.bool_10 = true;
            this.bool_12 = true;
            this.string_10 = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
            this.string_11 = BookmarkStart.b("椵氷唹弻愽㬿牁㥃᥅㍇等ㅋᅍ", 0x10);
            this.field_0 = new Field(doc);
            this.field_0.Type = FieldType.FieldTOC;
            this.string_9 = string.Empty;
        }

        public TableOfContent(IDocument doc, string switches) : this(doc)
        {
            this.TOCField.m_formattingString = switches;
            this.method_30();
        }

        internal override bool Accept(Class420 visitor)
        {
            this.method_33();
            return (!this.method_79(visitor) || base.method_12(visitor.vmethod_18(this.TOCField)));
        }

        protected override object CloneImpl()
        {
            if (this.bool_13)
            {
                this.method_33();
            }
            TableOfContent content = (TableOfContent) base.CloneImpl();
            content.field_0 = (Field) this.field_0.Clone();
            return content;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205();
            base.interface23_0.imethod_5(true);
        }

        public string GetTOCLevelStyle(int levelNumber)
        {
            int num = 13;
            if ((levelNumber < this.int_7) || (levelNumber > this.int_6))
            {
                throw new ArgumentException(BookmarkStart.b("缲倴䄶尸场ᴼ嘾⽀❂⁄㽆楈♊㡌㱎═獒㝔㉖祘敚恜罞ⵠౢቤɦ᭨⍪࡬๮ᕰᩲ᭴ၶ㕸Ṻ୼᩾ꎂꮊ놌늎놐욒ﲘ햜爵삠잢첤즦캨좬\ud9ae\ud4b0\udfb2", num));
            }
            this.method_30();
            ParagraphStyle style = null;
            if (!this.dictionary_0.ContainsKey(levelNumber))
            {
                BuiltinStyle style2 = (BuiltinStyle) levelNumber;
                style = this.method_31(style2) as ParagraphStyle;
            }
            else
            {
                style = this.dictionary_0[levelNumber];
            }
            return style.Name;
        }

        protected override void InitXDLSHolder()
        {
            int num = 0x11;
            if (this.bool_13)
            {
                this.method_33();
            }
            base.XDLSHolder.AddElement(BookmarkStart.b("䌶嘸堺ြ夾⡀♂⥄⍆", num), this.field_0);
        }

        private void method_30()
        {
            int num = 14;
            if (!this.bool_14)
            {
                string formattingString = this.TOCField.m_formattingString;
                if (formattingString.Contains(BookmarkStart.b("栳ᰵᠷ眹礻氽ܿ݁Ƀॅᩇ݉ോᩍ", num)))
                {
                    formattingString = formattingString.Remove(formattingString.IndexOf(BookmarkStart.b("栳ᰵᠷ眹礻氽ܿ݁Ƀॅᩇ݉ോᩍ", num))).Trim();
                }
                else if (formattingString.Contains(BookmarkStart.b("栳ᰵᠷ眹夻䰽✿❁≃⥅㩇❉ⵋ㩍", num)))
                {
                    formattingString = formattingString.Remove(formattingString.IndexOf(BookmarkStart.b("栳ᰵᠷ眹夻䰽✿❁≃⥅㩇❉ⵋ㩍", num))).Trim();
                }
                string[] strArray = formattingString.Split(new char[] { '\\' });
                bool flag = false;
                int index = 0;
                int length = strArray.Length;
                while (index < length)
                {
                    string str = strArray[index];
                    if (str.Length != 0)
                    {
                        switch (str[0])
                        {
                            case 'f':
                                this.method_44(str);
                                break;

                            case 'h':
                                this.bool_10 = true;
                                break;

                            case 'n':
                                this.bool_12 = false;
                                this.method_42(str, false);
                                break;

                            case 'o':
                                this.bool_7 = true;
                                flag = true;
                                this.method_41(str);
                                break;

                            case 'p':
                                this.bool_9 = false;
                                break;

                            case 't':
                                this.method_45(str);
                                break;

                            case 'u':
                                this.bool_11 = true;
                                break;
                        }
                    }
                    index++;
                }
                if ((this.TOCStyles.Count == 0) && !flag)
                {
                    this.int_6 = 9;
                }
                this.bool_14 = true;
            }
        }

        private IParagraphStyle method_31(BuiltinStyle A_0)
        {
            string name = Style.smethod_4(A_0);
            IParagraphStyle style = base.m_doc.Styles.FindByName(name, StyleType.ParagraphStyle) as IParagraphStyle;
            if (style == null)
            {
                style = (IParagraphStyle) Style.CreateBuiltinStyle(A_0, base.m_doc);
                base.m_doc.Styles.Add(style);
            }
            return style;
        }

        private void method_32()
        {
            for (int i = 1; i <= 9; i++)
            {
                BuiltinStyle style = (BuiltinStyle) i;
                this.TOCStyles.Add(i, this.method_31(style) as ParagraphStyle);
            }
        }

        internal void method_33()
        {
            if (this.bool_13)
            {
                this.TOCField.m_formattingString = string.Empty;
                if (this.bool_7)
                {
                    this.method_34();
                }
                this.method_40();
                this.method_36();
                this.method_37();
                this.method_39();
                this.method_35();
                this.method_38();
                this.bool_14 = true;
            }
        }

        private void method_34()
        {
            string str = string.Format(BookmarkStart.b("渱嬳ᘵᨷ䄹఻䌽洿㥁畃㭅橇橉", 12), this.int_7, this.int_6);
            Field tOCField = this.TOCField;
            tOCField.m_formattingString = tOCField.m_formattingString + str;
        }

        private void method_35()
        {
            int num = 10;
            if (this.bool_10)
            {
                Field tOCField = this.TOCField;
                tOCField.m_formattingString = tOCField.m_formattingString + BookmarkStart.b("氯娱ᐳ樵䈷ᨹ", num);
            }
        }

        private void method_36()
        {
            int num = 1;
            if (!this.bool_12)
            {
                Field tOCField = this.TOCField;
                object formattingString = tOCField.m_formattingString;
                tOCField.m_formattingString = string.Concat(new object[] { formattingString, BookmarkStart.b("符", num), 'n', BookmarkStart.b("ܦ", num), string.Format(BookmarkStart.b("尦ᤨ嘪,吮0串", num), this.int_9, this.int_8) });
            }
        }

        private void method_37()
        {
            int num = 12;
            if (!this.bool_9)
            {
                Field tOCField = this.TOCField;
                object formattingString = tOCField.m_formattingString;
                tOCField.m_formattingString = string.Concat(new object[] { formattingString, BookmarkStart.b("渱", num), 'p', BookmarkStart.b("ሱᘳᘵᨷᨹ", num) });
            }
        }

        private void method_38()
        {
            int num = 0x10;
            if (this.bool_11)
            {
                Field tOCField = this.TOCField;
                object formattingString = tOCField.m_formattingString;
                tOCField.m_formattingString = string.Concat(new object[] { formattingString, BookmarkStart.b("樵", num), 'u', BookmarkStart.b("ᘵ", num) });
            }
        }

        private void method_39()
        {
            int num = 0x10;
            if (this.bool_8)
            {
                Field tOCField = this.TOCField;
                object formattingString = tOCField.m_formattingString;
                tOCField.m_formattingString = string.Concat(new object[] { formattingString, BookmarkStart.b("樵", num), 'f', BookmarkStart.b("ᘵ", num), this.string_9 });
            }
        }

        private void method_40()
        {
            int num = 11;
            if ((this.dictionary_0 != null) && (this.dictionary_0.Count != 0))
            {
                Field tOCField = this.TOCField;
                object formattingString = tOCField.m_formattingString;
                tOCField.m_formattingString = string.Concat(new object[] { formattingString, BookmarkStart.b("洰", num), 't', BookmarkStart.b("ᄰᄲ", num) });
                for (int i = this.int_7; i <= this.int_6; i++)
                {
                    if (this.TOCStyles.ContainsKey(i) && (Style.BuiltinStyleLoader.string_2[i] != this.TOCStyles[i].Name))
                    {
                        Field field2 = this.TOCField;
                        object obj2 = field2.m_formattingString;
                        field2.m_formattingString = string.Concat(new object[] { obj2, this.TOCStyles[i].Name, this.string_10, i, this.string_10 });
                    }
                }
                Field field3 = this.TOCField;
                field3.m_formattingString = field3.m_formattingString + BookmarkStart.b("ጰ", num);
            }
        }

        private void method_41(string A_0)
        {
            this.method_42(A_0, true);
        }

        private void method_42(string A_0, bool A_1)
        {
            MatchCollection matchs = new Regex(BookmarkStart.b("挷ਹᄻܽᴿ", 0x12)).Matches(A_0);
            if (matchs.Count == 2)
            {
                if (A_1)
                {
                    this.int_7 = int.Parse(matchs[0].Groups[0].Value);
                    this.int_6 = int.Parse(matchs[1].Groups[0].Value);
                }
                else
                {
                    this.int_9 = int.Parse(matchs[0].Groups[0].Value);
                    this.int_8 = int.Parse(matchs[1].Groups[0].Value);
                }
            }
            else if (matchs.Count == 0)
            {
                if (A_1)
                {
                    this.int_6 = 9;
                }
                else
                {
                    this.int_8 = 9;
                }
            }
        }

        private void method_43(string A_0)
        {
            Regex regex = new Regex(BookmarkStart.b("甭ሯ漱漳ᘵ攷愹ḻ挽", 8));
            if (regex.Match(A_0).Captures.Count == 1)
            {
                this.bool_9 = false;
            }
        }

        private void method_44(string A_0)
        {
            this.bool_8 = true;
            this.string_9 = A_0.Substring(1, A_0.Length - 1);
        }

        private void method_45(string A_0)
        {
            char ch = this.string_10.ToCharArray()[0];
            string[] strArray2 = A_0.Split(new char[] { '"' })[1].Split(new char[] { ch });
            int num = -1;
            int index = 0;
            int length = strArray2.Length;
            while ((index + 1) < length)
            {
                num = int.Parse(strArray2[index + 1]);
                this.method_48(num, strArray2[index].Trim(), false);
                index += 2;
            }
            if (this.TOCStyles.Count > 0)
            {
                this.bool_7 = false;
            }
            this.bool_13 = false;
        }

        private void method_46()
        {
            this.method_30();
            this.bool_13 = true;
        }

        private void method_47()
        {
            this.method_30();
        }

        private void method_48(int A_0, string A_1, bool A_2)
        {
            if (A_2)
            {
                this.method_46();
            }
            BuiltinStyle bStyle = Style.NameToBuiltIn(A_1);
            IParagraphStyle style = base.m_doc.Styles.FindByName(A_1, StyleType.ParagraphStyle) as IParagraphStyle;
            Style.NameToBuiltIn(A_1.ToLower());
            IParagraphStyle style3 = base.m_doc.Styles.FindByName(A_1.ToLower(), StyleType.ParagraphStyle) as IParagraphStyle;
            if (((style != null) || (bStyle != BuiltinStyle.User)) && ((style == null) && (style3 == null)))
            {
                style = (IParagraphStyle) Style.CreateBuiltinStyle(bStyle, base.m_doc);
                base.m_doc.Styles.Add(style);
            }
            if (style != null)
            {
                this.TOCStyles[A_0] = style as ParagraphStyle;
            }
            else if (style3 != null)
            {
                this.TOCStyles[A_0] = style3 as ParagraphStyle;
            }
        }

        private void method_49(string A_0, int A_1)
        {
            int num = 2;
            if ((A_1 < 1) || (A_1 > 9))
            {
                throw new ArgumentOutOfRangeException(A_0, BookmarkStart.b("搧伩娫䬭尯ሱ娳䌵唷堹夻䰽怿㑁╃⩅㵇⽉汋⍍╏⅑⁓癕㩗㽙籛㥝቟ݡգብ൧ᡩ䱫ᩭᡯ፱ᩳ噵䥷婹ᵻၽꊁ늑ﺕ聯벛꾝邟財", num));
            }
        }

        internal void method_50()
        {
            if (this.TOCLevels.Count > 0)
            {
                this.TOCLevels.Clear();
            }
            if ((this.TOCStyles.Count > 0) && !this.UseHeadingStyles)
            {
                foreach (KeyValuePair<int, ParagraphStyle> pair in this.TOCStyles)
                {
                    if (!this.TOCLevels.Contains(pair.Key))
                    {
                        this.TOCLevels.Add(pair.Key);
                    }
                }
            }
            else
            {
                for (int i = this.int_7; i <= this.int_6; i++)
                {
                    this.TOCLevels.Add(i);
                }
            }
        }

        internal void method_51()
        {
            this.method_50();
            this.method_61();
            this.method_62();
            this.method_53();
            using (Class195 class2 = new Class195())
            {
                class2.method_38(this.TOCLevels);
                class2.method_42(this.UseTableEntryFields);
                this.TOCEntryPageNumbers = class2.method_83(base.Document);
                class2.method_51();
                this.method_74();
            }
        }

        internal bool method_52(Paragraph A_0)
        {
            Paragraph ownerParagraph = base.OwnerParagraph;
            Paragraph lastTOCParagraph = this.LastTOCParagraph;
            if (((A_0 != null) && (ownerParagraph != null)) && (lastTOCParagraph != null))
            {
                if (A_0.OwnerTextBody != ownerParagraph.OwnerTextBody)
                {
                    return false;
                }
                int num3 = ownerParagraph.method_5();
                int num2 = lastTOCParagraph.method_5();
                int num = A_0.method_5();
                if ((((num3 > -1) && (num2 > -1)) && ((num > -1) && (num >= num3))) && (num <= num2))
                {
                    return true;
                }
            }
            return false;
        }

        private void method_53()
        {
            foreach (ISection section in base.Document.Sections)
            {
                this.method_54(section.Body);
            }
        }

        private void method_54(Body A_0)
        {
            for (int i = 0; i < A_0.Items.Count; i++)
            {
                if (A_0.Items[i] is Paragraph)
                {
                    IParagraph paragraph = A_0.Items[i] as Paragraph;
                    this.method_56(paragraph);
                    i = A_0.Items.IndexOf(paragraph);
                }
                else if (A_0.Items[i] is Table)
                {
                    ITable table = A_0.ChildObjects[i] as Table;
                    this.method_55(table);
                    i = A_0.Items.IndexOf(table);
                }
            }
        }

        private void method_55(ITable A_0)
        {
            for (int i = 0; i < A_0.Rows.Count; i++)
            {
                TableRow row = A_0.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    TableCell cell = row.Cells[j];
                    this.method_54(cell);
                }
            }
        }

        private void method_56(IParagraph A_0)
        {
            List<int> list;
            int num = 11;
            if (this.TOCNewParagraphList.Contains(A_0))
            {
                return;
            }
            if (!this.method_64(A_0.Format.OutlineLevelEx))
            {
                goto Label_00F9;
            }
            this.method_57(A_0);
            if (string.IsNullOrEmpty(A_0.Text))
            {
                goto Label_00F9;
            }
            int num4 = 0;
            using (IEnumerator enumerator = A_0.Items.GetEnumerator())
            {
                ParagraphBase current;
                while (enumerator.MoveNext())
                {
                    current = (ParagraphBase) enumerator.Current;
                    if (((current is TextRange) && ((current as TextRange).Text != BookmarkStart.b("㠰", num))) && ((base.OwnerParagraph != A_0) || !((current as TextRange).Text == BookmarkStart.b("攰簲瘴", num))))
                    {
                        goto Label_00BC;
                    }
                }
                goto Label_00E2;
            Label_00BC:
                num4 = A_0.Items.IndexOf(current);
            }
        Label_00E2:
            this.method_67(A_0, null, num4, A_0.Items.Count + 1);
        Label_00F9:
            list = new List<int>();
            for (int i = 0; i < A_0.Items.Count; i++)
            {
                if (A_0.Items[i] is TextBox)
                {
                    TextBox box = A_0.Items[i] as TextBox;
                    this.method_54(box.Body);
                }
                else if (A_0.Items[i] is Field)
                {
                    Field field = A_0.Items[i] as Field;
                    if ((field.Type == FieldType.FieldTOCEntry) && this.UseTableEntryFields)
                    {
                        list.Add(i);
                    }
                }
            }
            for (int j = 0; j < list.Count; j++)
            {
                int num5 = list[j] + (j * 2);
                list.RemoveAt(j);
                this.method_67(A_0, A_0.Items[num5] as Field, num5, num5 + 2);
            }
        }

        private void method_57(IParagraph A_0)
        {
            int num = 8;
            if ((A_0.Text.Contains(BookmarkStart.b("✭", 8)) || A_0.Text.Contains(BookmarkStart.b("␭", num))) || A_0.Text.Contains(BookmarkStart.b("⌭", num)))
            {
                for (int i = 0; i < A_0.Items.Count; i++)
                {
                    if (A_0.Items[i] is TextRange)
                    {
                        TextRange range = A_0.Items[i] as TextRange;
                        string text = range.Text;
                        if ((range.Text != BookmarkStart.b("✭", num)) && range.Text.Contains(BookmarkStart.b("✭", num)))
                        {
                            this.method_58(range);
                        }
                        if (range.Text.Contains(BookmarkStart.b("␭", num)))
                        {
                            this.method_59(range, BookmarkStart.b("␭", num));
                            return;
                        }
                        if (range.Text.Contains(BookmarkStart.b("⌭", num)))
                        {
                            this.method_59(range, BookmarkStart.b("⌭", num));
                            return;
                        }
                    }
                }
            }
        }

        private void method_58(TextRange A_0)
        {
            int num = 0;
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            string text = A_0.Text;
            int index = text.IndexOf(BookmarkStart.b("⼥", 0));
            int num3 = ownerParagraph.Items.IndexOf(A_0);
            string str2 = text.Substring(index + 1);
            TextRange entity = A_0.Clone() as TextRange;
            if (index > 0)
            {
                entity.Text = text.Substring(index);
                A_0.Text = text.Substring(0, index);
            }
            else if (str2 != string.Empty)
            {
                entity.Text = str2;
                A_0.Text = BookmarkStart.b("⼥", num);
            }
            ownerParagraph.Items.Insert(num3 + 1, entity);
        }

        private void method_59(TextRange A_0, string A_1)
        {
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            string text = A_0.Text;
            int index = text.IndexOf(A_1);
            int num2 = ownerParagraph.Items.IndexOf(A_0);
            string str2 = text.Substring(index + 1);
            if (str2 != string.Empty)
            {
                TextRange entity = A_0.Clone() as TextRange;
                entity.Text = str2;
                ownerParagraph.Items.Insert(num2 + 1, entity);
                A_0.Text = text.Substring(0, index);
            }
            else
            {
                A_0.Text = text.Substring(0, index);
            }
            this.method_60(ownerParagraph, num2 + 1);
            if (A_0.Text == string.Empty)
            {
                ownerParagraph.Items.Remove(A_0);
            }
        }

        private void method_60(Paragraph A_0, int A_1)
        {
            Body ownerTextBody = A_0.OwnerTextBody;
            int index = ownerTextBody.Items.IndexOf(A_0);
            Paragraph entity = A_0.Clone() as Paragraph;
            int count = entity.Items.Count;
            for (int i = 0; i < count; i++)
            {
                entity.Items.RemoveAt(0);
            }
            ownerTextBody.Items.Insert(index + 1, entity);
            count = A_0.Items.Count;
            for (int j = A_1; j < count; j++)
            {
                entity.Items.Insert(entity.Items.Count, A_0.Items[A_1]);
            }
        }

        private void method_61()
        {
            int num = 0;
            Paragraph ownerParagraph = base.OwnerParagraph;
            Body ownerTextBody = ownerParagraph.OwnerTextBody;
            int index = ownerTextBody.Items.IndexOf(ownerParagraph);
            bool flag = true;
            int num3 = index;
            int num4 = 0;
            while (num3 < ownerTextBody.Items.Count)
            {
                if (!(ownerTextBody.Items[num3] is Paragraph))
                {
                    goto Label_01E7;
                }
                Paragraph entity = ownerTextBody.Items[num3] as Paragraph;
                int num6 = 0;
                if (num3 == index)
                {
                    num6 = entity.Items.IndexOf(this);
                }
                for (int i = num6; i < entity.Items.Count; i++)
                {
                    if (((entity.Items[i] == this) && (entity.Items[i + 1] is FieldMark)) && ((entity.Items[i + 1] as FieldMark).Type == FieldMarkType.FieldSeparator))
                    {
                        num4++;
                        i++;
                    }
                    else
                    {
                        if (entity.Items[i] is FieldMark)
                        {
                            FieldMark mark2 = entity.Items[i] as FieldMark;
                            if (mark2.Type == FieldMarkType.FieldSeparator)
                            {
                                num4++;
                            }
                            else if (mark2.Type == FieldMarkType.FieldEnd)
                            {
                                if ((i == 0) && (num4 == 1))
                                {
                                    break;
                                }
                                num4--;
                            }
                        }
                        else if ((entity.Items[i] is TextRange) && ((entity.Items[i] as TextRange).Text == BookmarkStart.b("爥朧椩", num)))
                        {
                            goto Label_01A2;
                        }
                        entity.Items.Remove(entity.Items[i]);
                        i--;
                    }
                }
                goto Label_01A5;
            Label_01A2:
                flag = false;
            Label_01A5:
                if (entity.Items.Count == 0)
                {
                    ownerTextBody.Items.Remove(entity);
                    num3--;
                }
                else
                {
                    if ((entity.Items[0] is FieldMark) && flag)
                    {
                        entity.Items.Insert(0, this);
                        FieldMark separator = null;
                        if (this.TOCField.Separator != null)
                        {
                            separator = this.TOCField.Separator;
                        }
                        else
                        {
                            separator = new FieldMark(base.Document, FieldMarkType.FieldSeparator);
                            this.TOCField.Separator = separator;
                        }
                        if (separator != null)
                        {
                            entity.Items.Insert(1, separator);
                        }
                        TextRange range = new TextRange(base.Document) {
                            Text = BookmarkStart.b("爥朧椩", num)
                        };
                        entity.Items.Insert(2, range);
                        ownerTextBody.Items.Remove(ownerParagraph);
                        return;
                    }
                    if (!flag)
                    {
                        return;
                    }
                }
            Label_01E7:
                num3++;
            }
        }

        private void method_62()
        {
            string str = string.Format(this.string_11, this.int_7, this.int_6);
            for (int i = base.Document.Bookmarks.Count - 1; i >= 0; i--)
            {
                Bookmark bookmark = base.Document.Bookmarks[i];
                if (bookmark.Name.StartsWith(str))
                {
                    base.Document.Bookmarks.Remove(bookmark);
                }
            }
        }

        private bool method_63(string A_0)
        {
            int num = 13;
            if (A_0 != null)
            {
                A_0 = A_0.ToLower().Replace(BookmarkStart.b("ጲ", num), "");
            }
            else
            {
                A_0 = BookmarkStart.b("崲娴䔶吸娺儼", num);
            }
            return false;
        }

        private bool method_64(int A_0)
        {
            return this.TOCLevels.Contains(A_0);
        }

        private int method_65(int A_0)
        {
            if (this.TOCLevels.Contains(A_0))
            {
                return A_0;
            }
            return 9;
        }

        private int method_66(string A_0)
        {
            A_0 = A_0.ToLower().Replace(BookmarkStart.b("ᔴ", 15), "");
            return 0;
        }

        private void method_67(IParagraph A_0, Field A_1, int A_2, int A_3)
        {
            string name = this.method_73();
            BookmarkStart entity = new BookmarkStart(base.Document, name);
            A_0.Items.Insert(A_2, entity);
            this.method_68(A_0, A_1, name);
            if (A_1 == null)
            {
                A_3 = A_0.Items.Count;
            }
            BookmarkEnd end = new BookmarkEnd(base.Document, name);
            A_0.Items.Insert(A_3, end);
        }

        private void method_68(IParagraph A_0, Field A_1, string A_2)
        {
            int num = 0x10;
            int num2 = this.method_65(A_0.Format.OutlineLevelEx);
            if ((num2 >= 0) && (num2 < 9))
            {
                string str = string.Empty;
                if (A_1 != null)
                {
                    str = A_1.Value;
                    num2 = int.Parse(A_1.FormattingString.Replace(BookmarkStart.b("樵吷", num), "").Replace(BookmarkStart.b("ᘵ", num), ""));
                }
                Paragraph paragraph = this.method_72(num2);
                this.method_69(A_0, paragraph, str, A_2);
                if (this.IncludePageNumbers || (!this.IncludePageNumbers && ((num2 > this.int_8) || (num2 < this.int_9))))
                {
                    this.method_70(paragraph, A_2);
                }
            }
        }

        private void method_69(IParagraph A_0, Paragraph A_1, string A_2, string A_3)
        {
            int num = 6;
            Field entity = new Field(base.Document) {
                Type = FieldType.FieldHyperlink
            };
            A_1.Items.Add(entity);
            A_1.AppendFieldMark(FieldMarkType.FieldSeparator);
            if (!string.IsNullOrEmpty(A_2))
            {
                A_1.AppendText(A_2).CharacterFormat.CharStyleName = BookmarkStart.b("搫圭䀯圱䘳娵儷吹圻", num);
            }
            else
            {
                this.method_76(A_0, A_1);
                foreach (ParagraphBase base2 in A_0.Items)
                {
                    if ((base2 is TextRange) && ((base2 as TextRange).Text != BookmarkStart.b("┫", num)))
                    {
                        ITextRange range = A_1.AppendText((base2 as TextRange).Text);
                        if ((base2 as TextRange).CharacterFormat.HasKey(60))
                        {
                            range.CharacterFormat.Bold = (base2 as TextRange).CharacterFormat.Bold;
                        }
                        if ((base2 as TextRange).CharacterFormat.HasKey(70))
                        {
                            range.CharacterFormat.Italic = (base2 as TextRange).CharacterFormat.Italic;
                        }
                        range.CharacterFormat.CharStyleName = BookmarkStart.b("搫圭䀯圱䘳娵儷吹圻", num);
                    }
                }
            }
            FieldMark mark = new FieldMark(base.Document, FieldMarkType.FieldEnd);
            A_1.Items.Add(mark);
            Hyperlink hyperlink = new Hyperlink(entity) {
                Type = HyperlinkType.Bookmark,
                BookmarkName = A_3
            };
        }

        private void method_70(Paragraph A_0, string A_1)
        {
            TextRange range;
            int num = 15;
            if (this.RightAlignPageNumbers)
            {
                A_0.Format.Tabs.AddTab(this.method_71(A_0), TabJustification.Right, TabLeader.Dotted);
                range = new TextRange(base.Document) {
                    Text = BookmarkStart.b("㰴", num)
                };
                A_0.Items.Insert(A_0.Items.Count - 1, range);
            }
            Field entity = new Field(base.Document) {
                Type = FieldType.FieldPageRef,
                Code = BookmarkStart.b("攴瘶縸縺漼稾݀捂", num) + A_1 + BookmarkStart.b("ᔴ欶儸", num),
                m_fieldValue = A_1 + BookmarkStart.b("ᔴ欶儸", num)
            };
            A_0.Items.Insert(A_0.Items.Count - 1, entity);
            FieldMark mark = new FieldMark(base.Document, FieldMarkType.FieldSeparator);
            A_0.Items.Insert(A_0.Items.Count - 1, mark);
            range = new TextRange(base.Document);
            A_0.Items.Insert(A_0.Items.Count - 1, range);
            mark = new FieldMark(base.Document, FieldMarkType.FieldEnd);
            A_0.Items.Insert(A_0.Items.Count - 1, mark);
        }

        private float method_71(DocumentObject A_0)
        {
            float num = 0f;
            DocumentObject owner = A_0;
            while (!(owner is Section))
            {
                if (owner.Owner == null)
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (!(owner is Section))
            {
                return num;
            }
            if ((owner as Section).Columns.Count > 1)
            {
                return ((owner as Section).Columns[0].Width - ((float) 0.5));
            }
            return ((owner as Section).PageSetup.ClientWidth - ((float) 0.5));
        }

        private Paragraph method_72(int A_0)
        {
            Body ownerTextBody = this.LastTOCParagraph.OwnerTextBody;
            int index = ownerTextBody.Items.IndexOf(this.LastTOCParagraph);
            int num2 = this.LastTOCParagraph.Items.IndexOf(this);
            if (num2 > 0)
            {
                this.method_60(this.LastTOCParagraph, num2);
                this.paragraph_0 = base.OwnerParagraph;
            }
            index = ownerTextBody.Items.IndexOf(this.LastTOCParagraph);
            Paragraph entity = new Paragraph(base.Document);
            ownerTextBody.Items.Insert(index, entity);
            A_0 += 0x12;
            entity.ApplyStyle((BuiltinStyle) A_0);
            if (this.LastTOCParagraph == base.OwnerParagraph)
            {
                for (int i = 0; i < this.LastTOCParagraph.Items.Count; i++)
                {
                    if (this.LastTOCParagraph.Items[i] == this)
                    {
                        entity.Items.Insert(entity.Items.Count, this.LastTOCParagraph.Items[i]);
                        i--;
                    }
                    else if (this.LastTOCParagraph.Items[i] is FieldMark)
                    {
                        entity.Items.Insert(entity.Items.Count, this.LastTOCParagraph.Items[i]);
                        i--;
                    }
                    else if (this.LastTOCParagraph.Items[i] is TextRange)
                    {
                        this.LastTOCParagraph.Items.Remove(this.LastTOCParagraph.Items[i]);
                        i--;
                        break;
                    }
                }
            }
            if (!this.TOCNewParagraphList.Contains(entity))
            {
                this.TOCNewParagraphList.Add(entity);
            }
            return entity;
        }

        private string method_73()
        {
            this.int_11++;
            return (string.Format(this.string_11, this.int_7, this.int_6) + string.Format(BookmarkStart.b("䴵࠷9఻฽瀿牁瑃癅硇穉籋繍ⵏ", 0x10), this.int_11));
        }

        private void method_74()
        {
            int num = 9;
            Paragraph ownerParagraph = base.OwnerParagraph;
            Body ownerTextBody = ownerParagraph.OwnerTextBody;
            int index = ownerTextBody.ChildObjects.IndexOf(ownerParagraph);
            int num3 = ownerTextBody.ChildObjects.IndexOf(this.LastTOCParagraph);
            int num4 = index;
            int num5 = 0;
            while (num4 < num3)
            {
                if (ownerTextBody.ChildObjects[num4] is Paragraph)
                {
                    Paragraph paragraph2 = ownerTextBody.ChildObjects[num4] as Paragraph;
                    int num6 = int.Parse(paragraph2.ParaStyle.Name.Replace(BookmarkStart.b("笮縰瀲", num), string.Empty));
                    if ((num6 < this.int_9) || (num6 > this.int_8))
                    {
                        TextRange range = this.method_75(paragraph2);
                        if (range != null)
                        {
                            range.Text = this.TOCEntryPageNumbers[num5].ToString();
                        }
                        num5++;
                    }
                }
                num4++;
            }
        }

        private TextRange method_75(Paragraph A_0)
        {
            if ((A_0 != null) && (A_0.ChildObjects.Count >= 3))
            {
                for (int i = A_0.ChildObjects.Count - 3; i > 0; i--)
                {
                    DocumentObject obj2 = A_0.ChildObjects[i];
                    if (obj2 is TextRange)
                    {
                        return (obj2 as TextRange);
                    }
                }
            }
            return null;
        }

        private void method_76(IParagraph A_0, Paragraph A_1)
        {
            Paragraph paragraph = A_0 as Paragraph;
            ListFormat listFormat = null;
            ParagraphStyle paraStyle = paragraph.ParaStyle;
            if (paragraph.ListFormat.ListType != ListType.NoList)
            {
                listFormat = paragraph.ListFormat;
            }
            else if (paraStyle.ListFormat.ListType != ListType.NoList)
            {
                listFormat = paraStyle.ListFormat;
            }
            if ((listFormat != null) && (listFormat.CurrentListStyle != null))
            {
                ListStyle currentListStyle = listFormat.CurrentListStyle;
                int levelNumber = 0;
                if (paragraph.ListFormat.HasKey(0))
                {
                    levelNumber = paragraph.ListFormat.ListLevelNumber;
                }
                else if (paraStyle.ListFormat.HasKey(0))
                {
                    levelNumber = paraStyle.ListFormat.ListLevelNumber;
                }
                ListLevel nearLevel = currentListStyle.GetNearLevel(levelNumber);
                Class12 class2 = null;
                if ((listFormat.LFOStyleName != null) && (listFormat.LFOStyleName.Length > 0))
                {
                    class2 = base.Document.ListOverrides.method_35(listFormat.LFOStyleName);
                }
                if (((class2 != null) && class2.method_23().method_11(levelNumber)) && class2.method_23().method_5(levelNumber).OverrideFormatting)
                {
                    nearLevel = class2.method_23().method_5(levelNumber).OverrideListLevel;
                }
                string str = base.Document.method_132(paragraph, listFormat, nearLevel);
                if (str != string.Empty)
                {
                    this.method_77(A_0, A_1, str);
                }
            }
        }

        private void method_77(IParagraph A_0, Paragraph A_1, string A_2)
        {
            int num = 0x13;
            ITextRange range = A_1.AppendText(A_2);
            if (A_0.BreakCharacterFormat.HasKey(60))
            {
                range.CharacterFormat.Bold = A_0.BreakCharacterFormat.Bold;
            }
            if (A_0.BreakCharacterFormat.HasKey(70))
            {
                range.CharacterFormat.Italic = A_0.BreakCharacterFormat.Italic;
            }
            range.CharacterFormat.CharStyleName = BookmarkStart.b("焸䈺䴼娾㍀⽂ⱄ⥆≈", num);
            int leftIndent = 0;
            if (A_1.Format.HasValue(0x488))
            {
                leftIndent = (int) A_1.Format.LeftIndent;
            }
            else if ((A_1.Format.BaseFormat != null) && A_1.Format.BaseFormat.HasValue(0x488))
            {
                leftIndent = (int) (A_1.Format.BaseFormat as ParagraphFormat).LeftIndent;
            }
            else if (A_1.Format.HasValue(0x492))
            {
                leftIndent = (int) A_1.Format.FirstLineIndent;
            }
            else if ((A_1.Format.BaseFormat != null) && A_1.Format.BaseFormat.HasValue(0x492))
            {
                leftIndent = (int) (A_1.Format.BaseFormat as ParagraphFormat).FirstLineIndent;
            }
            using (Class196 class2 = new Class196())
            {
                leftIndent += (int) class2.method_323(range as TextRange, range.Text).Width;
                leftIndent += 14;
                leftIndent = ((int) Math.Ceiling((decimal) (leftIndent / 11M))) * 11;
                A_1.Format.Tabs.AddTab((float) leftIndent, TabJustification.Left, TabLeader.NoLeader);
                range = A_1.AppendText(BookmarkStart.b("〸", num));
            }
        }

        private int[] method_78(int[] A_0)
        {
            for (int i = 0; i < (A_0.Length - 1); i++)
            {
                for (int j = i + 1; j < A_0.Length; j++)
                {
                    if (A_0[i] > A_0[j])
                    {
                        int num3 = A_0[i];
                        A_0[i] = A_0[j];
                        A_0[j] = num3;
                    }
                }
            }
            return A_0;
        }

        internal bool method_79(Class420 A_0)
        {
            if (base.IsDeleteRevision)
            {
                return A_0.vmethod_21();
            }
            return true;
        }

        public void SetTOCLevelStyle(int levelNumber, string styleName)
        {
            this.method_49(BookmarkStart.b("䘩䤫堭唯帱稳䌵唷堹夻䰽", 4), levelNumber);
            this.method_48(levelNumber, styleName, true);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("匦倨嬪䠬", 1), ParagraphItemType.TOC);
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.TOC;
            }
        }

        internal string FormattingString
        {
            get
            {
                return this.field_0.m_formattingString;
            }
            set
            {
                this.field_0.m_formattingString = value;
                this.bool_14 = false;
                this.method_30();
            }
        }

        public bool IncludePageNumbers
        {
            get
            {
                this.method_47();
                return this.bool_12;
            }
            set
            {
                this.method_46();
                this.bool_12 = value;
            }
        }

        private Paragraph LastTOCParagraph
        {
            get
            {
                if (this.paragraph_0 == null)
                {
                    this.paragraph_0 = base.OwnerParagraph;
                }
                return this.paragraph_0;
            }
        }

        public int LowerHeadingLevel
        {
            get
            {
                this.method_47();
                return this.int_7;
            }
            set
            {
                this.method_49(BookmarkStart.b("缲娴䀶尸䤺甼娾⁀❂ⱄ⥆⹈݊⡌㥎㑐㽒", 13), value);
                this.method_46();
                this.int_7 = value;
            }
        }

        public bool RightAlignPageNumbers
        {
            get
            {
                this.method_47();
                return this.bool_9;
            }
            set
            {
                this.method_46();
                this.bool_9 = value;
            }
        }

        public string TableID
        {
            get
            {
                return this.string_9;
            }
            set
            {
                this.string_9 = value;
            }
        }

        private List<int> TOCEntryPageNumbers
        {
            get
            {
                if (this.list_1 == null)
                {
                    this.list_1 = new List<int>();
                }
                return this.list_1;
            }
            set
            {
                this.list_1 = value;
            }
        }

        internal Field TOCField
        {
            get
            {
                return this.field_0;
            }
        }

        internal List<int> TOCLevels
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<int>();
                }
                return this.list_0;
            }
        }

        private List<IParagraph> TOCNewParagraphList
        {
            get
            {
                if (this.list_2 == null)
                {
                    this.list_2 = new List<IParagraph>();
                }
                return this.list_2;
            }
        }

        internal Dictionary<int, ParagraphStyle> TOCStyles
        {
            get
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<int, ParagraphStyle>();
                }
                return this.dictionary_0;
            }
        }

        public int UpperHeadingLevel
        {
            get
            {
                this.method_47();
                return this.int_6;
            }
            set
            {
                this.method_49(BookmarkStart.b("永䬺䴼娾㍀ୂ⁄♆ⵈ≊⍌⡎ᵐ㙒⍔㉖㕘", 0x13), value);
                this.method_46();
                this.int_6 = value;
            }
        }

        public bool UseAbsolutePos
        {
            get
            {
                return this.bool_15;
            }
            set
            {
                this.bool_15 = value;
            }
        }

        public bool UseHeadingStyles
        {
            get
            {
                this.method_47();
                return this.bool_7;
            }
            set
            {
                this.method_46();
                this.bool_7 = value;
            }
        }

        public bool UseHyperlinks
        {
            get
            {
                this.method_47();
                return this.bool_10;
            }
            set
            {
                this.method_46();
                this.bool_10 = value;
            }
        }

        public bool UseOutlineLevels
        {
            get
            {
                this.method_47();
                return this.bool_11;
            }
            set
            {
                this.method_46();
                this.bool_11 = value;
            }
        }

        public bool UseTableEntryFields
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

