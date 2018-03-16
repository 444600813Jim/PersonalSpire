using Spire.Doc;
using System;

internal sealed class Class607
{
    internal byte[] byte_0;
    internal Class1001 class1001_0 = new Class1001();
    internal Class1068 class1068_0;
    internal Class608 class608_0 = new Class608();
    private const int int_0 = 0x5a0;
    private const int int_1 = 0;
    private const int int_10 = 9;
    private static readonly int[] int_11 = new int[] { 
        0, 1, 3, 7, 15, 0x1f, 0x3f, 0x7f, 0xff, 0x1ff, 0x3ff, 0x7ff, 0xfff, 0x1fff, 0x3fff, 0x7fff, 
        0xffff
     };
    internal static readonly int[] int_12 = new int[] { 
        0x10, 0x11, 0x12, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 
        14, 1, 15
     };
    internal int[] int_13 = new int[1];
    internal int int_14;
    internal int int_15;
    internal int[] int_16;
    internal int int_17;
    internal int[] int_18;
    internal int int_19;
    private const int int_2 = 1;
    internal int int_20;
    internal int int_21;
    internal int int_22;
    internal int int_23;
    internal int int_24;
    internal int[] int_25 = new int[1];
    internal int int_26;
    private const int int_3 = 2;
    private const int int_4 = 3;
    private const int int_5 = 4;
    private const int int_6 = 5;
    private const int int_7 = 6;
    private const int int_8 = 7;
    private const int int_9 = 8;
    internal long long_0;
    internal object object_0;

    internal Class607(Class1068 A_0, object A_1, int A_2)
    {
        this.class1068_0 = A_0;
        this.int_18 = new int[0x10e0];
        this.byte_0 = new byte[A_2];
        this.int_17 = A_2;
        this.object_0 = A_1;
        this.int_22 = 0;
        this.method_0(null);
    }

    internal void method_0(long[] A_0)
    {
        if (A_0 != null)
        {
            A_0[0] = this.long_0;
        }
        if (this.int_22 != 4)
        {
        }
        this.int_22 = 0;
        this.int_15 = 0;
        this.int_14 = 0;
        this.int_26 = 0;
        this.int_23 = 0;
        if (this.object_0 != null)
        {
            this.class1068_0.long_2 = this.long_0 = Class603.smethod_0(0L, null, 0, 0);
        }
    }

