using Spire.Doc;
using System;
using System.Collections;

internal class Class1087 : IEnumerable, IEnumerator
{
    private int int_0;
    private int int_1;
    private readonly string string_0;

    public Class1087(string A_0)
    {
        this.string_0 = A_0;
        this.System.Collections.IEnumerator.Reset();
    }

    public static int smethod_0(string A_0)
    {
        int num = 0;
        Class1087 class2 = new Class1087(A_0);
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
        if (Class334.smethod_3(this.string_0, this.int_1))
        {
            this.int_0 = Class334.smethod_2(this.string_0, this.int_1);
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
            int num = 5;
            if (this.int_1 == 0)
            {
                throw new InvalidOperationException(BookmarkStart.b("渪䌬娮尰嘲䜴嘶䴸吺似Ἶ⥀≂㙄杆❈⑊㥌潎㍐㙒ご㥖祘⡚⥜㹞፠ᝢdͦ䝨", num));
            }
            return this.int_0;
        }
    }
}

