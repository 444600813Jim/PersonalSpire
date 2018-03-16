using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Text;

internal class Class495
{
    private readonly char[] char_0 = new char[] { '零', '一', '二', '三', '四', '五', '六', '七', '八', '九' };
    private readonly char[] char_1 = new char[] { '十', '百', '千', '万', '亿' };
    private readonly char[] char_10 = new char[] { 
        '①', '②', '③', '④', '⑤', '⑥', '⑦', '⑧', '⑨', '⑩', '⑪', '⑫', '⑬', '⑭', '⑮', '⑯', 
        '⑰', '⑱', '⑲', '⑳'
     };
    private readonly char[] char_11 = new char[] { '㈠', '㈡', '㈢', '㈣', '㈤', '㈥', '㈦', '㈧', '㈨', '㈩' };
    private readonly char[] char_12 = new char[] { 
        '⑴', '⑵', '⑶', '⑷', '⑸', '⑹', '⑺', '⑻', '⑼', '⑽', '⑾', '⑿', '⒀', '⒁', '⒂', '⒃', 
        '⒄', '⒅', '⒆', '⒇'
     };
    private readonly char[] char_13 = new char[] { 
        '⒈', '⒉', '⒊', '⒋', '⒌', '⒍', '⒎', '⒏', '⒐', '⒑', '⒒', '⒓', '⒔', '⒕', '⒖', '⒗', 
        '⒘', '⒙', '⒚', '⒛'
     };
    private readonly char[] char_14 = new char[] { '*', '†', '‡', '\x00a7' };
    private readonly char[] char_15 = new char[] { '〇', '一', '二', '三', '四', '五', '六', '七', '八', '九' };
    private readonly char[] char_16 = new char[] { '壱', '弐', '参', '四', '伍', '六', '七', '八', '九' };
    private readonly char[] char_17 = new char[] { '拾', '百', '阡', '萬' };
    private readonly char[] char_2 = new char[] { '零', '一', '二', '三', '四', '五', '六', '七', '八', '九' };
    private readonly char[] char_3 = new char[] { '十', '百', '千', '萬', '億' };
    private readonly char[] char_4 = new char[] { '零', '壹', '貳', '參', '肆', '伍', '陸', '柒', '捌', '玖' };
    private readonly char[] char_5 = new char[] { '拾', '佰', '仟', '萬', '億' };
    private readonly char[] char_6 = new char[] { '零', '壹', '贰', '叁', '肆', '伍', '陆', '柒', '捌', '玖' };
    private readonly char[] char_7 = new char[] { '拾', '佰', '千', '万', '亿' };
    private readonly char[] char_8 = new char[] { '子', '丑', '寅', '卯', '辰', '巳', '午', '未', '申', '酉', '戌', '亥' };
    private readonly char[] char_9 = new char[] { '甲', '乙', '丙', '丁', '戊', '己', '庚', '辛', '壬', '癸' };
    private DigitType digitType_0;

    internal DigitType method_0()
    {
        return this.digitType_0;
    }

    internal void method_1(DigitType A_0)
    {
        this.digitType_0 = A_0;
    }

    public string method_10(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        for (int i = 0; i < chArray.Length; i++)
        {
            if (chArray[i] == ' ')
            {
                chArray[i] = '　';
            }
            else if (chArray[i] < '\x007f')
            {
                chArray[i] = (char) (chArray[i] + 0xfee0);
            }
        }
        return new string(chArray);
    }

    public string method_11(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        for (int i = 0; i < chArray.Length; i++)
        {
            if (chArray[i] == '　')
            {
                chArray[i] = ' ';
            }
            else if ((chArray[i] > 0xff00) && (chArray[i] < 0xff5f))
            {
                chArray[i] = (char) (chArray[i] - 0xfee0);
            }
        }
        return new string(chArray);
    }

