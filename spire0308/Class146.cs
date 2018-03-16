using Spire.Doc;
using System;
using System.Collections;

internal class Class146
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    internal readonly Class741 class741_0 = new Class741();

    public int method_0()
    {
        return this.class741_0.method_7(0);
    }

    public int method_1()
    {
        if (this.class741_0.method_2() > 0)
        {
            return this.class741_0.method_7(this.class741_0.method_2() - 1);
        }
        return 0;
    }

    public void method_10()
    {
        this.class741_0.method_12();
        this.arrayList_0.Clear();
    }

    public int method_11(int A_0)
    {
        int num = 0x10;
        int num2 = this.method_19(A_0, false);
        if (num2 >= 0)
        {
            return num2;
        }
        if (this.class741_0.method_2() <= 1)
        {
            throw new InvalidOperationException(BookmarkStart.b("电夷吹刻儽㐿扁≃⽅♇⹉汋⽍㹏牑ㅓ㡕ⱗ⡙╛繝ٟൡᙣ䙥ᱧɩ५乭ͯɱᅳᕵᅷᱹᕻ᭽ꊁﮇﾏﲑ뒓ﾕ몙얟芡芫", num));
        }
        return (this.class741_0.method_2() - 2);
    }

    public int method_12(int A_0)
    {
        return this.method_19(A_0, true);
    }

    public int method_13(int A_0)
    {
        return this.class741_0.method_11(A_0);
    }

    public int method_14(int A_0)
    {
        int num2 = 0x10;
        int num = this.method_12(A_0);
        if (num < 0)
        {
            throw new InvalidOperationException(BookmarkStart.b("电夷吹刻儽㐿扁≃⽅♇⹉汋⽍㹏牑ㅓ㡕ⱗ⡙╛繝ٟൡᙣ䙥ᱧɩ५乭ͯɱᅳᕵᅷᱹᕻ᭽ꊁﮇﾏﲑ뒓ﾕ몙얟芡芫", num2));
        }
        return num;
    }

    public Class145 method_15(int A_0)
    {
        for (int i = 0; i < this.class741_0.method_2(); i++)
        {
            if (this.class741_0.method_7(i) >= A_0)
            {
                return new Class145(this, i, this.class741_0.method_7(i));
            }
        }
        return new Class145(this, 0x7fffffff, 0x7fffffff);
    }

    public int method_16(int A_0)
    {
        return this.class741_0.method_7(A_0);
    }

    public void method_17(int A_0, int A_1)
    {
        this.class741_0.method_8(A_0, A_1);
    }

    public object method_18(int A_0)
    {
        return this.arrayList_0[A_0];
    }

    private int method_19(int A_0, bool A_1)
    {
        int num = 0;
        int num2 = this.class741_0.method_2() - 1;
        num2--;
        while (num <= num2)
        {
            int num3 = (num + num2) >> 1;
            int num4 = this.class741_0.method_7(num3);
            int num5 = this.class741_0.method_7(num3 + 1);
            if (A_0 < num4)
            {
                num2 = num3 - 1;
            }
            else
            {
                if (A_0 < num5)
                {
                    if (A_0 == num4)
                    {
                        return num3;
                    }
                    if (!A_1)
                    {
                        return num3;
                    }
                    return ~num;
                }
                num = num3 + 1;
            }
        }
        return ~num;
    }

    public void method_2(int A_0)
    {
        this.class741_0.method_8(this.class741_0.method_2() - 1, A_0);
    }

    public int method_3()
    {
        return this.class741_0.method_2();
    }

    public int method_4()
    {
        return this.arrayList_0.Count;
    }

    public int method_5(int A_0, int A_1, object A_2)
    {
        if (this.class741_0.method_2() == 0)
        {
            this.class741_0.method_9(A_0);
        }
        return this.method_6(A_1, A_2);
    }

    public int method_6(int A_0, object A_1)
    {
        this.class741_0.method_9(A_0);
        return this.arrayList_0.Add(A_1);
    }

    public void method_7(int A_0, int A_1, object A_2)
    {
        this.class741_0.method_19(A_0, A_1);
        this.arrayList_0.Insert(A_0, A_2);
    }

    public void method_8(int A_0)
    {
        this.class741_0.method_9(A_0);
    }

    public void method_9(int A_0)
    {
        this.class741_0.method_24(A_0);
        this.arrayList_0.RemoveAt(A_0);
    }

    string object.ToString()
    {
        return this.class741_0.ToString();
    }
}

