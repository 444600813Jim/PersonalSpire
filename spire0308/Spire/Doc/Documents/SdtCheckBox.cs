namespace Spire.Doc.Documents
{
    using System;
    using System.Globalization;

    public class SdtCheckBox : SdtControlProperties
    {
        private bool bool_0;
        private bool bool_1;
        private byte byte_0;
        private Class67 class67_0 = Class67.class67_0;
        private Class67 class67_1 = Class67.class67_1;
        public const char DefaultCheckedState = '☒';
        public const string DefaultFontName = "MS Gothic";
        public const char DefaultUncheckedState = '☐';
        private int[] int_0;
        private string[] string_1;

        internal override SdtControlProperties Clone()
        {
            SdtCheckBox box = (SdtCheckBox) base.MemberwiseClone();
            box.class67_0 = this.class67_0.method_0();
            box.class67_1 = this.class67_1.method_0();
            return box;
        }

        internal void method_0(bool A_0)
        {
            this.bool_0 = A_0;
        }

        internal static int smethod_0(string A_0)
        {
            return int.Parse(A_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        }

        public bool Checked
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
                this.OnChange();
            }
        }

        internal Class67 CheckedState
        {
            get
            {
                return this.class67_0;
            }
            set
            {
                this.class67_0 = value;
            }
        }

        internal override SdtType Type
        {
            get
            {
                return SdtType.CheckBox;
            }
        }

        internal Class67 UncheckedState
        {
            get
            {
                return this.class67_1;
            }
            set
            {
                this.class67_1 = value;
            }
        }
    }
}

