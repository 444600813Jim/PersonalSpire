using System;

internal abstract class Class128
{
    private Class145 class145_0;
    private Class764 class764_0;

    protected Class128()
    {
    }

    internal void method_0(Class764 A_0, Class146 A_1, int A_2)
    {
        this.class764_0 = A_0;
        this.class145_0 = A_1.method_15(A_2);
    }

    internal int method_1()
    {
        return this.class145_0.int_1;
    }

    internal void method_2(int A_0)
    {
        while (this.class145_0.int_1 == A_0)
        {
            this.vmethod_0(this.class764_0, this.class145_0.int_0);
            if (this.class145_0.method_0())
            {
                return;
            }
            this.class145_0.method_1();
        }
    }

    protected abstract void vmethod_0(Class764 A_0, int A_1);
}

