using Spire.Doc;
using System;
using System.Collections;

internal class Class317
{
    private readonly double[] double_0;
    internal const float float_0 = 1E-06f;
    internal const float float_1 = 6f;

    internal Class317(double A_0, double A_1, double A_2)
    {
        this.double_0 = new double[] { A_2, A_1, A_0 };
    }

    internal Class317(double A_0, double A_1, double A_2, double A_3)
    {
        this.double_0 = new double[] { A_3, A_2, A_1, A_0 };
    }

    internal Class317(double A_0, double A_1, double A_2, double A_3, double A_4)
    {
        this.double_0 = new double[] { A_4, A_3, A_2, A_1, A_0 };
    }

    internal double[] method_0()
    {
        int num = 11;
        switch (this.method_1())
        {
            case 0:
                return new double[0];

            case 1:
                return new double[] { ((-1.0 * this.double_0[0]) / this.double_0[1]) };

            case 2:
                return this.method_2();

            case 3:
                return this.method_3();

            case 4:
                return this.method_4();
        }
        throw new NotSupportedException(BookmarkStart.b("琰䔲吴嬶䰸娺䤼嘾⽀⑂敄㕆♈⑊㥌㱎煐㱒㍔睖ⵘ㍚㱜⭞䅠ݢdf᭨๪࡬佮ᡰr啴᥶ᙸེ嵼౾ﮈﾊ", num));
    }

    internal int method_1()
    {
        int num = this.double_0.Length - 1;
        for (int i = num; i > -1; i--)
        {
            if (Math.Abs(this.double_0[i]) >= 9.9999999747524271E-07)
            {
                return i;
            }
            this.double_0[i] = 0.0;
        }
        return 0;
    }

    private double[] method_2()
    {
        double[] numArray = new double[0];
        double num = this.double_0[2];
        double num2 = this.double_0[1] / num;
        double num3 = this.double_0[0] / num;
        double d = (num2 * num2) - (4.0 * num3);
        if (d > 0.0)
        {
            double num5 = Math.Sqrt(d);
            return new double[] { (0.5 * (-num2 + num5)), (0.5 * (-num2 - num5)) };
        }
        if (d == 0.0)
        {
            numArray = new double[] { 0.5 * -num2 };
        }
        return numArray;
    }

    private double[] method_3()
    {
        double num18;
        double num = this.double_0[3];
        double num2 = this.double_0[2] / num;
        double num3 = this.double_0[1] / num;
        double num4 = this.double_0[0] / num;
        double num5 = ((3.0 * num3) - (num2 * num2)) / 3.0;
        double num6 = (((((2.0 * num2) * num2) * num2) - ((9.0 * num3) * num2)) + (27.0 * num4)) / 27.0;
        double num7 = num2 / 3.0;
        double num8 = ((num6 * num6) / 4.0) + (((num5 * num5) * num5) / 27.0);
        double x = num6 / 2.0;
        if (Math.Abs(num8) <= 9.9999999747524271E-07)
        {
            num8 = 0.0;
        }
        if (num8 > 0.0)
        {
            double num10;
            double num12 = Math.Sqrt(num8);
            double num11 = -x + num12;
            if (num11 >= 0.0)
            {
                num10 = Math.Pow(num11, 0.33333333333333331);
            }
            else
            {
                num10 = -Math.Pow(-num11, 0.33333333333333331);
            }
            num11 = -x - num12;
            if (num11 >= 0.0)
            {
                num10 += Math.Pow(num11, 0.33333333333333331);
            }
            else
            {
                num10 -= Math.Pow(-num11, 0.33333333333333331);
            }
            return new double[] { (num10 - num7) };
        }
        if (num8 < 0.0)
        {
            double num13 = Math.Sqrt(-num5 / 3.0);
            double d = Math.Atan2(Math.Sqrt(-num8), -x) / 3.0;
            double num15 = Math.Cos(d);
            double num16 = Math.Sin(d);
            double num17 = Math.Sqrt(3.0);
            return new double[] { (((2.0 * num13) * num15) - num7), ((-num13 * (num15 + (num17 * num16))) - num7), ((-num13 * (num15 - (num17 * num16))) - num7) };
        }
        if (x >= 0.0)
        {
            num18 = -Math.Pow(x, 0.33333333333333331);
        }
        else
        {
            num18 = Math.Pow(-x, 0.33333333333333331);
        }
        return new double[] { ((2.0 * num18) - num7), (-num18 - num7) };
    }