    internal int method_1(int A_0)
    {
        int num9;
        int num = 5;
        int sourceIndex = this.class1068_0.int_0;
        int num3 = this.class1068_0.int_1;
        int num4 = this.int_14;
        int num5 = this.int_15;
        int destinationIndex = this.int_26;
        int num7 = (destinationIndex < this.int_23) ? ((this.int_23 - destinationIndex) - 1) : (this.int_17 - destinationIndex);
        goto Label_0879;
    Label_005C:
        this.int_14 = num4;
        this.int_15 = num5;
        this.class1068_0.int_1 = num3;
        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
        this.class1068_0.int_0 = sourceIndex;
        this.int_26 = destinationIndex;
        if ((A_0 = this.class608_0.method_1(this, A_0)) != 1)
        {
            return this.method_5(A_0);
        }
        A_0 = 0;
        sourceIndex = this.class1068_0.int_0;
        num3 = this.class1068_0.int_1;
        num4 = this.int_14;
        num5 = this.int_15;
        destinationIndex = this.int_26;
        num7 = (destinationIndex < this.int_23) ? ((this.int_23 - destinationIndex) - 1) : (this.int_17 - destinationIndex);
        if (this.int_20 != 0)
        {
            this.int_22 = 7;
            goto Label_0EAF;
        }
        this.int_22 = 0;
        goto Label_0879;
    Label_02E6:
        num9 = this.int_24;
        if (this.int_19 < ((0x102 + (num9 & 0x1f)) + ((num9 >> 5) & 0x1f)))
        {
            num9 = this.int_13[0];
            while (num5 < num9)
            {
                if (num3 == 0)
                {
                    this.int_14 = num4;
                    this.int_15 = num5;
                    this.class1068_0.int_1 = num3;
                    this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                    this.class1068_0.int_0 = sourceIndex;
                    this.int_26 = destinationIndex;
                    return this.method_5(A_0);
                }
                A_0 = 0;
                num3--;
                num4 |= (this.class1068_0.byte_0[sourceIndex++] & 0xff) << num5;
                num5 += 8;
            }
            num9 = this.int_18[((this.int_25[0] + (num4 & int_11[num9])) * 3) + 1];
            int num15 = this.int_18[((this.int_25[0] + (num4 & int_11[num9])) * 3) + 2];
            if (num15 < 0x10)
            {
                num4 = Class604.smethod_0(num4, num9);
                num5 -= num9;
                this.int_16[this.int_19++] = num15;
            }
            else
            {
                int index = (num15 == 0x12) ? 7 : (num15 - 14);
                int num18 = (num15 == 0x12) ? 11 : 3;
                while (num5 < (num9 + index))
                {
                    if (num3 == 0)
                    {
                        this.int_14 = num4;
                        this.int_15 = num5;
                        this.class1068_0.int_1 = num3;
                        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                        this.class1068_0.int_0 = sourceIndex;
                        this.int_26 = destinationIndex;
                        return this.method_5(A_0);
                    }
                    A_0 = 0;
                    num3--;
                    num4 |= (this.class1068_0.byte_0[sourceIndex++] & 0xff) << num5;
                    num5 += 8;
                }
                num4 = Class604.smethod_0(num4, num9);
                num5 -= num9;
                num18 += num4 & int_11[index];
                num4 = Class604.smethod_0(num4, index);
                num5 -= index;
                index = this.int_19;
                num9 = this.int_24;
                if (((index + num18) > ((0x102 + (num9 & 0x1f)) + ((num9 >> 5) & 0x1f))) || ((num15 == 0x10) && (index < 1)))
                {
                    this.int_16 = null;
                    this.int_22 = 9;
                    this.class1068_0.string_0 = BookmarkStart.b("䈪䌬央倰弲尴匶ᤸ夺吼䬾慀⽂⁄⥆⹈㽊╌潎⍐㙒╔㉖㡘⽚", num);
                    A_0 = -3;
                    this.int_14 = num4;
                    this.int_15 = num5;
                    this.class1068_0.int_1 = num3;
                    this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                    this.class1068_0.int_0 = sourceIndex;
                    this.int_26 = destinationIndex;
                    return this.method_5(-3);
                }
                num15 = (num15 == 0x10) ? this.int_16[index - 1] : 0;
                do
                {
                    this.int_16[index++] = num15;
                }
                while (--num18 != 0);
                this.int_19 = index;
            }
            goto Label_02E6;
        }
        this.int_25[0] = -1;
        int[] numArray6 = new int[] { 9 };
        int[] numArray8 = new int[] { 6 };
        int[] numArray9 = new int[1];
        int[] numArray10 = new int[1];
        num9 = this.int_24;
        num9 = this.class1001_0.method_2(0x101 + (num9 & 0x1f), 1 + ((num9 >> 5) & 0x1f), this.int_16, numArray6, numArray8, numArray9, numArray10, this.int_18, this.class1068_0);
        if (num9 != 0)
        {
            if (num9 == -3)
            {
                this.int_16 = null;
                this.int_22 = 9;
            }
            A_0 = num9;
            this.int_14 = num4;
            this.int_15 = num5;
            this.class1068_0.int_1 = num3;
            this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
            this.class1068_0.int_0 = sourceIndex;
            this.int_26 = destinationIndex;
            return this.method_5(A_0);
        }
        this.class608_0.method_0(numArray6[0], numArray8[0], this.int_18, numArray9[0], this.int_18, numArray10[0]);
        this.int_22 = 6;
        goto Label_005C;
    Label_042E:
        while (this.int_19 < (4 + Class604.smethod_0(this.int_24, 10)))
        {
            while (num5 < 3)
            {
                if (num3 == 0)
                {
                    this.int_14 = num4;
                    this.int_15 = num5;
                    this.class1068_0.int_1 = num3;
                    this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                    this.class1068_0.int_0 = sourceIndex;
                    this.int_26 = destinationIndex;
                    return this.method_5(A_0);
                }
                A_0 = 0;
                num3--;
                num4 |= (this.class1068_0.byte_0[sourceIndex++] & 0xff) << num5;
                num5 += 8;
            }
            this.int_16[int_12[this.int_19++]] = num4 & 7;
            num4 = Class604.smethod_0(num4, 3);
            num5 -= 3;
        }
        while (this.int_19 < 0x13)
        {
            this.int_16[int_12[this.int_19++]] = 0;
        }
        this.int_13[0] = 7;
        num9 = this.class1001_0.method_1(this.int_16, this.int_13, this.int_25, this.int_18, this.class1068_0);
        if (num9 != 0)
        {
            A_0 = num9;
            if (A_0 == -3)
            {
                this.int_16 = null;
                this.int_22 = 9;
            }
            this.int_14 = num4;
            this.int_15 = num5;
            this.class1068_0.int_1 = num3;
            this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
            this.class1068_0.int_0 = sourceIndex;
            this.int_26 = destinationIndex;
            return this.method_5(A_0);
        }
        this.int_19 = 0;
        this.int_22 = 5;
        goto Label_02E6;
    Label_0879:
        switch (this.int_22)
        {
            case 0:
                while (num5 < 3)
                {
                    if (num3 == 0)
                    {
                        this.int_14 = num4;
                        this.int_15 = num5;
                        this.class1068_0.int_1 = num3;
                        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                        this.class1068_0.int_0 = sourceIndex;
                        this.int_26 = destinationIndex;
                        return this.method_5(A_0);
                    }
                    A_0 = 0;
                    num3--;
                    num4 |= (this.class1068_0.byte_0[sourceIndex++] & 0xff) << num5;
                    num5 += 8;
                }
                num9 = num4 & 7;
                this.int_20 = num9 & 1;
                switch (Class604.smethod_0(num9, 1))
                {
                    case 0:
                        num4 = Class604.smethod_0(num4, 3);
                        num5 -= 3;
                        num9 = num5 & 7;
                        num4 = Class604.smethod_0(num4, num9);
                        num5 -= num9;
                        this.int_22 = 1;
                        break;

                    case 1:
                    {
                        int[] numArray = new int[1];
                        int[] numArray2 = new int[1];
                        int[][] numArray3 = new int[1][];
                        int[][] numArray4 = new int[1][];
                        Class1001.smethod_0(numArray, numArray2, numArray3, numArray4, this.class1068_0);
                        this.class608_0.method_0(numArray[0], numArray2[0], numArray3[0], 0, numArray4[0], 0);
                        num4 = Class604.smethod_0(num4, 3);
                        num5 -= 3;
                        this.int_22 = 6;
                        break;
                    }
                    case 2:
                        num4 = Class604.smethod_0(num4, 3);
                        num5 -= 3;
                        this.int_22 = 3;
                        break;

                    case 3:
                        num4 = Class604.smethod_0(num4, 3);
                        num5 -= 3;
                        this.int_22 = 9;
                        this.class1068_0.string_0 = BookmarkStart.b("䈪䌬央倰弲尴匶ᤸ夺儼倾≀⡂敄㍆え㭊⡌", num);
                        A_0 = -3;
                        this.int_14 = num4;
                        this.int_15 = num5;
                        this.class1068_0.int_1 = num3;
                        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                        this.class1068_0.int_0 = sourceIndex;
                        this.int_26 = destinationIndex;
                        return this.method_5(-3);
                }
                goto Label_0879;

            case 1:
                while (num5 < 0x20)
                {
                    if (num3 == 0)
                    {
                        this.int_14 = num4;
                        this.int_15 = num5;
                        this.class1068_0.int_1 = num3;
                        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                        this.class1068_0.int_0 = sourceIndex;
                        this.int_26 = destinationIndex;
                        return this.method_5(A_0);
                    }
                    A_0 = 0;
                    num3--;
                    num4 |= (this.class1068_0.byte_0[sourceIndex++] & 0xff) << num5;
                    num5 += 8;
                }
                if ((Class604.smethod_0(~num4, 0x10) & 0xffff) != (num4 & 0xffff))
                {
                    this.int_22 = 9;
                    this.class1068_0.string_0 = BookmarkStart.b("䈪䌬央倰弲尴匶ᤸ䠺䤼倾㍀♂⅄杆⭈❊≌ⱎ㩐獒㥔㉖㝘㱚⥜㝞በ", num);
                    A_0 = -3;
                    this.int_14 = num4;
                    this.int_15 = num5;
                    this.class1068_0.int_1 = num3;
                    this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                    this.class1068_0.int_0 = sourceIndex;
                    this.int_26 = destinationIndex;
                    return this.method_5(-3);
                }
                this.int_21 = num4 & 0xffff;
                num5 = 0;
                num4 = 0;
                this.int_22 = (this.int_21 != 0) ? 2 : ((this.int_20 != 0) ? 7 : 0);
                goto Label_0879;

            case 2:
                if (num3 == 0)
                {
                    this.int_14 = num4;
                    this.int_15 = num5;
                    this.class1068_0.int_1 = num3;
                    this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                    this.class1068_0.int_0 = sourceIndex;
                    this.int_26 = destinationIndex;
                    return this.method_5(A_0);
                }
                if (num7 == 0)
                {
                    if ((destinationIndex == this.int_17) && (this.int_23 != 0))
                    {
                        destinationIndex = 0;
                        num7 = (0 < this.int_23) ? ((this.int_23 - destinationIndex) - 1) : (this.int_17 - destinationIndex);
                    }
                    if (num7 == 0)
                    {
                        this.int_26 = destinationIndex;
                        A_0 = this.method_5(A_0);
                        destinationIndex = this.int_26;
                        num7 = (destinationIndex < this.int_23) ? ((this.int_23 - destinationIndex) - 1) : (this.int_17 - destinationIndex);
                        if ((destinationIndex == this.int_17) && (this.int_23 != 0))
                        {
                            destinationIndex = 0;
                            num7 = (0 < this.int_23) ? ((this.int_23 - destinationIndex) - 1) : (this.int_17 - destinationIndex);
                        }
                        if (num7 == 0)
                        {
                            this.int_14 = num4;
                            this.int_15 = num5;
                            this.class1068_0.int_1 = num3;
                            this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                            this.class1068_0.int_0 = sourceIndex;
                            this.int_26 = destinationIndex;
                            return this.method_5(A_0);
                        }
                    }
                }
                A_0 = 0;
                num9 = this.int_21;
                if (num9 > num3)
                {
                    num9 = num3;
                }
                if (num9 > num7)
                {
                    num9 = num7;
                }
                Array.Copy(this.class1068_0.byte_0, sourceIndex, this.byte_0, destinationIndex, num9);
                sourceIndex += num9;
                num3 -= num9;
                destinationIndex += num9;
                num7 -= num9;
                this.int_21 -= num9;
                if (this.int_21 == 0)
                {
                    this.int_22 = (this.int_20 != 0) ? 7 : 0;
                }
                goto Label_0879;

            case 3:
                while (num5 < 14)
                {
                    if (num3 == 0)
                    {
                        this.int_14 = num4;
                        this.int_15 = num5;
                        this.class1068_0.int_1 = num3;
                        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                        this.class1068_0.int_0 = sourceIndex;
                        this.int_26 = destinationIndex;
                        return this.method_5(A_0);
                    }
                    A_0 = 0;
                    num3--;
                    num4 |= (this.class1068_0.byte_0[sourceIndex++] & 0xff) << num5;
                    num5 += 8;
                }
                this.int_24 = num9 = num4 & 0x3fff;
                if (((num9 & 0x1f) > 0x1d) || (((num9 >> 5) & 0x1f) > 0x1d))
                {
                    this.int_22 = 9;
                    this.class1068_0.string_0 = BookmarkStart.b("弪䈬䀮ᄰ帲吴夶䀸ᬺ儼娾⽀⑂ㅄ⽆楈⑊㽌潎㕐㩒♔⍖㡘㕚㹜㩞䅠ၢᱤ੦୨ѪŬᱮ", num);
                    A_0 = -3;
                    this.int_14 = num4;
                    this.int_15 = num5;
                    this.class1068_0.int_1 = num3;
                    this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                    this.class1068_0.int_0 = sourceIndex;
                    this.int_26 = destinationIndex;
                    return this.method_5(-3);
                }
                num9 = (0x102 + (num9 & 0x1f)) + ((num9 >> 5) & 0x1f);
                if ((this.int_16 != null) && (this.int_16.Length >= num9))
                {
                    for (int i = 0; i < num9; i++)
                    {
                        this.int_16[i] = 0;
                    }
                }
                else
                {
                    this.int_16 = new int[num9];
                }
                num4 = Class604.smethod_0(num4, 14);
                num5 -= 14;
                this.int_19 = 0;
                this.int_22 = 4;
                goto Label_042E;

            case 4:
                goto Label_042E;

            case 5:
                goto Label_02E6;

            case 6:
                goto Label_005C;

            case 7:
                break;

            case 8:
                goto Label_0F56;

            case 9:
                A_0 = -3;
                this.int_14 = num4;
                this.int_15 = num5;
                this.class1068_0.int_1 = num3;
                this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                this.class1068_0.int_0 = sourceIndex;
                this.int_26 = destinationIndex;
                return this.method_5(-3);

            default:
                A_0 = -2;
                this.int_14 = num4;
                this.int_15 = num5;
                this.class1068_0.int_1 = num3;
                this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
                this.class1068_0.int_0 = sourceIndex;
                this.int_26 = destinationIndex;
                return this.method_5(-2);
        }
    Label_0EAF:
        this.int_26 = destinationIndex;
        A_0 = this.method_5(A_0);
        destinationIndex = this.int_26;
        num7 = (destinationIndex < this.int_23) ? ((this.int_23 - destinationIndex) - 1) : (this.int_17 - destinationIndex);
        if (this.int_23 != this.int_26)
        {
            this.int_14 = num4;
            this.int_15 = num5;
            this.class1068_0.int_1 = num3;
            this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
            this.class1068_0.int_0 = sourceIndex;
            this.int_26 = destinationIndex;
            return this.method_5(A_0);
        }
        this.int_22 = 8;
    Label_0F56:
        A_0 = 1;
        this.int_14 = num4;
        this.int_15 = num5;
        this.class1068_0.int_1 = num3;
        this.class1068_0.long_0 += sourceIndex - this.class1068_0.int_0;
        this.class1068_0.int_0 = sourceIndex;
        this.int_26 = destinationIndex;
        return this.method_5(1);
    }

