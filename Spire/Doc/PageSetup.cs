namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;

    public class PageSetup : DocumentSerializable
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        internal bool bool_3;
        private bool bool_4;
        private Spire.Doc.Documents.Borders borders_0;
        private byte byte_1;
        private byte[] byte_2;
        internal const float float_0 = 595.35f;
        internal const float float_1 = 841.95f;
        internal const float float_10 = 36f;
        internal const float float_2 = 20f;
        internal const float float_3 = 50f;
        internal const float float_4 = 90f;
        internal const float float_5 = 90f;
        internal const float float_6 = 50f;
        internal const float float_7 = 42.55f;
        private float float_8;
        internal const float float_9 = 49.6f;
        private int int_2;
        protected float m_fFooterDistance;
        protected float m_fHeaderDistance;
        private string[] string_3;

        internal PageSetup(Section A_0) : base(A_0.Document, A_0)
        {
            this.borders_0 = new Spire.Doc.Documents.Borders();
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䰭弯䀱倳匵䨷䤹", 8), this.Borders);
        }

        public void InsertPageNumbers(bool fromTopPage, PageNumberAlignment horizontalAlignment)
        {
            HeaderFooter footer = fromTopPage ? (base.OwnerBase as Section).HeadersFooters.Header : (base.OwnerBase as Section).HeadersFooters.Footer;
            IParagraph paragraph = null;
            IField field2 = null;
            int num = 0;
            int count = footer.Paragraphs.Count;
            while (num < count)
            {
                Field field;
                paragraph = footer.Paragraphs[num];
                int num2 = 0;
                int num3 = paragraph.Items.Count;
                while (num2 < num3)
                {
                    if (paragraph.Items[num2].DocumentObjectType == DocumentObjectType.Field)
                    {
                        field = (Field) paragraph.Items[num2];
                        if (field.Type == FieldType.FieldPage)
                        {
                            goto Label_00A4;
                        }
                    }
                    num2++;
                }
                goto Label_00A8;
            Label_00A4:
                field2 = field;
            Label_00A8:
                num++;
            }
            if (field2 == null)
            {
                paragraph = footer.AddParagraph();
                field2 = paragraph.AppendField("", FieldType.FieldPage);
            }
            paragraph.Format.WrapFrameAround = true;
            paragraph.Format.FrameX = (short) horizontalAlignment;
        }

        internal SizeF method_5()
        {
            return new SizeF(this.PageSize);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("礷伹䠻儽ᐿ⍁♃ᅅⅇ⹉㡋♍", 0x12)))
            {
                this.DefaultTabWidth = reader.ReadFloat(BookmarkStart.b("礷伹䠻儽ᐿ⍁♃ᅅⅇ⹉㡋♍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽࠿❁ⵃⅅ⁇㹉", num)))
            {
                this.PageSize = new SizeF(this.PageSize.Width, reader.ReadFloat(BookmarkStart.b("样嬹嬻嬽࠿❁ⵃⅅ⁇㹉", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽᜿⭁⁃㉅⁇", num)))
            {
                this.PageSize = new SizeF(reader.ReadFloat(BookmarkStart.b("样嬹嬻嬽᜿⭁⁃㉅⁇", num)), this.PageSize.Height);
            }
            if (reader.HasAttribute(BookmarkStart.b("礷嘹唻夽⸿⽁⅃⡅㱇", num)))
            {
                this.VerticalAlignment = (PageAlignment) reader.ReadEnum(BookmarkStart.b("礷嘹唻夽⸿⽁⅃⡅㱇", num), typeof(PageAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("縷唹医䨽┿ぁC⽅㭇㹉ⵋ⁍㍏㝑", num)))
            {
                this.FooterDistance = reader.ReadFloat(BookmarkStart.b("縷唹医䨽┿ぁC⽅㭇㹉ⵋ⁍㍏㝑", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀷弹崻娽┿ぁC⽅㭇㹉ⵋ⁍㍏㝑", num)))
            {
                this.HeaderDistance = reader.ReadFloat(BookmarkStart.b("瀷弹崻娽┿ぁC⽅㭇㹉ⵋ⁍㍏㝑", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("眷䠹唻嬽⸿㙁╃㉅ⅇ╉≋", num)))
            {
                this.Orientation = (PageOrientation) reader.ReadEnum(BookmarkStart.b("眷䠹唻嬽⸿㙁╃㉅ⅇ╉≋", num), typeof(PageOrientation));
            }
            if (reader.HasAttribute(BookmarkStart.b("稷唹䠻䨽⼿⽁ृ❅㩇ⵉ╋⁍", num)))
            {
                this.Margins.Bottom = reader.ReadFloat(BookmarkStart.b("稷唹䠻䨽⼿⽁ृ❅㩇ⵉ╋⁍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷唹䰻猽ℿぁ⍃⽅♇", num)))
            {
                this.Margins.Top = reader.ReadFloat(BookmarkStart.b("氷唹䰻猽ℿぁ⍃⽅♇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琷弹娻䨽ി⍁㙃ⅅⅇ⑉", num)))
            {
                this.Margins.Left = reader.ReadFloat(BookmarkStart.b("琷弹娻䨽ി⍁㙃ⅅⅇ⑉", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("樷匹嬻嘽㐿ཁ╃㑅⽇⍉≋", num)))
            {
                this.Margins.Right = reader.ReadFloat(BookmarkStart.b("樷匹嬻嘽㐿ཁ╃㑅⽇⍉≋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("簷匹娻堽┿ぁ⅃⡅㱇౉╋㱍⍏♑ѓ㝕㽗㽙", num)))
            {
                this.DifferentFirstPageHeaderFooter = reader.ReadBoolean(BookmarkStart.b("簷匹娻堽┿ぁ⅃⡅㱇౉╋㱍⍏♑ѓ㝕㽗㽙", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("簷匹娻堽┿ぁ⅃⡅㱇Չ⡋⩍ᕏ⑑ㅓ㡕ࡗ㭙㭛㭝", num)))
            {
                this.DifferentOddAndEvenPagesHeaderFooter = reader.ReadBoolean(BookmarkStart.b("簷匹娻堽┿ぁ⅃⡅㱇Չ⡋⩍ᕏ⑑ㅓ㡕ࡗ㭙㭛㭝", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕ୗ⹙㥛⹝", num)))
            {
                this.LineNumberingStep = reader.ReadInt(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕ୗ⹙㥛⹝", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕᱗㍙⽛⩝şౡݣͥ", num)))
            {
                this.LineNumberingDistanceFromText = reader.ReadFloat(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕᱗㍙⽛⩝şౡݣͥ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕ᕗ㕙㡛㭝", num)))
            {
                this.LineNumberingRestartMode = (Spire.Doc.LineNumberingRestartMode) reader.ReadEnum(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕ᕗ㕙㡛㭝", num), typeof(Spire.Doc.LineNumberingRestartMode));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕ୗ⹙㵛ⱝᑟ㑡գ੥ᵧཀྵ", num)))
            {
                this.LineNumberingStartValue = reader.ReadInt(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ى╋⁍㕏᱑⅓㭕ୗ⹙㵛ⱝᑟ㑡գ੥ᵧཀྵ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ࡉ⍋㱍㑏㝑♓᝕⡗⩙せ❝", num)))
            {
                this.PageBordersApplyType = (Spire.Doc.PageBordersApplyType) reader.ReadEnum(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ࡉ⍋㱍㑏㝑♓᝕⡗⩙せ❝", num), typeof(Spire.Doc.PageBordersApplyType));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ࡉ⍋㱍㑏㝑♓ὕ⭗ፙ㉛ᡝ቟ൡ੣ብ", num)))
            {
                this.IsFrontPageBorder = reader.ReadBoolean(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ࡉ⍋㱍㑏㝑♓ὕ⭗ፙ㉛ᡝ቟ൡ੣ብ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ࡉ⍋㱍㑏㝑♓ᥕ㹗㱙⽛㭝ᑟ②ᙣ॥է", num)))
            {
                this.PageBorderOffsetFrom = (Spire.Doc.PageBorderOffsetFrom) reader.ReadEnum(BookmarkStart.b("样嬹嬻嬽ጿ❁ぃ㍅㡇ࡉ⍋㱍㑏㝑♓ᥕ㹗㱙⽛㭝ᑟ②ᙣ॥է", num), typeof(Spire.Doc.PageBorderOffsetFrom));
            }
            if (reader.HasAttribute(BookmarkStart.b("紷䬹䤻弽ⰿŁ⭃⩅὇⍉⡋㩍㡏", num)))
            {
                this.bool_1 = reader.ReadBoolean(BookmarkStart.b("紷䬹䤻弽ⰿŁ⭃⩅὇⍉⡋㩍㡏", num));
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 2;
            base.WriteXmlAttributes(writer);
            if (this.DefaultTabWidth != 36f)
            {
                writer.WriteValue(BookmarkStart.b("椧弩堫䄭搯匱嘳愵儷帹䠻嘽", num), this.DefaultTabWidth);
            }
            if (this.PageSize.Height != 0f)
            {
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭砯圱崳儵倷丹", num), this.PageSize.Height);
            }
            if (this.PageSize.Width != 0f)
            {
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭术嬱倳䈵倷", num), this.PageSize.Width);
            }
            if (this.VerticalAlignment != PageAlignment.Top)
            {
                writer.WriteValue(BookmarkStart.b("椧䘩䔫䤭帯弱儳堵䰷", num), this.VerticalAlignment);
            }
            if (this.FooterDistance >= 0f)
            {
                writer.WriteValue(BookmarkStart.b("渧䔩䌫娭唯䀱瀳張䬷丹崻倽⌿❁", num), this.FooterDistance);
            }
            if (this.HeaderDistance >= 0f)
            {
                writer.WriteValue(BookmarkStart.b("性伩䴫䨭唯䀱瀳張䬷丹崻倽⌿❁", num), this.HeaderDistance);
            }
            if (this.Orientation != ((PageOrientation) 0))
            {
                writer.WriteValue(BookmarkStart.b("朧堩䔫䬭帯䘱唳䈵儷唹刻", num), this.Orientation);
            }
            if (this.Margins.Bottom >= 0f)
            {
                writer.WriteValue(BookmarkStart.b("樧䔩堫娭弯弱礳圵䨷崹唻倽", num), this.Margins.Bottom);
            }
            if (this.Margins.Top >= 0f)
            {
                writer.WriteValue(BookmarkStart.b("簧䔩尫挭儯䀱匳張嘷", num), this.Margins.Top);
            }
            if (this.Margins.Left >= 0f)
            {
                writer.WriteValue(BookmarkStart.b("搧伩䨫娭累匱䘳儵儷吹", num), this.Margins.Left);
            }
            if (this.Margins.Right >= 0f)
            {
                writer.WriteValue(BookmarkStart.b("稧䌩䬫䘭䐯缱唳䐵強匹刻", num), this.Margins.Right);
            }
            if (this.DifferentFirstPageHeaderFooter)
            {
                writer.WriteValue(BookmarkStart.b("氧䌩䨫䠭唯䀱儳堵䰷簹唻䰽㌿㙁ᑃ❅⽇⽉", num), this.DifferentFirstPageHeaderFooter);
            }
            if (this.DifferentOddAndEvenPagesHeaderFooter)
            {
                writer.WriteValue(BookmarkStart.b("氧䌩䨫䠭唯䀱儳堵䰷甹堻娽Կ㑁⅃⡅ᡇ⭉⭋⭍", num), this.DifferentOddAndEvenPagesHeaderFooter);
            }
            if (this.LineNumberingRestartMode != Spire.Doc.LineNumberingRestartMode.None)
            {
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷瘹唻倽┿ుㅃ⭅Շ╉⡋⭍", num), this.LineNumberingRestartMode);
                if (this.LineNumberingStep != 0)
                {
                    writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷瘹唻倽┿ుㅃ⭅ᭇ㹉⥋㹍", num), this.LineNumberingStep);
                }
                if (this.LineNumberingDistanceFromText != 0f)
                {
                    writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷瘹唻倽┿ుㅃ⭅ే⍉㽋㩍ㅏ㱑㝓㍕", num), this.LineNumberingDistanceFromText);
                }
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷瘹唻倽┿ుㅃ⭅ᭇ㹉ⵋ㱍⑏ё㕓㩕ⵗ㽙", num), this.LineNumberingStartValue);
            }
            if (this.PageBordersApplyType != Spire.Doc.PageBordersApplyType.AllPages)
            {
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷砹医䰽␿❁㙃݅㡇㩉⁋㝍", num), this.PageBordersApplyType);
            }
            if (!this.IsFrontPageBorder)
            {
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷砹医䰽␿❁㙃ཅ㭇͉≋ࡍ≏㵑㩓≕", num), this.IsFrontPageBorder);
            }
            if (this.PageBorderOffsetFrom != Spire.Doc.PageBorderOffsetFrom.Text)
            {
                writer.WriteValue(BookmarkStart.b("砧䬩䬫䬭振圱䀳䌵䠷砹医䰽␿❁㙃ॅ⹇ⱉ㽋⭍⑏ᑑ♓㥕㕗", num), this.PageBorderOffsetFrom);
            }
            if (this.bool_1)
            {
                writer.WriteValue(BookmarkStart.b("洧嬩夫伭尯焱嬳娵漷匹堻䨽⠿", num), this.bool_1);
            }
        }

        internal bool AlignBordersAndEdges
        {
            get
            {
                return base.Document.Settings.bool_12;
            }
            set
            {
                base.Document.Settings.bool_12 = value;
            }
        }

        public bool Bidi
        {
            get
            {
                return this.OwnerSection.SectPr.method_136();
            }
            set
            {
                this.OwnerSection.SectPr.method_137(value);
            }
        }

        public Spire.Doc.Documents.Borders Borders
        {
            get
            {
                return this.OwnerSection.SectPr.method_49();
            }
        }

        public CharacterSpacing CharacterSpacingControl
        {
            get
            {
                return base.Document.Settings.characterSpacing_0;
            }
            set
            {
                base.Document.Settings.characterSpacing_0 = value;
            }
        }

        internal int CharsLine
        {
            get
            {
                return this.OwnerSection.SectPr.method_130();
            }
            set
            {
                this.OwnerSection.SectPr.method_131(value);
            }
        }

        public float ClientHeight
        {
            get
            {
                return ((this.PageSize.Height - this.Margins.Top) - this.Margins.Bottom);
            }
        }

        public float ClientWidth
        {
            get
            {
                return ((this.PageSize.Width - this.Margins.Left) - this.Margins.Right);
            }
        }

        public bool ColumnsLineBetween
        {
            get
            {
                return this.OwnerSection.SectPr.method_62();
            }
            set
            {
                this.OwnerSection.SectPr.method_63(value);
            }
        }

        internal int ColumnsSpacing
        {
            get
            {
                return this.OwnerSection.SectPr.method_120();
            }
            set
            {
                this.OwnerSection.SectPr.method_121(value);
            }
        }

        public float DefaultTabWidth
        {
            get
            {
                return (base.Document.Settings.float_0 / 20f);
            }
            set
            {
                base.Document.Settings.float_0 = (int) Math.Round((double) (value * 20f), 0);
            }
        }

        public bool DifferentFirstPageHeaderFooter
        {
            get
            {
                return this.OwnerSection.SectPr.method_58();
            }
            set
            {
                this.OwnerSection.SectPr.method_59(value);
            }
        }

        public bool DifferentOddAndEvenPagesHeaderFooter
        {
            get
            {
                return this.OwnerSection.Document.Settings.bool_37;
            }
            set
            {
                this.OwnerSection.Document.Settings.bool_37 = value;
            }
        }

        public bool EqualColumnWidth
        {
            get
            {
                return this.OwnerSection.SectPr.method_118();
            }
            set
            {
                this.OwnerSection.SectPr.method_119(value);
            }
        }

        public float FooterDistance
        {
            get
            {
                return this.OwnerSection.SectPr.method_112();
            }
            set
            {
                this.OwnerSection.SectPr.method_113(value);
            }
        }

        internal bool GutterAtTop
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

        internal bool HasLineNumbering
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

        public float HeaderDistance
        {
            get
            {
                return this.OwnerSection.SectPr.method_110();
            }
            set
            {
                this.OwnerSection.SectPr.method_111(value);
            }
        }

        public bool IsFrontPageBorder
        {
            get
            {
                return this.OwnerSection.SectPr.method_92();
            }
            set
            {
                this.OwnerSection.SectPr.method_93(value);
            }
        }

        public float LineNumberingDistanceFromText
        {
            get
            {
                return this.OwnerSection.SectPr.method_126();
            }
            set
            {
                this.OwnerSection.SectPr.method_127(value);
            }
        }

        public Spire.Doc.LineNumberingRestartMode LineNumberingRestartMode
        {
            get
            {
                return this.OwnerSection.SectPr.method_70();
            }
            set
            {
                this.OwnerSection.SectPr.method_71(value);
            }
        }

        public int LineNumberingStartValue
        {
            get
            {
                return this.OwnerSection.SectPr.method_82();
            }
            set
            {
                this.OwnerSection.SectPr.method_83(value);
            }
        }

        public int LineNumberingStep
        {
            get
            {
                return this.OwnerSection.SectPr.method_72();
            }
            set
            {
                this.OwnerSection.SectPr.method_73(value);
            }
        }

        internal float LinePitch
        {
            get
            {
                return this.OwnerSection.SectPr.method_78();
            }
            set
            {
                this.OwnerSection.SectPr.method_79(value);
            }
        }

        public MarginsF Margins
        {
            get
            {
                return this.OwnerSection.SectPr.method_50();
            }
            set
            {
                this.OwnerSection.SectPr.method_51(value);
            }
        }

        public PageOrientation Orientation
        {
            get
            {
                return this.OwnerSection.SectPr.method_88();
            }
            set
            {
                if (this.OwnerSection.SectPr.method_88() != value)
                {
                    this.OwnerSection.SectPr.method_89(value);
                    switch (value)
                    {
                        case PageOrientation.Portrait:
                            if (this.PageSize.Width <= this.PageSize.Height)
                            {
                                break;
                            }
                            this.PageSize = new SizeF(this.PageSize.Height, this.PageSize.Width);
                            return;

                        case PageOrientation.Landscape:
                            if (this.PageSize.Height > this.PageSize.Width)
                            {
                                this.PageSize = new SizeF(this.PageSize.Height, this.PageSize.Width);
                            }
                            break;

                        default:
                            return;
                    }
                }
            }
        }

        internal Section OwnerSection
        {
            get
            {
                return (base.OwnerBase as Section);
            }
        }

        public bool PageBorderIncludeFooter
        {
            get
            {
                return !base.Document.Settings.bool_14;
            }
            set
            {
                base.Document.Settings.bool_14 = !value;
            }
        }

        public bool PageBorderIncludeHeader
        {
            get
            {
                return !base.Document.Settings.bool_13;
            }
            set
            {
                base.Document.Settings.bool_13 = !value;
            }
        }

        public Spire.Doc.PageBorderOffsetFrom PageBorderOffsetFrom
        {
            get
            {
                return this.OwnerSection.SectPr.method_94();
            }
            set
            {
                this.OwnerSection.SectPr.method_95(value);
            }
        }

        public Spire.Doc.PageBordersApplyType PageBordersApplyType
        {
            get
            {
                return this.OwnerSection.SectPr.method_90();
            }
            set
            {
                this.OwnerSection.SectPr.method_91(value);
            }
        }

        public Spire.Doc.Documents.PageNumberStyle PageNumberStyle
        {
            get
            {
                return this.OwnerSection.SectPr.method_52();
            }
            set
            {
                this.OwnerSection.SectPr.method_53(value);
            }
        }

        public SizeF PageSize
        {
            get
            {
                float width = this.OwnerSection.SectPr.method_96();
                return new SizeF(width, this.OwnerSection.SectPr.method_98());
            }
            set
            {
                this.OwnerSection.SectPr.method_97(value.Width);
                this.OwnerSection.SectPr.method_99(value.Height);
            }
        }

        public int PageStartingNumber
        {
            get
            {
                return this.OwnerSection.SectPr.method_86();
            }
            set
            {
                this.OwnerSection.SectPr.method_87(value);
            }
        }

        internal GridPitchType PitchType
        {
            get
            {
                return this.OwnerSection.SectPr.method_132();
            }
            set
            {
                this.OwnerSection.SectPr.method_133(value);
            }
        }

        public bool RestartPageNumbering
        {
            get
            {
                return this.OwnerSection.SectPr.method_60();
            }
            set
            {
                this.OwnerSection.SectPr.method_61(value);
            }
        }

        public PageAlignment VerticalAlignment
        {
            get
            {
                return this.OwnerSection.SectPr.method_114();
            }
            set
            {
                this.OwnerSection.SectPr.method_115(value);
            }
        }
    }
}

