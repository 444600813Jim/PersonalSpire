using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Caculation;
using Spire.Doc.Formatting;
using System;

internal abstract class Class18 : AttrCollection
{
    private static readonly AttrCollection attrCollection_0;
    internal const char char_0 = '\0';

    protected Class18()
    {
    }

    internal static bool smethod_5(DocumentObject A_0)
    {
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.TextRange:
            case DocumentObjectType.FieldMark:
            case DocumentObjectType.BookmarkStart:
            case DocumentObjectType.BookmarkEnd:
            case DocumentObjectType.Comment:
            case DocumentObjectType.SmartTag:
                return true;

            case DocumentObjectType.OfficeMath:
                return ((Class5) A_0).method_32().vmethod_3();
        }
        return false;
    }

    object FormatBase.GetDefValue(int A_0)
    {
        int num = 0x12;
        int num2 = A_0;
        if (num2 <= 0x3b7e)
        {
            if (num2 > 0x3b06)
            {
                if (num2 > 0x3b42)
                {
                    if (num2 > 0x3b60)
                    {
                        switch (num2)
                        {
                            case 0x3b6a:
                                return false;

                            case 0x3b74:
                                return MathDelimiterShape.Centered;

                            case 0x3b7e:
                                return MathBaseJustification.Center;
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 0x3b4c:
                                return '(';

                            case 0x3b56:
                                return ')';

                            case 0x3b60:
                                return '│';
                        }
                    }
                }
                else if (num2 > 0x3b1a)
                {
                    switch (num2)
                    {
                        case 0x3b24:
                            return false;

                        case 0x3b38:
                            return true;

                        case 0x3b42:
                            return false;
                    }
                }
                else
                {
                    switch (num2)
                    {
                        case 0x3b10:
                            return false;

                        case 0x3b1a:
                            return false;
                    }
                }
            }
            else if (num2 > 0x3aca)
            {
                if (num2 > 0x3ae8)
                {
                    switch (num2)
                    {
                        case 0x3af2:
                            return false;

                        case 0x3afc:
                            return false;

                        case 0x3b06:
                            return false;
                    }
                }
                else
                {
                    switch (num2)
                    {
                        case 0x3ad4:
                            return false;

                        case 0x3ade:
                            return false;

                        case 0x3ae8:
                            return false;
                    }
                }
            }
            else if (num2 > 0x3ab6)
            {
                switch (num2)
                {
                    case 0x3ac0:
                        return '̂';

                    case 0x3ac5:
                        return '∫';

                    case 0x3aca:
                        return false;
                }
            }
            else
            {
                switch (num2)
                {
                    case 0x3aa2:
                        return MathJustification.CenterGroup;

                    case 0x3ab6:
                        return MathPosition.Bottom;
                }
            }
        }
        else if (num2 <= 0x3bec)
        {
            if (num2 > 0x3bb0)
            {
                if (num2 > 0x3bce)
                {
                    switch (num2)
                    {
                        case 0x3bd8:
                            return false;

                        case 0x3be2:
                            return false;

                        case 0x3bec:
                            return false;
                    }
                }
                else
                {
                    switch (num2)
                    {
                        case 0x3bba:
                            return MathPosition.Bottom;

                        case 0x3bc4:
                            return MathVerticalJustification.Top;

                        case 0x3bce:
                            return true;
                    }
                }
            }
            else if (num2 > 0x3b92)
            {
                switch (num2)
                {
                    case 0x3b9c:
                        return 0;

                    case 0x3ba6:
                        return MathSpacingRule.Single;

                    case 0x3bb0:
                        return '⏟';
                }
            }
            else
            {
                switch (num2)
                {
                    case 0x3b88:
                        return false;

                    case 0x3b92:
                        return false;
                }
            }
        }
        else
        {
            switch (num2)
            {
                case 0x3c6e:
                    return false;

                case 0x3c78:
                    return 0;

                case 0x3c82:
                    return MathSpacingRule.Single;

                case 0x3c5a:
                    return false;

                case 0x3c64:
                    return MathFractionType.Bar;

                case 0x3c8c:
                    return 0;

                case 0x3c96:
                    return MathLimitLocation.Undefined;

                case 0x3ca0:
                    return false;

                case 0x3caa:
                    return false;

                case 0x3cb4:
                    return false;

                case 0x3cbe:
                    return false;
            }
        }
        throw new ArgumentException(BookmarkStart.b("匷弹䔻ḽ⠿⍁㝃晅ⅇ⑉㩋⽍㱏㭑こ癕⹗㭙せ⭝՟", num));
    }

    internal virtual bool vmethod_0(DocumentObject A_0)
    {
        if (this.vmethod_2())
        {
            return ((A_0.DocumentObjectType == DocumentObjectType.OfficeMath) && (((Class5) A_0).method_32().vmethod_1() == MathObjectType.Argument));
        }
        return smethod_5(A_0);
    }

    internal abstract MathObjectType vmethod_1();
    internal virtual bool vmethod_2()
    {
        return true;
    }

    internal virtual bool vmethod_3()
    {
        return true;
    }
}

