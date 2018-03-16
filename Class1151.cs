using Spire.Doc;
using System;
using System.IO;

internal class Class1151
{
    internal int int_0;
    internal int int_1;

    internal Class1151(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
    }

    internal Class1151(int A_0, int A_1)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("瀵儷帹弻刽氿扁⁃ⅅⅇ⹉癋㕍恏⽑硓癕㭗⥙ⱛ㝝џⅡᅣᑥ剧ᅩ嵫፭", 0x10), this.int_0, this.int_1);
    }
}

