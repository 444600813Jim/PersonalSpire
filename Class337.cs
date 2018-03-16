using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;

internal class Class337
{
    private readonly Class422 class422_0;
    private Class86 class86_0;

    internal Class337(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0(TableCell A_0)
    {
        int num = 14;
        Class400 class2 = this.class422_0.method_18();
        this.class86_0 = new Class86();
        this.method_1(A_0, A_0.CellFormat);
        if (this.class86_0.class580_0 != null)
        {
            this.method_1(A_0, this.class86_0.class580_0.method_4());
        }
        class2.method_4(BookmarkStart.b("䜳䈵䄷嘹夻н㐿⍁♃⩅ⵇ杉⽋⭍㱏㹑祓♕⩗㕙ⱛ㭝቟ᙡൣͥ᭧", num));
        class2.method_40(BookmarkStart.b("刳夵ȷ堹崻崽⬿╁㙃⥅㵇⑉⡋捍㍏㵑㡓㥕⩗", num), this.class86_0.string_0);
        class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㘿❁㙃㉅ⅇ⥉ⵋ≍絏㍑㡓㽕㽗㑙", num), this.class86_0.string_1);
        this.class86_0.class1048_0.method_0(class2);
        if (!this.class422_0.method_14().method_13())
        {
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㜿ぁⵃ㉅ⅇ⑉⭋捍㵏㵑こ㍕", num), this.class86_0.string_2);
        }
        object obj2 = A_0.CellFormat.method_31(0xc6c);
        if (obj2 != null)
        {
            class2.method_40(BookmarkStart.b("刳夵ȷ䴹主弽〿潁⭃㙅㱇⍉⍋⁍", num), ((bool) obj2) ? BookmarkStart.b("䌳䐵夷䨹", num) : BookmarkStart.b("娳夵ᔷ䴹主弽〿", num));
        }
        class2.method_6(BookmarkStart.b("䜳䈵䄷嘹夻н㐿⍁♃⩅ⵇ杉⽋⭍㱏㹑祓♕⩗㕙ⱛ㭝቟ᙡൣͥ᭧", num));
    }

    private void method_1(TableCell A_0, WordAttrCollection A_1)
    {
        VerticalAlignment bottom = VerticalAlignment.Bottom;
        TextOrientation horizontal = TextOrientation.Horizontal;
        bool flag = false;
        for (int i = 0; i < A_1.Count; i++)
        {
            int num3 = A_1.method_18(i);
            object obj2 = A_1.method_19(i);
            if (obj2 != null)
            {
                this.class86_0.int_0++;
                switch (num3)
                {
                    case 1:
                    {
                        Borders borders = obj2 as Borders;
                        if (!borders.Top.IsDefault)
                        {
                            this.class86_0.class1048_0.class411_0.border_0 = borders.Top;
                        }
                        if (!borders.Bottom.IsDefault)
                        {
                            this.class86_0.class1048_0.class411_1.border_0 = borders.Bottom;
                        }
                        if (!borders.Left.IsDefault)
                        {
                            this.class86_0.class1048_0.class411_2.border_0 = borders.Left;
                        }
                        if (!borders.Right.IsDefault)
                        {
                            this.class86_0.class1048_0.class411_3.border_0 = borders.Right;
                        }
                        this.class86_0.int_0--;
                        continue;
                    }
                    case 2:
                    {
                        Paddings paddings = obj2 as Paddings;
                        float top = paddings.Top;
                        this.class86_0.class1048_0.class411_0.string_2 = Class576.smethod_42((double) paddings.Top);
                        float single2 = paddings.Bottom;
                        this.class86_0.class1048_0.class411_1.string_2 = Class576.smethod_42((double) paddings.Bottom);
                        float left = paddings.Left;
                        this.class86_0.class1048_0.class411_2.string_2 = Class576.smethod_42((double) paddings.Left);
                        float right = paddings.Right;
                        this.class86_0.class1048_0.class411_3.string_2 = Class576.smethod_42((double) paddings.Right);
                        this.class86_0.int_0--;
                        continue;
                    }
                    case 0xbea:
                    {
                        horizontal = (TextOrientation) obj2;
                        this.class86_0.string_2 = Class922.smethod_12((TextOrientation) obj2);
                        if (this.class86_0.string_2 == null)
                        {
                            this.class86_0.int_0--;
                        }
                        continue;
                    }
                    case 0xbf4:
                    {
                        flag = true;
                        bottom = (VerticalAlignment) obj2;
                        continue;
                    }
                    case 0xc62:
                    {
                        this.class86_0.string_0 = Class576.smethod_83((Class16) obj2);
                        continue;
                    }
                    case 0x271a:
                    {
                        this.class86_0.class580_0 = (Class580) obj2;
                        continue;
                    }
                }
                this.class86_0.int_0--;
            }
        }
        this.method_2(A_0, bottom, horizontal, flag);
        this.method_4(A_0);
        this.method_3(A_0, (CellFormat) A_1);
    }

    private void method_2(TableCell A_0, VerticalAlignment A_1, TextOrientation A_2, bool A_3)
    {
        Paragraph paragraph = A_0.method_55();
        if (paragraph != null)
        {
            this.class86_0.string_1 = Class922.smethod_10(A_1, A_2, paragraph.Format.HorizontalAlignment, A_3);
        }
        if (!Class567.smethod_16(this.class86_0.string_1) && A_3)
        {
            this.class86_0.int_0--;
        }
        if (Class567.smethod_16(this.class86_0.string_1) && !A_3)
        {
            this.class86_0.int_0++;
        }
    }

    private void method_3(TableCell A_0, CellFormat A_1)
    {
        RowFormat rowFormat = A_0.OwnerRow.RowFormat;
        float num = A_1.HasKey(0xbfe) ? A_1.Paddings.Top : rowFormat.Paddings.Top;
        float num4 = A_1.HasKey(0xc08) ? A_1.Paddings.Bottom : rowFormat.Paddings.Bottom;
        float num2 = A_1.HasKey(0xc12) ? A_1.Paddings.Left : rowFormat.Paddings.Left;
        float num3 = A_1.HasKey(0xc1c) ? A_1.Paddings.Right : rowFormat.Paddings.Right;
        if (A_1.CellWidth <= (num2 + num3))
        {
            num3 = 0f;
            num2 = 0f;
        }
        if (num != 0f)
        {
            this.class86_0.class1048_0.class411_0.string_2 = Class576.smethod_42((double) num);
        }
        if (num4 != 0f)
        {
            this.class86_0.class1048_0.class411_1.string_2 = Class576.smethod_42((double) num4);
        }
        if (num2 != 0f)
        {
            this.class86_0.class1048_0.class411_2.string_2 = Class576.smethod_42((double) num2);
        }
        if (num3 != 0f)
        {
            this.class86_0.class1048_0.class411_3.string_2 = Class576.smethod_42((double) num3);
        }
    }

    private void method_4(TableCell A_0)
    {
        RowFormat rowFormat = A_0.OwnerRow.RowFormat;
        if (((this.class86_0.class1048_0.class411_0.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0.OwnerRow != A_0.OwnerRow.OwnerTable.FirstRow))
        {
            this.class86_0.class1048_0.class411_0.border_0 = rowFormat.Borders.Horizontal;
        }
        if (((this.class86_0.class1048_0.class411_1.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0.OwnerRow != A_0.OwnerRow.OwnerTable.LastRow))
        {
            this.class86_0.class1048_0.class411_1.border_0 = rowFormat.Borders.Horizontal;
        }
        if (((this.class86_0.class1048_0.class411_2.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0 != A_0.OwnerRow.Cells[0]))
        {
            this.class86_0.class1048_0.class411_2.border_0 = rowFormat.Borders.Vertical;
        }
        if (((this.class86_0.class1048_0.class411_3.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0 != A_0.OwnerRow.Cells[A_0.OwnerRow.Cells.Count - 1]))
        {
            this.class86_0.class1048_0.class411_3.border_0 = rowFormat.Borders.Vertical;
        }
        if (((this.class86_0.class1048_0.class411_0.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0.OwnerRow == A_0.OwnerRow.OwnerTable.FirstRow))
        {
            this.class86_0.class1048_0.class411_0.border_0 = rowFormat.Borders.Top;
        }
        if (((this.class86_0.class1048_0.class411_1.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0.OwnerRow == A_0.OwnerRow.OwnerTable.LastRow))
        {
            this.class86_0.class1048_0.class411_1.border_0 = rowFormat.Borders.Bottom;
        }
        if (((this.class86_0.class1048_0.class411_2.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0 == A_0.OwnerRow.Cells[0]))
        {
            this.class86_0.class1048_0.class411_2.border_0 = rowFormat.Borders.Left;
        }
        if (((this.class86_0.class1048_0.class411_3.border_0 == null) && (A_0.OwnerRow.OwnerTable != null)) && (A_0 == A_0.OwnerRow.Cells[A_0.OwnerRow.Cells.Count - 1]))
        {
            this.class86_0.class1048_0.class411_3.border_0 = rowFormat.Borders.Right;
        }
        if ((rowFormat.Borders.IsDefault || rowFormat.Borders.NoBorder) && (A_0.CellFormat.Borders.IsDefault && (A_0.OwnerRow.OwnerTable.TableStyle != null)))
        {
            RowFormat format2 = A_0.OwnerRow.OwnerTable.TableStyle.imethod_3();
            this.class86_0.class1048_0.class411_0.border_0 = format2.Borders.Top;
            this.class86_0.class1048_0.class411_1.border_0 = format2.Borders.Bottom;
            this.class86_0.class1048_0.class411_2.border_0 = format2.Borders.Left;
            this.class86_0.class1048_0.class411_3.border_0 = format2.Borders.Right;
        }
        this.class86_0.class1048_0.method_1(true, false);
    }
}

