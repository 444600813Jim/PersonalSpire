using Spire.Doc.Fields;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

internal class Class1065
{
    private readonly Class147 class147_0;
    private readonly Class153 class153_0;
    private readonly Class155 class155_0;
    private readonly Class162 class162_0;
    private readonly Class344 class344_0;
    private readonly Hashtable hashtable_0;
    private readonly Hashtable hashtable_1;
    private readonly StringCollection stringCollection_0;

    internal Class1065()
    {
        this.class153_0 = new Class153();
        this.class155_0 = new Class155();
        this.stringCollection_0 = new StringCollection();
        this.class162_0 = new Class162();
        this.class147_0 = new Class147(0);
        this.class344_0 = new Class344();
        this.hashtable_1 = new Hashtable();
    }

    internal Class1065(Class703 A_0, BinaryReader A_1)
    {
        this.class153_0 = new Class153();
        this.class155_0 = new Class155();
        this.stringCollection_0 = new StringCollection();
        this.class162_0 = new Class162();
        this.class147_0 = new Class147(0);
        this.class344_0 = new Class344();
        this.hashtable_0 = new Hashtable();
        A_1.BaseStream.Position = A_0.class597_0.class1111_36.int_0;
        int num = A_0.class597_0.class1111_36.int_0 + A_0.class597_0.class1111_36.int_1;
        while (A_1.BaseStream.Position < num)
        {
            this.stringCollection_0.Add(Class813.smethod_1(A_1, true, false));
        }
        this.class153_0.method_23(A_1, A_0.class597_0.class1111_4);
        this.class153_0.method_26(A_1, A_0.class929_0.class1111_4.int_0, A_0.class929_0.class1111_4.int_1);
        this.class155_0.method_23(A_1, A_0.class597_0.class1111_5);
        this.class162_0.method_23(A_1, A_0.class597_0.class1111_42);
        this.class147_0.method_23(A_1, A_0.class597_0.class1111_43);
        this.class344_0.method_0(A_1, A_0.class597_0.class1111_37.int_0, A_0.class597_0.class1111_37.int_1);
        smethod_0(this.class162_0);
        smethod_0(this.class147_0);
        this.method_0();
    }

    private void method_0()
    {
        for (int i = 0; i < this.class162_0.method_4(); i++)
        {
            Class662 class2 = (Class662) this.class162_0.method_18(i);
            this.hashtable_0[class2.int_1] = i;
        }
    }

    internal void method_1(Class703 A_0, BinaryWriter A_1)
    {
        A_0.class597_0.class1111_36.int_0 = (int) A_1.BaseStream.Position;
        using (StringEnumerator enumerator = this.stringCollection_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class813.smethod_2(enumerator.Current, 0x37, A_1, true, false);
            }
        }
        A_0.class597_0.class1111_36.int_1 = ((int) A_1.BaseStream.Position) - A_0.class597_0.class1111_36.int_0;
        A_0.class597_0.class1111_4.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_4.int_1 = this.class153_0.vmethod_1(A_1);
        A_0.class929_0.class1111_4.int_0 = (int) A_1.BaseStream.Position;
        A_0.class929_0.class1111_4.int_1 = this.class153_0.method_27(A_1);
        A_0.class597_0.class1111_5.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_5.int_1 = this.class155_0.vmethod_1(A_1);
        this.method_2();
        A_0.class597_0.class1111_42.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_42.int_1 = this.class162_0.vmethod_1(A_1);
        A_0.class597_0.class1111_43.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_43.int_1 = this.class147_0.vmethod_1(A_1);
        A_0.class597_0.class1111_37.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_37.int_1 = this.class344_0.method_3(A_1);
    }

    internal Class155 method_10()
    {
        return this.class155_0;
    }

    internal Class162 method_11()
    {
        return this.class162_0;
    }

    internal Class147 method_12()
    {
        return this.class147_0;
    }

    internal int method_13(int A_0)
    {
        return this.class344_0.method_5(A_0);
    }

    internal int method_14(int A_0)
    {
        return this.method_13((int) this.hashtable_0[A_0]);
    }

    private void method_2()
    {
        for (int i = 0; i < this.class162_0.method_4(); i++)
        {
            Class662 class2 = (Class662) this.class162_0.method_18(i);
            class2.int_1 = (int) this.hashtable_1[this.method_13(i)];
        }
    }

    internal string method_3(int A_0)
    {
        if ((A_0 >= 0) && (A_0 < this.stringCollection_0.Count))
        {
            return this.stringCollection_0[A_0];
        }
        return "";
    }

    internal void method_4(int A_0, Comment A_1)
    {
        Class872 class2 = new Class872 {
            string_0 = A_1.Format.Initial,
            dateTime_0 = A_1.Format.DateTime,
            int_3 = this.stringCollection_0.IndexOf(A_1.Format.Author)
        };
        if (class2.int_3 < 0)
        {
            class2.int_3 = this.stringCollection_0.Count;
            this.stringCollection_0.Add(A_1.Format.Author);
        }
        class2.int_4 = A_1.TempHasRange ? A_1.Format.CommentId : -1;
        this.class153_0.method_6(A_0, class2);
    }

    internal void method_5(int A_0)
    {
        this.class155_0.method_6(A_0, null);
    }

    internal void method_6(int A_0)
    {
        this.class155_0.method_8(A_0);
    }

    internal void method_7(int A_0, int A_1)
    {
        this.class162_0.method_6(A_0, new Class662());
        this.class344_0.method_6(A_1);
    }

    internal void method_8(int A_0, int A_1)
    {
        int num = this.class147_0.method_6(A_0, null);
        this.hashtable_1[A_1] = num;
    }

    internal Class153 method_9()
    {
        return this.class153_0;
    }

    private static void smethod_0(Class146 A_0)
    {
        if (A_0.method_3() > 0)
        {
            A_0.method_2(0x7fffffff);
        }
    }
}

