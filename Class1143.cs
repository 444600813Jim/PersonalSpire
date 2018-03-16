using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Drawing;
using System.Text;

internal class Class1143
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private Class43 class43_0;
    private readonly StringBuilder stringBuilder_0 = new StringBuilder();

    internal Class1143()
    {
    }

    internal void method_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2)
    {
        int num = 0x13;
        Class576.smethod_94(1.0);
        string str = A_0.method_11().method_1();
        ShapeObject obj2 = new ShapeObject(A_0.method_9());
        if (A_2 != null)
        {
            A_2.method_37(obj2.CharacterFormat);
        }
        this.class43_0 = new Class43();
        this.class43_0.SetAttr(0x103b, ShapeType.NonPrimitive);
        this.method_2(A_0);
        Class746.smethod_1(A_0, obj2.ShapePr);
        this.method_1(A_0, str, obj2);
        this.class43_0.method_37(obj2.ShapePr);
        Class746.smethod_2(obj2, (Class98) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("常䤺尼伾⥀⩂♄", num), A_0.method_20(), true));
        A_1.method_13(obj2);
    }

    private void method_1(Class857 A_0, string A_1, ShapeObject A_2)
    {
        while (A_0.method_11().method_9(A_1))
        {
            if (!A_0.method_5(this.class43_0))
            {
                Class857.smethod_13(A_0, A_2);
            }
        }
    }

    private void method_2(Class857 A_0)
    {
        int num = 13;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        string str = "";
        while (class2.method_19())
        {
            string str2;
            if ((!A_0.method_2(A_0.method_11(), this.class43_0) && !Class857.smethod_7(A_0, this.class43_0)) && (!Class857.smethod_6(A_0, this.class43_0) && ((str2 = class2.method_1()) != null)))
            {
                if (str2 != BookmarkStart.b("圲", num))
                {
                    if (!(str2 == BookmarkStart.b("䔲尴制丸示刼䜾", num)))
                    {
                        if (str2 == BookmarkStart.b("䜲䜴嘶圸䠺嬼倾㍀⹂", num))
                        {
                            str = class2.method_3();
                        }
                    }
                    else
                    {
                        Class857.smethod_12(A_0, class2.method_3(), false, false, this.class43_0);
                    }
                }
                else
                {
                    this.method_3(class2.method_3());
                    this.method_5();
                }
            }
        }
        Class857.smethod_4(this.class43_0, str);
    }

    private void method_3(string A_0)
    {
        for (int i = 0; i < A_0.Length; i++)
        {
            char ch = A_0[i];
            if (Class922.smethod_5(ch) != PathType.Unknown)
            {
                this.method_4();
                this.arrayList_0.Add(ch);
            }
            else if ((!char.IsDigit(ch) && (ch != '-')) && !char.IsLetter(ch))
            {
                this.method_4();
            }
            else
            {
                if (ch == '-')
                {
                    this.method_4();
                }
                this.stringBuilder_0.Append(ch);
            }
        }
        this.method_4();
    }

    private void method_4()
    {
        if (this.stringBuilder_0.ToString().Length > 0)
        {
            this.arrayList_0.Add(this.stringBuilder_0.ToString());
        }
        this.stringBuilder_0.Length = 0;
    }

    private void method_5()
    {
        ArrayList list = new ArrayList();
        ArrayList list2 = new ArrayList();
        PathType unknown = PathType.Unknown;
        int num = 0;
        Class679 class2 = new Class679();
        Class891 class3 = new Class891();
        char ch = 'M';
        Class891 class4 = new Class891();
        Class891 class5 = new Class891();
        while (num < this.arrayList_0.Count)
        {
            if (smethod_3(this.arrayList_0[num]))
            {
                ch = (char) this.arrayList_0[num];
                unknown = Class922.smethod_5(ch);
                if (unknown != PathType.ArcTo)
                {
                    class2 = new Class679(unknown, 1);
                    if (class2.method_2() == 0)
                    {
                        list2.Add(class2);
                    }
                }
                num++;
            }
            else
            {
                switch (unknown)
                {
                    case PathType.Unknown:
                    case PathType.ArcTo:
                        goto Label_0242;
                }
                list2.Add(class2);
                int num5 = class2.method_2();
                for (int k = 0; k < num5; k++)
                {
                    Class891 class6 = new Class891();
                    char ch2 = char.ToUpper(ch);
                    if ((ch2 == 'S') && (k == 0))
                    {
                        class6 = smethod_1(class3, class4);
                    }
                    else if ((ch2 == 'T') && (k == 0))
                    {
                        class6 = smethod_1(class3, class5);
                    }
                    else
                    {
                        if (ch2 == 'V')
                        {
                            class6 = new Class891(class3.method_0(), class6.method_1());
                        }
                        else
                        {
                            class6 = new Class891(smethod_0((string) this.arrayList_0[num++]), class6.method_1());
                            if (char.IsLower(ch))
                            {
                                class6 = new Class891(class6.method_0().method_1() + class3.method_0().method_1(), class6.method_1().method_1());
                            }
                        }
                        if (ch2 == 'H')
                        {
                            class6 = new Class891(class6.method_0(), class3.method_1());
                        }
                        else
                        {
                            class6 = new Class891(class6.method_0(), smethod_0((string) this.arrayList_0[num++]));
                            if (char.IsLower(ch))
                            {
                                class6 = new Class891(class6.method_0().method_1(), class6.method_1().method_1() + class3.method_1().method_1());
                            }
                        }
                    }
                    if (k == (num5 - 1))
                    {
                        class3 = class6;
                    }
                    if (unknown == PathType.CurveTo)
                    {
                        if (k == 1)
                        {
                            class4 = class6;
                        }
                    }
                    else
                    {
                        class4 = class3;
                    }
                    if (unknown == PathType.QuadraticBezier)
                    {
                        if (k == 0)
                        {
                            class5 = class6;
                        }
                    }
                    else
                    {
                        class5 = class3;
                    }
                    list.Add(class6);
                }
            }
            continue;
        Label_0242:
            num++;
        }
        if (class2.method_0() != PathType.Close)
        {
            list2.Insert(0, new Class679(PathType.NoFill, 1));
        }
        Class891[] classArray2 = new Class891[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            classArray2[i] = (Class891) list[i];
        }
        Class679[] classArray = new Class679[list2.Count];
        for (int j = 0; j < list2.Count; j++)
        {
            classArray[j] = (Class679) list2[j];
        }
        this.class43_0.SetAttr(0x145, classArray2);
        this.class43_0.SetAttr(0x146, classArray);
    }

    private static Class623 smethod_0(string A_0)
    {
        int num = Class576.smethod_2(Class1041.smethod_18(A_0));
        if (num != -2147483648)
        {
            return new Class623(num, false);
        }
        return new Class623();
    }

    private static Class891 smethod_1(Class891 A_0, Class891 A_1)
    {
        return new Class891(new Point(smethod_2(A_0.method_0().method_1(), A_1.method_0().method_1()), smethod_2(A_0.method_1().method_1(), A_1.method_1().method_1())));
    }

    private static int smethod_2(int A_0, int A_1)
    {
        return ((2 * A_0) - A_1);
    }

    private static bool smethod_3(object A_0)
    {
        int num = 15;
        return ((A_0 is char) && (BookmarkStart.b("破娶挸䄺焼匾ी⭂ፄㅆੈ⡊Ṍ㱎P≒Ŕ⍖ᡘ㩚", num).IndexOf((char) A_0) != -1));
    }
}

