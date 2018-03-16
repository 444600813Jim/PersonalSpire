using Spire.Doc;
using System;

internal class Class744
{
    private Class744()
    {
    }

    internal static void smethod_0(Class857 A_0, Class107 A_1, bool A_2)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_9(class2, A_1.method_6()) && ((str = class2.method_1()) != null))
            {
                if (str != BookmarkStart.b("伦䰨䈪䨬䜮䔰", num))
                {
                    if (!(str == BookmarkStart.b("䨦䀨䔪,䜮吰娲刴弶䴸", num)))
                    {
                        if (((str == BookmarkStart.b("䌦倨䔪䰬䈮堰倲ᠴ䐶䤸娺帼嘾⽀⑂", num)) || (str == BookmarkStart.b("否䄨䨪䤬䀮䘰", num))) || (str == BookmarkStart.b("䔦䠨䠪䘬䠮䌰尲䀴夶崸ᘺ帼倾ⵀⱂ㝄", num)))
                        {
                        }
                    }
                    else
                    {
                        A_1.method_9((float) Class576.smethod_41(class2.method_3()));
                    }
                }
                else
                {
                    A_1.method_11((float) Class576.smethod_41(class2.method_3()));
                }
            }
        }
    }
}

