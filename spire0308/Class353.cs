using System;
using System.IO;

internal class Class353
{
    private const int int_0 = 0x76c;

    internal static DateTime smethod_0(int A_0)
    {
        if (A_0 == 0)
        {
            return DateTime.MinValue;
        }
        int minute = A_0 & 0x3f;
        int hour = (A_0 & 0x7c0) >> 6;
        int day = (A_0 & 0xf800) >> 11;
        int month = (A_0 & 0xf0000) >> 0x10;
        int year = ((A_0 & 0x1ff00000) >> 20) + 0x76c;
        try
        {
            return new DateTime(year, month, day, hour, minute, 0, 0);
        }
        catch (Exception)
        {
            return DateTime.MinValue;
        }
    }

    internal static int smethod_1(DateTime A_0)
    {
        if (A_0.Year < 0x76c)
        {
            return 0;
        }
        int num = 0;
        num = 0 | A_0.Minute;
        num |= A_0.Hour << 6;
        num |= A_0.Day << 11;
        num |= A_0.Month << 0x10;
        num |= (A_0.Year - 0x76c) << 20;
        return (num | (((int) A_0.DayOfWeek) << 0x1d));
    }

    internal static DateTime smethod_2(BinaryReader A_0)
    {
        return smethod_0(A_0.ReadInt32());
    }

    internal static void smethod_3(DateTime A_0, BinaryWriter A_1)
    {
        A_1.Write(smethod_1(A_0));
    }

    internal static void smethod_4(DateTime A_0, BinaryWriter A_1)
    {
        if (A_0 == DateTime.MinValue)
        {
            smethod_3(DateTime.MinValue, A_1);
        }
        else
        {
            smethod_3(A_0.ToLocalTime(), A_1);
        }
    }
}

