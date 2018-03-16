using Spire.Doc;
using System;

internal class Class799
{
    private Class799()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 10;
        A_0.method_21(false);
        Class113 class2 = A_0.method_10().method_2(BookmarkStart.b("Ἧ䄱䀳伵吷弹伻ွ㠿⽁⡃", 10));
        if (class2 != null)
        {
            Class396 class3 = new Class396(class2.method_3());
            A_0.method_12(class3);
            while (class3.method_9(BookmarkStart.b("启崱圳䌵唷弹刻䨽洿ㅁぃ㽅⑇⽉㽋", num)))
            {
                string str = class3.method_1();
                if (str != null)
                {
                    if (str != BookmarkStart.b("嘯崱娳䈵ᔷ尹崻崽┿潁⁃⍅⭇♉㽋", num))
                    {
                        if (str != BookmarkStart.b("䌯䘱䴳娵崷䤹", num))
                        {
                            if (!(str == BookmarkStart.b("儯䜱䀳夵唷嬹䠻圽⌿潁㝃㉅ㅇ♉⥋㵍", num)))
                            {
                                if (!(str == BookmarkStart.b("崯匱䜳䈵崷䠹ᄻ䴽㐿㭁⡃⍅㭇", num)))
                                {
                                    goto Label_00B4;
                                }
                                Class243.smethod_0(A_0);
                            }
                            else
                            {
                                Class855.smethod_0(A_0);
                            }
                        }
                        else
                        {
                            Class795.smethod_0(A_0);
                        }
                    }
                    else
                    {
                        Class976.smethod_0(A_0);
                    }
                    continue;
                }
            Label_00B4:
                class3.vmethod_1();
            }
        }
    }
}

