using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

[DefaultMember("Item")]
internal class Class916
{
    private readonly ArrayList arrayList_0;

    internal Class916()
    {
        this.arrayList_0 = new ArrayList();
    }

    internal Class916(Stream A_0)
    {
        this.arrayList_0 = new ArrayList();
        A_0.Position = 0L;
        this.method_3(A_0, ((int) A_0.Length) / 4);
    }

    internal uint method_0(uint A_0)
    {
        return (uint) this.arrayList_0[(int) A_0];
    }

    internal void method_1(uint A_0, uint A_1)
    {
        this.arrayList_0[(int) A_0] = A_1;
    }

    internal int method_2()
    {
        return this.arrayList_0.Count;
    }

    internal void method_3(Stream A_0, int A_1)
    {
        BinaryReader reader = new BinaryReader(A_0, Encoding.Unicode);
        for (int i = 0; i < A_1; i++)
        {
            this.arrayList_0.Add(reader.ReadUInt32());
        }
    }

    internal MemoryStream method_4()
    {
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output, Encoding.Unicode);
        for (uint i = 0; i < this.arrayList_0.Count; i++)
        {
            writer.Write(this.method_0(i));
        }
        return output;
    }

    internal void method_5(uint A_0)
    {
        this.arrayList_0.Add(A_0);
    }
}

