namespace Spire.Doc.Converters
{
    using System;
    using System.Text;

    public static class RtfSpec
    {
        public const int AnsiCodePage = 0x4e4;
        public static readonly Encoding AnsiEncoding = Encoding.GetEncoding(0x4e4);
        private bool bool_0;
        public const int DefaultFontSize = 0x18;
        private long[] long_0;
        public const int MacCodePage = 0x2710;
        public const int PcaCodePage = 850;
        public const int PcCodePage = 0x1b5;
        public const int PropertyTypeBoolean = 11;
        public const int PropertyTypeDate = 0x40;
        public const int PropertyTypeInteger = 3;
        public const int PropertyTypeRealNumber = 5;
        public const int PropertyTypeText = 30;
        public const int RtfVersion1 = 1;
        private string[] string_0;
        private string[] string_1;
        public const int SymbolFakeCodePage = 0x2a;
        public const string TagAlignCenter = "qc";
        public const string TagAlignJustify = "qj";
        public const string TagAlignLeft = "ql";
        public const string TagAlignRight = "qr";
        public const string TagBold = "b";
        public const string TagBulltet = "bullet";
        public const string TagCodePage = "cpg";
        public const string TagColorBackground = "cb";
        public const string TagColorBackgroundWord = "chcbpat";
        public const string TagColorBlue = "blue";
        public const string TagColorForeground = "cf";
        public const string TagColorGreen = "green";
        public const string TagColorHighlight = "highlight";
        public const string TagColorRed = "red";
        public const string TagColorTable = "colortbl";
        public const string TagDefaultFont = "deff";
        public const string TagDelimiter = ";";
        public const string TagEmDash = "emdash";
        public const string TagEmSpace = "emspace";
        public const string TagEncodingAnsi = "ansi";
        public const string TagEncodingAnsiCodePage = "ansicpg";
        public const string TagEncodingMac = "mac";
        public const string TagEncodingPc = "pc";
        public const string TagEncodingPca = "pca";
        public const string TagEnDash = "endash";
        public const string TagEnSpace = "enspace";
        public const string TagExtensionDestination = "*";
        public const string TagFont = "f";
        public const string TagFontCharset = "fcharset";
        public const string TagFontDown = "dn";
        public const string TagFontKindBidi = "fbidi";
        public const string TagFontKindDecor = "fdecor";
        public const string TagFontKindModern = "fmodern";
        public const string TagFontKindNil = "fnil";
        public const string TagFontKindRoman = "froman";
        public const string TagFontKindScript = "fscript";
        public const string TagFontKindSwiss = "fswiss";
        public const string TagFontKindTech = "ftech";
        public const string TagFontNoSuperSub = "nosupersub";
        public const string TagFontPitch = "fprq";
        public const string TagFontSize = "fs";
        public const string TagFontSubscript = "sub";
        public const string TagFontSuperscript = "super";
        public const string TagFontTable = "fonttbl";
        public const string TagFontUp = "up";
        public const string TagFooter = "footer";
        public const string TagFooterFirst = "footerf";
        public const string TagFooterLeft = "footerl";
        public const string TagFooterRight = "footerr";
        public const string TagFootnote = "footnote";
        public const string TagGenerator = "generator";
        public const string TagHeader = "header";
        public const string TagHeaderFirst = "headerf";
        public const string TagHeaderLeft = "headerl";
        public const string TagHeaderRight = "headerr";
        public const string TagHidden = "v";
        public const string TagHyphen = "-";
        public const string TagInfo = "info";
        public const string TagInfoAuthor = "author";
        public const string TagInfoBackupTime = "buptim";
        public const string TagInfoCategory = "category";
        public const string TagInfoComment = "comment";
        public const string TagInfoCompany = "company";
        public const string TagInfoCreationTime = "creatim";
        public const string TagInfoDay = "dy";
        public const string TagInfoDocumentComment = "doccomm";
        public const string TagInfoEditingTimeMinutes = "edmins";
        public const string TagInfoHour = "hr";
        public const string TagInfoHyperLinkBase = "hlinkbase";
        public const string TagInfoId = "id";
        public const string TagInfoKeywords = "keywords";
        public const string TagInfoManager = "manager";
        public const string TagInfoMinute = "min";
        public const string TagInfoMonth = "mo";
        public const string TagInfoNumberOfChars = "nofchars";
        public const string TagInfoNumberOfPages = "nofpages";
        public const string TagInfoNumberOfWords = "nofwords";
        public const string TagInfoOperator = "operator";
        public const string TagInfoPrintTime = "printim";
        public const string TagInfoRevision = "vern";
        public const string TagInfoRevisionTime = "revtim";
        public const string TagInfoSecond = "sec";
        public const string TagInfoSubject = "subject";
        public const string TagInfoTitle = "title";
        public const string TagInfoVersion = "version";
        public const string TagInfoYear = "yr";
        public const string TagItalic = "i";
        public const string TagLeftDoubleQuote = "ldblquote";
        public const string TagLeftSingleQuote = "lquote";
        public const string TagLine = "line";
        public const string TagListNumberText = "listtext";
        public const string TagPage = "page";
        public const string TagParagraph = "par";
        public const string TagParagraphDefaults = "pard";
        public const string TagParagraphNumberText = "pntext";
        public const string TagPicture = "pict";
        public const string TagPictureFormatEmf = "emfblip";
        public const string TagPictureFormatJpg = "jpegblip";
        public const string TagPictureFormatOs2Metafile = "pmmetafile";
        public const string TagPictureFormatPict = "macpict";
        public const string TagPictureFormatPng = "pngblip";
        public const string TagPictureFormatWinBmp = "wbitmap";
        public const string TagPictureFormatWinDib = "dibitmap";
        public const string TagPictureFormatWmf = "wmetafile";
        public const string TagPictureHeight = "pich";
        public const string TagPictureHeightGoal = "pichgoal";
        public const string TagPictureHeightScale = "picscaley";
        public const string TagPictureWidth = "picw";
        public const string TagPictureWidthGoal = "picwgoal";
        public const string TagPictureWidthScale = "picscalex";
        public const string TagPictureWrapper = "shppict";
        public const string TagPictureWrapperAlternative = "nonshppict";
        public const string TagPlain = "plain";
        public const string TagQmSpace = "qmspace";
        public const string TagRightDoubleQuote = "rdblquote";
        public const string TagRightSingleQuote = "rquote";
        public const string TagRtf = "rtf";
        public const string TagSection = "sect";
        public const string TagSectionDefaults = "sectd";
        public const string TagStrikeThrough = "strike";
        public const string TagStyleSheet = "stylesheet";
        public const string TagTabulator = "tab";
        public const string TagThemeFontBiMajor = "fbimajor";
        public const string TagThemeFontBiMinor = "fbiminor";
        public const string TagThemeFontDbMajor = "fdbmajor";
        public const string TagThemeFontDbMinor = "fdbminor";
        public const string TagThemeFontHiMajor = "fhimajor";
        public const string TagThemeFontHiMinor = "fhiminor";
        public const string TagThemeFontLoMajor = "flomajor";
        public const string TagThemeFontLoMinor = "flominor";
        public const string TagTilde = "~";
        public const string TagUnderLine = "ul";
        public const string TagUnderLineNone = "ulnone";
        public const string TagUnderscore = "_";
        public const string TagUnicodeAlternativeChoices = "upr";
        public const string TagUnicodeAlternativeUnicode = "ud";
        public const string TagUnicodeCode = "u";
        public const string TagUnicodeSkipCount = "uc";
        public const string TagUserProperties = "userprops";
        public const string TagUserPropertyLink = "linkval";
        public const string TagUserPropertyName = "propname";
        public const string TagUserPropertyType = "proptype";
        public const string TagUserPropertyValue = "staticval";
        public const string TagViewKind = "viewkind";

