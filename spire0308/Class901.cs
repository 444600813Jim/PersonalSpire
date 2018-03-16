using Spire.Doc;
using System;

internal class Class901
{
    private readonly string string_0;
    private string string_1;
    private string string_2;

    public Class901(string A_0, string A_1, string A_2)
    {
        int num = 6;
        this.string_0 = "";
        this.string_1 = "";
        this.string_2 = "";
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈫伭崯圱", num));
        }
        this.string_0 = A_0;
        this.method_2(A_1);
        this.method_4(A_2);
    }

    public string method_0()
    {
        return this.string_0;
    }

    public string method_1()
    {
        return this.string_1;
    }

    public void method_2(string A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜱䘳張", num));
        }
        this.string_1 = A_0;
    }

    public string method_3()
    {
        return this.string_2;
    }

    public void method_4(string A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐱唳娵䴷弹", num));
        }
        this.string_2 = A_0;
    }

    internal Class901 method_5()
    {
        return (Class901) base.MemberwiseClone();
    }
}

