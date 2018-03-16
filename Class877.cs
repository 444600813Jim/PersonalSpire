using System;

internal class Class877
{
    public const int int_0 = 0x10;
    public int int_1;
    public string string_0;
    public uint uint_0;
    public uint uint_1;

    public static Class877 smethod_0(Class303 A_0)
    {
        return new Class877 { string_0 = new string(A_0.method_9(4)), int_1 = A_0.method_1(), uint_1 = A_0.method_2(), uint_0 = A_0.method_2() };
    }

    public static int smethod_1(byte[] A_0)
    {
        return smethod_2(A_0, 0, A_0.Length);
    }

    public static int smethod_2(byte[] A_0, int A_1, int A_2)
    {
        int num5;
        int num6;
        int num7;
        int num8;
        int num = 0;
        int index = A_1;
        int num3 = A_2 / 4;
        for (int i = 0; i < num3; i++)
        {
            num5 = A_0[index++];
            num6 = A_0[index++];
            num7 = A_0[index++];
            num8 = A_0[index++];
            int num9 = ((num8 | (num7 << 8)) | (num6 << 0x10)) | (num5 << 0x18);
            num += num9;
        }
        num5 = (index < A_2) ? A_0[index++] : 0;
        num6 = (index < A_2) ? A_0[index++] : 0;
        num7 = (index < A_2) ? A_0[index] : 0;
        num8 = 0;
        int num10 = ((0 | (num7 << 8)) | (num6 << 0x10)) | (num5 << 0x18);
        return (num + num10);
    }
}

