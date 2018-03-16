namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using System;

    public class SDTContent : Body
    {
        internal SDTContent(Document A_0, StructureDocumentTag A_1) : base(A_0, A_1)
        {
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        protected override object CloneImpl()
        {
            return (SDTContent) base.CloneImpl();
        }

        protected override void CreateLayoutInfo()
        {
        }

        internal SDTContent method_45()
        {
            return (SDTContent) this.CloneImpl();
        }

        internal TableCell method_46()
        {
            for (DocumentObject obj2 = base.Owner; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2 is TableCell)
                {
                    return (obj2 as TableCell);
                }
            }
            return null;
        }
    }
}

