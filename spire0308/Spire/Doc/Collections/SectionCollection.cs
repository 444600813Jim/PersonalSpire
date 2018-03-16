namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class SectionCollection : DocumentObjectCollection, IWSectionCollection
    {
        private float float_1;
        private float[] float_2;
        private int[] int_2;
        private string string_1;
        private static readonly Type[] type_0 = new Type[] { typeof(Section) };

        internal SectionCollection() : base(null, null)
        {
        }

        public SectionCollection(Document doc) : base(doc, doc)
        {
        }

        public int Add(ISection section)
        {
            return base.Add(section);
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new Section(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䌯圱圳䈵儷唹刻", 10);
        }

        public int IndexOf(ISection section)
        {
            return base.InnerList.IndexOf(section);
        }

        internal string method_22()
        {
            string str = string.Empty;
            for (int i = 0; i < base.Count; i++)
            {
                str = str + this[i].method_24();
                if (!str.EndsWith(Class816.string_27))
                {
                    str = str + Class816.string_27;
                }
            }
            return str;
        }

        protected override void OnRemove(int index)
        {
            if ((index == 0) && (base.Count > 1))
            {
                Section section = this[1];
                if (section.HeadersFooters.LinkToPrevious)
                {
                    section.HeadersFooters.method_10();
                }
                foreach (HeaderFooter footer in section.HeadersFooters)
                {
                    if (footer.LinkToPrevious)
                    {
                        footer.LinkToPrevious = false;
                    }
                }
            }
            base.OnRemove(index);
        }

        public Section this[int index]
        {
            get
            {
                return (base.InnerList[index] as Section);
            }
        }

        protected override Type[] TypesOfElement
        {
            get
            {
                return type_0;
            }
        }
    }
}

