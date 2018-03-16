using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class624
{
    private static readonly int[] int_0 = new int[] { 
        -16777216, 0, 0xff0000, 0xffff00, 0xff00, 0xff00ff, 0xff, 0xffff, 0xffffff, 0x800000, 0x808000, 0x8000, 0x800080, 0x80, 0x8080, 0x808080, 
        0xc0c0c0
     };

    private Class624()
    {
    }

    internal static Word97Color smethod_0(Color A_0)
    {
        return smethod_2(smethod_6(A_0));
    }

    internal static Color smethod_1(Word97Color A_0)
    {
        return smethod_7(smethod_5(A_0));
    }

    internal static Word97Color smethod_2(int A_0)
    {
        if (A_0 == -16777216)
        {
            return Word97Color.Auto;
        }
        double maxValue = double.MaxValue;
        Word97Color black = Word97Color.Black;
        for (int i = 0; i < int_0.Length; i++)
        {
            double num2 = smethod_3(int_0[i], A_0);
            if (num2 <= maxValue)
            {
                black = (Word97Color) i;
                maxValue = num2;
            }
        }
        return black;
    }

    private static double smethod_3(int A_0, int A_1)
    {
        int red = A_0 & 0xff;
        int green = (A_0 & 0xff00) >> 8;
        int blue = (A_0 & 0xff0000) >> 0x10;
        int num4 = A_1 & 0xff;
        int num5 = (A_1 & 0xff00) >> 8;
        int num6 = (A_1 & 0xff0000) >> 0x10;
        Class508 class2 = new Class508(Color.FromArgb(red, green, blue));
        Class508 class3 = new Class508(Color.FromArgb(num4, num5, num6));
        double num7 = Math.Abs((double) (class2.method_4() - class3.method_4())) + Math.Abs((double) (class2.method_6() - class3.method_6()));
        if (!smethod_4(red, green, blue) && !smethod_4(num4, num5, num6))
        {
            num7 += Math.Abs((double) (class2.method_2() - class3.method_2()));
        }
        return num7;
    }

    private static bool smethod_4(int A_0, int A_1, int A_2)
    {
        return ((A_0 == A_1) && (A_1 == A_2));
    }

    internal static int smethod_5(Word97Color A_0)
    {
        if (A_0 < int_0.Length)
        {
            return int_0[(int) A_0];
        }
        return -16777216;
    }

    internal static int smethod_6(Color A_0)
    {
        int num = 0;
        num = 0 | A_0.R;
        num |= A_0.G << 8;
        num |= A_0.B << 0x10;
        return (num | (~A_0.A << 0x18));
    }

    internal static Color smethod_7(int A_0)
    {
        if (A_0 != -16777216)
        {
            int red = A_0 & 0xff;
            int green = (A_0 >> 8) & 0xff;
            int blue = (A_0 >> 0x10) & 0xff;
            int num4 = (A_0 >> 0x18) & 0xff;
            int alpha = ~num4 & 0xff;
            return Color.FromArgb(alpha, red, green, blue);
        }
        return Color.Empty;
    }
}

