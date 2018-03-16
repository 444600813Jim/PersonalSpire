using Spire.Doc.Documents;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class975 : ArrayList
{
    private int int_0;

    public Class571 method_0(int A_0)
    {
        return (Class571) base[A_0];
    }

    public void method_1(int A_0, Class571 A_1)
    {
        base[A_0] = A_1;
    }

    private void method_2(int A_0, int A_1, Class1140 A_2)
    {
        Class571 class2 = this.method_0(A_0);
        class2.Add(null);
        int num = class2.Count - 1;
        for (int i = num - 1; i >= A_1; i = num - 1)
        {
            while (class2.method_0(i).method_6() == CellMerge.Continue)
            {
                i--;
            }
            class2.method_1(num, class2.method_0(i));
            num = i;
        }
        class2.method_1(A_1, A_2);
    }

    private void method_3(int A_0, int A_1)
    {
        for (int i = 0; i < A_1; i++)
        {
            this.method_0(A_0).Add(new Class1140());
        }
    }

    internal void method_4()
    {
        for (int i = 0; i < this.Count; i++)
        {
            Class571 class4 = this.method_0(i);
            for (int j = 0; j < class4.Count; j++)
            {
                Class1140 class3 = class4.method_0(j);
                int num5 = Math.Min(class3.method_2(), this.Count - i);
                if (num5 > 1)
                {
                    class3.method_7(CellMerge.Start);
                    for (int k = 1; k < num5; k++)
                    {
                        int num3 = i + k;
                        if ((j + 1) > this.method_0(num3).Count)
                        {
                            this.method_3(num3, (j - this.method_0(num3).Count) + 1);
                        }
                        else
                        {
                            this.method_2(num3, j, new Class1140());
                        }
                        this.int_0 = Math.Max(this.int_0, this.method_0(num3).Count);
                        Class1140 class2 = this.method_0(num3).method_0(j);
                        class2.method_7(CellMerge.Continue);
                        class2.method_5(class3.method_4());
                    }
                }
            }
        }
    }

    internal int method_5()
    {
        return this.int_0;
    }

    internal void method_6(int A_0)
    {
        this.int_0 = A_0;
    }
}

