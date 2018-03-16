using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

internal class Class450 : spr᥋
{
    internal bool bool_0;
    private readonly Class780 class780_0 = new Class780();
    private Graphics graphics_0;
    private PointF pointF_0;
    private spr⇄ spr⇄_0;
    private readonly Stack stack_0 = new Stack();
    private readonly Stack stack_1 = new Stack();
    private readonly Stack stack_2 = new Stack();
    private static readonly StringFormat stringFormat_0 = new StringFormat(StringFormat.GenericTypographic);

    static Class450()
    {
        stringFormat_0.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
    }

    public void method_0(sprᮃ A_0, Graphics A_1)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䤦䘨伪䠬", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀦嬨䨪崬䜮堰倲䘴", num));
        }
        GraphicsUnit pageUnit = A_1.PageUnit;
        A_1.PageUnit = GraphicsUnit.Point;
        float pageScale = A_1.PageScale;
        A_1.PageScale = 1f;
        this.graphics_0 = A_1;
        using (this.spr⇄_0 = new spr⇄())
        {
            A_0.ᜀ(this);
        }
        A_1.PageScale = pageScale;
        A_1.PageUnit = pageUnit;
    }

    public void method_1(sprᮃ A_0, Graphics A_1, PointF A_2)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堵圷帹夻", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("儵䨷嬹䰻嘽⤿⅁㝃", num));
        }
        GraphicsUnit pageUnit = A_1.PageUnit;
        A_1.PageUnit = GraphicsUnit.Point;
        float pageScale = A_1.PageScale;
        A_1.PageScale = 1f;
        this.graphics_0 = A_1;
        this.pointF_0 = A_2;
        using (this.spr⇄_0 = new spr⇄())
        {
            A_0.ᜀ(this);
        }
        A_1.PageScale = pageScale;
        A_1.PageUnit = pageUnit;
    }

    private bool method_10(int A_0, int A_1)
    {
        double num = 10485760.0;
        double num2 = A_0 * A_1;
        return (num2 > num);
    }

    internal Image method_11(Image A_0, float A_1, float A_2)
    {
        Image image = A_0;
        if ((A_0 is Bitmap) && ((A_0.HorizontalResolution > 300f) || (A_0.VerticalResolution > 300f)))
        {
            int num3 = (int) Math.Round((double) (A_0.Width * (300f / A_0.HorizontalResolution)));
            int num4 = (int) Math.Round((double) (A_0.Height * (300f / A_0.VerticalResolution)));
            Bitmap bitmap2 = new Bitmap(num3, num4);
            bitmap2.SetResolution(300f, 300f);
            using (Graphics graphics2 = Graphics.FromImage(bitmap2))
            {
                graphics2.DrawImage(A_0, new RectangleF(0f, 0f, (float) num3, (float) num4));
            }
            A_0.Dispose();
            A_0 = null;
            image = bitmap2;
        }
        if (((A_1 * 6.25) >= image.Width) && ((A_2 * 6.25) >= image.Height))
        {
            return image;
        }
        int width = (int) Math.Round((double) (A_1 * 6.25));
        int height = (int) Math.Round((double) (A_2 * 6.25));
        Bitmap bitmap = new Bitmap(width, height);
        bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            graphics.DrawImage(image, new RectangleF(0f, 0f, (float) width, (float) height));
        }
        image.Dispose();
        image = null;
        return bitmap;
    }

    private void method_12(spr⟯ A_0)
    {
        this.stack_2.Push(this.graphics_0.Save());
        if (spr▍.ᜁ(A_0))
        {
            this.stack_0.Push(this.graphics_0.Transform.Clone());
            using (Matrix matrix = spr⊷.ᜁ(A_0.ᜀ()))
            {
                if (!this.pointF_0.IsEmpty && this.graphics_0.Transform.IsIdentity)
                {
                    this.graphics_0.TranslateTransform(this.pointF_0.X, this.pointF_0.Y, MatrixOrder.Prepend);
                }
                this.graphics_0.MultiplyTransform(matrix, MatrixOrder.Prepend);
            }
        }
        if (spr▍.ᜀ(A_0))
        {
            this.stack_1.Push(this.graphics_0.Clip.Clone());
            A_0.ᜁ().ᜀ(this.class780_0);
            this.graphics_0.SetClip(this.class780_0.method_0(), CombineMode.Intersect);
        }
    }

    private void method_13(spr⟯ A_0)
    {
        if (spr▍.ᜀ(A_0))
        {
            this.graphics_0.Clip = (Region) this.stack_1.Pop();
        }
        if (spr▍.ᜁ(A_0))
        {
            this.graphics_0.Transform = (Matrix) this.stack_0.Pop();
        }
        this.graphics_0.Restore((GraphicsState) this.stack_2.Pop());
    }

    public SizeF method_2(sprᮃ A_0, SizeF A_1, Graphics A_2, float A_3, float A_4, float A_5)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堸䬺丼", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("常䤺尼伾⥀⩂♄㑆", num));
        }
        if (A_5 <= 0f)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䨸堺尼匾⑀", num));
        }
        Matrix matrix = smethod_0(A_2, A_3, A_4);
        matrix.Scale(A_5, A_5, MatrixOrder.Prepend);
        Matrix transform = A_2.Transform;
        A_2.Transform = matrix;
        this.method_0(A_0, A_2);
        A_2.Transform = transform;
        PointF tf = smethod_2(A_1.ToPointF(), A_2);
        return new SizeF(tf.X * A_5, tf.Y * A_5);
    }

    public float method_3(sprᮃ A_0, SizeF A_1, Graphics A_2, float A_3, float A_4, float A_5, float A_6)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唳䘵䬷", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("匳䐵夷䨹吻圽⌿ㅁ", num));
        }
        if (A_5 <= 0f)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌳張尷丹吻", num));
        }
        if (A_6 <= 0f)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尳匵儷崹吻䨽", num));
        }
        Matrix matrix = smethod_0(A_2, A_3, A_4);
        PointF tf = smethod_1(new PointF(A_5, A_6), A_2);
        float num2 = tf.X / A_1.Width;
        float num3 = tf.Y / A_1.Height;
        float scaleX = Math.Min(num2, num3);
        matrix.Scale(scaleX, scaleX, MatrixOrder.Prepend);
        Matrix transform = A_2.Transform;
        A_2.Transform = matrix;
        this.method_0(A_0, A_2);
        A_2.Transform = transform;
        return scaleX;
    }

    private Image method_4(Image A_0, float A_1, float A_2)
    {
        if ((A_0.Width <= A_1) && (A_0.Height <= A_2))
        {
            return A_0;
        }
        int width = A_0.Width;
        int height = A_0.Height;
        int x = 0;
        int y = 0;
        int num3 = 0;
        int num4 = 0;
        int num = (int) A_1;
        int num2 = (int) A_2;
        if (num <= 0)
        {
            num = 1;
        }
        if (num2 <= 0)
        {
            num2 = 1;
        }
        Bitmap image = new Bitmap(num, num2);
        image.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(A_0, new Rectangle(num3, num4, num, num2), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            graphics.Dispose();
        }
        return image;
    }

    private void method_5(sprἣ A_0)
    {
        Image image = Image.FromStream(new MemoryStream(A_0.ᜊ()));
        if (image is Metafile)
        {
            image = this.method_9(image);
        }
        sprᤘ rᤘ = A_0.ᜄ();
        ImageAttributes imageAttr = null;
        if (A_0.ᜈ() != null)
        {
            imageAttr = new ImageAttributes();
            imageAttr.SetColorKey(A_0.ᜈ().ᜂ().ᜉ(), A_0.ᜈ().ᜁ().ᜉ());
        }
        GraphicsUnit pixel = GraphicsUnit.Pixel;
        RectangleF bounds = image.GetBounds(ref pixel);
        RectangleF ef2 = A_0.ᜂ();
        PointF[] destPoints = new PointF[] { ef2.Location, new PointF(ef2.X + ef2.Width, ef2.Y), new PointF(ef2.X, ef2.Y + ef2.Height) };
        if (!sprᤘ.ᜀ(rᤘ))
        {
            bounds = rᤘ.ᜀ(bounds);
        }
        if (this.bool_0)
        {
            spr➂ r➂ = (A_0.᜙() as spr➓).ᜀ();
            float num = ef2.Width * r➂.ᜐ();
            float num2 = ef2.Height * r➂.ᜌ();
            image = this.method_11(image, num, num2);
            bounds = new RectangleF(0f, 0f, (float) image.Width, (float) image.Height);
        }
        this.graphics_0.DrawImage(image, destPoints, bounds, pixel, imageAttr);
        if (image == null)
        {
            image.Dispose();
        }
    }

    private Image method_6(Image A_0, RectangleF A_1, RectangleF A_2, GraphicsUnit A_3, ImageAttributes A_4)
    {
        Bitmap image = null;
        try
        {
            if ((A_1.Width > 0f) && (A_1.Height > 0f))
            {
                image = new Bitmap((int) A_1.Width, (int) A_1.Height);
            }
            else
            {
                image = new Bitmap(A_0.Width, A_0.Height);
            }
        }
        catch
        {
            image = new Bitmap(A_0.Width, A_0.Height);
        }
        using (Graphics graphics = Graphics.FromImage(image))
        {
            PointF[] destPoints = new PointF[] { A_1.Location, new PointF(A_1.X + A_1.Width, A_1.Y), new PointF(A_1.X, A_1.Y + A_1.Height) };
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(A_0, destPoints, A_2, A_3, A_4);
            graphics.Dispose();
        }
        return image;
    }

    private Bitmap method_7(Image A_0, SizeF A_1)
    {
        float num4;
        int num = 300;
    Label_000C:
        num4 = ((float) num) / A_1.Height;
        float num5 = ((float) num) / A_1.Width;
        int num2 = (int) (A_0.Size.Width * num5);
        int num3 = (int) (A_0.Size.Height * num4);
        if (this.method_10(num2, num3))
        {
            num /= 2;
            goto Label_000C;
        }
        Bitmap bitmap = new Bitmap(num2, num3);
        bitmap.SetResolution((float) num, (float) num);
        using (Graphics graphics = this.method_8(bitmap))
        {
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(A_0, 0, 0);
            A_0.Dispose();
        }
        return bitmap;
    }

    private Graphics method_8(Image A_0)
    {
        return Graphics.FromImage(A_0);
    }

    private Bitmap method_9(Image A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        return this.method_7(A_0, new SizeF(A_0.HorizontalResolution, A_0.VerticalResolution));
    }

    private static Matrix smethod_0(Graphics A_0, float A_1, float A_2)
    {
        Matrix transform = A_0.Transform;
        PointF tf = smethod_1(new PointF(transform.OffsetX, transform.OffsetY), A_0);
        float[] elements = transform.Elements;
        Matrix matrix2 = new Matrix(elements[0], elements[1], elements[2], elements[3], tf.X, tf.Y);
        PointF tf2 = smethod_1(new PointF(A_1, A_2), A_0);
        matrix2.Translate(tf2.X, tf2.Y, MatrixOrder.Prepend);
        return matrix2;
    }

    private static PointF smethod_1(PointF A_0, Graphics A_1)
    {
        int num = 13;
        switch (A_1.PageUnit)
        {
            case GraphicsUnit.World:
            case GraphicsUnit.Point:
                break;

            case GraphicsUnit.Display:
                if ((A_1.DpiX < 300f) || (A_1.DpiY < 300f))
                {
                    A_0.X = (float) spr⤋.ᜄ((double) A_0.X, (double) A_1.DpiX);
                    A_0.Y = (float) spr⤋.ᜄ((double) A_0.Y, (double) A_1.DpiY);
                    break;
                }
                A_0.X = (float) spr⤋.ᜄ((double) A_0.X, 100.0);
                A_0.Y = (float) spr⤋.ᜄ((double) A_0.Y, 100.0);
                break;

            case GraphicsUnit.Pixel:
                A_0.X = (float) spr⤋.ᜄ((double) A_0.X, (double) A_1.DpiX);
                A_0.Y = (float) spr⤋.ᜄ((double) A_0.Y, (double) A_1.DpiY);
                break;

            case GraphicsUnit.Inch:
                A_0.X = (float) spr⤋.᜗((double) A_0.X);
                A_0.Y = (float) spr⤋.᜗((double) A_0.Y);
                break;

            case GraphicsUnit.Document:
                A_0.X = (float) spr⤋.ᜄ((double) A_0.X, 300.0);
                A_0.Y = (float) spr⤋.ᜄ((double) A_0.Y, 300.0);
                break;

            case GraphicsUnit.Millimeter:
                A_0.X = (float) spr⤋.᜕((double) A_0.X);
                A_0.Y = (float) spr⤋.᜕((double) A_0.Y);
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("昲嬴尶圸吺䨼儾慀⑂㝄♆㥈⍊⑌ⱎ≐獒⁔㥖じ⽚獜", num));
        }
        return new PointF(A_0.X * A_1.PageScale, A_0.Y * A_1.PageScale);
    }

    private static PointF smethod_2(PointF A_0, Graphics A_1)
    {
        PointF tf = smethod_1(new PointF(1f, 1f), A_1);
        return new PointF(A_0.X / tf.X, A_0.Y / tf.Y);
    }

    public override void vmethod_0(spr⚢ A_0)
    {
        if (A_0.ᜒ().ᜑ() >= 0.1f)
        {
            this.method_12(A_0);
            PointF point = new PointF(A_0.ᜏ(), A_0.ᜊ());
            if (sprⓚ.ᜀ(A_0.᜘(), sprⓚ.ទ))
            {
                spr⡅ r⡅ = new spr⡅(A_0.᜘());
                using (Brush brush = spr⏓.ᜀ(r⡅))
                {
                    using (Font font2 = sprḊ.ᜀ(A_0.ᜒ(), this.spr⇄_0))
                    {
                        this.graphics_0.DrawString(A_0.᜕(), font2, brush, point, stringFormat_0);
                    }
                }
            }
            if (sprⓚ.ᜀ(A_0.ᜎ(), sprⓚ.ទ))
            {
                GraphicsPath path = new GraphicsPath();
                using (Font font = sprḊ.ᜀ(A_0.ᜒ(), this.spr⇄_0))
                {
                    path.AddString(A_0.᜕(), font.FontFamily, (int) font.Style, A_0.ᜒ().ᜑ(), point, stringFormat_0);
                }
                spr⚪ r⚪ = new spr⚪(A_0.ᜎ());
                using (Pen pen = spr➮.ᜀ(r⚪))
                {
                    this.graphics_0.DrawPath(pen, path);
                }
            }
            this.method_13(A_0);
        }
    }

    public override void vmethod_1(spr➓ A_0)
    {
        this.method_12(A_0);
    }

    public override void vmethod_2(spr➓ A_0)
    {
        this.method_13(A_0);
    }

    public override void vmethod_3(sprᲆ A_0)
    {
        this.method_12(A_0);
        this.class780_0.ᜀ(A_0);
    }

    public override void vmethod_4(sprᲆ A_0)
    {
        this.class780_0.ᜂ(A_0);
        if (A_0.ᜈ() != null)
        {
            using (Brush brush = spr⏓.ᜀ(A_0.ᜈ()))
            {
                this.graphics_0.FillPath(brush, this.class780_0.method_0());
            }
        }
        if (A_0.ᜀ() != null)
        {
            using (Pen pen = spr➮.ᜀ(A_0.ᜀ()))
            {
                this.graphics_0.DrawPath(pen, this.class780_0.method_0());
            }
        }
        this.method_13(A_0);
    }

    public override void vmethod_5(sprᧂ A_0)
    {
        this.class780_0.ᜀ(A_0);
    }

    public override void vmethod_6(sprᧂ A_0)
    {
        this.class780_0.ᜁ(A_0);
    }

    public override void vmethod_7(spr៧ A_0)
    {
        this.class780_0.ᜀ(A_0);
    }

    public override void vmethod_8(sprᡉ A_0)
    {
        this.class780_0.ᜀ(A_0);
    }

    public override void vmethod_9(sprἣ A_0)
    {
        try
        {
            this.method_5(A_0);
        }
        catch
        {
            this.method_5(sprἣ.ᜀ(A_0));
        }
    }
}

