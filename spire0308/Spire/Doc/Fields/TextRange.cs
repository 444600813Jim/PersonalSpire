namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class TextRange : ParagraphBase, Interface21, ITextRange
    {
        private bool bool_10;
        private bool bool_11;
        private bool bool_12;
        private bool bool_13;
        private bool bool_14;
        private bool bool_15;
        private bool bool_16;
        [CompilerGenerated]
        private bool bool_17;
        [CompilerGenerated]
        private bool bool_18;
        [CompilerGenerated]
        private bool bool_19;
        [CompilerGenerated]
        private bool bool_20;
        [CompilerGenerated]
        private bool bool_21;
        private bool bool_7;
        private bool bool_8;
        internal bool bool_9;
        private Spire.Doc.CharacterCategory characterCategory_0;
        private Dictionary<string, TextRange> dictionary_0;
        [CompilerGenerated]
        private DocumentObject documentObject_0;
        private int int_4;
        private List<Class217> list_0;
        private List<Class216> list_1;
        private bool? nullable_0;
        [CompilerGenerated]
        private Paragraph paragraph_0;
        private string string_8;
        internal string string_9;
        internal TextRange textRange_0;

        public TextRange(IDocument doc) : base((Document) doc)
        {
            this.string_8 = string.Empty;
            this.string_9 = string.Empty;
            this.dictionary_0 = new Dictionary<string, TextRange>();
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            base.m_charFormat.method_0(this);
        }

        internal TextRange(IDocument A_0, string A_1, Spire.Doc.Formatting.CharacterFormat A_2) : this(A_0)
        {
            base.m_charFormat = A_2;
            base.m_charFormat.method_0(this);
            this.Text = A_1;
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_16(this));
        }

        internal override void Attach(Paragraph paragraph, int itemPos)
        {
            this.int_4 = 0;
            base.Attach(paragraph, itemPos);
            this.Text = this.string_8;
        }

        internal override void Attach(SDTInlineContent owner, int itemPos)
        {
            this.int_4 = 0;
            base.Attach(owner, itemPos);
            this.Text = this.string_8;
        }

        protected override object CloneImpl()
        {
            TextRange range = (TextRange) base.CloneImpl();
            range.string_8 = this.Text;
            return range;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            base.CloneRelationsTo(doc, nextOwner);
        }

        internal override void Close()
        {
            base.Close();
            this.string_8 = string.Empty;
            if (this.list_0 != null)
            {
                this.list_0.Clear();
                this.list_0 = null;
            }
            this.string_9 = string.Empty;
            if (this.dictionary_0 != null)
            {
                foreach (KeyValuePair<string, TextRange> pair in this.dictionary_0)
                {
                    if (pair.Value != null)
                    {
                        pair.Value.Close();
                    }
                }
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
        }

        protected override void CreateLayoutInfo()
        {
            int num = 1;
            this.method_34();
            base.interface23_0 = (this.Text == BookmarkStart.b("⸦", 1)) ? new Class207(this) : new Class205(ChildrenLayoutDirection.Horizontal);
            (base.interface23_0 as Class205).method_11().AddRange(this.CompressedPunctuations);
            if ((base.PreviousSibling != null) && (base.PreviousSibling.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.FieldMark))
            {
                Field previousSibling = base.PreviousSibling.PreviousSibling as Field;
                if ((previousSibling != null) && ((previousSibling.Type == FieldType.FieldPage) || ((previousSibling.Type == FieldType.FieldHyperlink) && ((new Hyperlink(previousSibling).BookmarkName == null) || !new Hyperlink(previousSibling).BookmarkName.StartsWith(BookmarkStart.b("砦紨䐪丬", num))))))
                {
                    base.interface23_0.imethod_5(true);
                }
            }
            if (base.OwnerParagraph == null)
            {
                Paragraph ownerBase = null;
                if (base.Owner is SDTInlineContent)
                {
                    ownerBase = base.method_28();
                }
                else if ((this.CharacterFormat.BaseFormat != null) && (this.CharacterFormat.BaseFormat.OwnerBase != null))
                {
                    ownerBase = this.CharacterFormat.BaseFormat.OwnerBase as Paragraph;
                }
                else
                {
                    base.interface23_0.imethod_5(true);
                }
                if (((ownerBase != null) && ownerBase.IsInCell) && ((ownerBase.OwnerTextBody as TableCell).CellFormat.TextDirection != TextDirection.TopToBottom))
                {
                    base.interface23_0.imethod_31(true);
                }
                if ((ownerBase != null) && ownerBase.SectionEndMark)
                {
                    base.interface23_0.imethod_5(true);
                }
                if ((((ownerBase != null) && (ownerBase.Items.IndexOf(this) < 0)) && ((ownerBase.LastItem is Break) && ((ownerBase.LastItem as Break).BreakType == BreakType.PageBreak))) && ownerBase.Document.Settings.method_5().method_121())
                {
                    base.interface23_0.imethod_11(true);
                }
            }
            if (((base.OwnerParagraph != null) && base.OwnerParagraph.IsInCell) && ((base.OwnerParagraph.OwnerTextBody as TableCell).CellFormat.TextDirection != TextDirection.TopToBottom))
            {
                base.interface23_0.imethod_31(true);
            }
            if ((((((base.OwnerParagraph != null) && (base.OwnerParagraph.ChildObjects.Count > 1)) && ((this.Text != BookmarkStart.b("⸦", num)) && (this.Text != string.Empty))) && ((this.Text.Trim().Length == 0) && (!base.OwnerParagraph.method_43() || base.OwnerParagraph.method_44()))) && ((base.NextSibling == null) || ((((base.NextSibling != null) && (base.NextSibling is TextRange)) && (((base.NextSibling as TextRange).Text != string.Empty) && ((base.NextSibling as TextRange).Text.Trim().Length == 0))) && (base.OwnerParagraph.ChildObjects.IndexOf(base.NextSibling) == (base.OwnerParagraph.ChildObjects.Count - 1))))) && (base.NextSibling == null))
            {
                base.interface23_0.imethod_5(true);
            }
        }

        internal override void Detach()
        {
            base.Detach();
            if (base.OwnerParagraph != null)
            {
                this.string_8 = this.Text;
                base.OwnerParagraph.method_63(this, string.Empty);
            }
            else if (base.Owner is SDTInlineContent)
            {
                this.string_8 = this.Text;
                (base.Owner as SDTInlineContent).method_22(this, string.Empty);
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䠪䔬丮䌰刲嘴䌶尸䤺ြ夾⹀ㅂ⡄♆㵈", 5), base.m_charFormat);
        }

        internal float method_30()
        {
            return this.method_31(true);
        }

        internal float method_31(bool A_0)
        {
            float num = 0f;
            if (A_0)
            {
                for (int j = 0; j < (base.interface23_0 as Class205).method_11().Count; j++)
                {
                    num += (base.interface23_0 as Class205).method_11()[j].method_2();
                }
                return num;
            }
            for (int i = 0; i < this.CompressedPunctuations.Count; i++)
            {
                num += this.CompressedPunctuations[i].method_2();
            }
            return num;
        }

        internal List<Class216> method_32()
        {
            List<Class216> list = new List<Class216>();
            if (this.CharacterCategory == Spire.Doc.CharacterCategory.FarEast)
            {
                int num = 0;
                int length = this.Text.Length;
                while (num < length)
                {
                    char ch = this.Text[num];
                    if ((Class57.smethod_6(ch) != Spire.Doc.CharacterCategory.Ascii) && Class203.smethod_1(ch))
                    {
                        Class216 item = new Class216(num, ch, false);
                        item.method_9(this);
                        list.Add(item);
                    }
                    num++;
                }
            }
            return list;
        }

        internal void method_33(Class196 A_0, bool A_1)
        {
            if (A_1)
            {
                foreach (Class216 class3 in (base.interface23_0 as Class205).method_11())
                {
                    class3.method_3(A_0.method_322(class3.method_4().ToString(), this.CharacterFormat).Width);
                }
            }
            else
            {
                foreach (Class216 class2 in this.CompressedPunctuations)
                {
                    class2.method_3(A_0.method_322(class2.method_4().ToString(), this.CharacterFormat).Width);
                }
            }
        }

        internal void method_34()
        {
            this.method_35();
            this.method_36();
            this.method_37();
        }

        private void method_35()
        {
            string text = string.Empty;
            if ((this.Text != Class816.string_9) && this.Text.Contains(Class816.string_9))
            {
                ParagraphItemCollection items = (base.Owner is SDTInlineContent) ? (base.Owner as SDTInlineContent).Items : ((base.OwnerParagraph != null) ? base.OwnerParagraph.Items : null);
                if (items != null)
                {
                    int index = this.Text.IndexOf(Class816.string_9);
                    text = this.Text;
                    int num = items.IndexOf(this);
                    string str2 = text.Substring(index + 1);
                    TextRange entity = base.Clone() as TextRange;
                    if (index > 0)
                    {
                        entity.Text = text.Substring(index);
                        this.Text = text.Substring(0, index);
                    }
                    else if (str2 != string.Empty)
                    {
                        entity.Text = str2;
                        this.Text = Class816.string_9;
                    }
                    items.Insert(num + 1, entity);
                }
            }
        }

        private void method_36()
        {
            if (!this.bool_8)
            {
                string str = string.Empty;
                if (this.Text.Replace(Class816.string_4, Class816.string_27).Replace('\n', '\r').Contains(Class816.string_27))
                {
                    ParagraphItemCollection items = (base.Owner is SDTInlineContent) ? (base.Owner as SDTInlineContent).Items : ((base.OwnerParagraph != null) ? base.OwnerParagraph.Items : null);
                    if (items != null)
                    {
                        TextRange entity = (this.textRange_0 != null) ? this.textRange_0 : this;
                        str = entity.Text.Replace(Class816.string_4, Class816.string_27).Replace('\n', '\r');
                        int index = str.IndexOf(Class816.string_27);
                        string str2 = str.Substring(index + 1);
                        TextRange range2 = entity.Clone() as TextRange;
                        if ((this.textRange_0 != null) && (this.int_4 > 0))
                        {
                            this.int_4--;
                        }
                        if (index > 0)
                        {
                            range2.Text = str.Substring(index + 1);
                            entity.Text = str.Substring(0, index);
                        }
                        else if (str2 != string.Empty)
                        {
                            range2.Text = str2;
                            entity.Text = string.Empty;
                        }
                        if (str == Class816.string_27)
                        {
                            entity.Text = string.Empty;
                            range2.Text = string.Empty;
                        }
                        Paragraph paragraph2 = (base.Owner is SDTInlineContent) ? (base.Owner as SDTInlineContent).OwnerParagraph : base.OwnerParagraph;
                        Paragraph paragraph = paragraph2.Clone() as Paragraph;
                        paragraph.method_57();
                        int num7 = paragraph2.method_5();
                        paragraph2.OwnerTextBody.Items.Insert(num7 + 1, paragraph);
                        (paragraph2.interface23_0 as Class213).method_38(false);
                        paragraph.Items.Add(range2);
                        int num2 = items.IndexOf(entity);
                        if (num2 > -1)
                        {
                            int num = (base.Document != null) ? base.Document.ClonedFields.Count : 0;
                            paragraph.method_67(items, num2 + 1);
                            int num5 = (base.Document != null) ? base.Document.ClonedFields.Count : 0;
                            int num4 = 0;
                            int num6 = num5 - num;
                            while (num4 < num6)
                            {
                                base.Document.ClonedFields.Pop();
                                num4++;
                            }
                            if (base.IsAddForIfField)
                            {
                                paragraph.IsAddForIfField = true;
                                base.m_doc.LayoutVariables.method_1().Add(paragraph);
                            }
                        }
                    }
                }
            }
        }

        private void method_37()
        {
            string text = this.Text;
            if (!string.IsNullOrEmpty(text) && text.Contains(Class816.string_6))
            {
                int index = text.IndexOf(Class816.string_6);
                string str2 = text.Substring(index + 1);
                TextRange entity = base.Clone() as TextRange;
                if (index > 0)
                {
                    entity.Text = text.Substring(index + 1);
                    this.Text = text.Substring(0, index);
                }
                else if (str2 != string.Empty)
                {
                    entity.Text = str2;
                    this.Text = string.Empty;
                }
                ParagraphItemCollection items = (base.Owner is SDTInlineContent) ? (base.Owner as SDTInlineContent).Items : ((base.OwnerParagraph != null) ? base.OwnerParagraph.Items : null);
                if (items != null)
                {
                    int num = base.method_5();
                    Break @break = new Break(base.Document, BreakType.LineBreak);
                    items.Insert(++num, @break);
                    if (index < (text.Length - 1))
                    {
                        items.Insert(++num, entity);
                    }
                }
            }
        }

        internal Spire.Doc.CharacterCategory method_38(string A_0)
        {
            if (!string.IsNullOrEmpty(A_0))
            {
                return Class57.smethod_9(this.Text);
            }
            return Spire.Doc.CharacterCategory.Ascii;
        }

        internal void method_39()
        {
            this.characterCategory_0 = this.method_38(this.Text);
        }

        private void method_40(string A_0)
        {
            if (!string.IsNullOrEmpty(A_0))
            {
                if (this.list_0 != null)
                {
                    this.list_0.Clear();
                    this.list_0 = null;
                }
                this.list_0 = new List<Class217>();
                this.bool_10 = Class57.smethod_6(A_0[0]) == Spire.Doc.CharacterCategory.FarEast;
                this.bool_11 = Class57.smethod_6(A_0[A_0.Length - 1]) == Spire.Doc.CharacterCategory.FarEast;
                Class217 item = new Class217();
                bool flag = false;
                bool flag2 = false;
                int num = 0;
                int length = A_0.Length;
                while (num < length)
                {
                    flag = Class57.smethod_10(A_0[num]);
                    if ((num + 1) >= length)
                    {
                        flag2 = false;
                    }
                    else
                    {
                        flag2 = Class57.smethod_10(A_0[num + 1]);
                    }
                    if (!item.method_2().HasValue && flag)
                    {
                        item.method_3(new int?(num));
                        item.method_7(num == 0);
                        item.method_11(Class57.smethod_11(A_0[num]));
                    }
                    if (item.method_2().HasValue && !flag2)
                    {
                        item.method_1(new int?(num));
                        item.method_5((num + 1) == length);
                        item.method_9(Class57.smethod_11(A_0[num]));
                    }
                    if (item.method_2().HasValue && item.method_0().HasValue)
                    {
                        this.LetterOrDigitPosition.Add(item);
                        item = new Class217();
                    }
                    num++;
                }
            }
        }

        internal float method_41(Class196 A_0, float A_1)
        {
            float num = 0f;
            if (base.Owner != null)
            {
                DocumentObject owner = base.Owner;
                while (!(owner is Section))
                {
                    if (((owner is Table) || (owner is Footnote)) || (owner.Owner == null))
                    {
                        break;
                    }
                    owner = owner.Owner;
                }
                if (owner is Section)
                {
                    Paragraph ownerParagraph = base.OwnerParagraph;
                    if (base.Owner is SDTInlineContent)
                    {
                        ownerParagraph = (base.Owner as SDTInlineContent).OwnerParagraph;
                    }
                    if (ownerParagraph.Format.IsFrame && (ownerParagraph.Format.FrameWidthRule == FrameSizeRule.Exact))
                    {
                        A_1 = ownerParagraph.Format.FrameWidthEx;
                    }
                    Class210 class2 = ((Interface1) ownerParagraph).imethod_0() as Class210;
                    return (A_1 - (((float) (class2.Interface22.imethod_1().method_0() + class2.Interface22.imethod_1().method_8())) + class2.method_51()));
                }
                if (owner is Table)
                {
                    return A_0.method_394(this);
                }
                if (owner is Footnote)
                {
                    num = A_1;
                }
            }
            return num;
        }

        internal void method_42(ParagraphItemCollection A_0)
        {
            if ((((this.CharacterCategory == Spire.Doc.CharacterCategory.FarEast) && (this.LetterOrDigitPosition.Count > 0)) && (((base.interface23_0 != null) && !base.interface23_0.imethod_4()) || (base.interface23_0 == null))) && (!(base.PreviousSibling is FieldMark) || !(base.NextSibling is FieldMark)))
            {
                string text = this.Text;
                int startPos = this.StartPos;
                int startIndex = 0;
                int num3 = 0;
                int count = this.LetterOrDigitPosition.Count;
                while (num3 < count)
                {
                    Class217 class2 = this.LetterOrDigitPosition[num3];
                    Class217 class3 = null;
                    if (num3 < (count - 1))
                    {
                        class3 = this.LetterOrDigitPosition[num3 + 1];
                    }
                    if ((num3 == 0) && !class2.method_6())
                    {
                        string str3 = text.Substring(startIndex, class2.method_2().Value);
                        this.method_43(A_0, str3, startPos);
                        startPos += str3.Length;
                        startIndex += str3.Length;
                        str3 = text.Substring(startIndex, (class2.method_0().Value - class2.method_2().Value) + 1);
                        this.method_43(A_0, str3, startPos);
                        startPos += str3.Length;
                        startIndex += str3.Length;
                        if (class3 == null)
                        {
                            str3 = text.Substring(startIndex);
                        }
                        else if ((class3.method_2().Value - class2.method_0().Value) > 1)
                        {
                            str3 = text.Substring(startIndex, (class3.method_2().Value - class2.method_0().Value) - 1);
                        }
                        if (str3.Length > 0)
                        {
                            this.method_43(A_0, str3, startPos);
                            startPos += str3.Length;
                            startIndex += str3.Length;
                        }
                    }
                    else
                    {
                        string str = text.Substring(startIndex, (class2.method_0().Value - class2.method_2().Value) + 1);
                        this.method_43(A_0, str, startPos);
                        startPos += str.Length;
                        startIndex += str.Length;
                        if (class3 == null)
                        {
                            str = text.Substring(startIndex);
                        }
                        else if ((class3.method_2().Value - class2.method_0().Value) > 1)
                        {
                            str = text.Substring(startIndex, (class3.method_2().Value - class2.method_0().Value) - 1);
                        }
                        if (str.Length > 0)
                        {
                            this.method_43(A_0, str, startPos);
                            startPos += str.Length;
                            startIndex += str.Length;
                        }
                    }
                    num3++;
                }
            }
            else
            {
                A_0.InnerList.Add(this);
            }
        }

        private void method_43(ParagraphItemCollection A_0, string A_1, int A_2)
        {
            int num = 15;
            if (this.dictionary_0 == null)
            {
                this.dictionary_0 = new Dictionary<string, TextRange>();
            }
            string key = A_1 + BookmarkStart.b("樴", num) + A_2;
            TextRange range = null;
            if (this.dictionary_0.ContainsKey(key))
            {
                range = this.dictionary_0[key];
            }
            else
            {
                range = new TextRange(base.Document);
                range.CharacterFormat.ApplyBase(this.CharacterFormat);
                range.method_0(base.Owner);
                range.characterCategory_0 = this.CharacterCategory;
                range.StartPos = A_2;
                range.int_4 = A_1.Length;
                range.string_9 = A_1;
                range.string_8 = A_1;
                range.textRange_0 = this;
                if (!string.IsNullOrEmpty(A_1))
                {
                    range.bool_12 = Class57.smethod_11(A_1[0]);
                    range.bool_13 = Class57.smethod_11(A_1[A_1.Length - 1]);
                    range.bool_14 = Class57.smethod_12(A_1[0]);
                    range.bool_15 = Class57.smethod_12(A_1[A_1.Length - 1]);
                    range.bool_10 = Class57.smethod_6(A_1[0]) == Spire.Doc.CharacterCategory.FarEast;
                    range.bool_11 = Class57.smethod_6(A_1[A_1.Length - 1]) == Spire.Doc.CharacterCategory.FarEast;
                }
                this.dictionary_0.Add(key, range);
            }
            A_0.InnerList.Add(range);
        }

        internal void method_44(int A_0, int A_1)
        {
            int num = 8;
            if ((this.dictionary_0 != null) && (this.dictionary_0.Count > 0))
            {
                Dictionary<string, TextRange> dictionary = new Dictionary<string, TextRange>();
                foreach (KeyValuePair<string, TextRange> pair in this.dictionary_0)
                {
                    string key = pair.Key;
                    TextRange range = pair.Value;
                    range.StartPos += A_1;
                    string[] strArray = key.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                    string str2 = strArray[0] + BookmarkStart.b("焭", num) + (Convert.ToInt32(strArray[1]) + A_1);
                    dictionary.Add(str2, range);
                }
                this.dictionary_0 = dictionary;
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            if (!(reader.TagName == BookmarkStart.b("䄴制䄸伺", 15)))
            {
                return false;
            }
            if (base.OwnerParagraph != null)
            {
                this.StartPos = base.OwnerParagraph.Text.Length;
            }
            this.Text = reader.ReadChildStringContent();
            if (this.Text == "")
            {
                reader.InnerReader.Read();
            }
            this.bool_7 = true;
            return true;
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            if (!ltWidget.method_73().imethod_0().imethod_10())
            {
                string str = (ltWidget.method_64() != null) ? ltWidget.method_64() : this.Text;
                ((Interface21) this).imethod_7(dc, ltWidget, str);
            }
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            int num = 0;
            if ((this.Text == Class818.string_0) && (base.OwnerParagraph.OwnerTextBody.Owner is Footnote))
            {
                this.Text = ((base.OwnerParagraph.OwnerTextBody.Owner as Footnote).interface23_0 as Class209).method_15();
            }
            string text = this.Text;
            if (!string.IsNullOrEmpty(text) && (text != BookmarkStart.b("⼥", num)))
            {
                if (((this.OwnerEmptyParagraph != null) && (base.OwnerParagraph == null)) || this.IsAddForEmptyPara)
                {
                    SizeF ef3 = dc.method_323(this, BookmarkStart.b("ࠥ", num));
                    ef3.Width = 0.000145f;
                    return ef3;
                }
                if (((base.OwnerParagraph != null) && string.IsNullOrEmpty(text.Trim())) && ((this == base.OwnerParagraph.Items.LastItem) && (base.OwnerParagraph.Format.HorizontalAlignment != HorizontalAlignment.Left)))
                {
                    text = text.TrimEnd(new char[0]);
                }
                if ((base.Owner == null) && (this.CharacterFormat.Font == null))
                {
                    return new SizeF();
                }
                return dc.method_323(this, text);
            }
            SizeF ef2 = dc.method_323(this, BookmarkStart.b("ࠥ", num));
            ef2.Width = 0f;
            return ef2;
        }

        Interface19[] Interface19.SplitBySize(Class196 dc, SizeF offset, float clientWidth, float clientActiveAreaWidth)
        {
            return Class542.smethod_0(dc, (double) offset.Width, this, null, clientWidth, clientActiveAreaWidth, true);
        }

        void Interface21.Draw(Class196 dc, Class375 ltWidget, string text)
        {
            dc.method_199(this, ltWidget, text);
            this.DrawImpl(dc, ltWidget);
        }

        double Interface21.GetTextAscent(Class196 dc)
        {
            return (double) dc.method_329(this);
        }

        Struct1 Interface21.GetTextAscentDescent(Class196 dc)
        {
            return dc.method_335(this);
        }

        Struct1 Interface21.GetTextAscentDescent(Class196 dc, bool isIgnoreSubsuperScript)
        {
            return dc.method_334(this, isIgnoreSubsuperScript);
        }

        int Interface21.OffsetToIndex(Class196 dc, double offset, string text, string textSplit, float clientWidth, float clientActiveAreaWidth, bool bIsFirstSplit)
        {
            int num = 3;
            float num2 = this.method_41(dc, clientWidth);
            Class210 class2 = base.interface23_0 as Class210;
            bool flag2 = (class2 != null) ? class2.Interface23.imethod_26() : true;
            bool flag = (base.OwnerParagraph != null) && base.OwnerParagraph.method_46();
            flag = (num2 <= 0f) || flag;
            int num4 = dc.method_401(text, this, textSplit, offset, !flag2, flag, num2, clientActiveAreaWidth);
            float width = dc.method_323(this, BookmarkStart.b("न", num)).Width;
            if ((num4 > 0) && (!flag || (num2 >= width)))
            {
                int num6 = Class203.smethod_4(textSplit, num4);
                if (num6 < 0)
                {
                    if ((num4 + num6) <= 0)
                    {
                        string str = text.Substring(0, num4 + Math.Abs(num6));
                        if (dc.method_323(this, str).Width < num2)
                        {
                            num4 += num6;
                        }
                    }
                }
                else
                {
                    num4 += num6;
                }
            }
            if ((num2 > width) && (num4 < textSplit.Length))
            {
                int num7 = num4;
                if (((offset != num2) && (num4 < 1)) || flag)
                {
                    num7++;
                }
                if (num7 > -1)
                {
                    for (int i = num7; i < textSplit.Length; i++)
                    {
                        if ((textSplit[i] != ' ') && (textSplit[i] != '\x00a0'))
                        {
                            break;
                        }
                        num4++;
                    }
                }
            }
            if (((num4 <= 0) && (Class59.smethod_5((double) num2, offset, 0.005) == 0)) && !flag)
            {
                num4 = -2147483648;
            }
            if (((num4 <= 0) && (Class59.smethod_5((double) num2, 0.0, 0.005) <= 0)) && flag)
            {
                num4 = -2147483648;
            }
            return num4;
        }

        SizeF Interface20.Measure(Class196 dc, string text)
        {
            return dc.method_323(this, text);
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            base.WriteXmlContent(writer);
            writer.WriteChildStringElement(BookmarkStart.b("䘱儳丵䰷", 12), this.Text);
        }

        internal Spire.Doc.CharacterCategory CharacterCategory
        {
            get
            {
                return this.characterCategory_0;
            }
        }

        public override Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
            internal set
            {
                base.m_charFormat = value;
            }
        }

        internal List<Class216> CompressedPunctuations
        {
            get
            {
                if ((this.list_1 == null) || (this.list_1.Count <= 0))
                {
                    this.list_1 = this.method_32();
                }
                return this.list_1;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.TextRange;
            }
        }

        internal override int EndPos
        {
            get
            {
                return (base.EndPos + this.int_4);
            }
        }

        internal DocumentObject FieldOwner
        {
            [CompilerGenerated]
            get
            {
                return this.documentObject_0;
            }
            [CompilerGenerated]
            set
            {
                this.documentObject_0 = value;
            }
        }

        internal bool HasBeenSplitted
        {
            [CompilerGenerated]
            get
            {
                return this.bool_21;
            }
            [CompilerGenerated]
            set
            {
                this.bool_21 = value;
            }
        }

        internal bool IsAddForBreak
        {
            [CompilerGenerated]
            get
            {
                return this.bool_18;
            }
            [CompilerGenerated]
            set
            {
                this.bool_18 = value;
            }
        }

        internal bool IsAddForEmptyPara
        {
            [CompilerGenerated]
            get
            {
                return this.bool_17;
            }
            [CompilerGenerated]
            set
            {
                this.bool_17 = value;
            }
        }

        internal bool IsBalanceWidthCharOfSingleByteAndDoubleByte
        {
            get
            {
                return base.Document.Settings.method_5().method_0(CompatibilityOptions.DontBlnSbDbWid);
            }
        }

        internal bool IsDigitOfEndPos
        {
            get
            {
                return this.bool_15;
            }
        }

        internal bool IsDigitOfStartPos
        {
            get
            {
                return this.bool_14;
            }
        }

        internal bool IsFarEastLetterOfEndPosition
        {
            get
            {
                return this.bool_11;
            }
        }

        internal bool IsFarEastLetterOfStartPosition
        {
            get
            {
                return this.bool_10;
            }
        }

        internal bool IsFieldToTextRange
        {
            [CompilerGenerated]
            get
            {
                return this.bool_19;
            }
            [CompilerGenerated]
            set
            {
                this.bool_19 = value;
            }
        }

        internal bool IsIfFieldResultFirstItem
        {
            [CompilerGenerated]
            get
            {
                return this.bool_20;
            }
            [CompilerGenerated]
            set
            {
                this.bool_20 = value;
            }
        }

        internal bool IsLetterOfEndPos
        {
            get
            {
                return this.bool_13;
            }
        }

        internal bool IsLetterOfStartPos
        {
            get
            {
                return this.bool_12;
            }
        }

        internal bool IsNotSplitByParagraphBreak
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

        internal bool IsPTab
        {
            get
            {
                return this.bool_16;
            }
            set
            {
                this.bool_16 = value;
            }
        }

        private bool IsSplitable
        {
            get
            {
                if (!this.nullable_0.HasValue)
                {
                    string text = this.Text;
                    if ((text == null) || (text.Length == 0))
                    {
                        this.nullable_0 = true;
                    }
                    foreach (char ch in text)
                    {
                        if (Class360.smethod_1(ch))
                        {
                            this.nullable_0 = true;
                            break;
                        }
                    }
                    if (!this.nullable_0.HasValue)
                    {
                        this.nullable_0 = false;
                    }
                }
                return this.nullable_0.Value;
            }
        }

        internal bool IsTextToSplitAssignedInSecondLayouting
        {
            get
            {
                return this.bool_9;
            }
            set
            {
                if (!Class195.bool_10)
                {
                    this.bool_9 = value;
                }
            }
        }

        internal List<Class217> LetterOrDigitPosition
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<Class217>();
                }
                return this.list_0;
            }
        }

        internal Paragraph OwnerEmptyParagraph
        {
            [CompilerGenerated]
            get
            {
                return this.paragraph_0;
            }
            [CompilerGenerated]
            set
            {
                this.paragraph_0 = value;
            }
        }

        internal bool SafeText
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                this.bool_7 = value;
            }
        }

        internal int StartPos
        {
            get
            {
                return base.StartPos;
            }
            set
            {
                base.StartPos = value;
            }
        }

        public virtual string Text
        {
            get
            {
                if (!base.ItemDetached && (base.OwnerParagraph != null))
                {
                    this.string_8 = base.OwnerParagraph.Text.Substring(this.StartPos, this.int_4);
                }
                else if (!base.ItemDetached && (base.Owner is SDTInlineContent))
                {
                    this.string_8 = (base.Owner as SDTInlineContent).Text.Substring(this.StartPos, this.int_4);
                }
                if ((this.TextToSplit == string.Empty) || (!Class195.bool_10 && !this.IsTextToSplitAssignedInSecondLayouting))
                {
                    this.TextToSplit = this.string_8;
                    this.IsTextToSplitAssignedInSecondLayouting = true;
                }
                return this.string_8;
            }
            set
            {
                this.nullable_0 = null;
                if (((!base.ItemDetached && (base.Owner is SDTInlineContent)) && ((base.OwnerParagraph == null) && (value != null))) && (value != this.Text))
                {
                    (base.Owner as SDTInlineContent).method_22(this, value);
                    this.int_4 = value.Length;
                    this.characterCategory_0 = this.method_38(value);
                }
                else if (!base.ItemDetached && (base.OwnerParagraph != null))
                {
                    if ((value != null) && (value != this.Text))
                    {
                        base.OwnerParagraph.method_63(this, value);
                        this.int_4 = value.Length;
                        this.characterCategory_0 = this.method_38(value);
                    }
                }
                else
                {
                    this.string_8 = value;
                    this.characterCategory_0 = this.method_38(value);
                }
                this.TextToSplit = this.string_8;
                if (!string.IsNullOrEmpty(value))
                {
                    this.dictionary_0.Clear();
                    this.bool_12 = Class57.smethod_11(value[0]);
                    this.bool_13 = Class57.smethod_11(value[value.Length - 1]);
                    this.bool_14 = Class57.smethod_12(value[0]);
                    this.bool_15 = Class57.smethod_12(value[value.Length - 1]);
                    this.list_1 = null;
                    if (this.characterCategory_0 == Spire.Doc.CharacterCategory.FarEast)
                    {
                        this.method_40(value);
                    }
                }
                this.bool_7 = base.Document.bool_3;
            }
        }

        internal int TextLength
        {
            get
            {
                if (!base.ItemDetached)
                {
                    return this.int_4;
                }
                return this.string_8.Length;
            }
            set
            {
                this.int_4 = value;
            }
        }

        internal string TextToSplit
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

        internal class Class207 : Class206
        {
            public Class207(TextRange A_0) : base(ChildrenLayoutDirection.Horizontal)
            {
                float left = 0f;
                if (A_0.Owner.Owner.Owner is Section)
                {
                    left = (A_0.Owner.Owner.Owner as Section).PageSetup.Margins.Left;
                }
                else
                {
                    left = A_0.Document.LastSection.PageSetup.Margins.Left;
                }
                left = (left != -0.05f) ? left : 0f;
                base.double_1 = A_0.Owner.Document.LastSection.PageSetup.DefaultTabWidth;
                Paragraph paragraph = A_0.method_28();
                if (paragraph.IsInCell)
                {
                    left = (((Interface1) paragraph.OwnerTextBody).imethod_0() as Class211).method_115();
                }
                base.double_2 = left;
                base.method_27(paragraph, left, this);
            }
        }

        internal class Class217
        {
            [CompilerGenerated]
            private bool bool_0;
            [CompilerGenerated]
            private bool bool_1;
            [CompilerGenerated]
            private bool bool_2;
            [CompilerGenerated]
            private bool bool_3;
            private int? nullable_0;
            private int? nullable_1;

            public int? method_0()
            {
                return this.nullable_1;
            }

            public void method_1(int? A_0)
            {
                this.nullable_1 = A_0;
            }

            [CompilerGenerated]
            public bool method_10()
            {
                return this.bool_3;
            }

            [CompilerGenerated]
            public void method_11(bool A_0)
            {
                this.bool_3 = A_0;
            }

            public int? method_2()
            {
                return this.nullable_0;
            }

            public void method_3(int? A_0)
            {
                this.nullable_0 = A_0;
            }

            [CompilerGenerated]
            public bool method_4()
            {
                return this.bool_0;
            }

            [CompilerGenerated]
            public void method_5(bool A_0)
            {
                this.bool_0 = A_0;
            }

            [CompilerGenerated]
            public bool method_6()
            {
                return this.bool_1;
            }

            [CompilerGenerated]
            public void method_7(bool A_0)
            {
                this.bool_1 = A_0;
            }

            [CompilerGenerated]
            public bool method_8()
            {
                return this.bool_2;
            }

            [CompilerGenerated]
            public void method_9(bool A_0)
            {
                this.bool_2 = A_0;
            }
        }
    }
}