    public string method_2(string A_0)
    {
        decimal num2;
        int num3;
        int num = 0x12;
        try
        {
            num2 = decimal.Parse(A_0);
        }
        catch (FormatException)
        {
            throw new Exception(BookmarkStart.b("氷刹夻ḽ⤿ⱁ㑃㍅㱇橉≋㭍㵏けㅓ⑕硗㱙㍛ⱝൟ͡ၣ䙥ŧᥩ䱫mὯٱ味ᕵ᝷ࡹ๻᭽ꪃ", num));
        }
        catch (Exception exception)
        {
            throw exception;
        }
        if ((num2 <= -10000000000000000M) || (num2 >= 10000000000000000M))
        {
            throw new Exception(BookmarkStart.b("紷吹䠻嬽㈿扁ぃ⹅ⵇ橉ɋ㭍㵏けㅓ⑕⭗穙⡛ㅝཟ䉡٣ཥཧ䩩ͫᱭ偯ٱ᭳᥵塷ॹᅻώꢃꚅﺏ뒓ﾙ벛쎟춡풣쎥蚧", num));
        }
        StringBuilder builder = new StringBuilder();
        if (BookmarkStart.b("ጷ", num) == A_0.Substring(0, 1))
        {
            A_0 = A_0.Substring(1);
        }
        else if (BookmarkStart.b("ᔷ", num) == A_0.Substring(0, 1))
        {
            builder.Append(0x8d1f);
            A_0 = A_0.Substring(1);
        }
        else if (BookmarkStart.b("ጷ", num) == A_0.Substring(A_0.Length - 1, 1))
        {
            A_0 = A_0.Substring(0, A_0.Length - 1);
        }
        else if (BookmarkStart.b("ᔷ", num) == A_0.Substring(A_0.Length - 1, 1))
        {
            builder.Append(0x8d1f);
            A_0 = A_0.Substring(0, A_0.Length - 1);
        }
        if (-1 == (num3 = A_0.IndexOf('.')))
        {
            builder.Append(this.method_3(A_0));
        }
        else
        {
            if (num3 == 0)
            {
                builder.Append(0x96f6);
            }
            else
            {
                builder.Append(this.method_3(A_0.Substring(0, num3)));
            }
            if ((A_0.Length - 1) != num3)
            {
                builder.Append('点');
                builder.Append(this.method_4(A_0.Substring(num3 + 1)));
            }
        }
        return builder.ToString();
    }

