using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;
using System.Text;

internal class Class763
{
    private BinaryReader binaryReader_0;
    private BinaryReader binaryReader_1;
    private BinaryReader binaryReader_2;
    private BinaryReader binaryReader_3;
    internal static bool bool_0;
    private Class1065 class1065_0;
    private Class1132 class1132_0;
    private Class158 class158_0;
    private Class159 class159_0;
    private Class160 class160_0;
    private Class165 class165_0;
    private Class168 class168_0;
    private Class348 class348_0;
    private Class348 class348_1;
    private Class349 class349_0;
    private Class598 class598_0;
    private Class700 class700_0;
    private Class700 class700_1;
    private Class703 class703_0;
    private Class770 class770_0;
    private Class986 class986_0;
    private Class996 class996_0;

    internal Class763(string A_0)
    {
        using (Stream stream = File.OpenRead(A_0))
        {
            this.method_20(new Class1132(stream), null);
        }
    }

    internal Class763(Class1132 A_0, string A_1)
    {
        this.method_20(A_0, A_1);
    }

    internal Class1132 method_0()
    {
        return this.class1132_0;
    }

    internal BinaryReader method_1()
    {
        return this.binaryReader_0;
    }

    internal Class700 method_10()
    {
        return this.class700_0;
    }

    internal Class700 method_11()
    {
        return this.class700_1;
    }

    internal Class1065 method_12()
    {
        return this.class1065_0;
    }

    internal Class160 method_13()
    {
        return this.class160_0;
    }

    internal Class159 method_14()
    {
        return this.class159_0;
    }

    internal Class158 method_15()
    {
        return this.class158_0;
    }

    internal Class168 method_16()
    {
        return this.class168_0;
    }

    internal Class349 method_17()
    {
        return this.class349_0;
    }

    internal Class986 method_18()
    {
        return this.class986_0;
    }

