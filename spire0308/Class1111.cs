using Spire.Doc;
using System;
using System.IO;

internal class Class1111
{
    internal int int_0;
    internal int int_1;

    internal Class1111()
    {
        this.int_0 = 0;
        this.int_1 = 0;
    }

    internal Class1111(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
    }

    internal void method_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
    }

    internal void method_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
    }

    string object.ToString()
    {
        int num = 15;
        if ((this.int_0 == 0) && (this.int_1 == 0))
        {
            return BookmarkStart.b("ᠴ", num);
        }
        return string.Format(BookmarkStart.b("临ܶ䐸᜺ᴼ䐾灀㹂", num), this.int_0, this.int_1);
    }
}

