using System;
using System.Text;

internal class Class525
{
    private const int int_0 = 0x4c;
    private int int_1;
    private readonly string string_0;

    public Class525(byte[] A_0, int A_1, int A_2)
    {
        this.string_0 = Convert.ToBase64String(A_0, A_1, A_2);
    }

    public bool method_0()
    {
        return (this.int_1 >= this.string_0.Length);
    }

    public string method_1()
    {
        int length = Math.Min(0x4c, this.string_0.Length - this.int_1);
        string str = this.string_0.Substring(this.int_1, length);
        this.int_1 += length;
        return str;
    }

    public static string smethod_0(byte[] A_0, string A_1)
    {
        Class525 class2 = new Class525(A_0, 0, A_0.Length);
        StringBuilder builder = new StringBuilder();
    Label_001B:
        builder.Append(class2.method_1());
        if (!class2.method_0())
        {
            builder.Append(A_1);
            goto Label_001B;
        }
        builder.Append(A_1);
        return builder.ToString();
    }
}

