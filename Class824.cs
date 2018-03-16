using Spire.Doc.Fields.Shape.Ps.Wrapping;
using System;
using System.Collections;
using System.Drawing;

internal class Class824
{
    internal static Class622 smethod_0(Class722 A_0, Class722 A_1)
    {
        if ((A_0 == null) && (A_1 == null))
        {
            return new Class622();
        }
        if ((A_1 == null) || (A_1.method_19() == 0))
        {
            return new Class622(A_0);
        }
        if ((A_0 != null) && (A_0.method_19() != 0))
        {
            return smethod_2(A_0, A_1);
        }
        return new Class622(A_1);
    }

    internal static Class722 smethod_1(Class622 A_0)
    {
        if (A_0.method_8() == 0)
        {
            return new Class722();
        }
        if (A_0.method_8() == 1)
        {
            return A_0.method_9(0);
        }
        return smethod_14(A_0);
    }

    private static bool smethod_10(Class722 A_0, Class722 A_1, int[] A_2)
    {
        bool flag = false;
        int num = A_0.method_23();
        int num2 = A_1.method_23();
        PointF tf = A_0.method_20(num).method_2();
        PointF tf2 = A_1.method_20(num2).method_2();
        flag = (tf.X < tf2.X) || ((tf.X == tf2.X) && (tf.Y < tf2.Y));
        A_2[0] = flag ? num : num2;
        return flag;
    }

    private static Class622 smethod_11(Class722 A_0, Class722 A_1, bool A_2)
    {
        Class886 class3;
        if (!A_2)
        {
            return smethod_12(A_0, A_1);
        }
        int[] numArray = new int[1];
        bool flag = smethod_10(A_0, A_1, numArray);
        int num2 = numArray[0];
        Class722 class5 = flag ? A_0 : A_1;
        Class722 class4 = new Class722();
        int num = num2;
        int num3 = A_0.method_19() + A_1.method_19();
        Class722 class2 = class5;
    Label_00A3:
        class3 = class2.method_20(num);
        class4.method_5(class3);
        if (num != (class2.method_19() - 1))
        {
            num++;
        }
        else
        {
            num = 0;
        }
        if (((num != num2) || (class2 != class5)) && (class4.method_19() <= num3))
        {
            if (class3.method_0() == VertexType.Simple)
            {
                goto Label_00A3;
            }
            class2 = (class2 == A_0) ? A_1 : A_0;
            num = class2.method_8(class3);
            if (num != -1)
            {
                if (num == (class2.method_19() - 1))
                {
                    num = 0;
                }
                else
                {
                    num++;
                }
                if ((num != num2) || (class2 != class5))
                {
                    goto Label_00A3;
                }
            }
        }
        class4.method_16();
        return new Class622(class4);
    }

    private static Class622 smethod_12(Class722 A_0, Class722 A_1)
    {
        int num = smethod_13(A_0, A_1);
        if (num == A_1.method_19())
        {
            return new Class622(A_0);
        }
        if (num != 0)
        {
            return new Class622(A_0);
        }
        num = smethod_13(A_1, A_0);
        if (num == A_0.method_19())
        {
            return new Class622(A_1);
        }
        if (num != 0)
        {
            return new Class622(A_1);
        }
        return new Class622(A_0, A_1);
    }

    private static int smethod_13(Class722 A_0, Class722 A_1)
    {
        int num = 0;
        for (int i = 0; i < A_1.method_19(); i++)
        {
            if (A_0.method_15(A_1.method_20(i).method_2()))
            {
                num++;
            }
        }
        return num;
    }

    private static Class722 smethod_14(Class622 A_0)
    {
        A_0.method_3(true);
        ArrayList list = new ArrayList(A_0.method_5());
        for (int i = list.Count - 1; i > 0; i--)
        {
            smethod_15(list, i);
        }
        return (Class722) list[0];
    }

    private static void smethod_15(ArrayList A_0, int A_1)
    {
        Class444 class2 = smethod_17(A_0, A_1);
        Class722 class3 = (Class722) A_0[class2.method_4()];
        Class722 class4 = (Class722) A_0[class2.method_5()];
        smethod_16(class3, class4, class2);
        A_0.RemoveAt(class2.method_4());
        A_0.RemoveAt(class2.method_5());
        A_0.Insert(0, class3);
    }

    private static void smethod_16(Class722 A_0, Class722 A_1, Class444 A_2)
    {
        bool flag;
        int num = A_2.method_2();
        int num2 = A_2.method_3();
        int num3 = smethod_18(A_0, num, false);
        int num4 = smethod_18(A_0, num, true);
        int num5 = smethod_18(A_1, num2, false);
        int num6 = smethod_18(A_1, num2, true);
        Class448 class2 = smethod_19(A_0, num, num4);
        Class448 class3 = smethod_19(A_1, num2, num5);
        PointF tf = smethod_20(class2);
        PointF tf2 = smethod_20(class3);
        if (flag = Class448.smethod_8(new Class448(A_0.method_20(num).method_2(), A_1.method_20(num2).method_2()), new Class448(tf, tf2)))
        {
            class2 = smethod_19(A_0, num, num3);
            class3 = smethod_19(A_1, num2, num6);
            tf = smethod_20(class2);
            tf2 = smethod_20(class3);
        }
        if (tf != PointF.Empty)
        {
            A_0.method_6(flag ? num : num4, new Class886(tf));
        }
        if (tf2 != PointF.Empty)
        {
            A_1.method_6(flag ? num6 : num2, new Class886(tf2));
        }
        num4 = smethod_18(A_0, num, true);
        num6 = smethod_18(A_1, num2, true);
        A_0.method_3(num4, A_1.method_9(num6));
    }

