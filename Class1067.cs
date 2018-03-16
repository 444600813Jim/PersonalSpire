using Spire.Doc;
using System;
using System.Runtime.InteropServices;

internal class Class1067
{
    private static Class1067 class1067_0;
    private static Class1067 class1067_1;
    private static int int_0;
    private short[] short_0;

    static Class1067()
    {
        int num = 4;
        int_0 = 15;
        try
        {
            byte[] buffer = new byte[0x120];
            int num2 = 0;
            while (num2 < 0x90)
            {
                buffer[num2++] = 8;
            }
            while (num2 < 0x100)
            {
                buffer[num2++] = 9;
            }
            while (num2 < 280)
            {
                buffer[num2++] = 7;
            }
            while (num2 < 0x120)
            {
                buffer[num2++] = 8;
            }
            class1067_0 = new Class1067(buffer);
            buffer = new byte[0x20];
            num2 = 0;
            while (num2 < 0x20)
            {
                buffer[num2++] = 5;
            }
            class1067_1 = new Class1067(buffer);
        }
        catch (Exception exception)
        {
            throw new Exception(BookmarkStart.b("温䤫䴭弯弱䐳䐵崷䤹伻儽㈿ੁㅃ⁅⹇❉ⵋ⁍я⁑ㅓ㍕扗穙㩛㝝ᡟݡc䙥ᱧᡩ५୭ͯ剱፳፵ᙷό๻ώꢇﲏ", num), exception);
        }
    }

    public Class1067(byte[] A_0)
    {
        this.method_2(A_0);
    }

    private int method_0(int[] A_0, int[] A_1, byte[] A_2, out int A_3)
    {
        int num = 0;
        A_3 = 0x200;
        for (int i = 0; i < A_2.Length; i++)
        {
            int index = A_2[i];
            if (index > 0)
            {
                A_0[index]++;
            }
        }
        for (int j = 1; j <= int_0; j++)
        {
            A_1[j] = num;
            num += A_0[j] << (0x10 - j);
            if (j >= 10)
            {
                int num5 = A_1[j] & 0x1ff80;
                int num6 = num & 0x1ff80;
                A_3 += (num6 - num5) >> (0x10 - j);
            }
        }
        return num;
    }

    private short[] method_1(int[] A_0, int[] A_1, byte[] A_2, int A_3, int A_4)
    {
        short[] numArray = new short[A_4];
        int num = 0x200;
        int num2 = 0x80;
        for (int i = int_0; i >= 10; i--)
        {
            int num10 = A_3 & 0x1ff80;
            A_3 -= A_0[i] << (0x10 - i);
            int num11 = A_3 & 0x1ff80;
            for (int k = num11; k < num10; k += num2)
            {
                numArray[Class1112.smethod_0(k)] = (short) ((-num << 4) | i);
                num += ((int) 1) << (i - 9);
            }
        }
        for (int j = 0; j < A_2.Length; j++)
        {
            int index = A_2[j];
            if (index != 0)
            {
                A_3 = A_1[index];
                int num4 = Class1112.smethod_0(A_3);
                if (index <= 9)
                {
                    do
                    {
                        numArray[num4] = (short) ((j << 4) | index);
                        num4 += ((int) 1) << index;
                    }
                    while (num4 < 0x200);
                }
                else
                {
                    int num5 = numArray[num4 & 0x1ff];
                    int num6 = ((int) 1) << (num5 & 15);
                    num5 = -(num5 >> 4);
                    do
                    {
                        numArray[num5 | (num4 >> 9)] = (short) ((j << 4) | index);
                        num4 += ((int) 1) << index;
                    }
                    while (num4 < num6);
                }
                A_1[index] = A_3 + (((int) 1) << (0x10 - index));
            }
        }
        return numArray;
    }

    private void method_2(byte[] A_0)
    {
        int num;
        int[] numArray = new int[int_0 + 1];
        int[] numArray2 = new int[int_0 + 1];
        int num2 = this.method_0(numArray, numArray2, A_0, out num);
        this.short_0 = this.method_1(numArray, numArray2, A_0, num2, num);
    }

    public int method_3(Class1114 A_0)
    {
        int num2;
        int index = A_0.method_7(9);
        if (index >= 0)
        {
            num2 = this.short_0[index];
            if (num2 >= 0)
            {
                A_0.method_8(num2 & 15);
                return (num2 >> 4);
            }
            int num4 = -(num2 >> 4);
            int num5 = num2 & 15;
            index = A_0.method_7(num5);
            if (index >= 0)
            {
                num2 = this.short_0[num4 | (index >> 9)];
                A_0.method_8(num2 & 15);
                return (num2 >> 4);
            }
            int num6 = A_0.method_0();
            index = A_0.method_7(num6);
            num2 = this.short_0[num4 | (index >> 9)];
            if ((num2 & 15) <= num6)
            {
                A_0.method_8(num2 & 15);
                return (num2 >> 4);
            }
            return -1;
        }
        int num3 = A_0.method_0();
        index = A_0.method_7(num3);
        num2 = this.short_0[index];
        if ((num2 >= 0) && ((num2 & 15) <= num3))
        {
            A_0.method_8(num2 & 15);
            return (num2 >> 4);
        }
        return -1;
    }

    public static Class1067 smethod_0()
    {
        return class1067_0;
    }

    public static Class1067 smethod_1()
    {
        return class1067_1;
    }
}

