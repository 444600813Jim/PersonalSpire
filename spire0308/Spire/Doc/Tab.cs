namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;

    public class Tab : DocumentSerializable
    {
        private bool bool_0;
        private bool bool_1;
        private byte[] byte_1;
        private float float_0;
        private float float_1;
        private TabJustification tabJustification_0;
        private Spire.Doc.Documents.TabLeader tabLeader_0;
        private TabRelativeToPosition tabRelativeToPosition_0;

        internal Tab(IDocument A_0) : base((Document) A_0, null)
        {
        }

        internal Tab(IDocument A_0, float A_1, TabJustification A_2, Spire.Doc.Documents.TabLeader A_3) : this(A_0, A_1, 0f, A_2, A_3)
        {
        }

        internal Tab(IDocument A_0, float A_1, float A_2, TabJustification A_3, Spire.Doc.Documents.TabLeader A_4) : this(A_0)
        {
            this.float_0 = A_1;
            this.tabJustification_0 = A_3;
            this.tabLeader_0 = A_4;
            this.float_1 = A_2;
        }

        internal Tab method_5()
        {
            return (Tab) this.CloneImpl();
        }

        private void method_6()
        {
            if (base.OwnerBase != null)
            {
                (base.OwnerBase as TabCollection).method_9();
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 2;
            if (reader.HasAttribute(BookmarkStart.b("砧䔩弫䜭䐯嬱嬳堵", 2)))
            {
                this.float_0 = reader.ReadFloat(BookmarkStart.b("砧䔩弫䜭䐯嬱嬳堵", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("戧弩弫娭夯吱崳唵夷丹唻儽⸿", num)))
            {
                this.tabJustification_0 = (TabJustification) reader.ReadEnum(BookmarkStart.b("戧弩弫娭夯吱崳唵夷丹唻儽⸿", num), typeof(TabJustification));
            }
            if (reader.HasAttribute(BookmarkStart.b("搧伩䴫䨭唯䀱", num)))
            {
                this.tabLeader_0 = (Spire.Doc.Documents.TabLeader) reader.ReadEnum(BookmarkStart.b("搧伩䴫䨭唯䀱", num), typeof(Spire.Doc.Documents.TabLeader));
            }
            if (reader.HasAttribute(BookmarkStart.b("氧伩䀫䬭䐯圱", num)))
            {
                this.float_1 = reader.ReadFloat(BookmarkStart.b("氧伩䀫䬭䐯圱", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            writer.WriteValue(BookmarkStart.b("簫䄭䌯嬱䀳張圷吹", 6), this.Position);
            writer.WriteValue(BookmarkStart.b("昫嬭䌯䘱崳倵儷夹崻䨽⤿ⵁ⩃", 6), this.Justification);
            writer.WriteValue(BookmarkStart.b("怫䬭儯嘱儳䐵", 6), this.TabLeader);
            writer.WriteValue(BookmarkStart.b("栫䬭尯圱䀳匵", 6), this.DeletePosition);
        }

        public float DeletePosition
        {
            get
            {
                return this.float_1;
            }
            set
            {
                this.float_1 = value;
                this.method_6();
            }
        }

        internal bool IsClear
        {
            get
            {
                return (this.tabJustification_0 == TabJustification.Clear);
            }
        }

        internal bool IsPTab
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

        public TabJustification Justification
        {
            get
            {
                return this.tabJustification_0;
            }
            set
            {
                if (value != this.tabJustification_0)
                {
                    this.tabJustification_0 = value;
                }
                this.method_6();
            }
        }

        public float Position
        {
            get
            {
                return this.float_0;
            }
            set
            {
                if (value != this.float_0)
                {
                    this.float_0 = value;
                }
                this.method_6();
            }
        }

        public Spire.Doc.Documents.TabLeader TabLeader
        {
            get
            {
                return this.tabLeader_0;
            }
            set
            {
                if (value != this.tabLeader_0)
                {
                    this.tabLeader_0 = value;
                }
                this.method_6();
            }
        }

        internal TabRelativeToPosition TabRelativePosition
        {
            get
            {
                return this.tabRelativeToPosition_0;
            }
            set
            {
                this.tabRelativeToPosition_0 = value;
            }
        }

        internal bool Undocumented40
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
    }
}

