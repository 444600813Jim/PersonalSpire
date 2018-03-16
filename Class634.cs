using Spire.Doc;
using System;
using System.Globalization;

internal class Class634 : Class633
{
    internal override int vmethod_0(byte[] A_0, int A_1, int A_2, char[] A_3, int A_4)
    {
        int num = 15;
        A_2 += A_1;
        int index = A_1;
        int num3 = A_4;
        while ((index + 3) < A_2)
        {
            uint num4 = (uint) ((((A_0[index + 3] << 0x18) | (A_0[index + 2] << 0x10)) | (A_0[index + 1] << 8)) | A_0[index]);
            if (num4 > 0x10ffff)
            {
                throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("簴夶伸娺儼嘾╀捂♄⽆⡈㥊ⱌⱎ═㙒❔睖楘⍚♜潞孠᭢ᡤ䝦hժ䵬੮ὰၲᩴ፶ၸᕺ᩼", num), new object[] { num4 }));
            }
            if (num4 > 0xffff)
            {
                A_3[num3] = Class633.smethod_0(num4);
                num3++;
            }
            else
            {
                if ((num4 >= 0xd800) && (num4 <= 0xdfff))
                {
                    throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("簴夶伸娺儼嘾╀捂♄⽆⡈㥊ⱌⱎ═㙒❔睖楘⍚♜潞孠᭢ᡤ䝦hժ䵬੮ὰၲᩴ፶ၸᕺ᩼", num), new object[] { num4 }));
                }
                A_3[num3] = (char) num4;
            }
            num3++;
            index += 4;
        }
        return (num3 - A_4);
    }
}