        public static int GetCodePage(int charSet)
        {
            switch (charSet)
            {
                case 0:
                    return 0x4e4;

                case 1:
                    return 0;

                case 2:
                    return 0x2a;

                case 0x4d:
                    return 0x2710;

                case 0x4e:
                    return 0x2711;

                case 0x4f:
                    return 0x2713;

                case 80:
                    return 0x2718;

                case 0x51:
                    return 0x2712;

                case 0x52:
                    return 0;

                case 0x53:
                    return 0x2715;

                case 0x54:
                    return 0x2714;

                case 0x55:
                    return 0x2716;

                case 0x56:
                    return 0x2761;

                case 0x57:
                    return 0x2725;

                case 0x58:
                    return 0x272d;

                case 0x59:
                    return 0x2717;

                case 0x80:
                    return 0x3a4;

                case 0x81:
                    return 0x3b5;

                case 130:
                    return 0x551;

                case 0x86:
                    return 0x3a8;

                case 0x88:
                    return 950;

                case 0xa1:
                    return 0x4e5;

                case 0xa2:
                    return 0x4e6;

                case 0xa3:
                    return 0x4ea;

                case 0xb1:
                    return 0x4e7;

                case 0xb2:
                    return 0x4e8;

                case 0xb3:
                    return 0;

                case 180:
                    return 0;

                case 0xb5:
                    return 0;

                case 0xba:
                    return 0x4e9;

                case 0xcc:
                    return 0x4e3;

                case 0xfe:
                    return 0x1b5;

                case 0xff:
                    return 850;

                case 0xee:
                    return 0x4e2;

                case 0xde:
                    return 0x36a;
            }
            return 0;
        }
    }
}

