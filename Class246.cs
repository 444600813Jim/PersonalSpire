using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class246
{
    private Class246()
    {
    }

    internal static bool smethod_0(Class857 A_0, DocumentObject A_1, Class108 A_2)
    {
        int num = 14;
        A_0.method_39(new Class1052());
        A_0.method_38().method_1(A_0.method_11().method_1());
        A_0.method_38().method_13(string.Format(BookmarkStart.b("伳ص䔷᜹伻儽㔿ぁ❃⍅", 14), A_0.method_38().method_0()));
        string str = A_0.method_38().method_0();
        if (str != null)
        {
            if (!(str == BookmarkStart.b("䀳圵娷嘹夻ጽ⼿⑁楃╅❇⑉㡋⭍㹏♑", num)))
            {
                if (!(str == BookmarkStart.b("唳娵䠷刹崻尽┿㙁ⵃ╅⥇♉態❍㹏㙑ㅓ⹕", num)))
                {
                    goto Label_020E;
                }
                A_0.method_38().method_7(FieldType.FieldIndex);
                A_0.method_38().method_9(BookmarkStart.b("紳砵簷缹搻", num));
            }
            else
            {
                A_0.method_38().method_7(FieldType.FieldTOC);
                A_0.method_38().method_9(BookmarkStart.b("怳礵笷", num));
            }
            Class396 class3 = A_0.method_11();
            A_0.method_38().method_5(class3.method_12(BookmarkStart.b("䜳䈵䄷嘹夻ጽ⸿⍁⥃⍅", num), null));
            if (Class567.smethod_16(A_0.method_38().method_4()))
            {
                Section section = A_2.method_8().Clone();
                section.SectPr.method_57(SectionBreakType.NoBreak);
                Class95 class4 = (Class95) A_0.method_13().method_3(A_0.method_38().method_4(), BookmarkStart.b("䜳匵嬷丹唻儽⸿", num), A_0.method_20());
                if ((class4 != null) && (class4.method_12() != null))
                {
                    ((Class17) section.SectPr.Clone()).method_37(section.SectPr);
                }
                A_0.method_29().Push(section);
                A_0.method_31(true);
            }
            smethod_2(A_0, A_1);
            smethod_1(A_0);
            if (A_1 == null)
            {
                A_1 = A_0.method_9().LastSection.Body;
            }
            List<DocumentObject> childElements = A_1.GetChildElements(DocumentObjectType.Paragraph, false);
            if (childElements.Count != 0)
            {
                Paragraph paragraph1 = (Paragraph) childElements[childElements.Count - 1];
            }
            else
            {
                new Paragraph(A_0.method_9());
            }
            if (Class567.smethod_16(A_0.method_38().method_4()))
            {
                A_0.method_33(true);
                A_0.method_29().Pop();
            }
            return true;
        }
    Label_020E:
        A_0.method_38().method_11(true);
        smethod_2(A_0, A_1);
        return false;
    }

    internal static void smethod_1(Class857 A_0)
    {
        int num = 9;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䄮倰帲倴", num))
                {
                    if (!(str == BookmarkStart.b("尮䔰䨲头制ᐸ唺尼刾⑀", num)))
                    {
                        if (((str == BookmarkStart.b("弮䌰尲䄴制娸伺堼嬾", num)) || (str == BookmarkStart.b("弮䌰尲䄴制娸伺吼倾⽀湂⹄≆え", num))) || ((str == BookmarkStart.b("䬮堰䀲䔴嬶堸䈺", num)) || (str == BookmarkStart.b("䰮帰崲儴帶䴸刺刼儾", num))))
                        {
                        }
                    }
                    else
                    {
                        A_0.method_38().method_5(class2.method_3());
                    }
                }
                else
                {
                    A_0.method_38().method_3(class2.method_3());
                }
            }
        }
    }

    private static void smethod_2(Class857 A_0, DocumentObject A_1)
    {
        int num = 7;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(A_0.method_38().method_0()))
        {
            if (class2.method_1() == A_0.method_38().method_12())
            {
                smethod_3(A_0, A_1);
            }
            else
            {
                if (class2.method_1() == BookmarkStart.b("䐬䄮唰嘲䴴ᨶ嬸吺夼䘾", num))
                {
                    Class574.smethod_0(A_0, BookmarkStart.b("䐬䄮唰嘲䴴ᨶ嬸吺夼䘾", num), A_1);
                    continue;
                }
                class2.vmethod_1();
            }
        }
        A_0.method_17(A_0.method_11().method_12(BookmarkStart.b("帬嬮䠰弲倴ᨶ圸娺值娾", num), BookmarkStart.b("縬嬮倰崲儴嘶䬸强", num)));
        Class108 class3 = Class574.smethod_10(A_0);
        A_1 = Class574.smethod_4(A_0, class3, A_1);
    }

    private static void smethod_3(Class857 A_0, DocumentObject A_1)
    {
        smethod_4(A_0);
        smethod_5(A_0, A_1);
    }

    private static void smethod_4(Class857 A_0)
    {
        int num = 5;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䐪堬嬮崰娲嬴制ᐸ场堼䤾⑀⽂", num)))
                {
                    if ((((str == BookmarkStart.b("帪帬䨮ᰰ尲䀴䌶唸刺匼娾汀⽂⁄ㅆⱈ❊", num)) || (str == BookmarkStart.b("帪帬䨮ᰰ娲嬴匶尸䌺ြ刾⁀ㅂ⹄㑆", num))) || ((str == BookmarkStart.b("帪帬䨮ᰰ娲嬴匶尸䌺ြ䰾⹀㙂㝄⑆ⱈ晊㹌㭎⡐㽒ご⑖", num)) || (str == BookmarkStart.b("䈪䌬䬮吰䬲ᠴ䐶娸吺䴼娾", num)))) || (str == BookmarkStart.b("太䠬䌮倰䜲尴䄶尸ᘺ䤼帾⍀湂㙄㍆♈㭊恌㽎㹐⁒㱔⍖じ㑚㍜", num)))
                    {
                    }
                }
                else
                {
                    A_0.method_38().method_17(Class1041.smethod_11(class2.method_3()));
                    A_0.method_38().method_9(string.Format(BookmarkStart.b("倪ᴬ刮ᄰ漲娴᜶ᬸ਺ြ䐾灀㹂杄", num), A_0.method_38().method_8(), class2.method_3()));
                }
            }
        }
    }

    private static void smethod_5(Class857 A_0, DocumentObject A_1)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        if (class2.method_9(A_0.method_38().method_12()))
        {
            if (class2.method_1() == BookmarkStart.b("並䜨伪䠬圮ᰰ䜲尴䌶唸帺ြ䬾⑀⹂㕄⭆⡈㽊⡌", num))
            {
                smethod_6(A_0, A_1);
            }
            else if (class2.method_1() == A_0.method_38().method_14())
            {
                smethod_7(A_0, A_1);
            }
            else if (class2.method_1() == BookmarkStart.b("並䜨伪䠬圮ᰰ䀲娴䈶䬸堺堼ሾ㉀㝂㱄⭆ⱈ㡊", num))
            {
                smethod_8(A_0, A_1);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_6(Class857 A_0, DocumentObject A_1)
    {
        A_0.method_11().vmethod_1();
    }

    private static void smethod_7(Class857 A_0, DocumentObject A_1)
    {
        A_0.method_11().vmethod_1();
    }

    private static void smethod_8(Class857 A_0, DocumentObject A_1)
    {
        A_0.method_11().vmethod_1();
    }
}

