using System;

internal class Class373
{
    private const int int_0 = 0x10000;
    private const int int_1 = 0x4f54544f;
    public int int_2;
    public ushort ushort_0;

    public bool method_0()
    {
        if ((this.int_2 != 0x10000) && (this.int_2 != 0x4f54544f))
        {
            return false;
        }
        return (this.ushort_0 > 0);
    }

    public static Class373 smethod_0(Class303 A_0)
    {
        Class373 class2 = new Class373 {
            int_2 = A_0.method_1(),
            ushort_0 = A_0.method_4()
        };
        A_0.method_4();
        A_0.method_4();
        A_0.method_4();
        return class2;
    }
}

