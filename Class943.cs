using Spire.Doc;
using System;
using System.IO;

[CLSCompliant(false)]
internal class Class943
{
    private bool bool_0;
    private bool bool_1;
    private byte[] byte_0 = new byte[0x10];
    private byte[] byte_1 = new byte[0x40];
    private byte[] byte_2 = new byte[0x10];
    private byte[] byte_3 = new byte[0x40];
    private Class540 class540_0;
    private Class611 class611_0 = new Class611();
    private Class772 class772_0;
    private const int int_0 = 0x10;
    private const int int_1 = 0x40;
    private const int int_2 = 0x200;
    private const int int_3 = 0;
    private const int int_4 = 0x100;
    private MemoryStream memoryStream_0;
    private MemoryStream memoryStream_1;
    private MemoryStream memoryStream_2;
    private string string_0 = string.Empty;
    private const uint uint_0 = 0xce4b;
    private uint uint_1;
    private static readonly ushort[] ushort_0 = new ushort[] { 0xe1f0, 0x1d0f, 0xcc9c, 0x84c0, 0x110c, 0xe10, 0xf1ce, 0x313e, 0x1872, 0xe139, 0xd40f, 0x84f9, 0x280c, 0xa96a, 0x4ec3 };
    private static readonly ushort[,] ushort_1 = new ushort[,] { { 0xaefc, 0x7b61, 0x4563, 0x375, 0xd849, 0x6f45, 0xeb23, 0x47d3, 0xb861, 0x45a0, 0xaa51, 0x76b4, 0x3730, 0x3331, 0x1021 }, { 0x4dd9, 0xf6c2, 0x8ac6, 0x6ea, 0xa0b3, 0xde8a, 0xc667, 0x8fa6, 0x60e3, 0x8b40, 0x4483, 0xed68, 0x6e60, 0x6662, 0x2042 }, { 0x9bb2, 0xfda5, 0x5ad, 0xdd4, 0x5147, 0xad35, 0x9cef, 0xf6d, 0xc1c6, 0x6a1, 0x8906, 0xcaf1, 0xdcc0, 0xccc4, 0x4084 }, { 0x2745, 0xeb6b, 0xb5a, 0x1ba8, 0xa28e, 0x4a4b, 0x29ff, 0x1eda, 0x93ad, 0xd42, 0x22d, 0x85c3, 0xa9a1, 0x89a9, 0x8108 }, { 0x4e8a, 0xc6f7, 0x16b4, 0x3750, 0x553d, 0x9496, 0x53fe, 0x3db4, 0x377b, 0x1a84, 0x45a, 0x1ba7, 0x4363, 0x373, 0x1231 }, { 0x9d14, 0x9dcf, 0x2d68, 0x6ea0, 0xaa7a, 0x390d, 0xa7fc, 0x7b68, 0x6ef6, 0x3508, 0x8b4, 0x374e, 0x86c6, 0x6e6, 0x2462 }, { 0x2a09, 0x2bbf, 0x5ad0, 0xdd40, 0x44d5, 0x721a, 0x5fd9, 0xf6d0, 0xddec, 0x6a10, 0x1168, 0x6e9c, 0x1dad, 0xdcc, 0x48c4 } };

    internal Class943()
    {
    }

    internal MemoryStream method_0()
    {
        return this.memoryStream_0;
    }

    internal MemoryStream method_1()
    {
        return this.memoryStream_2;
    }

