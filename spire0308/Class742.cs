using Spire.Doc;
using System;
using System.Text;

internal class Class742
{
    public static bool smethod_0(string A_0)
    {
        int num = 6;
        if (((0 > A_0.IndexOf(BookmarkStart.b("缫圭崯倱嬳娵", 6))) && (0 > A_0.IndexOf(BookmarkStart.b("笫䬭刯嘱崳堵強䤹", num)))) && (0 > A_0.IndexOf(BookmarkStart.b("笫䜭帯唱倳張嘷崹伻", num))))
        {
            return (0 <= A_0.IndexOf(BookmarkStart.b("栫䜭帯唱嘳圵䰷䤹", num)));
        }
        return true;
    }

    public static string smethod_1(string A_0)
    {
        int num = 6;
        if (A_0 == BookmarkStart.b("搫䬭尯䐱", 6))
        {
            return BookmarkStart.b("洫尭夯匱堳", num);
        }
        if (A_0 == BookmarkStart.b("砫䌭䌯ሱ昳嬵嘷", num))
        {
            return BookmarkStart.b("砫䜭崯圱䜳ᘵ瘷弹䬻ḽሿⵁ⥃❅♇", num);
        }
        if (A_0 == BookmarkStart.b("愫紭ု愱儳䐵儷尹", num))
        {
            return BookmarkStart.b("砫䜭崯圱䜳ᘵ瘷弹䬻ḽሿⵁ⥃❅♇", num);
        }
        if (A_0 == BookmarkStart.b("愫紭ု愱唳堵䬷ᨹ漻嬽㈿⭁≃", num))
        {
            return BookmarkStart.b("愫䜭匯䀱嬳䔵圷尹䠻ḽጿ⍁⩃㕅桇᥉⥋㱍㥏㑑", num);
        }
        if (A_0 == BookmarkStart.b("漫䄭䔯䀱崳匵䨷", num))
        {
            return BookmarkStart.b("漫䄭䔯䀱崳匵䨷ᨹ爻嬽㜿", num);
        }
        return A_0;
    }

    public static char smethod_2(char A_0)
    {
        if (!smethod_4(A_0))
        {
            return A_0;
        }
        return (char) (A_0 - 0xf000);
    }

    public static string smethod_3(string A_0)
    {
        StringBuilder builder = new StringBuilder();
        foreach (char ch in A_0)
        {
            builder.Append(smethod_2(ch));
        }
        return builder.ToString();
    }

    public static bool smethod_4(char A_0)
    {
        return ((A_0 >= 0xf020) && (A_0 <= 0xf0ff));
    }

    public static bool smethod_5(char A_0)
    {
        return ((A_0 >= ' ') && (A_0 <= '\x00ff'));
    }

    public static char smethod_6(char A_0)
    {
        if (!smethod_5(A_0))
        {
            return A_0;
        }
        return (char) (A_0 + 0xf000);
    }
}

