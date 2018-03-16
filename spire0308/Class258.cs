using System;
using System.IO;
using System.Security.Cryptography;

internal class Class258
{
    public static ICryptoTransform smethod_0(byte[] A_0)
    {
        return smethod_2(A_0).CreateDecryptor();
    }

    public static ICryptoTransform smethod_1(byte[] A_0)
    {
        return smethod_2(A_0).CreateEncryptor();
    }

    private static RijndaelManaged smethod_2(byte[] A_0)
    {
        return new RijndaelManaged { BlockSize = 0x80, KeySize = A_0.Length * 8, Key = A_0, IV = A_0, Mode = CipherMode.ECB, Padding = PaddingMode.None };
    }

    public static void smethod_3(Stream A_0, Stream A_1, ICryptoTransform A_2)
    {
        CryptoStream stream = new CryptoStream(A_0, A_2, CryptoStreamMode.Read);
        Class567.smethod_8(stream, A_1);
    }
}

