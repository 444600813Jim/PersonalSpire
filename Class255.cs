using Spire.Doc;
using System;

internal class Class255 : Class253
{
    private bool bool_5;
    private FileFormat fileFormat_0;

    public Class255() : this(FileFormat.Odt)
    {
    }

    public Class255(FileFormat A_0)
    {
        this.method_12(A_0);
    }

    private void method_12(FileFormat A_0)
    {
        int num = 8;
        switch (A_0)
        {
            case FileFormat.Odt:
            case FileFormat.Ott:
                this.fileFormat_0 = A_0;
                return;
        }
        throw new ArgumentException(BookmarkStart.b("漭帯ሱ崳堵丷嬹倻圽␿扁ᝃ❅㹇⽉ੋ⅍≏㽑㕓≕硗㱙㍛ⱝ䁟ᙡౣཥ᭧䩩ͫṭѯ᭱᭳ᡵ୷婹ࡻݽꒃ黎겋﶑뒙", num));
    }

    public bool method_13()
    {
        return this.bool_5;
    }

    public void method_14(bool A_0)
    {
        this.bool_5 = A_0;
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

