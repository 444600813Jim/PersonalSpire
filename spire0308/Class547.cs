using Spire.Doc.Documents;
using System;

internal class Class547
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2 = true;
    private bool bool_3 = true;
    private Class776 class776_0 = new Class776();
    private int int_0 = 0x63;
    private int int_1 = 0x10b;

    internal Class547 method_0()
    {
        Class547 class2 = (Class547) base.MemberwiseClone();
        class2.class776_0 = this.class776_0.method_0();
        return class2;
    }

    internal bool method_1(Class66 A_0)
    {
        return ((((A_0.method_3() == this.method_2()) && (A_0.method_5() == this.method_4())) && ((A_0.method_7() == this.method_6()) && (A_0.method_9() == this.method_8()))) && (A_0.method_11() == this.method_10()));
    }

    internal bool method_10()
    {
        return this.bool_3;
    }

    internal void method_11(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal int method_12()
    {
        return this.int_1;
    }

    internal void method_13(int A_0)
    {
        this.int_1 = A_0;
    }

    internal Class776 method_14()
    {
        return this.class776_0;
    }

    internal void method_15()
    {
        this.int_0 = 0;
        this.bool_2 = false;
        this.bool_3 = false;
        this.class776_0.method_2();
        this.method_18(StyleIdentifier.Normal, 0, false, false, true);
        this.method_18(StyleIdentifier.Heading1, 0, false, false, true);
        this.method_18(StyleIdentifier.Heading2, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading3, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading4, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading5, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading6, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading7, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading8, 0, true, true, true);
        this.method_18(StyleIdentifier.Heading9, 0, true, true, true);
        this.method_18(StyleIdentifier.Caption, 0, true, true, true);
        this.method_18(StyleIdentifier.Title, 0, false, false, true);
        this.method_18(StyleIdentifier.Subtitle, 0, false, false, true);
        this.method_18(StyleIdentifier.Strong, 0, false, false, true);
        this.method_18(StyleIdentifier.Emphasis, 0, false, false, true);
        this.method_17();
    }

    internal void method_16()
    {
        this.class776_0.method_2();
        this.method_18(StyleIdentifier.Normal, 0, false, false, true);
        this.method_18(StyleIdentifier.Heading1, 9, false, false, true);
        this.method_18(StyleIdentifier.Heading2, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading3, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading4, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading5, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading6, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading7, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading8, 9, true, true, true);
        this.method_18(StyleIdentifier.Heading9, 9, true, true, true);
        this.method_18(StyleIdentifier.Toc1, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc2, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc3, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc4, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc5, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc6, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc7, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc8, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Toc9, 0x27, true, true, false);
        this.method_18(StyleIdentifier.Caption, 0x23, true, true, true);
        this.method_18(StyleIdentifier.Title, 10, false, false, true);
        this.method_18(StyleIdentifier.DefaultParagraphFont, 1, true, true, false);
        this.method_18(StyleIdentifier.Subtitle, 11, false, false, true);
        this.method_18(StyleIdentifier.Strong, 0x16, false, false, true);
        this.method_18(StyleIdentifier.Emphasis, 20, false, false, true);
        this.method_18(StyleIdentifier.TableGrid, 0x3b, false, false, false);
        this.method_17();
    }

    private void method_17()
    {
        this.method_18(StyleIdentifier.PlaceholderText, 0x63, true, false, false);
        this.method_18(StyleIdentifier.NoSpacing, 1, false, false, true);
        this.method_18(StyleIdentifier.LightShading, 60, false, false, false);
        this.method_18(StyleIdentifier.LightList, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGrid, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1, 0x41, false, false, false);
        this.method_18(StyleIdentifier.MediumList2, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkList, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShading, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulList, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGrid, 0x49, false, false, false);
        this.method_18(StyleIdentifier.LightShadingAccent1, 60, false, false, false);
        this.method_18(StyleIdentifier.LightListAccent1, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGridAccent1, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1Accent1, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2Accent1, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1Accent1, 0x41, false, false, false);
        this.method_18(StyleIdentifier.Revision, 0x63, true, false, false);
        this.method_18(StyleIdentifier.ListParagraph, 0x22, false, false, true);
        this.method_18(StyleIdentifier.Quote, 0x1d, false, false, true);
        this.method_18(StyleIdentifier.IntenseQuote, 30, false, false, true);
        this.method_18(StyleIdentifier.MediumList2Accent1, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1Accent1, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2Accent1, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3Accent1, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkListAccent1, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShadingAccent1, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulListAccent1, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGridAccent1, 0x49, false, false, false);
        this.method_18(StyleIdentifier.LightShadingAccent2, 60, false, false, false);
        this.method_18(StyleIdentifier.LightListAccent2, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGridAccent2, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1Accent2, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2Accent2, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1Accent2, 0x41, false, false, false);
        this.method_18(StyleIdentifier.MediumList2Accent2, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1Accent2, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2Accent2, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3Accent2, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkListAccent2, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShadingAccent2, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulListAccent2, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGridAccent2, 0x49, false, false, false);
        this.method_18(StyleIdentifier.LightShadingAccent3, 60, false, false, false);
        this.method_18(StyleIdentifier.LightListAccent3, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGridAccent3, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1Accent3, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2Accent3, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1Accent3, 0x41, false, false, false);
        this.method_18(StyleIdentifier.MediumList2Accent3, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1Accent3, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2Accent3, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3Accent3, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkListAccent3, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShadingAccent3, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulListAccent3, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGridAccent3, 0x49, false, false, false);
        this.method_18(StyleIdentifier.LightShadingAccent4, 60, false, false, false);
        this.method_18(StyleIdentifier.LightListAccent4, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGridAccent4, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1Accent4, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2Accent4, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1Accent4, 0x41, false, false, false);
        this.method_18(StyleIdentifier.MediumList2Accent4, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1Accent4, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2Accent4, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3Accent4, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkListAccent4, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShadingAccent4, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulListAccent4, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGridAccent4, 0x49, false, false, false);
        this.method_18(StyleIdentifier.LightShadingAccent5, 60, false, false, false);
        this.method_18(StyleIdentifier.LightListAccent5, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGridAccent5, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1Accent5, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2Accent5, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1Accent5, 0x41, false, false, false);
        this.method_18(StyleIdentifier.MediumList2Accent5, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1Accent5, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2Accent5, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3Accent5, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkListAccent5, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShadingAccent5, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulListAccent5, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGridAccent5, 0x49, false, false, false);
        this.method_18(StyleIdentifier.LightShadingAccent6, 60, false, false, false);
        this.method_18(StyleIdentifier.LightListAccent6, 0x3d, false, false, false);
        this.method_18(StyleIdentifier.LightGridAccent6, 0x3e, false, false, false);
        this.method_18(StyleIdentifier.MediumShading1Accent6, 0x3f, false, false, false);
        this.method_18(StyleIdentifier.MediumShading2Accent6, 0x40, false, false, false);
        this.method_18(StyleIdentifier.MediumList1Accent6, 0x41, false, false, false);
        this.method_18(StyleIdentifier.MediumList2Accent6, 0x42, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid1Accent6, 0x43, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid2Accent6, 0x44, false, false, false);
        this.method_18(StyleIdentifier.MediumGrid3Accent6, 0x45, false, false, false);
        this.method_18(StyleIdentifier.DarkListAccent6, 70, false, false, false);
        this.method_18(StyleIdentifier.ColorfulShadingAccent6, 0x47, false, false, false);
        this.method_18(StyleIdentifier.ColorfulListAccent6, 0x48, false, false, false);
        this.method_18(StyleIdentifier.ColorfulGridAccent6, 0x49, false, false, false);
        this.method_18(StyleIdentifier.SubtleEmphasis, 0x13, false, false, true);
        this.method_18(StyleIdentifier.IntenseEmphasis, 0x15, false, false, true);
        this.method_18(StyleIdentifier.SubtleReference, 0x1f, false, false, true);
        this.method_18(StyleIdentifier.IntenseReference, 0x20, false, false, true);
        this.method_18(StyleIdentifier.BookTitle, 0x21, false, false, true);
        this.method_18(StyleIdentifier.Bibliography, 0x25, true, true, false);
        this.method_18(StyleIdentifier.TocHeading, 0x27, true, true, true);
    }

    private void method_18(StyleIdentifier A_0, int A_1, bool A_2, bool A_3, bool A_4)
    {
        this.class776_0.method_1(new Class66(A_0, false, A_4, A_2, A_1, A_3));
    }

    internal bool method_2()
    {
        return this.bool_0;
    }

    internal void method_3(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal bool method_4()
    {
        return this.bool_1;
    }

    internal void method_5(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal bool method_6()
    {
        return this.bool_2;
    }

    internal void method_7(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal int method_8()
    {
        return this.int_0;
    }

    internal void method_9(int A_0)
    {
        this.int_0 = A_0;
    }
}

