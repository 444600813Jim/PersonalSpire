namespace Spire.Doc.Documents.XML
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class XDLSHolder
    {
        private bool bool_0 = true;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private byte byte_0;
        private byte[] byte_1;
        private Dictionary<string, object> dictionary_0;
        private Dictionary<string, object> dictionary_1;
        private float float_0;
        private int int_0 = -1;
        private int[] int_1;

        public void AddElement(string tagName, object value)
        {
            if (this.dictionary_0 == null)
            {
                this.dictionary_0 = new Dictionary<string, object>();
            }
            this.dictionary_0[tagName] = value;
        }

        public void AddRefElement(string tagName, object value)
        {
            if (this.dictionary_1 == null)
            {
                this.dictionary_1 = new Dictionary<string, object>();
            }
            this.dictionary_1[tagName] = value;
        }

        public void AfterDeserialization(IDocumentSerializable owner)
        {
            if (this.dictionary_0 != null)
            {
                foreach (string str in this.dictionary_0.Keys)
                {
                    IDocumentSerializable serializable2 = this.dictionary_0[str] as IDocumentSerializable;
                    if (serializable2 != null)
                    {
                        serializable2.XDLSHolder.AfterDeserialization(serializable2);
                    }
                    else
                    {
                        IXDLSSerializableCollection serializables = this.dictionary_0[str] as IXDLSSerializableCollection;
                        if (serializables != null)
                        {
                            foreach (IDocumentSerializable serializable in serializables)
                            {
                                if (serializable != null)
                                {
                                    serializable.XDLSHolder.AfterDeserialization(serializable);
                                }
                            }
                        }
                    }
                }
            }
            if (this.dictionary_1 != null)
            {
                foreach (string str2 in this.dictionary_1.Keys)
                {
                    int num = -1;
                    if ((this.dictionary_1[str2] != null) && (this.dictionary_1[str2] is int))
                    {
                        num = (int) this.dictionary_1[str2];
                    }
                    owner.RestoreReference(str2, num);
                }
            }
            this.method_0();
        }

        public void BeforeSerialization()
        {
            if (this.dictionary_0 != null)
            {
                foreach (string str in this.dictionary_0.Keys)
                {
                    IDocumentSerializable serializable = this.dictionary_0[str] as IDocumentSerializable;
                    if (serializable != null)
                    {
                        serializable.XDLSHolder.Cleared = true;
                        serializable.XDLSHolder.BeforeSerialization();
                    }
                    else
                    {
                        IXDLSSerializableCollection serializables = this.dictionary_0[str] as IXDLSSerializableCollection;
                        if (serializables != null)
                        {
                            int num = 0;
                            foreach (IDocumentSerializable serializable2 in serializables)
                            {
                                if (serializable2 != null)
                                {
                                    serializable2.XDLSHolder.Cleared = true;
                                    serializable2.XDLSHolder.ID = num;
                                    serializable2.XDLSHolder.BeforeSerialization();
                                    num++;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void method_0()
        {
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
            }
            if (this.dictionary_1 != null)
            {
                this.dictionary_1.Clear();
            }
            this.bool_0 = true;
        }

        public bool ReadHolder(IXDLSContentReader reader)
        {
            int num = 9;
            if (reader.NodeType == XmlNodeType.Element)
            {
                string tagName = reader.TagName;
                if ((this.dictionary_0 != null) && this.dictionary_0.ContainsKey(tagName))
                {
                    object obj2 = this.dictionary_0[tagName];
                    if (obj2 != null)
                    {
                        IXDLSFactory factory = obj2 as IXDLSFactory;
                        if (factory != null)
                        {
                            obj2 = factory.Create(reader);
                            this.dictionary_0[tagName] = obj2;
                        }
                        return reader.ReadChildElement(obj2);
                    }
                }
                if ((this.dictionary_1 != null) && this.dictionary_1.ContainsKey(tagName))
                {
                    string attributeValue = reader.GetAttributeValue(BookmarkStart.b("崮吰唲", num));
                    if (attributeValue == null)
                    {
                        this.dictionary_1[reader.TagName] = -1;
                    }
                    else
                    {
                        this.dictionary_1[reader.TagName] = XmlConvert.ToInt32(attributeValue);
                    }
                    return false;
                }
            }
            return false;
        }

        public void WriteHolder(IXDLSContentWriter writer)
        {
            if (this.dictionary_0 != null)
            {
                foreach (string str in this.dictionary_0.Keys)
                {
                    writer.WriteChildElement(str, this.dictionary_0[str]);
                }
            }
            if (this.dictionary_1 != null)
            {
                foreach (string str2 in this.dictionary_1.Keys)
                {
                    IDocumentSerializable serializable = this.dictionary_1[str2] as IDocumentSerializable;
                    if (serializable != null)
                    {
                        writer.WriteChildRefElement(str2, serializable.XDLSHolder.ID);
                    }
                }
            }
        }

        public bool Cleared
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                if (value != this.bool_0)
                {
                    if (value)
                    {
                        this.method_0();
                    }
                    else
                    {
                        this.bool_0 = false;
                    }
                }
            }
        }

        public bool EnableID
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        public int ID
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        public bool SkipMe
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }
    }
}

