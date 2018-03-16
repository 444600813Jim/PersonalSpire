using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.FieldCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Class655 : Interface17
{
    private bool bool_0;
    private static Hashtable hashtable_0 = new Hashtable();
    private static Hashtable hashtable_1 = new Hashtable();
    private int int_0;
    private OleLinkType oleLinkType_0;
    private string string_0 = string.Empty;
    private string string_1 = string.Empty;
    private string string_2 = string.Empty;

    static Class655()
    {
        Class791.smethod_0(new object[] { BookmarkStart.b("献䄰", 9), ShapeOleLinkType.Picture, BookmarkStart.b("献匰", 9), ShapeOleLinkType.Bitmap, BookmarkStart.b("献夰", 9), ShapeOleLinkType.Html, BookmarkStart.b("献䌰", 9), ShapeOleLinkType.Rtf, BookmarkStart.b("献䔰", 9), ShapeOleLinkType.Text, BookmarkStart.b("献䐰", 9), ShapeOleLinkType.Unicode }, hashtable_0, hashtable_1);
    }

    FieldSwitchType Interface17.imethod_0(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_118 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                dictionary1.Add(BookmarkStart.b("欶堸", num), 0);
                dictionary1.Add(BookmarkStart.b("欶崸", num), 1);
                dictionary1.Add(BookmarkStart.b("欶嬸", num), 2);
                dictionary1.Add(BookmarkStart.b("欶儸", num), 3);
                dictionary1.Add(BookmarkStart.b("欶䤸", num), 4);
                dictionary1.Add(BookmarkStart.b("欶䬸", num), 5);
                dictionary1.Add(BookmarkStart.b("欶䴸", num), 6);
                dictionary1.Add(BookmarkStart.b("欶䰸", num), 7);
                dictionary1.Add(BookmarkStart.b("欶弸", num), 8);
                Class1160.dictionary_118 = dictionary1;
            }
            if (Class1160.dictionary_118.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        return FieldSwitchType.Flag;

                    case 8:
                        return FieldSwitchType.HasArgument;
                }
            }
        }
        return FieldSwitchType.Unknown;
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal void method_1(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("崪䰬䌮䐰嘲", 5));
        this.string_0 = A_0;
    }

    internal OleLinkType method_10()
    {
        return this.oleLinkType_0;
    }

    internal void method_11(OleLinkType A_0)
    {
        this.oleLinkType_0 = A_0;
    }

    internal string method_2()
    {
        return this.string_1;
    }

    internal void method_3(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䐱唳娵䴷弹", 12));
        this.string_1 = A_0;
    }

    internal string method_4()
    {
        return this.string_2;
    }

    internal void method_5(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䌴嘶唸为堼", 15));
        this.string_2 = A_0;
    }

    internal bool method_6()
    {
        return this.bool_0;
    }

    internal void method_7(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal int method_8()
    {
        return this.int_0;
    }

    internal void method_9(int A_0)
    {
        this.int_0 = A_0;
    }

    internal static string smethod_0(Class677 A_0)
    {
        int num = 15;
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat(BookmarkStart.b("ᔴ笶瀸町瘼Ἶ㩀獂㡄杆㉈穊が潎⩐慒⡔睖", 15), A_0.method_5(), Class955.smethod_5(A_0.method_8()), Class955.smethod_5(A_0.method_10()));
        if (A_0.method_12())
        {
            builder.Append(BookmarkStart.b("椴嘶ᤸ", num));
        }
        builder.AppendFormat(BookmarkStart.b("椴儶ᤸ䀺഼䈾慀", num), A_0.method_28());
        builder.Append(smethod_2(A_0.method_26()));
        return builder.ToString();
    }

    internal static OleLinkType smethod_1(string A_0)
    {
        return (OleLinkType) Class791.smethod_3(hashtable_0, A_0, ShapeOleLinkType.Picture);
    }

    internal static string smethod_2(ShapeOleLinkType A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, BookmarkStart.b("栳䘵", 14));
    }
}

