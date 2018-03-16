namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;

    public class ViewSetup : DocumentSerializable
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        public const int DEF_ZOOMING = 100;
        private Spire.Doc.DocumentViewType documentViewType_0;
        private int int_2;
        private int[] int_3;
        private string string_3;
        private Spire.Doc.ZoomType zoomType_0;

        public ViewSetup(IDocument doc) : base((Document) doc, null)
        {
            this.zoomType_0 = Spire.Doc.ZoomType.None;
            this.documentViewType_0 = Spire.Doc.DocumentViewType.PrintLayout;
            this.int_2 = 100;
        }

        internal ViewSetup method_5(Document A_0)
        {
            ViewSetup setup = (ViewSetup) this.CloneImpl();
            setup.method_0(A_0);
            return setup;
        }

        internal void method_6(int A_0)
        {
            if (A_0 == 0)
            {
                A_0 = 100;
            }
            else if (A_0 < 10)
            {
                A_0 = 10;
            }
            else if (A_0 > 500)
            {
                A_0 = 500;
            }
            if ((A_0 >= 10) && (A_0 <= 500))
            {
                this.int_2 = A_0;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 14;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("渳夵圷圹氻嬽㈿⅁⅃⡅㱇", 14)))
            {
                this.ZoomPercent = reader.ReadInt(BookmarkStart.b("渳夵圷圹氻嬽㈿⅁⅃⡅㱇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("渳夵圷圹栻䜽〿❁", num)))
            {
                this.ZoomType = (Spire.Doc.ZoomType) reader.ReadEnum(BookmarkStart.b("渳夵圷圹栻䜽〿❁", num), typeof(Spire.Doc.ZoomType));
            }
            if (reader.HasAttribute(BookmarkStart.b("戳張崷䴹栻䜽〿❁", num)))
            {
                this.DocumentViewType = (Spire.Doc.DocumentViewType) reader.ReadEnum(BookmarkStart.b("戳張崷䴹栻䜽〿❁", num), typeof(Spire.Doc.DocumentViewType));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 9;
            base.WriteXmlAttributes(writer);
            if (this.ZoomPercent != 100)
            {
                writer.WriteValue(BookmarkStart.b("甮帰尲場朶尸䤺帼娾⽀㝂", num), this.ZoomPercent);
            }
            if (this.ZoomType != Spire.Doc.ZoomType.None)
            {
                writer.WriteValue(BookmarkStart.b("甮帰尲場挶䀸䬺堼", num), this.ZoomType);
            }
            if (this.DocumentViewType != Spire.Doc.DocumentViewType.PrintLayout)
            {
                writer.WriteValue(BookmarkStart.b("礮堰嘲䈴挶䀸䬺堼", num), this.DocumentViewType);
            }
        }

        internal bool DisplayBackgroundShape
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

        public Spire.Doc.DocumentViewType DocumentViewType
        {
            get
            {
                return this.documentViewType_0;
            }
            set
            {
                this.documentViewType_0 = value;
            }
        }

        internal bool DoNotDisplayPageBoundaries
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

        internal bool FormsDesign
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        public int ZoomPercent
        {
            get
            {
                return this.int_2;
            }
            set
            {
                int num = 5;
                if (value == 0)
                {
                    value = 100;
                }
                if ((value < 10) || (value > 500))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("焪䈬䀮尰ጲ䔴制䬸堺堼儾㕀≂≄≆楈♊㡌㱎═獒㝔㉖祘㥚㡜⭞ᙠ٢d०䥨婪嵬佮ၰᵲᅴ坶䱸䭺䵼彾歷ꆎ", num));
                }
                this.int_2 = value;
            }
        }

        public Spire.Doc.ZoomType ZoomType
        {
            get
            {
                return this.zoomType_0;
            }
            set
            {
                this.zoomType_0 = value;
            }
        }
    }
}

