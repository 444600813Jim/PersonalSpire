using Spire.Doc;
using Spire.Doc.Fields.Shape.Ps.Wrapping;
using System;
using System.Collections;
using System.Drawing;

internal class Class1021
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private byte[] byte_0;
    private Class622 class622_0;
    private Class722 class722_0;
    private RectangleF rectangleF_0;
    private spr➓ spr➓_0;
    private readonly sprℭ sprℭ_0;
    private WrapFillType wrapFillType_0;

    internal Class1021(sprℭ A_0)
    {
        this.sprℭ_0 = A_0;
    }

    internal void method_0(sprᲆ A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜶堸伺唼", num));
        }
        if (this.wrapFillType_0 != WrapFillType.Fill)
        {
            this.arrayList_0.Clear();
            this.byte_0 = null;
            this.wrapFillType_0 = WrapFillType.Fill;
        }
        this.method_5(A_0);
    }

    internal void method_1(byte[] A_0, RectangleF A_1)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崳嬵夷崹夻簽㤿㙁⅃㕅", num));
        }
        if (A_1.IsEmpty)
        {
            throw new ArgumentNullException(BookmarkStart.b("崳嬵夷崹夻簽⼿㝁⩃≅㭇", num));
        }
        this.wrapFillType_0 = WrapFillType.Image;
        this.byte_0 = A_0;
        this.rectangleF_0 = A_1;
    }

    private void method_10()
    {
        this.class622_0 = Class445.smethod_0(this.spr➓_0, this.rectangleF_0);
    }

    private RectangleF method_11()
    {
        spr➓ r➓ = this.method_12();
        sprᨴ rᨴ = new sprᨴ();
        return rᨴ.ᜁ(r➓);
    }

    private spr➓ method_12()
    {
        int num = 3;
        switch (this.wrapFillType_0)
        {
            case WrapFillType.Fill:
            case WrapFillType.Stroke:
                return this.method_13();

            case WrapFillType.Image:
                return this.method_14();

            case WrapFillType.Canvas:
                return this.spr➓_0;
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("縨䌪䰬嬮攰尲戴䔶堸䬺", num));
    }

    private spr➓ method_13()
    {
        spr➓ r➓ = new spr➓();
        r➓.ᜀ(this.method_15());
        return r➓;
    }

    private spr➓ method_14()
    {
        spr➓ r➓ = new spr➓();
        r➓.ᜁ(new sprἣ(new PointF(this.rectangleF_0.Left, this.rectangleF_0.Top), new SizeF(this.rectangleF_0.Width, this.rectangleF_0.Height), this.byte_0));
        return r➓;
    }

    private sprᲆ[] method_15()
    {
        return (sprᲆ[]) this.arrayList_0.ToArray(typeof(sprᲆ));
    }

    internal void method_2(sprᲆ A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜶堸伺唼", num));
        }
        if (this.wrapFillType_0 != WrapFillType.Stroke)
        {
            this.arrayList_0.Clear();
            this.byte_0 = null;
            this.wrapFillType_0 = WrapFillType.Stroke;
        }
        this.method_5(A_0);
    }

    internal void method_3(spr➓ A_0, RectangleF A_1)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("到刲嬴䄶堸䠺", num));
        }
        this.arrayList_0.Clear();
        this.byte_0 = null;
        this.wrapFillType_0 = WrapFillType.Canvas;
        this.spr➓_0 = A_0;
        this.rectangleF_0 = A_1;
    }

    internal Class722 method_4()
    {
        if (this.class722_0 == null)
        {
            this.method_6();
        }
        return this.class722_0;
    }

    private void method_5(sprᲆ A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    private void method_6()
    {
        int num = 0x13;
        try
        {
            switch (this.wrapFillType_0)
            {
                case WrapFillType.Fill:
                    this.method_7();
                    break;

                case WrapFillType.Image:
                    this.method_8();
                    break;

                case WrapFillType.Stroke:
                    this.method_7();
                    break;

                case WrapFillType.Canvas:
                    this.method_10();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("游区尼䬾ᕀⱂቄ㕆⡈㭊", num));
            }
            if (this.class622_0 == null)
            {
                this.class622_0 = new Class622();
            }
            this.class722_0 = Class670.smethod_1(this.class622_0);
            if (this.byte_0 == null)
            {
                Class671.smethod_0(this.class722_0);
            }
        }
        catch
        {
            this.class722_0 = new Class722(this.method_11());
            this.sprℭ_0.ᜀ(2, 1, BookmarkStart.b("洸刺娼圾㕀捂㉄㕆⡈㭊㵌♎㽐㑒畔㉖⭘⥚㉜ⵞ你䍢つᑦhժ੬佮ɰɲtᙶ୸Ṻ嵼ᙾꎌ", num));
        }
    }

    private void method_7()
    {
        foreach (sprᲆ rᲆ in this.method_15())
        {
            Class622 class2 = Class548.smethod_0(rᲆ);
            if (this.class622_0 == null)
            {
                this.class622_0 = new Class622(class2);
            }
            else
            {
                this.class622_0.method_1(class2);
            }
        }
    }

    private void method_8()
    {
        if (this.arrayList_0.Count != 0)
        {
            this.method_7();
            if ((this.class622_0 != null) && (this.class622_0.method_8() != 0))
            {
                return;
            }
        }
        this.class622_0 = Class501.smethod_0(this.byte_0, this.rectangleF_0);
        if (this.class622_0.method_8() == 0)
        {
            this.method_9();
        }
    }

    private void method_9()
    {
        PointF[] tfArray = new PointF[] { new PointF(this.rectangleF_0.Left, this.rectangleF_0.Top), new PointF(this.rectangleF_0.Right, this.rectangleF_0.Top), new PointF(this.rectangleF_0.Right, this.rectangleF_0.Bottom), new PointF(this.rectangleF_0.Left, this.rectangleF_0.Bottom) };
        this.class622_0 = new Class622(new Class722(tfArray));
    }

    internal static spr➓ smethod_0(Class722 A_0)
    {
        spr➓ r➓ = new spr➓();
        if (A_0 != null)
        {
            sprᲆ rᲆ = sprᲆ.ᜀ(A_0.method_11(), true);
            rᲆ.ᜀ(new spr⚪(sprⓚ.᜶, 0.1f));
            r➓.ᜁ(rᲆ);
        }
        return r➓;
    }
}

