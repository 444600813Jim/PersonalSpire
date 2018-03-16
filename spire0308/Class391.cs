using System;

internal class Class391
{
    protected byte[] byte_0;
    protected static readonly int int_0 = 0x100;
    protected static readonly int int_1 = 0x1f3;
    protected static readonly int int_10 = (((int) 1) << int_9);
    protected static readonly int int_11 = 10;
    protected static readonly int int_12 = (((int) 1) << int_11);
    protected static readonly int int_13 = 10;
    protected static readonly int int_14 = (int_10 >> int_13);
    protected static readonly int int_15 = (int_10 << (int_11 - int_13));
    protected static readonly int int_16 = (int_0 >> 3);
    protected static readonly int int_17 = 6;
    protected static readonly int int_18 = (((int) 1) << int_17);
    protected static readonly int int_19 = (int_16 * int_18);
    protected static readonly int int_2 = 0x1eb;
    protected static readonly int int_20 = 30;
    protected static readonly int int_21 = 10;
    protected static readonly int int_22 = (((int) 1) << int_21);
    protected int int_23;
    protected static readonly int int_24 = 8;
    protected static readonly int int_25 = (((int) 1) << int_24);
    protected static readonly int int_26 = (int_21 + int_24);
    protected static readonly int int_27 = (((int) 1) << int_26);
    protected int int_28;
    protected int int_29;
    protected static readonly int int_3 = 0x1e7;
    protected int[][] int_30;
    protected int[] int_31 = new int[0x100];
    protected int[] int_32 = new int[int_0];
    protected int[] int_33 = new int[int_0];
    protected int[] int_34 = new int[int_16];
    protected static readonly int int_4 = 0x1f7;
    protected static readonly int int_5 = (3 * int_4);
    protected static readonly int int_6 = (int_0 - 1);
    protected static readonly int int_7 = 4;
    protected static readonly int int_8 = 100;
    protected static readonly int int_9 = 0x10;

    public Class391(byte[] A_0, int A_1, int A_2)
    {
        this.byte_0 = A_0;
        this.int_28 = A_1;
        this.int_29 = A_2;
        this.int_30 = new int[int_0][];
        for (int i = 0; i < int_0; i++)
        {
            int num2;
            this.int_30[i] = new int[4];
            int[] numArray = this.int_30[i];
            numArray[2] = num2 = (i << (int_7 + 8)) / int_0;
            numArray[0] = numArray[1] = num2;
            this.int_33[i] = int_10 / int_0;
            this.int_32[i] = 0;
        }
    }

    public byte[] method_0()
    {
        byte[] buffer = new byte[3 * int_0];
        int[] numArray = new int[int_0];
        for (int i = 0; i < int_0; i++)
        {
            numArray[this.int_30[i][3]] = i;
        }
        int num4 = 0;
        for (int j = 0; j < int_0; j++)
        {
            int index = numArray[j];
            buffer[num4++] = (byte) this.int_30[index][0];
            buffer[num4++] = (byte) this.int_30[index][1];
            buffer[num4++] = (byte) this.int_30[index][2];
        }
        return buffer;
    }

    public void method_1()
    {
        int num4;
        int index = 0;
        int num2 = 0;
        for (int i = 0; i < int_0; i++)
        {
            int[] numArray;
            int[] numArray2 = this.int_30[i];
            int num6 = i;
            int num5 = numArray2[1];
            num4 = i + 1;
            while (num4 < int_0)
            {
                numArray = this.int_30[num4];
                if (numArray[1] < num5)
                {
                    num6 = num4;
                    num5 = numArray[1];
                }
                num4++;
            }
            numArray = this.int_30[num6];
            if (i != num6)
            {
                num4 = numArray[0];
                numArray[0] = numArray2[0];
                numArray2[0] = num4;
                num4 = numArray[1];
                numArray[1] = numArray2[1];
                numArray2[1] = num4;
                num4 = numArray[2];
                numArray[2] = numArray2[2];
                numArray2[2] = num4;
                num4 = numArray[3];
                numArray[3] = numArray2[3];
                numArray2[3] = num4;
            }
            if (num5 != index)
            {
                this.int_31[index] = (num2 + i) >> 1;
                num4 = index + 1;
                while (num4 < num5)
                {
                    this.int_31[num4] = i;
                    num4++;
                }
                index = num5;
                num2 = i;
            }
        }
        this.int_31[index] = (num2 + int_6) >> 1;
        for (num4 = index + 1; num4 < 0x100; num4++)
        {
            this.int_31[num4] = int_6;
        }
    }

