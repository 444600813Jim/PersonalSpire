using System;
using System.IO;

internal static class Class59
{
    public const double double_0 = 0.75;
    public const double double_1 = 0.5;

    internal static Stream smethod_0(Stream A_0)
    {
        Stream stream = new MemoryStream();
        using (StreamReader reader = new StreamReader(A_0))
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(reader.ReadToEnd());
            }
        }
        A_0.Position = 0L;
        stream.Position = 0L;
        return stream;
    }

    public static int smethod_1(double A_0, double A_1, bool A_2)
    {
        if (A_2)
        {
            return smethod_3(A_0, A_1, 0.75);
        }
        return smethod_3(A_0, A_1, 0.5);
    }

    public static int smethod_2(double A_0, double A_1)
    {
        return smethod_1(A_0, A_1, true);
    }

    public static int smethod_3(double A_0, double A_1, double A_2)
    {
        if (A_0 > A_1)
        {
            if ((A_0 - A_1) < A_2)
            {
                return 0;
            }
            return 1;
        }
        if (A_0 >= A_1)
        {
            return 0;
        }
        if ((A_1 - A_0) < A_2)
        {
            return 0;
        }
        return -1;
    }

    public static sbyte smethod_4(float A_0, float A_1, float A_2)
    {
        if (Math.Abs((float) (A_0 - A_1)) < A_2)
        {
            return 0;
        }
        if (A_0 > A_1)
        {
            return 1;
        }
        return -1;
    }

    public static sbyte smethod_5(double A_0, double A_1, double A_2)
    {
        if (Math.Abs((double) (A_0 - A_1)) < A_2)
        {
            return 0;
        }
        if (A_0 > A_1)
        {
            return 1;
        }
        return -1;
    }

    public static float smethod_6(float A_0, byte A_1)
    {
        double num = 1.0;
        switch (A_1)
        {
            case 1:
                num = 10.0;
                break;

            case 2:
                num = 100.0;
                break;

            case 3:
                num = 1000.0;
                break;

            case 4:
                num = 10000.0;
                break;

            case 5:
                num = 100000.0;
                break;

            case 6:
                num = 1000000.0;
                break;
        }
        int num3 = (int) Math.Round((double) (A_0 * num));
        return (float) (((double) num3) / num);
    }

    public static float smethod_7(float A_0)
    {
        return smethod_6(A_0, 2);
    }

    public static int smethod_8(float A_0, int A_1)
    {
        return (int) Math.Round((double) A_0, A_1);
    }
}

