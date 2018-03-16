namespace Spire.Doc.Interface
{
    using System;
    using System.Reflection;

    public interface ITextBoxItemCollection
    {
        int Add(ITextBox textBox);

        ITextBox this[int index] { get; }
    }
}

