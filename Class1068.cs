using Spire.Compression;
using Spire.Compression.Zip;
using Spire.Doc;
using System;

internal sealed class Class1068
{
    public byte[] byte_0;
    public byte[] byte_1;
    internal Class609 class609_0;
    internal Class935 class935_0;
    public CompressionLevel compressionLevel_0;
    public CompressionStrategy compressionStrategy_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public long long_0;
    public long long_1;
    internal long long_2;
    public string string_0;

    public Class1068()
    {
        this.compressionLevel_0 = CompressionLevel.Normal;
        this.int_4 = 15;
    }

    public Class1068(CompressionMode A_0)
    {
        int num3 = 4;
        this.compressionLevel_0 = CompressionLevel.Normal;
        this.int_4 = 15;
        if (A_0 == CompressionMode.Compress)
        {
            if (this.method_8() != 0)
            {
                throw new Exception0(BookmarkStart.b("椩䴫䀭帯崱䀳ᘵ儷吹唻䨽⤿⍁⡃⽅㉇⽉汋⡍㽏⁑瑓㉕㵗㱙せ㽝ᑟݡ䩣", num3));
            }
        }
        else
        {
            if (A_0 != CompressionMode.Decompress)
            {
                throw new Exception0(BookmarkStart.b("挩䈫堭儯帱崳刵ᠷ怹倻圽∿ᅁぃ㑅ⵇ⭉⅋ࡍ㱏㍑≓㥕⩗瑙", num3));
            }
            if (this.method_1() != 0)
            {
                throw new Exception0(BookmarkStart.b("椩䴫䀭帯崱䀳ᘵ儷吹唻䨽⤿⍁⡃⽅㉇⽉汋⡍㽏⁑瑓㽕㙗㱙せ㽝ᑟݡ䩣", num3));
            }
        }
    }

    public long method_0()
    {
        return this.long_2;
    }

    public int method_1()
    {
        return this.method_3(this.int_4);
    }

    public int method_10(CompressionLevel A_0, bool A_1)
    {
        this.compressionLevel_0 = A_0;
        return this.method_13(A_1);
    }

    public int method_11(CompressionLevel A_0, int A_1)
    {
        this.compressionLevel_0 = A_0;
        this.int_4 = A_1;
        return this.method_13(true);
    }

    public int method_12(CompressionLevel A_0, int A_1, bool A_2)
    {
        this.compressionLevel_0 = A_0;
        this.int_4 = A_1;
        return this.method_13(A_2);
    }

    private int method_13(bool A_0)
    {
        int num = 8;
        if (this.class609_0 != null)
        {
            throw new Exception0(BookmarkStart.b("眭弯䜱ᐳ嬵夷䌹᰻倽⼿㙁摃╅⥇♉⁋湍᥏㱑㵓≕ㅗ㭙せ㝝᩟ݡ⁣ͥ๧٩൫ᩭᕯ婱嵳噵᥷ᱹࡻ᭽ꊁ늑\udd93\uf895ﾝ첟쮡\udea3\uc3a5쒩쪫슭톯욱톳麵醷钹", num));
        }
        this.class935_0 = new Class935();
        this.class935_0.method_1(A_0);
        return this.class935_0.method_33(this, this.compressionLevel_0, this.int_4, this.compressionStrategy_0);
    }

    public int method_14(FlushType A_0)
    {
        int num = 5;
        if (this.class935_0 == null)
        {
            throw new Exception0(BookmarkStart.b("攪䈬༮田嘲匴嬶堸伺堼Ἶቀ㝂⑄㍆ⱈ橊", num));
        }
        return this.class935_0.method_39(A_0);
    }

    public int method_15()
    {
        int num2 = 14;
        if (this.class935_0 == null)
        {
            throw new Exception0(BookmarkStart.b("稳夵ᠷ縹夻堽ⰿ⍁ぃ⍅桇᥉㡋⽍⑏㝑畓", num2));
        }
        int num = this.class935_0.method_36();
        this.class935_0 = null;
        return num;
    }

    public void method_16()
    {
        int num = 8;
        if (this.class935_0 == null)
        {
            throw new Exception0(BookmarkStart.b("怭弯ሱ瀳匵帷嘹崻䨽┿扁ᝃ㉅⥇㹉⥋潍", num));
        }
        this.class935_0.method_35();
    }

    public int method_17(CompressionLevel A_0, CompressionStrategy A_1)
    {
        int num = 14;
        if (this.class935_0 == null)
        {
            throw new Exception0(BookmarkStart.b("稳夵ᠷ縹夻堽ⰿ⍁ぃ⍅桇᥉㡋⽍⑏㝑畓", num));
        }
        return this.class935_0.method_37(A_0, A_1);
    }

