using System;

internal class Exception4 : Exception3
{
    private const string string_1 = "Fatal error";

    public Exception4() : base(BookmarkStart.b("急䤧帩䴫䈭ု圱䘳䐵圷䠹", 0))
    {
    }

    public Exception4(Exception A_0) : this(BookmarkStart.b("渧䬩堫伭尯ሱ儳䐵䨷唹主", 2), A_0)
    {
    }

    public Exception4(string A_0) : base(A_0)
    {
    }

    public Exception4(string A_0, Exception A_1) : base(A_0, A_1)
    {
    }
}

