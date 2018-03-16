namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class TabCollection : DocumentSerializableCollection
    {
        private bool[] bool_0;
        private bool bool_1;
        private int int_2;
        private long[] long_4;
        private string string_1;

        internal TabCollection(Document A_0) : base(A_0, null)
        {
        }

        internal TabCollection(Document A_0, FormatBase A_1) : this(A_0)
        {
            base.method_0(A_1);
        }

        public Tab AddTab()
        {
            return this.AddTab(0f, TabJustification.Left, TabLeader.NoLeader);
        }

        public Tab AddTab(float position)
        {
            return this.AddTab(position, TabJustification.Left, TabLeader.NoLeader);
        }

        public Tab AddTab(float position, TabJustification justification, TabLeader leader)
        {
            Tab tab = new Tab(base.Document, this.method_8((double) position), justification, leader);
            this.method_6(tab);
            return tab;
        }

        public void Clear()
        {
            base.InnerList.Clear();
            this.method_9();
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new Tab(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("洸娺弼", 0x13);
        }

        internal void method_5(double A_0)
        {
            int num = 0;
            while (num < base.Count)
            {
                if (this[num].Position == this.method_8(A_0))
                {
                    base.InnerList.Remove(this[num]);
                }
                else
                {
                    num++;
                }
            }
            this.method_9();
        }

        internal void method_6(Tab A_0)
        {
            int index = -1;
            if (A_0.Position > 0f)
            {
                int num2 = 0;
                int count = base.InnerList.Count;
                while (num2 < count)
                {
                    Tab tab = (Tab) base.InnerList[num2];
                    if (num2 == (count - 1))
                    {
                        if (A_0.Position >= tab.Position)
                        {
                            goto Label_008A;
                        }
                        index = count - 1;
                        break;
                    }
                    Tab tab2 = (Tab) base.InnerList[num2 + 1];
                    if (A_0.Position < tab.Position)
                    {
                        index = num2;
                        break;
                    }
                    if ((A_0.Position >= tab.Position) && (A_0.Position <= tab2.Position))
                    {
                        index = num2 + 1;
                        break;
                    }
                Label_008A:
                    num2++;
                }
            }
            if (index < 0)
            {
                base.InnerList.Add(A_0);
            }
            else
            {
                base.InnerList.Insert(index, A_0);
            }
            A_0.method_0(this);
            this.method_9();
        }

        internal bool method_7(float A_0, TabJustification A_1, TabLeader A_2)
        {
            foreach (object obj2 in base.InnerList)
            {
                if (((obj2 is Tab) && ((obj2 as Tab).Position == this.method_8((double) A_0))) && (((obj2 as Tab).Justification == A_1) && ((obj2 as Tab).TabLeader == A_2)))
                {
                    return true;
                }
            }
            return false;
        }

        internal float method_8(double A_0)
        {
            return (float) Math.Round(A_0, 2);
        }

        internal void method_9()
        {
            if (!this.bool_1 && ((base.OwnerBase != null) && (base.OwnerBase is ParagraphFormat)))
            {
                (base.OwnerBase as ParagraphFormat).method_52(this);
            }
        }

        public void RemoveAt(int index)
        {
            base.InnerList.RemoveAt(index);
            this.method_9();
        }

        internal bool CancelOnChangeEvent
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        public Tab this[int index]
        {
            get
            {
                return (Tab) base.InnerList[index];
            }
        }
    }
}

