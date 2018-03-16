using System;
using System.Runtime.CompilerServices;

internal class Class721 : IComparable
{
    private bool bool_0;
    [CompilerGenerated]
    private bool bool_1;
    [CompilerGenerated]
    private bool bool_2;
    private float float_0;
    private float float_1;
    private float float_2;
    private float float_3;
    public float float_4;
    private ushort? nullable_0;

    public float method_0()
    {
        return this.float_0;
    }

    public void method_1(float A_0)
    {
        this.float_0 = A_0;
    }

    [CompilerGenerated]
    public bool method_10()
    {
        return this.bool_1;
    }

    [CompilerGenerated]
    public void method_11(bool A_0)
    {
        this.bool_1 = A_0;
    }

    [CompilerGenerated]
    public bool method_12()
    {
        return this.bool_2;
    }

    [CompilerGenerated]
    public void method_13(bool A_0)
    {
        this.bool_2 = A_0;
    }

    public bool method_14()
    {
        return this.method_8().HasValue;
    }

    public float method_2()
    {
        return this.float_1;
    }

    public void method_3(float A_0)
    {
        this.float_1 = A_0;
    }

    public float method_4()
    {
        return this.float_2;
    }

    public void method_5(float A_0)
    {
        this.float_2 = A_0;
    }

    public float method_6()
    {
        return this.float_3;
    }

    public void method_7(float A_0)
    {
        this.float_3 = A_0;
    }

    public ushort? method_8()
    {
        return this.nullable_0;
    }

    public void method_9(ushort? A_0)
    {
        this.nullable_0 = A_0;
    }

    int IComparable.CompareTo(object A_0)
    {
        Class721 class2 = (Class721) A_0;
        if ((this.method_2() != class2.method_2()) && !class2.method_10())
        {
            return this.method_2().CompareTo(class2.method_2());
        }
        return -1;
    }

    int object.GetHashCode()
    {
        return this.method_8().GetHashCode();
    }
}

