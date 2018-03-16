using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class1129 : Class1128
{
    internal Class1128 method_18(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { '/' });
        return base.method_8(strArray, 0);
    }

    internal Class229 method_19(string A_0)
    {
        int num = A_0.LastIndexOf(BookmarkStart.b("ԩ", 4));
        string str = A_0.Substring(0, num + 1);
        Class1128 class2 = this.method_18(str);
        if (class2 != null)
        {
            string key = A_0.Substring(num + 1, A_0.Length - (num + 1));
            if (class2.method_0().ContainsKey(key))
            {
                return class2.method_0()[key];
            }
        }
        return null;
    }

    internal void method_20(Class771 A_0)
    {
        int num = 0x11;
        int num2 = 0;
        int num3 = A_0.method_2();
        while (num2 < num3)
        {
            if (!A_0.method_0(num2).method_0().EndsWith(BookmarkStart.b("ᠶ", num)))
            {
                this.method_23(A_0.method_0(num2));
            }
            num2++;
        }
    }

    internal void method_21(List<Class229> A_0)
    {
        int num = 14;
        int num2 = 0;
        int count = A_0.Count;
        while (num2 < count)
        {
            Class229 class2 = A_0[num2];
            if (!class2.method_7().EndsWith(BookmarkStart.b("ᬳ", num)))
            {
                this.method_22(class2);
            }
            num2++;
        }
    }

    private void method_22(Class229 A_0)
    {
        int num = 12;
        if (A_0.method_7().StartsWith(BookmarkStart.b("ᴱ", 12)))
        {
            A_0.method_8(A_0.method_7().Remove(0, 1));
        }
        string[] strArray = A_0.method_7().Split(new char[] { '/' });
        Class1128 class2 = base.method_8(strArray, 0);
        if ((strArray.Length > 1) && strArray[strArray.Length - 2].EndsWith(BookmarkStart.b("洱䘳匵吷䤹", num)))
        {
            class2.method_10(A_0);
        }
        else
        {
            class2.method_6(A_0);
        }
    }

    private void method_23(Class814 A_0)
    {
        int num = 1;
        string[] strArray = A_0.method_0().Split(new char[] { '/' });
        Class1128 class2 = base.method_8(strArray, 0);
        if (!A_0.method_12().ToString().Contains(BookmarkStart.b("挦䀨太䠬䰮䔰尲䜴丶", 1)))
        {
            if ((strArray.Length > 1) && strArray[strArray.Length - 2].EndsWith(BookmarkStart.b("砦嬨个䄬尮", num)))
            {
                class2.method_9(A_0);
            }
            else
            {
                class2.method_5(A_0);
            }
        }
    }

    internal List<Class229> method_24()
    {
        return base.vmethod_0(BookmarkStart.b("Ḱ", 11));
    }

    internal Class1129 method_25()
    {
        Class1129 class2 = new Class1129();
        class2.method_4(base.string_0);
        if ((base.dictionary_0 != null) && (base.dictionary_0.Count > 0))
        {
            foreach (string str2 in base.dictionary_0.Keys)
            {
                class2.method_0().Add(str2, base.dictionary_0[str2].method_9());
            }
        }
        if ((base.dictionary_2 != null) && (base.dictionary_2.Count > 0))
        {
            foreach (string str in base.dictionary_2.Keys)
            {
                class2.method_2().Add(str, base.dictionary_2[str].method_10() as Class230);
            }
        }
        if ((base.dictionary_1 != null) && (base.dictionary_1.Count > 0))
        {
            foreach (string str3 in base.dictionary_1.Keys)
            {
                class2.method_1().Add(str3, base.dictionary_1[str3].method_17());
            }
        }
        return class2;
    }
}

