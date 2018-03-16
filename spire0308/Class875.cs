using Spire.Doc;
using Spire.Doc.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Text;

internal class Class875
{
    private byte[] byte_0;
    private CLIPDATA clipdata_0 = new CLIPDATA();

    public void method_0(Struct9 A_0)
    {
        object obj2 = Marshal.PtrToStructure(A_0.intptr_0, typeof(CLIPDATA));
        this.clipdata_0 = (CLIPDATA) obj2;
        this.byte_0 = new byte[this.clipdata_0.uint_0];
        Marshal.Copy(this.clipdata_0.intptr_0, this.byte_0, 0, this.byte_0.Length);
    }

    public void method_1(string A_0)
    {
        int num = 0x10;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentException(BookmarkStart.b("刵夷丹崻", num));
        }
        string[] strArray = A_0.Split(new char[] { ' ' });
        if (strArray.Length < 2)
        {
            throw new ArgumentException(BookmarkStart.b("刵夷丹崻", num));
        }
        byte[] buffer = Convert.FromBase64String(strArray[0]);
        this.clipdata_0.int_0 = Convert.ToInt32(buffer);
        this.byte_0 = Convert.FromBase64String(strArray[1]);
        this.clipdata_0.uint_0 = (uint) this.byte_0.Length;
    }

    public void method_2(Struct9 A_0)
    {
        this.clipdata_0.intptr_0 = Marshal.AllocHGlobal(this.byte_0.Length);
        Marshal.Copy(this.byte_0, 0, this.clipdata_0.intptr_0, this.byte_0.Length);
        this.clipdata_0.uint_0 = (uint) this.byte_0.Length;
        Marshal.StructureToPtr(this.clipdata_0, A_0.intptr_0, true);
    }

    public string method_3()
    {
        StringBuilder builder = new StringBuilder();
        byte[] bytes = BitConverter.GetBytes(this.clipdata_0.int_0);
        builder.Append(Convert.ToBase64String(bytes));
        builder.Append(BookmarkStart.b("ബ", 7));
        builder.Append(Convert.ToBase64String(this.byte_0));
        return builder.ToString();
    }

    string object.ToString()
    {
        return this.method_3();
    }
}

