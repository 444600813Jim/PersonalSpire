using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

internal class Class857
{
    private ArrayList arrayList_0 = new ArrayList();
    private bool bool_0;
    private bool bool_1;
    internal static bool bool_10;
    private bool bool_11 = true;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private bool bool_8;
    internal static bool bool_9;
    private static readonly char[] char_0 = new char[] { '(', ')', '|' };
    private Class101 class101_0;
    private Class1052 class1052_0;
    private Class1138 class1138_0;
    private Class396 class396_0;
    private readonly Class415 class415_0 = new Class415();
    private readonly Class476 class476_0;
    private readonly Class854 class854_0 = new Class854();
    private readonly Class89 class89_0 = new Class89();
    private readonly Document document_0;
    private double double_0;
    private double double_1;
    internal static double double_2 = 1.0;
    private readonly Hashtable hashtable_0 = new Hashtable();
    private readonly Hashtable hashtable_1 = new Hashtable();
    private Hashtable hashtable_2;
    private int int_0;
    private int int_1;
    internal static int int_2;
    internal static int int_3;
    private int int_4;
    private int int_5;
    private readonly Stack stack_0 = new Stack();
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    internal static string string_4;

    internal Class857(Stream A_0, Document A_1)
    {
        this.class476_0 = new Class476(A_0);
        this.document_0 = A_1;
        this.document_0.Sections.Clear();
        this.int_4 = 0;
        this.int_0 = 1;
        this.int_1 = -1;
        this.double_0 = double.NaN;
        this.double_1 = double.NaN;
    }

    internal void method_0()
    {
        this.method_13().method_0();
        this.method_14().Clear();
        this.document_0.Settings.float_0 = 1134f;
        this.document_0.Settings.method_2(false);
        Class475.smethod_0(this);
        Class474.smethod_0(this);
        Class416.smethod_0(this);
        Class799.smethod_0(this);
        if (this.method_14().method_0(BookmarkStart.b("琦崨䨪䌬䬮倰䄲儴", 1)) == null)
        {
            this.method_1();
        }
        Class1053.smethod_0(this);
        if (this.bool_7)
        {
            this.document_0.EnforceDocProt = true;
            this.document_0.ProtectionType = ProtectionType.AllowOnlyFormFields;
        }
        foreach (Section section in this.document_0.Sections)
        {
            if (this.bool_7 && (section.SectPr.method_31(0x956) == null))
            {
                section.SectPr.method_125(true);
            }
            if (!section.IsLastChild)
            {
                section.Body.Paragraphs.Add(new Paragraph(this.document_0));
            }
        }
    }

    private void method_1()
    {
        Class92 class2 = new Class92();
        class2.method_1(BookmarkStart.b("尫䌭/", 6));
        this.class89_0.method_1(class2, false, true);
        Class108 class3 = new Class108();
        class3.method_1(BookmarkStart.b("缫娭儯就倳圵䨷帹", 6));
        class3.method_5(class2.method_0());
        class3.method_9(new Section(this.document_0));
        this.class854_0.Add(class3);
    }

    internal Class476 method_10()
    {
        return this.class476_0;
    }

    internal Class396 method_11()
    {
        return this.class396_0;
    }

    internal void method_12(Class396 A_0)
    {
        this.class396_0 = A_0;
    }

    internal Class89 method_13()
    {
        return this.class89_0;
    }

    internal Class854 method_14()
    {
        return this.class854_0;
    }

    internal Class415 method_15()
    {
        return this.class415_0;
    }

    internal string method_16()
    {
        return this.string_0;
    }

    internal void method_17(string A_0)
    {
        this.string_0 = A_0;
    }

    internal bool method_18()
    {
        return this.bool_1;
    }

