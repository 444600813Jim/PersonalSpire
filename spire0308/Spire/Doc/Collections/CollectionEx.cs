namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public abstract class CollectionEx : OwnerHolder, IEnumerable
    {
        private byte byte_0;
        private float float_0;
        private int int_1;
        private List<object> list_0;
        private long long_2;
        private long[] long_3;

        protected CollectionEx(Document doc, OwnerHolder owner) : base(doc, owner)
        {
            this.list_0 = new List<object>();
        }

        public IEnumerator GetEnumerator()
        {
            return this.list_0.GetEnumerator();
        }

        internal void method_4()
        {
            this.InnerList.Clear();
        }

        public int Count
        {
            get
            {
                return this.list_0.Count;
            }
        }

        internal IList InnerList
        {
            get
            {
                return this.list_0;
            }
        }
    }
}

