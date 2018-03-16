namespace Spire.Doc
{
    using System;

    public class OdsoRecipientData
    {
        private bool bool_0 = true;
        private byte[] byte_0;
        private byte[] byte_1;
        private float[] float_0;
        private int int_0;
        private int[] int_1;
        private int[] int_2;
        private int int_3;

        public OdsoRecipientData Clone()
        {
            return (OdsoRecipientData) base.MemberwiseClone();
        }

        public bool Active
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

        public int Column
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        public int Hash
        {
            get
            {
                return this.int_3;
            }
            set
            {
                this.int_3 = value;
            }
        }

        public byte[] UniqueTag
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
    }
}

