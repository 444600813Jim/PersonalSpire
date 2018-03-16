using System;

internal class Class968
{
    public static Guid smethod_0(byte[] A_0)
    {
        return smethod_1(A_0, 0, A_0.Length);
    }

    public static Guid smethod_1(byte[] A_0, int A_1, int A_2)
    {
        Class790 class2 = new Class790();
        return new Guid(class2.method_1(A_0, A_1, A_2));
    }

    public static int smethod_2(string A_0)
    {
        int num = 0x15051505;
        int num2 = 0x15051505;
        int num3 = 0;
        for (int i = A_0.Length; i > 0; i -= 4)
        {
            int num9 = A_0[num3];
            int num6 = (i > 1) ? A_0[num3 + 1] : 0;
            int num5 = (i > 2) ? A_0[num3 + 2] : 0;
            int num7 = (i > 3) ? A_0[num3 + 3] : 0;
            int num8 = num6;
            num8 = num8 << 0x10;
            num8 += num9;
            int num10 = num7;
            num10 = num10 << 0x10;
            num10 += num5;
            num = (((num << 5) + num) + (num >> 0x1b)) ^ num8;
            if (i <= 2)
            {
                break;
            }
            num2 = (((num2 << 5) + num2) + (num2 >> 0x1b)) ^ num10;
            num3 += 4;
        }
        return (num + (num2 * 0x5d588b65));
    }
}

