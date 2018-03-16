using Spire.Doc;
using System;
using System.Collections.Generic;

internal abstract class Class424
{
    private byte[] byte_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private string string_0;
    private string string_1;
    private string string_2;

    protected Class424()
    {
    }

    protected bool method_0(Class394 A_0)
    {
        int num = 0x10;
        string key = A_0.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_36 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                dictionary1.Add(BookmarkStart.b("䔵夷嘹䠻洽⤿㡁⅃", num), 0);
                dictionary1.Add(BookmarkStart.b("吵吷唹弻唽ጿ⭁㹃⍅", num), 1);
                dictionary1.Add(BookmarkStart.b("崵崷䌹縻圽㐿ㅁ", num), 2);
                dictionary1.Add(BookmarkStart.b("帵夷䤹吻洽⤿㡁⅃", num), 3);
                dictionary1.Add(BookmarkStart.b("唵儷䨹吻嬽㈿́⡃ⅅ❇㡉╋㩍㡏㽑", num), 4);
                dictionary1.Add(BookmarkStart.b("唵儷䨹吻嬽㈿Łⱃ❅ⅇ⑉╋⁍㝏", num), 5);
                dictionary1.Add(BookmarkStart.b("帵夷䤹吻缽ⰿ╁⭃㑅ⅇ㹉⑋⍍", num), 6);
                dictionary1.Add(BookmarkStart.b("䔵夷嘹䠻栽ℿ⹁ㅃ⍅", num), 7);
                dictionary1.Add(BookmarkStart.b("䔵䠷匹刻紽⼿㝁⩃㉅", num), 8);
                Class1160.dictionary_36 = dictionary1;
            }
            if (Class1160.dictionary_36.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.int_0 = A_0.method_4();
                        goto Label_0193;

                    case 1:
                        this.int_1 = A_0.method_4();
                        goto Label_0193;

                    case 2:
                        this.int_2 = A_0.method_4();
                        goto Label_0193;

                    case 3:
                        this.int_3 = A_0.method_4();
                        goto Label_0193;

                    case 4:
                        this.string_0 = A_0.method_3();
                        goto Label_0193;

                    case 5:
                        this.string_1 = A_0.method_3();
                        goto Label_0193;

                    case 6:
                        this.string_2 = A_0.method_3();
                        goto Label_0193;

                    case 7:
                        this.byte_0 = Convert.FromBase64String(A_0.method_3());
                        goto Label_0193;

                    case 8:
                        this.int_4 = A_0.method_4();
                        goto Label_0193;
                }
            }
        }
        return false;
    Label_0193:
        return true;
    }

    internal int method_1()
    {
        return this.int_0;
    }

    internal int method_2()
    {
        return this.int_1;
    }

    internal int method_3()
    {
        return this.int_2;
    }

    internal int method_4()
    {
        return this.int_3;
    }

    internal int method_5()
    {
        return this.int_4;
    }

    internal string method_6()
    {
        return this.string_0;
    }

    internal string method_7()
    {
        return this.string_1;
    }

    internal string method_8()
    {
        return this.string_2;
    }

    internal byte[] method_9()
    {
        return this.byte_0;
    }
}

