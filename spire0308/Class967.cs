using System;
using System.IO;

internal class Class967
{
    internal const int int_0 = 0x200;
    internal const int int_1 = 0x40;
    internal const int int_2 = 4;
    internal const int int_3 = 0x80;
    internal const int int_4 = 0x7f;

    internal static long smethod_0(uint A_0, bool A_1)
    {
        if (A_1)
        {
            return (long) ((A_0 + 1) * 0x200);
        }
        return (long) (A_0 * 0x40);
    }

    internal static uint smethod_1(long A_0, bool A_1)
    {
        if (A_1)
        {
            return (uint) ((A_0 / 0x200L) - 1L);
        }
        return (uint) (A_0 / 0x40L);
    }

    internal static void smethod_2(BinaryWriter A_0)
    {
        while ((A_0.BaseStream.Position % 0x200L) != 0L)
        {
            A_0.Write(uint.MaxValue);
        }
    }
}

