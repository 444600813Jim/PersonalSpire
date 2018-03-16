using System;
using System.Collections;
using System.Drawing;

internal class Class671
{
    private ArrayList arrayList_0;
    private bool bool_0;
    private Class447 class447_0;
    private Class447 class447_1;
    private Class448[] class448_0;
    private Class448[] class448_1;
    private Class722 class722_0;
    private Class950 class950_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private PointF pointF_0;
    private PointF pointF_1;

    private void method_0()
    {
        this.method_1();
        this.method_2();
        this.method_11();
    }

    private void method_1()
    {
        this.class722_0.method_0(true);
        this.int_0 = this.class722_0.method_25();
        this.int_1 = this.class722_0.method_26();
        this.int_2 = this.class722_0.method_19();
        this.class448_0 = this.method_9(this.int_0, this.int_1);
        this.class448_1 = this.method_9(this.int_1, this.int_0);
        this.bool_0 = true;
        this.class950_0 = null;
        this.arrayList_0 = new ArrayList();
        this.pointF_0 = this.class722_0.method_20(this.class722_0.method_23()).method_2();
        this.pointF_1 = this.class722_0.method_20(this.class722_0.method_24()).method_2();
        this.class447_0 = Class447.smethod_4(this.pointF_0, false);
        this.class447_1 = Class447.smethod_4(this.pointF_1, false);
    }

    private int method_10(int A_0, int A_1)
    {
        int num = 0;
        for (int i = this.method_3(A_0 + 1); i != A_1; i = this.method_3(i + 1))
        {
            num++;
        }
        return num;
    }

    private void method_11()
    {
        ArrayList list = new ArrayList();
        foreach (Class950 class2 in this.arrayList_0)
        {
            smethod_3(class2, list);
            this.method_12(class2);
            list.Add(class2);
        }
    }

    private void method_12(Class950 A_0)
    {
        int num = this.method_3(A_0.method_8() + 1);
        for (int i = 0; i < A_0.method_10(); i++)
        {
            this.class722_0.method_7(num);
        }
        if (spr⃸.ᜀ(A_0.method_0().Y, A_0.method_6().Y))
        {
            A_0.method_11(A_0.method_10() + 1);
        }
        else
        {
            bool flag;
            PointF tf3 = (flag = (A_0.method_0().X < A_0.method_6().X) ? A_0.method_12() : !A_0.method_12()) ? A_0.method_0() : A_0.method_6();
            Class447 class2 = Class447.smethod_4(tf3, true);
            Class447 class3 = new Class447(flag ? A_0.method_4() : A_0.method_2(), flag ? A_0.method_6() : A_0.method_0());
            PointF[] tfArray2 = new PointF[] { PointF.Empty };
            Class447.smethod_1(class2, class3, tfArray2);
            this.class722_0.method_6(num, new Class886(tfArray2[0]));
        }
    }

    private void method_2()
    {
        for (int i = 0; i < (this.int_2 - 1); i++)
        {
            int num2 = this.method_3(this.int_0 + i);
            int num3 = this.method_3(num2 + 1);
            PointF tf2 = this.class722_0.method_20(num2).method_2();
            PointF tf = this.class722_0.method_20(num3).method_2();
            if (num3 == this.int_1)
            {
                this.method_4(tf);
            }
            else
            {
                this.method_5(tf, tf2, num2, num3, i == (this.int_2 - 2));
            }
        }
    }

    private int method_3(int A_0)
    {
        return this.class722_0.method_10(A_0);
    }

    private void method_4(PointF A_0)
    {
        if (this.class950_0 != null)
        {
            this.class950_0.method_7(A_0);
            this.arrayList_0.Add(this.class950_0);
        }
        this.class950_0 = null;
        this.bool_0 = false;
    }

    private void method_5(PointF A_0, PointF A_1, int A_2, int A_3, bool A_4)
    {
        if (smethod_1(A_0, this.bool_0 ? (this.method_10(this.int_0, A_3) + 1) : (this.method_10(this.int_1, A_3) + 1), this.bool_0 ? this.class448_0 : this.class448_1, this.bool_0 ? this.class447_0 : this.class447_1))
        {
            if (this.class950_0 == null)
            {
                this.method_6(A_0, A_1, A_3, A_2, A_4);
            }
            else
            {
                this.method_7(A_0, A_3, A_4);
            }
        }
        else if (this.class950_0 != null)
        {
            this.method_8(A_0);
        }
    }

    private void method_6(PointF A_0, PointF A_1, int A_2, int A_3, bool A_4)
    {
        this.class950_0 = new Class950();
        this.class950_0.method_13(this.bool_0);
        this.class950_0.method_9(A_3);
        this.class950_0.method_1(A_1);
        this.class950_0.method_3(A_0);
        this.class950_0.method_5(A_0);
        this.class950_0.method_11(this.class950_0.method_10() + 1);
        if (A_4)
        {
            this.method_8(this.class722_0.method_20(this.method_3(A_2 + 1)).method_2());
        }
    }

    private void method_7(PointF A_0, int A_1, bool A_2)
    {
        this.class950_0.method_5(A_0);
        this.class950_0.method_11(this.class950_0.method_10() + 1);
        if (A_2)
        {
            this.method_8(this.class722_0.method_20(this.method_3(A_1 + 1)).method_2());
        }
    }

    private void method_8(PointF A_0)
    {
        this.class950_0.method_7(A_0);
        this.arrayList_0.Add(this.class950_0);
        this.class950_0 = null;
    }

    private Class448[] method_9(int A_0, int A_1)
    {
        int num = this.method_10(A_0, A_1) + 1;
        Class448[] classArray = new Class448[num];
        for (int i = 0; i < num; i++)
        {
            int num3 = this.method_3(A_0 + i);
            int num4 = this.method_3((A_0 + i) + 1);
            classArray[i] = new Class448(this.class722_0.method_20(num3).method_2(), this.class722_0.method_20(num4).method_2());
        }
        return classArray;
    }

    internal static void smethod_0(Class722 A_0)
    {
        if ((A_0 != null) && (A_0.method_19() >= 4))
        {
            new Class671 { class722_0 = A_0 }.method_0();
        }
    }

    private static bool smethod_1(PointF A_0, int A_1, Class448[] A_2, Class447 A_3)
    {
        Class447 class2 = Class447.smethod_4(A_0, true);
        PointF[] tfArray = new PointF[] { PointF.Empty };
        if (!Class447.smethod_2(A_3, class2, tfArray, true))
        {
            return false;
        }
        return smethod_2(new Class448(A_0, tfArray[0]), A_1, A_2);
    }

    private static bool smethod_2(Class448 A_0, int A_1, Class448[] A_2)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        for (int i = 0; i < A_2.Length; i++)
        {
            if (((i != (A_1 - 1)) && (i != A_1)) && Class448.smethod_5(A_2[i], A_0, tfArray2, true))
            {
                return true;
            }
        }
        return false;
    }

    private static void smethod_3(Class950 A_0, ArrayList A_1)
    {
        foreach (Class950 class2 in A_1)
        {
            if (class2.method_8() < A_0.method_8())
            {
                A_0.method_9(A_0.method_8() - (class2.method_10() - 1));
            }
        }
    }
}

