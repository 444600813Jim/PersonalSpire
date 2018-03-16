using System;
using System.IO;

internal class Class513
{
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private ushort ushort_0 = 0xffff;
    private ushort ushort_1 = 0x12;
    private ushort ushort_2;

    internal Class513()
    {
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_10()
    {
        return this.string_5;
    }

    internal void method_11(string A_0)
    {
        this.string_5 = A_0;
    }

    internal string method_12()
    {
        return this.string_6;
    }

    internal void method_13(string A_0)
    {
        this.string_6 = A_0;
    }

    internal string method_14()
    {
        return this.string_7;
    }

    internal void method_15(string A_0)
    {
        this.string_7 = A_0;
    }

    internal string method_16()
    {
        return this.string_8;
    }

    internal void method_17(string A_0)
    {
        this.string_8 = A_0;
    }

    internal void method_18(byte[] A_0)
    {
        if (A_0.Length >= 0x2a)
        {
            int num = 0;
            this.ushort_0 = Class1012.smethod_16(A_0, 0);
            num = 2;
            this.ushort_1 = Class1012.smethod_16(A_0, 2);
            num = 4;
            this.ushort_2 = Class1012.smethod_16(A_0, 4);
            num = 6;
            ushort num2 = Class1012.smethod_16(A_0, 6);
            num = 8;
            num = 8 + (num2 * 2);
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_0 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_1 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_2 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_3 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_4 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_5 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_6 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            this.string_7 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            num += num2 * 2;
            num2 = Class1012.smethod_16(A_0, num);
            num += 2;
            if (num2 > 0)
            {
                this.string_8 = Class1012.smethod_21(A_0, num, (ushort) (num2 * 2));
            }
            num += num2 * 2;
        }
    }

    internal byte[] method_19()
    {
        MemoryStream stream = new MemoryStream();
        Class1012.smethod_29(stream, this.ushort_0);
        Class1012.smethod_29(stream, this.ushort_1);
        Class1012.smethod_29(stream, this.ushort_2);
        Class1012.smethod_29(stream, 0);
        if (string.IsNullOrEmpty(this.string_0))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_0);
        }
        if (string.IsNullOrEmpty(this.string_1))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_1);
        }
        if (string.IsNullOrEmpty(this.string_2))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_2);
        }
        if (string.IsNullOrEmpty(this.string_3))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_3);
        }
        Class1012.smethod_29(stream, 0);
        if (string.IsNullOrEmpty(this.string_4))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_4);
        }
        if (string.IsNullOrEmpty(this.string_5))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_5);
        }
        if (string.IsNullOrEmpty(this.string_6))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_6);
        }
        if (string.IsNullOrEmpty(this.string_7))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            Class1012.smethod_19(stream, this.string_7);
        }
        Class1012.smethod_29(stream, 0);
        Class1012.smethod_29(stream, 0);
        Class1012.smethod_29(stream, 0);
        Class1012.smethod_29(stream, 0);
        Class1012.smethod_29(stream, 0);
        Class1012.smethod_29(stream, 0);
        Class1012.smethod_29(stream, 0);
        if (string.IsNullOrEmpty(this.string_8))
        {
            Class1012.smethod_29(stream, 0);
        }
        else
        {
            if (this.string_8.Length > 15)
            {
                this.string_8 = this.string_8.Substring(0, 15);
            }
            Class1012.smethod_19(stream, this.string_8);
        }
        byte[] dst = new byte[stream.Length];
        Buffer.BlockCopy(stream.GetBuffer(), 0, dst, 0, (int) stream.Length);
        return dst;
    }

    internal string method_2()
    {
        return this.string_1;
    }

    internal void method_3(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_4()
    {
        return this.string_2;
    }

    internal void method_5(string A_0)
    {
        this.string_2 = A_0;
    }

    internal string method_6()
    {
        return this.string_3;
    }

    internal void method_7(string A_0)
    {
        this.string_3 = A_0;
    }

    internal string method_8()
    {
        return this.string_4;
    }

    internal void method_9(string A_0)
    {
        this.string_4 = A_0;
    }
}

