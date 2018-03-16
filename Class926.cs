using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

internal class Class926
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_13;
    private bool bool_14;
    private bool bool_15;
    private bool bool_16;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6 = true;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private const char char_0 = '\x00ab';
    private const char char_1 = '\x00bb';
    private const char char_2 = '\x001e';
    private const char char_3 = '\x001f';
    private Class204 class204_0 = new Class204();
    private Dictionary<int, Footnote> dictionary_0;
    private Dictionary<int, Footnote> dictionary_1;
    private Dictionary<string, Dictionary<int, int>> dictionary_2;
    private Dictionary<string, string> dictionary_3;
    private Dictionary<string, Stream> dictionary_4;
    private Dictionary<string, string> dictionary_5;
    private static Dictionary<ImageFormat, string> dictionary_6 = null;
    private Dictionary<Comment, string> dictionary_7 = new Dictionary<Comment, string>();
    private Dictionary<int, string[]> dictionary_8 = new Dictionary<int, string[]>();
    private Document document_0;
    private int int_0;
    private int int_1;
    private int int_2 = -1;
    private int int_3;
    private int int_4;
    private int int_5 = -1;
    private List<int> list_0 = new List<int>();
    private List<string> list_1 = new List<string>();
    private MemoryStream memoryStream_0;
    private static object object_0 = new object();
    private Paragraph paragraph_0;
    private ParagraphStyle paragraphStyle_0;
    private Regex regex_0;
    private Stack<bool> stack_0 = new Stack<bool>();
    private const string string_0 = "-";
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string[] string_8;
    private XmlTextWriter xmlTextWriter_0;

    public bool method_0()
    {
        return this.bool_4;
    }

    public void method_1(bool A_0)
    {
        this.bool_4 = Convert.ToBoolean(A_0);
    }

    internal void method_10(bool A_0)
    {
        this.bool_13 = A_0;
    }

    private int method_100(List<float> A_0, float A_1, float A_2)
    {
        int index = A_0.IndexOf(A_1);
        if ((index < 0) && (A_1 > 0f))
        {
            throw new InvalidOperationException();
        }
        int num2 = 1;
        float num3 = A_1 + A_2;
        if (A_0.Count > (index + 1))
        {
            while ((num3 - A_0[index + num2]) > 0.01f)
            {
                num2++;
            }
        }
        return num2;
    }

    private int method_101(TableCell A_0)
    {
        int num = 1;
        int num2 = A_0.method_5();
        TableRow ownerRow = A_0.OwnerRow;
        int num3 = num2 + 1;
        int count = ownerRow.Cells.Count;
        while (num3 < count)
        {
            if (ownerRow.Cells[num3].CellFormat.HorizontalMerge == CellMerge.Continue)
            {
                num++;
            }
            num3++;
        }
        return num;
    }

    private float method_102(TableCell A_0)
    {
        TableRow ownerRow = A_0.OwnerRow;
        int index = ownerRow.Cells.IndexOf(A_0);
        float width = A_0.Width;
        for (int i = index + 1; i < ownerRow.Cells.Count; i++)
        {
            if (ownerRow.Cells[i].CellFormat.HorizontalMerge != CellMerge.Continue)
            {
                break;
            }
            width += ownerRow.Cells[i].Width;
        }
        if ((width > 0f) && (A_0.WidthType != FtsWidth.Percentage))
        {
            width = Class1073.smethod_1().method_2(width, PrintUnits.Point);
        }
        return width;
    }

    private void method_103(Table A_0)
    {
        int num = 14;
        string str = string.Empty;
        if (A_0.TableFormat.HorizontalAlignment != RowAlignment.Left)
        {
            if (A_0.TableFormat.WrapTextAround && (A_0.TableFormat.HorizontalAlignment == RowAlignment.Right))
            {
                str = str + BookmarkStart.b("刳娵圷嬹䠻н㈿⭁⍃⹅㱇煉", num);
            }
            else if (A_0.TableFormat.HorizontalAlignment == RowAlignment.Center)
            {
                str = str + BookmarkStart.b("夳圵䨷崹唻倽洿⹁⅃⁅㱇灉汋⽍╏♑㭓浕硗㝙㵛ⱝݟୡ੣䭥ᩧͩ୫٭ѯ䡱味᝵൷๹፻䕽ꁿ", num);
            }
        }
        else if (A_0.IsTextBox)
        {
            str = str + BookmarkStart.b("䐳夵䬷匹䠻圽⼿ⱁ繃❅⩇㥉⍋≍╏♑ㅓ浕硗", num) + string.Format(BookmarkStart.b("夳圵䨷崹唻倽洿㙁⭃㙅片橉㝋繍ⵏ≑⁓浕硗㝙㵛ⱝݟୡ੣䭥ѧཀྵ੫ᩭ䩯剱ཱི䝵շ੹ࡻ䕽", num), A_0.TableFormat.Positioning.VertPositionEx, A_0.TableFormat.Positioning.HorizPositionEx);
            if (!A_0.TextBoxFormat.FillColor.IsEmpty)
            {
                str = str + string.Format(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅敇⥉⍋≍㽏⁑湓ⵕ桗❙杛", num), this.method_147(A_0.TextBoxFormat.FillColor));
            }
        }
        else if ((A_0.TableFormat.WrapTextAround && (A_0.TableFormat.HorizontalAlignment == RowAlignment.Left)) && (A_0.TableFormat.Positioning.HorizPositionAbs == HorizontalPosition.Left))
        {
            str = str + BookmarkStart.b("刳娵圷嬹䠻нⰿ❁≃㉅獇", num);
        }
        if (A_0.TableFormat.CellSpacingEx > 0f)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("圳匵吷嘹伻丽ℿ⅁ⵃ⡅⽇", num), XmlConvert.ToString(Class1073.smethod_1().method_2(A_0.TableFormat.CellSpacingEx, PrintUnits.Point)));
        }
        else
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("圳匵吷嘹伻丽ℿ⅁ⵃ⡅⽇", num), BookmarkStart.b("г", num));
        }
        if (A_0.TableFormat.CellSpacingEx <= 0f)
        {
            str = str + BookmarkStart.b("嘳夵䨷帹夻䰽洿⅁⭃⩅⑇⭉㱋㵍㕏桑瑓㕕㝗㙙せ㽝ၟᅡţ嵥䡧", num);
        }
        if (A_0.IndentFromLeft != 0f)
        {
            str = str + BookmarkStart.b("夳圵䨷崹唻倽洿⹁⅃⁅㱇灉汋", num) + Convert.ToString(A_0.IndentFromLeft) + BookmarkStart.b("䐳䈵̷ᨹ", num);
        }
        if (A_0.PreferredWidth != null)
        {
            float num2;
            switch (A_0.PreferredWidth.Type)
            {
                case WidthType.Percentage:
                    num2 = A_0.PreferredWidth.Value;
                    str = str + BookmarkStart.b("䌳張尷丹吻н怿", num) + Convert.ToString(num2) + BookmarkStart.b("ᄳവᠷ", num);
                    break;

                case WidthType.Twip:
                    num2 = ((float) A_0.PreferredWidth.Value) / 20f;
                    str = str + BookmarkStart.b("䌳張尷丹吻н怿", num) + Convert.ToString(num2) + BookmarkStart.b("䐳䈵̷ᨹ", num);
                    break;
            }
        }
        if (str != string.Empty)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜳䈵䄷嘹夻", num), str);
        }
    }

    private void method_104(TableRow A_0)
    {
        int num = 0x13;
        string str = null;
        A_0.Height = Math.Abs(A_0.Height);
        if (A_0.Height > 0f)
        {
            str = XmlConvert.ToString(Class1073.smethod_1().method_2(A_0.Height, PrintUnits.Point)) + BookmarkStart.b("䤸䌺", num);
        }
        else if ((A_0.Cells.Count > 0) && (A_0.Cells[0].Paragraphs.Count > 0))
        {
            str = XmlConvert.ToString(Class1073.smethod_1().method_2(A_0.Cells[0].Paragraphs[0].BreakCharacterFormat.FontSize, PrintUnits.Point)) + BookmarkStart.b("䤸䌺", num);
        }
        else
        {
            str = BookmarkStart.b("ସ䬺䔼", num);
        }
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䨸伺䐼匾⑀", num), BookmarkStart.b("儸帺吼堾⥀㝂罄杆", num) + str);
    }

    private VerticalAlignment method_105(ShapeVerticalAlignment A_0)
    {
        switch (A_0)
        {
            case ShapeVerticalAlignment.Center:
                return VerticalAlignment.Middle;

            case ShapeVerticalAlignment.Bottom:
                return VerticalAlignment.Bottom;
        }
        return VerticalAlignment.Top;
    }

    private RowAlignment method_106(ShapeHorizontalAlignment A_0)
    {
        switch (A_0)
        {
            case ShapeHorizontalAlignment.Center:
                return RowAlignment.Center;

            case ShapeHorizontalAlignment.Right:
                return RowAlignment.Right;
        }
        return RowAlignment.Left;
    }

    private BorderStyle method_107(TextBoxLineStyle A_0)
    {
        switch (A_0)
        {
            case TextBoxLineStyle.Simple:
                return BorderStyle.Single;

            case TextBoxLineStyle.Double:
                return BorderStyle.Double;

            case TextBoxLineStyle.ThickThin:
                return BorderStyle.ThickThinMediumGap;

            case TextBoxLineStyle.ThinThick:
                return BorderStyle.ThinThickMediumGap;

            case TextBoxLineStyle.Triple:
                return BorderStyle.Triple;
        }
        return BorderStyle.None;
    }

    private void method_108()
    {
        int num = 12;
        if (!this.bool_1 && !this.bool_11)
        {
            Directory.CreateDirectory(this.string_3 + this.string_1 + BookmarkStart.b("洱崳嬵夷崹夻䴽᰿", num));
            this.bool_1 = true;
        }
    }

    private string method_109()
    {
        int num = 13;
        this.int_1++;
        if (!this.bool_11)
        {
            return (this.string_1 + BookmarkStart.b("氲尴娶堸尺堼䰾ᵀ", num) + this.string_1 + BookmarkStart.b("氲尴娶常", num) + this.int_1.ToString());
        }
        return (BookmarkStart.b("娲場嘶常帺丼ှ⡀⹂≄", num) + this.int_1.ToString());
    }

    internal Stream method_11()
    {
        return this.memoryStream_0;
    }

    private string method_110(Paddings A_0)
    {
        int num = 12;
        StringBuilder builder = new StringBuilder();
        if (A_0.Left > 0f)
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿⹁⅃⁅㱇灉", num) + XmlConvert.ToString(A_0.Left) + BookmarkStart.b("䈱䀳വ", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿⹁⅃⁅㱇灉籋㹍⑏楑", num));
        }
        if (A_0.Right > 0f)
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿ぁⵃⅅ⁇㹉癋", num) + XmlConvert.ToString(A_0.Right) + BookmarkStart.b("䈱䀳വ", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿ぁⵃⅅ⁇㹉癋繍⁏♑潓", num));
        }
        if (A_0.Top > 0f)
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿㙁⭃㙅片", num) + XmlConvert.ToString(A_0.Top) + BookmarkStart.b("䈱䀳വ", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿㙁⭃㙅片穉㱋㩍歏", num));
        }
        if (A_0.Bottom > 0f)
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿⁁⭃㉅㱇╉⅋瑍", num) + XmlConvert.ToString(A_0.Bottom) + BookmarkStart.b("䈱䀳വ", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䈱唳刵尷匹刻夽洿⁁⭃㉅㱇╉⅋瑍恏≑⁓浕", num));
        }
        return builder.ToString();
    }

    private string method_111(RowFormat A_0, Table A_1)
    {
        int num = 11;
        StringBuilder builder = new StringBuilder();
        if (A_1.IndentFromLeft > 0f)
        {
            builder.Append(BookmarkStart.b("尰刲䜴倶倸唺ြ匾⑀╂ㅄ絆", num) + XmlConvert.ToString(A_1.IndentFromLeft) + BookmarkStart.b("䄰䜲ิ", num));
        }
        if (A_1.TableFormat.CellSpacingEx < 0f)
        {
            builder.Append(BookmarkStart.b("匰尲䜴匶尸䤺ြ尾⹀⽂⥄♆㥈㡊⡌畎煐げ㩔㭖㕘㩚ⵜⱞѠ塢", num));
        }
        if ((A_0.BackColor != Color.Empty) && (A_0.BackColor != Color.White))
        {
            builder.Append(BookmarkStart.b("匰刲嘴尶常䤺刼䨾⽀❂桄⑆♈❊≌㵎歐獒", num) + this.method_147(A_0.BackColor) + BookmarkStart.b("ਰ", num));
        }
        this.method_150(A_0.Borders, builder, true);
        this.method_152(A_0.Borders, A_0.Borders, builder);
        return builder.ToString();
    }

    private string method_112(CellFormat A_0)
    {
        int num = 2;
        TableCell ownerBase = A_0.OwnerBase as TableCell;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("帧伩師娭夯儱唳娵ᔷ嬹倻圽✿ⱁ繃", 2) + A_0.VerticalAlignment.ToString().ToLower() + BookmarkStart.b("ጧ", 2));
        Color empty = Color.Empty;
        if (A_0.TextureStyle != TextureStyle.TextureNone)
        {
            empty = this.method_114(A_0);
            builder.Append(BookmarkStart.b("䨧䬩伫䔭圯䀱嬳䌵嘷帹ᄻ崽⼿⹁⭃㑅片", num) + this.method_147(empty) + BookmarkStart.b("ጧ", num));
        }
        else if (A_0.BackColor != Color.Empty)
        {
            builder.Append(BookmarkStart.b("䨧䬩伫䔭圯䀱嬳䌵嘷帹ᄻ崽⼿⹁⭃㑅片", num) + this.method_147(A_0.BackColor) + BookmarkStart.b("ጧ", num));
            empty = A_0.BackColor;
        }
        if ((empty != Color.Empty) && this.class204_0.method_0(empty))
        {
            builder.Append(BookmarkStart.b("䬧䔩䀫䄭䈯࠱", num) + this.method_147(Color.White) + BookmarkStart.b("ጧ", num));
        }
        this.method_116(ownerBase, builder);
        return builder.ToString();
    }

    private int method_113(int A_0, int A_1, float A_2, bool A_3, bool A_4)
    {
        if (A_0 == 0)
        {
            if (A_1 == 0)
            {
                return (int) Math.Round((double) (255f * (1f - (A_2 / 100f))));
            }
            return (int) Math.Round((double) (A_1 * (1f - (A_2 / 100f))));
        }
        if (A_0 == 0xff)
        {
            if (A_1 == 0xff)
            {
                return A_0;
            }
            if (A_1 == 0)
            {
                return (int) Math.Round((double) (255f * (A_2 / 100f)));
            }
            return ((A_1 + ((int) Math.Round((double) (255f * (A_2 / 100f))))) - ((int) Math.Round((double) (A_1 * (A_2 / 100f)))));
        }
        if (A_1 == 0)
        {
            return (int) Math.Round((double) (A_0 * (A_2 / 100f)));
        }
        return ((A_1 + ((int) Math.Round((double) (A_0 * (A_2 / 100f))))) - ((int) Math.Round((double) (A_1 * (A_2 / 100f)))));
    }

    private Color method_114(CellFormat A_0)
    {
        float num4 = this.method_172(A_0.TextureStyle);
        int num = this.method_113(A_0.ForeColor.R, A_0.BackColor.R, num4, A_0.ForeColor.IsEmpty, A_0.BackColor.IsEmpty);
        int num2 = this.method_113(A_0.ForeColor.G, A_0.BackColor.G, num4, A_0.ForeColor.IsEmpty, A_0.BackColor.IsEmpty);
        int num3 = this.method_113(A_0.ForeColor.B, A_0.BackColor.B, num4, A_0.ForeColor.IsEmpty, A_0.BackColor.IsEmpty);
        return Color.FromArgb(Convert.ToInt32(num), Convert.ToInt32(num2), Convert.ToInt32(num3));
    }

    private void method_115(Borders A_0, Borders A_1, StringBuilder A_2, TableCell A_3)
    {
        int num = 10;
        Border border = this.method_117(A_1, A_3, BookmarkStart.b("䐯崱䐳", 10));
        this.method_118(A_0.Top, border, A_2, BookmarkStart.b("䐯崱䐳", 10));
        border = this.method_117(A_1, A_3, BookmarkStart.b("尯圱刳䈵", 10));
        this.method_118(A_0.Left, border, A_2, BookmarkStart.b("尯圱刳䈵", 10));
        border = this.method_117(A_1, A_3, BookmarkStart.b("䈯嬱匳帵䰷", 10));
        if (A_3.CellFormat.HorizontalMerge == CellMerge.Start)
        {
            this.method_118(this.method_94(A_3), border, A_2, BookmarkStart.b("䈯嬱匳帵䰷", num));
        }
        else
        {
            this.method_118(A_0.Right, border, A_2, BookmarkStart.b("䈯嬱匳帵䰷", num));
        }
        border = this.method_117(A_1, A_3, BookmarkStart.b("刯崱䀳䈵圷圹", num));
        if (A_3.CellFormat.VerticalMerge == CellMerge.Start)
        {
            this.method_118(this.method_93(A_3), border, A_2, BookmarkStart.b("刯崱䀳䈵圷圹", num));
        }
        else
        {
            this.method_118(A_0.Bottom, border, A_2, BookmarkStart.b("刯崱䀳䈵圷圹", num));
        }
    }

    private void method_116(TableCell A_0, StringBuilder A_1)
    {
        int num = 14;
        Borders borders = this.method_120(A_0);
        if ((borders != null) && !borders.NoBorder)
        {
            if (borders.Top.BorderType != BorderStyle.None)
            {
                this.method_119(borders.Top, A_1, BookmarkStart.b("䀳夵䠷", num));
            }
            if (borders.Left.BorderType != BorderStyle.None)
            {
                this.method_119(borders.Left, A_1, BookmarkStart.b("堳匵帷丹", num));
            }
            if (borders.Right.BorderType != BorderStyle.None)
            {
                this.method_119(borders.Right, A_1, BookmarkStart.b("䘳張強刹䠻", num));
            }
            if (borders.Bottom.BorderType != BorderStyle.None)
            {
                this.method_119(borders.Bottom, A_1, BookmarkStart.b("嘳夵䰷丹医匽", num));
            }
        }
    }

    private Border method_117(Borders A_0, TableCell A_1, string A_2)
    {
        int num = 13;
        TableRow ownerRow = null;
        string str = A_2;
        if (str != null)
        {
            if (str == BookmarkStart.b("䜲娴䜶", num))
            {
                ownerRow = A_1.OwnerRow;
                if ((ownerRow != null) && (ownerRow.method_5() > 0))
                {
                    return A_0.Horizontal;
                }
                return A_0.Top;
            }
            if (str == BookmarkStart.b("弲倴儶䴸", num))
            {
                if (A_1.method_5() > 0)
                {
                    return A_0.Vertical;
                }
                return A_0.Left;
            }
            if (str == BookmarkStart.b("䄲尴倶儸伺", num))
            {
                ownerRow = A_1.OwnerRow;
                if ((ownerRow != null) && (A_1.method_5() == (ownerRow.Cells.Count - 1)))
                {
                    return A_0.Right;
                }
                return A_0.Vertical;
            }
            if (str == BookmarkStart.b("儲娴䌶䴸吺值", num))
            {
                ownerRow = A_1.OwnerRow;
                Table ownerTable = ownerRow.OwnerTable;
                if (((A_1 != null) && (ownerTable != null)) && (ownerRow.method_5() == (ownerTable.Rows.Count - 1)))
                {
                    return A_0.Bottom;
                }
                return A_0.Horizontal;
            }
        }
        return null;
    }

    private void method_118(Border A_0, Border A_1, StringBuilder A_2, string A_3)
    {
        int num = 14;
        if ((((!(A_0.OwnerBase is Borders) || !(A_0.OwnerBase.OwnerBase is CellFormat)) || (!(A_0.OwnerBase.OwnerBase.OwnerBase is TableCell) || ((A_0.OwnerBase.OwnerBase.OwnerBase as TableCell).OwnerRow.OwnerTable == null))) || (!(A_0.OwnerBase.OwnerBase.OwnerBase as TableCell).OwnerRow.OwnerTable.IsFrame || (A_0.BorderType != BorderStyle.None))) && (A_0.BorderType != BorderStyle.Cleared))
        {
            BorderStyle style = ((A_0.BorderType == BorderStyle.None) || (A_0.BorderType == BorderStyle.Cleared)) ? A_1.BorderType : A_0.BorderType;
            if ((style != BorderStyle.None) && (style != BorderStyle.Cleared))
            {
                A_2.Append(BookmarkStart.b("嘳夵䨷帹夻䰽洿", num) + A_3 + BookmarkStart.b("ᤳ䔵䰷䌹倻嬽稿", num) + this.method_155(style) + BookmarkStart.b("༳", num));
            }
            Color color = (A_0.Color != Color.Empty) ? A_0.Color : A_1.Color;
            if (color != Color.Empty)
            {
                A_2.Append(BookmarkStart.b("嘳夵䨷帹夻䰽洿", num) + A_3 + BookmarkStart.b("ᤳ唵圷嘹医䰽稿", num) + this.method_147(color) + BookmarkStart.b("༳", num));
            }
            else
            {
                A_2.Append(BookmarkStart.b("嘳夵䨷帹夻䰽洿", num) + A_3 + BookmarkStart.b("ᤳ唵圷嘹医䰽稿慁瑃癅硇穉籋繍歏", num));
            }
            float num2 = (A_0.LineWidth > 0f) ? A_0.LineWidth : A_1.LineWidth;
            if (num2 > 0f)
            {
                if ((style == BorderStyle.Double) && (num2 <= 0.5f))
                {
                    num2 = 1.5f;
                }
                else if ((style == BorderStyle.Double) && (num2 > 0.5f))
                {
                    num2 *= 3f;
                }
                num2 /= 0.75f;
                A_2.Append(BookmarkStart.b("嘳夵䨷帹夻䰽洿", num) + A_3 + BookmarkStart.b("ᤳ䄵儷帹䠻嘽稿", num) + XmlConvert.ToString(Math.Round((double) num2, 2)) + BookmarkStart.b("䐳丵̷", num));
            }
            else if ((num2 == 0f) && !A_0.HasNoneStyle)
            {
                A_2.Append(BookmarkStart.b("嘳夵䨷帹夻䰽洿", num) + A_3 + BookmarkStart.b("ᤳ䄵儷帹䠻嘽稿", num) + XmlConvert.ToString(Math.Round((double) 0.66666666666666663, 2)) + BookmarkStart.b("䐳丵̷", num));
            }
            else if ((num2 < 0f) && !A_0.HasNoneStyle)
            {
                A_2.Append(BookmarkStart.b("嘳夵䨷帹夻䰽洿", num) + A_3 + BookmarkStart.b("ᤳ䄵儷帹䠻嘽稿", num) + XmlConvert.ToString(Math.Round((double) (((double) num2) / 0.75), 2)) + BookmarkStart.b("䐳丵̷", num));
            }
        }
    }

    private void method_119(Border A_0, StringBuilder A_1, string A_2)
    {
        int num = 2;
        if ((((!(A_0.OwnerBase is Borders) || !(A_0.OwnerBase.OwnerBase is CellFormat)) || (!(A_0.OwnerBase.OwnerBase.OwnerBase is TableCell) || ((A_0.OwnerBase.OwnerBase.OwnerBase as TableCell).OwnerRow.OwnerTable == null))) || (!(A_0.OwnerBase.OwnerBase.OwnerBase as TableCell).OwnerRow.OwnerTable.IsFrame || (A_0.BorderType != BorderStyle.None))) && (A_0.BorderType != BorderStyle.Cleared))
        {
            BorderStyle style = ((A_0.BorderType == BorderStyle.None) || (A_0.BorderType == BorderStyle.Cleared)) ? BorderStyle.None : A_0.BorderType;
            if ((style != BorderStyle.None) && (style != BorderStyle.Cleared))
            {
                A_1.Append(BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ", num) + A_2 + BookmarkStart.b("ԧ天堫圭尯圱ำ", num) + this.method_155(style) + BookmarkStart.b("ጧ", num));
            }
            Color color = (A_0.Color != Color.Empty) ? A_0.Color : Color.Empty;
            if (color != Color.Empty)
            {
                A_1.Append(BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ", num) + A_2 + BookmarkStart.b("ԧ䤩䌫䈭弯䀱ำ", num) + this.method_147(color) + BookmarkStart.b("ጧ", num));
            }
            else
            {
                A_1.Append(BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ", num) + A_2 + BookmarkStart.b("ԧ䤩䌫䈭弯䀱ำᔵ࠷ਹ఻฽瀿牁罃", num));
            }
            float num2 = (A_0.LineWidth > 0f) ? A_0.LineWidth : 0f;
            if (num2 > 0f)
            {
                if ((style == BorderStyle.Double) && (num2 <= 0.5f))
                {
                    num2 = 1.5f;
                }
                else if ((style == BorderStyle.Double) && (num2 > 0.5f))
                {
                    num2 *= 3f;
                }
                num2 /= 0.75f;
                A_1.Append(BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ", num) + A_2 + BookmarkStart.b("ԧ崩䔫䨭䐯娱ำ", num) + XmlConvert.ToString(Math.Round((double) num2, 2)) + BookmarkStart.b("堧利ᜫ", num));
            }
            else if ((num2 == 0f) && !A_0.HasNoneStyle)
            {
                A_1.Append(BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ", num) + A_2 + BookmarkStart.b("ԧ崩䔫䨭䐯娱ำ", num) + XmlConvert.ToString(Math.Round((double) 0.66666666666666663, 2)) + BookmarkStart.b("堧利ᜫ", num));
            }
            else if ((num2 < 0f) && !A_0.HasNoneStyle)
            {
                A_1.Append(BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ", num) + A_2 + BookmarkStart.b("ԧ崩䔫䨭䐯娱ำ", num) + XmlConvert.ToString(Math.Round((double) (((double) num2) / 0.75), 2)) + BookmarkStart.b("堧利ᜫ", num));
            }
        }
    }

    internal Dictionary<string, Stream> method_12()
    {
        return this.dictionary_4;
    }

    private Borders method_120(TableCell A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        Borders borders3 = new Borders();
        Borders borders2 = A_0.CellFormat.Borders;
        RowFormat tableFormat = A_0.OwnerRow.OwnerTable.TableFormat;
        Borders borders = A_0.OwnerRow.HasTblPrEx ? A_0.OwnerRow.RowFormat.Borders : tableFormat.Borders;
        Border bottom = null;
        bool flag3 = false;
        bool flag4 = false;
        bool flag = false;
        bool flag5 = false;
        bool flag2 = false;
        int cellIndex = A_0.GetCellIndex();
        int rowIndex = A_0.OwnerRow.GetRowIndex();
        int num8 = A_0.OwnerRow.Cells.Count - 1;
        int num10 = A_0.OwnerRow.OwnerTable.Rows.Count - 1;
        int num4 = cellIndex;
        int num2 = rowIndex;
        for (int i = cellIndex + 1; i < (num8 + 1); i++)
        {
            if (A_0.OwnerRow.Cells[i].CellFormat.HorizontalMerge != CellMerge.Continue)
            {
                num4 = i;
                break;
            }
        }
        for (int j = rowIndex + 1; j < (num10 + 1); j++)
        {
            int num6 = this.method_121(A_0, cellIndex, j);
            if (num6 >= A_0.OwnerRow.OwnerTable.Rows[j].Cells.Count)
            {
                num2 = j;
                break;
            }
            if (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6].CellFormat.VerticalMerge != CellMerge.Continue)
            {
                num2 = j;
                break;
            }
            if (num6 > 0)
            {
                BorderStyle borderType = A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6 - 1].CellFormat.Borders.Right.BorderType;
            }
            if (((num6 < (A_0.OwnerRow.OwnerTable.Rows[j].Cells.Count - 1)) && ((A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6].CellFormat.Borders.Right.BorderType == BorderStyle.None) || (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6].CellFormat.Borders.Right.BorderType == BorderStyle.Cleared))) && (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6 + 1].CellFormat.Borders.Left.BorderType != BorderStyle.None))
            {
                BorderStyle style2 = A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6 + 1].CellFormat.Borders.Left.BorderType;
            }
            if ((A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6].CellFormat.Borders.Bottom.BorderType == BorderStyle.None) && (j == num10))
            {
                bottom = borders.Bottom;
            }
            else
            {
                bottom = A_0.OwnerRow.OwnerTable.Rows[j].Cells[num6].CellFormat.Borders.Bottom;
            }
            flag3 = true;
        }
        Border left = A_0.OwnerRow.Cells[num4].CellFormat.Borders.Left;
        float cellSpacingEx = tableFormat.CellSpacingEx;
        flag &= left.BorderType != BorderStyle.Cleared;
        if (num4 == cellIndex)
        {
            flag = false;
        }
        if (flag2 && flag3)
        {
            if (num2 == rowIndex)
            {
                flag2 = false;
            }
            else
            {
                int num3 = this.method_121(A_0, cellIndex, num2);
                if ((A_0.OwnerRow.OwnerTable.Rows[num2].Cells[num3].CellFormat.Borders.Top.BorderType == BorderStyle.Cleared) && (bottom.BorderType != BorderStyle.None))
                {
                    flag2 = false;
                }
            }
        }
        if ((flag2 && flag3) && ((borders2.Bottom.BorderType == BorderStyle.None) || (borders2.Bottom.BorderType == BorderStyle.Cleared)))
        {
            flag2 &= (bottom.BorderType == BorderStyle.None) || (bottom.BorderType == BorderStyle.Cleared);
        }
        if (!flag4)
        {
            Border border4 = (borders2.Left.BorderType != BorderStyle.None) ? borders2.Left : ((cellIndex == 0) ? borders.Left : ((borders2.Vertical.BorderType != BorderStyle.None) ? borders2.Vertical : borders.Vertical));
            if (border4.BorderType != BorderStyle.None)
            {
                borders3.Left.BorderType = border4.BorderType;
                borders3.Left.Color = border4.Color;
                borders3.Left.LineWidth = border4.LineWidth;
                borders3.Left.Space = border4.Space;
            }
        }
        if (!flag5)
        {
            Border border7 = (borders2.Top.BorderType != BorderStyle.None) ? borders2.Top : ((rowIndex == 0) ? borders.Top : ((borders2.Horizontal.BorderType != BorderStyle.None) ? borders2.Horizontal : borders.Horizontal));
            if (border7.BorderType != BorderStyle.None)
            {
                borders3.Top.BorderType = border7.BorderType;
                borders3.Top.Color = border7.Color;
                borders3.Top.LineWidth = border7.LineWidth;
                borders3.Top.Space = border7.Space;
            }
        }
        if (!flag)
        {
            Border border6 = (borders2.Right.BorderType != BorderStyle.None) ? borders2.Right : ((cellIndex == num8) ? borders.Right : ((borders2.Vertical.BorderType != BorderStyle.None) ? borders2.Vertical : borders.Vertical));
            if (border6.BorderType != BorderStyle.None)
            {
                borders3.Right.BorderType = border6.BorderType;
                borders3.Right.Color = border6.Color;
                borders3.Right.LineWidth = border6.LineWidth;
                borders3.Right.Space = border6.Space;
            }
        }
        if (!flag2)
        {
            Border border3 = flag3 ? bottom : borders2.Bottom;
            border3 = (border3.BorderType != BorderStyle.None) ? border3 : ((rowIndex == num10) ? borders.Bottom : ((borders2.Horizontal.BorderType != BorderStyle.None) ? borders2.Horizontal : borders.Horizontal));
            if (border3.BorderType != BorderStyle.None)
            {
                borders3.Bottom.BorderType = border3.BorderType;
                borders3.Bottom.Color = border3.Color;
                borders3.Bottom.LineWidth = border3.LineWidth;
                borders3.Bottom.Space = border3.Space;
            }
        }
        Border border8 = (borders2.DiagonalDown.BorderType != BorderStyle.None) ? borders2.DiagonalDown : borders.DiagonalDown;
        if (border8.BorderType != BorderStyle.None)
        {
            borders3.DiagonalDown.BorderType = border8.BorderType;
            borders3.DiagonalDown.Color = border8.Color;
            borders3.DiagonalDown.LineWidth = border8.LineWidth;
            borders3.DiagonalDown.Space = border8.Space;
        }
        Border border5 = (borders2.DiagonalUp.BorderType != BorderStyle.None) ? borders2.DiagonalUp : borders.DiagonalUp;
        if (border5.BorderType != BorderStyle.None)
        {
            borders3.DiagonalUp.BorderType = border5.BorderType;
            borders3.DiagonalUp.Color = border5.Color;
            borders3.DiagonalUp.LineWidth = border5.LineWidth;
            borders3.DiagonalUp.Space = border5.Space;
        }
        return borders3;
    }

    private int method_121(TableCell A_0, int A_1, int A_2)
    {
        float num2 = 0f;
        for (int i = 0; i < A_1; i++)
        {
            num2 += A_0.OwnerRow.Cells[i].Width;
        }
        float num4 = 0f;
        for (int j = 0; j < A_0.OwnerRow.OwnerTable.Rows[A_2].Cells.Count; j++)
        {
            num4 += A_0.OwnerRow.OwnerTable.Rows[A_2].Cells[j].Width;
            if (num2 == num4)
            {
                if (j == (A_0.OwnerRow.OwnerTable.Rows[A_2].Cells.Count - 1))
                {
                    return j;
                }
                return (j + 1);
            }
            if (num2 < num4)
            {
                return j;
            }
        }
        return 0;
    }

    private string method_122(Paragraph A_0, ParagraphFormat A_1, bool A_2, bool A_3, ListFormat A_4)
    {
        int num = 0x13;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("䴸帺䔼䬾汀≂⥄⹆⹈╊睌", 0x13) + A_1.HorizontalAlignment.ToString().ToLower() + BookmarkStart.b("ȸ", 0x13));
        if (A_1.KeepLines)
        {
            builder.Append(BookmarkStart.b("䤸娺娼娾汀⅂㝄≆⡈⁊恌♎㽐⁒㱔㍖㱘慚㱜⥞๠੢Ť屦", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䤸娺娼娾汀⅂㝄≆⡈⁊恌♎㽐⁒㱔㍖㱘慚㱜⩞ᕠౢ幤", num));
        }
        if (A_1.KeepFollow)
        {
            builder.Append(BookmarkStart.b("䤸娺娼娾汀⅂㝄≆⡈⁊恌⹎㝐❒ご╖捘㩚⭜ぞࡠݢ幤", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䤸娺娼娾汀⅂㝄≆⡈⁊恌⹎㝐❒ご╖捘㩚⡜⭞๠塢", num));
        }
        if (A_1.PageBreakBefore)
        {
            builder.Append(BookmarkStart.b("䤸娺娼娾汀⅂㝄≆⡈⁊恌ⵎ㑐㕒㩔╖㱘慚㱜㍞ᙠɢᱤᑦ剨", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䤸娺娼娾汀⅂㝄≆⡈⁊恌ⵎ㑐㕒㩔╖㱘慚㱜⩞ᕠౢ幤", num));
        }
        if (A_1.BackColor != Color.Empty)
        {
            builder.Append(BookmarkStart.b("嬸娺帼吾♀ㅂ⩄㉆❈⽊恌ⱎ㹐㽒㩔╖捘", num) + this.method_147(A_1.BackColor) + BookmarkStart.b("ȸ", num));
        }
        builder.Append(this.method_124(A_1));
        builder.Append(BookmarkStart.b("吸娺似堾⡀ⵂ桄㍆♈㭊睌", num) + XmlConvert.ToString(A_1.BeforeSpacing) + BookmarkStart.b("䤸伺ؼ", num));
        builder.Append(BookmarkStart.b("吸娺似堾⡀ⵂ桄╆♈㽊㥌⁎㱐楒", num) + XmlConvert.ToString(A_1.AfterSpacing) + BookmarkStart.b("䤸伺ؼ", num));
        if (A_2 && !A_3)
        {
            float num4 = A_1.LeftIndent + A_1.FirstLineIndent;
            ListLevel currentListLevel = null;
            if (((num4 > 0f) && (A_1.Tabs.Count > 0)) && (A_1.Tabs[0].Justification == TabJustification.List))
            {
                num4 = A_1.Tabs[0].Position - num4;
            }
            if (A_1.OwnerBase is Paragraph)
            {
                if (A_4 != null)
                {
                    currentListLevel = A_4.CurrentListLevel;
                }
                if (((currentListLevel != null) && ((currentListLevel.TextPosition + currentListLevel.NumberPosition) == 0f)) || (currentListLevel == null))
                {
                    num4 = 0f;
                }
                else if ((currentListLevel != null) && ((A_1.OwnerBase as Paragraph).ListFormat.ListType == ListType.Numbered))
                {
                    num4 = currentListLevel.TextPosition + currentListLevel.NumberPosition;
                }
                else if ((currentListLevel != null) && ((A_1.OwnerBase as Paragraph).ListFormat.ListType == ListType.Bulleted))
                {
                    num4 = Math.Abs((float) (num4 - currentListLevel.TextPosition));
                }
                else if (currentListLevel != null)
                {
                    num4 = currentListLevel.TextPosition + currentListLevel.NumberPosition;
                }
            }
            builder.Append(BookmarkStart.b("吸娺似堾⡀ⵂ桄⭆ⱈⵊ㥌畎", num) + XmlConvert.ToString(num4) + BookmarkStart.b("䤸伺ؼ", num));
            builder.Append(BookmarkStart.b("䴸帺䔼䬾汀⩂⭄⍆ⱈ╊㥌畎慐⍒⅔汖", num));
        }
        else if (A_2 && A_3)
        {
            float textPosition = A_1.LeftIndent + A_1.FirstLineIndent;
            float numberPosition = 0f;
            if (A_1.OwnerBase is Paragraph)
            {
                ListLevel level2 = (A_1.OwnerBase as Paragraph).ListFormat.CurrentListLevel;
                textPosition = level2.TextPosition;
                numberPosition = level2.NumberPosition;
            }
            builder.Append(BookmarkStart.b("吸娺似堾⡀ⵂ桄⭆ⱈⵊ㥌畎", num) + XmlConvert.ToString(textPosition) + BookmarkStart.b("䤸伺ؼ", num));
            builder.Append(BookmarkStart.b("䴸帺䔼䬾汀⩂⭄⍆ⱈ╊㥌畎", num) + XmlConvert.ToString(numberPosition) + BookmarkStart.b("䤸伺ؼ", num));
        }
        else
        {
            if (A_1.LeftIndent > 0f)
            {
                builder.Append(BookmarkStart.b("吸娺似堾⡀ⵂ桄⭆ⱈⵊ㥌畎", num) + XmlConvert.ToString(A_1.LeftIndent) + BookmarkStart.b("䤸伺ؼ", num));
            }
            if (A_1.HasValue(0x492))
            {
                builder.Append(BookmarkStart.b("䴸帺䔼䬾汀⩂⭄⍆ⱈ╊㥌畎", num) + XmlConvert.ToString(A_1.FirstLineIndent) + BookmarkStart.b("䤸伺ؼ", num));
            }
        }
        if (A_1.RightIndent > 0f)
        {
            builder.Append(BookmarkStart.b("吸娺似堾⡀ⵂ桄㕆⁈ⱊ╌㭎歐", num) + XmlConvert.ToString(A_1.RightIndent) + BookmarkStart.b("䤸伺ؼ", num));
        }
        bool flag = A_1.HasValue(0x618);
        if (A_1.IsBidi || flag)
        {
            string str = A_1.IsBidi ? BookmarkStart.b("䬸伺儼", num) : BookmarkStart.b("唸伺似", num);
            builder.AppendFormat(BookmarkStart.b("崸刺似娾≀㝂ⱄ⡆❈煊浌㑎慐⹒湔", num), str);
        }
        if ((A_0 != null) && (A_0.Items.Count == 0))
        {
            builder.AppendFormat(BookmarkStart.b("弸吺匼䬾汀あⱄ㵆ⱈ煊浌㑎慐⹒╔⍖托", num), A_0.BreakCharacterFormat.FontSize);
        }
        return this.method_150(A_1.Borders, builder, true);
    }

    private string method_123(Paragraph A_0, ParagraphFormat A_1, bool A_2, ListFormat A_3)
    {
        int num = 14;
        StringBuilder builder = new StringBuilder();
        bool flag = A_1.IsBidi || A_1.HasValue(0x618);
        if (A_1.HasValue(0x3fc))
        {
            builder.Append(BookmarkStart.b("䀳匵䀷丹ᄻ弽ⰿ⭁⍃⡅片", num) + A_1.HorizontalAlignment.ToString().ToLower() + BookmarkStart.b("༳", num));
        }
        if (A_1.KeepLines)
        {
            builder.Append(BookmarkStart.b("䐳圵強弹ᄻ尽㈿❁╃ⵅ敇⍉≋㵍㥏㙑ㅓ汕㥗ⱙ㍛㝝џ奡", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䐳圵強弹ᄻ尽㈿❁╃ⵅ敇⍉≋㵍㥏㙑ㅓ汕㥗⽙⡛ㅝ孟", num));
        }
        if (A_1.KeepFollow)
        {
            builder.Append(BookmarkStart.b("䐳圵強弹ᄻ尽㈿❁╃ⵅ敇⭉⩋㩍㕏⁑湓㝕⹗㕙㕛㩝孟", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䐳圵強弹ᄻ尽㈿❁╃ⵅ敇⭉⩋㩍㕏⁑湓㝕ⵗ⹙㍛敝", num));
        }
        if (A_1.PageBreakBefore)
        {
            builder.Append(BookmarkStart.b("䐳圵強弹ᄻ尽㈿❁╃ⵅ敇⡉⥋⡍㽏⁑ㅓ汕㥗㙙⭛㽝ᥟᅡ彣", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䐳圵強弹ᄻ尽㈿❁╃ⵅ敇⡉⥋⡍㽏⁑ㅓ汕㥗⽙⡛ㅝ孟", num));
        }
        if (A_1.BackColor != Color.Empty)
        {
            builder.Append(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅敇⥉⍋≍㽏⁑湓", num) + this.method_147(A_1.BackColor) + BookmarkStart.b("༳", num));
        }
        builder.Append(this.method_124(A_1));
        if (!A_1.BeforeAutoSpacing)
        {
            builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿㙁⭃㙅片", num) + XmlConvert.ToString(A_1.BeforeSpacing) + BookmarkStart.b("䐳䈵̷", num));
        }
        if (!A_1.AfterAutoSpacing)
        {
            builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿⁁⭃㉅㱇╉⅋瑍", num) + XmlConvert.ToString(A_1.AfterSpacing) + BookmarkStart.b("䐳䈵̷", num));
        }
        if (A_2)
        {
            float num2 = 0f;
            float num3 = 0f;
            this.method_126(A_0, ref num2, ref num3);
            if (flag)
            {
                builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿ぁⵃⅅ⁇㹉癋", num) + XmlConvert.ToString(num2) + BookmarkStart.b("䐳䈵̷", num));
            }
            else
            {
                builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿⹁⅃⁅㱇灉", num) + XmlConvert.ToString(num2) + BookmarkStart.b("䐳䈵̷", num));
            }
            builder.Append(BookmarkStart.b("䀳匵䀷丹ᄻ圽⸿♁⅃⡅㱇灉", num) + XmlConvert.ToString(num3) + BookmarkStart.b("䐳䈵̷", num));
        }
        else
        {
            float num4 = this.method_125(A_0, A_1);
            if (flag)
            {
                builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿ぁⵃⅅ⁇㹉癋", num) + XmlConvert.ToString((num4 <= 0f) ? 0f : num4) + BookmarkStart.b("䐳䈵̷", num));
            }
            else
            {
                builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿⹁⅃⁅㱇灉", num) + XmlConvert.ToString((num4 <= 0f) ? 0f : num4) + BookmarkStart.b("䐳䈵̷", num));
            }
            builder.Append(BookmarkStart.b("䀳匵䀷丹ᄻ圽⸿♁⅃⡅㱇灉", num) + XmlConvert.ToString(A_1.FirstLineIndent) + BookmarkStart.b("䐳䈵̷", num));
        }
        if (A_1.RightIndent > 0f)
        {
            if (flag)
            {
                builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿⹁⅃⁅㱇灉", num) + XmlConvert.ToString(A_1.RightIndent) + BookmarkStart.b("䐳䈵̷", num));
            }
            else
            {
                builder.Append(BookmarkStart.b("夳圵䨷崹唻倽洿ぁⵃⅅ⁇㹉癋", num) + XmlConvert.ToString(A_1.RightIndent) + BookmarkStart.b("䐳䈵̷", num));
            }
        }
        if (flag)
        {
            string str = A_1.IsBidi ? BookmarkStart.b("䘳䈵吷", num) : BookmarkStart.b("堳䈵䨷", num);
            builder.AppendFormat(BookmarkStart.b("倳張䨷弹弻䨽⤿ⵁ⩃籅桇ㅉ籋㍍歏", num), str);
        }
        if ((A_0 != null) && (A_0.Items.Count == 0))
        {
            builder.AppendFormat(BookmarkStart.b("刳夵嘷丹ᄻ䴽⤿㡁⅃籅桇ㅉ籋㍍⁏♑潓", num), A_0.BreakCharacterFormat.FontSize);
        }
        return this.method_150(A_1.Borders, builder, true);
    }

    private string method_124(ParagraphFormat A_0)
    {
        int num = 11;
        string str = string.Empty;
        if ((A_0.LineSpacing > 0f) && this.method_166(A_0))
        {
            switch (A_0.LineSpacingRule)
            {
                case LineSpacingRule.AtLeast:
                case LineSpacingRule.Exactly:
                    return (BookmarkStart.b("崰娲嬴制ᐸ区堼嘾♀⭂ㅄ絆", num) + XmlConvert.ToString(A_0.LineSpacing) + BookmarkStart.b("䄰䜲ิ", num));

                case LineSpacingRule.Multiple:
                    return (BookmarkStart.b("崰娲嬴制ᐸ区堼嘾♀⭂ㅄ絆", num) + XmlConvert.ToString(Math.Round((double) (A_0.LineSpacing / 12f), 2)) + BookmarkStart.b("ਰ", num));
            }
        }
        return str;
    }

    private float method_125(Paragraph A_0, ParagraphFormat A_1)
    {
        float num = 0f;
        if (A_0 != null)
        {
            if (A_0.Format.HasValue(0x488))
            {
                return A_0.Format.LeftIndent;
            }
            if (A_0.ParaStyle != null)
            {
                for (ParagraphStyle style = A_0.ParaStyle; style != null; style = style.BaseStyle)
                {
                    ParagraphFormat paragraphFormat = style.ParagraphFormat;
                    if (paragraphFormat.HasValue(0x488))
                    {
                        return paragraphFormat.LeftIndent;
                    }
                }
            }
            return num;
        }
        return A_1.LeftIndent;
    }

    private void method_126(Paragraph A_0, ref float A_1, ref float A_2)
    {
        if (!A_0.ListFormat.IsEmptyList && (!A_0.SectionEndMark || !string.IsNullOrEmpty(A_0.Text)))
        {
            ListFormat format = new ListFormat(A_0);
            format.method_25(A_0.ListFormat);
            ParagraphStyle paraStyle = A_0.ParaStyle;
            for (ParagraphStyle style2 = paraStyle; style2 != null; style2 = style2.BaseStyle)
            {
                if (!style2.ListFormat.IsEmptyList && (((style2.ListFormat.CurrentListStyle == null) || (style2.ListFormat.CurrentListLevel == null)) || !(style2.StyleId != style2.ListFormat.CurrentListLevel.ParaStyleName)))
                {
                    format.method_25(style2.ListFormat);
                    continue;
                }
                bool flag = false;
                if (((!style2.ListFormat.IsEmptyList && !style2.ListFormat.HasKey(0)) && (!format.HasKey(0) && (style2.ListFormat.CurrentListStyle != null))) && (style2.StyleId != style2.ListFormat.CurrentListLevel.ParaStyleName))
                {
                    using (IEnumerator enumerator = style2.ListFormat.CurrentListStyle.Levels.GetEnumerator())
                    {
                        ListLevel current;
                        while (enumerator.MoveNext())
                        {
                            current = (ListLevel) enumerator.Current;
                            if (style2.StyleId == current.ParaStyleName)
                            {
                                goto Label_0152;
                            }
                        }
                        goto Label_0197;
                    Label_0152:
                        flag = true;
                        format.method_25(style2.ListFormat);
                        format.ListLevelNumber = style2.ListFormat.CurrentListStyle.Levels.method_6(current);
                    }
                }
            Label_0197:
                if (!flag)
                {
                    break;
                }
            }
            if ((format != null) && (format.CurrentListStyle != null))
            {
                ListStyle currentListStyle = format.CurrentListStyle;
                int levelNumber = 0;
                if (format.HasKey(0))
                {
                    levelNumber = format.ListLevelNumber;
                }
                ListLevel overrideListLevel = (currentListStyle.Levels.Count > 0) ? currentListStyle.GetNearLevel(levelNumber) : null;
                if (overrideListLevel != null)
                {
                    Class12 class2 = null;
                    if ((format.LFOStyleName != null) && (format.LFOStyleName.Length > 0))
                    {
                        class2 = A_0.Document.ListOverrides.method_35(format.LFOStyleName);
                    }
                    if (((class2 != null) && class2.method_23().method_11(levelNumber)) && class2.method_23().method_5(levelNumber).OverrideFormatting)
                    {
                        overrideListLevel = class2.method_23().method_5(levelNumber).OverrideListLevel;
                    }
                    if ((currentListStyle.ListType == ListType.Numbered) || (currentListStyle.ListType == ListType.Bulleted))
                    {
                        if (overrideListLevel.ParagraphFormat.HasKey(0x488))
                        {
                            A_1 = overrideListLevel.ParagraphFormat.LeftIndent;
                        }
                        if ((A_0.ListFormat.ListType == ListType.NoList) && (paraStyle.ParagraphFormat.HasKey(0x488) || ((paraStyle.ParagraphFormat.LeftIndent != 0f) && (paraStyle.ParagraphFormat.LeftIndent != overrideListLevel.ParagraphFormat.LeftIndent))))
                        {
                            A_1 = paraStyle.ParagraphFormat.LeftIndent;
                        }
                        else if ((((A_0.ListFormat.ListType != ListType.NoList) && !A_0.ListFormat.HasKey(1)) && paraStyle.ListFormat.HasKey(1)) && (paraStyle.ParagraphFormat.HasKey(0x488) || !overrideListLevel.ParagraphFormat.HasKey(0x488)))
                        {
                            A_1 = paraStyle.ParagraphFormat.LeftIndent;
                        }
                        if (A_0.Format.HasKey(0x488))
                        {
                            A_1 = A_0.Format.LeftIndent;
                        }
                        if (overrideListLevel.ParagraphFormat.HasKey(0x492))
                        {
                            A_2 = overrideListLevel.ParagraphFormat.FirstLineIndent;
                        }
                        if ((A_0.ListFormat.ListType == ListType.NoList) && (paraStyle.ParagraphFormat.HasKey(0x492) || ((paraStyle.ParagraphFormat.FirstLineIndent != 0f) && (paraStyle.ParagraphFormat.FirstLineIndent != overrideListLevel.ParagraphFormat.FirstLineIndent))))
                        {
                            A_2 = paraStyle.ParagraphFormat.FirstLineIndent;
                        }
                        else if ((((A_0.ListFormat.ListType != ListType.NoList) && !A_0.ListFormat.HasKey(1)) && paraStyle.ListFormat.HasKey(1)) && (paraStyle.ParagraphFormat.HasKey(0x492) || !overrideListLevel.ParagraphFormat.HasKey(0x492)))
                        {
                            A_2 = paraStyle.ParagraphFormat.FirstLineIndent;
                        }
                        if (A_0.Format.HasKey(0x492))
                        {
                            A_2 = A_0.Format.FirstLineIndent;
                        }
                        if (((A_2 < 0f) && (A_1 == 0f)) && (!A_0.Format.HasValue(0x488) && !paraStyle.ParagraphFormat.HasValue(0x488)))
                        {
                            A_1 = Math.Abs(A_2);
                        }
                    }
                }
                format.Close();
            }
        }
    }

    private string method_127(CharacterFormat A_0)
    {
        return this.method_128(A_0, false);
    }

    private string method_128(CharacterFormat A_0, bool A_1)
    {
        int num = 0x10;
        StringBuilder builder = new StringBuilder();
        builder.Append(this.method_135(A_0));
        builder.Append(this.method_134(A_0));
        builder.Append(this.method_136(A_0));
        builder.Append(this.method_133(A_0));
        this.method_148(120, BookmarkStart.b("䈵崷䈹䠻ጽ㐿ぁ╃⡅㭇ⱉ⍋㱍㵏桑⅓♕⡗㽙⹛㵝şᅡţ嵥", 0x10), BookmarkStart.b("䈵崷䈹䠻ጽ㐿ぁ╃⡅㭇ⱉ⍋㱍㵏桑㩓㥕㙗㽙杛", 0x10), A_0, builder);
        this.method_148(60, BookmarkStart.b("倵圷吹䠻ጽ㜿❁ⵃⅅ⁇㹉癋ⱍ㽏㹑こ浕", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㜿❁ⵃⅅ⁇㹉癋⁍㽏⁑㥓㝕㑗慙", 0x10), A_0, builder);
        this.method_148(130, BookmarkStart.b("刵儷䤹䰻刽ℿ㭁繃⡅❇⑉⥋畍", 0x10), string.Empty, A_0, builder);
        this.method_148(70, BookmarkStart.b("倵圷吹䠻ጽ㌿㙁㵃⩅ⵇ灉╋㩍ㅏ㹑㵓㕕捗", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㌿㙁㵃⩅ⵇ灉≋⅍≏㽑㕓㩕捗", 0x10), A_0, builder);
        this.method_148(110, BookmarkStart.b("倵圷吹䠻ጽ㘿⍁㙃⽅⥇⑉㡋瑍⍏㽑㕓㩕㑗睙㽛㽝ၟᅡ彣", 0x10), BookmarkStart.b("倵圷吹䠻ጽ㘿⍁㙃⽅⥇⑉㡋瑍㹏㵑♓㭕㥗㙙杛", 0x10), A_0, builder);
        this.method_148(80, BookmarkStart.b("䈵崷䈹䠻ጽ␿❁❃⥅㩇⭉㡋❍㽏㱑湓㩕ㅗ㑙㥛獝ᑟ੡ᙣ॥ᵧ൩ѫ啭", 0x10), BookmarkStart.b("䈵崷䈹䠻ጽ␿❁❃⥅㩇⭉㡋❍㽏㱑湓㡕㝗㑙㥛敝", 0x10), A_0, builder);
        builder.Append(this.method_131(A_0));
        builder.Append(this.method_129(A_0));
        if (A_0.Bidi || A_0.HasValue(0x109))
        {
            string str = A_0.Bidi ? BookmarkStart.b("䐵䰷嘹", num) : BookmarkStart.b("娵䰷䠹", num);
            builder.AppendFormat(BookmarkStart.b("刵儷䠹夻崽㐿⭁⭃⡅片橉㝋繍ⵏ楑", num), str);
        }
        return builder.ToString();
    }

    private string method_129(CharacterFormat A_0)
    {
        string str = string.Empty;
        if (A_0.Document.DefCharFormat != null)
        {
            str = this.method_130(A_0.Document.DefCharFormat);
        }
        if (this.paragraphStyle_0 != null)
        {
            str = this.method_130(this.paragraphStyle_0.CharacterFormat);
        }
        if ((this.paragraph_0 != null) && (this.paragraph_0.ParaStyle != null))
        {
            str = this.method_130(this.paragraph_0.ParaStyle.CharacterFormat);
        }
        if (A_0.CharStyle != null)
        {
            str = this.method_130(A_0.CharStyle.CharacterFormat);
        }
        return this.method_130(A_0);
    }

    internal Dictionary<string, string> method_13()
    {
        return this.dictionary_5;
    }

    private string method_130(CharacterFormat A_0)
    {
        int num = 3;
        if (A_0 == null)
        {
            return null;
        }
        StringBuilder builder = new StringBuilder();
        if ((A_0.HasValue(140) && (((A_0.UnderlineStyle != UnderlineStyle.None) || A_0.DoubleStrike) || A_0.IsStrikeout)) && ((this.paragraph_0 == null) || ((this.paragraph_0 != null) && (this.paragraph_0.Text != ""))))
        {
            builder.Append(BookmarkStart.b("崨个唬嬮ᰰ圲倴吶嘸䤺尼䬾⡀ⱂ⭄絆", num));
            if (A_0.UnderlineStyle != UnderlineStyle.None)
            {
                builder.Append(BookmarkStart.b("न帪䌬䬮吰䄲头帶圸帺", num));
            }
            if (A_0.DoubleStrike || A_0.IsStrikeout)
            {
                builder.Append(BookmarkStart.b("न䜪䐬䄮吰Ḳ䄴弶䬸吺䠼堾⥀", num));
            }
            builder.Append(BookmarkStart.b("ረ", num));
        }
        return builder.ToString();
    }

    private string method_131(CharacterFormat A_0)
    {
        string str = string.Empty;
        if (A_0.Document.DefCharFormat != null)
        {
            str = this.method_132(A_0.Document.DefCharFormat);
        }
        if (this.paragraphStyle_0 != null)
        {
            str = this.method_132(this.paragraphStyle_0.CharacterFormat);
        }
        if ((this.paragraph_0 != null) && (this.paragraph_0.ParaStyle != null))
        {
            str = this.method_132(this.paragraph_0.ParaStyle.CharacterFormat);
        }
        if (A_0.CharStyle != null)
        {
            str = this.method_132(A_0.CharStyle.CharacterFormat);
        }
        return this.method_132(A_0);
    }

    private string method_132(CharacterFormat A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            return string.Empty;
        }
        StringBuilder builder = new StringBuilder();
        if (!A_0.HasValue(210))
        {
            return string.Empty;
        }
        if (A_0.SubSuperScript == SubSuperScript.SubScript)
        {
            builder.Append(BookmarkStart.b("丷弹主䨽⤿⅁╃⩅敇⭉⁋❍㝏㱑湓╕ⵗ㡙杛", num));
            builder.Append(BookmarkStart.b("帷唹刻䨽洿ㅁⵃ㱅ⵇ灉", num) + XmlConvert.ToString(Math.Round((double) (this.method_149(A_0) / 12f), 2)) + BookmarkStart.b("崷圹ܻ", num));
        }
        else if (A_0.SubSuperScript == SubSuperScript.SuperScript)
        {
            builder.Append(BookmarkStart.b("丷弹主䨽⤿⅁╃⩅敇⭉⁋❍㝏㱑湓╕ⵗ⩙㥛ⱝ孟", num));
            builder.Append(BookmarkStart.b("帷唹刻䨽洿ㅁⵃ㱅ⵇ灉", num) + XmlConvert.ToString(Math.Round((double) (this.method_149(A_0) / 12f), 2)) + BookmarkStart.b("崷圹ܻ", num));
        }
        return builder.ToString();
    }

    private string method_133(CharacterFormat A_0)
    {
        int num = 13;
        string str = string.Empty;
        if (A_0.Document.DefCharFormat != null)
        {
            CharacterFormat defCharFormat = A_0.Document.DefCharFormat;
            if ((defCharFormat.HasValue(20) || defCharFormat.HasValue(9)) || defCharFormat.HasValue(0x14c))
            {
                if ((defCharFormat.HighlightColor != Color.Empty) && (defCharFormat.HighlightColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(defCharFormat.HighlightColor) + BookmarkStart.b("࠲", num);
                }
                else if ((defCharFormat.TextBackgroundColor != Color.Empty) && (defCharFormat.TextBackgroundColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(defCharFormat.TextBackgroundColor) + BookmarkStart.b("࠲", num);
                }
            }
        }
        if (this.paragraphStyle_0 != null)
        {
            CharacterFormat characterFormat = this.paragraphStyle_0.CharacterFormat;
            if ((characterFormat.HasValue(20) || characterFormat.HasValue(9)) || characterFormat.HasValue(0x14c))
            {
                if ((characterFormat.HighlightColor != Color.Empty) && (characterFormat.HighlightColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(characterFormat.HighlightColor) + BookmarkStart.b("࠲", num);
                }
                else if ((characterFormat.TextBackgroundColor != Color.Empty) && (characterFormat.TextBackgroundColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(characterFormat.TextBackgroundColor) + BookmarkStart.b("࠲", num);
                }
            }
        }
        if ((this.paragraph_0 != null) && (this.paragraph_0.ParaStyle != null))
        {
            CharacterFormat format3 = this.paragraph_0.ParaStyle.CharacterFormat;
            if ((format3.HasValue(20) || format3.HasValue(9)) || format3.HasValue(0x14c))
            {
                if ((format3.HighlightColor != Color.Empty) && (format3.HighlightColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(format3.HighlightColor) + BookmarkStart.b("࠲", num);
                }
                else if ((format3.TextBackgroundColor != Color.Empty) && (format3.TextBackgroundColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(format3.TextBackgroundColor) + BookmarkStart.b("࠲", num);
                }
            }
        }
        if (A_0.CharStyle != null)
        {
            CharacterFormat format2 = A_0.CharStyle.CharacterFormat;
            if ((format2.HasValue(20) || format2.HasValue(9)) || format2.HasValue(0x14c))
            {
                if ((format2.HighlightColor != Color.Empty) && (format2.HighlightColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(format2.HighlightColor) + BookmarkStart.b("࠲", num);
                }
                else if ((format2.TextBackgroundColor != Color.Empty) && (format2.TextBackgroundColor != Color.White))
                {
                    str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(format2.TextBackgroundColor) + BookmarkStart.b("࠲", num);
                }
            }
        }
        if ((A_0.HasValue(20) || A_0.HasValue(9)) || A_0.HasValue(0x14c))
        {
            if ((A_0.HighlightColor != Color.Empty) && (A_0.HighlightColor != Color.White))
            {
                return (BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(A_0.HighlightColor) + BookmarkStart.b("࠲", num));
            }
            if ((A_0.TextBackgroundColor != Color.Empty) && (A_0.TextBackgroundColor != Color.White))
            {
                str = BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⩈⑊⅌⁎⍐楒", num) + this.method_147(A_0.TextBackgroundColor) + BookmarkStart.b("࠲", num);
            }
        }
        return str;
    }

    private string method_134(CharacterFormat A_0)
    {
        int num = 3;
        string str = string.Empty;
        if (((A_0.Document.DefCharFormat != null) && (A_0.Document.DefCharFormat.HasValue(160) || A_0.Document.DefCharFormat.HasValue(0x59))) && (A_0.Document.DefCharFormat.TextColor != Color.Empty))
        {
            str = BookmarkStart.b("䨨䐪䄬䀮䌰ल", num) + this.method_147(A_0.Document.DefCharFormat.TextColor) + BookmarkStart.b("ረ", num);
        }
        if (((this.paragraphStyle_0 != null) && (this.paragraphStyle_0.CharacterFormat.HasValue(160) || this.paragraphStyle_0.CharacterFormat.HasValue(0x59))) && (this.paragraphStyle_0.CharacterFormat.TextColor != Color.Empty))
        {
            str = BookmarkStart.b("䨨䐪䄬䀮䌰ल", num) + this.method_147(this.paragraphStyle_0.CharacterFormat.TextColor) + BookmarkStart.b("ረ", num);
        }
        if ((this.paragraph_0 != null) && (this.paragraph_0.ParaStyle != null))
        {
            for (ParagraphStyle style = this.paragraph_0.ParaStyle; style != null; style = style.BaseStyle)
            {
                CharacterFormat characterFormat = style.CharacterFormat;
                if ((characterFormat.HasValue(160) || characterFormat.HasValue(0x59)) && (characterFormat.TextColor != Color.Empty))
                {
                    str = BookmarkStart.b("䨨䐪䄬䀮䌰ल", num) + this.method_147(characterFormat.TextColor) + BookmarkStart.b("ረ", num);
                    break;
                }
            }
        }
        if (A_0.CharStyle != null)
        {
            for (Class11 class2 = A_0.CharStyle; class2 != null; class2 = class2.method_23())
            {
                CharacterFormat format = class2.CharacterFormat;
                if ((format.HasValue(160) || format.HasValue(0x59)) && (format.TextColor != Color.Empty))
                {
                    str = BookmarkStart.b("䨨䐪䄬䀮䌰ल", num) + this.method_147(format.TextColor) + BookmarkStart.b("ረ", num);
                    break;
                }
            }
        }
        if ((A_0.HasValue(160) || A_0.HasValue(0x59)) && (A_0.TextColor != Color.Empty))
        {
            str = BookmarkStart.b("䨨䐪䄬䀮䌰ल", num) + this.method_147(A_0.TextColor) + BookmarkStart.b("ረ", num);
        }
        return str;
    }

    private string method_135(CharacterFormat A_0)
    {
        int num = 4;
        string str = string.Empty;
        if ((A_0.Document.DefCharFormat != null) && A_0.Document.DefCharFormat.HasValue(150))
        {
            str = BookmarkStart.b("䘩䤫娭䐯圱䘳ᬵ䬷䨹崻崽⤿ⱁ⍃籅", num) + XmlConvert.ToString(A_0.Document.DefCharFormat.CharacterSpacing) + BookmarkStart.b("娩堫ᔭ", num);
        }
        if (((this.paragraph_0 != null) && (this.paragraph_0.ParaStyle != null)) && this.paragraph_0.ParaStyle.CharacterFormat.HasValue(150))
        {
            str = BookmarkStart.b("䘩䤫娭䐯圱䘳ᬵ䬷䨹崻崽⤿ⱁ⍃籅", num) + XmlConvert.ToString(this.paragraph_0.ParaStyle.CharacterFormat.CharacterSpacing) + BookmarkStart.b("娩堫ᔭ", num);
        }
        if ((A_0.CharStyle != null) && A_0.CharStyle.CharacterFormat.HasValue(150))
        {
            str = BookmarkStart.b("䘩䤫娭䐯圱䘳ᬵ䬷䨹崻崽⤿ⱁ⍃籅", num) + XmlConvert.ToString(A_0.CharStyle.CharacterFormat.CharacterSpacing) + BookmarkStart.b("娩堫ᔭ", num);
        }
        if (A_0.HasValue(150) && (A_0.CharacterSpacing > 0f))
        {
            str = BookmarkStart.b("䘩䤫娭䐯圱䘳ᬵ䬷䨹崻崽⤿ⱁ⍃籅", num) + XmlConvert.ToString(A_0.CharacterSpacing) + BookmarkStart.b("娩堫ᔭ", num);
        }
        return str.ToString();
    }

    private string method_136(CharacterFormat A_0)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.method_137(A_0));
        builder.Append(this.method_145(A_0));
        builder.Append(this.method_139(A_0));
        return builder.ToString();
    }

    private string method_137(CharacterFormat A_0)
    {
        int num = 7;
        StringBuilder builder = new StringBuilder();
        float num2 = 0f;
        if (!(A_0.OwnerBase is ListLevel) || (this.paragraph_0 == null))
        {
            if (A_0.Document.DefCharFormat != null)
            {
                num2 = this.method_138(A_0.Document.DefCharFormat, num2);
            }
            if ((this.paragraph_0 == null) || (this.paragraph_0.ParaStyle == null))
            {
                if (this.paragraphStyle_0 != null)
                {
                    num2 = this.method_138(this.paragraphStyle_0.CharacterFormat, num2);
                }
            }
            else
            {
                float num3 = num2;
                num2 = 0f;
                for (ParagraphStyle style = this.paragraph_0.ParaStyle; style != null; style = style.BaseStyle)
                {
                    num2 = this.method_138(style.CharacterFormat, num2);
                    if (num2 != 0.0)
                    {
                        break;
                    }
                }
                if (num2 == 0f)
                {
                    num2 = num3;
                }
            }
            if (A_0.CharStyle != null)
            {
                num2 = this.method_138(A_0.CharStyle.CharacterFormat, num2);
            }
            if (A_0 != null)
            {
                num2 = this.method_138(A_0, num2);
            }
            if (num2 > 0.0)
            {
                builder.Append(BookmarkStart.b("䬬䀮弰䜲ᠴ䐶倸䄺堼Ծ", num) + XmlConvert.ToString(num2) + BookmarkStart.b("崬嬮ਰ", num));
            }
        }
        return builder.ToString();
    }

    private float method_138(CharacterFormat A_0, float A_1)
    {
        bool flag = false;
        for (FormatBase base2 = A_0; base2 != null; base2 = base2.BaseFormat)
        {
            if (flag)
            {
                break;
            }
            flag = base2.HasValue(190);
        }
        if (flag && (A_0.SubSuperScript == SubSuperScript.None))
        {
            A_1 = A_0.FontSize;
        }
        return A_1;
    }

    private string method_139(CharacterFormat A_0)
    {
        new StringBuilder();
        Struct32 struct2 = new Struct32();
        if (A_0.Document.DefCharFormat != null)
        {
            struct2 = this.method_141(A_0.Document.DefCharFormat, struct2);
        }
        if ((this.paragraph_0 == null) || (this.paragraph_0.ParaStyle == null))
        {
            if (this.paragraphStyle_0 != null)
            {
                struct2 = this.method_141(this.paragraphStyle_0.CharacterFormat, struct2);
            }
        }
        else
        {
            Struct32 struct3 = struct2;
            struct2 = new Struct32();
            for (ParagraphStyle style = this.paragraph_0.ParaStyle; style != null; style = style.BaseStyle)
            {
                struct2 = this.method_141(style.CharacterFormat, struct2);
                if (struct2.method_1())
                {
                    break;
                }
            }
            if (!struct2.method_1())
            {
                struct2 = struct3;
            }
        }
        if (A_0.CharStyle != null)
        {
            struct2 = this.method_141(A_0.CharStyle.CharacterFormat, struct2);
        }
        if (A_0 != null)
        {
            struct2 = this.method_141(A_0, struct2);
        }
        return this.method_140(struct2);
    }

    private Regex method_14()
    {
        int num = 5;
        if (this.regex_0 == null)
        {
            List<char> hTMLIdentifierPunctuations = this.document_0.HTMLIdentifierPunctuations;
            string str = null;
            foreach (char ch in hTMLIdentifierPunctuations)
            {
                str = str + ch;
            }
            this.regex_0 = new Regex(BookmarkStart.b("̪瘬焮", num) + str + BookmarkStart.b("瘪ܬخᤰᬲ渴", num) + str + BookmarkStart.b("瘪ج献䈰䠲дᬶ䐸ሺ䄼᜾ᩀ", num) + str + BookmarkStart.b("瘪Ьخᨰ", num));
        }
        return this.regex_0;
    }

    private string method_140(Struct32 A_0)
    {
        int num = 13;
        StringBuilder builder = new StringBuilder();
        string str = !string.IsNullOrEmpty(A_0.string_0) ? A_0.string_0 : (!string.IsNullOrEmpty(A_0.string_1) ? A_0.string_1 : (!string.IsNullOrEmpty(A_0.string_2) ? A_0.string_2 : string.Empty));
        if (!string.IsNullOrEmpty(str))
        {
            builder.Append(BookmarkStart.b("唲娴夶䴸ᘺ嬼帾ⱀ⩂⥄㹆獈", num) + str + BookmarkStart.b("࠲", num));
        }
        if (!string.IsNullOrEmpty(A_0.string_1))
        {
            builder.Append(BookmarkStart.b("帲䘴堶ᐸ崺尼䴾⑀≂㙄㍆摈ⵊ≌ⅎ═繒㍔㙖㑘㉚ㅜ♞孠", num) + A_0.string_1 + BookmarkStart.b("࠲", num));
        }
        if (!string.IsNullOrEmpty(A_0.string_2))
        {
            builder.Append(BookmarkStart.b("帲䘴堶ᐸ夺吼嬾⡀湂⍄⡆❈㽊恌⥎ぐ㹒㱔㭖⁘慚", num) + A_0.string_2 + BookmarkStart.b("࠲", num));
        }
        if (!string.IsNullOrEmpty(A_0.string_4))
        {
            builder.Append(BookmarkStart.b("弲吴夶常ĺ", num) + A_0.string_4 + BookmarkStart.b("࠲", num));
        }
        if (!string.IsNullOrEmpty(A_0.string_5))
        {
            builder.Append(BookmarkStart.b("帲䘴堶ᐸ崺尼䴾⑀≂㙄㍆摈❊ⱌⅎ㙐♒㑔ざ㱘慚", num) + A_0.string_5 + BookmarkStart.b("࠲", num));
        }
        if (!string.IsNullOrEmpty(A_0.string_6))
        {
            builder.Append(BookmarkStart.b("帲䘴堶ᐸ娺匼䰾⡀湂⥄♆❈ⱊ㡌⹎㙐㙒潔", num) + A_0.string_6 + BookmarkStart.b("࠲", num));
        }
        return builder.ToString();
    }

    private Struct32 method_141(CharacterFormat A_0, Struct32 A_1)
    {
        Struct32 struct2 = new Struct32();
        if (A_0.HasValue(2))
        {
            string str = this.method_144(A_0.FontName);
            struct2.string_0 = str;
        }
        if (A_0.HasValue(230))
        {
            string str3 = this.method_144(A_0.FontNameAscii);
            struct2.string_0 = str3;
        }
        if (A_0.HasValue(0xeb))
        {
            string str2 = this.method_144(A_0.FontNameFarEast);
            struct2.string_1 = str2;
        }
        if (A_0.HasValue(270))
        {
            string str5 = this.method_144(A_0.FontNameBidi);
            struct2.string_2 = str5;
        }
        if (A_0.HasValue(240))
        {
            string str4 = this.method_144(A_0.FontNameNonFarEast);
            struct2.string_3 = str4;
        }
        if (A_0.HasValue(380))
        {
            struct2.string_4 = this.method_142(A_0.LocaleIdASCII);
        }
        if (A_0.HasValue(390))
        {
            struct2.string_5 = this.method_142(A_0.LocaleIdFarEast);
        }
        if (A_0.HasValue(340))
        {
            struct2.string_6 = this.method_142(A_0.LocaleIdBi);
        }
        if (struct2.method_1())
        {
            return struct2;
        }
        return A_1;
    }

    private string method_142(int A_0)
    {
        if (A_0 == 0x40a)
        {
            return string.Empty;
        }
        return ((LocaleIDs) A_0).ToString().Replace('_', '-').ToUpperInvariant();
    }

    private string method_143(string A_0, string A_1)
    {
        int num = 1;
        if (!A_0.Contains(A_1))
        {
            if (!string.IsNullOrEmpty(A_0))
            {
                A_0 = A_0 + BookmarkStart.b("ଦ", num) + A_1;
                return A_0;
            }
            A_0 = A_1;
        }
        return A_0;
    }

    private string method_144(string A_0)
    {
        int num = 0;
        string str = A_0.Trim();
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }
        if (str.Contains(BookmarkStart.b("إ", num)))
        {
            return (BookmarkStart.b("ĥ", num) + str + BookmarkStart.b("ĥ", num));
        }
        return str;
    }

    private string method_145(CharacterFormat A_0)
    {
        StringBuilder builder = new StringBuilder();
        string str = string.Empty;
        if (A_0.Document.DefCharFormat != null)
        {
            str = this.method_146(A_0.Document.DefCharFormat, str);
        }
        if ((this.paragraph_0 == null) || (this.paragraph_0.ParaStyle == null))
        {
            if (this.paragraphStyle_0 != null)
            {
                str = this.method_146(this.paragraphStyle_0.CharacterFormat, str);
            }
        }
        else
        {
            string str2 = str;
            str = string.Empty;
            for (ParagraphStyle style = this.paragraph_0.ParaStyle; style != null; style = style.BaseStyle)
            {
                str = this.method_146(style.CharacterFormat, str);
                if (str != string.Empty)
                {
                    break;
                }
            }
            if (str == string.Empty)
            {
                str = str2;
            }
        }
        if (A_0.CharStyle != null)
        {
            str = this.method_146(A_0.CharStyle.CharacterFormat, str);
        }
        if (A_0 != null)
        {
            str = this.method_146(A_0, str);
        }
        if (str != string.Empty)
        {
            builder.Append(str);
        }
        return builder.ToString();
    }

    private string method_146(CharacterFormat A_0, string A_1)
    {
        int num = 2;
        if (A_0.HasValue(170) || A_0.HasValue(90))
        {
            if (!A_0.Emboss && !A_0.IsOutLine)
            {
                A_1 = string.Empty;
                return A_1;
            }
            A_1 = BookmarkStart.b("丧䔩䈫娭ᴯ䔱儳張強刹䠻н∿ⵁ⡃≅獇", num);
        }
        return A_1;
    }

    private string method_147(Color A_0)
    {
        int num = A_0.ToArgb() & 0xffffff;
        return (BookmarkStart.b("ᬷ", 0x12) + num.ToString(BookmarkStart.b("怷హ", 0x12)));
    }

    private void method_148(short A_0, string A_1, string A_2, CharacterFormat A_3, StringBuilder A_4)
    {
        if (A_3.method_62(A_0))
        {
            A_4.Append(A_1);
        }
        else if (A_3.HasValue(A_0))
        {
            A_4.Append(A_2);
        }
    }

    private float method_149(CharacterFormat A_0)
    {
        if (A_0.FontSize > 1f)
        {
            return (A_0.FontSize / 2f);
        }
        return 8f;
    }

    public void method_15(Document A_0, string A_1)
    {
        int num = 8;
        this.document_0 = A_0;
        this.string_1 = Path.GetFileNameWithoutExtension(A_1);
        this.string_2 = Path.GetDirectoryName(A_1) + BookmarkStart.b("爭", 8);
        if (this.string_2 == BookmarkStart.b("爭", 8))
        {
            this.string_2 = Environment.CurrentDirectory + BookmarkStart.b("爭", num);
        }
        this.string_3 = this.string_2;
        this.dictionary_3 = new Dictionary<string, string>();
        string cssStyleSheetFileName = this.string_1 + BookmarkStart.b("焭䌯䘱䴳娵崷䤹ሻ崽㌿ㅁ", num);
        if (!string.IsNullOrEmpty(A_0.HtmlExportOptions.CssStyleSheetFileName))
        {
            this.bool_4 = true;
            cssStyleSheetFileName = A_0.HtmlExportOptions.CssStyleSheetFileName;
        }
        else
        {
            this.bool_4 = false;
        }
        if (!string.IsNullOrEmpty(A_0.HtmlExportOptions.ImagesPath))
        {
            if (!A_0.HtmlExportOptions.ImagesPath.EndsWith(BookmarkStart.b("爭", num)))
            {
                HtmlExportOptions htmlExportOptions = A_0.HtmlExportOptions;
                htmlExportOptions.ImagesPath = htmlExportOptions.ImagesPath + BookmarkStart.b("爭", num);
            }
            this.string_3 = A_0.HtmlExportOptions.ImagesPath;
        }
        if (A_0.HtmlExportOptions.CssStyleSheetType == CssStyleSheetType.External)
        {
            using (StreamWriter writer3 = File.CreateText(this.string_2 + cssStyleSheetFileName))
            {
                writer3.Write(this.method_22(A_0));
            }
        }
        this.paragraphStyle_0 = A_0.Styles.FindByName(BookmarkStart.b("怭弯䀱夳圵吷", num)) as ParagraphStyle;
        if (this.paragraphStyle_0 == null)
        {
            this.paragraphStyle_0 = A_0.Styles.FindByName(BookmarkStart.b("䀭弯䀱夳圵吷", num)) as ParagraphStyle;
        }
        using (this.xmlTextWriter_0 = new XmlTextWriter(A_1, Encoding.UTF8))
        {
            this.method_18(A_0, cssStyleSheetFileName);
        }
    }

    private string method_150(Borders A_0, StringBuilder A_1, bool A_2)
    {
        this.method_151(BookmarkStart.b("䘱嬳䘵", 12), A_0.Top, A_1, A_2);
        this.method_151(BookmarkStart.b("帱儳倵䰷", 12), A_0.Left, A_1, A_2);
        this.method_151(BookmarkStart.b("䀱崳儵倷丹", 12), A_0.Right, A_1, A_2);
        this.method_151(BookmarkStart.b("倱嬳䈵䰷唹儻", 12), A_0.Bottom, A_1, A_2);
        return A_1.ToString();
    }

    private void method_151(string A_0, Border A_1, StringBuilder A_2, bool A_3)
    {
        int num = 0x13;
        if (A_1.BorderType != BorderStyle.Cleared)
        {
            if (A_1.Color != Color.Empty)
            {
                A_2.Append(BookmarkStart.b("嬸吺似嬾⑀ㅂ桄", num) + A_0 + BookmarkStart.b("ᐸ堺刼匾⹀ㅂ罄", num) + this.method_147(A_1.Color) + BookmarkStart.b("ȸ", num));
            }
            else if (A_1.BorderType != BorderStyle.None)
            {
                A_2.Append(BookmarkStart.b("嬸吺似嬾⑀ㅂ桄", num) + A_0 + BookmarkStart.b("ᐸ堺刼匾⹀ㅂ罄摆祈筊経罎慐捒湔", num));
            }
            if (A_1.BorderType != BorderStyle.None)
            {
                A_2.Append(BookmarkStart.b("嬸吺似嬾⑀ㅂ桄", num) + A_0 + BookmarkStart.b("ᐸ䠺䤼䘾ⵀ♂罄", num) + this.method_155(A_1.BorderType) + BookmarkStart.b("ȸ", num));
            }
            else
            {
                A_2.Append(BookmarkStart.b("嬸吺似嬾⑀ㅂ桄", num) + A_0 + BookmarkStart.b("ᐸ䠺䤼䘾ⵀ♂罄杆❈⑊⍌⩎橐", num));
            }
            if (A_1.LineWidth > 0f)
            {
                float num2 = A_3 ? A_1.LineWidth : ((A_1.LineWidth * 25f) / 10f);
                num2 /= 0.75f;
                A_2.Append(BookmarkStart.b("嬸吺似嬾⑀ㅂ桄", num) + A_0 + BookmarkStart.b("ᐸ䰺吼嬾㕀⭂罄", num) + XmlConvert.ToString(Math.Round((double) num2, 2)) + BookmarkStart.b("䤸䌺ؼ", num));
            }
            if (A_1.Space > 0f)
            {
                A_2.Append(BookmarkStart.b("䤸娺夼嬾⡀ⵂ≄橆", num) + A_0 + BookmarkStart.b("̸", num) + XmlConvert.ToString(A_1.Space) + BookmarkStart.b("䤸伺ؼ", num));
            }
        }
    }

    private void method_152(Borders A_0, Borders A_1, StringBuilder A_2)
    {
        this.method_153(BookmarkStart.b("䜲娴䜶", 13), A_0.Top, A_1.Top, A_2);
        this.method_153(BookmarkStart.b("弲倴儶䴸", 13), A_0.Left, A_1.Left, A_2);
        this.method_153(BookmarkStart.b("䄲尴倶儸伺", 13), A_0.Right, A_1.Right, A_2);
        this.method_153(BookmarkStart.b("儲娴䌶䴸吺值", 13), A_0.Bottom, A_1.Bottom, A_2);
    }

    private void method_153(string A_0, Border A_1, Border A_2, StringBuilder A_3)
    {
        int num = 12;
        if (A_2 != A_1)
        {
            if (this.method_154(A_2, A_1))
            {
                this.method_151(A_0, A_2, A_3, true);
            }
        }
        else
        {
            if ((A_1.BorderType == BorderStyle.None) && !A_1.HasNoneStyle)
            {
                A_3.Append(BookmarkStart.b("倱嬳䐵尷弹主ጽ", num) + A_0 + BookmarkStart.b("ἱ䜳䈵䄷嘹夻н怿ㅁ⭃⩅ⅇ⹉睋", num));
            }
            if (A_1.LineWidth == 0f)
            {
                A_3.Append(BookmarkStart.b("倱嬳䐵尷弹主ጽ", num) + A_0 + BookmarkStart.b("ἱ䌳張尷丹吻н怿獁㑃㹅獇", num));
            }
            if (A_1.Color == Color.Empty)
            {
                A_3.Append(BookmarkStart.b("倱嬳䐵尷弹主ጽ", num) + A_0 + BookmarkStart.b("ἱ圳夵吷唹主н怿⁁⡃❅⭇ⅉ睋", num));
            }
        }
    }

    private bool method_154(Border A_0, Border A_1)
    {
        bool flag = false;
        if ((A_0.BorderType == BorderStyle.None) && A_0.HasNoneStyle)
        {
            return flag;
        }
        if ((A_1.BorderType != BorderStyle.None) && (A_1.BorderType != BorderStyle.Single))
        {
            return flag;
        }
        if ((A_0.BorderType == BorderStyle.None) || ((A_1.BorderType == A_0.BorderType) && (A_1.LineWidth == A_0.LineWidth)))
        {
            return flag;
        }
        return true;
    }

    private string method_155(BorderStyle A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case BorderStyle.None:
                return BookmarkStart.b("堯嬱倳刵崷吹", num);

            case BorderStyle.Single:
            case BorderStyle.Thick:
            case BorderStyle.Hairline:
            case BorderStyle.Wave:
            case BorderStyle.DashDotStroker:
                return BookmarkStart.b("䌯崱堳張尷", num);

            case BorderStyle.Double:
            case BorderStyle.Triple:
            case BorderStyle.ThinThickSmallGap:
            case BorderStyle.ThickThinSmallGap:
            case BorderStyle.ThinThickThinSmallGap:
            case BorderStyle.ThinThickMediumGap:
            case BorderStyle.ThickThinMediumGap:
            case BorderStyle.ThinThickThinMediumGap:
            case BorderStyle.ThinThickLargeGap:
            case BorderStyle.ThickThinLargeGap:
            case BorderStyle.ThinThickThinLargeGap:
            case BorderStyle.DoubleWave:
                return BookmarkStart.b("启崱䄳吵吷弹", num);

            case BorderStyle.Dot:
                return BookmarkStart.b("启崱䀳䈵崷帹", num);

            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
            case BorderStyle.DashSmallGap:
                return BookmarkStart.b("启匱䜳帵崷帹", num);

            case BorderStyle.Emboss3D:
                return BookmarkStart.b("䈯嬱倳儵崷", num);

            case BorderStyle.Engrave3D:
                return BookmarkStart.b("圯䀱嬳夵丷弹", num);

            case BorderStyle.Outset:
                return BookmarkStart.b("弯䜱䀳䔵崷丹", num);

            case BorderStyle.Inset:
                return BookmarkStart.b("夯就䜳匵䰷", num);
        }
        return BookmarkStart.b("䌯崱堳張尷", num);
    }

    private string method_156(string A_0)
    {
        A_0 = A_0.Trim();
        A_0 = this.method_157(A_0);
        if (A_0.StartsWith(BookmarkStart.b("ᠴ", 15)))
        {
            A_0 = A_0.Remove(0, 1);
        }
        return A_0;
    }

    private string method_157(string A_0)
    {
        int num = 0;
        int length = A_0.Length;
        while (num < length)
        {
            char c = A_0[num];
            if (!char.IsLetterOrDigit(c) && (A_0[num] != '-'))
            {
                A_0 = A_0.Replace(A_0[num], '-');
            }
            num++;
        }
        return A_0;
    }

    private void method_158(Image A_0, string A_1, int A_2, int A_3, bool A_4, ImageFormat A_5)
    {
        if (A_0 != null)
        {
            Image original = (Image) A_0.Clone();
            Bitmap image = null;
            if (A_4)
            {
                Metafile metafile = A_0 as Metafile;
                GraphicsUnit display = GraphicsUnit.Display;
                Size size = Size.Ceiling(metafile.GetBounds(ref display).Size);
                image = new Bitmap(size.Width, size.Height);
                image.SetResolution(metafile.HorizontalResolution, metafile.VerticalResolution);
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.DrawImageUnscaled(metafile, Point.Empty);
                    graphics.Dispose();
                }
                if (!this.bool_11)
                {
                    image.Save(this.string_3 + A_1, A_5);
                }
                else
                {
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, A_5);
                    this.method_12().Add(A_1, stream);
                }
            }
            else if (!this.bool_11)
            {
                new Bitmap(original, A_2, A_3).Save(this.string_3 + A_1, A_5);
            }
            else
            {
                MemoryStream stream2 = new MemoryStream();
                original.Save(stream2, A_5);
                this.method_12().Add(A_1, stream2);
            }
        }
    }

    private void method_159(CharacterFormat A_0)
    {
        int num = 10;
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䌯䈱唳堵", 10));
        string str = this.method_127(A_0);
        if (str.Length > 0)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䌯䘱䴳娵崷", num), str);
        }
        this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ᘯᄱ䰳圵࠷Ĺ", num));
        this.xmlTextWriter_0.WriteEndElement();
    }

    internal void method_16(Document A_0, Stream A_1, bool A_2)
    {
        int num = 0x12;
        this.document_0 = A_0;
        this.int_4 = 1;
        this.dictionary_4 = new Dictionary<string, Stream>();
        int ePubHeadingLevels = this.document_0.HtmlExportOptions.EPubHeadingLevels;
        this.string_8 = new string[ePubHeadingLevels];
        for (int i = 0; i < ePubHeadingLevels; i++)
        {
            this.string_8[i] = BookmarkStart.b("倷弹崻娽⤿ⱁ⍃", num) + (i + 1);
        }
        this.dictionary_5 = new Dictionary<string, string>();
        this.method_17(A_0, A_1);
    }

    private void method_160(string A_0)
    {
        int num2 = 0x11;
        if (A_0.Length > A_0.TrimStart(new char[] { ' ' }).Length)
        {
            int length = A_0.Length - A_0.TrimStart(new char[] { ' ' }).Length;
            A_0 = A_0.Substring(0, length).Replace(BookmarkStart.b("᜶", num2), BookmarkStart.b("ᄶ圸夺丼伾穀", num2)) + A_0.Substring(length);
            this.xmlTextWriter_0.WriteRaw(A_0);
        }
        else
        {
            StringBuilder builder = new StringBuilder(A_0, (int) (A_0.Length * 1.75));
            char ch = '\x001e';
            char ch2 = '\x001f';
            A_0 = builder.Replace(BookmarkStart.b("ᄶ", num2), BookmarkStart.b("ᄶ堸嘺䴼о", num2)).Replace(BookmarkStart.b("㸶", num2), BookmarkStart.b("ᄶ圸夺丼伾穀敂⭄╆㩈㭊癌楎㽐ㅒ♔❖托絚㍜㵞በ።幤䅦ݨ४ṬὮ䩰啲᭴ᕶ੸୺䙼奾늈궊꺔", num2)).Replace(BookmarkStart.b("ଶ", num2), BookmarkStart.b("ᄶ唸伺ؼ", num2)).Replace(BookmarkStart.b("श", num2), BookmarkStart.b("ᄶ常伺ؼ", num2)).Replace(ch.ToString(), BookmarkStart.b("ᄶᨸ̺༼༾础硂", num2)).Replace(ch2.ToString(), BookmarkStart.b("ᄶᨸ䌺尼嬾穀", num2)).ToString();
            this.xmlTextWriter_0.WriteRaw(A_0);
        }
    }

    private string method_161(string A_0)
    {
        int num = 5;
        int index = 0;
        int startIndex = 0;
        char ch = '\0';
        char[] chArray = new char[A_0.Length];
        chArray = A_0.ToCharArray();
        for (index = 0; index < chArray.Length; index++)
        {
            if (index >= 1)
            {
                ch = chArray[index - 1];
            }
            char ch2 = chArray[index];
            if ((ch == ' ') && (ch2 == ' '))
            {
                A_0 = A_0.Remove(startIndex, 1);
                A_0 = A_0.Insert(startIndex, BookmarkStart.b("പ䌬䴮䈰䌲ิ", num));
                startIndex += 6;
            }
            else
            {
                startIndex++;
            }
        }
        return A_0;
    }

    private string method_162()
    {
        int num = 8;
        string str = string.Empty;
        for (int i = 0; i < 14; i++)
        {
            str = str + BookmarkStart.b("࠭帯倱䜳䘵̷", num);
        }
        return str;
    }

    private string method_163(Style A_0, Document A_1)
    {
        int num = 10;
        List<string> list = new List<string>();
        string str = string.Empty;
        if (A_0 != null)
        {
            list.Add(A_0.Name);
            this.method_164(A_0.BaseStyle as Style, list, A_1);
            for (int i = list.Count - 1; i >= 0; i--)
            {
                str = str + this.method_156(list[i]);
                if (i > 0)
                {
                    str = str + BookmarkStart.b("ု", num);
                }
            }
        }
        return str;
    }

    private void method_164(Style A_0, List<string> A_1, Document A_2)
    {
        int num = 10;
        if (((A_0 != null) && (A_0.StyleDocId != 0)) && !A_0.Name.StartsWith(BookmarkStart.b("縯崱䘳嬵夷嘹", num)))
        {
            A_1.Add(A_0.Name);
            if (A_0.BaseStyle != null)
            {
                this.method_164(A_0.BaseStyle as Style, A_1, A_2);
            }
        }
    }

    private bool method_165(ParagraphFormat A_0, bool A_1)
    {
        if ((A_0.OwnerBase != null) && (A_0.OwnerBase.OwnerBase is TableCell))
        {
            return !A_1;
        }
        return true;
    }

    private bool method_166(ParagraphFormat A_0)
    {
        return A_0.HasValue(0x672);
    }

    private void method_167(int A_0)
    {
        int num = 8;
        if (this.int_2 >= 0)
        {
            this.xmlTextWriter_0.WriteEndElement();
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("⌭㨯", num));
        }
        this.int_2 = -1;
    }

    private void method_168(ListPatternType A_0, ListFormat A_1)
    {
        int num = 4;
        string str = null;
        switch (A_0)
        {
            case ListPatternType.UpRoman:
                str = BookmarkStart.b("挩", num);
                break;

            case ListPatternType.LowRoman:
                str = BookmarkStart.b("䌩", num);
                break;

            case ListPatternType.UpLetter:
                str = BookmarkStart.b("欩", num);
                break;

            case ListPatternType.LowLetter:
                str = BookmarkStart.b("䬩", num);
                break;

            case ListPatternType.Bullet:
                switch (A_1.CurrentListLevel.LevelNumber)
                {
                    case 0:
                        str = BookmarkStart.b("丩䔫崭匯", num);
                        goto Label_0106;

                    case 1:
                        str = BookmarkStart.b("䤩䔫尭匯帱儳", num);
                        goto Label_0106;

                    case 2:
                        str = BookmarkStart.b("天崫嬭儯䀱儳", num);
                        goto Label_0106;

                    case 3:
                        str = BookmarkStart.b("丩䔫崭匯", num);
                        goto Label_0106;

                    case 4:
                        str = BookmarkStart.b("䤩䔫尭匯帱儳", num);
                        goto Label_0106;

                    case 5:
                        str = BookmarkStart.b("天崫嬭儯䀱儳", num);
                        goto Label_0106;
                }
                str = BookmarkStart.b("丩䔫崭匯", num);
                break;

            default:
                str = BookmarkStart.b("ᬩ", num);
                break;
        }
    Label_0106:
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帩唫席唯", num), str);
    }

    private int method_169(ListFormat A_0)
    {
        if ((A_0.ListType != ListType.NoList) && A_0.HasKey(1))
        {
            return A_0.ListLevelNumber;
        }
        return -1;
    }

    public void method_17(Document A_0, Stream A_1)
    {
        int num = 7;
        this.document_0 = A_0;
        if (!A_0.HtmlExportOptions.ImagesPath.EndsWith(BookmarkStart.b("焬", 7)))
        {
            HtmlExportOptions htmlExportOptions = A_0.HtmlExportOptions;
            htmlExportOptions.ImagesPath = htmlExportOptions.ImagesPath + BookmarkStart.b("焬", num);
        }
        this.string_2 = A_0.HtmlExportOptions.ImagesPath;
        this.string_3 = this.string_2;
        this.dictionary_3 = new Dictionary<string, string>();
        this.paragraphStyle_0 = A_0.Styles.FindByName(BookmarkStart.b("挬䀮䌰帲吴嬶", num)) as ParagraphStyle;
        if (this.paragraphStyle_0 == null)
        {
            this.paragraphStyle_0 = A_0.Styles.FindByName(BookmarkStart.b("䌬䀮䌰帲吴嬶", num)) as ParagraphStyle;
        }
        this.xmlTextWriter_0 = new XmlTextWriter(A_1, Encoding.UTF8);
        if (!this.bool_11)
        {
            this.method_18(A_0, string.Empty);
        }
        else
        {
            this.method_18(A_0, A_0.HtmlExportOptions.CssStyleSheetFileName);
        }
        this.xmlTextWriter_0.Flush();
    }

    private int method_170(ListFormat A_0)
    {
        if (A_0.CurrentListLevel.PatternType == ListPatternType.Bullet)
        {
            return 1;
        }
        if (!this.method_2().ContainsKey(A_0.CustomStyleName))
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            this.method_2().Add(A_0.CustomStyleName, dictionary);
            ListLevel level = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
            for (int i = 0; i <= level.LevelNumber; i++)
            {
                dictionary.Add(i, A_0.CurrentListStyle.Levels[i].StartAt + 1);
            }
            return level.StartAt;
        }
        Dictionary<int, int> dictionary2 = this.method_2()[A_0.CustomStyleName];
        if (dictionary2.ContainsKey(A_0.ListLevelNumber))
        {
            int num3 = dictionary2[A_0.ListLevelNumber];
            dictionary2[A_0.ListLevelNumber] = num3 + 1;
            for (int j = A_0.ListLevelNumber; dictionary2.ContainsKey(j + 1); j++)
            {
                dictionary2[j + 1] = 1;
            }
            return num3;
        }
        ListLevel level2 = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
        dictionary2.Add(A_0.ListLevelNumber, level2.StartAt + 1);
        return level2.StartAt;
    }

    private void method_171(ListFormat A_0, bool A_1)
    {
        if ((this.dictionary_2 != null) && this.method_2().ContainsKey(A_0.CustomStyleName))
        {
            Dictionary<int, int> dictionary = this.method_2()[A_0.CustomStyleName];
            ICollection keys = dictionary.Keys;
            IEnumerator enumerator = keys.GetEnumerator();
            int count = keys.Count;
            int[] numArray = new int[count];
            for (int i = 0; enumerator.MoveNext(); i++)
            {
                numArray[i] = (int) enumerator.Current;
            }
            for (int j = 0; j < count; j++)
            {
                if (A_1 || ((numArray[j] != 0) && !A_0.CurrentListStyle.Levels[numArray[j]].NoRestartByHigher))
                {
                    dictionary[numArray[j]] = A_0.CurrentListStyle.Levels[numArray[j]].StartAt;
                }
            }
        }
    }

    private float method_172(TextureStyle A_0)
    {
        switch (A_0)
        {
            case TextureStyle.TextureSolid:
                return 100f;

            case TextureStyle.Texture5Percent:
            case TextureStyle.Texture2Pt5Percent:
            case TextureStyle.Texture7Pt5Percent:
                return 5f;

            case TextureStyle.Texture10Percent:
                return 10f;

            case TextureStyle.Texture20Percent:
                return 20f;

            case TextureStyle.Texture25Percent:
            case TextureStyle.Texture27Pt5Percent:
                return 27.5f;

            case TextureStyle.Texture30Percent:
            case TextureStyle.Texture32Pt5Percent:
                return 32.5f;

            case TextureStyle.Texture40Percent:
            case TextureStyle.Texture42Pt5Percent:
                return 40f;

            case TextureStyle.Texture50Percent:
            case TextureStyle.Texture52Pt5Percent:
                return 50f;

            case TextureStyle.Texture60Percent:
                return 60f;

            case TextureStyle.Texture70Percent:
            case TextureStyle.Texture72Pt5Percent:
                return 70f;

            case TextureStyle.Texture75Percent:
            case TextureStyle.Texture77Pt5Percent:
                return 75f;

            case TextureStyle.Texture80Percent:
            case TextureStyle.Texture82Pt5Percent:
                return 80f;

            case TextureStyle.Texture90Percent:
            case TextureStyle.Texture92Pt5Percent:
                return 90f;

            case TextureStyle.Texture12Pt5Percent:
                return 12.5f;

            case TextureStyle.Texture15Percent:
                return 15f;

            case TextureStyle.Texture17Pt5Percent:
                return 17.5f;

            case TextureStyle.Texture35Percent:
                return 35f;

            case TextureStyle.Texture37Pt5Percent:
                return 37.5f;

            case TextureStyle.Texture45Percent:
            case TextureStyle.Texture47Pt5Percent:
                return 45f;

            case TextureStyle.Texture55Percent:
            case TextureStyle.Texture57Pt5Percent:
                return 55f;

            case TextureStyle.Texture62Pt5Percent:
                return 62.5f;

            case TextureStyle.Texture65Percent:
            case TextureStyle.Texture67Pt5Percent:
                return 65f;

            case TextureStyle.Texture85Percent:
                return 85f;

            case TextureStyle.Texture87Pt5Percent:
                return 87.5f;

            case TextureStyle.Texture95Percent:
            case TextureStyle.Texture97Pt5Percent:
                return 95f;
        }
        return 0f;
    }

    private ListFormat method_173(Paragraph A_0)
    {
        if (A_0.ListFormat.IsEmptyList)
        {
            return A_0.ListFormat;
        }
        return A_0.GetListFormatForApplyStyle();
    }

    private int method_174(ParagraphFormat A_0)
    {
        switch (A_0.OutlineLevel)
        {
            case OutlineLevel.Level1:
                return 0;

            case OutlineLevel.Level2:
                return 1;

            case OutlineLevel.Level3:
                return 2;

            case OutlineLevel.Level4:
                return 3;

            case OutlineLevel.Level5:
                return 4;

            case OutlineLevel.Level6:
                return 5;

            case OutlineLevel.Level7:
                return 6;

            case OutlineLevel.Level8:
                return 7;

            case OutlineLevel.Level9:
                return 8;
        }
        return -1;
    }

    private void method_175(Paragraph A_0)
    {
        int num = 8;
        if (this.bool_12 && !string.IsNullOrEmpty(A_0.Text))
        {
            if (this.document_0.HasTOC && !this.document_0.TOC.UseHeadingStyles)
            {
                using (Dictionary<int, ParagraphStyle>.KeyCollection.Enumerator enumerator = this.document_0.TOC.TOCStyles.Keys.GetEnumerator())
                {
                    int current;
                    string str;
                    while (enumerator.MoveNext())
                    {
                        current = enumerator.Current;
                        if ((this.document_0.TOC.TOCStyles[current].Name == A_0.StyleName) && (current <= this.document_0.HtmlExportOptions.EPubHeadingLevels))
                        {
                            goto Label_00B2;
                        }
                    }
                    return;
                Label_00B2:
                    str = this.method_179();
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜭启", num), str);
                    this.dictionary_5.Add(string.Format(BookmarkStart.b("唭/伱༳䴵ष䜹", num), current, str), this.method_177(A_0.Text));
                    return;
                }
            }
            if (this.method_176(A_0.StyleName))
            {
                int num2 = this.method_178(A_0.StyleName);
                if (num2 <= this.document_0.HtmlExportOptions.EPubHeadingLevels)
                {
                    string str2 = this.method_179();
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜭启", num), str2);
                    this.dictionary_5.Add(string.Format(BookmarkStart.b("唭/伱༳䴵ष䜹", num), num2.ToString(), str2), this.method_177(A_0.Text));
                }
            }
        }
    }

    private bool method_176(string A_0)
    {
        int num = 0x12;
        foreach (string str in this.string_8)
        {
            if (A_0.ToLower().Replace(BookmarkStart.b("ᠷ", num), string.Empty).Contains(str))
            {
                return true;
            }
        }
        return false;
    }

    private string method_177(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("㌷", 0x12), string.Empty);
        return A_0;
    }

    private int method_178(string A_0)
    {
        int num = 14;
        if (A_0.Contains(BookmarkStart.b("ᠳ", 14)))
        {
            A_0 = A_0.Split(new char[] { ',' })[0];
        }
        if (A_0.Contains(BookmarkStart.b("ἳ", num)))
        {
            A_0 = A_0.Split(new char[] { '+' })[0];
        }
        char[] chArray4 = A_0.ToCharArray();
        string s = "";
        foreach (char ch in chArray4)
        {
            int num3;
            if (ch == '_')
            {
                break;
            }
            if (int.TryParse(ch.ToString(), out num3))
            {
                s = s + num3.ToString();
            }
        }
        return int.Parse(s);
    }

    internal string method_179()
    {
        return (BookmarkStart.b("堵夷䰹挻渽⼿⭁⩃㉅", 0x10) + this.int_4++);
    }

    private void method_18(Document A_0, string A_1)
    {
        this.method_19(A_0, A_1);
        this.method_20(A_0);
        this.xmlTextWriter_0.WriteEndElement();
    }

    private void method_19(Document A_0, string A_1)
    {
        int num = 11;
        this.xmlTextWriter_0.WriteDocType(BookmarkStart.b("夰䜲場嬶", 11), BookmarkStart.b("ᰰᰲᨴ怶ਸ砺ሼှՀᝂń杆ᅈ͊᥌Ɏᵐ獒摔祖桘瑚牜ᩞ⽠", 11), BookmarkStart.b("夰䜲䄴䜶̸ᐺሼ䠾㙀㑂歄う穈敊≌㵎㙐籒ŔՖ癘⍚㕜⭞ౠར呤噦䙨⽪㥬⭮幰୲ᵴͶᑸ᝺䱼乾꾀", 11), null);
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("夰䜲場嬶", 11), BookmarkStart.b("夰䜲䄴䜶̸ᐺሼ䠾㙀㑂歄う穈敊≌㵎㙐籒摔湖恘扚牜❞ॠᝢࡤ୦", 11));
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("夰嘲吴匶", 11));
        this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ര帲倴䌶堸ᬺ唼䬾㕀㍂桄≆㡈㹊⑌㥎汐煒ᙔ㡖㝘⽚㡜ㅞᕠ乢ㅤṦᥨ๪佬佮ተᱲ᭴Ͷᱸᕺॼ䉾ꎀ朗杖練뚘철쾢躤\udfa6\uc4a8잪隬辮튰\udbb2\ud4b4얶쪸\udeba\uc9bc芾듀럂ꏄ", 11));
        this.xmlTextWriter_0.WriteRaw(string.Format(BookmarkStart.b("ര䜲尴䌶唸帺̼䐾煀㹂祄框㵈≊㥌⍎㑐浒", 11), A_0.BuiltinDocumentProperties.Title));
        if ((A_0.HtmlExportOptions.CssStyleSheetType != CssStyleSheetType.Internal) && !string.IsNullOrEmpty(A_1))
        {
            if (this.bool_11)
            {
                this.memoryStream_0 = new MemoryStream();
                StreamWriter writer = new StreamWriter(this.memoryStream_0);
                writer.Write(this.method_22(A_0));
                writer.Flush();
            }
            this.xmlTextWriter_0.WriteRaw(string.Format(BookmarkStart.b("ര弲尴夶券ᬺ唼䴾⑀╂硄敆㉈筊が济煐❒ⱔ❖㱘晚罜⭞Ѡ᭢ᅤ䡦੨ᡪṬ䵮兰Ųၴ᭶䑸奺๼୾ﮎ뎐벒ꮔ", num), A_1));
        }
        else
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䈰䜲䰴嬶尸", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䔰䨲䔴制", num), BookmarkStart.b("䔰嘲䴴䌶ᘸ堺丼䰾", num));
            this.xmlTextWriter_0.WriteRaw(this.method_22(A_0));
            this.xmlTextWriter_0.WriteEndElement();
        }
        this.xmlTextWriter_0.WriteEndElement();
    }

    private Dictionary<string, Dictionary<int, int>> method_2()
    {
        if (this.dictionary_2 == null)
        {
            this.dictionary_2 = new Dictionary<string, Dictionary<int, int>>();
        }
        return this.dictionary_2;
    }

    private void method_20(Document A_0)
    {
        int num = 8;
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䰭弯嘱䴳", 8));
        this.bool_6 = true;
        StringBuilder builder = new StringBuilder();
        if (A_0.Background.Type == BackgroundType.Picture)
        {
            ImageFormat format = this.method_78(A_0.Background.Picture);
            string str = BookmarkStart.b("-", num) + format.ToString().ToLower();
            if (!A_0.HtmlExportOptions.ImageEmbedded)
            {
                string str4 = this.method_109() + str;
                this.method_108();
                this.method_158(A_0.Background.Picture, str4, A_0.Background.Picture.Width, A_0.Background.Picture.Height, false, format);
                builder.Append(string.Format(BookmarkStart.b("䰭儯儱弳儵䨷唹䤻倽␿潁ⵃ⭅⥇ⵉ⥋瑍╏⁑㡓繕⍗橙⅛睝孟", num), str4.Replace('\\', '/')));
            }
            else
            {
                string str3 = Convert.ToBase64String(A_0.Background.ImageBytes);
                builder.Append(string.Format(BookmarkStart.b("䰭儯儱弳儵䨷唹䤻倽␿潁ⵃ⭅⥇ⵉ⥋瑍╏⁑㡓繕㱗㭙⡛㽝婟ᥡ呣᭥卧ࡩ൫ᵭᕯ䑱䁳婵ͷ䭹Ż坽뭿", num), this.method_79(A_0.Background.Picture), str3));
            }
        }
        if (!A_0.Background.Color.IsEmpty)
        {
            Color color = A_0.Background.Color;
            if (((color.A != 0xff) || (color.R != 0xff)) || ((color.G != 0xff) || (color.B != 0xff)))
            {
                builder.Append(BookmarkStart.b("䰭儯儱弳儵䨷唹䤻倽␿潁❃⥅⑇╉㹋瑍", num) + this.method_147(color) + BookmarkStart.b("ᔭ", num));
            }
        }
        string str2 = this.method_21(A_0);
        builder.Append(str2);
        if (builder.Length != 0)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("崭䐯䬱堳匵", num), builder.ToString());
        }
        foreach (Section section in A_0.Sections)
        {
            this.method_24(section);
            this.method_25(FootnoteType.Footnote);
            this.int_3++;
        }
        this.bool_6 = true;
        this.method_25(FootnoteType.Endnote);
        this.xmlTextWriter_0.WriteEndElement();
    }

    private string method_21(Document A_0)
    {
        int num = 5;
        StringBuilder builder = new StringBuilder();
        if ((A_0 != null) && (A_0.Sections.Count > 0))
        {
            PageSetup pageSetup = A_0.Sections[0].PageSetup;
            builder.Append(BookmarkStart.b("嬪䰬䠮吰䐲尴匶䴸区ܼ", num) + pageSetup.PageSize.Width + BookmarkStart.b("嬪夬ᐮ", num));
            builder.Append(BookmarkStart.b("嬪䰬䠮吰嬲倴帶常区䤼Ծ", num) + pageSetup.PageSize.Height + BookmarkStart.b("嬪夬ᐮ", num));
            if ((pageSetup.LinePitch > 0f) && (pageSetup.PitchType != GridPitchType.NoGrid))
            {
                builder.Append(BookmarkStart.b("伪䈬䰮嘰䄲尴匶䴸䈺䴼娾筀", num));
                switch (pageSetup.PitchType)
                {
                    case GridPitchType.CharsAndLine:
                        builder.Append(BookmarkStart.b("䜪䐬䄮吰䀲吴夶崸堺唼帾㍀あ繄", num));
                        break;

                    case GridPitchType.LinesOnly:
                        builder.Append(BookmarkStart.b("䜪䐬䄮吰䀲ิ", num));
                        break;

                    case GridPitchType.SnapToChars:
                        builder.Append(BookmarkStart.b("堪䌬丮䄰䜲娴吶儸娺似䰾穀", num));
                        break;
                }
                builder.Append(BookmarkStart.b("伪䈬䰮嘰䄲尴匶唸刺匼娾ㅀ⩂ㅄ⑆ⅈ煊", num) + pageSetup.LinePitch + BookmarkStart.b("嬪夬ᐮ", num));
            }
        }
        return builder.ToString();
    }

    private string method_22(Document A_0)
    {
        int num = 0;
        StringBuilder builder = new StringBuilder();
        if (A_0.HtmlExportOptions.EPubExportFont && (A_0.HtmlExportOptions.FontFiles != null))
        {
            foreach (string str3 in A_0.HtmlExportOptions.FontFiles)
            {
                this.method_23(builder, str3);
            }
        }
        this.method_23(builder, BookmarkStart.b("䐥䜧丩唫唭ု吱嬳堵䰷᜹娻弽ⴿ⭁⡃㽅片浉ᡋ❍㵏㝑❓癕ᙗ㽙⭛繝㉟ൡॣݥ٧䵩坫乭ᙯᵱᩳɵ啷ॹᕻѽ뢁떃놉겋", num));
        if (A_0.DefParaFormat != null)
        {
            string str = BookmarkStart.b("嘥ࠧ儩尫伭启嘱崳堵強9఻Խ", num) + string.Format(BookmarkStart.b("䬥䤧堩䬫䜭帯ἱ䀳夵䠷9䜻฽㴿祁⥃❅㩇ⵉ╋⁍絏⁑㵓ㅕし⹙晛湝孟ཡգᑥཧͩɫ䍭ቯᵱsɵ᝷᝹䙻ս녿ﾁ뾃ﺏ뾑ﺗꚛ꺝鮟", num), A_0.DefParaFormat.BeforeSpacing, A_0.DefParaFormat.AfterSpacing) + BookmarkStart.b("嬥", num);
            this.method_23(builder, str);
        }
        this.method_23(builder, BookmarkStart.b("匥䐧ةఫ䄭尯䤱ᐳ嬵夷䠹嬻圽⸿潁ぃ⥅㡇灉汋繍歏牑㥓㝕⩗㵙㕛そ䵟aୣብᱧթū呭偯䉱佳噵շ", num));
        foreach (Style style in A_0.Styles)
        {
            string str2 = string.Empty;
            builder.Append(BookmarkStart.b("ࠥ", num));
            builder.Append(this.method_156(style.Name));
            builder.Append(BookmarkStart.b("崥", num));
            switch (style.StyleType)
            {
                case StyleType.ParagraphStyle:
                {
                    ParagraphStyle style2 = style as ParagraphStyle;
                    str2 = this.method_123(null, style2.ParagraphFormat, false, null) + this.method_127(style2.CharacterFormat);
                    break;
                }
                case StyleType.CharacterStyle:
                {
                    Class11 class2 = style as Class11;
                    str2 = this.method_127(class2.CharacterFormat);
                    break;
                }
            }
            builder.Append(str2);
            if (!this.dictionary_3.ContainsKey(style.Name))
            {
                this.dictionary_3.Add(style.Name, str2);
            }
            this.method_23(builder, BookmarkStart.b("嬥", num));
        }
        return builder.ToString();
    }

    private void method_23(StringBuilder A_0, string A_1)
    {
        A_0.AppendLine(A_1);
    }

    private void method_24(Section A_0)
    {
        int num = 3;
        bool hasHeadersFooters = A_0.Document.HtmlExportOptions.HasHeadersFooters;
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䴨䈪嬬", 3));
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䨨䜪䰬尮䈰", 3), BookmarkStart.b("稨个丬嬮堰尲嬴", 3) + A_0.method_5().ToString());
        if ((A_0.PreviousSibling != null) && (A_0.BreakCode == SectionBreakType.NewPage))
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娨弪听䌮吰", num), BookmarkStart.b("䨨䜪䠬丮䌰लᔴ唶嘸伺唼о慀㍂⑄⁆ⱈ晊⽌㵎㑐㉒㹔穖㭘㹚㭜ぞ፠٢彤䝦ࡨݪᩬ๮ࡰr", num));
        }
        if (hasHeadersFooters && this.bool_6)
        {
            if (this.bool_13)
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䴨䈪嬬", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娨弪听䌮吰", num), BookmarkStart.b("䴨䈪帬弮崰刲䰴ശᤸ吺堼崾汀㍂⑄⁆ⱈ晊╌⩎ぐ㝒", num));
            }
            else
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䴨䈪嬬", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娨弪听䌮吰", num), string.Format(BookmarkStart.b("䐨䈪䌬Ȯ夰嘲尴倶儸伺ܼ䐾煀㹂㕄㍆", num), A_0.PageSetup.Margins.Top));
            }
            if (A_0.PageSetup.DifferentFirstPageHeaderFooter)
            {
                foreach (BodyRegion region4 in A_0.HeadersFooters.FirstPageHeader.Items)
                {
                    this.method_26(region4);
                }
            }
            else
            {
                foreach (BodyRegion region3 in A_0.HeadersFooters.OddHeader.Items)
                {
                    this.method_26(region3);
                }
            }
            this.xmlTextWriter_0.WriteEndElement();
        }
        foreach (BodyRegion region in A_0.Body.Items)
        {
            this.method_26(region);
        }
        if (hasHeadersFooters && (A_0.NextSibling == null))
        {
            A_0 = A_0.Document.Sections[0];
            if (this.bool_13)
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䴨䈪嬬", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娨弪听䌮吰", num), BookmarkStart.b("䴨䈪帬弮崰刲䰴ശᤸ吺堼崾汀㍂⑄⁆ⱈ晊⭌⁎㹐❒", num));
            }
            if (A_0.PageSetup.DifferentFirstPageHeaderFooter)
            {
                foreach (BodyRegion region5 in A_0.HeadersFooters.FirstPageFooter.Items)
                {
                    this.method_26(region5);
                }
            }
            else
            {
                foreach (BodyRegion region2 in A_0.HeadersFooters.OddFooter.Items)
                {
                    this.method_26(region2);
                }
            }
            if (this.bool_13)
            {
                this.xmlTextWriter_0.WriteEndElement();
            }
        }
        this.xmlTextWriter_0.WriteEndElement();
        this.bool_6 = false;
    }

    private void method_25(FootnoteType A_0)
    {
        int num = 10;
        Dictionary<int, Footnote> dictionary = (A_0 == FootnoteType.Footnote) ? this.dictionary_0 : this.dictionary_1;
        if ((dictionary != null) && (dictionary.Count > 0))
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堯䀱", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯崱䜳帵夷帹夻", num), BookmarkStart.b("帯崱䜳帵夷帹夻", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("儯帱崳儵嘷", num), BookmarkStart.b("尯圱刳䈵", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䌯䘱䴳娵崷", num), BookmarkStart.b("䜯嬱倳䈵倷9฻ଽ政祁", num));
            this.xmlTextWriter_0.WriteEndElement();
            string str = null;
            Footnote footnote = null;
            foreach (int num2 in dictionary.Keys)
            {
                str = (num2 + 1).ToString();
                footnote = dictionary[num2];
                if (A_0 == FootnoteType.Footnote)
                {
                    this.string_4 = string.Concat(new object[] { BookmarkStart.b("漯吱䀳堵䨷弹娻", num), this.int_3, BookmarkStart.b("漯", num), str });
                    this.string_5 = string.Concat(new object[] { BookmarkStart.b("ጯ洱刳䈵嘷䠹夻堽ᐿ❁㱃㉅", num), this.int_3, BookmarkStart.b("漯", num), str });
                }
                else
                {
                    this.string_4 = BookmarkStart.b("漯圱倳堵䨷弹娻", num) + str;
                    this.string_5 = BookmarkStart.b("ጯ洱儳刵嘷䠹夻堽ᐿ❁㱃㉅", num) + str;
                }
                this.string_6 = BookmarkStart.b("欯", num) + str + BookmarkStart.b("洯ሱ", num);
                foreach (BodyRegion region in footnote.TextBody.Items)
                {
                    this.paragraph_0 = region as Paragraph;
                    this.method_26(region);
                }
            }
            if (A_0 == FootnoteType.Footnote)
            {
                this.dictionary_0.Clear();
            }
        }
    }

    private void method_26(BodyRegion A_0)
    {
        if (A_0.DocumentObjectType == DocumentObjectType.Paragraph)
        {
            this.method_27(A_0 as Paragraph);
        }
        else if (A_0.DocumentObjectType == DocumentObjectType.Table)
        {
            this.method_92(A_0 as Table);
        }
        else if (A_0.DocumentObjectType == DocumentObjectType.StructureDocumentTag)
        {
            BodyRegion region = null;
            Body sDTContent = (A_0 as StructureDocumentTag).SDTContent;
            for (int i = 0; i < sDTContent.Items.Count; i++)
            {
                region = sDTContent.Items[i];
                this.method_26(region);
            }
        }
    }

    private void method_27(Paragraph A_0)
    {
        int num = 12;
        this.paragraph_0 = A_0;
        ParagraphBase base2 = null;
        if (((A_0.Items.Count > 0) && (A_0.Items[0].DocumentObjectType == DocumentObjectType.Break)) && !A_0.IsInCell)
        {
            base2 = A_0.Items[0];
            this.method_46(base2);
        }
        ParagraphBase base4 = null;
        this.method_53(A_0);
        this.method_51();
        bool flag2 = false;
        if ((A_0.Items.Count == 0) && (A_0.Document.Watermark.Type != WatermarkType.NoWatermark))
        {
            HeaderFooter footer;
            TableCell ownerTextBody = A_0.OwnerTextBody as TableCell;
            if (ownerTextBody != null)
            {
                footer = ownerTextBody.OwnerRow.OwnerTable.OwnerTextBody as HeaderFooter;
            }
            else
            {
                footer = A_0.OwnerTextBody as HeaderFooter;
            }
            if (footer != null)
            {
                WatermarkBase watermark = footer.Watermark;
                if (((watermark != null) && footer.WriteWatermark) && (watermark.Type == WatermarkType.PictureWatermark))
                {
                    this.method_72((watermark as PictureWatermark).WordPicture, A_0);
                }
            }
            else
            {
                this.method_159(A_0.BreakCharacterFormat);
            }
        }
        else if (A_0.Items.Count == 0)
        {
            this.method_159(A_0.BreakCharacterFormat);
        }
        bool flag = false;
        foreach (ParagraphBase base3 in A_0.Items)
        {
            if (this.bool_2)
            {
                if (((base3.DocumentObjectType != DocumentObjectType.FieldMark) || ((base3 as FieldMark).Type != FieldMarkType.FieldEnd)) && ((base3.DocumentObjectType != DocumentObjectType.FieldMark) || ((base3 as FieldMark).Type != FieldMarkType.FieldSeparator)))
                {
                    continue;
                }
                this.bool_2 = false;
            }
            if (this.bool_5)
            {
                if ((base3.DocumentObjectType == DocumentObjectType.FieldMark) && ((base3 as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    this.xmlTextWriter_0.WriteEndElement();
                    this.bool_5 = false;
                    flag = false;
                }
                else
                {
                    if (!flag && (base3.DocumentObjectType == DocumentObjectType.TextRange))
                    {
                        flag2 = true;
                        this.method_81(base3 as TextRange);
                    }
                    else if (base3.DocumentObjectType == DocumentObjectType.Picture)
                    {
                        this.method_71(base3 as DocPicture);
                    }
                    else if ((base3 is Field) && ((base3 as Field).Type == FieldType.FieldPageRef))
                    {
                        flag = true;
                    }
                    continue;
                }
            }
            if (this.bool_3)
            {
                if ((base3.DocumentObjectType != DocumentObjectType.FieldMark) || ((base3 as FieldMark).Type != FieldMarkType.FieldEnd))
                {
                    continue;
                }
                this.bool_3 = false;
            }
            this.method_28(base3, ref flag2, ref base4);
        }
        if ((A_0.Items.Count > 0) && !flag2)
        {
            this.method_159(A_0.BreakCharacterFormat);
        }
        this.xmlTextWriter_0.WriteEndElement();
        if ((base4 != null) && (base4 != base2))
        {
            this.method_46(base4);
        }
        this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("㼱㸳", num));
    }

    private void method_28(ParagraphBase A_0, ref bool A_1, ref ParagraphBase A_2)
    {
        int num = 1;
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.StructureDocumentTagInline:
                foreach (ParagraphBase base2 in (A_0 as StructureDocumentTagInline).SDTContent.ChildObjects)
                {
                    this.method_28(base2, ref A_1, ref A_2);
                }
                return;

            case DocumentObjectType.StructureDocumentTagRow:
            case DocumentObjectType.StructureDocumentTagCell:
            case DocumentObjectType.SDTBlockContent:
            case DocumentObjectType.SDTInlineContent:
            case DocumentObjectType.SDTRowContent:
            case DocumentObjectType.SDTCellContent:
            case DocumentObjectType.Table:
            case DocumentObjectType.TableRow:
            case DocumentObjectType.TableCell:
            case DocumentObjectType.FieldMark:
            case DocumentObjectType.SeqField:
            case DocumentObjectType.EmbededField:
            case DocumentObjectType.ControlField:
            case DocumentObjectType.PermissionStart:
            case DocumentObjectType.PermissionEnd:
            case DocumentObjectType.ShapeGroup:
            case DocumentObjectType.ShapeLine:
            case DocumentObjectType.ShapePath:
            case DocumentObjectType.ShapeRect:
            case DocumentObjectType.TOC:
            case DocumentObjectType.XmlParaItem:
            case DocumentObjectType.Undefined:
                return;

            case DocumentObjectType.TextRange:
                A_1 = true;
                this.method_81(A_0 as TextRange);
                return;

            case DocumentObjectType.Picture:
                this.method_71(A_0 as DocPicture);
                return;

            case DocumentObjectType.Field:
                this.method_69(A_0 as Field);
                return;

            case DocumentObjectType.MergeField:
                this.method_91(A_0 as MergeField);
                return;

            case DocumentObjectType.TextFormField:
            case DocumentObjectType.DropDownFormField:
            case DocumentObjectType.CheckBox:
                this.method_52(A_0 as FormField);
                return;

            case DocumentObjectType.BookmarkStart:
                this.method_32((A_0 as BookmarkStart).Name);
                if (!this.document_0.HTMLSentenceIdentifier || !this.method_39((A_0 as BookmarkStart).Name))
                {
                    this.method_68(A_0 as BookmarkStart);
                    break;
                }
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("否夨䨪䌬", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("否ጨ䠪䄬丮䈰䀲", num), BookmarkStart.b("否䰨䔪夬䨮弰倲倴", num));
                this.bool_16 = true;
                this.method_68(A_0 as BookmarkStart);
                break;

            case DocumentObjectType.BookmarkEnd:
                if (this.bool_10)
                {
                    if (this.list_1.Contains((A_0 as BookmarkEnd).Name))
                    {
                        this.xmlTextWriter_0.WriteEndElement();
                        this.list_1.Remove((A_0 as BookmarkEnd).Name);
                    }
                    this.stack_0.Pop();
                    this.bool_10 = (this.stack_0.Count > 0) ? this.stack_0.Peek() : false;
                }
                return;

            case DocumentObjectType.Shape:
                this.method_29(A_0 as ShapeObject);
                return;

            case DocumentObjectType.Comment:
                if (this.document_0.HTMLCustomComment && !this.dictionary_8.ContainsKey((A_0 as Comment).Format.CommentId))
                {
                    this.method_33(A_0 as Comment);
                }
                return;

            case DocumentObjectType.Footnote:
                this.method_50(A_0 as Footnote);
                return;

            case DocumentObjectType.TextBox:
                this.method_47(A_0 as TextBox);
                return;

            case DocumentObjectType.Break:
                if (!this.method_45(A_0))
                {
                    A_2 = A_0;
                    return;
                }
                this.method_46(A_0);
                return;

            case DocumentObjectType.Symbol:
            {
                string data = BookmarkStart.b("Ħਨ", num) + (A_0 as Symbol).CharacterCode.ToString() + BookmarkStart.b("ᰦ", num);
                string fontName = (A_0 as Symbol).FontName;
                string str3 = this.method_127((A_0 as Symbol).CharacterFormat);
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䄦䘨䔪夬", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䄦䠨䠪䠬", num), fontName);
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("否崨刪䄬䨮", num), str3 + BookmarkStart.b("䄦䘨䔪夬Ȯ地刲場帶唸䈺ܼ", num) + fontName);
                this.xmlTextWriter_0.WriteRaw(data);
                this.xmlTextWriter_0.WriteEndElement();
                return;
            }
            case DocumentObjectType.CommentMark:
                if (this.document_0.HTMLCustomComment)
                {
                    this.method_31(A_0 as CommentMark);
                }
                return;

            case DocumentObjectType.Ruby:
                this.method_89(A_0 as Class2);
                return;

            default:
                return;
        }
        this.list_1.Add((A_0 as BookmarkStart).Name);
    }

    private void method_29(ShapeObject A_0)
    {
        if ((A_0.ShapeType == ShapeType.Rectangle) && A_0.HorizontalRule.method_0())
        {
            this.method_30(A_0);
        }
    }

    private Dictionary<int, Footnote> method_3()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<int, Footnote>();
        }
        return this.dictionary_0;
    }

    private void method_30(ShapeObject A_0)
    {
        int num = 0x11;
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("弶䬸", 0x11));
        string str = string.Empty + this.method_127(A_0.CharacterFormat);
        if (A_0.ShapePr.HasKey(0x7c0))
        {
            str = str + string.Format(BookmarkStart.b("䀶倸强䤼圾筀㡂畄㩆汈灊", num), A_0.WidthPercent);
        }
        else if (A_0.ShapePr.HasKey(0x1023) && (A_0.Width != 0.0))
        {
            str = str + string.Format(BookmarkStart.b("䀶倸强䤼圾筀㡂畄㩆㥈㽊癌", num), A_0.Width);
        }
        if (A_0.ShapePr.HasKey(0x1024))
        {
            str = str + string.Format(BookmarkStart.b("弶尸刺娼圾㕀祂㹄睆㑈㭊㥌瑎", num), A_0.Height);
        }
        if (A_0.HorizontalRule.method_2())
        {
            if (A_0.ShapePr.HasKey(0x181))
            {
                this.method_147(A_0.FillColor);
                str = str + string.Format(BookmarkStart.b("唶堸堺嘼堾㍀ⱂい⥆ⵈ晊⹌⁎㵐㱒❔浖≘歚⁜摞", num), this.method_147(A_0.FillColor));
            }
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("夶嘸䠺唼帾╀♂", num), BookmarkStart.b("夶嘸䠺唼帾╀♂", num));
        }
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䐶䴸䈺儼娾", num), str);
        switch (A_0.HorizontalRule.method_6())
        {
            case ShapeHorizontalAlignment.Left:
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嘶唸刺娼儾", num), BookmarkStart.b("嬶尸崺䤼", num));
                break;

            case ShapeHorizontalAlignment.Right:
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嘶唸刺娼儾", num), BookmarkStart.b("䔶倸尺唼䬾", num));
                break;
        }
        this.xmlTextWriter_0.WriteEndElement();
    }

    private void method_31(CommentMark A_0)
    {
        int num = 3;
        if (A_0.Type == CommentMarkType.CommentStart)
        {
            using (IEnumerator enumerator = A_0.Document.Comments.GetEnumerator())
            {
                Comment current;
                string str;
                while (enumerator.MoveNext())
                {
                    current = (Comment) enumerator.Current;
                    if (current.Format.CommentId == A_0.CommentId)
                    {
                        goto Label_0055;
                    }
                }
                return;
            Label_0055:
                str = this.method_36(A_0.CommentId);
                string str2 = null;
                if (str != null)
                {
                    str2 = str;
                }
                else
                {
                    str2 = BookmarkStart.b("䨨䐪䀬䈮吰崲䄴", num) + Class323.smethod_0().Next().ToString();
                }
                this.method_35(current, str2);
                string str6 = this.dictionary_7.ContainsKey(current) ? this.dictionary_7[current] : string.Empty;
                if (str6 == str2)
                {
                    str2 = BookmarkStart.b("䨨䐪䀬䈮吰崲䄴", num) + Class323.smethod_0().Next().ToString();
                }
                if ((this.document_0.HTMLSentenceIdentifier && !this.method_37(A_0.CommentId)) && this.method_38(A_0.CommentId))
                {
                    if (!this.bool_16 && (str6 == string.Empty))
                    {
                        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("娨嬪䰬䄮", num));
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娨ᄪ丬䌮倰䀲䘴", num), BookmarkStart.b("娨个䌬嬮吰崲嘴制", num));
                        this.bool_16 = true;
                    }
                    if ((str != null) && !this.list_1.Contains(str))
                    {
                        this.bool_10 = true;
                        this.stack_0.Push(this.bool_10);
                        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䠨", num));
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜨䨪䀬䨮", num), str);
                    }
                }
                this.method_32(A_0.CommentId.ToString());
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("娨嬪䰬䄮", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䨨ᄪ丬䌮倰䀲䘴", num), BookmarkStart.b("䨨䐪䀬䈮吰崲䄴", num));
                this.list_1.Add(A_0.CommentId.ToString());
                if ((this.document_0.HTMLSentenceIdentifier && this.method_37(A_0.CommentId)) && (str6 == string.Empty))
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娨ᄪ丬䌮倰䀲䘴", num), BookmarkStart.b("娨个䌬嬮吰崲嘴制", num));
                    this.bool_15 = true;
                    this.int_5 = A_0.CommentId;
                }
                string str3 = this.method_42(current.ChildObjects);
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ倲娴娶吸帺匼䬾", num), str3);
                string str4 = !string.IsNullOrEmpty(current.Format.Author) ? current.Format.Author : ((this.document_0.BuiltinDocumentProperties != null) ? this.document_0.BuiltinDocumentProperties.Author : string.Empty);
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ䘲䘴制䬸", num), str4);
                string str5 = current.Format.DateTime.ToString(BookmarkStart.b("倨刪听嘮ᰰ縲破ᨶ崸强椼眾ी祂⡄⩆獈㡊㹌ᕎ", num), CultureInfo.InvariantCulture);
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ圲吴䌶尸", num), str5);
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ倲尴匶", num), str2);
                if (str6 != string.Empty)
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ䌲吴䔶尸唺䤼ሾ≀⩂⅄", num), str6);
                }
                this.dictionary_8.Add(A_0.CommentId, new string[] { str3, str4, str5, str2, str6 });
                this.list_0.Add(A_0.CommentId);
                return;
            }
        }
        if (A_0.Type == CommentMarkType.CommentEnd)
        {
            if (this.list_1.Contains(A_0.CommentId.ToString()))
            {
                this.xmlTextWriter_0.WriteEndElement();
                this.list_1.Remove(A_0.CommentId.ToString());
            }
            if (A_0.CommentId == this.int_5)
            {
                this.bool_15 = false;
            }
            if (this.list_0.Contains(A_0.CommentId))
            {
                this.list_0.Remove(A_0.CommentId);
            }
        }
    }

    private void method_32(string A_0)
    {
        int num = 11;
        ParagraphItemCollection items = this.paragraph_0.Items;
        int num2 = 0;
        for (int i = 0; i < this.paragraph_0.Items.Count; i++)
        {
            if ((items[i] is BookmarkStart) && ((items[i] as BookmarkStart).Name == A_0))
            {
                num2 = i;
                break;
            }
            if (((items[i] is CommentMark) && ((items[i] as CommentMark).Type == CommentMarkType.CommentStart)) && ((items[i] as CommentMark).CommentId.ToString() == A_0))
            {
                num2 = i;
                break;
            }
        }
        for (int j = num2 + 1; j < items.Count; j++)
        {
            if ((items[j] is BookmarkEnd) && ((items[j] as BookmarkEnd).Name != BookmarkStart.b("渰琲娴甶堸堺嘼", num)))
            {
                if (this.list_1.Contains((items[j] as BookmarkEnd).Name))
                {
                    this.list_1.Remove((items[j] as BookmarkEnd).Name);
                    this.xmlTextWriter_0.WriteEndElement();
                }
            }
            else if ((items[j] is CommentMark) && ((items[j] as CommentMark).Type == CommentMarkType.CommentEnd))
            {
                if (this.list_1.Contains((items[j] as CommentMark).CommentId.ToString()))
                {
                    this.list_1.Remove((items[j] as CommentMark).CommentId.ToString());
                    this.xmlTextWriter_0.WriteEndElement();
                }
            }
            else if (((!(items[j] is BookmarkStart) && (!(items[j] is CommentMark) || ((items[j] as CommentMark).Type != CommentMarkType.CommentStart))) && (!(items[j] is BookmarkEnd) || ((items[j] as BookmarkEnd).Name != BookmarkStart.b("渰琲娴甶堸堺嘼", num)))) && !(items[j] is Comment))
            {
                break;
            }
        }
    }

    private void method_33(Comment A_0)
    {
        int num = 3;
        string str4 = this.dictionary_7.ContainsKey(A_0) ? this.dictionary_7[A_0] : string.Empty;
        ParagraphItemCollection items = this.paragraph_0.Items;
        int num3 = -1;
        bool flag = false;
        for (int i = 0; i < items.Count; i++)
        {
            if ((items[i] is Comment) && ((items[i] as Comment) == A_0))
            {
                num3 = i;
                break;
            }
        }
        string name = string.Empty;
        if ((items[num3 - 1] is BookmarkStart) && (items[num3 + 1] is BookmarkEnd))
        {
            name = (items[num3 - 1] as BookmarkStart).Name;
            flag = true;
        }
        else
        {
            name = BookmarkStart.b("䨨䐪䀬䈮吰崲䄴", num) + Class323.smethod_0().Next().ToString();
        }
        if (flag)
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䠨", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜨䨪䀬䨮", num), name);
        }
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("娨嬪䰬䄮", num));
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䨨ᄪ丬䌮倰䀲䘴", num), BookmarkStart.b("䨨䐪䀬䈮吰崲䄴", num));
        string str5 = this.method_42(A_0.ChildObjects);
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ倲娴娶吸帺匼䬾", num), str5);
        string str2 = !string.IsNullOrEmpty(A_0.Format.Author) ? A_0.Format.Author : ((this.document_0.BuiltinDocumentProperties != null) ? this.document_0.BuiltinDocumentProperties.Author : string.Empty);
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ䘲䘴制䬸", num), str2);
        string str3 = A_0.Format.DateTime.ToString(BookmarkStart.b("倨刪听嘮ᰰ縲破ᨶ崸强椼眾ी祂⡄⩆獈㡊㹌ᕎ", num), CultureInfo.InvariantCulture);
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ圲吴䌶尸", num), str3);
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ倲尴匶", num), name);
        if (str4 != string.Empty)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴨䨪夬丮ᰰ䌲吴䔶尸唺䤼ሾ≀⩂⅄", num), str4);
        }
        this.xmlTextWriter_0.WriteEndElement();
        if (flag)
        {
            this.xmlTextWriter_0.WriteEndElement();
        }
    }

    private void method_34(int A_0)
    {
        int num = 14;
        if (this.dictionary_8.ContainsKey(A_0))
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䜳䘵夷吹", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("圳వ嬷嘹崻䴽㌿", num), BookmarkStart.b("圳夵唷圹夻倽㐿", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倳圵䰷嬹ᄻ崽⼿⽁⥃⍅♇㹉", num), this.dictionary_8[A_0][0]);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倳圵䰷嬹ᄻ䬽㌿❁㙃", num), this.dictionary_8[A_0][1]);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倳圵䰷嬹ᄻ娽ℿ㙁⅃", num), this.dictionary_8[A_0][2]);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倳圵䰷嬹ᄻ崽⤿♁", num), this.dictionary_8[A_0][3]);
            if (!string.IsNullOrEmpty(this.dictionary_8[A_0][4]))
            {
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倳圵䰷嬹ᄻ丽ℿぁ⅃⡅㱇杉⽋❍㑏", num), this.dictionary_8[A_0][4]);
            }
        }
    }

    private void method_35(Comment A_0, string A_1)
    {
        if ((((A_0 != null) && (A_0.ReplyCommentItems.Count > 0)) && !string.IsNullOrEmpty(A_1)) && (this.dictionary_7 != null))
        {
            int num = 0;
            int count = A_0.ReplyCommentItems.Count;
            while (num < count)
            {
                ParagraphBase base2 = A_0.ReplyCommentItems[num];
                if (base2 is Comment)
                {
                    Comment key = base2 as Comment;
                    if (this.dictionary_7.ContainsKey(key))
                    {
                        break;
                    }
                    this.dictionary_7.Add(key, A_1);
                    this.method_35(key, A_1);
                }
                num++;
            }
        }
    }

    private string method_36(int A_0)
    {
        string str = null;
        string str4;
        ParagraphItemCollection items = this.paragraph_0.Items;
        Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
        int num = 0;
        int num2 = 0;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] is BookmarkStart)
            {
                int[] numArray4 = new int[] { i, -1 };
                dictionary.Add((items[i] as BookmarkStart).Name, numArray4);
            }
            if (items[i] is BookmarkEnd)
            {
                int[] numArray = dictionary[(items[i] as BookmarkEnd).Name];
                numArray[1] = i;
            }
            if (items[i] is CommentMark)
            {
                CommentMark mark = items[i] as CommentMark;
                if ((mark.CommentId == A_0) && (mark.Type == CommentMarkType.CommentStart))
                {
                    num = i;
                }
                else if ((mark.CommentId == A_0) && (mark.Type == CommentMarkType.CommentEnd))
                {
                    num2 = i;
                }
            }
        }
        Comment key = null;
        using (IEnumerator enumerator = this.document_0.Comments.GetEnumerator())
        {
            Comment current;
            while (enumerator.MoveNext())
            {
                current = (Comment) enumerator.Current;
                if (current.Format.CommentId == A_0)
                {
                    goto Label_0133;
                }
            }
            goto Label_014E;
        Label_0133:
            key = current;
        }
    Label_014E:
        str4 = this.method_41(this.paragraph_0, num, num2);
        using (Dictionary<string, int[]>.KeyCollection.Enumerator enumerator2 = dictionary.Keys.GetEnumerator())
        {
            string str2;
            while (enumerator2.MoveNext())
            {
                str2 = enumerator2.Current;
                int[] numArray2 = dictionary[str2];
                int num4 = numArray2[0];
                int num5 = numArray2[1];
                if ((this.method_41(this.paragraph_0, num4, num5) == str4) && ((num5 == (num2 + 2)) || !this.dictionary_7.ContainsKey(key)))
                {
                    goto Label_01CD;
                }
            }
            return str;
        Label_01CD:
            str = str2;
        }
        return str;
    }

    private bool method_37(int A_0)
    {
        if (this.document_0.HTMLSentenceIdentifier)
        {
            bool flag = false;
            string str = string.Empty;
            flag = this.method_40(A_0.ToString(), true, ref str);
            MatchCollection matchs = this.method_14().Matches(str);
            if (flag && (matchs.Count == 1))
            {
                int num = matchs[matchs.Count - 1].Index + matchs[matchs.Count - 1].Length;
                if (num == str.Length)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool method_38(int A_0)
    {
        string str = string.Empty;
        return this.method_40(A_0.ToString(), true, ref str);
    }

    private bool method_39(string A_0)
    {
        bool flag = false;
        string str = string.Empty;
        flag = this.method_40(A_0, false, ref str);
        MatchCollection matchs = this.method_14().Matches(str);
        if (flag && (matchs.Count == 1))
        {
            int num = matchs[matchs.Count - 1].Index + matchs[matchs.Count - 1].Length;
            if (num == str.Length)
            {
                return false;
            }
        }
        if (str == this.paragraph_0.Text)
        {
            flag = false;
        }
        return flag;
    }

    private Dictionary<int, Footnote> method_4()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<int, Footnote>();
        }
        return this.dictionary_1;
    }

    private bool method_40(string A_0, bool A_1, ref string A_2)
    {
        bool flag = false;
        if (this.document_0.HTMLSentenceIdentifier)
        {
            ParagraphItemCollection items = this.paragraph_0.Items;
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            if (A_1)
            {
                num3 = int.Parse(A_0);
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (A_1 && (items[i] is CommentMark))
                {
                    CommentMark mark = items[i] as CommentMark;
                    if ((mark.CommentId == num3) && (mark.Type == CommentMarkType.CommentStart))
                    {
                        num = i;
                        continue;
                    }
                    if ((mark.CommentId != num3) || (mark.Type != CommentMarkType.CommentEnd))
                    {
                        continue;
                    }
                    num2 = i;
                    break;
                }
                if (!A_1)
                {
                    if ((items[i] is BookmarkStart) && ((items[i] as BookmarkStart).Name == A_0))
                    {
                        num = i;
                    }
                    else if ((items[i] is BookmarkEnd) && ((items[i] as BookmarkEnd).Name == A_0))
                    {
                        num2 = i;
                        break;
                    }
                }
            }
            A_2 = this.method_41(this.paragraph_0, num, num2);
            if (!A_1)
            {
                bool flag2 = false;
                for (int k = num + 1; k < num2; k++)
                {
                    if ((items[k] is Comment) || (items[k] is CommentMark))
                    {
                        flag2 = true;
                        break;
                    }
                }
                if (!flag2 && string.IsNullOrEmpty(A_2))
                {
                    return false;
                }
            }
            if (num == 0)
            {
                return true;
            }
            string text = null;
            for (int j = num - 1; j >= 0; j--)
            {
                if (items[j] is TextRange)
                {
                    text = (items[j] as TextRange).Text;
                    break;
                }
            }
            if ((text != null) && this.bool_14)
            {
                return true;
            }
            if (text == null)
            {
                flag = true;
            }
        }
        return flag;
    }

    private string method_41(Paragraph A_0, int A_1, int A_2)
    {
        ParagraphItemCollection items = A_0.Items;
        StringBuilder builder = new StringBuilder();
        for (int i = A_1 + 1; i < A_2; i++)
        {
            if (items[i] is TextRange)
            {
                builder.Append((items[i] as TextRange).Text);
            }
        }
        return builder.ToString();
    }

    private string method_42(DocumentObjectCollection A_0)
    {
        StringBuilder builder = new StringBuilder();
        if (A_0.Owner.Owner is Comment)
        {
            foreach (DocumentObject obj3 in A_0)
            {
                if (obj3 is Paragraph)
                {
                    builder.Append((obj3 as Paragraph).Text);
                }
                else
                {
                    builder.Append(this.method_42(obj3.ChildObjects).ToString());
                }
            }
        }
        else if (A_0.Owner.Owner is TextBox)
        {
            foreach (DocumentObject obj2 in A_0)
            {
                if (obj2 is Paragraph)
                {
                    builder.Append((obj2 as Paragraph).Text);
                }
                else
                {
                    builder.Append(this.method_42(obj2.ChildObjects).ToString());
                }
            }
        }
        else if (A_0.Owner is Table)
        {
            foreach (DocumentObject obj6 in A_0)
            {
                foreach (DocumentObject obj4 in (obj6 as TableRow).ChildObjects)
                {
                    foreach (DocumentObject obj5 in (obj4 as TableCell).ChildObjects)
                    {
                        if (obj5 is Paragraph)
                        {
                            builder.Append((obj5 as Paragraph).Text);
                        }
                        else
                        {
                            builder.Append(this.method_42(obj5.ChildObjects).ToString());
                        }
                    }
                }
            }
        }
        return builder.ToString();
    }

    private bool method_43(ParagraphBase A_0)
    {
        Paragraph paragraph = A_0.method_28();
        return (((paragraph != null) && ((((A_0.Owner is SDTInlineContent) && (paragraph.ChildObjects.LastItem == A_0.Owner.Owner)) && ((A_0.Owner as SDTInlineContent).ChildObjects.LastItem == A_0)) || (paragraph.ChildObjects.LastItem == A_0))) && !paragraph.IsInCell);
    }

    private bool method_44(ParagraphBase A_0)
    {
        Paragraph paragraph = A_0.method_28();
        return (((paragraph != null) && ((((A_0.Owner is SDTInlineContent) && (paragraph.ChildObjects.FirstItem == A_0.Owner.Owner)) && ((A_0.Owner as SDTInlineContent).ChildObjects.FirstItem == A_0)) || (paragraph.ChildObjects.FirstItem == A_0))) && !paragraph.IsInCell);
    }

    private bool method_45(ParagraphBase A_0)
    {
        return (!this.method_43(A_0) && !this.method_44(A_0));
    }

    private void method_46(ParagraphBase A_0)
    {
        int num = 9;
        if ((A_0 as Break).BreakType == BreakType.LineBreak)
        {
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ጮ匰䄲ᨴश", num));
        }
        else if ((A_0 as Break).BreakType == BreakType.PageBreak)
        {
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ጮ匰䄲ᔴ䐶䴸䈺儼娾籀摂♄⭆ⱈ⩊㽌畎㍐㱒⅔㽖托⭚㱜㡞Ѡ乢ݤᕦ౨੪٬䉮፰ᙲ፴ᡶ୸Ṻ䝼Ṿﺆ愈겊ꊌ놎", num));
        }
    }

    private void method_47(TextBox A_0)
    {
        Table table = new Class7(A_0);
        table.ResetCells(1, 1);
        table.TableFormat.HorizontalAlignment = this.method_106(A_0.Format.HorizontalAlignment);
        table.TableFormat.Positioning.HorizRelationTo = this.method_48(A_0.Format.HorizontalOrigin);
        table.TableFormat.Positioning.HorizPositionEx = A_0.Format.HorizontalPosition;
        table.TableFormat.Positioning.VertRelationTo = this.method_49(A_0.Format.VerticalOrigin);
        if ((A_0.OwnerParagraph != null) && (table.TableFormat.Positioning.VertRelationTo == VerticalRelation.Paragraph))
        {
            table.TableFormat.Positioning.VertPositionEx = A_0.Format.VerticalPosition - A_0.OwnerParagraph.Format.BeforeSpacing;
        }
        else
        {
            table.TableFormat.Positioning.VertPositionEx = A_0.Format.VerticalPosition;
        }
        TableRow row = table.Rows[0];
        TableCell cell = row.Cells[0];
        row.Height = A_0.Format.Height;
        if (A_0.Format.NoLine)
        {
            row.RowFormat.Borders.BorderType = BorderStyle.Cleared;
            cell.CellFormat.Borders.BorderType = BorderStyle.Cleared;
        }
        else
        {
            cell.CellFormat.Borders.LineWidth = A_0.Format.LineWidth;
            cell.CellFormat.Borders.Color = A_0.Format.LineColor;
            cell.CellFormat.Borders.BorderType = this.method_107(A_0.Format.LineStyle);
        }
        cell.Width = A_0.Format.Width;
        cell.CellFormat.BackColor = A_0.Format.FillColor;
        cell.CellFormat.VerticalAlignment = this.method_105(A_0.Format.VerticalAlignment);
        int num = 0;
        int count = A_0.Body.Items.Count;
        while (num < count)
        {
            BodyRegion region = A_0.Body.Items[num];
            cell.Items.Add(region.Clone());
            num++;
        }
        this.method_92(table);
    }

    private HorizontalRelation method_48(HorizontalOrigin A_0)
    {
        switch (A_0)
        {
            case HorizontalOrigin.Page:
                return HorizontalRelation.Page;

            case HorizontalOrigin.Column:
                return HorizontalRelation.Column;
        }
        return HorizontalRelation.Margin;
    }

    private VerticalRelation method_49(VerticalOrigin A_0)
    {
        switch (A_0)
        {
            case VerticalOrigin.Margin:
                return VerticalRelation.Margin;

            case VerticalOrigin.Page:
                return VerticalRelation.Page;
        }
        return VerticalRelation.Paragraph;
    }

    internal bool method_5()
    {
        return this.bool_11;
    }

    private void method_50(Footnote A_0)
    {
        int num3 = 0x13;
        if (A_0.FootnoteType == FootnoteType.Footnote)
        {
            this.method_3().Add(this.method_3().Count, A_0);
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堸", num3));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("儸䤺堼夾", num3), string.Concat(new object[] { BookmarkStart.b("ᨸ携嬼䬾⽀ㅂ⁄ⅆ", num3), this.int_3, BookmarkStart.b("昸", num3), this.method_3().Count }));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倸强", num3), string.Concat(new object[] { BookmarkStart.b("昸崺䤼儾㍀♂⍄ፆⱈ㍊㥌", num3), this.int_3, BookmarkStart.b("昸", num3), this.method_3().Count }));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娸场尼䰾㉀", num3), BookmarkStart.b("缸吺刼䬾⽀ⱂㅄ≆", num3));
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("Ը䠺䠼伾罀", num3) + this.dictionary_0.Count.ToString() + BookmarkStart.b("Ըᐺ丼䨾ㅀ終", num3));
            this.xmlTextWriter_0.WriteEndElement();
        }
        else
        {
            this.method_4().Add(this.method_4().Count, A_0);
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堸", num3));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("儸䤺堼夾", num3), BookmarkStart.b("ᨸ携堼嬾⽀ㅂ⁄ⅆ", num3) + this.method_4().Count);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倸强", num3), BookmarkStart.b("昸帺夼儾㍀♂⍄ፆⱈ㍊㥌", num3) + this.method_4().Count);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("娸场尼䰾㉀", num3), BookmarkStart.b("簸唺夼儾⹀㝂⁄", num3));
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("Ը䠺䠼伾罀", num3) + this.method_4().Count.ToString() + BookmarkStart.b("Ըᐺ丼䨾ㅀ終", num3));
            this.xmlTextWriter_0.WriteEndElement();
        }
    }

    private void method_51()
    {
        int num = 7;
        if ((this.string_6 != null) && (this.string_4 != null))
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䰬", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䐬䬮", num), this.string_4);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䔬崮吰唲", num), this.string_5);
            this.xmlTextWriter_0.WriteString(this.string_6);
            this.xmlTextWriter_0.WriteEndElement();
            this.string_4 = null;
            this.string_6 = null;
        }
    }

    private void method_52(FormField A_0)
    {
        int num = 10;
        switch (A_0.Type)
        {
            case FieldType.FieldFormTextInput:
            {
                TextFormField field = A_0 as TextFormField;
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("儯", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯匱夳匵", num), field.Name);
                this.xmlTextWriter_0.WriteEndElement();
                if (!A_0.Document.HtmlExportOptions.IsTextInputFormFieldAsText)
                {
                    this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("夯就䐳䌵䰷", num));
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䌯䘱䴳娵崷", num), this.method_127(field.TextRange.CharacterFormat));
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䐯䬱䐳匵", num), BookmarkStart.b("䐯圱䰳䈵", num));
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯匱夳匵", num), field.Name);
                    if (field.Range.Count < 3)
                    {
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䘯匱堳䌵崷", num), field.Text);
                    }
                    else if (string.IsNullOrEmpty(field.DefaultText) && !string.IsNullOrEmpty(field.TextRange.Text))
                    {
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䘯匱堳䌵崷", num), field.TextRange.Text);
                    }
                    else
                    {
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䘯匱堳䌵崷", num), field.DefaultText);
                    }
                    this.xmlTextWriter_0.WriteEndElement();
                    this.bool_3 = true;
                    break;
                }
                if (field.Range.Count >= 3)
                {
                    break;
                }
                this.xmlTextWriter_0.WriteElementString(BookmarkStart.b("䌯䈱唳堵", num), field.Text);
                return;
            }
            case FieldType.FieldFormCheckBox:
            {
                CheckBoxFormField field2 = A_0 as CheckBoxFormField;
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("儯", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯匱夳匵", num), field2.Name);
                this.xmlTextWriter_0.WriteEndElement();
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("夯就䐳䌵䰷", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䐯䬱䐳匵", num), BookmarkStart.b("匯娱儳唵匷堹医䘽", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯匱夳匵", num), field2.Name);
                if (field2.Checked)
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("匯娱儳唵匷弹堻", num), BookmarkStart.b("匯娱儳唵匷弹堻", num));
                }
                this.xmlTextWriter_0.WriteEndElement();
                return;
            }
            case FieldType.FieldFormDropDown:
            {
                DropDownFormField field3 = A_0 as DropDownFormField;
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("儯", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯匱夳匵", num), field3.Name);
                this.xmlTextWriter_0.WriteEndElement();
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䌯圱堳匵嬷丹", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䐯䬱䐳匵", num), BookmarkStart.b("䐯圱䰳䈵", num));
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("帯匱夳匵", num), field3.Name);
                foreach (DropDownItem item in field3.DropDownItems)
                {
                    this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("弯䈱䀳張圷吹", num));
                    if (field3.DropDownValue == item.Text)
                    {
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䌯圱堳匵嬷丹夻娽", num), BookmarkStart.b("䌯圱堳匵嬷丹夻娽", num));
                    }
                    this.xmlTextWriter_0.WriteRaw(item.Text);
                    this.xmlTextWriter_0.WriteEndElement();
                }
                this.xmlTextWriter_0.WriteEndElement();
                return;
            }
            default:
                return;
        }
    }

    private void method_53(Paragraph A_0)
    {
        int num = 1;
        ListFormat format = this.method_173(A_0);
        this.method_167(this.method_169(format));
        this.string_7 = string.Empty;
        this.bool_7 = false;
        this.bool_8 = false;
        string str = string.Empty;
        this.int_2 = this.method_169(format);
        if ((format.ListType != ListType.NoList) && format.HasKey(1))
        {
            str = this.method_56(format, A_0, str);
        }
        else
        {
            if (A_0.HasTextBox)
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䌦䀨崪", num));
            }
            else
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("圦", num));
            }
            if (!this.bool_0)
            {
                str = this.method_123(A_0, A_0.Format, false, null);
            }
            else
            {
                if (!this.bool_8)
                {
                    this.method_175(A_0);
                }
                str = this.method_59(A_0.StyleName, str);
            }
            this.method_55(A_0, str);
        }
        if ((format.ListType != ListType.NoList) && format.HasKey(1))
        {
            this.method_55(A_0, str);
            if (this.bool_7)
            {
                this.int_2 = -1;
                string str2 = this.method_127(A_0.BreakCharacterFormat) + this.method_127(format.CurrentListLevel.CharacterFormat);
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("否夨䨪䌬", num));
                if (str2.Length > 0)
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("否崨刪䄬䨮", num), str2);
                }
                this.xmlTextWriter_0.WriteRaw(this.string_7);
                this.xmlTextWriter_0.WriteEndElement();
                this.method_64(format);
            }
        }
    }

    private void method_54(Paragraph A_0)
    {
        int num = 8;
        if (A_0.Format.KeepLines && !this.bool_0)
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䨭夯䐱", num));
            string str = this.method_123(A_0, A_0.Format, false, null);
            Style style = A_0.Document.Styles.FindByName(A_0.StyleName);
            string str2 = this.method_163(style, A_0.Document);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴭尯匱䜳䔵", num), str2);
            if (!string.IsNullOrEmpty(A_0.StyleName))
            {
                this.method_175(A_0);
            }
            if (!string.IsNullOrEmpty(str))
            {
                str = this.method_59(A_0.StyleName, str);
            }
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("崭䐯䬱堳匵", num), str);
            this.bool_0 = true;
            this.bool_8 = true;
        }
        if (!A_0.Format.KeepLines && this.bool_0)
        {
            this.xmlTextWriter_0.WriteEndElement();
            this.bool_0 = false;
        }
    }

    private void method_55(Paragraph A_0, string A_1)
    {
        int num = 2;
        if (((A_0.StyleName != null) && (A_0.StyleName.Length > 0)) && ((A_0.StyleName != BookmarkStart.b("昧䔩師䌭儯帱", num)) && !this.bool_0))
        {
            Style style = A_0.Document.Styles.FindByName(A_0.StyleName);
            string str = this.method_156(style.Name);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䬧䘩䴫崭䌯", num), str);
            this.method_175(A_0);
            A_1 = this.method_59(A_0.StyleName, A_1);
        }
        if (A_1.Length > 0)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嬧帩唫䈭唯", num), A_1);
        }
    }

    private string method_56(ListFormat A_0, Paragraph A_1, string A_2)
    {
        int num = 4;
        string str = null;
        if (!string.IsNullOrEmpty(A_1.Text))
        {
            int num2 = 0;
            if (A_0.CurrentListLevel.PatternType != ListPatternType.Bullet)
            {
                num2 = this.method_61(A_0);
            }
            this.method_60(A_0, num2, A_1);
        }
        else
        {
            this.int_2 = -1;
        }
        if (!this.bool_7 && !string.IsNullOrEmpty(A_1.Text))
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("天尫伭帯", num));
        }
        else
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("娩", num));
        }
        A_2 = this.method_123(A_1, A_1.Format, true, A_0);
        if (str != null)
        {
            A_2 = this.method_58(str, A_2);
        }
        return A_2;
    }

    private string method_57(ListFormat A_0, Paragraph A_1, string A_2)
    {
        string str = null;
        A_2 = this.method_122(A_1, A_1.Format, true, this.bool_9, A_0);
        if (A_1.BreakCharacterFormat != null)
        {
            A_2 = A_2 + this.method_127(A_1.BreakCharacterFormat);
        }
        if ((A_0 != null) && (A_0.CurrentListLevel != null))
        {
            str = this.method_127(A_0.CurrentListLevel.CharacterFormat);
        }
        if (str != null)
        {
            A_2 = this.method_58(str, A_2);
        }
        return A_2;
    }

    private string method_58(string A_0, string A_1)
    {
        int num = 0x11;
        bool flag = false;
        string[] strArray = A_1.Split(new char[] { ';' });
        foreach (string str in A_0.Split(new char[] { ';' }))
        {
            flag = false;
            if (str.Length > 0)
            {
                int index = str.IndexOf(BookmarkStart.b("ശ", num));
                string str2 = str.Substring(0, index);
                string newValue = str.Substring(index + 1);
                foreach (string str5 in strArray)
                {
                    if (str5.Contains(str2))
                    {
                        flag = true;
                        int num5 = str5.IndexOf(BookmarkStart.b("ശ", num));
                        string oldValue = str5.Substring(num5 + 1);
                        string str7 = str5.Replace(oldValue, newValue);
                        A_1 = A_1.Replace(str5, str7);
                    }
                }
                if (!flag)
                {
                    string str4 = A_1;
                    A_1 = str4 + str2 + BookmarkStart.b("ശ", num) + newValue + BookmarkStart.b("శ", num);
                }
            }
        }
        return A_1;
    }

    private string method_59(string A_0, string A_1)
    {
        int num = 0;
        if (!string.IsNullOrEmpty(A_0) && this.dictionary_3.ContainsKey(A_0))
        {
            foreach (string str in this.dictionary_3[A_0].Split(new char[] { ';' }))
            {
                if ((str.Length > 0) && (A_1.Length > 0))
                {
                    A_1 = A_1.Replace(str + BookmarkStart.b("ᴥ", num), string.Empty);
                }
            }
        }
        return A_1;
    }

    internal void method_6(bool A_0)
    {
        this.bool_11 = A_0;
    }

    private void method_60(ListFormat A_0, int A_1, Paragraph A_2)
    {
        int num = 2;
        if (this.int_2 >= 0)
        {
            if ((A_0.CurrentListLevel.PatternType == ListPatternType.Bullet) && !string.IsNullOrEmpty(A_0.CurrentListLevel.BulletCharacter))
            {
                this.bool_7 = true;
                if (!(A_0.CurrentListLevel.CharacterFormat.FontName.ToLower() == BookmarkStart.b("嬧匩䄫䰭弯帱", num)) && !(A_0.CurrentListLevel.CharacterFormat.FontName.ToLower() == BookmarkStart.b("弧䌩䈫䤭启嬱娳儵䬷", num)))
                {
                    this.string_7 = A_0.CurrentListLevel.BulletCharacter;
                }
                else
                {
                    this.string_7 = BookmarkStart.b("วऩ", num) + ((byte) A_0.CurrentListLevel.BulletCharacter[0]).ToString() + BookmarkStart.b("ጧ", num);
                }
            }
            else
            {
                this.bool_7 = true;
                this.string_7 = A_2.Document.method_132(A_2, A_0, A_0.CurrentListLevel);
            }
        }
    }

    private int method_61(ListFormat A_0)
    {
        if (A_0.IsRestartNumbering)
        {
            this.method_171(A_0, true);
        }
        else if (A_0.ListLevelNumber == 0)
        {
            this.method_171(A_0, false);
        }
        return this.method_170(A_0);
    }

    private void method_62(ListFormat A_0, Paragraph A_1, string A_2)
    {
        int num = 0;
        num = this.method_61(A_0);
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("圦", 1));
        A_2 = this.method_123(A_1, A_1.Format, true, A_0);
        if (!string.IsNullOrEmpty(A_0.CurrentListLevel.NumberPrefix) || !string.IsNullOrEmpty(A_0.CurrentListLevel.NumberSufix))
        {
            this.bool_7 = true;
            this.string_7 = A_1.Document.method_132(A_1, A_0, A_0.CurrentListLevel);
        }
        this.method_55(A_1, A_2);
        this.method_63(A_0, num);
    }

    private void method_63(ListFormat A_0, int A_1)
    {
        int num = 6;
        string str = this.method_127(A_0.CurrentListLevel.CharacterFormat);
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("弫席儯就", 6));
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("弫娭䤯帱儳", 6), str);
        if ((A_0.CurrentListLevel.PatternType == ListPatternType.Bullet) && !string.IsNullOrEmpty(A_0.CurrentListLevel.BulletCharacter))
        {
            if (!(A_0.CurrentListLevel.CharacterFormat.FontName.ToLower() == BookmarkStart.b("弫圭崯倱嬳娵", num)) && !(A_0.CurrentListLevel.CharacterFormat.FontName.ToLower() == BookmarkStart.b("嬫䜭帯唱倳張嘷崹伻", num)))
            {
                this.xmlTextWriter_0.WriteRaw(A_0.CurrentListLevel.BulletCharacter);
            }
            else
            {
                this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ਫഭ", num) + ((byte) A_0.CurrentListLevel.BulletCharacter[0]).ToString() + BookmarkStart.b("ᜫ", num));
            }
        }
        else if (this.bool_7)
        {
            this.xmlTextWriter_0.WriteRaw(this.string_7);
        }
        else
        {
            string data = this.method_65(A_0.CurrentListLevel.PatternType, A_1);
            this.xmlTextWriter_0.WriteRaw(data);
        }
        if (!this.bool_7 && (A_0.CurrentListLevel.NumberSufix != null))
        {
            this.xmlTextWriter_0.WriteRaw(A_0.CurrentListLevel.NumberSufix.ToString());
        }
        this.xmlTextWriter_0.WriteEndElement();
        this.method_64(A_0);
    }

    private void method_64(ListFormat A_0)
    {
        int num = 12;
        int num2 = 0;
        StringBuilder builder = new StringBuilder();
        float textPosition = A_0.CurrentListLevel.TextPosition;
        float num4 = A_0.CurrentListLevel.TextPosition + A_0.CurrentListLevel.NumberPosition;
        float tabSpaceAfter = A_0.CurrentListLevel.TabSpaceAfter;
        if (A_0.CurrentListLevel.TabSpaceAfter <= 0f)
        {
            num2 = (int) Math.Round((double) (((double) (textPosition - num4)) / 36.0));
        }
        else
        {
            num2 = (int) Math.Round((double) (((double) (A_0.CurrentListLevel.TabSpaceAfter - num4)) / 36.0));
        }
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䄱䐳圵嘷", num));
        builder.Append(BookmarkStart.b("吱嬳堵䰷᜹伻圽㨿❁繃", num) + XmlConvert.ToString(Math.Round((double) 0.58333333333333337, 2)) + BookmarkStart.b("圱夳വ", num));
        builder.Append(BookmarkStart.b("吱嬳堵䰷᜹娻弽ⴿ⭁⡃㽅片浉ᡋ❍㵏㝑❓癕ᙗ㽙⭛繝㉟ൡॣݥ٧䵩坫", num));
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䄱䀳伵吷弹", num), builder.ToString());
        if (num2 > 0)
        {
            for (int i = 0; i < num2; i++)
            {
                for (int j = 0; j < 0x16; j++)
                {
                    this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ᐱ娳吵䬷䨹ܻ", num));
                }
            }
        }
        else
        {
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ᐱ娳吵䬷䨹ܻᠽ⸿⁁㝃㙅獇汉≋ⱍ⍏≑潓灕㙗㡙⽛⹝孟䑡੣ѥ᭧ᩩ坫䡭ṯၱݳٵ䍷屹ቻᱽ뾃", num));
        }
        this.xmlTextWriter_0.WriteEndElement();
    }

    private string method_65(ListPatternType A_0, int A_1)
    {
        int num = 0;
        switch (A_0)
        {
            case ListPatternType.UpRoman:
                return this.method_66(A_1).ToUpper();

            case ListPatternType.LowRoman:
                return this.method_66(A_1).ToLower();

            case ListPatternType.UpLetter:
                num = 0x41 + (A_1 - 1);
                return char.ConvertFromUtf32(num);

            case ListPatternType.LowLetter:
                num = 0x61 + (A_1 - 1);
                return char.ConvertFromUtf32(num);
        }
        return A_1.ToString();
    }

    private string method_66(int A_0)
    {
        int num = 6;
        string str = "";
        for (int i = 0; i < A_0; i++)
        {
            while (A_0 >= 0x3e8)
            {
                str = str + BookmarkStart.b("愫", num);
                A_0 -= 0x3e8;
            }
            while (A_0 >= 900)
            {
                str = str + BookmarkStart.b("漫挭", num);
                A_0 -= 900;
            }
            while (A_0 >= 500)
            {
                str = str + BookmarkStart.b("栫", num);
                A_0 -= 500;
            }
            while (A_0 >= 400)
            {
                str = str + BookmarkStart.b("漫樭", num);
                A_0 -= 400;
            }
            while (A_0 >= 100)
            {
                str = str + BookmarkStart.b("漫", num);
                A_0 -= 100;
            }
            while (A_0 >= 90)
            {
                str = str + BookmarkStart.b("琫洭", num);
                A_0 -= 90;
            }
            while (A_0 >= 50)
            {
                str = str + BookmarkStart.b("怫", num);
                A_0 -= 50;
            }
            while (A_0 >= 40)
            {
                str = str + BookmarkStart.b("琫戭", num);
                A_0 -= 40;
            }
            while (A_0 >= 10)
            {
                str = str + BookmarkStart.b("琫", num);
                A_0 -= 10;
            }
            while (A_0 >= 9)
            {
                str = str + BookmarkStart.b("攫瘭", num);
                A_0 -= 9;
            }
            while (A_0 >= 5)
            {
                str = str + BookmarkStart.b("稫", num);
                A_0 -= 5;
            }
            while (A_0 >= 4)
            {
                str = str + BookmarkStart.b("攫砭", num);
                A_0 -= 4;
            }
            while (A_0 >= 1)
            {
                str = str + BookmarkStart.b("攫", num);
                A_0--;
            }
        }
        return str;
    }

    private string method_67(ListFormat A_0, int A_1)
    {
        return A_0.CurrentListLevel.GetListItemText(A_1 - 1, A_0.ListType);
    }

    private void method_68(BookmarkStart A_0)
    {
        this.bool_10 = true;
        this.stack_0.Push(this.bool_10);
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䰬", 7));
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䌬丮尰嘲", 7), A_0.Name);
    }

    private void method_69(Field A_0)
    {
        int num = 0x10;
        FieldType type = A_0.Type;
        switch (type)
        {
            case FieldType.FieldIf:
                this.bool_2 = true;
                return;

            case FieldType.FieldMergeField:
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䔵䠷嬹刻", num));
                string str = this.method_127(A_0.CharacterFormat);
                if (str.Length > 0)
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䔵䰷䌹倻嬽", num), str);
                }
                this.xmlTextWriter_0.WriteRaw(A_0.Value);
                this.xmlTextWriter_0.WriteEndElement();
                return;
            }
        }
        if (type == FieldType.FieldHyperlink)
        {
            Hyperlink hyperlink = new Hyperlink(A_0);
            this.method_70(hyperlink);
            this.bool_5 = true;
        }
    }

    internal bool method_7()
    {
        return this.bool_12;
    }

    private void method_70(Hyperlink A_0)
    {
        int num = 13;
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("刲", 13));
        string charStyleName = A_0.Field.CharacterFormat.CharStyleName;
        if ((charStyleName != null) && (charStyleName.Length > 0))
        {
            Style style = A_0.Field.Document.Styles.FindByName(charStyleName);
            string str3 = this.method_163(style, A_0.Field.Document);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("倲头嘶䨸䠺", num), str3);
        }
        Field field = new Field(A_0.Field.Document);
        TextRange range = new TextRange(A_0.Field.Document);
        ParagraphBase nextSibling = A_0.Field.NextSibling as ParagraphBase;
        if (nextSibling.NextSibling is TextRange)
        {
            range = nextSibling.NextSibling as TextRange;
        }
        string str2 = this.method_127(range.CharacterFormat);
        if (!string.IsNullOrEmpty(charStyleName))
        {
            str2 = this.method_59(charStyleName, str2);
        }
        if (str2.Length > 0)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䀲䄴丶唸帺", num), str2);
        }
        switch (A_0.Type)
        {
            case HyperlinkType.None:
                break;

            case HyperlinkType.FileLink:
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), A_0.FilePath);
                if (string.IsNullOrEmpty(A_0.ToolTip))
                {
                    break;
                }
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜲尴䌶唸帺", num), A_0.ToolTip);
                return;

            case HyperlinkType.WebLink:
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), A_0.Uri);
                if (string.IsNullOrEmpty(A_0.ToolTip))
                {
                    break;
                }
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜲尴䌶唸帺", num), A_0.ToolTip);
                return;

            case HyperlinkType.EMailLink:
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), A_0.Uri);
                if (string.IsNullOrEmpty(A_0.ToolTip))
                {
                    break;
                }
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜲尴䌶唸帺", num), A_0.ToolTip);
                return;

            case HyperlinkType.Bookmark:
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), BookmarkStart.b("ဲ", num) + A_0.BookmarkName);
                if (!string.IsNullOrEmpty(A_0.ToolTip))
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜲尴䌶唸帺", num), A_0.ToolTip);
                }
                break;

            default:
                return;
        }
    }

    private void method_71(DocPicture A_0)
    {
        this.method_72(A_0, null);
    }

    private void method_72(DocPicture A_0, Paragraph A_1)
    {
        int num = 9;
        if ((A_0 != null) && (A_0.ImageBytes != null))
        {
            SizeF ef = A_0.method_92();
            Image image = A_0.method_93(ef.Width, ef.Height);
            ImageFormat format = this.method_78(A_0.Image);
            string str2 = BookmarkStart.b("Į", num) + format.ToString().ToLower();
            int num2 = (int) Math.Round((double) Class1073.smethod_1().method_2(ef.Width, PrintUnits.Point));
            int num4 = (int) Math.Round((double) Class1073.smethod_1().method_2(ef.Height, PrintUnits.Point));
            if (A_1 != null)
            {
                PictureWatermark watermark = A_1.Document.Watermark as PictureWatermark;
                if (watermark.ScalingAuto)
                {
                    PageSetup pageSetup = A_1.method_49().PageSetup;
                    float num3 = (A_1.Document.LastSection.PageSetup.ClientWidth / watermark.WordPicture.Width) * 100f;
                    if (watermark.WordPicture.Width < watermark.WordPicture.Height)
                    {
                        num3 = (A_1.Document.LastSection.PageSetup.ClientHeight / watermark.WordPicture.Height) * 100f;
                    }
                    if ((num3 != 0f) || (num3 != 100f))
                    {
                        num2 = (int) ((num2 * num3) / 100f);
                        num4 = (int) ((num4 * num3) / 100f);
                    }
                }
            }
            if ((num2 >= 0) && (num4 >= 0))
            {
                bool flag;
                if ((flag = (A_0.TextWrappingStyle == TextWrappingStyle.Behind) || (A_0.TextWrappingStyle == TextWrappingStyle.InFrontOfText)) || (A_1 != null))
                {
                    this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("尮䄰刲嬴", num));
                    string str = !A_0.Borders.NoBorder ? this.method_76(A_0.Borders.Left) : BookmarkStart.b("䴮帰䄲儴制䬸ĺ഼伾㥀硂㕄⡆㩈≊㥌♎㹐㵒潔㙖㭘⡚㉜㍞ᑠᝢd屦", num);
                    if (A_0.IsUnderText && (A_0.OrderIndex > 0L))
                    {
                        str = str + BookmarkStart.b("售ᰰ娲嬴匶尸䌺ܼሾ", num) + this.method_77(A_0.OrderIndex);
                    }
                    else if (A_1 != null)
                    {
                        str = str + BookmarkStart.b("售ᰰ娲嬴匶尸䌺ܼሾ獀療瑄煆籈繊籌祎楐", num);
                    }
                    else
                    {
                        str = str + BookmarkStart.b("售ᰰ娲嬴匶尸䌺ܼ", num) + A_0.OrderIndex;
                    }
                    str = str + BookmarkStart.b("ᐮ", num);
                    if (A_0.HorizontalOrigin == HorizontalOrigin.Column)
                    {
                        str = str + string.Format(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ儼娾❀㝂罄㱆祈㙊㵌㭎橐", num), A_0.HorizontalPosition);
                    }
                    if (A_0.VerticalOrigin == VerticalOrigin.Paragraph)
                    {
                        str = str + string.Format(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ䤼倾ㅀ祂㹄睆㑈㭊㥌瑎", num), A_0.VerticalPosition);
                    }
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("尮䔰䨲头制", num), str);
                }
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䘮尰吲", num));
                if (!this.document_0.HtmlExportOptions.ImageEmbedded)
                {
                    string str3 = this.method_109() + str2;
                    this.method_108();
                    this.method_158(image, str3, num2, num4, false, format);
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("尮䌰倲", num), (this.method_0() ? this.string_3 : string.Empty) + str3);
                }
                else
                {
                    string str4 = Convert.ToBase64String(this.method_73(image, format));
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("尮䌰倲", num), string.Format(BookmarkStart.b("䬮倰䜲吴ശ䈸଺䀼о⍀≂㙄≆罈罊慌㑎恐⹒", num), this.method_80(format), str4));
                }
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("堮堰圲䄴弶", num), num2.ToString());
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䜮吰娲刴弶䴸", num), num4.ToString());
                if (!string.IsNullOrEmpty(A_0.AlternativeText))
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("丮崰䜲", num), A_0.AlternativeText);
                }
                else
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("丮崰䜲", num), BookmarkStart.b("䘮尰吲", num) + this.int_1.ToString());
                }
                string str5 = this.method_74(A_0);
                if (!string.IsNullOrEmpty(str5))
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("尮䔰䨲头制", num), str5);
                }
                if (A_0.Rotation != 0f)
                {
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("崮帰䜲吴䌶尸", num), A_0.Rotation.ToString());
                }
                this.xmlTextWriter_0.WriteEndElement();
                if (flag || (A_1 != null))
                {
                    this.xmlTextWriter_0.WriteEndElement();
                }
            }
        }
    }

    private byte[] method_73(Image A_0, ImageFormat A_1)
    {
        MemoryStream stream = new MemoryStream();
        A_0.Save(stream, A_1);
        stream.Flush();
        return stream.ToArray();
    }

    private string method_74(DocPicture A_0)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.method_75(A_0));
        if (!A_0.Borders.NoBorder)
        {
            builder.Append(this.method_76(A_0.Borders.Left));
        }
        return builder.ToString();
    }

    private string method_75(DocPicture A_0)
    {
        int num = 15;
        StringBuilder builder = new StringBuilder();
        if (((A_0.TextWrappingStyle == TextWrappingStyle.Square) || (A_0.TextWrappingStyle == TextWrappingStyle.Through)) || (A_0.TextWrappingStyle == TextWrappingStyle.Tight))
        {
            builder.Append(BookmarkStart.b("匴嬶嘸娺䤼Ծ", num));
            if (A_0.HorizontalAlignment == ShapeHorizontalAlignment.Right)
            {
                builder.Append(BookmarkStart.b("䜴帶常区䤼о", num));
            }
            else
            {
                builder.Append(BookmarkStart.b("头制弸伺ؼ", num));
            }
            builder.Append(string.Format(BookmarkStart.b("場嘶䬸尺吼儾汀⽂⁄ⅆ㵈煊浌㑎慐⹒╔⍖托㙚㱜ⵞ٠੢୤䩦᭨ɪ੬ݮհ䥲啴౶䡸ٺർ୾몀ꊎﲒ궖릘꾜토힢麤쪦좨\ud9aa\ucaac욮\udfb0\u9eb2ힴ\ud8b6\ucdb8쾺튼튾﯀뻄듈믊만", num), new object[] { A_0.WrapDistanceLeft, A_0.WrapDistanceRight, A_0.WrapDistanceTop, A_0.WrapDistanceBottom }));
        }
        return builder.ToString();
    }

    private string method_76(Border A_0)
    {
        int num = 10;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("刯崱䘳刵崷䠹ػ", 10));
        if (A_0.HasValue(2))
        {
            builder.Append(this.method_155(A_0.BorderType) + BookmarkStart.b("ု", num));
        }
        if (A_0.HasValue(3))
        {
            builder.Append(Math.Round((double) (A_0.LineWidth / 0.75f), 2) + BookmarkStart.b("䀯䨱ᐳ", num));
        }
        if (A_0.HasValue(1))
        {
            builder.Append(this.method_147(A_0.Color) + BookmarkStart.b("ု", num));
        }
        builder.Append(BookmarkStart.b("ଯ", num));
        return builder.ToString();
    }

    private int method_77(long A_0)
    {
        if (A_0 > 0x7fffffffL)
        {
            return 0x7fffffff;
        }
        return (0x7fffffff - ((int) A_0));
    }

    private ImageFormat method_78(Image A_0)
    {
        ImageFormat jpeg = ImageFormat.Jpeg;
        string str = A_0.RawFormat.Guid.ToString();
        if ((str != ImageFormat.Emf.Guid.ToString()) && (str != ImageFormat.Wmf.Guid.ToString()))
        {
            if (str == ImageFormat.Png.Guid.ToString())
            {
                return ImageFormat.Png;
            }
            return ImageFormat.Jpeg;
        }
        return ImageFormat.Png;
    }

    private string method_79(Image A_0)
    {
        int num = 10;
        if (dictionary_6 == null)
        {
            lock (object_0)
            {
                if (dictionary_6 == null)
                {
                    dictionary_6 = new Dictionary<ImageFormat, string>();
                    dictionary_6[ImageFormat.Bmp] = BookmarkStart.b("夯弱唳儵崷ᔹ帻匽〿", num);
                    dictionary_6[ImageFormat.Emf] = BookmarkStart.b("夯弱唳儵崷ᔹ夻匽☿", num);
                    dictionary_6[ImageFormat.Exif] = BookmarkStart.b("夯弱唳儵崷ᔹ夻䘽⤿⑁", num);
                    dictionary_6[ImageFormat.Gif] = BookmarkStart.b("夯弱唳儵崷ᔹ嬻圽☿", num);
                    dictionary_6[ImageFormat.Icon] = BookmarkStart.b("夯弱唳儵崷ᔹ唻崽⼿", num);
                    dictionary_6[ImageFormat.Jpeg] = BookmarkStart.b("夯弱唳儵崷ᔹ嘻丽┿╁", num);
                    dictionary_6[ImageFormat.MemoryBmp] = BookmarkStart.b("夯弱唳儵崷ᔹ帻匽〿", num);
                    dictionary_6[ImageFormat.Png] = BookmarkStart.b("夯弱唳儵崷ᔹ䰻倽✿", num);
                    dictionary_6[ImageFormat.Tiff] = BookmarkStart.b("夯弱唳儵崷ᔹ䠻圽☿⑁", num);
                    dictionary_6[ImageFormat.Wmf] = BookmarkStart.b("夯弱唳儵崷ᔹ䬻匽☿", num);
                }
            }
        }
        if (!dictionary_6.ContainsKey(A_0.RawFormat))
        {
            return BookmarkStart.b("夯弱唳儵崷ᔹ䰻倽✿", num);
        }
        return dictionary_6[A_0.RawFormat];
    }

    internal void method_8(bool A_0)
    {
        this.bool_12 = A_0;
    }

    private string method_80(ImageFormat A_0)
    {
        int num = 0;
        string str = BookmarkStart.b("伥䔧䬩䬫䬭Ἧ報䐳匵強", 0);
        if (((A_0 != ImageFormat.Png) && (A_0 != ImageFormat.Wmf)) && (A_0 != ImageFormat.Emf))
        {
            if (A_0 == ImageFormat.Gif)
            {
                str = BookmarkStart.b("伥䔧䬩䬫䬭Ἧ唱崳倵", num);
            }
            return str;
        }
        return BookmarkStart.b("伥䔧䬩䬫䬭Ἧ䈱娳儵", num);
    }

    private void method_81(TextRange A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            return;
        }
        string text = A_0.Text;
        if ((text.Length <= 0) || (text[0] == '\x0002'))
        {
            if ((A_0.Document.HTMLSentenceIdentifier && (A_0.Owner is Paragraph)) && (A_0 == (A_0.Owner as Paragraph).method_40()))
            {
                this.bool_14 = true;
            }
            return;
        }
        if ((A_0.DocumentObjectType != DocumentObjectType.TextRange) || !A_0.Document.HTMLSentenceIdentifier)
        {
            this.method_82(A_0, text);
            return;
        }
        MatchCollection matchs = this.method_14().Matches(text);
        TextRange range = null;
        if (A_0.Owner is Paragraph)
        {
            if (A_0 == (A_0.Owner as Paragraph).method_40())
            {
                this.bool_14 = true;
            }
            ParagraphItemCollection items = (A_0.Owner as Paragraph).Items;
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i] is TextRange)
                {
                    range = items[i] as TextRange;
                    break;
                }
            }
        }
        bool flag = A_0 == range;
        int startIndex = 0;
        string str = string.Empty;
        using (IEnumerator enumerator = matchs.GetEnumerator())
        {
            Match current;
            while (enumerator.MoveNext())
            {
                bool flag2;
                current = (Match) enumerator.Current;
                startIndex = current.Index + current.Length;
                if (startIndex == text.Length)
                {
                    goto Label_0278;
                }
                if (startIndex == 1)
                {
                    flag2 = false;
                }
                else
                {
                    char ch = text[startIndex - 2];
                    flag2 = A_0.method_38(ch.ToString()) == CharacterCategory.FarEast;
                }
                char ch2 = text[startIndex];
                bool flag3 = A_0.method_38(ch2.ToString()) == CharacterCategory.FarEast;
                if (flag2 || flag3)
                {
                    goto Label_021D;
                }
                if (!flag2 && !flag3)
                {
                    char ch5 = text[startIndex - 1];
                    if (!ch5.ToString().Equals(BookmarkStart.b("ሱ", num)))
                    {
                        char ch3 = text[startIndex - 1];
                        char ch4 = '\x00a0';
                        if (!ch3.ToString().Equals(ch4.ToString()))
                        {
                            goto Label_0212;
                        }
                    }
                    if ((this.bool_14 && !this.bool_15) && !this.bool_16)
                    {
                        this.method_83();
                    }
                    this.method_82(A_0, str + current.Value);
                    if (!this.bool_15)
                    {
                        this.method_84();
                    }
                    str = string.Empty;
                    this.bool_14 = true;
                    continue;
                }
            Label_0212:
                str = str + current;
                continue;
            Label_021D:
                if ((this.bool_14 && !this.bool_15) && !this.bool_16)
                {
                    this.method_83();
                }
                this.method_82(A_0, str + current.Value);
                if (!this.bool_15)
                {
                    this.method_84();
                }
                str = string.Empty;
                this.bool_14 = true;
            }
            goto Label_02DD;
        Label_0278:
            if ((this.bool_14 && !this.bool_15) && !this.bool_16)
            {
                this.method_83();
            }
            this.method_82(A_0, str + current.Value);
            if (!this.bool_15)
            {
                this.method_85(A_0);
                this.method_84();
            }
            this.bool_14 = true;
        }
    Label_02DD:
        if (text.Length > startIndex)
        {
            if ((this.bool_14 && !this.bool_15) && !this.bool_16)
            {
                this.method_83();
            }
            this.method_82(A_0, str + text.Substring(startIndex));
            if (flag && !this.bool_15)
            {
                this.method_85(A_0);
                this.method_84();
            }
            this.bool_14 = false;
        }
    }

    private void method_82(TextRange A_0, string A_1)
    {
        int num = 1;
        if (!this.method_86(A_0))
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("否夨䨪䌬", num));
        }
        string str = this.method_127(A_0.CharacterFormat);
        if ((A_0.CharacterFormat.CharStyleName != null) && (A_0.CharacterFormat.CharStyleName.Length > 0))
        {
            Style style = A_0.Document.Styles.FindByName(A_0.CharacterFormat.CharStyleName);
            string str2 = this.method_163(style, A_0.Document);
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䐦䔨䨪帬尮", num), str2);
            if (!string.IsNullOrEmpty(A_0.CharacterFormat.CharStyleName))
            {
                str = this.method_59(A_0.CharacterFormat.CharStyleName, str);
            }
        }
        if (str.Length > 0)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("否崨刪䄬䨮", num), str);
        }
        if (A_1 == string.Empty)
        {
            this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("Ħ䜨䤪帬弮ਰ", num));
        }
        else
        {
            this.method_160(A_1);
        }
        this.xmlTextWriter_0.WriteEndElement();
    }

    private void method_83()
    {
        int num = 8;
        this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("崭䀯匱娳", 8));
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("崭ਯ儱堳圵䬷䤹", 8), BookmarkStart.b("崭唯就䀳匵嘷夹夻", 8));
        if (this.document_0.HTMLCustomComment && (this.list_0.Count > 0))
        {
            foreach (int num2 in this.list_0)
            {
                if (this.method_36(num2) != null)
                {
                    this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("伭", num));
                    this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䀭儯弱儳", num), this.dictionary_8[num2][3]);
                }
                this.method_34(num2);
            }
        }
    }

    private void method_84()
    {
        this.xmlTextWriter_0.WriteEndElement();
        this.bool_16 = false;
        if (this.document_0.HTMLCustomComment && (this.list_0.Count > 0))
        {
            foreach (int num in this.list_0)
            {
                this.xmlTextWriter_0.WriteEndElement();
                if (this.method_36(num) != null)
                {
                    this.xmlTextWriter_0.WriteEndElement();
                }
            }
        }
    }

    private void method_85(TextRange A_0)
    {
        int num = -1;
        int count = -1;
        for (int i = 0; i < this.paragraph_0.Items.Count; i++)
        {
            if ((this.paragraph_0.Items[i] is TextRange) && ((this.paragraph_0.Items[i] as TextRange) == A_0))
            {
                num = i;
                break;
            }
        }
        for (int j = num + 1; j < this.paragraph_0.Items.Count; j++)
        {
            if (this.paragraph_0.Items[j] is TextRange)
            {
                count = j;
                break;
            }
        }
        if (count == -1)
        {
            count = this.paragraph_0.Items.Count;
        }
        for (int k = num + 1; k < count; k++)
        {
            if (((this.paragraph_0.Items[k] is CommentMark) && ((this.paragraph_0.Items[k] as CommentMark).Type == CommentMarkType.CommentEnd)) && this.list_0.Contains((this.paragraph_0.Items[k] as CommentMark).CommentId))
            {
                this.list_0.Remove((this.paragraph_0.Items[k] as CommentMark).CommentId);
            }
        }
    }

    private bool method_86(TextRange A_0)
    {
        int num = 12;
        if (A_0.IsInsertRevision)
        {
            if (A_0.Document.HTMLTrackChanges)
            {
                this.method_87(BookmarkStart.b("嬱娳䔵崷䠹䠻", num), A_0);
            }
            else
            {
                this.method_87(BookmarkStart.b("嬱娳䔵", num), A_0);
            }
            return true;
        }
        if (!A_0.IsDeleteRevision)
        {
            return false;
        }
        if (A_0.Document.HTMLTrackChanges)
        {
            this.method_87(BookmarkStart.b("嘱儳娵崷丹夻", num), A_0);
        }
        else
        {
            this.method_87(BookmarkStart.b("嘱儳娵", num), A_0);
        }
        return true;
    }

    private void method_87(string A_0, TextRange A_1)
    {
        int num = 10;
        this.xmlTextWriter_0.WriteStartElement(A_0);
        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("启匱䀳圵ᔷ伹伻嬽㈿⭁⁃", 10), this.method_88());
        bool flag = (A_1 != null) ? A_1.CharacterFormat.IsInsertRevision : false;
        string str = ((A_1 == null) || string.IsNullOrEmpty(flag ? A_1.CharacterFormat.InsertRevision.method_0() : A_1.CharacterFormat.DeleteRevision.method_0())) ? ((this.document_0.BuiltinDocumentProperties != null) ? this.document_0.BuiltinDocumentProperties.Author : string.Empty) : (flag ? A_1.CharacterFormat.InsertRevision.method_0() : A_1.CharacterFormat.DeleteRevision.method_0());
        if (!string.IsNullOrEmpty(str))
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("启匱䀳圵ᔷ伹伻嬽㈿ⱁ╃⭅ⵇ", num), str);
        }
        if (A_1 != null)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("启匱䀳圵ᔷ丹唻匽┿", num), ((A_1 != null) ? (flag ? A_1.CharacterFormat.InsertRevision.method_2() : A_1.CharacterFormat.DeleteRevision.method_2()) : DateTime.Now).ToString(BookmarkStart.b("䤯䬱䴳伵ᔷ眹焻ጽ␿♁၃ๅG灉⅋⍍橏⅑❓ౕ", num), CultureInfo.InvariantCulture));
        }
    }

    private string method_88()
    {
        int num2 = this.int_0++;
        return num2.ToString();
    }

    private void method_89(Class2 A_0)
    {
        int num = 12;
        if (A_0 != null)
        {
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䀱䄳吵䄷", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䄱䀳伵吷弹", num), BookmarkStart.b("䀱䄳吵䄷᜹崻刽⤿╁⩃籅", num) + this.method_90(A_0.method_51()));
            this.method_81(A_0);
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䀱䐳", num));
            this.method_160(BookmarkStart.b("ᨱ", num));
            this.xmlTextWriter_0.WriteEndElement();
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䀱䀳", num));
            this.method_81(A_0.method_45());
            this.xmlTextWriter_0.WriteEndElement();
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䀱䐳", num));
            this.method_160(BookmarkStart.b("ᬱ", num));
            this.xmlTextWriter_0.WriteEndElement();
            this.xmlTextWriter_0.WriteEndElement();
        }
    }

    internal bool method_9()
    {
        return this.bool_13;
    }

    private string method_90(RubyAlign A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case RubyAlign.Center:
                return BookmarkStart.b("䠪䠬䄮䔰嘲䜴", num);

            case RubyAlign.DistributeLetter:
                return BookmarkStart.b("伪䐬尮䔰䄲尴唶䰸伺堼ሾⵀ♂ㅄ㍆ⱈ㥊", num);

            case RubyAlign.DistributeSpace:
                return BookmarkStart.b("伪䐬尮䔰䄲尴唶䰸伺堼ሾ㉀㍂⑄⑆ⱈ", num);

            case RubyAlign.Left:
                return BookmarkStart.b("䜪䠬䤮䔰", num);

            case RubyAlign.Right:
                return BookmarkStart.b("太䐬䠮夰䜲", num);
        }
        return BookmarkStart.b("䨪堬嬮帰", num);
    }

    private void method_91(MergeField A_0)
    {
        int num = 4;
        TextRange range = new TextRange(A_0.Document);
        string str2 = ((A_0.Text != string.Empty) || A_0.ConvertedToText) ? A_0.Text : ('\x00ab'.ToString() + A_0.FieldName + '\x00bb'.ToString());
        string[] strArray2 = str2.Split(new char[] { '\r' });
        if (strArray2.Length > 1)
        {
            foreach (string str in strArray2)
            {
                range.Text = str;
                range.ApplyCharacterFormat(A_0.CharacterFormat);
                this.method_81(range);
                this.xmlTextWriter_0.WriteRaw(BookmarkStart.b("ᘩ丫尭Ἧఱ", num));
            }
        }
        else
        {
            range.Text = str2;
            range.ApplyCharacterFormat(A_0.CharacterFormat);
            this.method_81(range);
        }
    }

    private void method_92(Table A_0)
    {
        int num = 6;
        if (A_0.Rows.Count != 0)
        {
            this.method_167(-1);
            List<float> list = this.method_99(A_0);
            if ((A_0 != null) && !A_0.IsHasCaculatedCellWidth)
            {
                A_0.method_46();
            }
            bool flag2 = false;
            if (!A_0.TableFormat.WrapTextAround && (A_0.TableFormat.HorizontalAlignment != RowAlignment.Left))
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("䠫䜭䘯", num));
                flag2 = true;
                switch (A_0.TableFormat.HorizontalAlignment)
                {
                    case RowAlignment.Center:
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴫䈭夯唱娳", num), BookmarkStart.b("伫䬭帯䘱儳䐵", num));
                        break;

                    case RowAlignment.Right:
                        this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䴫䈭夯唱娳", num), BookmarkStart.b("師䜭圯娱䀳", num));
                        break;
                }
            }
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堫伭刯帱儳", num));
            this.method_103(A_0);
            if (A_0.TableFormat.Bidi)
            {
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䠫䜭䈯", num), BookmarkStart.b("師娭尯", num));
            }
            TableRow row = null;
            TableCell cell = null;
            int num4 = 0;
            int count = A_0.Rows.Count;
            while (num4 < count)
            {
                row = A_0.Rows[num4];
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堫尭", num));
                float num6 = 0f;
                this.method_104(row);
                int num2 = 0;
                int num3 = row.Cells.Count;
                while (num2 < num3)
                {
                    cell = row.Cells[num2];
                    if ((cell.CellFormat.VerticalMerge != CellMerge.Continue) && (cell.CellFormat.HorizontalMerge != CellMerge.Continue))
                    {
                        if (row.IsHeader)
                        {
                            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堫䘭", num));
                        }
                        else
                        {
                            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堫䨭", num));
                        }
                        bool flag = false;
                        this.method_96(list, num6, cell, ref flag);
                        float num5 = this.method_102(cell);
                        string str = this.method_112(cell.CellFormat);
                        if (row.IsHeader)
                        {
                            str = str + BookmarkStart.b("堫䬭䠯䘱ᤳ圵吷匹嬻倽稿⹁⅃⁅㱇煉", num);
                        }
                        Paddings paddings = cell.CellFormat.SamePaddingsAsTable ? A_0.TableFormat.Paddings : (!cell.CellFormat.Paddings.IsEmpty ? cell.CellFormat.Paddings : (!cell.OwnerRow.RowFormat.Paddings.IsEmpty ? cell.OwnerRow.RowFormat.Paddings : (!cell.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty ? cell.OwnerRow.OwnerTable.TableFormat.Paddings : new Paddings())));
                        str = str + this.method_110(paddings);
                        if (((num5 > 0f) && !flag) && (cell.WidthType == FtsWidth.Percentage))
                        {
                            str = str + BookmarkStart.b("嬫䜭启䘱尳వ", num) + num5.ToString() + BookmarkStart.b("फᔭ", num);
                        }
                        else if (((num5 > 0f) && !flag) && ((cell.WidthType != FtsWidth.Auto) && (cell.WidthType != FtsWidth.None)))
                        {
                            str = str + BookmarkStart.b("嬫䜭启䘱尳వ", num) + num5.ToString() + BookmarkStart.b("尫嘭ଯ", num);
                        }
                        if (str.Length > 0)
                        {
                            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("弫娭䤯帱儳", num), str);
                        }
                        if (cell.Items.Count == 0)
                        {
                            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("尫", num));
                            this.method_159(cell.CharacterFormat);
                            this.xmlTextWriter_0.WriteEndElement();
                        }
                        foreach (BodyRegion region in cell.Items)
                        {
                            this.method_26(region);
                        }
                        this.method_167(-1);
                        this.xmlTextWriter_0.WriteEndElement();
                        num6 += cell.Width;
                    }
                    else
                    {
                        num6 += cell.Width;
                    }
                    num2++;
                }
                this.xmlTextWriter_0.WriteEndElement();
                num4++;
            }
            this.xmlTextWriter_0.WriteEndElement();
            if (flag2)
            {
                this.xmlTextWriter_0.WriteEndElement();
            }
        }
    }

    private Border method_93(TableCell A_0)
    {
        Border bottom = A_0.CellFormat.Borders.Bottom;
        TableRow ownerRow = A_0.OwnerRow;
        Table ownerTable = ownerRow.OwnerTable;
        int index = ownerTable.Rows.IndexOf(ownerRow);
        int num2 = ownerRow.Cells.IndexOf(A_0);
        for (int i = index; i < ownerTable.Rows.Count; i++)
        {
            if ((num2 < ownerTable.Rows[i].Cells.Count) && (ownerTable.Rows[i].Cells[num2].CellFormat.VerticalMerge == CellMerge.Continue))
            {
                bottom = ownerTable.Rows[i].Cells[num2].CellFormat.Borders.Bottom;
            }
        }
        return bottom;
    }

    private Border method_94(TableCell A_0)
    {
        Border right = A_0.CellFormat.Borders.Right;
        TableRow ownerRow = A_0.OwnerRow;
        for (int i = ownerRow.Cells.IndexOf(A_0); i < ownerRow.Cells.Count; i++)
        {
            if (ownerRow.Cells[i].CellFormat.HorizontalMerge == CellMerge.Continue)
            {
                right = ownerRow.Cells[i].CellFormat.Borders.Right;
            }
        }
        return right;
    }

    private void method_95(List<float> A_0)
    {
        int num = 6;
        if (A_0.Count != 0)
        {
            float num3 = 0f;
            this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堫尭", num));
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("弫娭䤯帱儳", num), string.Format(BookmarkStart.b("圫ḭ䴯࠱伳ܵ䔷䨹䐻Խ", num), BookmarkStart.b("䐫䬭夯唱尳䈵", num), BookmarkStart.b("ᰫ", num)));
            int num2 = 0;
            int count = A_0.Count;
            while (num2 < count)
            {
                this.xmlTextWriter_0.WriteStartElement(BookmarkStart.b("堫䨭", num));
                if (num2 == 0)
                {
                    num3 = A_0[num2];
                }
                else
                {
                    num3 = A_0[num2] - A_0[num2 - 1];
                }
                this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("弫娭䤯帱儳", num), string.Format(BookmarkStart.b("圫ḭ䴯࠱伳ܵ䔷䨹䐻Խ", num), BookmarkStart.b("嬫䜭启䘱尳", num), num3));
                this.xmlTextWriter_0.WriteEndElement();
                num2++;
            }
            this.xmlTextWriter_0.WriteEndElement();
        }
    }

    private void method_96(List<float> A_0, float A_1, TableCell A_2, ref bool A_3)
    {
        int num = 12;
        int gridSpan = 1;
        if (A_2.CellFormat.HorizontalMerge == CellMerge.Start)
        {
            gridSpan = this.method_101(A_2);
        }
        else
        {
            A_1 = (float) Math.Round((double) A_1, 2);
            gridSpan = this.method_100(A_0, A_1, A_2.Width);
        }
        if ((gridSpan == 1) && (A_2.GridSpan > 1))
        {
            gridSpan = A_2.GridSpan;
        }
        if (gridSpan > 1)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("儱嬳娵䬷䨹崻倽", num), gridSpan.ToString());
            A_3 = true;
            gridSpan = 1;
        }
        if (A_2.CellFormat.VerticalMerge == CellMerge.Start)
        {
            this.xmlTextWriter_0.WriteAttributeString(BookmarkStart.b("䀱嬳䄵䬷䨹崻倽", num), this.method_97(A_2, A_1).ToString());
        }
    }

    private int method_97(TableCell A_0, float A_1)
    {
        int num = 1;
        TableRow ownerRow = A_0.OwnerRow;
        Table ownerTable = ownerRow.OwnerTable;
        A_0.GetCellIndex();
        int num3 = ownerRow.GetRowIndex() + 1;
        int count = ownerTable.Rows.Count;
        while (num3 < count)
        {
            TableCell cell = this.method_98(ownerTable.Rows[num3], A_1);
            if ((cell == null) || ((cell != null) && (A_0.Width != cell.Width)))
            {
                return num;
            }
            if (cell.CellFormat.VerticalMerge != CellMerge.Continue)
            {
                return num;
            }
            num++;
            num3++;
        }
        return num;
    }

    private TableCell method_98(TableRow A_0, float A_1)
    {
        float num = 0f;
        int num2 = 0;
        int count = A_0.Cells.Count;
        while (num2 < count)
        {
            if (((float) Math.Round((double) num, 2)) == A_1)
            {
                return A_0.Cells[num2];
            }
            num += A_0.Cells[num2].Width;
            num2++;
        }
        return null;
    }

    private List<float> method_99(Table A_0)
    {
        List<float> list = new List<float>();
        int num = 0;
        int count = A_0.Rows.Count;
        while (num < count)
        {
            TableRow row = A_0.Rows[num];
            float num5 = 0f;
            int num3 = 0;
            int num4 = row.Cells.Count;
            while (num3 < num4)
            {
                TableCell cell = row.Cells[num3];
                num5 += cell.Width;
                float item = (float) Math.Round((double) num5, 2);
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
                num3++;
            }
            num++;
        }
        list.Sort();
        return list;
    }
}

