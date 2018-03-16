using Spire.Doc;
using System;
using System.IO;

internal class Class433
{
    internal int int_0;
    internal string string_0;
    internal string string_1;
    internal string string_2;

    internal Class433(BinaryReader A_0)
    {
        this.string_0 = "";
        this.string_1 = "";
        this.string_2 = "";
        A_0.ReadInt32();
        this.int_0 = A_0.ReadInt32() & 0xffff;
        this.string_0 = Class654.smethod_0(A_0);
        this.string_1 = Class654.smethod_0(A_0);
        this.string_2 = Class654.smethod_0(A_0);
    }

    internal Class433(int A_0, string A_1, string A_2)
    {
        this.string_0 = "";
        this.string_1 = "";
        this.string_2 = "";
        this.int_0 = A_0;
        this.string_0 = A_1;
        this.string_1 = A_2;
    }

    internal void method_0(BinaryWriter A_0)
    {
        int num = ((4 + Class654.smethod_2(this.string_0)) + Class654.smethod_2(this.string_1)) + Class654.smethod_2(this.string_2);
        A_0.Write(num);
        A_0.Write(this.int_0);
        Class654.smethod_1(A_0, this.string_0);
        Class654.smethod_1(A_0, this.string_1);
        Class654.smethod_1(A_0, this.string_2);
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("搬䬮ର䠲Դ䨶ᔸᬺ格䴾⡀祂㹄癆㑈杊浌᭎ぐ㑒潔ⱖ歘♚煜罞╠ౢቤ०ըѪ౬୮⑰Ųᱴ䵶ɸ䡺|", 7), new object[] { this.int_0, this.string_0, this.string_1, this.string_2 });
    }
}

