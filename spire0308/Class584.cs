using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class584
{
    private readonly DateTime dateTime_0;
    private readonly int int_0;
    private readonly int int_1;
    private readonly int int_2;
    private string string_0;
    private readonly string string_1;
    private readonly string string_2;
    private readonly string string_3;
    private readonly string string_4;

    internal Class584(Class394 A_0)
    {
        int num2 = 8;
        this.int_0 = -1;
        this.dateTime_0 = DateTime.MinValue;
        this.string_0 = "";
        this.string_1 = "";
        this.string_2 = "";
        this.string_3 = "";
        this.int_1 = -1;
        this.int_2 = -1;
        this.string_4 = "";
        while (A_0.method_19())
        {
            string key = A_0.method_1();
            if (key != null)
            {
                int num;
                if (Class1160.dictionary_113 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("䜭启", num2), 0);
                    dictionary1.Add(BookmarkStart.b("䨭儯䘱儳", num2), 1);
                    dictionary1.Add(BookmarkStart.b("䴭䈯圱唳䈵崷帹崻䨽┿", num2), 2);
                    dictionary1.Add(BookmarkStart.b("䀭儯弱儳", num2), 3);
                    dictionary1.Add(BookmarkStart.b("伭䔯䘱尳夵䨷", num2), 4);
                    dictionary1.Add(BookmarkStart.b("䜭帯嬱䀳張夷嘹伻", num2), 5);
                    dictionary1.Add(BookmarkStart.b("䄭䈯嬱匳張嘷嬹倻", num2), 6);
                    dictionary1.Add(BookmarkStart.b("䴭弯帱爳張䨷䤹䠻", num2), 7);
                    dictionary1.Add(BookmarkStart.b("䴭弯帱ᤳ倵儷䠹伻䨽", num2), 8);
                    dictionary1.Add(BookmarkStart.b("䴭弯帱砳圵䬷丹", num2), 9);
                    dictionary1.Add(BookmarkStart.b("䴭弯帱ᤳ娵夷䤹䠻", num2), 10);
                    dictionary1.Add(BookmarkStart.b("娭䤯䈱儳", num2), 11);
                    Class1160.dictionary_113 = dictionary1;
                }
                if (Class1160.dictionary_113.TryGetValue(key, out num))
                {
                    switch (num)
                    {
                        case 0:
                            this.int_0 = A_0.method_4();
                            break;

                        case 1:
                        case 2:
                            this.dateTime_0 = Class1041.smethod_3(A_0.method_3());
                            break;

                        case 3:
                            this.string_0 = A_0.method_3();
                            break;

                        case 4:
                            this.string_1 = A_0.method_3();
                            break;

                        case 5:
                            this.string_2 = A_0.method_3();
                            break;

                        case 6:
                            this.string_3 = A_0.method_3();
                            break;

                        case 7:
                        case 8:
                            this.int_1 = A_0.method_4();
                            break;

                        case 9:
                        case 10:
                            this.int_2 = A_0.method_4();
                            break;

                        case 11:
                            this.string_4 = A_0.method_3();
                            break;
                    }
                }
            }
        }
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal DateTime method_1()
    {
        return this.dateTime_0;
    }

    internal bool method_10()
    {
        return (this.int_0 >= 0);
    }

    internal bool method_11()
    {
        return ((this.string_4 == BookmarkStart.b("游吺似嬾潀B⩄⩆⑈⹊⍌㭎", 0x13)) && (this.int_0 >= 0));
    }

    internal string method_2()
    {
        return this.string_0;
    }

    internal void method_3(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_4()
    {
        return this.string_1;
    }

    internal string method_5()
    {
        return this.string_2;
    }

    internal string method_6()
    {
        return this.string_3;
    }

    internal int method_7()
    {
        return this.int_1;
    }

    internal int method_8()
    {
        return this.int_2;
    }

    internal string method_9()
    {
        return this.string_4;
    }
}

