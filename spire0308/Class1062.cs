using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;

internal class Class1062
{
    internal static Class266 smethod_0(BinaryReader A_0)
    {
        Class768 class2 = new Class768(A_0);
        Stream baseStream = A_0.BaseStream;
        if ((class2.method_10() < 0) || ((baseStream.Position + class2.method_10()) > baseStream.Length))
        {
            class2.method_11((int) (baseStream.Length - baseStream.Position));
        }
        Class266 class3 = smethod_1(class2);
        class3.method_1(class2, A_0);
        return class3;
    }

    private static Class266 smethod_1(Class768 A_0)
    {
        switch (A_0.method_8())
        {
            case EscherRecordType.DggContainer:
                return new Class274();

            case EscherRecordType.BstoreContainer:
                return new Class275();

            case EscherRecordType.DgContainer:
                return new Class276();

            case EscherRecordType.ShapeGroupContainer:
                return new Class277();

            case EscherRecordType.ShapeContainer:
                return new Class273();

            case EscherRecordType.SolverContainer:
                return new Class278();

            case EscherRecordType.Dgg:
                return new Class284();

            case EscherRecordType.Bse:
                return new Class268();

            case EscherRecordType.Dg:
                return new Class289();

            case EscherRecordType.ShapeGroup:
                return new Class285();

            case EscherRecordType.Shape:
                return new Class279();

            case EscherRecordType.ShapeOptions:
            case EscherRecordType.ShapeOptionsEx:
                return new Class287();

            case EscherRecordType.ClientTextbox:
                return new Class282();

            case EscherRecordType.ChildAnchor:
                return new Class291();

            case EscherRecordType.ClientAnchor:
                return new Class267();

            case EscherRecordType.ClientData:
                return new Class280();

            case EscherRecordType.ConnectorRule:
                return new Class286();

            case EscherRecordType.ArcRule:
                return new Class288();

            case EscherRecordType.CalloutRule:
                return new Class281();

            case EscherRecordType.BlipEmf:
            case EscherRecordType.BlipWmf:
            case EscherRecordType.BlipPict:
                return new Class271();

            case EscherRecordType.BlipJpeg:
            case EscherRecordType.BlipPng:
            case EscherRecordType.BlipDib:
            case EscherRecordType.BlipJpeg2:
                return new Class270();

            case EscherRecordType.RegroupItems:
                return new Class290();

            case EscherRecordType.ColorMru:
                return new Class290();

            case EscherRecordType.DeletedPspl:
                return new Class290();

            case EscherRecordType.SplitMenuColors:
                return new Class283();
        }
        return new Class290();
    }
}

