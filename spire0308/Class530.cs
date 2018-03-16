using Spire.Doc;
using Spire.Doc.Formatting;
using System;

internal class Class530
{
    private Class530()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, Class101 A_2)
    {
        int num = 6;
        Class396 class2 = A_0.method_11();
        int num2 = smethod_1(A_0);
        if (A_0.method_24() == -1)
        {
            switch (num2)
            {
                case 1:
                    A_0.method_43(true);
                    break;

                case 0:
                    A_0.method_43(false);
                    break;
            }
        }
        else
        {
            A_0.method_43(true);
        }
        A_0.method_25(A_0.method_24() + 1);
        string str2 = A_0.method_16();
        Document document = A_0.method_9();
        if ((A_2 == null) || ((str2 != null) && (str2 != A_2.method_0())))
        {
            A_2 = A_0.method_13().method_3(str2, null, A_0.method_20()) as Class101;
            A_2.method_21().Name = str2;
            if (document.ListStyles.FindByName(str2) == null)
            {
                document.ListStyles.Add(A_2.method_21());
            }
            else if (num2 != 1)
            {
                Class12 class3 = null;
                string str3 = BookmarkStart.b("怫䠭弯愱䀳伵吷弹挻", num) + Guid.NewGuid();
                if (document.ListOverrides.method_35(str3) == null)
                {
                    int count = document.ListOverrides.Count;
                    class3 = new Class12(document, count + 1) {
                        Name = str3
                    };
                    document.ListOverrides.method_34(class3);
                    A_2.method_28(str3);
                }
            }
        }
        while (class2.method_9(BookmarkStart.b("䀫䜭䌯䘱", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䀫䜭䌯䘱ᤳ帵崷嬹堻嬽㈿", num)))
                {
                    if (!(str == BookmarkStart.b("䀫䜭䌯䘱ᤳ張䰷弹儻", num)))
                    {
                        goto Label_018A;
                    }
                    smethod_2(A_0, A_1, A_2);
                }
                else
                {
                    smethod_3(A_0, A_1, BookmarkStart.b("䀫䜭䌯䘱ᤳ帵崷嬹堻嬽㈿", num), A_2);
                }
                goto Label_0190;
            }
        Label_018A:
            class2.vmethod_1();
        Label_0190:
            A_0.method_43(true);
        }
        A_0.method_25(A_0.method_24() - 1);
        if (A_0.method_24() == -1)
        {
            A_0.method_43(false);
        }
    }

    private static int smethod_1(Class857 A_0)
    {
        int num = 3;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        int num2 = -1;
        while (class2.method_19())
        {
            string str;
            if (!A_0.method_4(class2) && ((str = class2.method_1()) != null))
            {
                if (!(str == BookmarkStart.b("䨨䐪䌬嬮堰崲䀴制ᐸ唺䠼刾⍀♂㝄⹆❈ⱊ", num)))
                {
                    if (str == BookmarkStart.b("䨨䐪䌬嬮堰崲䀴制ᐸ场吼䰾㕀", num))
                    {
                        num2 = 1;
                    }
                }
                else
                {
                    num2 = (class2.method_3() == BookmarkStart.b("崨太堬䨮", num)) ? 1 : 0;
                }
            }
        }
        return num2;
    }

    private static void smethod_2(Class857 A_0, DocumentObject A_1, Class101 A_2)
    {
        int num = 6;
        Class396 class2 = A_0.method_11();
        int num2 = 1;
        while (class2.method_19())
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("弫娭儯䀱䀳ᬵ丷嬹倻䬽┿", num)))
            {
                if (A_2 != null)
                {
                    A_2.method_21().Levels[A_0.method_24()].StartAt = class2.method_4();
                }
                num2 = class2.method_4();
            }
        }
        if (A_2.method_27() != null)
        {
            string str2 = A_2.method_27();
            Class12 class3 = A_0.method_9().ListOverrides.method_35(str2);
            OverrideLevelFormat format = new OverrideLevelFormat(A_0.method_9());
            class3.method_23().method_9(A_0.method_24(), format);
            format.OverrideStartAtValue = true;
            format.OverrideListLevel = A_0.method_9().ListStyles.FindByName(A_2.method_0()).Levels[A_0.method_24()];
            class3.method_23().method_5(A_0.method_24()).StartAt = num2;
        }
        smethod_3(A_0, A_1, BookmarkStart.b("䀫䜭䌯䘱ᤳ張䰷弹儻", num), A_2);
    }

    private static void smethod_3(Class857 A_0, DocumentObject A_1, string A_2, Class101 A_3)
    {
        int num = 0x12;
        Class396 class2 = A_0.method_11();
        bool flag = true;
        while (class2.method_9(A_2))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䠷", num)) && !(str == BookmarkStart.b("倷", num)))
                {
                    if (!(str == BookmarkStart.b("吷匹伻䨽", num)))
                    {
                        goto Label_0072;
                    }
                    smethod_0(A_0, A_1, A_3);
                }
                else
                {
                    Class1099.smethod_0(A_0, class2.method_1(), ref A_1, A_3, flag);
                    flag = false;
                }
                continue;
            }
        Label_0072:
            class2.vmethod_1();
        }
    }
}

