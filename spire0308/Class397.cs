using Spire.Doc;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;

internal class Class397
{
    private Class1092 class1092_0;
    private readonly StringBuilder stringBuilder_0;

    public Class397(Class1092 A_0, bool A_1)
    {
        this.class1092_0 = A_0;
        this.stringBuilder_0 = new StringBuilder(0x800);
    }

    public Class397(Stream A_0, bool A_1) : this(A_0, Encoding.UTF8, A_1)
    {
    }

    public Class397(Stream A_0, Encoding A_1, bool A_2)
    {
        if ((A_1.CodePage == 0xfde8) && (A_1.GetPreamble().Length == 0))
        {
            byte[] buffer = Class787.byte_0;
            A_0.Write(buffer, 0, buffer.Length);
        }
        this.class1092_0 = Class789.smethod_0(A_0, A_1);
        this.stringBuilder_0 = new StringBuilder(0x800);
    }

    public Class1092 method_0()
    {
        return this.class1092_0;
    }

    public void method_1(Class1092 A_0)
    {
        this.class1092_0 = A_0;
    }

    public void method_10(string A_0)
    {
        this.method_11(A_0, null);
    }

    public void method_11(string A_0, string A_1)
    {
        this.method_4(A_0);
        this.method_15(A_1);
        this.method_5();
    }

