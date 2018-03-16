using Spire.Doc;
using System;
using System.IO;
using System.Security.Cryptography;

[CLSCompliant(false)]
internal class Class440
{
    private Class299 class299_0 = new Class299();
    private const int int_0 = 0x40004;
    private const int int_1 = 0x40;
    private const int int_2 = 0x1000;

    internal void method_0(Stream A_0, string A_1, Interface61 A_2)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("儴嘶䴸娺", num));
        }
        if ((A_1 == null) || (A_1.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔴嘶䨸䠺䨼倾㍀❂", num));
        }
        this.method_1(A_0, A_2, A_1);
        this.method_5(A_2);
    }

    private void method_1(Stream A_0, Interface61 A_1, string A_2)
    {
        SHA1 sha = new SHA1Managed();
        using (Stream1 stream = A_1.imethod_2(BookmarkStart.b("欭帯儱䘳伵䠷丹唻儽⸿ୁ⩃⁅❇", 8)))
        {
            Class62 class2 = new Class62();
            class2.method_1(0x40004);
            class2.method_3(0x40);
            Class187 class3 = class2.method_4().method_0();
            this.method_3(class3);
            class3.method_15(this.method_10(class3.method_0()));
            Class190 class4 = class2.method_4().method_4().method_0();
            this.method_4(class4);
            class4.method_17(this.method_10(class4.method_2()));
            byte[] buffer = this.method_10(class4.method_2());
            byte[] buffer2 = new byte[] { 0xfe, 0xa7, 210, 0x76, 0x3b, 0x4b, 0x9e, 0x79 };
            byte[] buffer3 = this.class299_0.method_9(A_2, class4.method_16(), buffer2, class4.method_6() >> 3, class4.method_0());
            class4.method_19(this.method_11(buffer, class4.method_4(), buffer3, class4.method_16()));
            byte[] buffer4 = new byte[] { 0xd7, 170, 15, 0x6d, 0x30, 0x61, 0x34, 0x4e };
            buffer3 = this.class299_0.method_9(A_2, class4.method_16(), buffer4, class4.method_6() >> 3, class4.method_0());
            class4.method_21(this.method_11(sha.ComputeHash(buffer), class4.method_4(), buffer3, class4.method_16()));
            byte[] buffer5 = this.method_10(class3.method_4() / 8);
            byte[] buffer6 = new byte[] { 20, 110, 11, 0xe7, 0xab, 0xac, 0xd0, 0xd6 };
            buffer3 = this.class299_0.method_9(A_2, class4.method_16(), buffer6, class4.method_6() >> 3, class4.method_0());
            class4.method_23(this.method_11(buffer5, class4.method_4(), buffer3, class4.method_16()));
            Class188 class5 = class2.method_4().method_2();
            byte[] buffer7 = new byte[] { 0x5f, 0xb2, 0xad, 1, 12, 0xb9, 0xe1, 0xf6 };
            byte[] buffer8 = sha.ComputeHash(this.class299_0.method_12(class3.method_14(), buffer7));
            buffer8 = this.class299_0.method_13(buffer8, class3.method_2(), 0);
            byte[] buffer9 = this.method_10(class3.method_6());
            class5.method_1(this.method_11(buffer9, class3.method_2(), buffer5, buffer8));
            byte[] buffer10 = this.method_2(A_0, A_1, class3, buffer5);
            HMACSHA1 hmacsha = new HMACSHA1 {
                Key = this.class299_0.method_13(buffer9, class3.method_6(), 0)
            };
            byte[] buffer11 = new byte[] { 160, 0x67, 0x7f, 2, 0xb2, 0x2c, 0x84, 0x33 };
            byte[] buffer12 = sha.ComputeHash(this.class299_0.method_12(class3.method_14(), buffer11));
            buffer12 = this.class299_0.method_13(buffer12, class3.method_2(), 0);
            class5.method_3(this.method_11(hmacsha.ComputeHash(buffer10), class3.method_2(), buffer5, buffer12));
            class2.method_5(stream);
        }
    }

    private byte[] method_10(int A_0)
    {
        int num = 0x13;
        if (A_0 <= 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("唸帺匼堾㕀⭂", num));
        }
        byte[] buffer = new byte[A_0];
        Random random = new Random((int) DateTime.Now.Ticks);
        int maxValue = 0x100;
        for (int i = 0; i < A_0; i++)
        {
            buffer[i] = (byte) random.Next(maxValue);
        }
        return buffer;
    }

    private byte[] method_11(byte[] A_0, int A_1, byte[] A_2, byte[] A_3)
    {
        byte[] buffer;
        int length = A_0.Length;
        if ((length % A_1) != 0)
        {
            length = ((length / A_1) + 1) * A_1;
            buffer = this.class299_0.method_13(A_0, length, 0);
        }
        else
        {
            buffer = A_0;
        }
        byte[] dst = new byte[length];
        byte[] buffer2 = new byte[A_1];
        byte[] buffer3 = new byte[A_1];
        Class441 class2 = new Class441(Class441.KeySize.Bits128, A_2);
        for (int i = 0; i < length; i += A_1)
        {
            Buffer.BlockCopy(buffer, i, buffer2, 0, A_1);
            if (i == 0)
            {
                buffer2 = this.class299_0.method_14(buffer2, A_3);
            }
            else
            {
                buffer2 = this.class299_0.method_14(buffer2, buffer3);
            }
            class2.method_1(buffer2, buffer3);
            Buffer.BlockCopy(buffer3, 0, dst, i, A_1);
        }
        return dst;
    }

    private byte[] method_2(Stream A_0, Interface61 A_1, Class187 A_2, byte[] A_3)
    {
        byte[] bytes = BitConverter.GetBytes(A_0.Length);
        SHA1 sha = new SHA1Managed();
        using (Stream1 stream = A_1.imethod_2(BookmarkStart.b("漩䈫䴭䈯䬱䐳䈵崷帹氻弽⌿⥁╃ⅅⵇ", 4)))
        {
            int num = (int) (A_0.Length / 0x1000L);
            if ((A_0.Length % 0x1000L) != 0L)
            {
                num++;
            }
            for (int i = 0; i < num; i++)
            {
                int count = Math.Min(0x1000, ((int) A_0.Length) - (i * 0x1000));
                byte[] buffer = new byte[count];
                byte[] buffer3 = new byte[count];
                A_0.Read(buffer, 0, count);
                byte[] buffer4 = sha.ComputeHash(this.class299_0.method_12(A_2.method_14(), BitConverter.GetBytes(i)));
                buffer3 = this.method_11(buffer, A_2.method_2(), A_3, buffer4);
                bytes = this.class299_0.method_12(bytes, buffer3);
            }
            stream.Write(bytes, 0, bytes.Length);
        }
        return bytes;
    }

    private void method_3(Class187 A_0)
    {
        A_0.method_1(0x10);
        A_0.method_3(0x10);
        A_0.method_5(0x80);
        A_0.method_7(20);
        A_0.method_9(BookmarkStart.b("爲瀴搶", 13));
        A_0.method_11(BookmarkStart.b("瀲崴嘶倸唺吼儾♀โ⩄⍆ⱈࡊཌ౎", 13));
        A_0.method_13(BookmarkStart.b("怲紴瘶࠸", 13));
    }

    private void method_4(Class190 A_0)
    {
        A_0.method_1(0x186a0);
        A_0.method_3(0x10);
        A_0.method_5(0x10);
        A_0.method_7(0x80);
        A_0.method_9(20);
        A_0.method_11(BookmarkStart.b("昦氨砪", 1));
        A_0.method_13(BookmarkStart.b("搦䄨䨪䐬䄮堰崲刴稶嘸强堼簾̀B", 1));
        A_0.method_15(BookmarkStart.b("琦愨横ᰬ", 1));
    }

    private void method_5(Interface61 A_0)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弬䀮帰䜲", num));
        }
        using (Interface61 interface2 = A_0.imethod_4(BookmarkStart.b("⬬欮倰䜲吴搶䤸娺帼娾㉀", num)))
        {
            this.method_8(interface2);
            this.method_7(interface2);
            this.method_6(interface2);
            this.method_9(interface2);
        }
    }

    private void method_6(Interface61 A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尷嬹䠻弽ጿ㉁╃╅ⵇ㥉", num));
        }
        using (Stream1 stream = A_0.imethod_2(BookmarkStart.b("渷弹主䴽⤿ⵁ⩃", num)))
        {
            new Class666().method_8(stream);
        }
    }

    private void method_7(Interface61 A_0)
    {
        int num = 8;
        using (Interface61 interface2 = A_0.imethod_4(BookmarkStart.b("稭䈯匱娳䔵帷唹主匽िⱁ≃⥅", 8)))
        {
            using (Interface61 interface3 = interface2.imethod_4(BookmarkStart.b("紭䐯䀱嬳堵強缹刻崽㈿㭁㑃㉅ⅇ╉≋ᩍ≏㍑㩓╕㹗㕙⹛㍝", num)))
            {
                using (Stream1 stream = interface3.imethod_2(BookmarkStart.b("⠭怯䀱崳嬵夷䠹䔻", num)))
                {
                    Class610 class2 = new Class610();
                    class2.method_1(1);
                    class2.method_3(BookmarkStart.b("唭瘯琱ള眵ଷ簹఻ഽ洿睁牃ͅ็杉硋硍慏慑祓ᑕ᱗ṙ楛獝啟⍡偣坥⭧孩⡫幭䝯䁱䁳䁵շ", num));
                    class2.method_5(BookmarkStart.b("挭夯儱䘳夵䬷唹娻䨽渿Ł⭃⡅㱇⭉╋⁍㕏⁑穓ፕ㙗㥙⹛❝ၟᙡൣ॥٧㹩ṫ཭ṯűታ᥵੷᝹", num));
                    class2.method_7(1);
                    class2.method_9(1);
                    class2.method_11(1);
                    class2.method_12(stream);
                    Class1072 class3 = new Class1072();
                    class3.method_1(string.Empty);
                    class3.method_6(stream);
                }
            }
        }
    }

    private void method_8(Interface61 A_0)
    {
        int num = 11;
        using (Interface61 interface2 = A_0.imethod_4(BookmarkStart.b("田刲䄴嘶樸䬺尼尾⑀ੂ⭄ⅆ♈", 11)))
        {
            using (Stream1 stream = interface2.imethod_2(BookmarkStart.b("戰䜲䜴堶圸尺砼儾≀ㅂ㱄㝆㵈≊≌ⅎᕐ㉒⅔㙖੘⭚㱜㱞Ѡ", num)))
            {
                Class300 class2 = new Class300();
                class2.method_0().Add(BookmarkStart.b("戰䜲䜴堶圸尺砼儾≀ㅂ㱄㝆㵈≊≌ⅎՐ⅒㑔㥖⩘㵚㉜ⵞౠ", num));
                class2.method_1(stream);
            }
        }
    }

    private void method_9(Interface61 A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䠫伭䐯匱朳䘵夷夹夻䴽", num));
        }
        Class876 class2 = new Class876();
        Class362 item = new Class362();
        Class541 class4 = new Class541(0, BookmarkStart.b("椫䀭匯䀱䴳䘵䰷弹堻渽ℿ⅁⽃❅⽇⽉", num));
        class2.method_0().Add(item);
        item.method_0().Add(class4);
        item.method_2(BookmarkStart.b("缫娭䈯崱娳儵紷吹弻䰽㤿㉁ぃ⽅❇⑉ࡋ⽍⑏㍑ݓ♕㥗㥙㥛", num));
        using (Stream1 stream = A_0.imethod_2(BookmarkStart.b("栫伭䐯匱朳䘵夷夹夻猽ℿ㉁", num)))
        {
            class2.method_1(stream);
        }
    }
}

