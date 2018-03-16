using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

[DefaultMember("Item")]
internal class Class294
{
    private Dictionary<int, Class517> dictionary_0 = new Dictionary<int, Class517>();
    private Document document_0;
    private int int_0;
    private List<int> list_0 = new List<int>();

    internal Class294(Document A_0)
    {
        this.document_0 = A_0;
    }

    internal Class517 method_0(int A_0)
    {
        if (this.dictionary_0.ContainsKey(A_0))
        {
            return this.dictionary_0[A_0];
        }
        return null;
    }

    internal Document method_1()
    {
        return this.document_0;
    }

    internal void method_2(Class517 A_0)
    {
        int num = 1;
        if (this.list_0.Count > 0)
        {
            num = this.list_0[0];
            this.list_0.RemoveAt(0);
        }
        else if (this.dictionary_0.Count > 0)
        {
            num = ++this.int_0;
        }
        else
        {
            this.int_0++;
        }
        A_0.method_1(num);
        this.dictionary_0.Add(num, A_0);
    }

    internal bool method_3(int A_0)
    {
        if (this.dictionary_0.ContainsKey(A_0))
        {
            this.dictionary_0.Remove(A_0);
            this.list_0.Add(A_0);
            return true;
        }
        return false;
    }

    internal void method_4()
    {
        foreach (Class517 class2 in this.dictionary_0.Values)
        {
            class2.method_17();
        }
        this.dictionary_0.Clear();
        this.list_0.Clear();
        this.int_0 = 0;
    }

    internal Class517 method_5(byte[] A_0)
    {
        HMACSHA1 hmacsha = new HMACSHA1 {
            Key = Class517.byte_0
        };
        Class299 class2 = new Class299();
        Class517 class3 = null;
        using (Dictionary<int, Class517>.ValueCollection.Enumerator enumerator = this.dictionary_0.Values.GetEnumerator())
        {
            Class517 current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if ((!current.method_7() && (current.byte_1 != null)) && ((current.byte_1.Length == A_0.Length) && class2.method_15(current.method_4(), hmacsha.ComputeHash(A_0))))
                {
                    goto Label_0077;
                }
            }
            goto Label_008A;
        Label_0077:
            class3 = current;
        }
    Label_008A:
        if (class3 == null)
        {
            class3 = new Class517(this.document_0, A_0);
            this.method_2(class3);
        }
        A_0 = null;
        class3.method_6(class3.method_5() + 1);
        return class3;
    }

    internal Class517 method_6(byte[] A_0, bool A_1)
    {
        int length = A_0.Length;
        if (!A_1)
        {
            A_0 = this.method_8(A_0);
        }
        HMACSHA1 hmacsha = new HMACSHA1 {
            Key = Class517.byte_0
        };
        Class299 class3 = new Class299();
        Class517 class2 = null;
        using (Dictionary<int, Class517>.ValueCollection.Enumerator enumerator = this.dictionary_0.Values.GetEnumerator())
        {
            Class517 current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if ((current.method_7() && (current.byte_1.Length == A_0.Length)) && class3.method_15(current.method_4(), hmacsha.ComputeHash(A_0)))
                {
                    goto Label_007F;
                }
            }
            goto Label_0092;
        Label_007F:
            class2 = current;
        }
    Label_0092:
        if (class2 == null)
        {
            class2 = new Class517(this.document_0, A_0);
            this.method_2(class2);
            if (!A_1)
            {
                class2.method_14(length);
            }
        }
        A_0 = null;
        class2.method_6(class2.method_5() + 1);
        class2.method_8(true);
        return class2;
    }

    internal Class517 method_7(byte[] A_0)
    {
        Image image = Class517.smethod_0(A_0);
        if (image is Metafile)
        {
            return this.method_6(A_0, false);
        }
        return this.method_5(A_0);
    }

    private byte[] method_8(byte[] A_0)
    {
        byte[] buffer;
        try
        {
            MemoryStream stream = new MemoryStream();
            new Class1113(stream, true).method_0(A_0, 0, A_0.Length, true);
            stream.Close();
            buffer = stream.ToArray();
        }
        catch
        {
            MemoryStream stream2 = new MemoryStream();
            GZipStream stream3 = new GZipStream(stream2, CompressionMode.Compress, true);
            stream3.Write(A_0, 0, A_0.Length);
            stream3.Close();
            buffer = stream2.ToArray();
            stream2.Close();
        }
        return buffer;
    }

    internal byte[] method_9(byte[] A_0)
    {
        byte[] buffer2;
        try
        {
            int num;
            MemoryStream stream = new MemoryStream(A_0);
            Class1114 class2 = new Class1114(stream);
            MemoryStream stream2 = new MemoryStream();
            byte[] buffer = new byte[0x1000];
            goto Label_002B;
        Label_0021:
            stream2.Write(buffer, 0, num);
        Label_002B:
            num = class2.method_18(buffer, 0, buffer.Length);
            if (num > 0)
            {
                goto Label_0021;
            }
            stream.Close();
            stream = null;
            buffer2 = stream2.ToArray();
            stream2.Close();
            stream2 = null;
        }
        catch
        {
            using (GZipStream stream3 = new GZipStream(new MemoryStream(A_0), CompressionMode.Decompress, true))
            {
                byte[] buffer3 = new byte[0x1000];
                using (MemoryStream stream4 = new MemoryStream())
                {
                    int count = 0;
                    goto Label_0094;
                Label_007F:
                    if (count > 0)
                    {
                        goto Label_0094;
                    }
                    goto Label_00AB;
                Label_0086:
                    stream4.Write(buffer3, 0, count);
                    goto Label_007F;
                Label_0094:
                    count = stream3.Read(buffer3, 0, buffer3.Length);
                    if (count <= 0)
                    {
                        goto Label_007F;
                    }
                    goto Label_0086;
                Label_00AB:
                    buffer2 = stream4.ToArray();
                }
                return buffer2;
            }
        }
        return buffer2;
    }
}

