using Spire.Doc.Fields;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class723
{
    internal static spr➓ smethod_0(Class672 A_0)
    {
        WordArt wordArt = A_0.method_28().WordArt;
        spr➓ r➓ = new spr➓();
        if (sprḆ.ᜋ(wordArt.Text))
        {
            string str = Class955.smethod_7(wordArt.Text);
            spr⚪ r⚪ = A_0.method_18();
            spr⡅ r⡅2 = A_0.method_19() as spr⡅;
            spr⡅ r⡅ = (r⚪ == null) ? null : (r⚪.ᜌ() as spr⡅);
            SizeF sizeInPoints = A_0.method_28().SizeInPoints;
            float width = sizeInPoints.Width;
            float height = sizeInPoints.Height;
            float rotation = (float) A_0.method_28().Rotation;
            int num7 = smethod_1(wordArt.Bold, wordArt.Italic, wordArt.Underline);
            sprᝪ rᝪ = spr᮵.ᜂ().ᜀ(wordArt.FontFamily, height, (FontStyle) num7, wordArt.FontFamily);
            PointF tf = new PointF(0f, rᝪ.ᜑ() - (rᝪ.ᜏ() - rᝪ.ᜃ()));
            sprⓚ rⓚ2 = ((r⡅2 == null) || sprⓚ.ᜁ(r⡅2.ᜀ(), null)) ? sprⓚ.ទ : r⡅2.ᜀ();
            sprⓚ rⓚ = ((r⡅ == null) || sprⓚ.ᜁ(r⡅.ᜀ(), null)) ? sprⓚ.ទ : r⡅.ᜀ();
            spr⚢ r⚢ = new spr⚢(rᝪ, rⓚ2, rⓚ, tf, str, SizeF.Empty, (float) wordArt.Spacing);
            SizeF ef = rᝪ.ᜃ(str);
            float num2 = width / ef.Width;
            r⚢.ᜀ(new spr➂(num2, 0f, 0f, 1f, 0f, 0f));
            if (rotation != 0f)
            {
                float x = width * 0.5f;
                float y = height * 0.5f;
                r⚢.ᜃ().ᜀ(rotation, new PointF(x, y), MatrixOrder.Append);
            }
            r➓.ᜁ(r⚢);
        }
        return r➓;
    }

    private static int smethod_1(bool A_0, bool A_1, bool A_2)
    {
        int num = 0;
        if (A_0)
        {
            num |= 1;
        }
        if (A_1)
        {
            num |= 2;
        }
        if (A_2)
        {
            num |= 4;
        }
        return num;
    }
}

