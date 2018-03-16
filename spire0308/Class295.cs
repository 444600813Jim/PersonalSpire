using Spire.Compression;
using System;
using System.IO;

internal class Class295
{
    private readonly Class771 class771_0 = new Class771();
    private readonly Stream stream_0;

    public Class295(Stream A_0)
    {
        this.stream_0 = A_0;
    }

    public void method_0(string A_0, Stream A_1)
    {
        this.class771_0.method_14(A_0, A_1, false, FileAttributes.Archive);
    }

    public void method_1(int A_0)
    {
        this.class771_0.method_6((CompressionLevel) A_0);
    }

    public void method_2(string A_0, byte[] A_1)
    {
        this.class771_0.method_15(A_0, A_1);
    }

    public void method_3()
    {
        this.class771_0.method_25(this.stream_0, false);
    }
}

