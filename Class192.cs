using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Class192
{
    [ThreadStatic]
    public static Class192 class192_0;
    private List<Paragraph> list_0;

    internal List<Paragraph> method_0()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<Paragraph>();
        }
        return this.list_0;
    }

    public Class185 method_1(Paragraph A_0, Regex A_1, bool A_2)
    {
        string text = A_0.Text;
        MatchCollection matchs = A_1.Matches(text);
        Class185 class2 = new Class185();
        if (matchs.Count > 0)
        {
            foreach (Match match in matchs)
            {
                int index = match.Index;
                int endCharPos = match.Index + match.Length;
                TextSelection item = new TextSelection(A_0, index, endCharPos) {
                    class185_0 = class2
                };
                class2.Add(item);
                if (A_2)
                {
                    break;
                }
            }
        }
        smethod_1(A_0, A_1, A_2, class2);
        return class2;
    }

    public TextSelection[] method_2(Body A_0, Regex A_1)
    {
        if (A_0.Items.Count == 0)
        {
            return null;
        }
        return this.method_3(A_0, A_1, 0, A_0.Items.Count - 1);
    }

    public TextSelection[] method_3(Body A_0, Regex A_1, int A_2, int A_3)
    {
        TextSelection[] selectionArray = null;
        Paragraph paragraph = null;
        Table table = null;
        for (int i = A_2; i <= A_3; i++)
        {
            if (A_0.Items[i] is Paragraph)
            {
                paragraph = A_0.Items[i] as Paragraph;
                selectionArray = this.method_4(paragraph, A_1, 0, paragraph.Items.Count - 1);
                if (selectionArray != null)
                {
                    return selectionArray;
                }
                selectionArray = this.method_5(A_1);
            }
            else if (A_0.Items[i] is Table)
            {
                table = A_0.Items[i] as Table;
                selectionArray = this.method_6(table, A_1);
            }
            if (selectionArray != null)
            {
                return selectionArray;
            }
        }
        return this.method_5(A_1);
    }

    internal TextSelection[] method_4(Paragraph A_0, Regex A_1, int A_2, int A_3)
    {
        if (!this.method_0().Contains(A_0))
        {
            this.method_0().Add(A_0);
        }
        Class185 class2 = null;
        for (int i = A_2; i <= A_3; i++)
        {
            ParagraphBase base2 = A_0[i];
            List<Body> list = Class191.smethod_5(base2);
            if (list.Count > 0)
            {
                foreach (Body body in list)
                {
                    TextSelection[] collection = this.method_2(body, A_1);
                    if (collection != null)
                    {
                        if (class2 == null)
                        {
                            class2 = new Class185();
                        }
                        class2.AddRange(collection);
                    }
                }
            }
            list.Clear();
            list = null;
        }
        if ((class2 != null) && (class2.Count > 0))
        {
            return class2.ToArray();
        }
        return null;
    }

    internal TextSelection[] method_5(Regex A_0)
    {
        if ((this.list_0 != null) && (this.list_0.Count != 0))
        {
            string input = string.Empty;
            Paragraph paragraph2 = null;
            Match match = null;
            StringBuilder builder = new StringBuilder();
            int num2 = 0;
            int count = this.list_0.Count;
            while (num2 < count)
            {
                paragraph2 = this.list_0[num2];
                builder.Append(paragraph2.Text);
                if (num2 == (count - 1))
                {
                    input = builder.ToString();
                    match = A_0.Match(input);
                }
                num2++;
            }
            if ((match != null) && match.Success)
            {
                Class185 class2;
                int index = match.Index;
                int num = index + match.Length;
                if ((index == 0) && (num == input.Length))
                {
                    class2 = new Class185();
                    foreach (Paragraph paragraph in this.list_0)
                    {
                        if (match.Length == paragraph.Text.Length)
                        {
                            TextSelection item = new TextSelection(paragraph, 0, paragraph.Text.Length);
                            class2.Add(item);
                        }
                    }
                }
                else
                {
                    class2 = this.method_7(this.list_0, match);
                }
                if ((class2 != null) && (class2.Count > 0))
                {
                    this.list_0.Clear();
                    return class2.ToArray();
                }
            }
        }
        return null;
    }

    internal TextSelection[] method_6(Table A_0, Regex A_1)
    {
        TextSelection[] selectionArray = null;
        foreach (TableRow row in A_0.Rows)
        {
            foreach (TableCell cell in row.Cells)
            {
                selectionArray = this.method_2(cell, A_1);
                if (selectionArray != null)
                {
                    return selectionArray;
                }
            }
        }
        return selectionArray;
    }

    private Class185 method_7(List<Paragraph> A_0, Match A_1)
    {
        int index = A_1.Index;
        int num2 = index + A_1.Length;
        string str = string.Empty;
        int num3 = 0;
        int length = 0;
        Class185 class2 = null;
        using (List<Paragraph>.Enumerator enumerator = A_0.GetEnumerator())
        {
            int num5;
            Paragraph current;
            int num6;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                num6 = -1;
                num5 = -1;
                length = str.Length;
                str = str + current.Text;
                num3 = str.Length;
                if ((length <= index) && (index <= num3))
                {
                    class2 = new Class185();
                    num6 = index - length;
                }
                if ((length <= num2) && (num2 <= (num3 + 1)))
                {
                    num5 = num2 - length;
                }
                if ((num6 == -1) && (num5 == -1))
                {
                    if (((length > index) && (num3 < num2)) && (current.Text != string.Empty))
                    {
                        class2.Add(new TextSelection(current, 0, current.Text.Length));
                    }
                }
                else
                {
                    if ((num6 != -1) && (num5 != -1))
                    {
                        goto Label_012C;
                    }
                    if ((num6 != -1) && (num6 < current.Text.Length))
                    {
                        class2.Add(new TextSelection(current, num6, current.Text.Length));
                        continue;
                    }
                    if ((num5 != -1) && (num5 <= current.Text.Length))
                    {
                        goto Label_0140;
                    }
                }
            }
            return class2;
        Label_012C:
            class2.Add(new TextSelection(current, num6, num5));
            return class2;
        Label_0140:
            class2.Add(new TextSelection(current, 0, num5));
        }
        return class2;
    }

    public static Class192 smethod_0()
    {
        if (class192_0 == null)
        {
            class192_0 = new Class192();
        }
        return class192_0;
    }

    private static void smethod_1(Paragraph A_0, Regex A_1, bool A_2, Class185 A_3)
    {
        if ((A_3.Count <= 0) || !A_2)
        {
            foreach (ParagraphBase base2 in A_0.Items)
            {
                if (A_2 && (A_3.Count > 0))
                {
                    break;
                }
                List<Body> list = Class191.smethod_5(base2);
                if (list.Count > 0)
                {
                    using (List<Body>.Enumerator enumerator2 = list.GetEnumerator())
                    {
                        TextSelection selection;
                        while (enumerator2.MoveNext())
                        {
                            Body current = enumerator2.Current;
                            if (A_2)
                            {
                                selection = current.method_22(A_1);
                                if (selection == null)
                                {
                                    continue;
                                }
                                goto Label_009E;
                            }
                            Class185 collection = current.method_23(A_1);
                            if ((collection != null) && (collection.Count > 0))
                            {
                                A_3.AddRange(collection);
                            }
                        }
                        goto Label_00E4;
                    Label_009E:
                        A_3.Add(selection);
                        goto Label_00E4;
                    }
                }
                if (base2 is StructureDocumentTagInline)
                {
                    Class185 class2 = smethod_2((base2 as StructureDocumentTagInline).SDTContent, A_1, A_2);
                    if ((class2 != null) && (class2.Count > 0))
                    {
                        A_3.AddRange(class2);
                    }
                }
            Label_00E4:
                list.Clear();
                list = null;
            }
        }
    }

    private static Class185 smethod_2(SDTInlineContent A_0, Regex A_1, bool A_2)
    {
        string text = A_0.Text;
        MatchCollection matchs = A_1.Matches(text);
        Class185 class2 = new Class185();
        if (matchs.Count > 0)
        {
            foreach (Match match in matchs)
            {
                int index = match.Index;
                int num2 = match.Index + match.Length;
                TextSelection item = new TextSelection(A_0, index, num2) {
                    class185_0 = class2
                };
                class2.Add(item);
                if (A_2)
                {
                    break;
                }
            }
        }
        smethod_3(A_0, A_1, A_2, class2);
        return class2;
    }

    private static void smethod_3(SDTInlineContent A_0, Regex A_1, bool A_2, Class185 A_3)
    {
        if ((A_3.Count <= 0) || !A_2)
        {
            foreach (ParagraphBase base2 in A_0.Items)
            {
                if (A_2 && (A_3.Count > 0))
                {
                    break;
                }
                List<Body> list = Class191.smethod_5(base2);
                if (list.Count > 0)
                {
                    using (List<Body>.Enumerator enumerator2 = list.GetEnumerator())
                    {
                        TextSelection selection;
                        while (enumerator2.MoveNext())
                        {
                            Body current = enumerator2.Current;
                            if (A_2)
                            {
                                selection = current.method_22(A_1);
                                if (selection == null)
                                {
                                    continue;
                                }
                                goto Label_009E;
                            }
                            Class185 collection = current.method_23(A_1);
                            if ((collection != null) && (collection.Count > 0))
                            {
                                A_3.AddRange(collection);
                            }
                        }
                        goto Label_00E4;
                    Label_009E:
                        A_3.Add(selection);
                        goto Label_00E4;
                    }
                }
                if (base2 is StructureDocumentTagInline)
                {
                    Class185 class2 = smethod_2((base2 as StructureDocumentTagInline).SDTContent, A_1, A_2);
                    if ((class2 != null) && (class2.Count > 0))
                    {
                        A_3.AddRange(class2);
                    }
                }
            Label_00E4:
                list.Clear();
                list = null;
            }
        }
    }
}

