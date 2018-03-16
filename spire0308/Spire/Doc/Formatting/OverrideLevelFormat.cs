namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;

    public class OverrideLevelFormat : DocumentSerializable
    {
        private bool bool_0;
        private bool bool_1;
        private byte[] byte_1;
        private int int_2;
        private int int_3;
        internal int int_4;
        internal int int_5;
        internal int int_6;
        internal int int_7;
        internal int int_8;
        private ListLevel listLevel_0;

        internal OverrideLevelFormat(Document A_0) : base(A_0, null)
        {
            this.listLevel_0 = new ListLevel(base.Document);
            this.listLevel_0.method_0(this);
        }

        protected override object CloneImpl()
        {
            OverrideLevelFormat format = (OverrideLevelFormat) base.CloneImpl();
            format.OverrideListLevel = this.OverrideListLevel.Clone();
            return format;
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䈭唯䐱儳娵ᔷ唹䨻嬽㈿ぁⵃ≅ⵇ", 8), this.listLevel_0);
        }

        internal void method_5()
        {
            if (this.listLevel_0 != null)
            {
                this.listLevel_0.method_16();
                this.listLevel_0 = null;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("笷刹崻倽✿❁Ƀ⥅㩇❉ⵋ㩍", 0x12)))
            {
                this.bool_1 = reader.ReadBoolean(BookmarkStart.b("笷刹崻倽✿❁Ƀ⥅㩇❉ⵋ㩍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷刹崻倽✿❁ᝃ㉅⥇㡉㡋ཌྷ⑏", num)))
            {
                this.bool_0 = reader.ReadBoolean(BookmarkStart.b("笷刹崻倽✿❁ᝃ㉅⥇㡉㡋ཌྷ⑏", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("欷丹崻䰽㐿́ぃ", num)))
            {
                this.int_2 = reader.ReadInt(BookmarkStart.b("欷丹崻䰽㐿́ぃ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("樷弹伻嬽㈿㑁⅃≅祇", num)))
            {
                this.int_4 = reader.ReadInt(BookmarkStart.b("樷弹伻嬽㈿㑁⅃≅祇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("樷弹伻嬽㈿㑁⅃≅穇", num)))
            {
                this.int_5 = reader.ReadInt(BookmarkStart.b("樷弹伻嬽㈿㑁⅃≅穇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("樷弹伻嬽㈿㑁⅃≅筇", num)))
            {
                this.int_6 = reader.ReadInt(BookmarkStart.b("樷弹伻嬽㈿㑁⅃≅筇", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 2;
            base.WriteXmlAttributes(writer);
            if (this.bool_0)
            {
                writer.WriteValue(BookmarkStart.b("欧䈩䴫䀭圯圱朳䈵夷䠹䠻缽㐿", num), this.bool_0);
                writer.WriteValue(BookmarkStart.b("笧帩䴫尭䐯猱䀳", num), this.int_2);
            }
            if (this.bool_1)
            {
                writer.WriteValue(BookmarkStart.b("欧䈩䴫䀭圯圱爳夵䨷圹崻䨽", num), this.bool_1);
            }
            if (this.int_4 != 0)
            {
                writer.WriteValue(BookmarkStart.b("稧伩弫䬭䈯䐱儳刵ष", num), this.int_4);
            }
            if (this.int_5 != 0)
            {
                writer.WriteValue(BookmarkStart.b("稧伩弫䬭䈯䐱儳刵਷", num), this.int_5);
            }
            if (this.int_6 != 0)
            {
                writer.WriteValue(BookmarkStart.b("稧伩弫䬭䈯䐱儳刵ଷ", num), this.int_6);
            }
        }

        internal bool OverrideFormatting
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

        internal ListLevel OverrideListLevel
        {
            get
            {
                return this.listLevel_0;
            }
            set
            {
                this.listLevel_0 = value;
            }
        }

        internal bool OverrideStartAtValue
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

        internal int StartAt
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
    }
}

