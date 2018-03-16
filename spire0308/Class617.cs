using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Layouting;
using System;
using System.Collections.Generic;
using System.Drawing;

internal class Class617 : Class616
{
    public Class617(Interface3 A_0, Interface30 A_1) : base(A_0, A_1)
    {
        base.bool_0 = true;
    }

    private bool method_91(Class615 A_0)
    {
        Paragraph paragraph = A_0.method_8() as Paragraph;
        if (paragraph != null)
        {
            ParagraphStyle style = paragraph.GetStyle();
            ListFormat listFormat = null;
            if (((paragraph.ListFormat.CurrentListLevel == null) && (style != null)) && ((style.ListFormat.CurrentListLevel != null) && style.ListFormat.HasKey(0)))
            {
                listFormat = style.ListFormat;
            }
            else
            {
                listFormat = paragraph.ListFormat;
            }
            if (((listFormat != null) && (listFormat.ListType != ListType.NoList)) && (listFormat.CurrentListLevel != null))
            {
                int listLevelNumber;
                ListStyle style2 = null;
                ListStyleCollection listStyles = paragraph.Document.ListStyles;
                if (((paragraph.ListFormat.CurrentListLevel == null) && (style != null)) && (style.ListFormat.CurrentListLevel != null))
                {
                    listLevelNumber = style.ListFormat.ListLevelNumber;
                    style2 = listStyles.FindByName(style.ListFormat.CustomStyleName);
                }
                else
                {
                    listLevelNumber = paragraph.ListFormat.ListLevelNumber;
                    style2 = listStyles.FindByName(paragraph.ListFormat.CustomStyleName);
                }
                if (style2.GetNearLevel(listLevelNumber).NumberPosition == 0f)
                {
                    return !(paragraph.Format.FirstLineIndent == 0f);
                }
                return true;
            }
        }
        return false;
    }

