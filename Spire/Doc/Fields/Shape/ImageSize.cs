namespace Spire.Doc.Fields.Shape
{
    using System;

    public class ImageSize
    {
        private bool[] bool_0;
        private byte[] byte_0;
        private readonly double double_0;
        private readonly double double_1;
        private float float_0;
        private float[] float_1;
        private int int_0;
        private readonly int int_1;
        private readonly int int_2;
        private string string_0;

        internal ImageSize(Class1044 A_0)
        {
            this.int_1 = A_0.method_4();
            this.int_2 = A_0.method_5();
            this.double_0 = A_0.method_6();
            this.double_1 = A_0.method_7();
        }

        public ImageSize(int widthPixels, int heightPixels) : this(widthPixels, heightPixels, 96.0, 96.0)
        {
        }

        public ImageSize(int widthPixels, int heightPixels, double horizontalResolution, double verticalResolution)
        {
            this.int_1 = widthPixels;
            this.int_2 = heightPixels;
            this.double_0 = horizontalResolution;
            this.double_1 = verticalResolution;
        }

        public int HeightPixels
        {
            get
            {
                return this.int_2;
            }
        }

        internal int HeightTwips
        {
            get
            {
                return Class969.smethod_11((double) this.int_2, this.double_1);
            }
        }

        public double HorizontalResolution
        {
            get
            {
                return this.double_0;
            }
        }

        internal bool IsValid
        {
            get
            {
                return ((this.WidthPixels > 0) && (this.HeightPixels > 0));
            }
        }

        public double VerticalResolution
        {
            get
            {
                return this.double_1;
            }
        }

        public int WidthPixels
        {
            get
            {
                return this.int_1;
            }
        }

        internal int WidthTwips
        {
            get
            {
                return Class969.smethod_11((double) this.int_1, this.double_0);
            }
        }
    }
}

