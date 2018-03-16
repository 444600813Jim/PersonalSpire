using Spire.Doc;
using Spire.Doc.Documents.Converters.Encryption;
using System;
using System.IO;
using System.Text;

internal class Class987
{
    private byte[] byte_0;
    private readonly Random random_0 = new Random();
    private const string string_0 = "WordDocument";
    private const string string_1 = "Data";
    private const string string_2 = "1Table";
    private const string string_3 = "\x0005SummaryInformation";
    private const string string_4 = "\x0005DocumentSummaryInformation";

    internal void method_0(Class1132 A_0, string A_1, string A_2)
    {
        int num = 6;
        BinaryReader reader = new BinaryReader(A_0.method_0().method_5(A_1));
        switch (((VersionInfo) reader.ReadInt32()))
        {
            case VersionInfo.CryptoApi:
            case VersionInfo.CryptoApi2007:
            case VersionInfo.CryptoApi2010:
                throw new NotSupportedException(BookmarkStart.b("縫洭Яሱ娳夵䰷ᨹ伻䬽〿㉁⭃㑅㱇⽉⡋恍", num));

            case VersionInfo.RC4:
                if (!this.method_13(reader, A_2))
                {
                    throw new Exception(BookmarkStart.b("簫伭䌯䄱䌳夵䨷帹᰻᰽", num) + A_2 + BookmarkStart.b("หอ夯䄱ᐳ張嘷夹医䰽㈿❁❃㉅楇", num));
                }
                this.method_8(A_0, A_1);
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("礫䀭唯䨱䐳匵嬷丹夻娽怿❁⩃╅㩇㍉㱋㩍㥏㵑㩓癕⹗㽙⹛ⵝय़ൡ੣䡥", num));
    }

    internal void method_1(Class1132 A_0, Class703 A_1, string A_2)
    {
        int num = 0x12;
        string key = A_1.method_0();
        Stream stream = null;
        Stream stream2 = null;
        Stream stream3 = null;
        if (A_0.method_0().ContainsKey(key))
        {
            stream = A_0.method_0().method_5(A_1.method_0());
        }
        if (A_0.method_0().ContainsKey(BookmarkStart.b("漷唹主娽пⵁ❃㍅╇⽉≋㩍", num)))
        {
            stream2 = A_0.method_0().method_5(BookmarkStart.b("漷唹主娽пⵁ❃㍅╇⽉≋㩍", num));
        }
        if (A_0.method_0().ContainsKey(BookmarkStart.b("簷嬹䠻弽", num)))
        {
            stream3 = A_0.method_0().method_5(BookmarkStart.b("簷嬹䠻弽", num));
        }
        if (A_1.bool_11)
        {
            Class988 class3 = new Class988();
            if (class3.method_0(A_2, (uint) A_1.int_8))
            {
                this.method_4(stream, false, A_2);
                this.method_4(stream2, true, A_2);
                this.method_4(stream3, false, A_2);
                return;
            }
        }
        else
        {
            BinaryReader reader = new BinaryReader(stream);
            switch (((VersionInfo) reader.ReadInt32()))
            {
                case VersionInfo.CryptoApi:
                case VersionInfo.CryptoApi2007:
                case VersionInfo.CryptoApi2010:
                {
                    stream.Position = 0L;
                    byte[] buffer = new byte[A_1.int_8];
                    stream.Read(buffer, 0, A_1.int_8);
                    Class994 class2 = null;
                    using (MemoryStream stream4 = new MemoryStream(buffer))
                    {
                        class2 = new Class994(stream4);
                    }
                    if (!this.method_3(A_2, class2))
                    {
                        break;
                    }
                    A_0.method_0()[key] = this.method_5(stream, A_2, class2);
                    A_0.method_0()[BookmarkStart.b("漷唹主娽пⵁ❃㍅╇⽉≋㩍", num)] = this.method_5(stream2, A_2, class2);
                    if (stream3 != null)
                    {
                        A_0.method_0()[BookmarkStart.b("簷嬹䠻弽", num)] = this.method_5(stream3, A_2, class2);
                    }
                    return;
                }
                case VersionInfo.RC4:
                    if (this.method_13(reader, A_2))
                    {
                        this.method_8(A_0, key);
                        return;
                    }
                    break;

                default:
                    throw new InvalidOperationException(BookmarkStart.b("洷吹夻䘽〿❁❃㉅ⵇ⹉汋⭍㹏ㅑ♓⽕⡗⹙㕛ㅝ๟䉡ባͥᩧᥩիŭṯ山", num));
            }
        }
        this.method_2(A_2);
    }

    private void method_10(Class1154 A_0, Stream A_1)
    {
        if (A_1 != null)
        {
            A_1.Position = 0L;
            uint num3 = 0;
            this.method_11(A_0, 0);
            byte[] buffer = new byte[0x10];
            int num2 = 0;
            while (num2 < A_1.Length)
            {
                int num = A_1.Read(buffer, 0, buffer.Length);
                A_0.method_0(buffer, num);
                A_1.Position -= num;
                A_1.Write(buffer, 0, num);
                num2 += num;
                if ((num2 % 0x200) == 0)
                {
                    num3++;
                    this.method_11(A_0, num3);
                }
            }
            A_1.Position = 0L;
        }
    }

    private void method_11(Class1154 A_0, uint A_1)
    {
        byte[] destinationArray = new byte[0x10];
        Array.Copy(this.byte_0, 0, destinationArray, 0, 5);
        Array.Copy(BitConverter.GetBytes(A_1), 0, destinationArray, 5, 4);
        A_0.method_5(smethod_1(destinationArray, 9));
    }

