using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Class619 : Class615
{
    private Class616 class616_0;
    private const float float_0 = 16f;
    private Regex regex_0;

    public Class619(Interface2 A_0, Interface30 A_1) : base(A_0, A_1)
    {
        this.regex_0 = new Regex(BookmarkStart.b("稥嬧", 0));
    }

    public Interface2 method_29()
    {
        return (base.interface1_1 as Interface2);
    }

    internal Class616 method_30()
    {
        return this.class616_0;
    }

    internal void method_31(Class616 A_0)
    {
        this.class616_0 = A_0;
    }

    private void method_32()
    {
        if (((base.layoutState_0 == LayoutState.Splitted) && (base.interface1_0 != null)) && (!string.IsNullOrEmpty((base.interface1_0 as Class542).method_0()) && Class203.smethod_3((base.interface1_0 as Class542).method_0()[0])))
        {
            if (this.method_30().method_5().method_74().Count <= 0)
            {
                if (base.class375_0.method_73() is Class542)
                {
                    this.method_34(base.class375_0);
                }
            }
            else
            {
                Class375 class2 = string.IsNullOrEmpty((base.class375_0.method_73() as Class542).method_0()) ? this.method_30().method_5().method_74().method_0() : base.class375_0;
                if (class2.method_73() is Interface19)
                {
                    if (class2.method_73() is TextRange)
                    {
                        this.method_33(class2);
                    }
                    else if (class2.method_73() is Class542)
                    {
                        this.method_34(class2);
                    }
                }
                else
                {
                    while ((class2.method_73() is BookmarkEnd) || (class2.method_73() is BookmarkStart))
                    {
                        this.method_30().method_5().method_74().method_12(this.method_30().method_5().method_74().Count - 1);
                        this.method_30().method_5().method_98();
                        Class616 class1 = this.method_30();
                        class1.method_33(class1.method_32() - 1);
                        class2 = this.method_30().method_5().method_74().method_0();
                    }
                    if (((((class2.method_73() is DocPicture) && ((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline)) || ((class2.method_73() is TextBox) && ((class2.method_73() as TextBox).Format.TextWrappingStyle == TextWrappingStyle.Inline))) || !(class2.method_73() is Interface19)) && (this.method_30().method_5().method_74().Count > 1))
                    {
                        this.method_30().method_5().method_74().method_12(this.method_30().method_5().method_74().Count - 1);
                        this.method_30().method_5().method_98();
                        Class616 class3 = this.method_30();
                        class3.method_33(class3.method_32() - 1);
                        base.interface1_0 = class2.method_73();
                        base.layoutState_0 = LayoutState.Splitted;
                    }
                    else if (class2.method_73() is TextRange)
                    {
                        this.method_33(class2);
                    }
                    else if (class2.method_73() is Class542)
                    {
                        this.method_34(class2);
                    }
                }
            }
        }
    }

    private void method_33(Class375 A_0)
    {
        string text = (A_0.method_73() as TextRange).Text;
        if (!string.IsNullOrEmpty(text))
        {
            Interface19[] interfaceArray2;
            string[] strArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if ((strArray.Length > 1) && ((A_0.method_73() as TextRange).CharacterCategory == CharacterCategory.Ascii))
            {
                interfaceArray2 = new Interface19[] { new Class542(A_0.method_73() as TextRange, text.Substring(0, text.LastIndexOf(strArray[strArray.Length - 1]))), new Class542(A_0.method_73() as TextRange, strArray[strArray.Length - 1]) };
            }
            else
            {
                int num = 1;
                while (num < text.Length)
                {
                    if (!Class203.smethod_3(text[text.Length - num]) && !char.IsDigit(text[text.Length - num]))
                    {
                        break;
                    }
                    num++;
                }
                interfaceArray2 = new Interface19[] { new Class542(A_0.method_73() as TextRange, text.Substring(0, text.Length - num)), new Class542(A_0.method_73() as TextRange, text.Substring(text.Length - num)) };
            }
            RectangleF ef = A_0.method_69();
            float width = interfaceArray2[1].imethod_3(base.method_4()).Width;
            this.method_30().method_5().method_74().method_5(this.method_30().method_5().method_74().Count - 1, new Class375(interfaceArray2[0]));
            this.method_30().method_5().method_74().method_4(this.method_30().method_5().method_74().Count - 1).method_70(new RectangleF(ef.X, ef.Y, ef.Width - width, ef.Height));
            Class616 class1 = this.method_30();
            class1.method_33(class1.method_32() - 1);
            base.interface1_0 = interfaceArray2[1];
            base.layoutState_0 = LayoutState.Splitted;
        }
    }

    private void method_34(Class375 A_0)
    {
        string str = (A_0.method_73() as Class542).method_0();
        if (!string.IsNullOrEmpty(str))
        {
            RectangleF ef = A_0.method_69();
            string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if ((strArray.Length > 1) && (((A_0.method_73() as Class542).method_2() as TextRange).CharacterCategory == CharacterCategory.Ascii))
            {
                (A_0.method_73() as Class542).method_1(str.Substring(0, str.LastIndexOf(strArray[strArray.Length - 1])));
                float num3 = ef.Width - (A_0.method_73() as Class542).Interface2.imethod_3(base.method_4()).Width;
                A_0.method_70(new RectangleF(ef.X, ef.Y, ef.Width - num3, ef.Height));
                base.interface1_0 = new Class542((A_0.method_73() as Class542).method_2(), strArray[strArray.Length - 1] + (base.interface1_0 as Class542).method_0());
            }
            else
            {
                int num = 1;
                while (num < str.Length)
                {
                    if (!Class203.smethod_3(str[str.Length - num]) && !char.IsDigit(str[str.Length - num]))
                    {
                        break;
                    }
                    num++;
                }
                if (num == str.Length)
                {
                    num = 0;
                }
                (A_0.method_73() as Class542).method_1(str.Substring(0, str.Length - num));
                float num2 = ef.Width - (A_0.method_73() as Class542).Interface2.imethod_3(base.method_4()).Width;
                A_0.method_70(new RectangleF(ef.X, ef.Y, ef.Width - num2, ef.Height));
                base.interface1_0 = new Class542((A_0.method_73() as Class542).method_2(), str.Substring(str.Length - num) + (base.interface1_0 as Class542).method_0());
            }
            base.layoutState_0 = LayoutState.Splitted;
        }
    }

    private bool method_35(Table A_0)
    {
        bool flag = false;
        if (A_0.IsTextBox)
        {
            return true;
        }
        if (A_0.IsInCell)
        {
            flag = this.method_35((A_0.Owner as TableCell).OwnerRow.OwnerTable);
        }
        return flag;
    }

    private Section method_36(DocumentObject A_0)
    {
        for (DocumentObject obj2 = A_0.Owner; obj2 != null; obj2 = obj2.Owner)
        {
            if (obj2 is Section)
            {
                return (obj2 as Section);
            }
        }
        return null;
    }

    private Paragraph method_37(Interface2 A_0)
    {
        Paragraph ownerParagraph = null;
        if (!(A_0 is TextRange) && (!(A_0 is Class542) || !((A_0 as Class542).method_2() is TextRange)))
        {
            if (A_0 is ParagraphBase)
            {
                ownerParagraph = (A_0 as ParagraphBase).OwnerParagraph;
            }
            return ownerParagraph;
        }
        TextRange range = (A_0 is TextRange) ? (A_0 as TextRange) : ((A_0 as Class542).method_2() as TextRange);
        if (range.OwnerParagraph != null)
        {
            return range.OwnerParagraph;
        }
        if (range.OwnerEmptyParagraph != null)
        {
            ownerParagraph = range.OwnerEmptyParagraph;
        }
        return ownerParagraph;
    }

    private bool method_38(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return false;
        }
        foreach (char ch in A_0)
        {
            if (!char.IsPunctuation(ch))
            {
                return false;
            }
        }
        return true;
    }

    private TextRange method_39(IDocumentObject A_0)
    {
        while (A_0 != null)
        {
            if (((A_0.NextSibling == null) || (A_0.NextSibling.DocumentObjectType == DocumentObjectType.Break)) || ((A_0.NextSibling is TextRange) && ((A_0.NextSibling as TextRange).DocumentObjectType == DocumentObjectType.TextRange)))
            {
                break;
            }
            A_0 = A_0.NextSibling;
        }
        if (A_0 == null)
        {
            return null;
        }
        return (A_0.NextSibling as TextRange);
    }

    private TextRange method_40(IDocumentObject A_0, ref int A_1)
    {
        while (A_0 != null)
        {
            if (((A_0.PreviousSibling == null) || (A_0.PreviousSibling.DocumentObjectType == DocumentObjectType.Break)) || ((A_0.PreviousSibling is TextRange) && ((A_0.PreviousSibling as TextRange).DocumentObjectType == DocumentObjectType.TextRange)))
            {
                break;
            }
            A_0 = A_0.PreviousSibling;
            A_1++;
        }
        if (A_0 == null)
        {
            return null;
        }
        return (A_0.PreviousSibling as TextRange);
    }

    private Class375 method_41(Interface2 A_0, SizeF A_1, RectangleF A_2, float A_3)
    {
        int num = 11;
        if (this.method_51(A_1.Width))
        {
            return null;
        }
        if ((A_0 is Symbol) && !A_0.imethod_0().imethod_36())
        {
            Symbol symbol = A_0 as Symbol;
            TextRange range = this.method_39(symbol);
            if (range != null)
            {
                string text = range.Text;
                if ((!text.StartsWith(BookmarkStart.b("ᄰ", num)) && (text.Length > 0)) && !Class203.smethod_1(text[0]))
                {
                    string[] strArray = this.method_42(range.Text);
                    if ((strArray != null) && (strArray.Length > 1))
                    {
                        text = strArray[0].TrimEnd(new char[] { ' ' });
                    }
                    else
                    {
                        text = range.Text.TrimEnd(new char[] { ' ' });
                    }
                    SizeF ef = base.method_4().method_323(range, text);
                    float num2 = (ef.Width > 0.5) ? -0.4f : -1f;
                    float num3 = (float) Math.Round((double) ((A_3 - A_1.Width) - ef.Width), 1);
                    if (num3 <= num2)
                    {
                        A_0.imethod_0().imethod_37(true);
                        base.layoutState_0 = LayoutState.NotFitted;
                    }
                }
            }
            goto Label_17CD;
        }
        bool flag = false;
        TextRange range2 = (A_0 is TextRange) ? (A_0 as TextRange) : ((A_0 is Class542) ? ((A_0 as Class542).method_2() as TextRange) : null);
        string str2 = (A_0 is TextRange) ? (A_0 as TextRange).Text : ((A_0 is Class542) ? (A_0 as Class542).method_0() : null);
        Class210 class2 = ((range2 == null) || !(range2.Owner is Paragraph)) ? null : ((range2.Owner as Interface1).imethod_0() as Class210);
        if ((((A_3 <= 0f) || (range2 == null)) || (range2.DocumentObjectType != DocumentObjectType.TextRange)) || (string.IsNullOrEmpty(str2) && ((str2 == null) || string.IsNullOrEmpty(range2.TextToSplit))))
        {
            goto Label_17CD;
        }
        TextRange range3 = this.method_39(range2);
        if (range3 == null)
        {
            goto Label_17CD;
        }
        string str3 = string.Empty;
        bool flag2 = false;
        float num4 = 0f;
        float clientWidth = A_3;
        Section section = range2.method_2();
        if (section != null)
        {
            clientWidth = section.PageSetup.ClientWidth;
        }
        string[] strArray2 = this.method_43(range3.Text);
        if ((strArray2 != null) && (strArray2.Length > 1))
        {
            str3 = strArray2[0].TrimEnd(new char[] { ' ' });
        }
        else
        {
            str3 = range3.Text.TrimEnd(new char[] { ' ' });
        }
        SizeF ef2 = base.method_4().method_323(range3, str3);
        if (((range2.Owner != null) && (range2.Owner.Owner != null)) && (range2.Owner.Owner is TableCell))
        {
            Paragraph paragraph = this.method_30().method_71(range2);
            Interface1 interface2 = paragraph;
            float num6 = (float) (interface2.imethod_0().imethod_1().method_0() + interface2.imethod_0().imethod_1().method_8());
            float num7 = (paragraph.Format.FirstLineIndent < 0f) ? paragraph.Format.FirstLineIndent : 0f;
            TableCell owner = range2.Owner.Owner as TableCell;
            float num8 = owner.CellFormat.SamePaddingsAsTable ? owner.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : owner.CellFormat.Paddings.PaddingWidth;
            num4 = (owner.LayoutWidth - num8) + num7;
            int num9 = 0;
            TextRange previousSibling = this.method_40(range2, ref num9);
            if ((previousSibling == null) || str2.Contains(BookmarkStart.b("ᄰ", num)))
            {
                if (((A_0 is TextRange) && (previousSibling == null)) && (!str2.Contains(BookmarkStart.b("ᄰ", num)) && ((A_1.Width + ef2.Width) > (num4 - num6))))
                {
                    return null;
                }
            }
            else
            {
                float width = A_1.Width;
                while (previousSibling != null)
                {
                    if ((previousSibling.DocumentObjectType != DocumentObjectType.TextRange) || previousSibling.Text.Contains(BookmarkStart.b("ᄰ", num)))
                    {
                        break;
                    }
                    Interface2 interface3 = previousSibling;
                    width += interface3.imethod_3(base.method_4()).Width;
                    previousSibling = previousSibling.PreviousSibling as TextRange;
                }
                if ((previousSibling != null) && previousSibling.Text.Contains(BookmarkStart.b("ᄰ", num)))
                {
                    string str4 = previousSibling.Text.Substring(previousSibling.Text.LastIndexOf(BookmarkStart.b("ᄰ", num)) + 1);
                    float num11 = base.method_4().method_1() ? base.method_4().method_309(str4, base.method_4().method_376(previousSibling.CharacterFormat), null).Width : base.method_4().method_316(str4, base.method_4().method_365(previousSibling.CharacterFormat), null).Width;
                    width += num11;
                }
                if ((width + ef2.Width) > (num4 - num6))
                {
                    return null;
                }
            }
            flag2 = true;
        }
        RectangleF ef4 = new RectangleF(A_2.Location, new SizeF(A_1.Width + ef2.Width, A_1.Height));
        Class312 class3 = base.method_4().method_28().method_51(ef4, range2);
        if ((section != null) && (section.PageSetup.CharacterSpacingControl != CharacterSpacing.doNotCompress))
        {
            float num12 = this.method_30().method_5().method_82(range2, base.method_4());
            this.method_30().method_5().method_5(this.method_30().method_5().method_74().Count);
            range3.method_33(base.method_4(), false);
            num12 += range3.method_31(false) / 2f;
            A_2.X -= num12;
            A_2.Width += num12;
            A_3 += num12;
            if (range3.interface23_0 == null)
            {
                range3.CompressedPunctuations.RemoveRange(0, range3.CompressedPunctuations.Count);
            }
            else
            {
                (range3.interface23_0 as Class205).method_11().RemoveRange(0, (range3.interface23_0 as Class205).method_11().Count);
            }
        }
        float num13 = (ef2.Width > 0.5) ? -0.4f : -1f;
        float num14 = (float) Math.Round((double) ((A_3 - A_1.Width) - ef2.Width), 1);
        bool flag3 = (str3.Length > 0) ? char.IsPunctuation(str3[str3.Length - 1]) : false;
        if (((num14 > num13) && (((num14 <= 0f) || class3.method_0().IsEmpty) || ((num14 - class3.method_0().Width) > 0f))) && (((num14 >= 0f) || (num14 <= num13)) || (!flag3 || range3.OwnerParagraph.Format.OverflowPunc)))
        {
            goto Label_17CD;
        }
        bool flag4 = false;
        Interface19[] interfaceArray = new Interface19[2];
        RectangleF ef6 = new RectangleF(new PointF(A_2.X - ((float) base.method_2().imethod_0().method_0()), A_2.Y - ((float) base.method_2().imethod_0().method_4())), new SizeF(0f, 0f));
        int num15 = 0;
        TextRange range5 = this.method_40(range2, ref num15);
        string str5 = string.Empty;
        if (range5 != null)
        {
            str5 = range5.Text;
            if (this.method_46(str5))
            {
                flag4 = true;
            }
        }
        if (((range2 != null) && (str2 == BookmarkStart.b("㠰", num))) && (range2.HasBeenSplitted || !class3.method_0().IsEmpty))
        {
            range2.HasBeenSplitted = false;
            return null;
        }
        if (((str2 == BookmarkStart.b("㠰", num)) && (str3 != BookmarkStart.b("㠰", num))) && (!str3.Contains(BookmarkStart.b("ᄰ", num)) && !str3.Contains(BookmarkStart.b("ᰰ", num))))
        {
            interfaceArray[0] = new Class542(range2, string.Empty);
            interfaceArray[1] = new Class542(range2, BookmarkStart.b("㠰", num));
            flag = true;
            range2.HasBeenSplitted = true;
        }
        else
        {
            int num21;
            TextRange range8;
            float num22;
            if ((((str2.EndsWith(BookmarkStart.b("ᄰ", num)) || str3.StartsWith(BookmarkStart.b("ᄰ", num))) || ((str2.Length <= 0) || (str3.Length <= 0))) || (((this.method_44(str2[str2.Length - 1]) && !Class203.smethod_2(str2[str2.Length - 1])) && (Class203.smethod_2(str2[str2.Length - 1]) || Class203.smethod_2(str3[0]))) || (char.IsPunctuation(str3, 0) && Class203.smethod_2(str3[0])))) || ((base.method_4().method_410(str2) || base.method_4().method_410(str3)) || flag4))
            {
                if ((((str2.Contains(BookmarkStart.b("ᄰ", num)) || this.method_46(str2)) || (str2.StartsWith(BookmarkStart.b("ᄰ", num)) || (str2.Length <= 0))) || ((!Class203.smethod_2(str2[str2.Length - 1]) || (range5 == null)) || (str5.EndsWith(BookmarkStart.b("ᄰ", num)) || str5.Contains(BookmarkStart.b("ᄰ", num))))) || flag4)
                {
                    if ((((range3.Text.Length <= 1) || range3.Text.Contains(BookmarkStart.b("ᄰ", num))) || (this.method_46(range3.Text) || str2.Contains(BookmarkStart.b("ᄰ", num)))) || this.method_46(str2))
                    {
                        if ((!(A_0 is Class542) && (range2.TextToSplit == BookmarkStart.b("㠰", num))) && !range3.Text.StartsWith(BookmarkStart.b("ᄰ", num)))
                        {
                            interfaceArray[0] = new Class542(range2, string.Empty);
                            interfaceArray[1] = new Class542(range2, BookmarkStart.b("㠰", num));
                            flag = true;
                            if (str2 == BookmarkStart.b("㠰", num))
                            {
                                range2.HasBeenSplitted = true;
                            }
                        }
                    }
                    else
                    {
                        int num26 = 0;
                        for (int i = str2.Length - 1; i >= 0; i--)
                        {
                            string str13 = str2.Substring(i, 1);
                            if (char.IsPunctuation(str13.ToCharArray()[0]) && Class203.smethod_1(str13.ToCharArray()[0]))
                            {
                                num26 = i + 1;
                                flag = true;
                                break;
                            }
                        }
                        if (flag)
                        {
                            num26 += Class203.smethod_4(str2, num26);
                            if ((num26 == 1) && Class203.smethod_2(range2.Text.ToCharArray()[0]))
                            {
                                interfaceArray[0] = new Class542(range2, string.Empty);
                                interfaceArray[1] = new Class542(range2, str2.TrimStart(new char[0]));
                                if (str2 == BookmarkStart.b("㠰", num))
                                {
                                    range2.HasBeenSplitted = true;
                                }
                            }
                            else
                            {
                                interfaceArray[0] = new Class542(range2, str2.Substring(0, num26));
                                interfaceArray[1] = new Class542(range2, str2.Substring(num26).TrimStart(new char[0]));
                                if (str2 == BookmarkStart.b("㠰", num))
                                {
                                    range2.HasBeenSplitted = true;
                                }
                            }
                        }
                    }
                    goto Label_1772;
                }
                num21 = 1;
                range8 = range5;
                num22 = ef2.Width;
                while (range8 != null)
                {
                    if ((range8.DocumentObjectType != DocumentObjectType.TextRange) || range8.Text.Contains(BookmarkStart.b("ᄰ", num)))
                    {
                        break;
                    }
                    Interface2 interface6 = range8;
                    num22 += interface6.imethod_3(base.method_4()).Width;
                    num21++;
                    range8 = range8.PreviousSibling as TextRange;
                }
            }
            else
            {
                int num17;
                TextRange range6;
                float num18;
                Paragraph ownerParagraph = range3.OwnerParagraph;
                if ((ownerParagraph != null) && Class203.smethod_1(str3[0]))
                {
                    string str6 = ownerParagraph.Text.Substring(range3.StartPos);
                    if ((str6.TrimEnd(new char[0]).Length == 1) || (((this.method_44(str2[str2.Length - 1]) && (str2.Length > 1)) && ((str6.Length > 1) && this.method_38(str2))) && this.method_38(str6)))
                    {
                        return null;
                    }
                }
                if ((((!str2.Contains(BookmarkStart.b("ᄰ", num)) && (str2.Length > 0)) && (this.method_38(str2) && (str3.Length > 1))) && ((char.IsPunctuation(str3[0]) && this.method_38(str3)) && ((str5.Length > 0) && char.IsPunctuation(str5[str5.Length - 1])))) && this.method_38(str5))
                {
                    return null;
                }
                if (!str2.Contains(BookmarkStart.b("ᄰ", num)))
                {
                    num17 = 0;
                    range6 = range2;
                    num18 = ef2.Width;
                    while (range6 != null)
                    {
                        if ((range6.DocumentObjectType != DocumentObjectType.TextRange) || range6.Text.Contains(BookmarkStart.b("ᄰ", num)))
                        {
                            break;
                        }
                        Interface2 interface4 = range6;
                        num18 += interface4.imethod_3(base.method_4()).Width;
                        num17++;
                        range6 = range6.PreviousSibling as TextRange;
                    }
                }
                else
                {
                    string str7 = str2;
                    int length = str7.LastIndexOf(' ');
                    string str8 = str7.Substring(0, length);
                    SizeF size = base.method_4().method_1() ? base.method_4().method_309(str8, base.method_4().method_376(range2.CharacterFormat), null) : base.method_4().method_316(str8, range2.CharacterFormat.Font, null);
                    ef4 = new RectangleF(A_2.Location, size);
                    for (class3 = base.method_4().method_28().method_51(ef4, range2); !class3.method_0().IsEmpty; class3 = base.method_4().method_28().method_51(ef4, range2))
                    {
                        length = str8.LastIndexOf(' ');
                        if (length <= 0)
                        {
                            break;
                        }
                        str8 = str8.Substring(0, length);
                        size = base.method_4().method_1() ? base.method_4().method_309(str8, base.method_4().method_376(range2.CharacterFormat), null) : base.method_4().method_316(str8, range2.CharacterFormat.Font, null);
                        ef4 = new RectangleF(A_2.Location, size);
                    }
                    if (class2 != null)
                    {
                        while (Class59.smethod_5((double) ef4.Right, (double) class2.method_85().Right, 0.005) > 0)
                        {
                            length = str8.LastIndexOf(' ');
                            if (length <= 0)
                            {
                                break;
                            }
                            str8 = str8.Substring(0, length);
                            size = base.method_4().method_1() ? base.method_4().method_309(str8, base.method_4().method_376(range2.CharacterFormat), null) : base.method_4().method_316(str8, range2.CharacterFormat.Font, null);
                            ef4 = new RectangleF(A_2.Location, size);
                        }
                    }
                    interfaceArray[0] = new Class542(range2, str7.Substring(0, length + 1));
                    interfaceArray[1] = new Class542(range2, str7.Substring(length + 1, (str7.Length - length) - 1).TrimStart(new char[0]));
                    flag = true;
                    if (str2 == BookmarkStart.b("㠰", num))
                    {
                        range2.HasBeenSplitted = true;
                    }
                    goto Label_1772;
                }
                if ((range6 != null) && !range6.Text.EndsWith(BookmarkStart.b("ᄰ", num)))
                {
                    string str9 = range6.Text.Substring(range6.Text.LastIndexOf(BookmarkStart.b("ᄰ", num)) + 1);
                    num18 += base.method_4().method_1() ? base.method_4().method_309(str9, base.method_4().method_376(range6.CharacterFormat), null).Width : base.method_4().method_316(str9, range6.CharacterFormat.Font, null).Width;
                }
                if (((flag2 && (num18 <= num4)) || (!flag2 && (num18 <= clientWidth))) && (((range6 != null) && (this.method_30().method_5().method_74().Count > 0)) && (num17 <= this.method_30().method_5().method_74().Count)))
                {
                    string str10 = range6.Text;
                    Interface1 interface5 = this.method_30().method_5().method_74().method_4(this.method_30().method_5().method_74().Count - num17).method_73();
                    if ((interface5 is TextRange) && (str10.Length != (interface5 as TextRange).Text.Length))
                    {
                        str10 = (interface5 as TextRange).Text;
                    }
                    else if ((interface5 is Class542) && (str10.Length != (interface5 as Class542).method_0().Length))
                    {
                        str10 = (interface5 as Class542).method_0();
                    }
                    if ((this.method_30().method_32() != num17) || ((this.method_30().method_32() == num17) && str10.Contains(BookmarkStart.b("ᄰ", num))))
                    {
                        this.method_30().method_33(this.method_30().method_32() - num17);
                        ef6 = this.method_30().method_5().method_74().method_4(this.method_30().method_5().method_74().Count - num17).method_69();
                        if (str10.Contains(BookmarkStart.b("ᄰ", num)))
                        {
                            int num19 = str10.LastIndexOf(' ');
                            interfaceArray[0] = new Class542(range6, str10.Substring(0, num19 + 1));
                            interfaceArray[1] = new Class542(range6, str10.Substring(num19 + 1, (str10.Length - num19) - 1).TrimStart(new char[] { ' ' }));
                            flag = true;
                            if (str2 == BookmarkStart.b("㠰", num))
                            {
                                range2.HasBeenSplitted = true;
                            }
                        }
                        else
                        {
                            TextRange range7 = range6;
                            if (range2.Document != null)
                            {
                                range7 = new TextRange(range2.Document);
                                range7.method_0(range6.Owner);
                                range7.CharacterFormat.Font = range6.CharacterFormat.Font;
                                range7.CharacterFormat.FontSize = range6.CharacterFormat.FontSize;
                            }
                            interfaceArray[0] = new Class542(range7, string.Empty);
                            interfaceArray[1] = new Class542(range6, str10.TrimStart(new char[0]));
                            flag = true;
                            if (str2 == BookmarkStart.b("㠰", num))
                            {
                                range2.HasBeenSplitted = true;
                            }
                        }
                        for (int j = 0; j < num17; j++)
                        {
                            this.method_30().method_5().method_74().method_12(this.method_30().method_5().method_74().Count - 1);
                        }
                        this.method_30().method_5().method_98();
                    }
                }
                goto Label_1772;
            }
            if ((range8 != null) && !range8.Text.EndsWith(BookmarkStart.b("ᄰ", num)))
            {
                string str11 = range8.Text.Substring(range8.Text.LastIndexOf(BookmarkStart.b("ᄰ", num)) + 1);
                float num23 = base.method_4().method_1() ? base.method_4().method_309(str11, base.method_4().method_376(range8.CharacterFormat), null).Width : base.method_4().method_316(str11, range8.CharacterFormat.Font, null).Width;
                num22 += num23;
            }
            if (((flag2 && (num22 <= num4)) || (!flag2 && (num22 <= clientWidth))) && ((range8 != null) && (num21 <= this.method_30().method_5().method_74().Count)))
            {
                string str12 = range8.Text;
                Interface1 interface7 = this.method_30().method_5().method_74().method_4(this.method_30().method_5().method_74().Count - num21).method_73();
                if ((interface7 is TextRange) && (str12.Length != (interface7 as TextRange).Text.Length))
                {
                    str12 = (interface7 as TextRange).Text;
                }
                else if ((interface7 is Class542) && (str12.Length != (interface7 as Class542).method_0().Length))
                {
                    str12 = (interface7 as Class542).method_0();
                }
                if (str12 == range8.Text)
                {
                    this.method_30().method_33(this.method_30().method_32() - num21);
                    ef6 = this.method_30().method_5().method_74().method_4(this.method_30().method_5().method_74().Count - num21).method_69();
                    if (range8.Text.Contains(BookmarkStart.b("ᄰ", num)))
                    {
                        int num24 = str12.LastIndexOf(' ');
                        interfaceArray[0] = new Class542(range8, str12.Substring(0, num24 + 1));
                        interfaceArray[1] = new Class542(range8, str12.Substring(num24 + 1, (str12.Length - num24) - 1).TrimStart(new char[0]));
                        flag = true;
                        if (str2 == BookmarkStart.b("㠰", num))
                        {
                            range2.HasBeenSplitted = true;
                        }
                    }
                    else
                    {
                        TextRange range9 = range8;
                        if (range2.Document != null)
                        {
                            range9 = new TextRange(range2.Document);
                            range9.method_0(range8.Owner);
                            range9.CharacterFormat.Font = range8.CharacterFormat.Font;
                            range9.CharacterFormat.FontSize = range8.CharacterFormat.FontSize;
                        }
                        interfaceArray[0] = new Class542(range9, string.Empty);
                        interfaceArray[1] = new Class542(range8, str12.TrimStart(new char[0]));
                        flag = true;
                        if (str2 == BookmarkStart.b("㠰", num))
                        {
                            range2.HasBeenSplitted = true;
                        }
                    }
                    for (int k = 0; k < num21; k++)
                    {
                        this.method_30().method_5().method_74().method_12(this.method_30().method_5().method_74().Count - 1);
                    }
                    this.method_30().method_5().method_98();
                }
            }
        }
    Label_1772:
        if (flag)
        {
            base.class375_0 = new Class375(interfaceArray[0]);
            SizeF ef8 = interfaceArray[0].imethod_3(base.method_4());
            base.class375_0.method_70(new RectangleF(ef6.Location, ef8));
            if (interfaceArray[1] != null)
            {
                base.interface1_0 = interfaceArray[1];
                base.layoutState_0 = LayoutState.Splitted;
            }
            return base.class375_0;
        }
    Label_17CD:
        return null;
    }

    private string[] method_42(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        List<string> list = new List<string>();
        StringBuilder builder = new StringBuilder();
        int num = 0;
        int length = A_0.Length;
        while (num < length)
        {
            char c = A_0[num];
            if (!char.IsPunctuation(c) && !char.IsSymbol(c))
            {
                if (c == ' ')
                {
                    builder.Append(c);
                    char ch2 = ((num + 1) < length) ? A_0[num + 1] : '\0';
                    if ((ch2 != ' ') && A_0.Contains(ch2.ToString()))
                    {
                        list.Add(builder.ToString());
                        builder = new StringBuilder();
                    }
                }
                else
                {
                    builder.Append(c);
                }
            }
            else
            {
                list.Add(builder.ToString());
                builder = new StringBuilder();
                builder.Append(c);
            }
            num++;
        }
        if ((builder != null) && (builder.Length > 0))
        {
            list.Add(builder.ToString());
            builder = null;
        }
        return list.ToArray();
    }

    private string[] method_43(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        string[] array = A_0.Split(new char[] { ' ' });
        List<string> list = new List<string>();
        string str2 = string.Empty;
        int index = 0;
        int length = array.Length;
        while (index < length)
        {
            string str = array[index];
            if (string.IsNullOrEmpty(str) && (list.Count == 0))
            {
                str2 = str2 + ' ';
            }
            if (string.IsNullOrEmpty(str) && (list.Count > 0))
            {
                List<string> list2;
                int num3;
                (list2 = list)[num3 = list.Count - 1] = list2[num3] + ' ';
            }
            if (!string.IsNullOrEmpty(str) && (list.Count > 0))
            {
                List<string> list3;
                int num4;
                (list3 = list)[num4 = list.Count - 1] = list3[num4] + ' ';
                list.Add(str);
            }
            if (!string.IsNullOrEmpty(str) && (list.Count == 0))
            {
                list.Add(str2 + str);
            }
            index++;
        }
        Array.Clear(array, 0, array.Length);
        array = null;
        return list.ToArray();
    }

    private bool method_44(char A_0)
    {
        return ((char.IsPunctuation(A_0) && (A_0 != '\'')) && (A_0 != '’'));
    }

    private void method_45(ref RectangleF A_0, ref SizeF A_1)
    {
        float x = A_0.X;
        float num2 = A_0.X - ((base.interface30_0 as Class304).method_11().method_4() - (base.interface30_0 as Class304).method_13());
        if ((((base.interface30_0 as Class304).method_11().method_0() == TabJustification.Centered) && (Class59.smethod_4(x, (base.interface30_0 as Class304).method_11().method_4(), 0.5f) != 0)) && ((num2 / 2f) < (base.interface30_0 as Class304).method_13()))
        {
            x = (base.interface30_0 as Class304).method_11().method_4() + (num2 / 2f);
            if (A_0.Right < ((base.interface30_0 as Class304).method_11().method_4() + (num2 / 2f)))
            {
                x = A_0.Right;
            }
            A_0.Width -= x - A_0.X;
            A_0.X = x;
            base.method_16(A_0);
        }
        else if (((base.interface30_0 as Class304).method_11().method_0() == TabJustification.Right) && (A_0.X < (base.interface30_0 as Class304).method_11().method_4()))
        {
            x = (base.interface30_0 as Class304).method_11().method_4();
            A_0.Width -= x - A_0.X;
            A_0.X = x;
            base.method_16(A_0);
        }
        else if ((base.interface30_0 as Class304).method_11().method_0() == TabJustification.Decimal)
        {
            this.method_47(ref A_0, ref x, num2);
        }
        Interface2 interface2 = this.method_29();
        Class206 class2 = interface2.imethod_0() as Class206;
        float num9 = 0f;
        bool flag = this.method_61();
        TextRange range = (interface2 is Class542) ? ((interface2 as Class542).method_2() as TextRange) : (interface2 as TextRange);
        Paragraph paragraph = range.method_28();
        if (flag && (interface2 is TextRange))
        {
            TableCell owner = paragraph.Owner as TableCell;
            class2.method_17((double) (owner.interface23_0 as Class211).method_115());
        }
        Section section = range.method_2();
        if (((section != null) && (section.Columns.Count > 1)) && ((base.method_14() is Class304) && ((base.method_14() as Class304).Interface30.imethod_4() > 0)))
        {
            int num5 = (base.method_14() as Class304).Interface30.imethod_4();
            float num3 = 0f;
            for (int i = 0; i < num5; i++)
            {
                num3 += section.Columns[i].Width + section.Columns[i].Space;
            }
            int num6 = 0;
            int count = class2.list_1.Count;
            while (num6 < count)
            {
                if (class2.method_15().Count == class2.method_14().Count)
                {
                    class2.method_14()[num6].method_5((((class2.method_15()[num6].Position != 0f) ? class2.method_15()[num6].Position : (class2.method_15()[num6].DeletePosition / 20f)) + ((float) class2.method_16())) + num3);
                }
                num6++;
            }
        }
        num9 = (paragraph.Format.FirstLineIndent <= 0f) ? paragraph.Format.LeftIndent : 0f;
        float width = (float) class2.method_22((double) x, paragraph);
        if (((x < (num9 + class2.method_16())) && ((width + x) > (num9 + class2.method_16()))) && (paragraph.Format.FirstLineIndent != 0f))
        {
            width = num9 - (x - ((float) class2.method_16()));
        }
        if ((!range.Document.Settings.method_5().method_3() && (class2.list_1.Count == 0)) && ((num9 != 0f) && ((x + width) < (num9 + class2.method_16()))))
        {
            width = num9 - (x - ((float) class2.method_16()));
        }
        if ((flag && (width > base.class774_0.method_13().Width)) && ((class2.class215_0.method_0() != TabJustification.Left) || (class2.class215_0.method_4() != 0f)))
        {
            width = base.class774_0.method_13().Width;
        }
        A_1.Width = width;
        if ((((class2.method_21() == TabJustification.Centered) || (class2.method_21() == TabJustification.Right)) || (class2.method_21() == TabJustification.Decimal)) && !this.method_48())
        {
            A_1.Width = 0f;
        }
        (base.interface30_0 as Class304).method_14(width);
        class2.method_19(width);
        if (Class59.smethod_2((double) (x + width), (double) class2.class215_0.method_4()) >= 0)
        {
            (base.interface30_0 as Class304).method_12(class2.class215_0);
        }
    }

    private bool method_46(string A_0)
    {
        int num = 10;
        Regex regex = new Regex(BookmarkStart.b("欯渱䄳ȵ崷ਹ఻ጽ᰿㝁絃⁅⥇罉ᅋ敍", 10));
        if (!regex.IsMatch(A_0))
        {
            Regex regex2 = new Regex(BookmarkStart.b("欯渱䄳Ե࠷ู఻ጽ᰿㝁睃癅煇ⱉᅋ敍", num));
            Regex regex3 = new Regex(BookmarkStart.b("欯渱䄳Ե࠷嬹఻ጽ᰿㝁睃癅⹇ⱉᅋ敍", num));
            if (!regex2.IsMatch(A_0) && !regex3.IsMatch(A_0))
            {
                return false;
            }
        }
        return true;
    }

    private void method_47(ref RectangleF A_0, ref float A_1, float A_2)
    {
        Paragraph ownerParagraph = (this.method_29() as TextRange).OwnerParagraph;
        int index = ownerParagraph.ChildObjects.IndexOf(this.method_29() as TextRange);
        int num2 = 0;
        for (int i = index - 1; i >= 0; i--)
        {
            if ((ownerParagraph.ChildObjects[i] is TextRange) && ((ownerParagraph.ChildObjects[i] as Interface2).imethod_0() is Class206))
            {
                num2 = i;
                break;
            }
        }
        float num4 = base.method_4().method_182(ownerParagraph, num2, index);
        if (num4 < (base.interface30_0 as Class304).method_13())
        {
            A_2 -= num4;
            A_1 = (base.interface30_0 as Class304).method_11().method_4() + A_2;
            A_0.Width -= A_1 - A_0.X;
            A_0.X = A_1;
            base.method_16(A_0);
        }
    }

    private bool method_48()
    {
        bool flag = false;
        Paragraph ownerParagraph = null;
        TextRange range = null;
        if (this.method_29() is TextRange)
        {
            ownerParagraph = (this.method_29() as TextRange).OwnerParagraph;
            range = this.method_29() as TextRange;
        }
        else if ((this.method_29() is Class542) && ((this.method_29() as Class542).method_2() is TextRange))
        {
            ownerParagraph = ((this.method_29() as Class542).method_2() as TextRange).OwnerParagraph;
            range = (this.method_29() as Class542).method_2() as TextRange;
        }
        if ((ownerParagraph != null) && (range != null))
        {
            for (int i = 0; i < (ownerParagraph.Items.Count - 1); i++)
            {
                ParagraphBase base2 = ownerParagraph.Items[i];
                if (flag)
                {
                    TextRange range2 = ownerParagraph.Items[i] as TextRange;
                    if ((range2 != null) && (range2 != null))
                    {
                        return (((Interface1) range2).imethod_0() is Class206);
                    }
                }
                else if (base2 == range)
                {
                    flag = true;
                }
            }
        }
        return false;
    }

    internal bool method_49(SizeF A_0)
    {
        int num = 13;
        bool flag2 = this.method_52(A_0);
        return (this.method_50() || ((!this.method_51(A_0.Width) && ((!(((this.method_29() is DocPicture) || (this.method_29() is DocOleObject)) ? this.method_54(A_0) : base.class774_0.method_20(A_0)) && !flag2) && !(((this.method_29() is TextRange) || (this.method_29() is Class542)) ? this.method_57(A_0) : false))) && ((!(this.method_29() is BookmarkStart) || !(this.method_29() as BookmarkStart).Name.StartsWith(BookmarkStart.b("氲爴堶笸娺帼吾", num))) && (!(this.method_29() is BookmarkEnd) || !(this.method_29() as BookmarkEnd).Name.StartsWith(BookmarkStart.b("氲爴堶笸娺帼吾", num))))));
    }

    private bool method_50()
    {
        int num = 7;
        if (!(this.method_29() is TextRange) || (!(this.method_29() as TextRange).Text.Contains(BookmarkStart.b("✬", num)) && !(this.method_29() as TextRange).Text.Contains(BookmarkStart.b("‬", num))))
        {
            if (!(this.method_29() is Class542) || ((this.method_29() as Class542).method_0() == null))
            {
                return false;
            }
            if (!(this.method_29() as Class542).method_0().Contains(BookmarkStart.b("✬", num)))
            {
                return (this.method_29() as Class542).method_0().Contains(BookmarkStart.b("‬", num));
            }
        }
        return true;
    }

    private bool method_51(float A_0)
    {
        bool flag = false;
        if (this.method_29() is TextRange)
        {
            Paragraph paragraph = ((this.method_29() as TextRange).OwnerEmptyParagraph != null) ? (this.method_29() as TextRange).OwnerEmptyParagraph : (this.method_29() as TextRange).method_28();
            if (paragraph == null)
            {
                return flag;
            }
            Section section = paragraph.method_49();
            Class210 class3 = ((Interface1) paragraph).imethod_0() as Class210;
            int num3 = (paragraph != null) ? paragraph.Format.TabsEx.Count : 0;
            if ((num3 <= 0) || !paragraph.method_25())
            {
                return flag;
            }
            if (!class3.method_93())
            {
                class3.method_94(true);
                Tab tab = paragraph.Format.TabsEx[num3 - 1];
                for (int i = num3 - 2; tab.Justification == TabJustification.Left; i--)
                {
                    if ((tab.Position != 0f) || (i < 0))
                    {
                        break;
                    }
                    tab = paragraph.Format.TabsEx[i];
                }
                class3.method_98(tab.Position);
            }
            if (this.method_29().imethod_0() is Class206)
            {
                Class206 class2 = this.method_29().imethod_0() as Class206;
                float num = section.PageSetup.ClientWidth + section.PageSetup.Margins.Left;
                if ((((class2.method_18() + base.class774_0.method_13().X) >= section.PageSetup.ClientWidth) && ((Math.Round((double) class2.class215_0.method_4(), 2) >= Math.Round((double) num, 2)) || ((class2.class215_0.method_0() == TabJustification.Left) && (class2.class215_0.method_4() == 0f)))) && (class3.method_97() >= section.PageSetup.ClientWidth))
                {
                    class3.method_96(true);
                }
            }
            if (class3.method_95() && ((base.class774_0.method_13().X + A_0) >= class3.method_97()))
            {
                flag = true;
            }
        }
        return flag;
    }

    private bool method_52(SizeF A_0)
    {
        bool flag = false;
        DocumentObject obj2 = (this.method_29() is DocPicture) ? (this.method_29() as DocPicture) : ((this.method_29() is DocOleObject) ? (this.method_29() as DocOleObject).Interface49.get_OlePicture() : (this.method_29() as DocumentObject));
        if (((base.method_2().imethod_2() && !(this.method_29() is TextRange)) && (!(this.method_29() is Class542) && (base.class774_0.method_3() != 0.0))) && (base.class774_0.method_2() != 0.0))
        {
            if (!(obj2 is DocPicture) || (!(obj2 as DocPicture).LayoutInCell && ((obj2 as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)))
            {
                if (!(obj2 is DocPicture))
                {
                    flag = true;
                }
            }
            else
            {
                Paragraph ownerParagraph = (obj2 as DocPicture).OwnerParagraph;
                if (ownerParagraph == null)
                {
                    DocumentObject owner = (obj2 as DocPicture).Owner;
                    while (owner != null)
                    {
                        if (owner is Paragraph)
                        {
                            break;
                        }
                        owner = owner.Owner;
                    }
                    ownerParagraph = owner as Paragraph;
                }
                if ((((A_0.Height > base.class774_0.method_13().Height) && (ownerParagraph != null)) && (((Interface1) ownerParagraph).imethod_0().imethod_2() && !base.method_2().imethod_30())) || (base.method_2().imethod_30() && (A_0.Height > base.class774_0.method_13().Width)))
                {
                    flag = true;
                }
                if ((((A_0.Height <= base.class774_0.method_13().Height) && (A_0.Width > base.class774_0.method_13().Width)) && !base.method_2().imethod_30()) || ((base.method_2().imethod_30() && (A_0.Height <= base.class774_0.method_13().Width)) && (A_0.Width > base.class774_0.method_13().Height)))
                {
                    flag = true;
                }
                if ((obj2 as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline)
                {
                    DocumentObject obj4 = this.method_55(obj2);
                    if (obj4 is Table)
                    {
                        float num3 = (obj2.Owner.Owner is TableCell) ? (obj2.Owner.Owner as TableCell).LayoutWidth : 0f;
                        if (((A_0.Height <= base.class774_0.method_13().Height) && (A_0.Width > base.class774_0.method_13().Width)) && (A_0.Width <= num3))
                        {
                            flag = false;
                        }
                    }
                    else if (obj4 is Section)
                    {
                        float clientWidth = (obj4 as Section).PageSetup.ClientWidth;
                        if (((A_0.Height <= base.class774_0.method_13().Height) && (A_0.Width > base.class774_0.method_13().Width)) && (A_0.Width <= clientWidth))
                        {
                            flag = false;
                        }
                    }
                }
            }
        }
        TextRange range = (this.method_29() is TextRange) ? (this.method_29() as TextRange) : ((this.method_29() is Class542) ? ((this.method_29() as Class542).method_2() as TextRange) : null);
        float width = base.class774_0.method_13().Width;
        if ((((range != null) && (range.Text.Length == 1)) || (((this.method_29() is Class542) && ((this.method_29() as Class542).method_0() != null)) && ((this.method_29() as Class542).method_0().Length == 1))) && (range.OwnerParagraph != null))
        {
            if (range.OwnerParagraph.IsInCell)
            {
                width = base.method_4().method_394(range);
                if (A_0.Width > width)
                {
                    flag = true;
                }
            }
            if (this.method_53(range))
            {
                flag = true;
            }
        }
        if ((this.method_29() is Symbol) && (this.method_29() as Symbol).method_28().IsInCell)
        {
            width = base.method_4().method_394(this.method_29() as DocumentObject);
            if (A_0.Width > width)
            {
                flag = true;
            }
        }
        return flag;
    }

    private bool method_53(ParagraphBase A_0)
    {
        float num = 0f;
        float width = 0f;
        if ((A_0 != null) && (A_0.OwnerParagraph != null))
        {
            DocumentObject owner = A_0;
            while (!(owner is Section))
            {
                if ((owner is Table) || (owner.Owner == null))
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                width = (base.interface30_0 as Class304).method_4().Width;
            }
            else if (owner is Table)
            {
                DocumentObject obj2 = A_0;
                while (!(obj2 is TableCell))
                {
                    if ((obj2 is TableCell) || (obj2.Owner == null))
                    {
                        break;
                    }
                    obj2 = obj2.Owner;
                }
                if (obj2 is TableCell)
                {
                    width = (obj2 as TableCell).LayoutWidth;
                }
            }
            Class210 class2 = ((Interface1) A_0.OwnerParagraph).imethod_0() as Class210;
            if (class2.method_43())
            {
                num = ((float) class2.Interface22.imethod_1().method_0()) + class2.method_19();
            }
            else
            {
                num = (float) class2.Interface22.imethod_1().method_0();
            }
        }
        return (num > width);
    }

    private bool method_54(SizeF A_0)
    {
        bool flag = false;
        DocPicture picture = (this.method_29() is DocOleObject) ? (this.method_29() as DocOleObject).Interface49.get_OlePicture() : (this.method_29() as DocPicture);
        if (picture == null)
        {
            return flag;
        }
        DocumentObject obj3 = this.method_55(picture);
        if ((picture.TextWrappingStyle != TextWrappingStyle.Inline) && (((picture.TextWrappingStyle == TextWrappingStyle.Inline) || (picture.TextWrappingStyle == TextWrappingStyle.InFrontOfText)) || (((picture.TextWrappingStyle == TextWrappingStyle.Behind) || (picture.VerticalOrigin != VerticalOrigin.Paragraph)) || (obj3 is Table))))
        {
            if (picture.TextWrappingStyle == TextWrappingStyle.TopAndBottom)
            {
                float clientHeight = base.method_4().method_28().method_28().ClientHeight;
                if (!base.method_4().method_135())
                {
                    float height = base.method_4().method_28().method_3().method_4(0).method_69().Height;
                    float num15 = base.method_4().method_28().method_3().method_4(1).method_69().Height;
                    clientHeight = (clientHeight - height) - num15;
                }
                if (((Class59.smethod_5((double) A_0.Height, (double) base.class774_0.method_13().Height, 0.5) > 0) && ((Class59.smethod_5((double) A_0.Height, (double) base.class774_0.method_13().Height, 0.5) <= 0) || (Class59.smethod_5((double) base.class774_0.method_13().Height, (double) base.method_4().method_28().method_29().ClientHeight, 0.5) != 0))) && ((Class59.smethod_5((double) A_0.Height, (double) clientHeight, 0.5) <= 0) && (!this.method_29().imethod_0().imethod_36() || (Class59.smethod_5((double) A_0.Height, (double) base.class774_0.method_13().Height, 0.5) > 0))))
                {
                    this.method_29().imethod_0().imethod_37(true);
                    return flag;
                }
                return true;
            }
            if (((!this.method_29().imethod_0().imethod_36() && (picture.TextWrappingStyle == TextWrappingStyle.Square)) && ((picture.VerticalOrigin == VerticalOrigin.Margin) && (picture.VerticalPosition <= 0f))) && ((picture.HorizontalOrigin == HorizontalOrigin.Margin) && (picture.HorizontalPosition <= 0f)))
            {
                if (base.class774_0.method_13().Top <= 0f)
                {
                    return true;
                }
                if ((picture.VerticalAlignment == ShapeVerticalAlignment.None) && ((A_0.Width > base.class774_0.method_13().Width) || (A_0.Height > base.class774_0.method_13().Height)))
                {
                    this.method_29().imethod_0().imethod_37(true);
                    return false;
                }
                if (!base.method_4().method_28().method_51(new RectangleF(new PointF(), A_0), picture).method_0().IsEmpty)
                {
                    if (base.method_4().method_28().method_50(picture) >= base.class774_0.method_13().Bottom)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return true;
        }
        float num5 = 0f;
        float width = 0f;
        float num2 = 0f;
        float num11 = 0f;
        Paragraph ownerParagraph = picture.OwnerParagraph;
        if (picture.Owner is SDTInlineContent)
        {
            ownerParagraph = picture.Owner.Owner.Owner as Paragraph;
        }
        if (ownerParagraph == null)
        {
            DocumentObject owner = picture.Owner;
            while (owner != null)
            {
                if (owner is Paragraph)
                {
                    break;
                }
                owner = owner.Owner;
            }
            ownerParagraph = owner as Paragraph;
        }
        Class210 class2 = ((Interface1) ownerParagraph).imethod_0() as Class210;
        class2.Interface22.imethod_1().method_4();
        class2.Interface22.imethod_0().method_4();
        if (obj3 is Section)
        {
            float num12 = (obj3 as Section).PageSetup.ClientHeight;
            float clientWidth = (obj3 as Section).PageSetup.ClientWidth;
            MarginsF margins = (obj3 as Section).PageSetup.Margins;
            num5 = (obj3 as Section).PageSetup.PageSize.Height;
            width = (obj3 as Section).PageSetup.PageSize.Width;
            num2 = (base.interface30_0 as Class304).method_4().Height;
            num11 = (base.interface30_0 as Class304).method_4().Width;
            if (class2.method_43())
            {
                num11 = (base.interface30_0 as Class304).method_4().Width - ((((float) (class2.Interface22.imethod_1().method_0() + class2.Interface22.imethod_1().method_8())) + class2.method_19()) + class2.method_51());
            }
            else if ((obj3 as Section).Columns.Count == 1)
            {
                num11 = (obj3 as Section).PageSetup.ClientWidth;
            }
            else
            {
                num11 = base.method_4().method_181(obj3 as Section);
            }
            if (base.method_4().method_28().method_3().Count >= 2)
            {
                num2 = base.method_4().method_28().method_94();
            }
            if ((picture.VerticalOrigin == VerticalOrigin.Paragraph) && (picture.TextWrappingStyle != TextWrappingStyle.Inline))
            {
                float num18 = (picture.VerticalPosition > num12) ? 0f : picture.VerticalPosition;
                float num4 = (float) Math.Round((double) ((base.class774_0.method_13().Y + num18) + A_0.Height), 1);
                if (((num4 <= base.class774_0.method_13().Bottom) || (num4 <= num5)) || ((A_0.Height > num5) && (num4 > num5)))
                {
                    flag = true;
                }
                return flag;
            }
            if (((((A_0.Height <= base.class774_0.method_13().Height) && (Class59.smethod_4(base.class774_0.method_13().Width, 0f, 0.005f) > 0)) || ((A_0.Height > num12) && this.method_29().imethod_0().imethod_36())) || (((A_0.Height > base.class774_0.method_13().Height) && (base.class774_0.method_13().Height == num2)) && (A_0.Height > num2))) && ((((A_0.Width <= base.class774_0.method_13().Width) || ((A_0.Width > base.class774_0.method_13().Width) && ((base.class774_0.method_13().X + A_0.Width) <= num11))) || ((A_0.Width > width) || ((A_0.Width > num11) && ((base.class774_0.method_13().X + A_0.Width) > width)))) || ((((A_0.Width <= num11) && ((base.class774_0.method_13().X + A_0.Width) < num11)) || ((A_0.Width <= num11) && ((base.class774_0.method_13().X + A_0.Width) < width))) || ((A_0.Width > num11) && ((base.class774_0.method_13().X + A_0.Width) < width)))))
            {
                flag = true;
            }
            return flag;
        }
        if (obj3 is Table)
        {
            Table table = obj3 as Table;
            float num13 = 0f;
            TableCell cell = picture.Owner.Owner as TableCell;
            if (cell != null)
            {
                float num9 = 0f;
                Paragraph paragraph = picture.Owner as Paragraph;
                if (paragraph != null)
                {
                    float leftIndent = paragraph.Format.LeftIndent;
                    float rightIndent = paragraph.Format.RightIndent;
                    float firstLineIndent = paragraph.Format.FirstLineIndent;
                    num9 = (leftIndent + firstLineIndent) + rightIndent;
                }
                float layoutWidth = cell.LayoutWidth;
                float num17 = cell.CellFormat.SamePaddingsAsTable ? (obj3 as Table).TableFormat.Paddings.PaddingWidth : cell.CellFormat.Paddings.PaddingWidth;
                if (((A_0.Height <= base.class774_0.method_13().Height) && (Class59.smethod_4(A_0.Width, base.class774_0.method_13().Width, 0.05f) > 0)) && (Class59.smethod_4(A_0.Width, layoutWidth - (num17 + num9), 0.05f) < 0))
                {
                    this.method_29().imethod_0().imethod_37(true);
                    return false;
                }
                num13 = (float) ((Interface1) cell).imethod_0().imethod_0().method_4();
            }
            float num = base.method_4().method_28().method_28().ClientHeight;
            if (!base.method_4().method_135())
            {
                float num19 = base.method_4().method_28().method_3().method_4(0).method_69().Height;
                float num20 = base.method_4().method_28().method_3().method_4(1).method_69().Height;
                num = (num - num19) - num20;
            }
            if (((Class59.smethod_5((double) A_0.Height, (double) base.class774_0.method_13().Height, 0.5) <= 0) || (table.IsInCell && ((table.Owner.Owner as TableRow).HeightType == TableRowHeightType.Exactly))) || ((Class59.smethod_5((double) A_0.Height, (double) num, 0.5) > 0) || (this.method_29().imethod_0().imethod_36() && (Class59.smethod_5((double) A_0.Height, (double) (base.class774_0.method_13().Height + num13), 0.5) <= 0))))
            {
                flag = true;
            }
            if (!flag)
            {
                this.method_29().imethod_0().imethod_37(true);
            }
            return flag;
        }
        if (!(obj3 is Paragraph))
        {
            return flag;
        }
        ParagraphFormat format = (obj3 as Paragraph).Format;
        if ((format == null) || !format.IsFrame)
        {
            return flag;
        }
        if (((picture.TextWrappingStyle == TextWrappingStyle.Inline) && (format.FrameWidthRule == FrameSizeRule.Exact)) && ((A_0.Width > base.class774_0.method_2()) && (A_0.Width <= format.FrameWidthEx)))
        {
            return false;
        }
        return true;
    }

    private DocumentObject method_55(DocumentObject A_0)
    {
        DocumentObject owner = A_0;
        DocPicture picture = A_0 as DocPicture;
        while (!(owner is Section))
        {
            if (((owner is Paragraph) && ((owner as Paragraph).Format != null)) && (((owner as Paragraph).Format.IsFrame && (picture != null)) && (picture.TextWrappingStyle == TextWrappingStyle.Inline)))
            {
                return owner;
            }
            if ((owner is Table) && (picture.LayoutInCell || (picture.TextWrappingStyle == TextWrappingStyle.Inline)))
            {
                return owner;
            }
            if (owner.Owner == null)
            {
                return owner;
            }
            owner = owner.Owner;
        }
        return owner;
    }

    private bool method_56(SizeF A_0)
    {
        TextRange range = null;
        if (this.method_29() is TextRange)
        {
            range = this.method_29() as TextRange;
        }
        else if ((this.method_29() is Class542) && ((this.method_29() as Class542).method_2() is TextRange))
        {
            range = (this.method_29() as Class542).method_2() as TextRange;
        }
        Paragraph paragraph = (range.OwnerParagraph != null) ? range.OwnerParagraph : range.OwnerEmptyParagraph;
        if (((paragraph == null) || !(paragraph.Owner is TableCell)) || (((((paragraph.Owner as TableCell).OwnerRow == null) || ((paragraph.Owner as TableCell).OwnerRow.OwnerTable == null)) || ((paragraph.Owner as TableCell).OwnerRow.OwnerTable.TextBoxFormat == null)) && !this.method_35((paragraph.Owner as TableCell).OwnerRow.OwnerTable)))
        {
            return false;
        }
        return (Class59.smethod_2((double) A_0.Width, (double) base.class774_0.method_13().Width) <= 0);
    }

    private bool method_57(SizeF A_0)
    {
        bool flag;
        if (this.method_56(A_0))
        {
            return true;
        }
        if (flag = this.method_59(A_0))
        {
            return flag;
        }
        TextRange range = null;
        string text = null;
        if (this.method_29() is TextRange)
        {
            range = this.method_29() as TextRange;
            text = range.Text;
        }
        else if ((this.method_29() is Class542) && ((this.method_29() as Class542).method_2() is TextRange))
        {
            range = (this.method_29() as Class542).method_2() as TextRange;
            text = (this.method_29() as Class542).method_0();
        }
        if ((range == null) || (text == null))
        {
            return flag;
        }
        string str2 = text.TrimEnd(new char[0]);
        SizeF ef = A_0;
        if ((text != str2) && !string.IsNullOrEmpty(str2))
        {
            ef = base.method_4().method_323(range, str2);
        }
        if (!this.regex_0.IsMatch(str2))
        {
            Interface1 ownerParagraph = range.OwnerParagraph;
            if (ownerParagraph is Paragraph)
            {
                ef.Width -= (float) ownerParagraph.imethod_0().imethod_0().method_8();
            }
        }
        return this.method_59(ef);
    }

    private bool method_58()
    {
        return ((this.method_61() && ((base.interface30_0 as Class304).method_11().method_4() >= ((((this.method_29() as TextRange).OwnerParagraph.OwnerTextBody as TableCell).interface23_0 as Class211).method_115() + base.method_4().method_394(this.method_29() as DocumentObject)))) || ((base.interface30_0 as Class304).method_11().method_4() >= base.class774_0.method_13().Right));
    }

    private bool method_59(SizeF A_0)
    {
        bool flag = false;
        if (((base.method_2().imethod_2() && (Class59.smethod_2((double) A_0.Width, base.class774_0.method_2()) <= 0)) && (Class59.smethod_1((double) A_0.Height, base.class774_0.method_3(), false) <= 0)) || (Class59.smethod_2((double) (base.interface30_0 as Class304).method_11().method_4(), (double) Math.Abs(base.class774_0.method_13().Right)) > 0))
        {
            flag = true;
        }
        if (flag)
        {
            return flag;
        }
        TextRange range = (this.method_29() is TextRange) ? (this.method_29() as TextRange) : ((!(this.method_29() is Class542) || !((this.method_29() as Class542).method_2() is TextRange)) ? null : ((this.method_29() as Class542).method_2() as TextRange));
        if (range == null)
        {
            return flag;
        }
        Paragraph ownerParagraph = range.OwnerParagraph;
        if (((ownerParagraph != null) && (ownerParagraph.Format != null)) && ownerParagraph.Format.IsFrame)
        {
            if (ownerParagraph.Format.FrameHeight > 0)
            {
                return (Class59.smethod_2((double) A_0.Width, (double) base.class774_0.method_13().Width) <= 0);
            }
            if (ownerParagraph.Format.FrameHeight >= 0)
            {
                return flag;
            }
            return ((Class59.smethod_2((double) A_0.Width, (double) base.class774_0.method_13().Width) <= 0) && (Class59.smethod_1((double) A_0.Height, (double) -base.class774_0.method_13().Height, false) <= 0));
        }
        if ((((ownerParagraph == null) || !ownerParagraph.IsInCell) || (((ownerParagraph.Owner as TableCell).OwnerRow.OwnerTable == null) || (ownerParagraph.Owner as TableCell).OwnerRow.OwnerTable.IsTextBox)) || (ownerParagraph.Owner as TableCell).OwnerRow.OwnerTable.IsSDTTable)
        {
            return flag;
        }
        TableCell owner = ownerParagraph.Owner as TableCell;
        if ((owner != null) && !owner.CellFormat.SamePaddingsAsTable)
        {
            float right = owner.CellFormat.Paddings.Right;
        }
        else
        {
            float single2 = owner.OwnerRow.OwnerTable.TableFormat.Paddings.Right;
        }
        RectangleF ef = base.class774_0.method_13();
        return (((range is CheckBoxFormField) && ((Class59.smethod_3((double) A_0.Width, (double) ef.Width, 2.0) <= 0) || ((Class59.smethod_4(A_0.Width, ef.Width, 0.001f) > 0) && (Class59.smethod_4(A_0.Width, base.method_4().method_394(range), 0.001f) > 0)))) || ((((owner != null) && (owner.OwnerRow != null)) && ((owner.OwnerRow.HeightType == TableRowHeightType.Exactly) && (Class59.smethod_1((double) A_0.Height, (double) ef.Height, false) > 0))) || ((Class59.smethod_2((double) A_0.Width, (double) ef.Width) <= 0) && (Class59.smethod_1((double) A_0.Height, (double) ef.Height, false) <= 0))));
    }

    internal Class375 method_60(RectangleF A_0, SizeF A_1)
    {
        return (Class375) (base.class375_0 = null);
    }

    internal bool method_61()
    {
        bool flag = false;
        if (((this.method_29() is TextRange) && ((this.method_29() as TextRange).OwnerParagraph != null)) && (this.method_29() as TextRange).OwnerParagraph.IsInCell)
        {
            flag = true;
        }
        return flag;
    }

    internal bool method_62(TextRange A_0)
    {
        bool flag = false;
        if ((A_0.NextSibling != null) && (A_0.NextSibling is TextRange))
        {
            flag = true;
        }
        return flag;
    }

    internal void method_63(Interface19 A_0, SizeF A_1)
    {
        int num = 14;
        if ((A_0 != null) && (A_1.Height <= base.class774_0.method_11().Height))
        {
            Interface19[] interfaceArray2 = null;
            float width = (base.interface30_0 as Class304).method_4().Width;
            if ((this.method_29() as TextRange).OwnerParagraph != null)
            {
                Class210 class2 = ((Interface1) (this.method_29() as TextRange).OwnerParagraph).imethod_0() as Class210;
                if (class2.method_43())
                {
                    width = (base.interface30_0 as Class304).method_4().Width - ((((float) (class2.Interface22.imethod_1().method_0() + class2.Interface22.imethod_1().method_8())) + class2.method_19()) + class2.method_51());
                }
                else
                {
                    width = (base.interface30_0 as Class304).method_4().Width - (((float) (class2.Interface22.imethod_1().method_0() + class2.Interface22.imethod_1().method_8())) + class2.method_51());
                }
                if ((this.method_29() as TextRange).OwnerParagraph.IsInCell)
                {
                    width = base.method_4().method_394(this.method_29() as TextRange);
                }
            }
            if (base.method_2() is Class206)
            {
                interfaceArray2 = new Interface19[] { A_0, A_0 };
            }
            else
            {
                Interface21 interface2 = this.method_29() as Interface21;
                string str = "";
                string[] strArray = (this.method_29() as TextRange).Text.Split(new char[] { ' ' });
                Interface19[] interfaceArray = new Interface19[2];
                if ((strArray.Length == 1) && (A_1.Width > width))
                {
                    interfaceArray[0] = new Class542(interface2, strArray[0]);
                    interfaceArray[1] = new Class542(interface2, str.TrimStart(new char[0]));
                }
                else
                {
                    for (int i = 0; i < (strArray.Length - 1); i++)
                    {
                        str = str + strArray[i] + BookmarkStart.b("ᐳ", num);
                    }
                    interfaceArray[0] = new Class542(interface2, str);
                    interfaceArray[1] = new Class542(interface2, strArray[strArray.Length - 1].TrimStart(new char[0]));
                }
                interfaceArray2 = interfaceArray;
            }
            base.layoutState_0 = LayoutState.NotFitted;
            if (interfaceArray2 != null)
            {
                A_1 = interfaceArray2[0].imethod_3(base.method_4());
                if (!base.class774_0.method_20(A_1))
                {
                    A_1.Width = base.class774_0.method_11().Width;
                }
                this.method_69(A_1, interfaceArray2[0]);
                base.interface1_0 = interfaceArray2[1];
                base.layoutState_0 = LayoutState.Splitted;
            }
        }
        else
        {
            base.layoutState_0 = LayoutState.NotFitted;
            base.bool_3 = A_1.Height > base.class774_0.method_11().Height;
        }
    }

    internal bool method_64(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return false;
        }
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

    internal bool method_65(SizeF A_0, RectangleF A_1)
    {
        int num = 3;
        bool flag = this.method_66();
        if (((((((this.method_29() as TextRange).PreviousSibling == null) || !((this.method_29() as TextRange).PreviousSibling is TextRange)) || !((this.method_29() as TextRange).PreviousSibling as TextRange).Text.EndsWith("")) && ((this.method_29() as TextRange).PreviousSibling != null)) || ((!(this.method_29() as TextRange).Text.StartsWith("") || !(this.method_29() as TextRange).Text.EndsWith("")) || (!((this.method_29() as TextRange).NextSibling as TextRange).Text.StartsWith("") || !((this.method_29() as TextRange).NextSibling as TextRange).Text.EndsWith("")))) || (((this.method_29() as TextRange).NextSibling as TextRange).Text.IndexOf(BookmarkStart.b("न", num)) == -1))
        {
            return flag;
        }
        TextRange nextSibling = (this.method_29() as TextRange).NextSibling as TextRange;
        if (nextSibling.CharacterFormat.FontSize == 0f)
        {
            nextSibling.CharacterFormat.FontSize = (this.method_29() as TextRange).CharacterFormat.FontSize;
        }
        SizeF ef = base.method_4().method_1() ? base.method_4().method_309(nextSibling.Text.Substring(0, nextSibling.Text.IndexOf(BookmarkStart.b("न", num)) + 1), base.method_4().method_378(nextSibling), null) : base.method_4().method_316(nextSibling.Text.Substring(0, nextSibling.Text.IndexOf(BookmarkStart.b("न", num)) + 1), base.method_4().method_367(nextSibling), null);
        if (A_0.Width <= A_1.Width)
        {
            SizeF ef2 = A_0 + ef;
            if (ef2.Width > A_1.Width)
            {
                return true;
            }
        }
        return false;
    }

    internal bool method_66()
    {
        int num = 10;
        bool flag = true;
        return (((((!(this.method_29() as TextRange).Text.EndsWith(BookmarkStart.b("ု", 10)) && !(this.method_29() as TextRange).Text.EndsWith(BookmarkStart.b("ḯ", num))) && (!(this.method_29() as TextRange).Text.EndsWith(BookmarkStart.b("ᰯ", num)) && !((this.method_29() as TextRange).NextSibling as TextRange).Text.StartsWith(BookmarkStart.b("ု", num)))) && (!((this.method_29() as TextRange).NextSibling as TextRange).Text.StartsWith(BookmarkStart.b("ḯ", num)) && !((this.method_29() as TextRange).NextSibling as TextRange).Text.StartsWith(BookmarkStart.b("ᰯ", num)))) && (((((this.method_29() as TextRange).PreviousSibling == null) || !((this.method_29() as TextRange).PreviousSibling is TextRange)) || (!((this.method_29() as TextRange).PreviousSibling as TextRange).Text.EndsWith("") || !(this.method_29() as TextRange).Text.StartsWith(""))) || (!(this.method_29() as TextRange).Text.EndsWith("") || (((this.method_29() as TextRange).NextSibling as TextRange).Text.StartsWith("") && ((this.method_29() as TextRange).NextSibling as TextRange).Text.EndsWith(""))))) && flag);
    }

    internal void method_67(Interface2 A_0, SizeF A_1, ref RectangleF A_2)
    {
        Paragraph ownerParagraph = null;
        if (!(A_0 is TextRange) && (!(A_0 is Class542) || !((A_0 as Class542).method_2() is TextRange)))
        {
            if (A_0 is ParagraphBase)
            {
                ownerParagraph = (A_0 as ParagraphBase).OwnerParagraph;
            }
        }
        else
        {
            TextRange range = (A_0 is TextRange) ? (A_0 as TextRange) : ((A_0 as Class542).method_2() as TextRange);
            if (range != null)
            {
                ownerParagraph = (range.OwnerParagraph != null) ? range.OwnerParagraph : range.OwnerEmptyParagraph;
            }
        }
        if (((((ownerParagraph == null) || (ownerParagraph.Format == null)) || (ownerParagraph.Format.FrameVerticalPos == 2)) && (((ownerParagraph != null) || !(A_0 is TextRange)) || (((A_0 as TextRange).OwnerEmptyParagraph == null) || !((Interface1) (A_0 as TextRange).OwnerEmptyParagraph.method_49()).imethod_0().imethod_44()))) && (((Class616.list_0.Count > 0) && !(base.interface30_0 as Class304).method_10()) && (((ownerParagraph != null) && !ownerParagraph.Format.IsFrame) || (ownerParagraph == null))))
        {
            RectangleF ef13 = (base.interface30_0 as Class304).method_4();
            for (int i = 0; i < Class616.list_0.Count; i++)
            {
                RectangleF ef14 = Class616.list_0[i];
                if (ef13.X > (ef14.Right + 16f))
                {
                    continue;
                }
                RectangleF ef15 = Class616.list_0[i];
                if (ef13.Right < (ef15.X - 16f))
                {
                    continue;
                }
                if (Class616.list_0.Count <= 0)
                {
                    goto Label_073A;
                }
                RectangleF ef5 = Class616.list_0[i];
                if (A_2.Y >= ef5.Y)
                {
                    RectangleF ef41 = Class616.list_0[i];
                    if (A_2.Y < ef41.Bottom)
                    {
                        goto Label_0203;
                    }
                }
                RectangleF ef22 = Class616.list_0[i];
                if ((A_2.Y + A_1.Height) < ef22.Y)
                {
                    goto Label_073A;
                }
                RectangleF ef23 = Class616.list_0[i];
                if ((A_2.Y + A_1.Height) >= ef23.Bottom)
                {
                    goto Label_073A;
                }
            Label_0203:
                if (((((TextWrappingStyle) Class616.list_1[i]) != TextWrappingStyle.Inline) && (((TextWrappingStyle) Class616.list_1[i]) != TextWrappingStyle.TopAndBottom)) && ((((TextWrappingStyle) Class616.list_1[i]) != TextWrappingStyle.InFrontOfText) && (((TextWrappingStyle) Class616.list_1[i]) != TextWrappingStyle.Behind)))
                {
                    DocumentObject owner = A_0 as DocumentObject;
                    while (!(owner is Paragraph))
                    {
                        if (((owner == null) || (owner is Paragraph)) || (owner == null))
                        {
                            break;
                        }
                        owner = owner.Owner;
                    }
                    float num2 = 0f;
                    if (A_0 is ParagraphBase)
                    {
                        if ((A_0 as ParagraphBase).OwnerParagraph != null)
                        {
                            num2 = (float) (((Interface1) (A_0 as ParagraphBase).OwnerParagraph).imethod_0() as Class210).Interface22.imethod_1().method_8();
                        }
                        else if (A_0 is TextRange)
                        {
                            Paragraph ownerBase = (A_0 as TextRange).CharacterFormat.BaseFormat.OwnerBase as Paragraph;
                            if (ownerBase != null)
                            {
                                num2 = (float) (((Interface1) ownerBase).imethod_0() as Class210).Interface22.imethod_1().method_8();
                            }
                        }
                        num2 = (num2 < 0f) ? Math.Abs(num2) : 0f;
                    }
                    if (((owner != null) && (owner is Paragraph)) && ((owner as Paragraph).Format.HorizontalAlignment != HorizontalAlignment.Left))
                    {
                        RectangleF ef8 = Class616.list_0[i];
                        if (A_2.X < ef8.X)
                        {
                            RectangleF ef2 = Class616.list_0[i];
                            if ((A_2.X + A_1.Width) > ef2.X)
                            {
                                RectangleF ef16 = Class616.list_0[i];
                                A_2.Y = ef16.Bottom;
                                RectangleF ef17 = Class616.list_0[i];
                                A_2.Height -= ef17.Height;
                                base.method_16(A_2);
                                continue;
                            }
                        }
                    }
                    RectangleF ef9 = Class616.list_0[i];
                    if (A_2.X >= ef9.X)
                    {
                        RectangleF ef10 = Class616.list_0[i];
                        if (A_2.X < ef10.Right)
                        {
                            RectangleF ef12 = Class616.list_0[i];
                            A_2.Width = (A_2.Width - (ef12.Right - A_2.X)) - num2;
                            if (A_2.Width < 16f)
                            {
                                RectangleF ef4 = Class616.list_0[i];
                                A_2.Width = (base.class774_0.method_13().Right - ef4.Right) - num2;
                                if (A_2.Width < 16f)
                                {
                                    RectangleF ef36 = Class616.list_0[i];
                                    A_2.Y = ef36.Bottom;
                                    A_2.Width = base.class774_0.method_11().Width;
                                    RectangleF ef38 = Class616.list_0[i];
                                    A_2.Height -= ef38.Bottom - A_2.Y;
                                    base.method_16(A_2);
                                }
                                else
                                {
                                    RectangleF ef26 = Class616.list_0[i];
                                    A_2.X = ef26.Right;
                                    base.method_16(A_2);
                                }
                            }
                            else
                            {
                                RectangleF ef29 = Class616.list_0[i];
                                A_2.X = ef29.Right;
                                base.method_16(A_2);
                            }
                            continue;
                        }
                    }
                    RectangleF ef34 = Class616.list_0[i];
                    if (ef34.X > A_2.X)
                    {
                        RectangleF ef35 = Class616.list_0[i];
                        if (A_2.Right > ef35.X)
                        {
                            RectangleF ef = Class616.list_0[i];
                            A_2.Width = (ef.X - A_2.X) - num2;
                            if (A_2.Width < 16f)
                            {
                                RectangleF ef33 = Class616.list_0[i];
                                A_2.Width = (base.class774_0.method_13().Right - ef33.Right) - num2;
                                if (A_2.Width < 16f)
                                {
                                    RectangleF ef30 = Class616.list_0[i];
                                    A_2.Y = ef30.Bottom;
                                    RectangleF ef31 = Class616.list_0[i];
                                    A_2.Height -= ef31.Height;
                                    base.method_16(A_2);
                                }
                            }
                            else
                            {
                                base.method_16(A_2);
                            }
                            continue;
                        }
                    }
                    RectangleF ef6 = Class616.list_0[i];
                    if (A_2.X > ef6.X)
                    {
                        RectangleF ef7 = Class616.list_0[i];
                        if (A_2.X > ef7.Right)
                        {
                            A_2.Width = base.class774_0.method_11().Width;
                            base.method_16(A_2);
                            continue;
                        }
                    }
                    RectangleF ef27 = Class616.list_0[i];
                    if (A_2.X > ef27.X)
                    {
                        RectangleF ef28 = Class616.list_0[i];
                        if (A_2.X < ef28.Right)
                        {
                            RectangleF ef24 = Class616.list_0[i];
                            A_2.Width -= ef24.Right - A_2.X;
                            RectangleF ef25 = Class616.list_0[i];
                            A_2.X = ef25.Right;
                            base.method_16(A_2);
                        }
                    }
                    continue;
                }
            Label_073A:
                if (Class616.list_0.Count <= 0)
                {
                    continue;
                }
                RectangleF ef21 = Class616.list_0[i];
                if (A_2.Y >= ef21.Y)
                {
                    RectangleF ef11 = Class616.list_0[i];
                    if (A_2.Y < ef11.Bottom)
                    {
                        goto Label_07CA;
                    }
                }
                RectangleF ef39 = Class616.list_0[i];
                if ((A_2.Y + A_1.Height) < ef39.Y)
                {
                    continue;
                }
                RectangleF ef40 = Class616.list_0[i];
                if ((A_2.Y + A_1.Height) >= ef40.Bottom)
                {
                    continue;
                }
            Label_07CA:
                if (((TextWrappingStyle) Class616.list_1[i]) == TextWrappingStyle.TopAndBottom)
                {
                    RectangleF ef19 = Class616.list_0[i];
                    A_2.Y = ef19.Bottom;
                    RectangleF ef20 = Class616.list_0[i];
                    A_2.Height -= ef20.Height;
                    base.method_16(A_2);
                }
            }
        }
    }

    private void method_68(Interface2 A_0, SizeF A_1, ref RectangleF A_2)
    {
        if (A_1.Width > A_2.Width)
        {
            TextRange range = A_0 as TextRange;
            if ((A_0 is TextRange) && (range.OwnerParagraph != null))
            {
                Paragraph ownerParagraph = range.OwnerParagraph;
                if (ownerParagraph.IsInCell && (ownerParagraph.Owner is TableCell))
                {
                    float right = (ownerParagraph.Owner.Owner.Owner as Table).TableFormat.Paddings.Right;
                    A_2 = new RectangleF(A_2.X, A_2.Y, A_2.Width + right, A_2.Height);
                    base.method_16(A_2);
                }
            }
        }
    }

    private void method_69(SizeF A_0, Interface1 A_1)
    {
        float num22;
        double num = (A_0.Width + base.method_2().imethod_0().method_0()) + base.method_2().imethod_0().method_8();
        double num2 = (A_0.Height + base.method_2().imethod_0().method_4()) + base.method_2().imethod_0().method_12();
        double horizontalPosition = 0.0;
        double verticalPosition = 0.0;
        bool flag = false;
        DocPicture picture = null;
        if (!(A_1 is DocPicture))
        {
            goto Label_0BF7;
        }
        flag = true;
        float left = 0f;
        float right = 0f;
        float top = 0f;
        float bottom = 0f;
        float headerDistance = 0f;
        float footerDistance = 0f;
        Section section = null;
        picture = A_1 as DocPicture;
        float width = 0f;
        float height = 0f;
        float clientWidth = 0f;
        float num14 = 0f;
        bool flag2 = true;
        float num15 = (picture.Width * picture.WidthScale) / 100f;
        float num16 = (picture.Height * picture.WidthScale) / 100f;
        if (picture.Owner != null)
        {
            DocumentObject owner = picture.Owner;
            while (!(owner is Section))
            {
                if ((((owner is Table) && picture.LayoutInCell) && !(owner as Table).IsSDTTable) || (owner.Owner == null))
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                section = owner as Section;
                left = section.PageSetup.Margins.Left;
                right = section.PageSetup.Margins.Right;
                top = section.PageSetup.Margins.Top;
                bottom = section.PageSetup.Margins.Bottom;
                footerDistance = section.PageSetup.FooterDistance;
                headerDistance = section.PageSetup.HeaderDistance;
                float num28 = (base.method_4().method_28() != null) ? (base.method_4().method_28().method_49() - footerDistance) : 0f;
                bottom = (num28 > 0f) ? ((bottom >= footerDistance) ? bottom : footerDistance) : bottom;
                float num29 = (base.method_4().method_28() != null) ? base.method_4().method_28().method_47() : 0f;
                top = Math.Max(num29, top);
                height = section.PageSetup.PageSize.Height;
                width = section.PageSetup.PageSize.Width;
                clientWidth = section.PageSetup.ClientWidth;
                num14 = (float) base.class774_0.method_3();
                if (section.Columns.Count > 1)
                {
                    flag2 = false;
                }
            }
        }
        if (picture.TextWrappingStyle == TextWrappingStyle.Inline)
        {
            flag = false;
            goto Label_0B95;
        }
        bool flag4 = false;
        Paragraph paragraph3 = picture.method_106();
        if ((paragraph3.IsInCell && picture.LayoutInCell) && !(paragraph3.Owner.Owner.Owner as Table).IsSDTTable)
        {
            flag4 = true;
            verticalPosition = this.method_70(picture) + picture.EffectExtentTop;
            horizontalPosition = this.method_71(picture) + picture.EffectExtentLeft;
            (picture.OwnerParagraph.OwnerTextBody as TableCell).HasShape = true;
            goto Label_0B95;
        }
        switch (picture.VerticalOrigin)
        {
            case VerticalOrigin.Margin:
                verticalPosition = top + picture.VerticalPosition;
                switch (picture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.Top:
                        verticalPosition = (picture.VerticalPosition + top) - base.method_2().imethod_0().method_4();
                        break;

                    case ShapeVerticalAlignment.Center:
                        verticalPosition = (top + ((num14 - num16) / 2f)) - base.method_2().imethod_0().method_4();
                        break;

                    case ShapeVerticalAlignment.Bottom:
                        verticalPosition = (num14 - num16) - base.method_2().imethod_0().method_4();
                        break;

                    case ShapeVerticalAlignment.Inside:
                        verticalPosition = (picture.VerticalPosition + top) - base.method_2().imethod_0().method_4();
                        break;

                    case ShapeVerticalAlignment.Outside:
                        verticalPosition = (num14 - num16) - base.method_2().imethod_0().method_4();
                        break;
                }
                goto Label_0656;

            case VerticalOrigin.Page:
                verticalPosition = picture.VerticalPosition;
                switch (picture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.Top:
                        verticalPosition = 0.0;
                        break;

                    case ShapeVerticalAlignment.Center:
                        verticalPosition = (height - num16) / 2f;
                        break;

                    case ShapeVerticalAlignment.Bottom:
                        verticalPosition = height - num16;
                        break;

                    case ShapeVerticalAlignment.Inside:
                        verticalPosition = headerDistance;
                        break;

                    case ShapeVerticalAlignment.Outside:
                        verticalPosition = (height - bottom) - num16;
                        break;
                }
                goto Label_0656;

            case VerticalOrigin.Paragraph:
            case VerticalOrigin.Line:
                if (paragraph3 == null)
                {
                    verticalPosition = base.class774_0.method_11().Y + picture.VerticalPosition;
                }
                else
                {
                    verticalPosition = (((Interface1) paragraph3).imethod_0() as Class210).method_57() + picture.VerticalPosition;
                }
                goto Label_0656;

            case VerticalOrigin.TopMarginArea:
                verticalPosition = picture.VerticalPosition;
                if (picture.VerticalAlignment == ShapeVerticalAlignment.None)
                {
                }
                goto Label_0656;

            case VerticalOrigin.BottomMarginArea:
                num22 = 0f;
                if (!base.method_4().method_135())
                {
                    num22 = base.method_4().method_28().method_3().method_4(1).method_69().Height;
                    break;
                }
                num22 = footerDistance;
                break;

            default:
                verticalPosition = (base.class774_0.method_11().Y - base.method_2().imethod_0().method_4()) + picture.VerticalPosition;
                goto Label_0656;
        }
        verticalPosition = (height - num22) - base.method_2().imethod_0().method_4();
        switch (picture.VerticalAlignment)
        {
            case ShapeVerticalAlignment.Top:
                verticalPosition = (height - num22) - base.method_2().imethod_0().method_4();
                break;

            case ShapeVerticalAlignment.Center:
                verticalPosition = ((height - num22) + ((num22 - num16) / 2f)) - base.method_2().imethod_0().method_4();
                break;

            case ShapeVerticalAlignment.Bottom:
                verticalPosition = (height - num16) - base.method_2().imethod_0().method_4();
                break;

            case ShapeVerticalAlignment.Inside:
                verticalPosition = (height - num22) - base.method_2().imethod_0().method_4();
                break;

            case ShapeVerticalAlignment.Outside:
                verticalPosition = (height - num16) - base.method_2().imethod_0().method_4();
                break;
        }
    Label_0656:
        switch (picture.HorizontalOrigin)
        {
            case HorizontalOrigin.Margin:
                if (section == null)
                {
                    horizontalPosition = base.class774_0.method_11().X + picture.HorizontalPosition;
                    break;
                }
                horizontalPosition = left + picture.HorizontalPosition;
                break;

            case HorizontalOrigin.Page:
                horizontalPosition = picture.HorizontalPosition;
                switch (picture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        if (flag4)
                        {
                            Interface22 interface3 = (picture.OwnerParagraph.OwnerTextBody as TableCell).interface23_0;
                            horizontalPosition = ((((picture.OwnerParagraph.OwnerTextBody as TableCell).interface23_0 as Class211).method_115() - interface3.imethod_1().method_0()) - interface3.imethod_0().method_0()) + picture.HorizontalPosition;
                        }
                        else
                        {
                            horizontalPosition = picture.HorizontalPosition;
                        }
                        break;

                    case ShapeHorizontalAlignment.Left:
                        horizontalPosition = (num15 > left) ? ((double) 0f) : ((double) (left - num15));
                        break;

                    case ShapeHorizontalAlignment.Center:
                        if (flag4)
                        {
                            horizontalPosition = (base.method_4().method_394(picture) - num15) / 2f;
                        }
                        else
                        {
                            horizontalPosition = (width - num15) / 2f;
                        }
                        break;

                    case ShapeHorizontalAlignment.Right:
                        if (flag4)
                        {
                            horizontalPosition = base.method_4().method_394(picture) - num15;
                        }
                        else
                        {
                            horizontalPosition = (num15 < right) ? ((double) (width - right)) : ((double) (width - num15));
                        }
                        break;
                }
                if ((horizontalPosition < 0.0) && flag4)
                {
                    Interface22 interface4 = (picture.OwnerParagraph.OwnerTextBody as TableCell).interface23_0;
                    horizontalPosition = (((picture.OwnerParagraph.OwnerTextBody as TableCell).interface23_0 as Class211).method_115() - interface4.imethod_1().method_0()) - interface4.imethod_0().method_0();
                }
                goto Label_0B95;

            case HorizontalOrigin.Column:
            {
                float x = 0f;
                bool flag5 = false;
                if (section == null)
                {
                    x = base.method_4().method_28().method_65(paragraph3, new PointF(base.class774_0.method_11().X, (float) verticalPosition), base.method_4(), new PointF(), ref flag5);
                    if ((x != 0f) && !flag5)
                    {
                        horizontalPosition = x + picture.HorizontalPosition;
                    }
                    else
                    {
                        horizontalPosition = base.class774_0.method_11().X + picture.HorizontalPosition;
                        x = base.class774_0.method_11().X;
                    }
                }
                else
                {
                    if (!paragraph3.Format.IsFrame || ((this.method_30().method_5().method_73().imethod_0() as Class213).method_59() == float.MinValue))
                    {
                        x = base.method_4().method_28().method_65(paragraph3, new PointF(section.PageSetup.Margins.Left, (float) verticalPosition), base.method_4(), new PointF(), ref flag5);
                        if ((section.Columns.Count > 1) && (base.method_14().imethod_4() > 0))
                        {
                            float num23 = base.method_4().method_28().method_87(base.method_14().imethod_4());
                            if (Class59.smethod_5((double) num23, (double) x, 0.005) > 0)
                            {
                                x = num23;
                            }
                        }
                    }
                    else
                    {
                        x = (this.method_30().method_5().method_73().imethod_0() as Class213).method_59();
                    }
                    if ((x != 0f) && !flag5)
                    {
                        horizontalPosition = x + picture.HorizontalPosition;
                    }
                    else
                    {
                        horizontalPosition = section.PageSetup.Margins.Left + picture.HorizontalPosition;
                        x = section.PageSetup.Margins.Left;
                    }
                }
                if (flag2)
                {
                    switch (picture.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.Left:
                            horizontalPosition = x;
                            break;

                        case ShapeHorizontalAlignment.Center:
                            horizontalPosition = x + ((clientWidth - num15) / 2f);
                            break;

                        case ShapeHorizontalAlignment.Right:
                            horizontalPosition = (x + clientWidth) - num15;
                            break;
                    }
                }
                goto Label_0B95;
            }
            case HorizontalOrigin.LeftMarginArea:
                horizontalPosition = picture.HorizontalPosition;
                switch (picture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.Left:
                        horizontalPosition = 0.0;
                        break;

                    case ShapeHorizontalAlignment.Center:
                        horizontalPosition = (left - num15) / 2f;
                        break;

                    case ShapeHorizontalAlignment.Right:
                        horizontalPosition = left - num15;
                        break;
                }
                goto Label_0B95;

            case HorizontalOrigin.RightMarginArea:
            {
                float num27 = width - right;
                horizontalPosition = num27 + picture.HorizontalPosition;
                switch (picture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.Left:
                        horizontalPosition = 0.0;
                        break;

                    case ShapeHorizontalAlignment.Center:
                        horizontalPosition = (right - num15) / 2f;
                        break;

                    case ShapeHorizontalAlignment.Right:
                        horizontalPosition = num27 - num15;
                        break;
                }
                goto Label_0B95;
            }
            default:
                horizontalPosition = base.class774_0.method_11().X + picture.HorizontalPosition;
                goto Label_0B95;
        }
        if (flag2)
        {
            switch (picture.HorizontalAlignment)
            {
                case ShapeHorizontalAlignment.Center:
                    horizontalPosition = left + ((clientWidth - num15) / 2f);
                    break;

                case ShapeHorizontalAlignment.Right:
                    horizontalPosition = base.class774_0.method_11().Right - num15;
                    break;
            }
        }
    Label_0B95:
        if (picture.TextWrappingStyle == TextWrappingStyle.Square)
        {
            horizontalPosition -= picture.EffectExtentLeft;
            num += picture.EffectExtentLeft;
            verticalPosition -= picture.EffectExtentTop;
            num2 += picture.EffectExtentTop;
        }
        else if ((picture.TextWrappingStyle != TextWrappingStyle.Behind) && (picture.TextWrappingStyle != TextWrappingStyle.InFrontOfText))
        {
            horizontalPosition += picture.EffectExtentLeft;
            verticalPosition += picture.EffectExtentTop;
        }
    Label_0BF7:
        num = this.method_73(num, A_1);
        ParagraphBase base2 = A_1 as ParagraphBase;
        if (A_1 is Class542)
        {
            base2 = (A_1 as Class542).method_2() as ParagraphBase;
        }
        Paragraph ownerParagraph = base2.OwnerParagraph;
        if (base2.Owner is SDTInlineContent)
        {
            ownerParagraph = (base2.Owner as SDTInlineContent).OwnerParagraph;
        }
        bool flag3 = (A_1 is DocPicture) ? (((ownerParagraph.IsInCell && (A_1 as DocPicture).LayoutInCell) && ((A_1 as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind)) && ((A_1 as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText)) : true;
        if (A_1 is DocPicture)
        {
            num += picture.EffectExtentRight;
            num2 += picture.EffectExtentBottom;
        }
        if (flag3 && (num2 > base.class774_0.method_11().Height))
        {
            num2 = base.class774_0.method_11().Height;
        }
        if ((base.method_2().imethod_30() && (A_1 is DocPicture)) && (((this.method_29() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline) && (num2 > base.class774_0.method_11().Width)))
        {
            Interface23 interface2 = (ownerParagraph.OwnerTextBody as TableCell).interface23_0;
            num2 = ((base.class774_0.method_11().Width + ownerParagraph.interface23_0.imethod_1().method_8()) - (2.0 * (interface2.imethod_1().method_4() + interface2.imethod_1().method_12()))) - (interface2.imethod_1().method_0() + interface2.imethod_1().method_8());
        }
        base.class375_0 = new Class375(A_1);
        if (!flag)
        {
            base.class375_0.method_70(new RectangleF((float) ((base.class774_0.method_11().X - base.method_2().imethod_0().method_0()) + horizontalPosition), (float) ((base.class774_0.method_11().Y - base.method_2().imethod_0().method_4()) + verticalPosition), (float) num, (float) num2));
        }
        else
        {
            base.class375_0.method_70(new RectangleF((float) (horizontalPosition - base.method_2().imethod_0().method_0()), (float) (verticalPosition - base.method_2().imethod_0().method_4()), (float) num, (float) num2));
        }
        base.class375_0.method_49((base.interface30_0 as Class304).method_11().method_0());
        if (A_1 is DocPicture)
        {
            if (!(A_1 as DocPicture).Borders.NoBorder)
            {
                Borders borders = (A_1 as DocPicture).Borders;
                float num25 = (borders.Left.LineWidth + borders.Left.Space) + (borders.Right.LineWidth + borders.Right.Space);
                float num26 = (borders.Top.LineWidth + borders.Top.Space) + (borders.Bottom.LineWidth + borders.Bottom.Space);
                base.class375_0.method_70(new RectangleF(base.class375_0.method_69().Location, new SizeF(base.class375_0.method_69().Width + num25, base.class375_0.method_69().Height + num26)));
            }
            if (!this.method_30().method_10())
            {
                (A_1 as DocPicture).InTableCellBounds = base.class375_0.method_69();
                if ((((((((A_1 as DocPicture).ShapeInfo != null) && ((A_1 as DocPicture).ShapeInfo.ParentContainer != null)) && !(((A_1 as DocPicture).ShapeInfo.ParentContainer as ParagraphBase).interface23_0 as Class205).method_9()) || ((((A_1 as DocPicture).ShapeInfo != null) && ((A_1 as DocPicture).ShapeInfo.interface23_0 != null)) && !((A_1 as DocPicture).ShapeInfo.interface23_0 as Class205).method_9())) || (((A_1 as DocPicture).ShapeInfo == null) && !((A_1 as DocPicture).interface23_0 as Class205).method_9())) && ((((A_1 as DocPicture).OwnerParagraph != null) && !(A_1 as DocPicture).OwnerParagraph.IsInCell) && (((A_1 as DocPicture).TextWrappingStyleEx != TextWrappingStyle.Inline) && ((A_1 as DocPicture).TextWrappingStyleEx != TextWrappingStyle.Behind)))) && ((((A_1 as DocPicture).TextWrappingStyleEx != TextWrappingStyle.InFrontOfText) && !(A_1 as DocPicture).IsHeaderPicture) && ((base.class774_0.method_11().Y - base.class375_0.method_69().Y) > 1f)))
                {
                    base.class375_0.method_35(true);
                    ((A_1 as DocPicture).interface23_0 as Class205).method_10(true);
                    if (((A_1 as DocPicture).ShapeInfo != null) && ((A_1 as DocPicture).ShapeInfo.ParentContainer != null))
                    {
                        (((A_1 as DocPicture).ShapeInfo.ParentContainer as ParagraphBase).interface23_0 as Class205).method_10(true);
                    }
                    else if (((A_1 as DocPicture).ShapeInfo != null) && ((A_1 as DocPicture).ShapeInfo.interface23_0 != null))
                    {
                        ((A_1 as DocPicture).ShapeInfo.interface23_0 as Class205).method_10(true);
                    }
                    (A_1 as DocPicture).Document.LayoutVariables.method_0().Add((A_1 as DocPicture).OwnerParagraph);
                }
            }
            else if (((this.method_30().method_10() && !(A_1 as DocPicture).InTableCellBounds.IsEmpty) && (((A_1 as DocPicture).TextWrappingStyleEx != TextWrappingStyle.Inline) && ((A_1 as DocPicture).TextWrappingStyleEx != TextWrappingStyle.Behind))) && ((((A_1 as DocPicture).TextWrappingStyleEx != TextWrappingStyle.InFrontOfText) && ((A_1 as DocPicture).VerticalOrigin == VerticalOrigin.Paragraph)) && ((A_1 as DocPicture).VerticalPosition < 0f)))
            {
                base.class375_0.method_70((A_1 as DocPicture).InTableCellBounds);
            }
            if ((A_1 as DocPicture).ShapeInfo != null)
            {
                (A_1 as DocPicture).ShapeInfo.StartPoint = base.class375_0.method_69().Location;
            }
            float wrapDistanceTop = (A_1 as DocPicture).WrapDistanceTop;
            float wrapDistanceBottom = (A_1 as DocPicture).WrapDistanceBottom;
            float wrapDistanceLeft = (A_1 as DocPicture).WrapDistanceLeft;
            float wrapDistanceRight = (A_1 as DocPicture).WrapDistanceRight;
            Class312 class2 = new Class312();
            class2.method_1(new RectangleF(base.class375_0.method_69().X - wrapDistanceLeft, base.class375_0.method_69().Y - wrapDistanceTop, (base.class375_0.method_69().Width + wrapDistanceLeft) + wrapDistanceRight, (base.class375_0.method_69().Height + wrapDistanceTop) + wrapDistanceBottom));
            class2.method_11((A_1 as DocPicture).WrapPolygonEx);
            class2.method_2().method_1((A_1 as DocPicture).TextWrappingStyle);
            class2.method_2().method_3((A_1 as DocPicture).TextWrappingType);
            class2.method_5(A_1);
            class2.method_17((A_1 as DocPicture).LayoutInCell);
            class2.method_15((A_1 as DocPicture).AllowOverlap);
            class2.method_21(base.method_4().method_138());
            class2.method_23(base.method_4().method_137());
            Paragraph paragraph = (A_1 as DocPicture).method_106();
            class2.method_7(((paragraph == null) || !paragraph.IsInCell) ? null : (paragraph.Owner as TableCell));
            if (((class2.method_2().method_0() != TextWrappingStyle.Inline) && (class2.method_2().method_0() != TextWrappingStyle.Behind)) && (class2.method_2().method_0() != TextWrappingStyle.InFrontOfText))
            {
                base.method_4().method_28().method_40(class2);
            }
            long num24 = (A_1 as DocPicture).HasImage ? (A_1 as DocPicture).ZOrderEx : (((A_1 as DocPicture).ShapeInfo != null) ? (A_1 as DocPicture).ShapeInfo.ZOrderEx : 0L);
            if (!base.class375_0.method_34())
            {
                Class199 class3 = new Class199();
                class3.method_1(A_1 as DocPicture);
                class3.method_5(true);
                class3.method_3(base.class375_0);
                class3.method_9(base.method_4().method_135());
                class3.method_7(num24);
                if ((class2.method_2().method_0() == TextWrappingStyle.InFrontOfText) || (class2.method_2().method_0() == TextWrappingStyle.TopAndBottom))
                {
                    base.method_4().method_28().method_41(class3);
                }
                else if ((class2.method_2().method_0() == TextWrappingStyle.Behind) || (class3.method_0().TextWrappingStyleEx == TextWrappingStyle.Behind))
                {
                    base.method_4().method_28().method_44(class3);
                }
                else if ((num24 > 0L) && (class2.method_2().method_0() != TextWrappingStyle.Inline))
                {
                    base.method_4().method_28().method_41(class3);
                }
                else if ((num24 < 0L) && (class2.method_2().method_0() != TextWrappingStyle.Inline))
                {
                    base.method_4().method_28().method_44(class3);
                }
            }
        }
    }

    private double method_70(DocPicture A_0)
    {
        Paragraph ownerParagraph;
        DocumentObject owner;
        double num = 0.0;
        double num2 = ((A_0.OwnerParagraph.OwnerTextBody as TableCell).interface23_0 as Class211).method_117();
        switch (A_0.VerticalOrigin)
        {
            case VerticalOrigin.Margin:
            case VerticalOrigin.Page:
                num = num2 + A_0.VerticalPosition;
                goto Label_00E0;

            case VerticalOrigin.Paragraph:
                ownerParagraph = A_0.OwnerParagraph;
                if (ownerParagraph != null)
                {
                    goto Label_00A3;
                }
                owner = A_0.Owner;
                while (owner != null)
                {
                    if (owner is Paragraph)
                    {
                        break;
                    }
                    owner = owner.Owner;
                }
                break;

            default:
                num = base.class774_0.method_11().Y + A_0.VerticalPosition;
                goto Label_00E0;
        }
        ownerParagraph = owner as Paragraph;
    Label_00A3:
        if (ownerParagraph != null)
        {
            num = (((Interface1) ownerParagraph).imethod_0() as Class210).method_57() + A_0.VerticalPosition;
        }
        else
        {
            num = base.class774_0.method_11().Y + A_0.VerticalPosition;
        }
    Label_00E0:
        if ((A_0.TextWrappingStyle != TextWrappingStyle.Behind) && (A_0.TextWrappingStyle != TextWrappingStyle.InFrontOfText))
        {
            num = (num < num2) ? num2 : num;
        }
        return num;
    }

    private double method_71(DocPicture A_0)
    {
        double horizontalPosition = 0.0;
        TableCell ownerTextBody = A_0.OwnerParagraph.OwnerTextBody as TableCell;
        Interface22 interface2 = ownerTextBody.interface23_0;
        double layoutWidth = ownerTextBody.LayoutWidth;
        double num3 = (ownerTextBody.interface23_0 as Class211).method_115() - interface2.imethod_0().method_0();
        float left = (A_0.OwnerParagraph.Owner.Owner.Owner as Table).TableBounds.Left;
        double num4 = (A_0.Width * A_0.WidthScale) / 100f;
        switch (A_0.HorizontalOrigin)
        {
            case HorizontalOrigin.Margin:
            case HorizontalOrigin.Column:
                switch (A_0.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        horizontalPosition = (num3 + interface2.imethod_0().method_0()) + A_0.HorizontalPosition;
                        goto Label_01D9;

                    case ShapeHorizontalAlignment.Left:
                        horizontalPosition = num3 + interface2.imethod_0().method_0();
                        goto Label_01D9;

                    case ShapeHorizontalAlignment.Center:
                        horizontalPosition = (num3 + interface2.imethod_0().method_0()) + ((((layoutWidth - interface2.imethod_0().method_0()) - interface2.imethod_0().method_8()) - num4) / 2.0);
                        goto Label_01D9;

                    case ShapeHorizontalAlignment.Right:
                        horizontalPosition = (num3 + interface2.imethod_0().method_0()) + (((layoutWidth - interface2.imethod_0().method_0()) - interface2.imethod_0().method_8()) - num4);
                        goto Label_01D9;
                }
                break;

            case HorizontalOrigin.Page:
                horizontalPosition = A_0.HorizontalPosition;
                switch (A_0.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        horizontalPosition = num3 + A_0.HorizontalPosition;
                        goto Label_01D9;

                    case ShapeHorizontalAlignment.Left:
                        horizontalPosition = num3;
                        goto Label_01D9;

                    case ShapeHorizontalAlignment.Center:
                        horizontalPosition = num3 + ((layoutWidth - num4) / 2.0);
                        goto Label_01D9;

                    case ShapeHorizontalAlignment.Right:
                        horizontalPosition = num3 + (layoutWidth - num4);
                        goto Label_01D9;
                }
                break;

            default:
                horizontalPosition = (num3 + interface2.imethod_0().method_0()) + A_0.HorizontalPosition;
                break;
        }
    Label_01D9:
        if ((A_0.HorizontalOrigin != HorizontalOrigin.Column) && (A_0.HorizontalOrigin != HorizontalOrigin.Margin))
        {
            return horizontalPosition;
        }
        if ((A_0.TextWrappingStyle == TextWrappingStyle.Behind) || (A_0.TextWrappingStyle == TextWrappingStyle.InFrontOfText))
        {
            return horizontalPosition;
        }
        if ((horizontalPosition >= num3) && (num4 <= layoutWidth))
        {
            if ((num4 < layoutWidth) && ((horizontalPosition + num4) > (num3 + layoutWidth)))
            {
                horizontalPosition = (num3 + layoutWidth) - num4;
            }
            return horizontalPosition;
        }
        return num3;
    }

    private void method_72()
    {
        if (((base.class375_0.method_73() is TextRange) && ((base.class375_0.method_73() as TextRange).OwnerParagraph != null)) && (base.class375_0.method_73() as TextRange).OwnerParagraph.IsInCell)
        {
            ParagraphFormat format = (base.method_8() as TextRange).OwnerParagraph.Format;
            TableCell owner = (base.method_8() as TextRange).OwnerParagraph.Owner as TableCell;
            Interface23 interface2 = ((Interface1) owner).imethod_0();
            if (base.class375_0.method_69().X < (interface2 as Class211).method_115())
            {
                float num = 0f;
                if (owner.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
                {
                    num = owner.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
                }
                float num2 = ((float) (interface2.imethod_0().method_0() + interface2.imethod_1().method_0())) - num;
                base.class375_0.method_29(((interface2 as Class211).method_115() - base.class375_0.method_69().X) - num2);
            }
        }
    }

    private double method_73(double A_0, Interface1 A_1)
    {
        ParagraphBase base2 = A_1 as ParagraphBase;
        if (A_1 is Class542)
        {
            base2 = (A_1 as Class542).method_2() as ParagraphBase;
        }
        Paragraph ownerParagraph = base2.OwnerParagraph;
        if (base2.Owner is SDTInlineContent)
        {
            ownerParagraph = base2.Owner.Owner.Owner as Paragraph;
        }
        if (((!(A_1 is DocPicture) && (A_0 > base.class774_0.method_11().Width)) && (base.class774_0.method_11().Width > 0f)) && ((((base.interface30_0 as Class304).method_11().method_0() != TabJustification.Right) && ((base.interface30_0 as Class304).method_11().method_0() != TabJustification.Centered)) || (this.method_61() && ((base.interface30_0 as Class304).method_11().method_0() == TabJustification.Right))))
        {
            return (double) base.class774_0.method_11().Width;
        }
        if ((((A_1 is DocPicture) && (A_1 as DocPicture).LayoutInCell) && (base.method_2().imethod_2() && (A_0 > (base.class774_0.method_13().Width + (ownerParagraph.Owner as TableCell).interface23_0.imethod_0().method_8())))) && !base.method_2().imethod_30())
        {
            return (base.class774_0.method_11().Width + (ownerParagraph.Owner as TableCell).interface23_0.imethod_0().method_8());
        }
        if ((((A_1 is DocPicture) && (A_1 as DocPicture).LayoutInCell) && (base.method_2().imethod_2() && (A_0 > (base.class774_0.method_13().Height + (ownerParagraph.Owner as TableCell).interface23_0.imethod_0().method_12())))) && base.method_2().imethod_30())
        {
            return (base.class774_0.method_11().Height + (ownerParagraph.Owner as TableCell).interface23_0.imethod_0().method_12());
        }
        return A_0;
    }

    private void method_74(Interface19[] A_0)
    {
        TextRange range = (A_0[0] as Class542).method_2() as TextRange;
        if (((A_0 != null) && (range != null)) && ((range.interface23_0 != null) && (range.interface23_0 as Class205).method_12()))
        {
            string str2 = (A_0[0] is Class542) ? (A_0[0] as Class542).method_0() : ((A_0[0] is TextRange) ? (A_0[0] as TextRange).TextToSplit : null);
            string str = (A_0[1] is Class542) ? (A_0[1] as Class542).method_0() : ((A_0[1] is TextRange) ? (A_0[1] as TextRange).TextToSplit : null);
            if (string.IsNullOrEmpty(str2))
            {
                (A_0[1] as Class542).method_3().AddRange((((A_0[1] as Class542).method_2() as TextRange).interface23_0 as Class205).method_11());
            }
            else if (!string.IsNullOrEmpty(str))
            {
                int num = range.Text.LastIndexOf(str);
                for (int i = 0; i < (range.interface23_0 as Class205).method_11().Count; i++)
                {
                    if (num <= (range.interface23_0 as Class205).method_11()[i].method_0())
                    {
                        List<Class216> collection = new List<Class216>();
                        collection.AddRange((range.interface23_0 as Class205).method_11().GetRange(i, (range.interface23_0 as Class205).method_11().Count - i));
                        for (int j = collection.Count - 1; j >= 0; j--)
                        {
                            Class216 local1 = collection[j];
                            local1.method_1(local1.method_0() - num);
                        }
                        (A_0[1] as Class542).method_3().AddRange(collection);
                        List<Class216> list2 = new List<Class216>();
                        list2.AddRange(range.CompressedPunctuations.GetRange(0, (range.interface23_0 as Class205).method_11().Count - collection.Count));
                        (A_0[0] as Class542).method_3().AddRange(list2);
                        return;
                    }
                }
            }
        }
    }

    private void method_75(Interface19 A_0, float A_1)
    {
        int num = 0x11;
        Interface19[] interfaceArray = null;
        if (base.method_2() is Class206)
        {
            string str2 = (A_0 is Class542) ? (A_0 as Class542).method_0() : ((A_0 is TextRange) ? (A_0 as TextRange).TextToSplit : string.Empty);
            if (A_0 is Class542)
            {
                interfaceArray = new Interface19[] { new Class542((A_0 as Class542).method_2(), string.Empty), new Class542((A_0 as Class542).method_2(), str2) };
            }
            else
            {
                interfaceArray = new Interface19[] { new Class542(A_0 as Interface21, string.Empty), new Class542(A_0 as Interface21, str2) };
            }
        }
        else
        {
            interfaceArray = A_0.imethod_4(base.method_4(), base.class774_0.method_13().Size, (base.interface30_0 as Class304).method_4().Width, A_1);
        }
        base.layoutState_0 = LayoutState.NotFitted;
        if (interfaceArray != null)
        {
            SizeF ef;
            this.method_74(interfaceArray);
            string str = (interfaceArray[0] is Class542) ? (interfaceArray[0] as Class542).method_0() : ((interfaceArray[0] is TextRange) ? (interfaceArray[0] as TextRange).TextToSplit : null);
            if (!string.IsNullOrEmpty(str))
            {
                ef = interfaceArray[0].imethod_3(base.method_4());
            }
            else
            {
                TextRange range = (A_0 is TextRange) ? (A_0 as TextRange) : ((!(A_0 is Class542) || !((A_0 as Class542).method_2() is TextRange)) ? null : ((A_0 as Class542).method_2() as TextRange));
                TextRange range2 = new TextRange(range.Document);
                range2.CharacterFormat.method_25(range.CharacterFormat);
                Class542 class2 = new Class542(range2, "");
                ParagraphBase previousSibling = range.PreviousSibling as ParagraphBase;
                if (previousSibling != null)
                {
                    (class2.method_2() as TextRange).CharacterFormat.FontSize = Math.Min(range.CharacterFormat.FontSize, previousSibling.CharacterFormat.FontSize);
                }
                (class2.method_2() as TextRange).interface23_0 = range.interface23_0;
                interfaceArray[0] = class2;
                ef = base.method_4().method_323(class2.method_2() as TextRange, BookmarkStart.b("᜶", num));
                ef.Width = 0f;
            }
            if (!base.class774_0.method_20(ef))
            {
                if (this.method_50())
                {
                    base.layoutState_0 = LayoutState.NotFitted;
                    base.bool_3 = ef.Height > base.class774_0.method_11().Height;
                    return;
                }
                if ((interfaceArray[0] is Class542) && string.IsNullOrEmpty((interfaceArray[0] as Class542).method_0()))
                {
                    ef.Width = base.class774_0.method_11().Width;
                }
            }
            this.method_69(ef, interfaceArray[0]);
            if (interfaceArray[1] == null)
            {
                base.layoutState_0 = LayoutState.Fitted;
            }
            else
            {
                base.interface1_0 = interfaceArray[1];
                base.layoutState_0 = LayoutState.Splitted;
            }
        }
    }

    public override Class375 vmethod_0(RectangleF A_0)
    {
        SizeF pageSize;
        bool flag;
        int num = 11;
        base.method_16(A_0);
        float width = A_0.Width;
        Interface2 interface2 = this.method_29();
        if (((this.method_29() is ShapeObject) && ((this.method_29() as ShapeObject).TextWrappingStyle != TextWrappingStyle.Inline)) || (((this.method_29() is Class6) && ((this.method_29() as Class6).method_32() != null)) && (((this.method_29() as Class6).method_32().TextWrappingStyle == TextWrappingStyle.Behind) || ((this.method_29() as Class6).method_32().TextWrappingStyle == TextWrappingStyle.InFrontOfText))))
        {
            Paragraph paragraph = (this.method_29() as ParagraphBase).method_28();
            TextRange range = paragraph.method_54();
            pageSize = base.method_4().method_323(range, BookmarkStart.b("ᄰ", num));
            float height = pageSize.Height;
            switch (paragraph.Format.LineSpacingRule)
            {
                case LineSpacingRule.AtLeast:
                    height = Math.Max(paragraph.Format.LineSpacing, height);
                    break;

                case LineSpacingRule.Exactly:
                    height = paragraph.Format.LineSpacing;
                    break;
            }
            if (paragraph.IsInCell)
            {
                TableCell cell = paragraph.method_50();
                if (cell.OwnerRow.RowFormat.HeightType == TableRowHeightType.Exactly)
                {
                    height = Math.Min(height, cell.OwnerRow.RowFormat.Height);
                }
            }
            if (Class59.smethod_1((double) height, (double) A_0.Height, false) > 0)
            {
                base.layoutState_0 = LayoutState.NotFitted;
                base.bool_3 = height > base.class774_0.method_11().Height;
                return base.class375_0;
            }
        }
        SizeF empty = SizeF.Empty;
        SizeF ef4 = interface2.imethod_3(base.method_4());
        if (((interface2 is Footnote) && ((interface2 as Footnote).FootnoteType == FootnoteType.Footnote)) && !(interface2.imethod_0() as Class205).method_5())
        {
            Paragraph ownerParagraph = (interface2 as Footnote).OwnerParagraph;
            Section section = ownerParagraph.method_49();
            Class615 class2 = Class615.smethod_0((interface2 as Footnote).TextBody, base.method_14(), A_0.Width);
            RectangleF ef5 = base.method_4().method_28().method_81();
            if ((section.Columns.Count == 1) && (section.Columns[0].Width != 0f))
            {
                ef5.Width = section.Columns[0].Width;
            }
            else
            {
                ef5.Width = base.method_4().method_128().method_11().Width;
            }
            Class375 item = class2.vmethod_0(ef5);
            (interface2.imethod_0() as Class209).method_14(item.method_69().Height);
            empty = item.method_69().Size;
            if (!base.method_4().method_28().method_4().Contains(item))
            {
                base.method_4().method_28().method_4().method_7(item);
            }
            (section.interface23_0 as Class205).method_4(true);
            (ownerParagraph.interface23_0 as Class205).method_4(true);
            (interface2.imethod_0() as Class205).method_6(true);
            if (ownerParagraph.IsInCell)
            {
                ((ownerParagraph.Owner.Owner as TableRow).interface23_0 as Class205).method_4(true);
                Class205 class1 = (ownerParagraph.Owner.Owner as TableRow).interface23_0 as Class205;
                class1.method_8(class1.method_7() + item.method_69().Height);
                ((ownerParagraph.Owner.Owner as TableRow).OwnerTable.interface23_0 as Class205).method_4(true);
                Class205 class11 = (ownerParagraph.Owner.Owner as TableRow).OwnerTable.interface23_0 as Class205;
                class11.method_8(class11.method_7() + item.method_69().Height);
            }
        }
        if ((interface2 is Break) && ((interface2 as Break).BreakType == BreakType.ColumnBreak))
        {
            ef4 = new SizeF(0f, A_0.Height);
            Section section2 = (interface2 as Break).method_2();
            if (section2 != null)
            {
                ((Interface1) section2).imethod_0().imethod_49(true);
            }
        }
        this.method_67(interface2, ef4, ref A_0);
        if (this.method_29() is TextRange)
        {
            base.class375_0 = this.method_60(A_0, ef4);
            if (base.class375_0 != null)
            {
                return base.class375_0;
            }
        }
        TextRange range2 = (this.method_29() is TextRange) ? (this.method_29() as TextRange) : ((!(this.method_29() is Class542) || !((this.method_29() as Class542).method_2() is TextRange)) ? null : ((this.method_29() as Class542).method_2() as TextRange));
        Class206 class4 = interface2.imethod_0() as Class206;
        if (class4 != null)
        {
            if (range2 != null)
            {
                Paragraph paragraph3 = (range2.OwnerParagraph != null) ? range2.OwnerParagraph : ((range2.OwnerEmptyParagraph != null) ? range2.OwnerEmptyParagraph : null);
                if (((paragraph3 != null) && paragraph3.Format.IsFrame) && ((paragraph3.interface23_0 as Class210).method_59() != float.MinValue))
                {
                    class4.method_27(paragraph3, (paragraph3.interface23_0 as Class210).method_59(), class4);
                }
            }
            this.method_45(ref A_0, ref ef4);
            if ((base.interface30_0 as Class304).method_3() || (base.interface30_0 as Class304).method_5())
            {
                range2.Text = BookmarkStart.b("㠰", num);
            }
        }
        if (base.method_2().imethod_2() && (base.class774_0.method_3() != 0.0))
        {
            base.class774_0.method_2();
        }
        float num4 = A_0.X + ef4.Width;
        SizeF ef6 = ef4;
        ef6.Height += empty.Height;
        if ((empty.Height != 0f) && (base.method_4().method_28().method_4().Count == 1))
        {
            ef6.Height += 12f;
        }
        if (range2 != null)
        {
            string str = (this.method_29() is TextRange) ? (this.method_29() as TextRange).Text : (this.method_29() as Class542).method_0();
            Paragraph paragraph4 = range2.OwnerParagraph;
            if (((range2.StartPos == 0) && !string.IsNullOrEmpty(str)) && ((str == range2.Text) && (paragraph4 != null)))
            {
                Class213 class5 = ((Interface1) paragraph4).imethod_0() as Class213;
                ef6.Width += class5.method_69();
            }
        }
        bool flag2 = (((!(flag = this.method_49(ef6)) || (((class4 != null) && (num4 <= class4.class215_0.method_4())) && (ef4.Height <= base.class774_0.method_11().Height))) || (!flag || (((class4 != null) && (num4 <= class4.class215_0.method_4())) && (ef4.Height <= base.class774_0.method_11().Height)))) || (!flag || ((ef4.Width < base.class774_0.method_11().Width) && (ef4.Height <= base.class774_0.method_11().Height)))) || (((interface2 is Symbol) && (ef4.Width < base.class774_0.method_11().Width)) && (ef4.Height <= base.class774_0.method_11().Height));
        if ((base.class774_0.method_13().Width <= 0f) && !flag2)
        {
            Paragraph paragraph5 = this.method_37(interface2);
            object obj2 = interface2;
            if (((paragraph5 != null) && !paragraph5.IsInCell) && (((((obj2 is TextRange) && ((obj2 as TextRange).NextSibling is Field)) && ((((obj2 as TextRange).NextSibling as Field).DocumentObjectType == DocumentObjectType.Field) && ((((obj2 as TextRange).NextSibling as Field).Type == FieldType.FieldPage) || (((obj2 as TextRange).NextSibling as Field).Type == FieldType.FieldNumPages)))) || (((obj2 is Field) && ((obj2 as Field).DocumentObjectType == DocumentObjectType.Field)) && (((obj2 as Field).Type == FieldType.FieldPage) || ((obj2 as Field).Type == FieldType.FieldNumPages)))) || ((((obj2 is TextRange) && ((obj2 as TextRange).NextSibling is FieldMark)) && ((((obj2 as TextRange).NextSibling as FieldMark).Type == FieldMarkType.FieldEnd) && ((obj2 as TextRange).PreviousSibling is FieldMark))) && (((obj2 as TextRange).PreviousSibling as FieldMark).Type == FieldMarkType.FieldSeparator))))
            {
                flag2 = true;
            }
        }
        if (((!flag2 && (interface2 is TextRange)) && (((interface2 as TextRange).OwnerEmptyParagraph != null) && (interface2 as TextRange).OwnerEmptyParagraph.IsInCell)) && (((A_0.Height > 0f) && ((interface2 as TextRange).OwnerEmptyParagraph.OwnerTextBody != null)) && ((interface2 as TextRange).OwnerEmptyParagraph.OwnerTextBody.Items.Count <= 1)))
        {
            flag2 = true;
        }
        if (!flag2 && (A_0.Height < 1f))
        {
            Paragraph ownerEmptyParagraph = null;
            if ((interface2 is TextRange) || ((interface2 is Class542) && ((interface2 as Class542).method_2() is TextRange)))
            {
                TextRange range3 = (interface2 is TextRange) ? (interface2 as TextRange) : ((interface2 as Class542).method_2() as TextRange);
                if (range3.OwnerParagraph != null)
                {
                    ownerEmptyParagraph = range3.OwnerParagraph;
                }
                else if (range3.OwnerEmptyParagraph != null)
                {
                    ownerEmptyParagraph = range3.OwnerEmptyParagraph;
                }
            }
            if (((ownerEmptyParagraph != null) && ownerEmptyParagraph.IsInCell) && (ownerEmptyParagraph.Owner.Owner.Owner as Table).IsFrame)
            {
                flag2 = true;
            }
        }
        if (!flag2 && (interface2 is TextRange))
        {
            string text = (interface2 as TextRange).Text;
            if (((text.Length > 1) && Class203.smethod_1(text[text.Length - 1])) && !Class203.smethod_2(text[text.Length - 1]))
            {
                SizeF ef7 = base.method_4().method_323(interface2 as TextRange, text.Substring(0, text.Length - 1));
                Paragraph paragraph7 = (interface2 as TextRange).OwnerParagraph;
                if (((ef7.Width <= A_0.Width) && (ef7.Height <= A_0.Height)) && ((paragraph7 != null) && paragraph7.Format.OverflowPunc))
                {
                    flag2 = true;
                }
            }
        }
        if (!flag2 && ((interface2 is TextRange) || (interface2 is Class542)))
        {
            string str3 = (interface2 is TextRange) ? (interface2 as TextRange).Text : ((interface2 is Class542) ? (interface2 as Class542).method_0() : null);
            TextRange range4 = (interface2 is TextRange) ? (interface2 as TextRange) : ((interface2 is Class542) ? ((interface2 as Class542).method_2() as TextRange) : null);
            if ((!string.IsNullOrEmpty(str3) && !str3.Contains(BookmarkStart.b("㠰", num))) && ((range4 != null) && (range4.OwnerEmptyParagraph == null)))
            {
                str3 = str3.TrimEnd(new char[] { ' ' });
                SizeF ef8 = base.method_4().method_323(range4, str3);
                if (((((str3.Length > 0) && (A_0.Width > 0f)) && (((A_0.Height > 0f) && (ef8.Width <= A_0.Width)) && (ef8.Height <= A_0.Height))) || (((str3.Length <= 0) && (A_0.Height > 0f)) && (ef8.Height <= A_0.Height))) && (!str3.Contains(BookmarkStart.b("㬰", num)) && !str3.Contains(BookmarkStart.b("㰰", num))))
                {
                    flag2 = true;
                    interface2.imethod_0().imethod_35(true);
                }
            }
            if (!flag2 && (range4 != null))
            {
                Section section3 = range4.method_2();
                if (((section3 != null) && (Class59.smethod_4(ef4.Height, section3.PageSetup.ClientHeight, 0.005f) > 0)) && (Class59.smethod_4(ef4.Height, base.class774_0.method_11().Height, 0.005f) > 0))
                {
                    flag2 = true;
                }
            }
        }
        if (((flag2 && (interface2 is MergeField)) && (interface2 as MergeField).Text.Contains(BookmarkStart.b("㬰", num))) && (((ef4.Width - base.class774_0.method_11().Width) > 1f) || ((ef4.Height - base.class774_0.method_11().Height) > 1f)))
        {
            flag2 = false;
        }
        if (flag2)
        {
            Class375 class6 = this.method_41(this.method_29(), ef4, A_0, base.class774_0.method_13().Width);
            if (class6 != null)
            {
                return class6;
            }
            if (base.layoutState_0 == LayoutState.NotFitted)
            {
                return class6;
            }
            this.method_69(ef4, interface2);
            string str4 = (interface2 is TextRange) ? (interface2 as TextRange).Text : ((interface2 is Class542) ? (interface2 as Class542).method_0() : null);
            Class312 class7 = base.method_4().method_28().method_51(base.class375_0.method_69(), base.class375_0.method_73());
            IDocumentObject obj3 = (!(this.method_29() is TextRange) || ((this.method_29() as TextRange).PreviousSibling == null)) ? null : (this.method_29() as TextRange).PreviousSibling;
            string str5 = (obj3 is TextRange) ? (obj3 as TextRange).Text : string.Empty;
            if (((((base.class375_0.method_73() is TextRange) || (base.class375_0.method_73() is Class542)) && (!class7.method_0().IsEmpty && (class7.method_2().method_0() != TextWrappingStyle.Inline))) && (((class7.method_2().method_0() != TextWrappingStyle.Behind) && (class7.method_2().method_0() != TextWrappingStyle.InFrontOfText)) && (str4 != null))) && (((!str4.Contains(BookmarkStart.b("㠰", num)) || (str4.Length != 1)) && (((str5 == null) || !str5.Contains(BookmarkStart.b("㠰", num))) || (str5.Length != 1))) && (!(base.class375_0.method_73() is Field) || ((base.class375_0.method_73().imethod_0() is Class214) && !(base.class375_0.method_73().imethod_0() as Class214).method_15()))))
            {
                Interface19 interface4 = this.method_29() as Interface19;
                if ((interface4 != null) && (((ef4.Height <= base.class774_0.method_11().Height) || (Math.Abs((float) (base.class774_0.method_11().Height - ef4.Height)) <= 0.5)) || this.method_50()))
                {
                    this.method_75(interface4, base.class774_0.method_13().Width);
                    RectangleF ef9 = base.class375_0.method_69();
                    if (ef9.Bottom > class7.method_0().Bottom)
                    {
                        float num5 = ef9.Height - (ef9.Bottom - class7.method_0().Bottom);
                        base.class375_0.method_70(new RectangleF(ef9.Location, new SizeF(ef9.Width, num5)));
                    }
                }
                else
                {
                    base.layoutState_0 = LayoutState.NotFitted;
                    base.bool_3 = ef4.Height > base.class774_0.method_11().Height;
                }
            }
            else
            {
                Class210 class8 = base.method_2() as Class210;
                if (((class8 != null) ? class8.method_37() : false) && !base.method_2().imethod_28())
                {
                    base.layoutState_0 = LayoutState.Breaked;
                }
                else
                {
                    base.layoutState_0 = LayoutState.Fitted;
                }
            }
        }
        else
        {
            IDocumentObject obj4 = (!(this.method_29() is TextRange) || ((this.method_29() as TextRange).PreviousSibling == null)) ? null : (this.method_29() as TextRange).PreviousSibling;
            string str6 = (obj4 is TextRange) ? (obj4 as TextRange).Text : string.Empty;
            string str7 = (this.method_29() is TextRange) ? (this.method_29() as TextRange).Text : string.Empty;
            if (((!string.IsNullOrEmpty(str7) && !str7.StartsWith(BookmarkStart.b("ᄰ", num))) && ((str7.Length > 0) && !char.IsPunctuation(str7, 0))) && ((!string.IsNullOrEmpty(str6) && !str6.EndsWith(BookmarkStart.b("ᄰ", num))) && ((str6.Length > 0) && !char.IsPunctuation(str6, str6.Length - 1))))
            {
                float num6 = 0f;
                RectangleF ef10 = A_0;
                RectangleF ef11 = new RectangleF(A_0.Location, ef4);
                Class312 class9 = base.method_4().method_28().method_51(ef11, this.method_29());
                if ((((this.method_29() is TextRange) && !class9.method_0().IsEmpty) && ((class9.method_2().method_0() != TextWrappingStyle.Inline) && (class9.method_2().method_0() != TextWrappingStyle.Behind))) && (class9.method_2().method_0() != TextWrappingStyle.InFrontOfText))
                {
                    if (A_0.X < class9.method_0().X)
                    {
                        num6 = class9.method_0().X - A_0.X;
                    }
                    else
                    {
                        num6 = base.class774_0.method_13().Right - class9.method_0().Right;
                        ef11.X = class9.method_0().Right;
                    }
                    Class375 class10 = this.method_41(this.method_29(), ef4, ef10, num6);
                    if (class10 != null)
                    {
                        return class10;
                    }
                }
            }
            Interface19 interface5 = this.method_29() as Interface19;
            bool flag3 = ((this.method_29() is TextRange) || (this.method_29() is Class542)) ? this.method_29().imethod_0().imethod_2() : false;
            if ((interface5 != null) && (((ef4.Height <= base.class774_0.method_11().Height) || (Math.Abs((float) (base.class774_0.method_11().Height - ef4.Height)) <= 0.5)) || (this.method_50() || (flag3 && (base.class774_0.method_11().Height > 0f)))))
            {
                TextRange range5 = (this.method_29() is TextRange) ? (this.method_29() as TextRange) : ((!(this.method_29() is Class542) || !((this.method_29() as Class542).method_2() is TextRange)) ? null : ((this.method_29() as Class542).method_2() as TextRange));
                IDocumentObject nextSibling = range5.NextSibling;
                float num7 = 0f;
                Section section4 = range5.method_2();
                if ((section4 != null) && (section4.PageSetup.CharacterSpacingControl != CharacterSpacing.doNotCompress))
                {
                    num7 = this.method_30().method_5().method_82(range5, base.method_4());
                    this.method_30().method_5().method_78(this.method_30().method_5().method_74().Count);
                    this.method_30().method_3().method_14(new RectangleF(base.class774_0.method_13().X - num7, base.class774_0.method_13().Y, base.class774_0.method_13().Width + num7, base.class774_0.method_13().Height));
                    base.class774_0.method_12(new RectangleF(base.class774_0.method_11().X - num7, base.class774_0.method_11().Y, base.class774_0.method_11().Width + num7, base.class774_0.method_11().Height));
                    width = this.method_30().method_3().method_13().Width;
                    if ((num7 < ef6.Width) && (((range5.Text.Length != 1) || !Class203.smethod_1(range5.Text[0])) || Class203.smethod_2(range5.Text[0])))
                    {
                        this.method_75(interface5, width);
                    }
                    else
                    {
                        this.method_69(ef4, this.method_29());
                        base.layoutState_0 = LayoutState.Fitted;
                    }
                    base.class375_0.method_80(true);
                }
                else if (((range5.Text.Length == 1) && Class203.smethod_1(range5.Text[0])) && !Class203.smethod_2(range5.Text[0]))
                {
                    this.method_69(ef4, this.method_29());
                    base.layoutState_0 = LayoutState.Fitted;
                }
                else
                {
                    this.method_75(interface5, width);
                }
                base.class774_0.method_12(new RectangleF(base.class774_0.method_11().X - num7, base.class774_0.method_11().Y, base.class774_0.method_11().Width + num7, base.class774_0.method_11().Height));
                this.method_32();
            }
            else
            {
                base.layoutState_0 = LayoutState.NotFitted;
                base.bool_3 = ef4.Height > base.class774_0.method_11().Height;
            }
        }
        this.vmethod_1();
        if (base.class375_0 != null)
        {
            base.class375_0.method_3(base.method_4().field_0);
            if ((interface2 is Break) && ((interface2 as Break).BreakType == BreakType.LineBreak))
            {
                base.class375_0.method_67(true);
            }
            if ((base.method_4().method_135() && (base.class375_0.method_73() is DocPicture)) && ((base.class375_0.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))
            {
                pageSize = base.method_4().method_28().method_28().PageSize;
                if (Class59.smethod_5((double) base.class375_0.method_69().Right, (double) pageSize.Width, 5.0) > 0)
                {
                    base.class375_0.method_37(true);
                }
            }
            if ((interface2 is Break) && ((interface2 as Break).BreakType == BreakType.ColumnBreak))
            {
                base.class375_0.method_70(new RectangleF(base.class375_0.method_69().Location, new SizeF()));
            }
        }
        return base.class375_0;
    }

    protected override void vmethod_1()
    {
        Class214 class2 = base.method_2() as Class214;
        if (((class2 != null) ? (class2.method_13() > -1) : false) && (base.class375_0 != null))
        {
            base.interface30_0.imethod_6(base.class375_0);
        }
    }
}

