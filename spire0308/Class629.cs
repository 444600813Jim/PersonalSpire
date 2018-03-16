using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using System;
using System.Collections.Generic;

internal class Class629
{
    private static List<BookmarkStart> list_0 = new List<BookmarkStart>();
    private static List<BookmarkEnd> list_1 = new List<BookmarkEnd>();
    private static List<PermissionStart> list_2 = new List<PermissionStart>();
    private static List<PermissionEnd> list_3 = new List<PermissionEnd>();

    private Class629()
    {
    }

    internal static void smethod_0(Class581 A_0, DocumentObject A_1)
    {
        DocumentObject obj2 = A_0.method_13();
        A_0.method_14(A_1);
        smethod_1(A_0);
        A_0.method_14(obj2);
    }

    private static void smethod_1(Class581 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            smethod_2(A_0);
        }
    }

    internal static void smethod_2(Class581 A_0)
    {
        int num = 4;
        bool flag = false;
        Class394 class2 = A_0.imethod_1();
        if (A_0.vmethod_1())
        {
            Class9 class3 = Class402.smethod_0(A_0, MarkupLevel.Block);
            A_0.method_3(class3);
            while (class2.method_9(class3.method_22()))
            {
                smethod_2(A_0);
            }
            if (A_0.method_13().DocumentObjectType == DocumentObjectType.CustomXml)
            {
                A_0.method_5(DocumentObjectType.CustomXml);
                return;
            }
            return;
        }
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_115 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("娩", num), 0);
                dictionary1.Add(BookmarkStart.b("帩丫䈭", num), 1);
                dictionary1.Add(BookmarkStart.b("䬩䈫䀭弯䘱唳䈵儷唹刻", num), 2);
                dictionary1.Add(BookmarkStart.b("天䤫䴭䐯戱䘳", num), 3);
                dictionary1.Add(BookmarkStart.b("䠩䔫䀭琯匱䀳圵", num), 4);
                dictionary1.Add(BookmarkStart.b("娩䤫尭崯愱䀳圵䨷丹", num), 5);
                dictionary1.Add(BookmarkStart.b("娩䤫尭崯眱娳刵", num), 6);
                Class1160.dictionary_115 = dictionary1;
            }
            if (Class1160.dictionary_115.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        flag = Class518.smethod_0(A_0, list_0, list_1, list_2, list_3);
                        goto Label_01C9;

                    case 1:
                        Class1080.smethod_0(A_0);
                        goto Label_01C9;

                    case 2:
                        Class519.smethod_2(A_0, A_0.Interface50.imethod_0().LastParagraph, list_0, list_1);
                        goto Label_01C9;

                    case 3:
                        if (A_0.method_13().DocumentObjectType == DocumentObjectType.Body)
                        {
                            Body body = (Body) A_0.method_13();
                            Class980.smethod_0(A_0, body.ParentSection);
                        }
                        smethod_1(A_0);
                        goto Label_01C9;

                    case 4:
                        A_0.imethod_9();
                        goto Label_01C9;

                    case 5:
                        smethod_3(A_0);
                        goto Label_01C9;

                    case 6:
                        smethod_4(A_0);
                        goto Label_01C9;
                }
            }
        }
        smethod_1(A_0);
    Label_01C9:
        if (flag)
        {
            if (A_0.method_13().DocumentObjectType == DocumentObjectType.CustomXml)
            {
                while (A_0.method_13().DocumentObjectType == DocumentObjectType.CustomXml)
                {
                    Class9 class4 = (Class9) A_0.method_13();
                    A_0.method_5(DocumentObjectType.CustomXml);
                    while (class4.HasChildElements)
                    {
                        class4.Owner.method_17(class4.LastChild, class4);
                    }
                    class4.method_19();
                }
            }
            A_0.method_5(DocumentObjectType.Body);
            A_0.method_5(DocumentObjectType.Section);
            Section section = A_0.Interface50.imethod_0().AddSection();
            A_0.method_4(section);
            A_0.method_4(section.Body);
        }
    }

    private static void smethod_3(Class581 A_0)
    {
        int num = 12;
        Class394 class2 = A_0.imethod_1();
        string id = class2.method_12(BookmarkStart.b("嬱倳", 12), string.Empty);
        if ((id != null) && (id != string.Empty))
        {
            PermissionStart item = new PermissionStart(A_0.Interface50.imethod_0(), id) {
                EditorGroup = smethod_5(class2),
                DisplacedByCustomXml = smethod_6(class2),
                Editor = class2.method_12(BookmarkStart.b("圱倳", num), string.Empty)
            };
            string str2 = class2.method_12(BookmarkStart.b("儱嬳娵縷匹主䴽㐿", num), string.Empty);
            if (!string.IsNullOrEmpty(str2))
            {
                item.ColumnFirst = int.Parse(str2);
            }
            if (!string.IsNullOrEmpty(str2))
            {
                item.ColumnLast = int.Parse(str2);
            }
            list_2.Add(item);
        }
    }

    private static void smethod_4(Class581 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        string id = class2.method_12(BookmarkStart.b("嬱倳", 12), string.Empty);
        if ((id != null) && !(id == string.Empty))
        {
            PermissionEnd item = new PermissionEnd(A_0.Interface50.imethod_0(), id) {
                EditorGroup = smethod_5(class2),
                DisplacedByCustomXml = smethod_6(class2)
            };
            list_3.Add(item);
        }
    }

    private static EditingGroup smethod_5(Class394 A_0)
    {
        int num = 9;
        string str = A_0.method_12(BookmarkStart.b("䨮唰琲䜴䜶", 9), string.Empty);
        switch (str)
        {
            case null:
            case string.Empty:
                return EditingGroup.None;
        }
        string key = str;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_116 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("丮唰帲尴夶倸䠺䤼䴾⁀㝂⩄㕆㩈", num), 0);
                dictionary1.Add(BookmarkStart.b("䰮帰崲䄴䔶倸夺䠼䬾⹀ㅂ㙄", num), 1);
                dictionary1.Add(BookmarkStart.b("䰮䐰䄲䜴制圸伺", num), 2);
                dictionary1.Add(BookmarkStart.b("䨮唰娲䄴堶䬸䠺", num), 3);
                dictionary1.Add(BookmarkStart.b("䨮䜰嘲䜴丶嘸唺堼", num), 4);
                dictionary1.Add(BookmarkStart.b("䀮䘰崲倴䔶䨸", num), 5);
                Class1160.dictionary_116 = dictionary1;
            }
            if (Class1160.dictionary_116.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return EditingGroup.Administrators;

                    case 1:
                        return EditingGroup.Contributors;

                    case 2:
                        return EditingGroup.Current;

                    case 3:
                        return EditingGroup.Editors;

                    case 4:
                        return EditingGroup.Everyone;

                    case 5:
                        return EditingGroup.Owners;
                }
            }
        }
        return EditingGroup.None;
    }

    private static DisplacedByCustomXml smethod_6(Class394 A_0)
    {
        int num = 12;
        string str = A_0.method_12(BookmarkStart.b("嘱崳䔵䠷嘹崻崽┿♁ك㽅େ㽉㽋㩍㽏㽑౓㭕㑗", 12), string.Empty);
        switch (str)
        {
            case null:
            case string.Empty:
                return DisplacedByCustomXml.None;
        }
        string str2 = str;
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("䈱䘳匵丷", num))
            {
                return DisplacedByCustomXml.Prev;
            }
            if (str2 == BookmarkStart.b("就儳丵䰷", num))
            {
                return DisplacedByCustomXml.Next;
            }
        }
        return DisplacedByCustomXml.None;
    }
}

