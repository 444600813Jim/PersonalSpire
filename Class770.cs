using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class770 : Interface16
{
    private readonly ArrayList arrayList_0;
    private readonly BinaryReader binaryReader_0;
    internal static bool bool_0;
    private readonly Class536 class536_0;

    internal Class770()
    {
        this.arrayList_0 = new ArrayList();
        this.class536_0 = new Class536();
    }

    internal Class770(Class703 A_0, BinaryReader A_1)
    {
        int num4 = 2;
        this.arrayList_0 = new ArrayList();
        this.class536_0 = new Class536();
        if (A_0.class597_0.class1111_33.int_1 <= 0)
        {
            this.arrayList_0.Add(new Class602(0, A_0.int_14, A_0.int_9, false));
            return;
        }
        this.binaryReader_0 = A_1;
        A_1.BaseStream.Seek((long) A_0.class597_0.class1111_33.int_0, SeekOrigin.Begin);
    Label_0079:
        switch (A_1.ReadByte())
        {
            case 1:
            {
                int num2 = A_1.ReadInt16();
                this.class536_0.Add(new Class428(A_1, num2));
                goto Label_0079;
            }
            case 2:
                this.method_2();
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("紧䐩䜫䀭弯䔱娳ᘵ帷唹主匽ℿ㙁摃⥅⹇橉㡋♍㕏牑⑓㽕㵗㥙㥛繝ᑟ͡٣੥൧䑩", num4));
    }

    private void imethod_0(BinaryReader A_0, int A_1, int A_2)
    {
        Class602 class2 = new Class602(A_0, A_1, A_2, this.class536_0);
        this.arrayList_0.Add(class2);
    }

    internal void method_0(BinaryWriter A_0)
    {
        Class147 class2 = new Class147(Class602.int_1);
        foreach (Class602 class3 in this.arrayList_0)
        {
            class2.method_5(class3.method_0().method_2(), class3.method_0().method_4(), class3);
        }
        A_0.Write((byte) 2);
        A_0.Write((uint) class2.method_20());
        class2.vmethod_1(A_0);
    }

    internal int method_1(int A_0)
    {
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            if (this.method_4(i).method_0().method_0(A_0))
            {
                return i;
            }
        }
        return -1;
    }

    private void method_2()
    {
        int num = this.binaryReader_0.ReadInt32();
        Class144.smethod_0(this.binaryReader_0, num, Class602.int_1, this, BookmarkStart.b("挲头吶弸欺帼嬾", 13));
    }

    internal int method_3(Class602 A_0)
    {
        return this.arrayList_0.Add(A_0);
    }

    internal Class602 method_4(int A_0)
    {
        return (Class602) this.arrayList_0[A_0];
    }

    internal int method_5()
    {
        return this.arrayList_0.Count;
    }
}

