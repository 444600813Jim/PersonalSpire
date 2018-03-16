using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class1137
{
    private readonly Class422 class422_0;

    internal Class1137(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0()
    {
        int num = 13;
        Class400 class2 = this.class422_0.method_18();
        class2.method_4(BookmarkStart.b("尲匴儶倸堺堼Ծ❀ⱂ⭄㍆摈ⵊⱌⱎ㑐繒ㅔ㉖㩘㝚⹜", 13));
        CharacterFormat defCharFormat = this.class422_0.method_15().DefCharFormat;
        smethod_0(this.class422_0, defCharFormat);
        for (int i = 0; i < this.class422_0.method_15().Styles.Count; i++)
        {
            Style style = this.class422_0.method_15().Styles[i] as Style;
            if (style.RunPr != null)
            {
                smethod_0(this.class422_0, style.RunPr);
            }
        }
        for (int j = 0; j < this.class422_0.method_15().Sections.Count; j++)
        {
            smethod_1(this.class422_0, this.class422_0.method_15().Sections[j].HeadersFooters.EvenFooter);
            smethod_1(this.class422_0, this.class422_0.method_15().Sections[j].HeadersFooters.EvenHeader);
            smethod_1(this.class422_0, this.class422_0.method_15().Sections[j].HeadersFooters.FirstPageFooter);
            smethod_1(this.class422_0, this.class422_0.method_15().Sections[j].HeadersFooters.FirstPageHeader);
            smethod_1(this.class422_0, this.class422_0.method_15().Sections[j].HeadersFooters.OddFooter);
            smethod_1(this.class422_0, this.class422_0.method_15().Sections[j].HeadersFooters.OddHeader);
        }
        this.class422_0.method_107().method_12(this.class422_0.method_15().FontInfoList);
        using (IEnumerator enumerator = this.class422_0.method_107().System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Form4 current = (Form4) enumerator.Current;
                this.method_1(current);
            }
        }
        class2.method_6(BookmarkStart.b("尲匴儶倸堺堼Ծ❀ⱂ⭄㍆摈ⵊⱌⱎ㑐繒ㅔ㉖㩘㝚⹜", num));
    }

    private void method_1(Form4 A_0)
    {
        int num = 14;
        if (Class567.smethod_16(A_0.method_31()))
        {
            Class400 class2 = this.class422_0.method_18();
            class2.method_4(BookmarkStart.b("䜳䈵䄷嘹夻н☿ⵁ⩃㉅敇ⱉⵋⵍ㕏", num));
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н⸿⍁⥃⍅", num), A_0.method_31());
            class2.method_40(BookmarkStart.b("䜳䀵強9娻儽⸿㙁楃⁅⥇❉╋≍⥏", num), string.Format(BookmarkStart.b("伳ص䔷", num), A_0.method_31()));
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н☿ⵁ⩃㉅敇㩉╋㩍㍏㩑", num), Class922.smethod_27(A_0.method_41()));
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н☿ⵁ⩃㉅敇ⱉⵋ⍍㥏㹑ⵓ筕㽗㽙㉛㭝቟ୡݣ", num), Class922.smethod_25(A_0.method_39()));
            if (A_0.method_37() == 2)
            {
                class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н☿ⵁ⩃㉅敇⥉⑋⽍≏⅑ㅓ≕", num), BookmarkStart.b("䰳ᬵ䬷䌹儻尽⼿⹁", num));
            }
            class2.method_6(BookmarkStart.b("䜳䈵䄷嘹夻н☿ⵁ⩃㉅敇ⱉⵋⵍ㕏", num));
        }
    }

    private static void smethod_0(Class422 A_0, CharacterFormat A_1)
    {
        Document document = A_0.method_15();
        if (A_1.FontName != null)
        {
            Form4 form = new Form4(document, A_1.FontName);
            A_0.method_107().method_11(form);
        }
        if (A_1.FontNameAscii != null)
        {
            Form4 form2 = new Form4(document, A_1.FontNameAscii);
            A_0.method_107().method_11(form2);
        }
        if (A_1.FontNameFarEast != null)
        {
            Form4 form5 = new Form4(document, A_1.FontNameFarEast);
            A_0.method_107().method_11(form5);
        }
        if (A_1.FontNameBidi != null)
        {
            Form4 form4 = new Form4(document, A_1.FontNameBidi);
            A_0.method_107().method_11(form4);
        }
        if (A_1.FontNameNonFarEast != null)
        {
            Form4 form3 = new Form4(document, A_1.FontNameNonFarEast);
            A_0.method_107().method_11(form3);
        }
    }

    private static void smethod_1(Class422 A_0, DocumentObject A_1)
    {
        if ((A_1 is TextRange) && ((A_1 as TextRange).CharacterFormat != null))
        {
            smethod_0(A_0, (A_1 as TextRange).CharacterFormat);
        }
        DocumentObjectCollection childObjects = A_1.ChildObjects;
        if ((A_1 != null) && (childObjects.Count > 0))
        {
            for (int i = 0; i < childObjects.Count; i++)
            {
                smethod_1(A_0, childObjects[i]);
            }
        }
    }
}

