using System;
using System.Drawing;

internal class Class726
{
    private readonly PointF pointF_0;
    private readonly PointF pointF_1;
    private readonly PointF pointF_2;
    private readonly spr᣼ spr᣼_0;

    internal Class726(spr᣼ A_0)
    {
        this.spr᣼_0 = A_0;
        this.pointF_0 = new PointF(smethod_0(A_0, true), smethod_0(A_0, false));
        this.pointF_1 = new PointF(smethod_1(A_0, true), smethod_1(A_0, false));
        this.pointF_2 = A_0.ᜁ();
    }

    internal PointF method_0(float A_0)
    {
        if ((A_0 < 0f) || (A_0 > 1f))
        {
            return PointF.Empty;
        }
        if (A_0 == 0f)
        {
            return this.spr᣼_0.ᜁ();
        }
        if (A_0 == 1f)
        {
            return this.spr᣼_0.ᜀ();
        }
        float x = this.method_1(A_0, true);
        return new PointF(x, this.method_1(A_0, false));
    }

    private float method_1(float A_0, bool A_1)
    {
        float num = A_1 ? this.pointF_0.X : this.pointF_0.Y;
        float num2 = A_1 ? this.pointF_1.X : this.pointF_1.Y;
        float num3 = A_1 ? this.pointF_2.X : this.pointF_2.Y;
        return (((num * spr⃸.ᜀ(A_0)) + (A_0 * num2)) + num3);
    }

    internal spr᣼ method_2()
    {
        return this.spr᣼_0;
    }

    internal PointF method_3()
    {
        return this.pointF_0;
    }

    internal PointF method_4()
    {
        return this.pointF_1;
    }

    internal PointF method_5()
    {
        return this.pointF_2;
    }

    private static float smethod_0(spr᣼ A_0, bool A_1)
    {
        float[] numArray = smethod_2(A_0, A_1);
        float num = numArray[0];
        float num2 = numArray[1];
        float num3 = numArray[2];
        return ((num - (2f * num2)) + num3);
    }

    private static float smethod_1(spr᣼ A_0, bool A_1)
    {
        float[] numArray = smethod_2(A_0, A_1);
        float num = numArray[0];
        float num2 = numArray[1];
        return ((-2f * num) + (2f * num2));
    }

    private static float[] smethod_2(spr᣼ A_0, bool A_1)
    {
        return new float[] { (A_1 ? A_0.ᜁ().X : A_0.ᜁ().Y), (A_1 ? A_0.ᜂ().X : A_0.ᜂ().Y), (A_1 ? A_0.ᜀ().X : A_0.ᜀ().Y) };
    }
}

