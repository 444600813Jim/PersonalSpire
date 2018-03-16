using System;
using System.IO;

internal class Class431 : Class428, Interface54
{
    internal Class431()
    {
    }

    internal Class431(byte[] A_0) : base(A_0)
    {
    }

    internal Class431(BinaryReader A_0, bool A_1)
    {
        int num;
        if (A_1)
        {
            num = A_0.ReadByte();
        }
        else
        {
            num = A_0.ReadInt16();
        }
        base.method_3(A_0.ReadBytes(num));
    }

    public int imethod_1(bool A_0)
    {
        if (!A_0)
        {
            return (2 + base.method_2().Length);
        }
        if (base.method_2().Length == 0)
        {
            return 0;
        }
        return (1 + base.method_2().Length);
    }

    public void imethod_2(BinaryWriter A_0, bool A_1)
    {
        if (A_1)
        {
            A_0.Write((byte) base.method_2().Length);
        }
        else
        {
            A_0.Write((short) base.method_2().Length);
        }
        A_0.Write(base.method_2());
    }
}

