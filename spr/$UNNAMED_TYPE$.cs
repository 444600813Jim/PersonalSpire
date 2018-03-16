using Spire.Doc;

namespace spr
{
    using Spire.Doc;
    using System;

    internal class $UNNAMED_TYPE$
    {
        private $UNNAMED_TYPE$()
        {
        }

        internal static void smethod_0(Class857 A_0)
        {
            int num = 2;
            Class396 class2 = A_0.method_11();
            Class92 class3 = new Class92();
            smethod_1(A_0, class3);
            while (class2.method_9(BookmarkStart.b("堧䬩䬫䬭ᴯ帱唳伵圷伹䠻", num)))
            {
                string str = class2.method_1();
                if (str != null)
                {
                    if (str != BookmarkStart.b("堧䬩䬫䬭ᴯ帱唳伵圷伹䠻ጽ〿ぁ⭃㙅ⵇ㡉㡋❍㕏⅑", num))
                    {
                        
                        if (!(str == BookmarkStart.b("䀧伩䴫䨭唯䀱ᤳ䔵䰷䌹倻嬽", num)))
                        {
                            if (!(str == BookmarkStart.b("丧䔩䌫娭唯䀱ᤳ䔵䰷䌹倻嬽", num)))
                            {
                                goto Label_0090;
                            }
                            class3.method_15(Class1096.smethod_0(A_0, class2.method_1()));
                        }
                        else
                        {
                            class3.method_13(Class1096.smethod_0(A_0, class2.method_1()));
                        }
                    }
                    else
                    {
                        Class920.smethod_0(A_0, class3);
                    }
                    continue;
                }
            Label_0090:
                class2.vmethod_1();
            }
            if (class3.method_12() != null)
            {
                class3.method_4().method_111(class3.method_4().method_104());
                float num3 = (class3.method_12().method_10() > 0f) ? class3.method_12().method_10() : class3.method_12().method_8();
                class3.method_4().method_105(class3.method_4().method_104() + num3);
            }
            if (class3.method_14() != null)
            {
                class3.method_4().method_113(class3.method_4().method_106());
                float num2 = (class3.method_14().method_10() > 0f) ? class3.method_14().method_10() : class3.method_14().method_8();
                class3.method_4().method_107(class3.method_4().method_106() + num2);
            }
            A_0.method_13().method_1(class3, A_0.method_20(), true);
        }

        private static void smethod_1(Class857 A_0, Class92 A_1)
        {
            int num = 13;
            Class396 class2 = A_0.method_11();
            while (class2.method_19())
            {
                string str = class2.method_1();
                if (str != null)
                {
                    if (!(str == BookmarkStart.b("崲吴娶尸", num)))
                    {
                        if (str == BookmarkStart.b("䌲吴倶尸ᘺ䠼䰾⁀⑂⁄", num))
                        {
                        }
                    }
                    else
                    {
                        A_1.method_1(class2.method_3());
                    }
                }
            }
        }
    }
}

