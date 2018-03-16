using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class82
{
    private byte[] byte_0;
    private readonly Class398 class398_0;
    private int int_0;
    private readonly Interface48 interface48_0;
    private readonly ShapeBase shapeBase_0;
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
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class82(ShapeBase A_0, Class398 A_1, Interface48 A_2)
    {
        this.shapeBase_0 = A_0;
        this.class398_0 = A_1;
        this.interface48_0 = A_2;
    }

    internal void method_0(int A_0, object A_1)
    {
        this.int_0++;
        switch (A_0)
        {
            case 0x1c0:
                this.string_1 = Class735.smethod_1((Color) A_1);
                this.int_0--;
                return;

            case 0x1c1:
                this.string_2 = Class734.smethod_9(A_1);
                return;

            case 450:
                this.string_3 = Class735.smethod_1((Color) A_1);
                return;

            case 0x1c3:
            case 0x1d9:
            case 0x1da:
            case 0x1db:
            case 0x1e1:
                this.int_0--;
                return;

            case 0x1c4:
                this.string_4 = Class1085.smethod_36((LineFillType) A_1);
                return;

            case 0x1c5:
            case 0x1d8:
            case 0x1dc:
            case 480:
            case 0x1e3:
            case 0x1e4:
            case 0x1e5:
            case 0x1e6:
            case 0x1e7:
            case 0x1e8:
            case 0x1e9:
            case 490:
            case 0x1eb:
            case 0x1ec:
            case 0x1ed:
            case 0x1ee:
            case 0x1ef:
            case 0x1f0:
            case 0x1f1:
            case 0x1f2:
            case 0x1f3:
            case 500:
            case 0x1f5:
            case 0x1f6:
                break;

            case 0x1c6:
                this.string_5 = (string) A_1;
                return;

            case 0x1c7:
            case 0x1c9:
            case 0x1ca:
            case 510:
            case 0x1019:
                this.int_0--;
                return;

            case 0x1c8:
            case 0x1fd:
                this.int_0--;
                return;

            case 0x1cb:
                if (((int) A_1) > 0)
                {
                    this.string_6 = Class734.smethod_0((int) A_1);
                }
                this.int_0--;
                break;

            case 460:
            case 0x1ff:
                this.int_0--;
                return;

            case 0x1cd:
                this.string_7 = Class1085.smethod_26((ShapeLineStyle) A_1);
                return;

            case 0x1ce:
                this.string_8 = Class1085.smethod_22((LineDashing) A_1);
                return;

            case 0x1cf:
                this.int_0--;
                return;

            case 0x1d0:
                this.string_9 = Class1085.smethod_34((ArrowType) A_1);
                return;

            case 0x1d1:
                this.string_10 = Class1085.smethod_34((ArrowType) A_1);
                return;

            case 0x1d2:
                this.string_11 = Class1085.smethod_30((StrokeArrowWidth) A_1);
                return;

            case 0x1d3:
                this.string_12 = Class1085.smethod_32((StrokeArrowLength) A_1);
                return;

            case 0x1d4:
                this.string_13 = Class1085.smethod_30((StrokeArrowWidth) A_1);
                return;

            case 0x1d5:
                this.string_14 = Class1085.smethod_32((StrokeArrowLength) A_1);
                return;

            case 470:
                this.string_15 = Class1085.smethod_24((StrokeJoinStyle) A_1);
                return;

            case 0x1d7:
                this.string_16 = Class1085.smethod_28((StrokeEndCap) A_1);
                return;

            case 0x1dd:
            case 0x1de:
            case 0x1df:
            case 0x1e2:
                this.int_0--;
                return;

            case 0x1f7:
                this.int_0--;
                return;

            case 0x1f8:
            case 0x1fa:
                this.int_0--;
                return;

            case 0x1f9:
                this.string_17 = Class734.smethod_12(A_1);
                this.int_0--;
                return;

            case 0x1fb:
                this.int_0--;
                return;

            case 0x1fc:
                this.string_18 = Class734.smethod_12(A_1);
                this.int_0--;
                return;

            case 0x100e:
                this.byte_0 = (byte[]) A_1;
                return;

            default:
                return;
        }
    }

    internal void method_1()
    {
        this.class398_0.method_40(BookmarkStart.b("䄱䀳䐵圷儹夻娽", 12), this.string_18);
        this.class398_0.method_40(BookmarkStart.b("䄱䀳䐵圷儹夻崽⼿⹁⭃㑅", 12), this.string_1);
        this.class398_0.method_40(BookmarkStart.b("䄱䀳䐵圷儹夻䤽┿⭁⍃⹅㱇", 12), this.string_6);
        this.class398_0.method_40(BookmarkStart.b("嬱娳䔵崷丹䰻嬽⸿", 12), this.string_17);
    }

    internal void method_2()
    {
        int num = 12;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("䐱ำ䔵䰷䠹医唽┿", num));
            if ((this.interface48_0 as Class401).method_3() != null)
            {
                this.class398_0.method_40(this.interface48_0.imethod_5(), (this.interface48_0 as Class401).method_8(this.method_3(), this.shapeBase_0 as ShapeObject));
            }
            else
            {
                this.class398_0.method_40(this.interface48_0.imethod_5(), this.string_0);
            }
            if ((this.string_5 != null) || !string.IsNullOrEmpty(this.string_0))
            {
                this.class398_0.method_18(BookmarkStart.b("崱ำ䈵儷丹倻嬽", num), this.string_5);
            }
            this.class398_0.method_40(BookmarkStart.b("報嬳張嘷䤹䠻䜽ⰿ❁", num), this.string_15);
            this.class398_0.method_40(BookmarkStart.b("嘱唳䔵倷䤹䠻䜽ⰿ❁", num), this.string_8);
            this.class398_0.method_40(BookmarkStart.b("帱崳堵崷䤹䠻䜽ⰿ❁", num), this.string_7);
            this.class398_0.method_40(BookmarkStart.b("圱娳刵嬷嬹䰻", num), this.string_16);
            this.class398_0.method_40(BookmarkStart.b("䄱䀳圵䨷丹崻䰽㈿ⵁ㍃", num), this.string_9);
            this.class398_0.method_40(BookmarkStart.b("䄱䀳圵䨷丹崻䰽㈿ⵁ㍃ㅅⅇ⹉㡋♍", num), this.string_11);
            this.class398_0.method_40(BookmarkStart.b("䄱䀳圵䨷丹崻䰽㈿ⵁ㍃⩅ⵇ⑉⭋㩍㡏", num), this.string_12);
            this.class398_0.method_40(BookmarkStart.b("圱娳刵夷䠹主儽㜿", num), this.string_10);
            this.class398_0.method_40(BookmarkStart.b("圱娳刵夷䠹主儽㜿㕁ⵃ≅㱇≉", num), this.string_13);
            this.class398_0.method_40(BookmarkStart.b("圱娳刵夷䠹主儽㜿⹁⅃⡅⽇㹉⑋", num), this.string_14);
            this.class398_0.method_40(BookmarkStart.b("崱䐳圵嬷匹䠻䜽", num), this.string_2);
            this.class398_0.method_40(BookmarkStart.b("儱嬳娵圷䠹฻", num), this.string_3);
            this.class398_0.method_40(BookmarkStart.b("吱崳娵吷丹䔻丽┿", num), this.string_4);
            this.class398_0.method_5();
        }
    }

    internal byte[] method_3()
    {
        return this.byte_0;
    }

    internal string method_4()
    {
        return this.string_0;
    }

    internal void method_5(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_6()
    {
        return this.string_15;
    }

    internal void method_7(string A_0)
    {
        if (string.IsNullOrEmpty(this.string_15) && string.IsNullOrEmpty(A_0))
        {
            this.int_0++;
        }
        this.string_15 = A_0;
    }
}

