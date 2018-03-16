using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

internal class Class930
{
    private Class657 class657_0;
    private Class657 class657_1;
    private readonly Class658 class658_0;
    private readonly Hashtable hashtable_0 = new Hashtable();
    private int int_0;
    private int int_1;
    private int int_10;
    private int int_11;
    private int int_12;
    private int int_13;
    private int int_14;
    private int int_15;
    private int int_16;
    private int int_17;
    private int int_18;
    private int int_19;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;
    private int int_9;
    private ShapeBase shapeBase_0;

    internal Class930(Class658 A_0)
    {
        this.class658_0 = A_0;
    }

    internal void method_0(Class657 A_0, ShapeBase A_1)
    {
        this.shapeBase_0 = A_1;
        this.class657_0 = A_0;
        this.class657_1 = null;
        for (int i = 0; i < A_0.method_2(); i++)
        {
            Class171 class2 = (Class171) A_0.method_12(i);
            int num3 = class2.method_0() & -64;
            int num2 = num3;
            if (num2 <= 0x340)
            {
                if (num2 <= 0x180)
                {
                    if (num2 <= 0x80)
                    {
                        switch (num2)
                        {
                            case 0:
                            {
                                this.method_1(class2);
                                continue;
                            }
                            case 0x40:
                            {
                                this.method_2(class2);
                                continue;
                            }
                        }
                        if (num2 != 0x80)
                        {
                            goto Label_02A1;
                        }
                        this.method_3(class2);
                    }
                    else if (num2 <= 0x100)
                    {
                        if (num2 != 0xc0)
                        {
                            if (num2 != 0x100)
                            {
                                goto Label_02A1;
                            }
                            this.method_5(class2);
                        }
                        else
                        {
                            this.method_4(class2);
                        }
                    }
                    else if (num2 != 320)
                    {
                        if (num2 != 0x180)
                        {
                            goto Label_02A1;
                        }
                        this.method_7(class2);
                    }
                    else
                    {
                        this.method_6(class2);
                    }
                }
                else if (num2 <= 0x240)
                {
                    switch (num2)
                    {
                        case 0x1c0:
                        {
                            this.method_8(class2, num3);
                            continue;
                        }
                        case 0x200:
                        {
                            this.method_9(class2);
                            continue;
                        }
                    }
                    if (num2 != 0x240)
                    {
                        goto Label_02A1;
                    }
                    this.method_10(class2);
                }
                else if (num2 <= 0x2c0)
                {
                    if (num2 != 640)
                    {
                        if (num2 != 0x2c0)
                        {
                            goto Label_02A1;
                        }
                        this.method_12(class2);
                    }
                    else
                    {
                        this.method_11(class2);
                    }
                }
                else if (num2 != 0x300)
                {
                    if (num2 != 0x340)
                    {
                        goto Label_02A1;
                    }
                    this.method_14(class2);
                }
                else
                {
                    this.method_13(class2);
                }
                continue;
            }
            if (num2 <= 0x600)
            {
                if (num2 <= 0x500)
                {
                    switch (num2)
                    {
                        case 0x380:
                        {
                            this.method_15(class2);
                            continue;
                        }
                        case 0x400:
                        {
                            this.method_16(class2);
                            continue;
                        }
                    }
                    if (num2 != 0x500)
                    {
                        goto Label_02A1;
                    }
                    this.method_17(class2);
                    continue;
                }
                switch (num2)
                {
                    case 0x540:
                    case 0x580:
                    case 0x5c0:
                    case 0x600:
                        goto Label_0240;
                }
            }
            else
            {
                if (num2 > 0x700)
                {
                    goto Label_026E;
                }
                if (num2 > 0x680)
                {
                    goto Label_024A;
                }
                switch (num2)
                {
                    case 0x640:
                        goto Label_0240;

                    case 0x680:
                    {
                        continue;
                    }
                }
            }
            goto Label_02A1;
        Label_0240:
            this.method_8(class2, num3);
            continue;
        Label_024A:
            if (num2 != 0x6c0)
            {
                if (num2 != 0x700)
                {
                    goto Label_02A1;
                }
                this.method_19(class2);
            }
            else
            {
                this.method_18(class2);
            }
            continue;
        Label_026E:
            if (num2 <= 0x780)
            {
                if (num2 != 0x740)
                {
                    if (num2 != 0x780)
                    {
                        goto Label_02A1;
                    }
                    this.method_20(class2);
                }
                continue;
            }
            switch (num2)
            {
                case 0x7c0:
                {
                    this.method_21(class2);
                    continue;
                }
                case 0x1000:
                {
                    continue;
                }
            }
        Label_02A1:
            this.method_22(class2.method_0());
        }
        if (this.shapeBase_0.IsSignatureLine && !this.shapeBase_0.ShapePr.HasKey(0x7bc))
        {
            this.shapeBase_0.SetShapeAttr(0x7bc, true);
        }
        Class600.smethod_0(this.shapeBase_0.ShapePr);
    }

    private void method_1(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        if (A_0.method_0() == 4)
        {
            this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
        }
        else
        {
            this.method_22(A_0.method_0());
        }
    }

    private void method_10(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x240:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (PerspectiveType) num);
                return;

