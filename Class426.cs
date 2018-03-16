using Spire.Doc;
using System;
using System.IO;

internal class Class426 : Class424
{
    private byte[] byte_1;
    private byte[] byte_2;
    private readonly Class425 class425_0;

    internal Class426(BinaryReader A_0)
    {
        int num = 8;
        MemoryStream stream = new MemoryStream();
        Class567.smethod_8(A_0.BaseStream, stream);
        Class394 class2 = new Class394(stream);
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            string str2 = class2.method_1();
            if (str2 == null)
            {
                goto Label_00DB;
            }
            if (str2 != BookmarkStart.b("䔭唯䬱瀳圵䰷嬹", num))
            {
                if (!(str2 == BookmarkStart.b("䨭儯䘱唳缵嘷丹夻夽㈿⭁ぃ㽅", num)))
                {
                    if (!(str2 == BookmarkStart.b("䔭唯䬱焳堵嬷䠹䔻丽㐿ⵁ㙃㕅", num)) && !(str2 == BookmarkStart.b("䔭唯䬱焳堵嬷䠹䔻丽㐿ⵁ㙃", num)))
                    {
                        if (!(str2 == BookmarkStart.b("䬭帯儱䘳伵䠷丹夻娽ି❁㵃", num)))
                        {
                            goto Label_00DB;
                        }
                        this.class425_0 = new Class425(class2);
                    }
                }
                else
                {
                    this.method_11(class2);
                }
            }
            else
            {
                this.method_10(class2);
            }
        }
        return;
    Label_00DB:
        throw new InvalidOperationException(BookmarkStart.b("笭帯失娳夵伷吹᰻䨽ℿ╁摃⡅⥇❉⥋恍", num));
    }

    private void method_10(Class394 A_0)
    {
        int num = 15;
        while (A_0.method_19())
        {
            if (!base.method_0(A_0))
            {
                throw new InvalidOperationException(BookmarkStart.b("怴夶券唺刼䠾⽀捂ㅄ♆⹈歊⍌⹎㱐㙒答", num));
            }
        }
    }

    private void method_11(Class394 A_0)
    {
        int num = 15;
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str == null)
            {
                goto Label_0066;
            }
            if (!(str == BookmarkStart.b("倴夶娸䤺䐼伾㕀♂⅄ཆ⑈⩊⹌ю㑐⩒", num)))
            {
                if (!(str == BookmarkStart.b("倴夶娸䤺䐼伾㕀♂⅄ཆ⑈⩊⹌᥎ぐ㽒⁔㉖", num)))
                {
                    goto Label_0066;
                }
                this.byte_2 = Convert.FromBase64String(A_0.method_3());
            }
            else
            {
                this.byte_1 = Convert.FromBase64String(A_0.method_3());
            }
        }
        return;
    Label_0066:
        throw new InvalidOperationException(BookmarkStart.b("怴夶券唺刼䠾⽀捂ㅄ♆⹈歊⍌⹎㱐㙒答", num));
    }

    internal byte[] method_12()
    {
        return this.byte_1;
    }

    internal byte[] method_13()
    {
        return this.byte_2;
    }

    internal Class425 method_14()
    {
        return this.class425_0;
    }
}

