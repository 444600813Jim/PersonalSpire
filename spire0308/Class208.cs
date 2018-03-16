using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Layouting;
using System;
using System.Collections.Generic;

internal class Class208 : Class206
{
    internal List<float> list_3;

    public Class208(Paragraph A_0, ListLevel A_1) : base(ChildrenLayoutDirection.Horizontal)
    {
        this.list_3 = new List<float>();
        base.double_1 = A_0.Document.LastSection.PageSetup.DefaultTabWidth;
        this.method_28(A_1.ParagraphFormat.TabsEx);
        this.method_28(A_0.Format.TabsEx);
    }

    internal void method_28(TabCollection A_0)
    {
        if (A_0 != null)
        {
            int num = 0;
            int count = A_0.Count;
            while (num < count)
            {
                Tab tab = A_0[num];
                if (tab.DeletePosition == 0f)
                {
                    base.method_24(tab.Position, (TabJustification) tab.Justification, (TabLeader) tab.TabLeader);
                }
                else if (tab.DeletePosition != 0f)
                {
                    base.method_25(tab.DeletePosition / 20f);
                }
                num++;
            }
        }
    }
}

