using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Rendering;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

internal class Class500 : IDisposable
{
    private bool bool_0;
    [CompilerGenerated]
    private bool bool_1;
    private Class200 class200_0;
    private Class200 class200_1;
    private Class200 class200_2;
    private Class376 class376_0;
    private Class376 class376_1;
    private Class376 class376_2;
    private Color color_0 = Color.Empty;
    private DrawPageState drawPageState_0;
    private float float_0;
    private HeaderFooter headerFooter_0;
    private HeadersFooters headersFooters_0;
    private Image image_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private ISection isection_0;
    private List<IField> list_0;
    private List<IField> list_1;
    private List<IField> list_2;
    private List<Class375> list_3;
    private List<Class312> list_4;
    private List<Class312> list_5;
    private PageSetup pageSetup_0;

    public Class500(ISection A_0, int A_1)
    {
        this.isection_0 = A_0;
        this.pageSetup_0 = A_0.PageSetup;
        this.headersFooters_0 = A_0.HeadersFooters;
        this.int_0 = A_1;
        IDocument document = A_0.Document;
        this.image_0 = document.Background.Image;
        this.color_0 = document.Background.Color;
    }

    internal DrawPageState method_0()
    {
        return this.drawPageState_0;
    }

    [CompilerGenerated]
    internal bool method_1()
    {
        return this.bool_1;
    }

    internal void method_10(HeaderFooter A_0)
    {
        this.headerFooter_0 = A_0;
    }

    internal int method_11()
    {
        return this.int_2;
    }

    internal void method_12(int A_0)
    {
        this.int_2 = A_0;
    }

    internal bool method_13()
    {
        return this.bool_0;
    }

