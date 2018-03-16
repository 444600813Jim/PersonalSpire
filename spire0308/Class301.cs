using Spire.Doc;
using System;
using System.Runtime.InteropServices;

internal class Class301
{
    [ThreadStatic]
    private static Class301 class301_0;
    private const int int_0 = 0x2024;
    private const int int_1 = 0x400;
    private const int int_2 = 0x7fffffff;
    private int int_3;
    private IntPtr intptr_0;
    private const string string_0 = "Application was unable to allocate memory block";

    internal Class301() : this(0x2024)
    {
    }

    internal Class301(int A_0)
    {
        int num = 2;
        if (A_0 < 0x400)
        {
            A_0 = 0x400;
        }
        this.intptr_0 = Marshal.AllocCoTaskMem(A_0);
        this.int_3 = A_0;
        if (this.intptr_0.ToInt64() == 0L)
        {
            throw new OutOfMemoryException(BookmarkStart.b("椧娩尫䈭夯儱唳䈵儷唹刻ḽ㜿⍁㝃晅㵇⑉ⵋⱍ㱏㝑瑓≕㝗穙㵛㉝౟ൡݣݥᱧཀྵ䱫ͭᕯά᭳ѵŷ婹ṻች", num));
        }
    }

    internal void method_0(int A_0)
    {
        int num = 12;
        if (A_0 > this.int_3)
        {
            this.intptr_0 = Marshal.ReAllocCoTaskMem(this.intptr_0, A_0);
            this.int_3 = A_0;
            if (this.intptr_0.ToInt64() == 0L)
            {
                throw new OutOfMemoryException(BookmarkStart.b("猱䐳䘵吷匹弻弽㐿⭁⭃⡅桇㵉ⵋ㵍灏❑㩓㝕㩗㙙㥛繝ᑟൡ䑣ݥѧ٩ͫ൭ᅯٱᅳ噵ᕷόᅻᅽﮁꒃ", num));
            }
        }
    }

    internal void method_1(byte[] A_0)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("圵䨷䠹砻弽㐿⍁", num));
        }
        int length = A_0.Length;
        if (length != 0)
        {
            this.method_0(length);
            Marshal.Copy(A_0, 0, this.intptr_0, length);
        }
    }

    internal void method_2(byte[] A_0, int A_1)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刲䜴䔶紸娺䤼帾", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("娲昴䌶堸䤺䤼瘾⽀❂⁄㽆", num));
        }
        int num2 = A_0.Length - A_1;
        if (num2 != 0)
        {
            this.method_0(num2);
            Marshal.Copy(A_0, A_1, this.intptr_0, num2);
        }
    }

    internal void method_3(byte[] A_0, int A_1, int A_2)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䴫尭䈯瘱唳䈵夷", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔫紭䐯匱䘳䈵焷吹堻嬽㠿", num));
        }
        if (A_2 > 0)
        {
            int num2 = A_0.Length - A_1;
            if (num2 < A_2)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䔫洭弯䜱娳䈵ᠷ匹伻ḽ㐿ⵁ⭃晅⑇⭉㹋⥍㕏", num));
            }
            this.method_0(A_2);
            Marshal.Copy(A_0, A_1, this.intptr_0, A_2);
        }
    }

    internal void method_4(object A_0)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("儴制䨸伺吼儾⁀㝂ⱄ⡆❈", num));
        }
        Marshal.PtrToStructure(this.intptr_0, A_0);
    }

    internal void method_5(byte[] A_0, object A_1)
    {
        this.method_1(A_0);
        this.method_4(A_1);
    }

    internal void method_6(byte[] A_0, int A_1, object A_2)
    {
        this.method_2(A_0, A_1);
        this.method_4(A_2);
    }

    internal void method_7(byte[] A_0, int A_1, int A_2, object A_3)
    {
        this.method_3(A_0, A_1, A_2);
        this.method_4(A_3);
    }

    internal void method_8(object A_0, byte[] A_1, int A_2, int A_3)
    {
        int num = 4;
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬩師尭琯圱䜳䈵儷吹崻䨽⤿ⵁ⩃", num));
        }
        if ((A_2 < 0) || (A_2 >= A_1.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌩缫娭儯䀱䀳缵嘷帹夻䘽", num));
        }
        if ((A_2 + A_3) > A_1.Length)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌩怫䬭帯唱䀳帵", num));
        }
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("缩䈫䨭唯䀱堳伵儷吹嬻洽㐿ぁㅃ╅㱇㽉㹋⭍", num));
        }
        this.method_0(A_3);
        Marshal.StructureToPtr(A_0, this.intptr_0, false);
        Marshal.Copy(this.intptr_0, A_1, A_2, A_3);
        Marshal.DestroyStructure(this.intptr_0, A_0.GetType());
    }

    internal static Class301 smethod_0()
    {
        if (class301_0 == null)
        {
            class301_0 = new Class301();
        }
        return class301_0;
    }
}

