using Spire.Doc;
using System;

internal class Class792
{
    private const float float_0 = 100000f;
    private const float float_1 = 1f;
    private const float float_2 = 1f;
    private const float float_3 = 200000f;
    private const float float_4 = 200000f;
    private const float float_5 = 0f;
    private const float float_6 = 1f;
    private const float float_7 = -0.5f;
    private const float float_8 = 0.5f;
    private const int int_0 = 0x186a0;
    private const int int_1 = -100000;
    private const int int_2 = 0x30d40;

    private Class792()
    {
    }

    internal float method_0(float A_0)
    {
        int num = 14;
        if ((A_0 < -0.5f) || (A_0 > 0.5f))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("儳䔵嬷刹夻䰽ȿぁⵃⅅ⁇㹉≋⭍⍏⅑", num));
        }
        return (A_0 + 0.5f);
    }

    internal float method_1(float A_0)
    {
        int num = 13;
        if ((A_0 < -1.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌲倴䔶娸帺匼䬾", num));
        }
        return (A_0 - 0.5f);
    }

    internal static double smethod_0(int A_0)
    {
        return (double) (((float) A_0) / 100000f);
    }

    internal static int smethod_1(double A_0)
    {
        return Class1133.smethod_5(A_0 * 100000.0);
    }

    internal static int smethod_2(int A_0)
    {
        return Class969.smethod_71(smethod_0(A_0));
    }

    internal static int smethod_3(int A_0)
    {
        return smethod_1(Class969.smethod_68(A_0));
    }

    internal static int smethod_4(int A_0)
    {
        return Class969.smethod_71((double) (((float) A_0) / 200000f));
    }

    internal static int smethod_5(int A_0)
    {
        return Class1133.smethod_5(Class969.smethod_68(A_0) * 200000.0);
    }

    internal static int smethod_6(int A_0)
    {
        float num = ((float) (A_0 + 0x186a0)) / 200000f;
        return Class969.smethod_71((double) smethod_9(num));
    }

    internal static int smethod_7(int A_0)
    {
        double num = smethod_8((float) Class969.smethod_68(A_0));
        return Class1133.smethod_5((num * 200000.0) - 100000.0);
    }

    internal static float smethod_8(float A_0)
    {
        if ((A_0 <= 1.0) && (A_0 >= 0f))
        {
            return (A_0 / 2f);
        }
        if (A_0 > 1f)
        {
            return ((A_0 - 0.5f) / A_0);
        }
        return 1f;
    }

    internal static float smethod_9(float A_0)
    {
        int num = 5;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬪䠬崮到嘲嬴䌶", num));
        }
        if (A_0 <= 0.5)
        {
            return (A_0 * 2f);
        }
        if (A_0 >= 1.0)
        {
            return float.MaxValue;
        }
        return (0.5f / (1f - A_0));
    }
}

