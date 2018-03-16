namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class IfField : Field
    {
        private Class621 class621_0;
        private Class621 class621_1;
        private Class621 class621_2;
        private Class621 class621_3;
        private List<Class621> list_4;
        private bool? nullable_1;
        private Regex regex_8;
        private Regex regex_9;
        private string string_18;
        private string string_19;
        private string string_20;
        private string string_21;
        private string string_22;
        private string string_23;
        private Struct28 struct28_0;
        private Struct28 struct28_1;

        public IfField(IDocument doc) : base(doc)
        {
        }

        protected override object CloneImpl()
        {
            IfField field = base.CloneImpl() as IfField;
            field.class621_0 = null;
            field.class621_1 = null;
            field.class621_2 = null;
            field.class621_3 = null;
            return field;
        }

        private void method_235()
        {
            if (this.string_18 == null)
            {
                this.method_241();
            }
        }

        internal void method_236(string A_0)
        {
            int num = 5;
            if (!string.IsNullOrEmpty(A_0))
            {
                bool flag;
                A_0.Replace('\r', '_');
                A_0 = A_0.Replace('“', '"').Replace('”', '"');
                Match match = this.OperatorExpression.Match(A_0);
                this.string_21 = match.Groups[0].Value;
                int index = match.Index;
                if (((this.string_21 == BookmarkStart.b("ᜪጬ", num)) || (this.string_21 == BookmarkStart.b("ᔪာ", num))) || (this.string_21 == BookmarkStart.b("ᜪာ", num)))
                {
                    string str7 = A_0.Substring(index - 1, 1);
                    if ((str7 != BookmarkStart.b("प", num)) && (str7 != BookmarkStart.b("ପ", num)))
                    {
                        return;
                    }
                }
                string str3 = A_0.Substring(index + this.string_21.Length);
                int length = str3.IndexOf(BookmarkStart.b("प", num));
                this.string_18 = A_0.Substring(0, index).Replace(BookmarkStart.b("截欬", num), string.Empty).Replace(BookmarkStart.b("䈪䬬", num), string.Empty).Replace(BookmarkStart.b("截䬬", num), string.Empty).Replace(BookmarkStart.b("䈪欬", num), string.Empty).Replace(BookmarkStart.b("प", num), string.Empty);
                string str8 = (length > -1) ? str3.Substring(0, length) : this.method_238(str3, true);
                if (flag = !string.IsNullOrEmpty(str8.Trim()))
                {
                    index += this.string_21.Length;
                    this.method_238(str8, flag);
                    index = A_0.IndexOf(this.string_19, index) + this.string_19.Length;
                    string str9 = A_0.Substring(index);
                    this.method_237(str9, index);
                }
                else
                {
                    index += this.string_21.Length;
                    string str2 = A_0.Substring(index, A_0.Length - index);
                    this.method_238(str2, flag);
                    index = A_0.IndexOf(this.string_19, index) + this.string_19.Length;
                    str2 = str2.Substring(str2.IndexOf(this.string_19.Trim()) + this.string_19.Length);
                    this.method_237(str2, index);
                    this.string_19 = this.string_19.Replace(BookmarkStart.b("प", num), string.Empty);
                }
                if (!string.IsNullOrEmpty(this.string_21))
                {
                    double num9;
                    double num10;
                    bool flag3 = false;
                    bool flag4 = false;
                    bool flag5 = double.TryParse(this.string_18.Trim(new char[] { ' ' }), out num9);
                    bool flag2 = double.TryParse(this.string_19.Trim(new char[] { ' ' }), out num10);
                    if (flag5 && flag2)
                    {
                        flag3 = true;
                        double num7 = double.Parse(this.string_18.Trim(new char[] { ' ' }), NumberStyles.Number);
                        double num8 = double.Parse(this.string_19.Trim(new char[] { ' ' }), NumberStyles.Number);
                        string str5 = this.string_21;
                        if (str5 != null)
                        {
                            if (str5 != BookmarkStart.b("ᘪ", num))
                            {
                                if (str5 != BookmarkStart.b("ᜪጬ", num))
                                {
                                    if (str5 != BookmarkStart.b("ᜪ", num))
                                    {
                                        if (str5 != BookmarkStart.b("ᜪာ", num))
                                        {
                                            if (!(str5 == BookmarkStart.b("ᔪ", num)))
                                            {
                                                if (str5 == BookmarkStart.b("ᔪာ", num))
                                                {
                                                    this.nullable_1 = new bool?(num7 >= num8);
                                                }
                                            }
                                            else
                                            {
                                                this.nullable_1 = new bool?(num7 > num8);
                                            }
                                        }
                                        else
                                        {
                                            this.nullable_1 = new bool?(num7 <= num8);
                                        }
                                    }
                                    else
                                    {
                                        this.nullable_1 = new bool?(num7 < num8);
                                    }
                                }
                                else
                                {
                                    this.nullable_1 = new bool?(!(num7 == num8));
                                }
                            }
                            else
                            {
                                this.nullable_1 = new bool?(num7 == num8);
                            }
                        }
                    }
                    if (!flag3)
                    {
                        DateTime time;
                        DateTime time2;
                        bool flag6 = DateTime.TryParse(this.string_18.Trim(new char[] { ' ' }), out time);
                        bool flag7 = DateTime.TryParse(this.string_19.Trim(new char[] { ' ' }), out time2);
                        if (flag6 && flag7)
                        {
                            flag4 = true;
                            int num2 = DateTime.Compare(time, time2);
                            string str = this.string_21;
                            if (str != null)
                            {
                                if (str != BookmarkStart.b("ᘪ", num))
                                {
                                    if (str != BookmarkStart.b("ᜪጬ", num))
                                    {
                                        if (!(str == BookmarkStart.b("ᜪ", num)))
                                        {
                                            if (str == BookmarkStart.b("ᔪ", num))
                                            {
                                                this.nullable_1 = new bool?(num2 > 0);
                                            }
                                        }
                                        else
                                        {
                                            this.nullable_1 = new bool?(num2 < 0);
                                        }
                                    }
                                    else
                                    {
                                        this.nullable_1 = new bool?(num2 != 0);
                                    }
                                }
                                else
                                {
                                    this.nullable_1 = new bool?(num2 == 0);
                                }
                            }
                        }
                    }
                    if (!flag3 && !flag4)
                    {
                        string str6 = this.string_21;
                        if (str6 != null)
                        {
                            if (str6 == BookmarkStart.b("ᘪ", num))
                            {
                                this.nullable_1 = new bool?(this.string_18.Trim(new char[] { ' ' }) == this.string_19.Trim(new char[] { ' ' }));
                                return;
                            }
                            if (str6 == BookmarkStart.b("ᜪጬ", num))
                            {
                                this.nullable_1 = new bool?(this.string_18.Trim(new char[] { ' ' }) != this.string_19.Trim(new char[] { ' ' }));
                                return;
                            }
                        }
                        int num6 = string.Compare(this.string_18, this.string_19);
                        string str4 = this.string_21;
                        if (str4 != null)
                        {
                            if (str4 != BookmarkStart.b("ᔪ", num))
                            {
                                if (str4 == BookmarkStart.b("ᜪ", num))
                                {
                                    this.nullable_1 = new bool?(num6 < 0);
                                }
                                else if (str4 == BookmarkStart.b("ᘪ", num))
                                {
                                    this.nullable_1 = new bool?(num6 == 0);
                                }
                                else if (str4 == BookmarkStart.b("ᜪጬ", num))
                                {
                                    this.nullable_1 = new bool?(num6 != 0);
                                }
                            }
                            else
                            {
                                this.nullable_1 = new bool?(num6 > 0);
                            }
                        }
                    }
                }
            }
        }

        private void method_237(string A_0, int A_1)
        {
            int index;
            int length;
            string[] strArray;
            int num = 7;
            MatchCollection matchs = this.FieldExpression.Matches(A_0);
            switch (matchs.Count)
            {
                case 0:
                    strArray = A_0.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (strArray.Length <= 1)
                    {
                        if (strArray.Length == 1)
                        {
                            index = A_0.IndexOf(strArray[0]);
                            length = index + strArray[0].Length;
                            this.TrueResult = this.method_240(A_0, A_1, index, length);
                            index = length;
                            this.FalseResult = this.method_240(A_0, A_1, index, length);
                            return;
                        }
                        break;
                    }
                    index = A_0.IndexOf(strArray[0]);
                    length = index + strArray[0].Length;
                    this.TrueResult = this.method_240(A_0, A_1, index, length);
                    index = A_0.IndexOf(strArray[1]);
                    length = index + strArray[1].Length;
                    this.FalseResult = this.method_240(A_0, A_1, index, length);
                    return;

                case 1:
                {
                    bool flag = false;
                    if (!(flag = A_0.Trim().IndexOf(BookmarkStart.b("༬", num)) == 0))
                    {
                        index = 0;
                        length = matchs[0].Index;
                    }
                    else
                    {
                        index = matchs[0].Index;
                        length = index + matchs[0].Length;
                    }
                    this.TrueResult = this.method_240(A_0, A_1, index, length);
                    if (flag)
                    {
                        strArray = A_0.Substring(length).Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (strArray.Length > 0)
                        {
                            index = A_0.IndexOf(strArray[0], length);
                            length = index + strArray[0].Length;
                        }
                        else
                        {
                            index = length;
                        }
                    }
                    else
                    {
                        index = length;
                        length = index + matchs[0].Length;
                    }
                    this.FalseResult = this.method_240(A_0, A_1, index, length);
                    return;
                }
                case 2:
                    index = matchs[0].Index;
                    length = matchs[1].Index;
                    this.TrueResult = this.method_240(A_0, A_1, index, length);
                    index = length;
                    this.FalseResult = this.method_240(A_0, A_1, index, A_0.Length);
                    return;

                default:
                    index = matchs[0].Index;
                    length = matchs[0].Length;
                    this.TrueResult = this.method_240(A_0, A_1, index, length);
                    index = length;
                    length = matchs[1].Index + 1;
                    this.FalseResult = this.method_240(A_0, A_1, index, length);
                    break;
            }
        }

        private string method_238(string A_0, bool A_1)
        {
            if (A_1)
            {
                string[] strArray = A_0.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                this.string_19 = strArray[0];
            }
            else
            {
                MatchCollection matchs = this.FieldExpression.Matches(A_0);
                int index = matchs[0].Index;
                int num = (matchs.Count > 1) ? matchs[1].Index : (index + matchs[0].Length);
                this.string_19 = A_0.Substring(index, num - index);
            }
            this.method_239(this.string_19);
            return this.string_19;
        }

        private void method_239(string A_0)
        {
            int num = 0x13;
            Match match = this.FieldExpression.Match(A_0);
            if ((match.Length > 0) && !string.IsNullOrEmpty(match.Value.Replace(BookmarkStart.b("ᬸ", num), string.Empty)))
            {
                this.string_19 = match.Value;
            }
            else
            {
                string[] strArray = A_0.Split(new char[] { ' ' });
                this.string_19 = strArray[0];
            }
        }

        private Struct28 method_240(string A_0, int A_1, int A_2, int A_3)
        {
            Struct28 struct2 = new Struct28();
            string str = A_0.Substring(A_2, A_3 - A_2);
            struct2.string_0 = str;
            struct2.int_1 = A_1 + A_2;
            struct2.int_0 = (A_1 + A_2) + str.Length;
            return struct2;
        }

        private void method_241()
        {
            int num = 5;
            if (!string.IsNullOrEmpty(base.m_fieldValue))
            {
                Match match = this.OperatorExpression.Match(base.m_fieldValue);
                this.string_21 = match.Groups[0].Value;
                int index = match.Index;
                this.string_18 = base.m_fieldValue.Substring(0, index).Replace(BookmarkStart.b("截欬", num), string.Empty);
                index += this.string_21.Length;
                string input = base.m_fieldValue.Substring(index, base.m_fieldValue.Length - index);
                MatchCollection matchs = this.FieldExpression.Matches(input);
                if (matchs.Count == 3)
                {
                    int startIndex = matchs[0].Index;
                    int num4 = matchs[1].Index;
                    this.string_19 = input.Substring(startIndex, num4 - startIndex);
                    startIndex = matchs[1].Index;
                    num4 = matchs[2].Index;
                    this.string_22 = input.Substring(startIndex, num4 - startIndex);
                    startIndex = num4;
                    this.string_23 = input.Substring(startIndex, input.Length - startIndex);
                }
            }
        }

        internal void method_242()
        {
            int num = 14;
            string str = BookmarkStart.b("ᐳ", 14);
            if ((this.class621_0 != null) && (this.class621_0.method_1() != null))
            {
                this.string_18 = BookmarkStart.b("ᘳ", num) + this.class621_0.method_1() + BookmarkStart.b("ᘳ", num) + str;
            }
            if ((this.class621_1 != null) && (this.class621_1.method_1() != null))
            {
                this.string_19 = BookmarkStart.b("ᘳ", num) + this.class621_1.method_1() + BookmarkStart.b("ᘳ", num) + str;
            }
            if ((this.class621_2 != null) && (this.class621_2.method_1() != null))
            {
                this.string_22 = BookmarkStart.b("ᘳ", num) + this.class621_2.method_1() + BookmarkStart.b("ᘳ", num) + str;
            }
            if ((this.class621_3 != null) && (this.class621_3.method_1() != null))
            {
                this.string_23 = BookmarkStart.b("ᘳ", num) + this.class621_3.method_1() + BookmarkStart.b("ᘳ", num);
            }
            if (((this.string_18 != null) && (this.string_19 != null)) && ((this.string_22 != null) && (this.string_23 != null)))
            {
                base.m_fieldValue = this.string_18 + this.string_21 + str + this.string_19 + this.string_22 + this.string_23;
            }
        }

        internal void method_243()
        {
            if (this.Expression1.method_3())
            {
                this.list_4.Add(this.Expression1);
            }
            if (this.Expression2.method_3())
            {
                this.list_4.Add(this.Expression2);
            }
            if (this.TrueTextField.method_3())
            {
                this.list_4.Add(this.TrueTextField);
            }
            if (this.FalseTextField.method_3())
            {
                this.list_4.Add(this.FalseTextField);
            }
        }

        protected internal override void ParseFieldCode(string fieldCode)
        {
            this.UpdateFieldCode(fieldCode);
        }

        protected internal override void UpdateFieldCode(string fieldCode)
        {
            char[] separator = new char[] { '\\' };
            string[] fieldValues = fieldCode.Split(separator);
            base.ParseFieldFormat(fieldValues);
            base.m_fieldValue = fieldValues[0].Replace(BookmarkStart.b("縶缸", 0x11), string.Empty);
        }

        internal bool? CompartResult
        {
            get
            {
                return this.nullable_1;
            }
        }

        internal Class621 Expression1
        {
            get
            {
                if (this.class621_0 == null)
                {
                    this.method_235();
                    this.class621_0 = new Class621(this.string_18);
                }
                return this.class621_0;
            }
        }

        internal Class621 Expression2
        {
            get
            {
                if (this.class621_1 == null)
                {
                    this.method_235();
                    this.class621_1 = new Class621(this.string_19);
                }
                return this.class621_1;
            }
        }

        internal Struct28 FalseResult
        {
            get
            {
                return this.struct28_1;
            }
            set
            {
                this.struct28_1 = value;
            }
        }

        internal Class621 FalseTextField
        {
            get
            {
                if (this.class621_3 == null)
                {
                    this.method_235();
                    this.class621_3 = new Class621(this.string_23);
                }
                return this.class621_3;
            }
        }

        private Regex FieldExpression
        {
            get
            {
                int num = 0x12;
                if (this.regex_9 == null)
                {
                    this.regex_9 = new Regex(BookmarkStart.b("ᨷሹሻᐽ缿歁晃", num));
                }
                return this.regex_9;
            }
        }

        internal List<Class621> MergeFields
        {
            get
            {
                if (this.list_4 == null)
                {
                    this.list_4 = new List<Class621>();
                    this.method_243();
                }
                return this.list_4;
            }
        }

        private Regex OperatorExpression
        {
            get
            {
                int num = 10;
                if (this.regex_8 == null)
                {
                    this.regex_8 = new Regex(BookmarkStart.b("ᠯ椱࠳࠵Է朹᜻᜽", num));
                }
                return this.regex_8;
            }
        }

        internal Struct28 TrueResult
        {
            get
            {
                return this.struct28_0;
            }
            set
            {
                this.struct28_0 = value;
            }
        }

        internal Class621 TrueTextField
        {
            get
            {
                if (this.class621_2 == null)
                {
                    this.method_235();
                    this.class621_2 = new Class621(this.string_22);
                }
                return this.class621_2;
            }
        }
    }
}

