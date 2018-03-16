using Spire.Doc;
using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

[Serializable]
internal class Exception1 : Exception
{
    private string string_0;

    public Exception1()
    {
    }

    public Exception1(string A_0) : base(A_0)
    {
    }

    protected Exception1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
    {
        int num = 8;
        if (A_0 != null)
        {
            this.string_0 = A_0.GetString(BookmarkStart.b("䬭帯䘱崳䈵䄷礹医倽㐿❁㱃㉅", num));
        }
    }

    public Exception1(string A_0, Class631 A_1) : base(A_0)
    {
        if (A_1 != null)
        {
            this.string_0 = A_1.method_29();
        }
    }

    public Exception1(string A_0, Exception A_1) : base(A_0, A_1)
    {
    }

    [SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        int num = 0x11;
        if (info == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("帶圸崺刼", num));
        }
        info.AddValue(BookmarkStart.b("制圸伺吼䬾㡀B⩄⥆㵈⹊㕌㭎", num), this.string_0);
        base.GetObjectData(info, context);
    }

    public string method_0()
    {
        return this.string_0;
    }
}