    private Class1154 method_12(string A_0, byte[] A_1)
    {
        byte[] bytes = Encoding.Unicode.GetBytes((A_0 == null) ? "" : A_0);
        this.byte_0 = smethod_0(bytes);
        byte[] destinationArray = new byte[0x150];
        for (int i = 0; i < 0x10; i++)
        {
            Array.Copy(this.byte_0, 0, destinationArray, i * 0x15, 5);
            Array.Copy(A_1, 0, destinationArray, (i * 0x15) + 5, 0x10);
        }
        this.byte_0 = smethod_0(destinationArray);
        Class1154 class2 = new Class1154();
        this.method_11(class2, 0);
        return class2;
    }

    private bool method_13(BinaryReader A_0, string A_1)
    {
        byte[] buffer = A_0.ReadBytes(0x10);
        byte[] buffer2 = A_0.ReadBytes(0x10);
        byte[] buffer3 = A_0.ReadBytes(0x10);
        Class1154 class2 = this.method_12(A_1, buffer);
        class2.method_0(buffer2, 0x10);
        class2.method_0(buffer3, 0x10);
        return Class85.smethod_11(smethod_0(buffer2), buffer3, 0x10);
    }

    private void method_14(BinaryWriter A_0, string A_1)
    {
        byte[] buffer = this.method_15(0x10);
        byte[] buffer2 = this.method_15(0x10);
        Class1154 class2 = this.method_12(A_1, buffer);
        byte[] buffer3 = new byte[0x10];
        byte[] buffer4 = new byte[0x10];
        class2.method_2(buffer2, buffer3);
        class2.method_2(smethod_0(buffer2), buffer4);
        A_0.Write(buffer);
        A_0.Write(buffer3);
        A_0.Write(buffer4);
    }

    private byte[] method_15(int A_0)
    {
        byte[] buffer = new byte[A_0];
        this.random_0.NextBytes(buffer);
        return buffer;
    }

    private void method_2(string A_0)
    {
        throw new PasswordErrorException(BookmarkStart.b("朳䘵崷夹唻堽⤿❁⁃晅㡇⭉㽋㵍❏㵑♓㉕硗硙", 14) + A_0 + BookmarkStart.b("ᘳᘵ儷䤹᰻圽⸿⅁⭃㑅㩇⽉⽋㩍煏", 14));
    }

    private bool method_3(string A_0, Class994 A_1)
    {
        using (Class989 class2 = new Class989(A_1.method_6(), A_1.method_7()))
        {
            return class2.method_2(A_0);
        }
    }

    private void method_4(Stream A_0, bool A_1, string A_2)
    {
        if (A_0 != null)
        {
            Class988 class2 = new Class988();
            byte[] buffer = class2.method_2(A_2);
            int num = A_1 ? 0x44 : 0;
            class2.method_10(buffer, A_0, num);
        }
    }

    private MemoryStream method_5(Stream A_0, string A_1, Class994 A_2)
    {
        byte[] buffer = new byte[0x10];
        MemoryStream stream = new MemoryStream();
        long length = A_0.Length;
        int num2 = 0;
        A_0.Position = 0L;
        uint num3 = 0;
        using (Class989 class2 = new Class989(A_2.method_6(), A_2.method_7()))
        {
            Class992 class3 = A_2.method_7();
            Class993 class4 = A_2.method_6();
            IntPtr ptr = class2.method_4(A_1, class3.method_0(), num3, class4.method_12());
            while (num2 < length)
            {
                for (int i = A_0.Read(buffer, 0, 0x10); i < 0x10; i++)
                {
                    buffer[i] = 1;
                }
                buffer = class2.method_3(ptr, buffer);
                stream.Write(buffer, 0, 0x10);
                num2 += 0x10;
                if ((num2 % 0x200) == 0)
                {
                    num3++;
                    Class990.CryptDestroyKey(ptr);
                    ptr = class2.method_4(A_1, class3.method_0(), num3, class4.method_12());
                }
            }
            Class990.CryptDestroyKey(ptr);
        }
        stream.Position = 0L;
        return stream;
    }

    internal void method_6(BinaryWriter A_0, string A_1)
    {
        A_0.Write(0x10001);
        this.method_14(A_0, A_1);
    }

    internal void method_7(Class1132 A_0, string A_1)
    {
        this.method_8(A_0, A_1);
    }

    private void method_8(Class1132 A_0, string A_1)
    {
        Class1154 class2 = new Class1154();
        this.method_9(class2, A_0, A_1, 0x34);
        this.method_9(class2, A_0, BookmarkStart.b("怶嘸䤺夼笾⹀⁂い⩆ⱈ╊㥌", 0x11), 0x44);
        this.method_9(class2, A_0, BookmarkStart.b("猶堸伺尼", 0x11), 0);
    }

    private void method_9(Class1154 A_0, Class1132 A_1, string A_2, int A_3)
    {
        Stream stream = (MemoryStream) A_1.method_0()[A_2];
        if (stream != null)
        {
            byte[] buffer = new byte[A_3];
            stream.Position = 0L;
            stream.Read(buffer, 0, A_3);
            this.method_10(A_0, stream);
            stream.Position = 0L;
            stream.Write(buffer, 0, A_3);
        }
    }

    private static byte[] smethod_0(byte[] A_0)
    {
        Class489 class2 = new Class489();
        class2.method_0(A_0, A_0.Length);
        class2.method_1();
        return class2.method_4();
    }

    private static byte[] smethod_1(byte[] A_0, int A_1)
    {
        Class489 class2 = new Class489();
        class2.method_0(A_0, A_1);
        class2.method_1();
        return class2.method_4();
    }
}

