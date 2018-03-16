using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class463
{
    private static Hashtable hashtable_0 = new Hashtable();
    private static Hashtable hashtable_1 = new Hashtable();
    private static Hashtable hashtable_2 = new Hashtable();
    private static Hashtable hashtable_3 = new Hashtable();
    private static Hashtable hashtable_4 = new Hashtable();
    private static Hashtable hashtable_5 = new Hashtable();

    static Class463()
    {
        Class791.smethod_0(new object[] { BookmarkStart.b("紭夯就匳娵崷瘹夻䠽┿⹁", 8), ListLevelsType.SingleLevel, BookmarkStart.b("挭䔯帱䀳張吷弹䨻嬽ⰿ", 8), ListLevelsType.MultiLevel, BookmarkStart.b("昭䤯倱䘳張尷眹䤻刽㐿⭁⡃⍅㹇⽉⁋", 8), ListLevelsType.HybridMultiLevel }, hashtable_4, hashtable_5);
        Class791.smethod_0(new object[] { BookmarkStart.b("稭儯倱", 8), FollowCharacterType.Tab, BookmarkStart.b("紭䀯匱圳匵", 8), FollowCharacterType.Space, BookmarkStart.b("怭弯䘱尳張嘷崹", 8), FollowCharacterType.Nothing }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { BookmarkStart.b("䈭唯吱䀳", 8), ListNumberAlignment.Left, BookmarkStart.b("䴭唯就䀳匵䨷", 8), ListNumberAlignment.Center, BookmarkStart.b("尭夯唱尳䈵", 8), ListNumberAlignment.Right }, hashtable_0, hashtable_1);
    }

    internal static ListNumberAlignment smethod_0(string A_0)
    {
        return (ListNumberAlignment) Class791.smethod_3(hashtable_0, A_0, ListNumberAlignment.Left);
    }

    internal static string smethod_1(ListNumberAlignment A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, "");
    }

    internal static FollowCharacterType smethod_2(string A_0)
    {
        return (FollowCharacterType) Class791.smethod_3(hashtable_2, A_0, FollowCharacterType.Tab);
    }

    internal static string smethod_3(FollowCharacterType A_0)
    {
        return (string) Class791.smethod_3(hashtable_3, A_0, "");
    }

    internal static ListLevelsType smethod_4(string A_0)
    {
        return (ListLevelsType) Class791.smethod_3(hashtable_4, A_0, ListLevelsType.HybridMultiLevel);
    }

    internal static string smethod_5(ListLevelsType A_0)
    {
        return (string) Class791.smethod_3(hashtable_5, A_0, "");
    }
}

