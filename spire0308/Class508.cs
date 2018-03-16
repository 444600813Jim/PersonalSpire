using System;
using System.Drawing;

internal class Class508
{
    private double double_0;
    private double double_1;
    private double double_2;

    public Class508(Color A_0)
    {
        double num = ((double) A_0.R) / 255.0;
        double num2 = ((double) A_0.G) / 255.0;
        double num3 = ((double) A_0.B) / 255.0;
        double num4 = Math.Max(Math.Max(num, num2), num3);
        double num5 = Math.Min(Math.Min(num, num2), num3);
        double num6 = (num4 + num5) / 2.0;
        this.double_2 = num6;
        this.double_0 = num6;
        this.double_1 = num6;
        if (num4 == num5)
        {
            this.double_0 = 0.0;
            this.double_1 = 0.0;
        }
        else
        {
            double num7 = num4 - num5;
            this.double_1 = (this.double_2 > 0.5) ? (num7 / ((2.0 - num4) - num5)) : (num7 / (num4 + num5));
            if (num == num4)
            {
                this.double_0 = ((num2 - num3) / num7) + ((num2 < num3) ? ((double) 6) : ((double) 0));
            }
            else if (num2 == num4)
            {
                this.double_0 = ((num3 - num) / num7) + 2.0;
            }
            else if (num3 == num4)
            {
                this.double_0 = ((num - num2) / num7) + 4.0;
            }
        }
        this.double_0 /= 6.0;
    }

    public Class508(double A_0, double A_1, double A_2)
    {
        this.method_3(A_0);
        this.method_5(A_1);
        this.method_7(A_2);
    }

    internal sprⓚ method_0()
    {
        double num;
        double num2;
        double num3;
        if (this.double_2 == 0.0)
        {
            num = 0.0;
            num2 = 0.0;
            num3 = 0.0;
        }
        else if (this.double_1 == 0.0)
        {
            num = this.double_2;
            num2 = this.double_2;
            num3 = this.double_2;
        }
        else
        {
            double num4 = (this.double_2 < 0.5) ? (this.double_2 * (1.0 + this.double_1)) : ((this.double_2 + this.double_1) - (this.double_2 * this.double_1));
            double num5 = (2.0 * this.double_2) - num4;
            num = smethod_0(num5, num4, this.double_0 + 0.33333333333333331);
            num2 = smethod_0(num5, num4, this.double_0);
            num3 = smethod_0(num5, num4, this.double_0 - 0.33333333333333331);
        }
        return sprⓚ.ᜀ((int) (255.0 * num), (int) (255.0 * num2), (int) (255.0 * num3));
    }

    public Color method_1()
    {
        double num;
        double num2;
        double num3;
        if (this.double_2 == 0.0)
        {
            num = 0.0;
            num2 = 0.0;
            num3 = 0.0;
        }
        else if (this.double_1 == 0.0)
        {
            num = this.double_2;
            num2 = this.double_2;
            num3 = this.double_2;
        }
        else
        {
            double num4 = (this.double_2 < 0.5) ? (this.double_2 * (1.0 + this.double_1)) : ((this.double_2 + this.double_1) - (this.double_2 * this.double_1));
            double num5 = (2.0 * this.double_2) - num4;
            num = smethod_0(num5, num4, this.double_0 + 0.33333333333333331);
            num2 = smethod_0(num5, num4, this.double_0);
            num3 = smethod_0(num5, num4, this.double_0 - 0.33333333333333331);
        }
        return Color.FromArgb((int) (255.0 * num), (int) (255.0 * num2), (int) (255.0 * num3));
    }

    public double method_2()
    {
        return this.double_0;
    }

    public void method_3(double A_0)
    {
        this.double_0 = Class1133.smethod_2(A_0, 0.0, 1.0);
    }

    public double method_4()
    {
        return this.double_1;
    }

    public void method_5(double A_0)
    {
        this.double_1 = Class1133.smethod_2(A_0, 0.0, 1.0);
    }

    public double method_6()
    {
        return this.double_2;
    }

    public void method_7(double A_0)
    {
        this.double_2 = Class1133.smethod_2(A_0, 0.0, 1.0);
    }

    private static double smethod_0(double A_0, double A_1, double A_2)
    {
        if (A_2 < 0.0)
        {
            A_2++;
        }
        if (A_2 > 1.0)
        {
            A_2--;
        }
        if (A_2 < 0.16666666666666666)
        {
            return (A_0 + (((A_1 - A_0) * 6.0) * A_2));
        }
        if (A_2 < 0.5)
        {
            return A_1;
        }
        if (A_2 < 0.66666666666666663)
        {
            return (A_0 + (((A_1 - A_0) * (0.66666666666666663 - A_2)) * 6.0));
        }
        return A_0;
    }
}

