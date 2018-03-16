using Spire.Compression.Zip;
using Spire.Doc;
using System;

internal sealed class Class609
{
    private bool bool_0;
    private static readonly byte[] byte_0;
    internal Class1068 class1068_0;
    internal Class607 class607_0;
    private const int int_0 = 0x20;
    private const int int_1 = 8;
    private const int int_10 = 8;
    private const int int_11 = 9;
    private const int int_12 = 10;
    private const int int_13 = 11;
    private const int int_14 = 12;
    private const int int_15 = 13;
    internal int int_16;
    internal int int_17;
    internal int int_18;
    internal int int_19;
    private const int int_2 = 0;
    private const int int_3 = 1;
    private const int int_4 = 2;
    private const int int_5 = 3;
    private const int int_6 = 4;
    private const int int_7 = 5;
    private const int int_8 = 6;
    private const int int_9 = 7;
    internal long long_0;
    internal long[] long_1;

    static Class609()
    {
        byte[] buffer = new byte[4];
        buffer[2] = 0xff;
        buffer[3] = 0xff;
        byte_0 = buffer;
    }

    public Class609()
    {
        this.bool_0 = true;
        this.long_1 = new long[1];
    }

    public Class609(bool A_0)
    {
        this.bool_0 = true;
        this.long_1 = new long[1];
        this.bool_0 = A_0;
    }

    internal bool method_0()
    {
        return this.bool_0;
    }

    internal void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal int method_2()
    {
        this.class1068_0.long_1 = 0L;
        this.class1068_0.long_0 = 0L;
        this.class1068_0.string_0 = null;
        this.int_18 = this.method_0() ? 0 : 7;
        this.class607_0.method_0(null);
        return 0;
    }

    internal int method_3()
    {
        if (this.class607_0 != null)
        {
            this.class607_0.method_2();
        }
        this.class607_0 = null;
        return 0;
    }

    internal int method_4(Class1068 A_0, int A_1)
    {
        int num = 7;
        this.class1068_0 = A_0;
        this.class1068_0.string_0 = null;
        this.class607_0 = null;
        if ((A_1 >= 8) && (A_1 <= 15))
        {
            this.int_19 = A_1;
        }
        else
        {
            this.method_3();
            throw new Exception0(BookmarkStart.b("漬丮唰ጲ䈴帶圸强刼䠾慀あⱄ㵆ⱈ敊", num));
        }
        this.class607_0 = new Class607(A_0, this.method_0() ? this : null, ((int) 1) << A_1);
        this.method_2();
        return 0;
    }

