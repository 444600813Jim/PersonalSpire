using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct27 : IFormattable
{
    internal const double double_0 = 1.0;
    internal const double double_1 = 72.0;
    internal const double double_2 = 2.8346456692913389;
    internal const double double_3 = 28.346456692913385;
    internal const double double_4 = 0.75;
    internal const double double_5 = 1.3333333333333333;
    internal const double double_6 = 96.0;
    internal const double double_7 = 3.7795275590551185;
    internal const double double_8 = 37.795275590551178;
    internal const double double_9 = 1.0;
    public static readonly Struct27 struct27_0;
    private double double_10;
    private UnitGraphics unitGraphics_0;
    public Struct27(double A_0)
    {
        this.double_10 = A_0;
        this.unitGraphics_0 = UnitGraphics.Point;
    }

    public Struct27(double A_0, UnitGraphics A_1)
    {
        int num = 0x11;
        if (!Enum.IsDefined(typeof(UnitGraphics), A_1))
        {
            throw new InvalidEnumArgumentException(BookmarkStart.b("䌶䀸䬺堼", num));
        }
        this.double_10 = A_0;
        this.unitGraphics_0 = A_1;
    }

    public double method_0()
    {
        return this.double_10;
    }

    public UnitGraphics method_1()
    {
        return this.unitGraphics_0;
    }

    public double method_2()
    {
        switch (this.unitGraphics_0)
        {
            case UnitGraphics.Point:
                return this.double_10;

            case UnitGraphics.Inch:
                return (this.double_10 * 72.0);

            case UnitGraphics.Millimeter:
                return ((this.double_10 * 72.0) / 25.4);

            case UnitGraphics.Centimeter:
                return ((this.double_10 * 72.0) / 2.54);

            case UnitGraphics.Presentation:
                return ((this.double_10 * 72.0) / 96.0);
        }
        throw new InvalidCastException();
    }

    public void method_3(double A_0)
    {
        this.double_10 = A_0;
        this.unitGraphics_0 = UnitGraphics.Point;
    }

    public double method_4()
    {
        switch (this.unitGraphics_0)
        {
            case UnitGraphics.Point:
                return (this.double_10 / 72.0);

            case UnitGraphics.Inch:
                return this.double_10;

            case UnitGraphics.Millimeter:
                return (this.double_10 / 25.4);

            case UnitGraphics.Centimeter:
                return (this.double_10 / 2.54);

            case UnitGraphics.Presentation:
                return (this.double_10 / 96.0);
        }
        throw new InvalidCastException();
    }

    public void method_5(double A_0)
    {
        this.double_10 = A_0;
        this.unitGraphics_0 = UnitGraphics.Inch;
    }

    public double method_6()
    {
        switch (this.unitGraphics_0)
        {
            case UnitGraphics.Point:
                return ((this.double_10 * 25.4) / 72.0);

            case UnitGraphics.Inch:
                return (this.double_10 * 25.4);

            case UnitGraphics.Millimeter:
                return this.double_10;

            case UnitGraphics.Centimeter:
                return (this.double_10 * 10.0);

            case UnitGraphics.Presentation:
                return ((this.double_10 * 25.4) / 96.0);
        }
        throw new InvalidCastException();
    }

    public void method_7(double A_0)
    {
        this.double_10 = A_0;
        this.unitGraphics_0 = UnitGraphics.Millimeter;
    }

    public double method_8()
    {
        switch (this.unitGraphics_0)
        {
            case UnitGraphics.Point:
                return ((this.double_10 * 2.54) / 72.0);

            case UnitGraphics.Inch:
                return (this.double_10 * 2.54);

            case UnitGraphics.Millimeter:
                return (this.double_10 / 10.0);

            case UnitGraphics.Centimeter:
                return this.double_10;

            case UnitGraphics.Presentation:
                return ((this.double_10 * 2.54) / 96.0);
        }
        throw new InvalidCastException();
    }

    public void method_9(double A_0)
    {
        this.double_10 = A_0;
        this.unitGraphics_0 = UnitGraphics.Centimeter;
    }

    public double method_10()
    {
        switch (this.unitGraphics_0)
        {
            case UnitGraphics.Point:
                return ((this.double_10 * 96.0) / 72.0);

            case UnitGraphics.Inch:
                return (this.double_10 * 96.0);

            case UnitGraphics.Millimeter:
                return ((this.double_10 * 96.0) / 25.4);

            case UnitGraphics.Centimeter:
                return ((this.double_10 * 96.0) / 2.54);

            case UnitGraphics.Presentation:
                return this.double_10;
        }
        throw new InvalidCastException();
    }

    public void method_11(double A_0)
    {
        this.double_10 = A_0;
        this.unitGraphics_0 = UnitGraphics.Point;
    }

    public string method_12(IFormatProvider A_0)
    {
        return (this.double_10.ToString(A_0) + this.method_13());
    }

    string IFormattable.ToString(string A_0, IFormatProvider A_1)
    {
        return (this.double_10.ToString(A_0, A_1) + this.method_13());
    }

    string ValueType.ToString()
    {
        return (this.double_10.ToString(CultureInfo.InvariantCulture) + this.method_13());
    }

    private string method_13()
    {
        int num = 11;
        switch (this.unitGraphics_0)
        {
            case UnitGraphics.Point:
                return BookmarkStart.b("䄰䜲", num);

            case UnitGraphics.Inch:
                return BookmarkStart.b("堰崲", num);

            case UnitGraphics.Millimeter:
                return BookmarkStart.b("尰帲", num);

            case UnitGraphics.Centimeter:
                return BookmarkStart.b("到帲", num);

            case UnitGraphics.Presentation:
                return BookmarkStart.b("䄰䘲", num);
        }
        throw new InvalidCastException();
    }

    public static Struct27 smethod_0(double A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Point;
        return struct2;
    }

    public static Struct27 smethod_1(double A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Inch;
        return struct2;
    }

    public static Struct27 smethod_2(double A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Millimeter;
        return struct2;
    }

    public static Struct27 smethod_3(double A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Centimeter;
        return struct2;
    }

    public static Struct27 smethod_4(double A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Presentation;
        return struct2;
    }

    public static Struct27 smethod_5(string A_0)
    {
        Struct27 struct2;
        int num = 2;
        A_0 = A_0.Trim();
        A_0 = A_0.Replace(',', '.');
        int length = A_0.Length;
        int num3 = 0;
        while (num3 < length)
        {
            char c = A_0[num3];
            if (((c != '.') && (c != '-')) && ((c != '+') && !char.IsNumber(c)))
            {
                break;
            }
            num3++;
        }
        try
        {
            struct2.double_10 = double.Parse(A_0.Substring(0, num3).Trim(), CultureInfo.InvariantCulture);
        }
        catch (Exception exception)
        {
            struct2.double_10 = 1.0;
            throw new ArgumentException(string.Format(BookmarkStart.b("笧帩師䜭帯唱ᐳᄵ䌷ਹ䄻᤽怿⭁㝃晅♇╉㡋湍ㅏ牑≓㝕㑗㍙㡛繝ᙟ͡ࡣ፥൧䩩੫ŭɯ剱ݳɵ੷ཹύ੽ꚅ꾇튉\ud98b\ue08d憐뎓뢕", num), A_0), exception);
        }
        string str = A_0.Substring(num3).Trim().ToLower();
        struct2.unitGraphics_0 = UnitGraphics.Point;
        string key = str;
        if (key != null)
        {
            int num4;
            if (Class1160.dictionary_180 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("䬧䜩", num), 0);
                dictionary1.Add(BookmarkStart.b("䄧䐩", num), 1);
                dictionary1.Add(BookmarkStart.b("䔧䜩", num), 2);
                dictionary1.Add("", 3);
                dictionary1.Add(BookmarkStart.b("堧帩", num), 4);
                dictionary1.Add(BookmarkStart.b("堧弩", num), 5);
                Class1160.dictionary_180 = dictionary1;
            }
            if (Class1160.dictionary_180.TryGetValue(key, out num4))
            {
                switch (num4)
                {
                    case 0:
                        struct2.unitGraphics_0 = UnitGraphics.Centimeter;
                        return struct2;

                    case 1:
                        struct2.unitGraphics_0 = UnitGraphics.Inch;
                        return struct2;

                    case 2:
                        struct2.unitGraphics_0 = UnitGraphics.Millimeter;
                        return struct2;

                    case 3:
                    case 4:
                        struct2.unitGraphics_0 = UnitGraphics.Point;
                        return struct2;

                    case 5:
                        struct2.unitGraphics_0 = UnitGraphics.Presentation;
                        return struct2;
                }
            }
        }
        throw new ArgumentException(BookmarkStart.b("紧䐩䜫䀭弯䔱娳ᘵ䴷吹唻䨽怿㙁㵃㙅ⵇ灉汋楍", num) + str + BookmarkStart.b("༧", num));
    }

    public static Struct27 smethod_6(int A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Point;
        return struct2;
    }

    public static Struct27 smethod_7(double A_0)
    {
        Struct27 struct2;
        struct2.double_10 = A_0;
        struct2.unitGraphics_0 = UnitGraphics.Point;
        return struct2;
    }

    public static double smethod_8(Struct27 A_0)
    {
        return A_0.method_2();
    }

    public static bool smethod_9(Struct27 A_0, Struct27 A_1)
    {
        return ((A_0.unitGraphics_0 == A_1.unitGraphics_0) && (A_0.double_10 == A_1.double_10));
    }

    public static bool smethod_10(Struct27 A_0, Struct27 A_1)
    {
        return !smethod_9(A_0, A_1);
    }

    bool ValueType.Equals(object A_0)
    {
        return ((A_0 is Struct27) && smethod_9(this, (Struct27) A_0));
    }

    int ValueType.GetHashCode()
    {
        return (this.double_10.GetHashCode() ^ this.unitGraphics_0.GetHashCode());
    }

    public static Struct27 smethod_11(string A_0)
    {
        return smethod_5(A_0);
    }

    public void method_14(UnitGraphics A_0)
    {
        int num = 0x10;
        if (this.unitGraphics_0 != A_0)
        {
            switch (A_0)
            {
                case UnitGraphics.Point:
                    this.double_10 = this.method_2();
                    this.unitGraphics_0 = UnitGraphics.Point;
                    return;

                case UnitGraphics.Inch:
                    this.double_10 = this.method_4();
                    this.unitGraphics_0 = UnitGraphics.Inch;
                    return;

                case UnitGraphics.Millimeter:
                    this.double_10 = this.method_6();
                    this.unitGraphics_0 = UnitGraphics.Millimeter;
                    return;

                case UnitGraphics.Centimeter:
                    this.double_10 = this.method_8();
                    this.unitGraphics_0 = UnitGraphics.Centimeter;
                    return;

                case UnitGraphics.Presentation:
                    this.double_10 = this.method_10();
                    this.unitGraphics_0 = UnitGraphics.Presentation;
                    return;
            }
            throw new ArgumentException(BookmarkStart.b("挵嘷儹刻儽㜿ⱁ摃㍅♇⍉㡋湍⑏⭑⑓㍕扗穙筛", num) + A_0 + BookmarkStart.b("ᄵ", num));
        }
    }
}

