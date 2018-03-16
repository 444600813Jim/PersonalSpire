namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using System;

    public class DocumentProperties
    {
        private Document document_0;
        private DocumentVersion documentVersion_0;
        private float float_0;
        private Spire.Doc.Hyphenation hyphenation_0;
        private int[] int_0;
        private string string_0;

        internal DocumentProperties(Document A_0)
        {
            this.document_0 = A_0;
        }

        internal void method_0(DocumentVersion A_0)
        {
            this.documentVersion_0 = A_0;
        }

        public bool FormFieldShading
        {
            get
            {
                return this.document_0.Settings.bool_41;
            }
            set
            {
                this.document_0.Settings.bool_41 = value;
            }
        }

        internal Spire.Doc.Hyphenation Hyphenation
        {
            get
            {
                if (this.hyphenation_0 == null)
                {
                    this.hyphenation_0 = new Spire.Doc.Hyphenation(this.document_0);
                }
                return this.hyphenation_0;
            }
        }

        public DocumentVersion Version
        {
            get
            {
                return this.documentVersion_0;
            }
        }
    }
}

