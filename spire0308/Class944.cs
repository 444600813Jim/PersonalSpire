using System;
using System.IO;
using System.Text;

internal class Class944
{
    private byte[] byte_0 = new byte[] { 0xbb, 0xff, 0xff, 0xba, 0xff, 0xff, 0xb9, 0x80, 0, 190, 15, 0, 0xbf, 15, 0 };
    public const int int_0 = 0x44;
    public const int int_1 = 15;
    private ushort[] ushort_0 = new ushort[] { 0xe1f0, 0x1d0f, 0xcc9c, 0x84c0, 0x110c, 0xe10, 0xf1ce, 0x313e, 0x1872, 0xe139, 0xd40f, 0x84f9, 0x280c, 0xa96a, 0x4ec3 };
    private ushort[] ushort_1 = new ushort[] { 
        0xaefc, 0x4dd9, 0x9bb2, 0x2745, 0x4e8a, 0x9d14, 0x2a09, 0x7b61, 0xf6c2, 0xfda5, 0xeb6b, 0xc6f7, 0x9dcf, 0x2bbf, 0x4563, 0x8ac6, 
        0x5ad, 0xb5a, 0x16b4, 0x2d68, 0x5ad0, 0x375, 0x6ea, 0xdd4, 0x1ba8, 0x3750, 0x6ea0, 0xdd40, 0xd849, 0xa0b3, 0x5147, 0xa28e, 
        0x553d, 0xaa7a, 0x44d5, 0x6f45, 0xde8a, 0xad35, 0x4a4b, 0x9496, 0x390d, 0x721a, 0xeb23, 0xc667, 0x9cef, 0x29ff, 0x53fe, 0xa7fc, 
        0x5fd9, 0x47d3, 0x8fa6, 0xf6d, 0x1eda, 0x3db4, 0x7b68, 0xf6d0, 0xb861, 0x60e3, 0xc1c6, 0x93ad, 0x377b, 0x6ef6, 0xddec, 0x45a0, 
        0x8b40, 0x6a1, 0xd42, 0x1a84, 0x3508, 0x6a10, 0xaa51, 0x4483, 0x8906, 0x22d, 0x45a, 0x8b4, 0x1168, 0x76b4, 0xed68, 0xcaf1, 
        0x85c3, 0x1ba7, 0x374e, 0x6e9c, 0x3730, 0x6e60, 0xdcc0, 0xa9a1, 0x4363, 0x86c6, 0x1dad, 0x3331, 0x6662, 0xccc4, 0x89a9, 0x373, 
        0x6e6, 0xdcc, 0x1021, 0x2042, 0x4084, 0x8108, 0x1231, 0x2462, 0x48c4
     };

    internal bool method_0(string A_0, uint A_1)
    {
        return (this.method_8(A_0) == (A_1 & 0xffffffffL));
    }

    public ushort method_1(byte[] A_0)
    {
        ushort num = 0;
        byte[] destinationArray = new byte[A_0.Length + 1];
        destinationArray[0] = (byte) A_0.Length;
        Array.Copy(A_0, 0, destinationArray, 1, A_0.Length);
        for (int i = destinationArray.Length - 1; i >= 0; i--)
        {
            byte num3 = destinationArray[i];
            ushort num4 = ((num & 0x4000) == 0) ? ((ushort) 0) : ((ushort) 1);
            ushort num5 = (ushort) (num * 2);
            num5 = (ushort) (num5 & 0x7fff);
            ushort num6 = (ushort) (num4 | num5);
            num = (ushort) (num6 ^ num3);
        }
        return (ushort) (num ^ 0xce4b);
    }

    public void method_10(byte[] A_0, MemoryStream A_1, int A_2)
    {
        if (A_1 != null)
        {
            byte[] buffer = new byte[A_2];
            A_1.Position = 0L;
            A_1.Read(buffer, 0, A_2);
            A_1.Position = 0L;
            for (int i = 0; A_1.Position < A_1.Length; i = i % 0x10)
            {
                byte num = (byte) A_1.ReadByte();
                byte num3 = (byte) (num ^ A_0[i]);
                if ((num != 0) && (num3 != 0))
                {
                    A_1.Position -= 1L;
                    A_1.WriteByte((byte) (num ^ A_0[i]));
                }
                i++;
            }
            A_1.Position = 0L;
            A_1.Write(buffer, 0, A_2);
        }
    }

    private byte[] method_11(string A_0)
    {
        int num = Math.Min(A_0.Length, 15);
        byte[] buffer = new byte[num];
        char[] chars = A_0.ToCharArray();
        for (int i = 0; i < num; i++)
        {
            byte[] buffer2 = Encoding.Unicode.GetBytes(chars, i, 1);
            buffer[i] = (buffer2[0] != 0) ? buffer2[0] : buffer2[buffer2.Length - 1];
        }
        return buffer;
    }

