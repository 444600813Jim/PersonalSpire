using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class469
{
    private readonly Class422 class422_0;
    private Class87 class87_0;

    internal Class469(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0(ShapeBase A_0)
    {
        this.class87_0 = new Class87();
        this.method_2(A_0);
        this.method_1(A_0.IsInline);
    }

    internal void method_1(bool A_0)
    {
        int num = 2;
        if (this.class87_0.int_0 > 0)
        {
            Class400 class2 = this.class422_0.method_18();
            class2.method_4(BookmarkStart.b("嬧帩唫䈭唯࠱匳䐵夷䨹吻圽⌿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num));
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ弱唳䐵匷弹主ጽ㌿㙁╃㑅㱇杉㭋❍㑏♑㱓", num), this.class87_0.string_14);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ弱唳䐵匷弹主ጽ┿ⱁ⁃歅㽇⍉⡋㩍㡏", num), this.class87_0.string_15);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ弱唳䐵匷弹主ጽ㌿㙁╃㑅㱇", num), this.class87_0.string_16);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ弱唳䐵匷弹主ጽ┿ⱁ⁃", num), this.class87_0.string_17);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱䀳䐵圷儹夻", num), this.class87_0.string_18);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱䀳䐵圷儹夻ጽ␿⍁㝃⹅", num), this.class87_0.string_19);
            class2.method_40(BookmarkStart.b("嬧尩䬫ᐭ䌯䘱䘳夵匷弹ᄻ䤽⤿♁ぃ⹅", num), this.class87_0.string_21);
            class2.method_40(BookmarkStart.b("嬧尩䬫ᐭ䌯䘱䘳夵匷弹ᄻ崽⼿⹁⭃㑅", num), this.class87_0.string_20);
            class2.method_40(BookmarkStart.b("嬧尩䬫ᐭ䌯䘱䘳夵匷弹ᄻ儽〿⍁❃⽅㱇㍉", num), this.class87_0.string_22);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ吱崳娵吷", num), this.class87_0.bool_0 ? this.class87_0.string_28 : BookmarkStart.b("䘧䔩䈫䬭", num));
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ吱崳娵吷᜹嬻䰽ℿ♁ⵃ⍅♇㹉態⁍ㅏ㽑ㅓ", num), this.class87_0.string_29);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱尳圵尷唹䬻ጽ⌿ⵁ⡃⥅㩇", num), this.class87_0.string_23);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱尳圵尷唹䬻", num), this.class87_0.string_24);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱尳圵尷唹䬻ጽ⼿㉁╃╅ⅇ㹉㕋", num), this.class87_0.string_25);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱尳圵尷唹䬻ጽ⼿⑁≃㕅ⵇ㹉態㙍", num), this.class87_0.string_31);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱尳圵尷唹䬻ጽ⼿⑁≃㕅ⵇ㹉態㝍", num), this.class87_0.string_32);
            if (this.class87_0.string_28 != BookmarkStart.b("伧堩䴫䨭夯圱娳䈵", num))
            {
                class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ崱䐳圵嬷匹䠻䜽", num), this.class87_0.string_26);
                if (!this.class422_0.method_14().method_13())
                {
                    class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱嘳圵嬷儹嬻䰽⼿㝁⩃≅敇㹉㹋⽍㹏⅑⑓㝕⩗㽙㉛㵝ᥟ", num), this.class87_0.string_27);
                }
                if (this.class87_0.bool_0)
                {
                    class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ吱崳娵吷᜹弻儽ⰿⵁ㙃", num), this.class87_0.string_11);
                    class2.method_40(BookmarkStart.b("丧䔩ᘫ䰭儯儱弳儵䨷唹䤻倽␿潁❃⥅⑇╉㹋", num), this.class87_0.string_9);
                }
            }
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ䄱儳唵圷吹堻弽㈿㭁楃⁅ⅇ♉⁋捍㍏㵑㡓㥕⩗", num), this.class87_0.string_10);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ帱䄳嬵儷吹崻倽⌿❁", num), this.class87_0.string_1);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ儱嬳堵䰷䠹崻䴽㐿", num), this.class87_0.string_0);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ儱嬳娵圷䠹ᄻ匽⼿♁⅃", num), this.class87_0.string_2);
            this.class87_0.class1048_0.method_0(class2);
            if (!A_0)
            {
                class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱尳夵䨷匹䘻儽⸿㙁╃⩅敇㩉⍋㵍", num), this.class87_0.string_5);
                class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱尳夵䨷匹䘻儽⸿㙁╃⩅敇㡉⥋≍", num), this.class87_0.string_6);
                class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱䈳匵䨷丹唻崽ℿ⹁楃㙅❇㥉", num), this.class87_0.string_3);
                class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱䈳匵䨷丹唻崽ℿ⹁楃㑅ⵇ♉", num), this.class87_0.string_4);
            }
            class2.method_40(BookmarkStart.b("丧䔩ᘫ䴭尯嬱䐳", num), this.class87_0.string_7);
            class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱刳娵圷䴹ᄻ䤽⤿㙁ⱃ歅㱇⽉㑋㩍", num), this.class87_0.string_8);
            class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱䌳䐵夷䨹", num), this.class87_0.string_12);
            class2.method_40(BookmarkStart.b("嬧帩唫䈭唯࠱䘳䌵嘷᜹䠻嘽㈿ⵁㅃⅅ⁇", num), this.class87_0.string_13);
            class2.method_40(BookmarkStart.b("丧䔩ᘫ夭䈯匱䐳ᬵ圷䨹䠻圽⼿ⱁ", num), this.class87_0.string_30);
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ匱䄳䈵圷᜹嬻䰽⼿㕁楃⹅ⵇ⍉⭋♍⑏", num), this.class87_0.bool_1 ? BookmarkStart.b("尧堩夫䬭", num) : BookmarkStart.b("丧䬩䀫崭唯", num));
            class2.method_40(BookmarkStart.b("䰧堩䴫夭ਯ匱䄳䈵圷᜹嬻䰽⼿㕁楃ㅅⅇ⹉㡋♍", num), this.class87_0.bool_1 ? BookmarkStart.b("尧堩夫䬭", num) : BookmarkStart.b("丧䬩䀫崭唯", num));
            class2.method_6(BookmarkStart.b("嬧帩唫䈭唯࠱匳䐵夷䨹吻圽⌿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num));
        }
    }

    private void method_2(ShapeBase A_0)
    {
        int num = 14;
        if ((A_0.method_34() || A_0.IsWordArt) && !A_0.IsGroup)
        {
            this.class87_0.string_30 = BookmarkStart.b("䌳䐵夷䨹", num);
        }
        this.class87_0.string_6 = BookmarkStart.b("䐳圵䨷嬹嬻䰽ℿ㉁ⱃ", num);
        this.class87_0.string_4 = BookmarkStart.b("䐳圵䨷嬹嬻䰽ℿ㉁ⱃ", num);
        Class43 shapePr = A_0.ShapePr;
        Class111 class3 = new Class111();
        Class109 class4 = null;
        StrokeArrowWidth medium = StrokeArrowWidth.Medium;
        StrokeArrowWidth width = StrokeArrowWidth.Medium;
        string str = null;
        this.class87_0.bool_0 = true;
        bool flag3 = false;
        bool flag = ((A_0 is ShapeObject) && (A_0 as ShapeObject).Stroked) && !(A_0 as ShapeObject).HasImageBytes;
        int num4 = 0;
        bool flag2 = false;
        int num3 = 0;
        if (!flag)
        {
            this.class87_0.string_18 = BookmarkStart.b("娳夵嘷弹", num);
            this.class87_0.class1048_0.class411_0.string_0 = BookmarkStart.b("娳夵嘷弹", num);
            this.class87_0.class1048_0.class411_1.string_0 = BookmarkStart.b("娳夵嘷弹", num);
            this.class87_0.class1048_0.class411_2.string_0 = BookmarkStart.b("娳夵嘷弹", num);
            this.class87_0.class1048_0.class411_3.string_0 = BookmarkStart.b("娳夵嘷弹", num);
        }
        if (A_0.IsNeedDummyWhenInline && ((bool) shapePr.method_32(0x1fc)))
        {
            this.class87_0.string_18 = BookmarkStart.b("䜳夵吷匹堻", num);
        }
        this.class87_0.textWrappingStyle_0 = TextWrappingStyle.InFrontOfText;
        this.class87_0.string_13 = BookmarkStart.b("刳夵䨷弹嬻䰽⼿㝁⩃≅", num);
        for (int i = 0; i < shapePr.Count; i++)
        {
            int num7;
            int num6 = shapePr.method_18(i);
            object obj2 = shapePr.method_19(i);
            if (obj2 == null)
            {
                continue;
            }
            this.class87_0.int_0++;
            int num2 = num6;
            if (num2 > 0x1c1)
            {
                goto Label_0614;
            }
            if (num2 > 0x13e)
            {
                goto Label_03D3;
            }
            if (num2 <= 190)
            {
                if (num2 != 0x85)
                {
                    if (num2 != 190)
                    {
                        goto Label_0A7C;
                    }
                    this.class87_0.bool_1 = (bool) obj2;
                }
                else
                {
                    switch (((TextBoxWrapMode) obj2))
                    {
                        case TextBoxWrapMode.None:
                            this.class87_0.string_30 = BookmarkStart.b("娳夵ᔷ䴹主弽〿", num);
                            break;

                        case TextBoxWrapMode.Square:
                            this.class87_0.string_30 = BookmarkStart.b("䌳䐵夷䨹", num);
                            break;
                    }
                }
                continue;
            }
            switch (num2)
            {
                case 0x100:
                {
                    this.class87_0.double_2 = Class969.smethod_68((int) obj2);
                    continue;
                }
                case 0x101:
                {
                    this.class87_0.double_3 = Class969.smethod_68((int) obj2);
                    continue;
                }
                case 0x102:
                {
                    this.class87_0.double_0 = Class969.smethod_68((int) obj2);
                    continue;
                }
                case 0x103:
                {
                    this.class87_0.double_1 = Class969.smethod_68((int) obj2);
                    continue;
                }
                case 0x108:
                {
                    this.class87_0.string_0 = Class576.smethod_23((int) obj2);
                    continue;
                }
                case 0x109:
                {
                    this.class87_0.string_1 = Class576.smethod_25((int) obj2);
                    continue;
                }
                case 0x13d:
                {
                    if (!((bool) obj2))
                    {
                        break;
                    }
                    this.class87_0.string_2 = BookmarkStart.b("匳䐵崷䌹伻崽ℿ⹁⅃", num);
                    continue;
                }
                case 0x13e:
                {
                    if (!((bool) obj2))
                    {
                        goto Label_0319;
                    }
                    this.class87_0.string_2 = BookmarkStart.b("夳夵嘷唹", num);
                    continue;
                }
                default:
                    goto Label_0A7C;
            }
            this.class87_0.int_0--;
            continue;
        Label_0319:
            this.class87_0.int_0--;
            continue;
        Label_03D3:
            if (num2 <= 0x19c)
            {
                switch (num2)
                {
                    case 0x180:
                    {
                        this.class87_0.string_28 = Class922.smethod_21((FillType) obj2);
                        class3.method_5(Class922.smethod_22((FillType) obj2));
                        continue;
                    }
                    case 0x181:
                    {
                        this.class87_0.string_9 = Class576.smethod_75((Color) obj2);
                        this.class87_0.string_11 = this.class87_0.string_9;
                        class3.method_15(this.class87_0.string_9);
                        continue;
                    }
                    case 0x182:
                    {
                        this.class87_0.string_26 = Class576.smethod_81((int) obj2);
                        this.class87_0.string_27 = Class576.smethod_82((int) obj2);
                        class3.method_19(this.class87_0.string_26);
                        continue;
                    }
                    case 0x183:
                    {
                        class3.method_17(Class576.smethod_75((Color) obj2));
                        continue;
                    }
                    case 0x184:
                    {
                        class3.method_21(Class576.smethod_81((int) obj2));
                        continue;
                    }
                    case 0x18b:
                    {
                        num3 = (int) obj2;
                        class3.method_11(Class576.smethod_5(num3));
                        continue;
                    }
                    case 0x18c:
                    {
                        num4 = (int) obj2;
                        flag2 = true;
                        continue;
                    }
                    case 0x18d:
                    {
                        class3.method_7(Class576.smethod_27((int) obj2));
                        continue;
                    }
                    case 0x18e:
                    {
                        class3.method_9(Class576.smethod_27((int) obj2));
                        continue;
                    }
                    case 0x19c:
                    {
                        flag3 = ((int) obj2) == 0x4000000b;
                        continue;
                    }
                }
            }
            else
            {
                switch (num2)
                {
                    case 0x1c0:
                    {
                        Color black = (Color) obj2;
                        if (black.IsEmpty || (black == Color.Transparent))
                        {
                            black = Color.Black;
                        }
                        string str2 = Class576.smethod_75(black);
                        this.class87_0.string_20 = str2;
                        continue;
                    }
                    case 0x1c1:
                    {
                        this.class87_0.string_22 = Class576.smethod_81((int) obj2);
                        continue;
                    }
                    case 0x1bb:
                    {
                        this.class87_0.bool_0 = (bool) obj2;
                        continue;
                    }
                }
            }
            goto Label_0A7C;
        Label_0614:
            if (num2 > 0x23e)
            {
                goto Label_08E3;
            }
            if (num2 > 0x1fc)
            {
                goto Label_0816;
            }
            switch (num2)
            {
                case 0x1cb:
                {
                    this.class87_0.string_21 = Class576.smethod_56((int) obj2);
                    continue;
                }
                case 0x1ce:
                    switch (((LineDashing) obj2))
                    {
                        case LineDashing.Solid:
                        case LineDashing.Solid:
                        {
                            continue;
                        }
                    }
                    if (!Class422.smethod_1(A_0))
                    {
                        break;
                    }
                    num7 = this.class422_0.method_81().method_8();
                    goto Label_0749;

                case 0x1d0:
                {
                    this.class87_0.string_16 = this.class422_0.method_12(shapePr, (ArrowType) obj2, true);
                    continue;
                }
                case 0x1d1:
                {
                    this.class87_0.string_17 = this.class422_0.method_12(shapePr, (ArrowType) obj2, false);
                    continue;
                }
                case 0x1d2:
                {
                    medium = (StrokeArrowWidth) obj2;
                    continue;
                }
                case 0x1d4:
                {
                    width = (StrokeArrowWidth) obj2;
                    continue;
                }
                case 0x1d7:
                {
                    str = (((LineCap) A_0.ShapePr.method_31(0x1d7)) == LineCap.Round) ? BookmarkStart.b("䘳夵䴷吹堻", num) : BookmarkStart.b("䘳匵嬷丹", num);
                    continue;
                }
                case 0x1fc:
                {
                    if (this.class87_0.string_18 != BookmarkStart.b("倳圵䬷刹", num))
                    {
                        this.class87_0.string_18 = ((bool) obj2) ? BookmarkStart.b("䜳夵吷匹堻", num) : BookmarkStart.b("娳夵嘷弹", num);
                    }
                    else
                    {
                        this.class87_0.int_0--;
                    }
                    continue;
                }
                default:
                    goto Label_0A7C;
            }
            num7 = this.class422_0.method_53();
            this.class422_0.method_54(this.class422_0.method_53() + 1);
        Label_0749:
            class4 = Class922.smethod_13(A_0, num7);
            this.class87_0.string_19 = class4.method_0();
            this.class87_0.string_18 = BookmarkStart.b("倳圵䬷刹", num);
            continue;
        Label_0816:
            switch (num2)
            {
                case 0x201:
                {
                    this.class87_0.string_23 = Class576.smethod_75((Color) obj2);
                    continue;
                }
                case 0x204:
                {
                    this.class87_0.string_25 = Class576.smethod_81((int) obj2);
                    continue;
                }
                case 0x205:
                {
                    this.class87_0.string_31 = Class576.smethod_56((int) obj2);
                    continue;
                }
                case 0x206:
                {
                    this.class87_0.string_32 = Class576.smethod_56((int) obj2);
                    continue;
                }
                case 0x23e:
                {
                    this.class87_0.string_24 = ((bool) obj2) ? BookmarkStart.b("䈳張䬷匹帻刽┿", num) : BookmarkStart.b("尳張尷帹夻倽", num);
                    continue;
                }
                default:
                    goto Label_0A7C;
            }
        Label_08E3:
            if (num2 <= 0x392)
            {
                switch (num2)
                {
                    case 900:
                    {
                        this.method_5(this.class87_0.class1048_0.class411_2, obj2);
                        continue;
                    }
                    case 0x385:
                    {
                        this.method_5(this.class87_0.class1048_0.class411_0, obj2);
                        continue;
                    }
                    case 0x386:
                    {
                        this.method_5(this.class87_0.class1048_0.class411_3, obj2);
                        continue;
                    }
                    case 0x387:
                    {
                        this.method_5(this.class87_0.class1048_0.class411_1, obj2);
                        continue;
                    }
                    case 0x38f:
                    {
                        this.class87_0.string_5 = Class922.smethod_46((HorizontalPosition) obj2);
                        continue;
                    }
                    case 0x390:
                    {
                        this.class87_0.string_6 = Class922.smethod_44((RelativeHorizontalPosition) obj2);
                        continue;
                    }
                    case 0x391:
                    {
                        ShapeVerticalAlignment alignment = (ShapeVerticalAlignment) obj2;
                        this.class87_0.string_3 = Class922.smethod_40(alignment);
                        continue;
                    }
                    case 0x392:
                    {
                        this.class87_0.string_4 = Class922.smethod_38((RelativeVerticalPosition) obj2);
                        continue;
                    }
                    case 0x287:
                    {
                        this.class87_0.string_10 = Class576.smethod_75((Color) obj2);
                        continue;
                    }
                }
            }
            else
            {
                switch (num2)
                {
                    case 0x1001:
                    {
                        this.class87_0.textWrappingStyle_0 = (TextWrappingStyle) obj2;
                        continue;
                    }
                    case 0x1002:
                    {
                        this.class87_0.textWrappingType_0 = (TextWrappingType) obj2;
                        continue;
                    }
                    case 0x3ba:
                    {
                        this.class87_0.string_13 = ((bool) obj2) ? BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅", num) : BookmarkStart.b("刳夵䨷弹嬻䰽⼿㝁⩃≅", num);
                        continue;
                    }
                    case 0x100a:
                    {
                        this.class87_0.class1048_0.class411_0.border_0 = (Border) obj2;
                        this.class87_0.int_0--;
                        continue;
                    }
                    case 0x100b:
                    {
                        this.class87_0.class1048_0.class411_2.border_0 = (Border) obj2;
                        this.class87_0.int_0--;
                        continue;
                    }
                    case 0x100c:
                    {
                        this.class87_0.class1048_0.class411_1.border_0 = (Border) obj2;
                        this.class87_0.int_0--;
                        continue;
                    }
                    case 0x100d:
                    {
                        this.class87_0.class1048_0.class411_3.border_0 = (Border) obj2;
                        this.class87_0.int_0--;
                        continue;
                    }
                }
            }
        Label_0A7C:
            this.class87_0.int_0--;
        }
        if (this.class87_0.bool_0)
        {
            if (!Class567.smethod_16(this.class87_0.string_11))
            {
                this.class87_0.string_11 = BookmarkStart.b("ᜳ倵帷尹娻堽☿", num);
            }
            if (!Class567.smethod_16(this.class87_0.string_9))
            {
                this.class87_0.string_9 = BookmarkStart.b("ᜳ倵帷尹娻堽☿", num);
            }
        }
        if (this.class87_0.class1048_0.method_1(flag, false))
        {
            this.class87_0.int_0++;
        }
        this.class87_0.class1048_0.class411_0.string_0 = string.Format(BookmarkStart.b("伳ص䔷ᨹ䜻༽㴿扁㽃瑅㕇", num), this.class87_0.string_20, this.class87_0.string_21, this.class87_0.string_18);
        this.class87_0.class1048_0.class411_1.string_0 = string.Format(BookmarkStart.b("伳ص䔷ᨹ䜻༽㴿扁㽃瑅㕇", num), this.class87_0.string_20, this.class87_0.string_21, this.class87_0.string_18);
        this.class87_0.class1048_0.class411_2.string_0 = string.Format(BookmarkStart.b("伳ص䔷ᨹ䜻༽㴿扁㽃瑅㕇", num), this.class87_0.string_20, this.class87_0.string_21, this.class87_0.string_18);
        this.class87_0.class1048_0.class411_3.string_0 = string.Format(BookmarkStart.b("伳ص䔷ᨹ䜻༽㴿扁㽃瑅㕇", num), this.class87_0.string_20, this.class87_0.string_21, this.class87_0.string_18);
        if (this.class87_0.string_18 == BookmarkStart.b("䜳夵吷匹堻", num))
        {
            if ((this.class87_0.class1048_0.class411_0.string_0 == null) || (this.class87_0.class1048_0.class411_0.string_0 == BookmarkStart.b("娳夵嘷弹", num)))
            {
                this.class87_0.class1048_0.class411_0.string_0 = BookmarkStart.b("ᜳص࠷ਹ఻฽瀿扁瑃桅硇等瑋ⵍ㵏牑❓㥕㑗㍙㡛", num);
            }
            if ((this.class87_0.class1048_0.class411_1.string_0 == null) || (this.class87_0.class1048_0.class411_1.string_0 == BookmarkStart.b("娳夵嘷弹", num)))
            {
                this.class87_0.class1048_0.class411_1.string_0 = BookmarkStart.b("ᜳص࠷ਹ఻฽瀿扁瑃桅硇等瑋ⵍ㵏牑❓㥕㑗㍙㡛", num);
            }
            if ((this.class87_0.class1048_0.class411_2.string_0 == null) || (this.class87_0.class1048_0.class411_2.string_0 == BookmarkStart.b("娳夵嘷弹", num)))
            {
                this.class87_0.class1048_0.class411_2.string_0 = BookmarkStart.b("ᜳص࠷ਹ఻฽瀿扁瑃桅硇等瑋ⵍ㵏牑❓㥕㑗㍙㡛", num);
            }
            if ((this.class87_0.class1048_0.class411_3.string_0 == null) || (this.class87_0.class1048_0.class411_3.string_0 == BookmarkStart.b("娳夵嘷弹", num)))
            {
                this.class87_0.class1048_0.class411_3.string_0 = BookmarkStart.b("ᜳص࠷ਹ఻฽瀿扁瑃桅硇等瑋ⵍ㵏牑❓㥕㑗㍙㡛", num);
            }
        }
        if (Class567.smethod_16(this.class87_0.string_16))
        {
            this.class87_0.string_14 = smethod_1(shapePr, medium, true);
        }
        if (Class567.smethod_16(this.class87_0.string_17))
        {
            this.class87_0.string_15 = smethod_1(shapePr, width, false);
        }
        if ((class4 != null) && Class422.smethod_1(A_0))
        {
            class4.method_5(str);
            if (this.class422_0.method_81().method_2(class4.method_0(), null, false, false) == null)
            {
                this.class422_0.method_81().method_1(class4, false, false);
            }
        }
        this.method_4(A_0);
        if ((this.class87_0.string_3 == null) || (this.class87_0.string_4 == BookmarkStart.b("堳張嘷弹", num)))
        {
            this.class87_0.string_3 = BookmarkStart.b("刳䐵圷圹ᄻ䨽⼿㉁", num);
            if (this.class87_0.string_3 == null)
            {
                this.class87_0.int_0++;
            }
        }
        if ((this.class87_0.string_3 == BookmarkStart.b("刳䐵圷圹ᄻ䨽⼿㉁", num)) && !Class567.smethod_16(this.class87_0.string_4))
        {
            this.class87_0.string_4 = BookmarkStart.b("䐳圵䨷嬹嬻䰽ℿ㉁ⱃ", num);
        }
        if (this.class87_0.string_5 == null)
        {
            this.class87_0.string_5 = BookmarkStart.b("刳䐵圷圹ᄻ刽┿⑁ぃ", num);
            this.class87_0.int_0++;
        }
        this.class87_0.string_12 = Class922.smethod_31(this.class87_0.textWrappingStyle_0, this.class87_0.textWrappingType_0);
        if (this.class87_0.string_12 != null)
        {
            this.class87_0.int_0++;
        }
        if (this.class87_0.string_8 == null)
        {
            this.class87_0.string_8 = BookmarkStart.b("刳圵吷䤹夻", num);
            this.class87_0.int_0++;
        }
        this.method_3(class3, num3, num4, flag2, flag3);
    }

    private void method_3(Class111 A_0, int A_1, int A_2, bool A_3, bool A_4)
    {
        int num = 14;
        if (this.class87_0.string_28 == BookmarkStart.b("匳䐵夷帹唻嬽⸿㙁", 14))
        {
            A_0.method_1(string.Format(BookmarkStart.b("猳䴵࠷䜹", num), Class1041.smethod_8(this.class422_0.method_51())));
            this.class422_0.method_52(this.class422_0.method_51() + 1);
            this.class87_0.string_29 = A_0.method_0();
            this.class422_0.method_85().method_1(A_0, false, false);
            if ((A_0.method_4() == BookmarkStart.b("䜳䜵䴷嬹主嬽", num)) && ((A_2 > 0) || (A_2 == -100)))
            {
                string str3 = A_0.method_14();
                A_0.method_15(A_0.method_16());
                A_0.method_17(str3);
            }
            if (A_0.method_4() == BookmarkStart.b("堳張嘷弹崻䰽", num))
            {
                if ((A_2 % 100) != 0)
                {
                    A_0.method_5(BookmarkStart.b("唳丵儷嬹倻", num));
                }
                if (((A_2 >= 0) && (A_2 < 100)) && ((A_1 >= 0) || !A_3))
                {
                    string str = A_0.method_14();
                    A_0.method_15(A_0.method_16());
                    A_0.method_17(str);
                    string str2 = A_0.method_18();
                    A_0.method_19(A_0.method_20());
                    A_0.method_21(str2);
                }
            }
            A_0.method_15(smethod_0(A_0.method_14(), A_4));
            A_0.method_17(smethod_0(A_0.method_16(), A_4));
        }
    }

    private void method_4(ShapeBase A_0)
    {
        int num = 13;
        if (A_0.IsTopLevel && (A_0 is ShapeObject))
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            if ((((this.class87_0.double_0 != 0.0) || (this.class87_0.double_1 != 0.0)) || ((this.class87_0.double_2 != 0.0) || (this.class87_0.double_3 != 0.0))) && obj2.HasImageBytes)
            {
                ImageSize size = new ImageSize((int) obj2.ImageData.Size.Width, (int) obj2.ImageData.Size.Height);
                if (size.IsValid)
                {
                    this.class87_0.string_7 = string.Format(BookmarkStart.b("䄲倴吶䴸ጺ䘼༾㱀捂㹄癆㑈歊㙌絎ⱐ獒⹔摖⑘牚", num), new object[] { Class576.smethod_42(this.class87_0.double_2 * size.HeightPixels), Class576.smethod_42(this.class87_0.double_1 * size.WidthPixels), Class576.smethod_42(this.class87_0.double_3 * size.HeightPixels), Class576.smethod_42(this.class87_0.double_0 * size.WidthPixels) });
                    this.class87_0.int_0++;
                }
            }
        }
    }

    private void method_5(Class411 A_0, object A_1)
    {
        int num = (int) A_1;
        if (num == 0)
        {
            this.class87_0.int_0--;
        }
        else
        {
            A_0.string_3 = Class576.smethod_42(Class969.smethod_42(num));
        }
    }

    internal Class87 method_6()
    {
        return this.class87_0;
    }

    internal void method_7(Class87 A_0)
    {
        this.class87_0 = A_0;
    }

    private static string smethod_0(string A_0, bool A_1)
    {
        int num = 15;
        if (!(A_0 == BookmarkStart.b("ᘴ制弸崺഼༾獀畂獄", 15)))
        {
            return A_0;
        }
        if (!A_1)
        {
            return BookmarkStart.b("ᘴ儶嬸强Լ崾⍀", num);
        }
        return BookmarkStart.b("ᘴ儶弸Ⱥмؾ础", num);
    }

    private static string smethod_1(Class43 A_0, StrokeArrowWidth A_1, bool A_2)
    {
        int num = 9;
        int propertyKey = A_2 ? 0x1d0 : 0x1d1;
        if (!A_0.HasValue(propertyKey))
        {
            return null;
        }
        ArrowType type = (ArrowType) A_0.method_31(propertyKey);
        if (A_1 == StrokeArrowWidth.Wide)
        {
            return smethod_2(type, BookmarkStart.b("ᠮ԰Ȳ", num), BookmarkStart.b("᤮0в", num));
        }
        if (A_1 == StrokeArrowWidth.Medium)
        {
            return smethod_2(type, BookmarkStart.b("ᨮаԲ", num), BookmarkStart.b("ᰮذ", num));
        }
        return smethod_2(type, BookmarkStart.b("ᬮȰĲ", num), BookmarkStart.b("ᴮ԰в", num));
    }

    private static string smethod_2(ArrowType A_0, string A_1, string A_2)
    {
        int num = 5;
        string str = (A_0 == ArrowType.Open) ? A_1 : A_2;
        return string.Format(BookmarkStart.b("ᬪ̬吮İ串嘴娶", num), str);
    }
}

