using Spire.Doc;
using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class Class467
{
    private readonly Class644 class644_0;
    private Stream stream_0;
    private readonly string string_0;
    [CompilerGenerated]
    private string string_1;

    public Class467(string A_0, string A_1)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("䄰刲䜴䌶眸娺值娾", 11));
        this.string_0 = A_0;
        this.method_3(A_1);
        this.stream_0 = new MemoryStream();
        this.class644_0 = new Class644(A_0);
    }

    public string method_0()
    {
        return this.string_0;
    }

    public string method_1()
    {
        return Path.GetExtension(this.string_0).TrimStart(new char[] { '.' });
    }

    public MemoryStream method_10()
    {
        return Class567.smethod_9(this.stream_0);
    }

    [CompilerGenerated]
    public string method_2()
    {
        return this.string_1;
    }

    [CompilerGenerated]
    public void method_3(string A_0)
    {
        this.string_1 = A_0;
    }

    public Stream method_4()
    {
        return this.stream_0;
    }

    public void method_5(Stream A_0)
    {
        this.stream_0 = A_0;
    }

    public Class644 method_6()
    {
        return this.class644_0;
    }

    public void method_7(string A_0)
    {
        Stream stream = File.Create(A_0);
        try
        {
            this.stream_0.Position = 0L;
            Class567.smethod_8(this.stream_0, stream);
            this.stream_0.Position = 0L;
        }
        finally
        {
            this.stream_0.Close();
        }
    }

    public string method_8(string A_0)
    {
        int num = 0;
        if (!Class567.smethod_16(A_0))
        {
            return "";
        }
        Class1088 class2 = this.class644_0.method_4(A_0);
        if (class2 == null)
        {
            return "";
        }
        if (class2.method_3())
        {
            string str = class2.method_2();
            if (str.StartsWith(BookmarkStart.b("䀥䄧䘩䤫ᐭἯᴱ", num)))
            {
                str = Class736.smethod_17(str.Replace(BookmarkStart.b("䀥䄧䘩䤫ᐭἯᴱ", num), ""));
            }
            return str;
        }
        if (Class736.smethod_14(class2.method_2()))
        {
            return class2.method_2();
        }
        return this.method_9(class2);
    }

    public string method_9(Class1088 A_0)
    {
        int num = 4;
        if (A_0.method_3())
        {
            throw new InvalidOperationException(BookmarkStart.b("欩䈫อ夯就䀳匵䨷吹崻刽怿❁⡃⍅╇⽉≋㩍灏㭑❓癕㵗≙ⱛ㭝͟ᙡţɥ䙧", num));
        }
        return Class403.smethod_2(this.string_0, A_0.method_2());
    }
}

