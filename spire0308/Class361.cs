using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

[CLSCompliant(false)]
internal class Class361
{
    private byte[] byte_0;
    private Class299 class299_0 = new Class299();
    private Class540 class540_0;
    private Class876 class876_0;
    private int int_0 = 0x10;
    private Interface61 interface61_0;

    internal Stream method_0()
    {
        int num = 0x11;
        if (this.byte_0 == null)
        {
            throw new InvalidOperationException(BookmarkStart.b("縶圸堺刼䴾㍀♂♄㍆楈㭊ⱌ㱎≐⑒㩔╖㵘畚", num));
        }
        MemoryStream stream2 = new MemoryStream();
        using (Stream1 stream = this.interface61_0.imethod_0(BookmarkStart.b("父圸堺似䘾ㅀ㝂⁄⍆᥈⩊⹌⑎ぐ㑒ご", num)))
        {
            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, 8);
            int count = BitConverter.ToInt32(buffer, 0);
            int num3 = count % this.int_0;
            int num4 = (num3 > 0) ? ((count + this.int_0) - num3) : count;
            byte[] buffer2 = new byte[num4];
            stream.Read(buffer2, 0, num4);
            byte[] buffer3 = this.method_4(buffer2, this.byte_0);
            stream2.Write(buffer3, 0, count);
            stream2.Position = 0L;
        }
        return stream2;
    }

    internal void method_1(Interface61 A_0)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈰䜲娴䔶堸尺堼", num));
        }
        this.interface61_0 = A_0;
        using (Stream stream = A_0.imethod_0(BookmarkStart.b("琰崲嘴䔶䀸䬺䤼嘾⹀ⵂౄ⥆⽈⑊", num)))
        {
            this.class540_0 = new Class540(stream);
        }
        using (Interface61 interface2 = A_0.imethod_5(BookmarkStart.b("㜰眲吴䌶堸栺䴼帾≀♂㙄", num)))
        {
            this.method_6(interface2);
            this.method_5(interface2);
        }
    }

    internal bool method_2(string A_0)
    {
        Class709 class2 = this.class540_0.method_7();
        this.byte_0 = this.method_3(A_0, class2);
        return (this.byte_0 != null);
    }

    private byte[] method_3(string A_0, Class709 A_1)
    {
        byte[] buffer = A_1.method_0();
        byte[] buffer2 = this.class299_0.method_7(A_0, buffer, 0x10);
        byte[] buffer3 = this.method_4(A_1.method_2(), buffer2);
        this.method_4(A_1.method_4(), buffer2);
        new SHA1Managed().ComputeHash(buffer3);
        return buffer2;
    }

    private byte[] method_4(byte[] A_0, byte[] A_1)
    {
        Class441 class2 = new Class441(Class441.KeySize.Bits128, A_1);
        return this.class299_0.method_11(A_0, new Class299.Delegate2(class2.method_2), A_1.Length);
    }

    private void method_5(Interface61 A_0)
    {
        int num = 13;
        List<Class362> list = this.class876_0.method_0();
        if (list.Count != 1)
        {
            throw new Exception(BookmarkStart.b("稲嬴䄶堸场吼嬾慀❂⑄㍆⡈", num));
        }
        string str = list[0].method_1();
        string str2 = null;
        using (Interface61 interface3 = A_0.imethod_5(BookmarkStart.b("眲吴䌶堸栺䴼帾≀♂ౄ⥆⽈⑊", num)))
        {
            using (Stream stream = interface3.imethod_0(str))
            {
                List<string> list2 = new Class300(stream).method_0();
                if (list2.Count != 1)
                {
                    throw new Exception(BookmarkStart.b("稲嬴䄶堸场吼嬾慀❂⑄㍆⡈", num));
                }
                str2 = list2[0];
            }
        }
        using (Interface61 interface2 = A_0.imethod_5(BookmarkStart.b("朲䜴嘶圸䠺嬼倾㍀⹂ౄ⥆⽈⑊", num)))
        {
            using (Interface61 interface4 = interface2.imethod_5(str2))
            {
                this.method_7(interface4);
            }
        }
    }

    private void method_6(Interface61 A_0)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("圲吴䌶堸栺䴼帾≀♂㙄", num));
        }
        using (Stream1 stream = A_0.imethod_0(BookmarkStart.b("眲吴䌶堸栺䴼帾≀♂ࡄ♆㥈", num)))
        {
            this.class876_0 = new Class876(stream);
        }
    }

    private void method_7(Interface61 A_0)
    {
        using (Stream stream = A_0.imethod_0(BookmarkStart.b("⨫縭䈯嬱夳圵䨷䌹", 6)))
        {
            new Class610(stream);
            new Class1072(stream);
        }
    }
}

