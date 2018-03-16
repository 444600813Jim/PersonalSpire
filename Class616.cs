using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

internal class Class616 : Class615
{
    internal bool bool_6;
    protected Class375 class375_1;
    internal double double_0;
    protected int int_0;
    private Interface1 interface1_2;
    [ThreadStatic]
    internal static List<RectangleF> list_0 = new List<RectangleF>();
    [ThreadStatic]
    internal static List<TextWrappingStyle> list_1 = new List<TextWrappingStyle>();

    public Class616(Interface3 A_0, Interface30 A_1) : base(A_0, A_1)
    {
    }

    protected Interface3 method_29()
    {
        return (base.interface1_1 as Interface3);
    }

    protected Interface1 method_30()
    {
        Interface1 interface2 = ((this.int_0 > -1) && (this.int_0 < this.method_29().imethod_3())) ? this.method_29().imethod_4(this.int_0) : null;
        if ((interface2 is Field) && ((interface2 as Field).Type == FieldType.FieldHyperlink))
        {
            base.method_4().field_0 = (interface2 as Field).Clone() as Field;
        }
        else if (((interface2 is FieldMark) && ((interface2 as FieldMark).Type == FieldMarkType.FieldEnd)) && ((base.method_4().field_0 != null) && (base.method_4().field_0.End == interface2)))
        {
            base.method_4().field_0 = null;
        }
        if ((((interface2 is Field) && ((interface2 as Field).Type == FieldType.FieldUnknown)) && !string.IsNullOrEmpty((interface2 as Field).Code)) && (((interface2 as Field).NextSibling == null) || (((interface2 as Field).NextSibling != null) && !((interface2 as Field).NextSibling is FieldMark))))
        {
            TextRange range = new TextRange((interface2 as Field).Document) {
                Text = (interface2 as Field).Code
            };
            range.ApplyCharacterFormat((interface2 as Field).CharacterFormat);
            range.IsFieldToTextRange = true;
            range.FieldOwner = (interface2 as Field).Owner;
            if ((interface2 as Field).interface23_0 != null)
            {
                range.interface23_0 = (interface2 as Field).interface23_0;
            }
            return range;
        }
        if (interface2 is FieldMark)
        {
            FieldMark mark = interface2 as FieldMark;
            if ((((mark.Type == FieldMarkType.FieldSeparator) && !(mark.PreviousSibling is Field)) && ((mark.NextSibling is TextRange) && ((mark.NextSibling as TextRange).DocumentObjectType == DocumentObjectType.TextRange))) && (((mark.NextSibling as TextRange).interface23_0 != null) && (mark.NextSibling as TextRange).interface23_0.imethod_4()))
            {
                int num = this.int_0 + 1;
                int num2 = this.method_29().imethod_3();
                FieldMark mark2 = null;
                while (num < num2)
                {
                    if (this.method_29().imethod_4(num) is FieldMark)
                    {
                        mark2 = this.method_29().imethod_4(num) as FieldMark;
                        break;
                    }
                    num++;
                }
                if ((mark2 != null) && (mark2.Type == FieldMarkType.FieldEnd))
                {
                    this.int_0 = num + 1;
                    if (this.int_0 < num2)
                    {
                        return this.method_29().imethod_4(this.int_0);
                    }
                    return null;
                }
            }
        }
        if (((interface2 is DocOleObject) && ((interface2 as DocOleObject).Interface49.get_OlePicture() != null)) && ((interface2 as DocOleObject).Interface49.get_OlePicture().TextWrappingStyle != TextWrappingStyle.Inline))
        {
            return (interface2 as DocOleObject).Interface49.get_OlePicture();
        }
        return interface2;
    }

    private Interface1 method_31()
    {
        return ((((this.int_0 + 1) > -1) && ((this.int_0 + 1) < this.method_29().imethod_3())) ? this.method_29().imethod_4(this.int_0 + 1) : null);
    }

    internal int method_32()
    {
        return this.int_0;
    }

    internal void method_33(int A_0)
    {
        this.int_0 = A_0;
    }

    private bool method_34(Class615 A_0, RectangleF A_1, ref Class312 A_2)
    {
        if ((!A_2.method_0().IsEmpty && (A_0.method_8() is TextRange)) && (((A_0.method_8() as TextRange).PreviousSibling is Break) || (A_0.method_8() as TextRange).IsAddForBreak))
        {
            Break previousSibling = (A_0.method_8() as TextRange).PreviousSibling as Break;
            if ((previousSibling == null) && ((A_0.method_8() as TextRange).OwnerParagraph != null))
            {
                previousSibling = (A_0.method_8() as TextRange).OwnerParagraph.LastItem as Break;
            }
            if ((previousSibling == null) && ((A_0.method_8() as TextRange).OwnerEmptyParagraph != null))
            {
                previousSibling = (A_0.method_8() as TextRange).OwnerEmptyParagraph.LastItem as Break;
            }
            if (((previousSibling != null) && (previousSibling.BreakType == BreakType.LineBreak)) && (previousSibling.ClearType == LineBreakClear.All))
            {
                RectangleF ef2 = new RectangleF(A_1.X, A_2.method_0().Bottom, A_1.Width, A_1.Height - (A_2.method_0().Bottom - A_1.Top));
                base.method_19(ef2);
                A_2 = new Class312();
                return true;
            }
        }
        return false;
    }

    private Section method_35(Class375 A_0, ref Interface1 A_1)
    {
        if (((A_0.method_73() is Document) && (A_0.method_74().Count > 0)) && (A_0.method_74().method_4(0).method_73() is Section))
        {
            A_1 = A_0.method_74().method_4(0).method_73();
            return (A_0.method_74().method_4(0).method_73() as Section);
        }
        if ((((A_0.method_73() is Class65) && ((A_0.method_73() as Class65).method_2() is Document)) && ((A_0.method_74().Count > 0) && (A_0.method_74().method_4(0).method_73() is Class65))) && ((A_0.method_74().method_4(0).method_73() as Class65).method_2() is Section))
        {
            A_1 = A_0.method_74().method_4(0).method_73();
            return ((A_0.method_74().method_4(0).method_73() as Class65).method_2() as Section);
        }
        if (((A_0.method_73() is Class65) && ((A_0.method_73() as Class65).method_2() is Document)) && ((A_0.method_74().Count > 0) && (A_0.method_74().method_4(0).method_73() is Section)))
        {
            A_1 = A_0.method_74().method_4(0).method_73();
            return (A_0.method_74().method_4(0).method_73() as Section);
        }
        return null;
    }

    private RectangleF method_36(Class312 A_0, RectangleF A_1, RectangleF A_2, Paragraph A_3, bool A_4, float A_5)
    {
        return this.method_38(A_0, A_1, A_2, A_3, A_4, A_5, 0f);
    }

    private RectangleF method_37(Class312 A_0, RectangleF A_1, RectangleF A_2, float A_3)
    {
        return this.method_36(A_0, A_1, A_2, null, false, 0f);
    }

    private RectangleF method_38(Class312 A_0, RectangleF A_1, RectangleF A_2, Paragraph A_3, bool A_4, float A_5, float A_6)
    {
        int num = 13;
        float num2 = (A_3 != null) ? (((Interface1) A_3).imethod_0() as Class210).method_19() : 0f;
        num2 = (num2 > 0f) ? num2 : 0f;
        PointF location = A_1.Location;
        RectangleF ef = A_1;
        if ((A_0.method_0().IsEmpty || (A_0.method_2().method_0() == TextWrappingStyle.Behind)) || ((A_0.method_2().method_0() == TextWrappingStyle.Inline) || (A_0.method_2().method_0() == TextWrappingStyle.InFrontOfText)))
        {
            ef = new RectangleF();
        }
        else if (A_0.method_2().method_0() == TextWrappingStyle.TopAndBottom)
        {
            location.Y = ((float) base.method_2().imethod_1().method_4()) + A_0.method_0().Bottom;
            if (base.method_3().method_13().X > location.X)
            {
                location.X = base.method_3().method_13().X;
                ef.Width = A_2.Width - (base.method_3().method_13().X - A_2.X);
            }
            ef = new RectangleF(location, new SizeF(ef.Width, (ef.Height - A_0.method_0().Height) - ((float) base.method_2().imethod_1().method_12())));
        }
        else
        {
            bool flag = (A_3 != null) ? A_3.IsInCell : false;
            float left = base.method_4().method_28().method_29().Margins.Left;
            float num4 = left + ((A_3 != null) ? A_3.Format.LeftIndent : 0f);
            float num5 = base.method_4().method_28().method_29().PageSize.Width - base.method_4().method_28().method_29().Margins.Right;
            float num6 = A_2.Right - ((A_3 != null) ? A_3.Format.RightIndent : 0f);
            if (flag)
            {
                num5 = num6;
                left = num4;
            }
            switch (A_0.method_2().method_2())
            {
                case TextWrappingType.Both:
                    if (((A_0.method_0().X > left) || (location.X > base.method_3().method_13().X)) || (Class59.smethod_4(A_0.method_0().Right, num5, 1f) > 0))
                    {
                        if ((A_0.method_0().Right >= num5) && ((location.X > A_0.method_0().X) || (((location.X <= A_0.method_0().X) && (location.X <= left)) && (A_0.method_0().X <= left))))
                        {
                            if (((A_0.method_0().X <= left) && ((location.X <= A_0.method_0().X) || (A_0.method_0().Right >= num5))) || (((location.X > A_0.method_0().X) && (A_0.method_0().Right >= num5)) && (A_0.method_4() is Table)))
                            {
                                location.Y = A_0.method_0().Bottom;
                                float height = ef.Height - (A_0.method_0().Bottom - ef.Y);
                                ef = new RectangleF(location, new SizeF(ef.Width, height));
                            }
                            else if ((A_4 && !flag) && ((A_0.method_0().Right >= num5) && (A_0.method_0().X > left)))
                            {
                                location.Y = Math.Min(A_6, A_2.Y + 12f);
                                location.X = num4;
                                float width = ef.Width + (ef.X - num4);
                                float num10 = ef.Height + (ef.Y - location.Y);
                                ef = new RectangleF(location, new SizeF(width, num10));
                            }
                            else
                            {
                                ef.Width -= A_0.method_0().Right - location.X;
                                location.X = A_0.method_0().Right;
                                ef = new RectangleF(location, new SizeF(ef.Width, ef.Height));
                            }
                            if (A_0.method_20() && ((A_0.method_2().method_0() == TextWrappingStyle.Through) || (A_0.method_2().method_0() == TextWrappingStyle.Tight)))
                            {
                                base.class375_0.method_13(A_0.method_0().Bottom);
                            }
                        }
                        else if ((A_4 && !flag) && ((A_0.method_0().Right > num5) && (A_0.method_4() is TextBox)))
                        {
                            location.Y = Math.Min(A_6, location.Y + 12f);
                            location.X = num4;
                            float num11 = ef.Width + (ef.X - num4);
                            float num12 = ef.Height + (ef.Y - location.Y);
                            ef = new RectangleF(location, new SizeF(num11, num12));
                        }
                        else if ((((location.X > A_0.method_0().X) && (location.X < A_0.method_0().Right)) && (A_0.method_0().Right < num5)) && ((!(this.method_30() is DocumentBase) || !((this.method_30() as DocumentBase).PreviousSibling is TextRange)) || (!((this.method_30() as DocumentBase).PreviousSibling as TextRange).Text.Contains(BookmarkStart.b("㨲", num)) || (((this.method_30() as DocumentBase).PreviousSibling as TextRange).Text.Length != 1))))
                        {
                            location.X = A_0.method_0().Right + num2;
                            ef.Width = (num6 - A_0.method_0().Right) - num2;
                            ef = new RectangleF(location, ef.Size);
                        }
                        else if (A_0.method_18() && (A_0.method_4() is Paragraph))
                        {
                            Paragraph paragraph = A_0.method_4() as Paragraph;
                            float num13 = 74f;
                            num13 += paragraph.Format.Borders.Left.Space + paragraph.Format.Borders.Left.LineWidth;
                            if ((A_0.method_0().X - A_2.X) < num13)
                            {
                                RectangleF ef37 = new RectangleF(A_0.method_0().Right, location.Y, (A_2.Width > A_0.method_0().Right) ? (A_2.Width - A_0.method_0().Right) : 0f, A_5);
                                Class312 class2 = base.method_4().method_28().method_51(ef37, this.interface1_2);
                                if (!class2.method_0().IsEmpty)
                                {
                                    RectangleF ef41 = this.method_36(class2, A_1, ef37, A_3, A_4, A_5);
                                    if (ef41.IsEmpty)
                                    {
                                        location.X = A_0.method_0().Right + num2;
                                        ef.Width = (A_2.Right - A_0.method_0().Right) - num2;
                                        ef = new RectangleF(location, ef.Size);
                                    }
                                    else if ((class2.method_0().Bottom - A_0.method_0().Bottom) > 1f)
                                    {
                                        location.Y = A_0.method_0().Bottom;
                                        ef = new RectangleF(location, ef.Size);
                                    }
                                    else if (ef41.Right > A_2.Right)
                                    {
                                        ef = new RectangleF(ef41.Location, new SizeF(A_2.Right - ef41.Left, ef41.Height));
                                    }
                                    else
                                    {
                                        ef = ef41;
                                    }
                                }
                                else
                                {
                                    if (A_2.Right < A_0.method_0().Right)
                                    {
                                        if (location.X != A_2.X)
                                        {
                                            location.X = A_2.X + (((float) paragraph.Format.FrameHorizontalDistanceFromText) / 20f);
                                        }
                                        location.X += num2;
                                        location.Y = A_0.method_0().Bottom;
                                    }
                                    else
                                    {
                                        location.X = A_0.method_0().Right + num2;
                                        ef.Width = (A_2.Right - A_0.method_0().Right) - num2;
                                    }
                                    ef = new RectangleF(location, ef.Size);
                                }
                            }
                            else
                            {
                                ef = new RectangleF();
                            }
                        }
                        else
                        {
                            ef = new RectangleF();
                        }
                    }
                    else
                    {
                        location.X = A_0.method_0().Right + num2;
                        float num7 = A_0.method_0().Right - ef.Left;
                        ef.Width = (A_2.Width - num7) - num2;
                        if (ef.Width <= 0f)
                        {
                            ef = new RectangleF();
                        }
                        else
                        {
                            ef = new RectangleF(location, new SizeF(ef.Width, ef.Height));
                        }
                    }
                    goto Label_0D38;

                case TextWrappingType.Left:
                    location.X = base.method_3().method_13().X;
                    ef.Width = (A_0.method_0().Right - A_0.method_0().Width) - location.X;
                    ef = new RectangleF(location, new SizeF(ef.Width, ef.Height));
                    goto Label_0D38;

                case TextWrappingType.Right:
                    if (base.method_3().method_13().X > A_0.method_0().Right)
                    {
                        location.X = base.method_3().method_13().X;
                        ef.Width = A_2.Width - (base.method_3().method_13().X - A_2.Location.X);
                    }
                    else
                    {
                        float num14 = A_2.Width - (A_0.method_0().Right - A_2.Location.X);
                        if (num14 <= 0f)
                        {
                            location.X = base.method_3().method_13().X;
                            location.Y = A_0.method_0().Bottom;
                            ef.Width = A_2.Width - (base.method_3().method_13().X - A_2.Location.X);
                            if (A_0.method_20() && ((A_0.method_2().method_0() == TextWrappingStyle.Through) || (A_0.method_2().method_0() == TextWrappingStyle.Tight)))
                            {
                                base.class375_0.method_13(A_0.method_0().Bottom);
                            }
                        }
                        else
                        {
                            location.X = A_0.method_0().Right;
                            ef.Width = num14;
                        }
                    }
                    ef = new RectangleF(location, new SizeF(ef.Width, ef.Height));
                    goto Label_0D38;

                case TextWrappingType.Largest:
                {
                    float num15 = A_0.method_0().Left - left;
                    float num16 = (A_2.Width - num15) - A_0.method_0().Width;
                    if (num15 < num16)
                    {
                        if (base.method_3().method_13().X <= A_0.method_0().Right)
                        {
                            location.X = A_0.method_0().Right;
                            ef.Width = num16;
                        }
                        else
                        {
                            location.X = base.method_3().method_13().X;
                            ef.Width = num16 - (base.method_3().method_13().X - A_0.method_0().Right);
                        }
                    }
                    else
                    {
                        location.X = base.method_3().method_13().X;
                        if (location.X <= left)
                        {
                            ef.Width = num15 - 1f;
                        }
                        else
                        {
                            ef.Width = (num15 - (location.X - left)) - 1f;
                        }
                    }
                    ef = new RectangleF(location, new SizeF(ef.Width, ef.Height));
                    goto Label_0D38;
                }
            }
            ef = new RectangleF();
        }
    Label_0D38:
        if (((!ef.IsEmpty && (ef.X != base.method_3().method_13().X)) && ((base.method_5().method_74().Count == 0) && (base.method_2() is Class210))) && ((base.method_2() as Class210).method_43() && ((base.method_2() as Class210).method_51() > 0f)))
        {
            ef = new RectangleF(ef.X + (base.method_2() as Class210).method_51(), ef.Y, ef.Width - (base.method_2() as Class210).method_51(), ef.Height);
        }
        return ef;
    }

