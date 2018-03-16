namespace Spire.Doc.Interface
{
    using System;
    using System.Drawing;

    public interface IXDLSAttributeReader
    {
        bool HasAttribute(string name);
        bool ReadBoolean(string name);
        byte ReadByte(string name);
        Color ReadColor(string name);
        DateTime ReadDateTime(string s);
        double ReadDouble(string name);
        Enum ReadEnum(string name, Type enumType);
        float ReadFloat(string name);
        int ReadInt(string name);
        short ReadShort(string name);
        string ReadString(string name);
    }
}

