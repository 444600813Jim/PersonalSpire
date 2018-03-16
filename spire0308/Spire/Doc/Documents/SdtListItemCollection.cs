namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class SdtListItemCollection : IEnumerable
    {
        private float[] float_0;
        private int[] int_0;
        private int int_1 = -1;
        private List<SdtListItem> list_0 = new List<SdtListItem>();
        private long[] long_0;
        private SdtDropDownListBase sdtDropDownListBase_0;

        internal SdtListItemCollection(SdtDropDownListBase A_0)
        {
            this.sdtDropDownListBase_0 = A_0;
        }

        public void Add(SdtListItem item)
        {
            this.list_0.Add(item);
        }

        public void Clear()
        {
            this.list_0.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return this.list_0.GetEnumerator();
        }

        internal SdtListItemCollection method_0()
        {
            SdtListItemCollection items = (SdtListItemCollection) base.MemberwiseClone();
            items.list_0 = new List<SdtListItem>(this.list_0.Count);
            for (int i = 0; i < this.list_0.Count; i++)
            {
                items.Add(this[i].method_0());
            }
            return items;
        }

        public void RemoveAt(int index)
        {
            this.list_0.RemoveAt(index);
        }

        public int Count
        {
            get
            {
                return this.list_0.Count;
            }
        }

        public SdtListItem this[int index]
        {
            get
            {
                return this.list_0[index];
            }
        }

        internal SdtDropDownListBase Owner
        {
            get
            {
                return this.sdtDropDownListBase_0;
            }
            set
            {
                this.sdtDropDownListBase_0 = value;
            }
        }

        public SdtListItem SelectedValue
        {
            get
            {
                if (this.int_1 != -1)
                {
                    return this[this.int_1];
                }
                return null;
            }
            set
            {
                int num = 0x10;
                if (value == null)
                {
                    this.int_1 = -1;
                }
                else
                {
                    if (!this.list_0.Contains(value))
                    {
                        throw new ArgumentException(BookmarkStart.b("电夷吹᰻倽⼿㙁摃⁅ⅇ⑉⡋湍⍏❑㝓㹕硗ᙙ㵛ⵝᑟ㑡գ੥ᵧཀྵ䱫ݭṯ剱sṵᅷॹ屻ᵽﺉﺏ벑", num));
                    }
                    this.int_1 = this.list_0.IndexOf(value);
                    if (this.sdtDropDownListBase_0 != null)
                    {
                        this.sdtDropDownListBase_0.OnChange();
                    }
                }
            }
        }
    }
}