    private SizeF method_39(Class615 A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            return (SizeF) new Size();
        }
        SizeF ef = new SizeF();
        Paragraph fieldOwner = null;
        if (A_0.method_8() is TextRange)
        {
            string str = ((A_0.method_8() as TextRange).Text.Length > 0) ? (A_0.method_8() as TextRange).Text : (A_0.method_8() as TextRange).TextToSplit;
            TextRange range2 = A_0.method_8() as TextRange;
            if (range2.IsFieldToTextRange)
            {
                fieldOwner = range2.FieldOwner as Paragraph;
            }
            else
            {
                fieldOwner = (range2.OwnerEmptyParagraph != null) ? range2.OwnerEmptyParagraph : range2.method_28();
                fieldOwner.method_49();
            }
            if (string.IsNullOrEmpty(str) && range2.IsAddForBreak)
            {
                str = BookmarkStart.b("᜶", num);
            }
            Class560 class3 = ((Interface11) range2.CharacterFormat).imethod_0() as Class560;
            ef = base.method_4().method_323(range2, str);
            if (class3.method_16() != 0f)
            {
                float num3 = (A_0.method_8() as TextRange).Text.Length * class3.method_16();
                ef = new SizeF(ef.Width + num3, ef.Height);
            }
            return ef;
        }
        if (A_0.method_8() is Class542)
        {
            TextRange range = (A_0.method_8() as Class542).method_2() as TextRange;
            if (range.IsFieldToTextRange)
            {
                fieldOwner = range.FieldOwner as Paragraph;
            }
            else
            {
                ((range.OwnerEmptyParagraph != null) ? range.OwnerEmptyParagraph : range.method_28()).method_49();
            }
            Class560 class2 = ((Interface11) range.CharacterFormat).imethod_0() as Class560;
            ef = base.method_4().method_323(range, (A_0.method_8() as Class542).method_0());
            if (class2.method_16() != 0f)
            {
                float num2 = ((A_0.method_8() as Class542).method_2() as TextRange).Text.Length * class2.method_16();
                ef = new SizeF(ef.Width + num2, ef.Height);
            }
            return ef;
        }
        if (!(A_0.method_8() is BookmarkStart) && !(A_0.method_8() is BookmarkEnd))
        {
            (A_0.method_8() as ParagraphBase).method_28().method_49();
            return (A_0.method_8() as Interface2).imethod_3(base.method_4());
        }
        (A_0.method_8() as ParagraphBase).method_28().method_49();
        return (A_0.method_8() as Interface2).imethod_3(base.method_4());
    }

    private bool method_40(Paragraph A_0)
    {
        bool flag;
        using (IEnumerator enumerator = A_0.ChildObjects.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                ParagraphBase current = (ParagraphBase) enumerator.Current;
                if (((current.DocumentObjectType != DocumentObjectType.BookmarkStart) && (current.DocumentObjectType != DocumentObjectType.BookmarkEnd)) && (current.DocumentObjectType != DocumentObjectType.Break))
                {
                    goto Label_0045;
                }
            }
            return true;
        Label_0045:
            flag = false;
        }
        return flag;
    }

    private void method_41(Interface1 A_0)
    {
        int num = 3;
        if (A_0 is Paragraph)
        {
            (A_0.imethod_0() as Class210).method_44(true);
            if (this.method_73(A_0 as Paragraph))
            {
                RectangleF ef5 = base.method_23(A_0 as Paragraph, base.class774_0.method_13());
                (A_0.imethod_0() as Class210).method_58(ef5.Y);
            }
            else
            {
                (A_0.imethod_0() as Class210).method_58(base.class774_0.method_13().Y);
            }
        }
        if ((A_0 is Class65) && ((A_0 as Class65).method_2() is Paragraph))
        {
            Paragraph paragraph = (A_0 as Class65).method_2() as Paragraph;
            int count = paragraph.ChildObjects.Count;
            if ((count > (A_0 as Class65).Interface3.imethod_3()) && (paragraph.ChildObjects[(count - 1) - (A_0 as Class65).Interface3.imethod_3()].DocumentObjectType.ToString() == BookmarkStart.b("欨太䠬丮娰", num)))
            {
                DocumentObject obj2 = paragraph.ChildObjects[(count - 1) - (A_0 as Class65).Interface3.imethod_3()];
                Break @break = obj2 as Break;
                if ((@break.BreakType == BreakType.PageBreak) || (@break.BreakType == BreakType.ColumnBreak))
                {
                    (paragraph.interface23_0 as Class210).method_58(base.class774_0.method_13().Y);
                }
            }
            else if ((base.method_4().method_28().method_3().Count == 2) && ((paragraph.interface23_0 as Class210).method_57() > base.class774_0.method_13().Y))
            {
                (paragraph.interface23_0 as Class210).method_58(base.class774_0.method_13().Y);
            }
        }
    }

    private bool method_42(Interface1 A_0)
    {
        if (A_0 is Break)
        {
            Break @break = A_0 as Break;
            if ((@break.OwnerParagraph != null) && @break.OwnerParagraph.IsInCell)
            {
                return true;
            }
        }
        return false;
    }

    private void method_43(Class375 A_0, bool A_1)
    {
        foreach (Class375 class2 in A_0.method_74())
        {
            if ((((class2.method_73() is Table) && (class2.method_73() as Table).IsTextBox) && (((class2.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Behind) || ((class2.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.InFrontOfText))) || ((class2.method_73() is DocPicture) && ((class2.method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)))
            {
                if (A_1)
                {
                    base.method_4().method_28().method_42(class2);
                    base.method_4().method_28().method_45(class2);
                }
                else
                {
                    base.method_4().method_0()[base.method_4().method_0().Count - 2].method_42(class2);
                    base.method_4().method_0()[base.method_4().method_0().Count - 2].method_45(class2);
                }
            }
            else
            {
                this.method_43(class2, A_1);
            }
        }
    }

    private void method_44(Class375 A_0, bool A_1)
    {
        foreach (Class375 class2 in A_0.method_74())
        {
            if (class2.method_73() is Footnote)
            {
                if (A_1)
                {
                    base.method_4().method_28().method_39(class2);
                }
                else
                {
                    base.method_4().method_0()[base.method_4().method_0().Count - 2].method_39(class2);
                    Class500 class1 = base.method_4().method_28();
                    class1.method_7(class1.method_6() - 1);
                }
            }
            else
            {
                this.method_44(class2, A_1);
            }
        }
    }

    private void method_45(Class375 A_0, bool A_1)
    {
        foreach (Class375 class2 in A_0.method_74())
        {
            if ((class2.method_73() is Paragraph) && (class2.method_73() as Paragraph).Format.IsFrame)
            {
                if (A_1)
                {
                    base.method_4().method_28().method_43(class2);
                }
                else
                {
                    base.method_4().method_0()[base.method_4().method_0().Count - 2].method_43(class2);
                }
            }
            else
            {
                this.method_43(class2, true);
            }
        }
    }

    private float method_46()
    {
        float top = 0f;
        if (base.method_4().method_28().method_3().Count < 2)
        {
            return top;
        }
        Class500 class2 = base.method_4().method_28();
        if (class2.method_3().Count > 2)
        {
            top = base.class375_0.method_69().Top;
        }
        else
        {
            float num3 = class2.method_47();
            if (num3 > class2.method_28().Margins.Top)
            {
                top = num3;
            }
            else
            {
                top = class2.method_28().Margins.Top;
            }
        }
        float num2 = class2.method_49();
        if (num2 > class2.method_28().Margins.Bottom)
        {
            return (top + num2);
        }
        return (top + class2.method_28().Margins.Bottom);
    }

    private bool method_47(Table A_0)
    {
        if (((A_0 != null) && (A_0.TableFormat != null)) && !A_0.TableFormat.WrapTextAround)
        {
            int count = A_0.Rows.Count;
            this.method_87(A_0, ref count);
            if (count == 0)
            {
                return true;
            }
        }
        return false;
    }

    private bool method_48(RectangleF A_0)
    {
        return ((Math.Round((double) A_0.Height, 2) > Math.Round((double) base.class774_0.method_13().Height, 2)) && (Math.Round((double) A_0.Bottom, 2) > Math.Round((double) base.class774_0.method_13().Bottom, 2)));
    }

    private void method_49(Class615 A_0, Class210 A_1)
    {
        if ((A_1 != null) && A_1.method_43())
        {
            A_1.method_44(false);
            if (A_0.method_5() != null)
            {
                A_0.method_5().method_53(true);
            }
        }
    }

    private bool method_50()
    {
        bool flag = false;
        if (!(base.class375_0.method_73() is Section) && (!(base.class375_0.method_73() is Class65) || !((base.class375_0.method_73() as Class65).method_2() is Section)))
        {
            return flag;
        }
        return true;
    }

    private void method_51()
    {
        Class372 class2 = this.class375_1.method_73().imethod_0().imethod_1();
        RectangleF ef = this.class375_1.method_69();
        ef.X -= (float) class2.method_0();
        ef.Y -= (float) class2.method_4();
        ef.Width += (float) (class2.method_0() + class2.method_8());
        ef.Height += (float) (class2.method_4() + class2.method_12());
        float bottom = ef.Bottom;
        if (bottom < (base.interface30_0 as Class304).method_6().Top)
        {
            bottom = (base.interface30_0 as Class304).method_6().Top;
        }
        else if (bottom > (base.interface30_0 as Class304).method_6().Bottom)
        {
            bottom = (base.interface30_0 as Class304).method_6().Bottom;
        }
        RectangleF ef6 = (base.interface30_0 as Class304).method_6();
        ef6.Height = ef6.Bottom - bottom;
        ef6.Y = bottom;
        (base.interface30_0 as Class304).method_7(ef6);
    }

    private FrameLayoutState method_52(Paragraph A_0)
    {
        FrameLayoutState layouting = FrameLayoutState.Layouting;
        RectangleF ef = this.class375_1.method_69();
        if ((base.interface30_0 as Class304).method_6().IsEmpty)
        {
            (base.interface30_0 as Class304).method_7(ef);
        }
        if (!A_0.IsInSameFrameWithNextSibling)
        {
            if (A_0.Format.FrameHeight != 0)
            {
                ushort frameHeight = (ushort) A_0.Format.FrameHeight;
                bool flag = (frameHeight & 0x8000) != 0;
                float num2 = ef.Bottom - (base.interface30_0 as Class304).method_8().Y;
                if (!flag || (flag && (num2 < A_0.Format.FrameHeightEx)))
                {
                    ef.Height += A_0.Format.FrameHeightEx - num2;
                }
                this.class375_1.method_70(ef);
            }
            layouting = FrameLayoutState.Layouted;
        }
        if (A_0.Format.FrameWidthRule != FrameSizeRule.Exact)
        {
            this.vmethod_8(A_0.Format.FrameX, A_0.Format.FrameWidthEx);
        }
        bool flag2 = true;
        if (A_0.IsInCell && (A_0.OwnerTextBody as TableCell).OwnerRow.OwnerTable.IsFrame)
        {
            flag2 = false;
        }
        if (((A_0 != null) && A_0.Format.IsFrame) && (flag2 && (ef.Bottom < (base.interface30_0 as Class304).method_6().Y)))
        {
            ef.Height += (base.interface30_0 as Class304).method_6().Y - ef.Bottom;
        }
        return layouting;
    }

    private FrameLayoutState method_53(Table A_0)
    {
        FrameLayoutState layouting = FrameLayoutState.Layouting;
        RectangleF ef = this.class375_1.method_69();
        if ((base.interface30_0 as Class304).method_6().IsEmpty)
        {
            (base.interface30_0 as Class304).method_7(ef);
        }
        if (!A_0.IsInSameFrameWithNextSibling)
        {
            if (A_0.FrameFormat.FrameHeight != 0)
            {
                ushort frameHeight = (ushort) A_0.FrameFormat.FrameHeight;
                if ((frameHeight & 0x8000) != 0)
                {
                    float num = ef.Bottom - (base.interface30_0 as Class304).method_8().Y;
                    if (num < A_0.FrameFormat.FrameHeightEx)
                    {
                        ef.Height += A_0.FrameFormat.FrameHeightEx - num;
                    }
                }
                else
                {
                    ef.Height = (ef.Height + (base.interface30_0 as Class304).method_6().Bottom) - ef.Bottom;
                }
                this.class375_1.method_70(ef);
            }
            layouting = FrameLayoutState.Layouted;
        }
        this.vmethod_8(A_0.Rows[0].Cells[0].Paragraphs[0].Format.FrameX, A_0.Rows[0].Cells[0].Paragraphs[0].Format.FrameWidthEx);
        this.method_57(A_0.Rows[0].Cells[0].Paragraphs[0].Format.FrameY);
        this.method_55(A_0.Rows[0].Cells[0].Paragraphs[0], this.class375_1.method_69());
        return layouting;
    }

    private void method_54(FrameLayoutState A_0, Class375 A_1)
    {
        if ((A_1 != null) && (A_0 != FrameLayoutState.None))
        {
            Paragraph paragraph = (A_1.method_73() is Paragraph) ? (A_1.method_73() as Paragraph) : ((!(A_1.method_73() is Class65) || !((A_1.method_73() as Class65).method_2() is Paragraph)) ? null : ((A_1.method_73() as Class65).method_2() as Paragraph));
            if (A_1.method_73() is Table)
            {
                paragraph = (A_1.method_73() as Table).Rows[0].Cells[0].Paragraphs[0];
            }
            base.method_4().method_130().method_8(A_1);
            if ((((A_1.method_74().Count > 0) && (A_1.method_74().method_4(0).method_73() is Paragraph)) && ((paragraph != null) && paragraph.Format.IsFrame)) && ((paragraph.Format.FrameHeightRule == FrameSizeRule.Exact) && (Class59.smethod_4(base.method_4().method_130().method_2().Height, paragraph.Format.FrameHeightEx, 0.5f) > 0)))
            {
                float num = paragraph.Format.FrameHeightEx - base.method_4().method_130().method_2().Height;
                Class375 class2 = A_1.method_74().method_0();
                RectangleF ef3 = class2.method_69();
                class2.method_70(new RectangleF(ef3.Location, new SizeF(ef3.Width, ef3.Height + num)));
            }
            if ((paragraph != null) && paragraph.Format.IsFrame)
            {
                this.method_56(paragraph, A_0);
            }
        }
    }

    private void method_55(Paragraph A_0, RectangleF A_1)
    {
        if (A_0 != null)
        {
            bool flag = ((base.method_4().method_28() != null) && (base.method_4().method_28().method_30() != null)) && (base.method_4().method_28().method_30().PageSetup.Margins.Top < 0f);
            if ((!base.method_4().method_138() && !base.method_4().method_137()) || !flag)
            {
                DocumentObject owner = A_0;
                if (A_0.IsInCell)
                {
                    while (owner != null)
                    {
                        if (owner is Table)
                        {
                            break;
                        }
                        owner = owner.Owner;
                    }
                }
                if (!A_0.IsInCell || ((A_0.IsInCell && (owner is Table)) && (!(owner as Table).TableFormat.WrapTextAround && !(owner as Table).IsFrame)))
                {
                    ParagraphFormat format = A_0.Format;
                    if (A_0.Format.FrameWidthRule == FrameSizeRule.Exact)
                    {
                        RectangleF ef = base.method_24(A_0, A_1);
                        if (A_0.IsInCell)
                        {
                            A_1 = new RectangleF(A_1.Location, new SizeF(ef.Width, A_1.Height));
                        }
                        else if (format.WrapFrameAround && (A_0.Format.FrameWidthRule != FrameSizeRule.Auto))
                        {
                            A_1 = new RectangleF(new PointF(ef.X, A_1.Y), new SizeF(ef.Width, ef.Height));
                        }
                        else
                        {
                            A_1 = new RectangleF(new PointF(ef.X, A_1.Y), new SizeF(ef.Width, A_1.Height));
                        }
                    }
                    Class312 class2 = new Class312();
                    RectangleF ef2 = A_1;
                    float num2 = (format.FrameHorizontalDistanceFromText != 0) ? (((float) format.FrameHorizontalDistanceFromText) / 20f) : 0f;
                    float num = (format.FrameHorizontalDistanceFromText != 0) ? (((float) format.FrameVerticalDistanceFromText) / 20f) : 0f;
                    ef2 = new RectangleF(ef2.X - num2, ef2.Y - num, ef2.Width + (num2 * 2f), ef2.Height + (num * 2f));
                    class2.method_1(ef2);
                    class2.method_19(true);
                    class2.method_5(A_0);
                    class2.method_21(base.method_4().method_138());
                    class2.method_23(base.method_4().method_137());
                    if (format.WrapFrameAround && ((A_0.Format.FrameWidthRule != FrameSizeRule.Auto) || (A_0.Format.DropCapPosition != DropCapPosition.None)))
                    {
                        class2.method_2().method_1(TextWrappingStyle.Square);
                        class2.method_2().method_3(TextWrappingType.Both);
                    }
                    else
                    {
                        class2.method_2().method_1(TextWrappingStyle.TopAndBottom);
                        class2.method_2().method_3(TextWrappingType.Both);
                    }
                    base.method_4().method_28().method_40(class2);
                    list_0.Add(ef2);
                    if (A_0.Format.WrapFrameAround)
                    {
                        list_1.Add(TextWrappingStyle.Square);
                    }
                    else
                    {
                        list_1.Add(TextWrappingStyle.TopAndBottom);
                    }
                }
            }
        }
    }

    private void method_56(Paragraph A_0, FrameLayoutState A_1)
    {
        if (A_1 == FrameLayoutState.Layouted)
        {
            RectangleF ef = base.method_4().method_130().method_2();
            ParagraphFormat format = A_0.Format;
            float num = (!format.IsFrame || (format.FrameHeightRule != FrameSizeRule.Exact)) ? ef.Height : format.FrameHeightEx;
            switch (format.FrameY)
            {
                case -20:
                case -12:
                    base.method_4().method_130().method_9(0.0, (double) -num, true, true);
                    break;

                case -8:
                    base.method_4().method_130().method_9(0.0, (double) (-num / 2f), true, true);
                    break;
            }
            if (format.IsFrame && (format.FrameHeightRule == FrameSizeRule.Exact))
            {
                ef = new RectangleF(ef.Location, new SizeF(ef.Width, format.FrameHeightEx));
            }
        }
        this.method_55(A_0, base.method_4().method_130().method_2());
    }

    private void method_57(short A_0)
    {
        RectangleF ef = this.class375_1.method_69();
        short num = A_0;
        switch (num)
        {
            case -20:
            case -12:
                this.class375_1.method_94(0.0, (double) -ef.Height, true);
                return;
        }
        if (num == -8)
        {
            this.class375_1.method_94(0.0, (double) (-ef.Height / 2f), true);
        }
    }

    protected bool method_58()
    {
        if ((this.int_0 > -1) && (this.int_0 < (this.method_29().imethod_3() - 1)))
        {
            this.int_0++;
            return true;
        }
        this.int_0 = -1;
        return false;
    }

    protected void method_59(Interface1 A_0)
    {
        base.interface1_0 = new Class65(this.method_29(), A_0, this.int_0);
    }

    protected void method_60(Class615 A_0)
    {
        int num = 5;
        switch (A_0.method_1())
        {
            case LayoutState.Unknown:
                base.layoutState_0 = LayoutState.Unknown;
                return;

            case LayoutState.NotFitted:
                this.vmethod_3(A_0);
                base.class375_0.method_65(BookmarkStart.b("砪崬䌮堰䜲䄴制崸", num));
                return;

            case LayoutState.Splitted:
                base.class375_0.method_65(BookmarkStart.b("砪崬䌮堰䜲䄴制崸", num));
                this.vmethod_5(A_0);
                return;

            case LayoutState.Fitted:
                this.vmethod_4(A_0);
                return;

            case LayoutState.Breaked:
                this.vmethod_6(A_0);
                return;
        }
    }

    protected void method_61(Class615 A_0)
    {
        if (this.class375_1.method_34() && ((base.class375_0.method_73() is Section) || ((base.class375_0.method_73() is Class65) && ((base.class375_0.method_73() as Class65).method_2() is Section))))
        {
            List<Class375> list2 = new List<Class375>();
            for (int i = base.class375_0.method_74().Count - 1; i >= 0; i--)
            {
                if (base.method_4().method_28().method_54(base.class375_0.method_74().method_4(i).method_69()))
                {
                    list2.Add(base.class375_0.method_74().method_4(i));
                }
            }
            if (list2.Count > 0)
            {
                float height = list2[0].method_69().Height;
                int index = base.class375_0.method_74().IndexOf(list2[0]);
                int num9 = base.class375_0.method_74().IndexOf(list2[list2.Count - 1]);
                int num14 = (index == (base.class375_0.method_74().Count - 1)) ? index : (base.class375_0.method_74().Count - 1);
                list2.Clear();
                for (int j = num14; j >= num9; j--)
                {
                    Class375 item = base.class375_0.method_74().method_4(j);
                    list2.Add(item);
                }
                height = base.class375_0.method_69().Bottom - list2[list2.Count - 1].method_69().Top;
                this.method_43(this.class375_1, true);
                this.method_44(this.class375_1, true);
                foreach (Class375 class2 in list2)
                {
                    this.method_44(class2, true);
                    this.method_43(class2, true);
                    base.class375_0.method_74().method_11(class2);
                }
                Interface1 interface2 = list2[list2.Count - 1].method_73();
                int num3 = -1;
                if (base.class375_0.method_73() is Section)
                {
                    num3 = (interface2 as DocumentBase).method_5();
                }
                this.method_33((num3 > -1) ? num3 : (this.method_32() - list2.Count));
                Class375 class3 = (base.class375_0.method_74().Count > 0) ? base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1) : null;
                PointF location = list2[list2.Count - 1].method_69().Location;
                Paragraph paragraph = ((class3 == null) || !(class3.method_73() is Paragraph)) ? (((class3 == null) || !(class3.method_73() is Class65)) ? null : ((class3.method_73() as Class65).method_2() as Paragraph)) : (class3.method_73() as Paragraph);
                float num2 = (paragraph != null) ? paragraph.Format.AfterSpacing : 0f;
                float num5 = (class3 != null) ? (class3.method_69().Bottom + num2) : location.Y;
                height = (paragraph != null) ? (height + num2) : height;
                PointF tf2 = base.class375_0.method_69().Location;
                float x = tf2.X;
                float y = ((base.class375_0.method_74().Count != 0) || (location.Y >= tf2.Y)) ? num5 : tf2.Y;
                float num10 = !base.class375_0.method_38() ? (base.class375_0.method_69().Height - height) : 0f;
                num10 = (num10 <= 0f) ? 0f : num10;
                SizeF size = new SizeF((float) base.method_3().method_4(), (((float) base.method_3().method_5()) - num10) - base.method_4().method_28().method_76());
                RectangleF ef7 = new RectangleF(new PointF(x, y), size);
                base.layoutState_0 = LayoutState.Unknown;
                list2.Clear();
                list2 = null;
                List<RectangleF> list3 = new List<RectangleF>();
                for (int k = list_0.Count - 1; k >= 0; k--)
                {
                    if (base.method_4().method_28().method_54(list_0[k]))
                    {
                        list3.Add(list_0[k]);
                    }
                }
                foreach (RectangleF ef11 in list3)
                {
                    list_0.Remove(ef11);
                }
                list3.Clear();
                list3 = null;
                base.class375_0.method_39(true);
                this.vmethod_0(ef7);
            }
            else if (base.class375_0.method_74().Count == 0)
            {
                base.layoutState_0 = LayoutState.Unknown;
                List<RectangleF> list = new List<RectangleF>();
                for (int m = list_0.Count - 1; m >= 0; m--)
                {
                    if (base.method_4().method_28().method_54(list_0[m]))
                    {
                        list.Add(list_0[m]);
                    }
                }
                foreach (RectangleF ef12 in list)
                {
                    list_0.Remove(ef12);
                }
                list.Clear();
                list = null;
                base.class375_0.method_39(true);
                this.vmethod_0(new RectangleF(base.class375_0.method_69().X, base.class375_0.method_69().Y, (float) base.method_3().method_4(), (float) base.method_3().method_3()));
            }
            else
            {
                this.class375_1.method_35(false);
                this.method_62(A_0);
            }
        }
        else
        {
            this.method_62(A_0);
        }
    }

    private void method_62(Class615 A_0)
    {
        if (((this.class375_1.method_73() is Section) && this.class375_1.method_73().imethod_0().imethod_44()) || (((this.class375_1.method_73() is Class65) && ((this.class375_1.method_73() as Class65).method_2() is Section)) && this.class375_1.method_73().imethod_0().imethod_44()))
        {
            base.class375_0.method_70(new RectangleF(this.class375_1.method_69().Location, new SizeF()));
        }
        base.class375_0.method_74().method_7(this.class375_1);
        if (this.class375_1.method_73() is Paragraph)
        {
            this.class375_1.method_5(base.method_14().imethod_3().Interface30.imethod_4());
        }
        base.class375_0.method_31(this.class375_1.method_30());
        this.vmethod_7();
        this.method_64(A_0);
        this.vmethod_11(base.method_4(), A_0);
    }

    private bool method_63()
    {
        if (this.class375_1.method_73() is Table)
        {
            Table table = this.class375_1.method_73() as Table;
            if (table.IsTextBox && (table.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline))
            {
                return false;
            }
        }
        return true;
    }

    private void method_64(Class615 A_0)
    {
        SizeF ef3;
        int num = 15;
        float num2 = 0f;
        RectangleF ef = base.class375_0.method_69();
        FrameLayoutState none = FrameLayoutState.None;
        double num3 = base.bool_0 ? 0.0 : A_0.method_6();
        double num4 = base.bool_0 ? 0.0 : A_0.method_7();
        this.vmethod_9();
        if (((base.class375_0.method_73() is Paragraph) && !(A_0.method_8() is ParagraphBase)) && this.method_73(base.class375_0.method_73() as Paragraph))
        {
            Class375 class2 = base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1);
            Paragraph paragraph = base.class375_0.method_73() as Paragraph;
            Interface1 textBox = class2.method_73();
            if (textBox is Class7)
            {
                textBox = (textBox as Class7).TextBox as Interface1;
            }
            else if (class2.method_74().Count > 0)
            {
                textBox = class2.method_74().method_4(class2.method_74().Count - 1).method_73();
            }
            if (textBox is Class542)
            {
                textBox = (textBox as Class542).method_2();
            }
            if (textBox is ParagraphBase)
            {
                int count = paragraph.ChildObjects.Count;
                int index = paragraph.ChildObjects.IndexOf(textBox as DocumentObject);
                if (index == (count - 1))
                {
                    none = this.method_52(paragraph);
                }
                else if (index > -1)
                {
                    for (int i = index + 1; i < paragraph.ChildObjects.Count; i++)
                    {
                        if (!(paragraph.ChildObjects[i] as Interface1).imethod_0().imethod_4())
                        {
                            break;
                        }
                        count--;
                    }
                    if (index == (count - 1))
                    {
                        none = this.method_52(paragraph);
                    }
                }
            }
        }
        Paragraph paragraph2 = (base.class375_0.method_73() is Paragraph) ? (base.class375_0.method_73() as Paragraph) : ((base.class375_0.method_73() is Class65) ? ((base.class375_0.method_73() as Class65).method_2() as Paragraph) : null);
        this.method_75(paragraph2);
        LineSpacingRule multiple = LineSpacingRule.Multiple;
        this.class375_1.method_69();
        RectangleF ef2 = this.class375_1.method_69();
        double num8 = Math.Max(ef2.Right + num3, (double) ef.Right);
        double bottom = 0.0;
        float num10 = 0f;
        if ((!(base.class375_0.method_73() is Paragraph) && (!(base.class375_0.method_73() is Class65) || !((base.class375_0.method_73() as Class65).method_2() is Paragraph))) || (!(A_0.method_8() is IParagraphBase) && !(A_0.method_8() is Class542)))
        {
            if ((ef.Bottom >= ef2.Bottom) && (ef.X <= ef2.X))
            {
                bottom = Math.Max(ef2.Bottom + num4, (double) ef.Bottom);
            }
            else
            {
                bottom = Math.Max(ef2.Bottom + num4, (double) ef.Bottom);
            }
            if (this.class375_1.method_44())
            {
                bottom = ef2.Bottom;
            }
            goto Label_03C2;
        }
        float num11 = -1f;
        num2 = this.method_67(base.class375_0, ref multiple, ref num11);
        num10 = num2;
        if ((multiple == LineSpacingRule.AtLeast) && (num11 == 0f))
        {
            multiple = LineSpacingRule.Multiple;
        }
        else
        {
            switch (multiple)
            {
                case LineSpacingRule.AtLeast:
                    bottom = Math.Max(ef2.Bottom, Math.Max(ef.Bottom, ef2.Y + num2));
                    break;

                case LineSpacingRule.Exactly:
                case LineSpacingRule.Multiple:
                    goto Label_03B6;
            }
            goto Label_03C2;
        }
    Label_03B6:
        bottom = ef2.Y + num2;
    Label_03C2:
        ef3 = new SizeF(((float) num8) - ef.Left, ((float) bottom) - ef.Top);
        if ((A_0.method_8() is Paragraph) || ((A_0.method_8() is Class65) && ((A_0.method_8() as Class65).method_2() is Paragraph)))
        {
            Paragraph paragraph3 = (A_0.method_8() is Paragraph) ? (A_0.method_8() as Paragraph) : ((A_0.method_8() as Class65).method_2() as Paragraph);
            ParagraphStyle style = paragraph3.GetStyle();
            if ((!paragraph3.Format.Borders.NoBorder || (((style != null) && (style.ParagraphFormat != null)) && !style.ParagraphFormat.Borders.NoBorder)) || (((style != null) && (style.BaseStyle != null)) && ((style.BaseStyle.ParagraphFormat != null) && !style.BaseStyle.ParagraphFormat.Borders.NoBorder)))
            {
                ef3.Width = base.class774_0.method_13().Width;
            }
            if (((base.class375_0.method_73() is Section) && paragraph3.Format.IsFrame) && paragraph3.Format.WrapFrameAround)
            {
                return;
            }
        }
        if (A_0.method_8() is DocPicture)
        {
            DocPicture picture = A_0.method_8() as DocPicture;
            Paragraph ownerParagraph = picture.OwnerParagraph;
            if ((picture.TextWrappingStyle == TextWrappingStyle.InFrontOfText) || (picture.TextWrappingStyle == TextWrappingStyle.Behind))
            {
                if ((ownerParagraph == null) || (base.class375_0.method_69().Height != 0f))
                {
                    ef3.Height = base.class375_0.method_69().Height;
                }
                else
                {
                    Class213 class3 = ((Interface1) ownerParagraph).imethod_0() as Class213;
                    SizeF ef6 = base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ᔴ", num), base.method_4().method_376(ownerParagraph.BreakCharacterFormat), null) : base.method_4().method_316(BookmarkStart.b("ᔴ", num), base.method_4().method_365(ownerParagraph.BreakCharacterFormat), null);
                    switch (class3.method_55())
                    {
                        case LineSpacingRule.AtLeast:
                            if (ef6.Height <= class3.method_53())
                            {
                                ef3.Height = class3.method_53();
                                break;
                            }
                            ef3.Height = ef6.Height;
                            break;

                        case LineSpacingRule.Exactly:
                            ef3.Height = Math.Abs(class3.method_53());
                            break;

                        case LineSpacingRule.Multiple:
                            if (class3.method_53() != 0f)
                            {
                                ef3.Height = ef6.Height * (class3.method_53() / 12f);
                                break;
                            }
                            ef3.Height = ef6.Height;
                            break;
                    }
                }
            }
            if (picture.TextWrappingStyle != TextWrappingStyle.Inline)
            {
                list_0.Add(this.class375_1.method_69());
                list_1.Add(picture.TextWrappingStyle);
            }
            if (ownerParagraph == null)
            {
                ownerParagraph = this.method_71(picture);
            }
            if (((picture.TextWrappingStyle != TextWrappingStyle.Inline) && (picture.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (picture.TextWrappingStyle != TextWrappingStyle.Behind))
            {
                this.double_0 = 0.0;
                ef3.Height = ((((float) this.double_0) - ef.Y) < 0f) ? 0f : (((float) this.double_0) - ef.Y);
                if (ef3.Height == 0f)
                {
                    SizeF ef8 = base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ᔴ", num), base.method_4().method_376(ownerParagraph.BreakCharacterFormat), null) : base.method_4().method_316(BookmarkStart.b("ᔴ", num), base.method_4().method_365(ownerParagraph.BreakCharacterFormat), null);
                    ef3.Height = ef8.Height;
                }
            }
        }
        this.double_0 = bottom;
        if (A_0.method_8() is Table)
        {
            Table table = A_0.method_8() as Table;
            if (!table.IsTextBox)
            {
                if ((A_0.method_8() as Interface4).imethod_3().imethod_13())
                {
                    RectangleF ef15 = new RectangleF();
                    if (this.class375_1.method_74().Count > 0)
                    {
                        ef15 = new RectangleF(this.class375_1.method_74().method_4(0).method_69().X, this.class375_1.method_74().method_4(0).method_69().Y, this.class375_1.method_69().Width, this.class375_1.method_69().Height);
                    }
                    else
                    {
                        ef15 = this.class375_1.method_69();
                    }
                    if (!ef15.IsEmpty)
                    {
                        float left = ef15.Left;
                        float top = ef15.Top;
                        float width = ef15.Width;
                        float height = ef15.Height;
                        list_0.Add(new RectangleF(left, top, width, height));
                        list_1.Add(TextWrappingStyle.Square);
                    }
                }
            }
            else
            {
                if ((table.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.InFrontOfText) || (table.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Behind))
                {
                    Paragraph paragraph5 = base.class375_0.method_73() as Paragraph;
                    if (((paragraph5 == null) || (base.class375_0.method_69().Height != 0f)) || !(paragraph5.Text == string.Empty))
                    {
                        ef3.Height = base.class375_0.method_69().Height;
                    }
                    else
                    {
                        SizeF ef10 = base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ᔴ", num), base.method_4().method_376(paragraph5.BreakCharacterFormat), null) : base.method_4().method_316(BookmarkStart.b("ᔴ", num), base.method_4().method_365(paragraph5.BreakCharacterFormat), null);
                        Class213 class4 = base.class375_0.method_73().imethod_0() as Class213;
                        switch (class4.method_55())
                        {
                            case LineSpacingRule.AtLeast:
                                if (ef10.Height <= class4.method_53())
                                {
                                    ef3.Height = class4.method_53();
                                    break;
                                }
                                ef3.Height = ef10.Height;
                                break;

                            case LineSpacingRule.Exactly:
                                ef3.Height = Math.Abs(class4.method_53());
                                break;

                            case LineSpacingRule.Multiple:
                                if (class4.method_53() != 0f)
                                {
                                    ef3.Height = ef10.Height * (class4.method_53() / 12f);
                                    break;
                                }
                                ef3.Height = ef10.Height;
                                break;
                        }
                    }
                }
                if (((table.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline) && (table.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (table.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind))
                {
                    this.double_0 = 0.0;
                    ef3.Height = ((((float) this.double_0) - ef.Y) < 0f) ? 0f : (((float) this.double_0) - ef.Y);
                    if (ef3.Height == 0f)
                    {
                        Paragraph paragraph6 = base.class375_0.method_73() as Paragraph;
                        if (((paragraph6 != null) && (base.class375_0.method_69().Height == 0f)) && (paragraph6.Text == string.Empty))
                        {
                            SizeF ef13 = base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ᔴ", num), base.method_4().method_376(paragraph6.BreakCharacterFormat), null) : base.method_4().method_316(BookmarkStart.b("ᔴ", num), base.method_4().method_365(paragraph6.BreakCharacterFormat), null);
                            ef3.Height = ef13.Height;
                        }
                        else
                        {
                            ef3.Height = base.class375_0.method_69().Height;
                        }
                    }
                    if (table.TextBoxFormat.IsAllowInCell)
                    {
                        RectangleF ef14 = new RectangleF();
                        if (this.class375_1.method_74().Count > 0)
                        {
                            ef14 = new RectangleF(this.class375_1.method_74().method_4(0).method_69().X, this.class375_1.method_74().method_4(0).method_69().Y, this.class375_1.method_69().Width, this.class375_1.method_69().Height);
                        }
                        else
                        {
                            ef14 = this.class375_1.method_69();
                        }
                        if (!ef14.IsEmpty)
                        {
                            RowFormat.TablePositioning positioning = (A_0.method_8() as Interface4).imethod_3().imethod_15();
                            float x = ef14.Left - positioning.DistanceFromLeft;
                            float y = ef14.Top - positioning.DistanceFromTop;
                            float num14 = (ef14.Width + positioning.DistanceFromLeft) + positioning.DistanceFromRight;
                            float num15 = (ef14.Height + positioning.DistanceFromTop) + positioning.DistanceFromBottom;
                            list_0.Add(new RectangleF(x, y, num14, num15));
                            list_1.Add(TextWrappingStyle.Square);
                        }
                    }
                }
                ef3.Height = Math.Max(num10, ef3.Height);
            }
            if (this.method_74(table) && !base.method_4().method_135())
            {
                this.method_53(table);
            }
            if (this.method_74(table))
            {
                return;
            }
        }
        if ((((base.class375_0.method_73() is Paragraph) && (base.class375_0.method_74().Count == 1)) && ((base.class375_0.method_74().method_4(0).method_73() is Paragraph) && (base.class375_0.method_74().method_4(0).method_74().Count == 1))) && ((base.class375_0.method_74().method_4(0).method_74().method_4(0).method_73() is Break) && ((base.class375_0.method_74().method_4(0).method_74().method_4(0).method_73() as Break).BreakType == BreakType.ColumnBreak)))
        {
            ef3 = new SizeF();
        }
        if (this.method_72())
        {
            base.class375_0.method_70(new RectangleF(ef.Location, new SizeF(ef3.Width, ef3.Height + 0.5f)));
        }
        else
        {
            RectangleF ef16 = new RectangleF(ef.Location, ef3);
            Class312 class5 = base.method_4().method_28().method_51(ef16, base.class375_0.method_73());
            if (((!class5.method_0().IsEmpty && (class5.method_2().method_0() != TextWrappingStyle.Inline)) && ((class5.method_2().method_0() != TextWrappingStyle.Behind) && (class5.method_2().method_0() != TextWrappingStyle.InFrontOfText))) && (class5.method_2().method_0() != TextWrappingStyle.TopAndBottom))
            {
                float num20 = ef16.Width;
                float single1 = ef16.Height;
                if ((class5.method_2().method_0() != TextWrappingStyle.TopAndBottom) && (base.class375_0.method_73() is DocPicture))
                {
                    num20 = class5.method_0().X - ef.X;
                }
                base.class375_0.method_70(new RectangleF(ef.Location, new SizeF(num20, ef3.Height)));
            }
            else
            {
                base.class375_0.method_70(new RectangleF(ef.Location, ef3));
            }
        }
        if (((!(base.class375_0.method_73() is Paragraph) && (A_0.method_8() is Paragraph)) && ((A_0.method_8().imethod_0() as Class213).method_105() && A_0.method_8().imethod_0().imethod_32())) && base.method_4().method_135())
        {
            base.class375_0.method_70(new RectangleF(ef.Location, new SizeF(ef.Width, 0f)));
        }
        this.method_54(none, base.class375_0);
        if (!(base.interface30_0 as Class304).method_10() && (base.class375_0.method_73() is Paragraph))
        {
            Paragraph paragraph7 = base.class375_0.method_73() as Paragraph;
            Class213 class6 = base.class375_0.method_73().imethod_0() as Class213;
            if ((paragraph7.IsEndOfSection && string.IsNullOrEmpty(class6.method_65())) && paragraph7.IsEmptyParagraph)
            {
                Section section = paragraph7.method_49();
                if (section != null)
                {
                    Section nextSibling = section.NextSibling as Section;
                    if ((nextSibling != null) && (nextSibling.BreakCode == SectionBreakType.NoBreak))
                    {
                        float num21 = (paragraph7.PreviousSibling == null) ? (base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ᔴ", num), base.method_4().method_376(paragraph7.BreakCharacterFormat), null).Height : base.method_4().method_316(BookmarkStart.b("ᔴ", num), paragraph7.BreakCharacterFormat.Font, null).Height) : 0f;
                        base.class375_0.method_70(new RectangleF(base.class375_0.method_69().Location, new SizeF(base.class375_0.method_69().Width, num21)));
                    }
                }
            }
        }
        if ((((((base.class375_0.method_73() is Paragraph) && !(base.class375_0.method_73() as Paragraph).IsInCell) && ((base.class375_0.method_74().Count == 1) && (base.class375_0.method_74().method_4(0).method_73() is Paragraph))) && ((!(base.class375_0.method_73() as Paragraph).HasRelayout && (base.class375_0.method_73().imethod_0() as Class213).method_105()) && (((base.class375_0.method_73() as Paragraph).Format.FrameVerticalPos == 2) && ((base.class375_0.method_73() as Paragraph).Format.FrameYEx != -1)))) && ((base.class375_0.method_73() as Paragraph).Format.FrameY < 0)) && ((((base.class375_0.method_73() as Paragraph).NextSibling == null) || ((((base.class375_0.method_73() as Paragraph).NextSibling != null) && ((base.class375_0.method_73() as Paragraph).NextSibling is Paragraph)) && !((base.class375_0.method_73() as Paragraph).NextSibling as Paragraph).Format.IsFrame)) || ((((base.class375_0.method_73() as Paragraph).NextSibling != null) && ((base.class375_0.method_73() as Paragraph).NextSibling is Table)) && !((base.class375_0.method_73() as Paragraph).NextSibling as Table).IsFrame)))
        {
            Document document = (base.class375_0.method_73() as Paragraph).Document;
            if ((document != null) && !document.LayoutVariables.method_0().Contains(base.class375_0.method_73() as Paragraph))
            {
                document.LayoutVariables.method_0().Add(base.class375_0.method_73() as Paragraph);
            }
            (base.class375_0.method_73() as Paragraph).HasRelayout = true;
            base.class375_0.method_35(true);
        }
        if ((((A_0.method_5().method_73() is Paragraph) && ((A_0.method_5().method_73() as Paragraph).interface23_0 as Class210).method_37()) && ((A_0.method_5().method_73().imethod_0() as Class210).method_81() && (A_0.method_5().method_73().imethod_0() as Class210).Interface23.imethod_40())) && !base.method_4().method_19().IsHidden)
        {
            A_0.method_5().method_70(new RectangleF(new PointF(A_0.method_5().method_69().X, A_0.method_5().method_69().Y), new SizeF(0f, 0f)));
        }
    }

    private bool method_65(Interface1 A_0)
    {
        if ((!(A_0 is DocPicture) || (((A_0 as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText) && ((A_0 as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind))) && (!(A_0 is ShapeObject) || (((A_0 as ShapeObject).TextWrappingStyle != TextWrappingStyle.InFrontOfText) && ((A_0 as ShapeObject).TextWrappingStyle != TextWrappingStyle.Behind))))
        {
            return false;
        }
        return true;
    }

    private float method_66(Class375 A_0, ref bool A_1)
    {
        float num = 0f;
        float num2 = -1f;
        LineSpacingRule multiple = LineSpacingRule.Multiple;
        num = this.method_67(A_0, ref multiple, ref num2);
        if (multiple == LineSpacingRule.Exactly)
        {
            A_1 = true;
        }
        return num;
    }

    private float method_67(Class375 A_0, ref LineSpacingRule A_1, ref float A_2)
    {
        float num = 0f;
        float num2 = 0f;
        float num3 = 0f;
        bool flag = false;
        bool flag2 = false;
        bool flag3 = false;
        Font font = null;
        sprᝪ rᝪ = null;
        float height = 0f;
        A_2 = -1f;
        TextRange range = null;
        Paragraph paragraph2 = (A_0.method_73() is Paragraph) ? (A_0.method_73() as Paragraph) : ((A_0.method_73() as Class65).method_2() as Paragraph);
        if ((paragraph2.ChildObjects.Count == 0) && paragraph2.SectionEndMark)
        {
            return 0f;
        }
        if (((A_0.method_74().Count == 1) && (A_0.method_74().method_4(0).method_73() is Break)) && ((A_0.method_74().method_4(0).method_73() as Break).BreakType == BreakType.LineBreak))
        {
            if (base.method_4().method_1())
            {
                rᝪ = base.method_4().method_378((A_0.method_74().method_4(0).method_73() as Break).TextRange);
            }
            else
            {
                font = base.method_4().method_367((A_0.method_74().method_4(0).method_73() as Break).TextRange);
            }
        }
        Class213 class2 = A_0.method_73().imethod_0() as Class213;
        A_1 = class2.method_55();
        A_2 = Math.Abs(class2.method_53());
        if ((A_1 == LineSpacingRule.Exactly) || ((A_1 == LineSpacingRule.AtLeast) && (A_2 > 0f)))
        {
            num = A_2;
        }
        else
        {
            Struct1 struct2;
            int num6 = 0;
            for (int i = 0; i < A_0.method_74().Count; i++)
            {
                Interface1 interface4 = A_0.method_74().method_4(i).method_73();
                string str2 = string.Empty;
                range = this.method_70(interface4, ref str2);
                if (range != null)
                {
                    CharacterFormat format3 = ((!string.IsNullOrEmpty(range.Text.Trim()) || (range.OwnerParagraph == null)) || !paragraph2.method_22()) ? range.CharacterFormat : paragraph2.BreakCharacterFormat;
                    RectangleF ef4 = new RectangleF();
                    num6 = i;
                    if (base.method_4().method_1())
                    {
                        rᝪ = base.method_4().method_381(range, format3, ref ef4, true);
                    }
                    else
                    {
                        font = base.method_4().method_370(range, format3, ref ef4, true);
                    }
                    if ((!(interface4 is Field) || (((interface4 is Field) && (interface4.imethod_0() is Class214)) && !(interface4.imethod_0() as Class214).method_15())) && (!string.IsNullOrEmpty(str2) && (str2.Trim(new char[] { ' ' }).Length > 0)))
                    {
                        height = A_0.method_74().method_4(i).method_69().Height;
                    }
                    break;
                }
            }
            for (int j = 0; j < A_0.method_74().Count; j++)
            {
                Interface1 interface2 = A_0.method_74().method_4(j).method_73();
                if (A_0.method_74().method_4(j).method_69().Height <= 0f)
                {
                    if ((interface2 is IfField) && !flag2)
                    {
                        flag3 = true;
                    }
                }
                else
                {
                    string str = string.Empty;
                    range = this.method_70(interface2, ref str);
                    flag3 = false;
                    flag2 = true;
                    if (((range != null) && (j != num6)) && (range.OwnerParagraph != null))
                    {
                        RectangleF ef = new RectangleF();
                        float num8 = 0f;
                        float num7 = 0f;
                        Font font2 = null;
                        CharacterFormat format = (!string.IsNullOrEmpty(range.Text.Trim()) || !paragraph2.method_22()) ? range.CharacterFormat : paragraph2.BreakCharacterFormat;
                        sprᝪ rᝪ2 = null;
                        if (base.method_4().method_1())
                        {
                            rᝪ2 = base.method_4().method_381(range, format, ref ef, true);
                            if (rᝪ != null)
                            {
                                num8 = base.method_4().method_347(rᝪ);
                            }
                            if (rᝪ2 != null)
                            {
                                num7 = base.method_4().method_347(rᝪ2);
                            }
                        }
                        else
                        {
                            font2 = base.method_4().method_370(range, format, ref ef, true);
                            if (font != null)
                            {
                                num8 = base.method_4().method_341(font);
                            }
                            if (font2 != null)
                            {
                                num7 = base.method_4().method_341(font2);
                            }
                        }
                        if (((font2 != null) || (rᝪ2 != null)) && (num8 < num7))
                        {
                            font = font2;
                            rᝪ = rᝪ2;
                            if ((!(interface2 is Field) || (((interface2 is Field) && (interface2.imethod_0() is Class214)) && !(interface2.imethod_0() as Class214).method_15())) && (!string.IsNullOrEmpty(str) && (str.Trim(new char[] { ' ' }).Length > 0)))
                            {
                                height = A_0.method_74().method_4(j).method_69().Height;
                            }
                        }
                    }
                    else if ((range == null) && this.method_69(A_0.method_74().method_4(j).method_73()))
                    {
                        float num11 = A_0.method_74().method_4(j).method_69().Height;
                        if (num11 > num3)
                        {
                            flag = true;
                        }
                        num3 = (num3 > num11) ? num3 : num11;
                    }
                }
            }
            if (A_0.method_73() is Paragraph)
            {
                Interface1 interface3 = A_0.method_73();
                Paragraph paragraph = interface3 as Paragraph;
                if ((((paragraph.ListFormat != null) && (paragraph.ListFormat.ListType == ListType.Bulleted)) && ((paragraph.ListFormat.CurrentListLevel != null) && (paragraph.ListFormat.CurrentListLevel.CharacterFormat != null))) && ((interface3.imethod_0() is Class210) && (interface3.imethod_0() as Class210).method_43()))
                {
                    CharacterFormat format2 = new CharacterFormat(paragraph.Document);
                    format2.ImportContainer(paragraph.ListFormat.CurrentListLevel.CharacterFormat);
                    format2.ApplyBase(paragraph.BreakCharacterFormat);
                    float num9 = 0f;
                    float num14 = 0f;
                    Font font3 = null;
                    sprᝪ rᝪ3 = null;
                    if (base.method_4().method_1())
                    {
                        rᝪ3 = base.method_4().method_376(format2);
                        if (rᝪ != null)
                        {
                            num9 = base.method_4().method_347(rᝪ);
                        }
                        if (rᝪ3 != null)
                        {
                            num14 = base.method_4().method_347(rᝪ3);
                        }
                    }
                    else
                    {
                        font3 = base.method_4().method_365(format2);
                        if (font != null)
                        {
                            num9 = base.method_4().method_341(font);
                        }
                        if (font3 != null)
                        {
                            num14 = base.method_4().method_341(font3);
                        }
                    }
                    if (((font3 != null) || (rᝪ3 != null)) && (num9 < num14))
                    {
                        font = font3;
                        rᝪ = rᝪ3;
                        num3 = (num3 > num14) ? num3 : num14;
                    }
                    format2 = null;
                }
            }
            if (base.method_4().method_1() && (rᝪ == null))
            {
                rᝪ = base.method_4().method_376(paragraph2.BreakCharacterFormat);
            }
            else if (!base.method_4().method_1() && (font == null))
            {
                font = base.method_4().method_365(paragraph2.BreakCharacterFormat);
            }
            if (base.method_4().method_1())
            {
                struct2 = base.method_4().method_346(rᝪ);
            }
            else
            {
                struct2 = base.method_4().method_339(font);
            }
            num2 = (float) struct2.method_11();
            num = (A_1 == LineSpacingRule.Multiple) ? (num2 * (A_2 / 12f)) : num2;
            if (num3 > num2)
            {
                if (flag)
                {
                    float num10 = num3;
                    if (height != 0f)
                    {
                        num10 += (float) struct2.method_4();
                    }
                    if (A_1 == LineSpacingRule.Multiple)
                    {
                        num = num10 + (num2 * ((A_2 - 12f) / 12f));
                    }
                    else
                    {
                        num = num10;
                    }
                }
                else
                {
                    num = num3;
                }
            }
        }
        A_0.method_9(Math.Max(A_0.method_8(), num));
        if ((!base.method_4().method_135() && (paragraph2 != null)) && (class2.method_106() && (A_1 != LineSpacingRule.Exactly)))
        {
            Section section = paragraph2.method_49();
            if (((section != null) && (section.PageSetup.PitchType != GridPitchType.NoGrid)) && ((section.PageSetup.PitchType != GridPitchType.SnapToChars) && this.method_68(paragraph2)))
            {
                float num13 = (float) Math.Round((double) section.PageSetup.LinePitch, 2);
                if (A_1 == LineSpacingRule.Multiple)
                {
                    float num17 = (float) Math.Round((double) (A_2 / 12f), 2);
                    num2 = (num2 >= num3) ? num2 : num3;
                    float num12 = num13 * num17;
                    if (Class59.smethod_4(num2, num12, 0.3f) > 0)
                    {
                        float num18 = num2 % num13;
                        return (num2 + (num13 - num18));
                    }
                    if (Class59.smethod_4(num2, num13, 0.3f) > 0)
                    {
                        float num16 = num2 % num13;
                        return Math.Max(num2 + (num13 - num16), num12);
                    }
                    if (Class59.smethod_4(num12, num13, 0.3f) < 0)
                    {
                        return num13;
                    }
                    return num12;
                }
                if (A_1 == LineSpacingRule.AtLeast)
                {
                    return Math.Max(num13, num);
                }
            }
        }
        if (flag3)
        {
            return 0f;
        }
        return num;
    }

    private bool method_68(Paragraph A_0)
    {
        if ((A_0 != null) && A_0.method_46())
        {
            TableCell cell = A_0.method_50();
            if (cell != null)
            {
                Table ownerTable = cell.OwnerRow.OwnerTable;
                if ((ownerTable != null) && !ownerTable.IsTextBox)
                {
                    return !ownerTable.DontAdjustLineHeightInTable;
                }
            }
        }
        return true;
    }

    private bool method_69(Interface1 A_0)
    {
        A_0 = (A_0 is Class542) ? (A_0 as Class542).method_2() : A_0;
        if (!(A_0 is IParagraphBase) || (((!(A_0 is DocPicture) || ((A_0 as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)) && (!(A_0 is TextBox) || ((A_0 as TextBox).Format.TextWrappingStyle != TextWrappingStyle.Inline))) && (((!(A_0 is ShapeObject) || ((A_0 as ShapeObject).TextWrappingStyle != TextWrappingStyle.Inline)) && (!(A_0 is Class7) || ((A_0 as Class7).TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline))) && ((!(A_0 is DocOleObject) || ((A_0 as DocOleObject).Interface49.get_OlePicture() == null)) || ((A_0 as DocOleObject).Interface49.get_OlePicture().TextWrappingStyle != TextWrappingStyle.Inline)))))
        {
            return false;
        }
        return true;
    }

    private TextRange method_70(Interface1 A_0, ref string A_1)
    {
        TextRange range = null;
        if (A_0 is TextRange)
        {
            range = A_0 as TextRange;
            A_1 = range.Text;
            return range;
        }
        if (A_0 is Class542)
        {
            range = (A_0 as Class542).method_2() as TextRange;
            A_1 = (A_0 as Class542).method_0();
            return range;
        }
        if (A_0 is Symbol)
        {
            range = (A_0 as Symbol).method_30();
        }
        return range;
    }

    internal Paragraph method_71(DocumentObject A_0)
    {
        Paragraph owner = A_0.Owner as Paragraph;
        if (owner == null)
        {
            for (DocumentObject obj2 = A_0.Owner; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2 is Paragraph)
                {
                    return (obj2 as Paragraph);
                }
            }
        }
        return owner;
    }

    private bool method_72()
    {
        bool flag = false;
        if ((!(base.class375_0.method_73() is TableCell) || ((base.class375_0.method_73() as TableCell).CellFormat.VerticalAlignment != VerticalAlignment.Top)) || (base.class375_0.method_73().imethod_0().imethod_1().method_12() > 0.0))
        {
            return flag;
        }
        if ((base.class375_0.method_73() as TableCell).OwnerRow.HeightType == TableRowHeightType.Exactly)
        {
            float height = (base.class375_0.method_73() as TableCell).OwnerRow.Height;
            if (height < 0f)
            {
                height = -height;
            }
            if (height <= 1f)
            {
                flag = true;
            }
            return flag;
        }
        return true;
    }

    internal bool method_73(Paragraph A_0)
    {
        bool flag = true;
        if (A_0.IsInCell)
        {
            flag = false;
        }
        bool flag2 = false;
        if ((A_0 != null) && (((Interface1) A_0).imethod_0() as Class213).method_105())
        {
            flag2 = true;
        }
        return (flag2 && flag);
    }

    internal bool method_74(Table A_0)
    {
        bool flag = true;
        if (A_0.OwnerTextBody is TableCell)
        {
            flag = false;
        }
        return (A_0.IsFrame && flag);
    }

    internal bool method_75(Paragraph A_0)
    {
        if (A_0 == null)
        {
            return false;
        }
        bool flag2 = false;
        if (A_0.IsInCell)
        {
            flag2 = true;
        }
        bool flag = false;
        if ((A_0 != null) && (((Interface1) A_0).imethod_0() as Class213).method_105())
        {
            flag = true;
        }
        if (!flag2)
        {
            return flag;
        }
        return true;
    }

    internal bool method_76()
    {
        if ((this.class375_1.method_73() != null) && (this.class375_1.method_74().Count > 0))
        {
            for (int i = 0; i < this.class375_1.method_74().Count; i++)
            {
                if ((!(this.class375_1.method_74().method_4(i).method_73() is BookmarkStart) && !(this.class375_1.method_74().method_4(i).method_73() is BookmarkEnd)) && (!(this.class375_1.method_74().method_4(i).method_73() is FieldMark) && (!(this.class375_1.method_74().method_4(i).method_73() is TextRange) || !((this.class375_1.method_74().method_4(i).method_73() as TextRange).Text.Trim() == string.Empty))))
                {
                    return false;
                }
                if (this.class375_1.method_74().method_4(i).method_73() is Paragraph)
                {
                    Class375 class2 = this.class375_1.method_74().method_4(i);
                    if ((this.class375_1.method_74().method_4(i).method_73() is Paragraph) && (class2.method_74().Count > 0))
                    {
                        for (int j = 0; j < class2.method_74().Count; j++)
                        {
                            if ((!(class2.method_74().method_4(i).method_73() is BookmarkStart) && !(class2.method_74().method_4(j).method_73() is BookmarkEnd)) && (!(class2.method_74().method_4(j).method_73() is FieldMark) && (!(class2.method_74().method_4(i).method_73() is TextRange) || !((class2.method_74().method_4(i).method_73() as TextRange).Text.Trim() == string.Empty))))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        return true;
    }

    internal bool method_77()
    {
        if ((this.class375_1.method_73() is Paragraph) && (this.class375_1.method_74().Count > 0))
        {
            bool flag;
            Paragraph paragraph = this.class375_1.method_73() as Paragraph;
            IDocumentObjectCollection widgetCollection = paragraph.WidgetCollection;
            using (IEnumerator enumerator = widgetCollection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    object current = enumerator.Current;
                    if (((current is TextRange) && ((current as TextRange).DocumentObjectType == DocumentObjectType.TextRange)) || (((widgetCollection.Count == 1) && (current is Break)) && ((current as Break).BreakType == BreakType.ColumnBreak)))
                    {
                        goto Label_0098;
                    }
                }
                goto Label_00B2;
            Label_0098:
                flag = true;
            }
            return flag;
        }
    Label_00B2:
        return false;
    }

    internal bool method_78()
    {
        if ((this.class375_1.method_73() is Paragraph) && (this.class375_1.method_74().Count > 0))
        {
            bool flag;
            Paragraph paragraph = this.class375_1.method_73() as Paragraph;
            using (IEnumerator enumerator = paragraph.WidgetCollection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    object current = enumerator.Current;
                    if (((current is IfField) && ((current as IfField).DocumentObjectType == DocumentObjectType.Field)) && (((current as IfField).End != null) && ((current as IfField).End.Owner == paragraph)))
                    {
                        goto Label_0099;
                    }
                }
                goto Label_00B3;
            Label_0099:
                flag = true;
            }
            return flag;
        }
    Label_00B3:
        return false;
    }

    internal bool method_79()
    {
        if ((this.class375_1.method_73() is Paragraph) && (this.class375_1.method_74().Count > 0))
        {
            Paragraph paragraph = this.class375_1.method_73() as Paragraph;
            IDocumentObjectCollection widgetCollection = paragraph.WidgetCollection;
            int num = 0;
            int num2 = 0;
            foreach (object obj2 in widgetCollection)
            {
                if (obj2 is TextRange)
                {
                    if ((obj2 as TextRange).CharacterFormat.Hidden)
                    {
                        num++;
                    }
                    num2++;
                }
            }
            if (num == num2)
            {
                return true;
            }
        }
        return false;
    }

    private void method_80()
    {
        if (base.class375_0.method_74().Count > 0)
        {
            Class206 class2 = base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_73().imethod_0() as Class206;
            if (((class2 != null) && (this.class375_1 != null)) && ((class2.method_21() != TabJustification.Left) && (class2.method_21() != TabJustification.Right)))
            {
                RectangleF ef = this.class375_1.method_69();
                float num = (float) class2.method_22((double) ef.X, null);
                switch (class2.method_21())
                {
                    case TabJustification.Centered:
                        num -= ef.Width / 2f;
                        break;

                    case TabJustification.Right:
                    case TabJustification.Decimal:
                        num -= ef.Width;
                        break;
                }
                if (num > 0f)
                {
                    ef.X += num;
                }
                this.class375_1.method_70(ef);
            }
        }
    }

    private int method_81(Class615 A_0)
    {
        int num2 = (!(this.interface1_2 is Class820) || ((this.interface1_2 as Class820).method_1() >= (this.interface1_2 as Class820).method_0().imethod_5())) ? A_0.method_5().method_74().Count : (this.interface1_2 as Class820).method_1();
        if (A_0.method_8() is Table)
        {
            int num = num2;
            if (!(this.interface1_2 is Class820))
            {
                this.method_87(A_0.method_8() as Table, ref num2);
            }
            if ((num <= num2) || (num2 <= 0))
            {
                return num2;
            }
            for (num -= num2; num > 0; num--)
            {
                A_0.method_5().method_74().method_12(A_0.method_5().method_74().Count - 1);
            }
        }
        return num2;
    }

    private bool method_82(Class615 A_0)
    {
        if (((A_0.method_5() != null) && (A_0.method_5().method_73() is Table)) && (((this.method_50() && (base.class375_0.method_74().Count == 0)) && (base.method_4().method_28().method_3().Count == 2)) || (base.class375_0.method_73() is TableCell)))
        {
            this.method_61(A_0);
            this.method_59(A_0.method_0());
            base.layoutState_0 = LayoutState.Splitted;
            return true;
        }
        if ((base.class375_0.method_74().Count > 0) && ((!this.method_88() || (base.method_4().method_28().method_3().Count > 2)) || ((this.class375_1 != null) && (this.class375_1.method_73() is Table))))
        {
            Interface1 interface2 = base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_73();
            Class210 class2 = interface2.imethod_0() as Class210;
            if (((this.class375_1 != null) && (this.class375_1.method_73() is Table)) && ((this.class375_1.method_74().Count > 0) && this.method_50()))
            {
                Table table2 = this.class375_1.method_73() as Table;
                if ((table2.TableFormat != null) && !table2.TableFormat.WrapTextAround)
                {
                    int count = A_0.method_5().method_74().Count;
                    int num = this.method_81(A_0);
                    if (num > 0)
                    {
                        this.method_61(A_0);
                        if (num != count)
                        {
                            Interface1 interface4 = new Class820(table2, num + 1);
                            this.method_59(interface4);
                        }
                        else
                        {
                            this.method_59(A_0.method_0());
                        }
                        base.layoutState_0 = LayoutState.Splitted;
                    }
                    else if (num == 0)
                    {
                        int num3 = base.class375_0.method_74().Count;
                        interface2 = this.method_83(interface2, base.class375_0, base.class375_0.method_74().Count - 1);
                        if ((base.class375_0.method_74().Count == num3) && !(interface2 is Class820))
                        {
                            this.method_59(this.method_30());
                            base.layoutState_0 = LayoutState.Splitted;
                        }
                        else
                        {
                            this.method_59(interface2);
                            base.layoutState_0 = LayoutState.Splitted;
                        }
                    }
                    return true;
                }
                if ((table2.TableFormat != null) && table2.TableFormat.WrapTextAround)
                {
                    this.method_61(A_0);
                    this.method_59(A_0.method_0());
                    base.layoutState_0 = LayoutState.Splitted;
                    return true;
                }
            }
            if (class2 != null)
            {
                if (!class2.method_35() || !this.method_50())
                {
                    if (class2.method_39() && !this.bool_6)
                    {
                        base.class375_0.method_74().method_12(base.class375_0.method_74().Count - 1);
                        this.int_0--;
                        if (class2.method_19() < 0f)
                        {
                            class2.method_99();
                        }
                        this.method_59(interface2);
                        base.layoutState_0 = LayoutState.Splitted;
                        return true;
                    }
                    if ((class2.method_35() && this.bool_6) && this.method_89())
                    {
                        if (base.class375_0.method_74().Count > 0)
                        {
                            interface2 = this.method_83(interface2, base.class375_0, base.class375_0.method_74().Count - 1);
                        }
                        Interface1 interface3 = this.method_30();
                        if ((interface3 != null) && (interface3 != interface2))
                        {
                            interface2 = interface3;
                        }
                        if (class2.method_19() < 0f)
                        {
                            class2.method_99();
                        }
                        this.method_59(interface2);
                        base.layoutState_0 = LayoutState.Splitted;
                        return true;
                    }
                }
                else
                {
                    interface2 = this.method_83(interface2, base.class375_0, base.class375_0.method_74().Count - 1);
                    if (base.class375_0.method_74().Count > 0)
                    {
                        if (interface2 != base.class375_0.method_74().method_4(0).method_73())
                        {
                            this.method_59(interface2);
                        }
                        else
                        {
                            this.method_59(base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_73());
                        }
                    }
                    else
                    {
                        this.method_59(interface2);
                    }
                    base.layoutState_0 = LayoutState.Splitted;
                    if (interface2 is Class820)
                    {
                        return true;
                    }
                }
            }
            else if (((class2 == null) && (interface2 is Table)) && this.method_50())
            {
                Table table = interface2 as Table;
                if (table.method_72(table.Rows.Count - 1) && (!table.DontBreakWrappedTables || ((table.TableFormat != null) && !table.TableFormat.WrapTextAround)))
                {
                    interface2 = this.method_83(interface2, base.class375_0, base.class375_0.method_74().Count - 1);
                    this.method_59(interface2);
                    base.layoutState_0 = LayoutState.Splitted;
                    return true;
                }
            }
        }
        return false;
    }

    private Interface1 method_83(Interface1 A_0, Class375 A_1, int A_2)
    {
        RectangleF ef = A_1.method_74().method_4(A_2).method_69();
        int num = A_2;
        Class210 class2 = A_0.imethod_0() as Class210;
        if ((((A_2 == 0) && (class2 != null)) && (class2.method_35() && (base.method_4().method_28() != null))) && ((base.method_4().method_28().method_3().Count > 2) && (base.method_4().method_28().method_3().method_4(0).method_69().Bottom < A_1.method_74().method_0().method_69().Top)))
        {
            Class375 class4 = A_1.method_74().method_4(0);
            A_1.method_74().method_12(0);
            this.method_43(class4, true);
            this.int_0--;
            return A_0;
        }
        if ((class2 == null) && (A_0 is Table))
        {
            Table table2 = A_0 as Table;
            if ((table2.TableFormat != null) && !table2.TableFormat.WrapTextAround)
            {
                int num5 = 0;
                int num6 = 0;
                this.method_87(table2, ref num5);
                if ((num5 != 0) && (num6 > num5))
                {
                    this.method_86(ef, A_1, A_1.method_74().method_0(), A_2, num, num6, num5);
                    return base.interface1_0;
                }
                if ((num5 == 0) && (A_2 > 0))
                {
                    class2 = A_1.method_74().method_4(A_1.method_74().Count - 1).method_73().imethod_0() as Class210;
                    if ((class2 != null) && !class2.method_35())
                    {
                        this.method_85(ef, A_1, A_1.method_74().Count - 1, num);
                        return A_0;
                    }
                    A_0 = A_1.method_74().method_4(A_2).method_73();
                    if (A_0 is Table)
                    {
                        Table table3 = A_0 as Table;
                        TableRow row = table3.Rows[0];
                        if (((row.Cells.Count > 0) && (row.Cells[0].Paragraphs.Count > 0)) && row.Cells[0].Paragraphs[0].Format.KeepFollow)
                        {
                            class2 = ((Interface1) row.Cells[0].Paragraphs[0]).imethod_0() as Class210;
                        }
                    }
                }
                else if ((((num5 == 0) && (A_2 == 0)) && ((base.method_4().method_28() != null) && (base.method_4().method_28().method_3().Count > 2))) && (base.method_4().method_28().method_3().method_4(0).method_69().Bottom < A_1.method_74().method_0().method_69().Top))
                {
                    A_0 = A_1.method_74().method_4(A_2).method_73();
                    this.method_84(ef, A_1, A_2, num, true);
                    this.method_43(this.class375_1, true);
                }
            }
        }
        else if ((class2 != null) && !class2.method_35())
        {
            return A_0;
        }
        while (class2 != null)
        {
            if (A_2 <= 0)
            {
                return A_0;
            }
            if (class2.method_35())
            {
                int num4 = A_2 - 1;
                Class375 class3 = A_1.method_74().method_4(num4);
                RectangleF ef3 = class3.method_69();
                Interface1 interface2 = class3.method_73();
                class2 = interface2.imethod_0() as Class210;
                if ((class2 != null) && !class2.method_35())
                {
                    this.method_85(ef, A_1, num4, num);
                    return A_0;
                }
                if ((class2 != null) || !(class3.method_73() is Table))
                {
                    A_0 = interface2;
                    if ((((num4 == 0) && (class2 != null)) && (class2.method_35() && (base.method_4().method_28() != null))) && ((base.method_4().method_28().method_3().Count > 2) && (base.method_4().method_28().method_3().method_4(0).method_69().Bottom < ef3.Top)))
                    {
                        this.method_84(ef, A_1, num4, num, true);
                    }
                }
                else
                {
                    Table table = class3.method_73() as Table;
                    if ((table.TableFormat != null) && !table.TableFormat.WrapTextAround)
                    {
                        int count = class3.method_74().Count;
                        int num3 = count;
                        this.method_87(table, ref count);
                        if (((count != 0) && (num3 > count)) && ((base.method_4().method_28().method_3().Count > 2) || (num4 > 0)))
                        {
                            this.method_86(ef, A_1, class3, num4, num, num3, count);
                            return base.interface1_0;
                        }
                        if ((count == 0) && (num4 > 0))
                        {
                            class2 = A_1.method_74().method_4(num4 - 1).method_73().imethod_0() as Class210;
                            if ((class2 != null) && !class2.method_35())
                            {
                                this.method_85(ef, A_1, num4 - 1, num);
                                return A_0;
                            }
                        }
                        else if (num4 != 0)
                        {
                            if (count == num3)
                            {
                                this.method_85(ef, A_1, num4, num);
                                return A_0;
                            }
                        }
                        else if (((base.method_4().method_28() != null) && (base.method_4().method_28().method_3().Count > 2)) && (base.method_4().method_28().method_3().method_4(0).method_69().Bottom < ef3.Top))
                        {
                            this.method_84(ef, A_1, num4, num, true);
                        }
                    }
                    else if (num4 > 0)
                    {
                        this.method_85(ef, base.class375_0, num4, num);
                    }
                    A_0 = interface2;
                }
                A_2--;
            }
        }
        return A_0;
    }

    private void method_84(RectangleF A_0, Class375 A_1, int A_2, int A_3, bool A_4)
    {
        int num3 = A_4 ? (A_2 - 1) : A_2;
        float num2 = A_0.Bottom - A_1.method_74().method_4(A_2).method_69().Bottom;
        Section section = (A_1.method_73() is Section) ? (A_1.method_73() as Section) : ((!(A_1.method_73() is Class65) || !((A_1.method_73() as Class65).method_2() is Section)) ? null : ((A_1.method_73() as Class65).method_2() as Section));
        if (section == null)
        {
            Interface1 interface2 = A_1.method_74().method_4(A_2).method_73();
            section = this.method_35(A_1, ref interface2);
            if (section == null)
            {
                if (A_1.method_73() is Class65)
                {
                    interface2 = (A_1.method_73() as Class65).method_2();
                }
                else
                {
                    interface2 = A_1.method_73();
                }
                section = (interface2 as DocumentObject).method_2();
            }
        }
        if ((section != null) && (num2 < section.PageSetup.ClientHeight))
        {
            for (int i = A_3; i > num3; i--)
            {
                Class375 class2 = A_1.method_74().method_4(i);
                A_1.method_74().method_12(i);
                this.method_43(class2, true);
                this.int_0--;
            }
        }
    }

    private void method_85(RectangleF A_0, Class375 A_1, int A_2, int A_3)
    {
        this.method_84(A_0, A_1, A_2, A_3, false);
    }

    private void method_86(RectangleF A_0, Class375 A_1, Class375 A_2, int A_3, int A_4, int A_5, int A_6)
    {
        this.method_84(A_0, A_1, A_3, A_4, true);
        if (A_5 > A_6)
        {
            for (int i = A_5 - A_6; i > 0; i--)
            {
                A_2.method_74().method_12(A_2.method_74().Count - 1);
            }
            A_1.method_74().method_7(A_2);
            base.interface1_0 = new Class820(A_2.method_73() as Interface4, A_6 + 1);
            (A_2.method_73() as Interface4).imethod_3().imethod_10(true);
            base.layoutState_0 = LayoutState.Splitted;
        }
    }

    private void method_87(Table A_0, ref int A_1)
    {
        for (int i = A_1 - 1; i > -1; i--)
        {
            TableRow row = A_0.Rows[i];
            if (((row.Cells.Count <= 0) || (row.Cells[0].Paragraphs.Count <= 0)) || !row.Cells[0].Paragraphs[0].Format.KeepFollow)
            {
                break;
            }
            A_1--;
        }
    }

    private bool method_88()
    {
        if (base.class375_0.method_74().Count != 1)
        {
            return false;
        }
        return ((((base.class375_0.method_73() is TableCell) || ((base.class375_0.method_73() is Class65) && ((base.class375_0.method_73() as Class65).method_2() is TableCell))) && ((((base.class375_0.method_73().imethod_0() as Class211).method_117() - base.class375_0.method_73().imethod_0().imethod_1().method_4()) - base.class375_0.method_73().imethod_0().imethod_0().method_4()) == (base.interface30_0 as Class304).method_4().Y)) || !(base.class375_0.method_73() is TableCell));
    }

    private bool method_89()
    {
        bool flag;
        Paragraph paragraph = this.class375_1.method_73() as Paragraph;
        Table owner = (flag = paragraph.IsInCell) ? (paragraph.Owner.Owner.Owner as Table) : null;
        for (flag = owner.IsInCell; flag; flag = owner.IsInCell)
        {
            owner = owner.Owner.Owner.Owner as Table;
        }
        if (owner != null)
        {
            Paragraph paragraph2 = owner.Rows[0].Cells[0].ChildObjects[0] as Paragraph;
            return paragraph2.Format.KeepFollow;
        }
        return false;
    }

    private bool method_90(DocumentObject A_0)
    {
        if (A_0 != null)
        {
            IDocumentObject previousSibling = A_0.PreviousSibling;
            if (previousSibling != null)
            {
                if ((previousSibling is Paragraph) && (previousSibling as Paragraph).Format.KeepFollow)
                {
                    return true;
                }
                if (previousSibling is Table)
                {
                    Table table = previousSibling as Table;
                    if (table.method_72(table.Rows.Count - 1))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public override Class375 vmethod_0(RectangleF A_0)
    {
        bool flag = true;
        if ((base.method_4().method_28() != null) && (base.method_4().method_28().method_3().Count >= 2))
        {
            if ((base.method_4().method_28().method_3().method_4(0).method_69().Bottom == A_0.Top) || (base.method_4().method_28().method_28().Margins.Top == A_0.Top))
            {
                base.method_4().method_28().method_2(true);
            }
            TableCell cell = (base.interface1_1 is TableCell) ? (base.interface1_1 as TableCell) : ((!(base.interface1_1 is Class65) || !((base.interface1_1 as Class65).method_2() is TableCell)) ? null : ((base.interface1_1 as Class65).method_2() as TableCell));
            if (((cell == null) && ((base.method_4().method_0().Count > 1) || (base.method_4().method_28().method_3().Count > 2))) && ((base.method_4().method_28().method_3().method_4(0).method_69().Bottom == A_0.Top) || ((base.method_4().method_28().method_28().Margins.Top == A_0.Top) && (base.method_4().method_28().method_28().Margins.Top > base.method_4().method_28().method_3().method_4(0).method_69().Bottom))))
            {
                flag = false;
                Paragraph paragraph = (base.interface1_1 is Paragraph) ? (base.interface1_1 as Paragraph) : ((!(base.interface1_1 is Class65) || !((base.interface1_1 as Class65).method_2() is Paragraph)) ? null : ((base.interface1_1 as Class65).method_2() as Paragraph));
                if (((base.interface1_1 != null) && (paragraph != null)) && (((paragraph.IsStartOfSection && (base.interface1_1.imethod_0() as Class213).method_73()) && !(base.interface1_1 is Class65)) || ((paragraph.IsInCell || paragraph.Format.PageBreakBefore) || (paragraph.interface23_0 as Class213).method_101())))
                {
                    flag = true;
                }
            }
            else if ((cell == null) && (base.method_4().method_0().Count == 1))
            {
                Paragraph paragraph2 = (base.interface1_1 is Paragraph) ? (base.interface1_1 as Paragraph) : null;
                if (((paragraph2 != null) && paragraph2.IsStartOfSection) && paragraph2.Format.BeforeAutoSpacing)
                {
                    flag = false;
                }
            }
        }
        base.method_17(A_0, flag);
        base.method_21(A_0.Location, flag);
        do
        {
            Class615 class2 = this.vmethod_2();
            if (class2 != null)
            {
                class2.method_11(base.method_10());
            }
            if (class2 == null)
            {
                if (this.bool_6)
                {
                    if ((((base.class375_0.method_73() is Section) && (this.interface1_2 != null)) && (((this.interface1_2 is Paragraph) && (this.interface1_2.imethod_0() is Class213)) && (this.interface1_2.imethod_0() as Class213).method_37())) || (((base.class375_0.method_73() is Paragraph) && (base.class375_0.method_73().imethod_0() is Class213)) && ((base.class375_0.method_73().imethod_0() as Class213).method_37() && (base.class375_0.method_73().imethod_0() as Class213).method_33())))
                    {
                        base.layoutState_0 = LayoutState.Breaked;
                    }
                    else
                    {
                        base.layoutState_0 = LayoutState.Fitted;
                    }
                }
                break;
            }
            if ((((class2.method_8() is TextRange) || (class2.method_8() is Class542)) || ((class2.method_8() is BookmarkStart) || (class2.method_8() is BookmarkEnd))) || (((class2.method_8() is Break) || ((class2.method_8() is DocPicture) && ((class2.method_8() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))) || ((class2.method_8() is ShapeObject) && ((class2.method_8() as ShapeObject).TextWrappingStyle == TextWrappingStyle.Inline))))
            {
                bool flag2;
                SizeF ef6 = this.method_39(class2);
                float width = (flag2 = (class2.method_8() is DocPicture) || (class2.method_8() is ShapeObject)) ? ef6.Width : base.method_3().method_13().Width;
                Paragraph paragraph3 = (class2.method_8() is ParagraphBase) ? (class2.method_8() as ParagraphBase).OwnerParagraph : null;
                RectangleF ef = new RectangleF(base.method_3().method_13().Location, new SizeF(width, ef6.Height));
                Class312 class3 = base.method_4().method_28().method_51(ef, class2.method_8());
                float y = base.method_3().method_13().Location.Y;
                while (this.method_34(class2, A_0, ref class3))
                {
                    ef = new RectangleF(base.method_3().method_13().Location, ef.Size);
                    class3 = base.method_4().method_28().method_51(ef, class2.method_8());
                }
                while (!class3.method_0().IsEmpty)
                {
                    RectangleF ef4 = this.method_38(class3, base.method_3().method_13(), A_0, paragraph3, flag2, ef.Height, y);
                    if (!ef4.IsEmpty)
                    {
                        base.method_19(ef4);
                        A_0 = ef4;
                        if (ef4.Left < class3.method_0().Left)
                        {
                            if ((class2.method_8() is DocPicture) || (class2.method_8() is ShapeObject))
                            {
                                ef = new RectangleF(ef4.Location, new SizeF(width, ef.Height));
                            }
                            else
                            {
                                ef = new RectangleF(ef4.Location, new SizeF(ef4.Width, ef.Height));
                            }
                        }
                        else
                        {
                            ef = new RectangleF(ef4.Location, ef.Size);
                        }
                        y = class3.method_0().Bottom;
                        class3 = base.method_4().method_28().method_51(ef, class2.method_8());
                    }
                    else
                    {
                        class3 = new Class312();
                    }
                }
            }
            class2.method_2().imethod_27(base.method_2().imethod_26());
            class2.method_4().method_129(base.method_3());
            this.vmethod_10(class2);
            this.method_60(class2);
        }
        while (base.method_1() == LayoutState.Unknown);
        this.vmethod_1();
        return base.class375_0;
    }

    protected override void vmethod_1()
    {
        base.vmethod_1();
        if (((((base.class375_0.method_74().Count > 0) && (base.class375_0.method_73() is Class65)) && (((base.class375_0.method_73() as Class65).method_2() is Section) && (((base.class375_0.method_73() as Class65).method_2() as Section).Columns.Count > 1))) && (((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling != null) && (((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling is Section)) && (((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling as Section).BreakCode == SectionBreakType.NoBreak) && base.class375_0.method_73().imethod_0().imethod_44()))) && !base.class375_0.method_73().imethod_0().imethod_46())
        {
            Section section = (base.class375_0.method_73() is Section) ? (base.class375_0.method_73() as Section) : ((!(base.class375_0.method_73() is Class65) || !((base.class375_0.method_73() as Class65).method_2() is Section)) ? null : ((base.class375_0.method_73() as Class65).method_2() as Section));
            base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_73();
            Class375 class2 = (base.method_4().method_28().method_3().Count > 2) ? base.method_4().method_28().method_3().method_4(base.method_4().method_28().method_3().Count - 1) : null;
            Interface1 interface2 = null;
            if (((class2 != null) && (section == this.method_35(class2, ref interface2))) && ((Class59.smethod_5((double) base.class375_0.method_69().Y, (double) class2.method_69().Y, 0.005) == 0) && (Class59.smethod_5((double) base.class375_0.method_69().Height, (double) class2.method_69().Height, 0.005) > 0)))
            {
                float width = section.Columns[base.method_4().method_132().imethod_0().method_21() - 1].Width;
                float num2 = base.class375_0.method_117();
                float num3 = ((((base.class375_0.method_69().Width < 1f) || (num2 < 1f)) || (base.class375_0.method_69().Width != width)) ? width : base.class375_0.method_69().Width) * base.class375_0.method_69().Height;
                List<Class375> list = new List<Class375>();
                Interface1 interface3 = base.class375_0.method_73();
                PointF location = base.class375_0.method_69().Location;
                for (int i = base.method_4().method_28().method_3().Count - 1; i > 1; i--)
                {
                    Interface1 interface4 = null;
                    Class375 class3 = base.method_4().method_28().method_3().method_4(i);
                    if (section != this.method_35(class3, ref interface4))
                    {
                        break;
                    }
                    num2 = class3.method_117();
                    num3 += ((((class3.method_69().Width < 1f) || (num2 < 1f)) || (class3.method_69().Width != width)) ? width : class3.method_69().Width) * class3.method_69().Height;
                    interface3 = interface4;
                    list.Add(class3);
                    location.X = Math.Min(location.X, class3.method_69().X);
                    location.Y = Math.Min(location.Y, class3.method_69().Y);
                }
                float num5 = 0f;
                if (list.Count > 0)
                {
                    foreach (Class375 class4 in list)
                    {
                        base.method_4().method_28().method_3().method_11(class4);
                    }
                    list = null;
                }
                else
                {
                    num5 = base.class375_0.method_116();
                }
                if (interface3 != null)
                {
                    float num7 = 0f;
                    foreach (Column column in section.Columns)
                    {
                        num7 += column.Width;
                    }
                    float height = Math.Max(num3 / num7, num5) + 0.75f;
                    RectangleF ef15 = new RectangleF(location, new SizeF(section.Columns[0].Width, height));
                    ((Interface1) section).imethod_0().imethod_47(true);
                    ((Interface1) section).imethod_0().imethod_51(height);
                    base.interface30_0.imethod_3().imethod_5(0);
                    base.method_4().method_132().imethod_0().method_22(1);
                    base.method_4().method_132().imethod_0().method_27(section.Columns[0].Width + section.Columns[0].Space);
                    base.interface1_1 = interface3;
                    base.interface1_0 = interface3;
                    this.method_33(0);
                    base.layoutState_0 = LayoutState.Unknown;
                    this.method_45(base.class375_0, true);
                    base.class375_0 = null;
                    this.vmethod_0(ef15);
                }
            }
        }
        if (((((base.class375_0.method_74().Count > 0) && (base.class375_0.method_73() is Section)) && (((base.class375_0.method_73() as Section).Columns.Count > 1) && !base.class375_0.method_73().imethod_0().imethod_44())) && (((base.class375_0.method_73() as Section).NextSibling == null) || ((((base.class375_0.method_73() as Section).NextSibling != null) && ((base.class375_0.method_73() as Section).NextSibling is Section)) && (((base.class375_0.method_73() as Section).NextSibling as Section).BreakCode != SectionBreakType.NoBreak)))) || (((((base.class375_0.method_74().Count > 0) && (base.class375_0.method_73() is Class65)) && (((base.class375_0.method_73() as Class65).method_2() is Section) && (((base.class375_0.method_73() as Class65).method_2() as Section).Columns.Count > 1))) && !base.class375_0.method_73().imethod_0().imethod_44()) && ((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling == null) || (((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling != null) && (((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling is Section)) && ((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling as Section).BreakCode != SectionBreakType.NoBreak)))))
        {
            Section section2 = (base.class375_0.method_73() is Section) ? (base.class375_0.method_73() as Section) : ((!(base.class375_0.method_73() is Class65) || !((base.class375_0.method_73() as Class65).method_2() is Section)) ? null : ((base.class375_0.method_73() as Class65).method_2() as Section));
            base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_73();
            Class312 class5 = base.method_4().method_28().method_51(base.class375_0.method_69(), section2);
            if (!class5.method_0().IsEmpty && (base.class375_0.method_69().Width < class5.method_0().Width))
            {
                List<Class375> list2 = new List<Class375>();
                Interface1 interface5 = null;
                RectangleF ef16 = new RectangleF();
                for (int j = base.method_4().method_28().method_3().Count - 1; j > 1; j--)
                {
                    Class375 class6 = base.method_4().method_28().method_3().method_4(j);
                    if (section2 != this.method_35(class6, ref interface5))
                    {
                        break;
                    }
                    class5 = base.method_4().method_28().method_51(class6.method_69(), section2);
                    if (class5.method_0().IsEmpty || (class6.method_69().Width >= class5.method_0().Width))
                    {
                        interface5 = null;
                        break;
                    }
                    list2.Add(class6);
                    ef16 = class6.method_69();
                }
                int count = list2.Count;
                if (count > 0)
                {
                    foreach (Class375 class7 in list2)
                    {
                        base.method_4().method_28().method_3().method_11(class7);
                    }
                    list2 = null;
                }
                if (((interface5 != null) && !ef16.IsEmpty) && (count <= section2.Columns.Count))
                {
                    ((Interface1) section2).imethod_0().imethod_45(true);
                    Class304 class1 = base.interface30_0.imethod_3();
                    class1.imethod_5(class1.Interface30.imethod_4() - count);
                    Class195 class10 = base.method_4().method_132().imethod_0();
                    class10.method_22(class10.method_21() - count);
                    base.method_4().method_132().imethod_0().method_27(section2.Columns[base.interface30_0.imethod_3().Interface30.imethod_4()].Width + section2.Columns[base.interface30_0.imethod_3().Interface30.imethod_4()].Space);
                    base.interface1_1 = interface5;
                    base.interface1_0 = interface5;
                    this.method_33(0);
                    base.layoutState_0 = LayoutState.Unknown;
                    base.class375_0 = null;
                    ef16.Width = section2.Columns[base.interface30_0.imethod_3().Interface30.imethod_4()].Width;
                    this.vmethod_0(ef16);
                }
            }
        }
        if (((((base.class375_0.method_74().Count > 0) && (base.class375_0.method_73() is Section)) && (((base.class375_0.method_73() as Section).Columns.Count > 1) && !base.class375_0.method_73().imethod_0().imethod_44())) && ((!base.class375_0.method_73().imethod_0().imethod_48() && ((base.class375_0.method_73() as Section).NextSibling != null)) && (((base.class375_0.method_73() as Section).NextSibling is Section) && (((base.class375_0.method_73() as Section).NextSibling as Section).BreakCode == SectionBreakType.NoBreak)))) || (((((base.class375_0.method_74().Count > 0) && (base.class375_0.method_73() is Class65)) && (((base.class375_0.method_73() as Class65).method_2() is Section) && (((base.class375_0.method_73() as Class65).method_2() as Section).Columns.Count > 1))) && ((!base.class375_0.method_73().imethod_0().imethod_44() && !base.class375_0.method_73().imethod_0().imethod_48()) && ((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling != null) && (((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling is Section)))) && ((((base.class375_0.method_73() as Class65).method_2() as Section).NextSibling as Section).BreakCode == SectionBreakType.NoBreak)))
        {
            Section section3 = (base.class375_0.method_73() is Section) ? (base.class375_0.method_73() as Section) : ((!(base.class375_0.method_73() is Class65) || !((base.class375_0.method_73() as Class65).method_2() is Section)) ? null : ((base.class375_0.method_73() as Class65).method_2() as Section));
            DocumentObject entity = base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_73() as DocumentObject;
            if (((section3 != null) && (entity != null)) && ((section3.Body.ChildObjects.IndexOf(entity) == (section3.Body.ChildObjects.Count - 1)) && (base.method_4().method_28().method_3().Count >= 2)))
            {
                float num11 = section3.Columns[base.method_4().method_132().imethod_0().method_21() - 1].Width;
                float num12 = base.class375_0.method_117();
                float num13 = ((((base.class375_0.method_69().Width < 1f) || (num12 < 1f)) || (base.class375_0.method_69().Width != num11)) ? num11 : base.class375_0.method_69().Width) * base.class375_0.method_69().Height;
                List<Class375> list3 = new List<Class375>();
                Interface1 interface6 = base.class375_0.method_73();
                PointF tf2 = base.class375_0.method_69().Location;
                for (int k = base.method_4().method_28().method_3().Count - 1; k > 1; k--)
                {
                    Interface1 interface7 = null;
                    Class375 class8 = base.method_4().method_28().method_3().method_4(k);
                    if (section3 != this.method_35(class8, ref interface7))
                    {
                        break;
                    }
                    num12 = class8.method_117();
                    num13 += ((((class8.method_69().Width < 1f) || (num12 < 1f)) || (class8.method_69().Width != num11)) ? num11 : class8.method_69().Width) * class8.method_69().Height;
                    interface6 = interface7;
                    list3.Add(class8);
                    tf2.X = Math.Min(tf2.X, class8.method_69().X);
                    tf2.Y = Math.Min(tf2.Y, class8.method_69().Y);
                }
                float num15 = 0f;
                if (list3.Count > 0)
                {
                    foreach (Class375 class9 in list3)
                    {
                        base.method_4().method_28().method_3().method_11(class9);
                    }
                    list3 = null;
                }
                else
                {
                    num15 = base.class375_0.method_116();
                }
                if (interface6 != null)
                {
                    float num17 = 11f;
                    float num18 = 0f;
                    foreach (Column column2 in section3.Columns)
                    {
                        num18 += column2.Width;
                    }
                    float num19 = Math.Max((num13 / num18) + num17, num15) + 0.75f;
                    RectangleF ef17 = new RectangleF(tf2, new SizeF(section3.Columns[0].Width, num19));
                    ((Interface1) section3).imethod_0().imethod_45(true);
                    ((Interface1) section3).imethod_0().imethod_51(num19);
                    base.interface30_0.imethod_3().imethod_5(0);
                    base.method_4().method_132().imethod_0().method_22(1);
                    base.method_4().method_132().imethod_0().method_27(section3.Columns[0].Width + section3.Columns[0].Space);
                    base.interface1_1 = interface6;
                    base.interface1_0 = interface6;
                    this.method_33(0);
                    base.layoutState_0 = LayoutState.Unknown;
                    this.method_45(base.class375_0, true);
                    base.class375_0 = null;
                    this.vmethod_0(ef17);
                }
            }
        }
    }

    protected virtual void vmethod_10(Class615 A_0)
    {
        RectangleF ef = base.class774_0.method_13();
        if (((A_0.method_8() is Paragraph) && this.method_73(A_0.method_8() as Paragraph)) || ((A_0.method_8() is Table) && this.method_74(A_0.method_8() as Table)))
        {
            ef = (base.interface30_0 as Class304).method_6();
        }
        if (A_0 is Class619)
        {
            (A_0 as Class619).method_31(this);
        }
        else if (A_0 is Class618)
        {
            (A_0 as Class618).method_30(this);
        }
        this.class375_1 = A_0.vmethod_0(ef);
    }

    protected virtual void vmethod_11(Class196 A_0, Class615 A_1)
    {
        if (((A_0.method_28().method_4().Count > 0) && (A_1.method_5().method_73() is Footnote)) && ((A_1.method_5().method_73() as Footnote).FootnoteType == FootnoteType.Footnote))
        {
            A_0.method_28().method_4().method_0().method_90(A_1.method_5());
            float num = A_0.method_28().method_77();
            num = (A_0.method_28().method_4().Count == 1) ? (num + 12f) : num;
            Class205 class1 = base.class375_0.method_73().imethod_0() as Class205;
            class1.method_8(class1.method_7() + num);
            if (!(A_1.method_5().method_73() as Footnote).OwnerParagraph.IsInCell)
            {
                RectangleF ef9 = new RectangleF(base.class774_0.method_0().Location, new SizeF(base.class774_0.method_0().Width, base.class774_0.method_0().Height - num));
                base.class774_0.method_1(ef9);
            }
        }
        else if (((A_1.method_5().method_73() is Paragraph) || ((A_1.method_5().method_73() is Class65) && ((A_1.method_5().method_73() as Class65).method_2() is Paragraph))) && (A_1.method_5().method_73().imethod_0() as Class205).method_3())
        {
            Paragraph paragraph = (A_1.method_5().method_73() is Paragraph) ? (A_1.method_5().method_73() as Paragraph) : ((A_1.method_5().method_73() is Class65) ? ((A_1.method_5().method_73() as Class65).method_2() as Paragraph) : null);
            if ((paragraph != null) && !paragraph.IsInCell)
            {
                RectangleF ef = new RectangleF(base.class774_0.method_0().Location, new SizeF(base.class774_0.method_0().Width, base.class774_0.method_0().Height - (A_1.method_5().method_73().imethod_0() as Class205).method_7()));
                base.class774_0.method_1(ef);
            }
        }
        else if (((A_1.method_5().method_73() is Table) && (A_1.method_5().method_73().imethod_0() as Class205).method_3()) && (A_1.method_5().method_73() is Table))
        {
            RectangleF ef5 = new RectangleF(base.class774_0.method_0().Location, new SizeF(base.class774_0.method_0().Width, base.class774_0.method_0().Height - (A_1.method_5().method_73().imethod_0() as Class205).method_7()));
            base.class774_0.method_1(ef5);
        }
    }

    protected virtual Class615 vmethod_2()
    {
        Interface1 interface2;
    Label_0707:
        interface2 = this.method_30();
        this.interface1_2 = interface2;
        if (interface2 == null)
        {
            this.bool_6 = true;
            return null;
        }
        if (((interface2.imethod_0() != null) && interface2.imethod_0().imethod_4()) && (!(this.method_31() is Table) || !(this.method_31() as Table).TableFormat.WrapTextAround))
        {
            if (!this.method_58())
            {
                this.bool_6 = true;
                return null;
            }
            goto Label_0707;
        }
        if ((interface2 is Break) && ((interface2 as Break).BreakType != BreakType.LineBreak))
        {
            Break @break = interface2 as Break;
            Paragraph paragraph = @break.method_28();
            if ((paragraph != null) && (((Interface1) paragraph).imethod_0() as Class213).method_105())
            {
                if (!this.method_58())
                {
                    this.bool_6 = true;
                    return null;
                }
                goto Label_0707;
            }
            if ((((paragraph != null) && (@break.BreakType == BreakType.PageBreak)) && ((paragraph.ChildObjects.LastItem == @break) && !paragraph.IsEndOfDocument)) && (paragraph.IsEndOfSection || (((paragraph.NextSibling is Paragraph) && ((paragraph.NextSibling as Paragraph).ChildObjects.Count == 0)) && (paragraph.NextSibling as Paragraph).IsEndOfSection)))
            {
                Section nextSibling = paragraph.method_49().NextSibling as Section;
                if ((nextSibling != null) && (nextSibling.BreakCode == SectionBreakType.NewPage))
                {
                    this.bool_6 = true;
                    return null;
                }
            }
        }
        if (((interface2 is Field) && ((interface2 as Field).Type == FieldType.FieldHyperlink)) && (((interface2 as Field).NextSibling is FieldMark) && (((interface2 as Field).NextSibling as FieldMark).Type == FieldMarkType.FieldEnd)))
        {
            if (!this.method_58())
            {
                this.bool_6 = true;
                return null;
            }
            goto Label_0707;
        }
        if (((interface2 is ShapeObject) && !(interface2 is TextBox)) && ((interface2 as ShapeObject).DocumentObjectType == DocumentObjectType.TextBox))
        {
            using (IEnumerator enumerator = (interface2 as ShapeObject).AutoShapeTextCollection.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    object current = enumerator.Current;
                    (current as ParagraphBase).method_0((interface2 as ShapeObject).OwnerBase);
                    return Class615.smethod_0(current as Interface1, base.interface30_0, (float) base.class774_0.method_2());
                }
            }
        }
        if (((interface2 is Class6) && ((interface2 as Class6).method_30() != null)) && ((interface2 as Class6).method_32() == null))
        {
            Paragraph ownerParagraph = (interface2 as Class6).OwnerParagraph;
            interface2 = (interface2 as Class6).method_30();
            (interface2 as DocPicture).method_0(ownerParagraph);
        }
        this.method_41(interface2);
        if (interface2 is Paragraph)
        {
            bool hidden = (interface2 as Paragraph).BreakCharacterFormat.Hidden;
            bool flag = (interface2 as Paragraph).method_97();
            Class210 class2 = interface2.imethod_0() as Class210;
            class2.method_82(hidden);
            class2.Interface23.imethod_41(flag);
            class2.method_84(base.class774_0.method_13());
            if (((hidden && flag) && ((!base.method_4().method_19().IsHidden && !(interface2.imethod_0() as Class210).method_37()) && (!(this.method_31() is Table) || !(this.method_31() as Table).TableFormat.WrapTextAround))) || (!(interface2 as Paragraph).IsList && (((base.class774_0.method_13().Width - (interface2 as Paragraph).Format.LeftIndent) - (((interface2 as Paragraph).Format.FirstLineIndent < 0f) ? (interface2 as Paragraph).Format.FirstLineIndent : 0f)) < 0f)))
            {
                if (((interface2 as Paragraph).OwnerTextBody != null) && ((interface2 as Paragraph).OwnerTextBody.interface23_0 != null))
                {
                    (interface2 as Paragraph).OwnerTextBody.interface23_0.imethod_41((hidden && flag) && !base.method_4().method_19().IsHidden);
                }
                if (!this.method_58())
                {
                    this.bool_6 = true;
                    return null;
                }
                goto Label_0707;
            }
            if (((interface2 as Paragraph).OwnerTextBody != null) && ((interface2 as Paragraph).OwnerTextBody.interface23_0 != null))
            {
                (interface2 as Paragraph).OwnerTextBody.interface23_0.imethod_41(false);
            }
            if ((!base.method_4().method_19().IsHidden || class2.Interface23.imethod_8()) && ((interface2 as Paragraph).PreviousSibling is Paragraph))
            {
                Paragraph previousSibling = (interface2 as Paragraph).PreviousSibling as Paragraph;
                Class210 class3 = ((Interface1) previousSibling).imethod_0() as Class210;
                if ((((base.method_5() != null) && (base.method_5().method_74().method_0() != null)) && (base.method_5().method_74().method_0().method_73() == previousSibling)) && ((class3.method_81() && !class3.Interface23.imethod_40()) || class2.Interface23.imethod_8()))
                {
                    class2.method_90((float) (class3.Interface22.imethod_1().method_0() + (class3.method_83().Right - (class3.Interface22.imethod_1().method_0() + class3.Interface22.imethod_1().method_8()))));
                    Class375 class4 = base.method_5().method_74().method_0();
                    class4.method_69();
                    while (class4 != null)
                    {
                        if (class4.method_74().Count <= 0)
                        {
                            break;
                        }
                        class4 = class4.method_74().method_0();
                    }
                    if (class4 != null)
                    {
                        RectangleF ef4 = class4.method_69();
                        class2.method_88(ef4);
                        class2.method_92(class4.method_71());
                        RectangleF ef5 = base.class774_0.method_13();
                        base.method_16(new RectangleF(new PointF(ef5.Left, ef4.Top), new SizeF(ef5.Width, ef5.Bottom - ef4.Top)));
                    }
                }
            }
            if (this.method_73(interface2 as Paragraph))
            {
                RectangleF ef3 = base.method_23(interface2 as Paragraph, base.class774_0.method_13());
                (interface2.imethod_0() as Class210).method_58(ef3.Y);
                (interface2.imethod_0() as Class210).method_60(ef3.X);
            }
            else
            {
                (interface2.imethod_0() as Class210).method_58(base.class774_0.method_13().Y);
            }
        }
        if ((interface2 is Table) && this.method_74(interface2 as Table))
        {
            base.method_23(interface2 as Table, base.class774_0.method_13());
        }
        if (interface2 is TextRange)
        {
            bool flag3 = false;
            if ((interface2 as TextRange).CharacterFormat != null)
            {
                bool isNoProof = (interface2 as TextRange).CharacterFormat.IsNoProof;
                bool isWebHidden = (interface2 as TextRange).CharacterFormat.IsWebHidden;
                if (interface2 is TextFormField)
                {
                    flag3 = (interface2 as TextRange).CharacterFormat.Hidden || (((interface2 as TextFormField).TextRange != null) && (interface2 as TextFormField).TextRange.CharacterFormat.Hidden);
                }
                else
                {
                    flag3 = (interface2 as TextRange).CharacterFormat.Hidden;
                }
            }
            if (!flag3 || base.method_4().method_19().IsHidden)
            {
                if ((interface2 as TextRange).OwnerParagraph != null)
                {
                    interface2.imethod_0().imethod_3(((Interface1) (interface2 as TextRange).OwnerParagraph).imethod_0().imethod_2());
                }
                else
                {
                    interface2.imethod_0().imethod_3(base.method_2().imethod_2());
                }
            }
            else
            {
                if (!this.method_58())
                {
                    this.bool_6 = true;
                    Paragraph paragraph2 = ((interface2 as TextRange).OwnerEmptyParagraph != null) ? (interface2 as TextRange).OwnerEmptyParagraph : (interface2 as TextRange).method_28();
                    if (((paragraph2 != null) && (paragraph2.NextSibling is Table)) && (paragraph2.NextSibling as Table).TableFormat.WrapTextAround)
                    {
                        return Class615.smethod_0(interface2, base.interface30_0, (float) base.class774_0.method_4());
                    }
                    return null;
                }
                goto Label_0707;
            }
        }
        if ((((interface2 is ShapeObject) || (interface2 is ShapeGroup)) || (interface2 is Class6)) && ((!(interface2 is DocPicture) && !(interface2 is TextBox)) && !(interface2 is DocOleObject)))
        {
            return Class615.smethod_1(interface2, base.interface30_0, (float) base.class774_0.method_2(), base.method_10());
        }
        return Class615.smethod_0(interface2, base.interface30_0, (float) base.class774_0.method_4());
    }

    protected virtual void vmethod_3(Class615 A_0)
    {
        base.bool_3 = A_0.method_9();
        if (!this.method_82(A_0))
        {
            if (base.class375_0.method_73() is TableCell)
            {
                Table ownerTable = (base.class375_0.method_73() as TableCell).OwnerRow.OwnerTable;
                if (ownerTable.DontBreakWrappedTables && ownerTable.TableFormat.WrapTextAround)
                {
                    this.vmethod_4(A_0);
                    return;
                }
            }
            if (this.bool_6)
            {
                this.method_59(this.method_30());
                Class210 class2 = base.method_2() as Class210;
                if (class2 != null)
                {
                    this.method_49(A_0, class2);
                }
                base.layoutState_0 = LayoutState.Splitted;
            }
            else
            {
                base.layoutState_0 = LayoutState.NotFitted;
            }
        }
    }

    protected virtual void vmethod_4(Class615 A_0)
    {
        int num = 4;
        if (A_0.method_5().method_36())
        {
            base.layoutState_0 = LayoutState.Breaked;
        }
        else
        {
            if ((this.method_50() && (A_0.method_8() is Table)) && ((base.class375_0.method_74().Count > 0) || (base.method_4().method_28().method_3().Count > 2)))
            {
                Table table = A_0.method_8() as Table;
                if ((!table.IsFrame && table.TableFormat.WrapTextAround) && (table.DontBreakWrappedTables && (A_0.method_5().method_69().Height > ((table.method_55().PageSetup.PageSize.Height - base.class375_0.method_69().Height) - this.method_46()))))
                {
                    int count = base.class375_0.method_74().Count;
                    Interface1 interface3 = this.method_83(base.class375_0.method_74().method_0().method_73(), base.class375_0, count - 1);
                    if ((base.class375_0.method_74().Count == count) && !(interface3 is Class820))
                    {
                        this.method_59(A_0.method_8() as Interface4);
                        this.method_43(A_0.method_5(), true);
                    }
                    else
                    {
                        this.method_59(interface3);
                    }
                    base.layoutState_0 = LayoutState.Splitted;
                    return;
                }
            }
            this.method_61(A_0);
            bool flag = this.method_58();
            if ((((base.method_4().method_0().Count > 1) && (base.method_4().method_28().method_3().Count == 2)) && ((A_0.method_8() is Class65) && ((A_0.method_8() as Class65).method_2() is Paragraph))) && (A_0.method_8().imethod_0() as Class213).method_41())
            {
                Class375 class3 = base.method_4().method_0()[base.method_4().method_0().Count - 2].method_91();
                if (class3 != null)
                {
                    int num2 = class3.method_74().Count;
                    Class375 class4 = class3.method_74().method_4(num2 - 1);
                    Paragraph paragraph3 = (A_0.method_8() as Class65).method_2() as Paragraph;
                    Paragraph entity = (class4.method_73() is Paragraph) ? (class4.method_73() as Paragraph) : ((!(class4.method_73() is Class65) || !((class4.method_73() as Class65).method_2() is Paragraph)) ? null : ((class4.method_73() as Class65).method_2() as Paragraph));
                    if ((((entity != null) && (entity == paragraph3)) && ((class4.method_69().Width > 1f) && (class4.method_69().Height > 1f))) && !class4.method_113())
                    {
                        Section section = (class3.method_73() is Section) ? (class3.method_73() as Section) : ((!(class3.method_73() is Class65) || !((class3.method_73() as Class65).method_2() is Section)) ? null : ((class3.method_73() as Class65).method_2() as Section));
                        int num6 = A_0.method_5().method_74().Count;
                        int num7 = class4.method_74().Count;
                        if ((num6 == 1) || (num7 == 1))
                        {
                            Interface1 interface2 = class4.method_73();
                            if (class4.method_74().Count >= 3)
                            {
                                float height = A_0.method_5().method_69().Height;
                                float single2 = class4.method_69().Height;
                                interface2 = class4.method_74().method_4(class4.method_74().Count - 1).method_73();
                                Class375 class8 = class4.method_74().method_4(class4.method_74().Count - 1);
                                this.method_44(class8, false);
                                class4.method_74().method_12(class4.method_74().Count - 1);
                                Class65 class9 = new Class65(section, interface2, section.WidgetObjectCollection.IndexOf(entity));
                                RectangleF ef19 = new RectangleF(base.class375_0.method_69().Location, A_0.method_3().method_11().Size);
                                base.interface1_1 = class9;
                                base.interface1_0 = class9;
                                this.method_33(0);
                                base.layoutState_0 = LayoutState.Unknown;
                                this.method_44(base.class375_0, true);
                                base.class375_0 = null;
                                this.vmethod_0(ef19);
                                return;
                            }
                            float num3 = A_0.method_5().method_69().Height + class4.method_69().Height;
                            if (num3 < A_0.method_3().method_11().Height)
                            {
                                class3.method_74().method_12(num2 - 1);
                                this.method_43(class4, false);
                                this.method_44(class4, false);
                                num2 = class3.method_74().Count;
                                List<Class375> list = new List<Class375>();
                                float num4 = 0f;
                                for (int i = num2 - 1; i >= 0; i--)
                                {
                                    Class375 item = class3.method_74().method_4(i);
                                    if (((item.method_73().imethod_0() is Class213) && !(item.method_73().imethod_0() as Class213).method_35()) || ((item.method_73() is Table) && !this.method_47(item.method_73() as Table)))
                                    {
                                        break;
                                    }
                                    list.Add(item);
                                    num4 += item.method_69().Height;
                                }
                                if (((list.Count > 0) && (list.Count < num2)) && ((num3 + num4) < A_0.method_3().method_11().Height))
                                {
                                    Class375 class2 = list[list.Count - 1];
                                    Paragraph paragraph = (class2.method_73() is Paragraph) ? (class2.method_73() as Paragraph) : ((!(class2.method_73() is Class65) || !((class2.method_73() as Class65).method_2() is Paragraph)) ? null : ((class2.method_73() as Class65).method_2() as Paragraph));
                                    interface2 = class2.method_73();
                                    entity = paragraph;
                                    foreach (Class375 class7 in list)
                                    {
                                        class3.method_74().method_11(class7);
                                        this.method_43(class7, false);
                                        this.method_44(class7, false);
                                    }
                                    num3 += num4;
                                }
                                list.Clear();
                                list = null;
                                if (num3 < A_0.method_3().method_11().Height)
                                {
                                    Class65 class6 = new Class65(section, interface2, section.WidgetObjectCollection.IndexOf(entity));
                                    (interface2.imethod_0() as Class213).method_44(true);
                                    RectangleF ef14 = new RectangleF(base.class375_0.method_69().Location, A_0.method_3().method_11().Size);
                                    base.interface1_1 = class6;
                                    base.interface1_0 = class6;
                                    this.method_33(0);
                                    base.layoutState_0 = LayoutState.Unknown;
                                    this.method_44(base.class375_0, true);
                                    base.class375_0 = null;
                                    this.vmethod_0(ef14);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (((this.method_29() is Class65) && ((this.method_29() as Class65).method_2() is TableCell)) && !flag)
            {
                base.interface1_0 = null;
            }
            if (A_0.method_2().imethod_24() && (this.method_30() != null))
            {
                base.class375_0.method_65(BookmarkStart.b("礩尫䈭夯䘱䀳匵尷甹娻爽⤿ⱁ⅃х㩇⽉ⵋ╍", num));
                this.method_59(this.method_30());
                base.layoutState_0 = LayoutState.Splitted;
            }
            else if ((A_0.method_2().imethod_28() && !this.method_42(A_0.method_8())) && ((A_0.method_8() is Break) || (A_0.method_8() is Table)))
            {
                if (this.method_30() != null)
                {
                    this.method_59(this.method_30());
                }
                else
                {
                    base.interface1_0 = new Class65(this.method_29(), A_0.method_8(), this.method_29().imethod_3() - 1);
                }
                if ((this.method_30() != null) && ((this.method_30() as DocumentObject).PreviousSibling is Table))
                {
                    base.layoutState_0 = LayoutState.Splitted;
                }
                else
                {
                    base.layoutState_0 = LayoutState.Breaked;
                }
            }
            else if ((this.method_30() is Paragraph) && this.method_73(this.method_30() as Paragraph))
            {
                RectangleF ef7 = base.method_23(this.method_30() as Paragraph, base.class774_0.method_13());
                if (this.method_48(ef7) && !base.method_4().method_135())
                {
                    (base.interface30_0 as Class304).method_7(new RectangleF());
                    this.method_59(this.method_30());
                    base.layoutState_0 = LayoutState.Splitted;
                }
            }
            else if (!this.bool_6)
            {
                this.bool_6 = true;
            }
        }
    }

    protected virtual void vmethod_5(Class615 A_0)
    {
        if ((this.method_50() && (A_0.method_8() is Table)) && !(A_0.method_8() as Table).IsFrame)
        {
            Table table = A_0.method_8() as Table;
            if ((table.TableFormat != null) && !table.TableFormat.WrapTextAround)
            {
                int num2 = (!(this.interface1_2 is Class820) || ((this.interface1_2 as Class820).method_1() >= table.Rows.Count)) ? A_0.method_5().method_74().Count : (this.interface1_2 as Class820).method_1();
                int num = this.method_81(A_0);
                if (num > 0)
                {
                    this.method_61(A_0);
                    if (num != num2)
                    {
                        Interface1 interface2 = new Class820(table, num + 1);
                        this.method_59(interface2);
                    }
                    else
                    {
                        this.method_59(A_0.method_0());
                    }
                    base.layoutState_0 = LayoutState.Splitted;
                    return;
                }
                if ((num == 0) && (base.class375_0.method_74().Count > 0))
                {
                    int count = base.class375_0.method_74().Count;
                    Interface1 interface3 = this.method_83(A_0.method_5().method_73(), base.class375_0, base.class375_0.method_74().Count - 1);
                    if ((base.class375_0.method_74().Count == count) && !(interface3 is Class820))
                    {
                        if ((interface3 != base.class375_0.method_74().method_4(0).method_73()) && ((interface3 != table) || !this.method_90(table)))
                        {
                            this.method_59(A_0.method_8());
                        }
                        else
                        {
                            this.method_61(A_0);
                            this.method_59(A_0.method_0());
                        }
                    }
                    else
                    {
                        this.method_59(interface3);
                    }
                    base.layoutState_0 = LayoutState.Splitted;
                    return;
                }
            }
            else if ((table.TableFormat != null) && table.TableFormat.WrapTextAround)
            {
                this.method_61(A_0);
                this.method_59(A_0.method_0());
                base.layoutState_0 = LayoutState.Splitted;
                return;
            }
        }
        base.bool_3 = A_0.method_9();
        Class210 class2 = base.method_2() as Class210;
        if (class2 != null)
        {
            if (class2.method_19() > 0f)
            {
                class2.method_99();
            }
            if (class2.method_43() && ((A_0.method_5().method_69().Width > 0f) || (base.class375_0.method_69().Width > 0f)))
            {
                this.method_49(A_0, class2);
            }
        }
        if (((A_0.method_5().method_73() is Paragraph) && (A_0.method_5().method_69().Height == 0f)) && ((base.class375_0.method_74().Count > 0) && (A_0.method_5().method_69().Top > base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_69().Bottom)))
        {
            A_0.method_5().method_70(new RectangleF(new PointF(A_0.method_5().method_69().X, base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1).method_69().Bottom), new SizeF()));
        }
        this.method_61(A_0);
        this.method_59(A_0.method_0());
        base.layoutState_0 = LayoutState.Splitted;
    }

    protected virtual void vmethod_6(Class615 A_0)
    {
        this.method_61(A_0);
        Class375 class2 = base.class375_0.method_74().method_4(base.class375_0.method_74().Count - 1);
        if ((class2 == null) || (class2.method_74().Count <= 0))
        {
            if (((A_0.method_8() is Paragraph) && (A_0.method_8().imethod_0() as Class210).method_37()) && ((A_0.method_8().imethod_0() as Class210).method_81() && (A_0.method_8().imethod_0() as Class210).Interface23.imethod_40()))
            {
                this.int_0 = this.method_29().imethod_3() - 1;
            }
        }
        else
        {
            Class375 class3 = class2.method_74().method_4(class2.method_74().Count - 1);
            if (class3 != null)
            {
                Interface1 parentContainer = class3.method_73();
                if (((parentContainer is DocPicture) && ((parentContainer as DocPicture).ShapeInfo != null)) && ((parentContainer as DocPicture).ShapeInfo.ParentContainer != null))
                {
                    parentContainer = (parentContainer as DocPicture).ShapeInfo.ParentContainer as Interface1;
                }
                else if (((parentContainer is Table) && (parentContainer as Table).IsTextBox) && ((parentContainer as Table).TextBox != null))
                {
                    parentContainer = (parentContainer as Table).TextBox as Interface1;
                }
                for (int i = 0; i < this.method_29().imethod_3(); i++)
                {
                    if (this.method_29().imethod_4(i) == parentContainer)
                    {
                        this.int_0 = i;
                        break;
                    }
                }
            }
        }
        this.method_58();
        if (this.method_30() != null)
        {
            this.method_59(this.method_30());
            base.layoutState_0 = LayoutState.Splitted;
        }
        else
        {
            base.layoutState_0 = LayoutState.Breaked;
        }
    }

    protected virtual void vmethod_7()
    {
        RectangleF ef;
        int num = 2;
        if (!(this.class375_1.method_73() is DocPicture) || ((this.class375_1.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))
        {
            if (this.class375_1.method_73() is Field)
            {
                Field field = this.class375_1.method_73() as Field;
                if ((field.Type == FieldType.FieldHyperlink) && (field.Text.Length == 0))
                {
                    this.class375_1.method_73().imethod_0().imethod_13(true);
                    return;
                }
            }
            if ((this.class375_1.method_73() is Paragraph) && this.method_73(this.class375_1.method_73() as Paragraph))
            {
                this.method_51();
            }
            if (this.class375_1.method_73() is Table)
            {
                Table table = this.class375_1.method_73() as Table;
                if (table.IsTextBox)
                {
                    if (table.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline)
                    {
                        return;
                    }
                }
                else
                {
                    if (this.method_74(table))
                    {
                        this.method_51();
                        return;
                    }
                    if ((((table.Document.Settings.method_3() != 15) || !(table.OwnerTextBody is HeaderFooter)) || (Class59.smethod_2(base.method_3().method_4(), (double) table.LayoutWidth) > 0)) && (this.class375_1.method_73() as Interface4).imethod_3().imethod_13())
                    {
                        return;
                    }
                }
            }
            if (((this.class375_1.method_73() is ShapeObject) && !(this.class375_1.method_73() is DocPicture)) && (!(this.class375_1.method_73() is TextBox) && !(this.class375_1.method_73() is DocOleObject)))
            {
                this.method_51();
                return;
            }
            Class372 class3 = this.class375_1.method_73().imethod_0().imethod_1();
            ef = this.class375_1.method_69();
            ef.X -= (float) class3.method_0();
            if (base.class375_0.method_73().imethod_0() is Class213)
            {
                Class372 class4 = base.class375_0.method_73().imethod_0().imethod_0();
                Class213 class5 = base.class375_0.method_73().imethod_0() as Class213;
                if ((!this.class375_1.method_52() && !class5.method_43()) && class5.method_49())
                {
                    ef.Y -= (float) (class3.method_4() + class4.method_4());
                }
                else
                {
                    ef.Y -= (float) class3.method_4();
                }
            }
            else
            {
                ef.Y -= (float) class3.method_4();
            }
            ef.Width += (float) (class3.method_0() + class3.method_8());
            ef.Height += (float) (class3.method_4() + class3.method_12());
            switch (base.method_2().imethod_23())
            {
                case ChildrenLayoutDirection.Horizontal:
                    if (base.class774_0.method_13().Width > 0f)
                    {
                        base.class774_0.method_15((double) ef.Right);
                    }
                    else
                    {
                        object obj2 = (this.class375_1.method_73() is TextRange) ? this.class375_1.method_73() : ((this.class375_1.method_73() is Class542) ? (this.class375_1.method_73() as Class542).method_2() : null);
                        if (((!(obj2 is TextRange) || !((obj2 as TextRange).NextSibling is Field)) || ((((obj2 as TextRange).NextSibling as Field).DocumentObjectType != DocumentObjectType.Field) || ((((obj2 as TextRange).NextSibling as Field).Type != FieldType.FieldPage) && (((obj2 as TextRange).NextSibling as Field).Type != FieldType.FieldNumPages)))) && ((!(obj2 is Field) || ((obj2 as Field).DocumentObjectType != DocumentObjectType.Field)) || (((obj2 as Field).Type != FieldType.FieldPage) && ((obj2 as Field).Type != FieldType.FieldNumPages))))
                        {
                            base.class774_0.method_15((double) ef.Right);
                        }
                        else
                        {
                            base.class774_0.method_16((double) ef.Right);
                        }
                    }
                    this.class375_1.method_70(ef);
                    return;

                case ChildrenLayoutDirection.Vertical:
                {
                    if (!(this.class375_1.method_73() is Paragraph))
                    {
                        goto Label_0709;
                    }
                    Paragraph paragraph = this.class375_1.method_73() as Paragraph;
                    if (((((paragraph.Format == null) || !paragraph.Format.IsFrame) || (((paragraph.Format.FrameVerticalPos == 2) || (paragraph.Text.Length <= 0)) || paragraph.IsInCell)) && (!paragraph.IsInCell || !paragraph.method_56())) && (((paragraph.Format == null) || paragraph.IsInCell) || !paragraph.Format.IsFrame))
                    {
                        if (((this.class375_1.method_69().Height == 0f) && (!(base.interface30_0 as Class304).method_10() || ((base.interface30_0 as Class304).method_10() && (paragraph.ChildObjects.Count > 0)))) && ((((paragraph == null) || !paragraph.IsEndOfSection) || !paragraph.IsEmptyParagraph) && ((!this.method_77() || this.method_79()) || this.method_78())))
                        {
                            float num2 = base.method_4().method_1() ? base.method_4().method_309(BookmarkStart.b("ࠧ", num), base.method_4().method_376(paragraph.BreakCharacterFormat), null).Height : base.method_4().method_316(BookmarkStart.b("ࠧ", num), base.method_4().method_365(paragraph.BreakCharacterFormat), null).Height;
                            LineSpacingRule multiple = LineSpacingRule.Multiple;
                            float num4 = -1f;
                            float num3 = this.method_67(this.class375_1, ref multiple, ref num4);
                            if (multiple == LineSpacingRule.AtLeast)
                            {
                                num2 = Math.Max(num2, num3);
                            }
                            else
                            {
                                num2 = num3;
                            }
                            ef = new RectangleF(ef.Location, new SizeF(ef.Width, ef.Height + num2));
                            this.class375_1.method_70(ef);
                        }
                        Class372 class2 = this.class375_1.method_73().imethod_0().imethod_0();
                        if ((((this.class375_1.method_69().Height > 0f) && (class2.method_14() != 0f)) && (!paragraph.Format.Borders.NoBorder && (paragraph.Format.Borders.Bottom.BorderType != BorderStyle.None))) && (this.class375_1.method_73().imethod_0() as Class213).method_47())
                        {
                            ef.Height += (float) class2.method_12();
                            RectangleF ef3 = this.class375_1.method_69();
                            ef3.Height += (float) class2.method_12();
                            this.class375_1.method_70(ef3);
                        }
                        goto Label_0709;
                    }
                    return;
                }
            }
        }
        return;
    Label_0709:
        base.class774_0.method_18((double) ef.Bottom);
    }

    protected virtual void vmethod_8(short A_0, float A_1)
    {
    }

    protected virtual void vmethod_9()
    {
    }
}

