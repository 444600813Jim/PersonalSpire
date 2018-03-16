namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class TextSelection : IEnumerable
    {
        private byte[] byte_0;
        internal Class185 class185_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private List<TextRange> list_0;
        private Paragraph paragraph_0;
        private SDTInlineContent sdtinlineContent_0;
        private string string_0;
        private string[] string_1;
        private TextRange textRange_0;
        private TextRange textRange_1;
        private TextRange[] textRange_2;

        public TextSelection(Paragraph para, int startCharPos, int endCharPos)
        {
            this.list_0 = new List<TextRange>();
            this.paragraph_0 = para;
            if (this.paragraph_0.Items.Count != 0)
            {
                TextRange range;
                this.int_2 = Class191.smethod_2(this.paragraph_0, startCharPos + 1, out range);
                if (range != null)
                {
                    this.int_0 = startCharPos - range.StartPos;
                    this.textRange_0 = range;
                    this.int_3 = Class191.smethod_2(this.paragraph_0, endCharPos, out range);
                    if ((this.int_3 >= this.int_2) && (range != null))
                    {
                        this.int_1 = endCharPos - range.StartPos;
                    }
                    else
                    {
                        for (int j = para.Items.Count; j > 0; j--)
                        {
                            ParagraphBase base2 = para[j - 1];
                            if (base2 is TextRange)
                            {
                                range = base2 as TextRange;
                                break;
                            }
                        }
                        this.int_1 = (endCharPos - range.StartPos) - 1;
                    }
                    this.textRange_1 = range;
                    if (this.int_1 == range.TextLength)
                    {
                        this.int_1 = -1;
                    }
                    for (int i = this.int_2; i <= this.int_3; i++)
                    {
                        range = this.paragraph_0.Items[i] as TextRange;
                        if (range != null)
                        {
                            this.list_0.Add(range);
                        }
                    }
                }
            }
        }

        internal TextSelection(SDTInlineContent A_0, int A_1, int A_2)
        {
            this.list_0 = new List<TextRange>();
            this.sdtinlineContent_0 = A_0;
            this.paragraph_0 = A_0.OwnerParagraph;
            if (A_0.Items.Count != 0)
            {
                TextRange range;
                this.int_2 = Class191.smethod_4(A_0, A_1 + 1, out range);
                if (range != null)
                {
                    this.int_0 = A_1 - range.StartPos;
                    this.textRange_0 = range;
                    this.int_3 = Class191.smethod_4(A_0, A_2, out range);
                    if ((this.int_3 >= this.int_2) && (range != null))
                    {
                        this.int_1 = A_2 - range.StartPos;
                    }
                    else
                    {
                        for (int j = A_0.Items.Count; j > 0; j--)
                        {
                            ParagraphBase base2 = A_0[j - 1];
                            if (base2 is TextRange)
                            {
                                range = base2 as TextRange;
                                break;
                            }
                        }
                        this.int_1 = (A_2 - range.StartPos) - 1;
                    }
                    this.textRange_1 = range;
                    if (this.int_1 == range.TextLength)
                    {
                        this.int_1 = -1;
                    }
                    for (int i = this.int_2; i <= this.int_3; i++)
                    {
                        range = A_0.Items[i] as TextRange;
                        if (range != null)
                        {
                            this.list_0.Add(range);
                        }
                    }
                }
            }
        }

        public TextRange GetAsOneRange()
        {
            return this.GetAsOneRange(false);
        }

        public TextRange GetAsOneRange(bool IsCopyFormat)
        {
            if ((this.OwnerParagraph.Items.Count == 0) || ((this.OwnerSDTInlineContent != null) && (this.OwnerSDTInlineContent.Items.Count == 0)))
            {
                return null;
            }
            this.method_4();
            if ((this.int_0 > 0) || (this.int_1 != -1))
            {
                this.method_5();
            }
            if ((this.Count > 1) && IsCopyFormat)
            {
                TextRange range = this.list_0[0];
                int num = 1;
                int count = this.list_0.Count;
                while (num < count)
                {
                    TextRange range2 = this.list_0[num];
                    CharacterFormat.smethod_5(range2.CharacterFormat, range.CharacterFormat);
                    num++;
                }
            }
            if (this.Count > 1)
            {
                string selectedText = this.SelectedText;
                while (this.list_0.Count > 1)
                {
                    this.list_0[1].RemoveSelf();
                    this.list_0.RemoveAt(1);
                }
                this.textRange_0.Text = selectedText;
                this.textRange_1 = this.textRange_0;
            }
            return this.list_0[0];
        }

        public IEnumerator GetEnumerator()
        {
            string[] strArray = new string[this.Count];
            int index = 0;
            int count = this.Count;
            while (index < count)
            {
                strArray[index] = this[index];
                index++;
            }
            return strArray.GetEnumerator();
        }

        public TextRange[] GetRanges()
        {
            if (this.OwnerParagraph.Items.Count == 0)
            {
                return null;
            }
            this.method_4();
            if ((this.int_0 > 0) || (this.int_1 != -1))
            {
                this.method_5();
            }
            return this.list_0.ToArray();
        }

        internal int method_0()
        {
            if ((this.OwnerParagraph.Items.Count == 0) || ((this.OwnerSDTInlineContent != null) && (this.OwnerSDTInlineContent.Items.Count == 0)))
            {
                return 0;
            }
            this.method_4();
            if ((this.int_0 > 0) || (this.int_1 != -1))
            {
                this.method_5();
            }
            if (this.Count > 0)
            {
                while (this.list_0.Count > 0)
                {
                    this.list_0[0].RemoveSelf();
                    this.list_0.RemoveAt(0);
                }
                this.textRange_0 = null;
                this.textRange_1 = this.textRange_0;
            }
            return this.int_2;
        }

        internal void method_1()
        {
            if (this.textRange_2 == null)
            {
                TextRange[] ranges = this.GetRanges();
                if (ranges != null)
                {
                    this.textRange_2 = new TextRange[ranges.Length];
                    int index = 0;
                    int length = ranges.Length;
                    while (index < length)
                    {
                        this.textRange_2[index] = (TextRange) ranges[index].Clone();
                        index++;
                    }
                }
            }
        }

        internal void method_2(Paragraph A_0, int A_1, bool A_2, CharacterFormat A_3)
        {
            this.method_1();
            foreach (TextRange range2 in this.textRange_2)
            {
                TextRange entity = (TextRange) range2.Clone();
                if (A_2 && (A_3 != null))
                {
                    entity.CharacterFormat.ImportContainer(A_3);
                }
                A_0.Items.Insert(A_1, entity);
                A_1++;
            }
        }

        internal void method_3(SDTInlineContent A_0, int A_1, bool A_2, CharacterFormat A_3)
        {
            this.method_1();
            foreach (TextRange range2 in this.textRange_2)
            {
                TextRange entity = (TextRange) range2.Clone();
                if (A_2 && (A_3 != null))
                {
                    entity.CharacterFormat.ImportContainer(A_3);
                }
                A_0.Items.Insert(A_1, entity);
                A_1++;
            }
        }

        private void method_4()
        {
            if (this.OwnerSDTInlineContent != null)
            {
                SDTInlineContent ownerSDTInlineContent = this.OwnerSDTInlineContent;
                int count = ownerSDTInlineContent.Items.Count;
                if ((this.int_2 >= count) || (this.textRange_0 != ownerSDTInlineContent.Items[this.int_2]))
                {
                    this.int_2 = this.textRange_0.method_5();
                }
                if ((this.int_3 >= count) || (this.textRange_1 != ownerSDTInlineContent.Items[this.int_3]))
                {
                    this.int_3 = this.textRange_1.method_5();
                }
            }
            else
            {
                if ((this.textRange_0.Owner != this.OwnerParagraph) || (this.textRange_1.Owner != this.OwnerParagraph))
                {
                    throw new InvalidOperationException();
                }
                int num2 = this.OwnerParagraph.Items.Count;
                if ((this.int_2 >= num2) || (this.textRange_0 != this.OwnerParagraph.Items[this.int_2]))
                {
                    this.int_2 = this.textRange_0.method_5();
                }
                if ((this.int_3 >= num2) || (this.textRange_1 != this.OwnerParagraph.Items[this.int_3]))
                {
                    this.int_3 = this.textRange_1.method_5();
                }
            }
        }

        internal void method_5()
        {
            if (this.int_0 > 0)
            {
                TextRange entity = new TextRange(this.OwnerParagraph.Document) {
                    Text = this.textRange_0.Text.Substring(0, this.int_0)
                };
                entity.CharacterFormat.ImportContainer(this.textRange_0.CharacterFormat);
                this.textRange_0.Text = this.textRange_0.Text.Substring(this.int_0);
                if (this.OwnerSDTInlineContent != null)
                {
                    this.OwnerSDTInlineContent.Items.Insert(this.int_2, entity);
                }
                else
                {
                    this.OwnerParagraph.Items.Insert(this.int_2, entity);
                }
                this.int_2++;
                this.int_3++;
                if (this.class185_0 != null)
                {
                    this.method_6(true);
                }
                if ((this.Count == 1) && (this.int_1 >= 0))
                {
                    this.int_1 -= this.int_0;
                }
                this.int_0 = 0;
            }
            if (this.int_1 > 0)
            {
                TextRange range2 = new TextRange(this.OwnerParagraph.Document) {
                    Text = this.textRange_1.Text.Substring(this.int_1)
                };
                range2.CharacterFormat.ImportContainer(this.textRange_1.CharacterFormat);
                this.textRange_1.Text = this.textRange_1.Text.Substring(0, this.int_1);
                if (this.OwnerSDTInlineContent != null)
                {
                    this.OwnerSDTInlineContent.Items.Insert(this.int_3 + 1, range2);
                }
                else
                {
                    this.OwnerParagraph.Items.Insert(this.int_3 + 1, range2);
                }
                if (this.class185_0 != null)
                {
                    this.method_6(false);
                }
                this.int_1 = -1;
            }
        }

        private void method_6(bool A_0)
        {
            foreach (TextSelection selection in this.class185_0)
            {
                if (selection != this)
                {
                    TextRange range = A_0 ? this.textRange_0 : this.textRange_1;
                    int num = A_0 ? this.int_0 : this.int_1;
                    if (selection.textRange_0 == range)
                    {
                        if (!A_0)
                        {
                            selection.textRange_0 = (TextRange) this.textRange_1.NextSibling;
                            selection.list_0[0] = selection.textRange_0;
                        }
                        selection.int_0 -= num;
                    }
                    if (selection.textRange_1 == range)
                    {
                        if (!A_0)
                        {
                            selection.textRange_1 = (TextRange) this.textRange_1.NextSibling;
                            selection.list_0[selection.list_0.Count - 1] = selection.textRange_1;
                        }
                        if (selection.int_1 >= 0)
                        {
                            selection.int_1 -= num;
                        }
                    }
                }
            }
        }

        public int Count
        {
            get
            {
                return this.list_0.Count;
            }
        }

        internal TextRange EndTextRange
        {
            get
            {
                return this.textRange_1;
            }
        }

        public string this[int index]
        {
            get
            {
                TextRange range = this.list_0[index];
                string text = range.Text;
                if ((index == 0) && (this.int_0 > 0))
                {
                    text = text.Substring(this.int_0);
                }
                if ((index != (this.list_0.Count - 1)) || (this.int_1 == -1))
                {
                    return text;
                }
                if (this.list_0.Count == 1)
                {
                    return text.Substring(0, this.int_1 - this.int_0);
                }
                return text.Substring(0, this.int_1);
            }
            set
            {
                TextRange range = this.list_0[index];
                string str = value;
                if ((index == 0) && (this.int_0 > 0))
                {
                    str = range.Text.Substring(0, this.int_0) + str;
                }
                if ((index == this.list_0.Count) && (this.int_1 != -1))
                {
                    str = str + range.Text.Substring(this.int_1);
                }
                range.Text = str;
            }
        }

        internal Paragraph OwnerParagraph
        {
            get
            {
                if (this.textRange_0 != null)
                {
                    if (this.textRange_0.Owner is SDTInlineContent)
                    {
                        this.paragraph_0 = (this.textRange_0.Owner as SDTInlineContent).OwnerParagraph;
                    }
                    else
                    {
                        this.paragraph_0 = this.textRange_0.OwnerParagraph;
                    }
                }
                return this.paragraph_0;
            }
        }

        internal SDTInlineContent OwnerSDTInlineContent
        {
            get
            {
                return this.sdtinlineContent_0;
            }
        }

        public string SelectedText
        {
            get
            {
                int num = 10;
                if ((this.textRange_0 == null) || (this.textRange_1 == null))
                {
                    return string.Empty;
                }
                int startPos = this.textRange_0.StartPos;
                if (this.int_0 != 0)
                {
                    startPos += this.int_0;
                }
                int length = (this.int_1 >= 0) ? ((this.textRange_1.StartPos + this.int_1) - startPos) : ((this.textRange_1.StartPos + this.textRange_1.TextLength) - startPos);
                if (length < 0)
                {
                    throw new Exception(BookmarkStart.b("搯圱䰳䈵ᠷ䤹夻刽┿⅁ぃ⽅❇⑉汋㥍ㅏ⅑瑓㭕㝗㹙㕛㡝य़ݡc䡥䡧㹩ѫݭͯ剱ᝳ᥵൷ᙹ᡻幽ꒃ꺍晴ﶓ歹ﶗ몙쒟쮡슣쾥쮧쮩\ud8ab\uc7ad\udfaf\udcb1钳\ud9b5\udeb7骹쾻톽떿냁ꟃꏅ껉ꏋ귍ꗏ뿑뇓룕곗", num));
                }
                string str = (this.OwnerSDTInlineContent != null) ? this.OwnerSDTInlineContent.Text : this.OwnerParagraph.Text;
                return str.Substring(startPos, length);
            }
        }

        internal TextRange StartTextRange
        {
            get
            {
                return this.textRange_0;
            }
        }
    }
}

