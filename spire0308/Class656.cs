using Spire.Doc;
using System;
using System.Diagnostics;
using System.Reflection;

[DefaultMember("Item"), DebuggerStepThrough]
internal class Class656
{
    private const int int_0 = 0x10;
    private int int_1;
    private int[] int_2;
    private object[] object_0;

    public Class656()
    {
        this.int_2 = new int[0x10];
        this.object_0 = new object[0x10];
    }

    public Class656(int A_0)
    {
        int num = 8;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜭帯嬱䀳張夷嘹缻弽〿⍁❃⽅㱇㍉", num));
        }
        this.int_2 = new int[A_0];
        this.object_0 = new object[A_0];
    }

    public int method_0()
    {
        return this.int_2.Length;
    }

    public void method_1(int A_0)
    {
        int num = 14;
        if (A_0 != this.int_2.Length)
        {
            if (A_0 < this.int_1)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䈳圵吷伹夻", num));
            }
            if (A_0 > 0)
            {
                int[] destinationArray = new int[A_0];
                object[] objArray = new object[A_0];
                if (this.int_1 > 0)
                {
                    Array.Copy(this.int_2, 0, destinationArray, 0, this.int_1);
                    Array.Copy(this.object_0, 0, objArray, 0, this.int_1);
                }
                this.int_2 = destinationArray;
                this.object_0 = objArray;
            }
            else
            {
                this.int_2 = new int[0x10];
                this.object_0 = new object[0x10];
            }
        }
    }

    public bool method_10(object A_0)
    {
        return (this.method_15(A_0) >= 0);
    }

    private void method_11(int A_0)
    {
        int num = (this.int_2.Length == 0) ? 0x10 : (this.int_2.Length * 2);
        if (num < A_0)
        {
            num = A_0;
        }
        this.method_1(num);
    }

    public object method_12(int A_0)
    {
        int num = 0x11;
        if ((A_0 < 0) || (A_0 >= this.int_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("帶圸强堼䜾", num));
        }
        return this.object_0[A_0];
    }

    public int method_13(int A_0)
    {
        int num = 6;
        if ((A_0 < 0) || (A_0 >= this.int_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔫䀭启圱䰳", num));
        }
        return this.int_2[A_0];
    }

    public int method_14(int A_0)
    {
        int num = Class85.smethod_7(this.int_2, 0, this.int_1, A_0);
        if (num < 0)
        {
            return -1;
        }
        return num;
    }

    public int method_15(object A_0)
    {
        return Array.IndexOf<object>(this.object_0, A_0, 0, this.int_1);
    }

    private void method_16(int A_0, int A_1, object A_2)
    {
        if (this.int_1 == this.int_2.Length)
        {
            this.method_11(this.int_1 + 1);
        }
        if (A_0 < this.int_1)
        {
            Array.Copy(this.int_2, A_0, this.int_2, A_0 + 1, this.int_1 - A_0);
            Array.Copy(this.object_0, A_0, this.object_0, A_0 + 1, this.int_1 - A_0);
        }
        this.int_2[A_0] = A_1;
        this.object_0[A_0] = A_2;
        this.int_1++;
    }

    public void method_17(int A_0)
    {
        int num = 13;
        if ((A_0 < 0) || (A_0 >= this.int_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("娲嬴匶尸䌺", num));
        }
        this.int_1--;
        if (A_0 < this.int_1)
        {
            Array.Copy(this.int_2, A_0 + 1, this.int_2, A_0, this.int_1 - A_0);
            Array.Copy(this.object_0, A_0 + 1, this.object_0, A_0, this.int_1 - A_0);
        }
        this.int_2[this.int_1] = 0;
        this.object_0[this.int_1] = null;
    }

    public void method_18(int A_0)
    {
        int num = this.method_14(A_0);
        if (num >= 0)
        {
            this.method_17(num);
        }
    }

    public int[] method_19()
    {
        return this.int_2;
    }

    public int method_2()
    {
        return this.int_1;
    }

    public object[] method_20()
    {
        return this.object_0;
    }

    public void method_21(int A_0, object A_1)
    {
        int num = 9;
        if ((A_0 < 0) || (A_0 >= this.int_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘮弰圲倴伶", num));
        }
        this.object_0[A_0] = A_1;
    }

    public void method_22()
    {
        this.method_1(this.int_1);
    }

    public object method_3(int A_0)
    {
        int index = this.method_14(A_0);
        if (index < 0)
        {
            return null;
        }
        return this.object_0[index];
    }

    public void method_4(int A_0, object A_1)
    {
        int index = Class85.smethod_7(this.int_2, 0, this.int_1, A_0);
        if (index >= 0)
        {
            this.object_0[index] = A_1;
        }
        else
        {
            this.method_16(~index, A_0, A_1);
        }
    }

    public void method_5(int A_0, object A_1)
    {
        int num2 = 0x13;
        int num = Class85.smethod_7(this.int_2, 0, this.int_1, A_0);
        if (num >= 0)
        {
            throw new ArgumentException(BookmarkStart.b("崸为䴼匾⡀⁂⑄㍆ⱈ", num2));
        }
        this.method_16(~num, A_0, A_1);
    }

    public void method_6()
    {
        this.int_1 = 0;
        this.int_2 = new int[0x10];
        this.object_0 = new object[0x10];
    }

    protected Class656 method_7()
    {
        Class656 class2 = (Class656) base.MemberwiseClone();
        class2.int_1 = 0;
        class2.int_2 = new int[this.int_2.Length];
        class2.object_0 = new object[this.object_0.Length];
        return class2;
    }

    public bool method_8(int A_0)
    {
        return (this.method_14(A_0) >= 0);
    }

    public bool method_9(int A_0)
    {
        return (this.method_14(A_0) >= 0);
    }
}

