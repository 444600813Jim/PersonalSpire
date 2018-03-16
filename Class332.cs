using Spire.Doc;
using System;

internal class Class332
{
    private Class398 class398_0;
    private int int_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    internal Class332(Class398 A_0)
    {
        this.class398_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x77:
                this.string_0 = Class734.smethod_11(A_1, false);
                return;

            case 120:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_1 = Class734.smethod_12(A_1);
                this.int_0++;
                return;

            case 0x79:
                this.string_2 = Class734.smethod_11(A_1, false);
                return;

            case 0x7a:
                this.string_3 = Class734.smethod_11(A_1, false);
                return;

            case 0x7b:
                this.string_4 = Class734.smethod_11(A_1, false);
                return;

            case 0x7c:
                if ((bool) A_1)
                {
                    this.string_5 = Class734.smethod_11(A_1, false);
                    this.int_0++;
                }
                break;

            case 0x7d:
                if (!((bool) A_1))
                {
                    break;
                }
                this.string_6 = Class734.smethod_11(A_1, false);
                this.int_0++;
                return;

            case 0x7e:
                this.string_7 = Class734.smethod_11(A_1, false);
                return;

            case 0x7f:
                this.string_8 = Class734.smethod_11(A_1, false);
                return;

            case 0x33c:
                if ((bool) A_1)
                {
                    this.string_9 = Class734.smethod_11(A_1, false);
                    this.int_0++;
                    return;
                }
                break;

            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 1;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("䠦ጨ䜪䈬䰮娰", num));
            this.class398_0.method_40(BookmarkStart.b("儦ጨ个唬嬮", num), BookmarkStart.b("䈦䴨䈪夬", num));
            this.class398_0.method_40(BookmarkStart.b("䘦娨嬪䠬䰮䔰䄲吴䌶倸吺", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("儦䰨太夬䘮到娲倴䐶", num), this.string_5);
            this.class398_0.method_40(BookmarkStart.b("匦䰨匪夬", num), this.string_6);
            this.class398_0.method_40(BookmarkStart.b("否䄨䨪崬䨮䔰䨲䔴制", num), this.string_9);
            this.class398_0.method_5();
        }
    }
}

