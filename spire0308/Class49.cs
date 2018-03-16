using Spire.Doc;
using Spire.Doc.Collections;
using System;
using System.Reflection;

[DefaultMember("Item")]
internal class Class49 : CollectionEx
{
    internal Class49(Document A_0) : base(A_0, A_0)
    {
    }

    public Class51 method_5(int A_0)
    {
        return (base.InnerList[A_0] as Class51);
    }

    public void method_6(Class51 A_0)
    {
        base.InnerList.Add(A_0);
    }
}

