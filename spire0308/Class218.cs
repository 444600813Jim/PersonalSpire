using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.IO;

internal class Class218
{
    private Interface64 interface64_0;
    private readonly spr➓ spr➓_0;

    public Class218(ShapeBase A_0)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨸区尼伾⑀", num));
        }
        Class724 class2 = new Class724(A_0);
        this.spr➓_0 = Class220.smethod_0(class2, null);
        this.method_6(class2);
    }

    public SizeF method_0()
    {
        return this.interface64_0.imethod_0().Size;
    }

    public Size method_1(float A_0, float A_1)
    {
        return spr⤋.ᜀ(this.method_0(), A_0, (double) A_1);
    }

    public SizeF method_2(Graphics A_0, float A_1, float A_2, float A_3)
    {
        Class450 class2 = new Class450();
        return class2.method_2(this.spr➓_0, this.method_0(), A_0, A_1, A_2, A_3);
    }

    public float method_3(Graphics A_0, float A_1, float A_2, float A_3, float A_4)
    {
        Class450 class2 = new Class450();
        return class2.method_3(this.spr➓_0, this.method_0(), A_0, A_1, A_2, A_3, A_4);
    }

    public void method_4(string A_0)
    {
        sprḆ.ᜂ(A_0, BookmarkStart.b("䠭夯帱儳砵夷圹夻", 8));
        using (Stream stream = File.Create(A_0))
        {
            this.method_5(stream);
        }
    }

    public void method_5(Stream A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬷丹主嬽ℿ⽁", num));
        }
        Class378 class2 = new Class378();
        SizeF ef = this.method_0();
        if ((ef == SizeF.Empty) && (this.spr➓_0.ᜋ() == 0))
        {
            sprἣ sprἣ = new sprἣ(new PointF(0f, 0f), new SizeF(32f, 32f), sprḆ.ᜂ());
            this.spr➓_0.ᜁ(sprἣ);
            ef = sprἣ.ᜋ();
        }
        Class377.smethod_0(this.spr➓_0, ef, A_0, ImageFormat.Emf, class2);
    }

    private void method_6(Interface64 A_0)
    {
        this.interface64_0 = A_0;
        this.spr➓_0.ᜀ(new spr➂(1f, 0f, 0f, 1f, -this.interface64_0.imethod_0().Left, -this.interface64_0.imethod_0().Top));
    }
}

