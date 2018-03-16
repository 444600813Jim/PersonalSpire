namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;

    [CLSCompliant(false)]
    public class GroupedShapeCollection
    {
        private Dictionary<int, IDocumentObject> dictionary_0 = new Dictionary<int, IDocumentObject>();
        private int int_0;

        public GroupedShapeCollection(Document doc)
        {
        }

        public void AddDocObject(int shapeId, IDocumentObject shapeGroup)
        {
            if (this.dictionary_0 == null)
            {
                this.dictionary_0 = new Dictionary<int, IDocumentObject>();
            }
            this.dictionary_0.Add(shapeId, shapeGroup);
        }

        public IDocumentObject GetDocObject(int shapeId)
        {
            IDocumentObject obj2 = null;
            if (this.dictionary_0.ContainsKey(shapeId))
            {
                obj2 = this.dictionary_0[shapeId];
                this.dictionary_0.Remove(shapeId);
            }
            return obj2;
        }
    }
}

