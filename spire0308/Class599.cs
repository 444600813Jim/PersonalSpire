using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections;
using System.IO;

internal class Class599
{
    private static readonly byte[] byte_0 = new byte[10];
    private static readonly byte[] byte_1 = new byte[0x18];
    private const string string_0 = "Times New Roman";

    private Class599()
    {
    }

    internal static void smethod_0(Class52 A_0, Class703 A_1, BinaryReader A_2, BinaryReader A_3)
    {
        A_2.BaseStream.Position = A_1.class597_0.class1111_15.int_0;
        smethod_1(A_0, A_2, A_1.class597_0.class1111_15.int_1);
        A_2.BaseStream.Position = A_1.class597_0.class1111_61.int_0;
        smethod_2(A_0, A_2, A_1.class597_0.class1111_61.int_1, A_3);
    }

    private static void smethod_1(Class52 A_0, BinaryReader A_1, int A_2)
    {
        if (A_2 != 0)
        {
            int num2 = A_1.ReadInt32();
            for (int i = 0; i < num2; i++)
            {
                A_0.method_11(smethod_8(A_1));
            }
        }
    }

    private static void smethod_2(Class52 A_0, BinaryReader A_1, int A_2, BinaryReader A_3)
    {
        if (A_2 != 0)
        {
            A_1.ReadInt16();
            int num5 = A_1.ReadInt16();
            A_1.ReadInt32();
            A_1.ReadInt16();
            for (int i = 0; i < num5; i++)
            {
                int num = A_1.ReadInt32();
                int num2 = A_1.ReadInt16();
                EmbeddedFontStyle style = ((EmbeddedFontStyle) A_1.ReadInt16()) & EmbeddedFontStyle.BoldItalic;
                bool flag = A_1.ReadUInt32() != uint.MaxValue;
                A_3.BaseStream.Position = num;
                int count = A_3.ReadInt32();
                A_3.BaseStream.Position = num;
                A_0.method_6(num2).method_56(A_3.ReadBytes(count), EmbeddedFontFormat.EmbeddedOpenType, style, flag);
            }
        }
    }

    internal static void smethod_3(Class52 A_0, Class703 A_1, BinaryWriter A_2, BinaryWriter A_3)
    {
        A_1.class597_0.class1111_15.int_0 = (int) A_2.BaseStream.Position;
        A_1.class597_0.class1111_15.int_1 = smethod_4(A_0, A_2);
        A_1.class597_0.class1111_61.int_0 = (int) A_2.BaseStream.Position;
        A_1.class597_0.class1111_61.int_1 = smethod_5(A_0, A_2, A_3);
    }

