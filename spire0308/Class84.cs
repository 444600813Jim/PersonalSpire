using Spire.Doc;
using System;
using System.Collections;

internal class Class84
{
    private Class84()
    {
    }

    public static void smethod_0(Class403 A_0, bool A_1)
    {
        smethod_1(A_0, A_0.method_2(), "", A_1);
        ArrayList list = new ArrayList();
        foreach (Class467 class3 in (IEnumerable) A_0.method_0())
        {
            if (class3.method_6().method_0() > 0)
            {
                list.Add(class3);
            }
        }
        foreach (Class467 class2 in list)
        {
            smethod_1(A_0, class2.method_6(), class2.method_0(), A_1);
        }
    }

    private static void smethod_1(Class403 A_0, Class644 A_1, string A_2, bool A_3)
    {
        int num = 5;
        int num2 = A_2.LastIndexOf('/');
        string str = A_2.Substring(0, num2 + 1);
        string str2 = A_2.Substring(num2 + 1);
        Class467 class4 = new Class467(string.Format(BookmarkStart.b("倪ᴬ刮䨰Ȳ䠴栶䬸帺儼䰾湀㡂睄㩆杈㥊⡌⍎≐", 5), str.StartsWith(BookmarkStart.b("Ъ", 5)) ? "" : BookmarkStart.b("Ъ", num), str, str2), BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈⑊㵌⩎㽐⭒㡔㭖㽘㑚⽜㉞`ᝢᙤ䩦ᥨ੪๬Ѯၰᑲၴ奶୸ṺᅼṾ愈ﾎ뢒殺", num));
        Class397 class3 = new Class397(class4.method_4(), A_3);
        class3.method_2(BookmarkStart.b("礪䠬䌮倰䜲尴堶圸䠺唼嘾ㅀあ", num));
        class3.method_18(BookmarkStart.b("匪䀬䌮弰䀲", num), BookmarkStart.b("䌪夬嬮䄰लᨴᠶ䨸堺唼娾ⱀ≂㙄楆♈㭊⡌ⅎ⥐㹒㥔ㅖ㙘⥚ぜ㹞ᕠၢ䭤ࡦ᭨౪䉬ὮၰၲṴᙶṸṺ剼䵾놀뎂뎄ꢆﮈ朗杖練튠", num));
        foreach (Class1088 class2 in (IEnumerable) A_1)
        {
            class3.method_4(BookmarkStart.b("礪䠬䌮倰䜲尴堶圸䠺唼嘾ㅀ", num));
            class3.method_18(BookmarkStart.b("截䤬", num), class2.method_0());
            class3.method_18(BookmarkStart.b("缪听弮吰", num), class2.method_1());
            class3.method_18(BookmarkStart.b("缪䰬崮嘰嘲䄴", num), class2.method_2());
            if (class2.method_3())
            {
                class3.method_18(BookmarkStart.b("缪䰬崮嘰嘲䄴稶嘸强堼", num), BookmarkStart.b("渪唬嬮吰䄲嬴嘶唸", num));
            }
            class3.method_5();
        }
        class3.method_3();
        A_0.method_0().method_2(class4);
    }
}

