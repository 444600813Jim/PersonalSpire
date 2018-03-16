using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;
using System.Text;

internal class Class260
{
    private readonly Class147 class147_0 = new Class147(2);
    private readonly Class158 class158_0 = new Class158();
    private readonly Class159 class159_0 = new Class159();
    private readonly Class168 class168_0 = new Class168();
    private readonly Class349 class349_0 = new Class349();
    private readonly Class986 class986_0 = new Class986();
    private readonly Class996 class996_0 = new Class996();
    private int int_0;
    private readonly StringBuilder stringBuilder_0 = new StringBuilder();
    private readonly SubDocumentType subDocumentType_0;

    internal Class260(SubDocumentType A_0)
    {
        this.subDocumentType_0 = A_0;
    }

    internal void method_0()
    {
        this.int_0++;
    }

    internal void method_1()
    {
        this.int_0--;
    }

    internal Class349 method_10()
    {
        return this.class349_0;
    }

    internal Class986 method_11()
    {
        return this.class986_0;
    }

    internal StringBuilder method_12()
    {
        return this.stringBuilder_0;
    }

    internal int method_13()
    {
        return this.stringBuilder_0.Length;
    }

    internal int method_14()
    {
        return this.int_0;
    }

    internal void method_2(int A_0)
    {
        this.class159_0.method_8(this.stringBuilder_0.Length);
        this.class147_0.method_8(A_0);
    }

    internal int method_3(BinaryWriter A_0)
    {
        for (int i = 0; i < this.stringBuilder_0.Length; i++)
        {
            char ch = this.stringBuilder_0[i];
            A_0.Write((byte) ch);
            A_0.Write((byte) (ch >> 8));
        }
        return this.stringBuilder_0.Length;
    }

    internal SubDocumentType method_4()
    {
        return this.subDocumentType_0;
    }

    internal Class159 method_5()
    {
        return this.class159_0;
    }

    internal Class158 method_6()
    {
        return this.class158_0;
    }

    internal Class147 method_7()
    {
        return this.class147_0;
    }

    internal Class996 method_8()
    {
        return this.class996_0;
    }

    internal Class168 method_9()
    {
        return this.class168_0;
    }
}

