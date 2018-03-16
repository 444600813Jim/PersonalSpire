using System;

internal class Class790
{
    private const byte byte_0 = 3;
    private const byte byte_1 = 7;
    private const byte byte_10 = 11;
    private const byte byte_11 = 15;
    private readonly byte[] byte_12 = new byte[0x40];
    private readonly byte[] byte_13 = new byte[0x10];
    private const byte byte_2 = 11;
    private const byte byte_3 = 0x13;
    private const byte byte_4 = 3;
    private const byte byte_5 = 5;
    private const byte byte_6 = 9;
    private const byte byte_7 = 13;
    private const byte byte_8 = 3;
    private const byte byte_9 = 9;
    private readonly uint[] uint_0 = new uint[2];
    private readonly uint[] uint_1 = new uint[4];
    private readonly uint[] uint_2 = new uint[0x10];

    public Class790()
    {
        this.method_2();
    }

    public byte[] method_0(byte[] A_0)
    {
        return this.method_1(A_0, 0, A_0.Length);
    }

    public byte[] method_1(byte[] A_0, int A_1, int A_2)
    {
        this.method_3(A_0, A_1, A_2);
        return this.method_4();
    }

    private void method_10(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5)
    {
        A_0 += this.method_6(A_1, A_2, A_3) + A_4;
        A_0 = this.method_9(A_0, A_5);
    }

    private void method_11(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5)
    {
        A_0 += (this.method_7(A_1, A_2, A_3) + A_4) + 0x5a827999;
        A_0 = this.method_9(A_0, A_5);
    }

    private void method_12(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5)
    {
        A_0 += (this.method_8(A_1, A_2, A_3) + A_4) + 0x6ed9eba1;
        A_0 = this.method_9(A_0, A_5);
    }

    private void method_13(byte[] A_0, uint[] A_1)
    {
        int index = 0;
        for (int i = 0; i < A_0.Length; i += 4)
        {
            A_0[i] = (byte) A_1[index];
            A_0[i + 1] = (byte) (A_1[index] >> 8);
            A_0[i + 2] = (byte) (A_1[index] >> 0x10);
            A_0[i + 3] = (byte) (A_1[index] >> 0x18);
            index++;
        }
    }

    private void method_14(uint[] A_0, byte[] A_1, int A_2)
    {
        int index = 0;
        for (int i = A_2; index < A_0.Length; i += 4)
        {
            A_0[index] = (uint) (((A_1[i] | (A_1[i + 1] << 8)) | (A_1[i + 2] << 0x10)) | (A_1[i + 3] << 0x18));
            index++;
        }
    }

    private void method_15(uint[] A_0, byte[] A_1, int A_2)
    {
        uint num = A_0[0];
        uint num2 = A_0[1];
        uint num3 = A_0[2];
        uint num4 = A_0[3];
        this.method_14(this.uint_2, A_1, A_2);
        this.method_10(ref num, num2, num3, num4, this.uint_2[0], 3);
        this.method_10(ref num4, num, num2, num3, this.uint_2[1], 7);
        this.method_10(ref num3, num4, num, num2, this.uint_2[2], 11);
        this.method_10(ref num2, num3, num4, num, this.uint_2[3], 0x13);
        this.method_10(ref num, num2, num3, num4, this.uint_2[4], 3);
        this.method_10(ref num4, num, num2, num3, this.uint_2[5], 7);
        this.method_10(ref num3, num4, num, num2, this.uint_2[6], 11);
        this.method_10(ref num2, num3, num4, num, this.uint_2[7], 0x13);
        this.method_10(ref num, num2, num3, num4, this.uint_2[8], 3);
        this.method_10(ref num4, num, num2, num3, this.uint_2[9], 7);
        this.method_10(ref num3, num4, num, num2, this.uint_2[10], 11);
        this.method_10(ref num2, num3, num4, num, this.uint_2[11], 0x13);
        this.method_10(ref num, num2, num3, num4, this.uint_2[12], 3);
        this.method_10(ref num4, num, num2, num3, this.uint_2[13], 7);
        this.method_10(ref num3, num4, num, num2, this.uint_2[14], 11);
        this.method_10(ref num2, num3, num4, num, this.uint_2[15], 0x13);
        this.method_11(ref num, num2, num3, num4, this.uint_2[0], 3);
        this.method_11(ref num4, num, num2, num3, this.uint_2[4], 5);
        this.method_11(ref num3, num4, num, num2, this.uint_2[8], 9);
        this.method_11(ref num2, num3, num4, num, this.uint_2[12], 13);
        this.method_11(ref num, num2, num3, num4, this.uint_2[1], 3);
        this.method_11(ref num4, num, num2, num3, this.uint_2[5], 5);
        this.method_11(ref num3, num4, num, num2, this.uint_2[9], 9);
        this.method_11(ref num2, num3, num4, num, this.uint_2[13], 13);
        this.method_11(ref num, num2, num3, num4, this.uint_2[2], 3);
        this.method_11(ref num4, num, num2, num3, this.uint_2[6], 5);
        this.method_11(ref num3, num4, num, num2, this.uint_2[10], 9);
        this.method_11(ref num2, num3, num4, num, this.uint_2[14], 13);
        this.method_11(ref num, num2, num3, num4, this.uint_2[3], 3);
        this.method_11(ref num4, num, num2, num3, this.uint_2[7], 5);
        this.method_11(ref num3, num4, num, num2, this.uint_2[11], 9);
        this.method_11(ref num2, num3, num4, num, this.uint_2[15], 13);
        this.method_12(ref num, num2, num3, num4, this.uint_2[0], 3);
        this.method_12(ref num4, num, num2, num3, this.uint_2[8], 9);
        this.method_12(ref num3, num4, num, num2, this.uint_2[4], 11);
        this.method_12(ref num2, num3, num4, num, this.uint_2[12], 15);
        this.method_12(ref num, num2, num3, num4, this.uint_2[2], 3);
        this.method_12(ref num4, num, num2, num3, this.uint_2[10], 9);
        this.method_12(ref num3, num4, num, num2, this.uint_2[6], 11);
        this.method_12(ref num2, num3, num4, num, this.uint_2[14], 15);
        this.method_12(ref num, num2, num3, num4, this.uint_2[1], 3);
        this.method_12(ref num4, num, num2, num3, this.uint_2[9], 9);
        this.method_12(ref num3, num4, num, num2, this.uint_2[5], 11);
        this.method_12(ref num2, num3, num4, num, this.uint_2[13], 15);
        this.method_12(ref num, num2, num3, num4, this.uint_2[3], 3);
        this.method_12(ref num4, num, num2, num3, this.uint_2[11], 9);
        this.method_12(ref num3, num4, num, num2, this.uint_2[7], 11);
        this.method_12(ref num2, num3, num4, num, this.uint_2[15], 15);
        A_0[0] += num;
        A_0[1] += num2;
        A_0[2] += num3;
        A_0[3] += num4;
    }

