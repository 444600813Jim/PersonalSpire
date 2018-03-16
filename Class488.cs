using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.FieldCode;
using System;
using System.Text;

internal class Class488 : Interface17
{
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;

    internal Class488()
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
    }

    internal Class488(string A_0, string A_1, string A_2, string A_3)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.method_1(A_0);
        this.method_3(A_1);
        this.method_5(A_2);
        this.method_7(A_3);
    }

    FieldSwitchType Interface17.imethod_0(string A_0)
    {
        int num = 0x10;
        string str = A_0;
        if (str != null)
        {
            if ((str == BookmarkStart.b("樵唷", num)) || (str == BookmarkStart.b("樵嘷", num)))
            {
                return FieldSwitchType.Flag;
            }
            if (((str == BookmarkStart.b("樵吷", num)) || (str == BookmarkStart.b("樵圷", num))) || (str == BookmarkStart.b("樵䰷", num)))
            {
                return FieldSwitchType.HasArgument;
            }
        }
        return FieldSwitchType.Unknown;
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("丷嬹倻䬽┿", 0x12));
        this.string_0 = A_0;
    }

    internal string method_2()
    {
        return this.string_1;
    }

    internal void method_3(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("堭儯帱䄳匵", 8));
        this.string_1 = A_0;
    }

    internal string method_4()
    {
        return this.string_2;
    }

    internal void method_5(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䀵夷嘹䤻嬽", 0x10));
        this.string_2 = A_0;
    }

    internal string method_6()
    {
        return this.string_3;
    }

    internal void method_7(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䘯匱堳䌵崷", 10));
        this.string_3 = A_0;
    }

    internal string method_8()
    {
        return Class736.smethod_4(this.method_0(), this.method_2());
    }

    string object.ToString()
    {
        int num = 14;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("ᐳ縵愷樹礻氽ిୁ੃൅桇", 14));
        if (Class567.smethod_16(this.method_0()))
        {
            builder.AppendFormat(BookmarkStart.b("伳ص䔷ᨹ", num), Class955.smethod_5(this.method_0()));
        }
        if (Class567.smethod_16(this.method_2()))
        {
            builder.AppendFormat(BookmarkStart.b("栳娵ᠷ䄹఻䌽怿", num), Class955.smethod_3(this.method_2()));
        }
        if (Class567.smethod_16(this.method_4()))
        {
            builder.AppendFormat(BookmarkStart.b("栳夵ᠷ䄹఻䌽怿", num), Class955.smethod_3(this.method_4()));
        }
        if (Class567.smethod_16(this.method_6()))
        {
            builder.AppendFormat(BookmarkStart.b("栳䈵ᠷ䄹఻䌽怿", num), Class955.smethod_3(this.method_6()));
        }
        return builder.ToString();
    }
}

