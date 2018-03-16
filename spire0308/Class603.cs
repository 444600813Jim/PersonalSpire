using System;

internal sealed class Class603
{
    private static int int_0 = 0xfff1;
    private static int int_1 = 0x15b0;

    internal static long smethod_0(long A_0, byte[] A_1, int A_2, int A_3)
    {
        if (A_1 == null)
        {
            return 1L;
        }
        long num = A_0 & 0xffffL;
        long num2 = (A_0 >> 0x10) & 0xffffL;
        while (A_3 > 0)
        {
            int num3 = (A_3 < int_1) ? A_3 : int_1;
            A_3 -= num3;
            while (num3 >= 0x10)
            {
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num += A_1[A_2++] & 0xff;
                num2 += num;
                num3 -= 0x10;
            }
            if (num3 != 0)
            {
                do
                {
                    num += A_1[A_2++] & 0xff;
                    num2 += num;
                }
                while (--num3 != 0);
            }
            num = num % ((long) int_0);
            num2 = num2 % ((long) int_0);
        }
        return ((num2 << 0x10) | num);
    }
}

