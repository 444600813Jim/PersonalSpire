using System;

internal class Class1000
{
    private const int int_0 = 0x10;
    private const int int_1 = 0xfff1;
    private const int int_2 = 0xed8;

    public static void smethod_0(ref long A_0, byte[] A_1, int A_2, int A_3)
    {
        uint num = (uint) A_0;
        uint num2 = num & 0xffff;
        uint num3 = num >> 0x10;
        while (A_3 > 0)
        {
            int num4 = Math.Min(A_3, 0xed8);
            A_3 -= num4;
            while (--num4 >= 0)
            {
                num2 += (uint) (A_1[A_2++] & 0xff);
                num3 += num2;
            }
            num2 = num2 % 0xfff1;
            num3 = num3 % 0xfff1;
        }
        num = (num3 << 0x10) | num2;
        A_0 = num;
    }

    public static long smethod_1(byte[] A_0, int A_1, int A_2)
    {
        long num = 1L;
        smethod_0(ref num, A_0, A_1, A_2);
        return num;
    }
}

