using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class44 : CollectionEx
{
    internal Class44(Document A_0, OwnerHolder A_1) : base(A_0, A_1)
    {
    }

    internal DocumentObject method_10()
    {
        if (this.method_8().Count > 0)
        {
            return (this.method_8()[this.method_8().Count - 1] as DocumentObject);
        }
        return null;
    }

    internal void method_5(Class44 A_0)
    {
        int num = 0;
        int count = base.Count;
        while (num < count)
        {
            DocumentObject obj2 = (base.InnerList[num] as DocumentObject).Clone();
            if (obj2 != null)
            {
                A_0.method_8().Add(obj2);
            }
            num++;
        }
    }

    internal bool method_6()
    {
        bool flag;
        using (IEnumerator enumerator = this.method_8().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                DocumentObject current = (DocumentObject) enumerator.Current;
                if ((current is Paragraph) || (current is Table))
                {
                    goto Label_0035;
                }
            }
            return false;
        Label_0035:
            flag = true;
        }
        return flag;
    }

    internal int method_7()
    {
        int num2;
        int index = 0;
        using (IEnumerator enumerator = this.method_8().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                DocumentObject current = (DocumentObject) enumerator.Current;
                if ((current is Paragraph) || (current is Table))
                {
                    goto Label_0044;
                }
                index = this.method_8().IndexOf(current);
            }
            return index;
        Label_0044:
            num2 = index;
        }
        return num2;
    }

    internal IList method_8()
    {
        return base.InnerList;
    }

    internal DocumentObject method_9()
    {
        if (this.method_8().Count > 0)
        {
            return (this.method_8()[0] as DocumentObject);
        }
        return null;
    }
}

