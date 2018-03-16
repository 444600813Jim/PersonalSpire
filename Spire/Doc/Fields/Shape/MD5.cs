namespace Spire.Doc.Fields.Shape
{
    using System;

    public class MD5
    {
        private static byte[] byte_0;
        private byte[] byte_1 = new byte[0x40];
        private byte[] byte_2 = new byte[0x10];
        private int[] int_0;
        private const uint uint_0 = 0xd76aa478;
        private const uint uint_1 = 0xe8c7b756;
        private const uint uint_10 = 0xffff5bb1;
        private const uint uint_11 = 0x895cd7be;
        private const uint uint_12 = 0x6b901122;
        private const uint uint_13 = 0xfd987193;
        private const uint uint_14 = 0xa679438e;
        private const uint uint_15 = 0x49b40821;
        private const uint uint_16 = 0xf61e2562;
        private const uint uint_17 = 0xc040b340;
        private const uint uint_18 = 0x265e5a51;
        private const uint uint_19 = 0xe9b6c7aa;
        private const uint uint_2 = 0x242070db;
        private const uint uint_20 = 0xd62f105d;
        private const uint uint_21 = 0x2441453;
        private const uint uint_22 = 0xd8a1e681;
        private const uint uint_23 = 0xe7d3fbc8;
        private const uint uint_24 = 0x21e1cde6;
        private const uint uint_25 = 0xc33707d6;
        private const uint uint_26 = 0xf4d50d87;
        private const uint uint_27 = 0x455a14ed;
        private const uint uint_28 = 0xa9e3e905;
        private const uint uint_29 = 0xfcefa3f8;
        private const uint uint_3 = 0xc1bdceee;
        private const uint uint_30 = 0x676f02d9;
        private const uint uint_31 = 0x8d2a4c8a;
        private const uint uint_32 = 0xfffa3942;
        private const uint uint_33 = 0x8771f681;
        private const uint uint_34 = 0x6d9d6122;
        private const uint uint_35 = 0xfde5380c;
        private const uint uint_36 = 0xa4beea44;
        private const uint uint_37 = 0x4bdecfa9;
        private const uint uint_38 = 0xf6bb4b60;
        private const uint uint_39 = 0xbebfbc70;
        private const uint uint_4 = 0xf57c0faf;
        private const uint uint_40 = 0x289b7ec6;
        private const uint uint_41 = 0xeaa127fa;
        private const uint uint_42 = 0xd4ef3085;
        private const uint uint_43 = 0x4881d05;
        private const uint uint_44 = 0xd9d4d039;
        private const uint uint_45 = 0xe6db99e5;
        private const uint uint_46 = 0x1fa27cf8;
        private const uint uint_47 = 0xc4ac5665;
        private const uint uint_48 = 0xf4292244;
        private const uint uint_49 = 0x432aff97;
        private const uint uint_5 = 0x4787c62a;
        private const uint uint_50 = 0xab9423a7;
        private const uint uint_51 = 0xfc93a039;
        private const uint uint_52 = 0x655b59c3;
        private const uint uint_53 = 0x8f0ccc92;
        private const uint uint_54 = 0xffeff47d;
        private const uint uint_55 = 0x85845dd1;
        private const uint uint_56 = 0x6fa87e4f;
        private const uint uint_57 = 0xfe2ce6e0;
        private const uint uint_58 = 0xa3014314;
        private const uint uint_59 = 0x4e0811a1;
        private const uint uint_6 = 0xa8304613;
        private const uint uint_60 = 0xf7537e82;
        private const uint uint_61 = 0xbd3af235;
        private const uint uint_62 = 0x2ad7d2bb;
        private const uint uint_63 = 0xeb86d391;
        private uint[] uint_64 = new uint[2];
        private uint[] uint_65 = new uint[4];
        private const uint uint_7 = 0xfd469501;
        private const uint uint_8 = 0x698098d8;
        private const uint uint_9 = 0x8b44f7af;

        static MD5()
        {
            byte[] buffer = new byte[0x40];
            buffer[0] = 0x80;
            byte_0 = buffer;
        }

        public MD5()
        {
            this.uint_65[0] = 0x67452301;
            this.uint_65[1] = 0xefcdab89;
            this.uint_65[2] = 0x98badcfe;
            this.uint_65[3] = 0x10325476;
        }

        public static byte[] ComputeHash(byte[] b)
        {
            return ComputeHash(b, b.Length);
        }

        public static byte[] ComputeHash(byte[] b, int length)
        {
            MD5 md = new MD5();
            md.Update(b, length);
            md.FinalUpdate();
            return md.Digest;
        }

        public void FinalUpdate()
        {
            uint[] numArray = new uint[0x10];
            numArray[14] = this.uint_64[0];
            numArray[15] = this.uint_64[1];
            int num = ((int) (this.uint_64[0] >> 3)) & 0x3f;
            int length = (num < 0x38) ? (0x38 - num) : (120 - num);
            this.Update(byte_0, length);
            int index = 0;
            for (int i = 0; index < 14; i += 4)
            {
                numArray[index] = (uint) ((((this.byte_1[i + 3] << 0x18) | (this.byte_1[i + 2] << 0x10)) | (this.byte_1[i + 1] << 8)) | this.byte_1[i]);
                index++;
            }
            this.method_0(numArray);
            this.StoreDigest();
        }

        private void method_0(uint[] A_0)
        {
            uint num = this.uint_65[0];
            uint num2 = this.uint_65[1];
            uint num3 = this.uint_65[2];
            uint num4 = this.uint_65[3];
            num += ((((num3 ^ num4) & num2) ^ num4) + 0xd76aa478) + A_0[0];
            num = (num << 7) | (num >> 0x19);
            num += num2;
            num4 += ((((num2 ^ num3) & num) ^ num3) + 0xe8c7b756) + A_0[1];
            num4 = (num4 << 12) | (num4 >> 20);
            num4 += num;
            num3 += ((((num ^ num2) & num4) ^ num2) + 0x242070db) + A_0[2];
            num3 = (num3 << 0x11) | (num3 >> 15);
            num3 += num4;
            num2 += ((((num4 ^ num) & num3) ^ num) + 0xc1bdceee) + A_0[3];
            num2 = (num2 << 0x16) | (num2 >> 10);
            num2 += num3;
            num += ((((num3 ^ num4) & num2) ^ num4) + 0xf57c0faf) + A_0[4];
            num = (num << 7) | (num >> 0x19);
            num += num2;
            num4 += ((((num2 ^ num3) & num) ^ num3) + 0x4787c62a) + A_0[5];
            num4 = (num4 << 12) | (num4 >> 20);
            num4 += num;
            num3 += ((((num ^ num2) & num4) ^ num2) + 0xa8304613) + A_0[6];
            num3 = (num3 << 0x11) | (num3 >> 15);
            num3 += num4;
            num2 += ((((num4 ^ num) & num3) ^ num) + 0xfd469501) + A_0[7];
            num2 = (num2 << 0x16) | (num2 >> 10);
            num2 += num3;
            num += ((((num3 ^ num4) & num2) ^ num4) + 0x698098d8) + A_0[8];
            num = (num << 7) | (num >> 0x19);
            num += num2;
            num4 += ((((num2 ^ num3) & num) ^ num3) + 0x8b44f7af) + A_0[9];
            num4 = (num4 << 12) | (num4 >> 20);
            num4 += num;
            num3 += ((((num ^ num2) & num4) ^ num2) + 0xffff5bb1) + A_0[10];
            num3 = (num3 << 0x11) | (num3 >> 15);
            num3 += num4;
            num2 += ((((num4 ^ num) & num3) ^ num) + 0x895cd7be) + A_0[11];
            num2 = (num2 << 0x16) | (num2 >> 10);
            num2 += num3;
            num += ((((num3 ^ num4) & num2) ^ num4) + 0x6b901122) + A_0[12];
            num = (num << 7) | (num >> 0x19);
            num += num2;
            num4 += ((((num2 ^ num3) & num) ^ num3) + 0xfd987193) + A_0[13];
            num4 = (num4 << 12) | (num4 >> 20);
            num4 += num;
            num3 += ((((num ^ num2) & num4) ^ num2) + 0xa679438e) + A_0[14];
            num3 = (num3 << 0x11) | (num3 >> 15);
            num3 += num4;
            num2 += ((((num4 ^ num) & num3) ^ num) + 0x49b40821) + A_0[15];
            num2 = (num2 << 0x16) | (num2 >> 10);
            num2 += num3;
            num += ((((num2 ^ num3) & num4) ^ num3) + 0xf61e2562) + A_0[1];
            num = (num << 5) | (num >> 0x1b);
            num += num2;
            num4 += ((((num ^ num2) & num3) ^ num2) + 0xc040b340) + A_0[6];
            num4 = (num4 << 9) | (num4 >> 0x17);
            num4 += num;
            num3 += ((((num4 ^ num) & num2) ^ num) + 0x265e5a51) + A_0[11];
            num3 = (num3 << 14) | (num3 >> 0x12);
            num3 += num4;
            num2 += ((((num3 ^ num4) & num) ^ num4) + 0xe9b6c7aa) + A_0[0];
            num2 = (num2 << 20) | (num2 >> 12);
            num2 += num3;
            num += ((((num2 ^ num3) & num4) ^ num3) + 0xd62f105d) + A_0[5];
            num = (num << 5) | (num >> 0x1b);
            num += num2;
            num4 += ((((num ^ num2) & num3) ^ num2) + 0x2441453) + A_0[10];
            num4 = (num4 << 9) | (num4 >> 0x17);
            num4 += num;
            num3 += ((((num4 ^ num) & num2) ^ num) + 0xd8a1e681) + A_0[15];
            num3 = (num3 << 14) | (num3 >> 0x12);
            num3 += num4;
            num2 += ((((num3 ^ num4) & num) ^ num4) + 0xe7d3fbc8) + A_0[4];
            num2 = (num2 << 20) | (num2 >> 12);
            num2 += num3;
            num += ((((num2 ^ num3) & num4) ^ num3) + 0x21e1cde6) + A_0[9];
            num = (num << 5) | (num >> 0x1b);
            num += num2;
            num4 += ((((num ^ num2) & num3) ^ num2) + 0xc33707d6) + A_0[14];
            num4 = (num4 << 9) | (num4 >> 0x17);
            num4 += num;
            num3 += ((((num4 ^ num) & num2) ^ num) + 0xf4d50d87) + A_0[3];
            num3 = (num3 << 14) | (num3 >> 0x12);
            num3 += num4;
            num2 += ((((num3 ^ num4) & num) ^ num4) + 0x455a14ed) + A_0[8];
            num2 = (num2 << 20) | (num2 >> 12);
            num2 += num3;
            num += ((((num2 ^ num3) & num4) ^ num3) + 0xa9e3e905) + A_0[13];
            num = (num << 5) | (num >> 0x1b);
            num += num2;
            num4 += ((((num ^ num2) & num3) ^ num2) + 0xfcefa3f8) + A_0[2];
            num4 = (num4 << 9) | (num4 >> 0x17);
            num4 += num;
            num3 += ((((num4 ^ num) & num2) ^ num) + 0x676f02d9) + A_0[7];
            num3 = (num3 << 14) | (num3 >> 0x12);
            num3 += num4;
            num2 += ((((num3 ^ num4) & num) ^ num4) + 0x8d2a4c8a) + A_0[12];
            num2 = (num2 << 20) | (num2 >> 12);
            num2 += num3;
            num += (((num2 ^ num3) ^ num4) + 0xfffa3942) + A_0[5];
            num = (num << 4) | (num >> 0x1c);
            num += num2;
            num4 += (((num ^ num2) ^ num3) + 0x8771f681) + A_0[8];
            num4 = (num4 << 11) | (num4 >> 0x15);
            num4 += num;
            num3 += (((num4 ^ num) ^ num2) + 0x6d9d6122) + A_0[11];
            num3 = (num3 << 0x10) | (num3 >> 0x10);
            num3 += num4;
            num2 += (((num3 ^ num4) ^ num) + 0xfde5380c) + A_0[14];
            num2 = (num2 << 0x17) | (num2 >> 9);
            num2 += num3;
            num += (((num2 ^ num3) ^ num4) + 0xa4beea44) + A_0[1];
            num = (num << 4) | (num >> 0x1c);
            num += num2;
            num4 += (((num ^ num2) ^ num3) + 0x4bdecfa9) + A_0[4];
            num4 = (num4 << 11) | (num4 >> 0x15);
            num4 += num;
            num3 += (((num4 ^ num) ^ num2) + 0xf6bb4b60) + A_0[7];
            num3 = (num3 << 0x10) | (num3 >> 0x10);
            num3 += num4;
            num2 += (((num3 ^ num4) ^ num) + 0xbebfbc70) + A_0[10];
            num2 = (num2 << 0x17) | (num2 >> 9);
            num2 += num3;
            num += (((num2 ^ num3) ^ num4) + 0x289b7ec6) + A_0[13];
            num = (num << 4) | (num >> 0x1c);
            num += num2;
            num4 += (((num ^ num2) ^ num3) + 0xeaa127fa) + A_0[0];
            num4 = (num4 << 11) | (num4 >> 0x15);
            num4 += num;
            num3 += (((num4 ^ num) ^ num2) + 0xd4ef3085) + A_0[3];
            num3 = (num3 << 0x10) | (num3 >> 0x10);
            num3 += num4;
            num2 += (((num3 ^ num4) ^ num) + 0x4881d05) + A_0[6];
            num2 = (num2 << 0x17) | (num2 >> 9);
            num2 += num3;
            num += (((num2 ^ num3) ^ num4) + 0xd9d4d039) + A_0[9];
            num = (num << 4) | (num >> 0x1c);
            num += num2;
            num4 += (((num ^ num2) ^ num3) + 0xe6db99e5) + A_0[12];
            num4 = (num4 << 11) | (num4 >> 0x15);
            num4 += num;
            num3 += (((num4 ^ num) ^ num2) + 0x1fa27cf8) + A_0[15];
            num3 = (num3 << 0x10) | (num3 >> 0x10);
            num3 += num4;
            num2 += (((num3 ^ num4) ^ num) + 0xc4ac5665) + A_0[2];
            num2 = (num2 << 0x17) | (num2 >> 9);
            num2 += num3;
            num += (((~num4 | num2) ^ num3) + 0xf4292244) + A_0[0];
            num = (num << 6) | (num >> 0x1a);
            num += num2;
            num4 += (((~num3 | num) ^ num2) + 0x432aff97) + A_0[7];
            num4 = (num4 << 10) | (num4 >> 0x16);
            num4 += num;
            num3 += (((~num2 | num4) ^ num) + 0xab9423a7) + A_0[14];
            num3 = (num3 << 15) | (num3 >> 0x11);
            num3 += num4;
            num2 += (((~num | num3) ^ num4) + 0xfc93a039) + A_0[5];
            num2 = (num2 << 0x15) | (num2 >> 11);
            num2 += num3;
            num += (((~num4 | num2) ^ num3) + 0x655b59c3) + A_0[12];
            num = (num << 6) | (num >> 0x1a);
            num += num2;
            num4 += (((~num3 | num) ^ num2) + 0x8f0ccc92) + A_0[3];
            num4 = (num4 << 10) | (num4 >> 0x16);
            num4 += num;
            num3 += (((~num2 | num4) ^ num) + 0xffeff47d) + A_0[10];
            num3 = (num3 << 15) | (num3 >> 0x11);
            num3 += num4;
            num2 += (((~num | num3) ^ num4) + 0x85845dd1) + A_0[1];
            num2 = (num2 << 0x15) | (num2 >> 11);
            num2 += num3;
            num += (((~num4 | num2) ^ num3) + 0x6fa87e4f) + A_0[8];
            num = (num << 6) | (num >> 0x1a);
            num += num2;
            num4 += (((~num3 | num) ^ num2) + 0xfe2ce6e0) + A_0[15];
            num4 = (num4 << 10) | (num4 >> 0x16);
            num4 += num;
            num3 += (((~num2 | num4) ^ num) + 0xa3014314) + A_0[6];
            num3 = (num3 << 15) | (num3 >> 0x11);
            num3 += num4;
            num2 += (((~num | num3) ^ num4) + 0x4e0811a1) + A_0[13];
            num2 = (num2 << 0x15) | (num2 >> 11);
            num2 += num3;
            num += (((~num4 | num2) ^ num3) + 0xf7537e82) + A_0[4];
            num = (num << 6) | (num >> 0x1a);
            num += num2;
            num4 += (((~num3 | num) ^ num2) + 0xbd3af235) + A_0[11];
            num4 = (num4 << 10) | (num4 >> 0x16);
            num4 += num;
            num3 += (((~num2 | num4) ^ num) + 0x2ad7d2bb) + A_0[2];
            num3 = (num3 << 15) | (num3 >> 0x11);
            num3 += num4;
            num2 += (((~num | num3) ^ num4) + 0xeb86d391) + A_0[9];
            num2 = (num2 << 0x15) | (num2 >> 11);
            num2 += num3;
            this.uint_65[0] += num;
            this.uint_65[1] += num2;
            this.uint_65[2] += num3;
            this.uint_65[3] += num4;
        }

        public void StoreDigest()
        {
            int index = 0;
            for (int i = 0; index < 4; i += 4)
            {
                this.Digest[i] = (byte) (this.uint_65[index] & 0xff);
                this.Digest[i + 1] = (byte) ((this.uint_65[index] >> 8) & 0xff);
                this.Digest[i + 2] = (byte) ((this.uint_65[index] >> 0x10) & 0xff);
                this.Digest[i + 3] = (byte) ((this.uint_65[index] >> 0x18) & 0xff);
                index++;
            }
        }

        public void Update(byte[] buffer, int length)
        {
            int num = ((int) (this.uint_64[0] >> 3)) & 0x3f;
            if ((this.uint_64[0] + (length << 3)) < this.uint_64[0])
            {
                this.uint_64[1]++;
            }
            this.uint_64[0] += (uint) (length << 3);
            this.uint_64[1] += (uint) (length >> 0x1d);
            uint[] numArray = new uint[0x10];
            for (int i = 0; i < length; i++)
            {
                this.byte_1[num++] = buffer[i];
                if (num == 0x40)
                {
                    int index = 0;
                    for (int j = 0; index < 0x10; j += 4)
                    {
                        numArray[index] = (uint) ((((this.byte_1[j + 3] << 0x18) | (this.byte_1[j + 2] << 0x10)) | (this.byte_1[j + 1] << 8)) | this.byte_1[j]);
                        index++;
                    }
                    this.method_0(numArray);
                    num = 0;
                }
            }
        }

        public byte[] Digest
        {
            get
            {
                return this.byte_2;
            }
            set
            {
                this.byte_2 = value;
            }
        }
    }
}

