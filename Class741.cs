using Spire.Doc;
using System;
using System.Reflection;
using System.Text;

[DefaultMember("Item")]
internal class Class741
{
    private const int int_0 = 0x10;
    private int[] int_1;
    private int int_2;

    public Class741()
    {
        this.int_1 = new int[0x10];
    }

    public Class741(int A_0)
    {
        int num = 0;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔥䤧娩䴫䴭夯䘱䴳", num));
        }
        this.int_1 = new int[A_0];
    }

    public int method_0()
    {
        return this.int_1.Length;
    }

    public void method_1(int A_0)
    {
        int num = 5;
        if (A_0 != this.int_1.Length)
        {
            if (A_0 < this.int_2)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("崪䰬䌮䐰嘲", num));
            }
            if (A_0 > 0)
            {
                int[] destinationArray = new int[A_0];
                if (this.int_2 > 0)
                {
                    Array.Copy(this.int_1, 0, destinationArray, 0, this.int_2);
                }
                this.int_1 = destinationArray;
            }
            else
            {
                this.int_1 = new int[0x10];
            }
        }
    }

    public int method_10(int A_0, int A_1, int A_2)
    {
        int num = 2;
        if ((A_0 < 0) || (A_1 < 0))
        {
            throw new ArgumentOutOfRangeException((A_0 < 0) ? BookmarkStart.b("䄧䐩䠫䬭䠯", num) : BookmarkStart.b("䬧䔩夫䀭䐯", num));
        }
        if ((this.int_2 - A_0) < A_1)
        {
            throw new ArgumentException(BookmarkStart.b("䄧䐩䠫䬭䠯ሱ唳堵尷ᨹ弻儽㔿ⱁぃ", num));
        }
        return Array.BinarySearch<int>(this.int_1, A_0, A_1, A_2);
    }

    public int method_11(int A_0)
    {
        return this.method_10(0, this.method_2(), A_0);
    }

    public void method_12()
    {
        Array.Clear(this.int_1, 0, this.int_2);
        this.int_2 = 0;
    }

    public Class741 method_13()
    {
        Class741 class2 = new Class741(this.int_2) {
            int_2 = this.int_2
        };
        Array.Copy(this.int_1, 0, class2.int_1, 0, this.int_2);
        return class2;
    }

    public bool method_14(int A_0)
    {
        for (int i = 0; i < this.int_2; i++)
        {
            if (A_0 == this.int_1[i])
            {
                return true;
            }
        }
        return false;
    }

    private void method_15(int A_0)
    {
        if (this.int_1.Length < A_0)
        {
            int num = (this.int_1.Length == 0) ? 0x10 : (this.int_1.Length * 2);
            if (num < A_0)
            {
                num = A_0;
            }
            this.method_1(num);
        }
    }

    public int method_16(int A_0)
    {
        return Array.IndexOf<int>(this.int_1, A_0, 0, this.int_2);
    }

    public int method_17(int A_0, int A_1)
    {
        int num = 12;
        if (A_1 > this.int_2)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䄱䀳圵䨷丹画倽␿❁㱃", num));
        }
        return Array.IndexOf<int>(this.int_1, A_0, A_1, this.int_2 - A_1);
    }

    public int method_18(int A_0, int A_1, int A_2)
    {
        int num = 0;
        if ((A_1 + A_2) > this.int_2)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔥䜧弩䈫娭", num));
        }
        return Array.IndexOf<int>(this.int_1, A_0, A_1, A_2);
    }

    public void method_19(int A_0, int A_1)
    {
        int num = 1;
        if ((A_0 < 0) || (A_0 > this.int_2))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("並䜨伪䠬圮", num));
        }
        if (this.int_2 == this.int_1.Length)
        {
            this.method_15(this.int_2 + 1);
        }
        if (A_0 < this.int_2)
        {
            Array.Copy(this.int_1, A_0, this.int_1, A_0 + 1, this.int_2 - A_0);
        }
        this.int_1[A_0] = A_1;
        this.int_2++;
    }

    public int method_2()
    {
        return this.int_2;
    }

    public int method_20(int A_0)
    {
        return this.method_22(A_0, this.int_2 - 1, this.int_2);
    }

    public int method_21(int A_0, int A_1)
    {
        int num = 10;
        if (A_1 >= this.int_2)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌯䘱唳䐵䰷猹刻娽┿㩁", num));
        }
        return this.method_22(A_0, A_1, A_1 + 1);
    }

    public int method_22(int A_0, int A_1, int A_2)
    {
        int num = 3;
        if (this.int_2 == 0)
        {
            return -1;
        }
        if ((A_1 < 0) || (A_2 < 0))
        {
            throw new ArgumentOutOfRangeException((A_1 < 0) ? BookmarkStart.b("娨弪䰬崮䔰稲嬴匶尸䌺", num) : BookmarkStart.b("䨨䐪堬䄮䔰", num));
        }
        if ((A_1 >= this.int_2) || (A_2 > (A_1 + 1)))
        {
            throw new ArgumentOutOfRangeException((A_1 >= this.int_2) ? BookmarkStart.b("娨弪䰬崮䔰稲嬴匶尸䌺", num) : BookmarkStart.b("䨨䐪堬䄮䔰", num));
        }
        return Array.LastIndexOf<int>(this.int_1, A_0, A_1, A_2);
    }

    public void method_23(int A_0)
    {
        int num = this.method_16(A_0);
        if (num >= 0)
        {
            this.method_24(num);
        }
    }

    public void method_24(int A_0)
    {
        int num = 7;
        if ((A_0 < 0) || (A_0 >= this.int_2))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䐬䄮唰嘲䴴", num));
        }
        this.int_2--;
        if (A_0 < this.int_2)
        {
            Array.Copy(this.int_1, A_0 + 1, this.int_1, A_0, this.int_2 - A_0);
        }
        this.int_1[this.int_2] = 0;
    }

    public void method_25(int A_0, int A_1)
    {
        int num = 13;
        if ((A_0 < 0) || (A_1 < 0))
        {
            throw new ArgumentOutOfRangeException((A_0 < 0) ? BookmarkStart.b("娲嬴匶尸䌺", num) : BookmarkStart.b("倲娴䈶圸伺", num));
        }
        if ((this.int_2 - A_0) < A_1)
        {
            throw new ArgumentException(BookmarkStart.b("娲嬴匶尸䌺ᴼ帾⽀❂敄⑆♈㹊⍌㭎", num));
        }
        if (A_1 > 0)
        {
            int num2 = this.int_2;
            this.int_2 -= A_1;
            if (A_0 < this.int_2)
            {
                Array.Copy(this.int_1, A_0 + A_1, this.int_1, A_0, this.int_2 - A_0);
            }
            while (num2 > this.int_2)
            {
                this.int_1[--num2] = 0;
            }
        }
    }

    public void method_26()
    {
        this.method_27(0, this.method_2());
    }

    public void method_27(int A_0, int A_1)
    {
        int num = 3;
        if ((A_0 < 0) || (A_1 < 0))
        {
            throw new ArgumentOutOfRangeException((A_0 < 0) ? BookmarkStart.b("䀨䔪䤬䨮䤰", num) : BookmarkStart.b("䨨䐪堬䄮䔰", num));
        }
        if ((this.int_2 - A_0) < A_1)
        {
            throw new ArgumentException(BookmarkStart.b("䀨䔪䤬䨮䤰ጲ吴夶崸ᬺ帼倾㑀ⵂㅄ", num));
        }
        Array.Reverse(this.int_1, A_0, A_1);
    }

    public void method_28()
    {
        this.method_29(0, this.method_2());
    }

    public void method_29(int A_0, int A_1)
    {
        int num = 4;
        if ((A_0 < 0) || (A_1 < 0))
        {
            throw new ArgumentOutOfRangeException((A_0 < 0) ? BookmarkStart.b("䌩䈫䨭唯䨱", num) : BookmarkStart.b("䤩䌫嬭帯䘱", num));
        }
        if ((this.int_2 - A_0) < A_1)
        {
            throw new ArgumentException(BookmarkStart.b("䌩䈫䨭唯䨱ᐳ圵嘷帹᰻崽⼿㝁⩃㉅", num));
        }
        Array.Sort<int>(this.int_1, A_0, A_1);
    }

    public bool method_3()
    {
        return false;
    }

    public int[] method_30()
    {
        int[] destinationArray = new int[this.int_2];
        Array.Copy(this.int_1, 0, destinationArray, 0, this.int_2);
        return destinationArray;
    }

    public void method_31()
    {
        this.method_1(this.int_2);
    }

    public bool method_4()
    {
        return false;
    }

    public bool method_5()
    {
        return false;
    }

    public object method_6()
    {
        return this;
    }

    public int method_7(int A_0)
    {
        int num = 5;
        if ((A_0 < 0) || (A_0 >= this.int_2))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䈪䌬䬮吰䬲", num));
        }
        return this.int_1[A_0];
    }

    public void method_8(int A_0, int A_1)
    {
        int num = 14;
        if ((A_0 < 0) || (A_0 >= this.int_2))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("崳堵尷弹䐻", num));
        }
        this.int_1[A_0] = A_1;
    }

    public int method_9(int A_0)
    {
        if (this.int_2 == this.int_1.Length)
        {
            this.method_15(this.int_2 + 1);
        }
        this.int_1[this.int_2] = A_0;
        return this.int_2++;
    }

    string object.ToString()
    {
        int num = 2;
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < this.method_2(); i++)
        {
            builder.Append(this.method_7(i));
            if (i < (this.method_2() - 1))
            {
                builder.Append(BookmarkStart.b("ࠧ", num));
            }
        }
        return builder.ToString();
    }
}

