using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Documents.Converters.BinaryDoc.User;
using System;
using System.Collections;
using System.IO;

internal class Class705
{
    internal int int_0;
    internal int int_1;
    internal int int_2;
    internal KeyCombination keyCombination_0;

    internal Class705(BinaryReader A_0)
    {
        A_0.ReadInt16();
        A_0.ReadInt16();
        this.int_0 = A_0.ReadUInt16();
        this.int_1 = A_0.ReadUInt16();
        this.keyCombination_0 = (KeyCombination) A_0.ReadInt16();
        this.int_2 = A_0.ReadInt32();
    }

    internal Class705(Class1101 A_0, ArrayList A_1)
    {
        int num = 12;
        this.int_0 = A_0.int_2;
        this.int_1 = (A_0.int_3 == 0) ? 0xff : A_0.int_3;
        switch (A_0.mapType_0)
        {
            case MapType.None:
                this.keyCombination_0 = KeyCombination.Cid;
                this.int_2 = -1;
                return;

            case MapType.Mask:
                this.keyCombination_0 = KeyCombination.Mask;
                return;

            case MapType.AllocatedCommand:
                this.keyCombination_0 = KeyCombination.Cid;
                this.int_2 = (A_0.int_4 << 0x10) | 3;
                return;

            case MapType.FixedCommand:
                this.keyCombination_0 = KeyCombination.Cid;
                this.int_2 = ((A_0.int_5 << 0x10) | (((int) A_0.fixedCommandType_0) << 3)) | 1;
                return;

            case MapType.Macro:
                this.keyCombination_0 = KeyCombination.Cid;
                this.int_2 = (A_1.Count << 0x10) | 2;
                A_1.Add(A_0.string_0);
                return;

            case MapType.InsertCharacter:
                this.keyCombination_0 = KeyCombination.Char;
                this.int_2 = A_0.int_6;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("朱娳崵嘷唹䬻倽怿⥁⅃㽅╇⭉㱋湍⑏⭑⑓㍕癗", num));
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write((short) 0);
        A_0.Write((short) 0);
        A_0.Write((short) this.int_0);
        A_0.Write((short) this.int_1);
        A_0.Write((short) this.keyCombination_0);
        A_0.Write(this.int_2);
    }

    internal Class1101 method_1(Hashtable A_0)
    {
        int num = 0x10;
        Class1101 class2 = new Class1101 {
            int_2 = this.int_0,
            int_3 = (this.int_1 == 0xff) ? 0 : this.int_1
        };
        switch (this.keyCombination_0)
        {
            case KeyCombination.Cid:
                switch ((((Command) this.int_2) & Command.Nil))
                {
                    case Command.Fci:
                        class2.mapType_0 = MapType.FixedCommand;
                        class2.fixedCommandType_0 = ((FixedCommandType) (this.int_2 >> 3)) & ((FixedCommandType) 0x1fff);
                        class2.int_5 = (this.int_2 >> 0x10) & 0xffff;
                        return class2;

                    case Command.Macro:
                        class2.mapType_0 = MapType.Macro;
                        class2.string_0 = (string) A_0[(this.int_2 >> 0x10) & 0xffff];
                        return class2;

                    case Command.Allocated:
                        class2.mapType_0 = MapType.AllocatedCommand;
                        class2.int_4 = (this.int_2 >> 0x10) & 0xffff;
                        return class2;

                    case Command.Nil:
                        class2.mapType_0 = MapType.None;
                        return class2;
                }
                break;

            case KeyCombination.Char:
                class2.mapType_0 = MapType.InsertCharacter;
                class2.int_6 = this.int_2;
                return class2;

            case KeyCombination.Mask:
                class2.mapType_0 = MapType.Mask;
                return class2;

            default:
                throw new InvalidOperationException(BookmarkStart.b("挵嘷儹刻儽㜿ⱁ摃ⵅ㱇橉㩋⽍㱏❑ㅓ硕", num));
        }
        throw new InvalidOperationException(BookmarkStart.b("挵嘷儹刻儽㜿ⱁ摃╅╇㹉汋㡍ㅏ㹑⅓㍕癗", num));
    }
}

