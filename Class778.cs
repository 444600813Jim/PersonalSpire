using System;
using System.Collections;
using System.Drawing;

internal class Class778
{
    internal static void smethod_0(spr៧ A_0, spr៧ A_1)
    {
        int count = A_1.ᜀ().Count;
        if (((A_0.ᜀ().Count > 1) && (count > 1)) && !spr⃸.ᜀ((PointF) A_1.ᜀ()[count - 1], (PointF) A_0.ᜀ()[0]))
        {
            Class447 class2 = new Class447((PointF) A_1.ᜀ()[count - 2], (PointF) A_1.ᜀ()[count - 1]);
            Class447 class3 = new Class447((PointF) A_0.ᜀ()[0], (PointF) A_0.ᜀ()[1]);
            PointF[] tfArray2 = new PointF[] { PointF.Empty };
            if (Class447.smethod_2(class2, class3, tfArray2, true))
            {
                A_1.ᜀ()[count - 1] = tfArray2[0];
                A_0.ᜀ()[0] = tfArray2[0];
            }
        }
    }

    internal static spr᣼[] smethod_1(spr៧ A_0, spr᣼[] A_1, bool A_2)
    {
        PointF tf;
        PointF tf2;
        if (A_0.ᜀ().Count < 2)
        {
            return A_1;
        }
        ArrayList list = new ArrayList();
        if (A_2)
        {
            tf = (PointF) A_0.ᜀ()[0];
            tf2 = (PointF) A_0.ᜀ()[1];
        }
        else
        {
            tf = (PointF) A_0.ᜀ()[A_0.ᜀ().Count - 2];
            tf2 = (PointF) A_0.ᜀ()[A_0.ᜀ().Count - 1];
        }
        PointF[] tfArray2 = new PointF[] { tf, tf2 };
        if (!smethod_4(A_0, A_1, A_2, tfArray2, list))
        {
            smethod_2(A_0, A_1, A_2, tfArray2);
        }
        return (spr᣼[]) list.ToArray(typeof(spr᣼));
    }

    private static spr᣼ smethod_10(spr᣼ A_0, spr᣼[] A_1, ArrayList A_2, bool A_3, Class318 A_4)
    {
        // This item is obfuscated and can not be translated.
        int index = !A_3 ? (A_1.Length - 1) : 0;
        while (!A_3)
        {
        Label_0012:
            if (index <= -1)
            {
                return A_0;
            }
            spr᣼ r᣼ = A_1[index];
            Class318 class2 = smethod_13(A_0, r᣼);
            if (class2.method_0())
            {
                A_0 = smethod_11(A_0, r᣼, A_2, A_3, class2);
                A_4.method_1(true);
                return A_0;
            }
            A_2.Add(r᣼);
            if (!A_3)
            {
                index--;
            }
            else
            {
                index++;
                continue;
            }
        }
        goto Label_0012;
    }

    private static spr᣼ smethod_11(spr᣼ A_0, spr᣼ A_1, ArrayList A_2, bool A_3, Class318 A_4)
    {
        float minValue = float.MinValue;
        int index = 0;
        for (int i = 0; i < A_4.method_4().Length; i++)
        {
            if ((A_3 && (A_4.method_4()[i] > minValue)) || (!A_3 && (A_4.method_4()[i] <= minValue)))
            {
                minValue = A_4.method_4()[i];
                index = i;
            }
        }
        float num4 = A_4.method_4()[index];
        float num5 = A_4.method_6()[index];
        spr᣼[] r᣼Array = smethod_22(A_0, num4);
        spr᣼[] r᣼Array2 = smethod_22(A_1, num5);
        if (!A_3)
        {
            A_0 = r᣼Array[0];
            A_1 = (r᣼Array2.Length > 1) ? r᣼Array2[1] : r᣼Array2[0];
        }
        else
        {
            A_0 = (r᣼Array.Length > 1) ? r᣼Array[1] : r᣼Array[0];
            A_1 = r᣼Array2[0];
        }
        A_2.Add(A_1);
        return A_0;
    }

