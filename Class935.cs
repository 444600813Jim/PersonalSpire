using Spire.Compression;
using Spire.Compression.Zip;
using Spire.Doc;
using System;
using System.Runtime.CompilerServices;

internal sealed class Class935
{
    private bool bool_0;
    private bool bool_1 = true;
    internal byte[] byte_0;
    internal byte[] byte_1;
    internal Class1068 class1068_0;
    internal Class606 class606_0 = new Class606();
    internal Class606 class606_1 = new Class606();
    internal Class606 class606_2 = new Class606();
    private Class936 class936_0;
    internal CompressionLevel compressionLevel_0;
    internal CompressionStrategy compressionStrategy_0;
    private DeflateFlavor deflateFlavor_0;
    private const int int_0 = 9;
    private const int int_1 = 8;
    private const int int_10 = 0;
    private const int int_11 = 1;
    private const int int_12 = 2;
    private const int int_13 = 0x10;
    private const int int_14 = 0x10;
    private const int int_15 = 0x11;
    private const int int_16 = 0x12;
    private const int int_17 = 3;
    private const int int_18 = 0x102;
    private const int int_19 = 15;
    private const int int_2 = 0x20;
    private const int int_20 = 30;
    private const int int_21 = 0x13;
    private const int int_22 = 0x1d;
    private const int int_23 = 0x100;
    private const int int_24 = 0x100;
    private static readonly int int_25 = 0x106;
    private static readonly int int_26 = 0x11e;
    private static readonly int int_27 = ((2 * int_26) + 1);
    internal int int_28;
    internal int int_29;
    private const int int_3 = 0x2a;
    internal int int_30;
    internal int int_31;
    internal int int_32;
    internal int int_33;
    internal int int_34;
    internal int int_35;
    internal int[] int_36 = new int[(2 * int_26) + 1];
    internal int int_37;
    internal int int_38;
    internal int int_39;
    private const int int_4 = 0x71;
    internal int int_40;
    internal int int_41;
    internal int int_42;
    internal int int_43;
    internal int int_44;
    internal int int_45;
    internal int int_46;
    internal int int_47;
    internal int int_48;
    internal int int_49;
    private const int int_5 = 0x29a;
    internal int int_50;
    internal int int_51;
    internal int int_52;
    internal int int_53;
    internal int int_54;
    internal int int_55;
    internal int int_56;
    internal int int_57;
    internal int int_58;
    internal int int_59;
    private const int int_6 = 8;
    internal int int_60;
    private const int int_7 = 0;
    private const int int_8 = 1;
    private const int int_9 = 2;
    internal sbyte sbyte_0;
    internal sbyte[] sbyte_1 = new sbyte[(2 * int_26) + 1];
    internal short short_0;
    internal short[] short_1 = new short[0x10];
    internal short[] short_2 = new short[0x4e];
    internal short[] short_3 = new short[0x7a];
    internal short[] short_4 = new short[int_27 * 2];
    internal short[] short_5;
    internal short[] short_6;
    private static readonly string[] string_0 = new string[] { BookmarkStart.b("嬴制尸强ᴼ嬾⡀⁂ㅄ⹆♈╊ⱌ㵎⡐", 15), BookmarkStart.b("䘴䌶䬸帺尼刾慀♂⭄⍆", 15), "", BookmarkStart.b("匴帶唸帺ᴼ娾㍀ㅂ⩄㕆", 15), BookmarkStart.b("䘴䌶䬸帺尼刾慀♂㝄㕆♈㥊", 15), BookmarkStart.b("儴嘶䴸娺ᴼ娾㍀ㅂ⩄㕆", 15), BookmarkStart.b("尴夶䨸为嬼夾⡀⁂ⱄ≆❈㽊浌≎㑐㹒㩔╖⁘", 15), BookmarkStart.b("圴䈶弸崺堼䴾慀♂㝄㕆♈㥊", 15), BookmarkStart.b("尴夶娸吺值伾⁀㝂ⱄ╆╈⹊浌㥎㑐⅒♔㹖㙘㕚", 15), "" };

    internal Class935()
    {
    }

    internal bool method_0()
    {
        return this.bool_1;
    }

    internal void method_1(bool A_0)
    {
        this.bool_1 = A_0;
    }

    private void method_10(byte[] A_0, int A_1, int A_2)
    {
        Array.Copy(A_0, A_1, this.byte_0, this.int_51, A_2);
        this.int_51 += A_2;
    }

    private void method_11(byte A_0)
    {
        this.byte_0[this.int_51++] = A_0;
    }

    internal void method_12(int A_0)
    {
        this.method_11((byte) A_0);
        this.method_11((byte) Class604.smethod_0(A_0, 8));
    }

    internal void method_13(int A_0)
    {
        this.method_11((byte) (A_0 >> 8));
        this.method_11((byte) A_0);
    }

    internal void method_14(int A_0, short[] A_1)
    {
        int index = A_0 * 2;
        this.method_15(A_1[index] & 0xffff, A_1[index + 1] & 0xffff);
    }

