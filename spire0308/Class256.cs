using Spire.Doc;
using System;

internal class Class256 : Class253
{
    private FileFormat fileFormat_0;
    private string string_1;

    public Class256() : this(FileFormat.Doc)
    {
    }

    public Class256(FileFormat A_0)
    {
        this.method_14(A_0);
    }

    public string method_12()
    {
        return this.string_1;
    }

    public void method_13(string A_0)
    {
        this.string_1 = A_0;
    }

    private void method_14(FileFormat A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case FileFormat.Doc:
            case FileFormat.Dot:
                this.fileFormat_0 = A_0;
                return;
        }
        throw new ArgumentException(BookmarkStart.b("朥䘧਩䔫䀭䘯匱堳張尷ᨹ漻弽㘿❁Ƀ⥅㩇❉ⵋ㩍灏㑑㭓⑕硗⹙㑛㝝፟䉡ୣᙥᱧͩͫmͯ剱sཱུࡷό屻ॽꒃﾋﺏ벑", num));
    }

    public override FileFormat vmethod_1()
    {
        return this.fileFormat_0;
    }

    public override void vmethod_2(FileFormat A_0)
    {
        this.method_14(A_0);
    }
}

