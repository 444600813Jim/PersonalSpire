using System;
using System.Collections.Specialized;
using System.IO;

internal class Class343 : Class341
{
    private readonly StringCollection stringCollection_0;

    internal Class343(StringCollection A_0)
    {
        this.stringCollection_0 = A_0;
    }

    internal static void smethod_1(BinaryReader A_0, Class1111 A_1, StringCollection A_2)
    {
        smethod_2(A_0, A_1.int_0, A_1.int_1, A_2);
    }

    internal static void smethod_2(BinaryReader A_0, int A_1, int A_2, StringCollection A_3)
    {
        new Class343(A_3).method_0(A_0, A_1, A_2);
    }

    internal static void smethod_3(BinaryReader A_0, StringCollection A_1)
    {
        new Class343(A_1).method_1(A_0);
    }

    internal static int smethod_4(BinaryWriter A_0, StringCollection A_1)
    {
        return smethod_5(A_0, A_1, false);
    }

    internal static int smethod_5(BinaryWriter A_0, StringCollection A_1, bool A_2)
    {
        Class343 class2 = new Class343(A_1);
        return class2.method_4(A_0, A_2);
    }

    protected override void vmethod_0(string A_0, BinaryReader A_1)
    {
        this.stringCollection_0.Add(A_0);
    }

    protected override int vmethod_1()
    {
        return this.stringCollection_0.Count;
    }

    protected override int vmethod_2()
    {
        return 0;
    }

    protected override void vmethod_3(BinaryWriter A_0)
    {
        using (StringEnumerator enumerator = this.stringCollection_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class341.smethod_0(enumerator.Current, A_0);
            }
        }
    }
}

