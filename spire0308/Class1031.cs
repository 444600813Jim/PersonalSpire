using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

internal class Class1031
{
    private bool bool_0;
    private bool bool_1;
    private BorderStyle borderStyle_0;
    internal static readonly Class1031 class1031_0 = new Class1031();
    private Color color_0;
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1;
    private static readonly Hashtable hashtable_2;
    private static readonly Hashtable hashtable_3;
    private static readonly Hashtable hashtable_4;
    private const int int_0 = 0x1f;
    private const int int_1 = 0x1f;
    private int int_2;
    private int int_3;
    private int int_4;
    private Interface63 interface63_0;
    private string string_0;
    private string string_1;
    private string string_2;

    static Class1031()
    {
        hashtable_0.Add(BorderStyle.Dot, new float[] { 1f, 1f });
        hashtable_0.Add(BorderStyle.DashSmallGap, new float[] { 4f, 1f });
        hashtable_0.Add(BorderStyle.DashLargeGap, new float[] { 4f, 4f });
        hashtable_0.Add(BorderStyle.DotDash, new float[] { 7f, 3f, 3f, 3f });
        hashtable_0.Add(BorderStyle.DotDotDash, new float[] { 6f, 2f, 2f, 2f, 2f, 2f });
        hashtable_1 = new Hashtable();
        hashtable_1.Add(BorderStyle.Dot, 2f);
        hashtable_1.Add(BorderStyle.DashSmallGap, 5f);
        hashtable_1.Add(BorderStyle.DashLargeGap, 8f);
        hashtable_1.Add(BorderStyle.DotDash, 16f);
        hashtable_1.Add(BorderStyle.DotDotDash, 16f);
        hashtable_2 = new Hashtable();
        hashtable_2.Add(BorderStyle.Double, new float[] { 1f, 1f, 1f });
        hashtable_2.Add(BorderStyle.Triple, new float[] { 1f, 1f, 1f, 1f, 1f });
        hashtable_2.Add(BorderStyle.ThinThickSmallGap, new float[] { 1f, -0.75f, -0.75f });
        hashtable_2.Add(BorderStyle.ThickThinSmallGap, new float[] { -0.75f, -0.75f, 1f });
        hashtable_2.Add(BorderStyle.ThinThickMediumGap, new float[] { 1f, 0.5f, 0.5f });
        hashtable_2.Add(BorderStyle.ThickThinMediumGap, new float[] { 0.5f, 0.5f, 1f });
        hashtable_2.Add(BorderStyle.ThinThickLargeGap, new float[] { -1.5f, 1f, -0.75f });
        hashtable_2.Add(BorderStyle.ThickThinLargeGap, new float[] { -0.75f, 1f, -1.5f });
        hashtable_2.Add(BorderStyle.ThinThickThinSmallGap, new float[] { -0.75f, -0.75f, 1f, -0.75f, -0.75f });
        hashtable_2.Add(BorderStyle.ThinThickThinMediumGap, new float[] { 0.5f, 0.5f, 1f, 0.5f, 0.5f });
        hashtable_2.Add(BorderStyle.ThinThickThinLargeGap, new float[] { -0.75f, 1f, -1.5f, 1f, -0.75f });
        hashtable_2.Add(BorderStyle.Emboss3D, new float[] { 0.25f, 0f, 1f, 0f, 0.25f });
        hashtable_2.Add(BorderStyle.Engrave3D, new float[] { 0.25f, 0f, 1f, 0f, 0.25f });
        hashtable_3 = new Hashtable();
        hashtable_3.Add(BorderStyle.ThinThickSmallGap, BorderStyle.ThickThinSmallGap);
        hashtable_3.Add(BorderStyle.ThinThickMediumGap, BorderStyle.ThickThinMediumGap);
        hashtable_3.Add(BorderStyle.ThinThickLargeGap, BorderStyle.ThickThinLargeGap);
        hashtable_4 = new Hashtable(0x1b);
        hashtable_4.Add(BorderStyle.Single, 1);
        hashtable_4.Add(BorderStyle.Thick, 2);
        hashtable_4.Add(BorderStyle.Double, 3);
        hashtable_4.Add(BorderStyle.Dot, 4);
        hashtable_4.Add(BorderStyle.DashLargeGap, 5);
        hashtable_4.Add(BorderStyle.DotDash, 8);
        hashtable_4.Add(BorderStyle.DotDotDash, 9);
        hashtable_4.Add(BorderStyle.Triple, 10);
        hashtable_4.Add(BorderStyle.ThinThickSmallGap, 11);
        hashtable_4.Add(BorderStyle.ThickThinSmallGap, 12);
        hashtable_4.Add(BorderStyle.ThinThickThinSmallGap, 13);
        hashtable_4.Add(BorderStyle.ThinThickMediumGap, 14);
        hashtable_4.Add(BorderStyle.ThickThinMediumGap, 15);
        hashtable_4.Add(BorderStyle.ThinThickThinMediumGap, 0x10);
        hashtable_4.Add(BorderStyle.ThinThickLargeGap, 0x11);
        hashtable_4.Add(BorderStyle.ThickThinLargeGap, 0x12);
        hashtable_4.Add(BorderStyle.ThinThickThinLargeGap, 0x13);
        hashtable_4.Add(BorderStyle.Wave, 20);
        hashtable_4.Add(BorderStyle.DoubleWave, 0x15);
        hashtable_4.Add(BorderStyle.DashSmallGap, 0x16);
        hashtable_4.Add(BorderStyle.DashDotStroker, 0x17);
        hashtable_4.Add(BorderStyle.Emboss3D, 0x18);
        hashtable_4.Add(BorderStyle.Engrave3D, 0x19);
        hashtable_4.Add(BorderStyle.Outset, 0x1a);
        hashtable_4.Add(BorderStyle.Inset, 0x1b);
        hashtable_4.Add(BorderStyle.None, 0);
        hashtable_4.Add(BorderStyle.Hairline, 1);
    }

