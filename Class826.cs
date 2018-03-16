using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Pdf.General.Paper.Drawing;
using System;
using System.Collections;
using System.Drawing;

internal class Class826
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();
    private static readonly Hashtable hashtable_4 = new Hashtable();
    private readonly Interface0 interface0_0;
    private spr⇻ spr⇻_0;

    static Class826()
    {
        hashtable_0.Add(LineDashing.Dash, new float[] { 2f, 1f });
        hashtable_0.Add(LineDashing.Dot, new float[] { 1f, 1f });
        hashtable_0.Add(LineDashing.DashDot, new float[] { 2f, 1f, 1f, 1f });
        hashtable_0.Add(LineDashing.DashDotDot, new float[] { 2f, 1f, 1f, 1f, 1f, 1f });
        hashtable_0.Add(LineDashing.DotGEL, new float[] { 1f, 1f });
        hashtable_0.Add(LineDashing.DashGEL, new float[] { 4f, 3f });
        hashtable_0.Add(LineDashing.LongDashGEL, new float[] { 7f, 3f });
        hashtable_0.Add(LineDashing.DashDotGEL, new float[] { 4f, 3f, 1f, 3f });
        hashtable_0.Add(LineDashing.LongDashDotGEL, new float[] { 7f, 3f, 1f, 3f });
        hashtable_0.Add(LineDashing.LongDashDotDotGEL, new float[] { 7f, 3f, 1f, 3f, 1f, 3f });
        Class791.smethod_0(new object[] { ArrowType.Open, (PsLineEndType) 5, ArrowType.Diamond, (PsLineEndType) 3, ArrowType.None, (PsLineEndType) 0, ArrowType.Oval, (PsLineEndType) 4, ArrowType.Stealth, (PsLineEndType) 2, ArrowType.Arrow, (PsLineEndType) 1 }, hashtable_1, null);
        Class791.smethod_0(new object[] { StrokeArrowWidth.Wide, (PsLineEndSize) 2, StrokeArrowWidth.Medium, (PsLineEndSize) 1, StrokeArrowWidth.Narrow, (PsLineEndSize) 0 }, hashtable_3, null);
        Class791.smethod_0(new object[] { StrokeArrowLength.Long, (PsLineEndSize) 2, StrokeArrowLength.Medium, (PsLineEndSize) 1, StrokeArrowLength.Short, (PsLineEndSize) 0 }, hashtable_2, null);
        Class791.smethod_0(new object[] { StrokeEndCap.Flat, (PsLineEndingCapType) 1, StrokeEndCap.Round, (PsLineEndingCapType) 2, StrokeEndCap.Square, (PsLineEndingCapType) 0 }, hashtable_4, null);
    }

    internal Class826(Interface0 A_0)
    {
        this.interface0_0 = A_0;
    }

    public bool method_0()
    {
        return (bool) this.method_39(0x1fc);
    }

    public void method_1(bool A_0)
    {
        this.method_40(0x1fc, A_0);
    }

    internal Color method_10()
    {
        return (Color) this.method_39(450);
    }

    internal void method_11(Color A_0)
    {
        this.method_40(450, A_0);
    }

    internal LineFillType method_12()
    {
        return (LineFillType) this.method_39(0x1c4);
    }

    internal void method_13(LineFillType A_0)
    {
        this.method_40(0x1c4, A_0);
    }

    public LineDashing method_14()
    {
        return (LineDashing) this.method_39(0x1ce);
    }

    public void method_15(LineDashing A_0)
    {
        this.method_40(0x1ce, A_0);
    }

    public StrokeJoinStyle method_16()
    {
        return (StrokeJoinStyle) this.method_39(470);
    }

    public void method_17(StrokeJoinStyle A_0)
    {
        this.method_40(470, A_0);
    }

    public StrokeEndCap method_18()
    {
        return (StrokeEndCap) this.method_39(0x1d7);
    }

    public void method_19(StrokeEndCap A_0)
    {
        this.method_40(0x1d7, A_0);
    }

    public double method_2()
    {
        return Class969.smethod_42((int) this.method_39(0x1cb));
    }

    public ShapeLineStyle method_20()
    {
        return (ShapeLineStyle) this.method_39(0x1cd);
    }

    public void method_21(ShapeLineStyle A_0)
    {
        this.method_40(0x1cd, A_0);
    }

    public ArrowType method_22()
    {
        return (ArrowType) this.method_39(0x1d0);
    }

    public void method_23(ArrowType A_0)
    {
        this.method_40(0x1d0, A_0);
    }

    public ArrowType method_24()
    {
        return (ArrowType) this.method_39(0x1d1);
    }

    public void method_25(ArrowType A_0)
    {
        this.method_40(0x1d1, A_0);
    }

    public StrokeArrowWidth method_26()
    {
        return (StrokeArrowWidth) this.method_39(0x1d2);
    }

    public void method_27(StrokeArrowWidth A_0)
    {
        this.method_40(0x1d2, A_0);
    }

    public StrokeArrowLength method_28()
    {
        return (StrokeArrowLength) this.method_39(0x1d3);
    }

    public void method_29(StrokeArrowLength A_0)
    {
        this.method_40(0x1d3, A_0);
    }

    public void method_3(double A_0)
    {
        int num = 0x10;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䀵夷嘹䤻嬽", num));
        }
        this.method_40(0x1cb, Class969.smethod_40(A_0));
    }

    public StrokeArrowWidth method_30()
    {
        return (StrokeArrowWidth) this.method_39(0x1d4);
    }

    public void method_31(StrokeArrowWidth A_0)
    {
        this.method_40(0x1d4, A_0);
    }

    public StrokeArrowLength method_32()
    {
        return (StrokeArrowLength) this.method_39(0x1d5);
    }

    public void method_33(StrokeArrowLength A_0)
    {
        this.method_40(0x1d5, A_0);
    }

    public double method_34()
    {
        return Class969.smethod_68((int) this.method_39(0x1c1));
    }

    public void method_35(double A_0)
    {
        int num = 0x11;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䄶堸场䠼娾", num));
        }
        this.method_40(0x1c1, Class969.smethod_71(A_0));
    }

    public byte[] method_36()
    {
        return (byte[]) this.method_39(0x100e);
    }

    internal spr⇻ method_37()
    {
        if (this.spr⇻_0 == null)
        {
            this.method_38();
        }
        return this.spr⇻_0;
    }

    private void method_38()
    {
        sprᰴ rᰴ = new sprᰴ();
        rᰴ.ᜀ((PsLineEndType) Class791.smethod_5(hashtable_1, this.method_22()));
        rᰴ.ᜁ((PsLineEndSize) Class791.smethod_5(hashtable_2, this.method_28()));
        rᰴ.ᜀ((PsLineEndSize) Class791.smethod_5(hashtable_3, this.method_26()));
        sprᰴ rᰴ2 = new sprᰴ();
        rᰴ2.ᜀ((PsLineEndType) Class791.smethod_5(hashtable_1, this.method_24()));
        rᰴ2.ᜁ((PsLineEndSize) Class791.smethod_5(hashtable_2, this.method_32()));
        rᰴ2.ᜀ((PsLineEndSize) Class791.smethod_5(hashtable_3, this.method_30()));
        PsLineEndingCapType type = (PsLineEndingCapType) Class791.smethod_5(hashtable_4, this.method_18());
        float num = (float) this.method_2();
        this.spr⇻_0 = new spr⇻(rᰴ, rᰴ2, type, num);
    }

    private object method_39(int A_0)
    {
        return this.interface0_0.imethod_2(A_0);
    }

    public Color method_4()
    {
        return this.method_6();
    }

    private void method_40(int A_0, object A_1)
    {
        this.interface0_0.imethod_3(A_0, A_1);
    }

    public void method_5(Color A_0)
    {
        this.method_7(A_0);
    }

    internal Color method_6()
    {
        return (Color) this.method_39(0x1c0);
    }

    internal void method_7(Color A_0)
    {
        this.method_40(0x1c0, A_0);
    }

    public Color method_8()
    {
        return this.method_10();
    }

    public void method_9(Color A_0)
    {
        this.method_11(A_0);
    }

    internal static float[] smethod_0(LineDashing A_0, float A_1)
    {
        float[] numArray = (float[]) hashtable_0[A_0];
        if (numArray == null)
        {
            return null;
        }
        float[] array = new float[numArray.Length];
        numArray.CopyTo(array, 0);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= A_1;
        }
        return array;
    }
}

