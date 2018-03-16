using Spire.Doc;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

[CLSCompliant(false)]
internal sealed class Class991
{
    private const int int_0 = 0xc350;
    internal const string string_0 = "EncryptionInfo";
    internal const string string_1 = "\x0006DataSpaces";
    internal const string string_2 = "DataSpaceMap";
    internal const string string_3 = "\x0006Primary";
    internal const string string_4 = "DataSpaceInfo";
    internal const string string_5 = "TransformInfo";
    internal const string string_6 = "EncryptedPackage";
    internal const string string_7 = "StrongEncryptionDataSpace";
    internal const string string_8 = "StrongEncryptionTransform";
    internal const string string_9 = "Version";

    internal int method_0(Stream A_0, byte[] A_1)
    {
        int num = 2;
        if (A_0.Read(A_1, 0, 4) != 4)
        {
            throw new Exception(BookmarkStart.b("愧䐩娫伭尯嬱倳ᘵ尷嬹䠻弽", num));
        }
        return BitConverter.ToInt32(A_1, 0);
    }

    internal string method_1(Stream A_0)
    {
        int num = 3;
        byte[] buffer = new byte[4];
        int count = this.method_0(A_0, buffer);
        buffer = new byte[count];
        if (A_0.Read(buffer, 0, count) != count)
        {
            throw new Exception(BookmarkStart.b("怨䔪嬬丮崰娲儴᜶崸娺䤼帾", num));
        }
        string str = Encoding.Unicode.GetString(buffer, 0, buffer.Length);
        int num3 = count % 4;
        if (num3 != 0)
        {
            A_0.Position += 4 - num3;
        }
        return str;
    }

    internal byte[] method_10(byte[] A_0, byte[] A_1)
    {
        int length = A_0.Length;
        int count = A_1.Length;
        int num3 = length + count;
        byte[] dst = new byte[num3];
        Buffer.BlockCopy(A_0, 0, dst, 0, length);
        Buffer.BlockCopy(A_1, 0, dst, length, count);
        return dst;
    }

    internal byte[] method_11(byte[] A_0, int A_1, byte A_2)
    {
        byte[] dst = new byte[A_1];
        if (A_0.Length < A_1)
        {
            Buffer.BlockCopy(A_0, 0, dst, 0, A_0.Length);
            for (int i = A_0.Length; i < A_1; i++)
            {
                dst[i] = A_2;
            }
            return dst;
        }
        if (A_0.Length >= A_1)
        {
            Buffer.BlockCopy(A_0, 0, dst, 0, A_1);
        }
        return dst;
    }