    internal void method_19(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal bool method_2(Class396 A_0, Class43 A_1)
    {
        return (this.method_3(A_0, A_1) || smethod_3(A_0, A_1));
    }

    internal bool method_20()
    {
        return this.bool_2;
    }

    internal void method_21(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal int method_22()
    {
        return this.int_0;
    }

    internal void method_23(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_24()
    {
        return this.int_1;
    }

    internal void method_25(int A_0)
    {
        this.int_1 = A_0;
    }

    internal string method_26()
    {
        return this.string_1;
    }

    internal void method_27(string A_0)
    {
        this.string_1 = A_0;
    }

    internal Hashtable method_28()
    {
        return this.hashtable_0;
    }

    internal Stack method_29()
    {
        return this.stack_0;
    }

    private bool method_3(Class396 A_0, Class43 A_1)
    {
        int num = 0x12;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("伷匹堻䨽⠿", num))
            {
                this.double_0 = Class576.smethod_41(A_0.method_3());
                A_1.SetAttr(0x1023, this.double_0);
                return true;
            }
            if (str == BookmarkStart.b("倷弹唻夽⠿㙁", num))
            {
                this.double_1 = Class576.smethod_41(A_0.method_3());
                A_1.SetAttr(0x1024, this.double_1);
                return true;
            }
        }
        return false;
    }

    internal bool method_30()
    {
        return this.bool_3;
    }

    internal void method_31(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal bool method_32()
    {
        return this.bool_4;
    }

    internal void method_33(bool A_0)
    {
        this.bool_4 = A_0;
    }

    internal bool method_34()
    {
        return this.bool_5;
    }

    internal void method_35(bool A_0)
    {
        this.bool_5 = A_0;
    }

    internal ArrayList method_36()
    {
        return this.arrayList_0;
    }

    internal void method_37(ArrayList A_0)
    {
        this.arrayList_0 = A_0;
    }

    internal Class1052 method_38()
    {
        return this.class1052_0;
    }

    internal void method_39(Class1052 A_0)
    {
        this.class1052_0 = A_0;
    }

    internal bool method_4(Class396 A_0)
    {
        if (A_0.method_1() == BookmarkStart.b("天堫圭尯圱ᤳ堵夷圹夻", 4))
        {
            this.method_17(Class576.smethod_87(A_0.method_3()));
            return true;
        }
        return false;
    }

    internal bool method_40()
    {
        return this.bool_0;
    }

    internal void method_41(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal bool method_42()
    {
        return this.bool_6;
    }

    internal void method_43(bool A_0)
    {
        this.bool_6 = A_0;
    }

    internal bool method_44()
    {
        return this.bool_7;
    }

    internal void method_45(bool A_0)
    {
        this.bool_7 = A_0;
    }

    private double method_46()
    {
        return this.double_1;
    }

    private double method_47()
    {
        return this.double_0;
    }

    internal string method_48()
    {
        return this.string_2;
    }

    internal void method_49(string A_0)
    {
        this.string_2 = A_0;
    }

    internal bool method_5(Class43 A_0)
    {
        Class396 class2 = this.method_11();
        if (class2.method_1() == BookmarkStart.b("伪䠬尮到", 5))
        {
            A_0.SetAttr(0x381, class2.method_21());
            return true;
        }
        return false;
    }

    internal string method_50()
    {
        return this.string_3;
    }

    internal void method_51(string A_0)
    {
        this.string_3 = A_0;
    }

    internal Class1138 method_52()
    {
        return this.class1138_0;
    }

    internal void method_53(Class1138 A_0)
    {
        this.class1138_0 = A_0;
    }

    public Hashtable method_54()
    {
        return this.hashtable_1;
    }

    public bool method_55()
    {
        return this.bool_8;
    }

    public void method_56(bool A_0)
    {
        this.bool_8 = A_0;
    }

    public int method_57()
    {
        return this.int_4;
    }

    public void method_58(int A_0)
    {
        this.int_4 = A_0;
    }

    internal bool method_59()
    {
        return this.bool_11;
    }

    internal void method_6(bool A_0, bool A_1)
    {
        int num = 11;
        int num2 = this.class89_0.method_8();
        if (!A_0)
        {
            num2 = this.class89_0.method_9();
        }
        else if (A_1)
        {
            num2 = this.class89_0.method_10();
        }
        for (int i = 0; i < num2; i++)
        {
            Class96 class2;
            Class91 class4;
            if (!A_0)
            {
                class4 = this.class89_0.method_7(i);
            }
            else
            {
                class4 = A_1 ? this.class89_0.method_6(i) : this.class89_0.method_5(i);
            }
            if (!(class4 is Class96))
            {
                continue;
            }
            Class96 class3 = class4 as Class96;
            if (((class3.method_17() <= 0.0) || (class3.method_13() == null)) || class3.method_13().HasValue(190))
            {
                continue;
            }
            int fontSize = -1;
            string str = class3.method_8();
            goto Label_0129;
        Label_00C5:
            if ((class2.method_13() != null) && class2.method_13().HasValue(190))
            {
                fontSize = (int) class2.method_13().FontSize;
                str = null;
            }
            else
            {
                str = (str == BookmarkStart.b("戰䜲吴夶崸娺似嬾", num)) ? null : class2.method_8();
            }
            if (!Class567.smethod_16(class2.method_0()) || (fontSize != -1))
            {
                goto Label_0149;
            }
        Label_0129:
            class2 = (Class96) this.class89_0.method_4(str, class3.method_4());
            if (class2 != null)
            {
                goto Label_00C5;
            }
        Label_0149:
            if (fontSize == -1)
            {
                fontSize = 20;
            }
            class3.method_13().SetAttr(190, (float) Class1133.smethod_5((fontSize * class3.method_17()) / 100.0));
        }
    }

    internal void method_60(bool A_0)
    {
        this.bool_11 = A_0;
    }

    public int method_61()
    {
        return this.int_5;
    }

    public void method_62(int A_0)
    {
        this.int_5 = A_0;
    }

    internal Hashtable method_63()
    {
        return this.hashtable_2;
    }

    internal void method_64(Hashtable A_0)
    {
        this.hashtable_2 = A_0;
    }

    internal Class101 method_65()
    {
        return this.class101_0;
    }

    internal void method_66(Class101 A_0)
    {
        this.class101_0 = A_0;
    }

    internal void method_7(DocumentObject A_0, ShapeObject A_1)
    {
        if (this.arrayList_0.Count > 0)
        {
            this.method_8(A_1, (Paragraph) this.arrayList_0[this.arrayList_0.Count - 1]);
        }
        else if (!(A_0 is Body) && (A_0 != null))
        {
            this.method_8(A_1, A_0);
        }
        else
        {
            Paragraph paragraph = new Paragraph(this.document_0);
            this.method_8(A_1, paragraph);
            this.arrayList_0.Add(paragraph);
            if (A_0 != null)
            {
                A_0.method_13((Paragraph) this.arrayList_0[this.arrayList_0.Count - 1]);
            }
        }
    }

    internal void method_8(ShapeObject A_0, DocumentObject A_1)
    {
        switch (A_0.ShapeType)
        {
            case ShapeType.Image:
                A_1.method_13(A_0.ImageData);
                return;

            case ShapeType.TextBox:
                A_1.method_13(A_0.InternerTextbox);
                return;
        }
        A_1.method_13(A_0);
    }

    internal Document method_9()
    {
        return this.document_0;
    }

    internal static bool smethod_0(Class396 A_0, Class97 A_1, ParagraphFormat A_2)
    {
        int num = 9;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("䴮䌰嘲吴尶ᐸ夺堼夾⹀ㅂ⁄", num))
            {
                if (A_0.method_3() == BookmarkStart.b("弮倰吲倴", num))
                {
                    A_2.SetAttr(0x424, true);
                    A_1.method_34(true);
                }
                if (A_0.method_3() == BookmarkStart.b("丮䐰䜲娴", num))
                {
                    A_2.SetAttr(0x424, false);
                    A_1.method_34(false);
                }
                A_1.method_32(A_0.method_3() == BookmarkStart.b("䰮帰弲䀴娶圸", num));
                return true;
            }
            if (str == BookmarkStart.b("䴮䌰嘲吴尶ᐸ娺嬼䬾⑀ㅂ", num))
            {
                A_1.method_28(A_0.method_3() == BookmarkStart.b("弮倰吲倴", num));
                A_1.method_30(A_0.method_3() == BookmarkStart.b("䰮帰弲䀴娶圸", num));
                return true;
            }
        }
        return false;
    }

    internal static bool smethod_1(Class396 A_0, Class852 A_1)
    {
        int num = 2;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("䨧䔩師䨭唯䀱", num))
            {
                A_1.method_1(Class472.smethod_0(A_1.method_0(), A_0.method_3()));
                A_1.method_3(Class472.smethod_0(A_1.method_2(), A_0.method_3()));
                A_1.method_5(Class472.smethod_0(A_1.method_4(), A_0.method_3()));
                A_1.method_7(Class472.smethod_0(A_1.method_6(), A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ䈵圷䨹", num))
            {
                A_1.method_1(Class472.smethod_0(A_1.method_0(), A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ吵圷丹䠻儽ⴿ", num))
            {
                A_1.method_3(Class472.smethod_0(A_1.method_2(), A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ娵崷尹䠻", num))
            {
                A_1.method_5(Class472.smethod_0(A_1.method_4(), A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䨧䔩師䨭唯䀱ᤳ䐵儷崹吻䨽", num))
            {
                A_1.method_7(Class472.smethod_0(A_1.method_6(), A_0.method_3()));
                return true;
            }
        }
        return false;
    }

    internal static bool smethod_10(Class857 A_0, DocumentObject A_1, CharacterFormat A_2, Style A_3)
    {
        int num = 3;
        if (!(A_1 is ShapeObject) || (A_1 is ShapeGroup))
        {
            Class396 class3 = A_0.method_11();
            DocumentObject lastParagraph = A_1;
            string str3 = class3.method_0();
            string str = class3.method_1();
            if ((A_1 is Body) && (((str3 == BookmarkStart.b("䴨太䰬堮", num)) && (str == BookmarkStart.b("䠨", num))) || (((((str == BookmarkStart.b("丨", num)) || (str == BookmarkStart.b("䔨䈪䌬䨮", num))) || ((str == BookmarkStart.b("䨨䐪䌬䄮吰倲䄴堶䬸", num)) || (str == BookmarkStart.b("嬨个丬嬮", num)))) || (((str == BookmarkStart.b("䨨䈪弬䰮崰嘲", num)) || (str == BookmarkStart.b("䰨䜪䄬䘮䄰䀲倴", num))) || ((str == BookmarkStart.b("夨䐪䄬嘮崰娲嬴制", num)) || (str == BookmarkStart.b("夨䐪䄬嘮嘰尲嬴", num))))) || ((((str == BookmarkStart.b("嬨个䨬娮崰刲䜴ᨶ䤸吺儼䘾♀ⱂ⭄", num)) || (str == BookmarkStart.b("夨䨪夬䜮", num))) || ((str == BookmarkStart.b("夨䨪䨬䨮ᰰ䜲崴䈶吸夺匼帾⡀⽂", num)) || (str == BookmarkStart.b("䐨个䰬尮䐰䄲倴", num)))) || (((str == BookmarkStart.b("䨨䨪崬嬮堰尲嬴", num)) || (str == BookmarkStart.b("娨䠪䠬䄮吰", num))) || (str == BookmarkStart.b("䨨帪帬嬮帰帲ᠴ䐶儸娺䴼娾", num)))))))
            {
                if (A_0.method_36().Count == 0)
                {
                    Body body = (Body) A_1;
                    if (body.LastParagraph == null)
                    {
                        body.method_13(new Paragraph(A_0.method_9()));
                        A_0.method_36().Add(body.LastParagraph);
                    }
                    lastParagraph = (DocumentObject) body.LastParagraph;
                }
                else
                {
                    lastParagraph = (Paragraph) A_0.method_36()[A_0.method_36().Count - 1];
                }
            }
            string key = class3.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_174 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                    dictionary1.Add(BookmarkStart.b("丨", num), 0);
                    dictionary1.Add(BookmarkStart.b("䠨", num), 1);
                    dictionary1.Add(BookmarkStart.b("伨太䰬䈮吰", num), 2);
                    dictionary1.Add(BookmarkStart.b("䨨䐪䌬嬮䌰尲头", num), 3);
                    dictionary1.Add(BookmarkStart.b("䔨䈪䌬䨮", num), 4);
                    dictionary1.Add(BookmarkStart.b("䨨䐪䌬䄮吰倲䄴堶䬸", num), 5);
                    dictionary1.Add(BookmarkStart.b("嬨个丬嬮", num), 6);
                    dictionary1.Add(BookmarkStart.b("䨨䈪弬䰮崰嘲", num), 7);
                    dictionary1.Add(BookmarkStart.b("䰨䜪䄬䘮䄰䀲倴", num), 8);
                    dictionary1.Add(BookmarkStart.b("䨨帪帬嬮帰帲ᠴ䐶儸娺䴼娾", num), 9);
                    dictionary1.Add(BookmarkStart.b("夨䐪䄬嘮崰娲嬴制", num), 10);
                    dictionary1.Add(BookmarkStart.b("夨䐪䄬嘮嘰尲嬴", num), 11);
                    dictionary1.Add(BookmarkStart.b("夨䨪夬䜮", num), 12);
                    dictionary1.Add(BookmarkStart.b("嬨个䨬娮崰刲䜴ᨶ䤸吺儼䘾♀ⱂ⭄", num), 13);
                    dictionary1.Add(BookmarkStart.b("夨䨪䨬䨮ᰰ䜲崴䈶吸夺匼帾⡀⽂", num), 14);
                    dictionary1.Add(BookmarkStart.b("䐨个䰬尮䐰䄲倴", num), 15);
                    dictionary1.Add(BookmarkStart.b("䨨䨪崬嬮堰尲嬴", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("娨䠪䠬䄮吰", num), 0x11);
                    Class1160.dictionary_174 = dictionary1;
                }
                if (Class1160.dictionary_174.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            Class745.smethod_0(A_0, lastParagraph, A_2);
                            return true;

                        case 1:
                            return smethod_11(A_0, lastParagraph);

                        case 2:
                            Class746.smethod_0(A_0, lastParagraph, A_2);
                            return true;

                        case 3:
                            Class1144.smethod_0(A_0, lastParagraph, A_2, A_3);
                            return true;

                        case 4:
                            Class244.smethod_0(A_0, lastParagraph, A_2);
                            return true;

                        case 5:
                            Class245.smethod_0(A_0, lastParagraph, A_2);
                            return true;

                        case 6:
                            A_0.method_56(true);
                            Class1051.smethod_0(A_0, lastParagraph, A_2);
                            A_0.method_56(false);
                            return true;

                        case 7:
                        case 8:
                            A_0.method_56(true);
                            Class473.smethod_0(A_0, lastParagraph, A_2);
                            A_0.method_56(false);
                            return true;

                        case 9:
                        case 10:
                        case 11:
                        {
                            A_0.method_56(true);
                            Class1097 class2 = new Class1097();
                            class2.method_23(class3.method_1() == BookmarkStart.b("夨䐪䄬嘮崰娲嬴制", num));
                            class2.method_0(A_0, lastParagraph, A_2);
                            A_0.method_56(false);
                            return true;
                        }
                        case 12:
                            A_0.method_56(true);
                            new Class1143().method_0(A_0, lastParagraph, A_2);
                            A_0.method_56(false);
                            return true;

                        case 14:
                        case 15:
                        case 0x10:
                        case 0x11:
                            return true;
                    }
                }
            }
        }
        return false;
    }

    private static bool smethod_11(Class857 A_0, DocumentObject A_1)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        if (class2.method_0() != BookmarkStart.b("丩師伭䜯", 4))
        {
            return false;
        }
        string str3 = "";
        string str = "";
        while (class2.method_19())
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䈩師䬭嘯", num)))
                {
                    if (str2 == BookmarkStart.b("帩䴫尭圯圱䀳ᬵ帷䠹崻匽┿潁⩃❅╇⽉", num))
                    {
                        str = class2.method_3();
                    }
                }
                else
                {
                    str3 = Class576.smethod_91(class2.method_3());
                }
            }
        }
        A_0.method_49(str3);
        A_0.method_51(str);
        while (class2.method_9(BookmarkStart.b("䬩", num)))
        {
            if (class2.method_1() == BookmarkStart.b("䰩師伭崯圱", num))
            {
                Class746.smethod_0(A_0, A_1, null);
            }
            else
            {
                class2.vmethod_1();
            }
        }
        A_0.method_49(null);
        A_0.method_51(null);
        return true;
    }

    internal static void smethod_12(Class857 A_0, string A_1, bool A_2, bool A_3, Class43 A_4)
    {
        bool_9 = false;
        bool_10 = false;
        double_2 = 1.0;
        if (Class567.smethod_16(A_1))
        {
            string[] strArray = A_1.Trim().Split(new char[] { ' ' });
            int[] numArray = new int[4];
            for (int i = 0; i < strArray.Length; i++)
            {
                if (i >= 4)
                {
                    break;
                }
                int num6 = Class1041.smethod_18(strArray[i]);
                if (num6 == -2147483648)
                {
                    return;
                }
                numArray[i] = num6;
            }
            int num4 = numArray[2] - numArray[0];
            int num5 = numArray[3] - numArray[1];
            int_2 = numArray[2];
            int_3 = numArray[3];
            if (num5 > 0)
            {
                double num = ((double) num4) / ((double) num5);
                double num2 = A_0.method_47() / A_0.method_46();
                if (A_2 && (num < num2))
                {
                    num4 = (int) (num4 * num2);
                    double_2 = num2;
                    bool_9 = true;
                }
                if (A_3 && (num > num2))
                {
                    num5 = (int) (((double) num5) / num2);
                    double_2 = num2;
                    bool_10 = true;
                }
            }
            if (Class576.smethod_4(num4, num5))
            {
                Class576.smethod_3(num4, num5);
                num4 = Class576.smethod_2(num4);
                num5 = Class576.smethod_2(num5);
            }
            A_4.SetAttr(0x101d, numArray[0]);
            A_4.SetAttr(0x101e, numArray[1]);
            A_4.SetAttr(0x101f, num4);
            A_4.SetAttr(0x1020, num5);
        }
    }

    internal static bool smethod_13(Class857 A_0, ShapeObject A_1)
    {
        int num = 6;
        Class396 class2 = A_0.method_11();
        string str = class2.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("尫", num))
            {
                Class1099.smethod_1(A_0, class2.method_1(), A_1);
                return true;
            }
            if (str == BookmarkStart.b("䀫䜭䌯䘱", num))
            {
                Class530.smethod_0(A_0, A_1, null);
                return true;
            }
        }
        return false;
    }

    private static bool smethod_14(Class396 A_0, Class692 A_1)
    {
        int num = 13;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("帲吴䔶常刺匼ሾⵀ♂⍄㍆", num))
            {
                A_1.method_1(Class576.smethod_41(A_0.method_3()));
                A_1.method_5(true);
                return true;
            }
            if (str == BookmarkStart.b("帲吴䔶常刺匼ሾ㍀⩂≄⽆㵈", num))
            {
                A_1.method_3(Class576.smethod_41(A_0.method_3()));
                A_1.method_7(true);
                return true;
            }
        }
        return false;
    }

    private static bool smethod_15(Class396 A_0, Class851 A_1)
    {
        int num = 9;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("䈮倰䄲刴帶圸ᘺ䤼倾ㅀ", num))
            {
                A_1.method_1(Class576.smethod_41(A_0.method_3()));
                A_1.method_5(true);
                return true;
            }
            if (str == BookmarkStart.b("䈮倰䄲刴帶圸ᘺ弼倾㕀㝂⩄⩆", num))
            {
                A_1.method_3(Class576.smethod_41(A_0.method_3()));
                A_1.method_7(true);
                return true;
            }
        }
        return false;
    }

