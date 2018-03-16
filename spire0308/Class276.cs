using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;

internal class Class276 : Class272
{
    private EscherDrawingType escherDrawingType_0;

    internal Class276() : base(EscherRecordType.DgContainer)
    {
    }

    internal void method_11()
    {
        smethod_1(this, this.method_12());
    }

    internal Class289 method_12()
    {
        return (Class289) base.method_6(typeof(Class289));
    }

    internal Class278 method_13()
    {
        return (Class278) base.method_6(typeof(Class278));
    }

    internal EscherDrawingType method_14()
    {
        return this.escherDrawingType_0;
    }

    internal void method_15(EscherDrawingType A_0)
    {
        this.escherDrawingType_0 = A_0;
    }

    internal Class277 method_16()
    {
        return (Class277) base.method_6(typeof(Class277));
    }

    internal static Class276 smethod_0(EscherDrawingType A_0)
    {
        Class276 class2 = new Class276();
        class2.method_15(A_0);
        Class289 class3 = new Class289();
        class2.method_7().Add(class3);
        class3.method_5(((int) A_0) + 1);
        Class277 class4 = new Class277();
        class2.method_7().Add(class4);
        Class273 class5 = new Class273();
        class4.method_7().Add(class5);
        Class285 class6 = new Class285();
        class5.method_7().Add(class6);
        Class279 class7 = new Class279();
        class7.method_5(0);
        class7.method_31(ShapeType.NonPrimitive);
        class7.method_7(true);
        class7.method_11(true);
        class5.method_7().Add(class7);
        return class2;
    }

    private static void smethod_1(Class272 A_0, Class289 A_1)
    {
        for (int i = 0; i < A_0.method_7().Count; i++)
        {
            Class266 class3 = A_0.method_7().method_0(i);
            if (class3 is Class279)
            {
                Class279 class2 = (Class279) class3;
                if (!class2.method_12() && !class2.method_24())
                {
                    A_1.method_7(A_1.method_6() + 1);
                }
                if (!class2.method_12())
                {
                    A_1.method_9(Math.Max(A_1.method_8(), class2.method_4()));
                }
            }
            if (class3 is Class272)
            {
                smethod_1((Class272) class3, A_1);
            }
        }
    }
}

