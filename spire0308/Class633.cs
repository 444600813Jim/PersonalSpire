using System;
using System.Text;

internal abstract class Class633 : Decoder
{
    internal byte[] byte_0 = new byte[4];
    internal int int_0;

    protected Class633()
    {
    }

    internal static char smethod_0(uint A_0)
    {
        byte num = (byte) (0xd7c0 + (A_0 >> 10));
        byte num2 = (byte) (0xdc00 | (A_0 & 0x3ff));
        return (char) ((num2 << 8) | num);
    }

    int Decoder.GetCharCount(byte[] A_0, int A_1, int A_2)
    {
        return ((A_2 + this.int_0) / 4);
    }

    int Decoder.GetChars(byte[] A_0, int A_1, int A_2, char[] A_3, int A_4)
    {
        int index = this.int_0;
        if (this.int_0 > 0)
        {
            while (index < 4)
            {
                this.byte_0[index] = A_0[A_1];
                A_1++;
                A_2--;
                index++;
            }
            index = 1;
            this.vmethod_0(this.byte_0, 0, 4, A_3, A_4);
            A_4++;
        }
        else
        {
            index = 0;
        }
        index = this.vmethod_0(A_0, A_1, A_2, A_3, A_4) + index;
        int num2 = (this.int_0 + A_2) % 4;
        A_2 += A_1;
        A_1 = A_2 - num2;
        this.int_0 = 0;
        if (A_1 >= 0)
        {
            while (A_1 < A_2)
            {
                this.byte_0[this.int_0] = A_0[A_1];
                this.int_0++;
                A_1++;
            }
        }
        return index;
    }

    internal abstract int vmethod_0(byte[] A_0, int A_1, int A_2, char[] A_3, int A_4);
}

