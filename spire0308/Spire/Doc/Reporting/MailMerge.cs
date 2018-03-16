namespace Spire.Doc.Reporting
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class MailMerge
    {
        private bool bool_0 = true;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private bool bool_7;
        private Class55 class55_0;
        private DataSet dataSet_0;
        private DataSet dataSet_1;
        private DbConnection dbConnection_0;
        private Dictionary<string, IRowsEnumerator> dictionary_0;
        private Dictionary<string, string> dictionary_1;
        private Dictionary<string, bool> dictionary_2;
        private Dictionary<string, Class882> dictionary_3;
        private Dictionary<string, Spire.Doc.Fields.MergeField> dictionary_4;
        private Spire.Doc.Document document_0;
        private int int_0;
        private List<DictionaryEntry> list_0;
        private List<DictionaryEntry> list_1;
        private List<object> list_2;
        private MailMergeDataSet mailMergeDataSet_0;
        private MailMergeDataSet mailMergeDataSet_1;
        private Regex regex_0;
        private SectionCollection sectionCollection_0;
        private Stack<Class55> stack_0;
        private string[] string_0;
        private string[] string_1;

        public event MergeFieldEventHandler MergeField;

        public event MergeGroupEventHandler MergeGroup;

        public event MergeImageFieldEventHandler MergeImageField;

        internal MailMerge(Spire.Doc.Document A_0)
        {
            this.document_0 = A_0;
            this.sectionCollection_0 = new SectionCollection();
            this.class55_0 = new Class55(new Class55.Delegate0(this.method_2));
        }

        public void Execute(IEnumerable dataSource)
        {
            int num = 6;
            if (dataSource == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䠫伭䐯匱䜳夵䴷䠹弻嬽", num));
            }
            MailMergeDataTable table = new MailMergeDataTable(string.Empty, dataSource);
            this.ExecuteGroup(table);
        }

        public void Execute(DataRow row)
        {
            int num = 5;
            if (row == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("太䈬堮", num));
            }
            this.method_35(new Class194(row));
        }

        public void Execute(DataTable table)
        {
            int num = 14;
            if (table == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䀳圵娷嘹夻", num));
            }
            this.method_35(new Class194(table));
        }

        public void Execute(DataView dataView)
        {
            int num = 0x10;
            if (dataView == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("刵夷丹崻栽⤿❁㍃", num));
            }
            this.method_35(new Class948(dataView));
        }

        public void Execute(IDataReader dataReader)
        {
            int num = 12;
            if (dataReader == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嘱唳䈵夷根夻弽␿❁㙃", num));
            }
            this.method_35(new Class949(dataReader));
        }

        public void Execute(OleDbDataReader dataReader)
        {
            int num = 3;
            if (dataReader == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䴨䨪夬丮挰嘲吴匶尸䤺", num));
            }
            this.method_35(new Class949(dataReader));
        }

        public void Execute(string[] fieldNames, string[] fieldValues)
        {
            int num = 0x13;
            this.Document.bool_4 = true;
            if (fieldNames == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("弸刺堼匾╀ൂ⑄⩆ⱈ㡊", num));
            }
            if (fieldValues == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("弸刺堼匾╀ᕂ⑄⭆㱈⹊㹌", num));
            }
            this.string_0 = fieldNames;
            this.string_1 = fieldValues;
            if (this.string_0.Length > 0)
            {
                ISection section = null;
                int num2 = 0;
                int count = this.Document.Sections.Count;
                while (num2 < count)
                {
                    section = this.Document.Sections[num2];
                    this.method_36(section, null);
                    num2++;
                }
            }
            this.method_13();
            this.Document.bool_4 = false;
        }

        public void ExecuteGroup(MailMergeDataTable dataSource)
        {
            int num = 14;
            if (dataSource == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("倳圵䰷嬹伻儽㔿ぁ❃⍅", num));
            }
            if (dataSource.GroupName == string.Empty)
            {
                this.method_35(new Class194(dataSource));
            }
            else
            {
                this.method_14(new Class194(dataSource));
            }
        }

        public void ExecuteWidthNestedRegion(MailMergeDataSet dataSource, List<DictionaryEntry> filters)
        {
            int num = 1;
            if ((dataSource == null) || (dataSource.DataSet.Count == 0))
            {
                throw new ArgumentException(BookmarkStart.b("䌦䠨弪䰬簮吰䜲ᔴ帶䨸ᬺ堼刾ㅀ㝂㱄", num));
            }
            if ((filters == null) || ((filters != null) && (filters.Count == 0)))
            {
                throw new ArgumentException(BookmarkStart.b("䐦䘨䘪䀬丮弰圲䘴᜶唸刺丼䬾慀⩂㙄杆ⱈ♊㵌㭎⡐", num));
            }
            this.method_67();
            this.mailMergeDataSet_0 = dataSource;
            this.list_1 = filters;
            DictionaryEntry entry = filters[0];
            this.Document.bool_4 = true;
            this.bool_6 = true;
            this.method_22((string) entry.Key);
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
            if (this.dataSet_1 != null)
            {
                this.dataSet_1.Clear();
                this.dataSet_1 = null;
            }
            this.method_13();
            this.Document.bool_4 = false;
            this.bool_6 = false;
        }

        public void ExecuteWidthNestedRegion(DbConnection conn, List<DictionaryEntry> commands)
        {
            int num = 1;
            if (conn == null)
            {
                throw new ArgumentException(BookmarkStart.b("䐦䘨䔪䌬", num));
            }
            if ((commands == null) || ((commands != null) && (commands.Count == 0)))
            {
                throw new ArgumentException(BookmarkStart.b("䐦䘨䘪䀬丮弰圲䘴᜶唸刺丼䬾慀⩂㙄杆ⱈ♊㵌㭎⡐", num));
            }
            this.method_67();
            this.dbConnection_0 = conn;
            this.list_0 = commands;
            DictionaryEntry entry = commands[0];
            this.Document.bool_4 = true;
            this.bool_6 = true;
            this.method_22((string) entry.Key);
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
            if (this.dataSet_0 != null)
            {
                this.dataSet_0.Clear();
                this.dataSet_0 = null;
            }
            this.method_13();
            this.Document.bool_4 = false;
            this.bool_6 = false;
        }

        public void ExecuteWidthNestedRegion(DataSet dataSet, List<DictionaryEntry> commands)
        {
            int num = 10;
            if (dataSet == null)
            {
                throw new ArgumentException(BookmarkStart.b("启匱䀳圵欷弹䠻", num));
            }
            if ((commands == null) || ((commands != null) && (commands.Count == 0)))
            {
                throw new ArgumentException(BookmarkStart.b("匯崱夳嬵夷吹堻䴽怿⹁ⵃ㕅㱇橉╋㵍灏㝑㥓♕ⱗ⍙", num));
            }
            this.method_67();
            this.dataSet_1 = dataSet.Copy();
            this.list_0 = commands;
            DictionaryEntry entry = commands[0];
            this.Document.bool_4 = true;
            this.bool_6 = true;
            this.method_22((string) entry.Key);
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
            if (this.dataSet_1 != null)
            {
                this.dataSet_1.Clear();
                this.dataSet_1 = null;
            }
            this.method_13();
            this.Document.bool_4 = false;
            this.bool_6 = false;
        }

        public void ExecuteWidthNestedRegion(DbConnection conn, List<DictionaryEntry> commands, bool isSqlConnection)
        {
            this.bool_7 = isSqlConnection;
            this.ExecuteWidthNestedRegion(conn, commands);
        }

        public void ExecuteWidthRegion(DataTable table)
        {
            int num = 0;
            if (table == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("別䤧䠩䀫䬭", num));
            }
            this.method_14(new Class194(table));
        }

        public void ExecuteWidthRegion(DataView dataView)
        {
            int num = 14;
            if (dataView == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("倳圵䰷嬹樻圽┿㕁", num));
            }
            this.method_14(new Class948(dataView));
        }

        public void ExecuteWidthRegion(IDataReader dataReader)
        {
            int num = 0x13;
            if (dataReader == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("崸娺䤼帾ፀ♂⑄⍆ⱈ㥊", num));
            }
            this.method_14(new Class949(dataReader));
        }

        public string[] GetMergeFieldNames()
        {
            List<string> list = new List<string>();
            this.method_1(list, null);
            return list.ToArray();
        }

        public string[] GetMergeFieldNames(string groupName)
        {
            List<string> list = new List<string>();
            this.method_1(list, groupName);
            return list.ToArray();
        }

        public string[] GetMergeGroupNames()
        {
            EntityEntry entry;
            List<string> list = new List<string>();
            Stack<EntityEntry> stack = new Stack<EntityEntry>();
            stack.Push(new EntityEntry(this.Document));
            goto Label_00CA;
        Label_0022:
            if ((entry.Current != null) && (entry.Current.DocumentObjectType == DocumentObjectType.MergeField))
            {
                Spire.Doc.Fields.MergeField field = entry.Current as Spire.Doc.Fields.MergeField;
                if (smethod_0(field))
                {
                    list.Add(field.FieldName);
                }
            }
            while (!entry.Fetch())
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    break;
                }
                entry = stack.Peek();
            }
        Label_0079:
            if (stack.Count <= 0)
            {
                return list.ToArray();
            }
        Label_00CA:
            entry = stack.Peek();
            if ((entry.Current == null) || !entry.Current.IsComposite)
            {
                goto Label_0022;
            }
            ICompositeObject current = entry.Current as ICompositeObject;
            if (current.ChildObjects.Count <= 0)
            {
                goto Label_0022;
            }
            stack.Push(new EntityEntry(current.ChildObjects[0]));
            goto Label_0079;
        }

        private string[] method_0()
        {
            IEnumerator enumerator;
            List<string> list = new List<string>();
            Stack<IEnumerator> stack = new Stack<IEnumerator>();
            stack.Push(this.Document.ChildObjects.GetEnumerator());
            goto Label_00C8;
        Label_0027:
            if (enumerator.Current != null)
            {
                DocumentObject obj2 = enumerator.Current as DocumentObject;
                if ((obj2 != null) && (obj2.DocumentObjectType == DocumentObjectType.MergeField))
                {
                    Spire.Doc.Fields.MergeField field = obj2 as Spire.Doc.Fields.MergeField;
                    if (smethod_0(field))
                    {
                        list.Add(field.FieldName);
                    }
                }
            }
            while (!enumerator.MoveNext())
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    break;
                }
                enumerator = stack.Peek();
            }
        Label_0086:
            if (stack.Count <= 0)
            {
                return list.ToArray();
            }
        Label_00C8:
            enumerator = stack.Peek();
            if (!enumerator.MoveNext())
            {
                goto Label_0027;
            }
            ICompositeObject current = enumerator.Current as ICompositeObject;
            if ((current == null) || (current.ChildObjects.Count <= 0))
            {
                goto Label_0027;
            }
            stack.Push(current.ChildObjects.GetEnumerator());
            goto Label_0086;
        }

        private void method_1(List<string> A_0, string A_1)
        {
            Section section = null;
            BodyRegion region = null;
            int num = 0;
            int count = this.Document.Sections.Count;
            while (num < count)
            {
                section = this.Document.Sections[num];
                int num5 = 0;
                int num6 = section.Body.Items.Count;
                while (num5 < num6)
                {
                    region = section.Body.Items[num5];
                    this.method_54(A_0, region, A_1);
                    num5++;
                }
                for (int i = 0; i < 6; i++)
                {
                    int num4 = 0;
                    int num7 = section.HeadersFooters[i].Items.Count;
                    while (num4 < num7)
                    {
                        region = section.HeadersFooters[i].Items[num4];
                        this.method_54(A_0, region, A_1);
                        num4++;
                    }
                }
                num++;
            }
        }

        private void method_10(DocumentObject A_0, int A_1, int A_2)
        {
            switch (A_0.DocumentObjectType)
            {
                case DocumentObjectType.Body:
                    for (int i = A_1; i < A_2; i++)
                    {
                        (A_0 as Body).Items.RemoveAt(A_1);
                    }
                    break;

                case DocumentObjectType.HeaderFooter:
                    break;

                case DocumentObjectType.Paragraph:
                    for (int j = A_1; j < A_2; j++)
                    {
                        (A_0 as Paragraph).Items.RemoveAt(A_1);
                    }
                    return;

                case DocumentObjectType.Table:
                    for (int k = A_1; k < A_2; k++)
                    {
                        (A_0 as Table).Rows.RemoveAt(A_1);
                    }
                    return;

                case DocumentObjectType.TableRow:
                    for (int m = A_1; m < A_2; m++)
                    {
                        (A_0 as TableRow).Cells.RemoveAt(A_1);
                    }
                    return;

                case DocumentObjectType.TableCell:
                    for (int n = A_1; n < A_2; n++)
                    {
                        (A_0 as TableCell).Items.RemoveAt(A_1);
                    }
                    return;

                default:
                    return;
            }
        }

        private void method_11(IRowsEnumerator A_0)
        {
            Class55 class2 = this.class55_0;
            TextBodyPart part = new TextBodyPart();
            TextBodySelection textSel = class2.method_0();
            part.Copy(textSel);
            A_0.Reset();
            while (A_0.NextRow())
            {
                if (((this.dbConnection_0 != null) || (this.dataSet_1 != null)) || (this.mailMergeDataSet_0 != null))
                {
                    this.method_24(class2.method_9(), A_0);
                }
                int count = textSel.TextBody.Items.Count;
                if ((this.class55_0 != null) && (this.class55_0.method_1().Count > 0))
                {
                    this.method_16(textSel.TextBody, textSel.ItemStartIndex, textSel.ItemEndIndex, textSel.ParagraphItemStartIndex, textSel.ParagraphItemEndIndex);
                }
                this.method_17(textSel.TextBody, textSel.ItemStartIndex, textSel.ItemEndIndex, textSel.ParagraphItemStartIndex, textSel.ParagraphItemEndIndex, A_0);
                this.int_0++;
                textSel.ItemEndIndex += textSel.TextBody.Items.Count - count;
                if (A_0.IsLast)
                {
                    if (this.bool_6)
                    {
                        this.NestedEnums.Remove(class2.method_9());
                        return;
                    }
                    break;
                }
                int num2 = 0;
                int paragraphItemStartIndex = textSel.ParagraphItemStartIndex;
                if (textSel.ItemStartIndex == textSel.ItemEndIndex)
                {
                    int num4 = textSel.TextBody.Items[textSel.ItemEndIndex].ChildObjects.Count;
                    part.PasteAt(textSel.TextBody, textSel.ItemEndIndex, textSel.ParagraphItemEndIndex + 1);
                    int num5 = textSel.TextBody.Items[textSel.ItemEndIndex].ChildObjects.Count;
                    num2 = textSel.ParagraphItemEndIndex + (num5 - num4);
                    paragraphItemStartIndex = textSel.ParagraphItemStartIndex + (num5 - num4);
                }
                else
                {
                    part.PasteAt(textSel.TextBody, textSel.ItemEndIndex, textSel.ParagraphItemEndIndex);
                    if ((part.BodyItems.Count > 0) && (part.BodyItems[part.BodyItems.Count - 1] is Paragraph))
                    {
                        num2 = (part.BodyItems[part.BodyItems.Count - 1] as Paragraph).Items.Count - 1;
                    }
                    if ((part.BodyItems.Count > 0) && (part.BodyItems[0] is Paragraph))
                    {
                        paragraphItemStartIndex = textSel.TextBody.Items[textSel.ItemEndIndex].ChildObjects.Count - part.BodyItems[0].ChildObjects.Count;
                    }
                }
                textSel.method_0(part.BodyItems.Count - 1, num2, paragraphItemStartIndex);
                if (textSel.ItemStartInSDT)
                {
                    textSel.ParagraphItemStartIndex = 0;
                }
            }
        }

        private void method_12(IRowsEnumerator A_0)
        {
            Class55 class2 = this.class55_0;
            Table table = class2.method_2().table_0;
            int num = class2.method_2().int_0;
            int num2 = class2.method_2().int_1;
            int count = table.Rows.Count;
            int num3 = num;
            int num4 = 0;
            if (this.bool_6)
            {
                this.method_30(num, num2, table);
            }
            int num6 = (num2 - num) + 1;
            TableRow[] rowArray = new TableRow[num6];
            if ((num6 > 0) && (num2 <= (table.Rows.Count - 1)))
            {
                int index = 0;
                for (int i = num; i <= num2; i++)
                {
                    rowArray[index] = table.Rows[i].Clone();
                    index++;
                }
            }
            A_0.Reset();
            while (A_0.NextRow())
            {
                if (((this.dbConnection_0 != null) || (this.dataSet_1 != null)) || (this.mailMergeDataSet_0 != null))
                {
                    this.method_24(class2.method_9(), A_0);
                }
                num4 = this.method_19(table, num3, num6, A_0);
                this.int_0++;
                if (A_0.IsLast)
                {
                    if (this.bool_6)
                    {
                        this.NestedEnums.Remove(class2.method_9());
                    }
                    break;
                }
                num3 += num4;
                for (int j = 0; j < num6; j++)
                {
                    table.Rows.Insert(num3 + j, rowArray[j].Clone());
                }
            }
            class2.method_2().int_0 = num3;
        }

        private void method_13()
        {
            if ((this.HideEmptyParagraphs && (this.list_2 != null)) && (this.list_2.Count > 0))
            {
                int num = 0;
                int count = this.list_2.Count;
                while (num < count)
                {
                    object obj2 = this.list_2[num];
                    if (obj2 is Paragraph)
                    {
                        this.method_61(obj2 as Paragraph);
                    }
                    else if (obj2 is TableRow)
                    {
                        this.method_63(obj2 as TableRow);
                    }
                    else if (obj2 is BodyRegionCollection)
                    {
                        this.method_64(obj2 as BodyRegionCollection);
                    }
                    num++;
                }
            }
            this.list_2 = null;
        }

        private void method_14(IRowsEnumerator A_0)
        {
            this.Document.bool_4 = true;
            this.method_67();
            Section section = null;
            int num = 0;
            int count = this.Document.Sections.Count;
            while (num < count)
            {
                section = this.Document.Sections[num];
                this.method_15(section, A_0);
                num++;
            }
            this.method_45();
            this.method_13();
            this.Document.bool_4 = false;
        }

        private void method_15(Section A_0, IRowsEnumerator A_1)
        {
            this.class55_0.method_15(A_0.Body, A_1);
            for (int i = 0; i < 6; i++)
            {
                Body body = A_0.HeadersFooters[i];
                if (body.Items.Count > 0)
                {
                    this.class55_0.method_15(body, A_1);
                }
            }
        }

        private void method_16(Body A_0, int A_1, int A_2, int A_3, int A_4)
        {
            if (this.dictionary_3 == null)
            {
                this.dictionary_3 = new Dictionary<string, Class882>();
            }
            int num = A_1;
            int num2 = A_2;
            while (num <= num2)
            {
                BodyRegion region = A_0.Items[num];
                switch (region.DocumentObjectType)
                {
                    case DocumentObjectType.Paragraph:
                    {
                        Paragraph paragraph = region as Paragraph;
                        if (paragraph.Items.Count != 0)
                        {
                            int num7 = (num == 0) ? A_3 : 0;
                            int num6 = ((num != num2) || (A_4 <= -1)) ? (paragraph.Items.Count - 1) : A_4;
                            for (int i = num7; i <= num6; i++)
                            {
                                if ((paragraph.Items.Count > i) && (paragraph.Items[i].DocumentObjectType == DocumentObjectType.TextBox))
                                {
                                    TextBox box = paragraph.Items[i] as TextBox;
                                    this.method_16(box.Body, 0, -1, 0, -1);
                                }
                                else
                                {
                                    DocumentObject obj2 = paragraph.Items[i];
                                    if (((obj2 is BookmarkStart) || (obj2 is BookmarkEnd)) || ((obj2 is Field) && ((obj2 as Field).Type == FieldType.FieldRef)))
                                    {
                                        string key = string.Empty;
                                        if (obj2 is BookmarkStart)
                                        {
                                            key = (obj2 as BookmarkStart).Name;
                                        }
                                        else if (obj2 is BookmarkEnd)
                                        {
                                            key = (obj2 as BookmarkEnd).Name;
                                        }
                                        else
                                        {
                                            key = (obj2 as Field).Value;
                                        }
                                        if (!this.dictionary_3.ContainsKey(key))
                                        {
                                            Class882 class3 = new Class882();
                                            if (obj2 is BookmarkStart)
                                            {
                                                class3.method_3(obj2 as BookmarkStart);
                                            }
                                            else if (obj2 is BookmarkEnd)
                                            {
                                                class3.method_1(obj2 as BookmarkEnd);
                                            }
                                            else
                                            {
                                                class3.method_5(obj2 as Field);
                                            }
                                            this.dictionary_3.Add(key, class3);
                                        }
                                        else
                                        {
                                            Class882 class2 = this.dictionary_3[key];
                                            if (obj2 is BookmarkStart)
                                            {
                                                class2.method_3(obj2 as BookmarkStart);
                                            }
                                            else if (obj2 is BookmarkEnd)
                                            {
                                                class2.method_1(obj2 as BookmarkEnd);
                                            }
                                            else
                                            {
                                                class2.method_5(obj2 as Field);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                    case DocumentObjectType.Table:
                    {
                        Table table = region as Table;
                        int num4 = 0;
                        int count = table.Rows.Count;
                        while (num4 < count)
                        {
                            TableRow row = table.Rows[num4];
                            int num8 = 0;
                            int num9 = row.Cells.Count;
                            while (num8 < num9)
                            {
                                TableCell cell = row.Cells[num8];
                                this.method_16(cell, 0, -1, 0, -1);
                                num8++;
                            }
                            num4++;
                        }
                        break;
                    }
                }
                num++;
            }
        }

        private void method_17(Body A_0, int A_1, int A_2, int A_3, int A_4, IRowsEnumerator A_5)
        {
            if (A_2 < 0)
            {
                A_2 = A_0.Items.Count - 1;
            }
            int num12 = A_1;
            int num13 = A_2;
            while (num12 <= num13)
            {
                int num7;
                int num8;
                Paragraph paragraph;
                int num9;
                int num10;
                int num11;
                int num14;
                BodyRegion region = A_0.Items[num12];
                DocumentObjectType documentObjectType = region.DocumentObjectType;
                switch (documentObjectType)
                {
                    case DocumentObjectType.Paragraph:
                        paragraph = region as Paragraph;
                        num7 = ((num12 != A_1) || (A_3 <= -1)) ? 0 : A_3;
                        num8 = ((num12 != num13) || (A_4 <= -1)) ? (paragraph.Items.Count - 1) : A_4;
                        num14 = num7;
                        goto Label_01FE;

                    case DocumentObjectType.StructureDocumentTag:
                    {
                        StructureDocumentTag tag = region as StructureDocumentTag;
                        this.method_17(tag.SDTContent, 0, -1, 0, -1, A_5);
                        goto Label_0241;
                    }
                    default:
                        if (documentObjectType == DocumentObjectType.Table)
                        {
                            Table table = region as Table;
                            int num5 = -1;
                            int num6 = -1;
                            if (this.method_21(table, ref num5, ref num6) == -1)
                            {
                                int num15 = 0;
                                int count = table.Rows.Count;
                                while (num15 < count)
                                {
                                    int num20 = this.method_19(table, num15, 1, A_5);
                                    if (num20 > 1)
                                    {
                                        count = table.Rows.Count;
                                        num15 += num20 - 1;
                                    }
                                    num15++;
                                }
                            }
                            else
                            {
                                int num = 0;
                                int num4 = num5;
                                while (num < num4)
                                {
                                    int num2 = this.method_19(table, num, 1, A_5);
                                    if (num2 > 1)
                                    {
                                        int num3 = num2 - 1;
                                        num4 += num3;
                                        num5 += num3;
                                        num6 += num3;
                                        num += num3;
                                    }
                                    num++;
                                }
                                this.method_20(table, num5, num6 + 1, A_5);
                                int num16 = num6;
                                int num17 = table.Rows.Count;
                                while (num16 < num17)
                                {
                                    int num18 = this.method_19(table, num16, 1, A_5);
                                    if (num18 > 1)
                                    {
                                        num17 = table.Rows.Count;
                                        num16 += num18 - 1;
                                    }
                                    num16++;
                                }
                            }
                        }
                        goto Label_0241;
                }
            Label_0192:
                num11 = this.method_18(paragraph, A_0, num7, num8, A_5, out num9, out num10);
                num12 += num10;
                num13 += num9;
                if (num9 > 0)
                {
                    A_2 = num13;
                }
                if (num8 == (paragraph.Items.Count - 1))
                {
                    goto Label_020E;
                }
                num14 += num11;
                if (num11 <= 0)
                {
                    num7++;
                    num8++;
                }
                else
                {
                    num7 += num11;
                    num8 += num11;
                }
                num14++;
            Label_01FE:
                if (num14 < paragraph.Items.Count)
                {
                    goto Label_0192;
                }
            Label_020E:
                if (this.bool_4)
                {
                    this.EmptyParaList.Add(paragraph);
                }
            Label_0241:
                num12++;
            }
        }

        private int method_18(Paragraph A_0, Body A_1, int A_2, int A_3, IRowsEnumerator A_4, out int A_5, out int A_6)
        {
            int num = 9;
            int count = A_0.ChildObjects.Count;
            A_5 = 0;
            A_6 = 0;
            for (int i = A_2; i <= A_3; i++)
            {
                if ((A_0.Items.Count > i) && (A_0.Items[i].DocumentObjectType == DocumentObjectType.TextBox))
                {
                    TextBox box = A_0.Items[i] as TextBox;
                    this.method_17(box.Body, 0, -1, 0, -1, A_4);
                }
                else
                {
                    if (A_0.Items[i] is BookmarkStart)
                    {
                        BookmarkStart start = A_0.Items[i] as BookmarkStart;
                        string name = start.Name;
                        if ((this.dictionary_3 != null) && this.dictionary_3.ContainsKey(name))
                        {
                            Class882 class2 = this.dictionary_3[name];
                            string str3 = name + BookmarkStart.b("瀮", num) + Guid.NewGuid().ToString().Substring(0, 0x18).Replace(BookmarkStart.b("Ȯ", num), BookmarkStart.b("瀮", num));
                            if (class2.method_2() != null)
                            {
                                class2.method_2().method_30(str3);
                            }
                            if (class2.method_0() != null)
                            {
                                class2.method_0().method_30(str3);
                            }
                            if ((class2.method_4() != null) && (class2.method_4().Type == FieldType.FieldRef))
                            {
                                string oldValue = class2.method_4().Value;
                                class2.method_4().Code = class2.method_4().Code.Replace(oldValue, str3);
                            }
                        }
                    }
                    Field field2 = (A_0.Items.Count > i) ? (A_0.Items[i] as Field) : null;
                    if (field2 != null)
                    {
                        if (field2 is Spire.Doc.Fields.MergeField)
                        {
                            Spire.Doc.Fields.MergeField field = field2 as Spire.Doc.Fields.MergeField;
                            string fieldName = field.FieldName;
                            if (((field.Domain == null) || (field.Domain == A_4.TableName)) || this.bool_6)
                            {
                                if (smethod_0(field))
                                {
                                    GroupEventType eventType = smethod_2(field) ? GroupEventType.TableStart : GroupEventType.GroupStart;
                                    this.SendMergeGroup(eventType, A_4, field);
                                    if (this.ClearGroupTag && !this.GroupStartMergeFieldList.ContainsKey(field.Domain))
                                    {
                                        this.GroupStartMergeFieldList.Add(field.Domain, field);
                                    }
                                }
                                if (smethod_1(field))
                                {
                                    GroupEventType type2 = smethod_3(field) ? GroupEventType.TableEnd : GroupEventType.GroupEnd;
                                    this.SendMergeGroup(type2, A_4, field);
                                    if (this.ClearGroupTag && this.GroupStartMergeFieldList.ContainsKey(field.Domain))
                                    {
                                        this.method_60(this.GroupStartMergeFieldList[field.Domain], true);
                                        this.method_60(field, true);
                                        this.GroupStartMergeFieldList.Remove(field.Domain);
                                    }
                                }
                                if (!smethod_0(field) && !smethod_1(field))
                                {
                                    if (field.Prefix.StartsWith(BookmarkStart.b("昮尰刲刴制", num)))
                                    {
                                        this.method_48(field, A_0, A_4);
                                    }
                                    else
                                    {
                                        this.method_46(field, A_4);
                                    }
                                }
                                else if (this.bool_6)
                                {
                                    if (smethod_0(field) && !this.NestedEnums.ContainsKey(field.FieldName))
                                    {
                                        fieldName = field.FieldName;
                                        if (fieldName != string.Empty)
                                        {
                                            if (smethod_2(field))
                                            {
                                                if (!this.ClearFieldsState.ContainsKey(fieldName))
                                                {
                                                    this.ClearFieldsState.Add(fieldName, this.ClearFields);
                                                }
                                                else
                                                {
                                                    this.ClearFieldsState[fieldName] = this.ClearFields;
                                                }
                                            }
                                            IRowsEnumerator enumerator = this.method_23(fieldName);
                                            if (enumerator != null)
                                            {
                                                int num5 = A_1.Items.Count;
                                                this.GroupSelectors.Push(this.class55_0);
                                                this.class55_0 = new Class55(new Class55.Delegate0(this.method_2));
                                                this.class55_0.method_15(A_1, enumerator);
                                                int num6 = this.class55_0.method_10();
                                                if (num6 != -1)
                                                {
                                                    if (num6 > 0)
                                                    {
                                                        A_5 = A_1.Items.Count - num5;
                                                        A_6 = (A_5 + num6) - 1;
                                                    }
                                                    else
                                                    {
                                                        this.method_60(field, false);
                                                    }
                                                    if (this.dataSet_0 != null)
                                                    {
                                                        this.CurrentDataSet.Tables.Remove(fieldName);
                                                    }
                                                    else if (this.mailMergeDataSet_1 != null)
                                                    {
                                                        this.CurrentDataSetDocIO.method_1(fieldName);
                                                    }
                                                    this.class55_0 = this.GroupSelectors.Pop();
                                                    break;
                                                }
                                                this.class55_0 = this.GroupSelectors.Pop();
                                            }
                                        }
                                    }
                                }
                                else if ((smethod_0(field) || smethod_1(field)) && this.bool_0)
                                {
                                    this.method_60(field, true);
                                }
                            }
                        }
                        else if (field2 is IfField)
                        {
                            this.method_47(field2 as IfField, A_4);
                        }
                        else if (field2.Type == FieldType.FieldNext)
                        {
                            if ((A_4 != null) && !A_4.IsEnd)
                            {
                                A_4.NextRow();
                            }
                            this.method_60(field2, true);
                        }
                        else if (field2.Type == FieldType.FieldNextIf)
                        {
                            if ((field2.method_82() && (A_4 != null)) && !A_4.IsEnd)
                            {
                                A_4.NextRow();
                            }
                            A_0.Items.Remove(field2);
                            A_3 = A_0.Items.Count - 1;
                            i--;
                        }
                        else if ((field2.Type == FieldType.FieldMergeRec) || (field2.Type == FieldType.FieldMergeSeq))
                        {
                            int num4 = 1;
                            if (A_4 != null)
                            {
                                num4 += A_4.CurrentRowIndex;
                            }
                            this.method_44(field2, num4.ToString());
                        }
                    }
                }
            }
            return (A_0.ChildObjects.Count - count);
        }

        private int method_19(Table A_0, int A_1, int A_2, IRowsEnumerator A_3)
        {
            int count = A_0.Rows.Count;
            int num2 = (A_1 + A_2) - 1;
            TableRow row = null;
            TableCell cell = null;
            for (int i = A_1; i <= num2; i++)
            {
                row = A_0.Rows[i];
                int num6 = 0;
                int num7 = row.Cells.Count;
                while (num6 < num7)
                {
                    cell = row.Cells[num6];
                    this.method_17(cell, 0, -1, 0, -1, A_3);
                    num6++;
                }
            }
            int num5 = 0;
            if (this.bool_6)
            {
                string key = this.method_32(A_1, num2, A_0);
                int num4 = A_0.Rows.Count;
                if ((key != null) && this.ClearFieldsState.ContainsKey(key))
                {
                    this.ClearFields = this.ClearFieldsState[key];
                    this.ClearFieldsState.Remove(key);
                }
                while (key != null)
                {
                    num5 = A_0.Rows.Count - num4;
                    num2 += num5;
                    A_1 += num5;
                    num4 = A_0.Rows.Count;
                    IRowsEnumerator enumerator = this.method_23(key);
                    if (enumerator != null)
                    {
                        this.GroupSelectors.Push(this.class55_0);
                        this.class55_0 = new Class55(new Class55.Delegate0(this.method_2));
                        this.class55_0.method_16(A_0, A_1, num2, enumerator);
                        if (this.dataSet_0 != null)
                        {
                            this.CurrentDataSet.Tables.Remove(key);
                        }
                        else if (this.mailMergeDataSet_1 != null)
                        {
                            this.CurrentDataSetDocIO.method_1(key);
                        }
                        this.class55_0 = this.GroupSelectors.Pop();
                    }
                    string str2 = key;
                    key = this.method_32(A_1, num2, A_0);
                    if (str2 == key)
                    {
                        break;
                    }
                }
            }
            num5 = A_0.Rows.Count - count;
            return (A_2 + num5);
        }

        private void method_2(IRowsEnumerator A_0)
        {
            bool flag = false;
            Class55 class2 = this.class55_0;
            if (((this.bool_0 && (class2.method_0() != null)) && ((class2.method_0().TextBody.Owner != null) && (class2.method_0().TextBody != null))) && (A_0.RowsCount == 0))
            {
                int num2 = class2.method_3().Owner.method_5();
                int num3 = class2.method_4().Owner.method_5();
                Body owner = class2.method_3().Owner.Owner as Body;
                for (int i = num2; i <= num3; i++)
                {
                    if (owner.Items[i] is Paragraph)
                    {
                        this.method_59(owner.Items[i] as Paragraph);
                    }
                    else if (owner.Items[i] is Table)
                    {
                        Table table = owner.Items[i] as Table;
                        int num4 = 0;
                        int count = table.Rows.Count;
                        while (num4 < count)
                        {
                            this.method_57(table.Rows[num4]);
                            num4++;
                        }
                    }
                }
                flag = true;
                if ((A_0.RowsCount == 0) && this.HideEmptyGroup)
                {
                    this.method_4(class2);
                }
            }
            else
            {
                if ((A_0.RowsCount == 0) && this.HideEmptyGroup)
                {
                    this.method_4(class2);
                }
                this.method_60(class2.method_3(), true);
                this.method_60(class2.method_4(), true);
            }
            if (this.bool_6)
            {
                this.class55_0.method_3().FieldName = string.Empty;
                this.class55_0.method_4().FieldName = string.Empty;
            }
            if (flag || this.method_55(A_0))
            {
                if (class2.method_0() != null)
                {
                    this.method_11(A_0);
                }
                else if (class2.method_2() != null)
                {
                    this.method_12(A_0);
                }
            }
        }

        private void method_20(Table A_0, int A_1, int A_2, IRowsEnumerator A_3)
        {
            int num = (A_1 + A_2) - 1;
            if (this.bool_6)
            {
                string key = this.method_32(A_1, num, A_0);
                int count = A_0.Rows.Count;
                if ((key != null) && this.ClearFieldsState.ContainsKey(key))
                {
                    this.ClearFields = this.ClearFieldsState[key];
                    this.ClearFieldsState.Remove(key);
                }
                int num3 = 0;
                while (key != null)
                {
                    num3 = (A_0.Rows.Count - count) - A_1;
                    num += num3;
                    A_1 += num3;
                    count = A_0.Rows.Count;
                    IRowsEnumerator enumerator = this.method_23(key);
                    if (enumerator != null)
                    {
                        this.GroupSelectors.Push(this.class55_0);
                        this.class55_0 = new Class55(new Class55.Delegate0(this.method_2));
                        this.class55_0.method_16(A_0, A_1, num, enumerator);
                        if (this.dataSet_0 != null)
                        {
                            this.CurrentDataSet.Tables.Remove(key);
                        }
                        else if (this.mailMergeDataSet_1 != null)
                        {
                            this.CurrentDataSetDocIO.method_1(key);
                        }
                        this.class55_0 = this.GroupSelectors.Pop();
                    }
                    string str2 = key;
                    key = this.method_32(A_1, num, A_0);
                    if (str2 == key)
                    {
                        return;
                    }
                }
            }
        }

        private int method_21(Table A_0, ref int A_1, ref int A_2)
        {
            if (A_0 != null)
            {
                new Stack<string>();
                string fieldName = string.Empty;
                int num = -1;
                A_1 = -1;
                A_2 = -1;
                int num2 = 0;
                int count = A_0.Rows.Count;
                while (num2 < count)
                {
                    TableRow row = A_0.Rows[num2];
                    foreach (TableCell cell in row.Cells)
                    {
                        foreach (Paragraph paragraph in cell.Paragraphs)
                        {
                            using (IEnumerator enumerator3 = paragraph.Items.GetEnumerator())
                            {
                                while (enumerator3.MoveNext())
                                {
                                    ParagraphBase current = (ParagraphBase) enumerator3.Current;
                                    if (current is Spire.Doc.Fields.MergeField)
                                    {
                                        Spire.Doc.Fields.MergeField field = current as Spire.Doc.Fields.MergeField;
                                        if (smethod_0(field) && (field.FieldName != string.Empty))
                                        {
                                            if (string.IsNullOrEmpty(fieldName))
                                            {
                                                fieldName = (current as Spire.Doc.Fields.MergeField).FieldName;
                                                num = num2;
                                                A_1 = num2;
                                            }
                                        }
                                        else if (smethod_1(field) && !string.IsNullOrEmpty(fieldName))
                                        {
                                            string str2 = (current as Spire.Doc.Fields.MergeField).FieldName;
                                            if (fieldName == str2)
                                            {
                                                goto Label_0121;
                                            }
                                        }
                                    }
                                }
                                continue;
                            Label_0121:
                                A_2 = num2;
                                if (num == num2)
                                {
                                    return -1;
                                }
                                return num2;
                            }
                        }
                    }
                    num2++;
                }
                if (A_2 != -1)
                {
                    return num;
                }
            }
            return -1;
        }

        private void method_22(string A_0)
        {
            IRowsEnumerator enumerator = this.method_23(A_0);
            if (enumerator != null)
            {
                Section section = null;
                int num = 0;
                int count = this.Document.Sections.Count;
                while (num < count)
                {
                    section = this.Document.Sections[num];
                    this.method_15(section, enumerator);
                    num++;
                }
                this.method_45();
                if (this.dataSet_0 != null)
                {
                    this.CurrentDataSet.Tables.Remove(A_0);
                }
                else if (this.mailMergeDataSet_1 != null)
                {
                    this.CurrentDataSetDocIO.method_1(A_0);
                }
            }
        }

        private IRowsEnumerator method_23(string A_0)
        {
            IRowsEnumerator enumerator = null;
            object obj2 = this.method_25(A_0);
            if (obj2 is DataTable)
            {
                DataTable table = obj2 as DataTable;
                if (!this.CurrentDataSet.Tables.Contains(table.TableName))
                {
                    this.CurrentDataSet.Tables.Add(table);
                }
                enumerator = new Class194(table);
                enumerator.Reset();
                return enumerator;
            }
            if (obj2 is MailMergeDataTable)
            {
                MailMergeDataTable dataTable = obj2 as MailMergeDataTable;
                this.CurrentDataSetDocIO.Add(dataTable);
                enumerator = new Class194(dataTable);
                enumerator.Reset();
            }
            return enumerator;
        }

        private void method_24(string A_0, IRowsEnumerator A_1)
        {
            if (!this.NestedEnums.ContainsKey(A_0))
            {
                this.NestedEnums.Add(A_0, A_1);
            }
            else
            {
                this.NestedEnums[A_0] = A_1;
            }
        }

        private object method_25(string A_0)
        {
            if (this.dbConnection_0 != null)
            {
                return this.method_33(A_0);
            }
            if (this.mailMergeDataSet_0 != null)
            {
                return this.method_26(A_0, this.mailMergeDataSet_0);
            }
            return this.method_34(A_0);
        }

        private MailMergeDataTable method_26(string A_0, MailMergeDataSet A_1)
        {
            MailMergeDataTable table = A_1.method_0(A_0);
            if (table == null)
            {
                return null;
            }
            string str = this.method_27(A_0);
            if (str == string.Empty)
            {
                return table;
            }
            return table.method_0(str);
        }

        private string method_27(string A_0)
        {
            int num = 0x12;
            DictionaryEntry entry = new DictionaryEntry(string.Empty, string.Empty);
            bool flag = false;
            if (this.list_0 == null)
            {
                if (this.list_1 != null)
                {
                    int num4 = 0;
                    int count = this.list_1.Count;
                    while (num4 < count)
                    {
                        entry = this.list_1[num4];
                        if (A_0 == ((string) entry.Key))
                        {
                            flag = true;
                            break;
                        }
                        num4++;
                    }
                }
            }
            else
            {
                DictionaryEntry entry2 = new DictionaryEntry(string.Empty, string.Empty);
                bool flag2 = false;
                int num2 = 0;
                int num3 = this.list_0.Count;
                while (num2 < num3)
                {
                    entry = this.list_0[num2];
                    if (A_0 == ((string) entry.Key))
                    {
                        if (!flag2)
                        {
                            entry2 = this.list_0[num2];
                            flag2 = true;
                        }
                        string str = this.method_28((string) entry.Value);
                        if ((A_0 == ((string) entry.Key)) && ((this.NestedEnums.Count == 0) || !string.IsNullOrEmpty(str)))
                        {
                            flag = true;
                            break;
                        }
                    }
                    num2++;
                }
                if (!flag && flag2)
                {
                    entry = entry2;
                    flag = true;
                }
            }
            if (!flag)
            {
                return null;
            }
            string str2 = (string) entry.Value;
            if (str2.IndexOf(BookmarkStart.b("ᴷ", num)) == -1)
            {
                return str2;
            }
            return this.method_29(str2);
        }

        private string method_28(string A_0)
        {
            int num = 13;
            MatchCollection matchs = this.VariableCommandRegex.Matches(A_0);
            if (matchs.Count == 0)
            {
                return string.Empty;
            }
            int num2 = 0;
            int count = matchs.Count;
            if (0 >= count)
            {
                return string.Empty;
            }
            string[] strArray = matchs[num2].Value.Replace(BookmarkStart.b("ᘲ", num), string.Empty).Split(new char[] { '.' });
            if (strArray.Length != 2)
            {
                throw new ArgumentException(BookmarkStart.b("怲䄴䔶倸唺娼Ἶ㝀≂⥄㉆ⱈ歊⽌⩎═⑒ご㉖㝘筚穜穞䙠䍢ᙤṦѨ४ɬͮɰ卲嵴ŶᡸॺᑼṾꞆﶒ뺖릘뾞쾠첢톤螦\udfa8\ucaaa솬욮햰鶲", num));
            }
            IRowsEnumerator enumerator = null;
            if (this.NestedEnums.ContainsKey(strArray[0]))
            {
                enumerator = this.NestedEnums[strArray[0]];
            }
            if (enumerator == null)
            {
                return string.Empty;
            }
            return strArray[0];
        }

        private string method_29(string A_0)
        {
            int num = 14;
            MatchCollection matchs = this.VariableCommandRegex.Matches(A_0);
            if (matchs.Count == 0)
            {
                return null;
            }
            char[] separator = new char[] { '.' };
            string newValue = null;
            string str2 = null;
            string[] strArray = null;
            int num2 = 0;
            int count = matchs.Count;
            while (num2 < count)
            {
                str2 = matchs[num2].Value.Replace(BookmarkStart.b("ᄳ", num), string.Empty);
                strArray = str2.Split(separator);
                if (strArray.Length != 2)
                {
                    throw new ArgumentException(BookmarkStart.b("朳䈵䨷匹刻夽怿㑁╃⩅㵇⽉汋ⱍ㕏♑⍓㍕㵗㑙籛祝䕟䕡䑣ᕥᅧݩ๫ŭᱯű味幵๷᭹๻᝽ꢇﶏ望놗몙肟첡쮣튥袧\udca9\ucdab슭\ud9af\ud6b1骳", num));
                }
                IRowsEnumerator enumerator = null;
                if (this.NestedEnums.ContainsKey(strArray[0]))
                {
                    enumerator = this.NestedEnums[strArray[0]];
                }
                if (enumerator == null)
                {
                    return string.Empty;
                }
                newValue = enumerator.GetCellValue(strArray[1]).ToString();
                if ((this.dataSet_1 != null) && this.dataSet_1.Tables.Contains(strArray[0]))
                {
                    DataTable table = this.dataSet_1.Tables[strArray[0]];
                    if (table.Columns.Contains(strArray[1]) && (table.Columns[strArray[1]].DataType.Name == BookmarkStart.b("朳䈵䨷匹刻夽", num)))
                    {
                        newValue = BookmarkStart.b("ጳ", num) + newValue + BookmarkStart.b("ጳ", num);
                    }
                }
                A_0 = A_0.Replace(BookmarkStart.b("ᄳ", num) + str2 + BookmarkStart.b("ᄳ", num), newValue);
                num2++;
            }
            return A_0;
        }

        private void method_3(IRowsEnumerator A_0)
        {
            if (((this.dbConnection_0 != null) || (this.dataSet_1 != null)) || (this.mailMergeDataSet_0 != null))
            {
                this.method_24(A_0.TableName, A_0);
            }
        }

        private void method_30(int A_0, int A_1, Table A_2)
        {
            int num = 13;
            if (A_1 > (A_2.Rows.Count - 1))
            {
                return;
            }
            Dictionary<string, Spire.Doc.Fields.MergeField> dictionary = new Dictionary<string, Spire.Doc.Fields.MergeField>();
            Dictionary<string, Spire.Doc.Fields.MergeField> dictionary2 = new Dictionary<string, Spire.Doc.Fields.MergeField>();
            TableRow row = null;
            Spire.Doc.Fields.MergeField field = null;
            for (int i = A_0; i <= A_1; i++)
            {
                row = A_2.Rows[i];
                foreach (TableCell cell in row.Cells)
                {
                    foreach (Paragraph paragraph in cell.Paragraphs)
                    {
                        foreach (ParagraphBase base2 in paragraph.Items)
                        {
                            if (base2 is Spire.Doc.Fields.MergeField)
                            {
                                field = base2 as Spire.Doc.Fields.MergeField;
                                if (smethod_0(field) && !field.ConvertedToText)
                                {
                                    dictionary.Add(field.FieldName, field);
                                }
                                else if (smethod_1(field) && !field.ConvertedToText)
                                {
                                    dictionary2.Add(field.FieldName, field);
                                }
                            }
                        }
                    }
                }
            }
            if (dictionary.Count == 0)
            {
                if (dictionary2.Count <= 0)
                {
                    goto Label_0235;
                }
                using (Dictionary<string, Spire.Doc.Fields.MergeField>.KeyCollection.Enumerator enumerator5 = dictionary2.Keys.GetEnumerator())
                {
                    if (enumerator5.MoveNext())
                    {
                        string current = enumerator5.Current;
                        throw new ApplicationException(BookmarkStart.b("朲吴唶唸帺砼儾╀捂⍄⹆ⱈ❊⥌潎獐", num) + current + BookmarkStart.b("ᄲᔴ匶嘸帺丼儾晀㝂敄⽆⡈㵊⡌潎Ր㉒㝔㭖㱘࡚⥜㹞፠ᝢ䕤Ŧh๪Ŭ୮兰ᙲѴɶၸൺᱼ፾ꦆ", num));
                    }
                    goto Label_0235;
                }
            }
            if ((dictionary2.Count == 0) && (dictionary.Count > 0))
            {
                using (Dictionary<string, Spire.Doc.Fields.MergeField>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        string str2 = enumerator.Current;
                        throw new ApplicationException(BookmarkStart.b("朲吴唶唸帺渼䬾⁀ㅂㅄ杆⽈≊⡌⍎㕐獒睔", num) + str2 + BookmarkStart.b("ᄲᔴ匶嘸帺丼儾晀㝂敄⽆⡈㵊⡌潎Ր㉒㝔㭖㱘Ṛ㍜㭞䅠բ౤ɦըཪ䵬੮pٲᱴŶᡸ᝺᡼ᅾ궂", num));
                    }
                }
            }
        Label_0235:
            foreach (string str4 in dictionary.Keys)
            {
                if (!dictionary2.ContainsKey(str4))
                {
                    throw new ApplicationException(BookmarkStart.b("朲吴唶唸帺渼䬾⁀ㅂㅄ杆⽈≊⡌⍎㕐獒睔", num) + str4 + BookmarkStart.b("ᄲᔴ匶嘸帺丼儾晀㝂敄⽆⡈㵊⡌潎Ր㉒㝔㭖㱘Ṛ㍜㭞䅠բ౤ɦըཪ䵬੮pٲᱴŶᡸ᝺᡼ᅾ궂", num));
                }
                dictionary2.Remove(str4);
            }
            if (dictionary2.Count > 0)
            {
                using (Dictionary<string, Spire.Doc.Fields.MergeField>.KeyCollection.Enumerator enumerator2 = dictionary2.Keys.GetEnumerator())
                {
                    if (enumerator2.MoveNext())
                    {
                        string str = enumerator2.Current;
                        throw new ApplicationException(BookmarkStart.b("朲吴唶唸帺砼儾╀捂⍄⹆ⱈ❊⥌潎獐", num) + str + BookmarkStart.b("ᄲᔴ匶嘸帺丼儾晀㝂敄⽆⡈㵊⡌潎Ր㉒㝔㭖㱘࡚⥜㹞፠ᝢ䕤Ŧh๪Ŭ୮兰ᙲѴɶၸൺᱼ፾ꦆ", num));
                    }
                }
            }
            dictionary.Clear();
            dictionary2.Clear();
        }

        private void method_31(Spire.Doc.Fields.MergeField A_0)
        {
            this.method_60(A_0, true);
            A_0.FieldName = string.Empty;
        }

        private string method_32(int A_0, int A_1, Table A_2)
        {
            TableRow row = null;
            for (int i = A_0; i <= A_1; i++)
            {
                if (i < A_2.Rows.Count)
                {
                    row = A_2.Rows[i];
                    foreach (TableCell cell in row.Cells)
                    {
                        foreach (Paragraph paragraph in cell.Paragraphs)
                        {
                            using (IEnumerator enumerator3 = paragraph.Items.GetEnumerator())
                            {
                                ParagraphBase current;
                                string str;
                                while (enumerator3.MoveNext())
                                {
                                    current = (ParagraphBase) enumerator3.Current;
                                    if (current is Spire.Doc.Fields.MergeField)
                                    {
                                        Spire.Doc.Fields.MergeField field = current as Spire.Doc.Fields.MergeField;
                                        if (smethod_0(field) && (field.FieldName != string.Empty))
                                        {
                                            goto Label_00BE;
                                        }
                                    }
                                }
                                continue;
                            Label_00BE:
                                str = (current as Spire.Doc.Fields.MergeField).FieldName;
                                return ((str == string.Empty) ? null : str);
                            }
                        }
                    }
                }
            }
            return null;
        }

        private DataTable method_33(string A_0)
        {
            DataTable table2;
            int num = 13;
            DataTable dataTable = null;
            string cmdText = this.method_27(A_0);
            if (cmdText == null)
            {
                cmdText = BookmarkStart.b("怲倴嬶尸堺䤼Ἶ歀捂⍄㕆♈♊浌", num) + A_0;
            }
            else if (cmdText == string.Empty)
            {
                return null;
            }
            dataTable = new DataTable(A_0);
            DbCommand command = null;
            DbDataAdapter adapter = null;
            if (this.bool_7)
            {
                command = new SqlCommand(cmdText, this.dbConnection_0 as SqlConnection);
                adapter = new SqlDataAdapter(command as SqlCommand);
            }
            else
            {
                command = new OleDbCommand(cmdText, this.dbConnection_0 as OleDbConnection);
                adapter = new OleDbDataAdapter(command as OleDbCommand);
            }
            try
            {
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                table2 = dataTable;
            }
            return table2;
        }

        private DataTable method_34(string A_0)
        {
            DataTable table3;
            DataTable table = this.dataSet_1.Tables[A_0];
            if (table == null)
            {
                return null;
            }
            string filterExpression = this.method_27(A_0);
            if (filterExpression == null)
            {
                return null;
            }
            DataRow[] rowArray = null;
            try
            {
                rowArray = table.Select(filterExpression);
                DataTable table2 = new DataTable(A_0);
                foreach (DataColumn column in table.Columns)
                {
                    table2.Columns.Add(column.ColumnName).DataType = column.DataType;
                }
                foreach (DataRow row in rowArray)
                {
                    DataRow row2 = table2.NewRow();
                    row2.ItemArray = row.ItemArray;
                    row2.RowError = row.RowError;
                    table2.Rows.Add(row2);
                }
                return table2;
            }
            catch
            {
                table3 = null;
            }
            return table3;
        }

        private void method_35(IRowsEnumerator A_0)
        {
            int num = 15;
            this.Document.bool_4 = true;
            this.method_67();
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䜴堶丸䠺砼儾㑀⹂", num));
            }
            int rowsCount = A_0.RowsCount;
            int num4 = 0;
            if (rowsCount > 1)
            {
                this.method_51(this.Document);
            }
            IWSectionCollection sections = this.Document.Sections;
            A_0.Reset();
            if ((A_0.RowsCount != 0) || !this.bool_0)
            {
                while (A_0.NextRow())
                {
                    int num2 = num4;
                    int count = sections.Count;
                    while (num2 < count)
                    {
                        this.method_36(sections[num2], A_0);
                        num2++;
                    }
                    num4 = sections.Count;
                    if (!A_0.IsLast)
                    {
                        this.method_52(this.Document);
                    }
                }
            }
            else
            {
                int num6 = 0;
                int num7 = sections.Count;
                while (num6 < num7)
                {
                    this.method_36(sections[num6], null);
                    num6++;
                }
            }
            this.method_13();
            this.Document.bool_4 = false;
        }

        private void method_36(ISection A_0, IRowsEnumerator A_1)
        {
            this.method_37(A_0.Body.Items, A_1);
            for (int i = 0; i < 6; i++)
            {
                BodyRegionCollection childObjects = (BodyRegionCollection) A_0.HeadersFooters[i].ChildObjects;
                if (childObjects.Count > 0)
                {
                    this.method_37(childObjects, A_1);
                }
            }
        }

        private void method_37(BodyRegionCollection A_0, IRowsEnumerator A_1)
        {
            IBodyRegion region = null;
            for (int i = 0; i < A_0.Count; i++)
            {
                region = A_0[i];
                if (region is IParagraph)
                {
                    Paragraph paragraph = region as Paragraph;
                    this.method_39(paragraph, A_1);
                }
                else if (region is ITable)
                {
                    ITable table = region as ITable;
                    if (table != null)
                    {
                        this.method_43(table, A_1);
                    }
                }
                else if (region is IStructureDocument)
                {
                    IStructureDocument document = region as IStructureDocument;
                    if (document != null)
                    {
                        this.method_38(document, A_1);
                    }
                }
            }
        }

        private void method_38(IStructureDocument A_0, IRowsEnumerator A_1)
        {
            if (A_0 is StructureDocumentTag)
            {
                StructureDocumentTag tag = A_0 as StructureDocumentTag;
                this.method_37(tag.SDTContent.Items, A_1);
            }
        }

        private void method_39(Paragraph A_0, IRowsEnumerator A_1)
        {
            int num = 0x10;
            Stack<Field> stack = new Stack<Field>();
            IfField field = null;
            for (int i = 0; i < A_0.Items.Count; i++)
            {
                Spire.Doc.Fields.MergeField field3 = A_0[i] as Spire.Doc.Fields.MergeField;
                if (field3 != null)
                {
                    if (field3.Prefix.StartsWith(BookmarkStart.b("缵唷嬹嬻嬽", num)))
                    {
                        this.method_48(field3, A_0, A_1);
                    }
                    else if (!field3.ConvertedToText)
                    {
                        this.method_46(field3, A_1);
                        if ((field != null) && this.method_40(field, field3))
                        {
                            field3.Text = BookmarkStart.b("ᐵ", num) + field3.Text + BookmarkStart.b("ᐵ", num);
                        }
                    }
                }
                else if (A_0[i] is Field)
                {
                    Field field2 = A_0[i] as Field;
                    if (field2.Type == FieldType.FieldNext)
                    {
                        if ((A_1 != null) && !A_1.IsEnd)
                        {
                            A_1.NextRow();
                        }
                        this.method_60(field2, true);
                    }
                    else if (field2.Type == FieldType.FieldNextIf)
                    {
                        if ((field2.method_82() && (A_1 != null)) && !A_1.IsEnd)
                        {
                            A_1.NextRow();
                        }
                        A_0.Items.Remove(field2);
                        i--;
                    }
                    else if (field2.Type == FieldType.FieldIf)
                    {
                        if (field != null)
                        {
                            stack.Push(field);
                        }
                        field = field2 as IfField;
                        this.method_47(field2 as IfField, A_1);
                    }
                    else if ((field2.Type == FieldType.FieldMergeRec) || (field2.Type == FieldType.FieldMergeSeq))
                    {
                        int num3 = 1;
                        if (A_1 != null)
                        {
                            num3 += A_1.CurrentRowIndex;
                        }
                        this.method_44(field2, num3.ToString());
                    }
                }
                else if ((A_0[i] is FieldMark) && ((A_0[i] as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    if ((field != null) && (field.End == A_0[i]))
                    {
                        if (stack.Count > 0)
                        {
                            field = stack.Pop() as IfField;
                        }
                        else
                        {
                            field = null;
                        }
                    }
                }
                else if (A_0[i] is TextBox)
                {
                    TextBox box = A_0[i] as TextBox;
                    this.method_37((BodyRegionCollection) box.Body.ChildObjects, A_1);
                }
                else if (A_0[i] is ShapeObject)
                {
                    ShapeObject obj2 = A_0[i] as ShapeObject;
                    if ((obj2.AutoShapeTextCollection != null) && (obj2.AutoShapeTextCollection.Count > 0))
                    {
                        foreach (TextBox box2 in obj2.AutoShapeTextCollection)
                        {
                            this.method_37((BodyRegionCollection) box2.Body.ChildObjects, A_1);
                        }
                    }
                    else if (obj2.HasInternalTextbox)
                    {
                        this.method_37((BodyRegionCollection) obj2.InternerTextbox.Body.ChildObjects, A_1);
                    }
                }
            }
            if (this.bool_4)
            {
                this.EmptyParaList.Add(A_0);
            }
            stack.Clear();
            field = null;
        }

        private void method_4(Class55 A_0)
        {
            if (A_0.method_3().OwnerParagraph.IsInCell)
            {
                if (!A_0.method_12())
                {
                    this.method_6(A_0);
                }
                else
                {
                    this.method_9(A_0);
                }
            }
            else
            {
                this.method_5(A_0);
            }
            if (A_0.method_0() != null)
            {
                A_0.method_0().ItemEndIndex = A_0.method_0().ItemStartIndex;
            }
            if (A_0.method_2() != null)
            {
                A_0.method_2().int_1 = A_0.method_2().int_0;
            }
        }

        private bool method_40(IfField A_0, Spire.Doc.Fields.MergeField A_1)
        {
            bool flag = false;
            if ((A_0 != null) && (A_1 != null))
            {
                Paragraph ownerParagraph = A_0.OwnerParagraph;
                if (ownerParagraph == null)
                {
                    return flag;
                }
                FieldMark separator = A_0.Separator;
                FieldMark end = A_0.End;
                int index = ownerParagraph.ChildObjects.IndexOf(A_0);
                int num2 = ownerParagraph.ChildObjects.IndexOf(A_1);
                int num3 = -1;
                if (A_0.End.OwnerParagraph != ownerParagraph)
                {
                    num3 = ownerParagraph.ChildObjects.Count - 1;
                }
                else
                {
                    num3 = ownerParagraph.ChildObjects.IndexOf(end);
                }
                if ((separator != null) && (A_0.Separator.OwnerParagraph == ownerParagraph))
                {
                    num3 = ownerParagraph.ChildObjects.IndexOf(separator);
                }
                if ((num2 > index) && (num2 < num3))
                {
                    flag = this.method_41(ownerParagraph, index, num3, num2);
                }
            }
            return flag;
        }

        private bool method_41(Paragraph A_0, int A_1, int A_2, int A_3)
        {
            int num = 15;
            bool flag = false;
            if (A_0 == null)
            {
                return flag;
            }
            int num2 = -1;
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Regex regex = new Regex(BookmarkStart.b("ᴴ氶ԸԺ<戾橀橂", num));
            Regex regex3 = new Regex(BookmarkStart.b("᜴ἶ᜸ᄺȼᘾ捀", num));
            Regex regex2 = new Regex(BookmarkStart.b("᜴", num));
            for (int i = A_1; i <= A_2; i++)
            {
                string input = string.Empty;
                ParagraphBase base2 = A_0.Items[i];
                if (base2 is IfField)
                {
                    input = (base2 as IfField).Code;
                }
                else if (base2 is Spire.Doc.Fields.MergeField)
                {
                    input = (base2 as Spire.Doc.Fields.MergeField).Text;
                }
                else if (base2 is TextRange)
                {
                    input = (base2 as TextRange).Text;
                }
                if ((num2 == -1) && regex.IsMatch(input))
                {
                    num2 = i;
                }
                dictionary.Add(i, input);
            }
            if (num2 != -1)
            {
                if (A_3 >= num2)
                {
                    string str2 = string.Empty;
                    string str4 = string.Empty;
                    int length = -1;
                    int num6 = -1;
                    for (int j = num2 - A_1; j < dictionary.Count; j++)
                    {
                        int num3 = j + A_1;
                        if (num3 == A_3)
                        {
                            str4 = dictionary[num3];
                            length = str2.Length;
                            num6 = length + str4.Length;
                        }
                        str2 = str2 + dictionary[num3];
                    }
                    MatchCollection matchs = regex3.Matches(str2);
                    if (matchs.Count == 0)
                    {
                        if (this.method_42(str2))
                        {
                            flag = true;
                        }
                    }
                    else if ((matchs.Count == 1) && (regex2.Matches(str2).Count > 2))
                    {
                        flag = false;
                    }
                    else
                    {
                        using (IEnumerator enumerator = matchs.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                Match current = (Match) enumerator.Current;
                                int index = current.Index;
                                int num9 = current.Index + current.Length;
                                if ((index <= length) && (num9 >= num6))
                                {
                                    goto Label_028F;
                                }
                                flag = true;
                            }
                            goto Label_02A8;
                        Label_028F:
                            flag = false;
                        }
                    }
                }
                else
                {
                    string str3 = string.Empty;
                    foreach (KeyValuePair<int, string> pair in dictionary)
                    {
                        if (pair.Key >= num2)
                        {
                            break;
                        }
                        str3 = str3 + pair.Value;
                    }
                    if ((regex3.Matches(str3).Count == 0) && (this.method_42(str3) || (!str3.EndsWith(BookmarkStart.b("ᔴ", num)) && !dictionary[num2].StartsWith(BookmarkStart.b("ᔴ", num)))))
                    {
                        flag = true;
                    }
                }
            }
        Label_02A8:
            dictionary.Clear();
            dictionary = null;
            regex = null;
            regex3 = null;
            regex2 = null;
            return flag;
        }

        private bool method_42(string A_0)
        {
            int num = 0x12;
            if (string.IsNullOrEmpty(A_0))
            {
                return true;
            }
            string[] strArray2 = A_0.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if ((strArray2.Length == 1) && (strArray2[0].ToLower() == BookmarkStart.b("儷尹", num)))
            {
                return true;
            }
            if (strArray2.Length > 1)
            {
                ArrayList list = new ArrayList();
                foreach (string str in strArray2)
                {
                    if (str.ToLower() != BookmarkStart.b("儷尹", num))
                    {
                        list.Add(str);
                    }
                }
                if (list.Count > 1)
                {
                    return true;
                }
            }
            return false;
        }

        private void method_43(ITable A_0, IRowsEnumerator A_1)
        {
            TableRow row = null;
            TableCell cell = null;
            int num = 0;
            int count = A_0.Rows.Count;
            while (num < count)
            {
                row = A_0.Rows[num];
                int num3 = 0;
                int num4 = row.Cells.Count;
                while (num3 < num4)
                {
                    cell = row.Cells[num3];
                    this.method_37((BodyRegionCollection) cell.ChildObjects, A_1);
                    num3++;
                }
                num++;
            }
        }

        private void method_44(Field A_0, string A_1)
        {
            TextRange entity = new TextRange(this.Document);
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            int index = A_0.method_5();
            ownerParagraph.Items.Remove(A_0);
            ownerParagraph.Items.Insert(index, entity);
            entity.CharacterFormat.ImportContainer(A_0.CharacterFormat);
            entity.CharacterFormat.method_21(A_0.CharacterFormat);
            entity.Text = A_1;
        }

        private void method_45()
        {
            for (int i = 0; i < this.Document.Fields.Count; i++)
            {
                Field field = this.Document.Fields[i];
                if ((field.Type == FieldType.FieldMergeRec) || (field.Type == FieldType.FieldMergeSeq))
                {
                    this.method_44(field, this.int_0.ToString());
                    i--;
                }
            }
        }

        private void method_46(IMergeField A_0, IRowsEnumerator A_1)
        {
            int num = 7;
            if (A_1 == null)
            {
                this.method_50(A_0);
            }
            else
            {
                string columnName = null;
                bool flag = false;
                object cellValue = null;
                columnName = this.method_66(A_0.FieldName);
                if (columnName != null)
                {
                    cellValue = A_1.GetCellValue(columnName);
                }
                if (cellValue == null)
                {
                    int index = 0;
                    int length = A_1.ColumnNames.Length;
                    while (index < length)
                    {
                        columnName = A_1.ColumnNames[index];
                        string str2 = A_0.FieldName.ToUpper();
                        string str3 = columnName.ToUpper();
                        if ((str2 == str3) || (str2 == (BookmarkStart.b("༬", num) + str3 + BookmarkStart.b("༬", num))))
                        {
                            cellValue = A_1.GetCellValue(columnName);
                            break;
                        }
                        index++;
                    }
                }
                if (cellValue != null)
                {
                    MergeFieldEventArgs args = this.SendMergeField(A_0, cellValue, A_1);
                    if (args.IsKeepTextFormat)
                    {
                        (A_0 as Spire.Doc.Fields.MergeField).IsToTextOfMergeFieldEvent = true;
                    }
                    A_0.Text = args.Text;
                    (A_0 as Spire.Doc.Fields.MergeField).ConvertedToText = true;
                    flag = true;
                }
                if (flag || this.bool_0)
                {
                    this.method_60(A_0, true);
                }
            }
        }

        private void method_47(IfField A_0, IRowsEnumerator A_1)
        {
            if ((A_0.MergeFields.Count != 0) && (A_1 != null))
            {
                string columnName = null;
                int index = 0;
                int length = A_1.ColumnNames.Length;
                while (index < length)
                {
                    columnName = A_1.ColumnNames[index];
                    string str2 = columnName.ToUpper();
                    Class621 class2 = null;
                    int num = 0;
                    int count = A_0.MergeFields.Count;
                    while (num < count)
                    {
                        class2 = A_0.MergeFields[num];
                        if ((class2.method_0() != null) && (class2.method_0().ToUpper() == str2))
                        {
                            class2.method_2(A_1.GetCellValue(columnName).ToString());
                        }
                        num++;
                    }
                    index++;
                }
            }
        }

        private void method_48(IMergeField A_0, IParagraph A_1, IRowsEnumerator A_2)
        {
            if ((A_2 == null) && (this.mergeImageFieldEventHandler_0 == null))
            {
                this.method_50(A_0);
            }
            else
            {
                object cellValue;
                bool flag;
                MergeImageFieldEventArgs args = null;
                if ((A_2 != null) || (this.mergeImageFieldEventHandler_0 == null))
                {
                    flag = false;
                    string fieldName = A_0.FieldName;
                    string columnName = null;
                    cellValue = null;
                    columnName = this.method_66(fieldName);
                    if (columnName != null)
                    {
                        cellValue = A_2.GetCellValue(columnName);
                    }
                    if (cellValue == null)
                    {
                        int index = 0;
                        int length = A_2.ColumnNames.Length;
                        while (index < length)
                        {
                            columnName = A_2.ColumnNames[index];
                            if (columnName.ToUpper() == fieldName.ToUpper())
                            {
                                cellValue = A_2.GetCellValue(columnName);
                                break;
                            }
                            index++;
                        }
                    }
                }
                else
                {
                    int num3 = -1;
                    string imageName = string.Empty;
                    string str4 = this.method_66(A_0.FieldName);
                    if (str4 != null)
                    {
                        for (int i = 0; i < this.string_0.Length; i++)
                        {
                            if (this.string_0[i].ToUpper() == str4.ToUpper())
                            {
                                num3 = i;
                                break;
                            }
                        }
                    }
                    if (num3 == -1)
                    {
                        for (int j = 0; j < this.string_0.Length; j++)
                        {
                            if (this.string_0[j].ToUpper() == A_0.FieldName.ToUpper())
                            {
                                num3 = j;
                                break;
                            }
                        }
                    }
                    if (num3 != -1)
                    {
                        imageName = this.string_1[num3];
                    }
                    args = this.SendMergeImageField(A_0, null, imageName);
                    this.method_49(A_0, A_1, args);
                    return;
                }
                if (cellValue != null)
                {
                    Image image = this.method_53(cellValue);
                    if (image != null)
                    {
                        cellValue = image;
                    }
                    args = this.SendMergeImageField(A_0, cellValue, A_2);
                    this.method_49(A_0, A_1, args);
                    flag = true;
                }
                if (flag || this.bool_0)
                {
                    this.method_60(A_0, true);
                }
            }
        }

        private void method_49(IMergeField A_0, IParagraph A_1, MergeImageFieldEventArgs A_2)
        {
            if (A_2.UseText)
            {
                A_0.Text = A_2.Text;
            }
            else if (!A_2.Skip)
            {
                int index = A_1.Items.IndexOf(A_0);
                A_1.Items.RemoveAt(index);
                IPicture entity = (IPicture) this.Document.CreateParagraphItem(ParagraphItemType.Picture);
                A_1.Items.Insert(index, entity);
                if (A_2.Image != null)
                {
                    entity.LoadImage(A_2.Image);
                    if (!A_2.PictureSize.IsEmpty)
                    {
                        entity.Width = A_2.PictureSize.Width;
                        entity.Height = A_2.PictureSize.Height;
                    }
                }
            }
        }

        private void method_5(Class55 A_0)
        {
            int num = A_0.method_3().method_5();
            int num2 = A_0.method_3().OwnerParagraph.method_5();
            int num3 = A_0.method_4().method_5();
            int num4 = A_0.method_4().OwnerParagraph.method_5();
            Body owner = A_0.method_3().OwnerParagraph.Owner as Body;
            if (num2 == num4)
            {
                this.method_10(owner.Items[num2] as Paragraph, num, num3);
            }
            else if (((owner.Items[num2] as Paragraph).Items.Count > 1) && (num > 0))
            {
                this.method_10(owner.Items[num2] as Paragraph, num, (owner.Items[num2] as Paragraph).Items.Count);
                this.method_10(owner, num2 + 1, num4);
                if (num3 == ((owner.Items[num2 + 1] as Paragraph).Items.Count - 1))
                {
                    owner.Items.RemoveAt(num2 + 1);
                }
                else if ((owner.Items[num2 + 1] as Paragraph).Items.Count > 0)
                {
                    this.method_10(owner.Items[num2 + 1] as Paragraph, 0, num3 + 1);
                }
            }
            else
            {
                this.method_10(owner, num2, num4);
                if (num3 == ((owner.Items[num2 + 1] as Paragraph).Items.Count - 1))
                {
                    owner.Items.RemoveAt(num2 + 1);
                }
                else if ((owner.Items[num2 + 1] as Paragraph).Items.Count > 0)
                {
                    this.method_10(owner.Items[num2 + 1] as Paragraph, 0, num3 + 1);
                }
            }
        }

        private void method_50(IMergeField A_0)
        {
            if (this.bool_0 && (this.string_1 == null))
            {
                A_0.Text = "";
                (A_0 as Spire.Doc.Fields.MergeField).ConvertedToText = true;
            }
            else
            {
                int rowIndex = -1;
                string str = this.method_66(A_0.FieldName);
                if (str != null)
                {
                    for (int i = 0; i < this.string_0.Length; i++)
                    {
                        if (this.string_0[i].ToUpper() == str.ToUpper())
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                }
                if (rowIndex == -1)
                {
                    for (int j = 0; j < this.string_0.Length; j++)
                    {
                        if (this.string_0[j].ToUpper() == A_0.FieldName.ToUpper())
                        {
                            rowIndex = j;
                            break;
                        }
                    }
                }
                if (rowIndex != -1)
                {
                    MergeFieldEventArgs e = new MergeFieldEventArgs(this.Document, "", rowIndex, A_0, this.string_1[rowIndex]);
                    if (this.mergeFieldEventHandler_0 != null)
                    {
                        this.mergeFieldEventHandler_0(this, e);
                        if (e.IsKeepTextFormat)
                        {
                            (A_0 as Spire.Doc.Fields.MergeField).IsToTextOfMergeFieldEvent = true;
                        }
                    }
                    A_0.Text = e.Text;
                    (A_0 as Spire.Doc.Fields.MergeField).ConvertedToText = true;
                }
                else if (this.bool_0)
                {
                    this.method_60(A_0, true);
                }
            }
        }

        private void method_51(Spire.Doc.Document A_0)
        {
            int num = 0;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䈥䜧䤩夫䌭唯就䀳", num));
            }
            this.sectionCollection_0.Clear();
            A_0.Sections.method_12(this.sectionCollection_0);
        }

        private void method_52(Spire.Doc.Document A_0)
        {
            int num = 0x10;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("刵圷夹䤻匽┿ⱁぃ", num));
            }
            ISection section = null;
            int num2 = 0;
            int count = this.sectionCollection_0.Count;
            while (num2 < count)
            {
                section = this.sectionCollection_0[num2];
                A_0.Sections.Add(section.Clone());
                num2++;
            }
        }

        private Bitmap method_53(object A_0)
        {
            if (!(A_0.GetType() == typeof(byte[])))
            {
                return null;
            }
            MemoryStream stream = new MemoryStream((byte[]) A_0);
            try
            {
                return new Bitmap(stream);
            }
            catch
            {
                return null;
            }
        }

        private void method_54(List<string> A_0, BodyRegion A_1, string A_2)
        {
            if (A_1 is ITable)
            {
                Table table = A_1 as Table;
                TableRow row = null;
                TableCell cell = null;
                BodyRegion region = null;
                int num = 0;
                int count = table.Rows.Count;
                while (num < count)
                {
                    row = table.Rows[num];
                    int num8 = 0;
                    int num9 = row.Cells.Count;
                    while (num8 < num9)
                    {
                        cell = row.Cells[num8];
                        int num3 = 0;
                        int num10 = cell.Paragraphs.Count;
                        while (num3 < num10)
                        {
                            region = cell.Items[num3];
                            this.method_54(A_0, region, A_2);
                            num3++;
                        }
                        num8++;
                    }
                    num++;
                }
            }
            else
            {
                int num6 = 0;
                int num7 = (A_1 as Paragraph).Items.Count;
                while (num6 < num7)
                {
                    ParagraphBase base2 = (A_1 as Paragraph)[num6];
                    if (base2 is Spire.Doc.Fields.MergeField)
                    {
                        Spire.Doc.Fields.MergeField field = base2 as Spire.Doc.Fields.MergeField;
                        if (field.FieldName == A_2)
                        {
                            if (!this.bool_2 && smethod_0(field))
                            {
                                this.bool_2 = true;
                                this.bool_3 = false;
                            }
                            if (!this.bool_3 && smethod_1(field))
                            {
                                this.bool_3 = true;
                                this.bool_2 = false;
                            }
                        }
                        else if ((A_2 == null) || (this.bool_2 && !this.bool_3))
                        {
                            A_0.Add(field.FieldName);
                        }
                    }
                    else if (base2 is TextBox)
                    {
                        TextBox box = (TextBox) (A_1 as Paragraph)[num6];
                        int num5 = box.Body.Items.Count;
                        for (int i = 0; i < num5; i++)
                        {
                            this.method_54(A_0, box.Body.Items[i], A_2);
                        }
                    }
                    num6++;
                }
            }
        }

        private bool method_55(IRowsEnumerator A_0)
        {
            if (A_0.RowsCount > 0)
            {
                return true;
            }
            if (!this.bool_0 && !this.bool_4)
            {
                return true;
            }
            Class55 class2 = this.class55_0;
            if (class2.method_0() != null)
            {
                if (this.bool_0)
                {
                    this.method_58(class2.method_0().TextBody.Items);
                }
                if (this.bool_4)
                {
                    this.EmptyParaList.Add(class2.method_0().TextBody.Items);
                }
            }
            else if (class2.method_2() != null)
            {
                int num2 = class2.method_2().int_0;
                int num3 = class2.method_2().int_1;
                for (int i = num2; i <= num3; i++)
                {
                    if (class2.method_2().table_0.Rows.Count > num2)
                    {
                        if (this.bool_0)
                        {
                            this.method_57(class2.method_2().table_0.Rows[i]);
                        }
                        if (this.bool_4)
                        {
                            this.EmptyParaList.Add(class2.method_2().table_0.Rows[i]);
                        }
                    }
                }
            }
            return false;
        }

        private void method_56(IWSectionCollection A_0)
        {
            int num = 0;
            int count = A_0.Count;
            while (num < count)
            {
                this.method_36(A_0[num], null);
                num++;
            }
        }

        private void method_57(TableRow A_0)
        {
            TableCell cell = null;
            int num = 0;
            int count = A_0.Cells.Count;
            while (num < count)
            {
                cell = A_0.Cells[num];
                this.method_58(cell.Items);
                num++;
            }
        }

        private void method_58(BodyRegionCollection A_0)
        {
            BodyRegion region = null;
            int num = 0;
            int count = A_0.Count;
            while (num < count)
            {
                region = A_0[num];
                if (region is Paragraph)
                {
                    this.method_59(region as Paragraph);
                }
                else if (region is Table)
                {
                    Table table = region as Table;
                    int num3 = 0;
                    int num4 = table.Rows.Count;
                    while (num3 < num4)
                    {
                        this.method_57(table.Rows[num3]);
                        num3++;
                    }
                }
                num++;
            }
        }

        private void method_59(Paragraph A_0)
        {
            Field field = null;
            int num = 0;
            int count = A_0.Items.Count;
            while (num < count)
            {
                if (A_0.Items[num] is Field)
                {
                    field = A_0.Items[num] as Field;
                    if ((field.Type == FieldType.FieldMergeField) || (field.Type == FieldType.FieldNext))
                    {
                        this.method_60(field, true);
                    }
                }
                else if (A_0.Items[num] is TextBox)
                {
                    this.method_58((A_0.Items[num] as TextBox).Body.Items);
                }
                num++;
            }
        }

        private void method_6(Class55 A_0)
        {
            int num = A_0.method_3().method_5();
            int num2 = A_0.method_4().method_5();
            int num3 = A_0.method_3().OwnerParagraph.method_5();
            int cellIndex = (A_0.method_3().Owner.Owner as TableCell).GetCellIndex();
            int num5 = (A_0.method_4().Owner.Owner as TableCell).GetCellIndex();
            int rowIndex = (A_0.method_3().Owner.Owner.Owner as TableRow).GetRowIndex();
            int num7 = (A_0.method_4().Owner.Owner.Owner as TableRow).GetRowIndex();
            int num8 = A_0.method_4().OwnerParagraph.method_5();
            Table owner = A_0.method_3().Owner.Owner.Owner.Owner as Table;
            this.method_7(A_0, owner, num, num3, cellIndex, num5, rowIndex, num7);
            if (rowIndex != num7)
            {
                this.method_8(A_0, owner, num2, num8, cellIndex, num5, rowIndex, num7);
            }
            else if ((num == 0) && (num3 == 0))
            {
                if ((num8 == (owner.Rows[rowIndex].Cells[cellIndex].Items.Count - 1)) && (num2 == ((owner.Rows[rowIndex].Cells[cellIndex].Items[num8] as Paragraph).Items.Count - 1)))
                {
                    owner.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    this.method_10(owner.Rows[rowIndex].Cells[cellIndex].Items[num8], 0, num2);
                    this.method_10(owner.Rows[rowIndex].Cells[cellIndex], 0, num8);
                }
            }
        }

        private void method_60(IField A_0, bool A_1)
        {
            if (!(A_0 as Field).ConvertedToText)
            {
                A_0.Text = string.Empty;
                if ((A_0.Type == FieldType.FieldNext) && A_1)
                {
                    (A_0 as Field).ConvertedToText = true;
                }
                else if (A_0 is Spire.Doc.Fields.MergeField)
                {
                    Spire.Doc.Fields.MergeField field = A_0 as Spire.Doc.Fields.MergeField;
                    if ((smethod_0(field) || smethod_1(field)) || A_1)
                    {
                        field.ConvertedToText = true;
                    }
                }
            }
        }

        private void method_61(Paragraph A_0)
        {
            if (((A_0.Items.Count > 0) && (A_0.Items[0] is Spire.Doc.Fields.MergeField)) && this.method_62(A_0))
            {
                TableCell owner = A_0.Owner as TableCell;
                if ((owner != null) && ((owner.ChildObjects.Count == 1) || ((owner.Items.LastItem == A_0) && (A_0.PreviousSibling is Table))))
                {
                    A_0.ChildObjects.Clear();
                }
                else
                {
                    A_0.RemoveEmpty = true;
                }
            }
        }

        private bool method_62(Paragraph A_0)
        {
            bool flag = true;
            for (int i = 0; i < A_0.Items.Count; i++)
            {
                ParagraphBase base2 = A_0.Items[i];
                switch (base2.DocumentObjectType)
                {
                    case DocumentObjectType.Picture:
                        flag = false;
                        break;

                    case DocumentObjectType.MergeField:
                    {
                        Spire.Doc.Fields.MergeField field = A_0.Items[i] as Spire.Doc.Fields.MergeField;
                        if (!field.ConvertedToText || !string.IsNullOrEmpty(field.Text))
                        {
                            flag = false;
                        }
                        break;
                    }
                    default:
                        flag = false;
                        break;
                }
            }
            return flag;
        }

        private void method_63(TableRow A_0)
        {
            TableCell cell = null;
            int num = 0;
            int count = A_0.Cells.Count;
            while (num < count)
            {
                cell = A_0.Cells[num];
                this.method_64(cell.Items);
                num++;
            }
        }

        private void method_64(BodyRegionCollection A_0)
        {
            BodyRegion region = null;
            int num = 0;
            int count = A_0.Count;
            while (num < count)
            {
                region = A_0[num];
                if (region is Paragraph)
                {
                    if (this.method_65(A_0, num))
                    {
                        num--;
                        count--;
                    }
                }
                else if (region is Table)
                {
                    Table table = region as Table;
                    int num3 = 0;
                    int num4 = table.Rows.Count;
                    while (num3 < num4)
                    {
                        this.method_63(table.Rows[num3]);
                        num3++;
                    }
                }
                num++;
            }
        }

        private bool method_65(BodyRegionCollection A_0, int A_1)
        {
            Paragraph entity = A_0[A_1] as Paragraph;
            if (((entity.Items.Count > 0) && (entity.Text == string.Empty)) && (entity.Items[0] is Spire.Doc.Fields.MergeField))
            {
                A_0.Remove(entity);
                return true;
            }
            return false;
        }

        private string method_66(string A_0)
        {
            if ((this.dictionary_1 != null) && this.dictionary_1.ContainsKey(A_0))
            {
                return this.dictionary_1[A_0];
            }
            return null;
        }

        private void method_67()
        {
            if (this.Document.GrammarSpellingData != null)
            {
                this.Document.GrammarSpellingData.method_3(null);
                this.Document.GrammarSpellingData.method_1(null);
            }
        }

        private void method_7(Class55 A_0, Table A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7)
        {
            if (A_2 == 0)
            {
                if (A_3 != 0)
                {
                    this.method_10(A_1.Rows[A_6].Cells[A_4], A_3, A_1.Rows[A_6].Cells[A_4].Items.Count);
                }
                else if (A_4 == 0)
                {
                    if (A_6 != A_7)
                    {
                        this.method_10(A_1, A_6, A_7);
                    }
                    else if (A_4 == A_5)
                    {
                        A_1.Rows[A_6].Cells.RemoveAt(A_4);
                    }
                    else
                    {
                        this.method_10(A_1.Rows[A_6], A_4, A_5);
                    }
                }
                else if (A_6 == A_7)
                {
                    if (A_4 == A_5)
                    {
                        A_1.Rows[A_6].Cells.RemoveAt(A_4);
                    }
                    else
                    {
                        this.method_10(A_1.Rows[A_6], A_4, A_5);
                    }
                }
                else
                {
                    if (A_4 == (A_1.Rows[A_6].Cells.Count - 1))
                    {
                        A_1.Rows[A_6].Cells.RemoveAt(A_4);
                    }
                    else
                    {
                        this.method_10(A_1.Rows[A_6], A_4, A_1.Rows[A_6].Cells.Count - 1);
                    }
                    if ((A_6 + 1) < A_7)
                    {
                        this.method_10(A_1, A_6 + 1, A_7);
                    }
                }
            }
            else
            {
                this.method_10(A_1.Rows[A_6].Cells[A_4].Items[A_3] as Paragraph, A_2, (A_1.Rows[A_6].Cells[A_4].Items[A_3] as Paragraph).Items.Count);
                this.method_10(A_1.Rows[A_6].Cells[A_4], A_3 + 1, A_1.Rows[A_6].Cells[A_4].Items.Count);
                if (A_6 == A_7)
                {
                    this.method_10(A_1.Rows[A_6], A_4 + 1, A_5);
                }
                else
                {
                    this.method_10(A_1.Rows[A_6], A_4 + 1, A_1.Rows[A_6].Cells.Count);
                }
                this.method_10(A_1, A_6 + 1, A_7);
            }
        }

        private void method_8(Class55 A_0, Table A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7)
        {
            if ((A_6 != A_7) && (A_2 == ((A_1.Rows[A_6 + 1].Cells[A_5].Items[A_3] as Paragraph).Items.Count - 1)))
            {
                if (A_3 == (A_1.Rows[A_6 + 1].Cells[A_5].Items.Count - 1))
                {
                    if (A_5 == (A_1.Rows[A_6 + 1].Cells.Count - 1))
                    {
                        A_1.Rows.RemoveAt(A_6 + 1);
                    }
                    else
                    {
                        this.method_10(A_1.Rows[A_6 + 1], 0, A_5 + 1);
                    }
                }
                else
                {
                    this.method_10(A_1.Rows[A_6 + 1].Cells[A_5], 0, A_3 + 1);
                    this.method_10(A_1.Rows[A_6 + 1], 0, A_5);
                }
            }
            else
            {
                this.method_10(A_1.Rows[A_6 + 1].Cells[A_5].Items[A_3] as Paragraph, 0, A_2 + 1);
                this.method_10(A_1.Rows[A_6 + 1].Cells[A_5], 0, A_3);
                this.method_10(A_1.Rows[A_6 + 1], 0, A_5);
            }
        }

        private void method_9(Class55 A_0)
        {
            int num = A_0.method_3().method_5();
            int num2 = A_0.method_3().OwnerParagraph.method_5();
            int num3 = A_0.method_4().method_5();
            int num4 = A_0.method_4().OwnerParagraph.method_5();
            TableCell owner = A_0.method_3().OwnerParagraph.Owner as TableCell;
            if (((owner.Items[num2] as Paragraph).Items.Count > 1) && (num > 0))
            {
                this.method_10(owner.Items[num2] as Paragraph, num, (owner.Items[num2] as Paragraph).Items.Count);
                this.method_10(owner, num2 + 1, num4);
                if (num3 == ((owner.Items[num2 + 1] as Paragraph).Items.Count - 1))
                {
                    owner.Items.RemoveAt(num2 + 1);
                }
                else if ((owner.Items[num2 + 1] as Paragraph).Items.Count > 0)
                {
                    this.method_10(owner.Items[num2 + 1] as Paragraph, 0, num3);
                }
            }
            else
            {
                this.method_10(owner, num2, num4);
                if (num2 != num4)
                {
                    if (num3 == ((owner.Items[num2 + 1] as Paragraph).Items.Count - 1))
                    {
                        owner.Items.RemoveAt(num2 + 1);
                    }
                    else if ((owner.Items[num2 + 1] as Paragraph).Items.Count > 0)
                    {
                        this.method_10(owner.Items[num2 + 1] as Paragraph, 0, (owner.Items[num2 + 1] as Paragraph).Items.Count + 1);
                    }
                }
                else if (num3 == ((owner.Items[num2] as Paragraph).Items.Count - 1))
                {
                    owner.Items.RemoveAt(num2);
                }
                else if ((owner.Items[num2] as Paragraph).Items.Count > 0)
                {
                    this.method_10(owner.Items[num2] as Paragraph, 0, num3 + 1);
                }
            }
        }

        protected MergeFieldEventArgs SendMergeField(IMergeField field, object value, IRowsEnumerator rowsEnum)
        {
            MergeFieldEventArgs e = new MergeFieldEventArgs(this.Document, rowsEnum.TableName, rowsEnum.CurrentRowIndex, field, value);
            if (this.mergeFieldEventHandler_0 != null)
            {
                this.mergeFieldEventHandler_0(this, e);
            }
            return e;
        }

        protected MergeGroupEventArgs SendMergeGroup(GroupEventType eventType, IRowsEnumerator rowsEnum)
        {
            MergeGroupEventArgs e = new MergeGroupEventArgs(this.Document, rowsEnum, eventType);
            if (this.mergeGroupEventHandler_0 != null)
            {
                this.mergeGroupEventHandler_0(this, e);
            }
            return e;
        }

        protected MergeGroupEventArgs SendMergeGroup(GroupEventType eventType, IRowsEnumerator rowsEnum, IMergeField mergerField)
        {
            MergeGroupEventArgs e = new MergeGroupEventArgs(this.Document, rowsEnum, eventType, mergerField);
            if (this.mergeGroupEventHandler_0 != null)
            {
                this.mergeGroupEventHandler_0(this, e);
            }
            return e;
        }

        protected MergeImageFieldEventArgs SendMergeImageField(IMergeField field, object bmp, IRowsEnumerator rowsEnum)
        {
            MergeImageFieldEventArgs e = null;
            if (rowsEnum != null)
            {
                e = new MergeImageFieldEventArgs(this.Document, rowsEnum.TableName, rowsEnum.CurrentRowIndex, field, bmp);
            }
            else
            {
                e = new MergeImageFieldEventArgs(this.Document, null, 0x7fffffff, field, bmp);
            }
            if (this.mergeImageFieldEventHandler_0 != null)
            {
                this.mergeImageFieldEventHandler_0(this, e);
            }
            return e;
        }

        protected MergeImageFieldEventArgs SendMergeImageField(IMergeField field, object bmp, string imageName)
        {
            MergeImageFieldEventArgs e = new MergeImageFieldEventArgs(this.Document, null, 0x7fffffff, field, bmp, imageName);
            if (this.mergeImageFieldEventHandler_0 != null)
            {
                this.mergeImageFieldEventHandler_0(this, e);
            }
            return e;
        }

        private static bool smethod_0(Spire.Doc.Fields.MergeField A_0)
        {
            int num = 0x10;
            string prefix = A_0.Prefix;
            if (!(prefix == BookmarkStart.b("戵夷堹倻嬽ጿ㙁╃㑅㱇", 0x10)))
            {
                return (prefix == BookmarkStart.b("焵䨷唹䤻丽ጿ㙁╃㑅㱇", num));
            }
            return true;
        }

        private static bool smethod_1(Spire.Doc.Fields.MergeField A_0)
        {
            int num = 12;
            string prefix = A_0.Prefix;
            if (!(prefix == BookmarkStart.b("昱唳吵吷弹礻倽␿", 12)))
            {
                return (prefix == BookmarkStart.b("由䘳夵䴷䨹礻倽␿", num));
            }
            return true;
        }

        private static bool smethod_2(Spire.Doc.Fields.MergeField A_0)
        {
            return (A_0.Prefix == BookmarkStart.b("稭儯倱堳匵欷丹崻䰽㐿", 8));
        }

        private static bool smethod_3(Spire.Doc.Fields.MergeField A_0)
        {
            return (A_0.Prefix == BookmarkStart.b("怳圵娷嘹夻笽⸿♁", 14));
        }

        public bool ClearFields
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        private Dictionary<string, bool> ClearFieldsState
        {
            get
            {
                if (this.dictionary_2 == null)
                {
                    this.dictionary_2 = new Dictionary<string, bool>();
                }
                return this.dictionary_2;
            }
        }

        public bool ClearGroupTag
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        private DataSet CurrentDataSet
        {
            get
            {
                if (this.dataSet_0 == null)
                {
                    this.dataSet_0 = new DataSet();
                }
                return this.dataSet_0;
            }
        }

        private MailMergeDataSet CurrentDataSetDocIO
        {
            get
            {
                if (this.mailMergeDataSet_1 == null)
                {
                    this.mailMergeDataSet_1 = new MailMergeDataSet();
                }
                return this.mailMergeDataSet_1;
            }
        }

        protected Spire.Doc.Document Document
        {
            get
            {
                return this.document_0;
            }
        }

        private List<object> EmptyParaList
        {
            get
            {
                if (this.list_2 == null)
                {
                    this.list_2 = new List<object>();
                }
                return this.list_2;
            }
        }

        private Stack<Class55> GroupSelectors
        {
            get
            {
                if (this.stack_0 == null)
                {
                    this.stack_0 = new Stack<Class55>();
                }
                return this.stack_0;
            }
        }

        private Dictionary<string, Spire.Doc.Fields.MergeField> GroupStartMergeFieldList
        {
            get
            {
                if (this.dictionary_4 == null)
                {
                    this.dictionary_4 = new Dictionary<string, Spire.Doc.Fields.MergeField>();
                }
                return this.dictionary_4;
            }
        }

        public bool HideEmptyGroup
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        public bool HideEmptyParagraphs
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        public Dictionary<string, string> MappedFields
        {
            get
            {
                if (this.dictionary_1 == null)
                {
                    this.dictionary_1 = new Dictionary<string, string>();
                }
                return this.dictionary_1;
            }
        }

        private Dictionary<string, IRowsEnumerator> NestedEnums
        {
            get
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<string, IRowsEnumerator>();
                }
                return this.dictionary_0;
            }
        }

        private Regex VariableCommandRegex
        {
            get
            {
                int num = 2;
                if (this.regex_0 == null)
                {
                    this.regex_0 = new Regex(BookmarkStart.b("ധȩ眫瀭ሯᜱ椳ᴵᄷἹ", num));
                }
                return this.regex_0;
            }
        }

        internal class Class55
        {
            private Body body_0;
            private Body body_1;
            private MailMerge.Class56 class56_0;
            private Delegate0 delegate0_0;
            private Delegate1 delegate1_0;
            private Dictionary<string, Class882> dictionary_0;
            private int int_0;
            private int int_1;
            private int int_2;
            private int int_3;
            private int int_4;
            private int int_5;
            private int int_6;
            private int int_7;
            private int int_8;
            private IRowsEnumerator irowsEnumerator_0;
            private MergeField mergeField_0;
            private MergeField mergeField_1;
            private string string_0;
            private TextBodySelection textBodySelection_0;

            internal Class55(Delegate0 A_0)
            {
                this.int_1 = -1;
                this.int_2 = -1;
                this.int_3 = -1;
                this.int_4 = -1;
                this.int_5 = -1;
                this.int_6 = -1;
                this.int_7 = -1;
                this.int_8 = -1;
                this.delegate0_0 = (Delegate0) Delegate.Combine(this.delegate0_0, A_0);
            }

            internal Class55(Delegate0 A_0, Delegate1 A_1)
            {
                this.int_1 = -1;
                this.int_2 = -1;
                this.int_3 = -1;
                this.int_4 = -1;
                this.int_5 = -1;
                this.int_6 = -1;
                this.int_7 = -1;
                this.int_8 = -1;
                this.delegate0_0 = (Delegate0) Delegate.Combine(this.delegate0_0, A_0);
                this.delegate1_0 = (Delegate1) Delegate.Combine(this.delegate1_0, A_1);
            }

            internal TextBodySelection method_0()
            {
                return this.textBodySelection_0;
            }

            internal Dictionary<string, Class882> method_1()
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<string, Class882>();
                }
                return this.dictionary_0;
            }

            internal int method_10()
            {
                return this.int_8;
            }

            private void method_11(IRowsEnumerator A_0)
            {
                this.textBodySelection_0 = null;
                this.class56_0 = null;
                this.mergeField_0 = null;
                this.mergeField_1 = null;
                this.int_0 = 0;
                this.int_1 = -1;
                this.int_3 = -1;
                this.int_4 = -1;
                this.int_2 = -1;
                this.int_5 = -1;
                this.int_6 = -1;
                this.int_8 = -1;
                this.irowsEnumerator_0 = A_0;
                this.string_0 = this.irowsEnumerator_0.TableName;
            }

            internal bool method_12()
            {
                if ((this.method_3() == null) || (this.method_4() == null))
                {
                    return false;
                }
                if (((this.method_3() != null) && !this.method_3().OwnerParagraph.IsInCell) || ((this.method_4() != null) && !this.method_4().OwnerParagraph.IsInCell))
                {
                    return false;
                }
                return (this.method_3().OwnerParagraph.Owner == this.method_4().OwnerParagraph.Owner);
            }

            private void method_13(ICompositeObject A_0)
            {
                Stack<string> stack = new Stack<string>();
                this.method_14(A_0, stack);
            }

            private void method_14(ICompositeObject A_0, Stack<string> A_1)
            {
                foreach (IDocumentObject obj2 in A_0.ChildObjects)
                {
                    if (obj2 is ICompositeObject)
                    {
                        this.method_14(obj2 as ICompositeObject, A_1);
                    }
                    else if (obj2 is MergeField)
                    {
                        MergeField field = obj2 as MergeField;
                        if (MailMerge.smethod_0(field))
                        {
                            A_1.Push(field.FieldName);
                            field.Domain = field.FieldName;
                        }
                        else if (MailMerge.smethod_1(field))
                        {
                            string fieldName = field.FieldName;
                            field.Domain = fieldName;
                            if (fieldName == A_1.Peek())
                            {
                                A_1.Pop();
                            }
                        }
                        else if (A_1.Count > 0)
                        {
                            field.Domain = A_1.Peek();
                        }
                    }
                }
            }

            internal void method_15(Body A_0, IRowsEnumerator A_1)
            {
                this.method_13(A_0);
                this.method_11(A_1);
                this.body_0 = this.body_1 = A_0;
                this.method_17(this.body_1.Items);
            }

            internal void method_16(Table A_0, int A_1, int A_2, IRowsEnumerator A_3)
            {
                this.method_11(A_3);
                this.method_18(A_0, A_1, A_2);
            }

            private void method_17(BodyRegionCollection A_0)
            {
                int itemEndIndex = 0;
                int count = A_0.Count;
                while (itemEndIndex < count)
                {
                    int paragraphItemEndIndex;
                    ParagraphBase base2;
                    Paragraph paragraph;
                    BodyRegion region = A_0[itemEndIndex];
                    this.int_0 = itemEndIndex;
                    switch (region.DocumentObjectType)
                    {
                        case DocumentObjectType.Paragraph:
                            paragraph = (Paragraph) region;
                            paragraphItemEndIndex = 0;
                            goto Label_024B;

                        case DocumentObjectType.StructureDocumentTag:
                            if (((region as StructureDocumentTag).SDTContent != null) && ((region as StructureDocumentTag).SDTContent.Items != null))
                            {
                                this.method_17((region as StructureDocumentTag).SDTContent.Items);
                            }
                            goto Label_02B8;

                        case DocumentObjectType.Table:
                        {
                            Table table = (Table) region;
                            this.method_18(table, 0, table.Rows.Count - 1);
                            goto Label_02B8;
                        }
                        default:
                            throw new Exception();
                    }
                Label_0078:
                    base2 = paragraph.Items[paragraphItemEndIndex];
                    if (((base2 is BookmarkStart) || (base2 is BookmarkEnd)) || ((base2 is Field) && ((base2 as Field).Type == FieldType.FieldRef)))
                    {
                        string key = string.Empty;
                        if (base2 is BookmarkStart)
                        {
                            key = (base2 as BookmarkStart).Name;
                        }
                        else if (base2 is BookmarkEnd)
                        {
                            key = (base2 as BookmarkEnd).Name;
                        }
                        else
                        {
                            key = (base2 as Field).Value;
                        }
                        if (!this.method_1().ContainsKey(key))
                        {
                            Class882 class2 = new Class882();
                            if (base2 is BookmarkStart)
                            {
                                class2.method_3(base2 as BookmarkStart);
                            }
                            else if (base2 is BookmarkEnd)
                            {
                                class2.method_1(base2 as BookmarkEnd);
                            }
                            else
                            {
                                class2.method_5(base2 as Field);
                            }
                            this.method_1().Add(key, class2);
                        }
                        else
                        {
                            Class882 class3 = this.method_1()[key];
                            if (base2 is BookmarkStart)
                            {
                                class3.method_3(base2 as BookmarkStart);
                            }
                            else if (base2 is BookmarkEnd)
                            {
                                class3.method_1(base2 as BookmarkEnd);
                            }
                            else
                            {
                                class3.method_5(base2 as Field);
                            }
                        }
                    }
                    this.int_2 = paragraphItemEndIndex;
                    if (base2 is TextBox)
                    {
                        this.int_0 = 0;
                        this.method_17((base2 as TextBox).Body.Items);
                        this.int_0 = itemEndIndex;
                    }
                    else
                    {
                        this.method_20(base2);
                    }
                    if (this.method_8())
                    {
                        if (this.textBodySelection_0 == null)
                        {
                            goto Label_025F;
                        }
                        bool flag = this.textBodySelection_0.ItemStartIndex == this.textBodySelection_0.ItemEndIndex;
                        itemEndIndex = this.textBodySelection_0.ItemEndIndex;
                        if (flag)
                        {
                            paragraphItemEndIndex = this.textBodySelection_0.ParagraphItemEndIndex;
                        }
                        count = A_0.Count;
                        this.method_19();
                        if (!flag)
                        {
                            goto Label_02B8;
                        }
                    }
                    paragraphItemEndIndex++;
                Label_024B:
                    if (paragraphItemEndIndex < paragraph.Items.Count)
                    {
                        goto Label_0078;
                    }
                    goto Label_02B8;
                Label_025F:
                    if (this.class56_0.int_0 == this.class56_0.int_1)
                    {
                        count = A_0.Count;
                    }
                Label_02B8:
                    itemEndIndex++;
                }
            }

            private void method_18(Table A_0, int A_1, int A_2)
            {
                int count = A_0.Rows.Count;
                for (int i = A_1; i <= A_2; i++)
                {
                    TableRow row = A_0.Rows[i];
                    this.int_6 = i;
                    int num3 = 0;
                    int num4 = row.Cells.Count;
                    while (num3 < num4)
                    {
                        TableCell cell = row.Cells[num3];
                        this.method_17(cell.Items);
                        if (this.method_8())
                        {
                            goto Label_0064;
                        }
                        num3++;
                    }
                    continue;
                Label_0064:
                    A_2 += A_0.Rows.Count - count;
                    i = this.class56_0.int_0;
                    this.method_19();
                }
            }

            private void method_19()
            {
                this.textBodySelection_0 = null;
                this.class56_0 = null;
                this.mergeField_0 = null;
                this.mergeField_1 = null;
            }

            internal MailMerge.Class56 method_2()
            {
                return this.class56_0;
            }

            private void method_20(ParagraphBase A_0)
            {
                if (A_0.DocumentObjectType == DocumentObjectType.MergeField)
                {
                    MergeField field = A_0 as MergeField;
                    if (field.FieldName == this.string_0)
                    {
                        if (this.mergeField_0 == null)
                        {
                            if (MailMerge.smethod_0(field))
                            {
                                this.method_21(field);
                            }
                        }
                        else if (MailMerge.smethod_1(field))
                        {
                            this.method_22(field);
                            if (this.delegate0_0 != null)
                            {
                                this.delegate0_0(this.irowsEnumerator_0);
                            }
                        }
                    }
                }
            }

            private void method_21(MergeField A_0)
            {
                this.mergeField_0 = A_0;
                Paragraph ownerParagraph = A_0.OwnerParagraph;
                StructureDocumentTag entity = this.method_23(ownerParagraph);
                this.body_0 = ownerParagraph.method_21();
                this.int_3 = this.int_0;
                if (entity != null)
                {
                    int index = this.body_0.ChildObjects.IndexOf(entity);
                    if (index > -1)
                    {
                        this.int_3 = index;
                        this.int_4 = this.int_0;
                    }
                }
                this.int_5 = this.int_2;
                this.int_7 = this.int_6;
            }

            private void method_22(MergeField A_0)
            {
                this.mergeField_1 = A_0;
                Paragraph ownerParagraph = A_0.OwnerParagraph;
                StructureDocumentTag entity = this.method_23(ownerParagraph);
                Body body = A_0.OwnerParagraph.method_21();
                if (entity != null)
                {
                    int index = body.ChildObjects.IndexOf(entity);
                    if (index > -1)
                    {
                        this.int_1 = this.int_0;
                        this.int_0 = index;
                    }
                }
                this.int_8 = (this.int_0 - this.int_3) + 1;
                if (body == this.body_0)
                {
                    this.textBodySelection_0 = new TextBodySelection(body, this.int_3, this.int_0, this.int_5, this.int_2, this.int_4, this.int_1);
                }
                else
                {
                    if (((body.DocumentObjectType != DocumentObjectType.TableCell) || (this.body_0.DocumentObjectType != DocumentObjectType.TableCell)) || ((this.body_0.Owner as TableRow).OwnerTable != (body.Owner as TableRow).OwnerTable))
                    {
                        throw new MailMergeException();
                    }
                    this.method_24(body as TableCell);
                    this.class56_0 = new MailMerge.Class56(body.Owner.Owner as Table, this.int_7, this.int_6);
                }
            }

            private StructureDocumentTag method_23(Paragraph A_0)
            {
                DocumentObject owner = A_0.Owner;
                while (owner != null)
                {
                    if (owner is StructureDocumentTag)
                    {
                        break;
                    }
                    owner = owner.Owner;
                }
                if (owner is StructureDocumentTag)
                {
                    return (owner as StructureDocumentTag);
                }
                return null;
            }

            private void method_24(TableCell A_0)
            {
                TableRow ownerRow = A_0.OwnerRow;
                bool flag = false;
                using (IEnumerator enumerator = ownerRow.Cells.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        TableCell current = (TableCell) enumerator.Current;
                        if (A_0.CellFormat.VerticalMerge != CellMerge.None)
                        {
                            goto Label_003B;
                        }
                    }
                    goto Label_0053;
                Label_003B:
                    flag = true;
                }
            Label_0053:
                if (flag)
                {
                    goto Label_00C0;
                }
                return;
            Label_00AF:
                if (!flag)
                {
                    return;
                }
                this.int_6++;
            Label_00C0:
                if (ownerRow.NextSibling != null)
                {
                    ownerRow = ownerRow.NextSibling as TableRow;
                    flag = false;
                    using (IEnumerator enumerator2 = ownerRow.Cells.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            TableCell cell2 = (TableCell) enumerator2.Current;
                            if (A_0.CellFormat.VerticalMerge != CellMerge.None)
                            {
                                goto Label_0097;
                            }
                        }
                        goto Label_00AF;
                    Label_0097:
                        flag = true;
                    }
                    goto Label_00AF;
                }
            }

            internal MergeField method_3()
            {
                return this.mergeField_0;
            }

            internal MergeField method_4()
            {
                return this.mergeField_1;
            }

            internal void method_5(MergeField A_0)
            {
                this.mergeField_1 = A_0;
            }

            internal int method_6()
            {
                return this.int_0;
            }

            internal void method_7(int A_0)
            {
                this.int_0 = A_0;
            }

            internal bool method_8()
            {
                return (this.mergeField_1 != null);
            }

            internal string method_9()
            {
                return this.string_0;
            }

            internal delegate void Delegate0(IRowsEnumerator A_0);

            internal delegate void Delegate1(IRowsEnumerator A_0);
        }

        internal class Class56
        {
            internal int int_0;
            internal int int_1;
            internal Table table_0;

            internal Class56(Table A_0, int A_1, int A_2)
            {
                this.table_0 = A_0;
                this.int_0 = A_1;
                this.int_1 = A_2;
                this.method_0();
            }

            private void method_0()
            {
                int num = 9;
                if ((this.int_0 < 0) || (this.int_0 >= this.table_0.Rows.Count))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("簮䔰刲䜴䌶欸吺䨼瘾⽀❂⁄㽆", num));
                }
                if ((this.int_1 < 0) || (this.int_1 >= this.table_0.Rows.Count))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("樮弰圲朴堶丸爺匼嬾⑀㭂", num));
                }
            }
        }
    }
}

