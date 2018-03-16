namespace Spire.CompoundFile.Doc
{
    using System;

    public interface IDocProperty
    {
        bool Boolean { get; set; }

        System.DateTime DateTime { get; set; }

        double Double { get; set; }

        int Int32 { get; set; }

        int Integer { get; set; }

        bool IsBuiltIn { get; }

        string LinkSource { get; set; }

        bool LinkToContent { get; set; }

        string Name { get; }

        BuiltInProperty PropertyId { get; }

        string Text { get; set; }

        System.TimeSpan TimeSpan { get; set; }

        object Value { get; set; }
    }
}

