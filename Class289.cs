using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class289 : Class266
{
    private int int_0;
    private int int_1;

    internal Class289() : base(EscherRecordType.Dg, 0)
    {
    }

    internal int method_4()
    {
        return base.method_3().method_6();
    }

    internal void method_5(int A_0)
    {
        base.method_3().method_7(A_0);
    }

    internal int method_6()
    {
        return this.int_0;
    }

    internal void method_7(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_8()
    {
        return this.int_1;
    }

    internal void method_9(int A_0)
    {
        this.int_1 = A_0;
    }

    public override string System.Object.ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat(BookmarkStart.b("圫ḭ䴯㠱", 6), base.System.Object.ToString());
        builder.AppendFormat(BookmarkStart.b("缫䘭儯䈱儳电圷伹刻䨽稿㥁瑃㭅摇橉Ὃ㹍㥏㙑ᡓ㝕⭗⹙晛╝兟塡㱣᭥执", 6), this.int_0, this.int_1);
        return builder.ToString();
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_0);
        A_0.Write(this.int_1);
    }
}

