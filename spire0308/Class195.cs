using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Rendering;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class195 : IDisposable, Interface18
{
    private BookmarkLevel bookmarkLevel_0;
    private bool bool_0 = true;
    private bool bool_1;
    [ThreadStatic]
    internal static bool bool_10 = true;
    protected bool bool_11;
    protected bool bool_12;
    protected bool bool_13;
    protected bool bool_14;
    private bool bool_15;
    internal bool bool_2;
    private bool bool_3 = true;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    internal bool bool_8;
    internal bool bool_9;
    private Class196 class196_0;
    private Class197 class197_0;
    private Class197 class197_1;
    private Class497 class497_0 = new Class497();
    private Class499 class499_0 = new Class499();
    private Class500 class500_0;
    private Dictionary<Paragraph, int> dictionary_0;
    internal Dictionary<string, int> dictionary_1 = new Dictionary<string, int>();
    private float float_0;
    private float float_1;
    private float float_2;
    private float float_3;
    private float float_4;
    private float float_5;
    private float float_6;
    private ImageType imageType_0 = ImageType.Metafile;
    internal const int int_0 = 300;
    private int int_1;
    private int int_2;
    private int int_3 = 0x60;
    private int int_4 = -1;
    private int int_5;
    private Interface3 interface3_0;
    private ISection isection_0;
    private List<HeaderFooter> list_0 = new List<HeaderFooter>();
    private List<float> list_1 = new List<float>();
    private List<Dictionary<string, Class310>> list_10 = new List<Dictionary<string, Class310>>();
    private List<BookmarkLevel> list_11 = new List<BookmarkLevel>();
    private List<float> list_2 = new List<float>();
    private List<bool> list_3 = new List<bool>();
    private List<float> list_4 = new List<float>();
    private List<RectangleF> list_5;
    private List<TextWrappingStyle> list_6;
    private List<float> list_7;
    private List<int> list_8;
    private List<int> list_9;
    internal const long long_0 = 0xa00000L;
    protected bool? nullable_0;
    private Paragraph paragraph_0;
    private PointF pointF_0 = new PointF();
    private ToPdfParameterList toPdfParameterList_0 = new ToPdfParameterList();

    public Class195()
    {
        this.class197_0 = new Class197(this, false);
        this.class197_1 = new Class197(this, true);
    }

    private bool imethod_1(out RectangleF A_0, out RectangleF A_1, ref int A_2, ref bool A_3, bool A_4)
    {
        bool flag2;
        int count = this.method_31().Columns.Count;
        if (!A_4)
        {
            this.int_1 = 0;
            this.float_0 = 0f;
        }
        bool flag = false;
        flag2 = (flag2 = (count == 0) && (this.int_1 > 0)) || ((count > 0) && (this.int_1 > (count - 1)));
        bool flag3 = this.method_73(ref flag);
        flag2 = flag2 || flag3;
        this.method_76();
        if ((flag2 && ((this.float_2 == this.float_3) || (!A_3 && !flag))) || this.bool_5)
        {
            this.method_70();
            this.method_78();
            this.method_94();
        }
        A_0 = this.method_28().method_86();
        A_1 = this.method_92(A_4);
        A_3 = this.method_99(A_3);
        if (((A_3 && !this.bool_6) && ((this.method_31().Columns.Count > 1) && (this.int_1 == 0))) && ((A_4 && !this.method_31().PageSetup.EqualColumnWidth) && !this.method_98()))
        {
            float num2 = 0f;
            for (int i = 0; i < this.method_31().Columns.Count; i++)
            {
                num2 += this.method_31().Columns[i].Width;
            }
            A_1.Width = num2;
            this.float_1 = num2;
        }
        if (this.bool_6)
        {
            if (this.int_1 == 0)
            {
                this.float_5 = this.method_95();
            }
            A_3 = false;
            if (A_1.Height > this.float_5)
            {
                A_1.Height = this.float_5;
            }
        }
        this.pointF_0 = A_1.Location;
        A_2 = this.int_1;
        this.int_1++;
        return !A_1.Equals(RectangleF.Empty);
    }

    private bool imethod_4(Class65 A_0, LayoutState A_1, Class375 A_2, ref bool A_3)
    {
        bool flag;
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弫娭术嬱倳儵崷丹缻儽⸿㙁╃⽅♇⽉㹋", num));
        }
        if (A_0.Interface3.imethod_3() < 1)
        {
            throw new DLSException(BookmarkStart.b("缫席尯嬱䀳ᘵ伷匹堻夽┿㙁摃╅❇⑉㡋⽍㥏㱑ㅓ⑕硗牙㡛ㅝ͟ᝡॣͥ٧ṩ䕫乭ᵯݱݳɵ塷᥹፻ၽﮇꪉ揄낏ﺑ몙얟芡잣캥솧용좫躭햯\udeb1\ud1b3\udbb5\uddb7풹좻龽", num));
        }
        Interface1 interface2 = A_0.imethod_4(0);
        ISection section = interface2 as ISection;
        if (section == null)
        {
            Class65 class2 = interface2 as Class65;
            if (class2 != null)
            {
                section = class2.method_2() as ISection;
            }
        }
        if ((!(flag = this.method_104(section, A_2, A_3)) && (section != null)) && A_3)
        {
            return false;
        }
        if (section == null)
        {
            Class65 class3 = interface2 as Class65;
            if (class3 != null)
            {
                section = class3.method_2() as ISection;
            }
        }
        A_3 = this.method_105(A_2, A_3, flag);
        if (section == null)
        {
            throw new DLSException(BookmarkStart.b("漫䘭夯帱倳ᘵ圷尹᰻洽〿⹁ⵃ㉅὇⍉⡋⥍㕏♑ᝓ㥕㙗⹙㵛㝝๟ݡᙣ䙥ݧࡩ٫୭፯ٱ味ᕵ᥷ᑹ孻੽ꁿﺋ揄낏\udb91\uc793ﮗ肟쮡쪣튥춧\ud8a9\ucaab쾭펯ힱ閳", num));
        }
        if (this.isection_0 != section)
        {
            this.method_102(this.class499_0.Count - (this.isection_0 as Interface1).imethod_0().imethod_52());
            this.isection_0 = section;
            (this.isection_0 as Interface1).imethod_0().imethod_45(false);
            (this.isection_0 as Interface1).imethod_0().imethod_47(false);
            (this.isection_0 as Interface1).imethod_0().imethod_49(false);
            this.method_82();
            this.method_103(false, 0);
            this.bool_15 = true;
        }
        else
        {
            this.bool_15 = false;
        }
        return true;
    }

    Class195 Interface18.imethod_0()
    {
        return this;
    }

    void Interface18.imethod_2(Class375 A_0)
    {
        this.method_100(A_0);
        this.method_28().method_3().method_7(A_0);
    }

    void Interface18.imethod_3(Class375 A_0)
    {
        this.float_4 += A_0.method_69().Height;
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            this.method_107(A_0.method_74().method_4(i));
        }
    }

    public Class499 method_0()
    {
        return this.class499_0;
    }

    internal bool method_1()
    {
        if (!this.nullable_0.HasValue && (this.toPdfParameterList_0 != null))
        {
            return this.toPdfParameterList_0.UsePSCoversion;
        }
        return this.nullable_0.Value;
    }

    internal void method_10(List<Dictionary<string, Class310>> A_0)
    {
        this.list_10 = A_0;
    }

    private void method_100(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class375 class3 = A_0.method_74().method_4(i);
            if (((class3 != null) && ((class3.method_73() is Section) || ((class3.method_73() is Class65) && ((class3.method_73() as Class65).method_2() is Section)))) && (class3.method_74().Count > 0))
            {
                Class375 class2 = class3.method_74().method_4(class3.method_74().Count - 1);
                if ((class2.method_73() is Table) && (class2.method_74().Count > 0))
                {
                    Class375 class4 = class2.method_74().method_4(class2.method_74().Count - 1);
                    this.method_101(class4);
                }
            }
        }
    }

    private void method_101(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class375 class2 = A_0.method_74().method_4(i);
            if ((class2 != null) && (class2.method_73() is TableCell))
            {
                (A_0.method_74().method_4(i).method_73().imethod_0() as Class212).method_137(false);
            }
        }
    }

    private void method_102(int A_0)
    {
        for (int i = A_0; i < this.class499_0.Count; i++)
        {
            this.class499_0[i].method_74((this.isection_0 as Interface1).imethod_0().imethod_52(), true);
        }
    }

    private void method_103(bool A_0, int A_1)
    {
        FootEndnoteOptions footnoteOptions = null;
        if (A_0)
        {
            footnoteOptions = (this.method_31() as Section).FootnoteOptions;
            footnoteOptions.ApplyBase((this.interface3_0 as Document).FootnoteOptions);
            if (footnoteOptions.RestartRule == FootnoteRestartRule.RestartSection)
            {
                this.class500_0.method_7(0);
            }
            else if (footnoteOptions.RestartRule != FootnoteRestartRule.RestartPage)
            {
                this.class500_0.method_7(A_1);
            }
        }
        else
        {
            footnoteOptions = (this.method_31() as Section).EndnoteOptions;
            footnoteOptions.ApplyBase((this.interface3_0 as Document).EndnoteOptions);
            if (footnoteOptions.RestartRule == FootnoteRestartRule.RestartSection)
            {
                this.class500_0.method_12(0);
            }
        }
    }

    private bool method_104(ISection A_0, Class375 A_1, bool A_2)
    {
        bool flag = false;
        if ((A_0 != null) && A_2)
        {
            A_2 = false;
            this.bool_6 = true;
            float item = this.float_0;
            this.int_1 = 0;
            this.float_0 = 0f;
            for (int i = 0; i < this.list_3.Count; i++)
            {
                if (this.list_3[i])
                {
                    this.int_1 = i + 1;
                    this.float_0 = this.list_4[i];
                    A_2 = true;
                    flag = true;
                }
            }
            if (flag)
            {
                this.list_2.Insert(this.list_2.Count, A_1.method_69().Height);
                this.list_3.Insert(this.list_3.Count, false);
                this.list_4.Insert(this.list_4.Count, item);
                this.method_106();
            }
        }
        return flag;
    }

    private bool method_105(Class375 A_0, bool A_1, bool A_2)
    {
        if (((this.method_28().method_3().Count >= 2) && A_1) && !this.bool_6)
        {
            A_1 = false;
            Class375 class2 = A_0;
            while (class2.method_74().Count != 0)
            {
                class2 = class2.method_74().method_4(class2.method_74().Count - 1);
            }
            if (class2.method_73() is Break)
            {
                if (((class2.method_73() as Break).BreakType == BreakType.PageBreak) || ((class2.method_73() as Break).BreakType == BreakType.ColumnBreak))
                {
                    A_1 = true;
                    this.list_2.Insert(this.int_1 - 1, A_0.method_69().Height);
                    this.list_3.Insert(this.int_1 - 1, true);
                    this.list_4.Insert(this.int_1 - 1, this.float_0);
                    this.bool_5 = (class2.method_73() as Break).BreakType == BreakType.PageBreak;
                }
                return A_1;
            }
            this.list_2.Insert(this.int_1 - 1, A_0.method_69().Height);
            this.list_3.Insert(this.int_1 - 1, false);
            this.list_4.Insert(this.int_1 - 1, this.float_0);
            return A_1;
        }
        if (!A_2)
        {
            A_1 = false;
        }
        return A_1;
    }

    private void method_106()
    {
        this.float_5 = 0f;
        foreach (float num in this.list_2)
        {
            this.float_5 = Math.Max(this.float_5, Math.Min(this.float_3, num));
        }
        if (((this.float_2 + this.float_5) + 10f) >= this.float_3)
        {
            this.bool_5 = true;
        }
    }

    private void method_107(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class375 class2 = A_0.method_74().method_4(i);
            if ((class2.method_73() is Paragraph) || (class2.method_73() is Table))
            {
                if ((class2.method_73() is Table) && (class2.method_73() as Interface4).imethod_3().imethod_13())
                {
                    if (this.list_7 == null)
                    {
                        this.list_7 = new List<float>();
                    }
                    this.list_7.Add(class2.method_69().Height);
                }
                else
                {
                    for (int j = 0; j < class2.method_74().Count; j++)
                    {
                        this.list_1.Insert(this.list_1.Count, class2.method_74().method_4(j).method_69().Height);
                    }
                }
            }
        }
    }

    private int method_108()
    {
        int num = 0;
        float width = this.method_31().Columns[0].Width;
        for (int i = 1; i < this.method_31().Columns.Count; i++)
        {
            if (this.method_31().Columns[i].Width < width)
            {
                num = i;
                width = this.method_31().Columns[i].Width;
            }
        }
        return num;
    }

    private int method_109()
    {
        int num = 0;
        float width = this.method_31().Columns[0].Width;
        for (int i = 1; i < this.method_31().Columns.Count; i++)
        {
            if (this.method_31().Columns[i].Width > width)
            {
                num = i;
                width = this.method_31().Columns[i].Width;
            }
        }
        return num;
    }

    internal List<BookmarkLevel> method_11()
    {
        return this.list_11;
    }

    internal bool method_110(out RectangleF A_0, out RectangleF A_1)
    {
        if (this.method_31().HeadersFooters.LinkToPrevious)
        {
            this.method_31();
            PageSetup setup = null;
            A_1 = (this.method_28().method_3().Count != 0) ? RectangleF.Empty : ((setup != null) ? this.method_28().method_82(setup) : this.method_28().method_81());
        }
        else
        {
            A_1 = (this.method_28().method_3().Count != 0) ? RectangleF.Empty : this.method_28().method_81();
        }
        A_0 = (this.method_28().method_3().Count != 0) ? RectangleF.Empty : this.method_28().method_83();
        return !A_1.Equals(RectangleF.Empty);
    }

    internal void method_111(Class375 A_0)
    {
        this.method_28().method_3().method_7(A_0);
        RectangleF ef = A_0.method_69();
        if (Class59.smethod_4(ef.Bottom, this.method_28().method_28().PageSize.Height - this.method_28().method_28().Margins.Bottom, 0.005f) > 0)
        {
            A_0.method_70(new RectangleF(ef.Location, new SizeF(ef.Width, this.method_112(A_0))));
        }
    }

    private float method_112(Class375 A_0)
    {
        float num = 0f;
        if (A_0 != null)
        {
            if (Class59.smethod_4(A_0.method_69().Bottom, this.method_28().method_28().PageSize.Height - this.method_28().method_28().Margins.Bottom, 0.005f) <= 0)
            {
                return num;
            }
            foreach (Class375 class2 in A_0.method_74())
            {
                RectangleF ef = class2.method_69();
                if (Class59.smethod_4(ef.Bottom, this.method_28().method_28().PageSize.Height - this.method_28().method_28().Margins.Bottom, 0.005f) >= 0)
                {
                    return num;
                }
                num += ef.Height;
            }
        }
        return num;
    }

    internal bool method_113(out RectangleF A_0, out RectangleF A_1)
    {
        if (this.method_31().HeadersFooters.LinkToPrevious)
        {
            this.method_31();
            PageSetup setup = null;
            A_1 = (this.method_28().method_3().Count != 1) ? RectangleF.Empty : ((setup != null) ? this.method_28().method_85(setup) : this.method_28().method_84());
        }
        else
        {
            A_1 = (this.method_28().method_3().Count != 1) ? RectangleF.Empty : this.method_28().method_84();
        }
        A_0 = (this.method_28().method_3().Count != 1) ? RectangleF.Empty : this.method_28().method_86();
        return !A_1.Equals(RectangleF.Empty);
    }

    internal void method_114(Class375 A_0)
    {
        this.method_120(A_0);
        float num = -A_0.method_69().Height;
        A_0.method_94(0.0, (double) num, true);
        A_0.method_101(this.method_28().method_28());
        this.method_28().method_3().method_7(A_0);
        this.method_119(A_0);
        this.method_117(num);
        if (this.method_28().method_8() < 12)
        {
            float top = A_0.method_69().Top;
            float footerDistance = this.method_28().method_28().FooterDistance;
            Dictionary<DocPicture, RectangleF> dictionary = new Dictionary<DocPicture, RectangleF>();
            this.method_115(A_0, top, footerDistance, dictionary);
            this.method_116(dictionary);
            dictionary = null;
        }
    }

    private void method_115(Class375 A_0, float A_1, float A_2, Dictionary<DocPicture, RectangleF> A_3)
    {
        if (A_0 != null)
        {
            if (A_3 == null)
            {
                A_3 = new Dictionary<DocPicture, RectangleF>();
            }
            for (int i = 0; i < A_0.method_74().Count; i++)
            {
                Class375 class2 = A_0.method_74().method_4(i);
                if (class2 != null)
                {
                    if (class2.method_73() is DocPicture)
                    {
                        DocPicture key = class2.method_73() as DocPicture;
                        if ((((key.TextWrappingStyle != TextWrappingStyle.Behind) && (key.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (key.TextWrappingStyle != TextWrappingStyle.Inline)) && ((key.VerticalOrigin == VerticalOrigin.Line) || (key.VerticalOrigin == VerticalOrigin.Paragraph)))
                        {
                            RectangleF ef = class2.method_69();
                            float y = Math.Min(ef.Y, (A_1 + A_2) - ef.Height);
                            class2.method_70(new RectangleF(new PointF(ef.X, y), ef.Size));
                            ef = class2.method_69();
                            if (!A_3.ContainsKey(key))
                            {
                                A_3.Add(key, new RectangleF(ef.X - key.WrapDistanceLeft, ef.Y - key.WrapDistanceTop, (ef.Width + key.WrapDistanceLeft) + key.WrapDistanceRight, (ef.Height + key.WrapDistanceBottom) + key.WrapDistanceTop));
                            }
                        }
                    }
                    else if ((class2.method_73() is Paragraph) && (class2.method_73() as Paragraph).Format.IsFrame)
                    {
                        Paragraph paragraph = class2.method_73() as Paragraph;
                        if (paragraph.Format.FrameVerticalAnchor == FrameVertAnchor.Text)
                        {
                            RectangleF ef2 = class2.method_69();
                            float num3 = Math.Min(ef2.Y, (A_1 + A_2) - ef2.Height) - class2.method_69().Y;
                            if (num3 != 0f)
                            {
                                class2.method_94(0.0, (double) num3, false);
                            }
                        }
                    }
                    this.method_115(class2, A_1, A_2, A_3);
                }
            }
        }
    }

    private void method_116(Dictionary<DocPicture, RectangleF> A_0)
    {
        if ((this.method_28().method_21().Count > 0) && ((A_0 != null) && (A_0.Count > 0)))
        {
            foreach (Class312 class2 in this.method_28().method_21())
            {
                if (class2.method_22())
                {
                    Interface1 interface2 = class2.method_4();
                    if (interface2 is DocPicture)
                    {
                        DocPicture key = interface2 as DocPicture;
                        if (A_0.ContainsKey(key))
                        {
                            RectangleF ef = A_0[key];
                            class2.method_1(new RectangleF(ef.Location, ef.Size));
                            class2.method_9(null);
                        }
                    }
                }
            }
        }
    }

    private void method_117(float A_0)
    {
        if (this.method_28().method_21().Count > 0)
        {
            foreach (Class312 class2 in this.method_28().method_21())
            {
                if (class2.method_22())
                {
                    Interface1 interface2 = class2.method_4();
                    if (interface2 is Table)
                    {
                        Table table = interface2 as Table;
                        if (((Interface4) table).imethod_3().imethod_13() && (((Interface4) table).imethod_3().imethod_15().VertRelationTo == VerticalRelation.Paragraph))
                        {
                            this.method_118(class2, A_0);
                        }
                    }
                    else if (interface2 is DocPicture)
                    {
                        DocPicture picture = interface2 as DocPicture;
                        if ((picture.TextWrappingStyle != TextWrappingStyle.Inline) && (((picture.VerticalOrigin == VerticalOrigin.Paragraph) || (picture.VerticalOrigin == VerticalOrigin.Line)) || (picture.VerticalOrigin == VerticalOrigin.BottomMarginArea)))
                        {
                            this.method_118(class2, A_0);
                        }
                    }
                }
            }
        }
    }

    private void method_118(Class312 A_0, float A_1)
    {
        if (A_0 != null)
        {
            RectangleF ef = A_0.method_0();
            A_0.method_1(new RectangleF(new PointF(ef.X, ef.Y + A_1), ef.Size));
            A_0.method_9(null);
        }
    }

    private void method_119(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class375 class2 = A_0.method_74().method_4(i);
            if (((class2.method_73() is DocPicture) && ((class2.method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline)) && (((class2.method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind) && ((class2.method_73() as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText)))
            {
                DocPicture picture = class2.method_73() as DocPicture;
                float num2 = (picture.Height * picture.HeightScale) / 100f;
                if ((class2.method_69().Y + num2) > this.method_28().method_28().PageSize.Height)
                {
                    class2.method_70(new RectangleF(class2.method_69().X, this.method_28().method_28().PageSize.Height - num2, class2.method_69().Width, class2.method_69().Height));
                }
                else if ((class2.method_69().Y < 0f) || (num2 > this.method_28().method_28().PageSize.Height))
                {
                    class2.method_70(new RectangleF(class2.method_69().X, 0f, class2.method_69().Width, class2.method_69().Height));
                }
            }
            else
            {
                this.method_119(class2);
            }
        }
    }

    internal void method_12(List<BookmarkLevel> A_0)
    {
        this.list_11 = A_0;
    }

    internal void method_120(Class375 A_0)
    {
        for (int i = 0; i < A_0.method_74().Count; i++)
        {
            Class375 class2 = A_0.method_74().method_4(i);
            if (class2 != null)
            {
                if (class2.method_73() is Table)
                {
                    Table table = class2.method_73() as Table;
                    if (table.TableFormat.WrapTextAround)
                    {
                        table.TableFormat.method_53(false);
                    }
                    if (table.IsTextBox && (table.TextBoxFormat.TextWrappingStyle == TextWrappingStyle.InFrontOfText))
                    {
                        table.TableFormat.method_53(false);
                    }
                }
                if (A_0.method_73() is DocPicture)
                {
                    DocPicture picture = class2.method_73() as DocPicture;
                    if (picture.TextWrappingStyle != TextWrappingStyle.Inline)
                    {
                        picture.TextWrappingStyle = TextWrappingStyle.Square;
                    }
                }
                this.method_120(class2);
            }
        }
    }

    internal BookmarkLevel method_13()
    {
        return this.bookmarkLevel_0;
    }

    internal void method_14(BookmarkLevel A_0)
    {
        this.bookmarkLevel_0 = A_0;
    }

    private spr᮵ method_15()
    {
        return spr᮵.ᜂ();
    }

    internal int method_16()
    {
        return this.int_5;
    }

    internal void method_17(int A_0)
    {
        this.int_5 = A_0;
    }

    internal int method_18()
    {
        return this.method_0().Count;
    }

    internal ToPdfParameterList method_19()
    {
        if (this.toPdfParameterList_0 == null)
        {
            this.toPdfParameterList_0 = new ToPdfParameterList();
        }
        return this.toPdfParameterList_0;
    }

    internal void method_2(bool A_0)
    {
        this.nullable_0 = new bool?(A_0);
    }

    internal void method_20(ToPdfParameterList A_0)
    {
        this.toPdfParameterList_0 = A_0;
    }

    public int method_21()
    {
        return this.int_1;
    }

    public void method_22(int A_0)
    {
        this.int_1 = A_0;
    }

    internal PointF method_23()
    {
        return this.pointF_0;
    }

    internal void method_24(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    internal float method_25()
    {
        return this.float_3;
    }

    internal float method_26()
    {
        return this.float_0;
    }

    internal void method_27(float A_0)
    {
        this.float_0 = A_0;
    }

    internal Class500 method_28()
    {
        return this.class500_0;
    }

    internal ImageType method_29()
    {
        return this.imageType_0;
    }

    internal bool method_3()
    {
        return this.bool_11;
    }

    internal void method_30(ImageType A_0)
    {
        this.imageType_0 = A_0;
    }

    internal ISection method_31()
    {
        return this.isection_0;
    }

    internal Column method_32()
    {
        if (this.method_31().Columns.Count != 0)
        {
            return this.method_31().Columns[this.int_1];
        }
        return null;
    }

    protected bool method_33()
    {
        return ((this.int_2 % 2) == 0);
    }

    public Class497 method_34()
    {
        return this.class497_0;
    }

    internal Document method_35()
    {
        return (this.interface3_0 as Document);
    }

    internal void method_36(bool A_0)
    {
        this.bool_5 = A_0;
    }

    internal List<int> method_37()
    {
        if (this.list_8 == null)
        {
            this.list_8 = new List<int>();
        }
        return this.list_8;
    }

    internal void method_38(List<int> A_0)
    {
        this.list_8 = A_0;
    }

    internal List<int> method_39()
    {
        if (this.list_9 == null)
        {
            this.list_9 = new List<int>();
        }
        return this.list_9;
    }

    internal void method_4(bool A_0)
    {
        this.bool_11 = A_0;
    }

    internal Dictionary<Paragraph, int> method_40()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<Paragraph, int>();
        }
        return this.dictionary_0;
    }

    internal bool method_41()
    {
        return this.bool_7;
    }

    internal void method_42(bool A_0)
    {
        this.bool_7 = A_0;
    }

    public Class499 method_43(IDocument A_0)
    {
        int num = 0x13;
        this.interface3_0 = A_0 as Interface3;
        if (this.interface3_0 == null)
        {
            throw new DLSException(BookmarkStart.b("紸吺帼䨾ⱀ♂⭄㍆楈⡊ⱌⅎ癐❒畔⑖ⱘ⭚ⵜぞ፠ᝢ䕤፦ŨɪṬ佮ᡰᵲŴቶ୸ᵺᱼ᱾", num));
        }
        if (A_0.Sections.Count < 1)
        {
            return null;
        }
        (A_0 as Document).DocLayoter = this;
        (A_0 as Document).bool_23 = this.method_19().UsePSCoversion;
        this.isection_0 = A_0.Sections[0];
        (this.isection_0 as Interface1).imethod_0().imethod_53(0);
        this.method_45();
        bool_10 = true;
        if (!this.method_64())
        {
            this.bool_0 = true;
            bool_10 = false;
            int num2 = 0;
            int count = this.class499_0.Count;
            while (num2 < count)
            {
                Class500 class2 = this.class499_0[num2];
                class2.method_73(count);
                class2.method_75((A_0 as Document).DocLayoter);
                num2++;
            }
        }
        (A_0 as Document).DocLayoter = null;
        return this.class499_0;
    }

    internal Class499 method_44(IDocument A_0)
    {
        int num = 0x13;
        this.interface3_0 = A_0 as Interface3;
        if (this.interface3_0 == null)
        {
            throw new DLSException(BookmarkStart.b("紸吺帼䨾ⱀ♂⭄㍆楈⡊ⱌⅎ癐❒畔⑖ⱘ⭚ⵜぞ፠ᝢ䕤፦ŨɪṬ佮ᡰᵲŴቶ୸ᵺᱼ᱾", num));
        }
        if (A_0.Sections.Count < 1)
        {
            return null;
        }
        (A_0 as Document).DocLayoter = this;
        (A_0 as Document).bool_23 = this.method_19().UsePSCoversion;
        this.isection_0 = A_0.Sections[0];
        (this.isection_0 as Interface1).imethod_0().imethod_53(0);
        this.method_45();
        bool_10 = true;
        if (!this.method_64())
        {
            this.bool_0 = true;
            bool_10 = false;
            int num2 = 0;
            int count = this.class499_0.Count;
            while (num2 < count)
            {
                this.class499_0[num2].method_73(count);
                num2++;
            }
        }
        (A_0 as Document).DocLayoter = null;
        return this.class499_0;
    }

    internal void method_45()
    {
        int num = 5;
        spr᮵.ᜃ = true;
        this.method_19().PrivateFontList.Clear();
        foreach (PrivateFontPath path in this.method_19().PrivateFontPaths)
        {
            if (File.Exists(path.FontPath))
            {
                PrivateFontCollection fonts2 = new PrivateFontCollection();
                fonts2.AddFontFile(path.FontPath);
                if ((fonts2.Families.Length > 0) && !string.IsNullOrEmpty(path.FontName))
                {
                    Struct10 struct3 = new Struct10();
                    struct3.method_1(path.FontPath);
                    struct3.method_5(fonts2);
                    this.method_19().PrivateFontList.Add(path.FontName.ToLower() + this.method_48(path.FontStyle), struct3);
                    this.method_46(path.FontPath);
                }
            }
        }
        if (this.interface3_0 is Document)
        {
            using (IEnumerator enumerator2 = (this.interface3_0 as Document).FontInfoList.System.Collections.IEnumerable.GetEnumerator())
            {
                while (enumerator2.MoveNext())
                {
                    Form4 current = (Form4) enumerator2.Current;
                    Class827[] classArray2 = current.method_53();
                    if (classArray2 != null)
                    {
                        foreach (Class827 class2 in classArray2)
                        {
                            if (class2 != null)
                            {
                                PrivateFontCollection fonts = new PrivateFontCollection();
                                class2.method_7(fonts);
                                if (fonts.Families.Length > 0)
                                {
                                    string key = current.method_31().ToLower() + ((class2.method_2() != EmbeddedFontStyle.Regular) ? (BookmarkStart.b("ܪ", num) + class2.method_2().ToString().ToLower()) : string.Empty);
                                    Struct10 struct2 = new Struct10();
                                    struct2.method_5(fonts);
                                    struct2.method_3(new MemoryStream(class2.method_0()));
                                    this.method_19().PrivateFontList.Add(key, struct2);
                                    this.method_47(class2.method_0());
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void method_46(string A_0)
    {
        if (!string.IsNullOrEmpty(A_0))
        {
            this.method_15().ᜂ(A_0);
        }
    }

    private void method_47(byte[] A_0)
    {
        if (A_0 != null)
        {
            this.method_15().ᜀ(A_0);
        }
    }

    private string method_48(FontStyle A_0)
    {
        int num = 13;
        if (((A_0 & FontStyle.Bold) == FontStyle.Bold) && ((A_0 & FontStyle.Italic) == FontStyle.Italic))
        {
            return BookmarkStart.b("ἲ圴堶唸强吼䬾⁀⽂ⱄ⑆", num);
        }
        if ((A_0 & FontStyle.Bold) == FontStyle.Bold)
        {
            return BookmarkStart.b("ἲ圴堶唸强", num);
        }
        if ((A_0 & FontStyle.Italic) == FontStyle.Italic)
        {
            return BookmarkStart.b("ἲ尴䌶堸场吼尾", num);
        }
        return string.Empty;
    }

    public Image[] method_49(int A_0, int A_1, ImageType A_2, MemoryStream A_3, bool A_4)
    {
        return this.method_57(A_0, A_1, A_2, A_3, A_4, true, false);
    }

    internal bool method_5()
    {
        return this.bool_12;
    }

    internal void method_50(ImageType A_0)
    {
        int count = this.class499_0.Count;
        SizeF[] efArray = this.method_55();
        for (int i = 0; i < count; i++)
        {
            List<Dictionary<string, RectangleF>> list = new List<Dictionary<string, RectangleF>>();
            List<Dictionary<string, Class310>> list2 = new List<Dictionary<string, Class310>>();
            this.method_17(i + 1);
            float width = this.class499_0[i].method_28().PageSize.Width;
            float height = this.class499_0[i].method_28().PageSize.Height;
            if (A_0 == ImageType.Metafile)
            {
                MemoryStream stream = new MemoryStream();
                Image image = this.method_87(this.class499_0[i].method_28(), A_0, stream, this.int_3);
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.PageUnit = GraphicsUnit.Point;
                    graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, (int) width, (int) height));
                    using (Class196 class2 = new Class196(graphics, GraphicsUnit.Point, new SizeF(width, height)))
                    {
                        class2.method_142(true);
                        class2.method_17(i + 1);
                        class2.method_146(this.method_9());
                        class2.method_148(this.method_11());
                        class2.method_150(this.method_13());
                        class2.method_20(this.method_19());
                        this.class499_0[i].method_68(class2);
                        if (this.bool_2)
                        {
                            class2.method_156();
                        }
                        list = class2.method_153();
                        list2 = class2.method_145();
                        this.method_12(class2.method_147());
                        this.method_10(class2.method_145());
                        this.method_14(class2.method_149());
                    }
                }
                this.method_56(i, efArray, image, list, list2, count, this.class499_0);
            }
        }
        this.method_51();
    }

    internal void method_51()
    {
        this.method_66();
        this.method_67();
        this.method_68();
        this.method_69();
    }

    internal void method_52()
    {
        int count = this.class499_0.Count;
        SizeF[] efArray = this.method_55();
        for (int i = 0; i < count; i++)
        {
            this.method_17(i + 1);
            float width = this.class499_0[i].method_28().PageSize.Width;
            float height = this.class499_0[i].method_28().PageSize.Height;
            this.method_56(i, efArray, null, null, null, count, this.class499_0);
        }
    }

    internal void method_53(Class500 A_0, Graphics A_1, int A_2)
    {
        new List<Dictionary<string, RectangleF>>();
        new List<Dictionary<string, Class310>>();
        float width = A_0.method_28().PageSize.Width;
        float height = A_0.method_28().PageSize.Height;
        A_1.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        A_1.FillRectangle(Brushes.White, new Rectangle(0, 0, (int) width, (int) height));
        using (Class196 class2 = new Class196(A_1, GraphicsUnit.Point, new SizeF(width, height)))
        {
            class2.method_142(true);
            class2.method_144(true);
            class2.method_17(A_2);
            class2.method_146(this.method_9());
            class2.method_148(this.method_11());
            class2.method_150(this.method_13());
            class2.method_20(this.method_19());
            A_0.method_68(class2);
            if (this.bool_2)
            {
                class2.method_156();
            }
            class2.method_153();
            class2.method_145();
            this.method_12(class2.method_147());
            this.method_10(class2.method_145());
            this.method_14(class2.method_149());
        }
    }

    internal void method_54()
    {
        this.method_51();
    }

    private SizeF[] method_55()
    {
        int count = this.class499_0.Count;
        SizeF[] efArray = new SizeF[count];
        for (int i = 0; i < count; i++)
        {
            efArray[i] = this.class499_0[i].method_28().PageSize;
        }
        return efArray;
    }

    private void method_56(int A_0, SizeF[] A_1, Image A_2, List<Dictionary<string, RectangleF>> A_3, List<Dictionary<string, Class310>> A_4, int A_5, Class499 A_6)
    {
        if (this.interface3_0 is Document)
        {
            Class309 class2 = new Class309();
            class2.method_1(A_0);
            class2.method_3(A_1);
            class2.method_5(A_2);
            class2.method_7(A_4);
            class2.method_9(A_3);
            class2.method_11(A_5);
            class2.method_13(A_6);
            (this.interface3_0 as Document).method_23(class2);
        }
    }

    internal Image[] method_57(int A_0, int A_1, ImageType A_2, MemoryStream A_3, bool A_4, bool A_5, bool A_6)
    {
        if ((this.class499_0.Count < A_0) || (A_0 < 0))
        {
            return null;
        }
        if (this.class499_0.Count < (A_0 + A_1))
        {
            A_1 = this.class499_0.Count - A_0;
        }
        int num2 = (A_1 == -1) ? this.class499_0.Count : (A_0 + A_1);
        Image[] imageArray = new Image[num2];
        for (int i = A_0; i < num2; i++)
        {
            Image image = this.method_87(this.class499_0[i].method_28(), A_2, A_3, this.int_3);
            this.method_17(i + 1);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.PageUnit = GraphicsUnit.Point;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, (int) this.class499_0[i].method_28().PageSize.Width, (int) this.class499_0[i].method_28().PageSize.Height));
                using (Class196 class2 = new Class196(graphics, GraphicsUnit.Point, this.class499_0[i].method_28().PageSize))
                {
                    if (A_4)
                    {
                        class2.method_140(true);
                    }
                    class2.method_146(this.method_9());
                    class2.method_148(this.method_11());
                    class2.method_150(this.method_13());
                    class2.method_17(i + 1);
                    class2.method_20(this.method_19());
                    class2.method_6(this.method_5());
                    class2.method_8(this.method_7());
                    this.class499_0[i].method_68(class2);
                    if (this.bool_2)
                    {
                        class2.method_156();
                    }
                    this.class497_0.method_0().Add(new Class498(image, class2.method_153(), class2.method_145()));
                    this.method_10(class2.method_145());
                    this.method_12(class2.method_147());
                    this.method_14(class2.method_149());
                }
            }
            imageArray[i] = image;
        }
        if (!A_6)
        {
            this.method_51();
        }
        return imageArray;
    }

    private Image method_58(Image A_0)
    {
        int num = 6;
        Bitmap image = new Bitmap(A_0.Width, A_0.Height);
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.DrawString(BookmarkStart.b("缫席夯䀱儳ᠵ簷唹弻", num), new Font(BookmarkStart.b("砫䜭崯圱䜳ᘵ瘷弹䬻ḽሿⵁ⥃❅♇", num), 16f, FontStyle.Bold), Brushes.Red, new PointF(10f, 10f));
            graphics.DrawString(BookmarkStart.b("樫尭唯圱ᐳ䀵崷䠹伻圽⼿ⱁ摃╅❇⑉㩋⭍≏♑㵓㡕㽗穙⭛ㅝ቟١䑣ɥݧ३ᥫͭᕯᱱsյ塷๹፻幽黎ꂋ꺍﶑뚕ﮗﮙ뺝쾟첡좣\udfa5\u88a7충즫\udaad\u90af욱\udcb3\ud3b5颷\udcb9\ud5bb첽뎿뛁뫉귋꧍뗏믓냕동뇛뿝蟟蟡쫣", num), new Font(BookmarkStart.b("砫䜭崯圱䜳ᘵ瘷弹䬻ḽሿⵁ⥃❅♇", num), 10f), Brushes.Red, new PointF(10f, 35f));
            graphics.DrawString(BookmarkStart.b("礫席圯䀱唳刵崷ᨹ䠻儽怿Ł⭃⭅╇⽉㹋ⵍ㥏㍑㡓癕ᵗ㹙㕛⩝य़ൡ੣䙥ݧ౩䱫㵭o᭱ٳ፵噷㹹፻ᵽꁿ뺁ﲇ憎뚋ꆍ뾏뚗ﾙ놛쎟잡욣쪥\udda7\ucfa9芫춭\udfaf\udfb1鮳ﾵ횷캹캻톽꒿럁ꟃꏅ뷉ꏋ볍듏￑닓맕꫗닛믝铟쿡跣裥鳧飩菫諭藯釱釳\ud8f5\u90f7軹釻鋽㻿Ⰱ", num), new Font(BookmarkStart.b("砫䜭崯圱䜳ᘵ瘷弹䬻ḽሿⵁ⥃❅♇", num), 10f), Brushes.Red, new PointF(10f, 48f));
            graphics.Dispose();
        }
        return image;
    }

    private Image method_59(int A_0, int A_1)
    {
        int num = 10;
        MemoryStream stream = new MemoryStream();
        Image image = null;
        using (Bitmap bitmap = new Bitmap(A_0, A_1, PixelFormat.Format32bppPArgb))
        {
            using (Graphics graphics2 = Graphics.FromImage(bitmap))
            {
                IntPtr hdc = graphics2.GetHdc();
                RectangleF frameRect = new RectangleF(0f, 0f, (float) A_0, (float) A_1);
                image = new Metafile(stream, hdc, frameRect, MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
            }
        }
        using (Graphics graphics = Graphics.FromImage(image))
        {
            graphics.Clear(Color.WhiteSmoke);
            graphics.DrawString(BookmarkStart.b("振䈱崳䐵崷ᐹ砻儽⌿ᑁⵃ⍅㽇⽉㹋", num), new Font(BookmarkStart.b("搯嬱夳匵䬷ᨹ爻嬽㜿扁ᙃ⥅╇⭉≋", num), 16f, FontStyle.Bold), Brushes.Red, new PointF(10f, 10f));
            graphics.DrawString(BookmarkStart.b("瘯䀱儳匵ᠷ䰹夻䰽㌿⭁⭃⡅桇⥉⍋⁍♏㝑♓≕ㅗ㑙㭛繝᝟ൡᙣɥ䡧๩ͫ൭կάᅳᡵ౷ॹ屻੽ꊁﶍ벏늑秊몙ﾛﾝ캟芡쮣좥쒧펩貫즭햯욱钳습킷\udfb9\u9cbb\ud8bd\ua9bf냁럃닅柳뻍뇏뗑뇓럗볙ﳛ럝跟菡菣菥웧", num), new Font(BookmarkStart.b("搯嬱夳匵䬷ᨹ爻嬽㜿扁ᙃ⥅╇⭉≋", num), 10f), Brushes.Red, new PointF(10f, 35f));
            graphics.DrawString(BookmarkStart.b("支䈱匳䐵夷帹夻ḽ㐿ⵁ摃Յ❇❉⅋⭍≏ㅑ㵓㝕㑗穙ᥛ㩝य़ᙡൣ॥٧䩩ͫ࡭偯ⅱѳή੷ό剻㩽튃ﶉﲍ낏꺑ﲓꚛ놝辟햡펣톥蚧쾩膫잭펯ힱ횳\udab5\ucdb7\udfb9\u92bb\uddbd\uafbf꿁迅ꛇ뻉뻋ꇍ듏ꟑ럓돕귙돛곝蓟쿡苣觥髧쟩苫语蓯\udff1\u9df3飵賷裹鏻髽痿愁愃⠅怇縉愋戍⸏㰑", num), new Font(BookmarkStart.b("搯嬱夳匵䬷ᨹ爻嬽㜿扁ᙃ⥅╇⭉≋", num), 10f), Brushes.Red, new PointF(10f, 48f));
            graphics.Dispose();
        }
        return image;
    }

    internal void method_6(bool A_0)
    {
        this.bool_12 = A_0;
    }

    internal Image[] method_60(int A_0, int A_1, ImageType A_2, MemoryStream A_3, bool A_4, bool A_5, GraphicsUnit A_6)
    {
        if ((this.class499_0.Count < A_0) || (A_0 < 0))
        {
            return null;
        }
        if (this.class499_0.Count < (A_0 + A_1))
        {
            A_1 = this.class499_0.Count - A_0;
        }
        int num2 = (A_1 == -1) ? this.class499_0.Count : (A_0 + A_1);
        Image[] imageArray = new Image[num2];
        for (int i = A_0; i < num2; i++)
        {
            Image image = this.method_86(this.class499_0[i].method_28(), A_2, A_3, this.int_3, A_6);
            this.method_17(i + 1);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.PageUnit = A_6;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, (int) this.class499_0[i].method_28().PageSize.Width, (int) this.class499_0[i].method_28().PageSize.Height));
                using (Class196 class2 = new Class196(graphics, A_6, this.class499_0[i].method_28().PageSize))
                {
                    if (A_4)
                    {
                        class2.method_140(true);
                    }
                    class2.method_146(this.method_9());
                    class2.method_148(this.method_11());
                    class2.method_150(this.method_13());
                    class2.method_17(i + 1);
                    class2.method_20(this.method_19());
                    class2.method_6(this.method_5());
                    class2.method_8(this.method_7());
                    this.class499_0[i].method_68(class2);
                    if (this.bool_2)
                    {
                        class2.method_156();
                    }
                    this.class497_0.method_0().Add(new Class498(image, class2.method_153(), class2.method_145()));
                    this.method_10(class2.method_145());
                    this.method_12(class2.method_147());
                    this.method_14(class2.method_149());
                }
            }
            imageArray[i] = image;
        }
        return imageArray;
    }

    internal Stream method_61(int A_0, int A_1, ImageType A_2, MemoryStream A_3)
    {
        if ((this.class499_0.Count < A_0) || (A_0 < 0))
        {
            return null;
        }
        if (this.class499_0.Count < (A_0 + A_1))
        {
            A_1 = this.class499_0.Count - A_0;
        }
        int num2 = (A_1 == -1) ? this.class499_0.Count : (A_0 + A_1);
        Image[] imageArray = new Image[num2];
        for (int i = A_0; i < num2; i++)
        {
            A_3 = new MemoryStream();
            Image image = this.method_87(this.class499_0[i].method_28(), A_2, A_3, this.int_3);
            this.method_17(i + 1);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.PageUnit = GraphicsUnit.Point;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, (int) this.class499_0[i].method_28().PageSize.Width, (int) this.class499_0[i].method_28().PageSize.Height));
                using (Class196 class2 = new Class196(graphics, GraphicsUnit.Point, this.class499_0[i].method_28().PageSize))
                {
                    this.class499_0[i].method_68(class2);
                    if (this.bool_2)
                    {
                        class2.method_156();
                    }
                    this.class497_0.method_0().Add(new Class498(image, class2.method_153(), class2.method_9()));
                }
            }
            imageArray[i] = image;
        }
        return A_3;
    }

    private void method_62(int A_0, Class196 A_1)
    {
        bool flag = false;
        switch (this.class499_0[A_0].method_28().PageBordersApplyType)
        {
            case PageBordersApplyType.AllPages:
                flag = true;
                break;

            case PageBordersApplyType.FirstPage:
                if ((A_0 == 0) || ((A_0 > 0) && (this.class499_0[A_0].method_28().OwnerBase != this.class499_0[A_0 - 1].method_28().OwnerBase)))
                {
                    flag = true;
                }
                break;

            case PageBordersApplyType.AllExceptFirstPage:
                if ((A_0 > 0) && (this.class499_0[A_0].method_28().OwnerBase == this.class499_0[A_0 - 1].method_28().OwnerBase))
                {
                    flag = true;
                }
                break;
        }
        if (flag && (this.class499_0[A_0].method_3().Count != 0))
        {
            A_1.method_300(this.method_31() as Section, this.class499_0[A_0].method_3().method_4(0).method_69());
        }
    }

    internal spr⠃[] method_63(int A_0, int A_1)
    {
        if ((this.class499_0.Count < A_0) || (A_0 < 0))
        {
            return null;
        }
        if (this.class499_0.Count < (A_0 + A_1))
        {
            A_1 = this.class499_0.Count - A_0;
        }
        int num2 = (A_1 == -1) ? this.class499_0.Count : (A_0 + A_1);
        spr⠃[] r⠃Array = new spr⠃[num2];
        for (int i = A_0; i < num2; i++)
        {
            Class500 class4 = this.class499_0[i];
            this.method_17(i + 1);
            using (Class307 class2 = new Class307(class4, true))
            {
                using (Class196 class3 = new Class196(class2, this.class499_0[i].method_28().PageSize))
                {
                    class3.method_146(this.method_9());
                    class3.method_148(this.method_11());
                    class3.method_150(this.method_13());
                    class3.method_17(i + 1);
                    class3.method_20(this.method_19());
                    this.class499_0[i].method_68(class3);
                    if (this.bool_2)
                    {
                        class3.method_156();
                    }
                    this.class497_0.method_0().Add(new Class498(class3.method_153(), class3.method_145()));
                    this.method_10(class3.method_145());
                    this.method_12(class3.method_147());
                    this.method_14(class3.method_149());
                }
                r⠃Array[i] = (spr⠃) (class2.method_0().᜔() as sprḀ).ᜀ()[0];
            }
        }
        return r⠃Array;
    }

    private bool method_64()
    {
        this.bool_1 = false;
        this.class499_0.Clear();
        this.list_10.Clear();
        this.int_2 = 0;
        (this.interface3_0 as Document).LayoutVariables.method_4();
        Class304.smethod_0();
        (this.interface3_0 as Document).method_136();
        this.method_70();
        if (this.method_1())
        {
            Class307 class2 = new Class307(this.class500_0.method_28().PageSize, true);
            Class196 class3 = new Class196(class2, this.class500_0.method_28().PageSize);
            class3.method_20(this.method_19());
            this.class196_0 = class3;
            this.class196_0.class500_0 = this.class500_0;
            this.class196_0.class499_0 = this.class499_0;
            this.method_65();
        }
        else
        {
            using (Graphics graphics = Graphics.FromImage(this.method_87(this.class500_0.method_28(), this.imageType_0, null, this.int_3)))
            {
                graphics.PageUnit = GraphicsUnit.Point;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, (int) this.class500_0.method_28().PageSize.Width, (int) this.class500_0.method_28().PageSize.Height));
                Class196 class4 = new Class196(graphics, GraphicsUnit.Point, this.class500_0.method_28().PageSize);
                class4.method_20(this.method_19());
                this.class196_0 = class4;
                this.class196_0.class500_0 = this.class500_0;
                this.class196_0.class499_0 = this.class499_0;
                this.method_65();
                graphics.Dispose();
            }
        }
        if (this.isection_0 == this.isection_0.Document.ChildObjects.LastItem)
        {
            this.method_102(this.class499_0.Count - (this.isection_0 as Interface1).imethod_0().imethod_52());
        }
        this.method_71();
        this.method_77();
        this.method_74();
        return !this.bool_1;
    }

    private void method_65()
    {
        this.method_103(false, 0);
        this.method_78();
        this.bool_0 = false;
        Class304 class2 = new Class304();
        class2.method_0(new Class304.Delegate3(this.method_90));
        class2.method_15(this.interface3_0, this, this.class196_0);
        class2.method_1(new Class304.Delegate3(this.method_90));
    }

    internal void method_66()
    {
        if (((this.interface3_0 != null) && (this.interface3_0 is Document)) && ((this.interface3_0 as Document).LayoutVariables.method_0().Count > 0))
        {
            foreach (DocumentObject obj3 in (this.interface3_0 as Document).LayoutVariables.method_0())
            {
                if (obj3 is Paragraph)
                {
                    if ((obj3 as Paragraph).HasRelayout)
                    {
                        (obj3 as Paragraph).HasRelayout = false;
                    }
                    List<DocumentObject> list = new List<DocumentObject>();
                    int num = 0;
                    int count = (obj3 as Paragraph).Items.Count;
                    while (num < count)
                    {
                        DocumentObject item = (obj3 as Paragraph).Items[num];
                        if ((item is TextBox) && (item as TextBox).Format.IsInShape)
                        {
                            (item as TextBox).ShapeInfo.CompleteExtractionOfEmbeddedTextbox = false;
                            list.Add(item);
                        }
                        num++;
                    }
                    foreach (DocumentObject obj2 in list)
                    {
                        (obj3 as Paragraph).Items.Remove(obj2);
                    }
                }
            }
        }
    }

    internal void method_67()
    {
        if (((this.interface3_0 != null) && (this.interface3_0 is Document)) && ((this.interface3_0 as Document).LayoutVariables.method_1().Count > 0))
        {
            foreach (DocumentObject obj3 in (this.interface3_0 as Document).LayoutVariables.method_1())
            {
                if (obj3 is Paragraph)
                {
                    List<DocumentObject> list = new List<DocumentObject>();
                    if ((obj3 as Paragraph).IsAddForIfField)
                    {
                        list.Add(obj3);
                    }
                    else
                    {
                        int num2 = 0;
                        int count = (obj3 as Paragraph).Items.Count;
                        while (num2 < count)
                        {
                            DocumentObject item = (obj3 as Paragraph).Items[num2];
                            if ((item is ParagraphBase) && (item as ParagraphBase).IsAddForIfField)
                            {
                                (item as ParagraphBase).IsAddForIfField = false;
                                list.Add(item);
                            }
                            num2++;
                        }
                    }
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        DocumentObject entity = list[i];
                        if ((entity.Owner != null) && (entity.Owner.ChildObjects.IndexOf(entity) > -1))
                        {
                            if (entity.Owner is Paragraph)
                            {
                                (entity.Owner as Paragraph).Items.Remove(entity);
                            }
                            else
                            {
                                if (entity is Paragraph)
                                {
                                    (entity as Paragraph).method_59(0, true);
                                }
                                entity.Owner.ChildObjects.Remove(entity);
                            }
                        }
                    }
                }
            }
        }
    }

    internal void method_68()
    {
        if ((this.class499_0 != null) && (this.class499_0.Count > 0))
        {
            foreach (Class500 class2 in this.class499_0)
            {
                if (class2 != null)
                {
                    class2.method_96();
                }
            }
        }
    }

    internal void method_69()
    {
        if (this.list_0 != null)
        {
            foreach (HeaderFooter footer in this.list_0)
            {
                footer.ChildObjects.Clear();
            }
        }
    }

    internal bool method_7()
    {
        return this.bool_13;
    }

    private void method_70()
    {
        this.method_71();
        this.method_77();
        this.method_74();
        if (this.interface3_0 is Document)
        {
            PageSetup setup = new PageSetup((this.method_31() as Section).method_25());
            PageLayoutEventArgs args = new PageLayoutEventArgs {
                PageIndex = this.int_2,
                PageSetup = setup
            };
            (this.interface3_0 as Document).method_22(args);
            (this.method_31() as Section).LayoutPageSetup = setup;
        }
        Interface23 interface1 = (this.method_31() as Interface1).imethod_0();
        interface1.imethod_53(interface1.imethod_52() + 1);
        (this.method_31() as Interface1).imethod_0().imethod_49(false);
        (this.method_31() as Interface1).imethod_0().imethod_45(false);
        (this.method_31() as Interface1).imethod_0().imethod_47(false);
        (this.method_31() as Interface1).imethod_0().imethod_51(0f);
        int num = (this.class500_0 != null) ? this.class500_0.method_6() : 0;
        this.class500_0 = new Class500(this.method_31(), this.int_2);
        if (this.isection_0.PageSetup.RestartPageNumbering && (this.bool_0 || (((this.int_2 == 0) || ((this.method_31() as Interface1).imethod_0().imethod_52() == 1)) && (this.isection_0.PageSetup.PageStartingNumber > 0))))
        {
            this.class500_0.method_32(this.isection_0.PageSetup.PageStartingNumber - 1);
            this.int_2 = this.class500_0.method_31();
        }
        this.method_103(true, num);
        Class616.list_0 = new List<RectangleF>();
        Class616.list_1 = new List<TextWrappingStyle>();
        this.class499_0.Add(this.class500_0);
        this.int_2++;
        this.float_0 = 0f;
        this.int_1 = 0;
        if (this.class196_0 != null)
        {
            this.class196_0.class500_0 = this.class500_0;
            this.class196_0.class499_0 = this.class499_0;
        }
    }

    private void method_71()
    {
        if ((this.class500_0 != null) && (this.class500_0.method_4().Count > 0))
        {
            FootEndnoteOptions footnoteOptions = null;
            Section section = (this.class500_0.method_4().method_4(0).method_73() as Body).Owner.method_2();
            footnoteOptions = section.FootnoteOptions;
            footnoteOptions.ApplyBase(section.Document.FootnoteOptions);
            if (footnoteOptions.Position != FootnotePosition.PrintAtBottomOfPage)
            {
                float bottom = this.class500_0.method_3().method_4(2).method_69().Bottom;
                float num2 = this.class500_0.method_4().method_4(0).method_69().Top - 12f;
                float num3 = num2 - bottom;
                if (num3 != 0f)
                {
                    foreach (Class375 class3 in this.class500_0.method_4())
                    {
                        class3.method_94(0.0, (double) -num3, true);
                    }
                }
                if (this.class500_0.method_5().Count > 0)
                {
                    float num4 = (this.class500_0.method_4().method_0().method_69().Bottom - this.class500_0.method_4().method_4(0).method_69().Top) + 12f;
                    foreach (Class375 class2 in this.class500_0.method_5())
                    {
                        class2.method_94(0.0, (double) num4, true);
                    }
                }
            }
        }
    }

    private void method_72()
    {
        this.int_1 = 0;
        this.float_0 = 0f;
        this.list_2.Clear();
        this.list_3.Clear();
        this.list_4.Clear();
    }

    private bool method_73(ref bool A_0)
    {
        bool flag = false;
        if (this.bool_0)
        {
            this.float_2 += this.float_5;
            switch (this.method_31().BreakCode)
            {
                case SectionBreakType.NoBreak:
                {
                    Section section = this.method_31().Document.Sections[this.method_31().Document.Sections.IndexOf(this.method_31()) - 1];
                    if ((section.PageSetup.PageSize.Width == this.method_31().PageSetup.PageSize.Width) && (section.PageSetup.PageSize.Height == this.method_31().PageSetup.PageSize.Height))
                    {
                        if (section.Columns.Count == 1)
                        {
                            int count = this.method_28().method_3().Count;
                            this.float_2 = this.method_28().method_3().method_4(count - 1).method_69().Bottom - this.float_6;
                            this.float_5 = this.float_2;
                        }
                        else
                        {
                            this.method_75(section, true);
                        }
                        if (!this.bool_5)
                        {
                            this.method_72();
                            this.bool_0 = false;
                            this.bool_5 = false;
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                    return ((section.interface23_0 as Class205).method_3() || flag);
                }
                case SectionBreakType.NewColumn:
                    if ((this.method_31() as Section).SectPr.method_116() == 1)
                    {
                        flag = true;
                        this.float_5 = 0f;
                    }
                    return flag;

                case SectionBreakType.NewPage:
                    flag = true;
                    this.float_5 = 0f;
                    return flag;

                case SectionBreakType.EvenPage:
                    if (this.method_33())
                    {
                        A_0 = true;
                        this.method_70();
                        this.method_78();
                        this.method_94();
                    }
                    flag = true;
                    this.float_5 = 0f;
                    return flag;

                case SectionBreakType.Oddpage:
                    if (!this.method_33())
                    {
                        A_0 = true;
                        this.method_70();
                        this.method_78();
                        this.method_94();
                    }
                    flag = true;
                    this.float_5 = 0f;
                    return flag;
            }
        }
        return flag;
    }

    private void method_74()
    {
        int index = this.method_31().Document.Sections.IndexOf(this.method_31());
        if (index >= 0)
        {
            Section section = this.method_31().Document.Sections[index];
            if (((section != null) && (section.Columns.Count > 1)) && ((this.method_28() != null) && (this.method_28().method_3().Count > 2)))
            {
                this.method_75(section, false);
            }
        }
    }

    private void method_75(Section A_0, bool A_1)
    {
        int num = 9;
        int count = this.method_28().method_3().Count;
        int num3 = 0;
        if (count >= 3)
        {
            float num4 = 0f;
            for (int i = count; i > 1; i--)
            {
                object obj2 = this.method_28().method_3().method_4(i - 1).method_73();
                if (((obj2 is Class65) && ((obj2 as Class65).method_0() is Class65)) && (((obj2 as Class65).method_0() as Class65).method_2() is Section))
                {
                    obj2 = ((obj2 as Class65).method_0() as Class65).method_2();
                }
                else if ((obj2 is Class65) && ((obj2 as Class65).method_0() is Section))
                {
                    obj2 = (obj2 as Class65).method_0();
                }
                else if (((obj2 is Document) && (this.method_28().method_3().method_4(i - 1).method_74().Count > 0)) && (this.method_28().method_3().method_4(i - 1).method_74().method_4(0).method_73() is Section))
                {
                    obj2 = this.method_28().method_3().method_4(i - 1).method_74().method_4(0).method_73();
                }
                if (!(obj2 is Section) || ((obj2 as Section) != A_0))
                {
                    break;
                }
                num4 = Math.Max(num4, this.method_28().method_3().method_4(i - 1).method_69().Bottom);
                num3++;
            }
            if (A_1)
            {
                this.float_2 = num4 - this.float_6;
                this.float_5 = this.float_2;
            }
            if (A_0.PageSetup.ColumnsLineBetween && (num3 > 0))
            {
                RectangleF ef2 = this.method_28().method_3().method_4(this.method_28().method_3().Count - num3).method_69();
                float height = (ef2.Bottom == num4) ? ef2.Height : (num4 - ef2.Top);
                Class376 class3 = this.method_28().method_3().method_4(this.method_28().method_3().Count - 1).method_74();
                for (int j = 0; j < A_0.Columns.Count; j++)
                {
                    if ((j < num3) && ((j + 1) < A_0.Columns.Count))
                    {
                        float space = A_0.Columns[j].Space;
                        float width = A_0.Columns[j].Width;
                        Class375 class2 = new Class375(A_0);
                        class2.method_70(new RectangleF((ef2.X + width) + (space / 2f), ef2.Y, 1f, height));
                        class2.method_65(BookmarkStart.b("氮帰弲䀴娶圸栺堼伾⁀ㅂ⑄㍆⁈⑊⍌͎㡐㵒ご", num));
                        class3.method_7(class2);
                        ef2 = new RectangleF((ef2.X + width) + space, ef2.Y, 1f, height);
                    }
                }
            }
        }
    }

    private void method_76()
    {
        if (this.method_28().method_3().Count > 2)
        {
            int count = this.method_28().method_3().Count;
            Class375 class2 = this.method_28().method_3().method_4(count - 1);
            while (class2.method_74().Count != 0)
            {
                class2 = class2.method_74().method_4(class2.method_74().Count - 1);
            }
            if (class2.method_73() is Break)
            {
                if ((class2.method_73() as Break).BreakType == BreakType.PageBreak)
                {
                    this.bool_5 = true;
                }
                else if ((class2.method_73() as Break).BreakType == BreakType.ColumnBreak)
                {
                    float height = class2.method_69().Height;
                    for (Class375 class3 = this.method_28().method_3().method_4(count - 1); class3.method_74().Count != 0; class3 = class3.method_74().method_4(class3.method_74().Count - 1))
                    {
                        class3.method_70(new RectangleF(class3.method_69().Location, new SizeF(class3.method_69().Width, class3.method_69().Height - height)));
                    }
                }
            }
            else
            {
                DocumentObject owner = null;
                if (class2.method_73() is Paragraph)
                {
                    owner = class2.method_73() as Paragraph;
                }
                else if (class2.method_73() is Class542)
                {
                    owner = ((class2.method_73() as Class542).method_2() as DocumentObject).Owner;
                }
                else if (class2.method_73() is Class65)
                {
                    if ((class2.method_73() as Class65).method_2() is Paragraph)
                    {
                        owner = (class2.method_73() as Class65).method_2() as DocumentObject;
                    }
                    else
                    {
                        owner = ((class2.method_73() as Class65).method_2() as DocumentObject).Owner;
                    }
                }
                else if (class2.method_73() is DocumentObject)
                {
                    owner = (class2.method_73() as DocumentObject).Owner;
                }
                if ((owner != null) && (owner is Paragraph))
                {
                    Class210 class4 = (owner as Interface1).imethod_0() as Class210;
                    if (((class4.method_29() && (class4.method_63() != SectionBreakType.NoBreak)) && class4.method_37()) || ((!class4.method_29() && class4.method_37()) && class4.method_33()))
                    {
                        this.bool_5 = class4.method_37();
                        if (class4.method_33())
                        {
                            class4.method_34(false);
                        }
                    }
                }
            }
        }
    }

    private void method_77()
    {
        if (this.method_28() != null)
        {
            int count = this.method_28().method_3().Count;
            if ((this.method_28().method_30() != null) && (count >= 3))
            {
                PageAlignment verticalAlignment = this.method_28().method_30().PageSetup.VerticalAlignment;
                if (verticalAlignment != PageAlignment.Top)
                {
                    float bottom = this.method_28().method_3().method_4(0).method_69().Bottom;
                    float top = this.method_28().method_3().method_4(1).method_69().Top;
                    float height = this.method_28().method_3().method_4(2).method_69().Height;
                    float num3 = top - bottom;
                    if (height < num3)
                    {
                        switch (verticalAlignment)
                        {
                            case PageAlignment.Middle:
                            {
                                float num5 = (num3 - height) / 2f;
                                for (int i = 2; i < count; i++)
                                {
                                    this.method_28().method_3().method_4(i).method_94(0.0, (double) num5, true);
                                }
                                return;
                            }
                            case PageAlignment.Justified:
                                return;

                            case PageAlignment.Bottom:
                            {
                                float num7 = num3 - height;
                                for (int j = 2; j < count; j++)
                                {
                                    this.method_28().method_3().method_4(j).method_94(0.0, (double) num7, true);
                                }
                                return;
                            }
                        }
                    }
                }
            }
        }
    }

    private void method_78()
    {
        int num = 4;
        Interface3 interface2 = this.method_79();
        Interface3 interface3 = this.method_80();
        bool flag = (interface2 as HeaderFooter).ChildObjects.Count <= 0;
        bool flag2 = (interface3 as HeaderFooter).ChildObjects.Count <= 0;
        if ((!flag && flag2) && ((this.method_31() != null) && (Class59.smethod_4(this.method_31().PageSetup.Margins.Bottom, this.method_31().PageSetup.FooterDistance, 0.005f) > 0)))
        {
            Paragraph paragraph = (interface3 as HeaderFooter).AddParagraph();
            ParagraphStyle style = this.method_35().Styles.FindByName(BookmarkStart.b("氩䌫䄭䐯圱䘳", num), StyleType.ParagraphStyle) as ParagraphStyle;
            if (style != null)
            {
                paragraph.method_65(style);
            }
            this.list_0.Add(interface3 as HeaderFooter);
        }
        this.class196_0.class500_0.method_38();
        this.class196_0.class500_0.method_10(interface2 as HeaderFooter);
        Class304 class2 = new Class304();
        class2.method_0(new Class304.Delegate3(this.method_90));
        class2.method_15(interface2, this.class197_0, this.class196_0);
        class2.method_1(new Class304.Delegate3(this.method_90));
        Class304 class3 = new Class304();
        class3.method_0(new Class304.Delegate3(this.method_90));
        class3.method_15(interface3, this.class197_1, this.class196_0);
        class3.method_1(new Class304.Delegate3(this.method_90));
        this.class196_0.method_136(false);
    }

    private Body method_79()
    {
        HeadersFooters headersFooters = this.method_31().HeadersFooters;
        Section section = null;
        Body body = this.method_81(this.method_31(), headersFooters.Header);
        if (!headersFooters.LinkToPrevious)
        {
            if (this.method_31().PageSetup.DifferentOddAndEvenPagesHeaderFooter && this.method_33())
            {
                body = this.method_81(this.method_31(), headersFooters.EvenHeader);
            }
            if (this.method_31().PageSetup.DifferentFirstPageHeaderFooter && this.bool_0)
            {
                body = this.method_81(this.method_31(), headersFooters.FirstPageHeader);
            }
            return body;
        }
        IDocumentObject obj2 = this.method_31();
        if ((obj2 != null) && (obj2.PreviousSibling is Section))
        {
            int index = this.method_31().Document.Sections.IndexOf(this.method_31());
            while (index > 0)
            {
                section = this.method_31().Document.Sections[index - 1];
                body = this.method_81(section, section.HeadersFooters.OddHeader);
                if (!section.HeadersFooters.LinkToPrevious)
                {
                    break;
                }
                index--;
            }
            headersFooters.method_9(this.method_31().Document.Sections[index].HeadersFooters.LinkToPrevious);
        }
        if (this.method_31().PageSetup.DifferentOddAndEvenPagesHeaderFooter && this.method_33())
        {
            body = this.method_81(section, section.HeadersFooters.EvenHeader);
        }
        if ((!section.PageSetup.DifferentFirstPageHeaderFooter || (this.method_0().Count != 1)) && (!this.method_31().PageSetup.DifferentFirstPageHeaderFooter || !this.bool_0))
        {
            return body;
        }
        return this.method_81(section, section.HeadersFooters.FirstPageHeader);
    }

    internal void method_8(bool A_0)
    {
        this.bool_13 = A_0;
    }

    private Body method_80()
    {
        HeadersFooters headersFooters = this.method_31().HeadersFooters;
        Section section = null;
        Body body = this.method_81(this.method_31(), headersFooters.OddFooter);
        if (!headersFooters.LinkToPrevious)
        {
            if (this.method_31().PageSetup.DifferentOddAndEvenPagesHeaderFooter && this.method_33())
            {
                body = this.method_81(this.method_31(), headersFooters.EvenFooter);
            }
            if (this.method_31().PageSetup.DifferentFirstPageHeaderFooter && this.bool_0)
            {
                body = this.method_81(this.method_31(), headersFooters.FirstPageFooter);
            }
            return body;
        }
        IDocumentObject obj2 = this.method_31();
        if ((obj2 != null) && (obj2.PreviousSibling is Section))
        {
            for (int i = this.method_31().Document.Sections.IndexOf(this.method_31()); i > 0; i--)
            {
                section = this.method_31().Document.Sections[i - 1];
                body = this.method_81(section, section.HeadersFooters.OddFooter);
                if (!section.HeadersFooters.LinkToPrevious)
                {
                    break;
                }
            }
        }
        if (this.method_31().PageSetup.DifferentOddAndEvenPagesHeaderFooter && this.method_33())
        {
            body = this.method_81(section, section.HeadersFooters.EvenFooter);
        }
        if ((!section.PageSetup.DifferentFirstPageHeaderFooter || (this.method_0().Count != 1)) && (!this.method_31().PageSetup.DifferentFirstPageHeaderFooter || !this.bool_0))
        {
            return body;
        }
        return this.method_81(section, section.HeadersFooters.FirstPageFooter);
    }

    private Body method_81(ISection A_0, HeaderFooter A_1)
    {
        Body body = A_1;
        Section section = null;
        if (A_1.LinkToPrevious)
        {
            IDocumentObject obj2 = A_0;
            if ((obj2 == null) || !(obj2.PreviousSibling is Section))
            {
                return body;
            }
            for (int i = A_0.Document.Sections.IndexOf(A_0); i > 0; i--)
            {
                section = A_0.Document.Sections[i - 1];
                body = section.HeadersFooters[A_1.Type];
                if (!section.HeadersFooters[A_1.Type].LinkToPrevious)
                {
                    return body;
                }
            }
        }
        return body;
    }

    private void method_82()
    {
        this.bool_0 = true;
        this.bool_4 = false;
        this.bool_6 = false;
        this.int_1 = 0;
        this.float_0 = 0f;
        this.float_4 = 0f;
        (this.isection_0 as Interface1).imethod_0().imethod_53(0);
    }

    internal List<int> method_83(Document A_0)
    {
        this.interface3_0 = A_0;
        A_0.DocLayoter = this;
        A_0.bool_23 = this.method_19().UsePSCoversion;
        this.isection_0 = A_0.Sections[0];
        (this.isection_0 as Interface1).imethod_0().imethod_53(0);
        this.bool_8 = true;
        this.method_64();
        A_0.DocLayoter = null;
        this.method_51();
        List<int> list = new List<int>();
        foreach (KeyValuePair<Paragraph, int> pair in this.method_40())
        {
            list.Add(pair.Value);
        }
        return list;
    }

    internal void method_84(Document A_0)
    {
        this.interface3_0 = A_0;
        A_0.DocLayoter = this;
        A_0.bool_23 = this.method_19().UsePSCoversion;
        this.isection_0 = A_0.Sections[0];
        (this.isection_0 as Interface1).imethod_0().imethod_53(0);
        this.bool_9 = true;
        this.method_64();
        A_0.DocLayoter = null;
        this.method_51();
    }

    internal void method_85(Document A_0)
    {
        this.interface3_0 = A_0;
        A_0.DocLayoter = this;
        A_0.bool_23 = this.method_19().UsePSCoversion;
        this.isection_0 = A_0.Sections[0];
        (this.isection_0 as Interface1).imethod_0().imethod_53(0);
        this.method_64();
        for (int i = 0; i < A_0.Fields.Count; i++)
        {
            if (A_0.Fields[i].Type == FieldType.FieldPageRef)
            {
                A_0.Fields[i].method_49();
            }
        }
        A_0.DocLayoter = null;
        this.method_51();
    }

    private Image method_86(PageSetup A_0, ImageType A_1, MemoryStream A_2, int A_3, GraphicsUnit A_4)
    {
        int num = 1;
        int width = (int) A_0.PageSize.Width;
        int height = (int) A_0.PageSize.Height;
        if (A_4 == GraphicsUnit.Point)
        {
            width = (int) Class1073.smethod_1().method_2(A_0.PageSize.Width, PrintUnits.Point);
            height = (int) Class1073.smethod_1().method_2(A_0.PageSize.Height, PrintUnits.Point);
        }
        switch (A_1)
        {
            case ImageType.Metafile:
            {
                if (A_2 == null)
                {
                    A_2 = new MemoryStream();
                }
                using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppPArgb))
                {
                    bitmap.SetResolution((float) A_3, (float) A_3);
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        IntPtr hdc = graphics.GetHdc();
                        return new Metafile(A_2, hdc, new RectangleF(0f, 0f, (float) width, (float) height), MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
                    }
                }
            }
            case ImageType.Bitmap:
                return new Bitmap(width, height, PixelFormat.Format32bppPArgb);
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("並䐨䨪䨬䨮攰䨲䔴制", num));
    }

    private Image method_87(PageSetup A_0, ImageType A_1, MemoryStream A_2, int A_3)
    {
        return this.method_86(A_0, A_1, A_2, A_3, GraphicsUnit.Point);
    }

    internal bool method_88(int A_0, int A_1)
    {
        long num = A_0 * A_1;
        return (num > 0xa00000L);
    }

    private bool method_89(Interface1 A_0)
    {
        bool flag = false;
        Paragraph paragraph = (A_0 is Paragraph) ? (A_0 as Paragraph) : ((!(A_0 is Class65) || !((A_0 as Class65).method_2() is Paragraph)) ? null : ((A_0 as Class65).method_2() as Paragraph));
        if (paragraph != null)
        {
            Document document = paragraph.Document;
            if ((!string.IsNullOrEmpty(paragraph.Text) && (paragraph.Format.OutlineLevel != OutlineLevel.Body)) && !document.TOC.method_52(paragraph))
            {
                flag = true;
                if (!this.method_40().ContainsKey(paragraph))
                {
                    this.method_40().Add(paragraph, this.method_28().method_31() + 1);
                }
                else
                {
                    this.method_40()[paragraph] = this.method_28().method_31() + 1;
                }
            }
            if (paragraph == this.paragraph_0)
            {
                this.method_39().RemoveAt(this.method_39().Count - 1);
            }
        }
        this.paragraph_0 = paragraph;
        return flag;
    }

    internal List<Dictionary<string, Class310>> method_9()
    {
        return this.list_10;
    }

    private void method_90(object A_0, Class375 A_1)
    {
        int num = 13;
        IField field = (A_1.method_73() is IField) ? (A_1.method_73() as IField) : ((!(A_1.method_73() is Class542) || !((A_1.method_73() as Class542).method_2() is IField)) ? null : ((A_1.method_73() as Class542).method_2() as IField));
        if (field != null)
        {
            if (field.Type != FieldType.FieldHyperlink)
            {
                if (field.Type == FieldType.FieldPage)
                {
                    A_1.method_65((field as TextRange).Text);
                    if (this.bool_9)
                    {
                        int num2 = this.method_28().method_31() + 1;
                        (field as Field).method_217(num2.ToString());
                    }
                }
                else if (field.Type == FieldType.FieldNumPages)
                {
                    this.method_28().method_79(field);
                    this.method_28().method_78(A_1);
                    A_1.method_1(true);
                }
                else if (field.Type == FieldType.FieldSectionPages)
                {
                    this.method_28().method_80(field);
                    this.method_28().method_78(A_1);
                    A_1.method_1(true);
                }
                else if (field.Type == FieldType.FieldPageRef)
                {
                    string key = (field as Field).method_177().Trim().Split(new char[] { ' ' })[1];
                    if (!key.ToLower().StartsWith(BookmarkStart.b("氲䄴堶娸", num)))
                    {
                        if (!this.method_35().DocLayoter.dictionary_1.ContainsKey(key))
                        {
                            this.method_28().method_19().Add(field);
                            this.method_28().method_78(A_1);
                            A_1.method_1(true);
                        }
                        else
                        {
                            A_1.method_65(this.method_35().DocLayoter.dictionary_1[key].ToString());
                        }
                    }
                }
                else if (((field.Type == FieldType.FieldTOCEntry) && this.bool_8) && this.method_41())
                {
                    this.method_39().Add(this.method_28().method_31() + 1);
                }
                this.bool_1 = true;
            }
        }
        else if (this.bool_8 && this.method_89(A_1.method_73()))
        {
            this.method_39().Add(this.method_28().method_31() + 1);
        }
    }

    private string method_91(Field A_0)
    {
        string str = string.Empty;
        foreach (ParagraphBase base2 in A_0.Range.method_8())
        {
            if (base2 is TextRange)
            {
                str = str + (base2 as TextRange).Text;
            }
        }
        return str;
    }

    private RectangleF method_92(bool A_0)
    {
        RectangleF ef = this.method_93(A_0);
        float num = this.method_97();
        if ((ef.Height < num) && (this.method_31().BreakCode == SectionBreakType.NoBreak))
        {
            this.method_70();
            this.method_78();
            this.method_94();
            return this.method_93(A_0);
        }
        if (this.bool_15 && (this.method_31().BreakCode == SectionBreakType.NoBreak))
        {
            Interface23 interface1 = (this.method_31() as Interface1).imethod_0();
            interface1.imethod_53(interface1.imethod_52() + 1);
            if ((!this.isection_0.PageSetup.RestartPageNumbering || (this.isection_0.PreviousSibling == null)) || !this.bool_0)
            {
                if ((this.int_2 != 0) && ((this.method_31() as Interface1).imethod_0().imethod_52() != 1))
                {
                    return ef;
                }
                if (this.isection_0.PageSetup.PageStartingNumber <= 0)
                {
                    return ef;
                }
            }
            this.class500_0.method_32(this.isection_0.PageSetup.PageStartingNumber - 1);
            this.int_2 = this.class500_0.method_31();
            this.int_2++;
        }
        return ef;
    }

    private RectangleF method_93(bool A_0)
    {
        RectangleF empty = RectangleF.Empty;
        if ((this.method_31().BreakCode == SectionBreakType.NoBreak) && !this.bool_3)
        {
            if (this.bool_4)
            {
                empty = this.method_28().method_92(this.int_1, ref this.float_0);
                this.float_6 = empty.Y;
                if ((this.method_31() as Interface1).imethod_0().imethod_44() && ((this.method_31() as Interface1).imethod_0().imethod_50() > 0f))
                {
                    empty.Height = (this.method_31() as Interface1).imethod_0().imethod_50();
                }
                else
                {
                    this.float_3 = empty.Height;
                }
            }
            else
            {
                empty = this.method_28().method_95(this.int_1, ref this.float_0, this.bool_6, A_0);
            }
            empty.Y = this.float_6 + this.float_2;
            if ((this.method_31() as Interface1).imethod_0().imethod_44() && ((this.method_31() as Interface1).imethod_0().imethod_50() > 0f))
            {
                if ((!this.bool_4 && (this.int_1 > 0)) && (this.int_1 < ((this.method_31() as Section).Columns.Count - 1)))
                {
                    empty.Height = (this.method_31() as Interface1).imethod_0().imethod_50();
                }
                else
                {
                    empty.Height -= this.float_2;
                }
            }
            else
            {
                empty.Height = this.float_3 - this.float_2;
            }
        }
        else
        {
            empty = this.method_28().method_92(this.int_1, ref this.float_0);
            if ((this.method_31() as Interface1).imethod_0().imethod_44() && ((this.method_31() as Interface1).imethod_0().imethod_50() > 0f))
            {
                if ((!this.bool_4 && (this.int_1 > 0)) && (this.int_1 < ((this.method_31() as Section).Columns.Count - 1)))
                {
                    empty.Height = (this.method_31() as Interface1).imethod_0().imethod_50();
                }
                else
                {
                    empty.Height -= this.float_2;
                }
            }
            this.float_6 = empty.Y;
            this.bool_4 = false;
            this.bool_3 = false;
            this.float_3 = empty.Height;
        }
        if ((this.isection_0 is Section) && ((this.isection_0 as Section).TextDirection == TextDirection.RightToLeft))
        {
            empty = new RectangleF(empty.X, empty.Y, empty.Height, empty.Width);
        }
        return empty;
    }

    private void method_94()
    {
        this.list_2.Clear();
        this.list_1.Clear();
        this.list_3.Clear();
        this.list_4.Clear();
        this.float_4 = 0f;
        this.float_2 = 0f;
        this.float_5 = 0f;
        this.bool_4 = true;
        this.bool_5 = false;
        this.bool_6 = false;
        this.bool_0 = false;
    }

    private float method_95()
    {
        Class616.list_0 = this.list_5;
        Class616.list_1 = this.list_6;
        this.list_5.Clear();
        this.list_6.Clear();
        int count = this.method_31().Columns.Count;
        float num2 = 0f;
        if (!this.method_31().PageSetup.EqualColumnWidth && !this.method_98())
        {
            num2 = this.method_96();
        }
        else
        {
            foreach (float num4 in this.list_1)
            {
                num2 += num4;
                if (num2 >= (this.float_4 / ((float) (count - this.int_1))))
                {
                    break;
                }
            }
        }
        if (this.list_7 != null)
        {
            foreach (float num3 in this.list_7)
            {
                num2 += num3;
            }
            this.list_7.Clear();
        }
        return (float) Math.Ceiling((double) num2);
    }

    private float method_96()
    {
        float num = 0f;
        int num2 = this.method_108();
        int num3 = this.method_109();
        float num4 = this.method_97();
        float num5 = this.method_31().Columns[num3].Width - this.method_31().Columns[num2].Width;
        if (num5 < this.method_31().Columns[num2].Width)
        {
            float num6 = ((this.float_1 * this.float_4) / this.method_31().Columns[num2].Width) - this.float_4;
            float num7 = 0f;
            for (int i = 0; i < this.method_31().Columns.Count; i++)
            {
                num7 += ((2 * this.method_31().Columns.Count) - 1) * Math.Abs((float) (this.method_31().Columns[i].Width - this.method_31().Columns[num2].Width));
            }
            return (num6 - ((this.method_31().Columns.Count - 1) * num7));
        }
        if (num3 < num2)
        {
            num = ((num5 * this.float_4) / this.float_1) + ((this.method_31().Columns.Count * this.method_31().Columns[num3].Width) / (num5 * this.method_31().Columns[num2].Width));
        }
        else
        {
            num = ((num5 * this.float_4) / this.float_1) + ((num5 * this.method_31().Columns[num2].Width) / (this.method_31().Columns.Count * this.method_31().Columns[num3].Width));
            num -= num4;
        }
        float num9 = this.method_31().Columns[num3].Width / this.method_31().Columns[num2].Width;
        string[] strArray = num9.ToString().Split(new char[] { '.' });
        float num10 = 0f;
        if (strArray.Length > 1)
        {
            num10 = ((float) (Convert.ToDouble(strArray[1]) * this.float_4)) / (this.method_31().Columns.Count * ((float) Math.Pow(10.0, (double) strArray[1].Length)));
        }
        return (num - num10);
    }

    private float method_97()
    {
        int num = 4;
        float num2 = 0f;
        if (this.method_31().Body.Items.FirstItem is Paragraph)
        {
            Paragraph firstItem = this.method_31().Body.Items.FirstItem as Paragraph;
            return (this.class196_0.method_1() ? this.class196_0.method_309(BookmarkStart.b("਩", num), this.class196_0.method_376(firstItem.BreakCharacterFormat), null).Height : this.class196_0.method_316(BookmarkStart.b("਩", num), firstItem.BreakCharacterFormat.Font, null).Height);
        }
        if (this.method_31().Body.Items.FirstItem is Table)
        {
            Table table = this.method_31().Body.Items.FirstItem as Table;
            num2 = this.class196_0.method_1() ? this.class196_0.method_309(BookmarkStart.b("਩", num), this.class196_0.method_376(table.Rows[0].Cells[0].method_57().BreakCharacterFormat), null).Height : this.class196_0.method_316(BookmarkStart.b("਩", num), table.Rows[0].Cells[0].method_57().BreakCharacterFormat.Font, null).Height;
            float num3 = (table.Rows[0].Height >= 0f) ? table.Rows[0].Height : (-1f * table.Rows[0].Height);
            if ((table.Rows[0].HeightType == TableRowHeightType.Exactly) && (num3 < num2))
            {
                return num3;
            }
            if ((table.Rows[0].HeightType == TableRowHeightType.AtLeast) && (num3 > num2))
            {
                num2 = num3;
            }
        }
        return num2;
    }

    private bool method_98()
    {
        float width = this.method_31().Columns[0].Width;
        bool flag = true;
        using (IEnumerator enumerator = this.method_31().Columns.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Column current = (Column) enumerator.Current;
                if (width != current.Width)
                {
                    goto Label_0055;
                }
                width = current.Width;
            }
            return flag;
        Label_0055:
            flag = false;
        }
        return flag;
    }

    private bool method_99(bool A_0)
    {
        int index = this.method_31().Document.Sections.IndexOf(this.method_31());
        if ((this.method_31().Document.Sections.Count - 1) > index)
        {
            ISection section = this.method_31().Document.Sections[index + 1];
            if ((section.BreakCode == SectionBreakType.NoBreak) && (this.method_31().Columns.Count > 1))
            {
                A_0 = false;
                if (this.list_5 == null)
                {
                    this.list_5 = new List<RectangleF>();
                }
                this.list_5 = Class616.list_0;
                if (this.list_6 == null)
                {
                    this.list_6 = new List<TextWrappingStyle>();
                }
                this.list_6 = Class616.list_1;
                if ((this.int_1 == 0) && (this.int_4 != index))
                {
                    this.bool_5 = false;
                    this.bool_6 = false;
                    this.int_4 = index;
                }
                return A_0;
            }
            A_0 = false;
            this.bool_6 = false;
            return A_0;
        }
        A_0 = false;
        this.bool_6 = false;
        return A_0;
    }

    void IDisposable.Dispose()
    {
        this.vmethod_0();
        GC.Collect();
        GC.SuppressFinalize(this);
    }

    void object.Finalize()
    {
        try
        {
            this.vmethod_0();
        }
        finally
        {
            base.Finalize();
        }
    }

    public virtual void vmethod_0()
    {
        if (this.class500_0 != null)
        {
            this.class500_0 = null;
        }
        if (this.isection_0 != null)
        {
            this.isection_0 = null;
        }
        if (this.class499_0 != null)
        {
            foreach (Class500 class2 in this.class499_0)
            {
                if (class2 != null)
                {
                    class2.System.IDisposable.Dispose();
                }
            }
            this.class499_0.Clear();
            this.class499_0 = null;
        }
        if (this.class197_0 != null)
        {
            this.class197_0 = null;
        }
        if (this.class197_1 != null)
        {
            this.class197_1 = null;
        }
        if (this.interface3_0 != null)
        {
            (this.interface3_0 as DocumentBase).interface23_0 = null;
            this.interface3_0 = null;
        }
        if (this.class497_0 != null)
        {
            this.class497_0.System.IDisposable.Dispose();
            this.class497_0 = null;
        }
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
        if (this.list_2 != null)
        {
            this.list_2.Clear();
            this.list_2 = null;
        }
        if (this.list_3 != null)
        {
            this.list_3.Clear();
            this.list_3 = null;
        }
        if (this.list_4 != null)
        {
            this.list_4.Clear();
            this.list_4 = null;
        }
        if (this.list_5 != null)
        {
            this.list_5.Clear();
            this.list_5 = null;
        }
        if (this.list_6 != null)
        {
            this.list_6.Clear();
            this.list_6 = null;
        }
        if (this.list_7 != null)
        {
            this.list_7.Clear();
            this.list_7 = null;
        }
        if (this.list_8 != null)
        {
            this.list_8.Clear();
            this.list_8 = null;
        }
        if (this.list_9 != null)
        {
            this.list_9.Clear();
            this.list_9 = null;
        }
        if (this.dictionary_0 != null)
        {
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
        if (this.toPdfParameterList_0 != null)
        {
            this.toPdfParameterList_0 = null;
        }
        if (this.list_10 != null)
        {
            this.list_10.Clear();
            this.list_10 = null;
        }
        if (this.list_11 != null)
        {
            this.list_11.Clear();
            this.list_11 = null;
        }
        if (this.class196_0 != null)
        {
            this.class196_0.System.IDisposable.Dispose();
            this.class196_0 = null;
        }
    }

    internal class Class197 : Interface18
    {
        private bool bool_0;
        private Class195 class195_0;
        [CompilerGenerated]
        private int int_0;

        public Class197(Class195 A_0, bool A_1)
        {
            this.class195_0 = A_0;
            this.bool_0 = A_1;
        }

        public bool imethod_1(out RectangleF A_0, out RectangleF A_1, ref int A_2, ref bool A_3, bool A_4)
        {
            if (!this.bool_0)
            {
                return this.class195_0.method_110(out A_0, out A_1);
            }
            return this.class195_0.method_113(out A_0, out A_1);
        }

        public void imethod_2(Class375 A_0)
        {
            if (!this.bool_0)
            {
                this.class195_0.method_111(A_0);
            }
            else
            {
                this.class195_0.method_114(A_0);
            }
        }

        public void imethod_3(Class375 A_0)
        {
        }

        public bool imethod_4(Class65 A_0, LayoutState A_1, Class375 A_2, ref bool A_3)
        {
            return false;
        }

        Class195 Interface18.imethod_0()
        {
            return this.class195_0;
        }

        [CompilerGenerated]
        public int method_0()
        {
            return this.int_0;
        }

        [CompilerGenerated]
        public void method_1(int A_0)
        {
            this.int_0 = A_0;
        }

        public bool method_2()
        {
            return this.bool_0;
        }
    }
}

