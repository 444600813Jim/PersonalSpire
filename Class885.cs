using Spire.Doc;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal static class Class885
{
    private static Regex regex_0 = new Regex(BookmarkStart.b("حᠯ椱ᤳᴵ攷Թ总娽欿橁ᡃ桅恇ᙉ⡋敍祏筑歓罕灗牙[瑝ᱟ㹡䭣佥䁧ㅩ䅫䕭ⵯ䵱⡳ት卷剹⁻偽꡿\ude81\ue083궅ꆇꎉ뎋Ɥ릏릑붓", 8));
    private static Regex regex_1 = new Regex(BookmarkStart.b("爭ᠯᨱᰳ洵ᔷᄹ愻Ľ᰿♁潃湅ᑇ摉摋ቍ㑏祑絓罕杗獙瑛癝㱟䥡ᡣ㩥䕧䍩䑫㕭嵯奱⥳䥵⑷ṹ坻噽\udc7f\uac81것\uda85\uec87ꆉꖋꞍ꾏뮑붓붕놗욙떛", 8));
    private static Regex regex_2 = new Regex(BookmarkStart.b("爭ᠯ椱ᤳᴵ攷Թ总娽欿橁ᡃ桅恇ᙉ⡋敍祏筑歓੕煗", 8));
    private static Regex regex_3 = new Regex(BookmarkStart.b("حᠯ椱ᤳᴵ攷Թ总娽欿橁ᡃ桅恇ᙉ⡋敍祏筑歓罕灗牙[畝ᱟ㹡䥣佥䁧ㅩ䅫䕭ⵯ䵱⡳ት卷剹⁻偽꡿\ude81\ue083궅ꆇꎉ뎋Ɥ릏뢑붓", 8));
    private static Regex regex_4 = new Regex(BookmarkStart.b("爭᤯渱ᰳ䨵搷ጹᐻ戽␿楁汃ᩅ晇扉။⩍筏筑絓楕煗♙瑛ɝџ䥡䱣㩥䙧䉩に੭孯孱嵳䥵具♹呻", 8));

    internal static bool smethod_0(string A_0, out double A_1)
    {
        A_0 = A_0.Replace(BookmarkStart.b("椱", 12), BookmarkStart.b("ᨱ", 12)).Replace(BookmarkStart.b("漱", 12), BookmarkStart.b("ᬱ", 12)).Replace(BookmarkStart.b("䤱", 12), BookmarkStart.b("ᨱ", 12)).Replace(BookmarkStart.b("伱", 12), BookmarkStart.b("ᬱ", 12)).Replace(BookmarkStart.b("ሱ", 12), string.Empty);
        A_1 = 0.0;
        if (regex_4.IsMatch(A_0))
        {
            return false;
        }
        while (true)
        {
            int num = 0;
            if (!regex_0.IsMatch(A_0))
            {
                num++;
            }
            else
            {
                A_0 = regex_0.Replace(A_0, new MatchEvaluator(Class885.smethod_1));
            }
            if (regex_1.IsMatch(A_0))
            {
                A_0 = regex_1.Replace(A_0, new MatchEvaluator(Class885.smethod_2));
            }
            else
            {
                num++;
            }
            if (regex_2.IsMatch(A_0))
            {
                A_0 = regex_2.Replace(A_0, new MatchEvaluator(Class885.smethod_3));
            }
            else
            {
                num++;
            }
            if (regex_3.Match(A_0).Value == A_0)
            {
                return double.TryParse(regex_3.Replace(A_0, new MatchEvaluator(Class885.smethod_2)), out A_1);
            }
            if (num == 3)
            {
                return false;
            }
        }
    }

    private static string smethod_1(Match A_0)
    {
        int num = 0;
        string str = A_0.Value;
        bool flag = true;
        foreach (char ch in str)
        {
            if (ch == '-')
            {
                flag = !flag;
            }
        }
        string[] strArray = str.Replace(BookmarkStart.b("థ̧", num), BookmarkStart.b("థ", num)).Replace(BookmarkStart.b("థԧ", num), BookmarkStart.b("థ", num)).Replace(BookmarkStart.b("थ̧", num), BookmarkStart.b("थ", num)).Replace(BookmarkStart.b("थԧ", num), BookmarkStart.b("थ", num)).Replace(BookmarkStart.b("థ", num), BookmarkStart.b("ਥȧ", num)).Replace(BookmarkStart.b("थ", num), BookmarkStart.b("ਥܧ", num)).Split(new char[] { ',' });
        double num3 = (Convert.ToDouble(strArray[0]) >= 0.0) ? Convert.ToDouble(strArray[0]) : -Convert.ToDouble(strArray[0]);
        for (int i = 1; i < strArray.Length; i++)
        {
            if (strArray[i] != "")
            {
                switch (strArray[i][0])
                {
                    case '*':
                        num3 *= Convert.ToDouble(strArray[i].Substring(1, strArray[i].Length - 1));
                        break;

                    case '/':
                        num3 /= Convert.ToDouble(strArray[i].Substring(1, strArray[i].Length - 1));
                        break;
                }
            }
        }
        if (!flag)
        {
            num3 = -num3;
        }
        if (num3 < 0.0)
        {
            return num3.ToString();
        }
        return (BookmarkStart.b("ഥ", num) + num3.ToString());
    }

    private static string smethod_2(Match A_0)
    {
        int num = 0x13;
        string[] strArray = A_0.Value.Replace(BookmarkStart.b("ᄸ", 0x13), "").Replace(BookmarkStart.b("း", 0x13), "").Replace(BookmarkStart.b("ሸ်", 0x13), BookmarkStart.b("ሸ", 0x13)).Replace(BookmarkStart.b("ሸᘺ", 0x13), BookmarkStart.b("ᐸ", 0x13)).Replace(BookmarkStart.b("ᐸ်", 0x13), BookmarkStart.b("ᐸ", 0x13)).Replace(BookmarkStart.b("ᐸᘺ", 0x13), BookmarkStart.b("ሸ", 0x13)).Replace(BookmarkStart.b("ሸ", 0x13), BookmarkStart.b("ᔸ်", 0x13)).Replace(BookmarkStart.b("ᐸ", 0x13), BookmarkStart.b("ᔸᘺ", 0x13)).Split(new char[] { ',' });
        double num2 = 0.0;
        foreach (string str2 in strArray)
        {
            if (str2 != "")
            {
                num2 += Convert.ToDouble(str2);
            }
        }
        if (num2 < 0.0)
        {
            return num2.ToString();
        }
        return (BookmarkStart.b("ሸ", num) + num2.ToString());
    }

    private static string smethod_3(Match A_0)
    {
        return A_0.Value.Substring(1, A_0.Value.Length - 2);
    }
}

