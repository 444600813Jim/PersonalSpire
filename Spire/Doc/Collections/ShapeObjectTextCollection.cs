namespace Spire.Doc.Collections
{
    using Spire.Doc.Fields;
    using System;
    using System.Collections.Generic;

    [CLSCompliant(false)]
    public class ShapeObjectTextCollection
    {
        private bool bool_0;
        private Dictionary<int, TextBox> dictionary_0 = new Dictionary<int, TextBox>();

        public void AddTextBox(int shapeId, TextBox textBox)
        {
            if (this.dictionary_0 == null)
            {
                this.dictionary_0 = new Dictionary<int, TextBox>();
            }
            this.dictionary_0.Add(shapeId, textBox);
        }

        public TextBox GetTextBox(int shapeId)
        {
            TextBox box = null;
            if (this.dictionary_0.ContainsKey(shapeId))
            {
                box = this.dictionary_0[shapeId];
                this.dictionary_0.Remove(shapeId);
            }
            return box;
        }
    }
}

