using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class566
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    public Class521 method_0(int A_0)
    {
        return (Class521) this.arrayList_0[A_0];
    }

    public void method_1(int A_0, Class521 A_1)
    {
        this.arrayList_0[A_0] = A_1;
    }

    public int method_2()
    {
        return this.arrayList_0.Count;
    }

    public bool method_3()
    {
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            if (this.method_0(i).method_0())
            {
                return true;
            }
        }
        return false;
    }

    public int method_4()
    {
        int num = 0;
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            if (this.method_0(i).method_0())
            {
                num++;
            }
        }
        return num;
    }

    public void method_5(Class521 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    public Class521 method_6(int A_0)
    {
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            if (this.method_0(i).int_0 == A_0)
            {
                return this.method_0(i);
            }
        }
        return null;
    }

    public Class521 method_7(string A_0)
    {
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            if (this.method_0(i).string_0 == A_0)
            {
                return this.method_0(i);
            }
        }
        return null;
    }
}

