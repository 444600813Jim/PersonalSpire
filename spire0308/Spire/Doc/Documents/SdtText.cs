namespace Spire.Doc.Documents
{
    using System;

    public class SdtText : SdtControlProperties
    {
        private bool bool_0;
        private readonly bool bool_1;
        private byte[] byte_0;
        private byte byte_1;
        private float[] float_0;
        private int[] int_0;
        private long[] long_1;
        private string[] string_1;

        public SdtText(bool isRichText)
        {
            this.bool_1 = isRichText;
        }

        public bool IsMultiline
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

        internal override SdtType Type
        {
            get
            {
                if (!this.bool_1)
                {
                    return SdtType.Text;
                }
                return SdtType.RichText;
            }
        }
    }
}