    internal static void smethod_16(ParagraphBase A_0, Style A_1)
    {
    }

    internal static bool smethod_17(Stream A_0)
    {
        int num = 3;
        Class396 class2 = new Class396(A_0);
        while (class2.method_9(BookmarkStart.b("䴨䐪丬娮尰嘲嬴䌶ᐸ䠺吼堾⽀≂ㅄ㉆㭈⹊㹌", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("稨䈪䨬䄮倰䜲䀴䔶尸", num)))
            {
                return true;
            }
            class2.vmethod_1();
        }
        return false;
    }

    internal static bool smethod_18(Stream A_0)
    {
        int num = 0;
        Class396 class2 = new Class396(A_0);
        while (class2.method_9(BookmarkStart.b("䬥䤧䐩䔫䠭唯䄱䀳", num)))
        {
            string str;
            string str2;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䀥䄧䘩䤫̭唯就䀳䐵䄷", num)))
            {
                goto Label_0051;
            }
            goto Label_0066;
        Label_002E:
            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("䌥䘧䤩師圭䀯䘱崳夵嘷᜹堻弽㐿⍁", num)))
            {
                return true;
            }
            class2.vmethod_1();
        Label_0051:
            if (class2.method_9(BookmarkStart.b("䀥䄧䘩䤫̭唯就䀳䐵䄷", num)))
            {
                goto Label_002E;
            }
            continue;
        Label_0066:
            class2.vmethod_1();
        }
        return false;
    }

    internal static FileFormat smethod_19(Stream A_0)
    {
        int num = 0x13;
        StreamReader reader = new StreamReader(A_0);
        string str2 = reader.ReadLine();
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("堸䬺䴼匾⡀⁂⑄㍆⁈⑊⍌恎❐㵒ㅔ祖㙘㩚⹜㙞በ䵢੤ᝦ౨ժ६nተٲᡴቶ᝸ེ卼୾ﮂ", num))
            {
                return FileFormat.Odt;
            }
            if (str2 == BookmarkStart.b("堸䬺䴼匾⡀⁂⑄㍆⁈⑊⍌恎❐㵒ㅔ祖㙘㩚⹜㙞በ䵢੤ᝦ౨ժ६nተٲᡴቶ᝸ེ卼୾ﮂꪆﶈﾎ﶐", num))
            {
                return FileFormat.Ott;
            }
        }
        return FileFormat.Auto;
    }

    internal static bool smethod_2(Class396 A_0, Class412 A_1)
    {
        int num = 14;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("䐳圵尷帹唻倽✿", num))
            {
                A_1.method_1(Class576.smethod_41(A_0.method_3()));
                A_1.method_3(Class576.smethod_41(A_0.method_3()));
                A_1.method_5(Class576.smethod_41(A_0.method_3()));
                A_1.method_7(Class576.smethod_41(A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䐳圵尷帹唻倽✿潁ぃ⥅㡇", num))
            {
                A_1.method_1(Class576.smethod_41(A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䐳圵尷帹唻倽✿潁♃⥅㱇㹉⍋⍍", num))
            {
                A_1.method_3(Class576.smethod_41(A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䐳圵尷帹唻倽✿潁⡃⍅⹇㹉", num))
            {
                A_1.method_5(Class576.smethod_41(A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䐳圵尷帹唻倽✿潁㙃⽅⽇≉㡋", num))
            {
                A_1.method_7(Class576.smethod_41(A_0.method_3()));
                return true;
            }
        }
        return false;
    }

    private static bool smethod_3(Class396 A_0, Class43 A_1)
    {
        int num = 0x13;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("䄸", num))
            {
                A_1.SetAttr(0x1021, Class576.smethod_41(A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䀸", num))
            {
                A_1.SetAttr(0x1022, Class576.smethod_41(A_0.method_3()));
                return true;
            }
        }
        return false;
    }

    internal static void smethod_4(Class43 A_0, string A_1)
    {
        int num = 6;
        if (Class567.smethod_16(A_1))
        {
            string[] strArray = A_1.Replace(BookmarkStart.b("ఫ", num), "").Replace(BookmarkStart.b("伫䌭", num), BookmarkStart.b("伫䌭䰯", num)).Replace(BookmarkStart.b("䄫䌭", num), BookmarkStart.b("䄫䌭䰯", num)).Replace(BookmarkStart.b("䔫䀭", num), BookmarkStart.b("䔫䀭䰯", num)).Replace(BookmarkStart.b("尫娭", num), BookmarkStart.b("尫娭䰯", num)).Replace(BookmarkStart.b("尫䴭", num), BookmarkStart.b("尫䴭䰯", num)).Replace(BookmarkStart.b("尫嘭", num), BookmarkStart.b("尫嘭䰯", num)).Split(char_0);
            double num2 = (A_0.method_31(0x1021) == null) ? 0.0 : ((double) A_0.method_31(0x1021));
            double num4 = (A_0.method_31(0x1022) == null) ? 0.0 : ((double) A_0.method_31(0x1022));
            double num5 = (A_0.method_31(4) == null) ? 0.0 : Class969.smethod_68((int) A_0.method_31(4));
            for (int i = 0; i < strArray.Length; i++)
            {
                string str = strArray[i];
                if (Class567.smethod_16(str))
                {
                    if (str == BookmarkStart.b("堫尭儯就䜳娵夷丹夻", num))
                    {
                        num2 += Class576.smethod_41(strArray[++i]);
                        num4 += Class576.smethod_41(strArray[++i]);
                    }
                    else if (str == BookmarkStart.b("師䄭䐯匱䀳匵", num))
                    {
                        num5 += -(180.0 * Class1041.smethod_12(strArray[++i])) / 3.1415926535897931;
                    }
                }
            }
            A_0.SetAttr(0x1021, num2);
            A_0.SetAttr(0x1022, num4);
            A_0.SetAttr(4, Class969.smethod_71(num5));
        }
    }

    internal static bool smethod_5(Class396 A_0, Class43 A_1)
    {
        string str;
        int num = 10;
        if (((str = A_0.method_1()) == null) || (!(str == BookmarkStart.b("䈯圱堳ᬵ伷匹堻䨽⠿", num)) && !(str == BookmarkStart.b("䈯圱堳ᬵ倷弹唻夽⠿㙁", num))))
        {
            return false;
        }
        return true;
    }

    internal static bool smethod_6(Class857 A_0, Class43 A_1)
    {
        int num = 15;
        Class396 class2 = A_0.method_11();
        string str = class2.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("吴夶娸区刼䴾汀㝂㱄㝆ⱈ", num))
            {
                if (class2.method_3() == BookmarkStart.b("吴䐶ᐸ堺唼帾㍀", num))
                {
                    A_1.SetAttr(0x1001, TextWrappingStyle.Inline);
                }
                if (class2.method_3() == BookmarkStart.b("䔴嘶常帺", num))
                {
                    A_1.SetAttr(0x390, RelativeHorizontalPosition.Page);
                    A_1.SetAttr(0x392, RelativeVerticalPosition.Page);
                }
                return true;
            }
            if (str == BookmarkStart.b("吴夶娸区刼䴾汀㍂⑄⁆ⱈ晊⍌㩎㱐ㅒご╖", num))
            {
                return false;
            }
        }
        return false;
    }

    internal static bool smethod_7(Class857 A_0, Class43 A_1)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        if (A_0.method_4(class2))
        {
            return true;
        }
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_173 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                dictionary1.Add(BookmarkStart.b("倩ī䜭帯嘱儳丵", num), 0);
                dictionary1.Add(BookmarkStart.b("帩師伭帯䄱刳夵䨷圹", num), 1);
                dictionary1.Add(BookmarkStart.b("帩䤫嘭䐯ἱ䜳䈵䄷嘹夻ጽ⸿⍁⥃⍅", num), 2);
                dictionary1.Add(BookmarkStart.b("䌩䠫", num), 3);
                dictionary1.Add(BookmarkStart.b("䘩䴫圭唯䀱", num), 4);
                dictionary1.Add(BookmarkStart.b("䤩䀫伭䌯䄱ᤳ堵夷圹夻䴽", num), 5);
                dictionary1.Add(BookmarkStart.b("䐩䴫䌭唯", num), 6);
                dictionary1.Add(BookmarkStart.b("伩䈫䨭ᴯ儱儳娵吷᜹崻娽␿ぁ⅃㕅㭇", num), 7);
                dictionary1.Add(BookmarkStart.b("伩䈫䨭ᴯ䨱", num), 8);
                dictionary1.Add(BookmarkStart.b("伩䈫䨭ᴯ䬱", num), 9);
                dictionary1.Add(BookmarkStart.b("帩䴫䰭尯圱ᤳ吵夷夹圻夽㈿ⵁㅃ⡅ⱇ", num), 10);
                dictionary1.Add(BookmarkStart.b("䬩䈫䴭堯崱䘳ᬵ䠷嬹嬻嬽洿ⱁㅃ⭅⩇⽉㹋", num), 11);
                Class1160.dictionary_173 = dictionary1;
            }
            if (Class1160.dictionary_173.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        A_1.SetAttr(0x103a, (long) class2.method_4());
                        return true;

                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        return false;
                }
            }
        }
        return false;
    }

    internal static bool smethod_8(Class396 A_0, Class91 A_1)
    {
        int num = 7;
        string str = A_0.method_1();
        if (str != null)
        {
            if (str == BookmarkStart.b("䌬丮尰嘲", num))
            {
                A_1.method_1(Class576.smethod_87(A_0.method_3()));
                return true;
            }
            if (str == BookmarkStart.b("䤬䘮䈰䌲头嘶䀸ᘺ匼帾ⱀ♂", num))
            {
                A_1.method_3(A_0.method_3());
                return true;
            }
        }
        return false;
    }

    internal static bool smethod_9(Class396 A_0, Class572 A_1)
    {
        int num = 3;
        if (smethod_15(A_0, A_1.method_2()) || smethod_14(A_0, A_1.method_0()))
        {
            return true;
        }
        if (A_0.method_1() == BookmarkStart.b("䐨䨪弬䠮堰崲", num))
        {
            double num2 = Class576.smethod_41(A_0.method_3());
            A_1.method_2().method_1(num2);
            A_1.method_2().method_3(num2);
            A_1.method_0().method_1(num2);
            A_1.method_0().method_3(num2);
            A_1.method_0().method_5(true);
            A_1.method_0().method_7(true);
            A_1.method_2().method_5(true);
            A_1.method_2().method_7(true);
            return true;
        }
        return false;
    }
}

