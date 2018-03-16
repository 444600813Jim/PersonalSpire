using Spire.Doc;
using System;
using System.Collections;
using System.IO;

internal class Class1089 : SortedList
{
    private Guid guid_0;

    public Class1089() : this(Guid.Empty)
    {
    }

    public Class1089(Guid A_0) : base(new Class689())
    {
        this.guid_0 = Guid.Empty;
        this.guid_0 = A_0;
    }

    public Guid method_0()
    {
        return this.guid_0;
    }

    public void method_1(Guid A_0)
    {
        this.guid_0 = A_0;
    }

    public void method_2(string A_0, MemoryStream A_1)
    {
        base.Add(A_0, A_1);
    }

    public void method_3(string A_0, Class1089 A_1)
    {
        base.Add(A_0, A_1);
    }

    public MemoryStream method_4(string A_0)
    {
        MemoryStream stream = this[A_0] as MemoryStream;
        if (stream != null)
        {
            stream.Position = 0L;
        }
        return stream;
    }

    public MemoryStream method_5(string A_0)
    {
        int num = 1;
        MemoryStream stream = this.method_4(A_0);
        if (stream == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("搦䠨䔪䌬䀮䔰ጲ匴帶圸强ᴼ䰾㕀ㅂ⁄♆⑈歊橌㑎慐⹒牔睖じ㕚絜⭞ॠ٢䕤ᑦᵨѪὬ๮ᙰᙲ孴", num), A_0));
        }
        return stream;
    }

    public Class1089 method_6(string A_0)
    {
        return (Class1089) this[A_0];
    }

    public Class1089 method_7(string A_0)
    {
        int num = 0x11;
        Class1089 class2 = this.method_6(A_0);
        if (class2 == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("琶堸唺匼倾㕀捂⍄⹆❈⽊浌㱎═㱒❔㙖㹘㹚絜硞᩠卢ᡤ䁦䝨", num), A_0));
        }
        return class2;
    }
}

