using Spire.Doc;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal class Class632 : TextReader
{
    private byte[] byte_0;
    private char[] char_0;
    private Decoder decoder_0;
    private Encoding encoding_0;
    private const int int_0 = 0x4000;
    private const int int_1 = -1;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private Stream stream_0;

    public Class632(Stream A_0, Encoding A_1)
    {
        if (A_1 == null)
        {
            A_1 = Encoding.UTF8;
        }
        if (!A_0.CanSeek)
        {
            A_0 = smethod_0(A_0);
        }
        this.stream_0 = A_0;
        this.byte_0 = new byte[0x4000];
        this.int_3 = A_0.Read(this.byte_0, 0, 4);
        this.char_0 = new char[0x4000];
        this.decoder_0 = smethod_1(this.byte_0, ref this.int_2, this.int_3);
        int count = this.int_2;
        if (this.decoder_0 == null)
        {
            this.decoder_0 = A_1.GetDecoder();
            this.int_3 += A_0.Read(this.byte_0, 4, 0x3ffc);
            this.method_1();
            Decoder decoder = this.method_10();
            if (decoder != null)
            {
                this.decoder_0 = decoder;
            }
        }
        this.stream_0.Seek(0L, SeekOrigin.Begin);
        this.int_4 = 0;
        this.int_5 = 0;
        if (count > 0)
        {
            A_0.Read(this.byte_0, 0, count);
        }
        this.int_3 = 0;
        this.int_2 = 0;
    }

    public Encoding method_0()
    {
        return this.encoding_0;
    }

    internal void method_1()
    {
        if (this.int_5 > 0)
        {
            if (this.int_5 < this.int_4)
            {
                Array.Copy(this.char_0, this.int_5, this.char_0, 0, this.int_4 - this.int_5);
            }
            this.int_4 -= this.int_5;
            this.int_5 = 0;
        }
        int num = this.decoder_0.GetCharCount(this.byte_0, this.int_2, this.int_3 - this.int_2);
        int num2 = this.char_0.Length - this.int_4;
        if (num2 < num)
        {
            char[] destinationArray = new char[this.char_0.Length + num];
            Array.Copy(this.char_0, this.int_5, destinationArray, 0, this.int_4 - this.int_5);
            this.char_0 = destinationArray;
        }
        this.int_4 = this.int_5 + this.decoder_0.GetChars(this.byte_0, this.int_2, this.int_3 - this.int_2, this.char_0, this.int_5);
        this.int_2 = this.int_3;
    }

    internal Decoder method_10()
    {
        int num = 7;
        Decoder decoder = null;
        if (!this.method_4(BookmarkStart.b("ᄬီ䤰帲头", 7)) || (this.method_7(BookmarkStart.b("嬬䨮䌰䀲尴堶圸", num)) == null))
        {
            goto Label_007E;
        }
        string name = this.method_7(BookmarkStart.b("䠬䄮到尲儴帶圸尺", num));
        if (name != null)
        {
            Decoder decoder2;
            try
            {
                Encoding encoding = Encoding.GetEncoding(name);
                if (encoding != null)
                {
                    this.encoding_0 = encoding;
                    decoder2 = encoding.GetDecoder();
                }
                else
                {
                    goto Label_006D;
                }
            }
            catch (ArgumentException)
            {
                goto Label_006D;
            }
            return decoder2;
        }
    Label_006D:
        this.method_9(BookmarkStart.b("ጬ", num));
    Label_007E:
        if (decoder == null)
        {
            return this.method_11();
        }
        return null;
    }

    internal Decoder method_11()
    {
        int num = 2;
        for (int i = this.method_2(); i != -1; i = this.method_2())
        {
            string str3;
            char ch = (char) i;
            if (ch != '<')
            {
                continue;
            }
            string str2 = this.method_12();
            if ((str2 == null) || !Class641.smethod_0(str2, BookmarkStart.b("䔧伩堫伭", num)))
            {
                continue;
            }
            string str4 = null;
            string str = null;
            goto Label_007D;
        Label_004C:
            if (Class641.smethod_0(str2, BookmarkStart.b("䀧帩堫席ᴯ圱䔳䌵儷䰹", num)))
            {
                str4 = str3;
            }
            else if (Class641.smethod_0(str2, BookmarkStart.b("䬧䔩䈫娭唯就䀳", num)))
            {
                str = str3;
            }
        Label_007D:
            str3 = this.method_8(out str2);
            if (str2 != null)
            {
                goto Label_004C;
            }
            if (((str4 != null) && Class641.smethod_0(str4, BookmarkStart.b("䬧䔩䈫娭唯就䀳ᬵ䰷䌹䰻嬽", num))) && (str != null))
            {
                int index = str.IndexOf(BookmarkStart.b("䬧䈩䴫尭䌯圱䀳", num));
                if (index >= 0)
                {
                    index = str.IndexOf(BookmarkStart.b("ᔧ", num), index);
                    if (index >= 0)
                    {
                        index++;
                        int length = str.IndexOf(BookmarkStart.b("ጧ", num), index);
                        if (length < 0)
                        {
                            length = str.Length;
                        }
                        string name = str.Substring(index, length - index).Trim();
                        try
                        {
                            Encoding encoding = Encoding.GetEncoding(name);
                            this.encoding_0 = encoding;
                            return encoding.GetDecoder();
                        }
                        catch (ArgumentException)
                        {
                        }
                    }
                }
            }
        }
        return null;
    }

    internal string method_12()
    {
        int num = this.method_3();
        if (num == -1)
        {
            return null;
        }
        char c = (char) num;
        int startIndex = this.int_5;
        while (this.int_5 < (this.int_4 - 1))
        {
            if ((!char.IsLetterOrDigit(c) && (c != '-')) && ((c != '_') && (c != ':')))
            {
                break;
            }
            c = this.char_0[++this.int_5];
        }
        if (startIndex == this.int_5)
        {
            return null;
        }
        return new string(this.char_0, startIndex, this.int_5 - startIndex);
    }

    internal void method_13()
    {
        for (char ch = (char) this.method_3(); this.int_5 < (this.int_4 - 1); ch = this.char_0[++this.int_5])
        {
            if (((ch != ' ') && (ch != '\r')) && (ch != '\n'))
            {
                break;
            }
        }
    }

    internal void method_14(char A_0)
    {
        for (char ch = (char) this.method_3(); this.int_5 < (this.int_4 - 1); ch = this.char_0[++this.int_5])
        {
            if (ch == A_0)
            {
                break;
            }
        }
    }

    internal string method_15()
    {
        this.method_14('=');
        if (this.int_5 < this.int_4)
        {
            this.int_5++;
            this.method_13();
            if (this.int_5 < this.int_4)
            {
                char ch = this.char_0[this.int_5];
                this.int_5++;
                int startIndex = this.int_5;
                this.method_14(ch);
                if (this.int_5 < this.int_4)
                {
                    string str = new string(this.char_0, startIndex, this.int_5 - startIndex);
                    this.int_5++;
                    return str;
                }
            }
        }
        return null;
    }

    public int method_16(char[] A_0, int A_1, int A_2)
    {
        int num = 0;
        for (int i = this.method_2(); i != -1; i = this.method_2())
        {
            A_0[num + A_1] = (char) i;
            num++;
            if ((num + A_1) == A_2)
            {
                return num;
            }
            switch (i)
            {
                case 13:
                    if (this.method_3() == 10)
                    {
                        i = this.method_2();
                        A_0[num + A_1] = (char) i;
                        num++;
                    }
                    return num;

                case 10:
                    return num;
            }
        }
        return num;
    }

    private int method_2()
    {
        if (this.int_5 < this.int_4)
        {
            return this.char_0[this.int_5++];
        }
        return -1;
    }

    private int method_3()
    {
        int num = this.method_2();
        if (num != -1)
        {
            this.int_5--;
        }
        return num;
    }

    private bool method_4(string A_0)
    {
        int num = this.method_3();
        if (num != A_0[0])
        {
            return false;
        }
        int num2 = 0;
        int length = A_0.Length;
        while (num != -1)
        {
            if (num2 >= length)
            {
                break;
            }
            num = this.method_2();
            char ch = A_0[num2];
            if (num != ch)
            {
                return false;
            }
            num2++;
        }
        return true;
    }

    private void method_5()
    {
        char ch = (char) this.method_3();
    Label_0047:
        switch (ch)
        {
            case '\t':
            case '\r':
            case '\n':
            case ' ':
            {
                int num = this.int_5;
                ch = (char) this.method_2();
                if (((ch != ' ') && (ch != '\t')) && ((ch != '\r') && (ch != '\n')))
                {
                    this.int_5 = num;
                }
                goto Label_0047;
            }
        }
    }

    private string method_6()
    {
        int num = this.method_3();
        if ((num != 0x27) && (num != 0x22))
        {
            return null;
        }
        this.method_2();
        int startIndex = this.int_5;
        for (int i = this.method_2(); i != -1; i = this.method_2())
        {
            if (i == num)
            {
                break;
            }
        }
        if (this.int_5 <= startIndex)
        {
            return "";
        }
        return new string(this.char_0, startIndex, (this.int_5 - startIndex) - 1);
    }

    private string method_7(string A_0)
    {
        int num = 14;
        this.method_5();
        string b = this.method_12();
        if (string.Equals(A_0, b, StringComparison.OrdinalIgnoreCase))
        {
            this.method_5();
            if (this.method_4(BookmarkStart.b("ळ", num)))
            {
                this.method_5();
                return this.method_6();
            }
        }
        return null;
    }

    private string method_8(out string A_0)
    {
        int num = 3;
        this.method_5();
        A_0 = this.method_12();
        if (A_0 != null)
        {
            this.method_5();
            if (this.method_4(BookmarkStart.b("ᐨ", num)))
            {
                this.method_5();
                return this.method_6();
            }
        }
        return null;
    }

    private void method_9(string A_0)
    {
        int num = this.method_2();
        int num2 = 0;
        int length = A_0.Length;
        while (num2 < length)
        {
            if (num == -1)
            {
                break;
            }
            if (A_0[num2] == num)
            {
                num2++;
                if (num2 == length)
                {
                    return;
                }
            }
            else
            {
                num2 = 0;
            }
            num = this.method_2();
        }
    }

    private static Stream smethod_0(Stream A_0)
    {
        int num2;
        int count = 0x186a0;
        byte[] buffer = new byte[0x186a0];
        MemoryStream stream = new MemoryStream();
        while ((num2 = A_0.Read(buffer, 0, count)) > 0)
        {
            stream.Write(buffer, 0, num2);
        }
        stream.Seek(0L, SeekOrigin.Begin);
        A_0.Close();
        return stream;
    }

    internal static Decoder smethod_1(byte[] A_0, ref int A_1, int A_2)
    {
        if (4 > (A_2 - A_1))
        {
            goto Label_00E6;
        }
        uint num = (uint) ((((A_0[A_1] << 0x18) | (A_0[A_1 + 1] << 0x10)) | (A_0[A_1 + 2] << 8)) | A_0[A_1 + 3]);
        switch (num)
        {
            case 60:
            case 0xfffefffe:
                A_1 += 4;
                return new Class635();

            case 0x3c000000:
            case 0xfefffeff:
                A_1 += 4;
                return new Class634();

            default:
            {
                num = num >> 8;
                if (num == 0xefbbbf)
                {
                    A_1 += 3;
                    return Encoding.UTF8.GetDecoder();
                }
                num = num >> 8;
                uint num3 = num;
                if (num3 <= 0x3c00)
                {
                    switch (num3)
                    {
                        case 0x3c00:
                            goto Label_00BD;
                    }
                    goto Label_00E6;
                }
                if (num3 == 0xfeff)
                {
                    goto Label_00BD;
                }
                if (num3 != 0xfffe)
                {
                    goto Label_00E6;
                }
                break;
            }
        }
        A_1 += 2;
        return new UnicodeEncoding(false, false).GetDecoder();
    Label_00BD:
        A_1 += 2;
        return Encoding.BigEndianUnicode.GetDecoder();
    Label_00E6:
        return null;
    }

    void TextReader.Close()
    {
        this.stream_0.Close();
    }

    int TextReader.Peek()
    {
        int num = this.Read();
        if (num != -1)
        {
            this.int_5--;
        }
        return num;
    }

    int TextReader.Read()
    {
        if (this.int_5 == this.int_4)
        {
            this.int_3 = this.stream_0.Read(this.byte_0, 0, this.byte_0.Length);
            this.int_2 = 0;
            if (this.int_3 == 0)
            {
                return -1;
            }
            this.method_1();
        }
        if (this.int_5 < this.int_4)
        {
            return this.char_0[this.int_5++];
        }
        return -1;
    }

    int TextReader.Read(char[] A_0, int A_1, int A_2)
    {
        if (this.int_5 == this.int_4)
        {
            this.int_3 = this.stream_0.Read(this.byte_0, 0, this.byte_0.Length);
            this.int_2 = 0;
            if (this.int_3 == 0)
            {
                return -1;
            }
            this.method_1();
        }
        if (this.int_5 < this.int_4)
        {
            A_2 = Math.Min(this.int_4 - this.int_5, A_2);
            Array.Copy(this.char_0, this.int_5, A_0, A_1, A_2);
            this.int_5 += A_2;
            return A_2;
        }
        return 0;
    }

    int TextReader.ReadBlock(char[] A_0, int A_1, int A_2)
    {
        return this.Read(A_0, A_1, A_2);
    }

    string TextReader.ReadToEnd()
    {
        char[] buffer = new char[0x186a0];
        int charCount = 0;
        StringBuilder builder = new StringBuilder();
        while ((charCount = this.Read(buffer, 0, buffer.Length)) > 0)
        {
            builder.Append(buffer, 0, charCount);
        }
        return builder.ToString();
    }
}