    public int method_18(byte[] A_0)
    {
        int num = 0x11;
        if (this.class609_0 != null)
        {
            return this.class609_0.method_6(A_0);
        }
        if (this.class935_0 == null)
        {
            throw new Exception0(BookmarkStart.b("礶嘸ᬺ琼儾❀⽂⑄㍆ⱈ歊≌㵎煐ᝒごㅖ㕘㩚⥜㩞䅠ၢᅤ٦ᵨ๪䱬", num));
        }
        return this.class935_0.method_38(A_0);
    }

    internal void method_19()
    {
        int num = 11;
        int length = this.class935_0.int_51;
        if (length > this.int_3)
        {
            length = this.int_3;
        }
        if (length != 0)
        {
            if (((this.class935_0.byte_0.Length <= this.class935_0.int_49) || (this.byte_1.Length <= this.int_2)) || ((this.class935_0.byte_0.Length < (this.class935_0.int_49 + length)) || (this.byte_1.Length < (this.int_2 + length))))
            {
                throw new Exception0(string.Format(BookmarkStart.b("砰崲䌴嘶唸刺夼Ἶቀ㝂⑄㍆ⱈ敊浌李⅐㙒㭔㍖じ㕚㩜煞ⵠ٢୤fᵨͪ偬ᑮ䅰๲奴坶ॸṺ፼᭾쒆ﺊﮎ겐꒔나", num), this.class935_0.byte_0.Length, this.class935_0.int_51));
            }
            Array.Copy(this.class935_0.byte_0, this.class935_0.int_49, this.byte_1, this.int_2, length);
            this.int_2 += length;
            this.class935_0.int_49 += length;
            this.long_1 += length;
            this.int_3 -= length;
            this.class935_0.int_51 -= length;
            if (this.class935_0.int_51 == 0)
            {
                this.class935_0.int_49 = 0;
            }
        }
    }

    public int method_2(bool A_0)
    {
        return this.method_4(this.int_4, A_0);
    }

    internal int method_20(byte[] A_0, int A_1, int A_2)
    {
        int num = this.int_1;
        if (num > A_2)
        {
            num = A_2;
        }
        if (num == 0)
        {
            return 0;
        }
        this.int_1 -= num;
        if (this.class935_0.method_0())
        {
            this.long_2 = Class603.smethod_0(this.long_2, this.byte_0, this.int_0, num);
        }
        Array.Copy(this.byte_0, this.int_0, A_0, A_1, num);
        this.int_0 += num;
        this.long_0 += num;
        return num;
    }

    public int method_3(int A_0)
    {
        this.int_4 = A_0;
        return this.method_4(A_0, true);
    }

    public int method_4(int A_0, bool A_1)
    {
        int num = 4;
        this.int_4 = A_0;
        if (this.class935_0 != null)
        {
            throw new Exception0(BookmarkStart.b("猩䌫嬭ု弱唳伵ᠷ吹医䨽怿⅁╃⩅⑇橉Ջ⁍㥏♑㵓㝕㑗㍙♛㭝⥟ౡɣ੥१ṩ५䙭奯剱ᕳၵ౷ό๻幽꺍\ud98f\ufc91ﶓﮙ\uda9f\uc7a1쎥캧용춫\udaad\ud5af骱鶳颵", num));
        }
        this.class609_0 = new Class609(A_1);
        return this.class609_0.method_4(this, A_0);
    }

    public int method_5(FlushType A_0)
    {
        int num = 15;
        if (this.class609_0 == null)
        {
            throw new Exception0(BookmarkStart.b("笴堶ᤸ爺匼夾ⵀ≂ㅄ≆楈ᡊ㥌⹎═㙒瑔", num));
        }
        return this.class609_0.method_5(A_0);
    }

    public int method_6()
    {
        int num2 = 12;
        if (this.class609_0 == null)
        {
            throw new Exception0(BookmarkStart.b("簱嬳ᘵ焷吹娻刽ℿ㙁⅃晅ᭇ㹉ⵋ㩍㕏獑", num2));
        }
        int num = this.class609_0.method_3();
        this.class609_0 = null;
        return num;
    }

    public int method_7()
    {
        int num = 11;
        if (this.class609_0 == null)
        {
            throw new Exception0(BookmarkStart.b("缰尲ᔴ縶圸崺儼帾㕀♂敄ᑆ㵈⩊㥌⩎灐", num));
        }
        return this.class609_0.method_7();
    }

    public int method_8()
    {
        return this.method_13(true);
    }

    public int method_9(CompressionLevel A_0)
    {
        this.compressionLevel_0 = A_0;
        return this.method_13(true);
    }
}

