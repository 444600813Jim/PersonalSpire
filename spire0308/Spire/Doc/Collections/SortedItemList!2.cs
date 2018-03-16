namespace Spire.Doc.Collections
{
    using System;
    using System.Collections.Generic;

    public class SortedItemList<TKey, TValue> : TypedSortedListEx<TKey, TValue> where TKey: IComparable
    {
        public SortedItemList()
        {
        }

        public SortedItemList(int count) : base(count)
        {
        }

        public SortedItemList(IComparer<TKey> comparer) : base(comparer)
        {
        }

        public SortedItemList(IDictionary<TKey, TValue> dictionary) : base(dictionary)
        {
        }
    }
}