    internal int method_5(FlushType A_0)
    {
        int num = 0;
        int num2 = (int) A_0;
        if (this.class1068_0.byte_0 == null)
        {
            throw new Exception0(BookmarkStart.b("漥䘧娩夫娭爯䜱刳倵崷䠹᰻圽㌿扁⩃㍅⑇♉手湍", num));
        }
        num2 = (num2 == 4) ? -5 : 0;
        int num3 = -5;
        goto Label_04C4;
    Label_0038:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 += this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xffL;
        if (((int) this.long_1[0]) == ((int) this.long_0))
        {
            this.int_18 = 12;
            goto Label_07AE;
        }
        this.int_18 = 13;
        this.class1068_0.string_0 = BookmarkStart.b("伥䘧䤩䌫尭䈯圱圳䈵ᠷ帹崻䨽ℿ扁❃⹅ⵇ⥉❋", num);
        this.int_16 = 5;
        goto Label_04C4;
    Label_00F3:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 += ((this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff) << 8) & 0xff00L;
        this.int_18 = 11;
        goto Label_0038;
    Label_0184:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 += ((this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff) << 0x10) & 0xff0000L;
        this.int_18 = 10;
        goto Label_00F3;
    Label_0214:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 = ((this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff) << 0x18) & -16777216;
        this.int_18 = 9;
        goto Label_0184;
    Label_0303:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        int num10 = this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff;
        if ((((this.int_17 << 8) + num10) % 0x1f) != 0)
        {
            this.int_18 = 13;
            this.class1068_0.string_0 = BookmarkStart.b("伥䘧䤩䌫尭䈯圱圳䈵ᠷ刹夻弽␿❁㙃晅⭇≉⥋ⵍ㭏", num);
            this.int_16 = 5;
        }
        else
        {
            if ((num10 & 0x20) != 0)
            {
                this.int_18 = 2;
                goto Label_0527;
            }
            this.int_18 = 7;
        }
    Label_04C4:
        switch (this.int_18)
        {
            case 0:
                if (this.class1068_0.int_1 == 0)
                {
                    return num3;
                }
                num3 = num2;
                this.class1068_0.int_1--;
                this.class1068_0.long_0 += 1L;
                if (((this.int_17 = this.class1068_0.byte_0[this.class1068_0.int_0++]) & 15) != 8)
                {
                    this.int_18 = 13;
                    this.class1068_0.string_0 = string.Format(BookmarkStart.b("匥䘧䄩䈫䄭䜯就ᐳ唵圷圹䰻䰽┿ㅁ㝃⽅❇⑉汋⍍㕏♑㱓㥕㱗穙瑛湝ᡟᥡ呣履で塩ᅫ䝭", num), this.int_17);
                    this.int_16 = 5;
                }
                else if (((this.int_17 >> 4) + 8) > this.int_19)
                {
                    this.int_18 = 13;
                    this.class1068_0.string_0 = string.Format(BookmarkStart.b("伥䘧尩䴫䈭夯嘱ᐳ䄵儷吹堻儽㜿扁㝃⽅㉇⽉汋晍⭏扑⥓罕", num), (this.int_17 >> 4) + 8);
                    this.int_16 = 5;
                }
                else
                {
                    this.int_18 = 1;
                    goto Label_0303;
                }
                goto Label_04C4;

            case 1:
                goto Label_0303;

            case 2:
                goto Label_0527;

            case 3:
                goto Label_05A7;

            case 4:
                goto Label_0632;

            case 5:
                goto Label_06BC;

            case 6:
                this.int_18 = 13;
                this.class1068_0.string_0 = BookmarkStart.b("䠥䴧伩䠫อ启嬱圳䈵儷唹刻弽㈿㭁", num);
                this.int_16 = 0;
                return -2;

            case 7:
                num3 = this.class607_0.method_1(num3);
                switch (num3)
                {
                    case -3:
                        this.int_18 = 13;
                        this.int_16 = 0;
                        goto Label_04C4;

                    case 0:
                        num3 = num2;
                        break;
                }
                if (num3 != 1)
                {
                    return num3;
                }
                num3 = num2;
                this.class607_0.method_0(this.long_1);
                if (!this.method_0())
                {
                    this.int_18 = 12;
                    goto Label_04C4;
                }
                this.int_18 = 8;
                goto Label_0214;

            case 8:
                goto Label_0214;

            case 9:
                goto Label_0184;

            case 10:
                goto Label_00F3;

            case 11:
                goto Label_0038;

            case 12:
                goto Label_07AE;

            case 13:
                throw new Exception0(string.Format(BookmarkStart.b("搥䤧丩ఫ崭䐯匱䀳匵ᠷሹ䜻฽㴿歁", num), this.class1068_0.string_0));
        }
        throw new Exception0(BookmarkStart.b("甥尧堩䤫伭崯ሱ儳䐵䨷唹主ွ", num));
    Label_0527:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 = ((this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff) << 0x18) & -16777216;
        this.int_18 = 3;
    Label_05A7:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 += ((this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff) << 0x10) & 0xff0000L;
        this.int_18 = 4;
    Label_0632:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 += ((this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xff) << 8) & 0xff00L;
        this.int_18 = 5;
    Label_06BC:
        if (this.class1068_0.int_1 == 0)
        {
            return num3;
        }
        num3 = num2;
        this.class1068_0.int_1--;
        this.class1068_0.long_0 += 1L;
        this.long_0 += this.class1068_0.byte_0[this.class1068_0.int_0++] & 0xffL;
        this.class1068_0.long_2 = this.long_0;
        this.int_18 = 6;
        return 2;
    Label_07AE:
        return 1;
    }

    internal int method_6(byte[] A_0)
    {
        int num = 1;
        int num2 = 0;
        int length = A_0.Length;
        if (this.int_18 != 6)
        {
            throw new Exception0(BookmarkStart.b("琦崨太䠬丮尰ጲ倴䔶䬸吺似ᄾ", num));
        }
        if (Class603.smethod_0(1L, A_0, 0, A_0.Length) != this.class1068_0.long_2)
        {
            return -3;
        }
        this.class1068_0.long_2 = Class603.smethod_0(0L, null, 0, 0);
        if (length >= (((int) 1) << this.int_19))
        {
            length = (((int) 1) << this.int_19) - 1;
            num2 = A_0.Length - length;
        }
        this.class607_0.method_3(A_0, num2, length);
        this.int_18 = 7;
        return 0;
    }

    internal int method_7()
    {
        if (this.int_18 != 13)
        {
            this.int_18 = 13;
            this.int_16 = 0;
        }
        int num2 = this.class1068_0.int_1;
        if (num2 == 0)
        {
            return -5;
        }
        int index = this.class1068_0.int_0;
        int num3 = this.int_16;
        while (num2 != 0)
        {
            if (num3 >= 4)
            {
                break;
            }
            if (this.class1068_0.byte_0[index] == byte_0[num3])
            {
                num3++;
            }
            else if (this.class1068_0.byte_0[index] != 0)
            {
                num3 = 0;
            }
            else
            {
                num3 = 4 - num3;
            }
            index++;
            num2--;
        }
        this.class1068_0.long_0 += index - this.class1068_0.int_0;
        this.class1068_0.int_0 = index;
        this.class1068_0.int_1 = num2;
        this.int_16 = num3;
        if (num3 != 4)
        {
            return -3;
        }
        long num4 = this.class1068_0.long_0;
        long num5 = this.class1068_0.long_1;
        this.method_2();
        this.class1068_0.long_0 = num4;
        this.class1068_0.long_1 = num5;
        this.int_18 = 7;
        return 0;
    }

    internal int method_8(Class1068 A_0)
    {
        return this.class607_0.method_4();
    }
}

