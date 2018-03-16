using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Layouting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class375 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    [CompilerGenerated]
    private bool bool_10;
    [CompilerGenerated]
    private bool bool_11;
    [CompilerGenerated]
    private bool bool_12;
    [CompilerGenerated]
    private bool bool_13;
    [CompilerGenerated]
    private bool bool_14;
    [CompilerGenerated]
    private bool bool_15;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    [CompilerGenerated]
    private bool bool_6;
    [CompilerGenerated]
    private bool bool_7;
    [CompilerGenerated]
    private bool bool_8;
    [CompilerGenerated]
    private bool bool_9;
    private Class375 class375_0;
    private Class376 class376_0;
    private Class500 class500_0;
    private Field field_0;
    internal const float float_0 = 1.2f;
    internal const float float_1 = 0.1f;
    private float float_10;
    private float float_11;
    private float float_12;
    [CompilerGenerated]
    private float float_13;
    private float float_2;
    private float float_3;
    private float float_4;
    private float float_5;
    private float float_6;
    private float float_7;
    private float float_8;
    private float float_9;
    private HorizontalAlignment horizontalAlignment_0;
    private int int_0;
    private int int_1;
    private int int_2;
    [CompilerGenerated]
    private int int_3;
    private Interface1 interface1_0;
    private List<RectangleF> list_0;
    private RectangleF? nullable_0;
    private RectangleF rectangleF_0;
    private string string_0;
    private Struct1 struct1_0;
    private TabJustification tabJustification_0;

    public Class375(Interface1 A_0)
    {
        this.rectangleF_0 = RectangleF.Empty;
        this.int_1 = -2147483648;
        this.struct1_0 = new Struct1();
        this.float_7 = float.MinValue;
        this.float_8 = float.MinValue;
        this.float_11 = float.MinValue;
        this.int_2 = -1;
        this.interface1_0 = A_0;
    }

    public Class375(Interface1 A_0, PointF A_1)
    {
        this.rectangleF_0 = RectangleF.Empty;
        this.int_1 = -2147483648;
        this.struct1_0 = new Struct1();
        this.float_7 = float.MinValue;
        this.float_8 = float.MinValue;
        this.float_11 = float.MinValue;
        this.int_2 = -1;
        this.interface1_0 = A_0;
        this.rectangleF_0 = new RectangleF(A_1, new SizeF());
    }

    internal bool method_0()
    {
        return this.bool_5;
    }

    internal void method_1(bool A_0)
    {
        this.bool_5 = A_0;
    }

    internal float method_10()
    {
        return this.float_7;
    }

    private void method_100()
    {
        if ((this.int_1 >= 0) && (this.int_1 < this.method_74().Count))
        {
            this.method_21(this.method_74().method_4(this.int_1).method_69().Y);
            this.float_7 = this.method_74().method_4(this.int_1).method_69().Y + ((float) this.struct1_0.method_0());
            foreach (Class375 class2 in this.method_74())
            {
                class2.method_11(this.float_7);
            }
        }
    }

    public void method_101(PageSetup A_0)
    {
        float y = this.rectangleF_0.Y;
        float bottom = this.rectangleF_0.Bottom;
        Class376 class2 = new Class376();
        int num3 = 0;
        int count = this.method_74().Count;
        while (num3 < count)
        {
            Class375 class3 = this.method_74().method_4(num3);
            if (class3.method_73().imethod_0().imethod_26() && !class3.method_73().imethod_0().imethod_32())
            {
                y = Math.Min(class3.method_69().Y, y);
                bottom = Math.Max(class3.method_69().Bottom, bottom);
                class2.method_8(class3);
            }
            num3++;
        }
        bottom = (bottom <= (A_0.PageSize.Height - A_0.FooterDistance)) ? bottom : (A_0.PageSize.Height - A_0.FooterDistance);
        this.rectangleF_0.Y = y;
        if (this.rectangleF_0.Bottom != bottom)
        {
            this.rectangleF_0.Height = bottom - y;
        }
    }

    public void method_102()
    {
        float y = this.rectangleF_0.Y;
        float num2 = 0f;
        int num3 = 0;
        int count = this.method_74().Count;
        while (num3 < count)
        {
            Class375 class2 = this.method_74().method_4(num3);
            Paragraph paragraph = (class2.method_73() is Paragraph) ? (class2.method_73() as Paragraph) : ((!(class2.method_73() is Class65) || !((class2.method_73() as Class65).method_2() is Paragraph)) ? null : ((class2.method_73() as Class65).method_2() as Paragraph));
            if ((class2.method_73().imethod_0().imethod_26() && !class2.method_73().imethod_0().imethod_32()) || ((class2.method_73().imethod_0().imethod_32() && (paragraph != null)) && (paragraph.Format.IsFrame && (paragraph.Format.FrameVerticalPos == 2))))
            {
                if (class2.method_69().Y >= this.rectangleF_0.Y)
                {
                    y = Math.Min(class2.method_69().Y, y);
                }
                num2 = Math.Max(class2.method_69().Bottom, num2);
            }
            num3++;
        }
        if (this.rectangleF_0.Bottom != num2)
        {
            this.rectangleF_0.Height = num2 - y;
        }
    }

    public void method_103(PageSetup A_0)
    {
        float y = this.rectangleF_0.Y;
        float bottom = this.rectangleF_0.Bottom;
        Class376 class2 = new Class376();
        int num3 = 0;
        int count = this.method_74().Count;
        while (num3 < count)
        {
            Class375 class3 = this.method_74().method_4(num3);
            if (class3.method_73().imethod_0().imethod_26() && !class3.method_73().imethod_0().imethod_32())
            {
                y = Math.Min(class3.method_69().Y, y);
                bottom = Math.Max(class3.method_69().Bottom, bottom);
            }
            else if (class3.method_73().imethod_0().imethod_32())
            {
                class2.method_8(class3);
            }
            num3++;
        }
        bottom = (bottom <= A_0.HeaderDistance) ? A_0.HeaderDistance : bottom;
        this.rectangleF_0.Y = y;
        if (this.rectangleF_0.Bottom != bottom)
        {
            this.rectangleF_0.Height = ((bottom - y) > 0f) ? (bottom - y) : 0f;
        }
    }

    private bool method_104(Class375 A_0)
    {
        if ((A_0.method_73() is DocPicture) && (((A_0.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.InFrontOfText) || ((A_0.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Behind)))
        {
            return false;
        }
        return ((!(A_0.method_73() is Table) || !(A_0.method_73() as Table).IsTextBox) || (((A_0.method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && ((A_0.method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)));
    }

    public bool method_105(Class196 A_0)
    {
        double height;
        double num9;
        double num10;
        LineSpacingRule multiple = LineSpacingRule.Multiple;
        bool flag2 = false;
        float num = 0f;
        float num2 = 0f;
        float maxValue = float.MaxValue;
        float num4 = float.MaxValue;
        float num5 = 0f;
        float num6 = 0f;
        bool flag3 = false;
        bool flag4 = false;
        bool flag5 = false;
        bool flag6 = false;
        bool flag7 = false;
        float num7 = 0f;
        Paragraph paragraph = null;
        if ((this.method_73() is Paragraph) || (this.method_73() is Class65))
        {
            paragraph = (this.method_73() is Paragraph) ? (this.method_73() as Paragraph) : ((this.method_73() as Class65).method_2() as Paragraph);
        }
        this.method_119(A_0, out height, out num9, out num10);
        if (height > this.rectangleF_0.Height)
        {
            height = this.rectangleF_0.Height;
        }
        else
        {
            float single1 = this.rectangleF_0.Height;
        }
        if (num9 > height)
        {
            num9 = height;
        }
        Struct1 struct2 = ((this.method_7().method_8() > 0.0) || (paragraph == null)) ? this.method_7() : A_0.method_338(paragraph);
        if ((num10 / this.method_7().method_7()) > 1.2000000476837158)
        {
            struct2.method_10(num10);
        }
        if (paragraph != null)
        {
            Class213 class4 = this.method_73().imethod_0() as Class213;
            multiple = class4.method_55();
            num2 = Math.Abs(class4.method_53());
            if (class4.method_106())
            {
                Section section = paragraph.method_49();
                if (((section != null) && (section.PageSetup.PitchType != GridPitchType.NoGrid)) && (section.PageSetup.PitchType != GridPitchType.SnapToChars))
                {
                    flag2 = true;
                    num = (float) Math.Round((double) section.PageSetup.LinePitch, 2);
                }
            }
        }
        for (int i = 0; i < this.method_74().Count; i++)
        {
            Class375 class2 = this.method_74().method_4(i);
            if ((class2 != null) && !class2.method_73().imethod_0().imethod_12())
            {
                double num35 = 0.0;
                float top = class2.method_69().Top;
                num35 = this.method_111(paragraph, struct2, A_0, class2);
                float num12 = 0f;
                if ((class2.method_73() is ParagraphBase) || (class2.method_73() is Class542))
                {
                    if (class2.method_73().imethod_0().imethod_14())
                    {
                        flag6 = true;
                    }
                    ParagraphBase base2 = (class2.method_73() is ParagraphBase) ? (class2.method_73() as ParagraphBase) : ((class2.method_73() as Class542).method_2() as ParagraphBase);
                    num12 = (((Interface11) base2.CharacterFormat).imethod_0() as Class560).method_17();
                    if (num12 == 0f)
                    {
                        flag5 = true;
                    }
                    else if (num12 > 0f)
                    {
                        flag3 = true;
                        num5 = Math.Max(num5, num12);
                    }
                    else if (class2.method_73().imethod_0().imethod_14())
                    {
                        flag7 = true;
                        num7 = Math.Min(num7, num12);
                    }
                    else
                    {
                        flag4 = true;
                        num6 = Math.Min(num6, num12);
                    }
                    num35 -= num12;
                }
                class2.method_94(0.0, num35, true);
                top = class2.method_69().Top;
                if (num12 != 0f)
                {
                    maxValue = Math.Min(maxValue, top);
                }
                else
                {
                    num4 = Math.Min(num4, top);
                }
            }
        }
        bool flag8 = (!flag3 && !flag4) && !flag7;
        if ((multiple == LineSpacingRule.AtLeast) || ((multiple == LineSpacingRule.Multiple) && !flag8))
        {
            if (flag8)
            {
                float bottom = this.rectangleF_0.Bottom;
                for (int j = 0; j < this.method_74().Count; j++)
                {
                    if (((this.method_74().method_4(j).method_73() != null) && !this.method_74().method_4(j).method_73().imethod_0().imethod_12()) && (bottom < this.method_74().method_4(j).method_69().Bottom))
                    {
                        bottom = this.method_74().method_4(j).method_69().Bottom;
                    }
                }
                float num25 = bottom - this.rectangleF_0.Top;
                num25 = Math.Max(num25, num2);
                this.rectangleF_0 = new RectangleF(this.rectangleF_0.X, this.rectangleF_0.Y, this.rectangleF_0.Width, num25);
            }
            else
            {
                float num16 = (this.method_8() == 0f) ? this.rectangleF_0.Height : this.method_8();
                this.struct1_0.method_18((double) num5);
                this.struct1_0.method_20((double) Math.Abs(num6));
                struct2.method_18((double) num5);
                struct2.method_20((double) Math.Abs(num6));
                float num26 = Math.Min(num4, maxValue);
                if ((!flag8 && (num26 != float.MaxValue)) && (num26 != this.rectangleF_0.Top))
                {
                    this.method_93(0.0, (double) (this.rectangleF_0.Top - num26), true);
                }
                float num18 = 0f;
                float num20 = num5;
                float num15 = Math.Abs(num6);
                float num21 = Math.Abs(num7);
                if ((flag3 && !flag4) && !flag5)
                {
                    num20 -= (float) this.method_7().method_4();
                    num20 = (num20 < 0f) ? 0f : num20;
                }
                else if ((!flag3 && flag4) && !flag5)
                {
                    num15 -= (float) this.method_7().method_0();
                    num15 = (num15 < 0f) ? 0f : num15;
                }
                if (flag7)
                {
                    num21 -= (float) this.method_7().method_0();
                    num21 = (num21 < 0f) ? 0f : num21;
                    num15 = Math.Max(num15, num21);
                }
                num18 = num20 + num15;
                num18 = (num18 < 0f) ? 0f : num18;
                switch (multiple)
                {
                    case LineSpacingRule.AtLeast:
                    {
                        if (flag2)
                        {
                            float num30 = (float) Math.Round((double) this.rectangleF_0.Height, 2);
                            float num31 = (float) struct2.method_11();
                            float num32 = (float) Math.Round((double) (num31 + num18), 2);
                            if ((num32 - num30) > 0.01)
                            {
                                float num33 = num32 % num;
                                num32 += num - num33;
                                this.rectangleF_0 = new RectangleF(this.rectangleF_0.Location, new SizeF(this.rectangleF_0.Width, num32));
                            }
                            break;
                        }
                        float num37 = (float) struct2.method_11();
                        float num38 = num37 + num18;
                        num38 = Math.Max(num38, num2);
                        this.rectangleF_0 = new RectangleF(new PointF(this.rectangleF_0.X, this.rectangleF_0.Y), new SizeF(this.rectangleF_0.Width, num38));
                        break;
                    }
                    case LineSpacingRule.Multiple:
                    {
                        float num24 = num16;
                        if (!flag6)
                        {
                            num24 += num18;
                        }
                        else
                        {
                            float num23 = num24 - ((float) num10);
                            float num34 = num20 + ((float) this.method_7().method_0());
                            if (num34 >= num10)
                            {
                                num24 = num23 + ((float) this.method_7().method_0());
                                num24 += num18;
                            }
                            else
                            {
                                num24 = (((float) num10) + num23) + num15;
                            }
                        }
                        if (!flag2)
                        {
                            float num11 = num16;
                            if (flag6)
                            {
                                float num19 = num11 - ((float) num10);
                                float num29 = num20 + ((float) this.method_7().method_0());
                                if (num29 < num10)
                                {
                                    num11 = (((float) num10) + num19) + num15;
                                }
                                else
                                {
                                    num11 = num19 + ((float) this.method_7().method_0());
                                    num11 += num18;
                                }
                            }
                            else
                            {
                                num11 += num18;
                            }
                            this.rectangleF_0 = new RectangleF(new PointF(this.rectangleF_0.X, this.rectangleF_0.Y), new SizeF(this.rectangleF_0.Width, num11));
                        }
                        else
                        {
                            float num27 = this.rectangleF_0.Height;
                            float num28 = (float) struct2.method_11();
                            float num22 = num28 + num18;
                            num22 = (struct2.method_21() > this.rectangleF_0.Height) ? num22 : this.rectangleF_0.Height;
                            if ((num22 - num27) > 0.01)
                            {
                                float num39 = num22 % num;
                                num22 += num - num39;
                                this.rectangleF_0 = new RectangleF(this.rectangleF_0.Location, new SizeF(this.rectangleF_0.Width, num22));
                            }
                        }
                        break;
                    }
                }
            }
        }
        this.method_100();
        return false;
    }

    public void method_106(Class196 A_0, double A_1)
    {
        A_1 += this.method_108(A_0);
        A_1 /= 2.0;
        this.method_94(A_1, 0.0, true);
    }

    public void method_107(Class196 A_0, double A_1)
    {
        A_1 += this.method_108(A_0);
        this.method_94(A_1, 0.0, true);
    }

    private double method_108(Class196 A_0)
    {
        double num = 0.0;
        int num2 = 0;
        if (this.method_74().Count > 0)
        {
            for (int i = this.method_74().Count - 1; i >= 0; i--)
            {
                Class375 class2 = this.method_74().method_4(i);
                Class542 class3 = class2.method_73() as Class542;
                if ((class3 != null) && (class3.method_0() != null))
                {
                    class3.method_2();
                    int length = class3.method_0().Length;
                    class3.method_1(class3.method_0().TrimEnd(new char[] { ' ' }));
                    num2 = length - class3.method_0().Length;
                    if (num2 > 0)
                    {
                        SizeF ef = class3.Interface2.imethod_3(A_0);
                        float num6 = class2.method_69().Width - ef.Width;
                        num += num6;
                        class2.method_70(new RectangleF(class2.method_69().X, class2.method_69().Y, ef.Width, class2.method_69().Height));
                    }
                    if (num2 != length)
                    {
                        return num;
                    }
                }
                else if (class2.method_73() is Interface21)
                {
                    TextRange range = class2.method_73() as TextRange;
                    string text = range.Text;
                    num2 = text.Length - text.TrimEnd(new char[] { ' ' }).Length;
                    if (num2 > 0)
                    {
                        SizeF ef6 = A_0.method_323(range, range.Text.TrimEnd(new char[] { ' ' }));
                        float num7 = class2.method_69().Width - ef6.Width;
                        num += num7;
                        class2.method_70(new RectangleF(class2.method_69().X, class2.method_69().Y, ef6.Width, class2.method_69().Height));
                    }
                    if (num2 != text.Length)
                    {
                        return num;
                    }
                }
                else
                {
                    if ((class2.method_73() is DocPicture) && ((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))
                    {
                        return num;
                    }
                    if ((class2.method_73() is TextBox) && ((class2.method_73() as TextBox).Format.TextWrappingStyle == TextWrappingStyle.Inline))
                    {
                        return num;
                    }
                    if (((class2.method_73() is DocOleObject) && ((class2.method_73() as DocOleObject).Interface49.get_OlePicture() != null)) && ((class2.method_73() as DocOleObject).Interface49.get_OlePicture().TextWrappingStyle == TextWrappingStyle.Inline))
                    {
                        return num;
                    }
                }
            }
        }
        return num;
    }

    public void method_109(Class196 A_0, double A_1, ref int A_2)
    {
        int num = 11;
        bool flag = false;
        List<Class375> list = new List<Class375>(this.method_74());
        if (this.interface1_0 is Paragraph)
        {
            flag = true;
            Paragraph paragraph = this.interface1_0 as Paragraph;
            if ((paragraph.Format != null) && (paragraph.Format.FirstLineIndent < 0f))
            {
                float leftIndent = paragraph.Format.LeftIndent;
                for (DocumentObject obj2 = paragraph.Owner; obj2 != null; obj2 = obj2.Owner)
                {
                    if (obj2 is Section)
                    {
                        Section section = obj2 as Section;
                        leftIndent += section.PageSetup.Margins.Left;
                        break;
                    }
                }
            }
        }
        int[] numArray = new int[list.Count];
        int num10 = 0;
        int num12 = 0;
        string[] strArray2 = new string[list.Count];
        int num4 = 0;
        int num6 = 0;
        if (list.Count > 0)
        {
            num4 = A_0.method_170(this.method_74(), list[0], true);
            num6 = A_0.method_170(this.method_74(), list[list.Count - 1], false);
        }
        for (int i = 0; i < numArray.Length; i++)
        {
            Class375 class2 = list[i];
            Interface21 interface3 = class2.method_73() as Interface21;
            string str = null;
            if (interface3 == null)
            {
                Class542 class3 = class2.method_73() as Class542;
                if ((class3 != null) && (class3.method_0() != null))
                {
                    class3.method_2();
                    int length = class3.method_0().Length;
                    if ((i == num4) && (i == num6))
                    {
                        int num16 = class3.method_0().Length;
                        if (!flag)
                        {
                            class3.method_1(class3.method_0().TrimStart(new char[0]));
                        }
                        class3.method_1(class3.method_0().TrimEnd(new char[0]));
                        num12 += num16 - class3.method_0().Length;
                        if (num12 > 0)
                        {
                            SizeF ef10 = class3.Interface2.imethod_3(A_0);
                            A_1 += class2.method_69().Width - ef10.Width;
                            class2.method_70(new RectangleF(class2.method_69().X, class2.method_69().Y, ef10.Width, class2.method_69().Height));
                        }
                    }
                    else if (i <= num4)
                    {
                        if (!flag)
                        {
                            class3.method_1(class3.method_0().TrimStart(new char[0]));
                        }
                    }
                    else if (i == num6)
                    {
                        int num11 = class3.method_0().Length;
                        class3.method_1(class3.method_0().TrimEnd(new char[0]));
                        num12 += num11 - class3.method_0().Length;
                        if (num12 > 0)
                        {
                            SizeF ef15 = class3.Interface2.imethod_3(A_0);
                            A_1 += class2.method_69().Width - ef15.Width;
                            class2.method_70(new RectangleF(class2.method_69().X, class2.method_69().Y, ef15.Width, class2.method_69().Height));
                        }
                    }
                    else if (i > num6)
                    {
                        class3.method_1(class3.method_0().TrimEnd(new char[] { ' ' }));
                        class2.method_70(new RectangleF(class2.method_69().Location, new SizeF(class3.Interface2.imethod_3(A_0).Width, class2.method_69().Height)));
                    }
                    str = class3.method_5();
                    if (flag && (num4 >= i))
                    {
                        str = str.TrimStart(new char[] { ' ' });
                    }
                }
                else
                {
                    numArray[i] = 0;
                }
            }
            else
            {
                str = interface3.imethod_5();
                TextRange range = null;
                if (class2.method_73() is TextRange)
                {
                    range = class2.method_73() as TextRange;
                }
                if (range != null)
                {
                    int num17 = range.Text.Length;
                    if ((i == num4) && (i == num6))
                    {
                        str = range.Text.Trim(new char[] { ' ' });
                    }
                    else if (i <= num4)
                    {
                        str = range.Text.TrimStart(new char[] { ' ' });
                    }
                    else if (i >= num6)
                    {
                        str = range.Text.TrimEnd(new char[] { ' ' });
                    }
                    if ((str != range.Text) && (!class2.method_71().method_52() || !class2.method_71().method_54()))
                    {
                        if (i == num6)
                        {
                            if (Class59.smethod_4(class2.method_71().method_69().Right, class2.method_69().Right, 0.0001f) >= 0)
                            {
                                class2.method_65(range.Text.TrimEnd(new char[] { ' ' }));
                                SizeF size = A_0.method_323(range, class2.method_64());
                                float num5 = class2.method_69().Width - size.Width;
                                A_1 = class2.method_73().imethod_0().imethod_34() ? ((double) num5) : (num5 + A_1);
                                class2.method_70(new RectangleF(class2.method_69().Location, size));
                                class2.method_41(true);
                            }
                        }
                        else if (i <= num4)
                        {
                            A_2 = i;
                        }
                        else if (((i > num6) && !string.IsNullOrEmpty(class2.method_64())) && (class2.method_64().Length > 0))
                        {
                            class2.method_65(class2.method_64().TrimEnd(new char[] { ' ' }));
                        }
                    }
                }
            }
            if (str != null)
            {
                int num9 = str.Split(new char[] { ' ' }).Length - 1;
                numArray[i] = num9;
                list[i].method_51(num9);
                num10 += num9;
                strArray2[i] = str;
            }
            if ((interface3 != null) && (interface3.imethod_5() == BookmarkStart.b("㠰", num)))
            {
                num10 = 0;
                A_2 = i;
            }
        }
        this.rectangleF_0.Width += (float) A_1;
        if (this.rectangleF_0.Right > this.method_26())
        {
            this.rectangleF_0.Width -= this.rectangleF_0.Right - this.method_26();
        }
        float num13 = this.method_112(num10, A_1, numArray, A_2);
        double num8 = 0.0;
        int num14 = num10;
        for (int j = A_2; j < numArray.Length; j++)
        {
            Class375 class4 = list[j];
            Interface21 interface2 = class4.method_73() as Interface21;
            Class542 class5 = null;
            class4.method_94(num8, 0.0, true);
            if (interface2 == null)
            {
                class5 = class4.method_73() as Class542;
            }
            if ((interface2 != null) || (class5 != null))
            {
                RectangleF ef8 = class4.method_69();
                double num15 = num13 * numArray[j];
                if (((j != (numArray.Length - 1)) && (this.method_74().method_4(j + 1).method_73() != null)) && (this.method_74().method_4(j + 1).method_73().imethod_0() is Class206))
                {
                    num15 = 0.0;
                    num14 -= numArray[j];
                    num13 = this.method_112(num14, A_1 - num8, numArray, j + 1);
                }
                ef8.Width += (float) num15;
                class4.method_70(ef8);
                num8 += num15;
            }
        }
    }

    internal void method_11(float A_0)
    {
        this.float_7 = A_0;
    }

    private void method_110(int A_0, string[] A_1, ref int[] A_2, ref int A_3, ref double A_4, List<Class375> A_5, Class196 A_6)
    {
        int num = 0;
        for (int i = A_0 - 1; i >= 0; i--)
        {
            if (A_1[i] != null)
            {
                if (!A_1[i].EndsWith(BookmarkStart.b("إ", num)))
                {
                    break;
                }
                int num3 = A_1[i].Length - A_1[i].TrimEnd(new char[] { ' ' }).Length;
                A_2[i] -= num3;
                A_3 -= num3;
                Class375 local1 = A_5[i];
                local1.method_51(local1.method_50() - num3);
                if (num3 == A_1[i].Length)
                {
                    if ((this.method_26() > 0f) && (A_5[i].method_69().Right <= this.method_26()))
                    {
                        A_4 += A_5[i].method_69().Width;
                    }
                    A_5[i].method_70(new RectangleF(A_5[i].method_69().Location, new SizeF(0f, A_5[i].method_69().Height)));
                }
                else if (num3 > 0)
                {
                    if (A_5[i].method_73() is Interface21)
                    {
                        TextRange range = A_5[i].method_73() as TextRange;
                        A_5[i].method_65(A_1[i].TrimEnd(new char[] { ' ' }));
                        SizeF ef5 = A_6.method_323(range, range.Text.TrimEnd(new char[] { ' ' }));
                        float num4 = A_5[i].method_69().Width - ef5.Width;
                        A_4 = A_5[i].method_73().imethod_0().imethod_34() ? ((double) num4) : (num4 + A_4);
                        A_5[i].method_70(new RectangleF(A_5[i].method_69().Location, new SizeF(ef5.Width, A_5[i].method_69().Height)));
                    }
                    else if (A_5[i].method_73() is Class542)
                    {
                        Class542 class2 = A_5[i].method_73() as Class542;
                        class2.method_1(A_1[i].TrimEnd(new char[] { ' ' }));
                        SizeF ef9 = class2.Interface2.imethod_3(A_6);
                        float num5 = A_5[i].method_69().Width - ef9.Width;
                        A_4 = A_5[i].method_73().imethod_0().imethod_34() ? ((double) num5) : (num5 + A_4);
                        A_5[i].method_70(new RectangleF(A_5[i].method_69().Location, new SizeF(ef9.Width, A_5[i].method_69().Height)));
                    }
                    A_5[i].method_41(true);
                    return;
                }
            }
        }
    }

    private double method_111(Paragraph A_0, Struct1 A_1, Class196 A_2, Class375 A_3)
    {
        if (A_1.method_11() <= 0.0)
        {
            return 0.0;
        }
        double num = 0.0;
        double height = A_3.method_69().Height;
        float single1 = A_3.method_71().method_69().Height;
        double width = A_3.method_71().method_69().Width;
        double num4 = A_1.method_22() ? A_1.method_13() : A_1.method_8();
        Math.Abs((double) (num4 - height));
        LineSpacingRule lineSpacingRule = A_0.Format.LineSpacingRule;
        if (lineSpacingRule != LineSpacingRule.Multiple)
        {
            float num5 = Math.Abs(A_0.Format.LineSpacing);
            switch (lineSpacingRule)
            {
                case LineSpacingRule.AtLeast:
                    num4 = Math.Max(num4, (double) num5);
                    break;

                case LineSpacingRule.Exactly:
                    num4 = num5;
                    break;
            }
        }
        if ((lineSpacingRule == LineSpacingRule.AtLeast) && (Class59.smethod_5(width, 0.0, 0.005) <= 0))
        {
            return 0.0;
        }
        TextRange range = null;
        Struct1 struct2 = new Struct1();
        if ((A_3.method_73() is TextRange) || (A_3.method_73() is Class542))
        {
            range = (A_3.method_73() is TextRange) ? (A_3.method_73() as TextRange) : ((A_3.method_73() as Class542).method_2() as TextRange);
            struct2 = A_2.method_335(range);
        }
        else if (A_3.method_73() is Footnote)
        {
            struct2 = A_2.method_331(A_3.method_73() as Footnote);
        }
        else if (A_3.method_73() is Symbol)
        {
            struct2.method_1((double) A_2.method_330(A_3.method_73() as Symbol));
        }
        switch (A_0.Format.TextAlignment)
        {
            case TextAlignment.Center:
                num = (num4 - ((struct2.method_7() == 0.0) ? height : struct2.method_7())) / 2.0;
                break;

            case TextAlignment.Baseline:
            case TextAlignment.Auto:
            {
                double num6 = num4 * A_1.method_3();
                num = num6 - ((struct2.method_7() == 0.0) ? (height + A_1.method_14()) : struct2.method_0());
                break;
            }
            case TextAlignment.Bottom:
                num = num4 - ((struct2.method_7() == 0.0) ? height : struct2.method_7());
                break;
        }
        if (struct2.method_22())
        {
            num += struct2.method_26();
            if (struct2.method_26() <= 0.0)
            {
                double introduced16 = struct2.method_7();
                if (Class59.smethod_5(introduced16, struct2.method_11(), 0.005) != 0)
                {
                    double introduced17 = struct2.method_11();
                    double num7 = introduced17 - struct2.method_7();
                    num -= num7 * 0.5;
                }
            }
        }
        return num;
    }

    private float method_112(int A_0, double A_1, int[] A_2, int A_3)
    {
        float num2 = (A_0 != 0) ? (Convert.ToSingle(A_1) / ((float) A_0)) : 0f;
        this.method_59(Convert.ToSingle(A_1));
        for (int i = A_3; i < this.method_74().Count; i++)
        {
            if (num2 < 1f)
            {
                this.method_74().method_4(i).method_63(Convert.ToSingle(num2) * -1f);
            }
            else
            {
                this.method_74().method_4(i).method_63(Convert.ToSingle(num2));
            }
            this.method_74().method_4(i).method_59(A_2[i] * num2);
        }
        return num2;
    }

    internal bool method_113()
    {
        Class375 class2 = this.method_74().method_4(this.method_74().Count - 1);
        Interface1 interface2 = class2.method_73();
        while (class2 != null)
        {
            if (class2.method_74().Count <= 0)
            {
                break;
            }
            interface2 = class2.method_74().method_4(class2.method_74().Count - 1).method_73();
        }
        if (!(interface2 is Break) || (((interface2 as Break).BreakType != BreakType.PageBreak) && ((interface2 as Break).BreakType != BreakType.ColumnBreak)))
        {
            return false;
        }
        return true;
    }

    internal void method_114()
    {
        if ((this.class376_0 != null) && (this.class376_0.Count > 0))
        {
            this.class376_0.method_10();
        }
        if ((this.interface1_0 != null) && (this.interface1_0 is DocumentBase))
        {
            (this.interface1_0 as DocumentBase).ResetLayoutInfo();
        }
    }

    internal float method_115()
    {
        float num = 0f;
        if (this.method_73() is TableRow)
        {
            int num2 = 0;
            int count = this.method_74().Count;
            while (num2 < count)
            {
                Class375 class2 = this.method_74().method_4(num2);
                if (((class2.method_73() is TableCell) && (class2.method_74().Count > 0)) && (class2.method_74().method_4(0).method_73() is TableCell))
                {
                    num = Math.Max(num, class2.method_74().method_4(0).method_69().Height);
                }
                num2++;
            }
        }
        return num;
    }

    internal float method_116()
    {
        float num = 0f;
        foreach (Class375 class2 in this.method_74())
        {
            num = Math.Max(num, class2.method_18());
        }
        return num;
    }

    internal float method_117()
    {
        float num = 0f;
        foreach (Class375 class2 in this.method_74())
        {
            num = Math.Max(num, class2.method_69().Width);
        }
        return num;
    }

    internal bool method_118()
    {
        bool flag;
        using (List<Class375>.Enumerator enumerator = this.method_74().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class375 current = enumerator.Current;
                if (current.method_69().Top <= this.rectangleF_0.Top)
                {
                    goto Label_003D;
                }
            }
            return true;
        Label_003D:
            flag = false;
        }
        return flag;
    }

    private void method_119(Class196 A_0, out double A_1, out double A_2, out double A_3)
    {
        int num = 4;
        A_1 = 0.0;
        A_2 = 0.0;
        A_3 = 0.0;
        for (int i = 0; i < this.method_74().Count; i++)
        {
            Class375 class2 = this.method_74().method_4(i);
            if (((class2.method_69().Height > 0f) && (class2 != null)) && !class2.method_73().imethod_0().imethod_12())
            {
                A_1 = Math.Max(A_1, (double) class2.method_69().Height);
                if (!(class2.method_73() is Interface21) && !(class2.method_73() is Class542))
                {
                    if (class2.method_73() is Symbol)
                    {
                        Struct1 struct4 = A_0.method_336(class2.method_73() as Symbol);
                        double num5 = struct4.method_0();
                        if (this.struct1_0.method_0() < num5)
                        {
                            this.struct1_0 = struct4;
                            this.int_1 = i;
                        }
                    }
                    else if ((!(class2.method_73() is BookmarkEnd) && !(class2.method_73() is BookmarkStart)) && !(class2.method_73() is FieldMark))
                    {
                        A_2 = A_1;
                        if (class2.method_73().imethod_0().imethod_14())
                        {
                            if ((class2.method_73() is ShapeObject) && (class2.method_73() as ShapeObject).IsHorizontalRule)
                            {
                                Struct1 struct2 = A_0.method_337(class2.method_73() as ShapeObject);
                                double num3 = struct2.method_0();
                                if (this.struct1_0.method_0() < num3)
                                {
                                    this.struct1_0 = struct2;
                                    this.int_1 = i;
                                }
                            }
                            A_3 = Math.Max(A_3, (double) class2.method_69().Height);
                        }
                    }
                }
                else
                {
                    Interface21 interface2 = null;
                    if (class2.method_73() is Interface21)
                    {
                        interface2 = class2.method_73() as Interface21;
                    }
                    else
                    {
                        Class542 class3 = class2.method_73() as Class542;
                        if (class3 != null)
                        {
                            interface2 = class3.method_2();
                        }
                    }
                    if (interface2 != null)
                    {
                        Struct1 struct3 = interface2.imethod_11(A_0, true);
                        double num4 = struct3.method_0();
                        if ((class2.method_73() is CheckBoxFormField) && ((class2.method_73() as CheckBoxFormField).SizeType == CheckBoxSizeType.Auto))
                        {
                            num4 = A_0.method_1() ? ((double) A_0.method_309(BookmarkStart.b("਩", num), A_0.method_376((class2.method_73() as CheckBoxFormField).CharacterFormat), null).Height) : ((double) A_0.method_316(BookmarkStart.b("਩", num), (class2.method_73() as CheckBoxFormField).CharacterFormat.Font, null).Height);
                        }
                        A_2 = Math.Max(A_2, num4);
                        if (this.struct1_0.method_0() < num4)
                        {
                            this.struct1_0 = struct3;
                            this.int_1 = i;
                        }
                    }
                }
            }
        }
    }

    internal float method_12()
    {
        return this.float_11;
    }

    internal void method_13(float A_0)
    {
        this.float_11 = A_0;
    }

    internal bool method_14()
    {
        return this.bool_4;
    }

    internal void method_15(bool A_0)
    {
        this.bool_4 = A_0;
    }

    internal float method_16()
    {
        return this.float_10;
    }

    internal void method_17(float A_0)
    {
        this.float_10 = A_0;
    }

    internal float method_18()
    {
        return this.float_9;
    }

    internal void method_19(float A_0)
    {
        this.float_9 = A_0;
    }

    internal Field method_2()
    {
        return this.field_0;
    }

    internal float method_20()
    {
        return this.float_8;
    }

    internal void method_21(float A_0)
    {
        this.float_8 = A_0;
    }

    [CompilerGenerated]
    internal float method_22()
    {
        return this.float_13;
    }

    [CompilerGenerated]
    internal void method_23(float A_0)
    {
        this.float_13 = A_0;
    }

    internal float method_24()
    {
        return this.float_4;
    }

    internal void method_25(float A_0)
    {
        this.float_4 = A_0;
    }

    internal float method_26()
    {
        return this.float_5;
    }

    internal void method_27(float A_0)
    {
        this.float_5 = A_0;
    }

    internal float method_28()
    {
        return this.float_6;
    }

    internal void method_29(float A_0)
    {
        this.float_6 = A_0;
    }

    internal void method_3(Field A_0)
    {
        this.field_0 = A_0;
    }

    [CompilerGenerated]
    internal bool method_30()
    {
        return this.bool_6;
    }

    [CompilerGenerated]
    internal void method_31(bool A_0)
    {
        this.bool_6 = A_0;
    }

    [CompilerGenerated]
    internal bool method_32()
    {
        return this.bool_7;
    }

    [CompilerGenerated]
    internal void method_33(bool A_0)
    {
        this.bool_7 = A_0;
    }

    [CompilerGenerated]
    internal bool method_34()
    {
        return this.bool_8;
    }

    [CompilerGenerated]
    internal void method_35(bool A_0)
    {
        this.bool_8 = A_0;
    }

    [CompilerGenerated]
    internal bool method_36()
    {
        return this.bool_9;
    }

    [CompilerGenerated]
    internal void method_37(bool A_0)
    {
        this.bool_9 = A_0;
    }

    [CompilerGenerated]
    internal bool method_38()
    {
        return this.bool_10;
    }

    [CompilerGenerated]
    internal void method_39(bool A_0)
    {
        this.bool_10 = A_0;
    }

    internal int method_4()
    {
        return this.int_2;
    }

    [CompilerGenerated]
    internal bool method_40()
    {
        return this.bool_11;
    }

    [CompilerGenerated]
    internal void method_41(bool A_0)
    {
        this.bool_11 = A_0;
    }

    [CompilerGenerated]
    internal bool method_42()
    {
        return this.bool_12;
    }

    [CompilerGenerated]
    internal void method_43(bool A_0)
    {
        this.bool_12 = A_0;
    }

    [CompilerGenerated]
    internal bool method_44()
    {
        return this.bool_13;
    }

    [CompilerGenerated]
    internal void method_45(bool A_0)
    {
        this.bool_13 = A_0;
    }

    [CompilerGenerated]
    internal bool method_46()
    {
        return this.bool_14;
    }

    [CompilerGenerated]
    internal void method_47(bool A_0)
    {
        this.bool_14 = A_0;
    }

    internal TabJustification method_48()
    {
        return this.tabJustification_0;
    }

    internal void method_49(TabJustification A_0)
    {
        this.tabJustification_0 = A_0;
    }

    internal void method_5(int A_0)
    {
        this.int_2 = A_0;
    }

    public int method_50()
    {
        return this.int_0;
    }

    public void method_51(int A_0)
    {
        this.int_0 = A_0;
    }

    public bool method_52()
    {
        return this.bool_1;
    }

    public void method_53(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public bool method_54()
    {
        return this.bool_2;
    }

    public void method_55(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal bool method_56()
    {
        return this.bool_3;
    }

    internal void method_57(bool A_0)
    {
        this.bool_3 = true;
    }

    public float method_58()
    {
        return this.float_3;
    }

    public void method_59(float A_0)
    {
        this.float_3 = A_0;
    }

    internal RectangleF? method_6()
    {
        return this.nullable_0;
    }

    public HorizontalAlignment method_60()
    {
        return this.horizontalAlignment_0;
    }

    public void method_61(HorizontalAlignment A_0)
    {
        this.horizontalAlignment_0 = A_0;
    }

    public float method_62()
    {
        return this.float_2;
    }

    public void method_63(float A_0)
    {
        this.float_2 = Math.Abs(Convert.ToSingle(A_0));
    }

    public string method_64()
    {
        return this.string_0;
    }

    public void method_65(string A_0)
    {
        this.string_0 = A_0;
    }

    internal bool method_66()
    {
        return this.bool_0;
    }

    internal void method_67(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal List<RectangleF> method_68()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<RectangleF>();
        }
        return this.list_0;
    }

    public RectangleF method_69()
    {
        return this.rectangleF_0;
    }

    internal Struct1 method_7()
    {
        return this.struct1_0;
    }

    public void method_70(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }

    internal Class375 method_71()
    {
        return this.class375_0;
    }

    internal Class500 method_72()
    {
        if (this.class500_0 != null)
        {
            return this.class500_0;
        }
        if (this.class375_0 != null)
        {
            return this.class375_0.method_72();
        }
        return null;
    }

    internal Interface1 method_73()
    {
        return this.interface1_0;
    }

    public Class376 method_74()
    {
        if (this.class376_0 == null)
        {
            this.class376_0 = new Class376(this);
        }
        return this.class376_0;
    }

    public Class375 method_75()
    {
        if (this.method_71() != null)
        {
            int index = this.method_71().method_74().IndexOf(this);
            int count = this.method_71().method_74().Count;
            if ((index >= 1) && (index <= (count - 1)))
            {
                return this.method_71().method_74().method_4(index - 1);
            }
        }
        return null;
    }

    public Class375 method_76()
    {
        if (this.method_71() != null)
        {
            int index = this.method_71().method_74().IndexOf(this);
            int count = this.method_71().method_74().Count;
            if ((index >= 0) && (index <= (count - 2)))
            {
                return this.method_71().method_74().method_4(index + 1);
            }
        }
        return null;
    }

    [CompilerGenerated]
    internal int method_77()
    {
        return this.int_3;
    }

    [CompilerGenerated]
    internal void method_78(int A_0)
    {
        this.int_3 = A_0;
    }

    [CompilerGenerated]
    internal bool method_79()
    {
        return this.bool_15;
    }

    internal float method_8()
    {
        return this.float_12;
    }

    [CompilerGenerated]
    internal void method_80(bool A_0)
    {
        this.bool_15 = A_0;
    }

    private float method_81()
    {
        float maxValue = float.MaxValue;
        if (this.method_74().Count != 0)
        {
            int num2 = 0;
            int count = this.method_74().Count;
            while (num2 < count)
            {
                Class375 class2 = this.method_74().method_4(num2);
                if ((class2.method_73() is Table) && ((class2.method_73() as Table).TableFormat.HorizontalAlignment == RowAlignment.Left))
                {
                    maxValue = Math.Min(class2.method_69().X, maxValue);
                }
                if ((class2.method_73() is Paragraph) && ((class2.method_73() as Paragraph).Format.HorizontalAlignment == HorizontalAlignment.Left))
                {
                    maxValue = Math.Min(class2.method_69().X, maxValue);
                }
                num2++;
            }
        }
        return maxValue;
    }

    internal float method_82(TextRange A_0, Class196 A_1)
    {
        List<TextRange> list = new List<TextRange>();
        new List<Class216>();
        Class542 class2 = null;
        for (int i = this.method_77(); i < this.method_74().Count; i++)
        {
            Class375 class3 = this.method_74().method_4(i);
            TextRange item = null;
            if (class3.method_73() is TextRange)
            {
                item = class3.method_73() as TextRange;
                list.Add(item);
            }
            else if (class3.method_73() is Class542)
            {
                class2 = class3.method_73() as Class542;
            }
        }
        this.method_83(list, class2, A_1);
        if (A_0 != null)
        {
            A_0.method_33(A_1, true);
            this.method_86(A_0.CompressedPunctuations, A_0.TextLength);
            if (list.Count > 0)
            {
                this.method_85(list[list.Count - 1], A_0);
            }
            else if (class2 != null)
            {
                this.method_84(class2, A_0);
            }
        }
        else if ((list.Count > 0) && (class2 == null))
        {
            TextRange range = list[list.Count - 1];
            if ((((range.interface23_0 as Class205).method_11().Count > 0) && (range.TextLength > 0)) && Class203.smethod_1(range.Text[range.TextLength - 1]))
            {
                (range.interface23_0 as Class205).method_11().RemoveAt((range.interface23_0 as Class205).method_11().Count - 1);
            }
        }
        float num2 = 0f;
        num2 += (class2 != null) ? class2.method_4() : 0f;
        for (int j = 0; j < list.Count; j++)
        {
            num2 += list[j].method_30();
        }
        return (num2 / 2f);
    }

    private void method_83(List<TextRange> A_0, Class542 A_1, Class196 A_2)
    {
        new List<Class216>();
        if ((A_1 != null) && (A_1.method_3().Count > 0))
        {
            this.method_86(A_1.method_3(), A_1.method_0().Length);
            if (A_0.Count > 0)
            {
                A_0[0].method_33(A_2, true);
                this.method_86(A_0[0].CompressedPunctuations, A_0[0].TextLength);
                this.method_84(A_1, A_0[0]);
            }
        }
        int num2 = ((A_1 == null) || (A_1.method_3().Count <= 0)) ? 0 : 1;
        for (int i = num2; i < A_0.Count; i++)
        {
            A_0[i].method_33(A_2, true);
            this.method_86(A_0[i].CompressedPunctuations, A_0[i].TextLength);
            if (i > 0)
            {
                this.method_85(A_0[i - 1], A_0[i]);
            }
        }
    }

    private void method_84(Class542 A_0, TextRange A_1)
    {
        if (A_0 != null)
        {
            if ((!string.IsNullOrEmpty(A_0.method_0()) && Class203.smethod_3(A_0.method_0()[A_0.method_0().Length - 1])) && (!Class203.smethod_1(A_1.Text[0]) && (A_0.method_3().Count > 0)))
            {
                A_0.method_3().RemoveAt(A_0.method_3().Count - 1);
            }
            if ((!string.IsNullOrEmpty(A_0.method_0()) && !Class203.smethod_2(A_0.method_0()[A_0.method_0().Length - 1])) && (Class203.smethod_2(A_1.Text[0]) && ((A_1.interface23_0 as Class205).method_11().Count > 0)))
            {
                (A_1.interface23_0 as Class205).method_11().RemoveAt(0);
            }
        }
    }

    private void method_85(TextRange A_0, TextRange A_1)
    {
        if (A_0 != null)
        {
            if (((A_0.interface23_0 as Class205).method_11().Count > 0) && ((((A_1.Text.Length > 0) && (A_0.TextLength > 0)) && (Class203.smethod_1(A_0.Text[A_0.TextLength - 1]) && !Class203.smethod_1(A_1.Text[0]))) || (Class203.smethod_1(A_0.Text[A_0.TextLength - 1]) && (A_1.CompressedPunctuations.Count == 0))))
            {
                (A_0.interface23_0 as Class205).method_11().RemoveAt((A_0.interface23_0 as Class205).method_11().Count - 1);
            }
            if ((((A_1.interface23_0 as Class205).method_11().Count > 0) && (A_0.TextLength > 0)) && (!Class203.smethod_2(A_0.Text[A_0.TextLength - 1]) && Class203.smethod_2(A_1.Text[0])))
            {
                (A_1.interface23_0 as Class205).method_11().RemoveAt(0);
            }
        }
    }

    private void method_86(List<Class216> A_0, int A_1)
    {
        if ((A_0.Count == 1) && (A_0[0].method_0() != (A_1 - 1)))
        {
            this.method_87(A_0[0]);
        }
        else if (A_0.Count > 1)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                if (((i == 0) && (A_0[i].method_0() != 0)) && Class203.smethod_2(A_0[i].method_4()))
                {
                    this.method_87(A_0[i]);
                    A_0.RemoveAt(i);
                    i--;
                }
                else if (((i == (A_0.Count - 1)) && (A_0[i].method_0() != (A_1 - 1))) && Class203.smethod_3(A_0[i].method_4()))
                {
                    this.method_87(A_0[i]);
                    A_0.RemoveAt(i);
                    i--;
                }
                else if ((((i > 0) && Class203.smethod_2(A_0[i].method_4())) && ((A_0[i - 1].method_0() + 1) != A_0[i].method_0())) || (((i < (A_0.Count - 1)) && Class203.smethod_3(A_0[i].method_4())) && ((A_0[i].method_0() + 1) != A_0[i + 1].method_0())))
                {
                    this.method_87(A_0[i]);
                    A_0.RemoveAt(i);
                    i--;
                }
            }
        }
    }

    private void method_87(Class216 A_0)
    {
        if ((A_0.method_8() is TextRange) && (((A_0.method_8() as TextRange).interface23_0 as Class205).method_11().Count > 0))
        {
            ((A_0.method_8() as TextRange).interface23_0 as Class205).method_11().Remove(A_0);
        }
        else if ((A_0.method_8() is Class542) && ((A_0.method_8() as Class542).method_3().Count > 0))
        {
            (A_0.method_8() as Class542).method_3().Remove(A_0);
        }
    }

    public void method_88(Class196 A_0)
    {
        int num = 3;
        if (this.method_32())
        {
            if ((((this.interface1_0 is Table) && (this.interface1_0 as Table).IsTextBox) && ((((this.interface1_0 as Table).TextBox as TextBox).ShapeInfo != null) && (((this.interface1_0 as Table).TextBox as TextBox).ShapeInfo.TextWrappingStyle == TextWrappingStyle.Inline))) && !A_0.method_1())
            {
                this.nullable_0 = new RectangleF?(A_0.method_151().ClipBounds);
            }
        }
        else
        {
            this.interface1_0.imethod_1(A_0, this);
            if ((this.interface1_0 is Section) && (this.method_64() == BookmarkStart.b("樨䐪䄬娮尰崲昴制䤸娺似帾㕀⩂⩄⥆Ո≊⍌⩎", num)))
            {
                A_0.method_266(this);
            }
            int num5 = 0;
            int count = this.method_74().Count;
            while (num5 < count)
            {
                Class375 class2 = this.method_74().method_4(num5);
                if (class2 != null)
                {
                    if ((((this.interface1_0 is Class65) && (num5 == 0)) && ((class2.method_73() is Table) && (class2.method_74().Count > 0))) && (((class2.method_74().method_4(0).method_73() is TableRow) && (class2.method_74().method_4(0).method_74().Count > 0)) && (class2.method_74().method_4(0).method_74().method_4(0).method_73() is TableCell)))
                    {
                        foreach (Class375 class3 in class2.method_74().method_4(0).method_74())
                        {
                            if (class3.method_73() is TableCell)
                            {
                                class3.method_57(true);
                            }
                        }
                    }
                    if (class2.method_73() is Table)
                    {
                        float angle = 0f;
                        if (((class2.method_73() as Table).TextBoxFormat != null) && ((class2.method_73() as Table).TextBoxFormat.Rotation != 0f))
                        {
                            angle = (class2.method_73() as Table).TextBoxFormat.Rotation;
                        }
                        if (angle != 0f)
                        {
                            GraphicsState gstate = null;
                            RectangleF ef6 = class2.method_69();
                            if (A_0.method_1())
                            {
                                A_0.method_126().method_4();
                                spr➂ r➂ = new spr➂();
                                r➂.ᜀ(ef6.X + (ef6.Width / 2f), ef6.Y + (ef6.Height / 2f));
                                r➂.ᜀ(angle);
                                r➂.ᜀ(-(ef6.X + (ef6.Width / 2f)), -(ef6.Y + (ef6.Height / 2f)));
                                A_0.method_126().method_0().᜜().ᜏ().ᜀ(r➂.ᜐ(), r➂.ᜓ(), r➂.᜕(), r➂.ᜌ(), r➂.ᜊ(), r➂.ᜍ());
                            }
                            else
                            {
                                gstate = A_0.method_151().Save();
                                A_0.method_151().TranslateTransform(ef6.X + (ef6.Width / 2f), ef6.Y + (ef6.Height / 2f));
                                A_0.method_151().RotateTransform(angle);
                                A_0.method_151().TranslateTransform(-(ef6.X + (ef6.Width / 2f)), -(ef6.Y + (ef6.Height / 2f)));
                            }
                            class2.method_88(A_0);
                            if (A_0.method_1())
                            {
                                A_0.method_126().method_5();
                            }
                            else
                            {
                                A_0.method_151().Restore(gstate);
                            }
                        }
                        else
                        {
                            class2.method_88(A_0);
                        }
                    }
                    else if (((class2.method_73() is TableRow) && (class2.method_73() as TableRow).OwnerTable.IsFrame) && !this.method_69().IsEmpty)
                    {
                        RectangleF ef3 = class2.method_69();
                        Table ownerTable = (class2.method_73() as TableRow).OwnerTable;
                        bool flag = false;
                        if ((ownerTable.FrameFormat.FrameHeightRule == FrameSizeRule.Exact) && (ownerTable.FrameFormat.FrameHeightEx < ef3.Height))
                        {
                            ef3.Height = ownerTable.FrameFormat.FrameHeightEx;
                            flag = true;
                        }
                        if (ef3.X >= ownerTable.TableBounds.Right)
                        {
                            flag = true;
                            ef3.X = ownerTable.TableBounds.X;
                        }
                        if (ef3.Y >= ownerTable.TableBounds.Bottom)
                        {
                            flag = true;
                            ef3.Y = ownerTable.TableBounds.Y;
                        }
                        if (flag)
                        {
                            ef3 = new RectangleF(ef3.X + ((float) this.interface1_0.imethod_0().imethod_0().method_0()), ef3.Y + ((float) this.interface1_0.imethod_0().imethod_0().method_4()), ef3.Width - ((float) this.interface1_0.imethod_0().imethod_0().method_8()), ef3.Height - ((float) this.interface1_0.imethod_0().imethod_0().method_12()));
                            if (A_0.method_1())
                            {
                                A_0.method_126().method_4();
                                A_0.method_126().method_6(ef3);
                                class2.method_88(A_0);
                                A_0.method_126().method_7();
                                A_0.method_126().method_5();
                            }
                            else
                            {
                                GraphicsState state5 = A_0.method_151().Save();
                                A_0.method_151().SetClip(ef3, CombineMode.Intersect);
                                class2.method_88(A_0);
                                A_0.method_151().ResetClip();
                                A_0.method_151().Restore(state5);
                            }
                        }
                        else
                        {
                            class2.method_88(A_0);
                        }
                    }
                    else if ((((this.interface1_0 is TableCell) && (class2.method_73() is TableCell)) && (((this.interface1_0 as TableCell).OwnerRow != null) && !this.method_69().IsEmpty)) && !(this.interface1_0 as TableCell).OwnerRow.OwnerTable.IsSDTTable)
                    {
                        RectangleF ef = this.method_69();
                        if ((this.interface1_0 as TableCell).OwnerRow.HeightType == TableRowHeightType.Exactly)
                        {
                            float height = Math.Abs((this.interface1_0 as TableCell).OwnerRow.Height);
                            if (((ef.Height > height) && (height != 0f)) && ((class2.method_73() as TableCell).CellFormat.VerticalMerge != CellMerge.Start))
                            {
                                ef = new RectangleF(ef.X, ef.Y, ef.Width, height);
                            }
                        }
                        if (class2.method_69().IsEmpty && (this.interface1_0 as TableCell).OwnerRow.OwnerTable.IsTextBox)
                        {
                            float num2 = class2.method_81();
                            if (Class59.smethod_4(num2, ef.X, 0.005f) < 0)
                            {
                                float num13 = ef.X - num2;
                                ef.X = num2;
                                ef.Width += num13;
                            }
                        }
                        if ((((this.interface1_0 as TableCell).OwnerRow.OwnerTable.TextBoxFormat != null) && (this.interface1_0.imethod_0().imethod_0() != null)) && (((ef.Width - (this.interface1_0.imethod_0().imethod_0().method_8() + this.interface1_0.imethod_0().imethod_0().method_0())) > 0.0) && ((ef.Height - (this.interface1_0.imethod_0().imethod_0().method_4() + this.interface1_0.imethod_0().imethod_0().method_12())) > 0.0)))
                        {
                            ef = new RectangleF(ef.X, ef.Y, ef.Width - ((float) this.interface1_0.imethod_0().imethod_0().method_8()), ef.Height - ((float) this.interface1_0.imethod_0().imethod_0().method_12()));
                        }
                        if (A_0.method_1())
                        {
                            A_0.method_126().method_4();
                            A_0.method_126().method_6(ef);
                            class2.method_88(A_0);
                            this.interface1_0.imethod_2(A_0, this);
                            A_0.method_126().method_7();
                            A_0.method_126().method_5();
                        }
                        else
                        {
                            GraphicsState state4 = A_0.method_151().Save();
                            A_0.method_151().SetClip(ef, CombineMode.Intersect);
                            class2.method_88(A_0);
                            A_0.method_151().ResetClip();
                            A_0.method_151().Restore(state4);
                        }
                    }
                    else if (((class2.method_74().Count > 0) && !(class2.method_74().method_4(0).method_73() is Paragraph)) && ((((class2.method_73() is Paragraph) && (class2.method_73() as Paragraph).Format.IsFrame) && !(class2.method_73() as Paragraph).IsInCell) || (((class2.method_73() is Class65) && ((class2.method_73() as Class65).method_2() is Paragraph)) && (((class2.method_73() as Class65).method_2() as Paragraph).Format.IsFrame && !((class2.method_73() as Class65).method_2() as Paragraph).IsInCell))))
                    {
                        class2.method_99();
                        RectangleF ef7 = (class2.method_71() != null) ? new RectangleF(class2.method_69().Location, new SizeF(Math.Max(class2.method_71().method_69().Width, class2.method_69().Width), class2.method_69().Height)) : class2.method_69();
                        ef7 = new RectangleF(ef7.X + ((float) this.interface1_0.imethod_0().imethod_0().method_0()), ef7.Y, ef7.Width - ((float) this.interface1_0.imethod_0().imethod_0().method_8()), ef7.Height);
                        if (class2.method_52())
                        {
                            ef7 = new RectangleF(ef7.X, ef7.Y + ((float) this.interface1_0.imethod_0().imethod_0().method_4()), ef7.Width, ef7.Height);
                        }
                        if (class2.method_54())
                        {
                            ef7 = new RectangleF(ef7.X, ef7.Y, ef7.Width, ef7.Height - ((float) this.interface1_0.imethod_0().imethod_0().method_12()));
                        }
                        if (A_0.method_1())
                        {
                            A_0.method_126().method_4();
                            A_0.method_126().method_6(ef7);
                            class2.method_88(A_0);
                            A_0.method_126().method_7();
                            A_0.method_126().method_5();
                        }
                        else
                        {
                            GraphicsState state2 = A_0.method_151().Save();
                            A_0.method_151().SetClip(ef7, CombineMode.Intersect);
                            class2.method_88(A_0);
                            A_0.method_151().ResetClip();
                            A_0.method_151().Restore(state2);
                        }
                    }
                    else if (((class2.method_74().Count > 0) && (((class2.method_73() is Paragraph) && !(class2.method_74().method_4(0).method_73() is Paragraph)) || (((class2.method_73() is Class65) && ((class2.method_73() as Class65).method_2() is Paragraph)) && !(class2.method_74().method_4(0).method_73() is Class65)))) && ((class2.method_73().imethod_0() as Class210).method_55() == LineSpacingRule.Exactly))
                    {
                        Class210 class4 = class2.method_73().imethod_0() as Class210;
                        float num7 = Math.Abs(class4.method_53());
                        float num9 = class4.method_23();
                        float num12 = class4.method_21();
                        class2.method_99();
                        float y = class2.method_89();
                        RectangleF ef2 = (class2.method_71() != null) ? new RectangleF(class2.method_69().Location, new SizeF(Math.Max(class2.method_71().method_69().Width, class2.method_69().Width), class2.method_69().Height)) : class2.method_69();
                        if ((y != float.MaxValue) && ((y - ef2.Top) > num7))
                        {
                            ef2 = new RectangleF(new PointF(ef2.X, y), ef2.Size);
                        }
                        float num4 = ef2.Height;
                        if (class2.method_52() && !class2.method_54())
                        {
                            ef2.Y -= num12;
                            num4 = (num7 + num12) + ((float) this.interface1_0.imethod_0().imethod_0().method_4());
                        }
                        else if (!class2.method_52() && class2.method_54())
                        {
                            num4 = num7 + num9;
                        }
                        else if (class2.method_52() && class2.method_54())
                        {
                            ef2.Y -= num12;
                            num4 = ((num7 + num12) + ((float) this.interface1_0.imethod_0().imethod_0().method_4())) + num9;
                        }
                        else
                        {
                            num4 = num7;
                        }
                        ef2 = new RectangleF(ef2.X, ef2.Y, ef2.Width, num4);
                        if (class2.method_73() is Paragraph)
                        {
                            Paragraph paragraph = class2.method_73() as Paragraph;
                            if (paragraph.IsInCell)
                            {
                                TableCell owner = paragraph.Owner as TableCell;
                                RectangleF ef13 = (class2.method_71().method_71().method_71().method_73() is TableCell) ? class2.method_71().method_71().method_71().method_69() : new RectangleF();
                                RectangleF ef16 = (((class2.method_73() is Class65) && ((class2.method_73() as Class65).method_2() is Paragraph)) || (class2.method_73() is Paragraph)) ? class2.method_71().method_69() : new RectangleF();
                                float x = !ef16.IsEmpty ? ef16.X : ef2.X;
                                switch (owner.CellFormat.TextDirection)
                                {
                                    case TextDirection.RightToLeft:
                                    case TextDirection.LeftToRight:
                                        ef2 = new RectangleF(new PointF(x, ef2.Y), new SizeF(ef2.Height, Math.Max(ef2.Width, ef13.Height)));
                                        break;
                                }
                            }
                        }
                        if (A_0.method_1())
                        {
                            A_0.method_126().method_4();
                            A_0.method_126().method_6(ef2);
                            class2.method_88(A_0);
                            A_0.method_126().method_7();
                            A_0.method_126().method_5();
                        }
                        else
                        {
                            GraphicsState state3 = A_0.method_151().Save();
                            A_0.method_151().SetClip(ef2, CombineMode.Intersect);
                            class2.method_88(A_0);
                            A_0.method_151().ResetClip();
                            A_0.method_151().Restore(state3);
                        }
                    }
                    else
                    {
                        class2.method_88(A_0);
                    }
                }
                num5++;
            }
            this.interface1_0.imethod_2(A_0, this);
        }
    }

    internal float method_89()
    {
        if (this.method_74().Count <= 0)
        {
            return this.method_69().Top;
        }
        float maxValue = float.MaxValue;
        foreach (Class375 class2 in this.method_74())
        {
            if (!class2.method_73().imethod_0().imethod_12())
            {
                ParagraphBase base2 = (class2.method_73() is ParagraphBase) ? (class2.method_73() as ParagraphBase) : ((!(class2.method_73() is Class542) || !((class2.method_73() as Class542).method_2() is ParagraphBase)) ? null : ((class2.method_73() as Class542).method_2() as ParagraphBase));
                if ((base2 != null) && (base2.CharacterFormat.Position == 0f))
                {
                    maxValue = Math.Min(maxValue, class2.method_69().Top);
                }
            }
        }
        return maxValue;
    }

    internal void method_9(float A_0)
    {
        this.float_12 = A_0;
    }

    public void method_90(Class375 A_0)
    {
        if (A_0 != null)
        {
            this.class375_0 = A_0;
            if (!this.class375_0.method_34() && this.method_34())
            {
                this.class375_0.method_35(this.method_34());
            }
        }
    }

    public void method_91(Class500 A_0)
    {
        if (A_0 != null)
        {
            this.class500_0 = A_0;
        }
    }

    private bool method_92(Class375 A_0)
    {
        return ((((A_0.method_73() is DocPicture) && ((A_0.method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)) && ((A_0.method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind)) || ((((A_0.method_73() is Table) && (A_0.method_73() as Table).IsTextBox) && ((A_0.method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline)) && ((A_0.method_73() as Table).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)));
    }

    public void method_93(double A_0, double A_1, bool A_2)
    {
        int num = 0;
        int count = this.method_74().Count;
        while (num < count)
        {
            Class375 class2 = this.method_74().method_4(num);
            if (!class2.method_73().imethod_0().imethod_12())
            {
                class2.method_94(A_0, A_1, A_2);
            }
            num++;
        }
    }

    public void method_94(double A_0, double A_1, bool A_2)
    {
        this.method_95(A_0, A_1, A_2, false);
    }

    public void method_95(double A_0, double A_1, bool A_2, bool A_3)
    {
        this.rectangleF_0 = new RectangleF(new PointF(this.rectangleF_0.X + ((float) A_0), this.rectangleF_0.Y + ((float) A_1)), this.rectangleF_0.Size);
        for (int i = 0; i < this.method_74().Count; i++)
        {
            if ((this.interface1_0 is TableCell) && !(this.interface1_0 as TableCell).OwnerRow.OwnerTable.IsTextBox)
            {
                (this.interface1_0.imethod_0() as Class211).method_118(this.rectangleF_0.Y);
            }
            Class375 class2 = this.method_74().method_4(i);
            if (class2 != null)
            {
                if (class2.method_73() is Table)
                {
                    Table table = class2.method_73() as Table;
                    if (((Interface4) table).imethod_3().imethod_13())
                    {
                        if (((table.IsTextBox && ((table.TextBox as TextBox).ShapeInfo != null)) && (((table.TextBox as TextBox).ShapeInfo.TextWrappingStyle == TextWrappingStyle.Inline) && (((Interface4) table).imethod_3().imethod_15().VertRelationTo == VerticalRelation.Paragraph))) && A_2)
                        {
                            class2.method_94(A_0, A_1, A_2);
                        }
                        else if ((((Interface4) table).imethod_3().imethod_15().VertRelationTo == VerticalRelation.Paragraph) && A_2)
                        {
                            class2.method_94(0.0, A_1, A_2);
                        }
                        continue;
                    }
                }
                if (class2.method_73() is TableCell)
                {
                    for (int j = 0; j < class2.method_68().Count; j++)
                    {
                        RectangleF ef = class2.method_68()[j];
                        ef.X += (float) A_0;
                        ef.Y += (float) A_1;
                        class2.method_68()[j] = ef;
                    }
                }
                if (class2.method_73() is DocPicture)
                {
                    DocPicture picture = class2.method_73() as DocPicture;
                    if (picture.TextWrappingStyle != TextWrappingStyle.Inline)
                    {
                        if ((((picture.VerticalOrigin == VerticalOrigin.Paragraph) || (picture.VerticalOrigin == VerticalOrigin.Line)) || (picture.VerticalOrigin == VerticalOrigin.BottomMarginArea)) && A_2)
                        {
                            class2.method_94(0.0, A_1, A_2);
                        }
                        continue;
                    }
                }
                if ((A_3 || !(class2.method_73() is Paragraph)) || (((class2.method_73() as Paragraph).IsInCell || !(class2.method_73() as Paragraph).Format.IsFrame) || ((class2.method_73() as Paragraph).Format.FrameVerticalPos == 2)))
                {
                    class2.method_95(A_0, A_1, A_2, A_3);
                }
            }
        }
        this.method_100();
    }

    public void method_96(PointF A_0)
    {
        if (!this.method_69().IsEmpty)
        {
            this.method_70(new RectangleF(this.method_69().X - A_0.X, this.method_69().Y - A_0.Y, this.method_69().Width, this.method_69().Height));
        }
        for (int i = 0; i < this.method_74().Count; i++)
        {
            if (this.method_74().method_4(i).method_74().Count > 0)
            {
                this.method_74().method_4(i).method_96(A_0);
            }
            else if (!this.method_74().method_4(i).method_69().IsEmpty)
            {
                this.method_74().method_4(i).method_70(new RectangleF(this.method_74().method_4(i).method_69().X - A_0.X, this.method_74().method_4(i).method_69().Y - A_0.Y, this.method_74().method_4(i).method_69().Width, this.method_74().method_4(i).method_69().Height));
            }
        }
        this.method_100();
    }

    public void method_97(float A_0, float A_1, float A_2, float A_3)
    {
        if ((this.rectangleF_0.Width > A_0) && (A_3 == 0f))
        {
            this.rectangleF_0 = new RectangleF(this.rectangleF_0.X, this.rectangleF_0.Y, A_0, this.rectangleF_0.Height);
        }
        else if ((this.rectangleF_0.Height > A_3) && (A_2 == 0f))
        {
            this.rectangleF_0 = new RectangleF(this.rectangleF_0.X, this.rectangleF_0.Y, this.rectangleF_0.Width, A_1);
        }
        for (int i = 0; i < this.method_74().Count; i++)
        {
            Class375 class2 = this.method_74().method_4(i);
            float num2 = 0f;
            for (int j = i - 1; j >= 0; j--)
            {
                if (i == 0)
                {
                    break;
                }
                if (((this.method_74().method_4(j) == null) || this.method_104(this.method_74().method_4(j))) && (this.method_74().method_4(j).method_73() is ParagraphBase))
                {
                    num2 += this.method_74().method_4(j).method_69().Width;
                }
            }
            if ((class2 != null) && this.method_104(class2))
            {
                DocumentObject owner = class2.method_73() as DocumentObject;
                while (!(owner is TableCell))
                {
                    if ((owner == null) || (owner is Table))
                    {
                        break;
                    }
                    owner = owner.Owner;
                }
                if ((owner is TableCell) && !(class2.method_73() is TableCell))
                {
                    if (A_3 == 0f)
                    {
                        A_0 = (A_2 - ((float) (((Interface1) (owner as TableCell)).imethod_0().imethod_1().method_0() + ((Interface1) (owner as TableCell)).imethod_0().imethod_0().method_0()))) - num2;
                    }
                    else
                    {
                        A_1 = A_3 - ((float) (((Interface1) (owner as TableCell)).imethod_0().imethod_1().method_4() + ((Interface1) (owner as TableCell)).imethod_0().imethod_0().method_4()));
                    }
                }
                if (A_0 < 0f)
                {
                    A_0 = 0f;
                }
                class2.method_97(A_0, A_1, A_2, A_3);
            }
        }
    }

    public void method_98()
    {
        PointF location = this.rectangleF_0.Location;
        float num = 0f;
        int num2 = 0;
        int count = this.method_74().Count;
        while (num2 < count)
        {
            num += this.method_74().method_4(num2).method_69().Width;
            num2++;
        }
        if (num != this.rectangleF_0.Width)
        {
            this.rectangleF_0.Width = num;
        }
    }

    private void method_99()
    {
        PointF location = this.rectangleF_0.Location;
        float num = 0f;
        int num2 = 0;
        int count = this.method_74().Count;
        while (num2 < count)
        {
            num += this.method_74().method_4(num2).method_69().Width;
            num2++;
        }
        if (num > this.rectangleF_0.Width)
        {
            this.rectangleF_0.Width = num;
        }
    }

    void IDisposable.Dispose()
    {
        if ((this.list_0 != null) && (this.list_0.Count > 0))
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if ((this.class376_0 != null) && (this.class376_0.Count > 0))
        {
            this.class376_0.Clear();
            this.class376_0 = null;
        }
    }
}

