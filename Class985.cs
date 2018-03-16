using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class985 : ArrayList
{
    public Class537 method_0(int A_0)
    {
        return (Class537) base[A_0];
    }

    internal Class537 method_1()
    {
        return this.method_0(this.Count - 1);
    }

    internal int method_2()
    {
        int num = 0;
        for (int i = 0; i < this.Count; i++)
        {
            num += this.method_0(i).method_2().Length;
        }
        return num;
    }

    internal Class428 method_3()
    {
        return this.method_1().method_3().method_0().method_1();
    }
}

