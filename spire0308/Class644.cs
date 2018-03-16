using Spire.Doc;
using System;
using System.Collections;

internal class Class644 : IEnumerable
{
    private readonly Class181 class181_0;
    private readonly Class181 class181_1;
    private int int_0 = 1;
    private readonly string string_0;

    public Class644(string A_0)
    {
        this.string_0 = A_0;
        this.class181_0 = new Class181(true);
        this.class181_1 = new Class181(false);
    }

    public int method_0()
    {
        return this.class181_0.Count;
    }

    public string method_1()
    {
        return this.string_0;
    }

    public string method_2(string A_0, string A_1, bool A_2)
    {
        int num = 0x11;
        if (A_2)
        {
            if (Class736.smethod_6(A_1))
            {
                A_1 = BookmarkStart.b("儶倸场堼Ծ湀求", num) + A_1;
                A_1 = Class736.smethod_15(A_1);
            }
        }
        else
        {
            A_1 = Class403.smethod_1(this.string_0, A_1);
        }
        Class1088 class2 = (Class1088) this.class181_1[A_1];
        if (class2 != null)
        {
            return class2.method_0();
        }
        string str = string.Format(BookmarkStart.b("䔶瀸强䘼༾㱀", num), this.int_0);
        this.int_0++;
        this.method_3(str, A_0, A_1, A_2);
        return str;
    }

    public void method_3(string A_0, string A_1, string A_2, bool A_3)
    {
        Class1088 class2 = new Class1088(A_0, A_1, A_2, A_3);
        this.class181_0[A_0] = class2;
        this.class181_1[A_2] = class2;
    }

    public Class1088 method_4(string A_0)
    {
        return (Class1088) this.class181_0[A_0];
    }

    public Class1088 method_5(string A_0)
    {
        Class1088 class3;
        using (IEnumerator enumerator = this.class181_0.GetValueList().GetEnumerator())
        {
            Class1088 current;
            while (enumerator.MoveNext())
            {
                current = (Class1088) enumerator.Current;
                if (current.method_1() == A_0)
                {
                    goto Label_0038;
                }
            }
            return null;
        Label_0038:
            class3 = current;
        }
        return class3;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.class181_0.GetValueList().GetEnumerator();
    }
}

