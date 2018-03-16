using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class690
{
    private readonly Class422 class422_0;
    private readonly Class974 class974_0;
    private int int_0;
    private readonly Stack stack_0 = new Stack();
    private readonly Stack stack_1 = new Stack();

    internal Class690(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class974_0 = new Class974(this.class422_0);
    }

    internal VisitorAction method_0(Table A_0)
    {
        int num = 6;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            Class400 class2 = this.class422_0.method_18();
            if (!A_0.HasChildElements)
            {
                this.class422_0.method_11(A_0, null);
                return VisitorAction.SkipThisElement;
            }
            this.stack_1.Push(new Class981(A_0, true, false, false));
            if (this.method_12(A_0))
            {
                return VisitorAction.Continue;
            }
            this.method_13().method_0();
            int[] numArray = this.method_13().method_6();
            string str = Class576.smethod_42((double) (((float) this.method_13().method_8().PreferredWidth.Value) / 20f));
            if (this.class422_0.method_21())
            {
                this.class974_0.method_12(this.method_6(), BookmarkStart.b("堫伭刯帱儳", num));
                this.class974_0.method_7(false, true);
                class2.method_4(BookmarkStart.b("弫娭䤯帱儳వ䰷嬹帻刽┿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num));
                class2.method_40(BookmarkStart.b("堫伭刯帱儳వ夷嘹唻夽⸿", num), Class922.smethod_50((TableAlignment) A_0.TableFormat.method_32(0xfaa)));
                class2.method_40(BookmarkStart.b("弫娭䤯帱儳వ伷匹堻䨽⠿", num), str);
                class2.method_40(BookmarkStart.b("䨫䄭ਯ弱唳䐵強匹刻ጽⰿ❁≃㉅", num), this.method_10());
                object obj2 = A_0.FirstRow.RowFormat.method_31(0x111c);
                if (obj2 != null)
                {
                    class2.method_40(BookmarkStart.b("弫娭䤯帱儳వ伷䠹唻䨽⤿ⱁ⍃歅╇╉⡋⭍", num), ((bool) obj2) ? BookmarkStart.b("師䈭ᴯ䘱嘳", num) : BookmarkStart.b("䀫尭ᴯ䘱嘳", num));
                }
                class2.method_6(BookmarkStart.b("弫娭䤯帱儳వ䰷嬹帻刽┿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num));
                class2.method_6(BookmarkStart.b("弫娭䤯帱儳వ䬷丹䔻刽┿", num));
                for (int i = 0; i < numArray.Length; i++)
                {
                    this.class974_0.method_12(this.method_7(), BookmarkStart.b("堫伭刯帱儳ᬵ嬷唹倻䬽ⴿⱁ", num));
                    class2.method_33(BookmarkStart.b("弫娭䤯帱儳వ䰷嬹帻刽┿潁❃⥅⑇㽉⅋⁍絏≑♓㥕⡗㽙⹛⩝य़ݡᝣ", num), new object[] { BookmarkStart.b("弫娭䤯帱儳వ嬷唹倻䬽ⴿⱁ楃ㅅⅇ⹉㡋♍", num), Class576.smethod_42((double) (((float) numArray[i]) / 20f)) });
                    class2.method_6(BookmarkStart.b("弫娭䤯帱儳వ䬷丹䔻刽┿", num));
                }
            }
            if (this.class422_0.method_22())
            {
                if (A_0.FirstNonMarkupDescendant.DocumentObjectType == DocumentObjectType.TableCell)
                {
                    this.stack_0.Push(this.int_0);
                }
                class2.method_4(BookmarkStart.b("堫伭刯帱儳వ䰷嬹帻刽┿", num));
                class2.method_40(BookmarkStart.b("堫伭刯帱儳వ䬷丹䔻刽┿潁⩃❅╇⽉", num), this.method_6());
                for (int j = 0; j < numArray.Length; j++)
                {
                    class2.method_33(BookmarkStart.b("堫伭刯帱儳వ䰷嬹帻刽┿潁❃⥅⑇㽉⅋⁍", num), new object[] { BookmarkStart.b("堫伭刯帱儳వ䬷丹䔻刽┿潁⩃❅╇⽉", num), this.method_7() });
                }
            }
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(Table A_0)
    {
        int num = 5;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            if (!this.method_12(A_0) && this.class422_0.method_22())
            {
                this.class422_0.method_18().method_6(BookmarkStart.b("弪䰬䴮崰嘲༴䌶堸夺儼娾", num));
                if (A_0.FirstNonMarkupDescendant.DocumentObjectType == DocumentObjectType.TableCell)
                {
                    this.int_0 = (int) this.stack_0.Pop();
                }
            }
            this.stack_1.Pop();
            this.class422_0.method_11(A_0, null);
        }
        return VisitorAction.Continue;
    }

    private string method_10()
    {
        float num;
        switch (((TableAlignment) this.method_13().method_8().TableFormat.method_32(0xfaa)))
        {
            case TableAlignment.Center:
                return Class576.smethod_35((Class969.smethod_31(this.method_11()) - this.method_13().method_10()) / 2);

            case TableAlignment.Right:
                return Class576.smethod_35(Class969.smethod_31(this.method_11()) - this.method_13().method_10());

            default:
            {
                Table table = this.method_13().method_8();
                num = 2.147484E+09f;
                int num2 = 0;
                for (TableRow row = table.Rows[0]; row != null; row = table.Rows[num2++])
                {
                    if (num2 >= table.Rows.Count)
                    {
                        break;
                    }
                    num = Math.Min(row.RowFormat.LeftIndent, num);
                }
                break;
            }
        }
        return Class576.smethod_42((double) num);
    }

    private double method_11()
    {
        Table table = this.method_13().method_8();
        if (table.FirstNonMarkupDescendant.DocumentObjectType == DocumentObjectType.TableCell)
        {
            TableCell firstNonMarkupDescendant = (TableCell) this.method_13().method_8().FirstNonMarkupDescendant;
            CellFormat cellFormat = firstNonMarkupDescendant.CellFormat;
            return (double) ((cellFormat.CellWidth - cellFormat.Paddings.Left) - cellFormat.Paddings.Right);
        }
        Section section = (Section) table.method_6(DocumentObjectType.Section);
        while (section.BreakCode != SectionBreakType.NewPage)
        {
            if (section.PreviousSibling == null)
            {
                break;
            }
            DocumentObject previousSibling = (DocumentObject) section.PreviousSibling;
            if ((previousSibling != null) && (previousSibling is Section))
            {
                section = (Section) previousSibling;
            }
        }
        PageSetup pageSetup = section.PageSetup;
        double left = Class576.smethod_48(3.0);
        if (section.SectPr.HasValue(0x8e8))
        {
            left = pageSetup.Margins.Left;
        }
        double right = Class576.smethod_48(1.499);
        if (section.SectPr.HasValue(0x8f2))
        {
            right = pageSetup.Margins.Right;
        }
        return ((pageSetup.PageSize.Width - left) - right);
    }

    private bool method_12(Table A_0)
    {
        bool flag = Class422.smethod_1(A_0);
        return ((this.class422_0.method_63() || ((!this.class422_0.method_20() || !flag) && (((this.class422_0.method_23() != OpenDocumentWritingStage.StylesAutomaticStyles) && (this.class422_0.method_23() != OpenDocumentWritingStage.StylesMasterPage)) || flag))) || ((A_0.ParentObject is ShapeObject) && Class468.smethod_3(A_0.ParentObject as ShapeObject)));
    }

    private Class981 method_13()
    {
        return (this.stack_1.Peek() as Class981);
    }

    internal VisitorAction method_2(TableRow A_0)
    {
        int num = 15;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            this.int_0 = 0;
            Class400 class2 = this.class422_0.method_18();
            if (this.method_12(A_0.OwnerTable))
            {
                return VisitorAction.Continue;
            }
            this.method_13().method_2();
            if (this.class422_0.method_21())
            {
                this.class974_0.method_12(this.method_8(), BookmarkStart.b("䄴嘶嬸场堼ሾ㍀ⱂ㉄", num));
                if (((A_0.RowFormat.method_31(0x1018) != null) && (A_0.RowFormat.HeightType != TableRowHeightType.Auto)) || !A_0.RowFormat.IsBreakAcrossPages)
                {
                    class2.method_4(BookmarkStart.b("䘴䌶䀸场堼Ծ㕀≂❄⭆ⱈ晊㽌⁎♐繒╔╖㙘⭚㡜ⵞᕠ੢dᑦ", num));
                    if (A_0.RowFormat.method_31(0x1018) != null)
                    {
                        if (A_0.RowFormat.HeightType == TableRowHeightType.Exactly)
                        {
                            class2.method_40(BookmarkStart.b("䘴䌶䀸场堼Ծ㍀ⱂ㉄橆ⅈ⹊⑌⡎㥐❒", num), Class576.smethod_42((double) A_0.RowFormat.Height));
                        }
                        else if (A_0.RowFormat.HeightType == TableRowHeightType.AtLeast)
                        {
                            class2.method_40(BookmarkStart.b("䘴䌶䀸场堼Ծⱀ⩂⭄橆㭈⑊㩌扎㥐㙒㱔ざㅘ⽚", num), Class576.smethod_42((double) A_0.RowFormat.Height));
                        }
                    }
                    if (!A_0.RowFormat.IsBreakAcrossPages)
                    {
                        class2.method_40(BookmarkStart.b("匴堶̸债堼娾ㅀ湂ㅄ⡆⹈⹊㥌❎㑐⅒", num), BookmarkStart.b("吴嬶丸娺䐼䰾", num));
                    }
                    class2.method_6(BookmarkStart.b("䘴䌶䀸场堼Ծ㕀≂❄⭆ⱈ晊㽌⁎♐繒╔╖㙘⭚㡜ⵞᕠ੢dᑦ", num));
                }
                class2.method_6(BookmarkStart.b("䘴䌶䀸场堼Ծ㉀㝂㱄⭆ⱈ", num));
            }
            if (this.class422_0.method_22())
            {
                if (A_0.RowFormat.IsHeader)
                {
                    class2.method_4(BookmarkStart.b("䄴嘶嬸场堼Ծ㕀≂❄⭆ⱈ晊╌⩎ぐ㝒ご╖瑘⥚㉜⡞በ", num));
                }
                class2.method_4(BookmarkStart.b("䄴嘶嬸场堼Ծ㕀≂❄⭆ⱈ晊㽌⁎♐", num));
                class2.method_40(BookmarkStart.b("䄴嘶嬸场堼Ծ㉀㝂㱄⭆ⱈ晊⍌⹎㱐㙒", num), this.method_8());
            }
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_3(TableRow A_0)
    {
        int num = 4;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            Class400 class2 = this.class422_0.method_18();
            if (!this.method_12(A_0.OwnerTable) && this.class422_0.method_22())
            {
                if (this.int_0 == 0)
                {
                    for (int i = 0; i < this.method_13().method_9(); i++)
                    {
                        class2.method_10(BookmarkStart.b("帩䴫䰭尯圱ำ唵圷䰹夻䰽┿♁楃㉅⥇⡉⁋⭍絏ㅑㅓ㩕㑗", num));
                    }
                }
                class2.method_6(BookmarkStart.b("帩䴫䰭尯圱ำ䈵夷堹倻嬽洿ぁ⭃ㅅ", num));
                if (A_0.IsHeader)
                {
                    class2.method_6(BookmarkStart.b("帩䴫䰭尯圱ำ䈵夷堹倻嬽洿⩁⅃❅ⱇ⽉㹋捍≏㵑⍓╕", num));
                }
            }
            this.method_13().method_1();
            this.class422_0.method_11(A_0, null);
        }
        return VisitorAction.Continue;
    }

    internal VisitorAction method_4(TableCell A_0)
    {
        int num = 0x13;
        if (this.class422_0.method_23() == OpenDocumentWritingStage.MathML)
        {
            return VisitorAction.Continue;
        }
        Class400 class2 = this.class422_0.method_18();
        if (this.method_12(A_0.OwnerRow.OwnerTable))
        {
            return VisitorAction.Continue;
        }
        if ((A_0.CellFormat.HorizontalMerge != CellMerge.Continue) && (A_0.CellFormat.VerticalMerge != CellMerge.Continue))
        {
            if (this.class422_0.method_21())
            {
                this.class974_0.method_12(this.method_9(), BookmarkStart.b("䴸娺弼匾⑀湂♄≆╈❊", num));
                new Class337(this.class422_0).method_0(A_0);
                class2.method_6(BookmarkStart.b("䨸伺䐼匾⑀祂㙄㍆え❊⡌", num));
            }
            if (this.class422_0.method_22() && (this.method_13().method_12() != null))
            {
                class2.method_4(BookmarkStart.b("䴸娺弼匾⑀祂ㅄ♆⭈❊⡌扎㉐㙒㥔㭖", num));
                this.int_0++;
                string str = this.method_9();
                class2.method_40(BookmarkStart.b("䴸娺弼匾⑀祂㙄㍆え❊⡌扎㽐㉒㡔㉖", num), str);
                if (this.method_13().method_12().method_3() > 1)
                {
                    class2.method_43(BookmarkStart.b("䴸娺弼匾⑀祂⭄㉆⑈⥊⡌㵎籐げ㩔㭖ⱘ㙚㍜ⱞ䱠ၢᕤ٦ݨժ࡬୮", num), this.method_13().method_12().method_3());
                }
                if (this.method_13().method_12().method_5() > 1)
                {
                    class2.method_43(BookmarkStart.b("䴸娺弼匾⑀祂⭄㉆⑈⥊⡌㵎籐⅒㩔⁖⩘癚⹜⽞`ൢ୤ɦ൨", num), this.method_13().method_12().method_5());
                }
            }
            return VisitorAction.Continue;
        }
        if (this.class422_0.method_23() != OpenDocumentWritingStage.ContentAutomaticStyles)
        {
            class2.method_10(BookmarkStart.b("䴸娺弼匾⑀祂♄⡆㽈⹊㽌⩎㕐繒⅔㙖㭘㝚㡜牞ɠ٢।୦", num));
        }
        return VisitorAction.SkipThisElement;
    }

    internal VisitorAction method_5(TableCell A_0)
    {
        int num = 12;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            Class400 class2 = this.class422_0.method_18();
            if ((!this.method_12(A_0.OwnerRow.OwnerTable) && this.class422_0.method_22()) && (this.method_13().method_12() != null))
            {
                class2.method_6(BookmarkStart.b("䘱唳吵吷弹ػ䨽ℿ⁁⡃⍅敇⥉⥋≍㱏", num));
            }
            this.method_13().method_3();
            this.class422_0.method_11(A_0, null);
        }
        return VisitorAction.Continue;
    }

    internal string method_6()
    {
        this.class422_0.method_42(this.class422_0.method_41() + 1);
        return string.Format(BookmarkStart.b("簧䬩丫䈭唯䤱г䬵", 2), this.class422_0.method_41());
    }

    internal string method_7()
    {
        this.class422_0.method_44(this.class422_0.method_43() + 1);
        return string.Format(BookmarkStart.b("欧䔩䀫嬭崯就伳ص䔷", 2), this.class422_0.method_43());
    }

    internal string method_8()
    {
        this.class422_0.method_46(this.class422_0.method_45() + 1);
        return string.Format(BookmarkStart.b("搵圷䴹䜻฽㴿", 0x10), this.class422_0.method_45());
    }

    internal string method_9()
    {
        this.class422_0.method_48(this.class422_0.method_47() + 1);
        return string.Format(BookmarkStart.b("笷弹倻刽㬿牁㥃", 0x12), this.class422_0.method_47());
    }
}

