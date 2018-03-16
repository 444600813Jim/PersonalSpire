using System;

internal class Class537
{
    private readonly char[] char_0;
    private readonly Class870 class870_0;
    private readonly int int_0;

    internal Class537(char[] A_0, Class870 A_1, int A_2)
    {
        this.char_0 = A_0;
        this.class870_0 = A_1;
        this.int_0 = A_2;
    }

    internal Class537(Class537 A_0, int A_1, int A_2)
    {
        int length = A_2 - A_1;
        this.char_0 = new char[length];
        Array.Copy(A_0.char_0, A_1, this.char_0, 0, length);
        this.class870_0 = new Class870(A_0.method_3().method_0(), A_0.method_3().method_1() + A_1);
        this.int_0 = A_0.method_4() + (A_1 * (A_0.method_3().method_0().bool_0 ? 2 : 1));
    }

    internal int method_0(int A_0)
    {
        return ((this.class870_0.method_0().method_0().method_2() + this.class870_0.method_1()) + A_0);
    }

    internal int method_1(int A_0)
    {
        return (this.int_0 + (A_0 * (this.class870_0.method_0().bool_0 ? 2 : 1)));
    }

    internal char[] method_2()
    {
        return this.char_0;
    }

    internal Class870 method_3()
    {
        return this.class870_0;
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal int method_5()
    {
        return this.method_1(this.char_0.Length);
    }

    internal int method_6()
    {
        return this.method_0(0);
    }

    internal bool method_7()
    {
        return this.class870_0.method_0().bool_0;
    }

    internal char method_8()
    {
        return this.char_0[this.char_0.Length - 1];
    }
}