    protected string method_3(string A_0)
    {
        char[] chArray2;
        char[] chArray3;
        int num = 3;
        long num2 = long.Parse(A_0);
        char[] chArray = num2.ToString().ToCharArray();
        StringBuilder builder = new StringBuilder();
        int num3 = chArray.Length - 1;
        switch (this.method_0())
        {
            case DigitType.ChineseCountingThousand:
            case DigitType.ChineseLegalSimplified:
            case DigitType.IdeographLegalTraditional:
            case DigitType.TaiwaneseCountingThousand:
            case DigitType.JapaneseCounting:
                chArray2 = null;
                chArray3 = null;
                if (this.method_0() != DigitType.ChineseCountingThousand)
                {
                    if (this.method_0() == DigitType.ChineseLegalSimplified)
                    {
                        chArray2 = this.char_6;
                        chArray3 = this.char_7;
                    }
                    else if (this.method_0() == DigitType.IdeographLegalTraditional)
                    {
                        chArray2 = this.char_4;
                        chArray3 = this.char_5;
                    }
                    else if (this.method_0() == DigitType.JapaneseCounting)
                    {
                        chArray2 = this.char_15;
                        chArray3 = this.char_1;
                    }
                    else
                    {
                        chArray2 = this.char_2;
                        chArray3 = this.char_3;
                    }
                    break;
                }
                chArray2 = this.char_0;
                chArray3 = this.char_1;
                break;

            case DigitType.Zodiac:
                if ((num2 < 1L) || (num2 > 12L))
                {
                    builder.Append(num2);
                }
                else
                {
                    builder.Append(this.char_8[(int) ((IntPtr) (num2 - 1L))]);
                }
                goto Label_04BC;

            case DigitType.Traditional:
                if ((num2 < 1L) || (num2 > 10L))
                {
                    builder.Append(num2);
                }
                else
                {
                    builder.Append(this.char_9[(int) ((IntPtr) (num2 - 1L))]);
                }
                goto Label_04BC;

            case DigitType.GB1:
                if ((num2 < 1L) || (num2 > 20L))
                {
                    builder.Append(num2);
                }
                else
                {
                    builder.Append(this.char_13[(int) ((IntPtr) (num2 - 1L))]);
                }
                goto Label_04BC;

            case DigitType.GB2:
                if ((num2 < 1L) || (num2 > 20L))
                {
                    builder.Append(num2);
                }
                else
                {
                    builder.Append(this.char_12[(int) ((IntPtr) (num2 - 1L))]);
                }
                goto Label_04BC;

            default:
                goto Label_04BC;
        }
        int index = 0;
        index = 0;
        while (index < (chArray.Length - 1))
        {
            if ((this.method_0() == DigitType.JapaneseCounting) && ((chArray[index] == '1') || (chArray[index] == '0')))
            {
                builder.Append(string.Empty);
            }
            else
            {
                builder.Append(chArray2[chArray[index] - '0']);
            }
            if ((num3 % 4) == 0)
            {
                switch (num3)
                {
                    case 4:
                    case 12:
                        if ((this.method_0() == DigitType.JapaneseCounting) && (chArray[index] == '0'))
                        {
                            builder.Append(string.Empty);
                        }
                        else
                        {
                            builder.Append(chArray3[3]);
                        }
                        goto Label_02D5;
                }
                if (num3 == 8)
                {
                    if ((this.method_0() == DigitType.JapaneseCounting) && (chArray[index] == '0'))
                    {
                        builder.Append(string.Empty);
                    }
                    else
                    {
                        builder.Append(chArray3[4]);
                    }
                }
            }
            else if ((this.method_0() == DigitType.JapaneseCounting) && (chArray[index] == '0'))
            {
                builder.Append(string.Empty);
            }
            else
            {
                builder.Append(chArray3[(num3 % 4) - 1]);
            }
        Label_02D5:
            num3--;
            index++;
        }
        if ((chArray[chArray.Length - 1] != '0') || (chArray.Length == 1))
        {
            builder.Append(chArray2[chArray[index] - '0']);
        }
        index = 0;
        while (index < builder.Length)
        {
            int num5 = index;
            bool flag = false;
            goto Label_0380;
        Label_0320:
            if (!(BookmarkStart.b("\udfbe", num) == builder.ToString().Substring(num5, 1)))
            {
                goto Label_0391;
            }
            string str = builder.ToString().Substring(num5 + 1, 1);
            if ((BookmarkStart.b("⹦", num) == str) || (BookmarkStart.b("陦", num) == str))
            {
                goto Label_038E;
            }
            num5 += 2;
        Label_0380:
            if (num5 >= (builder.Length - 1))
            {
                goto Label_0391;
            }
            goto Label_0320;
        Label_038E:
            flag = true;
        Label_0391:
            if (num5 != index)
            {
                builder = builder.Remove(index, num5 - index);
                if ((index <= (builder.Length - 1)) && !flag)
                {
                    builder = builder.Insert(index, 0x96f6);
                    index++;
                }
            }
            if (flag)
            {
                builder = builder.Remove(index, 1);
                index++;
            }
            else
            {
                index += 2;
            }
        }
        int startIndex = builder.ToString().IndexOf(BookmarkStart.b("陦Ɽ", num));
        if (-1 != startIndex)
        {
            if ((((builder.Length - 2) != startIndex) && ((startIndex + 2) < builder.Length)) && (BookmarkStart.b("\udfbe", num) != builder.ToString().Substring(startIndex + 2, 1)))
            {
                builder = builder.Replace(BookmarkStart.b("陦Ɽ", num), BookmarkStart.b("陦\uddbc", num), startIndex, 2);
            }
            else
            {
                builder = builder.Replace(BookmarkStart.b("陦Ɽ", num), BookmarkStart.b("陦", num), startIndex, 2);
            }
        }
        if ((builder.Length > 1) && (BookmarkStart.b("⥦橹", num) == builder.ToString().Substring(0, 2)))
        {
            builder = builder.Remove(0, 1);
        }
    Label_04BC:
        return builder.ToString();
    }

