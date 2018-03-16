using Spire.Doc;
using Spire.Doc.Interface;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

internal class Class669 : IXDLSAttributeWriter, IXDLSContentWriter
{
    private Class620 class620_0 = new Class620();
    private Metafile metafile_0;
    private const string string_0 = "#";
    private const string string_1 = "X2";
    private string string_2 = BookmarkStart.b("戬戮細", 7);
    private readonly XmlWriter xmlWriter_0;

    public Class669(XmlWriter A_0)
    {
        this.xmlWriter_0 = A_0;
    }

    public void method_0(IDocumentSerializable A_0)
    {
        A_0.XDLSHolder.BeforeSerialization();
        this.method_1(this.string_2, A_0, false);
    }

    private void method_1(string A_0, IDocumentSerializable A_1, bool A_2)
    {
        int num = 4;
        if (!A_1.XDLSHolder.SkipMe)
        {
            this.xmlWriter_0.WriteStartElement(A_0);
            if (A_2 && A_1.XDLSHolder.EnableID)
            {
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䌩䠫", num), A_1.XDLSHolder.ID);
            }
            A_1.WriteXmlAttributes(this);
            A_1.WriteXmlContent(this);
            this.xmlWriter_0.WriteEndElement();
        }
    }

    private void method_2(string A_0, IXDLSSerializableCollection A_1)
    {
        if (A_1.Count > 0)
        {
            this.xmlWriter_0.WriteStartElement(A_0);
            foreach (IDocumentSerializable serializable in A_1)
            {
                if (serializable != null)
                {
                    this.method_1(A_1.TagItemName, serializable, true);
                }
            }
            this.xmlWriter_0.WriteEndElement();
        }
    }

    private void method_3(string A_0, object A_1)
    {
        IXmlSerializable serializable = A_1 as IXmlSerializable;
        if (serializable != null)
        {
            serializable.WriteXml(this.xmlWriter_0);
        }
    }

    internal void method_4(Image A_0)
    {
        int num = 0x11;
        if (A_0 != null)
        {
            MemoryStream stream = this.method_6(A_0);
            byte[] buffer = new byte[stream.Length];
            stream.Position = 0L;
            stream.Read(buffer, 0, buffer.Length);
            this.Spire.Doc.Interface.IXDLSContentWriter.WriteChildBinaryElement(BookmarkStart.b("帶吸娺娼娾", num), buffer);
        }
    }

    private bool method_5(EmfPlusRecordType A_0, int A_1, int A_2, IntPtr A_3, PlayRecordCallback A_4)
    {
        byte[] destination = new byte[A_2];
        if (A_3 != IntPtr.Zero)
        {
            Marshal.Copy(A_3, destination, 0, A_2);
        }
        this.metafile_0.PlayRecord(A_0, A_1, A_2, destination);
        return true;
    }

