using Spire.Doc;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class118 : Interface13
{
    private byte[] byte_0;
    private static readonly byte[] byte_1 = new byte[] { 0xfe, 0xa7, 210, 0x76, 0x3b, 0x4b, 0x9e, 0x79 };
    private static readonly byte[] byte_2 = new byte[] { 0xd7, 170, 15, 0x6d, 0x30, 0x61, 0x34, 0x4e };
    private static readonly byte[] byte_3 = new byte[] { 20, 110, 11, 0xe7, 0xab, 0xac, 0xd0, 0xd6 };
    private static readonly byte[] byte_4 = new byte[] { 0x5f, 0xb2, 0xad, 1, 12, 0xb9, 0xe1, 0xf6 };
    private static readonly byte[] byte_5 = new byte[] { 160, 0x67, 0x7f, 2, 0xb2, 0x2c, 0x84, 0x33 };
    private Class426 class426_0;
    private Class803 class803_0;
    private RijndaelManaged rijndaelManaged_0 = new RijndaelManaged();

    void Interface13.imethod_0(Stream A_0, Stream A_1, Stream A_2, string A_3)
    {
        int num = 4;
        A_0.Position = 8L;
        BinaryReader reader = new BinaryReader(A_0);
        this.class426_0 = new Class426(reader);
        if (this.method_12().method_6() != BookmarkStart.b("欩椫紭", 4))
        {
            throw new InvalidOperationException(BookmarkStart.b("缩䈫崭䔯䈱䐳夵䨷丹夻娽怿⅁ⵃ㙅⁇⽉㹋湍ㅏ㹑㍓㥕⩗㍙⡛㙝ൟ䱡", num));
        }
        if (this.method_12().method_8() != BookmarkStart.b("礩搫漭į", num))
        {
            throw new InvalidOperationException(BookmarkStart.b("缩䈫崭䔯䈱䐳夵䨷丹夻娽怿⩁╃㕅⁇橉ⵋ≍㝏㵑♓㽕ⱗ㉙ㅛ灝", num));
        }
        this.method_0(A_3);
        if (!this.method_2())
        {
            throw new Exception(BookmarkStart.b("縩䐫䬭ု嘱嬳唵䴷圹夻倽㐿扁㑃❅㭇㥉㭋⅍≏㙑瑓㽕⭗穙㕛そ͟ൡᙣᑥ൧३ᡫ䁭", num));
        }
        if (!this.method_3(A_1))
        {
            throw new Exception(BookmarkStart.b("縩䐫䬭ု嘱嬳唵䴷圹夻倽㐿扁ⵃ⡅㱇⽉⭋㱍㥏♑ⵓ癕ㅗ⥙籛㡝şୡࡣͥ౧䑩", num));
        }
        byte[] buffer = this.method_4(this.method_12().method_9(), this.method_12().method_12(), byte_3);
        this.method_1(A_1, A_2, buffer);
    }

    void Interface13.imethod_1(Stream A_0, Stream A_1, Stream A_2, string A_3)
    {
        throw new NotImplementedException();
    }

    private void method_0(string A_0)
    {
        this.rijndaelManaged_0 = new RijndaelManaged();
        this.class803_0 = new Class803();
        this.rijndaelManaged_0.BlockSize = this.method_12().method_2() << 3;
        this.rijndaelManaged_0.KeySize = this.method_12().method_3();
        this.rijndaelManaged_0.Mode = (this.method_12().method_7() == BookmarkStart.b("瘴弶堸刺匼嘾⽀⑂ࡄ⡆ⵈ⹊์ॎፐ", 15)) ? CipherMode.CFB : CipherMode.CBC;
        this.rijndaelManaged_0.Padding = PaddingMode.Zeros;
        this.byte_0 = this.method_7(A_0, this.method_12().method_9(), this.method_12().method_5());
    }

    private void method_1(Stream A_0, Stream A_1, byte[] A_2)
    {
        A_0.Position = 0L;
        A_1.Position = 0L;
        long num = new BinaryReader(A_0).ReadInt64();
        A_1.SetLength((long) Class567.smethod_5(num, 0x200));
        byte[] buffer = new byte[0x1000];
        for (int i = 0; A_0.Position < A_0.Length; i++)
        {
            int count = Math.Min((int) (A_0.Length - A_0.Position), 0x1000);
            A_0.Read(buffer, 0, count);
            byte[] buffer2 = this.method_9(this.method_11().method_9(), BitConverter.GetBytes(i), this.method_11().method_2(), 0x36);
            byte[] buffer3 = this.method_6(A_2, buffer2, buffer);
            A_1.Write(buffer3, 0, count);
        }
        A_1.SetLength(num);
        A_1.Position = 0L;
    }

    private byte[] method_10(byte[] A_0, byte[] A_1)
    {
        byte[] array = new byte[A_0.Length + A_1.Length];
        A_0.CopyTo(array, 0);
        A_1.CopyTo(array, A_0.Length);
        return this.class803_0.method_0(array);
    }

    private Class426 method_11()
    {
        return this.class426_0;
    }

    private Class425 method_12()
    {
        return this.class426_0.method_14();
    }

    private bool method_2()
    {
        byte[] buffer = this.method_12().method_9();
        int num = this.method_12().method_4();
        byte[] buffer2 = smethod_0(this.method_4(buffer, this.method_12().method_11(), byte_2), num, 0);
        byte[] buffer3 = this.class803_0.method_0(this.method_4(buffer, this.method_12().method_10(), byte_1));
        return Class85.smethod_1(buffer2, buffer3);
    }

    private bool method_3(Stream A_0)
    {
        byte[] buffer = this.method_12().method_9();
        byte[] buffer2 = this.method_11().method_9();
        int num = this.method_11().method_4();
        int num2 = this.method_11().method_2();
        byte[] buffer3 = this.method_4(buffer, this.method_12().method_12(), byte_3);
        byte[] buffer4 = this.method_9(buffer2, byte_4, num2, 0);
        KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(BookmarkStart.b("挪怬渮爰", 5) + this.method_11().method_8());
        algorithm.Key = this.method_5(buffer3, buffer4, this.method_11().method_12(), num, 0);
        byte[] buffer5 = algorithm.ComputeHash(A_0);
        byte[] buffer6 = this.method_9(buffer2, byte_5, num2, 0);
        byte[] buffer7 = this.method_5(buffer3, buffer6, this.method_11().method_13(), num, 0);
        return Class85.smethod_1(buffer5, buffer7);
    }

    private byte[] method_4(byte[] A_0, byte[] A_1, byte[] A_2)
    {
        return this.method_6(this.method_8(A_2), A_0, A_1);
    }

    private byte[] method_5(byte[] A_0, byte[] A_1, byte[] A_2, int A_3, byte A_4)
    {
        return smethod_0(this.method_6(A_0, A_1, A_2), A_3, A_4);
    }

    private byte[] method_6(byte[] A_0, byte[] A_1, byte[] A_2)
    {
        byte[] buffer2;
        ICryptoTransform transform = this.rijndaelManaged_0.CreateDecryptor(A_0, A_1);
        byte[] buffer = null;
        using (MemoryStream stream = new MemoryStream(A_2, 0, A_2.Length))
        {
            using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
            {
                buffer = new byte[A_2.Length];
                stream2.Read(buffer, 0, buffer.Length);
                buffer2 = buffer;
            }
        }
        return buffer2;
    }

    private byte[] method_7(string A_0, byte[] A_1, int A_2)
    {
        byte[] bytes = Encoding.Unicode.GetBytes((A_0 != null) ? A_0 : "");
        byte[] buffer2 = this.method_10(A_1, bytes);
        byte[] buffer = new byte[buffer2.Length + 4];
        for (int i = 0; i < A_2; i++)
        {
            Class567.smethod_0(i, buffer, 0);
            buffer2.CopyTo(buffer, 4);
            buffer2 = this.class803_0.method_0(buffer);
        }
        return buffer2;
    }

    private byte[] method_8(byte[] A_0)
    {
        return this.method_9(this.byte_0, A_0, this.method_12().method_3() >> 3, 0x36);
    }

    private byte[] method_9(byte[] A_0, byte[] A_1, int A_2, byte A_3)
    {
        return smethod_0(this.method_10(A_0, A_1), A_2, A_3);
    }

    private static byte[] smethod_0(byte[] A_0, int A_1, byte A_2)
    {
        byte[] buffer = new byte[A_1];
        for (int i = 0; i < A_1; i++)
        {
            buffer[i] = (i < Math.Min(A_1, A_0.Length)) ? A_0[i] : A_2;
        }
        return buffer;
    }
}