    internal Class1031()
    {
        this.color_0 = Color.Empty;
        this.method_0();
    }

    internal Class1031(Interface63 A_0, int A_1)
    {
        this.color_0 = Color.Empty;
        this.interface63_0 = A_0;
        this.int_2 = A_1;
    }

    internal Class1031(BorderStyle A_0, int A_1, Color A_2)
    {
        this.color_0 = Color.Empty;
        this.borderStyle_0 = A_0;
        this.int_3 = A_1;
        this.color_0 = A_2;
    }

    public void method_0()
    {
        this.interface63_0 = null;
        smethod_8(new object[] { this.borderStyle_0 != BorderStyle.None, PrId.LineStyle, this.borderStyle_0 });
        this.borderStyle_0 = BorderStyle.None;
        smethod_8(new object[] { this.int_3 != 0, PrId.RawLineWidth, this.int_3 });
        this.int_3 = 0;
        smethod_8(new object[] { !this.color_0.IsEmpty, PrId.Color, this.color_0 });
        this.color_0 = Color.Empty;
        smethod_8(new object[] { this.int_4 != 0, PrId.RawDistanceFromText, this.int_4 });
        this.int_4 = 0;
        smethod_8(new object[] { this.bool_0, PrId.Shadow, this.bool_0 });
        this.bool_0 = false;
        smethod_8(new object[] { this.bool_1, PrId.Frame, this.bool_1 });
        this.bool_1 = false;
        object[] objArray7 = new object[2];
        objArray7[0] = this;
        smethod_9(objArray7);
        this.string_0 = null;
        this.string_1 = null;
        this.string_2 = null;
    }

    public BorderStyle method_1()
    {
        if (!this.method_41())
        {
            return this.borderStyle_0;
        }
        return this.method_39().method_1();
    }

    public Color method_10()
    {
        return this.method_12();
    }

