using Spire.Doc;
using Spire.Doc.Documents.Converters;
using System;
using System.Collections;
using System.IO;

internal class Class490
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private BinaryWriter binaryWriter_0;
    private readonly Class932 class932_0 = new Class932();
    private Document document_0;

    internal int method_0(Document A_0, BinaryWriter A_1)
    {
        if ((((A_0.VbaMacros == null) && ((A_0.AttachedToolbars == null) || (A_0.AttachedToolbars.Length <= 0))) && ((A_0.AllocatedCommands == null) || (A_0.AllocatedCommands.Count <= 0))) && ((A_0.KeyMaps == null) || (A_0.KeyMaps.Count <= 0)))
        {
            return 0;
        }
        this.document_0 = A_0;
        this.binaryWriter_0 = A_1;
        int position = (int) A_1.BaseStream.Position;
        A_1.Write((byte) 0xff);
        this.method_1();
        this.method_2();
        this.method_3();
        this.method_4();
        this.method_5();
        this.method_6();
        A_1.Write((byte) 0x40);
        return (((int) A_1.BaseStream.Position) - position);
    }

    private void method_1()
    {
        if ((this.document_0.KeyMaps != null) && (this.document_0.KeyMaps.Count > 0))
        {
            this.binaryWriter_0.Write((byte) 4);
            this.binaryWriter_0.Write(this.document_0.KeyMaps.Count);
            foreach (Class1101 class2 in this.document_0.KeyMaps)
            {
                new Class705(class2, this.arrayList_0).method_0(this.binaryWriter_0);
            }
        }
    }

    private void method_2()
    {
        if ((this.document_0.AllocatedCommands != null) && (this.document_0.AllocatedCommands.Count > 0))
        {
            this.binaryWriter_0.Write((byte) 2);
            this.binaryWriter_0.Write(this.document_0.AllocatedCommands.Count);
            foreach (Class1047 class3 in this.document_0.AllocatedCommands)
            {
                Class769 class2 = new Class769 {
                    bool_0 = class3.fixedCommandType_0 == FixedCommandType.None
                };
                if (!class2.bool_0)
                {
                    class2.fixedCommandType_0 = class3.fixedCommandType_0;
                    class2.int_0 = this.class932_0.method_0();
                    this.class932_0.method_4(class3.byte_0);
                }
                class2.method_0(this.binaryWriter_0);
            }
        }
    }

    private void method_3()
    {
        if ((this.document_0.VbaMacroNames != null) && (this.document_0.VbaMacroNames.Count != 0))
        {
            this.binaryWriter_0.Write((byte) 1);
            this.binaryWriter_0.Write(this.document_0.VbaMacroNames.Count);
            foreach (string str in this.document_0.VbaMacroNames)
            {
                Class1064 class2 = new Class1064 {
                    int_0 = this.arrayList_0.Count
                };
                this.arrayList_0.Add(str.ToUpper());
                class2.int_1 = this.class932_0.method_0();
                this.class932_0.method_3(str);
                class2.method_0(this.binaryWriter_0);
            }
        }
    }

    private void method_4()
    {
        if (this.class932_0.method_0() != 0)
        {
            this.binaryWriter_0.Write((byte) 0x10);
            this.class932_0.method_6(this.binaryWriter_0);
        }
    }

    private void method_5()
    {
        int count = this.arrayList_0.Count;
        if (count != 0)
        {
            this.binaryWriter_0.Write((byte) 0x11);
            this.binaryWriter_0.Write((ushort) count);
            int num2 = 0;
            foreach (string str in this.arrayList_0)
            {
                this.binaryWriter_0.Write((ushort) num2++);
                Class813.smethod_2(str, 0xff, this.binaryWriter_0, true, true);
            }
        }
    }

    private void method_6()
    {
        byte[] buffer = new Class661().method_1(this.document_0.AttachedToolbars, (int) this.binaryWriter_0.BaseStream.Position);
        if (buffer != null)
        {
            this.binaryWriter_0.Write(buffer);
        }
    }
}

