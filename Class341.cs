using System;
using System.IO;

internal abstract class Class341
{
    protected Class341()
    {
    }

    internal void method_0(BinaryReader A_0, int A_1, int A_2)
    {
        if (A_2 != 0)
        {
            bool flag;
            A_0.BaseStream.Position = A_1;
            int num3 = A_0.ReadUInt16();
            int num4 = (flag = num3 == 0xffff) ? A_0.ReadInt16() : num3;
            int num5 = A_0.ReadInt16();
            if ((num4 == 0) && (num5 > 0))
            {
                num4 = 1;
            }
            int num = A_1 + A_2;
            for (int i = 0; i < num4; i++)
            {
                if (A_0.BaseStream.Position >= num)
                {
                    return;
                }
                this.method_2(A_0, flag);
            }
        }
    }

    internal void method_1(BinaryReader A_0)
    {
        bool flag;
        int num = A_0.ReadUInt16();
        int num3 = (flag = num == 0xffff) ? A_0.ReadInt32() : num;
        A_0.ReadInt16();
        for (int i = 0; i < num3; i++)
        {
            this.method_2(A_0, flag);
        }
    }

    private void method_2(BinaryReader A_0, bool A_1)
    {
        int num = A_1 ? A_0.ReadInt16() : A_0.ReadByte();
        string str = new string(Class813.smethod_15(A_0, A_1, num));
        this.vmethod_0(str, A_0);
    }

    internal int method_3(BinaryWriter A_0)
    {
        return this.method_4(A_0, false);
    }

    internal int method_4(BinaryWriter A_0, bool A_1)
    {
        int num = this.vmethod_1();
        if ((num == 0) && !A_1)
        {
            return 0;
        }
        long position = A_0.BaseStream.Position;
        A_0.Write((ushort) 0xffff);
        if (A_1)
        {
            A_0.Write(num);
        }
        else
        {
            A_0.Write((short) num);
        }
        A_0.Write((short) this.vmethod_2());
        this.vmethod_3(A_0);
        return (int) (A_0.BaseStream.Position - position);
    }

    protected static void smethod_0(string A_0, BinaryWriter A_1)
    {
        Class813.smethod_2(A_0, 0x7fffffff, A_1, true, false);
    }

    protected abstract void vmethod_0(string A_0, BinaryReader A_1);
    protected abstract int vmethod_1();
    protected abstract int vmethod_2();
    protected abstract void vmethod_3(BinaryWriter A_0);
}

