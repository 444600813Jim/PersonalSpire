using Spire.Doc;
using System;

internal class Class753 : IComparable
{
    private bool bool_0 = true;
    private int int_0;
    private int int_1;

    public int method_0()
    {
        return this.int_0;
    }

    public void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    public bool method_2()
    {
        return this.bool_0;
    }

    public void method_3(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public int method_4()
    {
        return this.int_1;
    }

    public void method_5(int A_0)
    {
        this.int_1 = A_0;
    }

    int IComparable.CompareTo(object A_0)
    {
        int num = 12;
        if (!(A_0 is Class753))
        {
            throw new NotImplementedException(BookmarkStart.b("紱嘳尵ᠷ匹伻ḽ⸿ⵁぃ晅⥇橉ы㩍㵏㹑᱓㍕㥗㹙࡛㽝ݟ⭡੣㙥१ᡩ൫७ɯ፱ѳṵⱷ᭹᭻㝽ꞅ", num));
        }
        Class753 class2 = A_0 as Class753;
        if (this.method_0() == class2.method_0())
        {
            return -1;
        }
        return this.method_0().CompareTo(class2.method_0());
    }
}

