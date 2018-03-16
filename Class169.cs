using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.FieldCode;
using System;

internal class Class169 : Interface17
{
    private string string_0;

    internal Class169()
    {
        this.string_0 = string.Empty;
    }

    internal Class169(string A_0)
    {
        this.string_0 = string.Empty;
        this.method_1(A_0);
    }

    FieldSwitchType Interface17.imethod_0(string A_0)
    {
        string str;
        int num = 10;
        if (((str = A_0) != null) && (str == BookmarkStart.b("氯䄱", num)))
        {
            return FieldSwitchType.Flag;
        }
        return FieldSwitchType.Unknown;
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䀵夷嘹䤻嬽", 0x10));
        this.string_0 = A_0;
    }

    internal static string smethod_0(string A_0)
    {
        Class169 class2 = new Class169(A_0);
        return class2.ToString();
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("਩漫愭縯昱昳礵琷ᨹ䜻฽㴿扁ᡃ㕅桇", 4), this.method_0());
    }
}

