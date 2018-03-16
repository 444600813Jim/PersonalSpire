using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class961
{
    private Class961()
    {
    }

    internal static void smethod_0(Class582 A_0)
    {
        int num = 8;
        Class394 class2 = A_0.imethod_1();
        Document doc = A_0.Interface50.imethod_0();
        doc.DefCharFormat = new CharacterFormat(doc);
        while (class2.method_9(BookmarkStart.b("䠭弯就䀳䔵", num)))
        {
            string str4;
            string str5 = class2.method_1();
            if (str5 == null)
            {
                goto Label_0172;
            }
            if (str5 == BookmarkStart.b("䨭唯吱唳䌵吷丹稻儽⸿㙁㝃", num))
            {
                goto Label_0165;
            }
            if (!(str5 == BookmarkStart.b("䠭弯就䀳", num)))
            {
                goto Label_0172;
            }
            doc.FontInfoList.method_11(smethod_1(class2, doc));
            continue;
        Label_0079:
            if ((str4 = class2.method_1()) != null)
            {
                if (str4 != BookmarkStart.b("伭䌯儱崳張", num))
                {
                    if (str4 != BookmarkStart.b("䠭儯䀱儳圵䬷丹", num))
                    {
                        if (!(str4 == BookmarkStart.b("䘭ᴯ匱娳䔵儷", num)))
                        {
                            if (str4 == BookmarkStart.b("䴭䌯", num))
                            {
                                string str;
                                doc.DefaultFontNameTable.method_7(str = class2.method_3());
                                doc.DefCharFormat.FontNameBidi = str;
                            }
                        }
                        else
                        {
                            string str3;
                            doc.DefaultFontNameTable.method_5(str3 = class2.method_3());
                            doc.DefCharFormat.FontNameNonFarEast = str3;
                        }
                    }
                    else
                    {
                        string str6;
                        doc.DefaultFontNameTable.method_3(str6 = class2.method_3());
                        doc.DefCharFormat.FontNameFarEast = str6;
                    }
                }
                else
                {
                    string str2;
                    doc.DefaultFontNameTable.method_1(str2 = class2.method_3());
                    doc.DefCharFormat.FontNameAscii = str2;
                }
            }
        Label_0165:
            if (class2.method_19())
            {
                goto Label_0079;
            }
            continue;
        Label_0172:
            class2.vmethod_1();
        }
    }

    private static Form4 smethod_1(Class394 A_0, Document A_1)
    {
        int num = 2;
        Form4 form = new Form4(A_1, A_0.method_12(BookmarkStart.b("䘧䬩䄫䬭", 2), ""));
        while (A_0.method_9(BookmarkStart.b("丧䔩䈫娭", num)))
        {
            string str;
            string key = A_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_202 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("䤧䘩堫怭儯弱儳", num), 0);
                    dictionary1.Add(BookmarkStart.b("堧䬩䈫䄭䌯圱ᤳܵ", num), 1);
                    dictionary1.Add(BookmarkStart.b("䬧䈩䴫尭䌯圱䀳", num), 2);
                    dictionary1.Add(BookmarkStart.b("丧䬩䄫䜭尯䬱", num), 3);
                    dictionary1.Add(BookmarkStart.b("䘧䔩堫稭䈯䜱儳戵䄷䨹夻", num), 4);
                    dictionary1.Add(BookmarkStart.b("堧䌩堫䴭堯", num), 5);
                    dictionary1.Add(BookmarkStart.b("嬧䌩䬫", num), 6);
                    Class1160.dictionary_202 = dictionary1;
                }
                if (Class1160.dictionary_202.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            form.method_34(A_0.method_28());
                            continue;
                        }
                        case 1:
                        {
                            form.method_36(new byte[10]);
                            Class114.smethod_10(A_0.method_28(), form.method_35(), 0);
                            continue;
                        }
                        case 2:
                        {
                            form.method_38(Class114.smethod_8(A_0.method_28()));
                            continue;
                        }
                        case 3:
                        {
                            form.method_40(Class911.smethod_0(A_0.method_28()));
                            continue;
                        }
                        case 4:
                        {
                            form.method_44(!A_0.method_31());
                            continue;
                        }
                        case 5:
                        {
                            form.method_42(Class417.smethod_6(A_0.method_28()));
                            continue;
                        }
                        case 6:
                            form.method_46(new byte[0x18]);
                            goto Label_02A3;
                    }
                }
            }
            goto Label_02B0;
        Label_01A5:
            if ((str = A_0.method_1()) != null)
            {
                if (str != BookmarkStart.b("崧天丫̭/", num))
                {
                    if (str != BookmarkStart.b("崧天丫̭į", num))
                    {
                        if (str != BookmarkStart.b("崧天丫̭ȯ", num))
                        {
                            if (str != BookmarkStart.b("崧天丫̭̯", num))
                            {
                                if (!(str == BookmarkStart.b("䬧天丫̭/", num)))
                                {
                                    if (str == BookmarkStart.b("䬧天丫̭į", num))
                                    {
                                        Class114.smethod_11(A_0.method_3(), form.method_45(), 20);
                                    }
                                }
                                else
                                {
                                    Class114.smethod_11(A_0.method_3(), form.method_45(), 0x10);
                                }
                            }
                            else
                            {
                                Class114.smethod_11(A_0.method_3(), form.method_45(), 12);
                            }
                        }
                        else
                        {
                            Class114.smethod_11(A_0.method_3(), form.method_45(), 8);
                        }
                    }
                    else
                    {
                        Class114.smethod_11(A_0.method_3(), form.method_45(), 4);
                    }
                }
                else
                {
                    Class114.smethod_11(A_0.method_3(), form.method_45(), 0);
                }
            }
        Label_02A3:
            if (A_0.method_19())
            {
                goto Label_01A5;
            }
            continue;
        Label_02B0:
            A_0.vmethod_1();
        }
        return form;
    }
}

