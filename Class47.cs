using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents.XML;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
internal class Class47 : DocumentSerializableCollection
{
    private Dictionary<int, int> dictionary_0;

    internal Class47(Document A_0) : base(A_0, A_0)
    {
    }

    internal int method_10(OverrideLevelFormat A_0)
    {
        int index = base.InnerList.IndexOf(A_0);
        int num2 = index;
        using (Dictionary<int, int>.Enumerator enumerator = this.method_7().GetEnumerator())
        {
            KeyValuePair<int, int> current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.Value == index)
                {
                    goto Label_003D;
                }
            }
            return num2;
        Label_003D:
            num2 = current.Key;
        }
        return num2;
    }

    internal bool method_11(int A_0)
    {
        return ((this.method_7().Count > 0) && this.method_7().ContainsKey(A_0));
    }

    public OverrideLevelFormat method_5(int A_0)
    {
        return (OverrideLevelFormat) base.InnerList[this.method_7()[A_0]];
    }

    private Class12 method_6()
    {
        return (base.OwnerBase as Class12);
    }

    internal Dictionary<int, int> method_7()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<int, int>();
        }
        return this.dictionary_0;
    }

    internal void method_8(Dictionary<int, int> A_0)
    {
        this.dictionary_0 = A_0;
    }

    internal int method_9(int A_0, OverrideLevelFormat A_1)
    {
        A_1.method_0(this.method_6());
        int num = base.InnerList.Add(A_1);
        if (this.method_7().ContainsKey(A_0))
        {
            this.method_7()[A_0] = num;
            return num;
        }
        this.method_7().Add(A_0, num);
        return num;
    }

    void DocumentSerializableCollection.CloneToImpl(CollectionEx A_0)
    {
        foreach (DocumentSerializable serializable in base.InnerList)
        {
            A_0.InnerList.Add(serializable.method_4());
            OverrideLevelFormat format = A_0.InnerList[A_0.Count - 1] as OverrideLevelFormat;
            format.method_0((A_0 as Class47).OwnerBase);
            format.OverrideListLevel.method_0(format);
        }
        foreach (KeyValuePair<int, int> pair in this.method_7())
        {
            (A_0 as Class47).method_7().Add(pair.Key, pair.Value);
        }
    }

    OwnerHolder DocumentSerializableCollection.CreateItem(IXDLSContentReader A_0)
    {
        return new OverrideLevelFormat(base.Document);
    }

    string DocumentSerializableCollection.GetTagItemName()
    {
        return BookmarkStart.b("䐪嬬䨮䌰䄲尴匶尸ᘺ儼娾㝀♂⥄", 5);
    }
}

