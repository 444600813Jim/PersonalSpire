using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

[CLSCompliant(false)]
internal class Class1071
{
    private byte[] byte_0;
    private Class299 class299_0 = new Class299();
    private Class62 class62_0;
    private Class876 class876_0;
    private const int int_0 = 0x1000;
    private Interface61 interface61_0;

    private bool method_0()
    {
        int num = 0x11;
        return ((this.class62_0 != null) && (this.class62_0.method_4().method_4().method_0().method_14() == BookmarkStart.b("搶焸稺࠼฾獀", num)));
    }

    internal Stream method_1()
    {
        int num = 0;
        if (this.byte_0 == null)
        {
            throw new InvalidOperationException(BookmarkStart.b("漥䘧䤩䌫尭䈯圱圳䈵ᠷ䨹崻䴽㌿㕁⭃㑅ⱇ摉", num));
        }
        MemoryStream stream2 = new MemoryStream();
        Class187 class2 = this.class62_0.method_4().method_0();
        bool flag = this.method_0();
        HashAlgorithm algorithm = null;
        if (flag)
        {
            algorithm = new SHA512Managed();
        }
        else
        {
            algorithm = new SHA1Managed();
        }
        using (Stream1 stream = this.interface61_0.imethod_0(BookmarkStart.b("挥䘧䤩師圭䀯䘱儳刵样嬹弻唽ℿ╁⅃", num)))
        {
            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, 8);
            int count = BitConverter.ToInt32(buffer, 0);
            int num3 = count % class2.method_2();
            int num4 = (num3 > 0) ? ((count + class2.method_2()) - num3) : count;
            byte[] buffer3 = new byte[num4];
            stream.Read(buffer3, 0, num4);
            byte[] buffer4 = this.class299_0.method_12(buffer, buffer3);
            if (!this.method_4(buffer4))
            {
                throw new Exception(BookmarkStart.b("挥䘧䤩師圭䀯䘱儳刵ᠷ䨹崻崽⬿⍁⍃⍅桇⍉㽋湍㥏㱑≓㝕㑗㍙㡛", num));
            }
            byte[] dst = new byte[count];
            int num6 = ((num4 % 0x1000) == 0) ? (num4 / 0x1000) : ((num4 / 0x1000) + 1);
            for (int i = 0; i < num6; i++)
            {
                int num7 = Math.Min(0x1000, num4 - (i * 0x1000));
                byte[] buffer5 = new byte[num7];
                byte[] src = new byte[num7];
                Buffer.BlockCopy(buffer3, i * 0x1000, buffer5, 0, num7);
                byte[] buffer7 = algorithm.ComputeHash(this.class299_0.method_12(class2.method_14(), BitConverter.GetBytes(i)));
                src = this.method_5(buffer5, class2.method_2(), this.byte_0, buffer7, num7);
                num7 = (i == (num6 - 1)) ? (num7 - (num4 - count)) : num7;
                Buffer.BlockCopy(src, 0, dst, i * 0x1000, num7);
            }
            stream2.Write(dst, 0, count);
            stream2.Position = 0L;
        }
        return stream2;
    }

    internal void method_2(Interface61 A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唥尧䔩師伭圯圱", num));
        }
        this.interface61_0 = A_0;
        using (Stream stream = A_0.imethod_0(BookmarkStart.b("挥䘧䤩師圭䀯䘱崳夵嘷猹刻堽⼿", num)))
        {
            this.class62_0 = new Class62(stream);
        }
        using (Interface61 interface2 = A_0.imethod_5(BookmarkStart.b("‥氧䬩堫伭振䈱唳唵崷䤹", num)))
        {
            this.method_7(interface2);
            this.method_6(interface2);
        }
    }

    internal bool method_3(string A_0)
    {
        Class187 class2 = this.class62_0.method_4().method_0();
        Class190 class3 = this.class62_0.method_4().method_4().method_0();
        bool flag = this.method_0();
        byte[] buffer = new byte[] { 0xfe, 0xa7, 210, 0x76, 0x3b, 0x4b, 0x9e, 0x79 };
        byte[] buffer2 = this.class299_0.method_8(A_0, class3.method_16(), buffer, class3.method_6() >> 3, class3.method_0(), flag);
        byte[] buffer3 = this.method_5(class3.method_18(), class3.method_4(), buffer2, class3.method_16(), class3.method_2());
        byte[] buffer4 = new byte[] { 0xd7, 170, 15, 0x6d, 0x30, 0x61, 0x34, 0x4e };
        byte[] buffer5 = this.class299_0.method_8(A_0, class3.method_16(), buffer4, class3.method_6() >> 3, class3.method_0(), flag);
        byte[] buffer6 = this.method_5(class3.method_20(), class3.method_4(), buffer5, class3.method_16(), class3.method_8());
        HashAlgorithm algorithm = null;
        if (flag)
        {
            algorithm = new SHA512Managed();
        }
        else
        {
            algorithm = new SHA1Managed();
        }
        byte[] buffer7 = algorithm.ComputeHash(buffer3);
        bool flag2 = this.class299_0.method_15(buffer6, buffer7);
        byte[] buffer8 = new byte[] { 20, 110, 11, 0xe7, 0xab, 0xac, 0xd0, 0xd6 };
        byte[] buffer9 = this.class299_0.method_8(A_0, class3.method_16(), buffer8, class3.method_6() >> 3, class3.method_0(), flag);
        this.byte_0 = this.method_5(class3.method_22(), class3.method_4(), buffer9, class3.method_16(), class2.method_4() / 8);
        return flag2;
    }

    private bool method_4(byte[] A_0)
    {
        Class187 class2 = this.class62_0.method_4().method_0();
        Class188 class3 = this.class62_0.method_4().method_2();
        bool flag = this.method_0();
        HashAlgorithm algorithm = null;
        if (flag)
        {
            algorithm = new SHA512Managed();
        }
        else
        {
            algorithm = new SHA1Managed();
        }
        byte[] buffer = new byte[] { 0x5f, 0xb2, 0xad, 1, 12, 0xb9, 0xe1, 0xf6 };
        byte[] buffer2 = algorithm.ComputeHash(this.class299_0.method_12(class2.method_14(), buffer));
        buffer2 = this.class299_0.method_13(buffer2, class2.method_2(), 0);
        byte[] buffer3 = this.method_5(class3.method_0(), class2.method_2(), this.byte_0, buffer2, class2.method_6());
        HMAC hmac = null;
        if (flag)
        {
            hmac = new HMACSHA512();
        }
        else
        {
            hmac = new HMACSHA1();
        }
        hmac.Key = this.class299_0.method_13(buffer3, class2.method_6(), 0);
        byte[] buffer4 = hmac.ComputeHash(A_0);
        byte[] buffer5 = new byte[] { 160, 0x67, 0x7f, 2, 0xb2, 0x2c, 0x84, 0x33 };
        byte[] buffer6 = algorithm.ComputeHash(this.class299_0.method_12(class2.method_14(), buffer5));
        buffer6 = this.class299_0.method_13(buffer6, class2.method_2(), 0);
        byte[] buffer7 = this.method_5(class3.method_2(), class2.method_2(), this.byte_0, buffer6, class2.method_6());
        return this.class299_0.method_15(buffer4, buffer7);
    }

    private byte[] method_5(byte[] A_0, int A_1, byte[] A_2, byte[] A_3, int A_4)
    {
        byte[] buffer5;
        int length = A_0.Length;
        byte[] dst = new byte[length];
        byte[] src = new byte[A_1];
        byte[] buffer3 = new byte[A_1];
        byte[] buffer4 = new byte[A_1];
        int num2 = this.class62_0.method_4().method_4().method_0().method_6();
        Class441.KeySize size = Class441.KeySize.Bits128;
        switch (num2)
        {
            case 0xc0:
                size = Class441.KeySize.Bits192;
                break;

            case 0x100:
                size = Class441.KeySize.Bits256;
                break;

            default:
                size = Class441.KeySize.Bits128;
                break;
        }
        Class441 class2 = new Class441(size, A_2);
        int srcOffset = 0;
        if ((length % A_1) != 0)
        {
            length = ((length / A_1) + 1) * A_1;
            buffer5 = this.class299_0.method_13(A_0, length, 0);
        }
        else
        {
            buffer5 = A_0;
        }
        while (srcOffset < length)
        {
            if (srcOffset == 0)
            {
                Buffer.BlockCopy(A_3, 0, buffer4, 0, A_1);
            }
            else
            {
                Buffer.BlockCopy(src, 0, buffer4, 0, A_1);
            }
            Buffer.BlockCopy(buffer5, srcOffset, src, 0, A_1);
            class2.method_2(src, buffer3);
            buffer3 = this.class299_0.method_14(buffer3, buffer4);
            Buffer.BlockCopy(buffer3, 0, dst, srcOffset, A_1);
            srcOffset += A_1;
        }
        if (dst.Length > A_4)
        {
            src = new byte[A_4];
            Buffer.BlockCopy(dst, 0, src, 0, A_4);
            dst = src;
        }
        return dst;
    }

    private void method_6(Interface61 A_0)
    {
        int num = 0;
        List<Class362> list = this.class876_0.method_0();
        if (list.Count != 1)
        {
            throw new Exception(BookmarkStart.b("漥䘧尩䴫䈭夯嘱ᐳ刵夷丹崻", num));
        }
        string str = list[0].method_1();
        string str2 = null;
        using (Interface61 interface3 = A_0.imethod_5(BookmarkStart.b("戥䤧帩䴫紭䀯匱圳匵焷吹娻儽", num)))
        {
            using (Stream stream = interface3.imethod_0(str))
            {
                List<string> list2 = new Class300(stream).method_0();
                if (list2.Count != 1)
                {
                    throw new Exception(BookmarkStart.b("漥䘧尩䴫䈭夯嘱ᐳ刵夷丹崻", num));
                }
                str2 = list2[0];
            }
        }
        using (Interface61 interface2 = A_0.imethod_5(BookmarkStart.b("爥娧䬩䈫崭嘯崱䘳嬵焷吹娻儽", num)))
        {
            using (Interface61 interface4 = interface2.imethod_5(str2))
            {
                this.method_8(interface4);
            }
        }
    }

    private void method_7(Interface61 A_0)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("倳圵䰷嬹漻丽ℿ⅁⅃㕅", num));
        }
        using (Stream1 stream = A_0.imethod_0(BookmarkStart.b("瀳圵䰷嬹漻丽ℿ⅁⅃୅⥇㩉", num)))
        {
            this.class876_0 = new Class876(stream);
        }
    }

    private void method_8(Interface61 A_0)
    {
        using (Stream stream = A_0.imethod_0(BookmarkStart.b("㈳昵䨷匹儻弽㈿㭁", 14)))
        {
            new Class610(stream);
            new Class1072(stream);
        }
    }
}

