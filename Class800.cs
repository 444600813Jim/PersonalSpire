using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;
using System.Collections;
using System.Text.RegularExpressions;

internal class Class800
{
    private readonly Class335 class335_0;
    private readonly Hashtable hashtable_0;
    private readonly Hashtable hashtable_1;
    private readonly Hashtable hashtable_2;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("瘬焮ᰰ刲ᠴ䴶砸ᘺ朼༾汀穂ᡄ浆", 7), RegexOptions.Singleline | RegexOptions.Compiled);

    internal Class800(StyleCollection A_0)
    {
        int count = A_0.Count;
        this.hashtable_0 = new Hashtable(count);
        this.hashtable_1 = new Hashtable(count);
        this.hashtable_2 = new Hashtable();
        this.class335_0 = Class335.smethod_0();
        StyleCollection docStyleCollection = A_0.DocStyleCollection;
        for (int i = 0; i < count; i++)
        {
            this.method_0(docStyleCollection[i] as Style);
        }
    }

    private void method_0(Style A_0)
    {
        string name;
        int num = 0;
        if (A_0.BuiltIn)
        {
            name = Class417.smethod_27(Class417.smethod_26(A_0.StyleIdentifier, A_0.Name));
        }
        else
        {
            name = A_0.Name;
        }
        int istd = A_0.Istd;
        string str2 = this.method_1(BookmarkStart.b("䜥", num), string.Empty);
        this.hashtable_0.Add(istd, str2);
        if (!this.hashtable_1.ContainsKey(A_0.StyleId))
        {
            this.hashtable_1.Add(A_0.StyleId, str2);
        }
        else
        {
            this.hashtable_1[A_0.StyleId] = str2;
        }
        string str3 = A_0.Document.Styles.method_14(A_0, false);
        if (Class567.smethod_16(str3))
        {
            string[] strArray = str3.Split(new char[] { ',' });
            int length = strArray.Length;
            while (--length >= 0)
            {
                strArray[length] = this.method_1(str2, strArray[length]);
            }
            this.hashtable_2.Add(istd, strArray);
        }
    }

    private string method_1(string A_0, string A_1)
    {
        string str = A_1.Replace(BookmarkStart.b("ࠧ", 2), string.Empty);
        if (str == string.Empty)
        {
            str = A_0;
        }
        str = this.method_2(str);
        this.class335_0.Interface34.imethod_1(str);
        return str;
    }

    private string method_2(string A_0)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("䔵䰷䌹倻嬽ि♁", 0x10));
        int num = 0;
        string str = A_0 + 0;
        while (this.class335_0.Interface34.imethod_3(str))
        {
            str = A_0 + num;
            num++;
        }
        return str;
    }

    internal string method_3(int A_0)
    {
        return (string) this.hashtable_0[A_0];
    }

    internal string method_4(string A_0)
    {
        return (string) this.hashtable_1[A_0];
    }

    internal string[] method_5(int A_0)
    {
        return (string[]) this.hashtable_2[A_0];
    }
}

