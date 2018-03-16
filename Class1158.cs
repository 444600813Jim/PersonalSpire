using Spire.CompoundFile.Doc.Net;
using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
internal class Class1158 : IEnumerable
{
    private Class1157 class1157_0;
    private IComparer icomparer_0;
    private int int_0;

    public Class1158()
    {
        this.icomparer_0 = Comparer<object>.Default;
        this.method_4();
    }

    public Class1158(IComparer A_0)
    {
        int num = 13;
        this.icomparer_0 = Comparer<object>.Default;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("倲娴娶䤸娺似娾㍀", num));
        }
        this.method_4();
        this.icomparer_0 = A_0;
    }

    public Class1157 method_0()
    {
        return this.class1157_0;
    }

    public int method_1()
    {
        return this.int_0;
    }

    protected Class1157 method_10(object A_0)
    {
        Class1157 class2 = this.class1157_0.method_4();
        Class1157 class3 = this.class1157_0;
        while (!class2.method_8())
        {
            if (this.icomparer_0.Compare(class2.method_10(), A_0) < 0)
            {
                class2 = class2.method_2();
            }
            else
            {
                class3 = class2;
                class2 = class2.method_0();
            }
        }
        return class3;
    }

    protected Class1157 method_11(object A_0)
    {
        Class1157 class2 = this.class1157_0.method_4();
        Class1157 class3 = this.class1157_0;
        while (!class2.method_8())
        {
            if (this.icomparer_0.Compare(A_0, class2.method_10()) < 0)
            {
                class3 = class2;
                class2 = class2.method_0();
            }
            else
            {
                class2 = class2.method_2();
            }
        }
        return class3;
    }

    protected void method_12(Class1157 A_0)
    {
        Class1157 class2 = A_0.method_2();
        A_0.method_3(class2.method_0());
        if (!class2.method_0().method_8())
        {
            class2.method_0().method_5(A_0);
        }
        class2.method_5(A_0.method_4());
        if (A_0 == this.class1157_0.method_4())
        {
            this.class1157_0.method_5(class2);
        }
        else if (A_0 == A_0.method_4().method_0())
        {
            A_0.method_4().method_1(class2);
        }
        else
        {
            A_0.method_4().method_3(class2);
        }
        class2.method_1(A_0);
        A_0.method_5(class2);
    }

    protected void method_13(Class1157 A_0)
    {
        Class1157 class2 = A_0.method_0();
        A_0.method_1(class2.method_2());
        if (!class2.method_2().method_8())
        {
            class2.method_2().method_5(A_0);
        }
        class2.method_5(A_0.method_4());
        if (A_0 == this.class1157_0.method_4())
        {
            this.class1157_0.method_5(class2);
        }
        else if (A_0 == A_0.method_4().method_2())
        {
            A_0.method_4().method_3(class2);
        }
        else
        {
            A_0.method_4().method_1(class2);
        }
        class2.method_3(A_0);
        A_0.method_5(class2);
    }

    protected void method_14(Class1157 A_0)
    {
        Class1157 class2 = A_0;
        while (!class2.method_8())
        {
            this.method_14(class2.method_2());
            class2 = class2.method_0();
            A_0 = class2;
        }
    }

    protected void method_15(bool A_0, Class1157 A_1, object A_2, object A_3)
    {
        Class1157 class2 = new Class1157(this.class1157_0, A_1, this.class1157_0, A_2, A_3);
        this.int_0++;
        if (A_1 == this.class1157_0)
        {
            Class1157 class3;
            Class1157 class4;
            this.class1157_0.method_3(class3 = class2);
            this.class1157_0.method_1(class4 = class3);
            this.class1157_0.method_5(class4);
        }
        else if (A_0)
        {
            A_1.method_1(class2);
            if (A_1 == this.class1157_0.method_0())
            {
                this.class1157_0.method_1(class2);
            }
        }
        else
        {
            A_1.method_3(class2);
            if (A_1 == this.class1157_0.method_2())
            {
                this.class1157_0.method_3(class2);
            }
        }
        Class1157 class5 = class2;
        while (class5.method_4().method_6() == NodeColor.Red)
        {
            if (class5.method_4() == class5.method_4().method_4().method_0())
            {
                A_1 = class5.method_4().method_4().method_2();
                if (A_1.method_6() == NodeColor.Red)
                {
                    class5.method_4().method_7(NodeColor.Black);
                    A_1.method_7(NodeColor.Black);
                    class5.method_4().method_4().method_7(NodeColor.Red);
                    class5 = class5.method_4().method_4();
                }
                else
                {
                    if (class5 == class5.method_4().method_2())
                    {
                        class5 = class5.method_4();
                        this.method_12(class5);
                    }
                    class5.method_4().method_7(NodeColor.Black);
                    class5.method_4().method_4().method_7(NodeColor.Red);
                    this.method_13(class5.method_4().method_4());
                }
            }
            else
            {
                A_1 = class5.method_4().method_4().method_0();
                if (A_1.method_6() == NodeColor.Red)
                {
                    class5.method_4().method_7(NodeColor.Black);
                    A_1.method_7(NodeColor.Black);
                    class5.method_4().method_4().method_7(NodeColor.Red);
                    class5 = class5.method_4().method_4();
                }
                else
                {
                    if (class5 == class5.method_4().method_0())
                    {
                        class5 = class5.method_4();
                        this.method_13(class5);
                    }
                    class5.method_4().method_7(NodeColor.Black);
                    class5.method_4().method_4().method_7(NodeColor.Red);
                    this.method_12(class5.method_4().method_4());
                }
            }
        }
        this.class1157_0.method_4().method_7(NodeColor.Black);
    }

    internal void method_16(Delegate10 A_0)
    {
        this.method_17(this.class1157_0, A_0);
    }

    private void method_17(Class1157 A_0, Delegate10 A_1)
    {
        if ((A_0 != null) && ((!A_0.method_8() || !A_0.method_0().method_8()) || !A_0.method_2().method_8()))
        {
            if (!A_0.method_8())
            {
                A_1(A_0);
            }
            this.method_17(A_0.method_0(), A_1);
            this.method_17(A_0.method_2(), A_1);
        }
    }

    public object method_2(object A_0)
    {
        Class1157 class2 = this.method_10(A_0);
        if (this.icomparer_0.Compare(class2.method_10(), A_0) == 0)
        {
            return class2.method_12();
        }
        return null;
    }

    public void method_3(object A_0, object A_1)
    {
        Class1157 class2 = this.method_10(A_0);
        if (!class2.method_8() && (this.icomparer_0.Compare(class2.method_10(), A_0) == 0))
        {
            class2.method_13(A_1);
        }
        else
        {
            this.method_6(A_0, A_1);
        }
    }

    protected void method_4()
    {
        Class1157 class2;
        Class1157 class3;
        this.class1157_0 = new Class1157(null, null, null, null, null, NodeColor.Black);
        this.class1157_0.method_9(true);
        this.class1157_0.method_3(class2 = this.class1157_0);
        this.class1157_0.method_1(class3 = class2);
        this.class1157_0.method_5(class3);
        this.int_0 = 0;
    }

    public void method_5()
    {
        Class1157 class2;
        Class1157 class3;
        this.method_14(this.class1157_0.method_4());
        this.class1157_0.method_3(class2 = this.class1157_0);
        this.class1157_0.method_1(class3 = class2);
        this.class1157_0.method_5(class3);
        this.int_0 = 0;
    }

    public void method_6(object A_0, object A_1)
    {
        Class1157 class2 = this.class1157_0.method_4();
        Class1157 class3 = this.class1157_0;
        bool flag = true;
        while (!class2.method_8())
        {
            class3 = class2;
            class2 = (flag = this.icomparer_0.Compare(A_0, class2.method_10()) < 0) ? class2.method_0() : class2.method_2();
        }
        Class1157 class4 = class3;
        if (flag)
        {
            if (class3 == this.method_9())
            {
                this.method_15(true, class3, A_0, A_1);
                return;
            }
            class4 = smethod_3(class4);
        }
        this.method_15(flag, class3, A_0, A_1);
    }

    public bool method_7(object A_0)
    {
        Class1157 class2 = this.method_10(A_0);
        return ((class2 != this.class1157_0) && (this.icomparer_0.Compare(class2.method_10(), A_0) == 0));
    }

    public void method_8(object A_0)
    {
        Class1157 class2 = this.method_10(A_0);
        if (!class2.method_8())
        {
            Class1157 class4;
            Class1157 class5;
            Class1157 class3 = class2;
            if (class3.method_0().method_8())
            {
                class5 = class3.method_2();
            }
            else if (class3.method_2().method_8())
            {
                class5 = class3.method_0();
            }
            else
            {
                class3 = smethod_2(class2);
                class5 = class3.method_2();
            }
            if (class3 == class2)
            {
                class4 = class2.method_4();
                if (!class5.method_8())
                {
                    class5.method_5(class4);
                }
                if (this.class1157_0.method_4() == class2)
                {
                    this.class1157_0.method_5(class5);
                }
                else if (class4.method_0() == class2)
                {
                    class4.method_1(class5);
                }
                else
                {
                    class4.method_3(class5);
                }
                if (this.class1157_0.method_0() == class2)
                {
                    this.class1157_0.method_1(class5.method_8() ? class4 : smethod_0(class5));
                }
                if (this.class1157_0.method_2() == class2)
                {
                    this.class1157_0.method_3(class5.method_8() ? class4 : smethod_1(class5));
                }
            }
            else
            {
                class2.method_0().method_5(class3);
                class3.method_1(class2.method_0());
                if (class3 == class2.method_2())
                {
                    class4 = class3;
                }
                else
                {
                    class4 = class3.method_4();
                    if (!class5.method_8())
                    {
                        class5.method_5(class4);
                    }
                    class4.method_1(class5);
                    class3.method_3(class2.method_2());
                    class2.method_2().method_5(class3);
                }
                if (this.class1157_0.method_4() == class2)
                {
                    this.class1157_0.method_5(class3);
                }
                else if (class2.method_4().method_0() == class2)
                {
                    class2.method_4().method_1(class3);
                }
                else
                {
                    class2.method_4().method_3(class3);
                }
                class3.method_5(class2.method_4());
                NodeColor color = class2.method_6();
                class2.method_7(class3.method_6());
                class3.method_7(color);
            }
            if (class2.method_6() == NodeColor.Black)
            {
                while (true)
                {
                    if ((class5 == this.class1157_0.method_4()) || (class5.method_6() != NodeColor.Black))
                    {
                        break;
                    }
                    if (class5 == class4.method_0())
                    {
                        class3 = class4.method_2();
                        if (class3.method_6() == NodeColor.Red)
                        {
                            class3.method_7(NodeColor.Black);
                            class4.method_7(NodeColor.Red);
                            this.method_12(class4);
                            class3 = class4.method_2();
                        }
                        if (class3.method_8())
                        {
                            class5 = class4;
                        }
                        else
                        {
                            if ((class3.method_0().method_6() != NodeColor.Black) || (class3.method_2().method_6() != NodeColor.Black))
                            {
                                if (class3.method_2().method_6() == NodeColor.Black)
                                {
                                    class3.method_0().method_7(NodeColor.Black);
                                    class3.method_7(NodeColor.Red);
                                    this.method_13(class3);
                                    class3 = class4.method_2();
                                }
                                class3.method_7(class4.method_6());
                                class4.method_7(NodeColor.Black);
                                class3.method_2().method_7(NodeColor.Black);
                                this.method_12(class4);
                                break;
                            }
                            class3.method_7(NodeColor.Red);
                            class5 = class4;
                        }
                    }
                    else
                    {
                        class3 = class4.method_0();
                        if (class3.method_6() == NodeColor.Red)
                        {
                            class3.method_7(NodeColor.Black);
                            class4.method_7(NodeColor.Red);
                            this.method_13(class4);
                            class3 = class4.method_0();
                        }
                        if (class3.method_8())
                        {
                            class5 = class4;
                        }
                        else
                        {
                            if ((class3.method_2().method_6() != NodeColor.Black) || (class3.method_0().method_6() != NodeColor.Black))
                            {
                                if (class3.method_0().method_6() == NodeColor.Black)
                                {
                                    class3.method_2().method_7(NodeColor.Black);
                                    class3.method_7(NodeColor.Red);
                                    this.method_12(class3);
                                    class3 = class4.method_0();
                                }
                                class3.method_7(class4.method_6());
                                class4.method_7(NodeColor.Black);
                                class3.method_0().method_7(NodeColor.Black);
                                this.method_13(class4);
                                break;
                            }
                            class3.method_7(NodeColor.Red);
                            class5 = class4;
                        }
                    }
                    class4 = class5.method_4();
                }
                class5.method_7(NodeColor.Black);
            }
            if (0 < this.int_0)
            {
                this.int_0--;
            }
        }
    }

    private Class1157 method_9()
    {
        return this.class1157_0.method_0();
    }

    public static Class1157 smethod_0(Class1157 A_0)
    {
        while (!A_0.method_0().method_8())
        {
            A_0 = A_0.method_0();
        }
        return A_0;
    }

    public static Class1157 smethod_1(Class1157 A_0)
    {
        while (!A_0.method_2().method_8())
        {
            A_0 = A_0.method_2();
        }
        return A_0;
    }

    public static Class1157 smethod_2(Class1157 A_0)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娳夵尷弹", num));
        }
        if (!A_0.method_8())
        {
            if (A_0.method_2().method_8())
            {
                Class1157 class2;
                while (!(class2 = A_0.method_4()).method_8())
                {
                    if (A_0 != class2.method_2())
                    {
                        break;
                    }
                    A_0 = class2;
                }
                A_0 = class2;
                return A_0;
            }
            A_0 = smethod_0(A_0.method_2());
        }
        return A_0;
    }

    public static Class1157 smethod_3(Class1157 A_0)
    {
        Class1157 class2;
        int num = 4;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐩䌫䨭唯", num));
        }
        if (A_0.method_8())
        {
            A_0 = A_0.method_2();
            return A_0;
        }
        if (A_0.method_0().method_8())
        {
            while (!(class2 = A_0.method_4()).method_8())
            {
                if (class2 != class2.method_0())
                {
                    break;
                }
                A_0 = class2;
            }
        }
        else
        {
            A_0 = smethod_1(A_0.method_0());
            return A_0;
        }
        if (!class2.method_8())
        {
            A_0 = class2;
        }
        return A_0;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new Class1159(this.class1157_0.method_0());
    }

    internal delegate void Delegate10(Class1157 A_0);
}