    internal void method_2()
    {
        this.method_0(null);
        this.byte_0 = null;
        this.int_18 = null;
    }

    internal void method_3(byte[] A_0, int A_1, int A_2)
    {
        Array.Copy(A_0, A_1, this.byte_0, 0, A_2);
        this.int_23 = this.int_26 = A_2;
    }

    internal int method_4()
    {
        if (this.int_22 != 1)
        {
            return 0;
        }
        return 1;
    }

    internal int method_5(int A_0)
    {
        int destinationIndex = this.class1068_0.int_2;
        int num2 = this.int_23;
        int num3 = ((num2 <= this.int_26) ? this.int_26 : this.int_17) - num2;
        if (num3 > this.class1068_0.int_3)
        {
            num3 = this.class1068_0.int_3;
        }
        if (A_0 == -5)
        {
            A_0 = 0;
        }
        this.class1068_0.int_3 -= num3;
        this.class1068_0.long_1 += num3;
        if (this.object_0 != null)
        {
            this.class1068_0.long_2 = this.long_0 = Class603.smethod_0(this.long_0, this.byte_0, num2, num3);
        }
        Array.Copy(this.byte_0, num2, this.class1068_0.byte_1, destinationIndex, num3);
        destinationIndex += num3;
        num2 += num3;
        if (num2 == this.int_17)
        {
            num2 = 0;
            if (this.int_26 == this.int_17)
            {
                this.int_26 = 0;
            }
            num3 = this.int_26 - num2;
            if (num3 > this.class1068_0.int_3)
            {
                num3 = this.class1068_0.int_3;
            }
            if ((num3 != 0) && (A_0 == -5))
            {
                A_0 = 0;
            }
            this.class1068_0.int_3 -= num3;
            this.class1068_0.long_1 += num3;
            if (this.object_0 != null)
            {
                this.class1068_0.long_2 = this.long_0 = Class603.smethod_0(this.long_0, this.byte_0, num2, num3);
            }
            Array.Copy(this.byte_0, num2, this.class1068_0.byte_1, destinationIndex, num3);
            destinationIndex += num3;
            num2 += num3;
        }
        this.class1068_0.int_2 = destinationIndex;
        this.int_23 = num2;
        return A_0;
    }
}

