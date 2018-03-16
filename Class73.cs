using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;

internal class Class73
{
    private static readonly Color color_0 = Color.White;
    private const float float_0 = 0.238f;
    private readonly Stack stack_0 = new Stack();

    internal Class73()
    {
        this.stack_0.Push(null);
    }

    internal void method_0(Class678 A_0)
    {
        this.stack_0.Push(smethod_3(A_0) ? A_0 : this.stack_0.Peek());
    }

    internal void method_1()
    {
        this.stack_0.Pop();
    }

    internal Color method_2(Color A_0)
    {
        if (!A_0.IsEmpty)
        {
            return A_0;
        }
        Class678 class2 = (Class678) this.stack_0.Peek();
        if (class2 != null)
        {
            return smethod_2(class2);
        }
        return Color.Black;
    }

    internal static Color smethod_0(Color A_0)
    {
        if (!A_0.IsEmpty)
        {
            return A_0;
        }
        return color_0;
    }

    internal static Color smethod_1(Color A_0)
    {
        if (!A_0.IsEmpty)
        {
            return A_0;
        }
        return Color.Black;
    }

    private static Color smethod_2(Class678 A_0)
    {
        TextureStyle style = A_0.method_13();
        switch (style)
        {
            case TextureStyle.TextureNone:
            case TextureStyle.TextureNil:
                if (!A_0.method_7().IsEmpty && (smethod_4(A_0.method_7()) <= 0.238f))
                {
                    return Color.White;
                }
                return Color.Black;
        }
        if (!Class955.smethod_13(style))
        {
            float num = (float) Class955.smethod_11(style);
            float num2 = smethod_4(smethod_1(A_0.method_11())) * num;
            float num3 = 1f - num;
            float num4 = smethod_4(smethod_0(A_0.method_7())) * num3;
            float num5 = num2 + num4;
            if (num5 <= 0.238f)
            {
                return Color.White;
            }
        }
        return Color.Black;
    }

    private static bool smethod_3(Class678 A_0)
    {
        return ((A_0 != null) && A_0.method_27());
    }

    private static float smethod_4(Color A_0)
    {
        float num = (0.3f * A_0.R) / 255f;
        float num2 = (0.59f * A_0.G) / 255f;
        float num3 = (0.11f * A_0.B) / 255f;
        return ((num + num2) + num3);
    }
}

