using Spire.Doc;
using System;
using System.Collections;
using System.IO;

internal class Class405 : Class403
{
    public Class405(Stream A_0)
    {
        base.class295_0 = new Class295(A_0);
        base.class295_0.method_1(2);
        base.method_1(new Class1042(base.class295_0));
    }

    public void method_10()
    {
        base.method_0().method_3();
        base.class295_0.method_3();
    }

    private Hashtable method_11()
    {
        int num = 4;
        Hashtable hashtable = new Hashtable();
        Class393 class3 = new Class393(base.method_5(BookmarkStart.b("ԩ眫洭弯就䀳匵嘷丹挻樽㤿㉁⅃㕅ᕇ摉㑋⍍㱏", 4)).method_4());
        while (class3.method_9(BookmarkStart.b("縩唫席唯䄱", num)))
        {
            string str = class3.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("温䤫䠭儯䜱堳䈵", num)))
                {
                    if (!(str == BookmarkStart.b("攩娫䬭䈯䀱崳刵崷", num)))
                    {
                        goto Label_0071;
                    }
                    smethod_5(class3, hashtable);
                }
                else
                {
                    smethod_4(class3, hashtable);
                }
                continue;
            }
        Label_0071:
            class3.vmethod_1();
        }
        return hashtable;
    }

    private static void smethod_4(Class393 A_0, Hashtable A_1)
    {
        int num = 0x10;
        string str = null;
        string str2 = null;
        while (A_0.method_19())
        {
            string str3 = A_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("猵䀷丹夻倽㌿⭁⭃⡅", num)))
                {
                    if (str3 == BookmarkStart.b("电圷吹䠻嬽⸿㙁၃㽅㡇⽉", num))
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
        int num = 4;
        string str = null;
        string str2 = null;
        while (A_0.method_19())
        {
            string str3 = A_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("稩䴫尭䐯簱唳嬵崷", num)))
                {
                    if (str3 == BookmarkStart.b("椩䌫䀭䐯圱娳䈵氷䌹䰻嬽", num))
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
        return (BookmarkStart.b("थ", 0) + A_0.Replace(BookmarkStart.b("稥", 0), BookmarkStart.b("थ", 0)));
    }
}

