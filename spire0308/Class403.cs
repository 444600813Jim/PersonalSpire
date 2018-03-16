using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal abstract class Class403
{
    private Class1042 class1042_0 = new Class1042();
    protected Class295 class295_0;
    private readonly Class644 class644_0 = new Class644(BookmarkStart.b("̫", 6));
    private const string string_0 = "/";
    private const string string_1 = "../";

    protected Class403()
    {
    }

    public Class1042 method_0()
    {
        return this.class1042_0;
    }

    public void method_1(Class1042 A_0)
    {
        this.class1042_0 = A_0;
    }

    public Class644 method_2()
    {
        return this.class644_0;
    }

    internal void method_3()
    {
        int num = 14;
        foreach (Class467 class2 in (IEnumerable) this.class1042_0)
        {
            if (class2.method_1() == BookmarkStart.b("䘳匵吷䤹", num))
            {
                string str = class2.method_0().Replace(BookmarkStart.b("ᬳ椵䨷弹倻䴽", num), "").Replace(BookmarkStart.b("ᨳ䐵崷嘹伻", num), "");
                if (str == BookmarkStart.b("ᬳ", num))
                {
                    smethod_0(class2, this.class644_0);
                }
                else
                {
                    smethod_0(class2, this.method_5(str).method_6());
                }
            }
        }
    }

    public Class467 method_4(string A_0)
    {
        return this.class1042_0.method_1(A_0);
    }

    public Class467 method_5(string A_0)
    {
        int num = 7;
        Class467 class2 = this.method_4(A_0);
        if (class2 == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("測丮弰崲娴䌶ᤸ崺吼儾╀捂㕄♆㭈㽊浌桎⩐捒⡔灖睘", num), A_0));
        }
        return class2;
    }

    public Class467 method_6(Class467 A_0, string A_1)
    {
        Class644 class2;
        string str;
        int num = 3;
        if (A_0 == null)
        {
            class2 = this.class644_0;
            str = BookmarkStart.b("ب", num);
        }
        else
        {
            class2 = A_0.method_6();
            str = A_0.method_0();
        }
        Class1088 class3 = class2.method_5(A_1);
        if (class3 != null)
        {
            return this.method_5(smethod_2(str, class3.method_2()));
        }
        return null;
    }

    public Class467 method_7(Class467 A_0, string A_1)
    {
        int num = 9;
        Class467 class2 = this.method_6(A_0, A_1);
        if (class2 == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("氮倰崲嬴堶䴸ᬺ嬼嘾⽀❂敄㍆⡈㥊⩌⩎═獒㩔ㅖ祘⥚㡜㍞`ᝢ౤ࡦݨᡪլٮŰ卲剴౶䥸ٺ婼", num), A_1));
        }
        return class2;
    }

    public Class467 method_8(Class467 A_0, string A_1, string A_2, string A_3)
    {
        string str;
        return this.method_9(A_0, A_1, A_2, A_3, out str);
    }

    public Class467 method_9(Class467 A_0, string A_1, string A_2, string A_3, out string A_4)
    {
        if (A_0 != null)
        {
            A_1 = smethod_2(A_0.method_0(), A_1);
        }
        Class467 class2 = new Class467(A_1, A_2);
        this.class1042_0.method_2(class2);
        A_4 = ((A_0 != null) ? A_0.method_6() : this.class644_0).method_2(A_3, class2.method_0(), false);
        return class2;
    }

    private static void smethod_0(Class467 A_0, Class644 A_1)
    {
        int num = 7;
        Class393 class2 = new Class393(A_0.method_4());
        while (class2.method_9(BookmarkStart.b("缬䨮崰刲䄴帶嘸唺丼圾⡀㍂㙄", num)))
        {
            string str5;
            if (((str5 = class2.method_1()) != null) && (str5 == BookmarkStart.b("缬䨮崰刲䄴帶嘸唺丼圾⡀㍂", num)))
            {
                string str2 = null;
                string str4 = null;
                string str = null;
                bool flag = false;
                while (class2.method_19())
                {
                    string str3 = class2.method_1();
                    if (str3 != null)
                    {
                        if (str3 != BookmarkStart.b("搬䬮", num))
                        {
                            if (str3 != BookmarkStart.b("礬嘮䄰嘲", num))
                            {
                                if (!(str3 == BookmarkStart.b("礬丮䌰吲倴䌶", num)))
                                {
                                    if (str3 == BookmarkStart.b("礬丮䌰吲倴䌶琸吺夼娾", num))
                                    {
                                        flag = class2.method_3() == BookmarkStart.b("栬圮䔰嘲䜴夶堸场", num);
                                    }
                                }
                                else
                                {
                                    str = class2.method_3();
                                }
                            }
                            else
                            {
                                str4 = class2.method_3();
                            }
                        }
                        else
                        {
                            str2 = class2.method_3();
                        }
                    }
                }
                A_1.method_3(str2, str4, str, flag);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    public static string smethod_1(string A_0, string A_1)
    {
        int num = 11;
        if (!A_1.StartsWith(BookmarkStart.b("Ḱ", 11)))
        {
            return A_1;
        }
        int num5 = 0;
        int num4 = Math.Min(A_0.Length, A_1.Length);
        for (int i = 0; i < num4; i++)
        {
            if (A_0[i] == '/')
            {
                num5 = i;
            }
            if (A_0[i] != A_1[i])
            {
                break;
            }
        }
        int startIndex = num5 + 1;
        StringBuilder builder = new StringBuilder();
        for (int j = startIndex; j < A_0.Length; j++)
        {
            if (A_0[j] == '/')
            {
                builder.Append(BookmarkStart.b("ἰᴲᨴ", num));
            }
        }
        builder.Append(A_1, startIndex, A_1.Length - startIndex);
        return builder.ToString();
    }

    public static string smethod_2(string A_0, string A_1)
    {
        int num3;
        int num = 13;
        if (A_1.StartsWith(BookmarkStart.b("ᰲ", 13)))
        {
            return A_1;
        }
        if (Class567.smethod_41(A_1, BookmarkStart.b("紲怴笶甸", num)))
        {
            return "";
        }
        string str = smethod_3(A_0);
        int startIndex = 0;
    Label_006F:
        num3 = A_1.IndexOf(BookmarkStart.b("ᴲ᬴ᠶ", num), startIndex);
        if (num3 >= startIndex)
        {
            if (num3 > startIndex)
            {
                str = str + A_1.Substring(startIndex, num3 - startIndex);
            }
            str = smethod_3(str);
            startIndex = num3 + BookmarkStart.b("ᴲ᬴ᠶ", num).Length;
            goto Label_006F;
        }
        return (str + A_1.Substring(startIndex, A_1.Length - startIndex));
    }

    private static string smethod_3(string A_0)
    {
        int num = 7;
        if (!Class567.smethod_16(A_0))
        {
            return A_0;
        }
        if (A_0 == BookmarkStart.b("Ȭ", num))
        {
            return A_0;
        }
        int num3 = A_0.Length - 1;
        for (int i = num3; i >= 0; i--)
        {
            if ((A_0[i] == '/') && (i < num3))
            {
                return A_0.Substring(0, i + 1);
            }
        }
        return "";
    }

    public virtual void vmethod_0(Stream A_0)
    {
    }
}

