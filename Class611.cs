using System;

[CLSCompliant(false)]
internal class Class611
{
    private static byte[] byte_0;
    private byte[] byte_1 = new byte[0x40];
    private byte[] byte_2 = new byte[0x10];
    private uint[] uint_0 = new uint[2];
    private uint[] uint_1 = new uint[] { 0x67452301, 0xefcdab89, 0x98badcfe, 0x10325476 };

    static Class611()
    {
        byte[] buffer = new byte[0x40];
        buffer[0] = 0x80;
        byte_0 = buffer;
    }

    internal uint[] method_0()
    {
        return this.uint_0;
    }

    internal uint[] method_1()
    {
        return this.uint_1;
    }

    private uint method_10(uint A_0, uint A_1, uint A_2)
    {
        return (A_1 ^ (A_0 | ~A_2));
    }

    private uint method_11(uint A_0, byte A_1)
    {
        return ((A_0 << A_1) | (A_0 >> (0x20 - A_1)));
    }

    private void method_12(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (this.method_7(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = this.method_11(A_0, A_5);
        A_0 += A_1;
    }

    private void method_13(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (this.method_8(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = this.method_11(A_0, A_5);
        A_0 += A_1;
    }

    private void method_14(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (this.method_9(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = this.method_11(A_0, A_5);
        A_0 += A_1;
    }

    private void method_15(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (this.method_10(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = this.method_11(A_0, A_5);
        A_0 += A_1;
    }

    private void method_16(uint[] A_0)
    {
        uint num = this.uint_1[0];
        uint num2 = this.uint_1[1];
        uint num3 = this.uint_1[2];
        uint num4 = this.uint_1[3];
        this.method_12(ref num, num2, num3, num4, A_0[0], 7, 0xd76aa478);
        this.method_12(ref num4, num, num2, num3, A_0[1], 12, 0xe8c7b756);
        this.method_12(ref num3, num4, num, num2, A_0[2], 0x11, 0x242070db);
        this.method_12(ref num2, num3, num4, num, A_0[3], 0x16, 0xc1bdceee);
        this.method_12(ref num, num2, num3, num4, A_0[4], 7, 0xf57c0faf);
        this.method_12(ref num4, num, num2, num3, A_0[5], 12, 0x4787c62a);
        this.method_12(ref num3, num4, num, num2, A_0[6], 0x11, 0xa8304613);
        this.method_12(ref num2, num3, num4, num, A_0[7], 0x16, 0xfd469501);
        this.method_12(ref num, num2, num3, num4, A_0[8], 7, 0x698098d8);
        this.method_12(ref num4, num, num2, num3, A_0[9], 12, 0x8b44f7af);
        this.method_12(ref num3, num4, num, num2, A_0[10], 0x11, 0xffff5bb1);
        this.method_12(ref num2, num3, num4, num, A_0[11], 0x16, 0x895cd7be);
        this.method_12(ref num, num2, num3, num4, A_0[12], 7, 0x6b901122);
        this.method_12(ref num4, num, num2, num3, A_0[13], 12, 0xfd987193);
        this.method_12(ref num3, num4, num, num2, A_0[14], 0x11, 0xa679438e);
        this.method_12(ref num2, num3, num4, num, A_0[15], 0x16, 0x49b40821);
        this.method_13(ref num, num2, num3, num4, A_0[1], 5, 0xf61e2562);
        this.method_13(ref num4, num, num2, num3, A_0[6], 9, 0xc040b340);
        this.method_13(ref num3, num4, num, num2, A_0[11], 14, 0x265e5a51);
        this.method_13(ref num2, num3, num4, num, A_0[0], 20, 0xe9b6c7aa);
        this.method_13(ref num, num2, num3, num4, A_0[5], 5, 0xd62f105d);
        this.method_13(ref num4, num, num2, num3, A_0[10], 9, 0x2441453);
        this.method_13(ref num3, num4, num, num2, A_0[15], 14, 0xd8a1e681);
        this.method_13(ref num2, num3, num4, num, A_0[4], 20, 0xe7d3fbc8);
        this.method_13(ref num, num2, num3, num4, A_0[9], 5, 0x21e1cde6);
        this.method_13(ref num4, num, num2, num3, A_0[14], 9, 0xc33707d6);
        this.method_13(ref num3, num4, num, num2, A_0[3], 14, 0xf4d50d87);
        this.method_13(ref num2, num3, num4, num, A_0[8], 20, 0x455a14ed);
        this.method_13(ref num, num2, num3, num4, A_0[13], 5, 0xa9e3e905);
        this.method_13(ref num4, num, num2, num3, A_0[2], 9, 0xfcefa3f8);
        this.method_13(ref num3, num4, num, num2, A_0[7], 14, 0x676f02d9);
        this.method_13(ref num2, num3, num4, num, A_0[12], 20, 0x8d2a4c8a);
        this.method_14(ref num, num2, num3, num4, A_0[5], 4, 0xfffa3942);
        this.method_14(ref num4, num, num2, num3, A_0[8], 11, 0x8771f681);
        this.method_14(ref num3, num4, num, num2, A_0[11], 0x10, 0x6d9d6122);
        this.method_14(ref num2, num3, num4, num, A_0[14], 0x17, 0xfde5380c);
        this.method_14(ref num, num2, num3, num4, A_0[1], 4, 0xa4beea44);
        this.method_14(ref num4, num, num2, num3, A_0[4], 11, 0x4bdecfa9);
        this.method_14(ref num3, num4, num, num2, A_0[7], 0x10, 0xf6bb4b60);
        this.method_14(ref num2, num3, num4, num, A_0[10], 0x17, 0xbebfbc70);
        this.method_14(ref num, num2, num3, num4, A_0[13], 4, 0x289b7ec6);
        this.method_14(ref num4, num, num2, num3, A_0[0], 11, 0xeaa127fa);
        this.method_14(ref num3, num4, num, num2, A_0[3], 0x10, 0xd4ef3085);
        this.method_14(ref num2, num3, num4, num, A_0[6], 0x17, 0x4881d05);
        this.method_14(ref num, num2, num3, num4, A_0[9], 4, 0xd9d4d039);
        this.method_14(ref num4, num, num2, num3, A_0[12], 11, 0xe6db99e5);
        this.method_14(ref num3, num4, num, num2, A_0[15], 0x10, 0x1fa27cf8);
        this.method_14(ref num2, num3, num4, num, A_0[2], 0x17, 0xc4ac5665);
        this.method_15(ref num, num2, num3, num4, A_0[0], 6, 0xf4292244);
        this.method_15(ref num4, num, num2, num3, A_0[7], 10, 0x432aff97);
        this.method_15(ref num3, num4, num, num2, A_0[14], 15, 0xab9423a7);
        this.method_15(ref num2, num3, num4, num, A_0[5], 0x15, 0xfc93a039);
        this.method_15(ref num, num2, num3, num4, A_0[12], 6, 0x655b59c3);
        this.method_15(ref num4, num, num2, num3, A_0[3], 10, 0x8f0ccc92);
        this.method_15(ref num3, num4, num, num2, A_0[10], 15, 0xffeff47d);
        this.method_15(ref num2, num3, num4, num, A_0[1], 0x15, 0x85845dd1);
        this.method_15(ref num, num2, num3, num4, A_0[8], 6, 0x6fa87e4f);
        this.method_15(ref num4, num, num2, num3, A_0[15], 10, 0xfe2ce6e0);
        this.method_15(ref num3, num4, num, num2, A_0[6], 15, 0xa3014314);
        this.method_15(ref num2, num3, num4, num, A_0[13], 0x15, 0x4e0811a1);
        this.method_15(ref num, num2, num3, num4, A_0[4], 6, 0xf7537e82);
        this.method_15(ref num4, num, num2, num3, A_0[11], 10, 0xbd3af235);
        this.method_15(ref num3, num4, num, num2, A_0[2], 15, 0x2ad7d2bb);
        this.method_15(ref num2, num3, num4, num, A_0[9], 0x15, 0xeb86d391);
        this.uint_1[0] += num;
        this.uint_1[1] += num2;
        this.uint_1[2] += num3;
        this.uint_1[3] += num4;
    }

    internal byte[] method_2()
    {
        return this.byte_1;
    }

    internal byte[] method_3()
    {
        return this.byte_2;
    }

    internal void method_4(byte[] A_0, uint A_1)
    {
        uint[] numArray = new uint[0x10];
        int num = ((int) (this.uint_0[0] >> 3)) & 0x3f;
        if ((this.uint_0[0] + (A_1 << 3)) < this.uint_0[0])
        {
            this.uint_0[1]++;
        }
        this.uint_0[0] += A_1 << 3;
        this.uint_0[1] += A_1 >> 0x1d;
        for (uint i = 0; i < A_1; i++)
        {
            this.byte_1[num++] = A_0[i];
            if (num == 0x40)
            {
                uint index = 0;
                for (uint j = 0; index < 0x10; j += 4)
                {
                    numArray[index] = (uint) ((((this.byte_1[(int) ((IntPtr) (j + 3))] << 0x18) | (this.byte_1[(int) ((IntPtr) (j + 2))] << 0x10)) | (this.byte_1[(int) ((IntPtr) (j + 1))] << 8)) | this.byte_1[j]);
                    index++;
                }
                this.method_16(numArray);
                num = 0;
            }
        }
    }

    internal void method_5()
    {
        uint[] numArray = new uint[0x10];
        numArray[14] = this.uint_0[0];
        numArray[15] = this.uint_0[1];
        uint num = (this.uint_0[0] >> 3) & 0x3f;
        uint num4 = (num < 0x38) ? (0x38 - num) : (120 - num);
        this.method_4(byte_0, num4);
        uint index = 0;
        for (uint i = 0; index < 14; i += 4)
        {
            numArray[index] = (uint) ((((this.byte_1[(int) ((IntPtr) (i + 3))] << 0x18) | (this.byte_1[(int) ((IntPtr) (i + 2))] << 0x10)) | (this.byte_1[(int) ((IntPtr) (i + 1))] << 8)) | this.byte_1[i]);
            index++;
        }
        this.method_16(numArray);
        this.method_6();
    }

    internal void method_6()
    {
        uint index = 0;
        for (uint i = 0; index < 4; i += 4)
        {
            this.byte_2[i] = (byte) (this.uint_1[index] & 0xff);
            this.byte_2[(int) ((IntPtr) (i + 1))] = (byte) ((this.uint_1[index] >> 8) & 0xff);
            this.byte_2[(int) ((IntPtr) (i + 2))] = (byte) ((this.uint_1[index] >> 0x10) & 0xff);
            this.byte_2[(int) ((IntPtr) (i + 3))] = (byte) ((this.uint_1[index] >> 0x18) & 0xff);
            index++;
        }
    }

    private uint method_7(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 & A_1) | (~A_0 & A_2));
    }

    private uint method_8(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 & A_2) | (A_1 & ~A_2));
    }

    private uint method_9(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 ^ A_1) ^ A_2);
    }
}