    internal bool method_10(string A_0)
    {
        int num = 6;
        if (this.memoryStream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("砫伭刯帱儳ᘵ欷丹主嬽ℿ⽁摃⽅㭇橉≋㭍㱏㹑瑓⑕㵗㱙㥛ⱝ՟ౡݣͥ౧䑩", num));
        }
        this.string_0 = A_0;
        if (this.method_6())
        {
            return this.method_25(A_0);
        }
        byte[] buffer = new byte[this.method_4()];
        this.memoryStream_0.Read(buffer, 0, (int) this.method_4());
        using (MemoryStream stream = new MemoryStream(buffer))
        {
            this.class540_0 = new Class540(stream);
        }
        if (this.class540_0.method_3() == 1)
        {
            this.memoryStream_0.Position = 4L;
            this.memoryStream_0.Read(this.byte_0, 0, 0x10);
            this.memoryStream_0.Read(this.byte_1, 0, 0x10);
            this.memoryStream_0.Read(this.byte_2, 0, 0x10);
            this.method_19(A_0);
            return this.method_23();
        }
        return this.method_24(A_0);
    }

    internal void method_11()
    {
        if (this.method_6())
        {
            this.method_16(this.memoryStream_0, false);
            this.method_16(this.memoryStream_2, true);
            this.method_16(this.memoryStream_1, false);
        }
        else if (this.class540_0.method_3() == 1)
        {
            this.memoryStream_0 = this.method_15(this.memoryStream_0);
            this.memoryStream_2 = this.method_15(this.memoryStream_2);
            if (this.memoryStream_1 != null)
            {
                this.memoryStream_1 = this.method_15(this.memoryStream_1);
            }
        }
        else
        {
            this.memoryStream_0 = this.method_17(this.memoryStream_0);
            this.memoryStream_2 = this.method_17(this.memoryStream_2);
            if (this.memoryStream_1 != null)
            {
                this.memoryStream_1 = this.method_17(this.memoryStream_1);
            }
        }
        this.method_13();
    }

    internal void method_12(string A_0)
    {
        this.byte_0 = Guid.NewGuid().ToByteArray();
        this.method_19(A_0);
        this.method_26();
        Buffer.BlockCopy(this.byte_0, 0, this.byte_1, 0, 0x10);
        this.byte_1[0x10] = 0x80;
        Array.Clear(this.byte_1, 0x11, 0x2f);
        this.byte_1[0x38] = 0x80;
        Class611 class2 = new Class611();
        class2.method_4(this.byte_1, 0x40);
        class2.method_6();
        Buffer.BlockCopy(class2.method_3(), 0, this.byte_2, 0, 0x10);
        this.method_21(0);
        this.method_27(this.byte_1, 0x10);
        this.method_27(this.byte_2, 0x10);
        this.memoryStream_0 = this.method_15(this.memoryStream_0);
        this.memoryStream_0.Position = 0L;
        this.memoryStream_0.WriteByte(1);
        this.memoryStream_0.WriteByte(0);
        this.memoryStream_0.WriteByte(1);
        this.memoryStream_0.WriteByte(0);
        this.memoryStream_0.Write(this.byte_0, 0, 0x10);
        this.memoryStream_0.Write(this.byte_1, 0, 0x10);
        this.memoryStream_0.Write(this.byte_2, 0, 0x10);
        this.memoryStream_2 = this.method_15(this.memoryStream_2);
        if (this.memoryStream_1 != null)
        {
            this.memoryStream_1 = this.method_15(this.memoryStream_1);
        }
        this.method_14();
    }

    private void method_13()
    {
        this.memoryStream_2.Position = 0L;
    }

    private void method_14()
    {
        this.memoryStream_2.Position = 0L;
    }

    private MemoryStream method_15(MemoryStream A_0)
    {
        byte[] buffer = new byte[0x10];
        MemoryStream stream = new MemoryStream();
        long length = A_0.Length;
        int num2 = 0;
        A_0.Position = 0L;
        uint num3 = 0;
        this.method_21(0);
        while (num2 < length)
        {
            for (int i = A_0.Read(buffer, 0, 0x10); i < 0x10; i++)
            {
                buffer[i] = 1;
            }
            this.method_27(buffer, 0x10);
            stream.Write(buffer, 0, 0x10);
            num2 += 0x10;
            if ((num2 % 0x200) == 0)
            {
                num3++;
                this.method_21(num3);
            }
        }
        stream.Position = 0L;
        return stream;
    }

    private void method_16(MemoryStream A_0, bool A_1)
    {
        if (A_0 != null)
        {
            Class944 class2 = new Class944();
            byte[] buffer = class2.method_2(this.string_0);
            int num = A_1 ? 0x44 : 0;
            class2.method_10(buffer, A_0, num);
        }
    }

    private MemoryStream method_17(MemoryStream A_0)
    {
        byte[] buffer = new byte[0x10];
        MemoryStream stream = new MemoryStream();
        long length = A_0.Length;
        int num2 = 0;
        A_0.Position = 0L;
        uint num3 = 0;
        using (Class945 class2 = new Class945(this.class540_0))
        {
            Class709 class3 = this.class540_0.method_7();
            Class494 class4 = this.class540_0.method_6();
            IntPtr ptr = class2.method_2(this.string_0, class3.method_0(), num3, class4.method_12());
            while (num2 < length)
            {
                for (int i = A_0.Read(buffer, 0, 0x10); i < 0x10; i++)
                {
                    buffer[i] = 1;
                }
                buffer = class2.method_1(ptr, buffer);
                stream.Write(buffer, 0, 0x10);
                num2 += 0x10;
                if ((num2 % 0x200) == 0)
                {
                    num3++;
                    Class946.CryptDestroyKey(ptr);
                    ptr = class2.method_2(this.string_0, class3.method_0(), num3, class4.method_12());
                }
            }
            Class946.CryptDestroyKey(ptr);
        }
        stream.Position = 0L;
        return stream;
    }

    private void method_18(ref byte A_0, ref byte A_1)
    {
        byte num = A_0;
        A_0 = A_1;
        A_1 = num;
    }

    private void method_19(string A_0)
    {
        int num = 0;
        while (num < A_0.Length)
        {
            this.byte_3[2 * num] = (byte) (A_0[num] & '\x00ff');
            this.byte_3[(2 * num) + 1] = (byte) ((A_0[num] >> 8) & '\x00ff');
            num++;
        }
        this.byte_3[2 * num] = 0x80;
        this.byte_3[0x38] = (byte) (num << 4);
    }

    internal MemoryStream method_2()
    {
        return this.memoryStream_1;
    }

    private void method_20(byte[] A_0)
    {
        this.class772_0 = new Class772();
        byte index = 0;
        byte num2 = 0;
        for (int i = 0; i < 0x100; i++)
        {
            this.class772_0.method_0()[i] = (byte) i;
        }
        for (int j = 0; j < 0x100; j++)
        {
            num2 = (byte) (((A_0[index] + this.class772_0.method_0()[j]) + num2) % 0x100);
            this.method_18(ref this.class772_0.method_0()[j], ref this.class772_0.method_0()[num2]);
            index = (byte) ((index + 1) % 0x10);
        }
    }

    private void method_21(uint A_0)
    {
        Class611 class2 = new Class611();
        byte[] dst = new byte[0x40];
        Buffer.BlockCopy(this.class611_0.method_3(), 0, dst, 0, 5);
        dst[5] = (byte) (A_0 & 0xff);
        dst[6] = (byte) ((A_0 >> 8) & 0xff);
        dst[7] = (byte) ((A_0 >> 0x10) & 0xff);
        dst[8] = (byte) ((A_0 >> 0x18) & 0xff);
        dst[9] = 0x80;
        dst[0x38] = 0x48;
        class2.method_4(dst, 0x40);
        class2.method_6();
        this.method_20(class2.method_3());
    }

    private bool method_22(byte[] A_0, byte[] A_1, int A_2)
    {
        for (int i = 0; i < A_2; i++)
        {
            if (A_0[i] != A_1[i])
            {
                return false;
            }
        }
        return true;
    }

    private bool method_23()
    {
        this.method_26();
        this.method_21(0);
        this.method_27(this.byte_1, 0x10);
        this.method_27(this.byte_2, 0x10);
        this.byte_1[0x10] = 0x80;
        Array.Clear(this.byte_1, 0x11, 0x2f);
        this.byte_1[0x38] = 0x80;
        Class611 class2 = new Class611();
        class2.method_4(this.byte_1, 0x40);
        class2.method_6();
        return this.method_22(class2.method_3(), this.byte_2, 0x10);
    }

    private bool method_24(string A_0)
    {
        using (Class945 class2 = new Class945(this.class540_0))
        {
            return class2.method_0(A_0);
        }
    }

    private bool method_25(string A_0)
    {
        Class944 class2 = new Class944();
        return class2.method_0(A_0, this.method_4());
    }

    private void method_26()
    {
        Class611 class2 = new Class611();
        class2.method_4(this.byte_3, 0x40);
        class2.method_6();
        this.class611_0 = new Class611();
        int dstOffset = 0;
        int srcOffset = 0;
        int count = 5;
        while (dstOffset != 0x10)
        {
            if ((0x40 - dstOffset) < 5)
            {
                count = 0x40 - dstOffset;
            }
            Buffer.BlockCopy(class2.method_3(), srcOffset, this.byte_3, dstOffset, count);
            dstOffset += count;
            if (dstOffset == 0x40)
            {
                this.class611_0.method_4(this.byte_3, 0x40);
                srcOffset = count;
                count = 5 - count;
                dstOffset = 0;
            }
            else
            {
                srcOffset = 0;
                count = 5;
                Buffer.BlockCopy(this.byte_0, 0, this.byte_3, dstOffset, 0x10);
                dstOffset += 0x10;
            }
        }
        this.byte_3[0x10] = 0x80;
        Array.Clear(this.byte_3, 0x11, 0x2f);
        this.byte_3[0x38] = 0x80;
        this.byte_3[0x39] = 10;
        this.class611_0.method_4(this.byte_3, 0x40);
        this.class611_0.method_6();
    }

    private void method_27(byte[] A_0, int A_1)
    {
        for (int i = 0; i < A_1; i++)
        {
            this.class772_0.method_3((byte) ((this.class772_0.method_2() + 1) % 0x100));
            this.class772_0.method_5((byte) ((this.class772_0.method_0()[this.class772_0.method_2()] + this.class772_0.method_4()) % 0x100));
            this.method_18(ref this.class772_0.method_0()[this.class772_0.method_2()], ref this.class772_0.method_0()[this.class772_0.method_4()]);
            byte index = (byte) ((this.class772_0.method_0()[this.class772_0.method_2()] + this.class772_0.method_0()[this.class772_0.method_4()]) % 0x100);
            A_0[i] = (byte) (A_0[i] ^ this.class772_0.method_0()[index]);
        }
    }

    internal Class540 method_3()
    {
        return this.class540_0;
    }

    internal uint method_4()
    {
        return this.uint_1;
    }

    internal void method_5(uint A_0)
    {
        this.uint_1 = A_0;
    }

    internal bool method_6()
    {
        return this.bool_1;
    }

    internal void method_7(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public void method_8(ref MemoryStream A_0, string A_1, ref byte[] A_2, ref byte[] A_3, ref byte[] A_4)
    {
        this.byte_0 = A_2;
        this.method_19(A_1);
        this.method_26();
        Buffer.BlockCopy(this.byte_0, 0, this.byte_1, 0, 0x10);
        this.byte_1[0x10] = 0x80;
        Array.Clear(this.byte_1, 0x11, 0x2f);
        this.byte_1[0x38] = 0x80;
        Class611 class2 = new Class611();
        class2.method_4(this.byte_1, 0x40);
        class2.method_6();
        Buffer.BlockCopy(class2.method_3(), 0, this.byte_2, 0, 0x10);
        this.method_21(0);
        this.method_27(this.byte_1, 0x10);
        this.method_27(this.byte_2, 0x10);
        A_0 = this.method_15(A_0);
        A_2 = this.byte_0;
        A_3 = this.byte_1;
        A_4 = this.byte_2;
    }

    public void method_9(ref MemoryStream A_0, string A_1, ref byte[] A_2, ref byte[] A_3, ref byte[] A_4)
    {
        Buffer.BlockCopy(A_2, 0, this.byte_0, 0, 0x10);
        Buffer.BlockCopy(A_3, 0, this.byte_1, 0, 0x10);
        Buffer.BlockCopy(A_4, 0, this.byte_2, 0, 0x10);
        this.method_19(A_1);
        this.method_23();
        A_0 = this.method_15(A_0);
    }

    internal static uint smethod_0(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return 0;
        }
        if (A_0.Length > 15)
        {
            A_0 = A_0.Substring(0, 15);
        }
        ushort num = smethod_3(A_0);
        uint num3 = (uint) (smethod_2(A_0) << 0x10);
        return (num3 | num);
    }

    private static uint smethod_1(uint A_0)
    {
        uint num = 0;
        for (int i = 0; i < 4; i++)
        {
            num |= A_0 & 0xff;
            if (i < 3)
            {
                num = num << 8;
                A_0 = A_0 >> 8;
            }
        }
        return num;
    }

    private static ushort smethod_2(string A_0)
    {
        ushort num = ushort_0[A_0.Length - 1];
        int num2 = 15 - A_0.Length;
        int num3 = 0;
        int length = A_0.Length;
        while (num3 < length)
        {
            char ch = A_0[num3];
            bool[] flagArray = smethod_4(ch);
            for (int i = 0; i < 7; i++)
            {
                if (flagArray[i])
                {
                    num = (ushort) (num ^ ushort_1[i, num2 + num3]);
                }
            }
            num3++;
        }
        return num;
    }

    private static ushort smethod_3(string A_0)
    {
        if (A_0 == null)
        {
            return 0;
        }
        ushort num3 = 0;
        int num = 0;
        int length = A_0.Length;
        while (num < length)
        {
            ushort num2 = smethod_6(smethod_7(smethod_5(A_0[num]), num + 1));
            num3 = (ushort) (num3 ^ num2);
            num++;
        }
        return (ushort) ((num3 ^ A_0.Length) ^ 0xce4bL);
    }

    private static bool[] smethod_4(char A_0)
    {
        ushort num = 1;
        bool[] flagArray = new bool[7];
        ushort num2 = Convert.ToUInt16(A_0);
        if ((num2 & 0xff) == 0)
        {
            num2 = (ushort) (num2 >> 8);
        }
        for (int i = 0; i < 7; i++)
        {
            flagArray[i] = (num2 & num) == num;
            num = (ushort) (num << 1);
        }
        return flagArray;
    }

    private static bool[] smethod_5(char A_0)
    {
        bool[] flagArray = new bool[15];
        ushort num = Convert.ToUInt16(A_0);
        ushort num2 = 1;
        for (int i = 0; i < 15; i++)
        {
            flagArray[i] = (num & num2) == num2;
            num2 = (ushort) (num2 << 1);
        }
        return flagArray;
    }

    private static ushort smethod_6(bool[] A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐥䄧帩弫", num));
        }
        if (A_0.Length > 0x10)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("爥䀧伩師䬭ု儱唳堵ἷ丹᰻尽┿扁⥃⥅㩇⽉汋㩍㡏㍑㩓癕楗汙籛㱝य़ᙡᝣ", num));
        }
        ushort num3 = 0;
        ushort num4 = 1;
        int index = 0;
        int length = A_0.Length;
        while (index < length)
        {
            if (A_0[index])
            {
                num3 = (ushort) (num3 + num4);
            }
            num4 = (ushort) (num4 << 1);
            index++;
        }
        return num3;
    }

    private static bool[] smethod_7(bool[] A_0, int A_1)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䰭夯䘱䜳", num));
        }
        if (A_0.Length == 0)
        {
            return A_0;
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䴭弯䜱娳䈵ᠷ夹崻倽朿㙁摃⑅ⵇ橉⁋⭍⍏⅑瑓≕し㭙㉛繝᩟ݡᙣ॥", num));
        }
        bool[] flagArray = new bool[A_0.Length];
        int index = 0;
        int length = A_0.Length;
        while (index < length)
        {
            int num4 = (index + A_1) % length;
            flagArray[num4] = A_0[index];
            index++;
        }
        return flagArray;
    }

    public static int smethod_8(int A_0, int A_1)
    {
        int num2 = 0x10;
        if (A_1 == 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("刵崷崹主嬽┿扁❃❅♇浉㡋湍㉏㝑瑓晕", num2));
        }
        int num = A_0 % A_1;
        return ((A_0 - num) + A_1);
    }
}

