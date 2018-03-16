namespace Spire.Doc.Documents
{
    using Spire.Doc.Formatting;
    using System;

    public sealed class MarginsF : WordAttrCollection
    {
        private int int_8;
        internal const short short_0 = 1;
        internal const short short_1 = 2;
        internal const short short_2 = 3;
        internal const short short_3 = 4;
        internal const short short_4 = 5;

        public MarginsF()
        {
        }

        internal MarginsF(FormatBase A_0, int A_1) : base(A_0, A_1)
        {
        }

        public MarginsF(float left, float top, float right, float bottom)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        public MarginsF Clone()
        {
            return new MarginsF(this.Left, this.Top, this.Right, this.Bottom);
        }

        internal override void CopyPropertiesTo(FormatBase destFormat)
        {
            MarginsF sf = destFormat as MarginsF;
            if (base.HasKey(1))
            {
                sf.Left = this.Left;
            }
            if (base.HasKey(2))
            {
                sf.Right = this.Right;
            }
            if (base.HasKey(4))
            {
                sf.Bottom = this.Bottom;
            }
            if (base.HasKey(3))
            {
                sf.Top = this.Top;
            }
            if (base.HasKey(5))
            {
                sf.Gutter = this.Gutter;
            }
        }

        protected override object GetDefValue(int key)
        {
            switch (key)
            {
                case 1:
                case 2:
                    return 50f;

                case 3:
                case 4:
                    return 20f;

                case 5:
                    return 0f;
            }
            throw new NotImplementedException();
        }

        internal void method_49(MarginsF A_0)
        {
            if (!A_0.IsDefault)
            {
                this.Left = A_0.Left;
                this.Bottom = A_0.Bottom;
                this.Right = A_0.Right;
                this.Top = A_0.Top;
                this.Gutter = A_0.Gutter;
            }
        }

        public float All
        {
            get
            {
                if (!this.IsAll)
                {
                    return 0f;
                }
                return this.Left;
            }
            set
            {
                if ((this.Left != value) || !this.IsAll)
                {
                    float num;
                    float num2;
                    this.Bottom = num = value;
                    this.Top = num2 = num;
                    this.Left = this.Right = num2;
                }
            }
        }

        public float Bottom
        {
            get
            {
                return (float) base[4];
            }
            set
            {
                base[4] = value;
            }
        }

        internal float Gutter
        {
            get
            {
                return (float) base[5];
            }
            set
            {
                if (value != ((float) base[5]))
                {
                    base[5] = value;
                }
            }
        }

        private bool IsAll
        {
            get
            {
                return (((this.Left == this.Right) && (this.Right == this.Top)) && (this.Top == this.Bottom));
            }
        }

        public float Left
        {
            get
            {
                return (float) base[1];
            }
            set
            {
                base[1] = value;
            }
        }

        public float Right
        {
            get
            {
                return (float) base[2];
            }
            set
            {
                base[2] = value;
            }
        }

        public float Top
        {
            get
            {
                return (float) base[3];
            }
            set
            {
                base[3] = value;
            }
        }
    }
}

