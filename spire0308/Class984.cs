using System;
using System.Collections;

internal class Class984 : IComparer
{
    int IComparer.Compare(object A_0, object A_1)
    {
        Class127 class2 = (Class127) A_0;
        Class127 class3 = (Class127) A_1;
        int num = ((class2.method_1() * 0x3e8) + (class2.method_0() * 100)) + class2.method_2();
        int num2 = ((class3.method_1() * 0x3e8) + (class3.method_0() * 100)) + class3.method_2();
        return (num - num2);
    }
}

