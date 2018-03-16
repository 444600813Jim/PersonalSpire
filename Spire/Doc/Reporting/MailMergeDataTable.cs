namespace Spire.Doc.Reporting
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MailMergeDataTable
    {
        private float[] float_0;
        private IEnumerator ienumerator_0;
        private string string_0;

        public MailMergeDataTable(string groupName, IEnumerable enumerable)
        {
            this.string_0 = groupName;
            this.ienumerator_0 = enumerable.GetEnumerator();
        }

        internal MailMergeDataTable(string A_0, IEnumerator A_1)
        {
            this.string_0 = A_0;
            this.ienumerator_0 = A_1;
        }

        internal MailMergeDataTable method_0(string A_0)
        {
            string[] strArray = A_0.Split(new char[] { ' ' });
            string name = strArray[0];
            string str2 = strArray[2];
            MailMergeDataTable table = null;
            List<object> list = new List<object>();
            this.ienumerator_0.Reset();
            while (this.ienumerator_0.MoveNext())
            {
                object obj2 = this.ienumerator_0.Current.GetType().GetProperty(name).GetValue(this.ienumerator_0.Current, null);
                if (str2 == obj2.ToString())
                {
                    list.Add(this.ienumerator_0.Current);
                }
            }
            if (list.Count > 0)
            {
                table = new MailMergeDataTable(this.GroupName, list.GetEnumerator());
            }
            return table;
        }

        public string GroupName
        {
            get
            {
                return this.string_0;
            }
        }

        public IEnumerator SourceData
        {
            get
            {
                return this.ienumerator_0;
            }
        }
    }
}