    private double[] method_4()
    {
        double[] numArray = new double[0];
        double num = this.double_0[4];
        double num2 = this.double_0[3] / num;
        double num3 = this.double_0[2] / num;
        double num4 = this.double_0[1] / num;
        double num5 = this.double_0[0] / num;
        double num6 = new Class317(1.0, -1.0 * num3, (num2 * num4) - (4.0 * num5), ((((-1.0 * num2) * num2) * num5) + ((4.0 * num3) * num5)) - (num4 * num4)).method_3()[0];
        double num7 = (((num2 * num2) / 4.0) - num3) + num6;
        if (Math.Abs(num7) <= 9.9999999747524271E-07)
        {
            num7 = 0.0;
        }
        if (num7 > 0.0)
        {
            return smethod_2(num2, num3, num4, num7);
        }
        if (num7 >= 0.0)
        {
            numArray = smethod_0(num2, num3, num5, num6);
        }
        return numArray;
    }

    private static double[] smethod_0(double A_0, double A_1, double A_2, double A_3)
    {
        double[] numArray = new double[0];
        double d = (A_3 * A_3) - (4.0 * A_2);
        if (d >= -9.9999999747524271E-07)
        {
            if (d < 0.0)
            {
                d = 0.0;
            }
            d = 2.0 * Math.Sqrt(d);
            double num2 = (((3.0 * A_0) * A_0) / 4.0) - (2.0 * A_1);
            int num3 = ((num2 + d) >= 9.9999999747524271E-07) ? 2 : 0;
            num3 += ((num2 - d) >= 9.9999999747524271E-07) ? 2 : 0;
            numArray = new double[num3];
            int num4 = 0;
            if ((num2 + d) >= 9.9999999747524271E-07)
            {
                double num5 = Math.Sqrt(num2 + d);
                numArray[num4++] = (-A_0 / 4.0) + (num5 / 2.0);
                numArray[num4++] = (-A_0 / 4.0) - (num5 / 2.0);
            }
            if ((num2 - d) >= 9.9999999747524271E-07)
            {
                double num6 = Math.Sqrt(num2 - d);
                numArray[num4++] = (-A_0 / 4.0) + (num6 / 2.0);
                numArray[num4++] = (-A_0 / 4.0) - (num6 / 2.0);
            }
        }
        return numArray;
    }

    private static void smethod_1(double A_0, double A_1, ArrayList A_2)
    {
        A_2.Add((-A_0 / 4.0) + (A_1 / 2.0));
        A_2.Add((-A_0 / 4.0) - (A_1 / 2.0));
    }

    private static double[] smethod_2(double A_0, double A_1, double A_2, double A_3)
    {
        double num = Math.Sqrt(A_3);
        double num2 = ((((3.0 * A_0) * A_0) / 4.0) - (num * num)) - (2.0 * A_1);
        double num3 = ((((4.0 * A_0) * A_1) - (8.0 * A_2)) - ((A_0 * A_0) * A_0)) / (4.0 * num);
        double num4 = num2 + num3;
        double num5 = num2 - num3;
        if (Math.Abs(num4) <= 9.9999999747524271E-07)
        {
            num4 = 0.0;
        }
        if (Math.Abs(num5) <= 9.9999999747524271E-07)
        {
            num5 = 0.0;
        }
        int num8 = (num4 >= 0.0) ? 2 : 0;
        num8 += (num5 >= 0.0) ? 2 : 0;
        double[] numArray = new double[num8];
        int num7 = 0;
        if (num4 >= 0.0)
        {
            double num9 = Math.Sqrt(num4);
            numArray[num7++] = (-A_0 / 4.0) + ((num + num9) / 2.0);
            numArray[num7++] = (-A_0 / 4.0) + ((num - num9) / 2.0);
        }
        if (num5 >= 0.0)
        {
            double num6 = Math.Sqrt(num5);
            numArray[num7++] = (-A_0 / 4.0) + ((-num - num6) / 2.0);
            numArray[num7++] = (-A_0 / 4.0) + ((num6 - num) / 2.0);
        }
        return numArray;
    }

    private static void smethod_3(double A_0, double A_1, double A_2, bool A_3, ArrayList A_4)
    {
        A_4.Add((-A_0 / 4.0) + ((A_3 ? (A_1 + A_2) : (-A_1 - A_2)) / 2.0));
        A_4.Add((-A_0 / 4.0) + ((A_3 ? (A_1 - A_2) : (A_2 - A_1)) / 2.0));
    }
}

