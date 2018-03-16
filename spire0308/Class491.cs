using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using System;
using System.IO;
using System.Runtime.InteropServices;

internal class Class491 : Interface51
{
    private Class1003 class1003_0;
    private Class1005 class1005_0;
    private Interface65 interface65_0;

    public Class491()
    {
        this.method_0();
    }

    public Class491(Stream A_0)
    {
        this.method_2(A_0);
    }

    public Class491(string A_0, STGM A_1)
    {
        Interface40 interface2;
        int num = 4;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䰩䔫䈭唯簱唳嬵崷", num));
        }
        if ((A_1 & STGM.STGM_CREATE) == STGM.STGM_DIRECT)
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                this.method_2(stream);
                return;
            }
        }
        Guid guid = new Guid(BookmarkStart.b("ᨩᰫḭ/ȱгص娷᜹఻฽瀿牁楃癅硇穉籋捍ፏ扑摓晕畗橙汛湝偟剡呣噥塧婩屫婭䙯", num));
        int errorCode = Class359.StgCreateStorageEx(A_0, A_1, STGFMT.STGFMT_DOCFILE, 0, IntPtr.Zero, IntPtr.Zero, ref guid, out interface2);
        switch (errorCode)
        {
            case -2147287007:
            case -2147287008:
                throw new Exception9();

            default:
                if (errorCode != 0)
                {
                    throw new ExternalException(BookmarkStart.b("椩䴫䀭帯崱䀳ᘵ圷䨹夻倽怿ㅁぃ⥅㩇⭉⭋⭍繏牑ቓ㽕㑗㽙籛ၝşཡţ䙥ŧᥩ噫乭", num) + A_0, errorCode);
                }
                this.class1005_0 = new Class1005(interface2);
                break;
        }
    }

    public void imethod_4(string A_0)
    {
        using (FileStream stream = new FileStream(A_0, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
        {
            this.Interface51.imethod_3(stream);
        }
    }

    Interface61 Interface51.imethod_0()
    {
        return this.class1005_0;
    }

    Class1003 Interface51.imethod_1()
    {
        return this.class1003_0;
    }

    void Interface51.imethod_2()
    {
        this.class1005_0.Interface61.imethod_8();
        if (this.interface65_0 != null)
        {
            this.interface65_0.imethod_2();
        }
    }

    void Interface51.imethod_3(Stream A_0)
    {
        int num = 2;
        this.Interface51.imethod_2();
        if (this.interface65_0 == null)
        {
            throw new Exception(BookmarkStart.b("簧䈩䤫อ崯圱䀳帵圷帹᰻儽㈿扁⭃㙅ⵇ㡉ⵋ㩍㥏㵑㩓癕ㅗ⥙籛そཟᙡ䑣ཥէᩩk୭ᵯ᝱ᩳɵᵷṹ剻", num));
        }
        this.method_1(A_0);
    }

    private void method_0()
    {
        Interface40 interface2;
        int num = 0x13;
        int errorCode = Class359.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out this.interface65_0);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("稸娺匼ᠾ㕀捂♄㕆ⱈ⩊㥌⩎煐ὒ㩔㑖㉘ᥚ⑜⭞Ѡၢ䭤", num), errorCode);
        }
        errorCode = Class359.StgCreateDocfileOnILockBytes(this.interface65_0, STGM.STGM_CREATE | STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE, 0, out interface2);
        if (errorCode != 0)
        {
            throw new ExternalException(BookmarkStart.b("稸娺匼ᠾ㕀捂♄㕆ⱈ⩊㥌⩎煐⁒⅔㡖⭘㩚㩜㩞䅠ౢ୤䝦⁨❪ɬ౮ᩰㅲ౴Ͷᱸࡺ卼", num), errorCode);
        }
        this.class1005_0 = new Class1005(interface2);
    }

    public void method_1(Stream A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("否崨太䠬丮尰", num));
        }
        if (this.interface65_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨦瘨䜪䈬䰮娰焲䰴䌶尸䠺", num));
        }
        byte[] buffer = new byte[0x8000];
        long num2 = 0L;
        while (true)
        {
            uint num3;
            int errorCode = this.interface65_0.imethod_0((ulong) num2, buffer, 0x8000, out num3);
            if (errorCode != 0)
            {
                throw new ExternalException(BookmarkStart.b("爦䜨䨪伬䌮吰ጲ䄴堶ᤸ䤺堼帾╀捂❄㹆㵈⹊㹌潎㝐⅒㩔㩖祘ቚᅜぞɠࡢ❤Ṧᵨ๪Ṭ", num), errorCode);
            }
            A_0.Write(buffer, 0, (int) num3);
            if (num3 < 0x8000)
            {
                return;
            }
            num2 += 0x8000L;
        }
    }

    private void method_2(Stream A_0)
    {
        uint num2;
        Interface40 interface2;
        int num3 = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔵䰷䠹夻弽ⴿ", num3));
        }
        Class359.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out this.interface65_0);
        int count = (int) (A_0.Length - A_0.Position);
        byte[] buffer = new byte[count];
        A_0.Read(buffer, 0, count);
        this.interface65_0.imethod_1(0L, buffer, (uint) buffer.Length, out num2);
        this.interface65_0.imethod_2();
        Class359.StgOpenStorageOnILockBytes(this.interface65_0, null, STGM.STGM_DIRECT_SWMR | STGM.STGM_SHARE_DENY_NONE, 0, 0, out interface2);
        this.class1005_0 = new Class1005(interface2);
    }

    void IDisposable.Dispose()
    {
        if (this.class1005_0 != null)
        {
            this.class1005_0.System.IDisposable.Dispose();
            this.class1005_0 = null;
            if (this.interface65_0 != null)
            {
                Marshal.FinalReleaseComObject(this.interface65_0);
                GC.SuppressFinalize(this.interface65_0);
                this.interface65_0 = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}

