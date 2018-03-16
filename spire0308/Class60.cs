using Spire.Doc;
using System;
using System.Collections;

internal class Class60 : IEnumerable, IEnumerator
{
    private int int_0;
    private int int_1;
    private readonly string string_0;

    public Class60(string A_0)
    {
        this.string_0 = A_0;
        this.System.Collections.IEnumerator.Reset();
    }

    public static int smethod_0(string A_0)
    {
        int num = 0;
        Class60 class2 = new Class60(A_0);
        while (class2.System.Collections.IEnumerator.MoveNext())
        {
            num++;
        }
        return num;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    bool IEnumerator.MoveNext()
    {
        if (this.int_1 >= this.string_0.Length)
        {
            return false;
        }
        if (Class61.smethod_3(this.string_0, this.int_1))
        {
            this.int_0 = Class61.smethod_2(this.string_0, this.int_1);
            this.int_1 += 2;
            return true;
        }
        this.int_0 = this.string_0[this.int_1];
        this.int_1++;
        return true;
    }

    void IEnumerator.Reset()
    {
        this.int_1 = 0;
    }

    object IEnumerator.Current
    {
        get
        {
            int num = 0x11;
            if (this.int_1 == 0)
            {
                throw new InvalidOperationException(BookmarkStart.b("父圸为值娾㍀≂ㅄ⡆㭈歊╌⹎≐獒㭔㡖ⵘ筚㽜㩞Ѡൢ䕤ᑦᵨ੪Ὤ᭮ᑰᝲ孴", num));
            }
            return this.int_0;
        }
    }
}

