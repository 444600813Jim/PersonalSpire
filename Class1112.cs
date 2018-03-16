using System;

internal class Class1112
{
    private static readonly byte[] byte_0 = new byte[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
    public static readonly int[] int_0 = new int[] { 
        0x10, 0x11, 0x12, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 
        14, 1, 15
     };

    public static short smethod_0(int A_0)
    {
        return (short) ((((byte_0[A_0 & 15] << 12) | (byte_0[(A_0 >> 4) & 15] << 8)) | (byte_0[(A_0 >> 8) & 15] << 4)) | byte_0[A_0 >> 12]);
    }
}