    internal void method_15(int A_0, int A_1)
    {
        int num = A_1;
        if (this.int_30 > (0x10 - num))
        {
            this.short_0 = (short) ((this.short_0 & 0xffff) | ((A_0 << this.int_30) & 0xffff));
            this.method_12(this.short_0);
            this.short_0 = (short) Class604.smethod_0(A_0, 0x10 - this.int_30);
            this.int_30 += num - 0x10;
        }
        else
        {
            this.short_0 = (short) ((this.short_0 & 0xffff) | ((A_0 << this.int_30) & 0xffff));
            this.int_30 += num;
        }
    }

    internal void method_16()
    {
        this.method_15(2, 3);
        this.method_14(0x100, Class605.short_0);
        this.method_20();
        if ((((1 + this.int_40) + 10) - this.int_30) < 9)
        {
            this.method_15(2, 3);
            this.method_14(0x100, Class605.short_0);
            this.method_20();
        }
        this.int_40 = 7;
    }

    internal bool method_17(int A_0, int A_1)
    {
        this.byte_0[this.int_28 + (this.int_42 * 2)] = (byte) Class604.smethod_0(A_0, 8);
        this.byte_0[(this.int_28 + (this.int_42 * 2)) + 1] = (byte) A_0;
        this.byte_0[this.int_29 + this.int_42] = (byte) A_1;
        this.int_42++;
        if (A_0 == 0)
        {
            this.short_4[A_1 * 2] = (short) (this.short_4[A_1 * 2] + 1);
        }
        else
        {
            this.int_48++;
            A_0--;
            this.short_4[((Class606.sbyte_2[A_1] + 0x100) + 1) * 2] = (short) (this.short_4[((Class606.sbyte_2[A_1] + 0x100) + 1) * 2] + 1);
            this.short_3[Class606.smethod_0(A_0) * 2] = (short) (this.short_3[Class606.smethod_0(A_0) * 2] + 1);
        }
        if (((this.int_42 & 0x1fff) == 0) && (this.compressionLevel_0 > ((CompressionLevel) 2)))
        {
            int num2 = this.int_42 * 8;
            int num3 = this.int_56 - this.int_31;
            for (int i = 0; i < 30; i++)
            {
                num2 += (int) (this.short_3[i * 2] * (5L + Class606.int_14[i]));
            }
            num2 = Class604.smethod_0(num2, 3);
            if ((this.int_48 < (this.int_42 / 2)) && (num2 < (num3 / 2)))
            {
                return true;
            }
        }
        if (this.int_42 != (this.int_43 - 1))
        {
            return (this.int_42 == this.int_43);
        }
        return true;
    }

    internal void method_18(short[] A_0, short[] A_1)
    {
        int num = 0;
        if (this.int_42 != 0)
        {
            do
            {
                int index = this.int_28 + (num * 2);
                int num2 = ((this.byte_0[index] << 8) & 0xff00) | (this.byte_0[index + 1] & 0xff);
                int num6 = this.byte_0[this.int_29 + num] & 0xff;
                num++;
                if (num2 != 0)
                {
                    int num3 = Class606.sbyte_2[num6];
                    this.method_14((num3 + 0x100) + 1, A_0);
                    int num4 = Class606.int_13[num3];
                    if (num4 != 0)
                    {
                        num6 -= Class606.int_16[num3];
                        this.method_15(num6, num4);
                    }
                    num2--;
                    num3 = Class606.smethod_0(num2);
                    this.method_14(num3, A_1);
                    num4 = Class606.int_14[num3];
                    if (num4 != 0)
                    {
                        num2 -= Class606.int_17[num3];
                        this.method_15(num2, num4);
                    }
                }
                else
                {
                    this.method_14(num6, A_0);
                }
            }
            while (num < this.int_42);
        }
        this.method_14(0x100, A_0);
        this.int_40 = A_0[0x201];
    }

    internal void method_19()
    {
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        while (num < 7)
        {
            num3 += this.short_4[num * 2];
            num++;
        }
        while (num < 0x80)
        {
            num2 += this.short_4[num * 2];
            num++;
        }
        while (num < 0x100)
        {
            num3 += this.short_4[num * 2];
            num++;
        }
        this.sbyte_0 = (num3 > Class604.smethod_0(num2, 2)) ? ((sbyte) 0) : ((sbyte) 1);
    }

    private void method_2()
    {
        this.int_60 = 2 * this.int_59;
        for (int i = 0; i < this.int_35; i++)
        {
            this.short_5[i] = 0;
        }
        this.class936_0 = Class936.smethod_0(this.compressionLevel_0);
        this.deflateFlavor_0 = this.class936_0.deflateFlavor_0;
        this.int_56 = 0;
        this.int_31 = 0;
        this.int_44 = 0;
        this.int_52 = 2;
        this.int_46 = 2;
        this.int_45 = 0;
        this.int_39 = 0;
    }

    internal void method_20()
    {
        if (this.int_30 == 0x10)
        {
            this.method_12(this.short_0);
            this.short_0 = 0;
            this.int_30 = 0;
        }
        else if (this.int_30 >= 8)
        {
            this.method_11((byte) this.short_0);
            this.short_0 = (short) Class604.smethod_0(this.short_0, 8);
            this.int_30 -= 8;
        }
    }

    internal void method_21()
    {
        if (this.int_30 > 8)
        {
            this.method_12(this.short_0);
        }
        else if (this.int_30 > 0)
        {
            this.method_11((byte) this.short_0);
        }
        this.short_0 = 0;
        this.int_30 = 0;
    }