            case 0x241:
            case 0x242:
            case 0x243:
            case 580:
            case 0x245:
            case 0x246:
            case 0x247:
            case 0x248:
            case 0x249:
            case 0x24a:
            case 0x24b:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x27f:
                smethod_1(this.shapeBase_0, 0x27f, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_11(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 640:
            case 0x281:
            case 0x282:
            case 0x283:
            case 0x284:
            case 0x285:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x286:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (PlaneType) num);
                return;

            case 0x287:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), Class624.smethod_7(num));
                return;

            case 0x288:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x289:
            case 650:
            case 0x28b:
            case 0x28d:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x28c:
                break;

            case 0x2bf:
                smethod_1(this.shapeBase_0, 700, num);
                smethod_1(this.shapeBase_0, 0x2bd, num);
                smethod_1(this.shapeBase_0, 0x2be, num);
                smethod_1(this.shapeBase_0, 0x2bf, num);
                return;

            default:
                this.method_22(A_0.method_0());
                break;
        }
    }

    private void method_12(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x2c0:
            case 0x2c1:
            case 0x2c2:
            case 0x2c3:
            case 0x2c4:
            case 0x2c5:
            case 710:
            case 0x2c7:
            case 0x2c8:
            case 0x2ca:
            case 0x2cb:
            case 0x2cc:
            case 0x2cd:
            case 0x2ce:
            case 0x2cf:
            case 720:
            case 0x2d1:
            case 0x2d2:
            case 0x2d3:
            case 0x2d4:
            case 0x2d5:
            case 0x2d6:
            case 0x2d7:
            case 0x2d8:
            case 0x2d9:
            case 730:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x2c9:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ThreeDRenderMode) num);
                return;

            case 0x2ff:
                smethod_1(this.shapeBase_0, 0x2fb, num);
                smethod_1(this.shapeBase_0, 0x2fc, num);
                smethod_1(this.shapeBase_0, 0x2fd, num);
                smethod_1(this.shapeBase_0, 0x2fe, num);
                smethod_1(this.shapeBase_0, 0x2ff, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_13(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x301:
                return;

            case 0x303:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ConnectorType) num);
                return;

            case 0x304:
            case 0x305:
            case 0x306:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (BWMode) num);
                return;

            case 0x309:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (DiagramNodeLayout) num);
                return;

            case 0x30a:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (DiagramNodeKind) num);
                return;

            case 0x30b:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 780:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), ((Class174) A_0).method_3());
                return;

            case 0x33f:
                smethod_1(this.shapeBase_0, 0x33a, num);
                smethod_1(this.shapeBase_0, 0x33b, num);
                smethod_1(this.shapeBase_0, 0x33c, num);
                smethod_1(this.shapeBase_0, 830, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_14(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x340:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (CalloutType) num);
                return;

            case 0x341:
            case 0x344:
            case 0x345:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x342:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (CalloutAngle) num);
                return;

            case 0x343:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (CalloutDropType) num);
                return;

            case 0x37f:
                smethod_1(this.shapeBase_0, 0x379, num);
                smethod_1(this.shapeBase_0, 890, num);
                smethod_1(this.shapeBase_0, 0x37b, num);
                smethod_1(this.shapeBase_0, 0x37c, num);
                smethod_1(this.shapeBase_0, 0x37d, num);
                smethod_1(this.shapeBase_0, 0x37e, num);
                smethod_1(this.shapeBase_0, 0x37f, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_15(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x380:
            case 0x381:
            case 0x38d:
            case 910:
            case 0x397:
            case 0x39a:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), ((Class175) A_0).method_3());
                return;

            case 0x382:
            {
                Class177 class4 = (Class177) A_0;
                this.shapeBase_0.HRef = Class736.smethod_4(class4.method_5(), class4.method_6());
                if (Class567.smethod_16(class4.method_7()))
                {
                    this.shapeBase_0.Target = class4.method_7();
                }
                return;
            }
            case 0x383:
            {
                Class891[] classArray = ((Class173) A_0).method_5();
                if (classArray != null)
                {
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray);
                }
                return;
            }
            case 900:
            case 0x385:
            case 0x386:
            case 0x387:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x388:
            case 0x396:
            case 0x39f:
            case 0x3a0:
            case 0x3a5:
            case 0x3a9:
            case 0x3aa:
                return;

            case 0x38f:
                this.shapeBase_0.HorizontalAlignment = (ShapeHorizontalAlignment) num;
                return;

            case 0x390:
                this.shapeBase_0.HorizontalOrigin = (HorizontalOrigin) num;
                return;

            case 0x391:
                this.shapeBase_0.VerticalAlignment = (ShapeVerticalAlignment) num;
                return;

            case 0x392:
                this.shapeBase_0.VerticalOrigin = (VerticalOrigin) num;
                return;

            case 0x393:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x394:
                switch (num)
                {
                    case 1:
                        this.shapeBase_0.SetShapeAttr(A_0.method_0(), ShapeHorizontalAlignment.Center);
                        return;

                    case 2:
                        this.shapeBase_0.SetShapeAttr(A_0.method_0(), ShapeHorizontalAlignment.Right);
                        return;
                }
                return;

            case 0x395:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 920:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x39b:
            case 0x39c:
            case 0x39d:
            case 0x39e:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), Class624.smethod_7(num));
                return;

            case 0x3bf:
                smethod_1(this.shapeBase_0, 0x3b9, num);
                smethod_1(this.shapeBase_0, 0x3ba, num);
                smethod_1(this.shapeBase_0, 0x3bb, num);
                smethod_1(this.shapeBase_0, 0x3bc, num);
                smethod_1(this.shapeBase_0, 0x3bd, num);
                smethod_1(this.shapeBase_0, 0x3be, num);
                smethod_1(this.shapeBase_0, 0x3bf, num);
                smethod_1(this.shapeBase_0, 0x3b0, num);
                smethod_1(this.shapeBase_0, 0x3b1, num);
                smethod_1(this.shapeBase_0, 0x3b2, num);
                smethod_1(this.shapeBase_0, 0x3b3, num);
                smethod_1(this.shapeBase_0, 0x3b4, num);
                smethod_1(this.shapeBase_0, 950, num);
                smethod_1(this.shapeBase_0, 0x3b7, num);
                smethod_1(this.shapeBase_0, 0x3b8, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_16(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        if (A_0.method_0() == 0x43f)
        {
            this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
        }
        else
        {
            this.method_22(A_0.method_0());
        }
    }

    private void method_17(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x500:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (EditAs) num);
                return;

            case 0x501:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x504:
            {
                Class782[] classArray = ((Class173) A_0).method_4();
                if (classArray != null)
                {
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray);
                }
                return;
            }
            case 0x505:
            case 0x506:
            case 0x507:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x508:
            {
                int[] numArray = ((Class173) A_0).method_10();
                if (numArray != null)
                {
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), numArray);
                    return;
                }
                return;
            }
            case 0x509:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x53f:
                smethod_1(this.shapeBase_0, 0x53c, num);
                smethod_1(this.shapeBase_0, 0x53d, num);
                smethod_1(this.shapeBase_0, 0x53e, num);
                if ((num & 1) != 0)
                {
                    this.shapeBase_0.TextWrappingStyle = TextWrappingStyle.Inline;
                    return;
                }
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_18(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x6c0:
                break;

            case 0x6ff:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            default:
                this.method_22(A_0.method_0());
                break;
        }
    }

    private void method_19(Class171 A_0)
    {
        int num = A_0.method_0();
        if (num != 0x700)
        {
            if (num != 0x73f)
            {
                this.method_22(A_0.method_0());
            }
            else
            {
                EscherInkFlags flags = (EscherInkFlags) A_0.vmethod_1();
                if ((flags & EscherInkFlags.UseInkAnnotation) != 0)
                {
                    this.shapeBase_0.SetShapeAttr(0x73f, (flags & EscherInkFlags.InkAnnotation) != 0);
                }
            }
        }
        else
        {
            this.shapeBase_0.SetShapeAttr(A_0.method_0(), ((Class176) A_0).method_3());
        }
    }

    private void method_2(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        if (A_0.method_0() == 0x7f)
        {
            smethod_1(this.shapeBase_0, 0x77, num);
            smethod_1(this.shapeBase_0, 120, num);
            smethod_1(this.shapeBase_0, 0x79, num);
            smethod_1(this.shapeBase_0, 0x7a, num);
            smethod_1(this.shapeBase_0, 0x7b, num);
            smethod_1(this.shapeBase_0, 0x7c, num);
            smethod_1(this.shapeBase_0, 0x7d, num);
            smethod_1(this.shapeBase_0, 0x7e, num);
            smethod_1(this.shapeBase_0, 0x7f, num);
        }
        else
        {
            this.method_22(A_0.method_0());
        }
    }

    private void method_20(Class171 A_0)
    {
        switch (A_0.method_0())
        {
            case 0x781:
            case 0x782:
            case 0x783:
            case 0x784:
            case 0x785:
            case 0x786:
            case 0x787:
            case 0x788:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), ((Class175) A_0).method_3());
                return;

            case 0x7bf:
                smethod_1(this.shapeBase_0, 0x7bd, A_0.vmethod_1());
                smethod_1(this.shapeBase_0, 0x7bc, A_0.vmethod_1());
                smethod_1(this.shapeBase_0, 0x7be, A_0.vmethod_1());
                smethod_1(this.shapeBase_0, 0x7bf, A_0.vmethod_1());
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_21(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x7c0:
            case 0x7c1:
            case 0x7c2:
            case 0x7c3:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (float) num);
                return;

            case 0x7c4:
            case 0x7c5:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_22(int A_0)
    {
    }

    internal void method_23(ShapeBase A_0, Class657 A_1, Class657 A_2, bool A_3)
    {
        this.shapeBase_0 = A_0;
        this.class657_0 = A_1;
        this.class657_1 = A_2;
        this.int_0 = 0;
        this.int_1 = 0;
        this.int_2 = 0;
        this.int_3 = 0;
        this.int_4 = 0;
        this.int_5 = 0;
        this.int_6 = 0;
        this.int_7 = 0;
        this.int_8 = 0;
        this.int_9 = 0;
        this.int_10 = 0;
        this.int_11 = 0;
        this.int_12 = 0;
        this.int_13 = 0;
        this.int_14 = 0;
        this.int_15 = 0;
        this.int_16 = 0;
        this.int_17 = 0;
        this.int_18 = 0;
        this.int_19 = 0;
        if (A_3)
        {
            this.int_14 = smethod_5(this.int_14, Class351.smethod_0(0x33f), true);
        }
        Class43 shapePr = A_0.ShapePr;
        for (int i = 0; i < shapePr.Count; i++)
        {
            int num = shapePr.method_18(i);
            object obj2 = shapePr.method_19(i);
            int num2 = num & -64;
            if (num2 <= 640)
            {
                if (num2 <= 0x100)
                {
                    if (num2 <= 0x40)
                    {
                        if (num2 != 0)
                        {
                            if (num2 != 0x40)
                            {
                                goto Label_02D4;
                            }
                            this.method_25(num, obj2);
                        }
                        else
                        {
                            this.method_24(num, obj2);
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 0x80:
                            {
                                this.method_26(num, obj2);
                                continue;
                            }
                            case 0xc0:
                            {
                                this.method_27(num, obj2);
                                continue;
                            }
                        }
                        if (num2 != 0x100)
                        {
                            goto Label_02D4;
                        }
                        this.method_28(num, obj2);
                    }
                }
                else if (num2 <= 0x1c0)
                {
                    switch (num2)
                    {
                        case 320:
                        {
                            this.method_29(num, obj2);
                            continue;
                        }
                        case 0x180:
                        {
                            this.method_30(num, obj2);
                            continue;
                        }
                    }
                    if (num2 != 0x1c0)
                    {
                        goto Label_02D4;
                    }
                    this.method_31(num, obj2);
                }
                else
                {
                    switch (num2)
                    {
                        case 0x200:
                        {
                            this.method_32(num, obj2);
                            continue;
                        }
                        case 0x240:
                        {
                            this.method_33(num, obj2);
                            continue;
                        }
                    }
                    if (num2 != 640)
                    {
                        goto Label_02D4;
                    }
                    this.method_34(num, obj2);
                }
                continue;
            }
            if (num2 <= 0x400)
            {
                if (num2 <= 0x300)
                {
                    if (num2 != 0x2c0)
                    {
                        if (num2 != 0x300)
                        {
                            goto Label_02D4;
                        }
                        this.method_36(num, obj2);
                    }
                    else
                    {
                        this.method_35(num, obj2);
                    }
                }
                else if (num2 != 0x340)
                {
                    if (num2 != 0x380)
                    {
                        if (num2 != 0x400)
                        {
                            goto Label_02D4;
                        }
                        this.method_39(num, obj2);
                    }
                    else
                    {
                        this.method_38(num, obj2);
                    }
                }
                else
                {
                    this.method_37(num, obj2);
                }
                continue;
            }
            if (num2 <= 0x700)
            {
                if (num2 == 0x500)
                {
                    this.method_40(num, obj2);
                }
                else if (num2 != 0x6c0)
                {
                    if (num2 != 0x700)
                    {
                        goto Label_02D4;
                    }
                    this.method_45(num, obj2);
                }
                else
                {
                    this.method_41(num, obj2);
                }
                continue;
            }
            switch (num2)
            {
                case 0x780:
                {
                    this.method_46(num, obj2);
                    continue;
                }
                case 0x7c0:
                {
                    this.method_42(num, obj2);
                    continue;
                }
                case 0x1000:
                {
                    this.method_43(num, obj2);
                    continue;
                }
            }
        Label_02D4:
            this.method_22(num);
        }
        smethod_4(A_1, 0x7f, this.int_0);
        smethod_4(A_1, 0xbf, this.int_1);
        smethod_4(A_1, 0xff, this.int_2);
        smethod_4(A_1, 0x17f, this.int_3);
        smethod_4(A_1, 0x13f, this.int_4);
        smethod_4(A_2, 0x13f, this.int_5);
        smethod_4(A_1, 0x1bf, this.int_6);
        smethod_4(A_2, 0x1bf, this.int_7);
        smethod_4(A_1, 0x1ff, this.int_8);
        smethod_4(A_2, 0x1ff, this.int_9);
        smethod_4(A_1, 0x23f, this.int_10);
        smethod_4(A_1, 0x27f, this.int_11);
        smethod_4(A_1, 0x2bf, this.int_12);
        smethod_4(A_1, 0x2ff, this.int_13);
        smethod_4(A_1, 0x33f, this.int_14);
        smethod_4(A_1, 0x37f, this.int_15);
        smethod_4(A_1, 0x3bf, this.int_16);
        smethod_4(A_2, 0x3bf, this.int_17);
        smethod_4(A_2, 0x53f, this.int_18);
        smethod_4(A_1, 0x7bf, this.int_19);
        smethod_2(A_0, A_1);
    }

    private void method_24(int A_0, object A_1)
    {
        if (A_0 == 4)
        {
            this.class657_0.method_24(A_0, (int) A_1);
        }
        else
        {
            this.method_22(A_0);
        }
    }

    private void method_25(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x77:
            case 120:
            case 0x79:
            case 0x7a:
            case 0x7b:
            case 0x7c:
            case 0x7d:
            case 0x7e:
            case 0x7f:
                this.int_0 = smethod_5(this.int_0, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_26(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x80:
            case 0x81:
            case 130:
            case 0x83:
            case 0x84:
            case 0x86:
            case 0x8a:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x85:
                this.class657_0.method_24(A_0, (int) ((TextBoxWrapMode) A_1));
                return;

            case 0x87:
                this.class657_0.method_24(A_0, (int) ((TextBoxAnchor) A_1));
                return;

            case 0x88:
                this.class657_0.method_24(A_0, (int) ((LayoutFlow) A_1));
                return;

            case 0x89:
                this.class657_0.method_24(A_0, (int) ((TextRotation) A_1));
                return;

            case 0x8b:
            case 140:
            case 0x8d:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0xbb:
            case 0xbc:
            case 0xbd:
            case 190:
            case 0xbf:
                this.int_1 = smethod_5(this.int_1, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_27(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0xc0:
            case 0xc1:
            case 0xc5:
                this.class657_0.method_25(A_0, (string) A_1);
                return;

            case 0xc2:
                this.class657_0.method_24(A_0, (int) ((TextPathAlignment) A_1));
                return;

            case 0xc3:
            case 0xc4:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 240:
            case 0xf1:
            case 0xf2:
            case 0xf3:
            case 0xf4:
            case 0xf5:
            case 0xf6:
            case 0xf7:
            case 0xf8:
            case 0xf9:
            case 250:
            case 0xfb:
            case 0xfc:
            case 0xfd:
            case 0xfe:
            case 0xff:
                this.int_2 = smethod_5(this.int_2, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_28(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x100:
            case 0x101:
            case 0x102:
            case 0x103:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 260:
            case 0x105:
                this.shapeBase_0.SetShapeAttr(A_0, A_1);
                return;

            case 0x107:
                this.class657_0.method_24(A_0, Class624.smethod_6((Color) A_1));
                return;

            case 0x108:
            case 0x109:
            case 0x10a:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x10b:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x10c:
            case 0x10d:
            case 270:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x11a:
            case 0x11b:
            case 0x11d:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x139:
                this.int_5 = smethod_5(this.int_5, Class351.smethod_0(A_0), (bool) A_1);
                return;

            case 0x13c:
            case 0x13d:
            case 0x13e:
            case 0x13f:
                this.int_4 = smethod_5(this.int_4, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_29(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x145:
            {
                this.class657_0.method_24(0x144, 4);
                Class173 class4 = new Class173(A_0, (Class891[]) A_1);
                this.class657_0.method_23(class4);
                return;
            }
            case 0x146:
            {
                Class173 class7 = new Class173(A_0, (Class679[]) A_1);
                this.class657_0.method_23(class7);
                return;
            }
            case 0x147:
            case 0x148:
            case 0x149:
            case 330:
            case 0x14b:
            case 0x14c:
            case 0x14d:
            case 0x14e:
            case 0x14f:
            case 0x150:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x151:
            {
                Class173 class6 = new Class173(A_0, (Class891[]) A_1);
                this.class657_0.method_23(class6);
                return;
            }
            case 0x152:
            {
                Class173 class3 = new Class173(A_0, (int[]) A_1);
                this.class657_0.method_23(class3);
                return;
            }
            case 0x153:
            case 340:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x155:
            {
                Class173 class5 = new Class173(A_0, (Class784[]) A_1);
                this.class657_0.method_23(class5);
                return;
            }
            case 0x156:
            {
                Class173 class2 = new Class173(A_0, (Class456[]) A_1);
                this.class657_0.method_23(class2);
                return;
            }
            case 0x157:
            {
                Class173 class8 = new Class173(A_0, (Class70[]) A_1);
                this.class657_0.method_23(class8);
                return;
            }
            case 0x158:
                this.class657_0.method_24(A_0, (int) ((ConnectionPointType) A_1));
                return;

            case 0x17a:
            case 0x17b:
            case 380:
            case 0x17d:
            case 0x17e:
            case 0x17f:
                this.int_3 = smethod_5(this.int_3, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_3(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x80:
                break;

            case 0x81:
            case 130:
            case 0x83:
            case 0x84:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x85:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (TextBoxWrapMode) num);
                return;

            case 0x86:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x87:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (TextBoxAnchor) num);
                return;

            case 0x88:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (LayoutFlow) num);
                return;

            case 0x89:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (TextRotation) num);
                return;

            case 0x8a:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x8b:
            case 140:
            case 0x8d:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0xbf:
                smethod_1(this.shapeBase_0, 0xbb, num);
                smethod_1(this.shapeBase_0, 0xbc, num);
                smethod_1(this.shapeBase_0, 0xbd, num);
                smethod_1(this.shapeBase_0, 190, num);
                smethod_1(this.shapeBase_0, 0xbf, num);
                return;

            default:
                this.method_22(A_0.method_0());
                break;
        }
    }

    private void method_30(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x180:
                this.class657_0.method_24(A_0, (int) ((FillType) A_1));
                return;

            case 0x181:
            case 0x183:
                this.class657_0.method_24(A_0, Class624.smethod_6((Color) A_1));
                return;

            case 0x182:
            case 0x184:
            case 0x185:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x187:
                this.class657_0.method_25(A_0, (string) A_1);
                return;

            case 0x188:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x189:
            case 0x18a:
            case 0x18b:
            case 0x18c:
            case 0x18d:
            case 0x18e:
            case 0x18f:
            case 400:
            case 0x191:
            case 0x192:
            case 0x193:
            case 0x194:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x195:
                this.class657_0.method_24(A_0, (int) ((FillDimensionType) A_1));
                return;

            case 0x197:
            {
                Class173 class2 = new Class173(A_0, (Class954[]) A_1);
                this.class657_0.method_23(class2);
                return;
            }
            case 0x198:
            case 0x199:
            case 410:
            case 0x19b:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x19c:
                this.class657_0.method_24(A_0, (int) ((GradientType) A_1));
                return;

            case 0x19e:
            case 0x19f:
            case 0x1a0:
            case 0x1a2:
            case 0x1a3:
            case 420:
            case 0x1a5:
            case 0x1a6:
            case 0x1a7:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x1a1:
                return;

            case 0x1b9:
            case 0x1ba:
                this.int_7 = smethod_5(this.int_7, Class351.smethod_0(A_0), (bool) A_1);
                return;

            case 0x1bb:
            case 0x1bc:
            case 0x1bd:
            case 0x1be:
            case 0x1bf:
                this.int_6 = smethod_5(this.int_6, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_31(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x1c0:
            case 450:
                this.class657_0.method_24(A_0, Class624.smethod_6((Color) A_1));
                return;

            case 0x1c1:
            case 0x1c3:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x1c4:
                this.class657_0.method_24(A_0, (int) ((LineFillType) A_1));
                return;

            case 0x1c6:
                this.class657_0.method_25(A_0, (string) A_1);
                return;

            case 0x1c7:
            case 0x1c8:
            case 0x1c9:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x1ca:
                this.class657_0.method_24(A_0, (int) ((FillDimensionType) A_1));
                return;

            case 0x1cb:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 460:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x1cd:
                this.class657_0.method_24(A_0, (int) ((ShapeLineStyle) A_1));
                return;

            case 0x1ce:
                this.class657_0.method_24(A_0, (int) ((LineDashing) A_1));
                return;

            case 0x1d0:
            case 0x1d1:
                this.class657_0.method_24(A_0, (int) ((ArrowType) A_1));
                return;

            case 0x1d2:
            case 0x1d4:
                this.class657_0.method_24(A_0, (int) ((StrokeArrowWidth) A_1));
                return;

            case 0x1d3:
            case 0x1d5:
                this.class657_0.method_24(A_0, (int) ((StrokeArrowLength) A_1));
                return;

            case 470:
                this.class657_0.method_24(A_0, (int) ((LineJoin) A_1));
                return;

            case 0x1d7:
                this.class657_0.method_24(A_0, (int) ((LineCap) A_1));
                return;

            case 0x1d9:
            case 0x1da:
            case 0x1db:
            case 0x1dc:
            case 0x1dd:
            case 0x1de:
            case 0x1df:
            case 0x1e1:
            case 0x1e2:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x1f7:
            case 0x1f8:
                this.int_9 = smethod_5(this.int_9, Class351.smethod_0(A_0), (bool) A_1);
                return;

            case 0x1f9:
            case 0x1fa:
            case 0x1fb:
            case 0x1fc:
            case 0x1fd:
            case 510:
            case 0x1ff:
                this.int_8 = smethod_5(this.int_8, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_32(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x200:
                this.class657_0.method_24(A_0, (int) ((ShadowType) A_1));
                return;

            case 0x201:
            case 0x202:
                this.class657_0.method_24(A_0, Class624.smethod_6((Color) A_1));
                return;

            case 0x203:
            case 0x204:
            case 0x205:
            case 0x206:
            case 0x207:
            case 520:
            case 0x209:
            case 0x20a:
            case 0x20b:
            case 0x20c:
            case 0x20d:
            case 0x20e:
            case 0x20f:
            case 0x210:
            case 0x211:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 530:
            case 0x213:
            case 0x214:
            case 0x216:
            case 0x217:
            case 0x218:
            case 0x21a:
            case 0x21b:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x23e:
            case 0x23f:
                this.int_10 = smethod_5(this.int_10, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_33(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x240:
                this.class657_0.method_24(A_0, (int) ((PerspectiveType) A_1));
                return;

            case 0x241:
            case 0x242:
            case 0x243:
            case 580:
            case 0x245:
            case 0x246:
            case 0x247:
            case 0x248:
            case 0x249:
            case 0x24a:
            case 0x24b:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x27f:
                this.int_11 = smethod_5(this.int_11, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_34(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 640:
            case 0x281:
            case 0x282:
            case 0x283:
            case 0x284:
            case 0x285:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x286:
                this.class657_0.method_24(A_0, (int) ((PlaneType) A_1));
                return;

            case 0x287:
                this.class657_0.method_24(A_0, Class624.smethod_6((Color) A_1));
                return;

            case 0x288:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x289:
            case 650:
            case 0x28b:
            case 0x28d:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 700:
            case 0x2bd:
            case 0x2be:
            case 0x2bf:
                this.int_12 = smethod_5(this.int_12, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_35(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x2c0:
            case 0x2c1:
            case 0x2c2:
            case 0x2c3:
            case 0x2c4:
            case 0x2c5:
            case 710:
            case 0x2c7:
            case 0x2c8:
            case 0x2ca:
            case 0x2cb:
            case 0x2cc:
            case 0x2cd:
            case 0x2ce:
            case 0x2cf:
            case 720:
            case 0x2d1:
            case 0x2d2:
            case 0x2d3:
            case 0x2d4:
            case 0x2d5:
            case 0x2d6:
            case 0x2d7:
            case 0x2d8:
            case 0x2d9:
            case 730:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x2c9:
                this.class657_0.method_24(A_0, (int) ((ThreeDRenderMode) A_1));
                return;

            case 0x2fb:
            case 0x2fc:
            case 0x2fd:
            case 0x2fe:
            case 0x2ff:
                this.int_13 = smethod_5(this.int_13, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_36(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x303:
                this.class657_0.method_24(A_0, (int) ((ConnectorType) A_1));
                return;

            case 0x304:
            case 0x305:
            case 0x306:
                this.class657_0.method_24(A_0, (int) ((BWMode) A_1));
                return;

            case 0x309:
                this.class657_1.method_24(A_0, (int) ((DiagramNodeLayout) A_1));
                return;

            case 0x30a:
                this.class657_1.method_24(A_0, (int) ((DiagramNodeKind) A_1));
                return;

            case 0x30b:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 780:
                this.class657_0.method_23(new Class174(780, (byte[]) A_1));
                return;

            case 0x33a:
            case 0x33b:
            case 0x33c:
            case 830:
                this.int_14 = smethod_5(this.int_14, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_37(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x340:
                this.class657_0.method_24(A_0, (int) ((CalloutType) A_1));
                return;

            case 0x341:
            case 0x344:
            case 0x345:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 0x342:
                this.class657_0.method_24(A_0, (int) ((CalloutAngle) A_1));
                return;

            case 0x343:
                this.class657_0.method_24(A_0, (int) ((CalloutDropType) A_1));
                return;

            case 0x379:
            case 890:
            case 0x37b:
            case 0x37c:
            case 0x37d:
            case 0x37e:
            case 0x37f:
                this.int_15 = smethod_5(this.int_15, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_38(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x380:
            case 0x381:
            case 0x38d:
            {
                string str2 = (string) A_1;
                if (Class567.smethod_16(str2))
                {
                    this.class657_0.method_25(A_0, str2);
                }
                return;
            }
            case 0x382:
                if (Class567.smethod_16(this.shapeBase_0.HRef))
                {
                    Class177 class2 = new Class177(A_0, this.shapeBase_0.HyperlinkAddress, this.shapeBase_0.HyperlinkSubAddress, this.shapeBase_0.Target);
                    this.class657_0.method_23(class2);
                }
                return;

            case 0x383:
            {
                Class173 class3 = new Class173(A_0, (Class891[]) A_1);
                this.class657_0.method_23(class3);
                return;
            }
            case 900:
            case 0x385:
            case 0x386:
            case 0x387:
                this.class657_0.method_24(A_0, (int) A_1);
                return;

            case 910:
            case 0x397:
            case 0x39a:
            {
                string str = (string) A_1;
                if (Class567.smethod_16(str))
                {
                    this.class657_1.method_25(A_0, str);
                }
                return;
            }
            case 0x38f:
                this.class657_1.method_24(A_0, (int) ((ShapeHorizontalAlignment) A_1));
                return;

            case 0x390:
                this.class657_1.method_24(A_0, (int) ((RelativeHorizontalPosition) A_1));
                return;

            case 0x391:
            {
                ShapeVerticalAlignment top = (ShapeVerticalAlignment) A_1;
                if (top == ShapeVerticalAlignment.Inline)
                {
                    top = ShapeVerticalAlignment.Top;
                }
                this.class657_1.method_24(A_0, (int) top);
                return;
            }
            case 0x392:
                this.class657_1.method_24(A_0, (int) ((RelativeVerticalPosition) A_1));
                return;

            case 0x393:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x394:
                switch (((ShapeHorizontalAlignment) A_1))
                {
                    case ShapeHorizontalAlignment.Center:
                        this.class657_1.method_24(A_0, 1);
                        return;

                    case ShapeHorizontalAlignment.Right:
                        this.class657_1.method_24(A_0, 2);
                        return;
                }
                return;

            case 920:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x39b:
            case 0x39c:
            case 0x39d:
            case 0x39e:
                return;

            case 0x3b0:
            case 0x3b1:
            case 0x3b2:
            case 0x3b3:
            case 950:
            case 0x3b7:
            case 0x3b8:
                this.int_17 = smethod_5(this.int_17, Class351.smethod_0(A_0), (bool) A_1);
                return;

            case 0x3b4:
            {
                bool flag = (bool) A_1;
                this.int_17 = smethod_5(this.int_17, Class351.smethod_0(A_0), flag);
                if (flag)
                {
                    this.class657_1.method_24(0x395, Class969.smethod_31(this.shapeBase_0.Height));
                    this.class657_1.method_24(0x396, Class969.smethod_31(this.shapeBase_0.Width));
                }
                return;
            }
            case 0x3b9:
            case 0x3bb:
            case 0x3bc:
            case 0x3bd:
            case 0x3be:
            case 0x3bf:
                this.int_16 = smethod_5(this.int_16, Class351.smethod_0(A_0), (bool) A_1);
                return;

            case 0x3ba:
                if (!this.shapeBase_0.IsInline)
                {
                    this.int_16 = smethod_5(this.int_16, Class351.smethod_0(A_0), (bool) A_1);
                    return;
                }
                return;
        }
        this.method_22(A_0);
    }

    private void method_39(int A_0, object A_1)
    {
        if (A_0 == 0x43f)
        {
            this.class657_1.method_24(A_0, (int) A_1);
        }
        else
        {
            this.method_22(A_0);
        }
    }

    private void method_4(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0xc0:
            case 0xc1:
            case 0xc5:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), ((Class175) A_0).method_3());
                return;

            case 0xc2:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (TextPathAlignment) num);
                return;

            case 0xc3:
            case 0xc4:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0xff:
                smethod_1(this.shapeBase_0, 240, num);
                smethod_1(this.shapeBase_0, 0xf1, num);
                smethod_1(this.shapeBase_0, 0xf2, num);
                smethod_1(this.shapeBase_0, 0xf3, num);
                smethod_1(this.shapeBase_0, 0xf4, num);
                smethod_1(this.shapeBase_0, 0xf5, num);
                smethod_1(this.shapeBase_0, 0xf6, num);
                smethod_1(this.shapeBase_0, 0xf7, num);
                smethod_1(this.shapeBase_0, 0xf8, num);
                smethod_1(this.shapeBase_0, 0xf9, num);
                smethod_1(this.shapeBase_0, 250, num);
                smethod_1(this.shapeBase_0, 0xfb, num);
                smethod_1(this.shapeBase_0, 0xfc, num);
                smethod_1(this.shapeBase_0, 0xfd, num);
                smethod_1(this.shapeBase_0, 0xfe, num);
                smethod_1(this.shapeBase_0, 0xff, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_40(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x500:
            {
                EditAs as2 = (EditAs) A_1;
                if (as2 != EditAs.Group)
                {
                    this.class657_1.method_24(A_0, (int) as2);
                }
                return;
            }
            case 0x501:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x504:
            {
                Class173 class3 = new Class173(A_0, (Class782[]) A_1);
                this.class657_1.method_23(class3);
                return;
            }
            case 0x505:
            case 0x506:
            case 0x507:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x508:
            {
                Class173 class2 = new Class173(A_0, (int[]) A_1);
                this.class657_1.method_23(class2);
                return;
            }
            case 0x509:
                this.class657_1.method_24(A_0, (int) A_1);
                return;

            case 0x53c:
            case 0x53d:
            case 0x53e:
                this.int_18 = smethod_5(this.int_18, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_41(int A_0, object A_1)
    {
        if (A_0 == 0x6ff)
        {
            this.class657_1.method_24(A_0, (int) A_1);
        }
        else
        {
            this.method_22(A_0);
        }
    }

    private void method_42(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x7c0:
            case 0x7c1:
            case 0x7c2:
            case 0x7c3:
                this.class657_1.method_24(A_0, (int) ((float) A_1));
                return;

            case 0x7c4:
            case 0x7c5:
                this.class657_1.method_24(A_0, (int) A_1);
                return;
        }
        this.method_22(A_0);
    }

    private void method_43(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x7c0:
            case 0x7c1:
            case 0x7c2:
            case 0x7c3:
            case 0x7c4:
            case 0x7c5:
            case 0x1000:
            case 0x1002:
            case 0x1003:
            case 0x1010:
            case 0x1011:
            case 0x1012:
            case 0x1013:
            case 0x1014:
            case 0x1015:
            case 0x1016:
            case 0x1017:
            case 0x1018:
            case 0x1019:
            case 0x101a:
            case 0x101c:
            case 0x1021:
            case 0x1022:
            case 0x1023:
            case 0x1024:
            case 0x102c:
            case 0x102d:
            case 0x102e:
            case 0x102f:
            case 0x1030:
            case 0x1031:
            case 0x1032:
            case 0x103a:
            case 0x103b:
                return;

            case 0x1001:
                if (this.shapeBase_0.IsPseudoInline)
                {
                    this.int_18 = smethod_5(this.int_18, 1, true);
                }
                return;

            case 0x1006:
            {
                int num5 = this.method_48((byte[]) A_1, PresetTexture.Custom);
                this.class657_0.method_24(260, num5);
                return;
            }
            case 0x1007:
            {
                string str = (string) A_1;
                if (Class567.smethod_16(str))
                {
                    ShapeObject obj2 = (ShapeObject) this.shapeBase_0;
                    if (obj2.ImageData.IsLink)
                    {
                        return;
                    }
                    this.class657_0.method_25(0x105, (string) A_1);
                }
                return;
            }
            case 0x1008:
            {
                string str2 = (string) A_1;
                if (Class567.smethod_16(str2))
                {
                    this.class657_0.method_25(0x105, str2);
                    int num2 = 2;
                    ShapeObject obj3 = (ShapeObject) this.shapeBase_0;
                    if (obj3.ImageData.IsLink)
                    {
                        num2 |= 8;
                    }
                    if (obj3.ImageData.IsLink && !obj3.HasImageBytes)
                    {
                        num2 |= 4;
                    }
                    this.class657_0.method_24(0x106, num2);
                }
                return;
            }
            case 0x100a:
            {
                Class1031 class4 = (A_1 is Class1031) ? ((Class1031) A_1) : this.method_44(A_1);
                smethod_3(this.class657_1, 0x39b, class4);
                return;
            }
            case 0x100b:
            {
                Class1031 class3 = (A_1 is Class1031) ? ((Class1031) A_1) : this.method_44(A_1);
                smethod_3(this.class657_1, 0x39c, class3);
                return;
            }
            case 0x100c:
            {
                Class1031 class2 = (A_1 is Class1031) ? ((Class1031) A_1) : this.method_44(A_1);
                smethod_3(this.class657_1, 0x39d, class2);
                return;
            }
            case 0x100d:
            {
                Class1031 class5 = (A_1 is Class1031) ? ((Class1031) A_1) : this.method_44(A_1);
                smethod_3(this.class657_1, 0x39e, class5);
                return;
            }
            case 0x100e:
            {
                PresetTexture texture = (PresetTexture) this.shapeBase_0.ShapePr.method_32(0x1019);
                int num3 = this.method_48((byte[]) A_1, texture);
                this.class657_0.method_24(0x1c5, num3);
                return;
            }
            case 0x100f:
            {
                PresetTexture texture2 = (PresetTexture) this.shapeBase_0.ShapePr.method_32(0x101a);
                int num4 = this.method_48((byte[]) A_1, texture2);
                if (num4 >= 0)
                {
                    this.class657_0.method_24(390, num4);
                }
                return;
            }
            case 0x101d:
                if (!this.shapeBase_0.IsGroup)
                {
                    this.class657_0.method_24(320, (int) A_1);
                }
                return;

            case 0x101e:
                if (!this.shapeBase_0.IsGroup)
                {
                    this.class657_0.method_24(0x141, (int) A_1);
                }
                return;

            case 0x101f:
                if (!this.shapeBase_0.IsGroup)
                {
                    this.class657_0.method_24(0x142, this.shapeBase_0.CoordOriginX + ((int) A_1));
                }
                return;

            case 0x1020:
                if (!this.shapeBase_0.IsGroup)
                {
                    this.class657_0.method_24(0x143, this.shapeBase_0.CoordOriginY + ((int) A_1));
                }
                return;
        }
        this.method_22(A_0);
    }

    internal Class1031 method_44(object A_0)
    {
        Border border = (Border) A_0;
        Class1031 class2 = new Class1031();
        class2.method_2(border.BorderType);
        class2.method_4((double) border.LineWidth);
        class2.method_13(border.Color);
        class2.method_29((int) border.Space);
        class2.method_17(border.Shadow);
        class2.method_23(border.ShadeTheme);
        return class2;
    }

    private void method_45(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x700:
            {
                this.class657_0.method_23(new Class176(0x700, (byte[]) A_1));
                EscherInkFlags flags = EscherInkFlags.UseInkAnnotation | EscherInkFlags.UseRenderInk | EscherInkFlags.RenderInk;
                if (this.shapeBase_0.InkAnnotation)
                {
                    flags |= EscherInkFlags.InkAnnotation;
                }
                this.class657_0.method_24(0x73f, (int) flags);
                break;
            }
        }
    }

    private void method_46(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x781:
            case 0x782:
            case 0x783:
            case 0x784:
            case 0x785:
            case 0x786:
            case 0x787:
            case 0x788:
                this.class657_0.method_25(A_0, (string) A_1);
                return;

            case 0x7bc:
            case 0x7bd:
            case 0x7be:
            case 0x7bf:
                this.int_19 = smethod_5(this.int_19, Class351.smethod_0(A_0), (bool) A_1);
                return;
        }
    }

    private Class269 method_47(int A_0)
    {
        if (this.class658_0.interface36_0 != null)
        {
            Class268 class2 = this.class658_0.interface36_0.imethod_0(A_0);
            if (class2 != null)
            {
                return class2.method_8();
            }
        }
        return null;
    }

    private int method_48(byte[] A_0, PresetTexture A_1)
    {
        Class269 class3;
        int num2;
        int num = 11;
        if (A_0 == null)
        {
            return -1;
        }
        Guid guid = Class968.smethod_0(A_0);
        object obj2 = this.hashtable_0[guid];
        if (!this.shapeBase_0.IsInline && (obj2 != null))
        {
            int num3 = (int) obj2;
            Class268 class1 = this.class658_0.interface36_0.imethod_0(num3);
            class1.int_5++;
            return num3;
        }
        ImageFormat png = Class409.smethod_0(A_0);
        if (!Class409.smethod_1(png))
        {
            if (png == ImageFormat.Gif)
            {
                using (Class958 class4 = new Class958())
                {
                    class4.method_9(new MemoryStream(A_0));
                    using (Image image = class4.method_2())
                    {
                        using (MemoryStream stream = new MemoryStream())
                        {
                            image.Save(stream, ImageFormat.Png);
                            A_0 = Class567.smethod_10(stream);
                        }
                    }
                    png = ImageFormat.Png;
                    goto Label_0136;
                }
            }
            try
            {
                using (Bitmap bitmap = new Bitmap(new MemoryStream(A_0)))
                {
                    using (MemoryStream stream2 = new MemoryStream())
                    {
                        bitmap.Save(stream2, ImageFormat.Png);
                        A_0 = Class567.smethod_10(stream2);
                        png = ImageFormat.Png;
                    }
                }
            }
            catch
            {
            }
        }
    Label_0136:
        switch (png)
        {
            case ImageFormat.Bmp:
            case ImageFormat.Gif:
            case ImageFormat.Jpeg:
            case ImageFormat.Png:
                class3 = new Class270(guid, A_0, A_1);
                break;

            case ImageFormat.Emf:
            case ImageFormat.Wmf:
                class3 = new Class271(guid, A_0);
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("缰尲䄴᜶尸䌺䴼娾≀㝂⁄⍆楈⑊㥌❎㑐⅒畔㹖㑘㩚㩜㩞䅠բ੤ᕦѨ੪ᥬᱮ兰᭲ၴնᱸ啺", num));
        }
        Class268 class2 = new Class268();
        class2.method_3().method_7((int) class3.method_5());
        class2.int_1 = (class3.method_5() != BlipImageType.Pict) ? ((int) class3.method_5()) : 3;
        class2.int_2 = (int) class3.method_5();
        class2.byte_1 = class3.method_4().ToByteArray();
        class2.int_3 = 0xff;
        class2.int_5 = 1;
        class2.method_7(this.class658_0.interface36_0 is Class350);
        class2.method_9(class3);
        if (this.hashtable_0[guid] != null)
        {
            num2 = (int) this.hashtable_0[guid];
            this.class658_0.interface36_0.imethod_1(class2);
            return num2;
        }
        num2 = this.class658_0.interface36_0.imethod_1(class2);
        this.hashtable_0.Add(guid, num2);
        return num2;
    }

    private void method_5(Class171 A_0)
    {
        string str;
        int num3;
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x100:
            case 0x101:
            case 0x102:
            case 0x103:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 260:
            {
                Class269 class2 = this.method_47(num);
                byte[] buffer = (class2 != null) ? class2.vmethod_2() : Class567.smethod_14();
                ((ShapeObject) this.shapeBase_0).SetShapeAttribute(0x1006, buffer);
                return;
            }
            case 0x105:
            {
                str = ((Class175) A_0).method_3();
                Class179 class4 = (Class179) this.class657_0.method_3(0x106);
                EscherBlipNameFlags flags = (class4 != null) ? ((EscherBlipNameFlags) class4.vmethod_1()) : EscherBlipNameFlags.Comment;
                if ((flags & EscherBlipNameFlags.LinkToFile) == EscherBlipNameFlags.Comment)
                {
                    num3 = 0x1007;
                    break;
                }
                if (!smethod_0(str))
                {
                    num3 = 0x381;
                    break;
                }
                num3 = 0x1008;
                break;
            }
            case 0x106:
            case 0x10b:
            case 0x11c:
            case 0x11e:
            case 0x11f:
                return;

            case 0x107:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), Class624.smethod_7(num));
                return;

            case 0x108:
            case 0x109:
            case 0x10a:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x10c:
            case 0x10d:
            case 270:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x11a:
            case 0x11b:
            case 0x11d:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x13f:
                smethod_1(this.shapeBase_0, 0x13c, num);
                smethod_1(this.shapeBase_0, 0x13d, num);
                smethod_1(this.shapeBase_0, 0x13e, num);
                smethod_1(this.shapeBase_0, 0x13f, num);
                smethod_1(this.shapeBase_0, 0x139, num);
                return;

            default:
                this.method_22(A_0.method_0());
                return;
        }
        this.shapeBase_0.SetShapeAttr(num3, str);
    }

    private void method_6(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 320:
                if (this.shapeBase_0.IsGroup)
                {
                    break;
                }
                this.shapeBase_0.CoordOriginX = num;
                return;

            case 0x141:
                if (this.shapeBase_0.IsGroup)
                {
                    break;
                }
                this.shapeBase_0.CoordOriginY = num;
                return;

            case 0x142:
                if (this.shapeBase_0.IsGroup)
                {
                    break;
                }
                this.shapeBase_0.method_57(num - this.shapeBase_0.CoordOriginX);
                return;

            case 0x143:
                if (this.shapeBase_0.IsGroup)
                {
                    break;
                }
                this.shapeBase_0.method_58(num - this.shapeBase_0.CoordOriginY);
                return;

            case 0x144:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (EscherShapePath) num);
                return;

            case 0x145:
            {
                Class891[] classArray2 = ((Class173) A_0).method_5();
                if (classArray2 == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray2);
                return;
            }
            case 0x146:
            {
                Class679[] classArray5 = ((Class173) A_0).method_9();
                if (classArray5 == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray5);
                return;
            }
            case 0x147:
            case 0x148:
            case 0x149:
            case 330:
            case 0x14b:
            case 0x14c:
            case 0x14d:
            case 0x14e:
            case 0x14f:
            case 0x150:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x151:
            {
                Class891[] classArray = ((Class173) A_0).method_5();
                if (classArray == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray);
                return;
            }
            case 0x152:
            {
                int[] numArray = ((Class173) A_0).method_10();
                if (numArray == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), numArray);
                return;
            }
            case 0x153:
            case 340:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x155:
            {
                Class784[] classArray6 = ((Class173) A_0).method_6();
                if (classArray6 == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray6);
                return;
            }
            case 0x156:
            {
                Class456[] classArray4 = ((Class173) A_0).method_8();
                if (classArray4 == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray4);
                return;
            }
            case 0x157:
            {
                Class70[] classArray3 = ((Class173) A_0).method_7();
                if (classArray3 == null)
                {
                    break;
                }
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray3);
                return;
            }
            case 0x158:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ConnectionPointType) num);
                return;

            case 0x179:
                break;

            case 0x17f:
                smethod_1(this.shapeBase_0, 0x17a, num);
                smethod_1(this.shapeBase_0, 0x17b, num);
                smethod_1(this.shapeBase_0, 380, num);
                smethod_1(this.shapeBase_0, 0x17d, num);
                smethod_1(this.shapeBase_0, 0x17e, num);
                smethod_1(this.shapeBase_0, 0x17f, num);
                return;

            default:
                this.method_22(A_0.method_0());
                break;
        }
    }

    private void method_7(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x180:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (FillType) num);
                return;

            case 0x181:
            case 0x183:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), Class624.smethod_7(num));
                return;

            case 0x182:
            case 0x184:
            case 0x185:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 390:
            {
                Class269 class2 = this.method_47(num);
                if (class2 != null)
                {
                    this.shapeBase_0.SetShapeAttr(0x100f, class2.vmethod_2());
                    this.shapeBase_0.SetShapeAttr(0x101a, class2.vmethod_3());
                }
                return;
            }
            case 0x187:
                this.shapeBase_0.SetShapeAttr(0x187, ((Class175) A_0).method_3());
                return;

            case 0x188:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x189:
            case 0x18a:
            case 0x18b:
            case 0x18c:
            case 0x18d:
            case 0x18e:
            case 0x18f:
            case 400:
            case 0x191:
            case 0x192:
            case 0x193:
            case 0x194:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x195:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (FillDimensionType) num);
                return;

            case 0x196:
            case 0x1a1:
            case 0x1ba:
                return;

            case 0x197:
            {
                Class954[] classArray = ((Class173) A_0).method_3();
                if (classArray != null)
                {
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), classArray);
                }
                return;
            }
            case 0x198:
            case 0x199:
            case 410:
            case 0x19b:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x19c:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (GradientType) num);
                return;

            case 0x19e:
            case 0x19f:
            case 0x1a0:
            case 0x1a2:
            case 0x1a3:
            case 420:
            case 0x1a5:
            case 0x1a6:
            case 0x1a7:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x1bf:
                smethod_1(this.shapeBase_0, 0x1bb, num);
                smethod_1(this.shapeBase_0, 0x1bc, num);
                smethod_1(this.shapeBase_0, 0x1bd, num);
                smethod_1(this.shapeBase_0, 0x1be, num);
                smethod_1(this.shapeBase_0, 0x1bf, num);
                smethod_1(this.shapeBase_0, 0x1b9, num);
                smethod_1(this.shapeBase_0, 0x1ba, num);
                return;
        }
        this.method_22(A_0.method_0());
    }

    private void method_8(Class171 A_0, int A_1)
    {
        if (A_1 == 0x1c0)
        {
            int num = A_0.vmethod_1();
            switch (A_0.method_0())
            {
                case 0x1c0:
                case 450:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), Class624.smethod_7(num));
                    return;

                case 0x1c1:
                case 0x1c3:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                    return;

                case 0x1c4:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (LineFillType) num);
                    return;

                case 0x1c5:
                {
                    Class269 class2 = this.method_47(num);
                    if (class2 != null)
                    {
                        this.shapeBase_0.SetShapeAttr(0x100e, class2.vmethod_2());
                        this.shapeBase_0.SetShapeAttr(0x1019, class2.vmethod_3());
                    }
                    return;
                }
                case 0x1c6:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), ((Class175) A_0).method_3());
                    return;

                case 0x1c7:
                case 0x1c8:
                case 0x1c9:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                    return;

                case 0x1ca:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (FillDimensionType) num);
                    return;

                case 0x1cb:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                    return;

                case 460:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                    return;

                case 0x1cd:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ShapeLineStyle) num);
                    return;

                case 0x1ce:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (LineDashing) num);
                    return;

                case 0x1cf:
                case 480:
                case 0x1f8:
                case 0x1f9:
                    return;

                case 0x1d0:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ArrowType) num);
                    return;

                case 0x1d1:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ArrowType) num);
                    return;

                case 0x1d2:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (StrokeArrowWidth) num);
                    return;

                case 0x1d3:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (StrokeArrowLength) num);
                    return;

                case 0x1d4:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (StrokeArrowWidth) num);
                    return;

                case 0x1d5:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (StrokeArrowLength) num);
                    return;

                case 470:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (LineJoin) num);
                    return;

                case 0x1d7:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), (LineCap) num);
                    return;

                case 0x1d9:
                case 0x1da:
                case 0x1db:
                case 0x1dc:
                case 0x1dd:
                case 0x1de:
                case 0x1df:
                case 0x1e1:
                case 0x1e2:
                    this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                    return;

                case 0x1ff:
                    smethod_1(this.shapeBase_0, 0x1f9, num);
                    smethod_1(this.shapeBase_0, 0x1fa, num);
                    smethod_1(this.shapeBase_0, 0x1fb, num);
                    smethod_1(this.shapeBase_0, 0x1fc, num);
                    smethod_1(this.shapeBase_0, 0x1fd, num);
                    smethod_1(this.shapeBase_0, 510, num);
                    smethod_1(this.shapeBase_0, 0x1ff, num);
                    smethod_1(this.shapeBase_0, 0x1f7, num);
                    smethod_1(this.shapeBase_0, 0x1f8, num);
                    return;
            }
            this.method_22(A_0.method_0());
        }
    }

    private void method_9(Class171 A_0)
    {
        int num = A_0.vmethod_1();
        switch (A_0.method_0())
        {
            case 0x200:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), (ShadowType) num);
                return;

            case 0x201:
            case 0x202:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), Class624.smethod_7(num));
                return;

            case 0x203:
            case 0x204:
            case 0x205:
            case 0x206:
            case 0x207:
            case 520:
            case 0x209:
            case 0x20a:
            case 0x20b:
            case 0x20c:
            case 0x20d:
            case 0x20e:
            case 0x20f:
            case 0x210:
            case 0x211:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 530:
            case 0x213:
            case 0x214:
            case 0x216:
            case 0x217:
            case 0x218:
            case 0x21a:
            case 0x21b:
                this.shapeBase_0.SetShapeAttr(A_0.method_0(), num);
                return;

            case 0x215:
            case 0x219:
            case 540:
                break;

            case 0x23f:
                smethod_1(this.shapeBase_0, 0x23e, num);
                smethod_1(this.shapeBase_0, 0x23f, num);
                return;

            default:
                this.method_22(A_0.method_0());
                break;
        }
    }

    private static bool smethod_0(string A_0)
    {
        if (!Class736.smethod_6(A_0) && !Class736.smethod_8(A_0))
        {
            return Class736.smethod_5(A_0);
        }
        return true;
    }

    private static void smethod_1(ShapeBase A_0, int A_1, int A_2)
    {
        int num = Class351.smethod_0(A_1);
        int num2 = num << 0x10;
        if ((A_2 & num2) != 0)
        {
            bool flag = (A_2 & num) != 0;
            A_0.SetShapeAttr(A_1, flag);
        }
    }

    private static void smethod_2(ShapeBase A_0, Class657 A_1)
    {
        if ((A_0.ShapeType == ShapeType.CustomShape) && !A_0.ShapePr.HasKey(0x145))
        {
            Class173 class2 = new Class173(0x145, new Class891[0]);
            A_1.method_23(class2);
        }
    }

    private static void smethod_3(Class657 A_0, int A_1, Class1031 A_2)
    {
        if (!A_2.method_35(Class1031.class1031_0))
        {
            A_0.method_24(A_1, Class624.smethod_6(A_2.method_12()));
        }
    }

    private static void smethod_4(Class657 A_0, int A_1, int A_2)
    {
        if ((A_2 & 0xffff0000L) != 0L)
        {
            A_0.method_24(A_1, A_2);
        }
    }

    private static int smethod_5(int A_0, int A_1, bool A_2)
    {
        int num = Class336.smethod_5(A_0, A_1, A_2);
        int num2 = A_1 << 0x10;
        return (num | num2);
    }
}

