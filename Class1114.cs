using Spire.Doc;
using System;
using System.IO;
using System.Runtime.InteropServices;

internal class Class1114
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private byte[] byte_0;
    private byte[] byte_1;
    private Class1067 class1067_0;
    private Class1067 class1067_1;
    private const int int_0 = 0xf00;
    private const int int_1 = 0xf000;
    private const int int_10 = 0x1d;
    private static readonly int[] int_11 = new int[] { 3, 3, 11 };
    private static readonly int[] int_12 = new int[] { 2, 3, 7 };
    private static readonly int[] int_13 = new int[] { 
        3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 0x11, 0x13, 0x17, 0x1b, 0x1f, 
        0x23, 0x2b, 0x33, 0x3b, 0x43, 0x53, 0x63, 0x73, 0x83, 0xa3, 0xc3, 0xe3, 0x102
     };
    private static readonly int[] int_14 = new int[] { 
        0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 
        3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0
     };
    private static readonly int[] int_15 = new int[] { 
        1, 2, 3, 4, 5, 7, 9, 13, 0x11, 0x19, 0x21, 0x31, 0x41, 0x61, 0x81, 0xc1, 
        0x101, 0x181, 0x201, 0x301, 0x401, 0x601, 0x801, 0xc01, 0x1001, 0x1801, 0x2001, 0x3001, 0x4001, 0x6001
     };
    private static readonly int[] int_16 = new int[] { 
        0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 
        7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13
     };
    private int int_17;
    private int int_18;
    private int int_19;
    private const int int_2 = 0x1f;
    private const int int_3 = 0x20;
    private const int int_4 = 0xc0;
    private const int int_5 = 0xffff;
    private const int int_6 = 0x102;
    private const int int_7 = 0x100;
    private const int int_8 = 0x101;
    private const int int_9 = 0x11d;
    private long long_0;
    private long long_1;
    private long long_2;
    private Stream stream_0;
    private uint uint_0;

    public Class1114(Stream A_0) : this(A_0, false)
    {
    }

    public Class1114(Stream A_0, bool A_1)
    {
        int num = 8;
        this.long_0 = 1L;
        this.byte_0 = new byte[4];
        this.byte_1 = new byte[0xffff];
        this.bool_2 = true;
        this.bool_3 = true;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崭䐯䀱儳圵唷", num));
        }
        if (A_0.Length == 0L)
        {
            throw new ArgumentException(BookmarkStart.b("崭䐯䀱儳圵唷ᨹᄻḽ㌿㙁㙃⽅♇ⵉ汋ⵍㅏ㱑瑓㡕㝗⹙籛㱝՟䉡ţ୥ᡧṩᕫ", num));
        }
        this.stream_0 = A_0;
        this.bool_0 = A_1;
        if (!this.bool_0)
        {
            this.method_13();
        }
        this.method_16();
    }

    protected internal int method_0()
    {
        return this.int_17;
    }

    protected internal long method_1()
    {
        return (((this.stream_0.Length - this.stream_0.Position) + this.int_17) >> 3);
    }

    protected internal int method_10()
    {
        int num = this.method_9(8) << 8;
        return (num | this.method_9(8));
    }

    protected internal int method_11()
    {
        return (this.method_9(8) | (this.method_9(8) << 8));
    }

    protected internal long method_12()
    {
        long num = (long) ((ulong) (this.method_9(8) << 0x18));
        num |= (long) ((ulong) (this.method_9(8) << 0x10));
        num |= (long) ((ulong) (this.method_9(8) << 8));
        return (num | ((long) ((ulong) this.method_9(8))));
    }

    protected void method_13()
    {
        int num = 5;
        int num2 = this.method_10();
        if (num2 == -1)
        {
            throw new Exception(BookmarkStart.b("挪䠬丮唰嘲䜴᜶嘸崺ᴼ䬾⥀♂敄㑆㵈㥊⡌⹎㱐獒㙔㙖㝘筚㍜ぞᕠ䍢ݤɦ䥨ᥪ࡬๮ᕰ嵲", num));
        }
        if ((num2 % 0x1f) != 0)
        {
            throw new FormatException(BookmarkStart.b("挪䠬丮唰嘲䜴᜶娸区堼尾⩀あい⩆楈≊⅌⍎㑐㑒㑔㭖", num));
        }
        if ((num2 & 0xf00) != 0x800)
        {
            throw new FormatException(BookmarkStart.b("縪䌬尮䐰䌲䔴堶䬸伺堼嬾慀⁂⩄⩆㥈㥊⡌㱎≐㩒㩔㥖祘㙚㡜⭞ॠౢŤ䥦", num));
        }
        this.int_18 = (int) Math.Pow(2.0, (double) (((num2 & 0xf000) >> 12) + 8));
        if (this.int_18 > 0xffff)
        {
            throw new FormatException(BookmarkStart.b("縪䌬尮䐰䌲䔴堶䬸伺堼嬾慀㑂ⱄ⥆ⵈ⑊㩌潎≐㩒⽔㉖祘㵚㉜ⵞ䅠ݢdŦը੪ᥬ੮兰ၲᩴ᩶ॸॺ᡼౾ꦈﮎ戀ﲒ릖", num));
        }
        if (((num2 & 0x20) >> 5) == 1)
        {
            throw new NotImplementedException(BookmarkStart.b("株堬尮䔰尲場᜶崸刺帼䬾⡀ⱂ⭄♆㭈㉊浌♎≐獒㭔㡖ⵘ筚⹜⩞ᅠ።੤ᕦᵨ๪६佮ၰݲ啴ͶᅸṺ嵼ቾﶈꖊ", num));
        }
    }

    protected string method_14(int A_0, int A_1)
    {
        int num = 15;
        string str = "";
        for (int i = 0; i < A_1; i++)
        {
            if ((i & 7) == 0)
            {
                str = BookmarkStart.b("ᔴ", num) + str;
            }
            str = ((A_0 & 1)).ToString() + str;
            A_0 = A_0 >> 1;
        }
        return str;
    }

    protected void method_15(out Class1067 A_0, out Class1067 A_1)
    {
        int num = 1;
        byte num2 = 0;
        int length = this.method_9(5);
        int num4 = this.method_9(5);
        int num5 = this.method_9(4);
        if (((length < 0) || (num4 < 0)) || (num5 < 0))
        {
            throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲䰴夶堸嘺吼尾慀⭂いⅆ⽈♊ⱌⅎ煐げ㩔㍖㱘⡚獜", num));
        }
        length += 0x101;
        num4++;
        int num9 = length + num4;
        byte[] sourceArray = new byte[num9];
        byte[] buffer2 = new byte[0x13];
        num5 += 4;
        int num6 = 0;
        while (num6 < num5)
        {
            int num11 = this.method_9(3);
            if (num11 < 0)
            {
                throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲䰴夶堸嘺吼尾慀⭂いⅆ⽈♊ⱌⅎ煐げ㩔㍖㱘⡚獜", num));
            }
            buffer2[Class1112.int_0[num6++]] = (byte) num11;
        }
        Class1067 class2 = new Class1067(buffer2);
        num6 = 0;
        do
        {
            int num10;
            bool flag = false;
            while (((num10 = class2.method_3(this)) & -16) == 0)
            {
                sourceArray[num6++] = num2 = (byte) num10;
                if (num6 == num9)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                break;
            }
            if (num10 < 0)
            {
                throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲䰴夶堸嘺吼尾慀⭂いⅆ⽈♊ⱌⅎ煐げ㩔㍖㱘⡚獜", num));
            }
            if (num10 >= 0x11)
            {
                num2 = 0;
            }
            else if (num6 == 0)
            {
                throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲䰴夶堸嘺吼尾慀⭂いⅆ⽈♊ⱌⅎ煐げ㩔㍖㱘⡚獜", num));
            }
            int index = num10 - 0x10;
            int num12 = int_12[index];
            int num7 = this.method_9(num12);
            if (num7 < 0)
            {
                throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲䰴夶堸嘺吼尾慀⭂いⅆ⽈♊ⱌⅎ煐げ㩔㍖㱘⡚獜", num));
            }
            num7 += int_11[index];
            if ((num6 + num7) > num9)
            {
                throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲䰴夶堸嘺吼尾慀⭂いⅆ⽈♊ⱌⅎ煐げ㩔㍖㱘⡚獜", num));
            }
            while (num7-- > 0)
            {
                sourceArray[num6++] = num2;
            }
        }
        while (num6 != num9);
        byte[] destinationArray = new byte[length];
        Array.Copy(sourceArray, 0, destinationArray, 0, length);
        A_0 = new Class1067(destinationArray);
        destinationArray = new byte[num4];
        Array.Copy(sourceArray, length, destinationArray, 0, num4);
        A_1 = new Class1067(destinationArray);
    }

    protected bool method_16()
    {
        int num = 0;
        if (!this.bool_2)
        {
            return false;
        }
        int num2 = this.method_9(1);
        if (num2 == -1)
        {
            return false;
        }
        int num4 = this.method_9(2);
        if (num4 == -1)
        {
            return false;
        }
        this.bool_2 = num2 == 0;
        switch (num4)
        {
            case 0:
            {
                this.bool_1 = true;
                this.method_4();
                int num3 = this.method_11();
                int num6 = this.method_11();
                if (num3 != (num6 ^ 0xffff))
                {
                    throw new FormatException(BookmarkStart.b("焥娧䔩䈫䤭ု倱堳夵嬷儹᰻刽┿ⱁ⍃㉅⁇摉", num));
                }
                if (num3 > 0xffff)
                {
                    throw new FormatException(BookmarkStart.b("猥䘧䤩䌫䌭䀯䀱儳䔵䬷弹堻ḽ∿⹁⭃╅⍇橉⁋⭍㹏㕑⁓㹕硗㥙㵛そ䁟ౡୣብ䡧ࡩ५乭ᵯᵱٳ፵塷๹ᑻώꊁ늃뎅붇릉릋ꂍ", num));
                }
                this.int_19 = num3;
                this.class1067_0 = null;
                this.class1067_1 = null;
                break;
            }
            case 1:
                this.bool_1 = false;
                this.int_19 = -1;
                this.class1067_0 = Class1067.smethod_0();
                this.class1067_1 = Class1067.smethod_1();
                break;

            case 2:
                this.bool_1 = false;
                this.int_19 = -1;
                this.method_15(out this.class1067_0, out this.class1067_1);
                break;

            default:
                throw new FormatException(BookmarkStart.b("焥娧䔩䈫䤭ု倱堳夵嬷儹᰻䨽㤿㉁⅃桅", num));
        }
        return true;
    }

    private bool method_17()
    {
        int num = 1;
        int num2 = 0xffff - ((int) (this.long_2 - this.long_1));
        bool flag = false;
        while (num2 >= 0x102)
        {
            int num3;
            while (((num3 = this.class1067_0.method_3(this)) & -256) == 0)
            {
                long num10;
                this.long_2 = (num10 = this.long_2) + 1L;
                this.byte_1[(int) ((IntPtr) (num10 % 0xffffL))] = (byte) num3;
                flag = true;
                if (--num2 < 0x102)
                {
                    return true;
                }
            }
            if (num3 < 0x101)
            {
                if (num3 < 0x100)
                {
                    throw new FormatException(BookmarkStart.b("渦䔨䜪䠬䠮倰弲ᔴ吶嘸强堼ᄾ", num));
                }
                return (flag | (this.bool_3 = this.method_16()));
            }
            if (num3 > 0x11d)
            {
                throw new FormatException(BookmarkStart.b("渦䔨䜪䠬䠮倰弲ᔴ䔶尸䬺堼帾㕀捂♄⡆ⵈ⹊浌⍎㑐㵒㉔⍖ㅘ畚", num));
            }
            int num8 = int_13[num3 - 0x101];
            int num6 = int_14[num3 - 0x101];
            if (num6 > 0)
            {
                int num9 = this.method_9(num6);
                if (num9 < 0)
                {
                    throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲吴䌶堸ᔺ", num));
                }
                num8 += num9;
            }
            num3 = this.class1067_1.method_3(this);
            if ((num3 < 0) || (num3 > int_15.Length))
            {
                throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲尴䐶䴸娺匼尾⑀捂♄⡆ⵈ⹊捌", num));
            }
            int num5 = int_15[num3];
            num6 = int_16[num3];
            if (num6 > 0)
            {
                int num7 = this.method_9(num6);
                if (num7 < 0)
                {
                    throw new FormatException(BookmarkStart.b("瀦嬨䐪䌬䠮ᄰ圲吴䌶堸ᔺ", num));
                }
                num5 += num7;
            }
            for (int i = 0; i < num8; i++)
            {
                this.byte_1[(int) ((IntPtr) (this.long_2 % 0xffffL))] = this.byte_1[(int) ((IntPtr) ((this.long_2 - num5) % 0xffffL))];
                this.long_2 += 1L;
                num2--;
            }
            flag = true;
        }
        return flag;
    }

    public int method_18(byte[] A_0, int A_1, int A_2)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刯䜱刳倵崷䠹", num));
        }
        if ((A_1 < 0) || (A_1 > (A_0.Length - 1)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("弯吱刳䔵崷丹", num), BookmarkStart.b("缯吱刳䔵崷丹᰻娽⼿❁㝃晅♇╉㡋湍㉏㝑㡓㥕㙗㵙籛⩝ཟ䉡ᝣᙥ൧३ի࡭᥯᝱ၳ噵᩷ཹ᩻᡽ꪃ", num));
        }
        if ((A_2 < 0) || (A_2 > (A_0.Length - A_1)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尯圱娳儵䰷刹", num), BookmarkStart.b("簯圱娳儵䰷刹᰻圽㌿扁ⵃ⩅⑇⽉⭋⽍㱏籑", num));
        }
        int num7 = A_2;
        while (A_2 > 0)
        {
            if (this.long_1 < this.long_2)
            {
                int sourceIndex = (int) (this.long_1 % 0xffffL);
                int length = Math.Min(Math.Min(0xffff - sourceIndex, (int) (this.long_2 - this.long_1)), A_2);
                Array.Copy(this.byte_1, sourceIndex, A_0, A_1, length);
                this.long_1 += length;
                A_1 += length;
                A_2 -= length;
                continue;
            }
            if (!this.bool_3)
            {
                break;
            }
            long num9 = this.long_2;
            if (!this.bool_1)
            {
                if (!this.method_17())
                {
                    break;
                }
            }
            else if (this.int_19 == 0)
            {
                if (!(this.bool_3 = this.method_16()))
                {
                    break;
                }
            }
            else
            {
                int num2 = (int) (this.long_2 % 0xffffL);
                int num3 = Math.Min(this.int_19, 0xffff - num2);
                int num4 = this.method_5(this.byte_1, num2, num3);
                if (num3 != num4)
                {
                    throw new FormatException(BookmarkStart.b("縯崱䀳ᘵ崷吹医䬽✿⩁摃≅⥇㹉ⵋ湍㥏㱑瑓╕ⱗ⡙㥛㽝ൟ䱡", num));
                }
                this.int_19 -= num4;
                this.long_2 += num4;
            }
            if (num9 < this.long_2)
            {
                int num5 = (int) (num9 % 0xffffL);
                int num6 = (int) (this.long_2 % 0xffffL);
                if (num5 < num6)
                {
                    this.method_3(this.byte_1, num5, num6 - num5);
                    continue;
                }
                this.method_3(this.byte_1, num5, 0xffff - num5);
                if (num6 > 0)
                {
                    this.method_3(this.byte_1, 0, num6);
                }
            }
        }
        if ((!this.bool_3 && !this.bool_4) && !this.bool_0)
        {
            this.method_4();
            if (this.method_12() != this.long_0)
            {
                throw new Exception(BookmarkStart.b("猯娱儳唵匷䤹䤻匽怿⅁ⱃ⍅⭇ⅉ汋⡍ㅏ㭑㡓㍕㱗瑙", num));
            }
            this.bool_4 = true;
        }
        return (num7 - A_2);
    }

    protected void method_2()
    {
        this.long_0 = 1L;
    }

    protected void method_3(byte[] A_0, int A_1, int A_2)
    {
        Class1000.smethod_0(ref this.long_0, A_0, A_1, A_2);
    }

    protected internal void method_4()
    {
        this.uint_0 = this.uint_0 >> (this.int_17 & 7);
        this.int_17 &= -8;
    }

    protected internal int method_5(byte[] A_0, int A_1, int A_2)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("圴䈶弸崺堼䴾", num));
        }
        if ((A_1 < 0) || (A_1 > (A_0.Length - 1)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("娴儶弸䠺堼䬾", num), BookmarkStart.b("稴儶弸䠺堼䬾慀⁂⑄⥆楈╊≌㭎煐ㅒご睖㕘㹚⹜ⱞ䅠ᝢ൤٦ݨ䭪ᝬ੮Ͱᱲ啴ᡶ୸孺᩼ൾﮈꮊ歷ﶒ떔ﶚﮜ爵펠莢즤슦잨첪\ud9ac\uc7ae醰麲閴蚶鞸", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("头制圸尺䤼圾", num), BookmarkStart.b("礴制圸尺䤼圾慀⁂⑄⥆楈╊≌㭎煐ㅒご睖㕘㹚⹜ⱞ䅠ᝢ൤٦ݨ䭪ᝬ੮Ͱᱲ孴", num));
        }
        if (A_2 > (A_0.Length - A_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("头制圸尺䤼圾", num), BookmarkStart.b("礴制圸尺䤼圾慀⩂㙄杆㵈⑊≌潎㵐㉒❔ざ㱘畚", num));
        }
        if ((this.int_17 & 7) != 0)
        {
            throw new NotSupportedException(BookmarkStart.b("朴制堸强吼儾♀捂⩄ⅆ楈㹊⍌⹎㵐㽒㱔ざ㝘㹚㥜罞ՠɢᅤ٦䥨ɪṬ佮ὰᱲŴ坶੸๺ർཾꖊ", num));
        }
        if (A_2 == 0)
        {
            return 0;
        }
        int num2 = 0;
        while (this.int_17 > 0)
        {
            if (A_2 <= 0)
            {
                break;
            }
            A_0[A_1++] = (byte) this.uint_0;
            this.int_17 -= 8;
            this.uint_0 = this.uint_0 >> 8;
            A_2--;
            num2++;
        }
        if (A_2 > 0)
        {
            num2 += this.stream_0.Read(A_0, A_1, A_2);
        }
        return num2;
    }

    protected void method_6()
    {
        int count = (4 - (this.int_17 >> 3)) - (((this.int_17 & 7) != 0) ? 1 : 0);
        if (count != 0)
        {
            int num2 = this.stream_0.Read(this.byte_0, 0, count);
            for (int i = 0; i < num2; i++)
            {
                this.uint_0 |= (uint) (this.byte_0[i] << this.int_17);
                this.int_17 += 8;
            }
        }
    }

    protected internal int method_7(int A_0)
    {
        int num = 6;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("伫䄭䔯就䀳", num), BookmarkStart.b("渫䜭䐯䄱ᐳ唵圷伹刻䨽怿⅁╃⡅桇⑉⍋㩍灏けㅓ癕㑗㽙⽛ⵝ䁟ᙡౣݥ٧䩩ᙫ୭ɯᵱ婳", num));
        }
        if (A_0 > 0x20)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("伫䄭䔯就䀳", num), BookmarkStart.b("漫䄭䔯就䀳ᘵ圷尹᰻尽⤿㙁㝃晅ⅇ㥉汋㩍㽏㵑瑓㩕㥗⡙㭛㭝也", num));
        }
        if (this.int_17 < A_0)
        {
            this.method_6();
        }
        if (this.int_17 < A_0)
        {
            return -1;
        }
        uint num2 = (uint) ~(((int) (-1)) << A_0);
        return (int) (this.uint_0 & num2);
    }

    protected internal void method_8(int A_0)
    {
        int num = 0x10;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("唵圷伹刻䨽", num), BookmarkStart.b("琵儷丹伻ḽ⌿ⵁㅃ⡅㱇橉⽋⽍㹏牑㩓㥕ⱗ穙㹛㭝䁟๡ţᕥ᭧䩩ᡫ٭ᅯᱱ味౵ᵷࡹ፻偽", num));
        }
        if (A_0 != 0)
        {
            if (A_0 >= this.int_17)
            {
                A_0 -= this.int_17;
                this.int_17 = 0;
                this.uint_0 = 0;
                if (A_0 > 0)
                {
                    this.stream_0.Position += A_0 >> 3;
                    A_0 &= 7;
                    if (A_0 > 0)
                    {
                        this.method_6();
                        this.int_17 -= A_0;
                        this.uint_0 = this.uint_0 >> A_0;
                    }
                }
            }
            else
            {
                this.int_17 -= A_0;
                this.uint_0 = this.uint_0 >> A_0;
            }
        }
    }

    protected internal int method_9(int A_0)
    {
        int num = this.method_7(A_0);
        if (num == -1)
        {
            return -1;
        }
        this.int_17 -= A_0;
        this.uint_0 = this.uint_0 >> A_0;
        return num;
    }
}

