namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;

    public class SequenceField : Field
    {
        private bool bool_35;
        private CaptionNumberingFormat captionNumberingFormat_0;
        private long long_4;
        private string string_18;
        private string string_19;
        private string[] string_20;
        private string string_21;

        protected internal SequenceField(Field field) : base(field.Document)
        {
            this.captionNumberingFormat_0 = ~CaptionNumberingFormat.Number;
        }

        public SequenceField(IDocument doc) : base(doc)
        {
            this.captionNumberingFormat_0 = ~CaptionNumberingFormat.Number;
        }

        protected internal override string ConvertSwitchesToString()
        {
            int num = 11;
            string str = base.ConvertSwitchesToString();
            switch (this.captionNumberingFormat_0)
            {
                case CaptionNumberingFormat.Number:
                    return (str + BookmarkStart.b("ᄰ漲ἴ᜶砸椺簼紾ࡀB", num));

                case CaptionNumberingFormat.Roman:
                    return (str + BookmarkStart.b("ᄰ漲ἴ᜶欸琺瀼績ཀ", num));

                case CaptionNumberingFormat.Alphabetic:
                    return (str + BookmarkStart.b("ᄰ漲ἴ᜶砸眺洼眾@łDፆHࡊ", num));
            }
            return str;
        }

        public string CaptionName
        {
            get
            {
                return base.m_fieldValue;
            }
            set
            {
                base.m_fieldValue = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.SeqField;
            }
        }

        public string FormattingString
        {
            get
            {
                return base.m_formattingString;
            }
        }

        public CaptionNumberingFormat NumberFormat
        {
            get
            {
                return this.captionNumberingFormat_0;
            }
            set
            {
                this.captionNumberingFormat_0 = value;
            }
        }
    }
}

