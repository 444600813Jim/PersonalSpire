using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class1005 : Interface61
{
    private Interface40 interface40_0;
    private List<string> list_0;
    private List<string> list_1;
    private const string string_0 = "_Root";
    private string string_1;

    [CLSCompliant(false)]
    public Class1005(Interface40 A_0) : this(A_0, BookmarkStart.b("椵樷唹医䨽", 0x10))
    {
    }

    [CLSCompliant(false)]
    public Class1005(Interface40 A_0, string A_1)
    {
        int num = 8;
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尭弯崱䀳", num));
        }
        if ((A_1 != null) && (A_1.Length != 0))
        {
            this.string_1 = A_1;
        }
        this.interface40_0 = A_0;
        this.method_1();
    }

    public Class1005(string A_0, STGM A_1)
    {
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        throw new NotImplementedException();
    }

    public void imethod_12(Interface61 A_0)
    {
        int num = 9;
        Class1005 class2 = A_0 as Class1005;
        if (class2 == null)
        {
            throw new NotImplementedException(BookmarkStart.b("氮帰䌲䰴帶圸尺ᴼ崾⑀㝂㉄≆ⱈ╊浌⭎㡐㕒㍔㉖⭘㹚㍜⭞䅠ၢᅤࡦ᭨੪੬੮兰ݲ౴ݶᱸࡺ嵼ᙾꎂﶈꮊﾒ殺ﲘ爵얠", num));
        }
        string str = A_0.imethod_11();
        if (this.imethod_7(str))
        {
            this.Interface61.imethod_6(str);
        }
        using (Class1005 class3 = this.imethod_4(str) as Class1005)
        {
            class2.interface40_0.imethod_4(0, IntPtr.Zero, IntPtr.Zero, class3.interface40_0);
        }
    }

    public void imethod_13(Stream1 A_0)
    {
        string str = A_0.method_0();
        using (Stream1 stream = this.Interface61.imethod_3(str) ? this.Interface61.imethod_0(str) : this.imethod_2(A_0.method_0()))
        {
            stream.SetLength(0L);
            A_0.vmethod_0(stream);
        }
    }

    public Stream1 imethod_2(string A_0)
    {
        Interface39 interface2 = null;
        this.interface40_0.imethod_0(A_0, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE, 0, 0, ref interface2);
        this.list_1.Add(A_0);
        return new Stream5(interface2, A_0);
    }

    public Interface61 imethod_4(string A_0)
    {
        Interface40 interface2;
        int num = 9;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尮䔰尲䜴嘶常帺猼帾ⱀ♂", num));
        }
        int errorCode = this.interface40_0.imethod_2(A_0, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE, 0, 0, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("缮䌰尲圴嬶尸嘺丼Ἶ╀㙂㝄⹆❈ⱊ浌㱎═㱒❔㙖㹘㹚絜㱞፠٢Ѥ፦hѪͬ", num), errorCode);
        }
        this.list_0.Add(A_0);
        return new Class1005(interface2, A_0);
    }

    public bool imethod_7(string A_0)
    {
        return this.list_0.Contains(A_0);
    }

    Stream1 Interface61.imethod_0(string A_0)
    {
        Interface39 interface2;
        this.interface40_0.imethod_1(A_0, 0, STGM.STGM_SHARE_EXCLUSIVE, 0, out interface2);
        return new Stream5(interface2, A_0);
    }

    void Interface61.imethod_1(string A_0)
    {
        if (this.Interface61.imethod_3(A_0))
        {
            this.interface40_0.imethod_9(A_0);
            this.list_1.Remove(A_0);
        }
    }

    string[] Interface61.imethod_10()
    {
        return this.list_0.ToArray();
    }

    string Interface61.imethod_11()
    {
        return this.string_1;
    }

    bool Interface61.imethod_3(string A_0)
    {
        return this.list_1.Contains(A_0);
    }

    Interface61 Interface61.imethod_5(string A_0)
    {
        Interface40 interface2;
        int num = 11;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䈰䜲娴䔶堸尺堼焾⁀⹂⁄", num));
        }
        int errorCode = this.interface40_0.imethod_3(A_0, IntPtr.Zero, STGM.STGM_SHARE_EXCLUSIVE, IntPtr.Zero, 0, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("愰䄲娴唶唸帺值䰾慀❂い㕆⁈╊⩌潎≐❒㩔╖㡘㱚㡜罞ɠᅢd٦ᵨɪɬŮ", num), errorCode);
        }
        return new Class1005(interface2, A_0);
    }

    void Interface61.imethod_6(string A_0)
    {
        if (this.imethod_7(A_0))
        {
            this.interface40_0.imethod_9(A_0);
            this.list_0.Remove(A_0);
        }
    }

    void Interface61.imethod_8()
    {
        this.interface40_0.imethod_6(0);
    }

    string[] Interface61.imethod_9()
    {
        return this.list_1.ToArray();
    }

    public Interface40 method_0()
    {
        return this.interface40_0;
    }

    private void method_1()
    {
        this.list_0.Clear();
        this.list_1.Clear();
        this.method_5(new Delegate9(this.method_4), null);
    }

    private void method_2(Struct3 A_0, object A_1)
    {
        if (A_0.stgty_0 == STGTY.STGTY_STREAM)
        {
            ((List<string>) A_1).Add(A_0.string_0);
        }
    }

    private void method_3(Struct3 A_0, object A_1)
    {
        if (A_0.stgty_0 == STGTY.STGTY_STORAGE)
        {
            ((List<string>) A_1).Add(A_0.string_0);
        }
    }

    private void method_4(Struct3 A_0, object A_1)
    {
        if (A_0.stgty_0 == STGTY.STGTY_STREAM)
        {
            if (this.list_1 != null)
            {
                this.list_1.Add(A_0.string_0);
            }
        }
        else if ((A_0.stgty_0 == STGTY.STGTY_STORAGE) && (this.list_0 != null))
        {
            this.list_0.Add(A_0.string_0);
        }
    }

    private void method_5(Delegate9 A_0, object A_1)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䴭儯帱堳匵䨷", num));
        }
        Interface38 interface2 = null;
        int errorCode = this.interface40_0.imethod_8(0, IntPtr.Zero, 0, ref interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("紭䐯䀱儳圵唷ᨹ礻倽㔿⽁⅃㑅⥇㹉╋⅍㹏牑᭓♕㵗⡙㵛⩝य़ൡ੣䙥๧୩իɭᕯᙱ", num), errorCode);
        }
        if (interface2 == null)
        {
            throw new SystemException(BookmarkStart.b("洭儯就娳夵䰷ᨹ嬻嬽㐿扁ൃͅ♇㽉⅋ᵍяፑSՕ౗ᵙ籛㝝๟ᙡţᑥ๧୩ཫ୭偯qᅳၵᵷࡹቻᵽꊁ겋ﶍ﶑ﾗﾙ", num));
        }
        errorCode = interface2.imethod_2();
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("紭䐯䀱儳圵唷ᨹ礻倽㔿⽁⅃㑅⥇㹉╋⅍㹏牑᭓♕㵗⡙㵛⩝य़ൡ੣䙥๧୩իɭᕯᙱ", num), errorCode);
        }
        Struct3 struct2 = new Struct3();
        uint num3 = 0;
        errorCode = interface2.imethod_0(1, ref struct2, ref num3);
        while (errorCode == 0)
        {
            if (1 != num3)
            {
                break;
            }
            A_0(struct2, A_1);
            errorCode = interface2.imethod_0(1, ref struct2, ref num3);
        }
        if ((errorCode > 1) || (errorCode < 0))
        {
            throw new ExternalException(BookmarkStart.b("紭䐯䀱儳圵唷ᨹ礻倽㔿⽁⅃㑅⥇㹉╋⅍㹏牑᭓♕㵗⡙㵛⩝य़ൡ੣䙥๧୩իɭᕯᙱ", num), errorCode);
        }
        Marshal.ReleaseComObject(interface2);
        interface2 = null;
    }

    void IDisposable.Dispose()
    {
        if (this.interface40_0 != null)
        {
            Marshal.FinalReleaseComObject(this.interface40_0);
            GC.SuppressFinalize(this.interface40_0);
            this.interface40_0 = null;
        }
    }

    void object.Finalize()
    {
        try
        {
            this.System.IDisposable.Dispose();
        }
        finally
        {
            base.Finalize();
        }
    }

    private delegate void Delegate9(Struct3 A_0, object A_1);
}

