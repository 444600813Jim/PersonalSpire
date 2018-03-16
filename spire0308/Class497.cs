using System;
using System.Collections.Generic;

internal class Class497 : IDisposable
{
    private List<Class498> list_0 = new List<Class498>();

    public List<Class498> method_0()
    {
        return this.list_0;
    }

    void IDisposable.Dispose()
    {
        if (this.list_0 != null)
        {
            int num = 0;
            int count = this.list_0.Count;
            while (num < count)
            {
                Class498 class2 = this.list_0[num];
                if (class2 != null)
                {
                    class2.System.IDisposable.Dispose();
                }
                this.list_0[num] = null;
                num++;
            }
            this.list_0.Clear();
            this.list_0 = null;
        }
    }
}

