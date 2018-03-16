using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class313 : List<string>
{
    public bool method_0(string A_0, bool A_1)
    {
        bool flag;
        int num = 5;
        using (List<string>.Enumerator enumerator = base.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                string current = enumerator.Current;
                string b = !A_1 ? current.ToLower() : current.ToLower().Replace(BookmarkStart.b("ପ", num), string.Empty);
                if (string.Equals(A_0, b))
                {
                    goto Label_0053;
                }
            }
            return false;
        Label_0053:
            flag = true;
        }
        return flag;
    }
}

