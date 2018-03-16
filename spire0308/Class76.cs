using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

[DefaultMember("Item")]
internal class Class76 : IEnumerable
{
    private readonly Interface63 interface63_0;

    internal Class76(Interface63 A_0)
    {
        this.interface63_0 = A_0;
    }

    public Class1031 method_0(BorderType A_0)
    {
        int num = 1;
        object obj2 = this.interface63_0.imethod_3()[A_0];
        if (obj2 == null)
        {
            throw new InvalidOperationException(BookmarkStart.b("猦䄨个ബ崮吰䈲䀴制䨸伺堼嬾慀⅂⩄㕆ⵈ⹊㽌潎㡐⁒畔㥖㙘⽚絜㹞ᝠɢ౤୦ࡨ४Ŭ੮兰ᕲᩴն奸ེᕼᙾꎂﮎ뾐", num));
        }
        int num2 = (int) obj2;
        Class1031 class2 = (Class1031) this.interface63_0.imethod_0(num2);
        if (class2 == null)
        {
            class2 = new Class1031(this.interface63_0, num2);
            this.interface63_0.imethod_2(num2, class2);
        }
        return class2;
    }

    public Class1031 method_1(int A_0)
    {
        BorderType key = (BorderType) this.interface63_0.imethod_3().GetKey(A_0);
        return this.method_0(key);
    }

    public void method_10(double A_0)
    {
        foreach (BorderType type in this.interface63_0.imethod_3().GetKeyList())
        {
            if (smethod_0(type))
            {
                this.method_0(type).method_4(A_0);
            }
        }
    }

    public BorderStyle method_11()
    {
        return this.method_1(0).method_1();
    }

    public void method_12(BorderStyle A_0)
    {
        foreach (BorderType type in this.interface63_0.imethod_3().GetKeyList())
        {
            if (smethod_0(type))
            {
                this.method_0(type).method_2(A_0);
            }
        }
    }

    public Color method_13()
    {
        return this.method_15();
    }

    public void method_14(Color A_0)
    {
        this.method_16(A_0);
    }

    internal Color method_15()
    {
        return this.method_1(0).method_12();
    }

    internal void method_16(Color A_0)
    {
        foreach (BorderType type in this.interface63_0.imethod_3().GetKeyList())
        {
            if (smethod_0(type))
            {
                this.method_0(type).method_13(A_0);
            }
        }
    }

    internal bool method_17()
    {
        return this.method_1(0).method_18();
    }

    internal void method_18(bool A_0)
    {
        foreach (BorderType type in this.interface63_0.imethod_3().GetKeyList())
        {
            if (smethod_0(type))
            {
                this.method_0(type).method_19(A_0);
            }
        }
    }

    internal bool method_19(BorderType A_0)
    {
        return this.interface63_0.imethod_3().Contains(A_0);
    }

    public Class1031 method_2()
    {
        return this.method_0(BorderType.Left);
    }

    public double method_20()
    {
        return this.method_1(0).method_14();
    }

    public void method_21(double A_0)
    {
        foreach (BorderType type in this.interface63_0.imethod_3().GetKeyList())
        {
            if (smethod_0(type))
            {
                this.method_0(type).method_15(A_0);
            }
        }
    }

    public bool method_22()
    {
        return this.method_1(0).method_16();
    }

    public void method_23(bool A_0)
    {
        foreach (BorderType type in this.interface63_0.imethod_3().GetKeyList())
        {
            if (smethod_0(type))
            {
                this.method_0(type).method_17(A_0);
            }
        }
    }

    public void method_24()
    {
        using (IEnumerator enumerator = this.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                ((Class1031) enumerator.Current).method_0();
            }
        }
    }

    internal bool method_25()
    {
        bool flag;
        using (IEnumerator enumerator = this.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class1031 current = (Class1031) enumerator.Current;
                if (current.method_7())
                {
                    goto Label_0028;
                }
            }
            return false;
        Label_0028:
            flag = true;
        }
        return flag;
    }

    public Class1031 method_3()
    {
        return this.method_0(BorderType.Right);
    }

    public Class1031 method_4()
    {
        return this.method_0(BorderType.Top);
    }

    public Class1031 method_5()
    {
        return this.method_0(BorderType.Bottom);
    }

    public Class1031 method_6()
    {
        return this.method_0(BorderType.Horizontal);
    }

    public Class1031 method_7()
    {
        return this.method_0(BorderType.Vertical);
    }

    public int method_8()
    {
        return this.interface63_0.imethod_3().Count;
    }

    public double method_9()
    {
        return this.method_1(0).method_3();
    }

    private static bool smethod_0(BorderType A_0)
    {
        return ((A_0 != BorderType.DiagonalDown) && (A_0 != BorderType.DiagonalUp));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new Class77(this);
    }

    private class Class77 : IEnumerator
    {
        private readonly Class76 class76_0;
        private int int_0;

        internal Class77(Class76 A_0)
        {
            this.class76_0 = A_0;
            this.int_0 = -1;
        }

        bool IEnumerator.MoveNext()
        {
            if (this.int_0 >= (this.class76_0.method_8() - 1))
            {
                return false;
            }
            this.int_0++;
            return true;
        }

        void IEnumerator.Reset()
        {
            this.int_0 = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return this.class76_0.method_1(this.int_0);
            }
        }
    }
}

