using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

internal class Class327
{
    private static Dictionary<string, string> dictionary_0;
    private static Dictionary<string, string> dictionary_1;
    private Document document_0;
    private string string_0;
    private string string_1;
    private string string_2;

    static Class327()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(BookmarkStart.b("丮到倲倴夶䴸਺", 9), BookmarkStart.b("丮到倲倴夶䴸਺", 9));
        dictionary.Add(BookmarkStart.b("丮到倲倴夶䴸ऺ", 9), BookmarkStart.b("丮到倲倴夶䴸ऺ", 9));
        dictionary.Add(BookmarkStart.b("丮到倲倴夶䴸࠺", 9), BookmarkStart.b("丮到倲倴夶䴸࠺", 9));
        dictionary.Add(BookmarkStart.b("丮到倲倴夶䴸༺", 9), BookmarkStart.b("丮到倲倴夶䴸༺", 9));
        dictionary.Add(BookmarkStart.b("丮到倲倴夶䴸ฺ", 9), BookmarkStart.b("丮到倲倴夶䴸ฺ", 9));
        dictionary.Add(BookmarkStart.b("丮到倲倴夶䴸ഺ", 9), BookmarkStart.b("丮到倲倴夶䴸ഺ", 9));
        dictionary.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀牂", 9), BookmarkStart.b("䴮嘰Ȳ", 9));
        dictionary.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀煂", 9), BookmarkStart.b("䴮嘰Ĳ", 9));
        dictionary.Add(BookmarkStart.b("䬮倰䄲帴ض", 9), BookmarkStart.b("嬮0", 9));
        dictionary.Add(BookmarkStart.b("䬮倰䄲帴Զ", 9), BookmarkStart.b("嬮̰", 9));
        dictionary.Add(BookmarkStart.b("䤮帰弲头堶丸帺夼眾㡀㍂⁄㕆╈≊⍌⑎", 9), BookmarkStart.b("䤮帰弲头堶丸帺夼眾㡀㍂⁄㕆╈≊⍌⑎", 9));
        dictionary.Add(BookmarkStart.b("䜮䠰䌲倴䔶唸刺匼吾", 9), BookmarkStart.b("䜮䠰䌲倴䔶唸刺匼吾", 9));
        dictionary.Add(BookmarkStart.b("䌮堰吲崴䌶࠸", 9), BookmarkStart.b("䴮嘰Ȳ", 9));
        dictionary.Add(BookmarkStart.b("䌮堰吲崴䌶ସ", 9), BookmarkStart.b("䴮嘰Ĳ", 9));
        dictionary.Add(BookmarkStart.b("䄮帰崲倴", 9), "");
        dictionary.Add(BookmarkStart.b("嬮吰䬲䄴ض", 9), BookmarkStart.b("嬮0", 9));
        dictionary.Add(BookmarkStart.b("嬮吰䬲䄴Զ", 9), BookmarkStart.b("嬮̰", 9));
        dictionary_0 = dictionary;
        Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
        dictionary2.Add(BookmarkStart.b("丮到倲倴夶䴸਺", 9), BookmarkStart.b("丮到倲倴夶䴸਺", 9));
        dictionary2.Add(BookmarkStart.b("丮到倲倴夶䴸ऺ", 9), BookmarkStart.b("丮到倲倴夶䴸ऺ", 9));
        dictionary2.Add(BookmarkStart.b("丮到倲倴夶䴸࠺", 9), BookmarkStart.b("丮到倲倴夶䴸࠺", 9));
        dictionary2.Add(BookmarkStart.b("丮到倲倴夶䴸༺", 9), BookmarkStart.b("丮到倲倴夶䴸༺", 9));
        dictionary2.Add(BookmarkStart.b("丮到倲倴夶䴸ฺ", 9), BookmarkStart.b("丮到倲倴夶䴸ฺ", 9));
        dictionary2.Add(BookmarkStart.b("丮到倲倴夶䴸ഺ", 9), BookmarkStart.b("丮到倲倴夶䴸ഺ", 9));
        dictionary2.Add(BookmarkStart.b("䬮倰䄲帴ض", 9), BookmarkStart.b("䬮娰Ȳ", 9));
        dictionary2.Add(BookmarkStart.b("䬮倰䄲帴Զ", 9), BookmarkStart.b("䬮娰Ĳ", 9));
        dictionary2.Add(BookmarkStart.b("䤮帰弲头堶丸帺夼眾㡀㍂⁄㕆╈≊⍌⑎", 9), BookmarkStart.b("䤮帰弲紴嬶倸唺嘼", 9));
        dictionary2.Add(BookmarkStart.b("䜮䠰䌲倴䔶唸刺匼吾", 9), BookmarkStart.b("䜮崰娲嬴尶", 9));
        dictionary2.Add(BookmarkStart.b("䌮堰吲崴䌶࠸", 9), BookmarkStart.b("䌮䔰Ȳ", 9));
        dictionary2.Add(BookmarkStart.b("䌮堰吲崴䌶ସ", 9), BookmarkStart.b("䌮䔰Ĳ", 9));
        dictionary_1 = dictionary2;
    }

    public Class327(Document A_0)
    {
        this.document_0 = A_0;
    }

    public string method_0()
    {
        return this.string_0;
    }

    public void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    private string method_10(string A_0)
    {
        string str = string.Empty;
        if ((this.document_0.Settings.method_7() != null) && dictionary_0.ContainsKey(A_0))
        {
            string key = dictionary_0[A_0];
            if (this.document_0.Settings.method_7().ContainsKey(key))
            {
                string str3 = this.document_0.Settings.method_7()[key];
                if (dictionary_1.ContainsKey(str3))
                {
                    string str2 = dictionary_1[str3];
                    if (this.document_0.ColorScheme.ContainsKey(str2))
                    {
                        str = this.document_0.ColorScheme[str2];
                    }
                }
            }
        }
        return str;
    }

    public string method_2()
    {
        return this.string_1;
    }

    public void method_3(string A_0)
    {
        this.string_1 = A_0;
    }

    public string method_4()
    {
        return this.string_2;
    }

    public void method_5(string A_0)
    {
        this.string_2 = A_0;
    }

    public Color method_6()
    {
        string str = this.method_10(this.method_0());
        if (string.IsNullOrEmpty(str))
        {
            return Color.Empty;
        }
        if (!string.IsNullOrEmpty(this.method_2()))
        {
            int num2 = int.Parse(this.method_2(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return this.method_7(str, num2);
        }
        if (!string.IsNullOrEmpty(this.method_4()))
        {
            int num = int.Parse(this.method_4(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return this.method_8(str, num);
        }
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        this.method_9(str, ref num3, ref num4, ref num5);
        return Color.FromArgb(num3, num4, num5);
    }

    public Color method_7(string A_0, int A_1)
    {
        float num = ((float) A_1) / 255f;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        this.method_9(A_0, ref num2, ref num3, ref num4);
        num2 = (int) (num2 * num);
        num3 = (int) (num3 * num);
        num4 = (int) (num4 * num);
        return Color.FromArgb(num2, num3, num4);
    }

    public Color method_8(string A_0, int A_1)
    {
        float num = ((float) A_1) / 255f;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        this.method_9(A_0, ref num2, ref num3, ref num4);
        num2 = ((int) ((0xff - num2) * (1f - num))) + num2;
        num3 = ((int) ((0xff - num3) * (1f - num))) + num3;
        num4 = ((int) ((0xff - num4) * (1f - num))) + num4;
        return Color.FromArgb(num2, num3, num4);
    }

    private void method_9(string A_0, ref int A_1, ref int A_2, ref int A_3)
    {
        string s = A_0.Substring(0, 2);
        string str2 = A_0.Substring(2, 2);
        string str3 = A_0.Substring(4, 2);
        A_1 = int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        A_2 = int.Parse(str2, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        A_3 = int.Parse(str3, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
    }

    internal static string smethod_0(string A_0)
    {
        string key = string.Empty;
        if (dictionary_0.ContainsValue(A_0))
        {
            foreach (KeyValuePair<string, string> pair in dictionary_0)
            {
                if (A_0.Equals(pair.Value))
                {
                    key = pair.Key;
                }
            }
            if (dictionary_1.ContainsKey(key))
            {
                return dictionary_1[key];
            }
        }
        return "";
    }
}

