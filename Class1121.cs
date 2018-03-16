using Spire.Doc;
using System;

internal class Class1121 : IComparable
{
    private int int_0;
    private sprᲆ[] sprᲆ_0;

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    internal sprᲆ[] method_2()
    {
        return this.sprᲆ_0;
    }

    internal void method_3(sprᲆ[] A_0)
    {
        this.sprᲆ_0 = A_0;
    }

    int IComparable.CompareTo(object A_0)
    {
        int num = 4;
        if (!(A_0 is Class1121))
        {
            throw new ArgumentException(BookmarkStart.b("䔩丫䐭唯儱䀳ᘵ儷䤹᰻倽⼿㙁摃❅桇ᩉⵋ㩍㡏᭑㩓さ㝗", num));
        }
        return this.int_0.CompareTo(((Class1121) A_0).method_0());
    }
}

