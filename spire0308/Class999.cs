using Spire.Doc;
using System;

internal class Class999
{
    private byte[] byte_0;
    private Class1113 class1113_0;
    private int[] int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private short[] short_0;
    private short[] short_1;

    public Class999(Class1113 A_0, int A_1, int A_2, int A_3)
    {
        this.class1113_0 = A_0;
        this.int_1 = A_2;
        this.int_3 = A_3;
        this.short_0 = new short[A_1];
        this.int_0 = new int[A_3];
    }

    public void method_0()
    {
        for (int i = 0; i < this.short_0.Length; i++)
        {
            this.short_0[i] = 0;
        }
        this.short_1 = null;
        this.byte_0 = null;
    }

    public void method_1(int A_0)
    {
        this.class1113_0.method_30(this.short_1[A_0] & 0xffff, this.byte_0[A_0]);
    }

    public int method_10()
    {
        return this.int_2;
    }

    public byte[] method_11()
    {
        return this.byte_0;
    }

    public short[] method_12()
    {
        return this.short_0;
    }

    public void method_2()
    {
        for (int i = 0; i < this.short_0.Length; i++)
        {
        }
    }

    public void method_3(short[] A_0, byte[] A_1)
    {
        this.short_1 = (short[]) A_0.Clone();
        this.byte_0 = (byte[]) A_1.Clone();
    }

    public void method_4()
    {
        int[] numArray = new int[this.int_3];
        this.short_1 = new short[this.int_2];
        int num = 0;
        for (int i = 0; i < this.int_3; i++)
        {
            numArray[i] = num;
            num += this.int_0[i] << (15 - i);
        }
        for (int j = 0; j < this.int_2; j++)
        {
            int num4 = this.byte_0[j];
            if (num4 > 0)
            {
                this.short_1[j] = Class1112.smethod_0(numArray[num4 - 1]);
                numArray[num4 - 1] += ((int) 1) << (0x10 - num4);
            }
        }
    }

    private void method_5(int[] A_0)
    {
        this.byte_0 = new byte[this.short_0.Length];
        int num = A_0.Length / 2;
        int num2 = (num + 1) / 2;
        int num3 = 0;
        for (int i = 0; i < this.int_3; i++)
        {
            this.int_0[i] = 0;
        }
        int[] numArray = new int[num];
        numArray[num - 1] = 0;
        for (int j = num - 1; j >= 0; j--)
        {
            int index = (2 * j) + 1;
            if (A_0[index] != -1)
            {
                int num8 = numArray[j] + 1;
                if (num8 > this.int_3)
                {
                    num8 = this.int_3;
                    num3++;
                }
                numArray[A_0[index - 1]] = numArray[A_0[index]] = num8;
            }
            else
            {
                int num13 = numArray[j];
                this.int_0[num13 - 1]++;
                this.byte_0[A_0[index - 1]] = (byte) numArray[j];
            }
        }
        if (num3 != 0)
        {
            int num7 = this.int_3 - 1;
            while (true)
            {
                while (this.int_0[--num7] == 0)
                {
                }
                do
                {
                    this.int_0[num7]--;
                    this.int_0[++num7]++;
                    num3 -= ((int) 1) << ((this.int_3 - 1) - num7);
                }
                while ((num3 > 0) && (num7 < (this.int_3 - 1)));
                if (num3 <= 0)
                {
                    this.int_0[this.int_3 - 1] += num3;
                    this.int_0[this.int_3 - 2] -= num3;
                    int num5 = 2 * num2;
                    for (int k = this.int_3; k != 0; k--)
                    {
                        int num9 = this.int_0[k - 1];
                        while (num9 > 0)
                        {
                            int num14 = 2 * A_0[num5++];
                            if (A_0[num14 + 1] == -1)
                            {
                                this.byte_0[A_0[num14]] = (byte) k;
                                num9--;
                            }
                        }
                    }
                    return;
                }
            }
        }
    }

