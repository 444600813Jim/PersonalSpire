using Spire.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;

internal class Class511
{
    private static List<string> list_0 = new List<string> { BookmarkStart.b("缫席夯䀱儳ᠵ簷唹弻栽⤿❁㍃⍅㩇摉ᭋ㹍㙏", 6), BookmarkStart.b("缫席夯䀱儳ᠵ簷唹弻栽⤿❁㍃⍅㩇摉ੋ⅍≏㽑❓", 6), BookmarkStart.b("缫席夯䀱儳ᠵ眷尹娻圽⌿❁ቃ⽅ⵇ㵉⥋㱍繏ᑑ㭓⑕㕗⥙", 6), BookmarkStart.b("缫席夯䀱儳ᠵ眷尹娻圽⌿❁ቃ⽅ⵇ㵉⥋㱍繏ፑ❓♕", 6) };

    internal static bool smethod_0(InternalLicense A_0)
    {
        if (((A_0 != null) && ((A_0.LicenseType & LicenseType.Runtime) == LicenseType.Runtime)) && ((A_0.AssemblyList != null) && (A_0.AssemblyList.Length != 0)))
        {
            foreach (string str in A_0.AssemblyList)
            {
                if (list_0.Contains(str))
                {
                    return true;
                }
            }
        }
        return false;
    }

    internal static LicenseType smethod_1(License A_0)
    {
        if (((A_0 == null) || (A_0.GetType() != typeof(LicenseInfo))) || ((LicenseInfo) A_0).IsUpdateRightExpired)
        {
            return LicenseType.None;
        }
        if (((LicenseInfo) A_0).Type != LicenseType.Runtime)
        {
            return LicenseType.Demo;
        }
        return LicenseType.Runtime;
    }
}

