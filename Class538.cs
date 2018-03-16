using System;
using System.Collections.Specialized;
using System.IO;

internal class Class538
{
    private readonly string string_0;
    private readonly string string_1;
    private readonly StringCollection stringCollection_0;
    private readonly StringCollection stringCollection_1;

    internal Class538(BinaryReader A_0)
    {
        this.stringCollection_0 = new StringCollection();
        this.stringCollection_1 = new StringCollection();
        this.string_0 = Class813.smethod_1(A_0, true, false);
        this.string_1 = Class813.smethod_1(A_0, true, false);
        Class343.smethod_3(A_0, this.method_5());
        Class343.smethod_3(A_0, this.method_6());
    }

    internal Class538(string A_0)
    {
        this.stringCollection_0 = new StringCollection();
        this.stringCollection_1 = new StringCollection();
        this.string_0 = A_0;
    }

    internal void method_0(BinaryWriter A_0)
    {
        Class813.smethod_2(this.method_3(), this.method_3().Length, A_0, true, false);
        Class813.smethod_2(this.method_4(), this.method_4().Length, A_0, true, false);
        Class343.smethod_5(A_0, this.method_5(), true);
        Class343.smethod_5(A_0, this.method_6(), true);
    }

    internal int method_1(string A_0)
    {
        int index = this.method_5().IndexOf(A_0);
        if (index < 0)
        {
            index = this.method_5().Add(A_0);
        }
        return index;
    }

    internal int method_2(string A_0)
    {
        int index = this.method_6().IndexOf(A_0);
        if (index < 0)
        {
            index = this.method_6().Add(A_0);
        }
        return index;
    }

    internal string method_3()
    {
        if (!Class567.smethod_16(this.string_0))
        {
            return "";
        }
        return this.string_0;
    }

    internal string method_4()
    {
        if (!Class567.smethod_16(this.string_1))
        {
            return "";
        }
        return this.string_1;
    }

    internal StringCollection method_5()
    {
        return this.stringCollection_0;
    }

    internal StringCollection method_6()
    {
        return this.stringCollection_1;
    }
}

