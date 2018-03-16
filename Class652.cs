using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class652 : IComparer
{
    int IComparer.Compare(object A_0, object A_1)
    {
        Class127 class2 = (Class127) A_0;
        Class127 class3 = (Class127) A_1;
        Border border = (Border) class2.method_3();
        Border border2 = (Border) class3.method_3();
        int num = (((class2.method_1() * 0x3e8) + (class2.method_0() * 100)) + (((border == null) ? 1 : 0) * 10)) + class2.method_2();
        int num2 = (((class3.method_1() * 0x3e8) + (class3.method_0() * 100)) + ((border2.Equals(new Border()) ? 1 : 0) * 10)) + class3.method_2();
        return (num - num2);
    }
}

