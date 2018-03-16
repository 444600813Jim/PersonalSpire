namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using Spire.Doc.Fields.Shape;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class ShapeItemCollection : DocumentObjectCollection
    {
        private long long_4;
        private static readonly Type[] type_0 = new Type[] { typeof(ShapeBase) };

        internal ShapeItemCollection(Document A_0, ShapeBase A_1) : base(A_0, A_1)
        {
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            string str2;
            int num = 10;
            if (((str2 = reader.GetAttributeValue(BookmarkStart.b("䐯䬱䐳匵", 10))) != null) && (str2 == BookmarkStart.b("䌯娱唳䘵崷", num)))
            {
                return new ShapeObject(base.Document);
            }
            return null;
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䘴弶堸䬺堼", 15);
        }

        internal ShapeBase this[int A_0]
        {
            get
            {
                return (ShapeBase) base[A_0];
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

