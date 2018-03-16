namespace Spire.Doc.Interface
{
    using Spire.Doc.Documents;
    using System;

    public interface IStyleHolder
    {
        void ApplyStyle(BuiltinStyle builtinStyle);
        void ApplyStyle(string styleName);

        string StyleName { get; }
    }
}

