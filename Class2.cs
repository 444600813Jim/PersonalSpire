using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Class2 : TextRange
{
    private bool bool_22;
    private float float_2;
    private float float_3;
    private RubyAlign rubyAlign_0;
    private TextRange textRange_1;

    public Class2(IDocument A_0) : base((Document) A_0)
    {
        this.float_3 = 9f;
        this.textRange_1 = new TextRange(A_0);
    }

    public Class2(IDocument A_0, string A_1, string A_2) : this((Document) A_0)
    {
        this.textRange_1.Text = A_1;
        this.Text = A_2;
    }

    public TextRange method_45()
    {
        return this.textRange_1;
    }

    public void method_46(TextRange A_0)
    {
        this.textRange_1 = A_0;
    }

    public float method_47()
    {
        return this.textRange_1.CharacterFormat.FontSize;
    }

    public void method_48(float A_0)
    {
        this.textRange_1.CharacterFormat.FontSize = A_0;
    }

    public float method_49()
    {
        return this.float_3;
    }

    public void method_50(float A_0)
    {
        this.float_3 = A_0;
    }

    public RubyAlign method_51()
    {
        return this.rubyAlign_0;
    }

    public void method_52(RubyAlign A_0)
    {
        this.rubyAlign_0 = A_0;
    }

    public float method_53()
    {
        return this.CharacterFormat.FontSize;
    }

    public void method_54(float A_0)
    {
        this.CharacterFormat.FontSize = A_0;
    }

    internal short method_55()
    {
        return this.CharacterFormat.Lid;
    }

    internal void method_56(short A_0)
    {
        this.CharacterFormat.Lid = A_0;
    }

    internal bool method_57()
    {
        return this.bool_22;
    }

    internal void method_58(bool A_0)
    {
        this.bool_22 = A_0;
    }

    internal bool method_59(Class420 A_0)
    {
        if (base.IsDeleteRevision)
        {
            return A_0.vmethod_21();
        }
        return true;
    }

    public void method_60(string A_0)
    {
        int num = 0x11;
        foreach (string str in A_0.Split(new string[] { BookmarkStart.b("欶ጸ", 0x11), BookmarkStart.b("欶", 0x11) }, StringSplitOptions.RemoveEmptyEntries))
        {
            string[] strArray4 = this.method_62(str);
            string str2 = strArray4[0].ToLower().Trim();
            if (str2 != null)
            {
                if (str2 != BookmarkStart.b("崶娸", num))
                {
                    if (str2 != BookmarkStart.b("弶䤸䠺", num))
                    {
                        if (!(str2 == BookmarkStart.b("䈶䤸", num)))
                        {
                            if (str2 == BookmarkStart.b("儶嘸唺䤼", num))
                            {
                                this.method_45().CharacterFormat.FontName = strArray4[1].Trim();
                            }
                        }
                        else
                        {
                            this.method_50(float.Parse(strArray4[1]));
                            Match match = new Regex(BookmarkStart.b("欶ᄸᔺ᜼挾桀", num)).Match(str.Trim(new char[] { ')' }));
                            this.method_45().Text = match.Groups[0].Value.Trim(new char[] { '(', ')' });
                            this.Text = str.Substring(str.IndexOf(BookmarkStart.b("ᬶ", num)) + 1).Trim(new char[] { ')' });
                        }
                    }
                    else
                    {
                        float num3 = float.Parse(strArray4[1]) / 2f;
                        this.method_48(num3);
                    }
                }
                else
                {
                    this.method_52(this.method_63(strArray4[1]));
                }
            }
        }
    }

    public Field method_61()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("栬縮", 7));
        builder.Append(BookmarkStart.b("ബ献ᬰጲ", 7) + this.method_64(this.method_51()));
        builder.Append(BookmarkStart.b("ബ献ᬰጲ᜴然嘸唺䤼Ծ", 7) + this.method_45().CharacterFormat.FontName + BookmarkStart.b("༬", 7));
        builder.Append(BookmarkStart.b("ബ献ᬰጲ崴䜶䨸", 7) + ((this.method_47() * 2f)).ToString());
        builder.Append(BookmarkStart.b("ബ献帰漲吴匶ᄸ机丼挾㑀㍂", 7) + this.method_49().ToString());
        builder.Append(BookmarkStart.b("Ԭ", 7) + this.method_45().Text + BookmarkStart.b("Ь̮", 7));
        builder.Append(this.Text + BookmarkStart.b("Ь", 7));
        Field field = new Field(base.m_doc, FieldType.FieldFormula, builder.ToString());
        FieldMark mark = new FieldMark(base.m_doc, this.CharacterFormat, FieldMarkType.FieldEnd);
        mark.method_0(base.Owner);
        field.End = mark;
        field.CharacterFormat = this.CharacterFormat;
        field.method_0(base.Owner);
        return field;
    }

    private string[] method_62(string A_0)
    {
        string[] strArray = new string[2];
        bool flag = false;
        bool flag2 = false;
        A_0 = A_0.Trim().Trim(new char[] { '"' });
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if (!char.IsDigit(c) && !flag2)
            {
                if (c == ':')
                {
                    flag2 = true;
                }
                else
                {
                    string[] strArray2;
                    if (flag)
                    {
                        return strArray;
                    }
                    (strArray2 = strArray)[0] = strArray2[0] + c;
                }
            }
            else
            {
                string[] strArray3;
                (strArray3 = strArray)[1] = strArray3[1] + c;
                flag = true;
            }
        }
        return strArray;
    }

    private RubyAlign method_63(string A_0)
    {
        int num = 0;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_2 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("ᜥ", num), 0);
                dictionary1.Add(BookmarkStart.b("ᐥ", num), 1);
                dictionary1.Add(BookmarkStart.b("ᔥ", num), 2);
                dictionary1.Add(BookmarkStart.b("ሥ", num), 3);
                dictionary1.Add(BookmarkStart.b("ጥ", num), 4);
                dictionary1.Add(BookmarkStart.b("ᘥ", num), 5);
                Class1160.dictionary_2 = dictionary1;
            }
            if (Class1160.dictionary_2.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return RubyAlign.DistributeLetter;

                    case 1:
                        return RubyAlign.DistributeSpace;

                    case 2:
                        return RubyAlign.Left;

                    case 3:
                        return RubyAlign.Right;

                    case 4:
                        return RubyAlign.RightVertical;
                }
            }
        }
        return RubyAlign.Center;
    }

    private string method_64(RubyAlign A_0)
    {
        int num = 0x12;
        switch (A_0)
        {
            case RubyAlign.DistributeLetter:
                return BookmarkStart.b("刷夹഻", num);

            case RubyAlign.DistributeSpace:
                return BookmarkStart.b("刷夹฻", num);

            case RubyAlign.Left:
                return BookmarkStart.b("刷夹༻", num);

            case RubyAlign.Right:
                return BookmarkStart.b("刷夹࠻", num);

            case RubyAlign.RightVertical:
                return BookmarkStart.b("刷夹ऻ", num);
        }
        return BookmarkStart.b("刷夹఻", num);
    }

    bool TextRange.Accept(Class420 A_0)
    {
        return (!this.method_59(A_0) || base.method_12(A_0.vmethod_20(this)));
    }

    public override DocumentObjectType Spire.Doc.Fields.TextRange.DocumentObjectType
    {
        get
        {
            return DocumentObjectType.Ruby;
        }
    }
}

