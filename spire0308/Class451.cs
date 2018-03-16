using Spire.Doc.Documents;
using System;
using System.IO;
using System.Text;

internal class Class451
{
    private readonly StandardClipboardFormat standardClipboardFormat_0;
    private readonly string string_0;

    internal Class451(StandardClipboardFormat A_0)
    {
        this.standardClipboardFormat_0 = StandardClipboardFormat.None;
        this.standardClipboardFormat_0 = A_0;
    }

    internal Class451(string A_0)
    {
        this.standardClipboardFormat_0 = StandardClipboardFormat.None;
        this.string_0 = A_0;
    }

    internal Class451(BinaryReader A_0, bool A_1)
    {
        this.standardClipboardFormat_0 = StandardClipboardFormat.None;
        int num = A_0.ReadInt32();
        if (num > 0)
        {
            this.string_0 = A_1 ? this.method_0(A_0, num) : this.method_1(A_0, num);
        }
        else if (num < 0)
        {
            this.standardClipboardFormat_0 = (StandardClipboardFormat) A_0.ReadInt32();
        }
    }

    private string method_0(BinaryReader A_0, int A_1)
    {
        if (A_1 == 0)
        {
            return string.Empty;
        }
        byte[] bytes = A_0.ReadBytes(A_1);
        return Encoding.Unicode.GetString(bytes, 0, A_1 - 2);
    }

    private string method_1(BinaryReader A_0, int A_1)
    {
        string str = "";
        if (A_1 > 0)
        {
            byte[] bytes = A_0.ReadBytes(A_1 - 1);
            A_0.ReadByte();
            str = Encoding.GetEncoding(0x4e3).GetString(bytes);
        }
        return str;
    }

    internal StandardClipboardFormat method_10()
    {
        return this.standardClipboardFormat_0;
    }

    internal string method_11()
    {
        return this.string_0;
    }

    internal void method_2(BinaryWriter A_0, bool A_1)
    {
        if (this.standardClipboardFormat_0 != StandardClipboardFormat.None)
        {
            A_0.Write(-1);
            A_0.Write((int) this.standardClipboardFormat_0);
        }
        else if (Class567.smethod_16(this.string_0))
        {
            if (A_1)
            {
                this.method_4(this.string_0, A_0);
            }
            else
            {
                this.method_9(A_0, this.string_0);
            }
        }
        else
        {
            A_0.Write(0);
        }
    }

    private int method_3(string A_0, BinaryWriter A_1)
    {
        byte[] bytes = new byte[this.method_6(A_0)];
        Encoding.Unicode.GetBytes(A_0, 0, A_0.Length, bytes, 0);
        A_1.Write(bytes);
        return bytes.Length;
    }

    private void method_4(string A_0, BinaryWriter A_1)
    {
        A_1.Write(this.method_7(A_0));
        this.method_3(A_0, A_1);
    }

    private void method_5(string A_0, BinaryWriter A_1)
    {
        A_1.Write(this.method_6(A_0));
        this.method_3(A_0, A_1);
    }

    private int method_6(string A_0)
    {
        return (this.method_7(A_0) * 2);
    }

    private int method_7(string A_0)
    {
        return (A_0.Length + 1);
    }

    private void method_8(BinaryWriter A_0, string A_1)
    {
        A_1 = (A_1 == null) ? "" : A_1;
        A_0.Write((int) (A_1.Length + 1));
        A_0.Write(Encoding.GetEncoding(0x4e3).GetBytes(A_1));
        A_0.Write((byte) 0);
    }

    private void method_9(BinaryWriter A_0, string A_1)
    {
        if ((A_1 != null) && (A_1.Length > 0))
        {
            this.method_8(A_0, A_1);
        }
        else
        {
            A_0.Write(0);
        }
    }
}

