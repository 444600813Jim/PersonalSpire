using Spire.Doc;
using System;
using System.Collections;

internal class Class50 : OwnerHolder
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private Class49 class49_0;
    private Document document_0;
    private readonly Hashtable hashtable_0;
    private readonly Hashtable hashtable_1;
    private int int_1;
    private ScreenSize screenSize_0;
    private string string_1;
    private WebTarget webTarget_0;

    public Class50(Document A_0) : base(A_0, A_0)
    {
        this.int_1 = 0x60;
        this.screenSize_0 = ScreenSize.Size800x600;
        this.hashtable_0 = new Hashtable();
        this.hashtable_1 = new Hashtable();
        this.document_0 = A_0;
        spr᫇.ᜁ(new object[] { 
            BookmarkStart.b("ᴫḭȯر䰳ĵืȹ", 6), ScreenSize.Size1024x768, BookmarkStart.b("ᴫἭԯ1䰳ี7࠹", 6), ScreenSize.Size1152x882, BookmarkStart.b("ᴫἭԯ1䰳༵࠷ਹ", 6), ScreenSize.Size1152x900, BookmarkStart.b("ᴫᰭ࠯ȱ䰳ܵ࠷࠹࠻", 6), ScreenSize.Size1280x1024, BookmarkStart.b("ᴫᠭ/ȱ䰳ܵ਷ਹ఻", 6), ScreenSize.Size1600x1200, BookmarkStart.b("ᴫᘭ/ȱ䰳ܵషู఻", 6), ScreenSize.Size1800x1440, BookmarkStart.b("ᴫᜭȯȱ䰳ܵ਷ਹ఻", 6), ScreenSize.Size1920x1200, BookmarkStart.b("ᤫᨭЯ䨱ܳĵื", 6), ScreenSize.Size544x376, 
            BookmarkStart.b("ᨫᨭ/䨱3ี࠷", 6), ScreenSize.Size640x480, BookmarkStart.b("ᬫᰭ/䨱ĳܵ਷", 6), ScreenSize.Size720x512, BookmarkStart.b("ᐫḭ/䨱ȳص࠷", 6), ScreenSize.Size800x600
         }, this.hashtable_0, this.hashtable_1);
    }

    public WebTarget method_10()
    {
        return this.webTarget_0;
    }

    public void method_11(WebTarget A_0)
    {
        this.webTarget_0 = A_0;
    }

    public bool method_12()
    {
        return this.bool_1;
    }

    public void method_13(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public bool method_14()
    {
        return this.bool_2;
    }

    public void method_15(bool A_0)
    {
        this.bool_2 = A_0;
    }

    public bool method_16()
    {
        return this.bool_3;
    }

    public void method_17(bool A_0)
    {
        this.bool_3 = A_0;
    }

    public bool method_18()
    {
        return this.bool_4;
    }

    public void method_19(bool A_0)
    {
        this.bool_4 = A_0;
    }

    public bool method_20()
    {
        return this.bool_5;
    }

    public void method_21(bool A_0)
    {
        this.bool_5 = A_0;
    }

    public int method_22()
    {
        return this.int_1;
    }

    public void method_23(int A_0)
    {
        this.int_1 = A_0;
    }

    public ScreenSize method_24()
    {
        return this.screenSize_0;
    }

    public void method_25(ScreenSize A_0)
    {
        this.screenSize_0 = A_0;
    }

    public Class51 method_26(int A_0)
    {
        Class51 class3;
        using (IEnumerator enumerator = this.method_5().GetEnumerator())
        {
            Class51 current;
            while (enumerator.MoveNext())
            {
                current = (Class51) enumerator.Current;
                if (current.method_7() == A_0)
                {
                    goto Label_0030;
                }
            }
            return null;
        Label_0030:
            class3 = current;
        }
        return class3;
    }

    internal ScreenSize method_27(string A_0)
    {
        return (ScreenSize) spr᫇.ᜀ(this.hashtable_0, A_0, ScreenSize.Size800x600);
    }

    internal string method_28(ScreenSize A_0)
    {
        return (string) spr᫇.ᜀ(this.hashtable_1, A_0, "");
    }

    public Document method_4()
    {
        return this.document_0;
    }

    public Class49 method_5()
    {
        if (this.class49_0 == null)
        {
            this.class49_0 = new Class49(this.document_0);
        }
        return this.class49_0;
    }

    public string method_6()
    {
        return this.string_1;
    }

    public void method_7(string A_0)
    {
        this.string_1 = A_0;
    }

    public bool method_8()
    {
        return this.bool_0;
    }

    public void method_9(bool A_0)
    {
        this.bool_0 = A_0;
    }
}

