using Spire.Doc;
using Spire.Doc.Converters;
using System;

internal class Class254 : Class253
{
    private bool bool_5;
    private bool bool_6;
    private FileFormat fileFormat_0;
    private OoxmlCompliance ooxmlCompliance_0;
    private string string_1;

    public Class254() : this(FileFormat.Docx)
    {
    }

    public Class254(FileFormat A_0)
    {
        this.bool_6 = true;
        this.method_12(A_0);
    }

    private void method_12(FileFormat A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case FileFormat.Docx:
            case FileFormat.Dotx:
            case FileFormat.Docm:
            case FileFormat.Dotm:
                this.fileFormat_0 = A_0;
                return;
        }
        throw new ArgumentException(BookmarkStart.b("申堵ᠷ匹刻䠽ℿ⹁ⵃ≅桇᥉ⵋ㡍㕏ᑑ㭓⑕㕗㭙⡛繝ٟൡᙣ䙥ᱧɩիᵭ偯ᵱѳɵᅷᕹቻൽꁿﶃꪉﮋ늑ﺕ鍊躟", num));
    }

    public string method_13()
    {
        return this.string_1;
    }

    public void method_14(string A_0)
    {
        this.string_1 = A_0;
    }

    public OoxmlCompliance method_15()
    {
        return this.ooxmlCompliance_0;
    }

    public void method_16(OoxmlCompliance A_0)
    {
        this.ooxmlCompliance_0 = A_0;
    }

    internal bool method_17()
    {
        return this.bool_5;
    }

    internal void method_18(bool A_0)
    {
        this.bool_5 = A_0;
    }

    internal bool method_19()
    {
        return this.bool_6;
    }

    internal void method_20(bool A_0)
    {
        this.bool_6 = A_0;
    }

    internal override void vmethod_0()
    {
        base.vmethod_0();
        this.method_20(false);
    }

    public override FileFormat vmethod_1()
    {
        return this.fileFormat_0;
    }

    public override void vmethod_2(FileFormat A_0)
    {
        this.method_12(A_0);
    }
}

