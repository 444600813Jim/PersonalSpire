using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class1026
{
    internal static Class222 smethod_0(BinaryReader A_0, Interface57 A_1)
    {
        Class728 class2 = new Class728(A_0);
        Stream baseStream = A_0.BaseStream;
        if ((class2.method_10() < 0) || ((baseStream.Position + class2.method_10()) > baseStream.Length))
        {
            class2.method_11((int) (baseStream.Length - baseStream.Position));
        }
        Class222 class3 = smethod_1(class2, A_1);
        class3.method_1(class2, A_0, A_1);
        return class3;
    }

    private static Class222 smethod_1(Class728 A_0, Interface57 A_1)
    {
        switch (A_0.method_8())
        {
            case EsRecordType.BlipEmf:
            case EsRecordType.BlipWmf:
            case EsRecordType.BlipPict:
                return new Class224();

            case EsRecordType.BlipJpeg:
            case EsRecordType.BlipPng:
            case EsRecordType.BlipDib:
            case EsRecordType.BlipJpeg2:
                return new Class225();

            case EsRecordType.Bse:
                return new Class226();
        }
        return null;
    }
}

