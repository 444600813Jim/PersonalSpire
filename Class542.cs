using Spire.Doc;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Drawing;

internal class Class542 : Interface19
{
    private Interface21 interface21_0;
    private List<Class216> list_0;
    private string string_0;

    public Class542(Interface21 A_0, string A_1)
    {
        this.interface21_0 = A_0;
        this.string_0 = A_1;
    }

    public Class542(Interface21 A_0, Class546 A_1, bool A_2)
    {
        string textToSplit = string.Empty;
        textToSplit = (A_0 as TextRange).TextToSplit;
        this.interface21_0 = A_0;
        string str2 = A_2 ? textToSplit.Substring(0, A_1.method_1()) : textToSplit.Substring(A_1.method_0());
        this.string_0 = str2;
    }

    public void imethod_1(Class196 A_0, Class375 A_1)
    {
        if (((this.interface21_0 is Field) && (this.method_0() != null)) && (this.method_0() != string.Empty))
        {
            string text = (this.interface21_0 as Field).Text;
            (this.interface21_0 as Field).Text = this.method_0();
            this.interface21_0.imethod_1(A_0, A_1);
            (this.interface21_0 as Field).Text = text;
        }
        else if (((A_1.method_73() as Class542).method_2() as TextRange).PreviousSibling is FieldMark)
        {
            string str = ((A_1.method_73() as Class542).method_2() as TextRange).Text;
            ParagraphBase previousSibling = ((A_1.method_73() as Class542).method_2() as TextRange).PreviousSibling as ParagraphBase;
            if (((previousSibling.PreviousSibling != null) && (previousSibling.PreviousSibling is Field)) && ((previousSibling.PreviousSibling as Field).Type == FieldType.FieldNumPages))
            {
                this.interface21_0.imethod_7(A_0, A_1, str);
            }
            else
            {
                this.interface21_0.imethod_7(A_0, A_1, this.method_0());
            }
        }
        else
        {
            this.interface21_0.imethod_7(A_0, A_1, this.method_0());
        }
    }

    public void imethod_2(Class196 A_0, Class375 A_1)
    {
    }

    public Interface19[] imethod_4(Class196 A_0, SizeF A_1, float A_2, float A_3)
    {
        return smethod_0(A_0, (double) A_1.Width, this.interface21_0, this.method_0(), A_2, A_3, false);
    }

    Interface23 Interface1.imethod_0()
    {
        return this.interface21_0.imethod_0();
    }

    SizeF Interface2.imethod_3(Class196 A_0)
    {
        return this.interface21_0.imethod_0(A_0, this.method_5());
    }

    public string method_0()
    {
        return this.string_0;
    }

    public void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    public Interface21 method_2()
    {
        return this.interface21_0;
    }

