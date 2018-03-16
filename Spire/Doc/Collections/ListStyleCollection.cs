namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class ListStyleCollection : DocumentSerializableCollection
    {
        private bool bool_0;
        private Dictionary<string, string> dictionary_0;
        internal Dictionary<int, Dictionary<int, string>> dictionary_1;
        internal Dictionary<int, string> dictionary_2;
        internal Dictionary<int, int> dictionary_3;
        internal IList<ListStyle> ilist_0;
        internal IList<Class12> ilist_1;
        private int int_2;
        private string[] string_1;
        private string string_2;
        private string[] string_3;

        internal ListStyleCollection(Document A_0) : base(A_0, null)
        {
            this.dictionary_1 = new Dictionary<int, Dictionary<int, string>>();
            this.dictionary_2 = new Dictionary<int, string>();
        }

        public int Add(ListStyle style)
        {
            int num = 13;
            if (style == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䀲䄴丶唸帺", num));
            }
            style.method_0(base.Document);
            return base.InnerList.Add(style);
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new ListStyle(base.Document);
        }

        public ListStyle FindByName(string name)
        {
            return (StyleCollection.smethod_0(base.InnerList, name) as ListStyle);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䜳䈵䄷嘹夻", 14);
        }

        internal int method_5(string A_0)
        {
            for (int i = 0; i < base.InnerList.Count; i++)
            {
                if ((base.InnerList[i] as ListStyle).Name == A_0)
                {
                    return i;
                }
            }
            return -1;
        }

        internal void method_6()
        {
            this.ilist_0 = null;
            this.dictionary_1 = new Dictionary<int, Dictionary<int, string>>();
            this.ilist_1 = null;
            this.dictionary_2 = new Dictionary<int, string>();
            this.dictionary_3 = new Dictionary<int, int>();
        }

        internal int method_7(ListFormat A_0)
        {
            return this.method_8(A_0, false);
        }

        internal int method_8(ListFormat A_0, bool A_1)
        {
            int num4;
            int key = 0;
            string lFOStyleName = string.Empty;
            Class12 item = new Class12(A_0.Document);
            ListStyle style = null;
            if ((A_0.LFOStyleName == string.Empty) || (A_0.CurrentListStyle.Name != string.Empty))
            {
                for (int i = 0; i < base.InnerList.Count; i++)
                {
                    lFOStyleName = (base.InnerList[i] as ListStyle).Name;
                    if (lFOStyleName == A_0.CustomStyleName)
                    {
                        style = base.InnerList[i] as ListStyle;
                        break;
                    }
                    key++;
                }
            }
            int num2 = key + 1;
            if (A_0.LFOStyleName == null)
            {
                key++;
                goto Label_0197;
            }
            lFOStyleName = A_0.LFOStyleName;
            if (this.int_2 == 0)
            {
                this.int_2 = base.InnerList.Count + 1;
            }
            if (!this.dictionary_1.ContainsKey(num2))
            {
                item = A_0.Document.ListOverrides.method_35(A_0.LFOStyleName);
                key = this.method_9(num2, A_0.LFOStyleName);
                goto Label_0197;
            }
            Dictionary<int, string> dictionary = this.dictionary_1[num2];
            bool flag = false;
            using (Dictionary<int, string>.KeyCollection.Enumerator enumerator2 = dictionary.Keys.GetEnumerator())
            {
                int current;
                while (enumerator2.MoveNext())
                {
                    current = enumerator2.Current;
                    if (dictionary[current] == A_0.LFOStyleName)
                    {
                        goto Label_0151;
                    }
                }
                goto Label_0167;
            Label_0151:
                key = current;
                flag = true;
            }
        Label_0167:
            if (!flag)
            {
                item = A_0.Document.ListOverrides.method_35(A_0.LFOStyleName);
                key = this.method_9(num2, A_0.LFOStyleName);
            }
        Label_0197:
            if (!A_1)
            {
                return key;
            }
            if (this.ilist_0 == null)
            {
                this.ilist_0 = new List<ListStyle>();
            }
            if (this.ilist_1 == null)
            {
                this.ilist_1 = new List<Class12>();
            }
            if (!this.dictionary_2.ContainsKey(key))
            {
                if (!this.ilist_0.Contains(style))
                {
                    this.ilist_0.Add(style);
                }
                this.dictionary_2.Add(key, lFOStyleName);
                this.ilist_1.Add(item);
                this.dictionary_3.Add(this.ilist_1.Count, this.ilist_0.IndexOf(style));
                return this.ilist_1.Count;
            }
            int num3 = 0;
            using (Dictionary<int, string>.Enumerator enumerator = this.dictionary_2.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    KeyValuePair<int, string> pair = enumerator.Current;
                    if (pair.Key == key)
                    {
                        goto Label_026B;
                    }
                    num3++;
                }
                return key;
            Label_026B:
                num4 = num3 + 1;
            }
            return num4;
        }

        private int method_9(int A_0, string A_1)
        {
            if (!this.dictionary_1.ContainsKey(A_0))
            {
                this.dictionary_1.Add(A_0, new Dictionary<int, string>());
            }
            this.dictionary_1[A_0].Add(this.int_2, A_1);
            int num = this.int_2;
            this.int_2++;
            return num;
        }

        public ListStyle this[int index]
        {
            get
            {
                return (ListStyle) base.InnerList[index];
            }
        }

        internal Dictionary<string, string> ListStyleNames
        {
            get
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<string, string>();
                }
                return this.dictionary_0;
            }
        }
    }
}

