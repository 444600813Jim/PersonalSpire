using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class1046
{
    private readonly ArrayList arrayList_0;
    private Guid guid_0;
    private const int int_0 = 20;

    public Class1046()
    {
        this.arrayList_0 = new ArrayList();
        this.guid_0 = Guid.Empty;
    }

    public Class1046(Stream A_0)
    {
        int num5 = 11;
        this.arrayList_0 = new ArrayList();
        this.guid_0 = Guid.Empty;
        A_0.Position = 0L;
        BinaryReader reader = new BinaryReader(A_0, Encoding.Unicode);
        reader.ReadUInt16();
        if (reader.ReadUInt16() != 0)
        {
            throw new NotSupportedException(BookmarkStart.b("爰刲嬴夶嘸伺ᴼ䴾⑀≂⅄杆㥈㥊≌㽎㑐⅒⅔⹖祘⡚㡜⭞䅠੢୤䝦ᵨͪѬᱮ兰ᕲᩴնᑸ᩺ॼ兾", num5));
        }
        reader.ReadUInt32();
        this.guid_0 = new Guid(reader.ReadBytes(0x10));
        int num2 = reader.ReadInt32();
        Guid[] guidArray = new Guid[num2];
        int[] numArray = new int[num2];
        for (int i = 0; i < num2; i++)
        {
            guidArray[i] = new Guid(reader.ReadBytes(0x10));
            numArray[i] = reader.ReadInt32();
        }
        for (int j = 0; j < num2; j++)
        {
            reader.BaseStream.Position = numArray[j];
            this.arrayList_0.Add(new Class520(guidArray[j], reader));
        }
    }

    public ArrayList method_0()
    {
        return this.arrayList_0;
    }

    public void method_1(Stream A_0)
    {
        BinaryWriter writer = new BinaryWriter(A_0, Encoding.Unicode);
        writer.Write((ushort) 0xfffe);
        writer.Write((ushort) 0);
        writer.Write((uint) 0x20105);
        writer.Write(this.guid_0.ToByteArray());
        writer.Write(this.arrayList_0.Count);
        int num = ((int) A_0.Position) + (20 * this.arrayList_0.Count);
        MemoryStream stream = new MemoryStream();
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            Class520 class2 = (Class520) this.arrayList_0[i];
            writer.Write(class2.method_1().ToByteArray());
            int num3 = num + ((int) stream.Length);
            writer.Write(num3);
            byte[] buffer = class2.method_3();
            stream.Write(buffer, 0, buffer.Length);
        }
        A_0.Write(stream.GetBuffer(), 0, (int) stream.Length);
    }
}

