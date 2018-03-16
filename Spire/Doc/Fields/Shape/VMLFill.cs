namespace Spire.Doc.Fields.Shape
{
    using Spire.Doc;
    using System;
    using System.Drawing;

    public class VMLFill
    {
        private float float_0;
        private float float_1;
        private readonly Interface0 interface0_0;
        private long long_0;
        private string string_0;
        private string string_1;

        internal VMLFill(Interface0 A_0)
        {
            this.interface0_0 = A_0;
        }

        internal void method_0(byte[] A_0)
        {
            this.method_3(0x100f, A_0);
            this.FillType = Spire.Doc.Fields.Shape.FillType.Picture;
        }

        private void method_1(double A_0, int A_1)
        {
            int num = 15;
            if ((A_0 < 0.0) || (A_0 > 1.0))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䌴嘶唸为堼", num));
            }
            this.method_3(A_1, Class969.smethod_71(A_0));
        }

        internal object method_2(int A_0)
        {
            return this.interface0_0.imethod_2(A_0);
        }

        internal void method_3(int A_0, object A_1)
        {
            this.interface0_0.imethod_3(A_0, A_1);
        }

        internal double Angle
        {
            get
            {
                return Class969.smethod_68((int) this.method_2(0x18b));
            }
            set
            {
                this.method_3(0x18b, Class969.smethod_71(value));
            }
        }

        public System.Drawing.Color Color
        {
            get
            {
                return this.ColorInternal;
            }
            set
            {
                this.ColorInternal = value;
                if (this.Parent is Background)
                {
                    (this.Parent as Background).method_7();
                }
            }
        }

        internal System.Drawing.Color Color2
        {
            get
            {
                return this.Color2Internal;
            }
            set
            {
                this.Color2Internal = value;
            }
        }

        internal System.Drawing.Color Color2Internal
        {
            get
            {
                return (System.Drawing.Color) this.method_2(0x183);
            }
            set
            {
                this.method_3(0x183, value);
            }
        }

        internal System.Drawing.Color ColorInternal
        {
            get
            {
                return (System.Drawing.Color) this.method_2(0x181);
            }
            set
            {
                this.method_3(0x181, value);
            }
        }

        internal string FillBlipName
        {
            get
            {
                return (string) this.method_2(0x187);
            }
            set
            {
                this.method_3(0x187, value);
            }
        }

        internal Spire.Doc.Fields.Shape.FillType FillType
        {
            get
            {
                return (Spire.Doc.Fields.Shape.FillType) this.method_2(0x180);
            }
            set
            {
                this.method_3(0x180, value);
            }
        }

        internal int Focus
        {
            get
            {
                return (int) this.method_2(0x18c);
            }
            set
            {
                int num = 0x13;
                if ((value < -100) || (value > 100))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("伸娺儼䨾⑀", num));
                }
                this.method_3(0x18c, value);
            }
        }

        internal double FocusLeft
        {
            get
            {
                return Class969.smethod_68((int) this.method_2(0x18d));
            }
            set
            {
                int num = 10;
                if ((value < 0.0) || (value > 1.0))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("䘯匱堳䌵崷", num));
                }
                this.method_3(0x18d, Class969.smethod_71(value));
            }
        }

        internal double FocusTop
        {
            get
            {
                return Class969.smethod_68((int) this.method_2(0x18e));
            }
            set
            {
                int num = 11;
                if ((value < 0.0) || (value > 1.0))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("䜰刲头䈶尸", num));
                }
                this.method_3(0x18e, Class969.smethod_71(value));
            }
        }

        internal Class954[] GradientColors
        {
            get
            {
                return (Class954[]) this.method_2(0x197);
            }
        }

        public byte[] ImageBytes
        {
            get
            {
                return (byte[]) this.method_2(0x100f);
            }
        }

        internal bool LockAspectRatio
        {
            get
            {
                return (((FillDimensionType) this.method_2(0x195)) != FillDimensionType.Default);
            }
            set
            {
                this.method_3(0x195, value ? FillDimensionType.FixedAspect : FillDimensionType.Default);
            }
        }

        public bool On
        {
            get
            {
                return (bool) this.method_2(0x1bb);
            }
            set
            {
                this.method_3(0x1bb, value);
            }
        }

        public double Opacity
        {
            get
            {
                return Class969.smethod_68((int) this.method_2(0x182));
            }
            set
            {
                this.method_1(value, 0x182);
            }
        }

        internal double Opacity2
        {
            get
            {
                return Class969.smethod_68((int) this.method_2(0x184));
            }
            set
            {
                this.method_1(value, 0x184);
            }
        }

        internal Interface0 Parent
        {
            get
            {
                return this.interface0_0;
            }
        }

        internal Struct36 Stretch
        {
            get
            {
                return (Struct36) this.method_2(0x103c);
            }
            set
            {
                this.method_3(0x103c, value);
            }
        }

        internal Struct37 Tile
        {
            get
            {
                return (Struct37) this.method_2(0x103e);
            }
            set
            {
                this.method_3(0x103e, value);
            }
        }

        internal bool Tiled
        {
            get
            {
                return (bool) this.method_2(0x103d);
            }
            set
            {
                this.method_3(0x103d, value);
            }
        }
    }
}

