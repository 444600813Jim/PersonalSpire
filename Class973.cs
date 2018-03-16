using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using System;
using System.Collections;

internal class Class973
{
    private readonly Class422 class422_0;

    internal Class973(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0()
    {
        Class400 class2 = this.class422_0.method_18();
        class2.method_4(BookmarkStart.b("䈬䤮地娲嘴制̸夺刼嬾㡀", 7));
        class2.method_4(BookmarkStart.b("䈬䤮地娲嘴制̸伺堼䜾㕀", 7));
        this.method_2();
        this.class422_0.method_24(OpenDocumentWritingStage.ContentBody);
    }

    internal VisitorAction method_1()
    {
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            Class400 class2 = this.class422_0.method_18();
            class2.method_5();
            class2.method_5();
            class2.method_3();
        }
        return VisitorAction.Continue;
    }

    private void method_2()
    {
        int num = 8;
        ArrayList list = this.method_3();
        if (list.Count != 0)
        {
            Class400 class2 = this.class422_0.method_18();
            class2.method_4(BookmarkStart.b("䄭嘯吱崳唵崷9娻儽㈿⽁㝃", num));
            class2.method_4(BookmarkStart.b("䠭弯䀱夳వ帷唹主匽", num));
            class2.method_40(BookmarkStart.b("䠭弯䀱夳వ嬷唹刻䨽㈿ⵁ⡃歅ⅇ❉㱋≍㕏㽑ㅓ㡕ⱗ㭙⡛㝝ཟౡ", num), BookmarkStart.b("䄭弯崱ำ唵圷圹ሻ䴽㔿ⱁ橃㕅㱇⭉㹋恍㙏㵑♓㭕癗㥙㍛㍝ၟൡ੣ͥ٧ṩ䉫⡭Ὧqᥳ", num));
            for (int i = 0; i < list.Count; i++)
            {
                FormField field = (FormField) list[i];
                if (field.FormFieldType == FormFieldType.CheckBox)
                {
                    class2.method_4(BookmarkStart.b("䠭弯䀱夳వ嬷刹夻崽⬿⁁⭃㹅", num));
                    class2.method_40(BookmarkStart.b("䠭弯䀱夳వ嬷唹刻䨽㈿ⵁ⡃歅ⅇ❉㱋≍㕏㽑ㅓ㡕ⱗ㭙⡛㝝ཟౡ", num), BookmarkStart.b("䄭弯崱ำ唵圷圹ሻ䴽㔿ⱁ橃㕅㱇⭉㹋恍㙏㵑♓㭕癗㥙㍛㍝ၟൡ੣ͥ٧ṩ䉫⵭ᡯ᝱ᝳᵵ㩷ᕹѻ", num));
                    class2.method_40(BookmarkStart.b("䠭弯䀱夳వ儷帹", num), string.Format(BookmarkStart.b("䴭弯就䀳䐵圷嘹䜻฽㴿", num), this.class422_0.method_31()));
                    this.class422_0.method_32(this.class422_0.method_31() + 1);
                    if ((field as CheckBoxFormField).Checked && !this.class422_0.method_14().method_13())
                    {
                        class2.method_40(BookmarkStart.b("䴭䔯䀱䘳匵嘷丹ᄻ䴽㐿⍁ぃ⍅", num), BookmarkStart.b("䴭堯圱圳崵崷帹", num));
                    }
                    class2.method_6(BookmarkStart.b("䠭弯䀱夳వ嬷刹夻崽⬿⁁⭃㹅", num));
                }
            }
            class2.method_6(BookmarkStart.b("䠭弯䀱夳వ帷唹主匽", num));
            class2.method_6(BookmarkStart.b("䄭嘯吱崳唵崷9娻儽㈿⽁㝃", num));
            this.class422_0.method_32(0);
        }
    }

    private ArrayList method_3()
    {
        ArrayList list = new ArrayList();
        foreach (Field field in this.class422_0.method_15().Fields)
        {
            if (field.Type == FieldType.FieldFormCheckBox)
            {
                list.Add(field);
            }
        }
        return list;
    }
}

