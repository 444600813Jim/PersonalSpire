using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;
using System.Reflection;
using System.Text;

[DefaultMember("Item")]
internal class Class272 : Class266
{
    private Class1063 class1063_0;

    internal Class272()
    {
        this.class1063_0 = new Class1063();
    }

    internal Class272(EscherRecordType A_0)
    {
        this.class1063_0 = new Class1063();
        base.method_3().method_3(true);
        base.method_3().method_9(A_0);
    }

    internal void method_10(int A_0, Class266 A_1)
    {
        this.class1063_0.method_1(A_0, A_1);
    }

    internal Class266 method_4(EscherRecordType A_0)
    {
        for (int i = 0; i < this.class1063_0.Count; i++)
        {
            Class266 class2 = this.class1063_0.method_0(i);
            if (class2.method_3().method_8() == A_0)
            {
                return class2;
            }
        }
        return null;
    }

    internal Class272 method_5(Class266 A_0)
    {
        for (int i = 0; i < this.class1063_0.Count; i++)
        {
            Class266 class3 = this.class1063_0.method_0(i);
            if (class3 == A_0)
            {
                return this;
            }
            if (class3 is Class272)
            {
                Class272 class2 = ((Class272) class3).method_5(A_0);
                if (class2 != null)
                {
                    return class2;
                }
            }
        }
        return null;
    }

    internal Class266 method_6(Type A_0)
    {
        for (int i = 0; i < this.class1063_0.Count; i++)
        {
            Class266 class2 = this.class1063_0.method_0(i);
            if (class2.GetType() == A_0)
            {
                return class2;
            }
        }
        return null;
    }

    internal Class1063 method_7()
    {
        return this.class1063_0;
    }

    internal int method_8()
    {
        return this.class1063_0.Count;
    }

    internal Class266 method_9(int A_0)
    {
        return this.class1063_0.method_0(A_0);
    }

    public override string System.Object.ToString()
    {
        int num = 13;
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat(BookmarkStart.b("䠲Դ䨶ᤸ栺䤼帾㍀㝂佄", 13), base.GetType().Name);
        builder.AppendFormat(BookmarkStart.b("怲倴嬶弸ĺᴼ䐾煀㹂佄", 13), base.System.Object.ToString());
        for (int i = 0; i < this.class1063_0.Count; i++)
        {
            builder.AppendFormat(BookmarkStart.b("䠲Դ䨶㌸", num), this.class1063_0.method_0(i).ToString());
        }
        builder.AppendFormat(BookmarkStart.b("䠲Դ䨶ᤸ縺匼嬾䭀", num), base.GetType().Name);
        return builder.ToString();
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.class1063_0.method_2(A_0, base.method_3().method_10());
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        this.class1063_0.method_3(A_0);
    }
}