    internal static void smethod_12(spr᣼[] A_0)
    {
        if (A_0.Length >= 2)
        {
            for (int i = 0; i < (A_0.Length - 1); i++)
            {
                Class318 class2 = smethod_13(A_0[i], A_0[i + 1]);
                if (class2.method_0())
                {
                    spr᣼[] r᣼Array = smethod_22(A_0[i], class2.method_4()[0]);
                    A_0[i] = r᣼Array[0];
                    r᣼Array = smethod_22(A_0[i + 1], class2.method_6()[0]);
                    A_0[i + 1] = (r᣼Array.Length > 1) ? r᣼Array[1] : r᣼Array[0];
                }
                A_0[i].ᜂ(A_0[i + 1].ᜁ());
            }
        }
    }

    private static Class318 smethod_13(spr᣼ A_0, spr᣼ A_1)
    {
        ArrayList list = new ArrayList();
        sprᳯ rᳯ = new sprᳯ();
        sprᳯ rᳯ2 = new sprᳯ();
        Class726 class2 = new Class726(A_0);
        Class726 class3 = new Class726(A_1);
        smethod_15(class2, class3, list, rᳯ);
        smethod_14(class2, class3, rᳯ, rᳯ2);
        if (rᳯ.ᜆ() == 0)
        {
            return Class318.smethod_0();
        }
        return new Class318(true, rᳯ.ᜆ(), rᳯ2.ᜌ(), rᳯ.ᜌ(), (PointF[]) list.ToArray(typeof(PointF)));
    }

    private static void smethod_14(Class726 A_0, Class726 A_1, sprᳯ A_2, sprᳯ A_3)
    {
        PointF tf = A_0.method_3();
        PointF tf2 = A_0.method_4();
        PointF tf3 = A_0.method_5();
        PointF tf4 = A_1.method_3();
        PointF tf5 = A_1.method_4();
        PointF tf6 = A_1.method_5();
        for (int i = 0; i < A_2.ᜆ(); i++)
        {
            float num4 = A_2.ᜃ(i);
            foreach (float num3 in new Class317((double) -tf.X, (double) -tf2.X, (double) (((-tf3.X + tf6.X) + (tf5.X * num4)) + ((tf4.X * num4) * num4))).method_0())
            {
                if ((num3 >= 0f) && (num3 <= 1f))
                {
                    goto Label_00B5;
                }
            }
            continue;
        Label_00B5:
            A_3.ᜄ(num3);
        }
    }

    private static void smethod_15(Class726 A_0, Class726 A_1, ArrayList A_2, sprᳯ A_3)
    {
        PointF tf = A_0.method_3();
        PointF tf2 = A_0.method_4();
        PointF tf3 = A_0.method_5();
        PointF tf4 = A_1.method_3();
        PointF tf5 = A_1.method_4();
        PointF tf6 = A_1.method_5();
        double num = (tf.X * tf2.Y) - (tf2.X * tf.Y);
        double num2 = (tf4.X * tf2.Y) - (tf2.X * tf4.Y);
        double num3 = (tf5.X * tf2.Y) - (tf2.X * tf5.Y);
        double num4 = (tf2.X * (tf3.Y - tf6.Y)) + (tf2.Y * (-tf3.X + tf6.X));
        double num5 = (tf4.X * tf.Y) - (tf.X * tf4.Y);
        double num6 = (tf5.X * tf.Y) - (tf.X * tf5.Y);
        double num7 = (tf.X * (tf3.Y - tf6.Y)) + (tf.Y * (-tf3.X + tf6.X));
        double[] numArray = new Class317(-num5 * num5, (-2.0 * num5) * num6, ((num * num2) - (num6 * num6)) - ((2.0 * num5) * num7), (num * num3) - ((2.0 * num6) * num7), (num * num4) - (num7 * num7)).method_0();
        smethod_16(A_0, A_1, numArray, A_2, A_3);
    }

