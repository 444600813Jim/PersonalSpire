using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;

internal class Class686
{
    private Class398 class398_0;
    private int int_0;
    private object object_0;
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

    internal Class686(Class398 A_0)
    {
        this.class398_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        int num = 0x10;
        this.int_0++;
        switch (A_0)
        {
            case 0xc0:
                this.string_4 = (string) A_1;
                return;

            case 0xc1:
                break;

            case 0xc2:
                this.string_10 = Class1085.smethod_12((TextPathAlignment) A_1);
                return;

            case 0xc3:
                this.string_6 = Class734.smethod_10((int) A_1) + BookmarkStart.b("䘵䰷", num);
                return;

            case 0xc4:
                this.string_11 = Class734.smethod_10((int) A_1);
                return;

            case 0xc5:
                this.string_5 = (string) A_1;
                return;

            case 240:
                this.string_12 = Class734.smethod_12(A_1);
                return;

            case 0xf1:
                this.object_0 = Class734.smethod_12(A_1);
                return;

            case 0xf2:
                this.string_13 = Class734.smethod_12(A_1);
                break;

            case 0xf3:
                this.string_14 = Class734.smethod_12(A_1);
                return;

            case 0xf4:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_15 = BookmarkStart.b("䈵儷崹吻䨽┿ⱁⵃ⡅⽇", num);
                return;

            case 0xf5:
                this.string_0 = Class734.smethod_12(A_1);
                return;

            case 0xf6:
                this.string_1 = Class734.smethod_12(A_1);
                return;

            case 0xf7:
                this.string_2 = Class734.smethod_12(A_1);
                return;

            case 0xf8:
                this.string_16 = Class734.smethod_12(A_1);
                return;

            case 0xf9:
                this.string_3 = Class734.smethod_12(A_1);
                return;

            case 250:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_7 = BookmarkStart.b("吵圷嘹堻", num);
                return;

            case 0xfb:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_8 = BookmarkStart.b("張䰷嬹倻圽⌿", num);
                return;

            case 0xfc:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_18 = BookmarkStart.b("䌵嘷帹夻䰽ⰿ⭁⩃⍅", num);
                return;

            case 0xfd:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_17 = BookmarkStart.b("圵䴷丹医", num);
                return;

            case 0xfe:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_9 = BookmarkStart.b("䔵唷嬹倻刽洿⅁╃㙅㭇", num);
                return;

            case 0xff:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_18 = BookmarkStart.b("娵儷吹夻ጽ㐿⩁㙃⥅㵇ⵉ⑋", num);
                return;

            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 6;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("娫ᐭ䐯圱䰳䈵䠷嬹䠻嘽", num));
            this.class398_0.method_35(BookmarkStart.b("䌫䀭", num), this.object_0, BookmarkStart.b("堫", num));
            Class558 class2 = new Class558();
            if (!string.IsNullOrEmpty(this.string_5))
            {
                class2.method_2(BookmarkStart.b("䨫䄭帯䘱ᤳ倵夷圹唻刽㤿", num), string.Format(BookmarkStart.b("ห唭/伱ᘳ", num), this.string_5));
            }
            class2.method_2(BookmarkStart.b("䨫䄭帯䘱ᤳ䔵儷䀹夻", num), this.string_6);
            class2.method_2(BookmarkStart.b("䨫䄭帯䘱ᤳ䄵崷匹嬻嘽㐿", num), this.string_7);
            class2.method_2(BookmarkStart.b("䨫䄭帯䘱ᤳ䔵䰷䌹倻嬽", num), this.string_8);
            class2.method_2(BookmarkStart.b("䨫䄭帯䘱ᤳ䀵夷䠹唻弽⸿㙁", num), this.string_9);
            class2.method_2(BookmarkStart.b("娫̭䐯圱䰳䈵ᔷ嬹倻圽✿ⱁ", num), this.string_10);
            class2.method_2(BookmarkStart.b("娫̭䐯圱䰳䈵ᔷ䤹䰻弽⌿⭁⩃ⅅ", num), this.string_11);
            class2.method_2(BookmarkStart.b("娫̭䐯圱䰳䈵ᔷ䠹夻䠽┿ぁ㝃⍅", num), this.string_12);
            class2.method_2(BookmarkStart.b("娫̭䈯崱䀳圵䰷弹ᄻ刽┿㙁ぃ⍅㩇㥉", num), this.string_13);
            class2.method_2(BookmarkStart.b("娫̭䐯圱䰳䈵ᔷ儹夻䰽⸿", num), this.string_14);
            class2.method_2(BookmarkStart.b("娫̭䐯圱䰳䈵ᔷ䤹䰻弽⌿⭁⩃ⅅ敇❉⍋⩍㕏", num), this.string_15);
            class2.method_2(BookmarkStart.b("娫̭䌯匱夳匵ᔷ嘹夻䨽㐿❁㙃歅⁇⽉╋⥍㡏♑❓", num), this.string_16);
            class2.method_2(BookmarkStart.b("䄫崭弯ἱ䀳匵䀷丹ᄻ䴽⠿⍁⁃⥅㽇", num), this.string_17);
            class2.method_2(BookmarkStart.b("堫䬭䠯䘱ᤳ刵崷夹医䰽ℿ㙁ⵃ⥅♇", num), this.string_18);
            this.class398_0.method_40(BookmarkStart.b("弫娭䤯帱儳", num), Class734.smethod_2(class2));
            this.class398_0.method_35(BookmarkStart.b("䨫䜭䐯䄱尳圵䠷弹", num), this.string_0, BookmarkStart.b("堫", num));
            this.class398_0.method_36(BookmarkStart.b("堫尭夯弱", num), this.string_1);
            this.class398_0.method_36(BookmarkStart.b("䨫䜭䐯䈱唳䈵倷", num), this.string_2);
            this.class398_0.method_36(BookmarkStart.b("含崭匯匱堳匵", num), this.string_3);
            this.class398_0.method_36(BookmarkStart.b("弫娭䈯嬱娳儵", num), this.string_4);
            this.class398_0.method_5();
        }
    }
}

