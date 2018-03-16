using Spire.Doc;
using System;
using System.Drawing;
using System.IO;

internal class Class1015
{
    private Class1014 class1014_0;
    private Class612 class612_0;

    public Class1015(Font A_0)
    {
        using (MemoryStream stream = new MemoryStream(this.method_2(A_0)))
        {
            this.class612_0 = new Class612(stream);
            this.class612_0.method_4();
            this.method_1();
        }
    }

    public Class1014 method_0()
    {
        return this.class1014_0;
    }

    private void method_1()
    {
        this.class612_0.method_6(BookmarkStart.b("眷椹ጻఽ", 0x12));
        this.class1014_0 = new Class1014(this.class612_0.method_0());
    }

    private byte[] method_2(Font A_0)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刳夵嘷丹", num));
        }
        byte[] buffer = null;
        IntPtr ptr = Class668.CreateDC(BookmarkStart.b("瀳缵欷樹瀻缽᤿", num), null, null, IntPtr.Zero);
        IntPtr ptr2 = A_0.ToHfont();
        IntPtr ptr3 = Class668.SelectObject(ptr, ptr2);
        uint num2 = Class668.GetFontData(ptr, 0, 0, null, 0);
        if (num2 == uint.MaxValue)
        {
            Class947.GetLastError();
            throw new Exception(BookmarkStart.b("圳圵嘷ᨹ刻儽㐿扁㑃❅㩇㥉⥋湍⑏㩑ㅓ癕㹗㕙㉛⩝", num));
        }
        buffer = new byte[num2];
        Class668.GetFontData(ptr, 0, 0, buffer, num2);
        Class668.DeleteObject(Class668.SelectObject(ptr, ptr3));
        Class668.DeleteObject(ptr3);
        Class668.DeleteDC(ptr2);
        Class668.DeleteDC(ptr);
        return buffer;
    }
}

