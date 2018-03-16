using System;
using System.IO;

internal class Class765
{
    internal int int_0;
    internal readonly int[] int_1;
    internal readonly int[] int_2;

    internal Class765(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadUInt16();
        int num = A_0.ReadUInt16();
        this.int_1 = new int[num];
        this.int_2 = new int[num];
        A_0.ReadUInt16();
        for (int i = 0; i < num; i++)
        {
            this.int_1[i] = A_0.ReadInt32();
            this.int_2[i] = A_0.ReadInt32();
        }
    }

    internal Class765(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = new int[A_1];
        this.int_2 = new int[A_1];
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) this.int_0);
        A_0.Write((ushort) this.int_1.Length);
        A_0.Write((ushort) 0);
        for (int i = 0; i < this.int_1.Length; i++)
        {
            A_0.Write(this.int_1[i]);
            A_0.Write(this.int_2[i]);
        }
    }
}

