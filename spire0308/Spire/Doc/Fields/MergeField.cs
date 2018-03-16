namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class MergeField : Field, IMergeField
    {
        [CompilerGenerated]
        private bool bool_35;
        [CompilerGenerated]
        private bool bool_36;
        private byte byte_4;
        private byte[] byte_5;
        protected string m_fieldName;
        private ParagraphItemCollection paragraphItemCollection_1;
        private static Regex regex_8 = new Regex(BookmarkStart.b("朩椫簭眯眱爳缵紷瘹砻戽㌿楁晃祅恇ᅉቋ瑍牏ད罓罕扗教瑛՝㹟䁡㥣䱥䅧䡩卫", 4));
        private string string_18;
        private string string_19;
        private string string_20;
        private string[] string_21;
        private string string_22;
        private string string_23;
        private string string_24;
        private string string_25;

        public MergeField(IDocument doc) : base(doc)
        {
            this.m_fieldName = "";
            this.string_18 = "";
            this.string_19 = "";
            this.string_22 = "";
            this.string_23 = "";
            this.string_24 = "";
            base.m_paraItemType = ParagraphItemType.MergeField;
            this.paragraphItemCollection_1 = new ParagraphItemCollection(doc as Document);
            this.paragraphItemCollection_1.method_0(this);
            base.m_fieldType = FieldType.FieldMergeField;
        }

        protected internal override string ConvertSwitchesToString()
        {
            int num = 8;
            string str = "";
            if (this.TextBefore != "")
            {
                str = BookmarkStart.b("爭刯ሱᘳ", num) + this.TextBefore + BookmarkStart.b("భ", num);
            }
            if (this.TextAfter != "")
            {
                str = str + BookmarkStart.b("อ氯吱ᐳᐵ", num) + this.TextAfter + BookmarkStart.b("భ", num);
            }
            return (str + base.ConvertSwitchesToString());
        }

        internal void method_235()
        {
            for (int i = 0; i < this.TextItems.Count; i++)
            {
                ParagraphBase base2 = this.TextItems[i];
                base2.CharacterFormat.ApplyBase(this.CharacterFormat.BaseFormat);
            }
        }

        private void method_236(string A_0)
        {
            int num = 4;
            string[] strArray = A_0.Trim().Split(new char[] { ' ' });
            strArray[0] = strArray[0].ToUpper();
            string str = "";
            for (int i = 0; i < strArray.Length; i++)
            {
                str = str + strArray[i] + BookmarkStart.b("਩", num);
            }
            A_0 = str;
            if (str.StartsWith(BookmarkStart.b("朩椫簭眯眱爳缵紷瘹砻", num)) && (str.Contains(BookmarkStart.b("瘩", num)) || str.Contains(BookmarkStart.b("ဩ", num))))
            {
                this.method_238(A_0);
            }
            else
            {
                this.method_237(A_0);
            }
        }

        private void method_237(string A_0)
        {
            Match match = regex_8.Match(A_0.Trim());
            if (match.Groups[2].Length == 0)
            {
                this.string_22 = "";
                this.m_fieldName = match.Groups[1].Value;
            }
            else
            {
                this.string_22 = match.Groups[1].Value;
                this.m_fieldName = match.Groups[2].Value;
            }
        }

        private void method_238(string A_0)
        {
            int num = 0x10;
            bool flag = false;
            string str = A_0;
            str = str.Replace(BookmarkStart.b("笵紷根笻笽ؿୁŃ੅ే橉", 0x10), string.Empty).Trim();
            if ((str.IndexOf(BookmarkStart.b("ᐵ", 0x10)) == 0) && (str.LastIndexOf(BookmarkStart.b("ᐵ", num)) == (str.Length - 1)))
            {
                str = str.Remove(0, 1);
                str = str.Remove(str.Length - 1, 1);
            }
            if (str.Contains(BookmarkStart.b("వ", num)))
            {
                this.string_22 = str.Substring(0, str.IndexOf(BookmarkStart.b("వ", num)));
                if (((!(this.string_22 == BookmarkStart.b("焵䨷唹䤻丽ጿ㙁╃㑅㱇", num)) && !(this.string_22 == BookmarkStart.b("焵䨷唹䤻丽Կⱁ⁃", num))) && (!(this.string_22 == BookmarkStart.b("戵夷堹倻嬽ጿ㙁╃㑅㱇", num)) && !(this.string_22 == BookmarkStart.b("戵夷堹倻嬽Կⱁ⁃", num)))) && !(this.string_22 == BookmarkStart.b("缵唷嬹嬻嬽", num)))
                {
                    this.string_22 = string.Empty;
                }
                else
                {
                    flag = true;
                    if (!A_0.Contains(BookmarkStart.b("樵", num)))
                    {
                        this.method_237(A_0);
                        return;
                    }
                }
            }
            if (flag)
            {
                str = str.Substring(str.IndexOf(BookmarkStart.b("వ", num)), str.Length);
            }
            this.m_fieldName = str;
        }

        private string method_239(string A_0)
        {
            int num = 15;
            string str = A_0;
            string str2 = string.Empty;
            base.m_formattingString = string.Empty;
            List<int> list = new List<int>();
            while (str.Contains(BookmarkStart.b("椴ᴶ", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴ᴶ", num));
            }
            if (str.Contains(BookmarkStart.b("椴ᐶ", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴ᐶ", num));
            }
            else if (str.Contains(BookmarkStart.b("椴夶", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴夶", num));
            }
            else if (str.Contains(BookmarkStart.b("椴礶", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴礶", num));
            }
            if (str.Contains(BookmarkStart.b("椴眶", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴眶", num));
            }
            else if (str.Contains(BookmarkStart.b("椴匶", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴匶", num));
            }
            else if (str.Contains(BookmarkStart.b("椴猶", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴猶", num));
            }
            else if (str.Contains(BookmarkStart.b("椴", num)))
            {
                str = this.method_246(str, ref list, BookmarkStart.b("椴", num));
            }
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                int length = (i == (list.Count - 1)) ? (A_0.Length - list[i]) : (list[i + 1] - list[i]);
                str2 = A_0.Substring(list[i], length);
                str2 = str2.Substring(1, str2.Length - 1);
                if (str2.Contains(BookmarkStart.b("椴", num)))
                {
                    str2 = str2.Substring(0, str2.IndexOf(BookmarkStart.b("椴", num)));
                }
                this.method_244(str2);
            }
            return str;
        }

        internal string method_240(string A_0)
        {
            string str = A_0;
            str = base.method_73(str);
            if (!string.IsNullOrEmpty(this.NumberFormat))
            {
                return this.method_242(str);
            }
            if (!string.IsNullOrEmpty(this.DateFormat))
            {
                return this.method_243(str);
            }
            return str;
        }

        internal string method_241()
        {
            return this.method_240(this.Text);
        }

        private string method_242(string A_0)
        {
            double num2;
            int num = 9;
            Regex regex = new Regex(BookmarkStart.b("献ᴰ漲᬴䬶攸ᔺ愼ጾ", 9));
            if (regex.IsMatch(this.NumberFormat, 0))
            {
                return A_0;
            }
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            string currencyGroupSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator;
            string str3 = A_0.Replace(currencyGroupSeparator, string.Empty).Replace(currencyDecimalSeparator, BookmarkStart.b("Į", num)).Replace(BookmarkStart.b("༮", num), string.Empty);
            if (string.IsNullOrEmpty(str3))
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder();
            foreach (char ch in str3)
            {
                if ((char.IsNumber(ch) || (ch == '.')) || (ch == '-'))
                {
                    builder.Append(ch);
                }
            }
            str3 = builder.ToString();
            if (!double.TryParse(str3, NumberStyles.Currency, CultureInfo.InvariantCulture, out num2))
            {
                return A_0;
            }
            num2 = double.Parse(str3, CultureInfo.InvariantCulture);
            if ((this.NumberFormat.Contains(BookmarkStart.b("ਮ", num)) || this.NumberFormat.Contains(BookmarkStart.b("弮", num))) || this.NumberFormat.Contains(BookmarkStart.b("缮", num)))
            {
                num2 /= 100.0;
            }
            string[] strArray = this.NumberFormat.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (strArray.Length <= 0)
            {
                return A_0;
            }
            string format = strArray[0];
            if ((num2 == 0.0) && (strArray.Length == 3))
            {
                return strArray[2];
            }
            if ((num2 < 0.0) && (strArray.Length == 2))
            {
                format = strArray[1];
                if (format.StartsWith(BookmarkStart.b("Ȯ", num)))
                {
                    return Math.Abs(num2).ToString(format, base.GetCultureInfo(this.CharacterFormat.LocaleIdASCII));
                }
                if (format.StartsWith(BookmarkStart.b("ܮ", num)) && format.EndsWith(BookmarkStart.b("خ", num)))
                {
                    format = format.Replace(BookmarkStart.b("ܮ", num), string.Empty).Replace(BookmarkStart.b("خ", num), string.Empty);
                    string str6 = Math.Abs(num2).ToString(format, base.GetCultureInfo(this.CharacterFormat.LocaleIdASCII));
                    return (BookmarkStart.b("ܮ", num) + str6 + BookmarkStart.b("خ", num));
                }
            }
            return num2.ToString(format, base.GetCultureInfo(this.CharacterFormat.LocaleIdASCII));
        }

        private string method_243(string A_0)
        {
            DateTime time;
            if (string.IsNullOrEmpty(A_0.Trim()))
            {
                return string.Empty;
            }
            if (DateTime.TryParse(A_0, out time))
            {
                return time.ToString(this.DateFormat, base.GetCultureInfo(this.CharacterFormat.LocaleIdASCII));
            }
            return A_0;
        }

        private void method_244(string A_0)
        {
            int num = 13;
            string str = string.Empty;
            if (A_0.Length > 0)
            {
                str = smethod_1(A_0);
                char ch2 = A_0[0];
                if (ch2 > '@')
                {
                    if (ch2 <= 'N')
                    {
                        if (ch2 == 'D')
                        {
                            goto Label_00FF;
                        }
                        if (ch2 != 'N')
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (ch2 == 'd')
                        {
                            goto Label_00FF;
                        }
                        if (ch2 != 'n')
                        {
                            return;
                        }
                    }
                    goto Label_00F7;
                }
                switch (ch2)
                {
                    case '#':
                        goto Label_00F7;

                    case '*':
                    {
                        string str2 = str;
                        if (str2 == null)
                        {
                            break;
                        }
                        if (str2 == BookmarkStart.b("昲䔴䜶尸䤺", num))
                        {
                            base.m_textFormat = TextFormat.Uppercase;
                            return;
                        }
                        if (str2 == BookmarkStart.b("缲娴䀶尸䤺", num))
                        {
                            base.m_textFormat = TextFormat.Lowercase;
                            return;
                        }
                        if (!(str2 == BookmarkStart.b("瀲吴䜶䨸", num)))
                        {
                            if (str2 == BookmarkStart.b("甲尴䔶䨸伺縼帾ㅀ", num))
                            {
                                base.m_textFormat = TextFormat.FirstCapital;
                                return;
                            }
                            break;
                        }
                        base.m_textFormat = TextFormat.Titlecase;
                        return;
                    }
                    default:
                        if (ch2 != '@')
                        {
                            return;
                        }
                        goto Label_00FF;
                }
                base.m_formattingString = base.m_formattingString + BookmarkStart.b("ጲ椴", num) + A_0;
            }
            return;
        Label_00F7:
            this.string_23 = str;
            return;
        Label_00FF:
            this.string_24 = str;
        }

        private string method_245(string A_0, List<int> A_1)
        {
            int index = A_0.Substring(A_1[A_1.Count - 1] + 1).IndexOf(BookmarkStart.b("漲", 13));
            if (index == -1)
            {
                A_0 = A_0.Substring(0, A_1[A_1.Count - 1]);
                return A_0;
            }
            A_0 = A_0.Remove(A_1[A_1.Count - 1], index);
            return A_0;
        }

        private string method_246(string A_0, ref List<int> A_1, string A_2)
        {
            int num = 15;
            int num2 = A_0.LastIndexOf(A_2);
            int num3 = 0;
            char[] chArray = new char[] { 'b', 'B', 'f', 'F', 'm', 'M', 'v', 'V' };
            while (A_0[num2] == '\\')
            {
                if (num2 < 0)
                {
                    break;
                }
                num2--;
                num3++;
            }
            if (A_2 == BookmarkStart.b("椴", num))
            {
                foreach (char ch in chArray)
                {
                    if (A_0[A_0.LastIndexOf(BookmarkStart.b("椴", num)) + 1] == ch)
                    {
                        return A_0;
                    }
                }
            }
            if ((num3 % 2) != 0)
            {
                A_1.Add(A_0.LastIndexOf(A_2));
                A_0 = this.method_245(A_0, A_1);
            }
            return A_0;
        }

        protected internal override void ParseFieldCode(string fieldCode)
        {
            base.Code = fieldCode;
            this.UpdateFieldCode(fieldCode);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 11;
            base.ReadXmlAttributes(reader);
            this.m_fieldName = reader.ReadString(BookmarkStart.b("眰娲倴嬶崸町尼刾⑀", 11));
            if (reader.HasAttribute(BookmarkStart.b("猰嘲匴堶䬸帺椼娾㥀㝂", 11)))
            {
                this.string_18 = reader.ReadString(BookmarkStart.b("猰嘲匴堶䬸帺椼娾㥀㝂", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀰唲䄴制䬸漺堼䜾㕀", num)))
            {
                this.string_19 = reader.ReadString(BookmarkStart.b("瀰唲䄴制䬸漺堼䜾㕀", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("缰䘲場唶尸䤺笼倾㍀⹂⑄㍆", num)))
            {
                this.string_23 = reader.ReadString(BookmarkStart.b("缰䘲場唶尸䤺笼倾㍀⹂⑄㍆", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("田刲䄴制缸吺似刾⁀㝂", num)))
            {
                this.string_24 = reader.ReadString(BookmarkStart.b("田刲䄴制缸吺似刾⁀㝂", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("愰䄲倴儶倸䌺", num)))
            {
                this.string_22 = reader.ReadString(BookmarkStart.b("愰䄲倴儶倸䌺", num));
            }
        }

        private static string smethod_1(string A_0)
        {
            string str = A_0.Remove(0, 1).Trim();
            char[] trimChars = new char[] { '"' };
            return str.Trim(trimChars);
        }

        protected internal override void UpdateFieldCode(string fieldCode)
        {
            int num = 0;
            bool flag = true;
            string str = this.method_239(fieldCode);
            char[] separator = new char[] { '\\' };
            string[] strArray = str.Split(separator);
            for (int i = 1; i < strArray.Length; i++)
            {
                string str3 = strArray[i];
                if (str3.Length <= 0)
                {
                    continue;
                }
                string str2 = smethod_1(str3);
                char ch = str3[0];
                if (ch <= 'V')
                {
                    switch (ch)
                    {
                        case 'M':
                        case 'V':
                            goto Label_00E1;

                        case 'B':
                            goto Label_00A4;

                        case 'F':
                            goto Label_0098;
                    }
                    goto Label_00BC;
                }
                if (ch > 'f')
                {
                    goto Label_00B0;
                }
                if (ch == 'b')
                {
                    goto Label_00A4;
                }
                if (ch != 'f')
                {
                    goto Label_00BC;
                }
            Label_0098:
                this.string_19 = str2;
                flag = false;
                continue;
            Label_00A4:
                this.string_18 = str2;
                flag = false;
                continue;
            Label_00B0:
                switch (ch)
                {
                    case 'm':
                    case 'v':
                        goto Label_00E1;
                }
            Label_00BC:
                if (flag)
                {
                    string[] strArray2;
                    (strArray2 = strArray)[0] = strArray2[0] + BookmarkStart.b("إ琧", num) + strArray[i];
                }
                continue;
            Label_00E1:
                flag = false;
            }
            this.method_236(strArray[0]);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x12;
            base.WriteXmlAttributes(writer);
            if (this.FieldName != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("縷匹夻刽␿ు╃⭅ⵇ", num), this.FieldName);
            }
            if (this.string_18 != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("稷弹娻儽㈿❁၃⍅ぇ㹉", num), this.TextBefore);
            }
            if (this.string_19 != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("礷尹䠻嬽㈿ᙁ⅃㹅㱇", num), this.TextAfter);
            }
            if (this.string_23 != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("瘷伹儻尽┿ぁɃ⥅㩇❉ⵋ㩍", num), this.NumberFormat);
            }
            if (this.string_24 != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("簷嬹䠻嬽ؿⵁ㙃⭅⥇㹉", num), this.DateFormat);
            }
            if (this.string_22 != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("样䠹夻堽⤿㩁", num), this.string_22);
            }
        }

        public string DateFormat
        {
            get
            {
                return this.string_24;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.MergeField;
            }
        }

        internal string Domain
        {
            get
            {
                return this.string_25;
            }
            set
            {
                this.string_25 = value;
            }
        }

        public string FieldName
        {
            get
            {
                return this.m_fieldName;
            }
            set
            {
                if (value.Contains(BookmarkStart.b("ဩ", 4)))
                {
                    string[] strArray = value.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    if (strArray.Length > 1)
                    {
                        this.string_22 = strArray[0];
                        this.m_fieldName = strArray[1];
                    }
                }
                else
                {
                    this.m_fieldName = value;
                }
                if ((!base.Document.bool_3 && !base.Document.bool_4) && (this.Text == string.Empty))
                {
                    this.Text = '\x00ab' + value + '\x00bb';
                }
            }
        }

        internal bool IsSkip
        {
            [CompilerGenerated]
            get
            {
                return this.bool_36;
            }
            [CompilerGenerated]
            set
            {
                this.bool_36 = value;
            }
        }

        internal bool IsToTextOfMergeFieldEvent
        {
            [CompilerGenerated]
            get
            {
                return this.bool_35;
            }
            [CompilerGenerated]
            set
            {
                this.bool_35 = value;
            }
        }

        public string NumberFormat
        {
            get
            {
                return this.string_23;
            }
        }

        public string Prefix
        {
            get
            {
                return this.string_22;
            }
            internal set
            {
                this.string_22 = value;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        public string TextAfter
        {
            get
            {
                return this.string_19;
            }
            set
            {
                this.string_19 = value;
            }
        }

        public string TextBefore
        {
            get
            {
                return this.string_18;
            }
            set
            {
                this.string_18 = value;
            }
        }

        public ParagraphItemCollection TextItems
        {
            get
            {
                if (this.paragraphItemCollection_1 == null)
                {
                    this.paragraphItemCollection_1 = new ParagraphItemCollection(base.Document);
                    this.paragraphItemCollection_1.method_0(this);
                }
                return this.paragraphItemCollection_1;
            }
        }
    }
}