    public void method_11(Color A_0)
    {
        this.method_13(A_0);
    }

    internal Color method_12()
    {
        if (!this.method_41())
        {
            return this.color_0;
        }
        return this.method_39().method_12();
    }

    internal void method_13(Color A_0)
    {
        this.method_43();
        smethod_8(new object[] { this.color_0 != A_0, PrId.Color, this.color_0 });
        this.color_0 = A_0;
        object[] objArray2 = new object[2];
        objArray2[0] = this;
        smethod_9(objArray2);
    }

    public double method_14()
    {
        if (!this.method_41())
        {
            return (double) this.int_4;
        }
        return this.method_39().method_14();
    }

    public void method_15(double A_0)
    {
        this.method_34(A_0, true);
    }

    public bool method_16()
    {
        if (!this.method_41())
        {
            return this.bool_0;
        }
        return this.method_39().method_16();
    }

    public void method_17(bool A_0)
    {
        this.method_43();
        smethod_8(new object[] { this.bool_0 != A_0, PrId.Shadow, this.bool_0 });
        this.bool_0 = A_0;
        object[] objArray2 = new object[2];
        objArray2[0] = this;
        smethod_9(objArray2);
    }

    internal bool method_18()
    {
        if (!this.method_41())
        {
            return this.bool_1;
        }
        return this.method_39().method_18();
    }

    internal void method_19(bool A_0)
    {
        this.method_43();
        smethod_8(new object[] { this.bool_1 != A_0, PrId.Frame, this.bool_1 });
        this.bool_1 = A_0;
        object[] objArray2 = new object[2];
        objArray2[0] = this;
        smethod_9(objArray2);
    }

    public void method_2(BorderStyle A_0)
    {
        this.method_43();
        smethod_8(new object[] { this.borderStyle_0 != A_0, PrId.LineStyle, this.borderStyle_0 });
        this.borderStyle_0 = A_0;
        if (A_0 == BorderStyle.None)
        {
            this.method_4(0.0);
        }
        object[] objArray2 = new object[2];
        objArray2[0] = this;
        smethod_9(objArray2);
    }

    internal string method_20()
    {
        return this.string_0;
    }

    internal void method_21(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_22()
    {
        return this.string_1;
    }

    internal void method_23(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_24()
    {
        return this.string_2;
    }

    internal void method_25(string A_0)
    {
        this.string_2 = A_0;
    }

    internal int method_26()
    {
        return this.int_3;
    }

    internal void method_27(int A_0)
    {
        smethod_8(new object[] { this.int_3 != A_0, PrId.RawLineWidth, this.int_3 });
        this.int_3 = A_0;
        object[] objArray2 = new object[2];
        objArray2[0] = this;
        smethod_9(objArray2);
    }

    internal int method_28()
    {
        return this.int_4;
    }

    internal void method_29(int A_0)
    {
        smethod_8(new object[] { this.int_4 != A_0, PrId.RawDistanceFromText, this.int_4 });
        this.int_4 = A_0;
        object[] objArray2 = new object[2];
        objArray2[0] = this;
        smethod_9(objArray2);
    }

    public double method_3()
    {
        if (this.method_41())
        {
            return this.method_39().method_3();
        }
        if (!this.method_6())
        {
            return Class969.smethod_29(this.int_3);
        }
        return (double) this.int_3;
    }

    internal int method_30()
    {
        float[] numArray = (float[]) hashtable_2[this.method_1()];
        if (numArray != null)
        {
            return numArray.Length;
        }
        return 1;
    }

    internal void method_31(double A_0)
    {
        this.method_32(A_0, false);
    }

    private void method_32(double A_0, bool A_1)
    {
        int num = 0x10;
        double num2 = Class1133.smethod_2(A_0, 0.0, 31.0);
        if ((num2 != A_0) && A_1)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("娵儷吹夻椽⤿♁ぃ⹅", num));
        }
        this.method_43();
        this.method_27(this.method_6() ? Class1133.smethod_5(num2) : Class969.smethod_28(num2));
        if ((num2 > 0.0) && (this.method_1() == BorderStyle.None))
        {
            this.method_2(BorderStyle.Single);
        }
    }

