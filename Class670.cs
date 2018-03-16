using Spire.Doc.Fields.Shape.Ps.Wrapping;
using System;
using System.Collections;
using System.Drawing;

internal class Class670
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
            return smethod_3(A_0, A_1);
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
        return smethod_18(A_0);
    }

    private static Class448 smethod_10(Class722 A_0, int A_1)
    {
        return new Class448(A_0.method_20(A_1).method_2(), A_0.method_20(A_0.method_10(A_1 + 1)).method_2());
    }

    private static void smethod_11(ArrayList A_0, ArrayList A_1, PointF A_2, PointF A_3)
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

    private static void smethod_12(Class887 A_0, bool A_1)
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

    private static bool smethod_13(Class722 A_0, Class722 A_1, int[] A_2)
    {
        bool flag;
        int num = A_0.method_23();
        int num2 = A_1.method_23();
        if (A_0.method_17(VertexType.Intersection))
        {
            flag = false;
        }
        else if (A_1.method_17(VertexType.Intersection))
        {
            flag = true;
        }
        else
        {
            PointF tf = A_0.method_20(num).method_2();
            PointF tf2 = A_1.method_20(num2).method_2();
            flag = (tf.X < tf2.X) || ((tf.X == tf2.X) && (tf.Y < tf2.Y));
        }
        A_2[0] = flag ? num : num2;
        return flag;
    }

    private static Class622 smethod_14(Class722 A_0, Class722 A_1, bool A_2)
    {
        if (!A_2)
        {
            return smethod_16(A_0, A_1);
        }
        int[] numArray = new int[1];
        bool flag = smethod_13(A_0, A_1, numArray);
        int num = numArray[0];
        Class722 class2 = smethod_15(A_0, A_1, num, flag, false);
        A_0.method_16();
        A_1.method_16();
        return new Class622(class2);
    }

    private static Class722 smethod_15(Class722 A_0, Class722 A_1, int A_2, bool A_3, bool A_4)
    {
        Class886 class3;
        Class722 class5 = A_3 ? A_0 : A_1;
        Class722 class2 = new Class722();
        int num2 = A_2;
        int num = A_0.method_19() + A_1.method_19();
        Class722 class4 = class5;
    Label_011D:
        class3 = class4.method_20(num2);
        if ((class2.method_19() == 0) || (!class2.method_20(class2.method_19() - 1).method_2().Equals(class3.method_2()) && !class2.method_20(0).method_2().Equals(class3.method_2())))
        {
            class2.method_5(class3);
        }
        if (num2 == (class4.method_19() - 1))
        {
            num2 = 0;
        }
        else
        {
            num2++;
        }
        if (A_4)
        {
            A_4 = false;
        }
        else
        {
            if (((num2 != A_2) || (class4 != class5)) && (class2.method_19() <= num))
            {
                if (class3.method_0() == VertexType.Simple)
                {
                    goto Label_011D;
                }
                class4 = (class4 == A_0) ? A_1 : A_0;
                num2 = class4.method_8(class3);
                if (((num2 != A_2) || (class4 != class5)) && (num2 != -1))
                {
                    if (num2 == (class4.method_19() - 1))
                    {
                        num2 = 0;
                    }
                    else
                    {
                        num2++;
                    }
                    if ((num2 != A_2) || (class4 != class5))
                    {
                        goto Label_011D;
                    }
                }
            }
            class2.method_16();
            return class2;
        }
        goto Label_011D;
    }

    private static Class622 smethod_16(Class722 A_0, Class722 A_1)
    {
        int num = smethod_17(A_0, A_1);
        if (num == A_1.method_19())
        {
            return new Class622(A_0);
        }
        if (num != 0)
        {
            return new Class622(A_0);
        }
        num = smethod_17(A_1, A_0);
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

    private static int smethod_17(Class722 A_0, Class722 A_1)
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

    private static Class722 smethod_18(Class622 A_0)
    {
        A_0.method_3(true);
        ArrayList list = new ArrayList(A_0.method_5());
        for (int i = list.Count - 1; i > 0; i--)
        {
            smethod_19(list, i);
        }
        return (Class722) list[0];
    }

    private static void smethod_19(ArrayList A_0, int A_1)
    {
        Class444 class2 = smethod_21(A_0, A_1);
        Class722 class3 = (Class722) A_0[class2.method_4()];
        Class722 class4 = (Class722) A_0[class2.method_5()];
        smethod_20(class3, class4, class2);
        A_0.RemoveAt(class2.method_4());
        A_0.RemoveAt(class2.method_5());
        A_0.Insert(0, class3);
    }

    internal static Class722 smethod_2(Class722 A_0, Class722 A_1)
    {
        if ((A_0 != null) || (A_1 != null))
        {
            if ((A_1 == null) || (A_1.method_19() == 0))
            {
                return new Class722();
            }
            if ((A_0 != null) && (A_0.method_19() != 0))
            {
                return smethod_25(A_0, A_1);
            }
        }
        return new Class722();
    }

    private static void smethod_20(Class722 A_0, Class722 A_1, Class444 A_2)
    {
        bool flag;
        int num = A_2.method_2();
        int num2 = A_2.method_3();
        int num3 = smethod_22(A_0, num, false);
        int num4 = smethod_22(A_0, num, true);
        int num5 = smethod_22(A_1, num2, false);
        int num6 = smethod_22(A_1, num2, true);
        Class448 class2 = smethod_23(A_0, num, num4);
        Class448 class3 = smethod_23(A_1, num2, num5);
        PointF tf = smethod_24(class2);
        PointF tf2 = smethod_24(class3);
        Class448 class4 = new Class448(A_0.method_20(num).method_2(), A_1.method_20(num2).method_2());
        Class448 class5 = new Class448(tf, tf2);
        if (flag = Class448.smethod_8(class4, class5))
        {
            class2 = smethod_23(A_0, num, num3);
            class3 = smethod_23(A_1, num2, num6);
            tf = smethod_24(class2);
            tf2 = smethod_24(class3);
        }
        if (tf != PointF.Empty)
        {
            A_0.method_6(flag ? num : num4, new Class886(tf));
        }
        if (tf2 != PointF.Empty)
        {
            A_1.method_6(flag ? num6 : num2, new Class886(tf2));
        }
        num4 = smethod_22(A_0, num, true);
        num6 = smethod_22(A_1, num2, true);
        A_0.method_3(num4, A_1.method_9(num6));
    }

    private static Class444 smethod_21(ArrayList A_0, int A_1)
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

    private static int smethod_22(Class722 A_0, int A_1, bool A_2)
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

    private static Class448 smethod_23(Class722 A_0, int A_1, int A_2)
    {
        return new Class448(A_0.method_20(A_1).method_2(), A_0.method_20(A_2).method_2());
    }

    private static PointF smethod_24(Class448 A_0)
    {
        return A_0.method_18(0.002f);
    }

    private static Class722 smethod_25(Class722 A_0, Class722 A_1)
    {
        A_0.method_0(true);
        A_1.method_0(true);
        Class722 class2 = A_0.method_18();
        Class722 class3 = A_1.method_18();
        bool flag = smethod_4(class2, class3);
        return smethod_26(class2, class3, flag, A_0, A_1);
    }

    private static Class722 smethod_26(Class722 A_0, Class722 A_1, bool A_2, Class722 A_3, Class722 A_4)
    {
        if (!A_2)
        {
            Class622 class2 = smethod_16(A_0, A_1);
            if (class2.method_8() != 1)
            {
                return new Class722();
            }
            if (class2.method_9(0) != A_0)
            {
                return A_3;
            }
            return A_4;
        }
        int[] numArray = new int[1];
        bool flag = smethod_27(A_0, A_1, numArray);
        if (numArray[0] == -1)
        {
            return new Class722();
        }
        Class722 class3 = smethod_15(A_0, A_1, numArray[0], flag, true);
        A_0.method_16();
        A_1.method_16();
        return class3;
    }

    private static bool smethod_27(Class722 A_0, Class722 A_1, int[] A_2)
    {
        int num = smethod_28(A_0, A_1);
        if (num != -1)
        {
            A_2[0] = num;
            return true;
        }
        A_2[0] = smethod_28(A_1, A_0);
        return false;
    }

    private static int smethod_28(Class722 A_0, Class722 A_1)
    {
        for (int i = 0; i < A_0.method_19(); i++)
        {
            if (A_0.method_20(i).method_0() == VertexType.Intersection)
            {
                Class886 class2 = A_0.method_20(A_0.method_10(i + 1));
                if ((class2.method_0() == VertexType.Intersection) || A_1.method_15(class2.method_2()))
                {
                    return i;
                }
            }
        }
        return -1;
    }

    private static Class622 smethod_3(Class722 A_0, Class722 A_1)
    {
        A_0.method_0(true);
        A_1.method_0(true);
        bool flag = smethod_4(A_0, A_1);
        return smethod_14(A_0, A_1, flag);
    }

    private static bool smethod_4(Class722 A_0, Class722 A_1)
    {
        if ((A_0.method_19() < 3) || (A_1.method_19() < 3))
        {
            return false;
        }
        Class887 class2 = new Class887(A_0, A_1);
        for (int i = 0; i < A_0.method_19(); i++)
        {
            class2.method_3(A_0.method_20(i).method_2());
            class2.method_11(i);
            class2.method_13(A_0.method_10(i + 1));
            Class448 class3 = smethod_10(A_0, i);
            for (int j = 0; j < A_1.method_19(); j++)
            {
                class2.method_15(j);
                smethod_5(class2, class3);
            }
        }
        if (class2.method_8())
        {
            smethod_12(class2, true);
            smethod_12(class2, false);
        }
        return class2.method_8();
    }

    private static void smethod_5(Class887 A_0, Class448 A_1)
    {
        A_0.method_5(A_0.method_1().method_20(A_0.method_14()).method_2());
        A_0.method_17(A_0.method_1().method_10(A_0.method_14() + 1));
        Class448 class2 = smethod_10(A_0.method_1(), A_0.method_14());
        if (!smethod_6(A_1, class2, A_0))
        {
            PointF[] tfArray = new PointF[1];
            bool flag = Class448.smethod_5(A_1, class2, tfArray, true);
            A_0.method_7(tfArray[0]);
            if ((flag && !spr⃸.ᜀ(A_0.method_6(), class2.method_16())) && !spr⃸.ᜀ(A_0.method_6(), A_1.method_16()))
            {
                smethod_11(A_0.method_18(A_0.method_10()), A_0.method_20(A_0.method_10()), A_0.method_2(), tfArray[0]);
                smethod_11(A_0.method_19(A_0.method_14()), A_0.method_21(A_0.method_14()), A_0.method_4(), tfArray[0]);
                A_0.method_9(true);
            }
        }
    }

    private static bool smethod_6(Class448 A_0, Class448 A_1, Class887 A_2)
    {
        bool flag = false;
        if (smethod_7(A_0, A_2, true))
        {
            flag = true;
        }
        if (smethod_7(A_1, A_2, false))
        {
            flag = true;
        }
        return flag;
    }

    private static bool smethod_7(Class448 A_0, Class887 A_1, bool A_2)
    {
        if (A_0.method_17(A_2 ? A_1.method_4() : A_1.method_2()))
        {
            smethod_8(A_0, A_1, A_2);
            return true;
        }
        return false;
    }

    private static void smethod_8(Class448 A_0, Class887 A_1, bool A_2)
    {
        A_1.method_9(true);
        Class886 class2 = A_2 ? A_1.method_1().method_20(A_1.method_14()) : A_1.method_0().method_20(A_1.method_10());
        class2.method_1(VertexType.Intersection);
        if (!smethod_9(A_0, A_1, A_2, true, class2) && !smethod_9(A_0, A_1, A_2, false, class2))
        {
            smethod_11(A_2 ? A_1.method_18(A_1.method_10()) : A_1.method_19(A_1.method_14()), A_2 ? A_1.method_20(A_1.method_10()) : A_1.method_21(A_1.method_14()), A_2 ? A_1.method_2() : A_1.method_4(), A_2 ? A_1.method_4() : A_1.method_2());
        }
    }

    private static bool smethod_9(Class448 A_0, Class887 A_1, bool A_2, bool A_3, Class886 A_4)
    {
        if (spr⃸.ᜀ(A_3 ? A_0.method_15() : A_0.method_16(), A_4.method_2()))
        {
            Class886 class2 = A_2 ? A_1.method_0().method_20(A_3 ? A_1.method_10() : A_1.method_12()) : A_1.method_1().method_20(A_3 ? A_1.method_14() : A_1.method_16());
            class2.method_1(VertexType.Intersection);
            class2.method_3(A_4.method_2());
            return true;
        }
        return false;
    }
}