    public void method_6()
    {
        int num = 0x13;
        int length = this.short_0.Length;
        int[] numArray = new int[length];
        int num3 = 0;
        int num4 = 0;
        for (int i = 0; i < length; i++)
        {
            int num15 = this.short_0[i];
            if (num15 != 0)
            {
                int index = num3++;
                while (index > 0)
                {
                    int num20;
                    if (this.short_0[numArray[num20 = (index - 1) / 2]] <= num15)
                    {
                        break;
                    }
                    numArray[index] = numArray[num20];
                    index = num20;
                }
                numArray[index] = i;
                num4 = i;
            }
        }
        while (num3 < 2)
        {
            numArray[num3++] = (num4 < 2) ? ++num4 : 0;
        }
        this.int_2 = Math.Max(num4 + 1, this.int_1);
        int num9 = num3;
        int[] numArray3 = new int[(4 * num3) - 2];
        int[] numArray2 = new int[(2 * num3) - 1];
        for (int j = 0; j < num3; j++)
        {
            int num17 = numArray[j];
            int num18 = 2 * j;
            numArray3[num18] = num17;
            numArray3[num18 + 1] = -1;
            numArray2[j] = this.short_0[num17] << 8;
            numArray[j] = j;
        }
        while (true)
        {
            int num10 = numArray[0];
            int num7 = numArray[--num3];
            int num12 = numArray2[num7];
            int num13 = 0;
            int num6 = 1;
            while (num6 < num3)
            {
                if (((num6 + 1) < num3) && (numArray2[numArray[num6]] > numArray2[numArray[num6 + 1]]))
                {
                    num6++;
                }
                numArray[num13] = numArray[num6];
                num13 = num6;
                num6 = (num13 * 2) + 1;
            }
            while ((num6 = num13) > 0)
            {
                if (numArray2[numArray[num13 = (num6 - 1) / 2]] <= num12)
                {
                    break;
                }
                numArray[num6] = numArray[num13];
            }
            numArray[num6] = num7;
            int num8 = numArray[0];
            num7 = num9++;
            numArray3[2 * num7] = num10;
            numArray3[(2 * num7) + 1] = num8;
            int num11 = Math.Min((int) (numArray2[num10] & 0xff), (int) (numArray2[num8] & 0xff));
            numArray2[num7] = num12 = ((numArray2[num10] + numArray2[num8]) - num11) + 1;
            num13 = 0;
            num6 = 1;
            while (num6 < num3)
            {
                if (((num6 + 1) < num3) && (numArray2[numArray[num6]] > numArray2[numArray[num6 + 1]]))
                {
                    num6++;
                }
                numArray[num13] = numArray[num6];
                num13 = num6;
                num6 = (num13 * 2) + 1;
            }
            while ((num6 = num13) > 0)
            {
                if (numArray2[numArray[num13 = (num6 - 1) / 2]] <= num12)
                {
                    break;
                }
                numArray[num6] = numArray[num13];
            }
            numArray[num6] = num7;
            if (num3 <= 1)
            {
                if (numArray[0] != ((numArray3.Length / 2) - 1))
                {
                    throw new ApplicationException(BookmarkStart.b("焸帺尼伾慀⩂⭄ㅆ⡈㥊⑌⹎㽐❒畔⅖じ㑚ㅜ㹞ᕠ٢Ť", num));
                }
                this.method_5(numArray3);
                return;
            }
        }
    }

    public int method_7()
    {
        int num = 0;
        for (int i = 0; i < this.short_0.Length; i++)
        {
            num += this.short_0[i] * this.byte_0[i];
        }
        return num;
    }

    public void method_8(Class999 A_0)
    {
        int index = -1;
        int num2 = 0;
        while (num2 < this.int_2)
        {
            int num4;
            int num5;
            int num3 = 1;
            int num6 = this.byte_0[num2];
            if (num6 == 0)
            {
                num5 = 0x8a;
                num4 = 3;
            }
            else
            {
                num5 = 6;
                num4 = 3;
                if (index != num6)
                {
                    A_0.short_0[num6] = (short) (A_0.short_0[num6] + 1);
                    num3 = 0;
                }
            }
            index = num6;
            num2++;
            while (num2 < this.int_2)
            {
                if (index != this.byte_0[num2])
                {
                    break;
                }
                num2++;
                if (++num3 >= num5)
                {
                    break;
                }
            }
            if (num3 < num4)
            {
                A_0.short_0[index] = (short) (A_0.short_0[index] + ((short) num3));
            }
            else
            {
                if (index != 0)
                {
                    A_0.short_0[0x10] = (short) (A_0.short_0[0x10] + 1);
                    continue;
                }
                if (num3 <= 10)
                {
                    A_0.short_0[0x11] = (short) (A_0.short_0[0x11] + 1);
                    continue;
                }
                A_0.short_0[0x12] = (short) (A_0.short_0[0x12] + 1);
            }
        }
    }

    public void method_9(Class999 A_0)
    {
        int num = -1;
        int index = 0;
        while (index < this.int_2)
        {
            int num4;
            int num5;
            int num3 = 1;
            int num6 = this.byte_0[index];
            if (num6 == 0)
            {
                num4 = 0x8a;
                num5 = 3;
            }
            else
            {
                num4 = 6;
                num5 = 3;
                if (num != num6)
                {
                    A_0.method_1(num6);
                    num3 = 0;
                }
            }
            num = num6;
            index++;
            while (index < this.int_2)
            {
                if (num != this.byte_0[index])
                {
                    break;
                }
                index++;
                if (++num3 >= num4)
                {
                    break;
                }
            }
            if (num3 < num5)
            {
                while (num3-- > 0)
                {
                    A_0.method_1(num);
                }
            }
            else if (num != 0)
            {
                A_0.method_1(0x10);
                this.class1113_0.method_30(num3 - 3, 2);
            }
            else
            {
                if (num3 <= 10)
                {
                    A_0.method_1(0x11);
                    this.class1113_0.method_30(num3 - 3, 3);
                    continue;
                }
                A_0.method_1(0x12);
                this.class1113_0.method_30(num3 - 11, 7);
            }
        }
    }
}

