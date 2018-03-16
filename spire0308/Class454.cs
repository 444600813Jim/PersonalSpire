using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class454 : Class453
{
    private Class1089 class1089_0;

    internal Class454(Class1089 A_0) : this(0, A_0)
    {
    }

    internal Class454(int A_0, Class1089 A_1)
    {
        this.class1089_0 = A_1;
        base.method_1(A_0);
    }

    internal MemoryStream method_10()
    {
        return (MemoryStream) this.class1089_0[BookmarkStart.b("㜵笷唹儻丽༿⁁⹃", 0x10)];
    }

    internal bool method_11()
    {
        return (this.method_9() != null);
    }

    internal Class1089 method_12()
    {
        return this.class1089_0;
    }

    internal void method_13(Class1089 A_0)
    {
        this.class1089_0 = A_0;
    }

    internal string method_3()
    {
        BinaryReader reader = this.method_5();
        if (reader != null)
        {
            Class555 class2 = new Class555(reader);
            if (class2.int_1 == 2)
            {
                return class2.string_0;
            }
        }
        return "";
    }

    private void method_4(Stream A_0)
    {
        BinaryReader reader = this.method_5();
        if (reader != null)
        {
            Class555 class2 = new Class555(reader);
            if (class2.int_1 == 2)
            {
                switch (class2.int_2)
                {
                    case 1:
                    case 2:
                        return;

                    case 3:
                    {
                        byte[] buffer = new byte[class2.int_3];
                        reader.Read(buffer, 0, buffer.Length);
                        A_0.Write(buffer, 0, buffer.Length);
                        return;
                    }
                }
            }
            else
            {
                this.method_9().Position = 4L;
                Class567.smethod_8(this.method_9(), A_0);
            }
        }
    }

    private BinaryReader method_5()
    {
        if (this.method_9().Length == 0L)
        {
            return null;
        }
        this.method_9().Position = 0L;
        return new BinaryReader(this.method_9(), Encoding.ASCII);
    }

    private void method_6(Stream A_0, string A_1)
    {
        int num = 7;
        MemoryStream stream = null;
        Class1089 class2 = null;
        if (A_1.StartsWith(BookmarkStart.b("栬圮到嘲头ᤶ樸区堼娾㕀浂組", 7)))
        {
            Stream stream2 = this.class1089_0[BookmarkStart.b("稬䀮䌰堲圴堶嘸债", num)] as MemoryStream;
            Class627.smethod_9(stream2);
        }
        else if (A_1.StartsWith(BookmarkStart.b("栬圮到嘲头ᤶ樸区堼娾㕀浂瑄畆", num)))
        {
            stream = new MemoryStream();
            Class627.smethod_8(this.class1089_0[BookmarkStart.b("紬丮到堲吴倶尸", num)] as MemoryStream, stream);
        }
        else if (!A_1.StartsWith(BookmarkStart.b("稬䀮䌰圲᬴猶嘸堺䠼刾⑀ⵂㅄ楆硈祊", num)) && !A_1.StartsWith(BookmarkStart.b("紬䀮䘰嘲䜴朶嘸刺匼䬾潀၂ⵄ⡆㹈敊籌絎", num)))
        {
            if ((!A_1.StartsWith(BookmarkStart.b("栬圮到嘲头ᤶ瘸䬺堼儾Հⱂ♄㉆⑈⹊⍌㭎ɐ⍒❔㉖㡘㽚⹜㝞Ѡ٢ᅤ", num)) && !A_1.StartsWith(BookmarkStart.b("稬䀮䌰圲᬴砶䤸帺匼笾⹀⁂い⩆ⱈ╊㥌᭎㑐⭒⅔", num))) && !A_1.StartsWith(BookmarkStart.b("紬䀮䘰嘲䜴朶嘸刺匼䬾潀ూ㕄≆❈ཊ≌ⱎ⑐㹒ご㥖ⵘ୚⽜㩞በ٢୤፦ࡨὪѬnὰ", num)))
            {
                if (A_1.StartsWith(BookmarkStart.b("戬娮䔰弲娴堶券ᔺ笼嘾ⵀ♂ф㍆㵈⩊⹌❎", num)))
                {
                    stream = this.class1089_0[BookmarkStart.b("氬嬮䔰刲嘴弶稸吺匼䬾⑀ⵂㅄ㑆", num)] as MemoryStream;
                }
                else if (A_1.StartsWith(BookmarkStart.b("氬䰮䌰尲瀴伶娸区ጼ笾⹀⁂い⩆ⱈ╊㥌", num)))
                {
                    stream = this.class1089_0[BookmarkStart.b("測怮缰朲瀴礶洸栺", num)] as MemoryStream;
                }
                else if (A_1.StartsWith(BookmarkStart.b("怬丮堰弲破䐶常稺䤼䬾", num)) || A_1.StartsWith(BookmarkStart.b("戬娮䔰弲娴堶券ᔺ瀼䰾♀ɂㅄ㍆⡈⡊╌", num)))
                {
                    class2 = this.class1089_0[BookmarkStart.b("怬渮愰稲破制䨸䠺尼堾⑀", num)] as Class1089;
                }
            }
            else
            {
                stream = this.class1089_0[BookmarkStart.b("栬䈮匰嘲儴匶尸强爼嬾❀", num)] as MemoryStream;
            }
        }
        else
        {
            stream = this.class1089_0[BookmarkStart.b("紬丮到堲吴倶尸", num)] as MemoryStream;
        }
        if (stream != null)
        {
            stream.Position = 0L;
            Class567.smethod_8(stream, A_0);
        }
        else
        {
            smethod_0(A_0, (class2 != null) ? class2 : this.class1089_0);
        }
    }

    internal MemoryStream method_7()
    {
        return (MemoryStream) this.class1089_0[BookmarkStart.b("⸬戮琰朲琴", 7)];
    }

    internal MemoryStream method_8()
    {
        return (MemoryStream) this.class1089_0[BookmarkStart.b("⠪紬昮爰", 5)];
    }

    internal MemoryStream method_9()
    {
        return (MemoryStream) this.class1089_0[BookmarkStart.b("Ⱜ怮崰嘲дܶ眸娺䤼嘾㝀♂", 7)];
    }

    private static void smethod_0(Stream A_0, Class1089 A_1)
    {
        new Class1132(A_1).method_5(A_0);
    }

    internal override string vmethod_0(string A_0)
    {
        int num = 12;
        if (A_0.StartsWith(BookmarkStart.b("眱䰳唵崷嘹ሻ洽⠿❁⅃㉅晇牉", 12)))
        {
            return BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㱉≋⩍繏㽑❓筕㵗≙㽛㭝౟", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("攱嬳䐵尷ᐹ砻儽⌿㝁⥃⍅♇㹉手癍", num)))
        {
            return BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇❉㽋㥍㽏⁑こ", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("戱嬳䄵崷䠹氻儽⤿ⱁぃ桅ᭇ≉⍋㥍繏橑", num)))
        {
            return BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㱉≋⩍繏㽑❓筕⡗㕙⭛㭝቟ቡୣཥ٧ṩ", num);
        }
        return BookmarkStart.b("匱䐳䘵吷匹弻弽㐿⭁⭃⡅杇㱉≋⩍繏㵑⑓㍕㙗≙ㅛ㉝ٟൡᙣ୥१ṩὫ䍭Ὧᑱታή᭷ό᡻ᅽﺉꊋﲏ\udb93\uf495ﾙﾛ", num);
    }

    internal override string vmethod_1(string A_0)
    {
        int num = 0x13;
        string str = Class680.smethod_0(this.vmethod_0(A_0));
        if (str != BookmarkStart.b("᜸夺吼儾", 0x13))
        {
            return str;
        }
        if (A_0.StartsWith(BookmarkStart.b("簸䌺帼娾ⵀ浂ᙄ⽆ⱈ⹊㥌慎恐慒", num)))
        {
            return BookmarkStart.b("᜸䌺儼䰾㥀", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("游吺似嬾潀݂⩄⑆㱈♊⡌ⅎ═絒摔敖", num)))
        {
            return BookmarkStart.b("᜸强刼尾㥀", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("椸吺䨼娾㍀ፂ⩄⹆❈㽊捌ᱎ㥐㱒≔祖桘楚", num)))
        {
            return BookmarkStart.b("᜸䬺䴼䬾㥀", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("椸吺䨼娾㍀ፂ⩄⹆❈㽊捌ᱎ㵐㩒ㅔ㉖睘橚潜", num)))
        {
            return BookmarkStart.b("᜸䠺儼嬾㥀", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("簸䌺帼娾ⵀ浂੄㝆ⱈ╊ौ⁎㉐♒㡔㉖㝘⽚๜⽞፠٢Ѥͦᩨͪ࡬੮հ", num)))
        {
            return BookmarkStart.b("᜸吺夼䰾", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("游吺似嬾潀ూ㕄≆❈ཊ≌ⱎ⑐㹒ご㥖ⵘཚ㡜❞ᕠ", num)))
        {
            return BookmarkStart.b("᜸吺夼䬾", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("椸吺䨼娾㍀ፂ⩄⹆❈㽊捌N⅐㙒㭔ፖ㙘㡚⡜㉞Ѡൢᅤ㝦᭨๪Ṭ੮ὰݲᑴͶၸᑺ፼", num)))
        {
            return BookmarkStart.b("᜸吺夼伾", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("砸堺似倾р㭂♄⽆杈ཊ≌ⱎ⑐㹒ご㥖ⵘ", num)))
        {
            return BookmarkStart.b("᜸䬺夼夾", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("琸娺吼匾ీあ≄ن㵈㽊", num)) || A_0.StartsWith(BookmarkStart.b("瘸为䤼匾⹀ⱂ⹄楆ш㡊⩌๎═❒㑔㑖ㅘ", num)))
        {
            return BookmarkStart.b("᜸嘺丼堾", num);
        }
        if (this.method_11())
        {
            return Path.GetExtension(this.method_3()).ToLower();
        }
        return BookmarkStart.b("᜸夺吼儾", num);
    }

    internal override void vmethod_2(Stream A_0, string A_1)
    {
        if (this.method_11())
        {
            this.method_4(A_0);
        }
        else
        {
            this.method_6(A_0, A_1);
        }
    }
}

