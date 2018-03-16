using System;
using System.Drawing;

internal class Class501
{
    private float float_0;
    private float float_1;
    private const int int_0 = -1;

    private Class622 method_0(byte[] A_0)
    {
        Class622 class2;
        using (spr⊗ r⊗ = new spr⊗(A_0))
        {
            class2 = smethod_1(r⊗.ᜏ(), r⊗.ᜃ(), r⊗.ᜍ());
            this.float_0 = r⊗.ᜃ();
            this.float_1 = r⊗.ᜍ();
        }
        return class2;
    }

    internal static Class622 smethod_0(byte[] A_0, RectangleF A_1)
    {
        if (spr≨.ᜂ(A_0))
        {
            return new Class622(new Class722(A_1));
        }
        Class501 class3 = new Class501();
        Class622 class2 = class3.method_0(A_0);
        if (class2.method_8() == 0)
        {
            return new Class622();
        }
        float num = class3.float_0;
        float num2 = class3.float_1;
        if ((A_1.Width != num) || (A_1.Height != num2))
        {
            if ((num == 0f) || (num2 == 0f))
            {
                return class2;
            }
            if (!(A_1 != RectangleF.Empty))
            {
                return class2;
            }
            spr➂ r➂ = new spr➂();
            r➂.ᜁ(A_1.Width / num, A_1.Height / num2);
            r➂.ᜀ(A_1.X, A_1.Y);
            for (int i = 0; i < class2.method_8(); i++)
            {
                class2.method_9(i).method_13(r➂);
            }
        }
        return class2;
    }

    private static Class622 smethod_1(spr⅔ A_0, int A_1, int A_2)
    {
        if (!A_0.ᜂ())
        {
            PointF[] tfArray = new PointF[] { new PointF(0f, 0f), new PointF((float) A_1, 0f), new PointF((float) A_1, (float) A_2), new PointF(0f, (float) A_2) };
            return new Class622(new Class722(tfArray));
        }
        int[] numArray2 = new int[A_2];
        int[] numArray = new int[A_2];
        smethod_3(A_0, A_1, A_2, numArray2, numArray);
        Class622 class3 = new Class622();
        Class722 class2 = new Class722();
        int num2 = A_2;
        bool flag = true;
        for (int i = A_2 - 1; i >= 0; i--)
        {
            if (numArray[i] != -1)
            {
                smethod_6(class2, new PointF((float) numArray[i], (float) i));
                if (!flag)
                {
                    num2 = i + 1;
                }
                flag = true;
                if (i == 0)
                {
                    smethod_2(class2, numArray2, i, num2);
                }
            }
            else if (flag)
            {
                flag = false;
                smethod_2(class2, numArray2, i, num2);
                class3.method_2(class2);
                class2 = new Class722();
            }
        }
        if (class2.method_19() > 0)
        {
            class3.method_2(class2);
        }
        return class3;
    }

    private static void smethod_2(Class722 A_0, int[] A_1, int A_2, int A_3)
    {
        for (int i = A_2; i < A_3; i++)
        {
            if (A_1[i] != -1)
            {
                smethod_6(A_0, new PointF((float) A_1[i], (float) i));
            }
        }
    }

    private static void smethod_3(spr⅔ A_0, int A_1, int A_2, int[] A_3, int[] A_4)
    {
        for (int i = 0; i < A_2; i++)
        {
            A_3[i] = smethod_4(i, A_1, A_0);
            if (A_3[i] != -1)
            {
                A_4[i] = smethod_5(i, A_1, A_0);
            }
            else
            {
                A_4[i] = -1;
            }
        }
    }

    private static int smethod_4(int A_0, int A_1, spr⅔ A_2)
    {
        for (int i = 0; i < A_1; i++)
        {
            if (A_2.ᜁ()[(A_0 * A_1) + i] != 0)
            {
                return i;
            }
        }
        return -1;
    }

    private static int smethod_5(int A_0, int A_1, spr⅔ A_2)
    {
        for (int i = A_1 - 1; i > -1; i--)
        {
            if (A_2.ᜁ()[(A_0 * A_1) + i] != 0)
            {
                return i;
            }
        }
        return -1;
    }

    private static void smethod_6(Class722 A_0, PointF A_1)
    {
        int num = A_0.method_19();
        if (num < 2)
        {
            A_0.method_4(A_1);
        }
        else
        {
            PointF tf = A_0.method_20(num - 2).method_2();
            PointF tf2 = A_0.method_20(num - 1).method_2();
            if ((tf.X == tf2.X) && (tf2.X == A_1.X))
            {
                A_0.method_21(num - 1, new Class886(A_1));
            }
            else
            {
                A_0.method_4(A_1);
            }
        }
    }
}

