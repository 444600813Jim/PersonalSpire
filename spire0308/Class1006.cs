using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Drawing;

[CLSCompliant(false)]
internal class Class1006
{
    private byte byte_0;
    private Color color_0;
    private static readonly int[] int_0 = new int[] { 0, -16777216, -16776961, -16711681, -16744448, -65281, -65536, -256, -1, -16777077, -16741493, -16751616, -7667573, -7667712, -256 };
    internal static readonly List<Color> list_0;
    internal static readonly uint[] uint_0 = new uint[] { 
        0xff000000, smethod_22(Color.Black), smethod_22(Color.Blue), smethod_22(Color.Cyan), smethod_22(Color.Green), smethod_22(Color.Magenta), smethod_22(Color.Red), smethod_22(Color.Yellow), smethod_22(Color.White), smethod_22(Color.DarkBlue), smethod_22(Color.DarkCyan), smethod_22(Color.DarkGreen), smethod_22(Color.DarkMagenta), smethod_22(Color.DarkRed), smethod_22(Color.Gold), 0x808080, 
        smethod_22(Color.LightGray)
     };

    static Class1006()
    {
        Color[] collection = new Color[] { 
            Color.Empty, Color.Black, Color.Blue, Color.Cyan, Color.Green, Color.Magenta, Color.Red, Color.Yellow, Color.White, Color.DarkBlue, Color.DarkCyan, Color.DarkGreen, Color.DarkMagenta, Color.DarkRed, Color.Gold, Color.DarkGray, 
            Color.LightGray
         };
        list_0 = new List<Color>(collection);
    }

    public Class1006(byte A_0)
    {
        this.color_0 = Color.FromArgb(int_0[A_0]);
        this.byte_0 = A_0;
    }

    public Color method_0()
    {
        return this.color_0;
    }

    public byte method_1()
    {
        return this.byte_0;
    }

    public int method_2()
    {
        return int_0[this.byte_0];
    }

    public static Class1006 smethod_0()
    {
        return new Class1006(0);
    }

    public static Class1006 smethod_1()
    {
        return new Class1006(1);
    }

    public static Class1006 smethod_10()
    {
        return new Class1006(10);
    }

    public static Class1006 smethod_11()
    {
        return new Class1006(11);
    }

    public static Class1006 smethod_12()
    {
        return new Class1006(12);
    }

    public static Class1006 smethod_13()
    {
        return new Class1006(13);
    }

    public static Class1006 smethod_14()
    {
        return new Class1006(14);
    }

    public static Class1006 smethod_15()
    {
        return new Class1006(15);
    }

    public static Class1006 smethod_16()
    {
        return new Class1006(0x10);
    }

    public static Color smethod_17(int A_0)
    {
        if ((A_0 >= 0) && (A_0 <= (int_0.Length - 1)))
        {
            return Color.FromArgb(int_0[A_0]);
        }
        return Color.Empty;
    }

    public static int smethod_18(Color A_0)
    {
        int num = A_0.ToArgb();
        for (int i = 0; i < int_0.Length; i++)
        {
            if (int_0[i] == num)
            {
                return i;
            }
        }
        return smethod_30(A_0);
    }

    internal static Color smethod_19(OfficeColor A_0)
    {
        return smethod_29((int) smethod_21(A_0));
    }

    public static Class1006 smethod_2()
    {
        return new Class1006(2);
    }

    internal static OfficeColor smethod_20(Color A_0)
    {
        return smethod_26(smethod_22(A_0));
    }

    internal static uint smethod_21(OfficeColor A_0)
    {
        if (A_0 < uint_0.Length)
        {
            return uint_0[(int) A_0];
        }
        return 0xff000000;
    }

    public static uint smethod_22(Color A_0)
    {
        return smethod_23(A_0, false);
    }

