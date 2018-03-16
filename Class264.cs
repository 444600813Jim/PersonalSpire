using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class264 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal void method_0(BinaryReader A_0, Class1111 A_1)
    {
        if (A_1.int_1 != 0)
        {
            A_0.BaseStream.Position = A_1.int_0;
            A_0.ReadUInt16();
            int num2 = A_0.ReadInt32();
            A_0.ReadInt16();
            for (int i = 0; i < num2; i++)
            {
                this.arrayList_0.Add(new Class702(A_0));
            }
        }
    }

    internal Class1111 method_1(BinaryWriter A_0)
    {
        int num = 1;
        int position = (int) A_0.BaseStream.Position;
        A_0.Write((ushort) 0xffff);
        A_0.Write(this.arrayList_0.Count);
        A_0.Write((ushort) 0);
        foreach (Class702 class2 in this.arrayList_0)
        {
            class2.method_0(A_0, num++);
        }
        return new Class1111(position, ((int) A_0.BaseStream.Position) - position);
    }

    public Class702 method_2(int A_0)
    {
        return (Class702) this.arrayList_0[A_0];
    }

    internal void method_3(Class702 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal int method_4()
    {
        return this.arrayList_0.Count;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

