using Spire.Doc;
using System;

internal class Class228
{
    private bool bool_0;
    private int int_0;
    private LocaleIDs localeIDs_0 = LocaleIDs.en_US;
    private OdsoFieldMappingType odsoFieldMappingType_0 = OdsoFieldMappingType.Null;
    private string string_0 = "";
    private string string_1 = "";

    public Class228 method_0()
    {
        return (Class228) base.MemberwiseClone();
    }

    public int method_1()
    {
        return this.int_0;
    }

    public string method_10()
    {
        return this.string_1;
    }

    public void method_11(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("央倰弲䀴制", 9));
        this.string_1 = A_0;
    }

    public OdsoFieldMappingType method_12()
    {
        return this.odsoFieldMappingType_0;
    }

    public void method_13(OdsoFieldMappingType A_0)
    {
        this.odsoFieldMappingType_0 = A_0;
    }

    public void method_2(int A_0)
    {
        int num = 0x11;
        if (!smethod_0(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䄶堸场䠼娾", num));
        }
        this.int_0 = A_0;
    }

    internal void method_3(int A_0)
    {
        if (smethod_0(A_0))
        {
            this.int_0 = A_0;
        }
    }

    internal bool method_4()
    {
        return this.bool_0;
    }

    internal void method_5(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal LocaleIDs method_6()
    {
        return this.localeIDs_0;
    }

    internal void method_7(LocaleIDs A_0)
    {
        this.localeIDs_0 = A_0;
    }

    public string method_8()
    {
        return this.string_0;
    }

    public void method_9(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("伸娺儼䨾⑀", 0x13));
        this.string_0 = A_0;
    }

    private static bool smethod_0(int A_0)
    {
        return (A_0 >= 0);
    }
}

