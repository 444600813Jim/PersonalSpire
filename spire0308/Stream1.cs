using Spire.Doc;
using System;
using System.IO;

internal abstract class Stream1 : Stream
{
    private string string_0;

    public Stream1(string A_0)
    {
        this.string_0 = A_0;
    }

    public string method_0()
    {
        return this.string_0;
    }

    protected void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    public virtual void vmethod_0(Stream1 A_0)
    {
        int num2;
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌯䘱䘳匵夷圹", num));
        }
        byte[] buffer = new byte[0x8000];
        long position = this.Position;
        while ((num2 = this.Read(buffer, 0, 0x8000)) > 0)
        {
            A_0.Write(buffer, 0, num2);
        }
    }
}

