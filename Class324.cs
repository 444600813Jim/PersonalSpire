using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class324 : IDisposable
{
    private Dictionary<string, Class326> dictionary_0;
    private Dictionary<string, Class325> dictionary_1;
    private Dictionary<string, Class325> dictionary_2;
    private Dictionary<string, Stream> dictionary_3;
    private Dictionary<short, string> dictionary_4;
    private Document document_0;

    public Class324(Document A_0)
    {
        this.document_0 = A_0;
        this.method_8();
    }

    public Dictionary<string, Class326> method_0()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, Class326>();
        }
        return this.dictionary_0;
    }

    public Dictionary<string, Class325> method_1()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<string, Class325>();
        }
        return this.dictionary_1;
    }

    public string method_10(string A_0, FontTypeHint A_1)
    {
        int num = 11;
        if (((A_0.Trim().Length != 0) && (A_0.StartsWith(BookmarkStart.b("尰刲弴堶䬸", num)) || A_0.StartsWith(BookmarkStart.b("尰娲嬴堶䬸", num)))) && ((this.method_5().ThemeFontLanguage != null) && (this.method_5().Themes != null)))
        {
            bool flag;
            string oldValue = (flag = A_0.StartsWith(BookmarkStart.b("尰刲弴堶䬸", num))) ? BookmarkStart.b("尰刲弴堶䬸", num) : BookmarkStart.b("尰娲嬴堶䬸", num);
            Dictionary<string, Class325> dictionary = flag ? this.method_2() : this.method_1();
            string str3 = A_0.Replace(oldValue, string.Empty);
            if (A_1 != FontTypeHint.Default)
            {
                return this.method_11(A_1, dictionary);
            }
            string str = str3;
            if (str != null)
            {
                if ((str == BookmarkStart.b("瀰䀲嘴帶倸", num)) || (str == BookmarkStart.b("礰爲嬴䐶倸", num)))
                {
                    return this.method_11(FontTypeHint.Default, dictionary);
                }
                if (str == BookmarkStart.b("琰刲䘴䌶砸䠺吼帾", num))
                {
                    return this.method_11(FontTypeHint.EastAsia, dictionary);
                }
                if (str == BookmarkStart.b("猰娲儴帶", num))
                {
                    return this.method_11(FontTypeHint.ComplexScript, dictionary);
                }
            }
        }
        return string.Empty;
    }

    internal string method_11(FontTypeHint A_0, Dictionary<string, Class325> A_1)
    {
        int num = 5;
        short num2 = 0x409;
        string key = BookmarkStart.b("䜪䰬嬮堰崲", 5);
        switch (A_0)
        {
            case FontTypeHint.EastAsia:
                key = BookmarkStart.b("个䰬", num);
                num2 = this.method_5().ThemeFontLanguage.method_2();
                break;

            case FontTypeHint.ComplexScript:
                key = BookmarkStart.b("䠪帬", num);
                num2 = this.method_5().ThemeFontLanguage.method_0();
                break;

            default:
                key = BookmarkStart.b("䜪䰬嬮堰崲", num);
                num2 = this.method_5().ThemeFontLanguage.method_4();
                break;
        }
        Class325 class2 = A_1[key];
        if (class2.method_8() == 0)
        {
            key = this.method_12(num2);
            if (A_1.ContainsKey(key))
            {
                class2 = A_1[key];
            }
            else
            {
                class2 = A_1[BookmarkStart.b("䜪䰬嬮堰崲", num)];
            }
        }
        return class2.method_6();
    }

    private string method_12(short A_0)
    {
        int num = 7;
        if (this.method_6().Count == 0)
        {
            this.method_8();
        }
        if (this.method_6().ContainsKey(A_0))
        {
            return this.method_6()[A_0];
        }
        return BookmarkStart.b("䄬丮䔰娲嬴", num);
    }

    public Dictionary<string, Class325> method_2()
    {
        if (this.dictionary_2 == null)
        {
            this.dictionary_2 = new Dictionary<string, Class325>();
        }
        return this.dictionary_2;
    }

    public Dictionary<string, Stream> method_3()
    {
        if (this.dictionary_3 == null)
        {
            this.dictionary_3 = new Dictionary<string, Stream>();
        }
        return this.dictionary_3;
    }

    public void method_4(Dictionary<string, Stream> A_0)
    {
        this.dictionary_3 = A_0;
    }

    public Document method_5()
    {
        return this.document_0;
    }

    public Dictionary<short, string> method_6()
    {
        if (this.dictionary_4 == null)
        {
            this.dictionary_4 = new Dictionary<short, string>();
        }
        return this.dictionary_4;
    }

    internal Class324 method_7()
    {
        Class324 class2 = new Class324(this.document_0);
        foreach (KeyValuePair<string, Class326> pair2 in this.method_0())
        {
            class2.method_0().Add(pair2.Key, pair2.Value.method_10());
        }
        foreach (KeyValuePair<string, Class325> pair4 in this.method_2())
        {
            class2.method_2().Add(pair4.Key, pair4.Value.method_9());
        }
        foreach (KeyValuePair<string, Class325> pair3 in this.method_1())
        {
            class2.method_1().Add(pair3.Key, pair3.Value.method_9());
        }
        foreach (KeyValuePair<string, Stream> pair in this.method_3())
        {
            class2.method_3().Add(pair.Key, pair.Value);
        }
        return class2;
    }

    private void method_8()
    {
        this.method_6().Add(0x411, BookmarkStart.b("攮䄰刲嬴", 9));
        this.method_6().Add(0x412, BookmarkStart.b("朮倰崲刴", 9));
        this.method_6().Add(0x404, BookmarkStart.b("朮倰崲䄴", 9));
        this.method_6().Add(0x804, BookmarkStart.b("朮倰崲䘴", 9));
        this.method_6().Add(0x401, BookmarkStart.b("渮䌰刲圴", 9));
        this.method_6().Add(0x40d, BookmarkStart.b("朮吰儲䜴", 9));
        this.method_6().Add(0x41e, BookmarkStart.b("笮夰刲尴", 9));
        this.method_6().Add(0x45e, BookmarkStart.b("樮䔰嬲尴", 9));
        this.method_6().Add(0x473, BookmarkStart.b("樮䔰嬲尴", 9));
        this.method_6().Add(0x445, BookmarkStart.b("洮吰崲刴", 9));
        this.method_6().Add(0x845, BookmarkStart.b("洮吰崲刴", 9));
        this.method_6().Add(0x447, BookmarkStart.b("栮䐰夲䜴", 9));
        this.method_6().Add(0x453, BookmarkStart.b("搮夰帲䜴", 9));
        this.method_6().Add(0x44b, BookmarkStart.b("搮弰圲吴", 9));
        this.method_6().Add(0x45c, BookmarkStart.b("氮夰嘲䜴", 9));
        this.method_6().Add(0x478, BookmarkStart.b("瘮堰娲尴", 9));
        this.method_6().Add(0x451, BookmarkStart.b("笮堰儲䄴", 9));
        this.method_6().Add(0x851, BookmarkStart.b("笮堰儲䄴", 9));
        this.method_6().Add(0x860, BookmarkStart.b("欮吰䔲吴", 9));
        this.method_6().Add(0x44a, BookmarkStart.b("笮吰弲䀴", 9));
        this.method_6().Add(0x449, BookmarkStart.b("笮倰帲头", 9));
        this.method_6().Add(0x45a, BookmarkStart.b("簮䠰䄲嘴", 9));
        this.method_6().Add(0x448, BookmarkStart.b("怮䌰䨲吴", 9));
        this.method_6().Add(0x44c, BookmarkStart.b("戮崰䨲場", 9));
        this.method_6().Add(0x454, BookmarkStart.b("挮倰尲娴", 9));
        this.method_6().Add(0x450, BookmarkStart.b("戮帰崲刴", 9));
        this.method_6().Add(0x850, BookmarkStart.b("戮帰崲刴", 9));
        this.method_6().Add(0x437, BookmarkStart.b("栮吰尲䜴", 9));
    }

    public string method_9(string A_0)
    {
        return this.method_10(A_0, FontTypeHint.Default);
    }

    void IDisposable.Dispose()
    {
        if (this.dictionary_0 != null)
        {
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
        if (this.dictionary_1 != null)
        {
            this.dictionary_1.Clear();
            this.dictionary_1 = null;
        }
        if (this.dictionary_2 != null)
        {
            this.dictionary_2.Clear();
            this.dictionary_2 = null;
        }
        if (this.document_0 != null)
        {
            this.document_0 = null;
        }
        if (this.dictionary_4 != null)
        {
            this.dictionary_4.Clear();
            this.dictionary_4 = null;
        }
    }
}

