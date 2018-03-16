using System;

internal class Class444
{
    private float float_0 = float.MaxValue;
    private int int_0;
    private int int_1;
    private readonly int int_2;
    private readonly int int_3;

    internal Class444(Class722 A_0, Class722 A_1, int A_2, int A_3)
    {
        this.int_2 = A_2;
        this.int_3 = A_3;
        this.method_0(A_0, A_1);
    }

    private void method_0(Class722 A_0, Class722 A_1)
    {
        for (int i = 0; i < A_0.method_19(); i++)
        {
            for (int j = 0; j < A_1.method_19(); j++)
            {
                float num3 = spr⃸.ᜁ(A_0.method_20(i).method_2(), A_1.method_20(j).method_2());
                if (num3 < this.float_0)
                {
                    this.float_0 = num3;
                    this.int_0 = i;
                    this.int_1 = j;
                }
            }
        }
    }

    internal float method_1()
    {
        return this.float_0;
    }

    internal int method_2()
    {
        return this.int_0;
    }

    internal int method_3()
    {
        return this.int_1;
    }

    internal int method_4()
    {
        return this.int_2;
    }

    internal int method_5()
    {
        return this.int_3;
    }
}

