using Spire.Doc;
using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct28
{
    public int int_0;
    public int int_1;
    public string string_0;
    public bool method_0()
    {
        return (((this.int_0 == 0) && (this.int_1 == 0)) && string.IsNullOrEmpty(this.string_0));
    }

    public Struct28 method_1()
    {
        int num = 4;
        if (!this.method_0())
        {
            Struct28 struct2;
            int index = this.string_0.IndexOf(BookmarkStart.b("ࠩ", num));
            int startIndex = index + 1;
            int num4 = this.string_0.LastIndexOf(BookmarkStart.b("ࠩ", num));
            num4 = ((num4 < 0) || (index == num4)) ? this.string_0.Length : num4;
            int length = ((num4 - startIndex) < 0) ? 0 : (num4 - startIndex);
            return new Struct28 { string_0 = this.string_0.Substring(startIndex, length), int_1 = this.int_1 + startIndex, int_0 = struct2.int_1 + struct2.string_0.Length };
        }
        return new Struct28();
    }
}

