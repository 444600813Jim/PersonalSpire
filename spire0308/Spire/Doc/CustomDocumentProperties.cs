namespace Spire.Doc
{
    using Spire.CompoundFile.Doc;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Xml;

    public class CustomDocumentProperties : DocumentSerializable
    {
        private bool bool_0;
        internal Dictionary<string, DocumentProperty> dictionary_0;
        private Dictionary<string, string> dictionary_1;
        private float[] float_0;
        private int[] int_2;
        private long[] long_2;
        internal const string string_3 = "property";
        internal const string string_4 = "name";
        internal const string string_5 = "pid";
        internal const string string_6 = "fmtid";

        internal CustomDocumentProperties() : this(0)
        {
        }

        internal CustomDocumentProperties(int A_0) : base(null, null)
        {
            this.dictionary_0 = new Dictionary<string, DocumentProperty>(A_0);
        }

        public DocumentProperty Add(string name, object value)
        {
            DocumentProperty property = new DocumentProperty(name, value, DocumentProperty.smethod_0(value));
            this.dictionary_0.Add(name, property);
            return property;
        }

        public CustomDocumentProperties Clone()
        {
            CustomDocumentProperties properties = new CustomDocumentProperties(this.dictionary_0.Count);
            foreach (string str in this.dictionary_0.Keys)
            {
                properties.dictionary_0.Add(str, this.dictionary_0[str].Clone());
            }
            return properties;
        }

        internal void method_5()
        {
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
            if (this.dictionary_1 != null)
            {
                this.dictionary_1.Clear();
                this.dictionary_1 = null;
            }
        }

        internal bool method_6(string A_0)
        {
            A_0 = A_0.Trim().Trim(new char[] { '\x0018' }).Trim().ToLower();
            return this.CustomKeyList.ContainsKey(A_0);
        }

        internal DocumentProperty method_7(string A_0)
        {
            A_0 = A_0.Trim().Trim(new char[] { '\x0018' }).Trim().ToLower();
            string str = this.CustomKeyList[A_0];
            return this.CustomHash[str];
        }

        internal void method_8(string A_0, DocumentProperty A_1)
        {
            A_0 = A_0.Trim().Trim(new char[] { '\x0018' }).Trim().ToLower();
            string str = this.CustomKeyList[A_0];
            this.CustomHash[str] = A_1;
        }

        private void method_9(XDLSReader A_0)
        {
            int num = 0x11;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䔶尸娺夼娾㍀", num));
            }
            if (A_0.InnerReader.LocalName == BookmarkStart.b("䜶䬸吺䴼娾㍀㝂㱄", num))
            {
                string str4 = A_0.ReadString(BookmarkStart.b("挶䀸䬺堼", num));
                string strName = A_0.ReadString(BookmarkStart.b("礶堸嘺堼", num));
                object obj2 = null;
                string key = str4;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_3 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                        dictionary1.Add(BookmarkStart.b("唶嘸吺儼", num), 0);
                        dictionary1.Add(BookmarkStart.b("䐶䴸䤺吼儾♀", num), 1);
                        dictionary1.Add(BookmarkStart.b("猶堸伺堼款⡀⹂⁄", num), 2);
                        dictionary1.Add(BookmarkStart.b("帶圸伺", num), 3);
                        dictionary1.Add(BookmarkStart.b("匶嘸为弼匾⑀", num), 4);
                        dictionary1.Add(BookmarkStart.b("嘶䬸䤺尼䘾", num), 5);
                        dictionary1.Add(BookmarkStart.b("吶唸刺䴼", num), 6);
                        Class1160.dictionary_3 = dictionary1;
                    }
                    if (Class1160.dictionary_3.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                obj2 = A_0.ReadBoolean(BookmarkStart.b("愶堸场䠼娾", num));
                                break;

                            case 1:
                                obj2 = A_0.ReadString(BookmarkStart.b("愶堸场䠼娾", num));
                                break;

                            case 2:
                                obj2 = A_0.ReadDateTime(BookmarkStart.b("愶堸场䠼娾", num));
                                break;

                            case 3:
                                obj2 = A_0.ReadInt(BookmarkStart.b("愶堸场䠼娾", num));
                                break;

                            case 4:
                                obj2 = A_0.ReadDouble(BookmarkStart.b("愶堸场䠼娾", num));
                                break;

                            case 5:
                                if (!A_0.InnerReader.IsEmptyElement)
                                {
                                    A_0.InnerReader.ReadStartElement();
                                    while (A_0.NodeType != XmlNodeType.Element)
                                    {
                                        A_0.InnerReader.Read();
                                    }
                                    obj2 = A_0.ReadChildBinaryElement();
                                }
                                break;

                            case 6:
                            {
                                string str = A_0.ReadString(BookmarkStart.b("愶堸场䠼娾", num));
                                Class875 class2 = new Class875();
                                class2.method_1(str);
                                obj2 = class2;
                                break;
                            }
                        }
                    }
                }
                DocumentProperty property = new DocumentProperty(strName, obj2);
                this.dictionary_0.Add(strName, property);
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            this.method_9(reader as XDLSReader);
            return flag;
        }

        public void Remove(string name)
        {
            this.CustomHash.Remove(name);
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 15;
            base.WriteXmlContent(writer);
            IXDLSAttributeWriter writer2 = writer as IXDLSAttributeWriter;
            XmlWriter writer3 = (writer as Class669).Spire.Doc.Interface.IXDLSContentWriter.get_InnerWriter();
            if ((this.dictionary_0 != null) && (this.dictionary_0.Count > 0))
            {
                foreach (string str in this.dictionary_0.Keys)
                {
                    DocumentProperty property = this.dictionary_0[str];
                    writer3.WriteStartElement(BookmarkStart.b("䔴䔶嘸䬺堼䴾㕀㩂", num));
                    writer3.WriteAttributeString(BookmarkStart.b("笴嘶吸帺", num), str);
                    PropertyType propertyType = property.PropertyType;
                    if (propertyType <= PropertyType.Bool)
                    {
                        switch (propertyType)
                        {
                            case PropertyType.Double:
                                writer3.WriteAttributeString(BookmarkStart.b("愴丶䤸帺", num), BookmarkStart.b("儴堶䰸夺儼娾", num));
                                writer2.WriteValue(BookmarkStart.b("挴嘶唸为堼", num), property.Double);
                                break;

                            case PropertyType.Bool:
                                writer3.WriteAttributeString(BookmarkStart.b("愴丶䤸帺", num), BookmarkStart.b("圴堶嘸场", num));
                                writer2.WriteValue(BookmarkStart.b("挴嘶唸为堼", num), property.Boolean);
                                break;
                        }
                    }
                    else
                    {
                        switch (propertyType)
                        {
                            case PropertyType.Int:
                                writer3.WriteAttributeString(BookmarkStart.b("愴丶䤸帺", num), BookmarkStart.b("尴夶䴸", num));
                                writer2.WriteValue(BookmarkStart.b("挴嘶唸为堼", num), property.Integer);
                                goto Label_01D4;

                            case PropertyType.String:
                                writer3.WriteAttributeString(BookmarkStart.b("愴丶䤸帺", num), BookmarkStart.b("䘴䌶䬸刺匼堾", num));
                                writer2.WriteValue(BookmarkStart.b("挴嘶唸为堼", num), property.ToString());
                                goto Label_01D4;
                        }
                        if (propertyType == PropertyType.DateTime)
                        {
                            writer3.WriteAttributeString(BookmarkStart.b("愴丶䤸帺", num), BookmarkStart.b("焴嘶䴸帺椼嘾ⱀ♂", num));
                            writer2.WriteValue(BookmarkStart.b("挴嘶唸为堼", num), property.DateTime);
                        }
                    }
                Label_01D4:
                    writer3.WriteEndElement();
                }
            }
        }

        public int Count
        {
            get
            {
                return this.dictionary_0.Count;
            }
        }

        public Dictionary<string, DocumentProperty> CustomHash
        {
            get
            {
                return this.dictionary_0;
            }
        }

        private Dictionary<string, string> CustomKeyList
        {
            get
            {
                if ((this.dictionary_1 == null) || (((this.dictionary_1 != null) && (this.dictionary_0 != null)) && (this.dictionary_0.Count != this.dictionary_1.Count)))
                {
                    if (this.dictionary_1 == null)
                    {
                        this.dictionary_1 = new Dictionary<string, string>();
                    }
                    else
                    {
                        this.dictionary_1.Clear();
                    }
                    if (this.dictionary_0 != null)
                    {
                        foreach (string str in this.dictionary_0.Keys)
                        {
                            string key = str.Trim().Trim(new char[] { '\x0018' }).Trim().ToLower();
                            if (this.dictionary_1.ContainsKey(key))
                            {
                                this.dictionary_1[key] = str;
                            }
                            else
                            {
                                this.dictionary_1.Add(key, str);
                            }
                        }
                    }
                }
                return this.dictionary_1;
            }
        }

        public DocumentProperty this[string name]
        {
            get
            {
                if (this.dictionary_0.ContainsKey(name))
                {
                    return this.dictionary_0[name];
                }
                return null;
            }
        }

        public DocumentProperty this[int index]
        {
            get
            {
                DocumentProperty property;
                int num = 0;
                using (Dictionary<string, DocumentProperty>.KeyCollection.Enumerator enumerator = this.dictionary_0.Keys.GetEnumerator())
                {
                    string current;
                    while (enumerator.MoveNext())
                    {
                        current = enumerator.Current;
                        if (num == index)
                        {
                            goto Label_0033;
                        }
                        num++;
                    }
                    return null;
                Label_0033:
                    property = this.dictionary_0[current];
                }
                return property;
            }
        }
    }
}

