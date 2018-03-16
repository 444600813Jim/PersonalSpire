using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class732 : ArrayList, Interface31
{
    bool Interface31.imethod_0()
    {
        return false;
    }

    Interface31 Interface31.imethod_1()
    {
        Class732 class2 = new Class732();
        for (int i = 0; i < this.Count; i++)
        {
            class2.Add(this.method_0(i).Clone());
        }
        return class2;
    }

    public CellFormat method_0(int A_0)
    {
        return (CellFormat) base[A_0];
    }

    public void method_1(int A_0, CellFormat A_1)
    {
        base[A_0] = A_1;
    }

    internal bool method_2(int A_0)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.method_0(i).method_6(A_0))
            {
                return true;
            }
        }
        return false;
    }
}

