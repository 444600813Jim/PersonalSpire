namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class ListFormat : WordAttrCollection
    {
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private const int int_10 = 2;
        internal const int int_11 = 3;
        private const int int_12 = 4;
        private const int int_13 = 5;
        private int[] int_14;
        private int[] int_15;
        private const int int_16 = 6;
        private const int int_17 = 7;
        private int[] int_18;
        internal const int int_19 = 0x66866c89;
        [ThreadStatic]
        private static int int_20;
        internal const int int_8 = 0;
        internal const int int_9 = 1;
        private long[] long_3;
        [ThreadStatic]
        private static string string_3;

        public ListFormat(IParagraph owner) : base(owner.Document, (DocumentObject) owner)
        {
        }

        internal ListFormat(Document A_0, Class13 A_1) : base(A_0)
        {
            base.method_0(A_1);
        }

        public ListFormat(Document doc, ParagraphStyle owner) : base(doc)
        {
            base.method_0(owner);
        }

        public void ApplyBulletStyle()
        {
            this.ApplyStyle(BookmarkStart.b("猰䘲头嬶尸伺堼嬾", 11));
        }

        public void ApplyNumberedStyle()
        {
            this.ApplyStyle(BookmarkStart.b("搩夫䌭刯圱䘳匵尷", 4));
        }

        internal override void ApplyProperty()
        {
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(ListFormat);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int num2 = (int) info.GetValue(info.FieldType);
                base.method_31(num2);
            }
        }

        public void ApplyStyle(string styleName)
        {
            if (!string.IsNullOrEmpty(styleName))
            {
                base[2] = styleName;
                string_3 = styleName;
                base[1] = this.CurrentListStyle.ListType;
                this.bool_4 = false;
            }
        }

        public void ContinueListNumbering()
        {
            this.ApplyStyle(string_3);
            this.ListLevelNumber = int_20;
        }

        public void DecreaseIndentLevel()
        {
            int num = 7;
            if (int_20 == 0)
            {
                throw new ArgumentException(BookmarkStart.b("愬䘮䈰䜲ᔴ嬶尸䴺堼匾慀⹂い㑆㵈歊⽌⩎煐㽒ご⑖⩘筚敜罞`ൢŤ䝦๨ᥪ࡬๮հᙲݴ坶൸፺᡼ᅾꆀ뎂", num));
            }
            base[0] = --int_20;
        }

        protected override object GetDefValue(int key)
        {
            int num = 1;
            ListFormat format = ((this.OwnerParagraph == null) || (this.OwnerParagraph.ParaStyle == null)) ? null : this.OwnerParagraph.ParaStyle.ListFormat;
            if ((((format != null) && (format != this)) && ((format.CurrentListStyle != null) && (format.CurrentListLevel != null))) && (this.OwnerParagraph.ParaStyle.StyleId == format.CurrentListLevel.ParaStyleName))
            {
                return format[key];
            }
            switch (key)
            {
                case 0:
                    return 0;

                case 1:
                    return Spire.Doc.Documents.ListType.NoList;

                case 2:
                case 6:
                    return string.Empty;

                case 3:
                    return false;

                case 4:
                case 7:
                    return null;

                case 5:
                    return -1;
            }
            throw new ArgumentException(BookmarkStart.b("䰦䰨刪ബ䜮倰䀲ᔴ帶圸䴺尼匾⡀❂敄ㅆ⡈❊㡌⩎", num));
        }

        public void IncreaseIndentLevel()
        {
            int num = 7;
            if (int_20 == 8)
            {
                throw new ArgumentException(BookmarkStart.b("愬䘮䈰䜲ᔴ嬶尸䴺堼匾慀⹂い㑆㵈歊⽌⩎煐㽒ご⑖⩘筚敜罞`ൢŤ䝦๨ᥪ࡬๮հᙲݴ坶൸፺᡼ᅾꆀ뎂", num));
            }
            base[0] = ++int_20;
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x10;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("稵帷唹漻䨽㤿⹁⅃ࡅ⥇❉⥋", 0x10)))
            {
                this.LFOStyleName = reader.ReadString(BookmarkStart.b("稵帷唹漻䨽㤿⹁⅃ࡅ⥇❉⥋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稵崷䰹夻刽฿㝁⥃⑅ⵇ㡉", num)))
            {
                base[0] = reader.ReadInt(BookmarkStart.b("稵崷䰹夻刽฿㝁⥃⑅ⵇ㡉", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("砵夷圹夻", num)))
            {
                base[2] = reader.ReadString(BookmarkStart.b("砵夷圹夻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稵儷䤹䠻樽㤿㉁⅃", num)))
            {
                base[1] = (Spire.Doc.Documents.ListType) reader.ReadEnum(BookmarkStart.b("稵儷䤹䠻樽㤿㉁⅃", num), typeof(Spire.Doc.Documents.ListType));
            }
        }

        public void RemoveList()
        {
            base[2] = string.Empty;
            string_3 = string.Empty;
            base[1] = Spire.Doc.Documents.ListType.NoList;
            this.bool_3 = true;
            this.bool_4 = true;
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 12;
            base.WriteXmlAttributes(writer);
            if (base.HasKey(0))
            {
                writer.WriteValue(BookmarkStart.b("縱儳䀵崷嘹爻䬽ⴿ⁁⅃㑅", num), this.ListLevelNumber);
            }
            if (base.HasKey(2))
            {
                writer.WriteValue(BookmarkStart.b("簱唳嬵崷", num), this.CustomStyleName);
            }
            if (base.HasKey(1))
            {
                writer.WriteValue(BookmarkStart.b("縱崳䔵䰷渹䔻丽┿", num), this.ListType);
            }
            if (base.HasKey(4))
            {
                writer.WriteValue(BookmarkStart.b("縱刳夵欷丹䔻刽┿ు╃⭅ⵇ", num), this.LFOStyleName);
            }
        }

        public ListLevel CurrentListLevel
        {
            get
            {
                if (((string) base[2]) == string.Empty)
                {
                    return null;
                }
                if (this.ListLevelNumber >= this.CurrentListStyle.Levels.Count)
                {
                    return this.CurrentListStyle.Levels[this.CurrentListStyle.Levels.Count - 1];
                }
                return this.CurrentListStyle.Levels[this.ListLevelNumber];
            }
        }

        public ListStyle CurrentListStyle
        {
            get
            {
                if (((string) base[2]) != string.Empty)
                {
                    return base.Document.ListStyles.FindByName(this.CustomStyleName);
                }
                return null;
            }
        }

        public string CustomStyleName
        {
            get
            {
                return (string) base[2];
            }
        }

        internal bool IsEmptyList
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

        internal bool IsListRemoved
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

        public bool IsRestartNumbering
        {
            get
            {
                return (bool) base[3];
            }
            set
            {
                base[3] = value;
            }
        }

        internal string LFOStyleName
        {
            get
            {
                return (string) base[4];
            }
            set
            {
                base[4] = value;
            }
        }

        public int ListLevelNumber
        {
            get
            {
                return (int) base[0];
            }
            set
            {
                int num = 4;
                if ((value > 8) || (value < 0))
                {
                    throw new ArgumentException(BookmarkStart.b("昩䔫崭䐯ሱ堳匵丷弹倻ḽⴿ㝁㝃㉅桇⡉⥋湍㱏㝑❓╕硗扙籛㽝๟١䑣ťᩧཀྵ൫ᩭᕯq味ɵၷόቻ幽끿", num));
                }
                base[0] = value;
                int_20 = value;
            }
        }

        public Spire.Doc.Documents.ListType ListType
        {
            get
            {
                return (Spire.Doc.Documents.ListType) base[1];
            }
        }

        internal string NewLfoStyleName
        {
            get
            {
                return (string) base[7];
            }
            set
            {
                base[7] = value;
            }
        }

        internal int NewListLevelNumber
        {
            get
            {
                return (int) base[5];
            }
            set
            {
                base[5] = value;
            }
        }

        internal string NewStyleName
        {
            get
            {
                return (string) base[6];
            }
            set
            {
                base[6] = value;
            }
        }

        internal Paragraph OwnerParagraph
        {
            get
            {
                if (base.OwnerBase is Paragraph)
                {
                    return (base.OwnerBase as Paragraph);
                }
                return null;
            }
        }
    }
}

