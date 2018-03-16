using Spire.Doc;
using System;
using System.IO;

internal class Class113
{
    private readonly MemoryStream memoryStream_0;
    private readonly string string_0;

    public Class113(string A_0) : this(A_0, new MemoryStream())
    {
    }

    public Class113(string A_0, MemoryStream A_1)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("砧䬩伫䔭儯唱儳昵夷䠹䠻ွ฿⍁⥃⍅", 2));
        this.string_0 = A_0;
        this.memoryStream_0 = A_1;
    }

    public void method_0(string A_0)
    {
        using (Stream stream = File.Create(A_0))
        {
            this.memoryStream_0.Position = 0L;
            Class567.smethod_8(this.memoryStream_0, stream);
            this.memoryStream_0.Position = 0L;
        }
    }

    public string method_1()
    {
        return this.string_0;
    }

    public string method_2()
    {
        return Path.GetExtension(this.string_0);
    }

    public MemoryStream method_3()
    {
        return this.memoryStream_0;
    }
}

