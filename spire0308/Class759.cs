using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;
using System.Text;

internal class Class759
{
    private Class759()
    {
    }

    internal static void smethod_0(Class1132 A_0, DigitalSignatures A_1)
    {
        smethod_1(A_0, A_1);
        smethod_2(A_0, A_1);
    }

    private static void smethod_1(Class1132 A_0, DigitalSignatures A_1)
    {
        Class1089 class2 = A_0.method_0().method_6(BookmarkStart.b("氲䴴娶唸䠺吼堾⽀≂ㅄ㉆㭈⹊㹌", 13));
        if (class2 != null)
        {
            foreach (string str in class2.GetKeyList())
            {
                Class556.smethod_0(class2.method_4(str), new Class867(A_0), A_1);
            }
        }
    }

    private static void smethod_2(Class1132 A_0, DigitalSignatures A_1)
    {
        Stream input = A_0.method_0().method_4(BookmarkStart.b("氲䘴帶常唺尼䬾㑀ㅂ⁄㑆", 13));
        if (input != null)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Unicode);
            int num = reader.ReadInt32();
            smethod_3(reader, num);
            reader.ReadInt32();
            smethod_4(reader, A_1, new Class594(A_0.method_0()).method_4());
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
            DigitalSignature signature = Class346.smethod_0(A_0, A_2);
            A_1.method_0(signature);
        }
    }
}

