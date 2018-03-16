using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class284 : Class266
{
    private ArrayList arrayList_0;
    private int int_0;
    private int int_1;
    private int int_2;

    internal Class284() : base(EscherRecordType.Dgg, 0)
    {
        this.arrayList_0 = new ArrayList();
    }

    internal ArrayList method_10()
    {
        return this.arrayList_0;
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_6()
    {
        return this.int_1;
    }

    internal void method_7(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_8()
    {
        return this.int_2;
    }

    internal void method_9(int A_0)
    {
        this.int_2 = A_0;
    }

    public override string System.Object.ToString()
    {
        int num = 3;
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat(BookmarkStart.b("刨ᬪ倬┮", 3), base.System.Object.ToString());
        builder.AppendFormat(BookmarkStart.b("稨嬪䐬䬮簰刲䴴ശ䈸଺ܼ朾㱀潂敄ņ⁈⽊⹌⍎ቐ㱒⁔㥖ⵘ慚♜湞ᱠ佢䕤㑦Ũ੪ᵬ੮㉰ᱲt᥶൸䅺ټ䵾ﲀ꾂ꖄ쎆ﮈ戴ﾐ횔ꖞ\udaa0\u90a2\ud8a4\uada6", 3), new object[] { this.int_0, this.arrayList_0.Count, this.int_1, this.int_2 });
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            builder.AppendFormat(BookmarkStart.b("刨ᬪ倬┮", num), this.arrayList_0[i].ToString());
        }
        return builder.ToString();
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        int num = A_0.ReadInt32() - 1;
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_0.Add(new Class1151(A_0));
        }
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write((int) (this.arrayList_0.Count + 1));
        A_0.Write(this.int_1);
        A_0.Write(this.int_2);
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            ((Class1151) this.arrayList_0[i]).method_0(A_0);
        }
    }
}

