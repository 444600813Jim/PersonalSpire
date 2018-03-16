using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class650
{
    internal static readonly Class650 class650_0 = new Class650(0);
    internal static readonly Class650 class650_1 = new Class650(1);
    internal static readonly Class650 class650_2 = new Class650(0x80);
    internal static readonly Class650 class650_3 = new Class650(0x81);
    private const int int_0 = 0;
    private const int int_1 = 1;
    private const int int_2 = 0x80;
    private const int int_3 = 0x81;
    private readonly int int_4;

    internal Class650(bool A_0)
    {
        this.int_4 = A_0 ? 1 : 0;
    }

    private Class650(int A_0)
    {
        this.int_4 = A_0;
    }

    internal int method_0()
    {
        return this.int_4;
    }

    internal bool method_1()
    {
        int num = 12;
        switch (this.int_4)
        {
            case 0:
                return false;

            case 1:
                return true;
        }
        throw new InvalidOperationException(BookmarkStart.b("簱嬳䈵ᠷ弹䐻丽┿⅁ぃ⍅ⱇ橉⍋㩍㡏㝑♓癕㩗㕙㍛㉝՟ᩡ䑣ၥ१٩ᥫ୭ͯ剱ᱳ፵੷ό剻", num));
    }

    internal Class650 method_2()
    {
        int num = 12;
        switch (this.int_4)
        {
            case 0:
                return class650_1;

            case 1:
                return class650_0;
        }
        throw new InvalidOperationException(BookmarkStart.b("簱嬳䈵ᠷ弹䐻丽┿⅁ぃ⍅ⱇ橉⍋㩍㡏㝑♓癕㩗㕙㍛㉝՟ᩡ䑣ၥ१٩ᥫ୭ͯ剱ᱳ፵੷ό剻", num));
    }

    internal Class650 method_3(AttrCollection A_0, int A_1)
    {
        int num = 13;
        switch (this.int_4)
        {
            case 0:
            case 1:
                return this;

            case 0x80:
                return (Class650) A_0.method_32(A_1);

            case 0x81:
                return ((Class650) A_0.method_32(A_1)).method_2();
        }
        throw new InvalidOperationException(BookmarkStart.b("昲嬴尶圸吺䨼儾慀⅂⩄⡆╈⹊㕌潎❐㉒㥔≖㱘畚", num));
    }

    internal Class650 method_4(CharacterFormat A_0, int A_1)
    {
        int num = 8;
        switch (this.int_4)
        {
            case 0:
            case 1:
                return this;

            case 0x80:
                return (Class650) A_0.method_32(A_1);

            case 0x81:
                return ((Class650) A_0.method_32(A_1)).method_2();
        }
        throw new InvalidOperationException(BookmarkStart.b("笭帯失娳夵伷吹᰻尽⼿ⵁ⡃⍅ぇ橉㩋⽍㱏❑ㅓ硕", num));
    }

    internal Class650 method_5(IRunAttrSource A_0, int A_1)
    {
        int num = 0;
        switch (this.int_4)
        {
            case 0:
            case 1:
                return this;

            case 0x80:
                return (Class650) A_0.FetchInheritedRunAttr(A_1);

            case 0x81:
                return ((Class650) A_0.FetchInheritedRunAttr(A_1)).method_2();
        }
        throw new InvalidOperationException(BookmarkStart.b("猥䘧䄩䈫䄭䜯就ᐳ琵圷唹倻笽㠿扁㉃❅⑇㽉⥋恍", num));
    }

    internal object method_6(IRunAttrSource A_0, int A_1)
    {
        int num = 0x13;
        switch (this.int_4)
        {
            case 0:
                return false;

            case 1:
                return true;

            case 0x80:
                return null;

            case 0x81:
                if (A_0 == null)
                {
                    return null;
                }
                return ((Class650) A_0.FetchInheritedRunAttr(A_1)).method_2().method_1();
        }
        throw new InvalidOperationException(BookmarkStart.b("永唺嘼儾⹀㑂⭄杆ୈ⑊≌⍎ᑐ⭒畔⅖㡘㝚⡜㩞你", num));
    }

    internal static Class650 smethod_0(bool A_0)
    {
        if (!A_0)
        {
            return class650_0;
        }
        return class650_1;
    }
}

