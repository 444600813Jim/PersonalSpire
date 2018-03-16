using Spire.Doc;
using System;
using System.IO;

internal class Class612
{
    private Class1016 class1016_0;
    private readonly Class303 class303_0;
    private Class373 class373_0;

    public Class612(Class303 A_0)
    {
        this.class303_0 = A_0;
    }

    public Class612(Stream A_0)
    {
        this.class303_0 = new Class303(A_0);
    }

    public Class303 method_0()
    {
        return this.class303_0;
    }

    public Stream method_1()
    {
        return this.class303_0.method_0();
    }

    public Class373 method_2()
    {
        return this.class373_0;
    }

    public Class1016 method_3()
    {
        return this.class1016_0;
    }

    public void method_4()
    {
        int num = 0;
        if (!this.method_5())
        {
            throw new InvalidOperationException(BookmarkStart.b("爥䀧伩ఫ崭嘯就䀳ᘵ帷匹倻嬽怿⭁㝃晅♇╉㡋湍♏㍑㡓㽕㱗瑙", num));
        }
    }

    public bool method_5()
    {
        this.class373_0 = Class373.smethod_0(this.class303_0);
        if (!this.method_2().method_0())
        {
            return false;
        }
        this.class1016_0 = new Class1016();
        for (int i = 0; i < this.method_2().ushort_0; i++)
        {
            Class877 class2 = Class877.smethod_0(this.class303_0);
            this.method_3().Add(class2.string_0, class2);
        }
        return true;
    }

    public void method_6(string A_0)
    {
        int num = 2;
        Class877 class2 = (Class877) this.class1016_0[A_0];
        if (class2 == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("欧䬩䈫䀭弯䘱ᐳ倵儷吹堻ḽ㐿⍁♃⩅ⵇ橉歋㕍恏⽑獓癕ㅗ㑙籛⩝࡟ݡ䑣eݧѩᡫ乭ᙯ᭱ᡳ፵噷", num), A_0));
        }
        this.class303_0.method_0().Position = class2.uint_1;
    }

    public byte[] method_7(string A_0)
    {
        this.method_6(A_0);
        Class877 class2 = (Class877) this.class1016_0[A_0];
        return this.class303_0.method_8((int) class2.uint_0);
    }
}

