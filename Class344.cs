using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class344 : Class341
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal int method_5(int A_0)
    {
        return (int) this.arrayList_0[A_0];
    }

    internal void method_6(int A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    protected override void vmethod_0(string A_0, BinaryReader A_1)
    {
        A_1.ReadUInt16();
        int num = A_1.ReadInt32();
        this.arrayList_0.Add(num);
        A_1.ReadInt32();
    }

    protected override int vmethod_1()
    {
        return this.arrayList_0.Count;
    }

    protected override int vmethod_2()
    {
        return 10;
    }

    protected override void vmethod_3(BinaryWriter A_0)
    {
        foreach (int num in this.arrayList_0)
        {
            Class341.smethod_0("", A_0);
            A_0.Write((short) 0x100);
            A_0.Write(num);
            A_0.Write(-1);
        }
    }
}

