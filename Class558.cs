using Spire.Doc;
using System;
using System.Collections;
using System.Reflection;
using System.Text;

[DefaultMember("Item")]
internal class Class558
{
    private static readonly char[] char_0 = new char[] { ' ', '\r', '\n', '\t', '\f' };
    private readonly Class181 class181_0;
    private const int int_0 = 0;
    private const int int_1 = 1;
    private const int int_2 = 2;
    private const int int_3 = 3;

    internal Class558()
    {
        this.class181_0 = new Class181();
    }

    internal Class558(string A_0)
    {
        this.class181_0 = new Class181();
        this.method_0(A_0);
    }

    internal void method_0(string A_0)
    {
        foreach (string str in A_0.Split(new char[] { ';' }))
        {
            this.method_11(str);
        }
    }

    internal void method_1(Class558 A_0)
    {
        int num = A_0.method_16();
        while (--num >= 0)
        {
            this.method_14(A_0.method_9(num), A_0.method_15(num));
        }
    }

    internal void method_10(string A_0)
    {
        this.class181_0.Remove(A_0.ToLower());
    }

    private void method_11(string A_0)
    {
        int index = A_0.IndexOf(':');
        if (index >= 0)
        {
            int length = index;
            string str = smethod_0(A_0.Substring(0, length));
            int startIndex = index + 1;
            int num4 = A_0.Length - startIndex;
            string str2 = smethod_0(A_0.Substring(startIndex, num4));
            if (Class567.smethod_16(str) && Class567.smethod_16(str2))
            {
                this.method_14(str, Class1125.smethod_8(str, str2));
            }
        }
    }

    private SortedList method_12(bool A_0)
    {
        int num = 0x12;
        string[] strArray2 = new string[] { BookmarkStart.b("唷嬹主夽⤿ⱁ楃㉅❇㩉", 0x12), BookmarkStart.b("唷嬹主夽⤿ⱁ楃㑅ⅇⵉ⑋㩍", 0x12), BookmarkStart.b("唷嬹主夽⤿ⱁ楃⑅❇㹉㡋⅍㵏", 0x12), BookmarkStart.b("唷嬹主夽⤿ⱁ楃⩅ⵇⱉ㡋", 0x12) };
        Class181 class2 = new Class181(true);
        foreach (DictionaryEntry entry in this.class181_0)
        {
            class2.Add(entry.Key, entry.Value);
        }
        Class1030 class3 = new Class1030();
        int num2 = smethod_2(strArray2, class2, class3);
        if (num2 != 0)
        {
            Class1125 class5 = class2[BookmarkStart.b("唷嬹主夽⤿ⱁ", num)] as Class1125;
            if (class5 != null)
            {
                for (int i = 0; i < class3.Count; i++)
                {
                    if (class3.method_0(i) == null)
                    {
                        class3.method_1(i, smethod_3(class5, i));
                    }
                    else
                    {
                        class2.Remove(strArray2[i]);
                    }
                }
                class2[BookmarkStart.b("唷嬹主夽⤿ⱁ", num)] = Class1125.smethod_7(class3);
            }
            else if (num2 == strArray2.Length)
            {
                Class1125 class4 = Class1125.smethod_7(class3);
                class2.Add(BookmarkStart.b("唷嬹主夽⤿ⱁ", num), class4);
                for (int j = 0; j < strArray2.Length; j++)
                {
                    class2.Remove(strArray2[j]);
                }
            }
        }
        if (!A_0)
        {
            return class2;
        }
        return new SortedList(class2, new Class1032());
    }

    internal Class1125 method_13(string A_0)
    {
        return (Class1125) this.class181_0[A_0.ToLower()];
    }

    internal void method_14(string A_0, Class1125 A_1)
    {
        this.class181_0[A_0.ToLower()] = A_1;
    }

    internal Class1125 method_15(int A_0)
    {
        return (Class1125) this.class181_0.GetByIndex(A_0);
    }

    internal int method_16()
    {
        return this.class181_0.Count;
    }

    internal void method_2(string A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            this.method_14(A_0, Class1125.smethod_0(A_1));
        }
    }

    internal void method_3(string A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            this.method_14(A_0, Class1125.smethod_1(A_1));
        }
    }

    internal void method_4(string A_0, double A_1)
    {
        this.method_14(A_0, Class1125.smethod_2(A_1));
    }

    internal void method_5(string A_0, double A_1)
    {
        this.method_14(A_0, Class1125.smethod_3(A_1));
    }

    internal string method_6(string A_0)
    {
        Class1125 class2 = this.method_13(A_0);
        if (class2 == null)
        {
            return string.Empty;
        }
        return class2.method_8();
    }

    internal string method_7(bool A_0)
    {
        if (this.class181_0.Count == 0)
        {
            return "";
        }
        StringBuilder builder = new StringBuilder();
        this.method_8(builder, A_0);
        return builder.ToString();
    }

    private void method_8(StringBuilder A_0, bool A_1)
    {
        int num = 0x11;
        if (this.class181_0.Count != 0)
        {
            SortedList list = this.method_12(A_1);
            bool flag = true;
            foreach (DictionaryEntry entry in list)
            {
                if (!flag)
                {
                    A_0.Append(BookmarkStart.b("శᤸ", num));
                }
                else
                {
                    flag = false;
                }
                smethod_1((string) entry.Key, (Class1125) entry.Value, A_0);
            }
        }
    }

    internal string method_9(int A_0)
    {
        return (string) this.class181_0.GetKey(A_0);
    }

    private static string smethod_0(string A_0)
    {
        return A_0.Trim(char_0);
    }

    private static void smethod_1(string A_0, Class1125 A_1, StringBuilder A_2)
    {
        A_2.Append(A_0);
        A_2.Append(BookmarkStart.b("ശ", 0x11));
        A_1.method_6(A_2);
    }

    private static int smethod_2(string[] A_0, Class181 A_1, Class1030 A_2)
    {
        int num = 0;
        foreach (string str in A_0)
        {
            Class1125 class2 = A_1[str] as Class1125;
            A_2.Add(class2);
            if (class2 != null)
            {
                num++;
            }
        }
        return num;
    }

    private static Class1125 smethod_3(Class1125 A_0, int A_1)
    {
        Class1030 class2 = A_0.method_9();
        if (class2 == null)
        {
            return A_0;
        }
        if (class2.Count == 1)
        {
            return class2.method_0(0);
        }
        switch (A_1)
        {
            case 0:
                return class2.method_0(0);

            case 1:
                return class2.method_0(1);

            case 2:
                if (class2.Count != 2)
                {
                    return class2.method_0(2);
                }
                return class2.method_0(0);

            case 3:
                if (class2.Count != 3)
                {
                    return class2.method_0(3);
                }
                return class2.method_0(1);
        }
        return null;
    }
}

