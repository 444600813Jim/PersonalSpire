using System;
using System.Collections;

internal class Class1032 : IComparer
{
    private static readonly SortedList sortedList_0 = new SortedList();
    private static readonly string[] string_0 = new string[] { 
        BookmarkStart.b("䔵儷䀹夻", 0x10), BookmarkStart.b("䄵儷帹䠻嘽", 0x10), BookmarkStart.b("帵崷匹嬻嘽㐿", 0x10), BookmarkStart.b("嬵夷䠹嬻圽⸿", 0x10), BookmarkStart.b("嬵夷䠹嬻圽⸿潁ぃ⥅㡇", 0x10), BookmarkStart.b("嬵夷䠹嬻圽⸿潁㙃⽅⽇≉㡋", 0x10), BookmarkStart.b("嬵夷䠹嬻圽⸿潁⡃⍅⹇㹉", 0x10), BookmarkStart.b("嬵夷䠹嬻圽⸿潁♃⥅㱇㹉⍋⍍", 0x10), BookmarkStart.b("䈵崷䈹䠻ጽ⤿ⱁ⁃⍅♇㹉", 0x10), BookmarkStart.b("䈵崷䈹䠻ጽℿ⹁ⵃⅅ♇", 0x10), BookmarkStart.b("䘵夷崹夻ጽ∿ぁ⅃❅⍇杉⹋⭍㙏㵑♓㍕", 0x10), BookmarkStart.b("䘵夷崹夻ጽ∿ぁ⅃❅⍇杉╋⁍⍏㭑こ㍕", 0x10), BookmarkStart.b("䘵夷崹夻ጽ∿ぁ⅃❅⍇杉ⵋ⡍⑏㝑♓", 0x10), BookmarkStart.b("娵儷吹夻ጽ⠿❁ⵃⅅ⁇㹉", 0x10), BookmarkStart.b("䄵儷帹医䤽㌿", 0x10), BookmarkStart.b("夵䨷䨹吻弽⸿ㅁ", 0x10), 
        BookmarkStart.b("䄵䨷匹䠻圽⸿╁楃⭅❇⹉⥋", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁㝃㉅ㅇ♉⥋", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁㍃⽅ⱇ㹉⑋", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁❃⥅⑇╉㹋", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁ぃ⥅㡇", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁ぃ⥅㡇杉㽋㩍⥏㹑ㅓ", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁ぃ⥅㡇杉㭋❍㑏♑㱓", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁ぃ⥅㡇杉⽋⅍㱏㵑♓", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁㙃⽅⽇≉㡋", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁㙃⽅⽇≉㡋捍⍏♑ⵓ㩕㵗", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁㙃⽅⽇≉㡋捍❏㭑こ≕し", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁㙃⽅⽇≉㡋捍㍏㵑㡓㥕⩗", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁⡃⍅⹇㹉", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁⡃⍅⹇㹉態㵍⑏⭑㡓㍕", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁⡃⍅⹇㹉態㥍㥏㙑⁓㹕", 0x10), 
        BookmarkStart.b("吵圷䠹堻嬽㈿潁⡃⍅⹇㹉態ⵍ㽏㹑㭓⑕", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁♃⥅㱇㹉⍋⍍", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁♃⥅㱇㹉⍋⍍絏⅑⁓⽕㑗㽙", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁♃⥅㱇㹉⍋⍍絏║㵓㉕ⱗ㉙", 0x10), BookmarkStart.b("吵圷䠹堻嬽㈿潁♃⥅㱇㹉⍋⍍絏ㅑ㭓㩕㝗⡙", 0x10), BookmarkStart.b("䘵夷帹堻圽⸿╁", 0x10), BookmarkStart.b("䘵夷帹堻圽⸿╁楃㉅❇㩉", 0x10), BookmarkStart.b("䘵夷帹堻圽⸿╁楃㑅ⅇⵉ⑋㩍", 0x10), BookmarkStart.b("䘵夷帹堻圽⸿╁楃⩅ⵇⱉ㡋", 0x10), BookmarkStart.b("䘵夷帹堻圽⸿╁楃⑅❇㹉㡋⅍㵏", 0x10), BookmarkStart.b("倵圷吹䠻", 0x10), BookmarkStart.b("倵圷吹䠻ጽ☿⍁⥃⽅⑇㍉", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㌿⭁㹃⍅", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㜿❁ⵃⅅ⁇㹉", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㌿㙁㵃⩅ⵇ", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㘿⍁㙃⽅⥇⑉㡋", 0x10), 
        BookmarkStart.b("䈵崷䈹䠻ጽ␿❁❃⥅㩇⭉㡋❍㽏㱑", 0x10), BookmarkStart.b("䈵崷䈹䠻ጽ㐿ぁ╃⡅㭇ⱉ⍋㱍㵏", 0x10), BookmarkStart.b("娵崷丹䠻嬽㈿潁㝃㙅⥇⥉╋⁍㝏", 0x10), BookmarkStart.b("䀵崷䠹䠻圽⌿⍁⡃歅⥇♉╋⥍㹏", 0x10), BookmarkStart.b("唵圷嘹医䰽", 0x10), BookmarkStart.b("吵夷夹圻夽㈿ⵁㅃ⡅ⱇ", 0x10), BookmarkStart.b("吵夷夹圻夽㈿ⵁㅃ⡅ⱇ杉⽋⅍㱏㵑♓", 0x10), BookmarkStart.b("刵儷䤹䰻刽ℿ㭁", 0x10), BookmarkStart.b("娵儷䤹䠻ጽ㌿㙁㵃⩅ⵇ", 0x10), BookmarkStart.b("娵儷䤹䠻ጽ㌿㙁㵃⩅ⵇ杉㡋㝍⁏㝑", 0x10), BookmarkStart.b("娵儷䤹䠻ጽ㌿㙁㵃⩅ⵇ杉╋⍍ㅏ㕑ㅓ", 0x10), BookmarkStart.b("娵儷䤹䠻ጽ㌿㙁㵃⩅ⵇ杉㱋⅍⍏㭑⁓㽕㝗㑙", 0x10), BookmarkStart.b("䔵䨷夹", 0x10)
     };

    static Class1032()
    {
        int num = 0;
        foreach (string str in string_0)
        {
            sortedList_0.Add(str, ++num);
        }
    }

    int IComparer.Compare(object A_0, object A_1)
    {
        string str = (string) A_0;
        string strB = (string) A_1;
        object obj2 = sortedList_0[str];
        object obj3 = sortedList_0[strB];
        int num = (obj2 != null) ? ((int) obj2) : 0x7fffffff;
        int num2 = (obj3 != null) ? ((int) obj3) : 0x7fffffff;
        if ((num == 0x7fffffff) && (num2 == 0x7fffffff))
        {
            return str.CompareTo(strB);
        }
        return num.CompareTo(num2);
    }
}

