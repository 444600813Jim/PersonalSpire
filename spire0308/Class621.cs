using Spire.Doc;
using System;
using System.Text.RegularExpressions;

internal class Class621
{
    private bool bool_0;
    private Regex regex_0;
    private string string_0;
    private string string_1;

    internal Class621(string A_0)
    {
        int num = 0x11;
        if (A_0 != null)
        {
            if (A_0.IndexOf(BookmarkStart.b("稶簸椺稼稾݀ੂD୆ൈ", num)) == -1)
            {
                char[] separator = new char[] { '"' };
                string[] strArray = A_0.Split(separator);
                if (strArray.Length == 1)
                {
                    this.string_1 = A_0.Trim();
                }
                else if (strArray.Length == 3)
                {
                    this.string_1 = strArray[1];
                }
                else
                {
                    this.string_1 = string.Empty;
                }
            }
            else
            {
                Match match = this.method_4().Match(A_0);
                if (match.Groups.Count > 1)
                {
                    this.string_0 = match.Groups[1].Value;
                    this.bool_0 = true;
                }
            }
        }
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal string method_1()
    {
        return this.string_1;
    }

    internal void method_2(string A_0)
    {
        this.string_1 = A_0;
    }

    internal bool method_3()
    {
        return this.bool_0;
    }

    private Regex method_4()
    {
        int num = 2;
        if (this.regex_0 == null)
        {
            this.regex_0 = new Regex(BookmarkStart.b("攧漩縫椭甯琱紳猵琷縹总䴽欿恁筃湅ፇᑉ湋ፍ筏筑癓", num));
        }
        return this.regex_0;
    }
}

