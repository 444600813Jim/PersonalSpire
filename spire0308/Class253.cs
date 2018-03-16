using Spire.Doc;
using System;

internal abstract class Class253
{
    private bool bool_0;
    private bool bool_1 = true;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private string string_0;

    protected Class253()
    {
    }

    internal bool method_0()
    {
        return this.bool_0;
    }

    internal void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public bool method_10()
    {
        return this.bool_4;
    }

    public void method_11(bool A_0)
    {
        this.bool_4 = A_0;
    }

    internal bool method_2()
    {
        return this.bool_1;
    }

    internal void method_3(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public void method_4(string A_0)
    {
        this.string_0 = A_0;
    }

    public string method_5()
    {
        return this.string_0;
    }

    public bool method_6()
    {
        return this.bool_2;
    }

    public void method_7(bool A_0)
    {
        this.bool_2 = A_0;
    }

    public bool method_8()
    {
        return this.bool_3;
    }

    public void method_9(bool A_0)
    {
        this.bool_3 = A_0;
    }

    public static Class253 smethod_0(FileFormat A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case FileFormat.Docx:
            case FileFormat.Dotx:
            case FileFormat.Dotm:
            case FileFormat.Docm:
                return new Class254(A_0);

            case FileFormat.WordML:
                return new Class257();

            case FileFormat.Odt:
            case FileFormat.Ott:
                return new Class255(A_0);
        }
        throw new ArgumentException(BookmarkStart.b("瀸唺䬼帾ⵀ⩂⅄杆㩈⩊㭌⩎煐㕒㩔╖㑘㩚⥜罞፠٢ᑤቦ౨ᡪᥬ੮ᕰ嵲", num));
    }

    public static Class253 smethod_1(string A_0)
    {
        return null;
    }

    internal virtual void vmethod_0()
    {
        this.method_1(true);
        this.method_7(true);
        this.method_3(false);
    }

    public abstract FileFormat vmethod_1();
    public abstract void vmethod_2(FileFormat A_0);
    internal virtual bool vmethod_3()
    {
        return false;
    }

    internal virtual bool vmethod_4()
    {
        return true;
    }
}

