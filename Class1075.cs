using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class1075
{
    private Class1075()
    {
    }

    private static sprⓚ smethod_0(sprⓚ A_0, double A_1)
    {
        return new sprⓚ((A_0.ᜁ() != 0xff) ? A_0.ᜁ() : ((int) (255.0 * A_1)), A_0);
    }

    internal static spr᧢ smethod_1(sprⓚ A_0, double A_1)
    {
        return new spr⡅(smethod_0(A_0, A_1));
    }

    private static int smethod_10(int A_0, int A_1, float A_2)
    {
        if (A_1 == A_0)
        {
            return A_0;
        }
        return (A_0 + ((int) ((A_1 - A_0) * (A_2 + (Math.Sign((float) (A_2 - (0.5f + (((float) (A_0 - A_1)) / 765f)))) * 0.1f)))));
    }

    private static void smethod_11(VMLFill A_0, sprℊ A_1)
    {
        Class954[] gradientColors = A_0.GradientColors;
        int length = gradientColors.Length;
        sprᫎ[] sourceArray = new sprᫎ[length];
        for (int i = 0; i < length; i++)
        {
            double num5 = (float) spr⤋.ᜀ(gradientColors[i].int_0);
            double num6 = A_0.Opacity2 + ((A_0.Opacity - A_0.Opacity2) * num5);
            sprⓚ rⓚ = smethod_0(sprⓚ.ᜀ(gradientColors[i].color_0), num6);
            sourceArray[i] = new sprᫎ(rⓚ, (float) num5);
        }
        int num4 = sourceArray.Length;
        if (sourceArray[0].ᜁ() > 0f)
        {
            num4++;
        }
        if (sourceArray[sourceArray.Length - 1].ᜁ() < 1f)
        {
            num4++;
        }
        sprᫎ[] destinationArray = sourceArray;
        if (num4 > sourceArray.Length)
        {
            destinationArray = new sprᫎ[num4];
            int destinationIndex = 0;
            if (sourceArray[0].ᜁ() > 0f)
            {
                destinationArray[0] = new sprᫎ(sourceArray[0].ᜀ(), 0f);
                destinationIndex++;
            }
            Array.Copy(sourceArray, 0, destinationArray, destinationIndex, sourceArray.Length);
            if (sourceArray[sourceArray.Length - 1].ᜁ() < 1f)
            {
                destinationArray[num4 - 1] = new sprᫎ(sourceArray[sourceArray.Length - 1].ᜀ(), 1f);
            }
        }
        A_1.ᜀ(smethod_12(destinationArray, A_0));
    }

    private static sprᫎ[] smethod_12(sprᫎ[] A_0, VMLFill A_1)
    {
        sprᫎ[] rᫎArray;
        float num4;
        float num5;
        float focus = A_1.Focus;
        if (smethod_16(A_1))
        {
            focus = (focus > 0f) ? (focus - 100f) : (focus + 100f);
        }
        if (focus == 0f)
        {
            return A_0;
        }
        int length = A_0.Length;
        if (focus == 100f)
        {
            rᫎArray = new sprᫎ[A_0.Length];
            for (int j = 0; j < length; j++)
            {
                rᫎArray[(length - 1) - j] = new sprᫎ(A_0[j].ᜀ(), 1f - A_0[j].ᜁ());
            }
            return rᫎArray;
        }
        focus *= 0.01f;
        if (focus > 0f)
        {
            num4 = 1f - focus;
            num5 = focus;
        }
        else
        {
            num4 = -focus;
            num5 = 1f + focus;
        }
        rᫎArray = new sprᫎ[length * 2];
        for (int i = 0; i < length; i++)
        {
            sprᫎ rᫎ = A_0[(focus > 0f) ? i : ((length - 1) - i)];
            float num2 = (focus > 0f) ? rᫎ.ᜁ() : (1f - rᫎ.ᜁ());
            rᫎArray[i] = new sprᫎ(rᫎ.ᜀ(), num2 * num4);
            rᫎArray[(rᫎArray.Length - 1) - i] = new sprᫎ(rᫎ.ᜀ(), 1f - (num2 * num5));
        }
        return rᫎArray;
    }

    internal static spr᧢ smethod_13(ShapeObject A_0, SizeF A_1)
    {
        PointF tf;
        VMLFill fill = A_0.Fill;
        sprᲆ rᲆ = new sprᲆ();
        sprᧂ rᧂ = new sprᧂ();
        rᧂ.ᜀ(true);
        rᲆ.ᜁ(rᧂ);
        RectangleF ef = new RectangleF(0f, 0f, A_1.Width, A_1.Height);
        if (A_0.IsTextureRotated)
        {
            tf = spr⃸.ᜁ(spr⃸.ᜀ((float) fill.FocusLeft, (float) fill.FocusTop, ef), spr⃸.ᜁ(ef), (float) A_0.Rotation);
            PointF[] tfArray = spr⃸.ᜀ(ef, (float) A_0.Rotation);
            rᧂ.ᜃ(tfArray);
        }
        else
        {
            RectangleF ef2 = spr⃸.ᜁ(ef, (float) A_0.Rotation);
            tf = spr⃸.ᜀ((float) fill.FocusLeft, (float) fill.FocusTop, ef2);
            rᧂ.ᜁ(ef2);
        }
        return smethod_6(rᲆ, fill, tf);
    }

    internal static spr᧢ smethod_14(ShapeObject A_0, SizeF A_1)
    {
        VMLFill fill = A_0.Fill;
        if (Class1022.smethod_0(A_1))
        {
            return null;
        }
        if (smethod_4(fill))
        {
            return smethod_1(sprⓚ.ᜀ(fill.ColorInternal), fill.Opacity);
        }
        RectangleF ef = new RectangleF(0f, 0f, A_1.Width, A_1.Height);
        float num = -((float) fill.Angle) - 90f;
        float totalRotation = (float) A_0.TotalRotation;
        RectangleF empty = RectangleF.Empty;
        spr➂ r➂ = new spr➂();
        if (A_0.IsTextureRotated)
        {
            r➂.ᜀ(totalRotation + num, spr⃸.ᜁ(ef));
            empty = spr⃸.ᜁ(ef, -num);
        }
        else
        {
            r➂.ᜀ(num, spr⃸.ᜁ(ef));
            empty = spr⃸.ᜁ(spr⃸.ᜁ(ef, totalRotation), -num);
        }
        spr⡀ r⡀ = new spr⡀(empty);
        r⡀.ᜀ(r➂);
        smethod_7(fill, r⡀);
        return r⡀;
    }

    internal static spr᧢ smethod_15(VMLFill A_0, byte[] A_1, Class316 A_2)
    {
        spr⍂ r⍂;
        spr❯ r❯;
        if (A_1 == null)
        {
            A_1 = A_0.ImageBytes;
        }
        if (A_1 == null)
        {
            return smethod_1(sprⓚ.ᜀ(A_0.ColorInternal), A_0.Opacity);
        }
        if (!A_0.Tiled)
        {
            r⍂ = new spr⍂(A_1);
        }
        else
        {
            switch (A_0.Tile.flipOrientation_0)
            {
                case FlipOrientation.Horizontal:
                    r⍂ = new spr⍂(A_1, WrapMode.TileFlipX);
                    goto Label_007E;

                case FlipOrientation.Vertical:
                    r⍂ = new spr⍂(A_1, WrapMode.TileFlipY);
                    goto Label_007E;

                case FlipOrientation.Both:
                    r⍂ = new spr⍂(A_1, WrapMode.TileFlipXY);
                    goto Label_007E;
            }
            r⍂ = new spr⍂(A_1, WrapMode.Tile);
        }
    Label_007E:
        r❯ = spr≨.᜚(A_1);
        r⍂.ᜀ(A_2.method_3(r❯, A_0.LockAspectRatio, A_0));
        return r⍂;
    }

    internal static bool smethod_16(VMLFill A_0)
    {
        switch (A_0.FillType)
        {
            case FillType.Shade:
            case FillType.ShadeScale:
            case FillType.ShadeTitle:
                switch (((int) A_0.Angle))
                {
                    case -135:
                    case -90:
                    case -45:
                        return true;
                }
                return false;
        }
        return false;
    }

    internal static spr᧢ smethod_2(byte[] A_0, byte[] A_1, sprⓚ A_2, sprⓚ A_3)
    {
        if (A_1 == null)
        {
            A_1 = A_0;
        }
        if (A_1 == null)
        {
            return smethod_1(A_2, 1.0);
        }
        spr⍂ r⍂ = new spr⍂(A_1);
        sprⓚ[] rⓚArray = new sprⓚ[] { sprⓚ.ឌ, A_2, sprⓚ.ᜋ, A_3 };
        r⍂.ᜀ(rⓚArray);
        r⍂.ᜋ().ᜁ(0.75f, 0.75f, MatrixOrder.Prepend);
        return r⍂;
    }

    internal static spr᧢ smethod_3(VMLFill A_0, byte[] A_1, Class316 A_2)
    {
        if (A_1 == null)
        {
            A_1 = A_0.ImageBytes;
        }
        if (A_1 == null)
        {
            return smethod_1(sprⓚ.ᜀ(A_0.ColorInternal), A_0.Opacity);
        }
        spr⍂ r⍂ = new spr⍂(A_1, WrapMode.Clamp);
        r⍂.ᜀ((float) A_0.Opacity);
        spr❯ r❯ = spr≨.᜚(A_1);
        r⍂.ᜀ(A_2.method_2(r❯, A_0.LockAspectRatio, A_0));
        return r⍂;
    }

    private static bool smethod_4(VMLFill A_0)
    {
        return ((smethod_5(A_0) && (A_0.ColorInternal.ToArgb() == A_0.Color2Internal.ToArgb())) && (A_0.Opacity == A_0.Opacity2));
    }

    private static bool smethod_5(VMLFill A_0)
    {
        if (A_0.GradientColors != null)
        {
            return (A_0.GradientColors.Length == 0);
        }
        return true;
    }

    internal static spr᧢ smethod_6(sprᲆ A_0, VMLFill A_1, PointF A_2)
    {
        if (smethod_4(A_1))
        {
            return smethod_1(sprⓚ.ᜀ(A_1.ColorInternal), A_1.Opacity);
        }
        sprẸ rẹ = new sprẸ(A_0, A_2);
        smethod_7(A_1, rẹ);
        return rẹ;
    }

    private static void smethod_7(VMLFill A_0, sprℊ A_1)
    {
        if (smethod_5(A_0))
        {
            smethod_8(A_0, A_1);
        }
        else
        {
            smethod_11(A_0, A_1);
        }
    }

    private static void smethod_8(VMLFill A_0, sprℊ A_1)
    {
        sprⓚ rⓚ = sprⓚ.ᜀ(A_0.ColorInternal);
        sprⓚ rⓚ2 = Class727.smethod_0(sprⓚ.ᜀ(A_0.Color2Internal), rⓚ);
        rⓚ = smethod_0(rⓚ, A_0.Opacity);
        rⓚ2 = smethod_0(rⓚ2, A_0.Opacity2);
        sprᫎ[] rᫎArray = new sprᫎ[] { new sprᫎ(rⓚ, 0f), new sprᫎ(smethod_9(rⓚ, rⓚ2, 0.2f), 0.2f), new sprᫎ(smethod_9(rⓚ, rⓚ2, 0.4f), 0.4f), new sprᫎ(smethod_9(rⓚ, rⓚ2, 0.6f), 0.6f), new sprᫎ(smethod_9(rⓚ, rⓚ2, 0.8f), 0.8f), new sprᫎ(rⓚ2, 1f) };
        A_1.ᜀ(smethod_12(rᫎArray, A_0));
    }

    private static sprⓚ smethod_9(sprⓚ A_0, sprⓚ A_1, float A_2)
    {
        A_2 = spr⃘.ᜀ(A_2, 0f, 1f);
        return new sprⓚ(smethod_10(A_0.ᜁ(), A_1.ᜁ(), A_2), smethod_10(A_0.ᜃ(), A_1.ᜃ(), A_2), smethod_10(A_0.ᜇ(), A_1.ᜇ(), A_2), smethod_10(A_0.ᜄ(), A_1.ᜄ(), A_2));
    }
}

