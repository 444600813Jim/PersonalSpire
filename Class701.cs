using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class701 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal void method_0(BinaryReader A_0, Class1111 A_1)
    {
        if (A_1.int_1 != 0)
        {
            A_0.BaseStream.Position = A_1.int_0;
            int num2 = A_0.ReadInt32();
            for (int i = 0; i < num2; i++)
            {
                this.arrayList_0.Add(new Class538(A_0));
            }
        }
    }

    internal Class1111 method_1(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        A_0.Write(this.arrayList_0.Count);
        foreach (Class538 class2 in this.arrayList_0)
        {
            class2.method_0(A_0);
        }
        return new Class1111(position, ((int) A_0.BaseStream.Position) - position);
    }

    public Class538 method_2(int A_0)
    {
        return (Class538) this.arrayList_0[A_0];
    }

    internal void method_3(Class702 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal int method_4()
    {
        return this.arrayList_0.Count;
    }

    internal int method_5(string A_0)
    {
        Class538 class2;
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            class2 = (Class538) this.arrayList_0[i];
            if (class2.method_3() == A_0)
            {
                return i;
            }
        }
        class2 = new Class538(A_0);
        this.arrayList_0.Add(class2);
        return (this.arrayList_0.Count - 1);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