    protected string method_4(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < chArray.Length; i++)
        {
            builder.Append(this.char_0[chArray[i] - '0']);
        }
        return builder.ToString();
    }

    public string method_5(string A_0)
    {
        decimal num2;
        int num = 0x12;
        try
        {
            num2 = decimal.Parse(A_0);
        }
        catch (FormatException)
        {
            throw new Exception(BookmarkStart.b("氷刹夻ḽ⤿ⱁ㑃㍅㱇橉≋㭍㵏けㅓ⑕硗㱙㍛ⱝൟ͡ၣ䙥ŧᥩ䱫mὯٱ味ᕵ᝷ࡹ๻᭽ꪃ", num));
        }
        StringBuilder builder = new StringBuilder();
        int num5 = ((int) num2) % 4;
        int num6 = ((int) num2) / 4;
        int num7 = (num5 == 0) ? (num6 - 1) : num6;
        string str = (num5 == 0) ? this.char_14[3].ToString() : this.char_14[num5 - 1].ToString();
        if (num7 < 0)
        {
            return A_0;
        }
        int num3 = 0;
        int num4 = num7 + 1;
        while (num3 < num4)
        {
            builder.Append(str);
            num3++;
        }
        return builder.ToString();
    }

    public string method_6(string A_0)
    {
        decimal num2;
        int num = 0x12;
        try
        {
            num2 = decimal.Parse(A_0);
        }
        catch (FormatException)
        {
            throw new Exception(BookmarkStart.b("氷刹夻ḽ⤿ⱁ㑃㍅㱇橉≋㭍㵏けㅓ⑕硗㱙㍛ⱝൟ͡ၣ䙥ŧᥩ䱫mὯٱ味ᕵ᝷ࡹ๻᭽ꪃ", num));
        }
        if ((num2 > 0M) && (num2 <= 10M))
        {
            return this.char_9[(int) decimal.op_Decrement(num2)].ToString();
        }
        return A_0;
    }

    public string method_7(string A_0)
    {
        decimal num2;
        int num = 0x12;
        try
        {
            num2 = decimal.Parse(A_0);
        }
        catch (FormatException)
        {
            throw new Exception(BookmarkStart.b("氷刹夻ḽ⤿ⱁ㑃㍅㱇橉≋㭍㵏けㅓ⑕硗㱙㍛ⱝൟ͡ၣ䙥ŧᥩ䱫mὯٱ味ᕵ᝷ࡹ๻᭽ꪃ", num));
        }
        if ((num2 > 0M) && (num2 <= 12M))
        {
            return this.char_8[(int) decimal.op_Decrement(num2)].ToString();
        }
        return A_0;
    }

    public string method_8(string A_0)
    {
        decimal num2;
        int num = 4;
        try
        {
            num2 = decimal.Parse(A_0);
        }
        catch (FormatException)
        {
            throw new Exception(BookmarkStart.b("縩䐫䬭ု嬱娳䘵䴷丹᰻倽㔿⽁♃⍅㩇橉⩋⅍≏㽑㕓≕硗㍙⽛繝๟ൡၣ䙥୧թṫᱭᕯᅱs塵", num));
        }
        if ((num2 > 0M) && (num2 <= 20M))
        {
            return this.char_10[(int) decimal.op_Decrement(num2)].ToString();
        }
        return A_0;
    }

    public string method_9(string A_0)
    {
        decimal num2;
        int num = 5;
        try
        {
            num2 = decimal.Parse(A_0);
        }
        catch (FormatException)
        {
            throw new Exception(BookmarkStart.b("缪䔬䨮ᄰ娲嬴䜶䰸伺ᴼ儾㑀⹂❄≆㭈歊⭌⁎⍐㹒㑔⍖祘㉚⹜罞འౢᅤ䝦੨ѪὬᵮᑰၲŴ奶", num));
        }
        if ((num2 > 0M) && (num2 <= 10M))
        {
            return this.char_11[(int) decimal.op_Decrement(num2)].ToString();
        }
        return A_0;
    }
}

