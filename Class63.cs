using Spire.Doc;
using System;
using System.Security.Cryptography;
using System.Text;

[CLSCompliant(false)]
internal class Class63
{
    internal const int int_0 = 0x186a0;
    internal const int int_1 = 4;
    internal const string string_0 = "rsaFull";
    internal const string string_1 = "hash";
    internal const string string_2 = "typeAny";

    internal Class63()
    {
    }

    internal byte[] method_0(byte[] A_0, uint A_1)
    {
        int num = 10;
        byte[] buffer = new byte[4];
        for (int i = 0; i < 4; i++)
        {
            buffer[i] = Convert.ToByte((uint) (((uint) (A_1 & (0xff << ((i * 8) & 0x1f)))) >> (i * 8)));
        }
        string s = string.Empty;
        for (int j = 0; j < 4; j++)
        {
            s = s + buffer[j].ToString(BookmarkStart.b("栯1", num));
        }
        s = s.Trim().Trim(new char[] { 0xfeff }).ToUpper();
        byte[] bytes = Encoding.Unicode.GetBytes(s);
        byte[] buffer3 = this.method_1(A_0, bytes);
        SHA1 sha = new SHA1Managed();
        buffer3 = sha.ComputeHash(buffer3);
        byte[] array = new byte[0x18];
        for (int k = 0; k < 0x186a0; k++)
        {
            buffer3.CopyTo(array, 0);
            int num4 = k;
            for (int m = 0; m < 4; m++)
            {
                array[buffer3.Length + m] = (byte) num4;
                num4 = num4 >> 8;
            }
            buffer3 = sha.ComputeHash(array);
        }
        return buffer3;
    }

    private byte[] method_1(byte[] A_0, byte[] A_1)
    {
        byte[] dst = new byte[A_0.Length + A_1.Length];
        Buffer.BlockCopy(A_0, 0, dst, 0, A_0.Length);
        Buffer.BlockCopy(A_1, 0, dst, A_0.Length, A_1.Length);
        return dst;
    }

    internal byte[] method_2(int A_0)
    {
        int num = 14;
        if (A_0 <= 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("堳匵嘷崹䠻嘽", num));
        }
        byte[] buffer = new byte[A_0];
        Random random = new Random((int) DateTime.Now.Ticks);
        int maxValue = 0x100;
        for (int i = 0; i < A_0; i++)
        {
            buffer[i] = (byte) random.Next(maxValue);
        }
        return buffer;
    }
}

