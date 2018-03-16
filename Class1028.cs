using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;
using System.Text;

internal class Class1028
{
    private Class1028()
    {
    }

    internal static void smethod_0(Class363 A_0, DigitalSignatures A_1)
    {
        smethod_1(A_0, A_1);
        smethod_2(A_0, A_1);
    }

    private static void smethod_1(Class363 A_0, DigitalSignatures A_1)
    {
        MemoryStream stream = A_0.method_46(BookmarkStart.b("栶䄸嘺儼䰾⡀⑂⭄♆㵈㹊㽌⩎≐", 0x11));
        if (stream != null)
        {
            Class1132 class3 = new Class1132(stream);
            Class1089 class2 = class3.method_0();
            if (class2 != null)
            {
                foreach (string str in class2.GetKeyList())
                {
                    Class556.smethod_0(class2.method_4(str), new Class625(class3), A_1);
                }
            }
        }
    }

    private static void smethod_2(Class363 A_0, DigitalSignatures A_1)
    {
        MemoryStream stream = A_0.method_49(BookmarkStart.b("猫崭夯唱娳圵䰷伹主嬽㌿", 6));
        if (stream != null)
        {
            Stream input = stream;
            if (input != null)
            {
                BinaryReader reader = new BinaryReader(input, Encoding.Unicode);
                int num = reader.ReadInt32();
                smethod_3(reader, num);
                reader.ReadInt32();
                smethod_4(reader, A_1, new Class321(A_0.method_47().method_0()).method_4());
            }
        }
    }

    private static void smethod_3(BinaryReader A_0, int A_1)
    {
        if (A_1 > 0)
        {
            A_0.ReadInt32();
            A_0.ReadInt32();
            while (A_0.ReadInt32() != 0)
            {
                A_0.ReadInt32();
                int count = A_0.ReadInt32();
                A_0.ReadBytes(count);
            }
            A_0.ReadBytes(8);
        }
    }

    private static void smethod_4(BinaryReader A_0, DigitalSignatures A_1, byte[] A_2)
    {
        for (int i = A_0.ReadInt32(); i != 0; i = A_0.ReadInt32())
        {
            DigitalSignature signature = Class452.smethod_0(A_0, A_2);
            A_1.method_0(signature);
        }
    }
}

