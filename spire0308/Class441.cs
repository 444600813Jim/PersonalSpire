using System;

[CLSCompliant(false)]
internal class Class441
{
    private byte[] byte_0;
    private byte[,] byte_1;
    private byte[,] byte_2;
    private byte[,] byte_3;
    private byte[,] byte_4;
    private byte[,] byte_5;
    private int int_0;
    private int int_1;
    private int int_2;
    private KeySize keySize_0;

    internal Class441(KeySize A_0, byte[] A_1)
    {
        this.keySize_0 = A_0;
        this.method_3(A_0);
        this.byte_0 = new byte[this.int_1 * 4];
        A_1.CopyTo(this.byte_0, 0);
        this.method_0();
    }

    private void method_0()
    {
        this.method_4();
        this.method_5();
        this.method_6();
        this.method_14();
    }

    internal void method_1(byte[] A_0, byte[] A_1)
    {
        this.method_0();
        this.byte_5 = new byte[4, this.int_0];
        for (int i = 0; i < (4 * this.int_0); i++)
        {
            this.byte_5[i % 4, i / 4] = A_0[i];
        }
        this.method_7(0);
        for (int j = 1; j <= (this.int_2 - 1); j++)
        {
            this.method_8();
            this.method_10();
            this.method_12();
            this.method_7(j);
        }
        this.method_8();
        this.method_10();
        this.method_7(this.int_2);
        for (int k = 0; k < (4 * this.int_0); k++)
        {
            A_1[k] = this.byte_5[k % 4, k / 4];
        }
    }

