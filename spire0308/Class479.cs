using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class479
{
    private readonly BinaryReader binaryReader_0;
    private readonly BinaryReader binaryReader_1;
    private bool bool_0 = true;
    internal static bool bool_1 = false;
    private static readonly byte[] byte_0 = new byte[] { 1, 1, 2, 4, 2, 2, 0, 3 };
    private Class479 class479_0;
    private readonly Interface15 interface15_0;

    internal Class479(Interface15 A_0, BinaryReader A_1)
    {
        Stream input = new MemoryStream();
        input.SetLength(0x400L);
        this.binaryReader_0 = new BinaryReader(input);
        this.interface15_0 = A_0;
        this.binaryReader_1 = A_1;
    }

    private bool method_0(SprmCode A_0, int A_1)
    {
        return (((A_0 == SprmCode.PHugePapx) && (A_1 == 0)) || ((A_0 == SprmCode.PTableProps) && this.bool_0));
    }

    internal void method_1(byte[] A_0)
    {
        int num = 6;
        if (A_0 != null)
        {
            Stream baseStream = this.binaryReader_0.BaseStream;
            baseStream.Position = 0L;
            baseStream.Write(A_0, 0, A_0.Length);
            baseStream.Position = 0L;
            for (int i = 0; baseStream.Position < A_0.Length; i++)
            {
                int position = (int) baseStream.Position;
                SprmCode code = (SprmCode) this.binaryReader_0.ReadUInt16();
                int count = smethod_1(this.binaryReader_0, code);
                SprmType type = (SprmType) (((int) (code & 0x1c00)) >> 10);
                if (bool_1)
                {
                    byte[] buffer = new byte[count];
                    long num8 = baseStream.Position;
                    baseStream.Read(buffer, 0, count);
                    baseStream.Position = num8;
                }
                if (this.method_0(code, i))
                {
                    int num4 = this.binaryReader_0.ReadInt32();
                    Class428 class2 = Class430.smethod_0(this.binaryReader_1, num4);
                    if (this.class479_0 == null)
                    {
                        this.class479_0 = new Class479(this.interface15_0, this.binaryReader_1);
                    }
                    this.class479_0.method_2(this.bool_0);
                    this.class479_0.method_1(class2.method_2());
                    baseStream.Position = A_0.Length;
                }
                else
                {
                    int num6 = (int) baseStream.Position;
                    int num2 = num6 + count;
                    if (!this.interface15_0.imethod_0(code, type, count, this.binaryReader_0) && bool_1)
                    {
                        int num9 = Math.Min((int) (num2 - position), (int) (A_0.Length - position));
                        string.Format(BookmarkStart.b("樫䄭䔯就倳ᘵ䴷吹堻儽⌿㝁⥃⍅♇㹉⥋⩍灏őѓѕᕗ恙❛湝婟㩡ᥣ䙥ᡧ୩ṫ཭ᵯ᝱s፵੷婹ၻ᭽늇붋벏늑ꚛ뺝\udb9f\u90a1\ud9a3\u88a5", num), (int) code, count, Class85.smethod_5(A_0, position, num9));
                    }
                    if (baseStream.Position != num2)
                    {
                        if ((baseStream.Position != num6) && (baseStream.Position == num2))
                        {
                            switch (code)
                            {
                                case SprmCode.TCellShdEx:
                                case SprmCode.TCellShdExRaw:
                                case SprmCode.PChgTabs:
                                case SprmCode.CShdEx:
                                    goto Label_01CC;
                            }
                            throw new InvalidOperationException(string.Format(BookmarkStart.b("攫䀭匯崱䘳䐵崷夹䠻刽㤿扁㙃⍅⥇⹉汋ᵍOQᥓ汕⍗橙晛ٝᵟ䱡䑣⍥ၧᩩ५൭ѯ᝱ၳ噵ͷ䭹Ż剽ꁿꢇ늑꒕몙ﺛ풟잡힣袥", num), (int) code, count, baseStream.Position - num6));
                        }
                        baseStream.Position = num2;
                    }
                Label_01CC:;
                }
            }
        }
    }

    internal void method_2(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal static int smethod_0(SprmCode A_0)
    {
        int index = ((int) (A_0 & 0xe000)) >> 13;
        return byte_0[index];
    }

    private static int smethod_1(BinaryReader A_0, SprmCode A_1)
    {
        int num = 5;
        int num2 = smethod_0(A_1);
        if (num2 != 0)
        {
            return num2;
        }
        switch (A_1)
        {
            case SprmCode.TDefTable10:
            case SprmCode.TDefTable:
                return (A_0.ReadUInt16() - 1);

            case SprmCode.PChgTabsWithTolerance:
            {
                int num3 = A_0.ReadByte();
                if (num3 == 0xff)
                {
                    throw new InvalidOperationException(BookmarkStart.b("株䈬䈮䄰弲倴伶ᤸ堺䠼䰾㕀ⱂ⡄杆㵈⩊⽌潎≐❒㩔❖⩘筚⩜㙞ᕠୢ䕤፦٨ݪ࡬ᵮၰᵲᙴቶ奸Ṻ፼᱾力뾐", num));
                }
                return num3;
            }
        }
        return A_0.ReadByte();
    }
}

