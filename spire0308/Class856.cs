using Spire.Doc;
using Spire.Doc.Fields;
using System;

internal class Class856
{
    private Class856()
    {
    }

    internal static double smethod_0(Class857 A_0, DocumentObject A_1, ShapeObject A_2)
    {
        A_0.method_17(null);
        double num = smethod_1(A_0, A_2);
        smethod_2(A_0, A_2);
        A_0.method_7(A_1, A_2);
        return num;
    }

    private static double smethod_1(Class857 A_0, ShapeObject A_1)
    {
        int num = 0x12;
        Class396 class2 = A_0.method_11();
        double naN = double.NaN;
        while (class2.method_19())
        {
            string str;
            if ((((str = class2.method_1()) != null) && (str != BookmarkStart.b("嬷刹崻圽⸿潁⩃⍅ぇ㹉態⁍ㅏ㽑ㅓ", num))) && (str != BookmarkStart.b("嬷唹主倽┿ぁ楃㑅⥇⹉╋㭍⍏", num)))
            {
                if (!(str == BookmarkStart.b("唷匹刻ጽ⠿❁ⵃⅅ⁇㹉", num)))
                {
                    if (((str == BookmarkStart.b("唷匹刻ጽ㜿⭁⁃㉅⁇", num)) || (str == BookmarkStart.b("唷嬹䐻ጽ⠿❁ⵃⅅ⁇㹉", num))) || (str == BookmarkStart.b("唷嬹䐻ጽ㜿⭁⁃㉅⁇", num)))
                    {
                    }
                }
                else
                {
                    naN = Class576.smethod_41(class2.method_3());
                }
            }
        }
        return naN;
    }

    internal static void smethod_2(Class857 A_0, ShapeObject A_1)
    {
        Class574.smethod_0(A_0, BookmarkStart.b("䐯圱䰳䈵ᔷ堹医䘽", 10), A_1);
    }
}

