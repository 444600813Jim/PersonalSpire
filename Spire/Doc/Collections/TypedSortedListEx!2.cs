namespace Spire.Doc.Collections
{
    using Spire.CompoundFile.Doc;
    using Spire.Doc;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.InteropServices;

    public class TypedSortedListEx<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary where TKey: IComparable
    {
        private Class1163<TKey, TValue> class1163_0;
        private Class1164<TKey, TValue> class1164_0;
        private Dictionary<TKey, TValue> dictionary_0;
        private TKey[] gparam_0;
        private IComparer<TKey> icomparer_0;
        private const int int_0 = 0x10;
        private int int_1;
        private int int_2;

        public TypedSortedListEx()
        {
            this.gparam_0 = new TKey[0x10];
            this.dictionary_0 = new Dictionary<TKey, TValue>(0x10);
            this.icomparer_0 = Comparer<TKey>.Default;
        }

        public TypedSortedListEx(IComparer<TKey> comparer) : this()
        {
            if (comparer != null)
            {
                this.icomparer_0 = comparer;
            }
        }

        public TypedSortedListEx(int initialCapacity)
        {
            int num = 0x13;
            if (initialCapacity < 0)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("倸唺吼䬾⡀≂⥄ц⡈㭊ⱌⱎ㡐❒ⱔ", num));
            }
            this.gparam_0 = new TKey[initialCapacity];
            this.dictionary_0 = new Dictionary<TKey, TValue>(initialCapacity);
            this.icomparer_0 = Comparer<TKey>.Default;
        }

        public TypedSortedListEx(IDictionary<TKey, TValue> d) : this(d, null)
        {
        }

        public TypedSortedListEx(IComparer<TKey> comparer, int capacity) : this(comparer)
        {
            this.Capacity = capacity;
        }

        public TypedSortedListEx(IDictionary<TKey, TValue> d, IComparer<TKey> comparer) : this(comparer, (d != null) ? d.Count : 0)
        {
            int num = 0x13;
            if (d == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("崸", num));
            }
            d.Keys.CopyTo(this.gparam_0, 0);
            this.dictionary_0 = new Dictionary<TKey, TValue>(d);
            Array.Sort<TKey>(this.gparam_0, comparer);
            this.int_1 = d.Count;
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            this.Add(item.Key, item.Value);
        }

        public virtual void Add(TKey key, TValue value)
        {
            int num = 14;
            if (key == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("弳匵䄷", num));
            }
            if (this.dictionary_0.ContainsKey(key))
            {
                throw new ArgumentException(BookmarkStart.b("瀳䌵䠷嘹唻崽ℿ㙁⅃≅", num));
            }
            int num2 = Array.BinarySearch<TKey>(this.gparam_0, 0, this.int_1, key, this.icomparer_0);
            this.method_0(~num2, key, value);
        }

        public void Add(object key, object value)
        {
            TKey local = (TKey) key;
            TValue local2 = (TValue) value;
            this.Add(local, local2);
        }

        public virtual void Clear()
        {
            this.int_2++;
            this.int_1 = 0;
            this.gparam_0 = new TKey[0x10];
            this.dictionary_0 = new Dictionary<TKey, TValue>(0x10);
        }

        public virtual object Clone()
        {
            TypedSortedListEx<TKey, TValue> ex = new TypedSortedListEx<TKey, TValue>(this.int_1);
            Array.Copy(this.gparam_0, 0, ex.gparam_0, 0, this.int_1);
            ex.dictionary_0 = new Dictionary<TKey, TValue>(this.dictionary_0);
            ex.int_1 = this.int_1;
            ex.int_2 = this.int_2;
            ex.icomparer_0 = this.icomparer_0;
            return ex;
        }

        public TypedSortedListEx<TKey, TValue> CloneAll()
        {
            int count = this.Count;
            TypedSortedListEx<TKey, TValue> ex = (TypedSortedListEx<TKey, TValue>) base.MemberwiseClone();
            ex.gparam_0 = new TKey[count];
            ex.dictionary_0 = new Dictionary<TKey, TValue>(count);
            ex.class1163_0 = null;
            ex.class1164_0 = null;
            ex.int_1 = 0;
            for (int i = 0; i < count; i++)
            {
                TKey key = this.GetKey(i);
                TValue local2 = this.dictionary_0[key];
                IDocCloneable cloneable = local2 as IDocCloneable;
                if (cloneable != null)
                {
                    local2 = (TValue) cloneable.Clone();
                }
                ex.Add(key, local2);
            }
            return ex;
        }

        public virtual bool Contains(TKey key)
        {
            return this.dictionary_0.ContainsKey(key);
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            TValue local;
            return (this.TryGetValue(item.Key, out local) && local.Equals(item.Value));
        }

        public bool Contains(object key)
        {
            if (key is TKey)
            {
                TKey local = (TKey) key;
                return this.ContainsKey(local);
            }
            return false;
        }

        public virtual bool ContainsKey(TKey key)
        {
            return this.dictionary_0.ContainsKey(key);
        }

        public virtual bool ContainsValue(TValue value)
        {
            return this.dictionary_0.ContainsValue(value);
        }

        public virtual void CopyTo(Array array, int arrayIndex)
        {
            int num = 9;
            if (array == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("丮䌰䄲吴丶", num));
            }
            if (array.Rank != 1)
            {
                throw new ArgumentException(BookmarkStart.b("丮䌰䄲吴丶", num));
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("丮䌰䄲吴丶瀸唺夼娾㥀", num));
            }
            if ((array.Length - arrayIndex) < this.Count)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < this.Count; i++)
            {
                KeyValuePair<TKey, TValue> pair = new KeyValuePair<TKey, TValue>(this.gparam_0[i], this.dictionary_0[this.gparam_0[i]]);
                array.SetValue(pair, (int) (i + arrayIndex));
            }
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            this.dictionary_0.CopyTo(array, arrayIndex);
        }

        public virtual TValue GetByIndex(int index)
        {
            int num = 0;
            if ((index < 0) || (index >= this.int_1))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("伥䘧丩䤫嘭", num));
            }
            return this.dictionary_0[this.gparam_0[index]];
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return new Class1161<TKey, TValue>((TypedSortedListEx<TKey, TValue>) this, 0, this.int_1);
        }

        public virtual TKey GetKey(int index)
        {
            int num = 12;
            if ((index < 0) || (index >= this.int_1))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("嬱娳刵崷䈹", num));
            }
            return this.gparam_0[index];
        }

        public virtual IList<TKey> GetKeyList()
        {
            if (this.class1163_0 == null)
            {
                this.class1163_0 = new Class1163<TKey, TValue>((TypedSortedListEx<TKey, TValue>) this);
            }
            return this.class1163_0;
        }

        public virtual IList<TValue> GetValueList()
        {
            if (this.class1164_0 == null)
            {
                this.class1164_0 = new Class1164<TKey, TValue>((TypedSortedListEx<TKey, TValue>) this);
            }
            else
            {
                this.class1164_0.vmethod_0();
            }
            return this.class1164_0;
        }

        public virtual int IndexOfKey(TKey key)
        {
            int num = 7;
            if (key == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䘬䨮䠰", num));
            }
            int num2 = Array.BinarySearch<TKey>(this.gparam_0, 0, this.int_1, key, this.icomparer_0);
            if (num2 < 0)
            {
                return -1;
            }
            return num2;
        }

        public virtual int IndexOfValue(TValue value)
        {
            object key = null;
            IDictionaryEnumerator enumerator = this.dictionary_0.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                if (enumerator.Value.Equals(value))
                {
                    key = enumerator.Key;
                    break;
                }
            }
            if (key == null)
            {
                return -1;
            }
            return Array.IndexOf(this.gparam_0, key, 0, this.int_1);
        }

        private void method_0(int A_0, TKey A_1, TValue A_2)
        {
            if (this.int_1 == this.gparam_0.Length)
            {
                this.method_1(this.int_1 + 1);
            }
            if (A_0 < this.int_1)
            {
                Array.Copy(this.gparam_0, A_0, this.gparam_0, A_0 + 1, this.int_1 - A_0);
            }
            this.gparam_0[A_0] = A_1;
            this.dictionary_0[A_1] = A_2;
            this.int_1++;
            this.int_2++;
        }

        private void method_1(int A_0)
        {
            int num = (this.gparam_0.Length == 0) ? 0x10 : (this.gparam_0.Length * 2);
            if (num < A_0)
            {
                num = A_0;
            }
            this.Capacity = num;
        }

        public virtual bool Remove(TKey key)
        {
            int index = this.IndexOfKey(key);
            if (index >= 0)
            {
                this.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void Remove(object key)
        {
            if (key is TKey)
            {
                this.Remove((TKey) key);
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return this.Remove(item.Key);
        }

        public virtual void RemoveAt(int index)
        {
            int num = 7;
            if ((index < 0) || (index >= this.int_1))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䐬䄮唰嘲䴴", num));
            }
            this.int_1--;
            TKey key = this.gparam_0[index];
            if (index < this.int_1)
            {
                Array.Copy(this.gparam_0, index + 1, this.gparam_0, index, this.int_1 - index);
            }
            this.gparam_0[this.int_1] = default(TKey);
            this.dictionary_0.Remove(key);
            this.int_2++;
        }

        public virtual void SetByIndex(int index, TValue value)
        {
            int num = 3;
            if ((index < 0) || (index >= this.int_1))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䀨䔪䤬䨮䤰", num));
            }
            this.dictionary_0[this.gparam_0[index]] = value;
            this.int_2++;
        }

        public static TypedSortedListEx<TKey, TValue> Synchronized(TypedSortedListEx<TKey, TValue> list)
        {
            int num = 0x11;
            if (list == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嬶倸䠺䤼", num));
            }
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            return this.dictionary_0.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public virtual void TrimToSize()
        {
            this.Capacity = this.int_1;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return this.dictionary_0.TryGetValue(key, out value);
        }

        public virtual int Capacity
        {
            get
            {
                return this.gparam_0.Length;
            }
            set
            {
                int num = 5;
                if (value != this.gparam_0.Length)
                {
                    if (value < this.int_1)
                    {
                        throw new ArgumentOutOfRangeException(BookmarkStart.b("崪䰬䌮䐰嘲", num));
                    }
                    if (value > 0)
                    {
                        TKey[] destinationArray = new TKey[value];
                        if (this.int_1 > 0)
                        {
                            Array.Copy(this.gparam_0, 0, destinationArray, 0, this.int_1);
                        }
                        this.gparam_0 = destinationArray;
                    }
                    else
                    {
                        this.gparam_0 = new TKey[0x10];
                    }
                }
            }
        }

        public virtual int Count
        {
            get
            {
                return this.int_1;
            }
        }

        public virtual bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public virtual bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public virtual bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public virtual TValue this[TKey key]
        {
            get
            {
                TValue local;
                this.dictionary_0.TryGetValue(key, out local);
                return local;
            }
            set
            {
                int num = 14;
                if (key == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("弳匵䄷", num));
                }
                if (this.dictionary_0.ContainsKey(key))
                {
                    this.dictionary_0[key] = value;
                }
                else
                {
                    this.Add(key, value);
                }
                this.int_2++;
            }
        }

        public object this[object key]
        {
            get
            {
                return ((key is TKey) ? this[(TKey) key] : default(TValue));
            }
            set
            {
                this[(TKey) key] = (TValue) value;
            }
        }

        public virtual IList<TKey> Keys
        {
            get
            {
                return this.GetKeyList();
            }
        }

        public virtual object SyncRoot
        {
            get
            {
                return this;
            }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get
            {
                return this.Keys;
            }
        }

        ICollection<TValue> IDictionary<TKey, TValue>.Values
        {
            get
            {
                return this.dictionary_0.Values;
            }
        }

        ICollection IDictionary.Keys
        {
            get
            {
                return this.dictionary_0.Keys;
            }
        }

        ICollection IDictionary.Values
        {
            get
            {
                return this.dictionary_0.Values;
            }
        }

        public virtual IList<TValue> Values
        {
            get
            {
                return this.GetValueList();
            }
        }

        [Serializable]
        private class Class1161 : IEnumerator<KeyValuePair<T, U>>, IDocCloneable
        {
            private bool bool_0;
            private T gparam_0;
            private U gparam_1;
            private int int_0;
            private int int_1;
            private int int_2;
            private int int_3;
            private TypedSortedListEx<T, U> typedSortedListEx_0;

            internal Class1161(TypedSortedListEx<T, U> A_0, int A_1, int A_2)
            {
                this.typedSortedListEx_0 = A_0;
                this.int_0 = A_1;
                this.int_1 = A_1;
                this.int_2 = A_1 + A_2;
                this.int_3 = this.typedSortedListEx_0.int_2;
                this.bool_0 = false;
            }

            public void Dispose()
            {
            }

            public virtual bool MoveNext()
            {
                if (this.int_3 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException();
                }
                if (this.int_0 < this.int_2)
                {
                    this.gparam_0 = this.typedSortedListEx_0.gparam_0[this.int_0];
                    this.gparam_1 = this.typedSortedListEx_0.dictionary_0[this.gparam_0];
                    this.int_0++;
                    this.bool_0 = true;
                    return true;
                }
                this.gparam_0 = default(T);
                this.gparam_1 = default(U);
                this.bool_0 = false;
                return false;
            }

            public virtual void Reset()
            {
                if (this.int_3 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException();
                }
                this.int_0 = this.int_1;
                this.bool_0 = false;
                this.gparam_0 = default(T);
                this.gparam_1 = default(U);
            }

            object IDocCloneable.Clone()
            {
                return base.MemberwiseClone();
            }

            public virtual T vmethod_0()
            {
                if (this.int_3 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException();
                }
                if (!this.bool_0)
                {
                    throw new InvalidOperationException();
                }
                return this.gparam_0;
            }

            public virtual KeyValuePair<T, U> vmethod_1()
            {
                if (this.int_3 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException();
                }
                if (!this.bool_0)
                {
                    throw new InvalidOperationException();
                }
                return new KeyValuePair<T, U>(this.gparam_0, this.gparam_1);
            }

            public virtual object vmethod_2()
            {
                if (this.int_3 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException();
                }
                if (!this.bool_0)
                {
                    throw new InvalidOperationException();
                }
                return this.gparam_1;
            }

            KeyValuePair<T, U> IEnumerator<KeyValuePair<T, U>>.Current
            {
                get
                {
                    if (!this.bool_0)
                    {
                        throw new InvalidOperationException();
                    }
                    return new KeyValuePair<T, U>(this.gparam_0, this.gparam_1);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    if (!this.bool_0)
                    {
                        throw new InvalidOperationException();
                    }
                    return new KeyValuePair<T, U>(this.gparam_0, this.gparam_1);
                }
            }
        }

        private class Class1162 : IEnumerator<T>
        {
            private int int_0;
            private int int_1;
            private TypedSortedListEx<T, U> typedSortedListEx_0;

            public Class1162(TypedSortedListEx<T, U> A_0)
            {
                int num = 5;
                this.int_0 = -1;
                if (A_0 == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("䜪䐬尮䔰", num));
                }
                this.typedSortedListEx_0 = A_0;
                this.int_1 = this.typedSortedListEx_0.int_2;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                int num = 0x11;
                if (this.int_1 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException(BookmarkStart.b("朶堸䤺堼儾㕀捂♄⡆╈❊⡌ⱎ═㩒㩔㥖祘ⱚ㱜ⱞ䅠b൤٦ݨ౪࡬୮", num));
                }
                if (this.int_0 < 0)
                {
                    this.int_0 = 0;
                }
                else
                {
                    this.int_0++;
                }
                if (this.int_0 >= this.typedSortedListEx_0.int_1)
                {
                    this.int_0 = -1;
                }
                return (this.int_0 >= 0);
            }

            public void Reset()
            {
                int num = 0;
                if (this.int_1 != this.typedSortedListEx_0.int_2)
                {
                    throw new InvalidOperationException(BookmarkStart.b("瘥䤧堩䤫䀭䐯ሱ圳夵吷嘹夻崽㐿⭁⭃⡅桇㵉ⵋ㵍灏ㅑ㱓㝕㙗㵙㥛㩝", num));
                }
                this.int_0 = -1;
            }

            T IEnumerator<T>.Current
            {
                get
                {
                    int num = 9;
                    if (this.int_1 != this.typedSortedListEx_0.int_2)
                    {
                        throw new InvalidOperationException(BookmarkStart.b("缮倰䄲倴夶䴸ᬺ帼倾ⵀ⽂⁄⑆㵈≊≌ⅎ煐⑒㑔⑖祘㡚㕜㹞འѢdͦ", num));
                    }
                    if ((this.int_0 < 0) || (this.int_0 >= this.typedSortedListEx_0.int_1))
                    {
                        throw new InvalidOperationException();
                    }
                    return this.typedSortedListEx_0.gparam_0[this.int_0];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    int num = 11;
                    if ((this.int_0 < 0) || (this.int_0 >= this.typedSortedListEx_0.int_1))
                    {
                        throw new InvalidOperationException();
                    }
                    if (this.int_1 != this.typedSortedListEx_0.int_2)
                    {
                        throw new InvalidOperationException(BookmarkStart.b("愰刲䜴制圸伺ᴼ尾⹀⽂⥄≆⩈㽊⑌⁎㽐獒≔㙖⩘筚㹜㝞`ൢɤɦ൨", num));
                    }
                    return this.typedSortedListEx_0.gparam_0[this.int_0];
                }
            }
        }

        [Serializable, DefaultMember("Item")]
        private class Class1163 : IList<T>
        {
            private TypedSortedListEx<T, U> typedSortedListEx_0;

            internal Class1163(TypedSortedListEx<T, U> A_0)
            {
                this.typedSortedListEx_0 = A_0;
            }

            public void Add(T key)
            {
                throw new NotSupportedException();
            }

            public virtual void Clear()
            {
                throw new NotSupportedException();
            }

            public virtual bool Contains(T key)
            {
                return this.typedSortedListEx_0.ContainsKey(key);
            }

            public virtual void CopyTo(T[] array, int arrayIndex)
            {
                int num = 0x12;
                if (array == null)
                {
                    throw new ArgumentException(BookmarkStart.b("夷䠹主弽㤿", num));
                }
                Array.Copy(this.typedSortedListEx_0.gparam_0, 0, array, arrayIndex, this.typedSortedListEx_0.Count);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return new TypedSortedListEx<T, U>.Class1162(this.typedSortedListEx_0);
            }

            public bool Remove(T key)
            {
                throw new NotSupportedException();
            }

            int IList<T>.IndexOf(T A_0)
            {
                int num = 11;
                if (A_0 == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("娰嘲䰴", num));
                }
                int num2 = Array.BinarySearch<T>(this.typedSortedListEx_0.gparam_0, 0, this.typedSortedListEx_0.Count, A_0, this.typedSortedListEx_0.icomparer_0);
                if (num2 < 0)
                {
                    return -1;
                }
                return num2;
            }

            void IList<T>.Insert(int A_0, T A_1)
            {
                throw new NotSupportedException();
            }

            void IList<T>.RemoveAt(int A_0)
            {
                throw new NotSupportedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new TypedSortedListEx<T, U>.Class1162(this.typedSortedListEx_0);
            }

            public virtual bool vmethod_0()
            {
                return true;
            }

            public virtual bool vmethod_1()
            {
                return this.typedSortedListEx_0.IsSynchronized;
            }

            public virtual object vmethod_2()
            {
                return this.typedSortedListEx_0.SyncRoot;
            }

            public virtual void vmethod_3(Array A_0, int A_1)
            {
                int num = 1;
                if (A_0 == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("䘦嬨太䰬嘮", num));
                }
                if (A_0.Rank != 1)
                {
                    throw new ArgumentException(BookmarkStart.b("䘦嬨太䰬嘮", num));
                }
                Array.Copy(this.typedSortedListEx_0.gparam_0, 0, A_0, A_1, this.typedSortedListEx_0.Count);
            }

            public virtual int Count
            {
                get
                {
                    return this.typedSortedListEx_0.int_1;
                }
            }

            public virtual bool IsReadOnly
            {
                get
                {
                    return true;
                }
            }

            T IList<T>.this[int A_0]
            {
                get
                {
                    return this.typedSortedListEx_0.GetKey(A_0);
                }
                set
                {
                    throw new NotSupportedException();
                }
            }
        }

        [Serializable, DefaultMember("Item")]
        private class Class1164 : IList<U>
        {
            private U[] gparam_0;
            private TypedSortedListEx<T, U> typedSortedListEx_0;

            internal Class1164(TypedSortedListEx<T, U> A_0)
            {
                this.typedSortedListEx_0 = A_0;
                this.vmethod_0();
            }

            public virtual void Add(U value)
            {
                throw new NotSupportedException();
            }

            public virtual void Clear()
            {
                throw new NotSupportedException();
            }

            public virtual bool Contains(U value)
            {
                return this.typedSortedListEx_0.ContainsValue(value);
            }

            public virtual void CopyTo(U[] array, int arrayIndex)
            {
                int num = 9;
                if (array == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("丮䌰䄲吴丶", num));
                }
                if (array.Rank != 1)
                {
                    throw new ArgumentException(BookmarkStart.b("丮䌰䄲䜴嘶䀸", num));
                }
                Array.Copy(this.gparam_0, 0, array, arrayIndex, this.typedSortedListEx_0.Count);
            }

            public virtual IEnumerator<U> GetEnumerator()
            {
                return ((IEnumerable<U>) this.gparam_0).GetEnumerator();
            }

            public virtual bool Remove(U value)
            {
                throw new NotSupportedException();
            }

            int IList<U>.IndexOf(U A_0)
            {
                return Array.IndexOf<U>(this.gparam_0, A_0, 0, this.typedSortedListEx_0.Count);
            }

            void IList<U>.Insert(int A_0, U A_1)
            {
                throw new NotSupportedException();
            }

            void IList<U>.RemoveAt(int A_0)
            {
                throw new NotSupportedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public virtual void vmethod_0()
            {
                int count = this.typedSortedListEx_0.Count;
                this.gparam_0 = new U[count];
                this.typedSortedListEx_0.dictionary_0.Values.CopyTo(this.gparam_0, 0);
                T[] array = new T[count];
                this.typedSortedListEx_0.dictionary_0.Keys.CopyTo(array, 0);
                Array.Sort<T, U>(array, this.gparam_0, this.typedSortedListEx_0.icomparer_0);
            }

            public virtual bool vmethod_1()
            {
                return true;
            }

            public virtual bool vmethod_2()
            {
                return this.typedSortedListEx_0.IsSynchronized;
            }

            public virtual object vmethod_3()
            {
                return this.typedSortedListEx_0.SyncRoot;
            }

            public virtual void vmethod_4(Array A_0, int A_1)
            {
                if ((A_0 != null) && (A_0.Rank != 1))
                {
                    throw new ArgumentException();
                }
                Array.Copy(this.gparam_0, 0, A_0, A_1, this.typedSortedListEx_0.Count);
            }

            public virtual int Count
            {
                get
                {
                    return this.typedSortedListEx_0.int_1;
                }
            }

            public virtual bool IsReadOnly
            {
                get
                {
                    return true;
                }
            }

            U IList<U>.this[int A_0]
            {
                get
                {
                    return this.typedSortedListEx_0.GetByIndex(A_0);
                }
                set
                {
                    this.typedSortedListEx_0.SetByIndex(A_0, value);
                }
            }
        }
    }
}

