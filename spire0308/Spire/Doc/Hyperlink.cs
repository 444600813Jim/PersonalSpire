namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using System;
    using System.Text.RegularExpressions;

    public class Hyperlink
    {
        private Spire.Doc.Fields.Field field_0;
        private float float_0;
        private HyperlinkType hyperlinkType_0;
        private int int_0;
        private long long_0;
        private ShapeObject shapeObject_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        private string string_5;

        public Hyperlink(Spire.Doc.Fields.Field hyperlink)
        {
            this.method_0(hyperlink);
            this.field_0 = hyperlink;
            this.string_5 = this.method_2(hyperlink.Code);
            this.method_1();
        }

        private void method_0(Spire.Doc.Fields.Field A_0)
        {
            int num = 0x11;
            if (A_0 == null)
            {
                throw new ArgumentException(BookmarkStart.b("瘶䬸尺䠼刾⑀ⵂㅄ杆⁈㡊浌ⅎ㹐❒畔㙖祘㵚㑜㩞ൠݢ", num), BookmarkStart.b("弶䀸䬺堼䴾ⵀ⩂⭄ⱆ", num));
            }
            if (A_0.Type != FieldType.FieldHyperlink)
            {
                throw new ArgumentException(BookmarkStart.b("瘶䬸尺䠼刾⑀ⵂㅄ杆⁈㡊浌ⅎ㹐❒畔㙖祘㍚⑜⽞Ѡᅢ।๦ݨj", num), BookmarkStart.b("弶䀸䬺堼䴾ⵀ⩂⭄ⱆ", num));
            }
        }

        private void method_1()
        {
            int num = 1;
            string str = this.field_0.Value;
            switch (str)
            {
                case null:
                case string.Empty:
                    return;
            }
            if (str.StartsWith(BookmarkStart.b("Ԧ䄨弪夬弮", num)))
            {
                this.hyperlinkType_0 = HyperlinkType.WebLink;
                this.string_1 = str;
            }
            else if (str.StartsWith(BookmarkStart.b("Ԧ䐨䨪䐬䌮䔰尲", num)))
            {
                this.hyperlinkType_0 = HyperlinkType.EMailLink;
                this.string_1 = str;
            }
            else if (!this.field_0.IsLocal && (this.field_0.FormattingString.IndexOf(BookmarkStart.b("䬦", num)) == -1))
            {
                this.hyperlinkType_0 = HyperlinkType.FileLink;
                this.string_0 = str;
            }
            else
            {
                this.hyperlinkType_0 = HyperlinkType.Bookmark;
                if ((this.field_0.LocalReference != null) && (this.field_0.LocalReference != string.Empty))
                {
                    this.string_2 = this.field_0.LocalReference;
                    this.string_0 = str;
                }
                else
                {
                    this.string_2 = str;
                }
            }
            this.method_3();
        }

        private void method_10(string A_0)
        {
            int num = 13;
            if ((this.hyperlinkType_0 != HyperlinkType.WebLink) && (this.hyperlinkType_0 != HyperlinkType.EMailLink))
            {
                throw new ArgumentException(BookmarkStart.b("昲䜴帶ᤸ堺尼儾慀⅂⁄杆㩈⹊㥌潎㹐㵒㥔⹖祘㵚㉜ⵞ䅠䅢㉤ɦ୨❪ѬŮᩰ兲啴ᡶ୸孺彼㩾첀얈뎐뎒ﺚ뾞캠얢薤쾦킨\udbaa\uc8ac\uddae\uddb0\udab2\udbb4\udcb6", num));
            }
            A_0 = this.method_15(A_0);
            this.field_0.m_fieldValue = this.method_13(A_0);
        }

        private void method_11(string A_0)
        {
            int num = 4;
            if (this.hyperlinkType_0 != HyperlinkType.Bookmark)
            {
                throw new ArgumentException(BookmarkStart.b("栩䌫䄭嬯弱唳䐵匷ᨹ刻弽ⴿ❁摃╅⥇⑉汋ⱍ㕏牑❓㍕ⱗ穙㍛そ౟᭡䑣eݧᡩ䱫䱭㉯ᵱ᭳ᵵᕷ᭹๻ᕽꉿꊁﾅ겋늑ﲓﾙ즟첡쾣", num));
            }
            this.field_0.m_fieldValue = this.method_13(A_0);
        }

        private void method_12(string A_0)
        {
            int num = 0x10;
            if ((this.hyperlinkType_0 != HyperlinkType.FileLink) && (this.hyperlinkType_0 != HyperlinkType.Bookmark))
            {
                throw new ArgumentException(BookmarkStart.b("瀵儷嘹夻ḽ〿⍁ぃ⹅桇⥉ⵋ⁍灏けㅓ癕⭗㽙⡛繝ཟౡࡣὥ䡧౩ͫᱭ偯偱㉳ήᑷόほ᝽ꚃꚅ겋겍튏﶑ﮓﶕﮙ芟芡킣\udfa5\ud8a7쾩貫솭횯銱\udcb3\ucfb5좷\udfb9\ucebb튽ꦿ곁꿃", num));
            }
            A_0 = this.method_14(A_0);
            this.field_0.m_fieldValue = this.method_13(A_0);
            if (this.hyperlinkType_0 == HyperlinkType.Bookmark)
            {
                if ((this.string_2 == null) || (this.string_2 == string.Empty))
                {
                    throw new ArgumentException(BookmarkStart.b("琵圷唹圻匽ℿぁ⽃晅♇⭉⅋⭍灏ㅑ㕓㡕罗⹙籛㱝՟䉡੣፥ѧ٩䱫ŭɯ剱ᅳ᭵ࡷ๹ջ偽ꁿ삁ﲍﮏ늑望ﾙ벛햟톡킣蚥쪧쾩貫\uddad\ud5af욱钳풵\uddb7\udcb9펻첽ꖿꋃ꿅꓇꿉뻍뇏ꛑ볓", num));
                }
                this.field_0.LocalReference = this.method_13(this.string_2);
            }
            this.string_0 = A_0;
        }

        private string method_13(string A_0)
        {
            int num = 0;
            if (!A_0.StartsWith(BookmarkStart.b("Х", 0)))
            {
                A_0 = BookmarkStart.b("Х", num) + A_0;
            }
            if (!A_0.EndsWith(BookmarkStart.b("Х", num)))
            {
                A_0 = A_0 + BookmarkStart.b("Х", num);
            }
            return A_0;
        }

        private string method_14(string A_0)
        {
            int num = 11;
            char[] separator = new char[] { '\\' };
            string[] strArray = A_0.Split(separator);
            A_0 = string.Empty;
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                if (strArray[index] != string.Empty)
                {
                    A_0 = A_0 + strArray[index];
                    if (index < (length - 1))
                    {
                        A_0 = A_0 + BookmarkStart.b("洰漲", num);
                    }
                }
                index++;
            }
            return A_0;
        }

        private string method_15(string A_0)
        {
            int num = 9;
            A_0 = A_0.Replace(BookmarkStart.b("മ", 9), string.Empty);
            string str = string.Empty;
            if (this.hyperlinkType_0 == HyperlinkType.WebLink)
            {
                if (!A_0.Contains(BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ", num)) && !A_0.Contains(BookmarkStart.b("䜮䔰䜲䔴䐶̸ᐺሼ", num)))
                {
                    str = str + BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ", num);
                }
            }
            else
            {
                str = str + BookmarkStart.b("䈮倰娲头䌶嘸ĺ", num);
            }
            if (!A_0.StartsWith(str))
            {
                A_0 = str + A_0;
            }
            return A_0;
        }

        private string method_2(string A_0)
        {
            int num = 9;
            if (string.IsNullOrEmpty(A_0))
            {
                return null;
            }
            Match match = new Regex(BookmarkStart.b("ܮ礰樲攴父欸眺琼焾ੀᡂ᥄㑆ᕈᡊ၌摎湐穒絔ୖ՘Zㅜ㉞འౢᅤ㩦䁨䍪㙬㍮ɰ⽲♴⩶卸剺", num)).Match(A_0);
            string str = null;
            if (match.Success)
            {
                str = match.Groups[3].Value.Replace(BookmarkStart.b("朮栰挲瀴收甸爺猼琾", num), string.Empty).Trim();
                char[] trimChars = new char[] { '"', '\'' };
                return str.TrimStart(trimChars).TrimEnd(trimChars);
            }
            return str;
        }

        private void method_3()
        {
            int num = 0;
            if (this.field_0.OwnerParagraph != null)
            {
                bool flag = false;
                Paragraph ownerParagraph = this.field_0.OwnerParagraph;
                int num2 = this.method_7(ref ownerParagraph);
                if (num2 != -1)
                {
                    for (ParagraphBase base2 = ownerParagraph.Items[num2]; !(base2 is FieldMark); base2 = ownerParagraph.Items[num2])
                    {
                        base2 = ownerParagraph.Items[num2];
                        if ((base2 is TextRange) && !(base2 is Spire.Doc.Fields.Field))
                        {
                            this.string_3 = this.string_3 + (base2 as TextRange).Text;
                        }
                        else if (base2 is ShapeObject)
                        {
                            this.shapeObject_0 = base2 as ShapeObject;
                        }
                        else if ((base2 is Break) && ((base2 as Break).BreakType == BreakType.LineBreak))
                        {
                            this.string_3 = this.string_3 + BookmarkStart.b("ⴥ", num);
                        }
                        num2++;
                        if (ownerParagraph.Items.Count <= num2)
                        {
                            if ((ownerParagraph.NextSibling == null) || !(ownerParagraph.NextSibling is Paragraph))
                            {
                                break;
                            }
                            if (!flag)
                            {
                                flag = true;
                                this.string_4 = this.string_3;
                            }
                            this.string_3 = this.string_3 + BookmarkStart.b("⬥∧", num);
                            if (ownerParagraph.LastItem is Spire.Doc.Fields.Field)
                            {
                                num2 = 1;
                            }
                            else
                            {
                                num2 = 0;
                            }
                            for (ownerParagraph = ownerParagraph.NextSibling as Paragraph; ownerParagraph.ChildObjects.Count == 0; ownerParagraph = ownerParagraph.NextSibling as Paragraph)
                            {
                                if ((ownerParagraph.NextSibling == null) || !(ownerParagraph.NextSibling is Paragraph))
                                {
                                    break;
                                }
                                this.string_3 = this.string_3 + BookmarkStart.b("⬥∧", num);
                            }
                        }
                    }
                }
            }
        }

        private void method_4()
        {
            if (this.field_0.OwnerParagraph != null)
            {
                Paragraph ownerParagraph = this.field_0.OwnerParagraph;
                int num = this.method_7(ref ownerParagraph);
                this.method_6(ownerParagraph, num);
                if (ownerParagraph.Items[num] is TextRange)
                {
                    (ownerParagraph.Items[num] as TextRange).Text = this.string_3;
                }
                else if (ownerParagraph.Items[num] is DocPicture)
                {
                    TextRange entity = new TextRange(ownerParagraph.Document) {
                        Text = this.string_3
                    };
                    ownerParagraph.Items.RemoveAt(num);
                    ownerParagraph.Items.Insert(num, entity);
                }
            }
        }

        private void method_5()
        {
            if (this.field_0.OwnerParagraph != null)
            {
                Paragraph ownerParagraph = this.field_0.OwnerParagraph;
                int num = this.method_7(ref ownerParagraph);
                this.method_6(ownerParagraph, num);
                ownerParagraph.Items.RemoveAt(num);
                ownerParagraph.Items.Insert(num, this.shapeObject_0);
            }
        }

        private void method_6(Paragraph A_0, int A_1)
        {
            if (!(A_0.Items[A_1 + 1] is FieldMark))
            {
                while (!(A_0.Items[A_1 + 1] is FieldMark))
                {
                    A_0.Items.RemoveAt(A_1 + 1);
                }
            }
        }

        private int method_7(ref Paragraph A_0)
        {
            DocumentObject obj2 = this.field_0;
            int num = this.method_8(obj2);
            if (num >= 0)
            {
                int num2 = this.field_0.method_5() + num;
                if ((num2 == (A_0.ChildObjects.Count - 1)) && ((A_0.ChildObjects[num2] is Spire.Doc.Fields.Field) || (A_0.ChildObjects[num2] is FieldMark)))
                {
                    while (A_0.NextSibling != null)
                    {
                        if (!(A_0.NextSibling is Paragraph))
                        {
                            break;
                        }
                        if (A_0.ChildObjects[num2] is FieldMark)
                        {
                            num2 = 0;
                            A_0 = A_0.NextSibling as Paragraph;
                        }
                        else
                        {
                            A_0 = A_0.NextSibling as Paragraph;
                            num2 = this.method_8(A_0.ChildObjects[0]);
                        }
                        if (num2 >= 0)
                        {
                            break;
                        }
                    }
                }
                ParagraphBase base2 = A_0.Items[num2];
                if ((base2 is TextRange) || (base2 is ShapeObject))
                {
                    return num2;
                }
            }
            return -1;
        }

        private int method_8(DocumentObject A_0)
        {
            int num = 0;
            while (A_0.NextSibling != null)
            {
                if (((A_0 is FieldMark) && ((A_0 as FieldMark).Type == FieldMarkType.FieldSeparator)) && ((A_0.NextSibling is FieldMark) && ((A_0.NextSibling as FieldMark).Type == FieldMarkType.FieldEnd)))
                {
                    return -1;
                }
                if (A_0.NextSibling is FieldMark)
                {
                    num++;
                }
                else if ((A_0.NextSibling is TextRange) || (A_0.NextSibling is ShapeObject))
                {
                    num++;
                    return num;
                }
                if (num > 3)
                {
                    return -1;
                }
                A_0 = A_0.NextSibling as DocumentObject;
            }
            return num;
        }

        private void method_9()
        {
            if (this.hyperlinkType_0 == HyperlinkType.Bookmark)
            {
                this.field_0.IsLocal = true;
            }
            else
            {
                this.field_0.LocalReference = null;
                this.field_0.m_formattingString = string.Empty;
            }
        }

        public string BookmarkName
        {
            get
            {
                int num = 10;
                if (string.IsNullOrEmpty(this.string_2))
                {
                    return this.string_2;
                }
                return this.string_2.Replace(BookmarkStart.b("ሯ", num), string.Empty);
            }
            set
            {
                this.method_11(value);
                this.string_2 = value;
            }
        }

        internal Spire.Doc.Fields.Field Field
        {
            get
            {
                return this.field_0;
            }
        }

        public string FilePath
        {
            get
            {
                return this.string_0.Replace(BookmarkStart.b("ᄲ", 13), string.Empty);
            }
            set
            {
                this.method_12(value);
            }
        }

        public ShapeObject PictureToDisplay
        {
            get
            {
                return this.shapeObject_0;
            }
            set
            {
                this.shapeObject_0 = value;
                this.method_5();
            }
        }

        public string TextToDisplay
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
                this.method_4();
            }
        }

        internal string TextToDisplayInCurrPara
        {
            get
            {
                return this.string_4;
            }
        }

        internal string ToolTip
        {
            get
            {
                int num = 13;
                if (string.IsNullOrEmpty(this.string_5))
                {
                    return this.string_5;
                }
                return this.string_5.Replace(BookmarkStart.b("ᄲ", num), string.Empty);
            }
            set
            {
                this.string_5 = value;
            }
        }

        public HyperlinkType Type
        {
            get
            {
                return this.hyperlinkType_0;
            }
            set
            {
                this.hyperlinkType_0 = value;
                this.method_9();
            }
        }

        public string Uri
        {
            get
            {
                return this.string_1.Replace(BookmarkStart.b("Х", 0), string.Empty);
            }
            set
            {
                this.method_10(value);
                this.string_1 = value;
            }
        }
    }
}

