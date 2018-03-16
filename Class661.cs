using Spire.Doc.Documents.Converters.BinaryDoc.User;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class661
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private BinaryReader binaryReader_0;

    internal byte[] method_0(BinaryReader A_0)
    {
        this.binaryReader_0 = A_0;
        int position = (int) this.binaryReader_0.BaseStream.Position;
        this.method_3();
        int count = ((int) this.binaryReader_0.BaseStream.Position) - position;
        this.binaryReader_0.BaseStream.Position = position;
        byte[] buffer = this.binaryReader_0.ReadBytes(count);
        this.method_2(buffer, position, 0);
        return buffer;
    }

    internal byte[] method_1(byte[] A_0, int A_1)
    {
        if ((A_0 == null) || (A_0.Length == 0))
        {
            return null;
        }
        this.binaryReader_0 = new BinaryReader(new MemoryStream(A_0));
        this.method_3();
        byte[] buffer = new byte[A_0.Length];
        for (int i = 0; i < A_0.Length; i++)
        {
            buffer[i] = A_0[i];
        }
        this.method_2(buffer, 0, A_1);
        return buffer;
    }

    private void method_10()
    {
        TBCBSFlags flags = (TBCBSFlags) this.binaryReader_0.ReadByte();
        if ((flags & TBCBSFlags.CustomBitmap) != TBCBSFlags.ButtonUp)
        {
            this.method_11();
            this.method_11();
        }
        if ((flags & TBCBSFlags.CustomBtnFace) != TBCBSFlags.ButtonUp)
        {
            this.binaryReader_0.ReadUInt16();
        }
        if ((flags & TBCBSFlags.Accelerator) != TBCBSFlags.ButtonUp)
        {
            this.method_14();
        }
    }

    private void method_11()
    {
        int num = this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadBytes(num - 10);
    }

    private void method_12()
    {
        if (this.binaryReader_0.ReadInt32() == 1)
        {
            this.method_14();
        }
    }

    private void method_13()
    {
        int num = this.binaryReader_0.ReadInt16();
        for (int i = 0; i < num; i++)
        {
            this.method_14();
        }
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        this.method_14();
    }

    private string method_14()
    {
        int num = this.binaryReader_0.ReadByte();
        byte[] bytes = this.binaryReader_0.ReadBytes(num * 2);
        return Encoding.Unicode.GetString(bytes);
    }

    private void method_2(byte[] A_0, int A_1, int A_2)
    {
        if (this.arrayList_0.Count != 0)
        {
            MemoryStream input = new MemoryStream(A_0);
            BinaryReader reader = new BinaryReader(input);
            BinaryWriter writer = new BinaryWriter(input);
            foreach (int num in this.arrayList_0)
            {
                int num2 = num - A_1;
                reader.BaseStream.Position = num2;
                int num4 = (reader.ReadInt32() - A_1) + A_2;
                reader.BaseStream.Position = num2;
                writer.Write(num4);
            }
        }
    }

    private void method_3()
    {
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        int num = this.binaryReader_0.ReadInt16();
        int count = this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadBytes(count);
        for (int i = 0; i < num; i++)
        {
            this.method_4();
        }
    }

    private void method_4()
    {
        int num = this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadInt16();
        int num2 = this.binaryReader_0.ReadInt16();
        if (num == 0)
        {
            this.method_6();
        }
        else
        {
            for (int i = 0; i < num2; i++)
            {
                this.method_5();
            }
        }
    }

    private void method_5()
    {
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadInt32();
        int position = (int) this.binaryReader_0.BaseStream.Position;
        this.binaryReader_0.ReadInt32();
        int num2 = this.binaryReader_0.ReadUInt16();
        this.binaryReader_0.ReadUInt16();
        if ((num2 & 1) != 0)
        {
            this.arrayList_0.Add(position);
        }
    }

    private void method_6()
    {
        Class813.smethod_1(this.binaryReader_0, true, false);
        int num = this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadBytes(num - 4);
        int num2 = this.binaryReader_0.ReadInt32();
        for (int i = 0; i < num2; i++)
        {
            this.method_7();
        }
    }

    private void method_7()
    {
        Class438 class2 = new Class438(this.binaryReader_0);
        if ((class2.int_0 != 1) && (class2.int_0 != 0x1051))
        {
            this.binaryReader_0.ReadInt32();
        }
        if (class2.controlType_0 != ControlType.ActiveX)
        {
            this.method_8();
            switch (class2.controlType_0)
            {
                case ControlType.Button:
                case ControlType.ExpandingGrid:
                    this.method_10();
                    return;

                case ControlType.Edit:
                case ControlType.DropDown:
                case ControlType.ComboBox:
                case ControlType.SplitDropDown:
                case ControlType.GraphicDropDown:
                case ControlType.GraphicCombo:
                    if (class2.int_0 == 1)
                    {
                        this.method_13();
                    }
                    return;

                case (ControlType.ComboBox | ControlType.Button):
                case ControlType.OCXDropDown:
                case ((ControlType) 8):
                case (ControlType.Popup | ControlType.Button):
                case ControlType.Label:
                case (ControlType.ExpandingGrid | ControlType.Button):
                case ControlType.Grid:
                case ControlType.Gauge:
                    return;

                case ControlType.Popup:
                case ControlType.ButtonPopup:
                case ControlType.SplitButtonPopup:
                case ControlType.SplitButtonMRUPopup:
                    this.method_12();
                    return;
            }
        }
    }

    private void method_8()
    {
        TBCGIFlags flags = (TBCGIFlags) this.binaryReader_0.ReadByte();
        if ((flags & TBCGIFlags.SaveText) != 0)
        {
            this.method_14();
        }
        if ((flags & TBCGIFlags.SaveMiscUIStrings) != 0)
        {
            this.method_14();
            this.method_14();
        }
        if ((flags & TBCGIFlags.SaveMiscCustom) != 0)
        {
            this.method_9();
        }
    }

    private void method_9()
    {
        this.method_14();
        this.binaryReader_0.ReadInt32();
        this.method_14();
        this.method_14();
        this.method_14();
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadByte();
    }
}

