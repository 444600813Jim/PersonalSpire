using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.ComponentModel;

internal class Class580 : Class577, Interface31
{
    private WordAttrCollection wordAttrCollection_0;

    internal Class580(WordAttrCollection A_0, string A_1, DateTime A_2) : base(A_1, A_2)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("太䠬央愰䄲", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨪堬嬮夰尲䜴", num));
        }
        this.wordAttrCollection_0 = A_0;
    }

    bool Interface31.imethod_0()
    {
        return false;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    Interface31 Interface31.imethod_1()
    {
        Class580 class2 = (Class580) base.MemberwiseClone();
        class2.wordAttrCollection_0 = (WordAttrCollection) this.wordAttrCollection_0.Clone();
        return class2;
    }

    internal WordAttrCollection method_4()
    {
        return this.wordAttrCollection_0;
    }
}