    internal void method_22(int A_0, int A_1, bool A_2)
    {
        this.method_21();
        this.int_40 = 8;
        if (A_2)
        {
            this.method_12((short) A_1);
            this.method_12((short) ~A_1);
        }
        this.method_10(this.byte_1, A_0, A_1);
    }

    internal void method_23(bool A_0)
    {
        this.method_26((this.int_31 >= 0) ? this.int_31 : -1, this.int_56 - this.int_31, A_0);
        this.int_31 = this.int_56;
        this.class1068_0.method_19();
    }

    internal BlockState method_24(FlushType A_0)
    {
        int num = 0xffff;
        if (0xffff > (this.byte_0.Length - 5))
        {
            num = this.byte_0.Length - 5;
        }
        while (true)
        {
            if (this.int_44 <= 1)
            {
                this.method_27();
                if ((this.int_44 == 0) && (A_0 == FlushType.None))
                {
                    return BlockState.NeedMore;
                }
                if (this.int_44 == 0)
                {
                    this.method_23(A_0 == FlushType.Finish);
                    if (this.class1068_0.int_3 == 0)
                    {
                        if (A_0 != FlushType.Finish)
                        {
                            return BlockState.NeedMore;
                        }
                        return BlockState.FinishStarted;
                    }
                    if (A_0 != FlushType.Finish)
                    {
                        return BlockState.BlockDone;
                    }
                    return BlockState.FinishDone;
                }
            }
            this.int_56 += this.int_44;
            this.int_44 = 0;
            int num2 = this.int_31 + num;
            if ((this.int_56 == 0) || (this.int_56 >= num2))
            {
                this.int_44 = this.int_56 - num2;
                this.int_56 = num2;
                this.method_23(false);
                if (this.class1068_0.int_3 == 0)
                {
                    return BlockState.NeedMore;
                }
            }
            if ((this.int_56 - this.int_31) >= (this.int_59 - int_25))
            {
                this.method_23(false);
                if (this.class1068_0.int_3 == 0)
                {
                    return BlockState.NeedMore;
                }
            }
        }
    }

    internal void method_25(int A_0, int A_1, bool A_2)
    {
        this.method_15(A_2 ? 1 : 0, 3);
        this.method_22(A_0, A_1, true);
    }

    internal void method_26(int A_0, int A_1, bool A_2)
    {
        int num2;
        int num3;
        int num = 0;
        if (this.compressionLevel_0 > CompressionLevel.NoCompression)
        {
            if (this.sbyte_0 == 2)
            {
                this.method_19();
            }
            this.class606_2.method_1(this);
            this.class606_1.method_1(this);
            num = this.method_7();
            num2 = Class604.smethod_0((this.int_50 + 3) + 7, 3);
            num3 = Class604.smethod_0((this.int_54 + 3) + 7, 3);
            if (num3 <= num2)
            {
                num2 = num3;
            }
        }
        else
        {
            num2 = num3 = A_1 + 5;
        }
        if (((A_1 + 4) <= num2) && (A_0 != -1))
        {
            this.method_25(A_0, A_1, A_2);
        }
        else if (num3 == num2)
        {
            this.method_15(2 + (A_2 ? 1 : 0), 3);
            this.method_18(Class605.short_0, Class605.short_1);
        }
        else
        {
            this.method_15(4 + (A_2 ? 1 : 0), 3);
            this.method_8(this.class606_2.int_18 + 1, this.class606_1.int_18 + 1, num + 1);
            this.method_18(this.short_4, this.short_3);
        }
        this.method_4();
        if (A_2)
        {
            this.method_21();
        }
    }