    private void method_10()
    {
        byte[,] buffer = new byte[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                buffer[i, k] = this.byte_5[i, k];
            }
        }
        for (int j = 1; j < 4; j++)
        {
            for (int m = 0; m < 4; m++)
            {
                this.byte_5[j, m] = buffer[j, (m + j) % this.int_0];
            }
        }
    }

    private void method_11()
    {
        byte[,] buffer = new byte[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                buffer[i, k] = this.byte_5[i, k];
            }
        }
        for (int j = 1; j < 4; j++)
        {
            for (int m = 0; m < 4; m++)
            {
                this.byte_5[j, (m + j) % this.int_0] = buffer[j, m];
            }
        }
    }

    private void method_12()
    {
        byte[,] buffer = new byte[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                buffer[i, k] = this.byte_5[i, k];
            }
        }
        for (int j = 0; j < 4; j++)
        {
            this.byte_5[0, j] = (byte) (((smethod_1(buffer[0, j]) ^ smethod_2(buffer[1, j])) ^ smethod_0(buffer[2, j])) ^ smethod_0(buffer[3, j]));
            this.byte_5[1, j] = (byte) (((smethod_0(buffer[0, j]) ^ smethod_1(buffer[1, j])) ^ smethod_2(buffer[2, j])) ^ smethod_0(buffer[3, j]));
            this.byte_5[2, j] = (byte) (((smethod_0(buffer[0, j]) ^ smethod_0(buffer[1, j])) ^ smethod_1(buffer[2, j])) ^ smethod_2(buffer[3, j]));
            this.byte_5[3, j] = (byte) (((smethod_2(buffer[0, j]) ^ smethod_0(buffer[1, j])) ^ smethod_0(buffer[2, j])) ^ smethod_1(buffer[3, j]));
        }
    }

    private void method_13()
    {
        byte[,] buffer = new byte[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                buffer[i, k] = this.byte_5[i, k];
            }
        }
        for (int j = 0; j < 4; j++)
        {
            this.byte_5[0, j] = (byte) (((smethod_6(buffer[0, j]) ^ smethod_4(buffer[1, j])) ^ smethod_5(buffer[2, j])) ^ smethod_3(buffer[3, j]));
            this.byte_5[1, j] = (byte) (((smethod_3(buffer[0, j]) ^ smethod_6(buffer[1, j])) ^ smethod_4(buffer[2, j])) ^ smethod_5(buffer[3, j]));
            this.byte_5[2, j] = (byte) (((smethod_5(buffer[0, j]) ^ smethod_3(buffer[1, j])) ^ smethod_6(buffer[2, j])) ^ smethod_4(buffer[3, j]));
            this.byte_5[3, j] = (byte) (((smethod_4(buffer[0, j]) ^ smethod_5(buffer[1, j])) ^ smethod_3(buffer[2, j])) ^ smethod_6(buffer[3, j]));
        }
    }

    private void method_14()
    {
        this.byte_3 = new byte[this.int_0 * (this.int_2 + 1), 4];
        for (int i = 0; i < this.int_1; i++)
        {
            this.byte_3[i, 0] = this.byte_0[4 * i];
            this.byte_3[i, 1] = this.byte_0[(4 * i) + 1];
            this.byte_3[i, 2] = this.byte_0[(4 * i) + 2];
            this.byte_3[i, 3] = this.byte_0[(4 * i) + 3];
        }
        byte[] buffer = new byte[4];
        for (int j = this.int_1; j < (this.int_0 * (this.int_2 + 1)); j++)
        {
            buffer[0] = this.byte_3[j - 1, 0];
            buffer[1] = this.byte_3[j - 1, 1];
            buffer[2] = this.byte_3[j - 1, 2];
            buffer[3] = this.byte_3[j - 1, 3];
            if ((j % this.int_1) == 0)
            {
                buffer = this.method_15(this.method_16(buffer));
                buffer[0] = (byte) (buffer[0] ^ this.byte_4[j / this.int_1, 0]);
                buffer[1] = (byte) (buffer[1] ^ this.byte_4[j / this.int_1, 1]);
                buffer[2] = (byte) (buffer[2] ^ this.byte_4[j / this.int_1, 2]);
                buffer[3] = (byte) (buffer[3] ^ this.byte_4[j / this.int_1, 3]);
            }
            else if ((this.int_1 > 6) && ((j % this.int_1) == 4))
            {
                buffer = this.method_15(buffer);
            }
            this.byte_3[j, 0] = (byte) (this.byte_3[j - this.int_1, 0] ^ buffer[0]);
            this.byte_3[j, 1] = (byte) (this.byte_3[j - this.int_1, 1] ^ buffer[1]);
            this.byte_3[j, 2] = (byte) (this.byte_3[j - this.int_1, 2] ^ buffer[2]);
            this.byte_3[j, 3] = (byte) (this.byte_3[j - this.int_1, 3] ^ buffer[3]);
        }
    }

    private byte[] method_15(byte[] A_0)
    {
        return new byte[] { this.byte_1[A_0[0] >> 4, A_0[0] & 15], this.byte_1[A_0[1] >> 4, A_0[1] & 15], this.byte_1[A_0[2] >> 4, A_0[2] & 15], this.byte_1[A_0[3] >> 4, A_0[3] & 15] };
    }

    private byte[] method_16(byte[] A_0)
    {
        return new byte[] { A_0[1], A_0[2], A_0[3], A_0[0] };
    }

    internal void method_2(byte[] A_0, byte[] A_1)
    {
        this.byte_5 = new byte[4, this.int_0];
        for (int i = 0; i < (4 * this.int_0); i++)
        {
            this.byte_5[i % 4, i / 4] = A_0[i];
        }
        this.method_7(this.int_2);
        for (int j = this.int_2 - 1; j >= 1; j--)
        {
            this.method_11();
            this.method_9();
            this.method_7(j);
            this.method_13();
        }
        this.method_11();
        this.method_9();
        this.method_7(0);
        for (int k = 0; k < (4 * this.int_0); k++)
        {
            A_1[k] = this.byte_5[k % 4, k / 4];
        }
    }

    private void method_3(KeySize A_0)
    {
        this.int_0 = 4;
        if (A_0 == KeySize.Bits128)
        {
            this.int_1 = 4;
            this.int_2 = 10;
        }
        else if (A_0 == KeySize.Bits192)
        {
            this.int_1 = 6;
            this.int_2 = 12;
        }
        else if (A_0 == KeySize.Bits256)
        {
            this.int_1 = 8;
            this.int_2 = 14;
        }
    }

    private void method_4()
    {
        this.byte_1 = new byte[,] { { 0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 1, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76 }, { 0xca, 130, 0xc9, 0x7d, 250, 0x59, 0x47, 240, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0 }, { 0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15 }, { 4, 0xc7, 0x23, 0xc3, 0x18, 150, 5, 0x9a, 7, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75 }, { 9, 0x83, 0x2c, 0x1a, 0x1b, 110, 90, 160, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84 }, { 0x53, 0xd1, 0, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 190, 0x39, 0x4a, 0x4c, 0x58, 0xcf }, { 0xd0, 0xef, 170, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 2, 0x7f, 80, 60, 0x9f, 0xa8 }, { 0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 210 }, { 0xcd, 12, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 100, 0x5d, 0x19, 0x73 }, { 0x60, 0x81, 0x4f, 220, 0x22, 0x2a, 0x90, 0x88, 70, 0xee, 0xb8, 20, 0xde, 0x5e, 11, 0xdb }, { 0xe0, 50, 0x3a, 10, 0x49, 6, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79 }, { 0xe7, 200, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 8 }, { 0xba, 120, 0x25, 0x2e, 0x1c, 0xa6, 180, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a }, { 0x70, 0x3e, 0xb5, 0x66, 0x48, 3, 0xf6, 14, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e }, { 0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 30, 0x87, 0xe9, 0xce, 0x55, 40, 0xdf }, { 140, 0xa1, 0x89, 13, 0xbf, 230, 0x42, 0x68, 0x41, 0x99, 0x2d, 15, 0xb0, 0x54, 0xbb, 0x16 } };
    }

    private void method_5()
    {
        this.byte_2 = new byte[,] { { 0x52, 9, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb }, { 0x7c, 0xe3, 0x39, 130, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb }, { 0x54, 0x7b, 0x94, 50, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 11, 0x42, 250, 0xc3, 0x4e }, { 8, 0x2e, 0xa1, 0x66, 40, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25 }, { 0x72, 0xf8, 0xf6, 100, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92 }, { 0x6c, 0x70, 0x48, 80, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 70, 0x57, 0xa7, 0x8d, 0x9d, 0x84 }, { 0x90, 0xd8, 0xab, 0, 140, 0xbc, 0xd3, 10, 0xf7, 0xe4, 0x58, 5, 0xb8, 0xb3, 0x45, 6 }, { 0xd0, 0x2c, 30, 0x8f, 0xca, 0x3f, 15, 2, 0xc1, 0xaf, 0xbd, 3, 1, 0x13, 0x8a, 0x6b }, { 0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 220, 0xea, 0x97, 0xf2, 0xcf, 0xce, 240, 180, 230, 0x73 }, { 150, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 110 }, { 0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 14, 170, 0x18, 190, 0x1b }, { 0xfc, 0x56, 0x3e, 0x4b, 0xc6, 210, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 120, 0xcd, 90, 0xf4 }, { 0x1f, 0xdd, 0xa8, 0x33, 0x88, 7, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f }, { 0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 13, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef }, { 160, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 200, 0xeb, 0xbb, 60, 0x83, 0x53, 0x99, 0x61 }, { 0x17, 0x2b, 4, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 20, 0x63, 0x55, 0x21, 12, 0x7d } };
    }

    private void method_6()
    {
        this.byte_4 = new byte[,] { { 0, 0, 0, 0 }, { 1, 0, 0, 0 }, { 2, 0, 0, 0 }, { 4, 0, 0, 0 }, { 8, 0, 0, 0 }, { 0x10, 0, 0, 0 }, { 0x20, 0, 0, 0 }, { 0x40, 0, 0, 0 }, { 0x80, 0, 0, 0 }, { 0x1b, 0, 0, 0 }, { 0x36, 0, 0, 0 } };
    }

    private void method_7(int A_0)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                this.byte_5[i, j] = (byte) (this.byte_5[i, j] ^ this.byte_3[(A_0 * 4) + j, i]);
            }
        }
    }

    private void method_8()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                this.byte_5[i, j] = this.byte_1[this.byte_5[i, j] >> 4, this.byte_5[i, j] & 15];
            }
        }
    }

    private void method_9()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                this.byte_5[i, j] = this.byte_2[this.byte_5[i, j] >> 4, this.byte_5[i, j] & 15];
            }
        }
    }

    private static byte smethod_0(byte A_0)
    {
        return A_0;
    }

    private static byte smethod_1(byte A_0)
    {
        if (A_0 < 0x80)
        {
            return (byte) (A_0 << 1);
        }
        return (byte) ((A_0 << 1) ^ 0x1b);
    }

    private static byte smethod_2(byte A_0)
    {
        return (byte) (smethod_1(A_0) ^ A_0);
    }

    private static byte smethod_3(byte A_0)
    {
        return (byte) (smethod_1(smethod_1(smethod_1(A_0))) ^ A_0);
    }

    private static byte smethod_4(byte A_0)
    {
        return (byte) ((smethod_1(smethod_1(smethod_1(A_0))) ^ smethod_1(A_0)) ^ A_0);
    }

    private static byte smethod_5(byte A_0)
    {
        return (byte) ((smethod_1(smethod_1(smethod_1(A_0))) ^ smethod_1(smethod_1(A_0))) ^ A_0);
    }

    private static byte smethod_6(byte A_0)
    {
        return (byte) ((smethod_1(smethod_1(smethod_1(A_0))) ^ smethod_1(smethod_1(A_0))) ^ smethod_1(A_0));
    }

    internal enum KeySize
    {
        Bits128,
        Bits192,
        Bits256
    }
}

