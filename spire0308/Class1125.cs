using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Class1125
{
    private CssUnitType cssUnitType_0;
    private CssValueType cssValueType_0;
    private static readonly double[] double_0 = new double[] { 1.0, 1.0, 2.54, 25.4, 72.0, 6.0, 96.0 };
    private static readonly IDictionary idictionary_0 = Class83.smethod_0();
    private const int int_0 = 1;
    private const int int_1 = 2;
    private const int int_2 = 3;
    private const int int_3 = 4;
    private const int int_4 = 5;
    private const int int_5 = 6;
    private const int int_6 = 7;
    private object object_0;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("昷ሹ̻н栿絁繃故恇ᅉ籋捍楏㍑祓さ՗⅙潛⍝䡟嵡幣㵥塧䝩啫཭嵯ᑱ⥳൵䭷ݹ啻䅽꥿ꮁ꺅랇낉ﺋ캑벓쪕낙뒛얝趟覡念馥캩螫蚭辯袱颵\udeb9\u96bb鞽﾿郋뷍𢡊ﻑ裓ꗕ蟛쯟뿡\udbe3\ubae5賧쇩쓫퇭쫯껱\udaf3\uaaf5鳷탹헻쇽⧿⨁℃⼅㜇嘉缋␍㰏丑朓㰕〗䄙ㄛ㔝紟ᴡ砣䈥̧ȩጫᐭ氯ᰱ栳刵ሷጹ̻᜽栿杁浃祅ᑇ㥉晋ቍ祏筑絓牕", 0x12), RegexOptions.Compiled);
    private static readonly Regex regex_1 = new Regex(BookmarkStart.b("䨷崹帻戽栿᥁ᩃᩅ慇ᝉ晋ቍ祏⹑⅓⑕㑗ٙ瑛՝㹟㹡䵣㭥䉧㙩䕫ቭ副⥱⩳呵╷偹幻ɽꝿ\ud981\uda83ꆅ햇ꂉꮋ쮏첑좓뒗떙솛떝", 0x12), RegexOptions.IgnoreCase);
    private static readonly Regex regex_2 = new Regex(BookmarkStart.b("ᨷ愹戻᰽ᴿ桁晃㩅潇ᅉቋ楍൏硑獓⩕͗љ灛͝䭟", 0x12));

    static Class1125()
    {
        idictionary_0.Add(BookmarkStart.b("娷嬹弻唽✿ぁ⭃㍅♇⹉態㹍㽏⅑㵓≕ㅗ㕙㉛", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷嬹弻唽✿ぁ⭃㍅♇⹉", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃╅❇♉⍋㱍", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃㕅㡇⭉⽋❍㹏㕑", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃㕅㱇㍉⁋⭍", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃㉅❇㩉", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃㑅ⅇⵉ⑋㩍", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃⑅❇㹉㡋⅍㵏", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃⩅ⵇⱉ㡋", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ楃ㅅⅇ⹉㡋♍", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("娷唹主娽┿ぁ", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("嬷唹刻䨽┿ⱁぃ", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("嬷唹䤻倽㐿❁㙃歅ⅇ⑉⽋㱍㕏㽑ㅓ㡕ⱗ", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("嬷唹䤻倽㐿❁㙃歅㩇⽉㽋⭍⑏", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("嬷伹夻", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("嬷伹主䴽⼿ぁ", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("帷唹刻䨽洿⑁╃⭅ⅇ♉㕋", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("帷唹刻䨽", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("吷匹伻䨽洿ㅁぃ㽅⑇⽉", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("唷嬹主夽⤿ⱁ", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("圷伹䠻刽⤿ⱁ⅃", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("䠷嬹堻娽⤿ⱁ⍃", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("䠷嬹䤻䴽┿", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("䠷嘹崻䜽洿♁ㅃ㑅ⅇ⑉⭋", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("䤷伹医䨽┿ㅁ", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("䬷匹䘻嬽", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("䰷弹䐻䨽洿♁⅃╅❇㡉ⵋ㩍㥏㵑㩓", 0x12), null);
        idictionary_0.Add(BookmarkStart.b("丷唹唻崽┿潁≃❅╇⍉⁋㝍", 0x12), null);
    }

    private Class1125(string A_0)
    {
        if (!this.method_0(A_0))
        {
            string str = A_0.ToLower();
            if (((!this.method_1(str) && !this.method_2(str)) && !this.method_4(str)) && !this.method_5(str))
            {
                this.object_0 = A_0;
                this.cssValueType_0 = CssValueType.Identifier;
            }
        }
    }

    private Class1125(object A_0, CssValueType A_1, CssUnitType A_2)
    {
        this.object_0 = A_0;
        this.cssValueType_0 = A_1;
        this.cssUnitType_0 = A_2;
    }

    private bool method_0(string A_0)
    {
        int num = 13;
        if ((A_0.StartsWith(BookmarkStart.b("ᐲ", 13)) || A_0.StartsWith(BookmarkStart.b("ᄲ", num))) && (A_0.Length > 1))
        {
            this.object_0 = A_0.Substring(1, A_0.Length - 2);
            this.cssValueType_0 = CssValueType.String;
            return true;
        }
        return false;
    }

    private bool method_1(string A_0)
    {
        Color color = smethod_9(A_0);
        if (!color.IsEmpty)
        {
            this.object_0 = color;
            this.cssValueType_0 = CssValueType.Color;
            return true;
        }
        return false;
    }

    internal double method_10()
    {
        if (((this.cssValueType_0 != CssValueType.Number) && (this.cssValueType_0 != CssValueType.Percentage)) && (this.cssValueType_0 != CssValueType.Length))
        {
            return 0.0;
        }
        return (double) this.object_0;
    }

    internal double method_11(CssUnitType A_0)
    {
        if (this.cssValueType_0 == CssValueType.Length)
        {
            return smethod_13(smethod_12((double) this.object_0, this.cssUnitType_0), A_0);
        }
        if (this.cssValueType_0 == CssValueType.Number)
        {
            return smethod_13(smethod_12((double) this.object_0, CssUnitType.Px), A_0);
        }
        return 0.0;
    }

    internal double method_12(CssUnitType A_0, double A_1)
    {
        if (this.cssValueType_0 != CssValueType.Percentage)
        {
            return this.method_11(A_0);
        }
        return ((((double) this.object_0) * A_1) / 100.0);
    }

    internal Color method_13()
    {
        if (this.cssValueType_0 == CssValueType.Color)
        {
            return (Color) this.object_0;
        }
        return Color.Black;
    }

    internal object method_14()
    {
        return this.object_0;
    }

    internal CssValueType method_15()
    {
        return this.cssValueType_0;
    }

    internal CssUnitType method_16()
    {
        return this.cssUnitType_0;
    }

    internal bool method_17()
    {
        if (this.cssValueType_0 != CssValueType.Length)
        {
            return (this.cssValueType_0 == CssValueType.Number);
        }
        return true;
    }

    internal bool method_18()
    {
        if ((this.cssValueType_0 != CssValueType.Length) && (this.cssValueType_0 != CssValueType.Number))
        {
            return (this.cssValueType_0 == CssValueType.Percentage);
        }
        return true;
    }

    private bool method_2(string A_0)
    {
        int num = 10;
        return (this.method_3(A_0, BookmarkStart.b("夯就", 10), CssUnitType.In) || (this.method_3(A_0, BookmarkStart.b("匯弱", num), CssUnitType.Cm) || (this.method_3(A_0, BookmarkStart.b("崯弱", num), CssUnitType.Mm) || (this.method_3(A_0, BookmarkStart.b("䀯䘱", num), CssUnitType.Pt) || (this.method_3(A_0, BookmarkStart.b("䀯儱", num), CssUnitType.Pc) || this.method_3(A_0, BookmarkStart.b("䀯䨱", num), CssUnitType.Px))))));
    }

    private bool method_3(string A_0, string A_1, CssUnitType A_2)
    {
        if (A_0.EndsWith(A_1))
        {
            double d = Class1041.smethod_15(A_0.Substring(0, A_0.Length - A_1.Length));
            if (!double.IsNaN(d))
            {
                this.object_0 = d;
                this.cssValueType_0 = CssValueType.Length;
                this.cssUnitType_0 = A_2;
                return true;
            }
        }
        return false;
    }

    private bool method_4(string A_0)
    {
        if (A_0.EndsWith(BookmarkStart.b("ᜱ", 12)))
        {
            double d = Class1041.smethod_15(A_0.Substring(0, A_0.Length - 1));
            if (!double.IsNaN(d))
            {
                this.object_0 = d;
                this.cssValueType_0 = CssValueType.Percentage;
                return true;
            }
        }
        return false;
    }

    private bool method_5(string A_0)
    {
        double d = Class1041.smethod_15(A_0);
        if (!double.IsNaN(d))
        {
            this.object_0 = d;
            this.cssValueType_0 = CssValueType.Number;
            return true;
        }
        return false;
    }

    internal void method_6(StringBuilder A_0)
    {
        int num = 2;
        switch (this.cssValueType_0)
        {
            case CssValueType.Identifier:
                A_0.Append(this.object_0);
                return;

            case CssValueType.Complex:
                this.method_7(A_0, BookmarkStart.b("ࠧ", num));
                return;

            case CssValueType.ComplexCommaSeparated:
                this.method_7(A_0, BookmarkStart.b("Ч਩", num));
                return;

            case CssValueType.String:
            {
                string str = this.method_8();
                if (str.IndexOf(' ') < 0)
                {
                    A_0.Append(str);
                    return;
                }
                A_0.AppendFormat(BookmarkStart.b("༧儩ᰫ匭ᜯ", num), str);
                return;
            }
            case CssValueType.Color:
            {
                Color color = this.method_13();
                A_0.AppendFormat(BookmarkStart.b("ଧ儩ᰫᐭ䠯1䤳䴵ष9䐻ఽ㴿㥁癃籅ぇ硉ㅋ", num), color.R, color.G, color.B);
                return;
            }
            case CssValueType.Number:
                A_0.Append(Class1041.smethod_46(this.method_10()));
                return;

            case CssValueType.Length:
                A_0.AppendFormat(BookmarkStart.b("匧ᨩ儫唭į伱", num), Class1041.smethod_46(this.method_10()), smethod_11(this.cssUnitType_0));
                return;

            case CssValueType.Percentage:
                A_0.AppendFormat(BookmarkStart.b("匧ᨩ儫ଭ", num), Class1041.smethod_46(this.method_10()));
                return;
        }
    }

    private void method_7(StringBuilder A_0, string A_1)
    {
        Class1030 class2 = this.method_9();
        if (class2.Count > 0)
        {
            class2.method_0(0).method_6(A_0);
            for (int i = 1; i < class2.Count; i++)
            {
                A_0.Append(A_1);
                class2.method_0(i).method_6(A_0);
            }
        }
    }

    internal string method_8()
    {
        if ((this.cssValueType_0 != CssValueType.Identifier) && (this.cssValueType_0 != CssValueType.String))
        {
            return string.Empty;
        }
        return (string) this.object_0;
    }

    internal Class1030 method_9()
    {
        if ((this.cssValueType_0 != CssValueType.Complex) && (this.cssValueType_0 != CssValueType.ComplexCommaSeparated))
        {
            return null;
        }
        return (Class1030) this.object_0;
    }

    internal static Class1125 smethod_0(string A_0)
    {
        return new Class1125(A_0, CssValueType.Identifier, CssUnitType.None);
    }

    internal static Class1125 smethod_1(string A_0)
    {
        return new Class1125(A_0, CssValueType.String, CssUnitType.None);
    }

    private static int smethod_10(string A_0, bool A_1)
    {
        double num = Class1041.smethod_12(A_0) * (A_1 ? 2.55 : 1.0);
        return Class1133.smethod_5(Class1133.smethod_2(num, 0.0, 255.0));
    }

    private static string smethod_11(CssUnitType A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case CssUnitType.In:
                return BookmarkStart.b("娲嬴", num);

            case CssUnitType.Cm:
                return BookmarkStart.b("倲場", num);

            case CssUnitType.Mm:
                return BookmarkStart.b("帲場", num);

            case CssUnitType.Pt:
                return BookmarkStart.b("䌲䄴", num);

            case CssUnitType.Pc:
                return BookmarkStart.b("䌲嘴", num);

            case CssUnitType.Px:
                return BookmarkStart.b("䌲䴴", num);

            case CssUnitType.Em:
                return BookmarkStart.b("嘲場", num);

            case CssUnitType.Ex:
                return BookmarkStart.b("嘲䴴", num);
        }
        return "";
    }

    private static double smethod_12(double A_0, CssUnitType A_1)
    {
        return (A_0 / double_0[(int) A_1]);
    }

    private static double smethod_13(double A_0, CssUnitType A_1)
    {
        return (A_0 * double_0[(int) A_1]);
    }

    private static bool smethod_14(string A_0)
    {
        return idictionary_0.Contains(A_0);
    }

    internal static Class1125 smethod_2(double A_0)
    {
        return new Class1125(A_0, CssValueType.Number, CssUnitType.None);
    }

    internal static Class1125 smethod_3(double A_0)
    {
        return new Class1125(A_0, CssValueType.Percentage, CssUnitType.None);
    }

    internal static Class1125 smethod_4(double A_0, CssUnitType A_1)
    {
        return new Class1125(A_0, CssValueType.Length, A_1);
    }

    internal static Class1125 smethod_5(Class1030 A_0)
    {
        return new Class1125(A_0, CssValueType.Complex, CssUnitType.None);
    }

    internal static Class1125 smethod_6(double A_0, double A_1, double A_2, double A_3, CssUnitType A_4)
    {
        Class1030 class2 = new Class1030(4);
        class2.Add(smethod_4(A_0, A_4));
        class2.Add(smethod_4(A_1, A_4));
        class2.Add(smethod_4(A_2, A_4));
        class2.Add(smethod_4(A_3, A_4));
        return smethod_7(class2);
    }

    internal static Class1125 smethod_7(Class1030 A_0)
    {
        Class1030 class2 = new Class1030(A_0);
        if ((class2.Count == 4) && class2.method_0(1).Equals(class2.method_0(3)))
        {
            class2.RemoveAt(3);
        }
        if ((class2.Count == 3) && class2.method_0(0).Equals(class2.method_0(2)))
        {
            class2.RemoveAt(2);
        }
        if ((class2.Count == 2) && class2.method_0(0).Equals(class2.method_0(1)))
        {
            class2.RemoveAt(1);
        }
        if (class2.Count != 1)
        {
            return smethod_5(class2);
        }
        return new Class1125(class2.method_0(0).method_14(), class2.method_0(0).method_15(), class2.method_0(0).method_16());
    }

    internal static Class1125 smethod_8(string A_0, string A_1)
    {
        int num = 11;
        if (!smethod_14(A_0))
        {
            return new Class1125(A_1);
        }
        MatchCollection matchs = (Class567.smethod_41(A_0, BookmarkStart.b("地尲嬴䌶ᐸ崺尼刾⡀⽂㱄", num)) ? regex_2 : regex_1).Matches(A_1);
        Class1030 class2 = new Class1030(matchs.Count);
        foreach (Match match in matchs)
        {
            class2.Add(new Class1125(match.Value));
        }
        return smethod_5(class2);
    }

    internal static Color smethod_9(string A_0)
    {
        int num = 0x12;
        A_0 = A_0.ToLower();
        Match match = regex_0.Match(A_0);
        if (match.Success)
        {
            Group group = match.Groups[1];
            if (group.Success)
            {
                string str = group.Value;
                if (str.Length == 6)
                {
                    return Color.FromArgb(-16777216 + Class1041.smethod_26(str));
                }
                int num5 = Class567.smethod_31(str[0]);
                int num6 = Class567.smethod_31(str[1]);
                int num7 = Class567.smethod_31(str[2]);
                return Color.FromArgb(num5 * 0x11, num6 * 0x11, num7 * 0x11);
            }
            int red = smethod_10(match.Groups[2].Value, match.Groups[3].Success);
            int green = smethod_10(match.Groups[4].Value, match.Groups[5].Success);
            int blue = smethod_10(match.Groups[6].Value, match.Groups[7].Success);
            return Color.FromArgb(red, green, blue);
        }
        if (A_0.EndsWith(BookmarkStart.b("強䠹夻䜽", num)))
        {
            A_0 = A_0.Substring(0, A_0.Length - BookmarkStart.b("強䠹夻䜽", num).Length) + BookmarkStart.b("強䠹崻䜽", num);
        }
        return Color.FromName(A_0);
    }

    bool object.Equals(object A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        if (object.ReferenceEquals(this, A_0))
        {
            return true;
        }
        if (A_0.GetType() != typeof(Class1125))
        {
            return false;
        }
        return this.Equals((Class1125) A_0);
    }

    int object.GetHashCode()
    {
        int num = (this.object_0 != null) ? this.object_0.GetHashCode() : 0;
        num = (num * 0x18d) ^ this.cssValueType_0;
        return ((num * 0x18d) ^ this.cssUnitType_0);
    }
}

