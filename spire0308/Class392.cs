using System;
using System.IO;

internal class Class392
{
    private bool bool_0;
    private byte[] byte_0;
    private byte[] byte_1 = new byte[0x100];
    private static readonly int int_0 = -1;
    private int int_1;
    private int int_10;
    private int int_11 = (((int) 1) << int_6);
    private int[] int_12 = new int[int_7];
    private int[] int_13 = new int[int_7];
    private int int_14 = int_7;
    private int int_15;
    private int int_16;
    private int int_17;
    private int int_18;
    private int int_19;
    private int int_2;
    private int int_20;
    private int[] int_21 = new int[] { 
        0, 1, 3, 7, 15, 0x1f, 0x3f, 0x7f, 0xff, 0x1ff, 0x3ff, 0x7ff, 0xfff, 0x1fff, 0x3fff, 0x7fff, 
        0xffff
     };
    private int int_22;
    private int int_3;
    private int int_4;
    private int int_5;
    private static readonly int int_6 = 12;
    private static readonly int int_7 = 0x138b;
    private int int_8;
    private int int_9 = int_6;

    public Class392(int A_0, int A_1, byte[] A_2, int A_3)
    {
        this.int_1 = A_0;
        this.int_2 = A_1;
        this.byte_0 = A_2;
        this.int_3 = Math.Max(2, A_3);
    }

    private void method_0(byte A_0, Stream A_1)
    {
        this.byte_1[this.int_22++] = A_0;
        if (this.int_22 >= 0xfe)
        {
            this.method_5(A_1);
        }
    }

    private void method_1(Stream A_0)
    {
        this.method_2(this.int_14);
        this.int_15 = this.int_17 + 2;
        this.bool_0 = true;
        this.method_8(this.int_17, A_0);
    }

    private void method_2(int A_0)
    {
        for (int i = 0; i < A_0; i++)
        {
            this.int_12[i] = -1;
        }
    }

    private void method_3(int A_0, Stream A_1)
    {
        int num4;
        this.int_16 = A_0;
        this.bool_0 = false;
        this.int_8 = this.int_16;
        this.int_10 = this.method_6(this.int_8);
        this.int_17 = ((int) 1) << (A_0 - 1);
        this.int_18 = this.int_17 + 1;
        this.int_15 = this.int_17 + 2;
        this.int_22 = 0;
        int num = this.method_7();
        int num2 = 0;
        int num3 = this.int_14;
        while (num3 < 0x10000)
        {
            num2++;
            num3 *= 2;
        }
        num2 = 8 - num2;
        int num6 = this.int_14;
        this.method_2(num6);
        this.method_8(this.int_17, A_1);
        while ((num4 = this.method_7()) != int_0)
        {
            num3 = (num4 << this.int_9) + num;
            int index = (num4 << num2) ^ num;
            if (this.int_12[index] == num3)
            {
                num = this.int_13[index];
                continue;
            }
            if (this.int_12[index] < 0)
            {
                goto Label_0132;
            }
            int num8 = num6 - index;
            if (index == 0)
            {
                num8 = 1;
            }
            goto Label_0119;
        Label_00F4:
            if (this.int_12[index] == num3)
            {
                goto Label_0126;
            }
            if (this.int_12[index] >= 0)
            {
                goto Label_0119;
            }
            goto Label_0132;
        Label_0110:
            index += num6;
            goto Label_00F4;
        Label_0119:
            if ((index -= num8) >= 0)
            {
                goto Label_00F4;
            }
            goto Label_0110;
        Label_0126:
            num = this.int_13[index];
            continue;
        Label_0132:
            this.method_8(num, A_1);
            num = num4;
            if (this.int_15 < this.int_11)
            {
                this.int_13[index] = this.int_15++;
                this.int_12[index] = num3;
            }
            else
            {
                this.method_1(A_1);
            }
        }
        this.method_8(num, A_1);
        this.method_8(this.int_18, A_1);
    }

    public void method_4(Stream A_0)
    {
        A_0.WriteByte(Convert.ToByte(this.int_3));
        this.int_4 = this.int_1 * this.int_2;
        this.int_5 = 0;
        this.method_3(this.int_3 + 1, A_0);
        A_0.WriteByte(0);
    }

    private void method_5(Stream A_0)
    {
        if (this.int_22 > 0)
        {
            A_0.WriteByte(Convert.ToByte(this.int_22));
            A_0.Write(this.byte_1, 0, this.int_22);
            this.int_22 = 0;
        }
    }

    private int method_6(int A_0)
    {
        return ((((int) 1) << A_0) - 1);
    }

    private int method_7()
    {
        if (this.int_4 == 0)
        {
            return int_0;
        }
        this.int_4--;
        int num = this.int_5 + 1;
        if (num < this.byte_0.GetUpperBound(0))
        {
            byte num3 = this.byte_0[this.int_5++];
            return (num3 & 0xff);
        }
        return 0xff;
    }

    private void method_8(int A_0, Stream A_1)
    {
        this.int_19 &= this.int_21[this.int_20];
        if (this.int_20 > 0)
        {
            this.int_19 |= A_0 << this.int_20;
        }
        else
        {
            this.int_19 = A_0;
        }
        this.int_20 += this.int_8;
        while (this.int_20 >= 8)
        {
            this.method_0((byte) (this.int_19 & 0xff), A_1);
            this.int_19 = this.int_19 >> 8;
            this.int_20 -= 8;
        }
        if ((this.int_15 > this.int_10) || this.bool_0)
        {
            if (this.bool_0)
            {
                this.int_10 = this.method_6(this.int_8 = this.int_16);
                this.bool_0 = false;
            }
            else
            {
                this.int_8++;
                if (this.int_8 == this.int_9)
                {
                    this.int_10 = this.int_11;
                }
                else
                {
                    this.int_10 = this.method_6(this.int_8);
                }
            }
        }
        if (A_0 == this.int_18)
        {
            while (this.int_20 > 0)
            {
                this.method_0((byte) (this.int_19 & 0xff), A_1);
                this.int_19 = this.int_19 >> 8;
                this.int_20 -= 8;
            }
            this.method_5(A_1);
        }
    }
}

