using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Layouting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal class Class544
{
    private bool bool_0;
    private Class196 class196_0;
    private Class543 class543_0;
    private Font font_0;
    private Graphics graphics_0;
    private Interface1 interface1_0;
    private Regex regex_0 = new Regex(BookmarkStart.b("眫爭䔯ر儳ص࠷᜹总䬽礿⑁╃獅ᕇ慉", 6));
    private Regex regex_1 = new Regex(BookmarkStart.b("眫爭䔯ıгȵ࠷᜹总䬽猿牁絃⁅ᕇ慉", 6));
    private Regex regex_2 = new Regex(BookmarkStart.b("眫爭䔯ıг圵࠷᜹总䬽猿牁≃⁅ᕇ慉", 6));
    private SizeF sizeF_0;
    private sprᝪ sprᝪ_0;
    private string string_0;
    private StringFormat stringFormat_0;

    internal Class196 method_0()
    {
        return this.class196_0;
    }

    internal void method_1(Class196 A_0)
    {
        this.class196_0 = A_0;
    }

    private Class545 method_10()
    {
        Class545 class2 = new Class545();
        Class545 class3 = new Class545();
        List<Struct11> list = new List<Struct11>();
        string str = this.class543_0.method_5();
        for (float i = this.method_21(true); str != null; i = this.method_21(false))
        {
            class3 = this.method_17(str, i);
            if (this.class543_0.method_1() == str.Length)
            {
                return class3;
            }
            if (!class3.method_0())
            {
                int num2 = 0;
                if (!this.method_11(class2, class3, list, out num2))
                {
                    this.class543_0.method_9(num2);
                    break;
                }
                if (this.class543_0.method_1() == this.class543_0.method_2())
                {
                    break;
                }
            }
            if ((class3.string_0 != null) && (class3.string_0.Length > 0))
            {
                break;
            }
            this.class543_0.method_4();
            str = this.class543_0.method_5();
        }
        this.method_12(class2, list);
        return class2;
    }

    private bool method_11(Class545 A_0, Class545 A_1, List<Struct11> A_2, out int A_3)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尭唯䄱䄳娵䰷", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈭夯就儳搵崷䤹䤻刽㐿", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈭夯就儳䔵", num));
        }
        bool flag2 = true;
        bool flag = (this.stringFormat_0 != null) && (this.stringFormat_0.FormatFlags != StringFormatFlags.LineLimit);
        float height = A_0.sizeF_0.Height;
        float num4 = this.sizeF_0.Height;
        A_3 = 0;
        if (A_1.struct11_0 != null)
        {
            int index = 0;
            int length = A_1.struct11_0.Length;
            while (index < length)
            {
                float num3 = height + A_1.float_0;
                if (((num3 > num4) && (num4 > 0f)) && !flag)
                {
                    flag2 = false;
                    break;
                }
                Struct11 struct2 = A_1.struct11_0[index];
                A_3 += struct2.string_0.Length;
                struct2 = this.method_19(struct2, A_2.Count == 0);
                A_2.Add(struct2);
                SizeF ef = A_0.sizeF_0;
                ef.Width = Math.Max(ef.Width, struct2.float_0);
                A_0.sizeF_0 = ef;
                if (((num3 >= num4) && (num4 > 0f)) && flag)
                {
                    if ((this.stringFormat_0 == null) || (this.stringFormat_0.FormatFlags != StringFormatFlags.NoClip))
                    {
                        float num5 = num3 - num4;
                        float num6 = A_1.float_0 - num5;
                        height += num6;
                    }
                    else
                    {
                        height = num3;
                    }
                    flag2 = false;
                    break;
                }
                height = num3;
                index++;
            }
        }
        if (height != A_0.sizeF_0.Height)
        {
            SizeF ef2 = A_0.sizeF_0;
            ef2.Height = height;
            A_0.sizeF_0 = ef2;
        }
        return flag2;
    }

    private void method_12(Class545 A_0, List<Struct11> A_1)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐵崷䤹䤻刽㐿", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娵儷吹夻䴽", num));
        }
        A_0.struct11_0 = A_1.ToArray();
        A_0.float_0 = this.method_14();
        if (!this.class543_0.method_0())
        {
            int length = A_1[0].string_0.Length;
            A_0.string_0 = this.string_0.Substring(length, this.string_0.Length - length).TrimStart(Class543.char_3);
        }
        A_1.Clear();
    }

    private void method_13()
    {
        if (this.font_0 != null)
        {
            this.font_0 = null;
        }
        if (this.stringFormat_0 != null)
        {
            this.stringFormat_0.Dispose();
            this.stringFormat_0 = null;
        }
        if (this.class543_0 != null)
        {
            this.class543_0.method_12();
            this.class543_0 = null;
        }
        this.string_0 = null;
    }

    private float method_14()
    {
        return ((this.sprᝪ_0 != null) ? this.sprᝪ_0.ᜇ() : ((this.font_0 != null) ? ((float) this.font_0.Height) : 0f));
    }

    internal bool method_15(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        for (int i = 0; i < chArray.Length; i++)
        {
            if (chArray[i] > '\x00ff')
            {
                return true;
            }
        }
        return false;
    }

    internal bool method_16(string A_0)
    {
        if ((!this.regex_0.IsMatch(A_0) && !this.regex_1.IsMatch(A_0)) && !this.regex_2.IsMatch(A_0))
        {
            return false;
        }
        return true;
    }

    private Class545 method_17(string A_0, float A_1)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弲尴夶尸", num));
        }
        A_0 = A_0.Replace(BookmarkStart.b("㨲", num), BookmarkStart.b("ጲᔴ᜶ᤸ", num));
        Class545 class3 = new Class545 {
            float_0 = this.method_14()
        };
        List<Struct11> list = new List<Struct11>();
        float width = this.sizeF_0.Width;
        float num6 = this.method_20(A_0) + A_1;
        TextLineType firstParagraphLine = TextLineType.FirstParagraphLine;
        bool flag2 = true;
        bool flag3 = false;
        PointF location = this.method_0().method_128().method_13().Location;
        SizeF size = (this.sprᝪ_0 != null) ? ((SizeF) this.method_7(A_0.ToString(), this.sprᝪ_0)) : ((SizeF) this.method_6(A_0.ToString(), this.font_0));
        RectangleF ef18 = new RectangleF(location, size);
        Class312 class5 = this.method_0().method_28().method_51(ef18, this.interface1_0);
        if (((width <= 0f) || (num6 <= width)) && ((width > 0f) && class5.method_0().IsEmpty))
        {
            this.method_18(class3, list, A_0, num6, TextLineType.NewLineBreak | firstParagraphLine);
        }
        else
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();
            num6 = A_1;
            Class543 class4 = new Class543(A_0);
            string str3 = class4.method_7();
            if ((str3.Length != class4.method_1()) && (str3 == BookmarkStart.b("ጲ", num)))
            {
                class4.method_3(class4.method_2() + 1);
                str3 = BookmarkStart.b("ጲ", num) + class4.method_7();
            }
            while (str3 != null)
            {
                int num9;
                PointF tf;
                bool flag = this.method_16(str3);
                int num7 = 0;
                if (!flag)
                {
                    builder2.Append(str3);
                }
                else
                {
                    num9 = 0;
                    while (num9 < str3.Length)
                    {
                        builder2.Append(str3.Substring(num9, 1));
                        if (this.method_20(builder2.ToString()) > width)
                        {
                            goto Label_01FD;
                        }
                        num9++;
                    }
                }
                goto Label_0201;
            Label_01FD:
                num7 = num9;
            Label_0201:
                tf = this.method_0().method_128().method_13().Location;
                SizeF ef12 = (this.sprᝪ_0 != null) ? ((SizeF) this.method_7(builder2.ToString(), this.sprᝪ_0)) : ((SizeF) this.method_6(builder2.ToString(), this.font_0));
                RectangleF ef2 = new RectangleF(tf, new SizeF(ef12.Width, ef12.Height));
                Class312 class2 = this.method_0().method_28().method_51(ef2, this.interface1_0);
                float num13 = ef2.Right + class2.method_0().Width;
                float num5 = this.method_20(builder2.ToString());
                LineBreaksPunctuation punctuation = Class203.smethod_0(builder2[builder2.Length - 1]);
                bool flag4 = char.IsPunctuation(builder2[builder2.Length - 1]);
                float num11 = 0f;
                if (flag4)
                {
                    num11 = (this.sprᝪ_0 != null) ? ((float) this.method_7(BookmarkStart.b("ጲ", num), this.sprᝪ_0).Width) : ((float) this.method_6(BookmarkStart.b("ጲ", num), this.font_0).Width);
                }
                if ((((num5 - width) > 0.005) && ((punctuation != LineBreaksPunctuation.LineBreaksBefore) || ((num5 - width) > (num11 / 2f)))) || (((!class2.method_0().IsEmpty && (class2.method_2().method_0() != TextWrappingStyle.Inline)) && ((class2.method_2().method_0() != TextWrappingStyle.InFrontOfText) && (class2.method_2().method_0() != TextWrappingStyle.Behind))) && (class2.method_2().method_0() != TextWrappingStyle.TopAndBottom)))
                {
                    if (((class2.method_2().method_0() != TextWrappingStyle.Inline) && (class2.method_2().method_0() != TextWrappingStyle.InFrontOfText)) && ((class2.method_2().method_0() != TextWrappingStyle.Behind) && (class2.method_2().method_0() != TextWrappingStyle.TopAndBottom)))
                    {
                        if (num13 < this.method_0().method_128().method_13().Right)
                        {
                            this.method_0().method_28().method_14(true);
                            float num14 = class2.method_0().Left + ((float) Math.Round((double) class2.method_0().Width, 6));
                            this.method_0().method_28().method_16(Math.Max(class2.method_0().Right, num14));
                        }
                        else if (((num13 > this.method_0().method_128().method_13().Right) && !this.bool_0) && ((ef2.Left < class2.method_0().Left) || (this.method_0().method_128().method_13().Left > class2.method_0().Left)))
                        {
                            builder.Append(BookmarkStart.b("ጲ", num));
                            break;
                        }
                    }
                    if (this.method_22() == StringTrimming.None)
                    {
                        break;
                    }
                    if ((builder2.Length == str3.Length) && !flag)
                    {
                        int length = A_0.Split(null).Length;
                        if ((this.method_22() == StringTrimming.Word) || (length == 1))
                        {
                            class3.string_0 = A_0.Substring(class4.method_2());
                            if (str3.StartsWith(BookmarkStart.b("ጲ", num)))
                            {
                                builder.Append(A_0.Substring(0, class4.method_2()));
                            }
                            break;
                        }
                        flag2 = false;
                        builder2.Length = 0;
                        str3 = class4.method_11().ToString();
                    }
                    else
                    {
                        if ((this.method_22() != StringTrimming.Character) || !flag2)
                        {
                            string str4 = builder.ToString();
                            if (flag && (num7 > 0))
                            {
                                builder2.Remove(builder2.Length - 1, 1);
                                str4 = builder2.ToString();
                                builder = builder2;
                                class4.method_3(builder2.Length);
                            }
                            else if ((flag && (str4.Length == 0)) && (num7 == 0))
                            {
                                class4.method_3(0);
                                class3.string_0 = class4.method_13();
                                flag3 = true;
                            }
                            break;
                        }
                        flag2 = false;
                        builder2.Length = 0;
                        builder2.Append(builder.ToString());
                        str3 = class4.method_11().ToString();
                    }
                }
                else
                {
                    if ((flag && ((num7 > 0) || (builder2.Length == 1))) && ((punctuation == LineBreaksPunctuation.LineBreaksBefore) && ((num5 - width) <= (num11 / 2f))))
                    {
                        builder.Append(builder2);
                        num6 = num5;
                        flag2 = false;
                        class4.method_3(builder2.Length - 1);
                    }
                    else
                    {
                        builder.Append(str3);
                        num6 = num5;
                    }
                    if (flag2)
                    {
                        class4.method_6();
                        str3 = class4.method_7();
                    }
                    else
                    {
                        class4.method_8();
                        str3 = class4.method_11().ToString();
                    }
                }
            }
            if ((builder.Length > 0) || this.method_0().method_28().method_13())
            {
                string str = builder.ToString();
                int num2 = str.Length;
                int num3 = Class203.smethod_4(A_0, num2);
                if (num3 != 0)
                {
                    string str2 = A_0.Substring(0, num2 + num3);
                    float num12 = this.method_0().method_1() ? this.method_0().method_309(str2, this.sprᝪ_0, null).Width : this.method_0().method_316(str2, this.font_0, null).Width;
                    if (num12 <= width)
                    {
                        str = str2;
                        class4.method_3(class4.method_2() + num3);
                    }
                }
                while (class4.method_11() == ' ')
                {
                    class4.method_3(class4.method_2() + 1);
                }
                this.method_18(class3, list, str, num6, TextLineType.LastParagraphLine | TextLineType.NewLineBreak);
                if (!flag3)
                {
                    class3.string_0 = class4.method_13();
                }
            }
            class4.method_12();
        }
        class3.struct11_0 = list.ToArray();
        list.Clear();
        return class3;
    }

    private void method_18(Class545 A_0, List<Struct11> A_1, string A_2, float A_3, TextLineType A_4)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尯嬱娳匵樷弹伻䬽ⰿ㙁", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尯嬱娳匵䬷", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尯嬱娳匵", num));
        }
        Struct11 item = new Struct11 {
            string_0 = A_2,
            float_0 = A_3,
            textLineType_0 = A_4
        };
        A_1.Add(item);
        SizeF ef = A_0.sizeF_0;
        ef.Height += this.method_14();
        ef.Width = Math.Max(ef.Width, A_3);
        A_0.sizeF_0 = ef;
    }

    private Struct11 method_19(Struct11 A_0, bool A_1)
    {
        string str = A_0.string_0;
        float num = A_0.float_0;
        bool flag = (A_0.textLineType_0 & TextLineType.FirstParagraphLine) == TextLineType.None;
        bool flag2 = (this.stringFormat_0 == null) || (this.stringFormat_0.FormatFlags != StringFormatFlags.DirectionRightToLeft);
        char[] trimChars = Class543.char_3;
        if (flag)
        {
            str = flag2 ? str.TrimStart(trimChars) : str.TrimEnd(trimChars);
        }
        if ((this.stringFormat_0 == null) || (this.stringFormat_0.FormatFlags != StringFormatFlags.MeasureTrailingSpaces))
        {
            if (((A_0.textLineType_0 & TextLineType.FirstParagraphLine) > TextLineType.None) && Class543.smethod_2(str))
            {
                str = new string(' ', 1);
            }
            else
            {
                str = flag2 ? str.TrimEnd(trimChars) : str.TrimStart(trimChars);
            }
        }
        if (str.Length != A_0.string_0.Length)
        {
            num = this.method_20(str);
            if ((A_0.textLineType_0 & TextLineType.FirstParagraphLine) > TextLineType.None)
            {
                num += this.method_21(A_1);
            }
        }
        A_0.string_0 = str;
        A_0.float_0 = num;
        return A_0;
    }

    internal void method_2(bool A_0)
    {
        this.bool_0 = A_0;
    }

    private float method_20(string A_0)
    {
        SizeF ef4 = (this.sprᝪ_0 != null) ? this.sprᝪ_0.ᜃ(A_0) : this.graphics_0.MeasureString(A_0, this.font_0, new SizeF(float.MaxValue, float.MaxValue), this.stringFormat_0);
        float width = ef4.Width;
        if ((this.interface1_0 != null) && (this.interface1_0 is TextRange))
        {
            TextRange range = this.interface1_0 as TextRange;
            if (range.IsBalanceWidthCharOfSingleByteAndDoubleByte)
            {
                width = this.method_0().method_323(range, A_0).Width;
            }
            else
            {
                Class560 class2 = ((Interface11) range.CharacterFormat).imethod_0() as Class560;
                if (class2.method_13())
                {
                    width = this.method_0().method_323(range, A_0).Width;
                }
                else if (class2.method_14())
                {
                    width = this.method_0().method_323(range, A_0.ToUpper()).Width;
                }
                if ((class2.method_15() != 1f) && (class2.method_15() > 0f))
                {
                    width *= class2.method_15();
                }
                if (class2.method_16() != 0f)
                {
                    width = this.method_0().method_244(width, A_0.Length, class2.method_16());
                }
            }
            if (((range.StartPos == 0) && (A_0 == range.Text)) && (range.OwnerParagraph != null))
            {
                Class213 class3 = ((Interface1) range.OwnerParagraph).imethod_0() as Class213;
                width += class3.method_69();
            }
        }
        if (((width == 0.0) && !this.bool_0) && (A_0.Length > 1))
        {
            width = (this.sprᝪ_0 != null) ? ((float) this.method_7(A_0, this.sprᝪ_0).Width) : ((float) this.method_6(A_0, this.font_0).Width);
        }
        return width;
    }

    private float method_21(bool A_0)
    {
        float num = 0f;
        if (this.stringFormat_0 != null)
        {
            num = (this.sizeF_0.Width > 0f) ? Math.Min(this.sizeF_0.Width, num) : num;
        }
        return num;
    }

    private StringTrimming method_22()
    {
        return ((this.stringFormat_0 != null) ? this.stringFormat_0.Trimming : StringTrimming.Word);
    }

    internal void method_3(Interface1 A_0)
    {
        this.interface1_0 = A_0;
    }

    public Class545 method_4(string A_0, Graphics A_1, Font A_2, StringFormat A_3, SizeF A_4)
    {
        this.method_8(A_0, A_1, A_2, A_3, A_4);
        Class545 class2 = this.method_10();
        this.method_13();
        return class2;
    }

    public Class545 method_5(string A_0, Graphics A_1, Font A_2, sprᝪ A_3, StringFormat A_4, SizeF A_5)
    {
        this.method_9(A_0, A_1, A_2, A_3, A_4, A_5);
        Class545 class2 = this.method_10();
        this.method_13();
        return class2;
    }

    public Size method_6(string A_0, Font A_1)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return Size.Empty;
        }
        CharacterRange[] ranges = new CharacterRange[] { new CharacterRange(0, A_0.Length) };
        Region[] regionArray = null;
        StringFormat stringFormat = this.stringFormat_0;
        stringFormat.SetMeasurableCharacterRanges(ranges);
        regionArray = this.graphics_0.MeasureCharacterRanges(A_0, A_1, new Rectangle(0, 0, 0x7fffffff, 0x7fffffff), stringFormat);
        RectangleF bounds = regionArray[0].GetBounds(this.graphics_0);
        bounds.Width += 2f * bounds.X;
        bounds.Height += 2f * bounds.Y;
        if (regionArray != null)
        {
            regionArray[0].Dispose();
            regionArray = null;
        }
        if ((this.interface1_0 != null) && (this.interface1_0 is TextRange))
        {
            TextRange range = this.interface1_0 as TextRange;
            Class560 class2 = ((Interface11) range.CharacterFormat).imethod_0() as Class560;
            if ((class2.method_15() != 1f) && (class2.method_15() > 0f))
            {
                bounds.Width *= class2.method_15();
            }
            if (class2.method_16() != 0f)
            {
                bounds.Width = this.method_0().method_243(bounds.Size, A_0.Length, class2.method_16()).Width;
            }
        }
        return Size.Ceiling(bounds.Size);
    }

    public Size method_7(string A_0, sprᝪ A_1)
    {
        if (!string.IsNullOrEmpty(A_0) && (A_1 != null))
        {
            return Size.Ceiling(A_1.ᜃ(A_0));
        }
        return new Size();
    }

    private void method_8(string A_0, Graphics A_1, Font A_2, StringFormat A_3, SizeF A_4)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜲倴伶䴸", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唲娴夶䴸", num));
        }
        this.string_0 = A_0;
        this.graphics_0 = A_1;
        this.font_0 = A_2;
        this.stringFormat_0 = A_3;
        this.sizeF_0 = A_4;
        this.class543_0 = new Class543(A_0);
    }

    private void method_9(string A_0, Graphics A_1, Font A_2, sprᝪ A_3, StringFormat A_4, SizeF A_5)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䘱儳丵䰷", num));
        }
        if ((A_2 == null) && (A_3 == null))
        {
            throw new ArgumentNullException(BookmarkStart.b("吱嬳堵䰷", num));
        }
        this.string_0 = A_0;
        this.graphics_0 = A_1;
        this.font_0 = A_2;
        this.sprᝪ_0 = A_3;
        this.stringFormat_0 = A_4;
        this.sizeF_0 = A_5;
        this.class543_0 = new Class543(A_0);
    }
}

