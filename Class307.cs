using Spire.Doc;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

internal class Class307 : IDisposable
{
    private Class500 class500_0;
    private spr┿ spr┿_0;

    public Class307(Class500 A_0, bool A_1) : this(A_0.method_28().PageSize, A_1)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弮倰吲倴", num));
        }
        this.class500_0 = A_0;
    }

    public Class307(SizeF A_0, bool A_1)
    {
        float num3 = 1f;
        sprᩆ rᩆ = new sprḀ();
        if (A_1)
        {
            sprᣮ rᣮ2;
            double num;
            double num2;
            this.method_3(A_0, rᩆ, new sprᴢ(72f, 72f), 0f, 0f, out num, out num2, out rᣮ2);
            sprᣮ rᣮ = spr⇊.ᜀ(rᣮ2.ᜀ() * num3, rᣮ2.ᜁ(), rᣮ2.ᜂ(), rᣮ2.ᜃ() * num3, rᣮ2.ᜄ(), rᣮ2.ᜅ(), rᩆ.ᜀ());
            rᩆ.ᜀ(new spr⟜((int) (num * num3), (int) (num2 * num3)));
            if (rᣮ == null)
            {
                rᣮ = spr⇊.ᜀ(1f, 0f, 0f, 1f, 0f, 0f, rᩆ.ᜀ());
            }
            this.spr┿_0 = spr⇊.ᜀ(rᩆ, rᣮ) as spr┿;
            RectangleF ef = new RectangleF(0f, 0f, A_0.Width, A_0.Height);
            spr☚ r☚ = spr⇊.ᜁ(rᩆ.ᜀ());
            r☚.ᜁ(ef.Left, ef.Top);
            r☚.ᜂ(ef.Left, ef.Bottom);
            r☚.ᜂ(ef.Right, ef.Bottom);
            r☚.ᜂ(ef.Right, ef.Top);
            r☚.ᜂ(ef.Left, ef.Top);
            r☚.᜘();
            this.method_0().ᜁ(ef.Left, ef.Top);
            this.method_0().᜛().ᜁ(r☚);
            this.method_0().᜙();
        }
    }

    public spr┿ method_0()
    {
        return this.spr┿_0;
    }

    internal void method_1(spr┿ A_0)
    {
        this.spr┿_0 = A_0;
    }

    public void method_10(Pen A_0, PointF A_1, PointF A_2)
    {
        this.method_0().ᜁ();
        spr⚪ r⚪ = spr➮.ᜀ(A_0);
        sprᲆ rᲆ = sprᲆ.ᜁ(A_1, A_2);
        this.method_0().ᜀ(r⚪, rᲆ);
        this.method_0().ᜂ();
    }

    public void method_11(string A_0, sprᝪ A_1, Color A_2, PointF A_3, SizeF A_4, spr➂ A_5, StringFormat A_6)
    {
        this.method_0().ᜁ();
        spr⚢ r⚢ = new spr⚢(A_1, sprⓚ.ᜀ(A_2), sprⓚ.ទ, new PointF(0f, 0f), A_0, A_4, 0f);
        if ((A_1.ᜂ() & FontStyle.Underline) != FontStyle.Regular)
        {
            r⚢.ᜊ = 1;
        }
        if (spr➂.ᜀ(null, A_5))
        {
            this.method_0().᜜().ᜏ().ᜀ(A_5.ᜐ(), A_5.ᜓ(), A_5.᜕(), A_5.ᜌ(), A_5.ᜊ(), A_5.ᜍ());
        }
        this.method_0().᜜().ᜏ().ᜀ(A_3.X, A_3.Y - r⚢.ᜄ().Y);
        this.method_0().ᜀ(r⚢);
        this.method_0().ᜂ();
    }

    public void method_12(string A_0, sprᝪ A_1, Color A_2, float A_3, float A_4, StringFormat A_5)
    {
        this.method_0().ᜁ();
        spr⚢ r⚢ = new spr⚢(A_1, A_2, new PointF(0f, 0f), A_0);
        this.method_0().᜜().ᜏ().ᜀ(A_3, A_4 - r⚢.ᜄ().Y);
        this.method_0().ᜀ(r⚢);
        this.method_0().ᜂ();
    }

    public void method_13(string A_0, Font A_1, Color A_2, float A_3, float A_4, StringFormat A_5)
    {
        sprᝪ rᝪ = new Class308(A_1.Name, A_1.Size, A_1.Style).method_16();
        this.method_12(A_0, rᝪ, A_2, A_3, A_4, A_5);
    }

    public void method_14(PointF A_0, spr➓ A_1)
    {
        this.method_0().ᜁ();
        this.method_0().᜜().ᜏ().ᜀ(A_0.X, A_0.Y);
        this.method_0().ᜀ(A_1);
        this.method_0().ᜂ();
    }

    public void method_15(Image A_0, RectangleF A_1)
    {
        this.method_16(A_0, A_1, null);
    }

    public void method_16(Image A_0, RectangleF A_1, spr➂ A_2)
    {
        using (MemoryStream stream = new MemoryStream())
        {
            spr⊗.ᜀ(A_0, stream);
            this.method_0().ᜁ();
            if (spr➂.ᜀ(A_2, null))
            {
                this.method_0().᜜().ᜏ().ᜀ(A_2.ᜐ(), A_2.ᜓ(), A_2.᜕(), A_2.ᜌ(), A_2.ᜊ(), A_2.ᜍ());
            }
            this.method_0().᜜().ᜏ().ᜀ(A_1.Location.X, A_1.Location.Y);
            sprἣ sprἣ = new sprἣ(new PointF(0f, 0f), A_1.Size, stream.ToArray());
            this.method_0().ᜀ(sprἣ);
            this.method_0().ᜂ();
        }
    }

    public Class500 method_2()
    {
        return this.class500_0;
    }

    private void method_3(SizeF A_0, sprᩆ A_1, sprᴢ A_2, float A_3, float A_4, out double A_5, out double A_6, out sprᣮ A_7)
    {
        RectangleF ef = new RectangleF(0f, 0f, A_0.Width, A_0.Height);
        float num = Math.Max(ef.Right, ef.Left);
        float num2 = Math.Max(ef.Bottom, ef.Top);
        float num3 = Math.Min(ef.Left, ef.Right);
        float num4 = Math.Min(ef.Top, ef.Bottom);
        sprᣮ rᣮ = spr⇊.ᜀ(1f, 0f, 0f, 1f, 0f, 0f, A_1.ᜀ());
        rᣮ.ᜂ(num3, num4, ref num3, ref num4);
        rᣮ.ᜂ(num, num2, ref num, ref num2);
        float num5 = Math.Max(num, num3);
        float num6 = Math.Max(num2, num4);
        float num7 = Math.Min(num3, num);
        float num8 = Math.Min(num4, num2);
        double num9 = num5 - num7;
        double num10 = num6 - num8;
        double num11 = num9;
        double num12 = num10;
        A_5 = (A_2.ᜀ * num11) / 72.0;
        A_6 = (A_2.ᜁ * num12) / 72.0;
        float num13 = (float) (A_5 / num9);
        float num14 = (float) (A_6 / num10);
        A_7 = spr⇊.ᜀ(num13, 0f, 0f, num14, A_3, A_4, A_1.ᜀ());
        A_7.ᜀ(-num7, -num8);
        A_7.ᜀ(rᣮ);
    }

    public void method_4()
    {
        this.method_0().ᜁ();
    }

    public void method_5()
    {
        this.method_0().ᜂ();
    }

    public void method_6(RectangleF A_0)
    {
        spr⇊.ᜁ(1, A_0.X, A_0.Y).ᜂ(A_0.X, A_0.Y, A_0.Width, A_0.Height);
    }

    public void method_7()
    {
    }

    public void method_8(Color A_0, RectangleF A_1)
    {
        this.method_9(A_0, A_1.X, A_1.Y, A_1.Width, A_1.Height);
    }

    public void method_9(Color A_0, float A_1, float A_2, float A_3, float A_4)
    {
        this.method_0().ᜁ();
        this.method_0().ᜀ(A_1, A_2, A_3, A_4);
        this.method_0().᜜().ᜁ(new sprⅺ(A_0.R, A_0.G, A_0.B));
        this.method_0().ᜏ();
        this.method_0().ᜂ();
    }

    void IDisposable.Dispose()
    {
        if (this.spr┿_0 != null)
        {
            this.spr┿_0.Dispose();
        }
        this.class500_0 = null;
    }
}

