using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Text;

internal class Class883 : IDisposable
{
    private bool bool_0;
    private Field field_0;
    private int int_0;
    internal List<Struct28> list_0;
    private List<int> list_1;
    internal List<Struct30> list_2;
    private Struct30 struct30_0;
    private Struct30 struct30_1;

    public Class883(Field A_0)
    {
        int num5 = 0x11;
        this.list_0 = new List<Struct28>();
        this.list_1 = new List<int>();
        this.list_2 = new List<Struct30>();
        this.int_0 = -2147483648;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("儶倸帺儼嬾", num5));
        }
        this.field_0 = A_0;
        ICompositeObject owner = A_0.Owner as ICompositeObject;
        if (owner != null)
        {
            int index = owner.ChildObjects.IndexOf(A_0);
            int num2 = -1;
            if (A_0.Owner.Owner != null)
            {
                num2 = (A_0.Owner.Owner as ICompositeObject).ChildObjects.IndexOf(A_0.Owner);
            }
            this.struct30_0 = new Struct30(num2, index);
            int num3 = owner.ChildObjects.IndexOf(A_0.Range.method_10());
            int num4 = -1;
            if (A_0.Range.method_10() is ParagraphBase)
            {
                num4 = num2;
            }
            else if (A_0.Range.method_10() is Paragraph)
            {
                Paragraph entity = A_0.Range.method_10() as Paragraph;
                num3 = entity.Items.IndexOf(A_0.End);
                num4 = entity.Owner.ChildObjects.IndexOf(entity);
            }
            this.struct30_1 = new Struct30(num4, num3);
        }
    }

    public Struct30 method_0()
    {
        return this.struct30_1;
    }

    internal void method_1(Struct30 A_0)
    {
        this.struct30_1 = A_0;
    }

    public Struct29 method_10(Struct28 A_0)
    {
        return this.method_11(A_0, this);
    }

    internal Struct29 method_11(Struct28 A_0, Class883 A_1)
    {
        if (A_0.method_0())
        {
            return new Struct29();
        }
        Struct29 struct3 = new Struct29();
        Struct28 struct4 = A_0.method_1();
        bool flag = false;
        int num2 = -1;
        int num = 0;
        int count = A_1.list_0.Count;
        while (num < count)
        {
            Struct28 struct5 = A_1.list_0[num];
            if ((!flag && (struct4.int_1 >= struct5.int_1)) && (struct4.int_1 < struct5.int_0))
            {
                Struct30 struct6 = A_1.list_2[num];
                struct6.method_3(struct4.int_1 - A_1.list_0[num].int_1);
                struct3.method_3(struct6);
                num2 = num;
                flag = true;
            }
            if ((flag && (struct4.int_0 > struct5.int_1)) && (struct4.int_0 <= struct5.int_0))
            {
                if ((num < (count - 1)) && (struct4.int_0 < struct5.int_0))
                {
                    struct3.method_1(A_1.list_2[num]);
                }
                else if ((num < (count - 1)) && (struct4.int_0 == struct5.int_0))
                {
                    struct3.method_1(A_1.list_2[num + 1]);
                }
                else if (num2 == (count - 1))
                {
                    struct3.method_1(struct3.method_2());
                }
                else
                {
                    struct3.method_1(this.struct30_1);
                }
            }
            num++;
        }
        return struct3;
    }

    public bool method_2()
    {
        return this.bool_0;
    }

    public void method_3(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public string method_4()
    {
        StringBuilder builder = new StringBuilder();
        foreach (Struct28 struct2 in this.list_0)
        {
            builder.Append(struct2.string_0);
        }
        this.int_0 = builder.Length;
        return builder.ToString();
    }

    public int method_5()
    {
        if (this.int_0 == -2147483648)
        {
            this.int_0 = this.method_4().Length;
        }
        return this.int_0;
    }

    public Struct30 method_6()
    {
        return this.struct30_0;
    }

    internal void method_7(Struct30 A_0)
    {
        this.struct30_0 = A_0;
    }

    public void method_8(string A_0, int A_1)
    {
        Struct28 struct2;
        struct2 = new Struct28 {
            string_0 = A_0,
            int_1 = this.method_4().Length,
            int_0 = struct2.int_1 + A_0.Length
        };
        this.list_0.Add(struct2);
        this.list_1.Add(A_1);
    }

    public void method_9(string A_0, Struct30 A_1)
    {
        Struct28 struct2;
        struct2 = new Struct28 {
            string_0 = A_0,
            int_1 = this.method_4().Length,
            int_0 = struct2.int_1 + A_0.Length
        };
        this.list_0.Add(struct2);
        this.list_2.Add(A_1);
    }

    void IDisposable.Dispose()
    {
        if (this.field_0 != null)
        {
            this.field_0 = null;
        }
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
    }
}