    internal List<Class216> method_3()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<Class216>();
        }
        return this.list_0;
    }

    internal float method_4()
    {
        float num = 0f;
        for (int i = 0; i < this.method_3().Count; i++)
        {
            num += this.method_3()[i].method_2();
        }
        return num;
    }

    public string method_5()
    {
        return this.method_0();
    }

    public static Interface19[] smethod_0(Class196 A_0, double A_1, Interface21 A_2, string A_3, float A_4, float A_5, bool A_6)
    {
        StringFormat format;
        int num = 3;
        format = new StringFormat(StringFormat.GenericTypographic) {
            FormatFlags = format.FormatFlags | StringFormatFlags.MeasureTrailingSpaces,
            FormatFlags = format.FormatFlags | StringFormatFlags.NoClip,
            Trimming = StringTrimming.Word
        };
        string str2 = (A_3 != null) ? A_3 : A_2.imethod_5();
        if ((A_2 is Field) ? (A_2 as Field).CharacterFormat.AllCaps : (A_2 as TextRange).CharacterFormat.AllCaps)
        {
            str2 = str2.ToUpper();
        }
        if ((A_2 is Field) ? (A_2 as Field).CharacterFormat.AllCaps : (A_2 as TextRange).CharacterFormat.AllCaps)
        {
            str2 = str2.ToUpper();
        }
        Font font = null;
        sprᝪ rᝪ = null;
        if (A_0.method_1())
        {
            rᝪ = (A_2 is Field) ? A_0.method_376((A_2 as Field).CharacterFormat) : A_0.method_378(A_2 as TextRange);
        }
        else
        {
            font = (A_2 is Field) ? A_0.method_365((A_2 as Field).CharacterFormat) : A_0.method_367(A_2 as TextRange);
        }
        Class544 class3 = new Class544();
        class3.method_1(A_0);
        class3.method_2(A_0.method_405(A_2 as TextRange));
        class3.method_3(A_2);
        Class545 class2 = class3.method_5(str2, A_0.method_151(), font, rᝪ, format, new SizeF((float) A_1, float.MaxValue));
        if (class2.struct11_0.Length > 0)
        {
            Interface19[] interfaceArray2 = new Interface19[2];
            interfaceArray2[0] = new Class542(A_2, class2.struct11_0[0].string_0);
            string str = string.Empty;
            if ((class2.string_0 == null) && (class2.struct11_0.Length > 1))
            {
                for (int i = 1; i < class2.method_1(); i++)
                {
                    if (class2.struct11_0[i].string_0 == BookmarkStart.b("न", num))
                    {
                        str = str + BookmarkStart.b("⌨", num);
                    }
                    else
                    {
                        str = str + BookmarkStart.b("⌨", num) + class2.struct11_0[i].string_0;
                    }
                }
            }
            else
            {
                str = class2.string_0;
            }
            if ((str == BookmarkStart.b("⌨", num)) || (str == BookmarkStart.b("␨", num)))
            {
                str = BookmarkStart.b("न", num);
            }
            if ((str != null) && (str.StartsWith(BookmarkStart.b("⌨", num)) || str.StartsWith(BookmarkStart.b("␨", num))))
            {
                str = str.Remove(0, 1).TrimStart(new char[0]);
            }
            interfaceArray2[1] = new Class542(A_2, str);
            return interfaceArray2;
        }
        if (((A_2 == null) || (A_2.imethod_5() == null)) || !(A_2.imethod_5() != string.Empty))
        {
            return null;
        }
        (A_2 as TextRange).TextToSplit = class2.string_0;
        if (A_0.method_323(A_2 as TextRange, (A_2 as TextRange).TextToSplit).Width > A_1)
        {
            return smethod_1(A_0, A_1, A_2, null, A_4, A_5, A_6);
        }
        return new Interface19[] { new Class542(A_2, string.Empty), new Class542(A_2, class2.string_0) };
    }

    public static Interface19[] smethod_1(Class196 A_0, double A_1, Interface21 A_2, Class546 A_3, float A_4, float A_5, bool A_6)
    {
        string textToSplit = string.Empty;
        textToSplit = (A_2 as TextRange).TextToSplit;
        if (A_3 == null)
        {
            A_3 = new Class546(0, textToSplit.Length - 1);
        }
        int num = A_2.imethod_8(A_0, A_1, A_3.method_7(textToSplit), textToSplit, A_4, A_5, A_6);
        if (num == -2147483648)
        {
            Interface19[] interfaceArray = new Interface19[2];
            interfaceArray[0] = new Class542(A_2, textToSplit.Substring(0, 1));
            string str2 = textToSplit.Substring(1);
            interfaceArray[1] = string.IsNullOrEmpty(str2) ? null : new Class542(A_2, str2);
            return interfaceArray;
        }
        if ((num > -1) && (num < A_3.method_2()))
        {
            Interface19[] interfaceArray2 = new Interface19[2];
            if (textToSplit.Length == (A_2 as TextRange).Text.Length)
            {
                interfaceArray2[0] = new Class542(A_2, A_3.method_5(num), true);
                interfaceArray2[1] = new Class542(A_2, A_3.method_6(num), false);
            }
            else
            {
                interfaceArray2[0] = new Class542(A_2, textToSplit.Substring(0, num));
                interfaceArray2[1] = new Class542(A_2, textToSplit.Substring(num));
            }
            (A_2 as TextRange).TextToSplit = (A_2 as TextRange).TextToSplit.Remove(0, num);
            return interfaceArray2;
        }
        Interface19[] interfaceArray3 = new Interface19[2];
        num = (num < 0) ? 0 : ((num == textToSplit.Length) ? (num - 1) : num);
        if (((num == 0) && (A_2 is TextRange)) && ((A_2 as TextRange).Document != null))
        {
            TextRange range = new TextRange((A_2 as TextRange).Document);
            range.method_0((A_2 as TextRange).Owner);
            range.CharacterFormat.Font = (A_2 as TextRange).CharacterFormat.Font;
            range.CharacterFormat.FontSize = (A_2 as TextRange).CharacterFormat.FontSize;
            interfaceArray3[0] = new Class542(range, string.Empty);
        }
        if (interfaceArray3[0] == null)
        {
            interfaceArray3[0] = new Class542(A_2, A_3.method_5(num), true);
        }
        interfaceArray3[1] = new Class542(A_2, A_3.method_6(num), false);
        return interfaceArray3;
    }
}