    private void method_27()
    {
        // This item is obfuscated and can not be translated.
        int num;
        int num4;
    Label_01E6:
        num = (this.int_60 - this.int_44) - this.int_56;
        if ((num != 0) || ((this.int_56 != 0) || (this.int_44 != 0)))
        {
            if (num == -1)
            {
                num--;
            }
            else if (this.int_56 >= ((this.int_59 + this.int_59) - int_25))
            {
                int num3;
                Array.Copy(this.byte_1, this.int_59, this.byte_1, 0, this.int_59);
                this.int_47 -= this.int_59;
                this.int_56 -= this.int_59;
                this.int_31 -= this.int_59;
                num4 = this.int_35;
                int index = num4;
                do
                {
                    num3 = this.short_5[--index] & 0xffff;
                    if (num3 >= this.int_59)
                    {
                    }
                    this.short_5[index] = (short) (num3 - this.int_59);
                }
                while (--num4 != 0);
                num4 = this.int_59;
                index = num4;
                num3 = this.short_6[--index] & 0xffff;
                if (num3 >= this.int_59)
                {
                }
                while (true)
                {
                    this.short_6[index] = (short) (num3 - this.int_59);
                }
                num += this.int_59;
            }
        }
        else
        {
            num = this.int_59;
        }
        if (this.class1068_0.int_1 != 0)
        {
            num4 = this.class1068_0.method_20(this.byte_1, this.int_56 + this.int_44, num);
            this.int_44 += num4;
            if (this.int_44 >= 3)
            {
                this.int_39 = this.byte_1[this.int_56] & 0xff;
                this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[this.int_56 + 1] & 0xff)) & this.int_33;
            }
            if ((this.int_44 < int_25) && (this.class1068_0.int_1 != 0))
            {
                goto Label_01E6;
            }
        }
    }

    internal BlockState method_28(FlushType A_0)
    {
        int num = 0;
        while (true)
        {
            bool flag;
            if (this.int_44 < int_25)
            {
                this.method_27();
                if ((this.int_44 < int_25) && (A_0 == FlushType.None))
                {
                    return BlockState.NeedMore;
                }
                if (this.int_44 == 0)
                {
                    this.method_23(A_0 == FlushType.Finish);
                    if (this.class1068_0.int_3 == 0)
                    {
                        if (A_0 == FlushType.Finish)
                        {
                            return BlockState.FinishStarted;
                        }
                        return BlockState.NeedMore;
                    }
                    if (A_0 != FlushType.Finish)
                    {
                        return BlockState.BlockDone;
                    }
                    return BlockState.FinishDone;
                }
            }
            if (this.int_44 >= 3)
            {
                this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[this.int_56 + 2] & 0xff)) & this.int_33;
                num = this.short_5[this.int_39] & 0xffff;
                this.short_6[this.int_56 & this.int_58] = this.short_5[this.int_39];
                this.short_5[this.int_39] = (short) this.int_56;
            }
            if (((num != 0L) && (((this.int_56 - num) & 0xffff) <= (this.int_59 - int_25))) && (this.compressionStrategy_0 != CompressionStrategy.HuffmanOnly))
            {
                this.int_46 = this.method_30(num);
            }
            if (this.int_46 >= 3)
            {
                flag = this.method_17(this.int_56 - this.int_47, this.int_46 - 3);
                this.int_44 -= this.int_46;
                if ((this.int_46 <= this.class936_0.int_2) && (this.int_44 >= 3))
                {
                    this.int_46--;
                    do
                    {
                        this.int_56++;
                        this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[this.int_56 + 2] & 0xff)) & this.int_33;
                        num = this.short_5[this.int_39] & 0xffff;
                        this.short_6[this.int_56 & this.int_58] = this.short_5[this.int_39];
                        this.short_5[this.int_39] = (short) this.int_56;
                    }
                    while (--this.int_46 != 0);
                    this.int_56++;
                }
                else
                {
                    this.int_56 += this.int_46;
                    this.int_46 = 0;
                    this.int_39 = this.byte_1[this.int_56] & 0xff;
                    this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[this.int_56 + 1] & 0xff)) & this.int_33;
                }
            }
            else
            {
                flag = this.method_17(0, this.byte_1[this.int_56] & 0xff);
                this.int_44--;
                this.int_56++;
            }
            if (flag)
            {
                this.method_23(false);
                if (this.class1068_0.int_3 == 0)
                {
                    return BlockState.NeedMore;
                }
            }
        }
    }

    internal BlockState method_29(FlushType A_0)
    {
        bool flag;
        int num = 0;
    Label_0339:
        if (this.int_44 < int_25)
        {
            this.method_27();
            if ((this.int_44 < int_25) && (A_0 == FlushType.None))
            {
                return BlockState.NeedMore;
            }
            if (this.int_44 == 0)
            {
                if (this.int_45 != 0)
                {
                    flag = this.method_17(0, this.byte_1[this.int_56 - 1] & 0xff);
                    this.int_45 = 0;
                }
                this.method_23(A_0 == FlushType.Finish);
                if (this.class1068_0.int_3 == 0)
                {
                    if (A_0 == FlushType.Finish)
                    {
                        return BlockState.FinishStarted;
                    }
                    return BlockState.NeedMore;
                }
                if (A_0 != FlushType.Finish)
                {
                    return BlockState.BlockDone;
                }
                return BlockState.FinishDone;
            }
        }
        if (this.int_44 >= 3)
        {
            this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[this.int_56 + 2] & 0xff)) & this.int_33;
            num = this.short_5[this.int_39] & 0xffff;
            this.short_6[this.int_56 & this.int_58] = this.short_5[this.int_39];
            this.short_5[this.int_39] = (short) this.int_56;
        }
        this.int_52 = this.int_46;
        this.int_53 = this.int_47;
        this.int_46 = 2;
        if (((num != 0) && (this.int_52 < this.class936_0.int_2)) && (((this.int_56 - num) & 0xffff) <= (this.int_59 - int_25)))
        {
            if (this.compressionStrategy_0 != CompressionStrategy.HuffmanOnly)
            {
                this.int_46 = this.method_30(num);
            }
            if ((this.int_46 <= 5) && ((this.compressionStrategy_0 == CompressionStrategy.Filtered) || ((this.int_46 == 3) && ((this.int_56 - this.int_47) > 0x1000))))
            {
                this.int_46 = 2;
            }
        }
        if ((this.int_52 < 3) || (this.int_46 > this.int_52))
        {
            if (this.int_45 != 0)
            {
                if (flag = this.method_17(0, this.byte_1[this.int_56 - 1] & 0xff))
                {
                    this.method_23(false);
                }
                this.int_56++;
                this.int_44--;
                if (this.class1068_0.int_3 == 0)
                {
                    return BlockState.NeedMore;
                }
            }
            else
            {
                this.int_45 = 1;
                this.int_56++;
                this.int_44--;
            }
            goto Label_0339;
        }
        int num3 = (this.int_56 + this.int_44) - 3;
        flag = this.method_17((this.int_56 - 1) - this.int_53, this.int_52 - 3);
        this.int_44 -= this.int_52 - 1;
        this.int_52 -= 2;
    Label_0238:
        if (++this.int_56 <= num3)
        {
            this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[this.int_56 + 2] & 0xff)) & this.int_33;
            num = this.short_5[this.int_39] & 0xffff;
            this.short_6[this.int_56 & this.int_58] = this.short_5[this.int_39];
            this.short_5[this.int_39] = (short) this.int_56;
        }
        if (--this.int_52 == 0)
        {
            this.int_45 = 0;
            this.int_46 = 2;
            this.int_56++;
            if (flag)
            {
                this.method_23(false);
                if (this.class1068_0.int_3 == 0)
                {
                    return BlockState.NeedMore;
                }
            }
        }
        else
        {
            goto Label_0238;
        }
        goto Label_0339;
    }

    private void method_3()
    {
        this.class606_2.short_0 = this.short_4;
        this.class606_2.class605_0 = Class605.class605_0;
        this.class606_1.short_0 = this.short_3;
        this.class606_1.class605_0 = Class605.class605_1;
        this.class606_0.short_0 = this.short_2;
        this.class606_0.class605_0 = Class605.class605_2;
        this.short_0 = 0;
        this.int_30 = 0;
        this.int_40 = 8;
        this.method_4();
    }

    internal int method_30(int A_0)
    {
        int num = this.class936_0.int_1;
        int index = this.int_56;
        int num3 = this.int_52;
        int num9 = (this.int_56 > (this.int_59 - int_25)) ? (this.int_56 - (this.int_59 - int_25)) : 0;
        int num10 = this.class936_0.int_3;
        int num8 = this.int_58;
        int num4 = this.int_56 + 0x102;
        byte num7 = this.byte_1[(index + num3) - 1];
        byte num6 = this.byte_1[index + num3];
        if (this.int_52 >= this.class936_0.int_0)
        {
            num = num >> 2;
        }
        if (num10 > this.int_44)
        {
            num10 = this.int_44;
        }
        do
        {
            int num5 = A_0;
            if ((this.byte_1[num5 + num3] == num6) && (((this.byte_1[(num5 + num3) - 1] == num7) && (this.byte_1[num5] == this.byte_1[index])) && (this.byte_1[++num5] == this.byte_1[index + 1])))
            {
                index += 2;
                num5++;
                while (this.byte_1[++index] == this.byte_1[++num5])
                {
                    if ((((this.byte_1[++index] != this.byte_1[++num5]) || (this.byte_1[++index] != this.byte_1[++num5])) || ((this.byte_1[++index] != this.byte_1[++num5]) || (this.byte_1[++index] != this.byte_1[++num5]))) || (((this.byte_1[++index] != this.byte_1[++num5]) || (this.byte_1[++index] != this.byte_1[++num5])) || ((this.byte_1[++index] != this.byte_1[++num5]) || (index >= num4))))
                    {
                        break;
                    }
                }
                int num11 = 0x102 - (num4 - index);
                index = num4 - 0x102;
                if (num11 > num3)
                {
                    this.int_47 = A_0;
                    num3 = num11;
                    if (num11 >= num10)
                    {
                        break;
                    }
                    num7 = this.byte_1[(index + num3) - 1];
                    num6 = this.byte_1[index + num3];
                }
            }
        }
        while (((A_0 = this.short_6[A_0 & num8] & 0xffff) > num9) && (--num != 0));
        if (num3 <= this.int_44)
        {
            return num3;
        }
        return this.int_44;
    }

    internal int method_31(Class1068 A_0, CompressionLevel A_1)
    {
        return this.method_32(A_0, A_1, 15);
    }

    internal int method_32(Class1068 A_0, CompressionLevel A_1, int A_2)
    {
        return this.method_34(A_0, A_1, A_2, 8, CompressionStrategy.Default);
    }

    internal int method_33(Class1068 A_0, CompressionLevel A_1, int A_2, CompressionStrategy A_3)
    {
        return this.method_34(A_0, A_1, A_2, 8, A_3);
    }

    internal int method_34(Class1068 A_0, CompressionLevel A_1, int A_2, int A_3, CompressionStrategy A_4)
    {
        int num = 6;
        this.class1068_0 = A_0;
        this.class1068_0.string_0 = null;
        if ((A_2 < 9) || (A_2 > 15))
        {
            throw new Exception0(BookmarkStart.b("嬫䜭帯嘱嬳䄵稷匹䠻䴽怿⽁ㅃ㕅㱇橉⹋⭍灏㭑㩓癕ⱗ㉙㥛繝቟͡੣ť൧䩩啫䁭幯䍱䅳塵", num));
        }
        if ((A_3 < 1) || (A_3 > 9))
        {
            throw new Exception0(string.Format(BookmarkStart.b("䄫䬭崯縱儳䀵崷嘹᰻匽㔿ㅁぃ晅⩇⽉汋❍㹏牑⁓㹕㵗穙⹛㽝๟աţ䙥奧䑩䉫乭୯䉱ॳ", num), 9));
        }
        this.class1068_0.class935_0 = this;
        this.int_57 = A_2;
        this.int_59 = ((int) 1) << this.int_57;
        this.int_58 = this.int_59 - 1;
        this.int_32 = A_3 + 7;
        this.int_35 = ((int) 1) << this.int_32;
        this.int_33 = this.int_35 - 1;
        this.int_34 = ((this.int_32 + 3) - 1) / 3;
        this.byte_1 = new byte[this.int_59 * 2];
        this.short_6 = new short[this.int_59];
        this.short_5 = new short[this.int_35];
        this.int_43 = ((int) 1) << (A_3 + 6);
        this.byte_0 = new byte[this.int_43 * 4];
        this.int_28 = this.int_43;
        this.int_29 = 3 * this.int_43;
        this.compressionLevel_0 = A_1;
        this.compressionStrategy_0 = A_4;
        this.method_35();
        return 0;
    }

    internal void method_35()
    {
        this.class1068_0.long_1 = 0L;
        this.class1068_0.long_0 = 0L;
        this.class1068_0.string_0 = null;
        this.int_51 = 0;
        this.int_49 = 0;
        this.bool_0 = false;
        this.int_55 = this.method_0() ? 0x2a : 0x71;
        this.class1068_0.long_2 = Class603.smethod_0(0L, null, 0, 0);
        this.int_41 = 0;
        this.method_3();
        this.method_2();
    }

    internal int method_36()
    {
        if (((this.int_55 != 0x2a) && (this.int_55 != 0x71)) && (this.int_55 != 0x29a))
        {
            return -2;
        }
        this.byte_0 = null;
        this.short_5 = null;
        this.short_6 = null;
        this.byte_1 = null;
        if (this.int_55 != 0x71)
        {
            return 0;
        }
        return -3;
    }

    internal int method_37(CompressionLevel A_0, CompressionStrategy A_1)
    {
        int num = 0;
        if (this.compressionLevel_0 != A_0)
        {
            Class936 class2 = Class936.smethod_0(A_0);
            if ((class2.deflateFlavor_0 != this.class936_0.deflateFlavor_0) && (this.class1068_0.long_0 != 0L))
            {
                num = this.class1068_0.method_14(FlushType.Partial);
            }
            this.compressionLevel_0 = A_0;
            this.class936_0 = class2;
            this.deflateFlavor_0 = this.class936_0.deflateFlavor_0;
        }
        this.compressionStrategy_0 = A_1;
        return num;
    }

    internal int method_38(byte[] A_0)
    {
        int num = 0;
        int length = A_0.Length;
        int sourceIndex = 0;
        if ((A_0 == null) || (this.int_55 != 0x2a))
        {
            throw new Exception0(BookmarkStart.b("甥尧堩䤫伭崯ሱ儳䐵䨷唹主ွ", num));
        }
        this.class1068_0.long_2 = Class603.smethod_0(this.class1068_0.long_2, A_0, 0, A_0.Length);
        if (length >= 3)
        {
            if (length > (this.int_59 - int_25))
            {
                length = this.int_59 - int_25;
                sourceIndex = A_0.Length - length;
            }
            Array.Copy(A_0, sourceIndex, this.byte_1, 0, length);
            this.int_56 = length;
            this.int_31 = length;
            this.int_39 = this.byte_1[0] & 0xff;
            this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[1] & 0xff)) & this.int_33;
            for (int i = 0; i <= (length - 3); i++)
            {
                this.int_39 = ((this.int_39 << this.int_34) ^ (this.byte_1[i + 2] & 0xff)) & this.int_33;
                this.short_6[i & this.int_58] = this.short_5[this.int_39];
                this.short_5[this.int_39] = (short) i;
            }
        }
        return 0;
    }

    internal int method_39(FlushType A_0)
    {
        int num = 11;
        if (((this.class1068_0.byte_1 == null) || ((this.class1068_0.byte_0 == null) && (this.class1068_0.int_1 != 0))) || ((this.int_55 == 0x29a) && (A_0 != FlushType.Finish)))
        {
            this.class1068_0.string_0 = string_0[4];
            throw new Exception0(string.Format(BookmarkStart.b("戰尲場制䴸区吼儾♀捂ⱄ㑆楈ⵊ⑌㱎㥐⩒答睖ɘ⁚浜≞㱠", num), this.class1068_0.string_0));
        }
        if (this.class1068_0.int_3 == 0)
        {
            this.class1068_0.string_0 = string_0[7];
            throw new Exception0(BookmarkStart.b("縰䘲䄴䜶䰸伺缼䨾❀╂⁄㕆楈≊㹌潎㝐♒㥔㭖祘獚ᱜ⥞`੢।٦୨ݪ࡬⵮ࡰݲၴѶ㙸๺ॼ彾벀뺂ꖄ랆ꂈ", num));
        }
        int num4 = this.int_41;
        this.int_41 = (int) A_0;
        if (this.int_55 == 0x2a)
        {
            int num2 = (8 + ((this.int_57 - 8) << 4)) << 8;
            int num5 = ((int) ((this.compressionLevel_0 - 1) & 0xff)) >> 1;
            if (num5 > 3)
            {
                num5 = 3;
            }
            num2 |= num5 << 6;
            if (this.int_56 != 0)
            {
                num2 |= 0x20;
            }
            num2 += 0x1f - (num2 % 0x1f);
            this.int_55 = 0x71;
            this.method_13(num2);
            if (this.int_56 != 0)
            {
                this.method_13((int) Class604.smethod_1(this.class1068_0.long_2, 0x10));
                this.method_13((int) (this.class1068_0.long_2 & 0xffffL));
            }
            this.class1068_0.long_2 = Class603.smethod_0(0L, null, 0, 0);
        }
        if (this.int_51 != 0)
        {
            this.class1068_0.method_19();
            if (this.class1068_0.int_3 == 0)
            {
                this.int_41 = -1;
                return 0;
            }
        }
        else if (((this.class1068_0.int_1 == 0) && (A_0 <= num4)) && (A_0 != FlushType.Finish))
        {
            return 0;
        }
        if ((this.int_55 == 0x29a) && (this.class1068_0.int_1 != 0))
        {
            this.class1068_0.string_0 = string_0[7];
            throw new Exception0(BookmarkStart.b("䈰䜲吴䌶䰸䠺ᴼȾ籀捂̈́ๆ݈ɊṌݎ๐RŔᙖ൘Ṛ絜神䝠䍢㩤Ѧ٨ཪ࡬౮彰㉲ʹᙶၸ᝺ᱼᵾ임ﺆﶈﺌ욎ﾐ뎒뒔ꪖ릘ꮚ", num));
        }
        if (((this.class1068_0.int_1 != 0) || (this.int_44 != 0)) || ((A_0 != FlushType.None) && (this.int_55 != 0x29a)))
        {
            BlockState state;
            switch (this.deflateFlavor_0)
            {
                case DeflateFlavor.Store:
                    state = this.method_24(A_0);
                    break;

                case DeflateFlavor.Fast:
                    state = this.method_28(A_0);
                    break;

                default:
                    state = this.method_29(A_0);
                    break;
            }
            switch (state)
            {
                case BlockState.FinishStarted:
                case BlockState.FinishDone:
                    this.int_55 = 0x29a;
                    break;
            }
            switch (state)
            {
                case BlockState.NeedMore:
                case BlockState.FinishStarted:
                    if (this.class1068_0.int_3 == 0)
                    {
                        this.int_41 = -1;
                    }
                    return 0;

                default:
                    if (state == BlockState.BlockDone)
                    {
                        if (A_0 == FlushType.Partial)
                        {
                            this.method_16();
                        }
                        else
                        {
                            this.method_25(0, 0, false);
                            if (A_0 == FlushType.Full)
                            {
                                for (int i = 0; i < this.int_35; i++)
                                {
                                    this.short_5[i] = 0;
                                }
                            }
                        }
                        this.class1068_0.method_19();
                        if (this.class1068_0.int_3 == 0)
                        {
                            this.int_41 = -1;
                            return 0;
                        }
                    }
                    break;
            }
        }
        if (A_0 == FlushType.Finish)
        {
            if (!this.method_0() || this.bool_0)
            {
                return 1;
            }
            this.method_13((int) Class604.smethod_1(this.class1068_0.long_2, 0x10));
            this.method_13((int) (this.class1068_0.long_2 & 0xffffL));
            this.class1068_0.method_19();
            this.bool_0 = true;
            if (this.int_51 == 0)
            {
                return 1;
            }
        }
        return 0;
    }

    internal void method_4()
    {
        for (int i = 0; i < int_26; i++)
        {
            this.short_4[i * 2] = 0;
        }
        for (int j = 0; j < 30; j++)
        {
            this.short_3[j * 2] = 0;
        }
        for (int k = 0; k < 0x13; k++)
        {
            this.short_2[k * 2] = 0;
        }
        this.short_4[0x200] = 1;
        this.int_54 = 0;
        this.int_50 = 0;
        this.int_48 = 0;
        this.int_42 = 0;
    }

    internal void method_5(short[] A_0, int A_1)
    {
        int num = this.int_36[A_1];
        for (int i = A_1 << 1; i <= this.int_37; i = i << 1)
        {
            if ((i < this.int_37) && smethod_0(A_0, this.int_36[i + 1], this.int_36[i], this.sbyte_1))
            {
                i++;
            }
            if (smethod_0(A_0, num, this.int_36[i], this.sbyte_1))
            {
                break;
            }
            this.int_36[A_1] = this.int_36[i];
            A_1 = i;
        }
        this.int_36[A_1] = num;
    }

    internal void method_6(short[] A_0, int A_1)
    {
        int num = -1;
        int num2 = A_0[1];
        int num3 = 0;
        int num4 = 7;
        int num5 = 4;
        if (num2 == 0)
        {
            num4 = 0x8a;
            num5 = 3;
        }
        A_0[((A_1 + 1) * 2) + 1] = 0x7fff;
        for (int i = 0; i <= A_1; i++)
        {
            int num6 = num2;
            num2 = A_0[((i + 1) * 2) + 1];
            if ((++num3 >= num4) || (num6 != num2))
            {
                if (num3 < num5)
                {
                    this.short_2[num6 * 2] = (short) (this.short_2[num6 * 2] + num3);
                }
                else if (num6 != 0)
                {
                    if (num6 != num)
                    {
                        this.short_2[num6 * 2] = (short) (this.short_2[num6 * 2] + 1);
                    }
                    this.short_2[0x20] = (short) (this.short_2[0x20] + 1);
                }
                else if (num3 <= 10)
                {
                    this.short_2[0x22] = (short) (this.short_2[0x22] + 1);
                }
                else
                {
                    this.short_2[0x24] = (short) (this.short_2[0x24] + 1);
                }
                num3 = 0;
                num = num6;
                if (num2 == 0)
                {
                    num4 = 0x8a;
                    num5 = 3;
                }
                else if (num6 == num2)
                {
                    num4 = 6;
                    num5 = 3;
                }
                else
                {
                    num4 = 7;
                    num5 = 4;
                }
            }
        }
    }

    internal int method_7()
    {
        this.method_6(this.short_4, this.class606_2.int_18);
        this.method_6(this.short_3, this.class606_1.int_18);
        this.class606_0.method_1(this);
        int index = 0x12;
        while (index >= 3)
        {
            if (this.short_2[(Class606.sbyte_0[index] * 2) + 1] != 0)
            {
                break;
            }
            index--;
        }
        this.int_50 += (((3 * (index + 1)) + 5) + 5) + 4;
        return index;
    }

    internal void method_8(int A_0, int A_1, int A_2)
    {
        this.method_15(A_0 - 0x101, 5);
        this.method_15(A_1 - 1, 5);
        this.method_15(A_2 - 4, 4);
        for (int i = 0; i < A_2; i++)
        {
            this.method_15(this.short_2[(Class606.sbyte_0[i] * 2) + 1], 3);
        }
        this.method_9(this.short_4, A_0 - 1);
        this.method_9(this.short_3, A_1 - 1);
    }

    internal void method_9(short[] A_0, int A_1)
    {
        int num = -1;
        int num2 = A_0[1];
        int num3 = 0;
        int num4 = 7;
        int num5 = 4;
        if (num2 == 0)
        {
            num4 = 0x8a;
            num5 = 3;
        }
        for (int i = 0; i <= A_1; i++)
        {
            int num6 = num2;
            num2 = A_0[((i + 1) * 2) + 1];
            if ((++num3 >= num4) || (num6 != num2))
            {
                if (num3 < num5)
                {
                    do
                    {
                        this.method_14(num6, this.short_2);
                    }
                    while (--num3 != 0);
                }
                else if (num6 != 0)
                {
                    if (num6 != num)
                    {
                        this.method_14(num6, this.short_2);
                        num3--;
                    }
                    this.method_14(0x10, this.short_2);
                    this.method_15(num3 - 3, 2);
                }
                else if (num3 <= 10)
                {
                    this.method_14(0x11, this.short_2);
                    this.method_15(num3 - 3, 3);
                }
                else
                {
                    this.method_14(0x12, this.short_2);
                    this.method_15(num3 - 11, 7);
                }
                num3 = 0;
                num = num6;
                if (num2 == 0)
                {
                    num4 = 0x8a;
                    num5 = 3;
                }
                else if (num6 == num2)
                {
                    num4 = 6;
                    num5 = 3;
                }
                else
                {
                    num4 = 7;
                    num5 = 4;
                }
            }
        }
    }

    internal static bool smethod_0(short[] A_0, int A_1, int A_2, sbyte[] A_3)
    {
        short num = A_0[A_1 * 2];
        short num2 = A_0[A_2 * 2];
        return ((num < num2) || ((num == num2) && (A_3[A_1] <= A_3[A_2])));
    }

    internal class Class936
    {
        private static readonly Class935.Class936[] class936_0 = new Class935.Class936[] { new Class935.Class936(0, 0, 0, 0, DeflateFlavor.Store), new Class935.Class936(4, 4, 8, 4, DeflateFlavor.Fast), new Class935.Class936(4, 5, 0x10, 8, DeflateFlavor.Fast), new Class935.Class936(4, 6, 0x20, 0x20, DeflateFlavor.Fast), new Class935.Class936(4, 4, 0x10, 0x10, DeflateFlavor.Slow), new Class935.Class936(8, 0x10, 0x20, 0x20, DeflateFlavor.Slow), new Class935.Class936(8, 0x10, 0x80, 0x80, DeflateFlavor.Slow), new Class935.Class936(8, 0x20, 0x80, 0x100, DeflateFlavor.Slow), new Class935.Class936(0x20, 0x80, 0x102, 0x400, DeflateFlavor.Slow), new Class935.Class936(0x20, 0x102, 0x102, 0x1000, DeflateFlavor.Slow) };
        internal DeflateFlavor deflateFlavor_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;

        private Class936(int A_0, int A_1, int A_2, int A_3, DeflateFlavor A_4)
        {
            this.int_0 = A_0;
            this.int_2 = A_1;
            this.int_3 = A_2;
            this.int_1 = A_3;
            this.deflateFlavor_0 = A_4;
        }

        public static Class935.Class936 smethod_0(CompressionLevel A_0)
        {
            return class936_0[(int) A_0];
        }
    }

    internal delegate BlockState Delegate6(FlushType A_0);
}