    public void method_2()
    {
        int num;
        int num11;
        if (this.int_28 < int_5)
        {
            this.int_29 = 1;
        }
        this.int_23 = 30 + ((this.int_29 - 1) / 3);
        byte[] buffer = this.byte_0;
        int index = 0;
        int num13 = this.int_28;
        int num10 = this.int_28 / (3 * this.int_29);
        int num2 = num10 / int_8;
        int num8 = int_22;
        int num12 = int_19;
        int num9 = num12 >> int_17;
        if (num9 <= 1)
        {
            num9 = 0;
        }
        for (num = 0; num < num9; num++)
        {
            this.int_34[num] = num8 * ((((num9 * num9) - (num * num)) * int_25) / (num9 * num9));
        }
        if (this.int_28 < int_5)
        {
            num11 = 3;
        }
        else if ((this.int_28 % int_1) != 0)
        {
            num11 = 3 * int_1;
        }
        else if ((this.int_28 % int_2) != 0)
        {
            num11 = 3 * int_2;
        }
        else if ((this.int_28 % int_3) != 0)
        {
            num11 = 3 * int_3;
        }
        else
        {
            num11 = 3 * int_4;
        }
        num = 0;
        while (num < num10)
        {
            int num4 = (buffer[index] & 0xff) << int_7;
            int num5 = (buffer[index + 1] & 0xff) << int_7;
            int num6 = (buffer[index + 2] & 0xff) << int_7;
            int num7 = this.method_8(num4, num5, num6);
            this.method_7(num8, num7, num4, num5, num6);
            if (num9 != 0)
            {
                this.method_6(num9, num7, num4, num5, num6);
            }
            index += num11;
            if (index >= num13)
            {
                index -= this.int_28;
            }
            num++;
            if (num2 == 0)
            {
                num2 = 1;
            }
            if ((num % num2) == 0)
            {
                num8 -= num8 / this.int_23;
                num12 -= num12 / int_20;
                num9 = num12 >> int_17;
                if (num9 <= 1)
                {
                    num9 = 0;
                }
                for (num7 = 0; num7 < num9; num7++)
                {
                    this.int_34[num7] = num8 * ((((num9 * num9) - (num7 * num7)) * int_25) / (num9 * num9));
                }
            }
        }
    }

    public int method_3(int A_0, int A_1, int A_2)
    {
        int num = 0x3e8;
        int num2 = -1;
        int index = this.int_31[A_1];
        int num4 = index - 1;
        while ((index < int_0) || (num4 >= 0))
        {
            int[] numArray;
            int num5;
            int num6;
            if (index < int_0)
            {
                numArray = this.int_30[index];
                num6 = numArray[1] - A_1;
                if (num6 >= num)
                {
                    index = int_0;
                }
                else
                {
                    index++;
                    if (num6 < 0)
                    {
                        num6 = -num6;
                    }
                    num5 = numArray[0] - A_0;
                    if (num5 < 0)
                    {
                        num5 = -num5;
                    }
                    num6 += num5;
                    if (num6 < num)
                    {
                        num5 = numArray[2] - A_2;
                        if (num5 < 0)
                        {
                            num5 = -num5;
                        }
                        num6 += num5;
                        if (num6 < num)
                        {
                            num = num6;
                            num2 = numArray[3];
                        }
                    }
                }
            }
            if (num4 >= 0)
            {
                numArray = this.int_30[num4];
                num6 = A_1 - numArray[1];
                if (num6 >= num)
                {
                    num4 = -1;
                }
                else
                {
                    num4--;
                    if (num6 < 0)
                    {
                        num6 = -num6;
                    }
                    num5 = numArray[0] - A_0;
                    if (num5 < 0)
                    {
                        num5 = -num5;
                    }
                    num6 += num5;
                    if (num6 < num)
                    {
                        num5 = numArray[2] - A_2;
                        if (num5 < 0)
                        {
                            num5 = -num5;
                        }
                        num6 += num5;
                        if (num6 < num)
                        {
                            num = num6;
                            num2 = numArray[3];
                        }
                    }
                }
            }
        }
        return num2;
    }

