namespace Spire.Doc.Documents
{
    using System;

    public class SdtListItem
    {
        private bool[] bool_0;
        private long[] long_0;
        private string string_0;
        private string[] string_1;
        private string string_2;

        public SdtListItem(string value) : this(value, value)
        {
        }

        public SdtListItem(string displayText, string value)
        {
            this.string_2 = displayText;
            this.string_0 = value;
        }

        internal SdtListItem method_0()
        {
            return (SdtListItem) base.MemberwiseClone();
        }

        public string DisplayText
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        public string Value
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }
    }
}

