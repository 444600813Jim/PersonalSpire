namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Runtime.CompilerServices;

    public class ListStyle : Style
    {
        private bool bool_11;
        private bool bool_12;
        private bool bool_13;
        private float float_0;
        private int int_10;
        private int int_11;
        private int int_12;
        private const int int_9 = 0x48;
        private ListLevelCollection listLevelCollection_0;
        private Spire.Doc.Documents.ListLevelsType listLevelsType_0;
        private Spire.Doc.Documents.ListType listType_0;
        private long long_2;
        [CompilerGenerated]
        private string string_10;
        internal const string string_5 = "";
        internal const string string_6 = "o";
        internal const string string_7 = "";
        private string string_8;
        private string string_9;

        internal ListStyle(Document A_0) : base(A_0)
        {
            this.listLevelsType_0 = Spire.Doc.Documents.ListLevelsType.MultiLevel;
            this.int_12 = 12;
            this.listLevelCollection_0 = new ListLevelCollection(this);
            this.listLevelCollection_0.method_0(this);
            base.m_ParaPr = new ParagraphFormat(A_0);
            base.m_ParaPr.method_0(this);
        }

        public ListStyle(IDocument doc, Spire.Doc.Documents.ListType listType) : this((Document) doc)
        {
            this.listType_0 = listType;
            this.method_26(listType);
        }

        internal ListStyle(Document A_0, Spire.Doc.Documents.ListType A_1, bool A_2) : this(A_0)
        {
            this.listType_0 = A_1;
            this.method_28(A_1, A_2);
        }

        internal ListStyle(Document A_0, int A_1, Spire.Doc.Documents.ListLevelsType A_2, int A_3) : this(A_0)
        {
            this.int_10 = A_1;
            this.listLevelsType_0 = A_2;
            this.int_11 = A_3;
        }

        public override IStyle Clone()
        {
            return (ListStyle) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            ListStyle style = (ListStyle) base.CloneImpl();
            style.listLevelCollection_0 = new ListLevelCollection(style);
            this.listLevelCollection_0.CloneToImpl(style.listLevelCollection_0);
            return style;
        }

        internal override void Close()
        {
            base.Close();
            if ((this.listLevelCollection_0 != null) && (this.listLevelCollection_0.Count != 0))
            {
                int count = this.listLevelCollection_0.Count;
                ListLevel level = null;
                for (int i = 0; i < count; i++)
                {
                    level = this.listLevelCollection_0[i];
                    level.method_16();
                    level = null;
                }
            }
            else
            {
                this.listLevelCollection_0 = null;
            }
        }

        public static ListStyle CreateEmptyListStyle(IDocument doc, Spire.Doc.Documents.ListType listType, bool isOneLevelList)
        {
            return new ListStyle((Document) doc, listType, isOneLevelList);
        }

        public ListLevel GetNearLevel(int levelNumber)
        {
            int num = 0x12;
            if (levelNumber < 0)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("嘷伹儻尽┿ぁ", num), BookmarkStart.b("渷嬹倻䬽┿扁❃❅♇橉≋⅍⑏牑㙓㍕硗㙙㥛ⵝ፟䉡ၣ๥१ѩ䱫幭", num));
            }
            if (levelNumber > (this.Levels.Count - 1))
            {
                levelNumber = this.Levels.Count - 1;
            }
            return this.Levels[levelNumber];
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䈭唯䐱儳娵䬷", 8), this.Levels);
        }

        internal void method_23(int A_0)
        {
            this.int_10 = A_0;
        }

        internal void method_24(Spire.Doc.Documents.ListLevelsType A_0)
        {
            this.listLevelsType_0 = A_0;
        }

        internal void method_25(int A_0)
        {
            this.int_11 = A_0;
        }

        internal void method_26(Spire.Doc.Documents.ListType A_0)
        {
            int num = 3;
            this.Levels.method_7();
            base.Document.CreateListLevelImpl(this);
            if (A_0 == Spire.Doc.Documents.ListType.Bulleted)
            {
                for (float i = 0.5f; i < 4.5f; i += 1.5f)
                {
                    this.Levels.method_5(ListLevel.smethod_3((float) ((int) (72f * i)), BookmarkStart.b("默", num), this));
                    this.Levels.method_5(ListLevel.smethod_3((float) ((int) (72.0 * (i + 0.5))), BookmarkStart.b("䘨", num), this));
                    this.Levels.method_5(ListLevel.smethod_3((float) ((int) (72f * (i + 1f))), BookmarkStart.b("軘", num), this));
                }
            }
            else
            {
                int num3 = 0;
                for (float j = 0.5f; j < 4.5f; j += 1.5f)
                {
                    this.Levels.method_5(ListLevel.smethod_4((int) (72f * j), num3++, ListPatternType.Arabic, ListNumberAlignment.Left, this));
                    this.Levels.method_5(ListLevel.smethod_4((int) (72.0 * (j + 0.5)), num3++, ListPatternType.LowLetter, ListNumberAlignment.Right, this));
                    this.Levels.method_5(ListLevel.smethod_4((int) (72f * (j + 1f)), num3++, ListPatternType.LowRoman, ListNumberAlignment.Left, this));
                }
            }
        }

        internal ListLevelCollection method_27(string A_0)
        {
            if (base.m_doc.ListStyles.Count > 0)
            {
                for (int i = 0; i < base.m_doc.ListStyles.Count; i++)
                {
                    if (base.m_doc.ListStyles[i].StyleLink == A_0)
                    {
                        return base.m_doc.ListStyles[i].Levels;
                    }
                }
            }
            return null;
        }

        internal void method_28(Spire.Doc.Documents.ListType A_0, bool A_1)
        {
            int num2 = A_1 ? 1 : 9;
            for (int i = 0; i < num2; i++)
            {
                this.Levels.method_5(base.Document.CreateListLevelImpl(this));
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 12;
            if (reader == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䀱儳圵尷弹主", num));
            }
            base.Name = reader.ReadString(BookmarkStart.b("簱唳嬵崷", num));
            this.ListType = (Spire.Doc.Documents.ListType) reader.ReadEnum(BookmarkStart.b("縱崳䔵䰷渹䔻丽┿", num), typeof(Spire.Doc.Documents.ListType));
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("稳圵唷弹", 14), base.Name);
            writer.WriteValue(BookmarkStart.b("砳張䬷丹栻䜽〿❁", 14), this.ListType);
        }

        internal string BaseListStyleName
        {
            get
            {
                return this.string_8;
            }
            set
            {
                this.string_8 = value;
            }
        }

        internal bool IsBuiltInStyle
        {
            get
            {
                return this.bool_13;
            }
            set
            {
                this.bool_13 = value;
            }
        }

        internal bool IsHybrid
        {
            get
            {
                if (!this.bool_11)
                {
                    return (this.ListLevelsType == Spire.Doc.Documents.ListLevelsType.HybridMultiLevel);
                }
                return true;
            }
            set
            {
                this.bool_11 = value;
            }
        }

        internal bool IsSimple
        {
            get
            {
                if (!this.bool_12)
                {
                    return (this.ListLevelsType == Spire.Doc.Documents.ListLevelsType.SingleLevel);
                }
                return true;
            }
            set
            {
                this.bool_12 = value;
            }
        }

        public ListLevelCollection Levels
        {
            get
            {
                if (((this.listLevelCollection_0 == null) || ((this.listLevelCollection_0 != null) && (this.listLevelCollection_0.Count == 0))) && ((this.BaseListStyleName != null) && (this.BaseListStyleName.Length > 0)))
                {
                    this.listLevelCollection_0 = this.method_27(this.BaseListStyleName);
                }
                return this.listLevelCollection_0;
            }
        }

        internal int ListDefId
        {
            get
            {
                return this.int_10;
            }
        }

        internal Spire.Doc.Documents.ListLevelsType ListLevelsType
        {
            get
            {
                return this.listLevelsType_0;
            }
        }

        internal string ListStyleId
        {
            [CompilerGenerated]
            get
            {
                return this.string_10;
            }
            [CompilerGenerated]
            set
            {
                this.string_10 = value;
            }
        }

        internal int ListStyleIstd
        {
            get
            {
                return this.int_12;
            }
            set
            {
                this.int_12 = value;
                if (this.int_12 == 0xfff)
                {
                    this.int_12 = 12;
                }
            }
        }

        public Spire.Doc.Documents.ListType ListType
        {
            get
            {
                return this.listType_0;
            }
            set
            {
                this.listType_0 = value;
            }
        }

        internal string StyleLink
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

        public override Spire.Doc.Documents.StyleType StyleType
        {
            get
            {
                return Spire.Doc.Documents.StyleType.ListStyle;
            }
        }

        internal int TemplateCode
        {
            get
            {
                return this.int_11;
            }
        }
    }
}

