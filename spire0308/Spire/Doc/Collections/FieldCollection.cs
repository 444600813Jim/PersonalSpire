namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using System;
    using System.Reflection;

    public class FieldCollection : CollectionEx
    {
        internal FieldCollection(Document A_0) : base(A_0, A_0)
        {
        }

        internal Field method_5(string A_0)
        {
            A_0.Replace('-', '_');
            for (int i = 0; i < base.InnerList.Count; i++)
            {
                Field field = base.InnerList[i] as Field;
                if (field.Value.Equals(A_0, StringComparison.CurrentCultureIgnoreCase))
                {
                    return field;
                }
            }
            return null;
        }

        internal void method_6(int A_0)
        {
            Field field = base.InnerList[A_0] as Field;
            this.method_7(field);
        }

        internal void method_7(Field A_0)
        {
            base.InnerList.Remove(A_0);
        }

        internal void method_8()
        {
            while (base.InnerList.Count > 0)
            {
                int num = base.InnerList.Count - 1;
                this.method_6(num);
            }
        }

        internal void method_9(Field A_0)
        {
            if (!base.InnerList.Contains(A_0))
            {
                base.InnerList.Add(A_0);
            }
        }

        internal Field this[string A_0]
        {
            get
            {
                return this.method_5(A_0);
            }
        }

        public Field this[int index]
        {
            get
            {
                return (base.InnerList[index] as Field);
            }
        }
    }
}

