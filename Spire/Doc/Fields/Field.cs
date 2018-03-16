namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Doc.Rendering;
    using Spire.Layouting;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Field : TextRange, Interface2, IField
    {
        private bool bool_22;
        private bool bool_23;
        private bool bool_24;
        private bool bool_25;
        private bool bool_26;
        private bool bool_27;
        internal bool bool_28;
        internal bool bool_29;
        private bool bool_30;
        private bool bool_31;
        private bool bool_32;
        private bool bool_33;
        [CompilerGenerated]
        private bool bool_34;
        private const char char_0 = ',';
        private const char char_1 = '(';
        internal const char char_10 = '”';
        private const char char_2 = ')';
        private const char char_3 = '\b';
        private const char char_4 = '\x0013';
        private const char char_5 = '\x0014';
        private const char char_6 = '\x0015';
        internal const char char_7 = '\x00ab';
        internal const char char_8 = '\x00bb';
        internal const char char_9 = '“';
        private CharacterFormat characterFormat_0;
        private Class44 class44_0;
        private Class883 class883_0;
        private Field field_0;
        private FieldMark fieldMark_0;
        private FieldMark fieldMark_1;
        private int int_5;
        private List<DocumentObject> list_2;
        private List<Field> list_3;
        protected bool m_bConvertedToText;
        protected FieldType m_fieldType;
        protected internal string m_fieldValue;
        protected internal string m_formattingString;
        protected ParagraphItemType m_paraItemType;
        protected Spire.Doc.Documents.TextFormat m_textFormat;
        private static Regex regex_0 = new Regex(BookmarkStart.b(@"Ԭ献䘰ᠲᰴ欶䨸်Ἴ>楀ᡂ᭄絆歈ᙊ晌晎歐汒絔ౖݘ祚\畞䡠䅢婤", 7));
        private static Regex regex_1 = new Regex(BookmarkStart.b("Ԭ献䘰ᠲᰴ欶䨸်Ἴ>楀ᡂ᭄絆歈ᙊ晌晎湐筒๔ॖ筘ٚ睜癞䍠屢", 7));
        private static Regex regex_2 = new Regex(BookmarkStart.b("攬瘮愰瘲朴笶瀸町瘼挾㉀桂浄ᭆᕈ❊ᅌ㱎穐穒橔ౖ筘ٚ扜睞㩠㵢䝤㩦䉨䉪䕬䵮൰卲屴", 7));
        private static Regex regex_3 = new Regex(BookmarkStart.b("Ԭ笮縰瀲椴䐶ሸሺᔼ>絀ూ㕄㍆⁈⑊⍌㱎潐絒罔繖", 7));
        private static Regex regex_4 = new Regex(BookmarkStart.b("搬愮爰缲怴猶簸欺琼簾ᕀᙂᝄɆᕈ㡊晌济祐ࡒ୔畖ј灚瑜絞䥠屢奤⡦ᥨὪѬnὰr䭴奶卸剺", 7));
        private static Regex regex_5 = new Regex(BookmarkStart.b("猬琮倰Ḳ伴瘶ᐸ愺怼搾⁀湂㽄睆摈牊ౌ扎⭐๒⹔晖畘♚祜", 7));
        private static Regex regex_6 = new Regex(BookmarkStart.b("Ԭီരา渴嘶ᐸ䄺簼ሾᭀṂ汄潆癈癊ᙌ罎籐橒ࡔ繖", 7));
        private static Regex regex_7 = new Regex(BookmarkStart.b("焬献䈰漲䘴ᴶ攸机䠼伾ᵀあ潄ᭆⵈ慊ᅌ李罐祒॔繖՘⡚睜獞㵠ၢ佤㱦㝨㝪ㅬ㉮孰", 7));
        private Stack<Field> stack_1;
        private Stack<bool> stack_2;
        private const string string_10 = "\r";
        private const string string_11 = "\a";
        private const string string_12 = "\r\a";
        private string string_13;
        private string string_14;
        private string string_15;
        private string string_16;
        private string string_17;

        public Field(IDocument doc) : base(doc)
        {
            this.string_13 = BookmarkStart.b("䌷ਹ䄻", 0x12);
            this.m_formattingString = string.Empty;
            this.m_fieldValue = string.Empty;
            this.string_15 = string.Empty;
            this.string_16 = string.Empty;
            this.stack_1 = new Stack<Field>();
            this.stack_2 = new Stack<bool>();
            this.list_2 = new List<DocumentObject>();
            this.string_17 = string.Empty;
            this.m_paraItemType = ParagraphItemType.Field;
        }

        internal Field(IDocument A_0, FieldType A_1, string A_2) : this(A_0)
        {
            this.m_fieldType = A_1;
            this.string_15 = A_2;
        }

        internal override bool Accept(Class420 visitor)
        {
            return (!this.method_45(visitor) || base.method_12(visitor.vmethod_18(this)));
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            if (!base.DeepDetached)
            {
                base.Document.Fields.method_9(this);
                this.bool_24 = false;
            }
            else
            {
                this.bool_24 = true;
            }
        }

        internal override void CloneCommit()
        {
            if (this.bool_24)
            {
                base.Document.Fields.method_9(this);
                this.bool_24 = false;
            }
        }

        protected override object CloneImpl()
        {
            Field field = (Field) base.CloneImpl();
            field.class44_0 = new Class44(base.Document, field);
            field.bool_25 = false;
            field.bool_24 = true;
            return field;
        }

        protected internal virtual string ConvertSwitchesToString()
        {
            int num = 0x11;
            string str = "";
            switch (this.m_textFormat)
            {
                case Spire.Doc.Documents.TextFormat.Uppercase:
                    this.m_formattingString = this.m_formattingString.Replace(BookmarkStart.b("欶ጸ渺䴼伾⑀ㅂ", num), string.Empty);
                    str = str + BookmarkStart.b("欶ጸᬺ格伾ㅀ♂㝄杆", num);
                    break;

                case Spire.Doc.Documents.TextFormat.Lowercase:
                    this.m_formattingString = this.m_formattingString.Replace(BookmarkStart.b("欶ጸ眺刼䠾⑀ㅂ", num), string.Empty);
                    str = str + BookmarkStart.b("欶ጸᬺ焼倾㙀♂㝄杆", num);
                    break;

                case Spire.Doc.Documents.TextFormat.FirstCapital:
                    this.m_formattingString = this.m_formattingString.Replace(BookmarkStart.b("欶ጸ紺吼䴾㉀㝂ل♆㥈", num), string.Empty);
                    str = str + BookmarkStart.b("欶ጸᬺ笼嘾㍀あㅄц⡈㭊浌", num);
                    break;

                case Spire.Doc.Documents.TextFormat.Titlecase:
                    this.m_formattingString = this.m_formattingString.Replace(BookmarkStart.b("欶ጸ砺尼伾㉀", num), string.Empty);
                    str = str + BookmarkStart.b("欶ጸᬺ縼帾ㅀあ敄", num);
                    break;
            }
            if (this.IsLocal)
            {
                str = str + BookmarkStart.b("᜶攸场", num);
            }
            return (str + this.m_formattingString);
        }

        protected override void CreateLayoutInfo()
        {
            int num = 3;
            if ((this is MergeField) && ((this as MergeField).Text.Contains(BookmarkStart.b("⌨", num)) || (this as MergeField).Text.Contains(BookmarkStart.b("␨", num))))
            {
                base.method_34();
            }
            base.interface23_0 = new Class214(ChildrenLayoutDirection.Horizontal);
            Class214 class2 = base.interface23_0 as Class214;
            if (this.Type == FieldType.FieldPage)
            {
                class2.method_14(1);
            }
            else if (this.Type == FieldType.FieldNumPages)
            {
                class2.method_14(2);
            }
            else
            {
                class2.method_14(0);
            }
            if (class2.method_13() > 0)
            {
                if (base.Owner is SDTInlineContent)
                {
                    SDTInlineContent owner = base.Owner as SDTInlineContent;
                    int index = owner.Items.IndexOf(this);
                    if (owner.Items.Count > (index + 1))
                    {
                        TextRange range = owner.Items[index + 1] as TextRange;
                        if (range != null)
                        {
                            range.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    int num2 = base.OwnerParagraph.Items.IndexOf(this);
                    if (base.OwnerParagraph.Items.Count > (num2 + 1))
                    {
                        TextRange range2 = base.OwnerParagraph[num2 + 1] as TextRange;
                        if (range2 != null)
                        {
                            range2.Text = string.Empty;
                        }
                    }
                }
            }
        }

        internal override void Detach()
        {
            if ((this.End != null) && (this.End.OwnerParagraph != null))
            {
                if (base.OwnerParagraph == this.End.OwnerParagraph)
                {
                    int num8 = this.End.method_5();
                    int num5 = base.method_5();
                    for (int i = num8; i > num5; i--)
                    {
                        DocumentObject entity = base.OwnerParagraph.Items[i];
                        base.OwnerParagraph.Items.Remove(entity);
                    }
                }
                else
                {
                    Struct30 struct2 = this.method_220(this);
                    Struct30 struct3 = this.method_220(this.End);
                    Body ownerTextBody = base.OwnerParagraph.OwnerTextBody;
                    if (struct2.method_0() == struct3.method_0())
                    {
                        int num6 = struct2.method_0();
                        for (int j = struct3.method_6(); j > struct2.method_6(); j--)
                        {
                            DocumentObject obj4 = ownerTextBody.ChildObjects[num6].ChildObjects[j];
                            if (ownerTextBody.ChildObjects[num6] is Paragraph)
                            {
                                (ownerTextBody.ChildObjects[num6] as Paragraph).Items.Remove(obj4);
                            }
                            else
                            {
                                ownerTextBody.ChildObjects[num6].ChildObjects.InnerList.Remove(obj4);
                            }
                        }
                    }
                    else
                    {
                        for (int k = struct3.method_0(); k <= struct2.method_0(); k--)
                        {
                            if (k == struct2.method_0())
                            {
                                for (int m = ownerTextBody.ChildObjects[k].ChildObjects.Count - 1; m > struct2.method_6(); m--)
                                {
                                    DocumentObject obj3 = ownerTextBody.ChildObjects[k].ChildObjects[m];
                                    if (ownerTextBody.ChildObjects[k] is Paragraph)
                                    {
                                        (ownerTextBody.ChildObjects[k] as Paragraph).Items.Remove(obj3);
                                    }
                                    else
                                    {
                                        ownerTextBody.ChildObjects[k].ChildObjects.InnerList.Remove(obj3);
                                    }
                                }
                            }
                            else if (k == struct3.method_0())
                            {
                                for (int n = struct3.method_6(); n >= 0; n--)
                                {
                                    DocumentObject obj2 = ownerTextBody.ChildObjects[k].ChildObjects[n];
                                    if (ownerTextBody.ChildObjects[k] is Paragraph)
                                    {
                                        (ownerTextBody.ChildObjects[k] as Paragraph).Items.Remove(obj2);
                                    }
                                    else
                                    {
                                        ownerTextBody.ChildObjects[k].ChildObjects.InnerList.Remove(obj2);
                                    }
                                }
                            }
                            else
                            {
                                DocumentObject obj5 = ownerTextBody.ChildObjects[k];
                                ownerTextBody.ChildObjects.InnerList.Remove(obj5);
                            }
                        }
                    }
                }
            }
            base.Detach();
            if (!base.DeepDetached)
            {
                base.Document.Fields.method_7(this);
            }
        }

        public Image DownloadImage(string url)
        {
            Image image = null;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
                    request.Timeout = 0x1388;
                    request.AllowWriteStreamBuffering = true;
                    WebResponse response = request.GetResponse();
                    image = Image.FromStream(response.GetResponseStream() as MemoryStream);
                    response.Close();
                }
                catch (Exception)
                {
                }
                return image;
            }
            if (File.Exists(url))
            {
                image = Image.FromFile(url);
            }
            return image;
        }

        protected CultureInfo GetCultureInfo(int cultureId)
        {
            int num = 12;
            if (this.CharacterFormat == null)
            {
                return null;
            }
            string name = ((LocaleIDs) cultureId).ToString();
            if (this.CharacterFormat.LocaleIdASCII == 0x40a)
            {
                int index = name.IndexOf('_');
                if (index > -1)
                {
                    name = name.Remove(index, 1).Insert(index, BookmarkStart.b("ἱ", num));
                }
            }
            else
            {
                name = name.Replace('_', '-');
            }
            return new CultureInfo(name);
        }

        private void method_100(bool A_0)
        {
            Struct29 struct3;
            Struct30 struct7;
            Struct30 struct8;
            bool flag;
            bool flag2;
            int num = 2;
            ((Interface1) this.End).imethod_0().imethod_7(true);
            if (this.IsLocked && A_0)
            {
                this.method_229(this, 0, this.Range.Count - 1);
                return;
            }
        Label_01CD:
            this.list_3 = null;
            IfField field = this as IfField;
            field.method_236(this.method_177());
            if (!field.CompartResult.HasValue)
            {
                if (A_0)
                {
                    this.method_229(this, 0, this.Range.Count - 1);
                }
                goto Label_0E35;
            }
            Struct31 struct2 = new Struct31 {
                field_0 = this
            };
            if (field.CompartResult.Value)
            {
                struct3 = this.NestedFieldCodeObjects.method_10(field.TrueResult);
                struct2.bool_0 = true;
                this.FieldResult = field.TrueResult.string_0;
                Struct29 struct4 = this.NestedFieldCodeObjects.method_10(field.FalseResult);
                if ((!string.IsNullOrEmpty(field.FalseResult.string_0) && (struct3.method_2().method_0() == struct4.method_2().method_0())) && (struct3.method_2().method_6() == struct4.method_2().method_6()))
                {
                    Struct30 struct6 = struct3.method_2();
                    struct6.method_5(struct4.method_2().method_2() - 1);
                    struct3.method_3(struct6);
                }
            }
            else
            {
                struct3 = this.NestedFieldCodeObjects.method_10(field.FalseResult);
                struct2.bool_0 = false;
                this.FieldResult = field.FalseResult.string_0;
            }
            struct2.struct29_0 = struct3;
            if (!struct3.method_4())
            {
                if (A_0)
                {
                    this.method_229(this, 0, this.Range.Count - 1);
                }
                goto Label_0E35;
            }
            Paragraph ownerParagraph = base.OwnerParagraph;
            Body ownerTextBody = ownerParagraph.OwnerTextBody;
            if ((this.End != null) && (this.End.OwnerParagraph != ownerParagraph))
            {
                ownerParagraph = this.End.OwnerParagraph;
            }
            Struct30 introduced72 = struct3.method_2();
            List<DocumentObject> list = this.method_221(introduced72, struct3.method_0(), ownerTextBody);
            if (this.bool_28 || !this.method_54(list))
            {
                this.method_55(list);
                this.method_71(list);
                struct2.list_0 = list;
                if (!this.NestedFieldCodeObjects.method_2())
                {
                    int num2 = ownerParagraph.Items.IndexOf(this.End);
                    FieldMark entity = new FieldMark(base.Document) {
                        Type = FieldMarkType.FieldSeparator
                    };
                    if ((num2 > -1) && (num2 < ownerParagraph.Items.Count))
                    {
                        ownerParagraph.Items.Insert(num2, entity);
                    }
                    if (this.Separator == null)
                    {
                        this.Separator = entity;
                    }
                }
                struct7 = this.method_220(this.Separator);
                struct8 = this.method_220(this.End);
                List<DocumentObject> list2 = this.method_224(struct7, struct8, ownerTextBody, false, false, true);
                foreach (DocumentObject obj2 in list2)
                {
                    if ((obj2.Owner != null) && (obj2.Owner.ChildObjects.IndexOf(obj2) > -1))
                    {
                        if (obj2.Owner is Paragraph)
                        {
                            (obj2.Owner as Paragraph).Items.Remove(obj2);
                        }
                        else
                        {
                            if (obj2 is Paragraph)
                            {
                                (obj2 as Paragraph).method_59(0, true);
                            }
                            obj2.Owner.ChildObjects.Remove(obj2);
                        }
                    }
                }
                list2.Clear();
                list2 = null;
                struct8 = this.method_220(this.End);
                flag = false;
                using (List<DocumentObject>.Enumerator enumerator = list.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        DocumentObject current = enumerator.Current;
                        if ((current is Paragraph) || (current is Table))
                        {
                            goto Label_039F;
                        }
                    }
                    goto Label_03B2;
                Label_039F:
                    flag = true;
                }
            }
            else
            {
                this.bool_28 = true;
                goto Label_01CD;
            }
        Label_03B2:
            if (((flag2 = ((!flag && struct3.method_2().method_8()) && struct3.method_0().method_8()) && (struct3.method_2().method_0() != struct3.method_0().method_0())) || flag) && (struct7.method_0() == struct8.method_0()))
            {
                Struct30 struct9 = this.method_220(this.End);
                this.method_116(ownerParagraph, ownerTextBody, struct9);
                struct7 = this.method_220(this.Separator);
                struct8 = this.method_220(this.End);
            }
            int num3 = struct8.method_6();
            int index = struct7.method_0() + 1;
            bool flag3 = false;
            new Regex(BookmarkStart.b("ਧ", num));
            Field item = null;
            Stack<Field> stack = new Stack<Field>();
            int num5 = -1;
            int num6 = 0;
            int count = list.Count;
            while (num6 < count)
            {
                DocumentObject obj4 = list[num6];
                DocumentObject obj5 = null;
                if (this.method_104(obj4, field))
                {
                    if (obj4 is Paragraph)
                    {
                        if (struct7.method_0() == struct8.method_0())
                        {
                            obj5 = obj4.Clone();
                            int num8 = obj4.ChildObjects.IndexOf(field);
                            for (int i = 0; i <= num8; i++)
                            {
                                obj5.ChildObjects[0].RemoveSelf();
                            }
                            flag3 = true;
                            ownerTextBody.ChildObjects.Insert(index, obj5);
                            obj5.method_0(ownerTextBody);
                            index++;
                            TextRange range = this.method_103(struct2);
                            obj5.ChildObjects.Insert(num8, range);
                            range.method_0(obj5);
                        }
                        else
                        {
                            obj5 = this.method_103(struct2);
                            ownerParagraph = this.Separator.OwnerParagraph;
                            ownerParagraph.Items.Insert(struct7.method_6() + 1, obj5);
                            obj5.method_0(ownerParagraph);
                            int num10 = obj4.ChildObjects.IndexOf(field);
                            if (num10 < (obj4.ChildObjects.Count - 1))
                            {
                                int num11 = num10 + 1;
                                int num12 = obj4.ChildObjects.Count;
                                while (num11 < num12)
                                {
                                    DocumentObject obj7 = obj4.ChildObjects[num11].Clone();
                                    if (obj7 is Field)
                                    {
                                        stack.Push(item);
                                        item = obj7 as Field;
                                    }
                                    if (((item != null) && (obj7 is FieldMark)) && ((obj7 as FieldMark).Type == FieldMarkType.FieldSeparator))
                                    {
                                        item.Separator = obj7 as FieldMark;
                                    }
                                    if (((item != null) && (obj7 is FieldMark)) && ((obj7 as FieldMark).Type == FieldMarkType.FieldEnd))
                                    {
                                        item.End = obj7 as FieldMark;
                                        if (stack.Count > 0)
                                        {
                                            item = stack.Pop();
                                        }
                                    }
                                    if ((obj7 is TextRange) && struct3.method_0().Equals(struct3.method_2()))
                                    {
                                        (obj7 as TextRange).Text = field.CompartResult.Value ? field.TrueResult.method_1().string_0 : field.FalseResult.method_1().string_0;
                                    }
                                    else if (obj7 is TextRange)
                                    {
                                        if (obj7 is IfField)
                                        {
                                            IfField field3 = obj7 as IfField;
                                            int num13 = -1;
                                            int num14 = -1;
                                            int num15 = obj4.ChildObjects.IndexOf(field3.Separator);
                                            if (num15 == -1)
                                            {
                                                num15 = list.IndexOf(field3.Separator);
                                                if (num15 == -1)
                                                {
                                                    num13 = list.IndexOf(field3.Separator.OwnerParagraph);
                                                    num15 = this.method_220(field3.Separator).method_6();
                                                }
                                            }
                                            int num16 = obj4.ChildObjects.IndexOf(field3.End);
                                            if (num16 == -1)
                                            {
                                                num16 = list.IndexOf(field3.End);
                                                num6 = num16;
                                                if (num16 == -1)
                                                {
                                                    num14 = list.IndexOf(field3.End.OwnerParagraph);
                                                    num16 = this.method_220(field3.End).method_6();
                                                    num6 = num14;
                                                }
                                            }
                                            else
                                            {
                                                num11 = num16;
                                            }
                                            List<DocumentObject> list3 = new List<DocumentObject>();
                                            int num17 = (num13 == -1) ? (num15 + 1) : num13;
                                            int num18 = (num14 == -1) ? num16 : (num14 + 1);
                                            for (int j = num17; j < num18; j++)
                                            {
                                                DocumentObject obj8 = obj4.ChildObjects[j];
                                                if ((j == num17) && (num13 > -1))
                                                {
                                                    for (int k = num15 + 1; k < obj8.ChildObjects.Count; k++)
                                                    {
                                                        DocumentObject obj9 = obj8.ChildObjects[k];
                                                        list3.Add(obj9);
                                                    }
                                                }
                                                else if (((j + 1) == num18) && (num14 > -1))
                                                {
                                                    for (int m = 0; m < num16; m++)
                                                    {
                                                        DocumentObject obj10 = obj8.ChildObjects[m];
                                                        list3.Add(obj10);
                                                    }
                                                }
                                                else
                                                {
                                                    list3.Add(obj8);
                                                }
                                            }
                                            this.method_105(field, ownerTextBody, struct2, struct3, list3, flag, flag2, ref num3, ref index, ref flag3);
                                            list3 = null;
                                            if (stack.Count > 0)
                                            {
                                                item = stack.Pop();
                                            }
                                        }
                                        else
                                        {
                                            (obj7 as TextRange).IsIfFieldResultFirstItem = num11 == 0;
                                            this.method_112(obj7 as TextRange, struct2);
                                        }
                                    }
                                    num11++;
                                }
                            }
                            flag3 = true;
                        }
                        goto Label_0DC3;
                    }
                    obj5 = this.method_103(struct2);
                }
                else if ((obj4 is Paragraph) && this.method_64(obj4 as Paragraph))
                {
                    obj5 = (obj4 as Paragraph).method_61();
                }
                else
                {
                    obj5 = obj4.Clone();
                }
                if (obj5 is ParagraphBase)
                {
                    if (flag2)
                    {
                        int num22 = obj4.Owner.method_5();
                        if (num5 >= 0)
                        {
                            if (num22 != num5)
                            {
                                flag = true;
                                flag3 = true;
                                flag2 = false;
                            }
                        }
                        else
                        {
                            num5 = num22;
                        }
                    }
                    if ((flag2 || flag) && !flag3)
                    {
                        ownerParagraph = this.Separator.OwnerParagraph;
                    }
                    else if (flag && flag3)
                    {
                        ownerParagraph = this.End.OwnerParagraph;
                    }
                    if (obj5 is Field)
                    {
                        stack.Push(item);
                        item = obj5 as Field;
                    }
                    if (((item != null) && (obj5 is FieldMark)) && ((obj5 as FieldMark).Type == FieldMarkType.FieldSeparator))
                    {
                        item.Separator = obj5 as FieldMark;
                    }
                    if (((item != null) && (obj5 is FieldMark)) && ((obj5 as FieldMark).Type == FieldMarkType.FieldEnd))
                    {
                        item.End = obj5 as FieldMark;
                        if (stack.Count > 0)
                        {
                            item = stack.Pop();
                        }
                    }
                    if ((obj5 is TextRange) && struct3.method_0().Equals(struct3.method_2()))
                    {
                        if ((obj5 is Field) && (list.Count == 1))
                        {
                            TextRange range2 = new TextRange(base.Document) {
                                Text = (obj5 as Field).FieldResult
                            };
                            range2.ApplyCharacterFormat((obj5 as TextRange).CharacterFormat);
                            obj5 = range2;
                        }
                        else
                        {
                            (obj5 as TextRange).Text = field.CompartResult.Value ? field.TrueResult.method_1().string_0 : field.FalseResult.method_1().string_0;
                        }
                    }
                    else if (obj5 is TextRange)
                    {
                        if ((obj5 is Field) && (list.Count == 1))
                        {
                            TextRange range3 = new TextRange(base.Document) {
                                Text = (obj5 as Field).FieldResult
                            };
                            range3.ApplyCharacterFormat((obj5 as TextRange).CharacterFormat);
                            obj5 = range3;
                        }
                        else
                        {
                            if (obj5 is IfField)
                            {
                                IfField field4 = obj5 as IfField;
                                int num23 = -1;
                                int num24 = -1;
                                int num25 = list.IndexOf(field4.Separator);
                                if (num25 == -1)
                                {
                                    num23 = list.IndexOf(field4.Separator.OwnerParagraph);
                                    num25 = this.method_220(field4.Separator).method_6();
                                }
                                int num26 = list.IndexOf(field4.End);
                                if (num26 == -1)
                                {
                                    num24 = list.IndexOf(field4.End.OwnerParagraph);
                                    num26 = this.method_220(field4.End).method_6();
                                    num6 = num24;
                                }
                                else
                                {
                                    num6 = num26;
                                }
                                List<DocumentObject> list4 = new List<DocumentObject>();
                                int num27 = (num23 == -1) ? (num25 + 1) : num23;
                                int num28 = (num24 == -1) ? num26 : (num24 + 1);
                                for (int n = num27; n < num28; n++)
                                {
                                    DocumentObject obj11 = list[n];
                                    if ((n == num27) && (num23 > -1))
                                    {
                                        for (int num30 = num25 + 1; num30 < obj11.ChildObjects.Count; num30++)
                                        {
                                            DocumentObject obj12 = obj11.ChildObjects[num30];
                                            list4.Add(obj12);
                                        }
                                    }
                                    else if (((n + 1) == num28) && (num24 > -1))
                                    {
                                        for (int num31 = 0; num31 < num26; num31++)
                                        {
                                            DocumentObject obj13 = obj11.ChildObjects[num31];
                                            list4.Add(obj13);
                                        }
                                    }
                                    else
                                    {
                                        list4.Add(obj11);
                                    }
                                }
                                this.method_105(field, ownerTextBody, struct2, struct3, list4, flag, flag2, ref num3, ref index, ref flag3);
                                list4 = null;
                                if (stack.Count > 0)
                                {
                                    item = stack.Pop();
                                }
                                goto Label_0DC3;
                            }
                            (obj5 as TextRange).IsIfFieldResultFirstItem = num6 == 0;
                            this.method_112(obj5 as TextRange, struct2);
                        }
                    }
                    if ((obj5.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.TextRange) || !string.IsNullOrEmpty((obj5 as TextRange).Text))
                    {
                        if ((!flag && !flag2) || (flag && flag3))
                        {
                            if ((num3 > -1) && (num3 < ownerParagraph.Items.Count))
                            {
                                ownerParagraph.Items.Insert(num3, obj5);
                                obj5.method_0(ownerParagraph);
                                num3++;
                            }
                        }
                        else
                        {
                            ownerParagraph.Items.Add(obj5);
                            obj5.method_0(ownerParagraph);
                        }
                    }
                }
                else
                {
                    flag3 = true;
                    ownerTextBody.ChildObjects.Insert(index, obj5);
                    obj5.method_0(ownerTextBody);
                    index++;
                }
            Label_0DC3:
                num6++;
            }
            stack.Clear();
            stack = null;
            if (A_0)
            {
                this.method_230(this, struct7);
                if (this.bool_28)
                {
                    this.method_101(this);
                }
            }
            list.Clear();
            list = null;
        Label_0E35:
            this.bool_28 = false;
            this.list_3 = null;
        }

        private void method_101(Field A_0)
        {
            if ((A_0 != null) && (A_0.Document != null))
            {
                Struct30 struct3 = this.method_220(A_0.Separator);
                Struct30 struct2 = this.method_220(A_0.End);
                Body ownerTextBody = A_0.OwnerParagraph.OwnerTextBody;
                if (struct3.method_0() == struct2.method_0())
                {
                    int num6 = struct3.method_0();
                    int num4 = struct3.method_6();
                    int num8 = struct2.method_6();
                    while (num4 <= num8)
                    {
                        DocumentObject obj3 = ownerTextBody.ChildObjects[num6].ChildObjects[num4];
                        if ((obj3 is Field) && !A_0.Document.LayoutVariables.method_3().Contains(obj3 as Field))
                        {
                            A_0.Document.LayoutVariables.method_3().Add(obj3 as Field);
                        }
                        num4++;
                    }
                }
                else
                {
                    int num2 = struct3.method_0();
                    int num9 = struct2.method_0();
                    while (num2 <= num9)
                    {
                        if (num2 == struct3.method_0())
                        {
                            int num10 = struct3.method_6();
                            int count = ownerTextBody.ChildObjects[num2].ChildObjects.Count;
                            while (num10 < count)
                            {
                                DocumentObject obj4 = ownerTextBody.ChildObjects[num2].ChildObjects[num10];
                                if ((obj4 is Field) && !A_0.Document.LayoutVariables.method_3().Contains(obj4 as Field))
                                {
                                    A_0.Document.LayoutVariables.method_3().Add(obj4 as Field);
                                }
                                num10++;
                            }
                        }
                        else if (num2 == struct2.method_0())
                        {
                            int num = 0;
                            int num3 = struct2.method_6();
                            while (num < num3)
                            {
                                DocumentObject obj5 = ownerTextBody.ChildObjects[num2].ChildObjects[num];
                                if ((obj5 is Field) && !A_0.Document.LayoutVariables.method_3().Contains(obj5 as Field))
                                {
                                    A_0.Document.LayoutVariables.method_3().Add(obj5 as Field);
                                }
                                num++;
                            }
                        }
                        else
                        {
                            int num7;
                            int num5 = 0;
                            num7 = num7 = ownerTextBody.ChildObjects[num2].ChildObjects.Count;
                            while (num5 < num7)
                            {
                                DocumentObject obj2 = ownerTextBody.ChildObjects[num2].ChildObjects[num5];
                                if ((obj2 is Field) && !A_0.Document.LayoutVariables.method_3().Contains(obj2 as Field))
                                {
                                    A_0.Document.LayoutVariables.method_3().Add(obj2 as Field);
                                }
                                num5++;
                            }
                        }
                        num2++;
                    }
                }
            }
        }

        private string method_102(string A_0)
        {
            if (string.IsNullOrEmpty(A_0))
            {
                return A_0;
            }
            string[] strArray = A_0.Split(new char[] { '"' });
            if (strArray.Length <= 1)
            {
                return A_0;
            }
            StringBuilder builder = new StringBuilder();
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                string str = strArray[index];
                if (index == 0)
                {
                    if (!string.IsNullOrEmpty(str.Trim()))
                    {
                        builder.Append(str);
                        builder.Append('"');
                    }
                }
                else if ((index + 1) < length)
                {
                    if (!string.IsNullOrEmpty(strArray[index + 1].Trim()))
                    {
                        builder.Append(str);
                        builder.Append('"');
                    }
                    else
                    {
                        builder.Append(str);
                    }
                }
                else if (((index + 1) == length) && !string.IsNullOrEmpty(str.Trim()))
                {
                    builder.Append(str);
                }
                index++;
            }
            return builder.ToString();
        }

        private TextRange method_103(Struct31 A_0)
        {
            TextRange range = new TextRange(base.m_doc);
            range.ApplyCharacterFormat(A_0.field_0.CharacterFormat);
            string str = A_0.bool_0 ? (A_0.field_0 as IfField).TrueResult.string_0 : (A_0.field_0 as IfField).FalseResult.method_1().string_0;
            int introduced8 = A_0.struct29_0.method_2().method_0();
            if (introduced8 == A_0.struct29_0.method_0().method_0())
            {
                range.Text = this.method_102(str);
                return range;
            }
            int introduced9 = A_0.struct29_0.method_0().method_0();
            if ((introduced9 - A_0.struct29_0.method_2().method_0()) != 0)
            {
                string[] strArray = this.method_109(A_0, str);
                range.Text = this.method_102(strArray[0]);
            }
            return range;
        }

        private bool method_104(DocumentObject A_0, IfField A_1)
        {
            bool flag = false;
            if ((A_0 != null) && (A_1 != null))
            {
                if ((A_0 is ParagraphBase) && (A_0 == A_1))
                {
                    return true;
                }
                if (!(A_0 is Paragraph))
                {
                    return flag;
                }
                Paragraph paragraph = A_0 as Paragraph;
                foreach (ParagraphBase base2 in paragraph.Items)
                {
                    if (flag = this.method_104(base2, A_1))
                    {
                        return flag;
                    }
                }
            }
            return flag;
        }

        private void method_105(IfField A_0, Body A_1, Struct31 A_2, Struct29 A_3, List<DocumentObject> A_4, bool A_5, bool A_6, ref int A_7, ref int A_8, ref bool A_9)
        {
            if (((A_0 != null) && (A_4 != null)) && (A_4.Count > 0))
            {
                Field item = null;
                Stack<Field> stack = new Stack<Field>();
                Paragraph ownerParagraph = A_0.OwnerParagraph;
                int num = 0;
                int count = A_4.Count;
                while (num < count)
                {
                    DocumentObject entity = A_4[num].Clone();
                    if (entity is ParagraphBase)
                    {
                        if ((A_6 || A_5) && !A_9)
                        {
                            ownerParagraph = A_0.Separator.OwnerParagraph;
                        }
                        else if (A_5 && A_9)
                        {
                            ownerParagraph = A_0.End.OwnerParagraph;
                        }
                        if (entity is Field)
                        {
                            stack.Push(item);
                            item = entity as Field;
                        }
                        if (((item != null) && (entity is FieldMark)) && ((entity as FieldMark).Type == FieldMarkType.FieldSeparator))
                        {
                            item.Separator = entity as FieldMark;
                        }
                        if (((item != null) && (entity is FieldMark)) && ((entity as FieldMark).Type == FieldMarkType.FieldEnd))
                        {
                            item.End = entity as FieldMark;
                            if (stack.Count > 0)
                            {
                                item = stack.Pop();
                            }
                        }
                        if ((entity is TextRange) && A_3.method_0().Equals(A_3.method_2()))
                        {
                            if ((entity is Field) && (A_4.Count == 1))
                            {
                                TextRange range2 = new TextRange(base.Document) {
                                    Text = (entity as Field).FieldResult
                                };
                                range2.ApplyCharacterFormat((entity as TextRange).CharacterFormat);
                                entity = range2;
                            }
                            else
                            {
                                (entity as TextRange).Text = A_0.CompartResult.Value ? A_0.TrueResult.method_1().string_0 : A_0.FalseResult.method_1().string_0;
                            }
                        }
                        else if (entity is TextRange)
                        {
                            if ((entity is Field) && (A_4.Count == 1))
                            {
                                TextRange range = new TextRange(base.Document) {
                                    Text = (entity as Field).FieldResult
                                };
                                range.ApplyCharacterFormat((entity as TextRange).CharacterFormat);
                                entity = range;
                            }
                            else if (entity is IfField)
                            {
                                IfField field2 = entity as IfField;
                                int num8 = -1;
                                int num7 = -1;
                                int index = A_4.IndexOf(field2.Separator);
                                if (index == -1)
                                {
                                    num8 = A_4.IndexOf(field2.Separator.OwnerParagraph);
                                    index = this.method_220(field2.Separator).method_6();
                                }
                                int num4 = A_4.IndexOf(field2.End);
                                if (num4 == -1)
                                {
                                    num7 = A_4.IndexOf(field2.End.OwnerParagraph);
                                    num4 = this.method_220(field2.End).method_6();
                                    num = num7;
                                }
                                else
                                {
                                    num = num4;
                                }
                                List<DocumentObject> list = new List<DocumentObject>();
                                int num9 = (num8 == -1) ? (index + 1) : num8;
                                int num6 = (num7 == -1) ? num4 : (num7 + 1);
                                for (int i = num9; i < num6; i++)
                                {
                                    DocumentObject obj3 = A_4[i];
                                    if ((i == num9) && (num8 > -1))
                                    {
                                        for (int j = index + 1; j < obj3.ChildObjects.Count; j++)
                                        {
                                            DocumentObject obj4 = obj3.ChildObjects[j];
                                            list.Add(obj4);
                                        }
                                    }
                                    else if (((i + 1) == num6) && (num7 > -1))
                                    {
                                        for (int k = 0; k < num4; k++)
                                        {
                                            DocumentObject obj5 = obj3.ChildObjects[k];
                                            list.Add(obj5);
                                        }
                                    }
                                    else
                                    {
                                        list.Add(obj3);
                                    }
                                }
                                this.method_105(A_0, A_1, A_2, A_3, list, A_5, A_6, ref A_7, ref A_8, ref A_9);
                                list = null;
                                goto Label_044B;
                            }
                        }
                        if ((entity.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.TextRange) || !string.IsNullOrEmpty((entity as TextRange).Text))
                        {
                            if ((!A_5 && !A_6) || (A_5 && A_9))
                            {
                                if ((A_7 > -1) && (A_7 < ownerParagraph.Items.Count))
                                {
                                    ownerParagraph.Items.Insert(A_7, entity);
                                    entity.method_0(ownerParagraph);
                                    A_7++;
                                }
                            }
                            else
                            {
                                ownerParagraph.Items.Add(entity);
                                entity.method_0(ownerParagraph);
                            }
                        }
                    }
                    else
                    {
                        A_9 = true;
                        A_1.ChildObjects.Insert(A_8, entity);
                        entity.method_0(A_1);
                        A_8++;
                    }
                Label_044B:
                    num++;
                }
            }
        }

        private void method_106(FieldMark A_0, Body A_1, Struct31 A_2)
        {
            Struct30 struct2 = this.method_220(A_0);
            Struct30 struct3 = new Struct30(-1, -1);
            List<Struct31> list = this.method_111(struct2.method_6(), A_0.OwnerParagraph, ref struct3);
            if ((list.Count > 0) && (struct3.method_0() != -1))
            {
                A_2.list_0 = this.method_115(A_2.list_0);
                A_2.struct30_1 = struct2;
                Struct30 struct5 = A_2.struct30_0;
                Struct30 struct4 = A_2.struct30_1;
                if (struct5.method_0() != struct4.method_0())
                {
                    A_2.struct30_0 = new Struct30(struct4.method_0(), 0);
                }
                else
                {
                    A_2.struct30_0.method_7(A_2.struct30_0.method_6() + 1);
                }
                if (A_2.list_0[0] != A_2.field_0)
                {
                    list.Insert(0, A_2);
                }
                this.method_232(A_1, list);
                this.method_110(list);
                this.method_107(list, A_1, struct3, true);
            }
        }

        private void method_107(List<Struct31> A_0, Body A_1, Struct30 A_2, bool A_3)
        {
            int num = A_2.method_6() + 1;
            int index = A_2.method_0();
            new Regex(BookmarkStart.b("ေ", 12));
            Field field = null;
            Paragraph paragraph = A_1.ChildObjects[A_2.method_0()] as Paragraph;
            Stack<Field> stack = new Stack<Field>();
            foreach (Struct31 struct2 in A_0)
            {
                bool flag2 = this.method_114(struct2.list_0);
                bool flag3 = false;
                bool flag = false;
                Struct30 struct3 = this.method_220(struct2.field_0.Separator);
                if (flag2 && (struct3.method_0() == A_2.method_0()))
                {
                    this.method_116(paragraph, A_1, A_2);
                    A_2 = this.method_220(struct2.field_0.End);
                }
                int num3 = 0;
                int count = struct2.list_0.Count;
                while (num3 < count)
                {
                    DocumentObject entity = struct2.list_0[num3].Clone();
                    if (entity is ParagraphBase)
                    {
                        if ((flag2 && !flag3) && !flag)
                        {
                            flag = true;
                            paragraph = A_1.ChildObjects[struct3.method_0()] as Paragraph;
                            if (paragraph.interface23_0 != null)
                            {
                                paragraph.interface23_0.imethod_5(false);
                            }
                            num = struct3.method_6() + 1;
                        }
                        if ((flag2 && flag3) && !flag)
                        {
                            flag = true;
                            paragraph = A_1.ChildObjects[A_2.method_0()] as Paragraph;
                            num = A_2.method_6() + 1;
                        }
                        (entity as ParagraphBase).IsAddForIfField = A_3;
                        this.method_113(entity as ParagraphBase, ref field, stack, struct2);
                        if (struct2.list_0[num3] == struct2.field_0)
                        {
                            this.method_108(struct2, paragraph, ref num, true, A_1);
                            this.method_231(struct2.list_0[num3]);
                        }
                        else if (!(entity is BookmarkStart) && !(entity is BookmarkEnd))
                        {
                            paragraph.Items.Insert(num, entity);
                            entity.method_0(paragraph);
                            num++;
                        }
                        if (A_3 && !base.m_doc.LayoutVariables.method_1().Contains(paragraph))
                        {
                            base.m_doc.LayoutVariables.method_1().Add(paragraph);
                        }
                    }
                    else if (entity is Paragraph)
                    {
                        flag3 = true;
                        flag = false;
                        (entity as Paragraph).IsAddForIfField = A_3;
                        A_1.ChildObjects.Insert(index, entity);
                        entity.method_0(A_1);
                        index++;
                        A_2.method_1(A_2.method_0() + 1);
                        if (A_3 && !base.m_doc.LayoutVariables.method_1().Contains(entity))
                        {
                            base.m_doc.LayoutVariables.method_1().Add(entity);
                        }
                    }
                    num3++;
                }
            }
            A_0.Clear();
            A_0 = null;
            stack.Clear();
            stack = null;
        }

        private void method_108(Struct31 A_0, Paragraph A_1, ref int A_2, bool A_3, Body A_4)
        {
            TextRange entity = new TextRange(base.m_doc) {
                IsAddForIfField = A_3 ? true : false
            };
            string str = A_0.bool_0 ? (A_0.field_0 as IfField).TrueResult.string_0 : (A_0.field_0 as IfField).FalseResult.method_1().string_0;
            int introduced15 = A_0.struct29_0.method_2().method_0();
            if (introduced15 == A_0.struct29_0.method_0().method_0())
            {
                entity.Text = str;
                entity.Text = entity.Text.Trim().Trim(new char[] { '"' });
                A_1.Items.Insert(A_2, entity);
                entity.method_0(A_1);
                A_2++;
            }
            else
            {
                int introduced16 = A_0.struct29_0.method_0().method_0();
                if ((introduced16 - A_0.struct29_0.method_2().method_0()) == 1)
                {
                    TextRange range2;
                    string[] strArray = this.method_109(A_0, str);
                    entity.Text = strArray[0];
                    entity.Text = entity.Text.Trim().Trim(new char[] { '"' });
                    A_1.Items.Insert(A_2, entity);
                    A_2++;
                    Paragraph paragraph = A_4.ChildObjects[this.method_220(A_0.field_0.End).method_0()] as Paragraph;
                    int index = paragraph.ChildObjects.IndexOf(A_0.field_0.End);
                    range2 = new TextRange(base.m_doc) {
                        IsAddForIfField = A_3 ? true : false,
                        Text = strArray[1],
                        Text = range2.Text.Trim().Trim(new char[] { '"' })
                    };
                    paragraph.Items.Insert(index, range2);
                }
            }
        }

        private string[] method_109(Struct31 A_0, string A_1)
        {
            string[] strArray = new string[2];
            int startIndex = A_0.struct29_0.method_2().method_2();
            int num2 = A_0.struct29_0.method_2().method_0();
            int num3 = A_0.struct29_0.method_2().method_6();
            for (int i = 0; i < A_0.field_0.NestedFieldCodeObjects.list_2.Count; i++)
            {
                string[] strArray2;
                Struct30 struct5 = A_0.field_0.NestedFieldCodeObjects.list_2[i];
                if ((struct5.method_0() != num2) || (struct5.method_6() != num3))
                {
                    break;
                }
                (strArray2 = strArray)[0] = strArray2[0] + A_0.field_0.NestedFieldCodeObjects.list_0[i].string_0.Substring(startIndex);
            }
            strArray[1] = A_1.Substring(strArray[0].Length);
            return strArray;
        }

        private void method_110(List<Struct31> A_0)
        {
            new List<DocumentObject>();
            for (int i = 0; i < (A_0.Count - 1); i++)
            {
                Paragraph paragraph;
                int num3;
                Struct31 struct2 = A_0[i];
                List<DocumentObject> list = struct2.list_0;
                List<DocumentObject> list2 = A_0[i + 1].list_0;
                int num4 = list.Count - 1;
                while (num4 >= 0)
                {
                    if ((list[num4] is Paragraph) || (list[num4] is IfField))
                    {
                        goto Label_00E7;
                    }
                    DocumentObject obj2 = list[num4].Clone();
                    this.method_112(obj2, struct2);
                    (obj2 as ParagraphBase).IsAddForIfField = true;
                    if ((list2.Count > 0) && (list2[0] is Paragraph))
                    {
                        (list2[0] as Paragraph).Items.Insert(0, obj2);
                    }
                    else
                    {
                        list2.Insert(0, obj2);
                    }
                    if (num4 == 0)
                    {
                        list.RemoveRange(0, list.Count);
                    }
                    num4--;
                }
                goto Label_00FC;
            Label_00E7:
                list.RemoveRange(num4 + 1, (list.Count - num4) - 1);
            Label_00FC:
                if (this.method_114(list))
                {
                    num3 = 0;
                    while (num3 < list.Count)
                    {
                        if (list[num3] is Paragraph)
                        {
                            goto Label_012B;
                        }
                        num3++;
                    }
                }
                continue;
            Label_012B:
                paragraph = list[num3].Clone() as Paragraph;
                for (int j = num3 - 1; j >= 0; j--)
                {
                    paragraph.Items.Insert(0, list[j].Clone());
                }
                list[num3] = paragraph;
                list.RemoveRange(0, num3);
            }
        }

        private List<Struct31> method_111(int A_0, Paragraph A_1, ref Struct30 A_2)
        {
            List<Struct31> list = new List<Struct31>();
            if ((A_1.Items.Count > (A_0 + 1)) && (A_1.ChildObjects[A_0 + 1] is IfField))
            {
                Struct29 struct2;
                IfField field = A_1.ChildObjects[A_0 + 1] as IfField;
                if (A_1.ChildObjects.Contains(field.End))
                {
                    return list;
                }
                Struct31 item = new Struct31 {
                    field_0 = field
                };
                field.method_236(field.method_177());
                if (!field.CompartResult.HasValue)
                {
                    return list;
                }
                if (field.CompartResult.Value)
                {
                    struct2 = field.NestedFieldCodeObjects.method_10(field.TrueResult);
                    item.bool_0 = true;
                    Struct29 struct5 = this.NestedFieldCodeObjects.method_10(field.FalseResult);
                    if ((struct2.method_2().method_0() == struct5.method_2().method_0()) && (struct2.method_2().method_6() == struct5.method_2().method_6()))
                    {
                        Struct30 struct11 = struct2.method_2();
                        struct11.method_5(struct5.method_2().method_2() - 1);
                        struct2.method_3(struct11);
                    }
                }
                else
                {
                    struct2 = field.NestedFieldCodeObjects.method_10(field.FalseResult);
                    item.bool_0 = false;
                }
                item.struct29_0 = struct2;
                if (struct2.method_4())
                {
                    Paragraph ownerParagraph = field.OwnerParagraph;
                    Body body2 = ownerParagraph.OwnerTextBody;
                    if ((field.End != null) && (field.End.OwnerParagraph != ownerParagraph))
                    {
                        ownerParagraph = field.End.OwnerParagraph;
                    }
                    Struct30 struct8 = this.method_220(field.End);
                    this.method_220(field.Separator);
                    Struct30 introduced18 = struct2.method_2();
                    item.list_0 = this.method_223(introduced18, struct2.method_0(), body2, true, true);
                    item.struct30_1 = struct8;
                    item.struct30_0 = this.method_220(field);
                    list.Add(item);
                    A_2 = struct8;
                    list.AddRange(this.method_111(struct8.method_6(), body2.ChildObjects[struct8.method_0()] as Paragraph, ref A_2));
                    return list;
                }
                Struct30 struct4 = this.method_220(field.End);
                A_2 = struct4;
                Body ownerTextBody = field.OwnerParagraph.OwnerTextBody;
                this.method_230(field, struct4);
                list.AddRange(this.method_111(struct4.method_6(), ownerTextBody.ChildObjects[struct4.method_0()] as Paragraph, ref A_2));
            }
            return list;
        }

        private void method_112(DocumentObject A_0, Struct31 A_1)
        {
            int num = 8;
            if (A_0 is TextRange)
            {
                Regex regex = new Regex(BookmarkStart.b("భ", num));
                string input = (A_0 as TextRange).Text.Replace('“', '"').Replace('”', '"');
                int length = input.TrimEnd(new char[0]).Length;
                MatchCollection matchs = regex.Matches(input);
                if (matchs.Count > 1)
                {
                    if (!A_1.bool_0)
                    {
                        if (A_1.struct29_0.method_2().method_4() >= 0)
                        {
                            length = (matchs[matchs.Count - 1].Index + 1) - A_1.struct29_0.method_2().method_2();
                            (A_0 as TextRange).Text = input.Substring(A_1.struct29_0.method_2().method_2(), length).Trim(new char[] { '"' });
                        }
                        else
                        {
                            (A_0 as TextRange).Text = input.Substring(A_1.struct29_0.method_2().method_2()).Trim(new char[] { '"' });
                        }
                    }
                    else if ((!(A_0 as TextRange).IsIfFieldResultFirstItem || (A_1.struct29_0.method_2().method_2() < 0)) || (A_1.struct29_0.method_2().method_4() < 0))
                    {
                        if ((A_0 as TextRange).IsIfFieldResultFirstItem && (A_1.struct29_0.method_2().method_2() >= 0))
                        {
                            (A_0 as TextRange).Text = input.Substring(A_1.struct29_0.method_2().method_2()).TrimEnd(new char[0]).Replace(BookmarkStart.b("భ", num), string.Empty);
                        }
                        else
                        {
                            (A_0 as TextRange).Text = input.Substring(0, matchs[0].Index);
                        }
                    }
                    else
                    {
                        int introduced21 = A_1.struct29_0.method_2().method_4();
                        int num3 = introduced21 - A_1.struct29_0.method_2().method_2();
                        if ((A_0 as TextRange).IsIfFieldResultFirstItem)
                        {
                            (A_0 as TextRange).Text = input.Substring(A_1.struct29_0.method_2().method_2(), num3).TrimEnd(new char[0]).Replace(BookmarkStart.b("భ", num), string.Empty);
                        }
                    }
                }
                else if (matchs.Count == 1)
                {
                    if ((A_0 as TextRange).IsIfFieldResultFirstItem && A_1.bool_0)
                    {
                        (A_0 as TextRange).Text = input.Substring(A_1.struct29_0.method_2().method_2()).Trim(new char[] { '"' });
                    }
                    else if (matchs[0].Index == (length - 1))
                    {
                        (A_0 as TextRange).Text = input.Substring(0, length - 1);
                    }
                    else
                    {
                        (A_0 as TextRange).Text = input.Substring(matchs[0].Index + 1);
                    }
                }
            }
        }

        private void method_113(ParagraphBase A_0, ref Field A_1, Stack<Field> A_2, Struct31 A_3)
        {
            if (A_0 is Field)
            {
                A_1 = A_0 as Field;
                A_2.Push(A_0 as Field);
            }
            if (((A_1 != null) && (A_0 is FieldMark)) && ((A_0 as FieldMark).Type == FieldMarkType.FieldSeparator))
            {
                A_1.Separator = A_0 as FieldMark;
            }
            if (((A_1 != null) && (A_0 is FieldMark)) && ((A_0 as FieldMark).Type == FieldMarkType.FieldEnd))
            {
                A_1.End = A_0 as FieldMark;
                if (A_2.Count > 0)
                {
                    A_1 = A_2.Pop();
                }
            }
            else if (A_0 is TextRange)
            {
                this.method_112(A_0, A_3);
            }
        }

        private bool method_114(List<DocumentObject> A_0)
        {
            bool flag = false;
            using (List<DocumentObject>.Enumerator enumerator = A_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = enumerator.Current;
                    if (current is Paragraph)
                    {
                        goto Label_0027;
                    }
                }
                return flag;
            Label_0027:
                flag = true;
            }
            return flag;
        }

        private List<DocumentObject> method_115(List<DocumentObject> A_0)
        {
            List<DocumentObject> list = new List<DocumentObject>();
            for (int i = A_0.Count - 1; i >= 0; i--)
            {
                if (A_0[i] is Paragraph)
                {
                    return list;
                }
                list.Insert(0, A_0[i]);
            }
            return list;
        }

        private void method_116(Paragraph A_0, Body A_1, Struct30 A_2)
        {
            int num = A_2.method_6();
            List<DocumentObject> list = new List<DocumentObject>();
            for (int i = num; i < A_0.Items.Count; i++)
            {
                list.Add(A_0.Items[i]);
            }
            if (list.Count > 0)
            {
                int num4 = (base.Document != null) ? base.Document.ClonedFields.Count : 0;
                int num5 = A_0.method_5();
                Paragraph entity = new Paragraph(base.Document);
                A_1.ChildObjects.Insert(num5 + 1, entity);
                foreach (DocumentObject obj2 in list)
                {
                    entity.ChildObjects.Add(obj2);
                }
                int num6 = (base.Document != null) ? base.Document.ClonedFields.Count : 0;
                int num3 = 0;
                int num7 = num6 - num4;
                while (num3 < num7)
                {
                    base.Document.ClonedFields.Pop();
                    num3++;
                }
            }
            list.Clear();
            list = null;
        }

        private string method_117(string A_0, string A_1)
        {
            return this.method_118(A_0, A_1, true);
        }

        private string method_118(string A_0, string A_1, bool A_2)
        {
            if (A_0.StartsWith(A_1, StringComparison.InvariantCultureIgnoreCase))
            {
                A_0 = A_0.Substring(A_1.Length, A_0.Length - A_1.Length);
                if (A_2)
                {
                    A_0 = A_0.Trim();
                }
            }
            return A_0;
        }

        private List<string> method_119(string A_0)
        {
            int num = 3;
            List<string> list = new List<string>();
            List<string> list2 = new List<string>(new string[] { BookmarkStart.b("ᔨᘪ", 3), BookmarkStart.b("ᜨᘪ", 3), BookmarkStart.b("ᔨᔪ", 3), BookmarkStart.b("ᐨ", 3), BookmarkStart.b("ᔨ", 3), BookmarkStart.b("ᜨ", 3) });
            string str = string.Empty;
            bool flag = false;
            List<int> list3 = this.method_123(list2, A_0);
            try
            {
                while (A_0 != string.Empty)
                {
                    int index = A_0.IndexOf('\x0014');
                    if (A_0.StartsWith(BookmarkStart.b("ନ", num)))
                    {
                        this.method_120(index, ref A_0, ref str);
                    }
                    else
                    {
                        this.method_121(list2, list, list3, flag, ref A_0, ref str);
                    }
                    if (flag && (list.Count == 0))
                    {
                        list.Insert(0, str);
                        str = string.Empty;
                        flag = false;
                    }
                    else if (list.Count > 0)
                    {
                        list.Add(str);
                        str = string.Empty;
                        if (!A_0.StartsWith(BookmarkStart.b("ନ", num)) && A_0.TrimStart(new char[0]).StartsWith(BookmarkStart.b("ନ", num)))
                        {
                            A_0 = A_0.TrimStart(new char[0]);
                        }
                        list.Add(A_0.Trim(new char[] { '"' }));
                        A_0 = string.Empty;
                    }
                    if (list.Count == 0)
                    {
                        flag = this.method_122(list2, ref A_0, ref str);
                    }
                }
            }
            catch
            {
                while (list.Count < 3)
                {
                    list.Add(string.Empty);
                }
                return list;
            }
            return list;
        }

        private void method_120(int A_0, ref string A_1, ref string A_2)
        {
            int num = 4;
            A_1 = A_1.Substring(A_1.IndexOf(BookmarkStart.b("ࠩ", 4)) + 1);
            A_0 = A_1.IndexOf('\x0014');
            if ((A_0 >= 0) && (A_0 < A_1.IndexOf(BookmarkStart.b("ࠩ", num))))
            {
                A_2 = A_2 + this.method_124(ref A_1);
            }
            A_2 = A_2 + A_1.Substring(0, A_1.IndexOf(BookmarkStart.b("ࠩ", num))).Trim(new char[] { ' ' });
            A_1 = A_1.Substring(A_1.IndexOf(BookmarkStart.b("ࠩ", num)) + 1).Trim(new char[] { ' ' });
        }

        private void method_121(List<string> A_0, List<string> A_1, List<int> A_2, bool A_3, ref string A_4, ref string A_5)
        {
            int num = 0x13;
            int num2 = 0;
            while (true)
            {
                if ((num2 >= A_0.Count) || (A_1.Count != 0))
                {
                    break;
                }
                if (A_4.Contains(A_0[num2]) && (A_2[0] == A_4.IndexOf(A_0[num2])))
                {
                    A_5 = A_5 + A_4.Substring(0, A_4.IndexOf(A_0[num2])).Trim(new char[] { ' ' });
                    A_4 = A_4.Substring(A_4.IndexOf(A_0[num2])).Trim(new char[] { ' ' });
                    break;
                }
                num2++;
            }
            if (A_3 || (A_1.Count > 0))
            {
                A_5 = A_5 + A_4.Substring(0, A_4.IndexOf(BookmarkStart.b("ᤸ", num))).Trim(new char[] { ' ' });
                A_4 = A_4.Substring(A_4.IndexOf(BookmarkStart.b("ᤸ", num))).Trim(new char[] { ' ' });
            }
        }

        private bool method_122(List<string> A_0, ref string A_1, ref string A_2)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                if (A_1.StartsWith(A_0[i]))
                {
                    A_2 = A_2 + A_0[i];
                    A_1 = A_1.Substring(A_1.IndexOf(A_0[i]) + A_0[i].Length).Trim();
                    return true;
                }
            }
            return false;
        }

        private List<int> method_123(List<string> A_0, string A_1)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < A_0.Count; i++)
            {
                if (A_1.Contains(A_0[i]))
                {
                    list.Add(A_1.IndexOf(A_0[i]));
                }
            }
            list.Sort();
            return list;
        }

        private string method_124(ref string A_0)
        {
            int num = 9;
            string str = string.Empty;
            for (int i = A_0.IndexOf('\x0014'); i >= 0; i = A_0.IndexOf('\x0014'))
            {
                if (i >= A_0.IndexOf(BookmarkStart.b("മ", num)))
                {
                    return str;
                }
                string str2 = A_0.Substring(0, A_0.IndexOf('\x0015') + 1);
                str = str + str2;
                A_0 = A_0.Substring(A_0.IndexOf('\x0015') + 1);
                int num3 = str2.Split(new char[] { '\x0014' }).Length - 2;
                while (num3 > 0)
                {
                    str = str + A_0.Substring(0, A_0.IndexOf('\x0015') + 1);
                    A_0 = A_0.Substring(A_0.IndexOf('\x0015') + 1);
                }
            }
            return str;
        }

        private string method_125(string A_0)
        {
            int num = 10;
            List<string> list = new List<string>(new string[] { BookmarkStart.b("య༱", 10), BookmarkStart.b("ฯ༱", 10), BookmarkStart.b("యఱ", 10), BookmarkStart.b("യ", 10), BookmarkStart.b("య", 10), BookmarkStart.b("ฯ", 10) });
            string[] strArray2 = A_0.Split(list.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (strArray2.Length > 1)
            {
                strArray2[0] = strArray2[0].Trim(new char[] { '"', ' ' });
                strArray2[1] = strArray2[1].Trim(new char[] { '"', ' ' });
            }
            else if (strArray2.Length == 0)
            {
                strArray2 = new string[] { string.Empty, string.Empty };
            }
            else
            {
                strArray2 = new string[] { strArray2[0], string.Empty };
            }
            string str = BookmarkStart.b("/", num);
            if (strArray2.Length > 1)
            {
                double num2;
                double num3;
                if (!double.TryParse(strArray2[0], out num2))
                {
                    try
                    {
                        string str3 = strArray2[0].Trim();
                        strArray2[0] = this.method_138(strArray2[0].Trim());
                        strArray2[0] = this.method_139(str3, strArray2[0]);
                    }
                    catch (Exception)
                    {
                    }
                }
                if (!double.TryParse(strArray2[1], out num3))
                {
                    try
                    {
                        string str4 = strArray2[1].Trim();
                        strArray2[1] = this.method_138(strArray2[1].Trim());
                        strArray2[1] = this.method_139(str4, strArray2[1]);
                    }
                    catch (Exception)
                    {
                    }
                }
                if (double.TryParse(strArray2[0], out num2) && double.TryParse(strArray2[1], out num3))
                {
                    foreach (string str2 in list)
                    {
                        if (A_0.Contains(str2))
                        {
                            return this.method_132(num2, num3, str2);
                        }
                    }
                    return str;
                }
                if (A_0.Contains(BookmarkStart.b("യ", num)))
                {
                    return ((((!string.IsNullOrEmpty(strArray2[0].Trim()) || !string.IsNullOrEmpty(strArray2[1].Trim())) && (strArray2[0].Trim() == strArray2[1].Trim())) || (strArray2[0] == strArray2[1])) ? BookmarkStart.b("į", num) : BookmarkStart.b("/", num));
                }
                if (A_0.Contains(BookmarkStart.b("యఱ", num)))
                {
                    return ((((!string.IsNullOrEmpty(strArray2[0].Trim()) || !string.IsNullOrEmpty(strArray2[1].Trim())) && (strArray2[0].Trim() != strArray2[1].Trim())) || (strArray2[0] != strArray2[1])) ? BookmarkStart.b("į", num) : BookmarkStart.b("/", num));
                }
                if ((!string.IsNullOrEmpty(strArray2[0]) && !string.IsNullOrEmpty(strArray2[1])) && (strArray2[0] != strArray2[1]))
                {
                    str = BookmarkStart.b("į", num);
                }
            }
            return str;
        }

        private void method_126()
        {
            int num = 10;
            if (!this.IsLocked && !(((Interface1) this).imethod_0() as Class214).method_17())
            {
                string str3 = this.method_137(this.method_177());
                string[] strArray = str3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string str = string.Empty;
                CaptionNumberingFormat number = CaptionNumberingFormat.Number;
                if (strArray.Length > 1)
                {
                    str = strArray[1].ToLower();
                    if (str3.Contains(BookmarkStart.b("焯怱申琵焷礹", num)))
                    {
                        number = CaptionNumberingFormat.Number;
                    }
                    else if (str3.Contains(BookmarkStart.b("焯縱搳縵礷砹礻樽िŁ", num)))
                    {
                        number = CaptionNumberingFormat.Alphabetic;
                    }
                    else if (str3.Contains(BookmarkStart.b("戯崱夳圵嘷", num)))
                    {
                        number = CaptionNumberingFormat.Roman;
                    }
                }
                if (string.IsNullOrEmpty(str))
                {
                    if (!(this is SequenceField))
                    {
                        return;
                    }
                    SequenceField field = this as SequenceField;
                    str = field.CaptionName.ToLower();
                    number = field.NumberFormat;
                }
                if (!string.IsNullOrEmpty(str))
                {
                    int num2 = 1;
                    if (base.Document.LayoutVariables.method_2().ContainsKey(str))
                    {
                        num2 = base.Document.LayoutVariables.method_2()[str] + 1;
                        base.Document.LayoutVariables.method_2()[str] = num2;
                    }
                    else
                    {
                        base.Document.LayoutVariables.method_2().Add(str, num2);
                    }
                    string str2 = string.Empty;
                    switch (number)
                    {
                        case CaptionNumberingFormat.Roman:
                            str2 = this.method_97(num2, FieldNumFormat.UpRoman);
                            break;

                        case CaptionNumberingFormat.Alphabetic:
                            str2 = this.method_97(num2, FieldNumFormat.UpLetter);
                            break;

                        default:
                            str2 = this.method_97(num2, FieldNumFormat.Arabic);
                            break;
                    }
                    this.method_217(str2);
                    (((Interface1) this).imethod_0() as Class214).method_18(true);
                }
            }
        }

        private void method_127()
        {
            int num = 5;
            if (!this.IsLocked && ((!this.bool_28 && !this.bool_29) && !base.Document.LayoutVariables.method_3().Contains(this)))
            {
                string str = string.Empty;
                Match match = new Regex(BookmarkStart.b("पԬĮᬰలᰴᔶ", num)).Match(this.Code);
                if ((match.Length > 0) && !string.IsNullOrEmpty(match.Value.Replace(BookmarkStart.b("प", num), string.Empty)))
                {
                    str = match.Value.Replace(BookmarkStart.b("प", num), string.Empty);
                }
                this.method_128(this, str);
                this.bool_25 = false;
            }
        }

        private void method_128(Field A_0, string A_1)
        {
            if (File.Exists(A_1))
            {
                using (FileStream stream = new FileStream(A_1, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (Document document = new Document(stream))
                    {
                        if (document.Sections.Count > 0)
                        {
                            if (this.Separator == null)
                            {
                                int index = A_0.End.method_5();
                                FieldMark entity = new FieldMark(A_0.Document, FieldMarkType.FieldSeparator);
                                A_0.End.OwnerParagraph.ChildObjects.Insert(index, entity);
                                A_0.Separator = entity;
                            }
                            Struct30 struct3 = this.method_220(A_0.Separator);
                            Struct30 struct2 = this.method_220(A_0.End);
                            Body ownerTextBody = A_0.Separator.OwnerParagraph.OwnerTextBody;
                            Paragraph ownerParagraph = A_0.Separator.OwnerParagraph;
                            if ((A_0.Separator.Owner == A_0.End.Owner) && (((document.Sections.Count > 1) || (document.Sections[0].Body.ChildObjects.Count > 1)) || ((document.Sections[0].Body.ChildObjects.Count == 1) && (document.Sections[0].Body.Paragraphs.Count <= 0))))
                            {
                                this.method_116(ownerParagraph, ownerTextBody, struct2);
                            }
                            struct2 = this.method_220(A_0.End);
                            this.method_129(struct3, struct2, ownerTextBody);
                            this.method_130(struct3, document, ownerTextBody);
                            this.bool_29 = true;
                        }
                    }
                }
            }
        }

        private void method_129(Struct30 A_0, Struct30 A_1, Body A_2)
        {
            List<DocumentObject> list = this.method_224(A_0, A_1, A_2, false, false, true);
            foreach (DocumentObject obj2 in list)
            {
                if ((obj2.Owner != null) && (obj2.Owner.ChildObjects.IndexOf(obj2) > -1))
                {
                    if (obj2.Owner is Paragraph)
                    {
                        (obj2.Owner as Paragraph).Items.Remove(obj2);
                    }
                    else
                    {
                        if (obj2 is Paragraph)
                        {
                            (obj2 as Paragraph).method_59(0, true);
                        }
                        obj2.Owner.ChildObjects.Remove(obj2);
                    }
                }
            }
            list.Clear();
            list = null;
        }

        private void method_130(Struct30 A_0, Document A_1, Body A_2)
        {
            int index = A_0.method_0() + 1;
            int num2 = A_0.method_6() + 1;
            for (int i = 0; i < A_1.Sections.Count; i++)
            {
                Section section = A_1.Sections[i];
                for (int j = 0; j < section.Body.ChildObjects.Count; j++)
                {
                    DocumentObject entity = section.Body.ChildObjects[j].Clone();
                    if ((i == 0) && (j == 0))
                    {
                        if (entity is Table)
                        {
                            A_2.ChildObjects.Insert(index, entity);
                            index++;
                        }
                        else
                        {
                            Paragraph paragraph = A_2.ChildObjects[A_0.method_0()] as Paragraph;
                            Stack<Field> stack = new Stack<Field>();
                            Field item = null;
                            foreach (DocumentObject obj3 in entity.ChildObjects)
                            {
                                DocumentObject obj2 = obj3.Clone();
                                if ((obj3 is Field) && ((obj3 as Field).End != null))
                                {
                                    stack.Push(item);
                                    item = obj2 as Field;
                                }
                                else if (obj2 is FieldMark)
                                {
                                    FieldMark mark = obj2 as FieldMark;
                                    if (mark.Type == FieldMarkType.FieldEnd)
                                    {
                                        if (item != null)
                                        {
                                            item.End = obj2 as FieldMark;
                                        }
                                        if (stack.Count > 0)
                                        {
                                            item = stack.Pop();
                                        }
                                    }
                                    else if (item != null)
                                    {
                                        item.Separator = obj2 as FieldMark;
                                    }
                                }
                                int count = paragraph.ChildObjects.Count;
                                paragraph.ChildObjects.Insert(num2, obj2);
                                if (paragraph.ChildObjects.Count > count)
                                {
                                    num2++;
                                }
                            }
                        }
                    }
                    else
                    {
                        A_2.ChildObjects.Insert(index, entity);
                        index++;
                    }
                }
            }
        }

        private void method_131()
        {
            int num = 0x11;
            if (!this.IsLocked)
            {
                string str = this.method_137(this.method_177());
                str = this.method_118(str.Trim(), BookmarkStart.b("吶嘸嘺䴼帾㍀♂", num), false);
                string str2 = string.Empty;
                try
                {
                    str2 = this.method_125(str);
                }
                catch (Exception)
                {
                    str2 = BookmarkStart.b("父䬸䤺刼䴾恀捂၄⥆≈╊≌㡎㽐獒㩔❖祘㡚㉜㭞Ѡ䍢ͤࡦ᭨䭪๬nὰᝲᱴͶၸᑺ፼Ṿ궂", num);
                }
                this.method_217(str2);
            }
        }

        private string method_132(double A_0, double A_1, string A_2)
        {
            int num = 4;
            double num2 = 0.0;
            string str = A_2;
            if (str != null)
            {
                if (str != BookmarkStart.b("ᜩ", num))
                {
                    if (str != BookmarkStart.b("ᘩ", num))
                    {
                        if (str != BookmarkStart.b("ᘩᄫ", num))
                        {
                            if (str != BookmarkStart.b("ᐩ", num))
                            {
                                if (!(str == BookmarkStart.b("ᐩᄫ", num)))
                                {
                                    if (str == BookmarkStart.b("ᘩራ", num))
                                    {
                                        num2 = (A_0 != A_1) ? ((double) 1) : ((double) 0);
                                    }
                                }
                                else
                                {
                                    num2 = (A_0 >= A_1) ? ((double) 1) : ((double) 0);
                                }
                            }
                            else
                            {
                                num2 = (A_0 > A_1) ? ((double) 1) : ((double) 0);
                            }
                        }
                        else
                        {
                            num2 = (A_0 <= A_1) ? ((double) 1) : ((double) 0);
                        }
                    }
                    else
                    {
                        num2 = (A_0 < A_1) ? ((double) 1) : ((double) 0);
                    }
                }
                else
                {
                    num2 = (A_0 == A_1) ? ((double) 1) : ((double) 0);
                }
            }
            return num2.ToString();
        }

        internal void method_133()
        {
            this.method_134(string.Empty);
        }

        internal void method_134(string A_0)
        {
            int num = 3;
            A_0 = string.IsNullOrEmpty(A_0) ? this.method_137(this.method_177()) : A_0;
            string str = string.Empty;
            if (A_0.Contains(BookmarkStart.b("用ࠪ", num)))
            {
                str = A_0.Substring(A_0.IndexOf(BookmarkStart.b("用ࠪ", num)));
                if (str.IndexOf(BookmarkStart.b("ନ", num)) > -1)
                {
                    str = str.Substring(str.IndexOf(BookmarkStart.b("ନ", num)) + 1);
                }
                if (str.LastIndexOf(BookmarkStart.b("ନ", num)) > -1)
                {
                    str = str.Remove(str.LastIndexOf(BookmarkStart.b("ନ", num))).Trim();
                }
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("用ࠪ", num))).Trim();
            }
            if (A_0.StartsWith(BookmarkStart.b("ᐨ", num)))
            {
                A_0 = A_0.Substring(1).Trim();
            }
            string message = string.Empty;
            try
            {
                message = this.method_138(A_0);
                message = this.method_139(A_0, message);
            }
            catch (Exception exception)
            {
                char ch = '\b';
                if (!A_0.Contains(ch.ToString()))
                {
                    message = exception.Message;
                }
            }
            message = this.method_136(message, str);
            this.method_217(message);
        }

        private float method_135(string A_0)
        {
            if (A_0.ToLower().Contains(BookmarkStart.b("䴧", 2)))
            {
                return Convert.ToSingle(decimal.Parse(A_0, NumberStyles.Float));
            }
            StringBuilder builder = new StringBuilder();
            bool flag = false;
            foreach (char ch in A_0)
            {
                if (char.IsDigit(ch))
                {
                    builder.Append(ch);
                }
                else if (!flag && (ch.ToString() == NumberFormatInfo.CurrentInfo.NumberDecimalSeparator))
                {
                    builder.Append(ch);
                    flag = true;
                }
            }
            return Convert.ToSingle(builder.ToString());
        }

        private string method_136(string A_0, string A_1)
        {
            double num2;
            int num = 8;
            if (A_1.Contains(BookmarkStart.b("爭ጯ", 8)))
            {
                A_1 = A_1.Replace(BookmarkStart.b("爭ጯ", num), string.Empty).Trim();
            }
            bool flag = A_0.Trim().StartsWith(BookmarkStart.b("̭", num));
            if (double.TryParse(A_0, out num2))
            {
                num2 = flag ? -num2 : num2;
                string format = A_1.TrimEnd(new char[] { '%' }).Replace(BookmarkStart.b("ഭ", num), BookmarkStart.b("ḭ", num));
                A_0 = num2.ToString(format);
                int length = A_1.Length;
                if (A_1.Contains(BookmarkStart.b("-", num)))
                {
                    length = A_1.IndexOf(BookmarkStart.b("-", num));
                }
                int index = A_1.IndexOf(BookmarkStart.b("ഭ", num));
                char ch = '(';
                if (A_0.StartsWith(ch.ToString()))
                {
                    index++;
                }
                if (index < 0)
                {
                    index = 0;
                }
                length = Math.Min(length, A_0.Length);
                for (int i = index; i < length; i++)
                {
                    if (char.IsNumber(A_0[i]) && (A_0[i] != '0'))
                    {
                        break;
                    }
                    if (A_1[i] != '0')
                    {
                        if (A_0[i] == '0')
                        {
                            A_0 = A_0.Remove(i, 1);
                            A_0 = A_0.Insert(i, BookmarkStart.b("อ", num));
                        }
                        else
                        {
                            A_0 = A_0.Remove(i, 1);
                            A_1 = A_1.Remove(i, 1);
                            i--;
                            length--;
                        }
                    }
                }
                if (A_1.Contains(BookmarkStart.b("ଭ", num)))
                {
                    A_0 = A_0 + BookmarkStart.b("ଭ", num);
                }
            }
            if (!flag)
            {
                return A_0;
            }
            return (BookmarkStart.b("̭", num) + A_0);
        }

        internal string method_137(string A_0)
        {
            int num = 10;
            if (string.IsNullOrEmpty(A_0))
            {
                return string.Empty;
            }
            if (A_0.Contains(BookmarkStart.b("氯ᠱᐳ笵紷根笻笽ؿുᙃ୅ेṉ", num)))
            {
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("氯ᠱᐳ笵紷根笻笽ؿുᙃ୅ेṉ", num))).Trim();
            }
            else if (A_0.Contains(BookmarkStart.b("氯ᠱᐳ笵崷䠹嬻嬽☿ⵁ㙃⭅⥇㹉", num)))
            {
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("氯ᠱᐳ笵崷䠹嬻嬽☿ⵁ㙃⭅⥇㹉", num))).Trim();
            }
            else if (A_0.Contains(BookmarkStart.b("氯ᠱᐳ电瀷笹渻砽༿၁ृ݅᱇", num)))
            {
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("氯ᠱᐳ电瀷笹渻砽༿၁ृ݅᱇", num))).Trim();
            }
            else if (A_0.Contains(BookmarkStart.b("氯ᠱᐳ电倷嬹主堽⼿ぁ⥃❅㱇", num)))
            {
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("氯ᠱᐳ电倷嬹主堽⼿ぁ⥃❅㱇", num))).Trim();
            }
            return A_0.Trim();
        }

        private string method_138(string A_0)
        {
            double minValue;
            int num = 9;
            if (this.method_169(A_0.ToLower()))
            {
                minValue = this.method_153(A_0);
            }
            else if (this.method_170(A_0))
            {
                minValue = this.method_171(A_0);
            }
            else
            {
                Bookmark bookmark = base.Document.Bookmarks.FindByName(A_0);
                if (bookmark != null)
                {
                    string str = string.Empty;
                    if (bookmark.BookmarkStart.OwnerParagraph == bookmark.BookmarkEnd.OwnerParagraph)
                    {
                        str = bookmark.BookmarkStart.OwnerParagraph.Text.Substring(bookmark.BookmarkStart.EndPos, bookmark.BookmarkEnd.EndPos - bookmark.BookmarkStart.EndPos);
                        str = this.method_135(str).ToString();
                    }
                    double.TryParse(str, out minValue);
                }
                else
                {
                    MatchCollection matchs = new Regex(BookmarkStart.b("ܮ倰儲娴䄶尸䜺弼娾ⵀⱂ㉄㭆㭈≊⩌❎═⽒㥔㉖㽘⽚瑜⍞㽠㡢⑤䩦㍨੪䁬ᕮⱰ奲⥴፶卸卺嵼噾ꮀ릂濾\ud986\ud288쪊ꂌ햎뺒쪖늘잚列뒞", num)).Matches(A_0.ToLower());
                    if (base.OwnerParagraph.IsInCell && (matchs.Count > 0))
                    {
                        minValue = double.MinValue;
                    }
                    else if (!double.TryParse(A_0, out minValue))
                    {
                        throw new Exception(BookmarkStart.b("ฮ搰崲儴制弸刺匼娾╀捂݄⡆♈⁊⁌⹎⍐㡒祔睖", num) + A_0.ToUpper());
                    }
                }
            }
            return minValue.ToString();
        }

        private string method_139(string A_0, string A_1)
        {
            string str = A_1;
            double minValue = double.MinValue;
            if (A_1 == minValue.ToString())
            {
                str = this.method_140(A_0)[0].ToString();
            }
            return str;
        }

        private List<double> method_140(string A_0)
        {
            Regex regex = new Regex(BookmarkStart.b("䜥䨧䔩娫䬭䰯倱儳娵圷䴹䀻䰽⤿╁ⱃ㉅㑇♉⥋⡍⑏", 0), RegexOptions.IgnoreCase);
            List<double> list = new List<double>();
            TableCell owner = base.OwnerParagraph.Owner as TableCell;
            TableRow row = owner.Owner as TableRow;
            Table ownerTable = row.OwnerTable;
            int index = ownerTable.Rows.IndexOf(row);
            int num2 = row.method_25(owner);
            if (!regex.Match(A_0).Success)
            {
                list.AddRange(this.method_141(A_0, ownerTable));
                return list;
            }
            if (list.Count == 0)
            {
                list.AddRange(this.method_145(A_0, index, num2, ownerTable));
            }
            return list;
        }

        private List<double> method_141(string A_0, Table A_1)
        {
            List<double> list = new List<double>();
            string[] strArray = A_0.Split(new char[] { ',' });
            if (strArray.Length > 0)
            {
                foreach (string str in strArray)
                {
                    if (str.Split(new char[] { ':' }).Length == 2)
                    {
                        list.AddRange(this.method_142(str, A_1));
                    }
                    else
                    {
                        Point point = this.method_143(str);
                        list.Add(this.method_146(A_1.Rows[point.X].Cells[point.Y], false));
                    }
                }
                return list;
            }
            if (A_0.Split(new char[] { ':' }).Length > 0)
            {
                list.AddRange(this.method_142(A_0, A_1));
            }
            return list;
        }

        private List<double> method_142(string A_0, Table A_1)
        {
            List<double> list = new List<double>();
            string[] strArray = A_0.Split(new char[] { ':' });
            if (strArray.Length == 2)
            {
                Point point = this.method_143(strArray[0]);
                Point point2 = this.method_143(strArray[1]);
                if (point.X == -1)
                {
                    for (int j = 0; j < A_1.Rows.Count; j++)
                    {
                        list.Add(this.method_146(A_1.Rows[j].Cells[point.Y], false));
                    }
                    return list;
                }
                if (point.Y == -1)
                {
                    for (int k = 0; k < A_1.Rows[point.X].Cells.Count; k++)
                    {
                        list.Add(this.method_146(A_1.Rows[point.X].Cells[k], false));
                    }
                    return list;
                }
                for (int i = point.X; i <= point2.X; i++)
                {
                    for (int m = point.Y; m <= point2.Y; m++)
                    {
                        list.Add(this.method_146(A_1.Rows[i].Cells[m], false));
                    }
                }
            }
            return list;
        }

        private Point method_143(string A_0)
        {
            new Regex(BookmarkStart.b("栵挷笹ᄻ搽ℿ潁㹃ᭅ捇ᙉ⡋敍", 0x10));
            Regex regex = new Regex(BookmarkStart.b("栵挷笹ᄻ搽ℿ潁㹃ᭅ捇", 0x10));
            Regex regex2 = new Regex(BookmarkStart.b("樵尷ᄹ", 0x10));
            Point point = new Point();
            Match match = regex.Match(A_0);
            Match match2 = regex2.Match(A_0);
            int x = string.IsNullOrEmpty(match2.Value) ? -1 : (int.Parse(match2.Value) - 1);
            return new Point(x, string.IsNullOrEmpty(match.Value) ? -1 : this.method_144(match.Value));
        }

        private int method_144(string A_0)
        {
            int num = 0;
            A_0 = A_0.ToUpper();
            for (int i = 0; i < A_0.Length; i++)
            {
                char ch = A_0[i];
                num += (int) Math.Round((double) (((ch - 'A') + 1) * Math.Pow(26.0, (double) ((A_0.Length - i) - 1))));
            }
            return (num - 1);
        }

        private List<double> method_145(string A_0, int A_1, int A_2, Table A_3)
        {
            int num = 5;
            List<double> list = new List<double>();
            string str = A_0.ToUpper();
            if (str == null)
            {
                return list;
            }
            if (str == BookmarkStart.b("未栬椮攰", num))
            {
                return this.method_147(A_1, A_2, A_3);
            }
            if (str == BookmarkStart.b("礪搬栮礰朲", num))
            {
                return this.method_148(A_1, A_2, A_3);
            }
            if (!(str == BookmarkStart.b("横漬怮朰瘲", num)))
            {
                if (str == BookmarkStart.b("椪栬挮縰搲", num))
                {
                    return this.method_149(A_1, A_2, A_3);
                }
                return list;
            }
            return this.method_150(A_1, A_2, A_3);
        }

        private double method_146(TableCell A_0, bool A_1)
        {
            double num = 0.0;
            if ((A_0.ChildObjects.Count == 1) && !A_1)
            {
                Class885.smethod_0(A_0.method_47()[0], out num);
            }
            return num;
        }

        private List<double> method_147(int A_0, int A_1, Table A_2)
        {
            List<double> list = new List<double>();
            double item = 0.0;
            bool flag = false;
            TableCell cell = A_2.Rows[A_0].method_24(A_1);
            for (TableCell cell2 = cell.PreviousSibling as TableCell; cell2 != null; cell2 = cell2.PreviousSibling as TableCell)
            {
                if (!(flag = this.method_151(cell2, cell2 == cell.PreviousSibling)))
                {
                    list.Add(this.method_146(cell2, flag));
                }
                else if (flag)
                {
                    list.Add(item);
                    return list;
                }
            }
            return list;
        }

        private List<double> method_148(int A_0, int A_1, Table A_2)
        {
            List<double> list = new List<double>();
            bool flag = false;
            TableCell cell = A_2.Rows[A_0].method_24(A_1);
            for (TableCell cell2 = cell.NextSibling as TableCell; cell2 != null; cell2 = cell2.PreviousSibling as TableCell)
            {
                if (!(flag = this.method_151(cell2, cell2 == cell.NextSibling)))
                {
                    list.Add(this.method_146(cell2, flag));
                }
                else if (flag)
                {
                    return list;
                }
            }
            return list;
        }

        private List<double> method_149(int A_0, int A_1, Table A_2)
        {
            List<double> list = new List<double>();
            bool flag = false;
            TableRow row1 = A_2.Rows[A_0];
            for (int i = A_0 + 1; i < A_2.Rows.Count; i++)
            {
                TableCell cell = A_2.Rows[i].method_24(A_1);
                if (!(flag = this.method_151(cell, i == (A_0 + 1))))
                {
                    list.Add(this.method_146(cell, flag));
                }
                else if (flag)
                {
                    return list;
                }
            }
            return list;
        }

        private List<double> method_150(int A_0, int A_1, Table A_2)
        {
            List<double> list = new List<double>();
            bool flag = false;
            for (int i = A_0 - 1; i >= 0; i--)
            {
                TableCell cell = A_2.Rows[i].method_24(A_1);
                if (!(flag = this.method_151(cell, i == (A_0 - 1))))
                {
                    list.Add(this.method_146(cell, flag));
                }
                else if (flag)
                {
                    return list;
                }
            }
            return list;
        }

        private bool method_151(TableCell A_0, bool A_1)
        {
            bool flag = false;
            if (A_0.ChildObjects.Count == 1)
            {
                double num2;
                Paragraph paragraph = A_0.ChildObjects[0] as Paragraph;
                if (((paragraph == null) || (paragraph == null)) || !Class885.smethod_0(paragraph.method_31(), out num2))
                {
                    flag = A_1;
                }
            }
            return flag;
        }

        private bool method_152(TableCell A_0)
        {
            bool flag = false;
            bool flag2 = false;
            for (int i = 0; i < A_0.ChildObjects.Count; i++)
            {
                double num2;
                Paragraph paragraph = A_0.ChildObjects[i] as Paragraph;
                if ((paragraph != null) && double.TryParse(paragraph.Text, out num2))
                {
                    if (flag)
                    {
                        return false;
                    }
                    flag = true;
                    flag2 = true;
                }
            }
            return flag2;
        }

        private double method_153(string A_0)
        {
            int num = 0x13;
            string str = A_0.ToLower();
            char ch = '(';
            if (A_0.Contains(ch.ToString()))
            {
                str = A_0.Remove(A_0.IndexOf('(')).ToLower().Trim();
            }
            List<double> list = new List<double>();
            if ((A_0.IndexOf('(') + 1) < A_0.LastIndexOf(')'))
            {
                list = this.method_174(A_0.Substring(A_0.IndexOf('(') + 1, (A_0.LastIndexOf(')') - A_0.IndexOf('(')) - 1));
            }
            else if (!(str == BookmarkStart.b("䴸䤺䠼娾", num)) && !(str == BookmarkStart.b("弸娺儼䰾⑀", num)))
            {
                throw new Exception(BookmarkStart.b("ᠸ栺䐼儾㕀≂㵄杆ై㥊㽌⁎⍐罒畔", num) + ')');
            }
            string key = str;
            if (key != null)
            {
                int num4;
                if (Class1160.dictionary_21 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                    dictionary1.Add(BookmarkStart.b("䤸䤺刼嬾㑀⁂ㅄ", num), 0);
                    dictionary1.Add(BookmarkStart.b("䨸为值", num), 1);
                    dictionary1.Add(BookmarkStart.b("堸䴺堼䴾⁀⑂⁄", num), 2);
                    dictionary1.Add(BookmarkStart.b("吸吺夼", num), 3);
                    dictionary1.Add(BookmarkStart.b("堸夺丼", num), 4);
                    dictionary1.Add(BookmarkStart.b("倸唺䤼", num), 5);
                    dictionary1.Add(BookmarkStart.b("䬸吺䠼儾╀", num), 6);
                    dictionary1.Add(BookmarkStart.b("䨸刺娼儾", num), 7);
                    dictionary1.Add(BookmarkStart.b("娸吺䠼儾㕀", num), 8);
                    dictionary1.Add(BookmarkStart.b("崸帺嬼嘾⽀♂⅄", num), 9);
                    dictionary1.Add(BookmarkStart.b("嘸䤺", num), 10);
                    dictionary1.Add(BookmarkStart.b("堸唺夼", num), 11);
                    dictionary1.Add(BookmarkStart.b("圸吺䤼", num), 12);
                    dictionary1.Add(BookmarkStart.b("吸娺䔼", num), 13);
                    dictionary1.Add(BookmarkStart.b("吸刺匼", num), 14);
                    dictionary1.Add(BookmarkStart.b("䴸䤺䠼娾", num), 15);
                    dictionary1.Add(BookmarkStart.b("弸娺儼䰾⑀", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("倸崺", num), 0x11);
                    Class1160.dictionary_21 = dictionary1;
                }
                if (Class1160.dictionary_21.TryGetValue(key, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                            return this.method_154(list);

                        case 1:
                            return this.method_155(list);

                        case 2:
                            return this.method_156(list);

                        case 3:
                            return this.method_157(list[0], list[1]);

                        case 4:
                            return this.method_158(list[0]);

                        case 5:
                            return this.method_164(list[0]);

                        case 6:
                            return this.method_159(list[0], (int) list[1]);

                        case 7:
                            return this.method_161(list[0]);

                        case 8:
                            return this.method_160(list);

                        case 9:
                        {
                            double num3 = list[0];
                            return this.method_165(num3.ToString());
                        }
                        case 10:
                            return this.method_166((int) list[0], (int) list[1]);

                        case 11:
                            return this.method_167((int) list[0], (int) list[1]);

                        case 12:
                            return this.method_168((int) list[0]);

                        case 13:
                            return this.method_163(list);

                        case 14:
                            return this.method_162(list);

                        case 15:
                            return 1.0;

                        case 0x10:
                            return 0.0;

                        case 0x11:
                            return ((list[0] == 1.0) ? list[1] : list[2]);
                    }
                }
            }
            throw new NotSupportedException(BookmarkStart.b("洸区堼Ἶ⹀㍂⁄㕆⡈㽊⑌⁎㽐", num) + str + BookmarkStart.b("倸䠺ᴼ儾⹀㝂敄㑆㱈㭊㵌⁎⍐❒ご㍖睘", num));
        }

        private double method_154(List<double> A_0)
        {
            double num = 1.0;
            for (int i = 0; i < A_0.Count; i++)
            {
                num *= A_0[i];
            }
            return num;
        }

        private double method_155(List<double> A_0)
        {
            double num = 0.0;
            for (int i = 0; i < A_0.Count; i++)
            {
                num += A_0[i];
            }
            return num;
        }

        private double method_156(List<double> A_0)
        {
            return (this.method_155(A_0) / ((double) A_0.Count));
        }

        private double method_157(double A_0, double A_1)
        {
            return (A_0 % A_1);
        }

        private double method_158(double A_0)
        {
            return Math.Abs(A_0);
        }

        private double method_159(double A_0, int A_1)
        {
            return Math.Round(A_0, A_1);
        }

        private double method_160(List<double> A_0)
        {
            return (double) (A_0.Count - 1);
        }

        private double method_161(double A_0)
        {
            if (A_0 < 0.0)
            {
                return 0.0;
            }
            return 1.0;
        }

        private double method_162(List<double> A_0)
        {
            A_0.Sort();
            return A_0[0];
        }

        private double method_163(List<double> A_0)
        {
            A_0.Sort();
            return A_0[A_0.Count - 1];
        }

        private double method_164(double A_0)
        {
            return Math.Floor(A_0);
        }

        private double method_165(string A_0)
        {
            double num;
            if (double.TryParse(A_0, out num))
            {
                return 1.0;
            }
            return 0.0;
        }

        private double method_166(int A_0, int A_1)
        {
            if ((A_0 | A_1) == 0)
            {
                return 0.0;
            }
            return 1.0;
        }

        private double method_167(int A_0, int A_1)
        {
            if ((A_0 & A_1) == 0)
            {
                return 0.0;
            }
            return 1.0;
        }

        private double method_168(int A_0)
        {
            if (A_0 == 0)
            {
                return 1.0;
            }
            return 0.0;
        }

        private bool method_169(string A_0)
        {
            List<string> list = new List<string>(new string[] { 
                BookmarkStart.b("䤸䤺刼嬾㑀⁂ㅄ", 0x13), BookmarkStart.b("䨸为值", 0x13), BookmarkStart.b("堸䴺堼䴾⁀⑂⁄", 0x13), BookmarkStart.b("吸吺夼", 0x13), BookmarkStart.b("堸夺丼", 0x13), BookmarkStart.b("倸唺䤼", 0x13), BookmarkStart.b("䬸吺䠼儾╀", 0x13), BookmarkStart.b("䨸刺娼儾", 0x13), BookmarkStart.b("娸吺䠼儾㕀", 0x13), BookmarkStart.b("崸帺嬼嘾⽀♂⅄", 0x13), BookmarkStart.b("嘸䤺", 0x13), BookmarkStart.b("堸唺夼", 0x13), BookmarkStart.b("圸吺䤼", 0x13), BookmarkStart.b("吸娺䔼", 0x13), BookmarkStart.b("吸刺匼", 0x13), BookmarkStart.b("䴸䤺䠼娾", 0x13), 
                BookmarkStart.b("弸娺儼䰾⑀", 0x13), BookmarkStart.b("倸崺", 0x13)
             });
            bool flag = false;
            using (List<string>.Enumerator enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    string current = enumerator.Current;
                    if (A_0.StartsWith(current))
                    {
                        goto Label_0150;
                    }
                }
                return flag;
            Label_0150:
                flag = true;
            }
            return flag;
        }

        private bool method_170(string A_0)
        {
            List<string> list = new List<string>(new string[] { BookmarkStart.b("ĩ", 4), BookmarkStart.b("ܩ", 4), BookmarkStart.b(")", 4), BookmarkStart.b("ԩ", 4), BookmarkStart.b("༩", 4), BookmarkStart.b("琩", 4), BookmarkStart.b("ᜩ", 4), BookmarkStart.b("ᘩ", 4), BookmarkStart.b("ᘩᄫ", 4), BookmarkStart.b("ᐩ", 4), BookmarkStart.b("ᐩᄫ", 4), BookmarkStart.b("ᘩራ", 4) });
            bool flag = false;
            using (List<string>.Enumerator enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    string current = enumerator.Current;
                    if (A_0.Contains(current))
                    {
                        goto Label_00E4;
                    }
                }
                return flag;
            Label_00E4:
                flag = true;
            }
            return flag;
        }

        private double method_171(string A_0)
        {
            double num = 0.0;
            List<string> list = new List<string>(new string[] { BookmarkStart.b("ጭ", 8), BookmarkStart.b("ር", 8), BookmarkStart.b("ርയ", 8), BookmarkStart.b("ိ", 8), BookmarkStart.b("ိയ", 8), BookmarkStart.b("ርฯ", 8), BookmarkStart.b("瀭", 8), BookmarkStart.b("ଭ", 8), BookmarkStart.b("ĭ", 8), BookmarkStart.b("Э", 8), BookmarkStart.b("̭", 8), BookmarkStart.b("ԭ", 8) });
            if (A_0.Length < 3)
            {
                return num;
            }
            List<string> list2 = this.method_173(A_0, list);
            foreach (string str in list)
            {
                this.method_172(ref list2, str);
            }
            return double.Parse(list2[0]);
        }

        private void method_172(ref List<string> A_0, string A_1)
        {
            int num = 0x10;
            while (A_0.Contains(A_1))
            {
                int index = A_0.LastIndexOf(A_1);
                double num3 = 0.0;
                string key = A_1;
                if (key != null)
                {
                    int num4;
                    if (Class1160.dictionary_22 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                        dictionary1.Add(BookmarkStart.b("ᴵ", num), 0);
                        dictionary1.Add(BookmarkStart.b("ᬵ", num), 1);
                        dictionary1.Add(BookmarkStart.b("ᰵ", num), 2);
                        dictionary1.Add(BookmarkStart.b("ᤵ", num), 3);
                        dictionary1.Add(BookmarkStart.b("ጵ", num), 4);
                        dictionary1.Add(BookmarkStart.b("栵", num), 5);
                        dictionary1.Add(BookmarkStart.b("ଵ", num), 6);
                        dictionary1.Add(BookmarkStart.b("ਵ", num), 7);
                        dictionary1.Add(BookmarkStart.b("ਵԷ", num), 8);
                        dictionary1.Add(BookmarkStart.b("࠵", num), 9);
                        dictionary1.Add(BookmarkStart.b("࠵Է", num), 10);
                        dictionary1.Add(BookmarkStart.b("ਵط", num), 11);
                        Class1160.dictionary_22 = dictionary1;
                    }
                    if (Class1160.dictionary_22.TryGetValue(key, out num4))
                    {
                        switch (num4)
                        {
                            case 0:
                                num3 = double.Parse(A_0[index - 1]) + double.Parse(A_0[index + 1]);
                                break;

                            case 1:
                                num3 = double.Parse(A_0[index - 1]) - double.Parse(A_0[index + 1]);
                                break;

                            case 2:
                                num3 = double.Parse(A_0[index - 1]) * double.Parse(A_0[index + 1]);
                                break;

                            case 3:
                                num3 = double.Parse(A_0[index - 1]) / double.Parse(A_0[index + 1]);
                                break;

                            case 4:
                                num3 = double.Parse(A_0[index - 1]) % double.Parse(A_0[index + 1]);
                                break;

                            case 5:
                                num3 = Math.Pow(double.Parse(A_0[index - 1]), double.Parse(A_0[index + 1]));
                                break;

                            case 6:
                                num3 = (double.Parse(A_0[index - 1]) == double.Parse(A_0[index + 1])) ? ((double) 1) : ((double) 0);
                                break;

                            case 7:
                                num3 = (double.Parse(A_0[index - 1]) < double.Parse(A_0[index + 1])) ? ((double) 1) : ((double) 0);
                                break;

                            case 8:
                                num3 = (double.Parse(A_0[index - 1]) <= double.Parse(A_0[index + 1])) ? ((double) 1) : ((double) 0);
                                break;

                            case 9:
                                num3 = (double.Parse(A_0[index - 1]) > double.Parse(A_0[index + 1])) ? ((double) 1) : ((double) 0);
                                break;

                            case 10:
                                num3 = (double.Parse(A_0[index - 1]) >= double.Parse(A_0[index + 1])) ? ((double) 1) : ((double) 0);
                                break;

                            case 11:
                                num3 = (double.Parse(A_0[index - 1]) != double.Parse(A_0[index + 1])) ? ((double) 1) : ((double) 0);
                                break;
                        }
                    }
                }
                A_0.RemoveAt(index + 1);
                A_0.RemoveAt(index);
                A_0.RemoveAt(index - 1);
                A_0.Insert(index - 1, num3.ToString());
            }
        }

        private List<string> method_173(string A_0, List<string> A_1)
        {
            int num = 14;
            List<string> list = new List<string>();
            int num2 = 0;
            string str = string.Empty;
            string item = string.Empty;
            for (int i = 0; i < A_0.Length; i++)
            {
                item = string.Empty;
                char ch = A_0[i];
                if (A_1.Contains(ch.ToString()))
                {
                    item = A_0[i].ToString();
                    if (i != (A_0.Length - 1))
                    {
                        char ch3 = A_0[i + 1];
                        if (!(ch3.ToString() == BookmarkStart.b("ळ", num)))
                        {
                            char ch5 = A_0[i + 1];
                            if (!(ch5.ToString() == BookmarkStart.b("ਲ਼", num)))
                            {
                                goto Label_00CE;
                            }
                        }
                        item = item + A_0[i++].ToString();
                    }
                }
            Label_00CE:
                if ((i == (A_0.Length - 1)) && (A_0[i] != ')'))
                {
                    str = str + A_0[i];
                }
                if (A_0[i] == '(')
                {
                    num2++;
                }
                else if (A_0[i] == ')')
                {
                    num2--;
                }
                if ((A_1.Contains(item) && (num2 == 0)) || (i == (A_0.Length - 1)))
                {
                    str = str.Trim();
                    if (!string.IsNullOrEmpty(str))
                    {
                        double num4;
                        if (double.TryParse(str, out num4))
                        {
                            if (((list.Count == 1) && (list[0] == BookmarkStart.b("ᤳ", num))) || (((list.Count > 1) && (list[list.Count - 1] == BookmarkStart.b("ᤳ", num))) && A_1.Contains(list[list.Count - 2])))
                            {
                                string str5 = list[list.Count - 1] + num4.ToString();
                                list[list.Count - 1] = str5;
                            }
                            else
                            {
                                list.Add(num4.ToString());
                            }
                            str = string.Empty;
                        }
                        else
                        {
                            string str4 = str;
                            str = this.method_138(str);
                            str = this.method_139(str4, str);
                            if (!double.TryParse(str, out num4))
                            {
                                throw new Exception(BookmarkStart.b("ᔳ攵䄷吹䠻弽㠿扁Ń㑅㩇╉㹋才灏", num) + str);
                            }
                            if (((list.Count == 1) && (list[0] == BookmarkStart.b("ᤳ", num))) || (((list.Count > 1) && (list[list.Count - 1] == BookmarkStart.b("ᤳ", num))) && A_1.Contains(list[list.Count - 2])))
                            {
                                string str3 = list[list.Count - 1] + num4.ToString();
                                list[list.Count - 1] = str3;
                            }
                            else
                            {
                                list.Add(num4.ToString());
                            }
                            str = string.Empty;
                        }
                    }
                    if ((i != (A_0.Length - 1)) && A_1.Contains(item))
                    {
                        list.Add(item.Trim());
                    }
                }
                else if ((((A_0[i] == '(') && (num2 > 1)) || ((A_0[i] == ')') && (num2 > 0))) || ((A_0[i] != '(') && (A_0[i] != ')')))
                {
                    str = str + A_0[i];
                }
            }
            return list;
        }

        private List<double> method_174(string A_0)
        {
            int num = 2;
            List<double> list = new List<double>();
            int num2 = 0;
            string s = string.Empty;
            for (int i = 0; i < A_0.Length; i++)
            {
                if (i == (A_0.Length - 1))
                {
                    s = s + A_0[i];
                }
                if (A_0[i] == '(')
                {
                    num2++;
                }
                else if (A_0[i] == ')')
                {
                    num2--;
                }
                if (((A_0[i] == ',') && (num2 == 0)) || (i == (A_0.Length - 1)))
                {
                    double num5;
                    s = s.Trim();
                    if (double.TryParse(s, out num5))
                    {
                        list.Add(num5);
                        s = string.Empty;
                    }
                    else
                    {
                        s = this.method_138(s);
                        if (double.TryParse(s, out num5))
                        {
                            list.Add(num5);
                            s = string.Empty;
                        }
                        else
                        {
                            double minValue = double.MinValue;
                            if (!(s == minValue.ToString()))
                            {
                                throw new Exception(BookmarkStart.b("ध礩唫䀭䐯匱䰳ᘵ紷䠹主儽㈿湁摃", num) + s);
                            }
                            list.AddRange(this.method_140(A_0));
                        }
                    }
                }
                else
                {
                    s = s + A_0[i];
                }
            }
            return list;
        }

        private void method_175()
        {
            try
            {
                if (this.End != null)
                {
                    if (base.OwnerParagraph == this.End.OwnerParagraph)
                    {
                        int num2 = this.End.method_5();
                        int num5 = base.method_5();
                        DocumentObject obj2 = (base.OwnerParagraph != null) ? base.OwnerParagraph : base.Owner;
                        for (int i = num5 + 1; i <= num2; i++)
                        {
                            DocumentObject obj3 = obj2.ChildObjects[i];
                            this.class44_0.method_8().Add(obj3);
                        }
                    }
                    else
                    {
                        Struct30 struct2 = this.method_220(this);
                        Struct30 struct3 = this.method_220(this.End);
                        Body ownerTextBody = base.OwnerParagraph.OwnerTextBody;
                        if (struct2.method_0() == struct3.method_0())
                        {
                            int num6 = struct2.method_0();
                            int num7 = struct2.method_6() + 1;
                            int num8 = struct3.method_6();
                            while (num7 <= num8)
                            {
                                DocumentObject obj4 = ownerTextBody.ChildObjects[num6].ChildObjects[num7];
                                this.class44_0.method_8().Add(obj4);
                                num7++;
                            }
                        }
                        else
                        {
                            int num3 = struct2.method_0();
                            int num4 = struct3.method_0();
                            while (num3 <= num4)
                            {
                                if (num3 == struct2.method_0())
                                {
                                    int num9 = struct2.method_6() + 1;
                                    int count = ownerTextBody.ChildObjects[num3].ChildObjects.Count;
                                    while (num9 < count)
                                    {
                                        DocumentObject obj6 = ownerTextBody.ChildObjects[num3].ChildObjects[num9];
                                        this.class44_0.method_8().Add(obj6);
                                        num9++;
                                    }
                                }
                                else
                                {
                                    DocumentObject obj5 = ownerTextBody.ChildObjects[num3];
                                    this.class44_0.method_8().Add(obj5);
                                }
                                num3++;
                            }
                        }
                    }
                    this.bool_25 = true;
                    this.bool_26 = true;
                }
                else if (this.class44_0 != null)
                {
                    this.class44_0.method_8().Clear();
                }
            }
            catch (Exception)
            {
                this.class44_0.method_8().Clear();
            }
        }

        private bool method_176()
        {
            bool flag;
            this.bool_26 = false;
            using (IEnumerator enumerator = this.Range.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if (current.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Field)
                    {
                        goto Label_0038;
                    }
                }
                return false;
            Label_0038:
                flag = true;
            }
            return flag;
        }

        internal string method_177()
        {
            if (this.class883_0 != null)
            {
                this.class883_0.System.IDisposable.Dispose();
            }
            this.class883_0 = new Class883(this);
            return this.method_178();
        }

        private string method_178()
        {
            string code = this.Code;
            string str2 = code;
            int index = base.method_28().Items.IndexOf(this);
            int num2 = base.method_28().Owner.ChildObjects.IndexOf(base.method_28());
            this.bool_30 = false;
            this.bool_31 = false;
            this.stack_1.Clear();
            this.NestedFieldCodeObjects.method_9(code, new Struct30(num2, index));
            for (int i = 0; i < this.Range.method_8().Count; i++)
            {
                DocumentObject obj3 = this.Range.method_8()[i] as DocumentObject;
                if ((obj3 is Paragraph) && (obj3.Owner == null))
                {
                    ICompositeObject owner = base.Owner as ICompositeObject;
                    if (owner != null)
                    {
                        int num7 = -1;
                        int num6 = -1;
                        if (base.Owner.Owner != null)
                        {
                            num7 = (base.Owner.Owner as ICompositeObject).ChildObjects.IndexOf(base.Owner);
                        }
                        int num5 = owner.ChildObjects.IndexOf(this.Range.method_10());
                        if (this.Range.method_10() is ParagraphBase)
                        {
                            num6 = num7;
                        }
                        else if (this.Range.method_10() is Paragraph)
                        {
                            Paragraph entity = this.Range.method_10() as Paragraph;
                            num5 = entity.Items.IndexOf(this.End);
                            num6 = entity.Owner.ChildObjects.IndexOf(entity);
                        }
                        this.NestedFieldCodeObjects.method_1(new Struct30(num6, num5));
                    }
                    continue;
                }
                if (obj3 is ParagraphBase)
                {
                    string str3 = this.method_181(obj3);
                    code = code + str3;
                    if (str2 != code)
                    {
                        index = base.OwnerParagraph.Items.IndexOf(obj3);
                        this.NestedFieldCodeObjects.method_9(str3, new Struct30(num2, index));
                        str2 = code;
                    }
                    if ((obj3 is Field) && ((obj3 as Field).Type == FieldType.FieldIncludeText))
                    {
                        this.bool_25 = false;
                        this.IncludeTextFieldInIfFieldList.Add(obj3 as Field);
                    }
                }
                else if (obj3 is Paragraph)
                {
                    Paragraph paragraph2 = obj3 as Paragraph;
                    num2 = paragraph2.Owner.ChildObjects.IndexOf(paragraph2);
                    index = 0;
                    bool flag = paragraph2 == this.Range.method_10();
                    for (int j = 0; j < paragraph2.Items.Count; j++)
                    {
                        DocumentObject obj2 = paragraph2.Items[j];
                        string str5 = this.method_181(obj2);
                        code = code + str5;
                        if (str2 != code)
                        {
                            index = paragraph2.Items.IndexOf(obj2);
                            this.NestedFieldCodeObjects.method_9(str5, new Struct30(num2, index));
                            str2 = code;
                        }
                        if ((obj2 is Field) && ((obj2 as Field).Type == FieldType.FieldIncludeText))
                        {
                            this.bool_25 = false;
                            this.IncludeTextFieldInIfFieldList.Add(obj2 as Field);
                        }
                        if (flag && (obj2 == this.End))
                        {
                            break;
                        }
                    }
                }
                else
                {
                    string str4 = this.method_179(obj3);
                    code = code + str4;
                    if (str2 != code)
                    {
                        if (obj3 is Table)
                        {
                            num2 = obj3.Owner.ChildObjects.IndexOf(obj3);
                            this.NestedFieldCodeObjects.method_9(str4, new Struct30(num2, 0));
                        }
                        else
                        {
                            index = base.OwnerParagraph.Items.IndexOf(obj3);
                            this.NestedFieldCodeObjects.method_8(str4, index);
                        }
                        str2 = code;
                    }
                }
                this.NestedFieldCodeObjects.method_1(new Struct30(num2, index));
                if (this.bool_30)
                {
                    this.NestedFieldCodeObjects.method_3(true);
                    break;
                }
            }
            this.bool_30 = false;
            this.bool_31 = false;
            this.bool_25 = false;
            this.stack_1.Clear();
            return code;
        }

        private string method_179(DocumentObject A_0)
        {
            int num = 3;
            string str = string.Empty;
            if (A_0 is Paragraph)
            {
                for (int i = 0; i < (A_0 as Paragraph).Items.Count; i++)
                {
                    str = str + this.method_181((A_0 as Paragraph).Items[i]);
                    if (this.bool_30)
                    {
                        return str;
                    }
                }
                if (!this.bool_31)
                {
                    str = str + BookmarkStart.b("␨", num);
                }
                return str;
            }
            if ((A_0 is Table) && !this.bool_31)
            {
                object obj2 = str;
                str = string.Concat(new object[] { obj2, '\x0014', this.method_180(A_0), '\x0015' });
            }
            return str;
        }

        private string method_180(DocumentObject A_0)
        {
            int num = 1;
            string str = string.Empty;
            for (int i = 0; i < (A_0 as Table).Rows.Count; i++)
            {
                TableRow row = (A_0 as Table).Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    TableCell cell = row.Cells[j];
                    for (int k = 0; k < cell.Items.Count; k++)
                    {
                        str = str + this.method_179(cell.Items[k]);
                        if (this.bool_30)
                        {
                            return str;
                        }
                    }
                    if (!this.bool_31)
                    {
                        str = str + BookmarkStart.b("…", num);
                    }
                }
                if (!this.bool_31)
                {
                    str = str + BookmarkStart.b("⨦⸨", num);
                }
            }
            return str;
        }

        private string method_181(DocumentObject A_0)
        {
            int num = 11;
            string fieldResult = string.Empty;
            if (!this.bool_30)
            {
                if ((A_0 is Field) && !this.bool_31)
                {
                    Field item = A_0 as Field;
                    if (item.Type == FieldType.FieldMergeField)
                    {
                        return item.Text;
                    }
                    if (item.End != null)
                    {
                        this.stack_1.Push(this.field_0);
                        this.stack_2.Push(this.bool_31);
                        this.field_0 = item;
                        if ((item.Type != FieldType.FieldQuote) && (item.Type != FieldType.FieldIncludeText))
                        {
                            this.bool_31 = true;
                        }
                        else
                        {
                            this.bool_31 = false;
                        }
                    }
                    if (!base.Document.LayoutVariables.method_3().Contains(item) || this.bool_28)
                    {
                        item.method_48(this.bool_28);
                    }
                    fieldResult = item.FieldResult;
                    if ((item.Type == FieldType.FieldAsk) && string.IsNullOrEmpty(fieldResult))
                    {
                        fieldResult = '\x0013'.ToString();
                    }
                    return fieldResult;
                }
                if (this.Separator == A_0)
                {
                    this.bool_30 = true;
                    return fieldResult;
                }
                if ((this.field_0 != null) && (this.field_0.End == A_0))
                {
                    if (this.stack_1.Count > 0)
                    {
                        this.field_0 = this.stack_1.Pop();
                    }
                    if (this.stack_2.Count > 0)
                    {
                        this.bool_31 = this.stack_2.Pop();
                    }
                    return fieldResult;
                }
                if ((A_0 is TextRange) && !this.bool_31)
                {
                    fieldResult = (A_0 as TextRange).Text;
                    if (((this.field_0 != null) && (this.field_0.Type == FieldType.FieldQuote)) && fieldResult.Contains(BookmarkStart.b("ጰ", num)))
                    {
                        fieldResult = fieldResult.Replace(BookmarkStart.b("ጰ", num), string.Empty);
                    }
                    return fieldResult;
                }
                if ((A_0 is Symbol) && !this.bool_31)
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append((char) (A_0 as Symbol).CharacterCode);
                    fieldResult = builder.ToString();
                    builder = null;
                    return fieldResult;
                }
                if ((((A_0 is DocPicture) || (A_0 is ShapeObject)) || ((A_0 is Class6) && ((A_0 as Class6).method_32() != null))) && !this.bool_31)
                {
                    fieldResult = '\b'.ToString();
                }
            }
            return fieldResult;
        }

        internal string method_182()
        {
            string str = string.Empty;
            if (((this.Separator != null) && (this.Separator.OwnerParagraph != null)) && ((this.End != null) && (this.End.OwnerParagraph != null)))
            {
                int index = 0;
                if ((this.Range.method_8().Count == 0) && !this.bool_25)
                {
                    this.method_175();
                }
                if (this.Separator.OwnerParagraph == base.OwnerParagraph)
                {
                    index = this.Range.method_8().IndexOf(this.Separator) + 1;
                }
                else
                {
                    index = this.Range.method_8().IndexOf(this.Separator.OwnerParagraph);
                }
                for (int i = index; i < this.Range.method_8().Count; i++)
                {
                    DocumentObject obj2 = this.Range.method_8()[i] as DocumentObject;
                    if (obj2 is Paragraph)
                    {
                        int num = 0;
                        int num2 = (obj2 as Paragraph).Items.Count - 1;
                        if (this.Separator.OwnerParagraph == obj2)
                        {
                            num = this.Separator.method_5() + 1;
                        }
                        if (this.End.OwnerParagraph == obj2)
                        {
                            num2 = this.End.method_5() - 1;
                        }
                        str = str + (obj2 as Paragraph).method_76(num, num2);
                        if (this.End.OwnerParagraph != obj2)
                        {
                            str = str + Class816.string_27;
                        }
                        if (num2 < ((obj2 as Paragraph).Items.Count - 1))
                        {
                            str = str + (obj2 as Paragraph).method_76(num2 + 1, (obj2 as Paragraph).Items.Count - 1) + Class816.string_27;
                            base.Document.bodyRegion_0 = this.End.OwnerParagraph;
                        }
                    }
                    else if (obj2 is Table)
                    {
                        str = str + (obj2 as Table).method_40();
                    }
                    else if (obj2 is MergeField)
                    {
                        str = str + (obj2 as TextRange).Text;
                    }
                    else if (obj2 is TextRange)
                    {
                        str = str + (obj2 as TextRange).Text;
                    }
                    else if (obj2 is Break)
                    {
                        str = str + Class816.string_27;
                    }
                }
            }
            return str;
        }

        internal Class44 method_183(Paragraph A_0)
        {
            Class44 class2 = new Class44(base.Document, this);
            if (this.End != null)
            {
                int index = A_0.Items.IndexOf(this);
                if (index <= -1)
                {
                    return class2;
                }
                for (int i = index + 1; i < A_0.Items.Count; i++)
                {
                    DocumentObject obj2 = A_0.Items[i];
                    if ((obj2 is Field) || (obj2 is FieldMark))
                    {
                        return class2;
                    }
                    if (obj2 is TextRange)
                    {
                        class2.method_8().Add(obj2);
                    }
                }
            }
            return class2;
        }

        internal string method_184(Paragraph A_0)
        {
            Class44 class2 = this.method_183(A_0);
            string str = string.Empty;
            foreach (DocumentObject obj2 in class2.method_8())
            {
                str = str + (obj2 as TextRange).Text;
            }
            return str;
        }

        private void method_185(string A_0)
        {
            Match match = regex_0.Match(A_0.Trim());
            if (match.Groups[2].Length == 0)
            {
                this.m_fieldValue = match.Groups[1].Value;
            }
            else
            {
                this.m_fieldValue = match.Groups[2].Value;
            }
        }

        private void method_186(string A_0, int A_1)
        {
            int num = 0;
            A_1 += 2;
            if (A_0.Length > A_1)
            {
                string str = A_0.Substring(A_1, A_0.Length - A_1).Trim();
                int index = str.IndexOf(BookmarkStart.b("Х", num));
                if (index != -1)
                {
                    int num3 = str.IndexOf(BookmarkStart.b("Х", num), (int) (index + 1));
                    if (num3 != -1)
                    {
                        this.string_14 = str.Substring(index, (num3 + 1) - index);
                    }
                }
            }
        }

        private void method_187()
        {
            if (!base.Document.bool_3)
            {
                this.string_15 = string.Empty;
            }
        }

        private string method_188(string A_0, int A_1)
        {
            int num = 1;
            A_0 = A_0.Remove(0, A_1 + 2).Trim();
            if (A_0.StartsWith(BookmarkStart.b("Ԧ", 1)) && A_0.EndsWith(BookmarkStart.b("Ԧ", num)))
            {
                int index = A_0.IndexOf(BookmarkStart.b("Ԧ", num));
                if (index > -1)
                {
                    A_0 = A_0.Remove(0, index + 1);
                }
                int startIndex = A_0.LastIndexOf(BookmarkStart.b("Ԧ", num));
                if (startIndex > -1)
                {
                    A_0 = A_0.Remove(startIndex);
                }
            }
            return A_0;
        }

        private string method_189(string A_0, out bool A_1)
        {
            int num = 0x13;
            A_1 = false;
            if (A_0.Contains(BookmarkStart.b("堸嘺ሼ伾ⱀ", 0x13)))
            {
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("堸嘺ሼ伾ⱀ", num)), A_0.Length - A_0.IndexOf(BookmarkStart.b("堸嘺ሼ伾ⱀ", num)));
                A_1 = true;
            }
            if (A_0.Contains(BookmarkStart.b("砸瘺ሼ漾ీ", num)))
            {
                A_0 = A_0.Remove(A_0.IndexOf(BookmarkStart.b("砸瘺ሼ漾ీ", num)), A_0.Length - A_0.IndexOf(BookmarkStart.b("砸瘺ሼ漾ీ", num)));
                A_1 = true;
            }
            return A_0;
        }

        private string method_190(string A_0, DateTime A_1)
        {
            int num = 1;
            if (A_1.ToString().Contains(BookmarkStart.b("昦搨", 1)))
            {
                A_0 = A_0 + BookmarkStart.b("昦搨", num);
                return A_0;
            }
            A_0 = A_0 + BookmarkStart.b("眦搨", num);
            return A_0;
        }

        private string method_191(string A_0, DateTime A_1)
        {
            int num = 0;
            string str = string.Empty;
            int num2 = 0;
            while (num2 < A_0.Length)
            {
                char ch = A_0[num2];
                if (((ch == 'D') || (ch == 'd')) && ((A_0.Length == 1) || (((num2 + 1) < A_0.Length) && (((A_0[num2 + 1] == 'D') || (A_0[num2 + 1] == 'd')) || (char.IsPunctuation(A_0[num2 + 1]) || char.IsWhiteSpace(A_0[num2 + 1]))))))
                {
                    goto Label_0203;
                }
                if (ch == 'M')
                {
                    while (num2 < A_0.Length)
                    {
                        if (A_0[num2] != 'M')
                        {
                            break;
                        }
                        num2++;
                        num++;
                    }
                    str = this.method_193(str, A_1, num);
                    num = 0;
                    continue;
                }
                switch (ch)
                {
                    case 'Y':
                    case 'y':
                        goto Label_01CC;

                    case 'h':
                    case 'H':
                        goto Label_0195;

                    default:
                        if (ch != 'm')
                        {
                            goto Label_010E;
                        }
                        while (num2 < A_0.Length)
                        {
                            if (A_0[num2] != 'm')
                            {
                                break;
                            }
                            num2++;
                            num++;
                        }
                        break;
                }
                str = this.method_198(str, A_1, num);
                num = 0;
                continue;
            Label_010E:
                if (ch == 's')
                {
                    while (num2 < A_0.Length)
                    {
                        if (A_0[num2] != 's')
                        {
                            break;
                        }
                        num2++;
                        num++;
                    }
                    str = this.method_199(str, A_1, num);
                    num = 0;
                    continue;
                }
                if ((ch != '\'') && (ch != '\\'))
                {
                    str = str + A_0[num2];
                    num2++;
                }
                else
                {
                    num2++;
                }
                continue;
            Label_0175:
                if ((A_0[num2] != 'h') && (A_0[num2] != 'H'))
                {
                    goto Label_019E;
                }
                num2++;
                num++;
            Label_0195:
                if (num2 < A_0.Length)
                {
                    goto Label_0175;
                }
            Label_019E:
                str = this.method_197(str, A_1, num);
                num = 0;
                continue;
            Label_01AC:
                if ((A_0[num2] != 'y') && (A_0[num2] != 'Y'))
                {
                    goto Label_01D5;
                }
                num2++;
                num++;
            Label_01CC:
                if (num2 < A_0.Length)
                {
                    goto Label_01AC;
                }
            Label_01D5:
                str = this.method_196(str, A_1, num);
                num = 0;
                continue;
            Label_01E3:
                if ((A_0[num2] != 'd') && (A_0[num2] != 'D'))
                {
                    goto Label_020C;
                }
                num2++;
                num++;
            Label_0203:
                if (num2 < A_0.Length)
                {
                    goto Label_01E3;
                }
            Label_020C:
                str = this.method_192(str, A_1, num);
                num = 0;
            }
            return str;
        }

        private string method_192(string A_0, DateTime A_1, int A_2)
        {
            int num = 0x13;
            string str = string.Empty;
            switch (A_2)
            {
                case 1:
                    str = A_1.Day.ToString();
                    break;

                case 2:
                    if (Convert.ToInt16(A_1.Day.ToString()) >= 10)
                    {
                        str = A_1.Day.ToString();
                        break;
                    }
                    str = BookmarkStart.b("स", num) + A_1.Day.ToString();
                    break;

                case 3:
                    str = A_1.DayOfWeek.ToString().Remove(3, A_1.Day.ToString().Length);
                    break;

                case 4:
                {
                    int index = Convert.ToInt32(A_1.DayOfWeek);
                    string[] strArray = this.method_195(this.CharacterFormat.LocaleIdASCII);
                    if ((strArray == null) || (index >= strArray.Length))
                    {
                        str = A_1.DayOfWeek.ToString();
                        break;
                    }
                    str = strArray[index];
                    break;
                }
                default:
                    str = A_1.DayOfWeek.ToString();
                    break;
            }
            A_0 = A_0 + str;
            return A_0;
        }

        private string method_193(string A_0, DateTime A_1, int A_2)
        {
            int num = 8;
            string name = string.Empty;
            switch (A_2)
            {
                case 1:
                    name = A_1.Month.ToString();
                    break;

                case 2:
                    if (Convert.ToInt16(A_1.Month.ToString()) >= 10)
                    {
                        name = A_1.Month.ToString();
                        break;
                    }
                    name = BookmarkStart.b("ḭ", num) + A_1.Month.ToString();
                    break;

                case 3:
                    name = Enum.GetName(typeof(Month), Convert.ToInt32(A_1.Month.ToString())).Substring(0, 3);
                    break;

                case 4:
                {
                    int num4 = Convert.ToInt32(A_1.Month.ToString());
                    string[] strArray = this.method_194(this.CharacterFormat.LocaleIdASCII);
                    if ((strArray == null) || ((num4 - 1) >= strArray.Length))
                    {
                        name = Enum.GetName(typeof(Month), num4);
                        break;
                    }
                    name = strArray[num4 - 1];
                    break;
                }
                default:
                    name = Enum.GetName(typeof(Month), Convert.ToInt32(A_1.Month.ToString()));
                    break;
            }
            A_0 = A_0 + name;
            return A_0;
        }

        private string[] method_194(int A_0)
        {
            int num = 2;
            string[] strArray = null;
            if (this.CharacterFormat == null)
            {
                return strArray;
            }
            string name = ((LocaleIDs) A_0).ToString();
            if (this.CharacterFormat.LocaleIdASCII == 0x40a)
            {
                int index = name.IndexOf('_');
                if (index > -1)
                {
                    name = name.Remove(index, 1).Insert(index, BookmarkStart.b("ԧ", num));
                }
            }
            else
            {
                name = name.Replace('_', '-');
            }
            CultureInfo info = new CultureInfo(name);
            return info.DateTimeFormat.MonthNames;
        }

        private string[] method_195(int A_0)
        {
            int num = 2;
            string[] strArray = null;
            if (this.CharacterFormat == null)
            {
                return strArray;
            }
            string name = ((LocaleIDs) A_0).ToString();
            if (this.CharacterFormat.LocaleIdASCII == 0x40a)
            {
                int index = name.IndexOf('_');
                if (index > -1)
                {
                    name = name.Remove(index, 1).Insert(index, BookmarkStart.b("ԧ", num));
                }
            }
            else
            {
                name = name.Replace('_', '-');
            }
            CultureInfo info = new CultureInfo(name);
            return info.DateTimeFormat.DayNames;
        }

        private string method_196(string A_0, DateTime A_1, int A_2)
        {
            string str = string.Empty;
            switch (A_2)
            {
                case 1:
                    str = A_1.Year.ToString().Remove(0, 2);
                    break;

                case 2:
                    str = A_1.Year.ToString().Remove(0, 2);
                    break;

                case 4:
                    str = A_1.Year.ToString();
                    break;

                default:
                    str = A_1.Year.ToString();
                    break;
            }
            A_0 = A_0 + str;
            return A_0;
        }

        private string method_197(string A_0, DateTime A_1, int A_2)
        {
            int num = 3;
            string str = string.Empty;
            switch (A_2)
            {
                case 1:
                    str = A_1.Hour.ToString();
                    break;

                case 2:
                    if (Convert.ToInt16(A_1.Hour.ToString()) >= 10)
                    {
                        str = A_1.Hour.ToString();
                        break;
                    }
                    str = BookmarkStart.b("ᤨ", num) + A_1.Hour.ToString();
                    break;

                default:
                    str = A_1.Hour.ToString();
                    break;
            }
            A_0 = A_0 + str;
            return A_0;
        }

        private string method_198(string A_0, DateTime A_1, int A_2)
        {
            int num = 12;
            string str = string.Empty;
            switch (A_2)
            {
                case 1:
                    str = A_1.Minute.ToString();
                    break;

                case 2:
                    if (Convert.ToInt16(A_1.Minute.ToString()) >= 10)
                    {
                        str = A_1.Minute.ToString();
                        break;
                    }
                    str = BookmarkStart.b("ȱ", num) + A_1.Minute.ToString();
                    break;

                default:
                    str = A_1.Minute.ToString();
                    break;
            }
            A_0 = A_0 + str;
            return A_0;
        }

        private string method_199(string A_0, DateTime A_1, int A_2)
        {
            int num = 9;
            string str = string.Empty;
            switch (A_2)
            {
                case 1:
                    str = A_1.Second.ToString();
                    break;

                case 2:
                    if (Convert.ToInt16(A_1.Second.ToString()) >= 10)
                    {
                        str = A_1.Second.ToString();
                        break;
                    }
                    str = BookmarkStart.b("Ἦ", num) + A_1.Second.ToString();
                    break;

                default:
                    str = A_1.Second.ToString();
                    break;
            }
            A_0 = A_0 + str;
            return A_0;
        }

        private void method_200(string A_0)
        {
            Paragraph ownerParagraph = base.OwnerParagraph;
            int num = base.method_5();
            ParagraphBase base2 = ownerParagraph.Items[++num];
            if ((base2 is FieldMark) && ((base2 as FieldMark).Type == FieldMarkType.FieldSeparator))
            {
                base2 = ownerParagraph.Items[++num];
                if (base2 is TextRange)
                {
                    (base2 as TextRange).Text = A_0;
                    while (ownerParagraph.Items[++num] is TextRange)
                    {
                        ownerParagraph.Items.Remove(ownerParagraph.Items[num]);
                    }
                }
            }
        }

        private void method_201(string A_0, string A_1)
        {
            this.FieldResult = A_1;
            if ((base.OwnerParagraph != null) && (this.End != null))
            {
                this.method_203();
                this.method_213();
                this.method_204(A_1);
                if (this.list_2.Count == 0)
                {
                    this.End.OwnerParagraph.Items.Insert(this.End.method_5(), this.method_219(A_1));
                }
                else if (base.OwnerParagraph == this.End.OwnerParagraph)
                {
                    for (int i = 0; i < this.list_2.Count; i++)
                    {
                        base.OwnerParagraph.Items.Insert(this.End.method_5(), this.list_2[i]);
                    }
                }
                else
                {
                    this.method_202(A_1);
                }
                this.list_2.Clear();
                this.bool_25 = false;
            }
        }

        private void method_202(string A_0)
        {
            int num = 6;
            int num4 = (this.Range.method_8().Count > 0) ? (this.Range.method_8().Count - 1) : 0;
            Paragraph paragraph = this.Range.method_8()[num4] as Paragraph;
            for (int i = 0; i < this.list_2.Count; i++)
            {
                DocumentObject entity = this.list_2[i];
                if (entity is Body)
                {
                    if (((entity is Paragraph) && (i == (this.list_2.Count - 1))) && !A_0.EndsWith(BookmarkStart.b("Å", num)))
                    {
                        for (int j = 0; j < (entity as Paragraph).Items.Count; j++)
                        {
                            paragraph.Items.Insert(j, (entity as Paragraph).Items[j].Clone());
                        }
                    }
                    else if (((entity is Paragraph) && (i == 0)) && !A_0.StartsWith(BookmarkStart.b("Å", num)))
                    {
                        for (int k = 0; k < (entity as Paragraph).Items.Count; k++)
                        {
                            this.Separator.OwnerParagraph.Items.Add((entity as Paragraph).Items[k].Clone());
                        }
                    }
                    else
                    {
                        paragraph.OwnerTextBody.Items.Insert(paragraph.method_5(), entity);
                    }
                }
                else if (entity is ParagraphBase)
                {
                    this.Separator.OwnerParagraph.Items.Add(entity);
                }
            }
        }

        private void method_203()
        {
            int num = 0x10;
            if (this.Separator != null)
            {
                if (this.Separator.NextSibling != null)
                {
                    this.characterFormat_0 = new CharacterFormat(base.Document);
                    if (!this.Code.ToLower().Contains(BookmarkStart.b("嬵崷䠹嬻嬽☿ⵁ㙃⭅⥇㹉", num)) && (this.Type != FieldType.FieldUnknown))
                    {
                        this.characterFormat_0.method_73(this.CharacterFormat);
                    }
                    else
                    {
                        this.characterFormat_0.method_73((this.Separator.NextSibling as ParagraphBase).CharacterFormat);
                    }
                }
            }
            else
            {
                FieldMark entity = new FieldMark(base.Document, FieldMarkType.FieldSeparator) {
                    IsAddForIfField = base.IsAddForIfField
                };
                if (base.OwnerParagraph == this.End.OwnerParagraph)
                {
                    base.OwnerParagraph.Items.Insert(this.End.method_5(), entity);
                }
                else
                {
                    Paragraph paragraph = this.End.OwnerParagraph.Clone() as Paragraph;
                    paragraph.method_57();
                    int index = this.End.OwnerParagraph.method_5();
                    this.End.OwnerParagraph.OwnerTextBody.Items.Insert(index, paragraph);
                    int count = this.End.OwnerParagraph.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (this.End == this.End.OwnerParagraph.Items[0])
                        {
                            break;
                        }
                        paragraph.Items.Add(this.End.OwnerParagraph.Items[0]);
                    }
                    paragraph.Items.Add(entity);
                }
                this.Separator = entity;
                this.bool_25 = false;
            }
        }

        private void method_204(string A_0)
        {
            int num = 0x10;
            this.list_2.Clear();
            if (A_0 != string.Empty)
            {
                int index = this.method_177().IndexOf(A_0);
                string str4 = string.Empty;
                int num3 = this.method_212(index, ref str4);
                string str = string.Empty;
                string str3 = A_0;
                if (str3.Length < str4.Length)
                {
                    str4 = str3;
                }
                string str2 = string.Empty;
                this.bool_30 = false;
                this.bool_31 = false;
                this.stack_1.Clear();
                for (int i = num3; i < (this.Range.method_8().Count - 1); i++)
                {
                    DocumentObject obj3 = this.Range.method_8()[i] as DocumentObject;
                    if (obj3 is ParagraphBase)
                    {
                        str2 = this.method_181(obj3);
                    }
                    else
                    {
                        str2 = this.method_179(obj3);
                    }
                    DocumentObject item = null;
                    DocumentObject obj4 = null;
                    if ((i == num3) && (str4 != string.Empty))
                    {
                        str = str + str4;
                        if (str4.Contains(BookmarkStart.b("㬵", num)))
                        {
                            str4 = str4.Replace(BookmarkStart.b("㬵", num), string.Empty);
                        }
                        item = this.method_205(obj3, str4, ref obj4);
                    }
                    else if (A_0.Length < (str + str2).Length)
                    {
                        str = str + str3;
                        item = this.method_205(obj3, str3, ref obj4);
                    }
                    else
                    {
                        str = str + str2;
                        item = this.method_205(obj3, null, ref obj4);
                    }
                    if (item != null)
                    {
                        this.list_2.Add(item);
                    }
                    str3 = A_0.Substring(str.Length);
                    if (obj4 != null)
                    {
                        i = this.Range.method_8().IndexOf(obj4);
                        this.stack_1.Clear();
                        this.bool_31 = false;
                        obj4 = null;
                    }
                    if (str == A_0)
                    {
                        break;
                    }
                }
                this.bool_30 = false;
                this.bool_31 = false;
                this.stack_1.Clear();
            }
        }

        private DocumentObject method_205(DocumentObject A_0, string A_1, ref DocumentObject A_2)
        {
            if (A_0 is ParagraphBase)
            {
                return this.method_208(A_0, A_1, ref A_2);
            }
            if (A_0 is Paragraph)
            {
                List<DocumentObject> list = this.method_209(A_0, A_1, ref A_2);
                for (int i = 0; i < (list.Count - 1); i++)
                {
                    this.list_2.Add(list[i]);
                }
                return list[list.Count - 1];
            }
            return this.method_206(A_0);
        }

        private DocumentObject method_206(DocumentObject A_0)
        {
            DocumentObject obj2 = A_0.Clone();
            Table table = obj2 as Table;
            Table table2 = A_0 as Table;
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                for (int j = 0; j < table2.Rows[i].Cells.Count; j++)
                {
                    this.method_207(table2.Rows[i].Cells[j], table.Rows[i].Cells[j]);
                }
            }
            return obj2;
        }

        private void method_207(Body A_0, Body A_1)
        {
            A_1.Items.InnerList.Clear();
            for (int i = 0; i < A_0.Items.Count; i++)
            {
                DocumentObject obj2 = null;
                if (A_0.Items[i] is Paragraph)
                {
                    foreach (DocumentObject obj3 in this.method_209(A_0.Items[i], null, ref obj2))
                    {
                        A_1.Items.Add(obj3);
                    }
                    if (obj2 != null)
                    {
                        i = A_0.Items.IndexOf(obj2);
                        this.stack_1.Clear();
                        this.bool_31 = false;
                        obj2 = null;
                    }
                }
                else
                {
                    A_1.Items.Add(this.method_206(A_0.Items[i]));
                }
            }
        }

        private DocumentObject method_208(DocumentObject A_0, string A_1, ref DocumentObject A_2)
        {
            DocumentObject item = A_0.Clone();
            if ((!(A_0 is Field) || ((A_0 as Field).Separator == null)) || (((A_0 as Field).End == null) || ((A_0 as Field).Type == FieldType.FieldHyperlink)))
            {
                if (!string.IsNullOrEmpty(A_1) && (item is TextRange))
                {
                    (item as TextRange).Text = A_1;
                }
                return item;
            }
            int index = 0;
            if ((A_0 as Field).Range.method_8().Contains((A_0 as Field).Separator))
            {
                index = (A_0 as Field).Range.method_8().IndexOf((A_0 as Field).Separator) + 1;
            }
            else if ((A_0 as Field).Range.method_8().Contains((A_0 as Field).Separator.OwnerParagraph))
            {
                index = (A_0 as Field).Range.method_8().IndexOf((A_0 as Field).Separator.OwnerParagraph);
            }
            for (int i = index; i < ((A_0 as Field).Range.method_8().Count - 1); i++)
            {
                if ((A_0 as Field).Range.method_8()[i] == (A_0 as Field).Separator.OwnerParagraph)
                {
                    if (((A_0 as Field).Range.method_8()[i] as Paragraph).LastItem == (A_0 as Field).Separator)
                    {
                        continue;
                    }
                    Paragraph paragraph = ((A_0 as Field).Range.method_8()[i] as DocumentObject).Clone() as Paragraph;
                    paragraph.method_57();
                    for (DocumentObject obj3 = (A_0 as Field).Separator.NextSibling as DocumentObject; obj3 != null; obj3 = (A_0 as Field).Separator.NextSibling as DocumentObject)
                    {
                        paragraph.Items.Add(obj3.Clone());
                    }
                    item = paragraph;
                }
                else
                {
                    item = ((A_0 as Field).Range.method_8()[i] as DocumentObject).Clone();
                }
                if (i == ((A_0 as Field).Range.method_8().Count - 2))
                {
                    break;
                }
                this.list_2.Add(item);
            }
            A_2 = (A_0 as Field).Range.method_8()[(A_0 as Field).Range.method_8().Count - 1] as DocumentObject;
            return item;
        }

        private List<DocumentObject> method_209(DocumentObject A_0, string A_1, ref DocumentObject A_2)
        {
            int num = 6;
            List<DocumentObject> list = new List<DocumentObject>();
            Paragraph paragraph = A_0.Clone() as Paragraph;
            paragraph.method_57();
            if ((A_1 != null) && A_1.EndsWith(BookmarkStart.b("Å", num)))
            {
                A_1 = A_1.Remove(A_1.Length - 1);
            }
            string str2 = string.Empty;
            string str = A_1;
            int num3 = this.method_211(A_0, A_1);
            for (int i = num3; i < (A_0 as Paragraph).Items.Count; i++)
            {
                ParagraphBase base2 = (A_0 as Paragraph).Items[i];
                DocumentObject obj2 = base2.Clone();
                bool flag = this.bool_30;
                this.bool_30 = false;
                str2 = this.method_181((A_0 as Paragraph).Items[i]);
                this.bool_30 = flag;
                bool flag2 = false;
                if (((base2 is Field) && ((base2 as Field).Separator != null)) && (((base2 as Field).End != null) && ((base2 as Field).Type != FieldType.FieldHyperlink)))
                {
                    flag2 = this.method_210(base2, obj2, paragraph, ref list);
                    A_2 = (base2 as Field).Range.method_8()[(base2 as Field).Range.method_8().Count - 1] as DocumentObject;
                }
                else if ((A_1 != null) && (obj2 is TextRange))
                {
                    if (((i == num3) && str2.Contains(A_1)) && !str2.StartsWith(A_1))
                    {
                        str2 = A_1;
                    }
                    if (str2.Contains(str) && !str.Contains(str2))
                    {
                        str2 = str;
                    }
                    (obj2 as TextRange).Text = str2;
                }
                if (!string.IsNullOrEmpty(str))
                {
                    str = str.Substring(str2.Length);
                }
                if (flag2)
                {
                    break;
                }
                paragraph.Items.Add(obj2);
                if ((str != null) && (str == string.Empty))
                {
                    break;
                }
                if (A_2 != null)
                {
                    i = (A_0 as Paragraph).Items.IndexOf(A_2);
                    this.stack_1.Clear();
                    this.bool_31 = false;
                    A_2 = null;
                }
            }
            list.Add(paragraph);
            return list;
        }

        private bool method_210(ParagraphBase A_0, DocumentObject A_1, Paragraph A_2, ref List<DocumentObject> A_3)
        {
            bool flag = false;
            int index = 0;
            if ((A_0 as Field).Range.method_8().Contains((A_0 as Field).Separator))
            {
                index = (A_0 as Field).Range.method_8().IndexOf((A_0 as Field).Separator) + 1;
            }
            else if ((A_0 as Field).Range.method_8().Contains((A_0 as Field).Separator.OwnerParagraph))
            {
                index = (A_0 as Field).Range.method_8().IndexOf((A_0 as Field).Separator.OwnerParagraph);
            }
            for (int i = index; i < ((A_0 as Field).Range.method_8().Count - 1); i++)
            {
                if ((A_0 as Field).Range.method_8()[i] == (A_0 as Field).Separator.OwnerParagraph)
                {
                    if (((A_0 as Field).Range.method_8()[i] as Paragraph).LastItem == (A_0 as Field).Separator)
                    {
                        continue;
                    }
                    Paragraph paragraph = ((A_0 as Field).Range.method_8()[i] as DocumentObject).Clone() as Paragraph;
                    A_2.method_57();
                    for (DocumentObject obj2 = (A_0 as Field).Separator.NextSibling as DocumentObject; obj2 != null; obj2 = (A_0 as Field).Separator.NextSibling as DocumentObject)
                    {
                        paragraph.Items.Add(obj2.Clone());
                    }
                    A_1 = paragraph;
                }
                else
                {
                    A_1 = ((A_0 as Field).Range.method_8()[i] as DocumentObject).Clone();
                }
                if (A_1 is Body)
                {
                    flag = true;
                }
                if (i == ((A_0 as Field).Range.method_8().Count - 2))
                {
                    return flag;
                }
                if (A_1 is Body)
                {
                    A_3.Add(A_2);
                    A_3.Add(A_1);
                }
                else
                {
                    A_2.Items.Add(A_1);
                }
            }
            return flag;
        }

        private int method_211(DocumentObject A_0, string A_1)
        {
            int num = 7;
            int num2 = 0;
            string str = string.Empty;
            if (A_1 != null)
            {
                bool flag = this.bool_30;
                this.bool_30 = false;
                string str2 = this.method_179(A_0);
                this.bool_30 = flag;
                if (str2.EndsWith(BookmarkStart.b("‬", num)))
                {
                    str2 = str2.Remove(str2.Length - 1);
                }
                int index = str2.IndexOf(A_1);
                if (index <= 0)
                {
                    return num2;
                }
                for (int i = 0; i < (A_0 as Paragraph).Items.Count; i++)
                {
                    str = str + this.method_181((A_0 as Paragraph).Items[i]);
                    if (index == str.Length)
                    {
                        return (i + 1);
                    }
                    if (index < str.Length)
                    {
                        A_1 = str.Substring(index);
                        return i;
                    }
                }
            }
            return num2;
        }

        private int method_212(int A_0, ref string A_1)
        {
            string code = this.Code;
            this.bool_30 = false;
            this.stack_1.Clear();
            this.bool_31 = false;
            string str2 = string.Empty;
            for (int i = 0; i < this.Range.method_8().Count; i++)
            {
                DocumentObject obj2 = this.Range.method_8()[i] as DocumentObject;
                if (obj2 is ParagraphBase)
                {
                    str2 = this.method_181(obj2);
                }
                else
                {
                    str2 = this.method_179(obj2);
                }
                code = code + str2;
                if (this.bool_30)
                {
                    break;
                }
                if (A_0 == code.Length)
                {
                    A_0 = i + 1;
                    break;
                }
                if (A_0 < code.Length)
                {
                    if (this.bool_31)
                    {
                        Field field = this.stack_1.Pop();
                        if (field.Separator.method_5() == (field.Separator.OwnerParagraph.Items.Count - 1))
                        {
                            A_0 = this.Range.method_8().IndexOf(field.Separator.OwnerParagraph) + 1;
                        }
                        else
                        {
                            A_1 = code.Substring(A_0);
                            A_0 = this.Range.method_8().IndexOf(field.Separator.OwnerParagraph);
                        }
                    }
                    else
                    {
                        A_1 = code.Substring(A_0);
                        A_0 = i;
                    }
                    break;
                }
            }
            this.bool_30 = false;
            this.stack_1.Clear();
            this.bool_31 = false;
            return A_0;
        }

        private void method_213()
        {
            for (int i = this.Range.Count - 1; i >= 0; i--)
            {
                DocumentObject obj2 = this.Range.method_8()[i] as DocumentObject;
                if (obj2 != this.End)
                {
                    if (obj2 == this.Separator)
                    {
                        break;
                    }
                    if (obj2 is ParagraphBase)
                    {
                        this.Range.method_8().Remove(obj2);
                        base.OwnerParagraph.Items.Remove(obj2);
                    }
                    else
                    {
                        Body ownerTextBody;
                        if (obj2 is Paragraph)
                        {
                            ownerTextBody = (obj2 as Paragraph).OwnerTextBody;
                            if (!this.bool_30)
                            {
                                this.method_214(obj2 as Paragraph);
                            }
                            if (this.bool_30)
                            {
                                break;
                            }
                            if ((obj2 as Paragraph).Items.Count == 0)
                            {
                                this.Range.method_8().Remove(obj2);
                                ownerTextBody.Items.Remove(obj2);
                            }
                        }
                        else if (obj2 is Table)
                        {
                            ownerTextBody = (obj2 as Table).OwnerTextBody;
                            if (!this.bool_30)
                            {
                                this.Range.method_8().Remove(obj2);
                                ownerTextBody.Items.Remove(obj2);
                            }
                        }
                    }
                }
            }
            this.bool_25 = false;
        }

        private void method_214(Paragraph A_0)
        {
            for (int i = A_0.Items.Count - 1; i >= 0; i--)
            {
                ParagraphBase entity = A_0.Items[i];
                if ((this.End.OwnerParagraph == A_0) && (i > A_0.Items.IndexOf(this.End)))
                {
                    i = A_0.Items.IndexOf(this.End);
                }
                else if (entity != this.End)
                {
                    if (entity == this.Separator)
                    {
                        this.bool_30 = true;
                        return;
                    }
                    if (!this.bool_30)
                    {
                        A_0.Items.Remove(entity);
                    }
                }
            }
        }

        private void method_215(Paragraph A_0, bool A_1, ref string A_2)
        {
            bool flag = this.bool_30;
            this.bool_30 = false;
            A_2 = this.method_179(A_0) + A_2;
            this.bool_30 = flag;
            if (A_1)
            {
                A_2 = A_2.TrimEnd(new char[] { '\r' });
            }
        }

        private string method_216(ParagraphBase A_0)
        {
            string text = string.Empty;
            if (A_0 is Field)
            {
                if ((A_0 as Field).Type == FieldType.FieldMergeField)
                {
                    return (A_0 as TextRange).Text;
                }
                if (!base.Document.LayoutVariables.method_3().Contains(A_0 as Field) && (A_0 != this))
                {
                    (A_0 as Field).method_49();
                }
                return (A_0 as Field).FieldResult;
            }
            if (A_0 is TextRange)
            {
                text = (A_0 as TextRange).Text;
            }
            return text;
        }

        internal void method_217(string A_0)
        {
            this.method_218(A_0, A_0);
        }

        internal void method_218(string A_0, string A_1)
        {
            if (A_0 != null)
            {
                A_0 = A_0.Replace(Class816.string_4, Class816.string_27);
                A_0 = A_0.Replace('\n', '\r');
                A_1 = A_1.Replace(Class816.string_4, Class816.string_27);
                A_1 = A_1.Replace('\n', '\r');
                this.FieldResult = A_0;
                if ((base.OwnerParagraph != null) && (this.End != null))
                {
                    this.method_203();
                    this.method_213();
                    this.End.OwnerParagraph.Items.Insert(this.End.method_5(), this.method_219(A_1));
                    this.bool_25 = false;
                }
            }
        }

        private TextRange method_219(string A_0)
        {
            TextRange range = new TextRange(base.Document) {
                IsAddForIfField = base.IsAddForIfField
            };
            if (this.characterFormat_0 != null)
            {
                range.CharacterFormat.ImportContainer(this.characterFormat_0);
                range.CharacterFormat.method_21(this.characterFormat_0);
                this.characterFormat_0 = null;
            }
            else
            {
                range.CharacterFormat.ImportContainer(this.CharacterFormat);
                range.CharacterFormat.method_21(this.CharacterFormat);
            }
            range.Text = A_0;
            return range;
        }

        private Struct30 method_220(DocumentObject A_0)
        {
            if (A_0 == null)
            {
                return new Struct30();
            }
            return new Struct30(A_0.Owner.method_5(), A_0.method_5());
        }

        internal List<DocumentObject> method_221(Struct30 A_0, Struct30 A_1, Body A_2)
        {
            return this.method_222(A_0, A_1, A_2, true);
        }

        private List<DocumentObject> method_222(Struct30 A_0, Struct30 A_1, Body A_2, bool A_3)
        {
            return this.method_223(A_0, A_1, A_2, A_3, false);
        }

        private List<DocumentObject> method_223(Struct30 A_0, Struct30 A_1, Body A_2, bool A_3, bool A_4)
        {
            return this.method_224(A_0, A_1, A_2, A_3, A_4, false);
        }

        private List<DocumentObject> method_224(Struct30 A_0, Struct30 A_1, Body A_2, bool A_3, bool A_4, bool A_5)
        {
            if ((!A_0.method_8() || !A_1.method_8()) || (A_2 == null))
            {
                return new List<DocumentObject>();
            }
            List<DocumentObject> list = new List<DocumentObject>();
            if (A_0.method_0() == A_1.method_0())
            {
                int num7 = A_0.method_0();
                int num5 = A_0.method_6();
                int num6 = A_1.method_6();
                while (num5 <= num6)
                {
                    list.Add(A_2.ChildObjects[num7].ChildObjects[num5]);
                    num5++;
                }
            }
            else
            {
                int num = A_0.method_0();
                int num8 = A_1.method_0();
                while (num <= num8)
                {
                    if (num == A_0.method_0())
                    {
                        if (((A_0.method_6() == 0) && !A_5) && ((A_2.ChildObjects[num] is Table) || (num < num8)))
                        {
                            list.Add(A_2.ChildObjects[num]);
                        }
                        else
                        {
                            int num3 = A_0.method_6();
                            int count = A_2.ChildObjects[num].ChildObjects.Count;
                            while (num3 < count)
                            {
                                list.Add(A_2.ChildObjects[num].ChildObjects[num3]);
                                num3++;
                            }
                        }
                    }
                    else if (num == A_1.method_0())
                    {
                        int num2 = 0;
                        int num9 = A_1.method_6();
                        while (num2 <= num9)
                        {
                            list.Add(A_2.ChildObjects[num].ChildObjects[num2]);
                            num2++;
                        }
                    }
                    else
                    {
                        list.Add(A_2.ChildObjects[num]);
                    }
                    num++;
                }
            }
            if (!A_3 && (list.Count > 0))
            {
                list.RemoveAt(0);
                if (list.Count > 0)
                {
                    list.RemoveAt(list.Count - 1);
                }
            }
            return list;
        }

        private void method_225()
        {
            this.method_226(this.Range);
        }

        private void method_226(Class44 A_0)
        {
            if (A_0 != null)
            {
                foreach (DocumentObject obj2 in A_0)
                {
                    this.method_231(obj2);
                }
            }
        }

        private string method_227(Field A_0)
        {
            string str = string.Empty;
            foreach (ParagraphBase base2 in A_0.Range.method_8())
            {
                if (base2 is TextRange)
                {
                    str = str + (base2 as TextRange).Text;
                }
            }
            return str;
        }

        private void method_228(Paragraph A_0, int A_1, int A_2)
        {
            if (((A_1 >= 0) || (A_1 <= A_0.Items.Count)) || ((A_2 >= 0) || (A_1 <= A_2)))
            {
                A_2 = (A_2 > A_0.Items.Count) ? (this.Range.Count - 1) : A_2;
                for (int i = A_1; i < A_2; i++)
                {
                    DocumentObject obj2 = A_0.Items[i];
                    this.method_231(obj2);
                }
            }
        }

        internal void method_229(Field A_0, int A_1, int A_2)
        {
            if (A_0 != null)
            {
                Struct30 struct3 = this.method_220(A_0);
                Struct30 struct2 = this.method_220(A_0.End);
                Struct30 struct4 = this.method_220(A_0.Separator);
                if ((struct4.method_8() && (struct4.method_0() != struct3.method_0())) && ((A_0 is IfField) && this.method_233(A_0 as IfField)))
                {
                    ((Interface1) A_0.Separator.OwnerParagraph).imethod_0().imethod_9(true);
                }
                else if ((struct2.method_8() && (struct2.method_0() != struct3.method_0())) && ((A_0 is IfField) && this.method_233(A_0 as IfField)))
                {
                    ((Interface1) A_0.End.OwnerParagraph).imethod_0().imethod_9(true);
                }
                Class44 range = A_0.Range;
                if (((A_1 >= 0) || (A_1 <= range.Count)) || ((A_2 >= 0) || (A_1 <= A_2)))
                {
                    A_2 = (A_2 > range.Count) ? (range.Count - 1) : A_2;
                    for (int i = A_1; i <= A_2; i++)
                    {
                        DocumentObject obj2 = range.method_8()[i] as DocumentObject;
                        if (((i == A_2) && (obj2 is Paragraph)) && (obj2 == range.method_10()))
                        {
                            int index = (obj2 as Paragraph).ChildObjects.IndexOf(A_0.End);
                            for (int j = 0; j <= index; j++)
                            {
                                this.method_231((obj2 as Paragraph).ChildObjects[j]);
                            }
                        }
                        else
                        {
                            this.method_231(obj2);
                        }
                    }
                }
            }
        }

        private void method_230(Field A_0, Struct30 A_1)
        {
            if ((A_0 != null) && A_1.method_8())
            {
                Struct30 struct2 = this.method_220(A_0);
                Body ownerTextBody = A_0.OwnerParagraph.OwnerTextBody;
                if (struct2.method_0() == A_1.method_0())
                {
                    int num = struct2.method_0();
                    int num8 = struct2.method_6();
                    int num9 = A_1.method_6();
                    while (num8 <= num9)
                    {
                        DocumentObject obj4 = ownerTextBody.ChildObjects[num].ChildObjects[num8];
                        this.method_231(obj4);
                        num8++;
                    }
                    if ((struct2.method_6() == 0) && (A_1.method_6() == (ownerTextBody.ChildObjects[num].ChildObjects.Count - 1)))
                    {
                        (ownerTextBody.ChildObjects[num] as Interface1).imethod_0().imethod_5(true);
                    }
                }
                else
                {
                    int num2 = struct2.method_0();
                    int num6 = A_1.method_0();
                    while (num2 <= num6)
                    {
                        if (num2 == struct2.method_0())
                        {
                            int num7 = struct2.method_6();
                            int count = ownerTextBody.ChildObjects[num2].ChildObjects.Count;
                            while (num7 < count)
                            {
                                DocumentObject obj3 = ownerTextBody.ChildObjects[num2].ChildObjects[num7];
                                this.method_231(obj3);
                                num7++;
                            }
                            if (struct2.method_6() == 0)
                            {
                                (ownerTextBody.ChildObjects[num2] as Interface1).imethod_0().imethod_5(true);
                            }
                        }
                        else if (num2 == A_1.method_0())
                        {
                            int num4 = 0;
                            int num5 = A_1.method_6();
                            while (num4 < num5)
                            {
                                DocumentObject obj5 = ownerTextBody.ChildObjects[num2].ChildObjects[num4];
                                this.method_231(obj5);
                                num4++;
                            }
                            if (A_1.method_6() == (ownerTextBody.ChildObjects[num2].ChildObjects.Count - 1))
                            {
                                (ownerTextBody.ChildObjects[num2] as Interface1).imethod_0().imethod_5(true);
                            }
                            if ((A_0 is IfField) && this.method_233(A_0 as IfField))
                            {
                                (ownerTextBody.ChildObjects[num2] as Interface1).imethod_0().imethod_9(true);
                            }
                        }
                        else
                        {
                            int num10;
                            int num3 = 0;
                            num10 = num10 = ownerTextBody.ChildObjects[num2].ChildObjects.Count;
                            while (num3 < num10)
                            {
                                DocumentObject obj2 = ownerTextBody.ChildObjects[num2].ChildObjects[num3];
                                this.method_231(obj2);
                                num3++;
                            }
                            if (ownerTextBody.ChildObjects[num2] is Paragraph)
                            {
                                (ownerTextBody.ChildObjects[num2] as Interface1).imethod_0().imethod_5(true);
                            }
                        }
                        num2++;
                    }
                }
            }
        }

        private void method_231(DocumentObject A_0)
        {
            if (A_0 is Paragraph)
            {
                (A_0 as Interface1).imethod_0().imethod_5(true);
                for (int i = 0; i < A_0.ChildObjects.Count; i++)
                {
                    DocumentObject obj4 = A_0.ChildObjects[i];
                    this.method_231(obj4);
                }
            }
            else if (A_0 is TableRow)
            {
                (A_0.Owner as Interface1).imethod_0().imethod_5(true);
            }
            else if (A_0 is Table)
            {
                (A_0 as Interface1).imethod_0().imethod_5(true);
            }
            else if (A_0 is StructureDocumentTagInline)
            {
                foreach (DocumentObject obj3 in (A_0 as StructureDocumentTagInline).SDTContent.ChildObjects)
                {
                    this.method_231(obj3);
                }
            }
            else if (A_0 is StructureDocumentTag)
            {
                foreach (DocumentObject obj2 in (A_0 as StructureDocumentTag).SDTContent.ChildObjects)
                {
                    this.method_231(obj2);
                }
            }
            else
            {
                if (A_0 is TextRange)
                {
                    (A_0 as TextRange).IsNotSplitByParagraphBreak = true;
                }
                (A_0 as Interface1).imethod_0().imethod_5(true);
                if (A_0 is TextRange)
                {
                    (A_0 as TextRange).IsNotSplitByParagraphBreak = false;
                }
            }
        }

        private void method_232(Body A_0, List<Struct31> A_1)
        {
            foreach (Struct31 struct4 in A_1)
            {
                Struct30 struct2 = struct4.struct30_0;
                Struct30 struct3 = struct4.struct30_1;
                if (struct2.method_0() == struct3.method_0())
                {
                    int num = struct2.method_0();
                    int num2 = struct2.method_6();
                    int num7 = struct3.method_6();
                    while (num2 <= num7)
                    {
                        DocumentObject obj3 = A_0.ChildObjects[num].ChildObjects[num2];
                        this.method_231(obj3);
                        num2++;
                    }
                }
                else
                {
                    int num4 = struct2.method_0();
                    int num5 = struct3.method_0();
                    while (num4 <= num5)
                    {
                        DocumentObject obj2 = A_0.ChildObjects[num4];
                        if (num4 == struct2.method_0())
                        {
                            int num6 = struct2.method_6();
                            int count = obj2.ChildObjects.Count;
                            while (num6 < count)
                            {
                                this.method_231(obj2.ChildObjects[num6]);
                                num6++;
                            }
                        }
                        else if (num4 == struct3.method_0())
                        {
                            int num3 = 0;
                            int num9 = struct3.method_6();
                            while (num3 < num9)
                            {
                                this.method_231(obj2.ChildObjects[num3]);
                                num3++;
                            }
                        }
                        else
                        {
                            this.method_231(obj2);
                        }
                        num4++;
                    }
                }
            }
        }

        private bool method_233(IfField A_0)
        {
            if (A_0 != null)
            {
                for (IDocumentObject obj2 = A_0.PreviousSibling; obj2 != null; obj2 = obj2.PreviousSibling)
                {
                    if (!(obj2 is BookmarkEnd) && !(obj2 is BookmarkStart))
                    {
                        return (((obj2 is FieldMark) && ((obj2 as FieldMark).Type == FieldMarkType.FieldEnd)) && (obj2 as Interface1).imethod_0().imethod_6());
                    }
                }
            }
            return false;
        }

        internal string method_234(MergeField A_0)
        {
            int num = 0x10;
            string text = A_0.Text;
            if ((A_0.ConvertedToText && (A_0.Text != null)) && (A_0.Text.Trim().Length > 0))
            {
                if (A_0.NumberFormat != string.Empty)
                {
                    Regex regex = new Regex(BookmarkStart.b("ᨵᘷ䘹ሻሽ", num));
                    if (regex.IsMatch(A_0.NumberFormat, 0))
                    {
                        return text;
                    }
                    text = A_0.Text.Replace(BookmarkStart.b("ᨵ", num), BookmarkStart.b("ᠵ", num)).Replace(BookmarkStart.b("ᘵ", num), string.Empty);
                    StringBuilder builder = new StringBuilder();
                    foreach (char ch in text)
                    {
                        if (char.IsNumber(ch) || (ch == '.'))
                        {
                            builder.Append(ch);
                        }
                    }
                    double num2 = double.Parse(builder.ToString(), CultureInfo.InvariantCulture);
                    if (A_0.NumberFormat.Contains(BookmarkStart.b("ጵ", num)))
                    {
                        num2 /= 100.0;
                    }
                    return num2.ToString(A_0.NumberFormat, CultureInfo.InvariantCulture);
                }
                if (A_0.DateFormat != string.Empty)
                {
                    text = DateTime.Parse(text).ToString(A_0.DateFormat, DateTimeFormatInfo.CurrentInfo);
                }
            }
            return text;
        }

        internal bool method_45(Class420 A_0)
        {
            if (base.IsDeleteRevision)
            {
                return A_0.vmethod_21();
            }
            return true;
        }

        internal Symbol method_46()
        {
            int num = 0;
            string[] strArray = this.Code.Split(new char[] { '\\' });
            float num2 = 0f;
            Symbol symbol = new Symbol(base.Document);
            symbol.method_0(base.OwnerParagraph);
            foreach (string str2 in strArray)
            {
                if (str2.ToUpper().StartsWith(BookmarkStart.b("甥焧朩渫愭簯", num)))
                {
                    symbol.CharacterCode = Convert.ToByte(str2.ToUpper().Replace(BookmarkStart.b("甥焧朩渫愭簯", num), string.Empty).Trim());
                }
                else if (str2.StartsWith(BookmarkStart.b("䀥", num)))
                {
                    symbol.FontName = str2.Replace(BookmarkStart.b("䀥", num), string.Empty).Trim().Trim(new char[] { '"' });
                }
                else if (str2.StartsWith(BookmarkStart.b("唥", num)))
                {
                    num2 = (float) Convert.ToDouble(str2.Replace(BookmarkStart.b("唥", num), string.Empty).Trim());
                }
            }
            symbol.CharacterFormat.ImportContainer(this.CharacterFormat);
            symbol.CharacterFormat.method_21(this.CharacterFormat);
            if (this.CharacterFormat.BaseFormat != null)
            {
                symbol.CharacterFormat.ApplyBase(this.CharacterFormat.BaseFormat);
            }
            if (num2 > 0f)
            {
                symbol.CharacterFormat.FontSize = num2;
            }
            return symbol;
        }

        internal string method_47()
        {
            int num = 8;
            switch (this.TextFormat)
            {
                case Spire.Doc.Documents.TextFormat.Uppercase:
                    this.Text = this.Text.ToUpper();
                    break;

                case Spire.Doc.Documents.TextFormat.Lowercase:
                    this.Text = this.Text.ToLower();
                    break;

                case Spire.Doc.Documents.TextFormat.FirstCapital:
                {
                    string text = this.Text;
                    char ch = text[0];
                    string str2 = ch.ToString().ToUpper();
                    this.Text = str2 + text.Remove(0, 1);
                    break;
                }
                case Spire.Doc.Documents.TextFormat.Titlecase:
                {
                    string[] strArray = this.Text.Split(new char[] { ' ' });
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        string str3 = strArray[i];
                        if (str3 != string.Empty)
                        {
                            char ch2 = str3[0];
                            string str4 = ch2.ToString().ToUpper();
                            str3 = str3.Remove(0, 1);
                            strArray[i] = str4 + str3;
                        }
                    }
                    this.Text = "";
                    int length = strArray.Length;
                    for (int j = 0; j < length; j++)
                    {
                        this.Text = this.Text + strArray[j];
                        if (j < (length - 1))
                        {
                            this.Text = this.Text + BookmarkStart.b("อ", num);
                        }
                    }
                    break;
                }
            }
            return this.Text;
        }

        private void method_48(bool A_0)
        {
            bool flag = this.bool_28;
            this.bool_28 = A_0;
            this.method_49();
            this.bool_28 = flag;
        }

        internal void method_49()
        {
            if (this.IsLocked)
            {
                return;
            }
            this.bool_25 = false;
            FieldType type = this.Type;
            if (type > FieldType.FieldFormula)
            {
                if (type <= FieldType.FieldAddin)
                {
                    switch (type)
                    {
                        case FieldType.FieldDocVariable:
                            this.method_78();
                            break;

                        case FieldType.FieldSection:
                            this.method_91();
                            break;

                        case FieldType.FieldIncludePicture:
                            this.method_50();
                            break;

                        case FieldType.FieldIncludeText:
                            this.method_127();
                            break;

                        case FieldType.FieldCompare:
                            this.method_131();
                            break;

                        case FieldType.FieldAddin:
                            this.method_92();
                            break;
                    }
                    goto Label_0222;
                }
                if (type == FieldType.FieldDocProperty)
                {
                    this.method_93();
                    goto Label_0222;
                }
                if (type != FieldType.FieldUnknown)
                {
                    goto Label_0222;
                }
            }
            else
            {
                switch (type)
                {
                    case FieldType.FieldRefNoKeyword:
                        break;

                    case FieldType.FieldRef:
                        this.method_88();
                        goto Label_0222;

                    case FieldType.FieldIndexEntry:
                    case FieldType.FieldFootnoteRef:
                    case FieldType.FieldNumWords:
                    case FieldType.FieldNumChars:
                    case FieldType.FieldTemplate:
                    case FieldType.FieldQuote:
                    case FieldType.FieldInclude:
                        goto Label_0222;

                    case FieldType.FieldSet:
                        this.method_86();
                        goto Label_0222;

                    case FieldType.FieldIf:
                        this.method_99();
                        goto Label_0222;

                    case FieldType.FieldNumPages:
                        this.method_217((((base.Document.int_8 != 0) || (base.Document.BuiltinDocumentProperties.PageCount <= 0)) ? base.Document.int_8 : base.Document.BuiltinDocumentProperties.PageCount).ToString());
                        goto Label_0222;

                    case FieldType.FieldFileName:
                        this.method_85();
                        goto Label_0222;

                    case FieldType.FieldDate:
                    case FieldType.FieldTime:
                        this.method_79();
                        goto Label_0222;

                    case FieldType.FieldPage:
                        if (base.Document.DocLayoter != null)
                        {
                            if (base.Document.DocLayoter.method_28() == null)
                            {
                                this.method_217(base.Document.DocLayoter.method_18().ToString());
                            }
                            else
                            {
                                this.method_217((base.Document.DocLayoter.method_28().method_31() + 1).ToString());
                            }
                        }
                        goto Label_0222;

                    case FieldType.FieldExpression:
                    case FieldType.FieldFormula:
                        this.method_133();
                        goto Label_0222;

                    case FieldType.FieldPageRef:
                        this.method_89();
                        goto Label_0222;

                    case FieldType.FieldAsk:
                        this.method_51();
                        goto Label_0222;

                    default:
                        goto Label_0222;
                }
            }
            this.method_83();
        Label_0222:
            if (!base.Document.LayoutVariables.method_3().Contains(this) && (this.Type != FieldType.FieldPage))
            {
                base.Document.LayoutVariables.method_3().Add(this);
            }
        }

        private void method_50()
        {
            string url = this.method_177().Split(new char[] { '"' })[1];
            Image image = this.DownloadImage(url);
            if (image != null)
            {
                DocPicture entity = new DocPicture(base.Document);
                entity.LoadImage(image);
                int index = base.Owner.ChildObjects.IndexOf(this.Separator);
                for (int i = base.Owner.ChildObjects.IndexOf(this.End) - 1; i > index; i--)
                {
                    base.Owner.ChildObjects.RemoveAt(i);
                }
                base.Owner.ChildObjects.Insert(index + 1, entity);
            }
        }

        private void method_51()
        {
            this.method_52(false);
        }

        internal void method_52(bool A_0)
        {
            if ((base.Document != null) && !this.bool_29)
            {
                AskFieldEventArgs args = new AskFieldEventArgs(this);
                string bookmarkName = args.BookmarkName;
                if (!A_0)
                {
                    if (base.Document.Bookmarks.FindByName(bookmarkName) == null)
                    {
                        string defaultResponse = args.DefaultResponse;
                        this.method_53(this, bookmarkName, defaultResponse);
                        this.bool_25 = false;
                    }
                }
                else
                {
                    base.Document.method_24(args);
                    if (!args.Cancel && !string.IsNullOrEmpty(args.ResponseTextEx))
                    {
                        string responseTextEx = args.ResponseTextEx;
                        this.method_53(this, bookmarkName, responseTextEx);
                        this.bool_29 = true;
                        this.bool_25 = false;
                    }
                }
            }
        }

        private void method_53(Field A_0, string A_1, string A_2)
        {
            if ((((A_0 != null) && (A_0.Document != null)) && (A_0.End != null)) && (A_0.End.OwnerParagraph != null))
            {
                Paragraph ownerParagraph = A_0.End.OwnerParagraph;
                int index = A_0.End.method_5();
                int num3 = (A_0.Separator != null) ? A_0.Separator.method_5() : index;
                for (int i = index - 1; i > num3; i--)
                {
                    ownerParagraph.ChildObjects.RemoveAt(i);
                }
                index = A_0.End.method_5();
                if (A_0.Separator == null)
                {
                    FieldMark mark = new FieldMark(A_0.Document, FieldMarkType.FieldSeparator);
                    mark.ApplyCharacterFormat(A_0.CharacterFormat);
                    ownerParagraph.ChildObjects.Insert(index, mark);
                    A_0.Separator = mark;
                    index = A_0.End.method_5();
                }
                Bookmark bookmark = A_0.Document.Bookmarks.FindByName(A_1);
                if (bookmark != null)
                {
                    A_0.Document.Bookmarks.Remove(bookmark);
                }
                BookmarkStart entity = new BookmarkStart(A_0.Document, A_1);
                ownerParagraph.ChildObjects.Insert(index, entity);
                TextRange range = new TextRange(A_0.Document) {
                    Text = A_2
                };
                range.ApplyCharacterFormat(A_0.CharacterFormat);
                ownerParagraph.ChildObjects.Insert(++index, range);
                BookmarkEnd end = new BookmarkEnd(A_0.Document, A_1);
                ownerParagraph.ChildObjects.Insert(++index, end);
            }
        }

        private bool method_54(List<DocumentObject> A_0)
        {
            if ((A_0 == null) || (A_0.Count <= 0))
            {
                return false;
            }
            bool flag2 = false;
            for (int i = 0; i < A_0.Count; i++)
            {
                DocumentObject obj2 = A_0[i];
                if ((obj2 is Field) && ((obj2 as Field).Type == FieldType.FieldAsk))
                {
                    (obj2 as Field).method_52(true);
                    flag2 = true;
                }
                else if (obj2 is Paragraph)
                {
                    bool flag = this.method_56(obj2 as Paragraph);
                    flag2 = !flag2 ? flag : flag2;
                }
                else if (obj2 is Table)
                {
                    bool flag3 = this.method_58(obj2 as Table);
                    flag2 = !flag2 ? flag3 : flag2;
                }
                else if (obj2 is StructureDocumentTag)
                {
                    bool flag4 = this.method_59(obj2 as StructureDocumentTag);
                    flag2 = !flag2 ? flag4 : flag2;
                }
            }
            return flag2;
        }

        private void method_55(List<DocumentObject> A_0)
        {
            if ((A_0 != null) && (A_0.Count > 0))
            {
                for (int i = 0; i < A_0.Count; i++)
                {
                    DocumentObject obj2 = A_0[i];
                    if ((obj2 is Field) && ((obj2 as Field).Type == FieldType.FieldAsk))
                    {
                        int index = A_0.IndexOf((obj2 as Field).End);
                        if ((index > 0) && (index > i))
                        {
                            for (int j = index; j >= i; j--)
                            {
                                A_0.RemoveAt(j);
                            }
                            i--;
                        }
                    }
                }
            }
        }

        private bool method_56(Paragraph A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            return this.method_57(A_0.Items);
        }

        private bool method_57(ParagraphItemCollection A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            bool flag2 = false;
            for (int i = 0; i < A_0.Count; i++)
            {
                DocumentObject obj2 = A_0[i];
                if ((obj2 is Field) && ((obj2 as Field).Type == FieldType.FieldAsk))
                {
                    (obj2 as Field).method_52(true);
                    flag2 = true;
                }
                else if (obj2 is TextBox)
                {
                    bool flag3 = this.method_60((obj2 as TextBox).Body);
                    flag2 = !flag2 ? flag3 : flag2;
                }
                else if (obj2 is StructureDocumentTagInline)
                {
                    bool flag = this.method_57((obj2 as StructureDocumentTagInline).SDTContent.Items);
                    flag2 = !flag2 ? flag : flag2;
                }
            }
            return flag2;
        }

        private bool method_58(Table A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            bool flag2 = false;
            for (int i = 0; i < A_0.Rows.Count; i++)
            {
                TableRow row = A_0.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    TableCell cell = row.Cells[j];
                    bool flag = this.method_60(cell);
                    flag2 = !flag2 ? flag : flag2;
                }
            }
            return flag2;
        }

        private bool method_59(StructureDocumentTag A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            return this.method_60(A_0.SDTContent);
        }

        private bool method_60(Body A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            bool flag = false;
            for (int i = 0; i < A_0.ChildObjects.Count; i++)
            {
                DocumentObject obj2 = A_0.ChildObjects[i];
                if (obj2 is Paragraph)
                {
                    bool flag4 = this.method_56(obj2 as Paragraph);
                    flag = !flag ? flag4 : flag;
                }
                else if (obj2 is Table)
                {
                    bool flag2 = this.method_58(obj2 as Table);
                    flag = !flag ? flag2 : flag;
                }
                else if (obj2 is StructureDocumentTag)
                {
                    bool flag3 = this.method_59(obj2 as StructureDocumentTag);
                    flag = !flag ? flag3 : flag;
                }
            }
            return flag;
        }

        private bool method_61(Table A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            bool flag2 = false;
            for (int i = 0; i < A_0.Rows.Count; i++)
            {
                TableRow row = A_0.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    TableCell cell = row.Cells[j];
                    bool flag = this.method_63(cell);
                    if (flag2 = !flag2 ? flag : flag2)
                    {
                        break;
                    }
                }
                if (flag2)
                {
                    return flag2;
                }
            }
            return flag2;
        }

        private bool method_62(StructureDocumentTag A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            return this.method_63(A_0.SDTContent);
        }

        private bool method_63(Body A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            bool flag2 = false;
            for (int i = 0; i < A_0.ChildObjects.Count; i++)
            {
                DocumentObject obj2 = A_0.ChildObjects[i];
                if (obj2 is Paragraph)
                {
                    bool flag4 = this.method_64(obj2 as Paragraph);
                    if (flag2 = !flag2 ? flag4 : flag2)
                    {
                        return flag2;
                    }
                }
                else if (obj2 is Table)
                {
                    bool flag3 = this.method_61(obj2 as Table);
                    if (flag2 = !flag2 ? flag3 : flag2)
                    {
                        return flag2;
                    }
                }
                else if (obj2 is StructureDocumentTag)
                {
                    bool flag = this.method_62(obj2 as StructureDocumentTag);
                    if (flag2 = !flag2 ? flag : flag2)
                    {
                        return flag2;
                    }
                }
            }
            return flag2;
        }

        private bool method_64(Paragraph A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            return this.method_65(A_0.Items);
        }

        private bool method_65(ParagraphItemCollection A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            bool flag2 = false;
            for (int i = 0; i < A_0.Count; i++)
            {
                DocumentObject obj2 = A_0[i];
                if ((obj2 is Field) && ((obj2 as Field).Type == FieldType.FieldAsk))
                {
                    return true;
                }
                if (obj2 is TextBox)
                {
                    bool flag3 = this.method_63((obj2 as TextBox).Body);
                    if (flag2 = !flag2 ? flag3 : flag2)
                    {
                        return flag2;
                    }
                }
                else if (obj2 is StructureDocumentTagInline)
                {
                    bool flag = this.method_65((obj2 as StructureDocumentTagInline).SDTContent.Items);
                    if (flag2 = !flag2 ? flag : flag2)
                    {
                        return flag2;
                    }
                }
            }
            return flag2;
        }

        internal bool method_66()
        {
            bool flag;
            FieldType fieldMergeField = FieldType.FieldMergeField;
            if ((this.Range != null) && (this.Range.Count == 0))
            {
                return false;
            }
            using (IEnumerator enumerator = this.Range.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if (current is Paragraph)
                    {
                        if (this.method_69(current as Paragraph, fieldMergeField))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (current is Table)
                        {
                            if (this.method_67(current as Table, fieldMergeField))
                            {
                                return true;
                            }
                            continue;
                        }
                        if ((current is Field) && ((current as Field).Type == fieldMergeField))
                        {
                            goto Label_0091;
                        }
                    }
                }
                return false;
            Label_0091:
                flag = true;
            }
            return flag;
        }

        private bool method_67(Table A_0, FieldType A_1)
        {
            if (A_0 != null)
            {
                foreach (TableRow row in A_0.Rows)
                {
                    foreach (TableCell cell in row.Cells)
                    {
                        if (this.method_68(cell, A_1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool method_68(Body A_0, FieldType A_1)
        {
            bool flag;
            if (A_0 == null)
            {
                return false;
            }
            using (IEnumerator enumerator = A_0.ChildObjects.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if (current is Paragraph)
                    {
                        if (this.method_69(current as Paragraph, A_1))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (current is Table)
                        {
                            if (this.method_67(current as Table, A_1))
                            {
                                return true;
                            }
                            continue;
                        }
                        if ((current is StructureDocumentTag) && this.method_68((current as StructureDocumentTag).SDTContent, A_1))
                        {
                            goto Label_0080;
                        }
                    }
                }
                return false;
            Label_0080:
                flag = true;
            }
            return flag;
        }

        private bool method_69(Paragraph A_0, FieldType A_1)
        {
            if (A_0 == null)
            {
                return false;
            }
            return this.method_70(A_0.Items, A_1);
        }

        private bool method_70(ParagraphItemCollection A_0, FieldType A_1)
        {
            bool flag;
            if ((A_0 == null) || (A_0.Count == 0))
            {
                return false;
            }
            using (IEnumerator enumerator = A_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if ((current is Field) && ((current as Field).Type == A_1))
                    {
                        return true;
                    }
                    if (current is TextBox)
                    {
                        if (this.method_68((current as TextBox).Body, A_1))
                        {
                            return true;
                        }
                    }
                    else if ((current is StructureDocumentTagInline) && this.method_70((current as StructureDocumentTagInline).SDTContent.Items, A_1))
                    {
                        goto Label_0090;
                    }
                }
                return false;
            Label_0090:
                flag = true;
            }
            return flag;
        }

        private void method_71(List<DocumentObject> A_0)
        {
            if (((A_0 != null) && (A_0.Count > 0)) && (this.list_3 != null))
            {
                for (int i = 0; i < A_0.Count; i++)
                {
                    DocumentObject item = A_0[i];
                    if ((!(item is Field) || ((item as Field).Type != FieldType.FieldIncludeText)) && (item is FieldMark))
                    {
                        foreach (Field field in this.list_3)
                        {
                            if ((item == field.Separator) || (item == field.End))
                            {
                                A_0.Remove(item);
                                i--;
                            }
                        }
                    }
                }
            }
        }

        internal void method_72()
        {
            string str = this.method_73(this.Text);
            if (!str.Equals(this.Text))
            {
                this.Text = str;
            }
        }

        internal string method_73(string A_0)
        {
            int num = 0x10;
            string str = A_0;
            if (this.TextFormat == Spire.Doc.Documents.TextFormat.Uppercase)
            {
                return str.ToUpper();
            }
            if (this.TextFormat == Spire.Doc.Documents.TextFormat.Lowercase)
            {
                return str.ToLower();
            }
            if (this.TextFormat == Spire.Doc.Documents.TextFormat.FirstCapital)
            {
                string str2 = str;
                char ch = str2[0];
                return (ch.ToString().ToUpper() + str2.Remove(0, 1));
            }
            if (this.TextFormat == Spire.Doc.Documents.TextFormat.Titlecase)
            {
                string[] strArray = str.Split(new char[] { ' ' });
                for (int i = 0; i < strArray.Length; i++)
                {
                    string str4 = strArray[i].ToLower();
                    if (str4 != string.Empty)
                    {
                        char ch2 = str4[0];
                        string str5 = ch2.ToString().ToUpper();
                        str4 = str4.Remove(0, 1);
                        strArray[i] = str5 + str4;
                    }
                }
                str = string.Empty;
                int length = strArray.Length;
                for (int j = 0; j < length; j++)
                {
                    str = str + strArray[j];
                    if (j < (length - 1))
                    {
                        str = str + BookmarkStart.b("ᘵ", num);
                    }
                }
            }
            return str;
        }

        private string method_74(string A_0)
        {
            int num = 11;
            string str = this.method_73(A_0);
            if (!string.IsNullOrEmpty(this.FormattingString.Trim()))
            {
                DateTime time;
                if (this.FormattingString.Contains(BookmarkStart.b("洰ဲ", num)))
                {
                    string str2 = this.method_188(this.method_75(this.FormattingString), this.FormattingString.IndexOf(BookmarkStart.b("洰ဲ", num)));
                    return this.method_136(str, str2);
                }
                if (this.FormattingString.Contains(BookmarkStart.b("洰猲", num)) && DateTime.TryParse(A_0, out time))
                {
                    str = this.method_81(time, this.method_75(this.FormattingString));
                }
            }
            return str;
        }

        private string method_75(string A_0)
        {
            return A_0.Replace('“', '"').Replace('”', '"');
        }

        private void method_76(string A_0)
        {
            Paragraph ownerParagraph = base.OwnerParagraph;
            int num = base.method_5();
            int num2 = 0;
            ParagraphBase base2 = null;
            for (int i = num; i < ownerParagraph.Items.Count; i++)
            {
                if ((ownerParagraph.Items[i] is FieldMark) && ((ownerParagraph.Items[i] as FieldMark).Type == FieldMarkType.FieldSeparator))
                {
                    num2 = i;
                    if (ownerParagraph.Items[num2].NextSibling != null)
                    {
                        if (ownerParagraph.Items[num2].NextSibling is TextRange)
                        {
                            base2 = ownerParagraph.Items[num2 + 1];
                        }
                        else
                        {
                            ownerParagraph.Items.Insert(num2 + 1, new TextRange(base.m_doc));
                            ownerParagraph.Items[num2 + 1].CharacterFormat.ImportContainer(this.CharacterFormat);
                            base2 = ownerParagraph.Items[num2 + 1];
                        }
                        break;
                    }
                    bool flag = false;
                    int num6 = base.OwnerParagraph.method_5();
                    CharacterFormat format = new CharacterFormat(base.m_doc);
                    format.ImportContainer(this.CharacterFormat);
                    Body ownerTextBody = base.OwnerParagraph.OwnerTextBody;
                    for (int j = num6; j < ownerTextBody.Items.Count; j++)
                    {
                        Paragraph paragraph2 = ownerTextBody.Items[j + 1] as Paragraph;
                        int num5 = 0;
                        goto Label_0120;
                    Label_00D3:
                        if ((paragraph2.Items[num5] is FieldMark) && ((paragraph2.Items[num5] as FieldMark).Type == FieldMarkType.FieldEnd))
                        {
                            goto Label_014F;
                        }
                        if (paragraph2.Items[num5] is TextRange)
                        {
                            goto Label_0132;
                        }
                        num5++;
                    Label_0120:
                        if (paragraph2.Items.Count <= num5)
                        {
                            goto Label_014F;
                        }
                        goto Label_00D3;
                    Label_0132:
                        format.ImportContainer(paragraph2.Items[num5].CharacterFormat);
                        flag = true;
                    Label_014F:
                        if (flag || ((paragraph2.Items[num5] is FieldMark) && ((paragraph2.Items[num5] as FieldMark).Type == FieldMarkType.FieldEnd)))
                        {
                            break;
                        }
                    }
                    ownerParagraph.Items.Insert(num2 + 1, new TextRange(base.m_doc));
                    ownerParagraph.Items[num2 + 1].CharacterFormat.ImportContainer(format);
                    base2 = ownerParagraph.Items[num2 + 1];
                    break;
                }
            }
            if (((base2 != null) && (base2 is TextRange)) && (((base2.NextSibling == null) || !(base2.NextSibling is FieldMark)) || ((base2.NextSibling as FieldMark).Type != FieldMarkType.FieldEnd)))
            {
                this.method_77(num2 + 1);
            }
            if (base2 is TextRange)
            {
                (base2 as TextRange).Text = A_0;
            }
        }

        private void method_77(int A_0)
        {
            Paragraph ownerParagraph = base.OwnerParagraph;
            int num = A_0 + 1;
            while (num < ownerParagraph.Items.Count)
            {
                if ((ownerParagraph.Items[num] is FieldMark) && ((ownerParagraph.Items[num] as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    return;
                }
                ownerParagraph.Items.RemoveAt(A_0 + 1);
            }
            int num2 = base.OwnerParagraph.method_5();
            Body ownerTextBody = base.OwnerParagraph.OwnerTextBody;
            int num3 = num2;
            while (num3 < ownerTextBody.Items.Count)
            {
                Paragraph paragraph2 = ownerTextBody.Items[num2 + 1] as Paragraph;
                while (paragraph2.Items.Count > 0)
                {
                    if ((paragraph2.Items[0] is FieldMark) && ((paragraph2.Items[0] as FieldMark).Type == FieldMarkType.FieldEnd))
                    {
                        break;
                    }
                    paragraph2.Items.RemoveAt(0);
                }
                if (paragraph2.Items.Count == 0)
                {
                    paragraph2.RemoveSelf();
                }
                else if ((paragraph2.Items[0] is FieldMark) && ((paragraph2.Items[0] as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    ownerParagraph.Items.Add(paragraph2.Items[0]);
                    if (paragraph2.Items.Count == 0)
                    {
                        paragraph2.RemoveSelf();
                    }
                    return;
                }
            }
        }

        private void method_78()
        {
            int num = 6;
            string oldValue = '"'.ToString();
            string str2 = base.m_doc.Variables[this.Value.Replace(oldValue, string.Empty)];
            if (str2 != null)
            {
                string str3 = str2;
                if (!string.IsNullOrEmpty(this.FormattingString))
                {
                    string str4 = this.FormattingString.Trim().ToString();
                    if (str4.Contains(BookmarkStart.b("瀫Эု缱焳搵缷缹稻焽ሿཁՃቅ", num)))
                    {
                        str4 = str4.Remove(str4.IndexOf(BookmarkStart.b("瀫Эု缱焳搵缷缹稻焽ሿཁՃቅ", num))).Trim();
                    }
                    else if (str4.Contains(BookmarkStart.b("瀫Эု缱儳䐵強弹娻儽㈿⽁╃㉅", num)))
                    {
                        str4 = str4.Remove(str4.IndexOf(BookmarkStart.b("瀫Эု缱儳䐵強弹娻儽㈿⽁╃㉅", num))).Trim();
                    }
                    if (!string.IsNullOrEmpty(str4))
                    {
                        if (str4.Contains(BookmarkStart.b("瀫渭", num)))
                        {
                            str4 = this.method_188(str4, str4.IndexOf(BookmarkStart.b("瀫渭", num))).Trim();
                        }
                        else if (str4.Contains(BookmarkStart.b("瀫ഭ", num)))
                        {
                            str4 = this.method_188(str4, str4.IndexOf(BookmarkStart.b("瀫ഭ", num))).Trim();
                        }
                    }
                    if (!string.IsNullOrEmpty(str4))
                    {
                        str3 = this.method_94(str3, str4);
                    }
                    if (this.TextFormat != Spire.Doc.Documents.TextFormat.None)
                    {
                        this.method_72();
                    }
                }
                this.method_217(str3);
            }
        }

        internal void method_79()
        {
            this.method_80(string.Empty);
        }

        internal void method_80(string A_0)
        {
            int num = 11;
            if (!this.bool_25 && base.Document.bool_3)
            {
                this.Range.method_8().Clear();
                this.method_175();
            }
            CultureInfo cultureInfo = this.GetCultureInfo(this.CharacterFormat.LocaleIdASCII);
            DateTime now = DateTime.Now;
            bool flag = false;
            string str2 = string.IsNullOrEmpty(A_0) ? this.FormattingString.Trim().ToString() : A_0;
            string str = str2;
            if (str.Contains(BookmarkStart.b("洰ᤲᔴ稶簸椺稼稾݀ూᝄ੆ࡈὊ", num)))
            {
                str = str.Remove(str.IndexOf(BookmarkStart.b("洰ᤲᔴ稶簸椺稼稾݀ూᝄ੆ࡈὊ", num))).Trim();
            }
            else if (str.Contains(BookmarkStart.b("洰ᤲᔴ稶尸䤺娼娾❀ⱂ㝄⩆⡈㽊", num)))
            {
                str = str.Remove(str.IndexOf(BookmarkStart.b("洰ᤲᔴ稶尸䤺娼娾❀ⱂ㝄⩆⡈㽊", num))).Trim();
            }
            if ((str2.Trim() != string.Empty) && str.Contains(BookmarkStart.b("洰猲", num)))
            {
                str = this.method_188(str, str.IndexOf(BookmarkStart.b("洰猲", num)));
                str = this.method_189(str, out flag);
                str = this.method_191(str, now);
                if (flag)
                {
                    str = this.method_190(str, now);
                }
            }
            else if (this.Type == FieldType.FieldTime)
            {
                str = now.ToString(cultureInfo.DateTimeFormat.ShortTimePattern);
            }
            else
            {
                str = now.ToString(cultureInfo.DateTimeFormat.ShortDatePattern);
            }
            this.method_217(str);
        }

        private string method_81(DateTime A_0, string A_1)
        {
            int num = 11;
            bool flag = false;
            string str = A_1;
            string str2 = str;
            CultureInfo cultureInfo = this.GetCultureInfo(this.CharacterFormat.LocaleIdASCII);
            if (str2.Contains(BookmarkStart.b("洰ᤲᔴ稶簸椺稼稾݀ూᝄ੆ࡈὊ", 11)))
            {
                str2 = str2.Remove(str2.IndexOf(BookmarkStart.b("洰ᤲᔴ稶簸椺稼稾݀ూᝄ੆ࡈὊ", num))).Trim();
            }
            else if (str2.Contains(BookmarkStart.b("洰ᤲᔴ稶尸䤺娼娾❀ⱂ㝄⩆⡈㽊", num)))
            {
                str2 = str2.Remove(str2.IndexOf(BookmarkStart.b("洰ᤲᔴ稶尸䤺娼娾❀ⱂ㝄⩆⡈㽊", num))).Trim();
            }
            if ((str.Trim() != string.Empty) && str2.Contains(BookmarkStart.b("洰猲", num)))
            {
                str2 = this.method_188(str2, str2.IndexOf(BookmarkStart.b("洰猲", num)));
                str2 = this.method_189(str2, out flag);
                str2 = this.method_191(str2, A_0);
                if (flag)
                {
                    str2 = this.method_190(str2, A_0);
                }
                return str2;
            }
            if (this.Type == FieldType.FieldTime)
            {
                return A_0.ToString(cultureInfo.DateTimeFormat.ShortTimePattern);
            }
            return A_0.ToString(cultureInfo.DateTimeFormat.ShortDatePattern);
        }

        internal bool method_82()
        {
            string str = this.method_137(this.method_177());
            str = this.method_117(str, BookmarkStart.b("帯圱䰳䈵儷尹", 10));
            if (!(this.method_125(str) == BookmarkStart.b("į", 10)))
            {
                return false;
            }
            return true;
        }

        private void method_83()
        {
            string name = this.method_177().Trim();
            string[] strArray = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (strArray.Length > 1)
            {
                name = strArray[0];
            }
            Bookmark bookmark = base.Document.Bookmarks.FindByName(name);
            if (bookmark != null)
            {
                string str2 = this.method_84(bookmark);
                if (!string.IsNullOrEmpty(str2))
                {
                    string str3 = str2;
                    if (!string.IsNullOrEmpty(this.FormattingString.Trim()))
                    {
                        str3 = this.method_74(str2);
                    }
                    this.method_218(str2, str3);
                }
            }
            else
            {
                for (int i = this.Range.Count - 1; i >= 0; i--)
                {
                    DocumentObject obj2 = this.Range.InnerList[i] as DocumentObject;
                    if (obj2 is FieldMark)
                    {
                        FieldMark mark = obj2 as FieldMark;
                        if (((mark.Type == FieldMarkType.FieldEnd) && (this.End == mark)) || ((mark.Type == FieldMarkType.FieldSeparator) && (this.Separator == mark)))
                        {
                            continue;
                        }
                    }
                    this.Range.InnerList.Remove(obj2);
                    obj2.Owner.ChildObjects.Remove(obj2);
                }
            }
        }

        private string method_84(Bookmark A_0)
        {
            if (A_0.BookmarkStart.OwnerParagraph != A_0.BookmarkEnd.OwnerParagraph)
            {
                return string.Empty;
            }
            bool flag = false;
            bool flag2 = false;
            string str = string.Empty;
            List<DocumentObject> list = new List<DocumentObject>();
            Paragraph ownerParagraph = A_0.BookmarkStart.OwnerParagraph;
            int num = ownerParagraph.ChildObjects.IndexOf(A_0.BookmarkStart) + 1;
            int index = ownerParagraph.ChildObjects.IndexOf(A_0.BookmarkEnd);
            while (num < index)
            {
                DocumentObject item = ownerParagraph.ChildObjects[num];
                if (item is Field)
                {
                    flag = true;
                    Field field = item as Field;
                    if (!ownerParagraph.Document.LayoutVariables.method_3().Contains(field))
                    {
                        flag2 = true;
                        field.method_49();
                    }
                }
                list.Add(item);
                num++;
            }
            if (flag2)
            {
                list = new List<DocumentObject>();
                int num5 = ownerParagraph.ChildObjects.IndexOf(A_0.BookmarkStart) + 1;
                int num6 = ownerParagraph.ChildObjects.IndexOf(A_0.BookmarkEnd);
                while (num5 < num6)
                {
                    DocumentObject obj4 = ownerParagraph.ChildObjects[num5];
                    list.Add(obj4);
                    num5++;
                }
            }
            if (!flag)
            {
                str = A_0.BookmarkStart.OwnerParagraph.Text.Substring(A_0.BookmarkStart.EndPos, A_0.BookmarkEnd.EndPos - A_0.BookmarkStart.EndPos);
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                int num2 = 0;
                int count = list.Count;
                while (num2 < count)
                {
                    DocumentObject obj2 = list[num2];
                    if (obj2 is Field)
                    {
                        num2 = list.IndexOf((obj2 as Field).Separator);
                    }
                    else if (obj2 is TextRange)
                    {
                        builder.Append((obj2 as TextRange).Text);
                    }
                    else if (obj2 is Symbol)
                    {
                        builder.Append((char) (obj2 as Symbol).CharacterCode);
                    }
                    num2++;
                }
                str = builder.ToString();
            }
            return str.Trim(new char[] { '"' });
        }

        private void method_85()
        {
            int num = 8;
            if (!this.IsLocked)
            {
                bool flag = false;
                string[] strArray2 = this.Code.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray2.Length > 1)
                {
                    foreach (string str in strArray2)
                    {
                        if (str.ToLower() == BookmarkStart.b("爭䀯", num))
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                string str2 = string.IsNullOrEmpty(base.Document.FileName) ? string.Empty : (flag ? Path.GetFullPath(base.Document.FileName) : Path.GetFileName(base.Document.FileName));
                str2 = this.method_73(str2);
                this.method_217(str2);
            }
        }

        private void method_86()
        {
            string str;
            int num = 8;
            string[] strArray = this.method_177().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder builder = new StringBuilder();
            if ((strArray.Length > 1) && (strArray[0].ToLower() == BookmarkStart.b("崭唯䘱", num)))
            {
                str = strArray[1];
                int index = 2;
                int length = strArray.Length;
                while (index < length)
                {
                    builder.Append(strArray[index]);
                    if ((index + 1) < length)
                    {
                        builder.Append(BookmarkStart.b("อ", num));
                    }
                    index++;
                }
            }
            else
            {
                str = strArray[0];
                int num2 = 1;
                int num3 = strArray.Length;
                while (num2 < num3)
                {
                    builder.Append(strArray[num2]);
                    if ((num2 + 1) < num3)
                    {
                        builder.Append(BookmarkStart.b("อ", num));
                    }
                    num2++;
                }
            }
            string str2 = builder.ToString();
            builder = null;
            Bookmark bookmark = base.Document.Bookmarks.FindByName(str);
            if ((bookmark != null) && !string.IsNullOrEmpty(str2))
            {
                this.method_87(str2, bookmark);
            }
        }

        private void method_87(string A_0, Bookmark A_1)
        {
            A_0 = A_0.Replace(Class816.string_4, Class816.string_27);
            A_0 = A_0.Replace('\n', '\r');
            this.FieldResult = A_0;
            if ((base.OwnerParagraph != null) && (this.End != null))
            {
                this.method_203();
                if (A_1.BookmarkStart.OwnerParagraph == A_1.BookmarkEnd.OwnerParagraph)
                {
                    for (int i = this.Range.Count - 1; i >= 0; i--)
                    {
                        DocumentObject obj2 = this.Range.method_8()[i] as DocumentObject;
                        if (obj2 != this.End)
                        {
                            if (obj2 == this.Separator)
                            {
                                break;
                            }
                            if (((obj2 is ParagraphBase) && !(obj2 is BookmarkEnd)) && !(obj2 is BookmarkStart))
                            {
                                this.Range.method_8().Remove(obj2);
                                base.OwnerParagraph.Items.Remove(obj2);
                            }
                        }
                    }
                    A_1.BookmarkStart.OwnerParagraph.Items.Insert(A_1.BookmarkStart.method_5() + 1, this.method_219(A_0));
                }
                this.bool_25 = false;
            }
        }

        private void method_88()
        {
            int num = 11;
            string name = this.method_177();
            bool flag = name.Contains(BookmarkStart.b("洰䄲", 11));
            bool flag2 = name.Contains(BookmarkStart.b("洰崲", 11));
            bool flag3 = name.Contains(BookmarkStart.b("洰䐲", 11));
            bool flag4 = name.Contains(BookmarkStart.b("洰䌲", 11));
            string[] strArray = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if ((strArray.Length > 1) && (strArray[0].ToLower() == BookmarkStart.b("䌰嘲匴", num)))
            {
                name = strArray[1];
            }
            else
            {
                name = strArray[0];
            }
            Bookmark bookmark = base.Document.Bookmarks.FindByName(name);
            if (((bookmark != null) && (bookmark.BookmarkStart != null)) && (bookmark.BookmarkEnd != null))
            {
                string listText = string.Empty;
                if ((!flag && !flag2) && !flag3)
                {
                    if ((flag4 && !flag) && (!flag2 && !flag3))
                    {
                        listText = string.Empty;
                    }
                    else if (bookmark.BookmarkStart.OwnerParagraph == bookmark.BookmarkEnd.OwnerParagraph)
                    {
                        listText = bookmark.BookmarkStart.OwnerParagraph.Text.Substring(bookmark.BookmarkStart.EndPos, bookmark.BookmarkEnd.EndPos - bookmark.BookmarkStart.EndPos);
                    }
                }
                else if (bookmark.BookmarkStart.OwnerParagraph != null)
                {
                    listText = bookmark.BookmarkStart.OwnerParagraph.ListText;
                }
                if (flag4)
                {
                    int num5 = -1;
                    int num6 = -1;
                    if (base.Owner == bookmark.BookmarkStart.Owner)
                    {
                        num5 = base.method_5();
                        num6 = bookmark.BookmarkStart.method_5();
                    }
                    else
                    {
                        List<DocumentObject> list = this.method_90(this);
                        List<DocumentObject> list2 = this.method_90(bookmark.BookmarkStart);
                        int num3 = -1;
                        int num4 = -1;
                        int num2 = 0;
                        int count = list.Count;
                        while (num2 < count)
                        {
                            DocumentObject item = list[num2];
                            if (list2.Contains(item))
                            {
                                num3 = num2 - 1;
                                num4 = list2.IndexOf(item) - 1;
                                break;
                            }
                            num2++;
                        }
                        if ((num3 > -1) && (num4 > -1))
                        {
                            num5 = list[num3].method_5();
                            num6 = list2[num4].method_5();
                        }
                    }
                    if ((num5 > -1) && (num6 > -1))
                    {
                        if (num5 >= num6)
                        {
                            if (!string.IsNullOrEmpty(listText))
                            {
                                listText = listText + BookmarkStart.b("ᄰ怲倴制ᤸ娺弼倾㝀♂", num);
                            }
                            else
                            {
                                listText = listText + BookmarkStart.b("瀰儲娴䄶尸", num);
                            }
                        }
                        else if (!string.IsNullOrEmpty(listText))
                        {
                            listText = listText + BookmarkStart.b("ᄰ怲倴制ᤸ夺堼匾⹀㑂", num);
                        }
                        else
                        {
                            listText = listText + BookmarkStart.b("猰嘲头堶丸", num);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(listText))
                {
                    this.method_217(listText);
                }
            }
        }

        private void method_89()
        {
            string key = this.method_177().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
            if ((base.Document.DocLayoter != null) && base.Document.DocLayoter.dictionary_1.ContainsKey(key))
            {
                this.method_217(base.Document.DocLayoter.dictionary_1[key].ToString());
            }
        }

        private List<DocumentObject> method_90(ParagraphBase A_0)
        {
            if (A_0 == null)
            {
                return null;
            }
            List<DocumentObject> list = new List<DocumentObject>();
            for (DocumentObject obj2 = A_0; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2.Owner == null)
                {
                    return list;
                }
                list.Add(obj2.Owner);
            }
            return list;
        }

        private void method_91()
        {
            DocumentObject ownerBase = base.OwnerBase as DocumentObject;
            int num = 1;
            while (!(ownerBase is Section))
            {
                if (ownerBase.Owner == null)
                {
                    break;
                }
                ownerBase = ownerBase.Owner;
            }
            if ((ownerBase != null) && (ownerBase is Section))
            {
                num += (ownerBase as Section).method_5();
            }
            this.method_217(num.ToString());
        }

        private void method_92()
        {
            this.FieldResult = this.FieldText;
        }

        private void method_93()
        {
            int num = 11;
            string str = this.method_137(this.method_177());
            str = this.method_117(str, BookmarkStart.b("唰尲嘴䜶䬸吺䴼娾㍀㝂㱄", 11));
            string str2 = string.Empty;
            if (str.Contains(BookmarkStart.b("洰ᤲ", 11)) || str.Contains(BookmarkStart.b("洰猲", num)))
            {
                int index = str.IndexOf(BookmarkStart.b("洰", num));
                str2 = str.Substring(index + 2).Trim();
                str = str.Substring(0, index).Trim();
            }
            str = str.Trim().Trim(new char[] { '"' }).ToLower();
            string author = string.Empty;
            string str4 = BookmarkStart.b("琰䄲䜴堶䬸ᨺᴼ樾⽀⡂⭄⡆㹈╊浌⭎㹐げ⁔㩖㱘㕚⥜罞ᅠᅢ੤ᝦ౨ᥪᥬ᙮兰ᵲᑴ᩶ᱸ啺", num);
            string key = str.ToLower();
            if (key != null)
            {
                int num10;
                if (Class1160.dictionary_19 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x19);
                    dictionary1.Add(BookmarkStart.b("倰䘲䄴弶嘸䤺", num), 0);
                    dictionary1.Add(BookmarkStart.b("匰䨲䄴制䨸", num), 1);
                    dictionary1.Add(BookmarkStart.b("到刲䄴制常吺似䘾", num), 2);
                    dictionary1.Add(BookmarkStart.b("到嬲吴䔶堸堺䤼娾㍀あ", num), 3);
                    dictionary1.Add(BookmarkStart.b("到嬲吴䔶堸堺䤼娾㍀あ㉄⹆㵈⍊㹌㽎ぐげご⑖", num), 4);
                    dictionary1.Add(BookmarkStart.b("到尲場娶尸唺䤼䰾", num), 5);
                    dictionary1.Add(BookmarkStart.b("到尲場䜶堸唺䐼", num), 6);
                    dictionary1.Add(BookmarkStart.b("到䄲倴嘶䴸帺䤼嘾ⱀ♂", num), 7);
                    dictionary1.Add(BookmarkStart.b("娰嘲䰴䀶嘸䤺夼䰾", num), 8);
                    dictionary1.Add(BookmarkStart.b("崰刲䘴䌶䤸䤺吼儾㕀♂⅄", num), 9);
                    dictionary1.Add(BookmarkStart.b("崰刲䘴䌶䨸娺䬼娾╀⅂㱄", num), 10);
                    dictionary1.Add(BookmarkStart.b("崰刲䘴䌶䨸娺䬼娾╀㝂ⱄ⩆ⱈ", num), 11);
                    dictionary1.Add(BookmarkStart.b("崰娲嬴制䨸", num), 12);
                    dictionary1.Add(BookmarkStart.b("尰刲嬴嘶常帺似", num), 13);
                    dictionary1.Add(BookmarkStart.b("弰刲場制嘸崺尼伾ㅀ⽂ⱄ⑆⡈㽊⑌⁎㽐", num), 14);
                    dictionary1.Add(BookmarkStart.b("帰圲場嘶崸吺帼嘾╀", num), 15);
                    dictionary1.Add(BookmarkStart.b("䄰刲刴制䨸", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䄰刲䜴嘶常䤺尼伾⥀あ", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䌰嘲䌴帶䨸刺刼儾⽀㙂⡄╆ⱈ㥊", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䈰嘲嘴䈶䬸刺䤼䘾", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䈰䘲圴崶尸堺䤼", num), 20);
                    dictionary1.Add(BookmarkStart.b("䔰嘲場䜶唸娺䤼娾", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䔰娲䄴嬶尸", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䔰尲䄴嘶唸帺夼嘾㕀⩂⭄⁆㵈≊⁌⩎", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䘰尲䜴匶䨸", num), 0x18);
                    Class1160.dictionary_19 = dictionary1;
                }
                if (Class1160.dictionary_19.TryGetValue(key, out num10))
                {
                    switch (num10)
                    {
                        case 0:
                            if (base.Document.BuiltinDocumentProperties.Author != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Author;
                            }
                            goto Label_0803;

                        case 1:
                        {
                            int bytesCount = base.Document.BuiltinDocumentProperties.BytesCount;
                            author = base.Document.BuiltinDocumentProperties.BytesCount.ToString();
                            goto Label_0803;
                        }
                        case 2:
                            if (base.Document.BuiltinDocumentProperties.Category != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Category.ToString();
                            }
                            goto Label_0803;

                        case 3:
                        case 4:
                        {
                            int charCount = base.Document.BuiltinDocumentProperties.CharCount;
                            author = base.Document.BuiltinDocumentProperties.CharCount.ToString();
                            goto Label_0803;
                        }
                        case 5:
                            if (base.Document.BuiltinDocumentProperties.Comments != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Comments;
                            }
                            else
                            {
                                author = str4;
                            }
                            goto Label_0803;

                        case 6:
                            if (base.Document.BuiltinDocumentProperties.Company != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Company;
                            }
                            goto Label_0803;

                        case 7:
                        {
                            DateTime createDate = base.Document.BuiltinDocumentProperties.CreateDate;
                            author = base.Document.BuiltinDocumentProperties.CreateDate.ToString(BookmarkStart.b("嘰", num));
                            goto Label_0803;
                        }
                        case 8:
                            if (base.Document.BuiltinDocumentProperties.Keywords != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Keywords;
                            }
                            else
                            {
                                author = str4;
                            }
                            goto Label_0803;

                        case 9:
                        {
                            DateTime lastPrinted = base.Document.BuiltinDocumentProperties.LastPrinted;
                            author = base.Document.BuiltinDocumentProperties.LastPrinted.ToString(BookmarkStart.b("嘰", num));
                            goto Label_0803;
                        }
                        case 10:
                            if (base.Document.BuiltinDocumentProperties.LastAuthor != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.LastAuthor;
                            }
                            goto Label_0803;

                        case 11:
                        {
                            DateTime lastSaveDate = base.Document.BuiltinDocumentProperties.LastSaveDate;
                            author = base.Document.BuiltinDocumentProperties.LastSaveDate.ToString(BookmarkStart.b("嘰", num));
                            goto Label_0803;
                        }
                        case 12:
                        {
                            int linesCount = base.Document.BuiltinDocumentProperties.LinesCount;
                            author = base.Document.BuiltinDocumentProperties.LinesCount.ToString();
                            goto Label_0803;
                        }
                        case 13:
                            if (base.Document.BuiltinDocumentProperties.Manager != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Manager;
                            }
                            goto Label_0803;

                        case 14:
                            if (base.Document.BuiltinDocumentProperties.ApplicationName != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.ApplicationName;
                            }
                            goto Label_0803;

                        case 15:
                            author = BookmarkStart.b("琰䄲䜴堶䬸ᨺᴼ款⥀⩂㙄杆㥈㥊≌㽎㑐⅒⅔⹖祘㉚⹜罞๠ൢ।Ṧ䥨ᵪ౬ͮᡰᝲ啴ᅶᙸॺ嵼ま얀캂쒄Ꞇ搜ﲐﮔ떚", num);
                            goto Label_0803;

                        case 0x10:
                        {
                            int pageCount = base.Document.BuiltinDocumentProperties.PageCount;
                            author = base.Document.BuiltinDocumentProperties.PageCount.ToString();
                            goto Label_0803;
                        }
                        case 0x11:
                        {
                            int paragraphCount = base.Document.BuiltinDocumentProperties.ParagraphCount;
                            author = base.Document.BuiltinDocumentProperties.ParagraphCount.ToString();
                            goto Label_0803;
                        }
                        case 0x12:
                            if (base.Document.BuiltinDocumentProperties.RevisionNumber != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.RevisionNumber.ToString();
                            }
                            goto Label_0803;

                        case 0x13:
                        {
                            int docSecurity = base.Document.BuiltinDocumentProperties.DocSecurity;
                            author = base.Document.BuiltinDocumentProperties.DocSecurity.ToString();
                            goto Label_0803;
                        }
                        case 20:
                            if (base.Document.BuiltinDocumentProperties.Subject != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Subject;
                            }
                            else
                            {
                                author = str4;
                            }
                            goto Label_0803;

                        case 0x15:
                            if (base.Document.BuiltinDocumentProperties.Template != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Template;
                            }
                            goto Label_0803;

                        case 0x16:
                            if (base.Document.BuiltinDocumentProperties.Title != null)
                            {
                                author = base.Document.BuiltinDocumentProperties.Title;
                            }
                            else
                            {
                                author = str4;
                            }
                            goto Label_0803;

                        case 0x17:
                            if (base.Document.BuiltinDocumentProperties.TotalEditingTime.TotalMinutes > 0.0)
                            {
                                author = base.Document.BuiltinDocumentProperties.TotalEditingTime.TotalMinutes.ToString();
                            }
                            goto Label_0803;

                        case 0x18:
                        {
                            int wordCount = base.Document.BuiltinDocumentProperties.WordCount;
                            author = base.Document.BuiltinDocumentProperties.WordCount.ToString();
                            goto Label_0803;
                        }
                    }
                }
            }
            if (base.Document.CustomDocumentProperties.method_6(str))
            {
                author = base.Document.CustomDocumentProperties.method_7(str).ToString();
            }
            else
            {
                author = str4;
            }
        Label_0803:
            if (str2 != string.Empty)
            {
                author = this.method_94(author, str2);
            }
            this.method_217(author);
        }

        private string method_94(string A_0, string A_1)
        {
            DateTime time;
            int num;
            string str = A_0;
            A_1 = A_1.Trim(new char[] { '"' });
            if (DateTime.TryParse(A_0, out time))
            {
                return this.method_191(A_1, time);
            }
            if (int.TryParse(A_0, out num))
            {
                str = this.method_136(A_0, A_1);
            }
            return str;
        }

        internal string method_95(string A_0, string A_1, PageNumberStyle A_2)
        {
            string str = A_0;
            A_1 = this.method_137(A_1);
            string[] strArray2 = A_1.Trim().Split(new string[] { BookmarkStart.b("焬Ԯ", 7) }, StringSplitOptions.RemoveEmptyEntries);
            FieldNumFormat format = (strArray2.Length > 0) ? this.method_98(strArray2[0].Trim()) : FieldNumFormat.Default;
            format = (format == FieldNumFormat.Default) ? this.method_96(A_2) : format;
            int num = int.Parse(A_0);
            return this.method_97(num, format);
        }

        private FieldNumFormat method_96(PageNumberStyle A_0)
        {
            FieldNumFormat arabic = FieldNumFormat.Arabic;
            switch (A_0)
            {
                case PageNumberStyle.Arabic:
                    return FieldNumFormat.Arabic;

                case PageNumberStyle.RomanUpper:
                    return FieldNumFormat.UpRoman;

                case PageNumberStyle.RomanLower:
                    return FieldNumFormat.LowRoman;

                case PageNumberStyle.LetterUpper:
                    return FieldNumFormat.UpLetter;

                case PageNumberStyle.LetterLower:
                    return FieldNumFormat.LowLetter;
            }
            return arabic;
        }

        private string method_97(int A_0, FieldNumFormat A_1)
        {
            int num = 0x11;
            switch (A_1)
            {
                case FieldNumFormat.Arabic:
                    return A_0.ToString();

                case FieldNumFormat.ArabicDash:
                    return (BookmarkStart.b("ᨶᤸ", num) + A_0.ToString() + BookmarkStart.b("᜶ᐸ", num));

                case FieldNumFormat.LowLetter:
                    return ListLevel.smethod_6(A_0).ToLower();

                case FieldNumFormat.UpLetter:
                    return ListLevel.smethod_6(A_0).ToUpper();

                case FieldNumFormat.LowRoman:
                    return ListLevel.smethod_5(A_0).ToLower();

                case FieldNumFormat.UpRoman:
                    return ListLevel.smethod_5(A_0).ToUpper();

                case FieldNumFormat.ChineseNum3:
                {
                    Class495 class9 = new Class495();
                    class9.method_1(DigitType.ChineseCountingThousand);
                    return class9.method_2(A_0.ToString());
                }
                case FieldNumFormat.ChineseNum2:
                {
                    Class495 class3 = new Class495();
                    class3.method_1(DigitType.ChineseLegalSimplified);
                    return class3.method_2(A_0.ToString());
                }
                case FieldNumFormat.Zodiac1:
                {
                    Class495 class5 = new Class495();
                    class5.method_1(DigitType.Traditional);
                    return class5.method_2(A_0.ToString());
                }
                case FieldNumFormat.Zodiac2:
                {
                    Class495 class2 = new Class495();
                    class2.method_1(DigitType.Zodiac);
                    return class2.method_2(A_0.ToString());
                }
                case FieldNumFormat.GB1:
                {
                    Class495 class8 = new Class495();
                    class8.method_1(DigitType.GB1);
                    return class8.method_2(A_0.ToString());
                }
                case FieldNumFormat.GB2:
                {
                    Class495 class4 = new Class495();
                    class4.method_1(DigitType.GB2);
                    return class4.method_2(A_0.ToString());
                }
                case FieldNumFormat.GB3:
                {
                    Class495 class7 = new Class495();
                    return class7.method_8(A_0.ToString());
                }
                case FieldNumFormat.GB4:
                {
                    Class495 class6 = new Class495();
                    return class6.method_9(A_0.ToString());
                }
            }
            return A_0.ToString();
        }

        private FieldNumFormat method_98(string A_0)
        {
            int num = 3;
            string key = A_0.ToLower();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_20 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("䠨太䰬䴮堰倲", num), 0);
                    dictionary1.Add(BookmarkStart.b("䠨太䰬䴮堰倲儴嘶䨸区", num), 1);
                    dictionary1.Add(BookmarkStart.b("嬨䐪䀬丮弰", num), 2);
                    dictionary1.Add(BookmarkStart.b("䠨䜪崬䜮倰儲倴䌶倸堺", num), 3);
                    dictionary1.Add(BookmarkStart.b("䨨䌪䐬䄮吰䀲倴夶䰸嘺฼", num), 4);
                    dictionary1.Add(BookmarkStart.b("䨨䌪䐬䄮吰䀲倴夶䰸嘺༼", num), 5);
                    dictionary1.Add(BookmarkStart.b("匨䐪䤬䘮倰倲д", num), 6);
                    dictionary1.Add(BookmarkStart.b("匨䐪䤬䘮倰倲ܴ", num), 7);
                    dictionary1.Add(BookmarkStart.b("丨䤪ᰬ", num), 8);
                    dictionary1.Add(BookmarkStart.b("丨䤪Ἤ", num), 9);
                    dictionary1.Add(BookmarkStart.b("丨䤪Ḭ", num), 10);
                    dictionary1.Add(BookmarkStart.b("丨䤪᤬", num), 11);
                    Class1160.dictionary_20 = dictionary1;
                }
                if (Class1160.dictionary_20.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            return FieldNumFormat.Arabic;

                        case 1:
                            return FieldNumFormat.ArabicDash;

                        case 2:
                            if (A_0[0] != 'r')
                            {
                                return FieldNumFormat.UpRoman;
                            }
                            return FieldNumFormat.LowRoman;

                        case 3:
                            if (A_0[0] != 'a')
                            {
                                return FieldNumFormat.UpLetter;
                            }
                            return FieldNumFormat.LowLetter;

                        case 4:
                            return FieldNumFormat.ChineseNum3;

                        case 5:
                            return FieldNumFormat.ChineseNum2;

                        case 6:
                            return FieldNumFormat.Zodiac1;

                        case 7:
                            return FieldNumFormat.Zodiac2;

                        case 8:
                            return FieldNumFormat.GB1;

                        case 9:
                            return FieldNumFormat.GB2;

                        case 10:
                            return FieldNumFormat.GB3;

                        case 11:
                            return FieldNumFormat.GB4;
                    }
                }
            }
            return FieldNumFormat.Default;
        }

        private void method_99()
        {
            if (!this.IsLocked)
            {
                this.method_100(false);
                IfField field = this as IfField;
                if (field.CompartResult.HasValue)
                {
                    this.FieldResult = field.CompartResult.Value ? field.TrueResult.method_1().string_0 : field.FalseResult.method_1().string_0;
                }
            }
        }

        protected void ParseField(string fieldCode)
        {
            char[] separator = new char[] { '\\' };
            string[] fieldValues = fieldCode.Split(separator);
            this.method_185(fieldValues[0]);
            this.ParseFieldFormat(fieldValues);
        }

        protected internal virtual void ParseFieldCode(string fieldCode)
        {
            this.m_fieldType = Class819.smethod_2(fieldCode);
            this.Code = fieldCode;
            this.UpdateFieldCode(fieldCode);
        }

        protected void ParseFieldFormat(string[] fieldValues)
        {
            int num = 1;
            string str = string.Empty;
            for (int i = 1; i < fieldValues.Length; i++)
            {
                string str3;
                string str2 = fieldValues[i];
                if (str2.Length > 0)
                {
                    str3 = smethod_0(str2).Trim(new char[] { ' ' });
                    switch (str2[0])
                    {
                        case '*':
                            goto Label_0077;
                    }
                    str = str + BookmarkStart.b("ܦ用", num) + str2;
                }
                continue;
            Label_0077:
                if (str3 == BookmarkStart.b("爦夨嬪䠬崮", num))
                {
                    this.m_textFormat = Spire.Doc.Documents.TextFormat.Uppercase;
                }
                else if (str3 == BookmarkStart.b("欦䘨尪䠬崮", num))
                {
                    this.m_textFormat = Spire.Doc.Documents.TextFormat.Lowercase;
                }
                else if (str3 == BookmarkStart.b("搦䠨嬪帬", num))
                {
                    this.m_textFormat = Spire.Doc.Documents.TextFormat.Titlecase;
                }
                else if (str3 == BookmarkStart.b("愦䀨太帬嬮爰刲䔴", num))
                {
                    this.m_textFormat = Spire.Doc.Documents.TextFormat.FirstCapital;
                }
                else
                {
                    str = str + BookmarkStart.b("ܦ用", num) + str2;
                }
            }
            if (!string.IsNullOrEmpty(str) && !this.m_formattingString.Trim().Equals(str.Trim()))
            {
                this.m_formattingString = this.m_formattingString + str;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 5;
            base.ReadXmlAttributes(reader);
            this.m_fieldType = (FieldType) reader.ReadEnum(BookmarkStart.b("缪听弮吰", 5), typeof(FieldType));
            this.m_bConvertedToText = reader.ReadBoolean(BookmarkStart.b("株䈬䄮䜰嘲䜴䌶尸强椼倾ᕀ♂㵄㍆", 5));
            if (reader.HasAttribute(BookmarkStart.b("缪䠬圮䔰甲娴䔶吸娺䤼", 5)))
            {
                this.m_textFormat = (Spire.Doc.Documents.TextFormat) reader.ReadEnum(BookmarkStart.b("缪䠬圮䔰甲娴䔶吸娺䤼", num), typeof(Spire.Doc.Documents.TextFormat));
            }
            if (reader.HasAttribute(BookmarkStart.b("截帬挮帰倲吴嬶", num)))
            {
                this.bool_23 = reader.ReadBoolean(BookmarkStart.b("截帬挮帰倲吴嬶", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("洪䐬䨮崰圲猴堶䬸嘺尼䬾㕀⩂⭄⁆", num)))
            {
                this.m_formattingString = reader.ReadString(BookmarkStart.b("洪䐬䨮崰圲猴堶䬸嘺尼䬾㕀⩂⭄⁆", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("紪䰬䌮䐰嘲", num)))
            {
                this.m_fieldValue = reader.ReadString(BookmarkStart.b("紪䰬䌮䐰嘲", num));
            }
        }

        private static string smethod_0(string A_0)
        {
            string str = A_0.Remove(0, 1);
            char[] trimChars = new char[] { '"' };
            return str.Trim(trimChars);
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            Field field2;
            FieldType type = this.Type;
            if (type <= FieldType.FieldPageRef)
            {
                switch (type)
                {
                    case FieldType.FieldNumPages:
                        goto Label_015D;

                    case FieldType.FieldPage:
                    {
                        Field field = this;
                        Paragraph paragraph = field.OwnerParagraph;
                        if (field.Owner is SDTInlineContent)
                        {
                            paragraph = (field.Owner as SDTInlineContent).OwnerParagraph;
                        }
                        dc.textRange_0 = this;
                        Class198 class4 = new Class198 {
                            drawingTextDirection_0 = DrawingTextDirection.Horizontal
                        };
                        dc.method_233(ltWidget.method_64(), field.CharacterFormat, paragraph.Format, ltWidget.method_69(), ltWidget.method_69().Width, class4);
                        return;
                    }
                }
                if (type != FieldType.FieldPageRef)
                {
                    return;
                }
                dc.method_211(this, ltWidget);
            }
            else
            {
                switch (type)
                {
                    case FieldType.FieldDocVariable:
                    {
                        Field field3 = this;
                        Paragraph paragraph3 = field3.OwnerParagraph;
                        if (field3.Owner is SDTInlineContent)
                        {
                            paragraph3 = (field3.Owner as SDTInlineContent).OwnerParagraph;
                        }
                        ltWidget.method_65(base.Document.Variables[field3.Value]);
                        Class198 class3 = new Class198 {
                            drawingTextDirection_0 = DrawingTextDirection.Horizontal
                        };
                        dc.method_233(ltWidget.method_64(), field3.CharacterFormat, paragraph3.Format, ltWidget.method_69(), ltWidget.method_69().Width, class3);
                        return;
                    }
                    case FieldType.FieldSection:
                        return;

                    case FieldType.FieldSectionPages:
                        goto Label_015D;

                    case FieldType.FieldHyperlink:
                    {
                        Hyperlink hyperlink = new Hyperlink(this);
                        dc.method_210(hyperlink, ltWidget);
                        return;
                    }
                    case FieldType.FieldMergeField:
                    {
                        MergeField field4 = this as MergeField;
                        dc.method_212(field4, ltWidget);
                        return;
                    }
                }
                return;
            }
            return;
        Label_015D:
            field2 = this;
            Paragraph ownerParagraph = field2.OwnerParagraph;
            if (field2.Owner is SDTInlineContent)
            {
                ownerParagraph = (field2.Owner as SDTInlineContent).OwnerParagraph;
            }
            Class198 class2 = new Class198 {
                drawingTextDirection_0 = DrawingTextDirection.Horizontal
            };
            dc.method_233(ltWidget.method_64(), field2.CharacterFormat, ownerParagraph.Format, ltWidget.method_69(), ltWidget.method_69().Width, class2);
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            string str2;
            Paragraph paragraph;
            int num = 3;
            SizeF empty = SizeF.Empty;
            string textToDisplay = "";
            CharacterFormat characterFormat = null;
            FieldType type = this.Type;
            if (type > FieldType.FieldAsk)
            {
                if (type > FieldType.FieldIncludeText)
                {
                    switch (type)
                    {
                        case FieldType.FieldDocProperty:
                            this.method_93();
                            if (!base.Document.LayoutVariables.method_3().Contains(this) && (this.Type != FieldType.FieldPage))
                            {
                                base.Document.LayoutVariables.method_3().Add(this);
                            }
                            goto Label_0C11;

                        case FieldType.FieldHyperlink:
                        {
                            Hyperlink hyperlink = new Hyperlink(this);
                            if (((hyperlink == null) || ((hyperlink.BookmarkName != null) && hyperlink.BookmarkName.StartsWith(BookmarkStart.b("瘨缪䈬䰮", num)))) || this.HasFieldsInRange)
                            {
                                characterFormat = base.method_27();
                                empty = dc.method_322(hyperlink.TextToDisplay, characterFormat);
                                empty = new SizeF(0f, empty.Height);
                            }
                            else if (hyperlink.PictureToDisplay != null)
                            {
                                hyperlink.PictureToDisplay.OwnerHyperlinkField = dc.field_0;
                                this.Text = (textToDisplay != null) ? textToDisplay : string.Empty;
                                if (((base.interface23_0 != null) && (base.interface23_0 is Class214)) && (hyperlink.PictureToDisplay.TextWrappingStyle == TextWrappingStyle.Inline))
                                {
                                    (base.interface23_0 as Class214).method_16(true);
                                }
                            }
                            else
                            {
                                if (this.IsInSamePara)
                                {
                                    textToDisplay = hyperlink.TextToDisplay;
                                }
                                else
                                {
                                    textToDisplay = hyperlink.TextToDisplayInCurrPara;
                                }
                                if ((!(hyperlink.Field.NextSibling is FieldMark) || ((hyperlink.Field.NextSibling as FieldMark).Type != FieldMarkType.FieldSeparator)) || ((hyperlink.Field.NextSibling.NextSibling == null) || !(hyperlink.Field.NextSibling.NextSibling is TextRange)))
                                {
                                    if ((!this.IsInSamePara && !string.IsNullOrEmpty(textToDisplay)) && (textToDisplay == hyperlink.TextToDisplay.Trim()))
                                    {
                                        characterFormat = base.method_27();
                                        foreach (DocumentObject obj3 in this.Range)
                                        {
                                            this.method_231(obj3);
                                        }
                                    }
                                    else
                                    {
                                        characterFormat = base.method_27();
                                    }
                                }
                                else
                                {
                                    DocumentObject nextSibling = null;
                                    if (hyperlink.Field.NextSibling is FieldMark)
                                    {
                                        characterFormat = (hyperlink.Field.NextSibling.NextSibling as TextRange).CharacterFormat;
                                        nextSibling = hyperlink.Field.NextSibling as DocumentObject;
                                    }
                                    if ((nextSibling != null) && !(nextSibling.NextSibling is FieldMark))
                                    {
                                        while (nextSibling != null)
                                        {
                                            if ((nextSibling.NextSibling is FieldMark) && ((nextSibling.NextSibling as FieldMark).Type == FieldMarkType.FieldEnd))
                                            {
                                                break;
                                            }
                                            nextSibling = nextSibling.NextSibling as DocumentObject;
                                            if ((nextSibling is TextRange) && (nextSibling.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                                            {
                                                TextRange range = nextSibling as TextRange;
                                                range.interface23_0 = new Class205();
                                                range.interface23_0.imethod_5(true);
                                            }
                                        }
                                    }
                                    this.CharacterFormat.ImportContainer(characterFormat);
                                    characterFormat.method_8();
                                }
                                empty = dc.method_322(textToDisplay, characterFormat);
                                this.Text = !string.IsNullOrEmpty(textToDisplay) ? textToDisplay : string.Empty;
                            }
                            goto Label_0C11;
                        }
                    }
                    if (type == FieldType.FieldUnknown)
                    {
                        this.method_83();
                    }
                }
                else
                {
                    switch (type)
                    {
                        case FieldType.FieldPrint:
                            this.method_225();
                            break;

                        case FieldType.FieldFormula:
                            goto Label_0808;

                        case FieldType.FieldMergeField:
                            if (((this as MergeField).IsToTextOfMergeFieldEvent && this.ConvertedToText) && !string.IsNullOrEmpty((this as MergeField).Text))
                            {
                                textToDisplay = (this as MergeField).TextBefore + (this as MergeField).Text + (this as MergeField).TextAfter;
                            }
                            else
                            {
                                textToDisplay = string.IsNullOrEmpty(this.Value) ? (this as MergeField).Text : this.Value;
                                textToDisplay = (this as MergeField).TextBefore + textToDisplay + (this as MergeField).TextAfter;
                                textToDisplay = (this as MergeField).method_240(textToDisplay);
                            }
                            characterFormat = base.method_27();
                            empty = dc.method_322(textToDisplay, characterFormat);
                            break;

                        case FieldType.FieldDocVariable:
                            if (!this.IsLocked)
                            {
                                this.method_78();
                                if (!base.Document.LayoutVariables.method_3().Contains(this) && (this.Type != FieldType.FieldPage))
                                {
                                    base.Document.LayoutVariables.method_3().Add(this);
                                }
                            }
                            if (((base.NextSibling != null) && (base.NextSibling is FieldMark)) && ((base.NextSibling as FieldMark).Type == FieldMarkType.FieldSeparator))
                            {
                                ((Interface1) this).imethod_0().imethod_5(true);
                            }
                            else
                            {
                                textToDisplay = base.Document.Variables[this.Value];
                                empty = dc.method_1() ? dc.method_309(textToDisplay, dc.method_376(base.method_27()), null) : dc.method_316(textToDisplay, base.method_27().Font, null);
                            }
                            break;

                        case FieldType.FieldSectionPages:
                            goto Label_060E;

                        case FieldType.FieldIncludeText:
                            this.method_127();
                            break;
                    }
                }
            }
            else
            {
                string text;
                switch (type)
                {
                    case FieldType.FieldPage:
                        text = string.Empty;
                        if (!this.IsLocked)
                        {
                            if (Class195.bool_10)
                            {
                                this.Text = "";
                                if (base.Owner is SDTInlineContent)
                                {
                                    SDTInlineContent owner = base.Owner as SDTInlineContent;
                                    int index = owner.Items.IndexOf(this);
                                    if (owner.Items.Count > (index + 2))
                                    {
                                        TextRange range2 = owner.Items[index + 2] as TextRange;
                                        if (range2 != null)
                                        {
                                            range2.Text = string.Empty;
                                        }
                                    }
                                }
                                else if (base.NextSibling.NextSibling is TextRange)
                                {
                                    (base.NextSibling.NextSibling as TextRange).Text = string.Empty;
                                }
                            }
                            else
                            {
                                text = this.Text;
                            }
                            text = this.method_95((dc.method_28().method_31() + 1).ToString(), this.method_137(this.FormattingString), dc.method_28().method_30().PageSetup.PageNumberStyle);
                            break;
                        }
                        text = this.method_227(this);
                        break;

                    case FieldType.FieldExpression:
                        goto Label_0808;

                    case FieldType.FieldPageRef:
                    {
                        string key = this.method_177().Trim().Split(new char[] { ' ' })[1];
                        if (!key.ToLower().StartsWith(BookmarkStart.b("瘨弪䈬䰮", num)))
                        {
                            string str6 = string.Empty;
                            if (!base.Document.DocLayoter.dictionary_1.ContainsKey(key))
                            {
                                str6 = this.method_227(this);
                                if (!this.IsLocked)
                                {
                                    if ((str6.Length >= 4) && string.IsNullOrEmpty(this.FormattingString))
                                    {
                                        str6 = str6.Substring(0, 3);
                                    }
                                    else if (str6.Length < 3)
                                    {
                                        str6 = str6.PadRight(3, '0');
                                    }
                                }
                                if (string.IsNullOrEmpty(this.Text.Trim()))
                                {
                                    this.Text = str6;
                                }
                            }
                            else
                            {
                                str6 = base.Document.DocLayoter.dictionary_1[key].ToString();
                                if (string.IsNullOrEmpty(this.Text.Trim()))
                                {
                                    this.Text = str6;
                                }
                            }
                            CharacterFormat format4 = base.method_27();
                            if (format4.IsSmallCaps)
                            {
                                empty = dc.method_1() ? dc.method_310(str6, dc.method_376(format4), null, true) : dc.method_317(str6, format4.Font, null, true);
                            }
                            else
                            {
                                empty = dc.method_1() ? dc.method_309(str6, dc.method_376(format4), null) : dc.method_316(str6, format4.Font, null);
                            }
                            foreach (ParagraphBase base3 in this.Range)
                            {
                                if ((base3 is TextRange) && (base3.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                                {
                                    ((Interface1) base3).imethod_0().imethod_5(true);
                                }
                            }
                        }
                        goto Label_0C11;
                    }
                    case FieldType.FieldAsk:
                        this.method_52(true);
                        this.method_225();
                        goto Label_0C11;

                    case FieldType.FieldFileName:
                        this.method_85();
                        goto Label_0C11;

                    case FieldType.FieldNumPages:
                        goto Label_060E;

                    case FieldType.FieldSet:
                        this.method_86();
                        this.method_225();
                        goto Label_0C11;

                    case FieldType.FieldIf:
                        this.method_100(true);
                        if (!base.Document.LayoutVariables.method_3().Contains(this) && (this.Type != FieldType.FieldPage))
                        {
                            base.Document.LayoutVariables.method_3().Add(this);
                        }
                        goto Label_0C11;

                    case FieldType.FieldSequence:
                        this.method_126();
                        goto Label_0C11;

                    default:
                        goto Label_0C11;
                }
                this.Text = text;
                if (base.Owner is SDTInlineContent)
                {
                    SDTInlineContent content2 = base.Owner as SDTInlineContent;
                    int num4 = content2.Items.IndexOf(this);
                    if (content2.Items.Count > (num4 + 2))
                    {
                        TextRange range3 = content2.Items[num4 + 2] as TextRange;
                        if (range3 != null)
                        {
                            this.CharacterFormat = range3.CharacterFormat;
                        }
                    }
                }
                else if (base.NextSibling.NextSibling is TextRange)
                {
                    this.CharacterFormat.method_73((base.NextSibling.NextSibling as TextRange).CharacterFormat);
                }
                CharacterFormat format3 = base.method_27();
                if (format3.IsSmallCaps)
                {
                    empty = dc.method_1() ? dc.method_310(text, dc.method_376(format3), null, true) : dc.method_317(text, format3.Font, null, true);
                }
                else
                {
                    empty = dc.method_1() ? dc.method_309(text, dc.method_376(format3), null) : dc.method_316(text, format3.Font, null);
                }
            }
            goto Label_0C11;
        Label_060E:
            str2 = this.method_227(this);
            if (!this.IsLocked)
            {
                if ((str2.Length >= 4) && string.IsNullOrEmpty(this.FormattingString))
                {
                    str2 = str2.Substring(0, 3);
                }
                else if (str2.Length < 3)
                {
                    str2 = str2.PadRight(3, '0');
                }
            }
            if (string.IsNullOrEmpty(this.Text.Trim()))
            {
                this.Text = str2;
            }
            CharacterFormat format2 = base.method_27();
            if (format2.IsSmallCaps)
            {
                empty = dc.method_1() ? dc.method_310(str2, dc.method_376(format2), null, true) : dc.method_317(str2, format2.Font, null, true);
            }
            else
            {
                empty = dc.method_1() ? dc.method_309(str2, dc.method_376(format2), null) : dc.method_316(str2, format2.Font, null);
            }
            foreach (ParagraphBase base2 in this.Range)
            {
                if ((base2 is TextRange) && (base2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                {
                    ((Interface1) base2).imethod_0().imethod_5(true);
                }
            }
            goto Label_0C11;
        Label_0808:
            if (this.IsLocked)
            {
                return new SizeF();
            }
            if (this.Code != this.method_177())
            {
                this.method_133();
                bool flag = false;
                for (int i = this.Range.Count - 1; i >= 0; i--)
                {
                    object obj4 = this.Range.method_8()[i];
                    if (((obj4 is FieldMark) && !flag) && ((obj4 as FieldMark).Type == FieldMarkType.FieldSeparator))
                    {
                        flag = true;
                    }
                    if (flag && (obj4 is TextRange))
                    {
                        this.method_231(obj4 as TextRange);
                    }
                }
                if (!base.Document.LayoutVariables.method_3().Contains(this) && (this.Type != FieldType.FieldPage))
                {
                    base.Document.LayoutVariables.method_3().Add(this);
                }
            }
        Label_0C11:
            paragraph = (base.OwnerEmptyParagraph != null) ? base.OwnerEmptyParagraph : base.method_28();
            Class44 class2 = this.method_183(paragraph);
            this.method_226(class2);
            return empty;
        }

        protected internal virtual void UpdateFieldCode(string fieldCode)
        {
            Match match;
            int num = 0x10;
            FieldType fieldType = this.m_fieldType;
            if (fieldType > FieldType.FieldFormula)
            {
                switch (fieldType)
                {
                    case FieldType.FieldLink:
                        fieldCode = fieldCode.Trim();
                        fieldCode = fieldCode.Replace(BookmarkStart.b("稵焷琹眻ḽ", num), string.Empty);
                        this.m_fieldValue = fieldCode;
                        return;

                    case FieldType.FieldIncludePicture:
                        fieldCode = fieldCode.Trim();
                        match = regex_4.Match(fieldCode);
                        this.m_fieldValue = BookmarkStart.b("ᐵ", num) + match.Groups[1].Value + BookmarkStart.b("ᐵ", num);
                        this.m_formattingString = match.Groups[2].Value;
                        return;

                    case FieldType.FieldHyperlink:
                    {
                        fieldCode = fieldCode.Trim();
                        match = regex_2.Match(fieldCode);
                        if (match.Groups[2].Value == string.Empty)
                        {
                            this.m_fieldValue = fieldCode.Replace(BookmarkStart.b("縵愷樹礻氽ిୁ੃൅", num), string.Empty);
                        }
                        else if (match.Groups[2].Value == BookmarkStart.b("樵吷", num))
                        {
                            this.m_fieldValue = fieldCode.Replace(BookmarkStart.b("縵愷樹礻氽ిୁ੃൅", num), string.Empty);
                            this.m_fieldValue = this.m_fieldValue.Replace(BookmarkStart.b("樵吷", num), string.Empty);
                        }
                        else
                        {
                            this.m_fieldValue = BookmarkStart.b("ᐵ", num) + match.Groups[2].Value + BookmarkStart.b("ᐵ", num);
                        }
                        int index = fieldCode.IndexOf(BookmarkStart.b("樵吷", num));
                        if ((match.Groups[1].Length > 0) || (index != -1))
                        {
                            this.bool_23 = true;
                            if (fieldCode.IndexOf(this.m_fieldValue) < index)
                            {
                                this.method_186(fieldCode, index);
                                return;
                            }
                        }
                        return;
                    }
                }
            }
            else
            {
                switch (fieldType)
                {
                    case FieldType.FieldPageRef:
                        fieldCode = fieldCode.Trim();
                        match = regex_0.Match(fieldCode);
                        this.m_fieldValue = match.Groups[2].Value;
                        return;

                    case FieldType.FieldFillIn:
                    {
                        fieldCode = fieldCode.Trim();
                        Match match2 = regex_1.Match(fieldCode);
                        int num2 = 2;
                        int count = match2.Groups.Count;
                        while (num2 < count)
                        {
                            if (match2.Groups[num2].Length > 0)
                            {
                                this.m_fieldValue = this.m_fieldValue + match2.Groups[num2].Value;
                            }
                            num2++;
                        }
                        return;
                    }
                    case FieldType.FieldFormula:
                        fieldCode = fieldCode.Trim();
                        fieldCode = fieldCode.Replace(BookmarkStart.b("ଵ", num), string.Empty);
                        this.m_fieldValue = fieldCode;
                        return;

                    case FieldType.FieldTOC:
                        fieldCode = fieldCode.Trim();
                        match = regex_3.Match(fieldCode);
                        this.m_formattingString = match.Groups[BookmarkStart.b("礵䠷丹唻儽⸿ㅁ", num)].Value;
                        return;
                }
            }
            this.ParseField(fieldCode);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 2;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("尧匩尫䬭", 2), this.m_paraItemType);
            writer.WriteValue(BookmarkStart.b("簧匩尫䬭", 2), this.Type);
            writer.WriteValue(BookmarkStart.b("欧䔩䈫堭唯䀱䀳匵尷渹医樽┿㩁ぃ", 2), this.ConvertedToText);
            writer.WriteValue(BookmarkStart.b("簧伩含娭瘯崱䘳嬵夷丹", 2), this.m_textFormat);
            if (this.bool_23)
            {
                writer.WriteValue(BookmarkStart.b("愧天怫䄭匯匱堳", num), this.bool_23);
            }
            if (this.m_formattingString != string.Empty)
            {
                writer.WriteValue(BookmarkStart.b("渧䌩䤫䈭启琱嬳䐵唷嬹䠻䨽⤿ⱁ⍃", num), this.m_formattingString);
            }
            if ((this.m_fieldValue != null) && (this.m_fieldValue != ""))
            {
                writer.WriteValue(BookmarkStart.b("縧䬩䀫嬭唯", num), this.m_fieldValue);
            }
        }

        public string Code
        {
            get
            {
                return this.string_15;
            }
            set
            {
                this.string_15 = value;
                if (!base.Document.bool_3)
                {
                    this.m_fieldType = Class819.smethod_2(this.string_15);
                    this.UpdateFieldCode(this.string_15);
                }
                if ((!base.Document.bool_3 && !base.Document.bool_4) && ((this.Type == FieldType.FieldMergeField) && (this.Text == string.Empty)))
                {
                    this.Text = '\x00ab' + (this as MergeField).FieldName + '\x00bb';
                }
            }
        }

        internal bool ConvertedToText
        {
            get
            {
                return this.m_bConvertedToText;
            }
            set
            {
                this.m_bConvertedToText = value;
                this.method_187();
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Field;
            }
        }

        public FieldMark End
        {
            get
            {
                if (((this.fieldMark_1 != null) && (this.fieldMark_1.OwnerParagraph != null)) && (this.fieldMark_1.OwnerParagraph.OwnerTextBody == null))
                {
                    int index = this.fieldMark_1.OwnerParagraph.Items.IndexOf(this.fieldMark_1);
                    if ((index > -1) && (index < base.OwnerParagraph.Items.Count))
                    {
                        return (base.OwnerParagraph.Items[index] as FieldMark);
                    }
                }
                return this.fieldMark_1;
            }
            set
            {
                this.fieldMark_1 = value;
            }
        }

        internal string FieldResult
        {
            get
            {
                return this.string_16;
            }
            set
            {
                this.string_16 = value;
            }
        }

        public string FieldText
        {
            get
            {
                string str = string.Empty;
                Field field = this;
                foreach (object obj2 in field.Range.method_8())
                {
                    if ((obj2 as DocumentObject).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange)
                    {
                        str = str + (obj2 as TextRange).Text;
                    }
                }
                return str;
            }
            set
            {
                if (((this.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Field) && (base.NextSibling is FieldMark)) && (base.Owner is Paragraph))
                {
                    Field field = this;
                    Paragraph owner = field.Owner as Paragraph;
                    if (((field.Type != FieldType.FieldMergeField) && (field.Type != FieldType.FieldNext)) && (field.Type != FieldType.FieldSequence))
                    {
                        List<object> list = new List<object>();
                        foreach (object obj2 in field.Range.method_8())
                        {
                            if ((obj2 as DocumentObject).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange)
                            {
                                list.Add(obj2);
                            }
                        }
                        foreach (object obj3 in list)
                        {
                            owner.Items.Remove(obj3 as DocumentObject);
                            field.Range.method_8().Remove(obj3);
                        }
                        TextRange entity = (list.Count > 0) ? ((list[0] as TextRange).Clone() as TextRange) : new TextRange(base.Document);
                        entity.Text = value;
                        entity.TextLength = value.Length;
                        if ((field.Range.method_8().Count > 1) && (list.Count > 0))
                        {
                            owner.Items.Insert(owner.Items.IndexOf(field.Range.method_8()[0] as DocumentObject) + 1, entity);
                            field.Range.method_8().Insert(1, entity);
                        }
                        if (list.Count <= 0)
                        {
                            entity.ApplyCharacterFormat(this.CharacterFormat);
                        }
                        list.Clear();
                        list = null;
                    }
                }
            }
        }

        internal string FieldValue
        {
            set
            {
                this.m_fieldValue = value;
            }
        }

        internal string FormattingString
        {
            get
            {
                return this.m_formattingString;
            }
            set
            {
                this.m_formattingString = value;
                this.method_187();
            }
        }

        internal bool HasFieldsInRange
        {
            get
            {
                if ((this.Range.Count > 0) && this.bool_26)
                {
                    this.bool_27 = this.method_176();
                }
                return this.bool_27;
            }
        }

        private List<Field> IncludeTextFieldInIfFieldList
        {
            get
            {
                if (this.list_3 == null)
                {
                    this.list_3 = new List<Field>();
                }
                return this.list_3;
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

        internal bool IsDirty
        {
            get
            {
                return this.bool_33;
            }
            set
            {
                this.bool_33 = value;
            }
        }

        internal bool IsFieldRange
        {
            get
            {
                return this.bool_22;
            }
            set
            {
                this.bool_22 = value;
            }
        }

        internal bool IsInSamePara
        {
            get
            {
                return ((this.End == null) || (base.OwnerParagraph == this.End.OwnerParagraph));
            }
        }

        internal bool IsLocal
        {
            get
            {
                return this.bool_23;
            }
            set
            {
                this.bool_23 = value;
                this.method_187();
            }
        }

        public bool IsLocked
        {
            get
            {
                return this.bool_32;
            }
            set
            {
                this.bool_32 = value;
            }
        }

        internal bool IsNotField
        {
            [CompilerGenerated]
            get
            {
                return this.bool_34;
            }
            [CompilerGenerated]
            set
            {
                this.bool_34 = value;
            }
        }

        internal bool IsRuby
        {
            get
            {
                return regex_7.IsMatch(this.Code);
            }
        }

        internal string LocalReference
        {
            get
            {
                return this.string_14;
            }
            set
            {
                this.string_14 = value;
                this.method_187();
            }
        }

        internal Class883 NestedFieldCodeObjects
        {
            get
            {
                if (this.class883_0 == null)
                {
                    this.class883_0 = new Class883(this);
                }
                return this.class883_0;
            }
        }

        public string Pattern
        {
            get
            {
                return this.string_13;
            }
            set
            {
                this.string_13 = value;
                this.method_187();
            }
        }

        internal Class44 Range
        {
            get
            {
                if (this.class44_0 == null)
                {
                    this.class44_0 = new Class44(base.Document, this);
                }
                else if ((!this.bool_25 && !base.Document.bool_3) && !base.Document.bool_5)
                {
                    this.class44_0.method_8().Clear();
                }
                if ((!this.bool_25 && !base.Document.bool_3) && !base.Document.bool_5)
                {
                    this.method_175();
                }
                return this.class44_0;
            }
        }

        internal string RtfDataFieldTag
        {
            get
            {
                return this.string_17;
            }
            set
            {
                this.string_17 = value;
            }
        }

        public FieldMark Separator
        {
            get
            {
                if (((this.fieldMark_0 != null) && (this.fieldMark_0.OwnerParagraph != null)) && (this.fieldMark_0.OwnerParagraph.OwnerTextBody == null))
                {
                    int index = this.fieldMark_0.OwnerParagraph.Items.IndexOf(this.fieldMark_0);
                    if ((index > -1) && (index < base.OwnerParagraph.Items.Count))
                    {
                        return (base.OwnerParagraph.Items[index] as FieldMark);
                    }
                }
                return this.fieldMark_0;
            }
            internal set
            {
                this.fieldMark_0 = value;
            }
        }

        internal int SourceFieldType
        {
            get
            {
                return this.int_5;
            }
            set
            {
                this.int_5 = value;
            }
        }

        public Spire.Doc.Documents.TextFormat TextFormat
        {
            get
            {
                return this.m_textFormat;
            }
            set
            {
                this.m_textFormat = value;
                this.method_187();
            }
        }

        public FieldType Type
        {
            get
            {
                return this.m_fieldType;
            }
            set
            {
                this.m_fieldType = value;
                this.method_187();
            }
        }

        public string Value
        {
            get
            {
                return this.m_fieldValue;
            }
        }

        internal enum Month
        {
            April = 4,
            August = 8,
            December = 12,
            Febrauary = 2,
            January = 1,
            July = 7,
            June = 6,
            March = 3,
            May = 5,
            November = 11,
            October = 10,
            September = 9
        }
    }
}

