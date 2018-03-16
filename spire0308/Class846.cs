using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class846
{
    private readonly bool bool_0;
    private readonly double double_0;
    private readonly string string_0;
    private readonly string string_1 = "";

    internal Class846(string A_0)
    {
        this.string_0 = A_0;
        if (A_0 != string.Empty)
        {
            int num = A_0.Length - 1;
            while (num >= 0)
            {
                if (((A_0[num] >= '0') && (A_0[num] <= '9')) || (A_0[num] == '.'))
                {
                    break;
                }
                num--;
            }
            string str = A_0.Substring(0, num + 1);
            this.double_0 = Class1041.smethod_15(str);
            this.bool_0 = !double.IsNaN(this.double_0);
            this.string_1 = A_0.Substring(num + 1, (A_0.Length - num) - 1);
        }
    }

    internal bool method_0()
    {
        return (this.bool_0 && this.method_6());
    }

    internal bool method_1()
    {
        int num = 12;
        if (!this.bool_0)
        {
            return false;
        }
        if (!(this.string_1 == BookmarkStart.b("吱倳", num)))
        {
            return this.method_6();
        }
        return true;
    }

    internal int method_10()
    {
        int num = 0x10;
        string str = this.string_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("倵尷", num))
            {
                return Class1133.smethod_5(this.double_0);
            }
            if (str == "")
            {
                return Class1133.smethod_5(this.double_0 * 65536.0);
            }
        }
        return 0;
    }

    internal int method_11()
    {
        if (this.method_4())
        {
            return Class1133.smethod_5(this.double_0);
        }
        return 0;
    }

    internal int method_12()
    {
        if (!this.method_3())
        {
            return 0;
        }
        if (this.method_0())
        {
            return Class1133.smethod_5(this.double_0 * 65536.0);
        }
        return Class1133.smethod_5(this.double_0);
    }

    internal bool method_2()
    {
        int num = 7;
        if (!this.bool_0)
        {
            return false;
        }
        if (((!(this.string_1 == BookmarkStart.b("䐬䄮", num)) && !(this.string_1 == BookmarkStart.b("崬圮", num))) && (!(this.string_1 == BookmarkStart.b("崬嬮", num)) && !(this.string_1 == BookmarkStart.b("䀬䈮", num)))) && (!(this.string_1 == BookmarkStart.b("丬䈮", num)) && !this.method_6()))
        {
            return this.method_5();
        }
        return true;
    }

    internal bool method_3()
    {
        int num = 4;
        if (!this.bool_0)
        {
            return false;
        }
        if (!(this.string_1 == BookmarkStart.b("䰩", num)))
        {
            return this.method_6();
        }
        return true;
    }

    internal bool method_4()
    {
        int num = 1;
        if (!this.bool_0)
        {
            return false;
        }
        if (!(this.string_1 == BookmarkStart.b("Ȧ", num)))
        {
            return this.method_5();
        }
        return true;
    }

    private bool method_5()
    {
        return ((this.double_0 == 0.0) && this.method_6());
    }

    private bool method_6()
    {
        return (this.string_1 == string.Empty);
    }

    internal int method_7()
    {
        return Class1133.smethod_5(this.method_8() * 12700.0);
    }

    internal double method_8()
    {
        int num = 12;
        string key = this.string_1;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_172 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add("", 0);
                dictionary1.Add(BookmarkStart.b("䈱䰳", num), 1);
                dictionary1.Add(BookmarkStart.b("䈱䀳", num), 2);
                dictionary1.Add(BookmarkStart.b("嬱娳", num), 3);
                dictionary1.Add(BookmarkStart.b("弱夳", num), 4);
                dictionary1.Add(BookmarkStart.b("儱夳", num), 5);
                Class1160.dictionary_172 = dictionary1;
            }
            if (Class1160.dictionary_172.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return this.double_0;

                    case 1:
                        return Class969.smethod_8(this.double_0);

                    case 2:
                        return this.double_0;

                    case 3:
                        return Class969.smethod_13(this.double_0);

                    case 4:
                        return Class969.smethod_15(this.double_0);

                    case 5:
                        return Class969.smethod_22(this.double_0);
                }
            }
        }
        return 0.0;
    }

    internal Class623 method_9()
    {
        return new Class623(Class969.smethod_31(this.method_8()), false);
    }
}

