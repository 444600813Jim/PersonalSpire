using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class235
{
    private Class398 class398_0;
    private int int_0;
    private string string_0;
    private string string_1;
    private string string_10;
    private string string_11;
    private string string_12;
    private string string_13;
    private string string_14;
    private string string_15;
    private string string_16;
    private string string_17;
    private string string_18;
    private string string_19;
    private string string_2;
    private string string_20;
    private string string_21;
    private string string_22;
    private string string_23;
    private string string_24;
    private string string_25;
    private string string_26;
    private string string_27;
    private string string_28;
    private string string_29;
    private string string_3;
    private string string_30;
    private string string_31;
    private string string_32;
    private string string_33;
    private string string_34;
    private string string_35;
    private string string_36;
    private string string_37;
    private string string_38;
    private string string_39;
    private string string_4;
    private string string_40;
    private string string_41;
    private string string_42;
    private string string_43;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class235(Class398 A_0)
    {
        this.class398_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        int num = 2;
        if (A_1 is bool)
        {
            switch (A_0)
            {
                case 0x2fb:
                case 0x2fd:
                case 0x2fe:
                case 0x2bf:
                    if (!((bool) A_1))
                    {
                        this.int_0++;
                    }
                    goto Label_0072;
            }
            if ((bool) A_1)
            {
                this.int_0++;
            }
        }
        else
        {
            this.int_0++;
        }
    Label_0072:
        switch (A_0)
        {
            case 640:
                this.string_0 = Class734.smethod_9(A_1);
                return;

            case 0x281:
                this.string_1 = Class734.smethod_9(A_1);
                return;

            case 0x282:
                this.string_2 = Class1041.smethod_8((int) A_1);
                return;

            case 0x283:
                this.string_3 = Class734.smethod_0((int) A_1);
                return;

            case 0x284:
                this.string_4 = Class734.smethod_0((int) A_1);
                return;

            case 0x285:
                this.string_5 = Class734.smethod_0((int) A_1);
                return;

            case 0x286:
                this.string_6 = Class1085.smethod_38((PlaneType) A_1);
                return;

            case 0x287:
                this.string_7 = Class735.smethod_1((Color) A_1);
                return;

            case 0x288:
            case 0x289:
            case 650:
            case 0x28b:
            case 0x28c:
            case 0x28d:
            case 0x2db:
            case 0x2dc:
            case 0x2dd:
            case 0x2de:
            case 0x2df:
            case 0x2e0:
            case 0x2e1:
            case 0x2e2:
            case 0x2e3:
            case 740:
            case 0x2e5:
            case 0x2e6:
            case 0x2e7:
            case 0x2e8:
            case 0x2e9:
            case 0x2ea:
            case 0x2eb:
            case 0x2ec:
            case 0x2ed:
            case 750:
            case 0x2ef:
            case 0x2f0:
            case 0x2f1:
            case 0x2f2:
            case 0x2f3:
            case 0x2f4:
            case 0x2f5:
            case 0x2f6:
            case 0x2f7:
            case 760:
            case 0x2f9:
            case 0x2fa:
                break;

            case 700:
                this.string_8 = Class734.smethod_11(A_1, false);
                return;

            case 0x2bd:
                this.string_9 = Class734.smethod_11(A_1, false);
                return;

            case 0x2be:
                this.string_10 = Class734.smethod_12(A_1);
                return;

            case 0x2bf:
                this.string_11 = Class734.smethod_11(A_1, true);
                return;

            case 0x2c0:
                this.string_12 = Class734.smethod_9(A_1);
                return;

            case 0x2c1:
                this.string_13 = Class734.smethod_9(A_1);
                return;

            case 0x2c2:
                this.string_14 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2c3:
                this.string_15 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2c4:
                this.string_16 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2c5:
                this.string_17 = Class734.smethod_9(A_1);
                return;

            case 710:
                this.string_18 = Class734.smethod_9(A_1);
                return;

            case 0x2c7:
                this.string_19 = Class734.smethod_9(A_1);
                return;

            case 0x2c8:
                this.string_20 = Class734.smethod_1((int) A_1);
                return;

            case 0x2c9:
                this.string_21 = Class1085.smethod_40((ThreeDRenderMode) A_1);
                return;

            case 0x2ca:
                this.string_22 = Class734.smethod_9(A_1);
                return;

            case 0x2cb:
                this.string_23 = Class734.smethod_1((int) A_1);
                return;

            case 0x2cc:
                this.string_24 = Class734.smethod_1((int) A_1);
                return;

            case 0x2cd:
                this.string_25 = Class734.smethod_1((int) A_1);
                break;

            case 0x2ce:
                this.string_26 = Class734.smethod_9(A_1);
                return;

            case 0x2cf:
                this.string_27 = Class734.smethod_9(A_1);
                return;

            case 720:
                this.string_28 = Class734.smethod_9(A_1);
                return;

            case 0x2d1:
                this.string_29 = Class734.smethod_22((int) A_1);
                return;

            case 0x2d2:
                this.string_30 = Class734.smethod_9(A_1);
                return;

            case 0x2d3:
                this.string_31 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2d4:
                this.string_32 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2d5:
                this.string_33 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2d6:
                this.string_34 = Class734.smethod_9(A_1);
                return;

            case 0x2d7:
                this.string_35 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2d8:
                this.string_36 = Class1041.smethod_8((int) A_1);
                return;

            case 0x2d9:
                this.string_37 = Class1041.smethod_8((int) A_1);
                return;

            case 730:
                this.string_38 = Class734.smethod_9(A_1);
                return;

            case 0x2fb:
                this.string_39 = Class734.smethod_11(A_1, true);
                return;

            case 0x2fc:
                this.string_40 = Class734.smethod_11(A_1, false);
                return;

            case 0x2fd:
                if ((bool) A_1)
                {
                    break;
                }
                this.string_41 = BookmarkStart.b("堧伩師崭䀯圱圳䈵儷䰹夻", num);
                return;

            case 0x2fe:
                this.string_42 = Class734.smethod_11(A_1, true);
                return;

            case 0x2ff:
                this.string_43 = Class734.smethod_11(A_1, false);
                return;

            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 14;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("嬳వ崷䈹䠻䰽㔿ㅁⵃ⥅♇", num));
            this.class398_0.method_40(BookmarkStart.b("䈳వ崷䈹䠻", num), BookmarkStart.b("䈳張崷䴹", num));
            this.class398_0.method_40(BookmarkStart.b("䜳䘵崷夹䤻刽ℿぁⵃ㉅ㅇ", num), this.string_0);
            this.class398_0.method_40(BookmarkStart.b("倳張帷尹䤻䴽⤿㙁㵃", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("䜳帵儷吹唻倽┿ㅁ㝃", num), this.string_2);
            this.class398_0.method_40(BookmarkStart.b("儳刵強弹", num), this.string_3);
            this.class398_0.method_40(BookmarkStart.b("刳夵䨷弹堻嬽〿㙁ⱃ", num), this.string_4);
            this.class398_0.method_40(BookmarkStart.b("嘳圵嬷儹堻嬽〿㙁ⱃ", num), this.string_5);
            this.class398_0.method_40(BookmarkStart.b("䐳娵夷吹夻", num), this.string_6);
            this.class398_0.method_40(BookmarkStart.b("圳夵吷唹主", num), this.string_7);
            this.class398_0.method_40(BookmarkStart.b("嬳堵", num), this.string_8);
            this.class398_0.method_40(BookmarkStart.b("夳匵䰷嬹倻", num), this.string_9);
            this.class398_0.method_40(BookmarkStart.b("堳張強刹䠻堽ℿ⅁⅃", num), this.string_11);
            this.class398_0.method_51(BookmarkStart.b("䘳夵䰷嬹䠻圽⼿ⱁ╃⡅⽇♉⥋", num), this.string_13, this.string_12);
            this.class398_0.method_52(BookmarkStart.b("嬳䐵儷弹刻䨽ℿ㙁ⵃ⥅♇", num), this.string_14, this.string_15, this.string_16);
            this.class398_0.method_40(BookmarkStart.b("嬳䐵儷弹刻䨽ℿ㙁ⵃ⥅♇⭉≋⥍㱏㝑", num), this.string_17);
            this.class398_0.method_52(BookmarkStart.b("䘳夵䰷嬹䠻圽⼿ⱁ❃⍅♇㹉⥋㱍", num), this.string_18, this.string_19, this.string_20);
            this.class398_0.method_40(BookmarkStart.b("䘳匵嘷帹夻䰽", num), this.string_21);
            this.class398_0.method_40(BookmarkStart.b("刳圵嬷弹䠻", num), this.string_22);
            this.class398_0.method_52(BookmarkStart.b("䈳張崷䴹䰻儽⤿ⱁぃ", num), this.string_23, this.string_24, this.string_25);
            this.class398_0.method_51(BookmarkStart.b("䈳張崷䴹䰻儽⤿ⱁぃ⥅㩇⍉⭋❍㹏", num), this.string_26, this.string_27);
            this.class398_0.method_40(BookmarkStart.b("䜳崵崷䴹崻倽✿⹁⅃", num), this.string_28);
            this.class398_0.method_40(BookmarkStart.b("䜳崵崷䴹崻匽㐿", num), this.string_29);
            this.class398_0.method_40(BookmarkStart.b("嘳䐵儷崹吻䨽⸿❁㝃㕅", num), this.string_30);
            this.class398_0.method_52(BookmarkStart.b("堳張強刹䠻丽⼿ㅁⵃ㉅ⅇ╉≋", num), this.string_31, this.string_32, this.string_33);
            this.class398_0.method_40(BookmarkStart.b("堳張強刹䠻刽┿㑁⅃⩅", num), this.string_34);
            this.class398_0.method_52(BookmarkStart.b("堳張強刹䠻丽⼿ㅁⵃ㉅ⅇ╉≋籍", num), this.string_35, this.string_36, this.string_37);
            this.class398_0.method_40(BookmarkStart.b("堳張強刹䠻刽┿㑁⅃⩅穇", num), this.string_38);
            this.class398_0.method_40(BookmarkStart.b("堳夵嬷儹主儽㐿⍁ぃ⽅❇⑉⽋⭍㹏♑ㅓ⑕", num), this.string_39);
            this.class398_0.method_40(BookmarkStart.b("唳䌵䰷唹主儽㐿⍁ぃ⽅❇⑉⽋⭍㹏♑ㅓ⑕", num), this.string_40);
            this.class398_0.method_40(BookmarkStart.b("䀳伵䠷弹", num), this.string_41);
            this.class398_0.method_40(BookmarkStart.b("堳張強刹䠻嘽ℿぁ㝃⹅", num), this.string_42);
            this.class398_0.method_40(BookmarkStart.b("堳張強刹䠻嘽ℿぁ㝃⹅穇", num), this.string_43);
            this.class398_0.method_5();
        }
    }
}

