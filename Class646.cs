using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class646
{
    private bool bool_0;
    private bool bool_1;
    private readonly ParagraphFormat paragraphFormat_0;

    private Class646(ParagraphFormat A_0)
    {
        this.paragraphFormat_0 = A_0;
    }

    private void method_0(int A_0, int A_1, int A_2)
    {
        object obj2 = this.paragraphFormat_0.method_31(A_0);
        if (obj2 != null)
        {
            int propKey = this.method_2() ? A_2 : A_1;
            this.paragraphFormat_0.SetAttr(propKey, obj2);
            this.paragraphFormat_0.Remove(A_0);
        }
    }

    private void method_1()
    {
        object right = this.paragraphFormat_0.HasKey(0x64a) ? this.paragraphFormat_0.method_31(0x64a) : null;
        if ((right == null) || (this.paragraphFormat_0.HasKey(0x3fc) && ((this.paragraphFormat_0.HorizontalAlignment == HorizontalAlignment.Left) || (this.paragraphFormat_0.HorizontalAlignment == HorizontalAlignment.Right))))
        {
            return;
        }
        if (this.method_2())
        {
            switch (((HorizontalAlignment) right))
            {
                case HorizontalAlignment.Left:
                    right = HorizontalAlignment.Right;
                    goto Label_009A;

                case HorizontalAlignment.Right:
                    right = HorizontalAlignment.Left;
                    goto Label_009A;
            }
            right = (HorizontalAlignment) right;
        }
    Label_009A:
        this.paragraphFormat_0.SetAttr(0x3fc, right);
        this.paragraphFormat_0.Remove(0x64a);
    }

    private bool method_2()
    {
        if (!this.bool_0)
        {
            this.bool_1 = (bool) this.paragraphFormat_0.method_32(0x618);
            this.bool_0 = true;
        }
        return this.bool_1;
    }

    internal static void smethod_0(StyleCollection A_0, bool A_1)
    {
        foreach (Style style in A_0)
        {
            if (style.StyleType == StyleType.ParagraphStyle)
            {
                smethod_1(style.ParaPr);
            }
        }
    }

    internal static void smethod_1(ParagraphFormat A_0)
    {
        Class646 class2 = new Class646(A_0);
        class2.method_0(0x654, 0x488, 0x47e);
        class2.method_0(0x65e, 0x47e, 0x488);
        class2.method_0(0x668, 0x492, 0x492);
        class2.method_1();
    }

    internal static void smethod_2(RowFormat A_0)
    {
        object right = A_0.method_31(0x13ed);
        if (right == null)
        {
            return;
        }
        if (A_0.method_31(0xfaa) != null)
        {
            goto Label_0069;
        }
        if (A_0.Bidi)
        {
            switch (((RowAlignment) right))
            {
                case RowAlignment.Left:
                    right = RowAlignment.Right;
                    goto Label_005D;

                case RowAlignment.Right:
                    right = RowAlignment.Left;
                    goto Label_005D;
            }
            right = (RowAlignment) right;
        }
    Label_005D:
        A_0.SetAttr(0xfaa, right);
    Label_0069:
        A_0.Remove(0x13ed);
    }
}

