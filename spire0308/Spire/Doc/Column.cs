namespace Spire.Doc
{
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;

    public class Column : DocumentSerializable
    {
        private bool bool_0;
        private byte byte_1;
        private byte byte_2;
        private float float_0;
        private float float_1;
        private float float_2;
        private long[] long_2;
        private string string_3;

        public Column(IDocument doc) : base((Document) doc, null)
        {
        }

        internal Column method_5()
        {
            return (Column) base.CloneImpl();
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            base.ReadXmlAttributes(reader);
            this.Width = reader.ReadFloat(BookmarkStart.b("漷匹堻䨽⠿", 0x12));
            this.Space = reader.ReadFloat(BookmarkStart.b("欷䨹崻崽⤿ⱁ⍃", 0x12));
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("术嬱倳䈵倷", 10), this.Width);
            writer.WriteValue(BookmarkStart.b("振䈱唳唵儷吹嬻", 10), this.Space);
        }

        public float Space
        {
            get
            {
                return this.float_2;
            }
            set
            {
                this.float_2 = value;
            }
        }

        public float Width
        {
            get
            {
                return this.float_1;
            }
            set
            {
                this.float_1 = value;
            }
        }
    }
}

