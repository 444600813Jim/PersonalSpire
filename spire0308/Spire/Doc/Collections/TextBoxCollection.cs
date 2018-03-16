namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using System;
    using System.Reflection;

    public class TextBoxCollection : CollectionEx
    {
        internal TextBoxCollection(Document A_0) : base(A_0, A_0)
        {
        }

        public void Clear()
        {
            while (base.InnerList.Count > 0)
            {
                int index = base.InnerList.Count - 1;
                this.RemoveAt(index);
            }
        }

        internal void method_5(TextBox A_0)
        {
            base.InnerList.Add(A_0);
        }

        internal void method_6(TextBox A_0)
        {
            base.InnerList.Remove(A_0);
        }

        public void RemoveAt(int index)
        {
            TextBox entity = base.InnerList[index] as TextBox;
            entity.OwnerParagraph.Items.Remove(entity);
        }

        public TextBox this[int index]
        {
            get
            {
                return (base.InnerList[index] as TextBox);
            }
        }
    }
}

