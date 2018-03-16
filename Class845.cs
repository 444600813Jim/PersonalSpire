using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.Text;

internal class Class845
{
    private readonly Class398 class398_0;
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
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class845(Class398 A_0)
    {
        this.class398_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        if (!(A_1 is bool) || ((bool) A_1))
        {
            this.int_0++;
        }
        switch (A_0)
        {
            case 0x200:
                this.string_0 = Class1085.smethod_42((ShadowType) A_1);
                break;

            case 0x201:
                this.string_1 = Class735.smethod_1((Color) A_1);
                return;

            case 0x202:
                this.string_2 = Class735.smethod_1((Color) A_1);
                return;

            case 0x203:
            case 0x20f:
            case 530:
            case 0x213:
            case 0x214:
            case 0x215:
            case 0x216:
            case 0x217:
            case 0x218:
            case 0x219:
            case 0x21a:
            case 0x21b:
                break;

            case 0x204:
                this.string_3 = Class734.smethod_9(A_1);
                return;

            case 0x205:
                this.string_4 = Class734.smethod_0((int) A_1);
                return;

            case 0x206:
                this.string_5 = Class734.smethod_0((int) A_1);
                return;

            case 0x207:
                this.string_6 = Class734.smethod_0((int) A_1);
                return;

            case 520:
                this.string_7 = Class734.smethod_0((int) A_1);
                return;

            case 0x209:
                this.string_8 = Class734.smethod_9(A_1);
                return;

            case 0x20a:
                this.string_9 = Class734.smethod_9(A_1);
                return;

            case 0x20b:
                this.string_10 = Class734.smethod_9(A_1);
                return;

            case 0x20c:
                this.string_11 = Class734.smethod_9(A_1);
                return;

            case 0x20d:
                this.string_12 = Class734.smethod_24((int) A_1);
                return;

            case 0x20e:
                this.string_13 = Class734.smethod_24((int) A_1);
                return;

            case 0x210:
                this.string_14 = Class734.smethod_9(A_1);
                return;

            case 0x211:
                this.string_15 = Class734.smethod_9(A_1);
                return;

            case 0x23e:
                this.string_16 = Class734.smethod_11(A_1, false);
                return;

            case 0x23f:
                this.string_17 = Class734.smethod_11(A_1, false);
                return;

            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 10;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("䘯࠱䜳帵夷帹医䤽", num));
            this.class398_0.method_40(BookmarkStart.b("弯就", num), this.string_16);
            this.class398_0.method_40(BookmarkStart.b("䐯䬱䐳匵", num), this.string_0);
            this.class398_0.method_40(BookmarkStart.b("匯崱堳夵䨷", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("匯崱堳夵䨷࠹", num), this.string_2);
            this.class398_0.method_40(BookmarkStart.b("弯䈱唳唵儷丹䔻", num), this.string_3);
            this.class398_0.method_51(BookmarkStart.b("弯䀱崳儵儷吹", num), this.string_14, this.string_15);
            this.class398_0.method_51(BookmarkStart.b("弯吱刳䔵崷丹", num), this.string_4, this.string_5);
            this.class398_0.method_51(BookmarkStart.b("弯吱刳䔵崷丹฻", num), this.string_6, this.string_7);
            this.class398_0.method_40(BookmarkStart.b("崯匱䀳䐵儷䈹", num), this.method_2());
            this.class398_0.method_40(BookmarkStart.b("弯倱䜳唵䴷䠹夻娽", num), this.string_17);
            this.class398_0.method_5();
        }
    }

    internal string method_2()
    {
        StringBuilder builder = new StringBuilder();
        bool flag = false;
        flag = smethod_0(builder, this.string_8);
        builder.Append(',');
        flag |= smethod_0(builder, this.string_9);
        builder.Append(',');
        flag |= smethod_0(builder, this.string_10);
        builder.Append(',');
        flag |= smethod_0(builder, this.string_11);
        builder.Append(',');
        flag |= smethod_0(builder, this.string_12);
        builder.Append(',');
        if (!(flag |= smethod_0(builder, this.string_13)))
        {
            return null;
        }
        return builder.ToString().TrimEnd(new char[] { ',' });
    }

    private static bool smethod_0(StringBuilder A_0, string A_1)
    {
        if (!string.IsNullOrEmpty(A_1))
        {
            A_0.Append(A_1);
            return true;
        }
        return false;
    }
}

