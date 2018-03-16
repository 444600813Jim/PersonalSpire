using Spire.Pdf.General.Paper.Drawing.Rendering.Ps;
using System;
using System.Collections;
using System.Drawing;

internal class Class319
{
    private readonly Class73 class73_0 = new Class73();
    private PointF pointF_0 = PointF.Empty;
    private sprự sprự_0;
    private readonly Stack stack_0 = new Stack();

    internal Class319(sprự A_0)
    {
        this.sprự_0 = A_0;
    }

    internal sprự method_0(sprự A_0)
    {
        this.stack_0.Push(this.sprự_0);
        this.sprự_0.ᜁ(A_0);
        this.sprự_0 = A_0;
        return this.sprự_0;
    }

    internal spr➓ method_1(PointF A_0)
    {
        spr➓ r➓ = new spr➓();
        r➓.ᜀ(smethod_0(A_0));
        this.method_0(r➓);
        return r➓;
    }

    internal void method_10(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    internal PointF method_11(PointF A_0)
    {
        return new PointF(this.pointF_0.X + A_0.X, this.pointF_0.Y + A_0.Y);
    }

    internal RectangleF method_12(RectangleF A_0)
    {
        return new RectangleF(this.method_11(A_0.Location), A_0.Size);
    }

    internal sprự method_13()
    {
        return this.sprự_0;
    }

    internal sprᴕ method_2(PsGroupCategory A_0)
    {
        sprᴕ sprᴕ = new sprᴕ();
        if (A_0 != null)
        {
            sprᴕ.ᜀ(A_0);
        }
        this.method_0(sprᴕ);
        return sprᴕ;
    }

    internal void method_3()
    {
        this.sprự_0 = (sprự) this.stack_0.Pop();
    }

    internal void method_4(sprᮃ A_0)
    {
        this.sprự_0.ᜁ(A_0);
    }

    internal void method_5(RectangleF A_0, sprⓚ A_1)
    {
        sprᲆ rᲆ = sprᲆ.ᜂ(A_0);
        rᲆ.ᜀ(new spr⚪(A_1));
        this.method_4(rᲆ);
    }

    internal void method_6(PointF[] A_0, sprⓚ A_1)
    {
        sprᲆ rᲆ = sprᲆ.ᜀ(A_0, true);
        rᲆ.ᜀ(new spr⚪(A_1));
        this.method_4(rᲆ);
    }

    internal void method_7(Class678 A_0)
    {
        this.class73_0.method_0(A_0);
    }

    internal void method_8()
    {
        this.class73_0.method_1();
    }

    internal sprⓚ method_9(sprⓚ A_0)
    {
        return sprⓚ.ᜀ(this.class73_0.method_2(A_0.ᜉ()));
    }

    private static spr➂ smethod_0(PointF A_0)
    {
        return new spr➂(1f, 0f, 0f, 1f, A_0.X, A_0.Y);
    }
}

