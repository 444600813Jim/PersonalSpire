using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.Markup;
using Spire.Doc.Documents.Markup;
using System;

internal class Class487
{
    private readonly Class457 class457_0 = new Class457();
    private readonly Sdtt sdtt_0;
    private readonly string string_0;
    private readonly string string_1;
    private readonly string string_2;

    internal Class487(Sdtt A_0, string A_1, string A_2, string A_3)
    {
        this.sdtt_0 = A_0;
        this.string_0 = A_1;
        this.string_1 = A_2;
        this.string_2 = A_3;
    }

    internal MarkupLevel method_0()
    {
        return smethod_0(this.sdtt_0);
    }

    internal string method_1()
    {
        return this.string_0;
    }

    internal string method_2()
    {
        if (!Class567.smethod_16(this.string_1))
        {
            return "";
        }
        return this.string_1;
    }

    internal string method_3()
    {
        return this.string_2;
    }

    internal Class457 method_4()
    {
        return this.class457_0;
    }

    internal static MarkupLevel smethod_0(Sdtt A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case Sdtt.SdttRegular:
                return MarkupLevel.Inline;

            case Sdtt.SdttPara:
                return MarkupLevel.Block;

            case Sdtt.SdttCell:
                return MarkupLevel.Cell;

            case Sdtt.SdttRow:
                return MarkupLevel.Row;
        }
        throw new InvalidOperationException(BookmarkStart.b("礯就䈳圵吷匹堻ḽ㌿♁ぃ㉅桇㱉ⵋ≍╏㝑穓", num));
    }

    internal static Sdtt smethod_1(MarkupLevel A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case MarkupLevel.Inline:
                return Sdtt.SdttRegular;

            case MarkupLevel.Block:
                return Sdtt.SdttPara;

            case MarkupLevel.Row:
                return Sdtt.SdttRow;

            case MarkupLevel.Cell:
                return Sdtt.SdttCell;
        }
        throw new InvalidOperationException(BookmarkStart.b("漥䘧尩䴫䈭夯嘱ᐳ嬵夷䠹圻䬽〿扁⡃⍅㹇⽉⁋恍", num));
    }
}

