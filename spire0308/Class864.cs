using Spire.Doc;
using Spire.Doc.Documents.Converters.Encryption;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class864 : Interface13
{
    private readonly Random random_0 = new Random();

    void Interface13.imethod_0(Stream A_0, Stream A_1, Stream A_2, string A_3)
    {
        A_0.Position = 8L;
        BinaryReader reader = new BinaryReader(A_0);
        Class1103 class2 = new Class1103(reader);
        Class534 class3 = new Class534(reader, true);
        smethod_0(class2);
        Class803 class4 = new Class803();
        ICryptoTransform transform = Class258.smethod_0(smethod_5(class2.int_1, class4, A_3, class3.byte_0));
        smethod_1(transform, class3);
        smethod_2(transform, A_1, A_2);
    }

    void Interface13.imethod_1(Stream A_0, Stream A_1, Stream A_2, string A_3)
    {
        Class803 class2 = new Class803();
        BinaryWriter writer = new BinaryWriter(A_0);
        smethod_3(writer);
        byte[] buffer = this.method_1(0x10);
        ICryptoTransform transform = Class258.smethod_1(smethod_5(0x80, class2, A_3, buffer));
        this.method_0(transform, buffer).method_0(writer);
        smethod_4(transform, A_1, A_2);
    }

    private Class534 method_0(ICryptoTransform A_0, byte[] A_1)
    {
        Class803 class2 = new Class803();
        byte[] buffer = this.method_1(0x10);
        byte[] sourceArray = class2.method_0(buffer);
        byte[] destinationArray = new byte[0x20];
        Array.Copy(sourceArray, destinationArray, sourceArray.Length);
        return new Class534 { byte_0 = A_1, int_0 = 0x10, int_1 = 0x20, byte_1 = A_0.TransformFinalBlock(buffer, 0, buffer.Length), byte_2 = A_0.TransformFinalBlock(destinationArray, 0, destinationArray.Length) };
    }

    private byte[] method_1(int A_0)
    {
        byte[] buffer = new byte[A_0];
        this.random_0.NextBytes(buffer);
        return buffer;
    }

    private static void smethod_0(Class1103 A_0)
    {
        int num = 10;
        if (A_0.headerFlags_0 != (HeaderFlags.Aes | HeaderFlags.CryptoApi))
        {
            throw new InvalidOperationException(BookmarkStart.b("支就儳丵䠷弹弻䨽┿♁摃⍅♇⥉㹋㝍⁏♑㵓㥕㙗穙㩛㉝şաᝣ䡥", num));
        }
        if (((A_0.algorithmType_0 != AlgorithmType.Aes128) && (A_0.algorithmType_0 != AlgorithmType.Aes192)) && (A_0.algorithmType_0 != AlgorithmType.Aes256))
        {
            throw new InvalidOperationException(BookmarkStart.b("支就儳丵䠷弹弻䨽┿♁摃⍅♇⥉㹋㝍⁏♑㵓㥕㙗穙㵛㉝ݟൡᙣཥᱧɩū乭᥯ᙱ婳", num));
        }
        if (A_0.algorithmIdHash_0 != AlgorithmIdHash.Sha1)
        {
            throw new InvalidOperationException(BookmarkStart.b("支就儳丵䠷弹弻䨽┿♁摃⍅♇⥉㹋㝍⁏♑㵓㥕㙗穙㵛㉝ݟൡᙣཥᱧɩū乭ᡯ፱ݳṵ塷፹᡻偽", num));
        }
    }

    private static void smethod_1(ICryptoTransform A_0, Class534 A_1)
    {
        int num = 0x11;
        Class803 class2 = new Class803();
        byte[] buffer = A_0.TransformFinalBlock(A_1.byte_1, 0, A_1.byte_1.Length);
        byte[] buffer2 = A_0.TransformFinalBlock(A_1.byte_2, 0, A_1.byte_2.Length);
        byte[] buffer3 = class2.method_0(buffer);
        if (!Class85.smethod_11(buffer2, buffer3, A_1.int_1))
        {
            throw new Exception(BookmarkStart.b("挶儸帺ᴼ嬾⹀⁂い⩆ⱈ╊㥌潎⅐㉒♔⑖⹘㑚⽜㭞䅠੢ᙤ䝦hժ๬nͰŲၴᑶ൸啺", num));
        }
    }

    private static void smethod_2(ICryptoTransform A_0, Stream A_1, Stream A_2)
    {
        A_1.Position = 0L;
        A_2.Position = 0L;
        long num = new BinaryReader(A_1).ReadInt64();
        A_2.SetLength((long) Class567.smethod_5(num, 0x200));
        Class258.smethod_3(A_1, A_2, A_0);
        A_2.SetLength(num);
        A_1.Position = 0L;
        A_2.Position = 0L;
    }

    private static void smethod_3(BinaryWriter A_0)
    {
        A_0.Write(0x20004);
        A_0.Write(0x24);
        A_0.Write(140);
        A_0.Write(0x24);
        A_0.Write(0);
        A_0.Write(0x660e);
        A_0.Write(0x8004);
        A_0.Write(0x80);
        A_0.Write(0x18);
        A_0.Write(0);
        A_0.Write(0);
        Class1029.smethod_8(BookmarkStart.b("男匹弻䰽⼿ㅁ⭃⁅㱇橉ो⁍㡏㍑㩓㕕㵗㹙籛ౝ㍟⍡䑣ݥ٧๩䱫⽭㕯ⅱ味㕵੷͹౻੽낏슑秊ﮝ튟", 0x12), A_0);
    }

    private static void smethod_4(ICryptoTransform A_0, Stream A_1, Stream A_2)
    {
        A_1.Position = 0L;
        A_2.Position = 0L;
        long length = A_1.Length;
        A_1.SetLength((long) Class567.smethod_5(A_1.Length, 0x10));
        new BinaryWriter(A_2).Write(length);
        A_2.SetLength((long) (Class567.smethod_5(length, 0x10) + 8));
        Class258.smethod_3(A_1, A_2, A_0);
        A_1.Position = 0L;
        A_2.Position = 0L;
    }

    private static byte[] smethod_5(int A_0, Class803 A_1, string A_2, byte[] A_3)
    {
        byte[] buffer = smethod_6(A_1, A_2, A_3);
        byte[] buffer2 = smethod_7(A_1, 0x36, buffer);
        byte[] buffer3 = smethod_7(A_1, 0x5c, buffer);
        byte[] array = new byte[buffer2.Length + buffer3.Length];
        buffer2.CopyTo(array, 0);
        buffer3.CopyTo(array, buffer2.Length);
        byte[] destinationArray = new byte[A_0 / 8];
        Array.Copy(array, 0, destinationArray, 0, destinationArray.Length);
        return destinationArray;
    }

    private static byte[] smethod_6(Class803 A_0, string A_1, byte[] A_2)
    {
        if (A_1 == null)
        {
            A_1 = "";
        }
        byte[] bytes = Encoding.Unicode.GetBytes(A_1);
        byte[] array = new byte[A_2.Length + bytes.Length];
        A_2.CopyTo(array, 0);
        bytes.CopyTo(array, A_2.Length);
        byte[] buffer2 = A_0.method_0(array);
        byte[] buffer = new byte[4 + buffer2.Length];
        for (int i = 0; i < 0xc350; i++)
        {
            Class567.smethod_0(i, buffer, 0);
            buffer2.CopyTo(buffer, 4);
            buffer2 = A_0.method_0(buffer);
        }
        buffer2.CopyTo(buffer, 0);
        Class567.smethod_0(0, buffer, buffer2.Length);
        return A_0.method_0(buffer);
    }

    private static byte[] smethod_7(Class803 A_0, byte A_1, byte[] A_2)
    {
        byte[] buffer = new byte[0x40];
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = A_1;
        }
        for (int j = 0; j < A_2.Length; j++)
        {
            buffer[j] = (byte) (buffer[j] ^ A_2[j]);
        }
        return A_0.method_0(buffer);
    }
}

