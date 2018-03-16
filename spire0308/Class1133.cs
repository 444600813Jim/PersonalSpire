using System;

internal class Class1133
{
    private Class1133()
    {
    }

    public static double smethod_0(double A_0)
    {
        return (0.017453292519943295 * A_0);
    }

    public static double smethod_1(double A_0)
    {
        return (57.295779513082323 * A_0);
    }

    public static double smethod_2(double A_0, double A_1, double A_2)
    {
        return Math.Min(Math.Max(A_0, A_1), A_2);
    }

    public static float smethod_3(float A_0, float A_1, float A_2)
    {
        return Math.Min(Math.Max(A_0, A_1), A_2);
    }

    public static double[] smethod_4(double[] A_0, double[] A_1)
    {
        int length = A_1.Length;
        double[] numArray = new double[length];
        for (int i = 0; i < A_0.Length; i++)
        {
            numArray[i / length] += A_0[i] * A_1[i % length];
        }
        return numArray;
    }

    public static int smethod_5(double A_0)
    {
        return (int) Math.Round(A_0);
    }

    public static int smethod_6(double A_0)
    {
        return (int) A_0;
    }

    public static bool smethod_7(double A_0)
    {
        return (Math.Abs(A_0) < double.Epsilon);
    }

    public static bool smethod_8(double A_0, double A_1)
    {
        return smethod_9(A_0, A_1, 1E-10);
    }

    public static bool smethod_9(double A_0, double A_1, double A_2)
    {
        return (Math.Abs((double) (A_0 - A_1)) < Math.Abs(A_2));
    }
}

