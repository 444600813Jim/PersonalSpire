namespace Spire.Doc.Documents.Markup
{
    using Spire.Doc;
    using System;
    using System.Collections;
    using System.Reflection;

    public class CustomXmlPartCollection : IEnumerable
    {
        private readonly ArrayList arrayList_0 = new ArrayList();
        private bool[] bool_0;
        private byte byte_0;
        private Document document_0;
        private int int_0;
        private long[] long_0;

        public CustomXmlPartCollection(Document doc)
        {
            this.document_0 = doc;
        }

        public void Add(CustomXmlPart part)
        {
            this.arrayList_0.Add(part);
        }

        public void Clear()
        {
            this.arrayList_0.Clear();
        }

        public CustomXmlPartCollection Clone()
        {
            CustomXmlPartCollection parts = new CustomXmlPartCollection(this.document_0);
            foreach (CustomXmlPart part in this)
            {
                parts.Add(part.Clone());
            }
            return parts;
        }

        public CustomXmlPart GetById(string id)
        {
            CustomXmlPart part2;
            using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
            {
                CustomXmlPart current;
                while (enumerator.MoveNext())
                {
                    current = (CustomXmlPart) enumerator.Current;
                    if (current.Id == id)
                    {
                        goto Label_0033;
                    }
                }
                return null;
            Label_0033:
                part2 = current;
            }
            return part2;
        }

        public IEnumerator GetEnumerator()
        {
            return this.arrayList_0.GetEnumerator();
        }

        public void RemoveAt(int index)
        {
            this.arrayList_0.RemoveAt(index);
        }

        public int Count
        {
            get
            {
                return this.arrayList_0.Count;
            }
        }

        public CustomXmlPart this[int index]
        {
            get
            {
                return (CustomXmlPart) this.arrayList_0[index];
            }
            set
            {
                this.arrayList_0[index] = value;
            }
        }
    }
}

