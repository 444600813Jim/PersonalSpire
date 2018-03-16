using Spire.Doc;
using System;
using System.Collections;

internal class Class562
{
    private Class562()
    {
    }

    internal static void smethod_0(Document A_0, Class399 A_1)
    {
        int num = 7;
        A_1.method_4(BookmarkStart.b("娬ᔮ地尲嬴䌶䨸", 7));
        A_1.method_4(BookmarkStart.b("娬ᔮ唰嘲匴嘶䰸场䤼社⹀ⵂㅄ㑆", 7));
        A_1.method_18(BookmarkStart.b("娬ᔮ倰䀲嘴帶倸", 7), A_0.DefaultFontNameTable.method_0());
        A_1.method_18(BookmarkStart.b("娬ᔮ地刲䜴制堸䠺䤼", 7), A_0.DefaultFontNameTable.method_2());
        A_1.method_18(BookmarkStart.b("娬ᔮ夰Ḳ吴夶䨸刺", 7), A_0.DefaultFontNameTable.method_4());
        A_1.method_18(BookmarkStart.b("娬ᔮ到䀲", 7), A_0.DefaultFontNameTable.method_6());
        A_1.method_5();
        using (IEnumerator enumerator = A_0.FontInfoList.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Form4 form = (Form4) enumerator.Current;
                A_1.method_4(BookmarkStart.b("娬ᔮ地尲嬴䌶", num));
                A_1.method_18(BookmarkStart.b("娬ᔮ弰刲場制", num), form.method_31());
                if (Class567.smethod_16(form.method_33()))
                {
                    if (form.method_33().IndexOf(BookmarkStart.b("⴬", num)) >= 0)
                    {
                        form.method_34(form.method_33().Substring(0, form.method_33().IndexOf(BookmarkStart.b("⴬", num))));
                    }
                    A_1.method_24(BookmarkStart.b("娬ᔮ倰弲䄴礶堸嘺堼", num), form.method_33().Replace(BookmarkStart.b("⴬", num), BookmarkStart.b("ᘬ", num)));
                }
                if (form.method_35() != null)
                {
                    A_1.method_24(BookmarkStart.b("娬ᔮ䄰刲嬴堶䨸帺ြ฾", num), Class567.smethod_40(form.method_35()));
                }
                A_1.method_24(BookmarkStart.b("娬ᔮ到嬲吴䔶䨸帺䤼", num), Class1041.smethod_39(form.method_37()));
                A_1.method_24(BookmarkStart.b("娬ᔮ地刲場帶唸䈺", num), Class911.smethod_1(form.method_39()));
                if (!form.method_43())
                {
                    A_1.method_10(BookmarkStart.b("娬ᔮ弰尲䄴挶䬸为堼款㡀㍂⁄", num));
                }
                A_1.method_24(BookmarkStart.b("娬ᔮ䄰娲䄴吶儸", num), Class417.smethod_7(form.method_41()));
                if (form.method_45() != null)
                {
                    A_1.method_4(BookmarkStart.b("娬ᔮ䈰娲刴", num));
                    A_1.method_18(BookmarkStart.b("娬ᔮ䐰䀲圴ᨶस", num), Class114.smethod_4(form.method_45(), 0));
                    A_1.method_18(BookmarkStart.b("娬ᔮ䐰䀲圴ᨶ࠸", num), Class114.smethod_4(form.method_45(), 4));
                    A_1.method_18(BookmarkStart.b("娬ᔮ䐰䀲圴ᨶସ", num), Class114.smethod_4(form.method_45(), 8));
                    A_1.method_18(BookmarkStart.b("娬ᔮ䐰䀲圴ᨶਸ", num), Class114.smethod_4(form.method_45(), 12));
                    A_1.method_18(BookmarkStart.b("娬ᔮ到䀲圴ᨶस", num), Class114.smethod_4(form.method_45(), 0x10));
                    A_1.method_18(BookmarkStart.b("娬ᔮ到䀲圴ᨶ࠸", num), Class114.smethod_4(form.method_45(), 20));
                    A_1.method_5();
                }
                A_1.method_5();
            }
        }
        A_1.method_5();
    }
}

