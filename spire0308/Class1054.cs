using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;

internal class Class1054
{
    internal readonly bool bool_0;
    internal readonly bool bool_1;
    internal readonly bool bool_2;
    internal readonly bool bool_3;
    internal readonly bool bool_4;
    internal readonly bool bool_5;
    internal readonly bool bool_6;
    internal readonly Border border_0;
    internal readonly Border border_1;
    internal readonly Border border_2;
    internal readonly Border border_3;
    internal readonly Border border_4;
    internal readonly Border border_5;
    internal readonly Class15 class15_0;
    internal readonly Class16 class16_0;
    internal readonly int int_0;
    internal readonly int int_1;
    internal readonly int int_2;
    internal readonly int int_3;
    internal readonly int int_4;
    internal readonly int int_5;
    internal readonly object object_0;
    internal readonly string string_0;
    internal readonly string string_1;
    internal readonly string string_10;
    internal readonly string string_11;
    internal readonly string string_12;
    internal readonly string string_13;
    internal readonly string string_14;
    internal readonly string string_15;
    internal readonly string string_16;
    internal readonly string string_17;
    internal readonly string string_18;
    internal readonly string string_19;
    internal readonly string string_2;
    internal readonly string string_20;
    internal readonly string string_21;
    internal readonly string string_22;
    internal readonly string string_23;
    internal readonly string string_24;
    internal readonly string string_25;
    internal readonly string string_26;
    internal readonly string string_3;
    internal readonly string string_4;
    internal readonly string string_5;
    internal readonly string string_6;
    internal readonly string string_7;
    internal readonly string string_8;
    internal readonly string string_9;