    private bool method_92(Class615 A_0)
    {
        bool flag;
        using (List<Class375>.Enumerator enumerator = A_0.method_5().method_74().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class375 current = enumerator.Current;
                if (current.method_73() is Footnote)
                {
                    goto Label_0034;
                }
            }
            return false;
        Label_0034:
            flag = true;
        }
        return flag;
    }

    private void method_93(Class375 A_0)
    {
        RectangleF ef20;
        int num = 4;
        bool flag = false;
        bool flag2 = false;
        int count = A_0.method_74().Count;
        A_0.method_105(base.method_4());
        Class210 class2 = A_0.method_73().imethod_0() as Class210;
        if (((A_0.method_73() is Paragraph) && (class2 as Class213).method_105()) && ((A_0.method_73().imethod_0() as Class213).method_59() != float.MinValue))
        {
            A_0.method_27((class2 as Class213).method_59() + (A_0.method_73() as Paragraph).Format.FrameWidthEx);
        }
        else
        {
            A_0.method_27(base.class774_0.method_13().Right);
        }
        HorizontalAlignment alignment = (class2 != null) ? class2.method_15() : HorizontalAlignment.Left;
        double num4 = base.method_4().method_169(A_0);
        PointF location = A_0.method_69().Location;
        if ((count > 0) && (A_0.method_69().Location != A_0.method_74().method_4(0).method_69().Location))
        {
            using (List<Class375>.Enumerator enumerator = A_0.method_74().GetEnumerator())
            {
                Class375 current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (((!(current.method_73() is Class7) || ((current.method_73() as Class7).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Inline)) && (!(current.method_73() is DocOleObject) || ((current.method_73() as DocOleObject).Interface49.get_OlePicture().TextWrappingStyle == TextWrappingStyle.Inline))) && (!(current.method_73() is DocPicture) || ((current.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline)))
                    {
                        goto Label_01AA;
                    }
                }
                goto Label_01CC;
            Label_01AA:
                location = current.method_69().Location;
            }
        }
    Label_01CC:
        ef20 = new RectangleF(location, new SizeF(A_0.method_69().Width + ((float) num4), A_0.method_69().Height));
        Class312 class4 = base.method_4().method_28().method_51(ef20, base.class375_0.method_73());
        if (((!class4.method_0().IsEmpty && (class4.method_2().method_0() != TextWrappingStyle.Inline)) && ((class4.method_2().method_0() != TextWrappingStyle.Behind) && (class4.method_2().method_0() != TextWrappingStyle.InFrontOfText))) && (class4.method_0().X > A_0.method_69().X))
        {
            double num3 = num4;
            float right = A_0.method_74().method_4(base.method_4().method_170(A_0.method_74(), A_0.method_74().method_0(), false)).method_69().Right;
            num4 = class4.method_0().X - A_0.method_69().Right;
            if (class4.method_0().X > right)
            {
                if (class2.method_85().Right >= class4.method_0().X)
                {
                    num4 = class4.method_0().X - right;
                }
                else
                {
                    num4 = num3;
                }
            }
        }
        Paragraph paragraph = this.method_96();
        if (((paragraph != null) && base.method_73(paragraph)) && (paragraph.Format.FrameWidth == 0))
        {
            num4 = 0.0;
        }
        if (num4 < 0.0)
        {
            num4 = 0.0;
        }
        CharacterSpacing compressPunctuation = CharacterSpacing.compressPunctuation;
        bool flag3 = false;
        if (paragraph != null)
        {
            Section section = this.method_95(paragraph);
            if (section != null)
            {
                compressPunctuation = section.PageSetup.CharacterSpacingControl;
            }
            if ((((alignment == HorizontalAlignment.Justify) && (paragraph != null)) && ((A_0.method_64() != BookmarkStart.b("礩尫䈭夯䘱䀳匵尷", num)) && (A_0.method_64() != BookmarkStart.b("礩尫䈭夯䘱䀳匵尷甹娻爽⤿ⱁ⅃х㩇⽉ⵋ╍", num)))) && ((A_0.method_74().Count > 0) && !A_0.method_74().method_4(0).method_66()))
            {
                flag = true;
            }
            flag3 = !paragraph.Document.Settings.method_5().method_29();
            if (((alignment == HorizontalAlignment.Justify) && (A_0.method_64() == BookmarkStart.b("礩尫䈭夯䘱䀳匵尷甹娻爽⤿ⱁ⅃х㩇⽉ⵋ╍", num))) && !flag3)
            {
                flag2 = true;
            }
        }
        if (compressPunctuation != CharacterSpacing.doNotCompress)
        {
            this.method_94(A_0);
        }
        if (!this.method_97(paragraph) && ((!flag2 && !flag) || ((flag && paragraph.IsEndOfSection) && (!paragraph.IsEndOfDocument && flag3))))
        {
            switch (alignment)
            {
                case HorizontalAlignment.Center:
                    A_0.method_106(base.method_4(), num4);
                    break;

                case HorizontalAlignment.Right:
                    A_0.method_107(base.method_4(), num4);
                    break;

                case HorizontalAlignment.Justify:
                case HorizontalAlignment.Distributed:
                {
                    int num6 = 0;
                    A_0.method_109(base.method_4(), num4, ref num6);
                    for (int i = num6; i < A_0.method_74().Count; i++)
                    {
                        A_0.method_74().method_4(i).method_61(alignment);
                        A_0.method_74().method_4(i).method_70(new RectangleF(A_0.method_74().method_4(i).method_69().X, A_0.method_74().method_4(i).method_69().Y, A_0.method_74().method_4(i).method_69().Width, A_0.method_74().method_4(i).method_69().Height));
                        if (i < (A_0.method_74().Count - 1))
                        {
                            A_0.method_74().method_4(i + 1).method_70(new RectangleF(A_0.method_74().method_4(i + 1).method_69().Location.X, A_0.method_74().method_4(i + 1).method_69().Location.Y, A_0.method_74().method_4(i + 1).method_69().Width, A_0.method_74().method_4(i + 1).method_69().Height));
                        }
                    }
                    break;
                }
            }
        }
        if (((base.method_4().method_28().method_3().Count == 2) && base.method_4().method_28().method_1()) && (A_0.method_12() != float.MinValue))
        {
            base.method_4().method_28().method_2(false);
            float num7 = Math.Max(base.method_4().method_28().method_3().method_4(0).method_69().Bottom, base.method_4().method_28().method_28().Margins.Top);
            float num9 = A_0.method_12() - num7;
            double num10 = ((double) num9) % A_0.method_7().method_7();
            double num11 = 0.0;
            if (((int) num10) > 0)
            {
                if (((int) (((double) num9) / A_0.method_7().method_7())) == 0)
                {
                    num11 = A_0.method_7().method_7() - num9;
                    A_0.method_94(0.0, num11, true);
                }
                else if ((num10 >= A_0.method_7().method_0()) && (num10 <= A_0.method_7().method_7()))
                {
                    num11 = A_0.method_7().method_4();
                    A_0.method_94(0.0, num11, true);
                }
                else
                {
                    num11 = Math.Abs((double) (A_0.method_7().method_4() - num10));
                    A_0.method_94(0.0, num11, true);
                }
                base.class774_0.method_18((double) A_0.method_69().Bottom);
            }
        }
    }

    private void method_94(Class375 A_0)
    {
        float num = 0f;
        A_0.method_82(null, base.method_4());
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            if (!A_0.method_74().method_4(i).method_79())
            {
                A_0.method_74().method_4(i).method_94((double) -num, 0.0, true);
                if (A_0.method_74().method_4(i).method_73() is TextRange)
                {
                    num += (A_0.method_74().method_4(i).method_73() as TextRange).method_30() / 2f;
                }
                else if (A_0.method_74().method_4(i).method_73() is Class542)
                {
                    num += (A_0.method_74().method_4(i).method_73() as Class542).method_4() / 2f;
                }
            }
        }
    }

    private Section method_95(DocumentObject A_0)
    {
        DocumentObject owner = A_0;
        while (!(owner is Section))
        {
            if (owner.Owner == null)
            {
                break;
            }
            owner = owner.Owner;
        }
        return (owner as Section);
    }

    private Paragraph method_96()
    {
        if (base.class375_1.method_73() is Paragraph)
        {
            return (base.class375_1.method_73() as Paragraph);
        }
        if ((base.class375_1.method_73() is Class65) && ((base.class375_1.method_73() as Class65).method_2() is Paragraph))
        {
            return ((base.class375_1.method_73() as Class65).method_2() as Paragraph);
        }
        return null;
    }

    internal bool method_97(Paragraph A_0)
    {
        int num = 10;
        if (((A_0 == null) || (A_0.ChildObjects.FirstItem == null)) || (!(A_0.ChildObjects.FirstItem is TableOfContent) && ((!(A_0.ChildObjects.FirstItem is Field) || ((A_0.ChildObjects.FirstItem as Field).Type != FieldType.FieldHyperlink)) || ((new Hyperlink(A_0.ChildObjects.FirstItem as Field).BookmarkName == null) || !new Hyperlink(A_0.ChildObjects.FirstItem as Field).BookmarkName.StartsWith(BookmarkStart.b("漯昱嬳唵", num))))))
        {
            return false;
        }
        return true;
    }

    private void method_98(Paragraph A_0)
    {
        if ((base.interface30_0 as Class304).method_2().Count > 0)
        {
            int outlineLevelEx = A_0.Format.OutlineLevelEx;
            if ((base.interface30_0 as Class304).method_2().Contains(outlineLevelEx) && (base.class375_0.method_69().Width > 0f))
            {
                base.interface30_0.imethod_6(base.class375_0);
            }
        }
    }

    protected override void vmethod_1()
    {
        base.method_2();
        Paragraph paragraph = null;
        if (base.class375_1.method_73() is Paragraph)
        {
            paragraph = base.class375_1.method_73() as Paragraph;
        }
        else if (base.class375_1.method_73() is Class65)
        {
            Class65 class2 = base.class375_1.method_73() as Class65;
            if (class2.method_2() is Paragraph)
            {
                paragraph = class2.method_2() as Paragraph;
            }
        }
        if ((base.interface30_0 as Class304).method_3())
        {
            this.method_98(paragraph);
        }
    }

    protected override void vmethod_10(Class615 A_0)
    {
        RectangleF ef = base.class774_0.method_13();
        Class210 class2 = base.method_2() as Class210;
        bool flag = false;
        if (class2 != null)
        {
            flag = !(class2.method_19() == 0f);
        }
        if (base.class375_0.method_74().Count == 0)
        {
            if ((flag && (class2.method_13() < 0)) && !(A_0.method_8() is Class65))
            {
                ef.X += class2.method_19();
                ef.Width -= class2.method_19();
            }
            if (class2.method_13() < 0)
            {
                ef.X += class2.method_51();
                ef.Width -= class2.method_51();
            }
            if (class2.method_13() != -1)
            {
                if (flag && !(A_0.method_8() is Class65))
                {
                    ef.X += class2.method_19() + class2.method_51();
                    ef.Width -= class2.method_19() + class2.method_51();
                }
                else if (!flag && !(A_0.method_8() is Class65))
                {
                    ef.X += class2.method_51();
                    ef.Width -= class2.method_51();
                }
            }
            if ((A_0.method_8() is Class65) && ((A_0.method_8() as Class65).method_2() is Paragraph))
            {
                Paragraph paragraph = (A_0.method_8() as Class65).method_2() as Paragraph;
                int count = paragraph.WidgetCollection.Count;
                if ((count > 1) && (count != (A_0.method_8() as Class65).Interface3.imethod_3()))
                {
                    DocumentObject obj2 = paragraph.WidgetCollection[(count - 1) - (A_0.method_8() as Class65).Interface3.imethod_3()];
                    if ((obj2 is Break) && (((obj2 as Break).BreakType == BreakType.PageBreak) || ((obj2 as Break).BreakType == BreakType.ColumnBreak)))
                    {
                        ef.X += class2.method_19() + class2.method_51();
                        ef.Width -= class2.method_19() + class2.method_51();
                    }
                }
            }
        }
        base.class375_1 = A_0.vmethod_0(ef);
        (base.interface30_0 as Class304).method_12(new Class206.Class215());
        (base.interface30_0 as Class304).method_14(0f);
    }

    protected override void vmethod_11(Class196 A_0, Class615 A_1)
    {
        if ((base.class375_0.method_73().imethod_0() as Class205).method_3() && this.method_92(A_1))
        {
            base.class774_0.method_1(new RectangleF(base.class774_0.method_0().Location, new SizeF(base.class774_0.method_0().Width, base.class774_0.method_0().Height - (base.class375_0.method_73().imethod_0() as Class205).method_7())));
        }
    }

    protected override Class615 vmethod_2()
    {
        if (base.method_29() == null)
        {
            return null;
        }
        return new Class616(base.method_29(), base.interface30_0);
    }

    protected override void vmethod_3(Class615 A_0)
    {
        base.bool_3 = A_0.method_9();
        if (base.bool_6)
        {
            bool flag;
            Class210 class2 = base.method_2() as Class210;
            if (((flag = (class2 != null) ? class2.method_39() : false) && (class2 != null)) && ((base.method_30() is ShapeObject) && ((base.method_30() as ShapeObject).TextWrappingStyle == TextWrappingStyle.Inline)))
            {
                Paragraph paragraph = (base.method_30() as ShapeObject).method_28();
                if (((paragraph != null) && paragraph.IsInCell) && (base.method_5() != null))
                {
                    float num = base.method_5().method_69().Width + (base.method_30() as Interface2).imethod_3(base.method_4()).Width;
                    if (Class59.smethod_5((double) num, base.method_3().method_2(), 0.00050000002374872565) > 0)
                    {
                        flag = false;
                    }
                }
            }
            if (!flag)
            {
                base.interface1_0 = A_0.method_0();
                base.layoutState_0 = LayoutState.Splitted;
            }
            else
            {
                base.layoutState_0 = LayoutState.NotFitted;
            }
        }
        else
        {
            base.layoutState_0 = LayoutState.NotFitted;
        }
    }

    protected override void vmethod_4(Class615 A_0)
    {
        base.method_61(A_0);
        base.layoutState_0 = LayoutState.Fitted;
        Class210 class2 = A_0.method_2() as Class210;
        if ((class2 != null) ? class2.method_37() : false)
        {
            base.class774_0.method_19();
            base.layoutState_0 = LayoutState.Breaked;
        }
    }

    protected override void vmethod_5(Class615 A_0)
    {
        base.method_61(A_0);
        base.interface1_1 = A_0.method_0();
        base.bool_6 = true;
    }

    protected override void vmethod_7()
    {
        RectangleF ef = base.class375_1.method_69();
        if (!base.method_4().method_28().method_13())
        {
            if (base.class774_0.method_11().X != base.class774_0.method_13().X)
            {
                base.class774_0.method_17();
            }
            ef.Height -= (float) base.class375_1.method_73().imethod_0().imethod_1().method_4();
            base.class774_0.method_18((double) ef.Bottom);
        }
        else
        {
            base.class774_0.method_15((double) base.method_4().method_28().method_15());
            base.method_4().method_28().method_14(false);
            base.method_4().method_28().method_16(0f);
            List<RectangleF> list = new List<RectangleF>();
            int num2 = 0;
            int count = base.class375_1.method_74().Count;
            while (num2 < count)
            {
                Class375 class2 = base.class375_1.method_74().method_4(num2);
                if ((class2.method_73() is DocPicture) && ((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))
                {
                    list.Add(class2.method_69());
                }
                num2++;
            }
            if (list.Count > 0)
            {
                RectangleF ef4 = new RectangleF();
                foreach (RectangleF ef5 in list)
                {
                    ef4 = (ef4.Bottom > ef5.Bottom) ? ef4 : ef5;
                }
                list = null;
                if (!ef4.IsEmpty)
                {
                    ef4.Height -= (float) base.class375_1.method_73().imethod_0().imethod_1().method_4();
                    Paragraph paragraph = (base.class375_1.method_73() is Paragraph) ? (base.class375_1.method_73() as Paragraph) : ((!(base.class375_1.method_73() is Class65) || !((base.class375_1.method_73() as Class65).method_2() is Paragraph)) ? null : ((base.class375_1.method_73() as Class65).method_2() as Paragraph));
                    if (paragraph != null)
                    {
                        float num = 0f;
                        if (base.method_4().method_1())
                        {
                            num = (float) base.method_4().method_346(base.method_4().method_376(paragraph.BreakCharacterFormat)).method_0();
                        }
                        else
                        {
                            num = (float) base.method_4().method_339(base.method_4().method_365(paragraph.BreakCharacterFormat)).method_0();
                        }
                        ef4.Height -= num;
                    }
                    base.class774_0.method_18((double) ef4.Bottom);
                }
            }
        }
    }

    protected override void vmethod_8(short A_0, float A_1)
    {
        RectangleF ef = base.class375_1.method_69();
        short num = A_0;
        switch (num)
        {
            case -16:
            case -8:
                if (A_1 > ef.Width)
                {
                    base.class375_1.method_94((double) -(A_1 - ef.Width), 0.0, false);
                }
                else
                {
                    base.class375_1.method_94((double) -ef.Width, 0.0, false);
                }
                return;
        }
        if (num == -4)
        {
            if (A_1 > ef.Width)
            {
                base.class375_1.method_94((double) (-(A_1 - ef.Width) / 2f), 0.0, false);
            }
            else
            {
                base.class375_1.method_94((double) (-ef.Width / 2f), 0.0, false);
            }
        }
    }

    protected override void vmethod_9()
    {
        this.method_93(base.class375_1);
        if ((base.class375_1.method_73() is Paragraph) && (base.class375_1.method_73().imethod_0() is Class210))
        {
            Class210 class3 = base.class375_1.method_73().imethod_0() as Class210;
            if (class3.method_43() && (class3.method_91() != null))
            {
                TabJustification justification = class3.method_91().method_48();
                foreach (Class375 class2 in base.class375_1.method_74())
                {
                    if ((justification != TabJustification.Left) && (class2.method_48() == TabJustification.Left))
                    {
                        class2.method_49(justification);
                    }
                    class3.method_91().method_74().method_7(class2);
                }
                base.class375_1.method_74().Clear();
            }
        }
    }
}

