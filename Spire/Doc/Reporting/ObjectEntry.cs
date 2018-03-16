namespace Spire.Doc.Reporting
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;

    public class ObjectEntry
    {
        private byte byte_0;
        public DocumentObject Current;
        public int Index;
        private int[] int_0;

        public ObjectEntry(DocumentObject ent)
        {
            this.Current = ent;
            this.Index = 0;
        }

        public bool Fetch()
        {
            if (((this.Current != null) && (this.Current.Owner != null)) && this.Current.Owner.IsComposite)
            {
                ICompositeObject owner = this.Current.Owner as ICompositeObject;
                if (owner.ChildObjects.Count > (this.Index + 1))
                {
                    this.Index++;
                    this.Current = owner.ChildObjects[this.Index];
                    return true;
                }
            }
            this.Current = null;
            this.Index = -1;
            return false;
        }
    }
}

