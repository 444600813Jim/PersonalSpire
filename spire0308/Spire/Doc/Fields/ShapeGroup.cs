namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Layouting;
    using System;

    public class ShapeGroup : ShapeObject
    {
        public ShapeGroup(Document doc) : base(doc)
        {
            base.SetShapeType(ShapeType.Group);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_37(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_36(this);
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_5(false);
            base.interface23_0.imethod_3(false);
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.ShapeGroup;
            }
        }

        internal Spire.Doc.EditAs EditAs
        {
            get
            {
                return (Spire.Doc.EditAs) base.GetShapeAttribute(0x500);
            }
            set
            {
                base.SetShapeAttribute(0x500, value);
            }
        }
    }
}

