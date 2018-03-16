using Spire.Doc;
using System;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class861
{
    private bool bool_0;
    [CompilerGenerated]
    private Document document_0;
    private Encoding encoding_0;
    private FileFormat fileFormat_0;
    private string string_0;
    private string string_1;

    public Class861()
    {
        this.fileFormat_0 = FileFormat.Auto;
    }

    public Class861(string A_0)
    {
        this.fileFormat_0 = FileFormat.Auto;
        this.string_0 = A_0;
    }

    public Class861(FileFormat A_0, string A_1, string A_2)
    {
        this.fileFormat_0 = FileFormat.Auto;
        this.fileFormat_0 = A_0;
        this.string_0 = A_1;
        this.string_1 = A_2;
    }

    [CompilerGenerated]
    public Document method_0()
    {
        return this.document_0;
    }

    [CompilerGenerated]
    public void method_1(Document A_0)
    {
        this.document_0 = A_0;
    }

    public bool method_10()
    {
        return this.bool_0;
    }

    public void method_11(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal Class861 method_12()
    {
        return (Class861) base.MemberwiseClone();
    }

    public FileFormat method_2()
    {
        return this.fileFormat_0;
    }

    public void method_3(FileFormat A_0)
    {
        this.fileFormat_0 = A_0;
    }

    public string method_4()
    {
        return this.string_0;
    }

    public void method_5(string A_0)
    {
        this.string_0 = A_0;
    }

    public string method_6()
    {
        return this.string_1;
    }

    public void method_7(string A_0)
    {
        this.string_1 = A_0;
    }

    public Encoding method_8()
    {
        return this.encoding_0;
    }

    public void method_9(Encoding A_0)
    {
        this.encoding_0 = A_0;
    }
}