    public byte[] method_4()
    {
        this.method_2();
        this.method_5();
        this.method_1();
        return this.method_0();
    }

    public void method_5()
    {
        for (int i = 0; i < int_0; i++)
        {
            this.int_30[i][0] = this.int_30[i][0] >> int_7;
            this.int_30[i][1] = this.int_30[i][1] >> int_7;
            this.int_30[i][2] = this.int_30[i][2] >> int_7;
            this.int_30[i][3] = i;
        }
    }

    protected void method_6(int A_0, int A_1, int A_2, int A_3, int A_4)
    {
        int num = A_1 - A_0;
        if (num < -1)
        {
            num = -1;
        }
        int num2 = A_1 + A_0;
        if (num2 > int_0)
        {
            num2 = int_0;
        }
        int num4 = A_1 + 1;
        int num5 = A_1 - 1;
        int num6 = 1;
        while ((num4 < num2) || (num5 > num))
        {
            int[] numArray;
            int num3 = this.int_34[num6++];
            if (num4 < num2)
            {
                numArray = this.int_30[num4++];
                try
                {
                    numArray[0] -= (num3 * (numArray[0] - A_2)) / int_27;
                    numArray[1] -= (num3 * (numArray[1] - A_3)) / int_27;
                    numArray[2] -= (num3 * (numArray[2] - A_4)) / int_27;
                }
                catch (Exception)
                {
                }
            }
            if (num5 > num)
            {
                numArray = this.int_30[num5--];
                try
                {
                    numArray[0] -= (num3 * (numArray[0] - A_2)) / int_27;
                    numArray[1] -= (num3 * (numArray[1] - A_3)) / int_27;
                    numArray[2] -= (num3 * (numArray[2] - A_4)) / int_27;
                }
                catch (Exception)
                {
                }
            }
        }
    }

    protected void method_7(int A_0, int A_1, int A_2, int A_3, int A_4)
    {
        int[] numArray = this.int_30[A_1];
        numArray[0] -= (A_0 * (numArray[0] - A_2)) / int_22;
        numArray[1] -= (A_0 * (numArray[1] - A_3)) / int_22;
        numArray[2] -= (A_0 * (numArray[2] - A_4)) / int_22;
    }

    protected int method_8(int A_0, int A_1, int A_2)
    {
        int num = 0x7fffffff;
        int num2 = 0x7fffffff;
        int index = -1;
        int num4 = -1;
        for (int i = 0; i < int_0; i++)
        {
            int[] numArray = this.int_30[i];
            int num6 = numArray[0] - A_0;
            if (num6 < 0)
            {
                num6 = -num6;
            }
            int num8 = numArray[1] - A_1;
            if (num8 < 0)
            {
                num8 = -num8;
            }
            num6 += num8;
            num8 = numArray[2] - A_2;
            if (num8 < 0)
            {
                num8 = -num8;
            }
            num6 += num8;
            if (num6 < num)
            {
                num = num6;
                index = i;
            }
            int num7 = num6 - (this.int_32[i] >> (int_9 - int_7));
            if (num7 < num2)
            {
                num2 = num7;
                num4 = i;
            }
            int num9 = this.int_33[i] >> int_13;
            this.int_33[i] -= num9;
            this.int_32[i] += num9 << int_11;
        }
        this.int_33[index] += int_14;
        this.int_32[index] -= int_15;
        return num4;
    }
}

