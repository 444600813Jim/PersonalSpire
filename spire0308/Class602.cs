using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class602 : Interface35
{
    internal readonly bool bool_0;
    internal readonly bool bool_1;
    private readonly Class428 class428_0;
    private readonly Class760 class760_0;
    internal readonly int int_0;
    internal static int int_1 = 8;
    private static readonly SprmCode[] sprmCode_0;

    static Class602()
    {
        SprmCode[] codeArray = new SprmCode[0x7f];
        codeArray[4] = SprmCode.PIncLvl;
        codeArray[5] = SprmCode.PJc;
        codeArray[6] = SprmCode.PFSideBySide;
        codeArray[7] = SprmCode.PFKeep;
        codeArray[8] = SprmCode.PFKeepFollow;
        codeArray[9] = SprmCode.PFPageBreakBefore;
        codeArray[10] = SprmCode.PBrcl;
        codeArray[11] = SprmCode.PBrcp;
        codeArray[12] = SprmCode.PIlvl;
        codeArray[14] = SprmCode.PFNoLineNumb;
        codeArray[0x18] = SprmCode.PFInTable;
        codeArray[0x19] = SprmCode.PFTtp;
        codeArray[0x1d] = SprmCode.PPc;
        codeArray[0x25] = SprmCode.PWr;
        codeArray[0x2c] = SprmCode.PFNoAutoHyph;
        codeArray[50] = SprmCode.PFLockAnchor;
        codeArray[0x33] = SprmCode.PFWidowControl;
        codeArray[0x35] = SprmCode.PFKinsoku;
        codeArray[0x36] = SprmCode.PFWordWrap;
        codeArray[0x37] = SprmCode.PFOverflowPunct;
        codeArray[0x38] = SprmCode.PFTopLinePunct;
        codeArray[0x39] = SprmCode.PFAutoSpaceDE;
        codeArray[0x3a] = SprmCode.PFAutoSpaceDN;
        codeArray[0x3d] = SprmCode.PISnapBaseLine;
        codeArray[0x41] = SprmCode.CFStrike;
        codeArray[0x42] = SprmCode.CFRMarkIns;
        codeArray[0x43] = SprmCode.CFFldVanish;
        codeArray[0x47] = SprmCode.CFData;
        codeArray[0x4b] = SprmCode.CFOle2;
        codeArray[0x4d] = SprmCode.CHighlight;
        codeArray[0x4e] = SprmCode.CFEmboss;
        codeArray[0x4f] = SprmCode.CSfxText;
        codeArray[0x53] = SprmCode.CPlain;
        codeArray[0x55] = SprmCode.CFBold;
        codeArray[0x56] = SprmCode.CFItalic;
        codeArray[0x57] = SprmCode.CFStrike;
        codeArray[0x58] = SprmCode.CFOutline;
        codeArray[0x59] = SprmCode.CFShadow;
        codeArray[90] = SprmCode.CFSmallCaps;
        codeArray[0x5b] = SprmCode.CFCaps;
        codeArray[0x5c] = SprmCode.CFVanish;
        codeArray[0x5e] = SprmCode.CKul;
        codeArray[0x62] = SprmCode.CIco;
        codeArray[100] = SprmCode.CHpsInc;
        codeArray[0x66] = SprmCode.CHpsPosAdj;
        codeArray[0x68] = SprmCode.CIss;
        codeArray[0x73] = SprmCode.CFDStrike;
        codeArray[0x74] = SprmCode.CFImprint;
        codeArray[0x75] = SprmCode.CFSpec;
        codeArray[0x76] = SprmCode.CFObj;
        codeArray[0x77] = SprmCode.PicBrcl;
        codeArray[120] = SprmCode.POutLvl;
        sprmCode_0 = codeArray;
    }

    internal Class602(int A_0, int A_1, int A_2, bool A_3)
    {
        this.class760_0 = new Class760(A_0, A_1);
        this.int_0 = A_2;
        this.bool_0 = A_3;
        this.bool_1 = false;
        this.class428_0 = new Class428();
    }

    internal Class602(BinaryReader A_0, int A_1, int A_2, Class536 A_3)
    {
        this.class760_0 = new Class760(A_1, A_2);
        int num = A_0.ReadInt16();
        this.bool_1 = (num & 1) != 0;
        int num2 = A_0.ReadInt32();
        this.bool_0 = (num2 & 0x40000000) == 0;
        this.int_0 = this.bool_0 ? num2 : ((num2 & 0x3fffffff) / 2);
        int num3 = A_0.ReadInt16();
        if ((num3 & 1) == 0)
        {
            int index = (num3 & 0xfe) >> 1;
            int num5 = (int) sprmCode_0[index];
            byte num6 = (byte) num5;
            byte num7 = (byte) (num5 >> 8);
            byte num8 = (byte) (num3 >> 8);
            this.class428_0 = new Class428(new byte[] { num6, num7, num8 });
        }
        else
        {
            int num9 = (num3 & 0xfffe) >> 1;
            this.class428_0 = A_3.method_0(num9);
        }
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) 0);
        if (this.bool_0)
        {
            A_0.Write(this.int_0);
        }
        else
        {
            int num = (this.int_0 * 2) | 0x40000000;
            A_0.Write(num);
        }
        A_0.Write((ushort) 0);
    }

    internal Class760 method_0()
    {
        return this.class760_0;
    }

    internal Class428 method_1()
    {
        return this.class428_0;
    }
}

