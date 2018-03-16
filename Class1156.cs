using Spire.Compression.Zip;
using Spire.Doc;
using System;
using System.IO;

internal class Class1156
{
    private Class1156()
    {
    }

    public static byte[] smethod_0(byte[] A_0, int A_1, CompressionMethod A_2)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_1(stream, A_1, A_2);
        }
    }

    public static byte[] smethod_1(Stream A_0, int A_1, CompressionMethod A_2)
    {
        if (A_1 == 0)
        {
            A_1 = (int) A_0.Length;
        }
        MemoryStream stream2 = new MemoryStream(A_1);
        using (Stream stream = smethod_6(A_2, A_0, CompressionMode.Decompress))
        {
            Class567.smethod_8(stream, stream2);
        }
        return stream2.ToArray();
    }

    public static byte[] smethod_2(byte[] A_0, CompressionMethod A_1)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_3(stream, A_1);
        }
    }

    public static byte[] smethod_3(Stream A_0, CompressionMethod A_1)
    {
        using (MemoryStream stream = new MemoryStream())
        {
            smethod_4(A_0, stream, A_1);
            return stream.ToArray();
        }
    }

    public static int smethod_4(Stream A_0, MemoryStream A_1, CompressionMethod A_2)
    {
        int position = (int) A_1.Position;
        using (Stream stream = smethod_6(A_2, A_1, CompressionMode.Compress))
        {
            Class567.smethod_8(A_0, stream);
        }
        return (((int) A_1.Position) - position);
    }

    public static int smethod_5(byte[] A_0, int A_1, int A_2, Stream A_3, CompressionMethod A_4)
    {
        int position = (int) A_3.Position;
        using (Stream stream = smethod_6(A_4, A_3, CompressionMode.Compress))
        {
            stream.Write(A_0, A_1, A_2);
        }
        return (((int) A_3.Position) - position);
    }

    private static Stream smethod_6(CompressionMethod A_0, Stream A_1, CompressionMode A_2)
    {
        int num = 10;
        switch (A_0)
        {
            case CompressionMethod.Stored:
                return new Stream8(A_1, A_2, true);

            case CompressionMethod.Deflated:
                return new Stream0(A_1, A_2, true);
        }
        throw new InvalidOperationException(BookmarkStart.b("支就弳堵圷䴹刻ḽ⌿ⵁ⥃㙅㩇⽉㽋㵍㥏㵑㩓癕㕗㽙⡛㙝ཟ١䑣ᕥᡧཀྵཫݭᙯ᭱ᅳት噷", num));
    }
}

