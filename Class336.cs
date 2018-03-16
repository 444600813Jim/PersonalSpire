using System;

internal class Class336
{
    private Class336()
    {
    }

    public static long smethod_0(long A_0)
    {
        return (((((((((A_0 & 0xffL) << 0x38) | ((A_0 & 0xff00L) << 40)) | ((A_0 & 0xff0000L) << 0x18)) | ((A_0 & 0xff000000L) << 8)) | ((A_0 & 0xff00000000L) >> 8)) | ((A_0 & 0xff0000000000L) >> 0x18)) | ((A_0 & 0xff000000000000L) >> 40)) | ((A_0 >> 0x38) & 0xffL));
    }

    public static int smethod_1(int A_0)
    {
        return (int) smethod_2((uint) A_0);
    }

    public static int smethod_10(int A_0, int A_1)
    {
        return (A_0 ^ A_1);
    }

    public static int smethod_11(int A_0)
    {
        A_0 = (A_0 & 0x55555555) + ((A_0 >> 1) & 0x55555555);
        A_0 = (A_0 & 0x33333333) + ((A_0 >> 2) & 0x33333333);
        A_0 = (A_0 & 0xf0f0f0f) + ((A_0 >> 4) & 0xf0f0f0f);
        A_0 = (A_0 & 0xff00ff) + ((A_0 >> 8) & 0xff00ff);
        A_0 = (A_0 & 0xffff) + ((A_0 >> 0x10) & 0xffff);
        return A_0;
    }

    public static int smethod_12(long A_0)
    {
        A_0 = (A_0 & 0x5555555555555555L) + ((A_0 >> 1) & 0x5555555555555555L);
        A_0 = (A_0 & 0x3333333333333333L) + ((A_0 >> 2) & 0x3333333333333333L);
        A_0 = (A_0 & 0xf0f0f0f0f0f0f0fL) + ((A_0 >> 4) & 0xf0f0f0f0f0f0f0fL);
        A_0 = (A_0 & 0xff00ff00ff00ffL) + ((A_0 >> 8) & 0xff00ff00ff00ffL);
        A_0 = (A_0 & 0xffff0000ffffL) + ((A_0 >> 0x10) & 0xffff0000ffffL);
        A_0 = (A_0 & 0xffffffffL) + ((A_0 >> 0x20) & 0xffffffffL);
        return (int) A_0;
    }

    public static byte smethod_13(byte A_0)
    {
        return (byte) (((((A_0 * 0x802L) & 0x22110L) | ((A_0 * 0x8020L) & 0x88440L)) * 0x10101L) >> 0x10);
    }

    public static uint smethod_2(uint A_0)
    {
        return (uint) (((((A_0 & 0xff) << 0x18) | ((A_0 & 0xff00) << 8)) | ((A_0 & 0xff0000) >> 8)) | ((A_0 & -16777216) >> 0x18));
    }

    public static short smethod_3(short A_0)
    {
        return (short) smethod_4((ushort) A_0);
    }

    public static ushort smethod_4(ushort A_0)
    {
        return (ushort) (((A_0 & 0xff) << 8) | ((A_0 & 0xff00) >> 8));
    }

    public static int smethod_5(int A_0, int A_1, bool A_2)
    {
        if (A_2)
        {
            return (A_0 | A_1);
        }
        return (A_0 & ~A_1);
    }

    public static bool smethod_6(int A_0, int A_1)
    {
        return ((A_0 & A_1) != 0);
    }

    public static bool smethod_7(uint A_0, uint A_1)
    {
        return ((A_0 & A_1) != 0);
    }

    public static bool smethod_8(ushort A_0, ushort A_1)
    {
        return ((A_0 & A_1) != 0);
    }

    public static bool smethod_9(byte A_0, byte A_1)
    {
        return ((A_0 & A_1) != 0);
    }
}

