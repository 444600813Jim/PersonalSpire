using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Drawing;
using System.IO;

internal class Class1077 : Interface56, Interface63
{
    private Class76 class76_0;
    private readonly Class783 class783_0;
    internal const double double_0 = 0.0;
    internal const double double_1 = 1.0;
    internal const double double_2 = -0.5;
    internal const double double_3 = 0.5;
    private readonly Interface0 interface0_0;
    private static readonly SortedList sortedList_0 = new SortedList();

    static Class1077()
    {
        sortedList_0.Add(BorderType.Top, 0x100a);
        sortedList_0.Add(BorderType.Left, 0x100b);
        sortedList_0.Add(BorderType.Bottom, 0x100c);
        sortedList_0.Add(BorderType.Right, 0x100d);
    }

    internal Class1077(Interface0 A_0, Document A_1)
    {
        this.interface0_0 = A_0;
        this.class783_0 = new Class783(A_1, new Class71(A_0));
    }

    public void imethod_0(Image A_0)
    {
        this.class783_0.method_0(A_0);
    }

    public void imethod_2(string A_0)
    {
        this.class783_0.method_2(A_0);
    }

    public byte[] imethod_5()
    {
        return this.class783_0.method_5();
    }

    public void imethod_7(string A_0)
    {
        this.class783_0.method_7(A_0);
    }

    void Interface56.imethod_1(Stream A_0)
    {
        this.class783_0.method_1(A_0);
    }

    bool Interface56.imethod_10()
    {
        return this.class783_0.method_18();
    }

    ImageSize Interface56.imethod_11()
    {
        return this.class783_0.method_19();
    }

    BlipImageType Interface56.imethod_12()
    {
        return this.class783_0.method_20();
    }

    bool Interface56.imethod_13()
    {
        return this.class783_0.method_21();
    }

    bool Interface56.imethod_14()
    {
        return this.class783_0.method_22();
    }

    string Interface56.imethod_15()
    {
        return this.class783_0.method_14();
    }

    void Interface56.imethod_16(string A_0)
    {
        this.class783_0.method_15(A_0);
    }

    Image Interface56.imethod_3()
    {
        return this.class783_0.method_3();
    }

    Stream Interface56.imethod_4()
    {
        return this.class783_0.method_4();
    }

    void Interface56.imethod_6(Stream A_0)
    {
        this.class783_0.method_6(A_0);
    }

    byte[] Interface56.imethod_8()
    {
        return this.class783_0.method_16();
    }

    void Interface56.imethod_9(byte[] A_0)
    {
        this.class783_0.method_17(A_0);
    }

    object Interface63.imethod_0(int A_0)
    {
        return this.interface0_0.imethod_0(A_0);
    }

    object Interface63.imethod_1(int A_0)
    {
        return this.interface0_0.imethod_1(A_0);
    }

    void Interface63.imethod_2(int A_0, object A_1)
    {
        this.method_31(A_0, A_1);
    }

    SortedList Interface63.imethod_3()
    {
        return sortedList_0;
    }

    internal ImageFormat method_0()
    {
        return this.class783_0.method_24();
    }

    internal void method_1(byte[] A_0)
    {
        this.class783_0.method_8(A_0);
    }

    public double method_10()
    {
        return this.method_13(0x103);
    }

    public void method_11(double A_0)
    {
        this.method_14(0x103, A_0);
    }

    internal Class915 method_12()
    {
        return new Class915(this.method_8(), this.method_10(), this.method_4(), this.method_6());
    }

    private double method_13(int A_0)
    {
        return Class969.smethod_68((int) this.method_30(A_0));
    }

    private void method_14(int A_0, double A_1)
    {
        int num = 2;
        if ((A_1 < -1.0) || (A_1 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("帧䬩䀫嬭唯", num));
        }
        this.method_31(A_0, Class969.smethod_71(A_1));
    }

    internal Class76 method_15()
    {
        if (this.class76_0 == null)
        {
            this.class76_0 = new Class76(this);
        }
        return this.class76_0;
    }

    public Color method_16()
    {
        return this.method_18();
    }

    public void method_17(Color A_0)
    {
        this.method_19(A_0);
    }

    internal Color method_18()
    {
        return (Color) this.method_30(0x107);
    }

    internal void method_19(Color A_0)
    {
        this.method_31(0x107, A_0);
    }

    public string method_2()
    {
        return (string) this.method_30(0x1007);
    }

    public double method_20()
    {
        return smethod_0(Class969.smethod_68((int) this.method_30(0x109)));
    }

    public void method_21(double A_0)
    {
        int num = 0x10;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䀵夷嘹䤻嬽", num));
        }
        this.method_31(0x109, Class969.smethod_71(smethod_1(A_0)));
    }

    public double method_22()
    {
        return smethod_2(Class969.smethod_68((int) this.method_30(0x108)));
    }

    public void method_23(double A_0)
    {
        int num = 9;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("央倰弲䀴制", num));
        }
        this.method_31(0x108, Class969.smethod_71(smethod_3(A_0)));
    }

    public bool method_24()
    {
        return (bool) this.method_30(0x13e);
    }

    public void method_25(bool A_0)
    {
        this.method_31(0x13e, A_0);
    }

    public bool method_26()
    {
        return (bool) this.method_30(0x13d);
    }

    public void method_27(bool A_0)
    {
        this.method_31(0x13d, A_0);
    }

    internal bool method_28()
    {
        return (this.interface0_0.imethod_0(0x107) != null);
    }

    internal bool method_29()
    {
        return ((this.Interface56.imethod_8() != null) && (this.Interface56.imethod_8().Length > 0));
    }

    public void method_3(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䈳圵吷伹夻", 14));
        this.method_31(0x1007, A_0);
    }

    private object method_30(int A_0)
    {
        return this.interface0_0.imethod_2(A_0);
    }

    private void method_31(int A_0, object A_1)
    {
        this.interface0_0.imethod_3(A_0, A_1);
    }

    internal byte[] method_32()
    {
        return this.class783_0.method_10();
    }

    public double method_4()
    {
        return this.method_13(0x100);
    }

    public void method_5(double A_0)
    {
        this.method_14(0x100, A_0);
    }

    public double method_6()
    {
        return this.method_13(0x101);
    }

    public void method_7(double A_0)
    {
        this.method_14(0x101, A_0);
    }

    public double method_8()
    {
        return this.method_13(0x102);
    }

    public void method_9(double A_0)
    {
        this.method_14(0x102, A_0);
    }

    internal static double smethod_0(double A_0)
    {
        int num = 0x10;
        if ((A_0 < -0.5) || (A_0 > 0.5))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("匵䬷夹吻嬽㈿A㙃⽅⽇≉㡋⁍㕏⅑❓", num));
        }
        return (A_0 + 0.5);
    }

    internal static double smethod_1(double A_0)
    {
        int num = 6;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尫䬭䈯儱儳堵䰷", num));
        }
        return (A_0 - 0.5);
    }

    internal static double smethod_2(double A_0)
    {
        int num = 15;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("倴䐶娸区堼䴾ɀⱂ⭄㍆㭈⩊㹌㭎", num));
        }
        if (A_0 <= 1.0)
        {
            return (A_0 / 2.0);
        }
        return ((A_0 - 0.5) / A_0);
    }

    internal static double smethod_3(double A_0)
    {
        int num = 9;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("弮吰䄲嘴制圸伺", num));
        }
        if (A_0 <= 0.5)
        {
            return (A_0 * 2.0);
        }
        if (A_0 >= 1.0)
        {
            return double.MaxValue;
        }
        return (0.5 / (1.0 - A_0));
    }
}

