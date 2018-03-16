using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class932
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private const int int_0 = 2;

    internal int method_0()
    {
        return this.arrayList_0.Count;
    }

    internal byte[] method_1(int A_0)
    {
        return (byte[]) this.arrayList_0[A_0];
    }

    internal string method_2(int A_0)
    {
        return Encoding.Unicode.GetString(this.method_1(A_0));
    }

    internal void method_3(string A_0)
    {
        this.method_4(Encoding.Unicode.GetBytes(A_0));
    }

    internal void method_4(byte[] A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal void method_5(BinaryReader A_0, int A_1, int A_2)
    {
        if (A_2 != 0)
        {
            A_0.BaseStream.Position = A_1;
            A_0.ReadUInt16();
            int num3 = A_0.ReadInt16();
            A_0.ReadUInt16();
            for (int i = 0; i < num3; i++)
            {
                int num = A_0.ReadInt16();
                byte[] buffer = A_0.ReadBytes(num * 2);
                A_0.ReadUInt16();
                this.arrayList_0.Add(buffer);
            }
        }
    }

    internal int method_6(BinaryWriter A_0)
    {
        int count = this.arrayList_0.Count;
        if (count == 0)
        {
            return 0;
        }
        long position = A_0.BaseStream.Position;
        A_0.Write((ushort) 0xffff);
        A_0.Write((short) count);
        A_0.Write((short) 2);
        for (int i = 0; i < count; i++)
        {
            byte[] buffer = (byte[]) this.arrayList_0[i];
            int num3 = buffer.Length / 2;
            A_0.Write((short) num3);
            A_0.Write(buffer);
            A_0.Write((short) 1);
        }
        return (int) (A_0.BaseStream.Position - position);
    }
}

