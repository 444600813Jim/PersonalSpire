using System;
using System.IO;
using System.Text;

internal class Class523
{
    private Class523()
    {
    }

    internal static Class916 smethod_0(Stream A_0, int A_1, uint A_2, int A_3)
    {
        MemoryStream stream = new MemoryStream();
        byte[] buffer = new byte[0x200];
        A_0.Position = 0x4cL;
        int count = Math.Min(A_1, 0x6d) * 4;
        A_0.Read(buffer, 0, count);
        stream.Write(buffer, 0, count);
        uint num2 = A_2;
        for (int i = 0; i < A_3; i++)
        {
            A_0.Position = Class967.smethod_0(num2, true);
            A_0.Read(buffer, 0, 0x200);
            stream.Write(buffer, 0, 0x1fc);
            num2 = (uint) (((buffer[0x1fc] | (buffer[0x1fd] << 8)) | (buffer[510] << 0x10)) | (buffer[0x1ff] << 0x18));
        }
        return new Class916(stream);
    }

    internal static void smethod_1(Stream A_0, uint A_1, int A_2, Class522 A_3)
    {
        uint num = A_1;
        BinaryWriter writer = new BinaryWriter(A_0, Encoding.Unicode);
        long position = A_0.Position;
        A_0.Position = 0x4cL;
        int num3 = Math.Min(A_2, 0x6d);
        for (int i = 0; i < num3; i++)
        {
            writer.Write(num);
            num++;
        }
        Class967.smethod_2(writer);
        A_0.Position = position;
        int num7 = A_2 - num3;
        if (num7 > 0)
        {
            A_3.uint_1 = Class967.smethod_1(A_0.Position, true);
            A_3.int_4 = 0;
            while (num7 > 0)
            {
                int num6 = Math.Min(num7, 0x7f);
                for (int j = 0; j < num6; j++)
                {
                    writer.Write(num);
                    num++;
                }
                Class967.smethod_2(writer);
                num7 -= num6;
                A_3.int_4++;
                A_0.Position -= 4L;
                if (num7 > 0)
                {
                    uint num8 = Class967.smethod_1(A_0.Position, true) + 1;
                    writer.Write(num8);
                }
                else
                {
                    writer.Write((uint) 0xfffffffe);
                }
            }
        }
        else
        {
            A_3.uint_1 = 0xfffffffe;
            A_3.int_4 = 0;
        }
    }
}

