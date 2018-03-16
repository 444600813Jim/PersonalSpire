namespace Spire.Doc.Fields
{
    using Spire.CompoundFile.Doc.Native;
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Layouting;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Text;

    public class DocOleObject : ShapeObject, Interface2, Interface49
    {
        private bool bool_11;
        private byte[] byte_5;
        internal Class1116 class1116_0;
        private Class6 class6_0;
        internal Dictionary<string, Guid> dictionary_0;
        internal DocPicture docPicture_1;
        private Spire.Doc.Fields.Field field_1;
        private const int int_8 = 6;
        internal OleLinkType oleLinkType_0;
        private Spire.Doc.Documents.OleObjectType oleObjectType_0;
        private static Random random_0;
        private Stream stream_0;
        internal Stream stream_1;
        private string[] string_10;
        internal static readonly string string_11 = ('\x0001' + BookmarkStart.b("瘸场堼", 0x13));
        internal static readonly string string_12 = ('\x0003' + BookmarkStart.b("瘸夺圼瘾⽀╂⩄", 0x13));
        private string string_13;
        private string string_14;
        private string string_15;
        private string string_16;
        internal const string string_8 = "ObjectPool";
        internal static readonly string string_9 = ('\x0001' + BookmarkStart.b("稸吺值伾เ⅂⽄", 0x13));

        public DocOleObject(Document doc) : base(doc)
        {
            this.string_15 = string.Empty;
            this.string_16 = string.Empty;
            this.dictionary_0 = new Dictionary<string, Guid>();
            base.SetShapeType(ShapeType.OleObject);
            this.string_13 = string.Empty;
            this.string_14 = string.Empty;
            base.OleFormat = this;
        }

        internal DocOleObject(Document A_0, ShapeObject A_1) : base(A_0)
        {
            this.string_15 = string.Empty;
            this.string_16 = string.Empty;
            this.dictionary_0 = new Dictionary<string, Guid>();
            base.ShapePr = A_1.ShapePr;
            this.string_13 = string.Empty;
            this.string_14 = string.Empty;
            base.OleFormat = this;
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            string key = BookmarkStart.b("氲", 13) + this.Interface49.get_OleStorageName();
            if (!base.Document.DocOleObjects.ContainsKey(key))
            {
                base.Document.DocOleObjects.Add(key, this);
            }
            else
            {
                base.Document.DocOleObjects[key] = this;
            }
        }

        protected override object CloneImpl()
        {
            DocOleObject obj2 = (DocOleObject) base.CloneImpl();
            if (this.Interface49.get_OlePicture() != null)
            {
                obj2.SetOlePicture(this.Interface49.get_OlePicture().Clone() as DocPicture);
                obj2.Interface49.get_OlePicture().method_0(obj2);
            }
            if (this.Interface49.get_Container() != null)
            {
                this.stream_0.Position = 0L;
                byte[] buffer = new byte[this.stream_0.Length];
                this.stream_0.Read(buffer, 0, buffer.Length);
                MemoryStream stream = new MemoryStream(buffer);
                obj2.method_80(stream);
                this.stream_0.Position = 0L;
            }
            obj2.oleObjectType_0 = this.OleObjectType;
            if (this.field_1 != null)
            {
                obj2.Field = this.field_1.Clone() as Spire.Doc.Fields.Field;
            }
            if (this.class6_0 != null)
            {
                obj2.OleXmlItem = this.class6_0.Clone() as Class6;
            }
            obj2.bool_4 = true;
            obj2.OleFormat = obj2;
            return obj2;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            base.CloneRelationsTo(doc, nextOwner);
            base.bool_4 = false;
        }

        internal override void Close()
        {
            this.byte_5 = null;
            this.field_1 = null;
            this.class6_0 = null;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_3(true);
            if (this.Interface49.get_OlePicture() != null)
            {
                switch (this.Interface49.get_OlePicture().TextWrappingStyle)
                {
                    case TextWrappingStyle.Inline:
                        base.interface23_0.imethod_15(true);
                        return;

                    case TextWrappingStyle.InFrontOfText:
                    case TextWrappingStyle.Behind:
                        base.interface23_0.imethod_21(true);
                        base.interface23_0.imethod_17(false);
                        return;
                }
                base.interface23_0.imethod_19(true);
                base.interface23_0.imethod_17(false);
            }
        }

        internal override void Detach()
        {
            string key = BookmarkStart.b("眧", 2) + this.Interface49.get_OleStorageName();
            if (base.Document.DocOleObjects.ContainsKey(key))
            {
                base.Document.DocOleObjects.Remove(key);
            }
        }

        internal void method_100(byte[] A_0, string A_1)
        {
            int num = 11;
            A_1 = (A_1 == null) ? string.Empty : A_1;
            this.string_13 = NextOleObjId.ToString();
            byte[] buffer = this.method_89(BookmarkStart.b("渰", num) + this.string_13);
            this.class1116_0 = new Class1116();
            this.class1116_0.method_29(this.string_15, this.string_16);
            base.m_doc.ObjectPool = this.class1116_0.method_12(buffer, A_0, A_1, this);
            this.OleObjectType = this.class1116_0.method_1();
            if (!this.Interface49.get_DisplayAsIcon())
            {
                this.method_94();
            }
        }

        internal void method_101(string A_0)
        {
            this.string_13 = NextOleObjId.ToString();
            byte[] buffer = this.method_89(BookmarkStart.b("焭", 8) + this.string_13);
            this.class1116_0 = new Class1116();
            byte[] buffer2 = this.class1116_0.method_11(buffer, A_0, BookmarkStart.b("焭", 8) + this.string_13, this.oleLinkType_0, this.oleObjectType_0);
            if (!this.Interface49.get_DisplayAsIcon())
            {
                buffer2 = this.method_93(buffer2);
            }
            this.stream_0 = this.method_77(buffer2);
        }

        internal void method_102(byte[] A_0, string A_1)
        {
            int num = 3;
            A_1 = (A_1 == null) ? string.Empty : A_1;
            A_1 = (!string.IsNullOrEmpty(A_1) || string.IsNullOrEmpty(this.string_16)) ? A_1 : this.string_16;
            this.string_13 = NextOleObjId.ToString();
            byte[] buffer = this.method_90(BookmarkStart.b("瘨", num) + this.string_13, null);
            this.class1116_0 = new Class1116();
            this.class1116_0.method_29(this.string_15, this.string_16);
            byte[] buffer2 = this.class1116_0.method_12(buffer, A_0, A_1, this);
            this.OleObjectType = this.class1116_0.method_1();
            if (!this.Interface49.get_DisplayAsIcon())
            {
                buffer2 = this.method_93(buffer2);
            }
            this.stream_0 = this.method_77(buffer2);
        }

        internal void method_103()
        {
            this.method_102(this.Interface49.get_NativeData(), null);
        }

        internal void method_104(string A_0)
        {
        }

        internal void method_105(string A_0, string A_1)
        {
            this.string_15 = A_0;
            this.string_16 = A_1;
        }

        internal void method_106(string A_0)
        {
            if (!string.IsNullOrEmpty(A_0))
            {
                byte[] buffer = this.method_110(A_0);
                this.method_107(buffer);
            }
        }

        internal void method_107(byte[] A_0)
        {
            if ((A_0 != null) && ((A_0 == null) || (A_0.Length != 0)))
            {
                using (MemoryStream stream = new MemoryStream(A_0))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        reader.ReadInt32();
                        if (reader.ReadInt32() != 2)
                        {
                            throw new NotSupportedException();
                        }
                        this.method_108(reader);
                        this.method_108(reader);
                        this.method_108(reader);
                        int count = reader.ReadInt32();
                        byte[] buffer = reader.ReadBytes(count);
                        this.stream_1 = new MemoryStream(buffer);
                        this.method_88();
                        this.method_100(this.Interface49.get_NativeData(), (this.OleObjectType == Spire.Doc.Documents.OleObjectType.Package) ? this.Interface49.get_PackageFileName() : string.Empty);
                    }
                }
            }
        }

        private string method_108(BinaryReader A_0)
        {
            int count = A_0.ReadInt32();
            if (count == 0)
            {
                return string.Empty;
            }
            byte[] bytes = A_0.ReadBytes(count);
            return Encoding.ASCII.GetString(bytes, 0, count - 1);
        }

        internal byte[] method_109()
        {
            if (this.Interface49.get_NativeData() == null)
            {
                return null;
            }
            int num = 0;
            int num2 = 0x501;
            int num3 = (this.Interface49.get_LinkType() == OleLinkType.Embed) ? 2 : 1;
            string s = this.Interface49.get_ObjectType();
            string str2 = string.Empty;
            string str3 = string.Empty;
            byte[] bytes = BitConverter.GetBytes(num2);
            num += 4;
            byte[] sourceArray = BitConverter.GetBytes(num3);
            num += 4;
            ASCIIEncoding encoding = new ASCIIEncoding();
            int length = s.Length;
            length = (length > 0) ? (length + 1) : length;
            byte[] buffer3 = BitConverter.GetBytes(length);
            num += buffer3.Length;
            byte[] buffer4 = encoding.GetBytes(s);
            num += (length > 0) ? (buffer4.Length + 1) : buffer4.Length;
            int num5 = str2.Length;
            num5 = (num5 > 0) ? (num5 + 1) : num5;
            byte[] buffer5 = BitConverter.GetBytes(num5);
            num += buffer5.Length;
            byte[] buffer6 = encoding.GetBytes(str2);
            num += (num5 > 0) ? (buffer6.Length + 1) : buffer6.Length;
            int num6 = str3.Length;
            num6 = (num6 > 0) ? (num6 + 1) : num5;
            byte[] buffer7 = BitConverter.GetBytes(num6);
            num += buffer7.Length;
            byte[] buffer8 = encoding.GetBytes(str3);
            num += (num6 > 0) ? (buffer8.Length + 1) : buffer8.Length;
            byte[] buffer9 = this.method_97(this.Interface49.get_NativeData());
            int num7 = buffer9.Length;
            byte[] buffer10 = BitConverter.GetBytes(num7);
            num += buffer10.Length;
            num += num7;
            byte[] buffer11 = BitConverter.GetBytes(0x501);
            num += buffer11.Length;
            byte[] buffer12 = BitConverter.GetBytes(0);
            num += buffer12.Length;
            byte[] destinationArray = new byte[num];
            int destinationIndex = 0;
            Array.Copy(bytes, 0, destinationArray, 0, bytes.Length);
            destinationIndex = 0 + bytes.Length;
            Array.Copy(sourceArray, 0, destinationArray, destinationIndex, sourceArray.Length);
            destinationIndex += sourceArray.Length;
            Array.Copy(buffer3, 0, destinationArray, destinationIndex, buffer3.Length);
            destinationIndex += buffer3.Length;
            Array.Copy(buffer4, 0, destinationArray, destinationIndex, buffer4.Length);
            destinationIndex += (buffer4.Length > 0) ? (buffer4.Length + 1) : buffer4.Length;
            Array.Copy(buffer5, 0, destinationArray, destinationIndex, buffer5.Length);
            destinationIndex += buffer5.Length;
            Array.Copy(buffer6, 0, destinationArray, destinationIndex, buffer6.Length);
            destinationIndex += (buffer6.Length > 0) ? (buffer6.Length + 1) : buffer6.Length;
            Array.Copy(buffer7, 0, destinationArray, destinationIndex, buffer7.Length);
            destinationIndex += buffer7.Length;
            Array.Copy(buffer8, 0, destinationArray, destinationIndex, buffer8.Length);
            destinationIndex += (buffer8.Length > 0) ? (buffer8.Length + 1) : buffer8.Length;
            Array.Copy(buffer10, 0, destinationArray, destinationIndex, buffer10.Length);
            destinationIndex += buffer10.Length;
            Array.Copy(buffer9, 0, destinationArray, destinationIndex, buffer9.Length);
            destinationIndex += buffer9.Length;
            Array.Copy(buffer11, 0, destinationArray, destinationIndex, buffer11.Length);
            destinationIndex += buffer11.Length;
            Array.Copy(buffer12, 0, destinationArray, destinationIndex, buffer12.Length);
            destinationIndex += buffer12.Length;
            return destinationArray;
        }

        internal byte[] method_110(string A_0)
        {
            A_0 = A_0.Replace(BookmarkStart.b("᜶", 0x11), string.Empty).Replace(BookmarkStart.b("㨶", 0x11), string.Empty).Replace(BookmarkStart.b("㴶", 0x11), string.Empty);
            if (string.IsNullOrEmpty(A_0))
            {
                return null;
            }
            List<byte> list = new List<byte>();
            int num = 0;
            int length = A_0.Length;
            while (num < length)
            {
                list.Add((byte) this.method_111(A_0[num], A_0[num + 1]));
                num += 2;
            }
            return list.ToArray();
        }

        private char method_111(char A_0, char A_1)
        {
            return (char) byte.Parse(A_0.ToString() + A_1, NumberStyles.HexNumber);
        }

        private Stream method_76()
        {
            return this.method_77(base.m_doc.ObjectPool);
        }

        private Stream method_77(byte[] A_0)
        {
            int num = 10;
            if ((A_0 == null) || (A_0.Length == 0))
            {
                return null;
            }
            MemoryStream stream = null;
            Stream12 stream2 = null;
            Stream12 stream3 = null;
            Stream12 stream4 = null;
            Stream12 stream5 = null;
            MemoryStream stream6 = null;
            try
            {
                stream = new MemoryStream(A_0);
                stream2 = new Stream12(stream);
                stream3 = stream2.method_11(BookmarkStart.b("缯倱帳匵嬷丹氻儽⼿⹁", num));
                stream4 = stream3.method_11(BookmarkStart.b("漯", num) + this.Interface49.get_OleStorageName().ToString());
                stream5 = Stream12.smethod_2();
                Stream12.smethod_0(stream4, stream5);
                stream6 = new MemoryStream();
                stream5.method_17(stream6);
                stream6.Position = 0L;
            }
            catch (Exception)
            {
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }
                if (stream2 != null)
                {
                    stream2.Close();
                    stream3.Dispose();
                }
                if (stream3 != null)
                {
                    stream3.Close();
                    stream3.Dispose();
                }
                if (stream4 != null)
                {
                    stream4.Close();
                    stream4.Dispose();
                }
                if (stream5 != null)
                {
                    stream5.Close();
                    stream5.Dispose();
                }
            }
            return stream6;
        }

        internal void method_78()
        {
            if (this.field_1 != null)
            {
                string str = this.field_1.Value;
                char[] separator = new char[] { '"' };
                string[] strArray = str.Split(separator);
                if (this.oleObjectType_0 == Spire.Doc.Documents.OleObjectType.Undefined)
                {
                    this.Interface49.set_ObjectType(strArray[0].Trim());
                }
                if (string.IsNullOrEmpty(this.string_14) && (strArray.Length > 1))
                {
                    this.SourceFullName = this.string_14 = strArray[1];
                }
            }
        }

        internal void method_79(Stream A_0)
        {
            this.stream_0 = A_0;
            this.stream_0.Position = 0L;
        }

        internal void method_80(Stream A_0)
        {
            this.stream_0 = A_0;
            byte[] buffer = new byte[A_0.Length];
            A_0.Position = 0L;
            A_0.Read(buffer, 0, buffer.Length);
            this.class1116_0 = new Class1116(buffer, BookmarkStart.b("礥", 0) + this.Interface49.get_OleStorageName());
            this.stream_0.Position = 0L;
        }

        internal void method_81(Class1089 A_0)
        {
            Class1132 class2 = new Class1132(A_0);
            MemoryStream stream = new MemoryStream();
            class2.method_5(stream);
            byte[] buffer = new byte[stream.Length];
            stream.Position = 0L;
            stream.Read(buffer, 0, buffer.Length);
            this.class1116_0 = new Class1116(buffer, BookmarkStart.b("礥", 0) + this.Interface49.get_OleStorageName());
            Class1089 class3 = new Class1089();
            class3.method_3(BookmarkStart.b("礥", 0) + this.Interface49.get_OleStorageName(), A_0);
            class2 = new Class1132(class3);
            MemoryStream stream2 = new MemoryStream();
            class2.method_5(stream2);
            this.stream_0 = stream2;
            this.stream_0.Position = 0L;
            if (A_0.Contains(string_12))
            {
                MemoryStream stream3 = A_0.method_4(string_12);
                stream3.Position = 0L;
                byte[] buffer2 = new byte[stream3.Length];
                stream3.Read(buffer2, 0, buffer2.Length);
                using (MemoryStream stream4 = new MemoryStream(buffer2))
                {
                    byte[] buffer4 = new byte[6];
                    stream4.Read(buffer4, 0, buffer4.Length);
                    this.Interface49.set_DisplayAsIcon((buffer4[0] & 0x40) == 0x40);
                    stream4.Flush();
                }
            }
            if (A_0.Contains(string_9))
            {
                Stream stream5 = A_0.method_4(string_9);
                stream5.Position = 0L;
                byte[] buffer3 = new byte[stream5.Length];
                stream5.Read(buffer3, 0, buffer3.Length);
                using (BinaryReader reader = new BinaryReader(new MemoryStream(buffer3)))
                {
                    reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadBytes(4);
                    new Guid(reader.ReadBytes(0x10));
                    Class627.smethod_2(reader);
                    new Class451(reader, false);
                    string str = Class627.smethod_2(reader);
                    if (!string.IsNullOrEmpty(str) && (str.Length > 0))
                    {
                        this.Interface49.set_ObjectType(str);
                    }
                    if (((reader.BaseStream.Length - reader.BaseStream.Position) >= 4L) && (reader.ReadInt32() == 0x71b239f4))
                    {
                        this.method_82(reader);
                        new Class451(reader, true);
                        this.method_82(reader);
                    }
                }
            }
        }

        private string method_82(BinaryReader A_0)
        {
            int num = A_0.ReadInt32();
            return this.method_83(A_0, num);
        }

        private string method_83(BinaryReader A_0, int A_1)
        {
            if (A_1 == 0)
            {
                return string.Empty;
            }
            byte[] bytes = A_0.ReadBytes(A_1);
            return Encoding.Unicode.GetString(bytes, 0, A_1 - 2);
        }

        internal void method_84(Class1116 A_0)
        {
            this.class1116_0 = A_0;
        }

        private void method_85(ShapeObject A_0)
        {
            if (((A_0.ShapePr != null) && (A_0.ShapePr.Count > 0)) && !A_0.ShapePr.Equals(base.ShapePr))
            {
                List<int> list = new List<int>(A_0.ShapePr.PropertiesHash.Keys);
                foreach (int num in list)
                {
                    base.ShapePr.PropertiesHash[num] = A_0.ShapePr.PropertiesHash[num];
                }
            }
            base.SetShapeType(ShapeType.OleObject);
        }

        internal void method_86(OleLinkType A_0)
        {
            this.oleLinkType_0 = A_0;
        }

        internal void method_87()
        {
            if (this.oleLinkType_0 == OleLinkType.Link)
            {
                this.field_1.Type = FieldType.FieldLink;
            }
            else
            {
                this.field_1.Type = FieldType.FieldEmbed;
            }
        }

        private void method_88()
        {
            int num = 11;
            try
            {
                if ((this.stream_1 != null) && (this.stream_1.Length > 0L))
                {
                    long position = this.stream_1.Position;
                    byte[] buffer = new byte[this.stream_1.Length];
                    this.stream_1.Read(buffer, 0, (int) this.stream_1.Length);
                    this.stream_1.Position = position;
                    this.class1116_0 = new Class1116(buffer, BookmarkStart.b("渰", num) + this.Interface49.get_OleStorageName());
                }
                else if ((base.m_doc.ObjectPool != null) && (base.m_doc.ObjectPool.Length > 0))
                {
                    this.class1116_0 = new Class1116(base.m_doc.ObjectPool, BookmarkStart.b("渰", num) + this.Interface49.get_OleStorageName());
                }
            }
            catch (Exception)
            {
            }
        }

        private byte[] method_89(string A_0)
        {
            return this.method_90(A_0, base.m_doc.ObjectPool);
        }

        private byte[] method_90(string A_0, byte[] A_1)
        {
            int num = 0x11;
            if ((this.stream_1 != null) && (this.OleObjectType == Spire.Doc.Documents.OleObjectType.Undefined))
            {
                A_1 = this.method_92(A_0, A_1);
                return A_1;
            }
            MemoryStream stream = null;
            Class1004 class2 = null;
            Stream12 stream2 = null;
            Stream12 stream3 = null;
            if ((A_1 != null) && (A_1.Length != 0))
            {
                stream = new MemoryStream(A_1);
                stream2 = new Stream12(stream, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
                stream3 = stream2.method_12(BookmarkStart.b("砶嬸儺堼尾㕀ፂ⩄⡆╈", num), STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
            }
            else
            {
                stream2 = Stream12.smethod_2();
                stream3 = stream2.method_13(BookmarkStart.b("砶嬸儺堼尾㕀ፂ⩄⡆╈", num));
            }
            class2 = new Class1004(BookmarkStart.b("搶䴸吺似帾♀♂", num), true);
            class2.Interface51.imethod_0().imethod_4(A_0);
            class2.Interface51.imethod_1().method_0()[1].method_13(Class1117.smethod_2(this.OleObjectType));
            MemoryStream stream4 = new MemoryStream();
            class2.Interface51.imethod_2();
            class2.Interface51.imethod_3(stream4);
            class2.System.IDisposable.Dispose();
            stream4.Flush();
            byte[] buffer = stream4.ToArray();
            stream4.Close();
            stream4 = new MemoryStream(buffer);
            MemoryStream stream5 = new MemoryStream();
            Stream12 stream6 = new Stream12(stream4);
            Stream12 stream7 = stream6.method_11(A_0);
            Stream12.smethod_0(stream7, stream3);
            stream2.Flush();
            stream2.method_17(stream5);
            stream5.Position = 0L;
            A_1 = stream5.ToArray();
            stream6.Close();
            stream6.Dispose();
            stream7.Close();
            stream7.Dispose();
            stream2.Close();
            stream2.Dispose();
            stream3.Close();
            stream3.Dispose();
            stream5.Close();
            stream5.Dispose();
            stream4.Close();
            stream4.Dispose();
            if (stream != null)
            {
                stream.Close();
                stream.Dispose();
            }
            return A_1;
        }

        private byte[] method_91()
        {
            byte[] buffer = null;
            Class1004 class2 = new Class1004(BookmarkStart.b("簮䔰尲䜴嘶常帺", 9), true);
            class2.Interface51.imethod_1().method_0()[0].method_13(Class1117.smethod_2(this.OleObjectType));
            MemoryStream stream = new MemoryStream();
            class2.Interface51.imethod_2();
            class2.Interface51.imethod_3(stream);
            class2.System.IDisposable.Dispose();
            stream.Flush();
            buffer = stream.ToArray();
            stream.Close();
            stream.Dispose();
            return buffer;
        }

        private byte[] method_92(string A_0, byte[] A_1)
        {
            Class1004 class3;
            Interface61 interface3;
            int num = 14;
            if ((A_1 != null) && (A_1.Length != 0))
            {
                MemoryStream stream = new MemoryStream(A_1);
                Class1004 class2 = new Class1004(stream);
                Interface61 interface2 = class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("笳吵刷弹弻䨽ဿⵁ⭃⩅", num));
                class3 = new Class1004();
                class3.Interface51.imethod_0().imethod_12(interface2);
                this.method_95(class2, class3);
                class2.System.IDisposable.Dispose();
                interface3 = class3.Interface51.imethod_0().imethod_5(BookmarkStart.b("笳吵刷弹弻䨽ဿⵁ⭃⩅", num));
            }
            else
            {
                class3 = new Class1004();
                interface3 = class3.Interface51.imethod_0().imethod_4(BookmarkStart.b("笳吵刷弹弻䨽ဿⵁ⭃⩅", num));
            }
            interface3 = interface3.imethod_4(A_0);
            this.method_96(class3, A_0);
            class3.Interface51.imethod_2();
            A_1 = (class3.method_4() as MemoryStream).ToArray();
            class3.System.IDisposable.Dispose();
            return A_1;
        }

        private byte[] method_93(byte[] A_0)
        {
            int num = 0x10;
            if ((A_0 == null) || ((A_0 != null) && (A_0.Length == 0)))
            {
                return A_0;
            }
            Class1004 class3 = null;
            using (MemoryStream stream = new MemoryStream(A_0))
            {
                using (Class1004 class2 = new Class1004(stream))
                {
                    if (((Array.IndexOf<string>(class2.Interface51.imethod_0().imethod_10(), BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", num)) != -1) && (Array.IndexOf<string>(class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", num)).imethod_10(), BookmarkStart.b("椵", num) + this.string_13) != -1)) && (Array.IndexOf<string>(class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", num)).imethod_5(BookmarkStart.b("椵", num) + this.string_13).imethod_9(), BookmarkStart.b("㔵眷堹嘻眽⸿⑁⭃", num)) != -1))
                    {
                        using (Stream1 stream2 = class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", num)).imethod_5(BookmarkStart.b("椵", num) + this.string_13).imethod_0(BookmarkStart.b("㔵眷堹嘻眽⸿⑁⭃", num)))
                        {
                            byte[] buffer = Class371.smethod_13(this.Interface49.get_LinkType(), this.OleObjectType, this.Interface49.get_DisplayAsIcon());
                            stream2.Write(buffer, 0, buffer.Length);
                            stream2.Flush();
                            class3 = new Class1004();
                            class3.Interface51.imethod_0().imethod_12(class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", num)));
                            this.method_95(class2, class3);
                            class2.System.IDisposable.Dispose();
                            class3.Interface51.imethod_2();
                            A_0 = (class3.method_4() as MemoryStream).ToArray();
                            class3.System.IDisposable.Dispose();
                        }
                    }
                    return A_0;
                }
            }
        }

        private void method_94()
        {
            base.m_doc.ObjectPool = this.method_93(base.m_doc.ObjectPool);
        }

        private void method_95(Class1004 A_0, Class1004 A_1)
        {
            int num = 11;
            this.dictionary_0.Clear();
            foreach (Class297 class3 in A_0.Interface51.imethod_1().method_0())
            {
                if ((class3.method_0() != BookmarkStart.b("縰儲弴制娸伺洼倾⹀⽂", num)) && (class3.method_2() == Class297.EntryType.Storage))
                {
                    if (this.dictionary_0.ContainsKey(class3.method_0()))
                    {
                        this.dictionary_0[class3.method_0()] = class3.method_12();
                    }
                    else
                    {
                        this.dictionary_0.Add(class3.method_0(), class3.method_12());
                    }
                }
            }
            A_0.System.IDisposable.Dispose();
            foreach (Class297 class2 in A_1.Interface51.imethod_1().method_0())
            {
                if (this.dictionary_0.ContainsKey(class2.method_0()))
                {
                    class2.method_13(this.dictionary_0[class2.method_0()]);
                }
            }
        }

        private void method_96(Class1004 A_0, string A_1)
        {
            Class1004 class2 = new Class1004(this.stream_1);
            this.stream_1.Position = 0L;
            Guid guid = Class1117.smethod_2(this.OleObjectType);
            using (List<Class297>.Enumerator enumerator = class2.Interface51.imethod_1().method_0().GetEnumerator())
            {
                Class297 current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (class2.Interface51.imethod_0().imethod_11() == current.method_0())
                    {
                        goto Label_006D;
                    }
                }
                goto Label_0085;
            Label_006D:
                guid = current.method_12();
            }
        Label_0085:
            class2.System.IDisposable.Dispose();
            using (List<Class297>.Enumerator enumerator2 = A_0.Interface51.imethod_1().method_0().GetEnumerator())
            {
                Class297 class3;
                while (enumerator2.MoveNext())
                {
                    class3 = enumerator2.Current;
                    if (A_1 == class3.method_0())
                    {
                        goto Label_00C2;
                    }
                }
                return;
            Label_00C2:
                class3.method_13(guid);
                this.dictionary_0.Add(A_1, guid);
            }
        }

        internal byte[] method_97(byte[] A_0)
        {
            if (this.OleObjectType == Spire.Doc.Documents.OleObjectType.Package)
            {
                return this.method_98(A_0);
            }
            byte[] buffer = this.method_91();
            buffer = new Class1116().method_13(buffer, A_0, this);
            if (!this.Interface49.get_DisplayAsIcon())
            {
                buffer = this.method_93(buffer);
            }
            return buffer;
        }

        private byte[] method_98(byte[] A_0)
        {
            byte[] buffer3;
            string fullPath = Path.GetFullPath(this.Interface49.get_PackageFileName());
            string fileName = Path.GetFileName(fullPath);
            byte[] bytes = Encoding.Default.GetBytes(fullPath);
            byte[] buffer = Encoding.Default.GetBytes(fileName);
            if (File.Exists(fullPath))
            {
                buffer3 = File.ReadAllBytes(fullPath);
            }
            else
            {
                buffer3 = A_0;
            }
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write((ushort) 2);
                    writer.Write(buffer, 0, buffer.Length);
                    writer.Write((byte) 0);
                    writer.Write(bytes, 0, bytes.Length);
                    writer.Write((byte) 0);
                    writer.Write((byte) 0);
                    writer.Write((byte) 0);
                    writer.Write((byte) 3);
                    writer.Write((byte) 0);
                    byte[] buffer4 = BitConverter.GetBytes((uint) (bytes.Length + 1));
                    writer.Write(buffer4, 0, buffer4.Length);
                    writer.Write(bytes, 0, bytes.Length);
                    writer.Write((byte) 0);
                    byte[] buffer5 = BitConverter.GetBytes((uint) buffer3.Length);
                    writer.Write(buffer5, 0, buffer5.Length);
                    writer.Write(buffer3, 0, buffer3.Length);
                    writer.Flush();
                }
                return stream.ToArray();
            }
        }

        internal void method_99(string A_0)
        {
            this.string_13 = NextOleObjId.ToString();
            byte[] buffer = this.method_89(BookmarkStart.b("爬", 7) + this.string_13);
            this.class1116_0 = new Class1116();
            base.m_doc.ObjectPool = this.class1116_0.method_11(buffer, A_0, BookmarkStart.b("爬", 7) + this.string_13, this.oleLinkType_0, this.oleObjectType_0);
            if (!this.Interface49.get_DisplayAsIcon())
            {
                this.method_94();
            }
        }

        public void SetNativeData(byte[] nativeData)
        {
            this.class1116_0 = null;
            this.stream_1 = null;
            this.byte_5 = nativeData;
            this.bool_11 = true;
        }

        public void SetOlePicture(DocPicture picture)
        {
            this.method_85(picture);
            base.ImageData = picture;
        }

        internal static byte[] smethod_3(List<DocOleObject> A_0)
        {
            int num = 3;
            byte[] buffer = new byte[0];
            if ((A_0 != null) && (A_0.Count > 0))
            {
                List<string> list = new List<string>();
                using (MemoryStream stream5 = new MemoryStream())
                {
                    using (Stream12 stream = Stream12.smethod_2())
                    {
                        using (Stream12 stream2 = stream.method_13(BookmarkStart.b("昨䤪䜬䨮到䜲攴堶嘸场", num)))
                        {
                            foreach (DocOleObject obj2 in A_0)
                            {
                                string item = BookmarkStart.b("瘨", num) + obj2.Interface49.get_OleStorageName();
                                if (!list.Contains(item))
                                {
                                    list.Add(item);
                                    if (obj2.Interface49.get_Container() != null)
                                    {
                                        obj2.Interface49.get_Container().Position = 0L;
                                        using (Stream12 stream3 = new Stream12(obj2.Interface49.get_Container()))
                                        {
                                            using (Stream12 stream4 = stream3.method_11(item))
                                            {
                                                Stream12.smethod_0(stream4, stream2);
                                            }
                                        }
                                    }
                                }
                            }
                            stream.Flush();
                            stream.method_17(stream5);
                            stream5.Position = 0L;
                            buffer = stream5.ToArray();
                        }
                    }
                }
                list = null;
            }
            return buffer;
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            if (base.ImageData != null)
            {
                dc.method_213(base.ImageData, ltWidget, true);
            }
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            if (this.TextWrappingStyle != TextWrappingStyle.Inline)
            {
                return SizeF.Empty;
            }
            if ((base.NextSibling is FieldMark) && ((base.NextSibling as FieldMark).Type == FieldMarkType.FieldSeparator))
            {
                DocumentObject nextSibling = base.NextSibling as DocumentObject;
                while (nextSibling != null)
                {
                    if ((nextSibling.NextSibling is FieldMark) && ((nextSibling.NextSibling as FieldMark).Type == FieldMarkType.FieldEnd))
                    {
                        break;
                    }
                    nextSibling = nextSibling.NextSibling as DocumentObject;
                    if (nextSibling is DocPicture)
                    {
                        DocPicture picture = nextSibling as DocPicture;
                        picture.interface23_0 = new Class205();
                        picture.interface23_0.imethod_5(true);
                    }
                }
            }
            if (base.ImageData == null)
            {
                return SizeF.Empty;
            }
            if (base.ImageData.HeightScale != 100f)
            {
                base.ImageData.Height = (base.ImageData.Height * base.ImageData.HeightScale) / 100f;
                base.ImageData.HeightScale = 100f;
            }
            if (base.ImageData.WidthScale != 100f)
            {
                base.ImageData.Width = (base.ImageData.Width * base.ImageData.WidthScale) / 100f;
                base.ImageData.WidthScale = 100f;
            }
            return base.ImageData.Size;
        }

        internal bool AutoUpdate
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x1014);
            }
            set
            {
                base.SetShapeAttribute(0x1014, value);
            }
        }

        public override Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                if (this.Interface49.get_OlePicture() == null)
                {
                    return base.CharacterFormat;
                }
                return this.Interface49.get_OlePicture().CharacterFormat;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.OleObject;
            }
        }

        internal Spire.Doc.Fields.Field Field
        {
            get
            {
                if (this.field_1 == null)
                {
                    this.field_1 = new Spire.Doc.Fields.Field(base.m_doc);
                }
                if (this.field_1.Type == FieldType.FieldNone)
                {
                    this.method_87();
                }
                this.field_1.method_0(this);
                return this.field_1;
            }
            set
            {
                this.field_1 = value;
            }
        }

        Stream Interface49.Container
        {
            get
            {
                if (((this.stream_0 == null) && (base.m_doc.ObjectPool != null)) && (base.m_doc.ObjectPool.Length > 0))
                {
                    this.stream_0 = this.method_76();
                }
                return this.stream_0;
            }
        }

        bool Interface49.DisplayAsIcon
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x33a);
            }
            set
            {
                base.SetShapeAttribute(0x33a, value);
                if (!base.Document.bool_3)
                {
                    this.method_94();
                }
            }
        }

        string Interface49.LinkPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.string_14))
                {
                    this.method_78();
                }
                return this.string_14;
            }
            set
            {
                value = Path.GetFullPath(value);
                this.string_14 = value;
            }
        }

        OleLinkType Interface49.LinkType
        {
            get
            {
                return this.oleLinkType_0;
            }
        }

        byte[] Interface49.NativeData
        {
            get
            {
                if (((this.OleObject == null) && (this.byte_5 == null)) && (this.stream_0 != null))
                {
                    this.byte_5 = new byte[this.stream_0.Length];
                    this.stream_0.Read(this.byte_5, 0, this.byte_5.Length);
                }
                if ((this.OleObject != null) && (this.OleObject.method_0() != null))
                {
                    return this.class1116_0.method_0();
                }
                return this.byte_5;
            }
            internal set
            {
                this.byte_5 = value;
            }
        }

        string Interface49.ObjectType
        {
            get
            {
                string shapeAttribute = (string) base.GetShapeAttribute(0x1011);
                if (!string.IsNullOrEmpty(shapeAttribute))
                {
                    return shapeAttribute;
                }
                return Class1117.smethod_1(this.OleObjectType, false);
            }
            set
            {
                base.SetShapeAttribute(0x1011, value);
                this.oleObjectType_0 = Class1117.smethod_0(value);
            }
        }

        DocPicture Interface49.OlePicture
        {
            get
            {
                if (((base.NextSibling is FieldMark) && (base.NextSibling.NextSibling is DocPicture)) && (base.ImageData != base.NextSibling.NextSibling))
                {
                    return (base.NextSibling.NextSibling as DocPicture);
                }
                return base.ImageData;
            }
        }

        string Interface49.OleStorageName
        {
            get
            {
                if (string.IsNullOrEmpty(this.string_13))
                {
                    this.string_13 = new Random().Next().ToString();
                }
                return this.string_13;
            }
            set
            {
                this.string_13 = value;
            }
        }

        string Interface49.PackageFileName
        {
            get
            {
                if (this.OleObject != null)
                {
                    return this.OleObject.method_2();
                }
                return this.string_15;
            }
        }

        internal bool IsChangeNativeData
        {
            get
            {
                return this.bool_11;
            }
        }

        internal bool IsLink
        {
            get
            {
                return (this.Interface49.get_LinkType() == OleLinkType.Link);
            }
        }

        internal bool IsLocked
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x1015);
            }
            set
            {
                base.SetShapeAttribute(0x1015, value);
            }
        }

        private static int NextOleObjId
        {
            get
            {
                if (random_0 == null)
                {
                    DateTime time2 = new DateTime();
                    random_0 = new Random(time2.Millisecond);
                }
                return random_0.Next();
            }
        }

        internal Class1116 OleObject
        {
            get
            {
                if (this.class1116_0 == null)
                {
                    this.method_88();
                }
                return this.class1116_0;
            }
        }

        internal Spire.Doc.Documents.OleObjectType OleObjectType
        {
            get
            {
                if ((this.OleObject != null) && (this.OleObject.method_1() != Spire.Doc.Documents.OleObjectType.Undefined))
                {
                    return this.class1116_0.method_1();
                }
                return this.oleObjectType_0;
            }
            set
            {
                this.oleObjectType_0 = value;
            }
        }

        internal int OleTxid
        {
            get
            {
                return (int) base.GetShapeAttribute(0x10b);
            }
            set
            {
                base.SetShapeAttribute(0x10b, value);
            }
        }

        internal Class6 OleXmlItem
        {
            get
            {
                return this.class6_0;
            }
            set
            {
                this.class6_0 = value;
            }
        }

        internal string SourceFullName
        {
            get
            {
                return (string) base.GetShapeAttribute(0x1012);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("䄶堸场䠼娾", 0x11));
                base.SetShapeAttribute(0x1012, value);
            }
        }

        internal string SourceItem
        {
            get
            {
                return (string) base.GetShapeAttribute(0x1013);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("䐱唳娵䴷弹", 12));
                base.SetShapeAttribute(0x1013, value);
            }
        }
    }
}