    private MemoryStream method_6(Image A_0)
    {
        MemoryStream stream = new MemoryStream();
        if (A_0 is Metafile)
        {
            this.metafile_0 = A_0 as Metafile;
            Rectangle bounds = this.metafile_0.GetMetafileHeader().Bounds;
            Bitmap image = new Bitmap(bounds.Width, bounds.Height, this.metafile_0.PixelFormat);
            Graphics graphics = Graphics.FromImage(image);
            IntPtr hdc = graphics.GetHdc();
            Metafile metafile = new Metafile(stream, hdc, EmfType.EmfOnly);
            graphics.ReleaseHdc(hdc);
            using (Graphics graphics2 = Graphics.FromImage(metafile))
            {
                graphics2.EnumerateMetafile(this.metafile_0, bounds.Location, new Graphics.EnumerateMetafileProc(this.method_5));
                return stream;
            }
        }
        try
        {
            A_0.Save(stream, A_0.RawFormat);
        }
        catch
        {
            A_0.Save(stream, ImageFormat.Png);
        }
        return stream;
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, bool A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, XmlConvert.ToString(A_1));
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, DateTime A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, XmlConvert.ToString(A_1, XmlDateTimeSerializationMode.Utc));
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, double A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, XmlConvert.ToString(A_1));
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, Color A_1)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弰刲場制", num));
        }
        if (A_0.Length == 0)
        {
            throw new ArgumentException(BookmarkStart.b("弰刲場制ᤸᘺᴼ䰾㕀ㅂⱄ⥆⹈歊⹌⹎㽐獒㭔㡖ⵘ筚㽜㩞䅠٢ࡤᝦᵨቪ", num));
        }
        StringBuilder builder = new StringBuilder();
        if (!A_1.IsEmpty)
        {
            builder.Append(BookmarkStart.b("ሰ", num));
            builder.Append(A_1.A.ToString(BookmarkStart.b("椰Ĳ", num)));
            builder.Append(A_1.R.ToString(BookmarkStart.b("椰Ĳ", num)));
            builder.Append(A_1.G.ToString(BookmarkStart.b("椰Ĳ", num)));
            builder.Append(A_1.B.ToString(BookmarkStart.b("椰Ĳ", num)));
        }
        this.xmlWriter_0.WriteAttributeString(A_0, builder.ToString());
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, Enum A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, A_1.ToString());
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, int A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, XmlConvert.ToString(A_1));
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, float A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, XmlConvert.ToString(A_1));
    }

    void IXDLSAttributeWriter.WriteValue(string A_0, string A_1)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, A_1);
    }

    void IXDLSContentWriter.WriteChildBinaryElement(string A_0, byte[] A_1)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("夶堸嘺堼", num));
        }
        if (A_0.Length == 0)
        {
            throw new ArgumentException(BookmarkStart.b("夶堸嘺堼Ἶ汀捂㙄㍆㭈≊⍌⡎煐げ㑔㥖祘㕚㉜⭞䅠Ţd䝦౨٪ᵬ᭮ࡰ", num));
        }
        this.Spire.Doc.Interface.IXDLSContentWriter.get_InnerWriter().WriteStartElement(A_0);
        this.Spire.Doc.Interface.IXDLSContentWriter.get_InnerWriter().WriteBase64(A_1, 0, A_1.Length);
        this.Spire.Doc.Interface.IXDLSContentWriter.get_InnerWriter().WriteEndElement();
    }

    void IXDLSContentWriter.WriteChildElement(string A_0, object A_1)
    {
        int num = 0x11;
        IDocumentSerializable serializable = A_1 as IDocumentSerializable;
        if (serializable != null)
        {
            this.method_1(A_0, serializable, false);
        }
        else
        {
            IXDLSSerializableCollection serializables = A_1 as IXDLSSerializableCollection;
            if (serializables != null)
            {
                this.method_2(A_0, serializables);
            }
            else if (A_1 is string)
            {
                this.xmlWriter_0.WriteStartElement(A_0);
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䌶䀸䬺堼", num), BookmarkStart.b("搶䴸䤺吼儾♀", num));
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䄶堸场䠼娾", num), (string) A_1);
                this.xmlWriter_0.WriteEndElement();
            }
            else if (A_1 is int)
            {
                this.xmlWriter_0.WriteStartElement(A_0);
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䌶䀸䬺堼", num), BookmarkStart.b("縶圸伺฼ാ", num));
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䄶堸场䠼娾", num), (int) A_1);
                this.xmlWriter_0.WriteEndElement();
            }
            else if (A_1 is float)
            {
                this.xmlWriter_0.WriteStartElement(A_0);
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䌶䀸䬺堼", num), BookmarkStart.b("搶倸唺娼匾⑀", num));
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䄶堸场䠼娾", num), (float) A_1);
                this.xmlWriter_0.WriteEndElement();
            }
            else if (A_1 is bool)
            {
                this.xmlWriter_0.WriteStartElement(A_0);
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䌶䀸䬺堼", num), BookmarkStart.b("甶嘸吺儼娾⁀ⵂ", num));
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䄶堸场䠼娾", num), A_1.ToString());
                this.xmlWriter_0.WriteEndElement();
            }
            else if (A_1 is Enum)
            {
                this.xmlWriter_0.WriteStartElement(A_0);
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䌶䀸䬺堼", num), A_1.GetType().ToString());
                this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䄶堸场䠼娾", num), A_1.ToString());
                this.xmlWriter_0.WriteEndElement();
            }
            else
            {
                this.vmethod_0(A_0, A_1);
            }
        }
    }

    void IXDLSContentWriter.WriteChildRefElement(string A_0, int A_1)
    {
        this.xmlWriter_0.WriteStartElement(A_0);
        this.Spire.Doc.Interface.IXDLSAttributeWriter.WriteValue(BookmarkStart.b("䘳匵帷", 14), A_1);
        this.xmlWriter_0.WriteEndElement();
    }

    void IXDLSContentWriter.WriteChildStringElement(string A_0, string A_1)
    {
        this.xmlWriter_0.WriteStartElement(A_0);
        this.xmlWriter_0.WriteString(A_1);
        this.xmlWriter_0.WriteEndElement();
    }

    protected virtual void vmethod_0(string A_0, object A_1)
    {
        if (!this.class620_0.method_0(this.xmlWriter_0, A_0, A_1))
        {
            this.method_3(A_0, A_1);
        }
    }

    XmlWriter IXDLSContentWriter.InnerWriter
    {
        get
        {
            return this.xmlWriter_0;
        }
    }
}

