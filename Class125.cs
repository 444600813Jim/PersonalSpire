using Spire.Doc;
using System;
using System.IO;

internal class Class125
{
    private const string string_0 = "Sign";

    internal static void smethod_0(Class703 A_0, BinaryReader A_1, Document A_2)
    {
        int num = 14;
        if (A_0.class597_0.class1111_60.int_1 != 0)
        {
            A_1.BaseStream.Position = A_0.class597_0.class1111_60.int_0;
            if (A_1.ReadUInt16() != 0xffff)
            {
                throw new InvalidOperationException(BookmarkStart.b("挳䐵圷吹嬻ḽ㌿⭁⍃⡅⥇㹉㥋㱍㕏籑", num));
            }
            int num4 = A_1.ReadInt16();
            A_1.ReadInt16();
            string[] strArray = new string[num4];
            for (int i = 0; i < num4; i++)
            {
                strArray[i] = Class813.smethod_1(A_1, true, false);
                A_1.ReadInt32();
            }
            for (int j = 0; j < num4; j++)
            {
                if (strArray[j] != BookmarkStart.b("朳張強吹", num))
                {
                    string str = Class813.smethod_1(A_1, true, false);
                    A_2.Variables.Add(strArray[j], str);
                }
                else
                {
                    int count = A_1.ReadUInt16() * 2;
                    A_2.VbaSignature = A_1.ReadBytes(count);
                }
            }
        }
    }

    internal static int smethod_1(Document A_0, BinaryWriter A_1)
    {
        int num = 9;
        int position = (int) A_1.BaseStream.Position;
        string[] strArray = smethod_2(A_0);
        if (strArray.Length == 0)
        {
            return 0;
        }
        A_1.Write((ushort) 0xffff);
        A_1.Write((short) strArray.Length);
        A_1.Write((short) 4);
        foreach (string str3 in strArray)
        {
            Class813.smethod_2(str3, 0x7fffffff, A_1, true, false);
            A_1.Write(0);
        }
        foreach (string str in strArray)
        {
            if (str != BookmarkStart.b("簮堰吲嬴", num))
            {
                string str2 = A_0.Variables[str];
                Class813.smethod_2(str2, 0x7fffffff, A_1, true, false);
            }
            else
            {
                A_1.Write((ushort) (A_0.VbaSignature.Length / 2));
                A_1.Write(A_0.VbaSignature);
            }
        }
        return (((int) A_1.BaseStream.Position) - position);
    }

    internal static string[] smethod_2(Document A_0)
    {
        int num = 4;
        int count = A_0.Variables.Count;
        if (A_0.VbaSignature != null)
        {
            count++;
        }
        string[] array = new string[count];
        int num3 = 0;
        foreach (string str in A_0.Variables.Items.Keys)
        {
            array[num3++] = str;
        }
        if (A_0.VbaSignature != null)
        {
            array[array.Length - 1] = BookmarkStart.b("礩䔫䤭帯", num);
        }
        Array.Sort(array, Class1134.icomparer_0);
        return array;
    }
}

