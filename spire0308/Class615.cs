using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Drawing;

internal abstract class Class615
{
    protected bool bool_0;
    private bool bool_1;
    private bool bool_2;
    protected bool bool_3;
    internal static bool bool_4;
    protected bool bool_5;
    protected Class196 class196_0;
    protected Class375 class375_0;
    protected Class774 class774_0;
    protected Interface1 interface1_0;
    protected Interface1 interface1_1;
    protected Interface30 interface30_0;
    protected LayoutState layoutState_0;

    public Class615(Interface1 A_0, Interface30 A_1)
    {
        this.interface1_1 = A_0;
        this.interface1_0 = A_0;
        this.interface30_0 = A_1;
    }

    public Interface1 method_0()
    {
        return this.interface1_0;
    }

    public LayoutState method_1()
    {
        return this.layoutState_0;
    }

    internal bool method_10()
    {
        return this.bool_1;
    }

    internal void method_11(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal bool method_12()
    {
        return this.bool_2;
    }

    internal void method_13(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal Interface30 method_14()
    {
        return this.interface30_0;
    }

    public bool method_15()
    {
        return ((this.method_1() == LayoutState.Splitted) && (this.method_0() != null));
    }

    protected void method_16(RectangleF A_0)
    {
        if (this.bool_0)
        {
            this.class774_0 = new Class774(A_0);
        }
        else
        {
            this.class774_0 = new Class774(A_0, this.method_2(), this.interface1_1);
        }
    }

    protected void method_17(RectangleF A_0, bool A_1)
    {
        if (this.bool_0)
        {
            this.class774_0 = new Class774(A_0, A_1);
        }
        else
        {
            this.class774_0 = new Class774(A_0, this.method_2(), this.interface1_1, A_1);
        }
    }

    protected void method_18(RectangleF A_0, Paddings A_1)
    {
        this.method_2().imethod_0().method_1((double) A_1.Left);
        this.method_2().imethod_0().method_9((double) A_1.Right);
        this.method_2().imethod_0().method_5((double) A_1.Top);
        this.method_2().imethod_0().method_13((double) A_1.Bottom);
        this.class774_0 = new Class774(A_0, this.method_2(), this.interface1_1);
    }

    protected void method_19(RectangleF A_0)
    {
        this.class774_0 = new Class774(A_0, this.method_2());
    }

    public Interface23 method_2()
    {
        return this.interface1_1.imethod_0();
    }

    protected void method_20(RectangleF A_0, RectangleF A_1)
    {
        this.class774_0 = new Class774(A_0, A_1, this.method_2());
    }

    protected void method_21(PointF A_0, bool A_1)
    {
        if ((this.class375_0 == null) || ((this.class375_0 != null) && (this.class375_0.method_74().Count == 0)))
        {
            this.class375_0 = new Class375(this.interface1_1);
        }
        RectangleF ef = this.class375_0.method_69();
        A_0.X += (float) this.method_2().imethod_1().method_0();
        if (A_1)
        {
            if (this.method_2().imethod_42() != double.MinValue)
            {
                this.method_2().imethod_1().method_5(this.method_2().imethod_42());
            }
            A_0.Y += (float) this.method_2().imethod_1().method_4();
        }
        else
        {
            this.method_2().imethod_43(this.method_2().imethod_1().method_4());
            this.method_2().imethod_1().method_5(0.0);
        }
        ef.Location = A_0;
        this.class375_0.method_70(ef);
    }

    protected void method_22(PointF A_0)
    {
        this.class375_0 = new Class375(this.interface1_1);
        RectangleF ef = this.class375_0.method_69();
        A_0.X += (float) this.method_2().imethod_1().method_0();
        A_0.Y += (float) this.method_2().imethod_1().method_4();
        ef.Location = A_0;
        this.class375_0.method_70(ef);
    }

    internal RectangleF method_23(DocumentObject A_0, RectangleF A_1)
    {
        Paragraph paragraph = null;
        if (A_0 is Paragraph)
        {
            paragraph = A_0 as Paragraph;
        }
        else if (A_0 is Table)
        {
            paragraph = (A_0 as Table).Rows[0].Cells[0].Paragraphs[0];
        }
        if (paragraph == null)
        {
            return new RectangleF();
        }
        ParagraphFormat format = paragraph.Format;
        Section section = this.method_26(paragraph) as Section;
        float x = A_1.X;
        float y = A_1.Y;
        float width = A_1.Width;
        if (format.FrameWidth != 0)
        {
            width = format.FrameWidthEx;
        }
        float height = A_1.Height;
        if (section != null)
        {
            x = this.method_27(format, section, A_1, width);
            y = this.method_28(format, section, A_1, height);
        }
        if ((x < A_1.X) && (format.FrameWidthRule != FrameSizeRule.Exact))
        {
            width = A_1.Width + (A_1.X - x);
        }
        if (y < A_1.Y)
        {
            height = A_1.Height + (A_1.Y - y);
        }
        A_1 = new RectangleF(x, y, width, height);
        if (((Math.Round((double) (this.interface30_0 as Class304).method_6().Width, 2) == Math.Round((double) A_1.Width, 2)) && (Math.Round((double) (this.interface30_0 as Class304).method_6().Bottom, 2) == Math.Round((double) A_1.Bottom, 2))) && ((Math.Round((double) (this.interface30_0 as Class304).method_6().X, 2) == Math.Round((double) A_1.X, 2)) && this.method_25(paragraph)))
        {
            return (this.interface30_0 as Class304).method_6();
        }
        (this.interface30_0 as Class304).method_7(A_1);
        this.method_4().method_131(new Class376());
        if (!(this.interface30_0 as Class304).method_8().Equals(A_1.Location))
        {
            (this.interface30_0 as Class304).method_9(A_1.Location);
        }
        return A_1;
    }

    internal RectangleF method_24(Paragraph A_0, RectangleF A_1)
    {
        ParagraphFormat format = A_0.Format;
        Section section = this.method_26(A_0) as Section;
        float x = A_1.X;
        float y = A_1.Y;
        float width = A_1.Width;
        if (format.FrameWidth != 0)
        {
            width = format.FrameWidthEx;
        }
        float height = A_1.Height;
        if (format.FrameHeight != 0)
        {
            ushort frameHeight = (ushort) format.FrameHeight;
            if ((frameHeight & 0x8000) == 0)
            {
                height = ((float) (frameHeight & 0x7fff)) / 20f;
            }
        }
        if (section != null)
        {
            x = this.method_27(format, section, A_1, width);
            y = this.method_28(format, section, A_1, height);
        }
        return new RectangleF(x, y, width, height);
    }

    private bool method_25(Paragraph A_0)
    {
        if (A_0 != null)
        {
            IDocumentObject previousSibling = null;
            if (A_0.IsInCell)
            {
                previousSibling = A_0.Owner.Owner.Owner.PreviousSibling;
            }
            else
            {
                previousSibling = A_0.PreviousSibling;
            }
            if (previousSibling is Paragraph)
            {
                return ((A_0.Format.FrameY == (previousSibling as Paragraph).Format.FrameY) && (A_0.Format.FrameX == (previousSibling as Paragraph).Format.FrameX));
            }
            if (previousSibling is Table)
            {
                return ((A_0.Format.FrameY == (previousSibling as Table).Rows[0].Cells[0].Paragraphs[0].Format.FrameY) && (A_0.Format.FrameX == (previousSibling as Table).Rows[0].Cells[0].Paragraphs[0].Format.FrameX));
            }
        }
        return false;
    }

    private DocumentObject method_26(DocumentObject A_0)
    {
        DocumentObject owner = A_0;
        while (!(owner is Section))
        {
            if (((owner is Table) && (owner as Table).IsTextBox) && ((owner as Table).TextBoxFormat.OwnerBase is TextBox))
            {
                owner = (owner as Table).TextBoxFormat.OwnerBase as DocumentObject;
            }
            if (owner.Owner == null)
            {
                return owner;
            }
            owner = owner.Owner;
        }
        return owner;
    }

    private float method_27(ParagraphFormat A_0, Section A_1, RectangleF A_2, float A_3)
    {
        float num = 0f;
        switch (A_0.FrameX)
        {
            case -8:
            case -16:
                switch (A_0.FrameHorizontalPos)
                {
                    case 0:
                        return (this.interface30_0 as Class304).method_4().Width;

                    case 1:
                        return (A_1.PageSetup.PageSize.Width - A_1.PageSetup.Margins.Right);

                    case 2:
                        return A_1.PageSetup.PageSize.Width;
                }
                return num;

            case -4:
                switch (A_0.FrameHorizontalPos)
                {
                    case 0:
                        return ((this.interface30_0 as Class304).method_4().Left + (((this.interface30_0 as Class304).method_4().Width - A_0.FrameWidthEx) / 2f));

                    case 1:
                        return (A_1.PageSetup.Margins.Left + ((((A_1.PageSetup.PageSize.Width - A_1.PageSetup.Margins.Right) - A_1.PageSetup.Margins.Left) - A_0.FrameWidthEx) / 2f));

                    case 2:
                        return ((A_1.PageSetup.PageSize.Width - A_0.FrameWidthEx) / 2f);
                }
                return num;

            case 0:
            case -12:
                switch (A_0.FrameHorizontalPos)
                {
                    case 0:
                        return (this.interface30_0 as Class304).method_4().X;

                    case 1:
                        return A_1.PageSetup.Margins.Left;

                    case 2:
                        return 0f;
                }
                return num;
        }
        num = ((float) A_0.FrameX) / 20f;
        switch (A_0.FrameHorizontalPos)
        {
            case 0:
                return (num + (this.interface30_0 as Class304).method_4().X);

            case 1:
                return (num + A_1.PageSetup.Margins.Left);
        }
        return num;
    }

    private float method_28(ParagraphFormat A_0, Section A_1, RectangleF A_2, float A_3)
    {
        float num = 0f;
        float top = A_1.PageSetup.Margins.Top;
        float bottom = A_1.PageSetup.Margins.Bottom;
        float num4 = (A_1.PageSetup.PageSize.Height - top) - bottom;
        float y = A_2.Y;
        Paragraph ownerBase = A_0.OwnerBase as Paragraph;
        Paragraph previousSibling = ownerBase.PreviousSibling as Paragraph;
        if ((((previousSibling != null) && previousSibling.Format.IsFrame) && ((previousSibling.Format.FrameWrapType == FrameTextWrap.NotBeside) && (A_0.FrameWrapType == FrameTextWrap.NotBeside))) && (previousSibling.Format.FrameVerticalDistanceFromTextEx != 0f))
        {
            y = this.class375_0.method_69().Bottom;
        }
        switch (A_0.FrameY)
        {
            case -12:
            case -20:
                switch (A_0.FrameVerticalPos)
                {
                    case 0:
                        return (top + num4);

                    case 1:
                        return A_1.PageSetup.PageSize.Height;
                }
                return num;

            case -8:
                switch (A_0.FrameVerticalPos)
                {
                    case 0:
                        return (top + (num4 / 2f));

                    case 1:
                        return (A_1.PageSetup.PageSize.Height / 2f);
                }
                return num;

            case -4:
            case -16:
                switch (A_0.FrameVerticalPos)
                {
                    case 0:
                        return top;

                    case 1:
                        return 0f;

                    case 2:
                        return (y + (((float) A_0.FrameYEx) / 20f));
                }
                return num;
        }
        switch (A_0.FrameVerticalPos)
        {
            case 0:
                return (top + (((float) A_0.FrameYEx) / 20f));

            case 1:
                return (((float) A_0.FrameYEx) / 20f);

            case 2:
                return (y + (((float) A_0.FrameYEx) / 20f));
        }
        return (((float) A_0.FrameYEx) / 20f);
    }

    public Class774 method_3()
    {
        return this.class774_0;
    }

    public Class196 method_4()
    {
        if (!this.bool_5)
        {
            return this.interface30_0.imethod_0();
        }
        return this.class196_0;
    }

    internal Class375 method_5()
    {
        return this.class375_0;
    }

    public double method_6()
    {
        return (this.interface1_1.imethod_0().imethod_0().method_8() + this.interface1_1.imethod_0().imethod_1().method_8());
    }

    public double method_7()
    {
        return this.interface1_1.imethod_0().imethod_1().method_12();
    }

    public Interface1 method_8()
    {
        return this.interface1_1;
    }

    public bool method_9()
    {
        return this.bool_3;
    }

    public static Class615 smethod_0(Interface1 A_0, Interface30 A_1, float A_2)
    {
        int num = 13;
        Interface3 interface2 = A_0 as Interface3;
        if (interface2 != null)
        {
            if (interface2.imethod_0().imethod_22())
            {
                return new Class617(interface2, A_1);
            }
            return new Class616(interface2, A_1);
        }
        Interface2 interface4 = A_0 as Interface2;
        if ((A_0 is Field) && ((A_0 as Field).Type == FieldType.FieldSymbol))
        {
            interface4 = (A_0 as Field).method_46();
        }
        if ((interface4 != null) && !(interface4 is TextBox))
        {
            return new Class619(interface4, A_1);
        }
        Interface4 interface3 = null;
        if (A_0 is Interface4)
        {
            interface3 = A_0 as Interface4;
        }
        else if (A_0 is TextBox)
        {
            interface3 = (A_0 as TextBox).method_78(A_1);
        }
        if (interface3 != null)
        {
            return new Class618(interface3, A_1);
        }
        Class820 class2 = A_0 as Class820;
        if (class2 == null)
        {
            throw new ArgumentException(BookmarkStart.b("稲嬴䄶堸场吼嬾慀㑂ⱄ⍆⹈⹊㥌潎═⩒╔㉖捘筚", num) + A_0.GetType());
        }
        return new Class618(class2, A_1);
    }

    public static Class615 smethod_1(Interface1 A_0, Interface30 A_1, float A_2, bool A_3)
    {
        int num = 15;
        Interface2 interface2 = A_0 as Interface2;
        if (((A_0 is ShapeObject) && !(A_0 is DocPicture)) && !(A_0 is TextBox))
        {
            interface2 = (A_0 as ShapeObject).method_63(A_3);
        }
        if (A_0 is Class6)
        {
            interface2 = (A_0 as Class6).method_51(A_3);
        }
        if (interface2 == null)
        {
            throw new ArgumentException(BookmarkStart.b("簴夶伸娺儼嘾╀捂㉄⹆ⵈⱊ⡌㭎煐❒ⱔ❖㱘慚絜", num) + A_0.GetType());
        }
        return new Class619(interface2, A_1);
    }

    public abstract Class375 vmethod_0(RectangleF A_0);
    protected virtual void vmethod_1()
    {
    }
}

