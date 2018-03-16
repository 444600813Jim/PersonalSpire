using Spire.Doc;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class478 : IEnumerable
{
    private Hashtable hashtable_0 = new Hashtable();

    internal Class8 method_0(FootnoteSeparatorType A_0)
    {
        return (Class8) this.hashtable_0[A_0];
    }

    internal void method_1(FootnoteSeparatorType A_0, Class8 A_1)
    {
        this.hashtable_0[A_0] = A_1;
    }

    internal Class478 method_2(Document A_0)
    {
        Class478 class2 = (Class478) base.MemberwiseClone();
        class2.hashtable_0 = new Hashtable();
        foreach (DictionaryEntry entry in this.hashtable_0)
        {
            Class8 class3 = (Class8) entry.Value;
            Class8 class4 = (Class8) class3.Clone();
            class4.method_0(A_0);
            class2.hashtable_0.Add(entry.Key, class4);
        }
        return class2;
    }

    internal int method_3()
    {
        return this.hashtable_0.Count;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.hashtable_0.Values.GetEnumerator();
    }
}

