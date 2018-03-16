using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class1009 : IDisposable
{
    private const byte byte_0 = 7;
    private const byte byte_1 = 12;
    private const byte byte_10 = 0x10;
    private const byte byte_11 = 0x17;
    private const byte byte_12 = 6;
    private const byte byte_13 = 10;
    private const byte byte_14 = 15;
    private const byte byte_15 = 0x15;
    private static byte[] byte_16;
    private byte[] byte_17 = new byte[0x40];
    protected byte[] byte_18;
    private const byte byte_2 = 0x11;
    private const byte byte_3 = 0x16;
    private const byte byte_4 = 5;
    private const byte byte_5 = 9;
    private const byte byte_6 = 14;
    private const byte byte_7 = 20;
    private const byte byte_8 = 4;
    private const byte byte_9 = 11;
    protected int int_0;
    protected int int_1 = 0x80;
    private uint[] uint_0 = new uint[4];
    private uint[] uint_1 = new uint[2];

    static Class1009()
    {
        byte[] buffer = new byte[0x40];
        buffer[0] = 0x80;
        byte_16 = buffer;
    }

    internal Class1009()
    {
        this.vmethod_0();
    }

    private void method_0(byte[] A_0, int A_1)
    {
        uint num = this.uint_0[0];
        uint num2 = this.uint_0[1];
        uint num3 = this.uint_0[2];
        uint num4 = this.uint_0[3];
        uint[] numArray = new uint[0x10];
        smethod_14(numArray, 0, A_0, A_1, 0x40);
        smethod_9(ref num, num2, num3, num4, numArray[0], 7, 0xd76aa478);
        smethod_9(ref num4, num, num2, num3, numArray[1], 12, 0xe8c7b756);
        smethod_9(ref num3, num4, num, num2, numArray[2], 0x11, 0x242070db);
        smethod_9(ref num2, num3, num4, num, numArray[3], 0x16, 0xc1bdceee);
        smethod_9(ref num, num2, num3, num4, numArray[4], 7, 0xf57c0faf);
        smethod_9(ref num4, num, num2, num3, numArray[5], 12, 0x4787c62a);
        smethod_9(ref num3, num4, num, num2, numArray[6], 0x11, 0xa8304613);
        smethod_9(ref num2, num3, num4, num, numArray[7], 0x16, 0xfd469501);
        smethod_9(ref num, num2, num3, num4, numArray[8], 7, 0x698098d8);
        smethod_9(ref num4, num, num2, num3, numArray[9], 12, 0x8b44f7af);
        smethod_9(ref num3, num4, num, num2, numArray[10], 0x11, 0xffff5bb1);
        smethod_9(ref num2, num3, num4, num, numArray[11], 0x16, 0x895cd7be);
        smethod_9(ref num, num2, num3, num4, numArray[12], 7, 0x6b901122);
        smethod_9(ref num4, num, num2, num3, numArray[13], 12, 0xfd987193);
        smethod_9(ref num3, num4, num, num2, numArray[14], 0x11, 0xa679438e);
        smethod_9(ref num2, num3, num4, num, numArray[15], 0x16, 0x49b40821);
        smethod_10(ref num, num2, num3, num4, numArray[1], 5, 0xf61e2562);
        smethod_10(ref num4, num, num2, num3, numArray[6], 9, 0xc040b340);
        smethod_10(ref num3, num4, num, num2, numArray[11], 14, 0x265e5a51);
        smethod_10(ref num2, num3, num4, num, numArray[0], 20, 0xe9b6c7aa);
        smethod_10(ref num, num2, num3, num4, numArray[5], 5, 0xd62f105d);
        smethod_10(ref num4, num, num2, num3, numArray[10], 9, 0x2441453);
        smethod_10(ref num3, num4, num, num2, numArray[15], 14, 0xd8a1e681);
        smethod_10(ref num2, num3, num4, num, numArray[4], 20, 0xe7d3fbc8);
        smethod_10(ref num, num2, num3, num4, numArray[9], 5, 0x21e1cde6);
        smethod_10(ref num4, num, num2, num3, numArray[14], 9, 0xc33707d6);
        smethod_10(ref num3, num4, num, num2, numArray[3], 14, 0xf4d50d87);
        smethod_10(ref num2, num3, num4, num, numArray[8], 20, 0x455a14ed);
        smethod_10(ref num, num2, num3, num4, numArray[13], 5, 0xa9e3e905);
        smethod_10(ref num4, num, num2, num3, numArray[2], 9, 0xfcefa3f8);
        smethod_10(ref num3, num4, num, num2, numArray[7], 14, 0x676f02d9);
        smethod_10(ref num2, num3, num4, num, numArray[12], 20, 0x8d2a4c8a);
        smethod_11(ref num, num2, num3, num4, numArray[5], 4, 0xfffa3942);
        smethod_11(ref num4, num, num2, num3, numArray[8], 11, 0x8771f681);
        smethod_11(ref num3, num4, num, num2, numArray[11], 0x10, 0x6d9d6122);
        smethod_11(ref num2, num3, num4, num, numArray[14], 0x17, 0xfde5380c);
        smethod_11(ref num, num2, num3, num4, numArray[1], 4, 0xa4beea44);
        smethod_11(ref num4, num, num2, num3, numArray[4], 11, 0x4bdecfa9);
        smethod_11(ref num3, num4, num, num2, numArray[7], 0x10, 0xf6bb4b60);
        smethod_11(ref num2, num3, num4, num, numArray[10], 0x17, 0xbebfbc70);
        smethod_11(ref num, num2, num3, num4, numArray[13], 4, 0x289b7ec6);
        smethod_11(ref num4, num, num2, num3, numArray[0], 11, 0xeaa127fa);
        smethod_11(ref num3, num4, num, num2, numArray[3], 0x10, 0xd4ef3085);
        smethod_11(ref num2, num3, num4, num, numArray[6], 0x17, 0x4881d05);
        smethod_11(ref num, num2, num3, num4, numArray[9], 4, 0xd9d4d039);
        smethod_11(ref num4, num, num2, num3, numArray[12], 11, 0xe6db99e5);
        smethod_11(ref num3, num4, num, num2, numArray[15], 0x10, 0x1fa27cf8);
        smethod_11(ref num2, num3, num4, num, numArray[2], 0x17, 0xc4ac5665);
        smethod_12(ref num, num2, num3, num4, numArray[0], 6, 0xf4292244);
        smethod_12(ref num4, num, num2, num3, numArray[7], 10, 0x432aff97);
        smethod_12(ref num3, num4, num, num2, numArray[14], 15, 0xab9423a7);
        smethod_12(ref num2, num3, num4, num, numArray[5], 0x15, 0xfc93a039);
        smethod_12(ref num, num2, num3, num4, numArray[12], 6, 0x655b59c3);
        smethod_12(ref num4, num, num2, num3, numArray[3], 10, 0x8f0ccc92);
        smethod_12(ref num3, num4, num, num2, numArray[10], 15, 0xffeff47d);
        smethod_12(ref num2, num3, num4, num, numArray[1], 0x15, 0x85845dd1);
        smethod_12(ref num, num2, num3, num4, numArray[8], 6, 0x6fa87e4f);
        smethod_12(ref num4, num, num2, num3, numArray[15], 10, 0xfe2ce6e0);
        smethod_12(ref num3, num4, num, num2, numArray[6], 15, 0xa3014314);
        smethod_12(ref num2, num3, num4, num, numArray[13], 0x15, 0x4e0811a1);
        smethod_12(ref num, num2, num3, num4, numArray[4], 6, 0xf7537e82);
        smethod_12(ref num4, num, num2, num3, numArray[11], 10, 0xbd3af235);
        smethod_12(ref num3, num4, num, num2, numArray[2], 15, 0x2ad7d2bb);
        smethod_12(ref num2, num3, num4, num, numArray[9], 0x15, 0xeb86d391);
        this.uint_0[0] += num;
        this.uint_0[1] += num2;
        this.uint_0[2] += num3;
        this.uint_0[3] += num4;
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = 0;
        }
    }

    public void method_1()
    {
        this.vmethod_9(true);
    }

    public byte[] method_2(byte[] A_0)
    {
        return this.method_3(A_0, 0, A_0.Length);
    }

    public byte[] method_3(byte[] A_0, int A_1, int A_2)
    {
        this.vmethod_0();
        this.vmethod_1(A_0, A_1, A_2);
        this.byte_18 = this.vmethod_2();
        return (byte[]) this.byte_18.Clone();
    }

    public byte[] method_4(Stream A_0)
    {
        this.vmethod_0();
        int num = 0;
        byte[] buffer = new byte[0x1000];
        while (0 < (num = A_0.Read(buffer, 0, 0x1000)))
        {
            this.vmethod_1(buffer, 0, num);
        }
        this.byte_18 = this.vmethod_2();
        return (byte[]) this.byte_18.Clone();
    }

    public int method_5(byte[] A_0, int A_1, int A_2, byte[] A_3, int A_4)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("儷吹䰻䬽㐿Aㅃ⁅⹇⽉㹋", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("儷吹䰻䬽㐿ു≃⁅㭇⽉㡋", num));
        }
        if ((A_2 < 0) || (A_2 > A_0.Length))
        {
            throw new ArgumentException(BookmarkStart.b("儷吹䰻䬽㐿Ł⭃㍅♇㹉", num));
        }
        if ((A_0.Length - A_2) < A_1)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("儷吹䰻䬽㐿ു≃⁅㭇⽉㡋", num));
        }
        if (this.int_0 == 0)
        {
            this.vmethod_0();
            this.int_0 = 1;
        }
        this.vmethod_1(A_0, A_1, A_2);
        if ((A_0 != A_3) || (A_1 != A_4))
        {
            Buffer.BlockCopy(A_0, A_1, A_3, A_4, A_2);
        }
        return A_2;
    }

    public byte[] method_6(byte[] A_0, int A_1, int A_2)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䘮弰䌲䀴䌶笸为嬼夾⑀ㅂ", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘮弰䌲䀴䌶瘸崺嬼䰾⑀㝂", num));
        }
        if ((A_2 < 0) || (A_2 > A_0.Length))
        {
            throw new ArgumentException(BookmarkStart.b("䘮弰䌲䀴䌶稸吺䠼儾㕀", num));
        }
        if ((A_0.Length - A_2) < A_1)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘮弰䌲䀴䌶瘸崺嬼䰾⑀㝂", num));
        }
        if (this.int_0 == 0)
        {
            this.vmethod_0();
        }
        this.vmethod_1(A_0, A_1, A_2);
        this.byte_18 = this.vmethod_2();
        byte[] dst = new byte[A_2];
        Buffer.BlockCopy(A_0, A_1, dst, 0, A_2);
        this.int_0 = 0;
        return dst;
    }

    public static Class1009 smethod_0(string A_0)
    {
        if (!(A_0 == BookmarkStart.b("欥氧Ἡ", 0)))
        {
            throw new NotSupportedException();
        }
        return new Class1009();
    }

    public static string smethod_1(string A_0)
    {
        UTF8Encoding encoding = new UTF8Encoding();
        string str = smethod_2(encoding.GetBytes(A_0));
        encoding = null;
        return str;
    }

    private static void smethod_10(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (smethod_5(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = smethod_8(A_0, A_5);
        A_0 += A_1;
    }

    private static void smethod_11(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (smethod_6(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = smethod_8(A_0, A_5);
        A_0 += A_1;
    }

    private static void smethod_12(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (smethod_7(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = smethod_8(A_0, A_5);
        A_0 += A_1;
    }

    private static void smethod_13(byte[] A_0, int A_1, uint[] A_2, int A_3, int A_4)
    {
        int num = A_1 + A_4;
        int index = A_3;
        for (int i = A_1; i < num; i += 4)
        {
            A_0[i] = (byte) (A_2[index] & 0xff);
            A_0[i + 1] = (byte) ((A_2[index] >> 8) & 0xff);
            A_0[i + 2] = (byte) ((A_2[index] >> 0x10) & 0xff);
            A_0[i + 3] = (byte) ((A_2[index] >> 0x18) & 0xff);
            index++;
        }
    }

    private static void smethod_14(uint[] A_0, int A_1, byte[] A_2, int A_3, int A_4)
    {
        int num = A_3 + A_4;
        int index = A_1;
        for (int i = A_3; i < num; i += 4)
        {
            A_0[index] = (uint) (((A_2[i] | (A_2[i + 1] << 8)) | (A_2[i + 2] << 0x10)) | (A_2[i + 3] << 0x18));
            index++;
        }
    }

    public static string smethod_2(byte[] A_0)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            return string.Empty;
        }
        using (Class1009 class2 = smethod_3())
        {
            byte[] buffer = class2.method_2(A_0);
            StringBuilder builder = new StringBuilder();
            foreach (byte num3 in buffer)
            {
                builder.Append(num3.ToString(BookmarkStart.b("䄸ऺ", num)));
            }
            return builder.ToString();
        }
    }

    public static Class1009 smethod_3()
    {
        return new Class1009();
    }

    private static uint smethod_4(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 & A_1) | (~A_0 & A_2));
    }

    private static uint smethod_5(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 & A_2) | (A_1 & ~A_2));
    }

    private static uint smethod_6(uint A_0, uint A_1, uint A_2)
    {
        return ((A_0 ^ A_1) ^ A_2);
    }

    private static uint smethod_7(uint A_0, uint A_1, uint A_2)
    {
        return (A_1 ^ (A_0 | ~A_2));
    }

    private static uint smethod_8(uint A_0, byte A_1)
    {
        return ((A_0 << A_1) | (A_0 >> (0x20 - A_1)));
    }

    private static void smethod_9(ref uint A_0, uint A_1, uint A_2, uint A_3, uint A_4, byte A_5, uint A_6)
    {
        A_0 += (smethod_4(A_1, A_2, A_3) + A_4) + A_6;
        A_0 = smethod_8(A_0, A_5);
        A_0 += A_1;
    }

    void IDisposable.Dispose()
    {
        this.vmethod_9(true);
    }

    public virtual void vmethod_0()
    {
        this.uint_1[1] = 0;
        this.uint_1[0] = 0;
        this.uint_0[0] = 0x67452301;
        this.uint_0[1] = 0xefcdab89;
        this.uint_0[2] = 0x98badcfe;
        this.uint_0[3] = 0x10325476;
    }

    protected virtual void vmethod_1(byte[] A_0, int A_1, int A_2)
    {
        int num3;
        int dstOffset = ((int) (this.uint_1[0] >> 3)) & 0x3f;
        if ((this.uint_1[0] += ((uint) (A_2 << 3))) < (A_2 << 3))
        {
            this.uint_1[1]++;
        }
        this.uint_1[1] += (uint) (A_2 >> 0x1d);
        int count = 0x40 - dstOffset;
        if (A_2 >= count)
        {
            Buffer.BlockCopy(A_0, A_1, this.byte_17, dstOffset, count);
            this.method_0(this.byte_17, 0);
            for (num3 = count; (num3 + 0x3f) < A_2; num3 += 0x40)
            {
                this.method_0(A_0, A_1 + num3);
            }
            dstOffset = 0;
        }
        else
        {
            num3 = 0;
        }
        Buffer.BlockCopy(A_0, A_1 + num3, this.byte_17, dstOffset, A_2 - num3);
    }

    protected virtual byte[] vmethod_2()
    {
        byte[] buffer = new byte[0x10];
        byte[] buffer2 = new byte[8];
        smethod_13(buffer2, 0, this.uint_1, 0, 8);
        int num = ((int) (this.uint_1[0] >> 3)) & 0x3f;
        int num2 = (num < 0x38) ? (0x38 - num) : (120 - num);
        this.vmethod_1(byte_16, 0, num2);
        this.vmethod_1(buffer2, 0, 8);
        smethod_13(buffer, 0, this.uint_0, 0, 0x10);
        this.uint_1[1] = 0;
        this.uint_1[0] = 0;
        this.uint_0[0] = 0;
        this.uint_0[1] = 0;
        this.uint_0[2] = 0;
        this.uint_0[3] = 0;
        this.vmethod_0();
        return buffer;
    }

    public virtual bool vmethod_3()
    {
        return true;
    }

    public virtual bool vmethod_4()
    {
        return true;
    }

    public virtual byte[] vmethod_5()
    {
        if (this.int_0 != 0)
        {
            throw new InvalidOperationException();
        }
        return (byte[]) this.byte_18.Clone();
    }

    public virtual int vmethod_6()
    {
        return this.int_1;
    }

    public virtual int vmethod_7()
    {
        return 1;
    }

    public virtual int vmethod_8()
    {
        return 1;
    }

    protected virtual void vmethod_9(bool A_0)
    {
        if (!A_0)
        {
            this.vmethod_0();
        }
    }
}

