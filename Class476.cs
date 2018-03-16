using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class476
{
    private readonly Class694 class694_0;

    public Class476()
    {
        this.class694_0 = new Class694();
    }

    public Class476(Stream A_0)
    {
        this.class694_0 = new Class694();
        this.method_0(A_0);
    }

    public Class476(string A_0)
    {
        this.class694_0 = new Class694();
        using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
        {
            this.method_0(stream);
        }
    }

    private void method_0(Stream A_0)
    {
        Class296 class2 = new Class296(A_0);
        while (class2.method_2())
        {
            Class113 class3 = new Class113(smethod_1(class2.method_0()));
            this.class694_0.method_1(class3);
            class2.method_5(class3.method_3());
            class3.method_3().Position = 0L;
        }
    }

    public Class694 method_1()
    {
        return this.class694_0;
    }

    public Class113 method_2(string A_0)
    {
        return this.class694_0.method_2(A_0);
    }

    public void method_3(Stream A_0, string A_1)
    {
        Class295 class2 = new Class295(A_0);
        class2.method_2(BookmarkStart.b("嬵儷圹夻䨽㤿㉁⅃", 0x10), Encoding.ASCII.GetBytes(A_1));
        using (IEnumerator enumerator = this.class694_0.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class113 current = (Class113) enumerator.Current;
                current.method_3().Position = 0L;
                class2.method_0(smethod_0(current.method_1()), current.method_3());
            }
        }
        class2.method_3();
    }

    private static string smethod_0(string A_0)
    {
        return A_0.TrimStart(new char[] { '/' });
    }

    internal static string smethod_1(string A_0)
    {
        return (BookmarkStart.b("ĭ", 8) + A_0);
    }
}