    internal Class1054(RowFormat A_0, bool A_1, Interface52 A_2)
    {
        int num4 = 5;
        this.bool_1 = true;
        this.bool_4 = true;
        this.bool_6 = A_2.imethod_2();
        for (int i = 0; i < A_0.Count; i++)
        {
            int num2 = A_0.method_18(i);
            object obj2 = A_0.method_19(i);
            int num3 = num2;
            if (num3 <= 0x10a4)
            {
                if (num3 <= 0x100e)
                {
                    if (num3 <= 0xfa5)
                    {
                        switch (num3)
                        {
                            case 1:
                                if (!(obj2 as Borders).IsDefault)
                                {
                                    this.border_4 = (obj2 as Borders).Top;
                                    this.border_2 = (obj2 as Borders).Left;
                                    this.border_0 = (obj2 as Borders).Bottom;
                                    this.border_3 = (obj2 as Borders).Right;
                                    this.border_1 = (obj2 as Borders).Horizontal;
                                    this.border_5 = (obj2 as Borders).Vertical;
                                    this.int_1 += 6;
                                }
                                break;

                            case 3:
                                this.string_18 = A_2.imethod_1().method_23((obj2 as Paddings).Bottom, 20f).ToString();
                                this.string_17 = A_2.imethod_1().method_23((obj2 as Paddings).Left, 20f).ToString();
                                this.string_16 = A_2.imethod_1().method_23((obj2 as Paddings).Top, 20f).ToString();
                                this.string_19 = A_2.imethod_1().method_23((obj2 as Paddings).Right, 20f).ToString();
                                this.int_1 += 4;
                                break;

                            case 0x77:
                                this.bool_0 = (bool) obj2;
                                break;

                            case 120:
                            {
                                this.bool_0 = true;
                                RowFormat.TablePositioning positioning = obj2 as RowFormat.TablePositioning;
                                this.string_3 = (positioning.DistanceFromTop != 0f) ? A_2.imethod_1().method_23(positioning.DistanceFromTop, 20f).ToString() : null;
                                this.string_4 = (positioning.DistanceFromLeft != 9f) ? A_2.imethod_1().method_23(positioning.DistanceFromLeft, 20f).ToString() : null;
                                this.string_5 = (positioning.DistanceFromBottom != 0f) ? A_2.imethod_1().method_23(positioning.DistanceFromBottom, 20f).ToString() : null;
                                this.string_6 = (positioning.DistanceFromRight != 9f) ? A_2.imethod_1().method_23(positioning.DistanceFromRight, 20f).ToString() : null;
                                this.string_8 = Class417.smethod_16(Class417.smethod_21(positioning.HorizRelationTo));
                                this.string_7 = Class417.smethod_14((VerticalOrigin) positioning.VertRelationTo);
                                this.string_9 = (positioning.HorizPositionAbs != HorizontalPosition.Left) ? Class417.smethod_18(positioning.HorizPositionAbs) : null;
                                this.string_11 = (positioning.VertPositionAbs != VerticalPosition.None) ? Class417.smethod_23(positioning.VertPositionAbs) : null;
                                this.string_10 = A_2.imethod_1().method_23(positioning.HorizPositionEx, 20f).ToString();
                                this.string_12 = A_2.imethod_1().method_23(positioning.VertPositionEx, 20f).ToString();
                                this.bool_1 = positioning.TableOverlap;
                                break;
                            }
                            case 0xfa5:
                                if (obj2 != null)
                                {
                                    Style style = A_2.imethod_0().Styles.method_13((int) obj2, false);
                                    if (A_2.imethod_2())
                                    {
                                        this.string_0 = style.StyleId;
                                    }
                                    else
                                    {
                                        this.string_0 = A_2.imethod_4(style.Istd);
                                    }
                                }
                                break;
                        }
                    }
                    else
                    {
                        switch (num3)
                        {
                            case 0xfaa:
                            {
                                this.string_13 = Class859.smethod_1((RowAlignment) obj2);
                                this.int_0++;
                                this.int_1++;
                                continue;
                            }
                            case 0xfc8:
                            {
                                if ((bool) obj2)
                                {
                                    this.bool_3 = (bool) obj2;
                                    this.int_0++;
                                }
                                continue;
                            }
                        }
                        if (num3 == 0x100e)
                        {
                            TableRowHeightType type = (TableRowHeightType) obj2;
                            if (type != TableRowHeightType.AtLeast)
                            {
                                this.string_22 = Class859.smethod_3(type, this.bool_6);
                                this.int_0++;
                            }
                            if ((this.bool_6 && (type == TableRowHeightType.Auto)) && (this.string_21 == null))
                            {
                                this.string_21 = BookmarkStart.b("ᬪ", num4);
                            }
                        }
                    }
                }
                else if (num3 <= 0x1086)
                {
                    switch (num3)
                    {
                        case 0x1018:
                        {
                            this.string_21 = Class1041.smethod_8((int) A_2.imethod_1().method_23(obj2, 20f));
                            this.int_0++;
                            continue;
                        }
                        case 0x102c:
                        {
                            this.string_20 = Class1041.smethod_41(Class531.smethod_1((TableStyleOptions) obj2));
                            this.int_1++;
                            continue;
                        }
                    }
                    if (num3 == 0x1086)
                    {
                        this.class15_0 = (Class15) obj2;
                        if (this.bool_6)
                        {
                            this.int_1++;
                        }
                    }
                }
                else
                {
                    switch (num3)
                    {
                        case 0x1090:
                        {
                            if (!A_1)
                            {
                                this.object_0 = ((LayoutType) obj2) == LayoutType.AutoFit;
                                this.int_1++;
                            }
                            continue;
                        }
                        case 0x109a:
                        {
                            this.int_3 = (int) Math.Round((double) (obj2 as Class15).method_49());
                            if (this.int_3 > 0)
                            {
                                this.int_0++;
                            }
                            continue;
                        }
                    }
                    if (num3 == 0x10a4)
                    {
                        this.int_5 = (int) (obj2 as Class15).method_49();
                        if (this.int_5 > 0)
                        {
                            this.int_0++;
                        }
                    }
                }
            }
            else if (num3 <= 0x1130)
            {
                if (num3 <= 0x10f4)
                {
                    switch (num3)
                    {
                        case 0x10c2:
                        {
                            this.string_14 = A_2.imethod_1().method_23(obj2, 20f).ToString();
                            this.int_0++;
                            this.int_1++;
                            continue;
                        }
                        case 0x10ea:
                        {
                            this.class16_0 = (Class16) obj2;
                            this.int_1++;
                            continue;
                        }
                    }
                    if (num3 == 0x10f4)
                    {
                        this.string_15 = A_2.imethod_1().method_23(obj2, 20f).ToString();
                        this.int_1++;
                    }
                }
                else
                {
                    switch (num3)
                    {
                        case 0x1108:
                        {
                            if (!((bool) obj2))
                            {
                                this.bool_4 = (bool) obj2;
                                this.int_0++;
                            }
                            continue;
                        }
                        case 0x111c:
                        {
                            this.bool_2 = (bool) obj2;
                            continue;
                        }
                    }
                    if (num3 == 0x1130)
                    {
                        this.string_25 = Class114.smethod_5((int) obj2);
                    }
                }
            }
            else if (num3 <= 0x11a8)
            {
                switch (num3)
                {
                    case 0x1194:
                    {
                        this.string_1 = Class1041.smethod_9((long) obj2);
                        continue;
                    }
                    case 0x119e:
                    {
                        this.string_2 = Class1041.smethod_9((long) obj2);
                        continue;
                    }
                }
                if ((num3 == 0x11a8) && A_2.imethod_2())
                {
                    this.bool_5 = true;
                    this.int_0++;
                }
            }
            else
            {
                switch (num3)
                {
                    case 0x13f0:
                        this.int_2 = (int) obj2;
                        this.int_0++;
                        break;

                    case 0x13f1:
                        this.int_4 = (int) obj2;
                        this.int_0++;
                        break;

                    case 0x1392:
                        this.string_24 = (string) obj2;
                        break;

                    case 0x1388:
                        this.string_23 = (string) obj2;
                        break;
                }
            }
        }
        if (!A_1)
        {
            if (this.object_0 == null)
            {
                this.object_0 = A_0.LayoutType == LayoutType.AutoFit;
                this.int_1++;
            }
            if ((bool) this.object_0)
            {
                this.int_1--;
            }
        }
        if ((A_0.OwnerBase is Table) && ((A_0.OwnerBase as Table).TableStyle != null))
        {
            if (this.bool_6)
            {
                this.string_0 = (A_0.OwnerBase as Table).TableStyle.StyleId;
            }
            else
            {
                this.string_0 = A_2.imethod_5((A_0.OwnerBase as Table).TableStyle.StyleId);
            }
        }
    }
}

