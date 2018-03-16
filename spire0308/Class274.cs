using System;
using System.IO;

internal class Class274 : Class272
{
    internal Class274() : base(EscherRecordType.DggContainer)
    {
    }

    internal void method_11(BinaryReader A_0)
    {
        if (this.method_14() != null)
        {
            this.method_14().method_11(A_0);
        }
    }

    internal void method_12(BinaryWriter A_0)
    {
        if (this.method_14() != null)
        {
            this.method_14().method_12(A_0);
        }
    }

    internal void method_13()
    {
        if ((this.method_14() != null) && (this.method_14().method_8() == 0))
        {
            base.method_7().Remove(this.method_14());
        }
    }

    internal Class275 method_14()
    {
        return (Class275) base.method_6(typeof(Class275));
    }

    internal Class284 method_15()
    {
        return (Class284) base.method_6(typeof(Class284));
    }

    internal static Class274 smethod_0()
    {
        Class274 class2 = new Class274();
        class2.method_7().Add(new Class284());
        class2.method_7().Add(new Class275());
        return class2;
    }
}

