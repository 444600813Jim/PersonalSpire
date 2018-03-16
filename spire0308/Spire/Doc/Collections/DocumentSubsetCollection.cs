namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Reflection;

    public abstract class DocumentSubsetCollection : IDocumentObjectCollection
    {
        private DocumentObjectCollection documentObjectCollection_0;
        private DocumentObjectType documentObjectType_0;
        private int int_0 = -1;
        private int int_1 = -1;
        private int int_2;

        internal DocumentSubsetCollection(DocumentObjectCollection A_0, DocumentObjectType A_1)
        {
            this.documentObjectCollection_0 = A_0;
            this.documentObjectType_0 = A_1;
            this.method_9();
            A_0.class54_0.method_0(new DocumentObjectCollection.ChangeItems(this.method_11));
        }

        public void Clear()
        {
            this.documentObjectCollection_0.method_11(this.documentObjectType_0);
            this.int_2 = 0;
            this.int_0 = -1;
            this.int_1 = -1;
        }

        protected DocumentObject GetByIndex(int index)
        {
            if ((this.int_1 >= 0) && (index != this.int_0))
            {
                bool flag = this.int_0 < index;
                while (index != this.int_0)
                {
                    this.int_1 = this.documentObjectCollection_0.method_10(this.int_1, this.documentObjectType_0, flag);
                    this.int_0 += flag ? 1 : -1;
                }
            }
            else
            {
                this.int_1 = this.method_8(index);
                this.int_0 = index;
            }
            if (this.int_1 < 0)
            {
                this.int_1 = this.method_8(index);
                this.int_0 = index;
            }
            return this.documentObjectCollection_0[this.int_1];
        }

        public IEnumerator GetEnumerator()
        {
            return new SubSetEnumerator(this);
        }

        internal DocumentObject method_0(DocumentObject A_0)
        {
            int num = this.method_4(A_0);
            if ((num >= 0) && (num <= (this.Count - 2)))
            {
                return this.GetByIndex(num + 1);
            }
            return null;
        }

        internal DocumentObject method_1(DocumentObject A_0)
        {
            int num = this.method_4(A_0);
            if ((num >= 1) && (num <= (this.Count - 1)))
            {
                return this.GetByIndex(num - 1);
            }
            return null;
        }

        private void method_10(DocumentObject A_0)
        {
            int num = 6;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䤫䀭䐯嬱䀳伵", num));
            }
            if (A_0.DocumentObjectType != this.documentObjectType_0)
            {
                throw new ArgumentException(BookmarkStart.b("攫䀭䘯匱堳張尷ᨹ夻倽㐿⭁ぃ㽅桇㹉㕋㹍㕏", num));
            }
        }

        private void method_11(DocumentObjectCollection.ChangeItemsType A_0, DocumentObject A_1)
        {
            switch (A_0)
            {
                case DocumentObjectCollection.ChangeItemsType.Add:
                    if (A_1.DocumentObjectType != this.documentObjectType_0)
                    {
                        break;
                    }
                    this.int_2++;
                    return;

                case DocumentObjectCollection.ChangeItemsType.Remove:
                    if (A_1.DocumentObjectType != this.documentObjectType_0)
                    {
                        break;
                    }
                    this.int_2--;
                    return;

                case DocumentObjectCollection.ChangeItemsType.Clear:
                    this.int_2 = 0;
                    break;

                default:
                    return;
            }
        }

        internal void method_12()
        {
            this.int_0 = -1;
            this.int_1 = -1;
        }

        internal int method_2(DocumentObject A_0)
        {
            this.method_10(A_0);
            this.documentObjectCollection_0.Add(A_0);
            return (this.int_2 - 1);
        }

        internal bool method_3(DocumentObject A_0)
        {
            this.method_10(A_0);
            return this.documentObjectCollection_0.Contains(A_0);
        }

        internal int method_4(DocumentObject A_0)
        {
            this.method_10(A_0);
            for (int i = 0; i < this.Count; i++)
            {
                if (this.GetByIndex(i) == A_0)
                {
                    return i;
                }
            }
            return -1;
        }

        internal int method_5(int A_0, DocumentObject A_1)
        {
            int num = this.method_8(A_0);
            this.documentObjectCollection_0.Insert(A_0, A_1);
            num++;
            return num;
        }

        internal void method_6(DocumentObject A_0)
        {
            this.method_10(A_0);
            this.documentObjectCollection_0.Remove(A_0);
        }

        internal void method_7(int A_0)
        {
            int index = this.method_8(A_0);
            this.documentObjectCollection_0.RemoveAt(index);
        }

        private int method_8(int A_0)
        {
            int num = 0;
            int num2 = 0;
            int count = this.documentObjectCollection_0.Count;
            while (num2 < count)
            {
                DocumentObject obj2 = this.documentObjectCollection_0[num2];
                if (obj2.DocumentObjectType == this.documentObjectType_0)
                {
                    if (num == A_0)
                    {
                        return num2;
                    }
                    num++;
                }
                num2++;
            }
            return -1;
        }

        private void method_9()
        {
            int num = -1;
            this.int_2 = 0;
            while (true)
            {
                num = this.documentObjectCollection_0.method_10(num, this.documentObjectType_0, true);
                if (num < 0)
                {
                    return;
                }
                this.int_2++;
            }
        }

        public int Count
        {
            get
            {
                return this.int_2;
            }
        }

        public Spire.Doc.Document Document
        {
            get
            {
                return this.documentObjectCollection_0.Document;
            }
        }

        public DocumentObject this[int index]
        {
            get
            {
                int num = 7;
                if (this.documentObjectCollection_0.Count < 1)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("䐬䄮唰嘲䴴", num));
                }
                return this.GetByIndex(index);
            }
        }

        public DocumentObject Owner
        {
            get
            {
                return this.documentObjectCollection_0.Owner;
            }
        }

        public class SubSetEnumerator : IEnumerator
        {
            private bool[] bool_0;
            private DocumentSubsetCollection documentSubsetCollection_0;
            private int int_0 = -1;

            public SubSetEnumerator(DocumentSubsetCollection enColl)
            {
                this.documentSubsetCollection_0 = enColl;
            }

            public bool MoveNext()
            {
                int num = this.documentSubsetCollection_0.documentObjectCollection_0.method_10(this.int_0, this.documentSubsetCollection_0.documentObjectType_0, true);
                if (num < 0)
                {
                    return false;
                }
                this.int_0 = num;
                return true;
            }

            public void Reset()
            {
                this.int_0 = -1;
            }

            public object Current
            {
                get
                {
                    if (this.int_0 < 0)
                    {
                        return null;
                    }
                    return this.documentSubsetCollection_0.documentObjectCollection_0[this.int_0];
                }
            }
        }
    }
}

