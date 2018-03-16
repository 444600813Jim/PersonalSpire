using Spire.Doc.Fields.Shape;
using System;

internal class Class1078
{
    public static byte[] smethod_0(byte[] A_0)
    {
        int srcOffset = 0;
        while (A_0[srcOffset++] == 0)
        {
            if (srcOffset >= A_0.Length)
            {
                break;
            }
        }
        srcOffset--;
        if (srcOffset > 0)
        {
            byte[] dst = new byte[A_0.Length - srcOffset];
            Buffer.BlockCopy(A_0, srcOffset, dst, 0, dst.Length);
            return dst;
        }
        return A_0;
    }

    public static byte[] smethod_1(byte[] A_0, int A_1)
    {
        byte[] dst = new byte[A_1];
        Buffer.BlockCopy(A_0, 0, dst, dst.Length - A_0.Length, A_0.Length);
        return dst;
    }

    public static byte[] smethod_2(Rsa A_0, byte[] A_1)
    {
        return A_0.Encrypt(A_1);
    }
}

