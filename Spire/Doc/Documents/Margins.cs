namespace Spire.Doc.Documents
{
    using System;

    public sealed class Margins
    {
        private bool[] bool_0;
        private bool[] bool_1;
        private int int_0;
        private int[] int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private string string_0;

        public Margins()
        {
        }

        public Margins(int left, int top, int right, int bottom)
        {
            this.int_0 = left;
            this.int_3 = top;
            this.int_2 = right;
            this.int_4 = bottom;
        }

        public int All
        {
            get
            {
                if (!this.IsAll)
                {
                    return 0;
                }
                return this.int_0;
            }
            set
            {
                if (!this.IsAll && (this.int_0 != value))
                {
                    this.int_0 = this.int_2 = this.int_3 = this.int_4 = value;
                }
            }
        }

        public int Bottom
        {
            get
            {
                return this.int_4;
            }
            set
            {
                if (value != this.int_4)
                {
                    this.int_4 = value;
                }
            }
        }

        private bool IsAll
        {
            get
            {
                return (((this.int_0 == this.int_2) && (this.int_2 == this.int_3)) && (this.int_3 == this.int_4));
            }
        }

        public int Left
        {
            get
            {
                return this.int_0;
            }
            set
            {
                if (value != this.int_0)
                {
                    this.int_0 = value;
                }
            }
        }

        public int Right
        {
            get
            {
                return this.int_2;
            }
            set
            {
                if (value != this.int_2)
                {
                    this.int_2 = value;
                }
            }
        }

        public int Top
        {
            get
            {
                return this.int_3;
            }
            set
            {
                if (value != this.int_3)
                {
                    this.int_3 = value;
                }
            }
        }
    }
}

