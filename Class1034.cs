using Spire.Doc;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class1034 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    internal const int int_0 = 30;

    public int method_0()
    {
        return this.arrayList_0.Count;
    }

    internal Class228 method_1(int A_0)
    {
        return (Class228) this.arrayList_0[A_0];
    }

    internal void method_2(int A_0, Class228 A_1)
    {
        Class567.smethod_20(A_1, BookmarkStart.b("央倰弲䀴制", 9));
        this.arrayList_0[A_0] = A_1;
    }

    public int method_3(Class228 A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("堭儯帱䄳匵", 8));
        return this.arrayList_0.Add(A_0);
    }

    public void method_4()
    {
        this.arrayList_0.Clear();
    }

    public void method_5(int A_0)
    {
        this.arrayList_0.RemoveAt(A_0);
    }

    internal void method_6()
    {
        if (this.method_0() != 0)
        {
            Class228[] classArray = new Class228[30];
            using (IEnumerator enumerator = this.System.Collections.IEnumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class228 current = (Class228) enumerator.Current;
                    if (current.method_12() != OdsoFieldMappingType.Null)
                    {
                        PredefinedMergeFieldName name = Class533.smethod_10(current.method_8());
                        if (name != PredefinedMergeFieldName.Invalid)
                        {
                            classArray[(int) name] = current;
                        }
                    }
                }
            }
            for (int i = 0; i < classArray.Length; i++)
            {
                if (classArray[i] == null)
                {
                    classArray[i] = new Class228();
                }
            }
            this.method_4();
            foreach (Class228 class3 in classArray)
            {
                this.method_3(class3);
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

