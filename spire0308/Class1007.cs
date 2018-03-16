using Spire.Doc;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

internal class Class1007
{
    private static Regex regex_0 = new Regex(BookmarkStart.b("栵挷䠹渻挽ᬿ╁̓ᭅፇ⡉๋ፍ౏⅑繓੕灗牙[㩝䭟䭡㡣ᕥ䉧䙩にᵭ婯婱⡳ት卷卹⁻ൽꩿ꺁\ud883\uf585ꊇꊉ킋뮏뮑좓늗욙떛몝", 0x10));

    public static Color smethod_0(string A_0) 
    {
        int num = 10;
        A_0 = A_0.Trim();
        Match match = regex_0.Match(A_0);
        if (match.Success)
        {
            return Color.FromArgb(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
        }
        if (A_0.ToLower() == BookmarkStart.b("匯䜱䘳䐵崷吹䠻崽⼿⹁⭃㑅", num))
        {
            return Color.Empty;
        }
        try
        {
            return ColorTranslator.FromHtml(A_0);
        }
        catch
        {
            return Color.Empty;
        }
    }
}

