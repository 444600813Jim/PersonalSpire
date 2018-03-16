using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

[DefaultMember("Item")]
internal class Class410
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal Class1090 method_0(uint A_0)
    {
        return (Class1090) this.arrayList_0[(int) A_0];
    }

    internal void method_1(uint A_0, Class1090 A_1)
    {
        this.arrayList_0[(int) A_0] = A_1;
    }

    internal int method_2()
    {
        return this.arrayList_0.Count;
    }

    internal void method_3(Class1090 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal Class1090 method_4(string A_0)
    {
        Class1090 class2 = this.method_6(this.method_0(0), this.method_0(0).uint_1);
        return this.method_5(class2, A_0);
    }

    private Class1090 method_5(Class1090 A_0, string A_1)
    {
        if (A_0.string_0 == A_1)
        {
            return A_0;
        }
        Class1090 class4 = this.method_6(A_0, A_0.uint_2);
        if (class4 != null)
        {
            Class1090 class5 = this.method_5(class4, A_1);
            if (class5 != null)
            {
                return class5;
            }
        }
        Class1090 class2 = this.method_6(A_0, A_0.uint_3);
        if (class2 != null)
        {
            Class1090 class3 = this.method_5(class2, A_1);
            if (class3 != null)
            {
                return class3;
            }
        }
        return null;
    }

    internal Class1090 method_6(Class1090 A_0, uint A_1)
    {
        if (((A_1 != uint.MaxValue) && (A_1 < this.arrayList_0.Count)) && (A_0 != this.method_0(A_1)))
        {
            return this.method_0(A_1);
        }
        return null;
    }

    internal MemoryStream method_7()
    {
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output, Encoding.Unicode);
        for (uint i = 0; i < this.arrayList_0.Count; i++)
        {
            this.method_0(i).method_0(writer);
        }
        Class1090 class2 = new Class1090();
        while ((output.Length % 0x200L) != 0L)
        {
            class2.method_0(writer);
        }
        return output;
    }
}

