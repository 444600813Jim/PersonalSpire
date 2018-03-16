using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Text;

internal class Class233
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly ArrayList arrayList_1 = new ArrayList();
    private bool bool_0;
    private readonly Class679[] class679_0;
    private readonly Class891[] class891_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private readonly StringBuilder stringBuilder_0 = new StringBuilder();

    internal Class233(string A_0)
    {
        this.method_0(A_0);
        this.class679_0 = new Class679[this.arrayList_0.Count];
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            this.class679_0[i] = (Class679) this.arrayList_0[i];
        }
        this.class891_0 = new Class891[this.arrayList_1.Count / 2];
        for (int j = 0; j < (this.arrayList_1.Count / 2); j++)
        {
            this.class891_0[j] = new Class891((Class623) this.arrayList_1[2 * j], (Class623) this.arrayList_1[(2 * j) + 1]);
        }
    }

    private void method_0(string A_0)
    {
        PathParserState command = PathParserState.Command;
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if (!char.IsDigit(c) && (c != '-'))
            {
                if (!char.IsLower(c) && !char.IsUpper(c))
                {
                    if (c == ',')
                    {
                        switch (command)
                        {
                            case PathParserState.Command:
                                this.method_2();
                                break;
                        }
                        this.method_3();
                        command = PathParserState.Restart;
                        continue;
                    }
                    if (c != '@')
                    {
                        continue;
                    }
                    switch (command)
                    {
                        case PathParserState.Command:
                            this.method_2();
                            break;

                        case PathParserState.Ref:
                        case PathParserState.Number:
                            this.method_3();
                            break;
                    }
                    command = PathParserState.Ref;
                    this.stringBuilder_0.Append(c);
                    continue;
                }
                switch (command)
                {
                    case PathParserState.Restart:
                        this.method_3();
                        break;

                    case PathParserState.Command:
                        if (smethod_1(this.stringBuilder_0.ToString().ToLower()))
                        {
                            this.method_2();
                        }
                        break;

                    case PathParserState.Ref:
                    case PathParserState.Number:
                        this.method_3();
                        break;
                }
                command = PathParserState.Command;
                this.stringBuilder_0.Append(c);
                continue;
            }
            switch (command)
            {
                case PathParserState.Restart:
                    command = PathParserState.Number;
                    break;

                case PathParserState.Command:
                    this.method_2();
                    command = PathParserState.Number;
                    break;
            }
            this.stringBuilder_0.Append(c);
        }
        this.method_1(command);
    }

    private void method_1(PathParserState A_0)
    {
        switch (A_0)
        {
            case PathParserState.Ref:
            case PathParserState.Number:
                this.method_3();
                this.stringBuilder_0.Append('e');
                break;
        }
        this.method_2();
    }

    private void method_2()
    {
        if (this.arrayList_0.Count > 0)
        {
            Class679 class2 = (Class679) this.arrayList_0[this.arrayList_0.Count - 1];
            this.arrayList_0[this.arrayList_0.Count - 1] = new Class679(class2.method_0(), smethod_0(class2, this.int_0 / 2));
        }
        string str = this.stringBuilder_0.ToString().ToLower();
        this.stringBuilder_0.Length = 0;
        Class679 class3 = new Class679(smethod_2(str), 0);
        this.arrayList_0.Add(class3);
        this.bool_0 = smethod_3(str);
        this.int_0 = 0;
    }

    private void method_3()
    {
        string str = this.stringBuilder_0.ToString();
        this.stringBuilder_0.Length = 0;
        Class623 class2 = smethod_4(str);
        bool flag = Class567.smethod_3((long) this.int_0);
        if (this.bool_0)
        {
            if (flag)
            {
                class2 = new Class623(class2.method_1() + this.int_2);
            }
            else
            {
                class2 = new Class623(class2.method_1() + this.int_1);
            }
        }
        else if (flag)
        {
            this.int_2 = class2.method_1();
        }
        else
        {
            this.int_1 = class2.method_1();
        }
        this.arrayList_1.Add(class2);
        this.int_0++;
    }

    internal Class679[] method_4()
    {
        return this.class679_0;
    }

    internal Class891[] method_5()
    {
        return this.class891_0;
    }

    private static int smethod_0(Class679 A_0, int A_1)
    {
        if (A_0.method_0() == PathType.Close)
        {
            return 1;
        }
        int num = A_0.method_4();
        if (num <= 0)
        {
            return 0;
        }
        return (A_1 / num);
    }

    private static bool smethod_1(string A_0)
    {
        return (smethod_2(A_0) != PathType.Unknown);
    }

    private static PathType smethod_2(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䈯", num))
            {
                return PathType.LineTo;
            }
            if (str == BookmarkStart.b("䘯", num))
            {
                return PathType.CurveTo;
            }
            if (str == BookmarkStart.b("䐯", num))
            {
                return PathType.MoveTo;
            }
        }
        return Class1085.smethod_73(A_0);
    }

    private static bool smethod_3(string A_0)
    {
        string str;
        int num = 0x13;
        if (((str = A_0) == null) || ((!(str == BookmarkStart.b("䬸", num)) && !(str == BookmarkStart.b("伸", num))) && !(str == BookmarkStart.b("䴸", num))))
        {
            return false;
        }
        return true;
    }

    internal static Class623 smethod_4(string A_0)
    {
        int num = 0x10;
        if (!Class567.smethod_16(A_0))
        {
            return new Class623();
        }
        bool flag = false;
        if (A_0.StartsWith(BookmarkStart.b("瘵", num)))
        {
            flag = true;
            A_0 = A_0.TrimStart(new char[] { '@' });
        }
        return new Class623(Class1041.smethod_23(A_0), flag);
    }

    private enum PathParserState
    {
        Restart,
        Command,
        Ref,
        Number
    }
}

