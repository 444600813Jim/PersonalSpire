namespace Spire.Doc.Documents.XML
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Globalization;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Xml;

    public class XDLSReader : IXDLSContentReader, IXDLSAttributeReader
    {
        private bool[] bool_0;
        private byte byte_0;
        private byte byte_1;
        private Class620 class620_0 = new Class620();
        private static Dictionary<Type, object> dictionary_0 = new Dictionary<Type, object>();
        private int[] int_0;
        private XmlReader xmlReader_0;

        public XDLSReader(XmlReader reader)
        {
            this.xmlReader_0 = reader;
        }

        public void Deserialize(IDocumentSerializable value)
        {
            while (this.xmlReader_0.NodeType != XmlNodeType.Element)
            {
                this.xmlReader_0.Read();
            }
            this.method_3(value);
            value.XDLSHolder.AfterDeserialization(value);
        }

        public string GetAttributeValue(string name)
        {
            return this.xmlReader_0.GetAttribute(name);
        }

        public bool HasAttribute(string name)
        {
            return (this.xmlReader_0.GetAttribute(name) != null);
        }

        private Color method_0(string A_0)
        {
            A_0 = A_0.Replace(BookmarkStart.b("ᬷ", 0x12), string.Empty);
            try
            {
                string s = A_0.Substring(0, 2);
                string str2 = A_0.Substring(2, 2);
                string str3 = A_0.Substring(4, 2);
                string str4 = A_0.Substring(6, 2);
                int alpha = int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                int red = int.Parse(str2, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                int green = int.Parse(str3, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                int blue = int.Parse(str4, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                return Color.FromArgb(alpha, red, green, blue);
            }
            catch
            {
            }
            return Color.Empty;
        }

        internal Image method_1()
        {
            return this.method_2(false);
        }

        internal Image method_2(bool A_0)
        {
            Image image = null;
            byte[] buffer = this.ReadChildBinaryElement();
            if (buffer.Length <= 0)
            {
                return image;
            }
            MemoryStream stream = new MemoryStream(buffer);
            if (A_0)
            {
                return new Metafile(stream);
            }
            return new Bitmap(stream);
        }

        private void method_3(IDocumentSerializable A_0)
        {
            int num = 8;
            if (A_0 == null)
            {
                this.xmlReader_0.Skip();
            }
            else
            {
                if (this.xmlReader_0.HasAttributes)
                {
                    if (this.xmlReader_0.MoveToAttribute(BookmarkStart.b("䜭启", num)))
                    {
                        A_0.XDLSHolder.ID = XmlConvert.ToInt32(this.xmlReader_0.GetAttribute(BookmarkStart.b("䜭启", num)));
                    }
                    A_0.ReadXmlAttributes(this);
                    this.xmlReader_0.MoveToElement();
                }
                bool flag = !this.xmlReader_0.IsEmptyElement;
                int depth = this.xmlReader_0.Depth;
                this.xmlReader_0.ReadStartElement();
                if (flag)
                {
                    while (this.xmlReader_0.Depth > depth)
                    {
                        if (this.xmlReader_0.EOF)
                        {
                            break;
                        }
                        if (this.xmlReader_0.NodeType != XmlNodeType.Element)
                        {
                            this.xmlReader_0.Read();
                        }
                        else if (!A_0.ReadXmlContent(this))
                        {
                            this.xmlReader_0.Skip();
                        }
                    }
                    if (this.xmlReader_0.NodeType == XmlNodeType.EndElement)
                    {
                        this.xmlReader_0.ReadEndElement();
                    }
                }
            }
        }

        private void method_4(IXDLSSerializableCollection A_0)
        {
            bool flag = !this.xmlReader_0.IsEmptyElement;
            int depth = this.xmlReader_0.Depth;
            this.xmlReader_0.ReadStartElement();
            if (flag)
            {
                while (this.xmlReader_0.Depth > depth)
                {
                    if (this.xmlReader_0.EOF)
                    {
                        break;
                    }
                    if (this.xmlReader_0.NodeType != XmlNodeType.Element)
                    {
                        this.xmlReader_0.Read();
                    }
                    else if (this.xmlReader_0.LocalName == A_0.TagItemName)
                    {
                        IDocumentSerializable serializable = A_0.AddNewItem(this);
                        this.method_3(serializable);
                    }
                }
                if (this.xmlReader_0.NodeType == XmlNodeType.EndElement)
                {
                    this.xmlReader_0.ReadEndElement();
                }
            }
        }

        public bool ParseElementType(Type enumType, out Enum elementType)
        {
            int num = 0x11;
            string[] names = null;
            Array values = null;
            object obj2 = null;
            if (dictionary_0.ContainsKey(enumType))
            {
                obj2 = dictionary_0[enumType];
            }
            if (obj2 == null)
            {
                names = Enum.GetNames(enumType);
                values = Enum.GetValues(enumType);
                obj2 = new object[] { names, values };
                dictionary_0.Add(enumType, obj2);
            }
            else
            {
                names = (string[]) ((object[]) obj2)[0];
                values = (Array) ((object[]) obj2)[1];
            }
            string attributeValue = this.GetAttributeValue(BookmarkStart.b("䌶䀸䬺堼", num));
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == attributeValue)
                {
                    elementType = (Enum) values.GetValue(i);
                    return true;
                }
            }
            elementType = (Enum) values.GetValue(0);
            return false;
        }

        public bool ReadBoolean(string name)
        {
            return XmlConvert.ToBoolean(this.xmlReader_0.GetAttribute(name));
        }

        public byte ReadByte(string name)
        {
            return XmlConvert.ToByte(this.xmlReader_0.GetAttribute(name));
        }

        public byte[] ReadChildBinaryElement()
        {
            XmlReader reader = this.xmlReader_0;
            int length = 0;
            byte[] buffer = new byte[0];
            byte[] buffer2 = new byte[0x3e8];
        Label_0030:
            length = reader.ReadElementContentAsBase64(buffer2, 0, buffer2.Length);
            byte[] array = new byte[buffer.Length + length];
            buffer.CopyTo(array, 0);
            Array.Copy(buffer2, 0, array, buffer.Length, length);
            buffer = array;
            if (length >= buffer2.Length)
            {
                buffer2 = new byte[buffer.Length * 2];
                if (reader.EOF)
                {
                    return buffer;
                }
                goto Label_0030;
            }
            return buffer;
        }

        public bool ReadChildElement(object value)
        {
            IDocumentSerializable serializable = value as IDocumentSerializable;
            if (serializable != null)
            {
                this.method_3(serializable);
            }
            else
            {
                IXDLSSerializableCollection serializables = value as IXDLSSerializableCollection;
                if (serializables == null)
                {
                    return false;
                }
                this.method_4(serializables);
            }
            return true;
        }

        public object ReadChildElement(Type type)
        {
            return this.class620_0.method_1(this.xmlReader_0, type);
        }

        public string ReadChildStringContent()
        {
            return this.xmlReader_0.ReadInnerXml();
        }

        public Color ReadColor(string name)
        {
            int num = 15;
            if (name == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嬴嘶吸帺", num));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException(BookmarkStart.b("嬴嘶吸帺ᴼሾ慀あㅄ㕆⁈╊⩌潎㉐㉒㭔睖㝘㑚⥜罞͠٢䕤ɦѨ᭪ᥬ᙮", num));
            }
            string attribute = this.xmlReader_0.GetAttribute(name);
            return this.method_0(attribute);
        }

        public DateTime ReadDateTime(string name)
        {
            int num = 10;
            if (name == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("帯匱夳匵", num));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException(BookmarkStart.b("帯匱夳匵ᠷ᜹᰻䴽㐿ぁⵃ⡅⽇橉⽋⽍㹏牑㩓㥕ⱗ穙㹛㭝䁟ݡॣᙥᱧ፩", num));
            }
            return XmlConvert.ToDateTime(this.xmlReader_0.GetAttribute(name), XmlDateTimeSerializationMode.Utc);
        }

        public double ReadDouble(string name)
        {
            return XmlConvert.ToDouble(this.xmlReader_0.GetAttribute(name));
        }

        public Enum ReadEnum(string name, Type enumType)
        {
            string attribute = this.xmlReader_0.GetAttribute(name);
            return (Enum) Enum.Parse(enumType, attribute);
        }

        public float ReadFloat(string name)
        {
            return XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(name));
        }

        public int ReadInt(string name)
        {
            return XmlConvert.ToInt32(this.xmlReader_0.GetAttribute(name));
        }

        public short ReadShort(string name)
        {
            return XmlConvert.ToInt16(this.xmlReader_0.GetAttribute(name));
        }

        public string ReadString(string name)
        {
            return this.xmlReader_0.GetAttribute(name);
        }

        public IXDLSAttributeReader AttributeReader
        {
            get
            {
                return this;
            }
        }

        public XmlReader InnerReader
        {
            get
            {
                return this.xmlReader_0;
            }
        }

        public XmlNodeType NodeType
        {
            get
            {
                return this.xmlReader_0.NodeType;
            }
        }

        public string TagName
        {
            get
            {
                return this.xmlReader_0.LocalName;
            }
        }
    }
}

