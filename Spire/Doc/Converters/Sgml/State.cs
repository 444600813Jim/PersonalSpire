namespace Spire.Doc.Converters.Sgml
{
    using System;

    internal enum State
    {
        Initial,
        Markup,
        EndTag,
        Attr,
        AttrValue,
        Text,
        PartialTag,
        AutoClose,
        CData,
        PartialText,
        PseudoStartTag,
        Eof
    }
}

