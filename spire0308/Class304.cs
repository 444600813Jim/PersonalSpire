using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

internal class Class304 : Interface30
{
    private bool bool_0;
    private Class196 class196_0;
    private Class206.Class215 class215_0;
    private Delegate3 delegate3_0;
    private float float_0;
    private int int_0;
    private PointF pointF_0;
    private RectangleF rectangleF_0;
    private RectangleF rectangleF_1;
    private RectangleF rectangleF_2;

    public void imethod_2(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }

    public void imethod_5(int A_0)
    {
        this.int_0 = A_0;
    }

    private void imethod_6(Class375 A_0)
    {
        if (this.delegate3_0 != null)
        {
            this.delegate3_0(this, A_0);
        }
    }

    Class196 Interface30.imethod_0()
    {
        return this.class196_0;
    }

    RectangleF Interface30.imethod_1()
    {
        return this.rectangleF_0;
    }

    Class304 Interface30.imethod_3()
    {
        return this;
    }

    int Interface30.imethod_4()
    {
        return this.int_0;
    }

    public void method_0(Delegate3 A_0)
    {
        Delegate3 delegate3;
        Delegate3 delegate2 = this.delegate3_0;
        do
        {
            delegate3 = delegate2;
            Delegate3 delegate4 = (Delegate3) Delegate.Combine(delegate3, A_0);
            delegate2 = Interlocked.CompareExchange<Delegate3>(ref this.delegate3_0, delegate4, delegate3);
        }
        while (delegate2 != delegate3);
    }

    public void method_1(Delegate3 A_0)
    {
        Delegate3 delegate3;
        Delegate3 delegate2 = this.delegate3_0;
        do
        {
            delegate3 = delegate2;
            Delegate3 delegate4 = (Delegate3) Delegate.Remove(delegate3, A_0);
            delegate2 = Interlocked.CompareExchange<Delegate3>(ref this.delegate3_0, delegate4, delegate3);
        }
        while (delegate2 != delegate3);
    }

    internal bool method_10()
    {
        return this.bool_0;
    }

    internal Class206.Class215 method_11()
    {
        if (this.class215_0 == null)
        {
            this.class215_0 = new Class206.Class215();
        }
        return this.class215_0;
    }

    internal void method_12(Class206.Class215 A_0)
    {
        this.class215_0 = A_0;
    }

    internal float method_13()
    {
        return this.float_0;
    }

    internal void method_14(float A_0)
    {
        this.float_0 = A_0;
    }

    public void method_15(Interface3 A_0, Interface18 A_1, Class196 A_2)
    {
        RectangleF ef;
        RectangleF ef2;
        this.bool_0 = A_0 is HeaderFooter;
        bool flag = false;
        bool flag2 = true;
        Interface3 interface2 = A_0;
        List<Interface3> list = new List<Interface3>();
        List<Class375> list2 = new List<Class375>();
        this.class196_0 = A_2;
        this.class196_0.method_136(this.bool_0);
        this.class196_0.method_133(A_1);
        this.int_0 = 0;
        while (A_1.imethod_1(out ef, out ef2, ref this.int_0, ref flag, flag2))
        {
            if (ef2.Equals(RectangleF.Empty))
            {
                return;
            }
            this.rectangleF_1 = ef2;
            this.imethod_2(ef);
            Class615 class2 = Class615.smethod_0(interface2, this, ef2.Width);
            Class375 class3 = class2.vmethod_0(ef2);
            if (!flag)
            {
                list.Clear();
                list2.Clear();
                A_1.imethod_2(class3);
            }
            else
            {
                list.Insert(list.Count, interface2);
                list2.Insert(list2.Count, class3);
            }
            if (!class2.method_15() && (((class2.method_1() != LayoutState.NotFitted) || (class2.method_0() == null)) || (!(class2.method_0() is Class65) || !((class2.method_0() as Class65).imethod_4(0) is Section))))
            {
                if ((interface2 is Document) || ((interface2 is Class65) && ((interface2 as Class65).method_2() is Document)))
                {
                    this.method_16(A_2, class2.method_3().method_13(), A_1);
                    return;
                }
                break;
            }
            if ((class2.method_1() == LayoutState.NotFitted) && (class2.method_0() != null))
            {
                (this.delegate3_0.Target as Class195).method_36(true);
            }
            this.method_18(class2);
            Class65 class4 = class2.method_0() as Class65;
            bool flag3 = flag;
            if (A_1.imethod_4(class4, class2.method_1(), class3, ref flag3))
            {
                if (flag3 && flag)
                {
                    int count = list2.Count;
                    for (int i = 0; i < count; i++)
                    {
                        A_1.imethod_2(list2[0]);
                        list.RemoveAt(0);
                        list2.RemoveAt(0);
                    }
                }
                else if (flag)
                {
                    A_1.imethod_3(class3);
                }
                interface2 = class4;
            }
            else
            {
                A_1.imethod_3(class3);
                if (list.Count > 0)
                {
                    interface2 = list[0];
                }
            }
        }
    }

