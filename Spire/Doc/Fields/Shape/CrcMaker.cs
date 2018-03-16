namespace Spire.Doc.Fields.Shape
{
    using System;

    public class CrcMaker
    {
        private CrcEncoding crcEncoding_0;
        private float[] float_0;
        private float float_1;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private long long_0;
        private long long_1;
        private long long_2;
        private long long_3;
        private long long_4;
        private long long_5;
        private long long_6;
        private long[] long_7;
        private long[] long_8;
        private long long_9;
        private string string_0;

        public CrcMaker()
        {
            this.int_0 = 0x10;
            this.long_0 = 0x1021L;
            this.int_1 = 1;
            this.long_1 = 0xffffL;
            this.long_8 = new long[0x100];
            this.method_0(CrcEncoding.CRC32);
        }

        internal CrcMaker(CrcEncoding A_0)
        {
            this.int_0 = 0x10;
            this.long_0 = 0x1021L;
            this.int_1 = 1;
            this.long_1 = 0xffffL;
            this.long_8 = new long[0x100];
            this.method_0(A_0);
        }

        public int MakeCRC(byte[] p)
        {
            long num = this.long_5;
            if (this.int_2 != 0)
            {
                num = this.method_1(num, this.int_0);
            }
            if (this.int_2 == 0)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    num = (num << 8) ^ this.long_8[(int) (((num >> (this.int_0 - 8)) & 0xffL) ^ p[i])];
                }
            }
            else
            {
                for (int j = 0; j < p.Length; j++)
                {
                    num = (num >> 8) ^ this.long_8[(int) ((num & 0xffL) ^ p[j])];
                }
            }
            if ((this.int_3 ^ this.int_2) != 0)
            {
                num = this.method_1(num, this.int_0);
            }
            num ^= this.long_2;
            num &= this.long_3;
            return (int) num;
        }

        private void method_0(CrcEncoding A_0)
        {
            long num;
            long num2;
            int num3;
            this.crcEncoding_0 = A_0;
            switch (A_0)
            {
                case CrcEncoding.CRC16:
                    this.int_0 = 0x10;
                    this.int_1 = 1;
                    this.long_0 = 0x8005L;
                    this.long_1 = 0L;
                    this.long_2 = 0L;
                    this.int_2 = 1;
                    this.int_3 = 1;
                    break;

                case CrcEncoding.CRC_CCITT:
                    this.int_0 = 0x10;
                    this.int_1 = 1;
                    this.long_0 = 0x1021L;
                    this.long_1 = 0xffffL;
                    this.long_2 = 0L;
                    this.int_2 = 0;
                    this.int_3 = 0;
                    break;

                case CrcEncoding.CRC_CCITT_Reverse:
                    this.int_0 = 0x10;
                    this.int_1 = 1;
                    this.long_0 = 0x1021L;
                    this.long_1 = 0L;
                    this.long_2 = 0L;
                    this.int_2 = 1;
                    this.int_3 = 1;
                    break;

                default:
                    this.int_0 = 0x20;
                    this.int_1 = 1;
                    this.long_0 = 0x4c11db7L;
                    this.long_1 = 0xffffffffL;
                    this.long_2 = 0xffffffffL;
                    this.int_2 = 1;
                    this.int_3 = 1;
                    break;
            }
            this.long_3 = (((1L << ((this.int_0 - 1) & 0x3f)) - 1L) << 1) | 1L;
            this.long_4 = ((long) 1L) << (this.int_0 - 1);
            this.method_2();
            if (this.int_1 == 0)
            {
                this.long_6 = this.long_1;
                num = this.long_1;
                for (num3 = 0; num3 < this.int_0; num3++)
                {
                    num2 = num & this.long_4;
                    num = num << 1;
                    if (num2 != 0L)
                    {
                        num ^= this.long_0;
                    }
                }
                num &= this.long_3;
                this.long_5 = num;
            }
            else
            {
                this.long_5 = this.long_1;
                num = this.long_1;
                for (num3 = 0; num3 < this.int_0; num3++)
                {
                    num2 = num & 1L;
                    if (num2 != 0L)
                    {
                        num ^= this.long_0;
                    }
                    num = num >> 1;
                    if (num2 != 0L)
                    {
                        num |= this.long_4;
                    }
                }
                this.long_6 = num;
            }
        }

        private long method_1(long A_0, int A_1)
        {
            long num = 1L;
            long num2 = 0L;
            for (long i = ((long) 1L) << (A_1 - 1); i != 0L; i = i >> 1)
            {
                if ((A_0 & i) != 0L)
                {
                    num2 |= num;
                }
                num = num << 1;
            }
            return num2;
        }

        private void method_2()
        {
            for (int i = 0; i < 0x100; i++)
            {
                long num2 = i;
                if (this.int_2 != 0)
                {
                    num2 = this.method_1(num2, 8);
                }
                num2 = num2 << (this.int_0 - 8);
                for (int j = 0; j < 8; j++)
                {
                    long num4 = num2 & this.long_4;
                    num2 = num2 << 1;
                    if (num4 != 0L)
                    {
                        num2 ^= this.long_0;
                    }
                }
                if (this.int_2 != 0)
                {
                    num2 = this.method_1(num2, this.int_0);
                }
                this.long_8[i] = num2 & this.long_3;
            }
        }

        internal CrcEncoding Encoding
        {
            get
            {
                return this.crcEncoding_0;
            }
        }
    }
}

