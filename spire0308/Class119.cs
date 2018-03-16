using Spire.Doc;
using System;
using System.Collections;
using System.IO;

internal abstract class Class119
{
    internal ArrayList arrayList_0 = new ArrayList();
    internal Class122 class122_0;

    internal Class119()
    {
        this.class122_0 = this.vmethod_0();
    }

    internal void method_0(int A_0, int A_1, Interface54 A_2)
    {
        int num = 1;
        if (!this.class122_0.method_0(A_0, A_1, A_2))
        {
            this.method_2();
            this.class122_0 = this.vmethod_0();
            if (!this.class122_0.method_0(A_0, A_1, A_2))
            {
                throw new InvalidOperationException(BookmarkStart.b("搦䠨䔪䌬䀮䔰ጲ吴匶崸ᬺ洼朾慀㝂⩄杆㵈⍊⡌潎ᝐᡒՔ祖", num));
            }
        }
    }

    internal Class147 method_1(Stream A_0)
    {
        this.method_2();
        Class147 class2 = new Class147(4);
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            Class983 class3 = this.arrayList_0[i] as Class983;
            int num2 = ((int) A_0.Position) / 0x200;
            A_0.Write(class3.method_1(), 0, class3.method_1().Length);
            class2.method_5(class3.method_0().method_2(), class3.method_0().method_4(), new Class699(num2));
        }
        return class2;
    }

    private void method_2()
    {
        Class983 class2 = this.class122_0.method_1();
        this.arrayList_0.Add(class2);
        this.class122_0 = null;
    }

    protected abstract Class122 vmethod_0();
}

