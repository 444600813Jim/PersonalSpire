using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;

internal class Class1076
{
    private readonly Interface0 interface0_0;

    internal Class1076(Interface0 A_0)
    {
        this.interface0_0 = A_0;
    }

    public double method_0()
    {
        return Class969.smethod_42((int) this.method_16(0x81));
    }

    public void method_1(double A_0)
    {
        int num = 0x12;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("丷嬹倻䬽┿", num));
        }
        this.method_17(0x81, Class969.smethod_40(A_0));
    }

    public LayoutFlow method_10()
    {
        return (LayoutFlow) this.method_16(0x88);
    }

    public void method_11(LayoutFlow A_0)
    {
        this.method_17(0x88, A_0);
    }

    internal TextBoxWrapMode method_12()
    {
        return (TextBoxWrapMode) this.method_16(0x85);
    }

    internal void method_13(TextBoxWrapMode A_0)
    {
        this.method_17(0x85, A_0);
    }

    internal TextBoxAnchor method_14()
    {
        return (TextBoxAnchor) this.method_16(0x87);
    }

    internal void method_15(TextBoxAnchor A_0)
    {
        this.method_17(0x87, A_0);
    }

    private object method_16(int A_0)
    {
        return this.interface0_0.imethod_2(A_0);
    }

    private void method_17(int A_0, object A_1)
    {
        this.interface0_0.imethod_3(A_0, A_1);
    }

    public double method_2()
    {
        return Class969.smethod_42((int) this.method_16(0x83));
    }

    public void method_3(double A_0)
    {
        int num = 7;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬬丮崰䘲倴", num));
        }
        this.method_17(0x83, Class969.smethod_40(A_0));
    }

    public double method_4()
    {
        return Class969.smethod_42((int) this.method_16(130));
    }

    public void method_5(double A_0)
    {
        int num = 0x13;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("伸娺儼䨾⑀", num));
        }
        this.method_17(130, Class969.smethod_40(A_0));
    }

    public double method_6()
    {
        return Class969.smethod_42((int) this.method_16(0x84));
    }

    public void method_7(double A_0)
    {
        int num = 0x10;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䀵夷嘹䤻嬽", num));
        }
        this.method_17(0x84, Class969.smethod_40(A_0));
    }

    public bool method_8()
    {
        return (bool) this.method_16(190);
    }

    public void method_9(bool A_0)
    {
        this.method_17(190, A_0);
    }
}

