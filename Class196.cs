using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Rendering;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Doc.Rendering;
using Spire.Layouting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal class Class196 : Class195
{
    private Bitmap bitmap_0;
    private BookmarkLevel bookmarkLevel_1;
    private bool bool_16;
    private bool bool_17;
    private bool bool_18;
    private bool bool_19;
    private bool bool_20;
    private const char char_0 = '\x001e';
    private const char char_1 = '\x00ad';
    internal const char char_2 = ' ';
    private const char char_3 = '\x00a0';
    private const char char_4 = '\x0016';
    private Class202 class202_0;
    private Class204 class204_0;
    private Class307 class307_0;
    private Class376 class376_0;
    private Class774 class774_0;
    [ThreadStatic]
    private static Dictionary<FontFamily, Struct2> dictionary_2;
    [ThreadStatic]
    private static Dictionary<Font, Struct1> dictionary_3;
    [ThreadStatic]
    private static Dictionary<string, Font> dictionary_4;
    [ThreadStatic]
    private static Dictionary<sprᝪ, Struct1> dictionary_5;
    [ThreadStatic]
    private static Dictionary<string, sprᝪ> dictionary_6;
    private Dictionary<int, Class375> dictionary_7;
    internal Field field_0;
    private const float float_10 = 1.4f;
    private float float_11;
    private float float_12;
    private const float float_7 = 1.5f;
    private const float float_8 = 0.2f;
    private const float float_9 = 0.6f;
    private Graphics graphics_0;
    internal int int_6;
    private Interface18 interface18_0;
    private List<Dictionary<string, RectangleF>> list_12;
    private List<BookmarkLevel> list_13;
    private List<Footnote> list_14;
    private List<Dictionary<string, Class310>> list_15;
    internal Paragraph paragraph_1;
    internal RectangleF rectangleF_0;
    private SizeF sizeF_0;
    private const string string_0 = "W";
    private const string string_1 = "i";
    private string string_2;
    private string string_3;
    private string string_4;
    internal TextRange textRange_0;

    internal Class196()
    {
        this.string_2 = ' '.ToString();
        this.string_3 = '\x00a0'.ToString();
        this.rectangleF_0 = new RectangleF();
        this.int_6 = 1;
        this.list_12 = new List<Dictionary<string, RectangleF>>();
        this.string_4 = "";
        this.list_13 = new List<BookmarkLevel>();
        this.list_15 = new List<Dictionary<string, Class310>>();
        this.class204_0 = new Class204();
        this.class202_0 = new Class202();
        this.float_11 = float.MinValue;
        this.float_12 = float.MinValue;
        this.bitmap_0 = new Bitmap(1, 1);
        this.method_152(Graphics.FromImage(this.bitmap_0));
        this.bitmap_0.SetResolution(96f, 96f);
        this.method_151().PageUnit = GraphicsUnit.Point;
    }

    internal Class196(Class307 A_0, SizeF A_1) : this(A_0, A_1, null)
    {
    }

    internal Class196(Graphics A_0, GraphicsUnit A_1)
    {
        int num = 1;
        this.string_2 = ' '.ToString();
        this.string_3 = '\x00a0'.ToString();
        this.rectangleF_0 = new RectangleF();
        this.int_6 = 1;
        this.list_12 = new List<Dictionary<string, RectangleF>>();
        this.string_4 = "";
        this.list_13 = new List<BookmarkLevel>();
        this.list_15 = new List<Dictionary<string, Class310>>();
        this.class204_0 = new Class204();
        this.class202_0 = new Class202();
        this.float_11 = float.MinValue;
        this.float_12 = float.MinValue;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("怦嬨䨪崬䜮堰倲䘴", num));
        }
        this.graphics_0 = A_0;
        this.graphics_0.PageUnit = A_1;
    }

    internal Class196(Class307 A_0, SizeF A_1, Graphics A_2)
    {
        int num = 2;
        this.string_2 = ' '.ToString();
        this.string_3 = '\x00a0'.ToString();
        this.rectangleF_0 = new RectangleF();
        this.int_6 = 1;
        this.list_12 = new List<Dictionary<string, RectangleF>>();
        this.string_4 = "";
        this.list_13 = new List<BookmarkLevel>();
        this.list_15 = new List<Dictionary<string, Class310>>();
        this.class204_0 = new Class204();
        this.class202_0 = new Class202();
        this.float_11 = float.MinValue;
        this.float_12 = float.MinValue;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("缧䔩師䨭戯圱娳刵崷䠹缻儽⸿㙁⅃㹅㱇", num));
        }
        this.graphics_0 = A_2;
        this.class307_0 = A_0;
        base.nullable_0 = true;
        this.sizeF_0 = A_1;
    }

    internal Class196(Graphics A_0, GraphicsUnit A_1, SizeF A_2)
    {
        int num = 15;
        this.string_2 = ' '.ToString();
        this.string_3 = '\x00a0'.ToString();
        this.rectangleF_0 = new RectangleF();
        this.int_6 = 1;
        this.list_12 = new List<Dictionary<string, RectangleF>>();
        this.string_4 = "";
        this.list_13 = new List<BookmarkLevel>();
        this.list_15 = new List<Dictionary<string, Class310>>();
        this.class204_0 = new Class204();
        this.class202_0 = new Class202();
        this.float_11 = float.MinValue;
        this.float_12 = float.MinValue;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("爴䔶堸䬺唼嘾≀あ", num));
        }
        this.graphics_0 = A_0;
        this.graphics_0.PageUnit = A_1;
        this.sizeF_0 = A_2;
    }

    private Dictionary<FontFamily, Struct2> method_121()
    {
        if (dictionary_2 == null)
        {
            dictionary_2 = new Dictionary<FontFamily, Struct2>();
        }
        return dictionary_2;
    }

    private Dictionary<Font, Struct1> method_122()
    {
        if (dictionary_3 == null)
        {
            dictionary_3 = new Dictionary<Font, Struct1>();
        }
        return dictionary_3;
    }

    private Dictionary<string, Font> method_123()
    {
        if (dictionary_4 == null)
        {
            dictionary_4 = new Dictionary<string, Font>();
        }
        return dictionary_4;
    }

    private Dictionary<sprᝪ, Struct1> method_124()
    {
        if (dictionary_5 == null)
        {
            dictionary_5 = new Dictionary<sprᝪ, Struct1>();
        }
        return dictionary_5;
    }

    private Dictionary<string, sprᝪ> method_125()
    {
        if (dictionary_6 == null)
        {
            dictionary_6 = new Dictionary<string, sprᝪ>();
        }
        return dictionary_6;
    }

    internal Class307 method_126()
    {
        return this.class307_0;
    }

    internal List<Footnote> method_127()
    {
        if (this.list_14 == null)
        {
            this.list_14 = new List<Footnote>();
        }
        return this.list_14;
    }

    public Class774 method_128()
    {
        return this.class774_0;
    }

    public void method_129(Class774 A_0)
    {
        this.class774_0 = A_0;
    }

    internal Class376 method_130()
    {
        if (this.class376_0 == null)
        {
            this.class376_0 = new Class376();
        }
        return this.class376_0;
    }

    internal void method_131(Class376 A_0)
    {
        this.class376_0 = A_0;
    }

    internal Interface18 method_132()
    {
        return this.interface18_0;
    }

    internal void method_133(Interface18 A_0)
    {
        this.interface18_0 = A_0;
    }

    private SizeF method_134()
    {
        return this.sizeF_0;
    }

    internal bool method_135()
    {
        return this.bool_20;
    }

    internal void method_136(bool A_0)
    {
        this.bool_20 = A_0;
    }

    internal bool method_137()
    {
        return ((this.method_135() && (this.method_132() is Class195.Class197)) && (this.method_132() as Class195.Class197).method_2());
    }

    internal bool method_138()
    {
        return ((this.method_135() && (this.method_132() is Class195.Class197)) && !(this.method_132() as Class195.Class197).method_2());
    }

    internal bool method_139()
    {
        return this.bool_18;
    }

    internal void method_140(bool A_0)
    {
        this.bool_18 = A_0;
    }

    internal bool method_141()
    {
        return this.bool_16;
    }

    internal void method_142(bool A_0)
    {
        this.bool_16 = A_0;
    }

    internal bool method_143()
    {
        return this.bool_17;
    }

    internal void method_144(bool A_0)
    {
        this.bool_17 = A_0;
    }

    internal List<Dictionary<string, Class310>> method_145()
    {
        if (this.list_15 == null)
        {
            this.list_15 = new List<Dictionary<string, Class310>>();
        }
        return this.list_15;
    }

    internal void method_146(List<Dictionary<string, Class310>> A_0)
    {
        this.list_15 = A_0;
    }

    internal List<BookmarkLevel> method_147()
    {
        if (this.list_13 == null)
        {
            this.list_13 = new List<BookmarkLevel>();
        }
        return this.list_13;
    }

    internal void method_148(List<BookmarkLevel> A_0)
    {
        this.list_13 = A_0;
    }

    internal BookmarkLevel method_149()
    {
        return this.bookmarkLevel_1;
    }

    internal void method_150(BookmarkLevel A_0)
    {
        this.bookmarkLevel_1 = A_0;
    }

    internal Graphics method_151()
    {
        return this.graphics_0;
    }

    internal void method_152(Graphics A_0)
    {
        if (this.graphics_0 != A_0)
        {
            this.graphics_0 = A_0;
        }
    }

    public List<Dictionary<string, RectangleF>> method_153()
    {
        return this.list_12;
    }

    internal Dictionary<int, Class375> method_154()
    {
        if (this.dictionary_7 == null)
        {
            this.dictionary_7 = new Dictionary<int, Class375>();
        }
        return this.dictionary_7;
    }

    internal void method_155(List<string> A_0)
    {
        foreach (string str in A_0)
        {
            if (File.Exists(str))
            {
                this.class202_0.method_2(str);
            }
        }
    }

    internal void method_156()
    {
        string str = BookmarkStart.b("瀴䄶堸场䠼帾㕀⩂⩄⥆楈᱊ⱌ㵎㽐㩒㭔ざ祘慚絜୞ॠ٢䕤ᅦ౨ᥪṬٮṰᵲ啴ᑶᡸᕺ嵼ᵾꎂ권ﾐﾒ랖ﾘ뾞쒠햢쒤쮦\udca8\ucaaa\ud9ac\uc6ae\udeb0\uddb2閴잶첸즺춼킾닀ꛂ", 15);
        Class198 class2 = new Class198 {
            drawingTextDirection_0 = DrawingTextDirection.Horizontal
        };
        this.method_249(str, class2, new Font(BookmarkStart.b("琴䔶倸娺儼", 15), 11f), Color.Red, new RectangleF(0f, 0f, float.MaxValue, float.MaxValue), new StringFormat());
    }

    internal void method_157()
    {
        List<int> list = new List<int>(this.method_154().Keys);
        list.Sort();
        foreach (int num in list)
        {
            this.method_154()[num].method_88(this);
        }
        this.method_154().Clear();
        this.int_6 = 1;
    }

    internal void method_158(Paragraph A_0, Class375 A_1)
    {
        int num = 5;
        if (A_1.method_69().Height > 0f)
        {
            ParagraphStyle style = A_0.GetStyle();
            this.paragraph_1 = A_0;
            this.rectangleF_0 = this.method_159(A_0, A_1);
            if (((style != null) && (style.ListFormat.CurrentListLevel != null)) && style.ListFormat.HasValue(0))
            {
                ListFormat listFormat = style.ListFormat;
            }
            else
            {
                ListFormat format2 = A_0.ListFormat;
            }
            Class375 class2 = null;
            if (!A_0.SectionEndMark || !string.IsNullOrEmpty(A_0.Text))
            {
                if (A_1.method_0())
                {
                    int num2 = 0;
                    int count = A_1.method_74().Count;
                    while (num2 < count)
                    {
                        Class375 class3 = A_1.method_74().method_4(num2);
                        if (class3.method_0())
                        {
                            HorizontalAlignment alignment = (A_1.method_73().imethod_0() as Class213).method_17();
                            int num4 = 0;
                            int num5 = class3.method_74().Count;
                            while (num4 < num5)
                            {
                                float num6;
                                int num7;
                                Class375 class5;
                                int num8;
                                Class375 class6;
                                int num9;
                                Class375 class7;
                                Class375 class4 = class3.method_74().method_4(num4);
                                if (class4.method_0() && (class4.method_73() is Field))
                                {
                                    Field field = class4.method_73() as Field;
                                    SizeF size = class4.method_69().Size;
                                    SizeF ef4 = this.method_323(field, class4.method_64());
                                    num6 = size.Width - ef4.Width;
                                    class4.method_70(new RectangleF(class4.method_69().Location, new SizeF(class4.method_69().Width - num6, class4.method_69().Height)));
                                    switch (alignment)
                                    {
                                        case HorizontalAlignment.Left:
                                            num7 = num4 + 1;
                                            goto Label_0217;

                                        case HorizontalAlignment.Center:
                                            num9 = num4 + 1;
                                            goto Label_0284;

                                        case HorizontalAlignment.Right:
                                            num8 = num4;
                                            goto Label_0357;
                                    }
                                }
                                goto Label_035C;
                            Label_01BD:
                                class5 = class3.method_74().method_4(num7);
                                class5.method_70(new RectangleF(new PointF(class5.method_69().X - num6, class5.method_69().Y), class5.method_69().Size));
                                num7++;
                            Label_0217:
                                if (num7 < num5)
                                {
                                    goto Label_01BD;
                                }
                                goto Label_035C;
                            Label_022A:
                                class7 = class3.method_74().method_4(num9);
                                class7.method_70(new RectangleF(new PointF(class7.method_69().X - num6, class7.method_69().Y), class7.method_69().Size));
                                num9++;
                            Label_0284:
                                if (num9 < num5)
                                {
                                    goto Label_022A;
                                }
                                for (int j = 0; j < num5; j++)
                                {
                                    Class375 class8 = class3.method_74().method_4(j);
                                    class8.method_70(new RectangleF(new PointF(class8.method_69().X + (num6 / 2f), class8.method_69().Y), class8.method_69().Size));
                                }
                                goto Label_035C;
                            Label_02FD:
                                class6 = class3.method_74().method_4(num8);
                                class6.method_70(new RectangleF(new PointF(class6.method_69().X + num6, class6.method_69().Y), class6.method_69().Size));
                                num8--;
                            Label_0357:
                                if (num8 >= 0)
                                {
                                    goto Label_02FD;
                                }
                            Label_035C:
                                num4++;
                            }
                        }
                        num2++;
                    }
                }
                new RectangleF(A_1.method_69().X, A_1.method_69().Y, A_1.method_69().Width, A_1.method_69().Height);
                if ((!A_0.Format.BackColor.IsEmpty && (A_0.Format.BackColor.ToArgb() != -1)) || ((A_0.Format.BackColor.IsEmpty && (A_0.ParaStyle != null)) && !A_0.ParaStyle.ParagraphFormat.BackColor.IsEmpty))
                {
                    RectangleF ef22 = this.method_163(A_0, A_1);
                    this.method_162(A_0, ef22);
                }
                if (A_0.Format.TextureStyle != TextureStyle.TextureNone)
                {
                    RectangleF ef23 = this.method_163(A_0, A_1);
                    this.method_278(A_0.Format.TextureStyle, A_0.Format.ForeColor, A_0.Format.BackColor, ef23);
                }
                if (((A_1.method_73() is Paragraph) && (A_1.method_74().Count > 0)) && (A_1.method_74().method_4(0).method_73() is Paragraph))
                {
                    Class375 class9 = A_1.method_74().method_4(0);
                    class9.method_53(true);
                    for (int k = 0; k < class9.method_74().Count; k++)
                    {
                        class9.method_74().method_4(k).method_53(true);
                    }
                    if (A_1.method_64() != BookmarkStart.b("砪崬䌮堰䜲䄴制崸", num))
                    {
                        Class375 class10 = A_1.method_74().method_4(A_1.method_74().Count - 1);
                        class10.method_55(true);
                        for (int m = 0; m < class10.method_74().Count; m++)
                        {
                            class10.method_74().method_4(m).method_55(true);
                        }
                    }
                }
                if ((A_1.method_64() != BookmarkStart.b("砪崬䌮堰䜲䄴制崸", num)) && (A_1.method_74().Count > 0))
                {
                    int num13 = 0;
                    int num14 = A_1.method_74().Count - 1;
                    while (num13 < A_1.method_74().Count)
                    {
                        class2 = A_1.method_74().method_4(num13);
                        bool flag = false;
                        if (num13 < num14)
                        {
                            Class375 class11 = A_1.method_74().method_4(num13 + 1);
                            if (class11.method_73() is Break)
                            {
                                flag = true;
                            }
                            else if (class11.method_73() is Class65)
                            {
                                Class65 class12 = class11.method_73() as Class65;
                                if (class12.imethod_4(0) is Break)
                                {
                                    flag = true;
                                }
                            }
                        }
                        else
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            for (int n = 0; n < class2.method_74().Count; n++)
                            {
                                class2.method_74().method_4(n).method_55(true);
                            }
                            if ((class2.method_74().Count > 0) && (class2.method_74().method_4(0).method_60() == HorizontalAlignment.Justify))
                            {
                                class2.method_74().method_4(0).method_70(new RectangleF(class2.method_74().method_4(0).method_69().X, class2.method_74().method_4(0).method_69().Y, class2.method_74().method_4(0).method_69().Width - Convert.ToSingle((float) (class2.method_74().method_4(0).method_50() * class2.method_74().method_4(0).method_62())), class2.method_74().method_4(0).method_69().Height));
                                for (int num16 = 1; num16 < class2.method_74().Count; num16++)
                                {
                                    if (!class2.method_74().method_4(num16 - 1).method_73().imethod_0().imethod_14() && !class2.method_74().method_4(num16 - 1).method_73().imethod_0().imethod_16())
                                    {
                                        Class375 class13 = class2.method_74().method_4(num16);
                                        if (class13.method_62() > 0f)
                                        {
                                            float width = class13.method_69().Width - ((class13.method_58() != 0f) ? Convert.ToSingle((float) (class13.method_50() * class13.method_62())) : 0f);
                                            if ((class13.method_48() != TabJustification.Right) && (class13.method_48() != TabJustification.Centered))
                                            {
                                                class13.method_70(new RectangleF(class13.method_69().X, class13.method_69().Y, width, class13.method_69().Height));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Class375 class14 = class2.method_74().method_4(num16 - 1);
                                        Class375 class15 = class2.method_74().method_4(num16);
                                        float num18 = class15.method_69().Width - ((class15.method_58() != 0f) ? Convert.ToSingle((float) (class15.method_50() * class15.method_62())) : 0f);
                                        if (!(class15.method_73() is DocPicture) && (!(class15.method_73() is DocOleObject) || ((class15.method_73() as DocOleObject).Interface49.get_OlePicture() == null)))
                                        {
                                            num18 = class15.method_69().Width - ((class15.method_58() != 0f) ? Convert.ToSingle((float) (class15.method_50() * class15.method_62())) : 0f);
                                            if ((class15.method_48() != TabJustification.Right) && (class15.method_48() != TabJustification.Centered))
                                            {
                                                class15.method_70(new RectangleF(class14.method_69().X + class14.method_69().Width, class15.method_69().Y, num18, class15.method_69().Height));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        num13++;
                    }
                    this.method_160(A_0, A_1);
                }
                for (int i = 0; i < A_1.method_74().Count; i++)
                {
                    Class375 class16 = A_1.method_74().method_4(i);
                    this.method_167(class16);
                }
                if (!this.method_166(A_1))
                {
                    this.method_189(A_0, A_1, true);
                }
                this.method_261(A_0, A_0.Format, A_1);
            }
        }
    }

    private RectangleF method_159(Paragraph A_0, Class375 A_1)
    {
        RectangleF ef = A_1.method_69();
        Section section = A_0.method_49();
        if (section != null)
        {
            if (section.Columns.Count <= 1)
            {
                float clientWidth = section.PageSetup.ClientWidth;
                float num3 = (section.PageSetup.PageSize.Width - section.PageSetup.Margins.Right) - A_0.Format.RightIndent;
                return new RectangleF(ef.Location, new SizeF(num3 - ef.Left, ef.Height));
            }
            int num2 = A_1.method_4();
            if ((num2 > -1) && (num2 < section.Columns.Count))
            {
                float width = section.Columns[num2].Width;
                if (Class59.smethod_4(ef.Width, width, 0.005f) < 0)
                {
                    ef = new RectangleF(ef.Location, new SizeF(width - A_0.Format.RightIndent, ef.Height));
                }
            }
        }
        return ef;
    }

    private void method_160(Paragraph A_0, Class375 A_1)
    {
        for (int i = 0; i < A_0.Format.Tabs.Count; i++)
        {
            if (A_0.Format.Tabs[i].Justification == TabJustification.Bar)
            {
                PointF tf = new PointF(A_0.Format.Tabs[i].Position + A_1.method_69().X, A_1.method_69().Y);
                PointF tf2 = new PointF(A_0.Format.Tabs[i].Position + A_1.method_69().X, A_1.method_69().Bottom + A_0.Format.AfterSpacing);
                this.method_151().DrawLine(Pens.Black, tf, tf2);
            }
        }
    }

    internal void method_161(Paragraph A_0, Class375 A_1)
    {
        DocumentObject obj2 = this.method_165(A_0.Owner);
        RectangleF ef = A_1.method_69();
        float num = this.method_263(A_1);
        if (num != ef.Top)
        {
            float num2 = ef.Y - num;
            ef.Y = num;
            ef.Height += num2;
        }
        if (!A_0.Format.Borders.NoBorder)
        {
            ef.Y -= A_0.Format.Borders.Top.LineWidth;
            ef.Height += A_0.Format.Borders.Top.LineWidth + A_0.Format.Borders.Bottom.LineWidth;
        }
        if (obj2 is Section)
        {
            Color color = A_0.Format.HasValue(0x15) ? A_0.Format.BackColor : ((A_0.ParaStyle != null) ? A_0.ParaStyle.ParagraphFormat.BackColor : Color.Empty);
            if (A_0.Format.IsFrame)
            {
                float frameWidthEx = A_0.Format.FrameWidthEx;
                ef.Width = (ef.Width < frameWidthEx) ? frameWidthEx : ef.Width;
                this.method_286(color, ef);
            }
            else
            {
                ef = new RectangleF((obj2 as Section).PageSetup.Margins.Left + A_0.Format.LeftIndent, ef.Y, ((obj2 as Section).PageSetup.ClientWidth - A_0.Format.LeftIndent) - A_0.Format.RightIndent, ef.Height);
                this.method_286(color, ef);
            }
        }
    }

    internal void method_162(Paragraph A_0, RectangleF A_1)
    {
        if (this.method_165(A_0.Owner) is Section)
        {
            Color color = A_0.Format.HasValue(0x15) ? A_0.Format.BackColor : ((A_0.ParaStyle != null) ? A_0.ParaStyle.ParagraphFormat.BackColor : Color.Empty);
            if (!color.IsEmpty)
            {
                this.method_286(color, A_1);
            }
        }
    }

    internal RectangleF method_163(Paragraph A_0, Class375 A_1)
    {
        bool flag = true;
        bool flag2 = true;
        return this.method_164(A_0, A_1, out flag, out flag2);
    }

    private RectangleF method_164(Paragraph A_0, Class375 A_1, out bool A_2, out bool A_3)
    {
        A_2 = true;
        A_3 = true;
        ParagraphFormat format = A_0.Format;
        Borders borders = format.Borders;
        Borders borders2 = A_0.ParaStyle.ParagraphFormat.Borders;
        Border border3 = ((borders.Left.BorderType != BorderStyle.None) || borders.Left.IsChanged) ? borders.Left : borders2.Left;
        Border border4 = ((borders.Right.BorderType != BorderStyle.None) || borders.Right.IsChanged) ? borders.Right : borders2.Right;
        Border border2 = ((borders.Top.BorderType != BorderStyle.None) || borders.Top.IsChanged) ? borders.Top : borders2.Top;
        Border border = ((borders.Bottom.BorderType != BorderStyle.None) || borders.Bottom.IsChanged) ? borders.Bottom : borders2.Bottom;
        RectangleF ef3 = A_1.method_69();
        Class372 class2 = A_1.method_73().imethod_0().imethod_0();
        if (((A_1.method_74().Count == 1) && (A_1.method_74().method_4(0).method_73() is Paragraph)) && (A_1.method_74().method_4(0).method_69().X < ef3.X))
        {
            float num12 = ef3.X - A_1.method_74().method_4(0).method_69().X;
            ef3 = new RectangleF(new PointF(ef3.X - num12, ef3.Y), new SizeF(ef3.Width + num12, ef3.Height));
        }
        ef3.Width = (ef3.Width - format.LeftIndent) - format.RightIndent;
        float right = ef3.Right;
        if (A_0.IsInCell)
        {
            TableCell owner = A_0.Owner as TableCell;
            TableRow ownerRow = owner.OwnerRow;
            Table ownerTable = ownerRow.OwnerTable;
            if (owner != null)
            {
                float left = owner.Bounds.Left;
                float layoutWidth = owner.LayoutWidth;
                float paddingWidth = 0f;
                float num5 = ((ownerRow.RowFormat == null) || (ownerRow.RowFormat.CellSpacingEx == -1f)) ? ownerTable.TableFormat.CellSpacingEx : ownerRow.RowFormat.CellSpacingEx;
                num5 = (num5 > 0f) ? num5 : 0f;
                if (owner.CellFormat.SamePaddingsAsTable)
                {
                    if (!ownerRow.RowFormat.Paddings.IsEmpty)
                    {
                        paddingWidth = ownerRow.RowFormat.Paddings.Right;
                    }
                    else if (!ownerTable.TableFormat.Paddings.IsEmpty)
                    {
                        paddingWidth = ownerTable.TableFormat.Paddings.PaddingWidth;
                    }
                    else if ((ownerRow.RowFormat.Paddings.IsEmpty && ownerTable.TableFormat.Paddings.IsEmpty) && (ownerRow.RowFormat.Paddings.IsDefault && ownerTable.TableFormat.Paddings.IsDefault))
                    {
                        paddingWidth = 5.4f;
                    }
                }
                else
                {
                    paddingWidth = owner.CellFormat.Paddings.Right;
                }
                right = (((left + layoutWidth) - num5) - paddingWidth) - format.RightIndent;
            }
        }
        else
        {
            Section section = null;
            if ((A_1.method_72() != null) && (A_1.method_72().method_30() != null))
            {
                section = A_1.method_72().method_30() as Section;
            }
            else
            {
                section = A_0.method_49();
            }
            if ((section != null) && (section.Columns.Count <= 1))
            {
                float clientWidth = section.PageSetup.ClientWidth;
                right = (section.PageSetup.PageSize.Width - section.PageSetup.Margins.Right) - format.RightIndent;
            }
        }
        if (Math.Round((double) ef3.Right, 2) != Math.Round((double) right, 2))
        {
            ef3.Width = right - ef3.X;
        }
        float num6 = this.method_263(A_1);
        if ((Class59.smethod_4(num6, ef3.Top, 0.005f) != 0) && (Class59.smethod_4(ef3.Top + ((float) class2.method_4()), num6, 0.005f) != 0))
        {
            float num10 = ef3.Y - num6;
            ef3.Y = num6;
            ef3.Height += num10;
        }
        if ((format.IsFrame && (A_1.method_74().Count > 0)) && (A_1.method_74().method_4(0).method_73() is Paragraph))
        {
            SizeF size = new SizeF(A_1.method_74().method_4(0).method_69().Right - ef3.X, A_1.method_74().method_4(0).method_69().Height);
            if (format.FrameWidthRule == FrameSizeRule.Exact)
            {
                size.Width = format.FrameWidthEx;
            }
            int num = 1;
            int count = A_1.method_74().Count;
            while (num < count)
            {
                RectangleF ef = A_1.method_74().method_4(num).method_69();
                if (format.FrameWidthRule == FrameSizeRule.Auto)
                {
                    size.Width = Math.Max(size.Width, ef.Right - ef3.X);
                }
                size.Height += ef.Height;
                num++;
            }
            if (format.LeftIndent != 0f)
            {
                size.Width -= format.LeftIndent;
            }
            if (format.RightIndent != 0f)
            {
                size.Width -= format.RightIndent;
            }
            ef3 = new RectangleF(ef3.Location, size);
        }
        if ((((A_1.method_72() != null) && (A_1.method_72().method_0() == DrawPageState.DrawBody)) && ((A_1.method_72().method_3().Count > 2) && !A_0.method_46())) && (ef3.Bottom > A_1.method_72().method_3().method_4(1).method_69().Top))
        {
            float num11 = ef3.Bottom - A_1.method_72().method_3().method_4(1).method_69().Top;
            ef3 = new RectangleF(ef3.Location, new SizeF(ef3.Width, ef3.Height - num11));
        }
        if (border3 != null)
        {
            float num2 = 1.4f - (border3.LineWidth * 0.6f);
            num2 = (num2 > 0f) ? num2 : 0f;
            float num7 = border3.Space + num2;
            ef3.X -= num7;
            ef3.Width += num7;
        }
        if (border4 != null)
        {
            float num8 = 1.4f - (border4.LineWidth * 0.6f);
            num8 = (num8 > 0f) ? num8 : 0f;
            float num9 = border4.Space + num8;
            ef3.Width += num9;
        }
        if ((A_0.NextSibling != null) && (A_0.NextSibling is Paragraph))
        {
            Borders borders3 = !(A_0.NextSibling as Paragraph).Format.Borders.NoBorder ? (A_0.NextSibling as Paragraph).Format.Borders : ((((A_0.NextSibling as Paragraph).ParaStyle == null) || ((A_0.NextSibling as Paragraph).ParaStyle.ParagraphFormat == null)) ? null : (A_0.NextSibling as Paragraph).ParaStyle.ParagraphFormat.Borders);
            if ((borders3 != null) && !borders3.NoBorder)
            {
                if (((borders3.Top.BorderType != BorderStyle.None) && this.method_262(borders3.Top, border)) || (this.method_262(borders3.Bottom, border) && this.method_262(borders3.Top, border2)))
                {
                    A_2 = false;
                }
                if (!A_2 && (!format.IsContextualSpacing || (A_0.ParaStyle.Name != (A_0.PreviousSibling as Paragraph).ParaStyle.Name)))
                {
                    ef3.Height += format.AfterSpacing + ((float) class2.method_12());
                }
            }
        }
        if ((A_0.PreviousSibling != null) && (A_0.PreviousSibling is Paragraph))
        {
            Borders borders4 = !(A_0.PreviousSibling as Paragraph).Format.Borders.NoBorder ? (A_0.PreviousSibling as Paragraph).Format.Borders : ((((A_0.PreviousSibling as Paragraph).ParaStyle == null) || ((A_0.PreviousSibling as Paragraph).ParaStyle.ParagraphFormat == null)) ? null : (A_0.PreviousSibling as Paragraph).ParaStyle.ParagraphFormat.Borders);
            if (!borders4.NoBorder)
            {
                if (((borders4.Bottom.BorderType != BorderStyle.None) && this.method_262(borders4.Bottom, border2)) || (this.method_262(borders4.Bottom, border) && this.method_262(borders4.Top, border2)))
                {
                    A_3 = false;
                }
                if (!A_3 && (!format.IsContextualSpacing || (A_0.ParaStyle.Name != (A_0.PreviousSibling as Paragraph).ParaStyle.Name)))
                {
                    ef3.Y -= format.BeforeSpacing;
                    ef3.Height += format.BeforeSpacing;
                }
            }
        }
        float num18 = 0f;
        this.method_188(A_0, A_1, ref num18);
        if ((A_1.method_73().imethod_0() is Class213) && ((A_1.method_73().imethod_0() as Class213).method_61() != 0f))
        {
            float num13 = (A_1.method_73().imethod_0() as Class213).method_61();
            float num14 = ef3.X - num13;
            ef3.X -= num14;
            ef3.Width += num14;
        }
        return ef3;
    }

    private DocumentObject method_165(DocumentObject A_0)
    {
        if (!(A_0 is Section))
        {
            while (A_0 != null)
            {
                if ((A_0 is Section) || (A_0 is TableCell))
                {
                    return A_0;
                }
                A_0 = A_0.Owner;
            }
        }
        return A_0;
    }

    internal bool method_166(Class375 A_0)
    {
        if (((A_0 != null) && (A_0.method_74().Count > 0)) && (A_0.method_74().method_4(0).method_74().Count > 0))
        {
            for (int i = 0; i < A_0.method_74().method_4(0).method_74().Count; i++)
            {
                Class375 class2 = A_0.method_74().method_4(0).method_74().method_4(i);
                if (((class2.method_73() != null) && (class2.method_73() is Break)) && (((class2.method_73() as Break).BreakType != BreakType.LineBreak) && !(class2.method_73() as Break).method_28().IsInCell))
                {
                    return true;
                }
                if (((Math.Round((double) class2.method_69().Width, 2) > 0.0) && (class2.method_73() != null)) && !(class2.method_73() is Break))
                {
                    return false;
                }
            }
        }
        return false;
    }

    internal void method_167(Class375 A_0)
    {
        if (A_0 != null)
        {
            float width = 0f;
            int num2 = 0;
            bool flag = true;
            for (int i = 0; i < A_0.method_74().Count; i++)
            {
                Class206 class4 = A_0.method_74().method_4(i).method_73().imethod_0() as Class206;
                if ((A_0.method_74().method_4(i).method_48() != TabJustification.Right) || (class4 != null))
                {
                    goto Label_041B;
                }
                if (flag && (i >= 1))
                {
                    num2 = i;
                    flag = false;
                    Class206 class2 = A_0.method_74().method_4(i - 1).method_73().imethod_0() as Class206;
                    if (class2 != null)
                    {
                        int num9 = this.method_187(A_0, num2);
                        float num8 = A_0.method_74().method_4(num9).method_69().Right - A_0.method_74().method_4(num2).method_69().X;
                        Section section2 = this.paragraph_1.method_49();
                        int num15 = section2.Document.Settings.method_3();
                        float num6 = section2.PageSetup.ClientWidth + section2.PageSetup.Margins.Left;
                        if ((num15 >= 15) && (class2.class215_0.method_4() > num6))
                        {
                            class2.method_19(num6 - A_0.method_74().method_4(num2).method_69().X);
                        }
                        float num7 = (class2.method_18() != 0f) ? class2.method_18() : (class2.class215_0.method_4() - A_0.method_74().method_4(num2).method_69().X);
                        if ((Math.Round((double) num8, 2) > Math.Round((double) num7, 2)) && (Math.Round((double) num6) > Math.Round((double) A_0.method_74().method_4(num9).method_69().Right)))
                        {
                            if (num7 > 0f)
                            {
                                width = num7;
                                A_0.method_74().method_4(num2 - 1).method_70(new RectangleF(A_0.method_74().method_4(num2 - 1).method_69().X, A_0.method_74().method_4(num2 - 1).method_69().Y, width, A_0.method_74().method_4(num2 - 1).method_69().Height));
                            }
                            else
                            {
                                width = 0f;
                            }
                        }
                        else
                        {
                            width = ((num7 - num8) >= 0f) ? (num7 - num8) : 0f;
                            A_0.method_74().method_4(num2 - 1).method_70(new RectangleF(A_0.method_74().method_4(num2 - 1).method_69().X, A_0.method_74().method_4(num2 - 1).method_69().Y, width, A_0.method_74().method_4(num2 - 1).method_69().Height));
                        }
                    }
                    else
                    {
                        width = 0f;
                    }
                }
                goto Label_0422;
            Label_02E9:
                if (((A_0.method_74().method_4(num2).method_48() == TabJustification.Right) && !(A_0.method_74().method_4(num2).method_73().imethod_0() is Class206)) && (!(A_0.method_74().method_4(num2).method_73() is DocPicture) || (((A_0.method_74().method_4(num2).method_73() is DocPicture) && ((A_0.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && ((A_0.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind))))
                {
                    A_0.method_74().method_4(num2).method_70(new RectangleF(A_0.method_74().method_4(num2).method_69().X + width, A_0.method_74().method_4(num2).method_69().Y, A_0.method_74().method_4(num2).method_69().Width, A_0.method_74().method_4(num2).method_69().Height));
                }
                flag = true;
                num2++;
            Label_041B:
                if (num2 <= i)
                {
                    goto Label_02E9;
                }
            Label_0422:
                if (i == (A_0.method_74().Count - 1))
                {
                    while (num2 <= i)
                    {
                        if (((A_0.method_74().method_4(num2).method_48() == TabJustification.Right) && !(A_0.method_74().method_4(num2).method_73().imethod_0() is Class206)) && (!(A_0.method_74().method_4(num2).method_73() is DocPicture) || (((A_0.method_74().method_4(num2).method_73() is DocPicture) && ((A_0.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && ((A_0.method_74().method_4(num2).method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind))))
                        {
                            A_0.method_74().method_4(num2).method_70(new RectangleF(A_0.method_74().method_4(num2).method_69().X + width, A_0.method_74().method_4(num2).method_69().Y, A_0.method_74().method_4(num2).method_69().Width, A_0.method_74().method_4(num2).method_69().Height));
                        }
                        flag = true;
                        num2++;
                    }
                    if ((A_0.method_74().method_4(i).method_73().imethod_0() is Class206) && ((A_0.method_74().method_4(i).method_73().imethod_0() as Class206).class215_0.method_0() == TabJustification.Right))
                    {
                        A_0.method_74().method_4(i).method_70(new RectangleF(A_0.method_74().method_4(i).method_69().X, A_0.method_74().method_4(i).method_69().Y, (A_0.method_74().method_4(i).method_73().imethod_0() as Class206).class215_0.method_4() - A_0.method_74().method_4(i).method_69().X, A_0.method_74().method_4(i).method_69().Height));
                    }
                }
            }
            bool flag2 = true;
            int num4 = 0;
            for (int j = 0; j < A_0.method_74().Count; j++)
            {
                Class206 class5 = A_0.method_74().method_4(j).method_73().imethod_0() as Class206;
                if ((A_0.method_74().method_4(j).method_48() != TabJustification.Centered) || (class5 != null))
                {
                    goto Label_094B;
                }
                if (flag2)
                {
                    num4 = j;
                    flag2 = false;
                    if (j > 0)
                    {
                        Class206 class3 = A_0.method_74().method_4(j - 1).method_73().imethod_0() as Class206;
                        int num13 = this.method_187(A_0, num4);
                        float num11 = (A_0.method_74().method_4(num13).method_69().Right - A_0.method_74().method_4(num4).method_69().X) / 2f;
                        float num10 = class3.class215_0.method_4() - A_0.method_74().method_4(num4).method_69().X;
                        if (num11 < num10)
                        {
                            width = num10 - num11;
                            Section section = this.paragraph_1.method_49();
                            float num12 = section.PageSetup.ClientWidth + section.PageSetup.Margins.Left;
                            if (class3.class215_0.method_4() < num12)
                            {
                                num12 -= (float) A_0.method_73().imethod_0().imethod_1().method_8();
                            }
                            float num14 = A_0.method_74().method_4(num13).method_69().Right + width;
                            if (num14 > num12)
                            {
                                width -= num14 - num12;
                                width = (width < 0f) ? 0f : width;
                            }
                            A_0.method_74().method_4(num4 - 1).method_70(new RectangleF(A_0.method_74().method_4(num4 - 1).method_69().X, A_0.method_74().method_4(num4 - 1).method_69().Y, width, A_0.method_74().method_4(num4 - 1).method_69().Height));
                        }
                    }
                }
                goto Label_0957;
            Label_0887:
                if ((A_0.method_74().method_4(num4).method_48() == TabJustification.Centered) && !(A_0.method_74().method_4(num4).method_73().imethod_0() is Class206))
                {
                    A_0.method_74().method_4(num4).method_70(new RectangleF(A_0.method_74().method_4(num4).method_69().X + width, A_0.method_74().method_4(num4).method_69().Y, A_0.method_74().method_4(num4).method_69().Width, A_0.method_74().method_4(num4).method_69().Height));
                }
                num4++;
            Label_094B:
                if (num4 <= j)
                {
                    goto Label_0887;
                }
                flag2 = true;
            Label_0957:
                if (j == (A_0.method_74().Count - 1))
                {
                    while (num4 <= j)
                    {
                        if ((A_0.method_74().method_4(num4).method_48() == TabJustification.Centered) && !(A_0.method_74().method_4(num4).method_73().imethod_0() is Class206))
                        {
                            A_0.method_74().method_4(num4).method_70(new RectangleF(A_0.method_74().method_4(num4).method_69().X + width, A_0.method_74().method_4(num4).method_69().Y, A_0.method_74().method_4(num4).method_69().Width, A_0.method_74().method_4(num4).method_69().Height));
                        }
                        num4++;
                    }
                    flag2 = true;
                    if ((A_0.method_74().method_4(j).method_73().imethod_0() is Class206) && ((A_0.method_74().method_4(j).method_73().imethod_0() as Class206).class215_0.method_0() == TabJustification.Centered))
                    {
                        A_0.method_74().method_4(j).method_70(new RectangleF(A_0.method_74().method_4(j).method_69().X, A_0.method_74().method_4(j).method_69().Y, (A_0.method_74().method_4(j).method_73().imethod_0() as Class206).class215_0.method_4() - A_0.method_74().method_4(j).method_69().X, A_0.method_74().method_4(j).method_69().Height));
                    }
                }
            }
            this.method_176(A_0);
            this.method_177(A_0);
            this.method_168(A_0);
        }
    }

    private void method_168(Class375 A_0)
    {
        Paragraph paragraph = (A_0.method_73() is Paragraph) ? (A_0.method_73() as Paragraph) : ((!(A_0.method_73() is Class65) || !((A_0.method_73() as Class65).method_2() is Paragraph)) ? null : ((A_0.method_73() as Class65).method_2() as Paragraph));
        if ((paragraph != null) && paragraph.method_45())
        {
            ParagraphFormat format = paragraph.Format;
            double num = this.method_169(A_0);
            switch (paragraph.Format.HorizontalAlignment)
            {
                case HorizontalAlignment.Center:
                    num /= 2.0;
                    A_0.method_94(num, 0.0, true);
                    return;

                case HorizontalAlignment.Right:
                    A_0.method_107(this, num);
                    break;

                default:
                    return;
            }
        }
    }

    internal double method_169(Class375 A_0)
    {
        Class210 class2 = A_0.method_73().imethod_0() as Class210;
        float right = 0f;
        int count = A_0.method_74().Count;
        if (count > 0)
        {
            A_0.method_74().method_4(0).method_43(true);
            A_0.method_74().method_4(count - 1).method_41(true);
        }
        if (count <= 1)
        {
            return ((A_0.method_26() - A_0.method_69().Right) - class2.Interface22.imethod_1().method_8());
        }
        for (int i = 0; i < count; i++)
        {
            if (((A_0.method_74().method_4(i).method_73() is Table) && (A_0.method_74().method_4(i).method_73() as Table).IsTextBox) && ((((A_0.method_74().method_4(i).method_73() as Table).TextBox as TextBox).ShapeInfo != null) && ((A_0.method_74().method_4(i).method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Inline)))
            {
                right = A_0.method_74().method_4(i).method_69().Right;
            }
            if ((A_0.method_74().method_4(i).method_73() is DocPicture) && ((A_0.method_74().method_4(i).method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))
            {
                right = A_0.method_74().method_4(i).method_69().Right;
            }
            if ((!(A_0.method_74().method_4(i).method_73() is TextRange) && !(A_0.method_74().method_4(i).method_73() is Class542)) && ((!(A_0.method_74().method_4(i).method_73() is DocOleObject) && !(A_0.method_74().method_4(i).method_73() is BookmarkStart)) && !(A_0.method_74().method_4(i).method_73() is BookmarkEnd)))
            {
                continue;
            }
            if ((class2.method_15() != HorizontalAlignment.Center) && (class2.method_15() != HorizontalAlignment.Right))
            {
                if (class2.method_15() != HorizontalAlignment.Justify)
                {
                    goto Label_02FC;
                }
                int num5 = this.method_170(A_0.method_74(), A_0.method_74().method_4(count - 1), false);
                right = A_0.method_74().method_4(num5).method_69().Right;
                break;
            }
            Class206 class3 = A_0.method_74().method_4(i).method_73().imethod_0() as Class206;
            if ((class3 != null) && ((A_0.method_74().method_4(i).method_48() == TabJustification.Right) || (A_0.method_74().method_4(i).method_48() == TabJustification.Centered)))
            {
                int num6 = i;
                if (i < (count - 1))
                {
                    num6 = this.method_187(A_0, i + 1);
                }
                float num7 = (class3.method_18() != 0f) ? class3.method_18() : (class3.class215_0.method_4() - A_0.method_74().method_4(i).method_69().X);
                if (num6 == (count - 1))
                {
                    right = A_0.method_74().method_4(i).method_69().Left + num7;
                    if (right > A_0.method_74().method_4(A_0.method_74().Count - 1).method_69().Right)
                    {
                        break;
                    }
                }
            }
        Label_02FC:
            if (A_0.method_74().method_4(i).method_69().Width < 0f)
            {
                right = A_0.method_74().method_4(i).method_69().Left;
            }
            else
            {
                right = A_0.method_74().method_4(i).method_69().Right;
            }
        }
        return ((A_0.method_26() - right) - class2.Interface22.imethod_1().method_8());
    }

    internal int method_170(Class376 A_0, Class375 A_1, bool A_2)
    {
        Class375 class2 = A_1;
        while (class2 != null)
        {
            if (!this.method_171(class2, A_2))
            {
                break;
            }
            class2 = A_2 ? class2.method_76() : class2.method_75();
        }
        if (class2 == null)
        {
            class2 = A_1;
        }
        return A_0.IndexOf(class2);
    }

    private bool method_171(Class375 A_0, bool A_1)
    {
        TextRange range = A_0.method_73() as TextRange;
        Class542 class2 = A_0.method_73() as Class542;
        char[] trimChars = new char[] { ' ' };
        if (class2 == null)
        {
            if ((A_0.method_73() is TextFormField) && ((A_0.method_76() == null) || !(A_0.method_76().method_73() is TextRange)))
            {
                return true;
            }
            if (!(A_0.method_73() is Field))
            {
                if (range != null)
                {
                    string text = range.Text;
                    string str4 = A_1 ? text.TrimStart(trimChars) : text.TrimEnd(trimChars);
                    if (!(text != str4) && !string.IsNullOrEmpty(text))
                    {
                        return false;
                    }
                    if (str4.Length > 0)
                    {
                        return false;
                    }
                    return true;
                }
                if (A_0.method_73() is ShapeObject)
                {
                    ShapeObject obj2 = A_0.method_73() as ShapeObject;
                    if ((obj2.TextWrappingStyle != TextWrappingStyle.InFrontOfText) && (obj2.TextWrappingStyle != TextWrappingStyle.Behind))
                    {
                        return false;
                    }
                    return true;
                }
                if (((A_0.method_73() is BookmarkStart) || (A_0.method_73() is BookmarkEnd)) || (A_0.method_73() is Break))
                {
                    return true;
                }
            }
            return false;
        }
        string str3 = class2.method_0();
        string str2 = A_1 ? class2.method_0().TrimStart(trimChars) : class2.method_0().TrimEnd(trimChars);
        if (!(str3 != str2) && !string.IsNullOrEmpty(str3))
        {
            return false;
        }
        if (str2.Length > 0)
        {
            return false;
        }
        return true;
    }

    private void method_172(Class375 A_0)
    {
        int num = 6;
        if ((A_0 != null) && (A_0.method_74().Count > 0))
        {
            bool flag = false;
            for (int i = A_0.method_74().Count - 1; i >= 0; i--)
            {
                Class375 class2 = A_0.method_74().method_4(i);
                if (!(class2.method_73() is TextRange) && !(class2.method_73() is Class542))
                {
                    break;
                }
                string str = (class2.method_73() is TextRange) ? (class2.method_73() as TextRange).Text : ((class2.method_73() is Class542) ? (class2.method_73() as Class542).method_0() : string.Empty);
                if (!string.IsNullOrEmpty(str) && str.EndsWith(BookmarkStart.b("ఫ", num)))
                {
                    TextRange range = (class2.method_73() is TextRange) ? (class2.method_73() as TextRange) : ((class2.method_73() is Class542) ? ((class2.method_73() as Class542).method_2() as TextRange) : null);
                    if (range != null)
                    {
                        str = str.TrimEnd(new char[] { ' ' });
                        SizeF ef = this.method_323(range, str);
                        class2.method_70(new RectangleF(class2.method_69().Location, new SizeF(ef.Width, class2.method_69().Height)));
                        if (str.Length > 0)
                        {
                            break;
                        }
                        if (A_0.method_74().Count > 1)
                        {
                            A_0.method_74().method_11(class2);
                            flag = true;
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(str) || (A_0.method_74().Count <= 1))
                    {
                        break;
                    }
                    A_0.method_74().method_11(class2);
                    flag = true;
                }
            }
            if (flag)
            {
                A_0.method_98();
            }
        }
    }

    private void method_173(Class375 A_0, bool A_1)
    {
        Paragraph paragraph = (A_0.method_73() is Paragraph) ? (A_0.method_73() as Paragraph) : ((!(A_0.method_73() is Class65) || !((A_0.method_73() as Class65).method_2() is Paragraph)) ? null : ((A_0.method_73() as Class65).method_2() as Paragraph));
        if (paragraph != null)
        {
            Class213 class4 = A_0.method_73().imethod_0() as Class213;
            float num4 = Math.Abs(class4.method_53());
            switch (class4.method_55())
            {
                case LineSpacingRule.AtLeast:
                    if (Class59.smethod_4(A_0.method_69().Height, num4, 0.005f) <= 0)
                    {
                        int num = 0;
                        int count = A_0.method_74().Count;
                        while (num < count)
                        {
                            Class375 class2 = A_0.method_74().method_4(num);
                            if (!class2.method_73().imethod_0().imethod_12())
                            {
                                float num2 = 1f;
                                if ((class2.method_73() is TextRange) || (class2.method_73() is Class542))
                                {
                                    TextRange range = (class2.method_73() is TextRange) ? (class2.method_73() as TextRange) : ((class2.method_73() as Class542).method_2() as TextRange);
                                    Struct1 struct3 = this.method_335(range);
                                    double introduced27 = struct3.method_0();
                                    double introduced28 = struct3.method_0();
                                    num2 = (float) (introduced27 / (introduced28 + struct3.method_4()));
                                }
                                class2.method_70(new RectangleF(class2.method_69().X, class2.method_69().Y + ((num4 - class2.method_69().Height) * num2), class2.method_69().Width, class2.method_69().Height));
                            }
                            num++;
                        }
                    }
                    break;

                case LineSpacingRule.Exactly:
                {
                    float num6 = this.method_175(A_0);
                    Struct1 struct2 = A_0.method_7();
                    if ((struct2.method_7() <= 0.0) || (num6 <= 0f))
                    {
                        break;
                    }
                    int num3 = 0;
                    int num9 = A_0.method_74().Count;
                    while (num3 < num9)
                    {
                        Class375 class3 = A_0.method_74().method_4(num3);
                        if (!class3.method_73().imethod_0().imethod_12())
                        {
                            if (!paragraph.Document.Settings.method_5().method_0(CompatibilityOptions.DontMakeSpaceForUL))
                            {
                                this.method_174(num4, num6, class3, paragraph, struct2);
                            }
                            else
                            {
                                if ((class3.method_73() is ParagraphBase) && ((class3.method_73() as ParagraphBase).CharacterFormat.Position != 0f))
                                {
                                    float position = (class3.method_73() as ParagraphBase).CharacterFormat.Position;
                                }
                                double introduced30 = struct2.method_0();
                                double introduced31 = struct2.method_0();
                                float num5 = (float) (introduced30 / (introduced31 + struct2.method_4()));
                                float num7 = num6 - ((float) struct2.method_4());
                                class3.method_70(new RectangleF(class3.method_69().X, class3.method_69().Y + ((num4 * num5) - num7), class3.method_69().Width, class3.method_69().Height));
                            }
                        }
                        num3++;
                    }
                    return;
                }
                default:
                    return;
            }
        }
    }

    private void method_174(float A_0, float A_1, Class375 A_2, Paragraph A_3, Struct1 A_4)
    {
        switch (A_3.Format.TextAlignment)
        {
            case TextAlignment.Center:
                A_2.method_70(new RectangleF(A_2.method_69().X, A_2.method_69().Y + ((A_0 - A_1) / 2f), A_2.method_69().Width, A_2.method_69().Height));
                return;

            case TextAlignment.Baseline:
            case TextAlignment.Auto:
            {
                float num3 = (float) (A_4.method_0() / A_4.method_7());
                float num = A_4.method_22() ? ((float) ((A_4.method_11() - A_4.method_7()) * (1f - num3))) : 0f;
                float num2 = (A_1 - ((float) A_4.method_4())) - num;
                A_2.method_70(new RectangleF(A_2.method_69().X, A_2.method_69().Y + ((A_0 * num3) - num2), A_2.method_69().Width, A_2.method_69().Height));
                return;
            }
            case TextAlignment.Bottom:
                A_2.method_70(new RectangleF(A_2.method_69().X, A_2.method_69().Y + (A_0 - A_1), A_2.method_69().Width, A_2.method_69().Height));
                return;
        }
    }

    private float method_175(Class375 A_0)
    {
        float num = 0f;
        int num2 = 0;
        int count = A_0.method_74().Count;
        while (num2 < count)
        {
            Class375 class2 = A_0.method_74().method_4(num2);
            if (!class2.method_73().imethod_0().imethod_12())
            {
                num = Math.Max(num, class2.method_69().Height);
            }
            num2++;
        }
        return num;
    }

    private void method_176(Class375 A_0)
    {
        bool flag = false;
        bool flag2 = false;
        int num = 0;
        float num2 = 0f;
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class206 class2 = A_0.method_74().method_4(i).method_73().imethod_0() as Class206;
            if ((A_0.method_74().method_4(i).method_48() == TabJustification.Decimal) && (class2 == null))
            {
                if (flag)
                {
                    num = i;
                    flag = false;
                    flag2 = true;
                    num2 = this.method_179(A_0, num, false);
                }
            }
            else
            {
                flag = this.method_178(A_0, num, flag2, i, num2, false);
                flag2 = false;
            }
            if (i == (A_0.method_74().Count - 1))
            {
                flag = this.method_178(A_0, num, flag2, i, num2, false);
                if ((A_0.method_74().method_4(i).method_73().imethod_0() is Class206) && ((A_0.method_74().method_4(i).method_73().imethod_0() as Class206).class215_0.method_0() == TabJustification.Decimal))
                {
                    A_0.method_74().method_4(i).method_70(new RectangleF(A_0.method_74().method_4(i).method_69().X, A_0.method_74().method_4(i).method_69().Y, (A_0.method_74().method_4(i).method_73().imethod_0() as Class206).class215_0.method_4() - A_0.method_74().method_4(i).method_69().X, A_0.method_74().method_4(i).method_69().Height));
                }
            }
        }
    }

    private void method_177(Class375 A_0)
    {
        int num = 0;
        float num2 = 0f;
        bool flag = false;
        Paragraph paragraph = this.method_185(A_0);
        if (paragraph != null)
        {
            for (int i = 0; i < A_0.method_74().Count; i++)
            {
                if ((paragraph.IsInCell && (paragraph.Format.Tabs.Count != 0)) && (paragraph.Format.Tabs[0].Justification == TabJustification.Decimal))
                {
                    if (!flag && (A_0.method_74().Count != 1))
                    {
                        flag = this.method_178(A_0, num, false, i, num2, true);
                    }
                    else
                    {
                        flag = false;
                        num2 = this.method_179(A_0, num, true);
                    }
                    if (i == 0)
                    {
                        flag = this.method_178(A_0, num, false, i, num2, true);
                    }
                }
            }
        }
    }

    private bool method_178(Class375 A_0, int A_1, bool A_2, int A_3, float A_4, bool A_5)
    {
        while (A_1 <= A_3)
        {
            if (A_5)
            {
                A_0.method_74().method_4(A_1).method_70(new RectangleF(A_0.method_74().method_4(A_1).method_69().X + A_4, A_0.method_74().method_4(A_1).method_69().Y, A_0.method_74().method_4(A_1).method_69().Width, A_0.method_74().method_4(A_1).method_69().Height));
            }
            else if (((A_0.method_74().method_4(A_1).method_48() == TabJustification.Decimal) && !(A_0.method_74().method_4(A_1).method_73().imethod_0() is Class206)) && A_2)
            {
                A_0.method_74().method_4(A_1).method_70(new RectangleF(A_0.method_74().method_4(A_1).method_69().X + A_4, A_0.method_74().method_4(A_1).method_69().Y, A_0.method_74().method_4(A_1).method_69().Width, A_0.method_74().method_4(A_1).method_69().Height));
            }
            A_1++;
        }
        return true;
    }

    private float method_179(Class375 A_0, int A_1, bool A_2)
    {
        float num = 0f;
        float num2 = 0f;
        float num3 = 0f;
        int num4 = this.method_187(A_0, A_1);
        Paragraph paragraph = this.method_185(A_0);
        float num5 = this.method_182(paragraph, A_1, num4);
        float num7 = (paragraph.Format.Tabs.Count > 0) ? paragraph.Format.Tabs[0].Position : 0f;
        for (int i = A_1; i <= num4; i++)
        {
            num2 += A_0.method_74().method_4(i).method_69().Width;
        }
        if (A_2)
        {
            num3 = (paragraph.Owner as TableCell).LayoutWidth - ((float) ((paragraph.Owner as TableCell).interface23_0.imethod_0().method_0() + (paragraph.Owner as TableCell).interface23_0.imethod_0().method_8()));
        }
        else
        {
            num3 = this.method_180(paragraph);
            Class206 class2 = A_0.method_74().method_4(A_1 - 1).method_73().imethod_0() as Class206;
            num7 = class2.class215_0.method_4() - A_0.method_74().method_4(A_1).method_69().X;
        }
        if (num5 >= num7)
        {
            return num;
        }
        if ((num2 - num5) < (num3 - num7))
        {
            return (num7 - num5);
        }
        return (num3 - num2);
    }

    private float method_180(Paragraph A_0)
    {
        DocumentObject owner = A_0;
        float clientWidth = 0f;
        while (!(owner is Section))
        {
            if (owner == null)
            {
                break;
            }
            owner = owner.Owner;
        }
        if (owner is Section)
        {
            clientWidth = (owner as Section).PageSetup.ClientWidth;
        }
        return clientWidth;
    }

    internal float method_181(Section A_0)
    {
        float clientWidth = 0f;
        if (A_0 != null)
        {
            clientWidth = A_0.PageSetup.ClientWidth;
        }
        return clientWidth;
    }

    internal float method_182(Paragraph A_0, int A_1, int A_2)
    {
        float num = 0f;
        if (A_0.ChildObjects.Count != 0)
        {
            int num2 = 0;
            int num3 = 0;
            bool flag = false;
            num2 = this.method_183(A_0, A_1, A_2, ref num, ref num3, ref flag);
            if ((A_0.ChildObjects[num2] is TextRange) && flag)
            {
                string[] strArray = (A_0.ChildObjects[num2] as TextRange).Text.Split(new char[] { (char) num3 });
                SizeF ef = this.method_323(A_0.ChildObjects[num2] as TextRange, strArray[0]);
                num += ef.Width;
            }
        }
        return num;
    }

    private int method_183(Paragraph A_0, int A_1, int A_2, ref float A_3, ref int A_4, ref bool A_5)
    {
        char ch = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
        bool flag = false;
        bool flag2 = false;
        int num = 0;
        for (int i = A_1; i <= A_2; i++)
        {
            if (!(A_0.ChildObjects[i] is TextRange))
            {
                continue;
            }
            A_4 = 0;
            char[] chArray = (A_0.ChildObjects[i] as TextRange).Text.ToCharArray();
            for (int j = 0; j < chArray.Length; j++)
            {
                if (char.IsNumber(chArray[j]))
                {
                    goto Label_007E;
                }
            }
            goto Label_0080;
        Label_007E:
            flag2 = true;
        Label_0080:
            if (flag2)
            {
                flag = this.method_184(chArray, ref A_4);
            }
            if (!flag2 && !flag)
            {
                if ((A_0.ChildObjects[i] as TextRange).Text.Contains(ch.ToString()))
                {
                    flag = true;
                }
                A_4 = ch;
            }
            if (flag)
            {
                num = i;
                A_5 = true;
                return num;
            }
            SizeF ef = this.method_323(A_0.ChildObjects[i] as TextRange, (A_0.ChildObjects[i] as TextRange).Text);
            A_3 += ef.Width;
        }
        return num;
    }

    private bool method_184(char[] A_0, ref int A_1)
    {
        int num = 0x2019;
        int num2 = 0x201d;
        for (int i = 0; i < A_0.Length; i++)
        {
            int num4 = A_0[i];
            if ((!char.IsNumber(A_0[i]) && (((num4 > 0x1f) && (num4 < 0x7f)) || ((num4 == num) || (num4 == num2)))) && (((A_0.Length == 1) || ((i > 0) && char.IsNumber(A_0[i - 1]))) && (num4 != CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator[0])))
            {
                A_1 = num4;
                return true;
            }
        }
        return false;
    }

    private Paragraph method_185(Class375 A_0)
    {
        Paragraph paragraph = null;
        if (A_0.method_73() != null)
        {
            if (A_0.method_73() is Paragraph)
            {
                return (A_0.method_73() as Paragraph);
            }
            if ((A_0.method_73() is Class65) ? ((A_0.method_73() as Class65).method_2() is Paragraph) : false)
            {
                paragraph = (A_0.method_73() as Class65).method_2() as Paragraph;
            }
        }
        return paragraph;
    }

    private Paragraph method_186(DocumentObject A_0)
    {
        DocumentObject owner = A_0.Owner;
        while (owner != null)
        {
            if (owner is Paragraph)
            {
                break;
            }
            owner = owner.Owner;
        }
        return (owner as Paragraph);
    }

    private int method_187(Class375 A_0, int A_1)
    {
        for (int i = A_1; i < A_0.method_74().Count; i++)
        {
            if (A_0.method_74().method_4(i).method_73().imethod_0() is Class206)
            {
                return (i - 1);
            }
        }
        return (A_0.method_74().Count - 1);
    }

    private RectangleF method_188(Paragraph A_0, Class375 A_1, ref float A_2)
    {
        Class210 class2 = A_1.method_73().imethod_0() as Class210;
        if ((A_1.method_74().Count == 0) || string.IsNullOrEmpty(class2.method_65()))
        {
            return RectangleF.Empty;
        }
        A_2 = -Math.Abs(class2.method_51());
        SizeF ef = new SizeF();
        Font font = null;
        sprᝪ rᝪ = null;
        if (base.method_1())
        {
            rᝪ = this.method_377(class2.method_71(), class2.method_67());
        }
        else
        {
            font = this.method_366(class2.method_71(), class2.method_67());
        }
        if (!class2.method_45())
        {
            ef = base.method_1() ? this.method_309(class2.method_65(), rᝪ, null) : this.method_316(class2.method_65(), font, null);
        }
        else
        {
            SizeF ef2 = base.method_1() ? this.method_309(class2.method_65(), rᝪ, null) : this.method_316(class2.method_65(), font, null);
            SizeF ef3 = this.method_306(class2.method_79());
            float num4 = Math.Min((float) (ef2.Width / ef3.Width), (float) (ef2.Height / ef3.Height));
            if (num4 != 1f)
            {
                ef = new SizeF(ef3.Width * num4, ef3.Height * num4);
            }
        }
        if (class2.method_75() == ListNumberAlignment.Center)
        {
            A_2 -= ef.Width / 2f;
        }
        else if (class2.method_75() == ListNumberAlignment.Right)
        {
            A_2 -= ef.Width;
        }
        float num6 = this.method_191(A_1) + A_2;
        float y = this.method_192(A_1);
        Font font2 = null;
        float num3 = 0f;
        sprᝪ rᝪ2 = null;
        if (base.method_1())
        {
            num3 = this.method_194(A_1, ref rᝪ2);
        }
        else
        {
            num3 = this.method_193(A_1, ref font2);
        }
        if (ef.Height != num3)
        {
            if ((!class2.method_45() && ((font2 != null) || (rᝪ2 != null))) && ((font != null) || (rᝪ != null)))
            {
                float num = 0f;
                float num2 = 0f;
                if (base.method_1())
                {
                    num = this.method_343(rᝪ);
                    num2 = this.method_343(rᝪ2);
                }
                else
                {
                    num = this.method_332(font);
                    num2 = this.method_332(font2);
                }
                y -= num - num2;
            }
            else
            {
                y -= (ef.Height - num3) / 2f;
            }
        }
        class2.method_62(num6);
        return new RectangleF(num6, y, ef.Width, ef.Height);
    }

    internal void method_189(Paragraph A_0, Class375 A_1, bool A_2)
    {
        float num = 0f;
        RectangleF ef = this.method_188(A_0, A_1, ref num);
        if (!ef.IsEmpty)
        {
            Class210 class2 = A_1.method_73().imethod_0() as Class210;
            float x = ef.X;
            float y = ef.Y;
            SizeF size = ef.Size;
            if (!class2.method_45())
            {
                this.bool_19 = true;
                Class198 class3 = new Class198 {
                    drawingTextDirection_0 = DrawingTextDirection.Horizontal
                };
                this.method_234(class2.method_65(), class2.method_71(), A_0.Format, new RectangleF(x, y, Math.Abs(num), size.Height), Math.Abs(num), class3, class2.method_67());
                if ((class2.method_77() != null) && (class2.method_77().method_2() != TabLeader.NoLeader))
                {
                    this.method_195(A_0, class2, (class2.method_51() + size.Width) + num, A_1.method_74().method_4(0).method_69().X, y);
                }
            }
            else
            {
                this.method_190(class2.method_79(), new RectangleF(x, y, size.Width, size.Height));
            }
        }
    }

    private void method_190(DocPicture A_0, RectangleF A_1)
    {
        Image image = this.method_225(A_0, A_1.Width, A_1.Height);
        if (base.method_1())
        {
            this.method_126().method_15(image, A_1);
        }
        else
        {
            this.method_151().DrawImage(image, A_1);
        }
    }

    private float method_191(Class375 A_0)
    {
        float x = A_0.method_74().method_4(0).method_69().X;
        if (((!(A_0.method_74().method_4(0).method_73() is Paragraph) || (A_0.method_74().method_4(0).method_74().Count <= 0)) || (A_0.method_74().method_4(0).method_74().method_4(0).method_69().X == x)) || (!(A_0.method_74().method_4(0).method_74().method_4(0).method_73() is TextRange) && !(A_0.method_74().method_4(0).method_74().method_4(0).method_73() is BookmarkStart)))
        {
            return x;
        }
        return A_0.method_74().method_4(0).method_74().method_4(0).method_69().X;
    }

    private float method_192(Class375 A_0)
    {
        int num = 1;
        float y = this.method_197(A_0);
        if (((A_0.method_74().Count > 1) && (A_0.method_74().method_4(0).method_74().Count == 1)) && ((A_0.method_74().method_4(0).method_74().method_4(0).method_69().Width == 0f) && (A_0.method_74().method_4(0).method_64() == BookmarkStart.b("琦夨䜪䐬嬮䔰嘲儴", num))))
        {
            int num5 = 0;
            int num3 = 0;
            int count = A_0.method_74().Count;
            while (num3 < count)
            {
                Class375 class2 = A_0.method_74().method_4(num3);
                if ((class2.method_74().Count != 1) || (class2.method_74().method_4(0).method_69().Width != 0f))
                {
                    num5 = num3;
                    break;
                }
                num3++;
            }
            if ((A_0.method_74().method_4(num5).method_74().Count > 0) && (A_0.method_74().method_4(num5).method_74().method_4(0).method_69().Y != y))
            {
                y = A_0.method_74().method_4(num5).method_74().method_4(0).method_69().Y;
            }
        }
        return y;
    }

    private float method_193(Class375 A_0, ref Font A_1)
    {
        if (A_0 == null)
        {
            return 0f;
        }
        if (!(A_0.method_73() is Paragraph) && (!(A_0.method_73() is Class65) || !((A_0.method_73() as Class65).method_2() is Paragraph)))
        {
            return 0f;
        }
        float height = A_0.method_69().Height;
        Paragraph paragraph = (A_0.method_73() is Paragraph) ? (A_0.method_73() as Paragraph) : ((A_0.method_73() as Class65).method_2() as Paragraph);
        A_1 = this.method_365(paragraph.BreakCharacterFormat);
        Class375 class2 = A_0.method_74().method_4(0);
        float num = 0f;
        foreach (Class375 class3 in class2.method_74())
        {
            Interface1 interface2 = (class3.method_73() is Class542) ? (class3.method_73() as Class542).method_2() : class3.method_73();
            if ((interface2 is TextRange) && (num < class3.method_69().Height))
            {
                num = class3.method_69().Height;
                A_1 = this.method_367(interface2 as TextRange);
            }
        }
        if ((num > 0f) && (num < height))
        {
            height = num;
        }
        return height;
    }

    private float method_194(Class375 A_0, ref sprᝪ A_1)
    {
        if (A_0 == null)
        {
            return 0f;
        }
        if (!(A_0.method_73() is Paragraph) && (!(A_0.method_73() is Class65) || !((A_0.method_73() as Class65).method_2() is Paragraph)))
        {
            return 0f;
        }
        float height = A_0.method_69().Height;
        Paragraph paragraph = (A_0.method_73() is Paragraph) ? (A_0.method_73() as Paragraph) : ((A_0.method_73() as Class65).method_2() as Paragraph);
        A_1 = this.method_376(paragraph.BreakCharacterFormat);
        Class375 class2 = A_0.method_74().method_4(0);
        float num = 0f;
        foreach (Class375 class3 in class2.method_74())
        {
            Interface1 interface2 = (class3.method_73() is Class542) ? (class3.method_73() as Class542).method_2() : class3.method_73();
            if ((interface2 is TextRange) && (num < class3.method_69().Height))
            {
                num = class3.method_69().Height;
                A_1 = this.method_378(interface2 as TextRange);
            }
        }
        if ((num > 0f) && (num < height))
        {
            height = num;
        }
        return height;
    }

    private void method_195(Paragraph A_0, Class210 A_1, float A_2, float A_3, float A_4)
    {
        string str = this.method_196(A_1);
        if (str != string.Empty)
        {
            float num4 = base.method_1() ? this.method_309(str, this.method_376(A_1.method_71()), null).Width : this.method_316(str, A_1.method_71().Font, null).Width;
            float num3 = A_1.method_51() - (((float) Math.Ceiling((double) (A_2 / num4))) * num4);
            string str2 = string.Empty;
            int num2 = (int) Math.Floor((double) (num3 / num4));
            for (int i = 0; i < num2; i++)
            {
                str2 = str2 + str;
            }
            SizeF ef2 = base.method_1() ? this.method_309(str2, this.method_376(A_1.method_71()), null) : this.method_316(str2, A_1.method_71().Font, null);
            Class198 class2 = new Class198 {
                drawingTextDirection_0 = DrawingTextDirection.Horizontal
            };
            this.method_233(str2, A_1.method_71(), A_0.Format, new RectangleF(A_3 - num3, A_4, ef2.Width, ef2.Height), ef2.Width, class2);
        }
    }

    private string method_196(Class210 A_0)
    {
        int num = 13;
        string str = string.Empty;
        switch (A_0.method_77().method_2())
        {
            case TabLeader.Dotted:
                return BookmarkStart.b("ᴲ", num);

            case TabLeader.Hyphenated:
                return BookmarkStart.b("Ḳ", num);

            case TabLeader.Single:
                return BookmarkStart.b("氲", num);
        }
        return str;
    }

    private float method_197(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class375 class2 = A_0.method_74().method_4(i);
            if ((((class2.method_73() is TextRange) || (class2.method_73() is Class542)) || ((class2.method_73() is DocPicture) && ((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))) || (((class2.method_73() is Table) && (class2.method_73() as Table).IsTextBox) && ((class2.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Inline)))
            {
                return class2.method_69().Y;
            }
            if (class2.method_73() is Paragraph)
            {
                return this.method_197(class2);
            }
        }
        return A_0.method_69().Y;
    }

    internal bool method_198(Paragraph A_0)
    {
        bool flag = false;
        if (((A_0 != null) && (A_0.Text == "")) && (A_0.Items.Count == 0))
        {
            flag = true;
        }
        return flag;
    }

    internal void method_199(TextRange A_0, Class375 A_1, string A_2)
    {
        int num = 9;
        IDocumentObject obj2 = A_0;
        this.textRange_0 = A_0;
        TextDirection topToBottom = TextDirection.TopToBottom;
        VerticalAlignment top = VerticalAlignment.Top;
        HorizontalAlignment left = HorizontalAlignment.Left;
        bool flag = false;
        RectangleF bounds = new RectangleF();
        TextDirection textDirection = TextDirection.TopToBottom;
        bool flag2 = false;
        Class198 class2 = new Class198();
        if (A_1.method_73() is Class542)
        {
            class2.list_0 = (A_1.method_73() as Class542).method_3();
        }
        else if (((A_1.method_73() as TextRange).interface23_0 as Class205).method_12())
        {
            class2.list_0 = ((A_1.method_73() as TextRange).interface23_0 as Class205).method_11();
        }
        if ((obj2.Owner is Paragraph) && ((obj2.Owner as Paragraph).Owner is TableCell))
        {
            topToBottom = ((obj2.Owner as Paragraph).Owner as TableCell).CellFormat.TextDirection;
            bounds = ((obj2.Owner as Paragraph).Owner as TableCell).Bounds;
            top = ((obj2.Owner as Paragraph).Owner as TableCell).CellFormat.VerticalAlignment;
            left = (obj2.Owner as Paragraph).Format.HorizontalAlignment;
            flag = true;
            class2.paddings_0 = this.method_202((obj2.Owner as Paragraph).Owner as TableCell);
        }
        Section section = A_0.method_2();
        if (section != null)
        {
            textDirection = section.TextDirection;
            flag2 = true;
        }
        if (flag2)
        {
            switch (textDirection)
            {
                case TextDirection.TopToBottom:
                    class2.drawingTextDirection_0 = DrawingTextDirection.Horizontal;
                    break;

                case TextDirection.RightToLeft:
                    class2.drawingTextDirection_0 = DrawingTextDirection.Vertical;
                    break;

                case TextDirection.LeftToRight:
                    class2.drawingTextDirection_0 = DrawingTextDirection.BottomToTop;
                    break;

                case TextDirection.TopToBottomRotated:
                    class2.drawingTextDirection_0 = DrawingTextDirection.HorizontalEastAsiaRotation;
                    break;

                case TextDirection.RightToLeftRotated:
                    class2.drawingTextDirection_0 = DrawingTextDirection.TopToBottom;
                    break;
            }
        }
        if (flag)
        {
            switch (topToBottom)
            {
                case TextDirection.TopToBottom:
                    class2.drawingTextDirection_0 = DrawingTextDirection.Horizontal;
                    class2.rectangleF_0 = bounds;
                    class2.horizontalAlignment_0 = left;
                    class2.verticalAlignment_0 = top;
                    break;

                case TextDirection.RightToLeft:
                    class2.drawingTextDirection_0 = DrawingTextDirection.TopToBottom;
                    class2.rectangleF_0 = bounds;
                    class2.horizontalAlignment_0 = left;
                    class2.verticalAlignment_0 = top;
                    break;

                case TextDirection.LeftToRight:
                    class2.drawingTextDirection_0 = DrawingTextDirection.BottomToTop;
                    class2.rectangleF_0 = bounds;
                    class2.horizontalAlignment_0 = left;
                    class2.verticalAlignment_0 = top;
                    break;

                case TextDirection.TopToBottomRotated:
                    class2.drawingTextDirection_0 = DrawingTextDirection.HorizontalEastAsiaRotation;
                    class2.rectangleF_0 = bounds;
                    class2.horizontalAlignment_0 = left;
                    class2.verticalAlignment_0 = top;
                    break;

                case TextDirection.RightToLeftRotated:
                    class2.drawingTextDirection_0 = DrawingTextDirection.Vertical;
                    class2.rectangleF_0 = bounds;
                    class2.horizontalAlignment_0 = left;
                    class2.verticalAlignment_0 = top;
                    break;
            }
            if ((obj2.Owner is Paragraph) && (obj2.Owner as Paragraph).IsInCell)
            {
                Paragraph owner = obj2.Owner as Paragraph;
                if (owner.Format.IsBidi)
                {
                    TableCell cell1 = owner.Owner as TableCell;
                }
            }
        }
        if ((obj2.Owner is Paragraph) && !(obj2.Owner as Paragraph).IsInCell)
        {
            Paragraph paragraph = obj2.Owner as Paragraph;
            if (paragraph.Format.IsBidi)
            {
                class2.drawingTextDirection_0 = DrawingTextDirection.RightToLeft;
                class2.rectangleF_0 = A_1.method_69();
                if ((paragraph.Owner is Body) && (paragraph.Owner.Owner is Section))
                {
                    Section section2 = paragraph.Owner.Owner as Section;
                    class2.pageSetup_0 = section2.PageSetup;
                }
            }
        }
        float x = A_1.method_69().Left;
        float y = A_1.method_69().Top;
        float width = A_1.method_69().Width;
        float height = A_1.method_69().Height;
        Class206 class3 = A_0.interface23_0 as Class206;
        float num6 = 0f;
        if (class3 != null)
        {
            this.method_204(A_0, A_1, ref A_2);
            A_0.Text = BookmarkStart.b("☮", num);
            if (class3.method_20() == TabLeader.NoLeader)
            {
                num6 = class3.method_18();
            }
            else
            {
                num6 = 0f;
            }
        }
        CharacterFormat characterFormat = A_0.CharacterFormat;
        ((Interface11) characterFormat).imethod_0();
        RectangleF ef5 = A_1.method_69();
        StringFormat format = null;
        Font font = null;
        sprᝪ rᝪ = null;
        if (base.method_1())
        {
            rᝪ = this.method_379(A_0, ref ef5);
        }
        else
        {
            font = this.method_368(A_0, ref ef5);
            format = this.method_348(A_0.CharacterFormat);
        }
        SizeF ef4 = this.method_323(A_0, A_2);
        y = ef5.Y;
        RectangleF ef3 = new RectangleF(x, y, (ef4.Width + A_1.method_58()) + num6, height);
        ParagraphFormat format3 = null;
        if (A_0.OwnerParagraph != null)
        {
            format3 = A_0.OwnerParagraph.Format;
        }
        if (A_1.method_28() > 0f)
        {
            if (A_1.method_69().Width < A_1.method_28())
            {
                return;
            }
            A_2 = this.method_203(A_0, A_1, ref ef3);
        }
        int num2 = this.method_324(A_0, ref A_2, true);
        if (num2 > 0)
        {
            float num7 = base.method_1() ? (this.method_309(this.string_2, rᝪ, format).Width * 0.95f) : (this.method_316(this.string_2, font, format).Width * 0.95f);
            ef4.Width += num7 * num2;
        }
        bool flag3 = (A_1.method_60() == HorizontalAlignment.Distributed) || (A_1.method_60() == HorizontalAlignment.Justify);
        if (A_0.IsAddForEmptyPara)
        {
            A_2 = string.Empty;
        }
        if ((!flag3 || A_1.method_54()) && ((A_1.method_60() != HorizontalAlignment.Distributed) && !this.method_240(A_2)))
        {
            if (A_1.method_54() && (class3 == null))
            {
                ef3 = new RectangleF(x, y, ef4.Width, height);
            }
            this.method_233(A_2, characterFormat, format3, ef3, A_1.method_69().Width, class2);
        }
        else if (flag3)
        {
            this.method_241(A_2, characterFormat, format3, ef3, A_1, class2);
        }
        this.method_200(A_0, A_1);
        if (A_1.method_2() != null)
        {
            Hyperlink hyperlink = new Hyperlink(A_1.method_2());
            this.method_396(hyperlink, A_1.method_69());
        }
    }

    private void method_200(TextRange A_0, Class375 A_1)
    {
        Border border = A_0.CharacterFormat.Border;
        if ((border.BorderType != BorderStyle.None) && (border.BorderType != BorderStyle.Cleared))
        {
            RectangleF ef = A_1.method_69();
            if (ef.Width != 0f)
            {
                TextRange previousSibling = A_0.PreviousSibling as TextRange;
                TextRange nextSibling = A_0.NextSibling as TextRange;
                bool flag = false;
                bool flag2 = false;
                if (((previousSibling != null) && (previousSibling.CharacterFormat.Border.BorderType != BorderStyle.None)) && ((previousSibling.CharacterFormat.Border.BorderType != BorderStyle.Cleared) && !A_1.method_42()))
                {
                    flag = true;
                }
                if (((nextSibling != null) && (nextSibling.CharacterFormat.Border.BorderType != BorderStyle.None)) && ((nextSibling.CharacterFormat.Border.BorderType != BorderStyle.Cleared) && !A_1.method_40()))
                {
                    flag2 = true;
                }
                if (!flag)
                {
                    this.method_267(border, new PointF(ef.X, ef.Y), new PointF(ef.X, ef.Bottom));
                }
                if (!flag2)
                {
                    this.method_267(border, new PointF(ef.Right, ef.Y), new PointF(ef.Right, ef.Bottom));
                }
                this.method_267(border, new PointF(ef.X, ef.Y), new PointF(ef.Right, ef.Y));
                this.method_267(border, new PointF(ef.X, ef.Bottom), new PointF(ef.Right, ef.Bottom));
            }
        }
    }

    internal void method_201(Footnote A_0, Class375 A_1, string A_2)
    {
        TextRange range = new TextRange(A_0.Document);
        range.CharacterFormat.ImportContainer(A_0.MarkerCharacterFormat);
        range.CharacterFormat.ApplyBase(A_0.MarkerCharacterFormat.BaseFormat);
        range.method_0(A_0.OwnerParagraph);
        float left = A_1.method_69().Left;
        float top = A_1.method_69().Top;
        float width = A_1.method_69().Width;
        float height = A_1.method_69().Height;
        CharacterFormat characterFormat = range.CharacterFormat;
        ((Interface11) characterFormat).imethod_0();
        RectangleF ef5 = A_1.method_69();
        if (base.method_1())
        {
            this.method_379(range, ref ef5);
        }
        else
        {
            this.method_368(range, ref ef5);
            this.method_348(range.CharacterFormat);
        }
        SizeF ef6 = this.method_323(range, A_2);
        top = ef5.Y;
        RectangleF ef7 = new RectangleF(left, top, ef6.Width + A_1.method_58(), height);
        Class198 class2 = new Class198 {
            drawingTextDirection_0 = DrawingTextDirection.Horizontal
        };
        this.method_233(A_2, characterFormat, A_0.OwnerParagraph.Format, ef7, A_1.method_69().Width, class2);
        range = null;
    }

    private Paddings method_202(TableCell A_0)
    {
        if (!A_0.CellFormat.SamePaddingsAsTable)
        {
            return A_0.CellFormat.Paddings;
        }
        if (!A_0.OwnerRow.RowFormat.Paddings.IsEmpty)
        {
            return A_0.OwnerRow.RowFormat.Paddings;
        }
        if (A_0.OwnerRow.OwnerTable.TableFormat.Paddings.IsEmpty)
        {
            return new Paddings();
        }
        return A_0.OwnerRow.OwnerTable.TableFormat.Paddings;
    }

    private string method_203(TextRange A_0, Class375 A_1, ref RectangleF A_2)
    {
        char[] chArray = A_0.Text.ToCharArray();
        float num = 0f;
        int num2 = 0;
        string str = null;
        for (int i = 0; i < A_0.Text.Length; i++)
        {
            SizeF ef5 = base.method_1() ? this.method_309(chArray[i].ToString(), this.method_378(A_0), null) : this.method_316(chArray[i].ToString(), this.method_367(A_0), this.method_348(A_0.CharacterFormat));
            num += ef5.Width;
            if (num >= A_1.method_28())
            {
                num2 = i;
                break;
            }
        }
        for (int j = num2; j < A_0.Text.Length; j++)
        {
            str = str + chArray[j];
        }
        A_2 = new RectangleF(A_1.method_69().X + A_1.method_28(), A_1.method_69().Y, A_1.method_69().Width - A_1.method_28(), A_1.method_69().Height);
        return str;
    }

    private void method_204(TextRange A_0, Class375 A_1, ref string A_2)
    {
        Class206 class2 = A_0.interface23_0 as Class206;
        A_2 = string.Empty;
        StringFormat format = this.method_348(A_0.CharacterFormat);
        if (this.method_353(A_0))
        {
            format = (A_0.OwnerParagraph.ParaStyle != null) ? this.method_348(A_0.OwnerParagraph.ParaStyle.CharacterFormat) : format;
        }
        if ((A_0.CharacterFormat != null) && (A_0.CharacterFormat.Font.Underline || A_0.CharacterFormat.Font.Strikeout))
        {
            this.method_208(A_0, A_1, format, ref A_2);
        }
        switch (class2.method_20())
        {
            case TabLeader.Dotted:
                this.method_205(A_0, A_1, format, ref A_2);
                return;

            case TabLeader.Hyphenated:
                this.method_207(A_0, A_1, format, ref A_2);
                return;

            case TabLeader.Single:
                this.method_206(A_0, A_1, format, ref A_2);
                return;
        }
    }

    private void method_205(TextRange A_0, Class375 A_1, StringFormat A_2, ref string A_3)
    {
        int num = 0x13;
        A_3 = string.Empty;
        float width = 0f;
        if (base.method_1())
        {
            width = this.method_309(BookmarkStart.b("᜸", num), this.method_378(A_0), A_2).Width;
        }
        else
        {
            width = this.method_316(BookmarkStart.b("᜸", num), this.method_367(A_0), A_2).Width;
        }
        for (float i = width; i <= A_1.method_69().Width; i += width)
        {
            A_3 = A_3 + BookmarkStart.b("᜸", num);
        }
    }

    private void method_206(TextRange A_0, Class375 A_1, StringFormat A_2, ref string A_3)
    {
        int num = 0x11;
        A_3 = string.Empty;
        float width = 0f;
        if (base.method_1())
        {
            width = this.method_309(BookmarkStart.b("栶", num), this.method_378(A_0), A_2).Width;
        }
        else
        {
            width = this.method_316(BookmarkStart.b("栶", num), this.method_367(A_0), A_2).Width;
        }
        for (float i = width; i <= A_1.method_69().Width; i += width)
        {
            A_3 = A_3 + BookmarkStart.b("栶", num);
        }
    }

    private void method_207(TextRange A_0, Class375 A_1, StringFormat A_2, ref string A_3)
    {
        int num = 0;
        A_3 = string.Empty;
        float width = 0f;
        if (base.method_1())
        {
            width = this.method_309(BookmarkStart.b("ଥ", num), this.method_378(A_0), A_2).Width;
        }
        else
        {
            width = this.method_316(BookmarkStart.b("ଥ", num), this.method_367(A_0), A_2).Width;
        }
        for (float i = width; i <= A_1.method_69().Width; i += width)
        {
            A_3 = A_3 + BookmarkStart.b("ଥ", num);
        }
    }

    private void method_208(TextRange A_0, Class375 A_1, StringFormat A_2, ref string A_3)
    {
        int num = 7;
        A_3 = string.Empty;
        RectangleF ef = A_1.method_69();
        if (base.method_1())
        {
            while (this.method_309(A_3, this.method_380(A_0, A_0.CharacterFormat, ref ef), A_2).Width <= A_1.method_69().Width)
            {
                A_3 = A_3 + BookmarkStart.b("ബ", num);
            }
        }
        else
        {
            while (this.method_316(A_3, this.method_369(A_0, A_0.CharacterFormat, ref ef), A_2).Width <= A_1.method_69().Width)
            {
                A_3 = A_3 + BookmarkStart.b("ബ", num);
            }
        }
    }

    internal void method_209(Symbol A_0, Class375 A_1)
    {
        string str = char.ConvertFromUtf32(A_0.CharacterCode);
        CharacterFormat characterFormat = A_0.CharacterFormat;
        if ((!A_0.CharacterFormat.HasValue(0) && (A_0.FontName != string.Empty)) && (A_0.FontName != A_0.CharacterFormat.FontName))
        {
            characterFormat = new CharacterFormat(A_0.Document);
            characterFormat.ImportContainer(A_0.CharacterFormat);
            characterFormat.method_21(A_0.CharacterFormat);
            characterFormat.ApplyBase(A_0.method_28().BreakCharacterFormat.BaseFormat);
            characterFormat.FontSize = A_0.CharacterFormat.FontSize;
            characterFormat.FontName = A_0.FontName;
        }
        if (base.method_1())
        {
            Color color = this.method_351(characterFormat);
            sprᝪ rᝪ = this.method_376(characterFormat);
            SizeF ef = this.method_309(str, this.method_376(A_0.CharacterFormat), null);
            SizeF ef2 = this.method_309(str, rᝪ, null);
            float num = Math.Abs((float) (ef2.Height - ef.Height));
            RectangleF ef3 = new RectangleF(new PointF(A_1.method_69().X, A_1.method_69().Y + num), new SizeF(ef2.Width, ef2.Height));
            PointF tf = new PointF(ef3.X, ef3.Y);
            this.method_126().method_11(str, rᝪ, color, tf, ef3.Size, null, null);
        }
        else
        {
            Font font = this.method_365(characterFormat);
            SizeF ef6 = this.method_151().MeasureString(str, this.method_365(A_0.CharacterFormat));
            SizeF ef7 = this.method_151().MeasureString(str, font);
            float num2 = Math.Abs((float) (ef7.Height - ef6.Height));
            RectangleF layoutRectangle = new RectangleF(new PointF(A_1.method_69().X, A_1.method_69().Y + num2), new SizeF(ef7.Width, ef7.Height));
            Color color2 = this.method_351(characterFormat);
            this.method_151().DrawString(str, font, this.method_350(color2), layoutRectangle, null);
        }
    }

    internal void method_210(Hyperlink A_0, Class375 A_1)
    {
        int num = 5;
        this.textRange_0 = null;
        if (A_0.PictureToDisplay is DocPicture)
        {
            if ((A_1.method_69().Width > 0f) && (A_1.method_69().Height > 0f))
            {
                this.method_213(A_0.PictureToDisplay as DocPicture, A_1, true);
            }
        }
        else
        {
            string text = A_0.Field.Text;
            CharacterFormat characterFormat = A_0.Field.CharacterFormat;
            ParagraphFormat format = A_0.Field.method_28().Format;
            if ((A_0.Type == HyperlinkType.Bookmark) && ((A_0.Type != HyperlinkType.Bookmark) || A_0.BookmarkName.ToLower().StartsWith(BookmarkStart.b("琪礬怮爰", num).ToLower())))
            {
                characterFormat = A_0.Field.OwnerParagraph.ParaStyle.CharacterFormat;
            }
            else if (((A_0.Field.NextSibling is FieldMark) && (A_0.Field.NextSibling.NextSibling != null)) && (A_0.Field.NextSibling.NextSibling is TextRange))
            {
                characterFormat = (A_0.Field.NextSibling.NextSibling as TextRange).CharacterFormat;
            }
            Class198 class2 = new Class198 {
                drawingTextDirection_0 = DrawingTextDirection.Horizontal
            };
            this.method_233(text, characterFormat, format, A_1.method_69(), A_1.method_69().Width, class2);
        }
        this.method_396(A_0, A_1.method_69());
    }

    internal void method_211(Field A_0, Class375 A_1)
    {
        string str = A_0.method_177();
        string str2 = str.Trim().Split(new char[] { ' ' })[1];
        bool flag = str.Trim().Contains(BookmarkStart.b("焬䜮", 7));
        if (!str2.ToLower().StartsWith(BookmarkStart.b("爬嬮帰倲", 7)))
        {
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            if (A_0.Owner is SDTInlineContent)
            {
                ownerParagraph = (A_0.Owner as SDTInlineContent).OwnerParagraph;
            }
            Class198 class2 = new Class198 {
                drawingTextDirection_0 = DrawingTextDirection.Horizontal
            };
            this.method_233(A_1.method_64(), A_0.CharacterFormat, ownerParagraph.Format, A_1.method_69(), A_1.method_69().Width, class2);
        }
        if (flag)
        {
            this.method_397(A_0, A_1);
        }
    }

    internal void method_212(MergeField A_0, Class375 A_1)
    {
        string str = string.Empty;
        if ((A_0.IsToTextOfMergeFieldEvent && A_0.ConvertedToText) && !string.IsNullOrEmpty(A_0.Text))
        {
            str = A_0.TextBefore + A_0.Text + A_0.TextAfter;
        }
        else
        {
            str = ((A_0.Value == string.Empty) || (A_1.method_73() is Class542)) ? A_0.Text : A_0.Value;
            str = A_0.TextBefore + str + A_0.TextAfter;
            str = A_0.method_240(str);
        }
        CharacterFormat characterFormat = A_0.CharacterFormat;
        ParagraphFormat format = A_0.OwnerParagraph.Format;
        this.textRange_0 = A_0;
        RectangleF ef2 = A_1.method_69();
        string str2 = null;
        int num = 0;
        int count = A_0.TextItems.Count;
        while (num < count)
        {
            if (num == 0)
            {
                str2 = str2 + A_0.TextBefore;
            }
            str2 = str2 + (A_0.TextItems[num] as TextRange).Text;
            if (num == (count - 1))
            {
                str2 = str2 + A_0.TextAfter;
            }
            num++;
        }
        if (((A_0.TextItems.Count > 1) && ((A_0.TextItems[0] as TextRange).CharacterFormat != (A_0.TextItems[1] as TextRange).CharacterFormat)) && (str2 == str))
        {
            int num3 = 0;
            int num4 = A_0.TextItems.Count;
            while (num3 < num4)
            {
                if (ef2.Width <= 0f)
                {
                    return;
                }
                if (ef2.Height <= 0f)
                {
                    return;
                }
                this.textRange_0 = A_0.TextItems[num3] as TextRange;
                str2 = ((A_0.Value == string.Empty) || (A_1.method_73() is Class542)) ? this.textRange_0.Text : A_0.Value;
                characterFormat = this.textRange_0.CharacterFormat;
                if (num3 == 0)
                {
                    str2 = A_0.TextBefore + str2;
                }
                if (num3 == (num4 - 1))
                {
                    str2 = str2 + A_0.TextAfter;
                }
                SizeF ef = new SizeF();
                if (base.method_1())
                {
                    ef = this.method_309(str2, this.method_376(this.textRange_0.CharacterFormat), this.method_348(this.textRange_0.CharacterFormat));
                }
                else
                {
                    ef = this.method_316(str2, this.textRange_0.CharacterFormat.Font, this.method_348(this.textRange_0.CharacterFormat));
                }
                Class198 class3 = new Class198 {
                    drawingTextDirection_0 = DrawingTextDirection.Horizontal
                };
                this.method_233(str2, characterFormat, format, ef2, A_1.method_69().Width, class3);
                ef2.X += ef.Width;
                ef2.Width -= ef.Width;
                num3++;
            }
        }
        else
        {
            Class198 class2 = new Class198 {
                drawingTextDirection_0 = DrawingTextDirection.Horizontal
            };
            this.method_233(str, characterFormat, format, ef2, A_1.method_69().Width, class2);
        }
    }

    internal void method_213(DocPicture A_0, Class375 A_1, bool A_2)
    {
        if (((A_0 != null) && (A_0.TextWrappingStyleEx != TextWrappingStyle.InFrontOfText)) && (A_0.TextWrappingStyleEx != TextWrappingStyle.Behind))
        {
            this.method_218(A_0, A_1, A_2);
        }
    }

    internal SizeF method_214(ShapeObject A_0)
    {
        float width = (float) A_0.Width;
        return new SizeF(width, (float) A_0.Height);
    }

    internal void method_215(ShapeObject A_0, Class375 A_1)
    {
        if (((A_0 != null) && (A_0.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (A_0.TextWrappingStyle != TextWrappingStyle.Behind))
        {
            this.method_217(A_0, A_1);
        }
    }

    private Image method_216(ShapeObject A_0)
    {
        Image image2;
        int num = 11;
        if (Class915.smethod_0(A_0.ImageData.method_77()))
        {
            return null;
        }
        Image image = A_0.ImageData.Image;
        string str = image.PixelFormat.ToString().ToLowerInvariant();
        float horizontalResolution = image.HorizontalResolution;
        if (image is Metafile)
        {
            image = this.method_221(image);
        }
        float num2 = 1f;
        if (((image != null) && ((image.Width > 0x1388) || (image.Height > 0x1388))) && !str.Contains(BookmarkStart.b("堰崲儴制䄸帺夼", num)))
        {
            num2 = Math.Min((float) (5000f / ((float) image.Width)), (float) (5000f / ((float) image.Height)));
            image = this.method_395(image, image.Width * num2, image.Height * num2);
        }
        else if (horizontalResolution != image.HorizontalResolution)
        {
            num2 = (float) Math.Round((double) (image.HorizontalResolution / horizontalResolution), 1);
        }
        if (((image != null) && (image is Bitmap)) && (image.PixelFormat == ((PixelFormat) 0x200f)))
        {
            Bitmap bitmap4 = image as Bitmap;
            RectangleF rect = new RectangleF(PointF.Empty, (SizeF) image.Size);
            try
            {
                image = bitmap4.Clone(rect, PixelFormat.Format24bppRgb);
            }
            catch (OutOfMemoryException)
            {
                return null;
            }
        }
        if (!Class915.smethod_0(A_0.ImageData.method_77()))
        {
            Bitmap bitmap = null;
            if (image is Bitmap)
            {
                bitmap = image as Bitmap;
                GraphicsUnit pixel = GraphicsUnit.Pixel;
                RectangleF bounds = image.GetBounds(ref pixel);
                bounds = A_0.ImageData.method_77().method_3(bounds);
                if ((num2 > 0f) && (num2 != 1.0))
                {
                    bounds = new RectangleF((float) ((int) (bounds.X * num2)), (float) ((int) (bounds.Y * num2)), (float) ((int) (bounds.Width * num2)), (float) ((int) (bounds.Height * num2)));
                }
                try
                {
                    image = bitmap.Clone(bounds, image.PixelFormat);
                    if (((image != null) && (image is Bitmap)) && (image.PixelFormat == PixelFormat.Format8bppIndexed))
                    {
                        try
                        {
                            Bitmap bitmap2 = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
                            bitmap2.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                            using (Graphics graphics = Graphics.FromImage(bitmap2))
                            {
                                graphics.DrawImageUnscaled(image, 0, 0);
                                graphics.Dispose();
                            }
                            image = bitmap2;
                        }
                        catch (OutOfMemoryException)
                        {
                            return null;
                        }
                    }
                }
                catch (OutOfMemoryException)
                {
                    return null;
                }
            }
        }
        Color chromaKey = A_0.ImageData.ChromaKey;
        if (!A_0.ImageData.ChromaKey.IsEmpty)
        {
            try
            {
                Bitmap bitmap5 = new Bitmap(image.Width, image.Height);
                using (Graphics graphics3 = Graphics.FromImage(bitmap5))
                {
                    int num5 = 0x18;
                    ImageAttributes imageAttr = new ImageAttributes();
                    Color colorLow = Color.FromArgb(0, ((A_0.ImageData.ChromaKey.R - 0x18) < 0) ? 0 : (A_0.ImageData.ChromaKey.R - num5), ((A_0.ImageData.ChromaKey.G - num5) < 0) ? 0 : (A_0.ImageData.ChromaKey.G - num5), ((A_0.ImageData.ChromaKey.B - num5) < 0) ? 0 : (A_0.ImageData.ChromaKey.B - num5));
                    Color colorHigh = Color.FromArgb(0, ((A_0.ImageData.ChromaKey.R + num5) > 0xff) ? 0xff : (A_0.ImageData.ChromaKey.R + num5), ((A_0.ImageData.ChromaKey.G + num5) > 0xff) ? 0xff : (A_0.ImageData.ChromaKey.G + num5), ((A_0.ImageData.ChromaKey.B + num5) > 0xff) ? 0xff : (A_0.ImageData.ChromaKey.B + num5));
                    imageAttr.SetColorKey(colorLow, colorHigh);
                    graphics3.DrawImage(image, new Rectangle(0, 0, bitmap5.Width, bitmap5.Height), 0, 0, bitmap5.Width, bitmap5.Height, GraphicsUnit.Pixel, imageAttr);
                    graphics3.Dispose();
                    imageAttr.Dispose();
                }
                image = bitmap5;
            }
            catch (OutOfMemoryException)
            {
                return null;
            }
        }
        if ((A_0.ImageData.Brightness == 0f) && (A_0.ImageData.Contrast == 0f))
        {
            return image;
        }
        try
        {
            float num3 = A_0.ImageData.Brightness / 100f;
            float num4 = (A_0.ImageData.Contrast == 0f) ? 1f : (1f + (A_0.ImageData.Contrast / 100f));
            float[][] numArray3 = new float[5][];
            float[] numArray4 = new float[5];
            numArray4[0] = 1f;
            numArray3[0] = numArray4;
            float[] numArray5 = new float[5];
            numArray5[1] = 1f;
            numArray3[1] = numArray5;
            float[] numArray6 = new float[5];
            numArray6[2] = 1f;
            numArray3[2] = numArray6;
            float[] numArray7 = new float[5];
            numArray7[3] = 1f;
            numArray3[3] = numArray7;
            float[] numArray8 = new float[5];
            numArray8[0] = num3;
            numArray8[1] = num3;
            numArray8[2] = num3;
            numArray8[4] = 1f;
            numArray3[4] = numArray8;
            float[][] numArray = numArray3;
            float[][] numArray9 = new float[5][];
            float[] numArray10 = new float[5];
            numArray10[0] = num4;
            numArray9[0] = numArray10;
            float[] numArray11 = new float[5];
            numArray11[1] = num4;
            numArray9[1] = numArray11;
            float[] numArray12 = new float[5];
            numArray12[2] = num4;
            numArray9[2] = numArray12;
            float[] numArray13 = new float[5];
            numArray13[3] = 1f;
            numArray9[3] = numArray13;
            float[] numArray14 = new float[5];
            numArray14[4] = 1f;
            numArray9[4] = numArray14;
            float[][] numArray2 = numArray9;
            float[][] numArray15 = new float[5][];
            float[] numArray16 = new float[5];
            numArray16[0] = num4;
            numArray15[0] = numArray16;
            float[] numArray17 = new float[5];
            numArray17[1] = num4;
            numArray15[1] = numArray17;
            float[] numArray18 = new float[5];
            numArray18[2] = num4;
            numArray15[2] = numArray18;
            float[] numArray19 = new float[5];
            numArray19[3] = 1f;
            numArray15[3] = numArray19;
            float[] numArray20 = new float[5];
            numArray20[0] = num3;
            numArray20[1] = num3;
            numArray20[2] = num3;
            numArray20[4] = 1f;
            numArray15[4] = numArray20;
            float[][] numArray21 = numArray15;
            float[][] newColorMatrix = ((A_0.ImageData.Brightness == 0f) || (A_0.ImageData.Contrast == 0f)) ? (((A_0.ImageData.Brightness == 0f) || (A_0.ImageData.Contrast != 0f)) ? numArray2 : numArray) : numArray21;
            ImageAttributes attributes = new ImageAttributes();
            attributes.ClearColorMatrix();
            attributes.SetColorMatrix(new ColorMatrix(newColorMatrix));
            Bitmap bitmap3 = new Bitmap(image.Width, image.Height);
            using (Graphics graphics2 = Graphics.FromImage(bitmap3))
            {
                graphics2.Clear(Color.White);
                graphics2.DrawImage(image, new Rectangle(0, 0, bitmap3.Width, bitmap3.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                graphics2.Dispose();
            }
            attributes.Dispose();
            return bitmap3;
        }
        catch (OutOfMemoryException)
        {
            image2 = new Bitmap(image);
        }
        return image2;
    }

    internal void method_217(ShapeObject A_0, Class375 A_1)
    {
        if (((A_0.Width != 0.0) && (A_0.Height != 0.0)) || (!A_0.HasImage && !(A_0 is ShapeGroup)))
        {
            RectangleF ef = A_1.method_69();
            if (base.method_1())
            {
                foreach (ShapeObject obj2 in A_0.ChildObjects)
                {
                    if (obj2.HasImage)
                    {
                        Image image = this.method_216(obj2);
                        if (image != null)
                        {
                            obj2.ImageData.LoadImage(image);
                        }
                    }
                }
                this.method_126().method_14(ef.Location, A_0.method_49());
            }
            else
            {
                GraphicsState gstate = this.method_151().Save();
                this.method_151().TranslateTransform(ef.X, ef.Y);
                A_0.method_50(this.method_151(), this.method_143());
                this.method_151().Restore(gstate);
            }
            if (A_0.OwnerHyperlinkField != null)
            {
                Hyperlink hyperlink = new Hyperlink(A_0.OwnerHyperlinkField);
                this.method_396(hyperlink, A_1.method_69());
            }
            else if (A_0.HasHyperlink && !string.IsNullOrEmpty(A_0.HyperlinkAddress))
            {
                this.method_398(A_0.HyperlinkAddress, A_1.method_69());
            }
        }
    }

    internal void method_218(DocPicture A_0, Class375 A_1, bool A_2)
    {
        if ((A_0 != null) && ((A_0.HasImage && (A_1.method_69().Width != 0f)) && (A_1.method_69().Height != 0f)))
        {
            SizeF ef3 = this.method_306(A_0);
            RectangleF ef4 = A_1.method_69();
            if (A_0.TextWrappingStyle == TextWrappingStyle.Square)
            {
                ef4.X += A_0.EffectExtentLeft;
                ef4.Y += A_0.EffectExtentTop;
                ef4.Width -= A_0.EffectExtentLeft;
                ef4.Height -= A_0.EffectExtentTop;
            }
            ef4.Width -= A_0.EffectExtentRight;
            ef4.Height -= A_0.EffectExtentBottom;
            if (float.IsNaN(ef4.X))
            {
                ef4.X = 0f;
            }
            if (float.IsNaN(ef4.Width) || ((A_0.TextWrappingStyle == TextWrappingStyle.Inline) && (ef4.Width < ef3.Width)))
            {
                ef4.Width = ef3.Width;
            }
            if (float.IsNaN(ef4.Height))
            {
                ef4.Height = ef3.Height;
            }
            GraphicsState gstate = null;
            if (base.method_1())
            {
                this.method_126().method_4();
            }
            else
            {
                gstate = this.method_151().Save();
            }
            if (A_1.method_73().imethod_0().imethod_30())
            {
                TableCell ownerTextBody = (A_1.method_73() as DocPicture).OwnerParagraph.OwnerTextBody as TableCell;
                float num = (ownerTextBody.interface23_0 as Class211).method_115();
                float num2 = (ownerTextBody.interface23_0 as Class211).method_117();
                (ownerTextBody.interface23_0 as Class211).method_119();
                float num3 = (float) ownerTextBody.interface23_0.imethod_0().method_0();
                float dy = ((num2 - ef4.Y) + (ef4.X - num)) + num3;
                if (ownerTextBody.CellFormat.TextDirection == TextDirection.TopToBottom)
                {
                    float dx = (((this.method_239(A_0) + num) - ef4.Y) - ef4.Width) - num3;
                    if (!base.method_1())
                    {
                        this.method_151().TranslateTransform(dx, dy);
                    }
                }
                else if (!base.method_1())
                {
                    this.method_151().TranslateTransform(ef4.Y - num2, dy);
                }
            }
            RectangleF ef5 = ef4;
            ef5.X -= A_0.EffectExtentLeft;
            ef5.Width += A_0.EffectExtentLeft;
            ef5.Y -= A_0.EffectExtentTop;
            ef5.Height += A_0.EffectExtentTop;
            if ((A_0.Rotation != 0f) && !base.method_1())
            {
                RectangleF ef6 = A_1.method_69();
                this.method_151().TranslateTransform(ef6.X + (ef6.Width / 2f), ef6.Y + (ef6.Height / 2f));
                this.method_151().RotateTransform(A_0.Rotation);
                this.method_151().TranslateTransform(-(ef6.X + (ef6.Width / 2f)), -(ef6.Y + (ef6.Height / 2f)));
            }
            if (base.method_1())
            {
                this.method_126().method_6(ef5);
            }
            else
            {
                this.method_151().SetClip(ef5, CombineMode.Intersect);
            }
            ef4.Width = (ef4.Width < 1f) ? 1f : ef4.Width;
            ef4.Height = (ef4.Height < 1f) ? 1f : ef4.Height;
            RectangleF ef7 = ef4;
            if (!A_0.Borders.NoBorder)
            {
                Borders borders = A_0.Borders;
                float num6 = borders.Left.LineWidth + borders.Left.Space;
                float num7 = borders.Right.LineWidth + borders.Right.Space;
                float num8 = borders.Top.LineWidth + borders.Top.Space;
                float num9 = borders.Bottom.LineWidth + borders.Bottom.Space;
                ef4 = new RectangleF(ef4.X + num6, ef4.Y + num8, (ef4.Width - num6) - num7, (ef4.Height - num8) - num9);
            }
            if (A_2)
            {
                Image image = this.method_225(A_0, ef4.Width, ef4.Height);
                if (base.method_1())
                {
                    this.method_126().method_15(image, ef4);
                }
                else
                {
                    this.method_151().DrawImage(image, ef4);
                }
                image.Dispose();
            }
            else
            {
                Image image2 = this.method_225(A_0, ef4.Width, ef4.Height);
                using (Image image3 = this.method_395(image2, ef4.Width, ef4.Height))
                {
                    if (base.method_1())
                    {
                        this.method_126().method_15(image2, ef4);
                    }
                    else
                    {
                        this.method_151().DrawImage(image3, ef4);
                    }
                    image3.Dispose();
                }
                image2.Dispose();
            }
            if (base.method_1())
            {
                this.method_126().method_7();
            }
            else
            {
                this.method_151().ResetClip();
            }
            if (base.method_1())
            {
                this.method_126().method_5();
            }
            else
            {
                this.method_151().Restore(gstate);
            }
            if (!A_0.Borders.NoBorder)
            {
                this.method_265(A_0.Borders, ef7);
            }
            if (A_0.OwnerHyperlinkField != null)
            {
                Hyperlink hyperlink = new Hyperlink(A_0.OwnerHyperlinkField);
                this.method_396(hyperlink, A_1.method_69());
            }
        }
    }

    private Bitmap method_219(Image A_0, SizeF A_1)
    {
        Bitmap bitmap;
        int width = (int) A_1.Width;
        float num2 = ((float) width) / A_1.Height;
        float num3 = ((float) width) / A_1.Width;
        int num4 = (int) (A_0.Size.Width * num3);
        int num5 = (int) (A_0.Size.Height * num2);
        if (width < 150)
        {
            int num6 = 150 / width;
            num6 = (((150 % width) == 0) || ((num6 % 2) == 0)) ? num6 : (num6 + 1);
            width *= num6;
            num2 = ((float) width) / A_1.Height;
            num3 = ((float) width) / A_1.Width;
            num4 = (int) (A_0.Size.Width * num3);
            num5 = (int) (A_0.Size.Height * num2);
        }
        if (!base.method_88(num4, num5))
        {
            goto Label_011B;
        }
        width = 300;
    Label_00CF:
        num2 = ((float) width) / A_1.Height;
        num3 = ((float) width) / A_1.Width;
        num4 = (int) (A_0.Size.Width * num3);
        num5 = (int) (A_0.Size.Height * num2);
        if (base.method_88(num4, num5))
        {
            width /= 2;
            goto Label_00CF;
        }
    Label_011B:
        bitmap = new Bitmap(num4, num5);
        bitmap.SetResolution((float) width, (float) width);
        using (Graphics graphics = this.method_220(bitmap))
        {
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(A_0, 0, 0);
            A_0.Dispose();
        }
        return bitmap;
    }

    public Graphics method_220(Image A_0)
    {
        return Graphics.FromImage(A_0);
    }

    private Image method_221(Image A_0)
    {
        if (base.method_1())
        {
            return A_0;
        }
        if (A_0 == null)
        {
            return null;
        }
        return this.method_219(A_0, new SizeF(A_0.HorizontalResolution, A_0.VerticalResolution));
    }

    private Image method_222(Image A_0, RectangleF A_1)
    {
        return this.method_223(A_0, (int) A_1.X, (int) A_1.Y, (int) A_1.Width, (int) A_1.Height);
    }

    private Image method_223(Image A_0, int A_1, int A_2, int A_3, int A_4)
    {
        Bitmap image = new Bitmap(A_3, A_4);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            Rectangle destRect = new Rectangle(new Point(0, 0), new Size(A_3, A_4));
            Rectangle srcRect = new Rectangle(new Point(A_1, A_2), new Size(A_3, A_4));
            graphics.DrawImage(A_0, destRect, srcRect, GraphicsUnit.Pixel);
        }
        return image;
    }

    private Image method_224(Image A_0, RectangleF A_1)
    {
        if (A_1 == RectangleF.Empty)
        {
            return null;
        }
        Bitmap image = new Bitmap((int) A_1.Width, (int) A_1.Height);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.DrawImage(A_0, new RectangleF(new PointF(0f, 0f), A_1.Size));
        }
        return image;
    }

    private Image method_225(DocPicture A_0, float A_1, float A_2)
    {
        int num = 9;
        Image image = A_0.Image;
        string str = image.PixelFormat.ToString().ToLowerInvariant();
        float horizontalResolution = image.HorizontalResolution;
        if (image is Metafile)
        {
            image = this.method_221(image);
        }
        float num5 = 1f;
        if (((image != null) && ((image.Width > 0x1388) || (image.Height > 0x1388))) && !str.Contains(BookmarkStart.b("䘮弰圲倴伶尸强", num)))
        {
            num5 = Math.Min((float) (5000f / ((float) image.Width)), (float) (5000f / ((float) image.Height)));
            image = this.method_395(image, image.Width * num5, image.Height * num5);
        }
        else if (horizontalResolution != image.HorizontalResolution)
        {
            num5 = (float) Math.Round((double) (image.HorizontalResolution / horizontalResolution), 1);
        }
        if (((image != null) && (image is Bitmap)) && (image.PixelFormat == ((PixelFormat) 0x200f)))
        {
            Bitmap bitmap3 = image as Bitmap;
            try
            {
                image = this.method_226(bitmap3);
            }
            catch (OutOfMemoryException)
            {
                return new Bitmap(image);
            }
        }
        if (A_0.IsCrop && A_0.IsPositivelyCrop)
        {
            Bitmap bitmap2 = null;
            if (image is Bitmap)
            {
                bitmap2 = image as Bitmap;
                RectangleF cropRectangle = A_0.CropRectangle;
                if ((num5 > 0f) && (num5 != 1.0))
                {
                    cropRectangle = new RectangleF((float) ((int) (cropRectangle.X * num5)), (float) ((int) (cropRectangle.Y * num5)), (float) ((int) (cropRectangle.Width * num5)), (float) ((int) (cropRectangle.Height * num5)));
                }
                if (cropRectangle.Width > bitmap2.Width)
                {
                    cropRectangle.Width = bitmap2.Width;
                }
                if ((cropRectangle.X + cropRectangle.Width) > bitmap2.Width)
                {
                    cropRectangle.Width = bitmap2.Width - cropRectangle.X;
                }
                if (cropRectangle.Height > bitmap2.Height)
                {
                    cropRectangle.Height = bitmap2.Height;
                }
                try
                {
                    image = bitmap2.Clone(cropRectangle, image.PixelFormat);
                    if (((image != null) && (image is Bitmap)) && (image.PixelFormat == PixelFormat.Format8bppIndexed))
                    {
                        try
                        {
                            Bitmap bitmap4 = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
                            bitmap4.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                            using (Graphics graphics2 = Graphics.FromImage(bitmap4))
                            {
                                graphics2.DrawImageUnscaled(image, 0, 0);
                                graphics2.Dispose();
                            }
                            image = bitmap4;
                        }
                        catch (OutOfMemoryException)
                        {
                            return new Bitmap(image);
                        }
                    }
                }
                catch (OutOfMemoryException)
                {
                    return new Bitmap(image);
                }
            }
        }
        Color chromaKey = A_0.ChromaKey;
        if (!A_0.ChromaKey.IsEmpty)
        {
            try
            {
                Bitmap bitmap6 = new Bitmap(image.Width, image.Height);
                using (Graphics graphics4 = Graphics.FromImage(bitmap6))
                {
                    int num7 = 0x18;
                    ImageAttributes imageAttr = new ImageAttributes();
                    Color colorLow = Color.FromArgb(0, ((A_0.ChromaKey.R - 0x18) < 0) ? 0 : (A_0.ChromaKey.R - num7), ((A_0.ChromaKey.G - num7) < 0) ? 0 : (A_0.ChromaKey.G - num7), ((A_0.ChromaKey.B - num7) < 0) ? 0 : (A_0.ChromaKey.B - num7));
                    Color colorHigh = Color.FromArgb(0, ((A_0.ChromaKey.R + num7) > 0xff) ? 0xff : (A_0.ChromaKey.R + num7), ((A_0.ChromaKey.G + num7) > 0xff) ? 0xff : (A_0.ChromaKey.G + num7), ((A_0.ChromaKey.B + num7) > 0xff) ? 0xff : (A_0.ChromaKey.B + num7));
                    imageAttr.SetColorKey(colorLow, colorHigh);
                    graphics4.DrawImage(image, new Rectangle(0, 0, bitmap6.Width, bitmap6.Height), 0, 0, bitmap6.Width, bitmap6.Height, GraphicsUnit.Pixel, imageAttr);
                    graphics4.Dispose();
                    imageAttr.Dispose();
                }
                image = bitmap6;
            }
            catch (OutOfMemoryException)
            {
                return new Bitmap(image);
            }
        }
        if ((A_0.AlphaModFix >= 0f) && (A_0.AlphaModFix < 100.0))
        {
            try
            {
                float num6 = A_0.AlphaModFix / 100f;
                ImageAttributes attributes2 = new ImageAttributes();
                attributes2.ClearColorMatrix();
                ColorMatrix newColorMatrix = new ColorMatrix {
                    Matrix33 = num6
                };
                attributes2.SetColorMatrix(newColorMatrix);
                Bitmap bitmap5 = new Bitmap(image.Width, image.Height);
                using (Graphics graphics3 = Graphics.FromImage(bitmap5))
                {
                    graphics3.DrawImage(image, new Rectangle(0, 0, bitmap5.Width, bitmap5.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes2);
                    graphics3.Dispose();
                }
                attributes2.Dispose();
                image = bitmap5;
            }
            catch (OutOfMemoryException)
            {
                return new Bitmap(image);
            }
        }
        if ((A_0.Brightness != 0f) || (A_0.Contrast != 0f))
        {
            try
            {
                float num3 = A_0.Brightness / 100f;
                float num4 = (A_0.Contrast == 0f) ? 1f : (1f + (A_0.Contrast / 100f));
                float[][] numArray4 = new float[5][];
                float[] numArray5 = new float[5];
                numArray5[0] = 1f;
                numArray4[0] = numArray5;
                float[] numArray6 = new float[5];
                numArray6[1] = 1f;
                numArray4[1] = numArray6;
                float[] numArray7 = new float[5];
                numArray7[2] = 1f;
                numArray4[2] = numArray7;
                float[] numArray8 = new float[5];
                numArray8[3] = 1f;
                numArray4[3] = numArray8;
                float[] numArray9 = new float[5];
                numArray9[0] = num3;
                numArray9[1] = num3;
                numArray9[2] = num3;
                numArray9[4] = 1f;
                numArray4[4] = numArray9;
                float[][] numArray10 = numArray4;
                float[][] numArray11 = new float[5][];
                float[] numArray12 = new float[5];
                numArray12[0] = num4;
                numArray11[0] = numArray12;
                float[] numArray13 = new float[5];
                numArray13[1] = num4;
                numArray11[1] = numArray13;
                float[] numArray14 = new float[5];
                numArray14[2] = num4;
                numArray11[2] = numArray14;
                float[] numArray15 = new float[5];
                numArray15[3] = 1f;
                numArray11[3] = numArray15;
                float[] numArray16 = new float[5];
                numArray16[4] = 1f;
                numArray11[4] = numArray16;
                float[][] numArray3 = numArray11;
                float[][] numArray17 = new float[5][];
                float[] numArray18 = new float[5];
                numArray18[0] = num4;
                numArray17[0] = numArray18;
                float[] numArray19 = new float[5];
                numArray19[1] = num4;
                numArray17[1] = numArray19;
                float[] numArray20 = new float[5];
                numArray20[2] = num4;
                numArray17[2] = numArray20;
                float[] numArray21 = new float[5];
                numArray21[3] = 1f;
                numArray17[3] = numArray21;
                float[] numArray22 = new float[5];
                numArray22[0] = num3;
                numArray22[1] = num3;
                numArray22[2] = num3;
                numArray22[4] = 1f;
                numArray17[4] = numArray22;
                float[][] numArray = numArray17;
                float[][] numArray2 = ((A_0.Brightness == 0f) || (A_0.Contrast == 0f)) ? (((A_0.Brightness == 0f) || (A_0.Contrast != 0f)) ? numArray3 : numArray10) : numArray;
                ImageAttributes attributes = new ImageAttributes();
                attributes.ClearColorMatrix();
                attributes.SetColorMatrix(new ColorMatrix(numArray2));
                Bitmap bitmap = new Bitmap(image.Width, image.Height);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                    graphics.Dispose();
                }
                attributes.Dispose();
                image = bitmap;
            }
            catch (OutOfMemoryException)
            {
                return new Bitmap(image);
            }
        }
        if (A_0.Color != PictureColor.Automatic)
        {
            Image image2;
            try
            {
                switch (A_0.Color)
                {
                    case PictureColor.Grayscale:
                        image = this.method_229(image);
                        break;

                    case PictureColor.BlackAndWhite:
                        image = this.method_228(image);
                        break;

                    case PictureColor.Washout:
                        image = this.method_230(image);
                        break;
                }
                goto Label_0859;
            }
            catch (OutOfMemoryException)
            {
                image2 = new Bitmap(image);
            }
            return image2;
        }
    Label_0859:
        if (this.method_143())
        {
            return this.method_227(image, A_1, A_2);
        }
        return image;
    }

    private Bitmap method_226(Bitmap A_0)
    {
        Bitmap image = new Bitmap(A_0.Width, A_0.Height, PixelFormat.Format24bppRgb);
        image.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            Rectangle rect = new Rectangle(0, 0, A_0.Width, A_0.Height);
            graphics.DrawImage(A_0, rect);
        }
        A_0.Dispose();
        return image;
    }

    internal Image method_227(Image A_0, float A_1, float A_2)
    {
        Image image = A_0;
        if ((A_0 is Bitmap) && ((A_0.HorizontalResolution > 300f) || (A_0.VerticalResolution > 300f)))
        {
            int num3 = (int) Math.Round((double) (A_0.Width * (300f / A_0.HorizontalResolution)));
            int num4 = (int) Math.Round((double) (A_0.Height * (300f / A_0.VerticalResolution)));
            Bitmap bitmap2 = new Bitmap(num3, num4);
            bitmap2.SetResolution(300f, 300f);
            using (Graphics graphics2 = Graphics.FromImage(bitmap2))
            {
                graphics2.DrawImage(A_0, new RectangleF(0f, 0f, (float) num3, (float) num4));
            }
            A_0.Dispose();
            A_0 = null;
            image = bitmap2;
        }
        if (((A_1 * 6.25) >= image.Width) && ((A_2 * 6.25) >= image.Height))
        {
            return image;
        }
        int width = (int) Math.Round((double) (A_1 * 6.25));
        int height = (int) Math.Round((double) (A_2 * 6.25));
        Bitmap bitmap = new Bitmap(width, height);
        bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            graphics.DrawImage(image, new RectangleF(0f, 0f, (float) width, (float) height));
        }
        image.Dispose();
        image = null;
        return bitmap;
    }

    private Image method_228(Image A_0)
    {
        Bitmap image = new Bitmap(A_0.Width, A_0.Height);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.Clear(Color.White);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            float[][] numArray = new float[5][];
            numArray[0] = new float[] { 0.299f, 0.299f, 0.299f, 0f, 0f };
            numArray[1] = new float[] { 0.587f, 0.587f, 0.587f, 0f, 0f };
            numArray[2] = new float[] { 0.114f, 0.114f, 0.114f, 0f, 0f };
            float[] numArray2 = new float[5];
            numArray2[3] = 1f;
            numArray[3] = numArray2;
            float[] numArray3 = new float[5];
            numArray3[4] = 1f;
            numArray[4] = numArray3;
            float[][] newColorMatrix = numArray;
            ColorMatrix matrix = new ColorMatrix(newColorMatrix);
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.ClearColorMatrix();
            imageAttr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttr.SetThreshold(0.5f, ColorAdjustType.Bitmap);
            graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height), 0, 0, A_0.Width, A_0.Height, GraphicsUnit.Pixel, imageAttr);
            graphics.Dispose();
            imageAttr.Dispose();
        }
        return image;
    }

    private Image method_229(Image A_0)
    {
        Bitmap image = new Bitmap(A_0.Width, A_0.Height);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.Clear(Color.White);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            float[][] numArray = new float[5][];
            numArray[0] = new float[] { 0.299f, 0.299f, 0.299f, 0f, 0f };
            numArray[1] = new float[] { 0.587f, 0.587f, 0.587f, 0f, 0f };
            numArray[2] = new float[] { 0.114f, 0.114f, 0.114f, 0f, 0f };
            float[] numArray2 = new float[5];
            numArray2[3] = 1f;
            numArray[3] = numArray2;
            float[] numArray3 = new float[5];
            numArray3[4] = 1f;
            numArray[4] = numArray3;
            float[][] newColorMatrix = numArray;
            ColorMatrix matrix = new ColorMatrix(newColorMatrix);
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.ClearColorMatrix();
            imageAttr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height), 0, 0, A_0.Width, A_0.Height, GraphicsUnit.Pixel, imageAttr);
            graphics.Dispose();
            imageAttr.Dispose();
        }
        return image;
    }

    private Image method_230(Image A_0)
    {
        Bitmap image = new Bitmap(A_0.Width, A_0.Height);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.Clear(Color.White);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            ColorMatrix newColorMatrix = new ColorMatrix {
                Matrix33 = 0.5f
            };
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.ClearColorMatrix();
            imageAttr.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height), 0, 0, A_0.Width, A_0.Height, GraphicsUnit.Pixel, imageAttr);
            graphics.Dispose();
            imageAttr.Dispose();
        }
        return image;
    }

    internal ColorMatrix method_231(float A_0, float A_1)
    {
        float num;
        if (A_0 < 0.5f)
        {
            num = 2f * A_0;
        }
        else if (A_0 > 0.99f)
        {
            num = 500f;
        }
        else
        {
            num = Math.Min((float) ((1.1f * ((float) Math.Tan(3.1415926535897931 * (A_0 - 0.5f)))) + 1f), (float) 500f);
        }
        float num2 = (num * (A_1 - 1f)) + A_1;
        float[][] newColorMatrix = new float[5][];
        float[] numArray2 = new float[5];
        numArray2[0] = num;
        newColorMatrix[0] = numArray2;
        float[] numArray3 = new float[5];
        numArray3[1] = num;
        newColorMatrix[1] = numArray3;
        float[] numArray4 = new float[5];
        numArray4[2] = num;
        newColorMatrix[2] = numArray4;
        float[] numArray5 = new float[5];
        numArray5[3] = 1f;
        newColorMatrix[3] = numArray5;
        float[] numArray6 = new float[5];
        numArray6[0] = num2;
        numArray6[1] = num2;
        numArray6[2] = num2;
        numArray6[4] = 1f;
        newColorMatrix[4] = numArray6;
        return new ColorMatrix(newColorMatrix);
    }

    private float[][] method_232(float[][] A_0, float[][] A_1)
    {
        float[][] numArray = new float[5][];
        for (int i = 0; i < 5; i++)
        {
            numArray[i] = new float[5];
        }
        int num3 = 5;
        float[] numArray3 = new float[5];
        for (int j = 0; j < 5; j++)
        {
            for (int k = 0; k < 5; k++)
            {
                numArray3[k] = A_0[k][j];
            }
            for (int m = 0; m < 5; m++)
            {
                float[] numArray2 = A_1[m];
                float num6 = 0f;
                for (int n = 0; n < num3; n++)
                {
                    num6 += numArray2[n] * numArray3[n];
                }
                numArray[m][j] = num6;
            }
        }
        return numArray;
    }

    internal void method_233(string A_0, CharacterFormat A_1, ParagraphFormat A_2, RectangleF A_3, float A_4, Class198 A_5)
    {
        this.method_234(A_0, A_1, A_2, A_3, A_4, A_5, CharacterCategory.Ascii);
    }

    internal void method_234(string A_0, CharacterFormat A_1, ParagraphFormat A_2, RectangleF A_3, float A_4, Class198 A_5, CharacterCategory A_6)
    {
        int num = 1;
        if ((A_0 != null) && (A_3.Height != 0f))
        {
            float num3 = 0f;
            Class560 class2 = ((Interface11) A_1).imethod_0() as Class560;
            A_5.bool_0 = class2.method_13();
            A_5.float_0 = class2.method_16();
            A_5.float_1 = class2.method_15();
            Font font = null;
            StringFormat format = null;
            Color black = Color.Black;
            sprᝪ rᝪ = null;
            if (base.method_1())
            {
                if (!this.bool_19)
                {
                    RectangleF ef6 = A_3;
                    rᝪ = this.method_380(this.textRange_0, A_1, ref ef6);
                }
                else
                {
                    rᝪ = this.method_377(A_1, A_6);
                }
            }
            else
            {
                if (!this.bool_19)
                {
                    RectangleF ef5 = A_3;
                    font = this.method_369(this.textRange_0, A_1, ref ef5);
                }
                else
                {
                    font = this.method_366(A_1, A_6);
                }
                format = this.method_348(A_1);
                if (this.method_353(this.textRange_0))
                {
                    format = ((this.paragraph_1 == null) || (this.paragraph_1.ParaStyle == null)) ? format : this.method_348(this.paragraph_1.ParaStyle.CharacterFormat);
                }
            }
            black = this.method_351(A_1);
            float height = A_3.Height;
            float y = A_3.Y;
            if (A_2 != null)
            {
                height = (A_3.Height - A_2.Borders.Bottom.LineWidth) - A_2.Borders.Top.LineWidth;
                y = A_3.Y + A_2.Borders.Top.LineWidth;
            }
            if (!A_1.TextBackgroundColor.IsEmpty && A_1.method_72(9))
            {
                this.method_286(A_1.TextBackgroundColor, new RectangleF(A_3.X, y, A_4, height));
            }
            if ((A_1.HighlightColor != Color.Empty) && A_1.method_72(20))
            {
                Color highlightColor = A_1.HighlightColor;
                if (highlightColor == Color.Green)
                {
                    highlightColor = Color.FromArgb(0xff, 0, 0xff, 0);
                }
                if (highlightColor == Color.Gold)
                {
                    highlightColor = Color.FromArgb(0xff, 0x80, 0x80, 0);
                }
                if (highlightColor.Name == BookmarkStart.b("ἦᤨጪᴬᜮİ", num))
                {
                    highlightColor = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                }
                this.method_286(highlightColor, new RectangleF(A_3.X, y, A_3.Width, height));
            }
            string[] strArray = this.method_235(A_0, A_5);
            for (int i = 0; i < strArray.Length; i++)
            {
                A_0 = strArray[i];
                if (A_0 == null)
                {
                    return;
                }
                bool flag = i != (strArray.Length - 1);
                A_3 = new RectangleF(A_3.X + num3, A_3.Y, A_3.Width - num3, A_3.Height);
                A_0 = A_0.Replace('\x001e'.ToString(), BookmarkStart.b("ਦ", num));
                A_0 = A_0.Replace('\x00ad'.ToString(), BookmarkStart.b("ਦ", num));
                A_0 = A_0.Replace('\x0016', ' ');
                if (class2.method_14())
                {
                    A_0 = A_0.ToUpper();
                }
                if (this.bool_19)
                {
                    if (class2.method_13())
                    {
                        A_3.Width = base.method_1() ? this.method_310(A_0, rᝪ, null, true).Width : this.method_317(A_0, font, null, true).Width;
                    }
                    else
                    {
                        A_3.Width = base.method_1() ? this.method_309(A_0, rᝪ, null).Width : this.method_316(A_0, font, null).Width;
                    }
                }
                if (A_1.Emboss)
                {
                    if (base.method_1())
                    {
                        num3 = this.method_252(A_0, A_5, rᝪ, Color.Black, new RectangleF(A_3.X + 0.2f, A_3.Y + 0.2f, A_3.Width, A_3.Height), format, flag);
                    }
                    else
                    {
                        num3 = this.method_250(A_0, A_5, font, Color.Black, new RectangleF(A_3.X + 0.2f, A_3.Y + 0.2f, A_3.Width, A_3.Height), format, flag);
                    }
                }
                if (A_1.Engrave)
                {
                    if (base.method_1())
                    {
                        num3 = this.method_252(A_0, A_5, rᝪ, Color.Black, new RectangleF(A_3.X - 0.2f, A_3.Y - 0.2f, A_3.Width, A_3.Height), format, flag);
                    }
                    else
                    {
                        num3 = this.method_250(A_0, A_5, font, Color.Black, new RectangleF(A_3.X - 0.2f, A_3.Y - 0.2f, A_3.Width, A_3.Height), format, flag);
                    }
                }
                if (this.method_240(A_0))
                {
                    if (base.method_1())
                    {
                        num3 = this.method_252("", A_5, rᝪ, black, A_3, format, flag);
                    }
                    else
                    {
                        num3 = this.method_250("", A_5, font, black, A_3, format, flag);
                    }
                }
                else if (base.method_1())
                {
                    num3 = this.method_252(A_0, A_5, rᝪ, black, A_3, format, flag);
                }
                else
                {
                    num3 = this.method_250(A_0, A_5, font, black, A_3, format, flag);
                }
                this.bool_19 = false;
            }
        }
    }

    private string[] method_235(string A_0, Class198 A_1)
    {
        if (A_1.list_0 == null)
        {
            return new string[] { A_0 };
        }
        string[] strArray2 = new string[A_1.list_0.Count + 1];
        if (A_1.list_0.Count <= 0)
        {
            strArray2[0] = A_0;
            return strArray2;
        }
        int startIndex = 0;
        int index = 0;
        int count = A_1.list_0.Count;
        while (index < count)
        {
            Class216 class2 = A_1.list_0[index];
            if ((class2.method_0() >= (A_0.Length - 1)) || (class2.method_0() == startIndex))
            {
                strArray2[index] = A_0.Substring(startIndex, 1);
                startIndex++;
                strArray2[index + 1] = A_0.Substring(startIndex);
                return strArray2;
            }
            strArray2[index] = A_0.Substring(startIndex, class2.method_0() - startIndex);
            startIndex = class2.method_0();
            if (index == (count - 1))
            {
                strArray2[index + 1] = A_0.Substring(startIndex);
            }
            index++;
        }
        return strArray2;
    }

    private bool method_236(Color A_0)
    {
        return (((A_0.A == 0xff) && (A_0.B == 0xff)) && ((A_0.R == 0xff) && (A_0.G == 0xff)));
    }

    private void method_237()
    {
    }

    private RectangleF method_238(RectangleF A_0, float A_1, float A_2)
    {
        float x = A_0.X;
        float y = A_0.Y + A_2;
        if (((((double) x) % 0.75) != 0.0) && (Math.Round((double) (((double) x) % 0.75), 2) > 0.02))
        {
            float num3 = x - ((float) Math.Round((double) (((double) x) % 0.75), 2));
            if ((((double) num3) % 0.75) < 0.03)
            {
                x = (float) Math.Round((double) (x - Math.Round((double) (((double) x) % 0.75), 2)), 2);
            }
            else
            {
                x = (float) Math.Round((double) ((x - Math.Round((double) (((double) x) % 0.75), 2)) - 0.75), 2);
            }
        }
        if (((((double) y) % 0.75) != 0.0) && (Math.Round((double) (((double) y) % 0.75), 2) > 0.02))
        {
            float num4 = y - ((float) Math.Round((double) (((double) y) % 0.75), 2));
            if ((((double) num4) % 0.75) < 0.03)
            {
                y = (float) Math.Round((double) (y - Math.Round((double) (((double) y) % 0.75), 2)), 2);
            }
            else
            {
                y = (float) Math.Round((double) ((y - Math.Round((double) (((double) y) % 0.75), 2)) - 0.75), 2);
            }
        }
        A_1 += A_0.X - x;
        return new RectangleF(x, y, A_1, (A_0.Height + A_0.Y) - y);
    }

    private float method_239(DocumentObject A_0)
    {
        TableCell ownerTextBody = (A_0 as ParagraphBase).OwnerParagraph.OwnerTextBody as TableCell;
        float num = 0f;
        if (ownerTextBody.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            num = ownerTextBody.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f;
        }
        float layoutWidth = ownerTextBody.LayoutWidth;
        float num3 = ((float) (((Interface1) ownerTextBody).imethod_0().imethod_0().method_0() + ((Interface1) ownerTextBody).imethod_0().imethod_1().method_0())) - num;
        float num4 = ((float) (((Interface1) ownerTextBody).imethod_0().imethod_0().method_8() + ((Interface1) ownerTextBody).imethod_0().imethod_1().method_8())) - num;
        return ((layoutWidth - num3) - num4);
    }

    internal bool method_240(string A_0)
    {
        bool flag = false;
        if (((A_0 == BookmarkStart.b("ᄰ", 11)) && (this.paragraph_1 != null)) && ((this.paragraph_1.Text == "") && (this.paragraph_1.Items.Count == 0)))
        {
            flag = true;
        }
        return flag;
    }

    internal void method_241(string A_0, CharacterFormat A_1, ParagraphFormat A_2, RectangleF A_3, Class375 A_4, Class198 A_5)
    {
        int num = 0x10;
        if (A_0 != null)
        {
            StringFormat format2;
            A_0 = A_0.Replace('\x001e'.ToString(), BookmarkStart.b("ᬵ", num));
            A_0 = A_0.Replace('\x00ad'.ToString(), BookmarkStart.b("ᬵ", num));
            Class560 class2 = ((Interface11) A_1).imethod_0() as Class560;
            A_5.bool_0 = class2.method_13();
            A_5.float_0 = class2.method_16();
            A_5.float_1 = class2.method_15();
            bool flag = false;
            if (A_5.drawingTextDirection_0 == DrawingTextDirection.RightToLeft)
            {
                flag = true;
            }
            Color foreColor = this.method_351(A_1);
            if ((this.paragraph_1 != null) && this.paragraph_1.IsInCell)
            {
                TableCell owner = this.paragraph_1.Owner as TableCell;
                if ((((owner != null) && (owner.CellFormat.ForeColor != Color.Empty)) && (owner.CellFormat.ForeColor.A > 0)) && ((((owner.CellFormat.BackColor != Color.Empty) && (owner.CellFormat.BackColor.A > 0)) || ((owner.CellFormat.ForeColor != Color.Empty) && (owner.CellFormat.ForeColor.A > 0))) || (owner.TextureStyle != TextureStyle.TextureNone)))
                {
                    foreColor = owner.CellFormat.ForeColor;
                }
            }
            this.method_350(foreColor);
            if ((A_1.TextBackgroundColor != Color.Empty) && A_1.method_72(9))
            {
                if (base.method_1())
                {
                    this.method_126().method_8(A_1.TextBackgroundColor, A_3);
                }
                else
                {
                    SolidBrush brush = this.method_350(A_1.TextBackgroundColor);
                    this.method_151().FillRectangle(brush, A_3.X, A_3.Y, A_3.Width, A_3.Height);
                }
            }
            RectangleF ef = A_3;
            Font font = null;
            StringFormat format = null;
            sprᝪ rᝪ = null;
            if (base.method_1())
            {
                rᝪ = this.method_380(this.textRange_0, A_1, ref ef);
            }
            else
            {
                font = this.method_369(this.textRange_0, A_1, ref ef);
                format = this.method_348(A_1);
            }
            if (class2.method_14())
            {
                A_0 = A_0.ToUpper();
            }
            if (A_4.method_40())
            {
                A_0 = A_0.TrimEnd(new char[] { ' ' });
            }
            string[] strArray = A_0.Split(new char[] { ' ' });
            string str = A_0.Replace('\x0016', ' ');
            if ((A_1.HighlightColor != Color.Empty) && A_1.method_72(20))
            {
                SizeF ef2 = base.method_1() ? this.method_309(str, rᝪ, format) : this.method_316(str, A_1.Font, format);
                if (A_1.IsSmallCaps)
                {
                    ef2 = base.method_1() ? this.method_310(str, rᝪ, format, true) : this.method_317(str, A_1.Font, format, true);
                }
                float introduced61 = Math.Abs(ef2.Width);
                ef2 = new SizeF(introduced61, Math.Abs(ef2.Height));
                if (A_1.CharacterSpacing != 0f)
                {
                    ef2 = this.method_243(ef2, str.Length, A_1.CharacterSpacing);
                }
                if (base.method_1())
                {
                    this.method_126().method_9(A_1.HighlightColor, A_3.X, A_3.Y, ef2.Width + A_4.method_58(), ef2.Height);
                }
                else
                {
                    using (SolidBrush brush2 = new SolidBrush(A_1.HighlightColor))
                    {
                        this.method_151().FillRectangle(brush2, A_3.X, A_3.Y, ef2.Width + A_4.method_58(), ef2.Height);
                    }
                }
            }
            SizeF ef3 = base.method_1() ? this.method_309(str, rᝪ, format) : this.method_316(str, font, format);
            if (class2.method_13())
            {
                ef3 = base.method_1() ? this.method_310(str, rᝪ, format, true) : this.method_317(str, font, format, true);
            }
            float width = Math.Abs(ef3.Width);
            ef3 = new SizeF(width, Math.Abs(ef3.Height));
            if (class2.method_16() != 0f)
            {
                ef3 = this.method_243(ef3, A_0.Length, A_1.CharacterSpacing);
            }
            if ((A_4.method_69().Width >= Convert.ToSingle((float) (ef3.Width + A_4.method_58()))) && (A_0 != string.Empty))
            {
                float num2 = A_4.method_69().Width - Convert.ToSingle((float) (ef3.Width + A_4.method_58()));
                A_4.method_59(A_4.method_58() + num2);
                A_4.method_63((A_4.method_50() != 0) ? Convert.ToSingle((float) (A_4.method_58() / ((float) A_4.method_50()))) : 0f);
            }
            format2 = new StringFormat(StringFormat.GenericTypographic) {
                FormatFlags = format2.FormatFlags | StringFormatFlags.NoClip
            };
            string str2 = A_0.Replace(this.string_2, string.Empty).Replace('\x0016', ' ');
            if (strArray.Length != (A_4.method_50() + 1))
            {
                string str3 = string.Empty;
                string str4 = string.Empty;
                int num3 = 0;
                int num4 = 0;
                bool flag2 = false;
                bool flag3 = false;
                if (A_0.StartsWith(BookmarkStart.b("ᘵ", num)))
                {
                    foreach (char ch3 in A_0)
                    {
                        if (!this.method_328(ch3))
                        {
                            break;
                        }
                        str3 = str3 + this.string_2;
                        num3++;
                    }
                    flag2 = true;
                }
                if (A_0.EndsWith(BookmarkStart.b("ᘵ", num)))
                {
                    for (int i = A_0.Length - 1; i > 0; i--)
                    {
                        if (!this.method_328(A_0[i]))
                        {
                            break;
                        }
                        str4 = str4 + this.string_2;
                        num4++;
                    }
                    flag3 = true;
                }
                if ((strArray.Length - num3) == (A_4.method_50() + 1))
                {
                    str2 = str3 + A_0.Replace(BookmarkStart.b("ᘵ", num), string.Empty);
                }
                else if (((strArray.Length - num3) - num4) == (A_4.method_50() + 1))
                {
                    str2 = str3 + A_0.Replace(BookmarkStart.b("ᘵ", num), string.Empty) + str4;
                }
                else if ((strArray.Length - num4) == (A_4.method_50() + 1))
                {
                    str2 = A_0.Replace(BookmarkStart.b("ᘵ", num), string.Empty) + str4;
                }
                strArray = A_0.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray.Length > 0)
                {
                    if (flag2)
                    {
                        strArray[0] = str3 + strArray[0];
                    }
                    if (flag3)
                    {
                        strArray[strArray.Length - 1] = strArray[strArray.Length - 1] + str4;
                    }
                }
            }
            float num7 = ef3.Width;
            SizeF ef6 = base.method_1() ? this.method_309(str2, rᝪ, format) : this.method_316(str2, font, format);
            if (A_1.IsSmallCaps)
            {
                ef6 = base.method_1() ? (ef6 = this.method_310(str2, rᝪ, format, true)) : (ef6 = this.method_317(str2, font, format, true));
            }
            if (A_1.CharacterSpacing != 0f)
            {
                ef6 = this.method_243(ef6, str2.Length, A_1.CharacterSpacing);
            }
            float num8 = Math.Abs(ef6.Width);
            if ((strArray.Length > 1) && (A_4.method_50() == 0))
            {
                A_4.method_51(strArray.Length);
            }
            float num9 = (A_4.method_50() == 0) ? 0f : ((num7 - num8) / ((float) A_4.method_50()));
            A_4.method_62();
            A_4.method_50();
            A_4.method_50();
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                char ch4 = '\x0016';
                if (strArray[index].Contains(ch4.ToString()))
                {
                    int num1 = strArray[index].Length;
                    char ch5 = '\x0016';
                    int num21 = strArray[index].Replace(ch5.ToString(), string.Empty).Length;
                }
                string str6 = strArray[index].Replace('\x0016', ' ');
                if (A_1.AllCaps)
                {
                    str6 = str6.ToUpper();
                }
                SizeF ef7 = base.method_1() ? this.method_309(str6, rᝪ, format) : this.method_316(str6, font, format);
                if (A_1.IsSmallCaps)
                {
                    ef7 = base.method_1() ? this.method_310(str6, rᝪ, format, true) : this.method_317(str6, font, format, true);
                }
                if ((A_1.CharacterSpacing != 0f) && (str6.Length > 1))
                {
                    ef7 = this.method_243(ef7, str6.Length, A_1.CharacterSpacing);
                }
                float num12 = ef7.Width;
                if (flag)
                {
                    A_3.X += num12;
                }
                if (((index == (strArray.Length - 1)) && !flag) && ((strArray.Length > 1) && ((A_3.X + num12) < A_4.method_69().Right)))
                {
                    float num13 = A_4.method_69().Right - (A_3.X + num12);
                    A_3.X += num13;
                }
                if (this.method_407(str6))
                {
                    if (A_1.Emboss)
                    {
                        if (base.method_1())
                        {
                            this.method_251(str6, A_5, rᝪ, Color.Gray, new RectangleF(A_3.X + 0.2f, A_3.Y + 0.2f, A_3.Width, A_3.Height), format);
                        }
                        else
                        {
                            this.method_249(str6, A_5, font, Color.Gray, new RectangleF(A_3.X + 0.2f, A_3.Y + 0.2f, A_3.Width, A_3.Height), format);
                        }
                    }
                    if (A_1.Engrave)
                    {
                        if (base.method_1())
                        {
                            this.method_251(str6, A_5, rᝪ, Color.Gray, new RectangleF(A_3.X - 0.2f, A_3.Y - 0.2f, A_3.Width, A_3.Height), format);
                        }
                        else
                        {
                            this.method_249(str6, A_5, font, Color.Gray, new RectangleF(A_3.X - 0.2f, A_3.Y - 0.2f, A_3.Width, A_3.Height), format);
                        }
                    }
                    if (base.method_1())
                    {
                        this.method_251(str6, A_5, rᝪ, foreColor, A_3, format);
                    }
                    else
                    {
                        this.method_249(str6, A_5, font, foreColor, A_3, format);
                    }
                }
                else
                {
                    float height = A_3.Height;
                    if (this.method_139() && !this.method_141())
                    {
                        height = float.MaxValue;
                    }
                    RectangleF ef9 = new RectangleF(A_3.X, A_3.Y, num12, height);
                    if (A_1.Emboss)
                    {
                        if (base.method_1())
                        {
                            this.method_251(str6, A_5, rᝪ, Color.Gray, new RectangleF(ef9.X + 0.2f, ef9.Y + 0.2f, ef9.Width, ef9.Height), format);
                        }
                        else
                        {
                            this.method_249(str6, A_5, font, Color.Gray, new RectangleF(ef9.X + 0.2f, ef9.Y + 0.2f, ef9.Width, ef9.Height), format);
                        }
                    }
                    if (A_1.Engrave)
                    {
                        if (base.method_1())
                        {
                            this.method_251(str6, A_5, rᝪ, Color.Gray, new RectangleF(ef9.X - 0.2f, ef9.Y - 0.2f, ef9.Width, ef9.Height), format);
                        }
                        else
                        {
                            this.method_249(str6, A_5, font, Color.Gray, new RectangleF(ef9.X - 0.2f, ef9.Y - 0.2f, ef9.Width, ef9.Height), format);
                        }
                    }
                    if (base.method_1())
                    {
                        this.method_251(str6, A_5, rᝪ, foreColor, ef9, format);
                    }
                    else
                    {
                        this.method_249(str6, A_5, font, foreColor, ef9, format);
                    }
                }
                if (!A_4.method_54())
                {
                    if (!flag)
                    {
                        A_3.X += num12;
                    }
                    if ((rᝪ != null) ? ((rᝪ.ᜂ() & FontStyle.Underline) == FontStyle.Underline) : ((font != null) ? font.Underline : false))
                    {
                        if (index < (length - 1))
                        {
                            float num15 = num9;
                            float num16 = num9 + A_4.method_62();
                            float num17 = num16 % num9;
                            int num18 = (int) (num16 / num9);
                            num18 = (num17 > 0f) ? (num18 + 1) : num18;
                            for (int j = 0; j < num18; j++)
                            {
                                if (((j + 1) == num18) && (num17 > 0f))
                                {
                                    num15 = num17;
                                }
                                RectangleF ef10 = new RectangleF(A_3.X, A_3.Y, num15, A_3.Height);
                                if (base.method_1())
                                {
                                    this.method_251(this.string_2, A_5, rᝪ, foreColor, ef10, format);
                                }
                                else
                                {
                                    this.method_249(this.string_2, A_5, font, foreColor, ef10, format);
                                }
                                if (flag)
                                {
                                    A_3.X -= num15;
                                }
                                else
                                {
                                    A_3.X += num15;
                                }
                            }
                        }
                    }
                    else
                    {
                        float num20 = num9 + A_4.method_62();
                        RectangleF ef11 = new RectangleF(A_3.X, A_3.Y, num20, A_3.Height);
                        if (base.method_1())
                        {
                            this.method_251(this.string_2, A_5, rᝪ, foreColor, ef11, format);
                        }
                        else
                        {
                            this.method_249(this.string_2, A_5, font, foreColor, ef11, format);
                        }
                        if (flag)
                        {
                            A_3.X -= num20;
                        }
                        else
                        {
                            A_3.X += num20;
                        }
                    }
                }
                else if (flag)
                {
                    A_3.X = (A_3.X + num12) - num9;
                }
                else
                {
                    A_3.X = (A_3.X + num12) + num9;
                }
                index++;
            }
        }
    }

    private string[] method_242(string[] A_0)
    {
        string[] strArray = new string[0];
        List<string> list = new List<string>();
        if (A_0.Length > 0)
        {
            int index = 0;
            int length = A_0.Length;
            while (index < length)
            {
                string str = A_0[index];
                if ((str.Length == 1) && (str[0] == '\x0016'))
                {
                    if (list.Count > 0)
                    {
                        list[list.Count - 1] = list[list.Count - 1] + this.string_2;
                    }
                    else
                    {
                        list.Add(this.string_2);
                    }
                }
                else
                {
                    list.Add(str.Replace('\x0016', ' '));
                }
                index++;
            }
        }
        strArray = list.ToArray();
        list.Clear();
        list = null;
        return strArray;
    }

    internal SizeF method_243(SizeF A_0, int A_1, float A_2)
    {
        return new SizeF(this.method_244(A_0.Width, A_1, A_2), A_0.Height);
    }

    internal float method_244(float A_0, int A_1, float A_2)
    {
        return (A_0 + (A_2 * A_1));
    }

    private PointF method_245(PointF A_0, PointF A_1, double A_2)
    {
        PointF tf = new PointF();
        double d = (A_2 * 3.1415926535897931) / 180.0;
        double num2 = (((A_0.X - A_1.X) * Math.Cos(d)) + ((A_0.Y - A_1.Y) * Math.Sin(d))) + A_1.X;
        double num3 = (((A_0.Y - A_1.Y) * Math.Cos(d)) - ((A_0.X - A_1.X) * Math.Sin(d))) + A_1.Y;
        tf.X = (float) num2;
        tf.Y = (float) num3;
        return tf;
    }

    private PointF method_246(PointF A_0, float A_1, int A_2)
    {
        PointF tf = A_0;
        if (A_2 == 90)
        {
            return new PointF(A_0.Y, A_1 - A_0.X);
        }
        if (A_2 == 270)
        {
            tf = new PointF(A_1 - A_0.Y, A_0.X);
        }
        return tf;
    }

    private void method_247(Class198 A_0, ref float A_1, ref float A_2)
    {
        switch (A_0.drawingTextDirection_0)
        {
            case DrawingTextDirection.Horizontal:
                A_1 = 0f;
                A_2 = 0f;
                return;

            case DrawingTextDirection.HorizontalEastAsiaRotation:
                A_1 = 270f;
                A_2 = 0f;
                return;

            case ((DrawingTextDirection) 2):
                break;

            case DrawingTextDirection.Vertical:
                A_1 = 0f;
                A_2 = 90f;
                return;

            case DrawingTextDirection.TopToBottom:
                A_1 = 90f;
                A_2 = 90f;
                break;

            case DrawingTextDirection.BottomToTop:
                A_1 = 270f;
                A_2 = 270f;
                return;

            default:
                return;
        }
    }

    private PointF method_248(Class198 A_0, float A_1, float A_2)
    {
        float top = 0f;
        float left = 0f;
        if (!A_0.paddings_0.IsEmpty)
        {
            top = A_0.paddings_0.Top;
            left = A_0.paddings_0.Left;
            float right = A_0.paddings_0.Right;
            float bottom = A_0.paddings_0.Bottom;
        }
        float x = A_1;
        float y = A_2;
        if (!A_0.rectangleF_0.IsEmpty)
        {
            switch (A_0.drawingTextDirection_0)
            {
                case DrawingTextDirection.Vertical:
                case DrawingTextDirection.TopToBottom:
                case DrawingTextDirection.BottomToTop:
                    if ((A_0.horizontalAlignment_0 != HorizontalAlignment.Justify) || (A_0.verticalAlignment_0 != VerticalAlignment.Top))
                    {
                        if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Justify) && (A_0.verticalAlignment_0 == VerticalAlignment.Middle))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Justify) && (A_0.verticalAlignment_0 == VerticalAlignment.Bottom))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Center) && (A_0.verticalAlignment_0 == VerticalAlignment.Top))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            y = A_2 - A_0.rectangleF_0.Y;
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Center) && (A_0.verticalAlignment_0 == VerticalAlignment.Middle))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Center) && (A_0.verticalAlignment_0 == VerticalAlignment.Bottom))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Right) && (A_0.verticalAlignment_0 == VerticalAlignment.Top))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            y = A_2 - A_0.rectangleF_0.Y;
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Right) && (A_0.verticalAlignment_0 == VerticalAlignment.Middle))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Right) && (A_0.verticalAlignment_0 == VerticalAlignment.Bottom))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Left) && (A_0.verticalAlignment_0 == VerticalAlignment.Top))
                        {
                            x = (A_1 - A_0.rectangleF_0.X) + left;
                            y = (A_2 - A_0.rectangleF_0.Y) + top;
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Left) && (A_0.verticalAlignment_0 == VerticalAlignment.Middle))
                        {
                            x = (A_1 - A_0.rectangleF_0.X) + left;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - (Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height)) / 2f);
                            }
                        }
                        else if ((A_0.horizontalAlignment_0 == HorizontalAlignment.Left) && (A_0.verticalAlignment_0 == VerticalAlignment.Bottom))
                        {
                            x = A_1 - A_0.rectangleF_0.X;
                            if (A_0.rectangleF_0.Width > A_0.rectangleF_0.Height)
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) + Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                            else
                            {
                                y = (A_2 - A_0.rectangleF_0.Y) - Math.Abs((float) (A_0.rectangleF_0.Width - A_0.rectangleF_0.Height));
                            }
                        }
                        break;
                    }
                    x = A_1 - A_0.rectangleF_0.X;
                    y = A_2 - A_0.rectangleF_0.Y;
                    break;
            }
        }
        return new PointF(x, y);
    }

    private float method_249(string A_0, Class198 A_1, Font A_2, Color A_3, RectangleF A_4, StringFormat A_5)
    {
        return this.method_250(A_0, A_1, A_2, A_3, A_4, A_5, false);
    }

    private float method_250(string A_0, Class198 A_1, Font A_2, Color A_3, RectangleF A_4, StringFormat A_5, bool A_6)
    {
        float num = 0f;
        float num2 = 0f;
        this.method_247(A_1, ref num, ref num2);
        using (SolidBrush brush = new SolidBrush(A_3))
        {
            if (!base.method_7() && !base.method_5())
            {
                A_0 = (!A_2.Underline || string.IsNullOrEmpty(A_0)) ? A_0 : A_0.Replace(' ', '\x00a0');
            }
            if (base.method_7() || base.method_5())
            {
                A_0 = !string.IsNullOrEmpty(A_0) ? A_0.Replace('\x00a0', ' ') : A_0;
            }
            SizeF ef3 = this.method_318(A_0, A_2, A_5, A_1.float_1);
            if ((A_0.Length == 1) && A_6)
            {
                if (Class203.smethod_2(A_0[0]))
                {
                    ef3.Width /= 2f;
                    A_4.X -= ef3.Width;
                }
                else if (Class203.smethod_3(A_0[0]))
                {
                    ef3.Width /= 2f;
                }
            }
            float x = A_4.X;
            float y = A_4.Y;
            if ((ef3.Width > 0f) && (((A_1.drawingTextDirection_0 != DrawingTextDirection.Horizontal) || (A_1.float_0 != 0f)) || A_1.bool_0))
            {
                foreach (char ch in A_0.ToCharArray())
                {
                    Font font2 = A_2;
                    string str2 = ch.ToString();
                    SizeF ef = this.method_318(str2, font2, A_5, A_1.float_1);
                    PointF tf2 = this.method_246(new PointF(x, y), 0f, 0);
                    if (A_1.bool_0 && ((char.IsLower(ch) || (ch == '\x00a0')) || (ch == ' ')))
                    {
                        ef = this.method_317(str2, font2, A_5, A_1.bool_0);
                        str2 = str2.ToUpper();
                        font2 = this.method_258(A_2);
                        this.method_256(A_2, A_3, new RectangleF(x, y, ef.Width, A_4.Height), A_5);
                        tf2 = this.method_246(new PointF(x, y + ((float) (this.method_339(A_2).method_0() - this.method_339(font2).method_0()))), 0f, 0);
                    }
                    if (this.method_407(str2))
                    {
                        GraphicsState gstate = this.method_151().Save();
                        switch (num2)
                        {
                            case 90f:
                                if (!A_1.rectangleF_0.IsEmpty)
                                {
                                    float dx = A_1.rectangleF_0.X;
                                    float dy = A_1.rectangleF_0.Y;
                                    this.method_151().TranslateTransform(dx, dy);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(0f, -A_1.rectangleF_0.Width);
                                    tf2 = this.method_248(A_1, x, y);
                                }
                                else
                                {
                                    this.method_151().TranslateTransform(0f, 0f);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(0f, -this.sizeF_0.Width);
                                }
                                break;

                            case 270f:
                                if (!A_1.rectangleF_0.IsEmpty)
                                {
                                    float num8 = A_1.rectangleF_0.X;
                                    float num9 = A_1.rectangleF_0.Y;
                                    this.method_151().TranslateTransform(num8, num9);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(-A_1.rectangleF_0.Height, 0f);
                                    tf2 = this.method_248(A_1, x, y);
                                }
                                else
                                {
                                    this.method_151().TranslateTransform(0f, 0f);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(0f, this.sizeF_0.Height);
                                }
                                break;
                        }
                        GraphicsState state6 = this.method_151().Save();
                        if ((num == 270f) && (num2 == 0f))
                        {
                            this.method_151().TranslateTransform(tf2.X, tf2.Y);
                            this.method_151().RotateTransform(num);
                            this.method_151().TranslateTransform(-ef.Width, 0f);
                            if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                            {
                                GraphicsState state7 = this.method_151().Save();
                                this.method_151().TranslateTransform(tf2.X, tf2.Y);
                                this.method_151().ScaleTransform(A_1.float_1, 1f);
                                this.method_151().DrawString(str2, font2, brush, 0f, 0f, A_5);
                                this.method_151().Restore(state7);
                            }
                            else
                            {
                                this.method_151().DrawString(str2, font2, brush, 0f, 0f, A_5);
                            }
                        }
                        else if ((num == 0f) && (num2 == 90f))
                        {
                            this.method_151().TranslateTransform(tf2.X, tf2.Y);
                            this.method_151().RotateTransform(-num2);
                            this.method_151().TranslateTransform(-ef.Height, 0f);
                            if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                            {
                                GraphicsState state5 = this.method_151().Save();
                                this.method_151().TranslateTransform(tf2.X, tf2.Y);
                                this.method_151().ScaleTransform(A_1.float_1, 1f);
                                this.method_151().DrawString(str2, font2, brush, 0f, 0f, A_5);
                                this.method_151().Restore(state5);
                            }
                            else
                            {
                                this.method_151().DrawString(str2, font2, brush, 0f, 0f, A_5);
                            }
                        }
                        else if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                        {
                            GraphicsState state14 = this.method_151().Save();
                            this.method_151().TranslateTransform(tf2.X, tf2.Y);
                            this.method_151().ScaleTransform(A_1.float_1, 1f);
                            this.method_151().DrawString(str2, font2, brush, 0f, 0f, A_5);
                            this.method_151().Restore(state14);
                        }
                        else
                        {
                            this.method_151().DrawString(str2, font2, brush, tf2.X, tf2.Y, A_5);
                        }
                        this.method_151().Restore(state6);
                        this.method_151().Restore(gstate);
                    }
                    else
                    {
                        GraphicsState state10 = this.method_151().Save();
                        switch (num2)
                        {
                            case 90f:
                                if (!A_1.rectangleF_0.IsEmpty)
                                {
                                    float num15 = A_1.rectangleF_0.X;
                                    float num16 = A_1.rectangleF_0.Y;
                                    this.method_151().TranslateTransform(num15, num16);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(0f, -A_1.rectangleF_0.Width);
                                    tf2 = this.method_248(A_1, x, y);
                                }
                                else
                                {
                                    this.method_151().TranslateTransform(0f, 0f);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(0f, -this.sizeF_0.Width);
                                }
                                break;

                            case 270f:
                                if (!A_1.rectangleF_0.IsEmpty)
                                {
                                    float num21 = A_1.rectangleF_0.X;
                                    float num22 = A_1.rectangleF_0.Y;
                                    this.method_151().TranslateTransform(num21, num22);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(-A_1.rectangleF_0.Height, 0f);
                                    tf2 = this.method_248(A_1, x, y);
                                }
                                else
                                {
                                    this.method_151().TranslateTransform(0f, 0f);
                                    this.method_151().RotateTransform(num2);
                                    this.method_151().TranslateTransform(-this.sizeF_0.Height, 0f);
                                }
                                break;
                        }
                        if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                        {
                            GraphicsState state12 = this.method_151().Save();
                            this.method_151().TranslateTransform(tf2.X, tf2.Y);
                            this.method_151().ScaleTransform(A_1.float_1, 1f);
                            this.method_151().DrawString(str2, font2, brush, 0f, 0f, A_5);
                            this.method_151().Restore(state12);
                        }
                        else
                        {
                            this.method_151().DrawString(str2, font2, brush, tf2.X, tf2.Y, A_5);
                        }
                        this.method_151().Restore(state10);
                    }
                    x += ef.Width;
                    if (A_1.float_0 != 0f)
                    {
                        float width = A_1.float_0;
                        this.method_256(A_2, A_3, new RectangleF(x, y, width, A_4.Height), A_5);
                        x += width;
                    }
                }
            }
            else
            {
                if ((ef3.Width < 0f) && this.method_141())
                {
                    x -= ef3.Width;
                }
                Font font = A_2;
                string str = string.Empty;
                SizeF ef2 = ef3;
                PointF tf = this.method_246(new PointF(x, y), 0f, 0);
                str = A_0;
                if (this.method_407(str))
                {
                    GraphicsState state3 = this.method_151().Save();
                    switch (num2)
                    {
                        case 90f:
                            if (!A_1.rectangleF_0.IsEmpty)
                            {
                                float num19 = A_1.rectangleF_0.X;
                                float num20 = A_1.rectangleF_0.Y;
                                this.method_151().TranslateTransform(num19, num20);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(0f, -A_1.rectangleF_0.Width);
                                tf = this.method_248(A_1, x, y);
                            }
                            else
                            {
                                this.method_151().TranslateTransform(0f, 0f);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(0f, -this.sizeF_0.Width);
                            }
                            break;

                        case 270f:
                            if (!A_1.rectangleF_0.IsEmpty)
                            {
                                float num17 = A_1.rectangleF_0.X;
                                float num18 = A_1.rectangleF_0.Y;
                                this.method_151().TranslateTransform(num17, num18);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(-A_1.rectangleF_0.Height, 0f);
                                tf = this.method_248(A_1, x, y);
                            }
                            else
                            {
                                this.method_151().TranslateTransform(0f, 0f);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(0f, this.sizeF_0.Height);
                            }
                            break;
                    }
                    GraphicsState state2 = this.method_151().Save();
                    if ((num == 270f) && (num2 == 0f))
                    {
                        this.method_151().TranslateTransform(tf.X, tf.Y);
                        this.method_151().RotateTransform(num);
                        this.method_151().TranslateTransform(-ef2.Width, 0f);
                        if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                        {
                            GraphicsState state11 = this.method_151().Save();
                            this.method_151().TranslateTransform(tf.X, tf.Y);
                            this.method_151().ScaleTransform(A_1.float_1, 1f);
                            this.method_151().DrawString(str, font, brush, 0f, 0f, A_5);
                            this.method_151().Restore(state11);
                        }
                        else
                        {
                            this.method_151().DrawString(str, font, brush, 0f, 0f, A_5);
                        }
                    }
                    else if ((num == 0f) && (num2 == 90f))
                    {
                        this.method_151().TranslateTransform(tf.X, tf.Y);
                        this.method_151().RotateTransform(-num2);
                        this.method_151().TranslateTransform(-ef2.Height, 0f);
                        if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                        {
                            GraphicsState state = this.method_151().Save();
                            this.method_151().TranslateTransform(tf.X, tf.Y);
                            this.method_151().ScaleTransform(A_1.float_1, 1f);
                            this.method_151().DrawString(str, font, brush, 0f, 0f, A_5);
                            this.method_151().Restore(state);
                        }
                        else
                        {
                            this.method_151().DrawString(str, font, brush, 0f, 0f, A_5);
                        }
                    }
                    else if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                    {
                        GraphicsState state8 = this.method_151().Save();
                        this.method_151().TranslateTransform(tf.X, tf.Y);
                        this.method_151().ScaleTransform(A_1.float_1, 1f);
                        this.method_151().DrawString(str, font, brush, 0f, 0f, A_5);
                        this.method_151().Restore(state8);
                    }
                    else
                    {
                        this.method_151().DrawString(str, font, brush, tf.X, tf.Y, A_5);
                    }
                    this.method_151().Restore(state2);
                    this.method_151().Restore(state3);
                }
                else
                {
                    GraphicsState state9 = this.method_151().Save();
                    switch (num2)
                    {
                        case 90f:
                            if (!A_1.rectangleF_0.IsEmpty)
                            {
                                float num6 = A_1.rectangleF_0.X;
                                float num7 = A_1.rectangleF_0.Y;
                                this.method_151().TranslateTransform(num6, num7);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(0f, -A_1.rectangleF_0.Width);
                                tf = this.method_248(A_1, x, y);
                            }
                            else
                            {
                                this.method_151().TranslateTransform(0f, 0f);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(0f, -this.sizeF_0.Width);
                            }
                            break;

                        case 270f:
                            if (!A_1.rectangleF_0.IsEmpty)
                            {
                                float num13 = A_1.rectangleF_0.X;
                                float num14 = A_1.rectangleF_0.Y;
                                this.method_151().TranslateTransform(num13, num14);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(-A_1.rectangleF_0.Height, 0f);
                                tf = this.method_248(A_1, x, y);
                            }
                            else
                            {
                                this.method_151().TranslateTransform(0f, 0f);
                                this.method_151().RotateTransform(num2);
                                this.method_151().TranslateTransform(-this.sizeF_0.Height, 0f);
                            }
                            break;
                    }
                    if ((A_1.float_1 != 1f) && (A_1.float_1 > 0f))
                    {
                        GraphicsState state13 = this.method_151().Save();
                        this.method_151().TranslateTransform(tf.X, tf.Y);
                        this.method_151().ScaleTransform(A_1.float_1, 1f);
                        this.method_151().DrawString(str, font, brush, 0f, 0f, A_5);
                        this.method_151().Restore(state13);
                    }
                    else
                    {
                        this.method_151().DrawString(str, font, brush, tf.X, tf.Y, A_5);
                    }
                    this.method_151().Restore(state9);
                }
                x += ef2.Width;
            }
            return ef3.Width;
        }
    }

    private float method_251(string A_0, Class198 A_1, sprᝪ A_2, Color A_3, RectangleF A_4, StringFormat A_5)
    {
        return this.method_252(A_0, A_1, A_2, A_3, A_4, A_5, false);
    }

    private float method_252(string A_0, Class198 A_1, sprᝪ A_2, Color A_3, RectangleF A_4, StringFormat A_5, bool A_6)
    {
        float num = 0f;
        float num2 = 0f;
        this.method_247(A_1, ref num, ref num2);
        using (new SolidBrush(A_3))
        {
            SizeF ef = this.method_311(A_0, A_2, A_5, A_1.float_1);
            A_0 = this.method_253(A_0);
            if ((A_0.Length == 1) && A_6)
            {
                if (Class203.smethod_2(A_0[0]))
                {
                    ef.Width /= 2f;
                    A_4.X -= ef.Width;
                }
                else if (Class203.smethod_3(A_0[0]))
                {
                    ef.Width /= 2f;
                }
            }
            float x = A_4.X;
            float y = A_4.Y;
            if ((ef.Width > 0f) && (((A_1.drawingTextDirection_0 != DrawingTextDirection.Horizontal) || (A_1.float_0 != 0f)) || A_1.bool_0))
            {
                foreach (char ch in A_0.ToCharArray())
                {
                    sprᝪ rᝪ2 = A_2;
                    string str2 = ch.ToString();
                    SizeF ef3 = this.method_311(str2, rᝪ2, A_5, A_1.float_1);
                    PointF tf2 = this.method_246(new PointF(x, y), 0f, 0);
                    if (A_1.bool_0 && ((char.IsLower(ch) || (ch == '\x00a0')) || (ch == ' ')))
                    {
                        ef3 = this.method_310(str2, rᝪ2, A_5, A_1.bool_0);
                        str2 = str2.ToUpper();
                        rᝪ2 = this.method_259(A_2);
                        this.method_255(A_2, A_3, new RectangleF(x, y, ef3.Width, A_4.Height), A_5);
                        tf2 = this.method_246(new PointF(x, y + ((float) (this.method_346(A_2).method_0() - this.method_346(rᝪ2).method_0()))), 0f, 0);
                    }
                    if (this.method_407(str2))
                    {
                        if (base.method_1())
                        {
                            spr➂ r➂3 = this.method_254(A_1, x, y, ref tf2, num2);
                            this.method_126().method_11(str2, rᝪ2, A_3, tf2, ef3, r➂3, A_5);
                        }
                    }
                    else if (base.method_1())
                    {
                        spr➂ r➂4 = this.method_254(A_1, x, y, ref tf2, num2);
                        this.method_126().method_11(str2, rᝪ2, A_3, tf2, ef3, r➂4, A_5);
                    }
                    x += ef3.Width;
                    if (A_1.float_0 != 0f)
                    {
                        float width = A_1.float_0;
                        this.method_255(A_2, A_3, new RectangleF(x, y, width, A_4.Height), A_5);
                        x += width;
                    }
                }
            }
            else
            {
                if ((ef.Width < 0f) && this.method_141())
                {
                    x -= ef.Width;
                }
                sprᝪ rᝪ = A_2;
                string str = string.Empty;
                SizeF ef2 = ef;
                PointF tf = this.method_246(new PointF(x, y), 0f, 0);
                str = A_0;
                if (this.method_407(str))
                {
                    if (base.method_1())
                    {
                        spr➂ r➂2 = this.method_254(A_1, x, y, ref tf, num2);
                        this.method_126().method_11(str, rᝪ, A_3, tf, ef2, r➂2, A_5);
                    }
                }
                else if (base.method_1())
                {
                    spr➂ r➂ = this.method_254(A_1, x, y, ref tf, num2);
                    this.method_126().method_11(str, rᝪ, A_3, tf, ef2, r➂, A_5);
                }
                x += ef2.Width;
            }
            return ef.Width;
        }
    }

    private string method_253(string A_0)
    {
        int num = 0x11;
        char[] chArray2 = new char[] { '\x001f' };
        foreach (char ch in chArray2)
        {
            while (A_0.IndexOf(ch) >= 0)
            {
                A_0 = A_0.Remove(A_0.IndexOf(ch), 1);
            }
        }
        A_0 = A_0.Replace(' '.ToString(), BookmarkStart.b("᜶ᤸ", num));
        return A_0;
    }

    private spr➂ method_254(Class198 A_0, float A_1, float A_2, ref PointF A_3, float A_4)
    {
        spr➂ r➂ = null;
        if (A_4 != 0f)
        {
            r➂ = new spr➂();
            if (A_4 == 90f)
            {
                if (!A_0.rectangleF_0.IsEmpty)
                {
                    float x = A_0.rectangleF_0.X;
                    float y = A_0.rectangleF_0.Y;
                    r➂.ᜀ(x, y);
                    r➂.ᜀ(A_4);
                    r➂.ᜀ(0f, -A_0.rectangleF_0.Width);
                    A_3 = this.method_248(A_0, A_1, A_2);
                    return r➂;
                }
                r➂.ᜀ(0f, 0f);
                r➂.ᜀ(A_4);
                r➂.ᜀ(0f, -this.sizeF_0.Width);
                return r➂;
            }
            if (A_4 != 270f)
            {
                return r➂;
            }
            if (!A_0.rectangleF_0.IsEmpty)
            {
                float num = A_0.rectangleF_0.X;
                float num2 = A_0.rectangleF_0.Y;
                r➂.ᜀ(num, num2);
                r➂.ᜀ(A_4);
                r➂.ᜀ(-A_0.rectangleF_0.Height, 0f);
                A_3 = this.method_248(A_0, A_1, A_2);
                return r➂;
            }
            r➂.ᜀ(0f, 0f);
            r➂.ᜀ(A_4);
            r➂.ᜀ(0f, this.sizeF_0.Height);
        }
        return r➂;
    }

    private void method_255(sprᝪ A_0, Color A_1, RectangleF A_2, StringFormat A_3)
    {
        if (base.method_1())
        {
            string str = ((A_0.ᜂ() & FontStyle.Underline) != FontStyle.Regular) ? this.string_3 : this.string_2;
            float width = this.method_309(str, A_0, A_3).Width;
            float num5 = A_2.Width % width;
            int num4 = (int) (A_2.Width / width);
            num4 = (num5 > 0f) ? (num4 + 1) : num4;
            this.method_126().method_4();
            this.method_126().method_6(A_2);
            float x = A_2.X;
            for (int i = 0; i < num4; i++)
            {
                this.method_126().method_12(str, A_0, A_1, x, A_2.Y, A_3);
                x += width;
            }
            this.method_126().method_7();
            this.method_126().method_5();
        }
    }

    private void method_256(Font A_0, Color A_1, RectangleF A_2, StringFormat A_3)
    {
        string str = A_0.Underline ? this.string_3 : this.string_2;
        float width = this.method_316(str, A_0, A_3).Width;
        float num5 = A_2.Width % width;
        int num3 = (int) (A_2.Width / width);
        num3 = (num5 > 0f) ? (num3 + 1) : num3;
        GraphicsState gstate = this.method_151().Save();
        this.method_151().SetClip(A_2);
        using (SolidBrush brush = new SolidBrush(A_1))
        {
            float x = A_2.X;
            for (int i = 0; i < num3; i++)
            {
                this.method_151().DrawString(str, A_0, brush, x, A_2.Y, A_3);
                x += width;
            }
        }
        this.method_151().Restore(gstate);
    }

    private string method_257(byte[] A_0)
    {
        return Encoding.BigEndianUnicode.GetString(A_0);
    }

    private Font method_258(Font A_0)
    {
        string name = A_0.Name;
        float num = (float) Math.Round((double) (A_0.Size * 0.8f), 2);
        FontStyle style = A_0.Style & ~FontStyle.Underline;
        return this.method_364(name, name, num, style);
    }

    private sprᝪ method_259(sprᝪ A_0)
    {
        string str = A_0.ᜀ();
        float num = (float) Math.Round((double) (A_0.ᜑ() * 0.8f), 2);
        FontStyle style = A_0.ᜂ() & ~FontStyle.Underline;
        return this.method_388(str, str, num, style);
    }

    internal void method_260(Paragraph A_0, Class375 A_1)
    {
        if ((A_0 != null) && (A_1 != null))
        {
            this.method_261(A_0, A_0.Format, A_1);
        }
    }

    private void method_261(Paragraph A_0, ParagraphFormat A_1, Class375 A_2)
    {
        if (((A_2.method_74().method_0() == null) || (A_2.method_74().method_0().method_74().method_0() == null)) || (!(A_2.method_74().method_0().method_74().method_0().method_73() is Break) || ((A_2.method_74().method_0().method_74().method_0().method_73() as Break).BreakType == BreakType.LineBreak)))
        {
            ParagraphFormat format = A_0.method_93();
            Section section2 = A_0.method_49();
            bool alignBordersAndEdges = section2.PageSetup.AlignBordersAndEdges;
            GraphicsState gstate = null;
            if (alignBordersAndEdges)
            {
                this.method_288(section2, A_2);
                float x = (this.float_11 == float.MinValue) ? -1f : this.float_11;
                float num14 = (this.float_12 == float.MinValue) ? (this.method_134().Width + 1f) : this.float_12;
                RectangleF ef6 = new RectangleF(x, -1f, num14 - x, this.method_134().Height + 1f);
                if (base.method_1())
                {
                    this.method_126().method_4();
                    this.method_126().method_6(ef6);
                }
                else
                {
                    gstate = this.method_151().Save();
                    this.method_151().SetClip(ef6);
                }
            }
            Borders borders3 = A_1.Borders;
            Borders borders = A_0.ParaStyle.ParagraphFormat.Borders;
            Borders borders4 = null;
            Border border4 = ((borders3.Left.BorderType != BorderStyle.None) || borders3.Left.IsChanged) ? borders3.Left : borders.Left;
            Border border3 = ((borders3.Right.BorderType != BorderStyle.None) || borders3.Right.IsChanged) ? borders3.Right : borders.Right;
            Border border5 = ((borders3.Top.BorderType != BorderStyle.None) || borders3.Top.IsChanged) ? borders3.Top : borders.Top;
            Border border = ((borders3.Bottom.BorderType != BorderStyle.None) || borders3.Bottom.IsChanged) ? borders3.Bottom : borders.Bottom;
            Border border2 = ((borders3.Horizontal.BorderType != BorderStyle.None) || borders3.Horizontal.IsChanged) ? borders3.Horizontal : borders.Horizontal;
            if (((border4.BorderType != BorderStyle.None) || (border3.BorderType != BorderStyle.None)) || (((border5.BorderType != BorderStyle.None) || (border.BorderType != BorderStyle.None)) || (border2.BorderType != BorderStyle.None)))
            {
                RectangleF ef2 = A_2.method_69();
                bool flag2 = true;
                bool flag = true;
                Class372 class2 = A_2.method_73().imethod_0().imethod_0();
                if (((A_2.method_74().Count >= 1) && (A_2.method_74().method_4(0).method_73() is Paragraph)) && (A_2.method_74().method_4(0).method_69().X < ef2.X))
                {
                    float num = ef2.X - A_2.method_74().method_4(0).method_69().X;
                    ef2 = new RectangleF(new PointF(ef2.X - num, ef2.Y), new SizeF(ef2.Width + num, ef2.Height));
                }
                ef2.Width = (ef2.Width - A_1.LeftIndent) - A_1.RightIndent;
                float right = ef2.Right;
                if (A_0.IsInCell)
                {
                    TableCell owner = A_0.Owner as TableCell;
                    TableRow ownerRow = owner.OwnerRow;
                    Table ownerTable = ownerRow.OwnerTable;
                    if (owner != null)
                    {
                        float left = owner.Bounds.Left;
                        float layoutWidth = owner.LayoutWidth;
                        float paddingWidth = 0f;
                        float num12 = ((ownerRow.RowFormat == null) || (ownerRow.RowFormat.CellSpacingEx == -1f)) ? ownerTable.TableFormat.CellSpacingEx : ownerRow.RowFormat.CellSpacingEx;
                        num12 = (num12 > 0f) ? num12 : 0f;
                        if (owner.CellFormat.SamePaddingsAsTable)
                        {
                            if (!ownerRow.RowFormat.Paddings.IsEmpty)
                            {
                                paddingWidth = ownerRow.RowFormat.Paddings.Right;
                            }
                            else if (!ownerTable.TableFormat.Paddings.IsEmpty)
                            {
                                paddingWidth = ownerTable.TableFormat.Paddings.PaddingWidth;
                            }
                            else if ((ownerRow.RowFormat.Paddings.IsEmpty && ownerTable.TableFormat.Paddings.IsEmpty) && (ownerRow.RowFormat.Paddings.IsDefault && ownerTable.TableFormat.Paddings.IsDefault))
                            {
                                paddingWidth = 5.4f;
                            }
                        }
                        else
                        {
                            paddingWidth = owner.CellFormat.Paddings.Right;
                        }
                        right = (((left + layoutWidth) - num12) - paddingWidth) - A_1.RightIndent;
                    }
                }
                else
                {
                    Section section = A_0.method_49();
                    if ((section != null) && (section.Columns.Count <= 1))
                    {
                        float clientWidth = section.PageSetup.ClientWidth;
                        right = (section.PageSetup.PageSize.Width - section.PageSetup.Margins.Right) - A_1.RightIndent;
                    }
                }
                if (Math.Round((double) ef2.Right, 2) != Math.Round((double) right, 2))
                {
                    ef2.Width = right - ef2.X;
                }
                float num20 = this.method_263(A_2);
                if ((Class59.smethod_4(num20, ef2.Top, 0.005f) != 0) && (Class59.smethod_4(ef2.Top + ((float) class2.method_4()), num20, 0.005f) != 0))
                {
                    float num21 = ef2.Y - num20;
                    ef2.Y = num20;
                    ef2.Height += num21;
                }
                if ((A_1.IsFrame && (A_2.method_74().Count > 0)) && (A_2.method_74().method_4(0).method_73() is Paragraph))
                {
                    SizeF size = new SizeF(A_2.method_74().method_4(0).method_69().Right - ef2.X, A_2.method_74().method_4(0).method_69().Height);
                    if (A_1.FrameWidthRule == FrameSizeRule.Exact)
                    {
                        size.Width = A_1.FrameWidthEx;
                    }
                    int num10 = 1;
                    int count = A_2.method_74().Count;
                    while (num10 < count)
                    {
                        RectangleF ef5 = A_2.method_74().method_4(num10).method_69();
                        if (A_1.FrameWidthRule == FrameSizeRule.Auto)
                        {
                            size.Width = Math.Max(size.Width, ef5.Right - ef2.X);
                        }
                        size.Height += ef5.Height;
                        num10++;
                    }
                    if (A_1.LeftIndent != 0f)
                    {
                        size.Width -= A_1.LeftIndent;
                    }
                    if (A_1.RightIndent != 0f)
                    {
                        size.Width -= A_1.RightIndent;
                    }
                    ef2 = new RectangleF(ef2.Location, size);
                }
                if ((A_2.method_73().imethod_0() is Class213) && ((A_2.method_73().imethod_0() as Class213).method_61() != 0f))
                {
                    float num7 = (A_2.method_73().imethod_0() as Class213).method_61();
                    float num8 = ef2.X - num7;
                    ef2.X -= num8;
                    ef2.Width += num8;
                }
                if (border4 != null)
                {
                    float num13 = border4.Space + (1.4f - (border4.LineWidth * 0.6f));
                    ef2.X -= num13;
                    ef2.Width += num13;
                }
                if (border3 != null)
                {
                    float num24 = border3.Space + (1.4f - (border3.LineWidth * 0.6f));
                    ef2.Width += num24;
                }
                IDocumentObject nextSibling = A_0.NextSibling;
                if ((!(nextSibling is Paragraph) && (A_0.Owner is SDTContent)) && (A_0.Owner.Owner is StructureDocumentTag))
                {
                    ICompositeObject obj5 = A_0.Owner.Owner.Owner as ICompositeObject;
                    int index = obj5.ChildObjects.IndexOf(A_0.Owner.Owner);
                    if ((index >= 0) && (index <= (obj5.ChildObjects.Count - 2)))
                    {
                        nextSibling = obj5.ChildObjects[index + 1];
                    }
                    else
                    {
                        nextSibling = null;
                    }
                }
                if (nextSibling is StructureDocumentTag)
                {
                    nextSibling = (nextSibling as StructureDocumentTag).ChildObjects.FirstItem;
                }
                if (nextSibling is Paragraph)
                {
                    Paragraph paragraph = nextSibling as Paragraph;
                    ParagraphFormat format3 = paragraph.method_93();
                    Borders borders2 = !paragraph.Format.Borders.NoBorder ? paragraph.Format.Borders : (((paragraph.ParaStyle == null) || (paragraph.ParaStyle.ParagraphFormat == null)) ? null : paragraph.ParaStyle.ParagraphFormat.Borders);
                    borders4 = !paragraph.Format.Borders.NoBorderEx ? paragraph.Format.Borders : (((paragraph.ParaStyle == null) || (paragraph.ParaStyle.ParagraphFormat == null)) ? null : paragraph.ParaStyle.ParagraphFormat.Borders);
                    if (((((borders2 != null) && !borders2.NoBorder) && (format.method_68(format3) && format.method_69(format3))) && (!paragraph.SectionEndMark || !string.IsNullOrEmpty(paragraph.Text))) && (((borders2.Top.BorderType != BorderStyle.None) && this.method_262(borders2.Top, border)) || (this.method_262(borders2.Bottom, border) && this.method_262(borders2.Top, border5))))
                    {
                        flag2 = false;
                    }
                    if (!flag2 && (!A_1.IsContextualSpacing || (A_0.ParaStyle.Name != paragraph.ParaStyle.Name)))
                    {
                        ef2.Height += A_1.AfterSpacing;
                        ef2.Height += (float) class2.method_12();
                    }
                }
                IDocumentObject previousSibling = A_0.PreviousSibling;
                if ((!(previousSibling is Paragraph) && (A_0.Owner is SDTContent)) && (A_0.Owner.Owner is StructureDocumentTag))
                {
                    ICompositeObject obj4 = A_0.Owner.Owner.Owner as ICompositeObject;
                    int num19 = obj4.ChildObjects.IndexOf(A_0.Owner.Owner);
                    if ((num19 >= 1) && (num19 <= (obj4.ChildObjects.Count - 1)))
                    {
                        previousSibling = obj4.ChildObjects[num19 - 1];
                    }
                    else
                    {
                        previousSibling = null;
                    }
                }
                if (previousSibling is StructureDocumentTag)
                {
                    previousSibling = (previousSibling as StructureDocumentTag).ChildObjects.LastItem;
                }
                if (previousSibling is Paragraph)
                {
                    Paragraph paragraph2 = previousSibling as Paragraph;
                    ParagraphFormat format2 = paragraph2.method_93();
                    Borders borders5 = !paragraph2.Format.Borders.NoBorder ? paragraph2.Format.Borders : (((paragraph2.ParaStyle == null) || (paragraph2.ParaStyle.ParagraphFormat == null)) ? null : paragraph2.ParaStyle.ParagraphFormat.Borders);
                    if ((((borders5 != null) && !borders5.NoBorder) && (format.method_68(format2) && format.method_69(format2))) && (((borders5.Bottom.BorderType != BorderStyle.None) && this.method_262(borders5.Bottom, border5)) || (this.method_262(borders5.Bottom, border) && this.method_262(borders5.Top, border5))))
                    {
                        flag = false;
                    }
                    if (!flag && (!A_1.IsContextualSpacing || (A_0.ParaStyle.Name != paragraph2.ParaStyle.Name)))
                    {
                        ef2.Y -= A_1.BeforeSpacing;
                        ef2.Height += A_1.BeforeSpacing;
                        ef2.Y -= (float) class2.method_4();
                        ef2.Height += (float) class2.method_4();
                    }
                }
                float lineWidth = border4.LineWidth;
                float num6 = border3.LineWidth;
                float num11 = border5.LineWidth;
                float num2 = border.LineWidth;
                float num4 = flag2 ? (ef2.Bottom - num2) : ef2.Bottom;
                float num5 = border2.LineWidth;
                bool flag4 = false;
                if (border4.BorderType != BorderStyle.None)
                {
                    this.method_267(border4, new PointF(ef2.Left - (lineWidth * 0.6f), (ef2.Top + ((lineWidth - num11) / 2f)) - (num11 * 0.6f)), new PointF(ef2.Left - (lineWidth * 0.6f), (num4 - ((lineWidth - num2) / 2f)) + (num2 * 0.6f)));
                }
                if ((border5.BorderType != BorderStyle.None) && flag)
                {
                    this.method_267(border5, new PointF(ef2.Left + ((num11 - lineWidth) / 2f), ef2.Top - (num11 * 0.6f)), new PointF(ef2.Right - ((num11 - num6) / 2f), ef2.Top - (num11 * 0.6f)));
                }
                if (border3.BorderType != BorderStyle.None)
                {
                    if (border3.Shadow)
                    {
                        this.method_268(border3, new PointF((ef2.Right + (num6 * 0.6f)) + num6, ((ef2.Top - ((num6 - num11) / 2f)) - (num11 * 0.6f)) + num11), new PointF((ef2.Right + (num6 * 0.6f)) + num6, ((ef2.Bottom + ((num6 - num2) / 2f)) + (num2 * 0.6f)) + num2), Color.Black);
                    }
                    this.method_267(border3, new PointF(ef2.Right + (num6 * 0.6f), (ef2.Top + ((num6 - num11) / 2f)) - (num11 * 0.6f)), new PointF(ef2.Right + (num6 * 0.6f), (num4 - ((num6 - num2) / 2f)) + (num2 * 0.6f)));
                }
                if ((border.BorderType != BorderStyle.None) && flag2)
                {
                    if (border.Shadow)
                    {
                        this.method_268(border, new PointF((ef2.Left + ((num2 - lineWidth) / 2f)) + lineWidth, (num4 + (num2 * 0.6f)) + num2), new PointF((ef2.Right - ((num2 - num6) / 2f)) + lineWidth, (num4 + (num2 * 0.6f)) + num2), Color.Black);
                    }
                    this.method_267(border, new PointF(ef2.Left + ((num2 - lineWidth) / 2f), num4 + (num2 * 0.6f)), new PointF(ef2.Right - ((num2 - num6) / 2f), num4 + (num2 * 0.6f)));
                    flag4 = true;
                }
                if (((!flag4 && (A_0.NextSibling is Paragraph)) && ((borders4 != null) && !borders4.NoBorderEx)) && (border2.BorderType != BorderStyle.None))
                {
                    this.method_267(border2, new PointF(ef2.Left + ((num2 - lineWidth) / 2f), num4 + (num5 * 0.6f)), new PointF(ef2.Right - ((num2 - num6) / 2f), num4 + (num5 * 0.6f)));
                }
            }
            if (alignBordersAndEdges)
            {
                if (base.method_1())
                {
                    this.method_126().method_7();
                    this.method_126().method_5();
                }
                else if (gstate != null)
                {
                    this.method_151().ResetClip();
                    this.method_151().Restore(gstate);
                }
            }
        }
    }

    private bool method_262(Border A_0, Border A_1)
    {
        return (((A_0.LineWidth == A_1.LineWidth) && (A_0.Color == A_1.Color)) && (A_0.BorderType == A_1.BorderType));
    }

    private float method_263(Class375 A_0)
    {
        int num = 7;
        float top = A_0.method_69().Top;
        if (A_0.method_73() is Paragraph)
        {
            Class375 class2 = A_0;
            A_0 = A_0.method_74().method_4(0);
            if ((A_0.method_64() == BookmarkStart.b("縬弮崰娲䄴䌶尸强", num)) && (Class59.smethod_5((double) A_0.method_69().Width, 0.0, 0.005) <= 0))
            {
                top = A_0.method_69().Bottom;
                int num3 = 1;
                int num5 = class2.method_74().Count;
                while (num3 < num5)
                {
                    Class375 class3 = class2.method_74().method_4(num3);
                    if (!(class3.method_64() == BookmarkStart.b("縬弮崰娲䄴䌶尸强", num)) || (Class59.smethod_5((double) A_0.method_69().Width, 0.0, 0.005) > 0))
                    {
                        A_0 = class3;
                        break;
                    }
                    top = class3.method_69().Bottom;
                    num3++;
                }
            }
            top = ((A_0.method_74().Count <= 0) || !(A_0.method_74().method_4(0).method_73() is Interface19)) ? top : A_0.method_74().method_4(0).method_69().Y;
            int num4 = 0;
            int count = A_0.method_74().Count;
            while (num4 < count)
            {
                Interface1 interface2 = A_0.method_74().method_4(num4).method_73();
                if (((!(interface2 is TextRange) && !(interface2 is Symbol)) && (!(interface2 is Class542) || !((interface2 as Class542).method_2() is TextRange))) && (!(interface2 is DocPicture) || ((interface2 as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)))
                {
                    if ((A_0.method_64() == BookmarkStart.b("縬弮崰娲䄴䌶尸强", num)) && (A_0.method_69().Width <= 0f))
                    {
                        top = A_0.method_69().Bottom;
                    }
                }
                else
                {
                    top = Math.Min(top, A_0.method_74().method_4(num4).method_69().Top);
                }
                num4++;
            }
        }
        return top;
    }

    private void method_264(Borders A_0, Class375 A_1)
    {
        RectangleF ef = A_1.method_69();
        this.method_267(A_0.Left, new PointF(ef.Left, ef.Top), new PointF(ef.Left, ef.Bottom));
        this.method_267(A_0.Top, new PointF(ef.Left, ef.Top), new PointF(ef.Right, ef.Top));
        this.method_267(A_0.Right, new PointF(ef.Right, ef.Top), new PointF(ef.Right, ef.Bottom));
        this.method_267(A_0.Bottom, new PointF(ef.Left, ef.Bottom), new PointF(ef.Right, ef.Bottom));
    }

    private void method_265(Borders A_0, RectangleF A_1)
    {
        this.method_267(A_0.Left, new PointF(A_1.Left, A_1.Top), new PointF(A_1.Left, A_1.Bottom));
        this.method_267(A_0.Top, new PointF(A_1.Left, A_1.Top), new PointF(A_1.Right, A_1.Top));
        this.method_267(A_0.Right, new PointF(A_1.Right, A_1.Top), new PointF(A_1.Right, A_1.Bottom));
        this.method_267(A_0.Bottom, new PointF(A_1.Left, A_1.Bottom), new PointF(A_1.Right, A_1.Bottom));
    }

    internal void method_266(Class375 A_0)
    {
        Color black = Color.Black;
        PointF location = A_0.method_69().Location;
        PointF tf2 = new PointF(A_0.method_69().X, A_0.method_69().Bottom);
        if (base.method_1())
        {
            this.method_126().method_10(new Pen(black, 1f), location, tf2);
        }
        else
        {
            this.method_151().DrawLine(new Pen(black, 1f), location, tf2);
        }
    }

    private void method_267(Border A_0, PointF A_1, PointF A_2)
    {
        if ((A_0.BorderType != BorderStyle.Cleared) && ((((A_0.BorderType == BorderStyle.None) && !A_0.HasNoneStyle) && (A_0.LineWidth > 0f)) || (A_0.BorderType != BorderStyle.None)))
        {
            Pen pen = this.method_393(A_0);
            if (base.method_1())
            {
                this.method_126().method_10(pen, A_1, A_2);
            }
            else
            {
                this.method_151().DrawLine(pen, A_1, A_2);
            }
        }
    }

    private void method_268(Border A_0, PointF A_1, PointF A_2, Color A_3)
    {
        if ((A_0.BorderType != BorderStyle.Cleared) && (((A_0.BorderType == BorderStyle.None) && !A_0.HasNoneStyle) || (A_0.BorderType != BorderStyle.None)))
        {
            Pen pen = this.method_393(A_0);
            pen.Color = A_3;
            if (base.method_1())
            {
                this.method_126().method_10(pen, A_1, A_2);
            }
            else
            {
                this.method_151().DrawLine(pen, A_1, A_2);
            }
        }
    }

    internal void method_269(Color A_0, RectangleF A_1)
    {
        using (Pen pen = new Pen(A_0))
        {
            this.method_151().DrawRectangle(pen, Rectangle.Ceiling(A_1));
        }
    }

    private RectangleF method_270(TableCell A_0, RectangleF A_1)
    {
        RectangleF ef = A_1;
        int cellIndex = A_0.GetCellIndex();
        int rowIndex = A_0.OwnerRow.GetRowIndex();
        TableCell cell = null;
        TableCell cell2 = null;
        Table ownerTable = A_0.OwnerRow.OwnerTable;
        if ((ownerTable != null) && (cellIndex > 0))
        {
            cell = ownerTable.Rows[rowIndex].Cells[cellIndex - 1];
        }
        if ((ownerTable != null) && (rowIndex > 0))
        {
            TableRow row = ownerTable.Rows[rowIndex - 1];
            if (cellIndex < row.Cells.Count)
            {
                cell2 = ownerTable.Rows[rowIndex - 1].Cells[cellIndex];
            }
        }
        if (cell != null)
        {
            Class212 class2 = ((Interface1) cell).imethod_0() as Class212;
            if (class2.method_156())
            {
                float num4 = Class59.smethod_7(class2.method_148() * 0.65f);
                float x = Class59.smethod_7(ef.X + num4);
                float width = Class59.smethod_7(ef.Width - num4);
                ef = new RectangleF(new PointF(x, ef.Y), new SizeF(width, ef.Height));
            }
        }
        if (cell2 != null)
        {
            Class212 class3 = ((Interface1) cell2).imethod_0() as Class212;
            if (class3.method_152())
            {
                float num3 = Class59.smethod_7(class3.method_144() * 0.65f);
                ef = new RectangleF(new PointF(ef.X, Class59.smethod_7(ef.Y + num3)), new SizeF(ef.Width, Class59.smethod_7(ef.Height - num3)));
            }
        }
        return ef;
    }

    private void method_271(Color A_0, RectangleF A_1, TableCell A_2)
    {
        TableCell previousSibling = A_2;
        while (previousSibling != null)
        {
            previousSibling = previousSibling.PreviousSibling as TableCell;
            if ((previousSibling != null) && (previousSibling.CellFormat.HorizontalMerge != CellMerge.Continue))
            {
                break;
            }
        }
        if (previousSibling != null)
        {
            Table ownerTable = previousSibling.OwnerRow.OwnerTable;
            float num5 = ((ownerTable == null) || (ownerTable.TableFormat.CellSpacingEx <= 0f)) ? 0f : (ownerTable.TableFormat.CellSpacingEx * 2f);
            bool flag = (((Interface1) previousSibling).imethod_0() as Class212).method_156();
            float num6 = (((Interface1) previousSibling).imethod_0() as Class212).method_148();
            float num3 = (previousSibling.Bounds.Right + num6) + num5;
            if (flag && (Class59.smethod_4(num3, A_1.Left, 0.001f) != 0))
            {
                float num4 = num3 - A_1.X;
                A_1 = new RectangleF(num3, A_1.Y, A_1.Width - num4, A_1.Height);
            }
        }
        this.method_286(A_0, A_1);
        float width = Math.Max((float) (A_2.CellFormat.Borders.Top.LineWidth / 2f), (float) (A_2.CellFormat.Borders.Bottom.LineWidth / 2f));
        int num2 = (((Interface1) A_2).imethod_0() as Class212).method_132();
        if ((num2 == 0) && (A_2.CellFormat.Borders.Left.BorderType == BorderStyle.Cleared))
        {
            this.method_286(A_0, new RectangleF(A_1.X - width, A_1.Y, width, A_1.Height));
        }
        if ((num2 == (A_2.OwnerRow.Cells.Count - 1)) && (A_2.CellFormat.Borders.Right.BorderType == BorderStyle.Cleared))
        {
            this.method_286(A_0, new RectangleF(A_1.Right, A_1.Y, width, A_1.Height));
        }
    }

    private void method_272(Background A_0, RectangleF A_1)
    {
        switch (A_0.Type)
        {
            case BackgroundType.Gradient:
                this.method_274(A_0.Gradient, A_1);
                return;

            case BackgroundType.Picture:
                this.method_275(A_0, A_1);
                return;

            case BackgroundType.Texture:
                this.method_276(A_0, A_1);
                break;

            case BackgroundType.Color:
                if (A_0.Opacity > 0f)
                {
                    Color color = A_0.Color;
                    int alpha = ((A_0.Opacity <= 0f) || (A_0.Opacity > 1f)) ? color.A : ((int) (color.A * A_0.Opacity));
                    if (alpha != color.A)
                    {
                        color = Color.FromArgb(alpha, color.R, color.G, color.B);
                    }
                    if (!color.IsEmpty && (color.A != 0))
                    {
                        this.method_273(color, A_1);
                        return;
                    }
                }
                break;

            default:
                return;
        }
    }

    private void method_273(Color A_0, RectangleF A_1)
    {
        this.method_286(A_0, A_1);
    }

    private void method_274(BackgroundGradient A_0, RectangleF A_1)
    {
        LinearGradientBrush brush = new LinearGradientBrush(A_1, A_0.Color1, A_0.Color2, LinearGradientMode.Horizontal);
        if (base.method_1())
        {
            this.method_126().method_8(A_0.Color1, A_1);
        }
        else
        {
            this.method_151().FillRectangle(brush, A_1);
        }
    }

    private void method_275(Background A_0, RectangleF A_1)
    {
        if ((A_0 != null) && (A_0.Picture != null))
        {
            if (base.method_1())
            {
                this.method_126().method_15(A_0.Picture, A_1);
            }
            else
            {
                this.method_151().DrawImage(A_0.Picture, A_1);
            }
        }
    }

    private void method_276(Background A_0, RectangleF A_1)
    {
        if ((A_0 != null) && (A_0.Picture != null))
        {
            if (base.method_1())
            {
                this.method_126().method_15(A_0.Picture, A_1);
            }
            else
            {
                using (TextureBrush brush = new TextureBrush(A_0.Picture))
                {
                    this.method_151().FillRectangle(brush, A_1);
                }
            }
        }
    }

    internal bool method_277(TableCell A_0)
    {
        return ((((A_0.Owner != null) && (A_0.Owner.Owner != null)) && ((A_0.Owner.Owner is Table) && (A_0.Owner.Owner as Table).IsTextBox)) && (((A_0.Owner.Owner as Table).TextBoxFormat != null) && ((A_0.Owner.Owner as Table).TextBoxFormat.FillEfects.Picture != null)));
    }

    internal void method_278(TextureStyle A_0, Color A_1, Color A_2, RectangleF A_3)
    {
        int num2 = 10;
        if (A_0.ToString().Contains(BookmarkStart.b("怯圱䘳唵崷吹䠻", 10)))
        {
            float num = float.Parse(A_0.ToString().Replace(BookmarkStart.b("搯圱䰳䈵䴷䠹夻", num2), "").Replace(BookmarkStart.b("怯圱䘳唵崷吹䠻", num2), "").Replace(BookmarkStart.b("怯䘱", num2), BookmarkStart.b("ḯ", num2)));
            Color color = this.method_280(A_1, A_2, num);
            this.method_286(color, A_3);
        }
        else
        {
            this.method_284(A_0, A_1, A_2, A_3);
        }
    }

    internal void method_279(TableCell A_0, RectangleF A_1)
    {
        int num = 0x13;
        if (A_0.TextureStyle.ToString().Contains(BookmarkStart.b("椸帺似尾⑀ⵂㅄ", 0x13)))
        {
            float num2 = float.Parse(A_0.TextureStyle.ToString().Replace(BookmarkStart.b("洸帺䔼䬾㑀ㅂ⁄", num), "").Replace(BookmarkStart.b("椸帺似尾⑀ⵂㅄ", num), "").Replace(BookmarkStart.b("椸伺", num), BookmarkStart.b("᜸", num)));
            this.method_286(this.method_281(A_0, num2), A_1);
        }
        this.method_285(A_0, A_0.CellFormat.ForeColor, A_0.CellFormat.BackColor, A_1);
    }

    private Color method_280(Color A_0, Color A_1, float A_2)
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        red = this.method_282(A_0.R, A_1.R, A_2, A_0.IsEmpty, A_1.IsEmpty);
        green = this.method_282(A_0.G, A_1.G, A_2, A_0.IsEmpty, A_1.IsEmpty);
        blue = this.method_282(A_0.B, A_1.B, A_2, A_0.IsEmpty, A_1.IsEmpty);
        return Color.FromArgb(red, green, blue);
    }

    private Color method_281(TableCell A_0, float A_1)
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        red = this.method_283(A_0.CellFormat.ForeColor.R, A_0.CellFormat.BackColor.R, A_1);
        green = this.method_283(A_0.CellFormat.ForeColor.G, A_0.CellFormat.BackColor.G, A_1);
        blue = this.method_283(A_0.CellFormat.ForeColor.B, A_0.CellFormat.BackColor.B, A_1);
        return Color.FromArgb(red, green, blue);
    }

    private int method_282(int A_0, int A_1, float A_2, bool A_3, bool A_4)
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

    private int method_283(int A_0, int A_1, float A_2)
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

    private void method_284(TextureStyle A_0, Color A_1, Color A_2, RectangleF A_3)
    {
        if (A_1.IsEmpty)
        {
            if (this.class204_0.method_0(A_2))
            {
                A_1 = Color.White;
            }
            else
            {
                A_1 = Color.Black;
            }
        }
        switch (A_0)
        {
            case TextureStyle.TextureDarkHorizontal:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.Horizontal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkVertical:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DarkVertical, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkDiagonalDown:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DarkDownwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkDiagonalUp:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DarkUpwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkCross:
                break;

            case TextureStyle.TextureDarkDiagonalCross:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DiagonalCross, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureHorizontal:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightHorizontal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureVertical:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightVertical, A_1, A_2), A_3);
                break;

            case TextureStyle.TextureDiagonalDown:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightDownwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDiagonalUp:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightUpwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureCross:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.Cross, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDiagonalCross:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DiagonalCross, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureSolid:
                this.method_286(A_1, A_3);
                return;

            default:
                return;
        }
    }

    private void method_285(TableCell A_0, Color A_1, Color A_2, RectangleF A_3)
    {
        if (A_1.IsEmpty)
        {
            if (this.class204_0.method_0(A_2))
            {
                A_1 = Color.White;
            }
            else
            {
                A_1 = Color.Black;
            }
        }
        switch (A_0.TextureStyle)
        {
            case TextureStyle.TextureDarkHorizontal:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.Horizontal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkVertical:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DarkVertical, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkDiagonalDown:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DarkDownwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkDiagonalUp:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DarkUpwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDarkCross:
                break;

            case TextureStyle.TextureDarkDiagonalCross:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DiagonalCross, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureHorizontal:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightHorizontal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureVertical:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightVertical, A_1, A_2), A_3);
                break;

            case TextureStyle.TextureDiagonalDown:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightDownwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDiagonalUp:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.LightUpwardDiagonal, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureCross:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.Cross, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureDiagonalCross:
                this.method_151().FillRectangle(new HatchBrush(HatchStyle.DiagonalCross, A_1, A_2), A_3);
                return;

            case TextureStyle.TextureSolid:
                this.method_286(A_1, A_3);
                return;

            default:
                return;
        }
    }

    private void method_286(Color A_0, RectangleF A_1)
    {
        if (!A_1.IsEmpty)
        {
            if (base.method_1())
            {
                this.method_126().method_8(A_0, A_1);
            }
            else
            {
                using (SolidBrush brush = this.method_350(A_0))
                {
                    this.method_151().FillRectangle(brush, A_1);
                }
            }
        }
    }

    private bool method_287(TableCell A_0, int A_1)
    {
        if (((A_0 != null) && (A_1 >= 0)) && (A_0.CellFormat.VerticalMerge != CellMerge.None))
        {
            int num3 = A_0.method_5();
            Table ownerTable = A_0.OwnerRow.OwnerTable;
            TableRow lastItem = ownerTable.Rows.LastItem as TableRow;
            int num = A_1 + 1;
            int count = ownerTable.Rows.Count;
            while (num < count)
            {
                TableRow row = ownerTable.Rows[num];
                if (num3 >= row.Cells.Count)
                {
                    break;
                }
                TableCell cell = row.Cells[num3];
                if ((cell.CellFormat.VerticalMerge != CellMerge.None) && (row == lastItem))
                {
                    return true;
                }
                num++;
            }
        }
        return false;
    }

    private void method_288(Section A_0, Class375 A_1)
    {
        if ((this.float_11 == float.MinValue) && (this.float_12 == float.MinValue))
        {
            PageSetup pageSetup = A_0.PageSetup;
            RectangleF ef = A_1.method_72().method_3().method_4(0).method_69();
            float space = pageSetup.Borders.Left.Space;
            float num = pageSetup.Borders.Right.Space;
            if (pageSetup.Borders.Left.BorderType != BorderStyle.None)
            {
                this.float_11 = ef.X - space;
            }
            if (pageSetup.Borders.Right.BorderType != BorderStyle.None)
            {
                this.float_12 = (pageSetup.ClientWidth + ef.X) + num;
            }
        }
    }

    private Class375 method_289(Class375 A_0)
    {
        Class375 class2 = A_0.method_71();
        while (!(class2.method_73() is TableRow))
        {
            class2 = class2.method_71();
        }
        return class2;
    }

    private int method_290(TableCell A_0, int A_1, int A_2)
    {
        float num2 = 0f;
        for (int i = 0; i < A_1; i++)
        {
            num2 += A_0.OwnerRow.Cells[i].LayoutWidth;
        }
        float num4 = 0f;
        for (int j = 0; j < A_0.OwnerRow.OwnerTable.Rows[A_2].Cells.Count; j++)
        {
            num4 += A_0.OwnerRow.OwnerTable.Rows[A_2].Cells[j].LayoutWidth;
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

    private bool method_291(TableCell A_0, Form0 A_1, int A_2)
    {
        bool flag = false;
        Borders borders = A_0.CellFormat.Borders;
        if (A_2 > 0)
        {
            if ((borders.Left.BorderType != BorderStyle.None) && (A_0.OwnerRow.Cells[A_2 - 1].CellFormat.Borders.Right.BorderType != BorderStyle.None))
            {
                return (borders.Left.LineWidth < A_0.OwnerRow.Cells[A_2 - 1].CellFormat.Borders.Right.LineWidth);
            }
            if (borders.Left.BorderType == BorderStyle.None)
            {
                return (A_1.method_65().LineWidth < A_0.OwnerRow.Cells[A_2 - 1].CellFormat.Borders.Right.LineWidth);
            }
            if (A_0.OwnerRow.Cells[A_2 - 1].CellFormat.Borders.Right.BorderType == BorderStyle.None)
            {
                flag = borders.Left.LineWidth < A_1.method_65().LineWidth;
            }
        }
        return flag;
    }

    private bool method_292(TableCell A_0, Form0 A_1, int A_2, int A_3, int A_4)
    {
        bool flag = false;
        Borders borders = A_0.CellFormat.Borders;
        if (A_2 < A_3)
        {
            if ((borders.Right.BorderType != BorderStyle.None) && (A_0.OwnerRow.Cells[A_4].CellFormat.Borders.Left.BorderType != BorderStyle.None))
            {
                return (borders.Right.LineWidth <= A_0.OwnerRow.Cells[A_4].CellFormat.Borders.Left.LineWidth);
            }
            if (borders.Right.BorderType == BorderStyle.None)
            {
                return (A_1.method_65().LineWidth <= A_0.OwnerRow.Cells[A_4].CellFormat.Borders.Left.LineWidth);
            }
            if (A_0.OwnerRow.Cells[A_4].CellFormat.Borders.Left.BorderType == BorderStyle.None)
            {
                flag = borders.Right.LineWidth <= A_1.method_65().LineWidth;
            }
        }
        return flag;
    }

    private bool method_293(TableCell A_0, Form0 A_1, int A_2, int A_3, Class375 A_4)
    {
        bool flag = false;
        Borders borders = A_0.CellFormat.Borders;
        if ((!A_4.method_56() && (A_3 > 0)) && (A_2 < A_0.OwnerRow.OwnerTable.Rows[A_3 - 1].Cells.Count))
        {
            if ((borders.Top.BorderType != BorderStyle.None) && (A_0.OwnerRow.OwnerTable.Rows[A_3 - 1].Cells[A_2].CellFormat.Borders.Bottom.BorderType != BorderStyle.None))
            {
                return (borders.Top.LineWidth < A_0.OwnerRow.OwnerTable.Rows[A_3 - 1].Cells[A_2].CellFormat.Borders.Bottom.LineWidth);
            }
            if (borders.Top.BorderType == BorderStyle.None)
            {
                return (A_1.method_66().LineWidth < A_0.OwnerRow.OwnerTable.Rows[A_3 - 1].Cells[A_2].CellFormat.Borders.Bottom.LineWidth);
            }
            if (A_0.OwnerRow.OwnerTable.Rows[A_3 - 1].Cells[A_2].CellFormat.Borders.Bottom.BorderType == BorderStyle.None)
            {
                flag = borders.Top.LineWidth < A_1.method_66().LineWidth;
            }
        }
        return flag;
    }

    private bool method_294(TableCell A_0, Form0 A_1, int A_2, int A_3, int A_4, int A_5)
    {
        bool flag = false;
        Borders borders = A_0.CellFormat.Borders;
        if ((A_3 < A_4) && (A_2 < A_0.OwnerRow.OwnerTable.Rows[A_5].Cells.Count))
        {
            if ((borders.Bottom.BorderType != BorderStyle.None) && (A_0.OwnerRow.OwnerTable.Rows[A_5].Cells[A_2].CellFormat.Borders.Top.BorderType != BorderStyle.None))
            {
                return (borders.Bottom.LineWidth <= A_0.OwnerRow.OwnerTable.Rows[A_5].Cells[A_2].CellFormat.Borders.Top.LineWidth);
            }
            if (borders.Bottom.BorderType == BorderStyle.None)
            {
                return (A_1.method_66().LineWidth <= A_0.OwnerRow.OwnerTable.Rows[A_5].Cells[A_2].CellFormat.Borders.Top.LineWidth);
            }
            if (A_0.OwnerRow.OwnerTable.Rows[A_5].Cells[A_2].CellFormat.Borders.Top.BorderType == BorderStyle.None)
            {
                flag = borders.Bottom.LineWidth <= A_1.method_66().LineWidth;
            }
        }
        return flag;
    }

    internal void method_295(Color A_0, int A_1, int A_2)
    {
        if (base.method_1())
        {
            this.method_126().method_8(A_0, new RectangleF(0f, 0f, (float) A_1, (float) A_2));
        }
        else
        {
            using (SolidBrush brush = new SolidBrush(A_0))
            {
                if (A_0 != Color.White)
                {
                    this.method_151().FillRectangle(brush, new Rectangle(0, 0, A_1, A_2));
                }
                brush.Dispose();
            }
        }
    }

    internal void method_296(Image A_0, PageSetup A_1)
    {
        this.method_151().DrawImage(A_0, 0f, 0f, A_1.PageSize.Width, A_1.PageSize.Height);
    }

    internal void method_297(WatermarkBase A_0, Class500 A_1)
    {
        if (A_0 != null)
        {
            RectangleF ef = new RectangleF(A_1.method_3().method_4(2).method_69().X, A_1.method_3().method_4(2).method_69().Y, A_1.method_28().ClientWidth, A_1.method_3().method_4(1).method_69().Y - A_1.method_3().method_4(2).method_69().Y);
            switch (A_0.Type)
            {
                case WatermarkType.NoWatermark:
                    return;

                case WatermarkType.PictureWatermark:
                    this.method_302(A_0 as PictureWatermark, A_1, ef);
                    return;

                case WatermarkType.TextWatermark:
                    this.method_298(A_0 as TextWatermark, ef);
                    return;
            }
        }
    }

    private void method_298(TextWatermark A_0, RectangleF A_1)
    {
        TextWatermark watermark = A_0;
        float emSize = ((watermark.FontSize == 1f) || ((A_0.ShapeWidthInPixels != -1) && (((int) (((float) A_0.ShapeWidthInPixels) / 20f)) != ((int) A_0.ShapeSize.Width)))) ? this.method_301(A_0) : watermark.FontSize;
        Font font = new Font(watermark.FontName, emSize);
        SizeF size = A_1.Size;
        if (A_0.ShapeWidthInPixels == -1)
        {
            size.Width = A_0.ShapeSize.Width * 0.6934f;
        }
        else
        {
            size.Width = ((float) A_0.ShapeWidthInPixels) / 20f;
        }
        if (A_0.ShapeHeightInPixels == -1)
        {
            size.Height = A_0.ShapeSize.Height * 0.67f;
        }
        else
        {
            size.Height = ((float) A_0.ShapeHeightInPixels) / 20f;
        }
        A_1.X += (A_1.Width - size.Width) / 2f;
        A_1.Y += (A_1.Height - size.Height) / 2f;
        A_1.Height = size.Height;
        A_1.Width = size.Width;
        int width = 0;
        int height = 0;
        using (Bitmap bitmap2 = new Bitmap(1, 1))
        {
            using (Graphics graphics3 = Graphics.FromImage(bitmap2))
            {
                width = (int) graphics3.MeasureString(A_0.Text, font).Width;
                height = (int) graphics3.MeasureString(A_0.Text, font).Height;
                graphics3.Dispose();
            }
            bitmap2.Dispose();
        }
        Bitmap image = new Bitmap(width, height);
        using (Graphics graphics2 = Graphics.FromImage(image))
        {
            graphics2.Clear(Color.White);
            graphics2.SmoothingMode = SmoothingMode.HighQuality;
            graphics2.DrawString(A_0.Text, font, new SolidBrush(A_0.Color), (float) 0f, (float) 0f);
            graphics2.Dispose();
        }
        if (watermark.Semitransparent)
        {
            Bitmap bitmap3 = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap3))
            {
                graphics.Clear(Color.White);
                ColorMatrix newColorMatrix = new ColorMatrix {
                    Matrix33 = 0.5f
                };
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttr);
                graphics.Dispose();
            }
            image = bitmap3;
        }
        if (watermark.Layout == WatermarkLayout.Diagonal)
        {
            if (base.method_1())
            {
                float num6 = A_1.X + (A_1.Width / 2f);
                float num7 = A_1.Y + (A_1.Height / 2f);
                spr➂ r➂ = new spr➂();
                r➂.ᜀ(num6, num7);
                r➂.ᜀ(-45f);
                r➂.ᜀ(-num6, -num7);
                this.method_126().method_16(image, A_1, r➂);
            }
            else
            {
                GraphicsState gstate = this.method_151().Save();
                this.method_151().InterpolationMode = InterpolationMode.HighQualityBicubic;
                float dx = A_1.X + (A_1.Width / 2f);
                float dy = A_1.Y + (A_1.Height / 2f);
                this.method_151().TranslateTransform(dx, dy);
                this.method_151().RotateTransform(-45f);
                this.method_151().TranslateTransform(-dx, -dy);
                this.method_151().DrawImage(image, A_1);
                this.method_151().Restore(gstate);
            }
        }
        else if (base.method_1())
        {
            this.method_126().method_15(image, A_1);
        }
        else
        {
            this.method_151().DrawImage(image, A_1);
        }
        image.Dispose();
    }

    internal void method_299(PageSetup A_0, RectangleF A_1, RectangleF A_2)
    {
        float space = A_0.Borders.Left.Space;
        float num2 = A_0.Borders.Right.Space;
        float num3 = A_0.Borders.Top.Space;
        float num4 = A_0.Borders.Bottom.Space;
        switch (A_0.PageBorderOffsetFrom)
        {
            case PageBorderOffsetFrom.Text:
                if (A_0.Borders.Left.BorderType == BorderStyle.None)
                {
                    goto Label_0202;
                }
                if (!A_0.PageBorderIncludeFooter || !A_0.PageBorderIncludeHeader)
                {
                    if (!A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
                    {
                        this.method_267(A_0.Borders.Left, new PointF(A_1.X - space, A_1.Y - num3), new PointF(A_1.X - space, A_2.Y - num4));
                    }
                    else if (A_0.PageBorderIncludeFooter && !A_0.PageBorderIncludeHeader)
                    {
                        float num11 = (A_1.Height < A_0.Margins.Top) ? A_0.Margins.Top : A_1.Bottom;
                        this.method_267(A_0.Borders.Left, new PointF(A_1.X - space, num11 + num3), new PointF(A_1.X - space, A_2.Bottom + num4));
                    }
                    else
                    {
                        float num6 = (A_1.Bottom < A_0.Margins.Top) ? A_0.Margins.Top : A_1.Bottom;
                        this.method_267(A_0.Borders.Left, new PointF(A_1.X - space, num6 + num3), new PointF(A_1.X - space, A_2.Y - num4));
                    }
                    break;
                }
                this.method_267(A_0.Borders.Left, new PointF(A_1.X - space, A_1.Y - num3), new PointF(A_1.X - space, A_2.Bottom + num4));
                break;

            case PageBorderOffsetFrom.PageEdge:
            {
                Math.Max(A_1.Right, A_2.Right);
                float x = A_0.PageSize.Width - num2;
                Math.Min(num3, A_1.Top);
                Math.Min(space, Math.Min(A_1.Left, A_2.Left));
                Math.Max(A_0.PageSize.Height - num4, A_2.Bottom);
                if (A_0.Borders.Left.BorderType != BorderStyle.None)
                {
                    this.method_267(A_0.Borders.Left, new PointF(space, num3), new PointF(space, A_0.PageSize.Height - num4));
                }
                if (A_0.Borders.Right.BorderType != BorderStyle.None)
                {
                    this.method_267(A_0.Borders.Right, new PointF(x, num3), new PointF(x, A_0.PageSize.Height - num4));
                }
                if (A_0.Borders.Top.BorderType != BorderStyle.None)
                {
                    this.method_267(A_0.Borders.Top, new PointF(space, num3), new PointF(x, num3));
                }
                if (A_0.Borders.Bottom.BorderType != BorderStyle.None)
                {
                    this.method_267(A_0.Borders.Bottom, new PointF(space, A_0.PageSize.Height - num4), new PointF(x, A_0.PageSize.Height - num4));
                    return;
                }
                return;
            }
            default:
                return;
        }
        this.float_11 = A_1.X - space;
    Label_0202:
        if (A_0.Borders.Right.BorderType != BorderStyle.None)
        {
            if (A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Right, new PointF((A_0.ClientWidth + A_1.X) + num2, A_1.Y - num3), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Bottom + num4));
            }
            else if (!A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Right, new PointF((A_0.ClientWidth + A_1.X) + num2, A_1.Y - num3), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Y - num4));
            }
            else if (A_0.PageBorderIncludeFooter && !A_0.PageBorderIncludeHeader)
            {
                float num9 = (A_1.Height < A_0.Margins.Top) ? A_0.Margins.Top : A_1.Bottom;
                this.method_267(A_0.Borders.Right, new PointF((A_0.ClientWidth + A_1.X) + num2, num9 + num3), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Bottom + num4));
            }
            else
            {
                float num10 = (A_1.Bottom < A_0.Margins.Top) ? A_0.Margins.Top : A_1.Bottom;
                this.method_267(A_0.Borders.Right, new PointF((A_0.ClientWidth + A_1.X) + num2, num10 + num3), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Y - num4));
            }
            this.float_12 = (A_0.ClientWidth + A_1.X) + num2;
        }
        if (A_0.Borders.Top.BorderType != BorderStyle.None)
        {
            if (A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Top, new PointF(A_1.X - space, A_1.Y - num3), new PointF((A_0.ClientWidth + A_1.X) + num2, A_1.Y - num3));
            }
            else if (!A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Top, new PointF(A_1.X - space, A_1.Y - num3), new PointF((A_0.ClientWidth + A_1.X) + num2, A_1.Y - num3));
            }
            else if (A_0.PageBorderIncludeFooter && !A_0.PageBorderIncludeHeader)
            {
                float num8 = (A_1.Height < A_0.Margins.Top) ? A_0.Margins.Top : A_1.Bottom;
                this.method_267(A_0.Borders.Top, new PointF(A_1.X - space, num8 + num3), new PointF((A_0.ClientWidth + A_1.X) + num2, num8 + num3));
            }
            else
            {
                float num7 = (A_1.Bottom < A_0.Margins.Top) ? A_0.Margins.Top : A_1.Bottom;
                this.method_267(A_0.Borders.Top, new PointF(A_1.X - space, num7 + num3), new PointF((A_0.ClientWidth + A_1.X) + num2, num7 + num3));
            }
        }
        if (A_0.Borders.Bottom.BorderType != BorderStyle.None)
        {
            if (A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Bottom, new PointF(A_1.X - space, A_2.Bottom + num4), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Bottom + num4));
            }
            else if (!A_0.PageBorderIncludeFooter && A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Bottom, new PointF(A_1.X - space, A_2.Y - num4), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Y - num4));
            }
            else if (A_0.PageBorderIncludeFooter && !A_0.PageBorderIncludeHeader)
            {
                this.method_267(A_0.Borders.Bottom, new PointF(A_1.X - space, A_2.Bottom + num4), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Bottom + num4));
            }
            else
            {
                this.method_267(A_0.Borders.Bottom, new PointF(A_1.X - space, A_2.Y - num4), new PointF((A_0.ClientWidth + A_1.X) + num2, A_2.Y - num4));
            }
        }
    }

    internal void method_300(Section A_0, RectangleF A_1)
    {
        if (A_0.PageSetup.PageBorderOffsetFrom == PageBorderOffsetFrom.PageEdge)
        {
            float space = A_0.PageSetup.Borders.Left.Space;
            float num2 = A_0.PageSetup.Borders.Right.Space;
            float y = A_0.PageSetup.Borders.Top.Space;
            float num4 = A_0.PageSetup.Borders.Bottom.Space;
            if (A_0.PageSetup.Borders.Left.BorderType != BorderStyle.None)
            {
                this.method_267(A_0.PageSetup.Borders.Left, new PointF(space, y), new PointF(space, A_0.PageSetup.PageSize.Height - num4));
            }
            if (A_0.PageSetup.Borders.Right.BorderType != BorderStyle.None)
            {
                this.method_267(A_0.PageSetup.Borders.Right, new PointF(A_0.PageSetup.PageSize.Width - num2, y), new PointF(A_0.PageSetup.PageSize.Width - num2, A_0.PageSetup.PageSize.Height - num4));
            }
            if (A_0.PageSetup.Borders.Top.BorderType != BorderStyle.None)
            {
                this.method_267(A_0.PageSetup.Borders.Top, new PointF(space, y), new PointF(A_0.PageSetup.PageSize.Width - num2, y));
            }
            if (A_0.PageSetup.Borders.Bottom.BorderType != BorderStyle.None)
            {
                this.method_267(A_0.PageSetup.Borders.Bottom, new PointF(space, A_0.PageSetup.PageSize.Height - num4), new PointF(A_0.PageSetup.PageSize.Width - num2, A_0.PageSetup.PageSize.Height - num4));
            }
        }
    }

    private float method_301(TextWatermark A_0)
    {
        float num = 5f;
        float num2 = 0f;
        float width = 0f;
        float emSize = 5f;
        num2 = ((float) A_0.ShapeWidthInPixels) / 20f;
        using (Bitmap bitmap = new Bitmap(1, 1))
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                while (width <= num2)
                {
                    Font font = new Font(A_0.FontName, emSize);
                    width = (int) graphics.MeasureString(A_0.Text, font).Width;
                    if (width <= num2)
                    {
                        num = emSize;
                        emSize += 0.5f;
                    }
                }
                graphics.Dispose();
            }
            bitmap.Dispose();
        }
        return num;
    }

    private void method_302(PictureWatermark A_0, Class500 A_1, RectangleF A_2)
    {
        if (A_0.ScalingAuto)
        {
            float num2 = (A_0.Document.LastSection.PageSetup.ClientWidth / A_0.WordPicture.Width) * 100f;
            if (A_0.WordPicture.Width < A_0.WordPicture.Height)
            {
                num2 = (A_0.Document.LastSection.PageSetup.ClientHeight / A_0.WordPicture.Height) * 100f;
            }
            A_0.WordPicture.WidthScale = num2;
            A_0.WordPicture.HeightScale = num2;
            A_0.ScalingAuto = false;
        }
        Bitmap bitmap = new Bitmap(A_0.Picture);
        A_2 = this.method_303(A_0, A_2, A_1);
        A_2.Height = A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f);
        A_2.Width = A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f);
        if (A_0.IsWashout)
        {
            bitmap = this.method_304(bitmap, 0.5f, A_2);
            if (base.method_1())
            {
                this.method_126().method_15(bitmap, A_2);
            }
            else
            {
                this.method_151().DrawImage(bitmap, A_2);
            }
        }
        else if (base.method_1())
        {
            this.method_126().method_15(bitmap, A_2);
        }
        else
        {
            this.method_151().DrawImage(bitmap, A_2);
        }
    }

    private RectangleF method_303(PictureWatermark A_0, RectangleF A_1, Class500 A_2)
    {
        float num;
        if (A_0.WordPicture.TextWrappingStyle == TextWrappingStyle.Inline)
        {
            A_1.X += (A_1.Width / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
            A_1.Y += (A_1.Height / 2f) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
            return A_1;
        }
        PageSetup setup = A_2.method_28();
        switch (A_0.WordPicture.HorizontalOrigin)
        {
            case HorizontalOrigin.Margin:
            case HorizontalOrigin.Column:
                switch (A_0.WordPicture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        A_1.X = setup.Margins.Left + A_0.WordPicture.HorizontalPosition;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Left:
                        A_1.X = setup.Margins.Left;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Center:
                        A_1.X += (A_1.Width / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Right:
                        A_1.X = A_1.Right - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Inside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.X = setup.Margins.Left;
                        }
                        else
                        {
                            A_1.X = A_1.Right - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        }
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Outside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.X = A_1.Right - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        }
                        else
                        {
                            A_1.X = setup.Margins.Left;
                        }
                        goto Label_0893;
                }
                break;

            case HorizontalOrigin.Page:
                switch (A_0.WordPicture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        A_1.X = A_0.WordPicture.HorizontalPosition;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Left:
                        A_1.X = 0f;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Center:
                        A_1.X = (setup.PageSize.Width / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Right:
                        A_1.X = setup.PageSize.Width - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Inside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.X = 0f;
                        }
                        else
                        {
                            A_1.X = setup.PageSize.Width - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        }
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Outside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.X = setup.PageSize.Width - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        }
                        else
                        {
                            A_1.X = 0f;
                        }
                        goto Label_0893;
                }
                break;

            case HorizontalOrigin.Character:
                A_1.X += (A_1.Width / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
                break;

            case HorizontalOrigin.LeftMarginArea:
                switch (A_0.WordPicture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        A_1.X = A_0.WordPicture.HorizontalPosition;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Left:
                        A_1.X = 0f;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Center:
                        A_1.X = (setup.Margins.Left / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Right:
                        A_1.X = setup.Margins.Left - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        goto Label_0893;
                }
                break;

            case HorizontalOrigin.RightMarginArea:
                switch (A_0.WordPicture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        A_1.X = A_1.Right + A_0.WordPicture.HorizontalPosition;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Left:
                        A_1.X = A_1.Right;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Center:
                        A_1.X = A_1.Right + ((setup.Margins.Right / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f));
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Right:
                        A_1.X = setup.PageSize.Width - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        goto Label_0893;
                }
                break;

            case HorizontalOrigin.InnerMarginArea:
                if ((base.method_16() % 2) != 1)
                {
                    switch (A_0.WordPicture.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            A_1.X = A_1.Right + A_0.WordPicture.HorizontalPosition;
                            goto Label_0893;

                        case ShapeHorizontalAlignment.Left:
                            A_1.X = A_1.Right;
                            goto Label_0893;

                        case ShapeHorizontalAlignment.Center:
                            A_1.X = A_1.Right + ((setup.Margins.Right / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f));
                            goto Label_0893;

                        case ShapeHorizontalAlignment.Right:
                            A_1.X = setup.PageSize.Width - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                            goto Label_0893;
                    }
                    break;
                }
                switch (A_0.WordPicture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        A_1.X = A_0.WordPicture.HorizontalPosition;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Left:
                        A_1.X = 0f;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Center:
                        A_1.X = (setup.Margins.Left / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Right:
                        A_1.X = setup.Margins.Left - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        goto Label_0893;
                }
                break;

            case HorizontalOrigin.OuterMarginArea:
                if ((base.method_16() % 2) != 1)
                {
                    switch (A_0.WordPicture.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            A_1.X = A_0.WordPicture.HorizontalPosition;
                            goto Label_0893;

                        case ShapeHorizontalAlignment.Left:
                            A_1.X = 0f;
                            goto Label_0893;

                        case ShapeHorizontalAlignment.Center:
                            A_1.X = (setup.Margins.Left / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f);
                            goto Label_0893;

                        case ShapeHorizontalAlignment.Right:
                            A_1.X = setup.Margins.Left - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                            goto Label_0893;
                    }
                    break;
                }
                switch (A_0.WordPicture.HorizontalAlignment)
                {
                    case ShapeHorizontalAlignment.None:
                        A_1.X = A_1.Right + A_0.WordPicture.HorizontalPosition;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Left:
                        A_1.X = A_1.Right;
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Center:
                        A_1.X = A_1.Right + ((setup.Margins.Right / 2f) - ((A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f)) / 2f));
                        goto Label_0893;

                    case ShapeHorizontalAlignment.Right:
                        A_1.X = setup.PageSize.Width - (A_0.WordPicture.Width * (A_0.WordPicture.WidthScale / 100f));
                        goto Label_0893;
                }
                break;
        }
    Label_0893:
        num = Math.Max(A_2.method_48(), setup.Margins.Top);
        float num2 = Math.Max(A_2.method_49(), setup.Margins.Bottom);
        switch (A_0.WordPicture.VerticalOrigin)
        {
            case VerticalOrigin.Margin:
                switch (A_0.WordPicture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.None:
                        A_1.Y = num + A_0.WordPicture.VerticalPosition;
                        return A_1;

                    case ShapeVerticalAlignment.Top:
                        A_1.Y = num;
                        return A_1;

                    case ShapeVerticalAlignment.Center:
                        A_1.Y = (num / 2f) + (((setup.PageSize.Height - num2) / 2f) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f));
                        return A_1;

                    case ShapeVerticalAlignment.Bottom:
                        A_1.Y = (setup.PageSize.Height - num2) - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Inside:
                        if ((base.method_16() % 2) == 0)
                        {
                            A_1.Y = (setup.PageSize.Height - num2) - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                            return A_1;
                        }
                        A_1.Y = num;
                        return A_1;

                    case ShapeVerticalAlignment.Outside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = (setup.PageSize.Height - num2) - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                            return A_1;
                        }
                        A_1.Y = num;
                        return A_1;
                }
                return A_1;

            case VerticalOrigin.Page:
                switch (A_0.WordPicture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.None:
                        A_1.Y = A_0.WordPicture.VerticalPosition;
                        return A_1;

                    case ShapeVerticalAlignment.Top:
                        A_1.Y = 0f;
                        return A_1;

                    case ShapeVerticalAlignment.Center:
                        A_1.Y = (setup.PageSize.Height / 2f) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
                        return A_1;

                    case ShapeVerticalAlignment.Bottom:
                        A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Inside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = 0f;
                            return A_1;
                        }
                        A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Outside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                            return A_1;
                        }
                        A_1.Y = num;
                        return A_1;
                }
                return A_1;

            case VerticalOrigin.Paragraph:
            case VerticalOrigin.Line:
                A_1.Y += (A_1.Height / 2f) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
                return A_1;

            case VerticalOrigin.TopMarginArea:
                switch (A_0.WordPicture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.None:
                        A_1.Y = A_0.WordPicture.VerticalPosition;
                        return A_1;

                    case ShapeVerticalAlignment.Top:
                        A_1.Y = 0f;
                        return A_1;

                    case ShapeVerticalAlignment.Center:
                        A_1.Y = (num / 2f) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
                        return A_1;

                    case ShapeVerticalAlignment.Bottom:
                        A_1.Y = num - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Inside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = 0f;
                            return A_1;
                        }
                        A_1.Y = num - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Outside:
                        if ((base.method_16() % 2) == 0)
                        {
                            A_1.Y = 0f;
                            return A_1;
                        }
                        A_1.Y = num - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;
                }
                return A_1;

            case VerticalOrigin.BottomMarginArea:
                switch (A_0.WordPicture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.None:
                        A_1.Y = (setup.PageSize.Height - num2) + A_0.WordPicture.VerticalPosition;
                        return A_1;

                    case ShapeVerticalAlignment.Top:
                        A_1.Y = setup.PageSize.Height - num2;
                        return A_1;

                    case ShapeVerticalAlignment.Center:
                        A_1.Y = (setup.PageSize.Height - (num2 / 2f)) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
                        return A_1;

                    case ShapeVerticalAlignment.Bottom:
                        A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Inside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = setup.PageSize.Height - num2;
                            return A_1;
                        }
                        A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Outside:
                        if ((base.method_16() % 2) == 0)
                        {
                            A_1.Y = setup.PageSize.Height - num2;
                            return A_1;
                        }
                        A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;
                }
                return A_1;

            case VerticalOrigin.InnerMarginArea:
            case VerticalOrigin.OuterMarginArea:
                switch (A_0.WordPicture.VerticalAlignment)
                {
                    case ShapeVerticalAlignment.None:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = A_0.WordPicture.VerticalPosition;
                            return A_1;
                        }
                        A_1.Y = (setup.PageSize.Height - num2) + A_0.WordPicture.VerticalPosition;
                        return A_1;

                    case ShapeVerticalAlignment.Top:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = 0f;
                            return A_1;
                        }
                        A_1.Y = setup.PageSize.Height - num2;
                        return A_1;

                    case ShapeVerticalAlignment.Center:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = (num / 2f) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
                            return A_1;
                        }
                        A_1.Y = (setup.PageSize.Height - (num2 / 2f)) - ((A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f)) / 2f);
                        return A_1;

                    case ShapeVerticalAlignment.Bottom:
                        if ((base.method_16() % 2) == 0)
                        {
                            A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                            return A_1;
                        }
                        A_1.Y = num - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Inside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = 0f;
                            return A_1;
                        }
                        A_1.Y = setup.PageSize.Height - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                        return A_1;

                    case ShapeVerticalAlignment.Outside:
                        if ((base.method_16() % 2) == 1)
                        {
                            A_1.Y = num - (A_0.WordPicture.Height * (A_0.WordPicture.HeightScale / 100f));
                            return A_1;
                        }
                        A_1.Y = setup.PageSize.Height - num2;
                        return A_1;
                }
                return A_1;
        }
        return A_1;
    }

    private Bitmap method_304(Bitmap A_0, float A_1, RectangleF A_2)
    {
        float num = 0.85f;
        float num2 = 0.85f;
        float[][] numArray = new float[5][];
        float[] numArray2 = new float[5];
        numArray2[0] = num2;
        numArray[0] = numArray2;
        float[] numArray3 = new float[5];
        numArray3[1] = num2;
        numArray[1] = numArray3;
        float[] numArray4 = new float[5];
        numArray4[2] = num2;
        numArray[2] = numArray4;
        float[] numArray5 = new float[5];
        numArray5[3] = 1f;
        numArray[3] = numArray5;
        float[] numArray6 = new float[5];
        numArray6[0] = num;
        numArray6[1] = num;
        numArray6[2] = num;
        numArray6[4] = 1f;
        numArray[4] = numArray6;
        float[][] newColorMatrix = numArray;
        ColorMatrix matrix = new ColorMatrix(newColorMatrix);
        ImageAttributes imageAttr = new ImageAttributes();
        imageAttr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        Bitmap image = new Bitmap(A_0.Width, A_0.Height);
        Graphics graphics = null;
        using (graphics = Graphics.FromImage(image))
        {
            graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width + 1, A_0.Height + 1), 0, 0, A_0.Width + 1, A_0.Height + 1, GraphicsUnit.Pixel, imageAttr);
        }
        return image;
    }

    internal void method_305(CheckBoxFormField A_0, Class375 A_1)
    {
        Pen pen = new Pen(this.method_351(A_0.CharacterFormat)) {
            Width = 0.6f
        };
        RectangleF ef = new RectangleF(A_1.method_69().X + pen.Width, A_1.method_69().Y + pen.Width, A_1.method_69().Width - (2f * pen.Width), A_1.method_69().Height - (2f * pen.Width));
        if (base.method_1())
        {
            PointF tf = new PointF(ef.X, ef.Y);
            PointF tf2 = new PointF(ef.Right, ef.Y);
            this.method_126().method_10(pen, tf, tf2);
            tf = new PointF(ef.Right, ef.Y);
            tf2 = new PointF(ef.Right, ef.Bottom);
            this.method_126().method_10(pen, tf, tf2);
            tf = new PointF(ef.Right, ef.Bottom);
            tf2 = new PointF(ef.X, ef.Bottom);
            this.method_126().method_10(pen, tf, tf2);
            tf = new PointF(ef.X, ef.Bottom);
            tf2 = new PointF(ef.X, ef.Y);
            this.method_126().method_10(pen, tf, tf2);
            if (A_0.Checked)
            {
                tf = new PointF(ef.X, ef.Y);
                tf2 = new PointF(ef.Right, ef.Bottom);
                this.method_126().method_10(pen, tf, tf2);
                tf = new PointF(ef.Right, ef.Top);
                tf2 = new PointF(ef.Left, ef.Bottom);
                this.method_126().method_10(pen, tf, tf2);
            }
        }
        else
        {
            this.method_151().DrawRectangle(pen, ef.X, ef.Y, ef.Width, ef.Height);
            if (A_0.Checked)
            {
                PointF tf3 = new PointF(ef.X, ef.Y);
                PointF tf4 = new PointF(ef.Right, ef.Bottom);
                this.method_151().DrawLine(pen, tf3, tf4);
                tf3 = new PointF(ef.Right, ef.Top);
                tf4 = new PointF(ef.Left, ef.Bottom);
                this.method_151().DrawLine(pen, tf3, tf4);
            }
        }
    }

    internal SizeF method_306(DocPicture A_0)
    {
        float width = (A_0.Size.Width * A_0.WidthScale) / 100f;
        float num2 = (A_0.Size.Height * A_0.HeightScale) / 100f;
        if ((A_0.LockAspectRatio && (A_0.WidthScale != A_0.HeightScale)) && ((width > 1584f) || (num2 > 1584f)))
        {
            float num4 = Math.Min(A_0.WidthScale, A_0.HeightScale);
            width = (A_0.Size.Width * num4) / 100f;
            num2 = (A_0.Size.Height * num4) / 100f;
        }
        if ((A_0.WidthPercent > 0f) || (A_0.HeightPercent > 0f))
        {
            Section section = A_0.method_2();
            if (section != null)
            {
                float num8 = section.PageSetup.PageSize.Width;
                float height = section.PageSetup.PageSize.Height;
                float clientWidth = section.PageSetup.ClientWidth;
                float clientHeight = section.PageSetup.ClientHeight;
                if (A_0.WidthPercent > 0f)
                {
                    float num6 = 0f;
                    switch (A_0.RelationWidth)
                    {
                        case HorizontalOrigin.Margin:
                            num6 = (clientWidth * A_0.WidthPercent) / 100f;
                            break;

                        case HorizontalOrigin.Page:
                            num6 = (num8 * A_0.WidthPercent) / 100f;
                            break;
                    }
                    if ((num6 != 0f) && (num6 != width))
                    {
                        width = num6;
                    }
                }
                if (A_0.HeightPercent > 0f)
                {
                    float num3 = 0f;
                    switch (A_0.RelationHeight)
                    {
                        case VerticalOrigin.Margin:
                            num3 = (clientHeight * A_0.HeightPercent) / 100f;
                            break;

                        case VerticalOrigin.Page:
                            num3 = (height * A_0.HeightPercent) / 100f;
                            break;
                    }
                    if ((num3 != 0f) && (num3 != num2))
                    {
                        num2 = num3;
                    }
                }
            }
        }
        width = (width > 1584f) ? 1584f : width;
        return new SizeF(width, (num2 > 1584f) ? 1584f : num2);
    }

    private bool method_307(IDocumentObject A_0)
    {
        bool flag = false;
        if (((A_0.PreviousSibling != null) && (A_0.PreviousSibling is FieldMark)) && ((A_0.PreviousSibling.PreviousSibling != null) && (A_0.PreviousSibling.PreviousSibling is DocOleObject)))
        {
            flag = true;
        }
        return flag;
    }

    private double method_308(sprᝪ A_0)
    {
        if (!this.method_124().ContainsKey(A_0))
        {
            this.method_347(A_0);
        }
        Struct1 struct2 = this.method_124()[A_0];
        return struct2.method_11();
    }

    internal SizeF method_309(string A_0, sprᝪ A_1, StringFormat A_2)
    {
        int num = 0;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            return SizeF.Empty;
        }
        A_0 = this.method_253(A_0);
        A_0 = A_0.Replace('\x001e'.ToString(), BookmarkStart.b("ଥ", num));
        A_0 = A_0.Replace('\x00ad'.ToString(), BookmarkStart.b("ଥ", num));
        SizeF ef = A_1.ᜃ(A_0);
        if (Class59.smethod_5((double) ef.Height, (double) A_1.ᜑ(), 0.005) == 0)
        {
            ef.Height = (float) this.method_308(A_1);
        }
        return ef;
    }

    internal SizeF method_310(string A_0, sprᝪ A_1, StringFormat A_2, bool A_3)
    {
        int num = 9;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            return SizeF.Empty;
        }
        SizeF ef2 = new SizeF();
        char ch = '\x001e';
        if (A_0.Contains(ch.ToString()))
        {
            A_0 = A_0.Replace(ch.ToString(), BookmarkStart.b("Ȯ", num));
        }
        if (A_3)
        {
            char[] chArray2 = A_0.ToCharArray();
            ef2 = this.method_309(BookmarkStart.b("༮", num), A_1, A_2);
            foreach (char ch2 in chArray2)
            {
                string str = ch2.ToString();
                sprᝪ rᝪ = A_1;
                if ((char.IsLower(ch2) || (ch2 == ' ')) || (ch2 == '\x00a0'))
                {
                    str = str.ToUpper();
                    rᝪ = this.method_259(A_1);
                }
                SizeF ef = rᝪ.ᜃ(str);
                ef2 = A_1.ᜃ(A_0);
                if (Class59.smethod_5((double) ef.Height, (double) rᝪ.ᜑ(), 0.005) == 0)
                {
                    ef.Height = (float) this.method_308(rᝪ);
                }
                float width = ef2.Width + ef.Width;
                float height = (ef.Height > ef2.Height) ? ef.Height : ef2.Height;
                ef2 = new SizeF(width, height);
            }
            return ef2;
        }
        ef2 = A_1.ᜃ(A_0);
        if (Class59.smethod_5((double) ef2.Height, (double) A_1.ᜑ(), 0.005) == 0)
        {
            ef2.Height = (float) this.method_308(A_1);
        }
        return ef2;
    }

    internal SizeF method_311(string A_0, sprᝪ A_1, StringFormat A_2, float A_3)
    {
        return this.method_312(A_0, A_1, A_2, 0f, A_3);
    }

    internal SizeF method_312(string A_0, sprᝪ A_1, StringFormat A_2, float A_3, float A_4)
    {
        SizeF ef = this.method_309(A_0, A_1, A_2);
        if ((A_4 != 1f) && (A_4 > 0f))
        {
            ef = new SizeF(ef.Width * A_4, ef.Height);
        }
        if (!string.IsNullOrEmpty(A_0) && (A_3 != 0f))
        {
            ef = this.method_243(ef, A_0.Length, A_3);
        }
        return ef;
    }

    internal SizeF method_313(string A_0, sprᝪ A_1, StringFormat A_2, bool A_3, float A_4)
    {
        SizeF ef = this.method_310(A_0, A_1, A_2, A_3);
        if (!string.IsNullOrEmpty(A_0) && (A_4 != 0f))
        {
            ef = this.method_243(ef, A_0.Length, A_4);
        }
        return ef;
    }

    internal SizeF method_314(string A_0, sprᝪ A_1, StringFormat A_2, bool A_3, float A_4, float A_5)
    {
        SizeF ef = this.method_310(A_0, A_1, A_2, A_3);
        if ((A_5 != 1f) && (A_5 > 0f))
        {
            ef = new SizeF(ef.Width * A_5, ef.Height);
        }
        if (!string.IsNullOrEmpty(A_0) && (A_4 != 0f))
        {
            ef = this.method_243(ef, A_0.Length, A_4);
        }
        return ef;
    }

    private double method_315(Font A_0)
    {
        if (!this.method_122().ContainsKey(A_0))
        {
            this.method_339(A_0);
        }
        Struct1 struct2 = this.method_122()[A_0];
        return struct2.method_11();
    }

    internal SizeF method_316(string A_0, Font A_1, StringFormat A_2)
    {
        int num = 3;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            return SizeF.Empty;
        }
        A_0 = A_0.Replace('\x001e'.ToString(), BookmarkStart.b("Ш", num));
        A_0 = A_0.Replace('\x00ad'.ToString(), BookmarkStart.b("Ш", num));
        bool flag = false;
        CharacterRange[] ranges = new CharacterRange[] { new CharacterRange(0, A_0.Length) };
        RectangleF bounds = new RectangleF();
        if (A_2 == null)
        {
            flag = true;
            A_2 = this.method_349();
        }
        A_2.SetMeasurableCharacterRanges(ranges);
        Region[] regionArray = this.method_151().MeasureCharacterRanges(A_0, A_1, new Rectangle(0, 0, 0x7fffffff, 0x7fffffff), A_2);
        bounds = regionArray[0].GetBounds(this.method_151());
        bounds.Width += 2f * bounds.X;
        if (Class59.smethod_5((double) bounds.Height, (double) A_1.Size, 0.005) == 0)
        {
            bounds.Height = (float) this.method_315(A_1);
        }
        if (regionArray != null)
        {
            regionArray[0].Dispose();
            regionArray = null;
        }
        if (flag)
        {
            A_2.Dispose();
            A_2 = null;
        }
        return bounds.Size;
    }

    internal SizeF method_317(string A_0, Font A_1, StringFormat A_2, bool A_3)
    {
        int num = 0x10;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            return SizeF.Empty;
        }
        RectangleF ef2 = new RectangleF();
        char ch2 = '\x001e';
        if (A_0.Contains(ch2.ToString()))
        {
            A_0 = A_0.Replace(ch2.ToString(), BookmarkStart.b("ᬵ", num));
        }
        bool flag = false;
        if (A_2 == null)
        {
            flag = true;
            A_2 = this.method_349();
        }
        if (A_3)
        {
            char[] chArray2 = A_0.ToCharArray();
            ef2 = new RectangleF(ef2.Location, new SizeF(ef2.Width, this.method_316(BookmarkStart.b("ᘵ", num), A_1, A_2).Height));
            foreach (char ch in chArray2)
            {
                string text = ch.ToString();
                Font font = A_1;
                if ((char.IsLower(ch) || (ch == ' ')) || (ch == '\x00a0'))
                {
                    text = text.ToUpper();
                    font = this.method_258(A_1);
                }
                CharacterRange[] ranges = new CharacterRange[] { new CharacterRange(0, text.Length) };
                A_2.SetMeasurableCharacterRanges(ranges);
                Region[] regionArray2 = this.method_151().MeasureCharacterRanges(text, font, new Rectangle(0, 0, 0x7fffffff, 0x7fffffff), A_2);
                RectangleF bounds = regionArray2[0].GetBounds(this.method_151());
                if (Class59.smethod_5((double) bounds.Height, (double) font.Size, 0.005) == 0)
                {
                    bounds.Height = (float) this.method_315(font);
                }
                float width = ef2.Width + bounds.Width;
                float height = (bounds.Height > ef2.Height) ? bounds.Height : ef2.Height;
                ef2 = new RectangleF(ef2.Location, new SizeF(width, height)) {
                    Width = ef2.Width + (2f * bounds.X)
                };
                if (regionArray2 != null)
                {
                    regionArray2[0].Dispose();
                    regionArray2 = null;
                }
            }
        }
        else
        {
            CharacterRange[] rangeArray4 = new CharacterRange[] { new CharacterRange(0, A_0.Length) };
            A_2.SetMeasurableCharacterRanges(rangeArray4);
            Region[] regionArray = this.method_151().MeasureCharacterRanges(A_0, A_1, new Rectangle(0, 0, 0x7fffffff, 0x7fffffff), A_2);
            ef2 = regionArray[0].GetBounds(this.method_151());
            ef2.Width += 2f * ef2.X;
            if (Class59.smethod_5((double) ef2.Height, (double) A_1.Size, 0.005) == 0)
            {
                ef2.Height = (float) this.method_315(A_1);
            }
            if (regionArray != null)
            {
                regionArray[0].Dispose();
                regionArray = null;
            }
        }
        if (flag && (A_2 != null))
        {
            A_2.Dispose();
            A_2 = null;
        }
        return ef2.Size;
    }

    internal SizeF method_318(string A_0, Font A_1, StringFormat A_2, float A_3)
    {
        return this.method_319(A_0, A_1, A_2, 0f, A_3);
    }

    internal SizeF method_319(string A_0, Font A_1, StringFormat A_2, float A_3, float A_4)
    {
        SizeF ef = this.method_316(A_0, A_1, A_2);
        if ((A_4 != 1f) && (A_4 > 0f))
        {
            ef = new SizeF(ef.Width * A_4, ef.Height);
        }
        if (!string.IsNullOrEmpty(A_0) && (A_3 != 0f))
        {
            ef = this.method_243(ef, A_0.Length, A_3);
        }
        return ef;
    }

    internal SizeF method_320(string A_0, Font A_1, StringFormat A_2, bool A_3, float A_4)
    {
        SizeF ef = this.method_317(A_0, A_1, A_2, A_3);
        if (!string.IsNullOrEmpty(A_0) && (A_4 != 0f))
        {
            ef = this.method_243(ef, A_0.Length, A_4);
        }
        return ef;
    }

    internal SizeF method_321(string A_0, Font A_1, StringFormat A_2, bool A_3, float A_4, float A_5)
    {
        SizeF ef = this.method_317(A_0, A_1, A_2, A_3);
        if ((A_5 != 1f) && (A_5 > 0f))
        {
            ef = new SizeF(ef.Width * A_5, ef.Height);
        }
        if (!string.IsNullOrEmpty(A_0) && (A_4 != 0f))
        {
            ef = this.method_243(ef, A_0.Length, A_4);
        }
        return ef;
    }

    internal SizeF method_322(string A_0, CharacterFormat A_1)
    {
        if (A_0 == null)
        {
            return new SizeF();
        }
        if (A_1 == null)
        {
            return new SizeF();
        }
        Class560 class2 = ((Interface11) A_1).imethod_0() as Class560;
        SizeF ef2 = new SizeF();
        StringFormat format = null;
        Font font = null;
        bool flag = false;
        sprᝪ rᝪ = null;
        if (base.method_1())
        {
            rᝪ = this.method_376(A_1);
        }
        else
        {
            font = this.method_365(A_1);
            if (format == null)
            {
                flag = true;
                format = this.method_348(A_1);
            }
        }
        if (class2.method_13())
        {
            ef2 = base.method_1() ? this.method_310(A_0, rᝪ, format, class2.method_13()) : this.method_317(A_0, font, format, class2.method_13());
        }
        else
        {
            if (class2.method_14())
            {
                A_0 = A_0.ToUpper();
            }
            ef2 = base.method_1() ? this.method_309(A_0, rᝪ, format) : this.method_316(A_0, font, format);
        }
        if (flag)
        {
            format.Dispose();
            format = null;
        }
        if (class2.method_12())
        {
            float width = Math.Abs(ef2.Width);
            ef2 = new SizeF(width, ef2.Height);
        }
        if ((class2.method_15() != 1f) && (class2.method_15() > 0f))
        {
            ef2 = new SizeF(ef2.Width * class2.method_15(), ef2.Height);
        }
        if (!string.IsNullOrEmpty(A_0) && (class2.method_16() != 0f))
        {
            ef2 = this.method_243(ef2, A_0.Length, class2.method_16());
        }
        return ef2;
    }

    internal SizeF method_323(TextRange A_0, string A_1)
    {
        int num = 9;
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        CharacterFormat characterFormat = A_0.CharacterFormat;
        if (((A_0.Text.Trim() == string.Empty) && (ownerParagraph != null)) && (ownerParagraph.Text == A_0.Text))
        {
            characterFormat = ownerParagraph.BreakCharacterFormat;
        }
        RectangleF ef3 = this.rectangleF_0;
        Font font = null;
        StringFormat format2 = null;
        SizeF ef = new SizeF();
        Class560 class2 = ((Interface11) characterFormat).imethod_0() as Class560;
        sprᝪ rᝪ = null;
        if (base.method_1())
        {
            rᝪ = this.method_380(A_0, characterFormat, ref ef3);
        }
        else
        {
            font = this.method_369(A_0, characterFormat, ref ef3);
            format2 = this.method_348(characterFormat);
            if (this.method_353(A_0))
            {
                format2 = (A_0.OwnerParagraph.ParaStyle != null) ? this.method_348(A_0.OwnerParagraph.ParaStyle.CharacterFormat) : format2;
            }
        }
        if ((A_1 != null) && class2.method_14())
        {
            ef = base.method_1() ? this.method_309(A_1.ToUpper(), rᝪ, format2) : this.method_316(A_1.ToUpper(), font, format2);
        }
        else if ((A_1 != null) && class2.method_13())
        {
            ef = base.method_1() ? this.method_310(A_1, rᝪ, format2, class2.method_13()) : this.method_317(A_1, font, format2, class2.method_13());
        }
        else
        {
            ef = base.method_1() ? this.method_309(A_1, rᝪ, format2) : this.method_316(A_1, font, format2);
        }
        if ((!base.method_1() && ef.IsEmpty) && !string.IsNullOrEmpty(A_1))
        {
            ef = this.method_151().MeasureString(A_1, font, 0x7fffffff, format2);
        }
        if (class2.method_12())
        {
            float width = Math.Abs(ef.Width);
            ef = new SizeF(width, ef.Height);
        }
        if ((class2.method_15() != 1f) && (class2.method_15() > 0f))
        {
            ef = new SizeF(ef.Width * class2.method_15(), ef.Height);
        }
        if (!string.IsNullOrEmpty(A_1) && (class2.method_16() != 0f))
        {
            ef = this.method_243(ef, A_1.Length, class2.method_16());
        }
        if ((ef.IsEmpty && (A_1 == string.Empty)) && (((A_0.OwnerParagraph != null) && !A_0.OwnerParagraph.IsInCell) || ((A_0.OwnerEmptyParagraph != null) && !A_0.OwnerEmptyParagraph.IsInCell)))
        {
            ef = base.method_1() ? this.method_309(BookmarkStart.b("Į", num), rᝪ, format2) : this.method_316(BookmarkStart.b("Į", num), font, format2);
            ef.Width = 0f;
        }
        if ((ownerParagraph != null) && (ownerParagraph.Format.AutoSpaceDE || ownerParagraph.Format.AutoSpaceDN))
        {
            TextRange nextWidgetSibling = A_0.NextWidgetSibling as TextRange;
            if (((nextWidgetSibling != null) && (((A_0.IsDigitOfEndPos || A_0.IsLetterOfEndPos) && nextWidgetSibling.IsFarEastLetterOfStartPosition) || (A_0.IsFarEastLetterOfEndPosition && (nextWidgetSibling.IsDigitOfStartPos || nextWidgetSibling.IsLetterOfStartPos)))) && (((ownerParagraph.Format.AutoSpaceDE && ownerParagraph.Format.AutoSpaceDN) || ((ownerParagraph.Format.AutoSpaceDE && !ownerParagraph.Format.AutoSpaceDN) && (A_0.IsLetterOfEndPos || nextWidgetSibling.IsLetterOfStartPos))) || ((!ownerParagraph.Format.AutoSpaceDE && ownerParagraph.Format.AutoSpaceDN) && (A_0.IsDigitOfEndPos || nextWidgetSibling.IsDigitOfStartPos))))
            {
                TextRange range2 = nextWidgetSibling.IsFarEastLetterOfStartPosition ? A_0 : nextWidgetSibling;
                float num2 = 0f;
                if (base.method_1())
                {
                    sprᝪ rᝪ2 = this.method_378(range2);
                    num2 = this.method_309(this.string_2, rᝪ2, format2).Width / 2f;
                }
                else
                {
                    Font font2 = this.method_367(range2);
                    num2 = this.method_316(this.string_2, font2, format2).Width / 2f;
                }
                ef.Width += num2;
            }
        }
        if ((A_0.IsBalanceWidthCharOfSingleByteAndDoubleByte && !string.IsNullOrEmpty(A_1)) && (A_0.Text != BookmarkStart.b("☮", num)))
        {
            int num4 = this.method_324(A_0, ref A_1, false);
            if (num4 > 0)
            {
                float num3 = base.method_1() ? (this.method_309(this.string_2, rᝪ, format2).Width * 0.95f) : (this.method_316(this.string_2, font, format2).Width * 0.95f);
                ef.Width += num3 * num4;
            }
        }
        if (format2 != null)
        {
            format2.Dispose();
            format2 = null;
        }
        return ef;
    }

    private int method_324(TextRange A_0, ref string A_1, bool A_2)
    {
        int num = 14;
        if (((!A_0.IsBalanceWidthCharOfSingleByteAndDoubleByte || string.IsNullOrEmpty(A_1)) || ((A_0.CharacterFormat.FontTypeHint == FontTypeHint.EastAsia) && (A_0.CharacterFormat.FontNameAscii == A_0.CharacterFormat.FontNameFarEast))) || ((A_0.OwnerParagraph == null) || (A_0.Text == BookmarkStart.b("㴳", num))))
        {
            return 0;
        }
        if (this.method_325(A_0))
        {
            return 0;
        }
        int num5 = 0;
        StringBuilder builder = new StringBuilder();
        int num6 = 0;
        int length = A_1.Length;
        while (num6 < length)
        {
            char ch = (num6 > 0) ? A_1[num6 - 1] : '\0';
            char ch2 = A_1[num6];
            char ch5 = ((num6 + 1) < length) ? A_1[num6 + 1] : '\0';
            builder.Append(ch2);
            bool flag3 = this.method_327(ch);
            bool flag8 = this.method_327(ch2);
            bool flag5 = this.method_327(ch5);
            bool flag9 = this.method_326(ch2);
            if (flag8 && !flag9)
            {
                bool flag2 = false;
                if (!flag3 && !flag5)
                {
                    if (length == 1)
                    {
                        string text = A_0.OwnerParagraph.Text;
                        int startPos = A_0.StartPos;
                        int num4 = text.Length;
                        char ch3 = (startPos > 0) ? text[startPos - 1] : '\0';
                        char ch4 = ((startPos + 1) < num4) ? text[startPos + 1] : '\0';
                        bool flag6 = this.method_327(ch3);
                        bool flag7 = this.method_327(ch4);
                        bool flag4 = this.method_326(ch3);
                        bool flag = this.method_326(ch4);
                        if ((flag6 || flag7) || (flag4 || flag))
                        {
                            flag2 = true;
                        }
                    }
                }
                else
                {
                    flag2 = true;
                }
                if (flag2)
                {
                    num5++;
                    builder.Append('\x0016');
                }
            }
            num6++;
        }
        if (A_2)
        {
            A_1 = builder.ToString();
        }
        builder.Remove(0, builder.Length);
        builder = null;
        return num5;
    }

    private bool method_325(TextRange A_0)
    {
        int num = 12;
        Font font = null;
        sprᝪ rᝪ = null;
        if (base.method_1())
        {
            rᝪ = this.method_378(A_0);
        }
        else
        {
            font = this.method_367(A_0);
        }
        using (StringFormat format = this.method_348(A_0.CharacterFormat))
        {
            SizeF ef = new SizeF();
            SizeF ef2 = new SizeF();
            SizeF ef3 = new SizeF();
            if (base.method_1())
            {
                ef = this.method_309(BookmarkStart.b("嬱", num), rᝪ, format);
                ef2 = this.method_309(BookmarkStart.b("攱", num), rᝪ, format);
                ef3 = this.method_309(this.string_2, rᝪ, format);
            }
            else
            {
                ef = this.method_316(BookmarkStart.b("嬱", num), font, format);
                ef2 = this.method_316(BookmarkStart.b("攱", num), font, format);
                ef3 = this.method_316(this.string_2, font, format);
            }
            return ((Math.Round((double) ef.Width, 2) == Math.Round((double) ef3.Width, 2)) && (Math.Round((double) ef2.Width, 2) == Math.Round((double) ef3.Width, 2)));
        }
    }

    private bool method_326(char A_0)
    {
        return (Encoding.Default.GetByteCount(A_0.ToString()) == 2);
    }

    private bool method_327(char A_0)
    {
        if ((A_0 != ' ') && (A_0 != '\x00a0'))
        {
            return false;
        }
        return true;
    }

    private bool method_328(char A_0)
    {
        return (A_0 == ' ');
    }

    internal float method_329(TextRange A_0)
    {
        if (base.method_1())
        {
            sprᝪ rᝪ = this.method_376(A_0.CharacterFormat);
            return this.method_343(rᝪ);
        }
        Font font = this.method_365(A_0.CharacterFormat);
        return this.method_332(font);
    }

    internal float method_330(Symbol A_0)
    {
        if (base.method_1())
        {
            return this.method_343(this.method_376(A_0.CharacterFormat));
        }
        return this.method_332(A_0.CharacterFormat.Font);
    }

    internal Struct1 method_331(Footnote A_0)
    {
        if (base.method_1())
        {
            return this.method_346(this.method_376(A_0.MarkerCharacterFormat));
        }
        return this.method_339(this.method_365(A_0.MarkerCharacterFormat));
    }

    private float method_332(Font A_0)
    {
        return (float) this.method_339(A_0).method_0();
    }

    private float method_333(Font A_0)
    {
        return (float) this.method_339(A_0).method_4();
    }

    internal Struct1 method_334(TextRange A_0, bool A_1)
    {
        RectangleF ef = new RectangleF();
        if (base.method_1())
        {
            sprᝪ rᝪ = this.method_381(A_0, A_0.CharacterFormat, ref ef, A_1);
            return this.method_346(rᝪ);
        }
        Font font = this.method_370(A_0, A_0.CharacterFormat, ref ef, A_1);
        return this.method_339(font);
    }

    internal Struct1 method_335(TextRange A_0)
    {
        return this.method_334(A_0, false);
    }

    internal Struct1 method_336(Symbol A_0)
    {
        if (base.method_1())
        {
            return this.method_346(this.method_376(A_0.CharacterFormat));
        }
        return this.method_339(A_0.CharacterFormat.Font);
    }

    internal Struct1 method_337(ShapeObject A_0)
    {
        if (base.method_1())
        {
            return this.method_346(this.method_376(A_0.CharacterFormat));
        }
        return this.method_339(this.method_365(A_0.CharacterFormat));
    }

    internal Struct1 method_338(Paragraph A_0)
    {
        if (base.method_1())
        {
            return this.method_346(this.method_376(A_0.BreakCharacterFormat));
        }
        return this.method_339(this.method_365(A_0.BreakCharacterFormat));
    }

    internal Struct1 method_339(Font A_0)
    {
        if (this.method_122().ContainsKey(A_0))
        {
            return this.method_122()[A_0];
        }
        Struct1 struct2 = new Struct1();
        Class308 class2 = new Class308(A_0.Name, A_0.Size, A_0.Style);
        if (class2 != null)
        {
            if (!this.method_121().ContainsKey(A_0.FontFamily))
            {
                Struct2 struct3 = new Struct2();
                struct3.method_1(class2.method_9());
                struct3.method_3(class2.method_14().ᜄ().ᜀ());
                this.method_121().Add(A_0.FontFamily, struct3);
            }
            if (!this.method_122().ContainsKey(A_0))
            {
                struct2.method_1((double) class2.method_11());
                struct2.method_5((double) class2.method_12());
                struct2.method_12((double) class2.method_10());
                struct2.method_16((double) A_0.Size);
                struct2.method_23(class2.method_9());
                struct2.method_25((double) class2.method_13());
                this.method_122().Add(A_0, struct2);
            }
        }
        return struct2;
    }

    internal float method_340(Font A_0)
    {
        return (float) this.method_339(A_0).method_7();
    }

    internal float method_341(Font A_0)
    {
        return (float) this.method_339(A_0).method_11();
    }

    private Struct2 method_342(Font A_0)
    {
        Struct2 struct2 = new Struct2();
        if (A_0 != null)
        {
            if (this.method_121().ContainsKey(A_0.FontFamily))
            {
                return this.method_121()[A_0.FontFamily];
            }
            Class308 class2 = new Class308(A_0.Name, A_0.Size, A_0.Style);
            if (class2 != null)
            {
                struct2.method_1(class2.method_14().ᜄ().ᜃ());
                struct2.method_3(class2.method_14().ᜄ().ᜀ());
                this.method_121().Add(A_0.FontFamily, struct2);
                if (!this.method_122().ContainsKey(A_0))
                {
                    Struct1 struct3 = new Struct1();
                    struct3.method_1((double) class2.method_11());
                    struct3.method_5((double) class2.method_12());
                    struct3.method_12((double) class2.method_10());
                    struct3.method_16((double) A_0.Size);
                    struct3.method_23(class2.method_9());
                    struct3.method_25((double) class2.method_13());
                    this.method_122().Add(A_0, struct3);
                }
            }
        }
        return struct2;
    }

    private float method_343(sprᝪ A_0)
    {
        return (float) this.method_346(A_0).method_0();
    }

    private float method_344(sprᝪ A_0)
    {
        return (float) this.method_346(A_0).method_4();
    }

    internal float method_345(sprᝪ A_0)
    {
        return (float) this.method_346(A_0).method_7();
    }

    internal Struct1 method_346(sprᝪ A_0)
    {
        if (this.method_124().ContainsKey(A_0))
        {
            return this.method_124()[A_0];
        }
        Struct1 struct2 = new Struct1();
        struct2.method_1((double) A_0.ᜃ());
        struct2.method_5((double) A_0.ᜒ());
        struct2.method_12((double) A_0.ᜏ());
        struct2.method_16((double) A_0.ᜑ());
        struct2.method_23(A_0.ᜊ().᜞());
        struct2.method_25((double) A_0.ᜋ());
        if (!this.method_124().ContainsKey(A_0))
        {
            this.method_124().Add(A_0, struct2);
        }
        return struct2;
    }

    internal float method_347(sprᝪ A_0)
    {
        return (float) this.method_346(A_0).method_11();
    }

    private StringFormat method_348(CharacterFormat A_0)
    {
        StringFormat format;
        format = new StringFormat(StringFormat.GenericTypographic) {
            FormatFlags = format.FormatFlags | StringFormatFlags.MeasureTrailingSpaces,
            FormatFlags = format.FormatFlags | StringFormatFlags.NoClip,
            Trimming = StringTrimming.Word
        };
        if ((A_0 != null) && A_0.Bidi)
        {
            format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
        }
        return format;
    }

    private StringFormat method_349()
    {
        return this.method_348(null);
    }

    private SolidBrush method_350(Color A_0)
    {
        return new SolidBrush(A_0);
    }

    private Color method_351(CharacterFormat A_0)
    {
        int num = 10;
        Color black = Color.Black;
        bool flag = false;
        if (this.method_353(this.textRange_0))
        {
            black = ((this.paragraph_1 == null) || (this.paragraph_1.ParaStyle == null)) ? Color.Black : this.paragraph_1.ParaStyle.CharacterFormat.TextColor;
            flag = black == Color.Empty;
        }
        else if (!A_0.TextColor.IsEmpty && (A_0.TextColor.A > 0))
        {
            black = A_0.TextColor;
        }
        else
        {
            flag = true;
        }
        if ((flag && (this.textRange_0 != null)) && (this.textRange_0.OwnerParagraph != null))
        {
            black = Color.Black;
            if (this.textRange_0.OwnerParagraph.IsInCell)
            {
                CellFormat cellFormat = (this.textRange_0.OwnerParagraph.OwnerTextBody as TableCell).CellFormat;
                if (!cellFormat.BackColor.IsEmpty && this.class204_0.method_0(cellFormat.BackColor))
                {
                    black = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                }
                if (((cellFormat.TextureStyle != TextureStyle.TextureNone) && !cellFormat.TextureStyle.ToString().Contains(BookmarkStart.b("怯圱䘳唵崷吹䠻", num))) && (!cellFormat.ForeColor.IsEmpty && this.class204_0.method_0(cellFormat.ForeColor)))
                {
                    black = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                }
            }
            if (!this.textRange_0.OwnerParagraph.Format.BackColor.IsEmpty && this.class204_0.method_0(this.textRange_0.OwnerParagraph.Format.BackColor))
            {
                black = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
            }
        }
        return black;
    }

    private void method_352(CharacterFormat A_0, string A_1, ref Font A_2)
    {
        if (((A_0.Document != null) && A_0.Document.FontSubstitutionTable.ContainsKey(A_1)) && (A_1 != A_2.Name))
        {
            A_2 = this.method_363(A_0.Document.FontSubstitutionTable[A_1], A_2.Size, A_2.Style, A_0);
        }
    }

    internal bool method_353(TextRange A_0)
    {
        int num = 0x11;
        if ((((A_0 != null) && (A_0.OwnerParagraph != null)) && (A_0.OwnerParagraph.ChildObjects.FirstItem != null)) && ((A_0.OwnerParagraph.ChildObjects.FirstItem is TableOfContent) || (((A_0.OwnerParagraph.ChildObjects.FirstItem is Field) && ((A_0.OwnerParagraph.ChildObjects.FirstItem as Field).Type == FieldType.FieldHyperlink)) && ((new Hyperlink(A_0.OwnerParagraph.ChildObjects.FirstItem as Field).BookmarkName != null) && new Hyperlink(A_0.OwnerParagraph.ChildObjects.FirstItem as Field).BookmarkName.StartsWith(BookmarkStart.b("栶洸吺帼", num))))))
        {
            return true;
        }
        if (((A_0 != null) && (A_0.OwnerParagraph != null)) && A_0.OwnerParagraph.IsTOCPara)
        {
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            int index = ownerParagraph.ChildObjects.IndexOf(A_0);
            for (int i = 0; i < index; i++)
            {
                if ((ownerParagraph.ChildObjects[i] is TableOfContent) || (((ownerParagraph.ChildObjects[i] is Field) && ((ownerParagraph.ChildObjects[i] as Field).Type == FieldType.FieldHyperlink)) && ((new Hyperlink(ownerParagraph.ChildObjects[i] as Field).BookmarkName != null) && new Hyperlink(ownerParagraph.ChildObjects[i] as Field).BookmarkName.StartsWith(BookmarkStart.b("栶洸吺帼", num)))))
                {
                    return true;
                }
            }
        }
        return false;
    }

    internal float method_354(TextRange A_0, CharacterFormat A_1, ref RectangleF A_2)
    {
        float sizeInPoints = A_1.Font.SizeInPoints;
        float top = A_2.Top;
        switch (A_1.SubSuperScript)
        {
            case SubSuperScript.SuperScript:
                A_2.Y = top - (this.method_329(A_0) * 0.1f);
                return (sizeInPoints / 1.5f);

            case SubSuperScript.SubScript:
            {
                int height = A_1.Font.Height;
                A_2.Y = top + (height - (((float) height) / 1.5f));
                return (sizeInPoints / 1.5f);
            }
        }
        return sizeInPoints;
    }

    internal float method_355(SubSuperScript A_0, Font A_1, ref RectangleF A_2)
    {
        return this.method_356(A_0, A_1, ref A_2, false);
    }

    internal float method_356(SubSuperScript A_0, Font A_1, ref RectangleF A_2, bool A_3)
    {
        float sizeInPoints = A_1.SizeInPoints;
        float top = A_2.Top;
        switch (A_0)
        {
            case SubSuperScript.SuperScript:
            {
                float num4 = this.method_340(A_1);
                if (!A_3)
                {
                    sizeInPoints /= 1.5f;
                }
                using (Font font = new Font(A_1.Name, sizeInPoints, A_1.Style))
                {
                    float num3 = this.method_340(font);
                    A_2.Y = top - (num4 - num3);
                    return sizeInPoints;
                }
            }
            case SubSuperScript.SubScript:
                if (!A_3)
                {
                    sizeInPoints /= 1.5f;
                }
                using (Font font2 = new Font(A_1.Name, sizeInPoints, A_1.Style))
                {
                    double num5 = this.method_339(font2).method_4();
                    A_2.Y = top + ((float) num5);
                }
                return sizeInPoints;
        }
        return sizeInPoints;
    }

    internal float method_357(SubSuperScript A_0, sprᝪ A_1, ref RectangleF A_2)
    {
        return this.method_358(A_0, A_1, ref A_2, false);
    }

    internal float method_358(SubSuperScript A_0, sprᝪ A_1, ref RectangleF A_2, bool A_3)
    {
        float num = A_1.ᜑ();
        float top = A_2.Top;
        switch (A_0)
        {
            case SubSuperScript.SuperScript:
            {
                float num3 = this.method_345(A_1);
                if (!A_3)
                {
                    num /= 1.5f;
                }
                sprᝪ rᝪ2 = this.method_389(A_1.ᜀ(), num, A_1.ᜂ());
                float num5 = this.method_345(rᝪ2);
                A_2.Y = top - (num3 - num5);
                return num;
            }
            case SubSuperScript.SubScript:
            {
                if (!A_3)
                {
                    num /= 1.5f;
                }
                sprᝪ rᝪ = this.method_389(A_1.ᜀ(), num, A_1.ᜂ());
                double num4 = this.method_346(rᝪ).method_4();
                A_2.Y = top + ((float) num4);
                return num;
            }
        }
        return num;
    }

    private void method_359(CharacterFormat A_0, ref FontStyle A_1)
    {
        FontStyle fontStyleEx = A_0.FontStyleEx;
        if (((A_1 & FontStyle.Bold) == FontStyle.Bold) && ((fontStyleEx & FontStyle.Bold) != FontStyle.Bold))
        {
            A_1 &= ~FontStyle.Bold;
        }
        if (((A_1 & FontStyle.Italic) == FontStyle.Italic) && ((fontStyleEx & FontStyle.Italic) != FontStyle.Italic))
        {
            A_1 &= ~FontStyle.Italic;
        }
        if (((A_1 & FontStyle.Strikeout) == FontStyle.Strikeout) && ((fontStyleEx & FontStyle.Strikeout) != FontStyle.Strikeout))
        {
            A_1 &= ~FontStyle.Strikeout;
        }
        if (((A_1 & FontStyle.Underline) == FontStyle.Underline) && ((fontStyleEx & FontStyle.Underline) != FontStyle.Underline))
        {
            A_1 &= ~FontStyle.Underline;
        }
        if ((fontStyleEx & FontStyle.Bold) == FontStyle.Bold)
        {
            A_1 |= FontStyle.Bold;
        }
        if ((fontStyleEx & FontStyle.Italic) == FontStyle.Italic)
        {
            A_1 |= FontStyle.Italic;
        }
        if ((fontStyleEx & FontStyle.Strikeout) == FontStyle.Strikeout)
        {
            A_1 |= FontStyle.Strikeout;
        }
        if ((fontStyleEx & FontStyle.Underline) == FontStyle.Underline)
        {
            A_1 |= FontStyle.Underline;
        }
    }

    private string method_360(FontStyle A_0)
    {
        int num = 3;
        FontStyle style = A_0 & ~FontStyle.Underline;
        style &= ~FontStyle.Strikeout;
        string str = string.Empty;
        switch (style)
        {
            case FontStyle.Bold:
                str = BookmarkStart.b("Ԩ䤪䈬䌮唰", num);
                break;

            case FontStyle.Italic:
                str = BookmarkStart.b("Ԩ䈪夬丮崰娲嘴", num);
                break;

            case (FontStyle.Italic | FontStyle.Bold):
                str = BookmarkStart.b("Ԩ䤪䈬䌮唰娲䄴嘶唸刺帼", num);
                break;
        }
        if ((A_0 & FontStyle.Underline) == FontStyle.Underline)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str + BookmarkStart.b("尨䔪䤬䨮䌰弲尴夶尸", num);
            }
            else
            {
                str = str + BookmarkStart.b("Ԩ帪䌬䬮吰䄲头帶圸帺", num);
            }
        }
        if ((A_0 & FontStyle.Strikeout) != FontStyle.Strikeout)
        {
            return str;
        }
        if (!string.IsNullOrEmpty(str))
        {
            return (str + BookmarkStart.b("娨弪弬䘮娰嘲娴䈶䴸", num));
        }
        return (str + BookmarkStart.b("Ԩ堪夬崮堰堲倴堶䰸伺", num));
    }

    private string method_361(FontStyle A_0)
    {
        int num = 0x12;
        if (((A_0 & FontStyle.Bold) == FontStyle.Bold) && ((A_0 & FontStyle.Italic) == FontStyle.Italic))
        {
            return BookmarkStart.b("ᐷ堹医刽␿⭁ぃ❅⑇⍉⽋", num);
        }
        if ((A_0 & FontStyle.Bold) == FontStyle.Bold)
        {
            return BookmarkStart.b("ᐷ堹医刽␿", num);
        }
        if ((A_0 & FontStyle.Italic) == FontStyle.Italic)
        {
            return BookmarkStart.b("ᐷ匹䠻弽ⰿ⭁❃", num);
        }
        return string.Empty;
    }

    private string method_362(string A_0, float A_1, FontStyle A_2)
    {
        int num = 12;
        if (string.IsNullOrEmpty(A_0))
        {
            new ArgumentNullException(BookmarkStart.b("吱嬳堵䰷琹崻匽┿", num));
        }
        return string.Concat(new object[] { A_0.ToLower(), BookmarkStart.b("ḱ", num), A_1, this.method_360(A_2) });
    }

    private Font method_363(string A_0, float A_1, FontStyle A_2, CharacterFormat A_3)
    {
        return this.method_364(A_0, A_0, A_1, A_2);
    }

    private Font method_364(string A_0, string A_1, float A_2, FontStyle A_3)
    {
        int num = 5;
        string key = this.method_362(A_0, A_2, A_3);
        if (this.method_123().ContainsKey(key))
        {
            return this.method_123()[key];
        }
        Font font = Class58.smethod_1(A_0, A_2, A_3);
        string str2 = A_0.ToLower();
        if (((font.Name.ToLower() == BookmarkStart.b("䘪䐬䰮䌰尲䘴堶弸伺ᴼ䰾⁀ⵂ㙄杆㩈⹊㽌♎㝐", num)) || !font.Name.ToLower().Equals(str2)) && (!string.IsNullOrEmpty(A_1) && !A_0.Equals(A_1)))
        {
            font = Class58.smethod_1(A_1, A_2, A_3);
            str2 = A_1.ToLower();
        }
        if (((font.Name.ToLower() == BookmarkStart.b("䘪䐬䰮䌰尲䘴堶弸伺ᴼ䰾⁀ⵂ㙄杆㩈⹊㽌♎㝐", num)) || !font.Name.ToLower().Equals(str2)) && ((base.method_19() != null) && (base.method_19().PrivateFontList.Count > 0)))
        {
            string str3 = !string.IsNullOrEmpty(A_1) ? A_1 : A_0;
            string str4 = str3.ToLower() + this.method_361(A_3);
            if (base.method_19().PrivateFontList.ContainsKey(str4))
            {
                Struct10 struct2 = base.method_19().PrivateFontList[str4];
                font = Class58.smethod_2(struct2.method_4().Families[0], A_2, A_3);
            }
            else if (base.method_19().PrivateFontList.ContainsKey(str3.ToLower()))
            {
                Struct10 struct3 = base.method_19().PrivateFontList[str3.ToLower()];
                font = Class58.smethod_2(struct3.method_4().Families[0], A_2, A_3);
            }
        }
        key = this.method_362(font.Name, A_2, A_3);
        if (!this.method_123().ContainsKey(key))
        {
            this.method_123().Add(key, font);
        }
        return font;
    }

    internal Font method_365(CharacterFormat A_0)
    {
        return this.method_366(A_0, CharacterCategory.Ascii);
    }

    internal Font method_366(CharacterFormat A_0, CharacterCategory A_1)
    {
        int num = 0;
        Class560 class2 = ((Interface11) A_0).imethod_0() as Class560;
        RectangleF ef = new RectangleF();
        Font font = class2.method_1();
        FontStyle style = font.Style;
        FontTypeHint hint = class2.method_9();
        string str = this.method_391(class2, hint);
        CharacterCategory category = A_1;
        switch (category)
        {
            case CharacterCategory.FarEast:
                str = class2.method_5();
                break;

            case CharacterCategory.ComplexScript:
                str = class2.method_6();
                break;

            default:
                if ((category == CharacterCategory.Other) && !A_0.IdctHint)
                {
                    str = class2.method_7();
                }
                break;
        }
        float num2 = (font.Size < 0.1) ? 0.1f : font.Size;
        num2 = this.method_355(class2.method_10(), font, ref ef);
        if (((((A_0.CharStyleName != null) && A_0.CharStyleName.ToLower().Equals(BookmarkStart.b("严儧娩䤫尭尯嬱娳崵", num))) && (A_0.UnderlineStyle == UnderlineStyle.Single)) && ((this.textRange_0 == null) || !this.method_353(this.textRange_0))) && !A_0.HasKey(140))
        {
            style |= FontStyle.Underline;
        }
        if ((this.bool_19 && (this.paragraph_1 != null)) && ((this.paragraph_1.ListFormat.ListType == ListType.Numbered) && (this.paragraph_1.ListFormat.CurrentListLevel != null)))
        {
            if (this.paragraph_1.ListFormat.CurrentListLevel.CharacterFormat.Font.Underline)
            {
                if ((style & FontStyle.Underline) == FontStyle.Regular)
                {
                    style |= FontStyle.Underline;
                }
            }
            else if ((style & FontStyle.Underline) != FontStyle.Regular)
            {
                style &= ~FontStyle.Underline;
            }
        }
        if ((A_0.Bidi && !string.IsNullOrEmpty(class2.method_6())) && (class2.method_3() != A_0.FontNameBidi))
        {
            str = class2.method_6();
        }
        font = this.method_375(str, num2, style, A_0);
        if ((A_1 == CharacterCategory.FarEast) && !this.method_371(font))
        {
            Font font2 = this.method_373(A_0, font);
            if (font2 != null)
            {
                font = font2;
            }
        }
        return font;
    }

    internal Font method_367(TextRange A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("戱唳䐵夷圹夻䨽┿ぁ㝃晅潇㹉㑋㩍ɏ㍑㩓ㅕ㵗絙籛㵝şౡ䍣ብ䡧୩ᡫ乭ѯ᝱ᱳ噵୷᭹ᅻ᭽ꁿꪉﶍ낏煉늛", num));
        }
        RectangleF ef = new RectangleF();
        return this.method_368(A_0, ref ef);
    }

    internal Font method_368(TextRange A_0, ref RectangleF A_1)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("昵夷䠹崻匽┿㙁⅃㑅㭇橉歋㩍⡏♑ٓ㝕㙗㵙㥛祝䁟šգࡥ佧ṩ䱫཭ѯ剱s፵ၷ婹ཻώꒃ꺍憐뒓躟", num));
        }
        return this.method_369(A_0, A_0.CharacterFormat, ref A_1);
    }

    internal Font method_369(TextRange A_0, CharacterFormat A_1, ref RectangleF A_2)
    {
        return this.method_370(A_0, A_1, ref A_2, false);
    }

    internal Font method_370(TextRange A_0, CharacterFormat A_1, ref RectangleF A_2, bool A_3)
    {
        int num = 0x11;
        if ((A_1 == null) && (A_0 == null))
        {
            throw new NullReferenceException(BookmarkStart.b("朶堸䤺尼刾⑀㝂⁄㕆㩈歊橌㭎⥐❒ݔ㙖㝘㱚㡜硞䅠ɢ୤ͦ䥨䱪๬ݮၰŲ㍴ᡶ୸ᙺᱼ୾Ꚁꎂ겊歷꾎떔ﲘ붜삠캢삤螦\udda8\uc2aa사쪮醰\udab2\uc6b4鞶\udcb8\ud6ba춼쮾룀", num));
        }
        Class560 class3 = ((Interface11) A_1).imethod_0() as Class560;
        if (A_0 == null)
        {
            return this.method_365(A_1);
        }
        if (((A_0.OwnerParagraph == null) && (class3.method_1() != null)) && (A_0.OwnerEmptyParagraph != null))
        {
            return this.method_365(A_1);
        }
        Font font2 = null;
        if ((A_0 == null) || (A_0.CharacterFormat == null))
        {
            font2 = class3.method_1();
            goto Label_03EA;
        }
        CharacterFormat characterFormat = A_0.CharacterFormat;
        Class560 class2 = ((Interface11) A_1).imethod_0() as Class560;
        font2 = class2.method_1();
        FontStyle style = font2.Style;
        FontTypeHint hint = class2.method_9();
        string fontNameFarEast = this.method_391(class2, hint);
        float fontSize = this.method_356(class2.method_10(), font2, ref A_2, A_3);
        if ((A_0.CharacterFormat.CharStyleName != BookmarkStart.b("缶䀸䬺堼䴾ⵀ⩂⭄ⱆ", num)) || !this.method_353(A_0))
        {
            if (A_0.CharacterFormat.CharStyle != null)
            {
                CharacterFormat format = A_0.CharacterFormat.CharStyle.CharacterFormat;
                if ((format.FontTypeHint == FontTypeHint.EastAsia) && format.HasValue(0xeb))
                {
                    fontNameFarEast = format.FontNameFarEast;
                }
                else if ((format.FontTypeHint == FontTypeHint.ComplexScript) && format.HasValue(270))
                {
                    fontNameFarEast = format.FontNameBidi;
                }
                else if (format.HasValue(2))
                {
                    fontNameFarEast = format.FontName;
                }
                if (format.HasValue(190))
                {
                    fontSize = format.FontSize;
                }
            }
            if (characterFormat.HasValue(190))
            {
                fontSize = class2.method_8();
            }
            if (A_0 is Field)
            {
                fontSize = class2.method_8();
            }
            if (hint == FontTypeHint.EastAsia)
            {
                if (characterFormat.HasValue(0xeb))
                {
                    fontNameFarEast = class2.method_5();
                }
            }
            else if (characterFormat.HasValue(2))
            {
                fontNameFarEast = class2.method_3();
            }
        }
        if ((A_0 != null) && (characterFormat != null))
        {
            CharacterCategory characterCategory = A_0.CharacterCategory;
            switch (characterCategory)
            {
                case CharacterCategory.Ascii:
                    fontNameFarEast = class2.method_4();
                    goto Label_0215;

                case CharacterCategory.FarEast:
                    fontNameFarEast = class2.method_5();
                    goto Label_0215;

                case CharacterCategory.ComplexScript:
                    fontNameFarEast = class2.method_6();
                    goto Label_0215;
            }
            if ((characterCategory == CharacterCategory.Other) && !characterFormat.IdctHint)
            {
                fontNameFarEast = class2.method_7();
            }
        }
    Label_0215:
        if (this.method_353(A_0))
        {
            style = (A_0.OwnerParagraph.ParaStyle != null) ? A_0.OwnerParagraph.ParaStyle.CharacterFormat.Font.Style : characterFormat.Font.Style;
        }
        if ((((A_0 == null) || (characterFormat == null)) || (((characterFormat.CharStyleName == null) || (characterFormat.CharStyleName != BookmarkStart.b("缶䀸䬺堼䴾ⵀ⩂⭄ⱆ", num))) || !this.method_353(A_0))) && ((class3.method_10() != SubSuperScript.None) && !A_3))
        {
            RectangleF ef = A_2;
            fontSize = this.method_354(A_0, A_1, ref ef);
        }
        if (((characterFormat.CharStyleName != null) && characterFormat.CharStyleName.ToLower().Equals(BookmarkStart.b("弶䀸䬺堼䴾ⵀ⩂⭄ⱆ", num))) && (!this.method_353(A_0) && !A_1.HasKey(140)))
        {
            style |= FontStyle.Underline;
        }
        if (((class3.method_11() != UnderlineStyle.None) || class3.method_1().Strikeout) && ((A_0.Text.Trim(new char[] { ' ' }) == string.Empty) && !(((Interface1) A_0).imethod_0() is Class206)))
        {
            if (A_0.NextSibling == null)
            {
                style &= ~FontStyle.Strikeout;
                style &= ~FontStyle.Underline;
            }
            else if (((A_0.NextSibling != null) && !A_0.Document.Settings.method_5().method_31()) && this.method_374(A_0))
            {
                style &= ~FontStyle.Strikeout;
                style &= ~FontStyle.Underline;
            }
        }
        if (fontSize == 0f)
        {
            fontSize = 0.5f;
        }
        font2 = this.method_375(fontNameFarEast, fontSize, style, A_1);
        if ((class2.method_12() && !string.IsNullOrEmpty(class2.method_6())) && (class2.method_3() != class2.method_6()))
        {
            return new Font(characterFormat.FontNameBidi, fontSize, characterFormat.Font.Style);
        }
    Label_03EA:
        if ((A_0.CharacterCategory == CharacterCategory.FarEast) && !this.method_371(font2))
        {
            Font font = this.method_372(A_0, font2);
            if (font != null)
            {
                font2 = font;
            }
        }
        return font2;
    }

    private bool method_371(Font A_0)
    {
        return ((A_0 == null) || this.method_342(A_0).method_0());
    }

    private Font method_372(TextRange A_0, Font A_1)
    {
        if ((A_0 == null) || (A_1 == null))
        {
            return null;
        }
        Font font = null;
        if ((A_0.CharacterFormat.CharStyle != null) && A_0.CharacterFormat.CharStyle.CharacterFormat.HasKey(0xeb))
        {
            font = new Font(A_0.CharacterFormat.CharStyle.CharacterFormat.FontNameFarEast, A_1.Size, A_1.Style);
            if (this.method_371(font))
            {
                return font;
            }
        }
        Paragraph paragraph = (A_0.OwnerParagraph != null) ? A_0.OwnerParagraph : ((A_0.OwnerEmptyParagraph != null) ? A_0.OwnerEmptyParagraph : null);
        if (paragraph != null)
        {
            if (paragraph.ParaStyle != null)
            {
                ParagraphStyle paraStyle = paragraph.ParaStyle;
                if (paraStyle.BaseStyle != null)
                {
                    while (paraStyle.BaseStyle != null)
                    {
                        if (paraStyle.CharacterFormat.HasKey(0xeb))
                        {
                            font = new Font(paraStyle.CharacterFormat.FontNameFarEast, A_1.Size, A_1.Style);
                            if (this.method_371(font))
                            {
                                return font;
                            }
                        }
                        paraStyle = paraStyle.BaseStyle;
                    }
                }
                else if (paraStyle.CharacterFormat.HasKey(0xeb))
                {
                    font = new Font(paraStyle.CharacterFormat.FontNameFarEast, A_1.Size, A_1.Style);
                    if (this.method_371(font))
                    {
                        return font;
                    }
                }
            }
            if (paragraph.BreakCharacterFormat.HasKey(0xeb))
            {
                font = new Font(paragraph.BreakCharacterFormat.FontNameFarEast, A_1.Size, A_1.Style);
                if (this.method_371(font))
                {
                    return font;
                }
            }
        }
        if (((A_0.Document != null) && (A_0.Document.DefCharFormat != null)) && A_0.Document.DefCharFormat.HasKey(0xeb))
        {
            font = new Font(A_0.Document.DefCharFormat.FontNameFarEast, A_1.Size, A_1.Style);
            if (this.method_371(font))
            {
                return font;
            }
        }
        return font;
    }

    private Font method_373(CharacterFormat A_0, Font A_1)
    {
        if ((A_0 == null) || (A_1 == null))
        {
            return null;
        }
        Font font = null;
        if ((A_0.CharStyle != null) && A_0.CharStyle.CharacterFormat.HasKey(0xeb))
        {
            font = new Font(A_0.CharStyle.CharacterFormat.FontNameFarEast, A_1.Size, A_1.Style);
            if (this.method_371(font))
            {
                return font;
            }
        }
        if (A_0.BaseFormat != null)
        {
            for (CharacterFormat format = A_0.BaseFormat as CharacterFormat; format != null; format = format.BaseFormat as CharacterFormat)
            {
                if (format.HasKey(0xeb))
                {
                    font = new Font(format.FontNameFarEast, A_1.Size, A_1.Style);
                    if (this.method_371(font))
                    {
                        return font;
                    }
                }
            }
        }
        if (((A_0.Document != null) && (A_0.Document.DefCharFormat != null)) && A_0.Document.DefCharFormat.HasKey(0xeb))
        {
            font = new Font(A_0.Document.DefCharFormat.FontNameFarEast, A_1.Size, A_1.Style);
            if (this.method_371(font))
            {
                return font;
            }
        }
        return font;
    }

    private bool method_374(TextRange A_0)
    {
        if (string.IsNullOrEmpty(A_0.Text.Trim(new char[] { ' ' })))
        {
            if (A_0.OwnerParagraph.ChildObjects.LastItem == A_0)
            {
                return true;
            }
            DocumentObject nextSibling = A_0.NextSibling as DocumentObject;
            while ((nextSibling is BookmarkStart) || (((nextSibling is BookmarkEnd) || (nextSibling is Break)) || ((nextSibling is TextRange) && ((nextSibling as TextRange).Text.Trim(new char[] { ' ' }) == string.Empty))))
            {
                if (!(nextSibling is Break))
                {
                    nextSibling = nextSibling.NextSibling as DocumentObject;
                    if (nextSibling != null)
                    {
                        continue;
                    }
                }
                return true;
            }
        }
        return false;
    }

    private Font method_375(string A_0, float A_1, FontStyle A_2, CharacterFormat A_3)
    {
        int num = 3;
        string str = A_0.ToLower();
        if (str == BookmarkStart.b("䠨太䐬丮崰䘲嬴帶娸吺夼娾ⱀあ", 3))
        {
            return this.method_363(BookmarkStart.b("栨太䐬丮崰ጲ怴夶倸堺刼嬾⑀捂ࡄᑆ", num), A_1, A_2, A_3);
        }
        if (str == BookmarkStart.b("娨刪䀬䴮帰弲", num))
        {
            return this.method_363(BookmarkStart.b("稨刪䀬䴮帰弲", num), A_1, A_2, A_3);
        }
        if (str.Contains(BookmarkStart.b("䬨䐪䄬䬮", num)))
        {
            A_2 |= FontStyle.Bold;
            string str3 = A_0.Substring(0, str.IndexOf(BookmarkStart.b("䬨䐪䄬䬮", num))).Trim();
            if ((str3.Length > 0) && char.IsPunctuation(str3[str3.Length - 1]))
            {
                str3 = str3.Substring(0, str3.Length - 1);
            }
            if ((str3.Length > 0) && char.IsPunctuation(str3[0]))
            {
                str3 = str3.Substring(1, str3.Length - 1);
            }
            return this.method_364(str3, A_0, A_1, A_2);
        }
        if (str.Contains(BookmarkStart.b("䀨弪䰬䌮堰倲", num)))
        {
            A_2 |= FontStyle.Italic;
            string str2 = A_0.Substring(0, str.IndexOf(BookmarkStart.b("䀨弪䰬䌮堰倲", num))).Trim();
            if ((str2.Length > 0) && char.IsPunctuation(str2[str2.Length - 1]))
            {
                str2 = str2.Substring(0, str2.Length - 1);
            }
            if ((str2.Length > 0) && char.IsPunctuation(str2[0]))
            {
                str2 = str2.Substring(1, str2.Length - 1);
            }
            return this.method_364(str2, A_0, A_1, A_2);
        }
        Font font = null;
        if (string.IsNullOrEmpty(A_0))
        {
            font = this.method_363(BookmarkStart.b("紨䈪䀬䨮䈰ጲ笴制丸ᬺ漼倾ⱀ≂⭄", num), A_1, A_2, A_3);
        }
        else
        {
            font = this.method_363(A_0, A_1, A_2, A_3);
        }
        this.method_352(A_3, A_0, ref font);
        return font;
    }

    internal sprᝪ method_376(CharacterFormat A_0)
    {
        return this.method_377(A_0, CharacterCategory.Ascii);
    }

    internal sprᝪ method_377(CharacterFormat A_0, CharacterCategory A_1)
    {
        int num = 0x12;
        Class560 class2 = ((Interface11) A_0).imethod_0() as Class560;
        RectangleF ef = new RectangleF();
        sprᝪ rᝪ = this.method_389(class2.method_3(), class2.method_8(), class2.method_2());
        FontStyle style = rᝪ.ᜂ();
        FontTypeHint hint = class2.method_9();
        string str = this.method_391(class2, hint);
        CharacterCategory category = A_1;
        switch (category)
        {
            case CharacterCategory.FarEast:
                str = class2.method_5();
                break;

            case CharacterCategory.ComplexScript:
                str = class2.method_6();
                break;

            default:
                if ((category == CharacterCategory.Other) && !A_0.IdctHint)
                {
                    str = class2.method_7();
                }
                break;
        }
        float num2 = (rᝪ.ᜑ() < 0.1) ? 0.1f : rᝪ.ᜑ();
        num2 = this.method_357(class2.method_10(), rᝪ, ref ef);
        if (((((A_0.CharStyleName != null) && A_0.CharStyleName.ToLower().Equals(BookmarkStart.b("倷䌹䰻嬽㈿⹁ⵃ⡅⍇", num))) && (A_0.UnderlineStyle == UnderlineStyle.Single)) && ((this.textRange_0 == null) || !this.method_353(this.textRange_0))) && !A_0.HasKey(140))
        {
            style |= FontStyle.Underline;
        }
        if ((this.bool_19 && (this.paragraph_1 != null)) && ((this.paragraph_1.ListFormat.ListType == ListType.Numbered) && (this.paragraph_1.ListFormat.CurrentListLevel != null)))
        {
            if (this.paragraph_1.ListFormat.CurrentListLevel.CharacterFormat.Font.Underline)
            {
                if ((style & FontStyle.Underline) == FontStyle.Regular)
                {
                    style |= FontStyle.Underline;
                }
            }
            else if ((style & FontStyle.Underline) != FontStyle.Regular)
            {
                style &= ~FontStyle.Underline;
            }
        }
        if ((A_0.Bidi && !string.IsNullOrEmpty(class2.method_6())) && (class2.method_3() != A_0.FontNameBidi))
        {
            str = class2.method_6();
        }
        rᝪ = this.method_385(str, num2, style, A_0);
        if ((A_1 == CharacterCategory.FarEast) && !this.method_382(rᝪ))
        {
            sprᝪ rᝪ2 = this.method_384(A_0, rᝪ);
            if (rᝪ2 != null)
            {
                rᝪ = rᝪ2;
            }
        }
        return rᝪ;
    }

    internal sprᝪ method_378(TextRange A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("朶堸䤺尼刾⑀㝂⁄㕆㩈歊橌㭎⥐❒ݔ㙖㝘㱚㡜硞䅠bѤ०乨Ὢ䵬๮հ卲Ŵቶᅸ孺๼Ṿꖄ꾎떔辠", num));
        }
        RectangleF ef = new RectangleF();
        return this.method_379(A_0, ref ef);
    }

    internal sprᝪ method_379(TextRange A_0, ref RectangleF A_1)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("砧䬩師伭崯圱䀳匵䨷䤹᰻᤽㐿㩁ぃᑅ⥇⑉⭋⭍睏牑㝓㝕㙗絙⡛繝şᙡ䑣ብ൧ɩ䱫ᵭᅯάᅳ噵౷፹ᅻ᭽ꁿꚅﲋ揄벑", num));
        }
        return this.method_380(A_0, A_0.CharacterFormat, ref A_1);
    }

    internal sprᝪ method_380(TextRange A_0, CharacterFormat A_1, ref RectangleF A_2)
    {
        return this.method_381(A_0, A_1, ref A_2, false);
    }

    internal sprᝪ method_381(TextRange A_0, CharacterFormat A_1, ref RectangleF A_2, bool A_3)
    {
        int num = 8;
        if ((A_1 == null) && (A_0 == null))
        {
            throw new NullReferenceException(BookmarkStart.b("縭儯䀱唳嬵崷丹夻䰽㌿扁捃㉅ぇ㹉ṋ⽍㹏㕑ㅓ煕硗㭙㉛㩝䁟䕡ݣ๥१ᡩ⩫ŭɯάᕳɵ彷婹ύώꖁꚅﺉ겋揄晴뒓聯鍊뺝풟쮡즣쎥袧쎩\udfab\u8ead햯\udfb1\uc4b3습솷钹", num));
        }
        Class560 class2 = ((Interface11) A_1).imethod_0() as Class560;
        if (A_0 == null)
        {
            return this.method_376(A_1);
        }
        if (((A_0.OwnerParagraph == null) && (class2.method_1() != null)) && (A_0.OwnerEmptyParagraph != null))
        {
            return this.method_376(A_1);
        }
        sprᝪ rᝪ = null;
        if ((A_0 == null) || (A_0.CharacterFormat == null))
        {
            rᝪ = this.method_389(class2.method_3(), class2.method_8(), class2.method_2());
            goto Label_0495;
        }
        CharacterFormat characterFormat = A_0.CharacterFormat;
        Class560 class3 = ((Interface11) A_1).imethod_0() as Class560;
        rᝪ = this.method_389(class3.method_3(), class3.method_8(), class3.method_2());
        FontStyle style = rᝪ.ᜂ();
        FontTypeHint hint = class3.method_9();
        string fontNameFarEast = this.method_391(class3, hint);
        float fontSize = this.method_358(class3.method_10(), rᝪ, ref A_2, A_3);
        if ((A_0.CharacterFormat.CharStyleName != BookmarkStart.b("昭䤯䈱儳䐵吷匹刻唽", num)) || !this.method_353(A_0))
        {
            if (A_0.CharacterFormat.CharStyle != null)
            {
                CharacterFormat format2 = A_0.CharacterFormat.CharStyle.CharacterFormat;
                if ((format2.FontTypeHint == FontTypeHint.EastAsia) && format2.HasValue(0xeb))
                {
                    fontNameFarEast = format2.FontNameFarEast;
                }
                else if ((format2.FontTypeHint == FontTypeHint.ComplexScript) && format2.HasValue(270))
                {
                    fontNameFarEast = format2.FontNameBidi;
                }
                else if (format2.HasValue(2))
                {
                    fontNameFarEast = format2.FontName;
                }
                if (format2.HasValue(190))
                {
                    fontSize = format2.FontSize;
                }
            }
            if (characterFormat.HasValue(190))
            {
                fontSize = class3.method_8();
            }
            if (A_0 is Field)
            {
                fontSize = class3.method_8();
            }
            if (hint == FontTypeHint.EastAsia)
            {
                if (characterFormat.HasValue(0xeb))
                {
                    fontNameFarEast = class3.method_5();
                }
            }
            else if (characterFormat.HasValue(2))
            {
                fontNameFarEast = class3.method_3();
            }
        }
        if ((A_0 != null) && (characterFormat != null))
        {
            CharacterCategory characterCategory = A_0.CharacterCategory;
            switch (characterCategory)
            {
                case CharacterCategory.Ascii:
                    fontNameFarEast = class3.method_4();
                    goto Label_0241;

                case CharacterCategory.FarEast:
                    fontNameFarEast = class3.method_5();
                    goto Label_0241;

                case CharacterCategory.ComplexScript:
                    fontNameFarEast = class3.method_6();
                    goto Label_0241;
            }
            if ((characterCategory == CharacterCategory.Other) && !characterFormat.IdctHint)
            {
                fontNameFarEast = class3.method_7();
            }
        }
    Label_0241:
        if (this.method_353(A_0))
        {
            style = (A_0.OwnerParagraph.ParaStyle != null) ? A_0.OwnerParagraph.ParaStyle.CharacterFormat.Font.Style : characterFormat.Font.Style;
        }
        if ((((A_0 == null) || (characterFormat == null)) || (((characterFormat.CharStyleName == null) || (characterFormat.CharStyleName != BookmarkStart.b("昭䤯䈱儳䐵吷匹刻唽", num))) || !this.method_353(A_0))) && ((class2.method_10() != SubSuperScript.None) && !A_3))
        {
            RectangleF ef = A_2;
            fontSize = this.method_354(A_0, A_1, ref ef);
        }
        if (((characterFormat.CharStyleName != null) && characterFormat.CharStyleName.ToLower().Equals(BookmarkStart.b("䘭䤯䈱儳䐵吷匹刻唽", num))) && (!this.method_353(A_0) && !A_1.HasKey(140)))
        {
            style |= FontStyle.Underline;
        }
        if (((class2.method_11() != UnderlineStyle.None) || class2.method_1().Strikeout) && ((A_0.Text.Trim(new char[] { ' ' }) == string.Empty) && !(((Interface1) A_0).imethod_0() is Class206)))
        {
            if (A_0.NextSibling == null)
            {
                style &= ~FontStyle.Strikeout;
                style &= ~FontStyle.Underline;
            }
            else if (A_0.NextSibling != null)
            {
                DocumentObject nextSibling = A_0.NextSibling as DocumentObject;
                while (nextSibling is TextRange)
                {
                    if (!((nextSibling as TextRange).Text.Trim(new char[] { ' ' }) == string.Empty))
                    {
                        break;
                    }
                    nextSibling = nextSibling.NextSibling as DocumentObject;
                    if (nextSibling == null)
                    {
                        break;
                    }
                }
                if (((nextSibling == null) || !(nextSibling is TextRange)) || ((nextSibling as TextRange).Text.Trim(new char[] { ' ' }) == string.Empty))
                {
                    style &= ~FontStyle.Strikeout;
                    style &= ~FontStyle.Underline;
                }
            }
        }
        if (fontSize == 0f)
        {
            fontSize = 0.5f;
        }
        rᝪ = this.method_385(fontNameFarEast, fontSize, style, A_1);
        if ((class3.method_12() && !string.IsNullOrEmpty(class3.method_6())) && (class3.method_3() != class3.method_6()))
        {
            return this.method_389(characterFormat.FontNameBidi, fontSize, characterFormat.FontStyle);
        }
    Label_0495:
        if ((A_0.CharacterCategory == CharacterCategory.FarEast) && !this.method_382(rᝪ))
        {
            sprᝪ rᝪ2 = this.method_383(A_0, rᝪ);
            if (rᝪ2 != null)
            {
                rᝪ = rᝪ2;
            }
        }
        return rᝪ;
    }

    private bool method_382(sprᝪ A_0)
    {
        if (A_0 == null)
        {
            return false;
        }
        return A_0.ᜊ().ᜄ().ᜃ();
    }

    private sprᝪ method_383(TextRange A_0, sprᝪ A_1)
    {
        if ((A_0 == null) || (A_1 == null))
        {
            return null;
        }
        sprᝪ rᝪ = null;
        if ((A_0.CharacterFormat.CharStyle != null) && A_0.CharacterFormat.CharStyle.CharacterFormat.HasKey(0xeb))
        {
            string fontNameFarEast = A_0.CharacterFormat.CharStyle.CharacterFormat.FontNameFarEast;
            rᝪ = this.method_389(fontNameFarEast, A_1.ᜑ(), A_1.ᜂ());
            if (this.method_382(rᝪ))
            {
                return rᝪ;
            }
        }
        Paragraph paragraph = (A_0.OwnerParagraph != null) ? A_0.OwnerParagraph : ((A_0.OwnerEmptyParagraph != null) ? A_0.OwnerEmptyParagraph : null);
        if (paragraph != null)
        {
            if (paragraph.ParaStyle != null)
            {
                ParagraphStyle paraStyle = paragraph.ParaStyle;
                if (paraStyle.BaseStyle != null)
                {
                    while (paraStyle.BaseStyle != null)
                    {
                        if (paraStyle.CharacterFormat.HasKey(0xeb))
                        {
                            string str4 = paraStyle.CharacterFormat.FontNameFarEast;
                            rᝪ = this.method_389(str4, A_1.ᜑ(), A_1.ᜂ());
                            if (this.method_382(rᝪ))
                            {
                                return rᝪ;
                            }
                        }
                        paraStyle = paraStyle.BaseStyle;
                    }
                }
                else if (paraStyle.CharacterFormat.HasKey(0xeb))
                {
                    string str5 = paraStyle.CharacterFormat.FontNameFarEast;
                    rᝪ = this.method_389(str5, A_1.ᜑ(), A_1.ᜂ());
                    if (this.method_382(rᝪ))
                    {
                        return rᝪ;
                    }
                }
            }
            if (paragraph.BreakCharacterFormat.HasKey(0xeb))
            {
                string str = paragraph.BreakCharacterFormat.FontNameFarEast;
                rᝪ = this.method_389(str, A_1.ᜑ(), A_1.ᜂ());
                if (this.method_382(rᝪ))
                {
                    return rᝪ;
                }
            }
        }
        if (((A_0.Document != null) && (A_0.Document.DefCharFormat != null)) && A_0.Document.DefCharFormat.HasKey(0xeb))
        {
            string str2 = A_0.Document.DefCharFormat.FontNameFarEast;
            rᝪ = this.method_389(str2, A_1.ᜑ(), A_1.ᜂ());
            if (this.method_382(rᝪ))
            {
                return rᝪ;
            }
        }
        return rᝪ;
    }

    private sprᝪ method_384(CharacterFormat A_0, sprᝪ A_1)
    {
        if ((A_0 == null) || (A_1 == null))
        {
            return null;
        }
        sprᝪ rᝪ = null;
        if ((A_0.CharStyle != null) && A_0.CharStyle.CharacterFormat.HasKey(0xeb))
        {
            string fontNameFarEast = A_0.CharStyle.CharacterFormat.FontNameFarEast;
            rᝪ = this.method_389(fontNameFarEast, A_1.ᜑ(), A_1.ᜂ());
            if (this.method_382(rᝪ))
            {
                return rᝪ;
            }
        }
        if (A_0.BaseFormat != null)
        {
            for (CharacterFormat format = A_0.BaseFormat as CharacterFormat; format != null; format = format.BaseFormat as CharacterFormat)
            {
                if (format.HasKey(0xeb))
                {
                    string str3 = format.FontNameFarEast;
                    rᝪ = this.method_389(str3, A_1.ᜑ(), A_1.ᜂ());
                    if (this.method_382(rᝪ))
                    {
                        return rᝪ;
                    }
                }
            }
        }
        if (((A_0.Document != null) && (A_0.Document.DefCharFormat != null)) && A_0.Document.DefCharFormat.HasKey(0xeb))
        {
            string str2 = A_0.Document.DefCharFormat.FontNameFarEast;
            rᝪ = this.method_389(str2, A_1.ᜑ(), A_1.ᜂ());
            if (this.method_382(rᝪ))
            {
                return rᝪ;
            }
        }
        return rᝪ;
    }

    private sprᝪ method_385(string A_0, float A_1, FontStyle A_2, CharacterFormat A_3)
    {
        int num = 4;
        string str = A_0.ToLower();
        if (str == BookmarkStart.b("䬩師䜭儯帱䄳堵儷夹医娽┿⽁㝃", 4))
        {
            return this.method_387(BookmarkStart.b("欩師䜭儯帱ᐳ挵嘷匹弻儽␿❁摃୅ᭇ", num), A_1, A_2, A_3);
        }
        if (str == BookmarkStart.b("天唫䌭刯崱堳", num))
        {
            return this.method_387(BookmarkStart.b("礩唫䌭刯崱堳", num), A_1, A_2, A_3);
        }
        if (str.Contains(BookmarkStart.b("䠩䌫䈭启", num)))
        {
            A_2 |= FontStyle.Bold;
            string str3 = A_0.Substring(0, str.IndexOf(BookmarkStart.b("䠩䌫䈭启", num))).Trim();
            if ((str3.Length > 0) && char.IsPunctuation(str3[str3.Length - 1]))
            {
                str3 = str3.Substring(0, str3.Length - 1);
            }
            if ((str3.Length > 0) && char.IsPunctuation(str3[0]))
            {
                str3 = str3.Substring(1, str3.Length - 1);
            }
            return this.method_388(str3, A_0, A_1, A_2);
        }
        if (str.Contains(BookmarkStart.b("䌩堫伭尯嬱圳", num)))
        {
            A_2 |= FontStyle.Italic;
            string str2 = A_0.Substring(0, str.IndexOf(BookmarkStart.b("䌩堫伭尯嬱圳", num))).Trim();
            if ((str2.Length > 0) && char.IsPunctuation(str2[str2.Length - 1]))
            {
                str2 = str2.Substring(0, str2.Length - 1);
            }
            if ((str2.Length > 0) && char.IsPunctuation(str2[0]))
            {
                str2 = str2.Substring(1, str2.Length - 1);
            }
            return this.method_388(str2, A_0, A_1, A_2);
        }
        sprᝪ rᝪ = null;
        if (string.IsNullOrEmpty(A_0))
        {
            rᝪ = this.method_387(BookmarkStart.b("縩䔫䌭唯䄱ᐳ砵崷䴹᰻氽⼿⽁╃⡅", num), A_1, A_2, A_3);
        }
        else
        {
            rᝪ = this.method_387(A_0, A_1, A_2, A_3);
        }
        this.method_386(A_3, A_0, ref rᝪ);
        return rᝪ;
    }

    private void method_386(CharacterFormat A_0, string A_1, ref sprᝪ A_2)
    {
        if (((A_0.Document != null) && A_0.Document.FontSubstitutionTable.ContainsKey(A_1)) && (A_1 != A_2.ᜀ()))
        {
            A_2 = this.method_387(A_0.Document.FontSubstitutionTable[A_1], A_2.ᜑ(), A_2.ᜂ(), A_0);
        }
    }

    private sprᝪ method_387(string A_0, float A_1, FontStyle A_2, CharacterFormat A_3)
    {
        return this.method_388(A_0, A_0, A_1, A_2);
    }

    private sprᝪ method_388(string A_0, string A_1, float A_2, FontStyle A_3)
    {
        int num = 2;
        string key = this.method_362(A_0, A_2, A_3);
        if (this.method_125().ContainsKey(key))
        {
            return this.method_125()[key];
        }
        sprᝪ rᝪ = this.method_389(A_0, A_2, A_3);
        string str2 = A_0.ToLower();
        if (((rᝪ.ᜀ().ToLower() == BookmarkStart.b("䔧䌩伫尭弯䄱嬳倵䰷ᨹ伻弽⸿ㅁ摃㕅ⵇ㡉╋⡍", num)) || !rᝪ.ᜀ().ToLower().Equals(str2)) && (!string.IsNullOrEmpty(A_1) && !A_0.Equals(A_1)))
        {
            rᝪ = this.method_389(A_1, A_2, A_3);
            str2 = A_1.ToLower();
        }
        if (((rᝪ.ᜀ().ToLower() == BookmarkStart.b("䔧䌩伫尭弯䄱嬳倵䰷ᨹ伻弽⸿ㅁ摃㕅ⵇ㡉╋⡍", num)) || !rᝪ.ᜀ().ToLower().Equals(str2)) && ((base.method_19() != null) && (base.method_19().PrivateFontList.Count > 0)))
        {
            string str3 = !string.IsNullOrEmpty(A_1) ? A_1 : A_0;
            string str4 = str3.ToLower() + this.method_361(A_3);
            if (base.method_19().PrivateFontList.ContainsKey(str4))
            {
                base.method_19().PrivateFontList[str4].method_4();
            }
            else if (base.method_19().PrivateFontList.ContainsKey(str3.ToLower()))
            {
                base.method_19().PrivateFontList[str3.ToLower()].method_4();
            }
        }
        key = this.method_362(rᝪ.ᜀ(), A_2, A_3);
        if (!this.method_125().ContainsKey(key))
        {
            this.method_125().Add(key, rᝪ);
        }
        return rᝪ;
    }

    private sprᝪ method_389(string A_0, float A_1, FontStyle A_2)
    {
        return new Class308(A_0, A_1, A_2).method_16();
    }

    private string method_390(CharacterFormat A_0, FontTypeHint A_1)
    {
        int num = 1;
        if (A_0 == null)
        {
            return BookmarkStart.b("猦䀨䘪䠬尮ᄰ紲倴䀶ᤸ椺刼刾⁀ⵂ", num);
        }
        string fontName = A_0.FontName;
        switch (A_1)
        {
            case FontTypeHint.EastAsia:
                return A_0.FontNameFarEast;

            case FontTypeHint.ComplexScript:
                return A_0.FontNameBidi;
        }
        return fontName;
    }

    private string method_391(Class560 A_0, FontTypeHint A_1)
    {
        if (A_0 == null)
        {
            return A_0.string_0;
        }
        string str = A_0.method_3();
        switch (A_1)
        {
            case FontTypeHint.EastAsia:
                return A_0.method_5();

            case FontTypeHint.ComplexScript:
                return A_0.method_6();
        }
        return str;
    }

    private StringAlignment method_392(ParagraphFormat A_0)
    {
        StringAlignment near = StringAlignment.Near;
        if (A_0.HorizontalAlignment == HorizontalAlignment.Right)
        {
            return StringAlignment.Far;
        }
        if (A_0.HorizontalAlignment == HorizontalAlignment.Center)
        {
            near = StringAlignment.Center;
        }
        return near;
    }

    private Pen method_393(Border A_0)
    {
        Pen pen = null;
        float lineWidth = A_0.LineWidth;
        FormatBase parentFormat = A_0.ParentFormat;
        if (parentFormat is CharacterFormat)
        {
            lineWidth = (lineWidth * 20f) / 8f;
        }
        else
        {
            if (parentFormat is Borders)
            {
                parentFormat = parentFormat.ParentFormat;
            }
            if ((parentFormat == null) || (parentFormat is ParagraphFormat))
            {
                lineWidth = (lineWidth * 20f) / 8f;
            }
        }
        Color black = Color.Black;
        if (!A_0.Color.IsEmpty && (A_0.Color.ToArgb() != 0))
        {
            black = A_0.Color;
        }
        pen = new Pen(black, A_0.LineWidth);
        switch (A_0.BorderType)
        {
            case BorderStyle.Double:
                pen.Width = (pen.Width < 1.5f) ? 1.5f : pen.Width;
                pen.CompoundArray = new float[] { 0f, 0.3f, 0.7f, 1f };
                break;

            case BorderStyle.Dot:
                pen.DashPattern = new float[] { 1f, 2f };
                break;

            case BorderStyle.DashLargeGap:
                pen.DashPattern = new float[] { 3f, 5f };
                break;

            case BorderStyle.DotDash:
                pen.DashPattern = new float[] { 4f, 3f, 1f, 3f };
                break;

            case BorderStyle.DotDotDash:
                pen.DashPattern = new float[] { 8f, 3f, 1f, 3f, 1f, 3f };
                break;

            case BorderStyle.Triple:
                pen.Width = 1.5f;
                pen.CompoundArray = new float[] { 0f, 0.1f, 0.9f, 1f };
                break;

            case BorderStyle.DashSmallGap:
                pen.DashPattern = new float[] { 3f, 3f };
                break;

            case BorderStyle.Outset:
                pen.Alignment = PenAlignment.Outset;
                break;

            case BorderStyle.Inset:
                pen.Alignment = PenAlignment.Inset;
                break;
        }
        pen.StartCap = LineCap.Square;
        pen.EndCap = LineCap.Square;
        return pen;
    }

    internal float method_394(DocumentObject A_0)
    {
        Paragraph paragraph = (A_0.Owner is SDTInlineContent) ? (A_0.Owner as SDTInlineContent).OwnerParagraph : (A_0.Owner as Paragraph);
        TableCell cell = (paragraph.Owner is SDTContent) ? (paragraph.Owner as SDTContent).method_46() : (paragraph.OwnerTextBody as TableCell);
        Class212 class2 = ((Interface1) cell).imethod_0() as Class212;
        float cellSpacingEx = 0f;
        if (cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f)
        {
            cellSpacingEx = cell.OwnerRow.OwnerTable.TableFormat.CellSpacingEx;
        }
        float num = class2.method_130();
        Interface22 interface2 = ((Interface1) cell).imethod_0();
        float num3 = ((float) (interface2.imethod_0().method_0() + interface2.imethod_1().method_0())) - cellSpacingEx;
        float num4 = ((float) (interface2.imethod_0().method_8() + interface2.imethod_1().method_8())) - cellSpacingEx;
        float num5 = ((float) (interface2.imethod_0().method_4() + interface2.imethod_1().method_4())) - cellSpacingEx;
        float num6 = ((float) (interface2.imethod_0().method_12() + interface2.imethod_1().method_12())) - cellSpacingEx;
        num = (num - num3) - num4;
        if ((cell.CellFormat.TextDirection != TextDirection.TopToBottom) && (A_0 is TextRange))
        {
            num = (((float) (((Interface1) cell).imethod_0() as Class211).method_119()) - num5) - num6;
        }
        Class210 class3 = ((Interface1) paragraph).imethod_0() as Class210;
        if (class3.method_43())
        {
            return (num - ((((float) (class3.Interface22.imethod_1().method_0() + class3.Interface22.imethod_1().method_8())) + class3.method_19()) + class3.method_51()));
        }
        return (num - (((float) (class3.Interface22.imethod_1().method_0() + class3.Interface22.imethod_1().method_8())) + class3.method_51()));
    }

    private Image method_395(Image A_0, float A_1, float A_2)
    {
        if ((A_0.Width <= A_1) && (A_0.Height <= A_2))
        {
            return A_0;
        }
        if (base.method_1())
        {
            return A_0;
        }
        int width = A_0.Width;
        int height = A_0.Height;
        int x = 0;
        int y = 0;
        int num = 0;
        int num2 = 0;
        int num3 = (int) A_1;
        int num4 = (int) A_2;
        if (num3 <= 0)
        {
            num3 = 1;
        }
        if (num4 <= 0)
        {
            num4 = 1;
        }
        Bitmap image = new Bitmap(num3, num4, PixelFormat.Format24bppRgb);
        image.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.Clear(Color.White);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(A_0, new Rectangle(num, num2, num3, num4), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            graphics.Dispose();
        }
        return image;
    }

    private void method_396(Hyperlink A_0, RectangleF A_1)
    {
        int num = 13;
        string filePath = "";
        switch (A_0.Type)
        {
            case HyperlinkType.FileLink:
                filePath = A_0.FilePath;
                break;

            case HyperlinkType.WebLink:
            case HyperlinkType.EMailLink:
                filePath = A_0.Uri;
                break;

            case HyperlinkType.Bookmark:
            {
                Dictionary<string, Class310> item = new Dictionary<string, Class310>();
                Class310 class2 = new Class310();
                class2.method_9(A_0.Field.Value.Replace(BookmarkStart.b("ᄲ", num), string.Empty));
                if (!A_0.BookmarkName.ToLower().StartsWith(BookmarkStart.b("氲䄴堶娸", num)))
                {
                    class2.method_1(A_1);
                }
                else
                {
                    class2.method_1(this.rectangleF_0);
                    class2.method_17(true);
                }
                class2.method_7(base.method_16());
                item.Add(class2.method_8(), class2);
                if (!this.method_399(class2.method_8()))
                {
                    this.method_145().Add(item);
                }
                using (List<BookmarkLevel>.Enumerator enumerator = this.method_147().GetEnumerator())
                {
                    BookmarkLevel current;
                    while (enumerator.MoveNext())
                    {
                        current = enumerator.Current;
                        if (current.Name == class2.method_8())
                        {
                            goto Label_01A5;
                        }
                        using (List<BookmarkLevel>.Enumerator enumerator2 = current.ChildObjects.GetEnumerator())
                        {
                            BookmarkLevel level2;
                            while (enumerator2.MoveNext())
                            {
                                level2 = enumerator2.Current;
                                if (level2.Name == class2.method_8())
                                {
                                    goto Label_015D;
                                }
                            }
                            continue;
                        Label_015D:
                            class2.method_3(level2.TargetBounds);
                            class2.method_5(level2.TargetPageNumber);
                            class2.method_11(level2.Text);
                            continue;
                        }
                    }
                    return;
                Label_01A5:
                    class2.method_3(current.TargetBounds);
                    class2.method_5(current.TargetPageNumber);
                    class2.method_11(current.Text);
                }
                return;
            }
        }
        this.method_398(filePath, A_1);
    }

    internal void method_397(Field A_0, Class375 A_1)
    {
        Dictionary<string, Class310> item = new Dictionary<string, Class310>();
        Class310 class2 = new Class310();
        string[] strArray = A_0.method_177().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        class2.method_9(strArray[1]);
        class2.method_1(A_1.method_69());
        class2.method_7(base.method_16());
        item.Add(class2.method_8(), class2);
        if (!this.method_399(class2.method_8()))
        {
            this.method_145().Add(item);
        }
        using (List<BookmarkLevel>.Enumerator enumerator = this.method_147().GetEnumerator())
        {
            BookmarkLevel current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.Name == class2.method_8())
                {
                    goto Label_011C;
                }
                using (List<BookmarkLevel>.Enumerator enumerator2 = current.ChildObjects.GetEnumerator())
                {
                    BookmarkLevel level2;
                    while (enumerator2.MoveNext())
                    {
                        level2 = enumerator2.Current;
                        if (level2.Name == class2.method_8())
                        {
                            goto Label_00D7;
                        }
                    }
                    continue;
                Label_00D7:
                    class2.method_3(level2.TargetBounds);
                    class2.method_5(level2.TargetPageNumber);
                    class2.method_11(level2.Text);
                    continue;
                }
            }
            return;
        Label_011C:
            class2.method_3(current.TargetBounds);
            class2.method_5(current.TargetPageNumber);
            class2.method_11(current.Text);
        }
    }

    private void method_398(string A_0, RectangleF A_1)
    {
        if (!string.IsNullOrEmpty(A_0))
        {
            Dictionary<string, RectangleF> item = new Dictionary<string, RectangleF>();
            item.Add(A_0, A_1);
            if (!this.list_12.Contains(item))
            {
                this.list_12.Add(item);
            }
        }
    }

    private bool method_399(string A_0)
    {
        bool flag;
        using (List<Dictionary<string, Class310>>.Enumerator enumerator = this.method_145().GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Dictionary<string, Class310> current = enumerator.Current;
                if (current.ContainsKey(A_0))
                {
                    goto Label_002B;
                }
            }
            return false;
        Label_002B:
            flag = true;
        }
        return flag;
    }

    internal void method_400(Paragraph A_0, Class310 A_1)
    {
        int num = 11;
        if (((A_1.method_8() != null) && (A_0.Document.TOC != null)) && A_1.method_8().StartsWith(BookmarkStart.b("渰朲娴吶", num)))
        {
            int outlineLevelEx = A_0.Format.OutlineLevelEx;
            A_0.Document.TOC.method_50();
            A_1.method_15(A_0.Text);
            if (A_0.Document.TOC.TOCLevels.Contains(outlineLevelEx))
            {
                A_1.method_13(outlineLevelEx);
            }
            if ((A_1.method_12() == 0) && (A_0.Format.OutlineLevelEx <= 9))
            {
                A_1.method_13(A_0.Format.OutlineLevelEx);
            }
        }
    }

    internal int method_401(string A_0, Interface20 A_1, string A_2, double A_3, bool A_4, bool A_5, float A_6, float A_7)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("別䴧利堫", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唥尧堩笫䜭启唱儳䈵", num));
        }
        if (A_3 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䤥丧䰩弫䬭䐯", num), A_3, BookmarkStart.b("瀥䤧䘩夫䬭ု儱唳堵ᠷ吹医䨽怿⁁⅃晅⑇⽉㽋㵍灏扑", num));
        }
        int num5 = -1;
        if (A_6 == 0f)
        {
            A_6 = (float) A_3;
        }
        if ((A_0.Length == 0) || ((A_3 <= 0.0) && (A_6 >= 0f)))
        {
            return num5;
        }
        int num2 = 0;
        int length = 0;
        double num4 = 0.0;
        while ((length = this.method_411(A_0, num2)) > -1)
        {
            SizeF ef = A_1.imethod_0(this, A_0.Substring(num2, length));
            if ((ef.Width + num4) > A_3)
            {
                num2 = 0;
                break;
            }
            num4 += ef.Width;
            num2 += length;
        }
        num5 = -1;
        return this.method_403(A_0, A_1, A_2, length, -1, A_4, A_5, A_3, A_6);
    }

    internal int method_402(string A_0, Interface20 A_1, int A_2, int A_3, bool A_4, bool A_5, double A_6, float A_7, float A_8)
    {
        if (((A_3 < 0) || A_4) || A_5)
        {
            for (int i = 0; i < A_0.Length; i++)
            {
                SizeF ef2 = A_1.imethod_0(this, A_0.Substring(0, i + 1));
                if (ef2.Width > A_6)
                {
                    A_3 = i - 1;
                    if ((A_3 == -1) && A_5)
                    {
                        float num3 = this.method_394(A_1 as TextRange);
                        if (ef2.Width > num3)
                        {
                            A_3 = 0;
                        }
                    }
                    if (A_7 < 0f)
                    {
                        A_3 = 0;
                    }
                    break;
                }
            }
            string[] strArray = A_0.Split(new char[] { ' ' });
            int num4 = A_3;
            if ((!this.method_407(A_0) && !A_5) && ((Math.Round((double) A_8, 2) == Math.Round(A_6, 2)) && (A_2 != 1)))
            {
                for (int j = 0; j < strArray.Length; j++)
                {
                    if ((strArray[j].Length - 1) > num4)
                    {
                        A_3 -= num4 + 1;
                        break;
                    }
                    num4 -= strArray[j].Length + 1;
                }
            }
        }
        if ((A_2 == 1) && !this.method_407(A_0))
        {
            SizeF ef = A_1.imethod_0(this, A_0);
            if (((Math.Round((double) A_8, 2) == Math.Round(A_6, 2)) && !this.method_406(A_1 as TextRange, ef, A_7)) && ((ef.Width <= A_7) || (Math.Round((double) A_7, 2) > Math.Round(A_6, 2))))
            {
                A_3 = -1;
            }
        }
        if (A_3 < 0)
        {
            A_3 = A_0.Length - 1;
        }
        return A_3;
    }

    internal int method_403(string A_0, Interface20 A_1, string A_2, int A_3, int A_4, bool A_5, bool A_6, double A_7, float A_8)
    {
        List<int> list = new List<int>();
        if (((A_4 < 0) || A_5) || A_6)
        {
            float width;
            for (int i = 0; i < A_0.Length; i++)
            {
                width = A_1.imethod_0(this, A_0.Substring(0, i + 1)).Width;
                if (char.IsPunctuation(A_0[i]))
                {
                    list.Add(i);
                }
                if (width > A_7)
                {
                    A_4 = i;
                    break;
                }
                if (A_0.Length == 1)
                {
                    A_4 = 1;
                }
                else
                {
                    A_4 = i;
                }
            }
            string[] strArray = A_0.Split(new char[] { ' ' });
            int num6 = A_4;
            if (A_6)
            {
                if (this.method_407(A_0))
                {
                    if ((A_3 <= 1) || (A_4 > 0x1a))
                    {
                        float num15 = A_1.imethod_0(this, A_2).Width;
                        float num10 = A_1.imethod_0(this, A_0).Width;
                        int length = (A_4 == 0) ? (A_4 + 1) : A_4;
                        float num12 = A_1.imethod_0(this, A_0.Substring(0, length)).Width;
                        if (num15 < A_8)
                        {
                            return -1;
                        }
                        if ((num10 <= A_8) || (num12 >= A_7))
                        {
                            if ((num12 >= A_8) || (num10 <= A_7))
                            {
                                return (A_4 + 1);
                            }
                            if (A_8 >= num10)
                            {
                                return -1;
                            }
                        }
                        return A_4;
                    }
                    for (int m = 0; m < strArray.Length; m++)
                    {
                        if (strArray[m].Length > num6)
                        {
                            float num5 = A_1.imethod_0(this, strArray[m]).Width;
                            if (num5 <= A_7)
                            {
                                A_4 -= num6 + 1;
                                return A_4;
                            }
                            if (((m == 0) && (num5 > A_7)) && (num5 < A_8))
                            {
                                return -1;
                            }
                            return A_4;
                        }
                        num6 -= strArray[m].Length;
                    }
                    return A_4;
                }
                if (A_3 <= 1)
                {
                    float num8 = A_1.imethod_0(this, A_0).Width;
                    float num9 = A_1.imethod_0(this, A_2).Width;
                    int num14 = (A_4 == 0) ? (A_4 + 1) : A_4;
                    float num11 = A_1.imethod_0(this, A_0.Substring(0, num14)).Width;
                    if ((A_8 - num9) > 0.5f)
                    {
                        return -1;
                    }
                    if ((num8 > A_8) && (num11 < A_7))
                    {
                        return A_4;
                    }
                    if ((num11 < A_8) && (num8 > A_7))
                    {
                        if (A_8 >= num8)
                        {
                            return -1;
                        }
                        return A_4;
                    }
                    return (A_4 + 1);
                }
                width = A_1.imethod_0(this, A_0.Substring(0, A_3)).Width;
                if (width >= A_7)
                {
                    if (width < A_8)
                    {
                        return -1;
                    }
                    if ((A_4 == 0) && !string.IsNullOrEmpty(A_0))
                    {
                        if ((A_1.imethod_0(this, A_0.Substring(0, 1)).Width > A_8) && (A_8 > 0f))
                        {
                            return 1;
                        }
                        return A_4;
                    }
                    return A_4;
                }
                for (int k = 0; k < strArray.Length; k++)
                {
                    if (strArray[k].Length > num6)
                    {
                        if (A_1.imethod_0(this, strArray[k]).Width <= A_7)
                        {
                            A_4 -= num6 + 1;
                        }
                        return A_4;
                    }
                    num6 -= strArray[k].Length;
                }
                return A_4;
            }
            if (this.method_407(A_0))
            {
                if ((A_3 <= 1) || (A_4 > 0x1a))
                {
                    SizeF ef10 = A_1.imethod_0(this, A_0);
                    SizeF ef11 = A_1.imethod_0(this, A_2);
                    if (((ef10.Width > A_7) && (ef10.Width > A_8)) || (ef11.Width > A_8))
                    {
                        return A_4;
                    }
                    return -1;
                }
                for (int n = 0; n < strArray.Length; n++)
                {
                    if (strArray[n].Length > num6)
                    {
                        SizeF ef12 = A_1.imethod_0(this, strArray[n]);
                        if ((ef12.Width <= A_7) || ((ef12.Width > A_7) && (ef12.Width < A_8)))
                        {
                            A_4 -= num6 + 1;
                        }
                        return A_4;
                    }
                    num6 -= strArray[n].Length;
                }
                return A_4;
            }
            if (A_3 <= 1)
            {
                SizeF ef6 = A_1.imethod_0(this, A_0);
                SizeF ef7 = A_1.imethod_0(this, A_2);
                if (((ef6.Width > A_7) && (ef6.Width > A_8)) || (ef7.Width > A_8))
                {
                    return A_4;
                }
                return -1;
            }
            for (int j = 0; j < strArray.Length; j++)
            {
                if (strArray[j].Length > num6)
                {
                    SizeF ef5 = A_1.imethod_0(this, strArray[j]);
                    if (ef5.Width > A_7)
                    {
                        if (ef5.Width > A_8)
                        {
                            return A_4;
                        }
                        return -1;
                    }
                    A_4 -= num6 + 1;
                }
                else
                {
                    num6 -= strArray[j].Length;
                }
            }
        }
        return A_4;
    }

    private int method_404(string A_0, int A_1)
    {
        int num = A_1;
        try
        {
            char[] chArray = A_0.Substring(0, A_1).ToCharArray();
            char[] chArray2 = A_0.Substring(A_1, A_0.Length - A_1).ToCharArray();
            for (int i = chArray.Length - 1; i < chArray.Length; i--)
            {
                num = A_0.Length - 1;
                if (!char.IsPunctuation(chArray[i]) || !Class203.smethod_2(chArray[i]))
                {
                    break;
                }
                num--;
            }
            for (int j = 0; j < chArray2.Length; j++)
            {
                if (!char.IsPunctuation(chArray2[j]) || !Class203.smethod_3(chArray2[j]))
                {
                    return num;
                }
                num++;
            }
        }
        catch (Exception)
        {
        }
        return num;
    }

    internal bool method_405(TextRange A_0)
    {
        if ((A_0.Owner != null) && (A_0.Owner is Paragraph))
        {
            return (A_0.Owner as Paragraph).IsInCell;
        }
        if (A_0.OwnerParagraph != null)
        {
            return A_0.OwnerParagraph.IsInCell;
        }
        return ((A_0.OwnerEmptyParagraph != null) && A_0.OwnerEmptyParagraph.IsInCell);
    }

    private bool method_406(TextRange A_0, SizeF A_1, float A_2)
    {
        return ((((A_0.PreviousSibling != null) && (A_0.PreviousSibling is TextRange)) && (((A_0.PreviousSibling as TextRange).interface23_0 is Class206) && (((A_0.PreviousSibling as TextRange).interface23_0 as Class206).method_21() == TabJustification.Left))) && ((((A_0.PreviousSibling as TextRange).interface23_0 as Class206).method_18() + A_1.Width) > A_2));
    }

    internal bool method_407(string A_0)
    {
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

    internal bool method_408(string A_0)
    {
        int length = A_0.Length;
        if (length == 0)
        {
            return false;
        }
        int num2 = Encoding.Default.GetBytes(A_0).Length;
        return (length != num2);
    }

    internal bool method_409(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        Regex regex = new Regex(BookmarkStart.b("焮樰㍼ᠴ銩搸Ἲ", 9));
        foreach (char ch in chArray)
        {
            if (regex.IsMatch(ch.ToString()))
            {
                return true;
            }
        }
        return false;
    }

    internal bool method_410(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        Regex regex = new Regex(BookmarkStart.b("漰栲딚ᨶ욧昺᤼", 11));
        foreach (char ch in chArray)
        {
            if (regex.IsMatch(ch.ToString()))
            {
                return true;
            }
        }
        return false;
    }

    private int method_411(string A_0, int A_1)
    {
        int num2 = A_0.Length - A_1;
        if (num2 > 0)
        {
            int num3 = A_1;
            int length = A_0.Length;
            while (num3 < length)
            {
                if (num3 == (length - 1))
                {
                    return 1;
                }
                if ((A_0[num3] == ' ') && (A_0[num3 + 1] != ' '))
                {
                    return ((num3 - A_1) + 1);
                }
                num3++;
            }
        }
        return -1;
    }

    internal RectangleF method_412(RectangleF A_0, float A_1)
    {
        if (A_0.IsEmpty)
        {
            return new RectangleF();
        }
        if ((A_1 == 0f) || (A_1 == 360f))
        {
            return A_0;
        }
        if (A_1 == -360f)
        {
            return A_0;
        }
        PointF tf = new PointF(A_0.X + (A_0.Width / 2f), A_0.Y + (A_0.Height / 2f));
        PointF tf2 = new PointF(A_0.X, A_0.Y);
        PointF tf3 = new PointF(A_0.X + A_0.Width, A_0.Y);
        PointF tf4 = new PointF(A_0.X + A_0.Width, A_0.Y + A_0.Height);
        PointF tf5 = new PointF(A_0.X, A_0.Y + A_0.Height);
        PointF tf6 = this.method_245(tf2, tf, (double) A_1);
        PointF tf7 = this.method_245(tf3, tf, (double) A_1);
        PointF tf8 = this.method_245(tf4, tf, (double) A_1);
        PointF tf9 = this.method_245(tf5, tf, (double) A_1);
        float x = Math.Min(tf6.X, Math.Min(tf7.X, Math.Min(tf8.X, tf9.X)));
        float y = Math.Min(tf6.Y, Math.Min(tf7.Y, Math.Min(tf8.Y, tf9.Y)));
        float num3 = Math.Max(tf6.X, Math.Max(tf7.X, Math.Max(tf8.X, tf9.X)));
        float num4 = Math.Max(tf6.Y, Math.Max(tf7.Y, Math.Max(tf8.Y, tf9.Y)));
        return new RectangleF(x, y, Math.Abs((float) (num3 - x)), Math.Abs((float) (num4 - y)));
    }

    private PointF method_413(PointF A_0, PointF A_1, float A_2)
    {
        float x = ((float) (((A_0.X - A_1.X) * Math.Cos((double) -A_2)) - ((A_0.Y - A_1.Y) * Math.Sin((double) -A_2)))) + A_1.X;
        return new PointF(x, ((float) (((A_0.X - A_1.X) * Math.Cos((double) -A_2)) + ((A_0.Y - A_1.Y) * Math.Sin((double) -A_2)))) + A_1.Y);
    }

    void IDisposable.Dispose()
    {
        this.vmethod_0();
        GC.SuppressFinalize(this);
    }

    protected override void System.Object.Finalize()
    {
        try
        {
            this.vmethod_0();
        }
        finally
        {
            base.System.Object.Finalize();
        }
    }

    public override void vmethod_0()
    {
        base.vmethod_0();
        if (this.bitmap_0 != null)
        {
            this.bitmap_0.Dispose();
            this.bitmap_0 = null;
        }
        if (this.graphics_0 != null)
        {
            this.graphics_0.Dispose();
            this.graphics_0 = null;
        }
        if (this.class376_0 != null)
        {
            this.class376_0.Clear();
            this.class376_0 = null;
        }
        if (this.class202_0 != null)
        {
            this.class202_0.System.IDisposable.Dispose();
            this.class202_0 = null;
        }
        if (this.interface18_0 != null)
        {
            this.interface18_0 = null;
        }
        this.paragraph_1 = null;
        this.textRange_0 = null;
        this.rectangleF_0 = RectangleF.Empty;
        this.field_0 = null;
        if (this.dictionary_7 != null)
        {
            this.dictionary_7.Clear();
            this.dictionary_7 = null;
        }
        if (this.class376_0 != null)
        {
            this.class376_0.Clear();
            this.class376_0 = null;
        }
        if (this.class202_0 != null)
        {
            this.class202_0.System.IDisposable.Dispose();
            this.class202_0 = null;
        }
        if (this.list_14 != null)
        {
            this.list_14.Clear();
            this.list_14 = null;
        }
        if (dictionary_2 != null)
        {
            dictionary_2.Clear();
            dictionary_2 = null;
        }
        if (dictionary_3 != null)
        {
            dictionary_3.Clear();
            dictionary_3 = null;
        }
        if (dictionary_4 != null)
        {
            foreach (KeyValuePair<string, Font> pair in dictionary_4)
            {
                if (pair.Value != null)
                {
                    pair.Value.Dispose();
                }
            }
            dictionary_4.Clear();
            dictionary_4 = null;
        }
    }

    internal virtual void vmethod_1(Table A_0, Class375 A_1)
    {
        if (A_0.TableFormat.CellSpacingEx > -1f)
        {
            this.method_264(A_0.TableFormat.Borders, A_1);
        }
        if (A_1.method_74().Count > 0)
        {
            (A_1.method_74().method_4(0).method_73().imethod_0() as Class211).method_125(true);
            (A_1.method_74().method_4(A_1.method_74().Count - 1).method_73().imethod_0() as Class211).method_127(true);
        }
    }

    internal virtual void vmethod_2(TableRow A_0, Class375 A_1)
    {
    }

    internal virtual void vmethod_3(TableCell A_0, Class375 A_1)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("匯圱堳娵", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尯䘱挳張尷崹夻䨽", num));
        }
        RectangleF ef2 = A_1.method_69();
        if ((A_1.method_64() == BookmarkStart.b("猯帱崳䘵䠷弹堻", num)) && (ef2.Width > 0f))
        {
            ef2.Width -= ef2.Right - A_1.method_24();
        }
        float num3 = (A_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx > 0f) ? (A_0.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f) : 0f;
        float num4 = ((float) A_1.method_73().imethod_0().imethod_1().method_4()) - num3;
        float num5 = ((float) A_1.method_73().imethod_0().imethod_1().method_12()) - num3;
        float num6 = ((float) A_1.method_73().imethod_0().imethod_1().method_0()) - num3;
        float num7 = ((float) A_1.method_73().imethod_0().imethod_1().method_8()) - num3;
        ef2 = new RectangleF(ef2.X + num6, ef2.Y + num4, (ef2.Width - num6) - num7, (ef2.Height - num4) - num5);
        if (!ef2.IsEmpty)
        {
            A_0.Bounds = ef2;
            if ((A_0.OwnerRow.OwnerTable.IsTextBox && (A_0.OwnerRow.OwnerTable.TextBoxFormat.FillEfects.ShapeType == ShapeType.TextBox)) && (A_0.OwnerRow.OwnerTable.TextBoxFormat.FillEfects.Type != BackgroundType.NoBackground))
            {
                TextBoxFormat textBoxFormat = A_0.OwnerRow.OwnerTable.TextBoxFormat;
                this.method_272(textBoxFormat.FillEfects, ef2);
            }
            else if (A_0.TextureStyle != TextureStyle.TextureNone)
            {
                this.method_278(A_0.CellFormat.TextureStyle, A_0.CellFormat.ForeColor, A_0.CellFormat.BackColor, ef2);
            }
            else
            {
                Color backColor = new Color();
                if (!A_0.CellFormat.BackColor.IsEmpty)
                {
                    backColor = A_0.CellFormat.BackColor;
                }
                if (!backColor.IsEmpty && (backColor.A != 0))
                {
                    this.method_271(backColor, ef2, A_0);
                }
            }
        }
        if (A_1.method_74().Count > 0)
        {
            for (int i = 0; i < A_1.method_74().method_4(0).method_74().Count; i++)
            {
                if (A_1.method_74().method_4(0).method_74().method_4(i).method_73() is Paragraph)
                {
                    Paragraph paragraph = A_1.method_74().method_4(0).method_74().method_4(i).method_73() as Paragraph;
                    if ((paragraph != null) && !paragraph.Format.BackColor.IsEmpty)
                    {
                        RectangleF empty = RectangleF.Empty;
                        if (paragraph.Format.IsFrame)
                        {
                            empty = A_1.method_74().method_4(0).method_74().method_4(i).method_69();
                        }
                        else
                        {
                            empty = new RectangleF(A_1.method_69().X + 0.5f, A_1.method_74().method_4(0).method_74().method_4(i).method_69().Y, A_1.method_69().Width, A_1.method_74().method_4(0).method_74().method_4(i).method_69().Height);
                        }
                        this.method_286(paragraph.Format.BackColor, empty);
                    }
                }
            }
        }
    }

    internal virtual void vmethod_4(TableCell A_0, Class375 A_1)
    {
        int num = 15;
        RectangleF ef = A_1.method_69();
        if (!ef.IsEmpty)
        {
            bool flag5;
            Borders borders = A_0.CellFormat.Borders;
            RowFormat tableFormat = A_0.OwnerRow.OwnerTable.TableFormat;
            Borders borders2 = (!A_0.OwnerRow.HasTblPrEx || (A_0.OwnerRow.RowFormat.Borders.NoBorder && !A_0.OwnerRow.RowFormat.Borders.HasBorderTypeValue)) ? tableFormat.Borders : A_0.OwnerRow.RowFormat.Borders;
            Class375 class4 = this.method_289(A_1);
            Class375 class5 = class4.method_71();
            Section section = A_0.method_2();
            bool alignBordersAndEdges = section.PageSetup.AlignBordersAndEdges;
            GraphicsState gstate = null;
            if (alignBordersAndEdges)
            {
                this.method_288(section, A_1);
                float x = (this.float_11 == float.MinValue) ? -1f : this.float_11;
                float num15 = (this.float_12 == float.MinValue) ? (this.method_134().Width + 1f) : this.float_12;
                RectangleF ef3 = new RectangleF(x, -1f, num15 - x, this.method_134().Height);
                if (base.method_1())
                {
                    this.method_126().method_4();
                    this.method_126().method_6(ef3);
                }
                else
                {
                    gstate = this.method_151().Save();
                    this.method_151().SetClip(ef3);
                }
            }
            Border bottom = null;
            bool flag10 = false;
            bool flag11 = false;
            bool flag3 = false;
            bool flag8 = A_0.OwnerRow.OwnerTable.TableFormat.CellSpacing > 0f;
            int num3 = (((Interface1) A_0).imethod_0() as Class212).method_132();
            int num8 = (((Interface1) A_0.OwnerRow).imethod_0() as Class211).method_101();
            int num17 = A_0.OwnerRow.Cells.Count - 1;
            if (A_0.OwnerRow.Cells[num17].CellFormat.HorizontalMerge == CellMerge.Continue)
            {
                for (int k = num17; k >= 0; k--)
                {
                    TableCell cell = A_0.OwnerRow.Cells[k];
                    if (cell.CellFormat.HorizontalMerge == CellMerge.Continue)
                    {
                        num17--;
                    }
                    else if (cell.CellFormat.HorizontalMerge != CellMerge.Continue)
                    {
                        break;
                    }
                }
            }
            int num18 = A_0.OwnerRow.OwnerTable.Rows.Count - 1;
            int num20 = num3;
            int num4 = num8;
            for (int i = num3 + 1; i < (num17 + 1); i++)
            {
                if (A_0.OwnerRow.Cells[i].CellFormat.HorizontalMerge != CellMerge.Continue)
                {
                    num20 = i;
                    break;
                }
            }
            for (int j = num8 + 1; j < (num18 + 1); j++)
            {
                int num11 = this.method_290(A_0, num3, j);
                if (num11 >= A_0.OwnerRow.OwnerTable.Rows[j].Cells.Count)
                {
                    num4 = j;
                    break;
                }
                if (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11].CellFormat.VerticalMerge != CellMerge.Continue)
                {
                    num4 = j;
                    break;
                }
                if ((num11 > 0) && (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11 - 1].CellFormat.Borders.Right.BorderType == BorderStyle.Cleared))
                {
                    flag11 = true;
                }
                if (((num11 < (A_0.OwnerRow.OwnerTable.Rows[j].Cells.Count - 1)) && ((A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11].CellFormat.Borders.Right.BorderType == BorderStyle.None) || (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11].CellFormat.Borders.Right.BorderType == BorderStyle.Cleared))) && ((A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11 + 1].CellFormat.Borders.Left.BorderType == BorderStyle.None) || (A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11 + 1].CellFormat.Borders.Left.BorderType == BorderStyle.Cleared)))
                {
                    flag3 = true;
                }
                if ((A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11].CellFormat.Borders.Bottom.BorderType == BorderStyle.None) && (j == num18))
                {
                    bottom = borders2.Bottom;
                }
                else
                {
                    bottom = A_0.OwnerRow.OwnerTable.Rows[j].Cells[num11].CellFormat.Borders.Bottom;
                }
                flag10 = true;
            }
            Border left = A_0.OwnerRow.Cells[num20].CellFormat.Borders.Left;
            float cellSpacingEx = tableFormat.CellSpacingEx;
            Class211 class3 = A_1.method_73().imethod_0() as Class211;
            Class212 class2 = A_1.method_73().imethod_0() as Class212;
            bool flag4 = (class5.method_73() as Interface4).imethod_3().imethod_9();
            bool flag = (class4.method_73().imethod_0() as Class211).method_124();
            bool flag7 = (class4.method_73().imethod_0() as Class211).method_126();
            bool flag6 = !class2.method_134() ? class2.method_134() : (!flag || !flag4);
            bool flag9 = !class2.method_136() ? class2.method_136() : ((!flag7 || flag) || !flag4);
            bool flag12 = class2.method_138();
            flag5 = (flag5 = class2.method_140()) & (left.BorderType != BorderStyle.Cleared);
            if (num20 == num3)
            {
                flag5 = false;
            }
            if (flag9 && flag10)
            {
                if (num4 == num8)
                {
                    flag9 = false;
                }
                else
                {
                    int num5 = this.method_290(A_0, num3, num4);
                    if ((A_0.OwnerRow.OwnerTable.Rows[num4].Cells[num5].CellFormat.Borders.Top.BorderType == BorderStyle.Cleared) && (bottom.BorderType != BorderStyle.None))
                    {
                        flag9 = false;
                    }
                }
            }
            if ((flag9 && flag10) && ((borders.Bottom.BorderType == BorderStyle.None) || (borders.Bottom.BorderType == BorderStyle.Cleared)))
            {
                flag9 &= (bottom.BorderType == BorderStyle.None) || (bottom.BorderType == BorderStyle.Cleared);
            }
            if ((A_1.method_64() == BookmarkStart.b("瘴嬶倸䬺䴼娾╀", num)) && (ef.Width > 0f))
            {
                ef.Width -= ef.Right - A_1.method_24();
                flag5 = true;
            }
            if (!flag12)
            {
                Border border4 = ((borders.Left.BorderType != BorderStyle.None) || !borders.Left.EqualsDefined) ? borders.Left : ((num3 == 0) ? (flag8 ? borders2.Vertical : borders2.Left) : ((borders.Vertical.BorderType != BorderStyle.None) ? borders.Vertical : borders2.Vertical));
                if (border4.BorderType != BorderStyle.None)
                {
                    if (((A_0.CellFormat.VerticalMerge == CellMerge.Start) && flag11) && ((num3 > 0) && (A_1.method_68().Count > 0)))
                    {
                        int num9 = num8;
                        Table ownerTable = A_0.OwnerRow.OwnerTable;
                        int num6 = 0;
                        int count = A_1.method_68().Count;
                        while (num6 < count)
                        {
                            int num22 = this.method_290(A_0, num3, num9);
                            TableRow row2 = ownerTable.Rows[num9];
                            TableCell cell1 = row2.Cells[num22 - 1];
                            RectangleF ef6 = A_1.method_68()[num6];
                            this.method_267(border4, new PointF(ef6.Left, ef6.Top), new PointF(ef6.Left, ef6.Bottom));
                            num9++;
                            num6++;
                        }
                    }
                    else
                    {
                        this.method_267(border4, new PointF(ef.Left, ef.Top), new PointF(ef.Left, ef.Bottom));
                    }
                    if (class3 is Class212)
                    {
                        (class3 as Class212).method_147(border4.LineWidth);
                        (class3 as Class212).method_155(true);
                    }
                }
            }
            if (!flag6)
            {
                Border border5 = ((borders.Top.BorderType != BorderStyle.None) || !borders.Top.EqualsDefined) ? borders.Top : (((num8 == 0) || (flag4 && flag)) ? (flag8 ? borders2.Horizontal : borders2.Top) : ((borders.Horizontal.BorderType != BorderStyle.None) ? borders.Horizontal : borders2.Horizontal));
                if (border5.BorderType != BorderStyle.None)
                {
                    this.method_267(border5, new PointF(ef.Left, ef.Top), new PointF(ef.Right, ef.Top));
                    if (class3 is Class212)
                    {
                        (class3 as Class212).method_143(border5.LineWidth);
                        (class3 as Class212).method_151(true);
                    }
                }
            }
            if (!flag5)
            {
                Border border3 = ((borders.Right.BorderType != BorderStyle.None) || !borders.Right.EqualsDefined) ? borders.Right : ((num3 == num17) ? (flag8 ? borders2.Vertical : borders2.Right) : ((borders.Vertical.BorderType != BorderStyle.None) ? borders.Vertical : borders2.Vertical));
                if (border3.BorderType != BorderStyle.None)
                {
                    if (((A_0.CellFormat.VerticalMerge == CellMerge.Start) && flag3) && ((num3 != num17) && (A_1.method_68().Count > 0)))
                    {
                        int num13 = num8;
                        Table table1 = A_0.OwnerRow.OwnerTable;
                        int num19 = 0;
                        int num21 = A_1.method_68().Count;
                        while (num19 < num21)
                        {
                            bool flag13;
                            int num14 = this.method_290(A_0, num3, num13);
                            TableRow row = A_0.OwnerRow.OwnerTable.Rows[num13];
                            if ((flag13 = ((row.Cells[num14 + 1].CellFormat.Borders.Left.BorderType == BorderStyle.Cleared) || (row.Cells[num14 + 1].CellFormat.Borders.Left.BorderType == BorderStyle.None)) ? (((row.Cells[num14 + 1].CellFormat.Borders.Left.BorderType != BorderStyle.Cleared) && (row.Cells[num14 + 1].CellFormat.Borders.Left.BorderType != BorderStyle.None)) && (row.Cells[num14].CellFormat.Borders.Right.BorderType != BorderStyle.None)) : true) || (!flag13 && (border3.BorderPosition == Border.BorderPositions.Vertical)))
                            {
                                RectangleF ef5 = A_1.method_68()[num19];
                                this.method_267(border3, new PointF(ef5.Right, ef5.Top), new PointF(ef5.Right, ef5.Bottom));
                            }
                            num13++;
                            num19++;
                        }
                    }
                    else
                    {
                        this.method_267(border3, new PointF(ef.Right, ef.Top), new PointF(ef.Right, ef.Bottom));
                    }
                    if (class3 is Class212)
                    {
                        (class3 as Class212).method_149(border3.LineWidth);
                        (class3 as Class212).method_157(true);
                    }
                }
            }
            if (!flag9)
            {
                Border border6 = flag10 ? bottom : borders.Bottom;
                border6 = ((border6.BorderType != BorderStyle.None) || !border6.EqualsDefined) ? border6 : ((((num8 == num18) || ((flag4 && !flag) && flag7)) || this.method_287(A_0, num8)) ? (flag8 ? borders2.Horizontal : borders2.Bottom) : ((borders.Horizontal.BorderType != BorderStyle.None) ? borders.Horizontal : borders2.Horizontal));
                if (border6.BorderType != BorderStyle.None)
                {
                    this.method_267(border6, new PointF(ef.Left, ef.Bottom), new PointF(ef.Right, ef.Bottom));
                    if (class3 is Class212)
                    {
                        (class3 as Class212).method_145(border6.LineWidth);
                        (class3 as Class212).method_153(true);
                    }
                }
            }
            Border border8 = (borders.DiagonalDown.BorderType != BorderStyle.None) ? borders.DiagonalDown : borders2.DiagonalDown;
            if (border8.BorderType != BorderStyle.None)
            {
                this.method_267(border8, new PointF(ef.Left, ef.Top), new PointF(ef.Right, ef.Bottom));
            }
            Border border2 = (borders.DiagonalUp.BorderType != BorderStyle.None) ? borders.DiagonalUp : borders2.DiagonalUp;
            if (border2.BorderType != BorderStyle.None)
            {
                this.method_267(border2, new PointF(ef.Left, ef.Bottom), new PointF(ef.Right, ef.Top));
            }
            if (alignBordersAndEdges)
            {
                if (base.method_1())
                {
                    this.method_126().method_7();
                    this.method_126().method_5();
                }
                else if (gstate != null)
                {
                    this.method_151().ResetClip();
                    this.method_151().Restore(gstate);
                }
            }
        }
    }

    internal class Form0 : RowFormat
    {
        public Form0(RowFormat A_0)
        {
            this.method_67(base.Borders.Horizontal, A_0.Borders.Horizontal);
            this.method_67(base.Borders.Vertical, A_0.Borders.Vertical);
        }

        public Border method_65()
        {
            return base.Borders.Vertical;
        }

        public Border method_66()
        {
            return base.Borders.Horizontal;
        }

        private void method_67(Border A_0, Border A_1)
        {
            A_0.BorderType = A_1.BorderType;
            A_0.Color = A_1.Color;
            A_0.LineWidth = A_1.LineWidth;
            A_0.Shadow = A_1.Shadow;
            A_0.Space = A_1.Space;
            A_0.HasNoneStyle = A_1.HasNoneStyle;
        }
    }
}

