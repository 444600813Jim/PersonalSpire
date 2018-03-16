using Spire.Doc.Documents;
using System;

internal class Class815
{
    private readonly Class827[][] class827_0 = new Class827[2][];
    private const int int_0 = 2;
    private const int int_1 = 4;

    internal Class815()
    {
        for (int i = 0; i < 2; i++)
        {
            this.class827_0[i] = new Class827[4];
        }
    }

    internal Class815 method_0()
    {
        Class815 class2 = new Class815();
        for (int i = 0; i < this.class827_0.Length; i++)
        {
            class2.class827_0[i] = (Class827[]) this.class827_0[i].Clone();
        }
        return class2;
    }

    internal void method_1(Class815 A_0)
    {
        for (int i = 0; i < 2; i++)
        {
            Class827[] classArray = A_0.class827_0[i];
            for (int j = 0; j < 4; j++)
            {
                Class827 class2 = classArray[j];
                if (class2 != null)
                {
                    Class827 class3 = this.class827_0[i][j];
                    if ((class3 == null) || (class3.method_3() && !class2.method_3()))
                    {
                        this.class827_0[i][j] = class2;
                    }
                }
            }
        }
    }

    internal Class827[] method_2(EmbeddedFontFormat A_0)
    {
        return this.class827_0[(int) A_0];
    }

    internal Class827[] method_3()
    {
        Class827[] destinationArray = new Class827[8];
        Class827[] sourceArray = this.class827_0[0];
        Class827[] classArray3 = this.class827_0[1];
        if (sourceArray != null)
        {
            Array.Copy(sourceArray, 0, destinationArray, 0, 4);
        }
        if (classArray3 != null)
        {
            Array.Copy(classArray3, 0, destinationArray, 4, 4);
        }
        return destinationArray;
    }

    internal Class827 method_4(EmbeddedFontFormat A_0, EmbeddedFontStyle A_1)
    {
        return this.class827_0[(int) A_0][(int) A_1];
    }

    internal void method_5(Class827 A_0)
    {
        this.class827_0[(int) A_0.method_1()][(int) A_0.method_2()] = A_0;
    }
}

