namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Fields.Shape;
    using System;

    public class WordArt
    {
        private byte byte_0;
        private float float_0;
        private int[] int_0;
        private readonly Interface0 interface0_0;
        private long[] long_0;
        private long long_1;
        private long long_2;

        internal WordArt(Interface0 A_0)
        {
            this.interface0_0 = A_0;
        }

        private object method_0(int A_0)
        {
            return this.interface0_0.imethod_2(A_0);
        }

        private void method_1(int A_0, object A_1)
        {
            this.interface0_0.imethod_3(A_0, A_1);
        }

        public bool Bold
        {
            get
            {
                return (bool) this.method_0(250);
            }
            set
            {
                this.method_1(250, value);
            }
        }

        internal bool FitPath
        {
            get
            {
                return (bool) this.method_0(0xf7);
            }
            set
            {
                this.method_1(0xf7, value);
            }
        }

        internal bool FitShape
        {
            get
            {
                return (bool) this.method_0(0xf5);
            }
            set
            {
                this.method_1(0xf5, value);
            }
        }

        public string FontFamily
        {
            get
            {
                return (string) this.method_0(0xc5);
            }
            set
            {
                this.method_1(0xc5, value);
            }
        }

        public bool Italic
        {
            get
            {
                return (bool) this.method_0(0xfb);
            }
            set
            {
                this.method_1(0xfb, value);
            }
        }

        internal bool Kerning
        {
            get
            {
                return (bool) this.method_0(0xf3);
            }
            set
            {
                this.method_1(0xf3, value);
            }
        }

        internal bool On
        {
            get
            {
                return (bool) this.method_0(0xf1);
            }
            set
            {
                this.method_1(0xf1, value);
            }
        }

        internal bool ReverseRows
        {
            get
            {
                return (bool) this.method_0(240);
            }
            set
            {
                this.method_1(240, value);
            }
        }

        internal bool RotateLetters
        {
            get
            {
                return (bool) this.method_0(0xf2);
            }
            set
            {
                this.method_1(0xf2, value);
            }
        }

        internal bool SameLetterHeights
        {
            get
            {
                return (bool) this.method_0(0xf8);
            }
            set
            {
                this.method_1(0xf8, value);
            }
        }

        internal bool Shadow
        {
            get
            {
                return (bool) this.method_0(0xfd);
            }
            set
            {
                this.method_1(0xfd, value);
            }
        }

        public double Size
        {
            get
            {
                return Class969.smethod_68((int) this.method_0(0xc3));
            }
            set
            {
                this.method_1(0xc3, Class969.smethod_71(value));
            }
        }

        public bool SmallCaps
        {
            get
            {
                return (bool) this.method_0(0xfe);
            }
            set
            {
                this.method_1(0xfe, value);
            }
        }

        internal double Spacing
        {
            get
            {
                return Class969.smethod_68((int) this.method_0(0xc4));
            }
            set
            {
                this.method_1(0xc4, Class969.smethod_71(value));
                this.method_1(0xf4, true);
            }
        }

        internal bool StrikeThrough
        {
            get
            {
                return (bool) this.method_0(0xff);
            }
            set
            {
                this.method_1(0xff, value);
            }
        }

        public string Text
        {
            get
            {
                return (string) this.method_0(0xc0);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("伸娺儼䨾⑀", 0x13));
                this.method_1(0xc0, value);
            }
        }

        internal Spire.Doc.Fields.Shape.TextPathAlignment TextPathAlignment
        {
            get
            {
                return (Spire.Doc.Fields.Shape.TextPathAlignment) this.method_0(0xc2);
            }
            set
            {
                this.method_1(0xc2, value);
            }
        }

        internal bool Trim
        {
            get
            {
                return (bool) this.method_0(0xf6);
            }
            set
            {
                this.method_1(0xf6, value);
            }
        }

        internal bool Underline
        {
            get
            {
                return (bool) this.method_0(0xfc);
            }
            set
            {
                this.method_1(0xfc, value);
            }
        }

        internal bool XScale
        {
            get
            {
                return (bool) this.method_0(0xf9);
            }
            set
            {
                this.method_1(0xf9, value);
            }
        }
    }
}

