using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class263
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private int int_0;
    private readonly Interface28 interface28_0;

    internal Class263(Interface28 A_0)
    {
        this.interface28_0 = A_0;
    }

    internal ElementPostion method_0()
    {
        if (this.arrayList_0.Count > 0)
        {
            return (ElementPostion) this.arrayList_0[this.arrayList_0.Count - 1];
        }
        return ElementPostion.None;
    }

    internal void method_1(ElementPostion A_0)
    {
        this.arrayList_0[this.arrayList_0.Count - 1] = A_0;
    }

    private void method_10()
    {
        this.arrayList_0.RemoveAt(this.arrayList_0.Count - 1);
    }

    internal void method_2(Class1150 A_0)
    {
        if (A_0.int_0 > this.int_0)
        {
            this.method_4(A_0);
        }
        else if (A_0.int_0 < this.int_0)
        {
            this.method_5(A_0);
        }
        else if ((A_0.int_0 > 0) && !A_0.method_1())
        {
            this.method_8();
        }
    }

    internal void method_3(Class1150 A_0, RowFormat A_1, char A_2)
    {
        if (A_0.method_1())
        {
            this.method_6(A_1);
        }
        else if ((A_2 == '\a') || A_0.bool_2)
        {
            this.method_7();
        }
    }

    private void method_4(Class1150 A_0)
    {
        if (this.int_0 > 0)
        {
            this.method_8();
        }
        while (this.int_0 < A_0.int_0)
        {
            this.interface28_0.imethod_29();
            this.method_9(ElementPostion.InTable);
            this.method_8();
            this.int_0++;
        }
    }

    private void method_5(Class1150 A_0)
    {
        int num = 12;
        if (this.method_0() == ElementPostion.InCell)
        {
            A_0.int_0 = this.int_0;
        }
        else if (this.method_0() == ElementPostion.InRow)
        {
            this.method_8();
            A_0.int_0 = this.int_0;
        }
        else
        {
            if (this.method_0() != ElementPostion.InTable)
            {
                throw new InvalidOperationException(BookmarkStart.b("瀱唳刵ᠷ渹崻尽ⰿ❁橃", num));
            }
            this.interface28_0.imethod_30();
            this.method_10();
            this.int_0--;
        }
    }

    private void method_6(RowFormat A_0)
    {
        if (this.method_0() == ElementPostion.InCell)
        {
            this.method_7();
        }
        if (this.method_0() != ElementPostion.InTable)
        {
            this.interface28_0.imethod_32(A_0);
            this.method_1(ElementPostion.InTable);
        }
    }

    private void method_7()
    {
        int num = 6;
        if (this.method_0() != ElementPostion.None)
        {
            if (this.method_0() != ElementPostion.InCell)
            {
                throw new InvalidOperationException(BookmarkStart.b("礫䀭唯䨱䐳匵嬷丹夻娽怿㙁╃⑅⑇⽉汋㵍⑏㍑⁓㍕癗", num));
            }
            this.interface28_0.imethod_34();
            this.method_1(ElementPostion.InRow);
        }
    }

    private void method_8()
    {
        if (this.method_0() == ElementPostion.InTable)
        {
            this.interface28_0.imethod_31();
            this.method_1(ElementPostion.InRow);
        }
        if (this.method_0() == ElementPostion.InRow)
        {
            this.interface28_0.imethod_33();
            this.method_1(ElementPostion.InCell);
        }
    }

    private void method_9(ElementPostion A_0)
    {
        this.arrayList_0.Add(A_0);
    }
}

