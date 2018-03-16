using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

internal class Class643 : Class642, IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private const char char_0 = '\x0002';
    private Class1082 class1082_0;
    private Class1082 class1082_1;
    private Class1082 class1082_10;
    private Class1082 class1082_2;
    private Class1082 class1082_3;
    private Class1082 class1082_4;
    private Class1082 class1082_5;
    private Class1082 class1082_6;
    private Class1082 class1082_7;
    private Class1082 class1082_8;
    private Class1082 class1082_9;
    private Dictionary<string, string> dictionary_0;
    private Dictionary<string, string> dictionary_1;
    private Dictionary<string, string> dictionary_2;
    private Dictionary<string, Dictionary<int, int>> dictionary_3;
    private Dictionary<string, int> dictionary_4;
    private Dictionary<int, string> dictionary_5;
    private Dictionary<int, int> dictionary_6;
    private Dictionary<Color, int> dictionary_7;
    private Dictionary<string, int> dictionary_8 = new Dictionary<string, int>();
    private Dictionary<string, Struct35> dictionary_9 = new Dictionary<string, Struct35>();
    private Document document_0;
    private const float float_1 = 12f;
    private const int int_3 = 8;
    private int int_4 = 1;
    private int int_5 = 1;
    private int int_6;
    private int int_7;
    private int int_8 = 1;
    private int int_9 = 1;
    private List<string> list_0;
    private List<Class51> list_1 = new List<Class51>();
    private const long long_0 = 0x2e80ff06L;
    private Stack<object> stack_0;
    private Stack<Field> stack_1;
    private StreamWriter streamWriter_0;
    private const string string_0 = "Times New Roman";
    private readonly string string_1 = '\x00a0'.ToString();
    private readonly string string_10 = '–'.ToString();
    private readonly string string_11 = '—'.ToString();
    private readonly string string_12 = '†'.ToString();
    private readonly string string_13 = '‡'.ToString();
    private readonly string string_14 = '{'.ToString();
    private readonly string string_15 = '}'.ToString();
    private readonly string string_16 = '\x00a7'.ToString();
    private readonly string string_17 = '\x00dc'.ToString();
    private readonly string string_18 = '\x00fc'.ToString();
    private readonly string string_19 = '\x00d6'.ToString();
    private readonly string string_2 = ' '.ToString();
    private readonly string string_20 = '\x00f6'.ToString();
    private readonly string string_21 = '\x00c4'.ToString();
    private readonly string string_22 = '\x00e4'.ToString();
    private readonly string string_23 = '\x00df'.ToString();
    private readonly string string_24 = '\\'.ToString();
    private readonly string string_25 = '•'.ToString();
    private readonly string string_26 = '“'.ToString();
    private readonly string string_27 = '”'.ToString();
    private readonly string string_3 = '\\'.ToString();
    private readonly string string_4 = '\x001f'.ToString();
    private readonly string string_5 = ((char) 0xf071).ToString();
    private readonly string string_6 = ((char) 0xf06d).ToString();
    private readonly string string_7 = '…'.ToString();
    private readonly string string_8 = '’'.ToString();
    private readonly string string_9 = '‘'.ToString();

    [DllImport("gdiplus.dll")]
    private static extern uint GdipEmfToWmfBits(IntPtr A_0, uint A_1, byte[] A_2, int A_3, Class642.EmfToWmfBitsFlags A_4);
    private Stack<Field> method_0()
    {
        if (this.stack_1 == null)
        {
            this.stack_1 = new Stack<Field>();
        }
        return this.stack_1;
    }

    private Class1082 method_1()
    {
        if (this.class1082_0 == null)
        {
            this.class1082_0 = new Class1082();
        }
        return this.class1082_0;
    }

    private Class1082 method_10()
    {
        if (this.class1082_7 == null)
        {
            this.class1082_7 = new Class1082();
        }
        return this.class1082_7;
    }

    private void method_100(FieldMark A_0)
    {
        int num = 10;
        if ((this.stack_0 != null) && (this.method_19().Count != 0))
        {
            switch (A_0.Type)
            {
                case FieldMarkType.FieldSeparator:
                    this.method_6().method_3(BookmarkStart.b("䴯伱", num));
                    this.method_6().method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("嘯帱倳䐵䬷嘹䠻ḽ", num));
                    return;

                case FieldMarkType.FieldEnd:
                {
                    object obj2 = this.method_19().Peek();
                    Field field = (obj2 is Field) ? (obj2 as Field) : ((obj2 is TableOfContent) ? (obj2 as TableOfContent).TOCField : null);
                    if (field != null)
                    {
                        if ((field.Separator != null) || (field is TextFormField))
                        {
                            this.method_6().method_3(BookmarkStart.b("䴯伱", num));
                        }
                        else
                        {
                            this.method_6().method_3(BookmarkStart.b("䴯伱䤳", num));
                        }
                    }
                    this.method_19().Pop();
                    if ((this.stack_1 != null) && (this.stack_1.Count > 0))
                    {
                        this.stack_1.Pop();
                    }
                    if ((this.method_19().Count > 0) && (this.method_19().Peek() is TextFormField))
                    {
                        this.method_6().method_6(this.method_159(this.method_19().Peek() as TextFormField));
                    }
                    return;
                }
            }
        }
    }

    private Class1082 method_101(Field A_0)
    {
        int num = 15;
        this.method_19().Push(A_0);
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("临", 15) + this.string_24 + BookmarkStart.b("匴帶尸场夼", 15));
        if (A_0.IsLocked)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("匴嬶崸场刼尾⩀", num));
        }
        class2.method_3(BookmarkStart.b("临", num) + this.string_24 + BookmarkStart.b("ἴ", num) + this.string_24 + BookmarkStart.b("匴嬶崸刺匼䰾㕀捂㹄", num));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("ᔴ", num));
        if (!string.IsNullOrEmpty(A_0.Code))
        {
            class2.method_3(this.method_183(A_0.Code));
            return class2;
        }
        class2.method_3(this.method_168(A_0.Type));
        class2.method_3(A_0.Value.Replace(this.string_3, this.string_3 + this.string_3));
        if (A_0.Type == FieldType.FieldTime)
        {
            A_0.m_formattingString = this.string_24 + A_0.m_formattingString.Trim();
        }
        class2.method_3(A_0.FormattingString);
        return class2;
    }

    private void method_102(Break A_0)
    {
        int num = 0x10;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䴵", 0x10));
        class2.method_0(this.method_37(A_0.TextRange.CharacterFormat));
        switch (A_0.BreakType)
        {
            case BreakType.PageBreak:
                class2.method_1(this.string_24 + BookmarkStart.b("䘵夷崹夻", num));
                break;

            case BreakType.ColumnBreak:
                class2.method_1(this.string_24 + BookmarkStart.b("唵圷嘹䤻匽⸿", num));
                break;

            case BreakType.LineBreak:
                if (A_0.IsCrBreak)
                {
                    class2.method_1(this.string_24 + BookmarkStart.b("娵娷䠹", num) + ((byte) A_0.ClearType).ToString());
                }
                class2.method_1(this.string_24 + BookmarkStart.b("娵儷吹夻", num));
                break;
        }
        class2.method_1(BookmarkStart.b("䬵", num));
        this.method_6().method_2(class2);
    }

    private Class1083 method_103(TextRange A_0)
    {
        int num = 0x13;
        string text = A_0.Text;
        Class1083 class2 = new Class1083();
        char ch = '\x0002';
        if (text.StartsWith(ch.ToString()))
        {
            text = text.Replace('\x0002'.ToString(), string.Empty);
            Footnote footnote = this.method_104(A_0);
            class2.method_1(BookmarkStart.b("䈸", num));
            class2.method_0(this.method_37((footnote != null) ? footnote.MarkerCharacterFormat : A_0.CharacterFormat));
            class2.method_1(this.string_24 + BookmarkStart.b("娸区嬼䬾⽀", num));
            class2.method_1(BookmarkStart.b("䐸", num));
        }
        else
        {
            text = text.Replace('\x0002'.ToString(), string.Empty);
        }
        if (string.IsNullOrEmpty(text))
        {
            class2.method_1(string.Empty);
            return class2;
        }
        string str2 = this.method_178(text);
        char ch3 = '\r';
        if (str2.IndexOf('\r') == -1)
        {
            class2.method_0(this.method_185(A_0.CharacterFormat, this.method_183(str2)));
            return class2;
        }
        CharacterFormat format = (A_0.OwnerParagraph == null) ? this.document_0.DefCharFormat : A_0.OwnerParagraph.BreakCharacterFormat;
        string str3 = string.Empty;
        while (true)
        {
            int index = str2.IndexOf(ch3);
            if (index != 0)
            {
                if (index == -1)
                {
                    index = str2.Length;
                }
                str3 = str2.Substring(0, index);
                class2.method_0(this.method_185(A_0.CharacterFormat, this.method_183(str3)));
                str2 = str2.Remove(0, index);
            }
            else
            {
                class2.method_0(this.method_185(format, this.string_24 + BookmarkStart.b("䤸娺似", num)));
                str2 = str2.Remove(0, 1);
            }
            if (str2.Length == 0)
            {
                return class2;
            }
        }
    }

    private Footnote method_104(ParagraphBase A_0)
    {
        for (DocumentObject obj2 = A_0.Owner; obj2 != null; obj2 = obj2.Owner)
        {
            if (obj2 is Footnote)
            {
                return (obj2 as Footnote);
            }
        }
        return null;
    }

    private void method_105(BookmarkEnd A_0)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䈸", 0x13));
        class2.method_1(this.string_24 + BookmarkStart.b("ጸ", 0x13) + this.string_24 + BookmarkStart.b("嬸债值吾⑀ⵂ⅄杆", 0x13));
        class2.method_1(this.method_184(A_0.Name));
        class2.method_1(BookmarkStart.b("䐸", 0x13));
        class2.method_1(Environment.NewLine);
        this.method_6().method_2(class2);
    }

    private void method_106(BookmarkStart A_0)
    {
        int num = 8;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("唭", 8));
        class2.method_3(this.string_24 + BookmarkStart.b("Э", 8) + this.string_24 + BookmarkStart.b("䰭嬯弱弳䔵䰷嬹主䨽怿", 8));
        class2.method_3(this.method_184(A_0.Name));
        if (A_0.ColumnFirst >= 0)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䰭嬯弱弳唵圷嘹娻", num) + A_0.ColumnFirst);
        }
        if (A_0.ColumnLast >= 0)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䰭嬯弱弳唵圷嘹倻", num) + (A_0.ColumnLast + 1));
        }
        class2.method_3(BookmarkStart.b("匭", num));
        class2.method_3(Environment.NewLine);
        this.method_6().method_6(class2);
    }

    private void method_107(PermissionStart A_0)
    {
        int num = 1;
        string id = A_0.Id;
        int num2 = this.method_109();
        if (!this.dictionary_8.ContainsKey(id))
        {
            this.dictionary_8.Add(id, num2);
        }
        else
        {
            this.dictionary_8[id] = num2;
        }
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("尦", num));
        class2.method_3(this.string_24 + BookmarkStart.b("ദ", num) + this.string_24 + BookmarkStart.b("圦嬨䐪夬尮䔰刲䜴䌶ᤸ", num));
        class2.method_3(this.method_184(num2.ToString()));
        class2.method_3(BookmarkStart.b("娦", num));
        class2.method_3(Environment.NewLine);
        this.method_6().method_6(class2);
    }

    private void method_108(PermissionEnd A_0)
    {
        int num = 0x11;
        if (this.dictionary_8.ContainsKey(A_0.Id))
        {
            Class1082 class2 = new Class1082();
            class2.method_3(BookmarkStart.b("䰶", num));
            class2.method_3(this.string_24 + BookmarkStart.b("ᴶ", num) + this.string_24 + BookmarkStart.b("䜶䬸吺䤼娾⽀❂敄", num));
            int num2 = this.dictionary_8[A_0.Id];
            class2.method_3(this.method_184(num2.ToString()));
            class2.method_3(BookmarkStart.b("䨶", num));
            class2.method_3(Environment.NewLine);
            this.method_6().method_6(class2);
        }
    }

    private int method_109()
    {
        return ++this.int_9;
    }

    private Class1082 method_11()
    {
        if (this.class1082_8 == null)
        {
            this.class1082_8 = new Class1082();
        }
        return this.class1082_8;
    }

    private void method_110(TableOfContent A_0)
    {
        int num = 1;
        this.method_19().Push(A_0);
        Class1082 class2 = new Class1082();
        class2.method_3(Environment.NewLine);
        class2.method_3(BookmarkStart.b("尦", 1) + this.string_24 + BookmarkStart.b("䄦䀨个䄬䬮", 1));
        if (A_0.TOCField.IsLocked)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䄦䔨伪䄬䀮到堲", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("䄦䔨伪䤬䘮䌰䜲䰴", num));
        class2.method_3(BookmarkStart.b("尦", num) + this.string_24 + BookmarkStart.b("ദ", num) + this.string_24 + BookmarkStart.b("䄦䔨伪䐬䄮䈰䜲ᔴ䰶", num));
        class2.method_2(this.method_37(A_0.TOCField.CharacterFormat));
        class2.method_3(BookmarkStart.b("ܦ紨搪測༮", num));
        class2.method_3(A_0.TOCField.Value);
        class2.method_3(A_0.FormattingString.Replace(this.string_24, this.string_24 + this.string_24));
        this.method_6().method_6(class2);
    }

    private Class1082 method_111(DocOleObject A_0)
    {
        int num = 0;
        Class1082 class2 = new Class1082();
        if ((A_0 != null) && ((A_0 == null) || ((A_0.Interface49.get_OlePicture() != null) && (A_0.Interface49.get_NativeData() != null))))
        {
            Field item = new Field(this.document_0) {
                Type = FieldType.FieldEmbed
            };
            this.method_0().Push(item);
            class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("䤥䨧䀩䤫䴭䐯", num));
            if (A_0.Interface49.get_LinkType() == OleLinkType.Embed)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䤥䨧䀩䤫䌭刯", num));
            }
            class2.method_3(this.string_24 + BookmarkStart.b("䤥䨧䀩嬫", num) + Math.Round((double) (A_0.Interface49.get_OlePicture().Width * 20f)));
            class2.method_3(this.string_24 + BookmarkStart.b("䤥䨧䀩䐫", num) + Math.Round((double) (A_0.Interface49.get_OlePicture().Height * 20f)));
            string str = A_0.Interface49.get_ObjectType();
            if (!string.IsNullOrEmpty(str))
            {
                class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("థ", num) + this.string_24 + BookmarkStart.b("䤥䨧䀩伫䈭儯䄱䜳ᘵ", num) + str + BookmarkStart.b("嬥", num));
            }
            class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("థ", num) + this.string_24 + BookmarkStart.b("䤥䨧䀩䠫伭䐯匱ᐳ", num));
            class2.method_3(smethod_0(A_0.method_109()));
            class2.method_3(BookmarkStart.b("嬥", num));
            class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("吥䴧天夫䈭䐯ሱ", num));
            class2.method_2(this.method_112(A_0.Interface49.get_OlePicture()));
            class2.method_3(BookmarkStart.b("嬥", num));
            class2.method_3(BookmarkStart.b("嬥", num));
            class2.method_3(Environment.NewLine);
            return class2;
        }
        class2.method_3(string.Empty);
        return class2;
    }

    private Class1083 method_112(DocPicture A_0)
    {
        if (!A_0.SkipDocxItem && A_0.HasImage)
        {
            if (A_0.TextWrappingStyle == TextWrappingStyle.Inline)
            {
                return this.method_114(A_0);
            }
            return this.method_113(A_0);
        }
        return new Class1083();
    }

    private Class1083 method_113(DocPicture A_0)
    {
        int num = 14;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("伳", 14));
        class2.method_0(this.method_37(A_0.CharacterFormat));
        class2.method_1(BookmarkStart.b("伳", 14) + this.string_24 + BookmarkStart.b("䜳帵䠷", 14));
        class2.method_1(BookmarkStart.b("伳", 14) + this.string_24 + BookmarkStart.b("ḳ", 14) + this.string_24 + BookmarkStart.b("䜳帵䠷匹刻䴽㐿", 14));
        int num2 = (int) Math.Round((double) (((A_0.Width * 20f) * A_0.WidthScale) / 100f));
        int num3 = (int) Math.Round((double) (((A_0.Height * 20f) * A_0.HeightScale) / 100f));
        class2.method_0(this.method_131(A_0.HorizontalPosition, A_0.VerticalPosition, num2, num3));
        if (A_0.IsHeaderPicture)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷尹吻娽㈿獁", num));
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷尹吻娽㈿牁", num));
        }
        if (A_0.HorizontalOrigin == HorizontalOrigin.Page)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷堹䐻丽ℿ╁⅃", num));
        }
        else if (A_0.HorizontalOrigin == HorizontalOrigin.Margin)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷堹䐻匽ℿぁ⍃⽅♇", num));
        }
        else if (A_0.HorizontalOrigin == HorizontalOrigin.Column)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷堹䐻崽⼿⹁ㅃ⭅♇", num));
        }
        if (A_0.VerticalOrigin == VerticalOrigin.Page)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷堹䔻丽ℿ╁⅃", num));
        }
        else if (A_0.VerticalOrigin == VerticalOrigin.Margin)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷堹䔻匽ℿぁ⍃⽅♇", num));
        }
        else if (A_0.VerticalOrigin == VerticalOrigin.Paragraph)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷堹䔻丽ℿぁ╃", num));
        }
        class2.method_1(this.method_123(A_0.TextWrappingStyle, A_0.TextWrappingType));
        if (A_0.IsUnderText)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷尹帻刽㜿㙁㱃㉅祇", num));
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䜳帵䠷尹帻刽㜿㙁㱃㉅硇", num));
        }
        class2.method_1(this.method_125(BookmarkStart.b("䜳帵夷䨹夻樽㤿㉁⅃", num), BookmarkStart.b("̵̳", num)));
        class2.method_1(this.method_125(BookmarkStart.b("刳琵崷刹唻倽␿ف⭃╅㵇❉⥋⁍⑏", num), this.method_83(A_0.IsUnderText)));
        class2.method_1(this.method_125(BookmarkStart.b("刳稵夷䌹医䬽㐿ୁ⩃Յⵇ♉⁋", num), this.method_83(A_0.AllowInCell)));
        class2.method_1(this.method_125(BookmarkStart.b("刳稵儷吹夻", num), this.method_83(!A_0.Borders.NoBorder)));
        class2.method_0(this.method_126(BookmarkStart.b("䐳張娷", num), this.method_117(A_0)));
        class2.method_1(BookmarkStart.b("䤳䬵䔷", num));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private Class1083 method_114(DocPicture A_0)
    {
        int num = 0;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("崥", 0));
        class2.method_0(this.method_37(A_0.CharacterFormat));
        if (A_0.IsMetaFile)
        {
            this.method_121(A_0, class2);
        }
        else
        {
            class2.method_1(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("唥䀧娩尫䜭匯䘱", num));
            class2.method_0(this.method_115(A_0));
            class2.method_1(BookmarkStart.b("嬥", num));
            class2.method_1(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("䠥䜧䐩弫䘭䀯䈱崳唵䰷", num));
            this.method_121(A_0, class2);
            class2.method_1(BookmarkStart.b("嬥", num));
        }
        class2.method_1(BookmarkStart.b("嬥", num));
        return class2;
    }

    private Class1083 method_115(DocPicture A_0)
    {
        int num = 9;
        Class1083 class2 = new Class1083(0x1388);
        class2.method_1(BookmarkStart.b("吮", 9) + this.string_24 + BookmarkStart.b("弮堰倲䄴", 9));
        class2.method_1(BookmarkStart.b("吮", 9) + this.string_24 + BookmarkStart.b("Ԯ", 9) + this.string_24 + BookmarkStart.b("弮堰倲䔴䔶嘸䬺", 9));
        class2.method_1(this.method_125(BookmarkStart.b("尮夰刲䔴制洸䈺䴼娾", 9), BookmarkStart.b("ᠮа", 9)));
        class2.method_1(this.method_125(BookmarkStart.b("䤮細刲䰴堶䰸伺琼儾ɀ♂⥄⭆", 9), A_0.LayoutInCell ? BookmarkStart.b("Ḯ", num) : BookmarkStart.b("Ἦ", num)));
        if (A_0.Borders.NoBorder)
        {
            class2.method_1(this.method_125(BookmarkStart.b("䤮細娲嬴制", num), BookmarkStart.b("Ἦ", num)));
        }
        else
        {
            class2.method_1(this.method_125(BookmarkStart.b("䤮細娲嬴制", num), BookmarkStart.b("Ḯ", num)));
        }
        class2.method_1(this.method_127(A_0.HorizontalAlignment));
        class2.method_1(this.method_129(A_0.HorizontalOrigin));
        class2.method_1(this.method_128(A_0.VerticalAlignment));
        class2.method_1(this.method_130(A_0.VerticalOrigin));
        class2.method_1(BookmarkStart.b("刮", num));
        class2.method_0(this.method_116(A_0));
        class2.method_1(this.string_24 + this.method_118(A_0));
        if (A_0.OrderIndex != 0L)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䴮崰娲䔴䌶堸尺", num) + this.method_119(A_0.OrderIndex).ToString());
        }
        class2.method_1(Environment.NewLine);
        class2.method_0(this.method_120(A_0.ImageBytes));
        class2.method_1(BookmarkStart.b("刮", num));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private Class1083 method_116(DocPicture A_0)
    {
        int num = 0;
        Class1083 class2 = new Class1083();
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩弫䴭儯帱儳丵", 0));
        class2.method_5((A_0.WidthScale <= 0f) ? 1f : A_0.WidthScale);
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩弫䴭儯帱儳伵", num));
        class2.method_5((A_0.HeightScale <= 0f) ? 1f : A_0.HeightScale);
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩伫尭弯䈱堳", num));
        class2.method_6(Math.Round((double) (A_0.CropFromLeft * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩伫尭弯䈱䘳", num));
        class2.method_6(Math.Round((double) (A_0.CropFromRight * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩伫尭弯䈱䀳", num));
        class2.method_6(Math.Round((double) (A_0.CropFromTop * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩伫尭弯䈱嘳", num));
        class2.method_6(Math.Round((double) (A_0.CropFromBottom * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩嬫", num));
        class2.method_6(Math.Round((double) (A_0.Width * 35.3f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩䐫", num));
        class2.method_6(Math.Round((double) (A_0.Height * 35.3f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩嬫䤭弯匱堳", num));
        class2.method_6(Math.Round((double) (A_0.Width * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("嘥䄧䤩䐫䤭弯匱堳", num));
        class2.method_6(Math.Round((double) (A_0.Height * 20f)));
        return class2;
    }

    private Class1083 method_117(DocPicture A_0)
    {
        int num = 3;
        Class1083 class2 = new Class1083(0x1388);
        class2.method_1(BookmarkStart.b("刨", 3) + this.string_24 + BookmarkStart.b("夨䈪丬嬮", 3));
        class2.method_0(this.method_116(A_0));
        class2.method_1(this.string_24 + this.method_118(A_0));
        if (A_0.OrderIndex != 0L)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䬨䜪䐬弮䔰刲刴", num) + this.method_119(A_0.OrderIndex).ToString());
        }
        class2.method_1(Environment.NewLine);
        class2.method_0(this.method_120(A_0.ImageBytes));
        class2.method_1(BookmarkStart.b("吨", num));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private string method_118(DocPicture A_0)
    {
        int num = 0x10;
        if (A_0.IsMetaFile)
        {
            return BookmarkStart.b("䄵唷弹䠻弽☿⭁⡃⍅灇", num);
        }
        if (Class777.smethod_3(A_0.ImageBytes) == Class777.ImageType.PNG)
        {
            return BookmarkStart.b("䘵嘷崹帻刽⤿㉁", num);
        }
        return BookmarkStart.b("尵䠷弹嬻尽ⰿ⭁㑃", num);
    }

    private long method_119(long A_0)
    {
        long num = 0x2e80ff06L + Math.Abs(A_0);
        if (num == 0x7fffffffffffffffL)
        {
            num = Math.Abs(A_0);
        }
        if (A_0 >= 0L)
        {
            return num;
        }
        return -num;
    }

    private Dictionary<string, int> method_12()
    {
        if (this.dictionary_4 == null)
        {
            this.dictionary_4 = new Dictionary<string, int>();
        }
        return this.dictionary_4;
    }

    private Class1083 method_120(byte[] A_0)
    {
        int num = 0x11;
        Class1083 class2 = new Class1083();
        if (A_0 != null)
        {
            int index = 0;
            int length = A_0.Length;
            while (index < length)
            {
                class2.method_1(A_0[index].ToString(BookmarkStart.b("漶ସ", num)));
                index++;
            }
        }
        return class2;
    }

    private void method_121(DocPicture A_0, Class1083 A_1)
    {
        int num = 3;
        A_1.method_1(BookmarkStart.b("刨", 3) + this.string_24 + BookmarkStart.b("夨䈪丬嬮", 3));
        A_1.method_0(this.method_116(A_0));
        A_1.method_1(this.string_24 + BookmarkStart.b("帨䘪䠬嬮倰唲尴嬶尸̺", 3));
        if (A_0.OrderIndex != 0L)
        {
            A_1.method_1(this.string_24 + BookmarkStart.b("䬨䜪䐬弮䔰刲刴", num) + this.method_119(A_0.OrderIndex).ToString());
        }
        A_1.method_1(Environment.NewLine);
        byte[] imageBytes = null;
        if (A_0.IsMetaFile)
        {
            imageBytes = A_0.ImageBytes;
        }
        else if (A_0.Image != null)
        {
            imageBytes = this.method_122(A_0.Image);
        }
        if (imageBytes != null)
        {
            int index = 0;
            int length = imageBytes.Length;
            while (index < length)
            {
                A_1.method_1(imageBytes[index].ToString(BookmarkStart.b("儨ᤪ", num)));
                index++;
            }
            imageBytes = null;
        }
        A_1.method_1(BookmarkStart.b("吨", num));
        A_1.method_1(Environment.NewLine);
    }

    private byte[] method_122(Image A_0)
    {
        MemoryStream stream = null;
        Graphics graphics = null;
        Metafile image = null;
        byte[] buffer2;
        try
        {
            stream = new MemoryStream();
            Bitmap bitmap = new Bitmap(A_0.Width, A_0.Height, PixelFormat.Format32bppArgb);
            using (graphics = Graphics.FromImage(bitmap))
            {
                IntPtr hdc = graphics.GetHdc();
                image = new Metafile(stream, hdc);
                graphics.ReleaseHdc(hdc);
            }
            using (graphics = Graphics.FromImage(image))
            {
                graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height));
            }
            IntPtr henhmetafile = image.GetHenhmetafile();
            uint num = GdipEmfToWmfBits(henhmetafile, 0, null, 8, Class642.EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
            byte[] buffer = new byte[num];
            GdipEmfToWmfBits(henhmetafile, num, buffer, 8, Class642.EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
            buffer2 = buffer;
        }
        finally
        {
            if (graphics != null)
            {
                graphics.Dispose();
            }
            if (image != null)
            {
                image.Dispose();
            }
            if (stream != null)
            {
                stream.Close();
            }
        }
        return buffer2;
    }

    private string method_123(TextWrappingStyle A_0, TextWrappingType A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case TextWrappingStyle.TopAndBottom:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶࠸", num));

            case TextWrappingStyle.Square:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶ସ", num) + this.method_124(A_1));

            case TextWrappingStyle.Tight:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶സ", num) + this.method_124(A_1));

            case TextWrappingStyle.Through:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶స", num));
        }
        return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶ਸ", num));
    }

    private string method_124(TextWrappingType A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case TextWrappingType.Both:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶券଺", num));

            case TextWrappingType.Left:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶券਺", num));

            case TextWrappingType.Right:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶券ऺ", num));

            case TextWrappingType.Largest:
                return (this.string_24 + BookmarkStart.b("尮夰䌲䈴䔶券࠺", num));
        }
        return string.Empty;
    }

    private string method_125(string A_0, string A_1)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("䌯䈱", 10));
        class2.method_1(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("䌯就ᐳ", 10));
        class2.method_1(A_0);
        class2.method_1(BookmarkStart.b("䴯", 10));
        class2.method_1(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("䌯䐱ᐳ", 10));
        class2.method_1(A_1);
        class2.method_1(BookmarkStart.b("䴯伱", 10));
        class2.method_1(Environment.NewLine);
        return class2.ToString();
    }

    private Class1083 method_126(string A_0, Class1083 A_1)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䨰", 11) + this.string_24 + BookmarkStart.b("䈰䌲", 11));
        class2.method_1(BookmarkStart.b("䨰", 11) + this.string_24 + BookmarkStart.b("䈰崲ᔴ", 11));
        class2.method_1(A_0);
        class2.method_1(BookmarkStart.b("䰰", 11));
        class2.method_1(BookmarkStart.b("䨰", 11) + this.string_24 + BookmarkStart.b("䈰䔲ᔴ", 11));
        class2.method_0(A_1);
        class2.method_1(BookmarkStart.b("䰰串", 11));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private string method_127(ShapeHorizontalAlignment A_0)
    {
        int num = 15;
        switch (A_0)
        {
            case ShapeHorizontalAlignment.Left:
                return this.method_125(BookmarkStart.b("䔴堶䨸区", num), BookmarkStart.b("д", num));

            case ShapeHorizontalAlignment.Center:
                return this.method_125(BookmarkStart.b("䔴堶䨸区", num), BookmarkStart.b("ܴ", num));

            case ShapeHorizontalAlignment.Right:
                return this.method_125(BookmarkStart.b("䔴堶䨸区", num), BookmarkStart.b("ش", num));

            case ShapeHorizontalAlignment.Inside:
                return this.method_125(BookmarkStart.b("䔴堶䨸区", num), BookmarkStart.b("Ĵ", num));

            case ShapeHorizontalAlignment.Outside:
                return this.method_125(BookmarkStart.b("䔴堶䨸区", num), BookmarkStart.b("4", num));
        }
        return string.Empty;
    }

    private string method_128(ShapeVerticalAlignment A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case ShapeVerticalAlignment.Top:
                return this.method_125(BookmarkStart.b("䘵圷䤹䨻", num), BookmarkStart.b("ܵ", num));

            case ShapeVerticalAlignment.Center:
                return this.method_125(BookmarkStart.b("䘵圷䤹䨻", num), BookmarkStart.b("е", num));

            case ShapeVerticalAlignment.Bottom:
                return this.method_125(BookmarkStart.b("䘵圷䤹䨻", num), BookmarkStart.b("Ե", num));

            case ShapeVerticalAlignment.Inside:
                return this.method_125(BookmarkStart.b("䘵圷䤹䨻", num), BookmarkStart.b("ȵ", num));

            case ShapeVerticalAlignment.Outside:
                return this.method_125(BookmarkStart.b("䘵圷䤹䨻", num), BookmarkStart.b("̵", num));
        }
        return string.Empty;
    }

    private string method_129(HorizontalOrigin A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case HorizontalOrigin.Margin:
                return this.method_125(BookmarkStart.b("嘥䜧天師䬭尯娱", num), BookmarkStart.b("ᘥ", num));

            case HorizontalOrigin.Page:
                return this.method_125(BookmarkStart.b("嘥䜧天師䬭尯娱", num), BookmarkStart.b("ᜥ", num));

            case HorizontalOrigin.Column:
                return this.method_125(BookmarkStart.b("嘥䜧天師䬭尯娱", num), BookmarkStart.b("ᐥ", num));

            case HorizontalOrigin.Character:
                return this.method_125(BookmarkStart.b("嘥䜧天師䬭尯娱", num), BookmarkStart.b("ᔥ", num));
        }
        return string.Empty;
    }

    private Dictionary<int, string> method_13()
    {
        if (this.dictionary_5 == null)
        {
            this.dictionary_5 = new Dictionary<int, string>();
        }
        return this.dictionary_5;
    }

    private string method_130(VerticalOrigin A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case VerticalOrigin.Margin:
                return this.method_125(BookmarkStart.b("䐳夵䬷䠹夻刽㘿", num), BookmarkStart.b("г", num));

            case VerticalOrigin.Page:
                return this.method_125(BookmarkStart.b("䐳夵䬷䠹夻刽㘿", num), BookmarkStart.b("Գ", num));

            case VerticalOrigin.Paragraph:
                return this.method_125(BookmarkStart.b("䐳夵䬷䠹夻刽㘿", num), BookmarkStart.b("س", num));

            case VerticalOrigin.Line:
                return this.method_125(BookmarkStart.b("䐳夵䬷䠹夻刽㘿", num), BookmarkStart.b("ܳ", num));
        }
        return string.Empty;
    }

    private Class1083 method_131(float A_0, float A_1, int A_2, int A_3)
    {
        int num = 6;
        Class1083 class2 = new Class1083();
        if ((A_0 == 0f) && (A_1 == 0f))
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯䀱崳儵倷丹", num));
            class2.method_4(A_2);
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱嬳䈵䰷唹儻", num));
            class2.method_4(A_3);
            return class2;
        }
        class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯帱儳倵䰷", num));
        class2.method_5(A_0 * 20f);
        class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯䘱嬳䘵", num));
        class2.method_5(A_1 * 20f);
        class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯䀱崳儵倷丹", num));
        class2.method_5((A_0 * 20f) + A_2);
        class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱嬳䈵䰷唹儻", num));
        class2.method_5((A_1 * 20f) + A_3);
        return class2;
    }

    private void method_132(TextBox A_0)
    {
        int num = 11;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䨰", 11));
        class2.method_0(this.method_37(A_0.CharacterFormat));
        class2.method_1(BookmarkStart.b("䨰", 11) + this.string_24 + BookmarkStart.b("䈰嬲䔴", 11));
        class2.method_1(BookmarkStart.b("䨰", 11) + this.string_24 + BookmarkStart.b("ᬰ", 11) + this.string_24 + BookmarkStart.b("䈰嬲䔴帶圸䠺䤼", 11));
        class2.method_0(this.method_131(A_0.Format.HorizontalPosition, A_0.Format.VerticalPosition, ((int) A_0.Format.Width) * 20, ((int) A_0.Format.Height) * 20));
        if (A_0.Format.IsHeaderTextBox)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴儶儸强似฾", num));
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴儶儸强似༾", num));
        }
        if (A_0.Format.HorizontalOrigin == HorizontalOrigin.Page)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴唶䄸䬺尼堾⑀", num));
        }
        else if (A_0.Format.HorizontalOrigin == HorizontalOrigin.Margin)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴唶䄸嘺尼䴾♀⩂⭄", num));
        }
        else if (A_0.Format.HorizontalOrigin == HorizontalOrigin.Column)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴唶䄸堺刼匾㑀⹂⭄", num));
        }
        if (A_0.Format.VerticalOrigin == VerticalOrigin.Page)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴唶䀸䬺尼堾⑀", num));
        }
        else if (A_0.Format.VerticalOrigin == VerticalOrigin.Margin)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴唶䀸嘺尼䴾♀⩂⭄", num));
        }
        else if (A_0.Format.VerticalOrigin == VerticalOrigin.Paragraph)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴唶䀸䬺尼䴾⁀", num));
        }
        class2.method_1(this.method_123(A_0.Format.TextWrappingStyle, A_0.Format.TextWrappingType));
        if (A_0.Format.IsBelowText)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴儶嬸场䨼䬾㥀㝂瑄", num));
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䈰嬲䔴儶嬸场䨼䬾㥀㝂畄", num));
        }
        class2.method_1(this.method_125(BookmarkStart.b("䈰嬲吴䜶尸漺䐼伾⑀", num), BookmarkStart.b("̰̲ܴ", num)));
        if (A_0.Format.NoLine)
        {
            class2.method_1(this.method_125(BookmarkStart.b("地缲尴夶尸", num), BookmarkStart.b("İ", num)));
        }
        if (A_0.Format.IsBelowText)
        {
            class2.method_1(this.method_125(BookmarkStart.b("地焲倴弶倸唺夼笾⹀⁂い⩆ⱈ╊㥌", num), BookmarkStart.b("0", num)));
        }
        else
        {
            class2.method_1(this.method_125(BookmarkStart.b("地焲倴弶倸唺夼笾⹀⁂い⩆ⱈ╊㥌", num), BookmarkStart.b("İ", num)));
        }
        switch (A_0.Format.HorizontalAlignment)
        {
            case ShapeHorizontalAlignment.Left:
                class2.method_1(this.method_125(BookmarkStart.b("䄰尲䘴弶", num), BookmarkStart.b("0", num)));
                break;

            case ShapeHorizontalAlignment.Center:
                class2.method_1(this.method_125(BookmarkStart.b("䄰尲䘴弶", num), BookmarkStart.b("̰", num)));
                break;

            case ShapeHorizontalAlignment.Right:
                class2.method_1(this.method_125(BookmarkStart.b("䄰尲䘴弶", num), BookmarkStart.b("Ȱ", num)));
                break;

            case ShapeHorizontalAlignment.Inside:
                class2.method_1(this.method_125(BookmarkStart.b("䄰尲䘴弶", num), BookmarkStart.b("԰", num)));
                break;

            case ShapeHorizontalAlignment.Outside:
                class2.method_1(this.method_125(BookmarkStart.b("䄰尲䘴弶", num), BookmarkStart.b("а", num)));
                break;
        }
        class2.method_0(this.method_134(A_0.Format.LineColor, A_0.Format.LineDashing, A_0.Format.LineWidth));
        class2.method_1(this.method_133(A_0.Format.LineStyle));
        class2.method_0(this.method_135(A_0.Format.FillEfects));
        class2.method_1(BookmarkStart.b("䨰", num) + this.string_24 + BookmarkStart.b("䈰嬲䔴䌶䄸伺", num));
        this.method_6().method_2(class2);
        this.method_31(A_0.Body.Items);
        class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䰰串䠴䨶", num));
        class2.method_1(Environment.NewLine);
        this.method_6().method_2(class2);
    }

    private string method_133(TextBoxLineStyle A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case TextBoxLineStyle.Double:
                return this.method_125(BookmarkStart.b("帱崳堵崷椹䠻䜽ⰿ❁", num), BookmarkStart.b("̱", num));

            case TextBoxLineStyle.ThickThin:
                return this.method_125(BookmarkStart.b("帱崳堵崷椹䠻䜽ⰿ❁", num), BookmarkStart.b("1", num));

            case TextBoxLineStyle.ThinThick:
                return this.method_125(BookmarkStart.b("帱崳堵崷椹䠻䜽ⰿ❁", num), BookmarkStart.b("ı", num));

            case TextBoxLineStyle.Triple:
                return this.method_125(BookmarkStart.b("帱崳堵崷椹䠻䜽ⰿ❁", num), BookmarkStart.b("ر", num));
        }
        return this.method_125(BookmarkStart.b("帱崳堵崷椹䠻䜽ⰿ❁", num), BookmarkStart.b("ȱ", num));
    }

    private Class1083 method_134(Color A_0, LineDashing A_1, float A_2)
    {
        int num = 0x13;
        Class1083 class2 = new Class1083();
        if (!A_0.IsEmpty && (A_0.Name != Color.Black.Name))
        {
            class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾ɀⱂ⥄⡆㭈", num), this.method_169(A_0)));
        }
        switch (A_1)
        {
            case LineDashing.Solid:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("स", num)));
                break;

            case LineDashing.Dash:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("࠸", num)));
                break;

            case LineDashing.Dot:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("ସ", num)));
                break;

            case LineDashing.DashDot:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("ਸ", num)));
                break;

            case LineDashing.DashDotDot:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("സ", num)));
                break;

            case LineDashing.DotGEL:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("༸", num)));
                break;

            case LineDashing.DashGEL:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("ุ", num)));
                break;

            case LineDashing.LongDashGEL:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("ĸ", num)));
                break;

            case LineDashing.DashDotGEL:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("࠸଺", num)));
                break;

            case LineDashing.LongDashDotGEL:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("8", num)));
                break;

            case LineDashing.LongDashDotDotGEL:
                class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾Հ≂㙄⽆⁈╊⩌", num), BookmarkStart.b("࠸਺", num)));
                break;
        }
        float num2 = A_2 * 12700f;
        class2.method_1(this.method_125(BookmarkStart.b("唸刺匼娾ᙀ⩂⅄㍆ⅈ", num), num2.ToString()));
        return class2;
    }

    private Class1083 method_135(Background A_0)
    {
        float num2;
        int num = 10;
        Class1083 class2 = new Class1083();
        switch (A_0.Type)
        {
            case BackgroundType.Gradient:
                switch (A_0.Gradient.ShadingStyle)
                {
                    case GradientShadingStyle.Horizontal:
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("ܯ", num)));
                        class2.method_1(this.method_136(A_0.Gradient.ShadingVariant));
                        goto Label_044D;

                    case GradientShadingStyle.Vertical:
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("ܯ", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵礷吹嬻刽┿", num), BookmarkStart.b("ᴯܱళ༵7࠹࠻฽", num)));
                        class2.method_1(this.method_136(A_0.Gradient.ShadingVariant));
                        goto Label_044D;

                    case GradientShadingStyle.DiagonalUp:
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("ܯ", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵礷吹嬻刽┿", num), BookmarkStart.b("ᴯ਱ళȵ༷ह਻฽", num)));
                        class2.method_1(this.method_136(A_0.Gradient.ShadingVariant));
                        goto Label_044D;

                    case GradientShadingStyle.DiagonalDown:
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("ܯ", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵礷吹嬻刽┿", num), BookmarkStart.b("ᴯ1ളȵķହ฻฽", num)));
                        class2.method_1(this.method_136(A_0.Gradient.ShadingVariant));
                        goto Label_044D;

                    case GradientShadingStyle.FromCorner:
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("ԯ", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵縷唹弻䬽㌿", num), BookmarkStart.b("įȱг", num)));
                        if (A_0.Gradient.ShadingVariant == GradientShadingVariant.ShadingDown)
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹瀻嬽☿㙁", num), BookmarkStart.b("دܱĳԵื", num)));
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹渻圽✿⩁ぃ", num), BookmarkStart.b("دܱĳԵื", num)));
                        }
                        else if (A_0.Gradient.ShadingVariant == GradientShadingVariant.ShadingMiddle)
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹瀻嬽☿㙁", num), BookmarkStart.b("دܱĳԵื", num)));
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹栻儽〿", num), BookmarkStart.b("دܱĳԵื", num)));
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹渻圽✿⩁ぃ", num), BookmarkStart.b("دܱĳԵื", num)));
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹縻儽㐿㙁⭃⭅", num), BookmarkStart.b("دܱĳԵื", num)));
                        }
                        else if (A_0.Gradient.ShadingVariant == GradientShadingVariant.ShadingOut)
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹栻儽〿", num), BookmarkStart.b("دܱĳԵื", num)));
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹縻儽㐿㙁⭃⭅", num), BookmarkStart.b("دܱĳԵื", num)));
                        }
                        goto Label_044D;

                    case GradientShadingStyle.FromCenter:
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("د", num)));
                        if (A_0.Gradient.ShadingVariant == GradientShadingVariant.ShadingUp)
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵縷唹弻䬽㌿", num), BookmarkStart.b("įȱг", num)));
                        }
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹瀻嬽☿㙁", num), BookmarkStart.b("̯1̳57", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹渻圽✿⩁ぃ", num), BookmarkStart.b("̯1̳57", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹栻儽〿", num), BookmarkStart.b("̯1̳57", num)));
                        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷唹縻儽㐿㙁⭃⭅", num), BookmarkStart.b("̯1̳57", num)));
                        goto Label_044D;
                }
                break;

            case BackgroundType.Picture:
            case BackgroundType.Texture:
                if (A_0.Type != BackgroundType.Picture)
                {
                    class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("ȯ", num)));
                }
                else
                {
                    class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵氷䌹䰻嬽", num), BookmarkStart.b("̯", num)));
                }
                if (A_0.Picture != null)
                {
                    DocPicture picture = new DocPicture(this.document_0);
                    picture.LoadImage(A_0.Picture);
                    class2.method_0(this.method_126(BookmarkStart.b("嘯嬱堳娵稷嘹唻丽", num), this.method_112(picture)));
                }
                goto Label_05A3;

            case BackgroundType.Color:
                if (A_0.Color.IsEmpty || (A_0.Color.Name == Color.White.Name))
                {
                    class2.method_1(string.Empty);
                }
                else
                {
                    class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵笷唹倻儽㈿", num), this.method_169(A_0.Color)));
                }
                goto Label_05A3;

            default:
                class2.method_1(string.Empty);
                return class2;
        }
    Label_044D:
        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵笷唹倻儽㈿", num), this.method_169(A_0.Gradient.Color1)));
        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵稷嬹弻唽̿ⵁ⡃⥅㩇", num), this.method_169(A_0.Gradient.Color2)));
    Label_05A3:
        num2 = A_0.Opacity * 65536f;
        class2.method_1(this.method_125(BookmarkStart.b("嘯嬱堳娵眷䨹崻崽⤿㙁㵃", num), num2.ToString()));
        return class2;
    }

    private string method_136(GradientShadingVariant A_0)
    {
        int num = 8;
        switch (A_0)
        {
            case GradientShadingVariant.ShadingUp:
                return this.method_125(BookmarkStart.b("䠭夯帱堳瀵圷夹䤻䴽", num), BookmarkStart.b("Ἥ/ȱ", num));

            case GradientShadingVariant.ShadingOut:
                return this.method_125(BookmarkStart.b("䠭夯帱堳瀵圷夹䤻䴽", num), BookmarkStart.b("̭ԯȱ", num));

            case GradientShadingVariant.ShadingMiddle:
                return this.method_125(BookmarkStart.b("䠭夯帱堳瀵圷夹䤻䴽", num), BookmarkStart.b("ᬭ/", num));
        }
        return string.Empty;
    }

    private void method_137()
    {
        int num = 15;
        ListStyleCollection listStyles = this.document_0.ListStyles;
        if (listStyles.Count != 0)
        {
            this.method_10().method_3(BookmarkStart.b("临", num) + this.string_24 + BookmarkStart.b("ἴ", num) + this.string_24 + BookmarkStart.b("头帶䨸伺䤼帾⍀⽂⁄", num));
            int num3 = 0;
            int count = listStyles.Count;
            while (num3 < count)
            {
                ListStyle style = listStyles[num3];
                this.method_10().method_3(Environment.NewLine);
                this.method_10().method_3(BookmarkStart.b("临", num) + this.string_24 + BookmarkStart.b("头帶䨸伺", num));
                if (style.IsSimple)
                {
                    this.method_10().method_3(this.string_24 + BookmarkStart.b("头帶䨸伺丼嘾ⱀ㍂⥄≆硈", num));
                }
                else
                {
                    this.method_10().method_3(this.string_24 + BookmarkStart.b("头帶䨸伺丼嘾ⱀ㍂⥄≆祈", num));
                }
                if (style.IsHybrid)
                {
                    this.method_10().method_3(this.string_24 + BookmarkStart.b("头帶䨸伺唼䘾⍀ㅂⱄ⍆", num));
                }
                int num2 = 0;
                int num5 = style.Levels.Count;
                while (num2 < num5)
                {
                    ListLevel level = style.Levels[num2];
                    this.method_10().method_6(this.method_138(level));
                    num2++;
                }
                this.method_10().method_3(BookmarkStart.b("临", num) + this.string_24 + BookmarkStart.b("头帶䨸伺匼帾ⱀ♂敄", num));
                this.method_10().method_3(style.Name);
                this.method_10().method_3(BookmarkStart.b("ᔴశ䐸", num));
                this.method_10().method_3(this.string_24 + BookmarkStart.b("头帶䨸伺吼嬾", num) + num3.ToString());
                this.method_10().method_3(Environment.NewLine);
                this.method_10().method_3(BookmarkStart.b("䠴", num));
                this.method_12().Add(style.Name, num3);
                num3++;
            }
            this.method_10().method_3(BookmarkStart.b("䠴", num));
        }
    }

    private Class1082 method_138(ListLevel A_0)
    {
        int num = 6;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("圫", 6) + this.string_24 + BookmarkStart.b("䀫䜭䌯䘱堳匵丷弹倻", 6));
        class2.method_3(this.method_145(A_0.PatternType));
        if (A_0.NumberAlignment == ListNumberAlignment.Left)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳尵嬷ਹ", num) + this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳尵嬷吹఻", num));
        }
        else if (A_0.NumberAlignment == ListNumberAlignment.Center)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳尵嬷ହ", num) + this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳尵嬷吹഻", num));
        }
        else if (A_0.NumberAlignment == ListNumberAlignment.Right)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳尵嬷࠹", num) + this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳尵嬷吹฻", num));
        }
        if (A_0.FollowCharacter == FollowCharacterType.Tab)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳倵圷嘹倻儽㜿牁", num));
        }
        else if (A_0.FollowCharacter == FollowCharacterType.Space)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳倵圷嘹倻儽㜿獁", num));
        }
        else
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳倵圷嘹倻儽㜿灁", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳䔵䰷嬹主䨽ℿ㙁", num));
        class2.method_3(A_0.StartAt.ToString());
        class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳䔵䠷嬹弻嬽", num));
        class2.method_4(A_0.LegacySpace);
        class2.method_3(this.string_24 + BookmarkStart.b("䀫䬭䘯圱堳張嘷帹夻倽㐿", num));
        class2.method_4(A_0.LegacyIndent);
        class2.method_6(this.method_140(A_0));
        class2.method_2(this.method_142(A_0));
        class2.method_6(this.method_40(A_0.ParagraphFormat, null));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("儫", num));
        class2.method_3(Environment.NewLine);
        return class2;
    }

    private string method_139(string A_0)
    {
        string str = A_0;
        return str.Replace(BookmarkStart.b("㐳", 14), this.string_24 + BookmarkStart.b("ጳص࠷", 14)).Replace(BookmarkStart.b("㔳", 14), this.string_24 + BookmarkStart.b("ጳصष", 14)).Replace(BookmarkStart.b("㘳", 14), this.string_24 + BookmarkStart.b("ጳص਷", 14)).Replace(BookmarkStart.b("㜳", 14), this.string_24 + BookmarkStart.b("ጳصଷ", 14)).Replace(BookmarkStart.b("〳", 14), this.string_24 + BookmarkStart.b("ጳصష", 14)).Replace(BookmarkStart.b("ㄳ", 14), this.string_24 + BookmarkStart.b("ጳصഷ", 14)).Replace(BookmarkStart.b("㈳", 14), this.string_24 + BookmarkStart.b("ጳصื", 14)).Replace(BookmarkStart.b("㌳", 14), this.string_24 + BookmarkStart.b("ጳص༷", 14)).Replace(BookmarkStart.b("㰳", 14), this.string_24 + BookmarkStart.b("ጳص7", 14));
    }

    private Dictionary<string, string> method_14()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, string>();
        }
        return this.dictionary_0;
    }

    private Class1082 method_140(ListLevel A_0)
    {
        int num = 0x13;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("䈸", 0x13) + this.string_24 + BookmarkStart.b("唸帺䬼娾ⵀ㝂⁄㽆㵈", 0x13));
        if ((A_0.PatternType == ListPatternType.Bullet) && !string.IsNullOrEmpty(A_0.BulletCharacter))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("Ḹ଺఼", num));
            string bulletCharacter = A_0.BulletCharacter;
            if (this.method_152(ref bulletCharacter))
            {
                class2.method_3(bulletCharacter);
            }
            else
            {
                byte num2 = (byte) A_0.BulletCharacter[0];
                string str3 = A_0.CharacterFormat.FontName.ToLower(CultureInfo.InvariantCulture);
                if ((!str3.Equals(BookmarkStart.b("樸䈺值崾⹀⽂", num)) && !str3.StartsWith(BookmarkStart.b("丸刺匼堾╀⩂⭄⁆㩈", num))) && (((num2 > 0x40) && (num2 < 0x5b)) || ((num2 > 0x60) && (num2 < 0x7b))))
                {
                    class2.method_3(A_0.BulletCharacter[0].ToString());
                }
                else
                {
                    class2.method_3(this.string_24 + BookmarkStart.b("䰸ᘺ", num) + ((0x1000 - num2)).ToString() + BookmarkStart.b("ᤸк", num));
                }
            }
        }
        else
        {
            string str2 = this.method_144(A_0);
            class2.method_3(this.string_24 + BookmarkStart.b("Ḹ", num) + this.method_143(str2).ToString(BookmarkStart.b("愸ऺ", num)) + str2);
        }
        class2.method_3(BookmarkStart.b("ȸ䘺", num));
        return class2;
    }

    private Class1082 method_141(ListLevel A_0, string A_1)
    {
        int num = 0;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("崥", 0) + this.string_24 + BookmarkStart.b("䨥䄧天堫娭唯䨱䀳", 0));
        class2.method_6(this.method_40(A_0.ParagraphFormat, null));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("إ", 0));
        if ((A_0.PatternType == ListPatternType.Bullet) && !string.IsNullOrEmpty(A_1))
        {
            string str = A_1;
            if (this.method_152(ref str))
            {
                class2.method_3(str);
            }
            else
            {
                byte num2 = (byte) A_1[0];
                string str2 = A_0.CharacterFormat.FontName.ToLower(CultureInfo.InvariantCulture);
                if ((!str2.Equals(BookmarkStart.b("甥儧䜩丫䄭尯", num)) && !str2.StartsWith(BookmarkStart.b("儥䄧䐩䬫䨭夯就匳䔵", num))) && (((num2 > 0x40) && (num2 < 0x5b)) || ((num2 > 0x60) && (num2 < 0x7b))))
                {
                    class2.method_3(A_1);
                }
                else
                {
                    int num3 = 0x1000 - num2;
                    class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("匥䬧ᠩ", num) + this.string_24 + BookmarkStart.b("匥ԧ", num) + num3.ToString() + BookmarkStart.b("إᜧ圩", num));
                }
            }
        }
        else
        {
            class2.method_3(A_1);
        }
        class2.method_3(this.string_24 + BookmarkStart.b("別䤧䠩儫", num));
        return class2;
    }

    private Class1083 method_142(ListLevel A_0)
    {
        int num = 13;
        Class1083 class2 = new Class1083();
        string str = this.method_144(A_0);
        class2.method_1(BookmarkStart.b("䠲", 13) + this.string_24 + BookmarkStart.b("弲倴䄶尸场匼䨾ⱀ⅂⁄㕆㩈", 13));
        if ((A_0.PatternType != ListPatternType.Bullet) && (str != string.Empty))
        {
            str = str.Trim();
            int num6 = this.method_143(str);
            if (!string.IsNullOrEmpty(A_0.NumberPrefix))
            {
                string[] strArray2 = str.Split(new string[] { BookmarkStart.b("漲ሴܶ", num) }, StringSplitOptions.None);
                int num5 = 1;
                int index = 0;
                int length = strArray2.Length;
                while (index < (length - 1))
                {
                    int num7 = strArray2[index].Length;
                    class2.method_1(this.string_24 + BookmarkStart.b("ᐲ", num) + ((num5 + num7)).ToString(BookmarkStart.b("欲ܴ", num)));
                    index++;
                }
            }
            else
            {
                for (int i = 1; i <= num6; i += 2)
                {
                    class2.method_1(this.string_24 + BookmarkStart.b("ᐲ", num) + i.ToString(BookmarkStart.b("欲ܴ", num)));
                }
            }
        }
        class2.method_1(BookmarkStart.b("࠲䠴", num));
        return class2;
    }

    private int method_143(string A_0)
    {
        A_0 = A_0.Replace(this.string_24 + BookmarkStart.b("ᄵ࠷", 0x10), string.Empty);
        return A_0.Length;
    }

    private string method_144(ListLevel A_0)
    {
        int num = 11;
        string numberPrefix = A_0.NumberPrefix;
        if (!string.IsNullOrEmpty(numberPrefix))
        {
            numberPrefix = this.method_139(A_0.NumberPrefix);
        }
        return (numberPrefix + this.string_24 + BookmarkStart.b("ᘰ̲", num) + A_0.LevelNumber.ToString() + A_0.NumberSufix);
    }

    private string method_145(ListPatternType A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case ListPatternType.Arabic:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁瑃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃癅", num));

            case ListPatternType.UpRoman:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁畃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃睅", num));

            case ListPatternType.LowRoman:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁癃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃瑅", num));

            case ListPatternType.UpLetter:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁睃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃畅", num));

            case ListPatternType.LowLetter:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁灃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃牅", num));

            case ListPatternType.Ordinal:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁煃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃獅", num));

            case ListPatternType.CardinalText:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁牃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃灅", num));

            case ListPatternType.OrdinalText:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁獃", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃煅", num));

            case ListPatternType.LeadingZero:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁癃瑅", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃瑅穇", num));

            case ListPatternType.Bullet:
                return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁癃畅", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃瑅筇", num));
        }
        return (this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁癃獅絇", num) + this.string_24 + BookmarkStart.b("堳匵丷弹倻倽☿⅁⩃瑅絇罉", num));
    }

    private void method_146()
    {
        int num = 4;
        this.method_11().method_3(BookmarkStart.b("儩", 4) + this.string_24 + BookmarkStart.b(")", 4) + this.string_24 + BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿㙁╃⑅⑇⽉", 4));
        foreach (int num2 in this.method_13().Keys)
        {
            this.method_11().method_3(Environment.NewLine);
            this.method_11().method_3(BookmarkStart.b("儩", num) + this.string_24 + BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿", num));
            int num3 = num2 - 1;
            this.method_11().method_3(this.string_24 + BookmarkStart.b("䘩䔫崭䐯嬱倳", num) + num3.ToString());
            string str = this.method_13()[num2];
            if (!string.IsNullOrEmpty(str))
            {
                Class12 class2 = this.document_0.ListOverrides.method_35(str);
                this.method_11().method_3(this.string_24 + BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿⅁⭃㍅♇㹉", num) + class2.method_23().Count);
                foreach (OverrideLevelFormat format in class2.method_23())
                {
                    this.method_11().method_3(BookmarkStart.b("儩", num) + this.string_24 + BookmarkStart.b("䘩䨫䄭尯圱䈳匵吷", num));
                    if (format.OverrideFormatting)
                    {
                        this.method_11().method_3(this.string_24 + BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿⑁⭃㑅╇⭉㡋", num));
                        this.method_11().method_6(this.method_138(format.OverrideListLevel));
                    }
                    if (format.OverrideStartAtValue)
                    {
                        this.method_11().method_3(this.string_24 + BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿ㅁぃ❅㩇㹉", num));
                        this.method_11().method_3(format.StartAt.ToString());
                    }
                    this.method_11().method_3(BookmarkStart.b("圩", num));
                }
            }
            else
            {
                this.method_11().method_3(this.string_24 + BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿⅁⭃㍅♇㹉籋", num));
            }
            this.method_11().method_3(this.string_24 + BookmarkStart.b("䘩弫", num) + num2.ToString());
            this.method_11().method_3(BookmarkStart.b("圩", num));
        }
        this.method_11().method_3(BookmarkStart.b("圩", num));
        this.method_11().method_3(Environment.NewLine);
    }

    private Class1082 method_147(ListFormat A_0, string A_1)
    {
        if ((A_0.ListType != ListType.NoList) && !string.IsNullOrEmpty(A_1))
        {
            ListLevel currentListLevel = A_0.CurrentListLevel;
            if (!string.IsNullOrEmpty(A_0.LFOStyleName))
            {
                int listLevelNumber = A_0.ListLevelNumber;
                Class12 class2 = this.document_0.ListOverrides.method_35(A_0.LFOStyleName);
                if (((class2 != null) && class2.method_23().method_11(listLevelNumber)) && class2.method_23().method_5(listLevelNumber).OverrideFormatting)
                {
                    currentListLevel = class2.method_23().method_5(listLevelNumber).OverrideListLevel;
                }
            }
            return this.method_141(currentListLevel, A_1);
        }
        Class1082 class3 = new Class1082();
        class3.method_3(string.Empty);
        return class3;
    }

    private Class1082 method_148(ListFormat A_0)
    {
        int num = 10;
        Class1082 class2 = new Class1082();
        if (A_0.ListType == ListType.NoList)
        {
            class2.method_3(string.Empty);
            return class2;
        }
        ListLevel currentListLevel = A_0.CurrentListLevel;
        if (!string.IsNullOrEmpty(A_0.LFOStyleName))
        {
            Class12 class3 = this.document_0.ListOverrides.method_35(A_0.LFOStyleName);
            if (class3 != null)
            {
                currentListLevel = class3.method_23().method_5(A_0.ListLevelNumber).OverrideListLevel;
            }
        }
        class2.method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("尯嬱䜳䈵䰷弹䐻䨽", num));
        class2.method_6(this.method_40(currentListLevel.ParagraphFormat, null));
        class2.method_2(this.method_37(currentListLevel.CharacterFormat));
        class2.method_3(BookmarkStart.b("ု", num));
        class2.method_3(this.method_149(currentListLevel, A_0));
        class2.method_3(this.string_24 + BookmarkStart.b("䐯匱嘳䬵", num));
        class2.method_3(Environment.NewLine);
        return class2;
    }

    private string method_149(ListLevel A_0, ListFormat A_1)
    {
        int num = 2;
        if ((A_0 != null) || (A_1 != null))
        {
            if ((A_0.PatternType == ListPatternType.Bullet) && !string.IsNullOrEmpty(A_0.BulletCharacter))
            {
                byte num2 = (byte) A_0.BulletCharacter[0];
                return (this.string_24 + BookmarkStart.b("༧", num) + num2.ToString(BookmarkStart.b("瀧ᠩ", num)));
            }
            if ((A_0.PatternType == ListPatternType.LowLetter) || (A_0.PatternType == ListPatternType.UpLetter))
            {
                return this.method_151(A_1).ToString();
            }
            if ((A_0.PatternType == ListPatternType.Arabic) && !this.method_153(A_0.NumberPrefix))
            {
                return (A_0.NumberPrefix + this.method_150(A_1) + A_0.NumberSufix);
            }
        }
        return string.Empty;
    }

    private Dictionary<string, string> method_15()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<string, string>();
        }
        return this.dictionary_1;
    }

    private int method_150(ListFormat A_0)
    {
        if (!this.method_17().ContainsKey(A_0.CustomStyleName))
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            this.method_17().Add(A_0.CustomStyleName, dictionary);
            ListLevel level = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
            dictionary.Add(A_0.ListLevelNumber, level.StartAt + 1);
            return level.StartAt;
        }
        Dictionary<int, int> dictionary2 = this.method_17()[A_0.CustomStyleName];
        if (dictionary2.ContainsKey(A_0.ListLevelNumber))
        {
            int num = dictionary2[A_0.ListLevelNumber];
            dictionary2[A_0.ListLevelNumber] = num + 1;
            return num;
        }
        ListLevel level2 = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
        dictionary2.Add(A_0.ListLevelNumber, level2.StartAt + 1);
        return (level2.StartAt + 1);
    }

    private Class1083 method_151(ListFormat A_0)
    {
        int num2 = (A_0.CurrentListLevel.PatternType == ListPatternType.LowLetter) ? 0x60 : 0x40;
        Class1083 class2 = new Class1083();
        class2.method_1(A_0.CurrentListLevel.NumberPrefix);
        int num = this.method_150(A_0);
        int num5 = 1;
        while (num > 0x1a)
        {
            num -= 0x1a;
            num5++;
        }
        int num3 = num + num2;
        string str = ((char) num3).ToString();
        for (int i = 0; i < num5; i++)
        {
            class2.method_1(str);
        }
        class2.method_1(A_0.CurrentListLevel.NumberSufix);
        return class2;
    }

    private bool method_152(ref string A_0)
    {
        string str = A_0;
        A_0 = A_0.Replace(this.string_25, this.string_24 + BookmarkStart.b("ḸȺ࠼", 0x13));
        if (str == A_0)
        {
            return false;
        }
        return true;
    }

    private bool method_153(string A_0)
    {
        int num = 13;
        return (string.IsNullOrEmpty(A_0) || (A_0.Contains(BookmarkStart.b("㌲", num)) || (A_0.Contains(BookmarkStart.b("㈲", num)) || (A_0.Contains(BookmarkStart.b("ㄲ", num)) || (A_0.Contains(BookmarkStart.b("〲", num)) || (A_0.Contains(BookmarkStart.b("㜲", num)) || (A_0.Contains(BookmarkStart.b("㘲", num)) || (A_0.Contains(BookmarkStart.b("㔲", num)) || (A_0.Contains(BookmarkStart.b("㐲", num)) || A_0.Contains(BookmarkStart.b("㬲", num)))))))))));
    }

    private Class1083 method_154()
    {
        int num = 11;
        Class1083 class2 = new Class1083();
        WatermarkBase watermark = this.document_0.Watermark;
        if (watermark.Type == WatermarkType.NoWatermark)
        {
            return class2.method_1(string.Empty);
        }
        string str = string.Empty;
        if (watermark.Type == WatermarkType.TextWatermark)
        {
            str = this.method_156(watermark as TextWatermark);
        }
        else
        {
            str = this.method_155(watermark as PictureWatermark);
        }
        class2.method_1(BookmarkStart.b("䨰", num) + this.string_24 + BookmarkStart.b("夰嘲吴匶尸䤺儼", num));
        class2.method_1(str);
        class2.method_1(BookmarkStart.b("䰰", num));
        class2.method_1(Environment.NewLine);
        class2.method_1(BookmarkStart.b("䨰", num) + this.string_24 + BookmarkStart.b("夰嘲吴匶尸䤺似", num));
        class2.method_1(str);
        class2.method_1(BookmarkStart.b("䰰", num));
        class2.method_1(Environment.NewLine);
        class2.method_1(BookmarkStart.b("䨰", num) + this.string_24 + BookmarkStart.b("夰嘲吴匶尸䤺嬼", num));
        class2.method_1(str);
        class2.method_1(BookmarkStart.b("䰰", num));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private string method_155(PictureWatermark A_0)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("嘬", 7) + this.string_24 + BookmarkStart.b("帬䜮䄰", 7));
        class2.method_1(BookmarkStart.b("嘬", 7) + this.string_24 + BookmarkStart.b("ܬ", 7) + this.string_24 + BookmarkStart.b("帬䜮䄰娲嬴䐶䴸", 7));
        class2.method_1(this.string_24 + BookmarkStart.b("帬䜮䄰弲倴儶䴸଺", 7));
        class2.method_1(this.string_24 + BookmarkStart.b("帬䜮䄰䜲娴䜶स", 7));
        class2.method_1(this.string_24 + BookmarkStart.b("帬䜮䄰䐲䜴ж", 7));
        class2.method_1(this.string_24 + BookmarkStart.b("帬䜮䄰䄲尴倶儸伺", 7));
        class2.method_5(A_0.WordPicture.Width * 20f);
        class2.method_1(this.string_24 + BookmarkStart.b("帬䜮䄰儲娴䌶䴸吺值", 7));
        class2.method_5(A_0.WordPicture.Height * 20f);
        class2.method_1(Environment.NewLine);
        class2.method_1(this.method_125(BookmarkStart.b("帬䜮倰䌲倴挶䀸䬺堼", 7), BookmarkStart.b("ᨬᨮ", 7)));
        class2.method_0(this.method_126(BookmarkStart.b("崬䘮匰", 7), this.method_117(A_0.WordPicture)));
        class2.method_0(this.method_157());
        class2.method_1(BookmarkStart.b("倬刮", 7));
        return class2.ToString();
    }

    private string method_156(TextWatermark A_0)
    {
        int num = 15;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("临", 15) + this.string_24 + BookmarkStart.b("䘴弶䤸", 15));
        class2.method_1(BookmarkStart.b("临", 15) + this.string_24 + BookmarkStart.b("ἴ", 15) + this.string_24 + BookmarkStart.b("䘴弶䤸刺匼䰾㕀", 15));
        class2.method_1(this.string_24 + BookmarkStart.b("䘴弶䤸场堼夾㕀獂", 15));
        class2.method_1(this.string_24 + BookmarkStart.b("䘴弶䤸伺刼伾煀", 15));
        class2.method_1(this.string_24 + BookmarkStart.b("䘴弶䤸䤺吼堾⥀㝂", 15));
        class2.method_4(A_0.ShapeWidthInPixels);
        class2.method_1(this.string_24 + BookmarkStart.b("䘴弶䤸夺刼䬾㕀ⱂ⡄", 15));
        class2.method_4(A_0.ShapeHeightInPixels);
        class2.method_1(this.string_24 + BookmarkStart.b("䘴弶䤸䰺似ా", 15));
        class2.method_1(Environment.NewLine);
        class2.method_1(this.method_125(BookmarkStart.b("䘴弶堸䬺堼款㡀㍂⁄", 15), BookmarkStart.b("дж༸", 15)));
        if (A_0.Layout == WatermarkLayout.Diagonal)
        {
            class2.method_1(this.method_125(BookmarkStart.b("䜴堶䴸娺䤼嘾⹀ⵂ", num), BookmarkStart.b("ܴܶ༸༺฼ܾ畀獂", num)));
        }
        class2.method_1(this.method_125(BookmarkStart.b("刴䌶尸䌺䤼樾ཀੂلࡆൈ๊", num), A_0.Text));
        int num2 = (int) Math.Round((double) (A_0.FontSize * 65536f));
        class2.method_1(this.method_125(BookmarkStart.b("刴䌶尸䌺䤼氾⡀㥂⁄", num), num2.ToString()));
        class2.method_1(this.method_125(BookmarkStart.b("刴䌶尸䌺䤼社⹀ⵂㅄ", num), A_0.FontName));
        class2.method_1(this.method_125(BookmarkStart.b("匴帶唸场縼倾ⵀⱂ㝄", num), this.method_169(A_0.Color)));
        if (A_0.Semitransparent)
        {
            class2.method_1(this.method_125(BookmarkStart.b("匴帶唸场爼伾⁀⁂ⱄ㍆え", num), BookmarkStart.b("شԶุഺԼ", num)));
        }
        class2.method_0(this.method_157());
        class2.method_1(BookmarkStart.b("䠴䨶", num));
        return class2.ToString();
    }

    private Class1083 method_157()
    {
        Class1083 class2 = new Class1083();
        class2.method_1(this.method_125(BookmarkStart.b("䬬挮堰崲倴", 7), BookmarkStart.b("ᴬ", 7)));
        class2.method_1(this.method_125(BookmarkStart.b("崬䀮䈰嬲", 7), BookmarkStart.b("Ἤ", 7)));
        class2.method_1(this.method_125(BookmarkStart.b("崬䀮䈰䄲倴嬶儸", 7), BookmarkStart.b("ᴬ", 7)));
        class2.method_1(this.method_125(BookmarkStart.b("崬䀮䈰䔲", 7), BookmarkStart.b("Ἤ", 7)));
        class2.method_1(this.method_125(BookmarkStart.b("崬䀮䈰䄲倴嬶伸", 7), BookmarkStart.b("ᴬ", 7)));
        return class2;
    }

    private Class1082 method_158(TextFormField A_0)
    {
        int num = 10;
        this.method_19().Push(A_0);
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("嘯嬱儳娵尷", 10));
        if (A_0.IsLocked)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯帱倳娵圷夹圻", num));
        }
        class2.method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("ᨯ", num) + this.string_24 + BookmarkStart.b("嘯帱倳張嘷䤹䠻ḽ㬿", num));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("ု", num));
        class2.method_3(this.method_168(A_0.Type));
        class2.method_3(BookmarkStart.b("䴯", num));
        if (!(A_0.NextSibling is Field))
        {
            class2.method_6(this.method_159(A_0));
        }
        return class2;
    }

    private Class1082 method_159(TextFormField A_0)
    {
        int num = 0x12;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("䌷", 0x12) + this.string_24 + BookmarkStart.b("ሷ", 0x12) + this.string_24 + BookmarkStart.b("帷唹主匽☿⭁⅃⩅ⱇ", 0x12));
        class2.method_3(BookmarkStart.b("䌷", 0x12) + this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁瑃", 0x12));
        switch (A_0.TextFieldType)
        {
            case TextFormFieldType.RegularText:
                class2.method_3(this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁ぃ㹅㱇穉", num));
                break;

            case TextFormFieldType.NumberText:
                class2.method_3(this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁ぃ㹅㱇等", num));
                break;

            case TextFormFieldType.DateText:
                class2.method_3(this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁ぃ㹅㱇硉", num));
                break;

            case TextFormFieldType.CurrentDate:
                class2.method_3(this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁ぃ㹅㱇祉", num));
                break;

            case TextFormFieldType.CurrentTime:
                class2.method_3(this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁ぃ㹅㱇繉", num));
                break;

            case TextFormFieldType.Calculation:
                class2.method_3(this.string_24 + BookmarkStart.b("帷尹䠻䜽〿❁ぃ㹅㱇罉", num));
                break;
        }
        if (A_0.CalculateOnExit)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("帷尹主嬽⌿⍁⡃╅", num));
        }
        if (A_0.MaximumLength != 0)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("帷尹儻弽㠿⹁⅃⡅", num) + A_0.MaximumLength.ToString());
        }
        class2.method_3(this.string_24 + BookmarkStart.b("帷尹吻丽㌿灁瑃", num));
        if (!string.IsNullOrEmpty(A_0.Name))
        {
            class2.method_3(BookmarkStart.b("䌷", num) + this.string_24 + BookmarkStart.b("帷尹刻弽ⴿ❁摃", num));
            class2.method_3(this.method_184(A_0.Name) + BookmarkStart.b("䔷", num));
        }
        if (!string.IsNullOrEmpty(A_0.DefaultText))
        {
            class2.method_3(BookmarkStart.b("䌷", num) + this.string_24 + BookmarkStart.b("帷尹堻嬽☿㙁⅃㹅㱇橉", num));
            class2.method_3(this.method_184(A_0.DefaultText) + BookmarkStart.b("䔷", num));
        }
        if (A_0.TextFormat == TextFormat.None)
        {
            if (!string.IsNullOrEmpty(A_0.StringFormat))
            {
                class2.method_3(BookmarkStart.b("䌷", num) + this.string_24 + BookmarkStart.b("帷尹娻儽㈿⽁╃㉅桇", num));
                class2.method_3(this.method_184(A_0.StringFormat));
                class2.method_3(BookmarkStart.b("䔷", num));
            }
        }
        else
        {
            class2.method_3(BookmarkStart.b("䌷", num) + this.string_24 + BookmarkStart.b("帷尹娻儽㈿⽁╃㉅桇", num));
            switch (A_0.TextFormat)
            {
                case TextFormat.Uppercase:
                    class2.method_3(BookmarkStart.b("洷䨹䰻嬽㈿⅁╃㕅ⵇ", num));
                    break;

                case TextFormat.Lowercase:
                    class2.method_3(BookmarkStart.b("琷唹䬻嬽㈿⅁╃㕅ⵇ", num));
                    break;

                case TextFormat.FirstCapital:
                    class2.method_3(BookmarkStart.b("縷匹主䴽㐿Ł╃㙅ⅇ㹉ⵋ≍", num));
                    break;

                case TextFormat.Titlecase:
                    class2.method_3(BookmarkStart.b("氷匹䠻刽┿⅁╃㕅ⵇ", num));
                    break;
            }
            class2.method_3(BookmarkStart.b("䔷", num));
        }
        class2.method_3(BookmarkStart.b("䔷", num));
        return class2;
    }

    private Dictionary<string, string> method_16()
    {
        if (this.dictionary_2 == null)
        {
            this.dictionary_2 = new Dictionary<string, string>();
        }
        return this.dictionary_2;
    }

    private Class1082 method_160(CheckBoxFormField A_0)
    {
        int num = 10;
        this.method_19().Push(A_0);
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("嘯嬱儳娵尷", 10));
        if (A_0.IsLocked)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯帱倳娵圷夹圻", num));
        }
        class2.method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("ᨯ", num) + this.string_24 + BookmarkStart.b("嘯帱倳張嘷䤹䠻ḽ㬿", num));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("ု", num));
        class2.method_3(this.method_168(A_0.Type));
        class2.method_3(BookmarkStart.b("䴯", num));
        class2.method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("嘯崱䘳嬵帷匹夻刽␿", num));
        class2.method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("嘯吱䀳伵䠷弹഻", num));
        class2.method_3(this.string_24 + BookmarkStart.b("嘯吱䘳匵䬷࠹ऻ", num));
        if (A_0.SizeType == CheckBoxSizeType.Auto)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯吱䜳張䈷弹఻", num));
        }
        else
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯吱䜳張䈷弹഻", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("嘯吱䀳伵䠷弹䠻䘽㐿牁", num));
        if (A_0.CalculateOnExit)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯吱䘳匵嬷嬹倻崽", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("嘯吱尳䘵䬷", num) + ((A_0.CheckBoxSize * 2)).ToString());
        if (!string.IsNullOrEmpty(A_0.Name))
        {
            class2.method_3(BookmarkStart.b("䬯", num) + this.string_24 + BookmarkStart.b("嘯吱娳圵唷弹᰻", num));
            class2.method_3(this.method_184(A_0.Name) + BookmarkStart.b("䴯", num));
        }
        if (A_0.Checked)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯吱倳匵帷䠹夻䴽焿", num));
        }
        else
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘯吱倳匵帷䠹夻䴽瀿", num));
        }
        class2.method_3(BookmarkStart.b("䴯", num));
        return class2;
    }

    private Class1082 method_161(DropDownFormField A_0)
    {
        int num = 2;
        this.method_19().Push(A_0);
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("匧", 2) + this.string_24 + BookmarkStart.b("丧䌩䤫䈭启", 2));
        if (A_0.IsLocked)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("丧䘩䠫䈭弯儱弳", num));
        }
        class2.method_3(BookmarkStart.b("匧", num) + this.string_24 + BookmarkStart.b("ȧ", num) + this.string_24 + BookmarkStart.b("丧䘩䠫䜭帯䄱䀳ᘵ䌷", num));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("ࠧ", num));
        class2.method_3(this.method_168(A_0.Type));
        class2.method_3(BookmarkStart.b("唧", num));
        class2.method_3(BookmarkStart.b("匧", num) + this.string_24 + BookmarkStart.b("丧䔩師䌭嘯嬱儳娵尷", num));
        class2.method_3(BookmarkStart.b("匧", num) + this.string_24 + BookmarkStart.b("丧䰩堫圭䀯圱س", num));
        class2.method_3(this.string_24 + BookmarkStart.b("丧䰩師䬭䌯1ĳ", num));
        class2.method_3(this.string_24 + BookmarkStart.b("丧䰩堫圭䀯圱䀳丵䰷ਹ", num));
        if (A_0.CalculateOnExit)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("丧䰩師䬭匯匱堳唵", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("丧䰩䐫伭䌯帱崳䔵䰷堹医䘽", num));
        class2.method_3(this.string_24 + BookmarkStart.b("丧䰩䐫席䌯1г", num));
        if (!string.IsNullOrEmpty(A_0.Name))
        {
            class2.method_3(BookmarkStart.b("匧", num) + this.string_24 + BookmarkStart.b("丧䰩䈫伭崯圱ᐳ", num));
            class2.method_3(this.method_184(A_0.Name) + BookmarkStart.b("唧", num));
        }
        class2.method_3(BookmarkStart.b("丧䰩䠫䬭嘯䀱儳䔵࠷", num));
        int num2 = 0;
        int count = A_0.DropDownItems.Count;
        while (num2 < count)
        {
            class2.method_3(BookmarkStart.b("匧", num) + this.string_24 + BookmarkStart.b("丧䰩䀫อ", num));
            class2.method_3(this.method_184(A_0.DropDownItems[num2].Text));
            class2.method_3(BookmarkStart.b("唧", num));
            num2++;
        }
        class2.method_3(BookmarkStart.b("唧", num));
        return class2;
    }

    private Class1082 method_162(CommentMark A_0)
    {
        int num = 9;
        Class1082 class2 = new Class1082();
        if (A_0.Type == CommentMarkType.CommentStart)
        {
            class2.method_3(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("Ԯ", num) + this.string_24 + BookmarkStart.b("丮䔰䄲匴䐶䴸娺似䬾慀", num));
            int num2 = this.method_174();
            class2.method_3(num2.ToString());
            this.method_18().Add(A_0.CommentId, num2);
        }
        else
        {
            class2.method_3(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("Ԯ", num) + this.string_24 + BookmarkStart.b("丮䔰䄲匴制圸强ᴼ", num));
            class2.method_3(this.method_18()[A_0.CommentId].ToString());
        }
        class2.method_3(BookmarkStart.b("刮", num));
        return class2;
    }

    private void method_163(Comment A_0)
    {
        int num = 1;
        Class1082 class2 = new Class1082();
        string s = null;
        if ((this.dictionary_6 != null) && this.method_18().ContainsKey(A_0.Format.CommentId))
        {
            s = this.method_18()[A_0.Format.CommentId].ToString();
        }
        if ((s == null) && (A_0.Items.Count != 0))
        {
            s = this.method_174().ToString();
        }
        if (A_0.AppendItems)
        {
            this.method_164(A_0, int.Parse(s));
        }
        class2.method_3(BookmarkStart.b("尦", num));
        if (!string.IsNullOrEmpty(A_0.Format.Initial))
        {
            class2.method_2(this.method_37(A_0.CharacterFormat));
            class2.method_3(BookmarkStart.b("尦", num) + this.string_24 + BookmarkStart.b("ദ", num) + this.string_24 + BookmarkStart.b("䘦崨䔪䐬䬮ᄰ", num));
            class2.method_3(A_0.Format.Initial);
            class2.method_3(BookmarkStart.b("娦", num));
        }
        if (!string.IsNullOrEmpty(A_0.Format.Author))
        {
            class2.method_3(BookmarkStart.b("尦", num) + this.string_24 + BookmarkStart.b("ദ", num) + this.string_24 + BookmarkStart.b("䘦崨䔪䰬娮䔰嬲娴䔶ᤸ", num));
            class2.method_3(A_0.Format.Author);
            class2.method_3(BookmarkStart.b("娦", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("䐦䄨䨪夬䄮ᄰ", num));
        class2.method_3(BookmarkStart.b("尦", num) + this.string_24 + BookmarkStart.b("ദ", num) + this.string_24 + BookmarkStart.b("䘦䜨䔪䈬嬮倰䜲尴堶圸", num));
        if (s != null)
        {
            class2.method_3(BookmarkStart.b("尦", num) + this.string_24 + BookmarkStart.b("ദ", num) + this.string_24 + BookmarkStart.b("䘦崨䔪弬䨮地ጲ", num));
            class2.method_3(s);
            class2.method_3(BookmarkStart.b("娦", num));
        }
        this.method_6().method_6(class2);
        this.method_31(A_0.Body.Items);
        this.method_6().method_3(BookmarkStart.b("娦吨", num));
    }

    private void method_164(Comment A_0, int A_1)
    {
        CommentMark mark = new CommentMark(A_0.Document, A_1, CommentMarkType.CommentStart);
        CommentMark mark2 = new CommentMark(A_0.Document, A_1, CommentMarkType.CommentEnd);
        this.method_6().method_6(this.method_162(mark));
        foreach (ParagraphBase base2 in A_0.Items)
        {
            this.method_85(base2);
        }
        this.method_6().method_6(this.method_162(mark2));
    }

    private string method_165(CharacterFormat A_0, Color A_1, CharacterFormat A_2, Color A_3, int A_4, string A_5)
    {
        if (A_0.HasValue(A_4))
        {
            if (A_1.IsNamedColor && A_1.IsKnownColor)
            {
                return this.method_166(A_1, A_5);
            }
            return this.method_177(A_1, A_5);
        }
        if (((A_2 != null) && A_2.HasValue(A_4)) && !A_3.IsEmpty)
        {
            if (!A_3.IsNamedColor || !A_3.IsKnownColor)
            {
                return this.method_177(A_3, A_5);
            }
            this.method_166(A_3, A_5);
        }
        return string.Empty;
    }

    private string method_166(Color A_0, string A_1)
    {
        int num = 0x10;
        Color color = new Color();
        string name = A_0.Name;
        if (name != null)
        {
            int num2;
            if (Class1160.dictionary_224 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("笵夷䠹医儽⸿", num), 0);
                dictionary1.Add(BookmarkStart.b("焵䨷弹夻倽", num), 1);
                dictionary1.Add(BookmarkStart.b("礵吷匹䨻嬽", num), 2);
                dictionary1.Add(BookmarkStart.b("砵夷䰹䔻", num), 3);
                dictionary1.Add(BookmarkStart.b("昵䴷䠹䰻刽┿", num), 4);
                dictionary1.Add(BookmarkStart.b("戵崷嬹倻", num), 5);
                dictionary1.Add(BookmarkStart.b("搵崷帹", num), 6);
                dictionary1.Add(BookmarkStart.b("稵儷圹夻", num), 7);
                dictionary1.Add(BookmarkStart.b("漵崷嘹倻儽㜿", num), 8);
                dictionary1.Add(BookmarkStart.b("琵吷伹夻", num), 9);
                dictionary1.Add(BookmarkStart.b("瀵䴷夹吻䴽⤿⍁", num), 10);
                dictionary1.Add(BookmarkStart.b("眵䤷伹崻", num), 11);
                dictionary1.Add(BookmarkStart.b("焵圷嘹堻", num), 12);
                Class1160.dictionary_224 = dictionary1;
            }
            if (Class1160.dictionary_224.TryGetValue(name, out num2))
            {
                switch (num2)
                {
                    case 0:
                        color = Color.FromArgb(0xff, 0, 0);
                        break;

                    case 1:
                        color = Color.FromArgb(0, 0xff, 0);
                        break;

                    case 2:
                        color = Color.FromArgb(0x80, 0x80, 0);
                        break;

                    case 3:
                        color = Color.FromArgb(0, 0, 0x80);
                        break;

                    case 4:
                        color = Color.FromArgb(0xff, 0, 0xff);
                        break;

                    case 5:
                        color = Color.FromArgb(0, 0xff, 0xff);
                        break;

                    case 6:
                        color = Color.FromArgb(0xff, 0, 0);
                        break;

                    case 7:
                        color = Color.FromArgb(0, 0x80, 0);
                        break;

                    case 8:
                        color = Color.FromArgb(0xff, 0xff, 0);
                        break;

                    case 9:
                        color = Color.FromArgb(0, 0, 0xff);
                        break;

                    case 10:
                        color = Color.FromArgb(0x80, 0, 0x80);
                        break;

                    case 11:
                        color = Color.FromArgb(0, 0x80, 0x80);
                        break;

                    case 12:
                        color = Color.FromArgb(0x80, 100, 0);
                        break;
                }
            }
        }
        if (!color.IsEmpty)
        {
            return this.method_177(color, A_1);
        }
        return this.method_177(A_0, A_1);
    }

    private void method_167()
    {
        int num = 2;
        if (this.bool_0 && this.bool_1)
        {
            this.method_7().method_3(this.string_24 + BookmarkStart.b("丧伩堫ᰭ", num));
        }
        else if (this.bool_1)
        {
            this.method_7().method_3(this.string_24 + BookmarkStart.b("丧伩堫Ἥ", num));
        }
        else
        {
            this.method_7().method_3(this.string_24 + BookmarkStart.b("丧伩堫ḭ", num));
        }
    }

    private string method_168(FieldType A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case FieldType.FieldRef:
                return BookmarkStart.b("琥洧氩ఫ", num);

            case FieldType.FieldIf:
                return BookmarkStart.b("漥渧਩", num);

            case FieldType.FieldIndex:
                return BookmarkStart.b("漥昧温椫瘭ု", num);

            case FieldType.FieldStyleRef:
                return BookmarkStart.b("甥簧猩怫欭戯眱爳ᘵ", num);

            case FieldType.FieldSequence:
                return BookmarkStart.b("甥洧笩ఫ", num);

            case FieldType.FieldTOC:
                return BookmarkStart.b("爥朧椩ఫ", num);

            case FieldType.FieldInfo:
                return BookmarkStart.b("漥昧氩挫อ", num);

            case FieldType.FieldTitle:
                return BookmarkStart.b("爥愧縩怫欭ု", num);

            case FieldType.FieldSubject:
                return BookmarkStart.b("甥紧栩昫欭猯昱ᐳ", num);

            case FieldType.FieldAuthor:
                return BookmarkStart.b("朥紧縩搫愭戯ሱ", num);

            case FieldType.FieldKeyWord:
                return BookmarkStart.b("津洧猩笫愭戯瘱朳ᘵ", num);

            case FieldType.FieldComments:
                return BookmarkStart.b("攥朧朩愫欭縯昱朳ᘵ", num);

            case FieldType.FieldLastSavedBy:
                return BookmarkStart.b("樥椧礩砫紭焯搱焳爵稷挹᰻", num);

            case FieldType.FieldCreateDate:
                return BookmarkStart.b("攥稧漩洫稭甯瘱申戵紷ᨹ", num);

            case FieldType.FieldSaveDate:
                return BookmarkStart.b("甥椧簩椫樭焯昱焳ᘵ", num);

            case FieldType.FieldPrintDate:
                return BookmarkStart.b("瘥稧挩戫稭琯猱怳猵ᠷ", num);

            case FieldType.FieldRevisionNum:
                return BookmarkStart.b("琥洧簩戫笭累ሱ", num);

            case FieldType.FieldEditTime:
                return BookmarkStart.b("挥氧挩砫稭礯缱焳ᘵ", num);

            case FieldType.FieldNumPages:
                return BookmarkStart.b("栥紧朩簫漭眯眱朳ᘵ", num);

            case FieldType.FieldNumWords:
                return BookmarkStart.b("栥紧朩笫愭戯瘱朳ᘵ", num);

            case FieldType.FieldNumChars:
                return BookmarkStart.b("栥紧朩漫昭焯怱朳ᘵ", num);

            case FieldType.FieldFileName:
                return BookmarkStart.b("急愧昩椫怭焯缱焳ᘵ", num);

            case FieldType.FieldTemplate:
                return BookmarkStart.b("爥洧朩簫戭焯昱焳ᘵ", num);

            case FieldType.FieldDate:
                return BookmarkStart.b("戥椧縩椫อ", num);

            case FieldType.FieldTime:
                return BookmarkStart.b("爥愧朩椫อ", num);

            case FieldType.FieldPage:
                return BookmarkStart.b("瘥椧洩椫อ", num);

            case FieldType.FieldQuote:
                return BookmarkStart.b("眥紧攩砫欭ု", num);

            case FieldType.FieldPageRef:
                return BookmarkStart.b("瘥椧洩椫簭甯琱ᐳ", num);

            case FieldType.FieldAsk:
                return BookmarkStart.b("朥笧愩ఫ", num);

            case FieldType.FieldFillIn:
                return BookmarkStart.b("急愧昩怫札縯ሱ", num);

            case FieldType.FieldPrint:
                return BookmarkStart.b("瘥稧挩戫稭ု", num);

            case FieldType.FieldGoToButton:
                return BookmarkStart.b("愥朧縩挫氭支昱怳礵瘷ᨹ", num);

            case FieldType.FieldMacroButton:
                return BookmarkStart.b("欥椧椩縫愭爯朱怳戵眷琹᰻", num);

            case FieldType.FieldAutoNumOutline:
                return BookmarkStart.b("朥紧縩挫怭支缱笳挵氷ᨹ", num);

            case FieldType.FieldAutoNumLegal:
                return BookmarkStart.b("朥紧縩挫怭支缱砳焵琷ᨹ", num);

            case FieldType.FieldAutoNum:
                return BookmarkStart.b("朥紧縩挫怭支缱ᐳ", num);

            case FieldType.FieldLink:
                return BookmarkStart.b("樥愧搩末อ", num);

            case FieldType.FieldSymbol:
                return BookmarkStart.b("甥焧朩渫愭簯ሱ", num);

            case FieldType.FieldMergeField:
                return BookmarkStart.b("欥洧砩欫欭瘯笱焳稵簷ᨹ", num);

            case FieldType.FieldUserName:
                return BookmarkStart.b("猥笧漩縫怭焯缱焳ᘵ", num);

            case FieldType.FieldUserInitials:
                return BookmarkStart.b("猥笧漩縫札縯笱怳缵礷瘹漻ḽ", num);

            case FieldType.FieldUserAddress:
                return BookmarkStart.b("猥笧漩縫漭琯瘱昳猵欷椹᰻", num);

            case FieldType.FieldBarCode:
                return BookmarkStart.b("搥椧砩漫愭琯眱ᐳ", num);

            case FieldType.FieldDocVariable:
                return BookmarkStart.b("戥朧椩稫漭戯笱申琵琷缹᰻", num);

            case FieldType.FieldSection:
                return BookmarkStart.b("甥洧椩砫札缯簱ᐳ", num);

            case FieldType.FieldSectionPages:
                return BookmarkStart.b("甥洧椩砫札缯簱搳眵缷缹漻ḽ", num);

            case FieldType.FieldIncludePicture:
                return BookmarkStart.b("漥昧椩怫笭琯眱搳缵笷渹椻氽Կ扁", num);

            case FieldType.FieldIncludeText:
                return BookmarkStart.b("漥昧椩怫笭琯眱怳猵怷渹᰻", num);

            case FieldType.FieldFileSize:
                return BookmarkStart.b("急愧昩椫紭礯栱焳ᘵ", num);

            case FieldType.FieldFormTextInput:
                return BookmarkStart.b("急朧砩愫稭甯樱怳ᘵ", num);

            case FieldType.FieldFormCheckBox:
                return BookmarkStart.b("急朧砩愫洭砯眱眳紵稷甹搻ḽ", num);

            case FieldType.FieldNoteRef:
                return BookmarkStart.b("栥朧縩椫簭甯琱ᐳ", num);

            case FieldType.FieldTOA:
                return BookmarkStart.b("爥朧欩ఫ", num);

            case FieldType.FieldPrivate:
                return BookmarkStart.b("瘥稧挩稫漭搯眱ᐳ", num);

            case FieldType.FieldAutoText:
                return BookmarkStart.b("朥紧縩挫稭甯樱怳ᘵ", num);

            case FieldType.FieldAddin:
                return BookmarkStart.b("朥氧温攫怭ု", num);

            case FieldType.FieldFormDropDown:
                return BookmarkStart.b("急朧砩愫樭戯紱搳爵眷洹爻ḽ", num);

            case FieldType.FieldAdvance:
                return BookmarkStart.b("朥氧簩洫怭猯眱ᐳ", num);

            case FieldType.FieldDocProperty:
                return BookmarkStart.b("戥朧椩簫簭缯戱焳搵氷挹᰻", num);

            case FieldType.FieldHyperlink:
                return BookmarkStart.b("渥焧稩椫簭簯笱稳紵ᠷ", num);

            case FieldType.FieldAutoTextList:
                return BookmarkStart.b("朥紧縩挫稭甯樱怳稵焷椹栻ḽ", num);

            case FieldType.FieldListNum:
                return BookmarkStart.b("樥愧礩砫怭支缱ᐳ", num);
        }
        return string.Empty;
    }

    private string method_169(Color A_0)
    {
        return Class1006.smethod_22(A_0).ToString();
    }

    private Dictionary<string, Dictionary<int, int>> method_17()
    {
        if (this.dictionary_3 == null)
        {
            this.dictionary_3 = new Dictionary<string, Dictionary<int, int>>();
        }
        return this.dictionary_3;
    }

    private void method_170()
    {
        int num = 11;
        if (this.method_5().method_0() != 0)
        {
            this.method_5().method_3(BookmarkStart.b("䰰", num));
            this.method_5().method_3(Environment.NewLine);
        }
        if (this.method_4().method_0() != 0)
        {
            this.method_4().method_3(BookmarkStart.b("䰰", num));
            this.method_4().method_3(Environment.NewLine);
        }
        if (this.method_1().method_0() != 0)
        {
            this.method_1().method_3(BookmarkStart.b("䰰", num));
            this.method_1().method_3(Environment.NewLine);
        }
    }

    private void method_171(string A_0)
    {
        int num = 7;
        if (!string.IsNullOrEmpty(A_0))
        {
            this.streamWriter_0.Write(BookmarkStart.b("嘬", num));
            this.streamWriter_0.Write(A_0);
            this.streamWriter_0.WriteLine(BookmarkStart.b("倬", num));
        }
    }

    private string method_172(bool A_0, string A_1)
    {
        int num = 9;
        if (string.IsNullOrEmpty(A_1))
        {
            return string.Empty;
        }
        string str = string.Empty;
        string str2 = this.bool_2 ? BookmarkStart.b("瀮̰̲Ĵ", num) : BookmarkStart.b("瀮İ", num);
        string key = A_1 + str2;
        if (this.dictionary_9.ContainsKey(key))
        {
            Struct35 struct2 = this.dictionary_9[key];
            if (A_0)
            {
                return struct2.string_1;
            }
            return struct2.string_0;
        }
        string str4 = this.method_183(A_1);
        int num3 = this.int_4++;
        Struct35 struct3 = new Struct35 {
            string_0 = this.string_24 + BookmarkStart.b("䤮", num) + num3,
            string_1 = this.string_24 + BookmarkStart.b("丮地", num) + num3,
            int_0 = this.bool_2 ? 0xcc : 0
        };
        if (A_0)
        {
            str = struct3.string_1;
        }
        else
        {
            str = struct3.string_0;
        }
        this.dictionary_9.Add(key, struct3);
        this.method_176(struct3.string_0, str4);
        this.method_176(struct3.string_1, str4);
        return str;
    }

    private string method_173(bool A_0)
    {
        int num3 = 7;
        if (A_0)
        {
            return (this.string_24 + BookmarkStart.b("䰬䤮", num3) + this.int_4++);
        }
        return (this.string_24 + BookmarkStart.b("䬬", num3) + this.int_4++);
    }

    private int method_174()
    {
        return this.int_5++;
    }

    private int method_175()
    {
        return this.int_8++;
    }

    private void method_176(string A_0, string A_1)
    {
        int num = 15;
        if (this.class1082_1 == null)
        {
            this.method_4().method_3(BookmarkStart.b("临", num) + this.string_24 + BookmarkStart.b("匴堶圸伺䤼崾ⵀ", num));
        }
        this.method_4().method_3(BookmarkStart.b("临", num));
        this.method_4().method_3(A_0);
        if (this.bool_2)
        {
            this.method_4().method_3(this.string_24 + BookmarkStart.b("匴吶儸娺似䰾⑀㝂睄睆絈", num));
        }
        else
        {
            this.method_4().method_3(this.string_24 + BookmarkStart.b("匴吶儸娺似䰾⑀㝂畄", num));
        }
        this.method_4().method_3(BookmarkStart.b("ᔴ", num));
        this.method_4().method_3(A_1);
        this.method_4().method_3(BookmarkStart.b("ิ䨶", num));
        this.method_4().method_3(Environment.NewLine);
    }

    private string method_177(Color A_0, string A_1)
    {
        int num = 7;
        if (this.class1082_2 == null)
        {
            this.method_5().method_3(BookmarkStart.b("嘬", num) + this.string_24 + BookmarkStart.b("丬䀮崰尲䜴䌶嬸场ؼ", num));
        }
        if (this.method_20().ContainsKey(A_0))
        {
            int num2 = this.method_20()[A_0];
            return (A_1 + num2.ToString());
        }
        this.method_20().Add(A_0, this.int_8);
        this.method_5().method_3(this.string_24 + BookmarkStart.b("弬䨮唰", num));
        this.method_5().method_4(A_0.R);
        this.method_5().method_3(this.string_24 + BookmarkStart.b("䨬崮吰嘲嬴", num));
        this.method_5().method_4(A_0.G);
        this.method_5().method_3(this.string_24 + BookmarkStart.b("伬䌮䐰嘲", num));
        this.method_5().method_4(A_0.B);
        this.method_5().method_3(BookmarkStart.b("ᘬ", num));
        this.method_5().method_3(Environment.NewLine);
        return (A_1 + this.method_175());
    }

    private string method_178(string A_0)
    {
        char newChar = '\r';
        A_0 = A_0.Replace(Environment.NewLine, newChar.ToString());
        A_0 = A_0.Replace('\n', newChar);
        return A_0;
    }

    private string method_179(CharacterFormat A_0, bool A_1)
    {
        int num = 15;
        if ((A_0.OwnerBase is ListLevel) || ((A_0.OwnerBase != null) && (A_0.OwnerBase.OwnerBase is Document)))
        {
            return string.Empty;
        }
        if ((A_0.OwnerBase != null) && (A_0.OwnerBase.OwnerBase is Paragraph))
        {
            Paragraph ownerBase = A_0.OwnerBase.OwnerBase as Paragraph;
            if (ownerBase.ParaStyle.CharacterFormat.HasValue(A_1 ? 270 : 2))
            {
                return this.method_172(A_1, A_1 ? ownerBase.ParaStyle.CharacterFormat.FontNameBidi : ownerBase.ParaStyle.CharacterFormat.FontName);
            }
        }
        if ((this.document_0.DefCharFormat != null) && this.document_0.DefCharFormat.HasValue(A_1 ? 270 : 2))
        {
            return this.method_172(A_1, A_1 ? this.document_0.DefCharFormat.FontNameBidi : this.document_0.DefCharFormat.FontName);
        }
        return this.method_172(A_1, BookmarkStart.b("愴帶吸帺丼Ἶཀ♂㉄杆ᭈ⑊⁌⹎㽐", num));
    }

    private Dictionary<int, int> method_18()
    {
        if (this.dictionary_6 == null)
        {
            this.dictionary_6 = new Dictionary<int, int>();
        }
        return this.dictionary_6;
    }

    private string method_180(CharacterFormat A_0)
    {
        bool flag = false;
        if (A_0.FontName != BookmarkStart.b("缪䐬䈮吰䀲ᔴ礶尸䰺ᴼ派⹀⹂⑄⥆", 5))
        {
            flag = true;
        }
        if (A_0.HasValue(2))
        {
            flag = true;
        }
        if (((A_0.Document != null) && (A_0.Document.GrammarSpellingData == null)) && A_0.HasKey(0))
        {
            flag = true;
        }
        if (flag)
        {
            return this.method_172(false, A_0.FontName);
        }
        return this.method_179(A_0, false);
    }

    private string method_181(CharacterFormat A_0)
    {
        bool flag = false;
        if (A_0.FontNameBidi != BookmarkStart.b("縩䔫䌭唯䄱ᐳ砵崷䴹᰻氽⼿⽁╃⡅", 4))
        {
            flag = true;
        }
        if (A_0.HasValue(270))
        {
            flag = true;
        }
        if (((A_0.Document != null) && (A_0.Document.GrammarSpellingData == null)) && A_0.HasKey(270))
        {
            flag = true;
        }
        if (flag)
        {
            return this.method_172(true, A_0.FontName);
        }
        return this.method_179(A_0, true);
    }

    private bool method_182(Paragraph A_0)
    {
        if (A_0.IsInCell && (A_0.NextSibling == null))
        {
            return false;
        }
        if ((A_0.OwnerTextBody.OwnerBase is Footnote) && (A_0.method_5() == (A_0.OwnerTextBody.ChildObjects.Count - 1)))
        {
            return false;
        }
        if ((A_0.OwnerTextBody.OwnerBase is Comment) && (A_0.NextSibling == null))
        {
            return false;
        }
        if (((A_0.OwnerTextBody.OwnerBase is Section) && ((A_0.OwnerTextBody.OwnerBase as Section).NextSibling != null)) && ((A_0.NextSibling == null) && (A_0.method_1() == null)))
        {
            return false;
        }
        return true;
    }

    private string method_183(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        return this.method_184(A_0);
    }

    private string method_184(string A_0)
    {
        int num = 0x11;
        if (string.IsNullOrEmpty(A_0))
        {
            return string.Empty;
        }
        Class1083 class2 = new Class1083((int) (A_0.Length * 1.75));
        for (int i = 0; i < A_0.Length; i++)
        {
            int num2 = A_0[i];
            switch (num2)
            {
                case 0x7b:
                case 0x7d:
                {
                    class2.method_1(this.string_24).method_2('\'').method_1(num2.ToString(BookmarkStart.b("伶ସ", num)));
                    continue;
                }
                case 0x5c:
                {
                    if (((i + 1) < A_0.Length) && (A_0[i + 1] == 't'))
                    {
                        class2.method_1(this.string_24).method_1(BookmarkStart.b("䌶堸夺ᴼ", num));
                        i++;
                    }
                    else
                    {
                        class2.method_1(this.string_24).method_1(BookmarkStart.b("ံస堺", num));
                    }
                    continue;
                }
                default:
                    if ((num2 >= 0x20) && (num2 < 0x80))
                    {
                        class2.method_2(A_0[i]);
                        continue;
                    }
                    if (((num2 >= 0) && (num2 < 0x20)) || ((num2 >= 0x80) && (num2 <= 0xff)))
                    {
                        if (num2 == 9)
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("䌶堸夺ᴼ", num));
                        }
                        else
                        {
                            class2.method_1(this.string_24).method_2('\'').method_1(num2.ToString(BookmarkStart.b("伶ସ", num)));
                        }
                        continue;
                    }
                    if ((num2 >= 0x350) && (num2 <= 0x44f))
                    {
                        num2 -= 0x350;
                        class2.method_1(this.string_24).method_2('\'').method_1(num2.ToString(BookmarkStart.b("伶ସ", num)));
                        this.bool_2 = true;
                        continue;
                    }
                    switch (num2)
                    {
                        case 0x2013:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("制圸强尼䰾⥀捂", num));
                            continue;
                        }
                        case 0x2014:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("制吸强尼䰾⥀捂", num));
                            continue;
                        }
                        case 0x2018:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("嬶䠸为刼䬾⑀捂", num));
                            continue;
                        }
                        case 0x2019:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("䔶䠸为刼䬾⑀捂", num));
                            continue;
                        }
                        case 0x201c:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("嬶崸夺儼举㑀ⱂㅄ≆楈", num));
                            continue;
                        }
                        case 0x201d:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("䔶崸夺儼举㑀ⱂㅄ≆楈", num));
                            continue;
                        }
                        case 0x2020:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("ံĸഺ", num));
                            continue;
                        }
                        case 0x2021:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("ံĸ఺", num));
                            continue;
                        }
                        case 0x2026:
                        {
                            class2.method_1(this.string_24).method_1(BookmarkStart.b("ံĸฺ", num));
                            continue;
                        }
                    }
                    break;
            }
            short num5 = (short) num2;
            class2.method_1(this.string_24).method_1(BookmarkStart.b("䈶", num)).method_4(num5).method_1(this.string_24).method_1(BookmarkStart.b("ံਸ崺", num));
        }
        return class2.ToString();
    }

    private Class1083 method_185(CharacterFormat A_0, string A_1)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("崥", 0));
        class2.method_2(' ');
        class2.method_1(A_1);
        class2.method_7(1, this.method_37(A_0).ToString());
        class2.method_1(BookmarkStart.b("嬥", 0));
        class2.method_1(Environment.NewLine);
        this.bool_2 = false;
        return class2;
    }

    private bool method_186(FieldMark A_0)
    {
        if (A_0.PreviousSibling == null)
        {
            return false;
        }
        return (((A_0.PreviousSibling is CheckBoxFormField) || (A_0.PreviousSibling is DropDownFormField)) || ((A_0.PreviousSibling is Field) && ((A_0.PreviousSibling as Field).Type == FieldType.FieldGoToButton)));
    }

    private Section method_187(DocumentObject A_0)
    {
        while (A_0 != null)
        {
            if (A_0.DocumentObjectType == DocumentObjectType.Section)
            {
                break;
            }
            A_0 = A_0.Owner;
        }
        if (A_0 != null)
        {
            return (A_0 as Section);
        }
        return null;
    }

    private void method_188()
    {
    }

    private Stack<object> method_19()
    {
        if (this.stack_0 == null)
        {
            this.stack_0 = new Stack<object>();
        }
        return this.stack_0;
    }

    private Class1082 method_2()
    {
        if (this.class1082_10 == null)
        {
            this.class1082_10 = new Class1082();
        }
        return this.class1082_10;
    }

    private Dictionary<Color, int> method_20()
    {
        if (this.dictionary_7 == null)
        {
            this.dictionary_7 = new Dictionary<Color, int>();
        }
        return this.dictionary_7;
    }

    internal void method_21(string A_0, IDocument A_1)
    {
        using (StreamWriter writer = new StreamWriter(A_0, false, Encoding.ASCII))
        {
            writer.AutoFlush = true;
            this.method_22(writer, A_1);
            writer.Close();
        }
    }

    internal void method_22(StreamWriter A_0, IDocument A_1)
    {
        int num = 6;
        this.document_0 = A_1 as Document;
        this.streamWriter_0 = A_0;
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        this.method_27();
        this.method_57();
        this.method_137();
        this.method_59();
        this.method_28();
        this.method_146();
        this.method_170();
        this.method_24();
        this.method_23();
        this.streamWriter_0.WriteLine(BookmarkStart.b("圫", num) + this.string_24 + BookmarkStart.b("師娭嘯̱", num) + this.string_24 + BookmarkStart.b("䴫䀭䌯嬱", num));
        this.method_25();
        this.method_26();
        this.streamWriter_0.Write(BookmarkStart.b("儫", num));
        this.streamWriter_0.Flush();
    }

    private void method_23()
    {
        int num = 9;
        if ((this.list_0 != null) && (this.list_0.Count != 0))
        {
            Class1082 class2 = new Class1082();
            class2.method_3(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("Ԯ", num) + this.string_24 + BookmarkStart.b("崮吰䔲䄴唶唸", num));
            foreach (string str in this.list_0)
            {
                class2.method_3(BookmarkStart.b("吮", num) + this.method_183(str) + BookmarkStart.b("ᐮ䰰", num));
            }
            class2.method_3(BookmarkStart.b("刮", num));
            class2.method_3(Environment.NewLine);
            this.method_2().method_6(class2);
        }
    }

    private void method_24()
    {
        int num = 7;
        int num2 = 1;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("嘬", 7) + this.string_24 + BookmarkStart.b("ܬ", 7) + this.string_24 + BookmarkStart.b("崬䠮䄰䜲圴嬶", 7));
        foreach (Class51 class3 in this.list_1)
        {
            class2.method_3(string.Concat(new object[] { BookmarkStart.b("嘬", num), this.string_24, BookmarkStart.b("崬䠮䄰", num), this.string_24, BookmarkStart.b("䐬弮嘰䌲", num), num2++ }));
            class2.method_3(this.string_24 + BookmarkStart.b("䐬嬮倰䌲", num) + (class3.method_11() ? BookmarkStart.b("ᰬ", num) : BookmarkStart.b("ᴬ", num)));
            class2.method_3(this.string_24 + BookmarkStart.b("䄬䘮", num) + (class3.method_5().Left * 20f));
            class2.method_3(this.string_24 + BookmarkStart.b("弬䘮", num) + (class3.method_5().Right * 20f));
            class2.method_3(this.string_24 + BookmarkStart.b("帬䴮", num) + (class3.method_5().Top * 20f));
            class2.method_3(this.string_24 + BookmarkStart.b("帬丮", num) + (class3.method_5().Bottom * 20f));
            class2.method_3(BookmarkStart.b("倬", num));
        }
        class2.method_3(BookmarkStart.b("倬", num));
        class2.method_3(Environment.NewLine);
        this.method_3().method_6(class2);
    }

    private void method_25()
    {
        int num = 12;
        using (Class1083 class2 = new Class1083())
        {
            string fontName = BookmarkStart.b("昱崳嬵崷䤹᰻瀽┿㕁摃ᑅ❇❉ⵋ⁍", num);
            if ((this.document_0.DefCharFormat != null) && this.document_0.DefCharFormat.HasValue(2))
            {
                fontName = this.document_0.DefCharFormat.FontName;
            }
            class2.method_1(this.string_24 + BookmarkStart.b("嘱儳倵帷", num));
            class2.method_1(this.method_172(false, fontName).Replace(this.string_24 + BookmarkStart.b("吱", num), string.Empty));
            this.streamWriter_0.Write(class2.ToString());
        }
    }

    private void method_26()
    {
        this.method_4().method_7(this.streamWriter_0);
        this.method_5().method_7(this.streamWriter_0);
        this.method_9().method_7(this.streamWriter_0);
        this.method_1().method_7(this.streamWriter_0);
        this.method_2().method_7(this.streamWriter_0);
        this.method_10().method_7(this.streamWriter_0);
        this.method_11().method_7(this.streamWriter_0);
        this.method_3().method_7(this.streamWriter_0);
        this.method_8().method_7(this.streamWriter_0);
    }

    private void method_27()
    {
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("ᨯ", 10) + this.string_24 + BookmarkStart.b("启圱刳唵倷䨹", 10));
        class2.method_2(this.method_37(this.document_0.DefCharFormat));
        class2.method_3(BookmarkStart.b("䴯", 10));
        class2.method_3(Environment.NewLine);
        class2.method_3(BookmarkStart.b("䬯", 10) + this.string_24 + BookmarkStart.b("ᨯ", 10) + this.string_24 + BookmarkStart.b("启圱刳䘵夷䨹", 10));
        class2.method_6(this.method_40(this.document_0.DefParaFormat, null));
        class2.method_3(BookmarkStart.b("䴯", 10));
        class2.method_3(Environment.NewLine);
        this.method_9().method_6(class2);
    }

    private void method_28()
    {
        this.method_29();
        int num = 0;
        int count = this.document_0.Sections.Count;
        while (num < count)
        {
            this.bool_1 = false;
            this.bool_0 = false;
            Section section = this.document_0.Sections[num];
            this.method_46(section);
            this.method_30(section);
            this.method_167();
            this.method_8().method_6(this.method_7());
            this.class1082_4 = null;
            this.method_8().method_6(this.method_6());
            this.class1082_3 = null;
            num++;
        }
    }

    private void method_29()
    {
        int num = 7;
        if (this.document_0.Background.Type != BackgroundType.NoBackground)
        {
            Class1083 class2 = new Class1083();
            class2.method_1(this.string_24 + BookmarkStart.b("嬬䘮吰䐲圴尶䨸䬺఼", num));
            class2.method_1(BookmarkStart.b("嘬", num) + this.string_24 + BookmarkStart.b("伬丮到堲刴䔶嘸为匼嬾", num));
            class2.method_1(BookmarkStart.b("嘬", num) + this.string_24 + BookmarkStart.b("帬䜮䄰", num));
            class2.method_1(BookmarkStart.b("嘬", num) + this.string_24 + BookmarkStart.b("ܬ", num) + this.string_24 + BookmarkStart.b("帬䜮䄰娲嬴䐶䴸", num));
            class2.method_0(this.method_135(this.document_0.Background));
            class2.method_1(BookmarkStart.b("倬刮䰰", num));
            class2.method_1(Environment.NewLine);
            this.method_8().method_2(class2);
        }
    }

    private Class1082 method_3()
    {
        if (this.class1082_9 == null)
        {
            this.class1082_9 = new Class1082();
        }
        return this.class1082_9;
    }

    private void method_30(Section A_0)
    {
        int num = 13;
        bool flag = A_0.NextSibling == null;
        this.method_32(A_0.HeadersFooters);
        this.method_31(A_0.Body.Items);
        if (!flag)
        {
            this.method_6().method_3(this.string_24 + BookmarkStart.b("䀲倴吶䴸", num));
        }
        this.method_6().method_3(Environment.NewLine);
    }

    private void method_31(BodyRegionCollection A_0)
    {
        int num = 0x11;
        foreach (DocumentObject obj2 in A_0)
        {
            if (obj2 is Paragraph)
            {
                this.method_35(obj2 as Paragraph);
            }
            else if (((obj2 is StructureDocumentTag) && ((obj2 as StructureDocumentTag).SDTContent != null)) && ((obj2 as StructureDocumentTag).SDTContent.Items != null))
            {
                this.method_31((obj2 as StructureDocumentTag).SDTContent.Items);
            }
            else
            {
                this.method_65(obj2 as Table);
            }
        }
        if ((A_0 != null) && (A_0.Count <= 0))
        {
            this.method_6().method_3(this.string_24 + BookmarkStart.b("䜶堸䤺", num));
        }
    }

    private void method_32(HeadersFooters A_0)
    {
        int num = 9;
        if ((A_0 != null) || (this.document_0.Watermark != null))
        {
            this.method_34(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("䜮吰刲儴制䬸场", num), A_0.EvenHeader);
            this.method_34(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("䜮吰刲儴制䬸䤺", num), A_0.OddHeader);
            this.method_34(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("䤮帰尲䄴制䬸场", num), A_0.EvenFooter);
            this.method_34(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("䤮帰尲䄴制䬸䤺", num), A_0.OddFooter);
            this.method_34(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("䜮吰刲儴制䬸崺", num), A_0.FirstPageHeader);
            this.method_34(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("䤮帰尲䄴制䬸崺", num), A_0.FirstPageFooter);
        }
    }

    private string method_33(HeaderFooter A_0)
    {
        string str = string.Empty;
        WatermarkBase watermark = A_0.Watermark;
        if ((watermark == null) || (watermark.Type == WatermarkType.NoWatermark))
        {
            return str;
        }
        if (watermark.Type == WatermarkType.TextWatermark)
        {
            return this.method_156(watermark as TextWatermark);
        }
        return this.method_155(watermark as PictureWatermark);
    }

    private void method_34(string A_0, HeaderFooter A_1)
    {
        int num = 2;
        if ((A_1.Items.Count > 0) || ((A_1.Watermark != null) && (A_1.Watermark.Type != WatermarkType.NoWatermark)))
        {
            this.method_6().method_3(A_0);
            this.method_6().method_3(this.method_33(A_1));
            this.method_31(A_1.Items);
            this.method_6().method_3(BookmarkStart.b("唧", num));
        }
    }

    private void method_35(Paragraph A_0)
    {
        this.method_6().method_6(this.method_147(A_0.GetListFormatForApplyStyle(), A_0.ListText));
        this.method_6().method_6(this.method_40(A_0.Format, A_0));
        ParagraphBase base2 = null;
        int num = 0;
        int count = A_0.Items.Count;
        while (num < count)
        {
            base2 = A_0.Items[num];
            this.method_85(base2);
            num++;
        }
        if (this.method_182(A_0))
        {
            this.method_36(A_0);
        }
    }

    private void method_36(Paragraph A_0)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("吮", 9));
        class2.method_0(this.method_37(A_0.BreakCharacterFormat));
        class2.method_1(this.string_24 + BookmarkStart.b("弮倰䄲", 9));
        class2.method_1(BookmarkStart.b("刮", 9));
        this.method_6().method_2(class2);
        this.method_6().method_3(Environment.NewLine);
    }

    private Class1083 method_37(CharacterFormat A_0)
    {
        int num = 12;
        Class1083 class2 = new Class1083();
        if (A_0 == null)
        {
            return class2.method_1(string.Empty);
        }
        CharacterFormat characterFormat = null;
        if (!string.IsNullOrEmpty(A_0.CharStyleName))
        {
            Style style = this.document_0.Styles.FindByName(A_0.CharStyleName);
            if ((style != null) && (style.CharacterFormat != null))
            {
                characterFormat = style.CharacterFormat;
            }
        }
        if (A_0.OwnerBase is TextRange)
        {
            if (A_0.IsInsertRevision)
            {
                class2.method_1(string.Concat(new object[] { this.string_24, BookmarkStart.b("䀱儳䀵儷䤹夻娽", num), this.string_24, BookmarkStart.b("䀱儳䀵夷伹䠻嘽", num), this.method_38(A_0.InsertRevision.method_0()) }));
                class2.method_1(this.string_24 + BookmarkStart.b("䀱儳䀵尷丹䠻匽", num) + Class1041.smethod_6(A_0.InsertRevision.method_2()).ToString());
            }
            else if (A_0.IsDeleteRevision)
            {
                class2.method_1(string.Concat(new object[] { this.string_24, BookmarkStart.b("嘱儳娵崷丹夻娽", num), this.string_24, BookmarkStart.b("䀱儳䀵夷伹䠻嘽␿❁⡃", num), this.method_38(A_0.DeleteRevision.method_0()) }));
                class2.method_1(this.string_24 + BookmarkStart.b("䀱儳䀵尷丹䠻匽␿❁⡃", num) + Class1041.smethod_6(A_0.DeleteRevision.method_2()).ToString());
            }
        }
        if (A_0.Bidi)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帱䀳䐵嬷刹", num) + this.string_24 + BookmarkStart.b("吱圳䔵࠷", num) + this.string_24 + BookmarkStart.b("帱唳堵強", num) + A_0.LocaleIdASCII.ToString());
            class2.method_1(this.method_181(A_0));
            if ((A_0.OwnerBase != null) && (A_0.OwnerBase is ParagraphStyle))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("匱刳䔵", num));
                class2.method_5(A_0.FontSize * 2f);
            }
            else if (A_0.HasValue(190))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("匱刳䔵", num));
                class2.method_5(A_0.FontSize * 2f);
            }
            class2.method_1(this.string_24 + BookmarkStart.b("䀱䀳娵嬷刹", num) + this.string_24 + BookmarkStart.b("吱圳䔵࠷", num) + this.string_24 + BookmarkStart.b("帱唳堵強", num) + A_0.LocaleIdBi.ToString());
            class2.method_1(this.method_180(A_0));
            if ((A_0.OwnerBase != null) && (A_0.OwnerBase is ParagraphStyle))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("吱䜳", num));
                class2.method_5(A_0.FontSizeBidi * 2f);
            }
            else if (A_0.HasValue(190) || (A_0.FontSize != 12f))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("吱䜳", num));
                class2.method_5(A_0.FontSizeBidi * 2f);
            }
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䀱䀳娵嬷刹", num) + this.string_24 + BookmarkStart.b("吱圳䔵࠷", num) + this.string_24 + BookmarkStart.b("帱唳堵強", num) + A_0.LocaleIdBi.ToString());
            class2.method_1(this.method_181(A_0));
            if ((A_0.OwnerBase != null) && (A_0.OwnerBase is ParagraphStyle))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("匱刳䔵", num));
                class2.method_5(A_0.FontSizeBidi * 2f);
            }
            else if (A_0.HasValue(190))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("匱刳䔵", num));
                class2.method_5(A_0.FontSizeBidi * 2f);
            }
            class2.method_1(this.string_24 + BookmarkStart.b("帱䀳䐵嬷刹", num) + this.string_24 + BookmarkStart.b("吱圳䔵࠷", num) + this.string_24 + BookmarkStart.b("帱唳堵強", num) + A_0.LocaleIdASCII.ToString());
            class2.method_1(this.method_180(A_0));
            if ((A_0.OwnerBase != null) && (A_0.OwnerBase is ParagraphStyle))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("吱䜳", num));
                class2.method_5(A_0.FontSize * 2f);
            }
            else if (A_0.HasValue(190) || (A_0.FontSize != 12f))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("吱䜳", num));
                class2.method_5(A_0.FontSize * 2f);
            }
        }
        if (!string.IsNullOrEmpty(A_0.CharStyleName) && this.method_14().ContainsKey(A_0.CharStyleName))
        {
            class2.method_1(this.method_14()[A_0.CharStyleName]);
        }
        this.method_39(60, this.string_24 + BookmarkStart.b("倱", num), A_0, class2);
        this.method_39(70, this.string_24 + BookmarkStart.b("嬱", num), A_0, class2);
        this.method_39(120, this.string_24 + BookmarkStart.b("儱唳䘵䬷", num), A_0, class2);
        this.method_39(110, this.string_24 + BookmarkStart.b("䄱圳圵䠷䤹", num), A_0, class2);
        if (A_0.HasValue(140))
        {
            this.method_51(A_0.UnderlineStyle, class2);
        }
        else if ((characterFormat != null) && characterFormat.HasValue(140))
        {
            this.method_51(characterFormat.UnderlineStyle, class2);
        }
        this.method_39(80, this.string_24 + BookmarkStart.b("䄱䀳䐵儷儹夻", num), A_0, class2);
        this.method_39(300, this.string_24 + BookmarkStart.b("䄱䀳䐵儷儹夻娽焿", num), A_0, class2);
        this.method_39(100, this.string_24 + BookmarkStart.b("䄱尳圵尷", num), A_0, class2);
        if (A_0.CharacterSpacing != 0f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("圱䰳䘵嘷帹", num) + ((int) (A_0.CharacterSpacing * 2f)));
            class2.method_1(this.string_24 + BookmarkStart.b("圱䰳䘵嘷帹䠻䤽", num) + ((int) (A_0.CharacterSpacing * 20f)));
        }
        if (A_0.HasValue(210))
        {
            if (A_0.SubSuperScript == SubSuperScript.SuperScript)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䄱䄳䘵崷䠹", num));
            }
            else if (A_0.SubSuperScript == SubSuperScript.SubScript)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䄱䄳吵", num));
            }
            else if (A_0.SubSuperScript == SubSuperScript.None)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("就嬳䔵䴷䨹夻䰽㌿㝁♃", num));
            }
        }
        else if ((characterFormat != null) && characterFormat.HasValue(210))
        {
            if (characterFormat.SubSuperScript == SubSuperScript.SuperScript)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䄱䄳䘵崷䠹", num));
            }
            else if (characterFormat.SubSuperScript == SubSuperScript.SubScript)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䄱䄳吵", num));
            }
            else if (characterFormat.SubSuperScript == SubSuperScript.None)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("就嬳䔵䴷䨹夻䰽㌿㝁♃", num));
            }
        }
        Color empty = Color.Empty;
        if (characterFormat != null)
        {
            empty = characterFormat.TextColor;
        }
        class2.method_1(this.method_165(A_0, A_0.TextColor, characterFormat, empty, 160, this.string_24 + BookmarkStart.b("儱刳", num)));
        if (characterFormat != null)
        {
            empty = characterFormat.TextBackgroundColor;
        }
        class2.method_1(this.method_165(A_0, A_0.TextBackgroundColor, characterFormat, empty, 9, this.string_24 + BookmarkStart.b("儱尳唵娷䨹崻䨽", num)));
        if (characterFormat != null)
        {
            empty = characterFormat.HighlightColor;
        }
        class2.method_1(this.method_165(A_0, A_0.HighlightColor, characterFormat, empty, 20, this.string_24 + BookmarkStart.b("娱崳儵倷嘹唻夽⠿㙁", num)));
        class2.method_0(this.method_62(A_0.Border));
        this.method_39(110, this.string_24 + BookmarkStart.b("䄱圳圵䠷䤹", num), A_0, class2);
        this.method_39(130, this.string_24 + BookmarkStart.b("䐱", num), A_0, class2);
        this.method_39(90, this.string_24 + BookmarkStart.b("崱䄳䈵吷", num), A_0, class2);
        this.method_39(120, this.string_24 + BookmarkStart.b("儱唳䘵䬷", num), A_0, class2);
        this.method_39(170, this.string_24 + BookmarkStart.b("圱夳吵圷", num), A_0, class2);
        this.method_39(180, this.string_24 + BookmarkStart.b("嬱夳䘵䨷", num), A_0, class2);
        return class2;
    }

    private int method_38(string A_0)
    {
        int num = 2;
        if ((this.list_0 == null) || (this.list_0.Count == 0))
        {
            this.list_0 = new List<string>();
            this.list_0.Add(BookmarkStart.b("紧䐩䜫䀭弯䔱娳", num));
        }
        if (!this.list_0.Contains(A_0))
        {
            this.list_0.Add(A_0);
        }
        return this.list_0.IndexOf(A_0);
    }

    private void method_39(short A_0, string A_1, CharacterFormat A_2, Class1083 A_3)
    {
        bool flag;
        int num = 4;
        if (flag = A_2.method_62(A_0))
        {
            A_3.method_1(A_1);
        }
        else if (!flag && A_2.method_67(A_0))
        {
            A_3.method_1(A_1 + BookmarkStart.b("ᨩ", num));
        }
        else if (A_2.HasValue(A_0))
        {
            if (A_2.method_53(A_0))
            {
                A_3.method_1(A_1);
            }
            else
            {
                A_3.method_1(A_1 + BookmarkStart.b("ᨩ", num));
            }
        }
    }

    private Class1082 method_4()
    {
        if (this.class1082_1 == null)
        {
            this.class1082_1 = new Class1082();
        }
        return this.class1082_1;
    }

    private Class1082 method_40(ParagraphFormat A_0, Paragraph A_1)
    {
        bool flag;
        int num = 0x13;
        Class1082 class2 = new Class1082();
        if (A_0 == null)
        {
            class2.method_3(string.Empty);
            return class2;
        }
        string str = string.Empty;
        string styleName = string.Empty;
        if (A_1 != null)
        {
            styleName = A_1.StyleName;
            if (string.IsNullOrEmpty(styleName))
            {
                styleName = BookmarkStart.b("眸吺似刾⁀⽂", num);
            }
            if (!this.method_14().ContainsKey(styleName))
            {
                this.method_61(styleName);
            }
            if (this.method_14().ContainsKey(styleName))
            {
                str = this.method_14()[styleName];
            }
        }
        ParagraphFormat paragraphFormat = null;
        if ((A_1 != null) && !string.IsNullOrEmpty(A_1.StyleName))
        {
            Style style = this.document_0.Styles.FindByName(A_1.StyleName);
            if (((style != null) && (style is ParagraphStyle)) && ((style as ParagraphStyle).ParagraphFormat != null))
            {
                paragraphFormat = (style as ParagraphStyle).ParagraphFormat;
            }
        }
        ListFormat format2 = (A_1 != null) ? A_1.GetListFormatForApplyStyle() : null;
        if (A_1 != null)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䤸娺似嬾", num));
        }
        if (A_1 != null)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䤸场尼嘾⽀", num));
            class2.method_3(this.string_24 + BookmarkStart.b("唸娺匼堾灀獂癄瑆", num));
        }
        if (A_0.IsBidi)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䬸伺儼伾⁀ㅂ", num));
        }
        if (A_0.IsWidowControl)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("丸刺夼尾㕀⽂㕄♆㭈", num));
        }
        class2.method_3(str);
        int num2 = 0x7fffffff;
        class2.method_3(this.string_24 + BookmarkStart.b("弸刺", num));
        if ((!A_0.HasValue(0x492) && (format2 != null)) && (format2.ListType != ListType.NoList))
        {
            num2 = ((int) format2.CurrentListLevel.ParagraphFormat.FirstLineIndent) * 20;
        }
        else
        {
            num2 = ((int) A_0.FirstLineIndent) * 20;
        }
        if (num2 != 0x7fffffff)
        {
            class2.method_4(num2);
        }
        int num3 = 0x7fffffff;
        class2.method_3(this.string_24 + (A_0.IsBidi ? BookmarkStart.b("䬸刺", num) : BookmarkStart.b("唸刺", num)));
        if ((!A_0.HasKey(0x488) && (format2 != null)) && (format2.ListType != ListType.NoList))
        {
            num3 = ((int) format2.CurrentListLevel.ParagraphFormat.LeftIndent) * 20;
        }
        else
        {
            num3 = ((int) A_0.LeftIndent) * 20;
        }
        if (num3 != 0x7fffffff)
        {
            class2.method_4(num3);
        }
        int num4 = 0x7fffffff;
        class2.method_3(this.string_24 + (A_0.IsBidi ? BookmarkStart.b("唸刺", num) : BookmarkStart.b("䬸刺", num)));
        if ((!A_0.HasValue(0x47e) && (format2 != null)) && (format2.ListType != ListType.NoList))
        {
            num4 = ((int) format2.CurrentListLevel.ParagraphFormat.RightIndent) * 20;
        }
        else
        {
            num4 = ((int) A_0.RightIndent) * 20;
        }
        if (num4 != 0x7fffffff)
        {
            class2.method_4(num4);
        }
        if (A_0.HasValue(0x5b5))
        {
            Class51 item = this.document_0.WebSettings.method_26(A_0.DivId);
            if (item != null)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("倸䬺娼伾", num) + (this.list_1.Count + 1));
                item.method_12(A_1.IsInCell);
                this.list_1.Add(item);
            }
        }
        class2.method_6(this.method_63(A_0));
        if (flag = (A_1 != null) && A_1.IsInCell)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("倸唺䤼崾ⵀ", num));
        }
        class2.method_6(this.method_53(A_0));
        class2.method_6(this.method_41(A_0, flag));
        if (A_0.method_59(0x410))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("券帺堼伾", num));
        }
        if (A_0.method_59(0x41a))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("券帺堼伾⽀", num));
        }
        if (A_0.method_59(0x424) && A_0.PageBreakBefore)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䤸娺娼娾⍀⅂", num));
        }
        if ((A_0.method_59(0x500) && (((byte) A_0.OutlineLevel) >= 0)) && (((byte) A_0.OutlineLevel) < 9))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘸为䤼匾⡀ⵂ⁄⭆ⱈ㵊⡌⍎", num));
            class2.method_4((byte) A_0.OutlineLevel);
        }
        if (A_0.method_60())
        {
            if (!A_0.BackColor.IsEmpty)
            {
                class2.method_3(this.method_177(A_0.BackColor, this.string_24 + BookmarkStart.b("娸夺䴼帾㕀", num)));
            }
            if (!A_0.ForeColor.IsEmpty)
            {
                class2.method_3(this.method_177(A_0.ForeColor, this.string_24 + BookmarkStart.b("娸崺䴼帾㕀", num)));
            }
            class2.method_3(this.method_45(A_0.TextureStyle));
        }
        if (A_0.HorizontalAlignment == HorizontalAlignment.Left)
        {
            class2.method_3(this.string_24 + (A_0.IsBidi ? BookmarkStart.b("䠸䤺", num) : BookmarkStart.b("䠸场", num)));
        }
        else if (A_0.HorizontalAlignment == HorizontalAlignment.Right)
        {
            class2.method_3(this.string_24 + (A_0.IsBidi ? BookmarkStart.b("䠸场", num) : BookmarkStart.b("䠸䤺", num)));
        }
        else if (A_0.HorizontalAlignment == HorizontalAlignment.Center)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠸堺", num));
        }
        else if (A_0.HorizontalAlignment == HorizontalAlignment.Justify)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠸儺", num));
        }
        else
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠸强", num));
        }
        class2.method_2(this.method_64(A_1, A_0));
        class2.method_2(this.method_52(A_0.TabsEx));
        if ((A_1 != null) && (A_1.ParaStyle != null))
        {
            CharacterFormat characterFormat = A_1.ParaStyle.CharacterFormat;
            class2.method_2(this.method_37(characterFormat));
        }
        else if (this.document_0.DefCharFormat != null)
        {
            class2.method_2(this.method_37(this.document_0.DefCharFormat));
        }
        if ((paragraphFormat != null) && paragraphFormat.IsContextualSpacing)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("娸吺匼䬾⑀㭂ㅄ㉆⡈❊㹌㽎ぐげご", num));
        }
        if ((A_1 != null) && (this.int_7 > 1))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("倸伺尼伾", num) + this.int_7.ToString());
        }
        class2.method_3(Environment.NewLine);
        return class2;
    }

    private Class1082 method_41(ParagraphFormat A_0, bool A_1)
    {
        int num = 8;
        Class1082 class2 = new Class1082();
        if (A_0.IsContextualSpacing)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䴭弯就䀳匵䀷丹䤻弽ⰿㅁ㑃❅⭇⽉", num));
            return class2;
        }
        if (A_0.method_59(0x4b0))
        {
            class2.method_3(this.method_42(this.string_24 + BookmarkStart.b("崭刯", num), A_0.BeforeSpacing));
        }
        else if (((this.document_0.DefParaFormat != null) && this.document_0.DefParaFormat.HasValue(0x4b0)) && !A_1)
        {
            class2.method_3(this.method_42(this.string_24 + BookmarkStart.b("崭刯", num), this.document_0.DefParaFormat.BeforeSpacing));
        }
        if (A_0.method_59(0x4c4))
        {
            class2.method_3(this.method_42(this.string_24 + BookmarkStart.b("崭儯", num), A_0.AfterSpacing));
        }
        else if (((this.document_0.DefParaFormat != null) && this.document_0.DefParaFormat.HasValue(0x4c4)) && !A_1)
        {
            class2.method_3(this.method_42(this.string_24 + BookmarkStart.b("崭儯", num), this.document_0.DefParaFormat.AfterSpacing));
        }
        if (A_0.method_59(0x4ba))
        {
            class2.method_3(this.method_43(this.string_24 + BookmarkStart.b("崭刯匱䄳䈵圷", num), A_0.BeforeAutoSpacing));
        }
        if (A_0.method_59(0x4ce))
        {
            class2.method_3(this.method_43(this.string_24 + BookmarkStart.b("崭儯匱䄳䈵圷", num), A_0.AfterAutoSpacing));
        }
        if (A_0.method_59(0x672))
        {
            class2.method_2(this.method_44(A_0));
            return class2;
        }
        if (((this.document_0.DefParaFormat != null) && this.document_0.DefParaFormat.HasValue(0x672)) && !A_1)
        {
            class2.method_2(this.method_44(this.document_0.DefParaFormat));
        }
        return class2;
    }

    private string method_42(string A_0, float A_1)
    {
        int num = (int) Math.Round((double) (A_1 * 20f));
        return (A_0 + num.ToString());
    }

    private string method_43(string A_0, bool A_1)
    {
        int num = 2;
        if (A_1)
        {
            return (A_0 + BookmarkStart.b("ᤧ", num));
        }
        return (A_0 + BookmarkStart.b("ᠧ", num));
    }

    private Class1083 method_44(ParagraphFormat A_0)
    {
        int num = 1;
        Class1083 class2 = new Class1083();
        class2.method_1(this.string_24 + BookmarkStart.b("否䔨", 1));
        int num2 = (int) Math.Abs(Math.Round((double) (A_0.LineSpacing * 20f)));
        if (A_0.LineSpacingRule == LineSpacingRule.Exactly)
        {
            class2.method_1(BookmarkStart.b("ਦ", num));
        }
        class2.method_4(num2);
        switch (A_0.LineSpacingRule)
        {
            case LineSpacingRule.AtLeast:
            case LineSpacingRule.Exactly:
                class2.method_1(this.string_24 + BookmarkStart.b("否䔨䘪堬䌮䔰̲", num));
                return class2;

            case LineSpacingRule.Multiple:
                class2.method_1(this.string_24 + BookmarkStart.b("否䔨䘪堬䌮䔰Ȳ", num));
                return class2;
        }
        return class2;
    }

    private string method_45(TextureStyle A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case TextureStyle.Texture5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶స଺഼", num));

            case TextureStyle.Texture10Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶࠸଺഼༾", num));

            case TextureStyle.Texture20Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ସ଺഼༾", num));

            case TextureStyle.Texture25Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ସฺ഼༾", num));

            case TextureStyle.Texture30Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ਸ଺഼༾", num));

            case TextureStyle.Texture40Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶സ଺഼༾", num));

            case TextureStyle.Texture50Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶స଺഼༾", num));

            case TextureStyle.Texture60Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶༸଺഼༾", num));

            case TextureStyle.Texture70Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ุ଺഼༾", num));

            case TextureStyle.Texture75Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ฺ഼ุ༾", num));

            case TextureStyle.Texture80Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ĸ଺഼༾", num));

            case TextureStyle.Texture90Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶8଺഼༾", num));

            case TextureStyle.TextureDarkHorizontal:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮娰嬲娴䔶倸䄺", num));

            case TextureStyle.TextureDarkVertical:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮娰䔲倴䔶䴸", num));

            case TextureStyle.TextureDarkDiagonalDown:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮娰儲儴帶堸尺", num));

            case TextureStyle.TextureDarkDiagonalUp:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮娰唲儴帶堸尺", num));

            case TextureStyle.TextureDarkCross:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮娰倲䜴堶䨸䠺", num));

            case TextureStyle.TextureDarkDiagonalCross:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮娰圲嘴䔶嘸䠺丼", num));

            case TextureStyle.TextureHorizontal:
                return (this.string_24 + BookmarkStart.b("䤪䨬䜮帰䄲尴䴶", num));

            case TextureStyle.TextureVertical:
                return (this.string_24 + BookmarkStart.b("䤪䨬央吰䄲䄴", num));

            case TextureStyle.TextureDiagonalDown:
                return (this.string_24 + BookmarkStart.b("䤪䨬䴮唰娲吴倶", num));

            case TextureStyle.TextureDiagonalUp:
                return (this.string_24 + BookmarkStart.b("䤪䨬䤮唰娲吴倶", num));

            case TextureStyle.TextureCross:
                return (this.string_24 + BookmarkStart.b("䤪䨬䰮䌰尲䘴䐶", num));

            case TextureStyle.TextureDiagonalCross:
                return (this.string_24 + BookmarkStart.b("䤪䨬䬮到䄲娴䐶䨸", num));

            case TextureStyle.Texture2Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ସฺ഼", num));

            case TextureStyle.Texture7Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ฺ഼ุ", num));

            case TextureStyle.Texture12Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶࠸ऺ࠼༾", num));

            case TextureStyle.Texture15Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶࠸ฺ഼༾", num));

            case TextureStyle.Texture17Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶࠸఺࠼༾", num));

            case TextureStyle.Texture27Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ସ఺࠼༾", num));

            case TextureStyle.Texture32Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ਸऺ࠼༾", num));

            case TextureStyle.Texture35Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ਸฺ഼༾", num));

            case TextureStyle.Texture37Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ਸ఺࠼༾", num));

            case TextureStyle.Texture42Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶സऺ࠼༾", num));

            case TextureStyle.Texture45Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶സฺ഼༾", num));

            case TextureStyle.Texture47Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶സ఺࠼༾", num));

            case TextureStyle.Texture52Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶సऺ࠼༾", num));

            case TextureStyle.Texture55Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶సฺ഼༾", num));

            case TextureStyle.Texture57Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶స఺࠼༾", num));

            case TextureStyle.Texture62Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶༸ऺ࠼༾", num));

            case TextureStyle.Texture65Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶༸ฺ഼༾", num));

            case TextureStyle.Texture67Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶༸఺࠼༾", num));

            case TextureStyle.Texture72Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ุऺ࠼༾", num));

            case TextureStyle.Texture77Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ุ఺࠼༾", num));

            case TextureStyle.Texture82Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ĸऺ࠼༾", num));

            case TextureStyle.Texture85Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ĸฺ഼༾", num));

            case TextureStyle.Texture87Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶ĸ఺࠼༾", num));

            case TextureStyle.Texture92Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶8ऺ࠼༾", num));

            case TextureStyle.Texture95Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶8ฺ഼༾", num));

            case TextureStyle.Texture97Pt5Percent:
                return (this.string_24 + BookmarkStart.b("堪䔬丮唰娲嬴倶8఺࠼༾", num));
        }
        return string.Empty;
    }

    private void method_46(Section A_0)
    {
        int num = 5;
        Class1082 class2 = new Class1082();
        class2.method_3(this.string_24 + BookmarkStart.b("堪䠬䰮䔰圲", 5));
        switch (A_0.BreakCode)
        {
            case SectionBreakType.NoBreak:
                class2.method_3(this.string_24 + BookmarkStart.b("堪伬䐮弰尲嬴制", num));
                break;

            case SectionBreakType.NewColumn:
                class2.method_3(this.string_24 + BookmarkStart.b("堪伬䐮到尲头", num));
                break;

            case SectionBreakType.EvenPage:
                class2.method_3(this.string_24 + BookmarkStart.b("堪伬䐮吰䔲倴夶", num));
                break;

            case SectionBreakType.Oddpage:
                class2.method_3(this.string_24 + BookmarkStart.b("堪伬䐮帰圲儴", num));
                break;
        }
        if (A_0.PageSetup.Orientation == PageOrientation.Landscape)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䜪䌬䬮䈰倲䔴䐶䄸唺", num));
        }
        if (A_0.TextDirection == TextDirection.TopToBottomRotated)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䜪夬崮䈰嘲嘴䌶", num) + this.string_24 + BookmarkStart.b("堪夬䨮䤰䜲匴嬶嘸䰺़", num));
        }
        else if (A_0.TextDirection == TextDirection.RightToLeft)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("太夬䌮䈰嘲嘴䌶", num) + this.string_24 + BookmarkStart.b("堪夬䨮䤰䜲匴嬶嘸䰺఼", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("䔪䈬䤮吰刲䄴䈶䬸帺䤼圾㍀ⱂㅄ㍆╈⹊籌", num));
        if (!this.document_0.Settings.bool_41)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䴪䈬崮尰䀲崴嘶崸帺", num));
        }
        if (!this.document_0.Settings.bool_42)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䔪䈬䔮娰嘲䜴夶䤸为匼尾㕀", num));
        }
        class2.method_6(this.method_48(A_0.PageSetup));
        this.method_7().method_6(class2);
        this.method_7().method_6(this.method_47(A_0));
        this.method_7().method_3(Environment.NewLine);
    }

    private Class1082 method_47(Section A_0)
    {
        int num = 0;
        Class1082 class2 = new Class1082();
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.NoTabForInd))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧帩䴫䰭夯就倳", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.WrapTrailSpaces))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("儥娧䬩尫娭䈯䄱䐳", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.MapPrintTextColor))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘥娧䤩䌫䈭刯帱", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.NoSpaceRaiseLower))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧伩含娭䈯匱䜳䘵䨷嘹", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.NoColumnBalance))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䤩䌫䈭刯匱堳", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ConvMailMergeEsc))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䔥帧䜩䄫䬭", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SuppressTopSpacing))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧堩弫娭䌯䈱", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SuppressSpBfAfterPgBrk))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧堩弫崭䀯倱刳", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.OrigWordTableRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䤥尧䠩䀫尭䔯帱", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SwapBordersFacingPgs))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥弧娩丫䨭䈯", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ShowBreaksInFrames))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䐥娧䄩䨫尭崯", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ExtraAfter))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧堩弫䈭帯䄱䐳", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SubOnSize))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥崧䠩䨫䄭帯䘱嘳伵䬷匹䘻嬽", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.TruncFontHeight))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("別娧弩䈫䴭儯䘱儳倵圷吹䠻嘽┿⭁⍃⹅㱇", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.PrintBodyBeforeHdr))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䐥䰧䠩䨫䘭启䀱", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontBlnSbDbWid))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䈥䘧帩丫䈭帯䄱嘳刵娷", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.LineWrapLikeWord6))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䤥䐧丩䀫䜭帯圱䌳䐵夷䨹", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.WPJust))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("儥堧䀩弫娭", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.WPSpace))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("儥堧天尫", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SpLayoutLikeWW8))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧䘩唫娭䜯就崳堵崷", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.FtnLayoutLikeWW8))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀥尧䐩䀫圭䐯䔱娳張嘷弹", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ForgetLastTabAlign))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("匥嬧伩䀫娭刯匱堳堵", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.AlignTablesRowByRow))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䜥䐧䐩堫䰭尯嬱娳刵", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.LayoutRawTableWidth))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䨥儧帩伫伭尯儱䀳吵吷䴹堻", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.LayoutTableRowsApart))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䨥儧帩堫䰭尯䀱䀳儵䨷", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.UseWord97LineBreakingRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䨥䘧䠩師䔭䈯䜱堳匵", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ApplyBreakingRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("朥堧娩䀫圭爯䀱弳搵䴷嘹夻䴽", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontWrapTextWithPunct))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("儥娧娩尫嬭帯儱䀳", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontSnapToGridInCell))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥䘧䬩尫娭弯唱䘳張尷匹刻崽┿⹁⡃", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontUseAsianBreakRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䜥嬧䌩䴫䀭刯䀱弳䐵䴷嘹夻", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontMakeSpaceForUL))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧天尫伭匯圱刳夵䨷伹倻", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontULTrlSpc))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧弩䀫娭䈯帱䜳䘵嬷", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.MWSmallCaps))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䬥嬧䜩伫伭䀯", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontAllowFieldEndSelect))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䜥䐧䘩䌫夭嘯嬱儳娵尷弹刻娽㌿❁⡃", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.PrintMet))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䨥儧帩尫尭䐯弱儳䈵", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ExactOnTop))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䨥儧帩䤫嘭匯䘱䀳䘵", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.WW6BorderRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䐥䰧堩師䈭䌯䔱䜳張䀷", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontAdjustLineHeightInTable))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䘩䈫䘭䐯匱倳尵䰷堹倻", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontVertAlignInTxbx))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧帩娫伭䐯䨱嘳丵", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ExpShRtn))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䌥倧娩弫䘭䈯䘱娳", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontUseHTMLParagraphAutoSpacing))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("严尧䜩䴫嬭䐯䄱䐳", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SuppressTopSpacingMac5))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧堩弫娭䌯弱", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.UseAutospaceForFullWidthAlpha))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䤥䐧丩䴫崭", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.TruncDxaExpand))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("別娧弩䈫䴭唯䨱", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontVertAlignCellWithSp))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧帩伫堭儯䄱䐳", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontBreakConstrainedForcedTables))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧帩丫尭嬯儱娳䔵䰷尹主崽㐿⁁⡃", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.HangulWidthLikeWW11))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("严弧伩䀫䬭䘯", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontUseIndentAsNumberingTabStop))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䌩䈫䨭帯弱嘳䐵䰷䤹", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontBreakWrappedTables))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䠩師䔭䜯䀱䐳䈵娷嘹", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.NoExtLeading))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䘩䤫伭启", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.DontAutofitConstrainedTables))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䬩䨫䴭帯䄱䀳䈵娷嘹", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.WW11IndentRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("伥䘧丩師䈭䌯䔱儳娵崷䰹夻倽", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.UseNormalStyleForList))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("匥嬧伩䈫䄭䈯弱䜳䈵䄷尹医䰽ⰿ⭁㝃㉅", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.LeaveBackslashAlone))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧利䀫伭䐯䘱嬳伵崷吹", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.doNotFlipMirrorIndents))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䈥䜧搩䌫娭瘯帱崳䘵男匹主䰽⼿ぁൃ⡅ⱇ⽉≋㩍⍏", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.enableOpenTypeFeatures))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䌥䘧䬩丫䈭唯紱䐳匵嘷渹䔻丽┿с⅃❅㱇㽉㹋⭍⍏", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.UseWord2002TableStyleRules))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䴧崩堫䰭尯䄱䀳伵䨷伹倻䴽", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.FELineBreak11))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀥䴧䘩䈫䰭䈯圱堳匵丷", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.AutofitLikeWW11))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䜥丧伩䀫䬭䘯", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.Word11KerningPairs))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䴥娧䐩尫尭䌯就儳䈵", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.CachedColBalance))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䔥䤧䤩䐫䬭启儱嬳娵娷嬹倻", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.UnderlineTabInNumList))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("匥尧䌩䈫䈭", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.overrideTableStyleFontSizeAndJustification))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䈥䄧䰩䨫䬭䈯圱娳䈵儷嬹䠻嬽ി㝁⡃㉅ⅇ㡉⍋㥍я㍑㙓㩕㵗቙㥛㽝џݡᙣ", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.GrowAutoFit))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䴩師䄭䜯匱䄳䈵圷尹唻䨽", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.AllowSpaceOfSameStyleInTable))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䠥䜧䤩含崭䀯䘱唳吵吷弹", num));
        }
        if (!A_0.Document.Settings.method_5().method_0(CompatibilityOptions.SplitPgBreakAndParaMark))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧䘩堫席圯䈱唳䐵", num));
        }
        if (A_0.Document.Settings.method_5().method_0(CompatibilityOptions.ExtraAfter))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥堧堩弫䰭䌯䈱", num));
        }
        return class2;
    }

    private Class1082 method_48(PageSetup A_0)
    {
        int num = 0;
        Class1082 class2 = new Class1082();
        if (A_0.HeaderDistance > 0f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("严䴧䬩䠫䬭䈯䬱", num));
            class2.method_5(A_0.HeaderDistance * 20f);
        }
        if (A_0.FooterDistance > 0f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀥䜧䔩堫䬭䈯䬱", num));
            class2.method_5(A_0.FooterDistance * 20f);
        }
        switch (A_0.VerticalAlignment)
        {
            case PageAlignment.Top:
                class2.method_3(this.string_24 + BookmarkStart.b("倥䴧堩堫伭尯䘱", num));
                break;

            case PageAlignment.Middle:
                class2.method_3(this.string_24 + BookmarkStart.b("倥䴧堩堫伭尯儱", num));
                break;

            case PageAlignment.Justified:
                class2.method_3(this.string_24 + BookmarkStart.b("倥䴧堩堫伭尯報", num));
                break;

            case PageAlignment.Bottom:
                class2.method_3(this.string_24 + BookmarkStart.b("倥䴧堩堫伭尯倱", num));
                break;
        }
        switch (A_0.CharacterSpacingControl)
        {
            case CharacterSpacing.doNotCompress:
                class2.method_3(this.string_24 + BookmarkStart.b("䰥䴧利尫伭帯嘱", num));
                break;

            case CharacterSpacing.compressPunctuation:
                class2.method_3(this.string_24 + BookmarkStart.b("䰥䬧䔩䄫席䈯圱䜳䔵", num));
                break;
        }
        if (A_0.DifferentFirstPageHeaderFooter)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("別䄧帩䀫䬭䀯唱", num));
        }
        if (A_0.DifferentOddAndEvenPagesHeaderFooter)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䀥䤧䤩䔫䀭圯䈱", num));
        }
        if (A_0.PageSize.Width != 612f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘥伧崩弫嘭帯", num));
            class2.method_4((int) Math.Round((double) (A_0.PageSize.Width * 20f)));
        }
        if (A_0.PageSize.Height != 792f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘥伧䈩弫嘭帯", num));
            class2.method_4((int) Math.Round((double) (A_0.PageSize.Height * 20f)));
        }
        if (A_0.Margins.Left != 90f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䬥䤧堩䬫䈭䌯䨱娳", num));
            class2.method_4((int) Math.Round((double) (A_0.Margins.Left * 20f)));
        }
        if (A_0.Margins.Right != 90f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䬥䤧堩䬫尭䌯䨱娳", num));
            class2.method_4((int) Math.Round((double) (A_0.Margins.Right * 20f)));
        }
        if (A_0.Margins.Top != 72f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䬥䤧堩䬫娭䌯䨱娳", num));
            class2.method_4((int) Math.Round((double) (A_0.Margins.Top * 20f)));
        }
        if (A_0.Margins.Bottom != 72f)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䬥䤧堩䬫䰭䌯䨱娳", num));
            class2.method_4((int) Math.Round((double) (A_0.Margins.Bottom * 20f)));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("䄥崧帩堫䬭䈯", num));
        class2.method_4((int) Math.Round((double) (A_0.Margins.Gutter * 20f)));
        class2.method_3(this.string_24 + BookmarkStart.b("䈥䴧䰩堫伭刯", num));
        class2.method_4((int) Math.Round((double) (A_0.DefaultTabWidth * 20f)));
        if (A_0.GutterAtTop)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䄥崧帩堫䬭䈯䈱䘳娵", num));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("嘥伧䐩伫䄭帯䘱", num));
        if (A_0.RestartPageNumbering)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("嘥伧䐩師䬭䌯䘱唳䐵䰷", num));
            class2.method_3(this.string_24 + BookmarkStart.b("嘥伧䐩弫娭儯䀱䀳䔵", num));
            class2.method_4(A_0.PageStartingNumber);
            class2.method_3(this.method_49(A_0.PageNumberStyle));
        }
        class2.method_3(this.string_24 + BookmarkStart.b("唥䴧䤩堫䈭夯就儳儵䨷匹堻", num));
        class2.method_5(A_0.LinePitch * 20f);
        if (A_0.PitchType == GridPitchType.LinesOnly)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("唥䴧䤩堫崭䀯圱圳張帷䌹倻", num));
        }
        class2.method_6(this.method_54(A_0.Borders));
        class2.method_2(this.method_50((A_0.OwnerBase as Section).Columns));
        return class2;
    }

    private string method_49(PageNumberStyle A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case PageNumberStyle.RomanUpper:
                return (this.string_24 + BookmarkStart.b("䈱匳堵䴷夹主匽", num));

            case PageNumberStyle.RomanLower:
                return (this.string_24 + BookmarkStart.b("䈱匳堵吷夹主匽", num));

            case PageNumberStyle.LetterUpper:
                return (this.string_24 + BookmarkStart.b("䈱匳堵䴷夹倻䨽㈿", num));

            case PageNumberStyle.LetterLower:
                return (this.string_24 + BookmarkStart.b("䈱匳堵吷夹倻䨽㈿", num));
        }
        return (this.string_24 + BookmarkStart.b("䈱匳堵尷弹弻", num));
    }

    private Class1082 method_5()
    {
        if (this.class1082_2 == null)
        {
            this.class1082_2 = new Class1082();
        }
        return this.class1082_2;
    }

    private Class1083 method_50(ColumnCollection A_0)
    {
        int num = 11;
        Class1083 class2 = new Class1083();
        if (A_0.Count <= 0)
        {
            return class2.method_1(string.Empty);
        }
        PageSetup pageSetup = A_0.OwnerSection.PageSetup;
        class2.method_1(this.string_24 + BookmarkStart.b("到尲头䐶", num));
        class2.method_4(A_0.Count);
        if (!pageSetup.EqualColumnWidth && (A_0.Count != 1))
        {
            int num2 = 0;
            int count = A_0.Count;
            while (num2 < count)
            {
                Column column = A_0[num2];
                class2.method_1(this.string_24 + BookmarkStart.b("到尲头夶嘸", num));
                class2.method_4(num2 + 1);
                class2.method_1(this.string_24 + BookmarkStart.b("到尲头䀶", num));
                class2.method_5(column.Width * 20f);
                class2.method_1(this.string_24 + BookmarkStart.b("到尲头䐶䬸", num));
                class2.method_5(column.Space * 20f);
                num2++;
            }
        }
        else if (pageSetup.EqualColumnWidth && (A_0.Count > 1))
        {
            class2.method_1(this.string_24 + BookmarkStart.b("到尲头䐶䄸", num));
            class2.method_5(A_0[0].Space * 20f);
        }
        if (pageSetup.ColumnsLineBetween)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("崰娲嬴制嬸帺䤼尾⹀⽂", num));
        }
        return class2;
    }

    private void method_51(UnderlineStyle A_0, Class1083 A_1)
    {
        int num = 0x12;
        UnderlineStyle style = A_0;
        if (style > UnderlineStyle.WavyHeavy)
        {
            if (style == UnderlineStyle.DashLong)
            {
                A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹倻娽ℿㅁⱃ", num));
            }
            else if (style == UnderlineStyle.WavyDouble)
            {
                A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹䤻刽␿⁁㍃❅㹇⽉", num));
            }
        }
        else
        {
            switch (style)
            {
                case UnderlineStyle.None:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹刻儽⸿❁", num));
                    return;

                case UnderlineStyle.Single:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹", num));
                    return;

                case UnderlineStyle.Words:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹䬻", num));
                    break;

                case UnderlineStyle.Double:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹堻尽", num));
                    return;

                case UnderlineStyle.Dotted:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹堻", num));
                    return;

                case (UnderlineStyle.DotDot | UnderlineStyle.Single):
                case ((UnderlineStyle) 8):
                case UnderlineStyle.DotDash:
                case UnderlineStyle.DotDotDash:
                    break;

                case UnderlineStyle.Thick:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹䠻嘽", num));
                    return;

                case UnderlineStyle.Dash:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹堻弽㌿⩁", num));
                    return;

                case UnderlineStyle.Wavy:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹䬻弽㘿❁", num));
                    return;

                case UnderlineStyle.WavyHeavy:
                    A_1.method_1(this.string_24 + BookmarkStart.b("䴷嘹吻䤽ℿ㑁⅃", num));
                    return;

                default:
                    return;
            }
        }
    }

    private Class1083 method_52(TabCollection A_0)
    {
        int num = 0;
        Class1083 class2 = new Class1083();
        if (A_0.Count > 0)
        {
            int num2 = 0;
            int count = A_0.Count;
            while (num2 < count)
            {
                Tab tab = A_0[num2];
                switch (tab.Justification)
                {
                    case TabJustification.Centered:
                        class2.method_1(this.string_24 + BookmarkStart.b("別大䤩", num));
                        break;

                    case TabJustification.Right:
                        class2.method_1(this.string_24 + BookmarkStart.b("別大堩", num));
                        break;

                    case TabJustification.Decimal:
                        class2.method_1(this.string_24 + BookmarkStart.b("別大丩䤫䴭", num));
                        break;
                }
                switch (tab.TabLeader)
                {
                    case TabLeader.Dotted:
                        class2.method_1(this.string_24 + BookmarkStart.b("別䐧丩䌫娭", num));
                        break;

                    case TabLeader.Hyphenated:
                        class2.method_1(this.string_24 + BookmarkStart.b("別䐧䈩唫席堯", num));
                        break;

                    case TabLeader.Single:
                        class2.method_1(this.string_24 + BookmarkStart.b("別䐧帩䐫", num));
                        break;

                    case TabLeader.Heavy:
                        class2.method_1(this.string_24 + BookmarkStart.b("別䐧伩崫", num));
                        break;
                }
                class2.method_1(this.string_24 + BookmarkStart.b("別倧", num));
                class2.method_5(tab.Position * 20f);
                num2++;
            }
        }
        return class2;
    }

    private Class1082 method_53(ParagraphFormat A_0)
    {
        int num = 12;
        Class1082 class2 = new Class1082();
        Borders borders = A_0.Borders.method_49();
        if ((A_0.OwnerBase != null) && (A_0.OwnerBase is Paragraph))
        {
            borders.ApplyBase((A_0.OwnerBase as Paragraph).ParaStyle.ParagraphFormat.Borders);
        }
        if (borders.HasKey(2))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("倱䘳刵䨷丹", num));
            class2.method_3(this.method_55(borders.Top, false));
        }
        if (borders.HasKey(1))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("倱䘳刵䨷嘹", num));
            class2.method_3(this.method_55(borders.Left, false));
        }
        if (borders.HasKey(3))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("倱䘳刵䨷堹", num));
            class2.method_3(this.method_55(borders.Bottom, false));
        }
        if (borders.HasKey(4))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("倱䘳刵䨷䠹", num));
            class2.method_3(this.method_55(borders.Right, false));
        }
        return class2;
    }

    private Class1082 method_54(Borders A_0)
    {
        int num = 4;
        Class1082 class2 = new Class1082();
        if (A_0.NoBorder)
        {
            class2.method_3(string.Empty);
            return class2;
        }
        class2.method_3(this.string_24 + BookmarkStart.b("娩䬫䰭䈯嘱䘳夵䠷丹༻ఽ", num));
        class2.method_3(this.string_24 + BookmarkStart.b("娩䬫䰭䈯嘱䘳䈵", num));
        class2.method_3(this.method_55(A_0.Top, false));
        class2.method_3(this.string_24 + BookmarkStart.b("娩䬫䰭䈯嘱䘳吵", num));
        class2.method_3(this.method_55(A_0.Bottom, false));
        class2.method_3(this.string_24 + BookmarkStart.b("娩䬫䰭䈯嘱䘳娵", num));
        class2.method_3(this.method_55(A_0.Left, false));
        class2.method_3(this.string_24 + BookmarkStart.b("娩䬫䰭䈯嘱䘳䐵", num));
        class2.method_3(this.method_55(A_0.Right, false));
        return class2;
    }

    private string method_55(Border A_0, bool A_1)
    {
        int num = 7;
        BorderStyle borderType = A_0.BorderType;
        int num2 = (int) (A_0.LineWidth * 20f);
        float num3 = A_0.Space * 20f;
        if (((borderType == BorderStyle.None) && !A_0.HasNoneStyle) && A_0.IsBorderDefined)
        {
            return this.method_177(Color.Black, this.string_24 + BookmarkStart.b("伬崮唰䄲䘴", num) + this.string_24 + BookmarkStart.b("伬崮唰䄲䈴ضस", num) + this.string_24 + BookmarkStart.b("伬崮唰䄲嘴儶", num));
        }
        Class1083 class2 = new Class1083();
        if ((borderType == BorderStyle.None) && A_0.Color.IsEmpty)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伬崮唰䄲䄴唶唸", num));
        }
        else if ((borderType != BorderStyle.Cleared) && ((borderType != BorderStyle.None) || A_0.IsDefault))
        {
            class2.method_1(this.method_56(borderType));
            class2.method_1(this.string_24 + BookmarkStart.b("伬崮唰䄲䈴", num));
            class2.method_4(num2);
            class2.method_1(this.method_177(A_0.Color, this.string_24 + BookmarkStart.b("伬崮唰䄲嘴儶", num)));
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伬崮唰䄲嬴堶圸帺", num));
        }
        if (num3 > 0f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伬崮䈰䌲", num));
            class2.method_5(num3);
        }
        return class2.ToString();
    }

    private string method_56(BorderStyle A_0)
    {
        int num = 4;
        switch (A_0)
        {
            case BorderStyle.None:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯就嬳堵崷", num));

            case BorderStyle.Double:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱嘳", num));

            case BorderStyle.Hairline:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯娱唳張䨷", num));

            case BorderStyle.Dot:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱嬳䈵", num));

            case BorderStyle.DashLargeGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱唳䔵倷", num));

            case BorderStyle.DotDash:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱唳䔵倷帹", num));

            case BorderStyle.DotDotDash:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱唳䔵倷帹堻", num));

            case BorderStyle.Triple:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱䘳張䠷嘹夻", num));

            case BorderStyle.ThinThickSmallGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱尳䈵嘷䤹嬻", num));

            case BorderStyle.ThickThinSmallGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱娳䈵倷䤹嬻", num));

            case BorderStyle.ThinThickThinSmallGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱娳䈵倷丹刻䴽✿", num));

            case BorderStyle.ThinThickMediumGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱尳䈵嘷圹嬻", num));

            case BorderStyle.ThickThinMediumGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱娳䈵倷圹嬻", num));

            case BorderStyle.ThinThickThinMediumGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱娳䈵倷丹刻匽✿", num));

            case BorderStyle.ThinThickLargeGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱尳䈵嘷嘹嬻", num));

            case BorderStyle.ThickThinLargeGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱娳䈵倷嘹嬻", num));

            case BorderStyle.ThinThickThinLargeGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䘱娳䈵倷丹刻刽✿", num));

            case BorderStyle.Wave:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䔱唳䀵䄷", num));

            case BorderStyle.DoubleWave:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䔱唳䀵䄷帹帻", num));

            case BorderStyle.DashSmallGap:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱唳䔵倷䤹儻", num));

            case BorderStyle.DashDotStroker:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嘱唳䔵倷帹医䨽㌿㙁㙃", num));

            case BorderStyle.Emboss3D:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯圱夳吵圷䤹伻", num));

            case BorderStyle.Engrave3D:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯圱娳儵䨷嬹䨻嬽", num));

            case BorderStyle.Outset:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯崱䄳䈵䬷弹䠻", num));

            case BorderStyle.Inset:
                return (this.string_24 + BookmarkStart.b("䠩師䨭䈯嬱娳䔵崷丹", num));
        }
        return (this.string_24 + BookmarkStart.b("䠩師䨭䈯䄱", num));
    }

    private void method_57()
    {
        int num = 1;
        foreach (Style style2 in this.document_0.Styles)
        {
            if (!this.method_15().ContainsKey(style2.StyleId))
            {
                this.method_15().Add(style2.StyleId, num.ToString());
                num++;
            }
        }
        foreach (Style style in this.document_0.Styles)
        {
            string str = this.method_58(style);
            if (!string.IsNullOrEmpty(str) && !this.method_16().ContainsKey(style.StyleId))
            {
                this.method_16().Add(style.StyleId, str);
            }
        }
    }

    private string method_58(Style A_0)
    {
        int num = 10;
        if (A_0 == null)
        {
            return string.Empty;
        }
        string str = string.Empty;
        if (A_0.StyleType == StyleType.ParagraphStyle)
        {
            if (this.method_15().ContainsKey(A_0.StyleId))
            {
                str = this.string_24 + BookmarkStart.b("䌯", num) + this.method_15()[A_0.StyleId];
            }
            return str;
        }
        if (A_0.StyleType == StyleType.CharacterStyle)
        {
            if (this.method_15().ContainsKey(A_0.StyleId))
            {
                str = this.string_24 + BookmarkStart.b("匯䄱", num) + this.method_15()[A_0.StyleId];
            }
            return str;
        }
        if ((A_0.StyleType == StyleType.TableStyle) && this.method_15().ContainsKey(A_0.StyleId))
        {
            str = this.string_24 + BookmarkStart.b("䐯䄱", num) + this.method_15()[A_0.StyleId];
        }
        return str;
    }

    private void method_59()
    {
        foreach (Style style in this.document_0.Styles)
        {
            this.method_60(style);
        }
    }

    private Class1082 method_6()
    {
        if (this.class1082_3 == null)
        {
            this.class1082_3 = new Class1082();
        }
        return this.class1082_3;
    }

    private void method_60(Style A_0)
    {
        int num = 0x10;
        if (this.class1082_0 == null)
        {
            this.method_1().method_3(BookmarkStart.b("䴵", num) + this.string_24 + BookmarkStart.b("䔵䰷䌹倻嬽㌿⩁⅃⍅㱇", num));
        }
        if (!this.method_14().ContainsKey(A_0.StyleId))
        {
            string str = string.Empty;
            if (this.method_16().ContainsKey(A_0.StyleId))
            {
                str = this.method_16()[A_0.StyleId];
            }
            else
            {
                str = this.method_58(A_0);
                this.method_16().Add(A_0.StyleId, str);
            }
            this.method_1().method_3(BookmarkStart.b("䴵", num));
            if ((A_0.StyleType == StyleType.CharacterStyle) || (A_0.StyleType == StyleType.TableStyle))
            {
                this.method_1().method_3(this.string_24 + BookmarkStart.b("ᰵ", num));
            }
            this.method_1().method_3(str);
            if (A_0.StyleType == StyleType.TableStyle)
            {
                Class13 class2 = A_0 as Class13;
                this.method_1().method_3(this.method_66(class2.Interface8.imethod_3(), null));
            }
            if (A_0.StyleType == StyleType.ParagraphStyle)
            {
                ParagraphStyle style = A_0 as ParagraphStyle;
                this.method_1().method_6(this.method_40(style.ParagraphFormat, null));
            }
            if (A_0.StyleType == StyleType.CharacterStyle)
            {
                this.method_1().method_3(this.string_24 + BookmarkStart.b("圵尷帹唻䨽⤿㑁⅃", num));
            }
            this.method_1().method_2(this.method_37(A_0.CharacterFormat));
            if (((A_0.BaseStyle != null) && !string.IsNullOrEmpty(A_0.BaseStyle.StyleId)) && this.method_15().ContainsKey(A_0.BaseStyle.StyleId))
            {
                string str5 = this.method_15()[A_0.BaseStyle.StyleId];
                this.method_1().method_3(this.string_24 + BookmarkStart.b("䔵娷嬹伻嬽␿ⵁ⩃", num) + str5 + BookmarkStart.b("ᘵ", num));
            }
            if (!string.IsNullOrEmpty(A_0.NextStyle) && this.method_15().ContainsKey(A_0.NextStyle))
            {
                string str4 = this.method_15()[A_0.NextStyle];
                this.method_1().method_3(this.string_24 + BookmarkStart.b("䔵嘷弹䐻䨽", num) + str4 + BookmarkStart.b("ᘵ", num));
            }
            if (!string.IsNullOrEmpty(A_0.LinkStyle) && this.method_15().ContainsKey(A_0.LinkStyle))
            {
                string str2 = this.method_15()[A_0.LinkStyle];
                this.method_1().method_3(this.string_24 + BookmarkStart.b("䔵吷匹刻唽", num) + str2 + BookmarkStart.b("ᘵ", num));
            }
            this.method_1().method_3(this.string_24 + BookmarkStart.b("䔵䤷尹医䰽ⴿ⍁ぃ", num));
            string str3 = this.method_183(A_0.Name);
            if (this.bool_2)
            {
                this.method_1().method_3(BookmarkStart.b("䴵", num) + this.string_24 + BookmarkStart.b("ᰵ", num) + this.string_24 + BookmarkStart.b("倵夷嘹䠻ḽ", num) + str3 + BookmarkStart.b("䬵", num));
                this.bool_2 = false;
            }
            else
            {
                this.method_1().method_3(BookmarkStart.b("ᘵ", num) + str3);
            }
            this.method_1().method_3(BookmarkStart.b("വ䔷", num));
            this.method_14().Add(A_0.StyleId, str);
        }
    }

    private void method_61(string A_0)
    {
        Style style = this.document_0.Styles.FindByName(A_0);
        if (style != null)
        {
            this.method_60(style);
        }
    }

    private Class1083 method_62(Border A_0)
    {
        int num = 5;
        Class1083 class2 = new Class1083();
        if ((A_0 == null) || ((A_0.BorderType == BorderStyle.None) && !A_0.HasNoneStyle))
        {
            return class2.method_1(string.Empty);
        }
        class2.method_1(this.string_24 + BookmarkStart.b("䠪䔬䴮䌰圲䜴", num));
        class2.method_1(this.method_55(A_0, false));
        return class2;
    }

    private Class1082 method_63(ParagraphFormat A_0)
    {
        short num2;
        int num = 0x13;
        Class1082 class2 = new Class1082();
        if (!A_0.IsFrame)
        {
            class2.method_3(string.Empty);
            return class2;
        }
        switch (A_0.FrameHorizontalPos)
        {
            case 0:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸区帼倾ⵀ", num));
                break;

            case 1:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸区值䴾♀", num));
                break;

            case 2:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸区䴼堾", num));
                break;
        }
        switch (A_0.FrameVerticalPos)
        {
            case 0:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸䴺值䴾♀", num));
                break;

            case 1:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸䴺䴼堾", num));
                break;

            case 2:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸䴺䴼帾㍀≂", num));
                break;
        }
        short frameX = A_0.FrameX;
        if (frameX <= -12)
        {
            if (frameX != -16)
            {
                if (frameX != -12)
                {
                    goto Label_0191;
                }
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䜾⡀", num));
            }
            else
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䜾⹀", num));
            }
            goto Label_01F8;
        }
        switch (frameX)
        {
            case -8:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䜾㍀", num));
                goto Label_01F8;

            case -4:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䜾≀", num));
                goto Label_01F8;

            case 0:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䜾ⵀ", num));
                goto Label_01F8;
        }
    Label_0191:
        class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䜾", num) + A_0.FrameXEx.ToString());
    Label_01F8:
        num2 = A_0.FrameY;
        if (num2 <= -12)
        {
            switch (num2)
            {
                case -20:
                    class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾⹀㙂ㅄ", num));
                    goto Label_030E;

                case -16:
                    class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾⡀ⵂ", num));
                    goto Label_030E;
            }
            if (num2 != -12)
            {
                goto Label_02A7;
            }
            class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾⍀", num));
            goto Label_030E;
        }
        switch (num2)
        {
            case -8:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾≀", num));
                goto Label_030E;

            case -4:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾㕀", num));
                goto Label_030E;

            case 0:
                class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾⡀⽂", num));
                goto Label_030E;
        }
    Label_02A7:
        class2.method_3(this.string_24 + BookmarkStart.b("䤸吺丼䘾", num) + A_0.FrameYEx.ToString());
    Label_030E:
        if (A_0.FrameHeight != 0)
        {
            switch (A_0.FrameHeightRule)
            {
                case FrameSizeRule.AtLeast:
                    class2.method_3(this.string_24 + BookmarkStart.b("堸夺丼圾", num) + A_0.FrameHeight.ToString());
                    break;

                case FrameSizeRule.Exact:
                    class2.method_3(this.string_24 + BookmarkStart.b("堸夺丼圾汀", num) + A_0.FrameHeight.ToString());
                    break;
            }
        }
        if (A_0.FrameWidth > 0)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("堸夺丼䠾", num) + A_0.FrameWidth.ToString());
        }
        if (A_0.FrameAnchorLock)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("堸夺丼匾⹀⁂⹄癆", num));
        }
        if (A_0.FrameHorizontalDistanceFromText != 0)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("崸崺似刾㕀㭂ㅄ㽆", num) + A_0.FrameHorizontalDistanceFromText.ToString());
        }
        if (A_0.FrameVerticalDistanceFromText != 0)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("崸崺似刾㕀㭂ㅄ㹆", num) + A_0.FrameVerticalDistanceFromText.ToString());
        }
        if (A_0.FrameWrapType == FrameTextWrap.Around)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("丸䤺尼伾⁀ㅂ⩄㉆❈⽊", num));
        }
        return class2;
    }

    private Class1083 method_64(Paragraph A_0, ParagraphFormat A_1)
    {
        int num = 11;
        Class1083 class2 = new Class1083();
        if ((A_0 == null) || !A_0.ListFormat.IsEmptyList)
        {
            if (A_1.OwnerBase == null)
            {
                class2.method_1(string.Empty);
                return class2;
            }
            ParagraphStyle ownerBase = null;
            int num2 = -1;
            int listLevelNumber = -1;
            if (A_1.OwnerBase is ParagraphStyle)
            {
                ownerBase = A_1.OwnerBase as ParagraphStyle;
            }
            else if (A_1.OwnerBase is Paragraph)
            {
                ownerBase = this.document_0.Styles.FindByName((A_1.OwnerBase as Paragraph).StyleName) as ParagraphStyle;
            }
            string lFOStyleName = string.Empty;
            if (((A_0 != null) && (A_0.ListFormat.ListType != ListType.NoList)) && !string.IsNullOrEmpty(A_0.ListFormat.CurrentListStyle.Name))
            {
                num2 = this.method_12()[A_0.ListFormat.CurrentListStyle.Name] + 1;
                lFOStyleName = A_0.ListFormat.LFOStyleName;
                if (A_0.ListFormat.HasKey(0))
                {
                    listLevelNumber = A_0.ListFormat.ListLevelNumber;
                }
            }
            while (ownerBase != null)
            {
                if (((num2 == -1) && (ownerBase.ListFormat.CurrentListStyle != null)) && !string.IsNullOrEmpty(ownerBase.ListFormat.CurrentListStyle.Name))
                {
                    num2 = this.method_12()[ownerBase.ListFormat.CurrentListStyle.Name] + 1;
                    lFOStyleName = ownerBase.ListFormat.LFOStyleName;
                }
                if ((listLevelNumber == -1) && ownerBase.ListFormat.HasKey(0))
                {
                    listLevelNumber = ownerBase.ListFormat.ListLevelNumber;
                }
                ownerBase = ownerBase.BaseStyle;
            }
            if (num2 == -1)
            {
                return class2;
            }
            class2.method_1(this.string_24 + BookmarkStart.b("崰䀲", num));
            class2.method_4(num2);
            if (!this.method_13().ContainsKey(num2))
            {
                this.method_13().Add(num2, lFOStyleName);
            }
            else if (string.IsNullOrEmpty(this.method_13()[num2]) && !string.IsNullOrEmpty(lFOStyleName))
            {
                this.method_13()[num2] = lFOStyleName;
            }
            if ((listLevelNumber != -1) && (listLevelNumber < 9))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("堰弲䌴嬶", num));
                class2.method_4(listLevelNumber);
            }
        }
        return class2;
    }

    private void method_65(Table A_0)
    {
        this.int_7++;
        A_0.method_63();
        int num = 0;
        int count = A_0.Rows.Count;
        while (num < count)
        {
            TableRow row = A_0.Rows[num];
            this.method_67(row);
            num++;
        }
        this.int_7--;
    }

    private string method_66(Form2 A_0, Table A_1)
    {
        int num = 14;
        if (A_0 == null)
        {
            return string.Empty;
        }
        using (Class1083 class2 = new Class1083())
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䀳䔵䨷唹䬻娽", num));
            Borders borders = A_0.method_72();
            class2.method_0(this.method_77(borders));
            class2.method_0(this.method_75(A_0.method_74()));
            if (A_0.method_76() > 0f)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䀳䐵強嬹䰻嘽焿牁籃", num));
            }
            if (!A_0.method_73().IsDefault)
            {
                class2.method_0(this.method_80(A_0.method_73(), true));
            }
            string str = A_0.method_78().ToString();
            if (str == BookmarkStart.b("砳匵帷丹", num))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䔳娵", num));
            }
            else if (str == BookmarkStart.b("昳張強刹䠻", num))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䔳䐵", num));
            }
            else if (str == BookmarkStart.b("眳匵嘷丹夻䰽", num))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䔳唵", num));
            }
            else if (str == BookmarkStart.b("縳䌵䬷丹唻堽㤿", num))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䔳尵", num));
            }
            else
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䔳刵", num));
            }
            return class2.ToString();
        }
    }

    private void method_67(TableRow A_0)
    {
        int num = 9;
        string str = this.method_68(A_0.RowFormat);
        if (this.int_7 == 1)
        {
            this.method_6().method_3(str.ToString());
        }
        int num2 = 0;
        int count = A_0.Cells.Count;
        while (num2 < count)
        {
            TableCell cell = A_0.Cells[num2];
            this.method_79(cell);
            num2++;
        }
        if (this.int_7 != 1)
        {
            str = BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("Ԯ", num) + this.string_24 + BookmarkStart.b("䄮吰䀲䄴䌶堸夺儼娾ㅀㅂ⩄㝆㩈", num) + str + this.string_24 + BookmarkStart.b("䄮吰䀲䄴䔶嘸䰺䀼", num);
        }
        this.method_6().method_3(str.ToString());
        if (((A_0.OwnerTable != null) && (A_0.OwnerTable.Owner != null)) && ((A_0.OwnerTable.Owner.OwnerBase != null) && (A_0.OwnerTable.Owner.OwnerBase is TableRow)))
        {
            TableRow ownerBase = A_0.OwnerTable.Owner.OwnerBase as TableRow;
            this.method_6().method_3(this.method_68(ownerBase.RowFormat));
        }
        else
        {
            this.method_6().method_3(BookmarkStart.b("吮", num) + this.string_24 + BookmarkStart.b("崮帰䐲䠴", num));
        }
    }

    private string method_68(RowFormat A_0)
    {
        int num = 3;
        using (Class1083 class2 = new Class1083())
        {
            TableRow ownerRow = A_0.OwnerRow;
            class2.method_1(this.string_24 + BookmarkStart.b("崨太䈬堮唰", num));
            if (((ownerRow != null) && (ownerRow.OwnerTable != null)) && (ownerRow == ownerRow.OwnerTable.LastRow))
            {
                class2.method_1(this.string_24 + BookmarkStart.b("䔨䨪帬嬮䌰尲䈴", num));
            }
            if ((ownerRow != null) && ownerRow.IsHeader)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太䔬䬮䌰", num));
            }
            if (((ownerRow != null) && (ownerRow.OwnerTable != null)) && (ownerRow.OwnerTable.TableStyleName != null))
            {
                foreach (KeyValuePair<string, string> pair in this.method_14())
                {
                    if (ownerRow.OwnerTable.TableStyleName.Replace(BookmarkStart.b("न", num), string.Empty) == pair.Key)
                    {
                        class2.method_1(pair.Value);
                    }
                }
            }
            class2.method_1(this.string_24 + BookmarkStart.b("崨太䨬丮䄰嬲дܶĸ", num));
            int num2 = 0;
            if (A_0.OwnerRow.OwnerTable.TableFormat.RowIndent != float.MinValue)
            {
                CellFormat cellFormat = ownerRow.Cells[0].CellFormat;
                RowFormat tableFormat = A_0.OwnerRow.OwnerTable.TableFormat;
                if (!tableFormat.HasKey(0x6b) && (tableFormat.RowIndent == 0f))
                {
                    num2 = (int) Math.Round((double) ((tableFormat.LeftIndent - tableFormat.Paddings.Left) * 20f));
                }
                else if (cellFormat.SamePaddingsAsTable)
                {
                    num2 = (int) Math.Round((double) ((tableFormat.RowIndent - tableFormat.Paddings.Left) * 20f));
                }
                else
                {
                    num2 = (int) Math.Round((double) ((tableFormat.RowIndent - cellFormat.Paddings.Left) * 20f));
                }
                class2.method_1(this.string_24 + BookmarkStart.b("崨太䄬䨮地䜲", num) + num2.ToString());
            }
            else
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太䄬䨮地䜲ᠴ", num) + (A_0.OwnerRow.OwnerTable.TableFormat.Paddings.Left * 20f));
            }
            if (((ownerRow != null) && (ownerRow.OwnerTable != null)) && (ownerRow.OwnerTable.TableStyleName != null))
            {
                Borders borders2 = ownerRow.OwnerTable.TableStyle.imethod_3().method_72();
                class2.method_0(this.method_77(borders2));
            }
            if (A_0.CellSpacing > -1f)
            {
                class2.method_0(this.method_75(A_0.CellSpacingEx));
            }
            else if (A_0.LeftIndent > 0f)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太䨬丮䄰嬲дܶĸ", num));
            }
            if (A_0.Height != 0f)
            {
                int num7 = (int) Math.Round((double) (ownerRow.Height * 20f));
                if ((ownerRow.HeightType == TableRowHeightType.Exactly) && (num7 > 0))
                {
                    num7 = -num7;
                }
                class2.method_1(this.string_24 + BookmarkStart.b("崨太弬䜮", num) + num7.ToString());
            }
            if ((!A_0.IsAutoResized && (ownerRow != null)) && (ownerRow.OwnerTable != null))
            {
                switch (ownerRow.OwnerTable.PreferredTableWidth.method_51())
                {
                    case FtsWidth.None:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶स", num));
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区഼", num));
                        break;

                    case FtsWidth.Auto:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶स", num));
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区఼", num));
                        break;

                    case FtsWidth.Percentage:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶", num) + ((ownerRow.OwnerTable.PreferredTableWidth.method_49() * 50f)).ToString());
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区༼", num));
                        break;

                    case FtsWidth.Point:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶", num) + ownerRow.OwnerTable.PreferredTableWidth.method_49().ToString());
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区฼", num));
                        break;
                }
            }
            if (ownerRow != null)
            {
                switch (A_0.GridBeforeWidth.method_51())
                {
                    case FtsWidth.None:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶笸଺", num));
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区缼༾", num));
                        break;

                    case FtsWidth.Auto:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区缼฾", num));
                        break;

                    case FtsWidth.Percentage:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区缼ാ", num));
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶笸", num) + ((A_0.GridBeforeWidth.method_49() * 50f)).ToString());
                        break;

                    case FtsWidth.Point:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区缼ా", num));
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶笸", num) + A_0.GridBeforeWidth.method_49().ToString());
                        break;
                }
                switch (A_0.GridAfterWidth.method_51())
                {
                    case FtsWidth.None:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶砸଺", num));
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区簼༾", num));
                        break;

                    case FtsWidth.Auto:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区簼฾", num));
                        break;

                    case FtsWidth.Percentage:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶砸", num) + ((A_0.GridAfterWidth.method_49() * 50f)).ToString());
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区簼ാ", num));
                        break;

                    case FtsWidth.Point:
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太娬砮堰圲䄴弶砸", num) + A_0.GridAfterWidth.method_49().ToString());
                        class2.method_1(this.string_24 + BookmarkStart.b("崨太䬬嬮䈰搲尴匶䴸区簼ా", num));
                        break;
                }
            }
            if (A_0.LayoutType == LayoutType.AutoFit)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太䰬娮䔰尲匴帶䴸਺", num));
            }
            if (!A_0.Paddings.IsDefault)
            {
                class2.method_0(this.method_80(A_0.Paddings, true));
            }
            if (A_0.HorizontalAlignment == RowAlignment.Right)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太尬崮", num));
            }
            else if (A_0.HorizontalAlignment == RowAlignment.Center)
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太尬䰮", num));
            }
            else
            {
                class2.method_1(this.string_24 + BookmarkStart.b("崨太尬䌮", num));
            }
            Borders borders = ((!A_0.Borders.NoBorder || (A_0.Borders.NoBorder && !A_0.Borders.IsDefault)) || ownerRow.OwnerTable.TableFormat.Borders.NoBorder) ? A_0.Borders : ownerRow.OwnerTable.TableFormat.Borders;
            class2.method_0(this.method_77(borders));
            class2.method_1(this.method_69(A_0));
            Section section = this.method_187(ownerRow);
            this.int_6 = ((section == null) || (A_0.LeftIndent != 0f)) ? ((int) Math.Round((double) (A_0.LeftIndent * 20f))) : ((int) Math.Round((double) (section.PageSetup.Margins.Right * 20f)));
            if (ownerRow != null)
            {
                int num4 = 0;
                int count = ownerRow.Cells.Count;
                while (num4 < count)
                {
                    TableCell cell = ownerRow.Cells[num4];
                    if ((cell != null) && (cell.CellFormat != null))
                    {
                        class2.method_1(Environment.NewLine);
                        class2.method_0(this.method_76(cell.CellFormat));
                    }
                    num4++;
                }
            }
            this.int_6 = 0;
            class2.method_1(Environment.NewLine);
            return class2.ToString();
        }
    }

    private string method_69(RowFormat A_0)
    {
        int num = 0;
        if (A_0.WrapTextAround)
        {
            Class1083 class2 = new Class1083();
            class2.method_1(this.method_72(A_0.Positioning.HorizRelationTo));
            class2.method_1(this.method_74(A_0.Positioning.VertRelationTo));
            class2.method_1(this.method_71(A_0.Positioning.HorizPositionAbs, A_0.Positioning.HorizPositionEx));
            class2.method_1(this.method_73(A_0.Positioning.VertPositionAbs, A_0.Positioning.VertPositionEx));
            class2.method_0(this.method_70(A_0.Positioning));
            class2.method_1(this.string_24 + BookmarkStart.b("別䤧䠩弫䀭弯崱䈳䐵吷䨹", num) + (A_0.Positioning.TableOverlap ? BookmarkStart.b("ᘥ", num) : BookmarkStart.b("ᜥ", num)));
            return class2.ToString();
        }
        return string.Empty;
    }

    private Class1082 method_7()
    {
        if (this.class1082_4 == null)
        {
            this.class1082_4 = new Class1082();
        }
        return this.class1082_4;
    }

    private Class1083 method_70(RowFormat.TablePositioning A_0)
    {
        int num = 15;
        Class1083 class2 = new Class1083();
        if (A_0.DistanceFromLeft != 0f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䄴匶弸䤺值䬾㥀㝂ॄ≆⽈㽊", num) + ((A_0.DistanceFromLeft * 20f)).ToString());
        }
        if (A_0.DistanceFromTop != 0f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䄴匶弸䤺值䬾㥀㝂ᅄ⡆㥈", num) + ((A_0.DistanceFromTop * 20f)).ToString());
        }
        if (A_0.DistanceFromRight != 0f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䄴匶弸䤺值䬾㥀㝂ᝄ⹆⹈⍊㥌", num) + ((A_0.DistanceFromRight * 20f)).ToString());
        }
        if (A_0.DistanceFromBottom != 0f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䄴匶弸䤺值䬾㥀㝂݄⡆㵈㽊≌≎", num) + ((A_0.DistanceFromBottom * 20f)).ToString());
        }
        return class2;
    }

    private string method_71(HorizontalPosition A_0, float A_1)
    {
        int num = 12;
        switch (A_0)
        {
            case HorizontalPosition.Left:
                return (this.string_24 + BookmarkStart.b("䘱䐳夵䬷䈹倻", num));

            case HorizontalPosition.Center:
                return (this.string_24 + BookmarkStart.b("䘱䐳夵䬷䈹弻", num));

            case HorizontalPosition.Right:
                return (this.string_24 + BookmarkStart.b("䘱䐳夵䬷䈹主", num));

            case HorizontalPosition.Inside:
                return (this.string_24 + BookmarkStart.b("䘱䐳夵䬷䈹唻", num));

            case HorizontalPosition.Outside:
                return (this.string_24 + BookmarkStart.b("䘱䐳夵䬷䈹医", num));
        }
        float num2 = A_1 * 20f;
        return (this.string_24 + BookmarkStart.b("䘱䐳夵䬷䈹", num) + num2.ToString());
    }

    private string method_72(HorizontalRelation A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case HorizontalRelation.Margin:
                return (this.string_24 + BookmarkStart.b("䐯䈱尳嬵䨷崹", num));

            case HorizontalRelation.Page:
                return (this.string_24 + BookmarkStart.b("䐯䈱尳䘵強", num));
        }
        return (this.string_24 + BookmarkStart.b("䐯䈱尳唵圷嘹", num));
    }

    private string method_73(VerticalPosition A_0, float A_1)
    {
        int num = 0x12;
        switch (A_0)
        {
            case VerticalPosition.Top:
                return (this.string_24 + BookmarkStart.b("䰷䨹医䴽㤿㙁", num));

            case VerticalPosition.Center:
                return (this.string_24 + BookmarkStart.b("䰷䨹医䴽㤿⅁", num));

            case VerticalPosition.Bottom:
                return (this.string_24 + BookmarkStart.b("䰷䨹医䴽㤿⁁", num));

            case VerticalPosition.Inside:
                return (this.string_24 + BookmarkStart.b("䰷䨹医䴽㤿⭁⩃", num));

            case VerticalPosition.Outside:
                return (this.string_24 + BookmarkStart.b("䰷䨹医䴽㤿ⵁㅃ㉅", num));
        }
        float num2 = A_1 * 20f;
        return (this.string_24 + BookmarkStart.b("䰷䨹医䴽㤿", num) + num2.ToString());
    }

    private string method_74(VerticalRelation A_0)
    {
        int num = 15;
        switch (A_0)
        {
            case VerticalRelation.Page:
                return (this.string_24 + BookmarkStart.b("䄴䜶伸䬺娼", num));

            case VerticalRelation.Paragraph:
                return (this.string_24 + BookmarkStart.b("䄴䜶伸䬺尼䴾⁀", num));
        }
        return (this.string_24 + BookmarkStart.b("䄴䜶伸嘺似堾", num));
    }

    private Class1083 method_75(float A_0)
    {
        int num = 0x12;
        Class1083 class2 = new Class1083();
        if (A_0 > -1f)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿⹁", num) + ((int) A_0));
            class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿㙁", num) + ((int) A_0));
            class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿⁁", num) + ((int) A_0));
            class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿ぁ", num) + ((int) A_0));
        }
        class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿⑁⡃畅", num));
        class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿⑁ぃ畅", num));
        class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿⑁♃畅", num));
        class2.method_1(this.string_24 + BookmarkStart.b("䰷䠹伻丽␿⑁㙃畅", num));
        return class2;
    }

    private Class1083 method_76(CellFormat A_0)
    {
        int num = 6;
        Class1083 class2 = new Class1083();
        TableCell ownerBase = A_0.OwnerBase as TableCell;
        TableRow ownerRow = ownerBase.OwnerRow;
        RowFormat rowFormat = ownerRow.RowFormat;
        float clientWidth = ownerRow.method_2().PageSetup.ClientWidth;
        if (ownerBase.CellFormat.HorizontalMerge == CellMerge.Start)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伫䈭崯唱刳", num));
        }
        else if (ownerBase.CellFormat.HorizontalMerge == CellMerge.Continue)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伫䈭崯䀱匳", num));
        }
        if (ownerBase.CellFormat.VerticalMerge == CellMerge.Start)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伫䈭䘯弱匳倵", num));
            class2.method_1(this.method_81(ownerBase.CellFormat.VerticalAlignment));
        }
        else if (ownerBase.CellFormat.VerticalMerge == CellMerge.Continue)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伫䈭䘯弱䘳儵", num));
            class2.method_1(this.method_81(A_0.VerticalAlignment));
        }
        else
        {
            class2.method_1(this.method_81(A_0.VerticalAlignment));
        }
        Borders borders = ((!rowFormat.Borders.NoBorder || (rowFormat.Borders.NoBorder && !rowFormat.Borders.IsDefault)) || ownerRow.OwnerTable.TableFormat.Borders.NoBorder) ? rowFormat.Borders : ownerRow.OwnerTable.TableFormat.Borders;
        if (A_0.Borders.HasBorderTypeValue)
        {
            class2.method_0(this.method_78(ownerBase, borders, null));
        }
        else
        {
            class2.method_0(this.method_78(ownerBase, A_0.Borders, borders));
        }
        if (!A_0.BackColor.IsEmpty)
        {
            class2.method_1(this.method_177(A_0.BackColor, this.string_24 + BookmarkStart.b("伫䈭匯倱䐳圵䰷", num)));
        }
        if (!A_0.TextWrap)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伫䈭縯崱挳䐵夷䨹", num));
        }
        switch (ownerBase.WidthType)
        {
            case FtsWidth.Percentage:
                class2.method_1(this.string_24 + BookmarkStart.b("伫䈭嘯䘱䜳愵儷帹䠻嘽爿", num));
                class2.method_1(this.string_24 + BookmarkStart.b("伫䈭䜯攱崳刵䰷刹", num));
                class2.method_4((int) Math.Round((double) (ownerBase.Scaling * 50f)));
                if (!A_0.SamePaddingsAsTable)
                {
                    class2.method_0(this.method_80(A_0.Paddings, false));
                }
                class2.method_1(this.string_24 + BookmarkStart.b("伫䬭尯帱䰳", num));
                class2.method_4(A_0.Cellx);
                break;

            case FtsWidth.Point:
                class2.method_1(this.string_24 + BookmarkStart.b("伫䈭嘯䘱䜳愵儷帹䠻嘽猿", num));
                class2.method_1(this.string_24 + BookmarkStart.b("伫䈭䜯攱崳刵䰷刹", num));
                class2.method_4((int) Math.Round((double) (ownerBase.Width * 20f)));
                if (!A_0.SamePaddingsAsTable)
                {
                    class2.method_0(this.method_80(A_0.Paddings, false));
                }
                class2.method_1(this.string_24 + BookmarkStart.b("伫䬭尯帱䰳", num));
                class2.method_4(A_0.Cellx);
                break;

            default:
                class2.method_1(this.string_24 + BookmarkStart.b("伫䈭嘯䘱䜳愵儷帹䠻嘽焿", num));
                if (!A_0.SamePaddingsAsTable)
                {
                    class2.method_0(this.method_80(A_0.Paddings, false));
                }
                class2.method_1(this.string_24 + BookmarkStart.b("伫䬭尯帱䰳", num));
                class2.method_4(A_0.Cellx);
                break;
        }
        if (A_0.FitText)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("伫䈭瘯嬱䀳戵崷䈹䠻", num));
        }
        return class2;
    }

    private Class1083 method_77(Borders A_0)
    {
        int num = 4;
        Class1083 class2 = new Class1083();
        if (A_0.Top.IsBorderDefined)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帩師䰭䈯嘱䘳䈵", num));
            class2.method_1(this.method_55(A_0.Top, true));
        }
        if (A_0.Bottom.IsBorderDefined)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帩師䰭䈯嘱䘳吵", num));
            class2.method_1(this.method_55(A_0.Bottom, true));
        }
        if (A_0.Left.IsBorderDefined)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帩師䰭䈯嘱䘳娵", num));
            class2.method_1(this.method_55(A_0.Left, true));
        }
        if (A_0.Right.IsBorderDefined)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帩師䰭䈯嘱䘳䐵", num));
            class2.method_1(this.method_55(A_0.Right, true));
        }
        if (A_0.Horizontal.IsBorderDefined)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帩師䰭䈯嘱䘳帵", num));
            class2.method_1(this.method_55(A_0.Horizontal, true));
        }
        if (A_0.Vertical.IsBorderDefined)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("帩師䰭䈯嘱䘳䀵", num));
            class2.method_1(this.method_55(A_0.Vertical, true));
        }
        return class2;
    }

    private Class1083 method_78(TableCell A_0, Borders A_1, Borders A_2)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(this.string_24 + BookmarkStart.b("䴭尯倱䘳刵䨷丹", 8));
        class2.method_1(this.method_55(A_0.CellFormat.Borders.Top, true));
        class2.method_1(this.string_24 + BookmarkStart.b("䴭尯倱䘳刵䨷堹", 8));
        class2.method_1(this.method_55(A_0.CellFormat.Borders.Bottom, true));
        class2.method_1(this.string_24 + BookmarkStart.b("䴭尯倱䘳刵䨷嘹", 8));
        class2.method_1(this.method_55(A_0.CellFormat.Borders.Left, true));
        class2.method_1(this.string_24 + BookmarkStart.b("䴭尯倱䘳刵䨷䠹", 8));
        class2.method_1(this.method_55(A_0.CellFormat.Borders.Right, true));
        return class2;
    }

    private void method_79(TableCell A_0)
    {
        int num = 2;
        this.method_31(A_0.Items);
        Paragraph paragraph = A_0.method_57();
        CharacterFormat format = (paragraph == null) ? A_0.CharacterFormat : paragraph.BreakCharacterFormat;
        if (this.int_7 > 1)
        {
            this.method_6().method_3(string.Concat(new object[] { BookmarkStart.b("匧", num), this.method_37(format), this.string_24, BookmarkStart.b("䘧伩弫娭匯圱堳娵䔷", num) }));
        }
        else
        {
            this.method_6().method_3(string.Concat(new object[] { BookmarkStart.b("匧", num), this.method_37(format), this.string_24, BookmarkStart.b("䬧伩䀫䈭䴯", num) }));
        }
        this.method_6().method_3(Environment.NewLine);
    }

    private Class1082 method_8()
    {
        if (this.class1082_5 == null)
        {
            this.class1082_5 = new Class1082();
        }
        return this.class1082_5;
    }

    private Class1083 method_80(Paddings A_0, bool A_1)
    {
        int num = 7;
        Class1083 class2 = new Class1083();
        if (A_1)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶唸", num));
            class2.method_4((int) Math.Round((double) (A_0.Left * 20f)));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶䴸", num));
            class2.method_4((int) Math.Round((double) (A_0.Top * 20f)));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶嬸", num));
            class2.method_4((int) Math.Round((double) (A_0.Bottom * 20f)));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶䬸", num));
            class2.method_4((int) Math.Round((double) (A_0.Right * 20f)));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶弸夺฼", num));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶弸场฼", num));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶弸䤺฼", num));
            class2.method_1(this.string_24 + BookmarkStart.b("夬崮䄰刲儴匶弸伺฼", num));
            return class2;
        }
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴䌶", num));
        class2.method_4((int) Math.Round((double) (A_0.Left * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴嬶", num));
        class2.method_4((int) Math.Round((double) (A_0.Top * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴唶", num));
        class2.method_4((int) Math.Round((double) (A_0.Bottom * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴䔶", num));
        class2.method_4((int) Math.Round((double) (A_0.Right * 20f)));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴儶唸࠺", num));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴儶䴸࠺", num));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴儶嬸࠺", num));
        class2.method_1(this.string_24 + BookmarkStart.b("丬䌮䄰刲儴儶䬸࠺", num));
        return class2;
    }

    private string method_81(VerticalAlignment A_0)
    {
        int num = 0x10;
        if (A_0 == VerticalAlignment.Top)
        {
            return (this.string_24 + BookmarkStart.b("唵吷䰹夻䰽㐿⍁⡃㉅", num));
        }
        if (A_0 == VerticalAlignment.Middle)
        {
            return (this.string_24 + BookmarkStart.b("唵吷䰹夻䰽㐿⍁⡃╅", num));
        }
        if (A_0 == VerticalAlignment.Bottom)
        {
            return (this.string_24 + BookmarkStart.b("唵吷䰹夻䰽㐿⍁⡃⑅", num));
        }
        return string.Empty;
    }

    private bool method_82(TableCell A_0, BorderType A_1)
    {
        TableRow ownerRow = A_0.OwnerRow;
        switch (A_1)
        {
            case BorderType.Right:
                if (A_0.NextSibling is TableCell)
                {
                    return true;
                }
                break;

            case BorderType.Left:
                if (A_0.PreviousSibling is TableCell)
                {
                    return true;
                }
                break;

            case BorderType.Top:
                if (ownerRow.PreviousSibling is TableRow)
                {
                    return true;
                }
                break;

            case BorderType.Bottom:
                if (ownerRow.NextSibling is TableRow)
                {
                    return true;
                }
                break;
        }
        return false;
    }

    private string method_83(bool A_0)
    {
        int num = 5;
        if (A_0)
        {
            return BookmarkStart.b("ᨪ", num);
        }
        return BookmarkStart.b("ᬪ", num);
    }

    private bool method_84(ParagraphBase A_0)
    {
        if (((A_0 is DocPicture) && (this.stack_1 != null)) && (this.stack_1.Count > 0))
        {
            Field field2 = this.stack_1.Peek();
            if ((field2 != null) && (field2.Type == FieldType.FieldEmbed))
            {
                return true;
            }
            if ((field2 != null) && (field2.Type == FieldType.FieldShape))
            {
                return false;
            }
        }
        if (!(A_0 is Field) && !(A_0 is FieldMark))
        {
            return ((this.stack_1 != null) && (this.stack_1.Count != 0));
        }
        if ((this.stack_1 != null) && (this.stack_1.Count > 0))
        {
            Field field = this.stack_1.Peek();
            if ((field != null) && (field.Type == FieldType.FieldEmbed))
            {
                if ((A_0 is FieldMark) && ((A_0 as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    this.stack_1.Pop();
                }
                return true;
            }
        }
        return false;
    }

    private void method_85(ParagraphBase A_0)
    {
        if (!this.method_84(A_0))
        {
            switch (A_0.DocumentObjectType)
            {
                case DocumentObjectType.StructureDocumentTagInline:
                    foreach (ParagraphBase base2 in (A_0 as StructureDocumentTagInline).SDTContent.Items)
                    {
                        this.method_85(base2);
                    }
                    return;

                case DocumentObjectType.StructureDocumentTagRow:
                case DocumentObjectType.StructureDocumentTagCell:
                case DocumentObjectType.SDTBlockContent:
                case DocumentObjectType.SDTInlineContent:
                case DocumentObjectType.SDTRowContent:
                case DocumentObjectType.SDTCellContent:
                case DocumentObjectType.Table:
                case DocumentObjectType.TableRow:
                case DocumentObjectType.TableCell:
                case DocumentObjectType.SeqField:
                case DocumentObjectType.EmbededField:
                case DocumentObjectType.ControlField:
                case DocumentObjectType.ShapeLine:
                case DocumentObjectType.ShapePath:
                case DocumentObjectType.ShapeRect:
                case DocumentObjectType.Undefined:
                case DocumentObjectType.CommentEnd:
                case DocumentObjectType.CustomXml:
                case DocumentObjectType.SmartTag:
                case DocumentObjectType.OfficeMath:
                case DocumentObjectType.System:
                    return;

                case DocumentObjectType.TextRange:
                    this.method_6().method_2(this.method_103(A_0 as TextRange));
                    return;

                case DocumentObjectType.Picture:
                    this.method_6().method_2(this.method_112(A_0 as DocPicture));
                    return;

                case DocumentObjectType.Field:
                    this.method_6().method_6(this.method_101(A_0 as Field));
                    return;

                case DocumentObjectType.FieldMark:
                    this.method_100(A_0 as FieldMark);
                    return;

                case DocumentObjectType.MergeField:
                    this.method_95(A_0 as MergeField);
                    return;

                case DocumentObjectType.TextFormField:
                    this.method_6().method_6(this.method_158(A_0 as TextFormField));
                    return;

                case DocumentObjectType.DropDownFormField:
                    this.method_6().method_6(this.method_161(A_0 as DropDownFormField));
                    return;

                case DocumentObjectType.CheckBox:
                    this.method_6().method_6(this.method_160(A_0 as CheckBoxFormField));
                    return;

                case DocumentObjectType.BookmarkStart:
                    this.method_106(A_0 as BookmarkStart);
                    return;

                case DocumentObjectType.BookmarkEnd:
                    this.method_105(A_0 as BookmarkEnd);
                    return;

                case DocumentObjectType.PermissionStart:
                    this.method_107(A_0 as PermissionStart);
                    return;

                case DocumentObjectType.PermissionEnd:
                    this.method_108(A_0 as PermissionEnd);
                    return;

                case DocumentObjectType.Shape:
                    this.method_90(A_0 as ShapeObject);
                    return;

                case DocumentObjectType.ShapeGroup:
                    this.method_87(A_0 as ShapeObject);
                    return;

                case DocumentObjectType.Comment:
                    this.method_163(A_0 as Comment);
                    return;

                case DocumentObjectType.Footnote:
                    this.method_97(A_0 as Footnote);
                    return;

                case DocumentObjectType.TextBox:
                    this.method_132(A_0 as TextBox);
                    return;

                case DocumentObjectType.Break:
                    this.method_102(A_0 as Break);
                    return;

                case DocumentObjectType.Symbol:
                    this.method_96(A_0 as Symbol);
                    return;

                case DocumentObjectType.TOC:
                    this.method_110(A_0 as TableOfContent);
                    return;

                case DocumentObjectType.XmlParaItem:
                    this.method_86(A_0 as Class6);
                    return;

                case DocumentObjectType.CommentMark:
                    this.method_6().method_6(this.method_162(A_0 as CommentMark));
                    return;

                case DocumentObjectType.OleObject:
                    this.method_6().method_6(this.method_111(A_0 as DocOleObject));
                    return;

                case DocumentObjectType.Ruby:
                {
                    Field field = (A_0 as Class2).method_61();
                    this.method_6().method_6(this.method_101(field));
                    this.method_100(field.End);
                    return;
                }
            }
        }
    }

    private void method_86(Class6 A_0)
    {
        if (A_0.method_32() != null)
        {
            ShapeBase base2 = A_0.method_32();
            if (base2.ShapeType == ShapeType.Group)
            {
                this.method_87(base2);
            }
            else
            {
                this.method_90(base2);
            }
        }
    }

    private void method_87(ShapeBase A_0)
    {
        int num = 0x10;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("䴵", 0x10) + this.string_24 + BookmarkStart.b("䔵倷䨹嬻䰽〿", 0x10));
        class2.method_1(BookmarkStart.b("䴵", 0x10) + this.string_24 + BookmarkStart.b("ᰵ", 0x10) + this.string_24 + BookmarkStart.b("䔵倷䨹唻倽㌿㙁", 0x10));
        if ((A_0.Owner != null) && (A_0.Owner is ShapeGroup))
        {
            class2.method_1(this.method_125(BookmarkStart.b("䐵崷嘹瀻嬽☿㙁", num), A_0.Left.ToString()));
            class2.method_1(this.method_125(BookmarkStart.b("䐵崷嘹栻儽〿", num), A_0.Top.ToString()));
            double num4 = A_0.Left + A_0.Width;
            class2.method_1(this.method_125(BookmarkStart.b("䐵崷嘹渻圽✿⩁ぃ", num), num4.ToString()));
            double num5 = A_0.Top + A_0.Height;
            class2.method_1(this.method_125(BookmarkStart.b("䐵崷嘹縻儽㐿㙁⭃⭅", num), num5.ToString()));
            class2.method_1(this.method_125(BookmarkStart.b("倵樷弹倻砽ⰿ⭁㑃ๅ", num), this.method_83((bool) A_0.GetShapeAttribute(0x338))));
            class2.method_1(this.method_125(BookmarkStart.b("倵樷弹倻砽ⰿ⭁㑃၅", num), this.method_83((bool) A_0.GetShapeAttribute(0x339))));
        }
        else
        {
            class2.method_0(this.method_91(A_0));
            class2.method_1(this.method_125(BookmarkStart.b("倵縷嘹唻丽࠿", num), this.method_83((bool) A_0.GetShapeAttribute(0x338))));
            class2.method_1(this.method_125(BookmarkStart.b("倵縷嘹唻丽ᘿ", num), this.method_83((bool) A_0.GetShapeAttribute(0x339))));
        }
        class2.method_1(this.method_125(BookmarkStart.b("儵䨷唹䤻丽ి❁≃㉅", num), A_0.CoordOriginX.ToString()));
        class2.method_1(this.method_125(BookmarkStart.b("儵䨷唹䤻丽ᐿⵁ㑃", num), A_0.CoordOriginY.ToString()));
        int num8 = A_0.CoordOriginX + A_0.CoordSizeWidth;
        class2.method_1(this.method_125(BookmarkStart.b("儵䨷唹䤻丽ሿ⭁⍃⹅㱇", num), num8.ToString()));
        int num9 = A_0.CoordOriginY + A_0.CoordSizeHeight;
        class2.method_1(this.method_125(BookmarkStart.b("儵䨷唹䤻丽ȿⵁぃ㉅❇❉", num), num9.ToString()));
        class2.method_1(this.method_125(BookmarkStart.b("刵倷崹䠻", num), A_0.ZOrder.ToString()));
        class2.method_1(this.method_125(BookmarkStart.b("倵琷嬹䔻儽㔿㙁ൃ⡅େ⽉⁋≍", num), this.method_83(A_0.AllowInCell)));
        this.method_6().method_2(class2);
        class2 = new Class1083();
        foreach (ShapeObject obj2 in A_0.ChildObjects)
        {
            if (obj2.ShapeType != ShapeType.Group)
            {
                this.method_90(obj2);
            }
            else
            {
                this.method_87(obj2);
            }
        }
        class2.method_1(BookmarkStart.b("䬵䔷", num));
        class2.method_1(Environment.NewLine);
        this.method_6().method_2(class2);
    }

    private Class1083 method_88(ShapeBase A_0)
    {
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("圫", 6) + this.string_24 + BookmarkStart.b("䨫䜭唯帱倳", 6) + this.string_24 + BookmarkStart.b("䨫䈭启帱嬳唵匷", 6));
        class2.method_1(BookmarkStart.b("圫", 6) + this.string_24 + BookmarkStart.b("ث", 6) + this.string_24 + BookmarkStart.b("䨫䈭启嬱娳䔵䰷ᨹ", 6));
        class2.method_1(BookmarkStart.b("圫", 6));
        class2.method_0(this.method_37(A_0.CharacterFormat));
        class2.method_1(BookmarkStart.b("ఫ紭砯猱搳猵ᠷ昹总ᐽ怿ཁŃᑅཇཉੋōɏὑᕓɕ硗", 6));
        class2.method_1(BookmarkStart.b("儫", 6));
        class2.method_1(BookmarkStart.b("儫", 6));
        class2.method_1(BookmarkStart.b("圫", 6) + this.string_24 + BookmarkStart.b("䨫䈭启䀱䜳娵䰷ᨹ", 6));
        class2.method_1(BookmarkStart.b("圫", 6));
        class2.method_0(this.method_37(A_0.CharacterFormat));
        class2.method_0(this.method_89(A_0));
        class2.method_1(BookmarkStart.b("儫", 6));
        class2.method_1(BookmarkStart.b("儫", 6));
        class2.method_1(BookmarkStart.b("儫", 6));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private Class1083 method_89(ShapeBase A_0)
    {
        int num = 14;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("伳", 14) + this.string_24 + BookmarkStart.b("䜳帵䠷", 14));
        class2.method_1(BookmarkStart.b("伳", 14) + this.string_24 + BookmarkStart.b("ḳ", 14) + this.string_24 + BookmarkStart.b("䜳帵䠷匹刻䴽㐿", 14));
        if ((A_0.Owner == null) || !(A_0.Owner is ShapeGroup))
        {
            class2.method_0(this.method_91(A_0));
        }
        class2.method_0(this.method_92(A_0));
        class2.method_1(BookmarkStart.b("䤳", num));
        class2.method_1(Environment.NewLine);
        if ((A_0 as ShapeObject).ChildObjects.Count > 0)
        {
            class2.method_1(BookmarkStart.b("伳", num) + this.string_24 + BookmarkStart.b("䜳帵䠷丹䐻䨽", num));
            this.method_6().method_2(class2);
            this.method_31((A_0 as ShapeObject).InternerTextbox.Body.Items);
            class2 = new Class1083();
            class2.method_1(BookmarkStart.b("䤳", num));
            class2.method_1(Environment.NewLine);
        }
        class2.method_1(BookmarkStart.b("䤳", num));
        class2.method_1(Environment.NewLine);
        return class2;
    }

    private Class1082 method_9()
    {
        if (this.class1082_6 == null)
        {
            this.class1082_6 = new Class1082();
        }
        return this.class1082_6;
    }

    private void method_90(ShapeBase A_0)
    {
        if (A_0.TextWrappingStyle == TextWrappingStyle.Inline)
        {
            this.method_6().method_2(this.method_88(A_0));
        }
        else
        {
            this.method_6().method_2(this.method_89(A_0));
        }
    }

    private Class1083 method_91(ShapeBase A_0)
    {
        int num = 6;
        Class1083 class2 = new Class1083();
        class2.method_0(this.method_131((float) A_0.Left, (float) A_0.Top, (int) Math.Round((double) (A_0.Width * 20.0)), (int) Math.Round((double) (A_0.Height * 20.0))));
        if ((A_0 as ShapeObject).IsHeaderAutoShape)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯吱尳刵䨷ହ", num));
        }
        else
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯吱尳刵䨷ਹ", num));
        }
        if (A_0.HorizontalOrigin == HorizontalOrigin.Page)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱䰳䘵夷崹夻", num));
        }
        else if (A_0.HorizontalOrigin == HorizontalOrigin.Margin)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱䰳嬵夷䠹嬻圽⸿", num));
        }
        else if (A_0.HorizontalOrigin == HorizontalOrigin.Column)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱䰳唵圷嘹䤻匽⸿", num));
        }
        if (A_0.VerticalOrigin == VerticalOrigin.Page)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱䴳䘵夷崹夻", num));
        }
        else if (A_0.VerticalOrigin == VerticalOrigin.Margin)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱䴳嬵夷䠹嬻圽⸿", num));
        }
        else if (A_0.VerticalOrigin == VerticalOrigin.Paragraph)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯倱䴳䘵夷䠹崻", num));
        }
        class2.method_1(this.method_123((TextWrappingStyle) A_0.GetShapeAttribute(0x1001), A_0.TextWrappingType));
        if (A_0.BehindText)
        {
            class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯吱嘳娵伷丹䐻䨽焿", num));
            return class2;
        }
        class2.method_1(this.string_24 + BookmarkStart.b("弫䘭䀯吱嘳娵伷丹䐻䨽瀿", num));
        return class2;
    }

    private Class1083 method_92(ShapeBase A_0)
    {
        int num = 2;
        Class1083 class2 = new Class1083();
        Type type = typeof(Class302);
        foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
        {
            int propertyKey = (int) info.GetValue(info.FieldType);
            if (A_0.ShapePr.HasValue(propertyKey) && (Enum.GetName(typeof(rtfShapeAttr), propertyKey) != null))
            {
                switch (propertyKey)
                {
                    case 0x145:
                    {
                        Class891[] shapeAttribute = (Class891[]) A_0.GetShapeAttribute(0x145);
                        class2.method_0(this.method_126(BookmarkStart.b("堧簩䤫尭䐯嬱圳張崷䤹", num), this.method_94(shapeAttribute)));
                        continue;
                    }
                    case 0x146:
                    {
                        Class679[] classArray3 = (Class679[]) A_0.GetShapeAttribute(0x146);
                        class2.method_0(this.method_126(BookmarkStart.b("堧礩䤫䤭崯圱娳䈵焷吹娻儽", num), this.method_93(classArray3)));
                        continue;
                    }
                    case 0x180:
                    {
                        int num10 = (int) A_0.GetShapeAttribute(0x180);
                        class2.method_1(this.method_125(BookmarkStart.b("丧䌩䀫䈭搯䬱䐳匵", num), num10.ToString()));
                        DocPicture picture = new DocPicture(this.document_0);
                        if (((byte[]) A_0.GetShapeAttribute(0x100f)) != null)
                        {
                            picture.LoadImage((byte[]) A_0.GetShapeAttribute(0x100f));
                            class2.method_0(this.method_126(BookmarkStart.b("丧䌩䀫䈭爯帱崳䘵", num), this.method_117(picture)));
                        }
                        continue;
                    }
                    case 0x338:
                    {
                        if ((A_0.Owner == null) || !(A_0.Owner is ShapeGroup))
                        {
                            goto Label_0620;
                        }
                        class2.method_1(this.method_125(BookmarkStart.b("丧砩䤫䈭瘯帱崳䘵瀷", num), this.method_83((bool) A_0.GetShapeAttribute(0x338))));
                        continue;
                    }
                    case 0x339:
                    {
                        if ((A_0.Owner == null) || !(A_0.Owner is ShapeGroup))
                        {
                            goto Label_0695;
                        }
                        class2.method_1(this.method_125(BookmarkStart.b("丧砩䤫䈭瘯帱崳䘵渷", num), this.method_83((bool) A_0.GetShapeAttribute(0x339))));
                        continue;
                    }
                    case 0x383:
                    {
                        Class891[] classArray = (Class891[]) A_0.GetShapeAttribute(0x383);
                        class2.method_0(this.method_126(BookmarkStart.b("堧紩師伭䀯戱嬳娵䄷崹医倽ᘿ❁㙃㉅ⅇ⥉⥋㵍", num), this.method_94(classArray)));
                        continue;
                    }
                    case 0x101d:
                    {
                        if (A_0.ShapeType == ShapeType.NonPrimitive)
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("伧伩䌫戭唯吱䀳", num), A_0.CoordOriginX.ToString()));
                        }
                        continue;
                    }
                    case 0x101e:
                    {
                        if (A_0.ShapeType == ShapeType.NonPrimitive)
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("伧伩䌫稭弯䈱", num), A_0.CoordOriginY.ToString()));
                        }
                        continue;
                    }
                    case 0x101f:
                    {
                        if (A_0.ShapeType == ShapeType.NonPrimitive)
                        {
                            int num9 = A_0.CoordOriginX + A_0.CoordSizeWidth;
                            class2.method_1(this.method_125(BookmarkStart.b("伧伩䌫簭夯唱尳䈵", num), num9.ToString()));
                        }
                        continue;
                    }
                    case 0x1020:
                    {
                        if (A_0.ShapeType == ShapeType.NonPrimitive)
                        {
                            int num13 = A_0.CoordOriginY + A_0.CoordSizeHeight;
                            class2.method_1(this.method_125(BookmarkStart.b("伧伩䌫氭弯䘱䀳夵唷", num), num13.ToString()));
                        }
                        continue;
                    }
                    case 0x1021:
                    {
                        if ((A_0.Owner != null) && (A_0.Owner is ShapeGroup))
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("娧伩䀫戭唯吱䀳", num), A_0.Left.ToString()));
                        }
                        continue;
                    }
                    case 0x1022:
                    {
                        if ((A_0.Owner != null) && (A_0.Owner is ShapeGroup))
                        {
                            class2.method_1(this.method_125(BookmarkStart.b("娧伩䀫稭弯䈱", num), A_0.Top.ToString()));
                        }
                        continue;
                    }
                    case 0x1023:
                    {
                        if ((A_0.Owner != null) && (A_0.Owner is ShapeGroup))
                        {
                            double num16 = A_0.Left + A_0.Width;
                            class2.method_1(this.method_125(BookmarkStart.b("娧伩䀫簭夯唱尳䈵", num), num16.ToString()));
                        }
                        continue;
                    }
                    case 0x1024:
                    {
                        if ((A_0.Owner != null) && (A_0.Owner is ShapeGroup))
                        {
                            double num5 = A_0.Top + A_0.Height;
                            class2.method_1(this.method_125(BookmarkStart.b("娧伩䀫氭弯䘱䀳夵唷", num), num5.ToString()));
                        }
                        continue;
                    }
                }
                if (A_0.ShapePr.method_31(propertyKey) is bool)
                {
                    class2.method_1(this.method_125(Enum.GetName(typeof(rtfShapeAttr), propertyKey), this.method_83((bool) A_0.ShapePr.method_31(propertyKey))));
                }
                else if (A_0.ShapePr.method_31(propertyKey) is Color)
                {
                    class2.method_1(this.method_125(Enum.GetName(typeof(rtfShapeAttr), propertyKey), this.method_169((Color) A_0.ShapePr.method_31(propertyKey))));
                }
                else if (A_0.ShapePr.method_31(propertyKey) is float)
                {
                    float num8 = ((float) A_0.ShapePr.method_31(propertyKey)) * 12700f;
                    class2.method_1(this.method_125(Enum.GetName(typeof(rtfShapeAttr), propertyKey), num8.ToString()));
                }
                else if (A_0.ShapePr.method_31(propertyKey) is long)
                {
                    long num7 = (long) A_0.ShapePr.method_31(propertyKey);
                    class2.method_1(this.method_125(Enum.GetName(typeof(rtfShapeAttr), propertyKey), num7.ToString()));
                }
                else
                {
                    int num14 = (int) A_0.ShapePr.method_31(propertyKey);
                    class2.method_1(this.method_125(Enum.GetName(typeof(rtfShapeAttr), propertyKey), num14.ToString()));
                }
            }
            continue;
        Label_0620:
            class2.method_1(this.method_125(BookmarkStart.b("丧氩䀫䜭䀯稱", num), this.method_83((bool) A_0.GetShapeAttribute(0x338))));
            continue;
        Label_0695:
            class2.method_1(this.method_125(BookmarkStart.b("丧氩䀫䜭䀯搱", num), this.method_83((bool) A_0.GetShapeAttribute(0x339))));
        }
        return class2;
    }

    private Class1083 method_93(Class679[] A_0)
    {
        int num = 0x13;
        Class1083 class2 = new Class1083();
        class2.method_1(((int) A_0[0].method_0()).ToString() + BookmarkStart.b("ȸ", 0x13));
        class2.method_1(A_0.Length.ToString() + BookmarkStart.b("ȸ", 0x13));
        foreach (Class679 class3 in A_0)
        {
            class2.method_1(Class781.smethod_4(class3).ToString());
            class2.method_1(BookmarkStart.b("ȸ", num));
        }
        class2.method_8(class2.method_10() - 1, 1);
        return class2;
    }

    private Class1083 method_94(Class891[] A_0)
    {
        int num = 7;
        Class1083 class2 = new Class1083();
        class2.method_1(BookmarkStart.b("ᔬᐮ", 7) + A_0.Length.ToString() + BookmarkStart.b("ᘬ", 7));
        foreach (Class891 class3 in A_0)
        {
            class2.method_1(BookmarkStart.b("Ԭ", num));
            class2.method_1(class3.method_0().ToString());
            class2.method_1(BookmarkStart.b("Ĭ", num));
            class2.method_1(class3.method_1().ToString());
            class2.method_1(BookmarkStart.b("Ьᐮ", num));
        }
        class2.method_8(class2.method_10() - 1, 1);
        return class2;
    }

    private void method_95(MergeField A_0)
    {
        int num = 0;
        if (A_0.ConvertedToText && (A_0.Text != null))
        {
            this.method_6().method_2(this.method_103(A_0));
        }
        else
        {
            Class1082 class2 = new Class1082();
            class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("䀥䄧伩䀫䨭", num));
            if (A_0.IsLocked)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䀥䐧丩䀫䄭匯失", num));
            }
            class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("థ", num) + this.string_24 + BookmarkStart.b("䀥䐧丩䔫䀭䌯䘱ᐳ䴵", num));
            class2.method_2(this.method_37(A_0.CharacterFormat));
            class2.method_3(BookmarkStart.b("إ", num));
            class2.method_3(this.method_168(A_0.Type));
            if (!string.IsNullOrEmpty(A_0.Value))
            {
                class2.method_3(A_0.Value);
            }
            else
            {
                class2.method_3(A_0.FieldName);
            }
            class2.method_3(BookmarkStart.b("إ", num) + this.string_24 + this.string_24 + BookmarkStart.b("థ", num) + A_0.FormattingString.Replace(BookmarkStart.b("稥ȧ", num), string.Empty));
            class2.method_3(BookmarkStart.b("嬥唧", num));
            class2.method_3(BookmarkStart.b("崥", num) + this.string_24 + BookmarkStart.b("䀥䐧丩師崭尯䘱伳", num));
            string str = A_0.TextBefore + A_0.Text + A_0.TextAfter;
            class2.method_2(this.method_185(A_0.CharacterFormat, this.method_183(str)));
            class2.method_3(BookmarkStart.b("嬥唧", num));
            class2.method_3(BookmarkStart.b("嬥", num));
            this.method_6().method_6(class2);
        }
    }

    private void method_96(Symbol A_0)
    {
        int num = 2;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("匧", 2));
        class2.method_2(this.method_37(A_0.CharacterFormat));
        class2.method_3(BookmarkStart.b("匧", 2) + this.string_24 + BookmarkStart.b("丧䌩䤫䈭启䤱", 2) + this.string_24 + BookmarkStart.b("ȧ", 2) + this.string_24 + BookmarkStart.b("丧䘩䠫䜭帯䄱䀳ᘵ欷挹焻簽༿แ摃", 2));
        class2.method_3(A_0.CharacterCode.ToString());
        class2.method_3(string.Concat(new object[] { BookmarkStart.b("ࠧ", 2), this.string_24, this.string_24, BookmarkStart.b("丧਩", 2), '"', A_0.FontName, '"', BookmarkStart.b("唧", 2) }));
        class2.method_3(BookmarkStart.b("匧", 2) + this.string_24 + BookmarkStart.b("丧䘩䠫尭䌯帱䀳", 2) + this.method_172(false, A_0.FontName));
        if (A_0.CharacterFormat.HasValue(190))
        {
            class2.method_3(this.string_24 + BookmarkStart.b("丧天", num));
            class2.method_5(A_0.CharacterFormat.FontSize * 2f);
        }
        class2.method_3(BookmarkStart.b("唧", num));
        class2.method_3(BookmarkStart.b("唧圩", num));
        this.method_6().method_6(class2);
    }

    private void method_97(Footnote A_0)
    {
        int num = 6;
        Class1082 class2 = new Class1082();
        class2.method_3(BookmarkStart.b("圫", 6));
        if (string.IsNullOrEmpty(A_0.CustomMarker) && !A_0.CustomMarkerIsSymbol)
        {
            class2.method_2(this.method_37(A_0.CharacterFormat));
            class2.method_3(this.string_24 + BookmarkStart.b("伫䘭嘯䘱娳", num));
        }
        else if (A_0.CustomMarkerIsSymbol)
        {
            class2.method_2(this.method_37(A_0.MarkerCharacterFormat));
            Field field = new Field(this.document_0) {
                Type = FieldType.FieldSymbol,
                m_fieldValue = A_0.SymbolCode.ToString(),
                m_formattingString = this.string_24 + this.string_24 + BookmarkStart.b("䨫อ振䬱夳吵圷嘹", num)
            };
            class2.method_6(this.method_101(field));
            class2.method_3(BookmarkStart.b("儫", num));
        }
        else
        {
            class2.method_2(this.method_37(A_0.MarkerCharacterFormat));
            class2.method_3(BookmarkStart.b("ఫ", num) + A_0.CustomMarker);
        }
        class2.method_3(BookmarkStart.b("圫", num) + this.string_24 + BookmarkStart.b("䨫䄭弯䘱娳夵䰷弹", num));
        if (A_0.FootnoteType == FootnoteType.Endnote)
        {
            class2.method_3(this.string_24 + BookmarkStart.b("䨫娭帯匱堳䈵", num));
        }
        class2.method_3(Environment.NewLine);
        this.method_6().method_6(class2);
        int num2 = this.int_7;
        this.int_7 = 0;
        this.method_31(A_0.TextBody.Items);
        this.int_7 = num2;
        this.method_6().method_3(BookmarkStart.b("儫匭", num));
        this.method_6().method_3(Environment.NewLine);
        if (A_0.FootnoteType == FootnoteType.Footnote)
        {
            this.method_98();
        }
        else
        {
            this.method_99();
        }
    }

    private void method_98()
    {
        int num = 10;
        if (!this.bool_0)
        {
            this.bool_0 = true;
            Class1082 class2 = new Class1082();
            if (this.document_0.FootnoteOptions.RestartRule == FootnoteRestartRule.DoNotRestart)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵䨷䤹䠻崽⼿ⱁぃ", num));
            }
            else if (this.document_0.FootnoteOptions.RestartRule == FootnoteRestartRule.RestartPage)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵䨷䤹䠻丽✿", num));
            }
            else if (this.document_0.FootnoteOptions.RestartRule == FootnoteRestartRule.RestartSection)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵䨷弹伻䨽ℿぁぃ", num));
            }
            class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵䬷丹崻䰽㐿", num));
            class2.method_4(this.document_0.FootnoteOptions.StartNumber);
            switch (this.document_0.FootnoteOptions.NumberFormat)
            {
                case FootnoteNumberFormat.Arabic:
                    class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵嘷嬹主", num));
                    break;

                case FootnoteNumberFormat.UpperCaseRoman:
                    class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵嘷䠹䤻崽", num));
                    break;

                case FootnoteNumberFormat.LowerCaseRoman:
                    class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵嘷䠹倻崽", num));
                    break;

                case FootnoteNumberFormat.UpperCaseLetter:
                    class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵嘷嬹䤻崽", num));
                    break;

                case FootnoteNumberFormat.LowerCaseLetter:
                    class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵嘷嬹倻崽", num));
                    break;

                default:
                    class2.method_3(this.string_24 + BookmarkStart.b("䌯吱䀳堵嘷夹吻圽", num));
                    break;
            }
            if (this.document_0.FootnoteOptions.Position == FootnotePosition.PrintAtBottomOfPage)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("嘯䘱娳吵刷", num));
            }
            else if (this.document_0.FootnoteOptions.Position == FootnotePosition.PrintImmediatelyBeneathText)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("嘯䘱娳䈵刷", num));
            }
            else if (this.document_0.FootnoteOptions.Position == FootnotePosition.PrintAsEndOfSection)
            {
                if (this.document_0.EndnoteOptions.Position == FootnotePosition.PrintAsEndOfDocument)
                {
                    class2.method_3(this.string_24 + BookmarkStart.b("唯就倳刵圷夹", num));
                }
                else if (this.document_0.EndnoteOptions.Position == FootnotePosition.PrintAsEndOfDocument)
                {
                    class2.method_3(this.string_24 + BookmarkStart.b("唯就倳堵圷丹夻䴽", num));
                }
            }
            this.method_7().method_6(class2);
        }
    }

    private void method_99()
    {
        int num = 2;
        if (!this.bool_1)
        {
            this.bool_1 = true;
            Class1082 class2 = new Class1082();
            if (this.document_0.EndnoteOptions.RestartRule == FootnoteRestartRule.DoNotRestart)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯䀱䜳䈵嬷唹刻䨽", num));
            }
            else if (this.document_0.EndnoteOptions.RestartRule == FootnoteRestartRule.RestartSection)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯䀱儳䔵䰷嬹主䨽", num));
            }
            class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯䄱䀳圵䨷丹", num));
            class2.method_4(this.document_0.EndnoteOptions.StartNumber);
            switch (this.document_0.EndnoteOptions.NumberFormat)
            {
                case FootnoteNumberFormat.Arabic:
                    class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯就唳䐵", num));
                    break;

                case FootnoteNumberFormat.UpperCaseRoman:
                    class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯就䘳䌵嬷", num));
                    break;

                case FootnoteNumberFormat.LowerCaseRoman:
                    class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯就䘳娵嬷", num));
                    break;

                case FootnoteNumberFormat.UpperCaseLetter:
                    class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯就唳䌵嬷", num));
                    break;

                case FootnoteNumberFormat.LowerCaseLetter:
                    class2.method_3(this.string_24 + BookmarkStart.b("嬧䬩䨫娭帯就唳娵嬷", num));
                    break;
            }
            if (this.document_0.EndnoteOptions.Position == FootnotePosition.PrintAsEndOfDocument)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䤧伩䈫䨭启崱圳", num));
            }
            else if (this.document_0.EndnoteOptions.Position == FootnotePosition.PrintAsEndOfSection)
            {
                class2.method_3(this.string_24 + BookmarkStart.b("䤧伩䈫䨭帯崱䀳匵䬷", num));
            }
            this.method_7().method_6(class2);
        }
    }

    internal static string smethod_0(byte[] A_0)
    {
        int num = 14;
        if ((A_0 == null) || ((A_0 != null) && (A_0.Length == 0)))
        {
            return string.Empty;
        }
        Class1083 class2 = new Class1083();
        int index = 0;
        int length = A_0.Length;
        while (index < length)
        {
            class2.method_1(A_0[index].ToString(BookmarkStart.b("䰳е", num)));
            index++;
        }
        return class2.ToString();
    }

    void IDisposable.Dispose()
    {
        if (this.streamWriter_0 != null)
        {
            this.streamWriter_0 = null;
        }
        if (this.class1082_0 != null)
        {
            this.class1082_0.System.IDisposable.Dispose();
            this.class1082_0 = null;
        }
        if (this.class1082_10 != null)
        {
            this.class1082_10.System.IDisposable.Dispose();
            this.class1082_10 = null;
        }
        if (this.class1082_1 != null)
        {
            this.class1082_1.System.IDisposable.Dispose();
            this.class1082_1 = null;
        }
        if (this.class1082_2 != null)
        {
            this.class1082_2.System.IDisposable.Dispose();
            this.class1082_2 = null;
        }
        if (this.class1082_6 != null)
        {
            this.class1082_6.System.IDisposable.Dispose();
            this.class1082_6 = null;
        }
        if (this.class1082_7 != null)
        {
            this.class1082_7.System.IDisposable.Dispose();
            this.class1082_7 = null;
        }
        if (this.class1082_8 != null)
        {
            this.class1082_8.System.IDisposable.Dispose();
            this.class1082_8 = null;
        }
        if (this.class1082_5 != null)
        {
            this.class1082_5.System.IDisposable.Dispose();
            this.class1082_5 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
        if (this.class1082_9 != null)
        {
            this.class1082_9.System.IDisposable.Dispose();
            this.class1082_9 = null;
        }
    }

    private enum BorderType
    {
        Right,
        Left,
        Top,
        Bottom
    }

    private class Class1082 : IDisposable
    {
        private List<Class643.Class1083> list_0 = new List<Class643.Class1083>();

        public int method_0()
        {
            return this.list_0.Count;
        }

        public List<Class643.Class1083> method_1()
        {
            if (this.list_0 == null)
            {
                this.list_0 = new List<Class643.Class1083>();
            }
            return this.list_0;
        }

        public void method_2(Class643.Class1083 A_0)
        {
            if (A_0 != null)
            {
                this.list_0.Add(A_0);
            }
        }

        public void method_3(string A_0)
        {
            Class643.Class1083 item = new Class643.Class1083();
            item.method_1(A_0);
            this.list_0.Add(item);
        }

        public void method_4(int A_0)
        {
            Class643.Class1083 item = new Class643.Class1083();
            item.method_4(A_0);
            this.list_0.Add(item);
        }

        public void method_5(float A_0)
        {
            Class643.Class1083 item = new Class643.Class1083();
            item.method_5(A_0);
            this.list_0.Add(item);
        }

        public void method_6(Class643.Class1082 A_0)
        {
            this.list_0.AddRange(A_0.method_1());
        }

        public void method_7(StreamWriter A_0)
        {
            int num = 0;
            int num2 = this.method_0();
            while (num < num2)
            {
                this.method_1()[num].method_9(A_0);
                num++;
            }
        }

        void IDisposable.Dispose()
        {
            if (this.list_0 != null)
            {
                for (int i = 0; i < this.list_0.Count; i++)
                {
                    if (this.list_0 != null)
                    {
                        this.list_0[i].System.IDisposable.Dispose();
                        this.list_0[i] = null;
                    }
                }
                this.list_0.Clear();
                this.list_0 = null;
            }
        }
    }

    private class Class1083 : IDisposable
    {
        internal const int int_0 = 0x1000;
        private StringBuilder stringBuilder_0;

        public Class1083()
        {
            this.stringBuilder_0 = new StringBuilder();
        }

        public Class1083(int A_0)
        {
            this.stringBuilder_0 = new StringBuilder(A_0);
        }

        public Class643.Class1083 method_0(Class643.Class1083 A_0)
        {
            int num = 6;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("弫娭䈯嬱娳儵稷伹倻圽␿❁㙃", num));
            }
            int num6 = A_0.method_10();
            int num2 = num6 % 0x1000;
            int num5 = num6 / 0x1000;
            num5 = (num2 != 0) ? (num5 + 1) : num5;
            char[] destination = new char[0x1000];
            for (int i = 0; i < num5; i++)
            {
                int count = ((num2 <= 0) || ((i + 1) < num5)) ? 0x1000 : num2;
                if ((num2 > 0) && ((i + 1) >= num5))
                {
                    destination = new char[num2];
                }
                A_0.stringBuilder_0.CopyTo(0x1000 * i, destination, 0, count);
                this.method_3(destination);
            }
            destination = null;
            return this;
        }

        public Class643.Class1083 method_1(string A_0)
        {
            this.stringBuilder_0.Append(A_0);
            return this;
        }

        public int method_10()
        {
            return this.stringBuilder_0.Length;
        }

        public Class643.Class1083 method_2(char A_0)
        {
            this.stringBuilder_0.Append(A_0);
            return this;
        }

        public Class643.Class1083 method_3(char[] A_0)
        {
            this.stringBuilder_0.Append(A_0);
            return this;
        }

        public Class643.Class1083 method_4(int A_0)
        {
            this.stringBuilder_0.Append(A_0);
            return this;
        }

        public Class643.Class1083 method_5(float A_0)
        {
            this.stringBuilder_0.Append(A_0.ToString(BookmarkStart.b("İ", 11)));
            return this;
        }

        public Class643.Class1083 method_6(double A_0)
        {
            this.stringBuilder_0.Append(A_0.ToString(BookmarkStart.b("Դ", 15)));
            return this;
        }

        public Class643.Class1083 method_7(int A_0, string A_1)
        {
            this.stringBuilder_0.Insert(A_0, A_1);
            return this;
        }

        public Class643.Class1083 method_8(int A_0, int A_1)
        {
            this.stringBuilder_0.Remove(A_0, A_1);
            return this;
        }

        public void method_9(StreamWriter A_0)
        {
            int num = 8;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("崭䐯䀱儳圵唷", num));
            }
            int num2 = this.method_10() % 0x1000;
            int num5 = this.method_10() / 0x1000;
            num5 = (num2 != 0) ? (num5 + 1) : num5;
            char[] destination = new char[0x1000];
            for (int i = 0; i < num5; i++)
            {
                int count = ((num2 <= 0) || ((i + 1) < num5)) ? 0x1000 : num2;
                if ((num2 > 0) && ((i + 1) >= num5))
                {
                    destination = new char[num2];
                }
                this.stringBuilder_0.CopyTo(0x1000 * i, destination, 0, count);
                A_0.Write(destination);
            }
            destination = null;
        }

        void IDisposable.Dispose()
        {
            if (this.stringBuilder_0 != null)
            {
                this.stringBuilder_0.Length = 0;
                this.stringBuilder_0 = null;
            }
        }

        string object.ToString()
        {
            return this.stringBuilder_0.ToString();
        }
    }
}

