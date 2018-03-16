using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class676
{
    private bool bool_0;
    private bool bool_1;
    private Class952 class952_0;
    private Class952 class952_1;
    private float float_0;
    private float float_1;
    private float float_2;
    private float float_3;
    private static readonly int[] int_0;
    private static readonly int[] int_1;
    private static readonly int[] int_2;
    private static readonly int[] int_3;
    private static readonly int[] int_4;
    private static readonly int[] int_5;

    static Class676()
    {
        int[] numArray = new int[3];
        numArray[0] = 3;
        numArray[2] = 1;
        int_0 = numArray;
        int[] numArray2 = new int[3];
        numArray2[0] = 1;
        numArray2[2] = 3;
        int_1 = numArray2;
        int[] numArray3 = new int[3];
        numArray3[0] = 1;
        numArray3[2] = 1;
        int_2 = numArray3;
        int_3 = new int[] { 5, 0, 3, 0, 1 };
        int_4 = new int[] { 1, 0, 3, 0, 5 };
        int_5 = new int[] { 1, 0, 3, 0, 1 };
    }

    internal void method_0(Class952 A_0, Class952 A_1, bool A_2, bool A_3, Class319 A_4)
    {
        this.class952_0 = A_0;
        this.class952_1 = A_1;
        this.bool_0 = A_2;
        this.bool_1 = A_3;
        this.float_0 = this.class952_0.method_1().X;
        this.float_1 = this.class952_0.method_1().Y;
        this.float_2 = this.class952_1.method_1().X;
        this.float_3 = this.class952_1.method_1().Y;
        this.method_2();
        this.method_4();
        this.method_1();
        this.method_8(A_4);
        if (this.method_44())
        {
            this.method_16(A_4);
        }
    }

    private void method_1()
    {
        if (this.method_36() == BorderType.Horizontal)
        {
            this.float_1 += this.method_39();
            this.float_3 += this.method_39();
        }
    }

    private bool method_10()
    {
        int num = 0x13;
        switch (this.method_36())
        {
            case BorderType.Bottom:
            case BorderType.Horizontal:
                return false;

            case BorderType.Left:
                return true;

            case BorderType.Right:
            case BorderType.Vertical:
                return false;

            case BorderType.Top:
                return true;
        }
        throw new InvalidOperationException(BookmarkStart.b("永唺嘼儾⹀㑂⭄杆⭈⑊㽌⭎㑐⅒畔⍖⁘⭚㡜煞", num));
    }

    private bool method_11()
    {
        int num = 9;
        switch (this.method_36())
        {
            case BorderType.Bottom:
            case BorderType.Right:
                return this.method_35().method_18();

            case BorderType.Left:
            case BorderType.Top:
            case BorderType.Horizontal:
            case BorderType.Vertical:
                return false;
        }
        throw new InvalidOperationException(BookmarkStart.b("種弰堲嬴堶丸唺ᴼ崾⹀ㅂ⅄≆㭈歊㥌㙎⅐㙒答", num));
    }

    private bool method_12()
    {
        int num = 6;
        switch (this.method_36())
        {
            case BorderType.Bottom:
                return false;

            case BorderType.Left:
                if (!this.class952_1.method_6())
                {
                    return false;
                }
                return this.method_35().method_18();

            case BorderType.Right:
                if (this.class952_1.method_6())
                {
                    return false;
                }
                return this.method_35().method_18();

            case BorderType.Top:
                return this.method_35().method_18();

            case BorderType.Horizontal:
                return this.method_35().method_18();

            case BorderType.Vertical:
                return false;
        }
        throw new InvalidOperationException(BookmarkStart.b("礫䀭嬯就嬳䄵嘷ᨹ帻儽㈿♁⅃㑅桇㹉㕋㹍㕏籑", num));
    }

    private bool method_13()
    {
        int num = 0x10;
        switch (this.method_36())
        {
            case BorderType.Bottom:
            case BorderType.Right:
                return !this.method_35().method_18();

            case BorderType.Left:
            case BorderType.Top:
                return false;

            case BorderType.Horizontal:
            case BorderType.Vertical:
                return true;
        }
        throw new InvalidOperationException(BookmarkStart.b("挵嘷儹刻儽㜿ⱁ摃⑅❇㡉⡋⭍≏牑⁓⽕⡗㽙牛", num));
    }

    private float[] method_14(bool A_0)
    {
        float[] array = Class1031.smethod_4(this.method_41(), this.method_40());
        if (A_0)
        {
            Array.Reverse(array);
        }
        return array;
    }

    private void method_15(spr⚪ A_0)
    {
        float[] numArray = Class1031.smethod_2(this.method_41(), 1f);
        if (numArray != null)
        {
            A_0.ᜁ(numArray);
        }
    }

    private void method_16(Class319 A_0)
    {
        this.float_0 = this.class952_0.method_1().X;
        this.float_1 = this.class952_0.method_1().Y;
        this.float_2 = this.class952_1.method_1().X;
        this.float_3 = this.class952_1.method_1().Y;
        this.method_17(-this.method_39() / 2f);
        PointF tf5 = this.method_18(-this.method_39());
        float num = this.method_45() ? ((float) 0) : ((float) 1);
        PointF tf6 = this.method_19(this.method_39() * num);
        sprᲆ rᲆ = sprᲆ.ᜁ(tf5, tf6);
        rᲆ.ᜀ(new spr⚪(sprⓚ.ᜋ, this.method_39()));
        A_0.method_4(rᲆ);
    }

    private void method_17(float A_0)
    {
        int num = 12;
        switch (this.method_36())
        {
            case BorderType.Bottom:
            case BorderType.Horizontal:
                this.float_1 -= A_0;
                this.float_3 -= A_0;
                return;

            case BorderType.Left:
                this.float_0 += A_0;
                this.float_2 += A_0;
                return;

            case BorderType.Right:
            case BorderType.Vertical:
                this.float_0 -= A_0;
                this.float_2 -= A_0;
                return;

            case BorderType.Top:
                this.float_1 += A_0;
                this.float_3 += A_0;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("朱娳匵䀷䨹夻崽㐿❁⁃晅⩇╉㹋⩍㕏⁑瑓≕⅗⩙㥛灝", num));
    }

    private PointF method_18(float A_0)
    {
        if (this.method_46())
        {
            return new PointF(this.float_0, this.float_1 - A_0);
        }
        return new PointF(this.float_0 - A_0, this.float_1);
    }

    private PointF method_19(float A_0)
    {
        if (this.method_46())
        {
            return new PointF(this.float_2, this.float_3 + A_0);
        }
        return new PointF(this.float_2 + A_0, this.float_3);
    }

    private void method_2()
    {
        if (this.bool_0)
        {
            if (this.method_45())
            {
                PointF tf2 = this.method_18(this.method_7(this.class952_0) / 2f);
                this.float_0 = tf2.X;
                this.float_1 = tf2.Y;
                PointF tf3 = this.method_19(this.method_7(this.class952_1) / 2f);
                this.float_2 = tf3.X;
                this.float_3 = tf3.Y;
            }
            switch (this.method_36())
            {
                case BorderType.Bottom:
                    this.float_1 = this.float_3;
                    this.float_1 += this.method_39();
                    this.float_3 += this.method_39();
                    return;

                case BorderType.Left:
                    this.float_0 -= this.method_39() / 2f;
                    this.float_2 -= this.method_39() / 2f;
                    return;

                case BorderType.Right:
                    this.method_3();
                    return;

                case BorderType.Top:
                case BorderType.Horizontal:
                    return;

                case BorderType.Vertical:
                    if (this.class952_1.method_6() && this.class952_1.method_27())
                    {
                        this.float_3 = this.class952_1.method_15().method_1().Y;
                    }
                    this.method_3();
                    return;
            }
        }
    }

    private int[] method_20(Class952 A_0)
    {
        switch (this.method_35().method_30())
        {
            case 3:
                return this.method_21(A_0, int_0, int_1, int_2);

            case 5:
                return this.method_21(A_0, int_3, int_4, int_5);
        }
        return null;
    }

    private int[] method_21(Class952 A_0, int[] A_1, int[] A_2, int[] A_3)
    {
        int num = 3;
        switch (A_0.method_25())
        {
            case 2:
                switch (this.method_36())
                {
                    case BorderType.Horizontal:
                        if (!A_0.method_28())
                        {
                            return A_2;
                        }
                        return A_1;

                    case BorderType.Vertical:
                        if (!A_0.method_26())
                        {
                            return A_2;
                        }
                        return A_1;
                }
                return A_1;

            case 3:
                switch (this.method_36())
                {
                    case BorderType.Horizontal:
                        if (A_0.method_28() && A_0.method_29())
                        {
                            return A_3;
                        }
                        if (!A_0.method_28())
                        {
                            return A_2;
                        }
                        return A_1;

                    case BorderType.Vertical:
                        if (A_0.method_26() && A_0.method_27())
                        {
                            return A_3;
                        }
                        if (!A_0.method_26())
                        {
                            return A_2;
                        }
                        return A_1;
                }
                return A_1;

            case 4:
                return A_3;
        }
        throw new InvalidOperationException(BookmarkStart.b("簨䔪䠬圮䄰嘲嘴䌶尸强ᴼ儾㑀⹂❄≆㭈歊≌⥎煐げ㩔㥖㝘㹚㹜⭞Ѡݢ䕤զ٨ᥪ६੮Ͱr啴ᙶ൸孺ᱼ彾ﶈꖊ", num));
    }

    private bool method_22()
    {
        if (!this.method_46())
        {
            return this.class952_0.method_27();
        }
        return this.class952_0.method_29();
    }

    private bool method_23()
    {
        if (!this.method_46())
        {
            return this.class952_1.method_26();
        }
        return this.class952_1.method_28();
    }

    private sprᲆ method_24(PointF A_0, PointF A_1, int A_2, float[] A_3)
    {
        int num = 10;
        float num2 = A_3[A_2];
        sprᲆ rᲆ = null;
        switch (this.method_41())
        {
            case BorderStyle.Single:
            case BorderStyle.Thick:
            case BorderStyle.Double:
            case BorderStyle.Hairline:
            case BorderStyle.Dot:
            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
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
            case BorderStyle.DashSmallGap:
            case BorderStyle.Outset:
            case BorderStyle.Inset:
                rᲆ = Class449.smethod_0(A_0, A_1, num2, this.method_37());
                break;

            case BorderStyle.Wave:
                rᲆ = Class449.smethod_2(A_0, A_1, this.method_39(), this.method_37(), this.method_45());
                break;

            case BorderStyle.DoubleWave:
                rᲆ = Class449.smethod_3(A_0, A_1, this.method_39(), this.method_37(), this.method_45());
                break;

            case BorderStyle.DashDotStroker:
                rᲆ = Class449.smethod_5(A_0, A_1, this.method_39(), this.method_37(), this.method_45());
                break;

            case BorderStyle.Emboss3D:
                rᲆ = Class449.smethod_1(A_0, A_1, this.method_33(A_2, num2, false));
                break;

            case BorderStyle.Engrave3D:
                rᲆ = Class449.smethod_1(A_0, A_1, this.method_33(A_2, num2, true));
                break;
        }
        if (rᲆ == null)
        {
            throw new InvalidOperationException(BookmarkStart.b("支就弳堵圷䴹刻ḽ∿ⵁ㙃≅ⵇ㡉汋≍㥏㱑ㅓ癕⭗⹙╛㉝՟䱡", num));
        }
        if (A_3.Length == 1)
        {
            this.method_15(rᲆ.ᜀ());
        }
        return rᲆ;
    }

    private spr➓ method_25(PointF A_0, PointF A_1, float A_2)
    {
        return this.method_26(A_0, A_1, A_2, this.method_45());
    }

    private spr➓ method_26(PointF A_0, PointF A_1, float A_2, bool A_3)
    {
        Class1025 class2 = Class779.smethod_0((PageBorderArt) this.method_41());
        float num = A_3 ? (A_1.X - A_0.X) : (A_1.Y - A_0.Y);
        float num4 = A_3 ? class2.method_1() : class2.method_2();
        num4 = this.method_27(num4, num, A_2, A_3);
        int num3 = this.method_31(num, A_2, num4, A_3);
        float num5 = this.method_32(num, A_2, num4, A_3);
        float num7 = 0f;
        spr➓ r➓ = new spr➓();
        for (int i = 0; i < num3; i++)
        {
            PageBorderArtElementPosition position = this.method_28(i, num3, A_3);
            float width = this.method_29(A_2, num4, num5, position);
            SizeF ef = A_3 ? new SizeF(width, A_2) : new SizeF(A_2, width);
            sprἣ sprἣ = new sprἣ(this.method_30(A_0, num7, A_2, A_3), ef, class2.method_4(this.method_36(), position));
            r➓.ᜁ(sprἣ);
            num7 += width;
        }
        return r➓;
    }

    private float method_27(float A_0, float A_1, float A_2, bool A_3)
    {
        int num = A_3 ? 2 : 0;
        float num2 = A_1 - (num * A_2);
        if (num2 < (A_2 * A_0))
        {
            A_0 = num2 / A_2;
        }
        return A_0;
    }

    private PageBorderArtElementPosition method_28(int A_0, int A_1, bool A_2)
    {
        if (!A_2)
        {
            return PageBorderArtElementPosition.Middle;
        }
        if (A_0 == 0)
        {
            return PageBorderArtElementPosition.First;
        }
        if (A_0 != (A_1 - 1))
        {
            return PageBorderArtElementPosition.Middle;
        }
        return PageBorderArtElementPosition.Last;
    }

    private float method_29(float A_0, float A_1, float A_2, PageBorderArtElementPosition A_3)
    {
        if (A_3 == PageBorderArtElementPosition.Middle)
        {
            return ((A_0 * A_1) + A_2);
        }
        return A_0;
    }

    private void method_3()
    {
        this.float_0 += this.method_39() / 2f;
        this.float_2 += this.method_39() / 2f;
    }

    private PointF method_30(PointF A_0, float A_1, float A_2, bool A_3)
    {
        if (!A_3)
        {
            return new PointF(A_0.X - (A_2 / 2f), A_0.Y + A_1);
        }
        return new PointF(A_0.X + A_1, A_0.Y - (A_2 / 2f));
    }

    private int method_31(float A_0, float A_1, float A_2, bool A_3)
    {
        int num = A_3 ? 2 : 0;
        float num2 = num * A_1;
        int num3 = (int) ((A_0 - num2) / (A_1 * A_2));
        return (num + num3);
    }

    private float method_32(float A_0, float A_1, float A_2, bool A_3)
    {
        int num = A_3 ? 2 : 0;
        int num2 = this.method_31(A_0, A_1, A_2, A_3) - num;
        float num3 = num * A_1;
        float num4 = (num2 * A_1) * A_2;
        return (((A_0 - num3) - num4) / ((float) num2));
    }

    private spr⚪ method_33(int A_0, float A_1, bool A_2)
    {
        sprⓚ[] rⓚArray3;
        sprⓚ[] rⓚArray = this.method_34();
        if (A_2)
        {
            rⓚArray3 = new sprⓚ[] { rⓚArray[0], sprⓚ.ទ, rⓚArray[1], sprⓚ.ទ, rⓚArray[2] };
        }
        else
        {
            rⓚArray3 = new sprⓚ[] { rⓚArray[2], sprⓚ.ទ, rⓚArray[1], sprⓚ.ទ, rⓚArray[0] };
        }
        if (this.method_13())
        {
            Array.Reverse(rⓚArray3);
        }
        return new spr⚪(rⓚArray3[A_0], A_1);
    }

    private sprⓚ[] method_34()
    {
        sprⓚ[] rⓚArray = new sprⓚ[3];
        spr᭵ r᭵ = new spr᭵(this.method_37());
        if (r᭵.ᜃ() < 85f)
        {
            rⓚArray[0] = this.method_37();
            rⓚArray[1] = spr᭵.ᜀ(this.method_37(), 85f);
            rⓚArray[2] = spr᭵.ᜀ(this.method_37(), 170f);
            return rⓚArray;
        }
        if (r᭵.ᜃ() < 170f)
        {
            rⓚArray[0] = spr᭵.ᜀ(this.method_37(), -85f);
            rⓚArray[1] = this.method_37();
            rⓚArray[2] = spr᭵.ᜀ(this.method_37(), 85f);
            return rⓚArray;
        }
        rⓚArray[0] = spr᭵.ᜀ(this.method_37(), -170f);
        rⓚArray[1] = spr᭵.ᜀ(this.method_37(), -85f);
        rⓚArray[2] = this.method_37();
        return rⓚArray;
    }

    private Class1031 method_35()
    {
        if (this.method_46())
        {
            return this.class952_0.method_12();
        }
        return this.class952_0.method_9();
    }

    private BorderType method_36()
    {
        if (this.class952_0.method_3() && this.class952_1.method_3())
        {
            return BorderType.Left;
        }
        if (this.class952_0.method_4() && this.class952_1.method_4())
        {
            return BorderType.Right;
        }
        if (this.class952_0.method_5() && this.class952_1.method_5())
        {
            return BorderType.Top;
        }
        if (this.class952_0.method_6() && this.class952_1.method_6())
        {
            return BorderType.Bottom;
        }
        if (this.bool_1)
        {
            return BorderType.Vertical;
        }
        return BorderType.Horizontal;
    }

    private sprⓚ method_37()
    {
        sprⓚ rⓚ = sprⓚ.ᜀ(this.method_35().method_12());
        if (rⓚ.ᜈ())
        {
            return sprⓚ.ᜋ;
        }
        return rⓚ;
    }

    private float method_38()
    {
        return (float) this.method_35().method_3();
    }

    private float method_39()
    {
        return this.method_35().method_8();
    }

    private void method_4()
    {
        if (this.method_5())
        {
            PointF tf = this.method_18(-this.method_7(this.class952_0));
            this.float_0 = tf.X;
            this.float_1 = tf.Y;
        }
        if (this.method_6())
        {
            PointF tf2 = this.method_19(-this.method_7(this.class952_1));
            this.float_2 = tf2.X;
            this.float_3 = tf2.Y;
        }
    }

    private float method_40()
    {
        switch (this.method_41())
        {
            case BorderStyle.Single:
            case BorderStyle.Dot:
            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
            case BorderStyle.Wave:
            case BorderStyle.DoubleWave:
            case BorderStyle.DashSmallGap:
            case BorderStyle.DashDotStroker:
                return this.method_39();

            case BorderStyle.Thick:
            case BorderStyle.Hairline:
                return 1f;

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
                return this.method_38();

            case BorderStyle.Outset:
            case BorderStyle.Inset:
                return 1f;
        }
        return this.method_39();
    }

    private BorderStyle method_41()
    {
        return this.method_35().method_1();
    }

    private bool method_42()
    {
        return this.method_35().method_6();
    }

    private bool method_43()
    {
        return this.method_35().method_50();
    }

    private bool method_44()
    {
        if (!this.method_35().method_16())
        {
            return false;
        }
        if (this.method_36() != BorderType.Bottom)
        {
            return (this.method_36() == BorderType.Right);
        }
        return true;
    }

    private bool method_45()
    {
        switch (this.method_36())
        {
            case BorderType.Bottom:
            case BorderType.Top:
            case BorderType.Horizontal:
                return true;
        }
        return false;
    }

    private bool method_46()
    {
        switch (this.method_36())
        {
            case BorderType.Left:
            case BorderType.Right:
            case BorderType.Vertical:
                return true;
        }
        return false;
    }

    private bool method_5()
    {
        if (!this.method_46() && !this.class952_0.method_24())
        {
            return this.class952_0.method_23();
        }
        return true;
    }

    private bool method_6()
    {
        if (this.method_46())
        {
            return (this.class952_1.method_6() && !this.bool_0);
        }
        if (!this.class952_1.method_23())
        {
            return this.class952_1.method_24();
        }
        return true;
    }

    private float method_7(Class952 A_0)
    {
        int num = 3;
        switch (this.method_36())
        {
            case BorderType.Bottom:
                return A_0.method_10().method_8();

            case BorderType.Left:
                return A_0.method_9().method_8();

            case BorderType.Right:
                return A_0.method_7().method_8();

            case BorderType.Top:
                return A_0.method_12().method_8();

            case BorderType.Horizontal:
                if (A_0.method_28())
                {
                    return A_0.method_10().method_8();
                }
                return A_0.method_12().method_8();

            case BorderType.Vertical:
                if (A_0.method_27())
                {
                    return A_0.method_9().method_8();
                }
                return A_0.method_7().method_8();
        }
        throw new InvalidOperationException(BookmarkStart.b("簨䔪䠬圮䄰嘲嘴䌶尸强ᴼ崾⹀ㅂ⅄≆㭈歊㥌㙎⅐㙒答", num));
    }

    private void method_8(Class319 A_0)
    {
        float[] numArray = null;
        int[] numArray2 = null;
        bool flag;
        bool flag3;
        if (flag = this.method_22())
        {
            bool flag2 = ((this.class952_0.method_21() ^ this.method_9()) ^ this.method_11()) ^ this.method_13();
            numArray = this.method_14(flag2);
            numArray2 = this.method_20(this.class952_0);
        }
        float[] numArray4 = null;
        int[] numArray5 = null;
        if (flag3 = this.method_23())
        {
            bool flag4 = ((this.class952_1.method_21() ^ this.method_10()) ^ this.method_12()) ^ this.method_13();
            numArray4 = this.method_14(flag4);
            numArray5 = this.method_20(this.class952_1);
        }
        float[] numArray3 = this.method_14(this.method_13());
        for (int i = 0; i < numArray3.Length; i++)
        {
            float num2 = numArray3[i] / 2f;
            this.method_17(num2);
            if (!sprḆ.ᜀ((long) i))
            {
                PointF tf;
                PointF tf2;
                if (flag)
                {
                    tf = this.method_18(smethod_0(numArray2[i], numArray));
                }
                else
                {
                    tf = new PointF(this.float_0, this.float_1);
                }
                if (flag3)
                {
                    tf2 = this.method_19(smethod_0(numArray5[i], numArray4));
                }
                else
                {
                    tf2 = new PointF(this.float_2, this.float_3);
                }
                sprᮃ rᮃ = this.method_42() ? this.method_25(tf, tf2, numArray3[i]) : this.method_24(tf, tf2, i, numArray3);
                A_0.method_4(rᮃ);
            }
            this.method_17(num2);
        }
    }

    private bool method_9()
    {
        int num = 11;
        switch (this.method_36())
        {
            case BorderType.Bottom:
            case BorderType.Horizontal:
                return true;

            case BorderType.Left:
                return false;

            case BorderType.Right:
            case BorderType.Vertical:
                return true;

            case BorderType.Top:
                return false;
        }
        throw new InvalidOperationException(BookmarkStart.b("搰崲帴夶嘸䰺匼Ἶ⍀ⱂ㝄⍆ⱈ㥊浌㭎⡐⍒ご祖", num));
    }

    private static float smethod_0(int A_0, float[] A_1)
    {
        float num = 0f;
        int index = A_1.Length - 1;
        while (A_0 > 0)
        {
            num += A_1[index];
            index--;
            A_0--;
        }
        return num;
    }
}

