using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

internal class Class827
{
    private readonly bool bool_0;
    private bool bool_1;
    private readonly byte[] byte_0;
    private readonly EmbeddedFontFormat embeddedFontFormat_0;
    private readonly EmbeddedFontStyle embeddedFontStyle_0;
    private PrivateFontCollection privateFontCollection_0;
    private spr➎ spr➎_0;

    internal Class827(byte[] A_0, EmbeddedFontFormat A_1, EmbeddedFontStyle A_2, bool A_3)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬬䀮弰䜲焴嘶䴸娺", num));
        }
        this.byte_0 = A_0;
        this.embeddedFontFormat_0 = A_1;
        this.embeddedFontStyle_0 = A_2;
        this.bool_0 = A_3;
    }

    internal byte[] method_0()
    {
        return this.byte_0;
    }

    internal EmbeddedFontFormat method_1()
    {
        return this.embeddedFontFormat_0;
    }

    internal EmbeddedFontStyle method_2()
    {
        return this.embeddedFontStyle_0;
    }

    internal bool method_3()
    {
        return this.bool_0;
    }

    internal FontFamily method_4()
    {
        if ((this.byte_0 != null) && (this.privateFontCollection_0 == null))
        {
            this.method_8();
        }
        if ((this.privateFontCollection_0 != null) && (this.privateFontCollection_0.Families.Length > 0))
        {
            return this.privateFontCollection_0.Families[0];
        }
        return null;
    }

    internal spr➎ method_5()
    {
        if (!this.bool_1)
        {
            this.spr➎_0 = this.method_6();
            this.bool_1 = true;
        }
        return this.spr➎_0;
    }

    private spr➎ method_6()
    {
        try
        {
            if (this.byte_0 == null)
            {
                return null;
            }
            byte[] buffer = null;
            if (this.embeddedFontFormat_0 == EmbeddedFontFormat.OpenType)
            {
                buffer = this.byte_0;
            }
            else if (this.embeddedFontFormat_0 == EmbeddedFontFormat.EmbeddedOpenType)
            {
                buffer = spr᩼.ᜂ(this.byte_0);
            }
            if (buffer == null)
            {
                return null;
            }
            spr╞ r╞ = new spr╞();
            return r╞.ᜀ(buffer, null);
        }
        catch (Exception)
        {
            return null;
        }
    }

    internal void method_7(PrivateFontCollection A_0)
    {
        if (this.byte_0 != null)
        {
            byte[] source = null;
            if (this.embeddedFontFormat_0 == EmbeddedFontFormat.OpenType)
            {
                source = this.byte_0;
            }
            else if (this.embeddedFontFormat_0 == EmbeddedFontFormat.EmbeddedOpenType)
            {
                source = spr᩼.ᜂ(this.byte_0);
            }
            if (source != null)
            {
                if (A_0 == null)
                {
                    A_0 = new PrivateFontCollection();
                }
                IntPtr destination = Marshal.AllocCoTaskMem(source.Length);
                if (destination != IntPtr.Zero)
                {
                    try
                    {
                        Marshal.Copy(source, 0, destination, source.Length);
                        A_0.AddMemoryFont(destination, source.Length);
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        Marshal.FreeCoTaskMem(destination);
                    }
                }
            }
        }
    }

    private void method_8()
    {
        this.method_7(this.privateFontCollection_0);
    }
}

