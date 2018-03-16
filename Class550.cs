using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;

internal class Class550 : spr᥋
{
    private bool bool_0;
    private bool bool_1;
    private float float_0;
    private float float_1;
    private PointF pointF_0 = PointF.Empty;

    private float method_0(sprᧂ A_0)
    {
        this.method_2();
        A_0.ᜀ(this);
        float num = this.float_0;
        this.method_2();
        return num;
    }

    internal PointF method_1(sprᧂ A_0, float A_1)
    {
        float num = this.method_0(A_0);
        this.float_1 = num * A_1;
        this.method_3();
        A_0.ᜀ(this);
        return this.pointF_0;
    }

    private void method_2()
    {
        this.float_0 = 0f;
        this.bool_0 = false;
        this.bool_1 = false;
    }

    private void method_3()
    {
        this.float_0 = 0f;
        this.bool_0 = true;
        this.bool_1 = false;
    }

    internal static PointF smethod_0(PointF A_0, PointF A_1, float A_2)
    {
        float num = A_1.Y - A_0.Y;
        float num2 = A_1.X - A_0.X;
        float num3 = num / num2;
        if (num2 == 0f)
        {
            return new PointF(A_0.X, A_0.Y + (A_2 * Math.Sign(num)));
        }
        float num4 = A_2 / ((float) Math.Sqrt((double) (1f + (num3 * num3))));
        if (A_0.X > A_1.X)
        {
            num4 = -num4;
        }
        float num5 = num3 * num4;
        return new PointF(A_0.X + num4, A_0.Y + num5);
    }

    internal static float smethod_1(PointF A_0, PointF A_1)
    {
        float num = A_1.X - A_0.X;
        float num2 = A_1.Y - A_0.Y;
        return (float) Math.Sqrt((double) ((num * num) + (num2 * num2)));
    }

    public override void vmethod_0(spr៧ A_0)
    {
        if (!this.bool_0 || !this.bool_1)
        {
            ArrayList list = A_0.ᜀ();
            if (list.Count >= 2)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    PointF tf = (PointF) list[i - 1];
                    PointF tf2 = (PointF) list[i];
                    float num2 = smethod_1(tf, tf2);
                    this.float_0 += num2;
                    if (this.bool_0 && (this.float_0 >= this.float_1))
                    {
                        this.pointF_0 = smethod_0(tf, tf2, num2 - (this.float_0 - this.float_1));
                        this.bool_1 = true;
                        return;
                    }
                }
            }
        }
    }

    public override void vmethod_1(sprᡉ A_0)
    {
        throw new Exception8(BookmarkStart.b("瀱儳䰵儷弹主ḽ〿⍁ぃ⹅㭇橉ⵋ㱍㕏牑㩓㥕ⱗ穙╛㭝ᑟ䉡ᝣ፥ᡧᩩͫᱭѯ᝱ၳ塵", 12));
    }
}