    internal void method_33(double A_0)
    {
        this.method_34(A_0, false);
    }

    private void method_34(double A_0, bool A_1)
    {
        int num = 5;
        if (A_0 < 0.0)
        {
            if (A_1)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("伪䐬尮䔰刲嬴吶尸紺似倾ⱀᝂ⁄㽆㵈", num));
            }
            A_0 = 0.0;
        }
        else if (A_0 > 31.0)
        {
            if (A_1)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("伪䐬尮䔰刲嬴吶尸紺似倾ⱀᝂ⁄㽆㵈", num));
            }
            A_0 = 31.0;
        }
        this.method_43();
        this.method_29((int) A_0);
    }

    internal bool method_35(Class1031 A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        return (object.ReferenceEquals(this, A_0) || (((((this.method_1() == A_0.method_1()) && (this.method_3() == A_0.method_3())) && (this.method_12().Equals(A_0.method_12()) && (this.method_14() == A_0.method_14()))) && (((this.method_18() == A_0.method_18()) && (this.method_16() == A_0.method_16())) && ((this.method_20() == A_0.method_20()) && (this.method_22() == A_0.method_22())))) && (this.method_24() == A_0.method_24())));
    }

    internal bool method_36(Class1031 A_0)
    {
        return (this.method_7() && this.method_35(A_0));
    }

    internal bool method_37(Class1031 A_0)
    {
        return smethod_1(this.method_1(), A_0.method_1());
    }

    internal bool method_38(Class1031 A_0, out bool A_1)
    {
        if (this.method_7() && (this.method_30() != 1))
        {
            A_1 = this.method_37(A_0);
            return ((((this.method_1() == A_0.method_1()) || A_1) && (this.method_3() == A_0.method_3())) && (this.method_18() == A_0.method_18()));
        }
        A_1 = false;
        return false;
    }

    private Class1031 method_39()
    {
        return (Class1031) this.interface63_0.imethod_1(this.int_2);
    }

    public void method_4(double A_0)
    {
        this.method_32(A_0, true);
    }

    public bool method_40()
    {
        return this.method_41();
    }

    internal bool method_41()
    {
        return (this.interface63_0 != null);
    }

    internal Class1031 method_42()
    {
        int num = 0x10;
        if (this.method_41())
        {
            throw new InvalidOperationException(BookmarkStart.b("电夷吹刻儽㐿扁❃⩅❇⑉⥋湍ㅏ㱑瑓㽕㙗㉙㥛ⱝय़ᙡţɥ䡧୩ᡫᩭɯ᭱ᙳ͵౷ό剻", num));
        }
        return (Class1031) base.MemberwiseClone();
    }

    private void method_43()
    {
        if (this.method_41())
        {
            this.method_44(this.method_39());
            smethod_8(new object[] { this.interface63_0 != null, PrId.Parent, this.interface63_0 });
            this.interface63_0 = null;
            object[] objArray2 = new object[2];
            objArray2[0] = this;
            smethod_9(objArray2);
        }
    }

    private void method_44(Class1031 A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("否嬨䠪", num));
        }
        smethod_8(new object[] { this.int_2 != A_0.int_2, PrId.Key, this.int_2 });
        this.int_2 = A_0.int_2;
        smethod_8(new object[] { this.borderStyle_0 != A_0.method_1(), PrId.LineStyle, this.borderStyle_0 });
        this.borderStyle_0 = A_0.method_1();
        smethod_8(new object[] { this.int_3 != A_0.method_26(), PrId.RawLineWidth, this.int_3 });
        this.int_3 = A_0.method_26();
        smethod_8(new object[] { this.color_0 != A_0.method_12(), PrId.Color, this.color_0 });
        this.color_0 = A_0.method_12();
        smethod_8(new object[] { this.int_4 != A_0.method_28(), PrId.RawDistanceFromText, this.int_4 });
        this.int_4 = A_0.method_28();
        smethod_8(new object[] { this.bool_0 != A_0.method_16(), PrId.Shadow, this.bool_0 });
        this.bool_0 = A_0.method_16();
        smethod_8(new object[] { this.bool_1 != A_0.method_18(), PrId.Frame, this.bool_1 });
        this.bool_1 = A_0.method_18();
        object[] objArray8 = new object[2];
        objArray8[0] = this;
        smethod_9(objArray8);
        this.string_0 = A_0.method_20();
        this.string_1 = A_0.method_22();
        this.string_2 = A_0.method_24();
    }

    internal int method_45()
    {
        object obj2 = hashtable_4[this.method_1()];
        if (obj2 == null)
        {
            return 0;
        }
        return (int) obj2;
    }

    internal int method_46()
    {
        if ((this.method_1() != BorderStyle.Dot) && (this.method_1() != BorderStyle.DashLargeGap))
        {
            return (this.method_45() * this.method_26());
        }
        return 1;
    }

    private int method_47()
    {
        return ((this.method_10().R + this.method_10().B) + (2 * this.method_10().G));
    }

    private int method_48()
    {
        return (this.method_10().B + (2 * this.method_10().G));
    }

    private int method_49()
    {
        return this.method_10().G;
    }

    internal double method_5()
    {
        double num = this.method_3();
        if ((num == 0.0) && this.method_7())
        {
            return 0.25;
        }
        return num;
    }

    internal bool method_50()
    {
        return ((this.method_1() >= BorderStyle.None) && (this.method_1() <= BorderStyle.Inset));
    }

    internal bool method_6()
    {
        return (this.method_1() >= ((BorderStyle) 0x40));
    }

    public bool method_7()
    {
        return (this.method_1() != BorderStyle.None);
    }

    internal float method_8()
    {
        return smethod_6(this.method_1(), (float) this.method_5());
    }

    internal float method_9()
    {
        if (!this.method_7())
        {
            return 0f;
        }
        float num = this.method_8();
        if (this.method_16())
        {
            num *= 2f;
        }
        return (num + ((float) this.method_14()));
    }

    internal static bool smethod_0(BorderStyle A_0, float A_1, float A_2)
    {
        return (((A_0 != BorderStyle.None) && (A_1 > 0f)) || (A_2 > 0f));
    }

    internal static bool smethod_1(BorderStyle A_0, BorderStyle A_1)
    {
        return ((hashtable_3.ContainsKey(A_0) && (((BorderStyle) hashtable_3[A_0]) == A_1)) || (hashtable_3.ContainsKey(A_1) && (((BorderStyle) hashtable_3[A_1]) == A_0)));
    }

    internal static float[] smethod_2(BorderStyle A_0, float A_1)
    {
        float[] numArray = (float[]) hashtable_0[A_0];
        if (numArray == null)
        {
            return null;
        }
        float[] numArray2 = (float[]) numArray.Clone();
        for (int i = 0; i < numArray2.Length; i++)
        {
            numArray2[i] *= A_1;
        }
        return numArray2;
    }

    internal static float smethod_3(BorderStyle A_0, float A_1)
    {
        return (float) hashtable_1[A_0];
    }

    internal static float[] smethod_4(BorderStyle A_0, float A_1)
    {
        float[] numArray = (float[]) hashtable_2[A_0];
        if (numArray == null)
        {
            return new float[] { A_1 };
        }
        float[] numArray3 = (float[]) numArray.Clone();
        for (int i = 0; i < numArray3.Length; i++)
        {
            if (numArray3[i] >= 0f)
            {
                numArray3[i] *= A_1;
            }
            else
            {
                numArray3[i] = Math.Abs(numArray3[i]);
            }
        }
        return numArray3;
    }

    internal static int smethod_5(BorderStyle A_0)
    {
        float[] numArray = (float[]) hashtable_2[A_0];
        if (numArray != null)
        {
            return numArray.Length;
        }
        return 1;
    }

    internal static float smethod_6(BorderStyle A_0, float A_1)
    {
        switch (A_0)
        {
            case BorderStyle.None:
                return 0f;

            case BorderStyle.Single:
            case BorderStyle.Dot:
            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
            case BorderStyle.DashSmallGap:
                return A_1;

            case BorderStyle.Thick:
            case BorderStyle.Hairline:
                return 0.75f;

            case BorderStyle.Double:
            case BorderStyle.Triple:
            case BorderStyle.ThinThickSmallGap:
            case BorderStyle.ThickThinSmallGap:
            case BorderStyle.ThinThickThinSmallGap:
            case BorderStyle.ThinThickMediumGap:
            case BorderStyle.ThickThinMediumGap:
            case BorderStyle.ThinThickThinMediumGap:
            case BorderStyle.ThinThickLargeGap:
            case BorderStyle.ThickThinLargeGap:
            case BorderStyle.ThinThickThinLargeGap:
            case BorderStyle.Emboss3D:
            case BorderStyle.Engrave3D:
            {
                float[] numArray2 = smethod_4(A_0, A_1);
                float num2 = 0f;
                foreach (float num3 in numArray2)
                {
                    num2 += num3;
                }
                return num2;
            }
            case ((BorderStyle) 4):
                return A_1;

            case BorderStyle.Wave:
                return (2.5f * A_1);

            case BorderStyle.DoubleWave:
                return (6.75f * A_1);

            case BorderStyle.DashDotStroker:
            case BorderStyle.Outset:
                return A_1;
        }
        return A_1;
    }

    internal static Class1031 smethod_7(Class1031 A_0, Class1031 A_1)
    {
        if (A_0 == null)
        {
            return A_1;
        }
        if (A_1 != null)
        {
            if (A_0.method_46() != A_1.method_46())
            {
                if (A_0.method_46() <= A_1.method_46())
                {
                    return A_1;
                }
                return A_0;
            }
            int num3 = A_0.method_45();
            int num4 = A_1.method_45();
            if (num3 != num4)
            {
                if (num3 <= num4)
                {
                    return A_1;
                }
                return A_0;
            }
            int num = A_0.method_47();
            int num2 = A_1.method_47();
            if (num != num2)
            {
                if (num >= num2)
                {
                    return A_1;
                }
                return A_0;
            }
            num = A_0.method_48();
            num2 = A_1.method_48();
            if (num != num2)
            {
                if (num >= num2)
                {
                    return A_1;
                }
                return A_0;
            }
            if (A_0.method_49() > A_1.method_49())
            {
                return A_1;
            }
        }
        return A_0;
    }

    internal static void smethod_8(params object[] A_0)
    {
    }

    internal static void smethod_9(params object[] A_0)
    {
    }

    bool object.Equals(object A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        if (object.ReferenceEquals(this, A_0))
        {
            return true;
        }
        if (A_0.GetType() != typeof(Class1031))
        {
            return false;
        }
        return this.method_35((Class1031) A_0);
    }

    int object.GetHashCode()
    {
        int num = ((int) (this.borderStyle_0 * ((BorderStyle) 0x18d))) ^ this.int_3;
        num = (num * 0x18d) ^ this.color_0.GetHashCode();
        num = (num * 0x18d) ^ this.int_4;
        num = (num * 0x18d) ^ this.bool_0.GetHashCode();
        num = (num * 0x18d) ^ this.bool_1.GetHashCode();
        num = (num * 0x18d) ^ ((this.string_0 != null) ? this.string_0.GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.string_1 != null) ? this.string_1.GetHashCode() : 0);
        return ((num * 0x18d) ^ ((this.string_2 != null) ? this.string_2.GetHashCode() : 0));
    }
}

