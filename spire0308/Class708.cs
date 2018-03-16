using Spire.Doc;
using System;
using System.IO;
using System.Security.Cryptography;

[CLSCompliant(false)]
internal class Class708
{
    private Class299 class299_0 = new Class299();
    private const int int_0 = 0x10;
    private const int int_1 = 0x20003;
    private const int int_2 = 0x24;
    private const int int_3 = 0x660e;
    private const int int_4 = 0x8004;
    private const int int_5 = 0x18;
    private const string string_0 = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";

    internal void method_0(Stream A_0, string A_1, Interface61 A_2)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伪䰬嬮倰", num));
        }
        if ((A_1 != null) && (A_1.Length != 0))
        {
            byte[] buffer = this.method_6(A_2, A_1);
            this.method_1(A_2);
            using (Stream1 stream = A_2.imethod_2(BookmarkStart.b("渪䌬䰮䌰䨲䔴䌶尸强洼帾≀⡂⑄⁆ⱈ", num)))
            {
                byte[] bytes = BitConverter.GetBytes(A_0.Length);
                stream.Write(bytes, 0, 8);
                this.method_9(A_0, buffer, stream);
                return;
            }
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("嬪䰬尮䈰䐲娴䔶崸", num));
    }

    private void method_1(Interface61 A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吥䜧䔩堫", num));
        }
        using (Interface61 interface2 = A_0.imethod_4(BookmarkStart.b("‥氧䬩堫伭振䈱唳唵崷䤹", num)))
        {
            this.method_4(interface2);
            this.method_3(interface2);
            this.method_2(interface2);
            this.method_5(interface2);
        }
    }

    private void method_2(Interface61 A_0)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨭儯䘱唳攵䠷嬹弻嬽㌿", num));
        }
        using (Stream1 stream = A_0.imethod_2(BookmarkStart.b("砭唯䀱䜳張圷吹", num)))
        {
            new Class666().method_8(stream);
        }
    }

    private void method_3(Interface61 A_0)
    {
        int num = 6;
        using (Interface61 interface2 = A_0.imethod_4(BookmarkStart.b("砫尭儯就䜳倵圷䠹儻眽⸿⑁⭃", 6)))
        {
            using (Interface61 interface3 = interface2.imethod_4(BookmarkStart.b("缫娭䈯崱娳儵紷吹弻䰽㤿㉁ぃ⽅❇⑉ᡋ㱍ㅏ㱑❓さ㝗⡙ㅛ", num)))
            {
                using (Stream1 stream = interface3.imethod_2(BookmarkStart.b("⨫縭䈯嬱夳圵䨷䌹", num)))
                {
                    Class610 class2 = new Class610();
                    class2.method_1(1);
                    class2.method_3(BookmarkStart.b("圫栭瘯଱申Ե縷ਹ༻ጽ甿瑁ŃE敇繉穋罍捏网ᙓቕ᱗潙煛歝⅟噡啣╥奧⹩屫奭䉯䙱䉳୵", num));
                    class2.method_5(BookmarkStart.b("愫䜭匯䀱嬳䔵圷尹䠻ွ̿ⵁ⩃㉅⥇⍉≋⭍≏籑ᅓ㡕㭗⡙╛⹝ᑟୡୣࡥ㱧ᡩ൫mͯᑱ᭳ѵᕷ", num));
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

    private void method_4(Interface61 A_0)
    {
        int num = 8;
        using (Interface61 interface2 = A_0.imethod_4(BookmarkStart.b("樭儯䘱唳攵䠷嬹弻嬽िⱁ≃⥅", 8)))
        {
            using (Stream1 stream = interface2.imethod_2(BookmarkStart.b("紭䐯䀱嬳堵強缹刻崽㈿㭁㑃㉅ⅇ╉≋੍ㅏ♑㕓Օ⡗㭙㽛㭝", num)))
            {
                Class300 class2 = new Class300();
                class2.method_0().Add(BookmarkStart.b("紭䐯䀱嬳堵強缹刻崽㈿㭁㑃㉅ⅇ╉≋ᩍ≏㍑㩓╕㹗㕙⹛㍝", num));
                class2.method_1(stream);
            }
        }
    }

    private void method_5(Interface61 A_0)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("倳圵䰷嬹漻丽ℿ⅁⅃㕅", num));
        }
        Class876 class2 = new Class876();
        Class362 item = new Class362();
        Class541 class4 = new Class541(0, BookmarkStart.b("焳堵嬷䠹䔻丽㐿❁⁃ᙅ⥇⥉❋⽍㝏㝑", num));
        class2.method_0().Add(item);
        item.method_0().Add(class4);
        item.method_2(BookmarkStart.b("朳䈵䨷唹刻夽Կⱁ❃㑅ㅇ㩉㡋❍㽏㱑ၓ㝕ⱗ㭙ཛ⹝şšţ", num));
        using (Stream1 stream = A_0.imethod_2(BookmarkStart.b("瀳圵䰷嬹漻丽ℿ⅁⅃୅⥇㩉", num)))
        {
            class2.method_1(stream);
        }
    }

    private byte[] method_6(Interface61 A_0, string A_1)
    {
        int num = 0;
        byte[] buffer = this.method_7(0x10);
        byte[] buffer2 = this.class299_0.method_7(A_1, buffer, 0x10);
        byte[] buffer3 = this.method_7(0x10);
        SHA1 sha = new SHA1Managed();
        using (Stream1 stream = A_0.imethod_2(BookmarkStart.b("挥䘧䤩師圭䀯䘱崳夵嘷猹刻堽⼿", 0)))
        {
            Class540 class2 = new Class540();
            class2.method_1(0x20003);
            class2.method_5(0x24);
            Class494 class3 = class2.method_6();
            class3.method_1(0x24);
            class3.method_9(0x660e);
            class3.method_11(0x8004);
            class3.method_13(0x80);
            class3.method_15(0x18);
            class3.method_17(0);
            class3.method_19(0);
            class3.method_21(BookmarkStart.b("欥䄧䤩師䄭䌯崱刳䈵ᠷ缹刻嘽ℿⱁ❃⍅ⱇ橉ṋᵍᅏ牑㕓㡕㱗穙ᵛ᭝㍟䉡❣ᑥᅧᩩᡫŭᝯqᕳٵၷ፹ύ幽큿ﲍ낏몑쒓\ud99f\ud2a1솣辥", num));
            Class709 class4 = class2.method_7();
            class4.method_1(buffer);
            class4.method_3(this.method_8(buffer3, buffer2));
            byte[] buffer4 = sha.ComputeHash(buffer3);
            int num2 = buffer4.Length % 0x10;
            class4.method_7(buffer4.Length);
            if (num2 != 0)
            {
                buffer4 = this.class299_0.method_12(buffer4, new byte[0x10 - num2]);
            }
            class4.method_5(this.method_8(buffer4, buffer2));
            class2.method_8(stream);
        }
        return buffer2;
    }

    private byte[] method_7(int A_0)
    {
        int num = 5;
        if (A_0 <= 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜪䠬䄮嘰䜲崴", num));
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

    private byte[] method_8(byte[] A_0, byte[] A_1)
    {
        Class441 class2 = new Class441(Class441.KeySize.Bits128, A_1);
        return this.class299_0.method_11(A_0, new Class299.Delegate2(class2.method_1), A_1.Length);
    }

    private void method_9(Stream A_0, byte[] A_1, Stream A_2)
    {
        Class441 class2 = new Class441(Class441.KeySize.Bits128, A_1);
        byte[] buffer = new byte[0x10];
        byte[] buffer2 = new byte[0x10];
        while (A_0.Read(buffer, 0, 0x10) > 0)
        {
            class2.method_1(buffer, buffer2);
            A_2.Write(buffer2, 0, 0x10);
        }
    }
}

