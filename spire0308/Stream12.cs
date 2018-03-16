using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Stream12 : Stream, IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private const int int_0 = 0x8000;
    private Interface39 interface39_0;
    private Interface40 interface40_0;
    private Interface65 interface65_0;
    private List<string> list_0;
    private List<string> list_1;
    private long long_0;
    private long long_1;
    public const STGM stgm_0 = STGM.STGM_SHARE_DENY_WRITE;
    public const STGM stgm_1 = STGM.STGM_SHARE_EXCLUSIVE;
    public const STGM stgm_2 = (STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
    public const STGM stgm_3 = (STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
    public const STGM stgm_4 = (STGM.STGM_DIRECT_SWMR | STGM.STGM_SHARE_DENY_NONE);
    private STGM stgm_5;
    private STGM stgm_6;
    private string string_0;
    private string string_1;
    private string string_2;

    private Stream12()
    {
        this.long_0 = -1L;
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
    }

    public Stream12(Stream A_0) : this(A_0, STGM.STGM_SHARE_EXCLUSIVE)
    {
    }

    public Stream12(string A_0) : this(A_0, STGM.STGM_SHARE_DENY_WRITE)
    {
    }

    public Stream12(Stream12 A_0, string A_1) : this(A_0, A_1, STGM.STGM_SHARE_EXCLUSIVE)
    {
    }

    public Stream12(Stream A_0, STGM A_1)
    {
        uint num3;
        int num4 = 7;
        this.long_0 = -1L;
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        if (A_0 is Stream12)
        {
            throw new ArgumentException(BookmarkStart.b("搬嬮ᄰ娲䘴᜶樸伺娼氾㕀ㅂ⁄♆⑈歊ⱌ⍎⍐㙒㑔㍖⁘畚", num4));
        }
        int errorCode = Class359.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out this.interface65_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("測丮弰ᐲ䄴᜶娸䤺堼帾㕀♂敄୆♈⡊♌ൎ⡐❒ご⑖睘", num4), errorCode);
        }
        int count = (int) (A_0.Length - A_0.Position);
        byte[] buffer = new byte[count];
        A_0.Read(buffer, 0, count);
        errorCode = this.interface65_0.imethod_1(0L, buffer, (uint) buffer.Length, out num3);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("測丮弰ᐲ䄴᜶丸䤺吼䬾⑀捂ॄ⡆⩈⁊ཌ㙎═㙒♔祖", num4), errorCode);
        }
        errorCode = this.interface65_0.imethod_2();
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("測丮弰ᐲ䄴᜶弸场䠼䰾⥀捂ॄ⡆⩈⁊ཌ㙎═㙒♔祖", num4), errorCode);
        }
        errorCode = Class359.StgOpenStorageOnILockBytes(this.interface65_0, null, A_1, 0, 0, out this.interface40_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("測丮弰ᐲ䄴᜶嘸䬺堼儾慀あㅄ⡆㭈⩊⩌⩎煐㱒㭔睖ᕘ㑚㹜㑞⍠ᩢᅤɦᩨ䕪", num4), errorCode);
        }
        this.method_27();
        this.stgm_5 = A_1;
    }

    public Stream12(string A_0, STGM A_1)
    {
        int num2 = 4;
        this.long_0 = -1L;
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䰩䔫䈭唯簱唳嬵崷", num2));
        }
        int errorCode = Class359.StgOpenStorage(A_0, IntPtr.Zero, A_1, IntPtr.Zero, 0, out this.interface40_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("椩䴫䀭帯崱䀳ᘵ圷䨹夻倽怿ㅁぃ⥅㩇⭉⭋⭍繏牑ቓ㽕㑗㽙籛ၝşཡţ䙥ŧᥩ噫乭", num2) + A_0, errorCode);
        }
        this.method_27();
        this.string_0 = A_0;
        this.stgm_5 = A_1;
    }

    public Stream12(string A_0, string A_1) : this(A_0, STGM.STGM_SHARE_DENY_WRITE, A_1, STGM.STGM_SHARE_EXCLUSIVE)
    {
    }

    public Stream12(Stream12 A_0, string A_1, STGM A_2) : this(A_0, A_1, STGM.STGM_SHARE_EXCLUSIVE, false)
    {
    }

    public Stream12(Stream12 A_0, string A_1, bool A_2) : this(A_0, A_1, A_2 ? (STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE) : STGM.STGM_SHARE_EXCLUSIVE, A_2)
    {
    }

    public Stream12(Stream12 A_0, string A_1, STGM A_2, bool A_3)
    {
        int num = 0x13;
        this.long_0 = -1L;
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨸伺刼䴾⁀⑂⁄", num));
        }
        if (A_0.interface40_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("倸唺䴼䨾㕀捂㙄㍆♈㥊ⱌ⡎㑐獒㡔≖⩘⽚絜㵞Ѡ䍢੤ᝦ౨ժ࡬୮", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨸伺似娾⁀⹂ୄ♆⑈⹊", num));
        }
        IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(A_0.interface40_0);
        this.interface40_0 = (Interface40) Marshal.GetObjectForIUnknown(iUnknownForObject);
        Marshal.Release(iUnknownForObject);
        this.stgm_5 = A_0.stgm_5;
        this.list_1.AddRange(A_0.list_1);
        this.list_0.AddRange(A_0.list_0);
        if (A_3)
        {
            this.method_16(A_1, A_2);
        }
        else
        {
            this.method_10(A_1, A_2);
        }
    }

    public Stream12(string A_0, STGM A_1, string A_2, STGM A_3) : this(A_0, A_1)
    {
        this.method_10(A_2, A_3);
    }

    public void Dispose()
    {
        if (!this.bool_0)
        {
            this.bool_0 = true;
            this.Close();
            if (this.interface40_0 != null)
            {
                Marshal.ReleaseComObject(this.interface40_0);
                this.interface40_0 = null;
            }
            if (this.interface65_0 != null)
            {
                Marshal.FinalReleaseComObject(this.interface65_0);
                GC.SuppressFinalize(this.interface65_0);
                this.interface65_0 = null;
            }
            this.string_2 = null;
            this.bool_0 = true;
            this.list_1 = null;
            this.list_0 = null;
        }
    }

    public bool method_0()
    {
        return this.bool_4;
    }

    public string[] method_1()
    {
        return this.list_0.ToArray();
    }

    public void method_10(string A_0, STGM A_1)
    {
        int num = 3;
        this.method_22();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲笴嘶吸帺", num));
        }
        bool flag = false;
        for (int i = 0; i < this.list_0.Count; i++)
        {
            string strA = this.list_0[i];
            if (string.Compare(strA, A_0, true) == 0)
            {
                flag = true;
                A_0 = strA;
                break;
            }
        }
        if (!flag)
        {
            throw new ArgumentException(BookmarkStart.b("怨䔪ബ尮䔰尲䜴嘶常帺ᴼ尾⁀ⵂ⭄⡆㵈歊⽌⩎煐㕒㩔≖㝘㽚絜ⱞᕠᅢd٦Ѩ䭪ᩬٮհ᭲啴ѶॸṺṼᙾꦈꦒ떔", num) + A_0);
        }
        if (this.interface39_0 != null)
        {
            this.Close();
        }
        int errorCode = this.interface40_0.imethod_1(A_0, 0, A_1, 0, out this.interface39_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("樨䨪䌬䄮帰䜲ᔴ堶䤸帺匼Ἶ㉀㝂㝄≆⡈♊捌", num), errorCode);
        }
        this.long_0 = this.method_24();
        this.long_1 = 0L;
        this.bool_2 = (A_1 & (STGM.STGM_READWRITE | STGM.STGM_WRITE)) > STGM.STGM_DIRECT;
        this.bool_3 = true;
        this.bool_1 = true;
        this.bool_4 = (A_1 & STGM.STGM_TRANSACTED) > STGM.STGM_DIRECT;
        this.string_1 = A_0;
        this.stgm_6 = A_1;
    }

    public Stream12 method_11(string A_0)
    {
        return this.method_12(A_0, STGM.STGM_SHARE_EXCLUSIVE);
    }

    public Stream12 method_12(string A_0, STGM A_1)
    {
        Interface40 interface2;
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈰䜲娴䔶堸尺堼焾⁀⹂⁄", num));
        }
        this.method_22();
        int errorCode = this.interface40_0.imethod_3(A_0, IntPtr.Zero, A_1, IntPtr.Zero, 0, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("爰刲嬴夶嘸伺ᴼ倾ㅀ♂⭄杆㩈㹊⽌潎≐❒㩔╖㡘㱚㡜煞䅠ၢၤզ䥨ᡪᥬnͰቲቴቶ奸ᕺᱼቾꎂ뎈ꮊ", num) + A_0, errorCode);
        }
        Stream12 stream = new Stream12 {
            interface40_0 = interface2,
            string_2 = A_0
        };
        stream.method_27();
        stream.stgm_5 = A_1;
        return stream;
    }

    public Stream12 method_13(string A_0)
    {
        return this.method_14(A_0, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
    }

    public Stream12 method_14(string A_0, STGM A_1)
    {
        Interface40 interface2;
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐶䴸吺似帾♀♂ୄ♆⑈⹊", num));
        }
        this.method_22();
        int errorCode = this.interface40_0.imethod_2(A_0, A_1, 0, 0, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("琶堸唺匼倾㕀捂⩄㝆ⱈ╊浌㱎⑐ㅒ畔⑖ⵘ㑚⽜㹞٠٢䭤䝦ᩨṪཬ佮ɰݲᩴնᡸᱺ᡼彾ꦈﺌ떎놐", num) + A_0, errorCode);
        }
        Stream12 stream = new Stream12 {
            interface40_0 = interface2,
            string_2 = A_0
        };
        interface2 = null;
        stream.method_27();
        stream.stgm_5 = A_1;
        this.list_1.Add(A_0);
        return stream;
    }

    public void method_15(string A_0)
    {
        this.method_16(A_0, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
    }

    public void method_16(string A_0, STGM A_1)
    {
        int num2 = 1;
        int errorCode = this.interface40_0.imethod_0(A_0, A_1, 0, 0, ref this.interface39_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("搦䠨䔪䌬䀮䔰ጲ嘴䔶尸娺䤼娾慀あㅄ㕆ⱈ⩊⁌慎", num2), errorCode);
        }
        this.string_1 = A_0;
        this.list_0.Add(A_0);
        this.long_1 = 0L;
        this.bool_2 = (A_1 & (STGM.STGM_READWRITE | STGM.STGM_WRITE)) > STGM.STGM_DIRECT;
        this.bool_3 = true;
        this.bool_1 = true;
        this.bool_4 = (A_1 & STGM.STGM_TRANSACTED) > STGM.STGM_DIRECT;
        this.method_27();
    }

    public void method_17(Stream A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐶䴸䤺堼帾ⱀ", num));
        }
        if (this.interface65_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娶昸场刼尾⩀ł㱄㍆ⱈ㡊", num));
        }
        byte[] buffer = new byte[0x8000];
        long num2 = 0L;
        while (true)
        {
            uint num3;
            int errorCode = this.interface65_0.imethod_0((ulong) num2, buffer, 0x8000, out num3);
            if (errorCode != 0)
            {
                throw new ExternalException(BookmarkStart.b("戶圸娺弼匾⑀捂ㅄ⡆楈㥊⡌⹎㕐獒㝔⹖ⵘ㹚⹜罞ݠᅢ੤੦䥨≪Ⅼnተᡲ㝴๶൸Ṻ๼", num), errorCode);
            }
            A_0.Write(buffer, 0, (int) num3);
            if (num3 < 0x8000)
            {
                return;
            }
            num2 += 0x8000L;
        }
    }

    public string method_18(string A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("否崨太縬嬮䌰嘲吴娶眸娺值娾", num));
        }
        if (A_0.Length == 0)
        {
            throw new ArgumentException(BookmarkStart.b("否崨太縬嬮䌰嘲吴娶眸娺值娾慀湂敄㑆㵈㥊⑌ⅎ㙐獒㙔㙖㝘㕚㉜⭞䅠Ţd䝦౨٪ᵬ᭮ࡰ嵲", num));
        }
        int num2 = 0;
        int count = this.list_0.Count;
        while (num2 < count)
        {
            string strA = this.list_0[num2];
            if (string.Compare(strA, A_0, true) == 0)
            {
                return strA;
            }
            num2++;
        }
        return null;
    }

    public bool method_19(string A_0)
    {
        if ((A_0 != null) && (A_0.Length != 0))
        {
            int num = 0;
            int count = this.list_0.Count;
            while (num < count)
            {
                if (this.list_0[num].Equals(A_0))
                {
                    return true;
                }
                num++;
            }
        }
        return false;
    }

    public string[] method_2()
    {
        return this.list_1.ToArray();
    }

    public bool method_20(string A_0)
    {
        if ((A_0 != null) && (A_0.Length != 0))
        {
            int num = 0;
            int count = this.list_1.Count;
            while (num < count)
            {
                if (this.list_1[num].Equals(A_0))
                {
                    return true;
                }
                num++;
            }
        }
        return false;
    }

    public int method_21(string A_0)
    {
        return this.interface40_0.imethod_9(A_0);
    }

    private void method_22()
    {
        int num = 14;
        if (this.interface40_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜳䈵圷䠹崻夽┿", num), BookmarkStart.b("朳䈵圷䠹崻夽┿扁⩃⥅㱇橉╋⁍㥏♑㵓㝕㑗㍙♛㭝џ", num));
        }
    }

    private void method_23()
    {
        int num = 9;
        if (this.interface39_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("簮䔰䄲倴嘶吸", num), BookmarkStart.b("簮䔰吲ᔴ搶䴸䤺堼帾ⱀ捂⭄⡆㵈歊⑌ⅎ㡐❒㱔㙖㕘㉚❜㩞ՠ", num));
        }
    }

    private long method_24()
    {
        this.method_23();
        long offset = this.Seek(0L, SeekOrigin.Current);
        long num2 = this.Seek(0L, SeekOrigin.End);
        this.Seek(offset, SeekOrigin.Begin);
        return num2;
    }

    private List<string> method_25()
    {
        List<string> list = new List<string>();
        this.method_31(new Delegate7(this.method_28), list);
        return list;
    }

    private List<string> method_26()
    {
        List<string> list = new List<string>();
        this.method_31(new Delegate7(this.method_29), list);
        return list;
    }

    private void method_27()
    {
        this.list_1.Clear();
        this.list_0.Clear();
        this.method_31(new Delegate7(this.method_30), null);
    }

    private void method_28(Struct3 A_0, object A_1)
    {
        if (A_0.stgty_0 == STGTY.STGTY_STREAM)
        {
            ((List<string>) A_1).Add(A_0.string_0);
        }
    }

    private void method_29(Struct3 A_0, object A_1)
    {
        if (A_0.stgty_0 == STGTY.STGTY_STORAGE)
        {
            ((List<string>) A_1).Add(A_0.string_0);
        }
    }

    public Interface40 method_3()
    {
        return this.interface40_0;
    }

    private void method_30(Struct3 A_0, object A_1)
    {
        if (A_0.stgty_0 == STGTY.STGTY_STREAM)
        {
            if (this.list_0 != null)
            {
                this.list_0.Add(A_0.string_0);
            }
        }
        else if ((A_0.stgty_0 == STGTY.STGTY_STORAGE) && (this.list_1 != null))
        {
            this.list_1.Add(A_0.string_0);
        }
    }

    private void method_31(Delegate7 A_0, object A_1)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("到刲头嬶尸䤺", num));
        }
        this.method_22();
        Interface38 interface2 = null;
        int errorCode = this.interface40_0.imethod_8(0, IntPtr.Zero, 0, ref interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("戰䜲䜴制堸嘺ᴼ稾⽀㙂⡄≆㭈⩊㥌♎㹐㵒畔ᡖ⥘㹚⽜㹞ᕠ੢੤०䥨൪౬ٮᵰᙲᅴ", num), errorCode);
        }
        if (interface2 == null)
        {
            throw new SystemException(BookmarkStart.b("爰刲嬴夶嘸伺ᴼ堾⑀㝂敄ๆై╊㡌≎ɐݒᑔ͖੘ཚᩜ罞ࡠൢᅤɦ᭨൪౬౮ᑰ卲ݴቶὸṺོᅾꖄﮈ꾎杖ﲚ", num));
        }
        errorCode = interface2.imethod_2();
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("戰䜲䜴制堸嘺ᴼ稾⽀㙂⡄≆㭈⩊㥌♎㹐㵒畔ᡖ⥘㹚⽜㹞ᕠ੢੤०䥨൪౬ٮᵰᙲᅴ", num), errorCode);
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
            throw new ExternalException(BookmarkStart.b("戰䜲䜴制堸嘺ᴼ稾⽀㙂⡄≆㭈⩊㥌♎㹐㵒畔ᡖ⥘㹚⽜㹞ᕠ੢੤०䥨൪౬ٮᵰᙲᅴ", num), errorCode);
        }
        if (interface2 != null)
        {
            Marshal.FinalReleaseComObject(interface2);
            GC.SuppressFinalize(interface2);
            interface2 = null;
        }
    }

    public Interface39 method_4()
    {
        return this.interface39_0;
    }

    public string method_5()
    {
        return this.string_1;
    }

    public string method_6()
    {
        return this.string_2;
    }

    public Interface65 method_7()
    {
        return this.interface65_0;
    }

    public string method_8()
    {
        return this.string_0;
    }

    public void method_9(string A_0)
    {
        this.method_10(A_0, STGM.STGM_SHARE_EXCLUSIVE);
    }

    public static void smethod_0(Stream12 A_0, Stream12 A_1)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("帬䀮䐰䄲嘴制", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䤬䨮䈰䜲尴夶堸伺吼倾⽀", num));
        }
        string str = A_0.method_6();
        if (str == null)
        {
            throw new ArgumentException(BookmarkStart.b("縬䀮䐰䄲嘴制ᤸ强刼娾㉀捂⭄⡆㵈歊⹌⁎㽐❒㑔㹖㝘筚㉜⽞Ѡൢdͦ䥨ᡪᡬ൮屰rŴᡶ୸᩺᩼᩾", num));
        }
        using (Stream12 stream = !A_1.method_20(str) ? A_1.method_13(str) : A_1.method_11(str))
        {
            A_0.method_3().imethod_4(0, IntPtr.Zero, IntPtr.Zero, stream.method_3());
            A_1.method_3().imethod_6(0);
        }
    }

    public static Stream12 smethod_1(string A_0)
    {
        Interface40 interface2;
        int num2 = 15;
        int errorCode = Class359.StgCreateDocfile(A_0, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE, 0, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("瘴嘶圸唺刼䬾慀⁂㝄≆⡈㽊⡌潎㉐㱒㡔❖㙘⹚㍜㭞䅠բ౤୦౨䕪", num2), errorCode);
        }
        return new Stream12 { interface40_0 = interface2 };
    }

    public static Stream12 smethod_2()
    {
        Interface65 interface2;
        Interface40 interface3;
        int num = 15;
        int errorCode = Class359.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("瘴嘶圸᰺䤼Ἶ≀ㅂ⁄♆㵈⹊浌͎㹐げ㹔ᕖ⁘⽚㡜ⱞ你", num), errorCode);
        }
        errorCode = Class359.StgCreateDocfileOnILockBytes(interface2, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE, 0, out interface3);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("瘴嘶圸᰺䤼Ἶ≀ㅂ⁄♆㵈⹊浌㱎═㱒❔㙖㹘㹚絜ぞའ䍢Ɽ⭦٨ࡪ٬⵮ࡰݲၴѶ坸", num), errorCode);
        }
        return new Stream12 { interface40_0 = interface3, interface65_0 = interface2 };
    }

    void Stream.Close()
    {
        base.Close();
        if (this.interface39_0 != null)
        {
            this.interface39_0.imethod_5(0);
            Marshal.FinalReleaseComObject(this.interface39_0);
            GC.SuppressFinalize(this.interface39_0);
            this.interface39_0 = null;
        }
        this.string_1 = null;
    }

    void Stream.Flush()
    {
        this.vmethod_0(STGC.STGC_DEFAULT);
        if (this.interface65_0 != null)
        {
            this.interface65_0.imethod_2();
        }
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刯䜱刳倵崷䠹", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("弯吱刳䔵崷丹", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("匯崱䄳堵䰷", num));
        }
        if ((A_0.Length - A_1) < A_2)
        {
            throw new ArgumentException(BookmarkStart.b("礯就䈳圵吷匹堻ḽ⼿⑁≃⍅㭇㹉汋⅍≏牑㝓㥕ⵗ㑙⡛繝ᙟ͡ࡣ፥൧ᥩ䉫", num));
        }
        this.method_23();
        if (this.long_0 == this.long_1)
        {
            return 0;
        }
        uint num2 = 0;
        uint num3 = (uint) A_2;
        byte[] buffer = (A_1 > 0) ? new byte[A_2] : A_0;
        int errorCode = this.interface39_0.imethod_0(buffer, num3, ref num2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("戯圱唳刵ᠷ甹䰻嬽㈿⍁ぃ⽅❇⑉汋⡍ㅏ㭑㡓㍕㱗", num), errorCode);
        }
        if (A_1 > 0)
        {
            Buffer.BlockCopy(buffer, 0, A_0, A_1, (int) num2);
        }
        this.long_1 += num2;
        return (int) num2;
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        long num;
        int num3 = 4;
        this.method_23();
        int errorCode = this.interface39_0.imethod_2(A_0, A_1, out num);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("礩䤫䬭嬯ሱ笳䘵崷䠹崻䨽⤿ⵁ⩃晅⹇⭉╋≍㕏㙑穓", num3), errorCode);
        }
        this.long_1 = num;
        return this.long_1;
    }

    void Stream.SetLength(long A_0)
    {
        int num2 = 10;
        this.method_23();
        int errorCode = this.interface39_0.imethod_3((ulong) A_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("振圱䀳稵崷吹嬻䨽⠿扁ୃ㙅ⵇ㡉ⵋ㩍㥏㵑㩓癕㹗㭙㕛㉝՟١", num2), errorCode);
        }
        this.long_0 = A_0;
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        int num = 8;
        if (!this.CanWrite)
        {
            throw new ArgumentException(BookmarkStart.b("紭䐯䀱儳圵唷ᨹ唻倽怿၁⅃❅ⱇՉ≋≍⥏牑㥓㥕㱗㽙牛繝㝟ၡୣࡥཧ䩩⍫ṭᕯqᕳɵᅷᕹቻ偽", num));
        }
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䰭䔯吱刳匵䨷", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䄭嘯吱䜳匵䰷", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䴭弯䜱娳䈵", num));
        }
        if ((A_0.Length - A_1) < A_2)
        {
            throw new ArgumentException(BookmarkStart.b("札帯䐱唳娵儷帹᰻儽☿⑁⅃㕅㱇橉⍋㱍灏ㅑ㭓⍕㙗⹙籛⡝ş๡ᅣͥ᭧䑩", num));
        }
        this.method_23();
        uint num3 = (uint) A_2;
        uint num2 = 0;
        byte[] destinationArray = (A_1 > 0) ? new byte[A_2] : A_0;
        if (A_1 > 0)
        {
            Array.Copy(A_0, A_1, destinationArray, 0, A_2);
        }
        int errorCode = this.interface39_0.imethod_1(destinationArray, num3, ref num2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("礭䈯嬱䀳匵ᠷ甹䰻嬽㈿⍁ぃ⽅❇⑉汋⡍ㅏ㭑㡓㍕㱗", num), errorCode);
        }
        this.long_1 += num2;
        if (this.long_0 < this.long_1)
        {
            this.long_0 = this.long_1;
        }
    }

    public virtual void vmethod_0(STGC A_0)
    {
        int num = 9;
        if ((this.stgm_6 & STGM.STGM_TRANSACTED) == STGM.STGM_TRANSACTED)
        {
            this.method_23();
            int errorCode = this.interface39_0.imethod_5((uint) A_0);
            if (errorCode != 0)
            {
                throw new ExternalException(BookmarkStart.b("氮帰帲場帶䴸ᬺ爼伾⑀ㅂ⑄㍆⁈⑊⍌潎㝐㉒㱔㭖㱘㽚", num), errorCode);
            }
        }
        this.interface40_0.imethod_6((uint) A_0);
    }

    public virtual void vmethod_1()
    {
        int num = 4;
        if ((this.stgm_6 & STGM.STGM_TRANSACTED) == STGM.STGM_TRANSACTED)
        {
            this.method_23();
            int errorCode = this.interface39_0.imethod_6();
            if (errorCode != 0)
            {
                throw new ExternalException(BookmarkStart.b("砩䤫堭唯䀱䀳ᘵ眷䨹夻䰽ℿ㙁ⵃ⥅♇橉⩋⽍㥏㹑ㅓ㉕", num), errorCode);
            }
        }
    }

    bool Stream.CanRead
    {
        get
        {
            return this.bool_1;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return this.bool_3;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            return this.bool_2;
        }
    }

    long Stream.Length
    {
        get
        {
            return this.long_0;
        }
    }

    long Stream.Position
    {
        get
        {
            return this.long_1;
        }
        set
        {
            this.Seek(value, SeekOrigin.Begin);
        }
    }

    internal delegate void Delegate7(Struct3 A_0, object A_1);
}

