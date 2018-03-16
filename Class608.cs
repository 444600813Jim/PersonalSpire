using Spire.Doc;
using System;

internal sealed class Class608
{
    internal byte byte_0;
    internal byte byte_1;
    private const int int_0 = 0;
    private const int int_1 = 1;
    private static readonly int[] int_10 = new int[] { 
        0, 1, 3, 7, 15, 0x1f, 0x3f, 0x7f, 0xff, 0x1ff, 0x3ff, 0x7ff, 0xfff, 0x1fff, 0x3fff, 0x7fff, 
        0xffff
     };
    internal int int_11;
    internal int[] int_12;
    internal int int_13;
    internal int int_14;
    internal int int_15;
    internal int int_16;
    internal int[] int_17;
    internal int int_18;
    internal int int_19;
    private const int int_2 = 2;
    internal int int_20;
    internal int[] int_21;
    internal int int_22;
    private const int int_3 = 3;
    private const int int_4 = 4;
    private const int int_5 = 5;
    private const int int_6 = 6;
    private const int int_7 = 7;
    private const int int_8 = 8;
    private const int int_9 = 9;

    internal void method_0(int A_0, int A_1, int[] A_2, int A_3, int[] A_4, int A_5)
    {
        this.int_19 = 0;
        this.byte_1 = (byte) A_0;
        this.byte_0 = (byte) A_1;
        this.int_17 = A_2;
        this.int_18 = A_3;
        this.int_12 = A_4;
        this.int_13 = A_5;
        this.int_21 = null;
    }

