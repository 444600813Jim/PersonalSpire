using Spire.Doc.Documents.Markup;
using System;
using System.Collections;
using System.IO;

internal class Class349
{
    internal static bool bool_0;
    private readonly Class149 class149_0;
    private readonly Class150 class150_0;
    private readonly Class264 class264_0;
    private readonly Class701 class701_0;
    private readonly Hashtable hashtable_0;

    internal Class349()
    {
        this.class149_0 = new Class149();
        this.class150_0 = new Class150();
        this.hashtable_0 = new Hashtable();
        this.class264_0 = new Class264();
        this.class701_0 = new Class701();
    }

    internal Class349(Class703 A_0, BinaryReader A_1)
    {
        this.class149_0 = new Class149();
        this.class150_0 = new Class150();
        this.hashtable_0 = new Hashtable();
        this.class264_0 = new Class264();
        this.class701_0 = new Class701();
        if (A_0.class868_0.class1111_1.int_1 != 0)
        {
            this.class264_0.method_0(A_1, A_0.class868_0.class1111_1);
            this.class701_0.method_0(A_1, A_0.class868_0.class1111_0);
            this.class149_0.method_23(A_1, A_0.class868_0.class1111_2);
            this.class150_0.method_23(A_1, A_0.class868_0.class1111_3);
            if (bool_0)
            {
                this.method_7();
            }
        }
    }

    internal void method_0(int A_0, Class9 A_1)
    {
        Class436 class2 = new Class436();
        int num = this.class149_0.method_6(A_0, class2);
        this.hashtable_0.Add(A_1, num);
        this.method_6(A_1.method_26(), A_1.method_22(), A_1.method_29(), A_1.method_24(), A_1.method_28());
    }

    internal void method_1(int A_0, Class9 A_1)
    {
        int num = (int) this.hashtable_0[A_1];
        Class435 class2 = new Class435();
        class2.method_1(num);
        int num2 = this.class150_0.method_6(A_0, class2);
        ((Class436) this.class149_0.method_18(num)).method_1(num2);
    }

    internal Class150 method_10()
    {
        return this.class150_0;
    }

    internal Class701 method_11()
    {
        return this.class701_0;
    }

    internal Class264 method_12()
    {
        return this.class264_0;
    }

    internal void method_2(Class703 A_0, BinaryWriter A_1)
    {
        if (this.method_8() != 0)
        {
            A_0.class868_0.class1111_1 = this.class264_0.method_1(A_1);
            A_0.class868_0.class1111_0 = this.class701_0.method_1(A_1);
            A_0.class868_0.class1111_2.int_0 = (int) A_1.BaseStream.Position;
            A_0.class868_0.class1111_2.int_1 = this.class149_0.vmethod_1(A_1);
            A_0.class868_0.class1111_3.int_0 = (int) A_1.BaseStream.Position;
            A_0.class868_0.class1111_3.int_1 = this.class150_0.vmethod_1(A_1);
        }
    }

    internal void method_3(Class349 A_0, int A_1)
    {
        if (A_0.method_8() != 0)
        {
            this.class149_0.method_26(A_0.class149_0, A_1);
            this.class150_0.method_26(A_0.class150_0, A_1);
            for (int i = 0; i < A_0.method_8(); i++)
            {
                Class487 class2 = A_0.method_5(i);
                this.method_6(class2.method_3(), class2.method_1(), class2.method_0(), class2.method_2(), class2.method_4());
            }
        }
    }

    internal void method_4(int A_0)
    {
        if (this.class264_0.method_4() != 0)
        {
            this.class149_0.method_8(A_0);
            this.class150_0.method_8(A_0);
            this.class149_0.method_28(this.class150_0);
            this.class150_0.method_28(this.class149_0);
        }
    }

    internal Class487 method_5(int A_0)
    {
        if (A_0 >= this.class264_0.method_4())
        {
            return null;
        }
        Class702 class5 = this.class264_0.method_2(A_0);
        Class538 class3 = this.class701_0.method_2(class5.method_2());
        Class487 class4 = new Class487(class5.method_1(), class3.method_5()[class5.method_3()], class5.method_4(), class3.method_3());
        foreach (Class167 class2 in class5.method_5())
        {
            class3 = this.class701_0.method_2(class2.method_1());
            class4.method_4().method_4(new Class901(class3.method_6()[class2.method_2()], class3.method_3(), class2.method_3()));
        }
        return class4;
    }

    private void method_6(string A_0, string A_1, MarkupLevel A_2, string A_3, Class457 A_4)
    {
        int num = this.class701_0.method_5(A_0);
        int num2 = this.class701_0.method_2(num).method_1(A_1);
        Class702 class3 = new Class702(Class487.smethod_1(A_2), num, num2, A_3);
        using (IEnumerator enumerator = A_4.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class901 current = (Class901) enumerator.Current;
                num = this.class701_0.method_5(current.method_1());
                num2 = this.class701_0.method_2(num).method_2(current.method_0());
                class3.method_5().Add(new Class167(num, num2, current.method_3()));
            }
        }
        this.class264_0.method_3(class3);
    }

    private void method_7()
    {
    }

    internal int method_8()
    {
        return this.class264_0.method_4();
    }

    internal Class149 method_9()
    {
        return this.class149_0;
    }
}

