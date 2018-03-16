using Spire.Doc;
using Spire.Doc.Converters.Sgml;
using System;
using System.Collections;
using System.Globalization;

internal class Class638
{
    private ArrayList arrayList_0;
    private bool bool_0;
    private Class638 class638_0;
    private GroupType groupType_0;
    private Occurrence occurrence_0;

    public Class638(Class638 A_0)
    {
        this.class638_0 = A_0;
        this.arrayList_0 = new ArrayList();
        this.groupType_0 = GroupType.None;
        this.occurrence_0 = Occurrence.Required;
    }

    public Occurrence method_0()
    {
        return this.occurrence_0;
    }

    public bool method_1()
    {
        return (this.bool_0 && (this.arrayList_0.Count == 0));
    }

    public Class638 method_2()
    {
        return this.class638_0;
    }

    public void method_3(Class638 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    public void method_4(string A_0)
    {
        if (string.Equals(A_0, BookmarkStart.b("ጯ戱眳爵礷渹紻", 10), StringComparison.OrdinalIgnoreCase))
        {
            this.bool_0 = true;
        }
        else
        {
            this.arrayList_0.Add(A_0);
        }
    }

    public void method_5(char A_0)
    {
        int num = 0x10;
        if (!this.bool_0 && (this.arrayList_0.Count == 0))
        {
            throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("笵儷䤹伻圽⸿╁摃㉅❇ⅉ⥋⁍灏けㅓさ㝗⡙㥛繝͟ൡ੣ࡥ൧३ᡫŭɯ剱即൵䡷ݹ孻偽", num), new object[] { A_0 }));
        }
        GroupType none = GroupType.None;
        switch (A_0)
        {
            case '&':
                none = GroupType.And;
                break;

            case ',':
                none = GroupType.Sequence;
                break;

            case '|':
                none = GroupType.Or;
                break;
        }
        if ((this.groupType_0 != GroupType.None) && (this.groupType_0 != none))
        {
            throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("电圷吹刻嬽⌿㙁⭃㑅桇浉㝋繍ⵏ畑瑓㽕⭗穙㕛そ͟ൡ੣ᕥŧᥩᡫ୭ṯٱ味ŵᅷ๹ᑻ幽ﭿ뎁旅ꚅﮍ벑", num), new object[] { A_0, this.groupType_0.ToString() }));
        }
        this.groupType_0 = none;
    }

    public void method_6(char A_0)
    {
        Occurrence required = Occurrence.Required;
        char ch = A_0;
        switch (ch)
        {
            case '*':
                required = Occurrence.ZeroOrMore;
                break;

            case '+':
                required = Occurrence.OneOrMore;
                break;

            default:
                if (ch == '?')
                {
                    required = Occurrence.Optional;
                }
                break;
        }
        this.occurrence_0 = required;
    }

    public bool method_7(string A_0, Class640 A_1)
    {
        bool flag;
        int num = 0x10;
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刵䰷帹", num));
        }
        foreach (object obj3 in this.arrayList_0)
        {
            if ((obj3 is string) && string.Equals((string) obj3, A_0, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                object current = enumerator.Current;
                string str = current as string;
                if (str != null)
                {
                    Class636 class2 = A_1.method_3(str);
                    if (((class2 != null) && class2.method_3()) && class2.method_6(A_0, A_1))
                    {
                        return true;
                    }
                }
                else
                {
                    Class638 class3 = (Class638) current;
                    if (class3.method_7(A_0, A_1))
                    {
                        goto Label_00D9;
                    }
                }
            }
            return false;
        Label_00D9:
            flag = true;
        }
        return flag;
    }
}

