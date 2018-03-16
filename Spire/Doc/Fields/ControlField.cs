namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.IO;

    public class ControlField : Field
    {
        private bool bool_35;
        private float float_2;
        private float[] float_3;
        private float float_4;
        private int int_6;
        private long[] long_4;

        internal ControlField(IDocument A_0) : base(A_0)
        {
            base.m_paraItemType = ParagraphItemType.ControlField;
        }

        protected override object CloneImpl()
        {
            return (ControlField) base.CloneImpl();
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            base.CloneRelationsTo(doc, nextOwner);
            if (doc.ObjectPool == null)
            {
                doc.ObjectPool = new byte[base.m_doc.ObjectPool.Length];
                base.m_doc.ObjectPool.CopyTo(doc.ObjectPool, 0);
            }
            else
            {
                byte[] objectPool = doc.ObjectPool;
                Class363.smethod_0(new MemoryStream(base.m_doc.ObjectPool), this.int_6, new MemoryStream(doc.ObjectPool), out objectPool);
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.ControlField;
            }
        }

        internal int StoragePicLocation
        {
            get
            {
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
            }
        }
    }
}