    private void method_16(Class196 A_0, RectangleF A_1, Interface18 A_2)
    {
        bool flag = false;
        int num = 0;
        A_1 = new RectangleF(new PointF(A_1.Location.X, A_1.Location.Y + 12f), new SizeF(A_1.Width, A_1.Height - 12f));
        foreach (Footnote footnote in A_0.method_127())
        {
            Class615 class2 = Class615.smethod_0(footnote.TextBody, this, A_1.Width);
            Class375 class3 = class2.vmethod_0(A_1);
            if (class2.method_15() || ((class2.method_1() == LayoutState.NotFitted) && (class2.method_0() != null)))
            {
                RectangleF ef;
                A_0.method_28().method_5().method_7(class3);
                A_2.imethod_1(out ef, out A_1, ref num, ref flag, true);
                A_1.Y += 12f;
                Interface3 interface2 = class2.method_0() as Interface3;
                class2 = Class615.smethod_0(interface2, this, A_1.Width);
                class3 = class2.vmethod_0(A_1);
            }
            A_0.method_28().method_5().method_7(class3);
            A_1 = class2.method_3().method_13();
        }
    }

    private void method_17(Class615 A_0, int A_1, ref bool A_2, ref bool A_3, bool A_4)
    {
        if (((!A_0.method_15() || A_3) || (!A_4 || (A_1 != 0))) || ((!(A_0.method_0() is Class65) || ((A_0.method_0() as Class65).imethod_4(0) is Section)) || (!((A_0.method_0() as Class65).imethod_4(0) is Class65) || !(((A_0.method_0() as Class65).imethod_4(0) as Class65).method_2() is Section))))
        {
            A_2 = true;
            A_3 = false;
            return;
        }
        Section section = ((A_0.method_0() as Class65).imethod_4(0) as Class65).method_2() as Section;
        if (section.Columns.Count <= 1)
        {
            return;
        }
        float width = section.Columns[0].Width;
        bool flag = true;
        using (IEnumerator enumerator = section.Columns.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Column current = (Column) enumerator.Current;
                if (width != current.Width)
                {
                    goto Label_010C;
                }
                width = current.Width;
            }
            goto Label_0124;
        Label_010C:
            flag = false;
        }
    Label_0124:
        if (!flag && !section.PageSetup.EqualColumnWidth)
        {
            A_2 = false;
            A_3 = true;
        }
    }

    private void method_18(Class615 A_0)
    {
        if (A_0.method_15())
        {
            Interface1 interface3 = A_0.method_0();
            Class65 class4 = null;
            while (interface3 != null)
            {
                if (!(interface3 is Class65))
                {
                    break;
                }
                class4 = interface3 as Class65;
                interface3 = class4.method_0();
            }
            if (((class4 != null) && (interface3 is DocumentObject)) && interface3.imethod_0().imethod_14())
            {
                List<Interface1> list = new List<Interface1>();
                int num2 = class4.method_3();
                Interface1 item = interface3;
                for (Interface1 interface5 = (item as DocumentObject).PreviousSibling as Interface1; interface5 != null; interface5 = (interface5 as DocumentObject).PreviousSibling as Interface1)
                {
                    if (!interface5.imethod_0().imethod_20())
                    {
                        break;
                    }
                    num2--;
                    item = interface5;
                    list.Add(item);
                }
                if (num2 < class4.method_3())
                {
                    class4.method_4(num2);
                    class4.method_1(item);
                    Class375 class6 = null;
                    Class375 class5 = A_0.method_5();
                    while (true)
                    {
                        if ((class5 == null) || (class5.method_74().Count <= 0))
                        {
                            break;
                        }
                        if (((class5.method_73() is Paragraph) && (class5.method_74().Count > 0)) && (class5.method_74().method_4(0).method_73() is Paragraph))
                        {
                            class6 = class5;
                            break;
                        }
                        class5 = class5.method_74().method_4(class5.method_74().Count - 1);
                    }
                    if (class6 != null)
                    {
                        for (int i = class6.method_74().Count - 1; i >= 0; i--)
                        {
                            if (list.Count <= 0)
                            {
                                break;
                            }
                            Class375 class2 = class6.method_74().method_4(i);
                            for (int j = class2.method_74().Count - 1; j >= 0; j--)
                            {
                                Class375 class3 = class2.method_74().method_4(j);
                                Interface1 interface2 = class3.method_73();
                                interface2 = (interface2 is Class7) ? ((interface2 as Class7).TextBox as Interface1) : interface2;
                                if (list.Contains(interface2))
                                {
                                    class2.method_72().method_45(class3);
                                    class2.method_72().method_42(class3);
                                    class2.method_74().method_11(class3);
                                    list.Remove(interface2);
                                }
                                if (list.Count <= 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                list = null;
            }
        }
    }

    internal List<int> method_2()
    {
        return (this.delegate3_0.Target as Class195).method_37();
    }

    internal bool method_3()
    {
        return (this.delegate3_0.Target as Class195).bool_8;
    }

    internal RectangleF method_4()
    {
        return this.rectangleF_1;
    }

    internal bool method_5()
    {
        return (this.delegate3_0.Target as Class195).bool_9;
    }

    internal RectangleF method_6()
    {
        return this.rectangleF_2;
    }

    internal void method_7(RectangleF A_0)
    {
        this.rectangleF_2 = A_0;
    }

    internal PointF method_8()
    {
        return this.pointF_0;
    }

    internal void method_9(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    public static void smethod_0()
    {
        Class374.smethod_0().method_0();
    }

    public delegate void Delegate3(object A_0, Class375 A_1);
}

