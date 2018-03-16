using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;

internal class Class788
{
    private Class398 class398_0;
    private int int_0;
    private string string_0;
    private string string_1;
    private string string_10;
    private string string_11;
    private string string_12;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class788(Class398 A_0)
    {
        this.class398_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        if (A_1 is bool)
        {
            switch (A_0)
            {
                case 0x379:
                case 0x37b:
                    if (!((bool) A_1))
                    {
                        this.int_0++;
                    }
                    goto Label_0060;
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
    Label_0060:
        switch (A_0)
        {
            case 0x340:
                this.string_0 = Class1085.smethod_44((CalloutType) A_1);
                return;

            case 0x341:
                this.string_1 = Class734.smethod_0((int) A_1);
                return;

            case 0x342:
                this.string_2 = Class1085.smethod_20((CalloutAngle) A_1);
                return;

            case 0x343:
                this.string_3 = Class1085.smethod_18((CalloutDropType) A_1);
                return;

            case 0x344:
                this.string_4 = Class734.smethod_0((int) A_1);
                return;

            case 0x345:
                this.string_5 = Class734.smethod_1((int) A_1);
                return;

            case 0x379:
                this.string_6 = Class734.smethod_11(A_1, true);
                return;

            case 890:
                this.string_7 = Class734.smethod_11(A_1, false);
                return;

            case 0x37b:
                this.string_8 = Class734.smethod_11(A_1, true);
                return;

            case 0x37c:
                this.string_9 = Class734.smethod_11(A_1, false);
                return;

            case 0x37d:
                this.string_10 = Class734.smethod_11(A_1, false);
                return;

            case 0x37e:
                this.string_11 = Class734.smethod_11(A_1, false);
                return;

            case 0x37f:
                this.string_12 = Class734.smethod_11(A_1, false);
                return;
        }
    }

    internal void method_1()
    {
        int num = 7;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("䈬ᔮ到刲头嬶嘸为䤼", num));
            this.class398_0.method_40(BookmarkStart.b("嬬ᔮ吰䬲䄴", num), BookmarkStart.b("䠬䬮堰䜲", num));
            this.class398_0.method_40(BookmarkStart.b("夬嘮䄰嘲", num), this.string_0);
            this.class398_0.method_40(BookmarkStart.b("䨬丮䄰", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("䰬䄮嘰弲倴", num), this.string_2);
            this.class398_0.method_40(BookmarkStart.b("䤬崮帰䌲", num), this.string_3);
            this.class398_0.method_40(BookmarkStart.b("䤬䘮䈰䜲吴夶娸帺", num), this.string_4);
            this.class398_0.method_40(BookmarkStart.b("䄬䨮弰吲䄴弶", num), this.string_5);
            this.class398_0.method_40(BookmarkStart.b("䈬䄮", num), this.string_6);
            this.class398_0.method_40(BookmarkStart.b("䰬䰮到嘲嬴䌶嬸娺似", num), this.string_7);
            this.class398_0.method_40(BookmarkStart.b("夬䨮䤰䜲圴堶䬸强堼䴾", num), this.string_8);
            this.class398_0.method_40(BookmarkStart.b("䀬䘮弰䘲䘴伶", num), this.string_9);
            this.class398_0.method_40(BookmarkStart.b("䀬䘮弰䘲䘴丶", num), this.string_10);
            this.class398_0.method_40(BookmarkStart.b("䤬崮帰䌲吴䈶䴸吺", num), this.string_11);
            this.class398_0.method_40(BookmarkStart.b("䄬䨮弰吲䄴弶䨸䬺堼尾⡀╂ⱄ≆ⵈ", num), this.string_12);
            this.class398_0.method_5();
        }
    }
}