    internal Class348 method_19(SubDocumentType A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case SubDocumentType.Main:
                return this.class348_0;

            case SubDocumentType.Header:
                return this.class348_1;
        }
        throw new InvalidOperationException(BookmarkStart.b("紧䐩䤫嘭䀯圱圳䈵崷帹᰻䴽㔿⁁⁃⥅⭇㽉⅋⭍㹏♑穓", num));
    }

    internal BinaryReader method_2()
    {
        return this.binaryReader_1;
    }

    private void method_20(Class1132 A_0, string A_1)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䤮䈰", num));
        }
        this.class1132_0 = A_0;
        BinaryReader reader = new BinaryReader(this.class1132_0.method_0().method_5(BookmarkStart.b("砮帰䄲儴猶嘸堺䠼刾⑀ⵂㅄ", num)), Class813.smethod_0(true));
        this.class703_0 = new Class703(reader);
        if (this.class703_0.method_1())
        {
            throw new NotSupportedException(BookmarkStart.b("笮夰娲䘴᜶崸吺帼䨾ⱀ♂⭄㍆楈≊㹌潎㽐㱒⅔睖⩘⹚ⵜ⽞๠ᅢᅤɦ൨䕪", num));
        }
        if (this.class703_0.bool_4)
        {
            if (A_1 == null)
            {
                throw new PasswordErrorException(BookmarkStart.b("欮帰倲䀴娶尸唺䤼Ἶ⡀あ敄≆❈⡊㽌㙎⅐❒ご㍖畘筚ቜ⽞Ѡൢ䕤፦Ũ๪䵬Ὦၰrٴvᙸॺ᥼彾愈ꮊﶌﾚ뎜", num));
            }
            new Class987().method_1(this.class1132_0, this.class703_0, A_1);
        }
        Stream input = this.class1132_0.method_0().method_5(BookmarkStart.b("砮帰䄲儴猶嘸堺䠼刾⑀ⵂㅄ", num));
        this.binaryReader_0 = new BinaryReader(input, Class813.smethod_0(true));
        this.binaryReader_1 = new BinaryReader(input, Class813.smethod_0(false));
        this.class703_0.method_3(this.binaryReader_0);
        Stream stream2 = this.class1132_0.method_0().method_5(this.class703_0.method_0());
        this.binaryReader_2 = new BinaryReader(stream2, Encoding.Unicode);
        Stream stream3 = this.class1132_0.method_0().method_4(BookmarkStart.b("欮倰䜲吴", num));
        this.binaryReader_3 = (stream3 != null) ? new BinaryReader(stream3, Encoding.Unicode) : null;
        this.class770_0 = new Class770(this.method_5(), this.method_3());
        this.class160_0 = new Class160(this.method_5(), this.method_1(), this.method_3());
        this.method_26();
        this.method_27();
        this.class598_0 = new Class598(this.method_5(), this.method_3());
        this.class165_0 = new Class165(this.method_5(), this.method_3(), this.class160_0.method_4());
        this.class348_0 = new Class348(SubDocumentType.Main, this.method_5(), this.method_3());
        this.class348_1 = new Class348(SubDocumentType.Header, this.method_5(), this.method_3());
        this.class996_0 = new Class996(this.method_5(), this.method_3());
        this.class700_0 = new Class700(FootnoteType.Footnote, this.method_5(), this.method_3());
        this.class700_1 = new Class700(FootnoteType.Endnote, this.method_5(), this.method_3());
        this.class1065_0 = new Class1065(this.method_5(), this.method_3());
        this.class168_0 = new Class168(this.method_5(), this.method_3());
        this.class349_0 = new Class349(this.method_5(), this.method_3());
        this.class986_0 = new Class986(this.method_5(), this.method_3());
        this.method_21();
    }

    private void method_21()
    {
        if (this.class348_0.method_0().method_4() > 0)
        {
            for (int i = 0; i < (this.class348_0.method_0().class741_0.method_2() - 1); i++)
            {
                int num2 = this.class348_0.method_0().class741_0.method_7(i);
                long num3 = this.method_23(num2, this.class770_0.method_4(0).int_0, 1) - 2L;
                if ((this.method_22(num3) != '\b') && (this.method_22(num3 - 2L) == '\b'))
                {
                    Class347 class2 = this.class348_0.method_4(num2);
                    this.class348_0.method_0().method_9(i);
                    this.class348_0.method_0().method_7(i, num2 - 1, class2);
                }
            }
        }
    }

    internal char method_22(long A_0)
    {
        if ((A_0 <= this.class160_0.binaryReader_0.BaseStream.Length) && (A_0 >= 0L))
        {
            long position = this.class160_0.binaryReader_0.BaseStream.Position;
            this.class160_0.binaryReader_0.BaseStream.Position = A_0;
            byte[] buffer = new byte[2];
            this.class160_0.binaryReader_0.BaseStream.Read(buffer, 0, 2);
            string str = string.Empty;
            str = Class813.smethod_0(true).GetString(buffer);
            char ch = (str.Length == 1) ? str[0] : '\0';
            this.class160_0.binaryReader_0.BaseStream.Position = position;
            return ch;
        }
        return '\0';
    }

    internal long method_23(int A_0, int A_1, int A_2)
    {
        uint num = this.method_24((uint) A_1);
        uint num2 = (uint) ((A_0 + num) + A_2);
        return this.method_25(num2);
    }

    internal uint method_24(uint A_0)
    {
        bool flag = false;
        uint num = 0;
        uint num3 = (Class813.smethod_0(true) == Encoding.Unicode) ? 2 : 1;
        uint num5 = (uint) ((this.class770_0.method_4(0).method_0().method_4() * num3) + this.class770_0.method_4(0).int_0);
        uint num2 = (uint) this.class770_0.method_4(0).int_0;
        if ((A_0 < num2) || (A_0 > num5))
        {
            return num;
        }
        if (A_0 == num5)
        {
            flag = true;
            num2 = num5;
        }
        uint num4 = (A_0 - num2) / num3;
        return (flag ? ((uint) this.class770_0.method_4(0).method_0().method_4()) : (((uint) this.class770_0.method_4(0).method_0().method_2()) + num4));
    }

    internal long method_25(uint A_0)
    {
        bool flag = false;
        uint num = 0;
        uint num2 = (Class813.smethod_0(true) == Encoding.Unicode) ? 2 : 1;
        uint num3 = (uint) ((this.class770_0.method_4(0).method_0().method_4() * num2) + this.class770_0.method_4(0).int_0);
        uint num4 = (uint) this.class770_0.method_4(0).int_0;
        if ((A_0 >= num4) && (A_0 <= num3))
        {
            if (A_0 == num3)
            {
                flag = true;
                num4 = num3;
            }
            uint num5 = A_0 - (flag ? ((uint) this.class770_0.method_4(0).method_0().method_4()) : ((uint) this.class770_0.method_4(0).method_0().method_2()));
            num = (num5 * num2) + num4;
        }
        return (long) num;
    }

    private void method_26()
    {
        this.class159_0 = new Class159();
        Class163 class2 = new Class163();
        class2.method_23(this.method_3(), this.class703_0.class597_0.class1111_13);
        for (int i = 0; i < class2.method_4(); i++)
        {
            this.method_1().BaseStream.Seek((long) class2.method_25(i), SeekOrigin.Begin);
            new Class485(this.method_1()).method_3(this.class159_0);
        }
    }

    private void method_27()
    {
        this.class158_0 = new Class158();
        Class163 class2 = new Class163();
        class2.method_23(this.method_3(), this.class703_0.class597_0.class1111_12);
        for (int i = 0; i < class2.method_4(); i++)
        {
            this.method_1().BaseStream.Seek((long) class2.method_25(i), SeekOrigin.Begin);
            new Class484(this.method_1()).method_3(this.class158_0);
        }
    }

    internal BinaryReader method_3()
    {
        return this.binaryReader_2;
    }

    internal BinaryReader method_4()
    {
        return this.binaryReader_3;
    }

    internal Class703 method_5()
    {
        return this.class703_0;
    }

    internal Class770 method_6()
    {
        return this.class770_0;
    }

    internal Class598 method_7()
    {
        return this.class598_0;
    }

    internal Class165 method_8()
    {
        return this.class165_0;
    }

    internal Class996 method_9()
    {
        return this.class996_0;
    }
}