    private static void smethod_16(Class726 A_0, Class726 A_1, double[] A_2, ArrayList A_3, sprᳯ A_4)
    {
        PointF tf = A_0.method_3();
        PointF tf2 = A_0.method_4();
        PointF tf3 = A_0.method_5();
        PointF tf4 = A_1.method_3();
        PointF tf5 = A_1.method_4();
        PointF tf6 = A_1.method_5();
        for (int i = 0; i < A_2.Length; i++)
        {
            double num3 = A_2[i];
            if ((num3 >= 0.0) && (num3 <= 1.0))
            {
                double[] numArray = new Class317((double) -tf.X, (double) -tf2.X, ((-tf3.X + tf6.X) + (num3 * tf5.X)) + ((num3 * num3) * tf4.X)).method_0();
                double[] numArray2 = new Class317((double) -tf.Y, (double) -tf2.Y, ((-tf3.Y + tf6.Y) + (num3 * tf5.Y)) + ((num3 * num3) * tf4.Y)).method_0();
                if ((numArray.Length > 0) && (numArray2.Length > 0))
                {
                    for (int j = 0; j < numArray.Length; j++)
                    {
                        if (smethod_17(A_1, numArray[j], numArray2, A_3, A_4, num3))
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

    private static bool smethod_17(Class726 A_0, double A_1, double[] A_2, ArrayList A_3, sprᳯ A_4, double A_5)
    {
        if ((0.0 > A_1) || (A_1 > 1.0))
        {
            return false;
        }
        PointF tf = A_0.method_3();
        PointF tf2 = A_0.method_4();
        PointF tf3 = A_0.method_5();
        for (int i = 0; i < A_2.Length; i++)
        {
            if (Math.Abs((double) (A_1 - A_2[i])) < 0.0001)
            {
                float x = ((float) (((tf.X * A_5) * A_5) + (tf2.X * A_5))) + tf3.X;
                float y = ((float) (((tf.Y * A_5) * A_5) + (tf2.Y * A_5))) + tf3.Y;
                A_3.Add(new PointF(x, y));
                A_4.ᜄ((float) A_5);
                return true;
            }
        }
        return false;
    }

    private static Class1122 smethod_18(PointF A_0, PointF A_1, spr᣼ A_2)
    {
        Class726 class2 = new Class726(A_2);
        bool flag = spr⃸.ᜀ(A_1.Y, A_0.Y);
        double[] numArray = smethod_19(A_0, A_1, class2, flag);
        return smethod_20(A_0, A_1, class2, numArray, flag);
    }

    private static double[] smethod_19(PointF A_0, PointF A_1, Class726 A_2, bool A_3)
    {
        if (A_3)
        {
            return new Class317((double) A_2.method_3().Y, (double) A_2.method_4().Y, (double) (A_2.method_5().Y - A_0.Y)).method_0();
        }
        float num = (A_1.X - A_0.X) / (A_1.Y - A_0.Y);
        return new Class317((double) ((num * A_2.method_3().Y) - A_2.method_3().X), (double) ((num * A_2.method_4().Y) - A_2.method_4().X), (double) ((((num * A_2.method_5().Y) - (num * A_0.Y)) + A_0.X) - A_2.method_5().X)).method_0();
    }

    private static void smethod_2(spr៧ A_0, spr᣼[] A_1, bool A_2, PointF[] A_3)
    {
        spr᣼ r᣼ = A_2 ? A_1[A_1.Length - 1] : A_1[0];
        Class447 class3 = new Class447(A_3[0], A_3[1]);
        Class447 class2 = A_2 ? new Class447(r᣼.ᜂ(), r᣼.ᜀ()) : new Class447(r᣼.ᜂ(), r᣼.ᜁ());
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        Class447.smethod_1(class3, class2, tfArray2);
        tfArray2[0] = smethod_3(A_1, A_2, A_3, tfArray2[0]);
        if (A_2)
        {
            A_0.ᜀ()[0] = tfArray2[0];
        }
        else
        {
            A_0.ᜀ()[A_0.ᜀ().Count - 1] = tfArray2[0];
        }
    }

    private static Class1122 smethod_20(PointF A_0, PointF A_1, Class726 A_2, double[] A_3, bool A_4)
    {
        int length = A_3.Length;
        if (length == 0)
        {
            return Class1122.smethod_0();
        }
        bool flag = false;
        bool flag2 = false;
        int num2 = 0;
        PointF[] tfArray = new PointF[] { PointF.Empty, PointF.Empty };
        float[] numArray = new float[2];
        for (int i = 0; i < length; i++)
        {
            float num3 = (float) A_3[i];
            if ((num3 >= 0f) && (num3 <= 1f))
            {
                num2++;
                numArray[num2 - 1] = num3;
                float num5 = smethod_21(num3, A_0, A_1, A_2, A_4);
                bool flag3 = (num5 > 0f) || (num5 < 1f);
                if (num2 == 1)
                {
                    flag = flag3;
                }
                else
                {
                    flag2 = flag3;
                }
                tfArray[num2 - 1] = A_2.method_0(num3);
            }
        }
        if (num2 == 0)
        {
            return Class1122.smethod_0();
        }
        return new Class1122(true, flag, flag2, num2, tfArray, numArray);
    }

    private static float smethod_21(float A_0, PointF A_1, PointF A_2, Class726 A_3, bool A_4)
    {
        float num = A_4 ? A_2.X : A_2.Y;
        float num2 = A_4 ? A_1.X : A_1.Y;
        PointF tf = A_3.method_0(A_0);
        return ((A_4 ? tf.X : (tf.Y - num2)) / (num - num2));
    }

    private static spr᣼[] smethod_22(spr᣼ A_0, float A_1)
    {
        if ((A_1 < 0f) || (A_1 > 1f))
        {
            return null;
        }
        if ((A_1 != 0f) && (A_1 != 1f))
        {
            Class447 class2 = new Class447(A_0.ᜁ(), A_0.ᜂ());
            Class447 class3 = new Class447(A_0.ᜂ(), A_0.ᜀ());
            float num = spr⃸.ᜁ(A_0.ᜁ(), A_0.ᜂ());
            float num2 = spr⃸.ᜁ(A_0.ᜂ(), A_0.ᜀ());
            PointF tf = smethod_24(class2, A_0, A_1, num, true);
            PointF tf2 = smethod_24(class3, A_0, A_1, num2, false);
            PointF tf3 = new Class726(A_0).method_0(A_1);
            spr᣼ r᣼ = smethod_23(A_0.ᜁ(), tf, tf3);
            spr᣼ r᣼2 = smethod_23(tf3, tf2, A_0.ᜀ());
            return new spr᣼[] { r᣼, r᣼2 };
        }
        return new spr᣼[] { A_0 };
    }

    private static spr᣼ smethod_23(PointF A_0, PointF A_1, PointF A_2)
    {
        spr᣼ r᣼ = new spr᣼();
        r᣼.ᜀ(A_0);
        r᣼.ᜁ(A_1);
        r᣼.ᜂ(A_2);
        return r᣼;
    }

    private static PointF smethod_24(Class447 A_0, spr᣼ A_1, float A_2, float A_3, bool A_4)
    {
        bool flag;
        if ((A_0.method_9() == 0f) && !A_0.method_13())
        {
            flag = A_4 ? (A_1.ᜂ().X > A_1.ᜁ().X) : (A_1.ᜀ().X > A_1.ᜂ().X);
        }
        else
        {
            flag = A_4 ? (A_1.ᜂ().Y > A_1.ᜁ().Y) : (A_1.ᜀ().Y > A_1.ᜂ().Y);
        }
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        float num = -1f;
        if (flag)
        {
            num = 1f;
        }
        A_0.method_7(A_4 ? A_1.ᜁ() : A_1.ᜂ(), (num * A_2) * A_3, tfArray2);
        return tfArray2[0];
    }

    internal static PointF smethod_3(spr᣼[] A_0, bool A_1, PointF[] A_2, PointF A_3)
    {
        float num = spr⃸.ᜀ(A_0);
        PointF tf = A_1 ? A_0[A_0.Length - 1].ᜀ() : A_0[0].ᜁ();
        float num2 = spr⃸.ᜁ(A_3, tf);
        float num3 = num;
        if (num2 <= num3)
        {
            return A_3;
        }
        Class447 class2 = new Class447(A_2[0], A_2[1]);
        if (A_3.X < (A_1 ? A_2[0].X : A_2[1].X))
        {
            num3 *= -1f;
        }
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        class2.method_7(A_1 ? A_2[0] : A_2[1], num3, tfArray2);
        return tfArray2[0];
    }

    private static bool smethod_4(spr៧ A_0, spr᣼[] A_1, bool A_2, PointF[] A_3, ArrayList A_4)
    {
        // This item is obfuscated and can not be translated.
        bool flag = false;
        int index = A_2 ? 0 : (A_1.Length - 1);
        while (A_2)
        {
        Label_0016:
            if (index >= A_1.Length)
            {
                return flag;
            }
            spr᣼ r᣼ = A_1[index];
            Class1122 class2 = smethod_18(A_3[0], A_3[1], r᣼);
            if (class2.method_0())
            {
                r᣼ = smethod_5(A_2, r᣼, class2, A_0);
                flag = true;
            }
            A_4.Add(r᣼);
            if (flag)
            {
                return flag;
            }
            if (A_2)
            {
                index++;
            }
            else
            {
                index--;
                continue;
            }
        }
        goto Label_0016;
    }

    private static spr᣼ smethod_5(bool A_0, spr᣼ A_1, Class1122 A_2, spr៧ A_3)
    {
        if (A_0)
        {
            A_3.ᜀ()[0] = A_2.method_8()[0];
        }
        else
        {
            A_3.ᜀ()[A_3.ᜀ().Count - 1] = A_2.method_8()[0];
        }
        spr᣼[] r᣼Array = smethod_22(A_1, A_2.method_10()[0]);
        if (A_0)
        {
            A_1 = r᣼Array[0];
            return A_1;
        }
        A_1 = (r᣼Array.Length > 1) ? r᣼Array[1] : r᣼Array[0];
        return A_1;
    }

    internal static Class446 smethod_6(spr᣼[] A_0, spr᣼[] A_1, bool A_2)
    {
        Class446 class2 = new Class446();
        class2.method_5(A_2);
        class2.method_7(!A_2);
        ArrayList list = new ArrayList();
        ArrayList list2 = new ArrayList();
        bool flag = smethod_9(A_0, A_1, list, list2, A_2);
        class2.method_1((spr᣼[]) list.ToArray(typeof(spr᣼)));
        class2.method_3((spr᣼[]) list2.ToArray(typeof(spr᣼)));
        if (!flag)
        {
            smethod_7(A_0, A_1, A_2, class2);
        }
        return class2;
    }

    private static void smethod_7(spr᣼[] A_0, spr᣼[] A_1, bool A_2, Class446 A_3)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        if (!spr⃸.ᜀ(spr⃸.ᜁ(A_2 ? A_0[0].ᜁ() : A_0[A_0.Length - 1].ᜀ(), !A_2 ? A_1[0].ᜁ() : A_1[A_1.Length - 1].ᜀ()), 0f))
        {
            Class447 class2 = smethod_8(A_0, A_2);
            Class447 class3 = smethod_8(A_1, !A_2);
            Class447.smethod_1(class2, class3, tfArray2);
        }
        if (tfArray2[0] != PointF.Empty)
        {
            A_3.method_11(true);
            A_3.method_9(tfArray2[0]);
        }
    }

    private static Class447 smethod_8(spr᣼[] A_0, bool A_1)
    {
        if (!A_1)
        {
            return new Class447(A_0[A_0.Length - 1].ᜀ(), A_0[A_0.Length - 1].ᜂ());
        }
        return new Class447(A_0[0].ᜂ(), A_0[0].ᜁ());
    }

    private static bool smethod_9(spr᣼[] A_0, spr᣼[] A_1, ArrayList A_2, ArrayList A_3, bool A_4)
    {
        // This item is obfuscated and can not be translated.
        bool flag = false;
        int index = A_4 ? (A_0.Length - 1) : 0;
        while (A_4)
        {
        Label_0015:
            if (index <= -1)
            {
                return flag;
            }
            spr᣼ r᣼ = A_0[index];
            A_3.Clear();
            Class318 class2 = Class318.smethod_0();
            r᣼ = smethod_10(r᣼, A_1, A_3, A_4, class2);
            flag = class2.method_0();
            A_2.Add(r᣼);
            if (flag)
            {
                return flag;
            }
            if (A_4)
            {
                index--;
            }
            else
            {
                index++;
                continue;
            }
        }
        goto Label_0015;
    }
}

