namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public class FieldMark : ParagraphBase
    {
        private bool bool_7;
        private FieldMarkType fieldMarkType_0;
        private string string_10;
        private string string_11;
        private string[] string_8;
        private string string_9;

        internal FieldMark(IDocument A_0) : base((Document) A_0)
        {
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(A_0);
        }

        protected internal FieldMark(FieldMark fieldMark, IDocument doc) : this(doc)
        {
            this.Type = fieldMark.Type;
            base.m_charFormat = (Spire.Doc.Formatting.CharacterFormat) fieldMark.CharacterFormat.method_23();
        }

        public FieldMark(IDocument doc, FieldMarkType type) : base((Document) doc)
        {
            this.fieldMarkType_0 = type;
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(doc);
        }

        internal FieldMark(IDocument A_0, Spire.Doc.Formatting.CharacterFormat A_1, FieldMarkType A_2) : this(A_0, A_2)
        {
            base.m_charFormat = A_1;
        }

        internal override bool Accept(Class420 visitor)
        {
            return (!this.method_30(visitor) || base.method_12(visitor.vmethod_19(this)));
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205();
            base.interface23_0.imethod_13(true);
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䨨䌪䰬崮倰倲䄴制䬸ᘺ嬼倾㍀⹂⑄㍆", 3), base.m_charFormat);
        }

        internal bool method_30(Class420 A_0)
        {
            if (base.IsDeleteRevision)
            {
                return A_0.vmethod_21();
            }
            return true;
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x10;
            if (reader.HasAttribute(BookmarkStart.b("瀵儷弹倻娽ി⍁㙃ⵅ᱇㍉㱋⭍", 0x10)))
            {
                this.fieldMarkType_0 = (FieldMarkType) reader.ReadEnum(BookmarkStart.b("瀵儷弹倻娽ി⍁㙃ⵅ᱇㍉㱋⭍", num), typeof(FieldMarkType));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("匦倨嬪䠬", 1), ParagraphItemType.FieldMark);
            writer.WriteValue(BookmarkStart.b("愦䀨个䄬䬮簰刲䜴尶洸䈺䴼娾", 1), this.fieldMarkType_0);
        }

        internal Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.FieldMark;
            }
        }

        public FieldMarkType Type
        {
            get
            {
                return this.fieldMarkType_0;
            }
            set
            {
                this.fieldMarkType_0 = value;
            }
        }
    }
}

