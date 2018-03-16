namespace Spire.Doc
{
    using System;

    public class Endnote
    {
        private Body body_0;
        private Body body_1;
        private Body body_2;
        private bool[] bool_0;
        private byte[] byte_0;
        private Document document_0;
        private int int_0;

        public Endnote(Document document)
        {
            this.document_0 = document;
        }

        internal Endnote(Endnote A_0)
        {
            this.body_0 = A_0.Separator.Clone() as Body;
            this.body_1 = A_0.ContinuationSeparator.Clone() as Body;
            this.body_2 = A_0.ContinuationNotice.Clone() as Body;
        }

        public Endnote Clone()
        {
            return new Endnote(this);
        }

        internal void method_0(Document A_0)
        {
            this.document_0 = A_0;
            if (this.body_0 != null)
            {
                this.body_0.method_3(this.document_0, null);
            }
            if (this.body_1 != null)
            {
                this.body_1.method_3(this.document_0, null);
            }
            if (this.body_2 != null)
            {
                this.body_2.method_3(this.document_0, null);
            }
        }

        public Body ContinuationNotice
        {
            get
            {
                if (this.body_2 == null)
                {
                    this.body_2 = new Body(this.document_0, null);
                }
                return this.body_2;
            }
            set
            {
                this.body_2 = value;
                if (this.body_2 != null)
                {
                    this.body_2.method_3(this.document_0, null);
                }
            }
        }

        public Body ContinuationSeparator
        {
            get
            {
                if ((this.body_1 == null) || (((this.body_1.ChildObjects.Count == 0) && !this.document_0.bool_3) && !this.document_0.bool_5))
                {
                    this.body_1 = new Body(this.document_0, null);
                    char ch = '\x0004';
                    this.body_1.AddParagraph().AppendText(ch.ToString()).CharacterFormat.IsSpecial = true;
                }
                return this.body_1;
            }
            set
            {
                this.body_1 = value;
                if (this.body_1 != null)
                {
                    this.body_1.method_3(this.document_0, null);
                }
            }
        }

        public Body Separator
        {
            get
            {
                if ((this.body_0 == null) || (((this.body_0.ChildObjects.Count == 0) && !this.document_0.bool_3) && !this.document_0.bool_5))
                {
                    this.body_0 = new Body(this.document_0, null);
                    char ch = '\x0003';
                    this.body_0.AddParagraph().AppendText(ch.ToString()).CharacterFormat.IsSpecial = true;
                }
                return this.body_0;
            }
            set
            {
                this.body_0 = value;
                if (this.body_0 != null)
                {
                    this.body_0.method_3(this.document_0, null);
                }
            }
        }
    }
}