    internal void method_14(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal float method_15()
    {
        return this.float_0;
    }

    internal void method_16(float A_0)
    {
        this.float_0 = A_0;
    }

    internal List<IField> method_17()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<IField>();
        }
        return this.list_0;
    }

    internal List<IField> method_18()
    {
        if (this.list_1 == null)
        {
            this.list_1 = new List<IField>();
        }
        return this.list_1;
    }

    internal List<IField> method_19()
    {
        if (this.list_2 == null)
        {
            this.list_2 = new List<IField>();
        }
        return this.list_2;
    }

    [CompilerGenerated]
    internal void method_2(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal List<Class375> method_20()
    {
        if (this.list_3 == null)
        {
            this.list_3 = new List<Class375>();
        }
        return this.list_3;
    }

    internal List<Class312> method_21()
    {
        if (this.list_4 == null)
        {
            this.list_4 = new List<Class312>();
        }
        return this.list_4;
    }

    internal void method_22(List<Class312> A_0)
    {
        this.list_4 = A_0;
    }

    internal List<Class312> method_23()
    {
        if (this.list_5 == null)
        {
            this.list_5 = new List<Class312>();
        }
        return this.list_5;
    }

    internal void method_24(List<Class312> A_0)
    {
        this.list_5 = A_0;
    }

    internal Class200 method_25()
    {
        if (this.class200_0 == null)
        {
            this.class200_0 = new Class200();
        }
        return this.class200_0;
    }

    internal Class200 method_26()
    {
        if (this.class200_1 == null)
        {
            this.class200_1 = new Class200();
        }
        return this.class200_1;
    }

    internal Class200 method_27()
    {
        if (this.class200_2 == null)
        {
            this.class200_2 = new Class200();
        }
        return this.class200_2;
    }

    public PageSetup method_28()
    {
        return this.pageSetup_0;
    }

    internal PageSetup method_29()
    {
        if (this.isection_0 != null)
        {
            return this.isection_0.PageSetup;
        }
        return this.method_28();
    }

    public Class376 method_3()
    {
        if (this.class376_0 == null)
        {
            this.class376_0 = new Class376(null, this);
        }
        return this.class376_0;
    }

    internal ISection method_30()
    {
        return this.isection_0;
    }

    public int method_31()
    {
        return this.int_0;
    }

    public void method_32(int A_0)
    {
        this.int_0 = A_0;
    }

    public float method_33()
    {
        MarginsF margins = this.pageSetup_0.Margins;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            return ((margins.Right != -0.05f) ? margins.Right : 0f);
        }
        return ((margins.Left != -0.05f) ? margins.Left : 0f);
    }

    public float method_34()
    {
        MarginsF margins = this.pageSetup_0.Margins;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            return ((margins.Left != -0.05f) ? margins.Left : 0f);
        }
        return ((margins.Right != -0.05f) ? margins.Right : 0f);
    }

    private void method_35(List<Class199> A_0)
    {
        if ((A_0 != null) && (A_0.Count > 0))
        {
            foreach (Class199 class2 in A_0)
            {
                class2.System.IDisposable.Dispose();
            }
            A_0.Clear();
        }
        A_0 = null;
    }

    private void method_36()
    {
        if ((this.list_4 != null) && (this.list_4.Count > 0))
        {
            foreach (Class312 class2 in this.list_4)
            {
                class2.System.IDisposable.Dispose();
            }
            this.list_4.Clear();
        }
        this.list_4 = null;
    }

    private void method_37(Class500 A_0, Class196 A_1)
    {
        bool flag = false;
        switch (A_0.method_28().PageBordersApplyType)
        {
            case PageBordersApplyType.AllPages:
                flag = true;
                break;

            case PageBordersApplyType.FirstPage:
                if (A_0.method_31() == 0)
                {
                    flag = true;
                }
                break;

            case PageBordersApplyType.AllExceptFirstPage:
                if (A_0.method_31() > 0)
                {
                    flag = true;
                }
                break;
        }
        if (flag && (A_0.method_3().Count != 0))
        {
            if (flag && (A_0.method_3().Count > 1))
            {
                A_1.method_299((this.isection_0 as Section).PageSetup, A_0.method_3().method_4(0).method_69(), A_0.method_3().method_4(1).method_69());
            }
            else
            {
                A_1.method_300(this.isection_0 as Section, A_0.method_3().method_4(0).method_69());
            }
        }
    }

    internal void method_38()
    {
        this.list_4 = new List<Class312>();
    }

    internal void method_39(Class375 A_0)
    {
        for (int i = 0; i < this.method_4().Count; i++)
        {
            if (this.method_4().method_4(i).method_71() == A_0)
            {
                Paragraph ownerParagraph = (A_0.method_73() as Footnote).OwnerParagraph;
                Class205 class1 = ownerParagraph.interface23_0 as Class205;
                class1.method_8(class1.method_7() - this.method_4().method_4(i).method_69().Height);
                if ((A_0.method_73() as Footnote).OwnerParagraph.IsInCell)
                {
                    Class205 class2 = (ownerParagraph.Owner.Owner as TableRow).interface23_0 as Class205;
                    class2.method_8(class2.method_7() - this.method_4().method_4(i).method_69().Height);
                    Class205 class3 = (ownerParagraph.Owner.Owner as TableRow).OwnerTable.interface23_0 as Class205;
                    class3.method_8(class3.method_7() - this.method_4().method_4(i).method_69().Height);
                }
                this.method_4().method_12(i);
                this.method_7(this.method_6() - 1);
                ((A_0.method_73() as Footnote).interface23_0 as Class205).method_6(false);
                return;
            }
        }
    }

    internal Class376 method_4()
    {
        if (this.class376_1 == null)
        {
            this.class376_1 = new Class376(null, this);
        }
        return this.class376_1;
    }

    internal void method_40(Class312 A_0)
    {
        if (!this.method_21().Contains(A_0))
        {
            this.method_21().Add(A_0);
        }
        if (!A_0.method_14() && !this.method_23().Contains(A_0))
        {
            this.method_23().Add(A_0);
        }
    }

    internal void method_41(Class199 A_0)
    {
        if (!this.method_26().Contains(A_0))
        {
            this.method_26().Add(A_0);
        }
    }

    internal void method_42(Class375 A_0)
    {
        int count = this.method_26().Count;
        for (int i = 0; i < count; i++)
        {
            Class199 class2 = this.method_26()[i];
            if (class2.method_2() == A_0)
            {
                this.method_26().RemoveAt(i);
                return;
            }
        }
    }

    internal void method_43(Class375 A_0)
    {
        for (int i = 0; i < this.method_21().Count; i++)
        {
            if (this.method_21()[i].method_4() == A_0.method_73())
            {
                Class312 item = this.method_21()[i];
                this.method_21().Remove(item);
                if (this.method_23().Contains(item))
                {
                    this.method_23().Remove(item);
                    return;
                }
                break;
            }
        }
    }

    internal void method_44(Class199 A_0)
    {
        if (!this.method_25().Contains(A_0))
        {
            this.method_25().Add(A_0);
        }
    }

    internal void method_45(Class375 A_0)
    {
        int count = this.method_25().Count;
        for (int i = 0; i < count; i++)
        {
            Class199 class2 = this.method_25()[i];
            if (class2.method_2() == A_0)
            {
                this.method_25().RemoveAt(i);
                return;
            }
        }
    }

    internal void method_46(Class199 A_0)
    {
        if (!this.method_26().Contains(A_0))
        {
            this.method_26().Add(A_0);
        }
    }

    internal float method_47()
    {
        if (this.class376_0.Count == 0)
        {
            return 0f;
        }
        if (this.class376_0.method_4(0).method_69().Height == 0f)
        {
            return 0f;
        }
        return this.class376_0.method_4(0).method_69().Bottom;
    }

    internal float method_48()
    {
        if ((this.class376_0.method_4(0).method_73() as HeaderFooter).Document.Settings.method_3() == 15)
        {
            return this.method_47();
        }
        float num = 0f;
        foreach (Class375 class2 in this.class376_0.method_4(0).method_74())
        {
            if (!(class2.method_73() is Table) || !(class2.method_73() as Table).TableFormat.WrapTextAround)
            {
                num = Math.Max(num, class2.method_69().Bottom);
            }
        }
        return num;
    }

    internal float method_49()
    {
        if (this.class376_0.Count <= 1)
        {
            return 0f;
        }
        RectangleF ef = this.class376_0.method_4(1).method_69();
        return (this.pageSetup_0.PageSize.Height - ef.Top);
    }

    internal Class376 method_5()
    {
        if (this.class376_2 == null)
        {
            this.class376_2 = new Class376(null, this);
        }
        return this.class376_2;
    }

    internal float method_50(Interface1 A_0)
    {
        float num = 0f;
        if (this.method_21().Count > 0)
        {
            this.method_21().Sort();
            foreach (Class312 class2 in this.method_21())
            {
                if (((A_0 == null) || (class2.method_4() == null)) || (A_0 != class2.method_4()))
                {
                    num = Math.Max(num, class2.method_0().Bottom);
                }
            }
        }
        return num;
    }

    internal Class312 method_51(RectangleF A_0, Interface1 A_1)
    {
        if ((this.method_3().Count <= 1) && (this.method_28().Document.Settings.method_3() != 15))
        {
            return new Class312();
        }
        Class312 class2 = new Class312();
        if (this.method_21().Count > 0)
        {
            this.method_21().Sort();
            bool flag = false;
            bool flag2 = false;
            Table owner = null;
            TableCell cell = null;
            if (A_1 is TextRange)
            {
                flag = this.method_56(A_1 as TextRange, ref owner, ref cell);
                flag2 = this.method_58(A_1 as TextRange);
            }
            else if (A_1 is Class542)
            {
                flag = this.method_56((A_1 as Class542).method_2() as TextRange, ref owner, ref cell);
                flag2 = this.method_58((A_1 as Class542).method_2() as TextRange);
            }
            else if (A_1 is Paragraph)
            {
                flag2 = this.method_60(A_1 as Paragraph);
            }
            else if (A_1 is Table)
            {
                flag2 = this.method_62(A_1 as Table);
            }
            else if (A_1 is ParagraphBase)
            {
                flag = this.method_57(A_1 as ParagraphBase, ref owner, ref cell);
                flag2 = this.method_59(A_1 as ParagraphBase);
            }
            if ((A_1 is Paragraph) && (A_1 as Paragraph).IsInCell)
            {
                owner = (A_1 as Paragraph).Owner.Owner.Owner as Table;
            }
            if (((owner != null) && (!owner.IsTextBox || ((owner.IsTextBox && (owner.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Behind)) && (owner.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.InFrontOfText)))) || (owner == null))
            {
                foreach (Class312 class3 in this.method_21())
                {
                    using (Region region = class3.method_8().Clone())
                    {
                        region.Intersect(A_0);
                        if (((region.IsVisible(A_0) && (!flag2 || !class3.method_18())) && (((class3.method_4() == null) || (A_1 == null)) || (class3.method_4() != A_1))) && ((((flag && !flag2) && (((class3.method_16() == flag) && !class3.method_18()) && (class3.method_6() == cell))) || (((this.method_3().Count >= 2) && !flag) && !flag2)) || ((((this.method_3().Count < 2) && !class3.method_18()) && (!flag && !flag2)) || ((flag && flag2) && (class3.method_16() && class3.method_18())))))
                        {
                            class2 = class3;
                            class2.method_13(region.GetRegionScans(new Matrix()));
                            return class2;
                        }
                    }
                }
            }
        }
        return class2;
    }

    internal bool method_52(RectangleF A_0, Interface1 A_1, bool A_2)
    {
        A_0 = new RectangleF(A_0.X, A_0.Y, A_0.Width, A_0.Height);
        if (this.method_21().Count > 0)
        {
            this.method_21().Sort();
            foreach (Class312 class2 in this.method_21())
            {
                using (Region region = class2.method_8().Clone())
                {
                    region.Intersect(A_0);
                    if ((class2.method_8().IsVisible(A_0) && (class2.method_16() == A_2)) && this.method_53(A_1, class2.method_4() as DocumentObject))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool method_53(Interface1 A_0, DocumentObject A_1)
    {
        DocumentObject owner = A_1;
        while (owner != null)
        {
            if (owner.Owner == A_0)
            {
                break;
            }
            owner = owner.Owner;
        }
        return (owner != null);
    }

    internal bool method_54(RectangleF A_0)
    {
        A_0 = new RectangleF(A_0.X, A_0.Y, A_0.Width, A_0.Height);
        if (this.method_21().Count > 0)
        {
            this.method_21().Sort();
            foreach (Class312 class2 in this.method_21())
            {
                using (Region region = class2.method_8().Clone())
                {
                    region.Intersect(A_0);
                    if (class2.method_8().IsVisible(A_0))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private Class312 method_55(List<Class312> A_0)
    {
        Class312 class2 = A_0[0];
        for (int i = 1; i < A_0.Count; i++)
        {
            if (class2.method_0().Bottom < A_0[i].method_0().Bottom)
            {
                class2 = A_0[i];
            }
        }
        return class2;
    }

    private bool method_56(TextRange A_0, ref Table A_1, ref TableCell A_2)
    {
        return this.method_57(A_0, ref A_1, ref A_2);
    }

    private bool method_57(ParagraphBase A_0, ref Table A_1, ref TableCell A_2)
    {
        bool flag = false;
        if ((A_0.Owner != null) && (A_0.Owner is Paragraph))
        {
            if (flag = (A_0.Owner as Paragraph).IsInCell)
            {
                A_2 = (A_0.Owner as Paragraph).Owner as TableCell;
                A_1 = (A_0.Owner as Paragraph).Owner.Owner.Owner as Table;
            }
            return flag;
        }
        if (A_0.OwnerParagraph != null)
        {
            if (flag = A_0.OwnerParagraph.IsInCell)
            {
                A_2 = A_0.OwnerParagraph.Owner as TableCell;
                A_1 = A_0.OwnerParagraph.Owner.Owner.Owner as Table;
            }
            return flag;
        }
        if ((A_0 is TextRange) && ((A_0 as TextRange).OwnerEmptyParagraph != null))
        {
            if (flag = (A_0 as TextRange).OwnerEmptyParagraph.IsInCell)
            {
                A_2 = (A_0 as TextRange).OwnerEmptyParagraph.Owner as TableCell;
                A_1 = (A_0 as TextRange).OwnerEmptyParagraph.Owner.Owner.Owner as Table;
            }
            return flag;
        }
        return false;
    }

    private bool method_58(TextRange A_0)
    {
        return this.method_59(A_0);
    }

    private bool method_59(ParagraphBase A_0)
    {
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        if ((ownerParagraph == null) && (A_0 is TextRange))
        {
            ownerParagraph = (A_0 as TextRange).OwnerEmptyParagraph;
        }
        if (ownerParagraph != null)
        {
            if (!ownerParagraph.IsInCell)
            {
                return (((Interface1) ownerParagraph).imethod_0() as Class213).method_105();
            }
            if ((ownerParagraph.IsInCell && (ownerParagraph.Owner.Owner.Owner is Table)) && (ownerParagraph.Owner.Owner.Owner as Interface4).imethod_3().imethod_14())
            {
                return true;
            }
        }
        return false;
    }

    internal int method_6()
    {
        return this.int_1;
    }

    private bool method_60(Paragraph A_0)
    {
        if ((A_0 == null) || (!(((Interface1) A_0).imethod_0() as Class213).method_105() && (!A_0.IsInCell || !(A_0.Owner.Owner.Owner as Table).IsFrame)))
        {
            return false;
        }
        return true;
    }

    private bool method_61(ParagraphBase A_0)
    {
        if (A_0.OwnerParagraph != null)
        {
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            return this.method_60(ownerParagraph);
        }
        return false;
    }

    private bool method_62(Table A_0)
    {
        return ((A_0 != null) && A_0.IsFrame);
    }

    internal float method_63(Paragraph A_0, Class210 A_1, PointF A_2, Class196 A_3, TextBoxFormat A_4)
    {
        PointF tf = A_2;
        if (A_1 != null)
        {
            A_2.Y = A_1.method_57();
        }
        if ((A_4.TextWrappingStyle != TextWrappingStyle.Behind) && (A_4.TextWrappingStyle != TextWrappingStyle.InFrontOfText))
        {
            return this.method_64(A_0, A_2, A_3, tf);
        }
        return this.method_64(A_0, A_2, A_3, A_2);
    }

    internal float method_64(Paragraph A_0, PointF A_1, Class196 A_2, PointF A_3)
    {
        bool flag = false;
        return this.method_65(A_0, A_1, A_2, A_3, ref flag);
    }

    internal float method_65(Paragraph A_0, PointF A_1, Class196 A_2, PointF A_3, ref bool A_4)
    {
        return this.method_66(A_0, A_1, A_2, A_3, ref A_4, null);
    }

    internal float method_66(Paragraph A_0, PointF A_1, Class196 A_2, PointF A_3, ref bool A_4, DocumentObject A_5)
    {
        string str;
        int num = 1;
        if (A_2.method_135())
        {
            return 0f;
        }
        float num2 = 0f;
        TextRange range = A_0.method_38();
        if (range == null)
        {
            range = new TextRange(A_0.Document);
            range.ApplyCharacterFormat(A_0.BreakCharacterFormat);
        }
        string[] strArray = range.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (strArray.Length > 0)
        {
            str = strArray[0];
        }
        else
        {
            str = BookmarkStart.b("ܦ", num);
        }
        str = str.Replace(BookmarkStart.b("⸦", num), BookmarkStart.b("ܦनପബ", num));
        SizeF size = A_2.method_1() ? A_2.method_309(str, A_2.method_376(range.CharacterFormat), null) : A_2.method_316(str, A_2.method_365(range.CharacterFormat), null);
        Section section = A_0.method_49();
        float left = section.PageSetup.Margins.Left;
        float num4 = (left + section.PageSetup.ClientWidth) - size.Width;
        A_1 = new PointF(left, A_1.Y);
        RectangleF ef4 = new RectangleF(A_1, size);
        while (true)
        {
            Class312 class2 = this.method_51(ef4, range);
            while (!class2.method_0().IsEmpty && (((class2.method_2().method_0() == TextWrappingStyle.Square) || (class2.method_2().method_0() == TextWrappingStyle.Through)) || (class2.method_2().method_0() == TextWrappingStyle.Tight)))
            {
                if (((class2.method_4() != null) && (class2.method_4() is ParagraphBase)) && A_0.Items.Contains((DocumentObject) class2.method_4()))
                {
                    A_4 = true;
                    if ((A_5 != null) && (A_0.Items.InnerList.IndexOf((DocumentObject) class2.method_4()) > A_0.Items.InnerList.IndexOf(A_5)))
                    {
                        num2 = 0f;
                        break;
                    }
                }
                RectangleF ef6 = this.method_67(class2, A_1, left, num4, size, ref num2);
                if (!ef6.IsEmpty)
                {
                    class2 = this.method_51(ef6, range);
                }
                else
                {
                    class2 = new Class312();
                }
            }
            if (A_3.IsEmpty || (Class59.smethod_4(A_1.Y, A_3.Y, 0.05f) >= 0))
            {
                return num2;
            }
            RectangleF ef = new RectangleF(new PointF(num2, A_3.Y), size);
            if (this.method_51(ef, range).method_0().IsEmpty)
            {
                return num2;
            }
            A_1 = ef.Location;
            ef4 = ef;
        }
    }

    private RectangleF method_67(Class312 A_0, PointF A_1, float A_2, float A_3, SizeF A_4, ref float A_5)
    {
        if (A_3 < 0f)
        {
            A_5 = 0f;
            return new RectangleF();
        }
        if (((A_1.X >= A_0.method_0().X) && (A_1.X < A_0.method_0().Right)) && (A_0.method_0().Right < A_3))
        {
            A_5 = A_0.method_0().Right;
            return new RectangleF(new PointF(A_5, A_1.Y), A_4);
        }
        if (A_5 >= A_3)
        {
            A_5 = 0f;
            A_1.Y += A_4.Height;
            return new RectangleF(new PointF(A_2, A_1.Y), A_4);
        }
        A_5 = 0f;
        return new RectangleF();
    }

    public void method_68(Class196 A_0)
    {
        if (this.method_28().Document.ViewSetup.DisplayBackgroundShape)
        {
            if (this.image_0 != null)
            {
                A_0.method_296(this.image_0, this.method_28());
            }
            A_0.method_295(this.color_0, (int) this.method_28().PageSize.Width, (int) this.method_28().PageSize.Height);
        }
        if (this.method_3().Count > 2)
        {
            A_0.method_297(this.method_9().Watermark, this);
        }
        if (!this.method_28().IsFrontPageBorder)
        {
            this.method_37(this, A_0);
        }
        this.method_71(this.method_25(), A_0, true);
        for (int i = 0; i < this.method_3().Count; i++)
        {
            Class375 class2 = this.method_3().method_4(i);
            if (i < 1)
            {
                this.drawPageState_0 = DrawPageState.DrawHeader;
            }
            else if (i == 1)
            {
                this.drawPageState_0 = DrawPageState.DrawFooter;
            }
            else
            {
                this.drawPageState_0 = DrawPageState.DrawBody;
            }
            class2.method_88(A_0);
            if (i == 1)
            {
                this.method_71(this.method_27(), A_0, true);
                this.method_71(this.method_26(), A_0, true);
                this.method_71(this.method_25(), A_0, false);
            }
        }
        this.method_71(this.method_27(), A_0, false);
        this.method_71(this.method_26(), A_0, false);
        if (this.method_28().IsFrontPageBorder)
        {
            this.method_37(this, A_0);
        }
        this.method_69(A_0);
        this.method_70(A_0);
    }

    private void method_69(Class196 A_0)
    {
        if (this.method_5().Count <= 0)
        {
            return;
        }
        PointF tf = new PointF(this.method_5().method_4(0).method_69().Location.X, this.method_5().method_4(0).method_69().Y - 6f);
        PointF tf3 = new PointF(tf.X + 144f, tf.Y);
        if (this.method_5().method_4(0).method_73() is Class65)
        {
            tf3 = new PointF(tf.X + this.method_28().ClientWidth, tf.Y);
        }
        if (A_0.method_1())
        {
            using (Pen pen2 = new Pen(Color.Black, 0.5f))
            {
                A_0.method_126().method_10(pen2, tf, tf3);
                goto Label_0112;
            }
        }
        using (Pen pen = new Pen(Color.Black, 0.5f))
        {
            A_0.method_151().DrawLine(pen, tf, tf3);
        }
    Label_0112:
        foreach (Class375 class2 in this.method_5())
        {
            class2.method_88(A_0);
        }
    }

    internal void method_7(int A_0)
    {
        this.int_1 = A_0;
    }

    private void method_70(Class196 A_0)
    {
        if (this.method_4().Count <= 0)
        {
            return;
        }
        PointF tf = new PointF(this.method_4().method_4(0).method_69().Location.X, this.method_4().method_4(0).method_69().Y - 6f);
        PointF tf3 = new PointF(tf.X + 144f, tf.Y);
        if (A_0.method_1())
        {
            using (Pen pen2 = new Pen(Color.Black, 0.5f))
            {
                A_0.method_126().method_10(pen2, tf, tf3);
                goto Label_00D9;
            }
        }
        using (Pen pen = new Pen(Color.Black, 0.5f))
        {
            A_0.method_151().DrawLine(pen, tf, tf3);
        }
    Label_00D9:
        foreach (Class375 class2 in this.method_4())
        {
            class2.method_88(A_0);
        }
    }

    internal void method_71(Class200 A_0, Class196 A_1, bool A_2)
    {
        if (A_0.Count > 0)
        {
            A_0.method_1();
            int num = 0;
            int count = A_0.Count;
            while (num < count)
            {
                Class199 class2 = A_0[num];
                if (class2.method_8() == A_2)
                {
                    if ((class2.method_0() != null) && class2.method_0().HasImage)
                    {
                        A_1.method_218(class2.method_0(), class2.method_2(), class2.method_4());
                    }
                    else if (((class2.method_0() != null) && (class2.method_0().ShapeInfo != null)) && (class2.method_0().ShapeInfo is ShapeGroup))
                    {
                        A_1.method_217(class2.method_0().ShapeInfo, class2.method_2());
                    }
                    else if (class2.method_0() != null)
                    {
                        A_1.method_217(class2.method_0(), class2.method_2());
                    }
                    else if (class2.method_2() != null)
                    {
                        if (class2.method_2().method_73() is Table)
                        {
                            Table table = class2.method_2().method_73() as Table;
                            class2.method_2().method_33(false);
                            GraphicsState gstate = null;
                            if (A_1.method_1())
                            {
                                A_1.method_126().method_4();
                            }
                            else
                            {
                                gstate = A_1.method_151().Save();
                            }
                            if (class2.method_2().method_6().HasValue)
                            {
                                if (A_1.method_1())
                                {
                                    A_1.method_126().method_6(class2.method_2().method_6().Value);
                                }
                                else
                                {
                                    A_1.method_151().SetClip(class2.method_2().method_6().Value, CombineMode.Intersect);
                                }
                            }
                            if ((table.IsTextBox && (table.TextBoxFormat.Rotation != 0f)) && !A_1.method_1())
                            {
                                RectangleF ef = class2.method_2().method_69();
                                A_1.method_151().TranslateTransform(ef.X + (ef.Width / 2f), ef.Y + (ef.Height / 2f));
                                A_1.method_151().RotateTransform(table.TextBoxFormat.Rotation);
                                A_1.method_151().TranslateTransform(-(ef.X + (ef.Width / 2f)), -(ef.Y + (ef.Height / 2f)));
                            }
                            class2.method_2().method_88(A_1);
                            class2.method_2().method_33(true);
                            if (class2.method_2().method_6().HasValue)
                            {
                                if (A_1.method_1())
                                {
                                    A_1.method_126().method_7();
                                }
                                else
                                {
                                    A_1.method_151().ResetClip();
                                }
                            }
                            if (A_1.method_1())
                            {
                                A_1.method_126().method_5();
                            }
                            else
                            {
                                A_1.method_151().Restore(gstate);
                            }
                        }
                        else
                        {
                            class2.method_2().method_88(A_1);
                        }
                    }
                }
                num++;
            }
        }
    }

    internal void method_72(SortedList<int, Class199> A_0, Class196 A_1, bool A_2)
    {
        if (A_0.Count > 0)
        {
            foreach (KeyValuePair<int, Class199> pair in A_0)
            {
                Class199 class2 = pair.Value;
                if (class2.method_8() == A_2)
                {
                    if ((class2.method_0() != null) && class2.method_0().HasImage)
                    {
                        A_1.method_218(class2.method_0(), class2.method_2(), class2.method_4());
                    }
                    else if (((class2.method_0() != null) && (class2.method_0().ShapeInfo != null)) && (class2.method_0().ShapeInfo is ShapeGroup))
                    {
                        A_1.method_217(class2.method_0().ShapeInfo, class2.method_2());
                    }
                    else if (class2.method_0() != null)
                    {
                        A_1.method_217(class2.method_0(), class2.method_2());
                    }
                    else if (class2.method_2() != null)
                    {
                        class2.method_2().method_88(A_1);
                    }
                }
            }
        }
    }

    public void method_73(int A_0)
    {
        this.method_74(A_0, false);
    }

    public void method_74(int A_0, bool A_1)
    {
        List<IField> list = A_1 ? this.method_18() : this.method_17();
        FieldType type = A_1 ? FieldType.FieldSectionPages : FieldType.FieldNumPages;
        for (int i = 0; i < list.Count; i++)
        {
            IField field = list[i];
            if (((field != null) && (field.Type == type)) && !(field as Field).IsLocked)
            {
                foreach (Class375 class2 in this.method_20())
                {
                    IField field2 = (class2.method_73() is IField) ? (class2.method_73() as IField) : ((!(class2.method_73() is Class542) || !((class2.method_73() as Class542).method_2() is IField)) ? null : ((class2.method_73() as Class542).method_2() as IField));
                    if (field == field2)
                    {
                        class2.method_65((field as Field).method_95(A_0.ToString(), (field as Field).FormattingString, this.method_30().PageSetup.PageNumberStyle));
                    }
                }
            }
        }
    }

    internal void method_75(Class195 A_0)
    {
        List<IField> list = this.method_19();
        for (int i = 0; i < list.Count; i++)
        {
            IField field = list[i];
            if (((field != null) && (field.Type == FieldType.FieldPageRef)) && !(field as Field).IsLocked)
            {
                string key = (field as Field).method_177().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                int num2 = 1;
                if (A_0.dictionary_1.ContainsKey(key))
                {
                    num2 = A_0.dictionary_1[key];
                }
                foreach (Class375 class2 in this.method_20())
                {
                    IField field2 = (class2.method_73() is IField) ? (class2.method_73() as IField) : ((!(class2.method_73() is Class542) || !((class2.method_73() as Class542).method_2() is IField)) ? null : ((class2.method_73() as Class542).method_2() as IField));
                    if (field == field2)
                    {
                        class2.method_65((field as Field).method_95(num2.ToString(), (field as Field).FormattingString, this.method_30().PageSetup.PageNumberStyle));
                    }
                }
            }
        }
    }

    internal float method_76()
    {
        float num = 0f;
        foreach (Class375 class2 in this.method_4())
        {
            num += class2.method_69().Height;
        }
        if (num != 0f)
        {
            return (num + 12f);
        }
        return num;
    }

    internal float method_77()
    {
        float height = 0f;
        if (this.method_4().Count > 0)
        {
            float num2 = Math.Min(this.method_3().method_4(1).method_69().Y, this.pageSetup_0.ClientHeight + this.method_28().Margins.Top);
            height = this.method_4().method_0().method_69().Height;
            float num3 = (num2 - this.method_4().method_0().method_69().Y) - height;
            this.method_4().method_0().method_94(0.0, (double) num3, true);
            for (int i = 0; i <= (this.method_4().Count - 2); i++)
            {
                this.method_4().method_4(i).method_94(0.0, (double) -height, true);
            }
        }
        return height;
    }

    internal void method_78(Class375 A_0)
    {
        this.method_20().Add(A_0);
    }

    public void method_79(IField A_0)
    {
        this.method_17().Add(A_0);
    }

    internal byte method_8()
    {
        if ((this.method_30() != null) && (this.method_30().Document != null))
        {
            return this.method_30().Document.Settings.method_3();
        }
        return 11;
    }

    public void method_80(IField A_0)
    {
        this.method_18().Add(A_0);
    }

    protected internal RectangleF method_81()
    {
        MarginsF margins = this.pageSetup_0.Margins;
        float x = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            x = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            x = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        x = (x != -0.05f) ? x : 0f;
        float num4 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num4 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        else
        {
            num4 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        num4 = (num4 != -0.05f) ? num4 : 0f;
        float num3 = (this.pageSetup_0.Margins.Top != -0.05f) ? this.pageSetup_0.Margins.Top : 0f;
        float num8 = (this.pageSetup_0.Margins.Bottom != -0.05f) ? this.pageSetup_0.Margins.Bottom : 0f;
        float y = this.pageSetup_0.OwnerSection.SectPr.HasKey(0x910) ? this.pageSetup_0.HeaderDistance : 36f;
        float width = this.pageSetup_0.PageSize.Width;
        float height = this.pageSetup_0.PageSize.Height;
        float gutter = margins.Gutter;
        if (!this.pageSetup_0.OwnerSection.SectPr.HasKey(0x910))
        {
            this.pageSetup_0.HeaderDistance = 36f;
        }
        if (gutter > 0f)
        {
            if (this.pageSetup_0.GutterAtTop)
            {
                num3 += gutter;
            }
            else if (this.pageSetup_0.DifferentOddAndEvenPagesHeaderFooter)
            {
                if (((this.method_31() + 1) % 2) == 1)
                {
                    x += gutter;
                }
                else
                {
                    num4 += gutter;
                }
            }
            else
            {
                x += gutter;
            }
        }
        return new RectangleF(x, y, width - (x + num4), height - (num3 + num8));
    }

    protected internal RectangleF method_82(PageSetup A_0)
    {
        MarginsF margins = this.pageSetup_0.Margins;
        float x = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            x = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            x = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        x = (x != -0.05f) ? x : 0f;
        float num2 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num2 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        else
        {
            num2 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        num2 = (num2 != -0.05f) ? num2 : 0f;
        float num3 = (A_0.Margins.Top != -0.05f) ? A_0.Margins.Top : 0f;
        float num4 = (A_0.Margins.Bottom != -0.05f) ? A_0.Margins.Bottom : 0f;
        float y = A_0.OwnerSection.SectPr.HasKey(0x910) ? A_0.HeaderDistance : 36f;
        float width = A_0.PageSize.Width;
        float height = A_0.PageSize.Height;
        if (!A_0.OwnerSection.SectPr.HasKey(0x910))
        {
            A_0.HeaderDistance = 36f;
        }
        return new RectangleF(x, y, width - (x + num2), height - (num3 + num4));
    }

    protected internal RectangleF method_83()
    {
        if (this.pageSetup_0.Margins.Top != -0.05f)
        {
            float top = this.pageSetup_0.Margins.Top;
        }
        if (this.pageSetup_0.Margins.Bottom != -0.05f)
        {
            float bottom = this.pageSetup_0.Margins.Bottom;
        }
        float y = this.pageSetup_0.OwnerSection.SectPr.HasKey(0x910) ? this.pageSetup_0.HeaderDistance : 36f;
        float width = this.pageSetup_0.PageSize.Width;
        float height = this.pageSetup_0.PageSize.Height;
        if (!this.pageSetup_0.OwnerSection.SectPr.HasKey(0x910))
        {
            this.pageSetup_0.HeaderDistance = 36f;
        }
        return new RectangleF(0f, y, width, height);
    }

    protected internal RectangleF method_84()
    {
        MarginsF margins = this.pageSetup_0.Margins;
        float x = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            x = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            x = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        x = (x != -0.05f) ? x : 0f;
        float num2 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num2 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        else
        {
            num2 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        num2 = (num2 != -0.05f) ? num2 : 0f;
        float num3 = (this.pageSetup_0.Margins.Top != -0.05f) ? this.pageSetup_0.Margins.Top : 0f;
        float num4 = (this.pageSetup_0.Margins.Bottom != -0.05f) ? this.pageSetup_0.Margins.Bottom : 0f;
        float num5 = this.pageSetup_0.OwnerSection.SectPr.HasKey(0x91a) ? this.pageSetup_0.FooterDistance : 36f;
        float width = this.pageSetup_0.PageSize.Width;
        float height = this.pageSetup_0.PageSize.Height;
        if (!this.pageSetup_0.OwnerSection.SectPr.HasKey(0x91a))
        {
            this.pageSetup_0.FooterDistance = 36f;
        }
        return new RectangleF(x, height - num5, width - (x + num2), height - (num3 + num4));
    }

    protected internal RectangleF method_85(PageSetup A_0)
    {
        MarginsF margins = A_0.Margins;
        float x = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            x = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            x = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        x = (x != -0.05f) ? x : 0f;
        float num2 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num2 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        else
        {
            num2 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        num2 = (num2 != -0.05f) ? num2 : 0f;
        float num3 = (A_0.Margins.Top != -0.05f) ? A_0.Margins.Top : 0f;
        float num4 = (A_0.Margins.Bottom != -0.05f) ? A_0.Margins.Bottom : 0f;
        float num5 = A_0.OwnerSection.SectPr.HasKey(0x91a) ? A_0.FooterDistance : 36f;
        float width = A_0.PageSize.Width;
        float height = A_0.PageSize.Height;
        if (!A_0.OwnerSection.SectPr.HasKey(0x91a))
        {
            A_0.FooterDistance = 36f;
        }
        return new RectangleF(x, height - num5, width - (x + num2), height - (num3 + num4));
    }

    protected internal RectangleF method_86()
    {
        if (this.pageSetup_0.Margins.Top != -0.05f)
        {
            float top = this.pageSetup_0.Margins.Top;
        }
        if (this.pageSetup_0.Margins.Bottom != -0.05f)
        {
            float bottom = this.pageSetup_0.Margins.Bottom;
        }
        float num = this.pageSetup_0.OwnerSection.SectPr.HasKey(0x91a) ? this.pageSetup_0.FooterDistance : 36f;
        float width = this.pageSetup_0.PageSize.Width;
        float height = this.pageSetup_0.PageSize.Height;
        if (!this.pageSetup_0.OwnerSection.SectPr.HasKey(0x91a))
        {
            this.pageSetup_0.FooterDistance = 36f;
        }
        return new RectangleF(0f, height - num, width, height);
    }

    internal float method_87(int A_0)
    {
        MarginsF margins = this.pageSetup_0.Margins;
        float width = this.pageSetup_0.PageSize.Width;
        float height = this.pageSetup_0.PageSize.Height;
        float num = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            num = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        if (this.isection_0.Columns.Count > 1)
        {
            for (int i = 0; i < A_0; i++)
            {
                Column column = (this.isection_0.Columns.Count > i) ? this.isection_0.Columns[i] : null;
                if (column != null)
                {
                    num += column.Width + column.Space;
                }
            }
        }
        return num;
    }

    protected internal RectangleF method_88(Column A_0, float A_1)
    {
        float clientWidth;
        MarginsF margins = this.pageSetup_0.Margins;
        float width = this.pageSetup_0.PageSize.Width;
        float height = this.pageSetup_0.PageSize.Height;
        float num7 = Math.Abs((margins.Top != -0.05f) ? margins.Top : 0f);
        float x = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            x = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            x = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        float num9 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num9 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        else
        {
            num9 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        float num10 = Math.Abs((margins.Bottom != -0.05f) ? margins.Bottom : 0f);
        float gutter = margins.Gutter;
        float num8 = ((!this.headersFooters_0.IsEmpty || this.headersFooters_0.LinkToPrevious) || (this.pageSetup_0.HeaderDistance >= num7)) ? (((this.method_3().Count <= 0) || (this.method_3().method_4(0).method_69().Height <= 0f)) ? ((((this.method_3().Count <= 0) || (this.method_3().method_4(0).method_69().Height > 0f)) || (this.method_3().method_4(0).method_74().Count != 0)) ? (this.pageSetup_0.OwnerSection.SectPr.HasKey(0x910) ? this.pageSetup_0.HeaderDistance : 0f) : 0f) : (this.pageSetup_0.HeaderDistance + this.method_3().method_4(0).method_69().Height)) : 0f;
        float num11 = ((!this.headersFooters_0.IsEmpty || this.headersFooters_0.LinkToPrevious) || (this.pageSetup_0.FooterDistance >= num10)) ? (((this.method_3().Count <= 1) || (this.method_3().method_4(1).method_69().Height <= 0f)) ? ((((this.method_3().Count <= 1) || (this.method_3().method_4(1).method_69().Height > 0f)) || (this.method_3().method_4(1).method_74().Count != 0)) ? (this.pageSetup_0.OwnerSection.SectPr.HasKey(0x91a) ? this.pageSetup_0.FooterDistance : 0f) : 0f) : (this.pageSetup_0.FooterDistance + this.method_3().method_4(1).method_69().Height)) : 0f;
        if (this.isection_0.Columns.Count > 1)
        {
            clientWidth = (A_0 == null) ? (width - (x + num9)) : A_0.Width;
        }
        else
        {
            clientWidth = this.isection_0.PageSetup.ClientWidth;
        }
        RectangleF empty = RectangleF.Empty;
        if (margins.Top < 0f)
        {
            empty = new RectangleF(x + A_1, Math.Abs(margins.Top), clientWidth, height - (Math.Abs(margins.Top) + Math.Max(num10, num11)));
        }
        else
        {
            empty = new RectangleF(x + A_1, Math.Max(num7, num8), clientWidth, height - (Math.Max(num7, num8) + Math.Max(num10, num11)));
        }
        if (gutter <= 0f)
        {
            return empty;
        }
        if (this.pageSetup_0.GutterAtTop)
        {
            return new RectangleF(empty.Left, empty.Top + gutter, empty.Width, empty.Height - gutter);
        }
        float num6 = (this.isection_0.Columns.Count == 1) ? (empty.Width - gutter) : empty.Width;
        if (this.pageSetup_0.DifferentOddAndEvenPagesHeaderFooter)
        {
            x = (((this.method_31() + 1) % 2) == 1) ? (empty.Left + gutter) : empty.Left;
        }
        else
        {
            x = empty.Left + gutter;
        }
        return new RectangleF(x, empty.Top, num6, empty.Height);
    }

    internal Paragraph method_89()
    {
        Paragraph paragraph = null;
        if (this.method_3().Count > 2)
        {
            Class375 class2 = this.method_3().method_4(this.method_3().Count - 1);
            while (class2 != null)
            {
                if (class2.method_74().Count <= 0)
                {
                    return paragraph;
                }
                if (class2.method_73() is Paragraph)
                {
                    return (class2.method_73() as Paragraph);
                }
                if (class2.method_74().Count > 0)
                {
                    class2 = class2.method_74().method_4(class2.method_74().Count - 1);
                }
            }
        }
        return paragraph;
    }

    internal HeaderFooter method_9()
    {
        return this.headerFooter_0;
    }

    internal Class375 method_90()
    {
        Class375 class2 = null;
        if (this.method_3().Count > 2)
        {
            Class375 class3 = this.method_3().method_4(this.method_3().Count - 1);
            while (class3 != null)
            {
                if (class3.method_74().Count <= 0)
                {
                    return class2;
                }
                if (class3.method_73() is Paragraph)
                {
                    return class3;
                }
                if (class3.method_74().Count > 0)
                {
                    class3 = class3.method_74().method_4(class3.method_74().Count - 1);
                }
            }
        }
        return class2;
    }

    internal Class375 method_91()
    {
        Class375 class2 = null;
        if (this.method_3().Count > 2)
        {
            Class375 class3 = this.method_3().method_4(this.method_3().Count - 1);
            while (class3 != null)
            {
                if (class3.method_74().Count <= 0)
                {
                    return class2;
                }
                if ((class3.method_73() is Section) || ((class3.method_73() is Class65) && ((class3.method_73() as Class65).method_2() is Section)))
                {
                    return class3;
                }
                if (class3.method_74().Count > 0)
                {
                    class3 = class3.method_74().method_4(class3.method_74().Count - 1);
                }
            }
        }
        return class2;
    }

    protected internal RectangleF method_92(int A_0, ref float A_1)
    {
        Column column = (this.isection_0.Columns.Count > A_0) ? this.isection_0.Columns[A_0] : null;
        RectangleF ef = this.method_88(column, A_1);
        if (column != null)
        {
            A_1 += column.Width + column.Space;
        }
        return ef;
    }

    protected internal RectangleF method_93(Column A_0, float A_1)
    {
        float clientWidth;
        MarginsF margins = this.isection_0.PageSetup.Margins;
        float width = this.isection_0.PageSetup.PageSize.Width;
        float height = this.isection_0.PageSetup.PageSize.Height;
        float num3 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num3 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        else
        {
            num3 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        num3 = (num3 != -0.05f) ? num3 : 0f;
        float num4 = 0f;
        if (((this.method_31() % 2) == 1) && this.isection_0.Document.Settings.bool_11)
        {
            num4 = (margins.Left != -0.05f) ? margins.Left : 0f;
        }
        else
        {
            num4 = (margins.Right != -0.05f) ? margins.Right : 0f;
        }
        num4 = (num4 != -0.05f) ? num4 : 0f;
        float y = Math.Abs((margins.Top != -0.05f) ? margins.Top : 0f);
        float num7 = Math.Abs((margins.Bottom != -0.05f) ? margins.Bottom : 0f);
        float gutter = margins.Gutter;
        if (this.isection_0.Columns.Count > 1)
        {
            clientWidth = (A_0 == null) ? (width - (num3 + num4)) : A_0.Width;
        }
        else
        {
            clientWidth = this.isection_0.PageSetup.ClientWidth;
        }
        RectangleF empty = RectangleF.Empty;
        empty = new RectangleF(num3 + A_1, y, clientWidth, height - (y + num7));
        if (gutter > 0f)
        {
            if (this.pageSetup_0.GutterAtTop)
            {
                return new RectangleF(empty.Left, empty.Top + gutter, empty.Width, empty.Height - gutter);
            }
            if (A_1 == 0f)
            {
                empty = new RectangleF(empty.Left + gutter, empty.Top, empty.Width - gutter, empty.Height);
            }
        }
        return empty;
    }

    protected internal float method_94()
    {
        MarginsF margins = this.pageSetup_0.Margins;
        float height = this.pageSetup_0.PageSize.Height;
        float num4 = Math.Abs((margins.Top != -0.05f) ? margins.Top : 0f);
        float num5 = Math.Abs((margins.Bottom != -0.05f) ? margins.Bottom : 0f);
        float gutter = margins.Gutter;
        float num2 = ((!this.headersFooters_0.IsEmpty || this.headersFooters_0.LinkToPrevious) || (this.pageSetup_0.HeaderDistance >= num4)) ? (((this.method_3().Count <= 0) || (this.method_3().method_4(0).method_69().Height <= 0f)) ? ((((this.method_3().Count <= 0) || (this.method_3().method_4(0).method_69().Height > 0f)) || (this.method_3().method_4(0).method_74().Count != 0)) ? (this.pageSetup_0.OwnerSection.SectPr.HasKey(0x910) ? this.pageSetup_0.HeaderDistance : 0f) : 0f) : (this.pageSetup_0.HeaderDistance + this.method_3().method_4(0).method_69().Height)) : 0f;
        float num3 = ((!this.headersFooters_0.IsEmpty || this.headersFooters_0.LinkToPrevious) || (this.pageSetup_0.FooterDistance >= num5)) ? (((this.method_3().Count <= 1) || (this.method_3().method_4(1).method_69().Height <= 0f)) ? ((((this.method_3().Count <= 1) || (this.method_3().method_4(1).method_69().Height > 0f)) || (this.method_3().method_4(1).method_74().Count != 0)) ? (this.pageSetup_0.OwnerSection.SectPr.HasKey(0x91a) ? this.pageSetup_0.FooterDistance : 0f) : 0f) : (this.pageSetup_0.FooterDistance + this.method_3().method_4(1).method_69().Height)) : 0f;
        return ((height - (Math.Max(num4, num2) + Math.Max(num5, num3))) - (this.pageSetup_0.GutterAtTop ? gutter : 0f));
    }

    protected internal RectangleF method_95(int A_0, ref float A_1, bool A_2, bool A_3)
    {
        int index = this.isection_0.Document.Sections.IndexOf(this.isection_0);
        if (!A_3)
        {
            index--;
        }
        if ((((this.isection_0.Document.Sections.Count - 1) > index) && (A_0 == 0)) && !A_2)
        {
            this.isection_0 = this.isection_0.Document.Sections[index + 1];
        }
        Column column = (this.isection_0.Columns.Count > A_0) ? this.isection_0.Columns[A_0] : null;
        RectangleF ef = this.method_93(column, A_1);
        if (column != null)
        {
            A_1 += column.Width + column.Space;
        }
        return ef;
    }

    internal void method_96()
    {
        if ((this.class376_0 != null) && (this.class376_0.Count > 0))
        {
            this.class376_0.method_10();
        }
    }

    void IDisposable.Dispose()
    {
        this.headersFooters_0 = null;
        this.isection_0 = null;
        this.int_0 = 0;
        this.color_0 = Color.Empty;
        if (this.class376_0 != null)
        {
            this.class376_0.Clear();
            this.class376_0 = null;
        }
        if (this.class376_1 != null)
        {
            this.class376_1.Clear();
            this.class376_1 = null;
        }
        if (this.class376_2 != null)
        {
            this.class376_2.Clear();
            this.class376_2 = null;
        }
        if (this.pageSetup_0 != null)
        {
            this.pageSetup_0 = null;
        }
        if (this.image_0 != null)
        {
            this.image_0.Dispose();
            this.image_0 = null;
        }
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.list_3 != null)
        {
            this.list_3.Clear();
            this.list_3 = null;
        }
        this.method_35(this.method_25());
        this.method_35(this.method_26());
        this.method_35(this.method_27());
        this.method_36();
    }
}

