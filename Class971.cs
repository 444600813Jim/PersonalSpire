using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Formatting;
using System;

internal class Class971
{
    private readonly Class422 class422_0;
    private Class647 class647_0;

    internal Class971(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0(Section A_0)
    {
        int num = 0;
        Class400 class2 = this.class422_0.method_18();
        this.method_3(A_0, A_0.SectPr);
        if (this.class647_0.class580_0 != null)
        {
            this.method_3(A_0, this.class647_0.class580_0.method_4());
        }
        if (this.class647_0.int_0 > 0)
        {
            class2.method_4(BookmarkStart.b("唥尧匩䀫䬭ਯ䄱儳唵䰷匹医倽洿㉁㙃⥅㡇⽉㹋㩍㥏㝑❓", num));
            class2.method_40(BookmarkStart.b("別䴧利堫ᐭ启崱娳䈵ᔷ堹崻刽ℿⱁ❃⍅敇㹉⥋㙍⑏网㝓㥕㑗⽙ㅛそ፟", num), this.class647_0.string_3);
            this.method_1();
            class2.method_6(BookmarkStart.b("唥尧匩䀫䬭ਯ䄱儳唵䰷匹医倽洿㉁㙃⥅㡇⽉㹋㩍㥏㝑❓", num));
        }
    }

    internal void method_1()
    {
        int num = 7;
        Class400 class2 = this.class422_0.method_18();
        class2.method_4(BookmarkStart.b("帬嬮䠰弲倴ശ娸吺儼䨾ⱀⵂ㙄", 7));
        class2.method_40(BookmarkStart.b("䬬䀮ର倲娴嬶䰸嘺匼ሾ≀ⱂい⥆㵈", 7), this.class647_0.columnCollection_0.Count.ToString());
        if (this.class647_0.bool_1)
        {
            class2.method_40(BookmarkStart.b("䬬䀮ର倲娴嬶䰸嘺匼ሾ♀≂㕄", num), this.class647_0.string_2);
        }
        if (this.class647_0.bool_0)
        {
            class2.method_10(BookmarkStart.b("帬嬮䠰弲倴ശ娸吺儼䨾ⱀⵂ桄㑆ⱈ㭊", num));
        }
        if ((this.class647_0.columnCollection_0 != null) && !this.class647_0.bool_1)
        {
            for (int i = 0; i < this.class647_0.columnCollection_0.Count; i++)
            {
                this.method_2(this.class647_0.columnCollection_0[i], i);
            }
        }
        class2.method_6(BookmarkStart.b("帬嬮䠰弲倴ശ娸吺儼䨾ⱀⵂ㙄", num));
    }

    internal void method_2(Column A_0, int A_1)
    {
        int num = 12;
        float num2 = 0f;
        float num3 = 0f;
        if (A_1 > 0)
        {
            num2 = this.class647_0.columnCollection_0[A_1 - 1].Space / 2f;
        }
        if (A_1 < (this.class647_0.columnCollection_0.Count - 1))
        {
            num3 = A_0.Space / 2f;
        }
        this.class422_0.method_18().method_33(BookmarkStart.b("䄱䀳伵吷弹ػ崽⼿⹁ㅃ⭅♇", num), new object[] { BookmarkStart.b("䄱䀳伵吷弹ػ䰽┿⹁楃ㅅⅇ⹉㡋♍", num), string.Format(BookmarkStart.b("䤱г䬵ሷ", num), Class576.smethod_49((double) ((A_0.Width + num2) + num3))), BookmarkStart.b("吱嬳వ䬷丹崻䰽㐿潁ⵃ⡅ⱇ⽉≋㩍", num), (num2 != 0f) ? Class576.smethod_35(num2) : BookmarkStart.b("ȱ崳堵", num), BookmarkStart.b("吱嬳వ崷吹堻ጽ⤿ⱁ⁃⍅♇㹉", num), (num3 != 0f) ? Class576.smethod_35(num3) : BookmarkStart.b("ȱ崳堵", num) });
    }

    internal Class647 method_3(Section A_0, WordAttrCollection A_1)
    {
        int num = 0x13;
        this.class647_0 = new Class647();
        this.class647_0.bool_1 = false;
        for (int i = 0; i < A_1.Count; i++)
        {
            int num4 = A_1.method_18(i);
            object obj2 = A_1.method_19(i);
            if (obj2 == null)
            {
                continue;
            }
            this.class647_0.int_0++;
            int num3 = num4;
            if (num3 <= 0x938)
            {
                if (num3 == 0x80c)
                {
                    this.class647_0.bool_0 = (bool) obj2;
                }
                else if (num3 != 0x92e)
                {
                    if (num3 != 0x938)
                    {
                        goto Label_00CA;
                    }
                    this.class647_0.bool_1 = (bool) obj2;
                }
                else
                {
                    this.class647_0.int_1 = (int) obj2;
                }
                continue;
            }
            switch (num3)
            {
                case 0x942:
                {
                    this.class647_0.string_2 = Class576.smethod_35(((float) ((int) obj2)) / 20f);
                    continue;
                }
                case 0x94c:
                {
                    this.class647_0.columnCollection_0 = (ColumnCollection) obj2;
                    continue;
                }
                case 0x271a:
                {
                    this.class647_0.class580_0 = (Class580) obj2;
                    continue;
                }
            }
        Label_00CA:
            this.class647_0.int_0--;
        }
        this.class647_0.string_3 = this.class422_0.method_15().Settings.method_5().method_13() ? BookmarkStart.b("䴸䤺䠼娾", num) : BookmarkStart.b("弸娺儼䰾⑀", num);
        this.class647_0.int_0++;
        return this.class647_0;
    }
}