    public byte[] method_2(string A_0)
    {
        byte[] buffer = this.method_11(A_0);
        ushort num = this.method_3(buffer);
        int length = buffer.Length;
        byte[] buffer2 = new byte[0x10];
        if ((length % 2) == 1)
        {
            byte num3 = (byte) (num >> 8);
            buffer2[length] = this.method_4(this.byte_0[0], num3);
            length--;
            num3 = (byte) (num & 0xff);
            byte num4 = buffer[buffer.Length - 1];
            buffer2[length] = this.method_4(num4, num3);
        }
        while (length > 0)
        {
            length--;
            byte num7 = (byte) (num >> 8);
            buffer2[length] = this.method_4(buffer[length], num7);
            length--;
            num7 = (byte) (num & 0xff);
            buffer2[length] = this.method_4(buffer[length], num7);
        }
        length = 15;
        for (int i = 15 - A_0.Length; i > 0; i--)
        {
            byte num5 = (byte) (num >> 8);
            buffer2[length] = this.method_4(this.byte_0[i], num5);
            length--;
            i--;
            num5 = (byte) (num & 0xff);
            buffer2[length] = this.method_4(this.byte_0[i], num5);
            length--;
        }
        return buffer2;
    }

    public ushort method_3(byte[] A_0)
    {
        ushort num = this.ushort_0[A_0.Length - 1];
        int index = 0x68;
        for (int i = A_0.Length - 1; i >= 0; i--)
        {
            byte num5 = A_0[i];
            for (int j = 0; j < 7; j++)
            {
                if ((num5 & 0x40) != 0)
                {
                    num = (ushort) (num ^ this.ushort_1[index]);
                }
                num5 = (byte) (num5 * 2);
                index--;
            }
        }
        return num;
    }

    public byte method_4(byte A_0, byte A_1)
    {
        return this.method_5((byte) (A_0 ^ A_1));
    }

    public byte method_5(byte A_0)
    {
        int num = A_0 >> 1;
        int num2 = A_0 << 7;
        int num3 = num | num2;
        return (byte) (num3 % 0x100);
    }

    public void method_6(string A_0, byte[] A_1, int A_2)
    {
        byte[] buffer = this.method_2(A_0);
        int index = 0;
        int length = A_1.Length;
        while (index < length)
        {
            byte num3 = A_1[index];
            num3 = (byte) (num3 ^ buffer[A_2]);
            A_1[index] = (byte) (num3 << 5);
            A_2++;
            A_2 = A_2 % 0x10;
            index++;
        }
    }

    public void method_7(string A_0, byte[] A_1, int A_2)
    {
        byte[] buffer = this.method_2(A_0);
        int index = 0;
        int length = A_1.Length;
        while (index < length)
        {
            byte num3 = A_1[index];
            num3 = (byte) (num3 ^ buffer[A_2]);
            A_1[index] = (byte) (num3 >> 5);
            A_2++;
            A_2 = A_2 % 0x10;
            index++;
        }
    }

    public uint method_8(string A_0)
    {
        byte[] buffer = this.method_11(A_0);
        ushort num = this.method_3(buffer);
        ushort num2 = this.method_1(buffer);
        uint num3 = 0;
        num3 = (uint) (0L | (num << 0x10));
        return (num3 | num2);
    }

    public byte[] method_9(string A_0)
    {
        ushort num2 = (ushort) ((this.method_8(A_0) & -65536) >> 0x10);
        byte num3 = (byte) ((num2 & 0xff00) >> 8);
        byte num4 = (byte) (num2 & 0xff);
        byte[] buffer = new byte[] { 0xbb, 0xff, 0xff, 0xba, 0xff, 0xff, 0xb9, 0x80, 0, 190, 15, 0, 0xbf, 15, 0 };
        byte[] buffer3 = new byte[0x10];
        int index = 0;
        while (index < A_0.Length)
        {
            buffer3[index] = (byte) A_0[index];
            index++;
        }
        while (index < 0x10)
        {
            buffer3[index] = buffer[index - A_0.Length];
            index++;
        }
        for (index = 0; index < 0x10; index++)
        {
            byte num6 = (byte) (buffer3[index] ^ num4);
            buffer3[index] = this.method_5(num6);
            index++;
            num6 = (byte) (buffer3[index] ^ num3);
            buffer3[index] = this.method_5(num6);
        }
        return buffer3;
    }
}