    private static int smethod_4(Class52 A_0, BinaryWriter A_1)
    {
        int position = (int) A_1.BaseStream.Position;
        A_1.Write(A_0.method_4());
        using (IEnumerator enumerator = A_0.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Form4 current = (Form4) enumerator.Current;
                smethod_9(current, A_1);
            }
        }
        return (((int) A_1.BaseStream.Position) - position);
    }

    private static int smethod_5(Class52 A_0, BinaryWriter A_1, BinaryWriter A_2)
    {
        int position = (int) A_1.BaseStream.Position;
        A_1.Write((short) 0);
        A_1.Write((short) smethod_7(A_0));
        A_1.Write(0x40);
        A_1.Write((short) 0x1a);
        int num2 = 0;
        for (int i = 0; i < A_0.method_4(); i++)
        {
            Class827[] classArray2 = A_0.method_6(i).method_52(EmbeddedFontFormat.EmbeddedOpenType);
            if (classArray2 != null)
            {
                foreach (Class827 class2 in classArray2)
                {
                    if (class2 != null)
                    {
                        smethod_6(class2, i, num2, A_1, A_2);
                        num2++;
                    }
                }
            }
        }
        return (((int) A_1.BaseStream.Position) - position);
    }

    private static void smethod_6(Class827 A_0, int A_1, int A_2, BinaryWriter A_3, BinaryWriter A_4)
    {
        A_3.Write((int) A_4.BaseStream.Position);
        A_3.Write((short) A_1);
        A_3.Write((short) A_0.method_2());
        A_3.Write(A_0.method_3() ? ((uint) A_2) : uint.MaxValue);
        A_4.Write(A_0.method_0());
    }

    private static int smethod_7(Class52 A_0)
    {
        int num = 0;
        using (IEnumerator enumerator = A_0.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class827[] classArray2 = ((Form4) enumerator.Current).method_52(EmbeddedFontFormat.EmbeddedOpenType);
                if (classArray2 != null)
                {
                    Class827[] classArray = classArray2;
                    for (int i = 0; i < classArray.Length; i++)
                    {
                        if (classArray[i] != null)
                        {
                            num++;
                        }
                    }
                }
            }
        }
        return num;
    }

    private static Form4 smethod_8(BinaryReader A_0)
    {
        string str;
        int num = 1;
        Form4 form = new Form4();
        int position = (int) A_0.BaseStream.Position;
        int num3 = A_0.ReadByte();
        int num4 = A_0.ReadByte();
        form.method_42(((FontPitch) num4) & (FontPitch.Variable | FontPitch.Fixed));
        form.method_44((num4 & 4) != 0);
        form.method_40((FontFamily) ((num4 & 0x70) >> 4));
        form.method_48(A_0.ReadInt16());
        form.method_38(A_0.ReadByte());
        A_0.ReadByte();
        form.method_36(new byte[10]);
        A_0.Read(form.method_35(), 0, form.method_35().Length);
        form.method_46(new byte[0x18]);
        A_0.Read(form.method_45(), 0, form.method_45().Length);
        int num5 = ((int) A_0.BaseStream.Position) - position;
        if (num3 > 0x29)
        {
            int num6 = (num3 - num5) + 1;
            str = Class813.smethod_5(A_0, num6);
        }
        else
        {
            str = "";
        }
        int index = str.IndexOf('\0');
        if (index < 0)
        {
            if (!Class567.smethod_16(str))
            {
                str = BookmarkStart.b("猦䀨䘪䠬尮ᄰ紲倴䀶ᤸ椺刼刾⁀ⵂ", num);
            }
            form.method_57(str);
            return form;
        }
        string str2 = str.Substring(0, index);
        string str3 = str.Substring(index + 1);
        str2 = str2.Replace(BookmarkStart.b("Ⱖ┨", num), string.Empty);
        if (!Class567.smethod_16(str2))
        {
            str2 = Class567.smethod_16(str3) ? str3 : BookmarkStart.b("猦䀨䘪䠬尮ᄰ紲倴䀶ᤸ椺刼刾⁀ⵂ", num);
        }
        form.method_57(str2);
        form.method_34(str3);
        return form;
    }

    private static void smethod_9(Form4 A_0, BinaryWriter A_1)
    {
        int position = (int) A_1.BaseStream.Position;
        A_1.Write((byte) 0);
        int num2 = 0;
        num2 = (int) (FontPitch.Default | A_0.method_41());
        num2 |= A_0.method_43() ? 4 : 0;
        num2 |= ((int) A_0.method_39()) << 4;
        A_1.Write((byte) num2);
        A_1.Write((short) A_0.method_47());
        A_1.Write((byte) A_0.method_37());
        int num3 = Class567.smethod_16(A_0.method_33()) ? (A_0.method_31().Length + 1) : 0;
        A_1.Write((byte) num3);
        A_1.Write((A_0.method_35() != null) ? A_0.method_35() : byte_0);
        A_1.Write((A_0.method_45() != null) ? A_0.method_45() : byte_1);
        Class813.smethod_8(A_0.method_31(), A_1);
        if (Class567.smethod_16(A_0.method_33()))
        {
            Class813.smethod_8(A_0.method_33(), A_1);
        }
        int num4 = (int) A_1.BaseStream.Position;
        int num5 = (num4 - position) - 1;
        A_1.BaseStream.Seek((long) position, SeekOrigin.Begin);
        A_1.Write((byte) num5);
        A_1.BaseStream.Seek((long) num4, SeekOrigin.Begin);
    }
}

