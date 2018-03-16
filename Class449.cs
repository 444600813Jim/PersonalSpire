using System;
using System.Drawing;

internal class Class449
{
    internal static sprᲆ smethod_0(PointF A_0, PointF A_1, float A_2, sprⓚ A_3)
    {
        return smethod_1(A_0, A_1, new spr⚪(A_3, A_2));
    }

    internal static sprᲆ smethod_1(PointF A_0, PointF A_1, spr⚪ A_2)
    {
        sprᲆ rᲆ = sprᲆ.ᜁ(A_0, A_1);
        rᲆ.ᜀ(A_2);
        return rᲆ;
    }

    internal static sprᲆ smethod_2(PointF A_0, PointF A_1, float A_2, sprⓚ A_3, bool A_4)
    {
        sprᲆ rᲆ = new sprᲆ(new spr⚪(A_3));
        float num = smethod_8(A_0, A_1, A_4);
        rᲆ.ᜁ(smethod_4(A_0, num, A_2, A_4));
        smethod_7(rᲆ, A_0, num, A_2 + 1.5f, A_4);
        return rᲆ;
    }

    internal static sprᲆ smethod_3(PointF A_0, PointF A_1, float A_2, sprⓚ A_3, bool A_4)
    {
        PointF tf;
        PointF tf2;
        sprᲆ rᲆ = new sprᲆ(new spr⚪(A_3));
        float num = smethod_8(A_0, A_1, A_4);
        if (A_4)
        {
            tf = new PointF(A_0.X, A_0.Y - (A_2 * 0.25f));
            tf2 = new PointF(A_0.X, A_0.Y + (A_2 * 0.25f));
        }
        else
        {
            tf = new PointF(A_0.X - (A_2 * 0.25f), A_0.Y);
            tf2 = new PointF(A_0.X + (A_2 * 0.25f), A_0.Y);
        }
        rᲆ.ᜁ(smethod_4(tf, num, A_2 * 0.5f, A_4));
        rᲆ.ᜁ(smethod_4(tf2, num, A_2 * 0.5f, A_4));
        smethod_7(rᲆ, A_0, num, A_2 + 1.5f, A_4);
        return rᲆ;
    }

    private static sprᧂ smethod_4(PointF A_0, float A_1, float A_2, bool A_3)
    {
        float num = A_2;
        sprᧂ rᧂ = new sprᧂ();
        int num2 = ((int) (A_1 / num)) + 2;
        float[] numArray = new float[num2 * 2];
        numArray[0] = A_0.X;
        numArray[1] = A_0.Y;
        if (A_3)
        {
            for (int i = 0; i < (num2 - 1); i++)
            {
                numArray[(i * 2) + 2] = (A_0.X + (i * num)) + (num / 2f);
                if (sprḆ.ᜀ((long) i))
                {
                    numArray[(i * 2) + 3] = A_0.Y + (num / 2f);
                }
                else
                {
                    numArray[(i * 2) + 3] = A_0.Y - (num / 2f);
                }
            }
        }
        else
        {
            for (int j = 0; j < (num2 - 1); j++)
            {
                if (sprḆ.ᜀ((long) j))
                {
                    numArray[(j * 2) + 2] = A_0.X + (num / 2f);
                }
                else
                {
                    numArray[(j * 2) + 2] = A_0.X - (num / 2f);
                }
                numArray[(j * 2) + 3] = (A_0.Y + (j * num)) + (num / 2f);
            }
        }
        spr៧ spr = new spr៧(numArray);
        rᧂ.ᜁ(spr);
        return rᧂ;
    }

    internal static sprᲆ smethod_5(PointF A_0, PointF A_1, float A_2, sprⓚ A_3, bool A_4)
    {
        PointF tf;
        sprᲆ rᲆ = new sprᲆ(new spr⚪(A_3));
        float num = A_2 + 3f;
        if (A_4)
        {
            tf = new PointF(A_0.X - num, A_0.Y + (num / 2f));
        }
        else
        {
            tf = new PointF(A_0.X + (num / 2f), A_0.Y - num);
        }
        sprᧂ rᧂ = new sprᧂ();
        rᲆ.ᜁ(rᧂ);
        float num6 = smethod_8(A_0, A_1, A_4);
        float num7 = num6 + (num * 2f);
        int num8 = ((int) (num7 * 2f)) + 1;
        float[] numArray = new float[num8 * 2];
        numArray[0] = tf.X;
        numArray[1] = tf.Y;
        int num3 = 0;
        if (A_4)
        {
            float x = tf.X;
            float num10 = x + num;
            for (int i = 0; i < (num8 - 1); i++)
            {
                if ((i & 2) == 2)
                {
                    if ((i & 1) == 1)
                    {
                        num10 += smethod_6(ref num3);
                        x = num10 - num;
                    }
                    numArray[(i * 2) + 2] = num10;
                    numArray[(i * 2) + 3] = A_0.Y - (num / 2f);
                }
                else
                {
                    if ((i & 1) == 1)
                    {
                        x += smethod_6(ref num3);
                        num10 = x + num;
                    }
                    numArray[(i * 2) + 2] = x;
                    numArray[(i * 2) + 3] = A_0.Y + (num / 2f);
                }
            }
        }
        else
        {
            float y = tf.Y;
            float num2 = y + num;
            for (int j = 0; j < (num8 - 1); j++)
            {
                if ((j & 2) == 2)
                {
                    if ((j & 1) == 1)
                    {
                        num2 += smethod_6(ref num3);
                        y = num2 - num;
                    }
                    numArray[(j * 2) + 2] = A_0.X - (num / 2f);
                    numArray[(j * 2) + 3] = num2;
                }
                else
                {
                    if ((j & 1) == 1)
                    {
                        y += smethod_6(ref num3);
                        num2 = y + num;
                    }
                    numArray[(j * 2) + 2] = A_0.X + (num / 2f);
                    numArray[(j * 2) + 3] = y;
                }
            }
        }
        spr៧ spr = new spr៧(numArray);
        rᧂ.ᜁ(spr);
        smethod_7(rᲆ, A_0, num6, A_2, A_4);
        return rᲆ;
    }

    private static float smethod_6(ref int A_0)
    {
        A_0++;
        if ((A_0 % 5) == 0)
        {
            return 2.25f;
        }
        if ((A_0 % 6) == 0)
        {
            A_0 = 0;
            return 2.25f;
        }
        return 0.75f;
    }

    private static void smethod_7(sprᲆ A_0, PointF A_1, float A_2, float A_3, bool A_4)
    {
        RectangleF ef;
        if (A_4)
        {
            ef = new RectangleF(A_1.X, A_1.Y - (A_3 / 2f), A_2, A_3);
        }
        else
        {
            ef = new RectangleF(A_1.X - (A_3 / 2f), A_1.Y, A_3, A_2);
        }
        A_0.ᜀ(sprᲆ.ᜂ(ef));
    }

    private static float smethod_8(PointF A_0, PointF A_1, bool A_2)
    {
        if (A_2)
        {
            return (A_1.X - A_0.X);
        }
        return (A_1.Y - A_0.Y);
    }
}

