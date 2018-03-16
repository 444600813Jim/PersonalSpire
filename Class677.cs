using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.IO;

internal class Class677
{
    private readonly Interface0 interface0_0;

    internal Class677(Interface0 A_0)
    {
        this.interface0_0 = A_0;
    }

    public void method_0(Stream A_0)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num));
        }
        if (this.method_7())
        {
            throw new InvalidOperationException(BookmarkStart.b("紨䌪䐬尮ᄰ簲礴父ᤸ吺弼唾⑀⁂ㅄ杆⁈㡊浌⍎㡐㵒㹔㉖㵘睚絜㹞འݢ䕤Ѧࡨժͬnհ卲᝴ቶ奸ࡺᱼॾꮄꞆ욈놐ﲘﾚ列爵얠莢讪슬춮\udbb0\ud6b2횴쎶쪸鮺\udebc\udebe꿀Ꞔꋆ룊곌많듐럒ﯔ", num));
        }
        this.method_19().vmethod_2(A_0, this.method_5());
    }

    public void method_1(string A_0)
    {
        using (Stream stream = File.Create(A_0))
        {
            this.method_0(stream);
        }
    }

    public string method_10()
    {
        return (string) this.method_30(0x1013);
    }

    public void method_11(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("弨䨪䄬娮吰", 3));
        this.method_31(0x1013, A_0);
    }

    public bool method_12()
    {
        return (bool) this.method_30(0x1014);
    }

    public void method_13(bool A_0)
    {
        this.method_31(0x1014, A_0);
    }

    public bool method_14()
    {
        return (bool) this.method_30(0x33a);
    }

    internal void method_15(bool A_0)
    {
        this.method_31(0x33a, A_0);
    }

    public bool method_16()
    {
        return (bool) this.method_30(0x1015);
    }

    public void method_17(bool A_0)
    {
        this.method_31(0x1015, A_0);
    }

    public Guid method_18()
    {
        if (this.method_21() != null)
        {
            return this.method_21().method_12().method_0();
        }
        if (this.method_22() != null)
        {
            return this.method_22().method_4();
        }
        return Guid.Empty;
    }

    internal Class453 method_19()
    {
        return (Class453) this.method_30(0x1010);
    }

    public string method_2()
    {
        if (this.method_19() == null)
        {
            return "";
        }
        return this.method_19().vmethod_1(this.method_5());
    }

    internal void method_20(Class453 A_0)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䘯匱堳䌵崷", num));
        }
        this.method_31(0x1010, A_0);
        this.method_23();
    }

    internal Class454 method_21()
    {
        return (this.method_19() as Class454);
    }

    internal Class455 method_22()
    {
        return (this.method_19() as Class455);
    }

    private void method_23()
    {
        int num = 5;
        if ((this.method_21() != null) && this.method_21().method_12().Contains(BookmarkStart.b("⠪戬䴮嬰稲嬴儶嘸", num)))
        {
            this.method_15(new Class320(this.method_21().method_12()).method_3());
        }
    }

    internal int method_24()
    {
        return (int) this.method_30(0x10b);
    }

    internal void method_25(int A_0)
    {
        this.method_31(0x10b, A_0);
    }

    internal ShapeOleLinkType method_26()
    {
        return (ShapeOleLinkType) this.method_30(0x1016);
    }

    internal void method_27(ShapeOleLinkType A_0)
    {
        this.method_31(0x1016, A_0);
    }

    internal int method_28()
    {
        return (int) this.method_30(0x1017);
    }

    internal void method_29(int A_0)
    {
        this.method_31(0x1017, A_0);
    }

    public MemoryStream method_3(string A_0)
    {
        if (this.method_21() != null)
        {
            return (MemoryStream) this.method_21().method_12()[A_0];
        }
        return null;
    }

    private object method_30(int A_0)
    {
        return this.interface0_0.imethod_2(A_0);
    }

    private void method_31(int A_0, object A_1)
    {
        this.interface0_0.imethod_3(A_0, A_1);
    }

    internal bool method_4()
    {
        return (this.method_7() && (this.method_19() == null));
    }

    public string method_5()
    {
        return (string) this.method_30(0x1011);
    }

    public void method_6(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("丷嬹倻䬽┿", 0x12));
        this.method_31(0x1011, A_0);
    }

    public bool method_7()
    {
        return Class567.smethod_16(this.method_8());
    }

    public string method_8()
    {
        return (string) this.method_30(0x1012);
    }

    public void method_9(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("倥䤧䘩夫䬭", 0));
        this.method_31(0x1012, A_0);
    }
}