    public static uint smethod_23(Color A_0, bool A_1)
    {
        uint num = 0;
        num = (uint) (0 | A_0.R);
        num |= (uint) (A_0.G << 8);
        num |= (uint) (A_0.B << 0x10);
        if (A_1)
        {
            return num;
        }
        return (num | ((uint) (~A_0.A << 0x18)));
    }

    public static uint smethod_24(int A_0)
    {
        if (A_0 < uint_0.Length)
        {
            return uint_0[A_0];
        }
        return 0xff000000;
    }

    public static int smethod_25(uint A_0)
    {
        if (A_0 == 0xff000000)
        {
            return 0;
        }
        double positiveInfinity = double.PositiveInfinity;
        int num4 = 1;
        for (int i = 0; i < uint_0.Length; i++)
        {
            double num2 = smethod_31(uint_0[i], A_0);
            if (num2 <= positiveInfinity)
            {
                num4 = i;
                positiveInfinity = num2;
            }
        }
        return num4;
    }

    internal static OfficeColor smethod_26(uint A_0)
    {
        if (A_0 == 0xff000000)
        {
            return OfficeColor.Auto;
        }
        double positiveInfinity = double.PositiveInfinity;
        OfficeColor black = OfficeColor.Black;
        for (int i = 0; i < uint_0.Length; i++)
        {
            double num2 = smethod_31(uint_0[i], A_0);
            if (num2 <= positiveInfinity)
            {
                black = (OfficeColor) i;
                positiveInfinity = num2;
            }
        }
        return black;
    }

    public static Color smethod_27(uint A_0)
    {
        if (A_0 != 0xff000000)
        {
            byte red = (byte) (A_0 & 0xff);
            byte green = (byte) ((A_0 & 0xff00) >> 8);
            byte blue = (byte) ((A_0 & 0xff0000) >> 0x10);
            byte alpha = (byte) ~((A_0 & -16777216) >> 0x18);
            return Color.FromArgb(alpha, red, green, blue);
        }
        return Color.Empty;
    }

    public static int smethod_28(Color A_0)
    {
        return smethod_25(smethod_22(A_0));
    }

    public static Color smethod_29(int A_0)
    {
        return smethod_27(smethod_24(A_0));
    }

    public static Class1006 smethod_3()
    {
        return new Class1006(3);
    }

    private static int smethod_30(Color A_0)
    {
        int num = 0x7fffffff;
        int num2 = 0;
        for (int i = 0; i < int_0.Length; i++)
        {
            Color color = Color.FromArgb(int_0[i]);
            int num4 = Math.Abs((int) (color.R - A_0.R));
            int num5 = Math.Abs((int) (color.B - A_0.B));
            int num6 = Math.Abs((int) (color.G - A_0.G));
            int num7 = (num4 + num5) + num6;
            if (num7 < num)
            {
                num2 = i;
                num = num7;
            }
        }
        return num2;
    }

    private static double smethod_31(uint A_0, uint A_1)
    {
        byte num = (byte) (A_0 & 0xff);
        byte num2 = (byte) ((A_0 & 0xff00) >> 8);
        byte num3 = (byte) ((A_0 & 0xff0000) >> 0x10);
        byte num4 = (byte) (A_1 & 0xff);
        byte num5 = (byte) ((A_1 & 0xff00) >> 8);
        byte num6 = (byte) ((A_1 & 0xff0000) >> 0x10);
        return (double) ((Math.Abs((int) (num - num4)) + Math.Abs((int) (num2 - num5))) + Math.Abs((int) (num3 - num6)));
    }

    public static Class1006 smethod_4()
    {
        return new Class1006(4);
    }

    public static Class1006 smethod_5()
    {
        return new Class1006(5);
    }

    public static Class1006 smethod_6()
    {
        return new Class1006(6);
    }

    public static Class1006 smethod_7()
    {
        return new Class1006(7);
    }

    public static Class1006 smethod_8()
    {
        return new Class1006(8);
    }

    public static Class1006 smethod_9()
    {
        return new Class1006(9);
    }
}

