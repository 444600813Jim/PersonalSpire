using Spire.Doc;
using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Class735
{
    private const int int_0 = 2;
    private const int int_1 = 3;
    private const int int_2 = 4;
    private const int int_3 = 5;
    private const int int_4 = 6;
    private const int int_5 = 8;
    private const int int_6 = 10;
    private const int int_7 = 12;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("砥'ȩЫ甭儯ἱ丳欵ጷጹ᰻ᘽᬿ⍁楃㱅ᕇ慉敋ቍ硏穑ࡓ㉕獗獙[睝䥟ṡ䱣㵥塧䝩啫཭嵯ᑱ⥳൵乷ݹ啻ɽ꡿ꪁ\udf83\ue785ꖇ톋ꖍ릏벑뺓뾕늙뾛뚝ﮟ銡覣龥즧螩쪫쮯蒱즳龵隷邹閻슽鷅꿍﷏듑觓귕ꟙ쫟쯡췣싥", 0), RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private Class735()
    {
    }

    internal static Color smethod_0(string A_0)
    {
        int num3;
        int num = 7;
        Match match = regex_0.Match(A_0);
        string str = match.Groups[2].Value;
        string str2 = match.Groups[8].Value;
        string str3 = match.Groups[6].Value;
        string str4 = match.Groups[10].Value;
        string str5 = match.Groups[12].Value;
        if (string.IsNullOrEmpty(str))
        {
            if (!string.IsNullOrEmpty(str2))
            {
                if (str2 == BookmarkStart.b("娬䘮弰圲娴䀶", num))
                {
                    return Color.FromArgb(0xef, 0x11, 0, 0);
                }
                if (str2 == BookmarkStart.b("娬䘮弰圲娴䀶洸帺䔼䬾", num))
                {
                    return Color.Black;
                }
                if (str2 == BookmarkStart.b("夬䜮堰䀲", num))
                {
                    return Color.Empty;
                }
                return Class1086.smethod_0(str2);
            }
            if (!string.IsNullOrEmpty(str3))
            {
                return Class114.smethod_13(str3);
            }
            if (!string.IsNullOrEmpty(str4))
            {
                return Class114.smethod_13(str4);
            }
            if (string.IsNullOrEmpty(str5))
            {
                throw new InvalidOperationException(smethod_4(A_0));
            }
            StringBuilder builder = new StringBuilder(6);
            for (int i = 0; i < str5.Length; i++)
            {
                char ch = str5[i];
                builder.Append(ch);
                builder.Append(ch);
            }
            return Class114.smethod_13(builder.ToString());
        }
        int alpha = 0xef;
        string str6 = match.Groups[3].Value;
        if (str6 == null)
        {
            goto Label_01A2;
        }
        if (str6 != BookmarkStart.b("䬬䘮崰弲", num))
        {
            if (str6 != BookmarkStart.b("䄬䘮弰嘲稴䔶缸刺儼匾", num))
            {
                if (!(str6 == BookmarkStart.b("䄬䘮弰嘲", num)))
                {
                    if (!(str6 == BookmarkStart.b("帬䜮倰圲娴䀶", num)))
                    {
                        goto Label_01A2;
                    }
                    num3 = 0xf3;
                }
                else
                {
                    num3 = 0xf2;
                }
            }
            else
            {
                num3 = 0xf1;
            }
        }
        else
        {
            num3 = 240;
        }
        string str7 = match.Groups[4].Value;
        if (str7 != null)
        {
            int num5;
            if (str7 != BookmarkStart.b("䤬丮䌰堲倴夶", num))
            {
                if (!(str7 == BookmarkStart.b("䄬䘮嘰嬲䄴制圸", num)))
                {
                    if (!(str7 == BookmarkStart.b("䰬䬮唰", num)))
                    {
                        goto Label_0196;
                    }
                    num5 = 3;
                }
                else
                {
                    num5 = 2;
                }
            }
            else
            {
                num5 = 1;
            }
            int blue = Class1041.smethod_23(match.Groups[5].Value);
            return Color.FromArgb(alpha, num3, num5, blue);
        }
    Label_0196:
        throw new InvalidOperationException(smethod_4(A_0));
    Label_01A2:
        throw new InvalidOperationException(smethod_4(A_0));
    }

    internal static string smethod_1(Color A_0)
    {
        return smethod_2(A_0, true, false);
    }

    internal static string smethod_2(Color A_0, bool A_1, bool A_2)
    {
        int num = 8;
        if (A_0.IsEmpty)
        {
            return BookmarkStart.b("娭堯嬱䜳", num);
        }
        if (A_0.A != 0xef)
        {
            string str = Class1086.smethod_1(A_0);
            if (str != "")
            {
                return str;
            }
            if (((A_1 && (A_0.A == 0xff)) && (smethod_7(A_0.R) && smethod_7(A_0.G))) && smethod_7(A_0.B))
            {
                return string.Format(BookmarkStart.b("ഭ䬯ȱ䤳䴵ष䜹䜻ఽ㴿", num), smethod_6(A_0.R), smethod_6(A_0.G), smethod_6(A_0.B));
            }
            string str2 = string.Format(BookmarkStart.b("ഭ䬯ȱ䤳䴵ष䜹䜻ఽ㴿", num), smethod_5(A_0.R), smethod_5(A_0.G), smethod_5(A_0.B));
            if (A_2)
            {
                return str2.ToUpper();
            }
            return str2;
        }
        StringBuilder builder = new StringBuilder();
        if (A_0.R < 240)
        {
            byte r = A_0.R;
            if (r == 1)
            {
                return null;
            }
            if (r != 0x11)
            {
                throw new InvalidOperationException(smethod_3(A_0));
            }
            builder.Append(BookmarkStart.b("夭夯就倳夵伷", num));
        }
        else
        {
            switch (A_0.R)
            {
                case 240:
                    builder.Append(BookmarkStart.b("䠭夯帱堳ᘵ", num));
                    break;

                case 0xf1:
                    builder.Append(BookmarkStart.b("䈭夯就儳礵䨷簹唻刽ⰿ扁", num));
                    break;

                case 0xf2:
                    builder.Append(BookmarkStart.b("䈭夯就儳ᘵ", num));
                    break;

                case 0xf3:
                    builder.Append(BookmarkStart.b("崭堯匱倳夵伷ᨹ", num));
                    break;

                case 0xf4:
                    return null;

                case 0xf7:
                    return null;

                default:
                    throw new InvalidOperationException(smethod_3(A_0));
            }
            switch (A_0.G)
            {
                case 1:
                    builder.Append(BookmarkStart.b("䨭儯䀱弳匵嘷", num));
                    break;

                case 2:
                    builder.Append(BookmarkStart.b("䈭夯唱尳䈵崷吹", num));
                    break;

                case 3:
                    builder.Append(BookmarkStart.b("伭启嘱", num));
                    break;

                default:
                    throw new InvalidOperationException(smethod_3(A_0));
            }
            builder.AppendFormat(BookmarkStart.b("ح䬯ȱ䤳ἵ", num), A_0.B);
        }
        return builder.ToString();
    }

    private static string smethod_3(Color A_0)
    {
        return string.Format(BookmarkStart.b("簨䔪䘬䄮帰䐲嬴᜶娸吺儼倾㍀捂ㅄ㹆㥈⹊浌⩎㽐げ㩔≖㝘⽚㡜ⵞѠݢ䕤ͦᱨᥪѬŮᙰ卲≴ᡶ୸ὺぼ㍾ꆀﶄ力歷꾎벐뎒Ꞗ떚", 3), A_0.ToString());
    }

    private static string smethod_4(string A_0)
    {
        return string.Format(BookmarkStart.b("支就弳堵圷䴹刻ḽ⌿ⵁ⡃⥅㩇橉㡋㝍⁏㝑瑓㍕㙗㥙㍛⭝๟ᙡţᑥ൧๩䱫੭կqᵳᡵί婹⭻ᅽ즃쪅ꢇﺍﾏ뚕떗몙꺝\udd9f\u8ca1", 10), A_0);
    }

    private static string smethod_5(int A_0)
    {
        return Class1041.smethod_40(A_0);
    }

    private static string smethod_6(int A_0)
    {
        return Class1041.smethod_38(A_0 % 0x10);
    }

    private static bool smethod_7(int A_0)
    {
        return ((A_0 / 0x10) == (A_0 % 0x10));
    }
}

