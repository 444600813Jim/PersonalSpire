using Spire.Doc;
using System;

internal class Class803
{
    private readonly byte[] byte_0 = new byte[0x40];
    private byte[] byte_1;
    private const int int_0 = 0x40;
    private int int_1;
    private long long_0;
    private readonly uint[] uint_0 = new uint[5];
    private readonly uint[] uint_1 = new uint[80];

    public Class803()
    {
        this.method_3();
    }

    public byte[] method_0(byte[] A_0)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀨䔪崬娮䔰", num));
        }
        this.method_1(A_0, 0, A_0.Length);
        this.byte_1 = this.method_2();
        this.method_3();
        return this.byte_1;
    }

    private void method_1(byte[] A_0, int A_1, int A_2)
    {
        int num;
        if (this.int_1 != 0)
        {
            if (A_2 < (0x40 - this.int_1))
            {
                Array.Copy(A_0, A_1, this.byte_0, this.int_1, A_2);
                this.int_1 += A_2;
                return;
            }
            num = 0x40 - this.int_1;
            Array.Copy(A_0, A_1, this.byte_0, this.int_1, num);
            this.method_4(this.byte_0, 0);
            this.int_1 = 0;
            A_1 += num;
            A_2 -= num;
        }
        for (num = 0; num < (A_2 - (A_2 % 0x40)); num += 0x40)
        {
            this.method_4(A_0, A_1 + num);
        }
        if ((A_2 % 0x40) != 0)
        {
            Array.Copy(A_0, (A_2 - (A_2 % 0x40)) + A_1, this.byte_0, 0, A_2 % 0x40);
            this.int_1 = A_2 % 0x40;
        }
    }

    private byte[] method_2()
    {
        byte[] buffer = new byte[20];
        this.method_5(this.byte_0, 0, this.int_1);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                buffer[(i * 4) + j] = (byte) (this.uint_0[i] >> (8 * (3 - j)));
            }
        }
        return buffer;
    }

    private void method_3()
    {
        this.long_0 = 0L;
        this.int_1 = 0;
        this.uint_0[0] = 0x67452301;
        this.uint_0[1] = 0xefcdab89;
        this.uint_0[2] = 0x98badcfe;
        this.uint_0[3] = 0x10325476;
        this.uint_0[4] = 0xc3d2e1f0;
    }

    private void method_4(byte[] A_0, int A_1)
    {
        int num;
        this.long_0 += 0x40L;
        for (num = 0; num < 0x10; num++)
        {
            int index = A_1 + (4 * num);
            this.uint_1[num] = (uint) ((((A_0[index] << 0x18) | (A_0[index + 1] << 0x10)) | (A_0[index + 2] << 8)) | A_0[index + 3]);
        }
        for (num = 0x10; num < 80; num++)
        {
            uint num2 = ((this.uint_1[num - 3] ^ this.uint_1[num - 8]) ^ this.uint_1[num - 14]) ^ this.uint_1[num - 0x10];
            uint num3 = num2 << 1;
            uint num4 = num2 >> 0x1f;
            this.uint_1[num] = num3 | num4;
        }
        uint num6 = this.uint_0[0];
        uint num7 = this.uint_0[1];
        uint num8 = this.uint_0[2];
        uint num9 = this.uint_0[3];
        uint num10 = this.uint_0[4];
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num8 ^ num9) & num7) ^ num9)) + 0x5a827999) + this.uint_1[0];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num7 ^ num8) & num6) ^ num8)) + 0x5a827999) + this.uint_1[1];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num6 ^ num7) & num10) ^ num7)) + 0x5a827999) + this.uint_1[2];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num10 ^ num6) & num9) ^ num6)) + 0x5a827999) + this.uint_1[3];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num9 ^ num10) & num8) ^ num10)) + 0x5a827999) + this.uint_1[4];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num8 ^ num9) & num7) ^ num9)) + 0x5a827999) + this.uint_1[5];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num7 ^ num8) & num6) ^ num8)) + 0x5a827999) + this.uint_1[6];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num6 ^ num7) & num10) ^ num7)) + 0x5a827999) + this.uint_1[7];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num10 ^ num6) & num9) ^ num6)) + 0x5a827999) + this.uint_1[8];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num9 ^ num10) & num8) ^ num10)) + 0x5a827999) + this.uint_1[9];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num8 ^ num9) & num7) ^ num9)) + 0x5a827999) + this.uint_1[10];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num7 ^ num8) & num6) ^ num8)) + 0x5a827999) + this.uint_1[11];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num6 ^ num7) & num10) ^ num7)) + 0x5a827999) + this.uint_1[12];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num10 ^ num6) & num9) ^ num6)) + 0x5a827999) + this.uint_1[13];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num9 ^ num10) & num8) ^ num10)) + 0x5a827999) + this.uint_1[14];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num8 ^ num9) & num7) ^ num9)) + 0x5a827999) + this.uint_1[15];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num7 ^ num8) & num6) ^ num8)) + 0x5a827999) + this.uint_1[0x10];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num6 ^ num7) & num10) ^ num7)) + 0x5a827999) + this.uint_1[0x11];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num10 ^ num6) & num9) ^ num6)) + 0x5a827999) + this.uint_1[0x12];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num9 ^ num10) & num8) ^ num10)) + 0x5a827999) + this.uint_1[0x13];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0x6ed9eba1) + this.uint_1[20];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0x6ed9eba1) + this.uint_1[0x15];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0x6ed9eba1) + this.uint_1[0x16];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0x6ed9eba1) + this.uint_1[0x17];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0x6ed9eba1) + this.uint_1[0x18];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0x6ed9eba1) + this.uint_1[0x19];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0x6ed9eba1) + this.uint_1[0x1a];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0x6ed9eba1) + this.uint_1[0x1b];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0x6ed9eba1) + this.uint_1[0x1c];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0x6ed9eba1) + this.uint_1[0x1d];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0x6ed9eba1) + this.uint_1[30];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0x6ed9eba1) + this.uint_1[0x1f];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0x6ed9eba1) + this.uint_1[0x20];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0x6ed9eba1) + this.uint_1[0x21];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0x6ed9eba1) + this.uint_1[0x22];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0x6ed9eba1) + this.uint_1[0x23];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0x6ed9eba1) + this.uint_1[0x24];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0x6ed9eba1) + this.uint_1[0x25];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0x6ed9eba1) + this.uint_1[0x26];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0x6ed9eba1) + this.uint_1[0x27];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num7 & num8) | (num7 & num9)) | (num8 & num9))) + 0x8f1bbcdc) + this.uint_1[40];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num6 & num7) | (num6 & num8)) | (num7 & num8))) + 0x8f1bbcdc) + this.uint_1[0x29];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num10 & num6) | (num10 & num7)) | (num6 & num7))) + 0x8f1bbcdc) + this.uint_1[0x2a];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num9 & num10) | (num9 & num6)) | (num10 & num6))) + 0x8f1bbcdc) + this.uint_1[0x2b];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num8 & num9) | (num8 & num10)) | (num9 & num10))) + 0x8f1bbcdc) + this.uint_1[0x2c];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num7 & num8) | (num7 & num9)) | (num8 & num9))) + 0x8f1bbcdc) + this.uint_1[0x2d];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num6 & num7) | (num6 & num8)) | (num7 & num8))) + 0x8f1bbcdc) + this.uint_1[0x2e];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num10 & num6) | (num10 & num7)) | (num6 & num7))) + 0x8f1bbcdc) + this.uint_1[0x2f];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num9 & num10) | (num9 & num6)) | (num10 & num6))) + 0x8f1bbcdc) + this.uint_1[0x30];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num8 & num9) | (num8 & num10)) | (num9 & num10))) + 0x8f1bbcdc) + this.uint_1[0x31];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num7 & num8) | (num7 & num9)) | (num8 & num9))) + 0x8f1bbcdc) + this.uint_1[50];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num6 & num7) | (num6 & num8)) | (num7 & num8))) + 0x8f1bbcdc) + this.uint_1[0x33];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num10 & num6) | (num10 & num7)) | (num6 & num7))) + 0x8f1bbcdc) + this.uint_1[0x34];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num9 & num10) | (num9 & num6)) | (num10 & num6))) + 0x8f1bbcdc) + this.uint_1[0x35];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num8 & num9) | (num8 & num10)) | (num9 & num10))) + 0x8f1bbcdc) + this.uint_1[0x36];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + (((num7 & num8) | (num7 & num9)) | (num8 & num9))) + 0x8f1bbcdc) + this.uint_1[0x37];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + (((num6 & num7) | (num6 & num8)) | (num7 & num8))) + 0x8f1bbcdc) + this.uint_1[0x38];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + (((num10 & num6) | (num10 & num7)) | (num6 & num7))) + 0x8f1bbcdc) + this.uint_1[0x39];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + (((num9 & num10) | (num9 & num6)) | (num10 & num6))) + 0x8f1bbcdc) + this.uint_1[0x3a];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + (((num8 & num9) | (num8 & num10)) | (num9 & num10))) + 0x8f1bbcdc) + this.uint_1[0x3b];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0xca62c1d6) + this.uint_1[60];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0xca62c1d6) + this.uint_1[0x3d];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0xca62c1d6) + this.uint_1[0x3e];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0xca62c1d6) + this.uint_1[0x3f];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0xca62c1d6) + this.uint_1[0x40];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0xca62c1d6) + this.uint_1[0x41];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0xca62c1d6) + this.uint_1[0x42];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0xca62c1d6) + this.uint_1[0x43];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0xca62c1d6) + this.uint_1[0x44];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0xca62c1d6) + this.uint_1[0x45];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0xca62c1d6) + this.uint_1[70];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0xca62c1d6) + this.uint_1[0x47];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0xca62c1d6) + this.uint_1[0x48];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0xca62c1d6) + this.uint_1[0x49];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0xca62c1d6) + this.uint_1[0x4a];
        num8 = (num8 << 30) | (num8 >> 2);
        num10 += ((((num6 << 5) | (num6 >> 0x1b)) + ((num7 ^ num8) ^ num9)) + 0xca62c1d6) + this.uint_1[0x4b];
        num7 = (num7 << 30) | (num7 >> 2);
        num9 += ((((num10 << 5) | (num10 >> 0x1b)) + ((num6 ^ num7) ^ num8)) + 0xca62c1d6) + this.uint_1[0x4c];
        num6 = (num6 << 30) | (num6 >> 2);
        num8 += ((((num9 << 5) | (num9 >> 0x1b)) + ((num10 ^ num6) ^ num7)) + 0xca62c1d6) + this.uint_1[0x4d];
        num10 = (num10 << 30) | (num10 >> 2);
        num7 += ((((num8 << 5) | (num8 >> 0x1b)) + ((num9 ^ num10) ^ num6)) + 0xca62c1d6) + this.uint_1[0x4e];
        num9 = (num9 << 30) | (num9 >> 2);
        num6 += ((((num7 << 5) | (num7 >> 0x1b)) + ((num8 ^ num9) ^ num10)) + 0xca62c1d6) + this.uint_1[0x4f];
        num8 = (num8 << 30) | (num8 >> 2);
        this.uint_0[0] += num6;
        this.uint_0[1] += num7;
        this.uint_0[2] += num8;
        this.uint_0[3] += num9;
        this.uint_0[4] += num10;
    }

    private void method_5(byte[] A_0, int A_1, int A_2)
    {
        long num = this.long_0 + A_2;
        int num2 = 0x38 - ((int) (num % 0x40L));
        if (num2 < 1)
        {
            num2 += 0x40;
        }
        byte[] buffer = new byte[(A_2 + num2) + 8];
        for (int i = 0; i < A_2; i++)
        {
            buffer[i] = A_0[i + A_1];
        }
        buffer[A_2] = 0x80;
        for (int j = A_2 + 1; j < (A_2 + num2); j++)
        {
            buffer[j] = 0;
        }
        long num4 = num << 3;
        this.method_6(num4, buffer, A_2 + num2);
        this.method_4(buffer, 0);
        if (((A_2 + num2) + 8) == 0x80)
        {
            this.method_4(buffer, 0x40);
        }
    }

    internal void method_6(long A_0, byte[] A_1, int A_2)
    {
        A_1[A_2++] = (byte) (A_0 >> 0x38);
        A_1[A_2++] = (byte) (A_0 >> 0x30);
        A_1[A_2++] = (byte) (A_0 >> 40);
        A_1[A_2++] = (byte) (A_0 >> 0x20);
        A_1[A_2++] = (byte) (A_0 >> 0x18);
        A_1[A_2++] = (byte) (A_0 >> 0x10);
        A_1[A_2++] = (byte) (A_0 >> 8);
        A_1[A_2] = (byte) A_0;
    }
}

