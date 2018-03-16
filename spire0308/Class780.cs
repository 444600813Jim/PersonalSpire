using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class780 : spr᥋
{
    private GraphicsPath graphicsPath_0;

    public GraphicsPath method_0()
    {
        return this.graphicsPath_0;
    }

    public override void vmethod_0(sprᲆ A_0)
    {
        this.graphicsPath_0 = new GraphicsPath(A_0.ᜃ());
    }

    public override void vmethod_1(sprᧂ A_0)
    {
        this.graphicsPath_0.StartFigure();
    }

    public override void vmethod_2(sprᧂ A_0)
    {
        if (A_0.ᜁ())
        {
            this.graphicsPath_0.CloseFigure();
        }
    }

    public override void vmethod_3(sprᲆ A_0)
    {
    }

    public override void vmethod_4(spr៧ A_0)
    {
        PointF[] points = A_0.ᜀ().ToArray(typeof(PointF)) as PointF[];
        if ((points != null) && (points.Length > 1))
        {
            bool flag = true;
            PointF tf = points[0];
            for (int i = 1; i < points.Length; i++)
            {
                if (tf != points[i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                points[points.Length - 1] = new PointF(tf.X + 0.5f, tf.Y);
            }
        }
        this.graphicsPath_0.AddLines(points);
    }

    public override void vmethod_5(sprᡉ A_0)
    {
        this.graphicsPath_0.AddBezier(A_0.ᜀ().ᜂ(), A_0.ᜀ().ᜄ(), A_0.ᜀ().ᜃ(), A_0.ᜀ().ᜀ());
    }
}

