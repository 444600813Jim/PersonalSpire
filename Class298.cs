using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

[DefaultMember("Item")]
internal class Class298 : Dictionary<string, Dictionary<string, string>>
{
    private Regex regex_0 = new Regex(BookmarkStart.b("့Թ;䴽┿⹁⅃╅㱇╉㹋灍硏浑湓繕杗恙ݛ]䱟ᥡ㥣䵥䅧䙩卫䝭婯䵱嵳⩵ͷ剹䍻䑽꡿북뢃낍쮏첑겕얗놙떛꒝龟誡鮣骥\udea7\ucba9삫\udbad\ud5af貱얷膹閽療﯃郋돍", 0x12), RegexOptions.Compiled | RegexOptions.IgnoreCase);
    public const string string_0 = @"(?<selector>(?:(?:[^,{]+),?)*?)\{(?:(?<name>[^}:]+):?(?<value>[^};]+);?)*?\}";
    public const string string_1 = "(?<!\")\\/\\*.+?\\*\\/(?!\")";
    private const string string_2 = "selector";
    private const string string_3 = "name";
    private const string string_4 = "value";

    public void method_0(string A_0)
    {
        this.method_1(File.ReadAllText(A_0));
    }

    public void method_1(string A_0)
    {
        int num = 6;
        if (!string.IsNullOrEmpty(A_0) && ((A_0 = A_0.Trim()).Length != 0))
        {
            A_0 = A_0.Replace(BookmarkStart.b("ါ༭ᴯἱ", num), "").Replace(BookmarkStart.b("ī̭ฯ", num), "").Trim();
            string pattern = BookmarkStart.b("圫爭帯ᠱ䤳", num);
            string replacement = BookmarkStart.b("圫匭", num);
            foreach (Match match in this.regex_0.Matches(Regex.Replace(Regex.Replace(A_0, pattern, replacement), BookmarkStart.b("Ыᄭయጱᘳἵ搷ᔹ总ᐽ渿楁筃ᩅ扇ᙉ捋晍潏獑癓罕", num), string.Empty)))
            {
                if ((((match != null) && (match.Groups != null)) && ((match.Groups[BookmarkStart.b("弫䬭尯圱圳䈵圷䠹", num)] != null) && (match.Groups[BookmarkStart.b("弫䬭尯圱圳䈵圷䠹", num)].Captures != null))) && ((match.Groups[BookmarkStart.b("弫䬭尯圱圳䈵圷䠹", num)].Captures[0] != null) && !string.IsNullOrEmpty(match.Groups[BookmarkStart.b("弫䬭尯圱圳䈵圷䠹", num)].Value)))
                {
                    string key = match.Groups[BookmarkStart.b("弫䬭尯圱圳䈵圷䠹", num)].Captures[0].Value.Trim();
                    Dictionary<string, string> dictionary = null;
                    if (!base.TryGetValue(key, out dictionary))
                    {
                        dictionary = new Dictionary<string, string>();
                    }
                    for (int i = 0; i < match.Groups[BookmarkStart.b("䈫伭崯圱", num)].Captures.Count; i++)
                    {
                        string str5 = match.Groups[BookmarkStart.b("䈫伭崯圱", num)].Captures[i].Value;
                        string str2 = match.Groups[BookmarkStart.b("娫伭尯䜱儳", num)].Captures[i].Value;
                        if (!string.IsNullOrEmpty(str5) && !string.IsNullOrEmpty(str2))
                        {
                            str5 = smethod_0(str5);
                            if (str5 == BookmarkStart.b("䨫䄭帯䘱ᤳ倵夷圹唻刽㤿", num))
                            {
                                str2 = smethod_0(str2.Split(new char[] { ',' })[0]);
                            }
                            else
                            {
                                str2 = smethod_0(str2);
                            }
                            if (!string.IsNullOrEmpty(str5) && !string.IsNullOrEmpty(str2))
                            {
                                dictionary[str5] = str2;
                            }
                        }
                    }
                    string[] strArray2 = key.Split(new char[] { ',' });
                    if (strArray2.Length == 1)
                    {
                        string str6 = smethod_1(key);
                        base[str6] = dictionary;
                    }
                    else
                    {
                        foreach (string str4 in strArray2)
                        {
                            string str = str4.Trim();
                            if (str.Length != 0)
                            {
                                str = smethod_1(str);
                                Dictionary<string, string> dictionary2 = null;
                                bool flag = false;
                                if (!base.TryGetValue(str, out dictionary2))
                                {
                                    dictionary2 = new Dictionary<string, string>();
                                    flag = true;
                                }
                                smethod_2(dictionary, dictionary2);
                                if (flag)
                                {
                                    base[str] = dictionary2;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private Dictionary<string, string> method_2(XmlNode A_0, Dictionary<string, Dictionary<string, string>> A_1, string A_2, string A_3)
    {
        int num = 1;
        Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> dictionary2 = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> dictionary3 = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> dictionary4 = new Dictionary<string, Dictionary<string, string>>();
        char[] separator = new char[] { ' ' };
        foreach (KeyValuePair<string, Dictionary<string, string>> pair in A_1)
        {
            Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
            string key = string.Empty;
            if (!pair.Key.ToLower().EndsWith(BookmarkStart.b("ܦ", num) + A_0.LocalName.ToLower()) && !pair.Key.ToLower().EndsWith(BookmarkStart.b("ᤦ", num) + A_0.LocalName.ToLower()))
            {
                if (!string.IsNullOrEmpty(A_2))
                {
                    foreach (string str2 in A_2.Split(separator))
                    {
                        if (pair.Key.ToLower().EndsWith(BookmarkStart.b("द", num) + str2.ToLower()))
                        {
                            key = pair.Key.ToLower().Replace(BookmarkStart.b("द", num) + str2.ToLower(), string.Empty).TrimEnd(separator);
                            if (!dictionary2.ContainsKey(key))
                            {
                                smethod_2(pair.Value, dictionary5);
                                dictionary2.Add(key, dictionary5);
                            }
                            else
                            {
                                smethod_2(pair.Value, dictionary2[key]);
                            }
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(A_3) && pair.Key.ToLower().EndsWith(BookmarkStart.b("Ц", num) + A_3.ToLower()))
                {
                    key = pair.Key.ToLower().Replace(BookmarkStart.b("Ц", num) + A_3.ToLower(), string.Empty).TrimEnd(separator);
                    if (!dictionary3.ContainsKey(key))
                    {
                        smethod_2(pair.Value, dictionary5);
                        dictionary3.Add(key, dictionary5);
                    }
                    else
                    {
                        smethod_2(pair.Value, dictionary3[key]);
                    }
                }
            }
            else
            {
                key = pair.Key.ToLower().Replace(A_0.LocalName.ToLower(), string.Empty).TrimEnd(new char[] { '>' }).TrimEnd(separator);
                if (!dictionary.ContainsKey(key))
                {
                    smethod_2(pair.Value, dictionary5);
                    dictionary.Add(key, dictionary5);
                }
                else
                {
                    smethod_2(pair.Value, dictionary[key]);
                }
            }
        }
        this.method_3(A_0, dictionary, ref dictionary4);
        this.method_3(A_0, dictionary2, ref dictionary4);
        this.method_3(A_0, dictionary3, ref dictionary4);
        if ((dictionary4.Count > 0) && dictionary4.ContainsKey(""))
        {
            return dictionary4[""];
        }
        return new Dictionary<string, string>();
    }

    private void method_3(XmlNode A_0, Dictionary<string, Dictionary<string, string>> A_1, ref Dictionary<string, Dictionary<string, string>> A_2)
    {
        int num = 9;
        if (A_1.Count > 0)
        {
            XmlNode parentNode = A_0;
            char[] trimChars = new char[] { ' ' };
            while (!(parentNode.ParentNode is XmlDocument))
            {
                string str = string.Empty;
                string str2 = string.Empty;
                foreach (XmlAttribute attribute in (parentNode as XmlElement).Attributes)
                {
                    if (attribute.Name.ToLower() == BookmarkStart.b("䰮崰刲䘴䐶", num))
                    {
                        str = attribute.Value;
                    }
                    else if (attribute.Name.ToLower() == BookmarkStart.b("䘮唰", num))
                    {
                        str2 = attribute.Value;
                    }
                }
                foreach (KeyValuePair<string, Dictionary<string, string>> pair in A_1)
                {
                    if (pair.Key.EndsWith(BookmarkStart.b("༮", num) + parentNode.LocalName.ToLower()) || pair.Key.EndsWith(BookmarkStart.b("ᄮ", num) + parentNode.LocalName.ToLower()))
                    {
                        string str4 = pair.Key.Replace(parentNode.LocalName.ToLower(), string.Empty).TrimEnd(trimChars).Replace(BookmarkStart.b("ᄮ", num) + parentNode.LocalName.ToLower(), string.Empty).TrimEnd(trimChars);
                        this.method_4(str4, parentNode, A_1, str, str2, pair.Value, ref A_2);
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        string[] strArray = str.Split(trimChars);
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            if (pair.Key.EndsWith(BookmarkStart.b("Į", num) + strArray[i].ToLower()))
                            {
                                string str3 = pair.Key.Replace(BookmarkStart.b("Į", num) + strArray[i].ToLower(), string.Empty).TrimEnd(trimChars);
                                this.method_4(str3, parentNode, A_1, str, str2, pair.Value, ref A_2);
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(str2) && pair.Key.EndsWith(BookmarkStart.b("మ", num) + str2))
                    {
                        string str5 = pair.Key.Replace(BookmarkStart.b("మ", num) + str2, string.Empty).TrimEnd(trimChars);
                        this.method_4(str5, parentNode, A_1, str, str2, pair.Value, ref A_2);
                    }
                }
                parentNode = parentNode.ParentNode;
            }
        }
    }

    private void method_4(string A_0, XmlNode A_1, Dictionary<string, Dictionary<string, string>> A_2, string A_3, string A_4, Dictionary<string, string> A_5, ref Dictionary<string, Dictionary<string, string>> A_6)
    {
        if (A_5.Count != 0)
        {
            if (A_0 != "")
            {
                this.method_4("", A_1, A_2, A_3, A_4, this.method_2(A_1, A_2, A_3, A_4), ref A_6);
            }
            else if (!A_6.ContainsKey(A_0))
            {
                A_6.Add(A_0, A_5);
            }
            else
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>(A_5);
                smethod_2(dictionary, A_6[A_0]);
            }
        }
    }

    public string method_5(XmlNode A_0)
    {
        int num = 7;
        if (!(A_0 is XmlElement))
        {
            return string.Empty;
        }
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        XmlElement element = A_0 as XmlElement;
        string key = element.LocalName.ToLower();
        if (base.ContainsKey(key))
        {
            smethod_2(base[key], dictionary);
        }
        string str = null;
        foreach (XmlAttribute attribute in element.Attributes)
        {
            if (attribute.Name.ToLower() == BookmarkStart.b("丬䌮倰䀲䘴", num))
            {
                str = attribute.Value;
            }
        }
        if (!string.IsNullOrEmpty(str))
        {
            foreach (string str5 in str.Trim().Split(new char[] { ' ' }))
            {
                string str4 = str5.Trim();
                if (str4.Length > 0)
                {
                    str4 = BookmarkStart.b("̬", num) + str4;
                    if (base.ContainsKey(str4))
                    {
                        smethod_2(base[str4], dictionary);
                    }
                    str4 = key + str4;
                    if (base.ContainsKey(str4))
                    {
                        smethod_2(base[str4], dictionary);
                    }
                }
            }
        }
        string str2 = element.GetAttribute(BookmarkStart.b("䐬䬮", num));
        if (!string.IsNullOrEmpty(str2) && ((str2 = str2.Trim()).Length > 0))
        {
            string str3 = BookmarkStart.b("ฬ", num) + str2;
            if (base.ContainsKey(str3))
            {
                smethod_2(base[str3], dictionary);
            }
            str3 = key + str3;
            if (base.ContainsKey(str3))
            {
                smethod_2(base[str3], dictionary);
            }
        }
        smethod_2(this.method_2(A_0, this, str, str2), dictionary);
        if (dictionary.Count <= 0)
        {
            return string.Empty;
        }
        StringBuilder builder = new StringBuilder();
        foreach (KeyValuePair<string, string> pair in dictionary)
        {
            builder.AppendFormat(BookmarkStart.b("嘬Ἦ䰰लᔴ䰶࠸䘺ؼ", num), pair.Key, pair.Value);
        }
        return builder.ToString();
    }

    public static string smethod_0(string A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        char[] trimChars = new char[] { '\r', '\n', '\f', '\t', '\v' };
        return A_0.Trim(trimChars).Trim();
    }

    private static string smethod_1(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { '.', '#' });
        if (strArray[0].Length <= 0)
        {
            return A_0;
        }
        int num = A_0.Length - strArray[0].Length;
        if (num > 0)
        {
            return (strArray[0].ToLower() + A_0.Substring(strArray[0].Length));
        }
        return strArray[0].ToLower();
    }

    private static void smethod_2(Dictionary<string, string> A_0, Dictionary<string, string> A_1)
    {
        foreach (KeyValuePair<string, string> pair in A_0)
        {
            A_1[pair.Key] = pair.Value;
        }
    }
}

