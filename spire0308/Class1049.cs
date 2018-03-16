using Spire.Doc;
using System;

internal class Class1049
{
    private Class1049()
    {
    }

    internal static void smethod_0(Class857 A_0, Class106 A_1)
    {
        int num = 12;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        int num2 = 1;
        while (class2.method_19())
        {
            string str;
            if ((!A_0.method_4(class2) && ((str = class2.method_1()) != null)) && (str == BookmarkStart.b("就䄳嬵娷弹主ጽ⌿ⵁ⡃㍅╇⑉㽋捍≏㝑⑓㍕㥗⹙㥛㩝", num)))
            {
                num2 = class2.method_4();
            }
        }
        if (A_1 != null)
        {
            while (num2-- > 0)
            {
                Class94 class3 = A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("䘱唳吵吷弹ᄻ崽⼿⹁ㅃ⭅♇", num), A_0.method_20(), true) as Class94;
                if (class3 == null)
                {
                    class3 = new Class94();
                }
                A_1.method_20().Add(class3);
            }
        }
    }
}

