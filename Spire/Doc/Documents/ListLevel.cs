namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class ListLevel : DocumentSerializable
    {
        private bool[] bool_0;
        private bool bool_1;
        [CompilerGenerated]
        private bool bool_10;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        internal bool bool_7;
        internal bool bool_8;
        internal bool bool_9;
        private byte[] byte_1;
        private Spire.Doc.Formatting.CharacterFormat characterFormat_0;
        private Class496 class496_0;
        private Dictionary<int, string> dictionary_0;
        private DocPicture docPicture_0;
        private const float float_0 = 18f;
        private const float float_1 = 26f;
        private float[] float_2;
        private FollowCharacterType followCharacterType_0;
        internal int int_10;
        private const int int_2 = 0x40;
        private const int int_3 = 30;
        internal const int int_4 = 0;
        internal const int int_5 = 9;
        private int int_6;
        private int int_7;
        private int int_8;
        private int int_9;
        private ListNumberAlignment listNumberAlignment_0;
        private ListPatternType listPatternType_0;
        private Spire.Doc.Formatting.ParagraphFormat paragraphFormat_0;
        private short short_0;
        internal const string string_10 = "\a";
        internal const string string_11 = "\b";
        private readonly string[] string_12;
        private readonly string[] string_13;
        private readonly string[] string_14;
        private readonly string[] string_15;
        private readonly string[] string_16;
        private readonly string[] string_17;
        private readonly string[] string_18;
        private readonly string[] string_19;
        private string string_20;
        private string string_21;
        private string string_22;
        private string string_23;
        private string string_24;
        private string string_25;
        private string string_26;
        internal const string string_3 = "\0";
        internal const string string_4 = "\x0001";
        internal const string string_5 = "\x0002";
        internal const string string_6 = "\x0003";
        internal const string string_7 = "\x0004";
        internal const string string_8 = "\x0005";
        internal const string string_9 = "\x0006";

        internal ListLevel(Document A_0) : base(A_0, null)
        {
            this.string_12 = new string[] { 
                string.Empty, BookmarkStart.b("笳堵崷", 14), BookmarkStart.b("怳䄵圷", 14), BookmarkStart.b("怳帵䨷弹夻", 14), BookmarkStart.b("爳夵䴷䠹", 14), BookmarkStart.b("爳張丷弹", 14), BookmarkStart.b("朳張䀷", 14), BookmarkStart.b("朳匵丷弹刻", 14), BookmarkStart.b("焳張強刹䠻", 14), BookmarkStart.b("稳張嘷弹", 14), BookmarkStart.b("怳匵嘷", 14), BookmarkStart.b("焳娵崷䰹夻倽", 14), BookmarkStart.b("怳䄵崷嘹䨻嬽", 14), BookmarkStart.b("怳帵儷䠹䠻嬽┿ⱁ", 14), BookmarkStart.b("爳夵䴷䠹䠻嬽┿ⱁ", 14), BookmarkStart.b("爳張帷丹夻嬽⸿", 14), 
                BookmarkStart.b("朳張䀷丹夻嬽⸿", 14), BookmarkStart.b("朳匵丷弹刻䨽┿❁⩃", 14), BookmarkStart.b("焳張強刹䠻嬽┿ⱁ", 14), BookmarkStart.b("稳張嘷弹䠻嬽┿ⱁ", 14)
             };
            this.string_13 = new string[] { string.Empty, BookmarkStart.b("怳匵嘷", 14), BookmarkStart.b("怳䄵崷吹䠻䜽", 14), BookmarkStart.b("怳帵儷䠹䠻䜽", 14), BookmarkStart.b("爳夵䨷丹䔻", 14), BookmarkStart.b("爳張帷丹䔻", 14), BookmarkStart.b("朳張䀷丹䔻", 14), BookmarkStart.b("朳匵丷弹刻䨽㤿", 14), BookmarkStart.b("焳張強刹䠻䜽", 14), BookmarkStart.b("稳張嘷弹䠻䜽", 14) };
            this.string_14 = new string[] { 
                string.Empty, BookmarkStart.b("爳張䨷䤹䠻", 14), BookmarkStart.b("朳匵嬷唹刻娽", 14), BookmarkStart.b("怳帵儷䠹堻", 14), BookmarkStart.b("爳夵䴷䠹䠻嘽", 14), BookmarkStart.b("爳張帷丹吻", 14), BookmarkStart.b("朳張䀷丹吻", 14), BookmarkStart.b("朳匵丷弹刻䨽⠿", 14), BookmarkStart.b("焳張強刹䠻嘽", 14), BookmarkStart.b("稳張嘷丹吻", 14), BookmarkStart.b("怳匵嘷丹吻", 14), BookmarkStart.b("焳娵崷䰹夻倽㐿⩁", 14), BookmarkStart.b("怳䄵崷嘹娻䨽⠿", 14), BookmarkStart.b("怳帵儷䠹䠻嬽┿ⱁぃ⹅", 14), BookmarkStart.b("爳夵䴷䠹䠻嬽┿ⱁぃ⹅", 14), BookmarkStart.b("爳張帷丹夻嬽⸿㙁ⱃ", 14), 
                BookmarkStart.b("朳張䀷丹夻嬽⸿㙁ⱃ", 14), BookmarkStart.b("朳匵丷弹刻䨽┿❁⩃㉅⁇", 14), BookmarkStart.b("焳張強刹䠻嬽┿ⱁぃ⹅", 14), BookmarkStart.b("稳張嘷弹䠻嬽┿ⱁぃ⹅", 14)
             };
            this.string_15 = new string[] { string.Empty, BookmarkStart.b("怳匵嘷丹吻", 14), BookmarkStart.b("怳䄵崷吹䠻圽┿㙁ⱃ", 14), BookmarkStart.b("怳帵儷䠹䠻圽┿㙁ⱃ", 14), BookmarkStart.b("爳夵䨷丹唻嬽㐿⩁", 14), BookmarkStart.b("爳張帷丹唻嬽㐿⩁", 14), BookmarkStart.b("朳張䀷丹唻嬽㐿⩁", 14), BookmarkStart.b("朳匵丷弹刻䨽⤿❁ぃ⹅", 14), BookmarkStart.b("焳張強刹䠻圽┿㙁ⱃ", 14), BookmarkStart.b("稳張嘷弹䠻圽┿㙁ⱃ", 14) };
            this.string_16 = new string[] { 
                BookmarkStart.b("稳䌵吷嘹", 14), BookmarkStart.b("焳張嘷䤹", 14), BookmarkStart.b("渳䄵崷匹", 14), BookmarkStart.b("瀳䐵崷匹", 14), BookmarkStart.b("戳張崷䠹", 14), BookmarkStart.b("爳쨵嘷尹", 14), BookmarkStart.b("朳匵嬷刹伻", 14), BookmarkStart.b("朳張崷堹夻倽", 14), BookmarkStart.b("申唵倷丹", 14), BookmarkStart.b("稳匵䴷吹", 14), BookmarkStart.b("渳匵倷吹", 14), BookmarkStart.b("焳娵帷", 14), BookmarkStart.b("渳䄵츷嘹娻", 14), BookmarkStart.b("瀳䐵崷匹䘻嬽⠿ⱁ", 14), BookmarkStart.b("戳張崷䠹䘻嬽⠿ⱁ", 14), BookmarkStart.b("爳쨵嘷尹䘻嬽⠿ⱁ", 14), 
                BookmarkStart.b("朳匵嬷刹䘻嬽⠿ⱁ", 14), BookmarkStart.b("朳張崷堹䘻嬽⠿ⱁ", 14), BookmarkStart.b("申唵倷丹䘻嬽⠿ⱁ", 14), BookmarkStart.b("稳匵䴷吹䘻嬽⠿ⱁ", 14)
             };
            this.string_17 = new string[] { string.Empty, BookmarkStart.b("渳匵倷吹", 14), BookmarkStart.b("渳䄵夷吹䘻圽✿", 14), BookmarkStart.b("瀳䐵崷匹圽✿", 14), BookmarkStart.b("戳張崷䠹䘻圽✿", 14), BookmarkStart.b("爳쨵嘷尹䘻圽✿", 14), BookmarkStart.b("朳匵嬷刹䘻圽✿", 14), BookmarkStart.b("朳張崷堹䘻圽✿", 14), BookmarkStart.b("申唵倷丹䘻圽✿", 14), BookmarkStart.b("稳匵䴷吹䘻圽✿", 14) };
            this.string_18 = new string[] { 
                BookmarkStart.b("稳䌵吷嘹䠻嬽", 14), BookmarkStart.b("焳䐵䬷丹夻", 14), BookmarkStart.b("渳䄵崷匹䠻嬽", 14), BookmarkStart.b("瀳䐵儷丹䠻嬽", 14), BookmarkStart.b("戳張崷䠹䠻嬽", 14), BookmarkStart.b("爳쨵嘷尹䠻嬽", 14), BookmarkStart.b("朳匵嬷刹伻䨽┿", 14), BookmarkStart.b("朳張崷堹䠻嬽", 14), BookmarkStart.b("申唵倷丹夻", 14), BookmarkStart.b("稳匵䴷吹䠻嬽", 14), BookmarkStart.b("渳匵倷吹䠻嬽", 14), BookmarkStart.b("焳娵帷丹夻", 14), BookmarkStart.b("渳䄵츷嘹娻䨽┿", 14), BookmarkStart.b("瀳䐵崷匹䘻嬽⠿ⱁぃ⍅", 14), BookmarkStart.b("戳張崷䠹䘻嬽⠿ⱁぃ⍅", 14), BookmarkStart.b("爳쨵嘷尹䘻嬽⠿ⱁぃ⍅", 14), 
                BookmarkStart.b("朳匵嬷刹䘻嬽⠿ⱁぃ⍅", 14), BookmarkStart.b("朳張崷堹䘻嬽⠿ⱁぃ⍅", 14), BookmarkStart.b("申唵倷丹䘻嬽⠿ⱁぃ⍅", 14), BookmarkStart.b("稳匵䴷吹䘻嬽⠿ⱁぃ⍅", 14)
             };
            this.string_19 = new string[] { string.Empty, BookmarkStart.b("渳匵倷吹䠻嬽", 14), BookmarkStart.b("渳䄵夷吹䘻圽✿ㅁぃ⍅", 14), BookmarkStart.b("瀳䐵崷匹圽✿ㅁぃ⍅", 14), BookmarkStart.b("戳張崷䠹䘻圽✿ㅁぃ⍅", 14), BookmarkStart.b("爳쨵嘷尹䘻圽✿ㅁぃ⍅", 14), BookmarkStart.b("朳匵嬷刹䘻圽✿ㅁぃ⍅", 14), BookmarkStart.b("朳張崷堹䘻圽✿ㅁぃ⍅", 14), BookmarkStart.b("申唵倷丹䘻圽✿ㅁぃ⍅", 14), BookmarkStart.b("稳匵䴷吹䘻圽✿ㅁぃ⍅", 14) };
            this.string_22 = BookmarkStart.b("ᨳ", 14);
            this.string_23 = string.Empty;
            this.byte_1 = new byte[9];
            this.short_0 = -1;
            this.bool_6 = true;
            this.string_26 = string.Empty;
            this.int_10 = 0xfff;
            this.characterFormat_0 = base.m_doc.CreateCharacterFormatImpl();
            this.characterFormat_0.method_0(this);
            this.paragraphFormat_0 = base.m_doc.CreateParagraphFormatImpl();
            this.paragraphFormat_0.method_0(this);
        }

        public ListLevel(ListStyle listStyle) : this(listStyle.Document)
        {
            base.method_0(listStyle);
        }

        public ListLevel Clone()
        {
            return (ListLevel) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            ListLevel level = (ListLevel) base.CloneImpl();
            level.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            level.paragraphFormat_0 = new Spire.Doc.Formatting.ParagraphFormat(base.Document);
            level.paragraphFormat_0.ImportContainer(this.ParagraphFormat);
            level.characterFormat_0.ImportContainer(this.CharacterFormat);
            if (this.PicBullet != null)
            {
                level.PicBullet = this.docPicture_0.Clone() as DocPicture;
            }
            level.byte_1 = new byte[this.byte_1.Length];
            this.byte_1.CopyTo(level.byte_1, 0);
            return level;
        }

        public void CreateLayoutData(string numStr, byte[] characterOffsets, int levelNumber)
        {
            int startIndex = 0;
            int length = 0;
            char[] separator = new char[] { '\\', Convert.ToChar(levelNumber) };
            string[] strArray = numStr.Split(separator);
            int num3 = strArray[0].Length + 1;
            for (int i = 0; i < 9; i++)
            {
                if (characterOffsets[i] == num3)
                {
                    if (i == 0)
                    {
                        this.string_23 = numStr.Substring(0, num3 - 1);
                    }
                    else
                    {
                        startIndex = characterOffsets[i - 1];
                        length = (num3 - 1) - characterOffsets[i - 1];
                        this.string_23 = numStr.Substring(startIndex, length);
                    }
                    if ((i != 8) && (characterOffsets[i + 1] != 0))
                    {
                        length = characterOffsets[i + 1] - (num3 + 1);
                        startIndex = num3 + 1;
                        this.string_22 = numStr.Substring(startIndex, length);
                    }
                    else
                    {
                        this.string_22 = strArray[1];
                    }
                    return;
                }
            }
        }

        public string GetListItemText(int listItemIndex, ListType listType)
        {
            return this.method_5(listItemIndex, listType, true);
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("席儯䀱唳儵䨷嬹䰻嘽洿⑁⭃㑅╇⭉㡋", 8), this.paragraphFormat_0);
            base.XDLSHolder.AddElement(BookmarkStart.b("䴭堯匱䘳圵嬷丹夻䰽洿⑁⭃㑅╇⭉㡋", 8), this.characterFormat_0);
        }

        internal void method_10(int A_0)
        {
            if ((A_0 >= 0) && (A_0 <= 0x7fff))
            {
                this.int_6 = A_0;
            }
        }

        private string method_11(int A_0)
        {
            int num = 2;
            if (A_0 > 0x63)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("欧䬩䈫䀭弯䘱ᐳ䔵䴷䨹䰻儽㈿㙁摃⡅㵇❉⹋⭍≏牑㍓⑕㵗㭙⡛㭝቟䉡ၣ๥१ѩ䱫坭䥯", num));
            }
            if (A_0 < 20)
            {
                return this.string_12[A_0];
            }
            int index = (int) Math.Floor((double) (((double) A_0) / 10.0));
            int num3 = A_0 - (index * 10);
            if (num3 > 0)
            {
                return (this.string_13[index] + BookmarkStart.b("ԧ", num) + this.string_12[A_0 - (index * 10)].ToLower());
            }
            return this.string_13[index];
        }

        private string method_12(int A_0)
        {
            int num = 5;
            if (A_0 > 0x63)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("株䰬䄮弰尲䄴᜶䨸为䴼伾⹀ㅂㅄ杆❈㹊⁌ⵎ㑐⅒畔ざ⭘㹚㱜⭞Ѡᅢ䕤፦Ũ੪ͬ佮䡰䩲", num));
            }
            int num2 = (int) Math.Floor((double) (((double) A_0) / 10.0));
            int num3 = A_0 - (num2 * 10);
            if ((num2 != 1) && (num3 == 1))
            {
                return (A_0.ToString() + BookmarkStart.b("堪夬", num));
            }
            if ((num2 != 1) && (num3 == 2))
            {
                return (A_0.ToString() + BookmarkStart.b("䔪䤬", num));
            }
            if ((num2 != 1) && (num3 == 3))
            {
                return (A_0.ToString() + BookmarkStart.b("太䤬", num));
            }
            return (A_0.ToString() + BookmarkStart.b("弪䔬", num));
        }

        private string method_13(int A_0)
        {
            int num = 15;
            if (A_0 > 0x63)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("瘴嘶圸唺刼䬾慀あい㝆㥈⑊㽌㭎煐㵒⁔㩖㭘㹚⽜罞٠ᅢd٦ᵨ๪Ὤ佮հ᭲ᑴ᥶奸䉺䑼", num));
            }
            if (A_0 < 20)
            {
                return this.string_14[A_0];
            }
            int index = (int) Math.Floor((double) (((double) A_0) / 10.0));
            int num3 = A_0 - (index * 10);
            if (num3 > 0)
            {
                return (this.string_13[index] + BookmarkStart.b("ᠴ", num) + this.string_14[num3].ToLower());
            }
            return this.string_15[index];
        }

        private string method_14(int A_0)
        {
            int num = 0x10;
            if (A_0 > 0x63)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("电夷吹刻儽㐿扁㝃㍅㡇㩉⍋㱍⑏牑㩓⍕㕗㡙㥛ⱝ䁟աᙣͥ१ṩ५ᱭ偯ٱᱳ᝵ᙷ婹䕻䝽", num));
            }
            if (A_0 < 20)
            {
                return this.string_18[A_0];
            }
            int index = (int) Math.Floor((double) (((double) A_0) / 10.0));
            int num2 = A_0 - (index * 10);
            if (num2 > 0)
            {
                string str2 = (num2 == 1) ? BookmarkStart.b("猵儷吹", num) : this.string_16[num2];
                return (str2 + BookmarkStart.b("䌵嘷帹", num) + this.string_19[index].ToLower());
            }
            return this.string_19[index];
        }

        private string method_15(int A_0, LocaleIDs A_1)
        {
            switch (A_1)
            {
                case LocaleIDs.de_DE:
                case LocaleIDs.de_CH:
                case LocaleIDs.de_AT:
                case LocaleIDs.de_LU:
                case LocaleIDs.de_LI:
                    return this.method_14(A_0);
            }
            return this.method_13(A_0);
        }

        internal void method_16()
        {
            this.byte_1 = null;
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            if (this.paragraphFormat_0 != null)
            {
                this.paragraphFormat_0.Close();
                this.characterFormat_0 = null;
            }
        }

        internal string method_5(int A_0, ListType A_1, bool A_2)
        {
            return this.method_7(A_0, A_1, LocaleIDs.en_US, A_2);
        }

        internal string method_6(int A_0, ListType A_1, LocaleIDs A_2)
        {
            return this.method_7(A_0, A_1, A_2, true);
        }

        internal string method_7(int A_0, ListType A_1, LocaleIDs A_2, bool A_3)
        {
            if ((A_1 == ListType.Bulleted) && (this.PatternType != ListPatternType.Bullet))
            {
                A_1 = ListType.Numbered;
            }
            switch (A_1)
            {
                case ListType.Numbered:
                    return this.method_8(A_0, A_2, A_3);

                case ListType.Bulleted:
                    return this.string_24;
            }
            return "";
        }

        private string method_8(int A_0, LocaleIDs A_1, bool A_2)
        {
            string str2;
            Class495 class7;
            int num = 5;
            ListPatternType type = this.listPatternType_0;
            if (type > ListPatternType.LeadingZero)
            {
                switch (type)
                {
                    case ListPatternType.DecimalEnclosedCircleChinese:
                        goto Label_044D;

                    case ListPatternType.IdeographTraditional:
                    {
                        Class495 class6 = new Class495();
                        class6.method_1(DigitType.Traditional);
                        string str8 = class6.method_2((A_0 + 1).ToString());
                        if (!A_2)
                        {
                            return str8;
                        }
                        return (this.string_20 + str8 + this.string_21);
                    }
                    case ListPatternType.IdeographZodiac:
                    {
                        Class495 class8 = new Class495();
                        class8.method_1(DigitType.Zodiac);
                        string str9 = class8.method_2((A_0 + 1).ToString());
                        if (!A_2)
                        {
                            return str9;
                        }
                        return (this.string_20 + str9 + this.string_21);
                    }
                    case ListPatternType.IdeographLegalTraditional:
                    {
                        Class495 class3 = new Class495();
                        class3.method_1(DigitType.IdeographLegalTraditional);
                        string str5 = class3.method_2((A_0 + 1).ToString());
                        if (!A_2)
                        {
                            return str5;
                        }
                        return (this.string_20 + str5 + this.string_21);
                    }
                    case ListPatternType.TaiwaneseCountingThousand:
                    {
                        Class495 class5 = new Class495();
                        class5.method_1(DigitType.TaiwaneseCountingThousand);
                        string str4 = class5.method_2((A_0 + 1).ToString());
                        if (!A_2)
                        {
                            return str4;
                        }
                        return (this.string_20 + str4 + this.string_21);
                    }
                    case ListPatternType.ChineseLegalSimplified:
                    {
                        Class495 class9 = new Class495();
                        class9.method_1(DigitType.ChineseLegalSimplified);
                        string str6 = class9.method_2((A_0 + 1).ToString());
                        if (!A_2)
                        {
                            return str6;
                        }
                        return (this.string_20 + str6 + this.string_21);
                    }
                    case ListPatternType.ChineseCountingThousand:
                    {
                        Class495 class2 = new Class495();
                        class2.method_1(DigitType.ChineseCountingThousand);
                        string str = class2.method_2((A_0 + 1).ToString());
                        if (!A_2)
                        {
                            return str;
                        }
                        return (this.string_20 + str + this.string_21);
                    }
                    case ListPatternType.None:
                        if (!A_2)
                        {
                            return string.Empty;
                        }
                        if (this.string_20 == null)
                        {
                            if ((this.string_20 == null) && (this.string_21 == null))
                            {
                                return this.LevelText;
                            }
                            return string.Empty;
                        }
                        return (this.string_20 + this.string_21);

                    case ListPatternType.CustomType:
                        str2 = string.Empty;
                        if (this.class496_0.method_0() != ListPatternFormat.LeadingTwoZero)
                        {
                            if (this.class496_0.method_0() == ListPatternFormat.LeadingThreedZero)
                            {
                                str2 = BookmarkStart.b("ᬪᴬἮ0", num);
                            }
                            else if (this.class496_0.method_0() == ListPatternFormat.LeadingFourZero)
                            {
                                str2 = BookmarkStart.b("ᬪᴬἮİȲ", num);
                            }
                        }
                        else
                        {
                            str2 = BookmarkStart.b("ᬪᴬḮ", num);
                        }
                        goto Label_0406;
                }
                goto Label_057B;
            }
            switch (type)
            {
                case ListPatternType.Arabic:
                {
                    if (this.NoPlaceholder)
                    {
                        if (!A_2)
                        {
                            return "";
                        }
                        return (this.string_20 + this.string_21);
                    }
                    if (!A_2)
                    {
                        int num13 = A_0 + 1;
                        return num13.ToString();
                    }
                    int num12 = A_0 + 1;
                    return (this.string_20 + num12.ToString() + this.string_21);
                }
                case ListPatternType.UpRoman:
                    if (!A_2)
                    {
                        return smethod_5(A_0 + 1).ToUpper();
                    }
                    return (this.string_20 + smethod_5(A_0 + 1).ToUpper() + this.string_21);

                case ListPatternType.LowRoman:
                    if (!A_2)
                    {
                        return smethod_5(A_0 + 1).ToLower();
                    }
                    return (this.string_23 + smethod_5(A_0 + 1).ToLower() + this.string_22);

                case ListPatternType.UpLetter:
                    if (!A_2)
                    {
                        return smethod_6(A_0 + 1).ToUpper();
                    }
                    return (this.string_23 + smethod_6(A_0 + 1).ToUpper() + this.string_22);

                case ListPatternType.LowLetter:
                    if (!A_2)
                    {
                        if (!this.NoPlaceholder)
                        {
                            return smethod_6(A_0 + 1).ToLower();
                        }
                        return "";
                    }
                    if (this.NoPlaceholder)
                    {
                        return (this.string_20 + this.string_21);
                    }
                    return (this.string_20 + smethod_6(A_0 + 1).ToLower() + this.string_21);

                case ListPatternType.Ordinal:
                    if (!A_2)
                    {
                        return this.method_12(A_0 + 1);
                    }
                    return (this.string_23 + this.method_12(A_0 + 1) + (string.IsNullOrEmpty(this.string_21) ? this.string_22 : this.string_21));

                case ListPatternType.CardinalText:
                    if (!A_2)
                    {
                        return this.method_11(A_0 + 1);
                    }
                    return (this.string_23 + this.method_11(A_0 + 1) + (string.IsNullOrEmpty(this.string_21) ? this.string_22 : this.string_21));

                case ListPatternType.OrdinalText:
                    if (!A_2)
                    {
                        return this.method_15(A_0 + 1, A_1);
                    }
                    return (this.string_23 + this.method_15(A_0 + 1, A_1) + (string.IsNullOrEmpty(this.string_21) ? this.string_22 : this.string_21));

                case ListPatternType.JapaneseCounting:
                {
                    Class495 class4 = new Class495();
                    class4.method_1(DigitType.JapaneseCounting);
                    string str7 = class4.method_2((A_0 + 1).ToString());
                    if (!A_2)
                    {
                        return str7;
                    }
                    return (this.string_20 + str7 + this.string_21);
                }
                case ListPatternType.DecimalEnclosedCircle:
                    goto Label_044D;

                case ListPatternType.LeadingZero:
                {
                    if (!A_2)
                    {
                        int num17 = A_0 + 1;
                        return (((A_0 < 9) ? BookmarkStart.b("ᬪ", num) : "") + num17.ToString());
                    }
                    if (A_0 < 9)
                    {
                        int num5 = A_0 + 1;
                        return (this.string_20 + BookmarkStart.b("ᬪ", num) + num5.ToString() + this.string_21);
                    }
                    int num3 = A_0 + 1;
                    return (this.string_20 + num3.ToString() + this.string_21);
                }
                default:
                    goto Label_057B;
            }
        Label_0406:
            if (A_2)
            {
                int num7 = A_0 + 1;
                return (this.string_20 + this.method_9(str2, num7.ToString()) + this.string_21);
            }
            int num16 = A_0 + 1;
            return this.method_9(BookmarkStart.b("ᬪᴬἮİȲ", num), num16.ToString());
        Label_044D:
            class7 = new Class495();
            string str3 = class7.method_8((A_0 + 1).ToString());
            if (A_2)
            {
                return (this.string_20 + str3 + this.string_21);
            }
            return str3;
        Label_057B:
            if (A_2)
            {
                int num6 = A_0 + 1;
                return (this.string_23 + num6.ToString() + this.string_22);
            }
            int num18 = A_0 + 1;
            return num18.ToString();
        }

        private string method_9(string A_0, string A_1)
        {
            if (A_1.Length >= A_0.Length)
            {
                return A_1;
            }
            int length = A_1.Length;
            return (A_0.Substring(0, A_0.Length - length) + A_1);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 9;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("昮弰圲倴夶䴸", 9)))
            {
                this.TextPosition = reader.ReadFloat(BookmarkStart.b("昮弰圲倴夶䴸", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("缮䌰嘲匴朶堸伺䤼娾㍀ⵂ", num)))
            {
                this.NumberPrefix = reader.ReadString(BookmarkStart.b("缮䌰嘲匴朶堸伺䤼娾㍀ⵂ", num));
            }
            else
            {
                this.NumberPrefix = null;
            }
            if (reader.HasAttribute(BookmarkStart.b("簮䐰唲攴嘶䴸伺堼䴾⽀", num)))
            {
                this.NumberSufix = reader.ReadString(BookmarkStart.b("簮䐰唲攴嘶䴸伺堼䴾⽀", num));
            }
            else
            {
                this.NumberSufix = null;
            }
            if (reader.HasAttribute(BookmarkStart.b("洮䐰弲头制䴸欺尼䬾㕀♂㝄⥆", num)))
            {
                this.BulletCharacter = reader.ReadString(BookmarkStart.b("洮䐰弲头制䴸欺尼䬾㕀♂㝄⥆", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("缮倰䜲䄴制䬸唺椼䘾ㅀ♂", num)))
            {
                this.PatternType = (ListPatternType) reader.ReadEnum(BookmarkStart.b("缮倰䜲䄴制䬸唺椼䘾ㅀ♂", num), typeof(ListPatternType));
            }
            if (reader.HasAttribute(BookmarkStart.b("缮䌰嘲䌴朶堸伺䤼娾㍀ⵂ", num)))
            {
                this.UsePrevLevelPattern = reader.ReadBoolean(BookmarkStart.b("缮䌰嘲䌴朶堸伺䤼娾㍀ⵂ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("簮䔰刲䜴䌶砸伺", num)))
            {
                this.StartAt = reader.ReadInt(BookmarkStart.b("簮䔰刲䜴䌶砸伺", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("愮䐰帲圴制䬸稺儼嘾♀ⵂ", num)))
            {
                this.NumberAlignment = (ListNumberAlignment) reader.ReadEnum(BookmarkStart.b("愮䐰帲圴制䬸稺儼嘾♀ⵂ", num), typeof(ListNumberAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("椮帰弲头堶丸砺唼帾㍀≂♄㍆ⱈ㥊", num)))
            {
                this.FollowCharacter = (FollowCharacterType) reader.ReadEnum(BookmarkStart.b("椮帰弲头堶丸砺唼帾㍀≂♄㍆ⱈ㥊", num), typeof(FollowCharacterType));
            }
            if (reader.HasAttribute(BookmarkStart.b("昮䈰缲倴倶堸场", num)))
            {
                this.IsLegalStyleNumbering = reader.ReadBoolean(BookmarkStart.b("昮䈰缲倴倶堸场", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("愮帰愲倴䐶䴸娺似䬾", num)))
            {
                this.NoRestartByHigher = reader.ReadBoolean(BookmarkStart.b("愮帰愲倴䐶䴸娺似䬾", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("挮吰吲吴吶䀸", num)))
            {
                this.bool_4 = reader.ReadBoolean(BookmarkStart.b("挮吰吲吴吶䀸", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("挮吰吲吴吶䀸爺匼嬾⑀ⵂㅄ", num)))
            {
                this.int_9 = reader.ReadInt(BookmarkStart.b("挮吰吲吴吶䀸爺匼嬾⑀ⵂㅄ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("挮吰吲吴吶䀸栺䴼帾≀♂", num)))
            {
                this.int_8 = reader.ReadInt(BookmarkStart.b("挮吰吲吴吶䀸栺䴼帾≀♂", num));
            }
        }

        internal static bool smethod_0(int A_0)
        {
            return ((A_0 >= 0) && (A_0 < 9));
        }

        internal static bool smethod_1(string A_0)
        {
            return (((A_0 != null) && (A_0.Length <= 30)) && (A_0.IndexOf(0xffff) < 0));
        }

        internal static string smethod_2(int A_0, FootnoteNumberFormat A_1)
        {
            string str = string.Empty;
            FootnoteNumberFormat format = A_1;
            if (format <= FootnoteNumberFormat.DecimalFullWidth)
            {
                switch (format)
                {
                    case FootnoteNumberFormat.Arabic:
                        return A_0.ToString();

                    case FootnoteNumberFormat.UpperCaseRoman:
                        return smethod_5(A_0).ToUpper();

                    case FootnoteNumberFormat.LowerCaseRoman:
                        return smethod_5(A_0).ToLower();

                    case FootnoteNumberFormat.UpperCaseLetter:
                        return smethod_6(A_0).ToUpper();

                    case FootnoteNumberFormat.LowerCaseLetter:
                        return smethod_6(A_0).ToLower();

                    case (FootnoteNumberFormat.LowerCaseLetter | FootnoteNumberFormat.UpperCaseRoman):
                    case (FootnoteNumberFormat.LowerCaseLetter | FootnoteNumberFormat.LowerCaseRoman):
                    case (FootnoteNumberFormat.LowerCaseLetter | FootnoteNumberFormat.UpperCaseLetter):
                    case ((FootnoteNumberFormat) 8):
                        return str;

                    case FootnoteNumberFormat.Chicago:
                    {
                        Class495 class9 = new Class495();
                        return class9.method_5(A_0.ToString());
                    }
                    case FootnoteNumberFormat.DecimalFullWidth:
                    {
                        Class495 class6 = new Class495();
                        return class6.method_10(A_0.ToString());
                    }
                }
                return str;
            }
            switch (format)
            {
                case FootnoteNumberFormat.DecimalEnclosedCircleChinese:
                {
                    Class495 class8 = new Class495();
                    return class8.method_8(A_0.ToString());
                }
                case FootnoteNumberFormat.IdeographEnclosedCircle:
                {
                    Class495 class4 = new Class495();
                    return class4.method_9(A_0.ToString());
                }
                case FootnoteNumberFormat.IdeographTraditional:
                {
                    Class495 class2 = new Class495();
                    return class2.method_6(A_0.ToString());
                }
                case FootnoteNumberFormat.IdeographZodiac:
                {
                    Class495 class7 = new Class495();
                    return class7.method_7(A_0.ToString());
                }
                case FootnoteNumberFormat.ChineseLegalSimplified:
                {
                    Class495 class3 = new Class495();
                    class3.method_1(DigitType.ChineseLegalSimplified);
                    return class3.method_2(A_0.ToString());
                }
                case FootnoteNumberFormat.ChineseCountingThousand:
                {
                    Class495 class5 = new Class495();
                    class5.method_1(DigitType.ChineseCountingThousand);
                    return class5.method_2(A_0.ToString());
                }
                case ((FootnoteNumberFormat) 40):
                case ((FootnoteNumberFormat) 0x29):
                case ((FootnoteNumberFormat) 0x2a):
                case ((FootnoteNumberFormat) 0x2b):
                case ((FootnoteNumberFormat) 0x2c):
                case FootnoteNumberFormat.Hebrew1:
                case FootnoteNumberFormat.ArabicAlpha:
                case FootnoteNumberFormat.Hebrew2:
                case FootnoteNumberFormat.ArabicAbjad:
                    return str;
            }
            return str;
        }

        internal static ListLevel smethod_3(float A_0, string A_1, ListStyle A_2)
        {
            int num = 10;
            ListLevel level = A_2.Document.CreateListLevelImpl(A_2);
            level.int_6 = 1;
            level.listPatternType_0 = ListPatternType.Bullet;
            string str = BookmarkStart.b("搯嬱夳匵䬷ᨹ爻嬽㜿扁ᙃ⥅╇⭉≋", 10);
            string str2 = A_1;
            if (str2 != null)
            {
                if (str2 != BookmarkStart.b("蟟", num))
                {
                    if (!(str2 == BookmarkStart.b("弯", num)))
                    {
                        if (str2 == BookmarkStart.b("韟", num))
                        {
                            str = BookmarkStart.b("术嬱娳儵尷匹刻夽㌿", num);
                        }
                    }
                    else
                    {
                        str = BookmarkStart.b("猯崱䄳䐵儷弹主ḽ฿❁㍃", num);
                    }
                }
                else
                {
                    str = BookmarkStart.b("振䬱夳吵圷嘹", num);
                }
            }
            level.characterFormat_0.FontName = str;
            level.paragraphFormat_0.LeftIndent = A_0 + 18f;
            level.paragraphFormat_0.FirstLineIndent = -18f;
            level.string_24 = A_1;
            return level;
        }

        internal static ListLevel smethod_4(int A_0, int A_1, ListPatternType A_2, ListNumberAlignment A_3, ListStyle A_4)
        {
            ListLevel level = A_4.Document.CreateListLevelImpl(A_4);
            level.int_6 = 1;
            level.listPatternType_0 = A_2;
            level.listNumberAlignment_0 = A_3;
            level.NumberPrefix = string.Empty;
            level.NumberSufix = BookmarkStart.b("ᠵ", 0x10);
            level.paragraphFormat_0.LeftIndent = A_0 + 18f;
            level.paragraphFormat_0.FirstLineIndent = -18f;
            level.characterFormat_0.FontName = BookmarkStart.b("戵儷圹夻䴽怿ు⅃ㅅ桇ᡉ⍋⍍ㅏ㱑", 0x10);
            return level;
        }

        internal static string smethod_5(int A_0)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(smethod_7(ref A_0, 0x3e8, BookmarkStart.b("累", 10)));
            builder.Append(smethod_7(ref A_0, 900, BookmarkStart.b("猯缱", 10)));
            builder.Append(smethod_7(ref A_0, 500, BookmarkStart.b("琯", 10)));
            builder.Append(smethod_7(ref A_0, 400, BookmarkStart.b("猯瘱", 10)));
            builder.Append(smethod_7(ref A_0, 100, BookmarkStart.b("猯", 10)));
            builder.Append(smethod_7(ref A_0, 90, BookmarkStart.b("栯焱", 10)));
            builder.Append(smethod_7(ref A_0, 50, BookmarkStart.b("簯", 10)));
            builder.Append(smethod_7(ref A_0, 40, BookmarkStart.b("栯縱", 10)));
            builder.Append(smethod_7(ref A_0, 10, BookmarkStart.b("栯", 10)));
            builder.Append(smethod_7(ref A_0, 9, BookmarkStart.b("礯樱", 10)));
            builder.Append(smethod_7(ref A_0, 5, BookmarkStart.b("是", 10)));
            builder.Append(smethod_7(ref A_0, 4, BookmarkStart.b("礯搱", 10)));
            builder.Append(smethod_7(ref A_0, 1, BookmarkStart.b("礯", 10)));
            return builder.ToString();
        }

        internal static string smethod_6(int A_0)
        {
            Stack<int> stack = smethod_8((float) A_0);
            StringBuilder builder = new StringBuilder();
            int count = stack.Count;
            while (stack.Count > 0)
            {
                int num3 = stack.Pop();
                if (stack.Count == 0)
                {
                    smethod_9(builder, num3);
                }
            }
            string str = builder.ToString();
            builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }

        private static string smethod_7(ref int A_0, int A_1, string A_2)
        {
            StringBuilder builder = new StringBuilder();
            while (A_0 >= A_1)
            {
                A_0 -= A_1;
                builder.Append(A_2);
            }
            return builder.ToString();
        }

        private static Stack<int> smethod_8(float A_0)
        {
            int num = 8;
            if (A_0 < 0f)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("伭䈯匱嘳張嬷", num), A_0, BookmarkStart.b("砭儯帱䄳匵ᠷ夹崻倽怿ⱁ⭃㉅桇⡉⥋湍㱏㝑❓╕硗橙", num));
            }
            Stack<int> stack = new Stack<int>();
            while (((int) A_0) > 26f)
            {
                float num2 = A_0 % 26f;
                if (num2 == 0f)
                {
                    A_0 = (A_0 / 26f) - 1f;
                    num2 = 26f;
                }
                else
                {
                    A_0 /= 26f;
                }
                stack.Push((int) num2);
            }
            if (A_0 > 0f)
            {
                stack.Push((int) A_0);
            }
            return stack;
        }

        private static void smethod_9(StringBuilder A_0, int A_1)
        {
            int num = 8;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䰭䔯嬱堳刵崷䠹", num));
            }
            if ((A_1 <= 0) || (A_1 > 0x1a))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䀭䔯弱嘳匵䨷", num), BookmarkStart.b("砭儯帱䄳匵ᠷ夹崻倽怿ⱁ⭃㉅桇⡉⥋湍㱏㝑❓╕硗橙籛㽝๟١䑣ťᩧཀྵ൫ᩭᕯq味䑵乷", num));
            }
            char ch = (char) (0x40 + A_1);
            A_0.Append(ch);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x13;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("瀸唺夼娾⽀㝂", 0x13), this.TextPosition);
            writer.WriteValue(BookmarkStart.b("椸䤺堼夾ᅀ≂ㅄ㍆ⱈ㥊⍌", 0x13), this.NumberPrefix);
            writer.WriteValue(BookmarkStart.b("樸为嬼漾⁀㝂ㅄ≆㭈╊", 0x13), this.NumberSufix);
            writer.WriteValue(BookmarkStart.b("笸为儼匾⑀㝂ᕄ♆㵈㽊⡌㵎㽐", 0x13), this.BulletCharacter);
            writer.WriteValue(BookmarkStart.b("椸娺䤼䬾⑀ㅂ⭄ፆえ㭊⡌", 0x13), this.PatternType);
            writer.WriteValue(BookmarkStart.b("椸䤺堼䤾ᅀ≂ㅄ㍆ⱈ㥊⍌", 0x13), this.UsePrevLevelPattern);
            writer.WriteValue(BookmarkStart.b("樸伺尼䴾㕀ɂㅄ", 0x13), this.StartAt);
            ListStyle ownerListStyle = this.OwnerListStyle;
            if ((ownerListStyle != null) && (ownerListStyle.ListType == ListType.Numbered))
            {
                writer.WriteValue(BookmarkStart.b("眸为值崾⑀ㅂф⭆⁈ⱊ⍌", num), this.NumberAlignment);
            }
            writer.WriteValue(BookmarkStart.b("瀸䠺焼娾♀≂⥄", num), this.IsLegalStyleNumbering);
            writer.WriteValue(BookmarkStart.b("缸吺儼匾⹀㑂ل⽆⡈㥊ⱌⱎ═㙒❔", num), this.FollowCharacter);
            writer.WriteValue(BookmarkStart.b("眸吺漼娾㉀㝂⑄㕆㵈", num), this.NoRestartByHigher);
            if (this.bool_4)
            {
                writer.WriteValue(BookmarkStart.b("甸帺娼帾≀㩂", num), this.bool_4);
                writer.WriteValue(BookmarkStart.b("甸帺娼帾≀㩂ౄ⥆ⵈ⹊⍌㭎", num), this.int_9);
                writer.WriteValue(BookmarkStart.b("甸帺娼帾≀㩂ᙄ㝆⡈⡊⡌", num), this.int_8);
            }
        }

        public string BulletCharacter
        {
            get
            {
                return this.string_24;
            }
            set
            {
                this.string_24 = value;
            }
        }

        public Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
        }

        internal Class496 CustomPattern
        {
            get
            {
                return this.class496_0;
            }
            set
            {
                this.class496_0 = value;
            }
        }

        public FollowCharacterType FollowCharacter
        {
            get
            {
                return this.followCharacterType_0;
            }
            set
            {
                this.followCharacterType_0 = value;
            }
        }

        internal bool HasPictureBullet
        {
            get
            {
                return (this.PicBullet != null);
            }
        }

        internal bool IsEmptyPicture
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

        public bool IsLegalStyleNumbering
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
            }
        }

        internal int LegacyIndent
        {
            get
            {
                return this.int_9;
            }
            set
            {
                this.int_9 = value;
            }
        }

        internal int LegacySpace
        {
            get
            {
                return this.int_8;
            }
            set
            {
                this.int_8 = value;
            }
        }

        internal int LevelNumber
        {
            get
            {
                if (this.OwnerListStyle != null)
                {
                    return this.OwnerListStyle.Levels.method_6(this);
                }
                if (base.OwnerBase is OverrideLevelFormat)
                {
                    OverrideLevelFormat ownerBase = base.OwnerBase as OverrideLevelFormat;
                    return (ownerBase.OwnerBase as Class12).method_23().method_10(ownerBase);
                }
                return -1;
            }
        }

        internal Dictionary<int, string> LevelStr
        {
            get
            {
                int num = 0x11;
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<int, string>();
                    this.dictionary_0.Add(0, BookmarkStart.b("㜶", num));
                    this.dictionary_0.Add(1, BookmarkStart.b("㘶", num));
                    this.dictionary_0.Add(2, BookmarkStart.b("㔶", num));
                    this.dictionary_0.Add(3, BookmarkStart.b("㐶", num));
                    this.dictionary_0.Add(4, BookmarkStart.b("㌶", num));
                    this.dictionary_0.Add(5, BookmarkStart.b("㈶", num));
                    this.dictionary_0.Add(6, BookmarkStart.b("ㄶ", num));
                    this.dictionary_0.Add(7, BookmarkStart.b("〶", num));
                    this.dictionary_0.Add(8, BookmarkStart.b("㼶", num));
                }
                return this.dictionary_0;
            }
        }

        internal string LevelText
        {
            get
            {
                return this.string_26;
            }
            set
            {
                this.string_26 = value;
            }
        }

        internal bool NoLevelText
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

        internal bool NoPlaceholder
        {
            [CompilerGenerated]
            get
            {
                return this.bool_10;
            }
            [CompilerGenerated]
            set
            {
                this.bool_10 = value;
            }
        }

        public bool NoRestartByHigher
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        public ListNumberAlignment NumberAlignment
        {
            get
            {
                return this.listNumberAlignment_0;
            }
            set
            {
                this.listNumberAlignment_0 = value;
            }
        }

        public float NumberPosition
        {
            get
            {
                return this.paragraphFormat_0.FirstLineIndent;
            }
            set
            {
                this.paragraphFormat_0.FirstLineIndent = value;
            }
        }

        public string NumberPrefix
        {
            get
            {
                return this.string_20;
            }
            set
            {
                this.string_20 = value;
            }
        }

        public string NumberSufix
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

        protected ListStyle OwnerListStyle
        {
            get
            {
                return (base.OwnerBase as ListStyle);
            }
        }

        public Spire.Doc.Formatting.ParagraphFormat ParagraphFormat
        {
            get
            {
                return this.paragraphFormat_0;
            }
        }

        internal string ParaStyleName
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

        public ListPatternType PatternType
        {
            get
            {
                return this.listPatternType_0;
            }
            set
            {
                this.listPatternType_0 = value;
            }
        }

        internal DocPicture PicBullet
        {
            get
            {
                return this.docPicture_0;
            }
            set
            {
                this.docPicture_0 = value;
                this.docPicture_0.method_0(this);
                this.bool_6 = false;
            }
        }

        internal short PicBulletId
        {
            get
            {
                return this.short_0;
            }
            set
            {
                this.short_0 = value;
            }
        }

        internal int PicIndex
        {
            get
            {
                return this.CharacterFormat.ListPictureIndex;
            }
        }

        protected ListLevel PreviousLevel
        {
            get
            {
                ListStyle ownerListStyle = this.OwnerListStyle;
                if (ownerListStyle != null)
                {
                    int num = ownerListStyle.Levels.method_6(this);
                    if (num > 0)
                    {
                        return ownerListStyle.Levels[num - 1];
                    }
                }
                return null;
            }
        }

        public int StartAt
        {
            get
            {
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
            }
        }

        public float TabSpaceAfter
        {
            get
            {
                if (this.paragraphFormat_0.Tabs.Count > 0)
                {
                    return this.paragraphFormat_0.Tabs[0].Position;
                }
                return 0f;
            }
            set
            {
                this.paragraphFormat_0.Tabs.AddTab(value);
            }
        }

        public float TextPosition
        {
            get
            {
                return this.paragraphFormat_0.LeftIndent;
            }
            set
            {
                this.paragraphFormat_0.LeftIndent = value;
            }
        }

        public bool UsePrevLevelPattern
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

        internal bool Word6Legacy
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
    }
}

