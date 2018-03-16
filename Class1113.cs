using Spire.Compression;
using Spire.Doc;
using System;
using System.IO;

internal class Class1113
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private byte[] byte_0;
    private byte[] byte_1;
    [ThreadStatic]
    private static byte[] byte_2 = new byte[0x11e];
    [ThreadStatic]
    private static byte[] byte_3;
    private byte[] byte_4;
    private byte[] byte_5;
    private Class999 class999_0;
    private Class999 class999_1;
    private Class999 class999_2;
    private CompressionLevel compressionLevel_0;
    private const int int_0 = 0x7800;
    private const int int_1 = 8;
    public const int int_10 = 0x7fff;
    public const int int_11 = 15;
    public const int int_12 = 0x8000;
    public const int int_13 = 0x7fff;
    public const int int_14 = 0x102;
    public const int int_15 = 3;
    public const int int_16 = 5;
    public const int int_17 = 0x106;
    public const int int_18 = 0x7efa;
    public static int[] int_19 = new int[] { 0, 4, 4, 4, 4, 8, 8, 8, 0x20, 0x20 };
    private const int int_2 = 0x10000;
    public static int[] int_20 = new int[] { 0, 4, 5, 6, 4, 0x10, 0x10, 0x20, 0x80, 0x102 };
    public static int[] int_21 = new int[] { 0, 8, 0x10, 0x20, 0x10, 0x20, 0x80, 0x80, 0x102, 0x102 };
    public static int[] int_22 = new int[] { 0, 4, 8, 0x20, 0x10, 0x20, 0x80, 0x100, 0x400, 0x1000 };
    public static int[] int_23 = new int[] { 0, 1, 1, 1, 1, 2, 2, 2, 2, 2 };
    public static int int_24 = Math.Min(0xffff, 0xfffb);
    private int int_25;
    private int int_26;
    private int int_27;
    private int int_28;
    private int int_29;
    private const int int_3 = 0x4000;
    private int int_30;
    private int int_31;
    private int int_32;
    private int int_33;
    private int int_34;
    private int int_35;
    private int int_36;
    private int int_37;
    private int int_38;
    private int int_39;
    private const int int_4 = 0x11e;
    private int int_40;
    private int int_41;
    private int int_42;
    private const int int_5 = 30;
    private const int int_6 = 0x13;
    private const int int_7 = 0x100;
    private const int int_8 = 0x1000;
    private const int int_9 = 0x8000;
    private long long_0;
    private short[] short_0;
    [ThreadStatic]
    private static short[] short_1 = new short[0x11e];
    [ThreadStatic]
    private static short[] short_2;
    private short[] short_3;
    private short[] short_4;
    private Stream stream_0;
    private uint uint_0;

    static Class1113()
    {
        int index = 0;
        while (index < 0x90)
        {
            short_1[index] = Class1112.smethod_0((0x30 + index) << 8);
            byte_2[index++] = 8;
        }
        while (index < 0x100)
        {
            short_1[index] = Class1112.smethod_0((0x100 + index) << 7);
            byte_2[index++] = 9;
        }
        while (index < 280)
        {
            short_1[index] = Class1112.smethod_0((-256 + index) << 9);
            byte_2[index++] = 7;
        }
        while (index < 0x11e)
        {
            short_1[index] = Class1112.smethod_0((-88 + index) << 8);
            byte_2[index++] = 8;
        }
        short_2 = new short[30];
        byte_3 = new byte[30];
        for (index = 0; index < 30; index++)
        {
            short_2[index] = Class1112.smethod_0(index << 11);
            byte_3[index] = 5;
        }
    }

    public Class1113(Stream A_0, bool A_1) : this(A_0, false, CompressionLevel.Normal, A_1)
    {
    }

    internal Class1113(Stream A_0, CompressionLevel A_1, bool A_2) : this(A_0, false, A_1, A_2)
    {
    }

    public Class1113(Stream A_0, bool A_1, bool A_2) : this(A_0, A_1, CompressionLevel.Normal, A_2)
    {
    }

    internal Class1113(Stream A_0, bool A_1, CompressionLevel A_2, bool A_3)
    {
        int num = 0x10;
        this.byte_0 = new byte[0x10000];
        this.long_0 = 1L;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("夵䴷丹䰻䬽㐿ᅁぃ㑅ⵇ⭉⅋", num));
        }
        if (!A_0.CanWrite)
        {
            throw new ArgumentException(BookmarkStart.b("礵䴷丹䰻䬽㐿扁㝃㉅㩇⽉ⵋ⍍灏㙑㭓㍕⭗穙㉛ㅝᑟ䉡ᝣ፥ᡧᩩͫᱭѯ剱ͳѵᅷ๹ᕻၽ겁", num), BookmarkStart.b("夵䴷丹䰻䬽㐿ᅁぃ㑅ⵇ⭉⅋", num));
        }
        this.class999_0 = new Class999(this, 0x11e, 0x101, 15);
        this.class999_1 = new Class999(this, 30, 1, 15);
        this.class999_2 = new Class999(this, 0x13, 4, 7);
        this.short_0 = new short[0x4000];
        this.byte_1 = new byte[0x4000];
        this.stream_0 = A_0;
        this.compressionLevel_0 = A_2;
        this.bool_0 = A_1;
        this.bool_3 = A_3;
        this.byte_4 = new byte[0x10000];
        this.short_3 = new short[0x8000];
        this.short_4 = new short[0x8000];
        this.int_33 = 1;
        this.int_32 = 1;
        this.int_38 = int_19[(int) A_2];
        this.int_36 = int_20[(int) A_2];
        this.int_37 = int_21[(int) A_2];
        this.int_35 = int_22[(int) A_2];
        this.int_39 = int_23[(int) A_2];
        if (!A_1)
        {
            this.method_5();
        }
    }

    public void method_0(byte[] A_0, int A_1, int A_2, bool A_3)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("启匱䀳圵", num));
        }
        int num2 = A_1 + A_2;
        if (((0 > A_1) || (A_1 > num2)) || (num2 > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("缯吱刳䔵崷丹᰻儽㈿扁⡃⍅♇ⵉ㡋♍灏㭑❓癕ㅗ㑙㽛ㅝ቟ၡţեᱧ䑩", num));
        }
        this.byte_5 = A_0;
        this.int_41 = A_1;
        this.int_42 = num2;
        if (A_2 != 0)
        {
            if (this.bool_1)
            {
                throw new IOException(BookmarkStart.b("振䘱䘳匵夷圹᰻䤽ℿㅁ摃╅⑇╉㽋⭍㑏籑", num));
            }
            Class1000.smethod_0(ref this.long_0, this.byte_5, this.int_41, A_2);
            while (!this.method_3() || !this.method_32())
            {
                this.method_33();
                if (!this.method_14(A_3) && A_3)
                {
                    this.method_33();
                    this.method_29();
                    if (!this.bool_0)
                    {
                        this.method_31((int) (this.long_0 >> 0x10));
                        this.method_31((int) (this.long_0 & 0xffffL));
                    }
                    this.method_33();
                    this.bool_1 = true;
                    if (this.bool_3)
                    {
                        this.stream_0.Close();
                    }
                }
            }
        }
    }

    public void method_1()
    {
        if (this.bool_1)
        {
            return;
        }
    Label_005E:
        this.method_33();
        if (!this.method_14(true))
        {
            this.method_33();
            this.method_29();
            if (!this.bool_0)
            {
                this.method_31((int) (this.long_0 >> 0x10));
                this.method_31((int) (this.long_0 & 0xffffL));
            }
            this.method_33();
        }
        if (this.method_3() && this.method_32())
        {
            this.bool_1 = true;
            if (this.bool_3)
            {
                this.stream_0.Close();
            }
        }
        else
        {
            goto Label_005E;
        }
    }

    private bool method_10(int A_0)
    {
        int num = this.int_35;
        int num2 = this.int_37;
        short[] numArray = this.short_4;
        int index = this.int_33;
        int num4 = this.int_33 + this.int_31;
        int num5 = Math.Max(this.int_31, 2);
        int num6 = Math.Max(this.int_33 - 0x7efa, 0);
        int num7 = (this.int_33 + 0x102) - 1;
        byte num8 = this.byte_4[num4 - 1];
        byte num9 = this.byte_4[num4];
        if (num5 >= this.int_38)
        {
            num = num >> 2;
        }
        if (num2 > this.int_34)
        {
            num2 = this.int_34;
        }
        do
        {
            if ((this.byte_4[A_0 + num5] == num9) && (((this.byte_4[(A_0 + num5) - 1] == num8) && (this.byte_4[A_0] == this.byte_4[index])) && (this.byte_4[A_0 + 1] == this.byte_4[index + 1])))
            {
                int num10 = A_0 + 2;
                index += 2;
                while (this.byte_4[++index] == this.byte_4[++num10])
                {
                    if ((((this.byte_4[++index] != this.byte_4[++num10]) || (this.byte_4[++index] != this.byte_4[++num10])) || ((this.byte_4[++index] != this.byte_4[++num10]) || (this.byte_4[++index] != this.byte_4[++num10]))) || (((this.byte_4[++index] != this.byte_4[++num10]) || (this.byte_4[++index] != this.byte_4[++num10])) || ((this.byte_4[++index] != this.byte_4[++num10]) || (index >= num7))))
                    {
                        break;
                    }
                }
                if (index > num4)
                {
                    this.int_30 = A_0;
                    num4 = index;
                    num5 = index - this.int_33;
                    if (num5 >= num2)
                    {
                        break;
                    }
                    num8 = this.byte_4[num4 - 1];
                    num9 = this.byte_4[num4];
                }
                index = this.int_33;
            }
        }
        while (((A_0 = numArray[A_0 & 0x7fff] & 0xffff) > num6) && (--num != 0));
        this.int_31 = Math.Min(num5, this.int_34);
        return (this.int_31 >= 3);
    }

    private bool method_11(bool A_0, bool A_1)
    {
        if (!A_0 && (this.int_34 == 0))
        {
            return false;
        }
        this.int_33 += this.int_34;
        this.int_34 = 0;
        int num = this.int_33 - this.int_32;
        if (((num < int_24) && ((this.int_32 >= 0x8000) || (num < 0x7efa))) && !A_0)
        {
            return true;
        }
        bool flag = A_1;
        if (num > int_24)
        {
            num = int_24;
            flag = false;
        }
        this.method_20(this.byte_4, this.int_32, num, flag);
        this.int_32 += num;
        return !flag;
    }

    private bool method_12(bool A_0, bool A_1)
    {
        if ((this.int_34 >= 0x106) || A_0)
        {
            while ((this.int_34 >= 0x106) || A_0)
            {
                int num;
                if (this.int_34 == 0)
                {
                    this.method_21(this.byte_4, this.int_32, this.int_33 - this.int_32, A_1);
                    this.int_32 = this.int_33;
                    return false;
                }
                if (this.int_33 > 0xfefa)
                {
                    this.method_7();
                }
                if (((this.int_34 >= 3) && ((num = this.method_9()) != 0)) && (((this.int_33 - num) <= 0x7efa) && this.method_10(num)))
                {
                    if (this.method_23(this.int_33 - this.int_30, this.int_31))
                    {
                        bool flag2 = A_1 && (this.int_34 == 0);
                        this.method_21(this.byte_4, this.int_32, this.int_33 - this.int_32, flag2);
                        this.int_32 = this.int_33;
                    }
                    this.int_34 -= this.int_31;
                    if ((this.int_31 <= this.int_36) && (this.int_34 >= 3))
                    {
                        while (--this.int_31 > 0)
                        {
                            this.int_33++;
                            this.method_9();
                        }
                        this.int_33++;
                    }
                    else
                    {
                        this.int_33 += this.int_31;
                        if (this.int_34 >= 2)
                        {
                            this.method_8();
                        }
                    }
                    this.int_31 = 2;
                }
                else
                {
                    this.method_22(this.byte_4[this.int_33] & 0xff);
                    this.int_33++;
                    this.int_34--;
                    if (this.method_4())
                    {
                        bool flag = A_1 && (this.int_34 == 0);
                        this.method_21(this.byte_4, this.int_32, this.int_33 - this.int_32, flag);
                        this.int_32 = this.int_33;
                        return !flag;
                    }
                }
            }
            return true;
        }
        return false;
    }

    private bool method_13(bool A_0, bool A_1)
    {
        if ((this.int_34 >= 0x106) || A_0)
        {
            goto Label_0183;
        }
        return false;
    Label_0171:
        if (this.method_4())
        {
            int num4 = this.int_33 - this.int_32;
            if (this.bool_2)
            {
                num4--;
            }
            bool flag = (A_1 && (this.int_34 == 0)) && !this.bool_2;
            this.method_21(this.byte_4, this.int_32, num4, flag);
            this.int_32 += num4;
            return !flag;
        }
    Label_0183:
        if ((this.int_34 >= 0x106) || A_0)
        {
            if (this.int_34 == 0)
            {
                if (this.bool_2)
                {
                    this.method_22(this.byte_4[this.int_33 - 1] & 0xff);
                }
                this.bool_2 = false;
                this.method_21(this.byte_4, this.int_32, this.int_33 - this.int_32, A_1);
                this.int_32 = this.int_33;
                return false;
            }
            if (this.int_33 >= 0xfefa)
            {
                this.method_7();
            }
            int num = this.int_30;
            int num2 = this.int_31;
            if (this.int_34 >= 3)
            {
                int num3 = this.method_9();
                if ((((num3 != 0) && ((this.int_33 - num3) <= 0x7efa)) && (this.method_10(num3) && (this.int_31 <= 5))) && ((this.int_31 == 3) && ((this.int_33 - this.int_30) > 0x1000)))
                {
                    this.int_31 = 2;
                }
            }
            if ((num2 < 3) || (this.int_31 > num2))
            {
                if (this.bool_2)
                {
                    this.method_22(this.byte_4[this.int_33 - 1] & 0xff);
                }
                this.bool_2 = true;
                this.int_33++;
                this.int_34--;
                goto Label_0171;
            }
            this.method_23((this.int_33 - 1) - num, num2);
            num2 -= 2;
        Label_00D7:
            this.int_33++;
            this.int_34--;
            if (this.int_34 >= 3)
            {
                this.method_9();
            }
            if (--num2 <= 0)
            {
                this.int_33++;
                this.int_34--;
                this.bool_2 = false;
                this.int_31 = 2;
            }
            else
            {
                goto Label_00D7;
            }
            goto Label_0171;
        }
        return true;
    }

    private bool method_14(bool A_0)
    {
        // This item is obfuscated and can not be translated.
        bool flag2;
        int num = 11;
        goto Label_0059;
    Label_0044:
        if (!this.method_32() || !flag2)
        {
            return flag2;
        }
    Label_0059:
        this.method_6();
        if (!A_0)
        {
        }
        bool flag = false;
        switch (this.int_39)
        {
            case 0:
                flag2 = this.method_11(flag, A_0);
                goto Label_0044;

            case 1:
                flag2 = this.method_12(flag, A_0);
                goto Label_0044;

            case 2:
                flag2 = this.method_13(flag, A_0);
                goto Label_0044;
        }
        throw new InvalidOperationException(BookmarkStart.b("䐰崲帴夶嘸䰺匼Ἶⱀ᱂ل⡆⑈㭊㽌⩎≐⁒㱔㡖㝘ᵚ⡜ㅞɠᝢ౤ࡦݨ", num));
    }

    private void method_15()
    {
        this.int_27 = 0;
        this.int_28 = 0;
        this.class999_0.method_0();
        this.class999_1.method_0();
        this.class999_2.method_0();
    }

    private int method_16(int A_0)
    {
        if (A_0 == 0xff)
        {
            return 0x11d;
        }
        int num = 0x101;
        while (A_0 >= 8)
        {
            num += 4;
            A_0 = A_0 >> 1;
        }
        return (num + A_0);
    }

    private int method_17(int A_0)
    {
        int num = 0;
        while (A_0 >= 4)
        {
            num += 2;
            A_0 = A_0 >> 1;
        }
        return (num + A_0);
    }

    private void method_18(int A_0)
    {
        this.class999_2.method_4();
        this.class999_0.method_4();
        this.class999_1.method_4();
        this.method_30(this.class999_0.method_10() - 0x101, 5);
        this.method_30(this.class999_1.method_10() - 1, 5);
        this.method_30(A_0 - 4, 4);
        for (int i = 0; i < A_0; i++)
        {
            this.method_30(this.class999_2.method_11()[Class1112.int_0[i]], 3);
        }
        this.class999_0.method_9(this.class999_2);
        this.class999_1.method_9(this.class999_2);
    }

    private void method_19()
    {
        for (int i = 0; i < this.int_27; i++)
        {
            int num2 = this.byte_1[i] & 0xff;
            int num3 = this.short_0[i];
            if (num3-- != 0)
            {
                int num6 = this.method_16(num2);
                this.class999_0.method_1(num6);
                int num5 = (num6 - 0x105) / 4;
                if ((num5 > 0) && (num5 <= 5))
                {
                    this.method_30(num2 & ((((int) 1) << num5) - 1), num5);
                }
                int num4 = this.method_17(num3);
                this.class999_1.method_1(num4);
                num5 = (num4 / 2) - 1;
                if (num5 > 0)
                {
                    this.method_30(num3 & ((((int) 1) << num5) - 1), num5);
                }
            }
            else
            {
                this.class999_0.method_1(num2);
            }
        }
        this.class999_0.method_1(0x100);
    }

    public int method_2()
    {
        return this.int_40;
    }

    private void method_20(byte[] A_0, int A_1, int A_2, bool A_3)
    {
        this.method_30(A_3 ? 1 : 0, 3);
        this.method_29();
        this.method_25(A_2);
        this.method_25(~A_2);
        this.method_27(A_0, A_1, A_2);
        this.method_15();
    }

    private void method_21(byte[] A_0, int A_1, int A_2, bool A_3)
    {
        this.class999_0.method_12()[0x100] = (short) (this.class999_0.method_12()[0x100] + 1);
        this.class999_0.method_6();
        this.class999_1.method_6();
        this.class999_0.method_8(this.class999_2);
        this.class999_1.method_8(this.class999_2);
        this.class999_2.method_6();
        int num = 4;
        for (int i = 0x12; i > num; i--)
        {
            if (this.class999_2.method_11()[Class1112.int_0[i]] > 0)
            {
                num = i + 1;
            }
        }
        int num3 = ((((14 + (num * 3)) + this.class999_2.method_7()) + this.class999_0.method_7()) + this.class999_1.method_7()) + this.int_28;
        int num4 = this.int_28;
        for (int j = 0; j < 0x11e; j++)
        {
            num4 += this.class999_0.method_12()[j] * byte_2[j];
        }
        for (int k = 0; k < 30; k++)
        {
            num4 += this.class999_1.method_12()[k] * byte_3[k];
        }
        if (num3 >= num4)
        {
            num3 = num4;
        }
        if ((A_1 >= 0) && ((A_2 + 4) < (num3 >> 3)))
        {
            this.method_20(A_0, A_1, A_2, A_3);
        }
        else if (num3 == num4)
        {
            this.method_30(2 + (A_3 ? 1 : 0), 3);
            this.class999_0.method_3(short_1, byte_2);
            this.class999_1.method_3(short_2, byte_3);
            this.method_19();
            this.method_15();
        }
        else
        {
            this.method_30(4 + (A_3 ? 1 : 0), 3);
            this.method_18(num);
            this.method_19();
            this.method_15();
        }
    }

    private bool method_22(int A_0)
    {
        this.short_0[this.int_27] = 0;
        this.byte_1[this.int_27++] = (byte) A_0;
        this.class999_0.method_12()[A_0] = (short) (this.class999_0.method_12()[A_0] + 1);
        return this.method_4();
    }

    private bool method_23(int A_0, int A_1)
    {
        this.short_0[this.int_27] = (short) A_0;
        this.byte_1[this.int_27++] = (byte) (A_1 - 3);
        int index = this.method_16(A_1 - 3);
        this.class999_0.method_12()[index] = (short) (this.class999_0.method_12()[index] + 1);
        if ((index >= 0x109) && (index < 0x11d))
        {
            this.int_28 += (index - 0x105) / 4;
        }
        int num3 = this.method_17(A_0 - 1);
        this.class999_1.method_12()[num3] = (short) (this.class999_1.method_12()[num3] + 1);
        if (num3 >= 4)
        {
            this.int_28 += (num3 / 2) - 1;
        }
        return this.method_4();
    }

    internal void method_24(int A_0)
    {
        this.byte_0[this.int_25++] = (byte) A_0;
    }

    internal void method_25(int A_0)
    {
        this.byte_0[this.int_25++] = (byte) A_0;
        this.byte_0[this.int_25++] = (byte) (A_0 >> 8);
    }

    internal void method_26(int A_0)
    {
        this.byte_0[this.int_25++] = (byte) A_0;
        this.byte_0[this.int_25++] = (byte) (A_0 >> 8);
        this.byte_0[this.int_25++] = (byte) (A_0 >> 0x10);
        this.byte_0[this.int_25++] = (byte) (A_0 >> 0x18);
    }

    internal void method_27(byte[] A_0, int A_1, int A_2)
    {
        Array.Copy(A_0, A_1, this.byte_0, this.int_25, A_2);
        this.int_25 += A_2;
    }

    internal int method_28()
    {
        return this.int_26;
    }

    internal void method_29()
    {
        if (this.int_26 > 0)
        {
            this.byte_0[this.int_25++] = (byte) this.uint_0;
            if (this.int_26 > 8)
            {
                this.byte_0[this.int_25++] = (byte) (this.uint_0 >> 8);
            }
        }
        this.uint_0 = 0;
        this.int_26 = 0;
    }

    private bool method_3()
    {
        return (this.int_42 == this.int_41);
    }

    internal void method_30(int A_0, int A_1)
    {
        this.uint_0 |= (uint) (A_0 << this.int_26);
        this.int_26 += A_1;
        this.method_34();
    }

    internal void method_31(int A_0)
    {
        this.byte_0[this.int_25++] = (byte) (A_0 >> 8);
        this.byte_0[this.int_25++] = (byte) A_0;
    }

    internal bool method_32()
    {
        return (this.int_25 == 0);
    }

    internal void method_33()
    {
        this.method_34();
        this.stream_0.Write(this.byte_0, 0, this.int_25);
        this.int_25 = 0;
        this.stream_0.Flush();
    }

    internal int method_34()
    {
        int num = 0;
        while (this.int_26 >= 8)
        {
            if (this.int_25 >= 0x10000)
            {
                return num;
            }
            this.byte_0[this.int_25++] = (byte) this.uint_0;
            this.uint_0 = this.uint_0 >> 8;
            this.int_26 -= 8;
            num++;
        }
        return num;
    }

    internal byte[] method_35()
    {
        byte[] destinationArray = new byte[this.int_25];
        Array.Copy(this.byte_0, 0, destinationArray, 0, destinationArray.Length);
        this.int_25 = 0;
        return destinationArray;
    }

    private bool method_4()
    {
        return (this.int_27 >= 0x4000);
    }

    private void method_5()
    {
        int num = 0x7800;
        num = 0x7800 | (((int) ((this.compressionLevel_0 >> 2) & 3)) << 6);
        num += 0x1f - (num % 0x1f);
        this.method_31(num);
    }

    private void method_6()
    {
        if (this.int_33 >= 0xfefa)
        {
            this.method_7();
        }
        while (this.int_34 < 0x106)
        {
            if (this.int_41 >= this.int_42)
            {
                break;
            }
            int length = (0x10000 - this.int_34) - this.int_33;
            if (length > (this.int_42 - this.int_41))
            {
                length = this.int_42 - this.int_41;
            }
            Array.Copy(this.byte_5, this.int_41, this.byte_4, this.int_33 + this.int_34, length);
            this.int_41 += length;
            this.int_40 += length;
            this.int_34 += length;
        }
        if (this.int_34 >= 3)
        {
            this.method_8();
        }
    }

    private void method_7()
    {
        Array.Copy(this.byte_4, 0x8000, this.byte_4, 0, 0x8000);
        this.int_30 -= 0x8000;
        this.int_33 -= 0x8000;
        this.int_32 -= 0x8000;
        for (int i = 0; i < 0x8000; i++)
        {
            int num2 = this.short_3[i] & 0xffff;
            this.short_3[i] = (num2 >= 0x8000) ? ((short) (num2 - 0x8000)) : ((short) 0);
        }
        for (int j = 0; j < 0x8000; j++)
        {
            int num4 = this.short_4[j] & 0xffff;
            this.short_4[j] = (num4 >= 0x8000) ? ((short) (num4 - 0x8000)) : ((short) 0);
        }
    }

    private void method_8()
    {
        this.int_29 = (this.byte_4[this.int_33] << 5) ^ this.byte_4[this.int_33 + 1];
    }

    private int method_9()
    {
        short num;
        int index = ((this.int_29 << 5) ^ this.byte_4[this.int_33 + 2]) & 0x7fff;
        this.short_4[this.int_33 & 0x7fff] = num = this.short_3[index];
        this.short_3[index] = (short) this.int_33;
        this.int_29 = index;
        return (num & 0xffff);
    }

    private enum BlockType
    {
        Stored,
        FixedHuffmanCodes,
        DynamicHuffmanCodes
    }
}