    private void method_2()
    {
        this.uint_0[0] = 0;
        this.uint_0[1] = 0;
        this.uint_1[0] = 0x67452301;
        this.uint_1[1] = 0xefcdab89;
        this.uint_1[2] = 0x98badcfe;
        this.uint_1[3] = 0x10325476;
        Array.Clear(this.byte_12, 0, 0x40);
        Array.Clear(this.uint_2, 0, 0x10);
    }

    protected void method_3(byte[] A_0, int A_1, int A_2)
    {
        int destinationIndex = ((int) (this.uint_0[0] >> 3)) & 0x3f;
        this.uint_0[0] += (uint) (A_2 << 3);
        if (this.uint_0[0] < (A_2 << 3))
        {
            this.uint_0[1]++;
        }
        this.uint_0[1] += (uint) (A_2 >> 0x1d);
        int length = 0x40 - destinationIndex;
        int num2 = 0;
        if (A_2 >= length)
        {
            Array.Copy(A_0, A_1, this.byte_12, destinationIndex, length);
            this.method_15(this.uint_1, this.byte_12, 0);
            num2 = length;
            while ((num2 + 0x3f) < A_2)
            {
                this.method_15(this.uint_1, A_0, num2);
                num2 += 0x40;
            }
            destinationIndex = 0;
        }
        Array.Copy(A_0, A_1 + num2, this.byte_12, destinationIndex, A_2 - num2);
    }

    protected byte[] method_4()
    {
        byte[] buffer = new byte[8];
        this.method_13(buffer, this.uint_0);
        uint num = (this.uint_0[0] >> 3) & 0x3f;
        int num2 = (num < 0x38) ? (0x38 - ((int) num)) : (120 - ((int) num));
        this.method_3(this.method_5(num2), 0, num2);
        this.method_3(buffer, 0, 8);
        this.method_13(this.byte_13, this.uint_1);
        this.method_2();
        return this.byte_13;
    }

    private byte[] method_5(int A_0)
    {
        if (A_0 > 0)
        {
            byte[] buffer = new byte[A_0];
            buffer[0] = 0x80;
            return buffer;
        }
        return null;
    }

    private uint method_6(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 & A_1) | (~A_0 & A_2));
    }

    private uint method_7(uint A_0, uint A_1, uint A_2)
    {
        return (((A_0 & A_1) | (A_0 & A_2)) | (A_1 & A_2));
    }

    private uint method_8(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 ^ A_1) ^ A_2);
    }

    private uint method_9(uint A_0, byte A_1)
    {
        return ((A_0 << A_1) | (A_0 >> (0x20 - A_1)));
    }
}