    internal int method_1(Class607 A_0, int A_1)
    {
        int num9;
        int num12;
        int num = 7;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        Class1068 class2 = A_0.class1068_0;
        num4 = class2.int_0;
        int num5 = class2.int_1;
        num2 = A_0.int_14;
        num3 = A_0.int_15;
        int num6 = A_0.int_26;
        int num7 = (num6 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
        goto Label_066B;
    Label_0145:
        num12 = num6 - this.int_11;
        while (num12 < 0)
        {
            num12 += A_0.int_17;
        }
        while (this.int_15 != 0)
        {
            if (num7 == 0)
            {
                if ((num6 == A_0.int_17) && (A_0.int_23 != 0))
                {
                    num6 = 0;
                    num7 = (0 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                }
                if (num7 == 0)
                {
                    A_0.int_26 = num6;
                    A_1 = A_0.method_5(A_1);
                    num6 = A_0.int_26;
                    num7 = (num6 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                    if ((num6 == A_0.int_17) && (A_0.int_23 != 0))
                    {
                        num6 = 0;
                        num7 = (0 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                    }
                    if (num7 == 0)
                    {
                        A_0.int_14 = num2;
                        A_0.int_15 = num3;
                        class2.int_1 = num5;
                        class2.long_0 += num4 - class2.int_0;
                        class2.int_0 = num4;
                        A_0.int_26 = num6;
                        return A_0.method_5(A_1);
                    }
                }
            }
            A_0.byte_0[num6++] = A_0.byte_0[num12++];
            num7--;
            if (num12 == A_0.int_17)
            {
                num12 = 0;
            }
            this.int_15--;
        }
        this.int_19 = 0;
        goto Label_066B;
    Label_02E2:
        num9 = this.int_20;
        while (num3 < num9)
        {
            if (num5 == 0)
            {
                A_0.int_14 = num2;
                A_0.int_15 = num3;
                class2.int_1 = num5;
                class2.long_0 += num4 - class2.int_0;
                class2.int_0 = num4;
                A_0.int_26 = num6;
                return A_0.method_5(A_1);
            }
            A_1 = 0;
            num5--;
            num2 |= (class2.byte_0[num4++] & 0xff) << num3;
            num3 += 8;
        }
        int index = (this.int_22 + (num2 & int_10[num9])) * 3;
        num2 = num2 >> this.int_21[index + 1];
        num3 -= this.int_21[index + 1];
        int num11 = this.int_21[index];
        if ((num11 & 0x10) != 0)
        {
            this.int_14 = num11 & 15;
            this.int_11 = this.int_21[index + 2];
            this.int_19 = 4;
        }
        else
        {
            if ((num11 & 0x40) != 0)
            {
                this.int_19 = 9;
                class2.string_0 = BookmarkStart.b("䐬䄮䜰刲头帶崸ᬺ夼嘾㉀㝂⑄⥆⩈⹊浌ⱎ㹐㝒ご", num);
                A_1 = -3;
                A_0.int_14 = num2;
                A_0.int_15 = num3;
                class2.int_1 = num5;
                class2.long_0 += num4 - class2.int_0;
                class2.int_0 = num4;
                A_0.int_26 = num6;
                return A_0.method_5(-3);
            }
            this.int_20 = num11;
            this.int_22 = (index / 3) + this.int_21[index + 2];
        }
        goto Label_066B;
    Label_044D:
        num9 = this.int_20;
        while (num3 < num9)
        {
            if (num5 == 0)
            {
                A_0.int_14 = num2;
                A_0.int_15 = num3;
                class2.int_1 = num5;
                class2.long_0 += num4 - class2.int_0;
                class2.int_0 = num4;
                A_0.int_26 = num6;
                return A_0.method_5(A_1);
            }
            A_1 = 0;
            num5--;
            num2 |= (class2.byte_0[num4++] & 0xff) << num3;
            num3 += 8;
        }
        index = (this.int_22 + (num2 & int_10[num9])) * 3;
        num2 = Class604.smethod_0(num2, this.int_21[index + 1]);
        num3 -= this.int_21[index + 1];
        num11 = this.int_21[index];
        if (num11 == 0)
        {
            this.int_16 = this.int_21[index + 2];
            this.int_19 = 6;
        }
        else if ((num11 & 0x10) != 0)
        {
            this.int_14 = num11 & 15;
            this.int_15 = this.int_21[index + 2];
            this.int_19 = 2;
        }
        else if ((num11 & 0x40) == 0)
        {
            this.int_20 = num11;
            this.int_22 = (index / 3) + this.int_21[index + 2];
        }
        else
        {
            if ((num11 & 0x20) == 0)
            {
                this.int_19 = 9;
                class2.string_0 = BookmarkStart.b("䐬䄮䜰刲头帶崸ᬺ儼嘾㕀♂㝄♆╈摊⅌⩎㽐㑒⅔㽖祘㡚㉜㭞Ѡ", num);
                A_1 = -3;
                A_0.int_14 = num2;
                A_0.int_15 = num3;
                class2.int_1 = num5;
                class2.long_0 += num4 - class2.int_0;
                class2.int_0 = num4;
                A_0.int_26 = num6;
                return A_0.method_5(-3);
            }
            this.int_19 = 7;
        }
    Label_066B:
        switch (this.int_19)
        {
            case 0:
                if ((num7 >= 0x102) && (num5 >= 10))
                {
                    A_0.int_14 = num2;
                    A_0.int_15 = num3;
                    class2.int_1 = num5;
                    class2.long_0 += num4 - class2.int_0;
                    class2.int_0 = num4;
                    A_0.int_26 = num6;
                    A_1 = this.method_2(this.byte_1, this.byte_0, this.int_17, this.int_18, this.int_12, this.int_13, A_0, class2);
                    num4 = class2.int_0;
                    num5 = class2.int_1;
                    num2 = A_0.int_14;
                    num3 = A_0.int_15;
                    num6 = A_0.int_26;
                    num7 = (num6 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                    if (A_1 != 0)
                    {
                        this.int_19 = (A_1 == 1) ? 7 : 9;
                        goto Label_066B;
                    }
                }
                this.int_20 = this.byte_1;
                this.int_21 = this.int_17;
                this.int_22 = this.int_18;
                this.int_19 = 1;
                goto Label_044D;

            case 1:
                goto Label_044D;

            case 2:
                num9 = this.int_14;
                while (num3 < num9)
                {
                    if (num5 == 0)
                    {
                        A_0.int_14 = num2;
                        A_0.int_15 = num3;
                        class2.int_1 = num5;
                        class2.long_0 += num4 - class2.int_0;
                        class2.int_0 = num4;
                        A_0.int_26 = num6;
                        return A_0.method_5(A_1);
                    }
                    A_1 = 0;
                    num5--;
                    num2 |= (class2.byte_0[num4++] & 0xff) << num3;
                    num3 += 8;
                }
                this.int_15 += num2 & int_10[num9];
                num2 = num2 >> num9;
                num3 -= num9;
                this.int_20 = this.byte_0;
                this.int_21 = this.int_12;
                this.int_22 = this.int_13;
                this.int_19 = 3;
                goto Label_02E2;

            case 3:
                goto Label_02E2;

            case 4:
                num9 = this.int_14;
                while (num3 < num9)
                {
                    if (num5 == 0)
                    {
                        A_0.int_14 = num2;
                        A_0.int_15 = num3;
                        class2.int_1 = num5;
                        class2.long_0 += num4 - class2.int_0;
                        class2.int_0 = num4;
                        A_0.int_26 = num6;
                        return A_0.method_5(A_1);
                    }
                    A_1 = 0;
                    num5--;
                    num2 |= (class2.byte_0[num4++] & 0xff) << num3;
                    num3 += 8;
                }
                this.int_11 += num2 & int_10[num9];
                num2 = num2 >> num9;
                num3 -= num9;
                this.int_19 = 5;
                goto Label_0145;

            case 5:
                goto Label_0145;

            case 6:
                if (num7 == 0)
                {
                    if ((num6 == A_0.int_17) && (A_0.int_23 != 0))
                    {
                        num6 = 0;
                        num7 = (0 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                    }
                    if (num7 == 0)
                    {
                        A_0.int_26 = num6;
                        A_1 = A_0.method_5(A_1);
                        num6 = A_0.int_26;
                        num7 = (num6 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                        if ((num6 == A_0.int_17) && (A_0.int_23 != 0))
                        {
                            num6 = 0;
                            num7 = (0 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                        }
                        if (num7 == 0)
                        {
                            A_0.int_14 = num2;
                            A_0.int_15 = num3;
                            class2.int_1 = num5;
                            class2.long_0 += num4 - class2.int_0;
                            class2.int_0 = num4;
                            A_0.int_26 = num6;
                            return A_0.method_5(A_1);
                        }
                    }
                }
                A_1 = 0;
                A_0.byte_0[num6++] = (byte) this.int_16;
                num7--;
                this.int_19 = 0;
                goto Label_066B;

            case 7:
                if (num3 > 7)
                {
                    num3 -= 8;
                    num5++;
                    num4--;
                }
                A_0.int_26 = num6;
                A_1 = A_0.method_5(A_1);
                num6 = A_0.int_26;
                num7 = (num6 < A_0.int_23) ? ((A_0.int_23 - num6) - 1) : (A_0.int_17 - num6);
                if (A_0.int_23 != A_0.int_26)
                {
                    A_0.int_14 = num2;
                    A_0.int_15 = num3;
                    class2.int_1 = num5;
                    class2.long_0 += num4 - class2.int_0;
                    class2.int_0 = num4;
                    A_0.int_26 = num6;
                    return A_0.method_5(A_1);
                }
                this.int_19 = 8;
                break;

            case 8:
                break;

            case 9:
                A_1 = -3;
                A_0.int_14 = num2;
                A_0.int_15 = num3;
                class2.int_1 = num5;
                class2.long_0 += num4 - class2.int_0;
                class2.int_0 = num4;
                A_0.int_26 = num6;
                return A_0.method_5(-3);

            default:
                A_1 = -2;
                A_0.int_14 = num2;
                A_0.int_15 = num3;
                class2.int_1 = num5;
                class2.long_0 += num4 - class2.int_0;
                class2.int_0 = num4;
                A_0.int_26 = num6;
                return A_0.method_5(-2);
        }
        A_1 = 1;
        A_0.int_14 = num2;
        A_0.int_15 = num3;
        class2.int_1 = num5;
        class2.long_0 += num4 - class2.int_0;
        class2.int_0 = num4;
        A_0.int_26 = num6;
        return A_0.method_5(1);
    }

    internal int method_2(int A_0, int A_1, int[] A_2, int A_3, int[] A_4, int A_5, Class607 A_6, Class1068 A_7)
    {
        int num = 0x13;
        int num2 = A_7.int_0;
        int num3 = A_7.int_1;
        int num4 = A_6.int_14;
        int num5 = A_6.int_15;
        int destinationIndex = A_6.int_26;
        int num15 = (destinationIndex < A_6.int_23) ? ((A_6.int_23 - destinationIndex) - 1) : (A_6.int_17 - destinationIndex);
        int num7 = int_10[A_0];
        int num16 = int_10[A_1];
        while (num5 < 20)
        {
            int num8;
            int num12;
            int num13;
            num3--;
            num4 |= (A_7.byte_0[num2++] & 0xff) << num5;
            num5 += 8;
            continue;
        Label_0097:
            num8 = num4 & num7;
            int[] numArray = A_2;
            int num9 = A_3;
            int index = (num9 + num8) * 3;
            int num11 = numArray[index];
            if (num11 != 0)
            {
                goto Label_012D;
            }
            num4 = num4 >> numArray[index + 1];
            num5 -= numArray[index + 1];
            A_6.byte_0[destinationIndex++] = (byte) numArray[index + 2];
            num15--;
            goto Label_0443;
        Label_00F2:
            if ((num11 & 0x40) != 0)
            {
                if ((num11 & 0x20) != 0)
                {
                    num12 = A_7.int_1 - num3;
                    num12 = ((num5 >> 3) < num12) ? (num5 >> 3) : num12;
                    num3 += num12;
                    num2 -= num12;
                    num5 -= num12 << 3;
                    A_6.int_14 = num4;
                    A_6.int_15 = num5;
                    A_7.int_1 = num3;
                    A_7.long_0 += num2 - A_7.int_0;
                    A_7.int_0 = num2;
                    A_6.int_26 = destinationIndex;
                    return 1;
                }
                A_7.string_0 = BookmarkStart.b("倸唺䬼帾ⵀ⩂⅄杆╈≊㥌⩎⍐㉒㥔硖㕘㹚㍜㡞ᕠୢ䕤Ѧ٨ཪ࡬", num);
                num12 = A_7.int_1 - num3;
                num12 = ((num5 >> 3) < num12) ? (num5 >> 3) : num12;
                num3 += num12;
                num2 -= num12;
                num5 -= num12 << 3;
                A_6.int_14 = num4;
                A_6.int_15 = num5;
                A_7.int_1 = num3;
                A_7.long_0 += num2 - A_7.int_0;
                A_7.int_0 = num2;
                A_6.int_26 = destinationIndex;
                return -3;
            }
            num8 += numArray[index + 2];
            num8 += num4 & int_10[num11];
            index = (num9 + num8) * 3;
            num11 = numArray[index];
            if (num11 == 0)
            {
                goto Label_040D;
            }
        Label_012D:
            num4 = num4 >> numArray[index + 1];
            num5 -= numArray[index + 1];
            if ((num11 & 0x10) == 0)
            {
                goto Label_00F2;
            }
            num11 &= 15;
            num12 = numArray[index + 2] + (num4 & int_10[num11]);
            num4 = num4 >> num11;
            num5 -= num11;
            while (num5 < 15)
            {
                num3--;
                num4 |= (A_7.byte_0[num2++] & 0xff) << num5;
                num5 += 8;
            }
            num8 = num4 & num16;
            numArray = A_4;
            num9 = A_5;
            index = (num9 + num8) * 3;
            num11 = numArray[index];
            goto Label_01FA;
        Label_01C5:
            if ((num11 & 0x40) != 0)
            {
                A_7.string_0 = BookmarkStart.b("倸唺䬼帾ⵀ⩂⅄杆ⵈ≊㹌㭎ぐ㵒㙔㉖祘㡚㉜㭞Ѡ", num);
                num12 = A_7.int_1 - num3;
                num12 = ((num5 >> 3) < num12) ? (num5 >> 3) : num12;
                num3 += num12;
                num2 -= num12;
                num5 -= num12 << 3;
                A_6.int_14 = num4;
                A_6.int_15 = num5;
                A_7.int_1 = num3;
                A_7.long_0 += num2 - A_7.int_0;
                A_7.int_0 = num2;
                A_6.int_26 = destinationIndex;
                return -3;
            }
            num8 += numArray[index + 2];
            num8 += num4 & int_10[num11];
            index = (num9 + num8) * 3;
            num11 = numArray[index];
        Label_01FA:
            num4 = num4 >> numArray[index + 1];
            num5 -= numArray[index + 1];
            if ((num11 & 0x10) == 0)
            {
                goto Label_01C5;
            }
            num11 &= 15;
            while (num5 < num11)
            {
                num3--;
                num4 |= (A_7.byte_0[num2++] & 0xff) << num5;
                num5 += 8;
            }
            int num14 = numArray[index + 2] + (num4 & int_10[num11]);
            num4 = num4 >> num11;
            num5 -= num11;
            num15 -= num12;
            if (destinationIndex >= num14)
            {
                num13 = destinationIndex - num14;
                if (((destinationIndex - num13) > 0) && (2 > (destinationIndex - num13)))
                {
                    A_6.byte_0[destinationIndex++] = A_6.byte_0[num13++];
                    A_6.byte_0[destinationIndex++] = A_6.byte_0[num13++];
                    num12 -= 2;
                }
                else
                {
                    Array.Copy(A_6.byte_0, num13, A_6.byte_0, destinationIndex, 2);
                    destinationIndex += 2;
                    num13 += 2;
                    num12 -= 2;
                }
            }
            else
            {
                num13 = destinationIndex - num14;
                do
                {
                    num13 += A_6.int_17;
                }
                while (num13 < 0);
                num11 = A_6.int_17 - num13;
                if (num12 > num11)
                {
                    num12 -= num11;
                    if (((destinationIndex - num13) > 0) && (num11 > (destinationIndex - num13)))
                    {
                        do
                        {
                            A_6.byte_0[destinationIndex++] = A_6.byte_0[num13++];
                        }
                        while (--num11 != 0);
                    }
                    else
                    {
                        Array.Copy(A_6.byte_0, num13, A_6.byte_0, destinationIndex, num11);
                        destinationIndex += num11;
                        num13 += num11;
                        num11 = 0;
                    }
                    num13 = 0;
                }
            }
            if (((destinationIndex - num13) > 0) && (num12 > (destinationIndex - num13)))
            {
                do
                {
                    A_6.byte_0[destinationIndex++] = A_6.byte_0[num13++];
                }
                while (--num12 != 0);
            }
            else
            {
                Array.Copy(A_6.byte_0, num13, A_6.byte_0, destinationIndex, num12);
                destinationIndex += num12;
                num13 += num12;
                num12 = 0;
            }
            goto Label_0443;
        Label_040D:
            num4 = num4 >> numArray[index + 1];
            num5 -= numArray[index + 1];
            A_6.byte_0[destinationIndex++] = (byte) numArray[index + 2];
            num15--;
        Label_0443:
            if ((num15 < 0x102) || (num3 < 10))
            {
                num12 = A_7.int_1 - num3;
                num12 = ((num5 >> 3) < num12) ? (num5 >> 3) : num12;
                num3 += num12;
                num2 -= num12;
                num5 -= num12 << 3;
                A_6.int_14 = num4;
                A_6.int_15 = num5;
                A_7.int_1 = num3;
                A_7.long_0 += num2 - A_7.int_0;
                A_7.int_0 = num2;
                A_6.int_26 = destinationIndex;
                return 0;
            }
        }
        goto Label_0097;
    }
}

