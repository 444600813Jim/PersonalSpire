namespace Spire.Doc.Interface
{
    using System;
    using System.Runtime.InteropServices;
    using System.Xml;

    public interface IXDLSContentReader
    {
        string GetAttributeValue(string name);
        bool ParseElementType(Type enumType, out Enum elementType);
        byte[] ReadChildBinaryElement();
        bool ReadChildElement(object value);
        object ReadChildElement(Type type);
        string ReadChildStringContent();

        IXDLSAttributeReader AttributeReader { get; }

        XmlReader InnerReader { get; }

        XmlNodeType NodeType { get; }

        string TagName { get; }
    }
}

