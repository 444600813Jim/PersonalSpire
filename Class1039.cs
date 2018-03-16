using Spire.Doc;
using System;

internal class Class1039
{
    private Class398 class398_0;
    private Class782[] class782_0;
    private int int_0;
    private Interface48 interface48_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;

    internal Class1039(Interface48 A_0, Class398 A_1)
    {
        this.class398_0 = A_1;
        this.interface48_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        this.int_0++;
        switch (A_0)
        {
            case 0x500:
                this.string_0 = Class1085.smethod_64((EditAs) A_1);
                this.int_0--;
                return;

            case 0x501:
                this.string_1 = Class1041.smethod_8((int) A_1);
                return;

            case 0x502:
            case 0x503:
                break;

            case 0x504:
                this.class782_0 = (Class782[]) A_1;
                break;

            case 0x505:
                this.string_2 = Class1041.smethod_8((int) A_1);
                return;

            case 0x506:
                this.string_3 = Class1041.smethod_8((int) A_1);
                return;

            case 0x507:
                this.string_4 = Class1041.smethod_8((int) A_1);
                return;

            case 0x508:
                this.string_5 = Class114.smethod_3((int[]) A_1);
                return;

            case 0x53c:
                this.string_6 = Class734.smethod_12(A_1);
                return;

            case 0x53d:
                this.string_7 = Class734.smethod_12(A_1);
                return;

            default:
                return;
        }
    }

    internal void method_1()
    {
        int num = 3;
        if (this.int_0 > 0)
        {
            this.class398_0.method_4(BookmarkStart.b("䘨ᄪ䤬䘮倰吲䜴嘶吸", num));
            this.class398_0.method_40(BookmarkStart.b("弨ᄪ䠬圮䔰", num), BookmarkStart.b("䰨伪䐬嬮", num));
            this.class398_0.method_40(BookmarkStart.b("䴨䰪䀬尮䔰䨲头制", num), this.string_1);
            this.class398_0.method_40(BookmarkStart.b("䴨䰪䀬尮到刲头制䄸", num), this.string_2);
            this.class398_0.method_40(BookmarkStart.b("䴨䰪䀬尮到刲头制䀸", num), this.string_3);
            this.class398_0.method_40(BookmarkStart.b("䴨䰪䀬䤮帰崲䄴䐶倸䄺堼", num), this.string_4);
            this.class398_0.method_40(BookmarkStart.b("䨨䐪䌬尮䔰䄲吴帶圸夺刼䨾⽀❂㙄", num), this.string_5);
            this.class398_0.method_40(BookmarkStart.b("䠨帪夬䀮地尲䜴娶堸伺", num), this.string_6);
            this.class398_0.method_40(BookmarkStart.b("嬨个嬬䨮䌰䀲倴", num), this.string_7);
            if ((this.class782_0 != null) && (this.class782_0.Length > 0))
            {
                this.class398_0.method_4(BookmarkStart.b("䘨ᄪ弬䨮崰刲䄴帶嘸唺䤼帾⍀⽂⁄", num));
                this.class398_0.method_40(BookmarkStart.b("弨ᄪ䠬圮䔰", num), BookmarkStart.b("䰨伪䐬嬮", num));
                foreach (Class782 class2 in this.class782_0)
                {
                    this.class398_0.method_4(BookmarkStart.b("䘨ᄪ弬䨮崰", num));
                    this.class398_0.method_40(BookmarkStart.b("弨ᄪ䠬圮䔰", num), BookmarkStart.b("䰨伪䐬嬮", num));
                    this.class398_0.method_40(BookmarkStart.b("䀨伪帬崮到", num), this.interface48_0.imethod_0(class2.int_0));
                    this.class398_0.method_40(BookmarkStart.b("䀨伪䤬䨮䈰䜲", num), this.interface48_0.imethod_0(class2.int_1));
                    this.class398_0.method_40(BookmarkStart.b("䀨伪丬䄮䔰䄲", num), this.interface48_0.imethod_0(class2.int_2));
                    this.class398_0.method_5();
                }
                this.class398_0.method_5();
            }
            this.class398_0.method_5();
        }
    }

    internal string method_2()
    {
        return this.string_0;
    }
}

