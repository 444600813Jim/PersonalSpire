using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class1149
{
    private static readonly ArrayList arrayList_0 = new ArrayList(new int[] { 230, 270, 0xeb, 240 });
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();

    static Class1149()
    {
        Class791.smethod_0(new object[] { 
            0, BookmarkStart.b("昱崳嬵崷䤹᰻瀽┿㕁摃ᑅ❇❉ⵋ⁍", 12), 1, BookmarkStart.b("猱䘳張夷嘹", 12), 2, BookmarkStart.b("焱嬳䌵䨷匹夻䰽怿ు⅃ㅅ", 12), 3, BookmarkStart.b("愱䴳嬵娷唹倻", 12), 4, BookmarkStart.b("稱儳娵丷弹䠻圽⌿⍁", 12), 5, BookmarkStart.b("焱嬳䌵䨷匹夻䰽", 12), 6, BookmarkStart.b("昱夳䔵ᠷ根儻倽", 12), 7, BookmarkStart.b("稱儳娵丷", 12), 
            8, BookmarkStart.b("簱儳䄵ᠷ挹医䰽⬿", 12), 9, BookmarkStart.b("愱䴳䔵䰷弹儻", 12), 10, BookmarkStart.b("攱崳堵強帹唻倽✿ㅁ", 12), 11, BookmarkStart.b("缱朳ᘵ男匹刻崽⠿ⵁ", 12), 12, BookmarkStart.b("瀱唳䈵夷吹嬻", 12), 13, BookmarkStart.b("愱崳嬵欷伹刻", 12), 14, BookmarkStart.b("戱礳張嘷崹瀻圽ᔿ", 12), 15, BookmarkStart.b("缱朳ᘵ缷唹䠻嘽⤿⅁", 12), 
            0x10, BookmarkStart.b("瘱嬳䈵䴷圹", 12), 0x11, BookmarkStart.b("愱崳嬵瀷弹唻", 12), 0x12, BookmarkStart.b("缱崳堵強瘹唻欽", 12), 0x13, BookmarkStart.b("缱崳堵嬷刹医", 12), 20, BookmarkStart.b("由䄳娵儷圹", 12), 0x15, BookmarkStart.b("焱儳堵䰷伹主䜽", 12), 0x16, BookmarkStart.b("猱娳儵䬷嬹刻弽怿ు⅃ㅅ", 12), 0x17, BookmarkStart.b("焱嬳䐵尷匹崻ḽ฿❁㍃", 12), 
            0x18, BookmarkStart.b("缱唳堵強嬹倻", 12), 0x19, BookmarkStart.b("縱唳䈵倷嬹", 12), 0x1a, BookmarkStart.b("愱䴳娵帷嬹夻倽", 12), 0x1b, BookmarkStart.b("搱䘳張嘷帹崻", 12), 0x1c, BookmarkStart.b("怱唳圵丷匹", 12), 0x1d, BookmarkStart.b("愱尳䐵䴷丹唻", 12), 30, BookmarkStart.b("愱儳堵尷吹䔻弽", 12), 0x1f, BookmarkStart.b("由唳䌵䰷嬹儻圽", 12), 
            0x20, BookmarkStart.b("昱䄳堵強嬹", 12), 0x21, BookmarkStart.b("眱䜳䈵䨷嬹刻夽┿⹁⭃晅േ⹉⥋㵍⍏㍑", 12), 0x22, BookmarkStart.b("猱䘳張夷嘹᰻欽⸿⭁❃⥅ⱇ⽉汋͍͏", 12), 0x23, BookmarkStart.b("昱唳帵圷圹崻", 12)
         }, hashtable_0, hashtable_1);
    }

    private Class1149()
    {
    }

    internal static string smethod_0(int A_0)
    {
        return (string) Class791.smethod_3(hashtable_0, A_0, BookmarkStart.b("攰娲場制䨸ᬺ猼娾㙀捂ᝄ⡆⑈⩊⍌", 11));
    }

    internal static int smethod_1(string A_0)
    {
        return (int) Class791.smethod_3(hashtable_1, A_0, 0);
    }

    internal static bool smethod_2(Class13 A_0)
    {
        foreach (ConditionalFormattingCode code in A_0.method_25().Keys)
        {
            CharacterFormat runPr = A_0.method_25()[code].RunPr;
            if (runPr != null)
            {
                foreach (int num in arrayList_0)
                {
                    if (runPr.method_6(num) && (Class791.smethod_6(hashtable_1, runPr.method_31(num)) == null))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}

