using System;
using System.Drawing;

internal class Class915
{
    private readonly double double_0;
    private readonly double double_1;
    private readonly double double_2;
    private readonly double double_3;

    public Class915(double A_0, double A_1, double A_2, double A_3)
    {
        this.double_1 = A_0;
        this.double_2 = A_1;
        this.double_3 = A_2;
        this.double_0 = A_3;
    }

    public bool method_0()
    {
        return ((((this.double_1 == 0.0) && (this.double_2 == 0.0)) && (this.double_3 == 0.0)) && (this.double_0 == 0.0));
    }

    public bool method_1()
    {
        if (((this.double_1 <= 0.0) && (this.double_2 <= 0.0)) && (this.double_3 <= 0.0))
        {
            return (this.double_0 > 0.0);
        }
        return true;
    }

    public bool method_2()
    {
        if (((this.double_1 >= 0.0) && (this.double_2 >= 0.0)) && (this.double_3 >= 0.0))
        {
            return (this.double_0 < 0.0);
        }
        return true;
    }

    public RectangleF method_3(RectangleF A_0)
    {
        double num = A_0.Left + (A_0.Width * this.double_1);
        double num2 = A_0.Left + (A_0.Width * (1.0 - this.double_2));
        double num3 = A_0.Top + (A_0.Height * this.double_3);
        double num4 = A_0.Top + (A_0.Height * (1.0 - this.double_0));
        return RectangleF.FromLTRB((float) num, (float) num3, (float) num2, (float) num4);
    }

    public Rectangle method_4(Rectangle A_0)
    {
        double num = A_0.Left + (A_0.Width * Math.Max(0.0, this.double_1));
        double num2 = A_0.Left + (A_0.Width * (1.0 - Math.Max(0.0, this.double_2)));
        double num3 = A_0.Top + (A_0.Height * Math.Max(0.0, this.double_3));
        double num4 = A_0.Top + (A_0.Height * (1.0 - Math.Max(0.0, this.double_0)));
        return Rectangle.FromLTRB(Class1133.smethod_5(num), Class1133.smethod_5(num3), Class1133.smethod_5(num2), Class1133.smethod_5(num4));
    }

    public RectangleF method_5(RectangleF A_0)
    {
        double num = 1.0 / (1.0 - Math.Min((double) 0.0, (double) (this.double_1 + this.double_2)));
        double num2 = 1.0 / (1.0 - Math.Min((double) 0.0, (double) (this.double_3 + this.double_0)));
        double num3 = -Math.Min(0.0, this.double_1);
        double num4 = -Math.Min(0.0, this.double_2);
        double num5 = -Math.Min(0.0, this.double_3);
        double num6 = -Math.Min(0.0, this.double_0);
        double num7 = A_0.Left + ((A_0.Width * num3) * num);
        double num8 = A_0.Left + (A_0.Width * (1.0 - (num4 * num)));
        double num9 = A_0.Top + ((A_0.Height * num5) * num2);
        double num10 = A_0.Top + (A_0.Height * (1.0 - (num6 * num2)));
        return RectangleF.FromLTRB((float) num7, (float) num9, (float) num8, (float) num10);
    }

    public spr⊗ method_6(byte[] A_0)
    {
        using (spr⊗ r⊗ = new spr⊗(A_0))
        {
            Rectangle rectangle = this.method_4(new Rectangle(0, 0, r⊗.ᜃ(), r⊗.ᜍ()));
            return r⊗.ᜀ(rectangle);
        }
    }

    public static bool smethod_0(Class915 A_0)
    {
        if (A_0 != null)
        {
            return A_0.method_0();
        }
        return true;
    }

    public static int smethod_1(byte[] A_0, Class915 A_1)
    {
        int hashCode = Class968.smethod_0(A_0).GetHashCode();
        int num2 = ((A_1 == null) || !A_1.method_1()) ? 0 : A_1.GetHashCode();
        return (hashCode ^ num2);
    }

    public static int smethod_2(byte[] A_0, Class915 A_1, Class236 A_2)
    {
        int num = smethod_1(A_0, A_1);
        if (A_2 != null)
        {
            num = (num * 0x18d) ^ A_2.GetHashCode();
        }
        return num;
    }

    int object.GetHashCode()
    {
        return ((((this.double_1.GetHashCode() >> 1) ^ (this.double_2.GetHashCode() << 3)) ^ (this.double_3.GetHashCode() << 1)) ^ (this.double_0.GetHashCode() >> 3));
    }
}

