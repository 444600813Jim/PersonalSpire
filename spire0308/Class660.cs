using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.User;
using System;
using System.Collections;
using System.IO;

internal class Class660
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly ArrayList arrayList_1 = new ArrayList();
    private readonly ArrayList arrayList_2 = new ArrayList();
    private BinaryReader binaryReader_0;
    private readonly Class932 class932_0 = new Class932();
    private Document document_0;
    private readonly Hashtable hashtable_0 = new Hashtable();

    internal void method_0(BinaryReader A_0, int A_1, Document A_2)
    {
        if (A_1 != 0)
        {
            this.binaryReader_0 = A_0;
            this.document_0 = A_2;
            int position = (int) A_0.BaseStream.Position;
            if (A_0.ReadByte() == 0xff)
            {
                int num3 = position + A_1;
                while (A_0.BaseStream.Position < num3)
                {
                    switch (((TcgType) A_0.ReadByte()))
                    {
                        case TcgType.PlfMcd:
                            this.method_1();
                            break;

                        case TcgType.PlfAcd:
                            this.method_2();
                            break;

                        case TcgType.PlfKme:
                        case TcgType.PlfKme2:
                            this.method_3();
                            break;

                        case TcgType.TcgSttbf:
                            this.method_4();
                            break;

                        case TcgType.MacroNames:
                            this.method_5();
                            break;

                        case TcgType.CTBWRAPPER:
                            this.method_7();
                            break;
                    }
                }
                this.method_8();
                this.method_9();
                this.method_10();
            }
        }
    }

    private void method_1()
    {
        int num = this.binaryReader_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_1.Add(new Class1064(this.binaryReader_0));
        }
    }

    private void method_10()
    {
        if (this.arrayList_0.Count != 0)
        {
            this.document_0.KeyMaps = new ArrayList();
            foreach (Class705 class2 in this.arrayList_0)
            {
                Class1101 class3 = class2.method_1(this.hashtable_0);
                this.document_0.KeyMaps.Add(class3);
            }
        }
    }

    private void method_2()
    {
        int num = this.binaryReader_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_2.Add(new Class769(this.binaryReader_0));
        }
    }

    private void method_3()
    {
        int num = this.binaryReader_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_0.Add(new Class705(this.binaryReader_0));
        }
    }

    private void method_4()
    {
        this.class932_0.method_5(this.binaryReader_0, (int) this.binaryReader_0.BaseStream.Position, 0x7fffffff);
    }

    private void method_5()
    {
        int num = this.binaryReader_0.ReadUInt16();
        for (int i = 0; i < num; i++)
        {
            this.method_6();
        }
    }

    private void method_6()
    {
        int num = this.binaryReader_0.ReadUInt16();
        string str = Class813.smethod_1(this.binaryReader_0, true, true);
        this.hashtable_0[num] = str;
    }

    private void method_7()
    {
        Stream baseStream = this.binaryReader_0.BaseStream;
        baseStream.Position -= 1L;
        this.document_0.AttachedToolbars = new Class661().method_0(this.binaryReader_0);
    }

    private void method_8()
    {
        if (this.arrayList_1.Count != 0)
        {
            this.document_0.VbaMacroNames = new ArrayList();
            foreach (Class1064 class2 in this.arrayList_1)
            {
                this.document_0.VbaMacroNames.Add(this.class932_0.method_2(class2.int_1));
            }
        }
    }

    private void method_9()
    {
        if (this.arrayList_2.Count != 0)
        {
            this.document_0.AllocatedCommands = new ArrayList();
            foreach (Class769 class2 in this.arrayList_2)
            {
                Class1047 class3 = !class2.bool_0 ? new Class1047(class2.fixedCommandType_0, this.class932_0.method_1(class2.int_0)) : new Class1047();
                this.document_0.AllocatedCommands.Add(class3);
            }
        }
    }
}

