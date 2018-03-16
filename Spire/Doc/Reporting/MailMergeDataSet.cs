namespace Spire.Doc.Reporting
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MailMergeDataSet
    {
        private float[] float_0;
        private float[] float_1;
        private List<object> list_0 = new List<object>();
        private long long_0;
        private string string_0 = BookmarkStart.b("缷䠹医䬽〿ు╃⭅ⵇ", 0x12);
        private string string_1 = BookmarkStart.b("欷唹䤻䰽⌿❁C❅㱇⭉", 0x12);

        public void Add(object dataTable)
        {
            this.list_0.Add(dataTable);
        }

        public void Clear()
        {
            this.list_0.Clear();
            this.list_0 = null;
        }

        internal MailMergeDataTable method_0(string A_0)
        {
            using (List<object>.Enumerator enumerator = this.list_0.GetEnumerator())
            {
                object current;
                Type type;
                string str;
                IEnumerator enumerator2;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    type = current.GetType();
                    str = type.GetProperty(this.string_0).GetValue(current, null).ToString();
                    if (!string.IsNullOrEmpty(str) && (str == A_0))
                    {
                        goto Label_005C;
                    }
                }
                goto Label_009D;
            Label_005C:
                enumerator2 = type.GetProperty(this.string_1).GetValue(current, null) as IEnumerator;
                MailMergeDataTable table = null;
                if (enumerator2 != null)
                {
                    table = new MailMergeDataTable(str, enumerator2);
                }
                return table;
            }
        Label_009D:
            return null;
        }

        internal void method_1(string A_0)
        {
            using (List<object>.Enumerator enumerator = this.list_0.GetEnumerator())
            {
                object current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    string str = current.GetType().GetProperty(this.string_0).GetValue(current, null).ToString();
                    if (!string.IsNullOrEmpty(str) && (str == A_0))
                    {
                        goto Label_0053;
                    }
                }
                return;
            Label_0053:
                this.list_0.Remove(current);
            }
        }

        internal bool method_2(object A_0)
        {
            return ((this.list_0 != null) && this.list_0.Contains(A_0));
        }

        public List<object> DataSet
        {
            get
            {
                return this.list_0;
            }
        }
    }
}

