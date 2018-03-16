using System;
using System.Drawing;

internal class Class447
{
    private bool bool_0;
    private float float_0;
    private float float_1;

    internal Class447()
    {
    }

    internal Class447(PointF A_0, PointF A_1)
    {
        if (spr⃸.ᜀ(A_0.X, A_1.X))
        {
            this.bool_0 = true;
            this.method_12(A_0.X);
        }
        else
        {
            this.method_10((A_0.Y - A_1.Y) / (A_0.X - A_1.X));
            this.method_12(A_0.Y - (this.method_9() * A_0.X));
        }
    }

    internal float method_0(float A_0)
    {
        if (!this.method_13())
        {
            return ((this.method_9() * A_0) + this.method_11());
        }
        return this.method_11();
    }

    internal bool method_1(PointF A_0)
    {
        if (!this.method_13())
        {
            return (this.method_0(A_0.X) < A_0.Y);
        }
        return (this.method_11() < A_0.X);
    }

    internal void method_10(float A_0)
    {
        this.float_0 = A_0;
    }

    internal float method_11()
    {
        return this.float_1;
    }

    internal void method_12(float A_0)
    {
        this.float_1 = A_0;
    }

    internal bool method_13()
    {
        return this.bool_0;
    }

    internal Class447 method_2(float A_0)
    {
        float num;
        if (this.method_9() == 0f)
        {
            num = A_0;
        }
        else
        {
            float num2 = (float) Math.Abs(Math.Cos(Math.Atan((double) this.method_9())));
            num = A_0 / num2;
        }
        Class447 class2 = new Class447 {
            bool_0 = this.method_13()
        };
        class2.method_10(this.method_9());
        class2.method_12(this.method_11() + num);
        return class2;
    }

    internal Class447 method_3(PointF A_0)
    {
        return this.method_4(A_0, false);
    }

    internal Class447 method_4(PointF A_0, bool A_1)
    {
        Class447 class2 = new Class447();
        if (this.method_13())
        {
            if (A_1 && !spr⃸.ᜀ(A_0.X, this.method_11()))
            {
                return null;
            }
            return new Class447(A_0, new PointF(A_0.X + 1f, A_0.Y));
        }
        if (this.method_9() == 0f)
        {
            if (A_1 && !spr⃸.ᜀ(A_0.Y, this.method_11()))
            {
                return null;
            }
            class2.bool_0 = true;
            class2.method_12(A_0.X);
            return class2;
        }
        if (A_1 && !spr⃸.ᜀ(this.method_0(A_0.X), A_0.Y))
        {
            return null;
        }
        class2.method_10(-1f / this.method_9());
        class2.method_12((A_0.X * (this.method_9() - class2.method_9())) + this.method_11());
        return class2;
    }

    internal Class447 method_5(PointF A_0)
    {
        Class447 class2 = new Class447();
        if (this.method_13())
        {
            class2.bool_0 = true;
            class2.method_12(A_0.X);
            return class2;
        }
        class2.method_10(this.method_9());
        class2.method_12(A_0.Y - (this.method_9() * A_0.X));
        return class2;
    }

    internal bool method_6(PointF A_0)
    {
        if (this.method_13())
        {
            return spr⃸.ᜀ(A_0.X, this.method_11());
        }
        return spr⃸.ᜀ(A_0.Y, this.method_0(A_0.X));
    }

    internal void method_7(PointF A_0, float A_1, PointF[] A_2)
    {
        this.method_8(A_0, A_1, A_2, false);
    }

    internal bool method_8(PointF A_0, float A_1, PointF[] A_2, bool A_3)
    {
        if (A_3 && !this.method_6(A_0))
        {
            return false;
        }
        if (this.method_13())
        {
            A_2[0] = new PointF(A_0.X, A_0.Y + A_1);
            return true;
        }
        if (this.method_9() < 0f)
        {
            A_1 *= -1f;
        }
        double d = Math.Atan((double) this.method_9());
        float x = ((float) (Math.Cos(d) * A_1)) + A_0.X;
        float y = ((float) (Math.Sin(d) * A_1)) + A_0.Y;
        A_2[0] = new PointF(x, y);
        return true;
    }

    internal float method_9()
    {
        return this.float_0;
    }

    internal static bool smethod_0(Class447 A_0, Class447 A_1)
    {
        return ((A_0.method_13() && A_1.method_13()) || ((spr⃸.ᜀ(A_0.method_9(), A_1.method_9()) && !A_0.method_13()) && !A_1.method_13()));
    }

    internal static void smethod_1(Class447 A_0, Class447 A_1, PointF[] A_2)
    {
        smethod_2(A_0, A_1, A_2, false);
    }

    internal static bool smethod_2(Class447 A_0, Class447 A_1, PointF[] A_2, bool A_3)
    {
        float num;
        float num2;
        if (A_3 && smethod_0(A_0, A_1))
        {
            return false;
        }
        if (A_0.method_13())
        {
            num = A_0.method_11();
            num2 = A_1.method_0(num);
        }
        else if (A_1.method_13())
        {
            num = A_1.method_11();
            num2 = A_0.method_0(num);
        }
        else
        {
            num = (A_1.method_11() - A_0.method_11()) / (A_0.method_9() - A_1.method_9());
            num2 = (A_0.method_9() * num) + A_0.method_11();
        }
        A_2[0] = new PointF(num, num2);
        return true;
    }

    internal static bool smethod_3(Class447 A_0, Class447 A_1, PointF[] A_2)
    {
        return (((!A_0.method_13() || !A_1.method_13()) && (A_0.method_9() != A_1.method_9())) && smethod_2(A_0, A_1, A_2, false));
    }

    internal static Class447 smethod_4(PointF A_0, bool A_1)
    {
        return new Class447(A_0, new PointF(A_0.X + (A_1 ? ((float) 1) : ((float) 0)), A_0.Y + (A_1 ? ((float) 0) : ((float) 1))));
    }
}

