using System;
using System.Drawing;

internal class Class1020 : Interface2
{
    private Class205 class205_0 = new Class205(ChildrenLayoutDirection.Horizontal);
    private SizeF sizeF_0;

    public Class1020(SizeF A_0)
    {
        this.sizeF_0 = A_0;
    }

    public void imethod_1(Class196 A_0, Class375 A_1)
    {
    }

    public void imethod_2(Class196 A_0, Class375 A_1)
    {
    }

    Interface23 Interface1.imethod_0()
    {
        return this.class205_0;
    }

    SizeF Interface2.imethod_3(Class196 A_0)
    {
        return this.sizeF_0;
    }
}

