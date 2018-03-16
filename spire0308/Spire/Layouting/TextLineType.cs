namespace Spire.Layouting
{
    using System;

    [Flags]
    internal enum TextLineType
    {
        FirstParagraphLine = 4,
        LastParagraphLine = 8,
        LayoutBreak = 2,
        NewLineBreak = 1,
        None = 0
    }
}

