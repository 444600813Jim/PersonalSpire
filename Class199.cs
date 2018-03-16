using Spire.Doc;
using Spire.Doc.Fields;
using System;

internal class Class199 : IDisposable, IComparable
{
    private bool bool_0;
    private bool bool_1;
    private Class375 class375_0;
    private DocPicture docPicture_0;
    private long long_0;

    public DocPicture method_0()
    {
        return this.docPicture_0;
    }

    public void method_1(DocPicture A_0)
    {
        this.docPicture_0 = A_0;
    }

    public Class375 method_2()
    {
        return this.class375_0;
    }

    public void method_3(Class375 A_0)
    {
        this.class375_0 = A_0;
    }

    public bool method_4()
    {
        return this.bool_0;
    }

    public void method_5(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public long method_6()
    {
        return this.long_0;
    }

    public void method_7(long A_0)
    {
        this.long_0 = A_0;
    }

    public bool method_8()
    {
        return this.bool_1;
    }

    public void method_9(bool A_0)
    {
        this.bool_1 = A_0;
    }

    int IComparable.CompareTo(object A_0)
    {
        int num = 1;
        if (!(A_0 is Class199))
        {
            throw new NotImplementedException(BookmarkStart.b("栦䬨䄪ബ䘮䈰ጲ嬴堶䴸ᬺ尼Ἶᅀ⩂♄㍆㱈㥊⡌๎㽐㝒Ŕ㉖⅘⽚൜ぞበ੢ᅤ๦٨ժ⑬Ůᝰᱲ呴", num));
        }
        Class199 class2 = A_0 as Class199;
        if (this.method_6() > class2.method_6())
        {
            return 1;
        }
        if (this.method_6() >= class2.method_6())
        {
            if ((this.method_0() == null) && (class2.method_0() != null))
            {
                return 1;
            }
            if ((this.method_0() == null) || (class2.method_0() != null))
            {
                return 0;
            }
        }
        return -1;
    }

    void IDisposable.Dispose()
    {
        if (this.docPicture_0 != null)
        {
            this.docPicture_0 = null;
        }
        if (this.class375_0 != null)
        {
            this.class375_0 = null;
        }
    }
}

