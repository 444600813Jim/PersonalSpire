using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class755 : ArrayList
{
    private static bool bool_0;
    private readonly Class168 class168_0 = new Class168();
    private readonly Class349 class349_0 = new Class349();
    private readonly Class986 class986_0 = new Class986();
    private readonly Class996 class996_0 = new Class996();
    private readonly Stack stack_0 = new Stack();

    internal Class755()
    {
        for (int i = 0; i <= 6; i++)
        {
            this.Add(new Class260((SubDocumentType) i));
        }
    }

    internal void method_0(SubDocumentType A_0)
    {
        this.stack_0.Push(this.method_22(A_0));
    }

    internal void method_1()
    {
        this.stack_0.Pop();
    }

    internal void method_10(int A_0, int A_1, Class431 A_2)
    {
        this.method_29().method_6().method_5(A_0, A_1, A_2);
    }

    internal void method_11(Class766 A_0)
    {
        this.method_29().method_7().method_6(this.method_20(), A_0);
    }

    internal void method_12(string A_0, int A_1)
    {
        this.method_29().method_8().method_7(this.method_20(), A_0, A_1);
    }

    internal void method_13(string A_0)
    {
        this.method_29().method_8().method_8(this.method_20(), A_0);
    }

    internal void method_14(Class9 A_0)
    {
        this.method_29().method_10().method_0(this.method_20(), A_0);
    }

    internal void method_15(Class9 A_0)
    {
        this.method_29().method_10().method_1(this.method_20(), A_0);
    }

    internal void method_16(Class4 A_0)
    {
        this.method_29().method_11().method_2(this.method_20(), A_0);
    }

    internal void method_17(Class430 A_0)
    {
        this.method_29().method_5().method_6(this.method_20(), A_0);
    }

    internal void method_18()
    {
        this.method_29().method_0();
    }

    internal void method_19()
    {
        this.method_29().method_1();
    }

    internal void method_2(int A_0)
    {
        this.method_3();
        this.method_4(A_0);
        this.method_5();
        this.method_6();
        this.method_7();
        this.method_8();
    }

    internal int method_20()
    {
        return this.method_29().method_13();
    }

    internal int method_21()
    {
        int num = 0;
        foreach (Class260 class2 in this)
        {
            num += class2.method_12().Length;
        }
        return num;
    }

    internal Class260 method_22(SubDocumentType A_0)
    {
        return (base[(int) A_0] as Class260);
    }

    internal SubDocumentType method_23()
    {
        return this.method_29().method_4();
    }

    internal int method_24()
    {
        return this.method_29().method_14();
    }

    internal Class996 method_25()
    {
        return this.class996_0;
    }

    internal Class168 method_26()
    {
        return this.class168_0;
    }

    internal Class349 method_27()
    {
        return this.class349_0;
    }

    internal Class986 method_28()
    {
        return this.class986_0;
    }

    private Class260 method_29()
    {
        return (this.stack_0.Peek() as Class260);
    }

    private void method_3()
    {
        int num = this.method_21();
        foreach (Class260 class2 in this)
        {
            class2.method_2(num);
        }
    }

    private void method_4(int A_0)
    {
        int num = A_0;
        foreach (Class260 class2 in this)
        {
            class2.method_5().method_24(num);
            class2.method_6().method_24(num);
            num += class2.method_12().Length * 2;
        }
    }

    private void method_5()
    {
        int num = 0;
        foreach (Class260 class2 in this)
        {
            this.class996_0.method_2(class2.method_8(), num);
            num += class2.method_12().Length;
        }
    }

    private void method_6()
    {
        int num = 0;
        foreach (Class260 class2 in this)
        {
            this.class168_0.method_11(class2.method_9(), num);
            num += class2.method_12().Length;
        }
        this.class168_0.method_14(this.method_21());
    }

    private void method_7()
    {
        int num = 0;
        foreach (Class260 class2 in this)
        {
            this.class349_0.method_3(class2.method_10(), num);
            num += class2.method_12().Length;
        }
        this.class349_0.method_4(this.method_21());
    }

    private void method_8()
    {
        int num = 0;
        foreach (Class260 class2 in this)
        {
            this.class986_0.method_3(class2.method_11(), num);
            num += class2.method_12().Length;
        }
        this.class986_0.method_4(this.method_21());
    }

    internal void method_9(string A_0)
    {
        this.method_29().method_12().Append(A_0);
    }
}

