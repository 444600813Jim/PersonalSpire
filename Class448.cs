using System;
using System.Drawing;

internal class Class448 : Class447
{
    private readonly float float_2;
    private readonly PointF pointF_0;
    private readonly PointF pointF_1;

    internal Class448(PointF A_0, PointF A_1) : base(A_0, A_1)
    {
        this.pointF_0 = A_0;
        this.pointF_1 = A_1;
        this.float_2 = spr⃸.ᜁ(this.pointF_0, this.pointF_1);
    }

    internal float method_14()
    {
        return spr⃸.ᜁ(this.pointF_0, this.pointF_1);
    }

    internal PointF method_15()
    {
        return this.pointF_0;
    }

    internal PointF method_16()
    {
        return this.pointF_1;
    }

    internal bool method_17(PointF A_0)
    {
        if (spr⃸.ᜀ(this.pointF_0, A_0) || spr⃸.ᜀ(this.pointF_1, A_0))
        {
            return true;
        }
        if (!base.method_6(A_0))
        {
            return false;
        }
        if (spr⃸.ᜁ(this.pointF_0, A_0) > this.float_2)
        {
            return false;
        }
        if (base.method_13())
        {
            return (((this.pointF_1.Y - this.pointF_0.Y) > 0f) == ((A_0.Y - this.pointF_0.Y) > 0f));
        }
        return (((this.pointF_1.X - this.pointF_0.X) > 0f) == ((A_0.X - this.pointF_0.X) > 0f));
    }

    internal PointF method_18(float A_0)
    {
        float num = this.method_14();
        if ((A_0 < 0f) || (A_0 > num))
        {
            return PointF.Empty;
        }
        if (A_0 == 0f)
        {
            return this.method_15();
        }
        if (spr⃸.ᜀ(A_0, num))
        {
            return this.method_16();
        }
        bool flag = false;
        if ((((base.method_9() >= 0f) && (this.method_15().X > this.method_16().X)) || ((base.method_9() < 0f) && (this.method_15().X < this.method_16().X))) || (base.method_13() && (this.method_15().Y > this.method_16().Y)))
        {
            flag = true;
        }
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        base.method_7(this.method_15(), A_0 * (flag ? ((float) (-1)) : ((float) 1)), tfArray2);
        return tfArray2[0];
    }

    internal static bool smethod_5(Class448 A_0, Class448 A_1, PointF[] A_2, bool A_3)
    {
        if (!Class447.smethod_2(A_0, A_1, A_2, A_3))
        {
            return false;
        }
        return (A_0.method_17(A_2[0]) && A_1.method_17(A_2[0]));
    }

    internal static bool smethod_6(Class448 A_0, Class447 A_1, PointF[] A_2, bool A_3)
    {
        if (!Class447.smethod_2(A_0, A_1, A_2, A_3))
        {
            return false;
        }
        return A_0.method_17(A_2[0]);
    }

    internal static bool smethod_7(Class448 A_0, Class448 A_1, PointF[] A_2)
    {
        if (!Class447.smethod_3(A_0, A_1, A_2))
        {
            return false;
        }
        return (A_0.method_17(A_2[0]) && A_1.method_17(A_2[0]));
    }

    internal static bool smethod_8(Class448 A_0, Class448 A_1)
    {
        PointF[] tfArray = new PointF[] { PointF.Empty };
        return smethod_7(A_0, A_1, tfArray);
    }
}

