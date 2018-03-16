namespace Spire.Doc.Documents
{
    using System;

    public abstract class SdtDocPart : SdtControlProperties
    {
        private bool bool_0;
        private float float_0;
        private float float_1;
        private int[] int_0;
        private int[] int_1;
        private string[] string_1;
        private string string_2 = "";
        private string string_3 = "";

        protected SdtDocPart()
        {
        }

        internal override SdtControlProperties Clone()
        {
            return (SdtDocPart) base.MemberwiseClone();
        }

        internal string BuildingBlockCategory
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }

        internal string BuildingBlockType
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

        internal bool IsUnique
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
    }
}

