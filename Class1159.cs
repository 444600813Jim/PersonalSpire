using Spire.Doc;
using System;
using System.Collections;

internal class Class1159 : IEnumerator
{
    private Class1157 class1157_0;
    private Class1157 class1157_1;

    public Class1159(Class1157 A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堧䬩師䬭帯䘱", num));
        }
        this.class1157_1 = A_0;
    }

    public Class1157 method_0()
    {
        return this.class1157_0;
    }

    bool IEnumerator.MoveNext()
    {
        if (this.class1157_0 == null)
        {
            this.class1157_0 = this.class1157_1;
        }
        else
        {
            this.class1157_0 = Class1158.smethod_2(this.class1157_0);
        }
        return ((this.class1157_0 != null) && !this.class1157_0.method_8());
    }

    void IEnumerator.Reset()
    {
        this.class1157_0 = null;
    }

    object IEnumerator.Current
    {
        get
        {
            return this.class1157_0;
        }
    }
}

