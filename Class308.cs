using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;

internal class Class308
{
    private readonly bool bool_0;
    internal float float_0;
    private readonly float float_1;
    private readonly float float_2;
    private readonly float float_3;
    private readonly float float_4;
    private Font font_0;
    private FontStyle fontStyle_0;
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static Hashtable hashtable_1 = Hashtable.Synchronized(new Hashtable());
    private spr➎ spr➎_0;
    private string string_0 = "";
    private static readonly StringFormat stringFormat_0 = StringFormat.GenericTypographic;

    static Class308()
    {
        stringFormat_0.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
    }

    public Class308(string A_0, float A_1, FontStyle A_2)
    {
        this.fontStyle_0 = A_2;
        this.float_0 = A_1;
        this.spr➎_0 = this.method_0().ᜀ(A_0, A_2, A_0);
        this.string_0 = A_0;
        this.bool_0 = this.spr➎_0.᜞();
        if (this.spr➎_0.ᜀ((float) this.spr➎_0.ᜆ(), A_1) < float.Epsilon)
        {
            this.float_1 = this.spr➎_0.ᜁ(A_1);
            this.float_2 = this.float_1 * 0.618f;
            this.float_3 = this.float_1 * 0.382f;
        }
        else
        {
            this.float_1 = this.spr➎_0.ᜁ(A_1);
            this.float_2 = this.spr➎_0.ᜀ((float) this.spr➎_0.᜝(), A_1);
            this.float_3 = this.spr➎_0.ᜀ((float) this.spr➎_0.ᜍ(), A_1);
            this.float_4 = this.spr➎_0.ᜀ((float) this.spr➎_0.᜜(), A_1);
        }
    }

    private spr᮵ method_0()
    {
        return spr᮵.ᜂ();
    }

    public string method_1()
    {
        return this.string_0;
    }

    public float method_10()
    {
        return this.float_1;
    }

    public float method_11()
    {
        return this.float_2;
    }

    public float method_12()
    {
        return this.float_3;
    }

    public float method_13()
    {
        return this.float_4;
    }

    public spr➎ method_14()
    {
        return this.spr➎_0;
    }

    public Font method_15()
    {
        int num = 2;
        if (this.font_0 == null)
        {
            try
            {
                this.font_0 = new Font(this.method_1(), this.float_0, this.method_3() & (FontStyle.Strikeout | FontStyle.Italic | FontStyle.Bold));
            }
            catch
            {
            }
        }
        if (this.font_0 == null)
        {
            try
            {
                this.font_0 = new Font(this.method_1(), this.float_0, FontStyle.Regular);
            }
            catch
            {
            }
        }
        if (this.font_0 == null)
        {
            try
            {
                this.font_0 = new Font(this.method_1(), this.float_0, FontStyle.Bold);
            }
            catch
            {
            }
        }
        if (this.font_0 == null)
        {
            try
            {
                this.font_0 = new Font(this.method_1(), this.float_0, FontStyle.Italic);
            }
            catch
            {
                this.font_0 = new Font(BookmarkStart.b("椧堩䔫伭尯", num), this.float_0, this.method_3());
            }
        }
        return this.font_0;
    }

    public sprᝪ method_16()
    {
        return new sprᝪ(this.float_0, this.fontStyle_0, this.method_14());
    }

    public float method_2()
    {
        return this.float_0;
    }

    public FontStyle method_3()
    {
        return this.fontStyle_0;
    }

    public void method_4(FontStyle A_0)
    {
        this.fontStyle_0 = A_0;
    }

    public bool method_5()
    {
        return ((this.method_3() & FontStyle.Bold) != FontStyle.Regular);
    }

    public bool method_6()
    {
        return ((this.method_3() & FontStyle.Italic) != FontStyle.Regular);
    }

    public bool method_7()
    {
        return ((this.method_3() & FontStyle.Strikeout) != FontStyle.Regular);
    }

    public bool method_8()
    {
        return ((this.method_3() & FontStyle.Underline) != FontStyle.Regular);
    }

    public bool method_9()
    {
        return this.bool_0;
    }

    public static SizeF smethod_0(string A_0, Class308 A_1)
    {
        return new SizeF(A_1.method_14().ᜀ(A_0, A_1.float_0), A_1.method_14().ᜀ((float) A_1.method_14().ᜆ(), A_1.float_0));
    }

    public static Class308 smethod_1(string A_0, float A_1, FontStyle A_2)
    {
        Class308 class2;
        lock (hashtable_1)
        {
            string str = (string) hashtable_1[A_0 + A_2];
            if ((str != null) && (str.Length != 0))
            {
                A_0 = str;
            }
            else
            {
                spr➎ r➎ = spr᮵.ᜂ().ᜀ(A_0, A_2, A_0);
                hashtable_1[A_0 + A_2] = r➎.᜚();
                A_0 = r➎.᜚();
            }
        }
        int num = smethod_3(A_0, A_1, A_2);
        lock (hashtable_0)
        {
            class2 = (Class308) hashtable_0[num];
            if (class2 == null)
            {
                class2 = new Class308(A_0, A_1, A_2);
                hashtable_0[num] = class2;
            }
        }
        return class2;
    }

    public static Class308 smethod_2(string A_0, float A_1, bool A_2, bool A_3)
    {
        FontStyle regular = FontStyle.Regular;
        if (A_2)
        {
            regular |= FontStyle.Bold;
        }
        if (A_3)
        {
            regular |= FontStyle.Italic;
        }
        return smethod_1(A_0, A_1, regular);
    }

    private static int smethod_3(string A_0, float A_1, FontStyle A_2)
    {
        return ((A_0.GetHashCode() ^ A_1.GetHashCode()) ^ A_2);
    }

    public static StringFormat smethod_4()
    {
        return stringFormat_0;
    }
}

