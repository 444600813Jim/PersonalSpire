using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Core.Biff_Records;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class421 : Class420, Interface14, Interface52
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    [CompilerGenerated]
    private bool bool_3;
    private Class399 class399_0;
    internal Class401 class401_0;
    private Class561 class561_0;
    private Dictionary<string, Class517> dictionary_0;
    private Dictionary<string, int> dictionary_1;
    private Dictionary<string, int> dictionary_2;
    private Document document_0;
    private readonly Hashtable hashtable_0;
    private IDictionary idictionary_0;
    private IDictionary idictionary_1;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private List<int> list_0;
    private Paragraph paragraph_0;
    private Section section_0;
    private Stack<bool> stack_0;
    private Stack stack_1;
    internal readonly string string_0;
    internal readonly string string_1;
    private string string_2;
    private string string_3;

    public Class421()
    {
        this.dictionary_0 = new Dictionary<string, Class517>();
        this.stack_0 = new Stack<bool>();
        this.dictionary_2 = new Dictionary<string, int>();
        this.list_0 = new List<int>();
        this.hashtable_0 = new Hashtable();
        this.string_0 = '\\'.ToString();
        this.string_1 = '"'.ToString();
        this.int_4 = 1;
    }

    public Class421(Document A_0, Stream A_1, Class465 A_2)
    {
        this.dictionary_0 = new Dictionary<string, Class517>();
        this.stack_0 = new Stack<bool>();
        this.dictionary_2 = new Dictionary<string, int>();
        this.list_0 = new List<int>();
        this.hashtable_0 = new Hashtable();
        this.string_0 = '\\'.ToString();
        this.string_1 = '"'.ToString();
        this.int_4 = 1;
        Class253 class2 = Class253.smethod_0(FileFormat.WordML);
        Class928 class3 = new Class928(A_0, A_1, string.Empty, class2);
        class3.method_4();
        this.document_0 = A_0;
        this.class399_0 = new Class399(A_1, class3.class253_0.method_6());
        this.class401_0 = new Class401(class3, A_0, this.class399_0, A_2);
        ((Interface48) this.class401_0).imethod_8(true);
        this.class561_0 = new Class561(this);
        this.stack_1 = new Stack();
        this.int_2 = 0;
        this.idictionary_1 = Class83.smethod_0();
        this.idictionary_0 = Class83.smethod_0();
    }

    private Class1104 imethod_0(Class928 A_0)
    {
        A_0.method_4();
        this.document_0 = A_0.document_0;
        this.class399_0 = new Class399(A_0.stream_0, A_0.class253_0.method_6());
        this.class401_0 = new Class401(A_0, this.class399_0);
        this.class561_0 = new Class561(this);
        this.stack_1 = new Stack();
        this.int_2 = 0;
        this.idictionary_1 = Class83.smethod_0();
        this.idictionary_0 = Class83.smethod_0();
        this.method_5();
        return new Class1104(BookmarkStart.b("䐯圱䰳䈵᜷䈹儻刽", 10));
    }

    private string imethod_5(string A_0)
    {
        return this.class401_0.method_5(A_0);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void imethod_8(AttrCollection A_0, bool A_1)
    {
        if (A_0 is FootEndnoteOptions)
        {
            FootEndnoteOptions options = A_0 as FootEndnoteOptions;
            if (!A_0.IsDefault && (options.OptionsType == FootnoteType.Footnote))
            {
                Class1130.smethod_0(this, FootnoteType.Footnote, A_0, A_1);
            }
            if (!A_0.IsDefault && (options.OptionsType == FootnoteType.Endnote))
            {
                Class1130.smethod_0(this, FootnoteType.Endnote, A_0, A_1);
            }
        }
        else if (A_0 is Class17)
        {
            FootEndnoteOptions options2 = (A_0 as Class17).method_139();
            if (!options2.IsDefault && (options2.OptionsType == FootnoteType.Footnote))
            {
                Class1130.smethod_0(this, FootnoteType.Footnote, options2, A_1);
            }
            FootEndnoteOptions options3 = (A_0 as Class17).method_138();
            if (!options3.IsDefault && (options3.OptionsType == FootnoteType.Endnote))
            {
                Class1130.smethod_0(this, FootnoteType.Endnote, options3, A_1);
            }
        }
    }

    Document Interface52.imethod_0()
    {
        return this.document_0;
    }

    Class398 Interface52.imethod_1()
    {
        return this.class399_0;
    }

    [CompilerGenerated]
    bool Interface52.imethod_2()
    {
        return this.bool_3;
    }

    [CompilerGenerated]
    void Interface52.imethod_3(bool A_0)
    {
        this.bool_3 = A_0;
    }

    string Interface52.imethod_4(int A_0)
    {
        return this.class401_0.method_4(A_0);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    int Interface52.imethod_6()
    {
        return this.int_3++;
    }

    void Interface52.imethod_7(HeaderFooter A_0)
    {
        int num = 0x12;
        this.class399_0.method_4(A_0.IsHeader ? BookmarkStart.b("伷9吻娽㈿", num) : BookmarkStart.b("伷9娻䨽㈿", num));
        this.class399_0.method_40(BookmarkStart.b("伷9䠻䜽〿❁", num), Class339.smethod_5(A_0.Type, false));
        A_0.Accept(this);
        this.class399_0.method_5();
    }

    private string method_10(EditingGroup A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case EditingGroup.Administrators:
                return BookmarkStart.b("䘦䴨䘪䐬䄮堰䀲䄴䔶堸伺刼䴾㉀", num);

            case EditingGroup.Contributors:
                return BookmarkStart.b("䐦䘨䔪夬崮堰儲䀴䌶嘸䤺丼", num);

            case EditingGroup.Current:
                return BookmarkStart.b("䐦尨太弬䨮弰䜲", num);

            case EditingGroup.Editors:
                return BookmarkStart.b("䈦䴨䈪夬䀮䌰䀲", num);

            case EditingGroup.Everyone:
                return BookmarkStart.b("䈦弨个弬嘮帰崲倴", num);

            case EditingGroup.Owners:
                return BookmarkStart.b("䠦帨䔪䠬崮䈰", num);
        }
        return "";
    }

    private string method_11(DisplacedByCustomXml A_0)
    {
        int num = 3;
        switch (A_0)
        {
            case DisplacedByCustomXml.Next:
                return BookmarkStart.b("䜨个唬嬮", num);

            case DisplacedByCustomXml.Prev:
                return BookmarkStart.b("夨太䠬央", num);
        }
        return "";
    }

    private int method_12(int A_0)
    {
        object obj2 = this.hashtable_0[A_0];
        if (obj2 != null)
        {
            return (int) obj2;
        }
        int num = this.Interface52.imethod_6();
        this.hashtable_0[A_0] = num;
        return num;
    }

    private string method_13(string A_0, string A_1, string A_2)
    {
        int num = 0x11;
        object obj2 = this.class401_0.Interface48.imethod_4().class181_0[A_1];
        if (obj2 == null)
        {
            return A_2;
        }
        return string.Format(BookmarkStart.b("䰶स䘺䘼฾㱀祂㹄畆㑈", num), A_0, obj2, A_2);
    }

    private void method_14(Background A_0, Class398 A_1, Interface48 A_2)
    {
        int num = 14;
        if (A_0.Type != BackgroundType.NoBackground)
        {
            A_1.method_4(BookmarkStart.b("䌳వ娷崹氻圽⌿㙁", num));
            switch (A_0.Type)
            {
                case BackgroundType.Gradient:
                {
                    BackgroundGradient gradient = A_0.Gradient;
                    A_1.method_4(BookmarkStart.b("䌳వ娷嬹弻唽✿ぁ⭃㍅♇⹉", num));
                    A_1.method_18(BookmarkStart.b("䌳వ娷崹弻儽ⰿⵁ㙃", num), Class735.smethod_2(gradient.Color1, false, true));
                    A_1.method_5();
                    this.method_15(gradient, A_1);
                    break;
                }
                case BackgroundType.Picture:
                case BackgroundType.Texture:
                {
                    DocPicture picture = new DocPicture(A_0.Document);
                    picture.LoadImage(A_0.ImageBytes);
                    if (ShapeObject.smethod_1(picture))
                    {
                        A_1.method_4(BookmarkStart.b("䌳వ娷嬹弻唽✿ぁ⭃㍅♇⹉", num));
                        A_1.method_18(BookmarkStart.b("䌳వ娷崹弻儽ⰿⵁ㙃", num), Class735.smethod_2(picture.Fill.ColorInternal, false, true));
                        Class963.smethod_1(picture, true, A_1, A_2);
                        A_1.method_5();
                        A_1.method_5();
                    }
                    break;
                }
                case BackgroundType.Color:
                    A_1.method_4(BookmarkStart.b("䌳వ娷嬹弻唽✿ぁ⭃㍅♇⹉", num));
                    A_1.method_18(BookmarkStart.b("䌳వ娷崹弻儽ⰿⵁ㙃", num), Class735.smethod_2(A_0.Color, false, true));
                    A_1.method_5();
                    break;
            }
            A_1.method_5();
        }
    }

    private void method_15(BackgroundGradient A_0, Class398 A_1)
    {
        int num = 13;
        A_1.method_4(BookmarkStart.b("䔲༴唶堸堺嘼堾㍀ⱂい⥆ⵈ", 13));
        if (A_0.Color1 != Color.White)
        {
            A_1.method_18(BookmarkStart.b("唲尴嬶唸堺刼匾⹀ㅂ", num), BookmarkStart.b("ဲ", num) + Class735.smethod_1(A_0.Color1));
        }
        A_1.method_4(BookmarkStart.b("䔲༴儶倸场儼", num));
        this.method_17(A_0, A_1);
        this.method_16(A_0, A_1);
        A_1.method_5();
        A_1.method_5();
    }

    private void method_16(BackgroundGradient A_0, Class398 A_1)
    {
        int num = 0x12;
        switch (A_0.ShadingStyle)
        {
            case GradientShadingStyle.Vertical:
                A_1.method_18(BookmarkStart.b("夷吹嬻刽┿", num), BookmarkStart.b("ᔷ̹఻", num));
                break;

            case GradientShadingStyle.DiagonalUp:
                A_1.method_18(BookmarkStart.b("夷吹嬻刽┿", num), BookmarkStart.b("ᔷହ༻ଽ", num));
                break;

            case GradientShadingStyle.DiagonalDown:
            case GradientShadingStyle.FromCorner:
            case GradientShadingStyle.FromCenter:
                A_1.method_18(BookmarkStart.b("夷吹嬻刽┿", num), BookmarkStart.b("ᔷูऻ", num));
                break;
        }
        A_1.method_18(BookmarkStart.b("唷弹䠻嘽⼿♁", num), BookmarkStart.b("吷匹刻嬽ℿぁ摃㕅ⅇⵉ⅋⽍", num));
        if (A_0.ShadingStyle == GradientShadingStyle.FromCorner)
        {
            A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿", num), BookmarkStart.b("षਹ఻ᬽ", num));
        }
        else if (A_0.ShadingVariant == GradientShadingVariant.ShadingMiddle)
        {
            A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿", num), BookmarkStart.b("ഷਹ᤻", num));
        }
        else if (A_0.ShadingVariant == GradientShadingVariant.ShadingOut)
        {
            A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿", num), BookmarkStart.b("ᔷ༹఻ᬽ", num));
        }
        else if (A_0.ShadingVariant == GradientShadingVariant.ShadingUp)
        {
            A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿", num), BookmarkStart.b("षਹ఻ᬽ", num));
        }
        if (A_0.ShadingStyle == GradientShadingStyle.FromCenter)
        {
            A_1.method_18(BookmarkStart.b("䰷䌹䰻嬽", num), BookmarkStart.b("強䠹崻娽⤿❁⩃㉅ᩇ⭉⡋❍ㅏ㹑", num));
        }
        else
        {
            A_1.method_18(BookmarkStart.b("䰷䌹䰻嬽", num), BookmarkStart.b("強䠹崻娽⤿❁⩃㉅", num));
        }
        if (((A_0.ShadingStyle == GradientShadingStyle.FromCorner) && ((A_0.FocusLeft != 0.0) || (A_0.FocusTop != 0.0))) || (A_0.ShadingStyle == GradientShadingStyle.FromCenter))
        {
            if (A_0.ShadingStyle == GradientShadingStyle.FromCorner)
            {
                if ((A_0.FocusLeft == 1.0) && (A_0.FocusTop == 1.0))
                {
                    A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿㉁⭃㕅ⅇ㹉╋⅍㹏", num), BookmarkStart.b("षᘹ഻", num));
                }
                else if (A_0.FocusLeft == 1.0)
                {
                    A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿㉁⭃㕅ⅇ㹉╋⅍㹏", num), BookmarkStart.b("ष", num));
                }
                else if (A_0.FocusTop == 1.0)
                {
                    A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿㉁⭃㕅ⅇ㹉╋⅍㹏", num), BookmarkStart.b("ᐷହ", num));
                }
            }
            else
            {
                A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿㉁⭃㕅ⅇ㹉╋⅍㹏", num), BookmarkStart.b("ᘷ༹ျွ甿", num));
            }
            A_1.method_18(BookmarkStart.b("帷唹弻䬽㌿ㅁⵃ㱅ⵇ", num), "");
        }
        if ((A_0.ShadingStyle == GradientShadingStyle.FromCorner) || ((A_0.ShadingStyle == GradientShadingStyle.FromCenter) && (A_0.ShadingVariant == GradientShadingVariant.ShadingDown)))
        {
            A_1.method_4(BookmarkStart.b("帷匹倻刽", num));
            A_1.method_18(BookmarkStart.b("崷䈹䠻", num), BookmarkStart.b("丷匹夻䤽", num));
            A_1.method_18(BookmarkStart.b("䰷䌹䰻嬽", num), BookmarkStart.b("強䠹崻娽⤿❁⩃㉅େ⽉≋㩍㕏⁑", num));
            A_1.method_5();
        }
    }

    private void method_17(BackgroundGradient A_0, Class398 A_1)
    {
        int num = 0x12;
        if (A_0.Color2 != Color.White)
        {
            if (A_0.Color2.Name[0] == 'e')
            {
                int num2 = int.Parse(A_0.Color2.Name.Substring(6), NumberStyles.HexNumber);
                if (A_0.Color2.Name[5] == '1')
                {
                    A_1.method_18(BookmarkStart.b("嬷唹倻儽㈿灁", num), BookmarkStart.b("帷匹倻刽怿♁╃㑅⍇⽉≋晍", num) + num2 + BookmarkStart.b("ᄷ", num));
                }
                else
                {
                    A_1.method_18(BookmarkStart.b("嬷唹倻儽㈿灁", num), BookmarkStart.b("帷匹倻刽怿⹁ⵃⅅ⁇㹉⥋⁍硏", num) + num2 + BookmarkStart.b("ᄷ", num));
                }
            }
            else
            {
                A_1.method_18(BookmarkStart.b("嬷唹倻儽㈿灁", num), BookmarkStart.b("ᬷ", num) + Class735.smethod_1(A_0.Color2));
            }
        }
    }

    private void method_18()
    {
        int num = 4;
        if (this.class401_0.method_0().HasDocOleObject)
        {
            this.class399_0.method_4(BookmarkStart.b("崩ᘫ䨭弯儱笳娵崷縹崻䨽ℿ", num));
            this.class399_0.method_4(BookmarkStart.b("崩ᘫ䰭夯就瀳圵䰷嬹", num));
            this.class399_0.method_40(BookmarkStart.b("崩ᘫ䀭儯弱儳", num), BookmarkStart.b("䔩䀫䬭启匱䀳圵ᘷ圹伻儽", num));
            this.class399_0.method_19(this.class401_0.method_6());
            this.class399_0.method_5();
            this.class399_0.method_5();
        }
    }

    private void method_19()
    {
        int num = 10;
        if (smethod_0(this.document_0))
        {
            this.class399_0.method_4(BookmarkStart.b("䜯࠱倳夵嬷椹䤻丽〿ف╃㉅⥇", num));
            this.class399_0.method_4(BookmarkStart.b("䜯࠱嘳張嘷縹崻䨽ℿ", num));
            this.class399_0.method_40(BookmarkStart.b("䜯࠱娳圵唷弹", num), BookmarkStart.b("唯嘱崳䈵尷嬹䠻弽渿⽁㝃⥅", num));
            MemoryStream stream = new MemoryStream();
            Class567.smethod_2(BookmarkStart.b("焯儱䀳張丷弹焻圽ⴿ❁", num), stream);
            Class567.smethod_1(0xf0010000, stream);
            Class567.smethod_1(4, stream);
            Class567.smethod_1(uint.MaxValue, stream);
            if (smethod_0(this.document_0))
            {
                Class567.smethod_1(0xf00d0000, stream);
                byte[] buffer = this.method_20();
                Class567.smethod_1((uint) buffer.Length, stream);
                stream.Write(buffer, 0, buffer.Length);
            }
            Class567.smethod_1(0xf00b0000, stream);
            Class567.smethod_1(4, stream);
            Class567.smethod_1(0x78563412, stream);
            this.class399_0.method_19(stream);
            this.class399_0.method_5();
            this.class399_0.method_5();
        }
    }

    private byte[] method_20()
    {
        MemoryStream stream = new MemoryStream {
            Position = 0x10L,
            Position = 0L
        };
        Class567.smethod_1(0x10c, stream);
        Class567.smethod_1(0, stream);
        Class567.smethod_1(0x409, stream);
        return stream.ToArray();
    }

    private void method_21()
    {
        int num = 0x13;
        if (this.document_0.ListStyles.Count != 0)
        {
            this.dictionary_1 = new Dictionary<string, int>();
            this.class399_0.method_4(BookmarkStart.b("丸ĺ儼嘾㉀㝂㙄", num));
            this.method_23();
            this.method_26();
            this.method_27();
            this.class399_0.method_5();
        }
    }

    internal int method_22(ListFormat A_0)
    {
        int num = 0;
        if (!string.IsNullOrEmpty(A_0.CurrentListStyle.Name))
        {
            foreach (KeyValuePair<string, string> pair in this.Interface52.imethod_0().ListStyles.ListStyleNames)
            {
                if (pair.Value == A_0.CustomStyleName)
                {
                    break;
                }
                num++;
            }
        }
        if (!string.IsNullOrEmpty(A_0.LFOStyleName))
        {
            string lFOStyleName = A_0.LFOStyleName;
            if (this.dictionary_1.ContainsKey(lFOStyleName))
            {
                num = this.dictionary_1[lFOStyleName];
            }
            return num;
        }
        num++;
        return num;
    }

    private void method_23()
    {
        int num = 1;
        foreach (ListStyle style in this.document_0.ListStyles)
        {
            int num2 = 0;
            int count = style.Levels.Count;
            while (num2 < count)
            {
                ListLevel level = style.Levels[num2];
                if ((level.PicBullet != null) && !string.IsNullOrEmpty(this.method_24(this.dictionary_0, level.PicBullet.ImageRecord)))
                {
                    this.class399_0.method_4(BookmarkStart.b("倦ጨ䜪䐬尮䔰挲尴吶笸为儼匾⑀㝂", num));
                    this.class399_0.method_43(BookmarkStart.b("倦ጨ䜪䐬尮䔰挲尴吶笸为儼匾⑀㝂ౄ⍆", num), level.PicBulletId);
                    this.class399_0.method_4(BookmarkStart.b("倦ጨ嬪䐬䰮䔰", num));
                    Class963.smethod_0(level.PicBullet, this.class399_0, this.class401_0);
                    this.class399_0.method_5();
                    this.class399_0.method_5();
                    this.class399_0.method_5();
                }
                num2++;
            }
        }
    }

    private string method_24(Dictionary<string, Class517> A_0, Class517 A_1)
    {
        string key = string.Empty;
        if (!A_0.ContainsValue(A_1))
        {
            key = this.method_25().ToString();
            A_0.Add(key, A_1);
        }
        return key;
    }

    private int method_25()
    {
        return ++this.int_1;
    }

    private void method_26()
    {
        int num = 7;
        for (int i = 0; i < this.document_0.ListStyles.Count; i++)
        {
            ListStyle style = this.document_0.ListStyles[i];
            this.class399_0.method_4(BookmarkStart.b("娬ᔮ崰娲䘴䌶紸帺嬼", num));
            this.class399_0.method_43(BookmarkStart.b("娬ᔮ崰娲䘴䌶紸帺嬼瘾╀", num), i);
            this.class399_0.method_28(BookmarkStart.b("娬ᔮ崰䀲尴匶", num), i);
            this.class399_0.method_24(BookmarkStart.b("娬ᔮ䄰弲䄴", num), Class463.smethod_5(style.ListLevelsType));
            this.class399_0.method_24(BookmarkStart.b("娬ᔮ䔰帲䔴嬶", num), Class114.smethod_5(style.TemplateCode));
            this.class399_0.method_24(BookmarkStart.b("娬ᔮ弰刲場制", num), style.Name);
            for (int j = 0; j < style.Levels.Count; j++)
            {
                this.method_28(style.Levels[j], j);
            }
            this.class399_0.method_5();
        }
    }

    private void method_27()
    {
        int num = 6;
        int num2 = 1;
        foreach (string str in this.document_0.ListStyles.ListStyleNames.Values)
        {
            int num3 = this.document_0.ListStyles.method_5(str);
            if (num3 >= 0)
            {
                this.class399_0.method_4(BookmarkStart.b("嬫ᐭ尯嬱䜳䈵", num));
                this.class399_0.method_43(BookmarkStart.b("嬫ᐭ夯帱刳夵", num), num2);
                this.class399_0.method_28(BookmarkStart.b("嬫ᐭ夯帱䜳䈵", num), num3);
                Class12 class2 = this.document_0.ListOverrides.method_36(num2);
                if (class2 != null)
                {
                    foreach (KeyValuePair<int, int> pair in class2.method_23().method_7())
                    {
                        OverrideLevelFormat format = class2.method_23().method_5(pair.Key);
                        this.class399_0.method_4(BookmarkStart.b("嬫ᐭ尯䐱堳礵丷弹主䰽⤿♁⅃", num));
                        this.class399_0.method_43(BookmarkStart.b("嬫ᐭ夯帱䈳娵", num), pair.Key);
                        if (format.OverrideStartAtValue)
                        {
                            this.class399_0.method_24(BookmarkStart.b("嬫ᐭ䌯䘱唳䐵䰷甹䨻嬽㈿ぁⵃ≅ⵇ", num), format.StartAt.ToString());
                        }
                        if (format.OverrideFormatting)
                        {
                            this.method_28(format.OverrideListLevel, pair.Key);
                        }
                        this.class399_0.method_5();
                    }
                    this.dictionary_1.Add(class2.Name, num2);
                }
                this.class399_0.method_5();
                num2++;
            }
        }
    }

    private void method_28(ListLevel A_0, int A_1)
    {
        int num = 8;
        this.class399_0.method_4(BookmarkStart.b("夭ਯ帱䈳娵", 8));
        this.class399_0.method_43(BookmarkStart.b("夭ਯ嬱堳䀵吷", 8), A_0.LevelNumber);
        this.class399_0.vmethod_2(BookmarkStart.b("夭ਯ䘱儳堵䰷嬹䠻圽㘿❁", 8), false);
        this.class399_0.method_28(BookmarkStart.b("夭ਯ䄱䀳圵䨷丹", 8), A_0.StartAt);
        if (!string.IsNullOrEmpty(A_0.ParaStyleName) && this.Interface52.imethod_0().StyleNameIds.ContainsKey(A_0.ParaStyleName))
        {
            IParagraphStyle style = this.Interface52.imethod_0().Styles.FindByName(this.Interface52.imethod_0().StyleNameIds[A_0.ParaStyleName], StyleType.ParagraphStyle) as IParagraphStyle;
            if (style != null)
            {
                string str3 = this.class401_0.method_4((style as Style).Istd);
                this.class399_0.method_4(BookmarkStart.b("夭ਯ䈱朳䈵䄷嘹夻", num));
                this.class399_0.method_18(BookmarkStart.b("夭ਯ䐱唳娵", num), str3);
                this.class399_0.method_5();
            }
        }
        if (A_0.PatternType != ListPatternType.Arabic)
        {
            this.class399_0.method_28(BookmarkStart.b("夭ਯ就刳唵", num), (int) A_0.PatternType);
        }
        if (A_0.NoRestartByHigher)
        {
            this.class399_0.method_28(BookmarkStart.b("夭ਯ帱䈳娵樷弹伻䨽ℿぁぃ", num), 0);
        }
        this.class399_0.method_31(BookmarkStart.b("夭ਯ嬱䜳稵強嘹", num), false);
        if (A_0.FollowCharacter != FollowCharacterType.Tab)
        {
            this.class399_0.method_24(BookmarkStart.b("夭ਯ䄱䄳倵帷", num), Class463.smethod_3(A_0.FollowCharacter));
        }
        if (((A_0.NumberPrefix != null) || (A_0.NumberSufix != null)) || (A_0.BulletCharacter != null))
        {
            this.class399_0.method_4(BookmarkStart.b("夭ਯ帱䈳娵氷弹䐻䨽", num));
            if (A_0.PatternType == ListPatternType.Bullet)
            {
                this.class399_0.method_40(BookmarkStart.b("夭ਯ䐱唳娵", num), A_0.BulletCharacter);
            }
            else
            {
                string str2 = string.Empty;
                if ((A_0.NumberPrefix != null) && (A_0.NumberPrefix.Length > 0))
                {
                    str2 = Class114.smethod_0(A_0.NumberPrefix);
                }
                string levelText = str2;
                if (!A_0.NoLevelText && (A_0.NumberSufix != null))
                {
                    char ch = this.method_29(A_0.LevelNumber);
                    A_0.NumberSufix = A_0.NumberSufix.Replace(ch.ToString(), string.Empty);
                    char[] trimChars = new char[1];
                    levelText = levelText + BookmarkStart.b("ଭ", num) + ((A_1 + 1)).ToString() + A_0.NumberSufix.Trim(trimChars);
                }
                else if (A_0.PatternType == ListPatternType.None)
                {
                    levelText = A_0.LevelText;
                }
                this.class399_0.method_40(BookmarkStart.b("夭ਯ䐱唳娵", num), levelText);
            }
            this.class399_0.method_5();
        }
        if (!A_0.IsEmptyPicture)
        {
            this.class399_0.method_28(BookmarkStart.b("夭ਯ帱䈳娵样匹弻簽㔿⹁⡃⍅㱇͉⡋", num), A_0.PicBulletId);
        }
        this.class399_0.method_24(BookmarkStart.b("夭ਯ帱䈳娵爷夹", num), Class463.smethod_1(A_0.NumberAlignment));
        Class696.smethod_0(A_0.ParagraphFormat, this);
        Paragraph ownerBase = A_0.OwnerBase as Paragraph;
        Class418.smethod_2(A_0.CharacterFormat, ownerBase, this);
        this.class399_0.method_5();
    }

    private char method_29(int A_0)
    {
        switch (A_0)
        {
            case 1:
                return '\0';

            case 2:
                return '\x0001';

            case 3:
                return '\x0002';

            case 4:
                return '\x0003';

            case 5:
                return '\x0004';

            case 6:
                return '\x0005';

            case 7:
                return '\x0006';

            case 8:
                return '\a';
        }
        return '\b';
    }

    public void method_3(Document A_0, Stream A_1)
    {
        Class253 class2 = Class253.smethod_0(FileFormat.WordML);
        Class928 class3 = new Class928(A_0, A_1, string.Empty, class2);
        class3.method_4();
        this.document_0 = A_0;
        this.class399_0 = new Class399(A_1, class3.class253_0.method_6());
        this.class401_0 = new Class401(class3, A_0, this.class399_0);
        this.class561_0 = new Class561(this);
        this.stack_1 = new Stack();
        this.int_2 = 0;
        this.idictionary_1 = Class83.smethod_0();
        this.idictionary_0 = Class83.smethod_0();
        this.method_5();
    }

    private void method_30()
    {
        this.class399_0.method_4(BookmarkStart.b("䘰ल䘴䌶䀸场堼䰾", 11));
        this.class399_0.method_24(BookmarkStart.b("䘰ल䌴制䬸䠺吼倾⽀ూ⍄Ն㱈≊⅌㭎ᡐ㵒ٔ⍖⁘㝚㡜ㅞ`๢dᑦ", 11), Class1041.smethod_8(7));
        this.method_31();
        StyleCollection docStyleCollection = this.class401_0.method_0().Styles.DocStyleCollection;
        for (int i = 0; i < docStyleCollection.Count; i++)
        {
            this.method_33((Style) docStyleCollection[i]);
        }
        this.class399_0.method_5();
    }

    private void method_31()
    {
        int num = 12;
        Class547 latentStyles = this.class401_0.method_0().Styles.LatentStyles;
        this.class399_0.method_4(BookmarkStart.b("䔱ำ娵夷丹夻倽㐿ᅁぃ㽅⑇⽉㽋", 12));
        this.class399_0.vmethod_1(BookmarkStart.b("䔱ำ刵崷尹瀻儽⌿⥁⅃≅ᭇ㹉ⵋ㩍㕏", 12), latentStyles.method_2());
        this.class399_0.method_43(BookmarkStart.b("䔱ำ娵夷丹夻倽㐿ᅁぃ㽅⑇⽉ཋ⅍╏㱑⁓", 12), latentStyles.method_12());
        for (int i = 0; i < latentStyles.method_14().method_5(); i++)
        {
            Class66 class3 = latentStyles.method_14().method_4(i);
            string str = Class417.smethod_26(class3.method_2(), "");
            if (Class567.smethod_16(str) && (class3.method_3() != latentStyles.method_2()))
            {
                this.class399_0.method_4(BookmarkStart.b("䔱ำ娵䬷帹礻䘽⌿❁㑃㉅ⅇ╉≋", num));
                this.class399_0.method_18(BookmarkStart.b("䔱ำ堵夷圹夻", num), str);
                this.class399_0.vmethod_1(BookmarkStart.b("䔱ำ娵圷夹圻嬽␿", num), class3.method_3());
                this.class399_0.method_5();
            }
        }
        this.class399_0.method_5();
    }

    private string method_32(Style A_0)
    {
        int num = 15;
        string name = A_0.Name;
        string str2 = string.Empty;
        switch (A_0.TypeCode)
        {
            case WordStyleType.TableStyle:
                if (((name == BookmarkStart.b("愴嘶嬸场堼焾⹀ㅂ⡄♆╈", num)) || (name == BookmarkStart.b("愴嘶嬸场堼Ἶཀⱂ㝄⩆⡈❊", num))) || ((name == BookmarkStart.b("笴堶䬸嘺尼匾ᕀ≂❄⭆ⱈ", num)) || (name == BookmarkStart.b("笴堶䬸嘺尼匾慀ᝂ⑄╆╈⹊", num))))
                {
                    return str2;
                }
                return BookmarkStart.b("䄴嘶嬸场堼", num);

            case WordStyleType.ListStyle:
                return BookmarkStart.b("嬴䈶吸夺堼䴾⡀ⵂ≄", num);
        }
        return Class911.smethod_9(A_0.StyleType);
    }

    private void method_33(Style A_0)
    {
        int num = 8;
        if ((A_0.Name == BookmarkStart.b("怭弯䀱夳圵吷", 8)) && ((this.Interface52.imethod_0().DefCharFormat != null) || (this.Interface52.imethod_0().DefParaFormat != null)))
        {
            if (this.Interface52.imethod_0().DefCharFormat != null)
            {
                A_0.CharacterFormat.method_25(this.Interface52.imethod_0().DefCharFormat);
            }
            if (this.Interface52.imethod_0().DefParaFormat != null)
            {
                A_0.ParaPr.method_25(this.Interface52.imethod_0().DefParaFormat);
            }
        }
        this.class399_0.method_4(BookmarkStart.b("夭ਯ䄱䀳伵吷弹", num));
        this.class399_0.method_18(BookmarkStart.b("夭ਯ䘱䴳䘵崷", num), this.method_32(A_0));
        switch (A_0.StyleIdentifier)
        {
            case StyleIdentifier.TableNormal:
            case StyleIdentifier.NoList:
            case StyleIdentifier.Normal:
            case StyleIdentifier.DefaultParagraphFont:
                this.class399_0.method_18(BookmarkStart.b("夭ਯ嘱儳倵夷伹倻䨽", num), BookmarkStart.b("䄭帯", num));
                break;
        }
        this.class399_0.method_18(BookmarkStart.b("夭ਯ䄱䀳伵吷弹画娽", num), this.class401_0.method_4(A_0.StyleDocId));
        string str = Class417.smethod_26(A_0.StyleIdentifier, A_0.Name);
        this.class399_0.method_24(BookmarkStart.b("夭ਯ就唳嬵崷", num), str);
        if (A_0.Name != str)
        {
            this.class399_0.method_24(BookmarkStart.b("夭䠯࠱䄳張瘷嬹儻嬽", num), A_0.Name);
        }
        if (A_0.BaseStyle != null)
        {
            this.class399_0.method_24(BookmarkStart.b("夭ਯ倱唳䔵崷帹猻倽", num), this.class401_0.method_4(A_0.Document.Styles.DocStyleCollection.method_17(A_0.BaseStyle as Style)));
        }
        if (!string.IsNullOrEmpty(A_0.NextStyle))
        {
            string str2 = A_0.NextStyle.Replace(BookmarkStart.b("อ", num), string.Empty);
            this.class399_0.method_24(BookmarkStart.b("夭ਯ就儳丵䰷", num), str2);
        }
        if (!string.IsNullOrEmpty(A_0.LinkStyle))
        {
            string str3 = A_0.LinkStyle.Replace(BookmarkStart.b("อ", num), string.Empty);
            this.class399_0.method_24(BookmarkStart.b("夭ਯ帱崳堵匷", num), str3);
        }
        this.class399_0.method_31(BookmarkStart.b("夭ਯ匱䄳䈵圷根夻娽┿⑁ⵃ⡅ⵇ", num), A_0.AutomaticallyUpdate);
        this.class399_0.method_31(BookmarkStart.b("夭ਯ娱崳刵尷弹刻", num), A_0.Hidden);
        this.class399_0.method_31(BookmarkStart.b("夭ਯ䄱儳嬵儷爹唻娽␿❁⩃", num), A_0.IsSemiHidden);
        this.class399_0.method_31(BookmarkStart.b("夭ਯ帱嬳唵匷弹堻", num), A_0.Locked);
        this.class399_0.method_31(BookmarkStart.b("夭ਯ䈱儳䐵䬷唹刻弽ⰿ", num), A_0.Personal);
        this.class399_0.method_31(BookmarkStart.b("夭ਯ䈱儳䐵䬷唹刻弽ⰿŁ⭃⭅㡇╉㽋⭍", num), A_0.PersonalCompose);
        this.class399_0.method_31(BookmarkStart.b("夭ਯ䈱儳䐵䬷唹刻弽ⰿ၁⅃㙅⑇㍉", num), A_0.PersonalReply);
        if (A_0.Rsid != 0)
        {
            this.class399_0.method_24(BookmarkStart.b("夭ਯ䀱䜳張尷", num), Class114.smethod_5(A_0.Rsid));
        }
        switch (A_0.StyleType)
        {
            case StyleType.ParagraphStyle:
                Class696.smethod_0((A_0 as ParagraphStyle).ParagraphFormat, this);
                Class418.smethod_2((A_0 as ParagraphStyle).CharacterFormat, A_0, this);
                break;

            case StyleType.CharacterStyle:
                Class418.smethod_2((A_0 as Class11).CharacterFormat, A_0, this);
                break;

            case StyleType.TableStyle:
                Class696.smethod_0((A_0 as Class13).imethod_0(), this);
                Class418.smethod_2((A_0 as Class13).CharacterFormat, A_0, this);
                break;
        }
        if (A_0.StyleType == StyleType.TableStyle)
        {
            Class13 class2 = (Class13) A_0;
            if (!class2.Interface8.imethod_3().IsDefault)
            {
                Class923.smethod_0(class2.Interface8.imethod_3(), true, true, this);
            }
            if (!class2.Interface8.imethod_2().IsDefault)
            {
                Class923.smethod_0(class2.Interface8.imethod_2(), false, true, this);
            }
            if (!class2.Interface8.imethod_1().IsDefault)
            {
                Class583.smethod_0(class2.Interface8.imethod_1(), this);
            }
            this.method_34(class2);
        }
        this.class399_0.method_5();
    }

    private void method_34(Class13 A_0)
    {
        this.class399_0.method_4(BookmarkStart.b("䘰ल䄴唶唸栺䤼䘾ⵀ♂ᕄ㕆", 11));
        this.class399_0.method_40(BookmarkStart.b("䘰ल䄴丶䤸帺", 11), Class417.smethod_5((ConditionalFormattingCode) A_0.TypeCode));
        if (!A_0.imethod_0().IsDefault)
        {
            Class696.smethod_0(A_0.imethod_0(), this);
        }
        if (!A_0.CharacterFormat.IsDefault)
        {
            Class418.smethod_2(A_0.CharacterFormat, A_0, this);
        }
        if (!A_0.Interface8.imethod_3().IsDefault)
        {
            Class923.smethod_0(A_0.Interface8.imethod_3(), true, true, this);
        }
        if (!A_0.Interface8.imethod_2().IsDefault)
        {
            Class923.smethod_0(A_0.Interface8.imethod_2(), false, true, this);
        }
        if (!A_0.Interface8.imethod_1().IsDefault)
        {
            Class583.smethod_0(A_0.Interface8.imethod_1(), this);
        }
        this.class399_0.method_5();
    }

    private void method_35(ShapeObject A_0)
    {
        switch (A_0.ShapeType)
        {
            case ShapeType.OleObject:
                this.method_36(A_0);
                break;

            case ShapeType.OleControl:
                this.method_37(A_0);
                break;
        }
    }

    private void method_36(ShapeObject A_0)
    {
        int num = 2;
        if ((this.class401_0.method_3() != null) && (A_0.docOleObject_0 != null))
        {
            DocOleObject oleFormat = A_0.OleFormat;
            this.class401_0.method_3().method_290(oleFormat, Class734.smethod_4(A_0));
        }
        else
        {
            DocOleObject obj3 = A_0.OleFormat;
            this.class399_0.method_4(BookmarkStart.b("䜧ဩ挫戭甯紱嘳尵崷夹䠻", num));
            this.class399_0.method_40(BookmarkStart.b("簧匩尫䬭", num), obj3.IsLink ? BookmarkStart.b("搧䌩䈫䔭", num) : BookmarkStart.b("洧䜩丫䬭启", num));
            this.class399_0.method_40(BookmarkStart.b("砧堩䌫䤭礯瘱", num), obj3.Interface49.get_ObjectType());
            this.class399_0.method_40(BookmarkStart.b("笧䈩䴫席唯笱瀳", num), Class734.smethod_4(A_0));
            this.class399_0.method_40(BookmarkStart.b("氧堩䴫夭焯䄱䐳匵嬷丹", num), obj3.Interface49.get_DisplayAsIcon() ? BookmarkStart.b("愧䤩䌫䀭", num) : BookmarkStart.b("欧䔩䈫娭唯就䀳", num));
            if (obj3.IsLink)
            {
                this.class399_0.method_40(BookmarkStart.b("紧娩䠫伭䐯圱礳夵尷弹", num), BookmarkStart.b("椧䘩嬫伭䤯䄱", num));
                this.class399_0.method_31(BookmarkStart.b("䜧ဩ怫䄭匯失儳刵縷匹夻刽␿", num), false);
                this.class399_0.method_11(BookmarkStart.b("䜧ဩ笫䄭䈯嘱爳張崷嘹堻紽⼿♁⅃㕅", num), BookmarkStart.b("琧䰩ఫ", num) + '\\'.ToString() + '\\'.ToString() + BookmarkStart.b("丧਩ᰫ", num));
            }
            else
            {
                this.class399_0.method_40(BookmarkStart.b("朧䠩䘫䬭匯䘱紳爵", num), BookmarkStart.b("眧", num) + obj3.Interface49.get_OleStorageName());
            }
            this.class399_0.method_5();
        }
    }

    private void method_37(ShapeObject A_0)
    {
        int num = 4;
        DocOleObject oleFormat = A_0.OleFormat;
        if (oleFormat != null)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(oleFormat.Interface49.get_OlePicture().ImageBytes, 0, oleFormat.Interface49.get_OlePicture().ImageBytes.Length);
            string str = this.class401_0.method_10(BookmarkStart.b("ᠩḫ", num), BookmarkStart.b("䜩弫䄭", num), stream);
            this.class399_0.method_4(BookmarkStart.b("崩ᘫ䄭匯䨱", num));
            this.class399_0.method_40(BookmarkStart.b("崩ᘫ䨭儯䘱唳", num), str);
            if (!A_0.IsInline)
            {
                this.class399_0.method_40(BookmarkStart.b("崩ᘫ崭堯匱䐳匵儷帹", num), Class734.smethod_3(A_0));
                this.class399_0.method_40(BookmarkStart.b("崩ᘫ䴭尯匱䜳䔵", num), BookmarkStart.b("天䐫伭䀯圱", num));
            }
            this.class399_0.method_45(BookmarkStart.b("崩ᘫ夭", num), Class969.smethod_0(A_0.Width));
            this.class399_0.method_45(BookmarkStart.b("崩ᘫ䘭", num), Class969.smethod_0(A_0.Height));
            this.class399_0.method_40(BookmarkStart.b("崩含ᐭ夯戱儳䐵䬷匹伻䨽ဿぁ⭃㙅ⵇ㡉㡋㝍቏㍑㍓", num), BookmarkStart.b("帩師嬭唯", num));
            this.class399_0.method_5();
        }
    }

    private void method_38(ShapeObject A_0)
    {
        this.method_39(A_0.HyperlinkAddress, A_0.HyperlinkSubAddress, A_0.Target, A_0.ScreenTip);
    }

    private void method_39(string A_0, string A_1, string A_2, string A_3)
    {
        this.class399_0.method_4(BookmarkStart.b("丸ĺ唼匾⡀ⵂ⹄", 0x13));
        this.class399_0.method_40(BookmarkStart.b("丸ĺ夼娾㉀㝂", 0x13), A_0);
        this.class399_0.method_40(BookmarkStart.b("丸ĺ弼倾⹀⡂⡄♆㭈⁊", 0x13), A_1);
        this.class399_0.method_40(BookmarkStart.b("丸ĺ䤼帾㍀⑂⁄㍆", 0x13), A_2);
        this.class399_0.method_40(BookmarkStart.b("丸ĺ丼尾㍀♂⁄⥆ᵈ≊㵌", 0x13), A_3);
    }

    public void method_4(Document A_0, string A_1)
    {
        using (FileStream stream = new FileStream(A_1, FileMode.Create, FileAccess.Write))
        {
            this.method_3(A_0, stream);
            stream.Flush();
        }
    }

    private void method_40()
    {
        this.class399_0.method_6(BookmarkStart.b("伷9吻刽⤿ⱁ⽃", 0x12));
    }

    private void method_41(FieldMark A_0, Field A_1)
    {
        int num = 0x13;
        if (A_0 != null)
        {
            this.method_53(A_0.CharacterFormat);
            this.class561_0.method_4(A_0.CharacterFormat, A_0, false);
        }
        else
        {
            this.method_53(A_1.CharacterFormat);
            this.class561_0.method_4(A_1.CharacterFormat, A_0, false);
        }
        string str = BookmarkStart.b("嬸帺娼嘾⽀", num);
        if (A_0 == null)
        {
            str = BookmarkStart.b("嬸帺娼嘾⽀", num);
            this.stack_1.Push(str);
            this.int_2++;
        }
        else
        {
            switch (A_0.Type)
            {
                case FieldMarkType.FieldSeparator:
                    str = BookmarkStart.b("䨸帺䴼帾㍀≂ㅄ≆", num);
                    if (this.stack_1.Count > 0)
                    {
                        this.stack_1.Pop();
                    }
                    this.stack_1.Push(str);
                    this.int_2--;
                    break;

                case FieldMarkType.FieldEnd:
                    str = BookmarkStart.b("尸唺夼", num);
                    if ((this.stack_1.Count > 0) && (((string) this.stack_1.Pop()) == BookmarkStart.b("嬸帺娼嘾⽀", num)))
                    {
                        this.int_2--;
                    }
                    break;
            }
        }
        this.class561_0.method_11(this.int_2 != 0);
        this.class399_0.method_34(BookmarkStart.b("丸ĺ嬼匾╀Bⵄ♆㭈", num), new object[] { BookmarkStart.b("丸ĺ嬼匾╀Bⵄ♆㭈Ὂ㑌㽎㑐", num), str });
        if ((A_0 == null) && (this.class401_0.method_3() == null))
        {
            this.class399_0.vmethod_2(BookmarkStart.b("丸ĺ夼嘾㍀㝂㱄", num), A_1.IsDirty);
            this.class399_0.vmethod_2(BookmarkStart.b("丸ĺ嬼匾╀ག⩄⑆≈", num), A_1.IsLocked);
        }
        this.method_42(A_1);
        this.class399_0.method_5();
        this.class561_0.method_5();
        if (A_0 != null)
        {
            this.method_54(A_0.CharacterFormat);
        }
        else
        {
            if (A_1.Type == FieldType.FieldTOC)
            {
                A_1.Text = BookmarkStart.b("洸琺縼Ἶ", num) + A_1.FormattingString;
            }
            else if (A_1.Type != FieldType.FieldFormTextInput)
            {
                A_1.Text = A_1.Code;
            }
            if (A_1.Type == FieldType.FieldFormTextInput)
            {
                TextRange range = new TextRange(A_1.Document, A_1.Code, A_1.CharacterFormat);
                this.vmethod_16(range);
            }
            else
            {
                this.vmethod_16(A_1);
            }
        }
    }

    private void method_42(Field A_0)
    {
        int num = 0x13;
        FormField field = A_0 as FormField;
        if (field != null)
        {
            this.class399_0.method_4(BookmarkStart.b("丸ĺ嬼匾╀݂⑄㍆⡈", num));
            MemoryStream stream = field.method_244();
            this.class399_0.method_19(stream);
            this.class399_0.method_5();
        }
    }

    private void method_43(Break A_0)
    {
        int num = 0x13;
        this.class399_0.method_4(BookmarkStart.b("丸ĺ似", 0x13));
        if (A_0.IsCrBreak)
        {
            this.class399_0.method_4(BookmarkStart.b("丸ĺ帼䴾", num));
            this.class399_0.method_5();
            this.class399_0.method_5();
        }
        else
        {
            this.class399_0.method_4(BookmarkStart.b("丸ĺ弼䴾", num));
            switch (A_0.BreakType)
            {
                case BreakType.PageBreak:
                    this.class399_0.method_40(BookmarkStart.b("丸ĺ䤼䘾ㅀ♂", num), BookmarkStart.b("䤸娺娼娾", num));
                    break;

                case BreakType.ColumnBreak:
                    this.class399_0.method_40(BookmarkStart.b("丸ĺ䤼䘾ㅀ♂", num), BookmarkStart.b("娸吺儼䨾ⱀⵂ", num));
                    break;

                case BreakType.LineBreak:
                    if (A_0.ClearType != LineBreakClear.None)
                    {
                        this.class399_0.method_40(BookmarkStart.b("丸ĺ䤼䘾ㅀ♂", num), BookmarkStart.b("䴸帺䔼䬾汀㑂㝄♆㥈㭊⑌ⅎ㙐", num));
                        this.class399_0.method_40(BookmarkStart.b("丸ĺ帼匾⑀≂㝄", num), Class860.smethod_12(A_0.ClearType));
                    }
                    break;
            }
            this.class399_0.method_5();
            this.class399_0.method_5();
        }
    }

    private void method_44(Symbol A_0)
    {
        this.method_53(A_0.CharacterFormat);
        this.class561_0.method_4(A_0.CharacterFormat, A_0.OwnerParagraph, false);
        this.class399_0.method_4(BookmarkStart.b("夭ਯ䄱䴳嬵", 8));
        this.class399_0.method_40(BookmarkStart.b("夭ਯ吱嬳堵䰷", 8), A_0.FontName);
        this.class399_0.method_40(BookmarkStart.b("夭ਯ儱尳圵䨷", 8), Convert.ToString((int) A_0.Text, 0x10).ToUpper());
        this.class399_0.method_5();
        this.class561_0.method_5();
        this.method_54(A_0.method_27());
    }

    private void method_45()
    {
        int num = 11;
        if (this.list_0.Count > 0)
        {
            for (int i = 0; i < this.list_0.Count; i++)
            {
                this.class399_0.method_4(BookmarkStart.b("倰帲头ശ堸唺匼倾㕀≂ㅄ⹆♈╊", num));
                this.class399_0.method_40(BookmarkStart.b("倰帲头ശ倸强", num), this.list_0[i].ToString());
                this.class399_0.method_40(BookmarkStart.b("䘰ल䄴丶䤸帺", num), BookmarkStart.b("昰尲䜴匶᜸示刼倾⩀⹂⑄㕆≈敊ࡌⅎ㕐", num));
                this.class399_0.method_5();
            }
            this.list_0.Clear();
        }
    }

    private void method_46(MergeField A_0)
    {
        string str = this.method_48(A_0);
        bool flag = this.class399_0.method_34(BookmarkStart.b("䐲༴儶唸强渼嘾ⱀ㍂⥄≆", 13), new object[] { BookmarkStart.b("䐲༴帶圸䠺䤼䴾", 13), str });
        if (A_0.TextItems.Count > 0)
        {
            int num = 0;
            int count = A_0.TextItems.Count;
            while (num < count)
            {
                this.vmethod_16(A_0.TextItems[num] as TextRange);
                num++;
            }
        }
        else
        {
            TextRange range = new TextRange(A_0.Document);
            range.ApplyCharacterFormat(A_0.CharacterFormat);
            range.Text = A_0.Text;
            this.vmethod_16(range);
        }
        if (flag)
        {
            this.class399_0.method_5();
        }
    }

    private void method_47(Field A_0)
    {
        int num = 12;
        string str = BookmarkStart.b("稱洳昵紷根瀻眽฿ु摃ᩅ⑇橉", 12) + A_0.Value;
        this.method_41(null, A_0);
        this.class561_0.method_4(A_0.CharacterFormat, null, false);
        if (string.IsNullOrEmpty(A_0.Code))
        {
            this.class399_0.method_11(BookmarkStart.b("䔱ำ張嘷䤹䠻䰽ᐿ❁㱃㉅", num), str);
        }
        this.class561_0.method_5();
    }

    private string method_48(MergeField A_0)
    {
        int num = 14;
        StringBuilder builder = new StringBuilder();
        builder.Append(A_0.Code);
        if (A_0.Prefix != string.Empty)
        {
            builder.AppendFormat(A_0.Prefix, new object[0]);
            builder.Append(BookmarkStart.b("ำ", num));
        }
        if (A_0.TextBefore != string.Empty)
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("嘳ᘵ", num));
            builder.Append(A_0.TextBefore);
        }
        if (A_0.TextAfter != string.Empty)
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("刳ᘵ", num));
            builder.Append(A_0.TextAfter);
        }
        if (!string.IsNullOrEmpty(A_0.DateFormat))
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("琳ᘵ", num));
            builder.Append(this.string_1 + A_0.DateFormat + this.string_1);
        }
        if (!string.IsNullOrEmpty(A_0.NumberFormat))
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("ᜳᘵ", num));
            builder.Append(this.string_1 + A_0.NumberFormat + this.string_1);
        }
        if (A_0.TextFormat != TextFormat.None)
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("ḳᘵ", num));
            builder.Append(this.method_49(A_0.TextFormat));
        }
        builder.Append(A_0.FormattingString);
        return builder.ToString();
    }

    private string method_49(TextFormat A_0)
    {
        int num = 0x11;
        switch (A_0)
        {
            case TextFormat.Uppercase:
                return BookmarkStart.b("戶䤸䬺堼䴾", num);

            case TextFormat.Lowercase:
                return BookmarkStart.b("笶嘸䰺堼䴾", num);

            case TextFormat.FirstCapital:
                return BookmarkStart.b("然倸䤺丼䬾ɀ≂㕄", num);

            case TextFormat.Titlecase:
                return BookmarkStart.b("琶堸䬺丼", num);
        }
        return "";
    }

    private void method_5()
    {
        int num = 10;
        this.class399_0.method_58();
        this.class399_0.method_0().method_24(BookmarkStart.b("䜯", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵ཷᕹ๻᩽꽿낁뒃뚅뮇ꖉﮋ煉歹", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9䬻", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵ཷᕹ๻᩽꽿낁뒃뚅뮇ꖉﮋ煉歹", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("䘯", 10), BookmarkStart.b("䔯䀱娳వ䬷夹吻嬽ⴿ⍁㝃歅╇⍉⽋㱍㽏⅑㭓さⱗ睙㽛ㅝൟ塡ባ୥ѧ", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9䨻", 10), BookmarkStart.b("䔯䀱娳వ䬷夹吻嬽ⴿ⍁㝃歅╇⍉⽋㱍㽏⅑㭓さⱗ睙㽛ㅝൟ塡ባ୥ѧ", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("䜯̱г", 10), BookmarkStart.b("䔯䀱娳వ䬷夹吻嬽ⴿ⍁㝃歅╇⍉⽋㱍㽏⅑㭓さⱗ睙㽛ㅝൟ塡ୣe๧ͩཫ୭䩯ձ᭳ѵᱷ", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9䬻༽瀿", 10), BookmarkStart.b("䔯䀱娳వ䬷夹吻嬽ⴿ⍁㝃歅╇⍉⽋㱍㽏⅑㭓さⱗ睙㽛ㅝൟ塡ୣe๧ͩཫ୭䩯ձ᭳ѵᱷ", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("䌯帱", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧ᥩཫ٭ᕯάᕳ㩵ᅷ᡹๻ώﮁꮃ뒅뢇몉뾋ꆍ﶑", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9伻刽", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧ᥩཫ٭ᕯάᕳ㩵ᅷ᡹๻ώﮁꮃ뒅뢇몉뾋ꆍ﶑", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("儯弱堳", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧୩ūɭ彯䁱䑳䙵䥷啹ύᅽ", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9崻匽ⰿ", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧୩ūɭ彯䁱䑳䙵䥷啹ύᅽ", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("䜯䨱", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵ཷᕹ๻᩽꽿낁뒃뚅뮇ꖉﮍ\uda91\ufd93", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9䬻䘽", 10), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⍍㥏ㅑ♓㥕⭗㕙㩛⩝也šୣ୥䝧թ੫࡭᥯ᅱᅳ奵ཷᕹ๻᩽꽿낁뒃뚅뮇ꖉﮍ\uda91\ufd93", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("弯", 10), BookmarkStart.b("䔯䀱娳వ䬷夹吻嬽ⴿ⍁㝃歅╇⍉⽋㱍㽏⅑㭓さⱗ睙㽛ㅝൟ塡ୣe๧ͩཫ୭䩯ᵱታၵᅷ᥹᥻", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9医", 10), BookmarkStart.b("䔯䀱娳వ䬷夹吻嬽ⴿ⍁㝃歅╇⍉⽋㱍㽏⅑㭓さⱗ睙㽛ㅝൟ塡ୣe๧ͩཫ୭䩯ᵱታၵᅷ᥹᥻", 10));
        this.class399_0.method_0().method_24(BookmarkStart.b("启䘱", 10), BookmarkStart.b("䔯䜱崳刵ȷ礹฻砽琿獁瑃睅硇杉穋筍቏慑祓杕楗㹙浛獝⅟偡嵣⁥䕧婩屫⽭ㅯ䉱䑳㕵䥷乹䑻䙽뉿", 10));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9堻䨽", 10), BookmarkStart.b("䔯䜱崳刵ȷ礹฻砽琿獁瑃睅硇杉穋筍቏慑祓杕楗㹙浛獝⅟偡嵣⁥䕧婩屫⽭ㅯ䉱䑳㕵䥷乹䑻䙽뉿", 10));
        if (this.method_58())
        {
            this.class399_0.method_0().method_24(BookmarkStart.b("崯", num), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⅍⁏㝑㩓⹕㕗㙙㩛ㅝ቟ཡգብ᭧䑩ͫᱭᝯ嵱᭳ၵṷ፹ύ᭽쑿揄뾏ꂑ꒓ꚕ꺗떙ﾝ풟쪡", num));
            this.class399_0.method_18(BookmarkStart.b("䠯弱堳堵䬷9儻", num), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⅍⁏㝑㩓⹕㕗㙙㩛ㅝ቟ཡգብ᭧䑩ͫᱭᝯ嵱᭳ၵṷ፹ύ᭽쑿揄뾏ꂑ꒓ꚕ꺗떙ﾝ풟쪡", num));
        }
        this.method_6();
        this.class399_0.method_18(BookmarkStart.b("䜯࠱夳圵嬷䠹医䴽ဿぁ⅃㕅ⵇ⑉㡋", num), smethod_0(this.document_0) ? BookmarkStart.b("䤯圱䜳", num) : BookmarkStart.b("帯崱", num));
        this.class399_0.method_18(BookmarkStart.b("䜯࠱儳嬵娷弹堻娽┿♁ୃ⑅≇ᩉ㹋⭍⍏㝑㩓≕", num), this.class401_0.method_0().HasDocOleObject ? BookmarkStart.b("䤯圱䜳", num) : BookmarkStart.b("帯崱", num));
        this.class399_0.method_18(BookmarkStart.b("䜯࠱嬳唵䀷樹主嬽㌿❁⩃㉅", num), this.class401_0.Interface48.imethod_4().bool_2 ? BookmarkStart.b("䤯圱䜳", num) : BookmarkStart.b("帯崱", num));
        this.class399_0.method_0().method_24(BookmarkStart.b("䠯弱堳", num), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䤽㜿㕁橃ㅅ筇摉⍋㱍㝏絑౓᭕ᑗ留浛杝奟婡䭣ࡥ१ݩ५ᵭo፱ᝳ፵", num));
        this.class399_0.method_18(BookmarkStart.b("䠯弱堳వ䬷䨹崻崽┿", num), BookmarkStart.b("䀯䀱儳䔵崷䠹䨻嬽", num));
        if (this.class401_0.method_1().method_2())
        {
            this.class399_0.method_0().method_14(string.Format(BookmarkStart.b("ု由儳堵崷䠹崻䨽┿♁摃⑅ㅇ橉㝋繍ⵏ牑", num), BookmarkStart.b("振䈱崳䐵崷ᐹ砻儽⌿", num)));
        }
        this.method_7();
        Class863.smethod_0(this.document_0, this.class399_0, false);
        Class562.smethod_0(this.document_0, this.class399_0);
        Class862.smethod_0(this.document_0, this.class399_0, false);
        this.method_21();
        this.method_30();
        this.method_18();
        this.method_19();
        this.method_14(this.document_0.Background, this.class399_0, this.class401_0);
        Class329.smethod_0(this);
        this.class399_0.method_4(BookmarkStart.b("䜯࠱嘳夵尷䌹", num));
        for (DocumentObject obj2 = this.document_0.FirstChild; obj2 != null; obj2 = (DocumentObject) obj2.NextSibling)
        {
            this.method_8((Section) obj2);
        }
        this.class399_0.method_5();
        this.class399_0.method_3();
    }

    private void method_50(ShapeObject A_0)
    {
        int num = 12;
        this.bool_0 = false;
        if (!((Interface48) this.class401_0).imethod_7() || ((A_0.ShapeType != ShapeType.Image) && (A_0.ShapeType != ShapeType.TextBox)))
        {
            this.bool_0 = true;
            this.class561_0.method_4(A_0.CharacterFormat, A_0, false);
        }
        this.stack_0.Push(this.bool_0);
        this.class399_0.method_4(BookmarkStart.b("䔱ำ䘵儷夹䠻", num));
    }

    private void method_51()
    {
        this.class399_0.method_5();
        this.bool_0 = this.stack_0.Pop();
        if (this.bool_0)
        {
            this.class561_0.method_5();
        }
    }

    private void method_52(Paragraph A_0)
    {
        int num = 12;
        ParagraphFormat format = A_0.Format;
        TableCell cell = A_0.method_50();
        if (cell != null)
        {
            format = A_0.Format.Clone() as ParagraphFormat;
            format.method_0(A_0);
            if ((cell.Owner.Owner is Table) && ((cell.Owner.Owner as Table).TableStyle != null))
            {
                Interface8 tableStyle = (cell.Owner.Owner as Table).TableStyle;
                if (!A_0.Format.HasKey(0x4c4) && tableStyle.imethod_0().HasValue(0x4c4))
                {
                    format.AfterSpacing = tableStyle.imethod_0().AfterSpacing;
                }
                if (!A_0.Format.HasKey(0x4b0) && tableStyle.imethod_0().HasValue(0x4b0))
                {
                    format.BeforeSpacing = tableStyle.imethod_0().BeforeSpacing;
                }
                if (!A_0.Format.HasKey(0x672) && tableStyle.imethod_0().HasValue(0x672))
                {
                    format.LineSpacing = tableStyle.imethod_0().LineSpacing;
                    format.LineSpacingRule = tableStyle.imethod_0().LineSpacingRule;
                }
                if (A_0.ParaStyle != null)
                {
                    IParagraphStyle paraStyle = A_0.ParaStyle;
                    if (!A_0.Format.HasKey(0x4c4) && paraStyle.ParagraphFormat.HasValue(0x4c4))
                    {
                        format.AfterSpacing = paraStyle.ParagraphFormat.AfterSpacing;
                    }
                    if (!A_0.Format.HasKey(0x4b0) && paraStyle.ParagraphFormat.HasValue(0x4b0))
                    {
                        format.BeforeSpacing = paraStyle.ParagraphFormat.BeforeSpacing;
                    }
                    if (!A_0.Format.HasKey(0x672) && paraStyle.ParagraphFormat.HasValue(0x672))
                    {
                        format.LineSpacing = paraStyle.ParagraphFormat.LineSpacing;
                        format.LineSpacingRule = paraStyle.ParagraphFormat.LineSpacingRule;
                    }
                }
            }
        }
        if (((A_0.ListFormat.ListType != ListType.NoList) && (A_0.ListFormat.CurrentListLevel != null)) && (A_0.ListFormat.CurrentListLevel.PicBullet == null))
        {
            this.string_2 = A_0.ListText;
            this.string_3 = A_0.ListFormat.CurrentListLevel.CharacterFormat.FontName;
        }
        bool flag = Class696.smethod_1(format, this);
        this.string_2 = null;
        this.string_3 = null;
        bool flag2 = Class418.smethod_0(A_0.BreakCharacterFormat, A_0, !flag, this);
        flag = flag || flag2;
        if ((A_0 == this.paragraph_0) && !this.section_0.IsLastChild)
        {
            if (!flag)
            {
                this.class399_0.method_4(BookmarkStart.b("䔱ำ䘵样䠹", num));
                flag = true;
            }
            Class695.smethod_0(this.section_0, this);
        }
        if (flag)
        {
            this.class399_0.method_6(BookmarkStart.b("䔱ำ䘵样䠹", num));
        }
    }

    private void method_53(CharacterFormat A_0)
    {
        bool flag = ((Interface52) this).imethod_2();
        if (A_0.HasInsertRevision)
        {
            string str2 = flag ? this.class401_0.method_3().method_476() : this.Interface52.imethod_6().ToString();
            this.class399_0.vmethod_7(A_0.InsertRevision, str2, flag);
        }
        if (A_0.HasDeleteRevision)
        {
            string str = flag ? this.class401_0.method_3().method_476() : this.Interface52.imethod_6().ToString();
            this.class399_0.vmethod_7(A_0.DeleteRevision, str, flag);
        }
    }

    private void method_54(CharacterFormat A_0)
    {
        if (A_0.HasInsertRevision)
        {
            this.class399_0.vmethod_9(A_0.InsertRevision.method_4(), ((Interface52) this).imethod_2());
        }
        if (A_0.HasDeleteRevision)
        {
            this.class399_0.vmethod_9(A_0.DeleteRevision.method_4(), ((Interface52) this).imethod_2());
        }
    }

    internal string method_55()
    {
        return this.string_2;
    }

    internal string method_56()
    {
        return this.string_3;
    }

    internal void method_57(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal bool method_58()
    {
        return this.bool_2;
    }

    private void method_6()
    {
        int num = 7;
        foreach (DictionaryEntry entry in this.class401_0.Interface48.imethod_4().class181_0)
        {
            string key = (string) entry.Key;
            int num2 = (int) entry.Value;
            string str2 = (this.class401_0.Interface48.imethod_4().class181_1[key] != null) ? BookmarkStart.b("䌬尮", num) : BookmarkStart.b("帬嬮", num);
            this.class399_0.method_18(string.Format(BookmarkStart.b("唬䈮崰崲䘴ശ䈸଺䀼䐾灀㹂", num), str2, num2), key);
        }
    }

    private void method_7()
    {
    }

    private void method_8(Section A_0)
    {
        this.section_0 = A_0;
        this.paragraph_0 = A_0.Body.LastParagraph as Paragraph;
        this.class399_0.method_4(BookmarkStart.b("弧利ᘫ崭唯儱䀳", 2));
        A_0.Body.Accept(this);
        if (this.section_0.IsLastChild)
        {
            Class695.smethod_0(this.section_0, this);
        }
        this.class399_0.method_5();
    }

    private int method_9()
    {
        return ++this.int_4;
    }

    private static bool smethod_0(Document A_0)
    {
        return false;
    }

    private static bool smethod_1(ShapeObject A_0)
    {
        return ((A_0.IsInline && A_0.IsOleControl) && (A_0.OleFormat.OleObject != null));
    }

    public override VisitorAction vmethod_10(Table A_0)
    {
        int num = 13;
        if (!string.IsNullOrEmpty(A_0.TableStyleName))
        {
            A_0.method_46();
        }
        this.class399_0.method_4(BookmarkStart.b("䐲༴䌶嬸场", num));
        Class923.smethod_0(A_0.TableFormat, true, false, this);
        Class532.smethod_0(this.class399_0, A_0);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_11(Table A_0)
    {
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_12(TableRow A_0)
    {
        this.class399_0.method_4(BookmarkStart.b("尪ᜬ嬮䌰", 5));
        Class923.smethod_0(A_0.RowFormat, false, false, this);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_13(TableRow A_0)
    {
        this.class399_0.method_5();
        this.method_45();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_14(TableCell A_0)
    {
        this.class399_0.method_4(BookmarkStart.b("䐲༴䌶娸", 13));
        Class583.smethod_0(A_0.CellFormat, this);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_15(TableCell A_0)
    {
        int num = 2;
        if (A_0.Interface3.get_Count() == 0)
        {
            this.class399_0.method_4(BookmarkStart.b("弧ဩ尫", num));
            this.class399_0.method_4(BookmarkStart.b("弧ဩ尫縭䈯", num));
            this.class399_0.method_4(BookmarkStart.b("弧ဩ尫紭䐯䬱堳匵", num));
            this.class399_0.method_40(BookmarkStart.b("弧ဩ娫伭尯", num), BookmarkStart.b("昧䔩師䌭儯帱", num));
            this.class399_0.method_5();
            Class418.smethod_2(A_0.CharacterFormat, null, this);
            this.class399_0.method_5();
            this.class399_0.method_5();
        }
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_16(TextRange A_0)
    {
        this.method_53(A_0.method_27());
        this.class561_0.method_0(A_0, ((Interface52) this).imethod_2());
        this.method_54(A_0.method_27());
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_17(Symbol A_0)
    {
        this.method_44(A_0);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_18(Field A_0)
    {
        if (((this.class401_0 != null) && ((Interface48) this.class401_0).imethod_7()) && (this.class401_0.method_3() != null))
        {
            this.class401_0.method_3().method_190(A_0);
            if (A_0.Type == FieldType.FieldHyperlink)
            {
                foreach (ParagraphBase base2 in A_0.Range)
                {
                    base2.SkipDocxItem = true;
                }
            }
            return VisitorAction.Continue;
        }
        FieldType type = A_0.Type;
        if (type != FieldType.FieldMergeField)
        {
            if (type != FieldType.FieldHyperlink)
            {
                this.method_41(null, A_0);
            }
            else
            {
                this.method_47(A_0);
            }
        }
        else
        {
            this.method_46(A_0 as MergeField);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_19(FieldMark A_0)
    {
        if (((this.class401_0 != null) && ((Interface48) this.class401_0).imethod_7()) && (this.class401_0.method_3() != null))
        {
            this.class401_0.method_3().method_190(A_0);
        }
        else
        {
            this.method_41(A_0, null);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_23(BookmarkStart A_0)
    {
        int num = 0x12;
        if (this.class401_0.method_3() != null)
        {
            this.class401_0.method_3().method_366(A_0);
        }
        else
        {
            int num2 = this.Interface52.imethod_6();
            if (!this.idictionary_0.Contains(A_0.Name))
            {
                this.idictionary_0.Add(A_0.Name, num2);
            }
            else
            {
                this.idictionary_0[A_0.Name] = num2;
            }
            this.class399_0.method_4(BookmarkStart.b("夷圹倻нℿⱁ⩃⥅㱇⭉㡋❍㽏㱑", num));
            this.class399_0.method_43(BookmarkStart.b("夷圹倻н⤿♁", num), num2);
            this.class399_0.method_40(BookmarkStart.b("伷9䠻䜽〿❁", num), BookmarkStart.b("漷唹主娽渿A⭃⥅⍇❉ⵋ㱍㭏籑ݓ≕㥗⡙⡛", num));
            this.class399_0.method_18(BookmarkStart.b("伷9刻弽ⴿ❁", num), A_0.Name);
            if (A_0.IsTableColumnBookmark)
            {
                this.idictionary_1.Add(A_0.Name, A_0);
                this.class399_0.method_43(BookmarkStart.b("伷9弻儽ⰿ潁≃⽅㩇㥉㡋", num), A_0.ColumnFirst);
                this.class399_0.method_43(BookmarkStart.b("伷9弻儽ⰿ潁⡃❅㭇㹉", num), A_0.ColumnLast);
            }
            this.class399_0.method_5();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_24(Break A_0)
    {
        this.method_43(A_0);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_25(BookmarkEnd A_0)
    {
        int num = 6;
        if (this.class401_0.method_3() != null)
        {
            this.class401_0.method_3().method_364(A_0);
        }
        else if (A_0.IsCellGroupBkmk)
        {
            this.list_0.Add((int) this.idictionary_0[A_0.Name]);
        }
        else if (this.idictionary_0.Contains(A_0.Name))
        {
            this.class399_0.method_4(BookmarkStart.b("䴫䌭尯࠱唳堵嘷唹䠻弽㐿⭁⭃⡅", num));
            this.class399_0.method_43(BookmarkStart.b("䴫䌭尯࠱崳刵", num), (int) this.idictionary_0[A_0.Name]);
            this.class399_0.method_40(BookmarkStart.b("嬫ᐭ䐯䬱䐳匵", num), BookmarkStart.b("笫䄭䈯嘱ᨳ琵圷唹圻匽ℿぁ⽃桅േ⑉⡋", num));
            BookmarkStart start = (BookmarkStart) this.idictionary_1[A_0.Name];
            if (start != null)
            {
                this.class399_0.method_43(BookmarkStart.b("嬫ᐭ匯崱堳ᬵ帷匹主䴽㐿", num), start.ColumnFirst);
                this.class399_0.method_43(BookmarkStart.b("嬫ᐭ匯崱堳ᬵ吷嬹伻䨽", num), start.ColumnLast);
            }
            this.class399_0.method_5();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_26(Footnote A_0)
    {
        int num = 13;
        this.method_53(A_0.method_27());
        this.class561_0.method_4(A_0.method_27(), A_0.OwnerParagraph, false);
        switch (A_0.FootnoteType)
        {
            case FootnoteType.Footnote:
                this.class561_0.method_13(FootnoteType.Footnote);
                this.class399_0.method_4(BookmarkStart.b("䐲༴儶嘸吺䤼儾⹀㝂⁄", num));
                break;

            case FootnoteType.Endnote:
                this.class561_0.method_13(FootnoteType.Endnote);
                this.class399_0.method_4(BookmarkStart.b("䐲༴制圸强匼倾㕀♂", num));
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("昲嬴尶圸吺䨼儾慀╂⩄⡆㵈╊≌㭎㑐獒⅔⹖⥘㹚獜", num));
        }
        this.class399_0.vmethod_2(BookmarkStart.b("䐲༴䐶䰸䬺䴼䴾⑀あ㙄ᕆⱈⵊ", num), !A_0.IsAutoNumbered);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_27(PermissionEnd A_0)
    {
        int num = 0x10;
        if (this.class401_0.method_3() != null)
        {
            this.class401_0.method_3().method_120(A_0);
        }
        else if (this.dictionary_2.ContainsKey(A_0.Id))
        {
            this.class399_0.method_4(BookmarkStart.b("䄵ȷ䨹夻䰽ⴿ݁⩃≅", num));
            this.class399_0.method_43(BookmarkStart.b("䄵ȷ匹堻", num), this.dictionary_2[A_0.Id]);
            if (A_0.DisplacedByCustomXml != DisplacedByCustomXml.None)
            {
                this.class399_0.method_40(BookmarkStart.b("䄵ȷ帹唻䴽〿⹁╃╅ⵇ⹉๋㝍ፏ❑❓≕㝗㝙ћ㍝౟", num), this.method_11(A_0.DisplacedByCustomXml));
            }
            this.class399_0.method_5();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_28(PermissionStart A_0)
    {
        int num = 8;
        if (this.class401_0.method_3() != null)
        {
            this.class401_0.method_3().method_119(A_0);
        }
        else
        {
            string id = A_0.Id;
            int num2 = this.method_9();
            if (!this.dictionary_2.ContainsKey(A_0.Id))
            {
                this.dictionary_2.Add(id, num2);
            }
            else
            {
                this.dictionary_2[id] = num2;
            }
            this.class399_0.method_4(BookmarkStart.b("夭ਯ䈱儳䐵唷椹䠻弽㈿㙁", num));
            this.class399_0.method_40(BookmarkStart.b("夭ਯ嬱倳", num), num2.ToString());
            if (A_0.EditorGroup != EditingGroup.None)
            {
                this.class399_0.method_40(BookmarkStart.b("夭ਯ圱倳焵䨷䨹", num), this.method_10(A_0.EditorGroup));
            }
            if (A_0.DisplacedByCustomXml != DisplacedByCustomXml.None)
            {
                this.class399_0.method_40(BookmarkStart.b("夭ਯ嘱崳䔵䠷嘹崻崽┿♁ك㽅େ㽉㽋㩍㽏㽑౓㭕㑗", num), this.method_11(A_0.DisplacedByCustomXml));
            }
            if (!string.IsNullOrEmpty(A_0.Editor) && !A_0.Editor.Equals(""))
            {
                this.class399_0.method_40(BookmarkStart.b("夭ਯ圱倳", num), A_0.Editor);
            }
            if (A_0.ColumnFirst >= 0)
            {
                this.class399_0.method_43(BookmarkStart.b("夭ਯ儱嬳娵ᔷ尹唻䰽㌿㙁", num), A_0.ColumnFirst);
            }
            if (A_0.ColumnLast >= 0)
            {
                this.class399_0.method_43(BookmarkStart.b("夭ਯ儱嬳娵ᔷ嘹崻䴽㐿", num), A_0.ColumnLast);
            }
            this.class399_0.method_5();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_29(Footnote A_0)
    {
        this.class399_0.method_5();
        this.class561_0.method_5();
        this.method_54(A_0.method_27());
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_30(Comment A_0)
    {
        this.method_53(A_0.CharacterFormat);
        this.class561_0.method_4(A_0.CharacterFormat, A_0.OwnerParagraph, false);
        this.class399_0.method_4(BookmarkStart.b("䘦䐨䜪ᜬ丮弰崲娴䌶堸伺吼倾⽀", 1));
        this.class399_0.method_43(BookmarkStart.b("䘦䐨䜪ᜬ䘮唰", 1), this.method_12(A_0.Format.CommentId));
        this.class399_0.method_40(BookmarkStart.b("䘦䐨䜪ᜬ丮䐰䜲崴堶䬸", 1), A_0.Format.Author);
        this.class399_0.method_38(BookmarkStart.b("䘦䐨䜪ᜬ䰮䌰嘲吴䌶尸强尼䬾⑀", 1), A_0.Format.DateTime);
        this.class399_0.method_40(BookmarkStart.b("倦ጨ弪听弮吰", 1), BookmarkStart.b("瀦䘨太䤬Į爰尲場娶尸唺䤼", 1));
        this.class399_0.method_40(BookmarkStart.b("倦ጨ䈪䌬䘮䔰娲吴嬶䨸", 1), A_0.Format.Initial);
        this.class399_0.method_4(BookmarkStart.b("䘦䐨䜪ᜬ䰮帰崲䄴制圸伺", 1));
        return VisitorAction.Continue;
    }

    internal override VisitorAction vmethod_31(CommentMark A_0)
    {
        this.class399_0.method_4(BookmarkStart.b("匱夳娵ȷ嬹刻倽⼿㙁╃㉅ⅇ╉≋", 12));
        this.class399_0.method_43(BookmarkStart.b("匱夳娵ȷ匹堻", 12), this.method_12(A_0.CommentId));
        this.class399_0.method_40(BookmarkStart.b("䔱ำ䈵䄷䨹夻", 12), BookmarkStart.b("攱嬳䐵尷ᐹ缻儽ⴿ⽁⅃⡅㱇摉Ὃ㩍ㅏ⁑⁓", 12));
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_32(Comment A_0)
    {
        this.class399_0.method_5();
        this.class399_0.method_5();
        this.class561_0.method_5();
        this.method_54(A_0.method_27());
        return VisitorAction.Continue;
    }

    internal override VisitorAction vmethod_33(CommentMark A_0)
    {
        this.class399_0.method_4(BookmarkStart.b("儯弱堳వ夷吹刻儽㐿⍁ぃ⽅❇⑉", 10));
        this.class399_0.method_43(BookmarkStart.b("儯弱堳వ儷帹", 10), this.method_12(A_0.CommentId));
        this.class399_0.method_40(BookmarkStart.b("䜯࠱䀳伵䠷弹", 10), BookmarkStart.b("术崱䘳刵ᘷ礹医匽ⴿ❁⩃㉅晇ཉ≋⩍", 10));
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_34(ShapeObject A_0)
    {
        this.method_53(A_0.CharacterFormat);
        if (A_0.IsOoxmlControl)
        {
            this.bool_1 = true;
            A_0.SetShapeAttribute(0x103b, ShapeType.Image);
        }
        else
        {
            this.bool_1 = false;
        }
        A_0.method_51();
        if (A_0.IsHyperlinkedInline)
        {
            this.method_38(A_0);
        }
        if (A_0.IsTopLevel)
        {
            this.method_50(A_0);
        }
        if (!smethod_1(A_0))
        {
            Class963.smethod_0(A_0, this.class399_0, this.class401_0);
        }
        if ((A_0.HasChildElements && (this.class401_0 != null)) && (((Interface48) this.class401_0).imethod_7() && (this.class401_0.method_3() != null)))
        {
            this.class401_0.method_3().method_116(A_0.ChildObjects as BodyRegionCollection, false);
            this.vmethod_35(A_0);
            return VisitorAction.SkipThisElement;
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_35(ShapeObject A_0)
    {
        if (A_0.HasChildElements || (A_0.ShapeType == ShapeType.TextBox))
        {
            this.class399_0.method_5();
            this.class399_0.method_5();
        }
        if (!smethod_1(A_0))
        {
            Class963.smethod_4(A_0, this.class399_0);
            this.class399_0.method_5();
        }
        if (A_0.IsOle)
        {
            this.method_35(A_0);
        }
        if (A_0.IsTopLevel)
        {
            this.method_51();
        }
        if (A_0.IsHyperlinkedInline)
        {
            this.method_40();
        }
        if (this.bool_1)
        {
            A_0.SetShapeAttribute(0x103b, ShapeType.OleControl);
        }
        this.method_54(A_0.CharacterFormat);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_36(ShapeGroup A_0)
    {
        A_0.method_51();
        if (A_0.IsTopLevel)
        {
            this.method_50(A_0);
        }
        Class963.smethod_0(A_0, this.class399_0, this.class401_0);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_37(ShapeGroup A_0)
    {
        Class963.smethod_4(A_0, this.class399_0);
        this.class399_0.method_5();
        if (A_0.IsTopLevel)
        {
            this.method_51();
        }
        return VisitorAction.Continue;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override VisitorAction vmethod_38(Class5 A_0)
    {
        return VisitorAction.Continue;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override VisitorAction vmethod_39(Class5 A_0)
    {
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_40(Class9 A_0)
    {
        int num = 3;
        this.class399_0.method_4(this.method_13(BookmarkStart.b("䜨堪", 3), A_0.method_26(), A_0.method_22()));
        if (Class567.smethod_16(A_0.method_24()))
        {
            this.class399_0.method_40(BookmarkStart.b("帨ᄪ崬䌮倰倲倴弶嘸场夼娾㍀", num), A_0.method_24());
        }
        using (IEnumerator enumerator = A_0.method_28().System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class901 current = (Class901) enumerator.Current;
                this.class399_0.method_40(this.method_13(BookmarkStart.b("䜨堪", num), current.method_1(), current.method_0()), current.method_3());
            }
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_41(Class9 A_0)
    {
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_42(StructureDocumentTag A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_44(StructureDocumentTagInline A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_46(StructureDocumentTagCell A_0)
    {
        A_0.UpdateDataBinding();
        this.class399_0.method_4(BookmarkStart.b("丸ĺ䤼尾", 0x13));
        Class583.smethod_0(A_0.CellFormat, this);
        return base.vmethod_46(A_0);
    }

    public override VisitorAction vmethod_47(StructureDocumentTagCell A_0)
    {
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_48(StructureDocumentTagRow A_0)
    {
        int num = 6;
        A_0.UpdateDataBinding();
        if ((A_0.ChildObjects.Count > 0) && !(A_0.ChildObjects[0] is StructureDocumentTagRow))
        {
            this.class399_0.method_4(BookmarkStart.b("嬫ᐭ䐯䀱", num));
            Class923.smethod_0(A_0.RowFormat, false, false, this);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_49(StructureDocumentTagRow A_0)
    {
        if ((A_0.ChildObjects.Count > 0) && !(A_0.ChildObjects[0] is StructureDocumentTagRow))
        {
            this.class399_0.method_5();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_8(Paragraph A_0)
    {
        this.class399_0.method_4(BookmarkStart.b("夭ਯ䈱", 8));
        this.method_52(A_0);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_9(Paragraph A_0)
    {
        this.class399_0.method_5();
        return VisitorAction.Continue;
    }
}

