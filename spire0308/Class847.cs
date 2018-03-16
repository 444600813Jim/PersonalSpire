using Spire.Doc;
using System;
using System.Collections;
using System.IO;

internal class Class847
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly string string_0;

    internal Class847(Class928 A_0)
    {
        this.string_0 = A_0.class253_0.method_5();
    }

    internal Stream method_0()
    {
        int num = 11;
        if (this.method_2())
        {
            string path = Path.Combine(this.string_0, string.Format(BookmarkStart.b("䨰̲䠴ᤶ䴸嘺䴼", num), Guid.NewGuid()));
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            this.arrayList_0.Add(new Class848((FileStream) stream, path));
            return stream;
        }
        return new MemoryStream();
    }

    internal void method_1()
    {
        foreach (Class848 class2 in this.arrayList_0)
        {
            class2.method_0().Close();
            File.Delete(class2.method_1());
        }
    }

    internal bool method_2()
    {
        return Class567.smethod_16(this.string_0);
    }

    private class Class848
    {
        private readonly FileStream fileStream_0;
        private readonly string string_0;

        internal Class848(FileStream A_0, string A_1)
        {
            this.fileStream_0 = A_0;
            this.string_0 = A_1;
        }

        public FileStream method_0()
        {
            return this.fileStream_0;
        }

        public string method_1()
        {
            return this.string_0;
        }
    }
}

