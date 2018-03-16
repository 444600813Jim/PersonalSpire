using Spire.Doc;
using System;
using System.Collections;
using System.IO;

internal class Class404 : Class403
{
    public Class404()
    {
    }

    public Class404(Stream A_0)
    {
        this.method_10(A_0);
    }

    public Class404(string A_0)
    {
        using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
        {
            this.method_10(stream);
        }
    }

    private void method_10(Stream A_0)
    {
        this.method_11(A_0);
        Hashtable hashtable = this.method_12();
        this.method_13(hashtable);
        base.method_3();
    }

    private void method_11(Stream A_0)
    {
        Class296 class2 = new Class296(A_0);
        while (class2.method_2())
        {
            Class467 class3 = new Class467(smethod_7(class2.method_0()), "");
            base.method_0().method_2(class3);
            try
            {
                class2.method_4(class3.method_4());
                class3.method_4().Position = 0L;
                continue;
            }
            catch (Exception2)
            {
                continue;
            }
        }
    }

    private Hashtable method_12()
    {
        int num = 9;
        Hashtable hashtable = new Hashtable();
        Class393 class3 = new Class393(base.method_5(BookmarkStart.b(".樰瀲娴夶䴸帺匼䬾Ṁᝂ㱄㝆ⱈ㡊၌慎⥐㹒㥔", 9)).method_4());
        while (class3.method_9(BookmarkStart.b("笮䠰䌲倴䐶", num)))
        {
            string str = class3.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("欮吰唲吴䈶唸伺", num)))
                {
                    if (!(str == BookmarkStart.b("怮䜰嘲䜴䔶倸强堼", num)))
                    {
                        goto Label_0072;
                    }
                    smethod_5(class3, hashtable);
                }
                else
                {
                    smethod_4(class3, hashtable);
                }
                continue;
            }
        Label_0072:
            class3.vmethod_1();
        }
        return hashtable;
    }

    private void method_13(Hashtable A_0)
    {
        foreach (Class467 class2 in (IEnumerable) base.method_0())
        {
            string str = (string) A_0[class2.method_0()];
            if (!Class567.smethod_16(str))
            {
                str = (string) A_0[class2.method_1()];
            }
            class2.method_3(str);
        }
    }

    private static void smethod_4(Class393 A_0, Hashtable A_1)
    {
        int num = 9;
        string str = null;
        string str2 = null;
        while (A_0.method_19())
        {
            string str3 = A_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("樮䤰䜲倴夶䨸刺刼儾", num)))
                {
                    if (str3 == BookmarkStart.b("氮帰崲䄴制圸伺椼䘾ㅀ♂", num))
                    {
                        str = A_0.method_3();
                    }
                }
                else
                {
                    str2 = A_0.method_3();
                }
            }
        }
        if (Class567.smethod_16(str) && Class567.smethod_16(str2))
        {
            A_1[str2] = str;
        }
    }

    private static void smethod_5(Class393 A_0, Hashtable A_1)
    {
        int num = 0x11;
        string str = null;
        string str2 = null;
        while (A_0.method_19())
        {
            string str3 = A_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("朶堸䤺䤼焾⁀⹂⁄", num)))
                {
                    if (str3 == BookmarkStart.b("琶嘸唺䤼娾⽀㝂ᅄ㹆㥈⹊", num))
                    {
                        str = A_0.method_3();
                    }
                }
                else
                {
                    str2 = A_0.method_3();
                }
            }
        }
        if (Class567.smethod_16(str) && Class567.smethod_16(str2))
        {
            A_1[str2] = str;
        }
    }

    private static string smethod_6(string A_0)
    {
        return A_0.TrimStart(new char[] { '/' });
    }

    private static string smethod_7(string A_0)
    {
        return (BookmarkStart.b("ᨴ", 15) + A_0.Replace(BookmarkStart.b("椴", 15), BookmarkStart.b("ᨴ", 15)));
    }

    public override void vmethod_0(Stream A_0)
    {
        Class295 class2 = new Class295(A_0);
        foreach (Class467 class3 in (IEnumerable) base.method_0())
        {
            class3.method_4().Position = 0L;
            class2.method_0(smethod_6(class3.method_0()), class3.method_4());
        }
        class2.method_3();
    }
}

