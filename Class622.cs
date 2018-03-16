using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

[DefaultMember("Item")]
internal class Class622
{
    private readonly ArrayList arrayList_0;

    internal Class622()
    {
        this.arrayList_0 = new ArrayList();
    }

    internal Class622(Class622 A_0) : this()
    {
        this.arrayList_0.AddRange(A_0.arrayList_0);
    }

    internal Class622(Class722 A_0) : this()
    {
        this.arrayList_0.Add(A_0);
    }

    internal Class622(Class722 A_0, Class722 A_1) : this()
    {
        this.arrayList_0.Add(A_0);
        this.arrayList_0.Add(A_1);
    }

    internal void method_0(Class722 A_0)
    {
        ArrayList list = (ArrayList) this.arrayList_0.Clone();
        bool flag = false;
        for (int i = 0; i < list.Count; i++)
        {
            Class722 class2 = (Class722) list[i];
            Class622 class3 = Class670.smethod_0(class2, A_0);
            if (class3.method_8() == 1)
            {
                flag = true;
                this.arrayList_0.Remove(class2);
                this.arrayList_0.Remove(A_0);
                A_0 = class3.method_9(0);
                this.arrayList_0.Add(A_0);
            }
        }
        if (!flag)
        {
            this.arrayList_0.Add(A_0);
        }
    }

    internal void method_1(Class622 A_0)
    {
        foreach (Class722 class2 in A_0.arrayList_0)
        {
            this.method_0(class2);
        }
    }

    internal void method_2(Class722 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal void method_3(bool A_0)
    {
        for (int i = 0; i < this.method_8(); i++)
        {
            ((Class722) this.arrayList_0[i]).method_0(A_0);
        }
    }

    internal void method_4(spr➂ A_0)
    {
        foreach (Class722 class2 in this.arrayList_0)
        {
            class2.method_13(A_0);
        }
    }

    internal Class722[] method_5()
    {
        return (Class722[]) this.arrayList_0.ToArray(typeof(Class722));
    }

    internal RectangleF method_6()
    {
        ArrayList list = new ArrayList();
        for (int i = 0; i < this.method_8(); i++)
        {
            list.AddRange(this.method_9(i).method_11());
        }
        if (list.Count != 0)
        {
            return spr⃸.ᜁ((PointF[]) list.ToArray(typeof(PointF)));
        }
        return RectangleF.Empty;
    }

    internal void method_7(Class722 A_0)
    {
        ArrayList c = new ArrayList(this.arrayList_0.Count);
        for (int i = 0; i < this.method_8(); i++)
        {
            Class722 class2 = Class670.smethod_2(A_0, this.method_9(i));
            if (class2.method_19() != 0)
            {
                c.Add(class2);
            }
        }
        this.arrayList_0.Clear();
        this.arrayList_0.AddRange(c);
    }

    internal int method_8()
    {
        return this.arrayList_0.Count;
    }

    internal Class722 method_9(int A_0)
    {
        int num = 0x11;
        if ((0 > A_0) || (A_0 >= this.method_8()))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("帶圸强堼䜾", num));
        }
        return (Class722) this.arrayList_0[A_0];
    }
}

