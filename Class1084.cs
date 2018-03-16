using System;
using System.IO;
using System.Text;

internal class Class1084 : IDisposable
{
    private bool bool_0;
    private Encoding encoding_0;
    private int? nullable_0;
    private TextReader textReader_0;

    public Class1084(TextReader A_0)
    {
        this.nullable_0 = null;
        this.textReader_0 = A_0;
        this.bool_0 = true;
    }

    public Class1084(Stream A_0, Encoding A_1)
    {
        this.nullable_0 = null;
        this.encoding_0 = A_1;
        this.textReader_0 = new StreamReader(A_0, this.method_0(), true);
    }

    public Encoding method_0()
    {
        if (this.encoding_0 == null)
        {
            this.encoding_0 = Encoding.GetEncoding(0x4e4);
        }
        return this.encoding_0;
    }

    public bool method_1()
    {
        return (this.textReader_0.Peek() == -1);
    }

    public char method_2()
    {
        char ch;
        if (this.nullable_0.HasValue)
        {
            ch = (char) this.nullable_0.Value;
            this.nullable_0 = null;
            return ch;
        }
        ch = (char) this.textReader_0.Read();
        if (ch > '\x00ff')
        {
            byte[] bytes = this.method_0().GetBytes(new char[] { ch });
            if (bytes.Length == 2)
            {
                ch = (char) bytes[0];
                this.nullable_0 = new int?(bytes[1]);
            }
        }
        return ch;
    }

    public char method_3()
    {
        if (this.nullable_0.HasValue)
        {
            return (char) this.nullable_0.Value;
        }
        char ch = (char) this.textReader_0.Peek();
        if (ch > '\x00ff')
        {
            byte[] bytes = this.method_0().GetBytes(new char[] { ch });
            if (bytes.Length == 2)
            {
                ch = (char) bytes[0];
            }
        }
        return ch;
    }

    public string method_4()
    {
        int num;
        StringBuilder builder = new StringBuilder();
        while ((num = this.textReader_0.Read()) > -1)
        {
            if (num == 0x7d)
            {
                this.nullable_0 = new int?(num);
                break;
            }
            if ((num != 13) || (num != 10))
            {
                builder.Append((char) num);
            }
        }
        return builder.ToString();
    }

    void IDisposable.Dispose()
    {
        if ((this.textReader_0 != null) && !this.bool_0)
        {
            this.textReader_0.Close();
            this.textReader_0.Dispose();
            this.textReader_0 = null;
        }
    }
}

