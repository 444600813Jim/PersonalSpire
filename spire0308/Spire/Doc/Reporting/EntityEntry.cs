namespace Spire.Doc.Reporting
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;

    public class EntityEntry
    {
        private bool[] bool_0;
        private byte byte_0;
        private byte byte_1;
        public DocumentObject Current;
        private float float_0;
        public int Index;

        public EntityEntry(DocumentObject ent)
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

