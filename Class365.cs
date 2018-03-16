using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal class Class365 : Class364
{
    private Class366 class366_0;
    private Class366 class366_1;
    private Class366 class366_2;
    private Class367 class367_0;
    private const int int_0 = 0x2000001;
    private const int int_1 = 0;
    private int int_10;
    private int int_11;
    private int int_12;
    private int int_13;
    private int int_14;
    private int int_15;
    private int int_16;
    private int int_17;
    private int int_18;
    private int int_19;
    private const int int_2 = 20;
    private const int int_3 = -1;
    private const int int_4 = 8;
    private const int int_5 = 1;
    private int int_6;
    private int int_7;
    private int int_8;
    private int int_9;
    private OleLinkType oleLinkType_0;
    private string string_0;

    internal Class365(Stream1 A_0)
    {
        this.string_0 = string.Empty;
        byte[] buffer = new byte[A_0.Length];
        A_0.Read(buffer, 0, buffer.Length);
        this.vmethod_0(buffer, 0);
    }

    internal Class365(OleLinkType A_0, string A_1)
    {
        this.string_0 = string.Empty;
        this.oleLinkType_0 = A_0;
        this.int_7 = 0x2000001;
        this.int_10 = 0;
        this.int_11 = 0;
        if (A_0 == OleLinkType.Embed)
        {
            this.int_8 = 8;
        }
        else
        {
            this.int_8 = 1;
            this.string_0 = A_1;
            this.int_9 = 3;
        }
    }

    internal void method_0(Stream1 A_0)
    {
        int num = 0;
        byte[] buffer = new byte[20];
        Class364.smethod_8(buffer, ref num, this.int_7);
        Class364.smethod_8(buffer, ref num, this.int_8);
        Class364.smethod_8(buffer, ref num, this.int_9);
        Class364.smethod_8(buffer, ref num, this.int_10);
        if (this.oleLinkType_0 == OleLinkType.Embed)
        {
            Class364.smethod_8(buffer, ref num, this.int_11);
            A_0.Write(buffer, 0, buffer.Length);
        }
    }

    internal void method_1(Stream12 A_0)
    {
        int num = 0;
        byte[] buffer = new byte[20];
        Class364.smethod_8(buffer, ref num, this.int_7);
        Class364.smethod_8(buffer, ref num, this.int_8);
        Class364.smethod_8(buffer, ref num, this.int_9);
        Class364.smethod_8(buffer, ref num, this.int_10);
        Class364.smethod_8(buffer, ref num, this.int_11);
        A_0.Write(buffer, 0, buffer.Length);
        if (this.oleLinkType_0 == OleLinkType.Link)
        {
            this.method_2(A_0, 4);
            string[] strArray = this.string_0.Split(new char[] { '\\' });
            string str = strArray[strArray.Length - 1];
            this.class366_1 = new Class366(str);
            this.class366_1.method_0(A_0, false);
            this.class366_2 = new Class366(this.string_0);
            this.class366_2.method_0(A_0, true);
            this.method_2(A_0, 0x10);
            this.method_2(A_0, 4);
            this.method_2(A_0, 4);
            this.method_2(A_0, 4);
            this.method_2(A_0, 4);
            this.method_2(A_0, 4);
        }
    }

    private void method_2(Stream12 A_0, int A_1)
    {
        byte[] buffer = new byte[A_1];
        A_0.Write(buffer, 0, A_1);
    }

    private void method_3(Stream12 A_0, string A_1)
    {
        byte[] buffer = new byte[4];
        ASCIIEncoding encoding = new ASCIIEncoding();
        int num = 0;
        byte[] bytes = encoding.GetBytes(A_1);
        Class364.smethod_8(buffer, ref num, bytes.Length);
        A_0.Write(buffer, 0, buffer.Length);
        if (bytes.Length > 0)
        {
            A_0.Write(bytes, 0, bytes.Length);
        }
    }

    internal override void vmethod_0(byte[] A_0, int A_1)
    {
        int num = 1;
        this.int_6 = A_0.Length;
        this.int_7 = Class364.smethod_1(A_0, ref A_1);
        if (this.int_7 != 0x2000001)
        {
            throw new InvalidDataException(BookmarkStart.b("栦攨渪ബ尮䔰䄲倴嘶吸ᬺ吼儾慀ⵂ⩄㍆楈㵊ⱌ⍎㡐㝒", num));
        }
        this.int_8 = Class364.smethod_1(A_0, ref A_1);
        this.int_9 = Class364.smethod_1(A_0, ref A_1);
        this.int_10 = Class364.smethod_1(A_0, ref A_1);
        if (this.int_10 != 0)
        {
            throw new InvalidDataException(BookmarkStart.b("栦攨渪ബ尮䔰䄲倴嘶吸ᬺ吼儾慀ⵂ⩄㍆楈㵊ⱌ⍎㡐㝒", num));
        }
        if (((this.int_8 != 0) && (this.int_8 != 8)) && ((this.int_8 != 12) && ((A_1 + 4) < this.int_6)))
        {
            this.int_11 = Class364.smethod_1(A_0, ref A_1);
            if ((this.int_11 != 0) && ((A_1 + this.int_11) < this.int_6))
            {
                byte[] buffer4 = Class364.smethod_5(A_0, this.int_11, ref A_1);
                this.class366_0 = new Class366(this.string_0);
                this.class366_0.vmethod_0(buffer4, 0);
            }
            this.int_12 = Class364.smethod_1(A_0, ref A_1);
            if ((this.int_12 != 0) && ((A_1 + this.int_12) < this.int_6))
            {
                byte[] buffer3 = Class364.smethod_5(A_0, this.int_12, ref A_1);
                this.class366_1 = new Class366(this.string_0);
                this.class366_1.vmethod_0(buffer3, 0);
            }
            this.int_13 = Class364.smethod_1(A_0, ref A_1);
            if ((this.int_13 != 0) && ((A_1 + this.int_13) < this.int_6))
            {
                byte[] buffer2 = Class364.smethod_5(A_0, this.int_13, ref A_1);
                this.class366_2 = new Class366(this.string_0);
                this.class366_2.vmethod_0(buffer2, 0);
            }
            this.int_14 = Class364.smethod_1(A_0, ref A_1);
            if (this.int_14 == -1)
            {
                throw new InvalidDataException(BookmarkStart.b("栦攨渪ബ尮䔰䄲倴嘶吸ᬺ吼儾慀ⵂ⩄㍆楈㵊ⱌ⍎㡐㝒", num));
            }
            byte[] buffer = Class364.smethod_5(A_0, 0x10, ref A_1);
            this.class367_0 = new Class367();
            this.class367_0.vmethod_0(buffer, 0);
            this.int_15 = Class364.smethod_1(A_0, ref A_1);
            this.int_16 = Class364.smethod_1(A_0, ref A_1);
            this.int_17 = Class364.smethod_1(A_0, ref A_1);
            this.int_18 = Class364.smethod_1(A_0, ref A_1);
            this.int_19 = Class364.smethod_1(A_0, ref A_1);
        }
    }

    internal override int vmethod_1(byte[] A_0, int A_1)
    {
        Class364.smethod_8(A_0, ref A_1, this.int_7);
        Class364.smethod_8(A_0, ref A_1, this.int_8);
        Class364.smethod_8(A_0, ref A_1, this.int_9);
        Class364.smethod_8(A_0, ref A_1, this.int_10);
        if (this.int_8 != 0)
        {
            Class364.smethod_8(A_0, ref A_1, this.int_11);
            if (this.int_11 != 0)
            {
                this.class366_0.vmethod_1(A_0, A_1);
                A_1 += this.class366_0.vmethod_2();
            }
            Class364.smethod_8(A_0, ref A_1, this.int_12);
            if (this.int_12 != 0)
            {
                this.class366_1.vmethod_1(A_0, A_1);
                A_1 += this.class366_1.vmethod_2();
            }
            Class364.smethod_8(A_0, ref A_1, this.int_13);
            this.class366_2.vmethod_1(A_0, A_1);
            A_1 += this.class366_2.vmethod_2();
            Class364.smethod_8(A_0, ref A_1, this.int_14);
            this.class367_0.vmethod_1(A_0, A_1);
            A_1 += this.class367_0.vmethod_2();
            Class364.smethod_8(A_0, ref A_1, this.int_15);
            Class364.smethod_8(A_0, ref A_1, this.int_16);
            Class364.smethod_8(A_0, ref A_1, this.int_17);
            Class364.smethod_8(A_0, ref A_1, this.int_18);
            Class364.smethod_8(A_0, ref A_1, this.int_19);
        }
        return A_0.Length;
    }

    internal override int vmethod_2()
    {
        if (this.int_6 == 0)
        {
            this.int_6 = 20;
        }
        return this.int_6;
    }

    private class Class366 : Class364
    {
        internal byte[] byte_0;
        internal Class365.Class367 class367_0;
        private const int int_0 = 0;
        private const int int_1 = -559022081;
        private const int int_2 = 4;
        internal string string_0;

        internal Class366(string A_0)
        {
            this.string_0 = A_0;
        }

        [DllImport("kernel32.dll", CharSet=CharSet.Auto)]
        public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string A_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder A_1, int A_2);
        internal void method_0(Stream12 A_0, bool A_1)
        {
            this.class367_0 = new Class365.Class367();
            byte[] buffer = new byte[0x10];
            this.class367_0.vmethod_1(buffer, 0);
            ASCIIEncoding encoding = new ASCIIEncoding();
            UnicodeEncoding encoding2 = new UnicodeEncoding();
            string s = string.Empty;
            string str2 = string.Empty;
            if (A_1)
            {
                StringBuilder builder = new StringBuilder(0xff);
                GetShortPathName(this.string_0, builder, builder.Capacity);
                string str3 = builder.ToString();
                s = str3;
                str2 = str3;
            }
            else
            {
                s = this.string_0;
                str2 = this.string_0;
            }
            byte[] bytes = encoding.GetBytes(s);
            byte[] buffer3 = BitConverter.GetBytes(-559022081);
            byte[] buffer4 = encoding2.GetBytes(str2);
            int num = ((buffer.Length + bytes.Length) + buffer3.Length) + buffer4.Length;
            A_0.Write(BitConverter.GetBytes(num), 0, 4);
            A_0.Write(buffer, 0, buffer.Length);
            A_0.Write(bytes, 0, bytes.Length);
            A_0.Write(buffer3, 0, buffer3.Length);
            A_0.Write(buffer4, 0, buffer4.Length);
        }

        internal override void vmethod_0(byte[] A_0, int A_1)
        {
            this.class367_0 = new Class365.Class367();
            this.class367_0.vmethod_0(A_0, A_1);
            A_1 += this.class367_0.vmethod_2();
            int num = A_0.Length - this.class367_0.vmethod_2();
            this.byte_0 = Class364.smethod_5(A_0, num, ref A_1);
        }

        internal override int vmethod_1(byte[] A_0, int A_1)
        {
            this.class367_0.vmethod_1(A_0, A_1);
            A_1 += this.class367_0.vmethod_2();
            Class364.smethod_11(A_0, ref A_1, this.byte_0);
            return 0;
        }

        internal override int vmethod_2()
        {
            if (this.byte_0 != null)
            {
                return (this.byte_0.Length + 0x10);
            }
            return 0;
        }
    }

    private class Class367 : Class364
    {
        internal const int int_0 = 0x10;
        internal int int_1;
        internal long long_0;
        internal short short_0;
        internal short short_1;

        internal Class367()
        {
        }

        internal override void vmethod_0(byte[] A_0, int A_1)
        {
            this.int_1 = Class364.smethod_1(A_0, ref A_1);
            this.short_0 = Class364.smethod_0(A_0, ref A_1);
            this.short_1 = Class364.smethod_0(A_0, ref A_1);
            this.long_0 = Class364.smethod_2(A_0, ref A_1);
        }

        internal override int vmethod_1(byte[] A_0, int A_1)
        {
            Class364.smethod_8(A_0, ref A_1, this.int_1);
            Class364.smethod_6(A_0, ref A_1, this.short_0);
            Class364.smethod_6(A_0, ref A_1, this.short_1);
            Class364.smethod_9(A_0, ref A_1, this.long_0);
            return 0x10;
        }

        internal override int vmethod_2()
        {
            return 0x10;
        }
    }
}

