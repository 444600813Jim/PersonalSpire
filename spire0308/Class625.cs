using System;
using System.IO;

internal class Class625 : Interface9
{
    private const char char_0 = '/';
    private readonly Class1132 class1132_0;

    internal Class625(Class1132 A_0)
    {
        this.class1132_0 = A_0;
    }

    public Stream imethod_0(Class731 A_0)
    {
        string str = A_0.method_2().Substring(1);
        Class1089 class2 = this.class1132_0.method_0();
        while (str.IndexOf('/') > 0)
        {
            int index = str.IndexOf('/');
            class2 = class2.method_6(str.Substring(0, index));
            str = str.Substring(index + 1);
        }
        return class2.method_5(str);
    }
}

