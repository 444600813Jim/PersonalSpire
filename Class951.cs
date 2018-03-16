using System;
using System.Drawing;

internal class Class951
{
    internal static double smethod_0(sprṋ A_0, float A_1)
    {
        double x = 1f - A_1;
        double num2 = Math.Pow(x, 2.0);
        double num3 = Math.Pow((double) A_1, 2.0);
        double num4 = ((((-3f * A_0.ᜂ().X) * num2) + (((3f * A_0.ᜄ().X) * x) * (1f - (3f * A_1)))) + (((3f * A_0.ᜃ().X) * A_1) * (2f - (3f * A_1)))) + ((3f * A_0.ᜀ().X) * num3);
        double num5 = ((((-3f * A_0.ᜂ().Y) * num2) + (((3f * A_0.ᜄ().Y) * x) * (1f - (3f * A_1)))) + (((3f * A_0.ᜃ().Y) * A_1) * (2f - (3f * A_1)))) + ((3f * A_0.ᜀ().Y) * num3);
        double num6 = ((((6f * A_0.ᜂ().X) * x) - ((6f * A_0.ᜄ().X) * (2f - (3f * A_1)))) + ((6f * A_0.ᜃ().X) * (1f - (3f * A_1)))) + ((6f * A_0.ᜀ().X) * A_1);
        double num7 = ((((6f * A_0.ᜂ().Y) * x) - ((6f * A_0.ᜄ().Y) * (2f - (3f * A_1)))) + ((6f * A_0.ᜃ().Y) * (1f - (3f * A_1)))) + ((6f * A_0.ᜀ().Y) * A_1);
        double num8 = Math.Pow(num4, 2.0);
        double num9 = Math.Pow(num5, 2.0);
        return Math.Abs((double) (((num4 * num7) - (num6 * num5)) / Math.Pow(num8 + num9, 1.5)));
    }

    internal static double smethod_1(sprṋ A_0)
    {
        double num = 0.0;
        PointF tf = smethod_2(A_0, 0f);
        for (float i = 0.1f; i <= 1f; i += 0.1f)
        {
            PointF tf2 = tf;
            tf = smethod_2(A_0, i);
            double introduced4 = Math.Pow((double) (tf2.X - tf.X), 2.0);
            num += Math.Sqrt(introduced4 + Math.Pow((double) (tf2.Y - tf.Y), 2.0));
        }
        return num;
    }

    internal static PointF smethod_2(sprṋ A_0, float A_1)
    {
        float num = 1f - A_1;
        double num2 = Math.Pow((double) num, 2.0);
        double num3 = Math.Pow((double) num, 3.0);
        double num4 = Math.Pow((double) A_1, 2.0);
        double num5 = Math.Pow((double) A_1, 3.0);
        return new PointF((float) ((((A_0.ᜂ().X * num3) + (((3f * A_1) * num2) * A_0.ᜄ().X)) + (((3.0 * num4) * num) * A_0.ᜃ().X)) + (num5 * A_0.ᜀ().X)), (float) ((((A_0.ᜂ().Y * num3) + (((3f * A_1) * num2) * A_0.ᜄ().Y)) + (((3.0 * num4) * num) * A_0.ᜃ().Y)) + (num5 * A_0.ᜀ().Y)));
    }
}