    private static Class444 smethod_17(ArrayList A_0, int A_1)
    {
        Class444 class2 = null;
        for (int i = 0; i < A_0.Count; i++)
        {
            if (A_1 != i)
            {
                Class444 class3 = new Class444((Class722) A_0[A_1], (Class722) A_0[i], A_1, i);
                if ((class2 == null) || (class3.method_1() < class2.method_1()))
                {
                    class2 = class3;
                }
            }
        }
        return class2;
    }

    private static int smethod_18(Class722 A_0, int A_1, bool A_2)
    {
        if (!A_2)
        {
            if (A_1 != 0)
            {
                return (A_1 - 1);
            }
            return (A_0.method_19() - 1);
        }
        if (A_1 != (A_0.method_19() - 1))
        {
            return (A_1 + 1);
        }
        return 0;
    }

    private static Class448 smethod_19(Class722 A_0, int A_1, int A_2)
    {
        return new Class448(A_0.method_20(A_1).method_2(), A_0.method_20(A_2).method_2());
    }

    private static Class622 smethod_2(Class722 A_0, Class722 A_1)
    {
        A_0.method_0(true);
        A_1.method_0(true);
        bool flag = smethod_3(A_0, A_1);
        return smethod_11(A_0, A_1, flag);
    }

    private static PointF smethod_20(Class448 A_0)
    {
        return A_0.method_18(0.002f);
    }

    private static bool smethod_3(Class722 A_0, Class722 A_1)
    {
        if ((A_0.method_19() < 3) || (A_1.method_19() < 3))
        {
            return false;
        }
        Class887 class2 = new Class887(A_0, A_1);
        for (int i = 0; i < A_0.method_19(); i++)
        {
            class2.method_3(A_0.method_20(i).method_2());
            Class448 class3 = smethod_7(A_0, i, class2.method_2());
            for (int j = 0; j < A_1.method_19(); j++)
            {
                smethod_4(class2, class3, i, j);
            }
        }
        if (class2.method_8())
        {
            smethod_9(class2, true);
            smethod_9(class2, false);
        }
        return class2.method_8();
    }

    private static void smethod_4(Class887 A_0, Class448 A_1, int A_2, int A_3)
    {
        PointF[] tfArray = new PointF[1];
        A_0.method_5(A_0.method_1().method_20(A_3).method_2());
        Class448 class2 = smethod_7(A_0.method_1(), A_3, A_0.method_4());
        if (!smethod_5(A_1, class2, A_0, A_2, A_3))
        {
            bool flag = Class448.smethod_5(A_1, class2, tfArray, true);
            A_0.method_7(tfArray[0]);
            if ((flag && !A_0.method_6().Equals(class2.method_16())) && !A_0.method_6().Equals(A_1.method_16()))
            {
                smethod_8(A_0.method_18(A_2), A_0.method_20(A_2), A_0.method_2(), tfArray[0]);
                smethod_8(A_0.method_19(A_3), A_0.method_21(A_3), A_0.method_4(), tfArray[0]);
                A_0.method_9(true);
            }
        }
    }

    private static bool smethod_5(Class448 A_0, Class448 A_1, Class887 A_2, int A_3, int A_4)
    {
        return (smethod_6(A_0, A_2, true, A_3) || smethod_6(A_1, A_2, false, A_4));
    }

    private static bool smethod_6(Class448 A_0, Class887 A_1, bool A_2, int A_3)
    {
        if (A_0.method_17(A_2 ? A_1.method_4() : A_1.method_2()))
        {
            (A_2 ? A_1.method_0().method_20(A_3) : A_1.method_1().method_20(A_3)).method_1(VertexType.Intersection);
            smethod_8(A_2 ? A_1.method_18(A_3) : A_1.method_19(A_3), A_2 ? A_1.method_20(A_3) : A_1.method_21(A_3), A_2 ? A_1.method_2() : A_1.method_4(), A_2 ? A_1.method_4() : A_1.method_2());
            A_1.method_9(true);
            return true;
        }
        return false;
    }

    private static Class448 smethod_7(Class722 A_0, int A_1, PointF A_2)
    {
        if (A_1 >= (A_0.method_19() - 1))
        {
            return new Class448(A_2, A_0.method_20(0).method_2());
        }
        return new Class448(A_2, A_0.method_20(A_1 + 1).method_2());
    }

    private static void smethod_8(ArrayList A_0, ArrayList A_1, PointF A_2, PointF A_3)
    {
        float num = spr⃸.ᜁ(A_2, A_3);
        bool flag = false;
        for (int i = 0; i < A_1.Count; i++)
        {
            if (num < ((float) A_1[i]))
            {
                A_0.Insert(i, new Class886(A_3, VertexType.Intersection));
                A_1.Insert(i, num);
                flag = true;
            }
            if (num == ((float) A_1[i]))
            {
                flag = true;
            }
            if (flag)
            {
                break;
            }
        }
        if (!flag)
        {
            A_0.Add(new Class886(A_3, VertexType.Intersection));
            A_1.Add(num);
        }
    }

    private static void smethod_9(Class887 A_0, bool A_1)
    {
        int num = 1;
        Class722 class2 = A_1 ? A_0.method_0() : A_0.method_1();
        int num3 = class2.method_19();
        for (int i = 0; i < num3; i++)
        {
            ArrayList list = A_1 ? A_0.method_18(i) : A_0.method_19(i);
            class2.method_3(i + num, list);
            num += list.Count;
        }
    }
}

