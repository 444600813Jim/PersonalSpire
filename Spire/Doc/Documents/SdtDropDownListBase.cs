namespace Spire.Doc.Documents
{
    using System;

    public abstract class SdtDropDownListBase : SdtControlProperties
    {
        private byte byte_0;
        private float float_0;
        private int[] int_0;
        private long long_1;
        private SdtListItemCollection sdtListItemCollection_0;
        private string string_1;

        internal SdtDropDownListBase()
        {
            this.sdtListItemCollection_0 = new SdtListItemCollection(this);
        }

        internal override SdtControlProperties Clone()
        {
            SdtDropDownListBase base2 = (SdtDropDownListBase) base.MemberwiseClone();
            base2.sdtListItemCollection_0 = this.sdtListItemCollection_0.method_0();
            base2.sdtListItemCollection_0.Owner = null;
            return base2;
        }

        internal override void OnChange()
        {
            base.OnChange();
        }

        public string LastValue
        {
            get
            {
                return this.string_1;
            }
            set
            {
                this.string_1 = value;
            }
        }

        public SdtListItemCollection ListItems
        {
            get
            {
                return this.sdtListItemCollection_0;
            }
        }
    }
}

