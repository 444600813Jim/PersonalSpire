using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class965
{
    private bool bool_0;
    private bool bool_1;
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
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class965(ShapeBase A_0, Class398 A_1, Interface48 A_2)
    {
        this.class398_0 = A_1;
        this.shapeBase_0 = A_0;
        this.interface48_0 = A_2;
    }

    internal void method_0(int A_0, object A_1)
    {
        int num = 2;
        this.int_0++;
        switch (A_0)
        {
            case 0x180:
                this.string_1 = Class1085.smethod_65((FillType) A_1);
                if (((FillType) A_1) != FillType.ShadeCenter)
                {
                    if (((FillType) A_1) != FillType.ShadeUnscale)
                    {
                        break;
                    }
                    this.bool_1 = true;
                    return;
                }
                this.bool_0 = true;
                return;

            case 0x181:
                this.string_2 = Class735.smethod_1((Color) A_1);
                this.int_0--;
                return;

            case 0x182:
                this.string_3 = Class734.smethod_9(A_1);
                return;

            case 0x183:
                this.string_4 = Class735.smethod_1((Color) A_1);
                return;

            case 0x184:
                this.string_5 = Class734.smethod_9(A_1);
                return;

            case 0x185:
            case 390:
            case 0x188:
            case 0x189:
            case 0x18a:
            case 0x196:
            case 0x19d:
            case 0x1a0:
            case 0x1a1:
            case 0x1a2:
            case 0x1a3:
            case 420:
            case 0x1a5:
            case 0x1a7:
            case 0x1a8:
            case 0x1a9:
            case 0x1aa:
            case 0x1ab:
            case 0x1ac:
            case 0x1ad:
            case 430:
            case 0x1af:
            case 0x1b0:
            case 0x1b1:
            case 0x1b2:
            case 0x1b3:
            case 0x1b4:
            case 0x1b5:
            case 0x1b6:
            case 0x1b7:
            case 440:
            case 0x101a:
                break;

            case 0x187:
                this.string_6 = (string) A_1;
                return;

            case 0x18b:
                this.string_7 = Class734.smethod_9(A_1);
                return;

            case 0x18c:
                this.string_8 = Class734.smethod_22((int) A_1);
                return;

            case 0x18d:
                this.string_9 = Class734.smethod_9(A_1);
                return;

            case 0x18e:
                this.string_10 = Class734.smethod_9(A_1);
                return;

            case 0x18f:
                this.string_11 = Class734.smethod_9(A_1);
                return;

            case 400:
                this.string_12 = Class734.smethod_9(A_1);
                return;

            case 0x191:
                this.string_13 = Class734.smethod_9(A_1);
                return;

            case 0x192:
                this.string_14 = Class734.smethod_9(A_1);
                return;

            case 0x193:
                this.string_15 = Class734.smethod_9(A_1);
                return;

            case 0x194:
                this.string_16 = Class734.smethod_9(A_1);
                return;

            case 0x195:
                this.string_17 = Class1085.smethod_61((FillDimensionType) A_1);
                return;

            case 0x197:
                this.string_18 = Class734.smethod_15((Class954[]) A_1);
                return;

            case 0x198:
                this.string_19 = Class734.smethod_9(A_1);
                return;

            case 0x199:
                this.string_20 = Class734.smethod_9(A_1);
                return;

            case 410:
                this.string_21 = Class734.smethod_9(A_1);
                return;

            case 0x19b:
                this.string_22 = Class734.smethod_9(A_1);
                return;

            case 0x19c:
                if (((int) A_1) != 0x4000000b)
                {
                    this.string_23 = BookmarkStart.b("䘧䔩䈫䬭", num);
                    return;
                }
                this.string_23 = BookmarkStart.b("䐧䌩䈫䬭儯䀱ᐳ䔵儷崹儻弽", num);
                return;

            case 0x19e:
                this.int_0--;
                return;

            case 0x19f:
                this.int_0--;
                return;

            case 0x1a6:
                this.int_0--;
                return;

            case 0x1b9:
                if (!((bool) A_1))
                {
                    this.int_0--;
                    return;
                }
                this.string_24 = Class734.smethod_12(A_1);
                return;

            case 0x1ba:
                if (!((bool) A_1))
                {
                    this.int_0--;
                    break;
                }
                this.string_25 = Class734.smethod_12(A_1);
                return;

            case 0x1bb:
                this.string_26 = Class734.smethod_12(A_1);
                this.int_0--;
                return;

            case 0x1bc:
                this.string_27 = Class734.smethod_12(A_1);
                this.int_0--;
                return;

            case 0x1bd:
                this.string_28 = Class734.smethod_13((bool) A_1);
                this.int_0--;
                return;

            case 0x1be:
                this.string_29 = Class734.smethod_12(A_1);
                this.int_0--;
                return;

            case 0x1bf:
                this.string_30 = Class734.smethod_12(A_1);
                return;

            case 0x100f:
                this.byte_0 = (byte[]) A_1;
                return;

            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 0x12;
        if (this.shapeBase_0.ShapeType != ShapeType.Line)
        {
            this.class398_0.method_40(BookmarkStart.b("帷匹倻刽┿♁", num), this.string_26);
        }
        this.class398_0.method_40(BookmarkStart.b("帷匹倻刽⌿ⵁ⡃⥅㩇", num), this.string_2);
    }

    internal void method_2()
    {
        int num = 0;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("倥ሧ䰩䔫䈭尯", num));
            if ((this.interface48_0 as Class401).method_3() != null)
            {
                this.class398_0.method_40(this.interface48_0.imethod_5(), (this.interface48_0 as Class401).method_8(this.method_3(), this.shapeBase_0 as ShapeObject));
            }
            else
            {
                this.class398_0.method_40(this.interface48_0.imethod_5(), this.string_0);
            }
            if (this.string_0 != null)
            {
                this.class398_0.method_18(BookmarkStart.b("䤥ሧ帩䔫娭尯圱", num), this.string_6);
            }
            this.class398_0.method_40(BookmarkStart.b("䤥堧䬩伫䜭䐯䬱", num), this.string_3);
            this.class398_0.method_40(BookmarkStart.b("䔥䜧䘩䌫尭ȯ", num), this.string_4);
            this.class398_0.method_40(BookmarkStart.b("䤥ሧ䔩尫伭匯嬱䀳伵਷", num), this.string_5);
            this.class398_0.method_40(BookmarkStart.b("䜥嬧娩䤫䴭䐯", num), this.string_17);
            this.class398_0.method_51(BookmarkStart.b("䤥娧䌩䬫䜭帯", num), this.string_19, this.string_20);
            this.class398_0.method_51(BookmarkStart.b("嘥䜧天䔫娭夯崱娳", num), this.string_21, this.string_22);
            this.class398_0.method_40(BookmarkStart.b("吥䴧䤩䌫䈭弯䀱", num), this.string_24);
            this.class398_0.method_40(BookmarkStart.b("吥䜧帩䴫娭唯", num), this.string_25);
            this.class398_0.method_40(BookmarkStart.b("䜥䘧䴩䀫䬭", num), this.string_7);
            this.class398_0.method_40(BookmarkStart.b("䔥䜧䘩䌫尭䌯", num), this.string_18);
            if ((this.string_9 != null) || (this.string_10 != null))
            {
                this.class398_0.method_51(BookmarkStart.b("䀥䜧䤩夫崭䀯崱䜳張䰷匹医倽", num), this.string_9, this.string_10);
                this.class398_0.method_18(BookmarkStart.b("䀥䜧䤩夫崭䌯嬱丳匵", num), "");
            }
            this.class398_0.method_40(BookmarkStart.b("䬥䴧帩䐫䄭启", num), this.string_23);
            this.class398_0.method_40(BookmarkStart.b("䀥䜧䤩夫崭", num), this.string_8);
            this.class398_0.method_40(BookmarkStart.b("別儧娩䤫", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("䤥ሧ丩䤫娭唯儱䀳嬵圷伹伻嬽⌿⹁ⵃ╅⍇", num), this.string_30);
            if (this.bool_0 || this.bool_1)
            {
                this.class398_0.method_33(BookmarkStart.b("䤥ሧ䰩䔫䈭尯", num), new object[] { BookmarkStart.b("倥ሧ伩含娭", num), BookmarkStart.b("倥䄧伩嬫", num), BookmarkStart.b("別儧娩䤫", num), this.bool_0 ? BookmarkStart.b("䄥娧䬩䠫䜭唯就䀳电崷吹䠻嬽㈿", num) : BookmarkStart.b("䄥娧䬩䠫䜭唯就䀳挵嘷䤹弻弽ⰿ❁⁃", num) });
            }
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
}

