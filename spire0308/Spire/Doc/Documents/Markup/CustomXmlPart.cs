namespace Spire.Doc.Documents.Markup
{
    using Spire.Doc;
    using System;

    public class CustomXmlPart
    {
        private byte[] byte_0;
        private byte[] byte_1 = new byte[0];
        private Class1033 class1033_0 = new Class1033();
        private int int_0;
        private string string_0 = "";
        private string[] string_1;

        public CustomXmlPart Clone()
        {
            CustomXmlPart part = (CustomXmlPart) base.MemberwiseClone();
            part.class1033_0 = this.class1033_0.method_8();
            return part;
        }

        public byte[] Data
        {
            get
            {
                return this.byte_1;
            }
            set
            {
                int num = 7;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("䤬丮䔰刲", num));
                }
                this.byte_1 = value;
            }
        }

        public string Id
        {
            get
            {
                return this.string_0;
            }
            set
            {
                int num = 3;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("䀨伪", num));
                }
                this.string_0 = value;
            }
        }

        internal Class1033 Schemas
        {
            get
            {
                return this.class1033_0;
            }
        }
    }
}

