using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

internal class Class206 : Class205, IDisposable
{
    internal Class215 class215_0;
    protected double double_1;
    protected double double_2;
    private float float_3;
    internal List<Class215> list_1;
    internal List<Tab> list_2;

    public Class206(ChildrenLayoutDirection A_0) : base(A_0)
    {
        this.list_1 = new List<Class215>();
        this.list_2 = new List<Tab>();
        this.class215_0 = new Class215();
    }

    public double method_13()
    {
        return this.double_1;
    }

    internal List<Class215> method_14()
    {
        return this.list_1;
    }

    internal List<Tab> method_15()
    {
        return this.list_2;
    }

    internal double method_16()
    {
        return this.double_2;
    }

    internal void method_17(double A_0)
    {
        this.double_2 = A_0;
    }

    internal float method_18()
    {
        return this.float_3;
    }

    internal void method_19(float A_0)
    {
        this.float_3 = A_0;
    }

    public TabLeader method_20()
    {
        return this.class215_0.method_2();
    }

    public TabJustification method_21()
    {
        return this.class215_0.method_0();
    }

    public double method_22(double A_0, Paragraph A_1 = null)
    {
        double num = A_0;
        bool flag = false;
        this.method_23();
        if (this.list_1.Count > 0)
        {
            for (int i = this.list_1.Count - 1; i > -1; i--)
            {
                if ((this.list_1[i].method_4() <= A_0) && ((i <= 0) || (this.list_1[i - 1].method_4() <= A_0)))
                {
                    if (i != (this.list_1.Count - 1))
                    {
                        if (this.list_1[i + 1].method_0() != TabJustification.Bar)
                        {
                            num = this.list_1[i + 1].method_4();
                            this.class215_0 = this.list_1[i + 1];
                        }
                        else
                        {
                            num = A_0;
                        }
                    }
                    flag = true;
                    break;
                }
            }
            if (!flag && (this.list_1[0].method_0() != TabJustification.Bar))
            {
                num = this.list_1[0].method_4();
                this.class215_0 = this.list_1[0];
            }
        }
        if (num == A_0)
        {
            this.class215_0 = new Class215();
            float num5 = 0f;
            A_0 -= this.double_2;
            if (this.method_13() > 0.0)
            {
                double num4 = (Math.Round(A_0, 2) - (Math.Round(A_0, 2) % Math.Round(this.method_13(), 2))) / Math.Round(this.method_13(), 2);
                if ((num4 <= 0.0) && ((num4 != 0.0) || (A_0 < 0.0)))
                {
                    num = 0.0;
                }
                else
                {
                    num = (num4 + 1.0) * this.method_13();
                }
            }
            if (this.list_1.Count == 1)
            {
                float num3 = Math.Abs(this.list_1[0].method_4());
                num5 = (this.method_16() > this.method_13()) ? (num3 - ((float) this.method_16())) : (num3 - ((float) this.method_13()));
                if ((num5 > 0f) && (Math.Round(this.method_13()) > 36.0))
                {
                    A_0 += num5;
                }
            }
        }
        if (Math.Round(num, 2) == Math.Round(A_0, 2))
        {
            return this.method_13();
        }
        return (num - A_0);
    }

    internal void method_23()
    {
        for (int i = 0; i < (this.list_1.Count - 1); i++)
        {
            for (int j = i + 1; j < this.list_1.Count; j++)
            {
                if (this.list_1[i].method_4() > this.list_1[j].method_4())
                {
                    Class215 class2 = this.list_1[i];
                    this.list_1[i] = this.list_1[j];
                    this.list_1[j] = class2;
                }
            }
        }
    }

    public void method_24(float A_0, TabJustification A_1, TabLeader A_2)
    {
        Class215 class2 = new Class215(A_0, A_1, A_2);
        if (!this.method_26(class2))
        {
            this.list_1.Add(class2);
        }
    }

    internal void method_25(float A_0)
    {
        for (int i = this.list_1.Count - 1; i >= 0; i--)
        {
            if (this.list_1[i].method_4() == A_0)
            {
                this.list_1.Remove(this.list_1[i]);
            }
        }
    }

