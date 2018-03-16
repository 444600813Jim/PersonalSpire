namespace Spire.Doc.Fields.Shape
{
    using System;
    using System.Collections;
    using System.Reflection;

    public class DigitalSignatures : IEnumerable
    {
        private readonly ArrayList arrayList_0 = new ArrayList();
        private bool[] bool_0;
        private float float_0;
        private readonly Hashtable hashtable_0 = new Hashtable();

        public IEnumerator GetEnumerator()
        {
            return this.arrayList_0.GetEnumerator();
        }

        internal void method_0(DigitalSignature A_0)
        {
            this.arrayList_0.Add(A_0);
            if (A_0.Visible)
            {
                this.hashtable_0.Add(A_0.SetupId, A_0);
            }
        }

        internal DigitalSignature method_1(string A_0)
        {
            return (DigitalSignature) this.hashtable_0[new Guid(A_0)];
        }

        public int Count
        {
            get
            {
                return this.arrayList_0.Count;
            }
        }

        public bool IsValid
        {
            get
            {
                bool flag;
                using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        DigitalSignature current = (DigitalSignature) enumerator.Current;
                        if (!current.IsValid)
                        {
                            goto Label_002D;
                        }
                    }
                    return true;
                Label_002D:
                    flag = false;
                }
                return flag;
            }
        }

        public DigitalSignature this[int index]
        {
            get
            {
                return (DigitalSignature) this.arrayList_0[index];
            }
        }
    }
}