    public void method_12(string A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            this.method_11(A_0, A_1);
        }
    }

    public void method_13(string A_0, DateTime A_1)
    {
        if (A_1.Year > 1)
        {
            this.method_11(A_0, Class1041.smethod_0(A_1));
        }
    }

    public void method_14(string A_0, int A_1)
    {
        this.method_11(A_0, Class1041.smethod_8(A_1));
    }

    public void method_15(string A_0)
    {
        this.class1092_0.method_21(this.method_21(A_0));
    }

    private string method_16(string A_0)
    {
        int num = 8;
        string str = string.Empty;
        string str3 = Class398.smethod_11(A_0);
        if (str3 == null)
        {
            return str;
        }
        if (str3 != BookmarkStart.b("堭ਯ", num))
        {
            if (str3 != BookmarkStart.b("䄭ਯ", num))
            {
                if (!(str3 == BookmarkStart.b("夭ਯ", num)))
                {
                    if (str3 == BookmarkStart.b("夭įȱำ", num))
                    {
                        str = BookmarkStart.b("嬭䈯就ำ䔵嬷刹夻匽ℿㅁ楃⭅ⅇ⥉㹋⅍⍏㵑㉓≕畗㥙㍛㍝婟ൡɣeŧ३५呭ݯᵱٳት", num);
                    }
                    return str;
                }
                return BookmarkStart.b("䘭䐯䘱䐳వ᜷ᔹ伻崽⠿❁⥃❅㭇摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䙧թṫ७彯ձ᭳ѵᱷ੹๻ᅽﲏ붑ꚓꚕꢗ겙뎛솟쮡쪣", num);
            }
            return BookmarkStart.b("嬭䈯就ำ䔵嬷刹夻匽ℿㅁ楃⭅ⅇ⥉㹋⅍⍏㵑㉓≕畗㥙㍛㍝婟ൡɣeŧ३५呭Ὧᑱታή᭷ό", num);
        }
        return BookmarkStart.b("嬭䈯就ำ䔵嬷刹夻匽ℿㅁ楃⭅ⅇ⥉㹋⅍⍏㵑㉓≕畗㥙㍛㍝婟ᑡॣ੥", num);
    }

    public void method_17(string A_0, string A_1, string A_2)
    {
        if (A_1 != A_2)
        {
            this.method_18(A_0, A_1);
        }
    }

    public void method_18(string A_0, string A_1)
    {
        this.class1092_0.method_4(A_0, this.method_21(A_1));
    }

    public void method_19(Stream A_0)
    {
        if (A_0 is MemoryStream)
        {
            this.method_20(((MemoryStream) A_0).GetBuffer(), 0, (int) A_0.Length);
        }
        else
        {
            this.method_20(Class567.smethod_10(A_0), 0, (int) A_0.Length);
        }
    }

    public void method_2(string A_0)
    {
        this.class1092_0.method_17(true);
        this.method_4(A_0);
    }

    public void method_20(byte[] A_0, int A_1, int A_2)
    {
        int num = 2;
        Class525 class2 = new Class525(A_0, A_1, A_2);
        while (!class2.method_0())
        {
            this.method_15(class2.method_1());
            this.class1092_0.method_22(BookmarkStart.b("┧\u2029", num));
        }
    }

    public string method_21(string A_0)
    {
        if (!smethod_0(A_0))
        {
            return A_0;
        }
        this.stringBuilder_0.Length = 0;
        using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                if (smethod_1(current))
                {
                    this.stringBuilder_0.Append(Class334.smethod_0(current));
                }
            }
        }
        return this.stringBuilder_0.ToString();
    }

    public void method_3()
    {
        this.class1092_0.method_12();
        this.class1092_0.method_18();
        this.class1092_0.method_15();
    }

    public void method_4(string A_0)
    {
        this.class1092_0.method_9(A_0);
    }

    public void method_5()
    {
        this.class1092_0.method_12();
    }

    public void method_6(string A_0)
    {
        this.class1092_0.method_12();
    }

    public void method_7()
    {
        this.class1092_0.method_13();
    }

    public void method_8(string A_0)
    {
        this.class1092_0.method_13();
    }

    public void method_9(string A_0)
    {
        this.class1092_0.method_20(A_0);
    }

    private static bool smethod_0(string A_0)
    {
        bool flag;
        if (!Class567.smethod_16(A_0))
        {
            return false;
        }
        using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                if (!smethod_1(current))
                {
                    goto Label_0037;
                }
            }
            return false;
        Label_0037:
            flag = true;
        }
        return flag;
    }

    private static bool smethod_1(int A_0)
    {
        if (((((A_0 != 9) && (A_0 != 10)) && (A_0 != 13)) && ((A_0 < 0x20) || (A_0 > 0xd7ff))) && ((A_0 < 0xe000) || (A_0 > 0xfffd)))
        {
            return ((A_0 >= 0x10000) && (A_0 <= 0x10ffff));
        }
        return true;
    }

    private static bool smethod_2(string A_0)
    {
        bool flag2;
        if (!Class567.smethod_16(A_0))
        {
            return false;
        }
        bool flag = true;
        using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                if (!smethod_4(current, flag))
                {
                    goto Label_003C;
                }
                flag = false;
            }
            return true;
        Label_003C:
            flag2 = false;
        }
        return flag2;
    }

    private static void smethod_3(string A_0, StringBuilder A_1)
    {
        A_1.Length = 0;
        if (Class567.smethod_16(A_0))
        {
            string str = new string('_', 1);
            bool flag = true;
            using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int current = (int) enumerator.Current;
                    A_1.Append(smethod_4(current, flag) ? Class334.smethod_0(current) : str);
                    flag = false;
                }
            }
        }
    }

    private static bool smethod_4(int A_0, bool A_1)
    {
        if (!A_1)
        {
            return smethod_6(A_0);
        }
        return smethod_5(A_0);
    }

    private static bool smethod_5(int A_0)
    {
        if ((((((A_0 < 0x41) || (A_0 > 90)) && ((A_0 != 0x5f) && ((A_0 < 0x61) || (A_0 > 0x7a)))) && (((A_0 < 0xc0) || (A_0 > 0xd6)) && ((A_0 < 0xd8) || (A_0 > 0xf6)))) && ((((A_0 < 0xf8) || (A_0 > 0x2ff)) && ((A_0 < 880) || (A_0 > 0x37d))) && (((A_0 < 0x37f) || (A_0 > 0x1fff)) && ((A_0 < 0x200c) || (A_0 > 0x200d))))) && (((((A_0 < 0x2070) || (A_0 > 0x218f)) && ((A_0 < 0x2c00) || (A_0 > 0x2fef))) && (((A_0 < 0x3001) || (A_0 > 0xd7ff)) && ((A_0 < 0xf900) || (A_0 > 0xfdcf)))) && ((A_0 < 0xfdf0) || (A_0 > 0xfffd))))
        {
            return ((A_0 >= 0x10000) && (A_0 <= 0xeffff));
        }
        return true;
    }

    private static bool smethod_6(int A_0)
    {
        if ((((!smethod_5(A_0) && (A_0 != 0x2d)) && (A_0 != 0x2e)) && ((A_0 < 0x30) || (A_0 > 0x39))) && ((A_0 != 0xb7) && ((A_0 < 0x300) || (A_0 > 0x36f))))
        {
            return ((A_0 >= 0x203f) && (A_0 <= 0x2040));
        }
        return true;
    }

    [Conditional("DEBUG")]
    private static void smethod_7()
    {
    }

    [Conditional("DEBUG")]
    private static void smethod_8(string A_0)
    {
    }

    [Conditional("DEBUG")]
    private static void smethod_9(string A_0)
    {
    }
}

