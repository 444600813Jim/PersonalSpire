using System;
using System.Globalization;

internal class Class738
{
    private Class738()
    {
    }

    public static char smethod_0(char A_0)
    {
        return char.ToUpper(A_0, CultureInfo.InvariantCulture);
    }

    public static char smethod_1(char A_0)
    {
        return char.ToLower(A_0, CultureInfo.InvariantCulture);
    }

    public static bool smethod_2(char A_0)
    {
        return (char.GetUnicodeCategory(A_0) == UnicodeCategory.PrivateUse);
    }
}