    private bool method_26(Class215 A_0)
    {
        bool flag;
        using (List<Class215>.Enumerator enumerator = this.list_1.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class215 current = enumerator.Current;
                if (((Math.Round((double) current.method_4(), 2) == Math.Round((double) A_0.method_4(), 2)) && (current.method_0() == A_0.method_0())) && (current.method_2() == A_0.method_2()))
                {
                    goto Label_005C;
                }
            }
            return false;
        Label_005C:
            flag = true;
        }
        return flag;
    }

    internal void method_27(Paragraph A_0, float A_1, Class206 A_2)
    {
        Tab tab;
        int num = 12;
        float num2 = 20f;
        A_2.method_15().Clear();
        A_2.list_1.Clear();
        ParagraphFormat paragraphFormat = A_0.Format;
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.NoTabForInd) && (paragraphFormat.FirstLineIndent < 0f))
        {
            A_2.method_24(A_1 + paragraphFormat.LeftIndent, TabJustification.Left, TabLeader.NoLeader);
        }
        IParagraphStyle style = A_0.GetStyle();
        if (style == null)
        {
            style = A_0.Document.Styles.FindByName(BookmarkStart.b("簱嬳䐵唷嬹倻", num), StyleType.ParagraphStyle) as IParagraphStyle;
            if (style == null)
            {
                style = (ParagraphStyle) Style.CreateBuiltinStyle(BuiltinStyle.Normal, A_0.Document);
            }
        }
        if (style.ParagraphFormat.Tabs.Count > 0)
        {
            paragraphFormat = A_0.GetStyle().ParagraphFormat;
        }
        int num3 = 0;
        int count = paragraphFormat.Tabs.Count;
        while (num3 < count)
        {
            tab = paragraphFormat.Tabs[num3];
            if ((tab.Position != 0f) || (tab.DeletePosition == 0f))
            {
                A_2.method_24(((tab.Position != 0f) ? tab.Position : (tab.DeletePosition / num2)) + A_1, (TabJustification) tab.Justification, (TabLeader) tab.TabLeader);
            }
            A_2.method_15().Add(tab);
            num3++;
        }
        paragraphFormat = A_0.Format;
        int num5 = 0;
        int num6 = paragraphFormat.Tabs.Count;
        while (num5 < num6)
        {
            int num10;
            tab = paragraphFormat.Tabs[num5];
            bool flag = false;
            bool flag2 = false;
            int index = 0;
            double d = (tab.DeletePosition / num2) + A_1;
            double num9 = tab.Position + A_1;
            if (A_2.list_1.Count != 0)
            {
                num10 = 0;
                while (num10 < A_2.list_1.Count)
                {
                    if (Math.Truncate((double) A_2.list_1[num10].method_4()) == Math.Truncate(num9))
                    {
                        goto Label_0227;
                    }
                    if (((Math.Truncate((double) A_2.list_1[num10].method_4()) == Math.Truncate(d)) && (tab.DeletePosition != 0f)) && (tab.Position == 0f))
                    {
                        goto Label_0230;
                    }
                    num10++;
                }
            }
            goto Label_0237;
        Label_0227:
            flag = true;
            index = num10;
            goto Label_0237;
        Label_0230:
            flag2 = true;
            index = num10;
        Label_0237:
            if (((tab.Position != 0f) || (tab.DeletePosition == 0f)) && (!flag2 && !flag))
            {
                A_2.method_24(((tab.Position != 0f) ? tab.Position : (tab.DeletePosition / num2)) + A_1, (TabJustification) tab.Justification, (TabLeader) tab.TabLeader);
                A_2.method_15().Add(tab);
            }
            else if (flag2)
            {
                A_2.list_1.RemoveAt(index);
            }
            else if (flag)
            {
                A_2.list_1[index].method_1((TabJustification) tab.Justification);
                A_2.list_1[index].method_5(((tab.Position != 0f) ? tab.Position : (tab.DeletePosition / num2)) + A_1);
                A_2.list_1[index].method_3((TabLeader) tab.TabLeader);
            }
            num5++;
        }
    }

    void IDisposable.Dispose()
    {
        if (this.list_1.Count > 0)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
        if (this.list_2.Count > 0)
        {
            this.list_2.Clear();
            this.list_2 = null;
        }
    }

    internal class Class215
    {
        private float float_0;
        private TabJustification tabJustification_0;
        private TabLeader tabLeader_0;

        internal Class215() : this(0f, TabJustification.Left, TabLeader.NoLeader)
        {
        }

        internal Class215(float A_0, TabJustification A_1, TabLeader A_2)
        {
            this.float_0 = A_0;
            this.tabJustification_0 = A_1;
            this.tabLeader_0 = A_2;
        }

        public TabJustification method_0()
        {
            return this.tabJustification_0;
        }

        public void method_1(TabJustification A_0)
        {
            if (A_0 != this.tabJustification_0)
            {
                this.tabJustification_0 = A_0;
            }
        }

        public TabLeader method_2()
        {
            return this.tabLeader_0;
        }

        public void method_3(TabLeader A_0)
        {
            if (A_0 != this.tabLeader_0)
            {
                this.tabLeader_0 = A_0;
            }
        }

        public float method_4()
        {
            return this.float_0;
        }

        public void method_5(float A_0)
        {
            if (A_0 != this.float_0)
            {
                this.float_0 = A_0;
            }
        }
    }
}

