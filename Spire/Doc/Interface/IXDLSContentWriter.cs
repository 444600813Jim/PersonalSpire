namespace Spire.Doc.Interface
{
    using System;
    using System.Xml;

    public interface IXDLSContentWriter
    {
        void WriteChildBinaryElement(string name, byte[] value);
        void WriteChildElement(string name, object value);
        void WriteChildRefElement(string name, int refToElement);
        void WriteChildStringElement(string name, string value);

        XmlWriter InnerWriter { get; }
    }
}

