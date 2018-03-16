using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class636
{
    private bool bool_0;
    private bool bool_1;
    private Class637 class637_0;
    private Dictionary<string, Class639> dictionary_0;
    private string string_0;
    private string[] string_1;
    private string[] string_2;

    public Class636(string A_0, bool A_1, bool A_2, Class637 A_3, string[] A_4, string[] A_5)
    {
        this.string_0 = A_0;
        this.bool_0 = A_1;
        this.bool_1 = A_2;
        this.class637_0 = A_3;
        this.string_1 = A_4;
        this.string_2 = A_5;
    }

    public string method_0()
    {
        return this.string_0;
    }

    public Class637 method_1()
    {
        return this.class637_0;
    }

    public bool method_2()
    {
        return this.bool_1;
    }

    public bool method_3()
    {
        return this.bool_0;
    }

    public Class639 method_4(string A_0)
    {
        Class639 class2;
        int num = 13;
        if (this.dictionary_0 == null)
        {
            throw new InvalidOperationException(BookmarkStart.b("朲崴制ᤸ娺䤼䬾㍀⩂❄㉆㵈⹊浌⍎㡐⁒⅔睖㽘㑚⽜罞ᕠୢd䝦౨ݪ࡬ɮᑰᵲŴ坶ᵸṺṼ፾꾎戀랖뾞쎠욢삤즦覨슪쎬욮얰\udab2\ud4b4\udbb6\ud0b8좺\ud8bc\udbbe", num));
        }
        this.dictionary_0.TryGetValue(A_0.ToUpperInvariant(), out class2);
        return class2;
    }

    public void method_5(Dictionary<string, Class639> A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嬶倸䠺䤼", num));
        }
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = A_0;
        }
        else
        {
            foreach (Class639 class2 in A_0.Values)
            {
                if (!this.dictionary_0.ContainsKey(class2.method_0()))
                {
                    this.dictionary_0.Add(class2.method_0(), class2);
                }
            }
        }
    }

    public bool method_6(string A_0, Class640 A_1)
    {
        if (this.string_2 != null)
        {
            foreach (string str in this.string_2)
            {
                if (string.Equals(str, A_0, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
        }
        if (this.string_1 != null)
        {
            foreach (string str2 in this.string_1)
            {
                if (string.Equals(str2, A_0, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }
        return this.class637_0.method_8(A_0, A_1);
    }
}

