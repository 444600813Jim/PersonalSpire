using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class48 : StyleCollection
{
    internal Class48(Document A_0) : base(A_0)
    {
    }

    public Class12 method_33(int A_0)
    {
        return (Class12) base.InnerList[A_0];
    }

    internal int method_34(Class12 A_0)
    {
        return base.InnerList.Add(A_0);
    }

    public Class12 method_35(string A_0)
    {
        return (base.FindByName(A_0) as Class12);
    }

    internal Class12 method_36(int A_0)
    {
        Class12 class3;
        using (IEnumerator enumerator = base.InnerList.GetEnumerator())
        {
            Class12 current;
            while (enumerator.MoveNext())
            {
                current = (Class12) enumerator.Current;
                if (current.method_24() == A_0)
                {
                    goto Label_0030;
                }
            }
            return null;
        Label_0030:
            class3 = current;
        }
        return class3;
    }

    OwnerHolder StyleCollection.CreateItem(IXDLSContentReader A_0)
    {
        return new Class12(base.Document);
    }

    string StyleCollection.GetTagItemName()
    {
        return BookmarkStart.b("栦弨个弬崮堰圲倴笶倸䠺䤼氾㕀㩂⥄≆", 1);
    }
}

