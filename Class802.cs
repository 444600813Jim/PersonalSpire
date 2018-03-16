using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;

internal class Class802
{
    private Class802()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        A_0.Interface50.imethod_0();
        Field field = smethod_1(class2.method_12(BookmarkStart.b("嬱娳䔵䰷䠹", 12), ""), A_0.Interface50.imethod_0());
        field.ParseFieldCode(field.Code);
        FieldType type = field.Type;
        A_0.method_9(field);
        class2.method_54().Push(field);
        if (!(field is MergeField))
        {
            FieldMark mark = new FieldMark(A_0.Interface50.imethod_0(), FieldMarkType.FieldSeparator);
            field.Separator = mark;
            A_0.method_9(mark);
        }
        Class464.smethod_0(A_0);
        if (!(field is MergeField))
        {
            ParagraphBase lastChild = A_0.method_13().LastChild as ParagraphBase;
            if ((lastChild != null) && !lastChild.CharacterFormat.HasDeleteRevision)
            {
                CharacterFormat format1 = (CharacterFormat) lastChild.CharacterFormat.Clone();
            }
            else
            {
                new CharacterFormat(A_0.Interface50.imethod_0());
            }
            FieldMark mark2 = new FieldMark(A_0.Interface50.imethod_0(), FieldMarkType.FieldEnd);
            A_0.method_9(mark2);
            field.End = mark2;
        }
        if ((class2.method_54().Count > 0) && (class2.method_54().Peek() == field))
        {
            class2.method_54().Pop();
        }
    }

    private static Field smethod_1(string A_0, Document A_1)
    {
        int num = 9;
        Field field = null;
        string str = A_0.Trim();
        FieldType type = Class819.smethod_2(str);
        FieldType type2 = type;
        if (type2 <= FieldType.FieldMergeField)
        {
            if (type2 != FieldType.FieldIf)
            {
                if (type2 != FieldType.FieldMergeField)
                {
                    goto Label_005C;
                }
                field = new MergeField(A_1);
            }
            else
            {
                field = new IfField(A_1);
            }
            goto Label_0113;
        }
        switch (type2)
        {
            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
            {
                string str2 = str.ToUpper();
                if (str2 != null)
                {
                    if ((str2 == BookmarkStart.b("笮琰欲愴縶眸欺格款", num)) || (str2 == BookmarkStart.b("椮縰愲破挶簸挺椼", num)))
                    {
                        field = new TextFormField(A_1);
                    }
                    else if ((str2 == BookmarkStart.b("欮田缲簴搶洸", num)) || (str2 == BookmarkStart.b("椮縰愲破猶欸琺洼笾เᑂୄ", num)))
                    {
                        field = new DropDownFormField(A_1);
                    }
                    else if ((str2 == BookmarkStart.b("氮礰瘲瘴簶笸琺攼", num)) || (str2 == BookmarkStart.b("椮縰愲破琶焸縺縼琾̀ూᵄ", num)))
                    {
                        field = new CheckBoxFormField(A_1);
                    }
                }
                (field as FormField).HasFFData = false;
                goto Label_0113;
            }
        }
    Label_005C:
        field = new Field(A_1);
    Label_0113:
        field.Code = field.Code + A_0;
        if (!(field is FormField))
        {
            field.Type = type;
        }
        return field;
    }
}

