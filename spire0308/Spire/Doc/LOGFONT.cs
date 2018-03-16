namespace Spire.Doc
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
    public class LOGFONT
    {
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public FontWeight lfWeight;
        [MarshalAs(UnmanagedType.U1)]
        public bool lfItalic;
        [MarshalAs(UnmanagedType.U1)]
        public bool lfUnderline;
        [MarshalAs(UnmanagedType.U1)]
        public bool lfStrikeOut;
        public FontCharSet lfCharSet;
        public FontPrecision lfOutPrecision;
        public FontClipPrecision lfClipPrecision;
        public FontQuality lfQuality;
        public FontPitchAndFamily lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x20)]
        public string lfFaceName;
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(BookmarkStart.b("戭缯由爳礵瘷渹㘻", 8));
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵瀷弹唻夽⠿㙁繃晅㍇穉ㅋ䑍", 8), this.lfHeight);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵漷匹堻䨽⠿硁摃㵅硇㝉䙋", 8), this.lfWidth);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵紷䤹弻弽〿❁⥃⍅♇㹉癋湍⭏扑⥓展", 8), this.lfEscapement);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵眷䠹唻嬽⸿㙁╃㉅ⅇ╉≋瑍灏⥑摓⭕剗", 8), this.lfOrientation);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵漷弹唻夽⠿㙁繃晅㍇穉ㅋ䑍", 8), this.lfWeight);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵焷丹崻刽⤿⅁繃晅㍇穉ㅋ䑍", 8), this.lfItalic);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵洷吹堻嬽㈿⹁ⵃ⡅ⵇ灉汋㕍恏⽑幓", 8), this.lfUnderline);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵欷丹主圽⬿❁ୃ㍅㱇灉汋㕍恏⽑幓", 8), this.lfStrikeOut);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵笷刹崻䰽ጿ❁ぃ籅桇ㅉ籋㍍婏", 8), this.lfCharSet);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵眷伹䠻渽㈿❁❃⽅㭇⍉⍋⁍橏牑⽓晕╗偙", 8), this.lfOutPrecision);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵笷嘹唻丽ဿぁ⅃╅ⅇ㥉╋⅍㹏桑瑓ⵕ桗❙噛", 8), this.lfClipPrecision);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵椷伹崻刽⤿㙁㵃籅桇ㅉ籋㍍婏", 8), this.lfQuality);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵样匹䠻崽⠿́⩃≅็⭉⅋❍㱏⭑湓癕⍗橙⅛呝", 8), this.lfPitchAndFamily);
            builder.AppendFormat(BookmarkStart.b("อုሱ堳倵縷嬹弻嬽฿⍁⥃⍅片橉㝋繍ⵏ塑", 8), this.lfFaceName);
            return builder.ToString();
        }
    }
}

