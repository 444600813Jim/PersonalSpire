using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class560 : Interface45
{
    private bool bool_0;
    private CharacterFormat characterFormat_0;
    private Font font_0;
    private float? nullable_0;
    private FontTypeHint? nullable_1;
    private SubSuperScript? nullable_2;
    private UnderlineStyle? nullable_3;
    private bool? nullable_4;
    private bool? nullable_5;
    private bool? nullable_6;
    private float? nullable_7;
    private float? nullable_8;
    private float? nullable_9;
    internal string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;

    public Class560(CharacterFormat A_0)
    {
        this.characterFormat_0 = A_0;
        this.string_0 = BookmarkStart.b("攰娲場制䨸ᬺ猼娾㙀捂ᝄ⡆⑈⩊⍌", 11);
    }

    private CharacterFormat method_0()
    {
        return this.characterFormat_0;
    }

    internal Font method_1()
    {
        return this.method_0().Font;
    }

    internal SubSuperScript method_10()
    {
        return this.method_0().SubSuperScript;
    }

    internal UnderlineStyle method_11()
    {
        return this.method_0().UnderlineStyle;
    }

    internal bool method_12()
    {
        if (!this.nullable_4.HasValue)
        {
            this.nullable_4 = new bool?(this.method_0().Bidi);
        }
        return this.nullable_4.Value;
    }

    internal bool method_13()
    {
        if (!this.nullable_5.HasValue)
        {
            this.nullable_5 = new bool?(this.method_0().IsSmallCaps);
        }
        return this.nullable_5.Value;
    }

    internal bool method_14()
    {
        if (!this.nullable_6.HasValue)
        {
            this.nullable_6 = new bool?(this.method_0().AllCaps);
        }
        return this.nullable_6.Value;
    }

    internal float method_15()
    {
        return this.method_0().TextScaleEx;
    }

    internal float method_16()
    {
        return this.method_0().CharacterSpacing;
    }

    internal float method_17()
    {
        return this.method_0().Position;
    }

    private void method_18()
    {
        this.nullable_4 = new bool?(this.method_0().Bidi);
        this.nullable_5 = new bool?(this.method_0().IsSmallCaps);
        this.nullable_6 = new bool?(this.method_0().AllCaps);
        this.nullable_7 = new float?(this.method_0().TextScaleEx);
        this.nullable_8 = new float?(this.method_0().CharacterSpacing);
    }

    internal FontStyle method_2()
    {
        return this.method_0().FontStyle;
    }

    internal string method_3()
    {
        return this.method_0().FontName;
    }

    internal string method_4()
    {
        return this.method_0().FontNameAscii;
    }

    internal string method_5()
    {
        return this.method_0().FontNameFarEast;
    }

    internal string method_6()
    {
        return this.method_0().FontNameBidi;
    }

    internal string method_7()
    {
        return this.method_0().FontNameNonFarEast;
    }

    internal float method_8()
    {
        return this.method_0().FontSize;
    }

    internal FontTypeHint method_9()
    {
        return this.method_0().FontTypeHint;
    }
}