    internal byte[] method_12(byte[] A_0, byte[] A_1)
    {
        byte[] buffer = new byte[A_0.Length];
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (byte) (A_0[i] ^ A_1[i]);
        }
        return buffer;
    }

    internal bool method_13(byte[] A_0, byte[] A_1)
    {
        for (int i = 0; i < A_0.Length; i++)
        {
            if (A_0[i] != A_1[i])
            {
                return false;
            }
        }
        return true;
    }

    internal string method_2(Stream A_0)
    {
        StringBuilder builder = new StringBuilder();
        byte[] buffer = new byte[2];
        while (A_0.Read(buffer, 0, 2) > 0)
        {
            string str = Encoding.Unicode.GetString(buffer, 0, buffer.Length);
            if (str[0] == '\0')
            {
                break;
            }
            builder.Append(str);
        }
        return builder.ToString();
    }

    internal void method_3(Stream A_0, int A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, 4);
    }

    internal void method_4(Stream A_0, string A_1)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(A_1);
        int length = bytes.Length;
        this.method_3(A_0, length);
        A_0.Write(bytes, 0, length);
        int num2 = length % 4;
        if (num2 != 0)
        {
            int num3 = 0;
            int num4 = 4 - num2;
            while (num3 < num4)
            {
                A_0.WriteByte(0);
                num3++;
            }
        }
    }

    internal void method_5(Stream A_0, string A_1)
    {
        int length = A_1.Length;
        byte[] bytes = Encoding.Unicode.GetBytes(A_1);
        A_0.Write(bytes, 0, bytes.Length);
        if ((length == 0) || (A_1[length - 1] != '\0'))
        {
            A_0.WriteByte(0);
            A_0.WriteByte(0);
        }
    }

    internal byte[] method_6(string A_0, byte[] A_1, int A_2)
    {
        byte[] buffer8;
        SHA1 sha = new SHA1Managed();
        byte[] bytes = Encoding.Unicode.GetBytes(A_0);
        byte[] dst = new byte[A_1.Length + bytes.Length];
        Buffer.BlockCopy(A_1, 0, dst, 0, A_1.Length);
        Buffer.BlockCopy(bytes, 0, dst, A_1.Length, bytes.Length);
        byte[] buffer3 = sha.ComputeHash(dst);
        byte[] buffer4 = new byte[buffer3.Length + 4];
        byte[] src = buffer3;
        for (int i = 0; i < 0xc350; i++)
        {
            buffer8 = BitConverter.GetBytes(i);
            Buffer.BlockCopy(buffer8, 0, buffer4, 0, buffer8.Length);
            Buffer.BlockCopy(src, 0, buffer4, buffer8.Length, src.Length);
            src = sha.ComputeHash(buffer4);
        }
        buffer8 = BitConverter.GetBytes(0);
        Buffer.BlockCopy(src, 0, buffer4, 0, src.Length);
        Buffer.BlockCopy(buffer8, 0, buffer4, src.Length, buffer8.Length);
        byte[] buffer9 = sha.ComputeHash(buffer4);
        byte[] buffer = new byte[0x40];
        for (int j = 0; j < 0x40; j++)
        {
            buffer[j] = 0x36;
        }
        int index = 0;
        int length = buffer9.Length;
        while (index < length)
        {
            buffer[index] = (byte) (buffer[index] ^ buffer9[index]);
            index++;
        }
        byte[] buffer7 = sha.ComputeHash(buffer);
        for (int k = 0; k < 0x40; k++)
        {
            buffer[k] = 0x5c;
        }
        int num3 = 0;
        int num4 = buffer9.Length;
        while (num3 < num4)
        {
            buffer[num3] = (byte) (buffer[num3] ^ buffer9[num3]);
            num3++;
        }
        sha.ComputeHash(buffer);
        if (A_2 > buffer7.Length)
        {
            throw new NotImplementedException();
        }
        byte[] buffer10 = new byte[A_2];
        Buffer.BlockCopy(buffer7, 0, buffer10, 0, A_2);
        return buffer10;
    }

    internal byte[] method_7(string A_0, byte[] A_1, byte[] A_2, int A_3, int A_4)
    {
        SHA1 sha = new SHA1Managed();
        byte[] bytes = Encoding.Unicode.GetBytes(A_0);
        byte[] buffer2 = sha.ComputeHash(this.method_10(A_1, bytes));
        for (int i = 0; i < A_4; i++)
        {
            buffer2 = sha.ComputeHash(this.method_10(BitConverter.GetBytes(i), buffer2));
        }
        buffer2 = sha.ComputeHash(this.method_10(buffer2, A_2));
        return this.method_11(buffer2, A_3, 0x36);
    }

    internal byte[] method_8(HashAlgorithm A_0, string A_1, byte[] A_2, byte[] A_3, int A_4, int A_5)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(A_1);
        byte[] buffer2 = A_0.ComputeHash(this.method_10(A_2, bytes));
        for (int i = 0; i < A_5; i++)
        {
            buffer2 = A_0.ComputeHash(this.method_10(BitConverter.GetBytes(i), buffer2));
        }
        buffer2 = A_0.ComputeHash(this.method_10(buffer2, A_3));
        return this.method_11(buffer2, A_4, 0x36);
    }

    internal byte[] method_9(byte[] A_0, Delegate8 A_1, int A_2)
    {
        int length = A_0.Length;
        byte[] dst = new byte[length];
        byte[] buffer2 = new byte[A_2];
        byte[] buffer3 = new byte[A_2];
        for (int i = 0; i < length; i += A_2)
        {
            int num3 = length - i;
            int count = Math.Min(num3, A_2);
            Buffer.BlockCopy(A_0, i, buffer2, 0, count);
            A_1(buffer2, buffer3);
            Buffer.BlockCopy(buffer3, 0, dst, i, count);
        }
        return dst;
    }

    internal delegate void Delegate8(byte[] A_0, byte[] A_1);
}

