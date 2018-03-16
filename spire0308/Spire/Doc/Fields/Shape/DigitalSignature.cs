namespace Spire.Doc.Fields.Shape
{
    using System;
    using System.Collections;
    using System.Security.Cryptography.X509Certificates;

    public class DigitalSignature
    {
        private readonly ArrayList arrayList_0 = new ArrayList();
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private byte byte_0;
        private byte[] byte_1;
        private byte[] byte_2;
        private byte[] byte_3;
        private byte[] byte_4;
        private System.DateTime dateTime_0;
        private readonly DigitalSignatureType digitalSignatureType_0;
        private Guid guid_0;
        private Guid guid_1;
        private string[] string_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        private X509Certificate2 x509Certificate2_0;

        internal DigitalSignature(DigitalSignatureType A_0)
        {
            this.digitalSignatureType_0 = A_0;
            this.dateTime_0 = System.DateTime.MinValue;
            this.string_1 = "";
        }

        internal void method_0(System.DateTime A_0)
        {
            this.dateTime_0 = A_0;
        }

        internal void method_1(string A_0)
        {
            this.string_1 = A_0;
        }

        internal void method_2(bool A_0)
        {
            this.bool_0 = A_0;
        }

        internal void method_3(X509Certificate2 A_0)
        {
            this.x509Certificate2_0 = A_0;
        }

        public X509Certificate2 Certificate
        {
            get
            {
                return this.x509Certificate2_0;
            }
        }

        public string Comments
        {
            get
            {
                return this.string_1;
            }
        }

        public System.DateTime DateTime
        {
            get
            {
                return this.dateTime_0;
            }
        }

        internal byte[] ImageBytes
        {
            get
            {
                return this.byte_1;
            }
            set
            {
                this.byte_1 = value;
            }
        }

        internal byte[] ImageBytesInvalid
        {
            get
            {
                return this.byte_3;
            }
            set
            {
                this.byte_3 = value;
            }
        }

        internal byte[] ImageBytesValid
        {
            get
            {
                return this.byte_2;
            }
            set
            {
                this.byte_2 = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return this.bool_0;
            }
        }

        internal Guid ProviderId
        {
            get
            {
                return this.guid_1;
            }
            set
            {
                this.guid_1 = value;
            }
        }

        internal ArrayList References
        {
            get
            {
                return this.arrayList_0;
            }
        }

        internal Guid SetupId
        {
            get
            {
                return this.guid_0;
            }
            set
            {
                this.guid_0 = value;
            }
        }

        internal bool SignedXmlResult
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

        internal string Text
        {
            get
            {
                return this.string_4;
            }
            set
            {
                this.string_4 = value;
            }
        }

        public DigitalSignatureType Type
        {
            get
            {
                return this.digitalSignatureType_0;
            }
        }

        internal bool Visible
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
    }
}

