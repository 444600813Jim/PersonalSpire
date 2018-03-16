using Spire.Doc;
using System;

internal class Class546
{
    private int int_0;
    private int int_1;

    private Class546()
    {
    }

    public Class546(int A_0, int A_1)
    {
        int num = 13;
        if (A_0 < 0)
        {
            throw new ArgumentException(BookmarkStart.b("唲尴䔶䨸伺洼倾㉀", num));
        }
        if (A_0 > A_1)
        {
            throw new ArgumentException(BookmarkStart.b("弲吴䐶䴸欺刼䰾", num));
        }
        this.int_1 = A_1;
        this.int_0 = A_0;
    }

    public int method_0()
    {
        return this.int_0;
    }

    public int method_1()
    {
        return this.int_1;
    }

    public int method_2()
    {
        return ((this.method_1() - this.method_0()) + 1);
    }

    public void method_3(int A_0)
    {
        int num = 0x13;
        if ((this.int_0 < 0) || (this.int_0 > A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("樸䬺儼嘾㕀ੂ⭄ⅆ♈敊ୌ♎⍐⁒⅔ݖ㙘⡚", num));
        }
        if ((this.int_1 < this.int_0) || (this.int_1 > A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("樸䬺儼嘾㕀ੂ⭄ⅆ♈敊Ō⹎≐❒Ք㡖⩘", num));
        }
    }

    public void method_4(Class546 A_0)
    {
        this.int_0 += A_0.method_0();
        this.int_1 += A_0.method_0();
    }

    public Class546 method_5(int A_0)
    {
        return new Class546(this.int_0, this.int_0 + A_0);
    }

    public Class546 method_6(int A_0)
    {
        return new Class546(this.int_0 + A_0, this.int_1);
    }

    public string method_7(string A_0)
    {
        return A_0.Substring(this.int_0, this.int_1 - this.int_0);
    }
}

