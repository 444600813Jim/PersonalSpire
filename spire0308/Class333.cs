using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;

internal class Class333
{
    private byte[] byte_0;
    private readonly Class398 class398_0;
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
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class333(ShapeBase A_0, Class398 A_1, Interface48 A_2)
    {
        this.class398_0 = A_1;
        this.shapeBase_0 = A_0;
        this.interface48_0 = A_2;
    }

    internal void method_0(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x139:
                this.string_12 = Class734.smethod_12(A_1);
                return;

            case 0x13a:
            case 0x13b:
            case 260:
            case 0x105:
            case 0x106:
            case 0x10b:
            case 0x10d:
            case 270:
            case 0x11b:
            case 0x11c:
            case 0x11d:
                break;

            case 0x13c:
                this.string_13 = Class734.smethod_12(A_1);
                return;

            case 0x13d:
                this.string_14 = Class734.smethod_11(A_1, false);
                return;

            case 0x13e:
                this.string_15 = Class734.smethod_11(A_1, false);
                return;

            case 0x13f:
                this.string_16 = Class734.smethod_12(A_1);
                return;

            case 0x1006:
                this.byte_0 = (byte[]) A_1;
                return;

            case 0x1007:
                this.string_1 = (string) A_1;
                return;

            case 0x1008:
                this.string_2 = (string) A_1;
                return;

            case 0x100:
                this.string_3 = Class734.smethod_9(A_1);
                return;

            case 0x101:
                this.string_4 = Class734.smethod_9(A_1);
                return;

            case 0x102:
                this.string_5 = Class734.smethod_9(A_1);
                return;

            case 0x103:
                this.string_6 = Class734.smethod_9(A_1);
                return;

            case 0x107:
                this.string_7 = Class735.smethod_1((Color) A_1);
                break;

            case 0x108:
                this.string_8 = Class734.smethod_9(A_1);
                return;

            case 0x109:
                this.string_9 = Class734.smethod_9(A_1);
                return;

            case 0x10a:
                this.string_10 = Class734.smethod_9(A_1);
                return;

            case 0x10c:
            {
                Color color2 = Color.FromArgb((int) A_1);
                this.string_11 = Class735.smethod_1(Color.FromArgb(0xef, color2.B, color2.G, color2.R));
                return;
            }
            case 0x11a:
            {
                Color color = Color.FromArgb((int) A_1);
                this.string_17 = Class735.smethod_1(Color.FromArgb(color.A, color.B, color.G, color.R));
                return;
            }
            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 5;
        if (((this.byte_0 != null) || (this.string_2 != null)) || (this.string_11 != null))
        {
            this.class398_0.method_4(BookmarkStart.b("崪ᜬ䘮尰刲刴制崸娺䤼帾", num));
            if (((this.interface48_0 as Class401).method_3() != null) && (((this.shapeBase_0 as ShapeObject).ShapeType == ShapeType.Image) || (this.shapeBase_0 as ShapeObject).HasImage))
            {
                this.class398_0.method_40(this.interface48_0.imethod_5(), (this.interface48_0 as Class401).method_8(this.method_2(), this.shapeBase_0 as ShapeObject));
            }
            else
            {
                if ((this.byte_0 != null) && (this.string_2 != this.string_0))
                {
                    this.class398_0.method_40(this.interface48_0.imethod_6(), this.string_2);
                }
                if ((this.byte_0 == null) && (this.string_2 == this.string_0))
                {
                    this.class398_0.method_40(this.interface48_0.imethod_5(), "");
                }
                else
                {
                    this.class398_0.method_40(this.interface48_0.imethod_5(), this.string_0);
                }
            }
            this.class398_0.method_18(BookmarkStart.b("䐪ᜬ嬮堰䜲头制", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("䠪弬䀮䄰䜲娴䜶", num), this.string_3);
            this.class398_0.method_40(BookmarkStart.b("䠪弬䀮䄰儲娴䌶䴸吺值", num), this.string_4);
            this.class398_0.method_40(BookmarkStart.b("䠪弬䀮䄰弲倴儶䴸", num), this.string_5);
            this.class398_0.method_40(BookmarkStart.b("䠪弬䀮䄰䄲尴倶儸伺", num), this.string_6);
            this.class398_0.method_40(BookmarkStart.b("䠪䔬崮帰帲吴尶尸䈺", num), this.string_7);
            this.class398_0.method_40(BookmarkStart.b("䰪䰬䘮弰", num), this.string_8);
            this.class398_0.method_40(BookmarkStart.b("䤪䄬丮到堲头制伸帺儼", num), this.string_9);
            this.class398_0.method_40(BookmarkStart.b("䰪䰬䈮尰刲", num), this.string_10);
            this.class398_0.method_40(BookmarkStart.b("䰪弬丮䠰䀲嘴嘶唸帺", num), this.string_14);
            this.class398_0.method_40(BookmarkStart.b("䤪䐬䌮吰䔲倴嬶", num), this.string_15);
            this.class398_0.method_40(BookmarkStart.b("个䀬䴮帰䀲䘴吶嘸场刼䴾", num), this.string_11);
            this.class398_0.method_40(BookmarkStart.b("太䠬䰮帰弲娴䔶䴸娺似堾⑀㝂", num), this.string_17);
            this.class398_0.method_5();
        }
    }

    internal byte[] method_2()
    {
        return this.byte_0;
    }

    internal string method_3()
    {
        return this.string_0;
    }

    internal void method_4(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_5()
    {
        return this.string_2;
    }

    internal void method_6(string A_0)
    {
        this.string_2 = A_0;
    }
}

