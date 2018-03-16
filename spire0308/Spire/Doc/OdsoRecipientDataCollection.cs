namespace Spire.Doc
{
    using System;
    using System.Collections;
    using System.Reflection;

    public class OdsoRecipientDataCollection : IEnumerable
    {
        private readonly ArrayList arrayList_0 = new ArrayList();
        private bool[] bool_0;
        private int int_0;
        private string string_0;

        public int Add(OdsoRecipientData value)
        {
            int num = 2;
            if (value == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("帧䬩䀫嬭唯", num));
            }
            return this.arrayList_0.Add(value);
        }

        public void Clear()
        {
            this.arrayList_0.Clear();
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

        public OdsoRecipientData this[int index]
        {
            get
            {
                return (OdsoRecipientData) this.arrayList_0[index];
            }
            set
            {
                int num = 0x13;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("伸娺儼䨾⑀", num));
                }
                this.arrayList_0[index] = value;
            }
        }
    }
}

