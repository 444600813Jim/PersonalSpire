using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;
using System.Text;

internal class Class279 : Class266
{
    private int int_0;
    private int int_1;

    internal Class279() : base(EscherRecordType.Shape, 2)
    {
    }

    internal bool method_10()
    {
        return ((this.int_1 & 4) != 0);
    }

    internal void method_11(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 4, A_0);
    }

    internal bool method_12()
    {
        return ((this.int_1 & 8) != 0);
    }

    internal void method_13(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 8, A_0);
    }

    internal bool method_14()
    {
        return ((this.int_1 & 0x10) != 0);
    }

    internal void method_15(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x10, A_0);
    }

    internal bool method_16()
    {
        return ((this.int_1 & 0x20) != 0);
    }

    internal void method_17(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x20, A_0);
    }

    internal bool method_18()
    {
        return ((this.int_1 & 0x40) != 0);
    }

    internal void method_19(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x40, A_0);
    }

    internal bool method_20()
    {
        return ((this.int_1 & 0x80) != 0);
    }

    internal void method_21(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x80, A_0);
    }

    internal bool method_22()
    {
        return ((this.int_1 & 0x100) != 0);
    }

    internal void method_23(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x100, A_0);
    }

    internal bool method_24()
    {
        return ((this.int_1 & 0x400) != 0);
    }

    internal void method_25(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x400, A_0);
    }

    internal bool method_26()
    {
        return ((this.int_1 & 0x200) != 0);
    }

    internal void method_27(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x200, A_0);
    }

    internal bool method_28()
    {
        return ((this.int_1 & 0x800) != 0);
    }

    internal void method_29(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 0x800, A_0);
    }

    internal ShapeType method_30()
    {
        return (ShapeType) base.method_3().method_6();
    }

    internal void method_31(ShapeType A_0)
    {
        base.method_3().method_7((int) A_0);
    }

    internal FlipOrientation method_32()
    {
        if (this.method_18() && this.method_20())
        {
            return FlipOrientation.Both;
        }
        if (this.method_18())
        {
            return FlipOrientation.Horizontal;
        }
        if (this.method_20())
        {
            return FlipOrientation.Vertical;
        }
        return FlipOrientation.None;
    }

    internal void method_33(FlipOrientation A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case FlipOrientation.None:
                this.method_19(false);
                this.method_21(false);
                return;

            case FlipOrientation.Horizontal:
                this.method_19(true);
                this.method_21(false);
                return;

            case FlipOrientation.Vertical:
                this.method_19(false);
                this.method_21(true);
                return;

            case FlipOrientation.Both:
                this.method_19(true);
                this.method_21(true);
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("愳堵匷吹医䤽⸿扁≃⩅ⅇ㩉汋㩍⥏≑ㅓ硕", num));
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    internal bool method_6()
    {
        return ((this.int_1 & 1) != 0);
    }

    internal void method_7(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 1, A_0);
    }

    internal bool method_8()
    {
        return ((this.int_1 & 2) != 0);
    }

    internal void method_9(bool A_0)
    {
        this.int_1 = Class336.smethod_5(this.int_1, 2, A_0);
    }

    public override string System.Object.ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat(BookmarkStart.b("䬯ȱ䤳㰵", 10), base.System.Object.ToString());
        builder.AppendFormat(BookmarkStart.b("振娱唳䘵崷猹堻н㬿牁繃ṅ㕇晉汋ᵍ㡏㍑⑓㍕੗㽙㽛ㅝ቟١≣੥१൩Ὣ呭୯䍱乳⹵շ婹呻ս뉿ﾁ궃貅", 10), this.int_0, this.int_1, (EscherShapeRecordFlags) this.int_1);
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

