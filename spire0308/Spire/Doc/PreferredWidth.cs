namespace Spire.Doc
{
    using System;

    public class PreferredWidth
    {
        private bool[] bool_0;
        private bool bool_1;
        private byte byte_0;
        internal const int int_0 = 50;
        private static PreferredWidth preferredWidth_0 = new PreferredWidth(WidthType.Auto, 0);
        private static PreferredWidth preferredWidth_1 = new PreferredWidth(WidthType.None, 0);
        private short short_0;
        private string[] string_0;
        private string string_1;
        private WidthType widthType_0;

        public PreferredWidth(WidthType type, short value)
        {
            int num = 2;
            this.widthType_0 = WidthType.Auto;
            switch (type)
            {
                case WidthType.None:
                case WidthType.Auto:
                    if (value != 0)
                    {
                        throw new ArgumentException(string.Format(BookmarkStart.b("缧䈩䤫䀭ု䘱尳匵ᠷ丹䔻丽┿扁ⵃ㕅桇ㅉ籋㍍籏牑⁓㹕㵗穙⩛㽝౟ᝡţ乥፧孩ᅫ䝭偯άųյ౷婹ṻ᭽ꁿ늁", num), type, value), BookmarkStart.b("帧䬩䀫嬭唯", num));
                    }
                    break;

                case WidthType.Percentage:
                    if ((value < 0) || (value > 600))
                    {
                        throw new ArgumentException(string.Format(BookmarkStart.b("缧䈩䤫䀭ု䘱尳匵ᠷ丹䔻丽┿扁ⵃ㕅桇ㅉ籋㍍籏牑⁓㹕㵗穙⩛㽝౟ᝡţ乥፧孩ᅫ䝭偯άųյ౷婹ṻ᭽ꁿꖇﶓﶗ몙ﶛ쒟芡좣쎥\udba7\ud9a9貫\udaad\ud8af펱\udab3\u96b5ힷ좹鲻\udbbd\ub1bf럁ꗃ꫅뻉ꏋ", num), type, value), BookmarkStart.b("帧䬩䀫嬭唯", num));
                    }
                    break;

                case WidthType.Twip:
                    if ((value < 0) || (value > 0x7bc0))
                    {
                        throw new ArgumentException(string.Format(BookmarkStart.b("缧䈩䤫䀭ု䘱尳匵ᠷ丹䔻丽┿扁ⵃ㕅桇ㅉ籋㍍籏牑⁓㹕㵗穙⩛㽝౟ᝡţ乥፧孩ᅫ䝭偯άųյ౷婹ṻ᭽ꁿꖇﶓﶗ몙ﶛ쒟芡얣좥첧誩삫쮭쎯솱钳습킷\udbb9\ud2bb麽꾿냁ꏅ맇뿉귋ꋍꛑ믓\ud8df\ud2e1", num), type, value), BookmarkStart.b("帧䬩䀫嬭唯", num));
                    }
                    break;
            }
            this.widthType_0 = type;
            this.short_0 = value;
        }

        public static PreferredWidth Auto
        {
            get
            {
                return preferredWidth_0;
            }
        }

        internal bool IsFixed
        {
            get
            {
                return (this.widthType_0 == WidthType.Twip);
            }
        }

        public static PreferredWidth None
        {
            get
            {
                return None;
            }
        }

        public WidthType Type
        {
            get
            {
                return this.widthType_0;
            }
        }

        public short Value
        {
            get
            {
                return this.short_0;
            }
        }
    }
}

