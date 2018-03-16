using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class464
{
    private Class464()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            smethod_1(A_0);
        }
    }

    internal static void smethod_1(Class581 A_0)
    {
        int num = 15;
        string key = A_0.imethod_1().method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_37 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                dictionary1.Add(BookmarkStart.b("吴夶圸吺䤼帾㕀⩂⩄⥆", num), 0);
                dictionary1.Add(BookmarkStart.b("䘴䈶嬸缺刼尾", num), 1);
                dictionary1.Add(BookmarkStart.b("䜴", num), 2);
                dictionary1.Add(BookmarkStart.b("崴嬶倸唺嘼", num), 3);
                dictionary1.Add(BookmarkStart.b("匴嬶崸栺吼刾ㅀ⽂⁄", num), 4);
                dictionary1.Add(BookmarkStart.b("娴稶堸伺唼", num), 5);
                dictionary1.Add(BookmarkStart.b("娴稶堸伺唼漾⁀ㅂ⑄", num), 6);
                dictionary1.Add(BookmarkStart.b("䔴制䬸嘺渼䬾⁀ㅂㅄ", num), 7);
                dictionary1.Add(BookmarkStart.b("䔴制䬸嘺砼儾╀", num), 8);
                Class1160.dictionary_37 = dictionary1;
            }
            if (Class1160.dictionary_37.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        Class519.smethod_0(A_0);
                        return;

                    case 1:
                        return;

                    case 2:
                        Class249.smethod_0(A_0);
                        return;

                    case 3:
                        Class630.smethod_0(A_0);
                        return;

                    case 4:
                        if ((A_0.imethod_1().method_54().Count > 0) && (A_0.imethod_1().method_54().Peek() is MergeField))
                        {
                            A_0.imethod_1().method_54().Pop();
                        }
                        Class802.smethod_0(A_0);
                        return;

                    case 5:
                    case 6:
                        smethod_4(A_0);
                        return;

                    case 7:
                        smethod_5(A_0);
                        return;

                    case 8:
                        smethod_6(A_0);
                        return;
                }
            }
        }
        if (A_0.vmethod_0())
        {
            smethod_9(A_0);
        }
        else if (!Class249.smethod_11(A_0, new CharacterFormat(A_0.Interface50.imethod_0())))
        {
            smethod_0(A_0);
        }
    }

    private static void smethod_2(Class581 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_12(BookmarkStart.b("崳堵䬷丹主", 14), string.Empty);
        if ((str != null) && !(str == string.Empty))
        {
            Field field = smethod_3(str, A_0.Interface50.imethod_0());
            field.ParseFieldCode(field.Code);
            A_0.method_9(field);
            class2.method_54().Push(field);
        }
    }

    private static Field smethod_3(string A_0, Document A_1)
    {
        Field field = null;
        FieldType type = Class819.smethod_2(A_0.Trim());
        FieldType type2 = type;
        if (type2 <= FieldType.FieldMergeField)
        {
            if (type2 != FieldType.FieldIf)
            {
                if (type2 != FieldType.FieldMergeField)
                {
                    goto Label_004A;
                }
                field = new MergeField(A_1);
            }
            else
            {
                field = new IfField(A_1);
            }
            goto Label_0051;
        }
        switch (type2)
        {
            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
                goto Label_0051;
        }
    Label_004A:
        field = new Field(A_1);
    Label_0051:
        field.Code = field.Code + A_0;
        if (!(field is FormField))
        {
            field.Type = type;
        }
        return field;
    }

    private static void smethod_4(Class581 A_0)
    {
        string str;
        int num = 7;
        Class582 class2 = A_0 as Class582;
        if ((class2 == null) || !class2.method_35())
        {
            throw new InvalidOperationException(BookmarkStart.b("砬䄮吰䬲䔴制娸伺堼嬾慀㝂⩄ⱆⱈ╊浌⥎㹐⅒畔V㙘⥚㥜቞ⵠ", num));
        }
        if (((str = A_0.imethod_1().method_1()) == null) || ((str != BookmarkStart.b("䈬戮倰䜲崴", num)) && (str != BookmarkStart.b("䈬戮倰䜲崴朶堸䤺尼", num))))
        {
            A_0.imethod_1().vmethod_1();
        }
    }

    private static void smethod_5(Class581 A_0)
    {
        int num = 13;
        Class394 class2 = A_0.imethod_1();
        string id = class2.method_12(BookmarkStart.b("娲儴", 13), string.Empty);
        if ((id != null) && (id != string.Empty))
        {
            PermissionStart start = new PermissionStart(A_0.Interface50.imethod_0(), id) {
                EditorGroup = smethod_7(class2),
                DisplacedByCustomXml = smethod_8(class2),
                Editor = class2.method_12(BookmarkStart.b("嘲儴", num), string.Empty)
            };
            string str2 = class2.method_12(BookmarkStart.b("倲娴嬶缸刺似䰾㕀", num), string.Empty);
            if (!string.IsNullOrEmpty(str2))
            {
                start.ColumnFirst = int.Parse(str2);
            }
            if (!string.IsNullOrEmpty(str2))
            {
                start.ColumnLast = int.Parse(str2);
            }
            A_0.method_9(start);
        }
    }

    private static void smethod_6(Class581 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        string id = class2.method_12(BookmarkStart.b("並䴨", 1), string.Empty);
        if ((id != null) && !(id == string.Empty))
        {
            PermissionEnd end = new PermissionEnd(A_0.Interface50.imethod_0(), id) {
                EditorGroup = smethod_7(class2),
                DisplacedByCustomXml = smethod_8(class2)
            };
            A_0.method_9(end);
        }
    }

    private static EditingGroup smethod_7(Class394 A_0)
    {
        int num = 12;
        string str = A_0.method_12(BookmarkStart.b("圱倳焵䨷䨹", 12), string.Empty);
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
            if (Class1160.dictionary_38 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("匱倳嬵儷吹唻䴽㐿ぁ╃㉅❇㡉㽋", num), 0);
                dictionary1.Add(BookmarkStart.b("儱嬳堵䰷䠹唻尽㔿㙁⭃㑅㭇", num), 1);
                dictionary1.Add(BookmarkStart.b("儱䄳䐵䨷弹刻䨽", num), 2);
                dictionary1.Add(BookmarkStart.b("圱倳張䰷唹主䴽", num), 3);
                dictionary1.Add(BookmarkStart.b("圱䈳匵䨷䌹医倽┿", num), 4);
                dictionary1.Add(BookmarkStart.b("崱䌳堵崷䠹伻", num), 5);
                Class1160.dictionary_38 = dictionary1;
            }
            if (Class1160.dictionary_38.TryGetValue(key, out num2))
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

    private static DisplacedByCustomXml smethod_8(Class394 A_0)
    {
        int num = 11;
        string str = A_0.method_12(BookmarkStart.b("唰娲䘴䜶唸娺帼娾╀ł㱄ц㱈㡊㥌⁎㱐୒㡔㭖", 11), string.Empty);
        switch (str)
        {
            case null:
            case string.Empty:
                return DisplacedByCustomXml.None;
        }
        string str2 = str;
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("䄰䄲倴䄶", num))
            {
                return DisplacedByCustomXml.Prev;
            }
            if (str2 == BookmarkStart.b("弰嘲䴴䌶", num))
            {
                return DisplacedByCustomXml.Next;
            }
        }
        return DisplacedByCustomXml.None;
    }

    private static void smethod_9(Class581 A_0)
    {
        A_0.imethod_1();
    }
}

