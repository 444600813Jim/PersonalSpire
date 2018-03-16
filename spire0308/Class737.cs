using Spire.Doc;
using System;
using System.Globalization;

internal class Class737
{
    private Class737()
    {
    }

    public static bool smethod_0(string A_0, int A_1, string A_2, int A_3, int A_4)
    {
        return (string.Compare(A_0, A_1, A_2, A_3, A_4) == 0);
    }

    public static bool smethod_1(string A_0, string A_1)
    {
        return (string.Compare(A_0, A_1, true) == 0);
    }

    public static bool smethod_2(string A_0, string A_1)
    {
        return smethod_4(A_0, A_1, 0x7fffffff);
    }

    public static bool smethod_3(string A_0, string A_1)
    {
        return smethod_4(A_0, A_1, A_1.Length);
    }

    private static bool smethod_4(string A_0, string A_1, int A_2)
    {
        if (!object.ReferenceEquals(A_0, A_1))
        {
            if ((A_0 == null) || (A_1 == null))
            {
                return false;
            }
            int num3 = Math.Min(A_0.Length, A_2);
            int num4 = Math.Min(A_1.Length, A_2);
            if (num3 != num4)
            {
                return false;
            }
            int num5 = 0;
            for (int i = 0; num5 < num3; i++)
            {
                if (i >= num4)
                {
                    break;
                }
                int num = A_0[num5];
                int num2 = A_1[i];
                if ((num | num2) <= 0x7f)
                {
                    if ((num >= 0x61) && (num <= 0x7a))
                    {
                        num ^= 0x20;
                    }
                    if ((num2 >= 0x61) && (num2 <= 0x7a))
                    {
                        num2 ^= 0x20;
                    }
                    if (num != num2)
                    {
                        return false;
                    }
                }
                else if (num != num2)
                {
                    num = char.ToUpper((char) num, CultureInfo.InvariantCulture);
                    num2 = char.ToUpper((char) num2, CultureInfo.InvariantCulture);
                    if (num != num2)
                    {
                        num = char.ToLower((char) num, CultureInfo.InvariantCulture);
                        num2 = char.ToLower((char) num2, CultureInfo.InvariantCulture);
                        if (num != num2)
                        {
                            return false;
                        }
                    }
                }
                num5++;
            }
        }
        return true;
    }

    public static int smethod_5(string A_0, string A_1)
    {
        return CultureInfo.CurrentCulture.CompareInfo.Compare(A_0, A_1, CompareOptions.StringSort);
    }

    public static string smethod_6(string A_0, string A_1, int A_2)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("帬䀮䐰䄲嘴制樸伺似嘾⽀⑂", num));
        }
        if (A_1 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("帬嬮䌰娲嬴倶洸吺琼儾㉀♂㝄㍆", num));
        }
        if ((A_2 < 0) || (A_2 > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䐬䄮唰嘲䴴", num));
        }
        return A_0.Insert(A_2, A_1);
    }

    public static string smethod_7(string A_0, int A_1, int A_2)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("否䘨帪弬䰮吰怲䄴䔶倸唺娼", num));
        }
        if ((A_1 < 0) || (A_1 > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("並䜨伪䠬圮", num));
        }
        if ((A_2 < 0) || ((A_1 + A_2) > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䐦䘨帪䌬嬮", num));
        }
        return A_0.Remove(A_1, A_2);
    }
}

