using System;
using System.IO;
using System.Text;

internal class Class555
{
    internal int int_0;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal string string_0;
    internal string string_1;
    internal string string_2;

    internal Class555(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadUInt16();
        if (this.int_1 == 2)
        {
            this.string_0 = smethod_0(A_0);
            this.string_1 = smethod_0(A_0);
            A_0.ReadUInt16();
            this.int_2 = A_0.ReadUInt16();
            switch (this.int_2)
            {
                case 1:
                    A_0.ReadUInt16();
                    this.string_2 = smethod_0(A_0);
                    A_0.ReadUInt16();
                    return;

                case 2:
                    return;

                case 3:
                    A_0.ReadInt32();
                    this.string_2 = smethod_0(A_0);
                    this.int_3 = A_0.ReadInt32();
                    return;
            }
        }
    }

    private static string smethod_0(BinaryReader A_0)
    {
        char ch;
        StringBuilder builder = new StringBuilder();
    Label_0010:
        ch = A_0.ReadChar();
        if (ch != '\0')
        {
            builder.Append(ch);
            goto Label_0010;
        }
        return builder.ToString();
    }
}

