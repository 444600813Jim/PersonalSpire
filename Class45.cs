using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class45 : CollectionEx
{
    internal Class45(Document A_0, OwnerHolder A_1) : base(A_0, A_1)
    {
    }

    internal IList method_5()
    {
        return base.InnerList;
    }

    internal void method_6(Class45 A_0)
    {
        int num = 0;
        int count = base.Count;
        while (num < count)
        {
            DocumentObject obj2 = (base.InnerList[num] as DocumentObject).Clone();
            if (obj2 != null)
            {
                A_0.method_5().Add(obj2);
            }
            num++;
        }
    }

    internal bool method_7()
    {
        bool flag = false;
        using (IEnumerator enumerator = this.method_5().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                DocumentObject current = (DocumentObject) enumerator.Current;
                if ((current is Paragraph) || (current is Table))
                {
                    goto Label_0037;
                }
            }
            return flag;
        Label_0037:
            flag = true;
        }
        return flag;
    }

    internal int method_8()
    {
        int index = 0;
        foreach (DocumentObject obj2 in this.method_5())
        {
            if ((obj2 is Paragraph) || (obj2 is Table))
            {
                return index;
            }
            index = this.method_5().IndexOf(obj2);
        }
        return index;
    }
}

