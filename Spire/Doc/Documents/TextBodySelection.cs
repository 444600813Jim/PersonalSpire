namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;

    public class TextBodySelection
    {
        private Body body_0;
        private bool[] bool_0;
        private bool bool_1;
        private bool bool_2;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private string string_0;

        public TextBodySelection(ParagraphBase itemStart, ParagraphBase itemEnd)
        {
            int num = 7;
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.int_5 = -1;
            Paragraph ownerParagraph = itemStart.OwnerParagraph;
            Paragraph paragraph2 = itemEnd.OwnerParagraph;
            if (ownerParagraph.Owner != paragraph2.Owner)
            {
                throw new ArgumentException(BookmarkStart.b("䐬嬮吰帲昴䌶堸䤺䤼Ἶ⁀ⵂ⅄杆⁈㽊⡌≎ᑐ㵒ㅔ睖㑘⹚⹜⭞䅠Ţd䝦੨Ѫͬ᭮ၰᩲ᭴ቶᵸ孺ᑼᅾꆀꦈﾊ뎒ﶘ", num));
            }
            this.body_0 = ownerParagraph.OwnerTextBody;
            this.int_0 = ownerParagraph.method_5();
            this.int_1 = paragraph2.method_5();
            this.int_2 = itemStart.method_5();
            this.int_3 = itemEnd.method_5();
            this.method_1();
        }

        public TextBodySelection(IBody textBody, int itemStartIndex, int itemEndIndex, int pItemStartIndex, int pItemEndIndex)
        {
            int num = 7;
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.int_5 = -1;
            if (textBody == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("夬䨮䤰䜲眴堶崸䈺", num));
            }
            this.body_0 = (Body) textBody;
            this.int_0 = itemStartIndex;
            this.int_1 = itemEndIndex;
            this.int_2 = pItemStartIndex;
            this.int_3 = pItemEndIndex;
            this.method_1();
        }

        internal TextBodySelection(Body A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6) : this(A_0, A_1, A_2, A_3, A_4)
        {
            this.int_5 = A_6;
            this.int_4 = A_5;
            if (this.int_5 > -1)
            {
                this.bool_2 = true;
            }
            if (this.int_4 > -1)
            {
                this.bool_1 = true;
            }
        }

        internal int method_0(int A_0, int A_1, int A_2)
        {
            int num = this.int_1 - this.int_0;
            if (this.ItemStartInSDT)
            {
                num++;
                A_0++;
            }
            this.int_0 += num;
            this.int_1 += A_0;
            this.int_2 = A_2;
            if (this.int_0 == this.int_1)
            {
                this.int_2 = A_2;
                this.int_3 = A_1;
            }
            this.method_1();
            return num;
        }

        private void method_1()
        {
            int num = 8;
            if ((this.int_0 < 0) || (this.int_0 >= this.body_0.Items.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䌭漯嬱䀳匵唷椹䠻弽㈿㙁ൃ⡅ⱇ⽉㑋", num), BookmarkStart.b("䌭漯嬱䀳匵唷椹䠻弽㈿㙁ൃ⡅ⱇ⽉㑋湍㥏⅑瑓㩕㵗⥙⽛繝ᑟ੡գࡥ䡧婩䱫ŭɯ剱፳ѵᵷ᭹ࡻ᭽ꊁ겋", num) + this.body_0.Items.Count);
            }
            if ((this.int_1 < this.int_0) || (this.int_1 >= this.body_0.Items.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䌭漯嬱䀳匵唷缹刻娽िⱁ⁃⍅ぇ", num), string.Concat(new object[] { BookmarkStart.b("䌭漯嬱䀳匵唷缹刻娽िⱁ⁃⍅ぇ橉╋㵍灏㹑ㅓ╕⭗穙⡛㙝şౡ䑣", num), this.int_0, BookmarkStart.b("อ弯䀱ᐳ儵䨷弹崻䨽┿ぁ摃㉅⁇⭉≋湍", num), this.body_0.Items.Count }));
            }
            Paragraph paragraph2 = this.body_0.Items[this.int_0] as Paragraph;
            Paragraph paragraph = this.body_0.Items[this.int_1] as Paragraph;
            if ((paragraph2 != null) && ((this.int_2 < 0) || (this.int_2 > paragraph2.Items.Count)))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䌭漯䈱紳䈵崷圹漻䨽ℿぁぃཅ♇⹉⥋㙍", num), BookmarkStart.b("䌭漯䈱紳䈵崷圹漻䨽ℿぁぃཅ♇⹉⥋㙍灏㭑❓癕㑗㽙⽛ⵝ䁟ᙡౣݥ٧䩩屫乭Ὧq味ᅵ੷όᵻ੽ꒃ꺍", num) + paragraph2.Items.Count);
            }
            if ((paragraph != null) && ((this.int_3 < 0) || (this.int_3 > paragraph.Items.Count)))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䌭漯䈱紳䈵崷圹礻倽␿ୁ⩃≅ⵇ㉉", num), BookmarkStart.b("䌭漯䈱紳䈵崷圹礻倽␿ୁ⩃≅ⵇ㉉汋❍⍏牑㡓㍕⭗⥙籛⩝࡟͡੣䙥塧䩩ͫᱭ偯ᕱٳ፵᥷๹᥻౽ꁿꪉ", num) + paragraph.Items.Count);
            }
        }

        public int ItemEndIndex
        {
            get
            {
                return this.int_1;
            }
            set
            {
                this.int_1 = value;
            }
        }

        internal int ItemEndIndexInSDT
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

        internal bool ItemEndIndSDT
        {
            get
            {
                return this.bool_2;
            }
        }

        public int ItemStartIndex
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        internal int ItemStartIndexInSDT
        {
            get
            {
                return this.int_4;
            }
            set
            {
                this.int_4 = value;
            }
        }

        internal bool ItemStartInSDT
        {
            get
            {
                return this.bool_1;
            }
        }

        public int ParagraphItemEndIndex
        {
            get
            {
                return this.int_3;
            }
            set
            {
                this.int_3 = value;
            }
        }

        public int ParagraphItemStartIndex
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_2 = value;
            }
        }

        public Body TextBody
        {
            get
            {
                return this.body_0;
            }
        }
    }
}

