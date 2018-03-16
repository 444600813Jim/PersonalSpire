using Spire.Doc;
using System;
using System.Collections.Specialized;
using System.IO;

internal class Class812
{
    private const string string_0 = "Unknown";
    private readonly StringCollection stringCollection_0;

    internal Class812()
    {
        this.stringCollection_0 = new StringCollection();
        this.stringCollection_0.Add(BookmarkStart.b("礫䀭嬯就嬳䄵嘷", 6));
    }

    internal Class812(Class703 A_0, BinaryReader A_1)
    {
        this.stringCollection_0 = new StringCollection();
        Class343.smethod_1(A_1, A_0.class597_0.class1111_51, this.stringCollection_0);
    }

    internal int method_0(BinaryWriter A_0)
    {
        return Class343.smethod_4(A_0, this.stringCollection_0);
    }

    internal string method_1(int A_0)
    {
        int num = 2;
        if ((A_0 >= 0) && (A_0 < this.stringCollection_0.Count))
        {
            return this.stringCollection_0[A_0];
        }
        return BookmarkStart.b("紧䐩䜫䀭弯䔱娳", num);
    }

    internal int method_2(string A_0)
    {
        int index = this.stringCollection_0.IndexOf(A_0);
        if (index < 0)
        {
            index = this.method_3(A_0);
        }
        return index;
    }

    internal int method_3(string A_0)
    {
        this.stringCollection_0.Add(A_0);
        return (this.stringCollection_0.Count - 1);
    }
}

