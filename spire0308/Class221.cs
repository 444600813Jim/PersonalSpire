using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class221 : Interface24
{
    private readonly string string_0;

    internal Class221(Class1089 A_0)
    {
        MemoryStream input = A_0.method_4(BookmarkStart.b("㜳礵笷戹爻缽ി݁", 14));
        if (input != null)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Unicode);
            StringBuilder builder = new StringBuilder();
            while (Class567.smethod_46(reader, 2))
            {
                char ch = reader.ReadChar();
                if (ch == '\0')
                {
                    break;
                }
                builder.Append(ch);
            }
            this.string_0 = builder.ToString();
        }
    }

    internal Class221(string A_0)
    {
        this.string_0 = A_0;
    }

    private void imethod_0(BinaryWriter A_0)
    {
        if (Class567.smethod_16(this.string_0))
        {
            for (int i = 0; i < this.string_0.Length; i++)
            {
                char ch = this.string_0[i];
                A_0.Write((byte) ch);
                A_0.Write((byte) 0);
            }
        }
        A_0.Write(0);
    }

    string Interface24.imethod_1()
    {
        return BookmarkStart.b("㨸琺縼朾ཀɂࡄɆ", 0x13);
    }

    internal string method_0()
    {
        return this.string_0;
    }
}

