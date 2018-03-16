using Spire.Doc.Fields;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

internal class Class1120
{
    internal static spr➓ smethod_0(Class672 A_0)
    {
        SizeF ef2;
        WordArt wordArt = A_0.method_28().WordArt;
        spr➓ r➓ = A_0.method_10();
        spr⚪ r⚪ = A_0.method_18();
        spr᧢ r᧢ = A_0.method_19();
        SizeF sizeInPoints = A_0.method_28().SizeInPoints;
        float height = sizeInPoints.Height;
        GraphicsPath path = smethod_3(wordArt, height, out ef2);
        if (path.PointCount == 0)
        {
            return null;
        }
        if ((r➓.ᜋ() == 1) && wordArt.FitShape)
        {
            sprᲆ rᲆ = r➓.ᜀ(0);
            if (rᲆ.ᜋ() == 2)
            {
                spr➓ r➓2;
                try
                {
                    r➓2 = smethod_2(smethod_7(path, (sprᧂ) rᲆ.ᜀ(0), (sprᧂ) rᲆ.ᜀ(1), wordArt.Trim, height, ef2), r⚪, r᧢);
                }
                catch (Exception8)
                {
                    goto Label_00B8;
                }
                return r➓2;
            }
        }
    Label_00B8:
        return smethod_2(smethod_1(A_0, path, sizeInPoints), r⚪, r᧢);
    }

    private static sprᲆ smethod_1(Class672 A_0, GraphicsPath A_1, SizeF A_2)
    {
        sprᧂ rᧂ = new sprᧂ();
        PointF[] tfArray = new PointF[] { PointF.Empty, new PointF(A_2.Width, 0f) };
        rᧂ.ᜁ(new spr៧(tfArray));
        sprᧂ rᧂ2 = new sprᧂ();
        PointF[] tfArray2 = new PointF[] { new PointF(0f, A_2.Height), new PointF(A_2.Width, A_2.Height) };
        rᧂ2.ᜁ(new spr៧(tfArray2));
        return smethod_7(A_1, rᧂ, rᧂ2, true, A_2.Height, SizeF.Empty);
    }

    private static spr➓ smethod_2(sprᲆ A_0, spr⚪ A_1, spr᧢ A_2)
    {
        spr➓ r➓ = new spr➓();
        A_0.ᜀ(A_1);
        A_0.ᜀ(A_2);
        r➓.ᜁ(A_0);
        return r➓;
    }

    private static GraphicsPath smethod_3(WordArt A_0, float A_1, out SizeF A_2)
    {
        if (A_1 <= 0f)
        {
            A_2 = new SizeF(0f, 0f);
            return new GraphicsPath();
        }
        int style = smethod_4(A_0.Bold, A_0.Italic, A_0.StrikeThrough, A_0.Underline);
        using (Font font = sprḊ.ᜀ(A_0.FontFamily, A_1, (FontStyle) style))
        {
            style = (int) font.Style;
            StringFormat format = new StringFormat(StringFormat.GenericTypographic) {
                LineAlignment = StringAlignment.Far
            };
            GraphicsPath path = new GraphicsPath();
            string s = Class955.smethod_7(A_0.Text);
            path.AddString(s, font.FontFamily, style, A_1, new PointF(0f, A_1), format);
            A_2 = smethod_6(s, font, format);
            return path;
        }
    }

    private static int smethod_4(bool A_0, bool A_1, bool A_2, bool A_3)
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
        if (A_3)
        {
            num |= 4;
        }
        return num;
    }

    private static sprᲆ smethod_5(GraphicsPath A_0)
    {
        return new sprᲆ();
    }

    private static SizeF smethod_6(string A_0, Font A_1, StringFormat A_2)
    {
        Bitmap bitmap = new Bitmap(1, 1);
        Graphics graphics = spr᪻.ᜀ(bitmap);
        PointF empty = PointF.Empty;
        SizeF ef = graphics.MeasureString(A_0, A_1, empty, A_2);
        float width = (float) spr⤋.᜗((double) (ef.Width / graphics.DpiX));
        float height = (float) spr⤋.᜗((double) (ef.Height / graphics.DpiY));
        graphics.Dispose();
        bitmap.Dispose();
        return new SizeF(width, height);
    }

    private static sprᲆ smethod_7(GraphicsPath A_0, sprᧂ A_1, sprᧂ A_2, bool A_3, float A_4, SizeF A_5)
    {
        float left;
        float top;
        float width;
        float height;
        if (A_3)
        {
            RectangleF bounds = A_0.GetBounds();
            left = bounds.Left;
            top = bounds.Top;
            width = bounds.Width;
            height = bounds.Height;
        }
        else
        {
            left = 0f;
            top = 0f;
            width = A_5.Width;
            height = A_4;
        }
        PointF[] pathPoints = A_0.PathPoints;
        Class550 class2 = new Class550();
        for (int i = 0; i < pathPoints.Length; i++)
        {
            PointF tf4 = pathPoints[i];
            float num9 = tf4.X - left;
            float num10 = tf4.Y - top;
            float num5 = num9 / width;
            float num7 = num10 / height;
            if (num5 > 1f)
            {
                num5 = 1f;
            }
            if (num7 > 1f)
            {
                num7 = 1f;
            }
            PointF tf = class2.method_1(A_1, num5);
            PointF tf2 = class2.method_1(A_2, num5);
            float num6 = Class550.smethod_1(tf, tf2);
            pathPoints[i] = Class550.smethod_0(tf, tf2, num6 * num7);
        }
        return smethod_8(pathPoints, A_0.PathTypes);
    }

    private static sprᲆ smethod_8(PointF[] A_0, byte[] A_1)
    {
        sprᲆ rᲆ = new sprᲆ();
        sprᧂ rᧂ = null;
        PointF[] tfArray2 = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
        PointF empty = PointF.Empty;
        int index = 0;
        spr៧ spr = null;
        for (int i = 0; i < A_0.Length; i++)
        {
            float x = A_0[i].X;
            float y = A_0[i].Y;
            if (A_1[i] == 0)
            {
                rᧂ = new sprᧂ();
                rᧂ.ᜀ(true);
                spr = null;
                empty = new PointF(x, y);
            }
            else
            {
                if ((A_1[i] & 3) == 3)
                {
                    spr = null;
                    if (index == 0)
                    {
                        tfArray2 = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
                        tfArray2[0] = empty;
                    }
                    index++;
                    tfArray2[index] = new PointF(x, y);
                    if (index == 3)
                    {
                        index = 0;
                        rᧂ.ᜁ(new sprᡉ(tfArray2));
                        empty = tfArray2[3];
                    }
                }
                else if ((A_1[i] & 1) == 1)
                {
                    if (spr == null)
                    {
                        spr = new spr៧();
                        rᧂ.ᜁ(spr);
                        spr.ᜀ().Add(empty);
                    }
                    empty = new PointF(x, y);
                    spr.ᜀ().Add(empty);
                }
                if ((A_1[i] & 0x80) == 0x80)
                {
                    rᲆ.ᜁ(rᧂ);
                    new sprᧂ().ᜀ(true);
                    spr = null;
                    index = 0;
                }
            }
        }
        return rᲆ;
    }
}

