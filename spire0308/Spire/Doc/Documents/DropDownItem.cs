namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;

    public class DropDownItem : DocumentSerializable
    {
        private bool bool_0;
        private bool bool_1;
        private int int_2;
        private int int_3;
        private long long_2;
        private string string_3;

        public DropDownItem(IDocument doc) : base((Document) doc, null)
        {
            this.string_3 = "";
        }

        internal DropDownItem method_5()
        {
            return (DropDownItem) this.CloneImpl();
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("伥尧伩䄫稭唯䨱䀳", 0)))
            {
                this.string_3 = reader.ReadString(BookmarkStart.b("伥尧伩䄫稭唯䨱䀳", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("尴䌶尸嘺椼娾㥀㝂", 15), this.string_3);
        }

        public string Text
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }
    }
}

